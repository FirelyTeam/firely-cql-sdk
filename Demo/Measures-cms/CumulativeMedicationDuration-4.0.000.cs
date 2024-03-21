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
[System.CodeDom.Compiler.GeneratedCode(".NET Code Generation", "1.0.0.0")]
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
		var b_ = context.Operators.SingleOrNull<Patient>(a_);

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
			if ((context.Operators.Equivalent(frequency, this.HS()) ?? false))
			{
				var b_ = context.Operators.ConvertIntegerToDecimal((int?)1);

				return b_;
			}
			else if ((context.Operators.Equivalent(frequency, this.WAKE()) ?? false))
			{
				var c_ = context.Operators.ConvertIntegerToDecimal((int?)1);

				return c_;
			}
			else if ((context.Operators.Equivalent(frequency, this.C()) ?? false))
			{
				var d_ = context.Operators.ConvertIntegerToDecimal((int?)3);

				return d_;
			}
			else if ((context.Operators.Equivalent(frequency, this.CM()) ?? false))
			{
				var e_ = context.Operators.ConvertIntegerToDecimal((int?)1);

				return e_;
			}
			else if ((context.Operators.Equivalent(frequency, this.CD()) ?? false))
			{
				var f_ = context.Operators.ConvertIntegerToDecimal((int?)1);

				return f_;
			}
			else if ((context.Operators.Equivalent(frequency, this.CV()) ?? false))
			{
				var g_ = context.Operators.ConvertIntegerToDecimal((int?)1);

				return g_;
			}
			else if ((context.Operators.Equivalent(frequency, this.AC()) ?? false))
			{
				var h_ = context.Operators.ConvertIntegerToDecimal((int?)3);

				return h_;
			}
			else if ((context.Operators.Equivalent(frequency, this.ACM()) ?? false))
			{
				var i_ = context.Operators.ConvertIntegerToDecimal((int?)1);

				return i_;
			}
			else if ((context.Operators.Equivalent(frequency, this.ACD()) ?? false))
			{
				var j_ = context.Operators.ConvertIntegerToDecimal((int?)1);

				return j_;
			}
			else if ((context.Operators.Equivalent(frequency, this.ACV()) ?? false))
			{
				var k_ = context.Operators.ConvertIntegerToDecimal((int?)1);

				return k_;
			}
			else if ((context.Operators.Equivalent(frequency, this.PC()) ?? false))
			{
				var l_ = context.Operators.ConvertIntegerToDecimal((int?)3);

				return l_;
			}
			else if ((context.Operators.Equivalent(frequency, this.PCM()) ?? false))
			{
				var m_ = context.Operators.ConvertIntegerToDecimal((int?)1);

				return m_;
			}
			else if ((context.Operators.Equivalent(frequency, this.PCD()) ?? false))
			{
				var n_ = context.Operators.ConvertIntegerToDecimal((int?)1);

				return n_;
			}
			else if ((context.Operators.Equivalent(frequency, this.PCV()) ?? false))
			{
				var o_ = context.Operators.ConvertIntegerToDecimal((int?)1);

				return o_;
			}
			else if ((context.Operators.Equivalent(frequency, this.MORN()) ?? false))
			{
				var p_ = context.Operators.ConvertIntegerToDecimal((int?)1);

				return p_;
			}
			else if ((context.Operators.Equivalent(frequency, this.MORN_early()) ?? false))
			{
				var q_ = context.Operators.ConvertIntegerToDecimal((int?)1);

				return q_;
			}
			else if ((context.Operators.Equivalent(frequency, this.MORN_late()) ?? false))
			{
				var r_ = context.Operators.ConvertIntegerToDecimal((int?)1);

				return r_;
			}
			else if ((context.Operators.Equivalent(frequency, this.NOON()) ?? false))
			{
				var s_ = context.Operators.ConvertIntegerToDecimal((int?)1);

				return s_;
			}
			else if ((context.Operators.Equivalent(frequency, this.AFT()) ?? false))
			{
				var t_ = context.Operators.ConvertIntegerToDecimal((int?)1);

				return t_;
			}
			else if ((context.Operators.Equivalent(frequency, this.AFT_early()) ?? false))
			{
				var u_ = context.Operators.ConvertIntegerToDecimal((int?)1);

				return u_;
			}
			else if ((context.Operators.Equivalent(frequency, this.AFT_late()) ?? false))
			{
				var v_ = context.Operators.ConvertIntegerToDecimal((int?)1);

				return v_;
			}
			else if ((context.Operators.Equivalent(frequency, this.EVE()) ?? false))
			{
				var w_ = context.Operators.ConvertIntegerToDecimal((int?)1);

				return w_;
			}
			else if ((context.Operators.Equivalent(frequency, this.EVE_early()) ?? false))
			{
				var x_ = context.Operators.ConvertIntegerToDecimal((int?)1);

				return x_;
			}
			else if ((context.Operators.Equivalent(frequency, this.EVE_late()) ?? false))
			{
				var y_ = context.Operators.ConvertIntegerToDecimal((int?)1);

				return y_;
			}
			else if ((context.Operators.Equivalent(frequency, this.NIGHT()) ?? false))
			{
				var z_ = context.Operators.ConvertIntegerToDecimal((int?)1);

				return z_;
			}
			else if ((context.Operators.Equivalent(frequency, this.PHS()) ?? false))
			{
				var aa_ = context.Operators.ConvertIntegerToDecimal((int?)1);

				return aa_;
			}
			else if ((context.Operators.Equivalent(frequency, this.Once_daily__qualifier_value_()) ?? false))
			{
				return (decimal?)1.0m;
			}
			else if ((context.Operators.Equivalent(frequency, this.Twice_a_day__qualifier_value_()) ?? false))
			{
				return (decimal?)2.0m;
			}
			else if ((context.Operators.Equivalent(frequency, this.Three_times_daily__qualifier_value_()) ?? false))
			{
				return (decimal?)3.0m;
			}
			else if ((context.Operators.Equivalent(frequency, this.Four_times_daily__qualifier_value_()) ?? false))
			{
				return (decimal?)4.0m;
			}
			else if ((context.Operators.Equivalent(frequency, this.Every_twenty_four_hours__qualifier_value_()) ?? false))
			{
				return (decimal?)1.0m;
			}
			else if ((context.Operators.Equivalent(frequency, this.Every_twelve_hours__qualifier_value_()) ?? false))
			{
				return (decimal?)2.0m;
			}
			else if ((context.Operators.Equivalent(frequency, this.Every_thirty_six_hours__qualifier_value_()) ?? false))
			{
				return (decimal?)0.67m;
			}
			else if ((context.Operators.Equivalent(frequency, this.Every_eight_hours__qualifier_value_()) ?? false))
			{
				return (decimal?)3.0m;
			}
			else if ((context.Operators.Equivalent(frequency, this.Every_four_hours__qualifier_value_()) ?? false))
			{
				return (decimal?)6.0m;
			}
			else if ((context.Operators.Equivalent(frequency, this.Every_six_hours__qualifier_value_()) ?? false))
			{
				return (decimal?)4.0m;
			}
			else if ((context.Operators.Equivalent(frequency, this.Every_seventy_two_hours__qualifier_value_()) ?? false))
			{
				return (decimal?)0.33m;
			}
			else if ((context.Operators.Equivalent(frequency, this.Every_forty_eight_hours__qualifier_value_()) ?? false))
			{
				return (decimal?)0.5m;
			}
			else if ((context.Operators.Equivalent(frequency, this.Every_eight_to_twelve_hours__qualifier_value_()) ?? false))
			{
				return (decimal?)3.0m;
			}
			else if ((context.Operators.Equivalent(frequency, this.Every_six_to_eight_hours__qualifier_value_()) ?? false))
			{
				return (decimal?)4.0m;
			}
			else if ((context.Operators.Equivalent(frequency, this.Every_three_to_four_hours__qualifier_value_()) ?? false))
			{
				return (decimal?)8.0m;
			}
			else if ((context.Operators.Equivalent(frequency, this.Every_three_to_six_hours__qualifier_value_()) ?? false))
			{
				return (decimal?)8.0m;
			}
			else if ((context.Operators.Equivalent(frequency, this.Every_two_to_four_hours__qualifier_value_()) ?? false))
			{
				return (decimal?)12.0m;
			}
			else if ((context.Operators.Equivalent(frequency, this.One_to_four_times_a_day__qualifier_value_()) ?? false))
			{
				return (decimal?)4.0m;
			}
			else if ((context.Operators.Equivalent(frequency, this.One_to_three_times_a_day__qualifier_value_()) ?? false))
			{
				return (decimal?)3.0m;
			}
			else if ((context.Operators.Equivalent(frequency, this.One_to_two_times_a_day__qualifier_value_()) ?? false))
			{
				return (decimal?)2.0m;
			}
			else if ((context.Operators.Equivalent(frequency, this.Two_to_four_times_a_day__qualifier_value_()) ?? false))
			{
				return (decimal?)4.0m;
			}
			else
			{
				var ab_ = this.ErrorLevel();
				var ac_ = context.Operators.Concatenate("Unknown frequency code ", (frequency?.code ?? ""));
				var ad_ = context.Operators.Message<object>(null, "CMDLogic.ToDaily.UnknownFrequencyCode", ab_, ac_);

				return (decimal?)ad_;
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
				if ((context.Operators.And(context.Operators.Not((bool?)(((context.Operators.DateFrom(context.Operators.Start((FHIRHelpers_4_3_000.ToValue((((context.Operators.SingleOrNull<Dosage>((R?.DosageInstruction as IEnumerable<Dosage>)))?.Timing)?.Repeat)?.Bounds) as CqlInterval<CqlDateTime>))) ?? context.Operators.DateFrom(context.Operators.Convert<CqlDateTime>(R?.AuthoredOnElement))) ?? context.Operators.DateFrom(context.Operators.Start(FHIRHelpers_4_3_000.ToInterval(R?.DispenseRequest?.ValidityPeriod)))) is null)), context.Operators.Not((bool?)(context.Operators.Multiply(((context.Operators.ConvertQuantity(FHIRHelpers_4_3_000.ToQuantity(R?.DispenseRequest?.ExpectedSupplyDuration), "d"))?.value ?? context.Operators.Divide(FHIRHelpers_4_3_000.ToQuantity(R?.DispenseRequest?.Quantity)?.value, context.Operators.Multiply((context.Operators.End((FHIRHelpers_4_3_000.ToValue((context.Operators.SingleOrNull<Dosage.DoseAndRateComponent>(((context.Operators.SingleOrNull<Dosage>((R?.DosageInstruction as IEnumerable<Dosage>)))?.DoseAndRate as IEnumerable<Dosage.DoseAndRateComponent>)))?.Dose) as CqlInterval<CqlQuantity>)) ?? (FHIRHelpers_4_3_000.ToValue((context.Operators.SingleOrNull<Dosage.DoseAndRateComponent>(((context.Operators.SingleOrNull<Dosage>((R?.DosageInstruction as IEnumerable<Dosage>)))?.DoseAndRate as IEnumerable<Dosage.DoseAndRateComponent>)))?.Dose) as CqlQuantity))?.value, ((this.ToDaily((((((context.Operators.SingleOrNull<Dosage>((R?.DosageInstruction as IEnumerable<Dosage>)))?.Timing)?.Repeat)?.FrequencyMaxElement)?.Value ?? ((((context.Operators.SingleOrNull<Dosage>((R?.DosageInstruction as IEnumerable<Dosage>)))?.Timing)?.Repeat)?.FrequencyElement)?.Value), this.Quantity(((((context.Operators.SingleOrNull<Dosage>((R?.DosageInstruction as IEnumerable<Dosage>)))?.Timing)?.Repeat)?.PeriodElement)?.Value, context.Operators.Convert<Code<Timing.UnitsOfTime>>(((((context.Operators.SingleOrNull<Dosage>((R?.DosageInstruction as IEnumerable<Dosage>)))?.Timing)?.Repeat)?.PeriodUnitElement)?.Value))) ?? context.Operators.ConvertIntegerToDecimal(context.Operators.CountOrNull<CqlTime>(context.Operators.LateBoundProperty<IEnumerable<CqlTime>>((((context.Operators.SingleOrNull<Dosage>((R?.DosageInstruction as IEnumerable<Dosage>)))?.Timing)?.Repeat)?.TimeOfDayElement, "value")))) ?? (decimal?)1.0m)))), context.Operators.ConvertIntegerToDecimal(context.Operators.Add((int?)1, (R?.DispenseRequest?.NumberOfRepeatsAllowedElement?.Value ?? (int?)0)))) is null))) ?? false))
				{
					var f_ = context.Operators.SingleOrNull<Dosage>((R?.DosageInstruction as IEnumerable<Dosage>));
					var g_ = FHIRHelpers_4_3_000.ToValue(f_?.Timing?.Repeat?.Bounds);
					var h_ = context.Operators.Start((g_ as CqlInterval<CqlDateTime>));
					var i_ = context.Operators.DateFrom(h_);
					var j_ = context.Operators.Convert<CqlDateTime>(R?.AuthoredOnElement);
					var k_ = context.Operators.DateFrom(j_);
					var l_ = FHIRHelpers_4_3_000.ToInterval(R?.DispenseRequest?.ValidityPeriod);
					var m_ = context.Operators.Start(l_);
					var n_ = context.Operators.DateFrom(m_);
					var p_ = FHIRHelpers_4_3_000.ToValue(f_?.Timing?.Repeat?.Bounds);
					var q_ = context.Operators.Start((p_ as CqlInterval<CqlDateTime>));
					var r_ = context.Operators.DateFrom(q_);
					var t_ = context.Operators.DateFrom(j_);
					var v_ = context.Operators.Start(l_);
					var w_ = context.Operators.DateFrom(v_);
					var x_ = FHIRHelpers_4_3_000.ToQuantity(R?.DispenseRequest?.ExpectedSupplyDuration);
					var y_ = context.Operators.ConvertQuantity(x_, "d");
					var z_ = FHIRHelpers_4_3_000.ToQuantity(R?.DispenseRequest?.Quantity);
					var ab_ = context.Operators.SingleOrNull<Dosage.DoseAndRateComponent>((f_?.DoseAndRate as IEnumerable<Dosage.DoseAndRateComponent>));
					var ac_ = FHIRHelpers_4_3_000.ToValue(ab_?.Dose);
					var ad_ = context.Operators.End((ac_ as CqlInterval<CqlQuantity>));
					var af_ = context.Operators.SingleOrNull<Dosage.DoseAndRateComponent>((f_?.DoseAndRate as IEnumerable<Dosage.DoseAndRateComponent>));
					var ag_ = FHIRHelpers_4_3_000.ToValue(af_?.Dose);
					var al_ = context.Operators.Convert<Code<Timing.UnitsOfTime>>(f_?.Timing?.Repeat?.PeriodUnitElement?.Value);
					var am_ = this.Quantity(f_?.Timing?.Repeat?.PeriodElement?.Value, al_);
					var an_ = this.ToDaily((f_?.Timing?.Repeat?.FrequencyMaxElement?.Value ?? f_?.Timing?.Repeat?.FrequencyElement?.Value), am_);
					var ap_ = context.Operators.LateBoundProperty<IEnumerable<CqlTime>>(f_?.Timing?.Repeat?.TimeOfDayElement, "value");
					var aq_ = context.Operators.CountOrNull<CqlTime>(ap_);
					var ar_ = context.Operators.ConvertIntegerToDecimal(aq_);
					var as_ = context.Operators.Multiply((ad_ ?? (ag_ as CqlQuantity))?.value, ((an_ ?? ar_) ?? (decimal?)1.0m));
					var at_ = context.Operators.Divide(z_?.value, as_);
					var au_ = context.Operators.Add((int?)1, (R?.DispenseRequest?.NumberOfRepeatsAllowedElement?.Value ?? (int?)0));
					var av_ = context.Operators.ConvertIntegerToDecimal(au_);
					var aw_ = context.Operators.Multiply((y_?.value ?? at_), av_);
					var ax_ = context.Operators.ConvertIntegerToDecimal((int?)1);
					var ay_ = context.Operators.Subtract(aw_, ax_);
					var az_ = this.Quantity(ay_, "day");
					var ba_ = context.Operators.Add(((r_ ?? t_) ?? w_), az_);
					var bb_ = context.Operators.Interval(((i_ ?? k_) ?? n_), ba_, true, true);

					return bb_;
				}
				else if ((context.Operators.And(context.Operators.Not((bool?)(((context.Operators.DateFrom(context.Operators.Start((FHIRHelpers_4_3_000.ToValue((((context.Operators.SingleOrNull<Dosage>((R?.DosageInstruction as IEnumerable<Dosage>)))?.Timing)?.Repeat)?.Bounds) as CqlInterval<CqlDateTime>))) ?? context.Operators.DateFrom(context.Operators.Convert<CqlDateTime>(R?.AuthoredOnElement))) ?? context.Operators.DateFrom(context.Operators.Start(FHIRHelpers_4_3_000.ToInterval(R?.DispenseRequest?.ValidityPeriod)))) is null)), context.Operators.Not((bool?)((FHIRHelpers_4_3_000.ToValue((((context.Operators.SingleOrNull<Dosage>((R?.DosageInstruction as IEnumerable<Dosage>)))?.Timing)?.Repeat)?.Bounds) as CqlInterval<CqlDateTime>)?.high is null))) ?? false))
				{
					var bc_ = context.Operators.SingleOrNull<Dosage>((R?.DosageInstruction as IEnumerable<Dosage>));
					var bd_ = FHIRHelpers_4_3_000.ToValue(bc_?.Timing?.Repeat?.Bounds);
					var be_ = context.Operators.Start((bd_ as CqlInterval<CqlDateTime>));
					var bf_ = context.Operators.DateFrom(be_);
					var bg_ = context.Operators.Convert<CqlDateTime>(R?.AuthoredOnElement);
					var bh_ = context.Operators.DateFrom(bg_);
					var bi_ = FHIRHelpers_4_3_000.ToInterval(R?.DispenseRequest?.ValidityPeriod);
					var bj_ = context.Operators.Start(bi_);
					var bk_ = context.Operators.DateFrom(bj_);
					var bm_ = FHIRHelpers_4_3_000.ToValue(bc_?.Timing?.Repeat?.Bounds);
					var bn_ = context.Operators.End((bm_ as CqlInterval<CqlDateTime>));
					var bo_ = context.Operators.DateFrom(bn_);
					var bp_ = context.Operators.Interval(((bf_ ?? bh_) ?? bk_), bo_, true, true);

					return bp_;
				}
				else
				{
					CqlInterval<CqlDate> bq_ = null;

					return (bq_ as CqlInterval<CqlDate>);
				};
			};

			return e_();
		};
		var c_ = context.Operators.SelectOrNull<MedicationRequest, CqlInterval<CqlDate>>(a_, b_);
		var d_ = context.Operators.SingleOrNull<CqlInterval<CqlDate>>(c_);

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
				if ((context.Operators.And(context.Operators.Not((bool?)((context.Operators.DateFrom(context.Operators.Convert<CqlDateTime>(D?.WhenHandedOverElement)) ?? context.Operators.DateFrom(context.Operators.Convert<CqlDateTime>(D?.WhenPreparedElement))) is null)), context.Operators.Not((bool?)(((context.Operators.ConvertQuantity(FHIRHelpers_4_3_000.ToQuantity(D?.DaysSupply), "d"))?.value ?? context.Operators.Divide(FHIRHelpers_4_3_000.ToQuantity(D?.Quantity)?.value, context.Operators.Multiply((context.Operators.End((FHIRHelpers_4_3_000.ToValue((context.Operators.SingleOrNull<Dosage.DoseAndRateComponent>(((context.Operators.SingleOrNull<Dosage>((D?.DosageInstruction as IEnumerable<Dosage>)))?.DoseAndRate as IEnumerable<Dosage.DoseAndRateComponent>)))?.Dose) as CqlInterval<CqlQuantity>)) ?? (FHIRHelpers_4_3_000.ToValue((context.Operators.SingleOrNull<Dosage.DoseAndRateComponent>(((context.Operators.SingleOrNull<Dosage>((D?.DosageInstruction as IEnumerable<Dosage>)))?.DoseAndRate as IEnumerable<Dosage.DoseAndRateComponent>)))?.Dose) as CqlQuantity))?.value, ((this.ToDaily((((((context.Operators.SingleOrNull<Dosage>((D?.DosageInstruction as IEnumerable<Dosage>)))?.Timing)?.Repeat)?.FrequencyMaxElement)?.Value ?? ((((context.Operators.SingleOrNull<Dosage>((D?.DosageInstruction as IEnumerable<Dosage>)))?.Timing)?.Repeat)?.FrequencyElement)?.Value), this.Quantity(((((context.Operators.SingleOrNull<Dosage>((D?.DosageInstruction as IEnumerable<Dosage>)))?.Timing)?.Repeat)?.PeriodElement)?.Value, context.Operators.Convert<Code<Timing.UnitsOfTime>>(((((context.Operators.SingleOrNull<Dosage>((D?.DosageInstruction as IEnumerable<Dosage>)))?.Timing)?.Repeat)?.PeriodUnitElement)?.Value))) ?? context.Operators.ConvertIntegerToDecimal(context.Operators.CountOrNull<CqlTime>(context.Operators.LateBoundProperty<IEnumerable<CqlTime>>((((context.Operators.SingleOrNull<Dosage>((D?.DosageInstruction as IEnumerable<Dosage>)))?.Timing)?.Repeat)?.TimeOfDayElement, "value")))) ?? (decimal?)1.0m)))) is null))) ?? false))
				{
					var f_ = context.Operators.Convert<CqlDateTime>(D?.WhenHandedOverElement);
					var g_ = context.Operators.DateFrom(f_);
					var h_ = context.Operators.Convert<CqlDateTime>(D?.WhenPreparedElement);
					var i_ = context.Operators.DateFrom(h_);
					var k_ = context.Operators.DateFrom(f_);
					var m_ = context.Operators.DateFrom(h_);
					var n_ = FHIRHelpers_4_3_000.ToQuantity(D?.DaysSupply);
					var o_ = context.Operators.ConvertQuantity(n_, "d");
					var p_ = FHIRHelpers_4_3_000.ToQuantity(D?.Quantity);
					var q_ = context.Operators.SingleOrNull<Dosage>((D?.DosageInstruction as IEnumerable<Dosage>));
					var r_ = context.Operators.SingleOrNull<Dosage.DoseAndRateComponent>((q_?.DoseAndRate as IEnumerable<Dosage.DoseAndRateComponent>));
					var s_ = FHIRHelpers_4_3_000.ToValue(r_?.Dose);
					var t_ = context.Operators.End((s_ as CqlInterval<CqlQuantity>));
					var v_ = context.Operators.SingleOrNull<Dosage.DoseAndRateComponent>((q_?.DoseAndRate as IEnumerable<Dosage.DoseAndRateComponent>));
					var w_ = FHIRHelpers_4_3_000.ToValue(v_?.Dose);
					var ab_ = context.Operators.Convert<Code<Timing.UnitsOfTime>>(q_?.Timing?.Repeat?.PeriodUnitElement?.Value);
					var ac_ = this.Quantity(q_?.Timing?.Repeat?.PeriodElement?.Value, ab_);
					var ad_ = this.ToDaily((q_?.Timing?.Repeat?.FrequencyMaxElement?.Value ?? q_?.Timing?.Repeat?.FrequencyElement?.Value), ac_);
					var af_ = context.Operators.LateBoundProperty<IEnumerable<CqlTime>>(q_?.Timing?.Repeat?.TimeOfDayElement, "value");
					var ag_ = context.Operators.CountOrNull<CqlTime>(af_);
					var ah_ = context.Operators.ConvertIntegerToDecimal(ag_);
					var ai_ = context.Operators.Multiply((t_ ?? (w_ as CqlQuantity))?.value, ((ad_ ?? ah_) ?? (decimal?)1.0m));
					var aj_ = context.Operators.Divide(p_?.value, ai_);
					var ak_ = context.Operators.ConvertIntegerToDecimal((int?)1);
					var al_ = context.Operators.Subtract((o_?.value ?? aj_), ak_);
					var am_ = this.Quantity(al_, "day");
					var an_ = context.Operators.Add((k_ ?? m_), am_);
					var ao_ = context.Operators.Interval((g_ ?? i_), an_, true, true);

					return ao_;
				}
				else
				{
					CqlInterval<CqlDate> ap_ = null;

					return (ap_ as CqlInterval<CqlDate>);
				};
			};

			return e_();
		};
		var c_ = context.Operators.SelectOrNull<MedicationDispense, CqlInterval<CqlDate>>(a_, b_);
		var d_ = context.Operators.SingleOrNull<CqlInterval<CqlDate>>(c_);

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
				if ((context.Operators.And(context.Operators.Not((bool?)(context.Operators.DateFrom(context.Operators.Start((FHIRHelpers_4_3_000.ToValue(Administration?.Effective) as CqlInterval<CqlDateTime>))) is null)), context.Operators.Not((bool?)(this.TherapeuticDuration((FHIRHelpers_4_3_000.ToValue(Administration?.Medication) as CqlConcept)) is null))) ?? false))
				{
					var f_ = FHIRHelpers_4_3_000.ToValue(Administration?.Effective);
					var g_ = context.Operators.Start((f_ as CqlInterval<CqlDateTime>));
					var h_ = context.Operators.DateFrom(g_);
					var j_ = context.Operators.Start((f_ as CqlInterval<CqlDateTime>));
					var k_ = context.Operators.DateFrom(j_);
					var l_ = FHIRHelpers_4_3_000.ToValue(Administration?.Medication);
					var m_ = this.TherapeuticDuration((l_ as CqlConcept));
					var n_ = context.Operators.Add(k_, m_);
					var o_ = context.Operators.ConvertIntegerToQuantity((int?)1);
					var p_ = context.Operators.Subtract(n_, o_);
					var q_ = context.Operators.Interval(h_, p_, true, true);

					return q_;
				}
				else
				{
					CqlInterval<CqlDate> r_ = null;

					return (r_ as CqlInterval<CqlDate>);
				};
			};

			return e_();
		};
		var c_ = context.Operators.SelectOrNull<MedicationAdministration, CqlInterval<CqlDate>>(a_, b_);
		var d_ = context.Operators.SingleOrNull<CqlInterval<CqlDate>>(c_);

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
					var i_ = context.Operators.Add(h_, (int?)1);

					return i_;
				};
				var d_ = context.Operators.SelectOrNull<CqlInterval<CqlDate>, int?>(b_, c_);
				var e_ = context.Operators.Sum(d_);

				return e_;
			}
			else
			{
				return (int?)null;
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
			var d_ = new CqlInterval<CqlDate>[]
			{
				I,
			};
			CqlInterval<CqlDate> e_(CqlInterval<CqlDate> X)
			{
				var j_ = context.Operators.LastOfList<CqlInterval<CqlDate>>(R);
				var k_ = context.Operators.End(j_);
				var l_ = context.Operators.Quantity(1m, "day");
				var m_ = context.Operators.Add(k_, l_);
				var n_ = context.Operators.Start(X);
				var o_ = new CqlDate[]
				{
					m_,
					n_,
				};
				var p_ = context.Operators.MaxOrNull<CqlDate>((o_ as IEnumerable<CqlDate>));
				var r_ = context.Operators.End(j_);
				var t_ = context.Operators.Add(r_, l_);
				var v_ = new CqlDate[]
				{
					t_,
					n_,
				};
				var w_ = context.Operators.MaxOrNull<CqlDate>((v_ as IEnumerable<CqlDate>));
				var y_ = context.Operators.End(X);
				var z_ = context.Operators.DurationBetween(n_, y_, "day");
				var aa_ = context.Operators.ConvertIntegerToDecimal((z_ ?? (int?)0));
				var ab_ = this.Quantity(aa_, "day");
				var ac_ = context.Operators.Add(w_, ab_);
				var ad_ = context.Operators.Interval(p_, ac_, true, true);

				return ad_;
			};
			var f_ = context.Operators.SelectOrNull<CqlInterval<CqlDate>, CqlInterval<CqlDate>>(d_, e_);
			var g_ = context.Operators.SingleOrNull<CqlInterval<CqlDate>>(f_);
			var h_ = new CqlInterval<CqlDate>[]
			{
				g_,
			};
			var i_ = context.Operators.ListUnion<CqlInterval<CqlDate>>(R, (h_ as IEnumerable<CqlInterval<CqlDate>>));

			return i_;
		};
		var c_ = context.Operators.AggregateOrNull<CqlInterval<CqlDate>, IEnumerable<CqlInterval<CqlDate>>>(intervals, (a_ as IEnumerable<CqlInterval<CqlDate>>), b_);

		return c_;
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
				CqlInterval<CqlDate> d_ = null;

				return (d_ as CqlInterval<CqlDate>);
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
		CqlInterval<CqlDate> c_(object M)
		{
			var m_ = this.MedicationRequestPeriod((M as MedicationRequest));

			return m_;
		};
		var d_ = context.Operators.SelectOrNull<object, CqlInterval<CqlDate>>(b_, c_);
		bool? e_(object M)
		{
			var n_ = M is MedicationDispense;

			return (n_ as bool?);
		};
		var f_ = context.Operators.WhereOrNull<object>(Medications, e_);
		CqlInterval<CqlDate> g_(object M)
		{
			var o_ = this.MedicationDispensePeriod((M as MedicationDispense));

			return o_;
		};
		var h_ = context.Operators.SelectOrNull<object, CqlInterval<CqlDate>>(f_, g_);
		var i_ = this.RolloutIntervals(h_);
		var j_ = context.Operators.ListUnion<CqlInterval<CqlDate>>(d_, i_);
		var k_ = this.CumulativeDuration(j_);

		return k_;
	}

}
