using System;
using System.Linq;
using System.Collections.Generic;
using Hl7.Cql.Runtime;
using Hl7.Cql.Primitives;
using Hl7.Cql.Abstractions;
using Hl7.Cql.ValueSets;
using Hl7.Cql.Iso8601;
using System.Reflection;
using Hl7.Cql.Operators;
using Hl7.Fhir.Model;
using Range = Hl7.Fhir.Model.Range;
using Task = Hl7.Fhir.Model.Task;
[System.CodeDom.Compiler.GeneratedCode(".NET Code Generation", "2.0.4.0")]
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
    internal Lazy<IEnumerable<(CqlDateTime effectiveDatetime, int? valueInteger)?>> __Documented_IPSS_Assessment_Result;
    internal Lazy<IEnumerable<(CqlDateTime effectiveDatetime, int? valueInteger)?>> __AUA_Symptom_Index_and_Quality_of_Life_Assessment_Result;
    internal Lazy<IEnumerable<(CqlDateTime effectiveDatetime, int? valueInteger)?>> __Urinary_Symptom_Score_Assessment;
    internal Lazy<(CqlDateTime effectiveDatetime, int? valueInteger)?> __Urinary_Symptom_Score_Within_1_Month_after_Initial_BPH_Diagnosis;
    internal Lazy<(CqlDateTime effectiveDatetime, int? valueInteger)?> __Urinary_Symptom_Score_6_to_12_Months_After_Initial_BPH_Diagnosis;
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
    internal Lazy<(IEnumerable<CqlCode> codes, string display)?> __SDE_Ethnicity;
    internal Lazy<IEnumerable<(CqlConcept code, CqlInterval<CqlDateTime> period)?>> __SDE_Payer;
    internal Lazy<(IEnumerable<CqlCode> codes, string display)?> __SDE_Race;
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
        __Documented_IPSS_Assessment_Result = new Lazy<IEnumerable<(CqlDateTime effectiveDatetime, int? valueInteger)?>>(this.Documented_IPSS_Assessment_Result_Value);
        __AUA_Symptom_Index_and_Quality_of_Life_Assessment_Result = new Lazy<IEnumerable<(CqlDateTime effectiveDatetime, int? valueInteger)?>>(this.AUA_Symptom_Index_and_Quality_of_Life_Assessment_Result_Value);
        __Urinary_Symptom_Score_Assessment = new Lazy<IEnumerable<(CqlDateTime effectiveDatetime, int? valueInteger)?>>(this.Urinary_Symptom_Score_Assessment_Value);
        __Urinary_Symptom_Score_Within_1_Month_after_Initial_BPH_Diagnosis = new Lazy<(CqlDateTime effectiveDatetime, int? valueInteger)?>(this.Urinary_Symptom_Score_Within_1_Month_after_Initial_BPH_Diagnosis_Value);
        __Urinary_Symptom_Score_6_to_12_Months_After_Initial_BPH_Diagnosis = new Lazy<(CqlDateTime effectiveDatetime, int? valueInteger)?>(this.Urinary_Symptom_Score_6_to_12_Months_After_Initial_BPH_Diagnosis_Value);
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
        __SDE_Ethnicity = new Lazy<(IEnumerable<CqlCode> codes, string display)?>(this.SDE_Ethnicity_Value);
        __SDE_Payer = new Lazy<IEnumerable<(CqlConcept code, CqlInterval<CqlDateTime> period)?>>(this.SDE_Payer_Value);
        __SDE_Race = new Lazy<(IEnumerable<CqlCode> codes, string display)?>(this.SDE_Race_Value);
        __SDE_Sex = new Lazy<CqlCode>(this.SDE_Sex_Value);
    }
    #region Dependencies

    public FHIRHelpers_4_3_000 FHIRHelpers_4_3_000 { get; }
    public SupplementalDataElements_3_4_000 SupplementalDataElements_3_4_000 { get; }
    public QICoreCommon_2_0_000 QICoreCommon_2_0_000 { get; }

    #endregion

	private CqlValueSet Hospital_Services_for_urology_care_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1164.64", default);

    [CqlDeclaration("Hospital Services for urology care")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1164.64")]
	public CqlValueSet Hospital_Services_for_urology_care() => 
		__Hospital_Services_for_urology_care.Value;

	private CqlValueSet Morbid_Obesity_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1164.67", default);

    [CqlDeclaration("Morbid Obesity")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1164.67")]
	public CqlValueSet Morbid_Obesity() => 
		__Morbid_Obesity.Value;

	private CqlValueSet Office_Visit_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1001", default);

    [CqlDeclaration("Office Visit")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1001")]
	public CqlValueSet Office_Visit() => 
		__Office_Visit.Value;

	private CqlValueSet Urinary_retention_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1164.52", default);

    [CqlDeclaration("Urinary retention")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1164.52")]
	public CqlValueSet Urinary_retention() => 
		__Urinary_retention.Value;

	private CqlCode American_Urological_Association_Symptom_Index__AUASI__Value() => 
		new CqlCode("80883-2", "http://loinc.org", default, default);

    [CqlDeclaration("American Urological Association Symptom Index [AUASI]")]
	public CqlCode American_Urological_Association_Symptom_Index__AUASI_() => 
		__American_Urological_Association_Symptom_Index__AUASI_.Value;

	private CqlCode Benign_prostatic_hyperplasia_with_lower_urinary_tract_symptoms_Value() => 
		new CqlCode("N40.1", "http://hl7.org/fhir/sid/icd-10-cm", default, default);

    [CqlDeclaration("Benign prostatic hyperplasia with lower urinary tract symptoms")]
	public CqlCode Benign_prostatic_hyperplasia_with_lower_urinary_tract_symptoms() => 
		__Benign_prostatic_hyperplasia_with_lower_urinary_tract_symptoms.Value;

	private CqlCode If_you_were_to_spend_the_rest_of_your_life_with_your_urinary_condition_just_the_way_it_is_now__how_would_you_feel_about_that__IPSS__Value() => 
		new CqlCode("81090-3", "http://loinc.org", default, default);

    [CqlDeclaration("If you were to spend the rest of your life with your urinary condition just the way it is now, how would you feel about that [IPSS]")]
	public CqlCode If_you_were_to_spend_the_rest_of_your_life_with_your_urinary_condition_just_the_way_it_is_now__how_would_you_feel_about_that__IPSS_() => 
		__If_you_were_to_spend_the_rest_of_your_life_with_your_urinary_condition_just_the_way_it_is_now__how_would_you_feel_about_that__IPSS_.Value;

	private CqlCode International_Prostate_Symptom_Score__IPSS__Value() => 
		new CqlCode("80976-4", "http://loinc.org", default, default);

    [CqlDeclaration("International Prostate Symptom Score [IPSS]")]
	public CqlCode International_Prostate_Symptom_Score__IPSS_() => 
		__International_Prostate_Symptom_Score__IPSS_.Value;

	private CqlCode survey_Value() => 
		new CqlCode("survey", "http://terminology.hl7.org/CodeSystem/observation-category", default, default);

    [CqlDeclaration("survey")]
	public CqlCode survey() => 
		__survey.Value;

	private CqlCode @virtual_Value() => 
		new CqlCode("VR", "http://terminology.hl7.org/CodeSystem/v3-ActCode", default, default);

    [CqlDeclaration("virtual")]
	public CqlCode @virtual() => 
		__virtual.Value;

	private CqlCode[] LOINC_Value()
	{
		CqlCode[] a_ = [
			new CqlCode("80883-2", "http://loinc.org", default, default),
			new CqlCode("81090-3", "http://loinc.org", default, default),
			new CqlCode("80976-4", "http://loinc.org", default, default),
		];

		return a_;
	}

    [CqlDeclaration("LOINC")]
	public CqlCode[] LOINC() => 
		__LOINC.Value;

	private CqlCode[] ICD10CM_Value()
	{
		CqlCode[] a_ = [
			new CqlCode("N40.1", "http://hl7.org/fhir/sid/icd-10-cm", default, default),
		];

		return a_;
	}

    [CqlDeclaration("ICD10CM")]
	public CqlCode[] ICD10CM() => 
		__ICD10CM.Value;

	private CqlCode[] ObservationCategoryCodes_Value()
	{
		CqlCode[] a_ = [
			new CqlCode("survey", "http://terminology.hl7.org/CodeSystem/observation-category", default, default),
		];

		return a_;
	}

    [CqlDeclaration("ObservationCategoryCodes")]
	public CqlCode[] ObservationCategoryCodes() => 
		__ObservationCategoryCodes.Value;

	private CqlCode[] ActCode_Value()
	{
		CqlCode[] a_ = [
			new CqlCode("VR", "http://terminology.hl7.org/CodeSystem/v3-ActCode", default, default),
		];

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
		IEnumerable<Patient> a_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-patient"));
		Patient b_ = context.Operators.SingletonFrom<Patient>(a_);

		return b_;
	}

    [CqlDeclaration("Patient")]
	public Patient Patient() => 
		__Patient.Value;

	private bool? Patient_is_Male_Value()
	{
		Patient a_ = this.Patient();
		Code<AdministrativeGender> b_ = a_?.GenderElement;
		AdministrativeGender? c_ = b_?.Value;
		string d_ = context.Operators.Convert<string>(c_);
		bool? e_ = context.Operators.Equal(d_, "male");

		return e_;
	}

    [CqlDeclaration("Patient is Male")]
	public bool? Patient_is_Male() => 
		__Patient_is_Male.Value;

	private bool? Has_Qualifying_Encounter_Value()
	{
		CqlValueSet a_ = this.Office_Visit();
		IEnumerable<Encounter> b_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
		bool? c_(Encounter ValidEncounter)
		{
			CqlInterval<CqlDateTime> f_ = this.Measurement_Period();
			Period g_ = ValidEncounter?.Period;
			CqlInterval<CqlDateTime> h_ = FHIRHelpers_4_3_000.ToInterval(g_);
			bool? i_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(f_, h_, "day");
			Coding j_ = ValidEncounter?.Class;
			CqlCode k_ = FHIRHelpers_4_3_000.ToCode(j_);
			CqlCode l_ = this.@virtual();
			bool? m_ = context.Operators.Equivalent(k_, l_);
			bool? n_ = context.Operators.Not(m_);
			bool? o_ = context.Operators.And(i_, n_);
			Code<Encounter.EncounterStatus> p_ = ValidEncounter?.StatusElement;
			Encounter.EncounterStatus? q_ = p_?.Value;
			Code<Encounter.EncounterStatus> r_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(q_);
			bool? s_ = context.Operators.Equal(r_, "finished");
			bool? t_ = context.Operators.And(o_, s_);

			return t_;
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
		Condition[] a_ = [
			Condition,
		];
		bool? b_(Condition Diagnosis)
		{
			CodeableConcept f_ = Diagnosis?.ClinicalStatus;
			CqlConcept g_ = FHIRHelpers_4_3_000.ToConcept(f_);
			CqlCode h_ = QICoreCommon_2_0_000.active();
			CqlConcept i_ = context.Operators.ConvertCodeToConcept(h_);
			bool? j_ = context.Operators.Equivalent(g_, i_);
			CodeableConcept k_ = Diagnosis?.VerificationStatus;
			CqlConcept l_ = FHIRHelpers_4_3_000.ToConcept(k_);
			CqlCode m_ = QICoreCommon_2_0_000.unconfirmed();
			CqlConcept n_ = context.Operators.ConvertCodeToConcept(m_);
			bool? o_ = context.Operators.Equivalent(l_, n_);
			CqlConcept q_ = FHIRHelpers_4_3_000.ToConcept(k_);
			CqlCode r_ = QICoreCommon_2_0_000.refuted();
			CqlConcept s_ = context.Operators.ConvertCodeToConcept(r_);
			bool? t_ = context.Operators.Equivalent(q_, s_);
			bool? u_ = context.Operators.Or(o_, t_);
			CqlConcept w_ = FHIRHelpers_4_3_000.ToConcept(k_);
			CqlCode x_ = QICoreCommon_2_0_000.entered_in_error();
			CqlConcept y_ = context.Operators.ConvertCodeToConcept(x_);
			bool? z_ = context.Operators.Equivalent(w_, y_);
			bool? aa_ = context.Operators.Or(u_, z_);
			bool? ab_ = context.Operators.Not(aa_);
			bool? ac_ = context.Operators.And(j_, ab_);

			return ac_;
		};
		IEnumerable<Condition> c_ = context.Operators.Where<Condition>((IEnumerable<Condition>)a_, b_);
		Condition d_ = context.Operators.SingletonFrom<Condition>(c_);
		bool? e_ = context.Operators.Not((bool?)(d_ is null));

		return e_;
	}

	private Condition Initial_BPH_Diagnosis_Starts_Within_6_Months_Before_or_After_Start_of_Measurement_Period_Value()
	{
		CqlCode a_ = this.Benign_prostatic_hyperplasia_with_lower_urinary_tract_symptoms();
		IEnumerable<CqlCode> b_ = context.Operators.ToList<CqlCode>(a_);
		IEnumerable<Condition> c_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, default, b_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
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
			DataType u_ = @this?.Onset;
			object v_ = FHIRHelpers_4_3_000.ToValue(u_);
			CqlInterval<CqlDateTime> w_ = QICoreCommon_2_0_000.toInterval(v_);
			CqlDateTime x_ = context.Operators.Start(w_);

			return x_;
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

	private IEnumerable<(CqlDateTime effectiveDatetime, int? valueInteger)?> Documented_IPSS_Assessment_Result_Value()
	{
		CqlCode a_ = this.International_Prostate_Symptom_Score__IPSS_();
		IEnumerable<CqlCode> b_ = context.Operators.ToList<CqlCode>(a_);
		IEnumerable<Observation> c_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, b_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
		bool? d_(Observation IPSSAssessment)
		{
			Code<ObservationStatus> h_ = IPSSAssessment?.StatusElement;
			ObservationStatus? i_ = h_?.Value;
			Code<ObservationStatus> j_ = context.Operators.Convert<Code<ObservationStatus>>(i_);
			string k_ = context.Operators.Convert<string>(j_);
			string[] l_ = [
				"final",
				"amended",
				"corrected",
			];
			bool? m_ = context.Operators.In<string>(k_, l_ as IEnumerable<string>);
			DataType n_ = IPSSAssessment?.Value;
			object o_ = FHIRHelpers_4_3_000.ToValue(n_);
			bool? p_ = context.Operators.Not((bool?)(o_ is null));
			bool? q_ = context.Operators.And(m_, p_);

			return q_;
		};
		IEnumerable<Observation> e_ = context.Operators.Where<Observation>(c_, d_);
		(CqlDateTime effectiveDatetime, int? valueInteger)? f_(Observation IPSSAssessment)
		{
			object r_()
			{
				bool w_()
				{
					DataType z_ = IPSSAssessment?.Effective;
					object aa_ = FHIRHelpers_4_3_000.ToValue(z_);
					bool ab_ = aa_ is CqlDateTime;

					return ab_;
				};
				bool x_()
				{
					DataType ac_ = IPSSAssessment?.Effective;
					object ad_ = FHIRHelpers_4_3_000.ToValue(ac_);
					bool ae_ = ad_ is CqlInterval<CqlDateTime>;

					return ae_;
				};
				bool y_()
				{
					DataType af_ = IPSSAssessment?.Effective;
					object ag_ = FHIRHelpers_4_3_000.ToValue(af_);
					bool ah_ = ag_ is CqlDateTime;

					return ah_;
				};
				if (w_())
				{
					DataType ai_ = IPSSAssessment?.Effective;
					object aj_ = FHIRHelpers_4_3_000.ToValue(ai_);

					return (aj_ as CqlDateTime) as object;
				}
				else if (x_())
				{
					DataType ak_ = IPSSAssessment?.Effective;
					object al_ = FHIRHelpers_4_3_000.ToValue(ak_);

					return (al_ as CqlInterval<CqlDateTime>) as object;
				}
				else if (y_())
				{
					DataType am_ = IPSSAssessment?.Effective;
					object an_ = FHIRHelpers_4_3_000.ToValue(am_);

					return (an_ as CqlDateTime) as object;
				}
				else
				{
					return null;
				}
			};
			CqlDateTime s_ = QICoreCommon_2_0_000.earliest(r_());
			DataType t_ = IPSSAssessment?.Value;
			object u_ = FHIRHelpers_4_3_000.ToValue(t_);
			(CqlDateTime effectiveDatetime, int? valueInteger)? v_ = (s_, u_ as int?);

			return v_;
		};
		IEnumerable<(CqlDateTime effectiveDatetime, int? valueInteger)?> g_ = context.Operators.Select<Observation, (CqlDateTime effectiveDatetime, int? valueInteger)?>(e_, f_);

		return g_;
	}

    [CqlDeclaration("Documented IPSS Assessment Result")]
	public IEnumerable<(CqlDateTime effectiveDatetime, int? valueInteger)?> Documented_IPSS_Assessment_Result() => 
		__Documented_IPSS_Assessment_Result.Value;

	private IEnumerable<(CqlDateTime effectiveDatetime, int? valueInteger)?> AUA_Symptom_Index_and_Quality_of_Life_Assessment_Result_Value()
	{
		CqlCode a_ = this.American_Urological_Association_Symptom_Index__AUASI_();
		IEnumerable<CqlCode> b_ = context.Operators.ToList<CqlCode>(a_);
		IEnumerable<Observation> c_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, b_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
		bool? d_(Observation AUASIAssessment)
		{
			List<CodeableConcept> h_ = AUASIAssessment?.Category;
			CqlConcept i_(CodeableConcept @this)
			{
				CqlConcept y_ = FHIRHelpers_4_3_000.ToConcept(@this);

				return y_;
			};
			IEnumerable<CqlConcept> j_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)h_, i_);
			bool? k_(CqlConcept AUASIAssessmentCategory)
			{
				CqlCode z_ = this.survey();
				CqlConcept aa_ = context.Operators.ConvertCodeToConcept(z_);
				bool? ab_ = context.Operators.Equivalent(AUASIAssessmentCategory, aa_);

				return ab_;
			};
			IEnumerable<CqlConcept> l_ = context.Operators.Where<CqlConcept>(j_, k_);
			bool? m_ = context.Operators.Exists<CqlConcept>(l_);
			Code<ObservationStatus> n_ = AUASIAssessment?.StatusElement;
			ObservationStatus? o_ = n_?.Value;
			Code<ObservationStatus> p_ = context.Operators.Convert<Code<ObservationStatus>>(o_);
			string q_ = context.Operators.Convert<string>(p_);
			string[] r_ = [
				"final",
				"amended",
				"corrected",
			];
			bool? s_ = context.Operators.In<string>(q_, r_ as IEnumerable<string>);
			bool? t_ = context.Operators.And(m_, s_);
			DataType u_ = AUASIAssessment?.Value;
			object v_ = FHIRHelpers_4_3_000.ToValue(u_);
			bool? w_ = context.Operators.Not((bool?)(v_ is null));
			bool? x_ = context.Operators.And(t_, w_);

			return x_;
		};
		IEnumerable<Observation> e_ = context.Operators.Where<Observation>(c_, d_);
		(CqlDateTime effectiveDatetime, int? valueInteger)? f_(Observation AUASIAssessment)
		{
			object ac_()
			{
				bool as_()
				{
					DataType av_ = AUASIAssessment?.Effective;
					object aw_ = FHIRHelpers_4_3_000.ToValue(av_);
					bool ax_ = aw_ is CqlDateTime;

					return ax_;
				};
				bool at_()
				{
					DataType ay_ = AUASIAssessment?.Effective;
					object az_ = FHIRHelpers_4_3_000.ToValue(ay_);
					bool ba_ = az_ is CqlInterval<CqlDateTime>;

					return ba_;
				};
				bool au_()
				{
					DataType bb_ = AUASIAssessment?.Effective;
					object bc_ = FHIRHelpers_4_3_000.ToValue(bb_);
					bool bd_ = bc_ is CqlDateTime;

					return bd_;
				};
				if (as_())
				{
					DataType be_ = AUASIAssessment?.Effective;
					object bf_ = FHIRHelpers_4_3_000.ToValue(be_);

					return (bf_ as CqlDateTime) as object;
				}
				else if (at_())
				{
					DataType bg_ = AUASIAssessment?.Effective;
					object bh_ = FHIRHelpers_4_3_000.ToValue(bg_);

					return (bh_ as CqlInterval<CqlDateTime>) as object;
				}
				else if (au_())
				{
					DataType bi_ = AUASIAssessment?.Effective;
					object bj_ = FHIRHelpers_4_3_000.ToValue(bi_);

					return (bj_ as CqlDateTime) as object;
				}
				else
				{
					return null;
				}
			};
			CqlDateTime ad_ = QICoreCommon_2_0_000.earliest(ac_());
			DataType ae_ = AUASIAssessment?.Value;
			object af_ = FHIRHelpers_4_3_000.ToValue(ae_);
			CqlCode ag_ = this.If_you_were_to_spend_the_rest_of_your_life_with_your_urinary_condition_just_the_way_it_is_now__how_would_you_feel_about_that__IPSS_();
			IEnumerable<CqlCode> ah_ = context.Operators.ToList<CqlCode>(ag_);
			IEnumerable<Observation> ai_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, ah_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
			bool? aj_(Observation QOLAssessment)
			{
				object bk_()
				{
					bool ch_()
					{
						DataType ck_ = QOLAssessment?.Effective;
						object cl_ = FHIRHelpers_4_3_000.ToValue(ck_);
						bool cm_ = cl_ is CqlDateTime;

						return cm_;
					};
					bool ci_()
					{
						DataType cn_ = QOLAssessment?.Effective;
						object co_ = FHIRHelpers_4_3_000.ToValue(cn_);
						bool cp_ = co_ is CqlInterval<CqlDateTime>;

						return cp_;
					};
					bool cj_()
					{
						DataType cq_ = QOLAssessment?.Effective;
						object cr_ = FHIRHelpers_4_3_000.ToValue(cq_);
						bool cs_ = cr_ is CqlDateTime;

						return cs_;
					};
					if (ch_())
					{
						DataType ct_ = QOLAssessment?.Effective;
						object cu_ = FHIRHelpers_4_3_000.ToValue(ct_);

						return (cu_ as CqlDateTime) as object;
					}
					else if (ci_())
					{
						DataType cv_ = QOLAssessment?.Effective;
						object cw_ = FHIRHelpers_4_3_000.ToValue(cv_);

						return (cw_ as CqlInterval<CqlDateTime>) as object;
					}
					else if (cj_())
					{
						DataType cx_ = QOLAssessment?.Effective;
						object cy_ = FHIRHelpers_4_3_000.ToValue(cx_);

						return (cy_ as CqlDateTime) as object;
					}
					else
					{
						return null;
					}
				};
				CqlDateTime bl_ = QICoreCommon_2_0_000.earliest(bk_());
				object bm_()
				{
					bool cz_()
					{
						DataType dc_ = QOLAssessment?.Effective;
						object dd_ = FHIRHelpers_4_3_000.ToValue(dc_);
						bool de_ = dd_ is CqlDateTime;

						return de_;
					};
					bool da_()
					{
						DataType df_ = QOLAssessment?.Effective;
						object dg_ = FHIRHelpers_4_3_000.ToValue(df_);
						bool dh_ = dg_ is CqlInterval<CqlDateTime>;

						return dh_;
					};
					bool db_()
					{
						DataType di_ = QOLAssessment?.Effective;
						object dj_ = FHIRHelpers_4_3_000.ToValue(di_);
						bool dk_ = dj_ is CqlDateTime;

						return dk_;
					};
					if (cz_())
					{
						DataType dl_ = QOLAssessment?.Effective;
						object dm_ = FHIRHelpers_4_3_000.ToValue(dl_);

						return (dm_ as CqlDateTime) as object;
					}
					else if (da_())
					{
						DataType dn_ = QOLAssessment?.Effective;
						object do_ = FHIRHelpers_4_3_000.ToValue(dn_);

						return (do_ as CqlInterval<CqlDateTime>) as object;
					}
					else if (db_())
					{
						DataType dp_ = QOLAssessment?.Effective;
						object dq_ = FHIRHelpers_4_3_000.ToValue(dp_);

						return (dq_ as CqlDateTime) as object;
					}
					else
					{
						return null;
					}
				};
				CqlDateTime bn_ = QICoreCommon_2_0_000.earliest(bm_());
				bool? bo_ = context.Operators.SameAs(bl_, bn_, "day");
				List<CodeableConcept> bp_ = QOLAssessment?.Category;
				CqlConcept bq_(CodeableConcept @this)
				{
					CqlConcept dr_ = FHIRHelpers_4_3_000.ToConcept(@this);

					return dr_;
				};
				IEnumerable<CqlConcept> br_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)bp_, bq_);
				bool? bs_(CqlConcept QOLAssessmentCategory)
				{
					CqlCode ds_ = this.survey();
					CqlConcept dt_ = context.Operators.ConvertCodeToConcept(ds_);
					bool? du_ = context.Operators.Equivalent(QOLAssessmentCategory, dt_);

					return du_;
				};
				IEnumerable<CqlConcept> bt_ = context.Operators.Where<CqlConcept>(br_, bs_);
				bool? bu_ = context.Operators.Exists<CqlConcept>(bt_);
				bool? bv_ = context.Operators.And(bo_, bu_);
				Code<ObservationStatus> bw_ = QOLAssessment?.StatusElement;
				ObservationStatus? bx_ = bw_?.Value;
				Code<ObservationStatus> by_ = context.Operators.Convert<Code<ObservationStatus>>(bx_);
				string bz_ = context.Operators.Convert<string>(by_);
				string[] ca_ = [
					"final",
					"amended",
					"corrected",
				];
				bool? cb_ = context.Operators.In<string>(bz_, ca_ as IEnumerable<string>);
				bool? cc_ = context.Operators.And(bv_, cb_);
				DataType cd_ = QOLAssessment?.Value;
				object ce_ = FHIRHelpers_4_3_000.ToValue(cd_);
				bool? cf_ = context.Operators.Not((bool?)(ce_ is null));
				bool? cg_ = context.Operators.And(cc_, cf_);

				return cg_;
			};
			IEnumerable<Observation> ak_ = context.Operators.Where<Observation>(ai_, aj_);
			object al_(Observation @this)
			{
				object dv_()
				{
					bool dx_()
					{
						DataType ea_ = @this?.Effective;
						object eb_ = FHIRHelpers_4_3_000.ToValue(ea_);
						bool ec_ = eb_ is CqlDateTime;

						return ec_;
					};
					bool dy_()
					{
						DataType ed_ = @this?.Effective;
						object ee_ = FHIRHelpers_4_3_000.ToValue(ed_);
						bool ef_ = ee_ is CqlInterval<CqlDateTime>;

						return ef_;
					};
					bool dz_()
					{
						DataType eg_ = @this?.Effective;
						object eh_ = FHIRHelpers_4_3_000.ToValue(eg_);
						bool ei_ = eh_ is CqlDateTime;

						return ei_;
					};
					if (dx_())
					{
						DataType ej_ = @this?.Effective;
						object ek_ = FHIRHelpers_4_3_000.ToValue(ej_);

						return (ek_ as CqlDateTime) as object;
					}
					else if (dy_())
					{
						DataType el_ = @this?.Effective;
						object em_ = FHIRHelpers_4_3_000.ToValue(el_);

						return (em_ as CqlInterval<CqlDateTime>) as object;
					}
					else if (dz_())
					{
						DataType en_ = @this?.Effective;
						object eo_ = FHIRHelpers_4_3_000.ToValue(en_);

						return (eo_ as CqlDateTime) as object;
					}
					else
					{
						return null;
					}
				};
				CqlDateTime dw_ = QICoreCommon_2_0_000.earliest(dv_());

				return dw_;
			};
			IEnumerable<Observation> am_ = context.Operators.SortBy<Observation>(ak_, al_, System.ComponentModel.ListSortDirection.Ascending);
			Observation an_ = context.Operators.Last<Observation>(am_);
			DataType ao_ = an_?.Value;
			object ap_ = FHIRHelpers_4_3_000.ToValue(ao_);
			int? aq_ = context.Operators.Add(af_ as int?, ap_ as int?);
			(CqlDateTime effectiveDatetime, int? valueInteger)? ar_ = (ad_, aq_);

			return ar_;
		};
		IEnumerable<(CqlDateTime effectiveDatetime, int? valueInteger)?> g_ = context.Operators.Select<Observation, (CqlDateTime effectiveDatetime, int? valueInteger)?>(e_, f_);

		return g_;
	}

    [CqlDeclaration("AUA Symptom Index and Quality of Life Assessment Result")]
	public IEnumerable<(CqlDateTime effectiveDatetime, int? valueInteger)?> AUA_Symptom_Index_and_Quality_of_Life_Assessment_Result() => 
		__AUA_Symptom_Index_and_Quality_of_Life_Assessment_Result.Value;

	private IEnumerable<(CqlDateTime effectiveDatetime, int? valueInteger)?> Urinary_Symptom_Score_Assessment_Value()
	{
		IEnumerable<(CqlDateTime effectiveDatetime, int? valueInteger)?> a_ = this.Documented_IPSS_Assessment_Result();
		IEnumerable<(CqlDateTime effectiveDatetime, int? valueInteger)?> b_ = this.AUA_Symptom_Index_and_Quality_of_Life_Assessment_Result();
		IEnumerable<(CqlDateTime effectiveDatetime, int? valueInteger)?> c_ = context.Operators.Union<(CqlDateTime effectiveDatetime, int? valueInteger)?>(a_, b_);

		return c_;
	}

    [CqlDeclaration("Urinary Symptom Score Assessment")]
	public IEnumerable<(CqlDateTime effectiveDatetime, int? valueInteger)?> Urinary_Symptom_Score_Assessment() => 
		__Urinary_Symptom_Score_Assessment.Value;

	private (CqlDateTime effectiveDatetime, int? valueInteger)? Urinary_Symptom_Score_Within_1_Month_after_Initial_BPH_Diagnosis_Value()
	{
		IEnumerable<(CqlDateTime effectiveDatetime, int? valueInteger)?> a_ = this.Urinary_Symptom_Score_Assessment();
		IEnumerable<(CqlDateTime effectiveDatetime, int? valueInteger)?> b_((CqlDateTime effectiveDatetime, int? valueInteger)? USSAssessment)
		{
			Condition g_ = this.Initial_BPH_Diagnosis_Starts_Within_6_Months_Before_or_After_Start_of_Measurement_Period();
			Condition[] h_ = [
				g_,
			];
			bool? i_(Condition InitialBPHDiagnosis)
			{
				CqlDateTime m_ = USSAssessment?.effectiveDatetime;
				CqlInterval<CqlDateTime> n_ = QICoreCommon_2_0_000.prevalenceInterval(InitialBPHDiagnosis);
				CqlDateTime o_ = context.Operators.Start(n_);
				CqlDateTime q_ = context.Operators.Start(n_);
				CqlQuantity r_ = context.Operators.Quantity(1m, "month");
				CqlDateTime s_ = context.Operators.Add(q_, r_);
				CqlInterval<CqlDateTime> t_ = context.Operators.Interval(o_, s_, true, true);
				bool? u_ = context.Operators.In<CqlDateTime>(m_, t_, "day");
				CqlDateTime w_ = context.Operators.Start(n_);
				bool? x_ = context.Operators.Not((bool?)(w_ is null));
				bool? y_ = context.Operators.And(u_, x_);

				return y_;
			};
			IEnumerable<Condition> j_ = context.Operators.Where<Condition>((IEnumerable<Condition>)h_, i_);
			(CqlDateTime effectiveDatetime, int? valueInteger)? k_(Condition InitialBPHDiagnosis) => 
				USSAssessment;
			IEnumerable<(CqlDateTime effectiveDatetime, int? valueInteger)?> l_ = context.Operators.Select<Condition, (CqlDateTime effectiveDatetime, int? valueInteger)?>(j_, k_);

			return l_;
		};
		IEnumerable<(CqlDateTime effectiveDatetime, int? valueInteger)?> c_ = context.Operators.SelectMany<(CqlDateTime effectiveDatetime, int? valueInteger)?, (CqlDateTime effectiveDatetime, int? valueInteger)?>(a_, b_);
		object d_((CqlDateTime effectiveDatetime, int? valueInteger)? @this)
		{
			CqlDateTime z_ = @this?.effectiveDatetime;

			return z_;
		};
		IEnumerable<(CqlDateTime effectiveDatetime, int? valueInteger)?> e_ = context.Operators.SortBy<(CqlDateTime effectiveDatetime, int? valueInteger)?>(c_, d_, System.ComponentModel.ListSortDirection.Ascending);
		(CqlDateTime effectiveDatetime, int? valueInteger)? f_ = context.Operators.First<(CqlDateTime effectiveDatetime, int? valueInteger)?>(e_);

		return f_;
	}

    [CqlDeclaration("Urinary Symptom Score Within 1 Month after Initial BPH Diagnosis")]
	public (CqlDateTime effectiveDatetime, int? valueInteger)? Urinary_Symptom_Score_Within_1_Month_after_Initial_BPH_Diagnosis() => 
		__Urinary_Symptom_Score_Within_1_Month_after_Initial_BPH_Diagnosis.Value;

	private (CqlDateTime effectiveDatetime, int? valueInteger)? Urinary_Symptom_Score_6_to_12_Months_After_Initial_BPH_Diagnosis_Value()
	{
		IEnumerable<(CqlDateTime effectiveDatetime, int? valueInteger)?> a_ = this.Urinary_Symptom_Score_Assessment();
		IEnumerable<(CqlDateTime effectiveDatetime, int? valueInteger)?> b_((CqlDateTime effectiveDatetime, int? valueInteger)? USSAssessment)
		{
			Condition g_ = this.Initial_BPH_Diagnosis_Starts_Within_6_Months_Before_or_After_Start_of_Measurement_Period();
			Condition[] h_ = [
				g_,
			];
			bool? i_(Condition InitialBPHDiagnosis)
			{
				CqlInterval<CqlDateTime> m_ = QICoreCommon_2_0_000.prevalenceInterval(InitialBPHDiagnosis);
				CqlDateTime n_ = context.Operators.Start(m_);
				CqlDateTime o_ = USSAssessment?.effectiveDatetime;
				int? p_ = context.Operators.DurationBetween(n_, o_, "month");
				CqlInterval<int?> q_ = context.Operators.Interval(6, 12, true, true);
				bool? r_ = context.Operators.In<int?>(p_, q_, default);

				return r_;
			};
			IEnumerable<Condition> j_ = context.Operators.Where<Condition>((IEnumerable<Condition>)h_, i_);
			(CqlDateTime effectiveDatetime, int? valueInteger)? k_(Condition InitialBPHDiagnosis) => 
				USSAssessment;
			IEnumerable<(CqlDateTime effectiveDatetime, int? valueInteger)?> l_ = context.Operators.Select<Condition, (CqlDateTime effectiveDatetime, int? valueInteger)?>(j_, k_);

			return l_;
		};
		IEnumerable<(CqlDateTime effectiveDatetime, int? valueInteger)?> c_ = context.Operators.SelectMany<(CqlDateTime effectiveDatetime, int? valueInteger)?, (CqlDateTime effectiveDatetime, int? valueInteger)?>(a_, b_);
		object d_((CqlDateTime effectiveDatetime, int? valueInteger)? @this)
		{
			CqlDateTime s_ = @this?.effectiveDatetime;

			return s_;
		};
		IEnumerable<(CqlDateTime effectiveDatetime, int? valueInteger)?> e_ = context.Operators.SortBy<(CqlDateTime effectiveDatetime, int? valueInteger)?>(c_, d_, System.ComponentModel.ListSortDirection.Ascending);
		(CqlDateTime effectiveDatetime, int? valueInteger)? f_ = context.Operators.Last<(CqlDateTime effectiveDatetime, int? valueInteger)?>(e_);

		return f_;
	}

    [CqlDeclaration("Urinary Symptom Score 6 to 12 Months After Initial BPH Diagnosis")]
	public (CqlDateTime effectiveDatetime, int? valueInteger)? Urinary_Symptom_Score_6_to_12_Months_After_Initial_BPH_Diagnosis() => 
		__Urinary_Symptom_Score_6_to_12_Months_After_Initial_BPH_Diagnosis.Value;

	private bool? Initial_Population_Value()
	{
		bool? a_ = this.Patient_is_Male();
		bool? b_ = this.Has_Qualifying_Encounter();
		bool? c_ = context.Operators.And(a_, b_);
		bool? d_ = this.Has_Qualifying_BPH_Diagnosis();
		bool? e_ = context.Operators.And(c_, d_);
		(CqlDateTime effectiveDatetime, int? valueInteger)? f_ = this.Urinary_Symptom_Score_Within_1_Month_after_Initial_BPH_Diagnosis();
		bool? g_ = context.Operators.Not((bool?)(f_ is null));
		bool? h_ = context.Operators.And(e_, g_);
		(CqlDateTime effectiveDatetime, int? valueInteger)? i_ = this.Urinary_Symptom_Score_6_to_12_Months_After_Initial_BPH_Diagnosis();
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
		IEnumerable<Condition> b_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
		IEnumerable<Condition> c_(Condition UrinaryRetention)
		{
			Condition g_ = this.Initial_BPH_Diagnosis_Starts_Within_6_Months_Before_or_After_Start_of_Measurement_Period();
			Condition[] h_ = [
				g_,
			];
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
			IEnumerable<Condition> j_ = context.Operators.Where<Condition>((IEnumerable<Condition>)h_, i_);
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
		Condition[] b_ = [
			a_,
		];
		IEnumerable<Condition> c_(Condition InitialBPHDiagnosis)
		{
			CqlValueSet f_ = this.Hospital_Services_for_urology_care();
			IEnumerable<Encounter> g_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, f_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
			bool? h_(Encounter InHospitalServices)
			{
				CqlInterval<CqlDateTime> l_ = QICoreCommon_2_0_000.prevalenceInterval(InitialBPHDiagnosis);
				CqlDateTime m_ = context.Operators.Start(l_);
				Period n_ = InHospitalServices?.Period;
				CqlInterval<CqlDateTime> o_ = FHIRHelpers_4_3_000.ToInterval(n_);
				CqlDateTime p_ = context.Operators.Start(o_);
				CqlInterval<CqlDateTime> r_ = FHIRHelpers_4_3_000.ToInterval(n_);
				CqlDateTime s_ = context.Operators.End(r_);
				CqlQuantity t_ = context.Operators.Quantity(31m, "days");
				CqlDateTime u_ = context.Operators.Add(s_, t_);
				CqlInterval<CqlDateTime> v_ = context.Operators.Interval(p_, u_, true, true);
				bool? w_ = context.Operators.In<CqlDateTime>(m_, v_, default);
				Code<Encounter.EncounterStatus> x_ = InHospitalServices?.StatusElement;
				Encounter.EncounterStatus? y_ = x_?.Value;
				Code<Encounter.EncounterStatus> z_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(y_);
				bool? aa_ = context.Operators.Equal(z_, "finished");
				bool? ab_ = context.Operators.And(w_, aa_);

				return ab_;
			};
			IEnumerable<Encounter> i_ = context.Operators.Where<Encounter>(g_, h_);
			Condition j_(Encounter InHospitalServices) => 
				InitialBPHDiagnosis;
			IEnumerable<Condition> k_ = context.Operators.Select<Encounter, Condition>(i_, j_);

			return k_;
		};
		IEnumerable<Condition> d_ = context.Operators.SelectMany<Condition, Condition>((IEnumerable<Condition>)b_, c_);
		Condition e_ = context.Operators.SingletonFrom<Condition>(d_);

		return e_;
	}

    [CqlDeclaration("Initial BPH Diagnosis Starts During or Within 30 Days After End of Hospitalization")]
	public Condition Initial_BPH_Diagnosis_Starts_During_or_Within_30_Days_After_End_of_Hospitalization() => 
		__Initial_BPH_Diagnosis_Starts_During_or_Within_30_Days_After_End_of_Hospitalization.Value;

	private IEnumerable<Condition> Morbid_Obesity_Diagnosis_On_or_Before_Follow_Up_USS_Assessment_Value()
	{
		CqlValueSet a_ = this.Morbid_Obesity();
		IEnumerable<Condition> b_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
		IEnumerable<Condition> c_(Condition MorbidObesity)
		{
			(CqlDateTime effectiveDatetime, int? valueInteger)? e_ = this.Urinary_Symptom_Score_6_to_12_Months_After_Initial_BPH_Diagnosis();
			(CqlDateTime effectiveDatetime, int? valueInteger)?[] f_ = [
				e_,
			];
			bool? g_((CqlDateTime effectiveDatetime, int? valueInteger)? FollowUpUSSAssessment)
			{
				CqlInterval<CqlDateTime> k_ = QICoreCommon_2_0_000.prevalenceInterval(MorbidObesity);
				CqlInterval<CqlDateTime> l_ = this.Measurement_Period();
				bool? m_ = context.Operators.Overlaps(k_, l_, default);
				CqlDateTime o_ = context.Operators.Start(k_);
				CqlDateTime p_ = FollowUpUSSAssessment?.effectiveDatetime;
				bool? q_ = context.Operators.SameOrBefore(o_, p_, default);
				bool? r_ = context.Operators.And(m_, q_);
				bool? s_ = this.isConfirmedActiveDiagnosis(MorbidObesity);
				bool? t_ = context.Operators.And(r_, s_);

				return t_;
			};
			IEnumerable<(CqlDateTime effectiveDatetime, int? valueInteger)?> h_ = context.Operators.Where<(CqlDateTime effectiveDatetime, int? valueInteger)?>((IEnumerable<(CqlDateTime effectiveDatetime, int? valueInteger)?>)f_, g_);
			Condition i_((CqlDateTime effectiveDatetime, int? valueInteger)? FollowUpUSSAssessment) => 
				MorbidObesity;
			IEnumerable<Condition> j_ = context.Operators.Select<(CqlDateTime effectiveDatetime, int? valueInteger)?, Condition>(h_, i_);

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
		IEnumerable<Observation> a_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/StructureDefinition/bmi"));
		IEnumerable<Observation> b_(Observation BMIExam)
		{
			(CqlDateTime effectiveDatetime, int? valueInteger)? g_ = this.Urinary_Symptom_Score_6_to_12_Months_After_Initial_BPH_Diagnosis();
			(CqlDateTime effectiveDatetime, int? valueInteger)?[] h_ = [
				g_,
			];
			bool? i_((CqlDateTime effectiveDatetime, int? valueInteger)? FollowUpUSSAssessment)
			{
				DataType m_ = BMIExam?.Value;
				CqlQuantity n_ = FHIRHelpers_4_3_000.ToQuantity(m_ as Quantity);
				CqlQuantity o_ = context.Operators.Quantity(40m, "kg/m2");
				bool? p_ = context.Operators.Greater(n_, o_);
				Code<ObservationStatus> q_ = BMIExam?.StatusElement;
				ObservationStatus? r_ = q_?.Value;
				string s_ = context.Operators.Convert<string>(r_);
				string[] t_ = [
					"final",
					"amended",
					"corrected",
				];
				bool? u_ = context.Operators.In<string>(s_, t_ as IEnumerable<string>);
				bool? v_ = context.Operators.And(p_, u_);
				DataType w_ = BMIExam?.Effective;
				object x_ = FHIRHelpers_4_3_000.ToValue(w_);
				CqlDateTime y_ = QICoreCommon_2_0_000.earliest(x_);
				CqlInterval<CqlDateTime> z_ = this.Measurement_Period();
				bool? aa_ = context.Operators.In<CqlDateTime>(y_, z_, "day");
				bool? ab_ = context.Operators.And(v_, aa_);
				object ad_ = FHIRHelpers_4_3_000.ToValue(w_);
				CqlDateTime ae_ = QICoreCommon_2_0_000.earliest(ad_);
				CqlDateTime af_ = FollowUpUSSAssessment?.effectiveDatetime;
				bool? ag_ = context.Operators.SameOrBefore(ae_, af_, default);
				bool? ah_ = context.Operators.And(ab_, ag_);

				return ah_;
			};
			IEnumerable<(CqlDateTime effectiveDatetime, int? valueInteger)?> j_ = context.Operators.Where<(CqlDateTime effectiveDatetime, int? valueInteger)?>((IEnumerable<(CqlDateTime effectiveDatetime, int? valueInteger)?>)h_, i_);
			Observation k_((CqlDateTime effectiveDatetime, int? valueInteger)? FollowUpUSSAssessment) => 
				BMIExam;
			IEnumerable<Observation> l_ = context.Operators.Select<(CqlDateTime effectiveDatetime, int? valueInteger)?, Observation>(j_, k_);

			return l_;
		};
		IEnumerable<Observation> c_ = context.Operators.SelectMany<Observation, Observation>(a_, b_);
		CqlDateTime d_(Observation BMIExam)
		{
			DataType ai_ = BMIExam?.Effective;
			object aj_ = FHIRHelpers_4_3_000.ToValue(ai_);
			CqlDateTime ak_ = QICoreCommon_2_0_000.earliest(aj_);

			return ak_;
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
		(CqlDateTime effectiveDatetime, int? valueInteger)? a_ = this.Urinary_Symptom_Score_Within_1_Month_after_Initial_BPH_Diagnosis();
		(CqlDateTime effectiveDatetime, int? valueInteger)?[] b_ = [
			a_,
		];
		(CqlDateTime effectiveDatetime, int? valueInteger)? c_ = this.Urinary_Symptom_Score_6_to_12_Months_After_Initial_BPH_Diagnosis();
		(CqlDateTime effectiveDatetime, int? valueInteger)?[] d_ = [
			c_,
		];
		IEnumerable<ValueTuple<(CqlDateTime effectiveDatetime, int? valueInteger)?, (CqlDateTime effectiveDatetime, int? valueInteger)?>> e_ = context.Operators.CrossJoin<(CqlDateTime effectiveDatetime, int? valueInteger)?, (CqlDateTime effectiveDatetime, int? valueInteger)?>((IEnumerable<(CqlDateTime effectiveDatetime, int? valueInteger)?>)b_, (IEnumerable<(CqlDateTime effectiveDatetime, int? valueInteger)?>)d_);
		((CqlDateTime effectiveDatetime, int? valueInteger)? FirstUSSAssessment, (CqlDateTime effectiveDatetime, int? valueInteger)? FollowUpUSSAssessment)? f_(ValueTuple<(CqlDateTime effectiveDatetime, int? valueInteger)?, (CqlDateTime effectiveDatetime, int? valueInteger)?> _valueTuple)
		{
			((CqlDateTime effectiveDatetime, int? valueInteger)? FirstUSSAssessment, (CqlDateTime effectiveDatetime, int? valueInteger)? FollowUpUSSAssessment)? k_ = (_valueTuple.Item1, _valueTuple.Item2);

			return k_;
		};
		IEnumerable<((CqlDateTime effectiveDatetime, int? valueInteger)? FirstUSSAssessment, (CqlDateTime effectiveDatetime, int? valueInteger)? FollowUpUSSAssessment)?> g_ = context.Operators.Select<ValueTuple<(CqlDateTime effectiveDatetime, int? valueInteger)?, (CqlDateTime effectiveDatetime, int? valueInteger)?>, ((CqlDateTime effectiveDatetime, int? valueInteger)? FirstUSSAssessment, (CqlDateTime effectiveDatetime, int? valueInteger)? FollowUpUSSAssessment)?>(e_, f_);
		int? h_(((CqlDateTime effectiveDatetime, int? valueInteger)? FirstUSSAssessment, (CqlDateTime effectiveDatetime, int? valueInteger)? FollowUpUSSAssessment)? tuple_fbhnjywjgmkheadezugcdqgxn)
		{
			int? l_ = tuple_fbhnjywjgmkheadezugcdqgxn?.FirstUSSAssessment?.valueInteger;
			int? m_ = tuple_fbhnjywjgmkheadezugcdqgxn?.FollowUpUSSAssessment?.valueInteger;
			int? n_ = context.Operators.Subtract(l_, m_);

			return n_;
		};
		IEnumerable<int?> i_ = context.Operators.Select<((CqlDateTime effectiveDatetime, int? valueInteger)? FirstUSSAssessment, (CqlDateTime effectiveDatetime, int? valueInteger)? FollowUpUSSAssessment)?, int?>(g_, h_);
		int? j_ = context.Operators.SingletonFrom<int?>(i_);

		return j_;
	}

    [CqlDeclaration("Urinary Symptom Score Change")]
	public int? Urinary_Symptom_Score_Change() => 
		__Urinary_Symptom_Score_Change.Value;

	private bool? Has_Urinary_Symptom_Score_Improvement_Greater_Than_or_Equal_To_3_Value()
	{
		int? a_ = this.Urinary_Symptom_Score_Change();
		int?[] b_ = [
			a_,
		];
		bool? c_(int? USSImprovement)
		{
			bool? g_ = context.Operators.GreaterOrEqual(USSImprovement, 3);

			return g_;
		};
		IEnumerable<int?> d_ = context.Operators.Where<int?>((IEnumerable<int?>)b_, c_);
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

	private (IEnumerable<CqlCode> codes, string display)? SDE_Ethnicity_Value()
	{
		(IEnumerable<CqlCode> codes, string display)? a_ = SupplementalDataElements_3_4_000.SDE_Ethnicity();

		return a_;
	}

    [CqlDeclaration("SDE Ethnicity")]
	public (IEnumerable<CqlCode> codes, string display)? SDE_Ethnicity() => 
		__SDE_Ethnicity.Value;

	private IEnumerable<(CqlConcept code, CqlInterval<CqlDateTime> period)?> SDE_Payer_Value()
	{
		IEnumerable<(CqlConcept code, CqlInterval<CqlDateTime> period)?> a_ = SupplementalDataElements_3_4_000.SDE_Payer();

		return a_;
	}

    [CqlDeclaration("SDE Payer")]
	public IEnumerable<(CqlConcept code, CqlInterval<CqlDateTime> period)?> SDE_Payer() => 
		__SDE_Payer.Value;

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

}
