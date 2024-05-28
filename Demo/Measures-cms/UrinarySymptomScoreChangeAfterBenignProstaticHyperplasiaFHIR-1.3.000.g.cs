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
    internal Lazy<IEnumerable<Tuple_GNNDVIQPcTANSdLebhBKYIdga>> __Documented_IPSS_Assessment_Result;
    internal Lazy<IEnumerable<Tuple_GNNDVIQPcTANSdLebhBKYIdga>> __AUA_Symptom_Index_and_Quality_of_Life_Assessment_Result;
    internal Lazy<IEnumerable<Tuple_GNNDVIQPcTANSdLebhBKYIdga>> __Urinary_Symptom_Score_Assessment;
    internal Lazy<Tuple_GNNDVIQPcTANSdLebhBKYIdga> __Urinary_Symptom_Score_Within_1_Month_after_Initial_BPH_Diagnosis;
    internal Lazy<Tuple_GNNDVIQPcTANSdLebhBKYIdga> __Urinary_Symptom_Score_6_to_12_Months_After_Initial_BPH_Diagnosis;
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
    internal Lazy<Tuple_HPcCiDPXQfZTXIORThMLfTQDR> __SDE_Ethnicity;
    internal Lazy<IEnumerable<Tuple_GPRWMPNAYaJRiGDFSTLJOPeIJ>> __SDE_Payer;
    internal Lazy<Tuple_HPcCiDPXQfZTXIORThMLfTQDR> __SDE_Race;
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
        __Documented_IPSS_Assessment_Result = new Lazy<IEnumerable<Tuple_GNNDVIQPcTANSdLebhBKYIdga>>(this.Documented_IPSS_Assessment_Result_Value);
        __AUA_Symptom_Index_and_Quality_of_Life_Assessment_Result = new Lazy<IEnumerable<Tuple_GNNDVIQPcTANSdLebhBKYIdga>>(this.AUA_Symptom_Index_and_Quality_of_Life_Assessment_Result_Value);
        __Urinary_Symptom_Score_Assessment = new Lazy<IEnumerable<Tuple_GNNDVIQPcTANSdLebhBKYIdga>>(this.Urinary_Symptom_Score_Assessment_Value);
        __Urinary_Symptom_Score_Within_1_Month_after_Initial_BPH_Diagnosis = new Lazy<Tuple_GNNDVIQPcTANSdLebhBKYIdga>(this.Urinary_Symptom_Score_Within_1_Month_after_Initial_BPH_Diagnosis_Value);
        __Urinary_Symptom_Score_6_to_12_Months_After_Initial_BPH_Diagnosis = new Lazy<Tuple_GNNDVIQPcTANSdLebhBKYIdga>(this.Urinary_Symptom_Score_6_to_12_Months_After_Initial_BPH_Diagnosis_Value);
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
        __SDE_Ethnicity = new Lazy<Tuple_HPcCiDPXQfZTXIORThMLfTQDR>(this.SDE_Ethnicity_Value);
        __SDE_Payer = new Lazy<IEnumerable<Tuple_GPRWMPNAYaJRiGDFSTLJOPeIJ>>(this.SDE_Payer_Value);
        __SDE_Race = new Lazy<Tuple_HPcCiDPXQfZTXIORThMLfTQDR>(this.SDE_Race_Value);
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
		var a_ = context.Operators.DateTime(2025, 1, 1, 0, 0, 0, 0, default);
		var b_ = context.Operators.DateTime(2026, 1, 1, 0, 0, 0, 0, default);
		var c_ = context.Operators.Interval(a_, b_, true, false);
		var d_ = context.ResolveParameter("UrinarySymptomScoreChangeAfterBenignProstaticHyperplasiaFHIR-1.3.000", "Measurement Period", c_);

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

	private bool? Patient_is_Male_Value()
	{
		var a_ = this.Patient();
		var b_ = context.Operators.Convert<string>(a_?.GenderElement?.Value);
		var c_ = context.Operators.Equal(b_, "male");

		return c_;
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
			var g_ = ValidEncounter?.Period;
			var h_ = FHIRHelpers_4_3_000.ToInterval(g_);
			var i_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(f_, h_, "day");
			var j_ = ValidEncounter?.Class;
			var k_ = FHIRHelpers_4_3_000.ToCode(j_);
			var l_ = this.@virtual();
			var m_ = context.Operators.Equivalent(k_, l_);
			var n_ = context.Operators.Not(m_);
			var o_ = context.Operators.And(i_, n_);
			var p_ = ValidEncounter?.StatusElement;
			var q_ = p_?.Value;
			var r_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(q_);
			var s_ = context.Operators.Equal(r_, "finished");
			var t_ = context.Operators.And(o_, s_);

			return t_;
		};
		var d_ = context.Operators.Where<Encounter>(b_, c_);
		var e_ = context.Operators.Exists<Encounter>(d_);

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
			var f_ = Diagnosis?.ClinicalStatus;
			var g_ = FHIRHelpers_4_3_000.ToConcept(f_);
			var h_ = QICoreCommon_2_0_000.active();
			var i_ = context.Operators.ConvertCodeToConcept(h_);
			var j_ = context.Operators.Equivalent(g_, i_);
			var k_ = Diagnosis?.VerificationStatus;
			var l_ = FHIRHelpers_4_3_000.ToConcept(k_);
			var m_ = QICoreCommon_2_0_000.unconfirmed();
			var n_ = context.Operators.ConvertCodeToConcept(m_);
			var o_ = context.Operators.Equivalent(l_, n_);
			var q_ = FHIRHelpers_4_3_000.ToConcept(k_);
			var r_ = QICoreCommon_2_0_000.refuted();
			var s_ = context.Operators.ConvertCodeToConcept(r_);
			var t_ = context.Operators.Equivalent(q_, s_);
			var u_ = context.Operators.Or(o_, t_);
			var w_ = FHIRHelpers_4_3_000.ToConcept(k_);
			var x_ = QICoreCommon_2_0_000.entered_in_error();
			var y_ = context.Operators.ConvertCodeToConcept(x_);
			var z_ = context.Operators.Equivalent(w_, y_);
			var aa_ = context.Operators.Or(u_, z_);
			var ab_ = context.Operators.Not(aa_);
			var ac_ = context.Operators.And(j_, ab_);

			return ac_;
		};
		var c_ = context.Operators.Where<Condition>((IEnumerable<Condition>)a_, b_);
		var d_ = context.Operators.SingletonFrom<Condition>(c_);
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
			var m_ = context.Operators.Quantity(6m, "months");
			var n_ = context.Operators.Subtract(l_, m_);
			var p_ = context.Operators.End(k_);
			var q_ = context.Operators.Interval(n_, p_, true, true);
			var r_ = context.Operators.In<CqlDateTime>(j_, q_, "day");
			var s_ = this.isConfirmedActiveDiagnosis(NewBPHDiagnosis);
			var t_ = context.Operators.And(r_, s_);

			return t_;
		};
		var e_ = context.Operators.Where<Condition>(c_, d_);
		object f_(Condition @this)
		{
			var u_ = @this?.Onset;
			var v_ = FHIRHelpers_4_3_000.ToValue(u_);
			var w_ = QICoreCommon_2_0_000.toInterval(v_);
			var x_ = context.Operators.Start(w_);

			return x_;
		};
		var g_ = context.Operators.SortBy<Condition>(e_, f_, System.ComponentModel.ListSortDirection.Ascending);
		var h_ = context.Operators.First<Condition>(g_);

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

	private IEnumerable<Tuple_GNNDVIQPcTANSdLebhBKYIdga> Documented_IPSS_Assessment_Result_Value()
	{
		var a_ = this.International_Prostate_Symptom_Score__IPSS_();
		var b_ = context.Operators.ToList<CqlCode>(a_);
		var c_ = context.Operators.RetrieveByCodes<Observation>(b_, null);
		bool? d_(Observation IPSSAssessment)
		{
			var h_ = IPSSAssessment?.StatusElement;
			var i_ = h_?.Value;
			var j_ = context.Operators.Convert<Code<ObservationStatus>>(i_);
			var k_ = context.Operators.Convert<string>(j_);
			var l_ = new string[]
			{
				"final",
				"amended",
				"corrected",
			};
			var m_ = context.Operators.In<string>(k_, (l_ as IEnumerable<string>));
			var n_ = IPSSAssessment?.Value;
			var o_ = FHIRHelpers_4_3_000.ToValue(n_);
			var p_ = context.Operators.Not((bool?)(o_ is null));
			var q_ = context.Operators.And(m_, p_);

			return q_;
		};
		var e_ = context.Operators.Where<Observation>(c_, d_);
		Tuple_GNNDVIQPcTANSdLebhBKYIdga f_(Observation IPSSAssessment)
		{
			object r_()
			{
				bool w_()
				{
					var z_ = IPSSAssessment?.Effective;
					var aa_ = FHIRHelpers_4_3_000.ToValue(z_);
					var ab_ = aa_ is CqlDateTime;

					return ab_;
				};
				bool x_()
				{
					var ac_ = IPSSAssessment?.Effective;
					var ad_ = FHIRHelpers_4_3_000.ToValue(ac_);
					var ae_ = ad_ is CqlInterval<CqlDateTime>;

					return ae_;
				};
				bool y_()
				{
					var af_ = IPSSAssessment?.Effective;
					var ag_ = FHIRHelpers_4_3_000.ToValue(af_);
					var ah_ = ag_ is CqlDateTime;

					return ah_;
				};
				if (w_())
				{
					var ai_ = IPSSAssessment?.Effective;
					var aj_ = FHIRHelpers_4_3_000.ToValue(ai_);

					return ((aj_ as CqlDateTime) as object);
				}
				else if (x_())
				{
					var ak_ = IPSSAssessment?.Effective;
					var al_ = FHIRHelpers_4_3_000.ToValue(ak_);

					return ((al_ as CqlInterval<CqlDateTime>) as object);
				}
				else if (y_())
				{
					var am_ = IPSSAssessment?.Effective;
					var an_ = FHIRHelpers_4_3_000.ToValue(am_);

					return ((an_ as CqlDateTime) as object);
				}
				else
				{
					return null;
				}
			};
			var s_ = QICoreCommon_2_0_000.earliest(r_());
			var t_ = IPSSAssessment?.Value;
			var u_ = FHIRHelpers_4_3_000.ToValue(t_);
			var v_ = new Tuple_GNNDVIQPcTANSdLebhBKYIdga
			{
				effectiveDatetime = s_,
				valueInteger = (int?)u_,
			};

			return v_;
		};
		var g_ = context.Operators.Select<Observation, Tuple_GNNDVIQPcTANSdLebhBKYIdga>(e_, f_);

		return g_;
	}

    [CqlDeclaration("Documented IPSS Assessment Result")]
	public IEnumerable<Tuple_GNNDVIQPcTANSdLebhBKYIdga> Documented_IPSS_Assessment_Result() => 
		__Documented_IPSS_Assessment_Result.Value;

	private IEnumerable<Tuple_GNNDVIQPcTANSdLebhBKYIdga> AUA_Symptom_Index_and_Quality_of_Life_Assessment_Result_Value()
	{
		var a_ = this.American_Urological_Association_Symptom_Index__AUASI_();
		var b_ = context.Operators.ToList<CqlCode>(a_);
		var c_ = context.Operators.RetrieveByCodes<Observation>(b_, null);
		bool? d_(Observation AUASIAssessment)
		{
			var h_ = AUASIAssessment?.Category;
			CqlConcept i_(CodeableConcept @this)
			{
				var y_ = FHIRHelpers_4_3_000.ToConcept(@this);

				return y_;
			};
			var j_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)h_, i_);
			bool? k_(CqlConcept AUASIAssessmentCategory)
			{
				var z_ = this.survey();
				var aa_ = context.Operators.ConvertCodeToConcept(z_);
				var ab_ = context.Operators.Equivalent(AUASIAssessmentCategory, aa_);

				return ab_;
			};
			var l_ = context.Operators.Where<CqlConcept>(j_, k_);
			var m_ = context.Operators.Exists<CqlConcept>(l_);
			var n_ = AUASIAssessment?.StatusElement;
			var o_ = n_?.Value;
			var p_ = context.Operators.Convert<Code<ObservationStatus>>(o_);
			var q_ = context.Operators.Convert<string>(p_);
			var r_ = new string[]
			{
				"final",
				"amended",
				"corrected",
			};
			var s_ = context.Operators.In<string>(q_, (r_ as IEnumerable<string>));
			var t_ = context.Operators.And(m_, s_);
			var u_ = AUASIAssessment?.Value;
			var v_ = FHIRHelpers_4_3_000.ToValue(u_);
			var w_ = context.Operators.Not((bool?)(v_ is null));
			var x_ = context.Operators.And(t_, w_);

			return x_;
		};
		var e_ = context.Operators.Where<Observation>(c_, d_);
		Tuple_GNNDVIQPcTANSdLebhBKYIdga f_(Observation AUASIAssessment)
		{
			object ac_()
			{
				bool as_()
				{
					var av_ = AUASIAssessment?.Effective;
					var aw_ = FHIRHelpers_4_3_000.ToValue(av_);
					var ax_ = aw_ is CqlDateTime;

					return ax_;
				};
				bool at_()
				{
					var ay_ = AUASIAssessment?.Effective;
					var az_ = FHIRHelpers_4_3_000.ToValue(ay_);
					var ba_ = az_ is CqlInterval<CqlDateTime>;

					return ba_;
				};
				bool au_()
				{
					var bb_ = AUASIAssessment?.Effective;
					var bc_ = FHIRHelpers_4_3_000.ToValue(bb_);
					var bd_ = bc_ is CqlDateTime;

					return bd_;
				};
				if (as_())
				{
					var be_ = AUASIAssessment?.Effective;
					var bf_ = FHIRHelpers_4_3_000.ToValue(be_);

					return ((bf_ as CqlDateTime) as object);
				}
				else if (at_())
				{
					var bg_ = AUASIAssessment?.Effective;
					var bh_ = FHIRHelpers_4_3_000.ToValue(bg_);

					return ((bh_ as CqlInterval<CqlDateTime>) as object);
				}
				else if (au_())
				{
					var bi_ = AUASIAssessment?.Effective;
					var bj_ = FHIRHelpers_4_3_000.ToValue(bi_);

					return ((bj_ as CqlDateTime) as object);
				}
				else
				{
					return null;
				}
			};
			var ad_ = QICoreCommon_2_0_000.earliest(ac_());
			var ae_ = AUASIAssessment?.Value;
			var af_ = FHIRHelpers_4_3_000.ToValue(ae_);
			var ag_ = this.If_you_were_to_spend_the_rest_of_your_life_with_your_urinary_condition_just_the_way_it_is_now__how_would_you_feel_about_that__IPSS_();
			var ah_ = context.Operators.ToList<CqlCode>(ag_);
			var ai_ = context.Operators.RetrieveByCodes<Observation>(ah_, null);
			bool? aj_(Observation QOLAssessment)
			{
				object bk_()
				{
					bool ch_()
					{
						var ck_ = QOLAssessment?.Effective;
						var cl_ = FHIRHelpers_4_3_000.ToValue(ck_);
						var cm_ = cl_ is CqlDateTime;

						return cm_;
					};
					bool ci_()
					{
						var cn_ = QOLAssessment?.Effective;
						var co_ = FHIRHelpers_4_3_000.ToValue(cn_);
						var cp_ = co_ is CqlInterval<CqlDateTime>;

						return cp_;
					};
					bool cj_()
					{
						var cq_ = QOLAssessment?.Effective;
						var cr_ = FHIRHelpers_4_3_000.ToValue(cq_);
						var cs_ = cr_ is CqlDateTime;

						return cs_;
					};
					if (ch_())
					{
						var ct_ = QOLAssessment?.Effective;
						var cu_ = FHIRHelpers_4_3_000.ToValue(ct_);

						return ((cu_ as CqlDateTime) as object);
					}
					else if (ci_())
					{
						var cv_ = QOLAssessment?.Effective;
						var cw_ = FHIRHelpers_4_3_000.ToValue(cv_);

						return ((cw_ as CqlInterval<CqlDateTime>) as object);
					}
					else if (cj_())
					{
						var cx_ = QOLAssessment?.Effective;
						var cy_ = FHIRHelpers_4_3_000.ToValue(cx_);

						return ((cy_ as CqlDateTime) as object);
					}
					else
					{
						return null;
					}
				};
				var bl_ = QICoreCommon_2_0_000.earliest(bk_());
				object bm_()
				{
					bool cz_()
					{
						var dc_ = QOLAssessment?.Effective;
						var dd_ = FHIRHelpers_4_3_000.ToValue(dc_);
						var de_ = dd_ is CqlDateTime;

						return de_;
					};
					bool da_()
					{
						var df_ = QOLAssessment?.Effective;
						var dg_ = FHIRHelpers_4_3_000.ToValue(df_);
						var dh_ = dg_ is CqlInterval<CqlDateTime>;

						return dh_;
					};
					bool db_()
					{
						var di_ = QOLAssessment?.Effective;
						var dj_ = FHIRHelpers_4_3_000.ToValue(di_);
						var dk_ = dj_ is CqlDateTime;

						return dk_;
					};
					if (cz_())
					{
						var dl_ = QOLAssessment?.Effective;
						var dm_ = FHIRHelpers_4_3_000.ToValue(dl_);

						return ((dm_ as CqlDateTime) as object);
					}
					else if (da_())
					{
						var dn_ = QOLAssessment?.Effective;
						var do_ = FHIRHelpers_4_3_000.ToValue(dn_);

						return ((do_ as CqlInterval<CqlDateTime>) as object);
					}
					else if (db_())
					{
						var dp_ = QOLAssessment?.Effective;
						var dq_ = FHIRHelpers_4_3_000.ToValue(dp_);

						return ((dq_ as CqlDateTime) as object);
					}
					else
					{
						return null;
					}
				};
				var bn_ = QICoreCommon_2_0_000.earliest(bm_());
				var bo_ = context.Operators.SameAs(bl_, bn_, "day");
				var bp_ = QOLAssessment?.Category;
				CqlConcept bq_(CodeableConcept @this)
				{
					var dr_ = FHIRHelpers_4_3_000.ToConcept(@this);

					return dr_;
				};
				var br_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)bp_, bq_);
				bool? bs_(CqlConcept QOLAssessmentCategory)
				{
					var ds_ = this.survey();
					var dt_ = context.Operators.ConvertCodeToConcept(ds_);
					var du_ = context.Operators.Equivalent(QOLAssessmentCategory, dt_);

					return du_;
				};
				var bt_ = context.Operators.Where<CqlConcept>(br_, bs_);
				var bu_ = context.Operators.Exists<CqlConcept>(bt_);
				var bv_ = context.Operators.And(bo_, bu_);
				var bw_ = QOLAssessment?.StatusElement;
				var bx_ = bw_?.Value;
				var by_ = context.Operators.Convert<Code<ObservationStatus>>(bx_);
				var bz_ = context.Operators.Convert<string>(by_);
				var ca_ = new string[]
				{
					"final",
					"amended",
					"corrected",
				};
				var cb_ = context.Operators.In<string>(bz_, (ca_ as IEnumerable<string>));
				var cc_ = context.Operators.And(bv_, cb_);
				var cd_ = QOLAssessment?.Value;
				var ce_ = FHIRHelpers_4_3_000.ToValue(cd_);
				var cf_ = context.Operators.Not((bool?)(ce_ is null));
				var cg_ = context.Operators.And(cc_, cf_);

				return cg_;
			};
			var ak_ = context.Operators.Where<Observation>(ai_, aj_);
			object al_(Observation @this)
			{
				object dv_()
				{
					bool dx_()
					{
						var ea_ = @this?.Effective;
						var eb_ = FHIRHelpers_4_3_000.ToValue(ea_);
						var ec_ = eb_ is CqlDateTime;

						return ec_;
					};
					bool dy_()
					{
						var ed_ = @this?.Effective;
						var ee_ = FHIRHelpers_4_3_000.ToValue(ed_);
						var ef_ = ee_ is CqlInterval<CqlDateTime>;

						return ef_;
					};
					bool dz_()
					{
						var eg_ = @this?.Effective;
						var eh_ = FHIRHelpers_4_3_000.ToValue(eg_);
						var ei_ = eh_ is CqlDateTime;

						return ei_;
					};
					if (dx_())
					{
						var ej_ = @this?.Effective;
						var ek_ = FHIRHelpers_4_3_000.ToValue(ej_);

						return ((ek_ as CqlDateTime) as object);
					}
					else if (dy_())
					{
						var el_ = @this?.Effective;
						var em_ = FHIRHelpers_4_3_000.ToValue(el_);

						return ((em_ as CqlInterval<CqlDateTime>) as object);
					}
					else if (dz_())
					{
						var en_ = @this?.Effective;
						var eo_ = FHIRHelpers_4_3_000.ToValue(en_);

						return ((eo_ as CqlDateTime) as object);
					}
					else
					{
						return null;
					}
				};
				var dw_ = QICoreCommon_2_0_000.earliest(dv_());

				return dw_;
			};
			var am_ = context.Operators.SortBy<Observation>(ak_, al_, System.ComponentModel.ListSortDirection.Ascending);
			var an_ = context.Operators.Last<Observation>(am_);
			var ao_ = an_?.Value;
			var ap_ = FHIRHelpers_4_3_000.ToValue(ao_);
			var aq_ = context.Operators.Add((int?)af_, (int?)ap_);
			var ar_ = new Tuple_GNNDVIQPcTANSdLebhBKYIdga
			{
				effectiveDatetime = ad_,
				valueInteger = aq_,
			};

			return ar_;
		};
		var g_ = context.Operators.Select<Observation, Tuple_GNNDVIQPcTANSdLebhBKYIdga>(e_, f_);

		return g_;
	}

    [CqlDeclaration("AUA Symptom Index and Quality of Life Assessment Result")]
	public IEnumerable<Tuple_GNNDVIQPcTANSdLebhBKYIdga> AUA_Symptom_Index_and_Quality_of_Life_Assessment_Result() => 
		__AUA_Symptom_Index_and_Quality_of_Life_Assessment_Result.Value;

	private IEnumerable<Tuple_GNNDVIQPcTANSdLebhBKYIdga> Urinary_Symptom_Score_Assessment_Value()
	{
		var a_ = this.Documented_IPSS_Assessment_Result();
		var b_ = this.AUA_Symptom_Index_and_Quality_of_Life_Assessment_Result();
		var c_ = context.Operators.Union<Tuple_GNNDVIQPcTANSdLebhBKYIdga>(a_, b_);

		return c_;
	}

    [CqlDeclaration("Urinary Symptom Score Assessment")]
	public IEnumerable<Tuple_GNNDVIQPcTANSdLebhBKYIdga> Urinary_Symptom_Score_Assessment() => 
		__Urinary_Symptom_Score_Assessment.Value;

	private Tuple_GNNDVIQPcTANSdLebhBKYIdga Urinary_Symptom_Score_Within_1_Month_after_Initial_BPH_Diagnosis_Value()
	{
		var a_ = this.Urinary_Symptom_Score_Assessment();
		IEnumerable<Tuple_GNNDVIQPcTANSdLebhBKYIdga> b_(Tuple_GNNDVIQPcTANSdLebhBKYIdga USSAssessment)
		{
			var g_ = this.Initial_BPH_Diagnosis_Starts_Within_6_Months_Before_or_After_Start_of_Measurement_Period();
			var h_ = new Condition[]
			{
				g_,
			};
			bool? i_(Condition InitialBPHDiagnosis)
			{
				var m_ = USSAssessment?.effectiveDatetime;
				var n_ = QICoreCommon_2_0_000.prevalenceInterval(InitialBPHDiagnosis);
				var o_ = context.Operators.Start(n_);
				var q_ = context.Operators.Start(n_);
				var r_ = context.Operators.Quantity(1m, "month");
				var s_ = context.Operators.Add(q_, r_);
				var t_ = context.Operators.Interval(o_, s_, true, true);
				var u_ = context.Operators.In<CqlDateTime>(m_, t_, "day");
				var w_ = context.Operators.Start(n_);
				var x_ = context.Operators.Not((bool?)(w_ is null));
				var y_ = context.Operators.And(u_, x_);

				return y_;
			};
			var j_ = context.Operators.Where<Condition>((IEnumerable<Condition>)h_, i_);
			Tuple_GNNDVIQPcTANSdLebhBKYIdga k_(Condition InitialBPHDiagnosis) => 
				USSAssessment;
			var l_ = context.Operators.Select<Condition, Tuple_GNNDVIQPcTANSdLebhBKYIdga>(j_, k_);

			return l_;
		};
		var c_ = context.Operators.SelectMany<Tuple_GNNDVIQPcTANSdLebhBKYIdga, Tuple_GNNDVIQPcTANSdLebhBKYIdga>(a_, b_);
		object d_(Tuple_GNNDVIQPcTANSdLebhBKYIdga @this)
		{
			var z_ = @this?.effectiveDatetime;

			return z_;
		};
		var e_ = context.Operators.SortBy<Tuple_GNNDVIQPcTANSdLebhBKYIdga>(c_, d_, System.ComponentModel.ListSortDirection.Ascending);
		var f_ = context.Operators.First<Tuple_GNNDVIQPcTANSdLebhBKYIdga>(e_);

		return f_;
	}

    [CqlDeclaration("Urinary Symptom Score Within 1 Month after Initial BPH Diagnosis")]
	public Tuple_GNNDVIQPcTANSdLebhBKYIdga Urinary_Symptom_Score_Within_1_Month_after_Initial_BPH_Diagnosis() => 
		__Urinary_Symptom_Score_Within_1_Month_after_Initial_BPH_Diagnosis.Value;

	private Tuple_GNNDVIQPcTANSdLebhBKYIdga Urinary_Symptom_Score_6_to_12_Months_After_Initial_BPH_Diagnosis_Value()
	{
		var a_ = this.Urinary_Symptom_Score_Assessment();
		IEnumerable<Tuple_GNNDVIQPcTANSdLebhBKYIdga> b_(Tuple_GNNDVIQPcTANSdLebhBKYIdga USSAssessment)
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
				var o_ = USSAssessment?.effectiveDatetime;
				var p_ = context.Operators.DurationBetween(n_, o_, "month");
				var q_ = context.Operators.Interval(6, 12, true, true);
				var r_ = context.Operators.In<int?>(p_, q_, null);

				return r_;
			};
			var j_ = context.Operators.Where<Condition>((IEnumerable<Condition>)h_, i_);
			Tuple_GNNDVIQPcTANSdLebhBKYIdga k_(Condition InitialBPHDiagnosis) => 
				USSAssessment;
			var l_ = context.Operators.Select<Condition, Tuple_GNNDVIQPcTANSdLebhBKYIdga>(j_, k_);

			return l_;
		};
		var c_ = context.Operators.SelectMany<Tuple_GNNDVIQPcTANSdLebhBKYIdga, Tuple_GNNDVIQPcTANSdLebhBKYIdga>(a_, b_);
		object d_(Tuple_GNNDVIQPcTANSdLebhBKYIdga @this)
		{
			var s_ = @this?.effectiveDatetime;

			return s_;
		};
		var e_ = context.Operators.SortBy<Tuple_GNNDVIQPcTANSdLebhBKYIdga>(c_, d_, System.ComponentModel.ListSortDirection.Ascending);
		var f_ = context.Operators.Last<Tuple_GNNDVIQPcTANSdLebhBKYIdga>(e_);

		return f_;
	}

    [CqlDeclaration("Urinary Symptom Score 6 to 12 Months After Initial BPH Diagnosis")]
	public Tuple_GNNDVIQPcTANSdLebhBKYIdga Urinary_Symptom_Score_6_to_12_Months_After_Initial_BPH_Diagnosis() => 
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
				var s_ = context.Operators.Quantity(1m, "year");
				var t_ = context.Operators.Add(r_, s_);
				var u_ = context.Operators.Interval(p_, t_, true, true);
				var v_ = context.Operators.In<CqlDateTime>(n_, u_, "day");
				var x_ = context.Operators.Start(o_);
				var y_ = context.Operators.Not((bool?)(x_ is null));
				var z_ = context.Operators.And(v_, y_);

				return z_;
			};
			var j_ = context.Operators.Where<Condition>((IEnumerable<Condition>)h_, i_);
			Condition k_(Condition InitialBPHDiagnosis) => 
				UrinaryRetention;
			var l_ = context.Operators.Select<Condition, Condition>(j_, k_);

			return l_;
		};
		var d_ = context.Operators.SelectMany<Condition, Condition>(b_, c_);
		bool? e_(Condition UrinaryRetention)
		{
			var aa_ = this.isConfirmedActiveDiagnosis(UrinaryRetention);

			return aa_;
		};
		var f_ = context.Operators.Where<Condition>(d_, e_);

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
				var n_ = InHospitalServices?.Period;
				var o_ = FHIRHelpers_4_3_000.ToInterval(n_);
				var p_ = context.Operators.Start(o_);
				var r_ = FHIRHelpers_4_3_000.ToInterval(n_);
				var s_ = context.Operators.End(r_);
				var t_ = context.Operators.Quantity(31m, "days");
				var u_ = context.Operators.Add(s_, t_);
				var v_ = context.Operators.Interval(p_, u_, true, true);
				var w_ = context.Operators.In<CqlDateTime>(m_, v_, null);
				var x_ = InHospitalServices?.StatusElement;
				var y_ = x_?.Value;
				var z_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(y_);
				var aa_ = context.Operators.Equal(z_, "finished");
				var ab_ = context.Operators.And(w_, aa_);

				return ab_;
			};
			var i_ = context.Operators.Where<Encounter>(g_, h_);
			Condition j_(Encounter InHospitalServices) => 
				InitialBPHDiagnosis;
			var k_ = context.Operators.Select<Encounter, Condition>(i_, j_);

			return k_;
		};
		var d_ = context.Operators.SelectMany<Condition, Condition>((IEnumerable<Condition>)b_, c_);
		var e_ = context.Operators.SingletonFrom<Condition>(d_);

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
			var f_ = new Tuple_GNNDVIQPcTANSdLebhBKYIdga[]
			{
				e_,
			};
			bool? g_(Tuple_GNNDVIQPcTANSdLebhBKYIdga FollowUpUSSAssessment)
			{
				var k_ = QICoreCommon_2_0_000.prevalenceInterval(MorbidObesity);
				var l_ = this.Measurement_Period();
				var m_ = context.Operators.Overlaps(k_, l_, null);
				var o_ = context.Operators.Start(k_);
				var p_ = FollowUpUSSAssessment?.effectiveDatetime;
				var q_ = context.Operators.SameOrBefore(o_, p_, null);
				var r_ = context.Operators.And(m_, q_);
				var s_ = this.isConfirmedActiveDiagnosis(MorbidObesity);
				var t_ = context.Operators.And(r_, s_);

				return t_;
			};
			var h_ = context.Operators.Where<Tuple_GNNDVIQPcTANSdLebhBKYIdga>((IEnumerable<Tuple_GNNDVIQPcTANSdLebhBKYIdga>)f_, g_);
			Condition i_(Tuple_GNNDVIQPcTANSdLebhBKYIdga FollowUpUSSAssessment) => 
				MorbidObesity;
			var j_ = context.Operators.Select<Tuple_GNNDVIQPcTANSdLebhBKYIdga, Condition>(h_, i_);

			return j_;
		};
		var d_ = context.Operators.SelectMany<Condition, Condition>(b_, c_);

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
			var h_ = new Tuple_GNNDVIQPcTANSdLebhBKYIdga[]
			{
				g_,
			};
			bool? i_(Tuple_GNNDVIQPcTANSdLebhBKYIdga FollowUpUSSAssessment)
			{
				var m_ = BMIExam?.Value;
				var n_ = context.Operators.Convert<Quantity>(m_);
				var o_ = FHIRHelpers_4_3_000.ToQuantity(n_);
				var p_ = context.Operators.Quantity(40m, "kg/m2");
				var q_ = context.Operators.Greater(o_, p_);
				var r_ = BMIExam?.StatusElement;
				var s_ = r_?.Value;
				var t_ = context.Operators.Convert<string>(s_);
				var u_ = new string[]
				{
					"final",
					"amended",
					"corrected",
				};
				var v_ = context.Operators.In<string>(t_, (u_ as IEnumerable<string>));
				var w_ = context.Operators.And(q_, v_);
				var x_ = BMIExam?.Effective;
				var y_ = FHIRHelpers_4_3_000.ToValue(x_);
				var z_ = QICoreCommon_2_0_000.earliest(y_);
				var aa_ = this.Measurement_Period();
				var ab_ = context.Operators.In<CqlDateTime>(z_, aa_, "day");
				var ac_ = context.Operators.And(w_, ab_);
				var ae_ = FHIRHelpers_4_3_000.ToValue(x_);
				var af_ = QICoreCommon_2_0_000.earliest(ae_);
				var ag_ = FollowUpUSSAssessment?.effectiveDatetime;
				var ah_ = context.Operators.SameOrBefore(af_, ag_, null);
				var ai_ = context.Operators.And(ac_, ah_);

				return ai_;
			};
			var j_ = context.Operators.Where<Tuple_GNNDVIQPcTANSdLebhBKYIdga>((IEnumerable<Tuple_GNNDVIQPcTANSdLebhBKYIdga>)h_, i_);
			Observation k_(Tuple_GNNDVIQPcTANSdLebhBKYIdga FollowUpUSSAssessment) => 
				BMIExam;
			var l_ = context.Operators.Select<Tuple_GNNDVIQPcTANSdLebhBKYIdga, Observation>(j_, k_);

			return l_;
		};
		var c_ = context.Operators.SelectMany<Observation, Observation>(a_, b_);
		CqlDateTime d_(Observation BMIExam)
		{
			var aj_ = BMIExam?.Effective;
			var ak_ = FHIRHelpers_4_3_000.ToValue(aj_);
			var al_ = QICoreCommon_2_0_000.earliest(ak_);

			return al_;
		};
		var e_ = context.Operators.Select<Observation, CqlDateTime>(c_, d_);
		var f_ = context.Operators.Exists<CqlDateTime>(e_);

		return f_;
	}

    [CqlDeclaration("Has BMI Exam Result Greater Than or Equal To 40 During Measurement Period and On or Before Follow Up USS Assessment")]
	public bool? Has_BMI_Exam_Result_Greater_Than_or_Equal_To_40_During_Measurement_Period_and_On_or_Before_Follow_Up_USS_Assessment() => 
		__Has_BMI_Exam_Result_Greater_Than_or_Equal_To_40_During_Measurement_Period_and_On_or_Before_Follow_Up_USS_Assessment.Value;

	private bool? Has_Morbid_Obesity_Diagnosis_or_BMI_Exam_Result__Greater_Than_or_Equal_to_40_Starts_On_or_Before_Follow_Up_USS_Assessment_Value()
	{
		var a_ = this.Morbid_Obesity_Diagnosis_On_or_Before_Follow_Up_USS_Assessment();
		var b_ = context.Operators.Exists<Condition>(a_);
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
		var b_ = context.Operators.Exists<Condition>(a_);
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
		var b_ = new Tuple_GNNDVIQPcTANSdLebhBKYIdga[]
		{
			a_,
		};
		var c_ = this.Urinary_Symptom_Score_6_to_12_Months_After_Initial_BPH_Diagnosis();
		var d_ = new Tuple_GNNDVIQPcTANSdLebhBKYIdga[]
		{
			c_,
		};
		var e_ = context.Operators.CrossJoin<Tuple_GNNDVIQPcTANSdLebhBKYIdga, Tuple_GNNDVIQPcTANSdLebhBKYIdga>((IEnumerable<Tuple_GNNDVIQPcTANSdLebhBKYIdga>)b_, (IEnumerable<Tuple_GNNDVIQPcTANSdLebhBKYIdga>)d_);
		Tuple_FBHNjYWJgMKheadEZUgcdQGXN f_(ValueTuple<Tuple_GNNDVIQPcTANSdLebhBKYIdga, Tuple_GNNDVIQPcTANSdLebhBKYIdga> _valueTuple)
		{
			var k_ = new Tuple_FBHNjYWJgMKheadEZUgcdQGXN
			{
				FirstUSSAssessment = _valueTuple.Item1,
				FollowUpUSSAssessment = _valueTuple.Item2,
			};

			return k_;
		};
		var g_ = context.Operators.Select<ValueTuple<Tuple_GNNDVIQPcTANSdLebhBKYIdga, Tuple_GNNDVIQPcTANSdLebhBKYIdga>, Tuple_FBHNjYWJgMKheadEZUgcdQGXN>(e_, f_);
		int? h_(Tuple_FBHNjYWJgMKheadEZUgcdQGXN tuple_fbhnjywjgmkheadezugcdqgxn)
		{
			var l_ = tuple_fbhnjywjgmkheadezugcdqgxn.FirstUSSAssessment?.valueInteger;
			var m_ = tuple_fbhnjywjgmkheadezugcdqgxn.FollowUpUSSAssessment?.valueInteger;
			var n_ = context.Operators.Subtract(l_, m_);

			return n_;
		};
		var i_ = context.Operators.Select<Tuple_FBHNjYWJgMKheadEZUgcdQGXN, int?>(g_, h_);
		var j_ = context.Operators.SingletonFrom<int?>(i_);

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
			var g_ = context.Operators.GreaterOrEqual(USSImprovement, 3);

			return g_;
		};
		var d_ = context.Operators.Where<int?>((IEnumerable<int?>)b_, c_);
		var e_ = context.Operators.SingletonFrom<int?>(d_);
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

	private Tuple_HPcCiDPXQfZTXIORThMLfTQDR SDE_Ethnicity_Value()
	{
		var a_ = SupplementalDataElements_3_4_000.SDE_Ethnicity();

		return a_;
	}

    [CqlDeclaration("SDE Ethnicity")]
	public Tuple_HPcCiDPXQfZTXIORThMLfTQDR SDE_Ethnicity() => 
		__SDE_Ethnicity.Value;

	private IEnumerable<Tuple_GPRWMPNAYaJRiGDFSTLJOPeIJ> SDE_Payer_Value()
	{
		var a_ = SupplementalDataElements_3_4_000.SDE_Payer();

		return a_;
	}

    [CqlDeclaration("SDE Payer")]
	public IEnumerable<Tuple_GPRWMPNAYaJRiGDFSTLJOPeIJ> SDE_Payer() => 
		__SDE_Payer.Value;

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

}
