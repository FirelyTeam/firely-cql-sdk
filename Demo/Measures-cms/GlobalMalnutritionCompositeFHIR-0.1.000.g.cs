using System;
using Tuples;
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
    internal Lazy<Tuple_DMgHTLENEHBHWJISQgKZGZVMB> __SDE_Ethnicity;
    internal Lazy<IEnumerable<Tuple_GDKRbfOIHhLGieQSVDEMIaDPX>> __SDE_Payer_Type;
    internal Lazy<Tuple_DMgHTLENEHBHWJISQgKZGZVMB> __SDE_Race;
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
        __SDE_Ethnicity = new Lazy<Tuple_DMgHTLENEHBHWJISQgKZGZVMB>(this.SDE_Ethnicity_Value);
        __SDE_Payer_Type = new Lazy<IEnumerable<Tuple_GDKRbfOIHhLGieQSVDEMIaDPX>>(this.SDE_Payer_Type_Value);
        __SDE_Race = new Lazy<Tuple_DMgHTLENEHBHWJISQgKZGZVMB>(this.SDE_Race_Value);
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
		var a_ = context.Operators.DateTime((int?)2025, (int?)1, (int?)1, (int?)0, (int?)0, (int?)0, (int?)0, default);
		var b_ = context.Operators.DateTime((int?)2026, (int?)1, (int?)1, (int?)0, (int?)0, (int?)0, (int?)0, default);
		var c_ = context.Operators.Interval(a_, b_, (bool?)true, (bool?)false);
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

	private Tuple_DMgHTLENEHBHWJISQgKZGZVMB SDE_Ethnicity_Value()
	{
		var a_ = SupplementalDataElements_3_4_000.SDE_Ethnicity();

		return a_;
	}

    [CqlDeclaration("SDE Ethnicity")]
	public Tuple_DMgHTLENEHBHWJISQgKZGZVMB SDE_Ethnicity() => 
		__SDE_Ethnicity.Value;

	private IEnumerable<Tuple_GDKRbfOIHhLGieQSVDEMIaDPX> SDE_Payer_Type_Value()
	{
		var a_ = SupplementalDataElements_3_4_000.SDE_Payer();

		return a_;
	}

    [CqlDeclaration("SDE Payer Type")]
	public IEnumerable<Tuple_GDKRbfOIHhLGieQSVDEMIaDPX> SDE_Payer_Type() => 
		__SDE_Payer_Type.Value;

	private Tuple_DMgHTLENEHBHWJISQgKZGZVMB SDE_Race_Value()
	{
		var a_ = SupplementalDataElements_3_4_000.SDE_Race();

		return a_;
	}

    [CqlDeclaration("SDE Race")]
	public Tuple_DMgHTLENEHBHWJISQgKZGZVMB SDE_Race() => 
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
			var e_ = FHIRHelpers_4_3_000.ToInterval(EncounterInpatient?.Period);
			var f_ = context.Operators.End(e_);
			var g_ = this.Measurement_Period();
			var h_ = context.Operators.ElementInInterval<CqlDateTime>(f_, g_, "day");
			var i_ = this.Patient();
			var j_ = context.Operators.Convert<CqlDate>(i_?.BirthDateElement?.Value);
			var l_ = context.Operators.Start(e_);
			var m_ = context.Operators.DateFrom(l_);
			var n_ = context.Operators.CalculateAgeAt(j_, m_, "year");
			var o_ = context.Operators.GreaterOrEqual(n_, (int?)65);
			var p_ = context.Operators.And(h_, o_);
			var r_ = context.Operators.Start(e_);
			var t_ = context.Operators.End(e_);
			var u_ = context.Operators.DurationBetween(r_, t_, "hour");
			var v_ = context.Operators.GreaterOrEqual(u_, (int?)24);
			var w_ = context.Operators.And(p_, v_);
			var x_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(EncounterInpatient?.StatusElement?.Value);
			var y_ = context.Operators.Equal(x_, "finished");
			var z_ = context.Operators.And(w_, y_);

			return z_;
		};
		var d_ = context.Operators.WhereOrNull<Encounter>(b_, c_);

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
		Tuple_BdOfeUSQKMfBEYcULSQYBIjjC e_(ValueTuple<Encounter,Procedure> _valueTuple)
		{
			var k_ = new Tuple_BdOfeUSQKMfBEYcULSQYBIjjC
			{
				QualifyingEncounter = _valueTuple.Item1,
				HospitalDietitianReferral = _valueTuple.Item2,
			};

			return k_;
		};
		var f_ = context.Operators.SelectOrNull<ValueTuple<Encounter,Procedure>, Tuple_BdOfeUSQKMfBEYcULSQYBIjjC>(d_, e_);
		bool? g_(Tuple_BdOfeUSQKMfBEYcULSQYBIjjC tuple_bdofeusqkmfbeyculsqybijjc)
		{
			var l_ = FHIRHelpers_4_3_000.ToConcept(tuple_bdofeusqkmfbeyculsqybijjc.HospitalDietitianReferral?.Code);
			var m_ = this.Hospital_Dietitian_Referral();
			var n_ = context.Operators.ConceptInValueSet((l_ as CqlConcept), m_);
			var o_ = context.Operators.Convert<string>(tuple_bdofeusqkmfbeyculsqybijjc.HospitalDietitianReferral?.StatusElement?.Value);
			var p_ = new string[]
			{
				"active",
				"completed",
				"in-progress",
			};
			var q_ = context.Operators.InList<string>(o_, (p_ as IEnumerable<string>));
			var r_ = context.Operators.And(n_, q_);
			var s_ = FHIRHelpers_4_3_000.ToValue(tuple_bdofeusqkmfbeyculsqybijjc.HospitalDietitianReferral?.Performed);
			var t_ = QICoreCommon_2_0_000.earliest(s_);
			var u_ = CQMCommon_2_0_000.hospitalizationWithObservation(tuple_bdofeusqkmfbeyculsqybijjc.QualifyingEncounter);
			var v_ = context.Operators.ElementInInterval<CqlDateTime>(t_, u_, null);
			var w_ = context.Operators.And(r_, v_);

			return w_;
		};
		var h_ = context.Operators.WhereOrNull<Tuple_BdOfeUSQKMfBEYcULSQYBIjjC>(f_, g_);
		Encounter i_(Tuple_BdOfeUSQKMfBEYcULSQYBIjjC tuple_bdofeusqkmfbeyculsqybijjc) => 
			tuple_bdofeusqkmfbeyculsqybijjc.QualifyingEncounter;
		var j_ = context.Operators.SelectOrNull<Tuple_BdOfeUSQKMfBEYcULSQYBIjjC, Encounter>(h_, i_);

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
		Tuple_FfUejBAXZfEABRILhFReePdGS e_(ValueTuple<Encounter,Observation> _valueTuple)
		{
			var k_ = new Tuple_FfUejBAXZfEABRILhFReePdGS
			{
				QualifyingEncounter = _valueTuple.Item1,
				MalnutritionRiskScreening = _valueTuple.Item2,
			};

			return k_;
		};
		var f_ = context.Operators.SelectOrNull<ValueTuple<Encounter,Observation>, Tuple_FfUejBAXZfEABRILhFReePdGS>(d_, e_);
		bool? g_(Tuple_FfUejBAXZfEABRILhFReePdGS tuple_ffuejbaxzfeabrilhfreepdgs)
		{
			var l_ = FHIRHelpers_4_3_000.ToConcept(tuple_ffuejbaxzfeabrilhfreepdgs.MalnutritionRiskScreening?.Code);
			var m_ = this.Malnutrition_Risk_Screening();
			var n_ = context.Operators.ConceptInValueSet((l_ as CqlConcept), m_);
			var o_ = context.Operators.Convert<Code<ObservationStatus>>(tuple_ffuejbaxzfeabrilhfreepdgs.MalnutritionRiskScreening?.StatusElement?.Value);
			var p_ = context.Operators.Convert<string>(o_);
			var q_ = new string[]
			{
				"final",
				"amended",
				"corrected",
			};
			var r_ = context.Operators.InList<string>(p_, (q_ as IEnumerable<string>));
			var s_ = context.Operators.And(n_, r_);
			var t_ = CQMCommon_2_0_000.hospitalizationWithObservation(tuple_ffuejbaxzfeabrilhfreepdgs.QualifyingEncounter);
			var u_ = FHIRHelpers_4_3_000.ToValue(tuple_ffuejbaxzfeabrilhfreepdgs.MalnutritionRiskScreening?.Effective);
			var v_ = QICoreCommon_2_0_000.toInterval(u_);
			var w_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(t_, v_, null);
			var x_ = context.Operators.And(s_, w_);
			var y_ = FHIRHelpers_4_3_000.ToValue(tuple_ffuejbaxzfeabrilhfreepdgs.MalnutritionRiskScreening?.Value);
			var z_ = this.Malnutrition_Screening_Not_At_Risk_Result();
			var aa_ = context.Operators.ConceptInValueSet((y_ as CqlConcept), z_);
			var ac_ = this.Malnutrition_Screening_At_Risk_Result();
			var ad_ = context.Operators.ConceptInValueSet((y_ as CqlConcept), ac_);
			var ae_ = context.Operators.Or(aa_, ad_);
			var af_ = context.Operators.And(x_, ae_);

			return af_;
		};
		var h_ = context.Operators.WhereOrNull<Tuple_FfUejBAXZfEABRILhFReePdGS>(f_, g_);
		Encounter i_(Tuple_FfUejBAXZfEABRILhFReePdGS tuple_ffuejbaxzfeabrilhfreepdgs) => 
			tuple_ffuejbaxzfeabrilhfreepdgs.QualifyingEncounter;
		var j_ = context.Operators.SelectOrNull<Tuple_FfUejBAXZfEABRILhFReePdGS, Encounter>(h_, i_);

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
			var g_ = context.Operators.ListContains<Encounter>(f_, QualifyingEncounter);
			var h_ = this.Encounter_with_Hospital_Dietitian_Referral();
			var i_ = context.Operators.ListContains<Encounter>(h_, QualifyingEncounter);
			var j_ = context.Operators.Or(g_, i_);

			return j_;
		};
		var c_ = context.Operators.WhereOrNull<Encounter>(a_, b_);
		Encounter d_(Encounter QualifyingEncounter) => 
			QualifyingEncounter;
		var e_ = context.Operators.SelectOrNull<Encounter, Encounter>(c_, d_);

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
		Tuple_FfUejBAXZfEABRILhFReePdGS e_(ValueTuple<Encounter,Observation> _valueTuple)
		{
			var k_ = new Tuple_FfUejBAXZfEABRILhFReePdGS
			{
				QualifyingEncounter = _valueTuple.Item1,
				MalnutritionRiskScreening = _valueTuple.Item2,
			};

			return k_;
		};
		var f_ = context.Operators.SelectOrNull<ValueTuple<Encounter,Observation>, Tuple_FfUejBAXZfEABRILhFReePdGS>(d_, e_);
		bool? g_(Tuple_FfUejBAXZfEABRILhFReePdGS tuple_ffuejbaxzfeabrilhfreepdgs)
		{
			var l_ = FHIRHelpers_4_3_000.ToConcept(tuple_ffuejbaxzfeabrilhfreepdgs.MalnutritionRiskScreening?.Code);
			var m_ = this.Malnutrition_Risk_Screening();
			var n_ = context.Operators.ConceptInValueSet((l_ as CqlConcept), m_);
			var o_ = context.Operators.Convert<Code<ObservationStatus>>(tuple_ffuejbaxzfeabrilhfreepdgs.MalnutritionRiskScreening?.StatusElement?.Value);
			var p_ = context.Operators.Convert<string>(o_);
			var q_ = new string[]
			{
				"final",
				"amended",
				"corrected",
			};
			var r_ = context.Operators.InList<string>(p_, (q_ as IEnumerable<string>));
			var s_ = context.Operators.And(n_, r_);
			var t_ = CQMCommon_2_0_000.hospitalizationWithObservation(tuple_ffuejbaxzfeabrilhfreepdgs.QualifyingEncounter);
			var u_ = FHIRHelpers_4_3_000.ToValue(tuple_ffuejbaxzfeabrilhfreepdgs.MalnutritionRiskScreening?.Effective);
			var v_ = QICoreCommon_2_0_000.toInterval(u_);
			var w_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(t_, v_, null);
			var x_ = context.Operators.And(s_, w_);
			var y_ = FHIRHelpers_4_3_000.ToValue(tuple_ffuejbaxzfeabrilhfreepdgs.MalnutritionRiskScreening?.Value);
			var z_ = this.Malnutrition_Screening_Not_At_Risk_Result();
			var aa_ = context.Operators.ConceptInValueSet((y_ as CqlConcept), z_);
			var ab_ = context.Operators.And(x_, aa_);

			return ab_;
		};
		var h_ = context.Operators.WhereOrNull<Tuple_FfUejBAXZfEABRILhFReePdGS>(f_, g_);
		Encounter i_(Tuple_FfUejBAXZfEABRILhFReePdGS tuple_ffuejbaxzfeabrilhfreepdgs) => 
			tuple_ffuejbaxzfeabrilhfreepdgs.QualifyingEncounter;
		var j_ = context.Operators.SelectOrNull<Tuple_FfUejBAXZfEABRILhFReePdGS, Encounter>(h_, i_);

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
			var g_ = context.Operators.ListContains<Encounter>(f_, QualifyingEncounter);
			var h_ = this.Encounter_with_Hospital_Dietitian_Referral();
			var i_ = context.Operators.ExistsInList<Encounter>(h_);
			var j_ = context.Operators.Not(i_);
			var k_ = context.Operators.And(g_, j_);

			return k_;
		};
		var c_ = context.Operators.WhereOrNull<Encounter>(a_, b_);
		Encounter d_(Encounter QualifyingEncounter) => 
			QualifyingEncounter;
		var e_ = context.Operators.SelectOrNull<Encounter, Encounter>(c_, d_);

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
		Tuple_FfUejBAXZfEABRILhFReePdGS e_(ValueTuple<Encounter,Observation> _valueTuple)
		{
			var k_ = new Tuple_FfUejBAXZfEABRILhFReePdGS
			{
				QualifyingEncounter = _valueTuple.Item1,
				MalnutritionRiskScreening = _valueTuple.Item2,
			};

			return k_;
		};
		var f_ = context.Operators.SelectOrNull<ValueTuple<Encounter,Observation>, Tuple_FfUejBAXZfEABRILhFReePdGS>(d_, e_);
		bool? g_(Tuple_FfUejBAXZfEABRILhFReePdGS tuple_ffuejbaxzfeabrilhfreepdgs)
		{
			var l_ = FHIRHelpers_4_3_000.ToConcept(tuple_ffuejbaxzfeabrilhfreepdgs.MalnutritionRiskScreening?.Code);
			var m_ = this.Malnutrition_Risk_Screening();
			var n_ = context.Operators.ConceptInValueSet((l_ as CqlConcept), m_);
			var o_ = context.Operators.Convert<Code<ObservationStatus>>(tuple_ffuejbaxzfeabrilhfreepdgs.MalnutritionRiskScreening?.StatusElement?.Value);
			var p_ = context.Operators.Convert<string>(o_);
			var q_ = new string[]
			{
				"final",
				"amended",
				"corrected",
			};
			var r_ = context.Operators.InList<string>(p_, (q_ as IEnumerable<string>));
			var s_ = context.Operators.And(n_, r_);
			var t_ = CQMCommon_2_0_000.hospitalizationWithObservation(tuple_ffuejbaxzfeabrilhfreepdgs.QualifyingEncounter);
			var u_ = FHIRHelpers_4_3_000.ToValue(tuple_ffuejbaxzfeabrilhfreepdgs.MalnutritionRiskScreening?.Effective);
			var v_ = QICoreCommon_2_0_000.toInterval(u_);
			var w_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(t_, v_, null);
			var x_ = context.Operators.And(s_, w_);
			var y_ = FHIRHelpers_4_3_000.ToValue(tuple_ffuejbaxzfeabrilhfreepdgs.MalnutritionRiskScreening?.Value);
			var z_ = this.Malnutrition_Screening_At_Risk_Result();
			var aa_ = context.Operators.ConceptInValueSet((y_ as CqlConcept), z_);
			var ab_ = context.Operators.And(x_, aa_);

			return ab_;
		};
		var h_ = context.Operators.WhereOrNull<Tuple_FfUejBAXZfEABRILhFReePdGS>(f_, g_);
		Encounter i_(Tuple_FfUejBAXZfEABRILhFReePdGS tuple_ffuejbaxzfeabrilhfreepdgs) => 
			tuple_ffuejbaxzfeabrilhfreepdgs.QualifyingEncounter;
		var j_ = context.Operators.SelectOrNull<Tuple_FfUejBAXZfEABRILhFReePdGS, Encounter>(h_, i_);

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
			var g_ = context.Operators.ListContains<Encounter>(f_, QualifyingEncounter);
			var h_ = this.Encounter_with_Hospital_Dietitian_Referral();
			var i_ = context.Operators.ListContains<Encounter>(h_, QualifyingEncounter);
			var j_ = context.Operators.Or(g_, i_);

			return j_;
		};
		var c_ = context.Operators.WhereOrNull<Encounter>(a_, b_);
		Encounter d_(Encounter QualifyingEncounter) => 
			QualifyingEncounter;
		var e_ = context.Operators.SelectOrNull<Encounter, Encounter>(c_, d_);

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
		Tuple_FNbCKKYcLGcBUjDdFESQQgGfh e_(ValueTuple<Encounter,Observation> _valueTuple)
		{
			var k_ = new Tuple_FNbCKKYcLGcBUjDdFESQQgGfh
			{
				QualifyingEncounter = _valueTuple.Item1,
				NutritionAssessment = _valueTuple.Item2,
			};

			return k_;
		};
		var f_ = context.Operators.SelectOrNull<ValueTuple<Encounter,Observation>, Tuple_FNbCKKYcLGcBUjDdFESQQgGfh>(d_, e_);
		bool? g_(Tuple_FNbCKKYcLGcBUjDdFESQQgGfh tuple_fnbckkyclgcbujddfesqqggfh)
		{
			var l_ = FHIRHelpers_4_3_000.ToConcept(tuple_fnbckkyclgcbujddfesqqggfh.NutritionAssessment?.Code);
			var m_ = this.Nutrition_Assessment();
			var n_ = context.Operators.ConceptInValueSet((l_ as CqlConcept), m_);
			var o_ = context.Operators.Convert<Code<ObservationStatus>>(tuple_fnbckkyclgcbujddfesqqggfh.NutritionAssessment?.StatusElement?.Value);
			var p_ = context.Operators.Convert<string>(o_);
			var q_ = new string[]
			{
				"final",
				"amended",
				"corrected",
			};
			var r_ = context.Operators.InList<string>(p_, (q_ as IEnumerable<string>));
			var s_ = context.Operators.And(n_, r_);
			var t_ = CQMCommon_2_0_000.hospitalizationWithObservation(tuple_fnbckkyclgcbujddfesqqggfh.QualifyingEncounter);
			var u_ = FHIRHelpers_4_3_000.ToValue(tuple_fnbckkyclgcbujddfesqqggfh.NutritionAssessment?.Effective);
			var v_ = QICoreCommon_2_0_000.toInterval(u_);
			var w_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(t_, v_, null);
			var x_ = context.Operators.And(s_, w_);
			var y_ = FHIRHelpers_4_3_000.ToValue(tuple_fnbckkyclgcbujddfesqqggfh.NutritionAssessment?.Value);
			var z_ = this.Nutrition_Assessment_Status_Moderately_Malnourished();
			var aa_ = context.Operators.ConceptInValueSet((y_ as CqlConcept), z_);
			var ac_ = this.Nutrition_Assessment_Status_Not_or_Mildly_Malnourished();
			var ad_ = context.Operators.ConceptInValueSet((y_ as CqlConcept), ac_);
			var ae_ = context.Operators.Or(aa_, ad_);
			var ag_ = this.Nutrition_Assessment_Status_Severely_Malnourished();
			var ah_ = context.Operators.ConceptInValueSet((y_ as CqlConcept), ag_);
			var ai_ = context.Operators.Or(ae_, ah_);
			var aj_ = context.Operators.And(x_, ai_);

			return aj_;
		};
		var h_ = context.Operators.WhereOrNull<Tuple_FNbCKKYcLGcBUjDdFESQQgGfh>(f_, g_);
		Encounter i_(Tuple_FNbCKKYcLGcBUjDdFESQQgGfh tuple_fnbckkyclgcbujddfesqqggfh) => 
			tuple_fnbckkyclgcbujddfesqqggfh.QualifyingEncounter;
		var j_ = context.Operators.SelectOrNull<Tuple_FNbCKKYcLGcBUjDdFESQQgGfh, Encounter>(h_, i_);

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
		Tuple_FNbCKKYcLGcBUjDdFESQQgGfh e_(ValueTuple<Encounter,Observation> _valueTuple)
		{
			var k_ = new Tuple_FNbCKKYcLGcBUjDdFESQQgGfh
			{
				QualifyingEncounter = _valueTuple.Item1,
				NutritionAssessment = _valueTuple.Item2,
			};

			return k_;
		};
		var f_ = context.Operators.SelectOrNull<ValueTuple<Encounter,Observation>, Tuple_FNbCKKYcLGcBUjDdFESQQgGfh>(d_, e_);
		bool? g_(Tuple_FNbCKKYcLGcBUjDdFESQQgGfh tuple_fnbckkyclgcbujddfesqqggfh)
		{
			var l_ = FHIRHelpers_4_3_000.ToConcept(tuple_fnbckkyclgcbujddfesqqggfh.NutritionAssessment?.Code);
			var m_ = this.Nutrition_Assessment();
			var n_ = context.Operators.ConceptInValueSet((l_ as CqlConcept), m_);
			var o_ = context.Operators.Convert<Code<ObservationStatus>>(tuple_fnbckkyclgcbujddfesqqggfh.NutritionAssessment?.StatusElement?.Value);
			var p_ = context.Operators.Convert<string>(o_);
			var q_ = new string[]
			{
				"final",
				"amended",
				"corrected",
			};
			var r_ = context.Operators.InList<string>(p_, (q_ as IEnumerable<string>));
			var s_ = context.Operators.And(n_, r_);
			var t_ = CQMCommon_2_0_000.hospitalizationWithObservation(tuple_fnbckkyclgcbujddfesqqggfh.QualifyingEncounter);
			var u_ = FHIRHelpers_4_3_000.ToValue(tuple_fnbckkyclgcbujddfesqqggfh.NutritionAssessment?.Effective);
			var v_ = QICoreCommon_2_0_000.toInterval(u_);
			var w_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(t_, v_, null);
			var x_ = context.Operators.And(s_, w_);
			var y_ = FHIRHelpers_4_3_000.ToValue(tuple_fnbckkyclgcbujddfesqqggfh.NutritionAssessment?.Value);
			var z_ = this.Nutrition_Assessment_Status_Moderately_Malnourished();
			var aa_ = context.Operators.ConceptInValueSet((y_ as CqlConcept), z_);
			var ac_ = this.Nutrition_Assessment_Status_Severely_Malnourished();
			var ad_ = context.Operators.ConceptInValueSet((y_ as CqlConcept), ac_);
			var ae_ = context.Operators.Or(aa_, ad_);
			var af_ = context.Operators.And(x_, ae_);

			return af_;
		};
		var h_ = context.Operators.WhereOrNull<Tuple_FNbCKKYcLGcBUjDdFESQQgGfh>(f_, g_);
		Encounter i_(Tuple_FNbCKKYcLGcBUjDdFESQQgGfh tuple_fnbckkyclgcbujddfesqqggfh) => 
			tuple_fnbckkyclgcbujddfesqqggfh.QualifyingEncounter;
		var j_ = context.Operators.SelectOrNull<Tuple_FNbCKKYcLGcBUjDdFESQQgGfh, Encounter>(h_, i_);

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
		Tuple_FNbCKKYcLGcBUjDdFESQQgGfh e_(ValueTuple<Encounter,Observation> _valueTuple)
		{
			var k_ = new Tuple_FNbCKKYcLGcBUjDdFESQQgGfh
			{
				QualifyingEncounter = _valueTuple.Item1,
				NutritionAssessment = _valueTuple.Item2,
			};

			return k_;
		};
		var f_ = context.Operators.SelectOrNull<ValueTuple<Encounter,Observation>, Tuple_FNbCKKYcLGcBUjDdFESQQgGfh>(d_, e_);
		bool? g_(Tuple_FNbCKKYcLGcBUjDdFESQQgGfh tuple_fnbckkyclgcbujddfesqqggfh)
		{
			var l_ = FHIRHelpers_4_3_000.ToConcept(tuple_fnbckkyclgcbujddfesqqggfh.NutritionAssessment?.Code);
			var m_ = this.Nutrition_Assessment();
			var n_ = context.Operators.ConceptInValueSet((l_ as CqlConcept), m_);
			var o_ = context.Operators.Convert<Code<ObservationStatus>>(tuple_fnbckkyclgcbujddfesqqggfh.NutritionAssessment?.StatusElement?.Value);
			var p_ = context.Operators.Convert<string>(o_);
			var q_ = new string[]
			{
				"final",
				"amended",
				"corrected",
			};
			var r_ = context.Operators.InList<string>(p_, (q_ as IEnumerable<string>));
			var s_ = context.Operators.And(n_, r_);
			var t_ = CQMCommon_2_0_000.hospitalizationWithObservation(tuple_fnbckkyclgcbujddfesqqggfh.QualifyingEncounter);
			var u_ = FHIRHelpers_4_3_000.ToValue(tuple_fnbckkyclgcbujddfesqqggfh.NutritionAssessment?.Effective);
			var v_ = QICoreCommon_2_0_000.toInterval(u_);
			var w_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(t_, v_, null);
			var x_ = context.Operators.And(s_, w_);
			var y_ = FHIRHelpers_4_3_000.ToValue(tuple_fnbckkyclgcbujddfesqqggfh.NutritionAssessment?.Value);
			var z_ = this.Nutrition_Assessment_Status_Not_or_Mildly_Malnourished();
			var aa_ = context.Operators.ConceptInValueSet((y_ as CqlConcept), z_);
			var ab_ = context.Operators.And(x_, aa_);

			return ab_;
		};
		var h_ = context.Operators.WhereOrNull<Tuple_FNbCKKYcLGcBUjDdFESQQgGfh>(f_, g_);
		Encounter i_(Tuple_FNbCKKYcLGcBUjDdFESQQgGfh tuple_fnbckkyclgcbujddfesqqggfh) => 
			tuple_fnbckkyclgcbujddfesqqggfh.QualifyingEncounter;
		var j_ = context.Operators.SelectOrNull<Tuple_FNbCKKYcLGcBUjDdFESQQgGfh, Encounter>(h_, i_);

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
		Tuple_DTggaXNYbDKaGBeEeceXhUMKb e_(ValueTuple<Encounter,Condition> _valueTuple)
		{
			var k_ = new Tuple_DTggaXNYbDKaGBeEeceXhUMKb
			{
				QualifyingEncounter = _valueTuple.Item1,
				MalnutritionDiagnosis = _valueTuple.Item2,
			};

			return k_;
		};
		var f_ = context.Operators.SelectOrNull<ValueTuple<Encounter,Condition>, Tuple_DTggaXNYbDKaGBeEeceXhUMKb>(d_, e_);
		bool? g_(Tuple_DTggaXNYbDKaGBeEeceXhUMKb tuple_dtggaxnybdkagbeeecexhumkb)
		{
			var l_ = FHIRHelpers_4_3_000.ToConcept(tuple_dtggaxnybdkagbeeecexhumkb.MalnutritionDiagnosis?.Code);
			var m_ = this.Malnutrition_Diagnosis();
			var n_ = context.Operators.ConceptInValueSet((l_ as CqlConcept), m_);
			var o_ = QICoreCommon_2_0_000.prevalenceInterval(tuple_dtggaxnybdkagbeeecexhumkb.MalnutritionDiagnosis);
			var p_ = context.Operators.Start(o_);
			var q_ = CQMCommon_2_0_000.hospitalizationWithObservation(tuple_dtggaxnybdkagbeeecexhumkb.QualifyingEncounter);
			var r_ = context.Operators.ElementInInterval<CqlDateTime>(p_, q_, null);
			var s_ = context.Operators.And(n_, r_);

			return s_;
		};
		var h_ = context.Operators.WhereOrNull<Tuple_DTggaXNYbDKaGBeEeceXhUMKb>(f_, g_);
		Encounter i_(Tuple_DTggaXNYbDKaGBeEeceXhUMKb tuple_dtggaxnybdkagbeeecexhumkb) => 
			tuple_dtggaxnybdkagbeeecexhumkb.QualifyingEncounter;
		var j_ = context.Operators.SelectOrNull<Tuple_DTggaXNYbDKaGBeEeceXhUMKb, Encounter>(h_, i_);

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
		Tuple_cTMBKgNETPhcWPSTMVcRebEg e_(ValueTuple<Encounter,Procedure> _valueTuple)
		{
			var k_ = new Tuple_cTMBKgNETPhcWPSTMVcRebEg
			{
				QualifyingEncounter = _valueTuple.Item1,
				NutritionCarePlan = _valueTuple.Item2,
			};

			return k_;
		};
		var f_ = context.Operators.SelectOrNull<ValueTuple<Encounter,Procedure>, Tuple_cTMBKgNETPhcWPSTMVcRebEg>(d_, e_);
		bool? g_(Tuple_cTMBKgNETPhcWPSTMVcRebEg tuple_ctmbkgnetphcwpstmvcrebeg)
		{
			var l_ = FHIRHelpers_4_3_000.ToConcept(tuple_ctmbkgnetphcwpstmvcrebeg.NutritionCarePlan?.Code);
			var m_ = this.Nutrition_Care_Plan();
			var n_ = context.Operators.ConceptInValueSet((l_ as CqlConcept), m_);
			var o_ = context.Operators.Convert<string>(tuple_ctmbkgnetphcwpstmvcrebeg.NutritionCarePlan?.StatusElement?.Value);
			var p_ = new string[]
			{
				"completed",
				"in-progress",
			};
			var q_ = context.Operators.InList<string>(o_, (p_ as IEnumerable<string>));
			var r_ = context.Operators.And(n_, q_);
			var s_ = FHIRHelpers_4_3_000.ToValue(tuple_ctmbkgnetphcwpstmvcrebeg.NutritionCarePlan?.Performed);
			var t_ = QICoreCommon_2_0_000.earliest(s_);
			var u_ = CQMCommon_2_0_000.hospitalizationWithObservation(tuple_ctmbkgnetphcwpstmvcrebeg.QualifyingEncounter);
			var v_ = context.Operators.ElementInInterval<CqlDateTime>(t_, u_, null);
			var w_ = context.Operators.And(r_, v_);

			return w_;
		};
		var h_ = context.Operators.WhereOrNull<Tuple_cTMBKgNETPhcWPSTMVcRebEg>(f_, g_);
		Encounter i_(Tuple_cTMBKgNETPhcWPSTMVcRebEg tuple_ctmbkgnetphcwpstmvcrebeg) => 
			tuple_ctmbkgnetphcwpstmvcrebeg.QualifyingEncounter;
		var j_ = context.Operators.SelectOrNull<Tuple_cTMBKgNETPhcWPSTMVcRebEg, Encounter>(h_, i_);

		return j_;
	}

    [CqlDeclaration("Encounter with Nutrition Care Plan")]
	public IEnumerable<Encounter> Encounter_with_Nutrition_Care_Plan() => 
		__Encounter_with_Nutrition_Care_Plan.Value;

    [CqlDeclaration("Measure Observation 1")]
	public int? Measure_Observation_1(Encounter MalnutritionRiskScreening) => 
		((context.Operators.ListContains<Encounter>(this.Encounter_with_Malnutrition_Risk_Screening_or_with_Hospital_Dietitian_Referral(), MalnutritionRiskScreening) ?? false)
			? (int?)1
			: (int?)0);

    [CqlDeclaration("Measure Observation 2")]
	public int? Measure_Observation_2(Encounter NutritionAssessment)
	{
		int? a_()
		{
			bool b_()
			{
				var d_ = this.Encounter_with_Malnutrition_Not_at_Risk_Screening_and_without_Hospital_Dietitian_Referral();
				var e_ = context.Operators.ListContains<Encounter>(d_, NutritionAssessment);

				return (e_ ?? false);
			};
			bool c_()
			{
				var f_ = this.Encounter_with_Malnutrition_Risk_Screening_at_Risk_or_with_Hospital_Dietitian_Referral();
				var g_ = context.Operators.ListContains<Encounter>(f_, NutritionAssessment);

				return (g_ ?? false);
			};
			if (b_())
			{
				return (int?)0;
			}
			else if (c_())
			{
				return ((context.Operators.ListContains<Encounter>(this.Encounter_with_Nutrition_Assessment_and_Identified_Status(), NutritionAssessment) ?? false)
					? (int?)1
					: (int?)0);
			}
			else
			{
				return (int?)0;
			};
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
				var e_ = context.Operators.ListContains<Encounter>(d_, MalnutritionDiagonsis);

				return (e_ ?? false);
			};
			bool c_()
			{
				var f_ = this.Encounter_with_Malnutrition_Risk_Screening_at_Risk_or_with_Hospital_Dietitian_Referral();
				var g_ = context.Operators.ListContains<Encounter>(f_, MalnutritionDiagonsis);

				return (g_ ?? false);
			};
			if (b_())
			{
				return (int?)0;
			}
			else if (c_())
			{
				int? h_()
				{
					bool i_()
					{
						var j_ = this.Encounter_with_Malnutrition_Diagnosis();
						var k_ = context.Operators.ListContains<Encounter>(j_, MalnutritionDiagonsis);

						return (k_ ?? false);
					};
					if (i_())
					{
						int? l_()
						{
							bool m_()
							{
								var o_ = this.Encounter_with_Nutrition_Assessment_Not_or_Mildly_Malnourished();
								var p_ = context.Operators.ListContains<Encounter>(o_, MalnutritionDiagonsis);

								return (p_ ?? false);
							};
							bool n_()
							{
								var q_ = this.Encounter_with_Nutrition_Assessment_Status_Moderately_Or_Severely_Malnourished();
								var r_ = context.Operators.ListContains<Encounter>(q_, MalnutritionDiagonsis);

								return (r_ ?? false);
							};
							if (m_())
							{
								return (int?)0;
							}
							else if (n_())
							{
								return (int?)1;
							}
							else
							{
								return (int?)0;
							};
						};

						return l_();
					}
					else
					{
						return (int?)0;
					};
				};

				return h_();
			}
			else
			{
				return (int?)0;
			};
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
				var e_ = context.Operators.ListContains<Encounter>(d_, NutritionCarePlan);

				return (e_ ?? false);
			};
			bool c_()
			{
				var f_ = this.Encounter_with_Malnutrition_Risk_Screening_at_Risk_or_with_Hospital_Dietitian_Referral();
				var g_ = context.Operators.ListContains<Encounter>(f_, NutritionCarePlan);

				return (g_ ?? false);
			};
			if (b_())
			{
				return (int?)0;
			}
			else if (c_())
			{
				int? h_()
				{
					bool i_()
					{
						var j_ = this.Encounter_with_Nutrition_Care_Plan();
						var k_ = context.Operators.ListContains<Encounter>(j_, NutritionCarePlan);

						return (k_ ?? false);
					};
					if (i_())
					{
						int? l_()
						{
							bool m_()
							{
								var o_ = this.Encounter_with_Nutrition_Assessment_Not_or_Mildly_Malnourished();
								var p_ = context.Operators.ListContains<Encounter>(o_, NutritionCarePlan);

								return (p_ ?? false);
							};
							bool n_()
							{
								var q_ = this.Encounter_with_Nutrition_Assessment_Status_Moderately_Or_Severely_Malnourished();
								var r_ = context.Operators.ListContains<Encounter>(q_, NutritionCarePlan);

								return (r_ ?? false);
							};
							if (m_())
							{
								return (int?)0;
							}
							else if (n_())
							{
								return (int?)1;
							}
							else
							{
								return (int?)0;
							};
						};

						return l_();
					}
					else
					{
						return (int?)0;
					};
				};

				return h_();
			}
			else
			{
				return (int?)0;
			};
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
				var e_ = context.Operators.ListContains<Encounter>(d_, QualifyingEncounter);
				var f_ = this.Encounter_with_Malnutrition_Risk_Screening_Not_at_Risk();
				var g_ = context.Operators.ListContains<Encounter>(f_, QualifyingEncounter);
				var h_ = context.Operators.And(e_, g_);
				var i_ = this.Encounter_with_Hospital_Dietitian_Referral();
				var j_ = context.Operators.ListContains<Encounter>(i_, QualifyingEncounter);
				var k_ = context.Operators.Not(j_);
				var l_ = context.Operators.And(h_, k_);

				return (l_ ?? false);
			};
			bool c_()
			{
				var m_ = this.Encounter_with_Malnutrition_Risk_Screening_or_with_Hospital_Dietitian_Referral();
				var n_ = context.Operators.ListContains<Encounter>(m_, QualifyingEncounter);
				var o_ = this.Encounter_with_Malnutrition_Risk_Screening_at_Risk();
				var p_ = context.Operators.ListContains<Encounter>(o_, QualifyingEncounter);
				var q_ = context.Operators.And(n_, p_);
				var r_ = this.Encounter_with_Hospital_Dietitian_Referral();
				var s_ = context.Operators.ListContains<Encounter>(r_, QualifyingEncounter);
				var t_ = context.Operators.Or(q_, s_);
				var u_ = this.Encounter_with_Nutrition_Assessment_Not_or_Mildly_Malnourished();
				var v_ = context.Operators.ListContains<Encounter>(u_, QualifyingEncounter);
				var w_ = context.Operators.And(t_, v_);
				var x_ = this.Encounter_with_Nutrition_Assessment_and_Identified_Status();
				var y_ = context.Operators.ListContains<Encounter>(x_, QualifyingEncounter);
				var z_ = context.Operators.Not(y_);
				var aa_ = context.Operators.Or(w_, z_);

				return (aa_ ?? false);
			};
			if (b_())
			{
				return (int?)1;
			}
			else if (c_())
			{
				return (int?)2;
			}
			else
			{
				return (int?)4;
			};
		};

		return a_();
	}

    [CqlDeclaration("Measure Observation TotalMalnutritionCompositeScore as Percentage")]
	public decimal? Measure_Observation_TotalMalnutritionCompositeScore_as_Percentage(Encounter QualifyingEncounter)
	{
		var a_ = context.Operators.ConvertIntegerToDecimal((int?)100);
		var b_ = this.Measure_Observation_TotalMalnutritionComponentsScore(QualifyingEncounter);
		var c_ = context.Operators.ConvertIntegerToDecimal(b_);
		var d_ = this.TotalMalnutritionCompositeScore_Eligible_Denominators(QualifyingEncounter);
		var e_ = context.Operators.ConvertIntegerToDecimal(d_);
		var f_ = context.Operators.Divide(c_, e_);
		var g_ = context.Operators.Multiply(a_, f_);

		return g_;
	}

}
