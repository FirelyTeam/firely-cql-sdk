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
			bool b_()
			{
				string w_ = period?.unit;
				bool? x_ = context.Operators.Equal(w_, "h");

				return (x_ ?? false);
			};
			bool c_()
			{
				string y_ = period?.unit;
				bool? z_ = context.Operators.Equal(y_, "min");

				return (z_ ?? false);
			};
			bool d_()
			{
				string aa_ = period?.unit;
				bool? ab_ = context.Operators.Equal(aa_, "s");

				return (ab_ ?? false);
			};
			bool e_()
			{
				string ac_ = period?.unit;
				bool? ad_ = context.Operators.Equal(ac_, "d");

				return (ad_ ?? false);
			};
			bool f_()
			{
				string ae_ = period?.unit;
				bool? af_ = context.Operators.Equal(ae_, "wk");

				return (af_ ?? false);
			};
			bool g_()
			{
				string ag_ = period?.unit;
				bool? ah_ = context.Operators.Equal(ag_, "mo");

				return (ah_ ?? false);
			};
			bool h_()
			{
				string ai_ = period?.unit;
				bool? aj_ = context.Operators.Equal(ai_, "a");

				return (aj_ ?? false);
			};
			bool i_()
			{
				string ak_ = period?.unit;
				bool? al_ = context.Operators.Equal(ak_, "hour");

				return (al_ ?? false);
			};
			bool j_()
			{
				string am_ = period?.unit;
				bool? an_ = context.Operators.Equal(am_, "minute");

				return (an_ ?? false);
			};
			bool k_()
			{
				string ao_ = period?.unit;
				bool? ap_ = context.Operators.Equal(ao_, "second");

				return (ap_ ?? false);
			};
			bool l_()
			{
				string aq_ = period?.unit;
				bool? ar_ = context.Operators.Equal(aq_, "day");

				return (ar_ ?? false);
			};
			bool m_()
			{
				string as_ = period?.unit;
				bool? at_ = context.Operators.Equal(as_, "week");

				return (at_ ?? false);
			};
			bool n_()
			{
				string au_ = period?.unit;
				bool? av_ = context.Operators.Equal(au_, "month");

				return (av_ ?? false);
			};
			bool o_()
			{
				string aw_ = period?.unit;
				bool? ax_ = context.Operators.Equal(aw_, "year");

				return (ax_ ?? false);
			};
			bool p_()
			{
				string ay_ = period?.unit;
				bool? az_ = context.Operators.Equal(ay_, "hours");

				return (az_ ?? false);
			};
			bool q_()
			{
				string ba_ = period?.unit;
				bool? bb_ = context.Operators.Equal(ba_, "minutes");

				return (bb_ ?? false);
			};
			bool r_()
			{
				string bc_ = period?.unit;
				bool? bd_ = context.Operators.Equal(bc_, "seconds");

				return (bd_ ?? false);
			};
			bool s_()
			{
				string be_ = period?.unit;
				bool? bf_ = context.Operators.Equal(be_, "days");

				return (bf_ ?? false);
			};
			bool t_()
			{
				string bg_ = period?.unit;
				bool? bh_ = context.Operators.Equal(bg_, "weeks");

				return (bh_ ?? false);
			};
			bool u_()
			{
				string bi_ = period?.unit;
				bool? bj_ = context.Operators.Equal(bi_, "months");

				return (bj_ ?? false);
			};
			bool v_()
			{
				string bk_ = period?.unit;
				bool? bl_ = context.Operators.Equal(bk_, "years");

				return (bl_ ?? false);
			};
			if (b_())
			{
				decimal? bm_ = context.Operators.ConvertIntegerToDecimal(frequency);
				decimal? bn_ = period?.value;
				decimal? bo_ = context.Operators.Divide(24.0m, bn_);
				decimal? bp_ = context.Operators.Multiply(bm_, bo_);

				return bp_;
			}
			else if (c_())
			{
				decimal? bq_ = context.Operators.ConvertIntegerToDecimal(frequency);
				decimal? br_ = period?.value;
				decimal? bs_ = context.Operators.Divide(24.0m, br_);
				decimal? bt_ = context.Operators.Multiply(bq_, bs_);
				decimal? bu_ = context.Operators.ConvertIntegerToDecimal(60);
				decimal? bv_ = context.Operators.Multiply(bt_, bu_);

				return bv_;
			}
			else if (d_())
			{
				decimal? bw_ = context.Operators.ConvertIntegerToDecimal(frequency);
				decimal? bx_ = period?.value;
				decimal? by_ = context.Operators.Divide(24.0m, bx_);
				decimal? bz_ = context.Operators.Multiply(bw_, by_);
				decimal? ca_ = context.Operators.ConvertIntegerToDecimal(60);
				decimal? cb_ = context.Operators.Multiply(bz_, ca_);
				decimal? cd_ = context.Operators.Multiply(cb_, ca_);

				return cd_;
			}
			else if (e_())
			{
				decimal? ce_ = context.Operators.ConvertIntegerToDecimal(frequency);
				decimal? cf_ = period?.value;
				decimal? cg_ = context.Operators.Divide(24.0m, cf_);
				decimal? ch_ = context.Operators.Multiply(ce_, cg_);
				decimal? ci_ = context.Operators.ConvertIntegerToDecimal(24);
				decimal? cj_ = context.Operators.Divide(ch_, ci_);

				return cj_;
			}
			else if (f_())
			{
				decimal? ck_ = context.Operators.ConvertIntegerToDecimal(frequency);
				decimal? cl_ = period?.value;
				decimal? cm_ = context.Operators.Divide(24.0m, cl_);
				decimal? cn_ = context.Operators.Multiply(ck_, cm_);
				int? co_ = context.Operators.Multiply(24, 7);
				decimal? cp_ = context.Operators.ConvertIntegerToDecimal(co_);
				decimal? cq_ = context.Operators.Divide(cn_, cp_);

				return cq_;
			}
			else if (g_())
			{
				decimal? cr_ = context.Operators.ConvertIntegerToDecimal(frequency);
				decimal? cs_ = period?.value;
				decimal? ct_ = context.Operators.Divide(24.0m, cs_);
				decimal? cu_ = context.Operators.Multiply(cr_, ct_);
				int? cv_ = context.Operators.Multiply(24, 30);
				decimal? cw_ = context.Operators.ConvertIntegerToDecimal(cv_);
				decimal? cx_ = context.Operators.Divide(cu_, cw_);

				return cx_;
			}
			else if (h_())
			{
				decimal? cy_ = context.Operators.ConvertIntegerToDecimal(frequency);
				decimal? cz_ = period?.value;
				decimal? da_ = context.Operators.Divide(24.0m, cz_);
				decimal? db_ = context.Operators.Multiply(cy_, da_);
				int? dc_ = context.Operators.Multiply(24, 365);
				decimal? dd_ = context.Operators.ConvertIntegerToDecimal(dc_);
				decimal? de_ = context.Operators.Divide(db_, dd_);

				return de_;
			}
			else if (i_())
			{
				decimal? df_ = context.Operators.ConvertIntegerToDecimal(frequency);
				decimal? dg_ = period?.value;
				decimal? dh_ = context.Operators.Divide(24.0m, dg_);
				decimal? di_ = context.Operators.Multiply(df_, dh_);

				return di_;
			}
			else if (j_())
			{
				decimal? dj_ = context.Operators.ConvertIntegerToDecimal(frequency);
				decimal? dk_ = period?.value;
				decimal? dl_ = context.Operators.Divide(24.0m, dk_);
				decimal? dm_ = context.Operators.Multiply(dj_, dl_);
				decimal? dn_ = context.Operators.ConvertIntegerToDecimal(60);
				decimal? do_ = context.Operators.Multiply(dm_, dn_);

				return do_;
			}
			else if (k_())
			{
				decimal? dp_ = context.Operators.ConvertIntegerToDecimal(frequency);
				decimal? dq_ = period?.value;
				decimal? dr_ = context.Operators.Divide(24.0m, dq_);
				decimal? ds_ = context.Operators.Multiply(dp_, dr_);
				decimal? dt_ = context.Operators.ConvertIntegerToDecimal(60);
				decimal? du_ = context.Operators.Multiply(ds_, dt_);
				decimal? dw_ = context.Operators.Multiply(du_, dt_);

				return dw_;
			}
			else if (l_())
			{
				decimal? dx_ = context.Operators.ConvertIntegerToDecimal(frequency);
				decimal? dy_ = period?.value;
				decimal? dz_ = context.Operators.Divide(24.0m, dy_);
				decimal? ea_ = context.Operators.Multiply(dx_, dz_);
				decimal? eb_ = context.Operators.ConvertIntegerToDecimal(24);
				decimal? ec_ = context.Operators.Divide(ea_, eb_);

				return ec_;
			}
			else if (m_())
			{
				decimal? ed_ = context.Operators.ConvertIntegerToDecimal(frequency);
				decimal? ee_ = period?.value;
				decimal? ef_ = context.Operators.Divide(24.0m, ee_);
				decimal? eg_ = context.Operators.Multiply(ed_, ef_);
				int? eh_ = context.Operators.Multiply(24, 7);
				decimal? ei_ = context.Operators.ConvertIntegerToDecimal(eh_);
				decimal? ej_ = context.Operators.Divide(eg_, ei_);

				return ej_;
			}
			else if (n_())
			{
				decimal? ek_ = context.Operators.ConvertIntegerToDecimal(frequency);
				decimal? el_ = period?.value;
				decimal? em_ = context.Operators.Divide(24.0m, el_);
				decimal? en_ = context.Operators.Multiply(ek_, em_);
				int? eo_ = context.Operators.Multiply(24, 30);
				decimal? ep_ = context.Operators.ConvertIntegerToDecimal(eo_);
				decimal? eq_ = context.Operators.Divide(en_, ep_);

				return eq_;
			}
			else if (o_())
			{
				decimal? er_ = context.Operators.ConvertIntegerToDecimal(frequency);
				decimal? es_ = period?.value;
				decimal? et_ = context.Operators.Divide(24.0m, es_);
				decimal? eu_ = context.Operators.Multiply(er_, et_);
				int? ev_ = context.Operators.Multiply(24, 365);
				decimal? ew_ = context.Operators.ConvertIntegerToDecimal(ev_);
				decimal? ex_ = context.Operators.Divide(eu_, ew_);

				return ex_;
			}
			else if (p_())
			{
				decimal? ey_ = context.Operators.ConvertIntegerToDecimal(frequency);
				decimal? ez_ = period?.value;
				decimal? fa_ = context.Operators.Divide(24.0m, ez_);
				decimal? fb_ = context.Operators.Multiply(ey_, fa_);

				return fb_;
			}
			else if (q_())
			{
				decimal? fc_ = context.Operators.ConvertIntegerToDecimal(frequency);
				decimal? fd_ = period?.value;
				decimal? fe_ = context.Operators.Divide(24.0m, fd_);
				decimal? ff_ = context.Operators.Multiply(fc_, fe_);
				decimal? fg_ = context.Operators.ConvertIntegerToDecimal(60);
				decimal? fh_ = context.Operators.Multiply(ff_, fg_);

				return fh_;
			}
			else if (r_())
			{
				decimal? fi_ = context.Operators.ConvertIntegerToDecimal(frequency);
				decimal? fj_ = period?.value;
				decimal? fk_ = context.Operators.Divide(24.0m, fj_);
				decimal? fl_ = context.Operators.Multiply(fi_, fk_);
				decimal? fm_ = context.Operators.ConvertIntegerToDecimal(60);
				decimal? fn_ = context.Operators.Multiply(fl_, fm_);
				decimal? fp_ = context.Operators.Multiply(fn_, fm_);

				return fp_;
			}
			else if (s_())
			{
				decimal? fq_ = context.Operators.ConvertIntegerToDecimal(frequency);
				decimal? fr_ = period?.value;
				decimal? fs_ = context.Operators.Divide(24.0m, fr_);
				decimal? ft_ = context.Operators.Multiply(fq_, fs_);
				decimal? fu_ = context.Operators.ConvertIntegerToDecimal(24);
				decimal? fv_ = context.Operators.Divide(ft_, fu_);

				return fv_;
			}
			else if (t_())
			{
				decimal? fw_ = context.Operators.ConvertIntegerToDecimal(frequency);
				decimal? fx_ = period?.value;
				decimal? fy_ = context.Operators.Divide(24.0m, fx_);
				decimal? fz_ = context.Operators.Multiply(fw_, fy_);
				int? ga_ = context.Operators.Multiply(24, 7);
				decimal? gb_ = context.Operators.ConvertIntegerToDecimal(ga_);
				decimal? gc_ = context.Operators.Divide(fz_, gb_);

				return gc_;
			}
			else if (u_())
			{
				decimal? gd_ = context.Operators.ConvertIntegerToDecimal(frequency);
				decimal? ge_ = period?.value;
				decimal? gf_ = context.Operators.Divide(24.0m, ge_);
				decimal? gg_ = context.Operators.Multiply(gd_, gf_);
				int? gh_ = context.Operators.Multiply(24, 30);
				decimal? gi_ = context.Operators.ConvertIntegerToDecimal(gh_);
				decimal? gj_ = context.Operators.Divide(gg_, gi_);

				return gj_;
			}
			else if (v_())
			{
				decimal? gk_ = context.Operators.ConvertIntegerToDecimal(frequency);
				decimal? gl_ = period?.value;
				decimal? gm_ = context.Operators.Divide(24.0m, gl_);
				decimal? gn_ = context.Operators.Multiply(gk_, gm_);
				int? go_ = context.Operators.Multiply(24, 365);
				decimal? gp_ = context.Operators.ConvertIntegerToDecimal(go_);
				decimal? gq_ = context.Operators.Divide(gn_, gp_);

				return gq_;
			}
			else
			{
				string gr_ = this.ErrorLevel();
				string gs_ = period?.unit;
				string gt_ = context.Operators.Concatenate("Unknown unit ", (gs_ ?? ""));
				object gu_ = context.Operators.Message<object>(null, "CMDLogic.ToDaily.UnknownUnit", gr_, gt_);

				return (decimal?)gu_;
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
				string fn_ = frequency?.code;
				string fo_ = context.Operators.Concatenate("Unknown frequency code ", (fn_ ?? ""));
				object fp_ = context.Operators.Message<object>(null, "CMDLogic.ToDaily.UnknownFrequencyCode", fm_, fo_);

				return (decimal?)fp_;
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
					List<Dosage> h_ = R?.DosageInstruction;
					Dosage i_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)h_);
					Timing j_ = i_?.Timing;
					Timing.RepeatComponent k_ = j_?.Repeat;
					DataType l_ = k_?.Bounds;
					object m_ = FHIRHelpers_4_3_000.ToValue(l_);
					CqlDateTime n_ = context.Operators.Start((m_ as CqlInterval<CqlDateTime>));
					CqlDate o_ = context.Operators.DateFrom(n_);
					FhirDateTime p_ = R?.AuthoredOnElement;
					CqlDateTime q_ = context.Operators.Convert<CqlDateTime>(p_);
					CqlDate r_ = context.Operators.DateFrom(q_);
					MedicationRequest.DispenseRequestComponent s_ = R?.DispenseRequest;
					Period t_ = s_?.ValidityPeriod;
					CqlInterval<CqlDateTime> u_ = FHIRHelpers_4_3_000.ToInterval(t_);
					CqlDateTime v_ = context.Operators.Start(u_);
					CqlDate w_ = context.Operators.DateFrom(v_);
					bool? x_ = context.Operators.Not((bool?)(((o_ ?? r_) ?? w_) is null));
					Duration z_ = s_?.ExpectedSupplyDuration;
					CqlQuantity aa_ = FHIRHelpers_4_3_000.ToQuantity((Quantity)z_);
					CqlQuantity ab_ = context.Operators.ConvertQuantity(aa_, "d");
					decimal? ac_ = ab_?.value;
					Quantity ae_ = s_?.Quantity;
					CqlQuantity af_ = FHIRHelpers_4_3_000.ToQuantity(ae_);
					decimal? ag_ = af_?.value;
					Dosage ai_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)h_);
					List<Dosage.DoseAndRateComponent> aj_ = ai_?.DoseAndRate;
					Dosage.DoseAndRateComponent ak_ = context.Operators.SingletonFrom<Dosage.DoseAndRateComponent>((IEnumerable<Dosage.DoseAndRateComponent>)aj_);
					DataType al_ = ak_?.Dose;
					object am_ = FHIRHelpers_4_3_000.ToValue(al_);
					CqlQuantity an_ = context.Operators.End((am_ as CqlInterval<CqlQuantity>));
					Dosage ap_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)h_);
					List<Dosage.DoseAndRateComponent> aq_ = ap_?.DoseAndRate;
					Dosage.DoseAndRateComponent ar_ = context.Operators.SingletonFrom<Dosage.DoseAndRateComponent>((IEnumerable<Dosage.DoseAndRateComponent>)aq_);
					DataType as_ = ar_?.Dose;
					object at_ = FHIRHelpers_4_3_000.ToValue(as_);
					decimal? au_ = (an_ ?? (at_ as CqlQuantity))?.value;
					Dosage aw_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)h_);
					Timing ax_ = aw_?.Timing;
					Timing.RepeatComponent ay_ = ax_?.Repeat;
					PositiveInt az_ = ay_?.FrequencyMaxElement;
					int? ba_ = az_?.Value;
					Dosage bc_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)h_);
					Timing bd_ = bc_?.Timing;
					Timing.RepeatComponent be_ = bd_?.Repeat;
					PositiveInt bf_ = be_?.FrequencyElement;
					int? bg_ = bf_?.Value;
					Dosage bi_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)h_);
					Timing bj_ = bi_?.Timing;
					Timing.RepeatComponent bk_ = bj_?.Repeat;
					FhirDecimal bl_ = bk_?.PeriodElement;
					decimal? bm_ = bl_?.Value;
					Dosage bo_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)h_);
					Timing bp_ = bo_?.Timing;
					Timing.RepeatComponent bq_ = bp_?.Repeat;
					Code<Timing.UnitsOfTime> br_ = bq_?.PeriodUnitElement;
					Timing.UnitsOfTime? bs_ = br_?.Value;
					Code<Timing.UnitsOfTime> bt_ = context.Operators.Convert<Code<Timing.UnitsOfTime>>(bs_);
					string bu_ = context.Operators.Convert<string>(bt_);
					CqlQuantity bv_ = this.Quantity(bm_, bu_);
					decimal? bw_ = this.ToDaily((ba_ ?? bg_), bv_);
					Dosage by_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)h_);
					Timing bz_ = by_?.Timing;
					Timing.RepeatComponent ca_ = bz_?.Repeat;
					List<Time> cb_ = ca_?.TimeOfDayElement;
					IEnumerable<CqlTime> cc_ = context.Operators.LateBoundProperty<IEnumerable<CqlTime>>(cb_, "value");
					int? cd_ = context.Operators.Count<CqlTime>(cc_);
					decimal? ce_ = context.Operators.ConvertIntegerToDecimal(cd_);
					decimal? cf_ = context.Operators.Multiply(au_, ((bw_ ?? ce_) ?? 1.0m));
					decimal? cg_ = context.Operators.Divide(ag_, cf_);
					UnsignedInt ci_ = s_?.NumberOfRepeatsAllowedElement;
					int? cj_ = ci_?.Value;
					int? ck_ = context.Operators.Add(1, (cj_ ?? 0));
					decimal? cl_ = context.Operators.ConvertIntegerToDecimal(ck_);
					decimal? cm_ = context.Operators.Multiply((ac_ ?? cg_), cl_);
					bool? cn_ = context.Operators.Not((bool?)(cm_ is null));
					bool? co_ = context.Operators.And(x_, cn_);

					return (co_ ?? false);
				};
				bool g_()
				{
					List<Dosage> cp_ = R?.DosageInstruction;
					Dosage cq_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)cp_);
					Timing cr_ = cq_?.Timing;
					Timing.RepeatComponent cs_ = cr_?.Repeat;
					DataType ct_ = cs_?.Bounds;
					object cu_ = FHIRHelpers_4_3_000.ToValue(ct_);
					CqlDateTime cv_ = context.Operators.Start((cu_ as CqlInterval<CqlDateTime>));
					CqlDate cw_ = context.Operators.DateFrom(cv_);
					FhirDateTime cx_ = R?.AuthoredOnElement;
					CqlDateTime cy_ = context.Operators.Convert<CqlDateTime>(cx_);
					CqlDate cz_ = context.Operators.DateFrom(cy_);
					MedicationRequest.DispenseRequestComponent da_ = R?.DispenseRequest;
					Period db_ = da_?.ValidityPeriod;
					CqlInterval<CqlDateTime> dc_ = FHIRHelpers_4_3_000.ToInterval(db_);
					CqlDateTime dd_ = context.Operators.Start(dc_);
					CqlDate de_ = context.Operators.DateFrom(dd_);
					bool? df_ = context.Operators.Not((bool?)(((cw_ ?? cz_) ?? de_) is null));
					Dosage dh_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)cp_);
					Timing di_ = dh_?.Timing;
					Timing.RepeatComponent dj_ = di_?.Repeat;
					DataType dk_ = dj_?.Bounds;
					object dl_ = FHIRHelpers_4_3_000.ToValue(dk_);
					CqlDateTime dm_ = (dl_ as CqlInterval<CqlDateTime>)?.high;
					bool? dn_ = context.Operators.Not((bool?)(dm_ is null));
					bool? do_ = context.Operators.And(df_, dn_);

					return (do_ ?? false);
				};
				if (f_())
				{
					List<Dosage> dp_ = R?.DosageInstruction;
					Dosage dq_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)dp_);
					Timing dr_ = dq_?.Timing;
					Timing.RepeatComponent ds_ = dr_?.Repeat;
					DataType dt_ = ds_?.Bounds;
					object du_ = FHIRHelpers_4_3_000.ToValue(dt_);
					CqlDateTime dv_ = context.Operators.Start((du_ as CqlInterval<CqlDateTime>));
					CqlDate dw_ = context.Operators.DateFrom(dv_);
					FhirDateTime dx_ = R?.AuthoredOnElement;
					CqlDateTime dy_ = context.Operators.Convert<CqlDateTime>(dx_);
					CqlDate dz_ = context.Operators.DateFrom(dy_);
					MedicationRequest.DispenseRequestComponent ea_ = R?.DispenseRequest;
					Period eb_ = ea_?.ValidityPeriod;
					CqlInterval<CqlDateTime> ec_ = FHIRHelpers_4_3_000.ToInterval(eb_);
					CqlDateTime ed_ = context.Operators.Start(ec_);
					CqlDate ee_ = context.Operators.DateFrom(ed_);
					Dosage eg_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)dp_);
					Timing eh_ = eg_?.Timing;
					Timing.RepeatComponent ei_ = eh_?.Repeat;
					DataType ej_ = ei_?.Bounds;
					object ek_ = FHIRHelpers_4_3_000.ToValue(ej_);
					CqlDateTime el_ = context.Operators.Start((ek_ as CqlInterval<CqlDateTime>));
					CqlDate em_ = context.Operators.DateFrom(el_);
					CqlDateTime eo_ = context.Operators.Convert<CqlDateTime>(dx_);
					CqlDate ep_ = context.Operators.DateFrom(eo_);
					Period er_ = ea_?.ValidityPeriod;
					CqlInterval<CqlDateTime> es_ = FHIRHelpers_4_3_000.ToInterval(er_);
					CqlDateTime et_ = context.Operators.Start(es_);
					CqlDate eu_ = context.Operators.DateFrom(et_);
					Duration ew_ = ea_?.ExpectedSupplyDuration;
					CqlQuantity ex_ = FHIRHelpers_4_3_000.ToQuantity((Quantity)ew_);
					CqlQuantity ey_ = context.Operators.ConvertQuantity(ex_, "d");
					decimal? ez_ = ey_?.value;
					Quantity fb_ = ea_?.Quantity;
					CqlQuantity fc_ = FHIRHelpers_4_3_000.ToQuantity(fb_);
					decimal? fd_ = fc_?.value;
					Dosage ff_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)dp_);
					List<Dosage.DoseAndRateComponent> fg_ = ff_?.DoseAndRate;
					Dosage.DoseAndRateComponent fh_ = context.Operators.SingletonFrom<Dosage.DoseAndRateComponent>((IEnumerable<Dosage.DoseAndRateComponent>)fg_);
					DataType fi_ = fh_?.Dose;
					object fj_ = FHIRHelpers_4_3_000.ToValue(fi_);
					CqlQuantity fk_ = context.Operators.End((fj_ as CqlInterval<CqlQuantity>));
					Dosage fm_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)dp_);
					List<Dosage.DoseAndRateComponent> fn_ = fm_?.DoseAndRate;
					Dosage.DoseAndRateComponent fo_ = context.Operators.SingletonFrom<Dosage.DoseAndRateComponent>((IEnumerable<Dosage.DoseAndRateComponent>)fn_);
					DataType fp_ = fo_?.Dose;
					object fq_ = FHIRHelpers_4_3_000.ToValue(fp_);
					decimal? fr_ = (fk_ ?? (fq_ as CqlQuantity))?.value;
					Dosage ft_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)dp_);
					Timing fu_ = ft_?.Timing;
					Timing.RepeatComponent fv_ = fu_?.Repeat;
					PositiveInt fw_ = fv_?.FrequencyMaxElement;
					int? fx_ = fw_?.Value;
					Dosage fz_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)dp_);
					Timing ga_ = fz_?.Timing;
					Timing.RepeatComponent gb_ = ga_?.Repeat;
					PositiveInt gc_ = gb_?.FrequencyElement;
					int? gd_ = gc_?.Value;
					Dosage gf_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)dp_);
					Timing gg_ = gf_?.Timing;
					Timing.RepeatComponent gh_ = gg_?.Repeat;
					FhirDecimal gi_ = gh_?.PeriodElement;
					decimal? gj_ = gi_?.Value;
					Dosage gl_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)dp_);
					Timing gm_ = gl_?.Timing;
					Timing.RepeatComponent gn_ = gm_?.Repeat;
					Code<Timing.UnitsOfTime> go_ = gn_?.PeriodUnitElement;
					Timing.UnitsOfTime? gp_ = go_?.Value;
					Code<Timing.UnitsOfTime> gq_ = context.Operators.Convert<Code<Timing.UnitsOfTime>>(gp_);
					string gr_ = context.Operators.Convert<string>(gq_);
					CqlQuantity gs_ = this.Quantity(gj_, gr_);
					decimal? gt_ = this.ToDaily((fx_ ?? gd_), gs_);
					Dosage gv_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)dp_);
					Timing gw_ = gv_?.Timing;
					Timing.RepeatComponent gx_ = gw_?.Repeat;
					List<Time> gy_ = gx_?.TimeOfDayElement;
					IEnumerable<CqlTime> gz_ = context.Operators.LateBoundProperty<IEnumerable<CqlTime>>(gy_, "value");
					int? ha_ = context.Operators.Count<CqlTime>(gz_);
					decimal? hb_ = context.Operators.ConvertIntegerToDecimal(ha_);
					decimal? hc_ = context.Operators.Multiply(fr_, ((gt_ ?? hb_) ?? 1.0m));
					decimal? hd_ = context.Operators.Divide(fd_, hc_);
					UnsignedInt hf_ = ea_?.NumberOfRepeatsAllowedElement;
					int? hg_ = hf_?.Value;
					int? hh_ = context.Operators.Add(1, (hg_ ?? 0));
					decimal? hi_ = context.Operators.ConvertIntegerToDecimal(hh_);
					decimal? hj_ = context.Operators.Multiply((ez_ ?? hd_), hi_);
					decimal? hk_ = context.Operators.ConvertIntegerToDecimal(1);
					decimal? hl_ = context.Operators.Subtract(hj_, hk_);
					CqlQuantity hm_ = this.Quantity(hl_, "day");
					CqlDate hn_ = context.Operators.Add(((em_ ?? ep_) ?? eu_), hm_);
					CqlInterval<CqlDate> ho_ = context.Operators.Interval(((dw_ ?? dz_) ?? ee_), hn_, true, true);

					return ho_;
				}
				else if (g_())
				{
					List<Dosage> hp_ = R?.DosageInstruction;
					Dosage hq_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)hp_);
					Timing hr_ = hq_?.Timing;
					Timing.RepeatComponent hs_ = hr_?.Repeat;
					DataType ht_ = hs_?.Bounds;
					object hu_ = FHIRHelpers_4_3_000.ToValue(ht_);
					CqlDateTime hv_ = context.Operators.Start((hu_ as CqlInterval<CqlDateTime>));
					CqlDate hw_ = context.Operators.DateFrom(hv_);
					FhirDateTime hx_ = R?.AuthoredOnElement;
					CqlDateTime hy_ = context.Operators.Convert<CqlDateTime>(hx_);
					CqlDate hz_ = context.Operators.DateFrom(hy_);
					MedicationRequest.DispenseRequestComponent ia_ = R?.DispenseRequest;
					Period ib_ = ia_?.ValidityPeriod;
					CqlInterval<CqlDateTime> ic_ = FHIRHelpers_4_3_000.ToInterval(ib_);
					CqlDateTime id_ = context.Operators.Start(ic_);
					CqlDate ie_ = context.Operators.DateFrom(id_);
					Dosage ig_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)hp_);
					Timing ih_ = ig_?.Timing;
					Timing.RepeatComponent ii_ = ih_?.Repeat;
					DataType ij_ = ii_?.Bounds;
					object ik_ = FHIRHelpers_4_3_000.ToValue(ij_);
					CqlDateTime il_ = context.Operators.End((ik_ as CqlInterval<CqlDateTime>));
					CqlDate im_ = context.Operators.DateFrom(il_);
					CqlInterval<CqlDate> in_ = context.Operators.Interval(((hw_ ?? hz_) ?? ie_), im_, true, true);

					return in_;
				}
				else
				{
					return null;
				}
			};

			return e_();
		};
		IEnumerable<CqlInterval<CqlDate>> c_ = context.Operators.Select<MedicationRequest, CqlInterval<CqlDate>>((IEnumerable<MedicationRequest>)a_, b_);
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
					FhirDateTime g_ = D?.WhenHandedOverElement;
					CqlDateTime h_ = context.Operators.Convert<CqlDateTime>(g_);
					CqlDate i_ = context.Operators.DateFrom(h_);
					FhirDateTime j_ = D?.WhenPreparedElement;
					CqlDateTime k_ = context.Operators.Convert<CqlDateTime>(j_);
					CqlDate l_ = context.Operators.DateFrom(k_);
					bool? m_ = context.Operators.Not((bool?)((i_ ?? l_) is null));
					Quantity n_ = D?.DaysSupply;
					CqlQuantity o_ = FHIRHelpers_4_3_000.ToQuantity(n_);
					CqlQuantity p_ = context.Operators.ConvertQuantity(o_, "d");
					decimal? q_ = p_?.value;
					Quantity r_ = D?.Quantity;
					CqlQuantity s_ = FHIRHelpers_4_3_000.ToQuantity(r_);
					decimal? t_ = s_?.value;
					List<Dosage> u_ = D?.DosageInstruction;
					Dosage v_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)u_);
					List<Dosage.DoseAndRateComponent> w_ = v_?.DoseAndRate;
					Dosage.DoseAndRateComponent x_ = context.Operators.SingletonFrom<Dosage.DoseAndRateComponent>((IEnumerable<Dosage.DoseAndRateComponent>)w_);
					DataType y_ = x_?.Dose;
					object z_ = FHIRHelpers_4_3_000.ToValue(y_);
					CqlQuantity aa_ = context.Operators.End((z_ as CqlInterval<CqlQuantity>));
					Dosage ac_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)u_);
					List<Dosage.DoseAndRateComponent> ad_ = ac_?.DoseAndRate;
					Dosage.DoseAndRateComponent ae_ = context.Operators.SingletonFrom<Dosage.DoseAndRateComponent>((IEnumerable<Dosage.DoseAndRateComponent>)ad_);
					DataType af_ = ae_?.Dose;
					object ag_ = FHIRHelpers_4_3_000.ToValue(af_);
					decimal? ah_ = (aa_ ?? (ag_ as CqlQuantity))?.value;
					Dosage aj_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)u_);
					Timing ak_ = aj_?.Timing;
					Timing.RepeatComponent al_ = ak_?.Repeat;
					PositiveInt am_ = al_?.FrequencyMaxElement;
					int? an_ = am_?.Value;
					Dosage ap_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)u_);
					Timing aq_ = ap_?.Timing;
					Timing.RepeatComponent ar_ = aq_?.Repeat;
					PositiveInt as_ = ar_?.FrequencyElement;
					int? at_ = as_?.Value;
					Dosage av_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)u_);
					Timing aw_ = av_?.Timing;
					Timing.RepeatComponent ax_ = aw_?.Repeat;
					FhirDecimal ay_ = ax_?.PeriodElement;
					decimal? az_ = ay_?.Value;
					Dosage bb_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)u_);
					Timing bc_ = bb_?.Timing;
					Timing.RepeatComponent bd_ = bc_?.Repeat;
					Code<Timing.UnitsOfTime> be_ = bd_?.PeriodUnitElement;
					Timing.UnitsOfTime? bf_ = be_?.Value;
					Code<Timing.UnitsOfTime> bg_ = context.Operators.Convert<Code<Timing.UnitsOfTime>>(bf_);
					string bh_ = context.Operators.Convert<string>(bg_);
					CqlQuantity bi_ = this.Quantity(az_, bh_);
					decimal? bj_ = this.ToDaily((an_ ?? at_), bi_);
					Dosage bl_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)u_);
					Timing bm_ = bl_?.Timing;
					Timing.RepeatComponent bn_ = bm_?.Repeat;
					List<Time> bo_ = bn_?.TimeOfDayElement;
					IEnumerable<CqlTime> bp_ = context.Operators.LateBoundProperty<IEnumerable<CqlTime>>(bo_, "value");
					int? bq_ = context.Operators.Count<CqlTime>(bp_);
					decimal? br_ = context.Operators.ConvertIntegerToDecimal(bq_);
					decimal? bs_ = context.Operators.Multiply(ah_, ((bj_ ?? br_) ?? 1.0m));
					decimal? bt_ = context.Operators.Divide(t_, bs_);
					bool? bu_ = context.Operators.Not((bool?)((q_ ?? bt_) is null));
					bool? bv_ = context.Operators.And(m_, bu_);

					return (bv_ ?? false);
				};
				if (f_())
				{
					FhirDateTime bw_ = D?.WhenHandedOverElement;
					CqlDateTime bx_ = context.Operators.Convert<CqlDateTime>(bw_);
					CqlDate by_ = context.Operators.DateFrom(bx_);
					FhirDateTime bz_ = D?.WhenPreparedElement;
					CqlDateTime ca_ = context.Operators.Convert<CqlDateTime>(bz_);
					CqlDate cb_ = context.Operators.DateFrom(ca_);
					CqlDateTime cd_ = context.Operators.Convert<CqlDateTime>(bw_);
					CqlDate ce_ = context.Operators.DateFrom(cd_);
					CqlDateTime cg_ = context.Operators.Convert<CqlDateTime>(bz_);
					CqlDate ch_ = context.Operators.DateFrom(cg_);
					Quantity ci_ = D?.DaysSupply;
					CqlQuantity cj_ = FHIRHelpers_4_3_000.ToQuantity(ci_);
					CqlQuantity ck_ = context.Operators.ConvertQuantity(cj_, "d");
					decimal? cl_ = ck_?.value;
					Quantity cm_ = D?.Quantity;
					CqlQuantity cn_ = FHIRHelpers_4_3_000.ToQuantity(cm_);
					decimal? co_ = cn_?.value;
					List<Dosage> cp_ = D?.DosageInstruction;
					Dosage cq_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)cp_);
					List<Dosage.DoseAndRateComponent> cr_ = cq_?.DoseAndRate;
					Dosage.DoseAndRateComponent cs_ = context.Operators.SingletonFrom<Dosage.DoseAndRateComponent>((IEnumerable<Dosage.DoseAndRateComponent>)cr_);
					DataType ct_ = cs_?.Dose;
					object cu_ = FHIRHelpers_4_3_000.ToValue(ct_);
					CqlQuantity cv_ = context.Operators.End((cu_ as CqlInterval<CqlQuantity>));
					Dosage cx_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)cp_);
					List<Dosage.DoseAndRateComponent> cy_ = cx_?.DoseAndRate;
					Dosage.DoseAndRateComponent cz_ = context.Operators.SingletonFrom<Dosage.DoseAndRateComponent>((IEnumerable<Dosage.DoseAndRateComponent>)cy_);
					DataType da_ = cz_?.Dose;
					object db_ = FHIRHelpers_4_3_000.ToValue(da_);
					decimal? dc_ = (cv_ ?? (db_ as CqlQuantity))?.value;
					Dosage de_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)cp_);
					Timing df_ = de_?.Timing;
					Timing.RepeatComponent dg_ = df_?.Repeat;
					PositiveInt dh_ = dg_?.FrequencyMaxElement;
					int? di_ = dh_?.Value;
					Dosage dk_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)cp_);
					Timing dl_ = dk_?.Timing;
					Timing.RepeatComponent dm_ = dl_?.Repeat;
					PositiveInt dn_ = dm_?.FrequencyElement;
					int? do_ = dn_?.Value;
					Dosage dq_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)cp_);
					Timing dr_ = dq_?.Timing;
					Timing.RepeatComponent ds_ = dr_?.Repeat;
					FhirDecimal dt_ = ds_?.PeriodElement;
					decimal? du_ = dt_?.Value;
					Dosage dw_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)cp_);
					Timing dx_ = dw_?.Timing;
					Timing.RepeatComponent dy_ = dx_?.Repeat;
					Code<Timing.UnitsOfTime> dz_ = dy_?.PeriodUnitElement;
					Timing.UnitsOfTime? ea_ = dz_?.Value;
					Code<Timing.UnitsOfTime> eb_ = context.Operators.Convert<Code<Timing.UnitsOfTime>>(ea_);
					string ec_ = context.Operators.Convert<string>(eb_);
					CqlQuantity ed_ = this.Quantity(du_, ec_);
					decimal? ee_ = this.ToDaily((di_ ?? do_), ed_);
					Dosage eg_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)cp_);
					Timing eh_ = eg_?.Timing;
					Timing.RepeatComponent ei_ = eh_?.Repeat;
					List<Time> ej_ = ei_?.TimeOfDayElement;
					IEnumerable<CqlTime> ek_ = context.Operators.LateBoundProperty<IEnumerable<CqlTime>>(ej_, "value");
					int? el_ = context.Operators.Count<CqlTime>(ek_);
					decimal? em_ = context.Operators.ConvertIntegerToDecimal(el_);
					decimal? en_ = context.Operators.Multiply(dc_, ((ee_ ?? em_) ?? 1.0m));
					decimal? eo_ = context.Operators.Divide(co_, en_);
					decimal? ep_ = context.Operators.ConvertIntegerToDecimal(1);
					decimal? eq_ = context.Operators.Subtract((cl_ ?? eo_), ep_);
					CqlQuantity er_ = this.Quantity(eq_, "day");
					CqlDate es_ = context.Operators.Add((ce_ ?? ch_), er_);
					CqlInterval<CqlDate> et_ = context.Operators.Interval((by_ ?? cb_), es_, true, true);

					return et_;
				}
				else
				{
					return null;
				}
			};

			return e_();
		};
		IEnumerable<CqlInterval<CqlDate>> c_ = context.Operators.Select<MedicationDispense, CqlInterval<CqlDate>>((IEnumerable<MedicationDispense>)a_, b_);
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
					DataType g_ = Administration?.Effective;
					object h_ = FHIRHelpers_4_3_000.ToValue(g_);
					CqlDateTime i_ = context.Operators.Start((h_ as CqlInterval<CqlDateTime>));
					CqlDate j_ = context.Operators.DateFrom(i_);
					bool? k_ = context.Operators.Not((bool?)(j_ is null));
					DataType l_ = Administration?.Medication;
					object m_ = FHIRHelpers_4_3_000.ToValue(l_);
					CqlQuantity n_ = this.TherapeuticDuration((m_ as CqlConcept));
					bool? o_ = context.Operators.Not((bool?)(n_ is null));
					bool? p_ = context.Operators.And(k_, o_);

					return (p_ ?? false);
				};
				if (f_())
				{
					DataType q_ = Administration?.Effective;
					object r_ = FHIRHelpers_4_3_000.ToValue(q_);
					CqlDateTime s_ = context.Operators.Start((r_ as CqlInterval<CqlDateTime>));
					CqlDate t_ = context.Operators.DateFrom(s_);
					object v_ = FHIRHelpers_4_3_000.ToValue(q_);
					CqlDateTime w_ = context.Operators.Start((v_ as CqlInterval<CqlDateTime>));
					CqlDate x_ = context.Operators.DateFrom(w_);
					DataType y_ = Administration?.Medication;
					object z_ = FHIRHelpers_4_3_000.ToValue(y_);
					CqlQuantity aa_ = this.TherapeuticDuration((z_ as CqlConcept));
					CqlDate ab_ = context.Operators.Add(x_, aa_);
					CqlQuantity ac_ = context.Operators.ConvertIntegerToQuantity(1);
					CqlDate ad_ = context.Operators.Subtract(ab_, ac_);
					CqlInterval<CqlDate> ae_ = context.Operators.Interval(t_, ad_, true, true);

					return ae_;
				}
				else
				{
					return null;
				}
			};

			return e_();
		};
		IEnumerable<CqlInterval<CqlDate>> c_ = context.Operators.Select<MedicationAdministration, CqlInterval<CqlDate>>((IEnumerable<MedicationAdministration>)a_, b_);
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
			}
		};

		return a_();
	}

    [CqlDeclaration("RolloutIntervals")]
	public IEnumerable<CqlInterval<CqlDate>> RolloutIntervals(IEnumerable<CqlInterval<CqlDate>> intervals)
	{
		IEnumerable<CqlInterval<CqlDate>> a_(IEnumerable<CqlInterval<CqlDate>> R, CqlInterval<CqlDate> I)
		{
			CqlInterval<CqlDate>[] c_ = new CqlInterval<CqlDate>[]
			{
				I,
			};
			CqlInterval<CqlDate> d_(CqlInterval<CqlDate> X)
			{
				CqlInterval<CqlDate> i_ = context.Operators.Last<CqlInterval<CqlDate>>(R);
				CqlDate j_ = context.Operators.End(i_);
				CqlQuantity k_ = context.Operators.Quantity(1m, "day");
				CqlDate l_ = context.Operators.Add(j_, k_);
				CqlDate m_ = context.Operators.Start(X);
				CqlDate[] n_ = new CqlDate[]
				{
					l_,
					m_,
				};
				CqlDate o_ = context.Operators.Max<CqlDate>((n_ as IEnumerable<CqlDate>));
				CqlDate q_ = context.Operators.End(i_);
				CqlDate s_ = context.Operators.Add(q_, k_);
				CqlDate[] u_ = new CqlDate[]
				{
					s_,
					m_,
				};
				CqlDate v_ = context.Operators.Max<CqlDate>((u_ as IEnumerable<CqlDate>));
				CqlDate x_ = context.Operators.End(X);
				int? y_ = context.Operators.DurationBetween(m_, x_, "day");
				decimal? z_ = context.Operators.ConvertIntegerToDecimal((y_ ?? 0));
				CqlQuantity aa_ = this.Quantity(z_, "day");
				CqlDate ab_ = context.Operators.Add(v_, aa_);
				CqlInterval<CqlDate> ac_ = context.Operators.Interval(o_, ab_, true, true);

				return ac_;
			};
			IEnumerable<CqlInterval<CqlDate>> e_ = context.Operators.Select<CqlInterval<CqlDate>, CqlInterval<CqlDate>>((IEnumerable<CqlInterval<CqlDate>>)c_, d_);
			CqlInterval<CqlDate> f_ = context.Operators.SingletonFrom<CqlInterval<CqlDate>>(e_);
			CqlInterval<CqlDate>[] g_ = new CqlInterval<CqlDate>[]
			{
				f_,
			};
			IEnumerable<CqlInterval<CqlDate>> h_ = context.Operators.ListUnion<CqlInterval<CqlDate>>(R, (g_ as IEnumerable<CqlInterval<CqlDate>>));

			return h_;
		};
		IEnumerable<CqlInterval<CqlDate>> b_ = context.Operators.Aggregate<CqlInterval<CqlDate>, IEnumerable<CqlInterval<CqlDate>>>(intervals, a_, null);

		return b_;
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
