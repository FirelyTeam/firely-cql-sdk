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
[CqlLibrary("FunctionalStatusAssessmentsforHeartFailureFHIR", "0.1.000")]
public class FunctionalStatusAssessmentsforHeartFailureFHIR_0_1_000
{


    internal CqlContext context;

    #region Cached values

    internal Lazy<CqlValueSet> __Heart_Failure;
    internal Lazy<CqlValueSet> __Office_Visit;
    internal Lazy<CqlValueSet> __Online_Assessments;
    internal Lazy<CqlValueSet> __Telephone_Visits;
    internal Lazy<CqlCode> __Emotional_score__MLHFQ_;
    internal Lazy<CqlCode> __Kansas_City_Cardiomyopathy_Questionnaire___12_item__KCCQ_12_;
    internal Lazy<CqlCode> __Overall_summary_score__KCCQ_12_;
    internal Lazy<CqlCode> __Overall_summary_score__KCCQ_;
    internal Lazy<CqlCode> __Physical_limitation_score__KCCQ_;
    internal Lazy<CqlCode> __Physical_score__MLHFQ_;
    internal Lazy<CqlCode> __PROMIS_10_Global_Mental_Health__GMH__score_T_score;
    internal Lazy<CqlCode> __PROMIS_10_Global_Physical_Health__GPH__score_T_score;
    internal Lazy<CqlCode> __PROMIS_29_Anxiety_score_T_score;
    internal Lazy<CqlCode> __PROMIS_29_Depression_score_T_score;
    internal Lazy<CqlCode> __PROMIS_29_Fatigue_score_T_score;
    internal Lazy<CqlCode> __PROMIS_29_Pain_interference_score_T_score;
    internal Lazy<CqlCode> __PROMIS_29_Physical_function_score_T_score;
    internal Lazy<CqlCode> __PROMIS_29_Satisfaction_with_participation_in_social_roles_score_T_score;
    internal Lazy<CqlCode> __PROMIS_29_Sleep_disturbance_score_T_score;
    internal Lazy<CqlCode> __Quality_of_life_score__KCCQ_;
    internal Lazy<CqlCode> __Self_efficacy_score__KCCQ_;
    internal Lazy<CqlCode> __Severe_cognitive_impairment__finding_;
    internal Lazy<CqlCode> __Social_limitation_score__KCCQ_;
    internal Lazy<CqlCode> __Symptom_stability_score__KCCQ_;
    internal Lazy<CqlCode> __Total_score__MLHFQ_;
    internal Lazy<CqlCode> __Total_symptom_score__KCCQ_;
    internal Lazy<CqlCode> __VR_12_Mental_component_summary__MCS__score___oblique_method_T_score;
    internal Lazy<CqlCode> __VR_12_Mental_component_summary__MCS__score___orthogonal_method_T_score;
    internal Lazy<CqlCode> __VR_12_Physical_component_summary__PCS__score___oblique_method_T_score;
    internal Lazy<CqlCode> __VR_12_Physical_component_summary__PCS__score___orthogonal_method_T_score;
    internal Lazy<CqlCode> __VR_36_Mental_component_summary__MCS__score___oblique_method_T_score;
    internal Lazy<CqlCode> __VR_36_Mental_component_summary__MCS__score___orthogonal_method_T_score;
    internal Lazy<CqlCode> __VR_36_Physical_component_summary__PCS__score___oblique_method_T_score;
    internal Lazy<CqlCode> __VR_36_Physical_component_summary__PCS__score___orthogonal_method_T_score;
    internal Lazy<CqlCode[]> __LOINC;
    internal Lazy<CqlCode[]> __SNOMEDCT;
    internal Lazy<CqlInterval<CqlDateTime>> __Measurement_Period;
    internal Lazy<Patient> __Patient;
    internal Lazy<Tuple_DMgHTLENEHBHWJISQgKZGZVMB> __SDE_Ethnicity;
    internal Lazy<IEnumerable<Tuple_GDKRbfOIHhLGieQSVDEMIaDPX>> __SDE_Payer;
    internal Lazy<Tuple_DMgHTLENEHBHWJISQgKZGZVMB> __SDE_Race;
    internal Lazy<CqlCode> __SDE_Sex;
    internal Lazy<IEnumerable<Encounter>> __Qualifying_Encounters;
    internal Lazy<IEnumerable<Encounter>> __Two_Outpatient_Encounters_during_Measurement_Period;
    internal Lazy<bool?> __Initial_Population;
    internal Lazy<bool?> __Denominator;
    internal Lazy<bool?> __Denominator_Exclusions;
    internal Lazy<IEnumerable<CqlDate>> __Date_PROMIS10_Total_Assessment_Completed;
    internal Lazy<bool?> __Has_Encounter_with_Initial_and_Follow_Up_PROMIS10_Assessments;
    internal Lazy<IEnumerable<CqlDate>> __Date_PROMIS29_Total_Assessment_Completed;
    internal Lazy<bool?> __Has_Encounter_with_Initial_and_Follow_Up_PROMIS29_Assessments;
    internal Lazy<IEnumerable<CqlDate>> __Date_VR12_Oblique_Total_Assessment_Completed;
    internal Lazy<bool?> __Has_Encounter_with_Initial_and_Follow_Up_VR12_Oblique_Assessments;
    internal Lazy<IEnumerable<CqlDate>> __Date_VR12_Orthogonal_Total_Assessment_Completed;
    internal Lazy<bool?> __Has_Encounter_with_Initial_and_Follow_Up_VR12_Orthogonal_Assessments;
    internal Lazy<IEnumerable<CqlDate>> __Date_VR36_Oblique_Total_Assessment_Completed;
    internal Lazy<bool?> __Has_Encounter_with_Initial_and_Follow_Up_VR36_Oblique_Assessments;
    internal Lazy<IEnumerable<CqlDate>> __Date_VR36_Orthogonal_Total_Assessment_Completed;
    internal Lazy<bool?> __Has_Encounter_with_Initial_and_Follow_Up_VR36_Orthogonal_Assessments;
    internal Lazy<IEnumerable<CqlDate>> __Date_MLHFQ_Total_Assessment_Completed;
    internal Lazy<bool?> __Has_Encounter_with_Initial_and_Follow_Up_MLHFQ_Assessments;
    internal Lazy<IEnumerable<CqlDate>> __Date_KCCQ12_Total_Assessment_Completed;
    internal Lazy<bool?> __Has_Encounter_with_Initial_and_Follow_Up_KCCQ12_Assessments;
    internal Lazy<IEnumerable<CqlDate>> __Date_KCCQ_Domain_Assessment_Completed;
    internal Lazy<bool?> __Has_Encounter_with_Initial_and_Follow_Up_KCCQ_Domain_Score_Assessments;
    internal Lazy<IEnumerable<CqlDate>> __Date_KCCQ_Total_Assessment_Completed;
    internal Lazy<bool?> __Has_Encounter_with_Initial_and_Follow_Up_KCCQ_Total_Score_Assessments;
    internal Lazy<bool?> __Numerator;

    #endregion
    public FunctionalStatusAssessmentsforHeartFailureFHIR_0_1_000(CqlContext context)
    {
        this.context = context ?? throw new ArgumentNullException("context");

        FHIRHelpers_4_3_000 = new FHIRHelpers_4_3_000(context);
        SupplementalDataElements_3_4_000 = new SupplementalDataElements_3_4_000(context);
        CQMCommon_2_0_000 = new CQMCommon_2_0_000(context);
        Hospice_6_9_000 = new Hospice_6_9_000(context);
        Status_1_6_000 = new Status_1_6_000(context);
        QICoreCommon_2_0_000 = new QICoreCommon_2_0_000(context);

        __Heart_Failure = new Lazy<CqlValueSet>(this.Heart_Failure_Value);
        __Office_Visit = new Lazy<CqlValueSet>(this.Office_Visit_Value);
        __Online_Assessments = new Lazy<CqlValueSet>(this.Online_Assessments_Value);
        __Telephone_Visits = new Lazy<CqlValueSet>(this.Telephone_Visits_Value);
        __Emotional_score__MLHFQ_ = new Lazy<CqlCode>(this.Emotional_score__MLHFQ__Value);
        __Kansas_City_Cardiomyopathy_Questionnaire___12_item__KCCQ_12_ = new Lazy<CqlCode>(this.Kansas_City_Cardiomyopathy_Questionnaire___12_item__KCCQ_12__Value);
        __Overall_summary_score__KCCQ_12_ = new Lazy<CqlCode>(this.Overall_summary_score__KCCQ_12__Value);
        __Overall_summary_score__KCCQ_ = new Lazy<CqlCode>(this.Overall_summary_score__KCCQ__Value);
        __Physical_limitation_score__KCCQ_ = new Lazy<CqlCode>(this.Physical_limitation_score__KCCQ__Value);
        __Physical_score__MLHFQ_ = new Lazy<CqlCode>(this.Physical_score__MLHFQ__Value);
        __PROMIS_10_Global_Mental_Health__GMH__score_T_score = new Lazy<CqlCode>(this.PROMIS_10_Global_Mental_Health__GMH__score_T_score_Value);
        __PROMIS_10_Global_Physical_Health__GPH__score_T_score = new Lazy<CqlCode>(this.PROMIS_10_Global_Physical_Health__GPH__score_T_score_Value);
        __PROMIS_29_Anxiety_score_T_score = new Lazy<CqlCode>(this.PROMIS_29_Anxiety_score_T_score_Value);
        __PROMIS_29_Depression_score_T_score = new Lazy<CqlCode>(this.PROMIS_29_Depression_score_T_score_Value);
        __PROMIS_29_Fatigue_score_T_score = new Lazy<CqlCode>(this.PROMIS_29_Fatigue_score_T_score_Value);
        __PROMIS_29_Pain_interference_score_T_score = new Lazy<CqlCode>(this.PROMIS_29_Pain_interference_score_T_score_Value);
        __PROMIS_29_Physical_function_score_T_score = new Lazy<CqlCode>(this.PROMIS_29_Physical_function_score_T_score_Value);
        __PROMIS_29_Satisfaction_with_participation_in_social_roles_score_T_score = new Lazy<CqlCode>(this.PROMIS_29_Satisfaction_with_participation_in_social_roles_score_T_score_Value);
        __PROMIS_29_Sleep_disturbance_score_T_score = new Lazy<CqlCode>(this.PROMIS_29_Sleep_disturbance_score_T_score_Value);
        __Quality_of_life_score__KCCQ_ = new Lazy<CqlCode>(this.Quality_of_life_score__KCCQ__Value);
        __Self_efficacy_score__KCCQ_ = new Lazy<CqlCode>(this.Self_efficacy_score__KCCQ__Value);
        __Severe_cognitive_impairment__finding_ = new Lazy<CqlCode>(this.Severe_cognitive_impairment__finding__Value);
        __Social_limitation_score__KCCQ_ = new Lazy<CqlCode>(this.Social_limitation_score__KCCQ__Value);
        __Symptom_stability_score__KCCQ_ = new Lazy<CqlCode>(this.Symptom_stability_score__KCCQ__Value);
        __Total_score__MLHFQ_ = new Lazy<CqlCode>(this.Total_score__MLHFQ__Value);
        __Total_symptom_score__KCCQ_ = new Lazy<CqlCode>(this.Total_symptom_score__KCCQ__Value);
        __VR_12_Mental_component_summary__MCS__score___oblique_method_T_score = new Lazy<CqlCode>(this.VR_12_Mental_component_summary__MCS__score___oblique_method_T_score_Value);
        __VR_12_Mental_component_summary__MCS__score___orthogonal_method_T_score = new Lazy<CqlCode>(this.VR_12_Mental_component_summary__MCS__score___orthogonal_method_T_score_Value);
        __VR_12_Physical_component_summary__PCS__score___oblique_method_T_score = new Lazy<CqlCode>(this.VR_12_Physical_component_summary__PCS__score___oblique_method_T_score_Value);
        __VR_12_Physical_component_summary__PCS__score___orthogonal_method_T_score = new Lazy<CqlCode>(this.VR_12_Physical_component_summary__PCS__score___orthogonal_method_T_score_Value);
        __VR_36_Mental_component_summary__MCS__score___oblique_method_T_score = new Lazy<CqlCode>(this.VR_36_Mental_component_summary__MCS__score___oblique_method_T_score_Value);
        __VR_36_Mental_component_summary__MCS__score___orthogonal_method_T_score = new Lazy<CqlCode>(this.VR_36_Mental_component_summary__MCS__score___orthogonal_method_T_score_Value);
        __VR_36_Physical_component_summary__PCS__score___oblique_method_T_score = new Lazy<CqlCode>(this.VR_36_Physical_component_summary__PCS__score___oblique_method_T_score_Value);
        __VR_36_Physical_component_summary__PCS__score___orthogonal_method_T_score = new Lazy<CqlCode>(this.VR_36_Physical_component_summary__PCS__score___orthogonal_method_T_score_Value);
        __LOINC = new Lazy<CqlCode[]>(this.LOINC_Value);
        __SNOMEDCT = new Lazy<CqlCode[]>(this.SNOMEDCT_Value);
        __Measurement_Period = new Lazy<CqlInterval<CqlDateTime>>(this.Measurement_Period_Value);
        __Patient = new Lazy<Patient>(this.Patient_Value);
        __SDE_Ethnicity = new Lazy<Tuple_DMgHTLENEHBHWJISQgKZGZVMB>(this.SDE_Ethnicity_Value);
        __SDE_Payer = new Lazy<IEnumerable<Tuple_GDKRbfOIHhLGieQSVDEMIaDPX>>(this.SDE_Payer_Value);
        __SDE_Race = new Lazy<Tuple_DMgHTLENEHBHWJISQgKZGZVMB>(this.SDE_Race_Value);
        __SDE_Sex = new Lazy<CqlCode>(this.SDE_Sex_Value);
        __Qualifying_Encounters = new Lazy<IEnumerable<Encounter>>(this.Qualifying_Encounters_Value);
        __Two_Outpatient_Encounters_during_Measurement_Period = new Lazy<IEnumerable<Encounter>>(this.Two_Outpatient_Encounters_during_Measurement_Period_Value);
        __Initial_Population = new Lazy<bool?>(this.Initial_Population_Value);
        __Denominator = new Lazy<bool?>(this.Denominator_Value);
        __Denominator_Exclusions = new Lazy<bool?>(this.Denominator_Exclusions_Value);
        __Date_PROMIS10_Total_Assessment_Completed = new Lazy<IEnumerable<CqlDate>>(this.Date_PROMIS10_Total_Assessment_Completed_Value);
        __Has_Encounter_with_Initial_and_Follow_Up_PROMIS10_Assessments = new Lazy<bool?>(this.Has_Encounter_with_Initial_and_Follow_Up_PROMIS10_Assessments_Value);
        __Date_PROMIS29_Total_Assessment_Completed = new Lazy<IEnumerable<CqlDate>>(this.Date_PROMIS29_Total_Assessment_Completed_Value);
        __Has_Encounter_with_Initial_and_Follow_Up_PROMIS29_Assessments = new Lazy<bool?>(this.Has_Encounter_with_Initial_and_Follow_Up_PROMIS29_Assessments_Value);
        __Date_VR12_Oblique_Total_Assessment_Completed = new Lazy<IEnumerable<CqlDate>>(this.Date_VR12_Oblique_Total_Assessment_Completed_Value);
        __Has_Encounter_with_Initial_and_Follow_Up_VR12_Oblique_Assessments = new Lazy<bool?>(this.Has_Encounter_with_Initial_and_Follow_Up_VR12_Oblique_Assessments_Value);
        __Date_VR12_Orthogonal_Total_Assessment_Completed = new Lazy<IEnumerable<CqlDate>>(this.Date_VR12_Orthogonal_Total_Assessment_Completed_Value);
        __Has_Encounter_with_Initial_and_Follow_Up_VR12_Orthogonal_Assessments = new Lazy<bool?>(this.Has_Encounter_with_Initial_and_Follow_Up_VR12_Orthogonal_Assessments_Value);
        __Date_VR36_Oblique_Total_Assessment_Completed = new Lazy<IEnumerable<CqlDate>>(this.Date_VR36_Oblique_Total_Assessment_Completed_Value);
        __Has_Encounter_with_Initial_and_Follow_Up_VR36_Oblique_Assessments = new Lazy<bool?>(this.Has_Encounter_with_Initial_and_Follow_Up_VR36_Oblique_Assessments_Value);
        __Date_VR36_Orthogonal_Total_Assessment_Completed = new Lazy<IEnumerable<CqlDate>>(this.Date_VR36_Orthogonal_Total_Assessment_Completed_Value);
        __Has_Encounter_with_Initial_and_Follow_Up_VR36_Orthogonal_Assessments = new Lazy<bool?>(this.Has_Encounter_with_Initial_and_Follow_Up_VR36_Orthogonal_Assessments_Value);
        __Date_MLHFQ_Total_Assessment_Completed = new Lazy<IEnumerable<CqlDate>>(this.Date_MLHFQ_Total_Assessment_Completed_Value);
        __Has_Encounter_with_Initial_and_Follow_Up_MLHFQ_Assessments = new Lazy<bool?>(this.Has_Encounter_with_Initial_and_Follow_Up_MLHFQ_Assessments_Value);
        __Date_KCCQ12_Total_Assessment_Completed = new Lazy<IEnumerable<CqlDate>>(this.Date_KCCQ12_Total_Assessment_Completed_Value);
        __Has_Encounter_with_Initial_and_Follow_Up_KCCQ12_Assessments = new Lazy<bool?>(this.Has_Encounter_with_Initial_and_Follow_Up_KCCQ12_Assessments_Value);
        __Date_KCCQ_Domain_Assessment_Completed = new Lazy<IEnumerable<CqlDate>>(this.Date_KCCQ_Domain_Assessment_Completed_Value);
        __Has_Encounter_with_Initial_and_Follow_Up_KCCQ_Domain_Score_Assessments = new Lazy<bool?>(this.Has_Encounter_with_Initial_and_Follow_Up_KCCQ_Domain_Score_Assessments_Value);
        __Date_KCCQ_Total_Assessment_Completed = new Lazy<IEnumerable<CqlDate>>(this.Date_KCCQ_Total_Assessment_Completed_Value);
        __Has_Encounter_with_Initial_and_Follow_Up_KCCQ_Total_Score_Assessments = new Lazy<bool?>(this.Has_Encounter_with_Initial_and_Follow_Up_KCCQ_Total_Score_Assessments_Value);
        __Numerator = new Lazy<bool?>(this.Numerator_Value);
    }
    #region Dependencies

    public FHIRHelpers_4_3_000 FHIRHelpers_4_3_000 { get; }
    public SupplementalDataElements_3_4_000 SupplementalDataElements_3_4_000 { get; }
    public CQMCommon_2_0_000 CQMCommon_2_0_000 { get; }
    public Hospice_6_9_000 Hospice_6_9_000 { get; }
    public Status_1_6_000 Status_1_6_000 { get; }
    public QICoreCommon_2_0_000 QICoreCommon_2_0_000 { get; }

    #endregion

	private CqlValueSet Heart_Failure_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.376", null);

    [CqlDeclaration("Heart Failure")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.376")]
	public CqlValueSet Heart_Failure() => 
		__Heart_Failure.Value;

	private CqlValueSet Office_Visit_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1001", null);

    [CqlDeclaration("Office Visit")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1001")]
	public CqlValueSet Office_Visit() => 
		__Office_Visit.Value;

	private CqlValueSet Online_Assessments_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1089", null);

    [CqlDeclaration("Online Assessments")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1089")]
	public CqlValueSet Online_Assessments() => 
		__Online_Assessments.Value;

	private CqlValueSet Telephone_Visits_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1080", null);

    [CqlDeclaration("Telephone Visits")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1080")]
	public CqlValueSet Telephone_Visits() => 
		__Telephone_Visits.Value;

	private CqlCode Emotional_score__MLHFQ__Value() => 
		new CqlCode("85609-6", "http://loinc.org", null, null);

    [CqlDeclaration("Emotional score [MLHFQ]")]
	public CqlCode Emotional_score__MLHFQ_() => 
		__Emotional_score__MLHFQ_.Value;

	private CqlCode Kansas_City_Cardiomyopathy_Questionnaire___12_item__KCCQ_12__Value() => 
		new CqlCode("86923-0", "http://loinc.org", null, null);

    [CqlDeclaration("Kansas City Cardiomyopathy Questionnaire - 12 item [KCCQ-12]")]
	public CqlCode Kansas_City_Cardiomyopathy_Questionnaire___12_item__KCCQ_12_() => 
		__Kansas_City_Cardiomyopathy_Questionnaire___12_item__KCCQ_12_.Value;

	private CqlCode Overall_summary_score__KCCQ_12__Value() => 
		new CqlCode("86924-8", "http://loinc.org", null, null);

    [CqlDeclaration("Overall summary score [KCCQ-12]")]
	public CqlCode Overall_summary_score__KCCQ_12_() => 
		__Overall_summary_score__KCCQ_12_.Value;

	private CqlCode Overall_summary_score__KCCQ__Value() => 
		new CqlCode("71940-1", "http://loinc.org", null, null);

    [CqlDeclaration("Overall summary score [KCCQ]")]
	public CqlCode Overall_summary_score__KCCQ_() => 
		__Overall_summary_score__KCCQ_.Value;

	private CqlCode Physical_limitation_score__KCCQ__Value() => 
		new CqlCode("72195-1", "http://loinc.org", null, null);

    [CqlDeclaration("Physical limitation score [KCCQ]")]
	public CqlCode Physical_limitation_score__KCCQ_() => 
		__Physical_limitation_score__KCCQ_.Value;

	private CqlCode Physical_score__MLHFQ__Value() => 
		new CqlCode("85618-7", "http://loinc.org", null, null);

    [CqlDeclaration("Physical score [MLHFQ]")]
	public CqlCode Physical_score__MLHFQ_() => 
		__Physical_score__MLHFQ_.Value;

	private CqlCode PROMIS_10_Global_Mental_Health__GMH__score_T_score_Value() => 
		new CqlCode("71969-0", "http://loinc.org", null, null);

    [CqlDeclaration("PROMIS-10 Global Mental Health (GMH) score T-score")]
	public CqlCode PROMIS_10_Global_Mental_Health__GMH__score_T_score() => 
		__PROMIS_10_Global_Mental_Health__GMH__score_T_score.Value;

	private CqlCode PROMIS_10_Global_Physical_Health__GPH__score_T_score_Value() => 
		new CqlCode("71971-6", "http://loinc.org", null, null);

    [CqlDeclaration("PROMIS-10 Global Physical Health (GPH) score T-score")]
	public CqlCode PROMIS_10_Global_Physical_Health__GPH__score_T_score() => 
		__PROMIS_10_Global_Physical_Health__GPH__score_T_score.Value;

	private CqlCode PROMIS_29_Anxiety_score_T_score_Value() => 
		new CqlCode("71967-4", "http://loinc.org", null, null);

    [CqlDeclaration("PROMIS-29 Anxiety score T-score")]
	public CqlCode PROMIS_29_Anxiety_score_T_score() => 
		__PROMIS_29_Anxiety_score_T_score.Value;

	private CqlCode PROMIS_29_Depression_score_T_score_Value() => 
		new CqlCode("71965-8", "http://loinc.org", null, null);

    [CqlDeclaration("PROMIS-29 Depression score T-score")]
	public CqlCode PROMIS_29_Depression_score_T_score() => 
		__PROMIS_29_Depression_score_T_score.Value;

	private CqlCode PROMIS_29_Fatigue_score_T_score_Value() => 
		new CqlCode("71963-3", "http://loinc.org", null, null);

    [CqlDeclaration("PROMIS-29 Fatigue score T-score")]
	public CqlCode PROMIS_29_Fatigue_score_T_score() => 
		__PROMIS_29_Fatigue_score_T_score.Value;

	private CqlCode PROMIS_29_Pain_interference_score_T_score_Value() => 
		new CqlCode("71961-7", "http://loinc.org", null, null);

    [CqlDeclaration("PROMIS-29 Pain interference score T-score")]
	public CqlCode PROMIS_29_Pain_interference_score_T_score() => 
		__PROMIS_29_Pain_interference_score_T_score.Value;

	private CqlCode PROMIS_29_Physical_function_score_T_score_Value() => 
		new CqlCode("71959-1", "http://loinc.org", null, null);

    [CqlDeclaration("PROMIS-29 Physical function score T-score")]
	public CqlCode PROMIS_29_Physical_function_score_T_score() => 
		__PROMIS_29_Physical_function_score_T_score.Value;

	private CqlCode PROMIS_29_Satisfaction_with_participation_in_social_roles_score_T_score_Value() => 
		new CqlCode("71957-5", "http://loinc.org", null, null);

    [CqlDeclaration("PROMIS-29 Satisfaction with participation in social roles score T-score")]
	public CqlCode PROMIS_29_Satisfaction_with_participation_in_social_roles_score_T_score() => 
		__PROMIS_29_Satisfaction_with_participation_in_social_roles_score_T_score.Value;

	private CqlCode PROMIS_29_Sleep_disturbance_score_T_score_Value() => 
		new CqlCode("71955-9", "http://loinc.org", null, null);

    [CqlDeclaration("PROMIS-29 Sleep disturbance score T-score")]
	public CqlCode PROMIS_29_Sleep_disturbance_score_T_score() => 
		__PROMIS_29_Sleep_disturbance_score_T_score.Value;

	private CqlCode Quality_of_life_score__KCCQ__Value() => 
		new CqlCode("72189-4", "http://loinc.org", null, null);

    [CqlDeclaration("Quality of life score [KCCQ]")]
	public CqlCode Quality_of_life_score__KCCQ_() => 
		__Quality_of_life_score__KCCQ_.Value;

	private CqlCode Self_efficacy_score__KCCQ__Value() => 
		new CqlCode("72190-2", "http://loinc.org", null, null);

    [CqlDeclaration("Self-efficacy score [KCCQ]")]
	public CqlCode Self_efficacy_score__KCCQ_() => 
		__Self_efficacy_score__KCCQ_.Value;

	private CqlCode Severe_cognitive_impairment__finding__Value() => 
		new CqlCode("702956004", "http://snomed.info/sct", null, null);

    [CqlDeclaration("Severe cognitive impairment (finding)")]
	public CqlCode Severe_cognitive_impairment__finding_() => 
		__Severe_cognitive_impairment__finding_.Value;

	private CqlCode Social_limitation_score__KCCQ__Value() => 
		new CqlCode("72196-9", "http://loinc.org", null, null);

    [CqlDeclaration("Social limitation score [KCCQ]")]
	public CqlCode Social_limitation_score__KCCQ_() => 
		__Social_limitation_score__KCCQ_.Value;

	private CqlCode Symptom_stability_score__KCCQ__Value() => 
		new CqlCode("72194-4", "http://loinc.org", null, null);

    [CqlDeclaration("Symptom stability score [KCCQ]")]
	public CqlCode Symptom_stability_score__KCCQ_() => 
		__Symptom_stability_score__KCCQ_.Value;

	private CqlCode Total_score__MLHFQ__Value() => 
		new CqlCode("71938-5", "http://loinc.org", null, null);

    [CqlDeclaration("Total score [MLHFQ]")]
	public CqlCode Total_score__MLHFQ_() => 
		__Total_score__MLHFQ_.Value;

	private CqlCode Total_symptom_score__KCCQ__Value() => 
		new CqlCode("72191-0", "http://loinc.org", null, null);

    [CqlDeclaration("Total symptom score [KCCQ]")]
	public CqlCode Total_symptom_score__KCCQ_() => 
		__Total_symptom_score__KCCQ_.Value;

	private CqlCode VR_12_Mental_component_summary__MCS__score___oblique_method_T_score_Value() => 
		new CqlCode("72026-8", "http://loinc.org", null, null);

    [CqlDeclaration("VR-12 Mental component summary (MCS) score - oblique method T-score")]
	public CqlCode VR_12_Mental_component_summary__MCS__score___oblique_method_T_score() => 
		__VR_12_Mental_component_summary__MCS__score___oblique_method_T_score.Value;

	private CqlCode VR_12_Mental_component_summary__MCS__score___orthogonal_method_T_score_Value() => 
		new CqlCode("72028-4", "http://loinc.org", null, null);

    [CqlDeclaration("VR-12 Mental component summary (MCS) score - orthogonal method T-score")]
	public CqlCode VR_12_Mental_component_summary__MCS__score___orthogonal_method_T_score() => 
		__VR_12_Mental_component_summary__MCS__score___orthogonal_method_T_score.Value;

	private CqlCode VR_12_Physical_component_summary__PCS__score___oblique_method_T_score_Value() => 
		new CqlCode("72025-0", "http://loinc.org", null, null);

    [CqlDeclaration("VR-12 Physical component summary (PCS) score - oblique method T-score")]
	public CqlCode VR_12_Physical_component_summary__PCS__score___oblique_method_T_score() => 
		__VR_12_Physical_component_summary__PCS__score___oblique_method_T_score.Value;

	private CqlCode VR_12_Physical_component_summary__PCS__score___orthogonal_method_T_score_Value() => 
		new CqlCode("72027-6", "http://loinc.org", null, null);

    [CqlDeclaration("VR-12 Physical component summary (PCS) score - orthogonal method T-score")]
	public CqlCode VR_12_Physical_component_summary__PCS__score___orthogonal_method_T_score() => 
		__VR_12_Physical_component_summary__PCS__score___orthogonal_method_T_score.Value;

	private CqlCode VR_36_Mental_component_summary__MCS__score___oblique_method_T_score_Value() => 
		new CqlCode("71990-6", "http://loinc.org", null, null);

    [CqlDeclaration("VR-36 Mental component summary (MCS) score - oblique method T-score")]
	public CqlCode VR_36_Mental_component_summary__MCS__score___oblique_method_T_score() => 
		__VR_36_Mental_component_summary__MCS__score___oblique_method_T_score.Value;

	private CqlCode VR_36_Mental_component_summary__MCS__score___orthogonal_method_T_score_Value() => 
		new CqlCode("72008-6", "http://loinc.org", null, null);

    [CqlDeclaration("VR-36 Mental component summary (MCS) score - orthogonal method T-score")]
	public CqlCode VR_36_Mental_component_summary__MCS__score___orthogonal_method_T_score() => 
		__VR_36_Mental_component_summary__MCS__score___orthogonal_method_T_score.Value;

	private CqlCode VR_36_Physical_component_summary__PCS__score___oblique_method_T_score_Value() => 
		new CqlCode("71989-8", "http://loinc.org", null, null);

    [CqlDeclaration("VR-36 Physical component summary (PCS) score - oblique method T-score")]
	public CqlCode VR_36_Physical_component_summary__PCS__score___oblique_method_T_score() => 
		__VR_36_Physical_component_summary__PCS__score___oblique_method_T_score.Value;

	private CqlCode VR_36_Physical_component_summary__PCS__score___orthogonal_method_T_score_Value() => 
		new CqlCode("72007-8", "http://loinc.org", null, null);

    [CqlDeclaration("VR-36 Physical component summary (PCS) score - orthogonal method T-score")]
	public CqlCode VR_36_Physical_component_summary__PCS__score___orthogonal_method_T_score() => 
		__VR_36_Physical_component_summary__PCS__score___orthogonal_method_T_score.Value;

	private CqlCode[] LOINC_Value()
	{
		CqlCode[] a_ = new CqlCode[]
		{
			new CqlCode("85609-6", "http://loinc.org", null, null),
			new CqlCode("86923-0", "http://loinc.org", null, null),
			new CqlCode("86924-8", "http://loinc.org", null, null),
			new CqlCode("71940-1", "http://loinc.org", null, null),
			new CqlCode("72195-1", "http://loinc.org", null, null),
			new CqlCode("85618-7", "http://loinc.org", null, null),
			new CqlCode("71969-0", "http://loinc.org", null, null),
			new CqlCode("71971-6", "http://loinc.org", null, null),
			new CqlCode("71967-4", "http://loinc.org", null, null),
			new CqlCode("71965-8", "http://loinc.org", null, null),
			new CqlCode("71963-3", "http://loinc.org", null, null),
			new CqlCode("71961-7", "http://loinc.org", null, null),
			new CqlCode("71959-1", "http://loinc.org", null, null),
			new CqlCode("71957-5", "http://loinc.org", null, null),
			new CqlCode("71955-9", "http://loinc.org", null, null),
			new CqlCode("72189-4", "http://loinc.org", null, null),
			new CqlCode("72190-2", "http://loinc.org", null, null),
			new CqlCode("72196-9", "http://loinc.org", null, null),
			new CqlCode("72194-4", "http://loinc.org", null, null),
			new CqlCode("71938-5", "http://loinc.org", null, null),
			new CqlCode("72191-0", "http://loinc.org", null, null),
			new CqlCode("72026-8", "http://loinc.org", null, null),
			new CqlCode("72028-4", "http://loinc.org", null, null),
			new CqlCode("72025-0", "http://loinc.org", null, null),
			new CqlCode("72027-6", "http://loinc.org", null, null),
			new CqlCode("71990-6", "http://loinc.org", null, null),
			new CqlCode("72008-6", "http://loinc.org", null, null),
			new CqlCode("71989-8", "http://loinc.org", null, null),
			new CqlCode("72007-8", "http://loinc.org", null, null),
		};

		return a_;
	}

    [CqlDeclaration("LOINC")]
	public CqlCode[] LOINC() => 
		__LOINC.Value;

	private CqlCode[] SNOMEDCT_Value()
	{
		CqlCode[] a_ = new CqlCode[]
		{
			new CqlCode("702956004", "http://snomed.info/sct", null, null),
		};

		return a_;
	}

    [CqlDeclaration("SNOMEDCT")]
	public CqlCode[] SNOMEDCT() => 
		__SNOMEDCT.Value;

	private CqlInterval<CqlDateTime> Measurement_Period_Value()
	{
		CqlDateTime a_ = context.Operators.DateTime(2025, 1, 1, 0, 0, 0, 0, default);
		CqlDateTime b_ = context.Operators.DateTime(2026, 1, 1, 0, 0, 0, 0, default);
		CqlInterval<CqlDateTime> c_ = context.Operators.Interval(a_, b_, true, false);
		object d_ = context.ResolveParameter("FunctionalStatusAssessmentsforHeartFailureFHIR-0.1.000", "Measurement Period", c_);

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

	private IEnumerable<Encounter> Qualifying_Encounters_Value()
	{
		CqlValueSet a_ = this.Office_Visit();
		IEnumerable<Encounter> b_ = context.Operators.RetrieveByValueSet<Encounter>(a_, null);
		CqlValueSet c_ = this.Telephone_Visits();
		IEnumerable<Encounter> d_ = context.Operators.RetrieveByValueSet<Encounter>(c_, null);
		IEnumerable<Encounter> e_ = context.Operators.ListUnion<Encounter>(b_, d_);
		CqlValueSet f_ = this.Online_Assessments();
		IEnumerable<Encounter> g_ = context.Operators.RetrieveByValueSet<Encounter>(f_, null);
		IEnumerable<Encounter> h_ = context.Operators.ListUnion<Encounter>(e_, g_);
		IEnumerable<Encounter> i_ = Status_1_6_000.Finished_Encounter(h_);
		bool? j_(Encounter ValidEncounter)
		{
			CqlInterval<CqlDateTime> l_ = this.Measurement_Period();
			CqlInterval<CqlDateTime> m_ = FHIRHelpers_4_3_000.ToInterval(ValidEncounter?.Period);
			CqlInterval<CqlDateTime> n_ = QICoreCommon_2_0_000.ToInterval((m_ as object));
			bool? o_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(l_, n_, "day");

			return o_;
		};
		IEnumerable<Encounter> k_ = context.Operators.Where<Encounter>(i_, j_);

		return k_;
	}

    [CqlDeclaration("Qualifying Encounters")]
	public IEnumerable<Encounter> Qualifying_Encounters() => 
		__Qualifying_Encounters.Value;

	private IEnumerable<Encounter> Two_Outpatient_Encounters_during_Measurement_Period_Value()
	{
		IEnumerable<Encounter> a_ = this.Qualifying_Encounters();
		IEnumerable<ValueTuple<Encounter,Encounter>> c_ = context.Operators.CrossJoin<Encounter, Encounter>(a_, a_);
		Tuple_FGYJHhbRRZTDGeEKJQJIIbGUe d_(ValueTuple<Encounter,Encounter> _valueTuple)
		{
			Tuple_FGYJHhbRRZTDGeEKJQJIIbGUe j_ = new Tuple_FGYJHhbRRZTDGeEKJQJIIbGUe
			{
				OfficeVisit1 = _valueTuple.Item1,
				OfficeVisit2 = _valueTuple.Item2,
			};

			return j_;
		};
		IEnumerable<Tuple_FGYJHhbRRZTDGeEKJQJIIbGUe> e_ = context.Operators.Select<ValueTuple<Encounter,Encounter>, Tuple_FGYJHhbRRZTDGeEKJQJIIbGUe>(c_, d_);
		bool? f_(Tuple_FGYJHhbRRZTDGeEKJQJIIbGUe tuple_fgyjhhbrrztdgeekjqjiibgue)
		{
			CqlInterval<CqlDateTime> k_ = FHIRHelpers_4_3_000.ToInterval(tuple_fgyjhhbrrztdgeekjqjiibgue.OfficeVisit2?.Period);
			CqlInterval<CqlDateTime> l_ = QICoreCommon_2_0_000.ToInterval((k_ as object));
			CqlDateTime m_ = context.Operators.Start(l_);
			CqlInterval<CqlDateTime> n_ = FHIRHelpers_4_3_000.ToInterval(tuple_fgyjhhbrrztdgeekjqjiibgue.OfficeVisit1?.Period);
			CqlInterval<CqlDateTime> o_ = QICoreCommon_2_0_000.ToInterval((n_ as object));
			CqlDateTime p_ = context.Operators.End(o_);
			CqlQuantity q_ = context.Operators.Quantity(1m, "day");
			CqlDateTime r_ = context.Operators.Add(p_, q_);
			bool? s_ = context.Operators.SameOrAfter(m_, r_, "day");

			return s_;
		};
		IEnumerable<Tuple_FGYJHhbRRZTDGeEKJQJIIbGUe> g_ = context.Operators.Where<Tuple_FGYJHhbRRZTDGeEKJQJIIbGUe>(e_, f_);
		Encounter h_(Tuple_FGYJHhbRRZTDGeEKJQJIIbGUe tuple_fgyjhhbrrztdgeekjqjiibgue) => 
			tuple_fgyjhhbrrztdgeekjqjiibgue.OfficeVisit1;
		IEnumerable<Encounter> i_ = context.Operators.Select<Tuple_FGYJHhbRRZTDGeEKJQJIIbGUe, Encounter>(g_, h_);

		return i_;
	}

    [CqlDeclaration("Two Outpatient Encounters during Measurement Period")]
	public IEnumerable<Encounter> Two_Outpatient_Encounters_during_Measurement_Period() => 
		__Two_Outpatient_Encounters_during_Measurement_Period.Value;

	private bool? Initial_Population_Value()
	{
		Patient a_ = this.Patient();
		CqlDate b_ = context.Operators.Convert<CqlDate>(a_?.BirthDateElement?.Value);
		CqlInterval<CqlDateTime> c_ = this.Measurement_Period();
		CqlDateTime d_ = context.Operators.Start(c_);
		CqlDate e_ = context.Operators.DateFrom(d_);
		int? f_ = context.Operators.CalculateAgeAt(b_, e_, "year");
		bool? g_ = context.Operators.GreaterOrEqual(f_, 18);
		CqlValueSet h_ = this.Heart_Failure();
		IEnumerable<Condition> i_ = context.Operators.RetrieveByValueSet<Condition>(h_, null);
		bool? j_(Condition HeartFailure)
		{
			CqlInterval<CqlDateTime> q_ = QICoreCommon_2_0_000.ToPrevalenceInterval(HeartFailure);
			CqlInterval<CqlDateTime> r_ = this.Measurement_Period();
			bool? s_ = context.Operators.OverlapsBefore(q_, r_, null);

			return s_;
		};
		IEnumerable<Condition> k_ = context.Operators.Where<Condition>(i_, j_);
		bool? l_ = context.Operators.Exists<Condition>(k_);
		bool? m_ = context.Operators.And(g_, l_);
		IEnumerable<Encounter> n_ = this.Two_Outpatient_Encounters_during_Measurement_Period();
		bool? o_ = context.Operators.Exists<Encounter>(n_);
		bool? p_ = context.Operators.And(m_, o_);

		return p_;
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

	private bool? Denominator_Exclusions_Value()
	{
		bool? a_ = Hospice_6_9_000.Has_Hospice_Services();
		CqlCode b_ = this.Severe_cognitive_impairment__finding_();
		IEnumerable<CqlCode> c_ = context.Operators.ToList<CqlCode>(b_);
		IEnumerable<Condition> d_ = context.Operators.RetrieveByCodes<Condition>(c_, null);
		bool? e_(Condition Dementia)
		{
			CqlInterval<CqlDateTime> i_ = QICoreCommon_2_0_000.ToPrevalenceInterval(Dementia);
			CqlInterval<CqlDateTime> j_ = this.Measurement_Period();
			bool? k_ = context.Operators.Overlaps(i_, j_, null);

			return k_;
		};
		IEnumerable<Condition> f_ = context.Operators.Where<Condition>(d_, e_);
		bool? g_ = context.Operators.Exists<Condition>(f_);
		bool? h_ = context.Operators.Or(a_, g_);

		return h_;
	}

    [CqlDeclaration("Denominator Exclusions")]
	public bool? Denominator_Exclusions() => 
		__Denominator_Exclusions.Value;

	private IEnumerable<CqlDate> Date_PROMIS10_Total_Assessment_Completed_Value()
	{
		CqlCode a_ = this.PROMIS_10_Global_Mental_Health__GMH__score_T_score();
		IEnumerable<CqlCode> b_ = context.Operators.ToList<CqlCode>(a_);
		IEnumerable<Observation> c_ = context.Operators.RetrieveByCodes<Observation>(b_, null);
		IEnumerable<Observation> d_ = Status_1_6_000.Final_Survey_Observation(c_);
		CqlCode e_ = this.PROMIS_10_Global_Physical_Health__GPH__score_T_score();
		IEnumerable<CqlCode> f_ = context.Operators.ToList<CqlCode>(e_);
		IEnumerable<Observation> g_ = context.Operators.RetrieveByCodes<Observation>(f_, null);
		IEnumerable<Observation> h_ = Status_1_6_000.Final_Survey_Observation(g_);
		IEnumerable<ValueTuple<Observation,Observation>> i_ = context.Operators.CrossJoin<Observation, Observation>(d_, h_);
		Tuple_CSQNXjbdUJCRVLSGAJQOISbPM j_(ValueTuple<Observation,Observation> _valueTuple)
		{
			Tuple_CSQNXjbdUJCRVLSGAJQOISbPM p_ = new Tuple_CSQNXjbdUJCRVLSGAJQOISbPM
			{
				PROMIS10MentalScore = _valueTuple.Item1,
				PROMIS10PhysicalScore = _valueTuple.Item2,
			};

			return p_;
		};
		IEnumerable<Tuple_CSQNXjbdUJCRVLSGAJQOISbPM> k_ = context.Operators.Select<ValueTuple<Observation,Observation>, Tuple_CSQNXjbdUJCRVLSGAJQOISbPM>(i_, j_);
		bool? l_(Tuple_CSQNXjbdUJCRVLSGAJQOISbPM tuple_csqnxjbdujcrvlsgajqoisbpm)
		{
			object q_ = FHIRHelpers_4_3_000.ToValue(tuple_csqnxjbdujcrvlsgajqoisbpm.PROMIS10MentalScore?.Effective);
			CqlInterval<CqlDateTime> r_ = QICoreCommon_2_0_000.ToInterval(q_);
			CqlDateTime s_ = context.Operators.Start(r_);
			CqlDate t_ = context.Operators.DateFrom(s_);
			object u_ = FHIRHelpers_4_3_000.ToValue(tuple_csqnxjbdujcrvlsgajqoisbpm.PROMIS10PhysicalScore?.Effective);
			CqlInterval<CqlDateTime> v_ = QICoreCommon_2_0_000.ToInterval(u_);
			CqlDateTime w_ = context.Operators.Start(v_);
			CqlDate x_ = context.Operators.DateFrom(w_);
			bool? y_ = context.Operators.SameAs(t_, x_, "day");
			object z_ = FHIRHelpers_4_3_000.ToValue(tuple_csqnxjbdujcrvlsgajqoisbpm.PROMIS10MentalScore?.Value);
			bool? aa_ = context.Operators.Not((bool?)(z_ is null));
			bool? ab_ = context.Operators.And(y_, aa_);
			object ac_ = FHIRHelpers_4_3_000.ToValue(tuple_csqnxjbdujcrvlsgajqoisbpm.PROMIS10PhysicalScore?.Value);
			bool? ad_ = context.Operators.Not((bool?)(ac_ is null));
			bool? ae_ = context.Operators.And(ab_, ad_);

			return ae_;
		};
		IEnumerable<Tuple_CSQNXjbdUJCRVLSGAJQOISbPM> m_ = context.Operators.Where<Tuple_CSQNXjbdUJCRVLSGAJQOISbPM>(k_, l_);
		CqlDate n_(Tuple_CSQNXjbdUJCRVLSGAJQOISbPM tuple_csqnxjbdujcrvlsgajqoisbpm)
		{
			object af_ = FHIRHelpers_4_3_000.ToValue(tuple_csqnxjbdujcrvlsgajqoisbpm.PROMIS10MentalScore?.Effective);
			CqlInterval<CqlDateTime> ag_ = QICoreCommon_2_0_000.ToInterval(af_);
			CqlDateTime ah_ = context.Operators.Start(ag_);
			CqlDate ai_ = context.Operators.DateFrom(ah_);
			object aj_ = FHIRHelpers_4_3_000.ToValue(tuple_csqnxjbdujcrvlsgajqoisbpm.PROMIS10PhysicalScore?.Effective);
			CqlInterval<CqlDateTime> ak_ = QICoreCommon_2_0_000.ToInterval(aj_);
			CqlDateTime al_ = context.Operators.Start(ak_);
			CqlDate am_ = context.Operators.DateFrom(al_);
			CqlDate[] an_ = new CqlDate[]
			{
				ai_,
				am_,
			};
			CqlDate ao_ = context.Operators.Max<CqlDate>((an_ as IEnumerable<CqlDate>));

			return ao_;
		};
		IEnumerable<CqlDate> o_ = context.Operators.Select<Tuple_CSQNXjbdUJCRVLSGAJQOISbPM, CqlDate>(m_, n_);

		return o_;
	}

    [CqlDeclaration("Date PROMIS10 Total Assessment Completed")]
	public IEnumerable<CqlDate> Date_PROMIS10_Total_Assessment_Completed() => 
		__Date_PROMIS10_Total_Assessment_Completed.Value;

	private bool? Has_Encounter_with_Initial_and_Follow_Up_PROMIS10_Assessments_Value()
	{
		IEnumerable<Encounter> a_ = this.Qualifying_Encounters();
		IEnumerable<CqlDate> b_ = this.Date_PROMIS10_Total_Assessment_Completed();
		IEnumerable<ValueTuple<Encounter,CqlDate,CqlDate>> d_ = context.Operators.CrossJoin<Encounter, CqlDate, CqlDate>(a_, b_, b_);
		Tuple_BaPOXCdQPieFFFdPRAYQHJVMK e_(ValueTuple<Encounter,CqlDate,CqlDate> _valueTuple)
		{
			Tuple_BaPOXCdQPieFFFdPRAYQHJVMK l_ = new Tuple_BaPOXCdQPieFFFdPRAYQHJVMK
			{
				ValidEncounters = _valueTuple.Item1,
				InitialPROMIS10Date = _valueTuple.Item2,
				FollowupPROMIS10Date = _valueTuple.Item3,
			};

			return l_;
		};
		IEnumerable<Tuple_BaPOXCdQPieFFFdPRAYQHJVMK> f_ = context.Operators.Select<ValueTuple<Encounter,CqlDate,CqlDate>, Tuple_BaPOXCdQPieFFFdPRAYQHJVMK>(d_, e_);
		bool? g_(Tuple_BaPOXCdQPieFFFdPRAYQHJVMK tuple_bapoxcdqpiefffdprayqhjvmk)
		{
			CqlInterval<CqlDateTime> m_ = FHIRHelpers_4_3_000.ToInterval(tuple_bapoxcdqpiefffdprayqhjvmk.ValidEncounters?.Period);
			CqlInterval<CqlDateTime> n_ = QICoreCommon_2_0_000.ToInterval((m_ as object));
			CqlDateTime o_ = context.Operators.End(n_);
			CqlInterval<CqlDateTime> p_ = this.Measurement_Period();
			CqlDateTime q_ = context.Operators.End(p_);
			CqlQuantity r_ = context.Operators.Quantity(180m, "days");
			CqlDateTime s_ = context.Operators.Subtract(q_, r_);
			bool? t_ = context.Operators.SameOrBefore(o_, s_, "day");
			CqlDateTime u_ = context.Operators.ConvertDateToDateTime(tuple_bapoxcdqpiefffdprayqhjvmk.InitialPROMIS10Date);
			CqlInterval<CqlDateTime> w_ = QICoreCommon_2_0_000.ToInterval((m_ as object));
			CqlDateTime x_ = context.Operators.End(w_);
			CqlQuantity y_ = context.Operators.Quantity(14m, "days");
			CqlDateTime z_ = context.Operators.Subtract(x_, y_);
			CqlInterval<CqlDateTime> ab_ = QICoreCommon_2_0_000.ToInterval((m_ as object));
			CqlDateTime ac_ = context.Operators.End(ab_);
			CqlInterval<CqlDateTime> ad_ = context.Operators.Interval(z_, ac_, true, true);
			bool? ae_ = context.Operators.In<CqlDateTime>(u_, ad_, "day");
			CqlInterval<CqlDateTime> ag_ = QICoreCommon_2_0_000.ToInterval((m_ as object));
			CqlDateTime ah_ = context.Operators.End(ag_);
			bool? ai_ = context.Operators.Not((bool?)(ah_ is null));
			bool? aj_ = context.Operators.And(ae_, ai_);
			bool? ak_ = context.Operators.And(t_, aj_);
			CqlDateTime al_ = context.Operators.ConvertDateToDateTime(tuple_bapoxcdqpiefffdprayqhjvmk.FollowupPROMIS10Date);
			CqlDate am_ = context.Operators.DateFrom(al_);
			CqlDate ao_ = context.Operators.DateFrom(u_);
			CqlQuantity ap_ = context.Operators.Quantity(30m, "days");
			CqlDate aq_ = context.Operators.Add(ao_, ap_);
			CqlDate as_ = context.Operators.DateFrom(u_);
			CqlDate au_ = context.Operators.Add(as_, r_);
			CqlInterval<CqlDate> av_ = context.Operators.Interval(aq_, au_, true, true);
			bool? aw_ = context.Operators.In<CqlDate>(am_, av_, "day");
			bool? ax_ = context.Operators.And(ak_, aw_);

			return ax_;
		};
		IEnumerable<Tuple_BaPOXCdQPieFFFdPRAYQHJVMK> h_ = context.Operators.Where<Tuple_BaPOXCdQPieFFFdPRAYQHJVMK>(f_, g_);
		Encounter i_(Tuple_BaPOXCdQPieFFFdPRAYQHJVMK tuple_bapoxcdqpiefffdprayqhjvmk) => 
			tuple_bapoxcdqpiefffdprayqhjvmk.ValidEncounters;
		IEnumerable<Encounter> j_ = context.Operators.Select<Tuple_BaPOXCdQPieFFFdPRAYQHJVMK, Encounter>(h_, i_);
		bool? k_ = context.Operators.Exists<Encounter>(j_);

		return k_;
	}

    [CqlDeclaration("Has Encounter with Initial and Follow Up PROMIS10 Assessments")]
	public bool? Has_Encounter_with_Initial_and_Follow_Up_PROMIS10_Assessments() => 
		__Has_Encounter_with_Initial_and_Follow_Up_PROMIS10_Assessments.Value;

	private IEnumerable<CqlDate> Date_PROMIS29_Total_Assessment_Completed_Value()
	{
		CqlCode a_ = this.PROMIS_29_Sleep_disturbance_score_T_score();
		IEnumerable<CqlCode> b_ = context.Operators.ToList<CqlCode>(a_);
		IEnumerable<Observation> c_ = context.Operators.RetrieveByCodes<Observation>(b_, null);
		IEnumerable<Observation> d_ = Status_1_6_000.Final_Survey_Observation(c_);
		CqlCode e_ = this.PROMIS_29_Satisfaction_with_participation_in_social_roles_score_T_score();
		IEnumerable<CqlCode> f_ = context.Operators.ToList<CqlCode>(e_);
		IEnumerable<Observation> g_ = context.Operators.RetrieveByCodes<Observation>(f_, null);
		IEnumerable<Observation> h_ = Status_1_6_000.Final_Survey_Observation(g_);
		CqlCode i_ = this.PROMIS_29_Physical_function_score_T_score();
		IEnumerable<CqlCode> j_ = context.Operators.ToList<CqlCode>(i_);
		IEnumerable<Observation> k_ = context.Operators.RetrieveByCodes<Observation>(j_, null);
		IEnumerable<Observation> l_ = Status_1_6_000.Final_Survey_Observation(k_);
		CqlCode m_ = this.PROMIS_29_Pain_interference_score_T_score();
		IEnumerable<CqlCode> n_ = context.Operators.ToList<CqlCode>(m_);
		IEnumerable<Observation> o_ = context.Operators.RetrieveByCodes<Observation>(n_, null);
		IEnumerable<Observation> p_ = Status_1_6_000.Final_Survey_Observation(o_);
		CqlCode q_ = this.PROMIS_29_Fatigue_score_T_score();
		IEnumerable<CqlCode> r_ = context.Operators.ToList<CqlCode>(q_);
		IEnumerable<Observation> s_ = context.Operators.RetrieveByCodes<Observation>(r_, null);
		IEnumerable<Observation> t_ = Status_1_6_000.Final_Survey_Observation(s_);
		CqlCode u_ = this.PROMIS_29_Depression_score_T_score();
		IEnumerable<CqlCode> v_ = context.Operators.ToList<CqlCode>(u_);
		IEnumerable<Observation> w_ = context.Operators.RetrieveByCodes<Observation>(v_, null);
		IEnumerable<Observation> x_ = Status_1_6_000.Final_Survey_Observation(w_);
		CqlCode y_ = this.PROMIS_29_Anxiety_score_T_score();
		IEnumerable<CqlCode> z_ = context.Operators.ToList<CqlCode>(y_);
		IEnumerable<Observation> aa_ = context.Operators.RetrieveByCodes<Observation>(z_, null);
		IEnumerable<Observation> ab_ = Status_1_6_000.Final_Survey_Observation(aa_);
		IEnumerable<ValueTuple<Observation,Observation,Observation,Observation,Observation,Observation,Observation>> ac_ = context.Operators.CrossJoin<Observation, Observation, Observation, Observation, Observation, Observation, Observation>(d_, h_, l_, p_, t_, x_, ab_);
		Tuple_ITZjeBeBSEgNiFGcLhJYIJNb ad_(ValueTuple<Observation,Observation,Observation,Observation,Observation,Observation,Observation> _valueTuple)
		{
			Tuple_ITZjeBeBSEgNiFGcLhJYIJNb aj_ = new Tuple_ITZjeBeBSEgNiFGcLhJYIJNb
			{
				Promis29Sleep = _valueTuple.Item1,
				Promis29SocialRoles = _valueTuple.Item2,
				Promis29Physical = _valueTuple.Item3,
				Promis29Pain = _valueTuple.Item4,
				Promis29Fatigue = _valueTuple.Item5,
				Promis29Depression = _valueTuple.Item6,
				Promis29Anxiety = _valueTuple.Item7,
			};

			return aj_;
		};
		IEnumerable<Tuple_ITZjeBeBSEgNiFGcLhJYIJNb> ae_ = context.Operators.Select<ValueTuple<Observation,Observation,Observation,Observation,Observation,Observation,Observation>, Tuple_ITZjeBeBSEgNiFGcLhJYIJNb>(ac_, ad_);
		bool? af_(Tuple_ITZjeBeBSEgNiFGcLhJYIJNb tuple_itzjebebsegnifgclhjyijnb)
		{
			object ak_ = FHIRHelpers_4_3_000.ToValue(tuple_itzjebebsegnifgclhjyijnb.Promis29Sleep?.Effective);
			CqlInterval<CqlDateTime> al_ = QICoreCommon_2_0_000.ToInterval(ak_);
			CqlDateTime am_ = context.Operators.Start(al_);
			CqlDate an_ = context.Operators.DateFrom(am_);
			object ao_ = FHIRHelpers_4_3_000.ToValue(tuple_itzjebebsegnifgclhjyijnb.Promis29SocialRoles?.Effective);
			CqlInterval<CqlDateTime> ap_ = QICoreCommon_2_0_000.ToInterval(ao_);
			CqlDateTime aq_ = context.Operators.Start(ap_);
			CqlDate ar_ = context.Operators.DateFrom(aq_);
			bool? as_ = context.Operators.SameAs(an_, ar_, "day");
			object at_ = FHIRHelpers_4_3_000.ToValue(tuple_itzjebebsegnifgclhjyijnb.Promis29SocialRoles?.Value);
			bool? au_ = context.Operators.Not((bool?)(at_ is null));
			bool? av_ = context.Operators.And(as_, au_);
			CqlInterval<CqlDateTime> ax_ = QICoreCommon_2_0_000.ToInterval(ak_);
			CqlDateTime ay_ = context.Operators.Start(ax_);
			CqlDate az_ = context.Operators.DateFrom(ay_);
			object ba_ = FHIRHelpers_4_3_000.ToValue(tuple_itzjebebsegnifgclhjyijnb.Promis29Physical?.Effective);
			CqlInterval<CqlDateTime> bb_ = QICoreCommon_2_0_000.ToInterval(ba_);
			CqlDateTime bc_ = context.Operators.Start(bb_);
			CqlDate bd_ = context.Operators.DateFrom(bc_);
			bool? be_ = context.Operators.SameAs(az_, bd_, "day");
			bool? bf_ = context.Operators.And(av_, be_);
			object bg_ = FHIRHelpers_4_3_000.ToValue(tuple_itzjebebsegnifgclhjyijnb.Promis29Physical?.Value);
			bool? bh_ = context.Operators.Not((bool?)(bg_ is null));
			bool? bi_ = context.Operators.And(bf_, bh_);
			CqlInterval<CqlDateTime> bk_ = QICoreCommon_2_0_000.ToInterval(ak_);
			CqlDateTime bl_ = context.Operators.Start(bk_);
			CqlDate bm_ = context.Operators.DateFrom(bl_);
			object bn_ = FHIRHelpers_4_3_000.ToValue(tuple_itzjebebsegnifgclhjyijnb.Promis29Pain?.Effective);
			CqlInterval<CqlDateTime> bo_ = QICoreCommon_2_0_000.ToInterval(bn_);
			CqlDateTime bp_ = context.Operators.Start(bo_);
			CqlDate bq_ = context.Operators.DateFrom(bp_);
			bool? br_ = context.Operators.SameAs(bm_, bq_, "day");
			bool? bs_ = context.Operators.And(bi_, br_);
			object bt_ = FHIRHelpers_4_3_000.ToValue(tuple_itzjebebsegnifgclhjyijnb.Promis29Pain?.Value);
			bool? bu_ = context.Operators.Not((bool?)(bt_ is null));
			bool? bv_ = context.Operators.And(bs_, bu_);
			CqlInterval<CqlDateTime> bx_ = QICoreCommon_2_0_000.ToInterval(ak_);
			CqlDateTime by_ = context.Operators.Start(bx_);
			CqlDate bz_ = context.Operators.DateFrom(by_);
			object ca_ = FHIRHelpers_4_3_000.ToValue(tuple_itzjebebsegnifgclhjyijnb.Promis29Fatigue?.Effective);
			CqlInterval<CqlDateTime> cb_ = QICoreCommon_2_0_000.ToInterval(ca_);
			CqlDateTime cc_ = context.Operators.Start(cb_);
			CqlDate cd_ = context.Operators.DateFrom(cc_);
			bool? ce_ = context.Operators.SameAs(bz_, cd_, "day");
			bool? cf_ = context.Operators.And(bv_, ce_);
			object cg_ = FHIRHelpers_4_3_000.ToValue(tuple_itzjebebsegnifgclhjyijnb.Promis29Fatigue?.Value);
			bool? ch_ = context.Operators.Not((bool?)(cg_ is null));
			bool? ci_ = context.Operators.And(cf_, ch_);
			CqlInterval<CqlDateTime> ck_ = QICoreCommon_2_0_000.ToInterval(ak_);
			CqlDateTime cl_ = context.Operators.Start(ck_);
			CqlDate cm_ = context.Operators.DateFrom(cl_);
			object cn_ = FHIRHelpers_4_3_000.ToValue(tuple_itzjebebsegnifgclhjyijnb.Promis29Depression?.Effective);
			CqlInterval<CqlDateTime> co_ = QICoreCommon_2_0_000.ToInterval(cn_);
			CqlDateTime cp_ = context.Operators.Start(co_);
			CqlDate cq_ = context.Operators.DateFrom(cp_);
			bool? cr_ = context.Operators.SameAs(cm_, cq_, "day");
			bool? cs_ = context.Operators.And(ci_, cr_);
			object ct_ = FHIRHelpers_4_3_000.ToValue(tuple_itzjebebsegnifgclhjyijnb.Promis29Depression?.Value);
			bool? cu_ = context.Operators.Not((bool?)(ct_ is null));
			bool? cv_ = context.Operators.And(cs_, cu_);
			CqlInterval<CqlDateTime> cx_ = QICoreCommon_2_0_000.ToInterval(ak_);
			CqlDateTime cy_ = context.Operators.Start(cx_);
			CqlDate cz_ = context.Operators.DateFrom(cy_);
			object da_ = FHIRHelpers_4_3_000.ToValue(tuple_itzjebebsegnifgclhjyijnb.Promis29Anxiety?.Effective);
			CqlInterval<CqlDateTime> db_ = QICoreCommon_2_0_000.ToInterval(da_);
			CqlDateTime dc_ = context.Operators.Start(db_);
			CqlDate dd_ = context.Operators.DateFrom(dc_);
			bool? de_ = context.Operators.SameAs(cz_, dd_, "day");
			bool? df_ = context.Operators.And(cv_, de_);
			object dg_ = FHIRHelpers_4_3_000.ToValue(tuple_itzjebebsegnifgclhjyijnb.Promis29Anxiety?.Value);
			bool? dh_ = context.Operators.Not((bool?)(dg_ is null));
			bool? di_ = context.Operators.And(df_, dh_);
			object dj_ = FHIRHelpers_4_3_000.ToValue(tuple_itzjebebsegnifgclhjyijnb.Promis29Sleep?.Value);
			bool? dk_ = context.Operators.Not((bool?)(dj_ is null));
			bool? dl_ = context.Operators.And(di_, dk_);

			return dl_;
		};
		IEnumerable<Tuple_ITZjeBeBSEgNiFGcLhJYIJNb> ag_ = context.Operators.Where<Tuple_ITZjeBeBSEgNiFGcLhJYIJNb>(ae_, af_);
		CqlDate ah_(Tuple_ITZjeBeBSEgNiFGcLhJYIJNb tuple_itzjebebsegnifgclhjyijnb)
		{
			object dm_ = FHIRHelpers_4_3_000.ToValue(tuple_itzjebebsegnifgclhjyijnb.Promis29Sleep?.Effective);
			CqlInterval<CqlDateTime> dn_ = QICoreCommon_2_0_000.ToInterval(dm_);
			CqlDateTime do_ = context.Operators.Start(dn_);
			CqlDate dp_ = context.Operators.DateFrom(do_);
			object dq_ = FHIRHelpers_4_3_000.ToValue(tuple_itzjebebsegnifgclhjyijnb.Promis29SocialRoles?.Effective);
			CqlInterval<CqlDateTime> dr_ = QICoreCommon_2_0_000.ToInterval(dq_);
			CqlDateTime ds_ = context.Operators.Start(dr_);
			CqlDate dt_ = context.Operators.DateFrom(ds_);
			object du_ = FHIRHelpers_4_3_000.ToValue(tuple_itzjebebsegnifgclhjyijnb.Promis29Physical?.Effective);
			CqlInterval<CqlDateTime> dv_ = QICoreCommon_2_0_000.ToInterval(du_);
			CqlDateTime dw_ = context.Operators.Start(dv_);
			CqlDate dx_ = context.Operators.DateFrom(dw_);
			object dy_ = FHIRHelpers_4_3_000.ToValue(tuple_itzjebebsegnifgclhjyijnb.Promis29Pain?.Effective);
			CqlInterval<CqlDateTime> dz_ = QICoreCommon_2_0_000.ToInterval(dy_);
			CqlDateTime ea_ = context.Operators.Start(dz_);
			CqlDate eb_ = context.Operators.DateFrom(ea_);
			object ec_ = FHIRHelpers_4_3_000.ToValue(tuple_itzjebebsegnifgclhjyijnb.Promis29Fatigue?.Effective);
			CqlInterval<CqlDateTime> ed_ = QICoreCommon_2_0_000.ToInterval(ec_);
			CqlDateTime ee_ = context.Operators.Start(ed_);
			CqlDate ef_ = context.Operators.DateFrom(ee_);
			object eg_ = FHIRHelpers_4_3_000.ToValue(tuple_itzjebebsegnifgclhjyijnb.Promis29Depression?.Effective);
			CqlInterval<CqlDateTime> eh_ = QICoreCommon_2_0_000.ToInterval(eg_);
			CqlDateTime ei_ = context.Operators.Start(eh_);
			CqlDate ej_ = context.Operators.DateFrom(ei_);
			object ek_ = FHIRHelpers_4_3_000.ToValue(tuple_itzjebebsegnifgclhjyijnb.Promis29Anxiety?.Effective);
			CqlInterval<CqlDateTime> el_ = QICoreCommon_2_0_000.ToInterval(ek_);
			CqlDateTime em_ = context.Operators.Start(el_);
			CqlDate en_ = context.Operators.DateFrom(em_);
			CqlDate[] eo_ = new CqlDate[]
			{
				dp_,
				dt_,
				dx_,
				eb_,
				ef_,
				ej_,
				en_,
			};
			CqlDate ep_ = context.Operators.Max<CqlDate>((eo_ as IEnumerable<CqlDate>));

			return ep_;
		};
		IEnumerable<CqlDate> ai_ = context.Operators.Select<Tuple_ITZjeBeBSEgNiFGcLhJYIJNb, CqlDate>(ag_, ah_);

		return ai_;
	}

    [CqlDeclaration("Date PROMIS29 Total Assessment Completed")]
	public IEnumerable<CqlDate> Date_PROMIS29_Total_Assessment_Completed() => 
		__Date_PROMIS29_Total_Assessment_Completed.Value;

	private bool? Has_Encounter_with_Initial_and_Follow_Up_PROMIS29_Assessments_Value()
	{
		IEnumerable<Encounter> a_ = this.Qualifying_Encounters();
		IEnumerable<CqlDate> b_ = this.Date_PROMIS29_Total_Assessment_Completed();
		IEnumerable<ValueTuple<Encounter,CqlDate,CqlDate>> d_ = context.Operators.CrossJoin<Encounter, CqlDate, CqlDate>(a_, b_, b_);
		Tuple_DcgYAFMUGiITLMLBigQTHXaba e_(ValueTuple<Encounter,CqlDate,CqlDate> _valueTuple)
		{
			Tuple_DcgYAFMUGiITLMLBigQTHXaba l_ = new Tuple_DcgYAFMUGiITLMLBigQTHXaba
			{
				ValidEncounters = _valueTuple.Item1,
				InitialPROMIS29Date = _valueTuple.Item2,
				FollowupPROMIS29Date = _valueTuple.Item3,
			};

			return l_;
		};
		IEnumerable<Tuple_DcgYAFMUGiITLMLBigQTHXaba> f_ = context.Operators.Select<ValueTuple<Encounter,CqlDate,CqlDate>, Tuple_DcgYAFMUGiITLMLBigQTHXaba>(d_, e_);
		bool? g_(Tuple_DcgYAFMUGiITLMLBigQTHXaba tuple_dcgyafmugiitlmlbigqthxaba)
		{
			CqlInterval<CqlDateTime> m_ = FHIRHelpers_4_3_000.ToInterval(tuple_dcgyafmugiitlmlbigqthxaba.ValidEncounters?.Period);
			CqlInterval<CqlDateTime> n_ = QICoreCommon_2_0_000.ToInterval((m_ as object));
			CqlDateTime o_ = context.Operators.End(n_);
			CqlInterval<CqlDateTime> p_ = this.Measurement_Period();
			CqlDateTime q_ = context.Operators.End(p_);
			CqlQuantity r_ = context.Operators.Quantity(180m, "days");
			CqlDateTime s_ = context.Operators.Subtract(q_, r_);
			bool? t_ = context.Operators.SameOrBefore(o_, s_, "day");
			CqlDateTime u_ = context.Operators.ConvertDateToDateTime(tuple_dcgyafmugiitlmlbigqthxaba.InitialPROMIS29Date);
			CqlInterval<CqlDateTime> w_ = QICoreCommon_2_0_000.ToInterval((m_ as object));
			CqlDateTime x_ = context.Operators.End(w_);
			CqlQuantity y_ = context.Operators.Quantity(14m, "days");
			CqlDateTime z_ = context.Operators.Subtract(x_, y_);
			CqlInterval<CqlDateTime> ab_ = QICoreCommon_2_0_000.ToInterval((m_ as object));
			CqlDateTime ac_ = context.Operators.End(ab_);
			CqlInterval<CqlDateTime> ad_ = context.Operators.Interval(z_, ac_, true, true);
			bool? ae_ = context.Operators.In<CqlDateTime>(u_, ad_, "day");
			CqlInterval<CqlDateTime> ag_ = QICoreCommon_2_0_000.ToInterval((m_ as object));
			CqlDateTime ah_ = context.Operators.End(ag_);
			bool? ai_ = context.Operators.Not((bool?)(ah_ is null));
			bool? aj_ = context.Operators.And(ae_, ai_);
			bool? ak_ = context.Operators.And(t_, aj_);
			CqlDateTime al_ = context.Operators.ConvertDateToDateTime(tuple_dcgyafmugiitlmlbigqthxaba.FollowupPROMIS29Date);
			CqlDate am_ = context.Operators.DateFrom(al_);
			CqlDate ao_ = context.Operators.DateFrom(u_);
			CqlQuantity ap_ = context.Operators.Quantity(30m, "days");
			CqlDate aq_ = context.Operators.Add(ao_, ap_);
			CqlDate as_ = context.Operators.DateFrom(u_);
			CqlDate au_ = context.Operators.Add(as_, r_);
			CqlInterval<CqlDate> av_ = context.Operators.Interval(aq_, au_, true, true);
			bool? aw_ = context.Operators.In<CqlDate>(am_, av_, "day");
			bool? ax_ = context.Operators.And(ak_, aw_);

			return ax_;
		};
		IEnumerable<Tuple_DcgYAFMUGiITLMLBigQTHXaba> h_ = context.Operators.Where<Tuple_DcgYAFMUGiITLMLBigQTHXaba>(f_, g_);
		Encounter i_(Tuple_DcgYAFMUGiITLMLBigQTHXaba tuple_dcgyafmugiitlmlbigqthxaba) => 
			tuple_dcgyafmugiitlmlbigqthxaba.ValidEncounters;
		IEnumerable<Encounter> j_ = context.Operators.Select<Tuple_DcgYAFMUGiITLMLBigQTHXaba, Encounter>(h_, i_);
		bool? k_ = context.Operators.Exists<Encounter>(j_);

		return k_;
	}

    [CqlDeclaration("Has Encounter with Initial and Follow Up PROMIS29 Assessments")]
	public bool? Has_Encounter_with_Initial_and_Follow_Up_PROMIS29_Assessments() => 
		__Has_Encounter_with_Initial_and_Follow_Up_PROMIS29_Assessments.Value;

	private IEnumerable<CqlDate> Date_VR12_Oblique_Total_Assessment_Completed_Value()
	{
		CqlCode a_ = this.VR_12_Mental_component_summary__MCS__score___oblique_method_T_score();
		IEnumerable<CqlCode> b_ = context.Operators.ToList<CqlCode>(a_);
		IEnumerable<Observation> c_ = context.Operators.RetrieveByCodes<Observation>(b_, null);
		IEnumerable<Observation> d_ = Status_1_6_000.Final_Survey_Observation(c_);
		CqlCode e_ = this.VR_12_Physical_component_summary__PCS__score___oblique_method_T_score();
		IEnumerable<CqlCode> f_ = context.Operators.ToList<CqlCode>(e_);
		IEnumerable<Observation> g_ = context.Operators.RetrieveByCodes<Observation>(f_, null);
		IEnumerable<Observation> h_ = Status_1_6_000.Final_Survey_Observation(g_);
		IEnumerable<ValueTuple<Observation,Observation>> i_ = context.Operators.CrossJoin<Observation, Observation>(d_, h_);
		Tuple_aWLEFJMGFWIGJKOEOKKQfQiJ j_(ValueTuple<Observation,Observation> _valueTuple)
		{
			Tuple_aWLEFJMGFWIGJKOEOKKQfQiJ p_ = new Tuple_aWLEFJMGFWIGJKOEOKKQfQiJ
			{
				VR12MentalAssessment = _valueTuple.Item1,
				VR12PhysicalAssessment = _valueTuple.Item2,
			};

			return p_;
		};
		IEnumerable<Tuple_aWLEFJMGFWIGJKOEOKKQfQiJ> k_ = context.Operators.Select<ValueTuple<Observation,Observation>, Tuple_aWLEFJMGFWIGJKOEOKKQfQiJ>(i_, j_);
		bool? l_(Tuple_aWLEFJMGFWIGJKOEOKKQfQiJ tuple_awlefjmgfwigjkoeokkqfqij)
		{
			object q_ = FHIRHelpers_4_3_000.ToValue(tuple_awlefjmgfwigjkoeokkqfqij.VR12MentalAssessment?.Effective);
			CqlInterval<CqlDateTime> r_ = QICoreCommon_2_0_000.ToInterval(q_);
			CqlDateTime s_ = context.Operators.Start(r_);
			CqlDate t_ = context.Operators.DateFrom(s_);
			object u_ = FHIRHelpers_4_3_000.ToValue(tuple_awlefjmgfwigjkoeokkqfqij.VR12PhysicalAssessment?.Effective);
			CqlInterval<CqlDateTime> v_ = QICoreCommon_2_0_000.ToInterval(u_);
			CqlDateTime w_ = context.Operators.Start(v_);
			CqlDate x_ = context.Operators.DateFrom(w_);
			bool? y_ = context.Operators.SameAs(t_, x_, "day");
			object z_ = FHIRHelpers_4_3_000.ToValue(tuple_awlefjmgfwigjkoeokkqfqij.VR12MentalAssessment?.Value);
			bool? aa_ = context.Operators.Not((bool?)(z_ is null));
			bool? ab_ = context.Operators.And(y_, aa_);
			object ac_ = FHIRHelpers_4_3_000.ToValue(tuple_awlefjmgfwigjkoeokkqfqij.VR12PhysicalAssessment?.Value);
			bool? ad_ = context.Operators.Not((bool?)(ac_ is null));
			bool? ae_ = context.Operators.And(ab_, ad_);

			return ae_;
		};
		IEnumerable<Tuple_aWLEFJMGFWIGJKOEOKKQfQiJ> m_ = context.Operators.Where<Tuple_aWLEFJMGFWIGJKOEOKKQfQiJ>(k_, l_);
		CqlDate n_(Tuple_aWLEFJMGFWIGJKOEOKKQfQiJ tuple_awlefjmgfwigjkoeokkqfqij)
		{
			object af_ = FHIRHelpers_4_3_000.ToValue(tuple_awlefjmgfwigjkoeokkqfqij.VR12MentalAssessment?.Effective);
			CqlInterval<CqlDateTime> ag_ = QICoreCommon_2_0_000.ToInterval(af_);
			CqlDateTime ah_ = context.Operators.Start(ag_);
			CqlDate ai_ = context.Operators.DateFrom(ah_);
			object aj_ = FHIRHelpers_4_3_000.ToValue(tuple_awlefjmgfwigjkoeokkqfqij.VR12PhysicalAssessment?.Effective);
			CqlInterval<CqlDateTime> ak_ = QICoreCommon_2_0_000.ToInterval(aj_);
			CqlDateTime al_ = context.Operators.Start(ak_);
			CqlDate am_ = context.Operators.DateFrom(al_);
			CqlDate[] an_ = new CqlDate[]
			{
				ai_,
				am_,
			};
			CqlDate ao_ = context.Operators.Max<CqlDate>((an_ as IEnumerable<CqlDate>));

			return ao_;
		};
		IEnumerable<CqlDate> o_ = context.Operators.Select<Tuple_aWLEFJMGFWIGJKOEOKKQfQiJ, CqlDate>(m_, n_);

		return o_;
	}

    [CqlDeclaration("Date VR12 Oblique Total Assessment Completed")]
	public IEnumerable<CqlDate> Date_VR12_Oblique_Total_Assessment_Completed() => 
		__Date_VR12_Oblique_Total_Assessment_Completed.Value;

	private bool? Has_Encounter_with_Initial_and_Follow_Up_VR12_Oblique_Assessments_Value()
	{
		IEnumerable<Encounter> a_ = this.Qualifying_Encounters();
		IEnumerable<CqlDate> b_ = this.Date_VR12_Oblique_Total_Assessment_Completed();
		IEnumerable<ValueTuple<Encounter,CqlDate,CqlDate>> d_ = context.Operators.CrossJoin<Encounter, CqlDate, CqlDate>(a_, b_, b_);
		Tuple_EhGfQcQTPMaVGfjeRNgbDIGOU e_(ValueTuple<Encounter,CqlDate,CqlDate> _valueTuple)
		{
			Tuple_EhGfQcQTPMaVGfjeRNgbDIGOU l_ = new Tuple_EhGfQcQTPMaVGfjeRNgbDIGOU
			{
				ValidEncounters = _valueTuple.Item1,
				InitialVR12ObliqueDate = _valueTuple.Item2,
				FollowupVR12ObliqueDate = _valueTuple.Item3,
			};

			return l_;
		};
		IEnumerable<Tuple_EhGfQcQTPMaVGfjeRNgbDIGOU> f_ = context.Operators.Select<ValueTuple<Encounter,CqlDate,CqlDate>, Tuple_EhGfQcQTPMaVGfjeRNgbDIGOU>(d_, e_);
		bool? g_(Tuple_EhGfQcQTPMaVGfjeRNgbDIGOU tuple_ehgfqcqtpmavgfjerngbdigou)
		{
			CqlInterval<CqlDateTime> m_ = FHIRHelpers_4_3_000.ToInterval(tuple_ehgfqcqtpmavgfjerngbdigou.ValidEncounters?.Period);
			CqlInterval<CqlDateTime> n_ = QICoreCommon_2_0_000.ToInterval((m_ as object));
			CqlDateTime o_ = context.Operators.End(n_);
			CqlInterval<CqlDateTime> p_ = this.Measurement_Period();
			CqlDateTime q_ = context.Operators.End(p_);
			CqlQuantity r_ = context.Operators.Quantity(180m, "days");
			CqlDateTime s_ = context.Operators.Subtract(q_, r_);
			bool? t_ = context.Operators.SameOrBefore(o_, s_, "day");
			CqlDateTime u_ = context.Operators.ConvertDateToDateTime(tuple_ehgfqcqtpmavgfjerngbdigou.InitialVR12ObliqueDate);
			CqlInterval<CqlDateTime> w_ = QICoreCommon_2_0_000.ToInterval((m_ as object));
			CqlDateTime x_ = context.Operators.End(w_);
			CqlQuantity y_ = context.Operators.Quantity(14m, "days");
			CqlDateTime z_ = context.Operators.Subtract(x_, y_);
			CqlInterval<CqlDateTime> ab_ = QICoreCommon_2_0_000.ToInterval((m_ as object));
			CqlDateTime ac_ = context.Operators.End(ab_);
			CqlInterval<CqlDateTime> ad_ = context.Operators.Interval(z_, ac_, true, true);
			bool? ae_ = context.Operators.In<CqlDateTime>(u_, ad_, "day");
			CqlInterval<CqlDateTime> ag_ = QICoreCommon_2_0_000.ToInterval((m_ as object));
			CqlDateTime ah_ = context.Operators.End(ag_);
			bool? ai_ = context.Operators.Not((bool?)(ah_ is null));
			bool? aj_ = context.Operators.And(ae_, ai_);
			bool? ak_ = context.Operators.And(t_, aj_);
			CqlDateTime al_ = context.Operators.ConvertDateToDateTime(tuple_ehgfqcqtpmavgfjerngbdigou.FollowupVR12ObliqueDate);
			CqlDate am_ = context.Operators.DateFrom(al_);
			CqlDate ao_ = context.Operators.DateFrom(u_);
			CqlQuantity ap_ = context.Operators.Quantity(30m, "days");
			CqlDate aq_ = context.Operators.Add(ao_, ap_);
			CqlDate as_ = context.Operators.DateFrom(u_);
			CqlDate au_ = context.Operators.Add(as_, r_);
			CqlInterval<CqlDate> av_ = context.Operators.Interval(aq_, au_, true, true);
			bool? aw_ = context.Operators.In<CqlDate>(am_, av_, "day");
			bool? ax_ = context.Operators.And(ak_, aw_);

			return ax_;
		};
		IEnumerable<Tuple_EhGfQcQTPMaVGfjeRNgbDIGOU> h_ = context.Operators.Where<Tuple_EhGfQcQTPMaVGfjeRNgbDIGOU>(f_, g_);
		Encounter i_(Tuple_EhGfQcQTPMaVGfjeRNgbDIGOU tuple_ehgfqcqtpmavgfjerngbdigou) => 
			tuple_ehgfqcqtpmavgfjerngbdigou.ValidEncounters;
		IEnumerable<Encounter> j_ = context.Operators.Select<Tuple_EhGfQcQTPMaVGfjeRNgbDIGOU, Encounter>(h_, i_);
		bool? k_ = context.Operators.Exists<Encounter>(j_);

		return k_;
	}

    [CqlDeclaration("Has Encounter with Initial and Follow Up VR12 Oblique Assessments")]
	public bool? Has_Encounter_with_Initial_and_Follow_Up_VR12_Oblique_Assessments() => 
		__Has_Encounter_with_Initial_and_Follow_Up_VR12_Oblique_Assessments.Value;

	private IEnumerable<CqlDate> Date_VR12_Orthogonal_Total_Assessment_Completed_Value()
	{
		CqlCode a_ = this.VR_12_Mental_component_summary__MCS__score___orthogonal_method_T_score();
		IEnumerable<CqlCode> b_ = context.Operators.ToList<CqlCode>(a_);
		IEnumerable<Observation> c_ = context.Operators.RetrieveByCodes<Observation>(b_, null);
		IEnumerable<Observation> d_ = Status_1_6_000.Final_Survey_Observation(c_);
		CqlCode e_ = this.VR_12_Physical_component_summary__PCS__score___orthogonal_method_T_score();
		IEnumerable<CqlCode> f_ = context.Operators.ToList<CqlCode>(e_);
		IEnumerable<Observation> g_ = context.Operators.RetrieveByCodes<Observation>(f_, null);
		IEnumerable<Observation> h_ = Status_1_6_000.Final_Survey_Observation(g_);
		IEnumerable<ValueTuple<Observation,Observation>> i_ = context.Operators.CrossJoin<Observation, Observation>(d_, h_);
		Tuple_aWLEFJMGFWIGJKOEOKKQfQiJ j_(ValueTuple<Observation,Observation> _valueTuple)
		{
			Tuple_aWLEFJMGFWIGJKOEOKKQfQiJ p_ = new Tuple_aWLEFJMGFWIGJKOEOKKQfQiJ
			{
				VR12MentalAssessment = _valueTuple.Item1,
				VR12PhysicalAssessment = _valueTuple.Item2,
			};

			return p_;
		};
		IEnumerable<Tuple_aWLEFJMGFWIGJKOEOKKQfQiJ> k_ = context.Operators.Select<ValueTuple<Observation,Observation>, Tuple_aWLEFJMGFWIGJKOEOKKQfQiJ>(i_, j_);
		bool? l_(Tuple_aWLEFJMGFWIGJKOEOKKQfQiJ tuple_awlefjmgfwigjkoeokkqfqij)
		{
			object q_ = FHIRHelpers_4_3_000.ToValue(tuple_awlefjmgfwigjkoeokkqfqij.VR12MentalAssessment?.Effective);
			CqlInterval<CqlDateTime> r_ = QICoreCommon_2_0_000.ToInterval(q_);
			CqlDateTime s_ = context.Operators.Start(r_);
			CqlDate t_ = context.Operators.DateFrom(s_);
			object u_ = FHIRHelpers_4_3_000.ToValue(tuple_awlefjmgfwigjkoeokkqfqij.VR12PhysicalAssessment?.Effective);
			CqlInterval<CqlDateTime> v_ = QICoreCommon_2_0_000.ToInterval(u_);
			CqlDateTime w_ = context.Operators.Start(v_);
			CqlDate x_ = context.Operators.DateFrom(w_);
			bool? y_ = context.Operators.SameAs(t_, x_, "day");
			object z_ = FHIRHelpers_4_3_000.ToValue(tuple_awlefjmgfwigjkoeokkqfqij.VR12MentalAssessment?.Value);
			bool? aa_ = context.Operators.Not((bool?)(z_ is null));
			bool? ab_ = context.Operators.And(y_, aa_);
			object ac_ = FHIRHelpers_4_3_000.ToValue(tuple_awlefjmgfwigjkoeokkqfqij.VR12PhysicalAssessment?.Value);
			bool? ad_ = context.Operators.Not((bool?)(ac_ is null));
			bool? ae_ = context.Operators.And(ab_, ad_);

			return ae_;
		};
		IEnumerable<Tuple_aWLEFJMGFWIGJKOEOKKQfQiJ> m_ = context.Operators.Where<Tuple_aWLEFJMGFWIGJKOEOKKQfQiJ>(k_, l_);
		CqlDate n_(Tuple_aWLEFJMGFWIGJKOEOKKQfQiJ tuple_awlefjmgfwigjkoeokkqfqij)
		{
			object af_ = FHIRHelpers_4_3_000.ToValue(tuple_awlefjmgfwigjkoeokkqfqij.VR12MentalAssessment?.Effective);
			CqlInterval<CqlDateTime> ag_ = QICoreCommon_2_0_000.ToInterval(af_);
			CqlDateTime ah_ = context.Operators.Start(ag_);
			CqlDate ai_ = context.Operators.DateFrom(ah_);
			object aj_ = FHIRHelpers_4_3_000.ToValue(tuple_awlefjmgfwigjkoeokkqfqij.VR12PhysicalAssessment?.Effective);
			CqlInterval<CqlDateTime> ak_ = QICoreCommon_2_0_000.ToInterval(aj_);
			CqlDateTime al_ = context.Operators.Start(ak_);
			CqlDate am_ = context.Operators.DateFrom(al_);
			CqlDate[] an_ = new CqlDate[]
			{
				ai_,
				am_,
			};
			CqlDate ao_ = context.Operators.Max<CqlDate>((an_ as IEnumerable<CqlDate>));

			return ao_;
		};
		IEnumerable<CqlDate> o_ = context.Operators.Select<Tuple_aWLEFJMGFWIGJKOEOKKQfQiJ, CqlDate>(m_, n_);

		return o_;
	}

    [CqlDeclaration("Date VR12 Orthogonal Total Assessment Completed")]
	public IEnumerable<CqlDate> Date_VR12_Orthogonal_Total_Assessment_Completed() => 
		__Date_VR12_Orthogonal_Total_Assessment_Completed.Value;

	private bool? Has_Encounter_with_Initial_and_Follow_Up_VR12_Orthogonal_Assessments_Value()
	{
		IEnumerable<Encounter> a_ = this.Qualifying_Encounters();
		IEnumerable<CqlDate> b_ = this.Date_VR12_Orthogonal_Total_Assessment_Completed();
		IEnumerable<ValueTuple<Encounter,CqlDate,CqlDate>> d_ = context.Operators.CrossJoin<Encounter, CqlDate, CqlDate>(a_, b_, b_);
		Tuple_DaTHNXWGHIVRYGRfGdXJYJKRZ e_(ValueTuple<Encounter,CqlDate,CqlDate> _valueTuple)
		{
			Tuple_DaTHNXWGHIVRYGRfGdXJYJKRZ l_ = new Tuple_DaTHNXWGHIVRYGRfGdXJYJKRZ
			{
				ValidEncounters = _valueTuple.Item1,
				InitialVR12OrthogonalDate = _valueTuple.Item2,
				FollowupVR12OrthogonalDate = _valueTuple.Item3,
			};

			return l_;
		};
		IEnumerable<Tuple_DaTHNXWGHIVRYGRfGdXJYJKRZ> f_ = context.Operators.Select<ValueTuple<Encounter,CqlDate,CqlDate>, Tuple_DaTHNXWGHIVRYGRfGdXJYJKRZ>(d_, e_);
		bool? g_(Tuple_DaTHNXWGHIVRYGRfGdXJYJKRZ tuple_dathnxwghivrygrfgdxjyjkrz)
		{
			CqlInterval<CqlDateTime> m_ = FHIRHelpers_4_3_000.ToInterval(tuple_dathnxwghivrygrfgdxjyjkrz.ValidEncounters?.Period);
			CqlInterval<CqlDateTime> n_ = QICoreCommon_2_0_000.ToInterval((m_ as object));
			CqlDateTime o_ = context.Operators.End(n_);
			CqlInterval<CqlDateTime> p_ = this.Measurement_Period();
			CqlDateTime q_ = context.Operators.End(p_);
			CqlQuantity r_ = context.Operators.Quantity(180m, "days");
			CqlDateTime s_ = context.Operators.Subtract(q_, r_);
			bool? t_ = context.Operators.SameOrBefore(o_, s_, "day");
			CqlDateTime u_ = context.Operators.ConvertDateToDateTime(tuple_dathnxwghivrygrfgdxjyjkrz.InitialVR12OrthogonalDate);
			CqlInterval<CqlDateTime> w_ = QICoreCommon_2_0_000.ToInterval((m_ as object));
			CqlDateTime x_ = context.Operators.End(w_);
			CqlQuantity y_ = context.Operators.Quantity(14m, "days");
			CqlDateTime z_ = context.Operators.Subtract(x_, y_);
			CqlInterval<CqlDateTime> ab_ = QICoreCommon_2_0_000.ToInterval((m_ as object));
			CqlDateTime ac_ = context.Operators.End(ab_);
			CqlInterval<CqlDateTime> ad_ = context.Operators.Interval(z_, ac_, true, true);
			bool? ae_ = context.Operators.In<CqlDateTime>(u_, ad_, "day");
			CqlInterval<CqlDateTime> ag_ = QICoreCommon_2_0_000.ToInterval((m_ as object));
			CqlDateTime ah_ = context.Operators.End(ag_);
			bool? ai_ = context.Operators.Not((bool?)(ah_ is null));
			bool? aj_ = context.Operators.And(ae_, ai_);
			bool? ak_ = context.Operators.And(t_, aj_);
			CqlDateTime al_ = context.Operators.ConvertDateToDateTime(tuple_dathnxwghivrygrfgdxjyjkrz.FollowupVR12OrthogonalDate);
			CqlDate am_ = context.Operators.DateFrom(al_);
			CqlDate ao_ = context.Operators.DateFrom(u_);
			CqlQuantity ap_ = context.Operators.Quantity(30m, "days");
			CqlDate aq_ = context.Operators.Add(ao_, ap_);
			CqlDate as_ = context.Operators.DateFrom(u_);
			CqlDate au_ = context.Operators.Add(as_, r_);
			CqlInterval<CqlDate> av_ = context.Operators.Interval(aq_, au_, true, true);
			bool? aw_ = context.Operators.In<CqlDate>(am_, av_, "day");
			bool? ax_ = context.Operators.And(ak_, aw_);

			return ax_;
		};
		IEnumerable<Tuple_DaTHNXWGHIVRYGRfGdXJYJKRZ> h_ = context.Operators.Where<Tuple_DaTHNXWGHIVRYGRfGdXJYJKRZ>(f_, g_);
		Encounter i_(Tuple_DaTHNXWGHIVRYGRfGdXJYJKRZ tuple_dathnxwghivrygrfgdxjyjkrz) => 
			tuple_dathnxwghivrygrfgdxjyjkrz.ValidEncounters;
		IEnumerable<Encounter> j_ = context.Operators.Select<Tuple_DaTHNXWGHIVRYGRfGdXJYJKRZ, Encounter>(h_, i_);
		bool? k_ = context.Operators.Exists<Encounter>(j_);

		return k_;
	}

    [CqlDeclaration("Has Encounter with Initial and Follow Up VR12 Orthogonal Assessments")]
	public bool? Has_Encounter_with_Initial_and_Follow_Up_VR12_Orthogonal_Assessments() => 
		__Has_Encounter_with_Initial_and_Follow_Up_VR12_Orthogonal_Assessments.Value;

	private IEnumerable<CqlDate> Date_VR36_Oblique_Total_Assessment_Completed_Value()
	{
		CqlCode a_ = this.VR_36_Mental_component_summary__MCS__score___oblique_method_T_score();
		IEnumerable<CqlCode> b_ = context.Operators.ToList<CqlCode>(a_);
		IEnumerable<Observation> c_ = context.Operators.RetrieveByCodes<Observation>(b_, null);
		IEnumerable<Observation> d_ = Status_1_6_000.Final_Survey_Observation(c_);
		CqlCode e_ = this.VR_36_Physical_component_summary__PCS__score___oblique_method_T_score();
		IEnumerable<CqlCode> f_ = context.Operators.ToList<CqlCode>(e_);
		IEnumerable<Observation> g_ = context.Operators.RetrieveByCodes<Observation>(f_, null);
		IEnumerable<Observation> h_ = Status_1_6_000.Final_Survey_Observation(g_);
		IEnumerable<ValueTuple<Observation,Observation>> i_ = context.Operators.CrossJoin<Observation, Observation>(d_, h_);
		Tuple_EbSJTAdMHbBibBKjAIBeBhcjh j_(ValueTuple<Observation,Observation> _valueTuple)
		{
			Tuple_EbSJTAdMHbBibBKjAIBeBhcjh p_ = new Tuple_EbSJTAdMHbBibBKjAIBeBhcjh
			{
				VR36MentalAssessment = _valueTuple.Item1,
				VR36PhysicalAssessment = _valueTuple.Item2,
			};

			return p_;
		};
		IEnumerable<Tuple_EbSJTAdMHbBibBKjAIBeBhcjh> k_ = context.Operators.Select<ValueTuple<Observation,Observation>, Tuple_EbSJTAdMHbBibBKjAIBeBhcjh>(i_, j_);
		bool? l_(Tuple_EbSJTAdMHbBibBKjAIBeBhcjh tuple_ebsjtadmhbbibbkjaibebhcjh)
		{
			object q_ = FHIRHelpers_4_3_000.ToValue(tuple_ebsjtadmhbbibbkjaibebhcjh.VR36MentalAssessment?.Effective);
			CqlInterval<CqlDateTime> r_ = QICoreCommon_2_0_000.ToInterval(q_);
			CqlDateTime s_ = context.Operators.Start(r_);
			CqlDate t_ = context.Operators.DateFrom(s_);
			object u_ = FHIRHelpers_4_3_000.ToValue(tuple_ebsjtadmhbbibbkjaibebhcjh.VR36PhysicalAssessment?.Effective);
			CqlInterval<CqlDateTime> v_ = QICoreCommon_2_0_000.ToInterval(u_);
			CqlDateTime w_ = context.Operators.Start(v_);
			CqlDate x_ = context.Operators.DateFrom(w_);
			bool? y_ = context.Operators.SameAs(t_, x_, "day");
			object z_ = FHIRHelpers_4_3_000.ToValue(tuple_ebsjtadmhbbibbkjaibebhcjh.VR36MentalAssessment?.Value);
			bool? aa_ = context.Operators.Not((bool?)(z_ is null));
			bool? ab_ = context.Operators.And(y_, aa_);
			object ac_ = FHIRHelpers_4_3_000.ToValue(tuple_ebsjtadmhbbibbkjaibebhcjh.VR36PhysicalAssessment?.Value);
			bool? ad_ = context.Operators.Not((bool?)(ac_ is null));
			bool? ae_ = context.Operators.And(ab_, ad_);

			return ae_;
		};
		IEnumerable<Tuple_EbSJTAdMHbBibBKjAIBeBhcjh> m_ = context.Operators.Where<Tuple_EbSJTAdMHbBibBKjAIBeBhcjh>(k_, l_);
		CqlDate n_(Tuple_EbSJTAdMHbBibBKjAIBeBhcjh tuple_ebsjtadmhbbibbkjaibebhcjh)
		{
			object af_ = FHIRHelpers_4_3_000.ToValue(tuple_ebsjtadmhbbibbkjaibebhcjh.VR36MentalAssessment?.Effective);
			CqlInterval<CqlDateTime> ag_ = QICoreCommon_2_0_000.ToInterval(af_);
			CqlDateTime ah_ = context.Operators.Start(ag_);
			CqlDate ai_ = context.Operators.DateFrom(ah_);
			object aj_ = FHIRHelpers_4_3_000.ToValue(tuple_ebsjtadmhbbibbkjaibebhcjh.VR36PhysicalAssessment?.Effective);
			CqlInterval<CqlDateTime> ak_ = QICoreCommon_2_0_000.ToInterval(aj_);
			CqlDateTime al_ = context.Operators.Start(ak_);
			CqlDate am_ = context.Operators.DateFrom(al_);
			CqlDate[] an_ = new CqlDate[]
			{
				ai_,
				am_,
			};
			CqlDate ao_ = context.Operators.Max<CqlDate>((an_ as IEnumerable<CqlDate>));

			return ao_;
		};
		IEnumerable<CqlDate> o_ = context.Operators.Select<Tuple_EbSJTAdMHbBibBKjAIBeBhcjh, CqlDate>(m_, n_);

		return o_;
	}

    [CqlDeclaration("Date VR36 Oblique Total Assessment Completed")]
	public IEnumerable<CqlDate> Date_VR36_Oblique_Total_Assessment_Completed() => 
		__Date_VR36_Oblique_Total_Assessment_Completed.Value;

	private bool? Has_Encounter_with_Initial_and_Follow_Up_VR36_Oblique_Assessments_Value()
	{
		IEnumerable<Encounter> a_ = this.Qualifying_Encounters();
		IEnumerable<CqlDate> b_ = this.Date_VR36_Oblique_Total_Assessment_Completed();
		IEnumerable<ValueTuple<Encounter,CqlDate,CqlDate>> d_ = context.Operators.CrossJoin<Encounter, CqlDate, CqlDate>(a_, b_, b_);
		Tuple_HNUZSEJfeiQXIhXGUDXLiWidi e_(ValueTuple<Encounter,CqlDate,CqlDate> _valueTuple)
		{
			Tuple_HNUZSEJfeiQXIhXGUDXLiWidi l_ = new Tuple_HNUZSEJfeiQXIhXGUDXLiWidi
			{
				ValidEncounters = _valueTuple.Item1,
				InitialVR36ObliqueDate = _valueTuple.Item2,
				FollowupVR36ObliqueDate = _valueTuple.Item3,
			};

			return l_;
		};
		IEnumerable<Tuple_HNUZSEJfeiQXIhXGUDXLiWidi> f_ = context.Operators.Select<ValueTuple<Encounter,CqlDate,CqlDate>, Tuple_HNUZSEJfeiQXIhXGUDXLiWidi>(d_, e_);
		bool? g_(Tuple_HNUZSEJfeiQXIhXGUDXLiWidi tuple_hnuzsejfeiqxihxgudxliwidi)
		{
			CqlInterval<CqlDateTime> m_ = FHIRHelpers_4_3_000.ToInterval(tuple_hnuzsejfeiqxihxgudxliwidi.ValidEncounters?.Period);
			CqlInterval<CqlDateTime> n_ = QICoreCommon_2_0_000.ToInterval((m_ as object));
			CqlDateTime o_ = context.Operators.End(n_);
			CqlInterval<CqlDateTime> p_ = this.Measurement_Period();
			CqlDateTime q_ = context.Operators.End(p_);
			CqlQuantity r_ = context.Operators.Quantity(180m, "days");
			CqlDateTime s_ = context.Operators.Subtract(q_, r_);
			bool? t_ = context.Operators.SameOrBefore(o_, s_, "day");
			CqlDateTime u_ = context.Operators.ConvertDateToDateTime(tuple_hnuzsejfeiqxihxgudxliwidi.InitialVR36ObliqueDate);
			CqlInterval<CqlDateTime> w_ = QICoreCommon_2_0_000.ToInterval((m_ as object));
			CqlDateTime x_ = context.Operators.End(w_);
			CqlQuantity y_ = context.Operators.Quantity(14m, "days");
			CqlDateTime z_ = context.Operators.Subtract(x_, y_);
			CqlInterval<CqlDateTime> ab_ = QICoreCommon_2_0_000.ToInterval((m_ as object));
			CqlDateTime ac_ = context.Operators.End(ab_);
			CqlInterval<CqlDateTime> ad_ = context.Operators.Interval(z_, ac_, true, true);
			bool? ae_ = context.Operators.In<CqlDateTime>(u_, ad_, "day");
			CqlInterval<CqlDateTime> ag_ = QICoreCommon_2_0_000.ToInterval((m_ as object));
			CqlDateTime ah_ = context.Operators.End(ag_);
			bool? ai_ = context.Operators.Not((bool?)(ah_ is null));
			bool? aj_ = context.Operators.And(ae_, ai_);
			bool? ak_ = context.Operators.And(t_, aj_);
			CqlDateTime al_ = context.Operators.ConvertDateToDateTime(tuple_hnuzsejfeiqxihxgudxliwidi.FollowupVR36ObliqueDate);
			CqlDate am_ = context.Operators.DateFrom(al_);
			CqlDate ao_ = context.Operators.DateFrom(u_);
			CqlQuantity ap_ = context.Operators.Quantity(30m, "days");
			CqlDate aq_ = context.Operators.Add(ao_, ap_);
			CqlDate as_ = context.Operators.DateFrom(u_);
			CqlDate au_ = context.Operators.Add(as_, r_);
			CqlInterval<CqlDate> av_ = context.Operators.Interval(aq_, au_, true, true);
			bool? aw_ = context.Operators.In<CqlDate>(am_, av_, "day");
			bool? ax_ = context.Operators.And(ak_, aw_);

			return ax_;
		};
		IEnumerable<Tuple_HNUZSEJfeiQXIhXGUDXLiWidi> h_ = context.Operators.Where<Tuple_HNUZSEJfeiQXIhXGUDXLiWidi>(f_, g_);
		Encounter i_(Tuple_HNUZSEJfeiQXIhXGUDXLiWidi tuple_hnuzsejfeiqxihxgudxliwidi) => 
			tuple_hnuzsejfeiqxihxgudxliwidi.ValidEncounters;
		IEnumerable<Encounter> j_ = context.Operators.Select<Tuple_HNUZSEJfeiQXIhXGUDXLiWidi, Encounter>(h_, i_);
		bool? k_ = context.Operators.Exists<Encounter>(j_);

		return k_;
	}

    [CqlDeclaration("Has Encounter with Initial and Follow Up VR36 Oblique Assessments")]
	public bool? Has_Encounter_with_Initial_and_Follow_Up_VR36_Oblique_Assessments() => 
		__Has_Encounter_with_Initial_and_Follow_Up_VR36_Oblique_Assessments.Value;

	private IEnumerable<CqlDate> Date_VR36_Orthogonal_Total_Assessment_Completed_Value()
	{
		CqlCode a_ = this.VR_36_Mental_component_summary__MCS__score___orthogonal_method_T_score();
		IEnumerable<CqlCode> b_ = context.Operators.ToList<CqlCode>(a_);
		IEnumerable<Observation> c_ = context.Operators.RetrieveByCodes<Observation>(b_, null);
		IEnumerable<Observation> d_ = Status_1_6_000.Final_Survey_Observation(c_);
		CqlCode e_ = this.VR_36_Physical_component_summary__PCS__score___orthogonal_method_T_score();
		IEnumerable<CqlCode> f_ = context.Operators.ToList<CqlCode>(e_);
		IEnumerable<Observation> g_ = context.Operators.RetrieveByCodes<Observation>(f_, null);
		IEnumerable<Observation> h_ = Status_1_6_000.Final_Survey_Observation(g_);
		IEnumerable<ValueTuple<Observation,Observation>> i_ = context.Operators.CrossJoin<Observation, Observation>(d_, h_);
		Tuple_EbSJTAdMHbBibBKjAIBeBhcjh j_(ValueTuple<Observation,Observation> _valueTuple)
		{
			Tuple_EbSJTAdMHbBibBKjAIBeBhcjh p_ = new Tuple_EbSJTAdMHbBibBKjAIBeBhcjh
			{
				VR36MentalAssessment = _valueTuple.Item1,
				VR36PhysicalAssessment = _valueTuple.Item2,
			};

			return p_;
		};
		IEnumerable<Tuple_EbSJTAdMHbBibBKjAIBeBhcjh> k_ = context.Operators.Select<ValueTuple<Observation,Observation>, Tuple_EbSJTAdMHbBibBKjAIBeBhcjh>(i_, j_);
		bool? l_(Tuple_EbSJTAdMHbBibBKjAIBeBhcjh tuple_ebsjtadmhbbibbkjaibebhcjh)
		{
			object q_ = FHIRHelpers_4_3_000.ToValue(tuple_ebsjtadmhbbibbkjaibebhcjh.VR36MentalAssessment?.Effective);
			CqlInterval<CqlDateTime> r_ = QICoreCommon_2_0_000.ToInterval(q_);
			CqlDateTime s_ = context.Operators.Start(r_);
			CqlDate t_ = context.Operators.DateFrom(s_);
			object u_ = FHIRHelpers_4_3_000.ToValue(tuple_ebsjtadmhbbibbkjaibebhcjh.VR36PhysicalAssessment?.Effective);
			CqlInterval<CqlDateTime> v_ = QICoreCommon_2_0_000.ToInterval(u_);
			CqlDateTime w_ = context.Operators.Start(v_);
			CqlDate x_ = context.Operators.DateFrom(w_);
			bool? y_ = context.Operators.SameAs(t_, x_, "day");
			object z_ = FHIRHelpers_4_3_000.ToValue(tuple_ebsjtadmhbbibbkjaibebhcjh.VR36MentalAssessment?.Value);
			bool? aa_ = context.Operators.Not((bool?)(z_ is null));
			bool? ab_ = context.Operators.And(y_, aa_);
			object ac_ = FHIRHelpers_4_3_000.ToValue(tuple_ebsjtadmhbbibbkjaibebhcjh.VR36PhysicalAssessment?.Value);
			bool? ad_ = context.Operators.Not((bool?)(ac_ is null));
			bool? ae_ = context.Operators.And(ab_, ad_);

			return ae_;
		};
		IEnumerable<Tuple_EbSJTAdMHbBibBKjAIBeBhcjh> m_ = context.Operators.Where<Tuple_EbSJTAdMHbBibBKjAIBeBhcjh>(k_, l_);
		CqlDate n_(Tuple_EbSJTAdMHbBibBKjAIBeBhcjh tuple_ebsjtadmhbbibbkjaibebhcjh)
		{
			object af_ = FHIRHelpers_4_3_000.ToValue(tuple_ebsjtadmhbbibbkjaibebhcjh.VR36MentalAssessment?.Effective);
			CqlInterval<CqlDateTime> ag_ = QICoreCommon_2_0_000.ToInterval(af_);
			CqlDateTime ah_ = context.Operators.Start(ag_);
			CqlDate ai_ = context.Operators.DateFrom(ah_);
			object aj_ = FHIRHelpers_4_3_000.ToValue(tuple_ebsjtadmhbbibbkjaibebhcjh.VR36PhysicalAssessment?.Effective);
			CqlInterval<CqlDateTime> ak_ = QICoreCommon_2_0_000.ToInterval(aj_);
			CqlDateTime al_ = context.Operators.Start(ak_);
			CqlDate am_ = context.Operators.DateFrom(al_);
			CqlDate[] an_ = new CqlDate[]
			{
				ai_,
				am_,
			};
			CqlDate ao_ = context.Operators.Max<CqlDate>((an_ as IEnumerable<CqlDate>));

			return ao_;
		};
		IEnumerable<CqlDate> o_ = context.Operators.Select<Tuple_EbSJTAdMHbBibBKjAIBeBhcjh, CqlDate>(m_, n_);

		return o_;
	}

    [CqlDeclaration("Date VR36 Orthogonal Total Assessment Completed")]
	public IEnumerable<CqlDate> Date_VR36_Orthogonal_Total_Assessment_Completed() => 
		__Date_VR36_Orthogonal_Total_Assessment_Completed.Value;

	private bool? Has_Encounter_with_Initial_and_Follow_Up_VR36_Orthogonal_Assessments_Value()
	{
		IEnumerable<Encounter> a_ = this.Qualifying_Encounters();
		IEnumerable<CqlDate> b_ = this.Date_VR36_Orthogonal_Total_Assessment_Completed();
		IEnumerable<ValueTuple<Encounter,CqlDate,CqlDate>> d_ = context.Operators.CrossJoin<Encounter, CqlDate, CqlDate>(a_, b_, b_);
		Tuple_FZFeLiXHKPLAfNDgWDMeScIDi e_(ValueTuple<Encounter,CqlDate,CqlDate> _valueTuple)
		{
			Tuple_FZFeLiXHKPLAfNDgWDMeScIDi l_ = new Tuple_FZFeLiXHKPLAfNDgWDMeScIDi
			{
				ValidEncounters = _valueTuple.Item1,
				InitialVR36OrthogonalDate = _valueTuple.Item2,
				FollowupVR36OrthogonalDate = _valueTuple.Item3,
			};

			return l_;
		};
		IEnumerable<Tuple_FZFeLiXHKPLAfNDgWDMeScIDi> f_ = context.Operators.Select<ValueTuple<Encounter,CqlDate,CqlDate>, Tuple_FZFeLiXHKPLAfNDgWDMeScIDi>(d_, e_);
		bool? g_(Tuple_FZFeLiXHKPLAfNDgWDMeScIDi tuple_fzfelixhkplafndgwdmescidi)
		{
			CqlInterval<CqlDateTime> m_ = FHIRHelpers_4_3_000.ToInterval(tuple_fzfelixhkplafndgwdmescidi.ValidEncounters?.Period);
			CqlInterval<CqlDateTime> n_ = QICoreCommon_2_0_000.ToInterval((m_ as object));
			CqlDateTime o_ = context.Operators.End(n_);
			CqlInterval<CqlDateTime> p_ = this.Measurement_Period();
			CqlDateTime q_ = context.Operators.End(p_);
			CqlQuantity r_ = context.Operators.Quantity(180m, "days");
			CqlDateTime s_ = context.Operators.Subtract(q_, r_);
			bool? t_ = context.Operators.SameOrBefore(o_, s_, "day");
			CqlDateTime u_ = context.Operators.ConvertDateToDateTime(tuple_fzfelixhkplafndgwdmescidi.InitialVR36OrthogonalDate);
			CqlInterval<CqlDateTime> w_ = QICoreCommon_2_0_000.ToInterval((m_ as object));
			CqlDateTime x_ = context.Operators.End(w_);
			CqlQuantity y_ = context.Operators.Quantity(14m, "days");
			CqlDateTime z_ = context.Operators.Subtract(x_, y_);
			CqlInterval<CqlDateTime> ab_ = QICoreCommon_2_0_000.ToInterval((m_ as object));
			CqlDateTime ac_ = context.Operators.End(ab_);
			CqlInterval<CqlDateTime> ad_ = context.Operators.Interval(z_, ac_, true, true);
			bool? ae_ = context.Operators.In<CqlDateTime>(u_, ad_, "day");
			CqlInterval<CqlDateTime> ag_ = QICoreCommon_2_0_000.ToInterval((m_ as object));
			CqlDateTime ah_ = context.Operators.End(ag_);
			bool? ai_ = context.Operators.Not((bool?)(ah_ is null));
			bool? aj_ = context.Operators.And(ae_, ai_);
			bool? ak_ = context.Operators.And(t_, aj_);
			CqlDateTime al_ = context.Operators.ConvertDateToDateTime(tuple_fzfelixhkplafndgwdmescidi.FollowupVR36OrthogonalDate);
			CqlDate am_ = context.Operators.DateFrom(al_);
			CqlDate ao_ = context.Operators.DateFrom(u_);
			CqlQuantity ap_ = context.Operators.Quantity(30m, "days");
			CqlDate aq_ = context.Operators.Add(ao_, ap_);
			CqlDate as_ = context.Operators.DateFrom(u_);
			CqlDate au_ = context.Operators.Add(as_, r_);
			CqlInterval<CqlDate> av_ = context.Operators.Interval(aq_, au_, true, true);
			bool? aw_ = context.Operators.In<CqlDate>(am_, av_, "day");
			bool? ax_ = context.Operators.And(ak_, aw_);

			return ax_;
		};
		IEnumerable<Tuple_FZFeLiXHKPLAfNDgWDMeScIDi> h_ = context.Operators.Where<Tuple_FZFeLiXHKPLAfNDgWDMeScIDi>(f_, g_);
		Encounter i_(Tuple_FZFeLiXHKPLAfNDgWDMeScIDi tuple_fzfelixhkplafndgwdmescidi) => 
			tuple_fzfelixhkplafndgwdmescidi.ValidEncounters;
		IEnumerable<Encounter> j_ = context.Operators.Select<Tuple_FZFeLiXHKPLAfNDgWDMeScIDi, Encounter>(h_, i_);
		bool? k_ = context.Operators.Exists<Encounter>(j_);

		return k_;
	}

    [CqlDeclaration("Has Encounter with Initial and Follow Up VR36 Orthogonal Assessments")]
	public bool? Has_Encounter_with_Initial_and_Follow_Up_VR36_Orthogonal_Assessments() => 
		__Has_Encounter_with_Initial_and_Follow_Up_VR36_Orthogonal_Assessments.Value;

	private IEnumerable<CqlDate> Date_MLHFQ_Total_Assessment_Completed_Value()
	{
		CqlCode a_ = this.Physical_score__MLHFQ_();
		IEnumerable<CqlCode> b_ = context.Operators.ToList<CqlCode>(a_);
		IEnumerable<Observation> c_ = context.Operators.RetrieveByCodes<Observation>(b_, null);
		IEnumerable<Observation> d_ = Status_1_6_000.Final_Survey_Observation(c_);
		CqlCode e_ = this.Emotional_score__MLHFQ_();
		IEnumerable<CqlCode> f_ = context.Operators.ToList<CqlCode>(e_);
		IEnumerable<Observation> g_ = context.Operators.RetrieveByCodes<Observation>(f_, null);
		IEnumerable<Observation> h_ = Status_1_6_000.Final_Survey_Observation(g_);
		IEnumerable<ValueTuple<Observation,Observation>> i_ = context.Operators.CrossJoin<Observation, Observation>(d_, h_);
		Tuple_CBaKLCFRCUhXghPfCScgCAfHU j_(ValueTuple<Observation,Observation> _valueTuple)
		{
			Tuple_CBaKLCFRCUhXghPfCScgCAfHU p_ = new Tuple_CBaKLCFRCUhXghPfCScgCAfHU
			{
				MLHFQPhysical = _valueTuple.Item1,
				MLHFQEmotional = _valueTuple.Item2,
			};

			return p_;
		};
		IEnumerable<Tuple_CBaKLCFRCUhXghPfCScgCAfHU> k_ = context.Operators.Select<ValueTuple<Observation,Observation>, Tuple_CBaKLCFRCUhXghPfCScgCAfHU>(i_, j_);
		bool? l_(Tuple_CBaKLCFRCUhXghPfCScgCAfHU tuple_cbaklcfrcuhxghpfcscgcafhu)
		{
			object q_ = FHIRHelpers_4_3_000.ToValue(tuple_cbaklcfrcuhxghpfcscgcafhu.MLHFQPhysical?.Effective);
			CqlInterval<CqlDateTime> r_ = QICoreCommon_2_0_000.ToInterval(q_);
			CqlDateTime s_ = context.Operators.Start(r_);
			CqlDate t_ = context.Operators.DateFrom(s_);
			object u_ = FHIRHelpers_4_3_000.ToValue(tuple_cbaklcfrcuhxghpfcscgcafhu.MLHFQEmotional?.Effective);
			CqlInterval<CqlDateTime> v_ = QICoreCommon_2_0_000.ToInterval(u_);
			CqlDateTime w_ = context.Operators.Start(v_);
			CqlDate x_ = context.Operators.DateFrom(w_);
			bool? y_ = context.Operators.SameAs(t_, x_, "day");
			object z_ = FHIRHelpers_4_3_000.ToValue(tuple_cbaklcfrcuhxghpfcscgcafhu.MLHFQPhysical?.Value);
			bool? aa_ = context.Operators.Not((bool?)(z_ is null));
			bool? ab_ = context.Operators.And(y_, aa_);
			object ac_ = FHIRHelpers_4_3_000.ToValue(tuple_cbaklcfrcuhxghpfcscgcafhu.MLHFQEmotional?.Value);
			bool? ad_ = context.Operators.Not((bool?)(ac_ is null));
			bool? ae_ = context.Operators.And(ab_, ad_);

			return ae_;
		};
		IEnumerable<Tuple_CBaKLCFRCUhXghPfCScgCAfHU> m_ = context.Operators.Where<Tuple_CBaKLCFRCUhXghPfCScgCAfHU>(k_, l_);
		CqlDate n_(Tuple_CBaKLCFRCUhXghPfCScgCAfHU tuple_cbaklcfrcuhxghpfcscgcafhu)
		{
			object af_ = FHIRHelpers_4_3_000.ToValue(tuple_cbaklcfrcuhxghpfcscgcafhu.MLHFQPhysical?.Effective);
			CqlInterval<CqlDateTime> ag_ = QICoreCommon_2_0_000.ToInterval(af_);
			CqlDateTime ah_ = context.Operators.Start(ag_);
			CqlDate ai_ = context.Operators.DateFrom(ah_);
			object aj_ = FHIRHelpers_4_3_000.ToValue(tuple_cbaklcfrcuhxghpfcscgcafhu.MLHFQEmotional?.Effective);
			CqlInterval<CqlDateTime> ak_ = QICoreCommon_2_0_000.ToInterval(aj_);
			CqlDateTime al_ = context.Operators.Start(ak_);
			CqlDate am_ = context.Operators.DateFrom(al_);
			CqlDate[] an_ = new CqlDate[]
			{
				ai_,
				am_,
			};
			CqlDate ao_ = context.Operators.Max<CqlDate>((an_ as IEnumerable<CqlDate>));

			return ao_;
		};
		IEnumerable<CqlDate> o_ = context.Operators.Select<Tuple_CBaKLCFRCUhXghPfCScgCAfHU, CqlDate>(m_, n_);

		return o_;
	}

    [CqlDeclaration("Date MLHFQ Total Assessment Completed")]
	public IEnumerable<CqlDate> Date_MLHFQ_Total_Assessment_Completed() => 
		__Date_MLHFQ_Total_Assessment_Completed.Value;

	private bool? Has_Encounter_with_Initial_and_Follow_Up_MLHFQ_Assessments_Value()
	{
		IEnumerable<Encounter> a_ = this.Qualifying_Encounters();
		IEnumerable<CqlDate> b_ = this.Date_MLHFQ_Total_Assessment_Completed();
		IEnumerable<ValueTuple<Encounter,CqlDate,CqlDate>> d_ = context.Operators.CrossJoin<Encounter, CqlDate, CqlDate>(a_, b_, b_);
		Tuple_DgNBKfGfRHaWDZaDFPZKifXLi e_(ValueTuple<Encounter,CqlDate,CqlDate> _valueTuple)
		{
			Tuple_DgNBKfGfRHaWDZaDFPZKifXLi l_ = new Tuple_DgNBKfGfRHaWDZaDFPZKifXLi
			{
				ValidEncounters = _valueTuple.Item1,
				InitialMLHFQDate = _valueTuple.Item2,
				FollowupMLHFQDate = _valueTuple.Item3,
			};

			return l_;
		};
		IEnumerable<Tuple_DgNBKfGfRHaWDZaDFPZKifXLi> f_ = context.Operators.Select<ValueTuple<Encounter,CqlDate,CqlDate>, Tuple_DgNBKfGfRHaWDZaDFPZKifXLi>(d_, e_);
		bool? g_(Tuple_DgNBKfGfRHaWDZaDFPZKifXLi tuple_dgnbkfgfrhawdzadfpzkifxli)
		{
			CqlInterval<CqlDateTime> m_ = FHIRHelpers_4_3_000.ToInterval(tuple_dgnbkfgfrhawdzadfpzkifxli.ValidEncounters?.Period);
			CqlInterval<CqlDateTime> n_ = QICoreCommon_2_0_000.ToInterval((m_ as object));
			CqlDateTime o_ = context.Operators.End(n_);
			CqlInterval<CqlDateTime> p_ = this.Measurement_Period();
			CqlDateTime q_ = context.Operators.End(p_);
			CqlQuantity r_ = context.Operators.Quantity(180m, "days");
			CqlDateTime s_ = context.Operators.Subtract(q_, r_);
			bool? t_ = context.Operators.SameOrBefore(o_, s_, "day");
			CqlDateTime u_ = context.Operators.ConvertDateToDateTime(tuple_dgnbkfgfrhawdzadfpzkifxli.InitialMLHFQDate);
			CqlInterval<CqlDateTime> w_ = QICoreCommon_2_0_000.ToInterval((m_ as object));
			CqlDateTime x_ = context.Operators.End(w_);
			CqlQuantity y_ = context.Operators.Quantity(14m, "days");
			CqlDateTime z_ = context.Operators.Subtract(x_, y_);
			CqlInterval<CqlDateTime> ab_ = QICoreCommon_2_0_000.ToInterval((m_ as object));
			CqlDateTime ac_ = context.Operators.End(ab_);
			CqlInterval<CqlDateTime> ad_ = context.Operators.Interval(z_, ac_, true, true);
			bool? ae_ = context.Operators.In<CqlDateTime>(u_, ad_, "day");
			CqlInterval<CqlDateTime> ag_ = QICoreCommon_2_0_000.ToInterval((m_ as object));
			CqlDateTime ah_ = context.Operators.End(ag_);
			bool? ai_ = context.Operators.Not((bool?)(ah_ is null));
			bool? aj_ = context.Operators.And(ae_, ai_);
			bool? ak_ = context.Operators.And(t_, aj_);
			CqlDateTime al_ = context.Operators.ConvertDateToDateTime(tuple_dgnbkfgfrhawdzadfpzkifxli.FollowupMLHFQDate);
			CqlDate am_ = context.Operators.DateFrom(al_);
			CqlDate ao_ = context.Operators.DateFrom(u_);
			CqlQuantity ap_ = context.Operators.Quantity(30m, "days");
			CqlDate aq_ = context.Operators.Add(ao_, ap_);
			CqlDate as_ = context.Operators.DateFrom(u_);
			CqlDate au_ = context.Operators.Add(as_, r_);
			CqlInterval<CqlDate> av_ = context.Operators.Interval(aq_, au_, true, true);
			bool? aw_ = context.Operators.In<CqlDate>(am_, av_, "day");
			bool? ax_ = context.Operators.And(ak_, aw_);

			return ax_;
		};
		IEnumerable<Tuple_DgNBKfGfRHaWDZaDFPZKifXLi> h_ = context.Operators.Where<Tuple_DgNBKfGfRHaWDZaDFPZKifXLi>(f_, g_);
		Encounter i_(Tuple_DgNBKfGfRHaWDZaDFPZKifXLi tuple_dgnbkfgfrhawdzadfpzkifxli) => 
			tuple_dgnbkfgfrhawdzadfpzkifxli.ValidEncounters;
		IEnumerable<Encounter> j_ = context.Operators.Select<Tuple_DgNBKfGfRHaWDZaDFPZKifXLi, Encounter>(h_, i_);
		bool? k_ = context.Operators.Exists<Encounter>(j_);

		return k_;
	}

    [CqlDeclaration("Has Encounter with Initial and Follow Up MLHFQ Assessments")]
	public bool? Has_Encounter_with_Initial_and_Follow_Up_MLHFQ_Assessments() => 
		__Has_Encounter_with_Initial_and_Follow_Up_MLHFQ_Assessments.Value;

	private IEnumerable<CqlDate> Date_KCCQ12_Total_Assessment_Completed_Value()
	{
		CqlCode a_ = this.Kansas_City_Cardiomyopathy_Questionnaire___12_item__KCCQ_12_();
		IEnumerable<CqlCode> b_ = context.Operators.ToList<CqlCode>(a_);
		IEnumerable<Observation> c_ = context.Operators.RetrieveByCodes<Observation>(b_, null);
		IEnumerable<Observation> d_ = Status_1_6_000.Final_Survey_Observation(c_);
		CqlCode e_ = this.Overall_summary_score__KCCQ_12_();
		IEnumerable<CqlCode> f_ = context.Operators.ToList<CqlCode>(e_);
		IEnumerable<Observation> g_ = context.Operators.RetrieveByCodes<Observation>(f_, null);
		IEnumerable<Observation> h_ = Status_1_6_000.Final_Survey_Observation(g_);
		IEnumerable<ValueTuple<Observation,Observation>> i_ = context.Operators.CrossJoin<Observation, Observation>(d_, h_);
		Tuple_FFJNYaMQHZAOFYMNSKAHAUdLF j_(ValueTuple<Observation,Observation> _valueTuple)
		{
			Tuple_FFJNYaMQHZAOFYMNSKAHAUdLF p_ = new Tuple_FFJNYaMQHZAOFYMNSKAHAUdLF
			{
				KCCQ12Item = _valueTuple.Item1,
				KCCQ12Summary = _valueTuple.Item2,
			};

			return p_;
		};
		IEnumerable<Tuple_FFJNYaMQHZAOFYMNSKAHAUdLF> k_ = context.Operators.Select<ValueTuple<Observation,Observation>, Tuple_FFJNYaMQHZAOFYMNSKAHAUdLF>(i_, j_);
		bool? l_(Tuple_FFJNYaMQHZAOFYMNSKAHAUdLF tuple_ffjnyamqhzaofymnskahaudlf)
		{
			object q_ = FHIRHelpers_4_3_000.ToValue(tuple_ffjnyamqhzaofymnskahaudlf.KCCQ12Item?.Effective);
			CqlInterval<CqlDateTime> r_ = QICoreCommon_2_0_000.ToInterval(q_);
			CqlDateTime s_ = context.Operators.Start(r_);
			CqlDate t_ = context.Operators.DateFrom(s_);
			object u_ = FHIRHelpers_4_3_000.ToValue(tuple_ffjnyamqhzaofymnskahaudlf.KCCQ12Summary?.Effective);
			CqlInterval<CqlDateTime> v_ = QICoreCommon_2_0_000.ToInterval(u_);
			CqlDateTime w_ = context.Operators.Start(v_);
			CqlDate x_ = context.Operators.DateFrom(w_);
			bool? y_ = context.Operators.SameAs(t_, x_, "day");
			object z_ = FHIRHelpers_4_3_000.ToValue(tuple_ffjnyamqhzaofymnskahaudlf.KCCQ12Item?.Value);
			bool? aa_ = context.Operators.Not((bool?)(z_ is null));
			bool? ab_ = context.Operators.And(y_, aa_);
			object ac_ = FHIRHelpers_4_3_000.ToValue(tuple_ffjnyamqhzaofymnskahaudlf.KCCQ12Summary?.Value);
			bool? ad_ = context.Operators.Not((bool?)(ac_ is null));
			bool? ae_ = context.Operators.And(ab_, ad_);

			return ae_;
		};
		IEnumerable<Tuple_FFJNYaMQHZAOFYMNSKAHAUdLF> m_ = context.Operators.Where<Tuple_FFJNYaMQHZAOFYMNSKAHAUdLF>(k_, l_);
		CqlDate n_(Tuple_FFJNYaMQHZAOFYMNSKAHAUdLF tuple_ffjnyamqhzaofymnskahaudlf)
		{
			object af_ = FHIRHelpers_4_3_000.ToValue(tuple_ffjnyamqhzaofymnskahaudlf.KCCQ12Item?.Effective);
			CqlInterval<CqlDateTime> ag_ = QICoreCommon_2_0_000.ToInterval(af_);
			CqlDateTime ah_ = context.Operators.Start(ag_);
			CqlDate ai_ = context.Operators.DateFrom(ah_);
			object aj_ = FHIRHelpers_4_3_000.ToValue(tuple_ffjnyamqhzaofymnskahaudlf.KCCQ12Summary?.Effective);
			CqlInterval<CqlDateTime> ak_ = QICoreCommon_2_0_000.ToInterval(aj_);
			CqlDateTime al_ = context.Operators.Start(ak_);
			CqlDate am_ = context.Operators.DateFrom(al_);
			CqlDate[] an_ = new CqlDate[]
			{
				ai_,
				am_,
			};
			CqlDate ao_ = context.Operators.Max<CqlDate>((an_ as IEnumerable<CqlDate>));

			return ao_;
		};
		IEnumerable<CqlDate> o_ = context.Operators.Select<Tuple_FFJNYaMQHZAOFYMNSKAHAUdLF, CqlDate>(m_, n_);

		return o_;
	}

    [CqlDeclaration("Date KCCQ12 Total Assessment Completed")]
	public IEnumerable<CqlDate> Date_KCCQ12_Total_Assessment_Completed() => 
		__Date_KCCQ12_Total_Assessment_Completed.Value;

	private bool? Has_Encounter_with_Initial_and_Follow_Up_KCCQ12_Assessments_Value()
	{
		IEnumerable<Encounter> a_ = this.Qualifying_Encounters();
		IEnumerable<CqlDate> b_ = this.Date_KCCQ12_Total_Assessment_Completed();
		IEnumerable<ValueTuple<Encounter,CqlDate,CqlDate>> d_ = context.Operators.CrossJoin<Encounter, CqlDate, CqlDate>(a_, b_, b_);
		Tuple_DNZcZTNIZUQfFfijaYDWagbfi e_(ValueTuple<Encounter,CqlDate,CqlDate> _valueTuple)
		{
			Tuple_DNZcZTNIZUQfFfijaYDWagbfi l_ = new Tuple_DNZcZTNIZUQfFfijaYDWagbfi
			{
				ValidEncounters = _valueTuple.Item1,
				InitialKCCQ12Date = _valueTuple.Item2,
				FollowupKCCQ12Date = _valueTuple.Item3,
			};

			return l_;
		};
		IEnumerable<Tuple_DNZcZTNIZUQfFfijaYDWagbfi> f_ = context.Operators.Select<ValueTuple<Encounter,CqlDate,CqlDate>, Tuple_DNZcZTNIZUQfFfijaYDWagbfi>(d_, e_);
		bool? g_(Tuple_DNZcZTNIZUQfFfijaYDWagbfi tuple_dnzcztnizuqfffijaydwagbfi)
		{
			CqlInterval<CqlDateTime> m_ = FHIRHelpers_4_3_000.ToInterval(tuple_dnzcztnizuqfffijaydwagbfi.ValidEncounters?.Period);
			CqlInterval<CqlDateTime> n_ = QICoreCommon_2_0_000.ToInterval((m_ as object));
			CqlDateTime o_ = context.Operators.End(n_);
			CqlInterval<CqlDateTime> p_ = this.Measurement_Period();
			CqlDateTime q_ = context.Operators.End(p_);
			CqlQuantity r_ = context.Operators.Quantity(180m, "days");
			CqlDateTime s_ = context.Operators.Subtract(q_, r_);
			bool? t_ = context.Operators.SameOrBefore(o_, s_, "day");
			CqlDateTime u_ = context.Operators.ConvertDateToDateTime(tuple_dnzcztnizuqfffijaydwagbfi.InitialKCCQ12Date);
			CqlInterval<CqlDateTime> w_ = QICoreCommon_2_0_000.ToInterval((m_ as object));
			CqlDateTime x_ = context.Operators.End(w_);
			CqlQuantity y_ = context.Operators.Quantity(14m, "days");
			CqlDateTime z_ = context.Operators.Subtract(x_, y_);
			CqlInterval<CqlDateTime> ab_ = QICoreCommon_2_0_000.ToInterval((m_ as object));
			CqlDateTime ac_ = context.Operators.End(ab_);
			CqlInterval<CqlDateTime> ad_ = context.Operators.Interval(z_, ac_, true, true);
			bool? ae_ = context.Operators.In<CqlDateTime>(u_, ad_, "day");
			CqlInterval<CqlDateTime> ag_ = QICoreCommon_2_0_000.ToInterval((m_ as object));
			CqlDateTime ah_ = context.Operators.End(ag_);
			bool? ai_ = context.Operators.Not((bool?)(ah_ is null));
			bool? aj_ = context.Operators.And(ae_, ai_);
			bool? ak_ = context.Operators.And(t_, aj_);
			CqlDateTime al_ = context.Operators.ConvertDateToDateTime(tuple_dnzcztnizuqfffijaydwagbfi.FollowupKCCQ12Date);
			CqlDate am_ = context.Operators.DateFrom(al_);
			CqlDate ao_ = context.Operators.DateFrom(u_);
			CqlQuantity ap_ = context.Operators.Quantity(30m, "days");
			CqlDate aq_ = context.Operators.Add(ao_, ap_);
			CqlDate as_ = context.Operators.DateFrom(u_);
			CqlDate au_ = context.Operators.Add(as_, r_);
			CqlInterval<CqlDate> av_ = context.Operators.Interval(aq_, au_, true, true);
			bool? aw_ = context.Operators.In<CqlDate>(am_, av_, "day");
			bool? ax_ = context.Operators.And(ak_, aw_);

			return ax_;
		};
		IEnumerable<Tuple_DNZcZTNIZUQfFfijaYDWagbfi> h_ = context.Operators.Where<Tuple_DNZcZTNIZUQfFfijaYDWagbfi>(f_, g_);
		Encounter i_(Tuple_DNZcZTNIZUQfFfijaYDWagbfi tuple_dnzcztnizuqfffijaydwagbfi) => 
			tuple_dnzcztnizuqfffijaydwagbfi.ValidEncounters;
		IEnumerable<Encounter> j_ = context.Operators.Select<Tuple_DNZcZTNIZUQfFfijaYDWagbfi, Encounter>(h_, i_);
		bool? k_ = context.Operators.Exists<Encounter>(j_);

		return k_;
	}

    [CqlDeclaration("Has Encounter with Initial and Follow Up KCCQ12 Assessments")]
	public bool? Has_Encounter_with_Initial_and_Follow_Up_KCCQ12_Assessments() => 
		__Has_Encounter_with_Initial_and_Follow_Up_KCCQ12_Assessments.Value;

	private IEnumerable<CqlDate> Date_KCCQ_Domain_Assessment_Completed_Value()
	{
		CqlCode a_ = this.Quality_of_life_score__KCCQ_();
		IEnumerable<CqlCode> b_ = context.Operators.ToList<CqlCode>(a_);
		IEnumerable<Observation> c_ = context.Operators.RetrieveByCodes<Observation>(b_, null);
		IEnumerable<Observation> d_ = Status_1_6_000.Final_Survey_Observation(c_);
		CqlCode e_ = this.Symptom_stability_score__KCCQ_();
		IEnumerable<CqlCode> f_ = context.Operators.ToList<CqlCode>(e_);
		IEnumerable<Observation> g_ = context.Operators.RetrieveByCodes<Observation>(f_, null);
		IEnumerable<Observation> h_ = Status_1_6_000.Final_Survey_Observation(g_);
		CqlCode i_ = this.Self_efficacy_score__KCCQ_();
		IEnumerable<CqlCode> j_ = context.Operators.ToList<CqlCode>(i_);
		IEnumerable<Observation> k_ = context.Operators.RetrieveByCodes<Observation>(j_, null);
		IEnumerable<Observation> l_ = Status_1_6_000.Final_Survey_Observation(k_);
		CqlCode m_ = this.Total_symptom_score__KCCQ_();
		IEnumerable<CqlCode> n_ = context.Operators.ToList<CqlCode>(m_);
		IEnumerable<Observation> o_ = context.Operators.RetrieveByCodes<Observation>(n_, null);
		IEnumerable<Observation> p_ = Status_1_6_000.Final_Survey_Observation(o_);
		CqlCode q_ = this.Physical_limitation_score__KCCQ_();
		IEnumerable<CqlCode> r_ = context.Operators.ToList<CqlCode>(q_);
		IEnumerable<Observation> s_ = context.Operators.RetrieveByCodes<Observation>(r_, null);
		IEnumerable<Observation> t_ = Status_1_6_000.Final_Survey_Observation(s_);
		CqlCode u_ = this.Social_limitation_score__KCCQ_();
		IEnumerable<CqlCode> v_ = context.Operators.ToList<CqlCode>(u_);
		IEnumerable<Observation> w_ = context.Operators.RetrieveByCodes<Observation>(v_, null);
		IEnumerable<Observation> x_ = Status_1_6_000.Final_Survey_Observation(w_);
		IEnumerable<ValueTuple<Observation,Observation,Observation,Observation,Observation,Observation>> y_ = context.Operators.CrossJoin<Observation, Observation, Observation, Observation, Observation, Observation>(d_, h_, l_, p_, t_, x_);
		Tuple_BbiPKFIYFfdQCLCHPcXKDaFMV z_(ValueTuple<Observation,Observation,Observation,Observation,Observation,Observation> _valueTuple)
		{
			Tuple_BbiPKFIYFfdQCLCHPcXKDaFMV af_ = new Tuple_BbiPKFIYFfdQCLCHPcXKDaFMV
			{
				KCCQLifeQuality = _valueTuple.Item1,
				KCCQSymptomStability = _valueTuple.Item2,
				KCCQSelfEfficacy = _valueTuple.Item3,
				KCCQSymptoms = _valueTuple.Item4,
				KCCQPhysicalLimits = _valueTuple.Item5,
				KCCQSocialLimits = _valueTuple.Item6,
			};

			return af_;
		};
		IEnumerable<Tuple_BbiPKFIYFfdQCLCHPcXKDaFMV> aa_ = context.Operators.Select<ValueTuple<Observation,Observation,Observation,Observation,Observation,Observation>, Tuple_BbiPKFIYFfdQCLCHPcXKDaFMV>(y_, z_);
		bool? ab_(Tuple_BbiPKFIYFfdQCLCHPcXKDaFMV tuple_bbipkfiyffdqclchpcxkdafmv)
		{
			object ag_ = FHIRHelpers_4_3_000.ToValue(tuple_bbipkfiyffdqclchpcxkdafmv.KCCQLifeQuality?.Effective);
			CqlInterval<CqlDateTime> ah_ = QICoreCommon_2_0_000.ToInterval(ag_);
			CqlDateTime ai_ = context.Operators.Start(ah_);
			CqlDate aj_ = context.Operators.DateFrom(ai_);
			object ak_ = FHIRHelpers_4_3_000.ToValue(tuple_bbipkfiyffdqclchpcxkdafmv.KCCQSymptomStability?.Effective);
			CqlInterval<CqlDateTime> al_ = QICoreCommon_2_0_000.ToInterval(ak_);
			CqlDateTime am_ = context.Operators.Start(al_);
			CqlDate an_ = context.Operators.DateFrom(am_);
			bool? ao_ = context.Operators.SameAs(aj_, an_, "day");
			object ap_ = FHIRHelpers_4_3_000.ToValue(tuple_bbipkfiyffdqclchpcxkdafmv.KCCQSymptomStability?.Value);
			bool? aq_ = context.Operators.Not((bool?)(ap_ is null));
			bool? ar_ = context.Operators.And(ao_, aq_);
			CqlInterval<CqlDateTime> at_ = QICoreCommon_2_0_000.ToInterval(ag_);
			CqlDateTime au_ = context.Operators.Start(at_);
			CqlDate av_ = context.Operators.DateFrom(au_);
			object aw_ = FHIRHelpers_4_3_000.ToValue(tuple_bbipkfiyffdqclchpcxkdafmv.KCCQSelfEfficacy?.Effective);
			CqlInterval<CqlDateTime> ax_ = QICoreCommon_2_0_000.ToInterval(aw_);
			CqlDateTime ay_ = context.Operators.Start(ax_);
			CqlDate az_ = context.Operators.DateFrom(ay_);
			bool? ba_ = context.Operators.SameAs(av_, az_, "day");
			bool? bb_ = context.Operators.And(ar_, ba_);
			object bc_ = FHIRHelpers_4_3_000.ToValue(tuple_bbipkfiyffdqclchpcxkdafmv.KCCQSelfEfficacy?.Value);
			bool? bd_ = context.Operators.Not((bool?)(bc_ is null));
			bool? be_ = context.Operators.And(bb_, bd_);
			CqlInterval<CqlDateTime> bg_ = QICoreCommon_2_0_000.ToInterval(ag_);
			CqlDateTime bh_ = context.Operators.Start(bg_);
			CqlDate bi_ = context.Operators.DateFrom(bh_);
			object bj_ = FHIRHelpers_4_3_000.ToValue(tuple_bbipkfiyffdqclchpcxkdafmv.KCCQSymptoms?.Effective);
			CqlInterval<CqlDateTime> bk_ = QICoreCommon_2_0_000.ToInterval(bj_);
			CqlDateTime bl_ = context.Operators.Start(bk_);
			CqlDate bm_ = context.Operators.DateFrom(bl_);
			bool? bn_ = context.Operators.SameAs(bi_, bm_, "day");
			bool? bo_ = context.Operators.And(be_, bn_);
			object bp_ = FHIRHelpers_4_3_000.ToValue(tuple_bbipkfiyffdqclchpcxkdafmv.KCCQSymptoms?.Value);
			bool? bq_ = context.Operators.Not((bool?)(bp_ is null));
			bool? br_ = context.Operators.And(bo_, bq_);
			CqlInterval<CqlDateTime> bt_ = QICoreCommon_2_0_000.ToInterval(ag_);
			CqlDateTime bu_ = context.Operators.Start(bt_);
			CqlDate bv_ = context.Operators.DateFrom(bu_);
			object bw_ = FHIRHelpers_4_3_000.ToValue(tuple_bbipkfiyffdqclchpcxkdafmv.KCCQPhysicalLimits?.Effective);
			CqlInterval<CqlDateTime> bx_ = QICoreCommon_2_0_000.ToInterval(bw_);
			CqlDateTime by_ = context.Operators.Start(bx_);
			CqlDate bz_ = context.Operators.DateFrom(by_);
			bool? ca_ = context.Operators.SameAs(bv_, bz_, "day");
			bool? cb_ = context.Operators.And(br_, ca_);
			object cc_ = FHIRHelpers_4_3_000.ToValue(tuple_bbipkfiyffdqclchpcxkdafmv.KCCQPhysicalLimits?.Value);
			bool? cd_ = context.Operators.Not((bool?)(cc_ is null));
			bool? ce_ = context.Operators.And(cb_, cd_);
			CqlInterval<CqlDateTime> cg_ = QICoreCommon_2_0_000.ToInterval(ag_);
			CqlDateTime ch_ = context.Operators.Start(cg_);
			CqlDate ci_ = context.Operators.DateFrom(ch_);
			object cj_ = FHIRHelpers_4_3_000.ToValue(tuple_bbipkfiyffdqclchpcxkdafmv.KCCQSocialLimits?.Effective);
			CqlInterval<CqlDateTime> ck_ = QICoreCommon_2_0_000.ToInterval(cj_);
			CqlDateTime cl_ = context.Operators.Start(ck_);
			CqlDate cm_ = context.Operators.DateFrom(cl_);
			bool? cn_ = context.Operators.SameAs(ci_, cm_, "day");
			bool? co_ = context.Operators.And(ce_, cn_);
			object cp_ = FHIRHelpers_4_3_000.ToValue(tuple_bbipkfiyffdqclchpcxkdafmv.KCCQSocialLimits?.Value);
			bool? cq_ = context.Operators.Not((bool?)(cp_ is null));
			bool? cr_ = context.Operators.And(co_, cq_);
			object cs_ = FHIRHelpers_4_3_000.ToValue(tuple_bbipkfiyffdqclchpcxkdafmv.KCCQLifeQuality?.Value);
			bool? ct_ = context.Operators.Not((bool?)(cs_ is null));
			bool? cu_ = context.Operators.And(cr_, ct_);

			return cu_;
		};
		IEnumerable<Tuple_BbiPKFIYFfdQCLCHPcXKDaFMV> ac_ = context.Operators.Where<Tuple_BbiPKFIYFfdQCLCHPcXKDaFMV>(aa_, ab_);
		CqlDate ad_(Tuple_BbiPKFIYFfdQCLCHPcXKDaFMV tuple_bbipkfiyffdqclchpcxkdafmv)
		{
			object cv_ = FHIRHelpers_4_3_000.ToValue(tuple_bbipkfiyffdqclchpcxkdafmv.KCCQLifeQuality?.Effective);
			CqlInterval<CqlDateTime> cw_ = QICoreCommon_2_0_000.ToInterval(cv_);
			CqlDateTime cx_ = context.Operators.Start(cw_);
			CqlDate cy_ = context.Operators.DateFrom(cx_);
			object cz_ = FHIRHelpers_4_3_000.ToValue(tuple_bbipkfiyffdqclchpcxkdafmv.KCCQSymptomStability?.Effective);
			CqlInterval<CqlDateTime> da_ = QICoreCommon_2_0_000.ToInterval(cz_);
			CqlDateTime db_ = context.Operators.Start(da_);
			CqlDate dc_ = context.Operators.DateFrom(db_);
			object dd_ = FHIRHelpers_4_3_000.ToValue(tuple_bbipkfiyffdqclchpcxkdafmv.KCCQSelfEfficacy?.Effective);
			CqlInterval<CqlDateTime> de_ = QICoreCommon_2_0_000.ToInterval(dd_);
			CqlDateTime df_ = context.Operators.Start(de_);
			CqlDate dg_ = context.Operators.DateFrom(df_);
			object dh_ = FHIRHelpers_4_3_000.ToValue(tuple_bbipkfiyffdqclchpcxkdafmv.KCCQSymptoms?.Effective);
			CqlInterval<CqlDateTime> di_ = QICoreCommon_2_0_000.ToInterval(dh_);
			CqlDateTime dj_ = context.Operators.Start(di_);
			CqlDate dk_ = context.Operators.DateFrom(dj_);
			object dl_ = FHIRHelpers_4_3_000.ToValue(tuple_bbipkfiyffdqclchpcxkdafmv.KCCQPhysicalLimits?.Effective);
			CqlInterval<CqlDateTime> dm_ = QICoreCommon_2_0_000.ToInterval(dl_);
			CqlDateTime dn_ = context.Operators.Start(dm_);
			CqlDate do_ = context.Operators.DateFrom(dn_);
			object dp_ = FHIRHelpers_4_3_000.ToValue(tuple_bbipkfiyffdqclchpcxkdafmv.KCCQSocialLimits?.Effective);
			CqlInterval<CqlDateTime> dq_ = QICoreCommon_2_0_000.ToInterval(dp_);
			CqlDateTime dr_ = context.Operators.Start(dq_);
			CqlDate ds_ = context.Operators.DateFrom(dr_);
			CqlDate[] dt_ = new CqlDate[]
			{
				cy_,
				dc_,
				dg_,
				dk_,
				do_,
				ds_,
			};
			CqlDate du_ = context.Operators.Max<CqlDate>((dt_ as IEnumerable<CqlDate>));

			return du_;
		};
		IEnumerable<CqlDate> ae_ = context.Operators.Select<Tuple_BbiPKFIYFfdQCLCHPcXKDaFMV, CqlDate>(ac_, ad_);

		return ae_;
	}

    [CqlDeclaration("Date KCCQ Domain Assessment Completed")]
	public IEnumerable<CqlDate> Date_KCCQ_Domain_Assessment_Completed() => 
		__Date_KCCQ_Domain_Assessment_Completed.Value;

	private bool? Has_Encounter_with_Initial_and_Follow_Up_KCCQ_Domain_Score_Assessments_Value()
	{
		IEnumerable<Encounter> a_ = this.Qualifying_Encounters();
		IEnumerable<CqlDate> b_ = this.Date_KCCQ_Domain_Assessment_Completed();
		IEnumerable<ValueTuple<Encounter,CqlDate,CqlDate>> d_ = context.Operators.CrossJoin<Encounter, CqlDate, CqlDate>(a_, b_, b_);
		Tuple_GechMKfhePFUbfJYJeVegQTRC e_(ValueTuple<Encounter,CqlDate,CqlDate> _valueTuple)
		{
			Tuple_GechMKfhePFUbfJYJeVegQTRC l_ = new Tuple_GechMKfhePFUbfJYJeVegQTRC
			{
				ValidEncounters = _valueTuple.Item1,
				InitialKCCQAssessmentDate = _valueTuple.Item2,
				FollowupKCCQAssessmentDate = _valueTuple.Item3,
			};

			return l_;
		};
		IEnumerable<Tuple_GechMKfhePFUbfJYJeVegQTRC> f_ = context.Operators.Select<ValueTuple<Encounter,CqlDate,CqlDate>, Tuple_GechMKfhePFUbfJYJeVegQTRC>(d_, e_);
		bool? g_(Tuple_GechMKfhePFUbfJYJeVegQTRC tuple_gechmkfhepfubfjyjevegqtrc)
		{
			CqlInterval<CqlDateTime> m_ = FHIRHelpers_4_3_000.ToInterval(tuple_gechmkfhepfubfjyjevegqtrc.ValidEncounters?.Period);
			CqlInterval<CqlDateTime> n_ = QICoreCommon_2_0_000.ToInterval((m_ as object));
			CqlDateTime o_ = context.Operators.End(n_);
			CqlInterval<CqlDateTime> p_ = this.Measurement_Period();
			CqlDateTime q_ = context.Operators.End(p_);
			CqlQuantity r_ = context.Operators.Quantity(180m, "days");
			CqlDateTime s_ = context.Operators.Subtract(q_, r_);
			bool? t_ = context.Operators.SameOrBefore(o_, s_, "day");
			CqlDateTime u_ = context.Operators.ConvertDateToDateTime(tuple_gechmkfhepfubfjyjevegqtrc.InitialKCCQAssessmentDate);
			CqlInterval<CqlDateTime> w_ = QICoreCommon_2_0_000.ToInterval((m_ as object));
			CqlDateTime x_ = context.Operators.End(w_);
			CqlQuantity y_ = context.Operators.Quantity(14m, "days");
			CqlDateTime z_ = context.Operators.Subtract(x_, y_);
			CqlInterval<CqlDateTime> ab_ = QICoreCommon_2_0_000.ToInterval((m_ as object));
			CqlDateTime ac_ = context.Operators.End(ab_);
			CqlInterval<CqlDateTime> ad_ = context.Operators.Interval(z_, ac_, true, true);
			bool? ae_ = context.Operators.In<CqlDateTime>(u_, ad_, "day");
			CqlInterval<CqlDateTime> ag_ = QICoreCommon_2_0_000.ToInterval((m_ as object));
			CqlDateTime ah_ = context.Operators.End(ag_);
			bool? ai_ = context.Operators.Not((bool?)(ah_ is null));
			bool? aj_ = context.Operators.And(ae_, ai_);
			bool? ak_ = context.Operators.And(t_, aj_);
			CqlDateTime al_ = context.Operators.ConvertDateToDateTime(tuple_gechmkfhepfubfjyjevegqtrc.FollowupKCCQAssessmentDate);
			CqlDate am_ = context.Operators.DateFrom(al_);
			CqlDate ao_ = context.Operators.DateFrom(u_);
			CqlQuantity ap_ = context.Operators.Quantity(30m, "days");
			CqlDate aq_ = context.Operators.Add(ao_, ap_);
			CqlDate as_ = context.Operators.DateFrom(u_);
			CqlDate au_ = context.Operators.Add(as_, r_);
			CqlInterval<CqlDate> av_ = context.Operators.Interval(aq_, au_, true, true);
			bool? aw_ = context.Operators.In<CqlDate>(am_, av_, "day");
			bool? ax_ = context.Operators.And(ak_, aw_);

			return ax_;
		};
		IEnumerable<Tuple_GechMKfhePFUbfJYJeVegQTRC> h_ = context.Operators.Where<Tuple_GechMKfhePFUbfJYJeVegQTRC>(f_, g_);
		Encounter i_(Tuple_GechMKfhePFUbfJYJeVegQTRC tuple_gechmkfhepfubfjyjevegqtrc) => 
			tuple_gechmkfhepfubfjyjevegqtrc.ValidEncounters;
		IEnumerable<Encounter> j_ = context.Operators.Select<Tuple_GechMKfhePFUbfJYJeVegQTRC, Encounter>(h_, i_);
		bool? k_ = context.Operators.Exists<Encounter>(j_);

		return k_;
	}

    [CqlDeclaration("Has Encounter with Initial and Follow Up KCCQ Domain Score Assessments")]
	public bool? Has_Encounter_with_Initial_and_Follow_Up_KCCQ_Domain_Score_Assessments() => 
		__Has_Encounter_with_Initial_and_Follow_Up_KCCQ_Domain_Score_Assessments.Value;

	private IEnumerable<CqlDate> Date_KCCQ_Total_Assessment_Completed_Value()
	{
		CqlCode a_ = this.Overall_summary_score__KCCQ_();
		IEnumerable<CqlCode> b_ = context.Operators.ToList<CqlCode>(a_);
		IEnumerable<Observation> c_ = context.Operators.RetrieveByCodes<Observation>(b_, null);
		IEnumerable<Observation> d_ = Status_1_6_000.Final_Survey_Observation(c_);
		bool? e_(Observation KCCQSummaryScore)
		{
			object i_ = FHIRHelpers_4_3_000.ToValue(KCCQSummaryScore?.Value);
			bool? j_ = context.Operators.Not((bool?)(i_ is null));

			return j_;
		};
		IEnumerable<Observation> f_ = context.Operators.Where<Observation>(d_, e_);
		CqlDate g_(Observation KCCQSummaryScore)
		{
			object k_ = FHIRHelpers_4_3_000.ToValue(KCCQSummaryScore?.Effective);
			CqlInterval<CqlDateTime> l_ = QICoreCommon_2_0_000.ToInterval(k_);
			CqlDateTime m_ = context.Operators.Start(l_);
			CqlDate n_ = context.Operators.DateFrom(m_);
			CqlDate[] o_ = new CqlDate[]
			{
				n_,
			};
			CqlDate p_ = context.Operators.Max<CqlDate>((o_ as IEnumerable<CqlDate>));

			return p_;
		};
		IEnumerable<CqlDate> h_ = context.Operators.Select<Observation, CqlDate>(f_, g_);

		return h_;
	}

    [CqlDeclaration("Date KCCQ Total Assessment Completed")]
	public IEnumerable<CqlDate> Date_KCCQ_Total_Assessment_Completed() => 
		__Date_KCCQ_Total_Assessment_Completed.Value;

	private bool? Has_Encounter_with_Initial_and_Follow_Up_KCCQ_Total_Score_Assessments_Value()
	{
		IEnumerable<Encounter> a_ = this.Qualifying_Encounters();
		IEnumerable<CqlDate> b_ = this.Date_KCCQ_Total_Assessment_Completed();
		IEnumerable<ValueTuple<Encounter,CqlDate,CqlDate>> d_ = context.Operators.CrossJoin<Encounter, CqlDate, CqlDate>(a_, b_, b_);
		Tuple_DSdKcfQMUMBjegQCVVeYhPYdf e_(ValueTuple<Encounter,CqlDate,CqlDate> _valueTuple)
		{
			Tuple_DSdKcfQMUMBjegQCVVeYhPYdf l_ = new Tuple_DSdKcfQMUMBjegQCVVeYhPYdf
			{
				ValidEncounters = _valueTuple.Item1,
				InitialKCCQTotalScore = _valueTuple.Item2,
				FollowupKCCQTotalScore = _valueTuple.Item3,
			};

			return l_;
		};
		IEnumerable<Tuple_DSdKcfQMUMBjegQCVVeYhPYdf> f_ = context.Operators.Select<ValueTuple<Encounter,CqlDate,CqlDate>, Tuple_DSdKcfQMUMBjegQCVVeYhPYdf>(d_, e_);
		bool? g_(Tuple_DSdKcfQMUMBjegQCVVeYhPYdf tuple_dsdkcfqmumbjegqcvveyhpydf)
		{
			CqlInterval<CqlDateTime> m_ = FHIRHelpers_4_3_000.ToInterval(tuple_dsdkcfqmumbjegqcvveyhpydf.ValidEncounters?.Period);
			CqlInterval<CqlDateTime> n_ = QICoreCommon_2_0_000.ToInterval((m_ as object));
			CqlDateTime o_ = context.Operators.End(n_);
			CqlInterval<CqlDateTime> p_ = this.Measurement_Period();
			CqlDateTime q_ = context.Operators.End(p_);
			CqlQuantity r_ = context.Operators.Quantity(180m, "days");
			CqlDateTime s_ = context.Operators.Subtract(q_, r_);
			bool? t_ = context.Operators.SameOrBefore(o_, s_, "day");
			CqlDateTime u_ = context.Operators.ConvertDateToDateTime(tuple_dsdkcfqmumbjegqcvveyhpydf.InitialKCCQTotalScore);
			CqlInterval<CqlDateTime> w_ = QICoreCommon_2_0_000.ToInterval((m_ as object));
			CqlDateTime x_ = context.Operators.End(w_);
			CqlQuantity y_ = context.Operators.Quantity(14m, "days");
			CqlDateTime z_ = context.Operators.Subtract(x_, y_);
			CqlInterval<CqlDateTime> ab_ = QICoreCommon_2_0_000.ToInterval((m_ as object));
			CqlDateTime ac_ = context.Operators.End(ab_);
			CqlInterval<CqlDateTime> ad_ = context.Operators.Interval(z_, ac_, true, true);
			bool? ae_ = context.Operators.In<CqlDateTime>(u_, ad_, "day");
			CqlInterval<CqlDateTime> ag_ = QICoreCommon_2_0_000.ToInterval((m_ as object));
			CqlDateTime ah_ = context.Operators.End(ag_);
			bool? ai_ = context.Operators.Not((bool?)(ah_ is null));
			bool? aj_ = context.Operators.And(ae_, ai_);
			bool? ak_ = context.Operators.And(t_, aj_);
			CqlDateTime al_ = context.Operators.ConvertDateToDateTime(tuple_dsdkcfqmumbjegqcvveyhpydf.FollowupKCCQTotalScore);
			CqlDate am_ = context.Operators.DateFrom(al_);
			CqlDate ao_ = context.Operators.DateFrom(u_);
			CqlQuantity ap_ = context.Operators.Quantity(30m, "days");
			CqlDate aq_ = context.Operators.Add(ao_, ap_);
			CqlDate as_ = context.Operators.DateFrom(u_);
			CqlDate au_ = context.Operators.Add(as_, r_);
			CqlInterval<CqlDate> av_ = context.Operators.Interval(aq_, au_, true, true);
			bool? aw_ = context.Operators.In<CqlDate>(am_, av_, "day");
			bool? ax_ = context.Operators.And(ak_, aw_);

			return ax_;
		};
		IEnumerable<Tuple_DSdKcfQMUMBjegQCVVeYhPYdf> h_ = context.Operators.Where<Tuple_DSdKcfQMUMBjegQCVVeYhPYdf>(f_, g_);
		Encounter i_(Tuple_DSdKcfQMUMBjegQCVVeYhPYdf tuple_dsdkcfqmumbjegqcvveyhpydf) => 
			tuple_dsdkcfqmumbjegqcvveyhpydf.ValidEncounters;
		IEnumerable<Encounter> j_ = context.Operators.Select<Tuple_DSdKcfQMUMBjegQCVVeYhPYdf, Encounter>(h_, i_);
		bool? k_ = context.Operators.Exists<Encounter>(j_);

		return k_;
	}

    [CqlDeclaration("Has Encounter with Initial and Follow Up KCCQ Total Score Assessments")]
	public bool? Has_Encounter_with_Initial_and_Follow_Up_KCCQ_Total_Score_Assessments() => 
		__Has_Encounter_with_Initial_and_Follow_Up_KCCQ_Total_Score_Assessments.Value;

	private bool? Numerator_Value()
	{
		bool? a_ = this.Has_Encounter_with_Initial_and_Follow_Up_PROMIS10_Assessments();
		bool? b_ = this.Has_Encounter_with_Initial_and_Follow_Up_PROMIS29_Assessments();
		bool? c_ = context.Operators.Or(a_, b_);
		bool? d_ = this.Has_Encounter_with_Initial_and_Follow_Up_VR12_Oblique_Assessments();
		bool? e_ = context.Operators.Or(c_, d_);
		bool? f_ = this.Has_Encounter_with_Initial_and_Follow_Up_VR12_Orthogonal_Assessments();
		bool? g_ = context.Operators.Or(e_, f_);
		bool? h_ = this.Has_Encounter_with_Initial_and_Follow_Up_VR36_Oblique_Assessments();
		bool? i_ = context.Operators.Or(g_, h_);
		bool? j_ = this.Has_Encounter_with_Initial_and_Follow_Up_VR36_Orthogonal_Assessments();
		bool? k_ = context.Operators.Or(i_, j_);
		bool? l_ = this.Has_Encounter_with_Initial_and_Follow_Up_MLHFQ_Assessments();
		bool? m_ = context.Operators.Or(k_, l_);
		bool? n_ = this.Has_Encounter_with_Initial_and_Follow_Up_KCCQ12_Assessments();
		bool? o_ = context.Operators.Or(m_, n_);
		bool? p_ = this.Has_Encounter_with_Initial_and_Follow_Up_KCCQ_Domain_Score_Assessments();
		bool? q_ = context.Operators.Or(o_, p_);
		bool? r_ = this.Has_Encounter_with_Initial_and_Follow_Up_KCCQ_Total_Score_Assessments();
		bool? s_ = context.Operators.Or(q_, r_);

		return s_;
	}

    [CqlDeclaration("Numerator")]
	public bool? Numerator() => 
		__Numerator.Value;

}
