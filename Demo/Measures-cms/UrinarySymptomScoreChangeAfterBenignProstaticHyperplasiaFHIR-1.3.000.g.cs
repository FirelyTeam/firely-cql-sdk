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
    internal Lazy<IEnumerable<Tuple_HHCMSSZgDEUSHVCefGhfGYQZI>> __Documented_IPSS_Assessment_Result;
    internal Lazy<IEnumerable<Tuple_HHCMSSZgDEUSHVCefGhfGYQZI>> __AUA_Symptom_Index_and_Quality_of_Life_Assessment_Result;
    internal Lazy<IEnumerable<Tuple_HHCMSSZgDEUSHVCefGhfGYQZI>> __Urinary_Symptom_Score_Assessment;
    internal Lazy<Tuple_HHCMSSZgDEUSHVCefGhfGYQZI> __Urinary_Symptom_Score_Within_1_Month_after_Initial_BPH_Diagnosis;
    internal Lazy<Tuple_HHCMSSZgDEUSHVCefGhfGYQZI> __Urinary_Symptom_Score_6_to_12_Months_After_Initial_BPH_Diagnosis;
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
    internal Lazy<Tuple_DMgHTLENEHBHWJISQgKZGZVMB> __SDE_Ethnicity;
    internal Lazy<IEnumerable<Tuple_GDKRbfOIHhLGieQSVDEMIaDPX>> __SDE_Payer;
    internal Lazy<Tuple_DMgHTLENEHBHWJISQgKZGZVMB> __SDE_Race;
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
        __Documented_IPSS_Assessment_Result = new Lazy<IEnumerable<Tuple_HHCMSSZgDEUSHVCefGhfGYQZI>>(this.Documented_IPSS_Assessment_Result_Value);
        __AUA_Symptom_Index_and_Quality_of_Life_Assessment_Result = new Lazy<IEnumerable<Tuple_HHCMSSZgDEUSHVCefGhfGYQZI>>(this.AUA_Symptom_Index_and_Quality_of_Life_Assessment_Result_Value);
        __Urinary_Symptom_Score_Assessment = new Lazy<IEnumerable<Tuple_HHCMSSZgDEUSHVCefGhfGYQZI>>(this.Urinary_Symptom_Score_Assessment_Value);
        __Urinary_Symptom_Score_Within_1_Month_after_Initial_BPH_Diagnosis = new Lazy<Tuple_HHCMSSZgDEUSHVCefGhfGYQZI>(this.Urinary_Symptom_Score_Within_1_Month_after_Initial_BPH_Diagnosis_Value);
        __Urinary_Symptom_Score_6_to_12_Months_After_Initial_BPH_Diagnosis = new Lazy<Tuple_HHCMSSZgDEUSHVCefGhfGYQZI>(this.Urinary_Symptom_Score_6_to_12_Months_After_Initial_BPH_Diagnosis_Value);
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
        __SDE_Ethnicity = new Lazy<Tuple_DMgHTLENEHBHWJISQgKZGZVMB>(this.SDE_Ethnicity_Value);
        __SDE_Payer = new Lazy<IEnumerable<Tuple_GDKRbfOIHhLGieQSVDEMIaDPX>>(this.SDE_Payer_Value);
        __SDE_Race = new Lazy<Tuple_DMgHTLENEHBHWJISQgKZGZVMB>(this.SDE_Race_Value);
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
		CqlCode[] a_ = new CqlCode[]
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
		CqlCode[] a_ = new CqlCode[]
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
		CqlCode[] a_ = new CqlCode[]
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
		CqlCode[] a_ = new CqlCode[]
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
		CqlDateTime a_ = context.Operators.DateTime(2025, 1, 1, 0, 0, 0, 0, default);
		CqlDateTime b_ = context.Operators.DateTime(2026, 1, 1, 0, 0, 0, 0, default);
		CqlInterval<CqlDateTime> c_ = context.Operators.Interval(a_, b_, true, false);
		object d_ = context.ResolveParameter("UrinarySymptomScoreChangeAfterBenignProstaticHyperplasiaFHIR-1.3.000", "Measurement Period", c_);

		return (CqlInterval<CqlDateTime>)d_;
	}

    [CqlDeclaration("Measurement Period")]
	public CqlInterval<CqlDateTime> Measurement_Period() => 
		__Measurement_Period.Value;

	private Patient Patient_Value()
	{
		IEnumerable<Patient> a_ = context.Operators.RetrieveByValueSet<Patient>(null, null);
		Patient b_ = context.Operators.SingletonFrom<Patient>(a_);

		return b_;
	}

    [CqlDeclaration("Patient")]
	public Patient Patient() => 
		__Patient.Value;

	private bool? Patient_is_Male_Value()
	{
		Patient a_ = this.Patient();
		bool? b_ = context.Operators.Equal(a_?.GenderElement?.Value, "male");

		return b_;
	}

    [CqlDeclaration("Patient is Male")]
	public bool? Patient_is_Male() => 
		__Patient_is_Male.Value;

	private bool? Has_Qualifying_Encounter_Value()
	{
		CqlValueSet a_ = this.Office_Visit();
		IEnumerable<Encounter> b_ = context.Operators.RetrieveByValueSet<Encounter>(a_, null);
		bool? c_(Encounter ValidEncounter)
		{
			CqlInterval<CqlDateTime> f_ = this.Measurement_Period();
			CqlInterval<CqlDateTime> g_ = FHIRHelpers_4_3_000.ToInterval(ValidEncounter?.Period);
			bool? h_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(f_, g_, "day");
			CqlCode i_ = FHIRHelpers_4_3_000.ToCode(ValidEncounter?.Class);
			CqlCode j_ = this.@virtual();
			bool? k_ = context.Operators.Equivalent(i_, j_);
			bool? l_ = context.Operators.Not(k_);
			bool? m_ = context.Operators.And(h_, l_);
			Code<Encounter.EncounterStatus> n_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(ValidEncounter?.StatusElement?.Value);
			bool? o_ = context.Operators.Equal(n_, "finished");
			bool? p_ = context.Operators.And(m_, o_);

			return p_;
		};
		IEnumerable<Encounter> d_ = context.Operators.Where<Encounter>(b_, c_);
		bool? e_ = context.Operators.Exists<Encounter>(d_);

		return e_;
	}

    [CqlDeclaration("Has Qualifying Encounter")]
	public bool? Has_Qualifying_Encounter() => 
		__Has_Qualifying_Encounter.Value;

    [CqlDeclaration("isConfirmedActiveDiagnosis")]
	public bool? isConfirmedActiveDiagnosis(Condition Condition)
	{
		Condition[] a_ = new Condition[]
		{
			Condition,
		};
		bool? b_(Condition Diagnosis)
		{
			CqlConcept f_ = FHIRHelpers_4_3_000.ToConcept(Diagnosis?.ClinicalStatus);
			CqlCode g_ = QICoreCommon_2_0_000.active();
			CqlConcept h_ = context.Operators.ConvertCodeToConcept(g_);
			bool? i_ = context.Operators.Equivalent(f_, h_);
			CqlConcept j_ = FHIRHelpers_4_3_000.ToConcept(Diagnosis?.VerificationStatus);
			CqlCode k_ = QICoreCommon_2_0_000.unconfirmed();
			CqlConcept l_ = context.Operators.ConvertCodeToConcept(k_);
			bool? m_ = context.Operators.Equivalent(j_, l_);
			CqlCode o_ = QICoreCommon_2_0_000.refuted();
			CqlConcept p_ = context.Operators.ConvertCodeToConcept(o_);
			bool? q_ = context.Operators.Equivalent(j_, p_);
			bool? r_ = context.Operators.Or(m_, q_);
			CqlCode t_ = QICoreCommon_2_0_000.entered_in_error();
			CqlConcept u_ = context.Operators.ConvertCodeToConcept(t_);
			bool? v_ = context.Operators.Equivalent(j_, u_);
			bool? w_ = context.Operators.Or(r_, v_);
			bool? x_ = context.Operators.Not(w_);
			bool? y_ = context.Operators.And(i_, x_);

			return y_;
		};
		IEnumerable<Condition> c_ = context.Operators.Where<Condition>(a_, b_);
		Condition d_ = context.Operators.SingletonFrom<Condition>(c_);
		bool? e_ = context.Operators.Not((bool?)(d_ is null));

		return e_;
	}

	private Condition Initial_BPH_Diagnosis_Starts_Within_6_Months_Before_or_After_Start_of_Measurement_Period_Value()
	{
		CqlCode a_ = this.Benign_prostatic_hyperplasia_with_lower_urinary_tract_symptoms();
		IEnumerable<CqlCode> b_ = context.Operators.ToList<CqlCode>(a_);
		IEnumerable<Condition> c_ = context.Operators.RetrieveByCodes<Condition>(b_, null);
		bool? d_(Condition NewBPHDiagnosis)
		{
			CqlInterval<CqlDateTime> i_ = QICoreCommon_2_0_000.prevalenceInterval(NewBPHDiagnosis);
			CqlDateTime j_ = context.Operators.Start(i_);
			CqlInterval<CqlDateTime> k_ = this.Measurement_Period();
			CqlDateTime l_ = context.Operators.Start(k_);
			CqlQuantity m_ = context.Operators.Quantity(6m, "months");
			CqlDateTime n_ = context.Operators.Subtract(l_, m_);
			CqlDateTime p_ = context.Operators.End(k_);
			CqlInterval<CqlDateTime> q_ = context.Operators.Interval(n_, p_, true, true);
			bool? r_ = context.Operators.In<CqlDateTime>(j_, q_, "day");
			bool? s_ = this.isConfirmedActiveDiagnosis(NewBPHDiagnosis);
			bool? t_ = context.Operators.And(r_, s_);

			return t_;
		};
		IEnumerable<Condition> e_ = context.Operators.Where<Condition>(c_, d_);
		object f_(Condition @this)
		{
			object u_ = FHIRHelpers_4_3_000.ToValue(@this?.Onset);
			CqlInterval<CqlDateTime> v_ = QICoreCommon_2_0_000.toInterval(u_);
			CqlDateTime w_ = context.Operators.Start(v_);

			return w_;
		};
		IEnumerable<Condition> g_ = context.Operators.SortBy<Condition>(e_, f_, System.ComponentModel.ListSortDirection.Ascending);
		Condition h_ = context.Operators.First<Condition>(g_);

		return h_;
	}

    [CqlDeclaration("Initial BPH Diagnosis Starts Within 6 Months Before or After Start of Measurement Period")]
	public Condition Initial_BPH_Diagnosis_Starts_Within_6_Months_Before_or_After_Start_of_Measurement_Period() => 
		__Initial_BPH_Diagnosis_Starts_Within_6_Months_Before_or_After_Start_of_Measurement_Period.Value;

	private bool? Has_Qualifying_BPH_Diagnosis_Value()
	{
		Condition a_ = this.Initial_BPH_Diagnosis_Starts_Within_6_Months_Before_or_After_Start_of_Measurement_Period();
		bool? b_ = context.Operators.Not((bool?)(a_ is null));

		return b_;
	}

    [CqlDeclaration("Has Qualifying BPH Diagnosis")]
	public bool? Has_Qualifying_BPH_Diagnosis() => 
		__Has_Qualifying_BPH_Diagnosis.Value;

	private IEnumerable<Tuple_HHCMSSZgDEUSHVCefGhfGYQZI> Documented_IPSS_Assessment_Result_Value()
	{
		CqlCode a_ = this.International_Prostate_Symptom_Score__IPSS_();
		IEnumerable<CqlCode> b_ = context.Operators.ToList<CqlCode>(a_);
		IEnumerable<Observation> c_ = context.Operators.RetrieveByCodes<Observation>(b_, null);
		bool? d_(Observation IPSSAssessment)
		{
			Code<ObservationStatus> h_ = context.Operators.Convert<Code<ObservationStatus>>(IPSSAssessment?.StatusElement?.Value);
			string i_ = context.Operators.Convert<string>(h_);
			string[] j_ = new string[]
			{
				"final",
				"amended",
				"corrected",
			};
			bool? k_ = context.Operators.In<string>(i_, (j_ as IEnumerable<string>));
			object l_ = FHIRHelpers_4_3_000.ToValue(IPSSAssessment?.Value);
			bool? m_ = context.Operators.Not((bool?)(l_ is null));
			bool? n_ = context.Operators.And(k_, m_);

			return n_;
		};
		IEnumerable<Observation> e_ = context.Operators.Where<Observation>(c_, d_);
		Tuple_HHCMSSZgDEUSHVCefGhfGYQZI f_(Observation IPSSAssessment)
		{
			object o_()
			{
				bool s_()
				{
					object v_ = FHIRHelpers_4_3_000.ToValue(IPSSAssessment?.Effective);
					bool w_ = v_ is CqlDateTime;

					return w_;
				};
				bool t_()
				{
					object x_ = FHIRHelpers_4_3_000.ToValue(IPSSAssessment?.Effective);
					bool y_ = x_ is CqlInterval<CqlDateTime>;

					return y_;
				};
				bool u_()
				{
					object z_ = FHIRHelpers_4_3_000.ToValue(IPSSAssessment?.Effective);
					bool aa_ = z_ is CqlDateTime;

					return aa_;
				};
				if (s_())
				{
					object ab_ = FHIRHelpers_4_3_000.ToValue(IPSSAssessment?.Effective);

					return ((ab_ as CqlDateTime) as object);
				}
				else if (t_())
				{
					object ac_ = FHIRHelpers_4_3_000.ToValue(IPSSAssessment?.Effective);

					return ((ac_ as CqlInterval<CqlDateTime>) as object);
				}
				else if (u_())
				{
					object ad_ = FHIRHelpers_4_3_000.ToValue(IPSSAssessment?.Effective);

					return ((ad_ as CqlDateTime) as object);
				}
				else
				{
					return null;
				};
			};
			CqlDateTime p_ = QICoreCommon_2_0_000.earliest(o_());
			object q_ = FHIRHelpers_4_3_000.ToValue(IPSSAssessment?.Value);
			Tuple_HHCMSSZgDEUSHVCefGhfGYQZI r_ = new Tuple_HHCMSSZgDEUSHVCefGhfGYQZI
			{
				effectiveDatetime = p_,
				valueInteger = (int?)q_,
			};

			return r_;
		};
		IEnumerable<Tuple_HHCMSSZgDEUSHVCefGhfGYQZI> g_ = context.Operators.Select<Observation, Tuple_HHCMSSZgDEUSHVCefGhfGYQZI>(e_, f_);

		return g_;
	}

    [CqlDeclaration("Documented IPSS Assessment Result")]
	public IEnumerable<Tuple_HHCMSSZgDEUSHVCefGhfGYQZI> Documented_IPSS_Assessment_Result() => 
		__Documented_IPSS_Assessment_Result.Value;

	private IEnumerable<Tuple_HHCMSSZgDEUSHVCefGhfGYQZI> AUA_Symptom_Index_and_Quality_of_Life_Assessment_Result_Value()
	{
		CqlCode a_ = this.American_Urological_Association_Symptom_Index__AUASI_();
		IEnumerable<CqlCode> b_ = context.Operators.ToList<CqlCode>(a_);
		IEnumerable<Observation> c_ = context.Operators.RetrieveByCodes<Observation>(b_, null);
		bool? d_(Observation AUASIAssessment)
		{
			CqlConcept h_(CodeableConcept @this)
			{
				CqlConcept u_ = FHIRHelpers_4_3_000.ToConcept(@this);

				return u_;
			};
			IEnumerable<CqlConcept> i_ = context.Operators.Select<CodeableConcept, CqlConcept>(AUASIAssessment?.Category, h_);
			bool? j_(CqlConcept AUASIAssessmentCategory)
			{
				CqlCode v_ = this.survey();
				CqlConcept w_ = context.Operators.ConvertCodeToConcept(v_);
				bool? x_ = context.Operators.Equivalent(AUASIAssessmentCategory, w_);

				return x_;
			};
			IEnumerable<CqlConcept> k_ = context.Operators.Where<CqlConcept>(i_, j_);
			bool? l_ = context.Operators.Exists<CqlConcept>(k_);
			Code<ObservationStatus> m_ = context.Operators.Convert<Code<ObservationStatus>>(AUASIAssessment?.StatusElement?.Value);
			string n_ = context.Operators.Convert<string>(m_);
			string[] o_ = new string[]
			{
				"final",
				"amended",
				"corrected",
			};
			bool? p_ = context.Operators.In<string>(n_, (o_ as IEnumerable<string>));
			bool? q_ = context.Operators.And(l_, p_);
			object r_ = FHIRHelpers_4_3_000.ToValue(AUASIAssessment?.Value);
			bool? s_ = context.Operators.Not((bool?)(r_ is null));
			bool? t_ = context.Operators.And(q_, s_);

			return t_;
		};
		IEnumerable<Observation> e_ = context.Operators.Where<Observation>(c_, d_);
		Tuple_HHCMSSZgDEUSHVCefGhfGYQZI f_(Observation AUASIAssessment)
		{
			object y_()
			{
				bool am_()
				{
					object ap_ = FHIRHelpers_4_3_000.ToValue(AUASIAssessment?.Effective);
					bool aq_ = ap_ is CqlDateTime;

					return aq_;
				};
				bool an_()
				{
					object ar_ = FHIRHelpers_4_3_000.ToValue(AUASIAssessment?.Effective);
					bool as_ = ar_ is CqlInterval<CqlDateTime>;

					return as_;
				};
				bool ao_()
				{
					object at_ = FHIRHelpers_4_3_000.ToValue(AUASIAssessment?.Effective);
					bool au_ = at_ is CqlDateTime;

					return au_;
				};
				if (am_())
				{
					object av_ = FHIRHelpers_4_3_000.ToValue(AUASIAssessment?.Effective);

					return ((av_ as CqlDateTime) as object);
				}
				else if (an_())
				{
					object aw_ = FHIRHelpers_4_3_000.ToValue(AUASIAssessment?.Effective);

					return ((aw_ as CqlInterval<CqlDateTime>) as object);
				}
				else if (ao_())
				{
					object ax_ = FHIRHelpers_4_3_000.ToValue(AUASIAssessment?.Effective);

					return ((ax_ as CqlDateTime) as object);
				}
				else
				{
					return null;
				};
			};
			CqlDateTime z_ = QICoreCommon_2_0_000.earliest(y_());
			object aa_ = FHIRHelpers_4_3_000.ToValue(AUASIAssessment?.Value);
			CqlCode ab_ = this.If_you_were_to_spend_the_rest_of_your_life_with_your_urinary_condition_just_the_way_it_is_now__how_would_you_feel_about_that__IPSS_();
			IEnumerable<CqlCode> ac_ = context.Operators.ToList<CqlCode>(ab_);
			IEnumerable<Observation> ad_ = context.Operators.RetrieveByCodes<Observation>(ac_, null);
			bool? ae_(Observation QOLAssessment)
			{
				object ay_()
				{
					bool br_()
					{
						object bu_ = FHIRHelpers_4_3_000.ToValue(QOLAssessment?.Effective);
						bool bv_ = bu_ is CqlDateTime;

						return bv_;
					};
					bool bs_()
					{
						object bw_ = FHIRHelpers_4_3_000.ToValue(QOLAssessment?.Effective);
						bool bx_ = bw_ is CqlInterval<CqlDateTime>;

						return bx_;
					};
					bool bt_()
					{
						object by_ = FHIRHelpers_4_3_000.ToValue(QOLAssessment?.Effective);
						bool bz_ = by_ is CqlDateTime;

						return bz_;
					};
					if (br_())
					{
						object ca_ = FHIRHelpers_4_3_000.ToValue(QOLAssessment?.Effective);

						return ((ca_ as CqlDateTime) as object);
					}
					else if (bs_())
					{
						object cb_ = FHIRHelpers_4_3_000.ToValue(QOLAssessment?.Effective);

						return ((cb_ as CqlInterval<CqlDateTime>) as object);
					}
					else if (bt_())
					{
						object cc_ = FHIRHelpers_4_3_000.ToValue(QOLAssessment?.Effective);

						return ((cc_ as CqlDateTime) as object);
					}
					else
					{
						return null;
					};
				};
				CqlDateTime az_ = QICoreCommon_2_0_000.earliest(ay_());
				object ba_()
				{
					bool cd_()
					{
						object cg_ = FHIRHelpers_4_3_000.ToValue(QOLAssessment?.Effective);
						bool ch_ = cg_ is CqlDateTime;

						return ch_;
					};
					bool ce_()
					{
						object ci_ = FHIRHelpers_4_3_000.ToValue(QOLAssessment?.Effective);
						bool cj_ = ci_ is CqlInterval<CqlDateTime>;

						return cj_;
					};
					bool cf_()
					{
						object ck_ = FHIRHelpers_4_3_000.ToValue(QOLAssessment?.Effective);
						bool cl_ = ck_ is CqlDateTime;

						return cl_;
					};
					if (cd_())
					{
						object cm_ = FHIRHelpers_4_3_000.ToValue(QOLAssessment?.Effective);

						return ((cm_ as CqlDateTime) as object);
					}
					else if (ce_())
					{
						object cn_ = FHIRHelpers_4_3_000.ToValue(QOLAssessment?.Effective);

						return ((cn_ as CqlInterval<CqlDateTime>) as object);
					}
					else if (cf_())
					{
						object co_ = FHIRHelpers_4_3_000.ToValue(QOLAssessment?.Effective);

						return ((co_ as CqlDateTime) as object);
					}
					else
					{
						return null;
					};
				};
				CqlDateTime bb_ = QICoreCommon_2_0_000.earliest(ba_());
				bool? bc_ = context.Operators.SameAs(az_, bb_, "day");
				CqlConcept bd_(CodeableConcept @this)
				{
					CqlConcept cp_ = FHIRHelpers_4_3_000.ToConcept(@this);

					return cp_;
				};
				IEnumerable<CqlConcept> be_ = context.Operators.Select<CodeableConcept, CqlConcept>(QOLAssessment?.Category, bd_);
				bool? bf_(CqlConcept QOLAssessmentCategory)
				{
					CqlCode cq_ = this.survey();
					CqlConcept cr_ = context.Operators.ConvertCodeToConcept(cq_);
					bool? cs_ = context.Operators.Equivalent(QOLAssessmentCategory, cr_);

					return cs_;
				};
				IEnumerable<CqlConcept> bg_ = context.Operators.Where<CqlConcept>(be_, bf_);
				bool? bh_ = context.Operators.Exists<CqlConcept>(bg_);
				bool? bi_ = context.Operators.And(bc_, bh_);
				Code<ObservationStatus> bj_ = context.Operators.Convert<Code<ObservationStatus>>(QOLAssessment?.StatusElement?.Value);
				string bk_ = context.Operators.Convert<string>(bj_);
				string[] bl_ = new string[]
				{
					"final",
					"amended",
					"corrected",
				};
				bool? bm_ = context.Operators.In<string>(bk_, (bl_ as IEnumerable<string>));
				bool? bn_ = context.Operators.And(bi_, bm_);
				object bo_ = FHIRHelpers_4_3_000.ToValue(QOLAssessment?.Value);
				bool? bp_ = context.Operators.Not((bool?)(bo_ is null));
				bool? bq_ = context.Operators.And(bn_, bp_);

				return bq_;
			};
			IEnumerable<Observation> af_ = context.Operators.Where<Observation>(ad_, ae_);
			object ag_(Observation @this)
			{
				object ct_()
				{
					bool cv_()
					{
						object cy_ = FHIRHelpers_4_3_000.ToValue(@this?.Effective);
						bool cz_ = cy_ is CqlDateTime;

						return cz_;
					};
					bool cw_()
					{
						object da_ = FHIRHelpers_4_3_000.ToValue(@this?.Effective);
						bool db_ = da_ is CqlInterval<CqlDateTime>;

						return db_;
					};
					bool cx_()
					{
						object dc_ = FHIRHelpers_4_3_000.ToValue(@this?.Effective);
						bool dd_ = dc_ is CqlDateTime;

						return dd_;
					};
					if (cv_())
					{
						object de_ = FHIRHelpers_4_3_000.ToValue(@this?.Effective);

						return ((de_ as CqlDateTime) as object);
					}
					else if (cw_())
					{
						object df_ = FHIRHelpers_4_3_000.ToValue(@this?.Effective);

						return ((df_ as CqlInterval<CqlDateTime>) as object);
					}
					else if (cx_())
					{
						object dg_ = FHIRHelpers_4_3_000.ToValue(@this?.Effective);

						return ((dg_ as CqlDateTime) as object);
					}
					else
					{
						return null;
					};
				};
				CqlDateTime cu_ = QICoreCommon_2_0_000.earliest(ct_());

				return cu_;
			};
			IEnumerable<Observation> ah_ = context.Operators.SortBy<Observation>(af_, ag_, System.ComponentModel.ListSortDirection.Ascending);
			Observation ai_ = context.Operators.Last<Observation>(ah_);
			object aj_ = FHIRHelpers_4_3_000.ToValue(ai_?.Value);
			int? ak_ = context.Operators.Add((int?)aa_, (int?)aj_);
			Tuple_HHCMSSZgDEUSHVCefGhfGYQZI al_ = new Tuple_HHCMSSZgDEUSHVCefGhfGYQZI
			{
				effectiveDatetime = z_,
				valueInteger = ak_,
			};

			return al_;
		};
		IEnumerable<Tuple_HHCMSSZgDEUSHVCefGhfGYQZI> g_ = context.Operators.Select<Observation, Tuple_HHCMSSZgDEUSHVCefGhfGYQZI>(e_, f_);

		return g_;
	}

    [CqlDeclaration("AUA Symptom Index and Quality of Life Assessment Result")]
	public IEnumerable<Tuple_HHCMSSZgDEUSHVCefGhfGYQZI> AUA_Symptom_Index_and_Quality_of_Life_Assessment_Result() => 
		__AUA_Symptom_Index_and_Quality_of_Life_Assessment_Result.Value;

	private IEnumerable<Tuple_HHCMSSZgDEUSHVCefGhfGYQZI> Urinary_Symptom_Score_Assessment_Value()
	{
		IEnumerable<Tuple_HHCMSSZgDEUSHVCefGhfGYQZI> a_ = this.Documented_IPSS_Assessment_Result();
		IEnumerable<Tuple_HHCMSSZgDEUSHVCefGhfGYQZI> b_ = this.AUA_Symptom_Index_and_Quality_of_Life_Assessment_Result();
		IEnumerable<Tuple_HHCMSSZgDEUSHVCefGhfGYQZI> c_ = context.Operators.ListUnion<Tuple_HHCMSSZgDEUSHVCefGhfGYQZI>(a_, b_);

		return c_;
	}

    [CqlDeclaration("Urinary Symptom Score Assessment")]
	public IEnumerable<Tuple_HHCMSSZgDEUSHVCefGhfGYQZI> Urinary_Symptom_Score_Assessment() => 
		__Urinary_Symptom_Score_Assessment.Value;

	private Tuple_HHCMSSZgDEUSHVCefGhfGYQZI Urinary_Symptom_Score_Within_1_Month_after_Initial_BPH_Diagnosis_Value()
	{
		IEnumerable<Tuple_HHCMSSZgDEUSHVCefGhfGYQZI> a_ = this.Urinary_Symptom_Score_Assessment();
		IEnumerable<Tuple_HHCMSSZgDEUSHVCefGhfGYQZI> b_(Tuple_HHCMSSZgDEUSHVCefGhfGYQZI USSAssessment)
		{
			Condition g_ = this.Initial_BPH_Diagnosis_Starts_Within_6_Months_Before_or_After_Start_of_Measurement_Period();
			Condition[] h_ = new Condition[]
			{
				g_,
			};
			bool? i_(Condition InitialBPHDiagnosis)
			{
				CqlInterval<CqlDateTime> m_ = QICoreCommon_2_0_000.prevalenceInterval(InitialBPHDiagnosis);
				CqlDateTime n_ = context.Operators.Start(m_);
				CqlDateTime p_ = context.Operators.Start(m_);
				CqlQuantity q_ = context.Operators.Quantity(1m, "month");
				CqlDateTime r_ = context.Operators.Add(p_, q_);
				CqlInterval<CqlDateTime> s_ = context.Operators.Interval(n_, r_, true, true);
				bool? t_ = context.Operators.In<CqlDateTime>(USSAssessment?.effectiveDatetime, s_, "day");
				CqlDateTime v_ = context.Operators.Start(m_);
				bool? w_ = context.Operators.Not((bool?)(v_ is null));
				bool? x_ = context.Operators.And(t_, w_);

				return x_;
			};
			IEnumerable<Condition> j_ = context.Operators.Where<Condition>(h_, i_);
			Tuple_HHCMSSZgDEUSHVCefGhfGYQZI k_(Condition InitialBPHDiagnosis) => 
				USSAssessment;
			IEnumerable<Tuple_HHCMSSZgDEUSHVCefGhfGYQZI> l_ = context.Operators.Select<Condition, Tuple_HHCMSSZgDEUSHVCefGhfGYQZI>(j_, k_);

			return l_;
		};
		IEnumerable<Tuple_HHCMSSZgDEUSHVCefGhfGYQZI> c_ = context.Operators.SelectMany<Tuple_HHCMSSZgDEUSHVCefGhfGYQZI, Tuple_HHCMSSZgDEUSHVCefGhfGYQZI>(a_, b_);
		object d_(Tuple_HHCMSSZgDEUSHVCefGhfGYQZI @this) => 
			@this?.effectiveDatetime;
		IEnumerable<Tuple_HHCMSSZgDEUSHVCefGhfGYQZI> e_ = context.Operators.SortBy<Tuple_HHCMSSZgDEUSHVCefGhfGYQZI>(c_, d_, System.ComponentModel.ListSortDirection.Ascending);
		Tuple_HHCMSSZgDEUSHVCefGhfGYQZI f_ = context.Operators.First<Tuple_HHCMSSZgDEUSHVCefGhfGYQZI>(e_);

		return f_;
	}

    [CqlDeclaration("Urinary Symptom Score Within 1 Month after Initial BPH Diagnosis")]
	public Tuple_HHCMSSZgDEUSHVCefGhfGYQZI Urinary_Symptom_Score_Within_1_Month_after_Initial_BPH_Diagnosis() => 
		__Urinary_Symptom_Score_Within_1_Month_after_Initial_BPH_Diagnosis.Value;

	private Tuple_HHCMSSZgDEUSHVCefGhfGYQZI Urinary_Symptom_Score_6_to_12_Months_After_Initial_BPH_Diagnosis_Value()
	{
		IEnumerable<Tuple_HHCMSSZgDEUSHVCefGhfGYQZI> a_ = this.Urinary_Symptom_Score_Assessment();
		IEnumerable<Tuple_HHCMSSZgDEUSHVCefGhfGYQZI> b_(Tuple_HHCMSSZgDEUSHVCefGhfGYQZI USSAssessment)
		{
			Condition g_ = this.Initial_BPH_Diagnosis_Starts_Within_6_Months_Before_or_After_Start_of_Measurement_Period();
			Condition[] h_ = new Condition[]
			{
				g_,
			};
			bool? i_(Condition InitialBPHDiagnosis)
			{
				CqlInterval<CqlDateTime> m_ = QICoreCommon_2_0_000.prevalenceInterval(InitialBPHDiagnosis);
				CqlDateTime n_ = context.Operators.Start(m_);
				int? o_ = context.Operators.DurationBetween(n_, USSAssessment?.effectiveDatetime, "month");
				CqlInterval<int?> p_ = context.Operators.Interval(6, 12, true, true);
				bool? q_ = context.Operators.In<int?>(o_, p_, null);

				return q_;
			};
			IEnumerable<Condition> j_ = context.Operators.Where<Condition>(h_, i_);
			Tuple_HHCMSSZgDEUSHVCefGhfGYQZI k_(Condition InitialBPHDiagnosis) => 
				USSAssessment;
			IEnumerable<Tuple_HHCMSSZgDEUSHVCefGhfGYQZI> l_ = context.Operators.Select<Condition, Tuple_HHCMSSZgDEUSHVCefGhfGYQZI>(j_, k_);

			return l_;
		};
		IEnumerable<Tuple_HHCMSSZgDEUSHVCefGhfGYQZI> c_ = context.Operators.SelectMany<Tuple_HHCMSSZgDEUSHVCefGhfGYQZI, Tuple_HHCMSSZgDEUSHVCefGhfGYQZI>(a_, b_);
		object d_(Tuple_HHCMSSZgDEUSHVCefGhfGYQZI @this) => 
			@this?.effectiveDatetime;
		IEnumerable<Tuple_HHCMSSZgDEUSHVCefGhfGYQZI> e_ = context.Operators.SortBy<Tuple_HHCMSSZgDEUSHVCefGhfGYQZI>(c_, d_, System.ComponentModel.ListSortDirection.Ascending);
		Tuple_HHCMSSZgDEUSHVCefGhfGYQZI f_ = context.Operators.Last<Tuple_HHCMSSZgDEUSHVCefGhfGYQZI>(e_);

		return f_;
	}

    [CqlDeclaration("Urinary Symptom Score 6 to 12 Months After Initial BPH Diagnosis")]
	public Tuple_HHCMSSZgDEUSHVCefGhfGYQZI Urinary_Symptom_Score_6_to_12_Months_After_Initial_BPH_Diagnosis() => 
		__Urinary_Symptom_Score_6_to_12_Months_After_Initial_BPH_Diagnosis.Value;

	private bool? Initial_Population_Value()
	{
		bool? a_ = this.Patient_is_Male();
		bool? b_ = this.Has_Qualifying_Encounter();
		bool? c_ = context.Operators.And(a_, b_);
		bool? d_ = this.Has_Qualifying_BPH_Diagnosis();
		bool? e_ = context.Operators.And(c_, d_);
		Tuple_HHCMSSZgDEUSHVCefGhfGYQZI f_ = this.Urinary_Symptom_Score_Within_1_Month_after_Initial_BPH_Diagnosis();
		bool? g_ = context.Operators.Not((bool?)(f_ is null));
		bool? h_ = context.Operators.And(e_, g_);
		Tuple_HHCMSSZgDEUSHVCefGhfGYQZI i_ = this.Urinary_Symptom_Score_6_to_12_Months_After_Initial_BPH_Diagnosis();
		bool? j_ = context.Operators.Not((bool?)(i_ is null));
		bool? k_ = context.Operators.And(h_, j_);

		return k_;
	}

    [CqlDeclaration("Initial Population")]
	public bool? Initial_Population() => 
		__Initial_Population.Value;

	private bool? Denominator_Value()
	{
		bool? a_ = this.Initial_Population();

		return a_;
	}

    [CqlDeclaration("Denominator")]
	public bool? Denominator() => 
		__Denominator.Value;

	private IEnumerable<Condition> Urinary_Retention_Diagnosis_Starts_Within_1_Year_After_Initial_BPH_Diagnosis_Value()
	{
		CqlValueSet a_ = this.Urinary_retention();
		IEnumerable<Condition> b_ = context.Operators.RetrieveByValueSet<Condition>(a_, null);
		IEnumerable<Condition> c_(Condition UrinaryRetention)
		{
			Condition g_ = this.Initial_BPH_Diagnosis_Starts_Within_6_Months_Before_or_After_Start_of_Measurement_Period();
			Condition[] h_ = new Condition[]
			{
				g_,
			};
			bool? i_(Condition InitialBPHDiagnosis)
			{
				CqlInterval<CqlDateTime> m_ = QICoreCommon_2_0_000.prevalenceInterval(UrinaryRetention);
				CqlDateTime n_ = context.Operators.Start(m_);
				CqlInterval<CqlDateTime> o_ = QICoreCommon_2_0_000.prevalenceInterval(InitialBPHDiagnosis);
				CqlDateTime p_ = context.Operators.Start(o_);
				CqlDateTime r_ = context.Operators.Start(o_);
				CqlQuantity s_ = context.Operators.Quantity(1m, "year");
				CqlDateTime t_ = context.Operators.Add(r_, s_);
				CqlInterval<CqlDateTime> u_ = context.Operators.Interval(p_, t_, true, true);
				bool? v_ = context.Operators.In<CqlDateTime>(n_, u_, "day");
				CqlDateTime x_ = context.Operators.Start(o_);
				bool? y_ = context.Operators.Not((bool?)(x_ is null));
				bool? z_ = context.Operators.And(v_, y_);

				return z_;
			};
			IEnumerable<Condition> j_ = context.Operators.Where<Condition>(h_, i_);
			Condition k_(Condition InitialBPHDiagnosis) => 
				UrinaryRetention;
			IEnumerable<Condition> l_ = context.Operators.Select<Condition, Condition>(j_, k_);

			return l_;
		};
		IEnumerable<Condition> d_ = context.Operators.SelectMany<Condition, Condition>(b_, c_);
		bool? e_(Condition UrinaryRetention)
		{
			bool? aa_ = this.isConfirmedActiveDiagnosis(UrinaryRetention);

			return aa_;
		};
		IEnumerable<Condition> f_ = context.Operators.Where<Condition>(d_, e_);

		return f_;
	}

    [CqlDeclaration("Urinary Retention Diagnosis Starts Within 1 Year After Initial BPH Diagnosis")]
	public IEnumerable<Condition> Urinary_Retention_Diagnosis_Starts_Within_1_Year_After_Initial_BPH_Diagnosis() => 
		__Urinary_Retention_Diagnosis_Starts_Within_1_Year_After_Initial_BPH_Diagnosis.Value;

	private Condition Initial_BPH_Diagnosis_Starts_During_or_Within_30_Days_After_End_of_Hospitalization_Value()
	{
		Condition a_ = this.Initial_BPH_Diagnosis_Starts_Within_6_Months_Before_or_After_Start_of_Measurement_Period();
		Condition[] b_ = new Condition[]
		{
			a_,
		};
		IEnumerable<Condition> c_(Condition InitialBPHDiagnosis)
		{
			CqlValueSet f_ = this.Hospital_Services_for_urology_care();
			IEnumerable<Encounter> g_ = context.Operators.RetrieveByValueSet<Encounter>(f_, null);
			bool? h_(Encounter InHospitalServices)
			{
				CqlInterval<CqlDateTime> l_ = QICoreCommon_2_0_000.prevalenceInterval(InitialBPHDiagnosis);
				CqlDateTime m_ = context.Operators.Start(l_);
				CqlInterval<CqlDateTime> n_ = FHIRHelpers_4_3_000.ToInterval(InHospitalServices?.Period);
				CqlDateTime o_ = context.Operators.Start(n_);
				CqlDateTime q_ = context.Operators.End(n_);
				CqlQuantity r_ = context.Operators.Quantity(31m, "days");
				CqlDateTime s_ = context.Operators.Add(q_, r_);
				CqlInterval<CqlDateTime> t_ = context.Operators.Interval(o_, s_, true, true);
				bool? u_ = context.Operators.In<CqlDateTime>(m_, t_, null);
				Code<Encounter.EncounterStatus> v_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(InHospitalServices?.StatusElement?.Value);
				bool? w_ = context.Operators.Equal(v_, "finished");
				bool? x_ = context.Operators.And(u_, w_);

				return x_;
			};
			IEnumerable<Encounter> i_ = context.Operators.Where<Encounter>(g_, h_);
			Condition j_(Encounter InHospitalServices) => 
				InitialBPHDiagnosis;
			IEnumerable<Condition> k_ = context.Operators.Select<Encounter, Condition>(i_, j_);

			return k_;
		};
		IEnumerable<Condition> d_ = context.Operators.SelectMany<Condition, Condition>(b_, c_);
		Condition e_ = context.Operators.SingletonFrom<Condition>(d_);

		return e_;
	}

    [CqlDeclaration("Initial BPH Diagnosis Starts During or Within 30 Days After End of Hospitalization")]
	public Condition Initial_BPH_Diagnosis_Starts_During_or_Within_30_Days_After_End_of_Hospitalization() => 
		__Initial_BPH_Diagnosis_Starts_During_or_Within_30_Days_After_End_of_Hospitalization.Value;

	private IEnumerable<Condition> Morbid_Obesity_Diagnosis_On_or_Before_Follow_Up_USS_Assessment_Value()
	{
		CqlValueSet a_ = this.Morbid_Obesity();
		IEnumerable<Condition> b_ = context.Operators.RetrieveByValueSet<Condition>(a_, null);
		IEnumerable<Condition> c_(Condition MorbidObesity)
		{
			Tuple_HHCMSSZgDEUSHVCefGhfGYQZI e_ = this.Urinary_Symptom_Score_6_to_12_Months_After_Initial_BPH_Diagnosis();
			Tuple_HHCMSSZgDEUSHVCefGhfGYQZI[] f_ = new Tuple_HHCMSSZgDEUSHVCefGhfGYQZI[]
			{
				e_,
			};
			bool? g_(Tuple_HHCMSSZgDEUSHVCefGhfGYQZI FollowUpUSSAssessment)
			{
				CqlInterval<CqlDateTime> k_ = QICoreCommon_2_0_000.prevalenceInterval(MorbidObesity);
				CqlInterval<CqlDateTime> l_ = this.Measurement_Period();
				bool? m_ = context.Operators.Overlaps(k_, l_, null);
				CqlDateTime o_ = context.Operators.Start(k_);
				bool? p_ = context.Operators.SameOrBefore(o_, FollowUpUSSAssessment?.effectiveDatetime, null);
				bool? q_ = context.Operators.And(m_, p_);
				bool? r_ = this.isConfirmedActiveDiagnosis(MorbidObesity);
				bool? s_ = context.Operators.And(q_, r_);

				return s_;
			};
			IEnumerable<Tuple_HHCMSSZgDEUSHVCefGhfGYQZI> h_ = context.Operators.Where<Tuple_HHCMSSZgDEUSHVCefGhfGYQZI>(f_, g_);
			Condition i_(Tuple_HHCMSSZgDEUSHVCefGhfGYQZI FollowUpUSSAssessment) => 
				MorbidObesity;
			IEnumerable<Condition> j_ = context.Operators.Select<Tuple_HHCMSSZgDEUSHVCefGhfGYQZI, Condition>(h_, i_);

			return j_;
		};
		IEnumerable<Condition> d_ = context.Operators.SelectMany<Condition, Condition>(b_, c_);

		return d_;
	}

    [CqlDeclaration("Morbid Obesity Diagnosis On or Before Follow Up USS Assessment")]
	public IEnumerable<Condition> Morbid_Obesity_Diagnosis_On_or_Before_Follow_Up_USS_Assessment() => 
		__Morbid_Obesity_Diagnosis_On_or_Before_Follow_Up_USS_Assessment.Value;

	private bool? Has_BMI_Exam_Result_Greater_Than_or_Equal_To_40_During_Measurement_Period_and_On_or_Before_Follow_Up_USS_Assessment_Value()
	{
		IEnumerable<Observation> a_ = context.Operators.RetrieveByValueSet<Observation>(null, null);
		IEnumerable<Observation> b_(Observation BMIExam)
		{
			Tuple_HHCMSSZgDEUSHVCefGhfGYQZI g_ = this.Urinary_Symptom_Score_6_to_12_Months_After_Initial_BPH_Diagnosis();
			Tuple_HHCMSSZgDEUSHVCefGhfGYQZI[] h_ = new Tuple_HHCMSSZgDEUSHVCefGhfGYQZI[]
			{
				g_,
			};
			bool? i_(Tuple_HHCMSSZgDEUSHVCefGhfGYQZI FollowUpUSSAssessment)
			{
				Quantity m_ = context.Operators.Convert<Quantity>(BMIExam?.Value);
				CqlQuantity n_ = FHIRHelpers_4_3_000.ToQuantity(m_);
				CqlQuantity o_ = context.Operators.Quantity(40m, "kg/m2");
				bool? p_ = context.Operators.Greater(n_, o_);
				string q_ = context.Operators.Convert<string>(BMIExam?.StatusElement?.Value);
				string[] r_ = new string[]
				{
					"final",
					"amended",
					"corrected",
				};
				bool? s_ = context.Operators.In<string>(q_, (r_ as IEnumerable<string>));
				bool? t_ = context.Operators.And(p_, s_);
				object u_ = FHIRHelpers_4_3_000.ToValue(BMIExam?.Effective);
				CqlDateTime v_ = QICoreCommon_2_0_000.earliest(u_);
				CqlInterval<CqlDateTime> w_ = this.Measurement_Period();
				bool? x_ = context.Operators.In<CqlDateTime>(v_, w_, "day");
				bool? y_ = context.Operators.And(t_, x_);
				CqlDateTime aa_ = QICoreCommon_2_0_000.earliest(u_);
				bool? ab_ = context.Operators.SameOrBefore(aa_, FollowUpUSSAssessment?.effectiveDatetime, null);
				bool? ac_ = context.Operators.And(y_, ab_);

				return ac_;
			};
			IEnumerable<Tuple_HHCMSSZgDEUSHVCefGhfGYQZI> j_ = context.Operators.Where<Tuple_HHCMSSZgDEUSHVCefGhfGYQZI>(h_, i_);
			Observation k_(Tuple_HHCMSSZgDEUSHVCefGhfGYQZI FollowUpUSSAssessment) => 
				BMIExam;
			IEnumerable<Observation> l_ = context.Operators.Select<Tuple_HHCMSSZgDEUSHVCefGhfGYQZI, Observation>(j_, k_);

			return l_;
		};
		IEnumerable<Observation> c_ = context.Operators.SelectMany<Observation, Observation>(a_, b_);
		CqlDateTime d_(Observation BMIExam)
		{
			object ad_ = FHIRHelpers_4_3_000.ToValue(BMIExam?.Effective);
			CqlDateTime ae_ = QICoreCommon_2_0_000.earliest(ad_);

			return ae_;
		};
		IEnumerable<CqlDateTime> e_ = context.Operators.Select<Observation, CqlDateTime>(c_, d_);
		bool? f_ = context.Operators.Exists<CqlDateTime>(e_);

		return f_;
	}

    [CqlDeclaration("Has BMI Exam Result Greater Than or Equal To 40 During Measurement Period and On or Before Follow Up USS Assessment")]
	public bool? Has_BMI_Exam_Result_Greater_Than_or_Equal_To_40_During_Measurement_Period_and_On_or_Before_Follow_Up_USS_Assessment() => 
		__Has_BMI_Exam_Result_Greater_Than_or_Equal_To_40_During_Measurement_Period_and_On_or_Before_Follow_Up_USS_Assessment.Value;

	private bool? Has_Morbid_Obesity_Diagnosis_or_BMI_Exam_Result__Greater_Than_or_Equal_to_40_Starts_On_or_Before_Follow_Up_USS_Assessment_Value()
	{
		IEnumerable<Condition> a_ = this.Morbid_Obesity_Diagnosis_On_or_Before_Follow_Up_USS_Assessment();
		bool? b_ = context.Operators.Exists<Condition>(a_);
		bool? c_ = this.Has_BMI_Exam_Result_Greater_Than_or_Equal_To_40_During_Measurement_Period_and_On_or_Before_Follow_Up_USS_Assessment();
		bool? d_ = context.Operators.Or(b_, c_);

		return d_;
	}

    [CqlDeclaration("Has Morbid Obesity Diagnosis or BMI Exam Result  Greater Than or Equal to 40 Starts On or Before Follow Up USS Assessment")]
	public bool? Has_Morbid_Obesity_Diagnosis_or_BMI_Exam_Result__Greater_Than_or_Equal_to_40_Starts_On_or_Before_Follow_Up_USS_Assessment() => 
		__Has_Morbid_Obesity_Diagnosis_or_BMI_Exam_Result__Greater_Than_or_Equal_to_40_Starts_On_or_Before_Follow_Up_USS_Assessment.Value;

	private bool? Denominator_Exclusions_Value()
	{
		IEnumerable<Condition> a_ = this.Urinary_Retention_Diagnosis_Starts_Within_1_Year_After_Initial_BPH_Diagnosis();
		bool? b_ = context.Operators.Exists<Condition>(a_);
		Condition c_ = this.Initial_BPH_Diagnosis_Starts_During_or_Within_30_Days_After_End_of_Hospitalization();
		bool? d_ = context.Operators.Not((bool?)(c_ is null));
		bool? e_ = context.Operators.Or(b_, d_);
		bool? f_ = this.Has_Morbid_Obesity_Diagnosis_or_BMI_Exam_Result__Greater_Than_or_Equal_to_40_Starts_On_or_Before_Follow_Up_USS_Assessment();
		bool? g_ = context.Operators.Or(e_, f_);

		return g_;
	}

    [CqlDeclaration("Denominator Exclusions")]
	public bool? Denominator_Exclusions() => 
		__Denominator_Exclusions.Value;

	private int? Urinary_Symptom_Score_Change_Value()
	{
		Tuple_HHCMSSZgDEUSHVCefGhfGYQZI a_ = this.Urinary_Symptom_Score_Within_1_Month_after_Initial_BPH_Diagnosis();
		Tuple_HHCMSSZgDEUSHVCefGhfGYQZI[] b_ = new Tuple_HHCMSSZgDEUSHVCefGhfGYQZI[]
		{
			a_,
		};
		Tuple_HHCMSSZgDEUSHVCefGhfGYQZI c_ = this.Urinary_Symptom_Score_6_to_12_Months_After_Initial_BPH_Diagnosis();
		Tuple_HHCMSSZgDEUSHVCefGhfGYQZI[] d_ = new Tuple_HHCMSSZgDEUSHVCefGhfGYQZI[]
		{
			c_,
		};
		IEnumerable<ValueTuple<Tuple_HHCMSSZgDEUSHVCefGhfGYQZI,Tuple_HHCMSSZgDEUSHVCefGhfGYQZI>> e_ = context.Operators.CrossJoin<Tuple_HHCMSSZgDEUSHVCefGhfGYQZI, Tuple_HHCMSSZgDEUSHVCefGhfGYQZI>(b_, d_);
		Tuple_FAESHVMWYGMYBALaJITZUecdI f_(ValueTuple<Tuple_HHCMSSZgDEUSHVCefGhfGYQZI,Tuple_HHCMSSZgDEUSHVCefGhfGYQZI> _valueTuple)
		{
			Tuple_FAESHVMWYGMYBALaJITZUecdI k_ = new Tuple_FAESHVMWYGMYBALaJITZUecdI
			{
				FirstUSSAssessment = _valueTuple.Item1,
				FollowUpUSSAssessment = _valueTuple.Item2,
			};

			return k_;
		};
		IEnumerable<Tuple_FAESHVMWYGMYBALaJITZUecdI> g_ = context.Operators.Select<ValueTuple<Tuple_HHCMSSZgDEUSHVCefGhfGYQZI,Tuple_HHCMSSZgDEUSHVCefGhfGYQZI>, Tuple_FAESHVMWYGMYBALaJITZUecdI>(e_, f_);
		int? h_(Tuple_FAESHVMWYGMYBALaJITZUecdI tuple_faeshvmwygmybalajitzuecdi)
		{
			int? l_ = context.Operators.Subtract(tuple_faeshvmwygmybalajitzuecdi.FirstUSSAssessment?.valueInteger, tuple_faeshvmwygmybalajitzuecdi.FollowUpUSSAssessment?.valueInteger);

			return l_;
		};
		IEnumerable<int?> i_ = context.Operators.Select<Tuple_FAESHVMWYGMYBALaJITZUecdI, int?>(g_, h_);
		int? j_ = context.Operators.SingletonFrom<int?>(i_);

		return j_;
	}

    [CqlDeclaration("Urinary Symptom Score Change")]
	public int? Urinary_Symptom_Score_Change() => 
		__Urinary_Symptom_Score_Change.Value;

	private bool? Has_Urinary_Symptom_Score_Improvement_Greater_Than_or_Equal_To_3_Value()
	{
		int? a_ = this.Urinary_Symptom_Score_Change();
		int?[] b_ = new int?[]
		{
			a_,
		};
		bool? c_(int? USSImprovement)
		{
			bool? g_ = context.Operators.GreaterOrEqual(USSImprovement, 3);

			return g_;
		};
		IEnumerable<int?> d_ = context.Operators.Where<int?>(b_, c_);
		int? e_ = context.Operators.SingletonFrom<int?>(d_);
		bool? f_ = context.Operators.Not((bool?)(e_ is null));

		return f_;
	}

    [CqlDeclaration("Has Urinary Symptom Score Improvement Greater Than or Equal To 3")]
	public bool? Has_Urinary_Symptom_Score_Improvement_Greater_Than_or_Equal_To_3() => 
		__Has_Urinary_Symptom_Score_Improvement_Greater_Than_or_Equal_To_3.Value;

	private bool? Numerator_Value()
	{
		bool? a_ = this.Has_Urinary_Symptom_Score_Improvement_Greater_Than_or_Equal_To_3();

		return a_;
	}

    [CqlDeclaration("Numerator")]
	public bool? Numerator() => 
		__Numerator.Value;

	private Tuple_DMgHTLENEHBHWJISQgKZGZVMB SDE_Ethnicity_Value()
	{
		Tuple_DMgHTLENEHBHWJISQgKZGZVMB a_ = SupplementalDataElements_3_4_000.SDE_Ethnicity();

		return a_;
	}

    [CqlDeclaration("SDE Ethnicity")]
	public Tuple_DMgHTLENEHBHWJISQgKZGZVMB SDE_Ethnicity() => 
		__SDE_Ethnicity.Value;

	private IEnumerable<Tuple_GDKRbfOIHhLGieQSVDEMIaDPX> SDE_Payer_Value()
	{
		IEnumerable<Tuple_GDKRbfOIHhLGieQSVDEMIaDPX> a_ = SupplementalDataElements_3_4_000.SDE_Payer();

		return a_;
	}

    [CqlDeclaration("SDE Payer")]
	public IEnumerable<Tuple_GDKRbfOIHhLGieQSVDEMIaDPX> SDE_Payer() => 
		__SDE_Payer.Value;

	private Tuple_DMgHTLENEHBHWJISQgKZGZVMB SDE_Race_Value()
	{
		Tuple_DMgHTLENEHBHWJISQgKZGZVMB a_ = SupplementalDataElements_3_4_000.SDE_Race();

		return a_;
	}

    [CqlDeclaration("SDE Race")]
	public Tuple_DMgHTLENEHBHWJISQgKZGZVMB SDE_Race() => 
		__SDE_Race.Value;

	private CqlCode SDE_Sex_Value()
	{
		CqlCode a_ = SupplementalDataElements_3_4_000.SDE_Sex();

		return a_;
	}

    [CqlDeclaration("SDE Sex")]
	public CqlCode SDE_Sex() => 
		__SDE_Sex.Value;

}
