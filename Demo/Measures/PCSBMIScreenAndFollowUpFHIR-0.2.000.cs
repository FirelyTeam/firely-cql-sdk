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
[CqlLibrary("PCSBMIScreenAndFollowUpFHIR", "0.2.000")]
public class PCSBMIScreenAndFollowUpFHIR_0_2_000
{


    internal CqlContext context;

    #region Cached values

    internal Lazy<CqlValueSet> __Encounter_to_Evaluate_BMI;
    internal Lazy<CqlValueSet> __Follow_Up_for_Above_Normal_BMI;
    internal Lazy<CqlValueSet> __Follow_Up_for_Below_Normal_BMI;
    internal Lazy<CqlValueSet> __Medical_Reason;
    internal Lazy<CqlValueSet> __Medications_for_Above_Normal_BMI;
    internal Lazy<CqlValueSet> __Medications_for_Below_Normal_BMI;
    internal Lazy<CqlValueSet> __Overweight_or_Obese;
    internal Lazy<CqlValueSet> __Patient_Declined;
    internal Lazy<CqlValueSet> __Pregnancy_or_Other_Related_Diagnoses;
    internal Lazy<CqlValueSet> __Referrals_Where_Weight_Assessment_May_Occur;
    internal Lazy<CqlValueSet> __Underweight;
    internal Lazy<CqlCode> __Body_mass_index__BMI___Ratio_;
    internal Lazy<CqlCode> __Encounter_for_palliative_care;
    internal Lazy<CqlCode> __Functional_Assessment_of_Chronic_Illness_Therapy___Palliative_Care_Questionnaire__FACIT_Pal_;
    internal Lazy<CqlCode> __virtual;
    internal Lazy<CqlCode[]> __ActCode;
    internal Lazy<CqlCode[]> __ICD10CM;
    internal Lazy<CqlCode[]> __LOINC;
    internal Lazy<CqlCode[]> __ObservationCategoryCodes;
    internal Lazy<CqlInterval<CqlDateTime>> __Measurement_Period;
    internal Lazy<Patient> __Patient;
    internal Lazy<IEnumerable<Encounter>> __Qualifying_Encounter_during_Day_of_Measurement_Period;
    internal Lazy<bool?> __Initial_Population;
    internal Lazy<bool?> __Denominator;
    internal Lazy<IEnumerable<Condition>> __Pregnancy;
    internal Lazy<bool?> __Denominator_Exclusions;
    internal Lazy<IEnumerable<Observation>> __BMI_during_Measurement_Period;
    internal Lazy<IEnumerable<Observation>> __Documented_High_BMI_during_Measurement_Period;
    internal Lazy<IEnumerable<object>> __High_BMI_Interventions_Ordered;
    internal Lazy<IEnumerable<Procedure>> __High_BMI_Interventions_Performed;
    internal Lazy<IEnumerable<Observation>> __High_BMI_and_Follow_up_Provided;
    internal Lazy<IEnumerable<Observation>> __Documented_Low_BMI_during_Measurement_Period;
    internal Lazy<IEnumerable<object>> __Low_BMI_Interventions_Ordered;
    internal Lazy<IEnumerable<Procedure>> __Low_BMI_Interventions_Performed;
    internal Lazy<IEnumerable<Observation>> __Low_BMI_and_Follow_up_Provided;
    internal Lazy<bool?> __Has_Normal_BMI;
    internal Lazy<bool?> __Numerator;
    internal Lazy<IEnumerable<object>> __Medical_Reason_for_Not_Documenting_a_Follow_up_Plan_for_Low_or_High_BMI;
    internal Lazy<IEnumerable<Observation>> __Medical_Reason_or_Patient_Reason_for_Not_Performing_BMI_Exam;
    internal Lazy<bool?> __Denominator_Exceptions;
    internal Lazy<Tuples.Tuple_DMgHTLENEHBHWJISQgKZGZVMB> __SDE_Ethnicity;
    internal Lazy<IEnumerable<Tuples.Tuple_GDKRbfOIHhLGieQSVDEMIaDPX>> __SDE_Payer;
    internal Lazy<Tuples.Tuple_DMgHTLENEHBHWJISQgKZGZVMB> __SDE_Race;
    internal Lazy<CqlCode> __SDE_Sex;

    #endregion
    public PCSBMIScreenAndFollowUpFHIR_0_2_000(CqlContext context)
    {
        this.context = context ?? throw new ArgumentNullException("context");

        FHIRHelpers_4_3_000 = new FHIRHelpers_4_3_000(context);
        Hospice_6_9_000 = new Hospice_6_9_000(context);
        PalliativeCare_1_9_000 = new PalliativeCare_1_9_000(context);
        QICoreCommon_2_0_000 = new QICoreCommon_2_0_000(context);
        SupplementalDataElements_3_4_000 = new SupplementalDataElements_3_4_000(context);

        __Encounter_to_Evaluate_BMI = new Lazy<CqlValueSet>(this.Encounter_to_Evaluate_BMI_Value);
        __Follow_Up_for_Above_Normal_BMI = new Lazy<CqlValueSet>(this.Follow_Up_for_Above_Normal_BMI_Value);
        __Follow_Up_for_Below_Normal_BMI = new Lazy<CqlValueSet>(this.Follow_Up_for_Below_Normal_BMI_Value);
        __Medical_Reason = new Lazy<CqlValueSet>(this.Medical_Reason_Value);
        __Medications_for_Above_Normal_BMI = new Lazy<CqlValueSet>(this.Medications_for_Above_Normal_BMI_Value);
        __Medications_for_Below_Normal_BMI = new Lazy<CqlValueSet>(this.Medications_for_Below_Normal_BMI_Value);
        __Overweight_or_Obese = new Lazy<CqlValueSet>(this.Overweight_or_Obese_Value);
        __Patient_Declined = new Lazy<CqlValueSet>(this.Patient_Declined_Value);
        __Pregnancy_or_Other_Related_Diagnoses = new Lazy<CqlValueSet>(this.Pregnancy_or_Other_Related_Diagnoses_Value);
        __Referrals_Where_Weight_Assessment_May_Occur = new Lazy<CqlValueSet>(this.Referrals_Where_Weight_Assessment_May_Occur_Value);
        __Underweight = new Lazy<CqlValueSet>(this.Underweight_Value);
        __Body_mass_index__BMI___Ratio_ = new Lazy<CqlCode>(this.Body_mass_index__BMI___Ratio__Value);
        __Encounter_for_palliative_care = new Lazy<CqlCode>(this.Encounter_for_palliative_care_Value);
        __Functional_Assessment_of_Chronic_Illness_Therapy___Palliative_Care_Questionnaire__FACIT_Pal_ = new Lazy<CqlCode>(this.Functional_Assessment_of_Chronic_Illness_Therapy___Palliative_Care_Questionnaire__FACIT_Pal__Value);
        __virtual = new Lazy<CqlCode>(this.@virtual_Value);
        __ActCode = new Lazy<CqlCode[]>(this.ActCode_Value);
        __ICD10CM = new Lazy<CqlCode[]>(this.ICD10CM_Value);
        __LOINC = new Lazy<CqlCode[]>(this.LOINC_Value);
        __ObservationCategoryCodes = new Lazy<CqlCode[]>(this.ObservationCategoryCodes_Value);
        __Measurement_Period = new Lazy<CqlInterval<CqlDateTime>>(this.Measurement_Period_Value);
        __Patient = new Lazy<Patient>(this.Patient_Value);
        __Qualifying_Encounter_during_Day_of_Measurement_Period = new Lazy<IEnumerable<Encounter>>(this.Qualifying_Encounter_during_Day_of_Measurement_Period_Value);
        __Initial_Population = new Lazy<bool?>(this.Initial_Population_Value);
        __Denominator = new Lazy<bool?>(this.Denominator_Value);
        __Pregnancy = new Lazy<IEnumerable<Condition>>(this.Pregnancy_Value);
        __Denominator_Exclusions = new Lazy<bool?>(this.Denominator_Exclusions_Value);
        __BMI_during_Measurement_Period = new Lazy<IEnumerable<Observation>>(this.BMI_during_Measurement_Period_Value);
        __Documented_High_BMI_during_Measurement_Period = new Lazy<IEnumerable<Observation>>(this.Documented_High_BMI_during_Measurement_Period_Value);
        __High_BMI_Interventions_Ordered = new Lazy<IEnumerable<object>>(this.High_BMI_Interventions_Ordered_Value);
        __High_BMI_Interventions_Performed = new Lazy<IEnumerable<Procedure>>(this.High_BMI_Interventions_Performed_Value);
        __High_BMI_and_Follow_up_Provided = new Lazy<IEnumerable<Observation>>(this.High_BMI_and_Follow_up_Provided_Value);
        __Documented_Low_BMI_during_Measurement_Period = new Lazy<IEnumerable<Observation>>(this.Documented_Low_BMI_during_Measurement_Period_Value);
        __Low_BMI_Interventions_Ordered = new Lazy<IEnumerable<object>>(this.Low_BMI_Interventions_Ordered_Value);
        __Low_BMI_Interventions_Performed = new Lazy<IEnumerable<Procedure>>(this.Low_BMI_Interventions_Performed_Value);
        __Low_BMI_and_Follow_up_Provided = new Lazy<IEnumerable<Observation>>(this.Low_BMI_and_Follow_up_Provided_Value);
        __Has_Normal_BMI = new Lazy<bool?>(this.Has_Normal_BMI_Value);
        __Numerator = new Lazy<bool?>(this.Numerator_Value);
        __Medical_Reason_for_Not_Documenting_a_Follow_up_Plan_for_Low_or_High_BMI = new Lazy<IEnumerable<object>>(this.Medical_Reason_for_Not_Documenting_a_Follow_up_Plan_for_Low_or_High_BMI_Value);
        __Medical_Reason_or_Patient_Reason_for_Not_Performing_BMI_Exam = new Lazy<IEnumerable<Observation>>(this.Medical_Reason_or_Patient_Reason_for_Not_Performing_BMI_Exam_Value);
        __Denominator_Exceptions = new Lazy<bool?>(this.Denominator_Exceptions_Value);
        __SDE_Ethnicity = new Lazy<Tuples.Tuple_DMgHTLENEHBHWJISQgKZGZVMB>(this.SDE_Ethnicity_Value);
        __SDE_Payer = new Lazy<IEnumerable<Tuples.Tuple_GDKRbfOIHhLGieQSVDEMIaDPX>>(this.SDE_Payer_Value);
        __SDE_Race = new Lazy<Tuples.Tuple_DMgHTLENEHBHWJISQgKZGZVMB>(this.SDE_Race_Value);
        __SDE_Sex = new Lazy<CqlCode>(this.SDE_Sex_Value);
    }
    #region Dependencies

    public FHIRHelpers_4_3_000 FHIRHelpers_4_3_000 { get; }
    public Hospice_6_9_000 Hospice_6_9_000 { get; }
    public PalliativeCare_1_9_000 PalliativeCare_1_9_000 { get; }
    public QICoreCommon_2_0_000 QICoreCommon_2_0_000 { get; }
    public SupplementalDataElements_3_4_000 SupplementalDataElements_3_4_000 { get; }

    #endregion

	private CqlValueSet Encounter_to_Evaluate_BMI_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.600.1.1751", null);

    [CqlDeclaration("Encounter to Evaluate BMI")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.600.1.1751")]
	public CqlValueSet Encounter_to_Evaluate_BMI() => 
		__Encounter_to_Evaluate_BMI.Value;

	private CqlValueSet Follow_Up_for_Above_Normal_BMI_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.600.1.1525", null);

    [CqlDeclaration("Follow Up for Above Normal BMI")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.600.1.1525")]
	public CqlValueSet Follow_Up_for_Above_Normal_BMI() => 
		__Follow_Up_for_Above_Normal_BMI.Value;

	private CqlValueSet Follow_Up_for_Below_Normal_BMI_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.600.1.1528", null);

    [CqlDeclaration("Follow Up for Below Normal BMI")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.600.1.1528")]
	public CqlValueSet Follow_Up_for_Below_Normal_BMI() => 
		__Follow_Up_for_Below_Normal_BMI.Value;

	private CqlValueSet Medical_Reason_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1007", null);

    [CqlDeclaration("Medical Reason")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1007")]
	public CqlValueSet Medical_Reason() => 
		__Medical_Reason.Value;

	private CqlValueSet Medications_for_Above_Normal_BMI_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1561", null);

    [CqlDeclaration("Medications for Above Normal BMI")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1561")]
	public CqlValueSet Medications_for_Above_Normal_BMI() => 
		__Medications_for_Above_Normal_BMI.Value;

	private CqlValueSet Medications_for_Below_Normal_BMI_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1562", null);

    [CqlDeclaration("Medications for Below Normal BMI")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1562")]
	public CqlValueSet Medications_for_Below_Normal_BMI() => 
		__Medications_for_Below_Normal_BMI.Value;

	private CqlValueSet Overweight_or_Obese_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1047.502", null);

    [CqlDeclaration("Overweight or Obese")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1047.502")]
	public CqlValueSet Overweight_or_Obese() => 
		__Overweight_or_Obese.Value;

	private CqlValueSet Patient_Declined_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1582", null);

    [CqlDeclaration("Patient Declined")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1582")]
	public CqlValueSet Patient_Declined() => 
		__Patient_Declined.Value;

	private CqlValueSet Pregnancy_or_Other_Related_Diagnoses_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.600.1.1623", null);

    [CqlDeclaration("Pregnancy or Other Related Diagnoses")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.600.1.1623")]
	public CqlValueSet Pregnancy_or_Other_Related_Diagnoses() => 
		__Pregnancy_or_Other_Related_Diagnoses.Value;

	private CqlValueSet Referrals_Where_Weight_Assessment_May_Occur_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.600.1.1527", null);

    [CqlDeclaration("Referrals Where Weight Assessment May Occur")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.600.1.1527")]
	public CqlValueSet Referrals_Where_Weight_Assessment_May_Occur() => 
		__Referrals_Where_Weight_Assessment_May_Occur.Value;

	private CqlValueSet Underweight_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1563", null);

    [CqlDeclaration("Underweight")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1563")]
	public CqlValueSet Underweight() => 
		__Underweight.Value;

	private CqlCode Body_mass_index__BMI___Ratio__Value() => 
		new CqlCode("39156-5", "http://loinc.org", null, null);

    [CqlDeclaration("Body mass index (BMI) [Ratio]")]
	public CqlCode Body_mass_index__BMI___Ratio_() => 
		__Body_mass_index__BMI___Ratio_.Value;

	private CqlCode Encounter_for_palliative_care_Value() => 
		new CqlCode("Z51.5", "http://hl7.org/fhir/sid/icd-10-cm", null, null);

    [CqlDeclaration("Encounter for palliative care")]
	public CqlCode Encounter_for_palliative_care() => 
		__Encounter_for_palliative_care.Value;

	private CqlCode Functional_Assessment_of_Chronic_Illness_Therapy___Palliative_Care_Questionnaire__FACIT_Pal__Value() => 
		new CqlCode("71007-9", "http://loinc.org", null, null);

    [CqlDeclaration("Functional Assessment of Chronic Illness Therapy - Palliative Care Questionnaire (FACIT-Pal)")]
	public CqlCode Functional_Assessment_of_Chronic_Illness_Therapy___Palliative_Care_Questionnaire__FACIT_Pal_() => 
		__Functional_Assessment_of_Chronic_Illness_Therapy___Palliative_Care_Questionnaire__FACIT_Pal_.Value;

	private CqlCode @virtual_Value() => 
		new CqlCode("VR", "http://terminology.hl7.org/CodeSystem/v3-ActCode", null, null);

    [CqlDeclaration("virtual")]
	public CqlCode @virtual() => 
		__virtual.Value;

	private CqlCode[] ActCode_Value()
	{
		var a_ = new CqlCode[]
		{
			new CqlCode("VR", "http://terminology.hl7.org/CodeSystem/v3-ActCode", null, null),
		};

		return a_;
	}

    [CqlDeclaration("ActCode")]
	public CqlCode[] ActCode() => 
		__ActCode.Value;

	private CqlCode[] ICD10CM_Value()
	{
		var a_ = new CqlCode[]
		{
			new CqlCode("Z51.5", "http://hl7.org/fhir/sid/icd-10-cm", null, null),
		};

		return a_;
	}

    [CqlDeclaration("ICD10CM")]
	public CqlCode[] ICD10CM() => 
		__ICD10CM.Value;

	private CqlCode[] LOINC_Value()
	{
		var a_ = new CqlCode[]
		{
			new CqlCode("39156-5", "http://loinc.org", null, null),
			new CqlCode("71007-9", "http://loinc.org", null, null),
		};

		return a_;
	}

    [CqlDeclaration("LOINC")]
	public CqlCode[] LOINC() => 
		__LOINC.Value;

	private CqlCode[] ObservationCategoryCodes_Value()
	{
		var a_ = new CqlCode[0]
;

		return a_;
	}

    [CqlDeclaration("ObservationCategoryCodes")]
	public CqlCode[] ObservationCategoryCodes() => 
		__ObservationCategoryCodes.Value;

	private CqlInterval<CqlDateTime> Measurement_Period_Value()
	{
		var a_ = context.Operators.ConvertIntegerToDecimal(default);
		var b_ = context.Operators.DateTime((int?)2025, (int?)1, (int?)1, (int?)0, (int?)0, (int?)0, (int?)0, a_);
		var d_ = context.Operators.DateTime((int?)2026, (int?)1, (int?)1, (int?)0, (int?)0, (int?)0, (int?)0, a_);
		var e_ = context.Operators.Interval(b_, d_, true, false);
		var f_ = context.ResolveParameter("PCSBMIScreenAndFollowUpFHIR-0.2.000", "Measurement Period", e_);

		return (CqlInterval<CqlDateTime>)f_;
	}

    [CqlDeclaration("Measurement Period")]
	public CqlInterval<CqlDateTime> Measurement_Period() => 
		__Measurement_Period.Value;

	private Patient Patient_Value()
	{
		var a_ = context.Operators.RetrieveByValueSet<Patient>(null, null);
		var b_ = context.Operators.SingleOrNull<Patient>(a_);

		return b_;
	}

    [CqlDeclaration("Patient")]
	public Patient Patient() => 
		__Patient.Value;

	private IEnumerable<Encounter> Qualifying_Encounter_during_Day_of_Measurement_Period_Value()
	{
		var a_ = this.Encounter_to_Evaluate_BMI();
		var b_ = context.Operators.RetrieveByValueSet<Encounter>(a_, null);
		bool? c_(Encounter BMIEncounter)
		{
			var e_ = this.Measurement_Period();
			var f_ = FHIRHelpers_4_3_000.ToInterval(BMIEncounter?.Period);
			var g_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(e_, f_, "day");
			var h_ = FHIRHelpers_4_3_000.ToCode(BMIEncounter?.Class);
			var i_ = this.@virtual();
			var j_ = context.Operators.Equivalent(h_, i_);
			var k_ = context.Operators.Not(j_);
			var l_ = context.Operators.And(g_, k_);
			var m_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(BMIEncounter?.StatusElement?.Value);
			var n_ = context.Operators.Equal(m_, "finished");
			var o_ = context.Operators.And(l_, n_);

			return o_;
		};
		var d_ = context.Operators.WhereOrNull<Encounter>(b_, c_);

		return d_;
	}

    [CqlDeclaration("Qualifying Encounter during Day of Measurement Period")]
	public IEnumerable<Encounter> Qualifying_Encounter_during_Day_of_Measurement_Period() => 
		__Qualifying_Encounter_during_Day_of_Measurement_Period.Value;

	private bool? Initial_Population_Value()
	{
		var a_ = this.Qualifying_Encounter_during_Day_of_Measurement_Period();
		bool? b_(Encounter QualifyingEncounter)
		{
			var e_ = this.Patient();
			var f_ = context.Operators.Convert<CqlDate>(e_?.BirthDateElement?.Value);
			var g_ = FHIRHelpers_4_3_000.ToInterval(QualifyingEncounter?.Period);
			var h_ = context.Operators.Start(g_);
			var i_ = context.Operators.DateFrom(h_);
			var j_ = context.Operators.CalculateAgeAt(f_, i_, "year");
			var k_ = context.Operators.GreaterOrEqual(j_, (int?)18);

			return k_;
		};
		var c_ = context.Operators.WhereOrNull<Encounter>(a_, b_);
		var d_ = context.Operators.ExistsInList<Encounter>(c_);

		return d_;
	}

    [CqlDeclaration("Initial Population")]
	public bool? Initial_Population() => 
		__Initial_Population.Value;

	private bool? Denominator_Value()
	{
		var a_ = this.Initial_Population();

		return a_;
	}

    [CqlDeclaration("Denominator")]
	public bool? Denominator() => 
		__Denominator.Value;

	private IEnumerable<Condition> Pregnancy_Value()
	{
		var a_ = this.Pregnancy_or_Other_Related_Diagnoses();
		var b_ = context.Operators.RetrieveByValueSet<Condition>(a_, null);
		IEnumerable<Condition> c_(Condition PregnancyDiagnosis)
		{
			var e_ = this.Qualifying_Encounter_during_Day_of_Measurement_Period();
			bool? f_(Encounter QualifyingEncounter)
			{
				var j_ = FHIRHelpers_4_3_000.ToConcept(PregnancyDiagnosis?.ClinicalStatus);
				var k_ = QICoreCommon_2_0_000.active();
				var l_ = context.Operators.ConvertCodeToConcept(k_);
				var m_ = context.Operators.Equivalent(j_, l_);
				var n_ = QICoreCommon_2_0_000.prevalenceInterval(PregnancyDiagnosis);
				var o_ = this.Measurement_Period();
				var p_ = context.Operators.Overlaps(n_, o_, "day");
				var q_ = context.Operators.And(m_, p_);

				return q_;
			};
			var g_ = context.Operators.WhereOrNull<Encounter>(e_, f_);
			Condition h_(Encounter QualifyingEncounter) => 
				PregnancyDiagnosis;
			var i_ = context.Operators.SelectOrNull<Encounter, Condition>(g_, h_);

			return i_;
		};
		var d_ = context.Operators.SelectManyOrNull<Condition, Condition>(b_, c_);

		return d_;
	}

    [CqlDeclaration("Pregnancy")]
	public IEnumerable<Condition> Pregnancy() => 
		__Pregnancy.Value;

	private bool? Denominator_Exclusions_Value()
	{
		var a_ = Hospice_6_9_000.Has_Hospice_Services();
		var b_ = PalliativeCare_1_9_000.Has_Palliative_Care_in_the_Measurement_Period();
		var c_ = context.Operators.Or(a_, b_);
		var d_ = this.Pregnancy();
		var e_ = context.Operators.ExistsInList<Condition>(d_);
		var f_ = context.Operators.Or(c_, e_);

		return f_;
	}

    [CqlDeclaration("Denominator Exclusions")]
	public bool? Denominator_Exclusions() => 
		__Denominator_Exclusions.Value;

	private IEnumerable<Observation> BMI_during_Measurement_Period_Value()
	{
		var a_ = context.Operators.RetrieveByValueSet<Observation>(null, null);
		bool? b_(Observation BMI)
		{
			var d_ = FHIRHelpers_4_3_000.ToQuantity(BMI?.Value);
			var e_ = context.Operators.Quantity(0m, "kg/m2");
			var f_ = context.Operators.Greater(d_, e_);
			var g_ = context.Operators.Convert<Code<ObservationStatus>>(BMI?.StatusElement?.Value);
			var h_ = context.Operators.Convert<string>(g_);
			var i_ = new string[]
			{
				"final",
				"amended",
				"corrected",
			};
			var j_ = context.Operators.InList<string>(h_, (i_ as IEnumerable<string>));
			var k_ = context.Operators.And(f_, j_);
			var l_ = this.Measurement_Period();
			var m_ = FHIRHelpers_4_3_000.ToValue(BMI?.Effective);
			var n_ = QICoreCommon_2_0_000.toInterval(m_);
			var o_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(l_, n_, "day");
			var p_ = context.Operators.And(k_, o_);

			return p_;
		};
		var c_ = context.Operators.WhereOrNull<Observation>(a_, b_);

		return c_;
	}

    [CqlDeclaration("BMI during Measurement Period")]
	public IEnumerable<Observation> BMI_during_Measurement_Period() => 
		__BMI_during_Measurement_Period.Value;

	private IEnumerable<Observation> Documented_High_BMI_during_Measurement_Period_Value()
	{
		var a_ = this.BMI_during_Measurement_Period();
		bool? b_(Observation BMI)
		{
			var d_ = this.Measurement_Period();
			var e_ = FHIRHelpers_4_3_000.ToValue(BMI?.Effective);
			var f_ = QICoreCommon_2_0_000.toInterval(e_);
			var g_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(d_, f_, "day");
			var h_ = FHIRHelpers_4_3_000.ToQuantity(BMI?.Value);
			var i_ = context.Operators.Quantity(25m, "kg/m2");
			var j_ = context.Operators.GreaterOrEqual(h_, i_);
			var k_ = context.Operators.And(g_, j_);

			return k_;
		};
		var c_ = context.Operators.WhereOrNull<Observation>(a_, b_);

		return c_;
	}

    [CqlDeclaration("Documented High BMI during Measurement Period")]
	public IEnumerable<Observation> Documented_High_BMI_during_Measurement_Period() => 
		__Documented_High_BMI_during_Measurement_Period.Value;

	private IEnumerable<object> High_BMI_Interventions_Ordered_Value()
	{
		var a_ = this.Follow_Up_for_Above_Normal_BMI();
		var b_ = context.Operators.RetrieveByValueSet<ServiceRequest>(a_, null);
		var c_ = this.Referrals_Where_Weight_Assessment_May_Occur();
		var d_ = context.Operators.RetrieveByValueSet<ServiceRequest>(c_, null);
		var e_ = context.Operators.ListUnion<ServiceRequest>(b_, d_);
		var f_ = this.Medications_for_Above_Normal_BMI();
		var g_ = context.Operators.RetrieveByValueSet<MedicationRequest>(f_, null);
		var i_ = context.Operators.RetrieveByValueSet<MedicationRequest>(f_, null);
		var j_ = context.Operators.ListUnion<MedicationRequest>(g_, i_);
		var k_ = context.Operators.ListUnion<object>((e_ as IEnumerable<object>), (j_ as IEnumerable<object>));
		bool? l_(object HighInterventionsOrdered)
		{
			var n_ = context.Operators.LateBoundProperty<object>(HighInterventionsOrdered, "reasonCode");
			var o_ = new object[]
			{
				n_,
			};
			CqlConcept p_(object @this)
			{
				var z_ = FHIRHelpers_4_3_000.ToConcept(@this);

				return z_;
			};
			var q_ = context.Operators.SelectOrNull<object, CqlConcept>(o_, p_);
			var r_ = this.Overweight_or_Obese();
			var s_ = context.Operators.ConceptsInValueSet(q_, r_);
			var u_ = context.Operators.RetrieveByValueSet<Condition>(r_, null);
			bool? v_(Condition OverweightObese)
			{
				var aa_ = QICoreCommon_2_0_000.isProblemListItem(OverweightObese);
				var ab_ = QICoreCommon_2_0_000.isHealthConcern(OverweightObese);
				var ac_ = context.Operators.Or(aa_, ab_);
				var ad_ = QICoreCommon_2_0_000.isActive(OverweightObese);
				var ae_ = context.Operators.And(ac_, ad_);
				var af_ = QICoreCommon_2_0_000.prevalenceInterval(OverweightObese);
				var ag_ = context.Operators.Start(af_);
				var ah_ = context.Operators.LateBoundProperty<object>(HighInterventionsOrdered, "authoredOn");
				var ai_ = context.Operators.LateBoundProperty<CqlDateTime>(ah_, "value");
				var aj_ = context.Operators.SameOrBefore(ag_, ai_, "day");
				var ak_ = context.Operators.And(ae_, aj_);

				return ak_;
			};
			var w_ = context.Operators.WhereOrNull<Condition>(u_, v_);
			var x_ = context.Operators.ExistsInList<Condition>(w_);
			var y_ = context.Operators.Or(s_, x_);

			return y_;
		};
		var m_ = context.Operators.WhereOrNull<object>(k_, l_);

		return m_;
	}

    [CqlDeclaration("High BMI Interventions Ordered")]
	public IEnumerable<object> High_BMI_Interventions_Ordered() => 
		__High_BMI_Interventions_Ordered.Value;

	private IEnumerable<Procedure> High_BMI_Interventions_Performed_Value()
	{
		var a_ = this.Follow_Up_for_Above_Normal_BMI();
		var b_ = context.Operators.RetrieveByValueSet<Procedure>(a_, null);
		bool? c_(Procedure HighInterventionsPerformed)
		{
			CqlConcept e_(CodeableConcept @this)
			{
				var q_ = FHIRHelpers_4_3_000.ToConcept(@this);

				return q_;
			};
			var f_ = context.Operators.SelectOrNull<CodeableConcept, CqlConcept>(HighInterventionsPerformed?.ReasonCode, e_);
			var g_ = this.Overweight_or_Obese();
			var h_ = context.Operators.ConceptsInValueSet(f_, g_);
			var i_ = context.Operators.EnumEqualsString(HighInterventionsPerformed?.StatusElement?.Value, "completed");
			var j_ = context.Operators.And(h_, i_);
			var l_ = context.Operators.RetrieveByValueSet<Condition>(g_, null);
			bool? m_(Condition OverweightObese)
			{
				var r_ = QICoreCommon_2_0_000.isHealthConcern(OverweightObese);
				var s_ = QICoreCommon_2_0_000.isActive(OverweightObese);
				var t_ = context.Operators.And(r_, s_);
				CqlInterval<CqlDateTime> u_()
				{
					if ((context.Operators.Start(QICoreCommon_2_0_000.prevalenceInterval(OverweightObese)) is null))
					{
						return null;
					}
					else
					{
						var z_ = QICoreCommon_2_0_000.prevalenceInterval(OverweightObese);
						var aa_ = context.Operators.Start(z_);
						var ac_ = context.Operators.Start(z_);
						var ad_ = context.Operators.Interval(aa_, ac_, true, true);

						return ad_;
					};
				};
				var v_ = FHIRHelpers_4_3_000.ToValue(HighInterventionsPerformed?.Performed);
				var w_ = QICoreCommon_2_0_000.toInterval(v_);
				var x_ = context.Operators.IntervalSameOrBefore(u_(), w_, "day");
				var y_ = context.Operators.And(t_, x_);

				return y_;
			};
			var n_ = context.Operators.WhereOrNull<Condition>(l_, m_);
			var o_ = context.Operators.ExistsInList<Condition>(n_);
			var p_ = context.Operators.Or(j_, o_);

			return p_;
		};
		var d_ = context.Operators.WhereOrNull<Procedure>(b_, c_);

		return d_;
	}

    [CqlDeclaration("High BMI Interventions Performed")]
	public IEnumerable<Procedure> High_BMI_Interventions_Performed() => 
		__High_BMI_Interventions_Performed.Value;

	private IEnumerable<Observation> High_BMI_and_Follow_up_Provided_Value()
	{
		var a_ = this.Documented_High_BMI_during_Measurement_Period();
		IEnumerable<Observation> b_(Observation HighBMI)
		{
			var d_ = this.High_BMI_Interventions_Ordered();
			var e_ = this.High_BMI_Interventions_Performed();
			var f_ = context.Operators.ListUnion<object>((d_ as IEnumerable<object>), (e_ as IEnumerable<object>));
			bool? g_(object HighBMIInterventions)
			{
				var k_ = context.Operators.LateBoundProperty<object>(HighBMIInterventions, "performed");
				var l_ = FHIRHelpers_4_3_000.ToValue(k_);
				var m_ = QICoreCommon_2_0_000.toInterval(l_);
				var n_ = context.Operators.LateBoundProperty<object>(HighBMIInterventions, "authoredOn");
				var o_ = context.Operators.LateBoundProperty<CqlDateTime>(n_, "value");
				var p_ = QICoreCommon_2_0_000.toInterval((o_ as object));
				var q_ = context.Operators.Start((m_ ?? p_));
				var r_ = this.Measurement_Period();
				var s_ = context.Operators.ElementInInterval<CqlDateTime>(q_, r_, "day");

				return s_;
			};
			var h_ = context.Operators.WhereOrNull<object>(f_, g_);
			Observation i_(object HighBMIInterventions) => 
				HighBMI;
			var j_ = context.Operators.SelectOrNull<object, Observation>(h_, i_);

			return j_;
		};
		var c_ = context.Operators.SelectManyOrNull<Observation, Observation>(a_, b_);

		return c_;
	}

    [CqlDeclaration("High BMI and Follow up Provided")]
	public IEnumerable<Observation> High_BMI_and_Follow_up_Provided() => 
		__High_BMI_and_Follow_up_Provided.Value;

	private IEnumerable<Observation> Documented_Low_BMI_during_Measurement_Period_Value()
	{
		var a_ = this.BMI_during_Measurement_Period();
		bool? b_(Observation BMI)
		{
			var d_ = this.Measurement_Period();
			var e_ = FHIRHelpers_4_3_000.ToValue(BMI?.Effective);
			var f_ = QICoreCommon_2_0_000.toInterval(e_);
			var g_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(d_, f_, "day");
			var h_ = FHIRHelpers_4_3_000.ToQuantity(BMI?.Value);
			var i_ = context.Operators.Quantity(18.5m, "kg/m2");
			var j_ = context.Operators.Less(h_, i_);
			var k_ = context.Operators.And(g_, j_);

			return k_;
		};
		var c_ = context.Operators.WhereOrNull<Observation>(a_, b_);

		return c_;
	}

    [CqlDeclaration("Documented Low BMI during Measurement Period")]
	public IEnumerable<Observation> Documented_Low_BMI_during_Measurement_Period() => 
		__Documented_Low_BMI_during_Measurement_Period.Value;

	private IEnumerable<object> Low_BMI_Interventions_Ordered_Value()
	{
		var a_ = this.Follow_Up_for_Below_Normal_BMI();
		var b_ = context.Operators.RetrieveByValueSet<ServiceRequest>(a_, null);
		var c_ = this.Referrals_Where_Weight_Assessment_May_Occur();
		var d_ = context.Operators.RetrieveByValueSet<ServiceRequest>(c_, null);
		var e_ = context.Operators.ListUnion<ServiceRequest>(b_, d_);
		var f_ = this.Medications_for_Below_Normal_BMI();
		var g_ = context.Operators.RetrieveByValueSet<MedicationRequest>(f_, null);
		var i_ = context.Operators.RetrieveByValueSet<MedicationRequest>(f_, null);
		var j_ = context.Operators.ListUnion<MedicationRequest>(g_, i_);
		var k_ = context.Operators.ListUnion<object>((e_ as IEnumerable<object>), (j_ as IEnumerable<object>));
		bool? l_(object LowInterventionsOrdered)
		{
			var n_ = context.Operators.LateBoundProperty<object>(LowInterventionsOrdered, "reasonCode");
			var o_ = new object[]
			{
				n_,
			};
			CqlConcept p_(object @this)
			{
				var z_ = FHIRHelpers_4_3_000.ToConcept(@this);

				return z_;
			};
			var q_ = context.Operators.SelectOrNull<object, CqlConcept>(o_, p_);
			var r_ = this.Underweight();
			var s_ = context.Operators.ConceptsInValueSet(q_, r_);
			var u_ = context.Operators.RetrieveByValueSet<Condition>(r_, null);
			bool? v_(Condition Underweight)
			{
				var aa_ = QICoreCommon_2_0_000.isHealthConcern(Underweight);
				var ab_ = QICoreCommon_2_0_000.isActive(Underweight);
				var ac_ = context.Operators.And(aa_, ab_);
				var ad_ = QICoreCommon_2_0_000.prevalenceInterval(Underweight);
				var ae_ = context.Operators.Start(ad_);
				var af_ = context.Operators.LateBoundProperty<object>(LowInterventionsOrdered, "authoredOn");
				var ag_ = context.Operators.LateBoundProperty<CqlDateTime>(af_, "value");
				var ah_ = context.Operators.SameOrBefore(ae_, ag_, "day");
				var ai_ = context.Operators.And(ac_, ah_);
				var ak_ = context.Operators.LateBoundProperty<CqlDateTime>(af_, "value");
				var al_ = this.Measurement_Period();
				var am_ = context.Operators.ElementInInterval<CqlDateTime>(ak_, al_, "day");
				var an_ = context.Operators.And(ai_, am_);

				return an_;
			};
			var w_ = context.Operators.WhereOrNull<Condition>(u_, v_);
			var x_ = context.Operators.ExistsInList<Condition>(w_);
			var y_ = context.Operators.Or(s_, x_);

			return y_;
		};
		var m_ = context.Operators.WhereOrNull<object>(k_, l_);

		return m_;
	}

    [CqlDeclaration("Low BMI Interventions Ordered")]
	public IEnumerable<object> Low_BMI_Interventions_Ordered() => 
		__Low_BMI_Interventions_Ordered.Value;

	private IEnumerable<Procedure> Low_BMI_Interventions_Performed_Value()
	{
		var a_ = this.Follow_Up_for_Below_Normal_BMI();
		var b_ = context.Operators.RetrieveByValueSet<Procedure>(a_, null);
		bool? c_(Procedure LowInterventionsPerformed)
		{
			CqlConcept e_(CodeableConcept @this)
			{
				var q_ = FHIRHelpers_4_3_000.ToConcept(@this);

				return q_;
			};
			var f_ = context.Operators.SelectOrNull<CodeableConcept, CqlConcept>(LowInterventionsPerformed?.ReasonCode, e_);
			var g_ = this.Underweight();
			var h_ = context.Operators.ConceptsInValueSet(f_, g_);
			var i_ = context.Operators.EnumEqualsString(LowInterventionsPerformed?.StatusElement?.Value, "completed");
			var j_ = context.Operators.And(h_, i_);
			var l_ = context.Operators.RetrieveByValueSet<Condition>(g_, null);
			bool? m_(Condition Underweight)
			{
				var r_ = QICoreCommon_2_0_000.isHealthConcern(Underweight);
				var s_ = QICoreCommon_2_0_000.isActive(Underweight);
				var t_ = context.Operators.And(r_, s_);
				CqlInterval<CqlDateTime> u_()
				{
					if ((context.Operators.Start(QICoreCommon_2_0_000.prevalenceInterval(Underweight)) is null))
					{
						return null;
					}
					else
					{
						var ae_ = QICoreCommon_2_0_000.prevalenceInterval(Underweight);
						var af_ = context.Operators.Start(ae_);
						var ah_ = context.Operators.Start(ae_);
						var ai_ = context.Operators.Interval(af_, ah_, true, true);

						return ai_;
					};
				};
				var v_ = FHIRHelpers_4_3_000.ToValue(LowInterventionsPerformed?.Performed);
				var w_ = QICoreCommon_2_0_000.toInterval(v_);
				var x_ = context.Operators.IntervalSameOrBefore(u_(), w_, "day");
				var y_ = context.Operators.And(t_, x_);
				var z_ = this.Measurement_Period();
				var ab_ = QICoreCommon_2_0_000.toInterval(v_);
				var ac_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(z_, ab_, "day");
				var ad_ = context.Operators.And(y_, ac_);

				return ad_;
			};
			var n_ = context.Operators.WhereOrNull<Condition>(l_, m_);
			var o_ = context.Operators.ExistsInList<Condition>(n_);
			var p_ = context.Operators.Or(j_, o_);

			return p_;
		};
		var d_ = context.Operators.WhereOrNull<Procedure>(b_, c_);

		return d_;
	}

    [CqlDeclaration("Low BMI Interventions Performed")]
	public IEnumerable<Procedure> Low_BMI_Interventions_Performed() => 
		__Low_BMI_Interventions_Performed.Value;

	private IEnumerable<Observation> Low_BMI_and_Follow_up_Provided_Value()
	{
		var a_ = this.Documented_Low_BMI_during_Measurement_Period();
		IEnumerable<Observation> b_(Observation LowBMI)
		{
			var d_ = this.Low_BMI_Interventions_Ordered();
			var e_ = this.Low_BMI_Interventions_Performed();
			var f_ = context.Operators.ListUnion<object>((d_ as IEnumerable<object>), (e_ as IEnumerable<object>));
			bool? g_(object LowBMIInterventions)
			{
				var k_ = context.Operators.LateBoundProperty<object>(LowBMIInterventions, "performed");
				var l_ = FHIRHelpers_4_3_000.ToValue(k_);
				var m_ = QICoreCommon_2_0_000.toInterval(l_);
				var n_ = context.Operators.LateBoundProperty<object>(LowBMIInterventions, "authoredOn");
				var o_ = context.Operators.LateBoundProperty<CqlDateTime>(n_, "value");
				var p_ = QICoreCommon_2_0_000.toInterval((o_ as object));
				var q_ = context.Operators.Start((m_ ?? p_));
				var r_ = this.Measurement_Period();
				var s_ = context.Operators.ElementInInterval<CqlDateTime>(q_, r_, "day");

				return s_;
			};
			var h_ = context.Operators.WhereOrNull<object>(f_, g_);
			Observation i_(object LowBMIInterventions) => 
				LowBMI;
			var j_ = context.Operators.SelectOrNull<object, Observation>(h_, i_);

			return j_;
		};
		var c_ = context.Operators.SelectManyOrNull<Observation, Observation>(a_, b_);

		return c_;
	}

    [CqlDeclaration("Low BMI and Follow up Provided")]
	public IEnumerable<Observation> Low_BMI_and_Follow_up_Provided() => 
		__Low_BMI_and_Follow_up_Provided.Value;

	private bool? Has_Normal_BMI_Value()
	{
		var a_ = this.BMI_during_Measurement_Period();
		bool? b_(Observation BMI)
		{
			var l_ = FHIRHelpers_4_3_000.ToQuantity(BMI?.Value);
			var m_ = context.Operators.Quantity(18.5m, "kg/m2");
			var n_ = context.Operators.Quantity(24.9m, "kg/m2");
			var o_ = context.Operators.Interval(m_, n_, true, true);
			var p_ = context.Operators.ElementInInterval<CqlQuantity>(l_, o_, null);

			return p_;
		};
		var c_ = context.Operators.WhereOrNull<Observation>(a_, b_);
		var d_ = context.Operators.ExistsInList<Observation>(c_);
		var e_ = this.Documented_High_BMI_during_Measurement_Period();
		var f_ = context.Operators.ExistsInList<Observation>(e_);
		var g_ = this.Documented_Low_BMI_during_Measurement_Period();
		var h_ = context.Operators.ExistsInList<Observation>(g_);
		var i_ = context.Operators.Or(f_, h_);
		var j_ = context.Operators.Not(i_);
		var k_ = context.Operators.And(d_, j_);

		return k_;
	}

    [CqlDeclaration("Has Normal BMI")]
	public bool? Has_Normal_BMI() => 
		__Has_Normal_BMI.Value;

	private bool? Numerator_Value()
	{
		var a_ = this.High_BMI_and_Follow_up_Provided();
		var b_ = context.Operators.ExistsInList<Observation>(a_);
		var c_ = this.Low_BMI_and_Follow_up_Provided();
		var d_ = context.Operators.ExistsInList<Observation>(c_);
		var e_ = context.Operators.Or(b_, d_);
		var f_ = this.Has_Normal_BMI();
		var g_ = context.Operators.Or(e_, f_);

		return g_;
	}

    [CqlDeclaration("Numerator")]
	public bool? Numerator() => 
		__Numerator.Value;

	private IEnumerable<object> Medical_Reason_for_Not_Documenting_a_Follow_up_Plan_for_Low_or_High_BMI_Value()
	{
		var a_ = this.Referrals_Where_Weight_Assessment_May_Occur();
		var b_ = context.Operators.RetrieveByValueSet<ServiceRequest>(a_, null);
		var d_ = context.Operators.RetrieveByValueSet<ServiceRequest>(a_, null);
		var e_ = context.Operators.ListUnion<ServiceRequest>(b_, d_);
		var f_ = this.Follow_Up_for_Above_Normal_BMI();
		var g_ = context.Operators.RetrieveByValueSet<ServiceRequest>(f_, null);
		var i_ = context.Operators.RetrieveByValueSet<ServiceRequest>(f_, null);
		var j_ = context.Operators.ListUnion<ServiceRequest>(g_, i_);
		var k_ = context.Operators.ListUnion<ServiceRequest>(e_, j_);
		var l_ = this.Follow_Up_for_Below_Normal_BMI();
		var m_ = context.Operators.RetrieveByValueSet<ServiceRequest>(l_, null);
		var o_ = context.Operators.RetrieveByValueSet<ServiceRequest>(l_, null);
		var p_ = context.Operators.ListUnion<ServiceRequest>(m_, o_);
		var q_ = context.Operators.ListUnion<ServiceRequest>(k_, p_);
		IEnumerable<ServiceRequest> r_(ServiceRequest NoBMIFollowUp)
		{
			var al_ = this.Qualifying_Encounter_during_Day_of_Measurement_Period();
			bool? am_(Encounter QualifyingEncounter)
			{
				var aq_ = context.Operators.Convert<CqlDateTime>(NoBMIFollowUp?.AuthoredOnElement);
				var ar_ = FHIRHelpers_4_3_000.ToInterval(QualifyingEncounter?.Period);
				var as_ = context.Operators.Start(ar_);
				var at_ = context.Operators.SameAs(aq_, as_, "day");

				return at_;
			};
			var an_ = context.Operators.WhereOrNull<Encounter>(al_, am_);
			ServiceRequest ao_(Encounter QualifyingEncounter) => 
				NoBMIFollowUp;
			var ap_ = context.Operators.SelectOrNull<Encounter, ServiceRequest>(an_, ao_);

			return ap_;
		};
		var s_ = context.Operators.SelectManyOrNull<ServiceRequest, ServiceRequest>(q_, r_);
		bool? t_(ServiceRequest NoBMIFollowUp)
		{
			var au_ = context.Operators.Convert<Code<RequestStatus>>(NoBMIFollowUp?.StatusElement?.Value);
			var av_ = context.Operators.Equivalent(au_, "completed");
			bool? aw_(Extension @this)
			{
				var bf_ = context.Operators.Equal(@this?.Url, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-doNotPerformReason");

				return bf_;
			};
			var ax_ = context.Operators.WhereOrNull<Extension>(((NoBMIFollowUp is DomainResource)
					? ((NoBMIFollowUp as DomainResource).Extension)
					: null), aw_);
			DataType ay_(Extension @this) => 
				@this?.Value;
			var az_ = context.Operators.SelectOrNull<Extension, DataType>(ax_, ay_);
			var ba_ = context.Operators.SingleOrNull<DataType>(az_);
			var bb_ = FHIRHelpers_4_3_000.ToConcept(ba_);
			var bc_ = this.Medical_Reason();
			var bd_ = context.Operators.ConceptInValueSet(bb_, bc_);
			var be_ = context.Operators.And(av_, bd_);

			return be_;
		};
		var u_ = context.Operators.WhereOrNull<ServiceRequest>(s_, t_);
		var v_ = this.Medications_for_Above_Normal_BMI();
		var w_ = context.Operators.RetrieveByValueSet<MedicationRequest>(v_, null);
		var y_ = context.Operators.RetrieveByValueSet<MedicationRequest>(v_, null);
		var z_ = context.Operators.ListUnion<MedicationRequest>(w_, y_);
		var aa_ = this.Medications_for_Below_Normal_BMI();
		var ab_ = context.Operators.RetrieveByValueSet<MedicationRequest>(aa_, null);
		var ad_ = context.Operators.RetrieveByValueSet<MedicationRequest>(aa_, null);
		var ae_ = context.Operators.ListUnion<MedicationRequest>(ab_, ad_);
		var af_ = context.Operators.ListUnion<MedicationRequest>(z_, ae_);
		IEnumerable<MedicationRequest> ag_(MedicationRequest NoBMIFollowUp)
		{
			var bg_ = this.Qualifying_Encounter_during_Day_of_Measurement_Period();
			bool? bh_(Encounter QualifyingEncounter)
			{
				var bl_ = context.Operators.Convert<CqlDateTime>(NoBMIFollowUp?.AuthoredOnElement);
				var bm_ = FHIRHelpers_4_3_000.ToInterval(QualifyingEncounter?.Period);
				var bn_ = context.Operators.Start(bm_);
				var bo_ = context.Operators.SameAs(bl_, bn_, "day");

				return bo_;
			};
			var bi_ = context.Operators.WhereOrNull<Encounter>(bg_, bh_);
			MedicationRequest bj_(Encounter QualifyingEncounter) => 
				NoBMIFollowUp;
			var bk_ = context.Operators.SelectOrNull<Encounter, MedicationRequest>(bi_, bj_);

			return bk_;
		};
		var ah_ = context.Operators.SelectManyOrNull<MedicationRequest, MedicationRequest>(af_, ag_);
		bool? ai_(MedicationRequest NoBMIFollowUp)
		{
			var bp_ = context.Operators.Equivalent(NoBMIFollowUp?.StatusElement?.Value, "completed");
			CqlConcept bq_(CodeableConcept @this)
			{
				var bv_ = FHIRHelpers_4_3_000.ToConcept(@this);

				return bv_;
			};
			var br_ = context.Operators.SelectOrNull<CodeableConcept, CqlConcept>(NoBMIFollowUp?.ReasonCode, bq_);
			var bs_ = this.Medical_Reason();
			var bt_ = context.Operators.ConceptsInValueSet(br_, bs_);
			var bu_ = context.Operators.And(bp_, bt_);

			return bu_;
		};
		var aj_ = context.Operators.WhereOrNull<MedicationRequest>(ah_, ai_);
		var ak_ = context.Operators.ListUnion<object>((u_ as IEnumerable<object>), (aj_ as IEnumerable<object>));

		return ak_;
	}

    [CqlDeclaration("Medical Reason for Not Documenting a Follow up Plan for Low or High BMI")]
	public IEnumerable<object> Medical_Reason_for_Not_Documenting_a_Follow_up_Plan_for_Low_or_High_BMI() => 
		__Medical_Reason_for_Not_Documenting_a_Follow_up_Plan_for_Low_or_High_BMI.Value;

	private IEnumerable<Observation> Medical_Reason_or_Patient_Reason_for_Not_Performing_BMI_Exam_Value()
	{
		var a_ = this.Body_mass_index__BMI___Ratio_();
		var b_ = context.Operators.ToList<CqlCode>(a_);
		var c_ = context.Operators.RetrieveByCodes<Observation>(b_, null);
		IEnumerable<Observation> d_(Observation NoBMI)
		{
			var h_ = this.Qualifying_Encounter_during_Day_of_Measurement_Period();
			bool? i_(Encounter QualifyingEncounter)
			{
				var m_ = FHIRHelpers_4_3_000.ToValue(NoBMI?.Effective);
				var n_ = QICoreCommon_2_0_000.toInterval(m_);
				var o_ = context.Operators.End(n_);
				var p_ = FHIRHelpers_4_3_000.ToInterval(QualifyingEncounter?.Period);
				var q_ = context.Operators.Start(p_);
				var r_ = context.Operators.SameAs(o_, q_, "day");

				return r_;
			};
			var j_ = context.Operators.WhereOrNull<Encounter>(h_, i_);
			Observation k_(Encounter QualifyingEncounter) => 
				NoBMI;
			var l_ = context.Operators.SelectOrNull<Encounter, Observation>(j_, k_);

			return l_;
		};
		var e_ = context.Operators.SelectManyOrNull<Observation, Observation>(c_, d_);
		bool? f_(Observation NoBMI)
		{
			var s_ = context.Operators.Convert<Code<ObservationStatus>>(NoBMI?.StatusElement?.Value);
			var t_ = context.Operators.Equal(s_, "cancelled");
			bool? u_(Extension @this)
			{
				var am_ = context.Operators.Equal(@this?.Url, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-notDoneReason");

				return am_;
			};
			var v_ = context.Operators.WhereOrNull<Extension>(((NoBMI is DomainResource)
					? ((NoBMI as DomainResource).Extension)
					: null), u_);
			DataType w_(Extension @this) => 
				@this?.Value;
			var x_ = context.Operators.SelectOrNull<Extension, DataType>(v_, w_);
			var y_ = context.Operators.SingleOrNull<DataType>(x_);
			var z_ = FHIRHelpers_4_3_000.ToConcept(y_);
			var aa_ = this.Patient_Declined();
			var ab_ = context.Operators.ConceptInValueSet(z_, aa_);
			bool? ac_(Extension @this)
			{
				var an_ = context.Operators.Equal(@this?.Url, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-notDoneReason");

				return an_;
			};
			var ad_ = context.Operators.WhereOrNull<Extension>(((NoBMI is DomainResource)
					? ((NoBMI as DomainResource).Extension)
					: null), ac_);
			var af_ = context.Operators.SelectOrNull<Extension, DataType>(ad_, w_);
			var ag_ = context.Operators.SingleOrNull<DataType>(af_);
			var ah_ = FHIRHelpers_4_3_000.ToConcept(ag_);
			var ai_ = this.Medical_Reason();
			var aj_ = context.Operators.ConceptInValueSet(ah_, ai_);
			var ak_ = context.Operators.Or(ab_, aj_);
			var al_ = context.Operators.And(t_, ak_);

			return al_;
		};
		var g_ = context.Operators.WhereOrNull<Observation>(e_, f_);

		return g_;
	}

    [CqlDeclaration("Medical Reason or Patient Reason for Not Performing BMI Exam")]
	public IEnumerable<Observation> Medical_Reason_or_Patient_Reason_for_Not_Performing_BMI_Exam() => 
		__Medical_Reason_or_Patient_Reason_for_Not_Performing_BMI_Exam.Value;

	private bool? Denominator_Exceptions_Value()
	{
		var a_ = this.Medical_Reason_for_Not_Documenting_a_Follow_up_Plan_for_Low_or_High_BMI();
		var b_ = context.Operators.ExistsInList<object>(a_);
		var c_ = this.Medical_Reason_or_Patient_Reason_for_Not_Performing_BMI_Exam();
		var d_ = context.Operators.ExistsInList<Observation>(c_);
		var e_ = context.Operators.Or(b_, d_);

		return e_;
	}

    [CqlDeclaration("Denominator Exceptions")]
	public bool? Denominator_Exceptions() => 
		__Denominator_Exceptions.Value;

	private Tuples.Tuple_DMgHTLENEHBHWJISQgKZGZVMB SDE_Ethnicity_Value()
	{
		var a_ = SupplementalDataElements_3_4_000.SDE_Ethnicity();

		return a_;
	}

    [CqlDeclaration("SDE Ethnicity")]
	public Tuples.Tuple_DMgHTLENEHBHWJISQgKZGZVMB SDE_Ethnicity() => 
		__SDE_Ethnicity.Value;

	private IEnumerable<Tuples.Tuple_GDKRbfOIHhLGieQSVDEMIaDPX> SDE_Payer_Value()
	{
		var a_ = SupplementalDataElements_3_4_000.SDE_Payer();

		return a_;
	}

    [CqlDeclaration("SDE Payer")]
	public IEnumerable<Tuples.Tuple_GDKRbfOIHhLGieQSVDEMIaDPX> SDE_Payer() => 
		__SDE_Payer.Value;

	private Tuples.Tuple_DMgHTLENEHBHWJISQgKZGZVMB SDE_Race_Value()
	{
		var a_ = SupplementalDataElements_3_4_000.SDE_Race();

		return a_;
	}

    [CqlDeclaration("SDE Race")]
	public Tuples.Tuple_DMgHTLENEHBHWJISQgKZGZVMB SDE_Race() => 
		__SDE_Race.Value;

	private CqlCode SDE_Sex_Value()
	{
		var a_ = SupplementalDataElements_3_4_000.SDE_Sex();

		return a_;
	}

    [CqlDeclaration("SDE Sex")]
	public CqlCode SDE_Sex() => 
		__SDE_Sex.Value;

}