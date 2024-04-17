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
[System.CodeDom.Compiler.GeneratedCode(".NET Code Generation", "2.0.0.0")]
[CqlLibrary("UrinarySymptomScoreChangeAfterBenignProstaticHyperplasiaFHIR", "1.3.000")]
public class UrinarySymptomScoreChangeAfterBenignProstaticHyperplasiaFHIR_1_3_000
{


    internal CqlContext context;

    #region Cached values

    internal Lazy<CqlValueSet> __Hospital_Services_for_urology_care;
    internal Lazy<CqlValueSet> __Morbid_Obesity;
    internal Lazy<CqlValueSet> __Office_Visit;
    internal Lazy<CqlValueSet> __Urinary_retention;
    internal Lazy<CqlCode> __American_Urological_Association_Symptom_Index__AUASI_;
    internal Lazy<CqlCode> __Benign_prostatic_hyperplasia_with_lower_urinary_tract_symptoms;
    internal Lazy<CqlCode> __If_you_were_to_spend_the_rest_of_your_life_with_your_urinary_condition_just_the_way_it_is_now__how_would_you_feel_about_that__IPSS_;
    internal Lazy<CqlCode> __International_Prostate_Symptom_Score__IPSS_;
    internal Lazy<CqlCode> __survey;
    internal Lazy<CqlCode> __virtual;
    internal Lazy<CqlCode[]> __LOINC;
    internal Lazy<CqlCode[]> __ICD10CM;
    internal Lazy<CqlCode[]> __ObservationCategoryCodes;
    internal Lazy<CqlCode[]> __ActCode;
    internal Lazy<CqlInterval<CqlDateTime>> __Measurement_Period;
    internal Lazy<Patient> __Patient;
    internal Lazy<bool?> __Patient_is_Male;
    internal Lazy<bool?> __Has_Qualifying_Encounter;
    internal Lazy<Condition> __Initial_BPH_Diagnosis_Starts_Within_6_Months_Before_or_After_Start_of_Measurement_Period;
    internal Lazy<bool?> __Has_Qualifying_BPH_Diagnosis;
    internal Lazy<IEnumerable<Tuples.Tuple_HHCMSSZgDEUSHVCefGhfGYQZI>> __Documented_IPSS_Assessment_Result;
    internal Lazy<IEnumerable<Tuples.Tuple_HHCMSSZgDEUSHVCefGhfGYQZI>> __AUA_Symptom_Index_and_Quality_of_Life_Assessment_Result;
    internal Lazy<IEnumerable<Tuples.Tuple_HHCMSSZgDEUSHVCefGhfGYQZI>> __Urinary_Symptom_Score_Assessment;
    internal Lazy<Tuples.Tuple_HHCMSSZgDEUSHVCefGhfGYQZI> __Urinary_Symptom_Score_Within_1_Month_after_Initial_BPH_Diagnosis;
    internal Lazy<Tuples.Tuple_HHCMSSZgDEUSHVCefGhfGYQZI> __Urinary_Symptom_Score_6_to_12_Months_After_Initial_BPH_Diagnosis;
    internal Lazy<bool?> __Initial_Population;
    internal Lazy<bool?> __Denominator;
    internal Lazy<IEnumerable<Condition>> __Urinary_Retention_Diagnosis_Starts_Within_1_Year_After_Initial_BPH_Diagnosis;
    internal Lazy<Condition> __Initial_BPH_Diagnosis_Starts_During_or_Within_30_Days_After_End_of_Hospitalization;
    internal Lazy<IEnumerable<Condition>> __Morbid_Obesity_Diagnosis_On_or_Before_Follow_Up_USS_Assessment;
    internal Lazy<bool?> __Has_BMI_Exam_Result_Greater_Than_or_Equal_To_40_During_Measurement_Period_and_On_or_Before_Follow_Up_USS_Assessment;
    internal Lazy<bool?> __Has_Morbid_Obesity_Diagnosis_or_BMI_Exam_Result__Greater_Than_or_Equal_to_40_Starts_On_or_Before_Follow_Up_USS_Assessment;
    internal Lazy<bool?> __Denominator_Exclusions;
    internal Lazy<int?> __Urinary_Symptom_Score_Change;
    internal Lazy<bool?> __Has_Urinary_Symptom_Score_Improvement_Greater_Than_or_Equal_To_3;
    internal Lazy<bool?> __Numerator;
    internal Lazy<Tuples.Tuple_DMgHTLENEHBHWJISQgKZGZVMB> __SDE_Ethnicity;
    internal Lazy<IEnumerable<Tuples.Tuple_GDKRbfOIHhLGieQSVDEMIaDPX>> __SDE_Payer;
    internal Lazy<Tuples.Tuple_DMgHTLENEHBHWJISQgKZGZVMB> __SDE_Race;
    internal Lazy<CqlCode> __SDE_Sex;

    #endregion
    public UrinarySymptomScoreChangeAfterBenignProstaticHyperplasiaFHIR_1_3_000(CqlContext context)
    {
        this.context = context ?? throw new ArgumentNullException("context");

        FHIRHelpers_4_3_000 = new FHIRHelpers_4_3_000(context);
        SupplementalDataElements_3_4_000 = new SupplementalDataElements_3_4_000(context);
        QICoreCommon_2_0_000 = new QICoreCommon_2_0_000(context);

        __Hospital_Services_for_urology_care = new Lazy<CqlValueSet>(this.Hospital_Services_for_urology_care_Value);
        __Morbid_Obesity = new Lazy<CqlValueSet>(this.Morbid_Obesity_Value);
        __Office_Visit = new Lazy<CqlValueSet>(this.Office_Visit_Value);
        __Urinary_retention = new Lazy<CqlValueSet>(this.Urinary_retention_Value);
        __American_Urological_Association_Symptom_Index__AUASI_ = new Lazy<CqlCode>(this.American_Urological_Association_Symptom_Index__AUASI__Value);
        __Benign_prostatic_hyperplasia_with_lower_urinary_tract_symptoms = new Lazy<CqlCode>(this.Benign_prostatic_hyperplasia_with_lower_urinary_tract_symptoms_Value);
        __If_you_were_to_spend_the_rest_of_your_life_with_your_urinary_condition_just_the_way_it_is_now__how_would_you_feel_about_that__IPSS_ = new Lazy<CqlCode>(this.If_you_were_to_spend_the_rest_of_your_life_with_your_urinary_condition_just_the_way_it_is_now__how_would_you_feel_about_that__IPSS__Value);
        __International_Prostate_Symptom_Score__IPSS_ = new Lazy<CqlCode>(this.International_Prostate_Symptom_Score__IPSS__Value);
        __survey = new Lazy<CqlCode>(this.survey_Value);
        __virtual = new Lazy<CqlCode>(this.@virtual_Value);
        __LOINC = new Lazy<CqlCode[]>(this.LOINC_Value);
        __ICD10CM = new Lazy<CqlCode[]>(this.ICD10CM_Value);
        __ObservationCategoryCodes = new Lazy<CqlCode[]>(this.ObservationCategoryCodes_Value);
        __ActCode = new Lazy<CqlCode[]>(this.ActCode_Value);
        __Measurement_Period = new Lazy<CqlInterval<CqlDateTime>>(this.Measurement_Period_Value);
        __Patient = new Lazy<Patient>(this.Patient_Value);
        __Patient_is_Male = new Lazy<bool?>(this.Patient_is_Male_Value);
        __Has_Qualifying_Encounter = new Lazy<bool?>(this.Has_Qualifying_Encounter_Value);
        __Initial_BPH_Diagnosis_Starts_Within_6_Months_Before_or_After_Start_of_Measurement_Period = new Lazy<Condition>(this.Initial_BPH_Diagnosis_Starts_Within_6_Months_Before_or_After_Start_of_Measurement_Period_Value);
        __Has_Qualifying_BPH_Diagnosis = new Lazy<bool?>(this.Has_Qualifying_BPH_Diagnosis_Value);
        __Documented_IPSS_Assessment_Result = new Lazy<IEnumerable<Tuples.Tuple_HHCMSSZgDEUSHVCefGhfGYQZI>>(this.Documented_IPSS_Assessment_Result_Value);
        __AUA_Symptom_Index_and_Quality_of_Life_Assessment_Result = new Lazy<IEnumerable<Tuples.Tuple_HHCMSSZgDEUSHVCefGhfGYQZI>>(this.AUA_Symptom_Index_and_Quality_of_Life_Assessment_Result_Value);
        __Urinary_Symptom_Score_Assessment = new Lazy<IEnumerable<Tuples.Tuple_HHCMSSZgDEUSHVCefGhfGYQZI>>(this.Urinary_Symptom_Score_Assessment_Value);
        __Urinary_Symptom_Score_Within_1_Month_after_Initial_BPH_Diagnosis = new Lazy<Tuples.Tuple_HHCMSSZgDEUSHVCefGhfGYQZI>(this.Urinary_Symptom_Score_Within_1_Month_after_Initial_BPH_Diagnosis_Value);
        __Urinary_Symptom_Score_6_to_12_Months_After_Initial_BPH_Diagnosis = new Lazy<Tuples.Tuple_HHCMSSZgDEUSHVCefGhfGYQZI>(this.Urinary_Symptom_Score_6_to_12_Months_After_Initial_BPH_Diagnosis_Value);
        __Initial_Population = new Lazy<bool?>(this.Initial_Population_Value);
        __Denominator = new Lazy<bool?>(this.Denominator_Value);
        __Urinary_Retention_Diagnosis_Starts_Within_1_Year_After_Initial_BPH_Diagnosis = new Lazy<IEnumerable<Condition>>(this.Urinary_Retention_Diagnosis_Starts_Within_1_Year_After_Initial_BPH_Diagnosis_Value);
        __Initial_BPH_Diagnosis_Starts_During_or_Within_30_Days_After_End_of_Hospitalization = new Lazy<Condition>(this.Initial_BPH_Diagnosis_Starts_During_or_Within_30_Days_After_End_of_Hospitalization_Value);
        __Morbid_Obesity_Diagnosis_On_or_Before_Follow_Up_USS_Assessment = new Lazy<IEnumerable<Condition>>(this.Morbid_Obesity_Diagnosis_On_or_Before_Follow_Up_USS_Assessment_Value);
        __Has_BMI_Exam_Result_Greater_Than_or_Equal_To_40_During_Measurement_Period_and_On_or_Before_Follow_Up_USS_Assessment = new Lazy<bool?>(this.Has_BMI_Exam_Result_Greater_Than_or_Equal_To_40_During_Measurement_Period_and_On_or_Before_Follow_Up_USS_Assessment_Value);
        __Has_Morbid_Obesity_Diagnosis_or_BMI_Exam_Result__Greater_Than_or_Equal_to_40_Starts_On_or_Before_Follow_Up_USS_Assessment = new Lazy<bool?>(this.Has_Morbid_Obesity_Diagnosis_or_BMI_Exam_Result__Greater_Than_or_Equal_to_40_Starts_On_or_Before_Follow_Up_USS_Assessment_Value);
        __Denominator_Exclusions = new Lazy<bool?>(this.Denominator_Exclusions_Value);
        __Urinary_Symptom_Score_Change = new Lazy<int?>(this.Urinary_Symptom_Score_Change_Value);
        __Has_Urinary_Symptom_Score_Improvement_Greater_Than_or_Equal_To_3 = new Lazy<bool?>(this.Has_Urinary_Symptom_Score_Improvement_Greater_Than_or_Equal_To_3_Value);
        __Numerator = new Lazy<bool?>(this.Numerator_Value);
        __SDE_Ethnicity = new Lazy<Tuples.Tuple_DMgHTLENEHBHWJISQgKZGZVMB>(this.SDE_Ethnicity_Value);
        __SDE_Payer = new Lazy<IEnumerable<Tuples.Tuple_GDKRbfOIHhLGieQSVDEMIaDPX>>(this.SDE_Payer_Value);
        __SDE_Race = new Lazy<Tuples.Tuple_DMgHTLENEHBHWJISQgKZGZVMB>(this.SDE_Race_Value);
        __SDE_Sex = new Lazy<CqlCode>(this.SDE_Sex_Value);
    }
    #region Dependencies

    public FHIRHelpers_4_3_000 FHIRHelpers_4_3_000 { get; }
    public SupplementalDataElements_3_4_000 SupplementalDataElements_3_4_000 { get; }
    public QICoreCommon_2_0_000 QICoreCommon_2_0_000 { get; }

    #endregion

	private CqlValueSet Hospital_Services_for_urology_care_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1164.64", null);

    [CqlDeclaration("Hospital Services for urology care")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1164.64")]
	public CqlValueSet Hospital_Services_for_urology_care() => 
		__Hospital_Services_for_urology_care.Value;

	private CqlValueSet Morbid_Obesity_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1164.67", null);

    [CqlDeclaration("Morbid Obesity")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1164.67")]
	public CqlValueSet Morbid_Obesity() => 
		__Morbid_Obesity.Value;

	private CqlValueSet Office_Visit_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1001", null);

    [CqlDeclaration("Office Visit")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1001")]
	public CqlValueSet Office_Visit() => 
		__Office_Visit.Value;

	private CqlValueSet Urinary_retention_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1164.52", null);

    [CqlDeclaration("Urinary retention")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1164.52")]
	public CqlValueSet Urinary_retention() => 
		__Urinary_retention.Value;

	private CqlCode American_Urological_Association_Symptom_Index__AUASI__Value() => 
		new CqlCode("80883-2", "http://loinc.org", null, null);

    [CqlDeclaration("American Urological Association Symptom Index [AUASI]")]
	public CqlCode American_Urological_Association_Symptom_Index__AUASI_() => 
		__American_Urological_Association_Symptom_Index__AUASI_.Value;

	private CqlCode Benign_prostatic_hyperplasia_with_lower_urinary_tract_symptoms_Value() => 
		new CqlCode("N40.1", "http://hl7.org/fhir/sid/icd-10-cm", null, null);

    [CqlDeclaration("Benign prostatic hyperplasia with lower urinary tract symptoms")]
	public CqlCode Benign_prostatic_hyperplasia_with_lower_urinary_tract_symptoms() => 
		__Benign_prostatic_hyperplasia_with_lower_urinary_tract_symptoms.Value;

	private CqlCode If_you_were_to_spend_the_rest_of_your_life_with_your_urinary_condition_just_the_way_it_is_now__how_would_you_feel_about_that__IPSS__Value() => 
		new CqlCode("81090-3", "http://loinc.org", null, null);

    [CqlDeclaration("If you were to spend the rest of your life with your urinary condition just the way it is now, how would you feel about that [IPSS]")]
	public CqlCode If_you_were_to_spend_the_rest_of_your_life_with_your_urinary_condition_just_the_way_it_is_now__how_would_you_feel_about_that__IPSS_() => 
		__If_you_were_to_spend_the_rest_of_your_life_with_your_urinary_condition_just_the_way_it_is_now__how_would_you_feel_about_that__IPSS_.Value;

	private CqlCode International_Prostate_Symptom_Score__IPSS__Value() => 
		new CqlCode("80976-4", "http://loinc.org", null, null);

    [CqlDeclaration("International Prostate Symptom Score [IPSS]")]
	public CqlCode International_Prostate_Symptom_Score__IPSS_() => 
		__International_Prostate_Symptom_Score__IPSS_.Value;

	private CqlCode survey_Value() => 
		new CqlCode("survey", "http://terminology.hl7.org/CodeSystem/observation-category", null, null);

    [CqlDeclaration("survey")]
	public CqlCode survey() => 
		__survey.Value;

	private CqlCode @virtual_Value() => 
		new CqlCode("VR", "http://terminology.hl7.org/CodeSystem/v3-ActCode", null, null);

    [CqlDeclaration("virtual")]
	public CqlCode @virtual() => 
		__virtual.Value;

	private CqlCode[] LOINC_Value()
	{
		var a_ = new CqlCode[]
		{
			new CqlCode("80883-2", "http://loinc.org", null, null),
			new CqlCode("81090-3", "http://loinc.org", null, null),
			new CqlCode("80976-4", "http://loinc.org", null, null),
		};

		return a_;
	}

    [CqlDeclaration("LOINC")]
	public CqlCode[] LOINC() => 
		__LOINC.Value;

	private CqlCode[] ICD10CM_Value()
	{
		var a_ = new CqlCode[]
		{
			new CqlCode("N40.1", "http://hl7.org/fhir/sid/icd-10-cm", null, null),
		};

		return a_;
	}

    [CqlDeclaration("ICD10CM")]
	public CqlCode[] ICD10CM() => 
		__ICD10CM.Value;

	private CqlCode[] ObservationCategoryCodes_Value()
	{
		var a_ = new CqlCode[]
		{
			new CqlCode("survey", "http://terminology.hl7.org/CodeSystem/observation-category", null, null),
		};

		return a_;
	}

    [CqlDeclaration("ObservationCategoryCodes")]
	public CqlCode[] ObservationCategoryCodes() => 
		__ObservationCategoryCodes.Value;

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

	private CqlInterval<CqlDateTime> Measurement_Period_Value()
	{
		var a_ = context.Operators.ConvertIntegerToDecimal(default);
		var b_ = context.Operators.DateTime((int?)2025, (int?)1, (int?)1, (int?)0, (int?)0, (int?)0, (int?)0, a_);
		var d_ = context.Operators.DateTime((int?)2026, (int?)1, (int?)1, (int?)0, (int?)0, (int?)0, (int?)0, a_);
		var e_ = context.Operators.Interval(b_, d_, true, false);
		var f_ = context.ResolveParameter("UrinarySymptomScoreChangeAfterBenignProstaticHyperplasiaFHIR-1.3.000", "Measurement Period", e_);

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

	private bool? Patient_is_Male_Value()
	{
		var a_ = this.Patient();
		var b_ = context.Operators.EnumEqualsString(a_?.GenderElement?.Value, "male");

		return b_;
	}

    [CqlDeclaration("Patient is Male")]
	public bool? Patient_is_Male() => 
		__Patient_is_Male.Value;

	private bool? Has_Qualifying_Encounter_Value()
	{
		var a_ = this.Office_Visit();
		var b_ = context.Operators.RetrieveByValueSet<Encounter>(a_, null);
		bool? c_(Encounter ValidEncounter)
		{
			var f_ = this.Measurement_Period();
			var g_ = FHIRHelpers_4_3_000.ToInterval(ValidEncounter?.Period);
			var h_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(f_, g_, "day");
			var i_ = FHIRHelpers_4_3_000.ToCode(ValidEncounter?.Class);
			var j_ = this.@virtual();
			var k_ = context.Operators.Equivalent(i_, j_);
			var l_ = context.Operators.Not(k_);
			var m_ = context.Operators.And(h_, l_);
			var n_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(ValidEncounter?.StatusElement?.Value);
			var o_ = context.Operators.Equal(n_, "finished");
			var p_ = context.Operators.And(m_, o_);

			return p_;
		};
		var d_ = context.Operators.WhereOrNull<Encounter>(b_, c_);
		var e_ = context.Operators.ExistsInList<Encounter>(d_);

		return e_;
	}

    [CqlDeclaration("Has Qualifying Encounter")]
	public bool? Has_Qualifying_Encounter() => 
		__Has_Qualifying_Encounter.Value;

    [CqlDeclaration("isConfirmedActiveDiagnosis")]
	public bool? isConfirmedActiveDiagnosis(Condition Condition)
	{
		var a_ = new Condition[]
		{
			Condition,
		};
		bool? b_(Condition Diagnosis)
		{
			var f_ = FHIRHelpers_4_3_000.ToConcept(Diagnosis?.ClinicalStatus);
			var g_ = QICoreCommon_2_0_000.active();
			var h_ = context.Operators.ConvertCodeToConcept(g_);
			var i_ = context.Operators.Equivalent(f_, h_);
			var j_ = FHIRHelpers_4_3_000.ToConcept(Diagnosis?.VerificationStatus);
			var k_ = QICoreCommon_2_0_000.unconfirmed();
			var l_ = context.Operators.ConvertCodeToConcept(k_);
			var m_ = context.Operators.Equivalent(j_, l_);
			var o_ = QICoreCommon_2_0_000.refuted();
			var p_ = context.Operators.ConvertCodeToConcept(o_);
			var q_ = context.Operators.Equivalent(j_, p_);
			var r_ = context.Operators.Or(m_, q_);
			var t_ = QICoreCommon_2_0_000.entered_in_error();
			var u_ = context.Operators.ConvertCodeToConcept(t_);
			var v_ = context.Operators.Equivalent(j_, u_);
			var w_ = context.Operators.Or(r_, v_);
			var x_ = context.Operators.Not(w_);
			var y_ = context.Operators.And(i_, x_);

			return y_;
		};
		var c_ = context.Operators.WhereOrNull<Condition>(a_, b_);
		var d_ = context.Operators.SingleOrNull<Condition>(c_);
		var e_ = context.Operators.Not((bool?)(d_ is null));

		return e_;
	}

	private Condition Initial_BPH_Diagnosis_Starts_Within_6_Months_Before_or_After_Start_of_Measurement_Period_Value()
	{
		var a_ = this.Benign_prostatic_hyperplasia_with_lower_urinary_tract_symptoms();
		var b_ = context.Operators.ToList<CqlCode>(a_);
		var c_ = context.Operators.RetrieveByCodes<Condition>(b_, null);
		bool? d_(Condition NewBPHDiagnosis)
		{
			var i_ = QICoreCommon_2_0_000.prevalenceInterval(NewBPHDiagnosis);
			var j_ = context.Operators.Start(i_);
			var k_ = this.Measurement_Period();
			var l_ = context.Operators.Start(k_);
			var m_ = context.Operators.Quantity((decimal?)6m, "months");
			var n_ = context.Operators.Subtract(l_, m_);
			var p_ = context.Operators.End(k_);
			var q_ = context.Operators.Interval(n_, p_, true, true);
			var r_ = context.Operators.ElementInInterval<CqlDateTime>(j_, q_, "day");
			var s_ = this.isConfirmedActiveDiagnosis(NewBPHDiagnosis);
			var t_ = context.Operators.And(r_, s_);

			return t_;
		};
		var e_ = context.Operators.WhereOrNull<Condition>(c_, d_);
		object f_(Condition @this)
		{
			var u_ = FHIRHelpers_4_3_000.ToValue(@this?.Onset);
			var v_ = QICoreCommon_2_0_000.toInterval(u_);
			var w_ = context.Operators.Start(v_);

			return w_;
		};
		var g_ = context.Operators.ListSortBy<Condition>(e_, f_, System.ComponentModel.ListSortDirection.Ascending);
		var h_ = context.Operators.FirstOfList<Condition>(g_);

		return h_;
	}

    [CqlDeclaration("Initial BPH Diagnosis Starts Within 6 Months Before or After Start of Measurement Period")]
	public Condition Initial_BPH_Diagnosis_Starts_Within_6_Months_Before_or_After_Start_of_Measurement_Period() => 
		__Initial_BPH_Diagnosis_Starts_Within_6_Months_Before_or_After_Start_of_Measurement_Period.Value;

	private bool? Has_Qualifying_BPH_Diagnosis_Value()
	{
		var a_ = this.Initial_BPH_Diagnosis_Starts_Within_6_Months_Before_or_After_Start_of_Measurement_Period();
		var b_ = context.Operators.Not((bool?)(a_ is null));

		return b_;
	}

    [CqlDeclaration("Has Qualifying BPH Diagnosis")]
	public bool? Has_Qualifying_BPH_Diagnosis() => 
		__Has_Qualifying_BPH_Diagnosis.Value;

	private IEnumerable<Tuples.Tuple_HHCMSSZgDEUSHVCefGhfGYQZI> Documented_IPSS_Assessment_Result_Value()
	{
		var a_ = this.International_Prostate_Symptom_Score__IPSS_();
		var b_ = context.Operators.ToList<CqlCode>(a_);
		var c_ = context.Operators.RetrieveByCodes<Observation>(b_, null);
		bool? d_(Observation IPSSAssessment)
		{
			var h_ = context.Operators.Convert<Code<ObservationStatus>>(IPSSAssessment?.StatusElement?.Value);
			var i_ = context.Operators.Convert<string>(h_);
			var j_ = new string[]
			{
				"final",
				"amended",
				"corrected",
			};
			var k_ = context.Operators.InList<string>(i_, (j_ as IEnumerable<string>));
			var l_ = FHIRHelpers_4_3_000.ToValue(IPSSAssessment?.Value);
			var m_ = context.Operators.Not((bool?)(l_ is null));
			var n_ = context.Operators.And(k_, m_);

			return n_;
		};
		var e_ = context.Operators.WhereOrNull<Observation>(c_, d_);
		Tuples.Tuple_HHCMSSZgDEUSHVCefGhfGYQZI f_(Observation IPSSAssessment)
		{
			object o_()
			{
				bool s_()
				{
					var v_ = FHIRHelpers_4_3_000.ToValue(IPSSAssessment?.Effective);
					var w_ = v_ is CqlDateTime;

					return w_;
				};
				bool t_()
				{
					var x_ = FHIRHelpers_4_3_000.ToValue(IPSSAssessment?.Effective);
					var y_ = x_ is CqlInterval<CqlDateTime>;

					return y_;
				};
				bool u_()
				{
					var z_ = FHIRHelpers_4_3_000.ToValue(IPSSAssessment?.Effective);
					var aa_ = z_ is CqlDateTime;

					return aa_;
				};
				if (s_())
				{
					var ab_ = FHIRHelpers_4_3_000.ToValue(IPSSAssessment?.Effective);

					return ((ab_ as CqlDateTime) as object);
				}
				else if (t_())
				{
					var ac_ = FHIRHelpers_4_3_000.ToValue(IPSSAssessment?.Effective);

					return ((ac_ as CqlInterval<CqlDateTime>) as object);
				}
				else if (u_())
				{
					var ad_ = FHIRHelpers_4_3_000.ToValue(IPSSAssessment?.Effective);

					return ((ad_ as CqlDateTime) as object);
				}
				else
				{
					return null;
				};
			};
			var p_ = QICoreCommon_2_0_000.earliest(o_());
			var q_ = FHIRHelpers_4_3_000.ToValue(IPSSAssessment?.Value);
			var r_ = new Tuples.Tuple_HHCMSSZgDEUSHVCefGhfGYQZI
			{
				effectiveDatetime = p_,
				valueInteger = (int?)q_,
			};

			return r_;
		};
		var g_ = context.Operators.SelectOrNull<Observation, Tuples.Tuple_HHCMSSZgDEUSHVCefGhfGYQZI>(e_, f_);

		return g_;
	}

    [CqlDeclaration("Documented IPSS Assessment Result")]
	public IEnumerable<Tuples.Tuple_HHCMSSZgDEUSHVCefGhfGYQZI> Documented_IPSS_Assessment_Result() => 
		__Documented_IPSS_Assessment_Result.Value;

	private IEnumerable<Tuples.Tuple_HHCMSSZgDEUSHVCefGhfGYQZI> AUA_Symptom_Index_and_Quality_of_Life_Assessment_Result_Value()
	{
		var a_ = this.American_Urological_Association_Symptom_Index__AUASI_();
		var b_ = context.Operators.ToList<CqlCode>(a_);
		var c_ = context.Operators.RetrieveByCodes<Observation>(b_, null);
		bool? d_(Observation AUASIAssessment)
		{
			CqlConcept h_(CodeableConcept @this)
			{
				var u_ = FHIRHelpers_4_3_000.ToConcept(@this);

				return u_;
			};
			var i_ = context.Operators.SelectOrNull<CodeableConcept, CqlConcept>(AUASIAssessment?.Category, h_);
			bool? j_(CqlConcept AUASIAssessmentCategory)
			{
				var v_ = this.survey();
				var w_ = context.Operators.ConvertCodeToConcept(v_);
				var x_ = context.Operators.Equivalent(AUASIAssessmentCategory, w_);

				return x_;
			};
			var k_ = context.Operators.WhereOrNull<CqlConcept>(i_, j_);
			var l_ = context.Operators.ExistsInList<CqlConcept>(k_);
			var m_ = context.Operators.Convert<Code<ObservationStatus>>(AUASIAssessment?.StatusElement?.Value);
			var n_ = context.Operators.Convert<string>(m_);
			var o_ = new string[]
			{
				"final",
				"amended",
				"corrected",
			};
			var p_ = context.Operators.InList<string>(n_, (o_ as IEnumerable<string>));
			var q_ = context.Operators.And(l_, p_);
			var r_ = FHIRHelpers_4_3_000.ToValue(AUASIAssessment?.Value);
			var s_ = context.Operators.Not((bool?)(r_ is null));
			var t_ = context.Operators.And(q_, s_);

			return t_;
		};
		var e_ = context.Operators.WhereOrNull<Observation>(c_, d_);
		Tuples.Tuple_HHCMSSZgDEUSHVCefGhfGYQZI f_(Observation AUASIAssessment)
		{
			object y_()
			{
				bool am_()
				{
					var ap_ = FHIRHelpers_4_3_000.ToValue(AUASIAssessment?.Effective);
					var aq_ = ap_ is CqlDateTime;

					return aq_;
				};
				bool an_()
				{
					var ar_ = FHIRHelpers_4_3_000.ToValue(AUASIAssessment?.Effective);
					var as_ = ar_ is CqlInterval<CqlDateTime>;

					return as_;
				};
				bool ao_()
				{
					var at_ = FHIRHelpers_4_3_000.ToValue(AUASIAssessment?.Effective);
					var au_ = at_ is CqlDateTime;

					return au_;
				};
				if (am_())
				{
					var av_ = FHIRHelpers_4_3_000.ToValue(AUASIAssessment?.Effective);

					return ((av_ as CqlDateTime) as object);
				}
				else if (an_())
				{
					var aw_ = FHIRHelpers_4_3_000.ToValue(AUASIAssessment?.Effective);

					return ((aw_ as CqlInterval<CqlDateTime>) as object);
				}
				else if (ao_())
				{
					var ax_ = FHIRHelpers_4_3_000.ToValue(AUASIAssessment?.Effective);

					return ((ax_ as CqlDateTime) as object);
				}
				else
				{
					return null;
				};
			};
			var z_ = QICoreCommon_2_0_000.earliest(y_());
			var aa_ = FHIRHelpers_4_3_000.ToValue(AUASIAssessment?.Value);
			var ab_ = this.If_you_were_to_spend_the_rest_of_your_life_with_your_urinary_condition_just_the_way_it_is_now__how_would_you_feel_about_that__IPSS_();
			var ac_ = context.Operators.ToList<CqlCode>(ab_);
			var ad_ = context.Operators.RetrieveByCodes<Observation>(ac_, null);
			bool? ae_(Observation QOLAssessment)
			{
				object ay_()
				{
					bool br_()
					{
						var bu_ = FHIRHelpers_4_3_000.ToValue(QOLAssessment?.Effective);
						var bv_ = bu_ is CqlDateTime;

						return bv_;
					};
					bool bs_()
					{
						var bw_ = FHIRHelpers_4_3_000.ToValue(QOLAssessment?.Effective);
						var bx_ = bw_ is CqlInterval<CqlDateTime>;

						return bx_;
					};
					bool bt_()
					{
						var by_ = FHIRHelpers_4_3_000.ToValue(QOLAssessment?.Effective);
						var bz_ = by_ is CqlDateTime;

						return bz_;
					};
					if (br_())
					{
						var ca_ = FHIRHelpers_4_3_000.ToValue(QOLAssessment?.Effective);

						return ((ca_ as CqlDateTime) as object);
					}
					else if (bs_())
					{
						var cb_ = FHIRHelpers_4_3_000.ToValue(QOLAssessment?.Effective);

						return ((cb_ as CqlInterval<CqlDateTime>) as object);
					}
					else if (bt_())
					{
						var cc_ = FHIRHelpers_4_3_000.ToValue(QOLAssessment?.Effective);

						return ((cc_ as CqlDateTime) as object);
					}
					else
					{
						return null;
					};
				};
				var az_ = QICoreCommon_2_0_000.earliest(ay_());
				object ba_()
				{
					bool cd_()
					{
						var cg_ = FHIRHelpers_4_3_000.ToValue(QOLAssessment?.Effective);
						var ch_ = cg_ is CqlDateTime;

						return ch_;
					};
					bool ce_()
					{
						var ci_ = FHIRHelpers_4_3_000.ToValue(QOLAssessment?.Effective);
						var cj_ = ci_ is CqlInterval<CqlDateTime>;

						return cj_;
					};
					bool cf_()
					{
						var ck_ = FHIRHelpers_4_3_000.ToValue(QOLAssessment?.Effective);
						var cl_ = ck_ is CqlDateTime;

						return cl_;
					};
					if (cd_())
					{
						var cm_ = FHIRHelpers_4_3_000.ToValue(QOLAssessment?.Effective);

						return ((cm_ as CqlDateTime) as object);
					}
					else if (ce_())
					{
						var cn_ = FHIRHelpers_4_3_000.ToValue(QOLAssessment?.Effective);

						return ((cn_ as CqlInterval<CqlDateTime>) as object);
					}
					else if (cf_())
					{
						var co_ = FHIRHelpers_4_3_000.ToValue(QOLAssessment?.Effective);

						return ((co_ as CqlDateTime) as object);
					}
					else
					{
						return null;
					};
				};
				var bb_ = QICoreCommon_2_0_000.earliest(ba_());
				var bc_ = context.Operators.SameAs(az_, bb_, "day");
				CqlConcept bd_(CodeableConcept @this)
				{
					var cp_ = FHIRHelpers_4_3_000.ToConcept(@this);

					return cp_;
				};
				var be_ = context.Operators.SelectOrNull<CodeableConcept, CqlConcept>(QOLAssessment?.Category, bd_);
				bool? bf_(CqlConcept QOLAssessmentCategory)
				{
					var cq_ = this.survey();
					var cr_ = context.Operators.ConvertCodeToConcept(cq_);
					var cs_ = context.Operators.Equivalent(QOLAssessmentCategory, cr_);

					return cs_;
				};
				var bg_ = context.Operators.WhereOrNull<CqlConcept>(be_, bf_);
				var bh_ = context.Operators.ExistsInList<CqlConcept>(bg_);
				var bi_ = context.Operators.And(bc_, bh_);
				var bj_ = context.Operators.Convert<Code<ObservationStatus>>(QOLAssessment?.StatusElement?.Value);
				var bk_ = context.Operators.Convert<string>(bj_);
				var bl_ = new string[]
				{
					"final",
					"amended",
					"corrected",
				};
				var bm_ = context.Operators.InList<string>(bk_, (bl_ as IEnumerable<string>));
				var bn_ = context.Operators.And(bi_, bm_);
				var bo_ = FHIRHelpers_4_3_000.ToValue(QOLAssessment?.Value);
				var bp_ = context.Operators.Not((bool?)(bo_ is null));
				var bq_ = context.Operators.And(bn_, bp_);

				return bq_;
			};
			var af_ = context.Operators.WhereOrNull<Observation>(ad_, ae_);
			object ag_(Observation @this)
			{
				object ct_()
				{
					bool cv_()
					{
						var cy_ = FHIRHelpers_4_3_000.ToValue(@this?.Effective);
						var cz_ = cy_ is CqlDateTime;

						return cz_;
					};
					bool cw_()
					{
						var da_ = FHIRHelpers_4_3_000.ToValue(@this?.Effective);
						var db_ = da_ is CqlInterval<CqlDateTime>;

						return db_;
					};
					bool cx_()
					{
						var dc_ = FHIRHelpers_4_3_000.ToValue(@this?.Effective);
						var dd_ = dc_ is CqlDateTime;

						return dd_;
					};
					if (cv_())
					{
						var de_ = FHIRHelpers_4_3_000.ToValue(@this?.Effective);

						return ((de_ as CqlDateTime) as object);
					}
					else if (cw_())
					{
						var df_ = FHIRHelpers_4_3_000.ToValue(@this?.Effective);

						return ((df_ as CqlInterval<CqlDateTime>) as object);
					}
					else if (cx_())
					{
						var dg_ = FHIRHelpers_4_3_000.ToValue(@this?.Effective);

						return ((dg_ as CqlDateTime) as object);
					}
					else
					{
						return null;
					};
				};
				var cu_ = QICoreCommon_2_0_000.earliest(ct_());

				return cu_;
			};
			var ah_ = context.Operators.ListSortBy<Observation>(af_, ag_, System.ComponentModel.ListSortDirection.Ascending);
			var ai_ = context.Operators.LastOfList<Observation>(ah_);
			var aj_ = FHIRHelpers_4_3_000.ToValue(ai_?.Value);
			var ak_ = context.Operators.Add((int?)aa_, (int?)aj_);
			var al_ = new Tuples.Tuple_HHCMSSZgDEUSHVCefGhfGYQZI
			{
				effectiveDatetime = z_,
				valueInteger = ak_,
			};

			return al_;
		};
		var g_ = context.Operators.SelectOrNull<Observation, Tuples.Tuple_HHCMSSZgDEUSHVCefGhfGYQZI>(e_, f_);

		return g_;
	}

    [CqlDeclaration("AUA Symptom Index and Quality of Life Assessment Result")]
	public IEnumerable<Tuples.Tuple_HHCMSSZgDEUSHVCefGhfGYQZI> AUA_Symptom_Index_and_Quality_of_Life_Assessment_Result() => 
		__AUA_Symptom_Index_and_Quality_of_Life_Assessment_Result.Value;

	private IEnumerable<Tuples.Tuple_HHCMSSZgDEUSHVCefGhfGYQZI> Urinary_Symptom_Score_Assessment_Value()
	{
		var a_ = this.Documented_IPSS_Assessment_Result();
		var b_ = this.AUA_Symptom_Index_and_Quality_of_Life_Assessment_Result();
		var c_ = context.Operators.ListUnion<Tuples.Tuple_HHCMSSZgDEUSHVCefGhfGYQZI>(a_, b_);

		return c_;
	}

    [CqlDeclaration("Urinary Symptom Score Assessment")]
	public IEnumerable<Tuples.Tuple_HHCMSSZgDEUSHVCefGhfGYQZI> Urinary_Symptom_Score_Assessment() => 
		__Urinary_Symptom_Score_Assessment.Value;

	private Tuples.Tuple_HHCMSSZgDEUSHVCefGhfGYQZI Urinary_Symptom_Score_Within_1_Month_after_Initial_BPH_Diagnosis_Value()
	{
		var a_ = this.Urinary_Symptom_Score_Assessment();
		IEnumerable<Tuples.Tuple_HHCMSSZgDEUSHVCefGhfGYQZI> b_(Tuples.Tuple_HHCMSSZgDEUSHVCefGhfGYQZI USSAssessment)
		{
			var g_ = this.Initial_BPH_Diagnosis_Starts_Within_6_Months_Before_or_After_Start_of_Measurement_Period();
			var h_ = new Condition[]
			{
				g_,
			};
			bool? i_(Condition InitialBPHDiagnosis)
			{
				var m_ = QICoreCommon_2_0_000.prevalenceInterval(InitialBPHDiagnosis);
				var n_ = context.Operators.Start(m_);
				var p_ = context.Operators.Start(m_);
				var q_ = context.Operators.Quantity((decimal?)1m, "month");
				var r_ = context.Operators.Add(p_, q_);
				var s_ = context.Operators.Interval(n_, r_, true, true);
				var t_ = context.Operators.ElementInInterval<CqlDateTime>(USSAssessment?.effectiveDatetime, s_, "day");
				var v_ = context.Operators.Start(m_);
				var w_ = context.Operators.Not((bool?)(v_ is null));
				var x_ = context.Operators.And(t_, w_);

				return x_;
			};
			var j_ = context.Operators.WhereOrNull<Condition>(h_, i_);
			Tuples.Tuple_HHCMSSZgDEUSHVCefGhfGYQZI k_(Condition InitialBPHDiagnosis) => 
				USSAssessment;
			var l_ = context.Operators.SelectOrNull<Condition, Tuples.Tuple_HHCMSSZgDEUSHVCefGhfGYQZI>(j_, k_);

			return l_;
		};
		var c_ = context.Operators.SelectManyOrNull<Tuples.Tuple_HHCMSSZgDEUSHVCefGhfGYQZI, Tuples.Tuple_HHCMSSZgDEUSHVCefGhfGYQZI>(a_, b_);
		object d_(Tuples.Tuple_HHCMSSZgDEUSHVCefGhfGYQZI @this) => 
			@this?.effectiveDatetime;
		var e_ = context.Operators.ListSortBy<Tuples.Tuple_HHCMSSZgDEUSHVCefGhfGYQZI>(c_, d_, System.ComponentModel.ListSortDirection.Ascending);
		var f_ = context.Operators.FirstOfList<Tuples.Tuple_HHCMSSZgDEUSHVCefGhfGYQZI>(e_);

		return f_;
	}

    [CqlDeclaration("Urinary Symptom Score Within 1 Month after Initial BPH Diagnosis")]
	public Tuples.Tuple_HHCMSSZgDEUSHVCefGhfGYQZI Urinary_Symptom_Score_Within_1_Month_after_Initial_BPH_Diagnosis() => 
		__Urinary_Symptom_Score_Within_1_Month_after_Initial_BPH_Diagnosis.Value;

	private Tuples.Tuple_HHCMSSZgDEUSHVCefGhfGYQZI Urinary_Symptom_Score_6_to_12_Months_After_Initial_BPH_Diagnosis_Value()
	{
		var a_ = this.Urinary_Symptom_Score_Assessment();
		IEnumerable<Tuples.Tuple_HHCMSSZgDEUSHVCefGhfGYQZI> b_(Tuples.Tuple_HHCMSSZgDEUSHVCefGhfGYQZI USSAssessment)
		{
			var g_ = this.Initial_BPH_Diagnosis_Starts_Within_6_Months_Before_or_After_Start_of_Measurement_Period();
			var h_ = new Condition[]
			{
				g_,
			};
			bool? i_(Condition InitialBPHDiagnosis)
			{
				var m_ = QICoreCommon_2_0_000.prevalenceInterval(InitialBPHDiagnosis);
				var n_ = context.Operators.Start(m_);
				var o_ = context.Operators.DurationBetween(n_, USSAssessment?.effectiveDatetime, "month");
				var p_ = context.Operators.Interval((int?)6, (int?)12, true, true);
				var q_ = context.Operators.ElementInInterval<int?>(o_, p_, null);

				return q_;
			};
			var j_ = context.Operators.WhereOrNull<Condition>(h_, i_);
			Tuples.Tuple_HHCMSSZgDEUSHVCefGhfGYQZI k_(Condition InitialBPHDiagnosis) => 
				USSAssessment;
			var l_ = context.Operators.SelectOrNull<Condition, Tuples.Tuple_HHCMSSZgDEUSHVCefGhfGYQZI>(j_, k_);

			return l_;
		};
		var c_ = context.Operators.SelectManyOrNull<Tuples.Tuple_HHCMSSZgDEUSHVCefGhfGYQZI, Tuples.Tuple_HHCMSSZgDEUSHVCefGhfGYQZI>(a_, b_);
		object d_(Tuples.Tuple_HHCMSSZgDEUSHVCefGhfGYQZI @this) => 
			@this?.effectiveDatetime;
		var e_ = context.Operators.ListSortBy<Tuples.Tuple_HHCMSSZgDEUSHVCefGhfGYQZI>(c_, d_, System.ComponentModel.ListSortDirection.Ascending);
		var f_ = context.Operators.LastOfList<Tuples.Tuple_HHCMSSZgDEUSHVCefGhfGYQZI>(e_);

		return f_;
	}

    [CqlDeclaration("Urinary Symptom Score 6 to 12 Months After Initial BPH Diagnosis")]
	public Tuples.Tuple_HHCMSSZgDEUSHVCefGhfGYQZI Urinary_Symptom_Score_6_to_12_Months_After_Initial_BPH_Diagnosis() => 
		__Urinary_Symptom_Score_6_to_12_Months_After_Initial_BPH_Diagnosis.Value;

	private bool? Initial_Population_Value()
	{
		var a_ = this.Patient_is_Male();
		var b_ = this.Has_Qualifying_Encounter();
		var c_ = context.Operators.And(a_, b_);
		var d_ = this.Has_Qualifying_BPH_Diagnosis();
		var e_ = context.Operators.And(c_, d_);
		var f_ = this.Urinary_Symptom_Score_Within_1_Month_after_Initial_BPH_Diagnosis();
		var g_ = context.Operators.Not((bool?)(f_ is null));
		var h_ = context.Operators.And(e_, g_);
		var i_ = this.Urinary_Symptom_Score_6_to_12_Months_After_Initial_BPH_Diagnosis();
		var j_ = context.Operators.Not((bool?)(i_ is null));
		var k_ = context.Operators.And(h_, j_);

		return k_;
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

	private IEnumerable<Condition> Urinary_Retention_Diagnosis_Starts_Within_1_Year_After_Initial_BPH_Diagnosis_Value()
	{
		var a_ = this.Urinary_retention();
		var b_ = context.Operators.RetrieveByValueSet<Condition>(a_, null);
		IEnumerable<Condition> c_(Condition UrinaryRetention)
		{
			var g_ = this.Initial_BPH_Diagnosis_Starts_Within_6_Months_Before_or_After_Start_of_Measurement_Period();
			var h_ = new Condition[]
			{
				g_,
			};
			bool? i_(Condition InitialBPHDiagnosis)
			{
				var m_ = QICoreCommon_2_0_000.prevalenceInterval(UrinaryRetention);
				var n_ = context.Operators.Start(m_);
				var o_ = QICoreCommon_2_0_000.prevalenceInterval(InitialBPHDiagnosis);
				var p_ = context.Operators.Start(o_);
				var r_ = context.Operators.Start(o_);
				var s_ = context.Operators.Quantity((decimal?)1m, "year");
				var t_ = context.Operators.Add(r_, s_);
				var u_ = context.Operators.Interval(p_, t_, true, true);
				var v_ = context.Operators.ElementInInterval<CqlDateTime>(n_, u_, "day");
				var x_ = context.Operators.Start(o_);
				var y_ = context.Operators.Not((bool?)(x_ is null));
				var z_ = context.Operators.And(v_, y_);

				return z_;
			};
			var j_ = context.Operators.WhereOrNull<Condition>(h_, i_);
			Condition k_(Condition InitialBPHDiagnosis) => 
				UrinaryRetention;
			var l_ = context.Operators.SelectOrNull<Condition, Condition>(j_, k_);

			return l_;
		};
		var d_ = context.Operators.SelectManyOrNull<Condition, Condition>(b_, c_);
		bool? e_(Condition UrinaryRetention)
		{
			var aa_ = this.isConfirmedActiveDiagnosis(UrinaryRetention);

			return aa_;
		};
		var f_ = context.Operators.WhereOrNull<Condition>(d_, e_);

		return f_;
	}

    [CqlDeclaration("Urinary Retention Diagnosis Starts Within 1 Year After Initial BPH Diagnosis")]
	public IEnumerable<Condition> Urinary_Retention_Diagnosis_Starts_Within_1_Year_After_Initial_BPH_Diagnosis() => 
		__Urinary_Retention_Diagnosis_Starts_Within_1_Year_After_Initial_BPH_Diagnosis.Value;

	private Condition Initial_BPH_Diagnosis_Starts_During_or_Within_30_Days_After_End_of_Hospitalization_Value()
	{
		var a_ = this.Initial_BPH_Diagnosis_Starts_Within_6_Months_Before_or_After_Start_of_Measurement_Period();
		var b_ = new Condition[]
		{
			a_,
		};
		IEnumerable<Condition> c_(Condition InitialBPHDiagnosis)
		{
			var f_ = this.Hospital_Services_for_urology_care();
			var g_ = context.Operators.RetrieveByValueSet<Encounter>(f_, null);
			bool? h_(Encounter InHospitalServices)
			{
				var l_ = QICoreCommon_2_0_000.prevalenceInterval(InitialBPHDiagnosis);
				var m_ = context.Operators.Start(l_);
				var n_ = FHIRHelpers_4_3_000.ToInterval(InHospitalServices?.Period);
				var o_ = context.Operators.Start(n_);
				var q_ = context.Operators.End(n_);
				var r_ = context.Operators.Quantity((decimal?)31m, "days");
				var s_ = context.Operators.Add(q_, r_);
				var t_ = context.Operators.Interval(o_, s_, true, true);
				var u_ = context.Operators.ElementInInterval<CqlDateTime>(m_, t_, null);
				var v_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(InHospitalServices?.StatusElement?.Value);
				var w_ = context.Operators.Equal(v_, "finished");
				var x_ = context.Operators.And(u_, w_);

				return x_;
			};
			var i_ = context.Operators.WhereOrNull<Encounter>(g_, h_);
			Condition j_(Encounter InHospitalServices) => 
				InitialBPHDiagnosis;
			var k_ = context.Operators.SelectOrNull<Encounter, Condition>(i_, j_);

			return k_;
		};
		var d_ = context.Operators.SelectManyOrNull<Condition, Condition>(b_, c_);
		var e_ = context.Operators.SingleOrNull<Condition>(d_);

		return e_;
	}

    [CqlDeclaration("Initial BPH Diagnosis Starts During or Within 30 Days After End of Hospitalization")]
	public Condition Initial_BPH_Diagnosis_Starts_During_or_Within_30_Days_After_End_of_Hospitalization() => 
		__Initial_BPH_Diagnosis_Starts_During_or_Within_30_Days_After_End_of_Hospitalization.Value;

	private IEnumerable<Condition> Morbid_Obesity_Diagnosis_On_or_Before_Follow_Up_USS_Assessment_Value()
	{
		var a_ = this.Morbid_Obesity();
		var b_ = context.Operators.RetrieveByValueSet<Condition>(a_, null);
		IEnumerable<Condition> c_(Condition MorbidObesity)
		{
			var e_ = this.Urinary_Symptom_Score_6_to_12_Months_After_Initial_BPH_Diagnosis();
			var f_ = new Tuples.Tuple_HHCMSSZgDEUSHVCefGhfGYQZI[]
			{
				e_,
			};
			bool? g_(Tuples.Tuple_HHCMSSZgDEUSHVCefGhfGYQZI FollowUpUSSAssessment)
			{
				var k_ = QICoreCommon_2_0_000.prevalenceInterval(MorbidObesity);
				var l_ = this.Measurement_Period();
				var m_ = context.Operators.Overlaps(k_, l_, null);
				var o_ = context.Operators.Start(k_);
				var p_ = context.Operators.SameOrBefore(o_, FollowUpUSSAssessment?.effectiveDatetime, null);
				var q_ = context.Operators.And(m_, p_);
				var r_ = this.isConfirmedActiveDiagnosis(MorbidObesity);
				var s_ = context.Operators.And(q_, r_);

				return s_;
			};
			var h_ = context.Operators.WhereOrNull<Tuples.Tuple_HHCMSSZgDEUSHVCefGhfGYQZI>(f_, g_);
			Condition i_(Tuples.Tuple_HHCMSSZgDEUSHVCefGhfGYQZI FollowUpUSSAssessment) => 
				MorbidObesity;
			var j_ = context.Operators.SelectOrNull<Tuples.Tuple_HHCMSSZgDEUSHVCefGhfGYQZI, Condition>(h_, i_);

			return j_;
		};
		var d_ = context.Operators.SelectManyOrNull<Condition, Condition>(b_, c_);

		return d_;
	}

    [CqlDeclaration("Morbid Obesity Diagnosis On or Before Follow Up USS Assessment")]
	public IEnumerable<Condition> Morbid_Obesity_Diagnosis_On_or_Before_Follow_Up_USS_Assessment() => 
		__Morbid_Obesity_Diagnosis_On_or_Before_Follow_Up_USS_Assessment.Value;

	private bool? Has_BMI_Exam_Result_Greater_Than_or_Equal_To_40_During_Measurement_Period_and_On_or_Before_Follow_Up_USS_Assessment_Value()
	{
		var a_ = context.Operators.RetrieveByValueSet<Observation>(null, null);
		IEnumerable<Observation> b_(Observation BMIExam)
		{
			var g_ = this.Urinary_Symptom_Score_6_to_12_Months_After_Initial_BPH_Diagnosis();
			var h_ = new Tuples.Tuple_HHCMSSZgDEUSHVCefGhfGYQZI[]
			{
				g_,
			};
			bool? i_(Tuples.Tuple_HHCMSSZgDEUSHVCefGhfGYQZI FollowUpUSSAssessment)
			{
				var m_ = context.Operators.Convert<Quantity>(BMIExam?.Value);
				var n_ = FHIRHelpers_4_3_000.ToQuantity(m_);
				var o_ = context.Operators.Quantity((decimal?)40m, "kg/m2");
				var p_ = context.Operators.Greater(n_, o_);
				var q_ = context.Operators.Convert<string>(BMIExam?.StatusElement?.Value);
				var r_ = new string[]
				{
					"final",
					"amended",
					"corrected",
				};
				var s_ = context.Operators.InList<string>(q_, (r_ as IEnumerable<string>));
				var t_ = context.Operators.And(p_, s_);
				var u_ = FHIRHelpers_4_3_000.ToValue(BMIExam?.Effective);
				var v_ = QICoreCommon_2_0_000.earliest(u_);
				var w_ = this.Measurement_Period();
				var x_ = context.Operators.ElementInInterval<CqlDateTime>(v_, w_, "day");
				var y_ = context.Operators.And(t_, x_);
				var aa_ = QICoreCommon_2_0_000.earliest(u_);
				var ab_ = context.Operators.SameOrBefore(aa_, FollowUpUSSAssessment?.effectiveDatetime, null);
				var ac_ = context.Operators.And(y_, ab_);

				return ac_;
			};
			var j_ = context.Operators.WhereOrNull<Tuples.Tuple_HHCMSSZgDEUSHVCefGhfGYQZI>(h_, i_);
			Observation k_(Tuples.Tuple_HHCMSSZgDEUSHVCefGhfGYQZI FollowUpUSSAssessment) => 
				BMIExam;
			var l_ = context.Operators.SelectOrNull<Tuples.Tuple_HHCMSSZgDEUSHVCefGhfGYQZI, Observation>(j_, k_);

			return l_;
		};
		var c_ = context.Operators.SelectManyOrNull<Observation, Observation>(a_, b_);
		CqlDateTime d_(Observation BMIExam)
		{
			var ad_ = FHIRHelpers_4_3_000.ToValue(BMIExam?.Effective);
			var ae_ = QICoreCommon_2_0_000.earliest(ad_);

			return ae_;
		};
		var e_ = context.Operators.SelectOrNull<Observation, CqlDateTime>(c_, d_);
		var f_ = context.Operators.ExistsInList<CqlDateTime>(e_);

		return f_;
	}

    [CqlDeclaration("Has BMI Exam Result Greater Than or Equal To 40 During Measurement Period and On or Before Follow Up USS Assessment")]
	public bool? Has_BMI_Exam_Result_Greater_Than_or_Equal_To_40_During_Measurement_Period_and_On_or_Before_Follow_Up_USS_Assessment() => 
		__Has_BMI_Exam_Result_Greater_Than_or_Equal_To_40_During_Measurement_Period_and_On_or_Before_Follow_Up_USS_Assessment.Value;

	private bool? Has_Morbid_Obesity_Diagnosis_or_BMI_Exam_Result__Greater_Than_or_Equal_to_40_Starts_On_or_Before_Follow_Up_USS_Assessment_Value()
	{
		var a_ = this.Morbid_Obesity_Diagnosis_On_or_Before_Follow_Up_USS_Assessment();
		var b_ = context.Operators.ExistsInList<Condition>(a_);
		var c_ = this.Has_BMI_Exam_Result_Greater_Than_or_Equal_To_40_During_Measurement_Period_and_On_or_Before_Follow_Up_USS_Assessment();
		var d_ = context.Operators.Or(b_, c_);

		return d_;
	}

    [CqlDeclaration("Has Morbid Obesity Diagnosis or BMI Exam Result  Greater Than or Equal to 40 Starts On or Before Follow Up USS Assessment")]
	public bool? Has_Morbid_Obesity_Diagnosis_or_BMI_Exam_Result__Greater_Than_or_Equal_to_40_Starts_On_or_Before_Follow_Up_USS_Assessment() => 
		__Has_Morbid_Obesity_Diagnosis_or_BMI_Exam_Result__Greater_Than_or_Equal_to_40_Starts_On_or_Before_Follow_Up_USS_Assessment.Value;

	private bool? Denominator_Exclusions_Value()
	{
		var a_ = this.Urinary_Retention_Diagnosis_Starts_Within_1_Year_After_Initial_BPH_Diagnosis();
		var b_ = context.Operators.ExistsInList<Condition>(a_);
		var c_ = this.Initial_BPH_Diagnosis_Starts_During_or_Within_30_Days_After_End_of_Hospitalization();
		var d_ = context.Operators.Not((bool?)(c_ is null));
		var e_ = context.Operators.Or(b_, d_);
		var f_ = this.Has_Morbid_Obesity_Diagnosis_or_BMI_Exam_Result__Greater_Than_or_Equal_to_40_Starts_On_or_Before_Follow_Up_USS_Assessment();
		var g_ = context.Operators.Or(e_, f_);

		return g_;
	}

    [CqlDeclaration("Denominator Exclusions")]
	public bool? Denominator_Exclusions() => 
		__Denominator_Exclusions.Value;

	private int? Urinary_Symptom_Score_Change_Value()
	{
		var a_ = this.Urinary_Symptom_Score_Within_1_Month_after_Initial_BPH_Diagnosis();
		var b_ = new Tuples.Tuple_HHCMSSZgDEUSHVCefGhfGYQZI[]
		{
			a_,
		};
		var c_ = this.Urinary_Symptom_Score_6_to_12_Months_After_Initial_BPH_Diagnosis();
		var d_ = new Tuples.Tuple_HHCMSSZgDEUSHVCefGhfGYQZI[]
		{
			c_,
		};
		var e_ = context.Operators.CrossJoin<Tuples.Tuple_HHCMSSZgDEUSHVCefGhfGYQZI, Tuples.Tuple_HHCMSSZgDEUSHVCefGhfGYQZI>(b_, d_);
		Tuples.Tuple_FAESHVMWYGMYBALaJITZUecdI f_(ValueTuple<Tuples.Tuple_HHCMSSZgDEUSHVCefGhfGYQZI,Tuples.Tuple_HHCMSSZgDEUSHVCefGhfGYQZI> _valueTuple)
		{
			var k_ = new Tuples.Tuple_FAESHVMWYGMYBALaJITZUecdI
			{
				FirstUSSAssessment = _valueTuple.Item1,
				FollowUpUSSAssessment = _valueTuple.Item2,
			};

			return k_;
		};
		var g_ = context.Operators.SelectOrNull<ValueTuple<Tuples.Tuple_HHCMSSZgDEUSHVCefGhfGYQZI,Tuples.Tuple_HHCMSSZgDEUSHVCefGhfGYQZI>, Tuples.Tuple_FAESHVMWYGMYBALaJITZUecdI>(e_, f_);
		int? h_(Tuples.Tuple_FAESHVMWYGMYBALaJITZUecdI tuple_faeshvmwygmybalajitzuecdi)
		{
			var l_ = context.Operators.Subtract(tuple_faeshvmwygmybalajitzuecdi.FirstUSSAssessment?.valueInteger, tuple_faeshvmwygmybalajitzuecdi.FollowUpUSSAssessment?.valueInteger);

			return l_;
		};
		var i_ = context.Operators.SelectOrNull<Tuples.Tuple_FAESHVMWYGMYBALaJITZUecdI, int?>(g_, h_);
		var j_ = context.Operators.SingleOrNull<int?>(i_);

		return j_;
	}

    [CqlDeclaration("Urinary Symptom Score Change")]
	public int? Urinary_Symptom_Score_Change() => 
		__Urinary_Symptom_Score_Change.Value;

	private bool? Has_Urinary_Symptom_Score_Improvement_Greater_Than_or_Equal_To_3_Value()
	{
		var a_ = this.Urinary_Symptom_Score_Change();
		var b_ = new int?[]
		{
			a_,
		};
		bool? c_(int? USSImprovement)
		{
			var g_ = context.Operators.GreaterOrEqual(USSImprovement, (int?)3);

			return g_;
		};
		var d_ = context.Operators.WhereOrNull<int?>(b_, c_);
		var e_ = context.Operators.SingleOrNull<int?>(d_);
		var f_ = context.Operators.Not((bool?)(e_ is null));

		return f_;
	}

    [CqlDeclaration("Has Urinary Symptom Score Improvement Greater Than or Equal To 3")]
	public bool? Has_Urinary_Symptom_Score_Improvement_Greater_Than_or_Equal_To_3() => 
		__Has_Urinary_Symptom_Score_Improvement_Greater_Than_or_Equal_To_3.Value;

	private bool? Numerator_Value()
	{
		var a_ = this.Has_Urinary_Symptom_Score_Improvement_Greater_Than_or_Equal_To_3();

		return a_;
	}

    [CqlDeclaration("Numerator")]
	public bool? Numerator() => 
		__Numerator.Value;

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
