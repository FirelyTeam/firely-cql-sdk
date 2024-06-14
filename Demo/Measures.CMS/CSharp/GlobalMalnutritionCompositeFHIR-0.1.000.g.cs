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
[CqlLibrary("GlobalMalnutritionCompositeFHIR", "0.1.000")]
public class GlobalMalnutritionCompositeFHIR_0_1_000
{


    internal CqlContext context;

    #region Cached values

    internal Lazy<CqlValueSet> __Encounter_Inpatient;
    internal Lazy<CqlValueSet> __Ethnicity;
    internal Lazy<CqlValueSet> __Hospital_Dietitian_Referral;
    internal Lazy<CqlValueSet> __Malnutrition_Diagnosis;
    internal Lazy<CqlValueSet> __Malnutrition_Risk_Screening;
    internal Lazy<CqlValueSet> __Malnutrition_Screening_At_Risk_Result;
    internal Lazy<CqlValueSet> __Malnutrition_Screening_Not_At_Risk_Result;
    internal Lazy<CqlValueSet> __Nutrition_Assessment;
    internal Lazy<CqlValueSet> __Nutrition_Assessment_Status_Moderately_Malnourished;
    internal Lazy<CqlValueSet> __Nutrition_Assessment_Status_Not_or_Mildly_Malnourished;
    internal Lazy<CqlValueSet> __Nutrition_Assessment_Status_Severely_Malnourished;
    internal Lazy<CqlValueSet> __Nutrition_Care_Plan;
    internal Lazy<CqlValueSet> __ONC_Administrative_Sex;
    internal Lazy<CqlValueSet> __Payer_Type;
    internal Lazy<CqlValueSet> __Race;
    internal Lazy<CqlCode> __Birth_date;
    internal Lazy<CqlCode[]> __LOINC;
    internal Lazy<CqlCode[]> __SNOMEDCT;
    internal Lazy<CqlCode[]> __ICD10CM;
    internal Lazy<CqlInterval<CqlDateTime>> __Measurement_Period;
    internal Lazy<Patient> __Patient;
    internal Lazy<Tuple_HPcCiDPXQfZTXIORThMLfTQDR> __SDE_Ethnicity;
    internal Lazy<IEnumerable<Tuple_GPRWMPNAYaJRiGDFSTLJOPeIJ>> __SDE_Payer_Type;
    internal Lazy<Tuple_HPcCiDPXQfZTXIORThMLfTQDR> __SDE_Race;
    internal Lazy<CqlCode> __SDE_Sex;
    internal Lazy<IEnumerable<Encounter>> __Qualifying_Encounter;
    internal Lazy<IEnumerable<Encounter>> __Initial_Population;
    internal Lazy<IEnumerable<Encounter>> __Measure_Population;
    internal Lazy<IEnumerable<Encounter>> __Encounter_with_Hospital_Dietitian_Referral;
    internal Lazy<IEnumerable<Encounter>> __Encounter_with_Malnutrition_Risk_Screening;
    internal Lazy<IEnumerable<Encounter>> __Encounter_with_Malnutrition_Risk_Screening_or_with_Hospital_Dietitian_Referral;
    internal Lazy<IEnumerable<Encounter>> __Encounter_with_Malnutrition_Risk_Screening_Not_at_Risk;
    internal Lazy<IEnumerable<Encounter>> __Encounter_with_Malnutrition_Not_at_Risk_Screening_and_without_Hospital_Dietitian_Referral;
    internal Lazy<IEnumerable<Encounter>> __Encounter_with_Malnutrition_Risk_Screening_at_Risk;
    internal Lazy<IEnumerable<Encounter>> __Encounter_with_Malnutrition_Risk_Screening_at_Risk_or_with_Hospital_Dietitian_Referral;
    internal Lazy<IEnumerable<Encounter>> __Encounter_with_Nutrition_Assessment_and_Identified_Status;
    internal Lazy<IEnumerable<Encounter>> __Encounter_with_Nutrition_Assessment_Status_Moderately_Or_Severely_Malnourished;
    internal Lazy<IEnumerable<Encounter>> __Encounter_with_Nutrition_Assessment_Not_or_Mildly_Malnourished;
    internal Lazy<IEnumerable<Encounter>> __Encounter_with_Malnutrition_Diagnosis;
    internal Lazy<IEnumerable<Encounter>> __Encounter_with_Nutrition_Care_Plan;

    #endregion
    public GlobalMalnutritionCompositeFHIR_0_1_000(CqlContext context)
    {
        this.context = context ?? throw new ArgumentNullException("context");

        FHIRHelpers_4_3_000 = new FHIRHelpers_4_3_000(context);
        SupplementalDataElements_3_4_000 = new SupplementalDataElements_3_4_000(context);
        QICoreCommon_2_0_000 = new QICoreCommon_2_0_000(context);
        CQMCommon_2_0_000 = new CQMCommon_2_0_000(context);

        __Encounter_Inpatient = new Lazy<CqlValueSet>(this.Encounter_Inpatient_Value);
        __Ethnicity = new Lazy<CqlValueSet>(this.Ethnicity_Value);
        __Hospital_Dietitian_Referral = new Lazy<CqlValueSet>(this.Hospital_Dietitian_Referral_Value);
        __Malnutrition_Diagnosis = new Lazy<CqlValueSet>(this.Malnutrition_Diagnosis_Value);
        __Malnutrition_Risk_Screening = new Lazy<CqlValueSet>(this.Malnutrition_Risk_Screening_Value);
        __Malnutrition_Screening_At_Risk_Result = new Lazy<CqlValueSet>(this.Malnutrition_Screening_At_Risk_Result_Value);
        __Malnutrition_Screening_Not_At_Risk_Result = new Lazy<CqlValueSet>(this.Malnutrition_Screening_Not_At_Risk_Result_Value);
        __Nutrition_Assessment = new Lazy<CqlValueSet>(this.Nutrition_Assessment_Value);
        __Nutrition_Assessment_Status_Moderately_Malnourished = new Lazy<CqlValueSet>(this.Nutrition_Assessment_Status_Moderately_Malnourished_Value);
        __Nutrition_Assessment_Status_Not_or_Mildly_Malnourished = new Lazy<CqlValueSet>(this.Nutrition_Assessment_Status_Not_or_Mildly_Malnourished_Value);
        __Nutrition_Assessment_Status_Severely_Malnourished = new Lazy<CqlValueSet>(this.Nutrition_Assessment_Status_Severely_Malnourished_Value);
        __Nutrition_Care_Plan = new Lazy<CqlValueSet>(this.Nutrition_Care_Plan_Value);
        __ONC_Administrative_Sex = new Lazy<CqlValueSet>(this.ONC_Administrative_Sex_Value);
        __Payer_Type = new Lazy<CqlValueSet>(this.Payer_Type_Value);
        __Race = new Lazy<CqlValueSet>(this.Race_Value);
        __Birth_date = new Lazy<CqlCode>(this.Birth_date_Value);
        __LOINC = new Lazy<CqlCode[]>(this.LOINC_Value);
        __SNOMEDCT = new Lazy<CqlCode[]>(this.SNOMEDCT_Value);
        __ICD10CM = new Lazy<CqlCode[]>(this.ICD10CM_Value);
        __Measurement_Period = new Lazy<CqlInterval<CqlDateTime>>(this.Measurement_Period_Value);
        __Patient = new Lazy<Patient>(this.Patient_Value);
        __SDE_Ethnicity = new Lazy<Tuple_HPcCiDPXQfZTXIORThMLfTQDR>(this.SDE_Ethnicity_Value);
        __SDE_Payer_Type = new Lazy<IEnumerable<Tuple_GPRWMPNAYaJRiGDFSTLJOPeIJ>>(this.SDE_Payer_Type_Value);
        __SDE_Race = new Lazy<Tuple_HPcCiDPXQfZTXIORThMLfTQDR>(this.SDE_Race_Value);
        __SDE_Sex = new Lazy<CqlCode>(this.SDE_Sex_Value);
        __Qualifying_Encounter = new Lazy<IEnumerable<Encounter>>(this.Qualifying_Encounter_Value);
        __Initial_Population = new Lazy<IEnumerable<Encounter>>(this.Initial_Population_Value);
        __Measure_Population = new Lazy<IEnumerable<Encounter>>(this.Measure_Population_Value);
        __Encounter_with_Hospital_Dietitian_Referral = new Lazy<IEnumerable<Encounter>>(this.Encounter_with_Hospital_Dietitian_Referral_Value);
        __Encounter_with_Malnutrition_Risk_Screening = new Lazy<IEnumerable<Encounter>>(this.Encounter_with_Malnutrition_Risk_Screening_Value);
        __Encounter_with_Malnutrition_Risk_Screening_or_with_Hospital_Dietitian_Referral = new Lazy<IEnumerable<Encounter>>(this.Encounter_with_Malnutrition_Risk_Screening_or_with_Hospital_Dietitian_Referral_Value);
        __Encounter_with_Malnutrition_Risk_Screening_Not_at_Risk = new Lazy<IEnumerable<Encounter>>(this.Encounter_with_Malnutrition_Risk_Screening_Not_at_Risk_Value);
        __Encounter_with_Malnutrition_Not_at_Risk_Screening_and_without_Hospital_Dietitian_Referral = new Lazy<IEnumerable<Encounter>>(this.Encounter_with_Malnutrition_Not_at_Risk_Screening_and_without_Hospital_Dietitian_Referral_Value);
        __Encounter_with_Malnutrition_Risk_Screening_at_Risk = new Lazy<IEnumerable<Encounter>>(this.Encounter_with_Malnutrition_Risk_Screening_at_Risk_Value);
        __Encounter_with_Malnutrition_Risk_Screening_at_Risk_or_with_Hospital_Dietitian_Referral = new Lazy<IEnumerable<Encounter>>(this.Encounter_with_Malnutrition_Risk_Screening_at_Risk_or_with_Hospital_Dietitian_Referral_Value);
        __Encounter_with_Nutrition_Assessment_and_Identified_Status = new Lazy<IEnumerable<Encounter>>(this.Encounter_with_Nutrition_Assessment_and_Identified_Status_Value);
        __Encounter_with_Nutrition_Assessment_Status_Moderately_Or_Severely_Malnourished = new Lazy<IEnumerable<Encounter>>(this.Encounter_with_Nutrition_Assessment_Status_Moderately_Or_Severely_Malnourished_Value);
        __Encounter_with_Nutrition_Assessment_Not_or_Mildly_Malnourished = new Lazy<IEnumerable<Encounter>>(this.Encounter_with_Nutrition_Assessment_Not_or_Mildly_Malnourished_Value);
        __Encounter_with_Malnutrition_Diagnosis = new Lazy<IEnumerable<Encounter>>(this.Encounter_with_Malnutrition_Diagnosis_Value);
        __Encounter_with_Nutrition_Care_Plan = new Lazy<IEnumerable<Encounter>>(this.Encounter_with_Nutrition_Care_Plan_Value);
    }
    #region Dependencies

    public FHIRHelpers_4_3_000 FHIRHelpers_4_3_000 { get; }
    public SupplementalDataElements_3_4_000 SupplementalDataElements_3_4_000 { get; }
    public QICoreCommon_2_0_000 QICoreCommon_2_0_000 { get; }
    public CQMCommon_2_0_000 CQMCommon_2_0_000 { get; }

    #endregion

	private CqlValueSet Encounter_Inpatient_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.666.5.307", null);

    [CqlDeclaration("Encounter Inpatient")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.666.5.307")]
	public CqlValueSet Encounter_Inpatient() => 
		__Encounter_Inpatient.Value;

	private CqlValueSet Ethnicity_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.114222.4.11.837", null);

    [CqlDeclaration("Ethnicity")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.114222.4.11.837")]
	public CqlValueSet Ethnicity() => 
		__Ethnicity.Value;

	private CqlValueSet Hospital_Dietitian_Referral_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1095.91", null);

    [CqlDeclaration("Hospital Dietitian Referral")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1095.91")]
	public CqlValueSet Hospital_Dietitian_Referral() => 
		__Hospital_Dietitian_Referral.Value;

	private CqlValueSet Malnutrition_Diagnosis_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1095.55", null);

    [CqlDeclaration("Malnutrition Diagnosis")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1095.55")]
	public CqlValueSet Malnutrition_Diagnosis() => 
		__Malnutrition_Diagnosis.Value;

	private CqlValueSet Malnutrition_Risk_Screening_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1095.92", null);

    [CqlDeclaration("Malnutrition Risk Screening")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1095.92")]
	public CqlValueSet Malnutrition_Risk_Screening() => 
		__Malnutrition_Risk_Screening.Value;

	private CqlValueSet Malnutrition_Screening_At_Risk_Result_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1095.38", null);

    [CqlDeclaration("Malnutrition Screening At Risk Result")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1095.38")]
	public CqlValueSet Malnutrition_Screening_At_Risk_Result() => 
		__Malnutrition_Screening_At_Risk_Result.Value;

	private CqlValueSet Malnutrition_Screening_Not_At_Risk_Result_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1095.34", null);

    [CqlDeclaration("Malnutrition Screening Not At Risk Result")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1095.34")]
	public CqlValueSet Malnutrition_Screening_Not_At_Risk_Result() => 
		__Malnutrition_Screening_Not_At_Risk_Result.Value;

	private CqlValueSet Nutrition_Assessment_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1095.21", null);

    [CqlDeclaration("Nutrition Assessment")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1095.21")]
	public CqlValueSet Nutrition_Assessment() => 
		__Nutrition_Assessment.Value;

	private CqlValueSet Nutrition_Assessment_Status_Moderately_Malnourished_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1095.44", null);

    [CqlDeclaration("Nutrition Assessment Status Moderately Malnourished")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1095.44")]
	public CqlValueSet Nutrition_Assessment_Status_Moderately_Malnourished() => 
		__Nutrition_Assessment_Status_Moderately_Malnourished.Value;

	private CqlValueSet Nutrition_Assessment_Status_Not_or_Mildly_Malnourished_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1095.48", null);

    [CqlDeclaration("Nutrition Assessment Status Not or Mildly Malnourished")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1095.48")]
	public CqlValueSet Nutrition_Assessment_Status_Not_or_Mildly_Malnourished() => 
		__Nutrition_Assessment_Status_Not_or_Mildly_Malnourished.Value;

	private CqlValueSet Nutrition_Assessment_Status_Severely_Malnourished_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1095.42", null);

    [CqlDeclaration("Nutrition Assessment Status Severely Malnourished")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1095.42")]
	public CqlValueSet Nutrition_Assessment_Status_Severely_Malnourished() => 
		__Nutrition_Assessment_Status_Severely_Malnourished.Value;

	private CqlValueSet Nutrition_Care_Plan_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1095.93", null);

    [CqlDeclaration("Nutrition Care Plan")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1095.93")]
	public CqlValueSet Nutrition_Care_Plan() => 
		__Nutrition_Care_Plan.Value;

	private CqlValueSet ONC_Administrative_Sex_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1", null);

    [CqlDeclaration("ONC Administrative Sex")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1")]
	public CqlValueSet ONC_Administrative_Sex() => 
		__ONC_Administrative_Sex.Value;

	private CqlValueSet Payer_Type_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.114222.4.11.3591", null);

    [CqlDeclaration("Payer Type")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.114222.4.11.3591")]
	public CqlValueSet Payer_Type() => 
		__Payer_Type.Value;

	private CqlValueSet Race_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.114222.4.11.836", null);

    [CqlDeclaration("Race")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.114222.4.11.836")]
	public CqlValueSet Race() => 
		__Race.Value;

	private CqlCode Birth_date_Value() => 
		new CqlCode("21112-8", "http://loinc.org", null, null);

    [CqlDeclaration("Birth date")]
	public CqlCode Birth_date() => 
		__Birth_date.Value;

	private CqlCode[] LOINC_Value()
	{
		var a_ = new CqlCode[]
		{
			new CqlCode("21112-8", "http://loinc.org", null, null),
		};

		return a_;
	}

    [CqlDeclaration("LOINC")]
	public CqlCode[] LOINC() => 
		__LOINC.Value;

	private CqlCode[] SNOMEDCT_Value()
	{
		var a_ = new CqlCode[0]
;

		return a_;
	}

    [CqlDeclaration("SNOMEDCT")]
	public CqlCode[] SNOMEDCT() => 
		__SNOMEDCT.Value;

	private CqlCode[] ICD10CM_Value()
	{
		var a_ = new CqlCode[0]
;

		return a_;
	}

    [CqlDeclaration("ICD10CM")]
	public CqlCode[] ICD10CM() => 
		__ICD10CM.Value;

	private CqlInterval<CqlDateTime> Measurement_Period_Value()
	{
		var a_ = context.Operators.DateTime(2025, 1, 1, 0, 0, 0, 0, default);
		var b_ = context.Operators.DateTime(2026, 1, 1, 0, 0, 0, 0, default);
		var c_ = context.Operators.Interval(a_, b_, true, false);
		var d_ = context.ResolveParameter("GlobalMalnutritionCompositeFHIR-0.1.000", "Measurement Period", c_);

		return (CqlInterval<CqlDateTime>)d_;
	}

    [CqlDeclaration("Measurement Period")]
	public CqlInterval<CqlDateTime> Measurement_Period() => 
		__Measurement_Period.Value;

	private Patient Patient_Value()
	{
		var a_ = context.Operators.RetrieveByValueSet<Patient>(null, null);
		var b_ = context.Operators.SingletonFrom<Patient>(a_);

		return b_;
	}

    [CqlDeclaration("Patient")]
	public Patient Patient() => 
		__Patient.Value;

	private Tuple_HPcCiDPXQfZTXIORThMLfTQDR SDE_Ethnicity_Value()
	{
		var a_ = SupplementalDataElements_3_4_000.SDE_Ethnicity();

		return a_;
	}

    [CqlDeclaration("SDE Ethnicity")]
	public Tuple_HPcCiDPXQfZTXIORThMLfTQDR SDE_Ethnicity() => 
		__SDE_Ethnicity.Value;

	private IEnumerable<Tuple_GPRWMPNAYaJRiGDFSTLJOPeIJ> SDE_Payer_Type_Value()
	{
		var a_ = SupplementalDataElements_3_4_000.SDE_Payer();

		return a_;
	}

    [CqlDeclaration("SDE Payer Type")]
	public IEnumerable<Tuple_GPRWMPNAYaJRiGDFSTLJOPeIJ> SDE_Payer_Type() => 
		__SDE_Payer_Type.Value;

	private Tuple_HPcCiDPXQfZTXIORThMLfTQDR SDE_Race_Value()
	{
		var a_ = SupplementalDataElements_3_4_000.SDE_Race();

		return a_;
	}

    [CqlDeclaration("SDE Race")]
	public Tuple_HPcCiDPXQfZTXIORThMLfTQDR SDE_Race() => 
		__SDE_Race.Value;

	private CqlCode SDE_Sex_Value()
	{
		var a_ = SupplementalDataElements_3_4_000.SDE_Sex();

		return a_;
	}

    [CqlDeclaration("SDE Sex")]
	public CqlCode SDE_Sex() => 
		__SDE_Sex.Value;

	private IEnumerable<Encounter> Qualifying_Encounter_Value()
	{
		var a_ = this.Encounter_Inpatient();
		var b_ = context.Operators.RetrieveByValueSet<Encounter>(a_, null);
		bool? c_(Encounter EncounterInpatient)
		{
			var e_ = EncounterInpatient?.Period;
			var f_ = FHIRHelpers_4_3_000.ToInterval(e_);
			var g_ = context.Operators.End(f_);
			var h_ = this.Measurement_Period();
			var i_ = context.Operators.In<CqlDateTime>(g_, h_, "day");
			var j_ = this.Patient();
			var k_ = j_?.BirthDateElement;
			var l_ = k_?.Value;
			var m_ = context.Operators.Convert<CqlDate>(l_);
			var o_ = FHIRHelpers_4_3_000.ToInterval(e_);
			var p_ = context.Operators.Start(o_);
			var q_ = context.Operators.DateFrom(p_);
			var r_ = context.Operators.CalculateAgeAt(m_, q_, "year");
			var s_ = context.Operators.GreaterOrEqual(r_, 65);
			var t_ = context.Operators.And(i_, s_);
			var v_ = FHIRHelpers_4_3_000.ToInterval(e_);
			var w_ = context.Operators.Start(v_);
			var y_ = FHIRHelpers_4_3_000.ToInterval(e_);
			var z_ = context.Operators.End(y_);
			var aa_ = context.Operators.DurationBetween(w_, z_, "hour");
			var ab_ = context.Operators.GreaterOrEqual(aa_, 24);
			var ac_ = context.Operators.And(t_, ab_);
			var ad_ = EncounterInpatient?.StatusElement;
			var ae_ = ad_?.Value;
			var af_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(ae_);
			var ag_ = context.Operators.Equal(af_, "finished");
			var ah_ = context.Operators.And(ac_, ag_);

			return ah_;
		};
		var d_ = context.Operators.Where<Encounter>(b_, c_);

		return d_;
	}

    [CqlDeclaration("Qualifying Encounter")]
	public IEnumerable<Encounter> Qualifying_Encounter() => 
		__Qualifying_Encounter.Value;

	private IEnumerable<Encounter> Initial_Population_Value()
	{
		var a_ = this.Qualifying_Encounter();

		return a_;
	}

    [CqlDeclaration("Initial Population")]
	public IEnumerable<Encounter> Initial_Population() => 
		__Initial_Population.Value;

	private IEnumerable<Encounter> Measure_Population_Value()
	{
		var a_ = this.Initial_Population();

		return a_;
	}

    [CqlDeclaration("Measure Population")]
	public IEnumerable<Encounter> Measure_Population() => 
		__Measure_Population.Value;

	private IEnumerable<Encounter> Encounter_with_Hospital_Dietitian_Referral_Value()
	{
		var a_ = this.Qualifying_Encounter();
		var b_ = this.Hospital_Dietitian_Referral();
		var c_ = context.Operators.RetrieveByValueSet<Procedure>(b_, null);
		var d_ = context.Operators.CrossJoin<Encounter, Procedure>(a_, c_);
		Tuple_BLOdcPfeecJFNOdFOfHFZLQfa e_(ValueTuple<Encounter, Procedure> _valueTuple)
		{
			var k_ = new Tuple_BLOdcPfeecJFNOdFOfHFZLQfa
			{
				QualifyingEncounter = _valueTuple.Item1,
				HospitalDietitianReferral = _valueTuple.Item2,
			};

			return k_;
		};
		var f_ = context.Operators.Select<ValueTuple<Encounter, Procedure>, Tuple_BLOdcPfeecJFNOdFOfHFZLQfa>(d_, e_);
		bool? g_(Tuple_BLOdcPfeecJFNOdFOfHFZLQfa tuple_blodcpfeecjfnodfofhfzlqfa)
		{
			var l_ = tuple_blodcpfeecjfnodfofhfzlqfa.HospitalDietitianReferral?.Code;
			var m_ = FHIRHelpers_4_3_000.ToConcept(l_);
			var n_ = this.Hospital_Dietitian_Referral();
			var o_ = context.Operators.ConceptInValueSet(m_, n_);
			var p_ = tuple_blodcpfeecjfnodfofhfzlqfa.HospitalDietitianReferral?.StatusElement;
			var q_ = p_?.Value;
			var r_ = context.Operators.Convert<string>(q_);
			var s_ = new string[]
			{
				"active",
				"completed",
				"in-progress",
			};
			var t_ = context.Operators.In<string>(r_, (s_ as IEnumerable<string>));
			var u_ = context.Operators.And(o_, t_);
			var v_ = tuple_blodcpfeecjfnodfofhfzlqfa.HospitalDietitianReferral?.Performed;
			var w_ = FHIRHelpers_4_3_000.ToValue(v_);
			var x_ = QICoreCommon_2_0_000.earliest(w_);
			var y_ = CQMCommon_2_0_000.hospitalizationWithObservation(tuple_blodcpfeecjfnodfofhfzlqfa.QualifyingEncounter);
			var z_ = context.Operators.In<CqlDateTime>(x_, y_, null);
			var aa_ = context.Operators.And(u_, z_);

			return aa_;
		};
		var h_ = context.Operators.Where<Tuple_BLOdcPfeecJFNOdFOfHFZLQfa>(f_, g_);
		Encounter i_(Tuple_BLOdcPfeecJFNOdFOfHFZLQfa tuple_blodcpfeecjfnodfofhfzlqfa) => 
			tuple_blodcpfeecjfnodfofhfzlqfa.QualifyingEncounter;
		var j_ = context.Operators.Select<Tuple_BLOdcPfeecJFNOdFOfHFZLQfa, Encounter>(h_, i_);

		return j_;
	}

    [CqlDeclaration("Encounter with Hospital Dietitian Referral")]
	public IEnumerable<Encounter> Encounter_with_Hospital_Dietitian_Referral() => 
		__Encounter_with_Hospital_Dietitian_Referral.Value;

	private IEnumerable<Encounter> Encounter_with_Malnutrition_Risk_Screening_Value()
	{
		var a_ = this.Qualifying_Encounter();
		var b_ = this.Malnutrition_Risk_Screening();
		var c_ = context.Operators.RetrieveByValueSet<Observation>(b_, null);
		var d_ = context.Operators.CrossJoin<Encounter, Observation>(a_, c_);
		Tuple_BEjjTWeGPXJSNajSOdYBEfDdb e_(ValueTuple<Encounter, Observation> _valueTuple)
		{
			var k_ = new Tuple_BEjjTWeGPXJSNajSOdYBEfDdb
			{
				QualifyingEncounter = _valueTuple.Item1,
				MalnutritionRiskScreening = _valueTuple.Item2,
			};

			return k_;
		};
		var f_ = context.Operators.Select<ValueTuple<Encounter, Observation>, Tuple_BEjjTWeGPXJSNajSOdYBEfDdb>(d_, e_);
		bool? g_(Tuple_BEjjTWeGPXJSNajSOdYBEfDdb tuple_bejjtwegpxjsnajsodybefddb)
		{
			var l_ = tuple_bejjtwegpxjsnajsodybefddb.MalnutritionRiskScreening?.Code;
			var m_ = FHIRHelpers_4_3_000.ToConcept(l_);
			var n_ = this.Malnutrition_Risk_Screening();
			var o_ = context.Operators.ConceptInValueSet(m_, n_);
			var p_ = tuple_bejjtwegpxjsnajsodybefddb.MalnutritionRiskScreening?.StatusElement;
			var q_ = p_?.Value;
			var r_ = context.Operators.Convert<Code<ObservationStatus>>(q_);
			var s_ = context.Operators.Convert<string>(r_);
			var t_ = new string[]
			{
				"final",
				"amended",
				"corrected",
			};
			var u_ = context.Operators.In<string>(s_, (t_ as IEnumerable<string>));
			var v_ = context.Operators.And(o_, u_);
			var w_ = CQMCommon_2_0_000.hospitalizationWithObservation(tuple_bejjtwegpxjsnajsodybefddb.QualifyingEncounter);
			var x_ = tuple_bejjtwegpxjsnajsodybefddb.MalnutritionRiskScreening?.Effective;
			var y_ = FHIRHelpers_4_3_000.ToValue(x_);
			var z_ = QICoreCommon_2_0_000.toInterval(y_);
			var aa_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(w_, z_, null);
			var ab_ = context.Operators.And(v_, aa_);
			var ac_ = tuple_bejjtwegpxjsnajsodybefddb.MalnutritionRiskScreening?.Value;
			var ad_ = FHIRHelpers_4_3_000.ToValue(ac_);
			var ae_ = this.Malnutrition_Screening_Not_At_Risk_Result();
			var af_ = context.Operators.ConceptInValueSet((ad_ as CqlConcept), ae_);
			var ah_ = FHIRHelpers_4_3_000.ToValue(ac_);
			var ai_ = this.Malnutrition_Screening_At_Risk_Result();
			var aj_ = context.Operators.ConceptInValueSet((ah_ as CqlConcept), ai_);
			var ak_ = context.Operators.Or(af_, aj_);
			var al_ = context.Operators.And(ab_, ak_);

			return al_;
		};
		var h_ = context.Operators.Where<Tuple_BEjjTWeGPXJSNajSOdYBEfDdb>(f_, g_);
		Encounter i_(Tuple_BEjjTWeGPXJSNajSOdYBEfDdb tuple_bejjtwegpxjsnajsodybefddb) => 
			tuple_bejjtwegpxjsnajsodybefddb.QualifyingEncounter;
		var j_ = context.Operators.Select<Tuple_BEjjTWeGPXJSNajSOdYBEfDdb, Encounter>(h_, i_);

		return j_;
	}

    [CqlDeclaration("Encounter with Malnutrition Risk Screening")]
	public IEnumerable<Encounter> Encounter_with_Malnutrition_Risk_Screening() => 
		__Encounter_with_Malnutrition_Risk_Screening.Value;

	private IEnumerable<Encounter> Encounter_with_Malnutrition_Risk_Screening_or_with_Hospital_Dietitian_Referral_Value()
	{
		var a_ = this.Qualifying_Encounter();
		bool? b_(Encounter QualifyingEncounter)
		{
			var f_ = this.Encounter_with_Malnutrition_Risk_Screening();
			var g_ = context.Operators.Contains<Encounter>(f_, QualifyingEncounter);
			var h_ = this.Encounter_with_Hospital_Dietitian_Referral();
			var i_ = context.Operators.Contains<Encounter>(h_, QualifyingEncounter);
			var j_ = context.Operators.Or(g_, i_);

			return j_;
		};
		var c_ = context.Operators.Where<Encounter>(a_, b_);
		Encounter d_(Encounter QualifyingEncounter) => 
			QualifyingEncounter;
		var e_ = context.Operators.Select<Encounter, Encounter>(c_, d_);

		return e_;
	}

    [CqlDeclaration("Encounter with Malnutrition Risk Screening or with Hospital Dietitian Referral")]
	public IEnumerable<Encounter> Encounter_with_Malnutrition_Risk_Screening_or_with_Hospital_Dietitian_Referral() => 
		__Encounter_with_Malnutrition_Risk_Screening_or_with_Hospital_Dietitian_Referral.Value;

	private IEnumerable<Encounter> Encounter_with_Malnutrition_Risk_Screening_Not_at_Risk_Value()
	{
		var a_ = this.Qualifying_Encounter();
		var b_ = this.Malnutrition_Risk_Screening();
		var c_ = context.Operators.RetrieveByValueSet<Observation>(b_, null);
		var d_ = context.Operators.CrossJoin<Encounter, Observation>(a_, c_);
		Tuple_BEjjTWeGPXJSNajSOdYBEfDdb e_(ValueTuple<Encounter, Observation> _valueTuple)
		{
			var k_ = new Tuple_BEjjTWeGPXJSNajSOdYBEfDdb
			{
				QualifyingEncounter = _valueTuple.Item1,
				MalnutritionRiskScreening = _valueTuple.Item2,
			};

			return k_;
		};
		var f_ = context.Operators.Select<ValueTuple<Encounter, Observation>, Tuple_BEjjTWeGPXJSNajSOdYBEfDdb>(d_, e_);
		bool? g_(Tuple_BEjjTWeGPXJSNajSOdYBEfDdb tuple_bejjtwegpxjsnajsodybefddb)
		{
			var l_ = tuple_bejjtwegpxjsnajsodybefddb.MalnutritionRiskScreening?.Code;
			var m_ = FHIRHelpers_4_3_000.ToConcept(l_);
			var n_ = this.Malnutrition_Risk_Screening();
			var o_ = context.Operators.ConceptInValueSet(m_, n_);
			var p_ = tuple_bejjtwegpxjsnajsodybefddb.MalnutritionRiskScreening?.StatusElement;
			var q_ = p_?.Value;
			var r_ = context.Operators.Convert<Code<ObservationStatus>>(q_);
			var s_ = context.Operators.Convert<string>(r_);
			var t_ = new string[]
			{
				"final",
				"amended",
				"corrected",
			};
			var u_ = context.Operators.In<string>(s_, (t_ as IEnumerable<string>));
			var v_ = context.Operators.And(o_, u_);
			var w_ = CQMCommon_2_0_000.hospitalizationWithObservation(tuple_bejjtwegpxjsnajsodybefddb.QualifyingEncounter);
			var x_ = tuple_bejjtwegpxjsnajsodybefddb.MalnutritionRiskScreening?.Effective;
			var y_ = FHIRHelpers_4_3_000.ToValue(x_);
			var z_ = QICoreCommon_2_0_000.toInterval(y_);
			var aa_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(w_, z_, null);
			var ab_ = context.Operators.And(v_, aa_);
			var ac_ = tuple_bejjtwegpxjsnajsodybefddb.MalnutritionRiskScreening?.Value;
			var ad_ = FHIRHelpers_4_3_000.ToValue(ac_);
			var ae_ = this.Malnutrition_Screening_Not_At_Risk_Result();
			var af_ = context.Operators.ConceptInValueSet((ad_ as CqlConcept), ae_);
			var ag_ = context.Operators.And(ab_, af_);

			return ag_;
		};
		var h_ = context.Operators.Where<Tuple_BEjjTWeGPXJSNajSOdYBEfDdb>(f_, g_);
		Encounter i_(Tuple_BEjjTWeGPXJSNajSOdYBEfDdb tuple_bejjtwegpxjsnajsodybefddb) => 
			tuple_bejjtwegpxjsnajsodybefddb.QualifyingEncounter;
		var j_ = context.Operators.Select<Tuple_BEjjTWeGPXJSNajSOdYBEfDdb, Encounter>(h_, i_);

		return j_;
	}

    [CqlDeclaration("Encounter with Malnutrition Risk Screening Not at Risk")]
	public IEnumerable<Encounter> Encounter_with_Malnutrition_Risk_Screening_Not_at_Risk() => 
		__Encounter_with_Malnutrition_Risk_Screening_Not_at_Risk.Value;

	private IEnumerable<Encounter> Encounter_with_Malnutrition_Not_at_Risk_Screening_and_without_Hospital_Dietitian_Referral_Value()
	{
		var a_ = this.Qualifying_Encounter();
		bool? b_(Encounter QualifyingEncounter)
		{
			var f_ = this.Encounter_with_Malnutrition_Risk_Screening_Not_at_Risk();
			var g_ = context.Operators.Contains<Encounter>(f_, QualifyingEncounter);
			var h_ = this.Encounter_with_Hospital_Dietitian_Referral();
			var i_ = context.Operators.Exists<Encounter>(h_);
			var j_ = context.Operators.Not(i_);
			var k_ = context.Operators.And(g_, j_);

			return k_;
		};
		var c_ = context.Operators.Where<Encounter>(a_, b_);
		Encounter d_(Encounter QualifyingEncounter) => 
			QualifyingEncounter;
		var e_ = context.Operators.Select<Encounter, Encounter>(c_, d_);

		return e_;
	}

    [CqlDeclaration("Encounter with Malnutrition Not at Risk Screening and without Hospital Dietitian Referral")]
	public IEnumerable<Encounter> Encounter_with_Malnutrition_Not_at_Risk_Screening_and_without_Hospital_Dietitian_Referral() => 
		__Encounter_with_Malnutrition_Not_at_Risk_Screening_and_without_Hospital_Dietitian_Referral.Value;

	private IEnumerable<Encounter> Encounter_with_Malnutrition_Risk_Screening_at_Risk_Value()
	{
		var a_ = this.Qualifying_Encounter();
		var b_ = this.Malnutrition_Risk_Screening();
		var c_ = context.Operators.RetrieveByValueSet<Observation>(b_, null);
		var d_ = context.Operators.CrossJoin<Encounter, Observation>(a_, c_);
		Tuple_BEjjTWeGPXJSNajSOdYBEfDdb e_(ValueTuple<Encounter, Observation> _valueTuple)
		{
			var k_ = new Tuple_BEjjTWeGPXJSNajSOdYBEfDdb
			{
				QualifyingEncounter = _valueTuple.Item1,
				MalnutritionRiskScreening = _valueTuple.Item2,
			};

			return k_;
		};
		var f_ = context.Operators.Select<ValueTuple<Encounter, Observation>, Tuple_BEjjTWeGPXJSNajSOdYBEfDdb>(d_, e_);
		bool? g_(Tuple_BEjjTWeGPXJSNajSOdYBEfDdb tuple_bejjtwegpxjsnajsodybefddb)
		{
			var l_ = tuple_bejjtwegpxjsnajsodybefddb.MalnutritionRiskScreening?.Code;
			var m_ = FHIRHelpers_4_3_000.ToConcept(l_);
			var n_ = this.Malnutrition_Risk_Screening();
			var o_ = context.Operators.ConceptInValueSet(m_, n_);
			var p_ = tuple_bejjtwegpxjsnajsodybefddb.MalnutritionRiskScreening?.StatusElement;
			var q_ = p_?.Value;
			var r_ = context.Operators.Convert<Code<ObservationStatus>>(q_);
			var s_ = context.Operators.Convert<string>(r_);
			var t_ = new string[]
			{
				"final",
				"amended",
				"corrected",
			};
			var u_ = context.Operators.In<string>(s_, (t_ as IEnumerable<string>));
			var v_ = context.Operators.And(o_, u_);
			var w_ = CQMCommon_2_0_000.hospitalizationWithObservation(tuple_bejjtwegpxjsnajsodybefddb.QualifyingEncounter);
			var x_ = tuple_bejjtwegpxjsnajsodybefddb.MalnutritionRiskScreening?.Effective;
			var y_ = FHIRHelpers_4_3_000.ToValue(x_);
			var z_ = QICoreCommon_2_0_000.toInterval(y_);
			var aa_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(w_, z_, null);
			var ab_ = context.Operators.And(v_, aa_);
			var ac_ = tuple_bejjtwegpxjsnajsodybefddb.MalnutritionRiskScreening?.Value;
			var ad_ = FHIRHelpers_4_3_000.ToValue(ac_);
			var ae_ = this.Malnutrition_Screening_At_Risk_Result();
			var af_ = context.Operators.ConceptInValueSet((ad_ as CqlConcept), ae_);
			var ag_ = context.Operators.And(ab_, af_);

			return ag_;
		};
		var h_ = context.Operators.Where<Tuple_BEjjTWeGPXJSNajSOdYBEfDdb>(f_, g_);
		Encounter i_(Tuple_BEjjTWeGPXJSNajSOdYBEfDdb tuple_bejjtwegpxjsnajsodybefddb) => 
			tuple_bejjtwegpxjsnajsodybefddb.QualifyingEncounter;
		var j_ = context.Operators.Select<Tuple_BEjjTWeGPXJSNajSOdYBEfDdb, Encounter>(h_, i_);

		return j_;
	}

    [CqlDeclaration("Encounter with Malnutrition Risk Screening at Risk")]
	public IEnumerable<Encounter> Encounter_with_Malnutrition_Risk_Screening_at_Risk() => 
		__Encounter_with_Malnutrition_Risk_Screening_at_Risk.Value;

	private IEnumerable<Encounter> Encounter_with_Malnutrition_Risk_Screening_at_Risk_or_with_Hospital_Dietitian_Referral_Value()
	{
		var a_ = this.Qualifying_Encounter();
		bool? b_(Encounter QualifyingEncounter)
		{
			var f_ = this.Encounter_with_Malnutrition_Risk_Screening_at_Risk();
			var g_ = context.Operators.Contains<Encounter>(f_, QualifyingEncounter);
			var h_ = this.Encounter_with_Hospital_Dietitian_Referral();
			var i_ = context.Operators.Contains<Encounter>(h_, QualifyingEncounter);
			var j_ = context.Operators.Or(g_, i_);

			return j_;
		};
		var c_ = context.Operators.Where<Encounter>(a_, b_);
		Encounter d_(Encounter QualifyingEncounter) => 
			QualifyingEncounter;
		var e_ = context.Operators.Select<Encounter, Encounter>(c_, d_);

		return e_;
	}

    [CqlDeclaration("Encounter with Malnutrition Risk Screening at Risk or with Hospital Dietitian Referral")]
	public IEnumerable<Encounter> Encounter_with_Malnutrition_Risk_Screening_at_Risk_or_with_Hospital_Dietitian_Referral() => 
		__Encounter_with_Malnutrition_Risk_Screening_at_Risk_or_with_Hospital_Dietitian_Referral.Value;

	private IEnumerable<Encounter> Encounter_with_Nutrition_Assessment_and_Identified_Status_Value()
	{
		var a_ = this.Qualifying_Encounter();
		var b_ = this.Nutrition_Assessment();
		var c_ = context.Operators.RetrieveByValueSet<Observation>(b_, null);
		var d_ = context.Operators.CrossJoin<Encounter, Observation>(a_, c_);
		Tuple_HHhYPFJVjUjiTMIZOceFUGCNE e_(ValueTuple<Encounter, Observation> _valueTuple)
		{
			var k_ = new Tuple_HHhYPFJVjUjiTMIZOceFUGCNE
			{
				QualifyingEncounter = _valueTuple.Item1,
				NutritionAssessment = _valueTuple.Item2,
			};

			return k_;
		};
		var f_ = context.Operators.Select<ValueTuple<Encounter, Observation>, Tuple_HHhYPFJVjUjiTMIZOceFUGCNE>(d_, e_);
		bool? g_(Tuple_HHhYPFJVjUjiTMIZOceFUGCNE tuple_hhhypfjvjujitmizocefugcne)
		{
			var l_ = tuple_hhhypfjvjujitmizocefugcne.NutritionAssessment?.Code;
			var m_ = FHIRHelpers_4_3_000.ToConcept(l_);
			var n_ = this.Nutrition_Assessment();
			var o_ = context.Operators.ConceptInValueSet(m_, n_);
			var p_ = tuple_hhhypfjvjujitmizocefugcne.NutritionAssessment?.StatusElement;
			var q_ = p_?.Value;
			var r_ = context.Operators.Convert<Code<ObservationStatus>>(q_);
			var s_ = context.Operators.Convert<string>(r_);
			var t_ = new string[]
			{
				"final",
				"amended",
				"corrected",
			};
			var u_ = context.Operators.In<string>(s_, (t_ as IEnumerable<string>));
			var v_ = context.Operators.And(o_, u_);
			var w_ = CQMCommon_2_0_000.hospitalizationWithObservation(tuple_hhhypfjvjujitmizocefugcne.QualifyingEncounter);
			var x_ = tuple_hhhypfjvjujitmizocefugcne.NutritionAssessment?.Effective;
			var y_ = FHIRHelpers_4_3_000.ToValue(x_);
			var z_ = QICoreCommon_2_0_000.toInterval(y_);
			var aa_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(w_, z_, null);
			var ab_ = context.Operators.And(v_, aa_);
			var ac_ = tuple_hhhypfjvjujitmizocefugcne.NutritionAssessment?.Value;
			var ad_ = FHIRHelpers_4_3_000.ToValue(ac_);
			var ae_ = this.Nutrition_Assessment_Status_Moderately_Malnourished();
			var af_ = context.Operators.ConceptInValueSet((ad_ as CqlConcept), ae_);
			var ah_ = FHIRHelpers_4_3_000.ToValue(ac_);
			var ai_ = this.Nutrition_Assessment_Status_Not_or_Mildly_Malnourished();
			var aj_ = context.Operators.ConceptInValueSet((ah_ as CqlConcept), ai_);
			var ak_ = context.Operators.Or(af_, aj_);
			var am_ = FHIRHelpers_4_3_000.ToValue(ac_);
			var an_ = this.Nutrition_Assessment_Status_Severely_Malnourished();
			var ao_ = context.Operators.ConceptInValueSet((am_ as CqlConcept), an_);
			var ap_ = context.Operators.Or(ak_, ao_);
			var aq_ = context.Operators.And(ab_, ap_);

			return aq_;
		};
		var h_ = context.Operators.Where<Tuple_HHhYPFJVjUjiTMIZOceFUGCNE>(f_, g_);
		Encounter i_(Tuple_HHhYPFJVjUjiTMIZOceFUGCNE tuple_hhhypfjvjujitmizocefugcne) => 
			tuple_hhhypfjvjujitmizocefugcne.QualifyingEncounter;
		var j_ = context.Operators.Select<Tuple_HHhYPFJVjUjiTMIZOceFUGCNE, Encounter>(h_, i_);

		return j_;
	}

    [CqlDeclaration("Encounter with Nutrition Assessment and Identified Status")]
	public IEnumerable<Encounter> Encounter_with_Nutrition_Assessment_and_Identified_Status() => 
		__Encounter_with_Nutrition_Assessment_and_Identified_Status.Value;

	private IEnumerable<Encounter> Encounter_with_Nutrition_Assessment_Status_Moderately_Or_Severely_Malnourished_Value()
	{
		var a_ = this.Qualifying_Encounter();
		var b_ = this.Nutrition_Assessment();
		var c_ = context.Operators.RetrieveByValueSet<Observation>(b_, null);
		var d_ = context.Operators.CrossJoin<Encounter, Observation>(a_, c_);
		Tuple_HHhYPFJVjUjiTMIZOceFUGCNE e_(ValueTuple<Encounter, Observation> _valueTuple)
		{
			var k_ = new Tuple_HHhYPFJVjUjiTMIZOceFUGCNE
			{
				QualifyingEncounter = _valueTuple.Item1,
				NutritionAssessment = _valueTuple.Item2,
			};

			return k_;
		};
		var f_ = context.Operators.Select<ValueTuple<Encounter, Observation>, Tuple_HHhYPFJVjUjiTMIZOceFUGCNE>(d_, e_);
		bool? g_(Tuple_HHhYPFJVjUjiTMIZOceFUGCNE tuple_hhhypfjvjujitmizocefugcne)
		{
			var l_ = tuple_hhhypfjvjujitmizocefugcne.NutritionAssessment?.Code;
			var m_ = FHIRHelpers_4_3_000.ToConcept(l_);
			var n_ = this.Nutrition_Assessment();
			var o_ = context.Operators.ConceptInValueSet(m_, n_);
			var p_ = tuple_hhhypfjvjujitmizocefugcne.NutritionAssessment?.StatusElement;
			var q_ = p_?.Value;
			var r_ = context.Operators.Convert<Code<ObservationStatus>>(q_);
			var s_ = context.Operators.Convert<string>(r_);
			var t_ = new string[]
			{
				"final",
				"amended",
				"corrected",
			};
			var u_ = context.Operators.In<string>(s_, (t_ as IEnumerable<string>));
			var v_ = context.Operators.And(o_, u_);
			var w_ = CQMCommon_2_0_000.hospitalizationWithObservation(tuple_hhhypfjvjujitmizocefugcne.QualifyingEncounter);
			var x_ = tuple_hhhypfjvjujitmizocefugcne.NutritionAssessment?.Effective;
			var y_ = FHIRHelpers_4_3_000.ToValue(x_);
			var z_ = QICoreCommon_2_0_000.toInterval(y_);
			var aa_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(w_, z_, null);
			var ab_ = context.Operators.And(v_, aa_);
			var ac_ = tuple_hhhypfjvjujitmizocefugcne.NutritionAssessment?.Value;
			var ad_ = FHIRHelpers_4_3_000.ToValue(ac_);
			var ae_ = this.Nutrition_Assessment_Status_Moderately_Malnourished();
			var af_ = context.Operators.ConceptInValueSet((ad_ as CqlConcept), ae_);
			var ah_ = FHIRHelpers_4_3_000.ToValue(ac_);
			var ai_ = this.Nutrition_Assessment_Status_Severely_Malnourished();
			var aj_ = context.Operators.ConceptInValueSet((ah_ as CqlConcept), ai_);
			var ak_ = context.Operators.Or(af_, aj_);
			var al_ = context.Operators.And(ab_, ak_);

			return al_;
		};
		var h_ = context.Operators.Where<Tuple_HHhYPFJVjUjiTMIZOceFUGCNE>(f_, g_);
		Encounter i_(Tuple_HHhYPFJVjUjiTMIZOceFUGCNE tuple_hhhypfjvjujitmizocefugcne) => 
			tuple_hhhypfjvjujitmizocefugcne.QualifyingEncounter;
		var j_ = context.Operators.Select<Tuple_HHhYPFJVjUjiTMIZOceFUGCNE, Encounter>(h_, i_);

		return j_;
	}

    [CqlDeclaration("Encounter with Nutrition Assessment Status Moderately Or Severely Malnourished")]
	public IEnumerable<Encounter> Encounter_with_Nutrition_Assessment_Status_Moderately_Or_Severely_Malnourished() => 
		__Encounter_with_Nutrition_Assessment_Status_Moderately_Or_Severely_Malnourished.Value;

	private IEnumerable<Encounter> Encounter_with_Nutrition_Assessment_Not_or_Mildly_Malnourished_Value()
	{
		var a_ = this.Qualifying_Encounter();
		var b_ = this.Nutrition_Assessment();
		var c_ = context.Operators.RetrieveByValueSet<Observation>(b_, null);
		var d_ = context.Operators.CrossJoin<Encounter, Observation>(a_, c_);
		Tuple_HHhYPFJVjUjiTMIZOceFUGCNE e_(ValueTuple<Encounter, Observation> _valueTuple)
		{
			var k_ = new Tuple_HHhYPFJVjUjiTMIZOceFUGCNE
			{
				QualifyingEncounter = _valueTuple.Item1,
				NutritionAssessment = _valueTuple.Item2,
			};

			return k_;
		};
		var f_ = context.Operators.Select<ValueTuple<Encounter, Observation>, Tuple_HHhYPFJVjUjiTMIZOceFUGCNE>(d_, e_);
		bool? g_(Tuple_HHhYPFJVjUjiTMIZOceFUGCNE tuple_hhhypfjvjujitmizocefugcne)
		{
			var l_ = tuple_hhhypfjvjujitmizocefugcne.NutritionAssessment?.Code;
			var m_ = FHIRHelpers_4_3_000.ToConcept(l_);
			var n_ = this.Nutrition_Assessment();
			var o_ = context.Operators.ConceptInValueSet(m_, n_);
			var p_ = tuple_hhhypfjvjujitmizocefugcne.NutritionAssessment?.StatusElement;
			var q_ = p_?.Value;
			var r_ = context.Operators.Convert<Code<ObservationStatus>>(q_);
			var s_ = context.Operators.Convert<string>(r_);
			var t_ = new string[]
			{
				"final",
				"amended",
				"corrected",
			};
			var u_ = context.Operators.In<string>(s_, (t_ as IEnumerable<string>));
			var v_ = context.Operators.And(o_, u_);
			var w_ = CQMCommon_2_0_000.hospitalizationWithObservation(tuple_hhhypfjvjujitmizocefugcne.QualifyingEncounter);
			var x_ = tuple_hhhypfjvjujitmizocefugcne.NutritionAssessment?.Effective;
			var y_ = FHIRHelpers_4_3_000.ToValue(x_);
			var z_ = QICoreCommon_2_0_000.toInterval(y_);
			var aa_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(w_, z_, null);
			var ab_ = context.Operators.And(v_, aa_);
			var ac_ = tuple_hhhypfjvjujitmizocefugcne.NutritionAssessment?.Value;
			var ad_ = FHIRHelpers_4_3_000.ToValue(ac_);
			var ae_ = this.Nutrition_Assessment_Status_Not_or_Mildly_Malnourished();
			var af_ = context.Operators.ConceptInValueSet((ad_ as CqlConcept), ae_);
			var ag_ = context.Operators.And(ab_, af_);

			return ag_;
		};
		var h_ = context.Operators.Where<Tuple_HHhYPFJVjUjiTMIZOceFUGCNE>(f_, g_);
		Encounter i_(Tuple_HHhYPFJVjUjiTMIZOceFUGCNE tuple_hhhypfjvjujitmizocefugcne) => 
			tuple_hhhypfjvjujitmizocefugcne.QualifyingEncounter;
		var j_ = context.Operators.Select<Tuple_HHhYPFJVjUjiTMIZOceFUGCNE, Encounter>(h_, i_);

		return j_;
	}

    [CqlDeclaration("Encounter with Nutrition Assessment Not or Mildly Malnourished")]
	public IEnumerable<Encounter> Encounter_with_Nutrition_Assessment_Not_or_Mildly_Malnourished() => 
		__Encounter_with_Nutrition_Assessment_Not_or_Mildly_Malnourished.Value;

	private IEnumerable<Encounter> Encounter_with_Malnutrition_Diagnosis_Value()
	{
		var a_ = this.Qualifying_Encounter();
		var b_ = this.Malnutrition_Diagnosis();
		var c_ = context.Operators.RetrieveByValueSet<Condition>(b_, null);
		var d_ = context.Operators.CrossJoin<Encounter, Condition>(a_, c_);
		Tuple_GSiGYORNRKJGEXbhEjVIWNTMN e_(ValueTuple<Encounter, Condition> _valueTuple)
		{
			var k_ = new Tuple_GSiGYORNRKJGEXbhEjVIWNTMN
			{
				QualifyingEncounter = _valueTuple.Item1,
				MalnutritionDiagnosis = _valueTuple.Item2,
			};

			return k_;
		};
		var f_ = context.Operators.Select<ValueTuple<Encounter, Condition>, Tuple_GSiGYORNRKJGEXbhEjVIWNTMN>(d_, e_);
		bool? g_(Tuple_GSiGYORNRKJGEXbhEjVIWNTMN tuple_gsigyornrkjgexbhejviwntmn)
		{
			var l_ = tuple_gsigyornrkjgexbhejviwntmn.MalnutritionDiagnosis?.Code;
			var m_ = FHIRHelpers_4_3_000.ToConcept(l_);
			var n_ = this.Malnutrition_Diagnosis();
			var o_ = context.Operators.ConceptInValueSet(m_, n_);
			var p_ = QICoreCommon_2_0_000.prevalenceInterval(tuple_gsigyornrkjgexbhejviwntmn.MalnutritionDiagnosis);
			var q_ = context.Operators.Start(p_);
			var r_ = CQMCommon_2_0_000.hospitalizationWithObservation(tuple_gsigyornrkjgexbhejviwntmn.QualifyingEncounter);
			var s_ = context.Operators.In<CqlDateTime>(q_, r_, null);
			var t_ = context.Operators.And(o_, s_);

			return t_;
		};
		var h_ = context.Operators.Where<Tuple_GSiGYORNRKJGEXbhEjVIWNTMN>(f_, g_);
		Encounter i_(Tuple_GSiGYORNRKJGEXbhEjVIWNTMN tuple_gsigyornrkjgexbhejviwntmn) => 
			tuple_gsigyornrkjgexbhejviwntmn.QualifyingEncounter;
		var j_ = context.Operators.Select<Tuple_GSiGYORNRKJGEXbhEjVIWNTMN, Encounter>(h_, i_);

		return j_;
	}

    [CqlDeclaration("Encounter with Malnutrition Diagnosis")]
	public IEnumerable<Encounter> Encounter_with_Malnutrition_Diagnosis() => 
		__Encounter_with_Malnutrition_Diagnosis.Value;

	private IEnumerable<Encounter> Encounter_with_Nutrition_Care_Plan_Value()
	{
		var a_ = this.Qualifying_Encounter();
		var b_ = this.Nutrition_Care_Plan();
		var c_ = context.Operators.RetrieveByValueSet<Procedure>(b_, null);
		var d_ = context.Operators.CrossJoin<Encounter, Procedure>(a_, c_);
		Tuple_igUTMWHAUfJcWZMIjcGJEYSM e_(ValueTuple<Encounter, Procedure> _valueTuple)
		{
			var k_ = new Tuple_igUTMWHAUfJcWZMIjcGJEYSM
			{
				QualifyingEncounter = _valueTuple.Item1,
				NutritionCarePlan = _valueTuple.Item2,
			};

			return k_;
		};
		var f_ = context.Operators.Select<ValueTuple<Encounter, Procedure>, Tuple_igUTMWHAUfJcWZMIjcGJEYSM>(d_, e_);
		bool? g_(Tuple_igUTMWHAUfJcWZMIjcGJEYSM tuple_igutmwhaufjcwzmijcgjeysm)
		{
			var l_ = tuple_igutmwhaufjcwzmijcgjeysm.NutritionCarePlan?.Code;
			var m_ = FHIRHelpers_4_3_000.ToConcept(l_);
			var n_ = this.Nutrition_Care_Plan();
			var o_ = context.Operators.ConceptInValueSet(m_, n_);
			var p_ = tuple_igutmwhaufjcwzmijcgjeysm.NutritionCarePlan?.StatusElement;
			var q_ = p_?.Value;
			var r_ = context.Operators.Convert<string>(q_);
			var s_ = new string[]
			{
				"completed",
				"in-progress",
			};
			var t_ = context.Operators.In<string>(r_, (s_ as IEnumerable<string>));
			var u_ = context.Operators.And(o_, t_);
			var v_ = tuple_igutmwhaufjcwzmijcgjeysm.NutritionCarePlan?.Performed;
			var w_ = FHIRHelpers_4_3_000.ToValue(v_);
			var x_ = QICoreCommon_2_0_000.earliest(w_);
			var y_ = CQMCommon_2_0_000.hospitalizationWithObservation(tuple_igutmwhaufjcwzmijcgjeysm.QualifyingEncounter);
			var z_ = context.Operators.In<CqlDateTime>(x_, y_, null);
			var aa_ = context.Operators.And(u_, z_);

			return aa_;
		};
		var h_ = context.Operators.Where<Tuple_igUTMWHAUfJcWZMIjcGJEYSM>(f_, g_);
		Encounter i_(Tuple_igUTMWHAUfJcWZMIjcGJEYSM tuple_igutmwhaufjcwzmijcgjeysm) => 
			tuple_igutmwhaufjcwzmijcgjeysm.QualifyingEncounter;
		var j_ = context.Operators.Select<Tuple_igUTMWHAUfJcWZMIjcGJEYSM, Encounter>(h_, i_);

		return j_;
	}

    [CqlDeclaration("Encounter with Nutrition Care Plan")]
	public IEnumerable<Encounter> Encounter_with_Nutrition_Care_Plan() => 
		__Encounter_with_Nutrition_Care_Plan.Value;

    [CqlDeclaration("Measure Observation 1")]
	public int? Measure_Observation_1(Encounter MalnutritionRiskScreening) => 
		((context.Operators.Contains<Encounter>(this.Encounter_with_Malnutrition_Risk_Screening_or_with_Hospital_Dietitian_Referral(), MalnutritionRiskScreening) ?? false)
			? 1
			: 0);

    [CqlDeclaration("Measure Observation 2")]
	public int? Measure_Observation_2(Encounter NutritionAssessment)
	{
		int? a_()
		{
			bool b_()
			{
				var d_ = this.Encounter_with_Malnutrition_Not_at_Risk_Screening_and_without_Hospital_Dietitian_Referral();
				var e_ = context.Operators.Contains<Encounter>(d_, NutritionAssessment);

				return (e_ ?? false);
			};
			bool c_()
			{
				var f_ = this.Encounter_with_Malnutrition_Risk_Screening_at_Risk_or_with_Hospital_Dietitian_Referral();
				var g_ = context.Operators.Contains<Encounter>(f_, NutritionAssessment);

				return (g_ ?? false);
			};
			if (b_())
			{
				return 0;
			}
			else if (c_())
			{
				return ((context.Operators.Contains<Encounter>(this.Encounter_with_Nutrition_Assessment_and_Identified_Status(), NutritionAssessment) ?? false)
					? 1
					: 0);
			}
			else
			{
				return 0;
			}
		};

		return a_();
	}

    [CqlDeclaration("Measure Observation 3")]
	public int? Measure_Observation_3(Encounter MalnutritionDiagonsis)
	{
		int? a_()
		{
			bool b_()
			{
				var d_ = this.Encounter_with_Malnutrition_Not_at_Risk_Screening_and_without_Hospital_Dietitian_Referral();
				var e_ = context.Operators.Contains<Encounter>(d_, MalnutritionDiagonsis);

				return (e_ ?? false);
			};
			bool c_()
			{
				var f_ = this.Encounter_with_Malnutrition_Risk_Screening_at_Risk_or_with_Hospital_Dietitian_Referral();
				var g_ = context.Operators.Contains<Encounter>(f_, MalnutritionDiagonsis);

				return (g_ ?? false);
			};
			if (b_())
			{
				return 0;
			}
			else if (c_())
			{
				int? h_()
				{
					bool i_()
					{
						var j_ = this.Encounter_with_Malnutrition_Diagnosis();
						var k_ = context.Operators.Contains<Encounter>(j_, MalnutritionDiagonsis);

						return (k_ ?? false);
					};
					if (i_())
					{
						int? l_()
						{
							bool m_()
							{
								var o_ = this.Encounter_with_Nutrition_Assessment_Not_or_Mildly_Malnourished();
								var p_ = context.Operators.Contains<Encounter>(o_, MalnutritionDiagonsis);

								return (p_ ?? false);
							};
							bool n_()
							{
								var q_ = this.Encounter_with_Nutrition_Assessment_Status_Moderately_Or_Severely_Malnourished();
								var r_ = context.Operators.Contains<Encounter>(q_, MalnutritionDiagonsis);

								return (r_ ?? false);
							};
							if (m_())
							{
								return 0;
							}
							else if (n_())
							{
								return 1;
							}
							else
							{
								return 0;
							}
						};

						return l_();
					}
					else
					{
						return 0;
					}
				};

				return h_();
			}
			else
			{
				return 0;
			}
		};

		return a_();
	}

    [CqlDeclaration("Measure Observation 4")]
	public int? Measure_Observation_4(Encounter NutritionCarePlan)
	{
		int? a_()
		{
			bool b_()
			{
				var d_ = this.Encounter_with_Malnutrition_Not_at_Risk_Screening_and_without_Hospital_Dietitian_Referral();
				var e_ = context.Operators.Contains<Encounter>(d_, NutritionCarePlan);

				return (e_ ?? false);
			};
			bool c_()
			{
				var f_ = this.Encounter_with_Malnutrition_Risk_Screening_at_Risk_or_with_Hospital_Dietitian_Referral();
				var g_ = context.Operators.Contains<Encounter>(f_, NutritionCarePlan);

				return (g_ ?? false);
			};
			if (b_())
			{
				return 0;
			}
			else if (c_())
			{
				int? h_()
				{
					bool i_()
					{
						var j_ = this.Encounter_with_Nutrition_Care_Plan();
						var k_ = context.Operators.Contains<Encounter>(j_, NutritionCarePlan);

						return (k_ ?? false);
					};
					if (i_())
					{
						int? l_()
						{
							bool m_()
							{
								var o_ = this.Encounter_with_Nutrition_Assessment_Not_or_Mildly_Malnourished();
								var p_ = context.Operators.Contains<Encounter>(o_, NutritionCarePlan);

								return (p_ ?? false);
							};
							bool n_()
							{
								var q_ = this.Encounter_with_Nutrition_Assessment_Status_Moderately_Or_Severely_Malnourished();
								var r_ = context.Operators.Contains<Encounter>(q_, NutritionCarePlan);

								return (r_ ?? false);
							};
							if (m_())
							{
								return 0;
							}
							else if (n_())
							{
								return 1;
							}
							else
							{
								return 0;
							}
						};

						return l_();
					}
					else
					{
						return 0;
					}
				};

				return h_();
			}
			else
			{
				return 0;
			}
		};

		return a_();
	}

    [CqlDeclaration("Measure Observation TotalMalnutritionComponentsScore")]
	public int? Measure_Observation_TotalMalnutritionComponentsScore(Encounter QualifyingEncounter)
	{
		var a_ = this.Measure_Observation_1(QualifyingEncounter);
		var b_ = this.Measure_Observation_2(QualifyingEncounter);
		var c_ = this.Measure_Observation_3(QualifyingEncounter);
		var d_ = this.Measure_Observation_4(QualifyingEncounter);
		var e_ = new int?[]
		{
			a_,
			b_,
			c_,
			d_,
		};
		var f_ = context.Operators.Sum((e_ as IEnumerable<int?>));

		return f_;
	}

    [CqlDeclaration("TotalMalnutritionCompositeScore Eligible Denominators")]
	public int? TotalMalnutritionCompositeScore_Eligible_Denominators(Encounter QualifyingEncounter)
	{
		int? a_()
		{
			bool b_()
			{
				var d_ = this.Encounter_with_Malnutrition_Risk_Screening_or_with_Hospital_Dietitian_Referral();
				var e_ = context.Operators.Contains<Encounter>(d_, QualifyingEncounter);
				var f_ = this.Encounter_with_Malnutrition_Risk_Screening_Not_at_Risk();
				var g_ = context.Operators.Contains<Encounter>(f_, QualifyingEncounter);
				var h_ = context.Operators.And(e_, g_);
				var i_ = this.Encounter_with_Hospital_Dietitian_Referral();
				var j_ = context.Operators.Contains<Encounter>(i_, QualifyingEncounter);
				var k_ = context.Operators.Not(j_);
				var l_ = context.Operators.And(h_, k_);

				return (l_ ?? false);
			};
			bool c_()
			{
				var m_ = this.Encounter_with_Malnutrition_Risk_Screening_or_with_Hospital_Dietitian_Referral();
				var n_ = context.Operators.Contains<Encounter>(m_, QualifyingEncounter);
				var o_ = this.Encounter_with_Malnutrition_Risk_Screening_at_Risk();
				var p_ = context.Operators.Contains<Encounter>(o_, QualifyingEncounter);
				var q_ = context.Operators.And(n_, p_);
				var r_ = this.Encounter_with_Hospital_Dietitian_Referral();
				var s_ = context.Operators.Contains<Encounter>(r_, QualifyingEncounter);
				var t_ = context.Operators.Or(q_, s_);
				var u_ = this.Encounter_with_Nutrition_Assessment_Not_or_Mildly_Malnourished();
				var v_ = context.Operators.Contains<Encounter>(u_, QualifyingEncounter);
				var w_ = context.Operators.And(t_, v_);
				var x_ = this.Encounter_with_Nutrition_Assessment_and_Identified_Status();
				var y_ = context.Operators.Contains<Encounter>(x_, QualifyingEncounter);
				var z_ = context.Operators.Not(y_);
				var aa_ = context.Operators.Or(w_, z_);

				return (aa_ ?? false);
			};
			if (b_())
			{
				return 1;
			}
			else if (c_())
			{
				return 2;
			}
			else
			{
				return 4;
			}
		};

		return a_();
	}

    [CqlDeclaration("Measure Observation TotalMalnutritionCompositeScore as Percentage")]
	public decimal? Measure_Observation_TotalMalnutritionCompositeScore_as_Percentage(Encounter QualifyingEncounter)
	{
		var a_ = context.Operators.ConvertIntegerToDecimal(100);
		var b_ = this.Measure_Observation_TotalMalnutritionComponentsScore(QualifyingEncounter);
		var c_ = context.Operators.ConvertIntegerToDecimal(b_);
		var d_ = this.TotalMalnutritionCompositeScore_Eligible_Denominators(QualifyingEncounter);
		var e_ = context.Operators.ConvertIntegerToDecimal(d_);
		var f_ = context.Operators.Divide(c_, e_);
		var g_ = context.Operators.Multiply(a_, f_);

		return g_;
	}

}
