using System;
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
[System.CodeDom.Compiler.GeneratedCode(".NET Code Generation", "2.0.4.0")]
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
		new CqlCode("HS", "http://terminology.hl7.org/CodeSystem/v3-TimingEvent", default, default);

    [CqlDeclaration("HS")]
	public CqlCode HS() => 
		__HS.Value;

	private CqlCode WAKE_Value() => 
		new CqlCode("WAKE", "http://terminology.hl7.org/CodeSystem/v3-TimingEvent", default, default);

    [CqlDeclaration("WAKE")]
	public CqlCode WAKE() => 
		__WAKE.Value;

	private CqlCode C_Value() => 
		new CqlCode("C", "http://terminology.hl7.org/CodeSystem/v3-TimingEvent", default, default);

    [CqlDeclaration("C")]
	public CqlCode C() => 
		__C.Value;

	private CqlCode CM_Value() => 
		new CqlCode("CM", "http://terminology.hl7.org/CodeSystem/v3-TimingEvent", default, default);

    [CqlDeclaration("CM")]
	public CqlCode CM() => 
		__CM.Value;

	private CqlCode CD_Value() => 
		new CqlCode("CD", "http://terminology.hl7.org/CodeSystem/v3-TimingEvent", default, default);

    [CqlDeclaration("CD")]
	public CqlCode CD() => 
		__CD.Value;

	private CqlCode CV_Value() => 
		new CqlCode("CV", "http://terminology.hl7.org/CodeSystem/v3-TimingEvent", default, default);

    [CqlDeclaration("CV")]
	public CqlCode CV() => 
		__CV.Value;

	private CqlCode AC_Value() => 
		new CqlCode("AC", "http://terminology.hl7.org/CodeSystem/v3-TimingEvent", default, default);

    [CqlDeclaration("AC")]
	public CqlCode AC() => 
		__AC.Value;

	private CqlCode ACM_Value() => 
		new CqlCode("ACM", "http://terminology.hl7.org/CodeSystem/v3-TimingEvent", default, default);

    [CqlDeclaration("ACM")]
	public CqlCode ACM() => 
		__ACM.Value;

	private CqlCode ACD_Value() => 
		new CqlCode("ACD", "http://terminology.hl7.org/CodeSystem/v3-TimingEvent", default, default);

    [CqlDeclaration("ACD")]
	public CqlCode ACD() => 
		__ACD.Value;

	private CqlCode ACV_Value() => 
		new CqlCode("ACV", "http://terminology.hl7.org/CodeSystem/v3-TimingEvent", default, default);

    [CqlDeclaration("ACV")]
	public CqlCode ACV() => 
		__ACV.Value;

	private CqlCode PC_Value() => 
		new CqlCode("PC", "http://terminology.hl7.org/CodeSystem/v3-TimingEvent", default, default);

    [CqlDeclaration("PC")]
	public CqlCode PC() => 
		__PC.Value;

	private CqlCode PCM_Value() => 
		new CqlCode("PCM", "http://terminology.hl7.org/CodeSystem/v3-TimingEvent", default, default);

    [CqlDeclaration("PCM")]
	public CqlCode PCM() => 
		__PCM.Value;

	private CqlCode PCD_Value() => 
		new CqlCode("PCD", "http://terminology.hl7.org/CodeSystem/v3-TimingEvent", default, default);

    [CqlDeclaration("PCD")]
	public CqlCode PCD() => 
		__PCD.Value;

	private CqlCode PCV_Value() => 
		new CqlCode("PCV", "http://terminology.hl7.org/CodeSystem/v3-TimingEvent", default, default);

    [CqlDeclaration("PCV")]
	public CqlCode PCV() => 
		__PCV.Value;

	private CqlCode MORN_Value() => 
		new CqlCode("MORN", "http://hl7.org/fhir/event-timing", default, default);

    [CqlDeclaration("MORN")]
	public CqlCode MORN() => 
		__MORN.Value;

	private CqlCode MORN_early_Value() => 
		new CqlCode("MORN.early", "http://hl7.org/fhir/event-timing", default, default);

    [CqlDeclaration("MORN.early")]
	public CqlCode MORN_early() => 
		__MORN_early.Value;

	private CqlCode MORN_late_Value() => 
		new CqlCode("MORN.late", "http://hl7.org/fhir/event-timing", default, default);

    [CqlDeclaration("MORN.late")]
	public CqlCode MORN_late() => 
		__MORN_late.Value;

	private CqlCode NOON_Value() => 
		new CqlCode("NOON", "http://hl7.org/fhir/event-timing", default, default);

    [CqlDeclaration("NOON")]
	public CqlCode NOON() => 
		__NOON.Value;

	private CqlCode AFT_Value() => 
		new CqlCode("AFT", "http://hl7.org/fhir/event-timing", default, default);

    [CqlDeclaration("AFT")]
	public CqlCode AFT() => 
		__AFT.Value;

	private CqlCode AFT_early_Value() => 
		new CqlCode("AFT.early", "http://hl7.org/fhir/event-timing", default, default);

    [CqlDeclaration("AFT.early")]
	public CqlCode AFT_early() => 
		__AFT_early.Value;

	private CqlCode AFT_late_Value() => 
		new CqlCode("AFT.late", "http://hl7.org/fhir/event-timing", default, default);

    [CqlDeclaration("AFT.late")]
	public CqlCode AFT_late() => 
		__AFT_late.Value;

	private CqlCode EVE_Value() => 
		new CqlCode("EVE", "http://hl7.org/fhir/event-timing", default, default);

    [CqlDeclaration("EVE")]
	public CqlCode EVE() => 
		__EVE.Value;

	private CqlCode EVE_early_Value() => 
		new CqlCode("EVE.early", "http://hl7.org/fhir/event-timing", default, default);

    [CqlDeclaration("EVE.early")]
	public CqlCode EVE_early() => 
		__EVE_early.Value;

	private CqlCode EVE_late_Value() => 
		new CqlCode("EVE.late", "http://hl7.org/fhir/event-timing", default, default);

    [CqlDeclaration("EVE.late")]
	public CqlCode EVE_late() => 
		__EVE_late.Value;

	private CqlCode NIGHT_Value() => 
		new CqlCode("NIGHT", "http://hl7.org/fhir/event-timing", default, default);

    [CqlDeclaration("NIGHT")]
	public CqlCode NIGHT() => 
		__NIGHT.Value;

	private CqlCode PHS_Value() => 
		new CqlCode("PHS", "http://hl7.org/fhir/event-timing", default, default);

    [CqlDeclaration("PHS")]
	public CqlCode PHS() => 
		__PHS.Value;

	private CqlCode Every_eight_hours__qualifier_value__Value() => 
		new CqlCode("307469008", "http://snomed.info/sct", default, default);

    [CqlDeclaration("Every eight hours (qualifier value)")]
	public CqlCode Every_eight_hours__qualifier_value_() => 
		__Every_eight_hours__qualifier_value_.Value;

	private CqlCode Every_eight_to_twelve_hours__qualifier_value__Value() => 
		new CqlCode("396140003", "http://snomed.info/sct", default, default);

    [CqlDeclaration("Every eight to twelve hours (qualifier value)")]
	public CqlCode Every_eight_to_twelve_hours__qualifier_value_() => 
		__Every_eight_to_twelve_hours__qualifier_value_.Value;

	private CqlCode Every_forty_eight_hours__qualifier_value__Value() => 
		new CqlCode("396131002", "http://snomed.info/sct", default, default);

    [CqlDeclaration("Every forty eight hours (qualifier value)")]
	public CqlCode Every_forty_eight_hours__qualifier_value_() => 
		__Every_forty_eight_hours__qualifier_value_.Value;

	private CqlCode Every_forty_hours__qualifier_value__Value() => 
		new CqlCode("396130001", "http://snomed.info/sct", default, default);

    [CqlDeclaration("Every forty hours (qualifier value)")]
	public CqlCode Every_forty_hours__qualifier_value_() => 
		__Every_forty_hours__qualifier_value_.Value;

	private CqlCode Every_four_hours__qualifier_value__Value() => 
		new CqlCode("225756002", "http://snomed.info/sct", default, default);

    [CqlDeclaration("Every four hours (qualifier value)")]
	public CqlCode Every_four_hours__qualifier_value_() => 
		__Every_four_hours__qualifier_value_.Value;

	private CqlCode Every_seventy_two_hours__qualifier_value__Value() => 
		new CqlCode("396143001", "http://snomed.info/sct", default, default);

    [CqlDeclaration("Every seventy two hours (qualifier value)")]
	public CqlCode Every_seventy_two_hours__qualifier_value_() => 
		__Every_seventy_two_hours__qualifier_value_.Value;

	private CqlCode Every_six_hours__qualifier_value__Value() => 
		new CqlCode("307468000", "http://snomed.info/sct", default, default);

    [CqlDeclaration("Every six hours (qualifier value)")]
	public CqlCode Every_six_hours__qualifier_value_() => 
		__Every_six_hours__qualifier_value_.Value;

	private CqlCode Every_six_to_eight_hours__qualifier_value__Value() => 
		new CqlCode("396139000", "http://snomed.info/sct", default, default);

    [CqlDeclaration("Every six to eight hours (qualifier value)")]
	public CqlCode Every_six_to_eight_hours__qualifier_value_() => 
		__Every_six_to_eight_hours__qualifier_value_.Value;

	private CqlCode Every_thirty_six_hours__qualifier_value__Value() => 
		new CqlCode("396126004", "http://snomed.info/sct", default, default);

    [CqlDeclaration("Every thirty six hours (qualifier value)")]
	public CqlCode Every_thirty_six_hours__qualifier_value_() => 
		__Every_thirty_six_hours__qualifier_value_.Value;

	private CqlCode Every_three_to_four_hours__qualifier_value__Value() => 
		new CqlCode("225754004", "http://snomed.info/sct", default, default);

    [CqlDeclaration("Every three to four hours (qualifier value)")]
	public CqlCode Every_three_to_four_hours__qualifier_value_() => 
		__Every_three_to_four_hours__qualifier_value_.Value;

	private CqlCode Every_three_to_six_hours__qualifier_value__Value() => 
		new CqlCode("396127008", "http://snomed.info/sct", default, default);

    [CqlDeclaration("Every three to six hours (qualifier value)")]
	public CqlCode Every_three_to_six_hours__qualifier_value_() => 
		__Every_three_to_six_hours__qualifier_value_.Value;

	private CqlCode Every_twelve_hours__qualifier_value__Value() => 
		new CqlCode("307470009", "http://snomed.info/sct", default, default);

    [CqlDeclaration("Every twelve hours (qualifier value)")]
	public CqlCode Every_twelve_hours__qualifier_value_() => 
		__Every_twelve_hours__qualifier_value_.Value;

	private CqlCode Every_twenty_four_hours__qualifier_value__Value() => 
		new CqlCode("396125000", "http://snomed.info/sct", default, default);

    [CqlDeclaration("Every twenty four hours (qualifier value)")]
	public CqlCode Every_twenty_four_hours__qualifier_value_() => 
		__Every_twenty_four_hours__qualifier_value_.Value;

	private CqlCode Every_two_to_four_hours__qualifier_value__Value() => 
		new CqlCode("225752000", "http://snomed.info/sct", default, default);

    [CqlDeclaration("Every two to four hours (qualifier value)")]
	public CqlCode Every_two_to_four_hours__qualifier_value_() => 
		__Every_two_to_four_hours__qualifier_value_.Value;

	private CqlCode Four_times_daily__qualifier_value__Value() => 
		new CqlCode("307439001", "http://snomed.info/sct", default, default);

    [CqlDeclaration("Four times daily (qualifier value)")]
	public CqlCode Four_times_daily__qualifier_value_() => 
		__Four_times_daily__qualifier_value_.Value;

	private CqlCode Once_daily__qualifier_value__Value() => 
		new CqlCode("229797004", "http://snomed.info/sct", default, default);

    [CqlDeclaration("Once daily (qualifier value)")]
	public CqlCode Once_daily__qualifier_value_() => 
		__Once_daily__qualifier_value_.Value;

	private CqlCode One_to_four_times_a_day__qualifier_value__Value() => 
		new CqlCode("396109005", "http://snomed.info/sct", default, default);

    [CqlDeclaration("One to four times a day (qualifier value)")]
	public CqlCode One_to_four_times_a_day__qualifier_value_() => 
		__One_to_four_times_a_day__qualifier_value_.Value;

	private CqlCode One_to_three_times_a_day__qualifier_value__Value() => 
		new CqlCode("396108002", "http://snomed.info/sct", default, default);

    [CqlDeclaration("One to three times a day (qualifier value)")]
	public CqlCode One_to_three_times_a_day__qualifier_value_() => 
		__One_to_three_times_a_day__qualifier_value_.Value;

	private CqlCode One_to_two_times_a_day__qualifier_value__Value() => 
		new CqlCode("396107007", "http://snomed.info/sct", default, default);

    [CqlDeclaration("One to two times a day (qualifier value)")]
	public CqlCode One_to_two_times_a_day__qualifier_value_() => 
		__One_to_two_times_a_day__qualifier_value_.Value;

	private CqlCode Three_times_daily__qualifier_value__Value() => 
		new CqlCode("229798009", "http://snomed.info/sct", default, default);

    [CqlDeclaration("Three times daily (qualifier value)")]
	public CqlCode Three_times_daily__qualifier_value_() => 
		__Three_times_daily__qualifier_value_.Value;

	private CqlCode Twice_a_day__qualifier_value__Value() => 
		new CqlCode("229799001", "http://snomed.info/sct", default, default);

    [CqlDeclaration("Twice a day (qualifier value)")]
	public CqlCode Twice_a_day__qualifier_value_() => 
		__Twice_a_day__qualifier_value_.Value;

	private CqlCode Two_to_four_times_a_day__qualifier_value__Value() => 
		new CqlCode("396111001", "http://snomed.info/sct", default, default);

    [CqlDeclaration("Two to four times a day (qualifier value)")]
	public CqlCode Two_to_four_times_a_day__qualifier_value_() => 
		__Two_to_four_times_a_day__qualifier_value_.Value;

	private CqlCode[] V3TimingEvent_Value()
	{
		CqlCode[] a_ = [
			new CqlCode("HS", "http://terminology.hl7.org/CodeSystem/v3-TimingEvent", default, default),
			new CqlCode("WAKE", "http://terminology.hl7.org/CodeSystem/v3-TimingEvent", default, default),
			new CqlCode("C", "http://terminology.hl7.org/CodeSystem/v3-TimingEvent", default, default),
			new CqlCode("CM", "http://terminology.hl7.org/CodeSystem/v3-TimingEvent", default, default),
			new CqlCode("CD", "http://terminology.hl7.org/CodeSystem/v3-TimingEvent", default, default),
			new CqlCode("CV", "http://terminology.hl7.org/CodeSystem/v3-TimingEvent", default, default),
			new CqlCode("AC", "http://terminology.hl7.org/CodeSystem/v3-TimingEvent", default, default),
			new CqlCode("ACM", "http://terminology.hl7.org/CodeSystem/v3-TimingEvent", default, default),
			new CqlCode("ACD", "http://terminology.hl7.org/CodeSystem/v3-TimingEvent", default, default),
			new CqlCode("ACV", "http://terminology.hl7.org/CodeSystem/v3-TimingEvent", default, default),
			new CqlCode("PC", "http://terminology.hl7.org/CodeSystem/v3-TimingEvent", default, default),
			new CqlCode("PCM", "http://terminology.hl7.org/CodeSystem/v3-TimingEvent", default, default),
			new CqlCode("PCD", "http://terminology.hl7.org/CodeSystem/v3-TimingEvent", default, default),
			new CqlCode("PCV", "http://terminology.hl7.org/CodeSystem/v3-TimingEvent", default, default),
		];

		return a_;
	}

    [CqlDeclaration("V3TimingEvent")]
	public CqlCode[] V3TimingEvent() => 
		__V3TimingEvent.Value;

	private CqlCode[] EventTiming_Value()
	{
		CqlCode[] a_ = [
			new CqlCode("MORN", "http://hl7.org/fhir/event-timing", default, default),
			new CqlCode("MORN.early", "http://hl7.org/fhir/event-timing", default, default),
			new CqlCode("MORN.late", "http://hl7.org/fhir/event-timing", default, default),
			new CqlCode("NOON", "http://hl7.org/fhir/event-timing", default, default),
			new CqlCode("AFT", "http://hl7.org/fhir/event-timing", default, default),
			new CqlCode("AFT.early", "http://hl7.org/fhir/event-timing", default, default),
			new CqlCode("AFT.late", "http://hl7.org/fhir/event-timing", default, default),
			new CqlCode("EVE", "http://hl7.org/fhir/event-timing", default, default),
			new CqlCode("EVE.early", "http://hl7.org/fhir/event-timing", default, default),
			new CqlCode("EVE.late", "http://hl7.org/fhir/event-timing", default, default),
			new CqlCode("NIGHT", "http://hl7.org/fhir/event-timing", default, default),
			new CqlCode("PHS", "http://hl7.org/fhir/event-timing", default, default),
		];

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
		IEnumerable<Patient> a_ = context.Operators.RetrieveByValueSet<Patient>(default, default);
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

				return x_ ?? false;
			};
			bool c_()
			{
				string y_ = period?.unit;
				bool? z_ = context.Operators.Equal(y_, "min");

				return z_ ?? false;
			};
			bool d_()
			{
				string aa_ = period?.unit;
				bool? ab_ = context.Operators.Equal(aa_, "s");

				return ab_ ?? false;
			};
			bool e_()
			{
				string ac_ = period?.unit;
				bool? ad_ = context.Operators.Equal(ac_, "d");

				return ad_ ?? false;
			};
			bool f_()
			{
				string ae_ = period?.unit;
				bool? af_ = context.Operators.Equal(ae_, "wk");

				return af_ ?? false;
			};
			bool g_()
			{
				string ag_ = period?.unit;
				bool? ah_ = context.Operators.Equal(ag_, "mo");

				return ah_ ?? false;
			};
			bool h_()
			{
				string ai_ = period?.unit;
				bool? aj_ = context.Operators.Equal(ai_, "a");

				return aj_ ?? false;
			};
			bool i_()
			{
				string ak_ = period?.unit;
				bool? al_ = context.Operators.Equal(ak_, "hour");

				return al_ ?? false;
			};
			bool j_()
			{
				string am_ = period?.unit;
				bool? an_ = context.Operators.Equal(am_, "minute");

				return an_ ?? false;
			};
			bool k_()
			{
				string ao_ = period?.unit;
				bool? ap_ = context.Operators.Equal(ao_, "second");

				return ap_ ?? false;
			};
			bool l_()
			{
				string aq_ = period?.unit;
				bool? ar_ = context.Operators.Equal(aq_, "day");

				return ar_ ?? false;
			};
			bool m_()
			{
				string as_ = period?.unit;
				bool? at_ = context.Operators.Equal(as_, "week");

				return at_ ?? false;
			};
			bool n_()
			{
				string au_ = period?.unit;
				bool? av_ = context.Operators.Equal(au_, "month");

				return av_ ?? false;
			};
			bool o_()
			{
				string aw_ = period?.unit;
				bool? ax_ = context.Operators.Equal(aw_, "year");

				return ax_ ?? false;
			};
			bool p_()
			{
				string ay_ = period?.unit;
				bool? az_ = context.Operators.Equal(ay_, "hours");

				return az_ ?? false;
			};
			bool q_()
			{
				string ba_ = period?.unit;
				bool? bb_ = context.Operators.Equal(ba_, "minutes");

				return bb_ ?? false;
			};
			bool r_()
			{
				string bc_ = period?.unit;
				bool? bd_ = context.Operators.Equal(bc_, "seconds");

				return bd_ ?? false;
			};
			bool s_()
			{
				string be_ = period?.unit;
				bool? bf_ = context.Operators.Equal(be_, "days");

				return bf_ ?? false;
			};
			bool t_()
			{
				string bg_ = period?.unit;
				bool? bh_ = context.Operators.Equal(bg_, "weeks");

				return bh_ ?? false;
			};
			bool u_()
			{
				string bi_ = period?.unit;
				bool? bj_ = context.Operators.Equal(bi_, "months");

				return bj_ ?? false;
			};
			bool v_()
			{
				string bk_ = period?.unit;
				bool? bl_ = context.Operators.Equal(bk_, "years");

				return bl_ ?? false;
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
				string gt_ = context.Operators.Concatenate("Unknown unit ", gs_ ?? "");
				object gu_ = context.Operators.Message<object>(null, "CMDLogic.ToDaily.UnknownUnit", gr_, gt_);

				return gu_ as decimal?;
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

				return ax_ ?? false;
			};
			bool c_()
			{
				CqlCode ay_ = this.WAKE();
				bool? az_ = context.Operators.Equivalent(frequency, ay_);

				return az_ ?? false;
			};
			bool d_()
			{
				CqlCode ba_ = this.C();
				bool? bb_ = context.Operators.Equivalent(frequency, ba_);

				return bb_ ?? false;
			};
			bool e_()
			{
				CqlCode bc_ = this.CM();
				bool? bd_ = context.Operators.Equivalent(frequency, bc_);

				return bd_ ?? false;
			};
			bool f_()
			{
				CqlCode be_ = this.CD();
				bool? bf_ = context.Operators.Equivalent(frequency, be_);

				return bf_ ?? false;
			};
			bool g_()
			{
				CqlCode bg_ = this.CV();
				bool? bh_ = context.Operators.Equivalent(frequency, bg_);

				return bh_ ?? false;
			};
			bool h_()
			{
				CqlCode bi_ = this.AC();
				bool? bj_ = context.Operators.Equivalent(frequency, bi_);

				return bj_ ?? false;
			};
			bool i_()
			{
				CqlCode bk_ = this.ACM();
				bool? bl_ = context.Operators.Equivalent(frequency, bk_);

				return bl_ ?? false;
			};
			bool j_()
			{
				CqlCode bm_ = this.ACD();
				bool? bn_ = context.Operators.Equivalent(frequency, bm_);

				return bn_ ?? false;
			};
			bool k_()
			{
				CqlCode bo_ = this.ACV();
				bool? bp_ = context.Operators.Equivalent(frequency, bo_);

				return bp_ ?? false;
			};
			bool l_()
			{
				CqlCode bq_ = this.PC();
				bool? br_ = context.Operators.Equivalent(frequency, bq_);

				return br_ ?? false;
			};
			bool m_()
			{
				CqlCode bs_ = this.PCM();
				bool? bt_ = context.Operators.Equivalent(frequency, bs_);

				return bt_ ?? false;
			};
			bool n_()
			{
				CqlCode bu_ = this.PCD();
				bool? bv_ = context.Operators.Equivalent(frequency, bu_);

				return bv_ ?? false;
			};
			bool o_()
			{
				CqlCode bw_ = this.PCV();
				bool? bx_ = context.Operators.Equivalent(frequency, bw_);

				return bx_ ?? false;
			};
			bool p_()
			{
				CqlCode by_ = this.MORN();
				bool? bz_ = context.Operators.Equivalent(frequency, by_);

				return bz_ ?? false;
			};
			bool q_()
			{
				CqlCode ca_ = this.MORN_early();
				bool? cb_ = context.Operators.Equivalent(frequency, ca_);

				return cb_ ?? false;
			};
			bool r_()
			{
				CqlCode cc_ = this.MORN_late();
				bool? cd_ = context.Operators.Equivalent(frequency, cc_);

				return cd_ ?? false;
			};
			bool s_()
			{
				CqlCode ce_ = this.NOON();
				bool? cf_ = context.Operators.Equivalent(frequency, ce_);

				return cf_ ?? false;
			};
			bool t_()
			{
				CqlCode cg_ = this.AFT();
				bool? ch_ = context.Operators.Equivalent(frequency, cg_);

				return ch_ ?? false;
			};
			bool u_()
			{
				CqlCode ci_ = this.AFT_early();
				bool? cj_ = context.Operators.Equivalent(frequency, ci_);

				return cj_ ?? false;
			};
			bool v_()
			{
				CqlCode ck_ = this.AFT_late();
				bool? cl_ = context.Operators.Equivalent(frequency, ck_);

				return cl_ ?? false;
			};
			bool w_()
			{
				CqlCode cm_ = this.EVE();
				bool? cn_ = context.Operators.Equivalent(frequency, cm_);

				return cn_ ?? false;
			};
			bool x_()
			{
				CqlCode co_ = this.EVE_early();
				bool? cp_ = context.Operators.Equivalent(frequency, co_);

				return cp_ ?? false;
			};
			bool y_()
			{
				CqlCode cq_ = this.EVE_late();
				bool? cr_ = context.Operators.Equivalent(frequency, cq_);

				return cr_ ?? false;
			};
			bool z_()
			{
				CqlCode cs_ = this.NIGHT();
				bool? ct_ = context.Operators.Equivalent(frequency, cs_);

				return ct_ ?? false;
			};
			bool aa_()
			{
				CqlCode cu_ = this.PHS();
				bool? cv_ = context.Operators.Equivalent(frequency, cu_);

				return cv_ ?? false;
			};
			bool ab_()
			{
				CqlCode cw_ = this.Once_daily__qualifier_value_();
				bool? cx_ = context.Operators.Equivalent(frequency, cw_);

				return cx_ ?? false;
			};
			bool ac_()
			{
				CqlCode cy_ = this.Twice_a_day__qualifier_value_();
				bool? cz_ = context.Operators.Equivalent(frequency, cy_);

				return cz_ ?? false;
			};
			bool ad_()
			{
				CqlCode da_ = this.Three_times_daily__qualifier_value_();
				bool? db_ = context.Operators.Equivalent(frequency, da_);

				return db_ ?? false;
			};
			bool ae_()
			{
				CqlCode dc_ = this.Four_times_daily__qualifier_value_();
				bool? dd_ = context.Operators.Equivalent(frequency, dc_);

				return dd_ ?? false;
			};
			bool af_()
			{
				CqlCode de_ = this.Every_twenty_four_hours__qualifier_value_();
				bool? df_ = context.Operators.Equivalent(frequency, de_);

				return df_ ?? false;
			};
			bool ag_()
			{
				CqlCode dg_ = this.Every_twelve_hours__qualifier_value_();
				bool? dh_ = context.Operators.Equivalent(frequency, dg_);

				return dh_ ?? false;
			};
			bool ah_()
			{
				CqlCode di_ = this.Every_thirty_six_hours__qualifier_value_();
				bool? dj_ = context.Operators.Equivalent(frequency, di_);

				return dj_ ?? false;
			};
			bool ai_()
			{
				CqlCode dk_ = this.Every_eight_hours__qualifier_value_();
				bool? dl_ = context.Operators.Equivalent(frequency, dk_);

				return dl_ ?? false;
			};
			bool aj_()
			{
				CqlCode dm_ = this.Every_four_hours__qualifier_value_();
				bool? dn_ = context.Operators.Equivalent(frequency, dm_);

				return dn_ ?? false;
			};
			bool ak_()
			{
				CqlCode do_ = this.Every_six_hours__qualifier_value_();
				bool? dp_ = context.Operators.Equivalent(frequency, do_);

				return dp_ ?? false;
			};
			bool al_()
			{
				CqlCode dq_ = this.Every_seventy_two_hours__qualifier_value_();
				bool? dr_ = context.Operators.Equivalent(frequency, dq_);

				return dr_ ?? false;
			};
			bool am_()
			{
				CqlCode ds_ = this.Every_forty_eight_hours__qualifier_value_();
				bool? dt_ = context.Operators.Equivalent(frequency, ds_);

				return dt_ ?? false;
			};
			bool an_()
			{
				CqlCode du_ = this.Every_eight_to_twelve_hours__qualifier_value_();
				bool? dv_ = context.Operators.Equivalent(frequency, du_);

				return dv_ ?? false;
			};
			bool ao_()
			{
				CqlCode dw_ = this.Every_six_to_eight_hours__qualifier_value_();
				bool? dx_ = context.Operators.Equivalent(frequency, dw_);

				return dx_ ?? false;
			};
			bool ap_()
			{
				CqlCode dy_ = this.Every_three_to_four_hours__qualifier_value_();
				bool? dz_ = context.Operators.Equivalent(frequency, dy_);

				return dz_ ?? false;
			};
			bool aq_()
			{
				CqlCode ea_ = this.Every_three_to_six_hours__qualifier_value_();
				bool? eb_ = context.Operators.Equivalent(frequency, ea_);

				return eb_ ?? false;
			};
			bool ar_()
			{
				CqlCode ec_ = this.Every_two_to_four_hours__qualifier_value_();
				bool? ed_ = context.Operators.Equivalent(frequency, ec_);

				return ed_ ?? false;
			};
			bool as_()
			{
				CqlCode ee_ = this.One_to_four_times_a_day__qualifier_value_();
				bool? ef_ = context.Operators.Equivalent(frequency, ee_);

				return ef_ ?? false;
			};
			bool at_()
			{
				CqlCode eg_ = this.One_to_three_times_a_day__qualifier_value_();
				bool? eh_ = context.Operators.Equivalent(frequency, eg_);

				return eh_ ?? false;
			};
			bool au_()
			{
				CqlCode ei_ = this.One_to_two_times_a_day__qualifier_value_();
				bool? ej_ = context.Operators.Equivalent(frequency, ei_);

				return ej_ ?? false;
			};
			bool av_()
			{
				CqlCode ek_ = this.Two_to_four_times_a_day__qualifier_value_();
				bool? el_ = context.Operators.Equivalent(frequency, ek_);

				return el_ ?? false;
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
				string fo_ = context.Operators.Concatenate("Unknown frequency code ", fn_ ?? "");
				object fp_ = context.Operators.Message<object>(null, "CMDLogic.ToDaily.UnknownFrequencyCode", fm_, fo_);

				return fp_ as decimal?;
			}
		};

		return a_();
	}

    [CqlDeclaration("Quantity")]
	public CqlQuantity Quantity(decimal? value, string unit) => 
		((context.Operators.Not((bool?)(value is null))) ?? false
			? new CqlQuantity(value, unit)
			: null);

    [CqlDeclaration("MedicationRequestPeriod")]
	public CqlInterval<CqlDate> MedicationRequestPeriod(MedicationRequest Request)
	{
		MedicationRequest[] a_ = [
			Request,
		];
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
					CqlInterval<CqlDateTime> n_ = m_ switch { null => null , CqlInterval<CqlDateTime> a => a/* , CqlQuantity => ???, CqlInterval<CqlQuantity> => ??? */, _ => throw new System.Diagnostics.UnreachableException() };
					CqlDateTime o_ = context.Operators.Start(n_);
					CqlDate p_ = context.Operators.DateFrom(o_);
					FhirDateTime q_ = R?.AuthoredOnElement;
					CqlDateTime r_ = context.Operators.Convert<CqlDateTime>(q_);
					CqlDate s_ = context.Operators.DateFrom(r_);
					MedicationRequest.DispenseRequestComponent t_ = R?.DispenseRequest;
					Period u_ = t_?.ValidityPeriod;
					CqlInterval<CqlDateTime> v_ = FHIRHelpers_4_3_000.ToInterval(u_);
					CqlDateTime w_ = context.Operators.Start(v_);
					CqlDate x_ = context.Operators.DateFrom(w_);
					bool? y_ = context.Operators.Not((bool?)(((p_ ?? s_) ?? x_) is null));
					Duration aa_ = t_?.ExpectedSupplyDuration;
					CqlQuantity ab_ = FHIRHelpers_4_3_000.ToQuantity(aa_);
					CqlQuantity ac_ = context.Operators.ConvertQuantity(ab_, "d");
					decimal? ad_ = ac_?.value;
					Quantity af_ = t_?.Quantity;
					CqlQuantity ag_ = FHIRHelpers_4_3_000.ToQuantity(af_);
					decimal? ah_ = ag_?.value;
					Dosage aj_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)h_);
					List<Dosage.DoseAndRateComponent> ak_ = aj_?.DoseAndRate;
					Dosage.DoseAndRateComponent al_ = context.Operators.SingletonFrom<Dosage.DoseAndRateComponent>((IEnumerable<Dosage.DoseAndRateComponent>)ak_);
					DataType am_ = al_?.Dose;
					object an_ = FHIRHelpers_4_3_000.ToValue(am_);
					CqlInterval<CqlQuantity> ao_ = an_ switch { null => null , CqlInterval<CqlQuantity> b => b/* , CqlQuantity => ??? */, _ => throw new System.Diagnostics.UnreachableException() };
					CqlQuantity ap_ = context.Operators.End(ao_);
					Dosage ar_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)h_);
					List<Dosage.DoseAndRateComponent> as_ = ar_?.DoseAndRate;
					Dosage.DoseAndRateComponent at_ = context.Operators.SingletonFrom<Dosage.DoseAndRateComponent>((IEnumerable<Dosage.DoseAndRateComponent>)as_);
					DataType au_ = at_?.Dose;
					object av_ = FHIRHelpers_4_3_000.ToValue(au_);
					CqlQuantity aw_ = av_ switch { null => null , CqlQuantity c => c/* , CqlInterval<CqlQuantity> => ??? */, _ => throw new System.Diagnostics.UnreachableException() };
					decimal? ax_ = (ap_ ?? aw_)?.value;
					Dosage az_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)h_);
					Timing ba_ = az_?.Timing;
					Timing.RepeatComponent bb_ = ba_?.Repeat;
					PositiveInt bc_ = bb_?.FrequencyMaxElement;
					int? bd_ = bc_?.Value;
					Dosage bf_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)h_);
					Timing bg_ = bf_?.Timing;
					Timing.RepeatComponent bh_ = bg_?.Repeat;
					PositiveInt bi_ = bh_?.FrequencyElement;
					int? bj_ = bi_?.Value;
					Dosage bl_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)h_);
					Timing bm_ = bl_?.Timing;
					Timing.RepeatComponent bn_ = bm_?.Repeat;
					FhirDecimal bo_ = bn_?.PeriodElement;
					decimal? bp_ = bo_?.Value;
					Dosage br_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)h_);
					Timing bs_ = br_?.Timing;
					Timing.RepeatComponent bt_ = bs_?.Repeat;
					Code<Timing.UnitsOfTime> bu_ = bt_?.PeriodUnitElement;
					Timing.UnitsOfTime? bv_ = bu_?.Value;
					string bw_ = context.Operators.Convert<string>(bv_);
					CqlQuantity bx_ = this.Quantity(bp_, bw_);
					decimal? by_ = this.ToDaily(bd_ ?? bj_, bx_);
					Dosage ca_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)h_);
					Timing cb_ = ca_?.Timing;
					Timing.RepeatComponent cc_ = cb_?.Repeat;
					List<Time> cd_ = cc_?.TimeOfDayElement;
					IEnumerable<CqlTime> ce_ = context.Operators.LateBoundProperty<IEnumerable<CqlTime>>(cd_, "value");
					int? cf_ = context.Operators.Count<CqlTime>(ce_);
					decimal? cg_ = context.Operators.ConvertIntegerToDecimal(cf_);
					decimal? ch_ = context.Operators.Multiply(ax_, (by_ ?? cg_) ?? 1.0m);
					decimal? ci_ = context.Operators.Divide(ah_, ch_);
					UnsignedInt ck_ = t_?.NumberOfRepeatsAllowedElement;
					int? cl_ = ck_?.Value;
					int? cm_ = context.Operators.Add(1, cl_ ?? 0);
					decimal? cn_ = context.Operators.ConvertIntegerToDecimal(cm_);
					decimal? co_ = context.Operators.Multiply(ad_ ?? ci_, cn_);
					bool? cp_ = context.Operators.Not((bool?)(co_ is null));
					bool? cq_ = context.Operators.And(y_, cp_);

					return cq_ ?? false;
				};
				bool g_()
				{
					List<Dosage> cr_ = R?.DosageInstruction;
					Dosage cs_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)cr_);
					Timing ct_ = cs_?.Timing;
					Timing.RepeatComponent cu_ = ct_?.Repeat;
					DataType cv_ = cu_?.Bounds;
					object cw_ = FHIRHelpers_4_3_000.ToValue(cv_);
					CqlInterval<CqlDateTime> cx_ = cw_ switch { null => null , CqlInterval<CqlDateTime> d => d/* , CqlQuantity => ???, CqlInterval<CqlQuantity> => ??? */, _ => throw new System.Diagnostics.UnreachableException() };
					CqlDateTime cy_ = context.Operators.Start(cx_);
					CqlDate cz_ = context.Operators.DateFrom(cy_);
					FhirDateTime da_ = R?.AuthoredOnElement;
					CqlDateTime db_ = context.Operators.Convert<CqlDateTime>(da_);
					CqlDate dc_ = context.Operators.DateFrom(db_);
					MedicationRequest.DispenseRequestComponent dd_ = R?.DispenseRequest;
					Period de_ = dd_?.ValidityPeriod;
					CqlInterval<CqlDateTime> df_ = FHIRHelpers_4_3_000.ToInterval(de_);
					CqlDateTime dg_ = context.Operators.Start(df_);
					CqlDate dh_ = context.Operators.DateFrom(dg_);
					bool? di_ = context.Operators.Not((bool?)(((cz_ ?? dc_) ?? dh_) is null));
					Dosage dk_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)cr_);
					Timing dl_ = dk_?.Timing;
					Timing.RepeatComponent dm_ = dl_?.Repeat;
					DataType dn_ = dm_?.Bounds;
					object do_ = FHIRHelpers_4_3_000.ToValue(dn_);
					CqlDateTime dq_ = cx_?.high;
					bool? dr_ = context.Operators.Not((bool?)(dq_ is null));
					bool? ds_ = context.Operators.And(di_, dr_);

					return ds_ ?? false;
				};
				if (f_())
				{
					List<Dosage> dt_ = R?.DosageInstruction;
					Dosage du_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)dt_);
					Timing dv_ = du_?.Timing;
					Timing.RepeatComponent dw_ = dv_?.Repeat;
					DataType dx_ = dw_?.Bounds;
					object dy_ = FHIRHelpers_4_3_000.ToValue(dx_);
					CqlInterval<CqlDateTime> dz_ = dy_ switch { null => null , CqlInterval<CqlDateTime> e => e/* , CqlQuantity => ???, CqlInterval<CqlQuantity> => ??? */, _ => throw new System.Diagnostics.UnreachableException() };
					CqlDateTime ea_ = context.Operators.Start(dz_);
					CqlDate eb_ = context.Operators.DateFrom(ea_);
					FhirDateTime ec_ = R?.AuthoredOnElement;
					CqlDateTime ed_ = context.Operators.Convert<CqlDateTime>(ec_);
					CqlDate ee_ = context.Operators.DateFrom(ed_);
					MedicationRequest.DispenseRequestComponent ef_ = R?.DispenseRequest;
					Period eg_ = ef_?.ValidityPeriod;
					CqlInterval<CqlDateTime> eh_ = FHIRHelpers_4_3_000.ToInterval(eg_);
					CqlDateTime ei_ = context.Operators.Start(eh_);
					CqlDate ej_ = context.Operators.DateFrom(ei_);
					Dosage el_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)dt_);
					Timing em_ = el_?.Timing;
					Timing.RepeatComponent en_ = em_?.Repeat;
					DataType eo_ = en_?.Bounds;
					object ep_ = FHIRHelpers_4_3_000.ToValue(eo_);
					CqlDateTime er_ = context.Operators.Start(dz_);
					CqlDate es_ = context.Operators.DateFrom(er_);
					CqlDateTime eu_ = context.Operators.Convert<CqlDateTime>(ec_);
					CqlDate ev_ = context.Operators.DateFrom(eu_);
					Period ex_ = ef_?.ValidityPeriod;
					CqlInterval<CqlDateTime> ey_ = FHIRHelpers_4_3_000.ToInterval(ex_);
					CqlDateTime ez_ = context.Operators.Start(ey_);
					CqlDate fa_ = context.Operators.DateFrom(ez_);
					Duration fc_ = ef_?.ExpectedSupplyDuration;
					CqlQuantity fd_ = FHIRHelpers_4_3_000.ToQuantity(fc_);
					CqlQuantity fe_ = context.Operators.ConvertQuantity(fd_, "d");
					decimal? ff_ = fe_?.value;
					Quantity fh_ = ef_?.Quantity;
					CqlQuantity fi_ = FHIRHelpers_4_3_000.ToQuantity(fh_);
					decimal? fj_ = fi_?.value;
					Dosage fl_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)dt_);
					List<Dosage.DoseAndRateComponent> fm_ = fl_?.DoseAndRate;
					Dosage.DoseAndRateComponent fn_ = context.Operators.SingletonFrom<Dosage.DoseAndRateComponent>((IEnumerable<Dosage.DoseAndRateComponent>)fm_);
					DataType fo_ = fn_?.Dose;
					object fp_ = FHIRHelpers_4_3_000.ToValue(fo_);
					CqlInterval<CqlQuantity> fq_ = fp_ switch { null => null , CqlInterval<CqlQuantity> f => f/* , CqlQuantity => ??? */, _ => throw new System.Diagnostics.UnreachableException() };
					CqlQuantity fr_ = context.Operators.End(fq_);
					Dosage ft_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)dt_);
					List<Dosage.DoseAndRateComponent> fu_ = ft_?.DoseAndRate;
					Dosage.DoseAndRateComponent fv_ = context.Operators.SingletonFrom<Dosage.DoseAndRateComponent>((IEnumerable<Dosage.DoseAndRateComponent>)fu_);
					DataType fw_ = fv_?.Dose;
					object fx_ = FHIRHelpers_4_3_000.ToValue(fw_);
					CqlQuantity fy_ = fx_ switch { null => null , CqlQuantity g => g/* , CqlInterval<CqlQuantity> => ??? */, _ => throw new System.Diagnostics.UnreachableException() };
					decimal? fz_ = (fr_ ?? fy_)?.value;
					Dosage gb_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)dt_);
					Timing gc_ = gb_?.Timing;
					Timing.RepeatComponent gd_ = gc_?.Repeat;
					PositiveInt ge_ = gd_?.FrequencyMaxElement;
					int? gf_ = ge_?.Value;
					Dosage gh_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)dt_);
					Timing gi_ = gh_?.Timing;
					Timing.RepeatComponent gj_ = gi_?.Repeat;
					PositiveInt gk_ = gj_?.FrequencyElement;
					int? gl_ = gk_?.Value;
					Dosage gn_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)dt_);
					Timing go_ = gn_?.Timing;
					Timing.RepeatComponent gp_ = go_?.Repeat;
					FhirDecimal gq_ = gp_?.PeriodElement;
					decimal? gr_ = gq_?.Value;
					Dosage gt_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)dt_);
					Timing gu_ = gt_?.Timing;
					Timing.RepeatComponent gv_ = gu_?.Repeat;
					Code<Timing.UnitsOfTime> gw_ = gv_?.PeriodUnitElement;
					Timing.UnitsOfTime? gx_ = gw_?.Value;
					string gy_ = context.Operators.Convert<string>(gx_);
					CqlQuantity gz_ = this.Quantity(gr_, gy_);
					decimal? ha_ = this.ToDaily(gf_ ?? gl_, gz_);
					Dosage hc_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)dt_);
					Timing hd_ = hc_?.Timing;
					Timing.RepeatComponent he_ = hd_?.Repeat;
					List<Time> hf_ = he_?.TimeOfDayElement;
					IEnumerable<CqlTime> hg_ = context.Operators.LateBoundProperty<IEnumerable<CqlTime>>(hf_, "value");
					int? hh_ = context.Operators.Count<CqlTime>(hg_);
					decimal? hi_ = context.Operators.ConvertIntegerToDecimal(hh_);
					decimal? hj_ = context.Operators.Multiply(fz_, (ha_ ?? hi_) ?? 1.0m);
					decimal? hk_ = context.Operators.Divide(fj_, hj_);
					UnsignedInt hm_ = ef_?.NumberOfRepeatsAllowedElement;
					int? hn_ = hm_?.Value;
					int? ho_ = context.Operators.Add(1, hn_ ?? 0);
					decimal? hp_ = context.Operators.ConvertIntegerToDecimal(ho_);
					decimal? hq_ = context.Operators.Multiply(ff_ ?? hk_, hp_);
					decimal? hr_ = context.Operators.ConvertIntegerToDecimal(1);
					decimal? hs_ = context.Operators.Subtract(hq_, hr_);
					CqlQuantity ht_ = this.Quantity(hs_, "day");
					CqlDate hu_ = context.Operators.Add((es_ ?? ev_) ?? fa_, ht_);
					CqlInterval<CqlDate> hv_ = context.Operators.Interval((eb_ ?? ee_) ?? ej_, hu_, true, true);

					return hv_;
				}
				else if (g_())
				{
					List<Dosage> hw_ = R?.DosageInstruction;
					Dosage hx_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)hw_);
					Timing hy_ = hx_?.Timing;
					Timing.RepeatComponent hz_ = hy_?.Repeat;
					DataType ia_ = hz_?.Bounds;
					object ib_ = FHIRHelpers_4_3_000.ToValue(ia_);
					CqlInterval<CqlDateTime> ic_ = ib_ switch { null => null , CqlInterval<CqlDateTime> h => h/* , CqlQuantity => ???, CqlInterval<CqlQuantity> => ??? */, _ => throw new System.Diagnostics.UnreachableException() };
					CqlDateTime id_ = context.Operators.Start(ic_);
					CqlDate ie_ = context.Operators.DateFrom(id_);
					FhirDateTime if_ = R?.AuthoredOnElement;
					CqlDateTime ig_ = context.Operators.Convert<CqlDateTime>(if_);
					CqlDate ih_ = context.Operators.DateFrom(ig_);
					MedicationRequest.DispenseRequestComponent ii_ = R?.DispenseRequest;
					Period ij_ = ii_?.ValidityPeriod;
					CqlInterval<CqlDateTime> ik_ = FHIRHelpers_4_3_000.ToInterval(ij_);
					CqlDateTime il_ = context.Operators.Start(ik_);
					CqlDate im_ = context.Operators.DateFrom(il_);
					Dosage io_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)hw_);
					Timing ip_ = io_?.Timing;
					Timing.RepeatComponent iq_ = ip_?.Repeat;
					DataType ir_ = iq_?.Bounds;
					object is_ = FHIRHelpers_4_3_000.ToValue(ir_);
					CqlDateTime iu_ = context.Operators.End(ic_);
					CqlDate iv_ = context.Operators.DateFrom(iu_);
					CqlInterval<CqlDate> iw_ = context.Operators.Interval((ie_ ?? ih_) ?? im_, iv_, true, true);

					return iw_;
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
		MedicationDispense[] a_ = [
			Dispense,
		];
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
					CqlInterval<CqlQuantity> aa_ = z_ switch { null => null , CqlInterval<CqlQuantity> a => a/* , CqlQuantity => ??? */, _ => throw new System.Diagnostics.UnreachableException() };
					CqlQuantity ab_ = context.Operators.End(aa_);
					Dosage ad_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)u_);
					List<Dosage.DoseAndRateComponent> ae_ = ad_?.DoseAndRate;
					Dosage.DoseAndRateComponent af_ = context.Operators.SingletonFrom<Dosage.DoseAndRateComponent>((IEnumerable<Dosage.DoseAndRateComponent>)ae_);
					DataType ag_ = af_?.Dose;
					object ah_ = FHIRHelpers_4_3_000.ToValue(ag_);
					CqlQuantity ai_ = ah_ switch { null => null , CqlQuantity b => b/* , CqlInterval<CqlQuantity> => ??? */, _ => throw new System.Diagnostics.UnreachableException() };
					decimal? aj_ = (ab_ ?? ai_)?.value;
					Dosage al_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)u_);
					Timing am_ = al_?.Timing;
					Timing.RepeatComponent an_ = am_?.Repeat;
					PositiveInt ao_ = an_?.FrequencyMaxElement;
					int? ap_ = ao_?.Value;
					Dosage ar_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)u_);
					Timing as_ = ar_?.Timing;
					Timing.RepeatComponent at_ = as_?.Repeat;
					PositiveInt au_ = at_?.FrequencyElement;
					int? av_ = au_?.Value;
					Dosage ax_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)u_);
					Timing ay_ = ax_?.Timing;
					Timing.RepeatComponent az_ = ay_?.Repeat;
					FhirDecimal ba_ = az_?.PeriodElement;
					decimal? bb_ = ba_?.Value;
					Dosage bd_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)u_);
					Timing be_ = bd_?.Timing;
					Timing.RepeatComponent bf_ = be_?.Repeat;
					Code<Timing.UnitsOfTime> bg_ = bf_?.PeriodUnitElement;
					Timing.UnitsOfTime? bh_ = bg_?.Value;
					string bi_ = context.Operators.Convert<string>(bh_);
					CqlQuantity bj_ = this.Quantity(bb_, bi_);
					decimal? bk_ = this.ToDaily(ap_ ?? av_, bj_);
					Dosage bm_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)u_);
					Timing bn_ = bm_?.Timing;
					Timing.RepeatComponent bo_ = bn_?.Repeat;
					List<Time> bp_ = bo_?.TimeOfDayElement;
					IEnumerable<CqlTime> bq_ = context.Operators.LateBoundProperty<IEnumerable<CqlTime>>(bp_, "value");
					int? br_ = context.Operators.Count<CqlTime>(bq_);
					decimal? bs_ = context.Operators.ConvertIntegerToDecimal(br_);
					decimal? bt_ = context.Operators.Multiply(aj_, (bk_ ?? bs_) ?? 1.0m);
					decimal? bu_ = context.Operators.Divide(t_, bt_);
					bool? bv_ = context.Operators.Not((bool?)((q_ ?? bu_) is null));
					bool? bw_ = context.Operators.And(m_, bv_);

					return bw_ ?? false;
				};
				if (f_())
				{
					FhirDateTime bx_ = D?.WhenHandedOverElement;
					CqlDateTime by_ = context.Operators.Convert<CqlDateTime>(bx_);
					CqlDate bz_ = context.Operators.DateFrom(by_);
					FhirDateTime ca_ = D?.WhenPreparedElement;
					CqlDateTime cb_ = context.Operators.Convert<CqlDateTime>(ca_);
					CqlDate cc_ = context.Operators.DateFrom(cb_);
					CqlDateTime ce_ = context.Operators.Convert<CqlDateTime>(bx_);
					CqlDate cf_ = context.Operators.DateFrom(ce_);
					CqlDateTime ch_ = context.Operators.Convert<CqlDateTime>(ca_);
					CqlDate ci_ = context.Operators.DateFrom(ch_);
					Quantity cj_ = D?.DaysSupply;
					CqlQuantity ck_ = FHIRHelpers_4_3_000.ToQuantity(cj_);
					CqlQuantity cl_ = context.Operators.ConvertQuantity(ck_, "d");
					decimal? cm_ = cl_?.value;
					Quantity cn_ = D?.Quantity;
					CqlQuantity co_ = FHIRHelpers_4_3_000.ToQuantity(cn_);
					decimal? cp_ = co_?.value;
					List<Dosage> cq_ = D?.DosageInstruction;
					Dosage cr_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)cq_);
					List<Dosage.DoseAndRateComponent> cs_ = cr_?.DoseAndRate;
					Dosage.DoseAndRateComponent ct_ = context.Operators.SingletonFrom<Dosage.DoseAndRateComponent>((IEnumerable<Dosage.DoseAndRateComponent>)cs_);
					DataType cu_ = ct_?.Dose;
					object cv_ = FHIRHelpers_4_3_000.ToValue(cu_);
					CqlInterval<CqlQuantity> cw_ = cv_ switch { null => null , CqlInterval<CqlQuantity> c => c/* , CqlQuantity => ??? */, _ => throw new System.Diagnostics.UnreachableException() };
					CqlQuantity cx_ = context.Operators.End(cw_);
					Dosage cz_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)cq_);
					List<Dosage.DoseAndRateComponent> da_ = cz_?.DoseAndRate;
					Dosage.DoseAndRateComponent db_ = context.Operators.SingletonFrom<Dosage.DoseAndRateComponent>((IEnumerable<Dosage.DoseAndRateComponent>)da_);
					DataType dc_ = db_?.Dose;
					object dd_ = FHIRHelpers_4_3_000.ToValue(dc_);
					CqlQuantity de_ = dd_ switch { null => null , CqlQuantity d => d/* , CqlInterval<CqlQuantity> => ??? */, _ => throw new System.Diagnostics.UnreachableException() };
					decimal? df_ = (cx_ ?? de_)?.value;
					Dosage dh_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)cq_);
					Timing di_ = dh_?.Timing;
					Timing.RepeatComponent dj_ = di_?.Repeat;
					PositiveInt dk_ = dj_?.FrequencyMaxElement;
					int? dl_ = dk_?.Value;
					Dosage dn_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)cq_);
					Timing do_ = dn_?.Timing;
					Timing.RepeatComponent dp_ = do_?.Repeat;
					PositiveInt dq_ = dp_?.FrequencyElement;
					int? dr_ = dq_?.Value;
					Dosage dt_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)cq_);
					Timing du_ = dt_?.Timing;
					Timing.RepeatComponent dv_ = du_?.Repeat;
					FhirDecimal dw_ = dv_?.PeriodElement;
					decimal? dx_ = dw_?.Value;
					Dosage dz_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)cq_);
					Timing ea_ = dz_?.Timing;
					Timing.RepeatComponent eb_ = ea_?.Repeat;
					Code<Timing.UnitsOfTime> ec_ = eb_?.PeriodUnitElement;
					Timing.UnitsOfTime? ed_ = ec_?.Value;
					string ee_ = context.Operators.Convert<string>(ed_);
					CqlQuantity ef_ = this.Quantity(dx_, ee_);
					decimal? eg_ = this.ToDaily(dl_ ?? dr_, ef_);
					Dosage ei_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)cq_);
					Timing ej_ = ei_?.Timing;
					Timing.RepeatComponent ek_ = ej_?.Repeat;
					List<Time> el_ = ek_?.TimeOfDayElement;
					IEnumerable<CqlTime> em_ = context.Operators.LateBoundProperty<IEnumerable<CqlTime>>(el_, "value");
					int? en_ = context.Operators.Count<CqlTime>(em_);
					decimal? eo_ = context.Operators.ConvertIntegerToDecimal(en_);
					decimal? ep_ = context.Operators.Multiply(df_, (eg_ ?? eo_) ?? 1.0m);
					decimal? eq_ = context.Operators.Divide(cp_, ep_);
					decimal? er_ = context.Operators.ConvertIntegerToDecimal(1);
					decimal? es_ = context.Operators.Subtract(cm_ ?? eq_, er_);
					CqlQuantity et_ = this.Quantity(es_, "day");
					CqlDate eu_ = context.Operators.Add(cf_ ?? ci_, et_);
					CqlInterval<CqlDate> ev_ = context.Operators.Interval(bz_ ?? cc_, eu_, true, true);

					return ev_;
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
		MedicationAdministration[] a_ = [
			Administration,
		];
		CqlInterval<CqlDate> b_(MedicationAdministration M)
		{
			CqlInterval<CqlDate> e_()
			{
				bool f_()
				{
					DataType g_ = Administration?.Effective;
					object h_ = FHIRHelpers_4_3_000.ToValue(g_);
					CqlInterval<CqlDateTime> i_ = h_ switch { null => null , CqlInterval<CqlDateTime> a => a/* , CqlDateTime => ??? */, _ => throw new System.Diagnostics.UnreachableException() };
					CqlDateTime j_ = context.Operators.Start(i_);
					CqlDate k_ = context.Operators.DateFrom(j_);
					bool? l_ = context.Operators.Not((bool?)(k_ is null));
					DataType m_ = Administration?.Medication;
					object n_ = FHIRHelpers_4_3_000.ToValue(m_);
					CqlConcept o_ = n_ switch { null => null , CqlConcept b => b/* , ResourceReference => ??? */, _ => throw new System.Diagnostics.UnreachableException() };
					CqlQuantity p_ = this.TherapeuticDuration(o_);
					bool? q_ = context.Operators.Not((bool?)(p_ is null));
					bool? r_ = context.Operators.And(l_, q_);

					return r_ ?? false;
				};
				if (f_())
				{
					DataType s_ = Administration?.Effective;
					object t_ = FHIRHelpers_4_3_000.ToValue(s_);
					CqlInterval<CqlDateTime> u_ = t_ switch { null => null , CqlInterval<CqlDateTime> c => c/* , CqlDateTime => ??? */, _ => throw new System.Diagnostics.UnreachableException() };
					CqlDateTime v_ = context.Operators.Start(u_);
					CqlDate w_ = context.Operators.DateFrom(v_);
					object y_ = FHIRHelpers_4_3_000.ToValue(s_);
					CqlDateTime aa_ = context.Operators.Start(u_);
					CqlDate ab_ = context.Operators.DateFrom(aa_);
					DataType ac_ = Administration?.Medication;
					object ad_ = FHIRHelpers_4_3_000.ToValue(ac_);
					CqlConcept ae_ = ad_ switch { null => null , CqlConcept d => d/* , ResourceReference => ??? */, _ => throw new System.Diagnostics.UnreachableException() };
					CqlQuantity af_ = this.TherapeuticDuration(ae_);
					CqlDate ag_ = context.Operators.Add(ab_, af_);
					CqlQuantity ah_ = context.Operators.ConvertIntegerToQuantity(1);
					CqlDate ai_ = context.Operators.Subtract(ag_, ah_);
					CqlInterval<CqlDate> aj_ = context.Operators.Interval(w_, ai_, true, true);

					return aj_;
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
			if ((context.Operators.Not((bool?)(Intervals is null))) ?? false)
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
				return null;
			}
		};

		return a_();
	}

    [CqlDeclaration("RolloutIntervals")]
	public IEnumerable<CqlInterval<CqlDate>> RolloutIntervals(IEnumerable<CqlInterval<CqlDate>> intervals)
	{
		IEnumerable<CqlInterval<CqlDate>> a_(IEnumerable<CqlInterval<CqlDate>> R, CqlInterval<CqlDate> I)
		{
			CqlInterval<CqlDate>[] c_ = [
				I,
			];
			CqlInterval<CqlDate> d_(CqlInterval<CqlDate> X)
			{
				CqlInterval<CqlDate> i_ = context.Operators.Last<CqlInterval<CqlDate>>(R);
				CqlDate j_ = context.Operators.End(i_);
				CqlQuantity k_ = context.Operators.Quantity(1m, "day");
				CqlDate l_ = context.Operators.Add(j_, k_);
				CqlDate m_ = context.Operators.Start(X);
				CqlDate[] n_ = [
					l_,
					m_,
				];
				CqlDate o_ = context.Operators.Max<CqlDate>(n_ as IEnumerable<CqlDate>);
				CqlDate q_ = context.Operators.End(i_);
				CqlDate s_ = context.Operators.Add(q_, k_);
				CqlDate[] u_ = [
					s_,
					m_,
				];
				CqlDate v_ = context.Operators.Max<CqlDate>(u_ as IEnumerable<CqlDate>);
				CqlDate x_ = context.Operators.End(X);
				int? y_ = context.Operators.DurationBetween(m_, x_, "day");
				decimal? z_ = context.Operators.ConvertIntegerToDecimal(y_ ?? 0);
				CqlQuantity aa_ = this.Quantity(z_, "day");
				CqlDate ab_ = context.Operators.Add(v_, aa_);
				CqlInterval<CqlDate> ac_ = context.Operators.Interval(o_, ab_, true, true);

				return ac_;
			};
			IEnumerable<CqlInterval<CqlDate>> e_ = context.Operators.Select<CqlInterval<CqlDate>, CqlInterval<CqlDate>>((IEnumerable<CqlInterval<CqlDate>>)c_, d_);
			CqlInterval<CqlDate> f_ = context.Operators.SingletonFrom<CqlInterval<CqlDate>>(e_);
			CqlInterval<CqlDate>[] g_ = [
				f_,
			];
			IEnumerable<CqlInterval<CqlDate>> h_ = context.Operators.Union<CqlInterval<CqlDate>>(R, g_ as IEnumerable<CqlInterval<CqlDate>>);

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
				MedicationRequest b_ = medication switch { null => null , MedicationRequest a => a/* , MedicationDispense => ??? */, _ => throw new System.Diagnostics.UnreachableException() };
				CqlInterval<CqlDate> c_ = this.MedicationRequestPeriod(b_);

				return c_;
			}
			else if (medication is MedicationDispense)
			{
				MedicationDispense d_ = medication switch { null => null , MedicationDispense b => b/* , MedicationRequest => ??? */, _ => throw new System.Diagnostics.UnreachableException() };
				CqlInterval<CqlDate> e_ = this.MedicationDispensePeriod(d_);

				return e_;
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

			return l_ as bool?;
		};
		IEnumerable<object> b_ = context.Operators.Where<object>(Medications, a_);
		CqlInterval<CqlDate> c_(object M)
		{
			MedicationRequest m_ = M switch { null => null , MedicationRequest a => a/* , MedicationDispense => ??? */, _ => throw new System.Diagnostics.UnreachableException() };
			CqlInterval<CqlDate> n_ = this.MedicationRequestPeriod(m_);

			return n_;
		};
		IEnumerable<CqlInterval<CqlDate>> d_ = context.Operators.Select<object, CqlInterval<CqlDate>>(b_, c_);
		bool? e_(object M)
		{
			bool o_ = M is MedicationDispense;

			return o_ as bool?;
		};
		IEnumerable<object> f_ = context.Operators.Where<object>(Medications, e_);
		CqlInterval<CqlDate> g_(object M)
		{
			MedicationDispense p_ = M switch { null => null , MedicationDispense b => b/* , MedicationRequest => ??? */, _ => throw new System.Diagnostics.UnreachableException() };
			CqlInterval<CqlDate> q_ = this.MedicationDispensePeriod(p_);

			return q_;
		};
		IEnumerable<CqlInterval<CqlDate>> h_ = context.Operators.Select<object, CqlInterval<CqlDate>>(f_, g_);
		IEnumerable<CqlInterval<CqlDate>> i_ = this.RolloutIntervals(h_);
		IEnumerable<CqlInterval<CqlDate>> j_ = context.Operators.Union<CqlInterval<CqlDate>>(d_, i_);
		int? k_ = this.CumulativeDuration(j_);

		return k_;
	}

}
