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
			bool b_()
			{
				var w_ = period?.unit;
				var x_ = context.Operators.Equal(w_, "h");

				return (x_ ?? false);
			};
			bool c_()
			{
				var y_ = period?.unit;
				var z_ = context.Operators.Equal(y_, "min");

				return (z_ ?? false);
			};
			bool d_()
			{
				var aa_ = period?.unit;
				var ab_ = context.Operators.Equal(aa_, "s");

				return (ab_ ?? false);
			};
			bool e_()
			{
				var ac_ = period?.unit;
				var ad_ = context.Operators.Equal(ac_, "d");

				return (ad_ ?? false);
			};
			bool f_()
			{
				var ae_ = period?.unit;
				var af_ = context.Operators.Equal(ae_, "wk");

				return (af_ ?? false);
			};
			bool g_()
			{
				var ag_ = period?.unit;
				var ah_ = context.Operators.Equal(ag_, "mo");

				return (ah_ ?? false);
			};
			bool h_()
			{
				var ai_ = period?.unit;
				var aj_ = context.Operators.Equal(ai_, "a");

				return (aj_ ?? false);
			};
			bool i_()
			{
				var ak_ = period?.unit;
				var al_ = context.Operators.Equal(ak_, "hour");

				return (al_ ?? false);
			};
			bool j_()
			{
				var am_ = period?.unit;
				var an_ = context.Operators.Equal(am_, "minute");

				return (an_ ?? false);
			};
			bool k_()
			{
				var ao_ = period?.unit;
				var ap_ = context.Operators.Equal(ao_, "second");

				return (ap_ ?? false);
			};
			bool l_()
			{
				var aq_ = period?.unit;
				var ar_ = context.Operators.Equal(aq_, "day");

				return (ar_ ?? false);
			};
			bool m_()
			{
				var as_ = period?.unit;
				var at_ = context.Operators.Equal(as_, "week");

				return (at_ ?? false);
			};
			bool n_()
			{
				var au_ = period?.unit;
				var av_ = context.Operators.Equal(au_, "month");

				return (av_ ?? false);
			};
			bool o_()
			{
				var aw_ = period?.unit;
				var ax_ = context.Operators.Equal(aw_, "year");

				return (ax_ ?? false);
			};
			bool p_()
			{
				var ay_ = period?.unit;
				var az_ = context.Operators.Equal(ay_, "hours");

				return (az_ ?? false);
			};
			bool q_()
			{
				var ba_ = period?.unit;
				var bb_ = context.Operators.Equal(ba_, "minutes");

				return (bb_ ?? false);
			};
			bool r_()
			{
				var bc_ = period?.unit;
				var bd_ = context.Operators.Equal(bc_, "seconds");

				return (bd_ ?? false);
			};
			bool s_()
			{
				var be_ = period?.unit;
				var bf_ = context.Operators.Equal(be_, "days");

				return (bf_ ?? false);
			};
			bool t_()
			{
				var bg_ = period?.unit;
				var bh_ = context.Operators.Equal(bg_, "weeks");

				return (bh_ ?? false);
			};
			bool u_()
			{
				var bi_ = period?.unit;
				var bj_ = context.Operators.Equal(bi_, "months");

				return (bj_ ?? false);
			};
			bool v_()
			{
				var bk_ = period?.unit;
				var bl_ = context.Operators.Equal(bk_, "years");

				return (bl_ ?? false);
			};
			if (b_())
			{
				var bm_ = context.Operators.ConvertIntegerToDecimal(frequency);
				var bn_ = period?.value;
				var bo_ = context.Operators.Divide(24.0m, bn_);
				var bp_ = context.Operators.Multiply(bm_, bo_);

				return bp_;
			}
			else if (c_())
			{
				var bq_ = context.Operators.ConvertIntegerToDecimal(frequency);
				var br_ = period?.value;
				var bs_ = context.Operators.Divide(24.0m, br_);
				var bt_ = context.Operators.Multiply(bq_, bs_);
				var bu_ = context.Operators.ConvertIntegerToDecimal(60);
				var bv_ = context.Operators.Multiply(bt_, bu_);

				return bv_;
			}
			else if (d_())
			{
				var bw_ = context.Operators.ConvertIntegerToDecimal(frequency);
				var bx_ = period?.value;
				var by_ = context.Operators.Divide(24.0m, bx_);
				var bz_ = context.Operators.Multiply(bw_, by_);
				var ca_ = context.Operators.ConvertIntegerToDecimal(60);
				var cb_ = context.Operators.Multiply(bz_, ca_);
				var cd_ = context.Operators.Multiply(cb_, ca_);

				return cd_;
			}
			else if (e_())
			{
				var ce_ = context.Operators.ConvertIntegerToDecimal(frequency);
				var cf_ = period?.value;
				var cg_ = context.Operators.Divide(24.0m, cf_);
				var ch_ = context.Operators.Multiply(ce_, cg_);
				var ci_ = context.Operators.ConvertIntegerToDecimal(24);
				var cj_ = context.Operators.Divide(ch_, ci_);

				return cj_;
			}
			else if (f_())
			{
				var ck_ = context.Operators.ConvertIntegerToDecimal(frequency);
				var cl_ = period?.value;
				var cm_ = context.Operators.Divide(24.0m, cl_);
				var cn_ = context.Operators.Multiply(ck_, cm_);
				var co_ = context.Operators.Multiply(24, 7);
				var cp_ = context.Operators.ConvertIntegerToDecimal(co_);
				var cq_ = context.Operators.Divide(cn_, cp_);

				return cq_;
			}
			else if (g_())
			{
				var cr_ = context.Operators.ConvertIntegerToDecimal(frequency);
				var cs_ = period?.value;
				var ct_ = context.Operators.Divide(24.0m, cs_);
				var cu_ = context.Operators.Multiply(cr_, ct_);
				var cv_ = context.Operators.Multiply(24, 30);
				var cw_ = context.Operators.ConvertIntegerToDecimal(cv_);
				var cx_ = context.Operators.Divide(cu_, cw_);

				return cx_;
			}
			else if (h_())
			{
				var cy_ = context.Operators.ConvertIntegerToDecimal(frequency);
				var cz_ = period?.value;
				var da_ = context.Operators.Divide(24.0m, cz_);
				var db_ = context.Operators.Multiply(cy_, da_);
				var dc_ = context.Operators.Multiply(24, 365);
				var dd_ = context.Operators.ConvertIntegerToDecimal(dc_);
				var de_ = context.Operators.Divide(db_, dd_);

				return de_;
			}
			else if (i_())
			{
				var df_ = context.Operators.ConvertIntegerToDecimal(frequency);
				var dg_ = period?.value;
				var dh_ = context.Operators.Divide(24.0m, dg_);
				var di_ = context.Operators.Multiply(df_, dh_);

				return di_;
			}
			else if (j_())
			{
				var dj_ = context.Operators.ConvertIntegerToDecimal(frequency);
				var dk_ = period?.value;
				var dl_ = context.Operators.Divide(24.0m, dk_);
				var dm_ = context.Operators.Multiply(dj_, dl_);
				var dn_ = context.Operators.ConvertIntegerToDecimal(60);
				var do_ = context.Operators.Multiply(dm_, dn_);

				return do_;
			}
			else if (k_())
			{
				var dp_ = context.Operators.ConvertIntegerToDecimal(frequency);
				var dq_ = period?.value;
				var dr_ = context.Operators.Divide(24.0m, dq_);
				var ds_ = context.Operators.Multiply(dp_, dr_);
				var dt_ = context.Operators.ConvertIntegerToDecimal(60);
				var du_ = context.Operators.Multiply(ds_, dt_);
				var dw_ = context.Operators.Multiply(du_, dt_);

				return dw_;
			}
			else if (l_())
			{
				var dx_ = context.Operators.ConvertIntegerToDecimal(frequency);
				var dy_ = period?.value;
				var dz_ = context.Operators.Divide(24.0m, dy_);
				var ea_ = context.Operators.Multiply(dx_, dz_);
				var eb_ = context.Operators.ConvertIntegerToDecimal(24);
				var ec_ = context.Operators.Divide(ea_, eb_);

				return ec_;
			}
			else if (m_())
			{
				var ed_ = context.Operators.ConvertIntegerToDecimal(frequency);
				var ee_ = period?.value;
				var ef_ = context.Operators.Divide(24.0m, ee_);
				var eg_ = context.Operators.Multiply(ed_, ef_);
				var eh_ = context.Operators.Multiply(24, 7);
				var ei_ = context.Operators.ConvertIntegerToDecimal(eh_);
				var ej_ = context.Operators.Divide(eg_, ei_);

				return ej_;
			}
			else if (n_())
			{
				var ek_ = context.Operators.ConvertIntegerToDecimal(frequency);
				var el_ = period?.value;
				var em_ = context.Operators.Divide(24.0m, el_);
				var en_ = context.Operators.Multiply(ek_, em_);
				var eo_ = context.Operators.Multiply(24, 30);
				var ep_ = context.Operators.ConvertIntegerToDecimal(eo_);
				var eq_ = context.Operators.Divide(en_, ep_);

				return eq_;
			}
			else if (o_())
			{
				var er_ = context.Operators.ConvertIntegerToDecimal(frequency);
				var es_ = period?.value;
				var et_ = context.Operators.Divide(24.0m, es_);
				var eu_ = context.Operators.Multiply(er_, et_);
				var ev_ = context.Operators.Multiply(24, 365);
				var ew_ = context.Operators.ConvertIntegerToDecimal(ev_);
				var ex_ = context.Operators.Divide(eu_, ew_);

				return ex_;
			}
			else if (p_())
			{
				var ey_ = context.Operators.ConvertIntegerToDecimal(frequency);
				var ez_ = period?.value;
				var fa_ = context.Operators.Divide(24.0m, ez_);
				var fb_ = context.Operators.Multiply(ey_, fa_);

				return fb_;
			}
			else if (q_())
			{
				var fc_ = context.Operators.ConvertIntegerToDecimal(frequency);
				var fd_ = period?.value;
				var fe_ = context.Operators.Divide(24.0m, fd_);
				var ff_ = context.Operators.Multiply(fc_, fe_);
				var fg_ = context.Operators.ConvertIntegerToDecimal(60);
				var fh_ = context.Operators.Multiply(ff_, fg_);

				return fh_;
			}
			else if (r_())
			{
				var fi_ = context.Operators.ConvertIntegerToDecimal(frequency);
				var fj_ = period?.value;
				var fk_ = context.Operators.Divide(24.0m, fj_);
				var fl_ = context.Operators.Multiply(fi_, fk_);
				var fm_ = context.Operators.ConvertIntegerToDecimal(60);
				var fn_ = context.Operators.Multiply(fl_, fm_);
				var fp_ = context.Operators.Multiply(fn_, fm_);

				return fp_;
			}
			else if (s_())
			{
				var fq_ = context.Operators.ConvertIntegerToDecimal(frequency);
				var fr_ = period?.value;
				var fs_ = context.Operators.Divide(24.0m, fr_);
				var ft_ = context.Operators.Multiply(fq_, fs_);
				var fu_ = context.Operators.ConvertIntegerToDecimal(24);
				var fv_ = context.Operators.Divide(ft_, fu_);

				return fv_;
			}
			else if (t_())
			{
				var fw_ = context.Operators.ConvertIntegerToDecimal(frequency);
				var fx_ = period?.value;
				var fy_ = context.Operators.Divide(24.0m, fx_);
				var fz_ = context.Operators.Multiply(fw_, fy_);
				var ga_ = context.Operators.Multiply(24, 7);
				var gb_ = context.Operators.ConvertIntegerToDecimal(ga_);
				var gc_ = context.Operators.Divide(fz_, gb_);

				return gc_;
			}
			else if (u_())
			{
				var gd_ = context.Operators.ConvertIntegerToDecimal(frequency);
				var ge_ = period?.value;
				var gf_ = context.Operators.Divide(24.0m, ge_);
				var gg_ = context.Operators.Multiply(gd_, gf_);
				var gh_ = context.Operators.Multiply(24, 30);
				var gi_ = context.Operators.ConvertIntegerToDecimal(gh_);
				var gj_ = context.Operators.Divide(gg_, gi_);

				return gj_;
			}
			else if (v_())
			{
				var gk_ = context.Operators.ConvertIntegerToDecimal(frequency);
				var gl_ = period?.value;
				var gm_ = context.Operators.Divide(24.0m, gl_);
				var gn_ = context.Operators.Multiply(gk_, gm_);
				var go_ = context.Operators.Multiply(24, 365);
				var gp_ = context.Operators.ConvertIntegerToDecimal(go_);
				var gq_ = context.Operators.Divide(gn_, gp_);

				return gq_;
			}
			else
			{
				var gr_ = this.ErrorLevel();
				var gs_ = context.Operators.Concatenate("Unknown unit ", (period?.unit ?? ""));
				var gt_ = context.Operators.Message<object>(null, "CMDLogic.ToDaily.UnknownUnit", gr_, gs_);

				return (decimal?)gt_;
			}
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
			}
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
					var h_ = R?.DosageInstruction;
					var i_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)h_);
					var j_ = i_?.Timing;
					var k_ = j_?.Repeat;
					var l_ = k_?.Bounds;
					var m_ = FHIRHelpers_4_3_000.ToValue(l_);
					var n_ = context.Operators.Start((m_ as CqlInterval<CqlDateTime>));
					var o_ = context.Operators.DateFrom(n_);
					var p_ = R?.AuthoredOnElement;
					var q_ = context.Operators.Convert<CqlDateTime>(p_);
					var r_ = context.Operators.DateFrom(q_);
					var s_ = R?.DispenseRequest;
					var t_ = s_?.ValidityPeriod;
					var u_ = FHIRHelpers_4_3_000.ToInterval(t_);
					var v_ = context.Operators.Start(u_);
					var w_ = context.Operators.DateFrom(v_);
					var x_ = context.Operators.Not((bool?)(((o_ ?? r_) ?? w_) is null));
					var z_ = s_?.ExpectedSupplyDuration;
					var aa_ = FHIRHelpers_4_3_000.ToQuantity((Quantity)z_);
					var ab_ = context.Operators.ConvertQuantity(aa_, "d");
					var ac_ = ab_?.value;
					var ae_ = s_?.Quantity;
					var af_ = FHIRHelpers_4_3_000.ToQuantity(ae_);
					var ag_ = af_?.value;
					var ai_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)h_);
					var aj_ = ai_?.DoseAndRate;
					var ak_ = context.Operators.SingletonFrom<Dosage.DoseAndRateComponent>((IEnumerable<Dosage.DoseAndRateComponent>)aj_);
					var al_ = ak_?.Dose;
					var am_ = FHIRHelpers_4_3_000.ToValue(al_);
					var an_ = context.Operators.End((am_ as CqlInterval<CqlQuantity>));
					var ap_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)h_);
					var aq_ = ap_?.DoseAndRate;
					var ar_ = context.Operators.SingletonFrom<Dosage.DoseAndRateComponent>((IEnumerable<Dosage.DoseAndRateComponent>)aq_);
					var as_ = ar_?.Dose;
					var at_ = FHIRHelpers_4_3_000.ToValue(as_);
					var au_ = (an_ ?? (at_ as CqlQuantity))?.value;
					var aw_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)h_);
					var ax_ = aw_?.Timing;
					var ay_ = ax_?.Repeat;
					var az_ = ay_?.FrequencyMaxElement;
					var ba_ = az_?.Value;
					var bc_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)h_);
					var bd_ = bc_?.Timing;
					var be_ = bd_?.Repeat;
					var bf_ = be_?.FrequencyElement;
					var bg_ = bf_?.Value;
					var bi_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)h_);
					var bj_ = bi_?.Timing;
					var bk_ = bj_?.Repeat;
					var bl_ = bk_?.PeriodElement;
					var bm_ = bl_?.Value;
					var bo_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)h_);
					var bp_ = bo_?.Timing;
					var bq_ = bp_?.Repeat;
					var br_ = bq_?.PeriodUnitElement;
					var bs_ = br_?.Value;
					var bt_ = context.Operators.Convert<Code<Timing.UnitsOfTime>>(bs_);
					var bu_ = context.Operators.Convert<string>(bt_);
					var bv_ = this.Quantity(bm_, bu_);
					var bw_ = this.ToDaily((ba_ ?? bg_), bv_);
					var by_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)h_);
					var bz_ = by_?.Timing;
					var ca_ = bz_?.Repeat;
					var cb_ = ca_?.TimeOfDayElement;
					var cc_ = context.Operators.LateBoundProperty<IEnumerable<CqlTime>>(cb_, "value");
					var cd_ = context.Operators.Count<CqlTime>(cc_);
					var ce_ = context.Operators.ConvertIntegerToDecimal(cd_);
					var cf_ = context.Operators.Multiply(au_, ((bw_ ?? ce_) ?? 1.0m));
					var cg_ = context.Operators.Divide(ag_, cf_);
					var ci_ = s_?.NumberOfRepeatsAllowedElement;
					var cj_ = ci_?.Value;
					var ck_ = context.Operators.Add(1, (cj_ ?? 0));
					var cl_ = context.Operators.ConvertIntegerToDecimal(ck_);
					var cm_ = context.Operators.Multiply((ac_ ?? cg_), cl_);
					var cn_ = context.Operators.Not((bool?)(cm_ is null));
					var co_ = context.Operators.And(x_, cn_);

					return (co_ ?? false);
				};
				bool g_()
				{
					var cp_ = R?.DosageInstruction;
					var cq_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)cp_);
					var cr_ = cq_?.Timing;
					var cs_ = cr_?.Repeat;
					var ct_ = cs_?.Bounds;
					var cu_ = FHIRHelpers_4_3_000.ToValue(ct_);
					var cv_ = context.Operators.Start((cu_ as CqlInterval<CqlDateTime>));
					var cw_ = context.Operators.DateFrom(cv_);
					var cx_ = R?.AuthoredOnElement;
					var cy_ = context.Operators.Convert<CqlDateTime>(cx_);
					var cz_ = context.Operators.DateFrom(cy_);
					var da_ = R?.DispenseRequest;
					var db_ = da_?.ValidityPeriod;
					var dc_ = FHIRHelpers_4_3_000.ToInterval(db_);
					var dd_ = context.Operators.Start(dc_);
					var de_ = context.Operators.DateFrom(dd_);
					var df_ = context.Operators.Not((bool?)(((cw_ ?? cz_) ?? de_) is null));
					var dh_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)cp_);
					var di_ = dh_?.Timing;
					var dj_ = di_?.Repeat;
					var dk_ = dj_?.Bounds;
					var dl_ = FHIRHelpers_4_3_000.ToValue(dk_);
					var dm_ = (dl_ as CqlInterval<CqlDateTime>)?.high;
					var dn_ = context.Operators.Not((bool?)(dm_ is null));
					var do_ = context.Operators.And(df_, dn_);

					return (do_ ?? false);
				};
				if (f_())
				{
					var dp_ = R?.DosageInstruction;
					var dq_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)dp_);
					var dr_ = dq_?.Timing;
					var ds_ = dr_?.Repeat;
					var dt_ = ds_?.Bounds;
					var du_ = FHIRHelpers_4_3_000.ToValue(dt_);
					var dv_ = context.Operators.Start((du_ as CqlInterval<CqlDateTime>));
					var dw_ = context.Operators.DateFrom(dv_);
					var dx_ = R?.AuthoredOnElement;
					var dy_ = context.Operators.Convert<CqlDateTime>(dx_);
					var dz_ = context.Operators.DateFrom(dy_);
					var ea_ = R?.DispenseRequest;
					var eb_ = ea_?.ValidityPeriod;
					var ec_ = FHIRHelpers_4_3_000.ToInterval(eb_);
					var ed_ = context.Operators.Start(ec_);
					var ee_ = context.Operators.DateFrom(ed_);
					var eg_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)dp_);
					var eh_ = eg_?.Timing;
					var ei_ = eh_?.Repeat;
					var ej_ = ei_?.Bounds;
					var ek_ = FHIRHelpers_4_3_000.ToValue(ej_);
					var el_ = context.Operators.Start((ek_ as CqlInterval<CqlDateTime>));
					var em_ = context.Operators.DateFrom(el_);
					var eo_ = context.Operators.Convert<CqlDateTime>(dx_);
					var ep_ = context.Operators.DateFrom(eo_);
					var er_ = ea_?.ValidityPeriod;
					var es_ = FHIRHelpers_4_3_000.ToInterval(er_);
					var et_ = context.Operators.Start(es_);
					var eu_ = context.Operators.DateFrom(et_);
					var ew_ = ea_?.ExpectedSupplyDuration;
					var ex_ = FHIRHelpers_4_3_000.ToQuantity((Quantity)ew_);
					var ey_ = context.Operators.ConvertQuantity(ex_, "d");
					var ez_ = ey_?.value;
					var fb_ = ea_?.Quantity;
					var fc_ = FHIRHelpers_4_3_000.ToQuantity(fb_);
					var fd_ = fc_?.value;
					var ff_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)dp_);
					var fg_ = ff_?.DoseAndRate;
					var fh_ = context.Operators.SingletonFrom<Dosage.DoseAndRateComponent>((IEnumerable<Dosage.DoseAndRateComponent>)fg_);
					var fi_ = fh_?.Dose;
					var fj_ = FHIRHelpers_4_3_000.ToValue(fi_);
					var fk_ = context.Operators.End((fj_ as CqlInterval<CqlQuantity>));
					var fm_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)dp_);
					var fn_ = fm_?.DoseAndRate;
					var fo_ = context.Operators.SingletonFrom<Dosage.DoseAndRateComponent>((IEnumerable<Dosage.DoseAndRateComponent>)fn_);
					var fp_ = fo_?.Dose;
					var fq_ = FHIRHelpers_4_3_000.ToValue(fp_);
					var fr_ = (fk_ ?? (fq_ as CqlQuantity))?.value;
					var ft_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)dp_);
					var fu_ = ft_?.Timing;
					var fv_ = fu_?.Repeat;
					var fw_ = fv_?.FrequencyMaxElement;
					var fx_ = fw_?.Value;
					var fz_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)dp_);
					var ga_ = fz_?.Timing;
					var gb_ = ga_?.Repeat;
					var gc_ = gb_?.FrequencyElement;
					var gd_ = gc_?.Value;
					var gf_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)dp_);
					var gg_ = gf_?.Timing;
					var gh_ = gg_?.Repeat;
					var gi_ = gh_?.PeriodElement;
					var gj_ = gi_?.Value;
					var gl_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)dp_);
					var gm_ = gl_?.Timing;
					var gn_ = gm_?.Repeat;
					var go_ = gn_?.PeriodUnitElement;
					var gp_ = go_?.Value;
					var gq_ = context.Operators.Convert<Code<Timing.UnitsOfTime>>(gp_);
					var gr_ = context.Operators.Convert<string>(gq_);
					var gs_ = this.Quantity(gj_, gr_);
					var gt_ = this.ToDaily((fx_ ?? gd_), gs_);
					var gv_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)dp_);
					var gw_ = gv_?.Timing;
					var gx_ = gw_?.Repeat;
					var gy_ = gx_?.TimeOfDayElement;
					var gz_ = context.Operators.LateBoundProperty<IEnumerable<CqlTime>>(gy_, "value");
					var ha_ = context.Operators.Count<CqlTime>(gz_);
					var hb_ = context.Operators.ConvertIntegerToDecimal(ha_);
					var hc_ = context.Operators.Multiply(fr_, ((gt_ ?? hb_) ?? 1.0m));
					var hd_ = context.Operators.Divide(fd_, hc_);
					var hf_ = ea_?.NumberOfRepeatsAllowedElement;
					var hg_ = hf_?.Value;
					var hh_ = context.Operators.Add(1, (hg_ ?? 0));
					var hi_ = context.Operators.ConvertIntegerToDecimal(hh_);
					var hj_ = context.Operators.Multiply((ez_ ?? hd_), hi_);
					var hk_ = context.Operators.ConvertIntegerToDecimal(1);
					var hl_ = context.Operators.Subtract(hj_, hk_);
					var hm_ = this.Quantity(hl_, "day");
					var hn_ = context.Operators.Add(((em_ ?? ep_) ?? eu_), hm_);
					var ho_ = context.Operators.Interval(((dw_ ?? dz_) ?? ee_), hn_, true, true);

					return ho_;
				}
				else if (g_())
				{
					var hp_ = R?.DosageInstruction;
					var hq_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)hp_);
					var hr_ = hq_?.Timing;
					var hs_ = hr_?.Repeat;
					var ht_ = hs_?.Bounds;
					var hu_ = FHIRHelpers_4_3_000.ToValue(ht_);
					var hv_ = context.Operators.Start((hu_ as CqlInterval<CqlDateTime>));
					var hw_ = context.Operators.DateFrom(hv_);
					var hx_ = R?.AuthoredOnElement;
					var hy_ = context.Operators.Convert<CqlDateTime>(hx_);
					var hz_ = context.Operators.DateFrom(hy_);
					var ia_ = R?.DispenseRequest;
					var ib_ = ia_?.ValidityPeriod;
					var ic_ = FHIRHelpers_4_3_000.ToInterval(ib_);
					var id_ = context.Operators.Start(ic_);
					var ie_ = context.Operators.DateFrom(id_);
					var ig_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)hp_);
					var ih_ = ig_?.Timing;
					var ii_ = ih_?.Repeat;
					var ij_ = ii_?.Bounds;
					var ik_ = FHIRHelpers_4_3_000.ToValue(ij_);
					var il_ = context.Operators.End((ik_ as CqlInterval<CqlDateTime>));
					var im_ = context.Operators.DateFrom(il_);
					var in_ = context.Operators.Interval(((hw_ ?? hz_) ?? ie_), im_, true, true);

					return in_;
				}
				else
				{
					return null;
				}
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
					var g_ = D?.WhenHandedOverElement;
					var h_ = context.Operators.Convert<CqlDateTime>(g_);
					var i_ = context.Operators.DateFrom(h_);
					var j_ = D?.WhenPreparedElement;
					var k_ = context.Operators.Convert<CqlDateTime>(j_);
					var l_ = context.Operators.DateFrom(k_);
					var m_ = context.Operators.Not((bool?)((i_ ?? l_) is null));
					var n_ = D?.DaysSupply;
					var o_ = FHIRHelpers_4_3_000.ToQuantity(n_);
					var p_ = context.Operators.ConvertQuantity(o_, "d");
					var q_ = p_?.value;
					var r_ = D?.Quantity;
					var s_ = FHIRHelpers_4_3_000.ToQuantity(r_);
					var t_ = s_?.value;
					var u_ = D?.DosageInstruction;
					var v_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)u_);
					var w_ = v_?.DoseAndRate;
					var x_ = context.Operators.SingletonFrom<Dosage.DoseAndRateComponent>((IEnumerable<Dosage.DoseAndRateComponent>)w_);
					var y_ = x_?.Dose;
					var z_ = FHIRHelpers_4_3_000.ToValue(y_);
					var aa_ = context.Operators.End((z_ as CqlInterval<CqlQuantity>));
					var ac_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)u_);
					var ad_ = ac_?.DoseAndRate;
					var ae_ = context.Operators.SingletonFrom<Dosage.DoseAndRateComponent>((IEnumerable<Dosage.DoseAndRateComponent>)ad_);
					var af_ = ae_?.Dose;
					var ag_ = FHIRHelpers_4_3_000.ToValue(af_);
					var ah_ = (aa_ ?? (ag_ as CqlQuantity))?.value;
					var aj_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)u_);
					var ak_ = aj_?.Timing;
					var al_ = ak_?.Repeat;
					var am_ = al_?.FrequencyMaxElement;
					var an_ = am_?.Value;
					var ap_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)u_);
					var aq_ = ap_?.Timing;
					var ar_ = aq_?.Repeat;
					var as_ = ar_?.FrequencyElement;
					var at_ = as_?.Value;
					var av_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)u_);
					var aw_ = av_?.Timing;
					var ax_ = aw_?.Repeat;
					var ay_ = ax_?.PeriodElement;
					var az_ = ay_?.Value;
					var bb_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)u_);
					var bc_ = bb_?.Timing;
					var bd_ = bc_?.Repeat;
					var be_ = bd_?.PeriodUnitElement;
					var bf_ = be_?.Value;
					var bg_ = context.Operators.Convert<Code<Timing.UnitsOfTime>>(bf_);
					var bh_ = context.Operators.Convert<string>(bg_);
					var bi_ = this.Quantity(az_, bh_);
					var bj_ = this.ToDaily((an_ ?? at_), bi_);
					var bl_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)u_);
					var bm_ = bl_?.Timing;
					var bn_ = bm_?.Repeat;
					var bo_ = bn_?.TimeOfDayElement;
					var bp_ = context.Operators.LateBoundProperty<IEnumerable<CqlTime>>(bo_, "value");
					var bq_ = context.Operators.Count<CqlTime>(bp_);
					var br_ = context.Operators.ConvertIntegerToDecimal(bq_);
					var bs_ = context.Operators.Multiply(ah_, ((bj_ ?? br_) ?? 1.0m));
					var bt_ = context.Operators.Divide(t_, bs_);
					var bu_ = context.Operators.Not((bool?)((q_ ?? bt_) is null));
					var bv_ = context.Operators.And(m_, bu_);

					return (bv_ ?? false);
				};
				if (f_())
				{
					var bw_ = D?.WhenHandedOverElement;
					var bx_ = context.Operators.Convert<CqlDateTime>(bw_);
					var by_ = context.Operators.DateFrom(bx_);
					var bz_ = D?.WhenPreparedElement;
					var ca_ = context.Operators.Convert<CqlDateTime>(bz_);
					var cb_ = context.Operators.DateFrom(ca_);
					var cd_ = context.Operators.Convert<CqlDateTime>(bw_);
					var ce_ = context.Operators.DateFrom(cd_);
					var cg_ = context.Operators.Convert<CqlDateTime>(bz_);
					var ch_ = context.Operators.DateFrom(cg_);
					var ci_ = D?.DaysSupply;
					var cj_ = FHIRHelpers_4_3_000.ToQuantity(ci_);
					var ck_ = context.Operators.ConvertQuantity(cj_, "d");
					var cl_ = ck_?.value;
					var cm_ = D?.Quantity;
					var cn_ = FHIRHelpers_4_3_000.ToQuantity(cm_);
					var co_ = cn_?.value;
					var cp_ = D?.DosageInstruction;
					var cq_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)cp_);
					var cr_ = cq_?.DoseAndRate;
					var cs_ = context.Operators.SingletonFrom<Dosage.DoseAndRateComponent>((IEnumerable<Dosage.DoseAndRateComponent>)cr_);
					var ct_ = cs_?.Dose;
					var cu_ = FHIRHelpers_4_3_000.ToValue(ct_);
					var cv_ = context.Operators.End((cu_ as CqlInterval<CqlQuantity>));
					var cx_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)cp_);
					var cy_ = cx_?.DoseAndRate;
					var cz_ = context.Operators.SingletonFrom<Dosage.DoseAndRateComponent>((IEnumerable<Dosage.DoseAndRateComponent>)cy_);
					var da_ = cz_?.Dose;
					var db_ = FHIRHelpers_4_3_000.ToValue(da_);
					var dc_ = (cv_ ?? (db_ as CqlQuantity))?.value;
					var de_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)cp_);
					var df_ = de_?.Timing;
					var dg_ = df_?.Repeat;
					var dh_ = dg_?.FrequencyMaxElement;
					var di_ = dh_?.Value;
					var dk_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)cp_);
					var dl_ = dk_?.Timing;
					var dm_ = dl_?.Repeat;
					var dn_ = dm_?.FrequencyElement;
					var do_ = dn_?.Value;
					var dq_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)cp_);
					var dr_ = dq_?.Timing;
					var ds_ = dr_?.Repeat;
					var dt_ = ds_?.PeriodElement;
					var du_ = dt_?.Value;
					var dw_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)cp_);
					var dx_ = dw_?.Timing;
					var dy_ = dx_?.Repeat;
					var dz_ = dy_?.PeriodUnitElement;
					var ea_ = dz_?.Value;
					var eb_ = context.Operators.Convert<Code<Timing.UnitsOfTime>>(ea_);
					var ec_ = context.Operators.Convert<string>(eb_);
					var ed_ = this.Quantity(du_, ec_);
					var ee_ = this.ToDaily((di_ ?? do_), ed_);
					var eg_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)cp_);
					var eh_ = eg_?.Timing;
					var ei_ = eh_?.Repeat;
					var ej_ = ei_?.TimeOfDayElement;
					var ek_ = context.Operators.LateBoundProperty<IEnumerable<CqlTime>>(ej_, "value");
					var el_ = context.Operators.Count<CqlTime>(ek_);
					var em_ = context.Operators.ConvertIntegerToDecimal(el_);
					var en_ = context.Operators.Multiply(dc_, ((ee_ ?? em_) ?? 1.0m));
					var eo_ = context.Operators.Divide(co_, en_);
					var ep_ = context.Operators.ConvertIntegerToDecimal(1);
					var eq_ = context.Operators.Subtract((cl_ ?? eo_), ep_);
					var er_ = this.Quantity(eq_, "day");
					var es_ = context.Operators.Add((ce_ ?? ch_), er_);
					var et_ = context.Operators.Interval((by_ ?? cb_), es_, true, true);

					return et_;
				}
				else
				{
					return null;
				}
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
					var g_ = Administration?.Effective;
					var h_ = FHIRHelpers_4_3_000.ToValue(g_);
					var i_ = context.Operators.Start((h_ as CqlInterval<CqlDateTime>));
					var j_ = context.Operators.DateFrom(i_);
					var k_ = context.Operators.Not((bool?)(j_ is null));
					var l_ = Administration?.Medication;
					var m_ = FHIRHelpers_4_3_000.ToValue(l_);
					var n_ = this.TherapeuticDuration((m_ as CqlConcept));
					var o_ = context.Operators.Not((bool?)(n_ is null));
					var p_ = context.Operators.And(k_, o_);

					return (p_ ?? false);
				};
				if (f_())
				{
					var q_ = Administration?.Effective;
					var r_ = FHIRHelpers_4_3_000.ToValue(q_);
					var s_ = context.Operators.Start((r_ as CqlInterval<CqlDateTime>));
					var t_ = context.Operators.DateFrom(s_);
					var v_ = FHIRHelpers_4_3_000.ToValue(q_);
					var w_ = context.Operators.Start((v_ as CqlInterval<CqlDateTime>));
					var x_ = context.Operators.DateFrom(w_);
					var y_ = Administration?.Medication;
					var z_ = FHIRHelpers_4_3_000.ToValue(y_);
					var aa_ = this.TherapeuticDuration((z_ as CqlConcept));
					var ab_ = context.Operators.Add(x_, aa_);
					var ac_ = context.Operators.ConvertIntegerToQuantity(1);
					var ad_ = context.Operators.Subtract(ab_, ac_);
					var ae_ = context.Operators.Interval(t_, ad_, true, true);

					return ae_;
				}
				else
				{
					return null;
				}
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
			}
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
			var h_ = context.Operators.Union<CqlInterval<CqlDate>>(R, (g_ as IEnumerable<CqlInterval<CqlDate>>));

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
			}
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
		var j_ = context.Operators.Union<CqlInterval<CqlDate>>(d_, i_);
		var k_ = this.CumulativeDuration(j_);

		return k_;
	}

}
