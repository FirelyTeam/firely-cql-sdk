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
    internal Lazy<(IEnumerable<CqlCode> codes, string display)?> __SDE_Ethnicity;
    internal Lazy<IEnumerable<(CqlConcept code, CqlInterval<CqlDateTime> period)?>> __SDE_Payer_Type;
    internal Lazy<(IEnumerable<CqlCode> codes, string display)?> __SDE_Race;
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
        __SDE_Ethnicity = new Lazy<(IEnumerable<CqlCode> codes, string display)?>(this.SDE_Ethnicity_Value);
        __SDE_Payer_Type = new Lazy<IEnumerable<(CqlConcept code, CqlInterval<CqlDateTime> period)?>>(this.SDE_Payer_Type_Value);
        __SDE_Race = new Lazy<(IEnumerable<CqlCode> codes, string display)?>(this.SDE_Race_Value);
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
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.666.5.307", default);

    [CqlDeclaration("Encounter Inpatient")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.666.5.307")]
	public CqlValueSet Encounter_Inpatient() => 
		__Encounter_Inpatient.Value;

	private CqlValueSet Ethnicity_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.114222.4.11.837", default);

    [CqlDeclaration("Ethnicity")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.114222.4.11.837")]
	public CqlValueSet Ethnicity() => 
		__Ethnicity.Value;

	private CqlValueSet Hospital_Dietitian_Referral_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1095.91", default);

    [CqlDeclaration("Hospital Dietitian Referral")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1095.91")]
	public CqlValueSet Hospital_Dietitian_Referral() => 
		__Hospital_Dietitian_Referral.Value;

	private CqlValueSet Malnutrition_Diagnosis_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1095.55", default);

    [CqlDeclaration("Malnutrition Diagnosis")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1095.55")]
	public CqlValueSet Malnutrition_Diagnosis() => 
		__Malnutrition_Diagnosis.Value;

	private CqlValueSet Malnutrition_Risk_Screening_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1095.92", default);

    [CqlDeclaration("Malnutrition Risk Screening")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1095.92")]
	public CqlValueSet Malnutrition_Risk_Screening() => 
		__Malnutrition_Risk_Screening.Value;

	private CqlValueSet Malnutrition_Screening_At_Risk_Result_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1095.38", default);

    [CqlDeclaration("Malnutrition Screening At Risk Result")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1095.38")]
	public CqlValueSet Malnutrition_Screening_At_Risk_Result() => 
		__Malnutrition_Screening_At_Risk_Result.Value;

	private CqlValueSet Malnutrition_Screening_Not_At_Risk_Result_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1095.34", default);

    [CqlDeclaration("Malnutrition Screening Not At Risk Result")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1095.34")]
	public CqlValueSet Malnutrition_Screening_Not_At_Risk_Result() => 
		__Malnutrition_Screening_Not_At_Risk_Result.Value;

	private CqlValueSet Nutrition_Assessment_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1095.21", default);

    [CqlDeclaration("Nutrition Assessment")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1095.21")]
	public CqlValueSet Nutrition_Assessment() => 
		__Nutrition_Assessment.Value;

	private CqlValueSet Nutrition_Assessment_Status_Moderately_Malnourished_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1095.44", default);

    [CqlDeclaration("Nutrition Assessment Status Moderately Malnourished")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1095.44")]
	public CqlValueSet Nutrition_Assessment_Status_Moderately_Malnourished() => 
		__Nutrition_Assessment_Status_Moderately_Malnourished.Value;

	private CqlValueSet Nutrition_Assessment_Status_Not_or_Mildly_Malnourished_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1095.48", default);

    [CqlDeclaration("Nutrition Assessment Status Not or Mildly Malnourished")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1095.48")]
	public CqlValueSet Nutrition_Assessment_Status_Not_or_Mildly_Malnourished() => 
		__Nutrition_Assessment_Status_Not_or_Mildly_Malnourished.Value;

	private CqlValueSet Nutrition_Assessment_Status_Severely_Malnourished_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1095.42", default);

    [CqlDeclaration("Nutrition Assessment Status Severely Malnourished")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1095.42")]
	public CqlValueSet Nutrition_Assessment_Status_Severely_Malnourished() => 
		__Nutrition_Assessment_Status_Severely_Malnourished.Value;

	private CqlValueSet Nutrition_Care_Plan_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1095.93", default);

    [CqlDeclaration("Nutrition Care Plan")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1095.93")]
	public CqlValueSet Nutrition_Care_Plan() => 
		__Nutrition_Care_Plan.Value;

	private CqlValueSet ONC_Administrative_Sex_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1", default);

    [CqlDeclaration("ONC Administrative Sex")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1")]
	public CqlValueSet ONC_Administrative_Sex() => 
		__ONC_Administrative_Sex.Value;

	private CqlValueSet Payer_Type_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.114222.4.11.3591", default);

    [CqlDeclaration("Payer Type")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.114222.4.11.3591")]
	public CqlValueSet Payer_Type() => 
		__Payer_Type.Value;

	private CqlValueSet Race_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.114222.4.11.836", default);

    [CqlDeclaration("Race")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.114222.4.11.836")]
	public CqlValueSet Race() => 
		__Race.Value;

	private CqlCode Birth_date_Value() => 
		new CqlCode("21112-8", "http://loinc.org", default, default);

    [CqlDeclaration("Birth date")]
	public CqlCode Birth_date() => 
		__Birth_date.Value;

	private CqlCode[] LOINC_Value()
	{
		CqlCode[] a_ = [
			new CqlCode("21112-8", "http://loinc.org", default, default),
		];

		return a_;
	}

    [CqlDeclaration("LOINC")]
	public CqlCode[] LOINC() => 
		__LOINC.Value;

	private CqlCode[] SNOMEDCT_Value()
	{
		CqlCode[] a_ = []
;

		return a_;
	}

    [CqlDeclaration("SNOMEDCT")]
	public CqlCode[] SNOMEDCT() => 
		__SNOMEDCT.Value;

	private CqlCode[] ICD10CM_Value()
	{
		CqlCode[] a_ = []
;

		return a_;
	}

    [CqlDeclaration("ICD10CM")]
	public CqlCode[] ICD10CM() => 
		__ICD10CM.Value;

	private CqlInterval<CqlDateTime> Measurement_Period_Value()
	{
		CqlDateTime a_ = context.Operators.DateTime(2025, 1, 1, 0, 0, 0, 0, default);
		CqlDateTime b_ = context.Operators.DateTime(2026, 1, 1, 0, 0, 0, 0, default);
		CqlInterval<CqlDateTime> c_ = context.Operators.Interval(a_, b_, true, false);
		object d_ = context.ResolveParameter("GlobalMalnutritionCompositeFHIR-0.1.000", "Measurement Period", c_);

		return (CqlInterval<CqlDateTime>)d_;
	}

    [CqlDeclaration("Measurement Period")]
	public CqlInterval<CqlDateTime> Measurement_Period() => 
		__Measurement_Period.Value;

	private Patient Patient_Value()
	{
		IEnumerable<Patient> a_ = context.Operators.RetrieveByValueSet<Patient>(default, default);
		Patient b_ = context.Operators.SingletonFrom<Patient>(a_);

		return b_;
	}

    [CqlDeclaration("Patient")]
	public Patient Patient() => 
		__Patient.Value;

	private (IEnumerable<CqlCode> codes, string display)? SDE_Ethnicity_Value()
	{
		(IEnumerable<CqlCode> codes, string display)? a_ = SupplementalDataElements_3_4_000.SDE_Ethnicity();

		return a_;
	}

    [CqlDeclaration("SDE Ethnicity")]
	public (IEnumerable<CqlCode> codes, string display)? SDE_Ethnicity() => 
		__SDE_Ethnicity.Value;

	private IEnumerable<(CqlConcept code, CqlInterval<CqlDateTime> period)?> SDE_Payer_Type_Value()
	{
		IEnumerable<(CqlConcept code, CqlInterval<CqlDateTime> period)?> a_ = SupplementalDataElements_3_4_000.SDE_Payer();

		return a_;
	}

    [CqlDeclaration("SDE Payer Type")]
	public IEnumerable<(CqlConcept code, CqlInterval<CqlDateTime> period)?> SDE_Payer_Type() => 
		__SDE_Payer_Type.Value;

	private (IEnumerable<CqlCode> codes, string display)? SDE_Race_Value()
	{
		(IEnumerable<CqlCode> codes, string display)? a_ = SupplementalDataElements_3_4_000.SDE_Race();

		return a_;
	}

    [CqlDeclaration("SDE Race")]
	public (IEnumerable<CqlCode> codes, string display)? SDE_Race() => 
		__SDE_Race.Value;

	private CqlCode SDE_Sex_Value()
	{
		CqlCode a_ = SupplementalDataElements_3_4_000.SDE_Sex();

		return a_;
	}

    [CqlDeclaration("SDE Sex")]
	public CqlCode SDE_Sex() => 
		__SDE_Sex.Value;

	private IEnumerable<Encounter> Qualifying_Encounter_Value()
	{
		CqlValueSet a_ = this.Encounter_Inpatient();
		IEnumerable<Encounter> b_ = context.Operators.RetrieveByValueSet<Encounter>(a_, default);
		bool? c_(Encounter EncounterInpatient)
		{
			Period e_ = EncounterInpatient?.Period;
			CqlInterval<CqlDateTime> f_ = FHIRHelpers_4_3_000.ToInterval(e_);
			CqlDateTime g_ = context.Operators.End(f_);
			CqlInterval<CqlDateTime> h_ = this.Measurement_Period();
			bool? i_ = context.Operators.In<CqlDateTime>(g_, h_, "day");
			Patient j_ = this.Patient();
			Date k_ = j_?.BirthDateElement;
			string l_ = k_?.Value;
			CqlDate m_ = context.Operators.ConvertStringToDate(l_);
			CqlInterval<CqlDateTime> o_ = FHIRHelpers_4_3_000.ToInterval(e_);
			CqlDateTime p_ = context.Operators.Start(o_);
			CqlDate q_ = context.Operators.DateFrom(p_);
			int? r_ = context.Operators.CalculateAgeAt(m_, q_, "year");
			bool? s_ = context.Operators.GreaterOrEqual(r_, 65);
			bool? t_ = context.Operators.And(i_, s_);
			CqlInterval<CqlDateTime> v_ = FHIRHelpers_4_3_000.ToInterval(e_);
			CqlDateTime w_ = context.Operators.Start(v_);
			CqlInterval<CqlDateTime> y_ = FHIRHelpers_4_3_000.ToInterval(e_);
			CqlDateTime z_ = context.Operators.End(y_);
			int? aa_ = context.Operators.DurationBetween(w_, z_, "hour");
			bool? ab_ = context.Operators.GreaterOrEqual(aa_, 24);
			bool? ac_ = context.Operators.And(t_, ab_);
			Code<Encounter.EncounterStatus> ad_ = EncounterInpatient?.StatusElement;
			Encounter.EncounterStatus? ae_ = ad_?.Value;
			Code<Encounter.EncounterStatus> af_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(ae_);
			bool? ag_ = context.Operators.Equal(af_, "finished");
			bool? ah_ = context.Operators.And(ac_, ag_);

			return ah_;
		};
		IEnumerable<Encounter> d_ = context.Operators.Where<Encounter>(b_, c_);

		return d_;
	}

    [CqlDeclaration("Qualifying Encounter")]
	public IEnumerable<Encounter> Qualifying_Encounter() => 
		__Qualifying_Encounter.Value;

	private IEnumerable<Encounter> Initial_Population_Value()
	{
		IEnumerable<Encounter> a_ = this.Qualifying_Encounter();

		return a_;
	}

    [CqlDeclaration("Initial Population")]
	public IEnumerable<Encounter> Initial_Population() => 
		__Initial_Population.Value;

	private IEnumerable<Encounter> Measure_Population_Value()
	{
		IEnumerable<Encounter> a_ = this.Initial_Population();

		return a_;
	}

    [CqlDeclaration("Measure Population")]
	public IEnumerable<Encounter> Measure_Population() => 
		__Measure_Population.Value;

	private IEnumerable<Encounter> Encounter_with_Hospital_Dietitian_Referral_Value()
	{
		IEnumerable<Encounter> a_ = this.Qualifying_Encounter();
		CqlValueSet b_ = this.Hospital_Dietitian_Referral();
		IEnumerable<Procedure> c_ = context.Operators.RetrieveByValueSet<Procedure>(b_, default);
		IEnumerable<ValueTuple<Encounter, Procedure>> d_ = context.Operators.CrossJoin<Encounter, Procedure>(a_, c_);
		(Encounter QualifyingEncounter, Procedure HospitalDietitianReferral)? e_(ValueTuple<Encounter, Procedure> _valueTuple)
		{
			(Encounter QualifyingEncounter, Procedure HospitalDietitianReferral)? k_ = (_valueTuple.Item1, _valueTuple.Item2);

			return k_;
		};
		IEnumerable<(Encounter QualifyingEncounter, Procedure HospitalDietitianReferral)?> f_ = context.Operators.Select<ValueTuple<Encounter, Procedure>, (Encounter QualifyingEncounter, Procedure HospitalDietitianReferral)?>(d_, e_);
		bool? g_((Encounter QualifyingEncounter, Procedure HospitalDietitianReferral)? tuple_blodcpfeecjfnodfofhfzlqfa)
		{
			CodeableConcept l_ = tuple_blodcpfeecjfnodfofhfzlqfa?.HospitalDietitianReferral?.Code;
			CqlConcept m_ = FHIRHelpers_4_3_000.ToConcept(l_);
			CqlValueSet n_ = this.Hospital_Dietitian_Referral();
			bool? o_ = context.Operators.ConceptInValueSet(m_ as CqlConcept, n_);
			Code<EventStatus> p_ = tuple_blodcpfeecjfnodfofhfzlqfa?.HospitalDietitianReferral?.StatusElement;
			EventStatus? q_ = p_?.Value;
			string r_ = context.Operators.Convert<string>(q_);
			string[] s_ = [
				"active",
				"completed",
				"in-progress",
			];
			bool? t_ = context.Operators.In<string>(r_, s_ as IEnumerable<string>);
			bool? u_ = context.Operators.And(o_, t_);
			DataType v_ = tuple_blodcpfeecjfnodfofhfzlqfa?.HospitalDietitianReferral?.Performed;
			object w_ = FHIRHelpers_4_3_000.ToValue(v_);
			CqlDateTime x_ = QICoreCommon_2_0_000.earliest(w_);
			CqlInterval<CqlDateTime> y_ = CQMCommon_2_0_000.hospitalizationWithObservation(tuple_blodcpfeecjfnodfofhfzlqfa?.QualifyingEncounter);
			bool? z_ = context.Operators.In<CqlDateTime>(x_, y_, default);
			bool? aa_ = context.Operators.And(u_, z_);

			return aa_;
		};
		IEnumerable<(Encounter QualifyingEncounter, Procedure HospitalDietitianReferral)?> h_ = context.Operators.Where<(Encounter QualifyingEncounter, Procedure HospitalDietitianReferral)?>(f_, g_);
		Encounter i_((Encounter QualifyingEncounter, Procedure HospitalDietitianReferral)? tuple_blodcpfeecjfnodfofhfzlqfa) => 
			tuple_blodcpfeecjfnodfofhfzlqfa?.QualifyingEncounter;
		IEnumerable<Encounter> j_ = context.Operators.Select<(Encounter QualifyingEncounter, Procedure HospitalDietitianReferral)?, Encounter>(h_, i_);

		return j_;
	}

    [CqlDeclaration("Encounter with Hospital Dietitian Referral")]
	public IEnumerable<Encounter> Encounter_with_Hospital_Dietitian_Referral() => 
		__Encounter_with_Hospital_Dietitian_Referral.Value;

	private IEnumerable<Encounter> Encounter_with_Malnutrition_Risk_Screening_Value()
	{
		IEnumerable<Encounter> a_ = this.Qualifying_Encounter();
		CqlValueSet b_ = this.Malnutrition_Risk_Screening();
		IEnumerable<Observation> c_ = context.Operators.RetrieveByValueSet<Observation>(b_, default);
		IEnumerable<ValueTuple<Encounter, Observation>> d_ = context.Operators.CrossJoin<Encounter, Observation>(a_, c_);
		(Encounter QualifyingEncounter, Observation MalnutritionRiskScreening)? e_(ValueTuple<Encounter, Observation> _valueTuple)
		{
			(Encounter QualifyingEncounter, Observation MalnutritionRiskScreening)? k_ = (_valueTuple.Item1, _valueTuple.Item2);

			return k_;
		};
		IEnumerable<(Encounter QualifyingEncounter, Observation MalnutritionRiskScreening)?> f_ = context.Operators.Select<ValueTuple<Encounter, Observation>, (Encounter QualifyingEncounter, Observation MalnutritionRiskScreening)?>(d_, e_);
		bool? g_((Encounter QualifyingEncounter, Observation MalnutritionRiskScreening)? tuple_bejjtwegpxjsnajsodybefddb)
		{
			CodeableConcept l_ = tuple_bejjtwegpxjsnajsodybefddb?.MalnutritionRiskScreening?.Code;
			CqlConcept m_ = FHIRHelpers_4_3_000.ToConcept(l_);
			CqlValueSet n_ = this.Malnutrition_Risk_Screening();
			bool? o_ = context.Operators.ConceptInValueSet(m_ as CqlConcept, n_);
			Code<ObservationStatus> p_ = tuple_bejjtwegpxjsnajsodybefddb?.MalnutritionRiskScreening?.StatusElement;
			ObservationStatus? q_ = p_?.Value;
			Code<ObservationStatus> r_ = context.Operators.Convert<Code<ObservationStatus>>(q_);
			string s_ = context.Operators.Convert<string>(r_);
			string[] t_ = [
				"final",
				"amended",
				"corrected",
			];
			bool? u_ = context.Operators.In<string>(s_, t_ as IEnumerable<string>);
			bool? v_ = context.Operators.And(o_, u_);
			CqlInterval<CqlDateTime> w_ = CQMCommon_2_0_000.hospitalizationWithObservation(tuple_bejjtwegpxjsnajsodybefddb?.QualifyingEncounter);
			DataType x_ = tuple_bejjtwegpxjsnajsodybefddb?.MalnutritionRiskScreening?.Effective;
			object y_ = FHIRHelpers_4_3_000.ToValue(x_);
			CqlInterval<CqlDateTime> z_ = QICoreCommon_2_0_000.toInterval(y_);
			bool? aa_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(w_, z_, default);
			bool? ab_ = context.Operators.And(v_, aa_);
			DataType ac_ = tuple_bejjtwegpxjsnajsodybefddb?.MalnutritionRiskScreening?.Value;
			object ad_ = FHIRHelpers_4_3_000.ToValue(ac_);
			CqlConcept ae_ = ad_ switch { null => null , CqlConcept a => a/* , CqlQuantity => ???, string => ???, bool => ???, int => ???, CqlInterval<CqlQuantity> => ???, CqlRatio => ???, SampledData => ???, CqlTime => ???, CqlDateTime => ???, CqlInterval<CqlDateTime> => ??? */, _ => throw new System.Diagnostics.UnreachableException() };
			CqlValueSet af_ = this.Malnutrition_Screening_Not_At_Risk_Result();
			bool? ag_ = context.Operators.ConceptInValueSet(ae_, af_);
			object ai_ = FHIRHelpers_4_3_000.ToValue(ac_);
			CqlValueSet ak_ = this.Malnutrition_Screening_At_Risk_Result();
			bool? al_ = context.Operators.ConceptInValueSet(ae_, ak_);
			bool? am_ = context.Operators.Or(ag_, al_);
			bool? an_ = context.Operators.And(ab_, am_);

			return an_;
		};
		IEnumerable<(Encounter QualifyingEncounter, Observation MalnutritionRiskScreening)?> h_ = context.Operators.Where<(Encounter QualifyingEncounter, Observation MalnutritionRiskScreening)?>(f_, g_);
		Encounter i_((Encounter QualifyingEncounter, Observation MalnutritionRiskScreening)? tuple_bejjtwegpxjsnajsodybefddb) => 
			tuple_bejjtwegpxjsnajsodybefddb?.QualifyingEncounter;
		IEnumerable<Encounter> j_ = context.Operators.Select<(Encounter QualifyingEncounter, Observation MalnutritionRiskScreening)?, Encounter>(h_, i_);

		return j_;
	}

    [CqlDeclaration("Encounter with Malnutrition Risk Screening")]
	public IEnumerable<Encounter> Encounter_with_Malnutrition_Risk_Screening() => 
		__Encounter_with_Malnutrition_Risk_Screening.Value;

	private IEnumerable<Encounter> Encounter_with_Malnutrition_Risk_Screening_or_with_Hospital_Dietitian_Referral_Value()
	{
		IEnumerable<Encounter> a_ = this.Qualifying_Encounter();
		bool? b_(Encounter QualifyingEncounter)
		{
			IEnumerable<Encounter> f_ = this.Encounter_with_Malnutrition_Risk_Screening();
			bool? g_ = context.Operators.Contains<Encounter>(f_, QualifyingEncounter);
			IEnumerable<Encounter> h_ = this.Encounter_with_Hospital_Dietitian_Referral();
			bool? i_ = context.Operators.Contains<Encounter>(h_, QualifyingEncounter);
			bool? j_ = context.Operators.Or(g_, i_);

			return j_;
		};
		IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);
		Encounter d_(Encounter QualifyingEncounter) => 
			QualifyingEncounter;
		IEnumerable<Encounter> e_ = context.Operators.Select<Encounter, Encounter>(c_, d_);

		return e_;
	}

    [CqlDeclaration("Encounter with Malnutrition Risk Screening or with Hospital Dietitian Referral")]
	public IEnumerable<Encounter> Encounter_with_Malnutrition_Risk_Screening_or_with_Hospital_Dietitian_Referral() => 
		__Encounter_with_Malnutrition_Risk_Screening_or_with_Hospital_Dietitian_Referral.Value;

	private IEnumerable<Encounter> Encounter_with_Malnutrition_Risk_Screening_Not_at_Risk_Value()
	{
		IEnumerable<Encounter> a_ = this.Qualifying_Encounter();
		CqlValueSet b_ = this.Malnutrition_Risk_Screening();
		IEnumerable<Observation> c_ = context.Operators.RetrieveByValueSet<Observation>(b_, default);
		IEnumerable<ValueTuple<Encounter, Observation>> d_ = context.Operators.CrossJoin<Encounter, Observation>(a_, c_);
		(Encounter QualifyingEncounter, Observation MalnutritionRiskScreening)? e_(ValueTuple<Encounter, Observation> _valueTuple)
		{
			(Encounter QualifyingEncounter, Observation MalnutritionRiskScreening)? k_ = (_valueTuple.Item1, _valueTuple.Item2);

			return k_;
		};
		IEnumerable<(Encounter QualifyingEncounter, Observation MalnutritionRiskScreening)?> f_ = context.Operators.Select<ValueTuple<Encounter, Observation>, (Encounter QualifyingEncounter, Observation MalnutritionRiskScreening)?>(d_, e_);
		bool? g_((Encounter QualifyingEncounter, Observation MalnutritionRiskScreening)? tuple_bejjtwegpxjsnajsodybefddb)
		{
			CodeableConcept l_ = tuple_bejjtwegpxjsnajsodybefddb?.MalnutritionRiskScreening?.Code;
			CqlConcept m_ = FHIRHelpers_4_3_000.ToConcept(l_);
			CqlValueSet n_ = this.Malnutrition_Risk_Screening();
			bool? o_ = context.Operators.ConceptInValueSet(m_ as CqlConcept, n_);
			Code<ObservationStatus> p_ = tuple_bejjtwegpxjsnajsodybefddb?.MalnutritionRiskScreening?.StatusElement;
			ObservationStatus? q_ = p_?.Value;
			Code<ObservationStatus> r_ = context.Operators.Convert<Code<ObservationStatus>>(q_);
			string s_ = context.Operators.Convert<string>(r_);
			string[] t_ = [
				"final",
				"amended",
				"corrected",
			];
			bool? u_ = context.Operators.In<string>(s_, t_ as IEnumerable<string>);
			bool? v_ = context.Operators.And(o_, u_);
			CqlInterval<CqlDateTime> w_ = CQMCommon_2_0_000.hospitalizationWithObservation(tuple_bejjtwegpxjsnajsodybefddb?.QualifyingEncounter);
			DataType x_ = tuple_bejjtwegpxjsnajsodybefddb?.MalnutritionRiskScreening?.Effective;
			object y_ = FHIRHelpers_4_3_000.ToValue(x_);
			CqlInterval<CqlDateTime> z_ = QICoreCommon_2_0_000.toInterval(y_);
			bool? aa_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(w_, z_, default);
			bool? ab_ = context.Operators.And(v_, aa_);
			DataType ac_ = tuple_bejjtwegpxjsnajsodybefddb?.MalnutritionRiskScreening?.Value;
			object ad_ = FHIRHelpers_4_3_000.ToValue(ac_);
			CqlConcept ae_ = ad_ switch { null => null , CqlConcept a => a/* , CqlQuantity => ???, string => ???, bool => ???, int => ???, CqlInterval<CqlQuantity> => ???, CqlRatio => ???, SampledData => ???, CqlTime => ???, CqlDateTime => ???, CqlInterval<CqlDateTime> => ??? */, _ => throw new System.Diagnostics.UnreachableException() };
			CqlValueSet af_ = this.Malnutrition_Screening_Not_At_Risk_Result();
			bool? ag_ = context.Operators.ConceptInValueSet(ae_, af_);
			bool? ah_ = context.Operators.And(ab_, ag_);

			return ah_;
		};
		IEnumerable<(Encounter QualifyingEncounter, Observation MalnutritionRiskScreening)?> h_ = context.Operators.Where<(Encounter QualifyingEncounter, Observation MalnutritionRiskScreening)?>(f_, g_);
		Encounter i_((Encounter QualifyingEncounter, Observation MalnutritionRiskScreening)? tuple_bejjtwegpxjsnajsodybefddb) => 
			tuple_bejjtwegpxjsnajsodybefddb?.QualifyingEncounter;
		IEnumerable<Encounter> j_ = context.Operators.Select<(Encounter QualifyingEncounter, Observation MalnutritionRiskScreening)?, Encounter>(h_, i_);

		return j_;
	}

    [CqlDeclaration("Encounter with Malnutrition Risk Screening Not at Risk")]
	public IEnumerable<Encounter> Encounter_with_Malnutrition_Risk_Screening_Not_at_Risk() => 
		__Encounter_with_Malnutrition_Risk_Screening_Not_at_Risk.Value;

	private IEnumerable<Encounter> Encounter_with_Malnutrition_Not_at_Risk_Screening_and_without_Hospital_Dietitian_Referral_Value()
	{
		IEnumerable<Encounter> a_ = this.Qualifying_Encounter();
		bool? b_(Encounter QualifyingEncounter)
		{
			IEnumerable<Encounter> f_ = this.Encounter_with_Malnutrition_Risk_Screening_Not_at_Risk();
			bool? g_ = context.Operators.Contains<Encounter>(f_, QualifyingEncounter);
			IEnumerable<Encounter> h_ = this.Encounter_with_Hospital_Dietitian_Referral();
			bool? i_ = context.Operators.Exists<Encounter>(h_);
			bool? j_ = context.Operators.Not(i_);
			bool? k_ = context.Operators.And(g_, j_);

			return k_;
		};
		IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);
		Encounter d_(Encounter QualifyingEncounter) => 
			QualifyingEncounter;
		IEnumerable<Encounter> e_ = context.Operators.Select<Encounter, Encounter>(c_, d_);

		return e_;
	}

    [CqlDeclaration("Encounter with Malnutrition Not at Risk Screening and without Hospital Dietitian Referral")]
	public IEnumerable<Encounter> Encounter_with_Malnutrition_Not_at_Risk_Screening_and_without_Hospital_Dietitian_Referral() => 
		__Encounter_with_Malnutrition_Not_at_Risk_Screening_and_without_Hospital_Dietitian_Referral.Value;

	private IEnumerable<Encounter> Encounter_with_Malnutrition_Risk_Screening_at_Risk_Value()
	{
		IEnumerable<Encounter> a_ = this.Qualifying_Encounter();
		CqlValueSet b_ = this.Malnutrition_Risk_Screening();
		IEnumerable<Observation> c_ = context.Operators.RetrieveByValueSet<Observation>(b_, default);
		IEnumerable<ValueTuple<Encounter, Observation>> d_ = context.Operators.CrossJoin<Encounter, Observation>(a_, c_);
		(Encounter QualifyingEncounter, Observation MalnutritionRiskScreening)? e_(ValueTuple<Encounter, Observation> _valueTuple)
		{
			(Encounter QualifyingEncounter, Observation MalnutritionRiskScreening)? k_ = (_valueTuple.Item1, _valueTuple.Item2);

			return k_;
		};
		IEnumerable<(Encounter QualifyingEncounter, Observation MalnutritionRiskScreening)?> f_ = context.Operators.Select<ValueTuple<Encounter, Observation>, (Encounter QualifyingEncounter, Observation MalnutritionRiskScreening)?>(d_, e_);
		bool? g_((Encounter QualifyingEncounter, Observation MalnutritionRiskScreening)? tuple_bejjtwegpxjsnajsodybefddb)
		{
			CodeableConcept l_ = tuple_bejjtwegpxjsnajsodybefddb?.MalnutritionRiskScreening?.Code;
			CqlConcept m_ = FHIRHelpers_4_3_000.ToConcept(l_);
			CqlValueSet n_ = this.Malnutrition_Risk_Screening();
			bool? o_ = context.Operators.ConceptInValueSet(m_ as CqlConcept, n_);
			Code<ObservationStatus> p_ = tuple_bejjtwegpxjsnajsodybefddb?.MalnutritionRiskScreening?.StatusElement;
			ObservationStatus? q_ = p_?.Value;
			Code<ObservationStatus> r_ = context.Operators.Convert<Code<ObservationStatus>>(q_);
			string s_ = context.Operators.Convert<string>(r_);
			string[] t_ = [
				"final",
				"amended",
				"corrected",
			];
			bool? u_ = context.Operators.In<string>(s_, t_ as IEnumerable<string>);
			bool? v_ = context.Operators.And(o_, u_);
			CqlInterval<CqlDateTime> w_ = CQMCommon_2_0_000.hospitalizationWithObservation(tuple_bejjtwegpxjsnajsodybefddb?.QualifyingEncounter);
			DataType x_ = tuple_bejjtwegpxjsnajsodybefddb?.MalnutritionRiskScreening?.Effective;
			object y_ = FHIRHelpers_4_3_000.ToValue(x_);
			CqlInterval<CqlDateTime> z_ = QICoreCommon_2_0_000.toInterval(y_);
			bool? aa_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(w_, z_, default);
			bool? ab_ = context.Operators.And(v_, aa_);
			DataType ac_ = tuple_bejjtwegpxjsnajsodybefddb?.MalnutritionRiskScreening?.Value;
			object ad_ = FHIRHelpers_4_3_000.ToValue(ac_);
			CqlConcept ae_ = ad_ switch { null => null , CqlConcept a => a/* , CqlQuantity => ???, string => ???, bool => ???, int => ???, CqlInterval<CqlQuantity> => ???, CqlRatio => ???, SampledData => ???, CqlTime => ???, CqlDateTime => ???, CqlInterval<CqlDateTime> => ??? */, _ => throw new System.Diagnostics.UnreachableException() };
			CqlValueSet af_ = this.Malnutrition_Screening_At_Risk_Result();
			bool? ag_ = context.Operators.ConceptInValueSet(ae_, af_);
			bool? ah_ = context.Operators.And(ab_, ag_);

			return ah_;
		};
		IEnumerable<(Encounter QualifyingEncounter, Observation MalnutritionRiskScreening)?> h_ = context.Operators.Where<(Encounter QualifyingEncounter, Observation MalnutritionRiskScreening)?>(f_, g_);
		Encounter i_((Encounter QualifyingEncounter, Observation MalnutritionRiskScreening)? tuple_bejjtwegpxjsnajsodybefddb) => 
			tuple_bejjtwegpxjsnajsodybefddb?.QualifyingEncounter;
		IEnumerable<Encounter> j_ = context.Operators.Select<(Encounter QualifyingEncounter, Observation MalnutritionRiskScreening)?, Encounter>(h_, i_);

		return j_;
	}

    [CqlDeclaration("Encounter with Malnutrition Risk Screening at Risk")]
	public IEnumerable<Encounter> Encounter_with_Malnutrition_Risk_Screening_at_Risk() => 
		__Encounter_with_Malnutrition_Risk_Screening_at_Risk.Value;

	private IEnumerable<Encounter> Encounter_with_Malnutrition_Risk_Screening_at_Risk_or_with_Hospital_Dietitian_Referral_Value()
	{
		IEnumerable<Encounter> a_ = this.Qualifying_Encounter();
		bool? b_(Encounter QualifyingEncounter)
		{
			IEnumerable<Encounter> f_ = this.Encounter_with_Malnutrition_Risk_Screening_at_Risk();
			bool? g_ = context.Operators.Contains<Encounter>(f_, QualifyingEncounter);
			IEnumerable<Encounter> h_ = this.Encounter_with_Hospital_Dietitian_Referral();
			bool? i_ = context.Operators.Contains<Encounter>(h_, QualifyingEncounter);
			bool? j_ = context.Operators.Or(g_, i_);

			return j_;
		};
		IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);
		Encounter d_(Encounter QualifyingEncounter) => 
			QualifyingEncounter;
		IEnumerable<Encounter> e_ = context.Operators.Select<Encounter, Encounter>(c_, d_);

		return e_;
	}

    [CqlDeclaration("Encounter with Malnutrition Risk Screening at Risk or with Hospital Dietitian Referral")]
	public IEnumerable<Encounter> Encounter_with_Malnutrition_Risk_Screening_at_Risk_or_with_Hospital_Dietitian_Referral() => 
		__Encounter_with_Malnutrition_Risk_Screening_at_Risk_or_with_Hospital_Dietitian_Referral.Value;

	private IEnumerable<Encounter> Encounter_with_Nutrition_Assessment_and_Identified_Status_Value()
	{
		IEnumerable<Encounter> a_ = this.Qualifying_Encounter();
		CqlValueSet b_ = this.Nutrition_Assessment();
		IEnumerable<Observation> c_ = context.Operators.RetrieveByValueSet<Observation>(b_, default);
		IEnumerable<ValueTuple<Encounter, Observation>> d_ = context.Operators.CrossJoin<Encounter, Observation>(a_, c_);
		(Encounter QualifyingEncounter, Observation NutritionAssessment)? e_(ValueTuple<Encounter, Observation> _valueTuple)
		{
			(Encounter QualifyingEncounter, Observation NutritionAssessment)? k_ = (_valueTuple.Item1, _valueTuple.Item2);

			return k_;
		};
		IEnumerable<(Encounter QualifyingEncounter, Observation NutritionAssessment)?> f_ = context.Operators.Select<ValueTuple<Encounter, Observation>, (Encounter QualifyingEncounter, Observation NutritionAssessment)?>(d_, e_);
		bool? g_((Encounter QualifyingEncounter, Observation NutritionAssessment)? tuple_hhhypfjvjujitmizocefugcne)
		{
			CodeableConcept l_ = tuple_hhhypfjvjujitmizocefugcne?.NutritionAssessment?.Code;
			CqlConcept m_ = FHIRHelpers_4_3_000.ToConcept(l_);
			CqlValueSet n_ = this.Nutrition_Assessment();
			bool? o_ = context.Operators.ConceptInValueSet(m_ as CqlConcept, n_);
			Code<ObservationStatus> p_ = tuple_hhhypfjvjujitmizocefugcne?.NutritionAssessment?.StatusElement;
			ObservationStatus? q_ = p_?.Value;
			Code<ObservationStatus> r_ = context.Operators.Convert<Code<ObservationStatus>>(q_);
			string s_ = context.Operators.Convert<string>(r_);
			string[] t_ = [
				"final",
				"amended",
				"corrected",
			];
			bool? u_ = context.Operators.In<string>(s_, t_ as IEnumerable<string>);
			bool? v_ = context.Operators.And(o_, u_);
			CqlInterval<CqlDateTime> w_ = CQMCommon_2_0_000.hospitalizationWithObservation(tuple_hhhypfjvjujitmizocefugcne?.QualifyingEncounter);
			DataType x_ = tuple_hhhypfjvjujitmizocefugcne?.NutritionAssessment?.Effective;
			object y_ = FHIRHelpers_4_3_000.ToValue(x_);
			CqlInterval<CqlDateTime> z_ = QICoreCommon_2_0_000.toInterval(y_);
			bool? aa_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(w_, z_, default);
			bool? ab_ = context.Operators.And(v_, aa_);
			DataType ac_ = tuple_hhhypfjvjujitmizocefugcne?.NutritionAssessment?.Value;
			object ad_ = FHIRHelpers_4_3_000.ToValue(ac_);
			CqlConcept ae_ = ad_ switch { null => null , CqlConcept a => a/* , CqlQuantity => ???, string => ???, bool => ???, int => ???, CqlInterval<CqlQuantity> => ???, CqlRatio => ???, SampledData => ???, CqlTime => ???, CqlDateTime => ???, CqlInterval<CqlDateTime> => ??? */, _ => throw new System.Diagnostics.UnreachableException() };
			CqlValueSet af_ = this.Nutrition_Assessment_Status_Moderately_Malnourished();
			bool? ag_ = context.Operators.ConceptInValueSet(ae_, af_);
			object ai_ = FHIRHelpers_4_3_000.ToValue(ac_);
			CqlValueSet ak_ = this.Nutrition_Assessment_Status_Not_or_Mildly_Malnourished();
			bool? al_ = context.Operators.ConceptInValueSet(ae_, ak_);
			bool? am_ = context.Operators.Or(ag_, al_);
			object ao_ = FHIRHelpers_4_3_000.ToValue(ac_);
			CqlValueSet aq_ = this.Nutrition_Assessment_Status_Severely_Malnourished();
			bool? ar_ = context.Operators.ConceptInValueSet(ae_, aq_);
			bool? as_ = context.Operators.Or(am_, ar_);
			bool? at_ = context.Operators.And(ab_, as_);

			return at_;
		};
		IEnumerable<(Encounter QualifyingEncounter, Observation NutritionAssessment)?> h_ = context.Operators.Where<(Encounter QualifyingEncounter, Observation NutritionAssessment)?>(f_, g_);
		Encounter i_((Encounter QualifyingEncounter, Observation NutritionAssessment)? tuple_hhhypfjvjujitmizocefugcne) => 
			tuple_hhhypfjvjujitmizocefugcne?.QualifyingEncounter;
		IEnumerable<Encounter> j_ = context.Operators.Select<(Encounter QualifyingEncounter, Observation NutritionAssessment)?, Encounter>(h_, i_);

		return j_;
	}

    [CqlDeclaration("Encounter with Nutrition Assessment and Identified Status")]
	public IEnumerable<Encounter> Encounter_with_Nutrition_Assessment_and_Identified_Status() => 
		__Encounter_with_Nutrition_Assessment_and_Identified_Status.Value;

	private IEnumerable<Encounter> Encounter_with_Nutrition_Assessment_Status_Moderately_Or_Severely_Malnourished_Value()
	{
		IEnumerable<Encounter> a_ = this.Qualifying_Encounter();
		CqlValueSet b_ = this.Nutrition_Assessment();
		IEnumerable<Observation> c_ = context.Operators.RetrieveByValueSet<Observation>(b_, default);
		IEnumerable<ValueTuple<Encounter, Observation>> d_ = context.Operators.CrossJoin<Encounter, Observation>(a_, c_);
		(Encounter QualifyingEncounter, Observation NutritionAssessment)? e_(ValueTuple<Encounter, Observation> _valueTuple)
		{
			(Encounter QualifyingEncounter, Observation NutritionAssessment)? k_ = (_valueTuple.Item1, _valueTuple.Item2);

			return k_;
		};
		IEnumerable<(Encounter QualifyingEncounter, Observation NutritionAssessment)?> f_ = context.Operators.Select<ValueTuple<Encounter, Observation>, (Encounter QualifyingEncounter, Observation NutritionAssessment)?>(d_, e_);
		bool? g_((Encounter QualifyingEncounter, Observation NutritionAssessment)? tuple_hhhypfjvjujitmizocefugcne)
		{
			CodeableConcept l_ = tuple_hhhypfjvjujitmizocefugcne?.NutritionAssessment?.Code;
			CqlConcept m_ = FHIRHelpers_4_3_000.ToConcept(l_);
			CqlValueSet n_ = this.Nutrition_Assessment();
			bool? o_ = context.Operators.ConceptInValueSet(m_ as CqlConcept, n_);
			Code<ObservationStatus> p_ = tuple_hhhypfjvjujitmizocefugcne?.NutritionAssessment?.StatusElement;
			ObservationStatus? q_ = p_?.Value;
			Code<ObservationStatus> r_ = context.Operators.Convert<Code<ObservationStatus>>(q_);
			string s_ = context.Operators.Convert<string>(r_);
			string[] t_ = [
				"final",
				"amended",
				"corrected",
			];
			bool? u_ = context.Operators.In<string>(s_, t_ as IEnumerable<string>);
			bool? v_ = context.Operators.And(o_, u_);
			CqlInterval<CqlDateTime> w_ = CQMCommon_2_0_000.hospitalizationWithObservation(tuple_hhhypfjvjujitmizocefugcne?.QualifyingEncounter);
			DataType x_ = tuple_hhhypfjvjujitmizocefugcne?.NutritionAssessment?.Effective;
			object y_ = FHIRHelpers_4_3_000.ToValue(x_);
			CqlInterval<CqlDateTime> z_ = QICoreCommon_2_0_000.toInterval(y_);
			bool? aa_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(w_, z_, default);
			bool? ab_ = context.Operators.And(v_, aa_);
			DataType ac_ = tuple_hhhypfjvjujitmizocefugcne?.NutritionAssessment?.Value;
			object ad_ = FHIRHelpers_4_3_000.ToValue(ac_);
			CqlConcept ae_ = ad_ switch { null => null , CqlConcept a => a/* , CqlQuantity => ???, string => ???, bool => ???, int => ???, CqlInterval<CqlQuantity> => ???, CqlRatio => ???, SampledData => ???, CqlTime => ???, CqlDateTime => ???, CqlInterval<CqlDateTime> => ??? */, _ => throw new System.Diagnostics.UnreachableException() };
			CqlValueSet af_ = this.Nutrition_Assessment_Status_Moderately_Malnourished();
			bool? ag_ = context.Operators.ConceptInValueSet(ae_, af_);
			object ai_ = FHIRHelpers_4_3_000.ToValue(ac_);
			CqlValueSet ak_ = this.Nutrition_Assessment_Status_Severely_Malnourished();
			bool? al_ = context.Operators.ConceptInValueSet(ae_, ak_);
			bool? am_ = context.Operators.Or(ag_, al_);
			bool? an_ = context.Operators.And(ab_, am_);

			return an_;
		};
		IEnumerable<(Encounter QualifyingEncounter, Observation NutritionAssessment)?> h_ = context.Operators.Where<(Encounter QualifyingEncounter, Observation NutritionAssessment)?>(f_, g_);
		Encounter i_((Encounter QualifyingEncounter, Observation NutritionAssessment)? tuple_hhhypfjvjujitmizocefugcne) => 
			tuple_hhhypfjvjujitmizocefugcne?.QualifyingEncounter;
		IEnumerable<Encounter> j_ = context.Operators.Select<(Encounter QualifyingEncounter, Observation NutritionAssessment)?, Encounter>(h_, i_);

		return j_;
	}

    [CqlDeclaration("Encounter with Nutrition Assessment Status Moderately Or Severely Malnourished")]
	public IEnumerable<Encounter> Encounter_with_Nutrition_Assessment_Status_Moderately_Or_Severely_Malnourished() => 
		__Encounter_with_Nutrition_Assessment_Status_Moderately_Or_Severely_Malnourished.Value;

	private IEnumerable<Encounter> Encounter_with_Nutrition_Assessment_Not_or_Mildly_Malnourished_Value()
	{
		IEnumerable<Encounter> a_ = this.Qualifying_Encounter();
		CqlValueSet b_ = this.Nutrition_Assessment();
		IEnumerable<Observation> c_ = context.Operators.RetrieveByValueSet<Observation>(b_, default);
		IEnumerable<ValueTuple<Encounter, Observation>> d_ = context.Operators.CrossJoin<Encounter, Observation>(a_, c_);
		(Encounter QualifyingEncounter, Observation NutritionAssessment)? e_(ValueTuple<Encounter, Observation> _valueTuple)
		{
			(Encounter QualifyingEncounter, Observation NutritionAssessment)? k_ = (_valueTuple.Item1, _valueTuple.Item2);

			return k_;
		};
		IEnumerable<(Encounter QualifyingEncounter, Observation NutritionAssessment)?> f_ = context.Operators.Select<ValueTuple<Encounter, Observation>, (Encounter QualifyingEncounter, Observation NutritionAssessment)?>(d_, e_);
		bool? g_((Encounter QualifyingEncounter, Observation NutritionAssessment)? tuple_hhhypfjvjujitmizocefugcne)
		{
			CodeableConcept l_ = tuple_hhhypfjvjujitmizocefugcne?.NutritionAssessment?.Code;
			CqlConcept m_ = FHIRHelpers_4_3_000.ToConcept(l_);
			CqlValueSet n_ = this.Nutrition_Assessment();
			bool? o_ = context.Operators.ConceptInValueSet(m_ as CqlConcept, n_);
			Code<ObservationStatus> p_ = tuple_hhhypfjvjujitmizocefugcne?.NutritionAssessment?.StatusElement;
			ObservationStatus? q_ = p_?.Value;
			Code<ObservationStatus> r_ = context.Operators.Convert<Code<ObservationStatus>>(q_);
			string s_ = context.Operators.Convert<string>(r_);
			string[] t_ = [
				"final",
				"amended",
				"corrected",
			];
			bool? u_ = context.Operators.In<string>(s_, t_ as IEnumerable<string>);
			bool? v_ = context.Operators.And(o_, u_);
			CqlInterval<CqlDateTime> w_ = CQMCommon_2_0_000.hospitalizationWithObservation(tuple_hhhypfjvjujitmizocefugcne?.QualifyingEncounter);
			DataType x_ = tuple_hhhypfjvjujitmizocefugcne?.NutritionAssessment?.Effective;
			object y_ = FHIRHelpers_4_3_000.ToValue(x_);
			CqlInterval<CqlDateTime> z_ = QICoreCommon_2_0_000.toInterval(y_);
			bool? aa_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(w_, z_, default);
			bool? ab_ = context.Operators.And(v_, aa_);
			DataType ac_ = tuple_hhhypfjvjujitmizocefugcne?.NutritionAssessment?.Value;
			object ad_ = FHIRHelpers_4_3_000.ToValue(ac_);
			CqlConcept ae_ = ad_ switch { null => null , CqlConcept a => a/* , CqlQuantity => ???, string => ???, bool => ???, int => ???, CqlInterval<CqlQuantity> => ???, CqlRatio => ???, SampledData => ???, CqlTime => ???, CqlDateTime => ???, CqlInterval<CqlDateTime> => ??? */, _ => throw new System.Diagnostics.UnreachableException() };
			CqlValueSet af_ = this.Nutrition_Assessment_Status_Not_or_Mildly_Malnourished();
			bool? ag_ = context.Operators.ConceptInValueSet(ae_, af_);
			bool? ah_ = context.Operators.And(ab_, ag_);

			return ah_;
		};
		IEnumerable<(Encounter QualifyingEncounter, Observation NutritionAssessment)?> h_ = context.Operators.Where<(Encounter QualifyingEncounter, Observation NutritionAssessment)?>(f_, g_);
		Encounter i_((Encounter QualifyingEncounter, Observation NutritionAssessment)? tuple_hhhypfjvjujitmizocefugcne) => 
			tuple_hhhypfjvjujitmizocefugcne?.QualifyingEncounter;
		IEnumerable<Encounter> j_ = context.Operators.Select<(Encounter QualifyingEncounter, Observation NutritionAssessment)?, Encounter>(h_, i_);

		return j_;
	}

    [CqlDeclaration("Encounter with Nutrition Assessment Not or Mildly Malnourished")]
	public IEnumerable<Encounter> Encounter_with_Nutrition_Assessment_Not_or_Mildly_Malnourished() => 
		__Encounter_with_Nutrition_Assessment_Not_or_Mildly_Malnourished.Value;

	private IEnumerable<Encounter> Encounter_with_Malnutrition_Diagnosis_Value()
	{
		IEnumerable<Encounter> a_ = this.Qualifying_Encounter();
		CqlValueSet b_ = this.Malnutrition_Diagnosis();
		IEnumerable<Condition> c_ = context.Operators.RetrieveByValueSet<Condition>(b_, default);
		IEnumerable<ValueTuple<Encounter, Condition>> d_ = context.Operators.CrossJoin<Encounter, Condition>(a_, c_);
		(Encounter QualifyingEncounter, Condition MalnutritionDiagnosis)? e_(ValueTuple<Encounter, Condition> _valueTuple)
		{
			(Encounter QualifyingEncounter, Condition MalnutritionDiagnosis)? k_ = (_valueTuple.Item1, _valueTuple.Item2);

			return k_;
		};
		IEnumerable<(Encounter QualifyingEncounter, Condition MalnutritionDiagnosis)?> f_ = context.Operators.Select<ValueTuple<Encounter, Condition>, (Encounter QualifyingEncounter, Condition MalnutritionDiagnosis)?>(d_, e_);
		bool? g_((Encounter QualifyingEncounter, Condition MalnutritionDiagnosis)? tuple_gsigyornrkjgexbhejviwntmn)
		{
			CodeableConcept l_ = tuple_gsigyornrkjgexbhejviwntmn?.MalnutritionDiagnosis?.Code;
			CqlConcept m_ = FHIRHelpers_4_3_000.ToConcept(l_);
			CqlValueSet n_ = this.Malnutrition_Diagnosis();
			bool? o_ = context.Operators.ConceptInValueSet(m_ as CqlConcept, n_);
			CqlInterval<CqlDateTime> p_ = QICoreCommon_2_0_000.prevalenceInterval(tuple_gsigyornrkjgexbhejviwntmn?.MalnutritionDiagnosis);
			CqlDateTime q_ = context.Operators.Start(p_);
			CqlInterval<CqlDateTime> r_ = CQMCommon_2_0_000.hospitalizationWithObservation(tuple_gsigyornrkjgexbhejviwntmn?.QualifyingEncounter);
			bool? s_ = context.Operators.In<CqlDateTime>(q_, r_, default);
			bool? t_ = context.Operators.And(o_, s_);

			return t_;
		};
		IEnumerable<(Encounter QualifyingEncounter, Condition MalnutritionDiagnosis)?> h_ = context.Operators.Where<(Encounter QualifyingEncounter, Condition MalnutritionDiagnosis)?>(f_, g_);
		Encounter i_((Encounter QualifyingEncounter, Condition MalnutritionDiagnosis)? tuple_gsigyornrkjgexbhejviwntmn) => 
			tuple_gsigyornrkjgexbhejviwntmn?.QualifyingEncounter;
		IEnumerable<Encounter> j_ = context.Operators.Select<(Encounter QualifyingEncounter, Condition MalnutritionDiagnosis)?, Encounter>(h_, i_);

		return j_;
	}

    [CqlDeclaration("Encounter with Malnutrition Diagnosis")]
	public IEnumerable<Encounter> Encounter_with_Malnutrition_Diagnosis() => 
		__Encounter_with_Malnutrition_Diagnosis.Value;

	private IEnumerable<Encounter> Encounter_with_Nutrition_Care_Plan_Value()
	{
		IEnumerable<Encounter> a_ = this.Qualifying_Encounter();
		CqlValueSet b_ = this.Nutrition_Care_Plan();
		IEnumerable<Procedure> c_ = context.Operators.RetrieveByValueSet<Procedure>(b_, default);
		IEnumerable<ValueTuple<Encounter, Procedure>> d_ = context.Operators.CrossJoin<Encounter, Procedure>(a_, c_);
		(Encounter QualifyingEncounter, Procedure NutritionCarePlan)? e_(ValueTuple<Encounter, Procedure> _valueTuple)
		{
			(Encounter QualifyingEncounter, Procedure NutritionCarePlan)? k_ = (_valueTuple.Item1, _valueTuple.Item2);

			return k_;
		};
		IEnumerable<(Encounter QualifyingEncounter, Procedure NutritionCarePlan)?> f_ = context.Operators.Select<ValueTuple<Encounter, Procedure>, (Encounter QualifyingEncounter, Procedure NutritionCarePlan)?>(d_, e_);
		bool? g_((Encounter QualifyingEncounter, Procedure NutritionCarePlan)? tuple_igutmwhaufjcwzmijcgjeysm)
		{
			CodeableConcept l_ = tuple_igutmwhaufjcwzmijcgjeysm?.NutritionCarePlan?.Code;
			CqlConcept m_ = FHIRHelpers_4_3_000.ToConcept(l_);
			CqlValueSet n_ = this.Nutrition_Care_Plan();
			bool? o_ = context.Operators.ConceptInValueSet(m_ as CqlConcept, n_);
			Code<EventStatus> p_ = tuple_igutmwhaufjcwzmijcgjeysm?.NutritionCarePlan?.StatusElement;
			EventStatus? q_ = p_?.Value;
			string r_ = context.Operators.Convert<string>(q_);
			string[] s_ = [
				"completed",
				"in-progress",
			];
			bool? t_ = context.Operators.In<string>(r_, s_ as IEnumerable<string>);
			bool? u_ = context.Operators.And(o_, t_);
			DataType v_ = tuple_igutmwhaufjcwzmijcgjeysm?.NutritionCarePlan?.Performed;
			object w_ = FHIRHelpers_4_3_000.ToValue(v_);
			CqlDateTime x_ = QICoreCommon_2_0_000.earliest(w_);
			CqlInterval<CqlDateTime> y_ = CQMCommon_2_0_000.hospitalizationWithObservation(tuple_igutmwhaufjcwzmijcgjeysm?.QualifyingEncounter);
			bool? z_ = context.Operators.In<CqlDateTime>(x_, y_, default);
			bool? aa_ = context.Operators.And(u_, z_);

			return aa_;
		};
		IEnumerable<(Encounter QualifyingEncounter, Procedure NutritionCarePlan)?> h_ = context.Operators.Where<(Encounter QualifyingEncounter, Procedure NutritionCarePlan)?>(f_, g_);
		Encounter i_((Encounter QualifyingEncounter, Procedure NutritionCarePlan)? tuple_igutmwhaufjcwzmijcgjeysm) => 
			tuple_igutmwhaufjcwzmijcgjeysm?.QualifyingEncounter;
		IEnumerable<Encounter> j_ = context.Operators.Select<(Encounter QualifyingEncounter, Procedure NutritionCarePlan)?, Encounter>(h_, i_);

		return j_;
	}

    [CqlDeclaration("Encounter with Nutrition Care Plan")]
	public IEnumerable<Encounter> Encounter_with_Nutrition_Care_Plan() => 
		__Encounter_with_Nutrition_Care_Plan.Value;

    [CqlDeclaration("Measure Observation 1")]
	public int? Measure_Observation_1(Encounter MalnutritionRiskScreening) => 
		((context.Operators.Contains<Encounter>(this.Encounter_with_Malnutrition_Risk_Screening_or_with_Hospital_Dietitian_Referral(), MalnutritionRiskScreening)) ?? false
			? 1
			: 0);

    [CqlDeclaration("Measure Observation 2")]
	public int? Measure_Observation_2(Encounter NutritionAssessment)
	{
		int? a_()
		{
			bool b_()
			{
				IEnumerable<Encounter> d_ = this.Encounter_with_Malnutrition_Not_at_Risk_Screening_and_without_Hospital_Dietitian_Referral();
				bool? e_ = context.Operators.Contains<Encounter>(d_, NutritionAssessment);

				return e_ ?? false;
			};
			bool c_()
			{
				IEnumerable<Encounter> f_ = this.Encounter_with_Malnutrition_Risk_Screening_at_Risk_or_with_Hospital_Dietitian_Referral();
				bool? g_ = context.Operators.Contains<Encounter>(f_, NutritionAssessment);

				return g_ ?? false;
			};
			if (b_())
			{
				return 0;
			}
			else if (c_())
			{
				return ((context.Operators.Contains<Encounter>(this.Encounter_with_Nutrition_Assessment_and_Identified_Status(), NutritionAssessment)) ?? false
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
				IEnumerable<Encounter> d_ = this.Encounter_with_Malnutrition_Not_at_Risk_Screening_and_without_Hospital_Dietitian_Referral();
				bool? e_ = context.Operators.Contains<Encounter>(d_, MalnutritionDiagonsis);

				return e_ ?? false;
			};
			bool c_()
			{
				IEnumerable<Encounter> f_ = this.Encounter_with_Malnutrition_Risk_Screening_at_Risk_or_with_Hospital_Dietitian_Referral();
				bool? g_ = context.Operators.Contains<Encounter>(f_, MalnutritionDiagonsis);

				return g_ ?? false;
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
						IEnumerable<Encounter> j_ = this.Encounter_with_Malnutrition_Diagnosis();
						bool? k_ = context.Operators.Contains<Encounter>(j_, MalnutritionDiagonsis);

						return k_ ?? false;
					};
					if (i_())
					{
						int? l_()
						{
							bool m_()
							{
								IEnumerable<Encounter> o_ = this.Encounter_with_Nutrition_Assessment_Not_or_Mildly_Malnourished();
								bool? p_ = context.Operators.Contains<Encounter>(o_, MalnutritionDiagonsis);

								return p_ ?? false;
							};
							bool n_()
							{
								IEnumerable<Encounter> q_ = this.Encounter_with_Nutrition_Assessment_Status_Moderately_Or_Severely_Malnourished();
								bool? r_ = context.Operators.Contains<Encounter>(q_, MalnutritionDiagonsis);

								return r_ ?? false;
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
				IEnumerable<Encounter> d_ = this.Encounter_with_Malnutrition_Not_at_Risk_Screening_and_without_Hospital_Dietitian_Referral();
				bool? e_ = context.Operators.Contains<Encounter>(d_, NutritionCarePlan);

				return e_ ?? false;
			};
			bool c_()
			{
				IEnumerable<Encounter> f_ = this.Encounter_with_Malnutrition_Risk_Screening_at_Risk_or_with_Hospital_Dietitian_Referral();
				bool? g_ = context.Operators.Contains<Encounter>(f_, NutritionCarePlan);

				return g_ ?? false;
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
						IEnumerable<Encounter> j_ = this.Encounter_with_Nutrition_Care_Plan();
						bool? k_ = context.Operators.Contains<Encounter>(j_, NutritionCarePlan);

						return k_ ?? false;
					};
					if (i_())
					{
						int? l_()
						{
							bool m_()
							{
								IEnumerable<Encounter> o_ = this.Encounter_with_Nutrition_Assessment_Not_or_Mildly_Malnourished();
								bool? p_ = context.Operators.Contains<Encounter>(o_, NutritionCarePlan);

								return p_ ?? false;
							};
							bool n_()
							{
								IEnumerable<Encounter> q_ = this.Encounter_with_Nutrition_Assessment_Status_Moderately_Or_Severely_Malnourished();
								bool? r_ = context.Operators.Contains<Encounter>(q_, NutritionCarePlan);

								return r_ ?? false;
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
		int? a_ = this.Measure_Observation_1(QualifyingEncounter);
		int? b_ = this.Measure_Observation_2(QualifyingEncounter);
		int? c_ = this.Measure_Observation_3(QualifyingEncounter);
		int? d_ = this.Measure_Observation_4(QualifyingEncounter);
		int?[] e_ = [
			a_,
			b_,
			c_,
			d_,
		];
		int? f_ = context.Operators.Sum(e_ as IEnumerable<int?>);

		return f_;
	}

    [CqlDeclaration("TotalMalnutritionCompositeScore Eligible Denominators")]
	public int? TotalMalnutritionCompositeScore_Eligible_Denominators(Encounter QualifyingEncounter)
	{
		int? a_()
		{
			bool b_()
			{
				IEnumerable<Encounter> d_ = this.Encounter_with_Malnutrition_Risk_Screening_or_with_Hospital_Dietitian_Referral();
				bool? e_ = context.Operators.Contains<Encounter>(d_, QualifyingEncounter);
				IEnumerable<Encounter> f_ = this.Encounter_with_Malnutrition_Risk_Screening_Not_at_Risk();
				bool? g_ = context.Operators.Contains<Encounter>(f_, QualifyingEncounter);
				bool? h_ = context.Operators.And(e_, g_);
				IEnumerable<Encounter> i_ = this.Encounter_with_Hospital_Dietitian_Referral();
				bool? j_ = context.Operators.Contains<Encounter>(i_, QualifyingEncounter);
				bool? k_ = context.Operators.Not(j_);
				bool? l_ = context.Operators.And(h_, k_);

				return l_ ?? false;
			};
			bool c_()
			{
				IEnumerable<Encounter> m_ = this.Encounter_with_Malnutrition_Risk_Screening_or_with_Hospital_Dietitian_Referral();
				bool? n_ = context.Operators.Contains<Encounter>(m_, QualifyingEncounter);
				IEnumerable<Encounter> o_ = this.Encounter_with_Malnutrition_Risk_Screening_at_Risk();
				bool? p_ = context.Operators.Contains<Encounter>(o_, QualifyingEncounter);
				bool? q_ = context.Operators.And(n_, p_);
				IEnumerable<Encounter> r_ = this.Encounter_with_Hospital_Dietitian_Referral();
				bool? s_ = context.Operators.Contains<Encounter>(r_, QualifyingEncounter);
				bool? t_ = context.Operators.Or(q_, s_);
				IEnumerable<Encounter> u_ = this.Encounter_with_Nutrition_Assessment_Not_or_Mildly_Malnourished();
				bool? v_ = context.Operators.Contains<Encounter>(u_, QualifyingEncounter);
				bool? w_ = context.Operators.And(t_, v_);
				IEnumerable<Encounter> x_ = this.Encounter_with_Nutrition_Assessment_and_Identified_Status();
				bool? y_ = context.Operators.Contains<Encounter>(x_, QualifyingEncounter);
				bool? z_ = context.Operators.Not(y_);
				bool? aa_ = context.Operators.Or(w_, z_);

				return aa_ ?? false;
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
		decimal? a_ = context.Operators.ConvertIntegerToDecimal(100);
		int? b_ = this.Measure_Observation_TotalMalnutritionComponentsScore(QualifyingEncounter);
		decimal? c_ = context.Operators.ConvertIntegerToDecimal(b_);
		int? d_ = this.TotalMalnutritionCompositeScore_Eligible_Denominators(QualifyingEncounter);
		decimal? e_ = context.Operators.ConvertIntegerToDecimal(d_);
		decimal? f_ = context.Operators.Divide(c_, e_);
		decimal? g_ = context.Operators.Multiply(a_, f_);

		return g_;
	}

}
