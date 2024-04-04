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
    internal Lazy<Tuples.Tuple_DMgHTLENEHBHWJISQgKZGZVMB> __SDE_Ethnicity;
    internal Lazy<IEnumerable<Tuples.Tuple_GDKRbfOIHhLGieQSVDEMIaDPX>> __SDE_Payer;
    internal Lazy<Tuples.Tuple_DMgHTLENEHBHWJISQgKZGZVMB> __SDE_Race;
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
        __SDE_Ethnicity = new Lazy<Tuples.Tuple_DMgHTLENEHBHWJISQgKZGZVMB>(this.SDE_Ethnicity_Value);
        __SDE_Payer = new Lazy<IEnumerable<Tuples.Tuple_GDKRbfOIHhLGieQSVDEMIaDPX>>(this.SDE_Payer_Value);
        __SDE_Race = new Lazy<Tuples.Tuple_DMgHTLENEHBHWJISQgKZGZVMB>(this.SDE_Race_Value);
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
		var a_ = new CqlCode[]
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
		var a_ = new CqlCode[]
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
		var a_ = context.Operators.ConvertIntegerToDecimal(default);
		var b_ = context.Operators.DateTime((int?)2025, (int?)1, (int?)1, (int?)0, (int?)0, (int?)0, (int?)0, a_);
		var d_ = context.Operators.DateTime((int?)2026, (int?)1, (int?)1, (int?)0, (int?)0, (int?)0, (int?)0, a_);
		var e_ = context.Operators.Interval(b_, d_, true, false);
		var f_ = context.ResolveParameter("FunctionalStatusAssessmentsforHeartFailureFHIR-0.1.000", "Measurement Period", e_);

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

	private IEnumerable<Encounter> Qualifying_Encounters_Value()
	{
		var a_ = this.Office_Visit();
		var b_ = context.Operators.RetrieveByValueSet<Encounter>(a_, null);
		var c_ = this.Telephone_Visits();
		var d_ = context.Operators.RetrieveByValueSet<Encounter>(c_, null);
		var e_ = context.Operators.ListUnion<Encounter>(b_, d_);
		var f_ = this.Online_Assessments();
		var g_ = context.Operators.RetrieveByValueSet<Encounter>(f_, null);
		var h_ = context.Operators.ListUnion<Encounter>(e_, g_);
		var i_ = Status_1_6_000.Finished_Encounter(h_);
		bool? j_(Encounter ValidEncounter)
		{
			var l_ = this.Measurement_Period();
			var m_ = FHIRHelpers_4_3_000.ToInterval(ValidEncounter?.Period);
			var n_ = QICoreCommon_2_0_000.ToInterval((m_ as object));
			var o_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(l_, n_, "day");

			return o_;
		};
		var k_ = context.Operators.WhereOrNull<Encounter>(i_, j_);

		return k_;
	}

    [CqlDeclaration("Qualifying Encounters")]
	public IEnumerable<Encounter> Qualifying_Encounters() => 
		__Qualifying_Encounters.Value;

	private IEnumerable<Encounter> Two_Outpatient_Encounters_during_Measurement_Period_Value()
	{
		var a_ = this.Qualifying_Encounters();
		IEnumerable<Encounter> b_(Encounter _OfficeVisit1)
		{
			var i_ = this.Qualifying_Encounters();

			return i_;
		};
		Tuples.Tuple_FGYJHhbRRZTDGeEKJQJIIbGUe c_(Encounter _OfficeVisit1, Encounter _OfficeVisit2)
		{
			var j_ = new Tuples.Tuple_FGYJHhbRRZTDGeEKJQJIIbGUe
			{
				OfficeVisit1 = _OfficeVisit1,
				OfficeVisit2 = _OfficeVisit2,
			};

			return j_;
		};
		var d_ = context.Operators.SelectManyResultsOrNull<Encounter, Encounter, Tuples.Tuple_FGYJHhbRRZTDGeEKJQJIIbGUe>(a_, b_, c_);
		bool? e_(Tuples.Tuple_FGYJHhbRRZTDGeEKJQJIIbGUe tuple_fgyjhhbrrztdgeekjqjiibgue)
		{
			var k_ = FHIRHelpers_4_3_000.ToInterval(tuple_fgyjhhbrrztdgeekjqjiibgue.OfficeVisit2?.Period);
			var l_ = QICoreCommon_2_0_000.ToInterval((k_ as object));
			var m_ = context.Operators.Start(l_);
			var n_ = FHIRHelpers_4_3_000.ToInterval(tuple_fgyjhhbrrztdgeekjqjiibgue.OfficeVisit1?.Period);
			var o_ = QICoreCommon_2_0_000.ToInterval((n_ as object));
			var p_ = context.Operators.End(o_);
			var q_ = context.Operators.Quantity(1m, "day");
			var r_ = context.Operators.Add(p_, q_);
			var s_ = context.Operators.SameOrAfter(m_, r_, "day");

			return s_;
		};
		var f_ = context.Operators.WhereOrNull<Tuples.Tuple_FGYJHhbRRZTDGeEKJQJIIbGUe>(d_, e_);
		Encounter g_(Tuples.Tuple_FGYJHhbRRZTDGeEKJQJIIbGUe tuple_fgyjhhbrrztdgeekjqjiibgue) => 
			tuple_fgyjhhbrrztdgeekjqjiibgue.OfficeVisit1;
		var h_ = context.Operators.SelectOrNull<Tuples.Tuple_FGYJHhbRRZTDGeEKJQJIIbGUe, Encounter>(f_, g_);

		return h_;
	}

    [CqlDeclaration("Two Outpatient Encounters during Measurement Period")]
	public IEnumerable<Encounter> Two_Outpatient_Encounters_during_Measurement_Period() => 
		__Two_Outpatient_Encounters_during_Measurement_Period.Value;

	private bool? Initial_Population_Value()
	{
		var a_ = this.Patient();
		var b_ = context.Operators.Convert<CqlDate>(a_?.BirthDateElement?.Value);
		var c_ = this.Measurement_Period();
		var d_ = context.Operators.Start(c_);
		var e_ = context.Operators.DateFrom(d_);
		var f_ = context.Operators.CalculateAgeAt(b_, e_, "year");
		var g_ = context.Operators.GreaterOrEqual(f_, (int?)18);
		var h_ = this.Heart_Failure();
		var i_ = context.Operators.RetrieveByValueSet<Condition>(h_, null);
		bool? j_(Condition HeartFailure)
		{
			var q_ = QICoreCommon_2_0_000.ToPrevalenceInterval(HeartFailure);
			var r_ = this.Measurement_Period();
			var s_ = context.Operators.OverlapsBefore(q_, r_, null);

			return s_;
		};
		var k_ = context.Operators.WhereOrNull<Condition>(i_, j_);
		var l_ = context.Operators.ExistsInList<Condition>(k_);
		var m_ = context.Operators.And(g_, l_);
		var n_ = this.Two_Outpatient_Encounters_during_Measurement_Period();
		var o_ = context.Operators.ExistsInList<Encounter>(n_);
		var p_ = context.Operators.And(m_, o_);

		return p_;
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

	private bool? Denominator_Exclusions_Value()
	{
		var a_ = Hospice_6_9_000.Has_Hospice_Services();
		var b_ = this.Severe_cognitive_impairment__finding_();
		var c_ = context.Operators.ToList<CqlCode>(b_);
		var d_ = context.Operators.RetrieveByCodes<Condition>(c_, null);
		bool? e_(Condition Dementia)
		{
			var i_ = QICoreCommon_2_0_000.ToPrevalenceInterval(Dementia);
			var j_ = this.Measurement_Period();
			var k_ = context.Operators.Overlaps(i_, j_, null);

			return k_;
		};
		var f_ = context.Operators.WhereOrNull<Condition>(d_, e_);
		var g_ = context.Operators.ExistsInList<Condition>(f_);
		var h_ = context.Operators.Or(a_, g_);

		return h_;
	}

    [CqlDeclaration("Denominator Exclusions")]
	public bool? Denominator_Exclusions() => 
		__Denominator_Exclusions.Value;

	private IEnumerable<CqlDate> Date_PROMIS10_Total_Assessment_Completed_Value()
	{
		var a_ = this.PROMIS_10_Global_Mental_Health__GMH__score_T_score();
		var b_ = context.Operators.ToList<CqlCode>(a_);
		var c_ = context.Operators.RetrieveByCodes<Observation>(b_, null);
		var d_ = Status_1_6_000.Final_Survey_Observation(c_);
		IEnumerable<Observation> e_(Observation _PROMIS10MentalScore)
		{
			var l_ = this.PROMIS_10_Global_Physical_Health__GPH__score_T_score();
			var m_ = context.Operators.ToList<CqlCode>(l_);
			var n_ = context.Operators.RetrieveByCodes<Observation>(m_, null);
			var o_ = Status_1_6_000.Final_Survey_Observation(n_);

			return o_;
		};
		Tuples.Tuple_CSQNXjbdUJCRVLSGAJQOISbPM f_(Observation _PROMIS10MentalScore, Observation _PROMIS10PhysicalScore)
		{
			var p_ = new Tuples.Tuple_CSQNXjbdUJCRVLSGAJQOISbPM
			{
				PROMIS10MentalScore = _PROMIS10MentalScore,
				PROMIS10PhysicalScore = _PROMIS10PhysicalScore,
			};

			return p_;
		};
		var g_ = context.Operators.SelectManyResultsOrNull<Observation, Observation, Tuples.Tuple_CSQNXjbdUJCRVLSGAJQOISbPM>(d_, e_, f_);
		bool? h_(Tuples.Tuple_CSQNXjbdUJCRVLSGAJQOISbPM tuple_csqnxjbdujcrvlsgajqoisbpm)
		{
			var q_ = FHIRHelpers_4_3_000.ToValue(tuple_csqnxjbdujcrvlsgajqoisbpm.PROMIS10MentalScore?.Effective);
			var r_ = QICoreCommon_2_0_000.ToInterval(q_);
			var s_ = context.Operators.Start(r_);
			var t_ = context.Operators.DateFrom(s_);
			var u_ = FHIRHelpers_4_3_000.ToValue(tuple_csqnxjbdujcrvlsgajqoisbpm.PROMIS10PhysicalScore?.Effective);
			var v_ = QICoreCommon_2_0_000.ToInterval(u_);
			var w_ = context.Operators.Start(v_);
			var x_ = context.Operators.DateFrom(w_);
			var y_ = context.Operators.SameAs(t_, x_, "day");
			var z_ = FHIRHelpers_4_3_000.ToValue(tuple_csqnxjbdujcrvlsgajqoisbpm.PROMIS10MentalScore?.Value);
			var aa_ = context.Operators.Not((bool?)(z_ is null));
			var ab_ = context.Operators.And(y_, aa_);
			var ac_ = FHIRHelpers_4_3_000.ToValue(tuple_csqnxjbdujcrvlsgajqoisbpm.PROMIS10PhysicalScore?.Value);
			var ad_ = context.Operators.Not((bool?)(ac_ is null));
			var ae_ = context.Operators.And(ab_, ad_);

			return ae_;
		};
		var i_ = context.Operators.WhereOrNull<Tuples.Tuple_CSQNXjbdUJCRVLSGAJQOISbPM>(g_, h_);
		CqlDate j_(Tuples.Tuple_CSQNXjbdUJCRVLSGAJQOISbPM tuple_csqnxjbdujcrvlsgajqoisbpm)
		{
			var af_ = FHIRHelpers_4_3_000.ToValue(tuple_csqnxjbdujcrvlsgajqoisbpm.PROMIS10MentalScore?.Effective);
			var ag_ = QICoreCommon_2_0_000.ToInterval(af_);
			var ah_ = context.Operators.Start(ag_);
			var ai_ = context.Operators.DateFrom(ah_);
			var aj_ = FHIRHelpers_4_3_000.ToValue(tuple_csqnxjbdujcrvlsgajqoisbpm.PROMIS10PhysicalScore?.Effective);
			var ak_ = QICoreCommon_2_0_000.ToInterval(aj_);
			var al_ = context.Operators.Start(ak_);
			var am_ = context.Operators.DateFrom(al_);
			var an_ = new CqlDate[]
			{
				ai_,
				am_,
			};
			var ao_ = context.Operators.MaxOrNull<CqlDate>((an_ as IEnumerable<CqlDate>));

			return ao_;
		};
		var k_ = context.Operators.SelectOrNull<Tuples.Tuple_CSQNXjbdUJCRVLSGAJQOISbPM, CqlDate>(i_, j_);

		return k_;
	}

    [CqlDeclaration("Date PROMIS10 Total Assessment Completed")]
	public IEnumerable<CqlDate> Date_PROMIS10_Total_Assessment_Completed() => 
		__Date_PROMIS10_Total_Assessment_Completed.Value;

	private bool? Has_Encounter_with_Initial_and_Follow_Up_PROMIS10_Assessments_Value()
	{
		var a_ = this.Qualifying_Encounters();
		IEnumerable<CqlDate> b_(Encounter _ValidEncounters)
		{
			var m_ = this.Date_PROMIS10_Total_Assessment_Completed();

			return m_;
		};
		Tuples.Tuple_BaPOXCdQPieFFFdPRAYQHJVMK c_(Encounter _ValidEncounters, CqlDate _InitialPROMIS10Date)
		{
			var n_ = new Tuples.Tuple_BaPOXCdQPieFFFdPRAYQHJVMK
			{
				ValidEncounters = _ValidEncounters,
				InitialPROMIS10Date = _InitialPROMIS10Date,
			};

			return n_;
		};
		var d_ = context.Operators.SelectManyResultsOrNull<Encounter, CqlDate, Tuples.Tuple_BaPOXCdQPieFFFdPRAYQHJVMK>(a_, b_, c_);
		IEnumerable<CqlDate> e_(Tuples.Tuple_BaPOXCdQPieFFFdPRAYQHJVMK _ValidEncountersInitialPROMIS10Date)
		{
			var o_ = this.Date_PROMIS10_Total_Assessment_Completed();

			return o_;
		};
		Tuples.Tuple_BaPOXCdQPieFFFdPRAYQHJVMK f_(Tuples.Tuple_BaPOXCdQPieFFFdPRAYQHJVMK ValidEncountersInitialPROMIS10Date, CqlDate _FollowupPROMIS10Date)
		{
			var p_ = new Tuples.Tuple_BaPOXCdQPieFFFdPRAYQHJVMK
			{
				ValidEncounters = ValidEncountersInitialPROMIS10Date.ValidEncounters,
				InitialPROMIS10Date = ValidEncountersInitialPROMIS10Date.InitialPROMIS10Date,
				FollowupPROMIS10Date = _FollowupPROMIS10Date,
			};

			return p_;
		};
		var g_ = context.Operators.SelectManyResultsOrNull<Tuples.Tuple_BaPOXCdQPieFFFdPRAYQHJVMK, CqlDate, Tuples.Tuple_BaPOXCdQPieFFFdPRAYQHJVMK>(d_, e_, f_);
		bool? h_(Tuples.Tuple_BaPOXCdQPieFFFdPRAYQHJVMK tuple_bapoxcdqpiefffdprayqhjvmk)
		{
			var q_ = FHIRHelpers_4_3_000.ToInterval(tuple_bapoxcdqpiefffdprayqhjvmk.ValidEncounters?.Period);
			var r_ = QICoreCommon_2_0_000.ToInterval((q_ as object));
			var s_ = context.Operators.End(r_);
			var t_ = this.Measurement_Period();
			var u_ = context.Operators.End(t_);
			var v_ = context.Operators.Quantity(180m, "days");
			var w_ = context.Operators.Subtract(u_, v_);
			var x_ = context.Operators.SameOrBefore(s_, w_, "day");
			var y_ = context.Operators.ConvertDateToDateTime(tuple_bapoxcdqpiefffdprayqhjvmk.InitialPROMIS10Date);
			var aa_ = QICoreCommon_2_0_000.ToInterval((q_ as object));
			var ab_ = context.Operators.End(aa_);
			var ac_ = context.Operators.Quantity(14m, "days");
			var ad_ = context.Operators.Subtract(ab_, ac_);
			var af_ = QICoreCommon_2_0_000.ToInterval((q_ as object));
			var ag_ = context.Operators.End(af_);
			var ah_ = context.Operators.Interval(ad_, ag_, true, true);
			var ai_ = context.Operators.ElementInInterval<CqlDateTime>(y_, ah_, "day");
			var ak_ = QICoreCommon_2_0_000.ToInterval((q_ as object));
			var al_ = context.Operators.End(ak_);
			var am_ = context.Operators.Not((bool?)(al_ is null));
			var an_ = context.Operators.And(ai_, am_);
			var ao_ = context.Operators.And(x_, an_);
			var ap_ = context.Operators.ConvertDateToDateTime(tuple_bapoxcdqpiefffdprayqhjvmk.FollowupPROMIS10Date);
			var aq_ = context.Operators.DateFrom(ap_);
			var as_ = context.Operators.DateFrom(y_);
			var at_ = context.Operators.Quantity(30m, "days");
			var au_ = context.Operators.Add(as_, at_);
			var aw_ = context.Operators.DateFrom(y_);
			var ay_ = context.Operators.Add(aw_, v_);
			var az_ = context.Operators.Interval(au_, ay_, true, true);
			var ba_ = context.Operators.ElementInInterval<CqlDate>(aq_, az_, "day");
			var bb_ = context.Operators.And(ao_, ba_);

			return bb_;
		};
		var i_ = context.Operators.WhereOrNull<Tuples.Tuple_BaPOXCdQPieFFFdPRAYQHJVMK>(g_, h_);
		Encounter j_(Tuples.Tuple_BaPOXCdQPieFFFdPRAYQHJVMK tuple_bapoxcdqpiefffdprayqhjvmk) => 
			tuple_bapoxcdqpiefffdprayqhjvmk.ValidEncounters;
		var k_ = context.Operators.SelectOrNull<Tuples.Tuple_BaPOXCdQPieFFFdPRAYQHJVMK, Encounter>(i_, j_);
		var l_ = context.Operators.ExistsInList<Encounter>(k_);

		return l_;
	}

    [CqlDeclaration("Has Encounter with Initial and Follow Up PROMIS10 Assessments")]
	public bool? Has_Encounter_with_Initial_and_Follow_Up_PROMIS10_Assessments() => 
		__Has_Encounter_with_Initial_and_Follow_Up_PROMIS10_Assessments.Value;

	private IEnumerable<CqlDate> Date_PROMIS29_Total_Assessment_Completed_Value()
	{
		var a_ = this.PROMIS_29_Sleep_disturbance_score_T_score();
		var b_ = context.Operators.ToList<CqlCode>(a_);
		var c_ = context.Operators.RetrieveByCodes<Observation>(b_, null);
		var d_ = Status_1_6_000.Final_Survey_Observation(c_);
		IEnumerable<Observation> e_(Observation _Promis29Sleep)
		{
			var aa_ = this.PROMIS_29_Satisfaction_with_participation_in_social_roles_score_T_score();
			var ab_ = context.Operators.ToList<CqlCode>(aa_);
			var ac_ = context.Operators.RetrieveByCodes<Observation>(ab_, null);
			var ad_ = Status_1_6_000.Final_Survey_Observation(ac_);

			return ad_;
		};
		Tuples.Tuple_ITZjeBeBSEgNiFGcLhJYIJNb f_(Observation _Promis29Sleep, Observation _Promis29SocialRoles)
		{
			var ae_ = new Tuples.Tuple_ITZjeBeBSEgNiFGcLhJYIJNb
			{
				Promis29Sleep = _Promis29Sleep,
				Promis29SocialRoles = _Promis29SocialRoles,
			};

			return ae_;
		};
		var g_ = context.Operators.SelectManyResultsOrNull<Observation, Observation, Tuples.Tuple_ITZjeBeBSEgNiFGcLhJYIJNb>(d_, e_, f_);
		IEnumerable<Observation> h_(Tuples.Tuple_ITZjeBeBSEgNiFGcLhJYIJNb _Promis29SleepPromis29SocialRoles)
		{
			var af_ = this.PROMIS_29_Physical_function_score_T_score();
			var ag_ = context.Operators.ToList<CqlCode>(af_);
			var ah_ = context.Operators.RetrieveByCodes<Observation>(ag_, null);
			var ai_ = Status_1_6_000.Final_Survey_Observation(ah_);

			return ai_;
		};
		Tuples.Tuple_ITZjeBeBSEgNiFGcLhJYIJNb i_(Tuples.Tuple_ITZjeBeBSEgNiFGcLhJYIJNb Promis29SleepPromis29SocialRoles, Observation _Promis29Physical)
		{
			var aj_ = new Tuples.Tuple_ITZjeBeBSEgNiFGcLhJYIJNb
			{
				Promis29Sleep = Promis29SleepPromis29SocialRoles.Promis29Sleep,
				Promis29SocialRoles = Promis29SleepPromis29SocialRoles.Promis29SocialRoles,
				Promis29Physical = _Promis29Physical,
			};

			return aj_;
		};
		var j_ = context.Operators.SelectManyResultsOrNull<Tuples.Tuple_ITZjeBeBSEgNiFGcLhJYIJNb, Observation, Tuples.Tuple_ITZjeBeBSEgNiFGcLhJYIJNb>(g_, h_, i_);
		IEnumerable<Observation> k_(Tuples.Tuple_ITZjeBeBSEgNiFGcLhJYIJNb _Promis29SleepPromis29SocialRolesPromis29Physical)
		{
			var ak_ = this.PROMIS_29_Pain_interference_score_T_score();
			var al_ = context.Operators.ToList<CqlCode>(ak_);
			var am_ = context.Operators.RetrieveByCodes<Observation>(al_, null);
			var an_ = Status_1_6_000.Final_Survey_Observation(am_);

			return an_;
		};
		Tuples.Tuple_ITZjeBeBSEgNiFGcLhJYIJNb l_(Tuples.Tuple_ITZjeBeBSEgNiFGcLhJYIJNb Promis29SleepPromis29SocialRolesPromis29Physical, Observation _Promis29Pain)
		{
			var ao_ = new Tuples.Tuple_ITZjeBeBSEgNiFGcLhJYIJNb
			{
				Promis29Sleep = Promis29SleepPromis29SocialRolesPromis29Physical.Promis29Sleep,
				Promis29SocialRoles = Promis29SleepPromis29SocialRolesPromis29Physical.Promis29SocialRoles,
				Promis29Physical = Promis29SleepPromis29SocialRolesPromis29Physical.Promis29Physical,
				Promis29Pain = _Promis29Pain,
			};

			return ao_;
		};
		var m_ = context.Operators.SelectManyResultsOrNull<Tuples.Tuple_ITZjeBeBSEgNiFGcLhJYIJNb, Observation, Tuples.Tuple_ITZjeBeBSEgNiFGcLhJYIJNb>(j_, k_, l_);
		IEnumerable<Observation> n_(Tuples.Tuple_ITZjeBeBSEgNiFGcLhJYIJNb _Promis29SleepPromis29SocialRolesPromis29PhysicalPromis29Pain)
		{
			var ap_ = this.PROMIS_29_Fatigue_score_T_score();
			var aq_ = context.Operators.ToList<CqlCode>(ap_);
			var ar_ = context.Operators.RetrieveByCodes<Observation>(aq_, null);
			var as_ = Status_1_6_000.Final_Survey_Observation(ar_);

			return as_;
		};
		Tuples.Tuple_ITZjeBeBSEgNiFGcLhJYIJNb o_(Tuples.Tuple_ITZjeBeBSEgNiFGcLhJYIJNb Promis29SleepPromis29SocialRolesPromis29PhysicalPromis29Pain, Observation _Promis29Fatigue)
		{
			var at_ = new Tuples.Tuple_ITZjeBeBSEgNiFGcLhJYIJNb
			{
				Promis29Sleep = Promis29SleepPromis29SocialRolesPromis29PhysicalPromis29Pain.Promis29Sleep,
				Promis29SocialRoles = Promis29SleepPromis29SocialRolesPromis29PhysicalPromis29Pain.Promis29SocialRoles,
				Promis29Physical = Promis29SleepPromis29SocialRolesPromis29PhysicalPromis29Pain.Promis29Physical,
				Promis29Pain = Promis29SleepPromis29SocialRolesPromis29PhysicalPromis29Pain.Promis29Pain,
				Promis29Fatigue = _Promis29Fatigue,
			};

			return at_;
		};
		var p_ = context.Operators.SelectManyResultsOrNull<Tuples.Tuple_ITZjeBeBSEgNiFGcLhJYIJNb, Observation, Tuples.Tuple_ITZjeBeBSEgNiFGcLhJYIJNb>(m_, n_, o_);
		IEnumerable<Observation> q_(Tuples.Tuple_ITZjeBeBSEgNiFGcLhJYIJNb _Promis29SleepPromis29SocialRolesPromis29PhysicalPromis29PainPromis29Fatigue)
		{
			var au_ = this.PROMIS_29_Depression_score_T_score();
			var av_ = context.Operators.ToList<CqlCode>(au_);
			var aw_ = context.Operators.RetrieveByCodes<Observation>(av_, null);
			var ax_ = Status_1_6_000.Final_Survey_Observation(aw_);

			return ax_;
		};
		Tuples.Tuple_ITZjeBeBSEgNiFGcLhJYIJNb r_(Tuples.Tuple_ITZjeBeBSEgNiFGcLhJYIJNb Promis29SleepPromis29SocialRolesPromis29PhysicalPromis29PainPromis29Fatigue, Observation _Promis29Depression)
		{
			var ay_ = new Tuples.Tuple_ITZjeBeBSEgNiFGcLhJYIJNb
			{
				Promis29Sleep = Promis29SleepPromis29SocialRolesPromis29PhysicalPromis29PainPromis29Fatigue.Promis29Sleep,
				Promis29SocialRoles = Promis29SleepPromis29SocialRolesPromis29PhysicalPromis29PainPromis29Fatigue.Promis29SocialRoles,
				Promis29Physical = Promis29SleepPromis29SocialRolesPromis29PhysicalPromis29PainPromis29Fatigue.Promis29Physical,
				Promis29Pain = Promis29SleepPromis29SocialRolesPromis29PhysicalPromis29PainPromis29Fatigue.Promis29Pain,
				Promis29Fatigue = Promis29SleepPromis29SocialRolesPromis29PhysicalPromis29PainPromis29Fatigue.Promis29Fatigue,
				Promis29Depression = _Promis29Depression,
			};

			return ay_;
		};
		var s_ = context.Operators.SelectManyResultsOrNull<Tuples.Tuple_ITZjeBeBSEgNiFGcLhJYIJNb, Observation, Tuples.Tuple_ITZjeBeBSEgNiFGcLhJYIJNb>(p_, q_, r_);
		IEnumerable<Observation> t_(Tuples.Tuple_ITZjeBeBSEgNiFGcLhJYIJNb _Promis29SleepPromis29SocialRolesPromis29PhysicalPromis29PainPromis29FatiguePromis29Depression)
		{
			var az_ = this.PROMIS_29_Anxiety_score_T_score();
			var ba_ = context.Operators.ToList<CqlCode>(az_);
			var bb_ = context.Operators.RetrieveByCodes<Observation>(ba_, null);
			var bc_ = Status_1_6_000.Final_Survey_Observation(bb_);

			return bc_;
		};
		Tuples.Tuple_ITZjeBeBSEgNiFGcLhJYIJNb u_(Tuples.Tuple_ITZjeBeBSEgNiFGcLhJYIJNb Promis29SleepPromis29SocialRolesPromis29PhysicalPromis29PainPromis29FatiguePromis29Depression, Observation _Promis29Anxiety)
		{
			var bd_ = new Tuples.Tuple_ITZjeBeBSEgNiFGcLhJYIJNb
			{
				Promis29Sleep = Promis29SleepPromis29SocialRolesPromis29PhysicalPromis29PainPromis29FatiguePromis29Depression.Promis29Sleep,
				Promis29SocialRoles = Promis29SleepPromis29SocialRolesPromis29PhysicalPromis29PainPromis29FatiguePromis29Depression.Promis29SocialRoles,
				Promis29Physical = Promis29SleepPromis29SocialRolesPromis29PhysicalPromis29PainPromis29FatiguePromis29Depression.Promis29Physical,
				Promis29Pain = Promis29SleepPromis29SocialRolesPromis29PhysicalPromis29PainPromis29FatiguePromis29Depression.Promis29Pain,
				Promis29Fatigue = Promis29SleepPromis29SocialRolesPromis29PhysicalPromis29PainPromis29FatiguePromis29Depression.Promis29Fatigue,
				Promis29Depression = Promis29SleepPromis29SocialRolesPromis29PhysicalPromis29PainPromis29FatiguePromis29Depression.Promis29Depression,
				Promis29Anxiety = _Promis29Anxiety,
			};

			return bd_;
		};
		var v_ = context.Operators.SelectManyResultsOrNull<Tuples.Tuple_ITZjeBeBSEgNiFGcLhJYIJNb, Observation, Tuples.Tuple_ITZjeBeBSEgNiFGcLhJYIJNb>(s_, t_, u_);
		bool? w_(Tuples.Tuple_ITZjeBeBSEgNiFGcLhJYIJNb tuple_itzjebebsegnifgclhjyijnb)
		{
			var be_ = FHIRHelpers_4_3_000.ToValue(tuple_itzjebebsegnifgclhjyijnb.Promis29Sleep?.Effective);
			var bf_ = QICoreCommon_2_0_000.ToInterval(be_);
			var bg_ = context.Operators.Start(bf_);
			var bh_ = context.Operators.DateFrom(bg_);
			var bi_ = FHIRHelpers_4_3_000.ToValue(tuple_itzjebebsegnifgclhjyijnb.Promis29SocialRoles?.Effective);
			var bj_ = QICoreCommon_2_0_000.ToInterval(bi_);
			var bk_ = context.Operators.Start(bj_);
			var bl_ = context.Operators.DateFrom(bk_);
			var bm_ = context.Operators.SameAs(bh_, bl_, "day");
			var bn_ = FHIRHelpers_4_3_000.ToValue(tuple_itzjebebsegnifgclhjyijnb.Promis29SocialRoles?.Value);
			var bo_ = context.Operators.Not((bool?)(bn_ is null));
			var bp_ = context.Operators.And(bm_, bo_);
			var br_ = QICoreCommon_2_0_000.ToInterval(be_);
			var bs_ = context.Operators.Start(br_);
			var bt_ = context.Operators.DateFrom(bs_);
			var bu_ = FHIRHelpers_4_3_000.ToValue(tuple_itzjebebsegnifgclhjyijnb.Promis29Physical?.Effective);
			var bv_ = QICoreCommon_2_0_000.ToInterval(bu_);
			var bw_ = context.Operators.Start(bv_);
			var bx_ = context.Operators.DateFrom(bw_);
			var by_ = context.Operators.SameAs(bt_, bx_, "day");
			var bz_ = context.Operators.And(bp_, by_);
			var ca_ = FHIRHelpers_4_3_000.ToValue(tuple_itzjebebsegnifgclhjyijnb.Promis29Physical?.Value);
			var cb_ = context.Operators.Not((bool?)(ca_ is null));
			var cc_ = context.Operators.And(bz_, cb_);
			var ce_ = QICoreCommon_2_0_000.ToInterval(be_);
			var cf_ = context.Operators.Start(ce_);
			var cg_ = context.Operators.DateFrom(cf_);
			var ch_ = FHIRHelpers_4_3_000.ToValue(tuple_itzjebebsegnifgclhjyijnb.Promis29Pain?.Effective);
			var ci_ = QICoreCommon_2_0_000.ToInterval(ch_);
			var cj_ = context.Operators.Start(ci_);
			var ck_ = context.Operators.DateFrom(cj_);
			var cl_ = context.Operators.SameAs(cg_, ck_, "day");
			var cm_ = context.Operators.And(cc_, cl_);
			var cn_ = FHIRHelpers_4_3_000.ToValue(tuple_itzjebebsegnifgclhjyijnb.Promis29Pain?.Value);
			var co_ = context.Operators.Not((bool?)(cn_ is null));
			var cp_ = context.Operators.And(cm_, co_);
			var cr_ = QICoreCommon_2_0_000.ToInterval(be_);
			var cs_ = context.Operators.Start(cr_);
			var ct_ = context.Operators.DateFrom(cs_);
			var cu_ = FHIRHelpers_4_3_000.ToValue(tuple_itzjebebsegnifgclhjyijnb.Promis29Fatigue?.Effective);
			var cv_ = QICoreCommon_2_0_000.ToInterval(cu_);
			var cw_ = context.Operators.Start(cv_);
			var cx_ = context.Operators.DateFrom(cw_);
			var cy_ = context.Operators.SameAs(ct_, cx_, "day");
			var cz_ = context.Operators.And(cp_, cy_);
			var da_ = FHIRHelpers_4_3_000.ToValue(tuple_itzjebebsegnifgclhjyijnb.Promis29Fatigue?.Value);
			var db_ = context.Operators.Not((bool?)(da_ is null));
			var dc_ = context.Operators.And(cz_, db_);
			var de_ = QICoreCommon_2_0_000.ToInterval(be_);
			var df_ = context.Operators.Start(de_);
			var dg_ = context.Operators.DateFrom(df_);
			var dh_ = FHIRHelpers_4_3_000.ToValue(tuple_itzjebebsegnifgclhjyijnb.Promis29Depression?.Effective);
			var di_ = QICoreCommon_2_0_000.ToInterval(dh_);
			var dj_ = context.Operators.Start(di_);
			var dk_ = context.Operators.DateFrom(dj_);
			var dl_ = context.Operators.SameAs(dg_, dk_, "day");
			var dm_ = context.Operators.And(dc_, dl_);
			var dn_ = FHIRHelpers_4_3_000.ToValue(tuple_itzjebebsegnifgclhjyijnb.Promis29Depression?.Value);
			var do_ = context.Operators.Not((bool?)(dn_ is null));
			var dp_ = context.Operators.And(dm_, do_);
			var dr_ = QICoreCommon_2_0_000.ToInterval(be_);
			var ds_ = context.Operators.Start(dr_);
			var dt_ = context.Operators.DateFrom(ds_);
			var du_ = FHIRHelpers_4_3_000.ToValue(tuple_itzjebebsegnifgclhjyijnb.Promis29Anxiety?.Effective);
			var dv_ = QICoreCommon_2_0_000.ToInterval(du_);
			var dw_ = context.Operators.Start(dv_);
			var dx_ = context.Operators.DateFrom(dw_);
			var dy_ = context.Operators.SameAs(dt_, dx_, "day");
			var dz_ = context.Operators.And(dp_, dy_);
			var ea_ = FHIRHelpers_4_3_000.ToValue(tuple_itzjebebsegnifgclhjyijnb.Promis29Anxiety?.Value);
			var eb_ = context.Operators.Not((bool?)(ea_ is null));
			var ec_ = context.Operators.And(dz_, eb_);
			var ed_ = FHIRHelpers_4_3_000.ToValue(tuple_itzjebebsegnifgclhjyijnb.Promis29Sleep?.Value);
			var ee_ = context.Operators.Not((bool?)(ed_ is null));
			var ef_ = context.Operators.And(ec_, ee_);

			return ef_;
		};
		var x_ = context.Operators.WhereOrNull<Tuples.Tuple_ITZjeBeBSEgNiFGcLhJYIJNb>(v_, w_);
		CqlDate y_(Tuples.Tuple_ITZjeBeBSEgNiFGcLhJYIJNb tuple_itzjebebsegnifgclhjyijnb)
		{
			var eg_ = FHIRHelpers_4_3_000.ToValue(tuple_itzjebebsegnifgclhjyijnb.Promis29Sleep?.Effective);
			var eh_ = QICoreCommon_2_0_000.ToInterval(eg_);
			var ei_ = context.Operators.Start(eh_);
			var ej_ = context.Operators.DateFrom(ei_);
			var ek_ = FHIRHelpers_4_3_000.ToValue(tuple_itzjebebsegnifgclhjyijnb.Promis29SocialRoles?.Effective);
			var el_ = QICoreCommon_2_0_000.ToInterval(ek_);
			var em_ = context.Operators.Start(el_);
			var en_ = context.Operators.DateFrom(em_);
			var eo_ = FHIRHelpers_4_3_000.ToValue(tuple_itzjebebsegnifgclhjyijnb.Promis29Physical?.Effective);
			var ep_ = QICoreCommon_2_0_000.ToInterval(eo_);
			var eq_ = context.Operators.Start(ep_);
			var er_ = context.Operators.DateFrom(eq_);
			var es_ = FHIRHelpers_4_3_000.ToValue(tuple_itzjebebsegnifgclhjyijnb.Promis29Pain?.Effective);
			var et_ = QICoreCommon_2_0_000.ToInterval(es_);
			var eu_ = context.Operators.Start(et_);
			var ev_ = context.Operators.DateFrom(eu_);
			var ew_ = FHIRHelpers_4_3_000.ToValue(tuple_itzjebebsegnifgclhjyijnb.Promis29Fatigue?.Effective);
			var ex_ = QICoreCommon_2_0_000.ToInterval(ew_);
			var ey_ = context.Operators.Start(ex_);
			var ez_ = context.Operators.DateFrom(ey_);
			var fa_ = FHIRHelpers_4_3_000.ToValue(tuple_itzjebebsegnifgclhjyijnb.Promis29Depression?.Effective);
			var fb_ = QICoreCommon_2_0_000.ToInterval(fa_);
			var fc_ = context.Operators.Start(fb_);
			var fd_ = context.Operators.DateFrom(fc_);
			var fe_ = FHIRHelpers_4_3_000.ToValue(tuple_itzjebebsegnifgclhjyijnb.Promis29Anxiety?.Effective);
			var ff_ = QICoreCommon_2_0_000.ToInterval(fe_);
			var fg_ = context.Operators.Start(ff_);
			var fh_ = context.Operators.DateFrom(fg_);
			var fi_ = new CqlDate[]
			{
				ej_,
				en_,
				er_,
				ev_,
				ez_,
				fd_,
				fh_,
			};
			var fj_ = context.Operators.MaxOrNull<CqlDate>((fi_ as IEnumerable<CqlDate>));

			return fj_;
		};
		var z_ = context.Operators.SelectOrNull<Tuples.Tuple_ITZjeBeBSEgNiFGcLhJYIJNb, CqlDate>(x_, y_);

		return z_;
	}

    [CqlDeclaration("Date PROMIS29 Total Assessment Completed")]
	public IEnumerable<CqlDate> Date_PROMIS29_Total_Assessment_Completed() => 
		__Date_PROMIS29_Total_Assessment_Completed.Value;

	private bool? Has_Encounter_with_Initial_and_Follow_Up_PROMIS29_Assessments_Value()
	{
		var a_ = this.Qualifying_Encounters();
		IEnumerable<CqlDate> b_(Encounter _ValidEncounters)
		{
			var m_ = this.Date_PROMIS29_Total_Assessment_Completed();

			return m_;
		};
		Tuples.Tuple_DcgYAFMUGiITLMLBigQTHXaba c_(Encounter _ValidEncounters, CqlDate _InitialPROMIS29Date)
		{
			var n_ = new Tuples.Tuple_DcgYAFMUGiITLMLBigQTHXaba
			{
				ValidEncounters = _ValidEncounters,
				InitialPROMIS29Date = _InitialPROMIS29Date,
			};

			return n_;
		};
		var d_ = context.Operators.SelectManyResultsOrNull<Encounter, CqlDate, Tuples.Tuple_DcgYAFMUGiITLMLBigQTHXaba>(a_, b_, c_);
		IEnumerable<CqlDate> e_(Tuples.Tuple_DcgYAFMUGiITLMLBigQTHXaba _ValidEncountersInitialPROMIS29Date)
		{
			var o_ = this.Date_PROMIS29_Total_Assessment_Completed();

			return o_;
		};
		Tuples.Tuple_DcgYAFMUGiITLMLBigQTHXaba f_(Tuples.Tuple_DcgYAFMUGiITLMLBigQTHXaba ValidEncountersInitialPROMIS29Date, CqlDate _FollowupPROMIS29Date)
		{
			var p_ = new Tuples.Tuple_DcgYAFMUGiITLMLBigQTHXaba
			{
				ValidEncounters = ValidEncountersInitialPROMIS29Date.ValidEncounters,
				InitialPROMIS29Date = ValidEncountersInitialPROMIS29Date.InitialPROMIS29Date,
				FollowupPROMIS29Date = _FollowupPROMIS29Date,
			};

			return p_;
		};
		var g_ = context.Operators.SelectManyResultsOrNull<Tuples.Tuple_DcgYAFMUGiITLMLBigQTHXaba, CqlDate, Tuples.Tuple_DcgYAFMUGiITLMLBigQTHXaba>(d_, e_, f_);
		bool? h_(Tuples.Tuple_DcgYAFMUGiITLMLBigQTHXaba tuple_dcgyafmugiitlmlbigqthxaba)
		{
			var q_ = FHIRHelpers_4_3_000.ToInterval(tuple_dcgyafmugiitlmlbigqthxaba.ValidEncounters?.Period);
			var r_ = QICoreCommon_2_0_000.ToInterval((q_ as object));
			var s_ = context.Operators.End(r_);
			var t_ = this.Measurement_Period();
			var u_ = context.Operators.End(t_);
			var v_ = context.Operators.Quantity(180m, "days");
			var w_ = context.Operators.Subtract(u_, v_);
			var x_ = context.Operators.SameOrBefore(s_, w_, "day");
			var y_ = context.Operators.ConvertDateToDateTime(tuple_dcgyafmugiitlmlbigqthxaba.InitialPROMIS29Date);
			var aa_ = QICoreCommon_2_0_000.ToInterval((q_ as object));
			var ab_ = context.Operators.End(aa_);
			var ac_ = context.Operators.Quantity(14m, "days");
			var ad_ = context.Operators.Subtract(ab_, ac_);
			var af_ = QICoreCommon_2_0_000.ToInterval((q_ as object));
			var ag_ = context.Operators.End(af_);
			var ah_ = context.Operators.Interval(ad_, ag_, true, true);
			var ai_ = context.Operators.ElementInInterval<CqlDateTime>(y_, ah_, "day");
			var ak_ = QICoreCommon_2_0_000.ToInterval((q_ as object));
			var al_ = context.Operators.End(ak_);
			var am_ = context.Operators.Not((bool?)(al_ is null));
			var an_ = context.Operators.And(ai_, am_);
			var ao_ = context.Operators.And(x_, an_);
			var ap_ = context.Operators.ConvertDateToDateTime(tuple_dcgyafmugiitlmlbigqthxaba.FollowupPROMIS29Date);
			var aq_ = context.Operators.DateFrom(ap_);
			var as_ = context.Operators.DateFrom(y_);
			var at_ = context.Operators.Quantity(30m, "days");
			var au_ = context.Operators.Add(as_, at_);
			var aw_ = context.Operators.DateFrom(y_);
			var ay_ = context.Operators.Add(aw_, v_);
			var az_ = context.Operators.Interval(au_, ay_, true, true);
			var ba_ = context.Operators.ElementInInterval<CqlDate>(aq_, az_, "day");
			var bb_ = context.Operators.And(ao_, ba_);

			return bb_;
		};
		var i_ = context.Operators.WhereOrNull<Tuples.Tuple_DcgYAFMUGiITLMLBigQTHXaba>(g_, h_);
		Encounter j_(Tuples.Tuple_DcgYAFMUGiITLMLBigQTHXaba tuple_dcgyafmugiitlmlbigqthxaba) => 
			tuple_dcgyafmugiitlmlbigqthxaba.ValidEncounters;
		var k_ = context.Operators.SelectOrNull<Tuples.Tuple_DcgYAFMUGiITLMLBigQTHXaba, Encounter>(i_, j_);
		var l_ = context.Operators.ExistsInList<Encounter>(k_);

		return l_;
	}

    [CqlDeclaration("Has Encounter with Initial and Follow Up PROMIS29 Assessments")]
	public bool? Has_Encounter_with_Initial_and_Follow_Up_PROMIS29_Assessments() => 
		__Has_Encounter_with_Initial_and_Follow_Up_PROMIS29_Assessments.Value;

	private IEnumerable<CqlDate> Date_VR12_Oblique_Total_Assessment_Completed_Value()
	{
		var a_ = this.VR_12_Mental_component_summary__MCS__score___oblique_method_T_score();
		var b_ = context.Operators.ToList<CqlCode>(a_);
		var c_ = context.Operators.RetrieveByCodes<Observation>(b_, null);
		var d_ = Status_1_6_000.Final_Survey_Observation(c_);
		IEnumerable<Observation> e_(Observation _VR12MentalAssessment)
		{
			var l_ = this.VR_12_Physical_component_summary__PCS__score___oblique_method_T_score();
			var m_ = context.Operators.ToList<CqlCode>(l_);
			var n_ = context.Operators.RetrieveByCodes<Observation>(m_, null);
			var o_ = Status_1_6_000.Final_Survey_Observation(n_);

			return o_;
		};
		Tuples.Tuple_aWLEFJMGFWIGJKOEOKKQfQiJ f_(Observation _VR12MentalAssessment, Observation _VR12PhysicalAssessment)
		{
			var p_ = new Tuples.Tuple_aWLEFJMGFWIGJKOEOKKQfQiJ
			{
				VR12MentalAssessment = _VR12MentalAssessment,
				VR12PhysicalAssessment = _VR12PhysicalAssessment,
			};

			return p_;
		};
		var g_ = context.Operators.SelectManyResultsOrNull<Observation, Observation, Tuples.Tuple_aWLEFJMGFWIGJKOEOKKQfQiJ>(d_, e_, f_);
		bool? h_(Tuples.Tuple_aWLEFJMGFWIGJKOEOKKQfQiJ tuple_awlefjmgfwigjkoeokkqfqij)
		{
			var q_ = FHIRHelpers_4_3_000.ToValue(tuple_awlefjmgfwigjkoeokkqfqij.VR12MentalAssessment?.Effective);
			var r_ = QICoreCommon_2_0_000.ToInterval(q_);
			var s_ = context.Operators.Start(r_);
			var t_ = context.Operators.DateFrom(s_);
			var u_ = FHIRHelpers_4_3_000.ToValue(tuple_awlefjmgfwigjkoeokkqfqij.VR12PhysicalAssessment?.Effective);
			var v_ = QICoreCommon_2_0_000.ToInterval(u_);
			var w_ = context.Operators.Start(v_);
			var x_ = context.Operators.DateFrom(w_);
			var y_ = context.Operators.SameAs(t_, x_, "day");
			var z_ = FHIRHelpers_4_3_000.ToValue(tuple_awlefjmgfwigjkoeokkqfqij.VR12MentalAssessment?.Value);
			var aa_ = context.Operators.Not((bool?)(z_ is null));
			var ab_ = context.Operators.And(y_, aa_);
			var ac_ = FHIRHelpers_4_3_000.ToValue(tuple_awlefjmgfwigjkoeokkqfqij.VR12PhysicalAssessment?.Value);
			var ad_ = context.Operators.Not((bool?)(ac_ is null));
			var ae_ = context.Operators.And(ab_, ad_);

			return ae_;
		};
		var i_ = context.Operators.WhereOrNull<Tuples.Tuple_aWLEFJMGFWIGJKOEOKKQfQiJ>(g_, h_);
		CqlDate j_(Tuples.Tuple_aWLEFJMGFWIGJKOEOKKQfQiJ tuple_awlefjmgfwigjkoeokkqfqij)
		{
			var af_ = FHIRHelpers_4_3_000.ToValue(tuple_awlefjmgfwigjkoeokkqfqij.VR12MentalAssessment?.Effective);
			var ag_ = QICoreCommon_2_0_000.ToInterval(af_);
			var ah_ = context.Operators.Start(ag_);
			var ai_ = context.Operators.DateFrom(ah_);
			var aj_ = FHIRHelpers_4_3_000.ToValue(tuple_awlefjmgfwigjkoeokkqfqij.VR12PhysicalAssessment?.Effective);
			var ak_ = QICoreCommon_2_0_000.ToInterval(aj_);
			var al_ = context.Operators.Start(ak_);
			var am_ = context.Operators.DateFrom(al_);
			var an_ = new CqlDate[]
			{
				ai_,
				am_,
			};
			var ao_ = context.Operators.MaxOrNull<CqlDate>((an_ as IEnumerable<CqlDate>));

			return ao_;
		};
		var k_ = context.Operators.SelectOrNull<Tuples.Tuple_aWLEFJMGFWIGJKOEOKKQfQiJ, CqlDate>(i_, j_);

		return k_;
	}

    [CqlDeclaration("Date VR12 Oblique Total Assessment Completed")]
	public IEnumerable<CqlDate> Date_VR12_Oblique_Total_Assessment_Completed() => 
		__Date_VR12_Oblique_Total_Assessment_Completed.Value;

	private bool? Has_Encounter_with_Initial_and_Follow_Up_VR12_Oblique_Assessments_Value()
	{
		var a_ = this.Qualifying_Encounters();
		IEnumerable<CqlDate> b_(Encounter _ValidEncounters)
		{
			var m_ = this.Date_VR12_Oblique_Total_Assessment_Completed();

			return m_;
		};
		Tuples.Tuple_EhGfQcQTPMaVGfjeRNgbDIGOU c_(Encounter _ValidEncounters, CqlDate _InitialVR12ObliqueDate)
		{
			var n_ = new Tuples.Tuple_EhGfQcQTPMaVGfjeRNgbDIGOU
			{
				ValidEncounters = _ValidEncounters,
				InitialVR12ObliqueDate = _InitialVR12ObliqueDate,
			};

			return n_;
		};
		var d_ = context.Operators.SelectManyResultsOrNull<Encounter, CqlDate, Tuples.Tuple_EhGfQcQTPMaVGfjeRNgbDIGOU>(a_, b_, c_);
		IEnumerable<CqlDate> e_(Tuples.Tuple_EhGfQcQTPMaVGfjeRNgbDIGOU _ValidEncountersInitialVR12ObliqueDate)
		{
			var o_ = this.Date_VR12_Oblique_Total_Assessment_Completed();

			return o_;
		};
		Tuples.Tuple_EhGfQcQTPMaVGfjeRNgbDIGOU f_(Tuples.Tuple_EhGfQcQTPMaVGfjeRNgbDIGOU ValidEncountersInitialVR12ObliqueDate, CqlDate _FollowupVR12ObliqueDate)
		{
			var p_ = new Tuples.Tuple_EhGfQcQTPMaVGfjeRNgbDIGOU
			{
				ValidEncounters = ValidEncountersInitialVR12ObliqueDate.ValidEncounters,
				InitialVR12ObliqueDate = ValidEncountersInitialVR12ObliqueDate.InitialVR12ObliqueDate,
				FollowupVR12ObliqueDate = _FollowupVR12ObliqueDate,
			};

			return p_;
		};
		var g_ = context.Operators.SelectManyResultsOrNull<Tuples.Tuple_EhGfQcQTPMaVGfjeRNgbDIGOU, CqlDate, Tuples.Tuple_EhGfQcQTPMaVGfjeRNgbDIGOU>(d_, e_, f_);
		bool? h_(Tuples.Tuple_EhGfQcQTPMaVGfjeRNgbDIGOU tuple_ehgfqcqtpmavgfjerngbdigou)
		{
			var q_ = FHIRHelpers_4_3_000.ToInterval(tuple_ehgfqcqtpmavgfjerngbdigou.ValidEncounters?.Period);
			var r_ = QICoreCommon_2_0_000.ToInterval((q_ as object));
			var s_ = context.Operators.End(r_);
			var t_ = this.Measurement_Period();
			var u_ = context.Operators.End(t_);
			var v_ = context.Operators.Quantity(180m, "days");
			var w_ = context.Operators.Subtract(u_, v_);
			var x_ = context.Operators.SameOrBefore(s_, w_, "day");
			var y_ = context.Operators.ConvertDateToDateTime(tuple_ehgfqcqtpmavgfjerngbdigou.InitialVR12ObliqueDate);
			var aa_ = QICoreCommon_2_0_000.ToInterval((q_ as object));
			var ab_ = context.Operators.End(aa_);
			var ac_ = context.Operators.Quantity(14m, "days");
			var ad_ = context.Operators.Subtract(ab_, ac_);
			var af_ = QICoreCommon_2_0_000.ToInterval((q_ as object));
			var ag_ = context.Operators.End(af_);
			var ah_ = context.Operators.Interval(ad_, ag_, true, true);
			var ai_ = context.Operators.ElementInInterval<CqlDateTime>(y_, ah_, "day");
			var ak_ = QICoreCommon_2_0_000.ToInterval((q_ as object));
			var al_ = context.Operators.End(ak_);
			var am_ = context.Operators.Not((bool?)(al_ is null));
			var an_ = context.Operators.And(ai_, am_);
			var ao_ = context.Operators.And(x_, an_);
			var ap_ = context.Operators.ConvertDateToDateTime(tuple_ehgfqcqtpmavgfjerngbdigou.FollowupVR12ObliqueDate);
			var aq_ = context.Operators.DateFrom(ap_);
			var as_ = context.Operators.DateFrom(y_);
			var at_ = context.Operators.Quantity(30m, "days");
			var au_ = context.Operators.Add(as_, at_);
			var aw_ = context.Operators.DateFrom(y_);
			var ay_ = context.Operators.Add(aw_, v_);
			var az_ = context.Operators.Interval(au_, ay_, true, true);
			var ba_ = context.Operators.ElementInInterval<CqlDate>(aq_, az_, "day");
			var bb_ = context.Operators.And(ao_, ba_);

			return bb_;
		};
		var i_ = context.Operators.WhereOrNull<Tuples.Tuple_EhGfQcQTPMaVGfjeRNgbDIGOU>(g_, h_);
		Encounter j_(Tuples.Tuple_EhGfQcQTPMaVGfjeRNgbDIGOU tuple_ehgfqcqtpmavgfjerngbdigou) => 
			tuple_ehgfqcqtpmavgfjerngbdigou.ValidEncounters;
		var k_ = context.Operators.SelectOrNull<Tuples.Tuple_EhGfQcQTPMaVGfjeRNgbDIGOU, Encounter>(i_, j_);
		var l_ = context.Operators.ExistsInList<Encounter>(k_);

		return l_;
	}

    [CqlDeclaration("Has Encounter with Initial and Follow Up VR12 Oblique Assessments")]
	public bool? Has_Encounter_with_Initial_and_Follow_Up_VR12_Oblique_Assessments() => 
		__Has_Encounter_with_Initial_and_Follow_Up_VR12_Oblique_Assessments.Value;

	private IEnumerable<CqlDate> Date_VR12_Orthogonal_Total_Assessment_Completed_Value()
	{
		var a_ = this.VR_12_Mental_component_summary__MCS__score___orthogonal_method_T_score();
		var b_ = context.Operators.ToList<CqlCode>(a_);
		var c_ = context.Operators.RetrieveByCodes<Observation>(b_, null);
		var d_ = Status_1_6_000.Final_Survey_Observation(c_);
		IEnumerable<Observation> e_(Observation _VR12MentalAssessment)
		{
			var l_ = this.VR_12_Physical_component_summary__PCS__score___orthogonal_method_T_score();
			var m_ = context.Operators.ToList<CqlCode>(l_);
			var n_ = context.Operators.RetrieveByCodes<Observation>(m_, null);
			var o_ = Status_1_6_000.Final_Survey_Observation(n_);

			return o_;
		};
		Tuples.Tuple_aWLEFJMGFWIGJKOEOKKQfQiJ f_(Observation _VR12MentalAssessment, Observation _VR12PhysicalAssessment)
		{
			var p_ = new Tuples.Tuple_aWLEFJMGFWIGJKOEOKKQfQiJ
			{
				VR12MentalAssessment = _VR12MentalAssessment,
				VR12PhysicalAssessment = _VR12PhysicalAssessment,
			};

			return p_;
		};
		var g_ = context.Operators.SelectManyResultsOrNull<Observation, Observation, Tuples.Tuple_aWLEFJMGFWIGJKOEOKKQfQiJ>(d_, e_, f_);
		bool? h_(Tuples.Tuple_aWLEFJMGFWIGJKOEOKKQfQiJ tuple_awlefjmgfwigjkoeokkqfqij)
		{
			var q_ = FHIRHelpers_4_3_000.ToValue(tuple_awlefjmgfwigjkoeokkqfqij.VR12MentalAssessment?.Effective);
			var r_ = QICoreCommon_2_0_000.ToInterval(q_);
			var s_ = context.Operators.Start(r_);
			var t_ = context.Operators.DateFrom(s_);
			var u_ = FHIRHelpers_4_3_000.ToValue(tuple_awlefjmgfwigjkoeokkqfqij.VR12PhysicalAssessment?.Effective);
			var v_ = QICoreCommon_2_0_000.ToInterval(u_);
			var w_ = context.Operators.Start(v_);
			var x_ = context.Operators.DateFrom(w_);
			var y_ = context.Operators.SameAs(t_, x_, "day");
			var z_ = FHIRHelpers_4_3_000.ToValue(tuple_awlefjmgfwigjkoeokkqfqij.VR12MentalAssessment?.Value);
			var aa_ = context.Operators.Not((bool?)(z_ is null));
			var ab_ = context.Operators.And(y_, aa_);
			var ac_ = FHIRHelpers_4_3_000.ToValue(tuple_awlefjmgfwigjkoeokkqfqij.VR12PhysicalAssessment?.Value);
			var ad_ = context.Operators.Not((bool?)(ac_ is null));
			var ae_ = context.Operators.And(ab_, ad_);

			return ae_;
		};
		var i_ = context.Operators.WhereOrNull<Tuples.Tuple_aWLEFJMGFWIGJKOEOKKQfQiJ>(g_, h_);
		CqlDate j_(Tuples.Tuple_aWLEFJMGFWIGJKOEOKKQfQiJ tuple_awlefjmgfwigjkoeokkqfqij)
		{
			var af_ = FHIRHelpers_4_3_000.ToValue(tuple_awlefjmgfwigjkoeokkqfqij.VR12MentalAssessment?.Effective);
			var ag_ = QICoreCommon_2_0_000.ToInterval(af_);
			var ah_ = context.Operators.Start(ag_);
			var ai_ = context.Operators.DateFrom(ah_);
			var aj_ = FHIRHelpers_4_3_000.ToValue(tuple_awlefjmgfwigjkoeokkqfqij.VR12PhysicalAssessment?.Effective);
			var ak_ = QICoreCommon_2_0_000.ToInterval(aj_);
			var al_ = context.Operators.Start(ak_);
			var am_ = context.Operators.DateFrom(al_);
			var an_ = new CqlDate[]
			{
				ai_,
				am_,
			};
			var ao_ = context.Operators.MaxOrNull<CqlDate>((an_ as IEnumerable<CqlDate>));

			return ao_;
		};
		var k_ = context.Operators.SelectOrNull<Tuples.Tuple_aWLEFJMGFWIGJKOEOKKQfQiJ, CqlDate>(i_, j_);

		return k_;
	}

    [CqlDeclaration("Date VR12 Orthogonal Total Assessment Completed")]
	public IEnumerable<CqlDate> Date_VR12_Orthogonal_Total_Assessment_Completed() => 
		__Date_VR12_Orthogonal_Total_Assessment_Completed.Value;

	private bool? Has_Encounter_with_Initial_and_Follow_Up_VR12_Orthogonal_Assessments_Value()
	{
		var a_ = this.Qualifying_Encounters();
		IEnumerable<CqlDate> b_(Encounter _ValidEncounters)
		{
			var m_ = this.Date_VR12_Orthogonal_Total_Assessment_Completed();

			return m_;
		};
		Tuples.Tuple_DaTHNXWGHIVRYGRfGdXJYJKRZ c_(Encounter _ValidEncounters, CqlDate _InitialVR12OrthogonalDate)
		{
			var n_ = new Tuples.Tuple_DaTHNXWGHIVRYGRfGdXJYJKRZ
			{
				ValidEncounters = _ValidEncounters,
				InitialVR12OrthogonalDate = _InitialVR12OrthogonalDate,
			};

			return n_;
		};
		var d_ = context.Operators.SelectManyResultsOrNull<Encounter, CqlDate, Tuples.Tuple_DaTHNXWGHIVRYGRfGdXJYJKRZ>(a_, b_, c_);
		IEnumerable<CqlDate> e_(Tuples.Tuple_DaTHNXWGHIVRYGRfGdXJYJKRZ _ValidEncountersInitialVR12OrthogonalDate)
		{
			var o_ = this.Date_VR12_Orthogonal_Total_Assessment_Completed();

			return o_;
		};
		Tuples.Tuple_DaTHNXWGHIVRYGRfGdXJYJKRZ f_(Tuples.Tuple_DaTHNXWGHIVRYGRfGdXJYJKRZ ValidEncountersInitialVR12OrthogonalDate, CqlDate _FollowupVR12OrthogonalDate)
		{
			var p_ = new Tuples.Tuple_DaTHNXWGHIVRYGRfGdXJYJKRZ
			{
				ValidEncounters = ValidEncountersInitialVR12OrthogonalDate.ValidEncounters,
				InitialVR12OrthogonalDate = ValidEncountersInitialVR12OrthogonalDate.InitialVR12OrthogonalDate,
				FollowupVR12OrthogonalDate = _FollowupVR12OrthogonalDate,
			};

			return p_;
		};
		var g_ = context.Operators.SelectManyResultsOrNull<Tuples.Tuple_DaTHNXWGHIVRYGRfGdXJYJKRZ, CqlDate, Tuples.Tuple_DaTHNXWGHIVRYGRfGdXJYJKRZ>(d_, e_, f_);
		bool? h_(Tuples.Tuple_DaTHNXWGHIVRYGRfGdXJYJKRZ tuple_dathnxwghivrygrfgdxjyjkrz)
		{
			var q_ = FHIRHelpers_4_3_000.ToInterval(tuple_dathnxwghivrygrfgdxjyjkrz.ValidEncounters?.Period);
			var r_ = QICoreCommon_2_0_000.ToInterval((q_ as object));
			var s_ = context.Operators.End(r_);
			var t_ = this.Measurement_Period();
			var u_ = context.Operators.End(t_);
			var v_ = context.Operators.Quantity(180m, "days");
			var w_ = context.Operators.Subtract(u_, v_);
			var x_ = context.Operators.SameOrBefore(s_, w_, "day");
			var y_ = context.Operators.ConvertDateToDateTime(tuple_dathnxwghivrygrfgdxjyjkrz.InitialVR12OrthogonalDate);
			var aa_ = QICoreCommon_2_0_000.ToInterval((q_ as object));
			var ab_ = context.Operators.End(aa_);
			var ac_ = context.Operators.Quantity(14m, "days");
			var ad_ = context.Operators.Subtract(ab_, ac_);
			var af_ = QICoreCommon_2_0_000.ToInterval((q_ as object));
			var ag_ = context.Operators.End(af_);
			var ah_ = context.Operators.Interval(ad_, ag_, true, true);
			var ai_ = context.Operators.ElementInInterval<CqlDateTime>(y_, ah_, "day");
			var ak_ = QICoreCommon_2_0_000.ToInterval((q_ as object));
			var al_ = context.Operators.End(ak_);
			var am_ = context.Operators.Not((bool?)(al_ is null));
			var an_ = context.Operators.And(ai_, am_);
			var ao_ = context.Operators.And(x_, an_);
			var ap_ = context.Operators.ConvertDateToDateTime(tuple_dathnxwghivrygrfgdxjyjkrz.FollowupVR12OrthogonalDate);
			var aq_ = context.Operators.DateFrom(ap_);
			var as_ = context.Operators.DateFrom(y_);
			var at_ = context.Operators.Quantity(30m, "days");
			var au_ = context.Operators.Add(as_, at_);
			var aw_ = context.Operators.DateFrom(y_);
			var ay_ = context.Operators.Add(aw_, v_);
			var az_ = context.Operators.Interval(au_, ay_, true, true);
			var ba_ = context.Operators.ElementInInterval<CqlDate>(aq_, az_, "day");
			var bb_ = context.Operators.And(ao_, ba_);

			return bb_;
		};
		var i_ = context.Operators.WhereOrNull<Tuples.Tuple_DaTHNXWGHIVRYGRfGdXJYJKRZ>(g_, h_);
		Encounter j_(Tuples.Tuple_DaTHNXWGHIVRYGRfGdXJYJKRZ tuple_dathnxwghivrygrfgdxjyjkrz) => 
			tuple_dathnxwghivrygrfgdxjyjkrz.ValidEncounters;
		var k_ = context.Operators.SelectOrNull<Tuples.Tuple_DaTHNXWGHIVRYGRfGdXJYJKRZ, Encounter>(i_, j_);
		var l_ = context.Operators.ExistsInList<Encounter>(k_);

		return l_;
	}

    [CqlDeclaration("Has Encounter with Initial and Follow Up VR12 Orthogonal Assessments")]
	public bool? Has_Encounter_with_Initial_and_Follow_Up_VR12_Orthogonal_Assessments() => 
		__Has_Encounter_with_Initial_and_Follow_Up_VR12_Orthogonal_Assessments.Value;

	private IEnumerable<CqlDate> Date_VR36_Oblique_Total_Assessment_Completed_Value()
	{
		var a_ = this.VR_36_Mental_component_summary__MCS__score___oblique_method_T_score();
		var b_ = context.Operators.ToList<CqlCode>(a_);
		var c_ = context.Operators.RetrieveByCodes<Observation>(b_, null);
		var d_ = Status_1_6_000.Final_Survey_Observation(c_);
		IEnumerable<Observation> e_(Observation _VR36MentalAssessment)
		{
			var l_ = this.VR_36_Physical_component_summary__PCS__score___oblique_method_T_score();
			var m_ = context.Operators.ToList<CqlCode>(l_);
			var n_ = context.Operators.RetrieveByCodes<Observation>(m_, null);
			var o_ = Status_1_6_000.Final_Survey_Observation(n_);

			return o_;
		};
		Tuples.Tuple_EbSJTAdMHbBibBKjAIBeBhcjh f_(Observation _VR36MentalAssessment, Observation _VR36PhysicalAssessment)
		{
			var p_ = new Tuples.Tuple_EbSJTAdMHbBibBKjAIBeBhcjh
			{
				VR36MentalAssessment = _VR36MentalAssessment,
				VR36PhysicalAssessment = _VR36PhysicalAssessment,
			};

			return p_;
		};
		var g_ = context.Operators.SelectManyResultsOrNull<Observation, Observation, Tuples.Tuple_EbSJTAdMHbBibBKjAIBeBhcjh>(d_, e_, f_);
		bool? h_(Tuples.Tuple_EbSJTAdMHbBibBKjAIBeBhcjh tuple_ebsjtadmhbbibbkjaibebhcjh)
		{
			var q_ = FHIRHelpers_4_3_000.ToValue(tuple_ebsjtadmhbbibbkjaibebhcjh.VR36MentalAssessment?.Effective);
			var r_ = QICoreCommon_2_0_000.ToInterval(q_);
			var s_ = context.Operators.Start(r_);
			var t_ = context.Operators.DateFrom(s_);
			var u_ = FHIRHelpers_4_3_000.ToValue(tuple_ebsjtadmhbbibbkjaibebhcjh.VR36PhysicalAssessment?.Effective);
			var v_ = QICoreCommon_2_0_000.ToInterval(u_);
			var w_ = context.Operators.Start(v_);
			var x_ = context.Operators.DateFrom(w_);
			var y_ = context.Operators.SameAs(t_, x_, "day");
			var z_ = FHIRHelpers_4_3_000.ToValue(tuple_ebsjtadmhbbibbkjaibebhcjh.VR36MentalAssessment?.Value);
			var aa_ = context.Operators.Not((bool?)(z_ is null));
			var ab_ = context.Operators.And(y_, aa_);
			var ac_ = FHIRHelpers_4_3_000.ToValue(tuple_ebsjtadmhbbibbkjaibebhcjh.VR36PhysicalAssessment?.Value);
			var ad_ = context.Operators.Not((bool?)(ac_ is null));
			var ae_ = context.Operators.And(ab_, ad_);

			return ae_;
		};
		var i_ = context.Operators.WhereOrNull<Tuples.Tuple_EbSJTAdMHbBibBKjAIBeBhcjh>(g_, h_);
		CqlDate j_(Tuples.Tuple_EbSJTAdMHbBibBKjAIBeBhcjh tuple_ebsjtadmhbbibbkjaibebhcjh)
		{
			var af_ = FHIRHelpers_4_3_000.ToValue(tuple_ebsjtadmhbbibbkjaibebhcjh.VR36MentalAssessment?.Effective);
			var ag_ = QICoreCommon_2_0_000.ToInterval(af_);
			var ah_ = context.Operators.Start(ag_);
			var ai_ = context.Operators.DateFrom(ah_);
			var aj_ = FHIRHelpers_4_3_000.ToValue(tuple_ebsjtadmhbbibbkjaibebhcjh.VR36PhysicalAssessment?.Effective);
			var ak_ = QICoreCommon_2_0_000.ToInterval(aj_);
			var al_ = context.Operators.Start(ak_);
			var am_ = context.Operators.DateFrom(al_);
			var an_ = new CqlDate[]
			{
				ai_,
				am_,
			};
			var ao_ = context.Operators.MaxOrNull<CqlDate>((an_ as IEnumerable<CqlDate>));

			return ao_;
		};
		var k_ = context.Operators.SelectOrNull<Tuples.Tuple_EbSJTAdMHbBibBKjAIBeBhcjh, CqlDate>(i_, j_);

		return k_;
	}

    [CqlDeclaration("Date VR36 Oblique Total Assessment Completed")]
	public IEnumerable<CqlDate> Date_VR36_Oblique_Total_Assessment_Completed() => 
		__Date_VR36_Oblique_Total_Assessment_Completed.Value;

	private bool? Has_Encounter_with_Initial_and_Follow_Up_VR36_Oblique_Assessments_Value()
	{
		var a_ = this.Qualifying_Encounters();
		IEnumerable<CqlDate> b_(Encounter _ValidEncounters)
		{
			var m_ = this.Date_VR36_Oblique_Total_Assessment_Completed();

			return m_;
		};
		Tuples.Tuple_HNUZSEJfeiQXIhXGUDXLiWidi c_(Encounter _ValidEncounters, CqlDate _InitialVR36ObliqueDate)
		{
			var n_ = new Tuples.Tuple_HNUZSEJfeiQXIhXGUDXLiWidi
			{
				ValidEncounters = _ValidEncounters,
				InitialVR36ObliqueDate = _InitialVR36ObliqueDate,
			};

			return n_;
		};
		var d_ = context.Operators.SelectManyResultsOrNull<Encounter, CqlDate, Tuples.Tuple_HNUZSEJfeiQXIhXGUDXLiWidi>(a_, b_, c_);
		IEnumerable<CqlDate> e_(Tuples.Tuple_HNUZSEJfeiQXIhXGUDXLiWidi _ValidEncountersInitialVR36ObliqueDate)
		{
			var o_ = this.Date_VR36_Oblique_Total_Assessment_Completed();

			return o_;
		};
		Tuples.Tuple_HNUZSEJfeiQXIhXGUDXLiWidi f_(Tuples.Tuple_HNUZSEJfeiQXIhXGUDXLiWidi ValidEncountersInitialVR36ObliqueDate, CqlDate _FollowupVR36ObliqueDate)
		{
			var p_ = new Tuples.Tuple_HNUZSEJfeiQXIhXGUDXLiWidi
			{
				ValidEncounters = ValidEncountersInitialVR36ObliqueDate.ValidEncounters,
				InitialVR36ObliqueDate = ValidEncountersInitialVR36ObliqueDate.InitialVR36ObliqueDate,
				FollowupVR36ObliqueDate = _FollowupVR36ObliqueDate,
			};

			return p_;
		};
		var g_ = context.Operators.SelectManyResultsOrNull<Tuples.Tuple_HNUZSEJfeiQXIhXGUDXLiWidi, CqlDate, Tuples.Tuple_HNUZSEJfeiQXIhXGUDXLiWidi>(d_, e_, f_);
		bool? h_(Tuples.Tuple_HNUZSEJfeiQXIhXGUDXLiWidi tuple_hnuzsejfeiqxihxgudxliwidi)
		{
			var q_ = FHIRHelpers_4_3_000.ToInterval(tuple_hnuzsejfeiqxihxgudxliwidi.ValidEncounters?.Period);
			var r_ = QICoreCommon_2_0_000.ToInterval((q_ as object));
			var s_ = context.Operators.End(r_);
			var t_ = this.Measurement_Period();
			var u_ = context.Operators.End(t_);
			var v_ = context.Operators.Quantity(180m, "days");
			var w_ = context.Operators.Subtract(u_, v_);
			var x_ = context.Operators.SameOrBefore(s_, w_, "day");
			var y_ = context.Operators.ConvertDateToDateTime(tuple_hnuzsejfeiqxihxgudxliwidi.InitialVR36ObliqueDate);
			var aa_ = QICoreCommon_2_0_000.ToInterval((q_ as object));
			var ab_ = context.Operators.End(aa_);
			var ac_ = context.Operators.Quantity(14m, "days");
			var ad_ = context.Operators.Subtract(ab_, ac_);
			var af_ = QICoreCommon_2_0_000.ToInterval((q_ as object));
			var ag_ = context.Operators.End(af_);
			var ah_ = context.Operators.Interval(ad_, ag_, true, true);
			var ai_ = context.Operators.ElementInInterval<CqlDateTime>(y_, ah_, "day");
			var ak_ = QICoreCommon_2_0_000.ToInterval((q_ as object));
			var al_ = context.Operators.End(ak_);
			var am_ = context.Operators.Not((bool?)(al_ is null));
			var an_ = context.Operators.And(ai_, am_);
			var ao_ = context.Operators.And(x_, an_);
			var ap_ = context.Operators.ConvertDateToDateTime(tuple_hnuzsejfeiqxihxgudxliwidi.FollowupVR36ObliqueDate);
			var aq_ = context.Operators.DateFrom(ap_);
			var as_ = context.Operators.DateFrom(y_);
			var at_ = context.Operators.Quantity(30m, "days");
			var au_ = context.Operators.Add(as_, at_);
			var aw_ = context.Operators.DateFrom(y_);
			var ay_ = context.Operators.Add(aw_, v_);
			var az_ = context.Operators.Interval(au_, ay_, true, true);
			var ba_ = context.Operators.ElementInInterval<CqlDate>(aq_, az_, "day");
			var bb_ = context.Operators.And(ao_, ba_);

			return bb_;
		};
		var i_ = context.Operators.WhereOrNull<Tuples.Tuple_HNUZSEJfeiQXIhXGUDXLiWidi>(g_, h_);
		Encounter j_(Tuples.Tuple_HNUZSEJfeiQXIhXGUDXLiWidi tuple_hnuzsejfeiqxihxgudxliwidi) => 
			tuple_hnuzsejfeiqxihxgudxliwidi.ValidEncounters;
		var k_ = context.Operators.SelectOrNull<Tuples.Tuple_HNUZSEJfeiQXIhXGUDXLiWidi, Encounter>(i_, j_);
		var l_ = context.Operators.ExistsInList<Encounter>(k_);

		return l_;
	}

    [CqlDeclaration("Has Encounter with Initial and Follow Up VR36 Oblique Assessments")]
	public bool? Has_Encounter_with_Initial_and_Follow_Up_VR36_Oblique_Assessments() => 
		__Has_Encounter_with_Initial_and_Follow_Up_VR36_Oblique_Assessments.Value;

	private IEnumerable<CqlDate> Date_VR36_Orthogonal_Total_Assessment_Completed_Value()
	{
		var a_ = this.VR_36_Mental_component_summary__MCS__score___orthogonal_method_T_score();
		var b_ = context.Operators.ToList<CqlCode>(a_);
		var c_ = context.Operators.RetrieveByCodes<Observation>(b_, null);
		var d_ = Status_1_6_000.Final_Survey_Observation(c_);
		IEnumerable<Observation> e_(Observation _VR36MentalAssessment)
		{
			var l_ = this.VR_36_Physical_component_summary__PCS__score___orthogonal_method_T_score();
			var m_ = context.Operators.ToList<CqlCode>(l_);
			var n_ = context.Operators.RetrieveByCodes<Observation>(m_, null);
			var o_ = Status_1_6_000.Final_Survey_Observation(n_);

			return o_;
		};
		Tuples.Tuple_EbSJTAdMHbBibBKjAIBeBhcjh f_(Observation _VR36MentalAssessment, Observation _VR36PhysicalAssessment)
		{
			var p_ = new Tuples.Tuple_EbSJTAdMHbBibBKjAIBeBhcjh
			{
				VR36MentalAssessment = _VR36MentalAssessment,
				VR36PhysicalAssessment = _VR36PhysicalAssessment,
			};

			return p_;
		};
		var g_ = context.Operators.SelectManyResultsOrNull<Observation, Observation, Tuples.Tuple_EbSJTAdMHbBibBKjAIBeBhcjh>(d_, e_, f_);
		bool? h_(Tuples.Tuple_EbSJTAdMHbBibBKjAIBeBhcjh tuple_ebsjtadmhbbibbkjaibebhcjh)
		{
			var q_ = FHIRHelpers_4_3_000.ToValue(tuple_ebsjtadmhbbibbkjaibebhcjh.VR36MentalAssessment?.Effective);
			var r_ = QICoreCommon_2_0_000.ToInterval(q_);
			var s_ = context.Operators.Start(r_);
			var t_ = context.Operators.DateFrom(s_);
			var u_ = FHIRHelpers_4_3_000.ToValue(tuple_ebsjtadmhbbibbkjaibebhcjh.VR36PhysicalAssessment?.Effective);
			var v_ = QICoreCommon_2_0_000.ToInterval(u_);
			var w_ = context.Operators.Start(v_);
			var x_ = context.Operators.DateFrom(w_);
			var y_ = context.Operators.SameAs(t_, x_, "day");
			var z_ = FHIRHelpers_4_3_000.ToValue(tuple_ebsjtadmhbbibbkjaibebhcjh.VR36MentalAssessment?.Value);
			var aa_ = context.Operators.Not((bool?)(z_ is null));
			var ab_ = context.Operators.And(y_, aa_);
			var ac_ = FHIRHelpers_4_3_000.ToValue(tuple_ebsjtadmhbbibbkjaibebhcjh.VR36PhysicalAssessment?.Value);
			var ad_ = context.Operators.Not((bool?)(ac_ is null));
			var ae_ = context.Operators.And(ab_, ad_);

			return ae_;
		};
		var i_ = context.Operators.WhereOrNull<Tuples.Tuple_EbSJTAdMHbBibBKjAIBeBhcjh>(g_, h_);
		CqlDate j_(Tuples.Tuple_EbSJTAdMHbBibBKjAIBeBhcjh tuple_ebsjtadmhbbibbkjaibebhcjh)
		{
			var af_ = FHIRHelpers_4_3_000.ToValue(tuple_ebsjtadmhbbibbkjaibebhcjh.VR36MentalAssessment?.Effective);
			var ag_ = QICoreCommon_2_0_000.ToInterval(af_);
			var ah_ = context.Operators.Start(ag_);
			var ai_ = context.Operators.DateFrom(ah_);
			var aj_ = FHIRHelpers_4_3_000.ToValue(tuple_ebsjtadmhbbibbkjaibebhcjh.VR36PhysicalAssessment?.Effective);
			var ak_ = QICoreCommon_2_0_000.ToInterval(aj_);
			var al_ = context.Operators.Start(ak_);
			var am_ = context.Operators.DateFrom(al_);
			var an_ = new CqlDate[]
			{
				ai_,
				am_,
			};
			var ao_ = context.Operators.MaxOrNull<CqlDate>((an_ as IEnumerable<CqlDate>));

			return ao_;
		};
		var k_ = context.Operators.SelectOrNull<Tuples.Tuple_EbSJTAdMHbBibBKjAIBeBhcjh, CqlDate>(i_, j_);

		return k_;
	}

    [CqlDeclaration("Date VR36 Orthogonal Total Assessment Completed")]
	public IEnumerable<CqlDate> Date_VR36_Orthogonal_Total_Assessment_Completed() => 
		__Date_VR36_Orthogonal_Total_Assessment_Completed.Value;

	private bool? Has_Encounter_with_Initial_and_Follow_Up_VR36_Orthogonal_Assessments_Value()
	{
		var a_ = this.Qualifying_Encounters();
		IEnumerable<CqlDate> b_(Encounter _ValidEncounters)
		{
			var m_ = this.Date_VR36_Orthogonal_Total_Assessment_Completed();

			return m_;
		};
		Tuples.Tuple_FZFeLiXHKPLAfNDgWDMeScIDi c_(Encounter _ValidEncounters, CqlDate _InitialVR36OrthogonalDate)
		{
			var n_ = new Tuples.Tuple_FZFeLiXHKPLAfNDgWDMeScIDi
			{
				ValidEncounters = _ValidEncounters,
				InitialVR36OrthogonalDate = _InitialVR36OrthogonalDate,
			};

			return n_;
		};
		var d_ = context.Operators.SelectManyResultsOrNull<Encounter, CqlDate, Tuples.Tuple_FZFeLiXHKPLAfNDgWDMeScIDi>(a_, b_, c_);
		IEnumerable<CqlDate> e_(Tuples.Tuple_FZFeLiXHKPLAfNDgWDMeScIDi _ValidEncountersInitialVR36OrthogonalDate)
		{
			var o_ = this.Date_VR36_Orthogonal_Total_Assessment_Completed();

			return o_;
		};
		Tuples.Tuple_FZFeLiXHKPLAfNDgWDMeScIDi f_(Tuples.Tuple_FZFeLiXHKPLAfNDgWDMeScIDi ValidEncountersInitialVR36OrthogonalDate, CqlDate _FollowupVR36OrthogonalDate)
		{
			var p_ = new Tuples.Tuple_FZFeLiXHKPLAfNDgWDMeScIDi
			{
				ValidEncounters = ValidEncountersInitialVR36OrthogonalDate.ValidEncounters,
				InitialVR36OrthogonalDate = ValidEncountersInitialVR36OrthogonalDate.InitialVR36OrthogonalDate,
				FollowupVR36OrthogonalDate = _FollowupVR36OrthogonalDate,
			};

			return p_;
		};
		var g_ = context.Operators.SelectManyResultsOrNull<Tuples.Tuple_FZFeLiXHKPLAfNDgWDMeScIDi, CqlDate, Tuples.Tuple_FZFeLiXHKPLAfNDgWDMeScIDi>(d_, e_, f_);
		bool? h_(Tuples.Tuple_FZFeLiXHKPLAfNDgWDMeScIDi tuple_fzfelixhkplafndgwdmescidi)
		{
			var q_ = FHIRHelpers_4_3_000.ToInterval(tuple_fzfelixhkplafndgwdmescidi.ValidEncounters?.Period);
			var r_ = QICoreCommon_2_0_000.ToInterval((q_ as object));
			var s_ = context.Operators.End(r_);
			var t_ = this.Measurement_Period();
			var u_ = context.Operators.End(t_);
			var v_ = context.Operators.Quantity(180m, "days");
			var w_ = context.Operators.Subtract(u_, v_);
			var x_ = context.Operators.SameOrBefore(s_, w_, "day");
			var y_ = context.Operators.ConvertDateToDateTime(tuple_fzfelixhkplafndgwdmescidi.InitialVR36OrthogonalDate);
			var aa_ = QICoreCommon_2_0_000.ToInterval((q_ as object));
			var ab_ = context.Operators.End(aa_);
			var ac_ = context.Operators.Quantity(14m, "days");
			var ad_ = context.Operators.Subtract(ab_, ac_);
			var af_ = QICoreCommon_2_0_000.ToInterval((q_ as object));
			var ag_ = context.Operators.End(af_);
			var ah_ = context.Operators.Interval(ad_, ag_, true, true);
			var ai_ = context.Operators.ElementInInterval<CqlDateTime>(y_, ah_, "day");
			var ak_ = QICoreCommon_2_0_000.ToInterval((q_ as object));
			var al_ = context.Operators.End(ak_);
			var am_ = context.Operators.Not((bool?)(al_ is null));
			var an_ = context.Operators.And(ai_, am_);
			var ao_ = context.Operators.And(x_, an_);
			var ap_ = context.Operators.ConvertDateToDateTime(tuple_fzfelixhkplafndgwdmescidi.FollowupVR36OrthogonalDate);
			var aq_ = context.Operators.DateFrom(ap_);
			var as_ = context.Operators.DateFrom(y_);
			var at_ = context.Operators.Quantity(30m, "days");
			var au_ = context.Operators.Add(as_, at_);
			var aw_ = context.Operators.DateFrom(y_);
			var ay_ = context.Operators.Add(aw_, v_);
			var az_ = context.Operators.Interval(au_, ay_, true, true);
			var ba_ = context.Operators.ElementInInterval<CqlDate>(aq_, az_, "day");
			var bb_ = context.Operators.And(ao_, ba_);

			return bb_;
		};
		var i_ = context.Operators.WhereOrNull<Tuples.Tuple_FZFeLiXHKPLAfNDgWDMeScIDi>(g_, h_);
		Encounter j_(Tuples.Tuple_FZFeLiXHKPLAfNDgWDMeScIDi tuple_fzfelixhkplafndgwdmescidi) => 
			tuple_fzfelixhkplafndgwdmescidi.ValidEncounters;
		var k_ = context.Operators.SelectOrNull<Tuples.Tuple_FZFeLiXHKPLAfNDgWDMeScIDi, Encounter>(i_, j_);
		var l_ = context.Operators.ExistsInList<Encounter>(k_);

		return l_;
	}

    [CqlDeclaration("Has Encounter with Initial and Follow Up VR36 Orthogonal Assessments")]
	public bool? Has_Encounter_with_Initial_and_Follow_Up_VR36_Orthogonal_Assessments() => 
		__Has_Encounter_with_Initial_and_Follow_Up_VR36_Orthogonal_Assessments.Value;

	private IEnumerable<CqlDate> Date_MLHFQ_Total_Assessment_Completed_Value()
	{
		var a_ = this.Physical_score__MLHFQ_();
		var b_ = context.Operators.ToList<CqlCode>(a_);
		var c_ = context.Operators.RetrieveByCodes<Observation>(b_, null);
		var d_ = Status_1_6_000.Final_Survey_Observation(c_);
		IEnumerable<Observation> e_(Observation _MLHFQPhysical)
		{
			var l_ = this.Emotional_score__MLHFQ_();
			var m_ = context.Operators.ToList<CqlCode>(l_);
			var n_ = context.Operators.RetrieveByCodes<Observation>(m_, null);
			var o_ = Status_1_6_000.Final_Survey_Observation(n_);

			return o_;
		};
		Tuples.Tuple_CBaKLCFRCUhXghPfCScgCAfHU f_(Observation _MLHFQPhysical, Observation _MLHFQEmotional)
		{
			var p_ = new Tuples.Tuple_CBaKLCFRCUhXghPfCScgCAfHU
			{
				MLHFQPhysical = _MLHFQPhysical,
				MLHFQEmotional = _MLHFQEmotional,
			};

			return p_;
		};
		var g_ = context.Operators.SelectManyResultsOrNull<Observation, Observation, Tuples.Tuple_CBaKLCFRCUhXghPfCScgCAfHU>(d_, e_, f_);
		bool? h_(Tuples.Tuple_CBaKLCFRCUhXghPfCScgCAfHU tuple_cbaklcfrcuhxghpfcscgcafhu)
		{
			var q_ = FHIRHelpers_4_3_000.ToValue(tuple_cbaklcfrcuhxghpfcscgcafhu.MLHFQPhysical?.Effective);
			var r_ = QICoreCommon_2_0_000.ToInterval(q_);
			var s_ = context.Operators.Start(r_);
			var t_ = context.Operators.DateFrom(s_);
			var u_ = FHIRHelpers_4_3_000.ToValue(tuple_cbaklcfrcuhxghpfcscgcafhu.MLHFQEmotional?.Effective);
			var v_ = QICoreCommon_2_0_000.ToInterval(u_);
			var w_ = context.Operators.Start(v_);
			var x_ = context.Operators.DateFrom(w_);
			var y_ = context.Operators.SameAs(t_, x_, "day");
			var z_ = FHIRHelpers_4_3_000.ToValue(tuple_cbaklcfrcuhxghpfcscgcafhu.MLHFQPhysical?.Value);
			var aa_ = context.Operators.Not((bool?)(z_ is null));
			var ab_ = context.Operators.And(y_, aa_);
			var ac_ = FHIRHelpers_4_3_000.ToValue(tuple_cbaklcfrcuhxghpfcscgcafhu.MLHFQEmotional?.Value);
			var ad_ = context.Operators.Not((bool?)(ac_ is null));
			var ae_ = context.Operators.And(ab_, ad_);

			return ae_;
		};
		var i_ = context.Operators.WhereOrNull<Tuples.Tuple_CBaKLCFRCUhXghPfCScgCAfHU>(g_, h_);
		CqlDate j_(Tuples.Tuple_CBaKLCFRCUhXghPfCScgCAfHU tuple_cbaklcfrcuhxghpfcscgcafhu)
		{
			var af_ = FHIRHelpers_4_3_000.ToValue(tuple_cbaklcfrcuhxghpfcscgcafhu.MLHFQPhysical?.Effective);
			var ag_ = QICoreCommon_2_0_000.ToInterval(af_);
			var ah_ = context.Operators.Start(ag_);
			var ai_ = context.Operators.DateFrom(ah_);
			var aj_ = FHIRHelpers_4_3_000.ToValue(tuple_cbaklcfrcuhxghpfcscgcafhu.MLHFQEmotional?.Effective);
			var ak_ = QICoreCommon_2_0_000.ToInterval(aj_);
			var al_ = context.Operators.Start(ak_);
			var am_ = context.Operators.DateFrom(al_);
			var an_ = new CqlDate[]
			{
				ai_,
				am_,
			};
			var ao_ = context.Operators.MaxOrNull<CqlDate>((an_ as IEnumerable<CqlDate>));

			return ao_;
		};
		var k_ = context.Operators.SelectOrNull<Tuples.Tuple_CBaKLCFRCUhXghPfCScgCAfHU, CqlDate>(i_, j_);

		return k_;
	}

    [CqlDeclaration("Date MLHFQ Total Assessment Completed")]
	public IEnumerable<CqlDate> Date_MLHFQ_Total_Assessment_Completed() => 
		__Date_MLHFQ_Total_Assessment_Completed.Value;

	private bool? Has_Encounter_with_Initial_and_Follow_Up_MLHFQ_Assessments_Value()
	{
		var a_ = this.Qualifying_Encounters();
		IEnumerable<CqlDate> b_(Encounter _ValidEncounters)
		{
			var m_ = this.Date_MLHFQ_Total_Assessment_Completed();

			return m_;
		};
		Tuples.Tuple_DgNBKfGfRHaWDZaDFPZKifXLi c_(Encounter _ValidEncounters, CqlDate _InitialMLHFQDate)
		{
			var n_ = new Tuples.Tuple_DgNBKfGfRHaWDZaDFPZKifXLi
			{
				ValidEncounters = _ValidEncounters,
				InitialMLHFQDate = _InitialMLHFQDate,
			};

			return n_;
		};
		var d_ = context.Operators.SelectManyResultsOrNull<Encounter, CqlDate, Tuples.Tuple_DgNBKfGfRHaWDZaDFPZKifXLi>(a_, b_, c_);
		IEnumerable<CqlDate> e_(Tuples.Tuple_DgNBKfGfRHaWDZaDFPZKifXLi _ValidEncountersInitialMLHFQDate)
		{
			var o_ = this.Date_MLHFQ_Total_Assessment_Completed();

			return o_;
		};
		Tuples.Tuple_DgNBKfGfRHaWDZaDFPZKifXLi f_(Tuples.Tuple_DgNBKfGfRHaWDZaDFPZKifXLi ValidEncountersInitialMLHFQDate, CqlDate _FollowupMLHFQDate)
		{
			var p_ = new Tuples.Tuple_DgNBKfGfRHaWDZaDFPZKifXLi
			{
				ValidEncounters = ValidEncountersInitialMLHFQDate.ValidEncounters,
				InitialMLHFQDate = ValidEncountersInitialMLHFQDate.InitialMLHFQDate,
				FollowupMLHFQDate = _FollowupMLHFQDate,
			};

			return p_;
		};
		var g_ = context.Operators.SelectManyResultsOrNull<Tuples.Tuple_DgNBKfGfRHaWDZaDFPZKifXLi, CqlDate, Tuples.Tuple_DgNBKfGfRHaWDZaDFPZKifXLi>(d_, e_, f_);
		bool? h_(Tuples.Tuple_DgNBKfGfRHaWDZaDFPZKifXLi tuple_dgnbkfgfrhawdzadfpzkifxli)
		{
			var q_ = FHIRHelpers_4_3_000.ToInterval(tuple_dgnbkfgfrhawdzadfpzkifxli.ValidEncounters?.Period);
			var r_ = QICoreCommon_2_0_000.ToInterval((q_ as object));
			var s_ = context.Operators.End(r_);
			var t_ = this.Measurement_Period();
			var u_ = context.Operators.End(t_);
			var v_ = context.Operators.Quantity(180m, "days");
			var w_ = context.Operators.Subtract(u_, v_);
			var x_ = context.Operators.SameOrBefore(s_, w_, "day");
			var y_ = context.Operators.ConvertDateToDateTime(tuple_dgnbkfgfrhawdzadfpzkifxli.InitialMLHFQDate);
			var aa_ = QICoreCommon_2_0_000.ToInterval((q_ as object));
			var ab_ = context.Operators.End(aa_);
			var ac_ = context.Operators.Quantity(14m, "days");
			var ad_ = context.Operators.Subtract(ab_, ac_);
			var af_ = QICoreCommon_2_0_000.ToInterval((q_ as object));
			var ag_ = context.Operators.End(af_);
			var ah_ = context.Operators.Interval(ad_, ag_, true, true);
			var ai_ = context.Operators.ElementInInterval<CqlDateTime>(y_, ah_, "day");
			var ak_ = QICoreCommon_2_0_000.ToInterval((q_ as object));
			var al_ = context.Operators.End(ak_);
			var am_ = context.Operators.Not((bool?)(al_ is null));
			var an_ = context.Operators.And(ai_, am_);
			var ao_ = context.Operators.And(x_, an_);
			var ap_ = context.Operators.ConvertDateToDateTime(tuple_dgnbkfgfrhawdzadfpzkifxli.FollowupMLHFQDate);
			var aq_ = context.Operators.DateFrom(ap_);
			var as_ = context.Operators.DateFrom(y_);
			var at_ = context.Operators.Quantity(30m, "days");
			var au_ = context.Operators.Add(as_, at_);
			var aw_ = context.Operators.DateFrom(y_);
			var ay_ = context.Operators.Add(aw_, v_);
			var az_ = context.Operators.Interval(au_, ay_, true, true);
			var ba_ = context.Operators.ElementInInterval<CqlDate>(aq_, az_, "day");
			var bb_ = context.Operators.And(ao_, ba_);

			return bb_;
		};
		var i_ = context.Operators.WhereOrNull<Tuples.Tuple_DgNBKfGfRHaWDZaDFPZKifXLi>(g_, h_);
		Encounter j_(Tuples.Tuple_DgNBKfGfRHaWDZaDFPZKifXLi tuple_dgnbkfgfrhawdzadfpzkifxli) => 
			tuple_dgnbkfgfrhawdzadfpzkifxli.ValidEncounters;
		var k_ = context.Operators.SelectOrNull<Tuples.Tuple_DgNBKfGfRHaWDZaDFPZKifXLi, Encounter>(i_, j_);
		var l_ = context.Operators.ExistsInList<Encounter>(k_);

		return l_;
	}

    [CqlDeclaration("Has Encounter with Initial and Follow Up MLHFQ Assessments")]
	public bool? Has_Encounter_with_Initial_and_Follow_Up_MLHFQ_Assessments() => 
		__Has_Encounter_with_Initial_and_Follow_Up_MLHFQ_Assessments.Value;

	private IEnumerable<CqlDate> Date_KCCQ12_Total_Assessment_Completed_Value()
	{
		var a_ = this.Kansas_City_Cardiomyopathy_Questionnaire___12_item__KCCQ_12_();
		var b_ = context.Operators.ToList<CqlCode>(a_);
		var c_ = context.Operators.RetrieveByCodes<Observation>(b_, null);
		var d_ = Status_1_6_000.Final_Survey_Observation(c_);
		IEnumerable<Observation> e_(Observation _KCCQ12Item)
		{
			var l_ = this.Overall_summary_score__KCCQ_12_();
			var m_ = context.Operators.ToList<CqlCode>(l_);
			var n_ = context.Operators.RetrieveByCodes<Observation>(m_, null);
			var o_ = Status_1_6_000.Final_Survey_Observation(n_);

			return o_;
		};
		Tuples.Tuple_FFJNYaMQHZAOFYMNSKAHAUdLF f_(Observation _KCCQ12Item, Observation _KCCQ12Summary)
		{
			var p_ = new Tuples.Tuple_FFJNYaMQHZAOFYMNSKAHAUdLF
			{
				KCCQ12Item = _KCCQ12Item,
				KCCQ12Summary = _KCCQ12Summary,
			};

			return p_;
		};
		var g_ = context.Operators.SelectManyResultsOrNull<Observation, Observation, Tuples.Tuple_FFJNYaMQHZAOFYMNSKAHAUdLF>(d_, e_, f_);
		bool? h_(Tuples.Tuple_FFJNYaMQHZAOFYMNSKAHAUdLF tuple_ffjnyamqhzaofymnskahaudlf)
		{
			var q_ = FHIRHelpers_4_3_000.ToValue(tuple_ffjnyamqhzaofymnskahaudlf.KCCQ12Item?.Effective);
			var r_ = QICoreCommon_2_0_000.ToInterval(q_);
			var s_ = context.Operators.Start(r_);
			var t_ = context.Operators.DateFrom(s_);
			var u_ = FHIRHelpers_4_3_000.ToValue(tuple_ffjnyamqhzaofymnskahaudlf.KCCQ12Summary?.Effective);
			var v_ = QICoreCommon_2_0_000.ToInterval(u_);
			var w_ = context.Operators.Start(v_);
			var x_ = context.Operators.DateFrom(w_);
			var y_ = context.Operators.SameAs(t_, x_, "day");
			var z_ = FHIRHelpers_4_3_000.ToValue(tuple_ffjnyamqhzaofymnskahaudlf.KCCQ12Item?.Value);
			var aa_ = context.Operators.Not((bool?)(z_ is null));
			var ab_ = context.Operators.And(y_, aa_);
			var ac_ = FHIRHelpers_4_3_000.ToValue(tuple_ffjnyamqhzaofymnskahaudlf.KCCQ12Summary?.Value);
			var ad_ = context.Operators.Not((bool?)(ac_ is null));
			var ae_ = context.Operators.And(ab_, ad_);

			return ae_;
		};
		var i_ = context.Operators.WhereOrNull<Tuples.Tuple_FFJNYaMQHZAOFYMNSKAHAUdLF>(g_, h_);
		CqlDate j_(Tuples.Tuple_FFJNYaMQHZAOFYMNSKAHAUdLF tuple_ffjnyamqhzaofymnskahaudlf)
		{
			var af_ = FHIRHelpers_4_3_000.ToValue(tuple_ffjnyamqhzaofymnskahaudlf.KCCQ12Item?.Effective);
			var ag_ = QICoreCommon_2_0_000.ToInterval(af_);
			var ah_ = context.Operators.Start(ag_);
			var ai_ = context.Operators.DateFrom(ah_);
			var aj_ = FHIRHelpers_4_3_000.ToValue(tuple_ffjnyamqhzaofymnskahaudlf.KCCQ12Summary?.Effective);
			var ak_ = QICoreCommon_2_0_000.ToInterval(aj_);
			var al_ = context.Operators.Start(ak_);
			var am_ = context.Operators.DateFrom(al_);
			var an_ = new CqlDate[]
			{
				ai_,
				am_,
			};
			var ao_ = context.Operators.MaxOrNull<CqlDate>((an_ as IEnumerable<CqlDate>));

			return ao_;
		};
		var k_ = context.Operators.SelectOrNull<Tuples.Tuple_FFJNYaMQHZAOFYMNSKAHAUdLF, CqlDate>(i_, j_);

		return k_;
	}

    [CqlDeclaration("Date KCCQ12 Total Assessment Completed")]
	public IEnumerable<CqlDate> Date_KCCQ12_Total_Assessment_Completed() => 
		__Date_KCCQ12_Total_Assessment_Completed.Value;

	private bool? Has_Encounter_with_Initial_and_Follow_Up_KCCQ12_Assessments_Value()
	{
		var a_ = this.Qualifying_Encounters();
		IEnumerable<CqlDate> b_(Encounter _ValidEncounters)
		{
			var m_ = this.Date_KCCQ12_Total_Assessment_Completed();

			return m_;
		};
		Tuples.Tuple_DNZcZTNIZUQfFfijaYDWagbfi c_(Encounter _ValidEncounters, CqlDate _InitialKCCQ12Date)
		{
			var n_ = new Tuples.Tuple_DNZcZTNIZUQfFfijaYDWagbfi
			{
				ValidEncounters = _ValidEncounters,
				InitialKCCQ12Date = _InitialKCCQ12Date,
			};

			return n_;
		};
		var d_ = context.Operators.SelectManyResultsOrNull<Encounter, CqlDate, Tuples.Tuple_DNZcZTNIZUQfFfijaYDWagbfi>(a_, b_, c_);
		IEnumerable<CqlDate> e_(Tuples.Tuple_DNZcZTNIZUQfFfijaYDWagbfi _ValidEncountersInitialKCCQ12Date)
		{
			var o_ = this.Date_KCCQ12_Total_Assessment_Completed();

			return o_;
		};
		Tuples.Tuple_DNZcZTNIZUQfFfijaYDWagbfi f_(Tuples.Tuple_DNZcZTNIZUQfFfijaYDWagbfi ValidEncountersInitialKCCQ12Date, CqlDate _FollowupKCCQ12Date)
		{
			var p_ = new Tuples.Tuple_DNZcZTNIZUQfFfijaYDWagbfi
			{
				ValidEncounters = ValidEncountersInitialKCCQ12Date.ValidEncounters,
				InitialKCCQ12Date = ValidEncountersInitialKCCQ12Date.InitialKCCQ12Date,
				FollowupKCCQ12Date = _FollowupKCCQ12Date,
			};

			return p_;
		};
		var g_ = context.Operators.SelectManyResultsOrNull<Tuples.Tuple_DNZcZTNIZUQfFfijaYDWagbfi, CqlDate, Tuples.Tuple_DNZcZTNIZUQfFfijaYDWagbfi>(d_, e_, f_);
		bool? h_(Tuples.Tuple_DNZcZTNIZUQfFfijaYDWagbfi tuple_dnzcztnizuqfffijaydwagbfi)
		{
			var q_ = FHIRHelpers_4_3_000.ToInterval(tuple_dnzcztnizuqfffijaydwagbfi.ValidEncounters?.Period);
			var r_ = QICoreCommon_2_0_000.ToInterval((q_ as object));
			var s_ = context.Operators.End(r_);
			var t_ = this.Measurement_Period();
			var u_ = context.Operators.End(t_);
			var v_ = context.Operators.Quantity(180m, "days");
			var w_ = context.Operators.Subtract(u_, v_);
			var x_ = context.Operators.SameOrBefore(s_, w_, "day");
			var y_ = context.Operators.ConvertDateToDateTime(tuple_dnzcztnizuqfffijaydwagbfi.InitialKCCQ12Date);
			var aa_ = QICoreCommon_2_0_000.ToInterval((q_ as object));
			var ab_ = context.Operators.End(aa_);
			var ac_ = context.Operators.Quantity(14m, "days");
			var ad_ = context.Operators.Subtract(ab_, ac_);
			var af_ = QICoreCommon_2_0_000.ToInterval((q_ as object));
			var ag_ = context.Operators.End(af_);
			var ah_ = context.Operators.Interval(ad_, ag_, true, true);
			var ai_ = context.Operators.ElementInInterval<CqlDateTime>(y_, ah_, "day");
			var ak_ = QICoreCommon_2_0_000.ToInterval((q_ as object));
			var al_ = context.Operators.End(ak_);
			var am_ = context.Operators.Not((bool?)(al_ is null));
			var an_ = context.Operators.And(ai_, am_);
			var ao_ = context.Operators.And(x_, an_);
			var ap_ = context.Operators.ConvertDateToDateTime(tuple_dnzcztnizuqfffijaydwagbfi.FollowupKCCQ12Date);
			var aq_ = context.Operators.DateFrom(ap_);
			var as_ = context.Operators.DateFrom(y_);
			var at_ = context.Operators.Quantity(30m, "days");
			var au_ = context.Operators.Add(as_, at_);
			var aw_ = context.Operators.DateFrom(y_);
			var ay_ = context.Operators.Add(aw_, v_);
			var az_ = context.Operators.Interval(au_, ay_, true, true);
			var ba_ = context.Operators.ElementInInterval<CqlDate>(aq_, az_, "day");
			var bb_ = context.Operators.And(ao_, ba_);

			return bb_;
		};
		var i_ = context.Operators.WhereOrNull<Tuples.Tuple_DNZcZTNIZUQfFfijaYDWagbfi>(g_, h_);
		Encounter j_(Tuples.Tuple_DNZcZTNIZUQfFfijaYDWagbfi tuple_dnzcztnizuqfffijaydwagbfi) => 
			tuple_dnzcztnizuqfffijaydwagbfi.ValidEncounters;
		var k_ = context.Operators.SelectOrNull<Tuples.Tuple_DNZcZTNIZUQfFfijaYDWagbfi, Encounter>(i_, j_);
		var l_ = context.Operators.ExistsInList<Encounter>(k_);

		return l_;
	}

    [CqlDeclaration("Has Encounter with Initial and Follow Up KCCQ12 Assessments")]
	public bool? Has_Encounter_with_Initial_and_Follow_Up_KCCQ12_Assessments() => 
		__Has_Encounter_with_Initial_and_Follow_Up_KCCQ12_Assessments.Value;

	private IEnumerable<CqlDate> Date_KCCQ_Domain_Assessment_Completed_Value()
	{
		var a_ = this.Quality_of_life_score__KCCQ_();
		var b_ = context.Operators.ToList<CqlCode>(a_);
		var c_ = context.Operators.RetrieveByCodes<Observation>(b_, null);
		var d_ = Status_1_6_000.Final_Survey_Observation(c_);
		IEnumerable<Observation> e_(Observation _KCCQLifeQuality)
		{
			var x_ = this.Symptom_stability_score__KCCQ_();
			var y_ = context.Operators.ToList<CqlCode>(x_);
			var z_ = context.Operators.RetrieveByCodes<Observation>(y_, null);
			var aa_ = Status_1_6_000.Final_Survey_Observation(z_);

			return aa_;
		};
		Tuples.Tuple_BbiPKFIYFfdQCLCHPcXKDaFMV f_(Observation _KCCQLifeQuality, Observation _KCCQSymptomStability)
		{
			var ab_ = new Tuples.Tuple_BbiPKFIYFfdQCLCHPcXKDaFMV
			{
				KCCQLifeQuality = _KCCQLifeQuality,
				KCCQSymptomStability = _KCCQSymptomStability,
			};

			return ab_;
		};
		var g_ = context.Operators.SelectManyResultsOrNull<Observation, Observation, Tuples.Tuple_BbiPKFIYFfdQCLCHPcXKDaFMV>(d_, e_, f_);
		IEnumerable<Observation> h_(Tuples.Tuple_BbiPKFIYFfdQCLCHPcXKDaFMV _KCCQLifeQualityKCCQSymptomStability)
		{
			var ac_ = this.Self_efficacy_score__KCCQ_();
			var ad_ = context.Operators.ToList<CqlCode>(ac_);
			var ae_ = context.Operators.RetrieveByCodes<Observation>(ad_, null);
			var af_ = Status_1_6_000.Final_Survey_Observation(ae_);

			return af_;
		};
		Tuples.Tuple_BbiPKFIYFfdQCLCHPcXKDaFMV i_(Tuples.Tuple_BbiPKFIYFfdQCLCHPcXKDaFMV KCCQLifeQualityKCCQSymptomStability, Observation _KCCQSelfEfficacy)
		{
			var ag_ = new Tuples.Tuple_BbiPKFIYFfdQCLCHPcXKDaFMV
			{
				KCCQLifeQuality = KCCQLifeQualityKCCQSymptomStability.KCCQLifeQuality,
				KCCQSymptomStability = KCCQLifeQualityKCCQSymptomStability.KCCQSymptomStability,
				KCCQSelfEfficacy = _KCCQSelfEfficacy,
			};

			return ag_;
		};
		var j_ = context.Operators.SelectManyResultsOrNull<Tuples.Tuple_BbiPKFIYFfdQCLCHPcXKDaFMV, Observation, Tuples.Tuple_BbiPKFIYFfdQCLCHPcXKDaFMV>(g_, h_, i_);
		IEnumerable<Observation> k_(Tuples.Tuple_BbiPKFIYFfdQCLCHPcXKDaFMV _KCCQLifeQualityKCCQSymptomStabilityKCCQSelfEfficacy)
		{
			var ah_ = this.Total_symptom_score__KCCQ_();
			var ai_ = context.Operators.ToList<CqlCode>(ah_);
			var aj_ = context.Operators.RetrieveByCodes<Observation>(ai_, null);
			var ak_ = Status_1_6_000.Final_Survey_Observation(aj_);

			return ak_;
		};
		Tuples.Tuple_BbiPKFIYFfdQCLCHPcXKDaFMV l_(Tuples.Tuple_BbiPKFIYFfdQCLCHPcXKDaFMV KCCQLifeQualityKCCQSymptomStabilityKCCQSelfEfficacy, Observation _KCCQSymptoms)
		{
			var al_ = new Tuples.Tuple_BbiPKFIYFfdQCLCHPcXKDaFMV
			{
				KCCQLifeQuality = KCCQLifeQualityKCCQSymptomStabilityKCCQSelfEfficacy.KCCQLifeQuality,
				KCCQSymptomStability = KCCQLifeQualityKCCQSymptomStabilityKCCQSelfEfficacy.KCCQSymptomStability,
				KCCQSelfEfficacy = KCCQLifeQualityKCCQSymptomStabilityKCCQSelfEfficacy.KCCQSelfEfficacy,
				KCCQSymptoms = _KCCQSymptoms,
			};

			return al_;
		};
		var m_ = context.Operators.SelectManyResultsOrNull<Tuples.Tuple_BbiPKFIYFfdQCLCHPcXKDaFMV, Observation, Tuples.Tuple_BbiPKFIYFfdQCLCHPcXKDaFMV>(j_, k_, l_);
		IEnumerable<Observation> n_(Tuples.Tuple_BbiPKFIYFfdQCLCHPcXKDaFMV _KCCQLifeQualityKCCQSymptomStabilityKCCQSelfEfficacyKCCQSymptoms)
		{
			var am_ = this.Physical_limitation_score__KCCQ_();
			var an_ = context.Operators.ToList<CqlCode>(am_);
			var ao_ = context.Operators.RetrieveByCodes<Observation>(an_, null);
			var ap_ = Status_1_6_000.Final_Survey_Observation(ao_);

			return ap_;
		};
		Tuples.Tuple_BbiPKFIYFfdQCLCHPcXKDaFMV o_(Tuples.Tuple_BbiPKFIYFfdQCLCHPcXKDaFMV KCCQLifeQualityKCCQSymptomStabilityKCCQSelfEfficacyKCCQSymptoms, Observation _KCCQPhysicalLimits)
		{
			var aq_ = new Tuples.Tuple_BbiPKFIYFfdQCLCHPcXKDaFMV
			{
				KCCQLifeQuality = KCCQLifeQualityKCCQSymptomStabilityKCCQSelfEfficacyKCCQSymptoms.KCCQLifeQuality,
				KCCQSymptomStability = KCCQLifeQualityKCCQSymptomStabilityKCCQSelfEfficacyKCCQSymptoms.KCCQSymptomStability,
				KCCQSelfEfficacy = KCCQLifeQualityKCCQSymptomStabilityKCCQSelfEfficacyKCCQSymptoms.KCCQSelfEfficacy,
				KCCQSymptoms = KCCQLifeQualityKCCQSymptomStabilityKCCQSelfEfficacyKCCQSymptoms.KCCQSymptoms,
				KCCQPhysicalLimits = _KCCQPhysicalLimits,
			};

			return aq_;
		};
		var p_ = context.Operators.SelectManyResultsOrNull<Tuples.Tuple_BbiPKFIYFfdQCLCHPcXKDaFMV, Observation, Tuples.Tuple_BbiPKFIYFfdQCLCHPcXKDaFMV>(m_, n_, o_);
		IEnumerable<Observation> q_(Tuples.Tuple_BbiPKFIYFfdQCLCHPcXKDaFMV _KCCQLifeQualityKCCQSymptomStabilityKCCQSelfEfficacyKCCQSymptomsKCCQPhysicalLimits)
		{
			var ar_ = this.Social_limitation_score__KCCQ_();
			var as_ = context.Operators.ToList<CqlCode>(ar_);
			var at_ = context.Operators.RetrieveByCodes<Observation>(as_, null);
			var au_ = Status_1_6_000.Final_Survey_Observation(at_);

			return au_;
		};
		Tuples.Tuple_BbiPKFIYFfdQCLCHPcXKDaFMV r_(Tuples.Tuple_BbiPKFIYFfdQCLCHPcXKDaFMV KCCQLifeQualityKCCQSymptomStabilityKCCQSelfEfficacyKCCQSymptomsKCCQPhysicalLimits, Observation _KCCQSocialLimits)
		{
			var av_ = new Tuples.Tuple_BbiPKFIYFfdQCLCHPcXKDaFMV
			{
				KCCQLifeQuality = KCCQLifeQualityKCCQSymptomStabilityKCCQSelfEfficacyKCCQSymptomsKCCQPhysicalLimits.KCCQLifeQuality,
				KCCQSymptomStability = KCCQLifeQualityKCCQSymptomStabilityKCCQSelfEfficacyKCCQSymptomsKCCQPhysicalLimits.KCCQSymptomStability,
				KCCQSelfEfficacy = KCCQLifeQualityKCCQSymptomStabilityKCCQSelfEfficacyKCCQSymptomsKCCQPhysicalLimits.KCCQSelfEfficacy,
				KCCQSymptoms = KCCQLifeQualityKCCQSymptomStabilityKCCQSelfEfficacyKCCQSymptomsKCCQPhysicalLimits.KCCQSymptoms,
				KCCQPhysicalLimits = KCCQLifeQualityKCCQSymptomStabilityKCCQSelfEfficacyKCCQSymptomsKCCQPhysicalLimits.KCCQPhysicalLimits,
				KCCQSocialLimits = _KCCQSocialLimits,
			};

			return av_;
		};
		var s_ = context.Operators.SelectManyResultsOrNull<Tuples.Tuple_BbiPKFIYFfdQCLCHPcXKDaFMV, Observation, Tuples.Tuple_BbiPKFIYFfdQCLCHPcXKDaFMV>(p_, q_, r_);
		bool? t_(Tuples.Tuple_BbiPKFIYFfdQCLCHPcXKDaFMV tuple_bbipkfiyffdqclchpcxkdafmv)
		{
			var aw_ = FHIRHelpers_4_3_000.ToValue(tuple_bbipkfiyffdqclchpcxkdafmv.KCCQLifeQuality?.Effective);
			var ax_ = QICoreCommon_2_0_000.ToInterval(aw_);
			var ay_ = context.Operators.Start(ax_);
			var az_ = context.Operators.DateFrom(ay_);
			var ba_ = FHIRHelpers_4_3_000.ToValue(tuple_bbipkfiyffdqclchpcxkdafmv.KCCQSymptomStability?.Effective);
			var bb_ = QICoreCommon_2_0_000.ToInterval(ba_);
			var bc_ = context.Operators.Start(bb_);
			var bd_ = context.Operators.DateFrom(bc_);
			var be_ = context.Operators.SameAs(az_, bd_, "day");
			var bf_ = FHIRHelpers_4_3_000.ToValue(tuple_bbipkfiyffdqclchpcxkdafmv.KCCQSymptomStability?.Value);
			var bg_ = context.Operators.Not((bool?)(bf_ is null));
			var bh_ = context.Operators.And(be_, bg_);
			var bj_ = QICoreCommon_2_0_000.ToInterval(aw_);
			var bk_ = context.Operators.Start(bj_);
			var bl_ = context.Operators.DateFrom(bk_);
			var bm_ = FHIRHelpers_4_3_000.ToValue(tuple_bbipkfiyffdqclchpcxkdafmv.KCCQSelfEfficacy?.Effective);
			var bn_ = QICoreCommon_2_0_000.ToInterval(bm_);
			var bo_ = context.Operators.Start(bn_);
			var bp_ = context.Operators.DateFrom(bo_);
			var bq_ = context.Operators.SameAs(bl_, bp_, "day");
			var br_ = context.Operators.And(bh_, bq_);
			var bs_ = FHIRHelpers_4_3_000.ToValue(tuple_bbipkfiyffdqclchpcxkdafmv.KCCQSelfEfficacy?.Value);
			var bt_ = context.Operators.Not((bool?)(bs_ is null));
			var bu_ = context.Operators.And(br_, bt_);
			var bw_ = QICoreCommon_2_0_000.ToInterval(aw_);
			var bx_ = context.Operators.Start(bw_);
			var by_ = context.Operators.DateFrom(bx_);
			var bz_ = FHIRHelpers_4_3_000.ToValue(tuple_bbipkfiyffdqclchpcxkdafmv.KCCQSymptoms?.Effective);
			var ca_ = QICoreCommon_2_0_000.ToInterval(bz_);
			var cb_ = context.Operators.Start(ca_);
			var cc_ = context.Operators.DateFrom(cb_);
			var cd_ = context.Operators.SameAs(by_, cc_, "day");
			var ce_ = context.Operators.And(bu_, cd_);
			var cf_ = FHIRHelpers_4_3_000.ToValue(tuple_bbipkfiyffdqclchpcxkdafmv.KCCQSymptoms?.Value);
			var cg_ = context.Operators.Not((bool?)(cf_ is null));
			var ch_ = context.Operators.And(ce_, cg_);
			var cj_ = QICoreCommon_2_0_000.ToInterval(aw_);
			var ck_ = context.Operators.Start(cj_);
			var cl_ = context.Operators.DateFrom(ck_);
			var cm_ = FHIRHelpers_4_3_000.ToValue(tuple_bbipkfiyffdqclchpcxkdafmv.KCCQPhysicalLimits?.Effective);
			var cn_ = QICoreCommon_2_0_000.ToInterval(cm_);
			var co_ = context.Operators.Start(cn_);
			var cp_ = context.Operators.DateFrom(co_);
			var cq_ = context.Operators.SameAs(cl_, cp_, "day");
			var cr_ = context.Operators.And(ch_, cq_);
			var cs_ = FHIRHelpers_4_3_000.ToValue(tuple_bbipkfiyffdqclchpcxkdafmv.KCCQPhysicalLimits?.Value);
			var ct_ = context.Operators.Not((bool?)(cs_ is null));
			var cu_ = context.Operators.And(cr_, ct_);
			var cw_ = QICoreCommon_2_0_000.ToInterval(aw_);
			var cx_ = context.Operators.Start(cw_);
			var cy_ = context.Operators.DateFrom(cx_);
			var cz_ = FHIRHelpers_4_3_000.ToValue(tuple_bbipkfiyffdqclchpcxkdafmv.KCCQSocialLimits?.Effective);
			var da_ = QICoreCommon_2_0_000.ToInterval(cz_);
			var db_ = context.Operators.Start(da_);
			var dc_ = context.Operators.DateFrom(db_);
			var dd_ = context.Operators.SameAs(cy_, dc_, "day");
			var de_ = context.Operators.And(cu_, dd_);
			var df_ = FHIRHelpers_4_3_000.ToValue(tuple_bbipkfiyffdqclchpcxkdafmv.KCCQSocialLimits?.Value);
			var dg_ = context.Operators.Not((bool?)(df_ is null));
			var dh_ = context.Operators.And(de_, dg_);
			var di_ = FHIRHelpers_4_3_000.ToValue(tuple_bbipkfiyffdqclchpcxkdafmv.KCCQLifeQuality?.Value);
			var dj_ = context.Operators.Not((bool?)(di_ is null));
			var dk_ = context.Operators.And(dh_, dj_);

			return dk_;
		};
		var u_ = context.Operators.WhereOrNull<Tuples.Tuple_BbiPKFIYFfdQCLCHPcXKDaFMV>(s_, t_);
		CqlDate v_(Tuples.Tuple_BbiPKFIYFfdQCLCHPcXKDaFMV tuple_bbipkfiyffdqclchpcxkdafmv)
		{
			var dl_ = FHIRHelpers_4_3_000.ToValue(tuple_bbipkfiyffdqclchpcxkdafmv.KCCQLifeQuality?.Effective);
			var dm_ = QICoreCommon_2_0_000.ToInterval(dl_);
			var dn_ = context.Operators.Start(dm_);
			var do_ = context.Operators.DateFrom(dn_);
			var dp_ = FHIRHelpers_4_3_000.ToValue(tuple_bbipkfiyffdqclchpcxkdafmv.KCCQSymptomStability?.Effective);
			var dq_ = QICoreCommon_2_0_000.ToInterval(dp_);
			var dr_ = context.Operators.Start(dq_);
			var ds_ = context.Operators.DateFrom(dr_);
			var dt_ = FHIRHelpers_4_3_000.ToValue(tuple_bbipkfiyffdqclchpcxkdafmv.KCCQSelfEfficacy?.Effective);
			var du_ = QICoreCommon_2_0_000.ToInterval(dt_);
			var dv_ = context.Operators.Start(du_);
			var dw_ = context.Operators.DateFrom(dv_);
			var dx_ = FHIRHelpers_4_3_000.ToValue(tuple_bbipkfiyffdqclchpcxkdafmv.KCCQSymptoms?.Effective);
			var dy_ = QICoreCommon_2_0_000.ToInterval(dx_);
			var dz_ = context.Operators.Start(dy_);
			var ea_ = context.Operators.DateFrom(dz_);
			var eb_ = FHIRHelpers_4_3_000.ToValue(tuple_bbipkfiyffdqclchpcxkdafmv.KCCQPhysicalLimits?.Effective);
			var ec_ = QICoreCommon_2_0_000.ToInterval(eb_);
			var ed_ = context.Operators.Start(ec_);
			var ee_ = context.Operators.DateFrom(ed_);
			var ef_ = FHIRHelpers_4_3_000.ToValue(tuple_bbipkfiyffdqclchpcxkdafmv.KCCQSocialLimits?.Effective);
			var eg_ = QICoreCommon_2_0_000.ToInterval(ef_);
			var eh_ = context.Operators.Start(eg_);
			var ei_ = context.Operators.DateFrom(eh_);
			var ej_ = new CqlDate[]
			{
				do_,
				ds_,
				dw_,
				ea_,
				ee_,
				ei_,
			};
			var ek_ = context.Operators.MaxOrNull<CqlDate>((ej_ as IEnumerable<CqlDate>));

			return ek_;
		};
		var w_ = context.Operators.SelectOrNull<Tuples.Tuple_BbiPKFIYFfdQCLCHPcXKDaFMV, CqlDate>(u_, v_);

		return w_;
	}

    [CqlDeclaration("Date KCCQ Domain Assessment Completed")]
	public IEnumerable<CqlDate> Date_KCCQ_Domain_Assessment_Completed() => 
		__Date_KCCQ_Domain_Assessment_Completed.Value;

	private bool? Has_Encounter_with_Initial_and_Follow_Up_KCCQ_Domain_Score_Assessments_Value()
	{
		var a_ = this.Qualifying_Encounters();
		IEnumerable<CqlDate> b_(Encounter _ValidEncounters)
		{
			var m_ = this.Date_KCCQ_Domain_Assessment_Completed();

			return m_;
		};
		Tuples.Tuple_GechMKfhePFUbfJYJeVegQTRC c_(Encounter _ValidEncounters, CqlDate _InitialKCCQAssessmentDate)
		{
			var n_ = new Tuples.Tuple_GechMKfhePFUbfJYJeVegQTRC
			{
				ValidEncounters = _ValidEncounters,
				InitialKCCQAssessmentDate = _InitialKCCQAssessmentDate,
			};

			return n_;
		};
		var d_ = context.Operators.SelectManyResultsOrNull<Encounter, CqlDate, Tuples.Tuple_GechMKfhePFUbfJYJeVegQTRC>(a_, b_, c_);
		IEnumerable<CqlDate> e_(Tuples.Tuple_GechMKfhePFUbfJYJeVegQTRC _ValidEncountersInitialKCCQAssessmentDate)
		{
			var o_ = this.Date_KCCQ_Domain_Assessment_Completed();

			return o_;
		};
		Tuples.Tuple_GechMKfhePFUbfJYJeVegQTRC f_(Tuples.Tuple_GechMKfhePFUbfJYJeVegQTRC ValidEncountersInitialKCCQAssessmentDate, CqlDate _FollowupKCCQAssessmentDate)
		{
			var p_ = new Tuples.Tuple_GechMKfhePFUbfJYJeVegQTRC
			{
				ValidEncounters = ValidEncountersInitialKCCQAssessmentDate.ValidEncounters,
				InitialKCCQAssessmentDate = ValidEncountersInitialKCCQAssessmentDate.InitialKCCQAssessmentDate,
				FollowupKCCQAssessmentDate = _FollowupKCCQAssessmentDate,
			};

			return p_;
		};
		var g_ = context.Operators.SelectManyResultsOrNull<Tuples.Tuple_GechMKfhePFUbfJYJeVegQTRC, CqlDate, Tuples.Tuple_GechMKfhePFUbfJYJeVegQTRC>(d_, e_, f_);
		bool? h_(Tuples.Tuple_GechMKfhePFUbfJYJeVegQTRC tuple_gechmkfhepfubfjyjevegqtrc)
		{
			var q_ = FHIRHelpers_4_3_000.ToInterval(tuple_gechmkfhepfubfjyjevegqtrc.ValidEncounters?.Period);
			var r_ = QICoreCommon_2_0_000.ToInterval((q_ as object));
			var s_ = context.Operators.End(r_);
			var t_ = this.Measurement_Period();
			var u_ = context.Operators.End(t_);
			var v_ = context.Operators.Quantity(180m, "days");
			var w_ = context.Operators.Subtract(u_, v_);
			var x_ = context.Operators.SameOrBefore(s_, w_, "day");
			var y_ = context.Operators.ConvertDateToDateTime(tuple_gechmkfhepfubfjyjevegqtrc.InitialKCCQAssessmentDate);
			var aa_ = QICoreCommon_2_0_000.ToInterval((q_ as object));
			var ab_ = context.Operators.End(aa_);
			var ac_ = context.Operators.Quantity(14m, "days");
			var ad_ = context.Operators.Subtract(ab_, ac_);
			var af_ = QICoreCommon_2_0_000.ToInterval((q_ as object));
			var ag_ = context.Operators.End(af_);
			var ah_ = context.Operators.Interval(ad_, ag_, true, true);
			var ai_ = context.Operators.ElementInInterval<CqlDateTime>(y_, ah_, "day");
			var ak_ = QICoreCommon_2_0_000.ToInterval((q_ as object));
			var al_ = context.Operators.End(ak_);
			var am_ = context.Operators.Not((bool?)(al_ is null));
			var an_ = context.Operators.And(ai_, am_);
			var ao_ = context.Operators.And(x_, an_);
			var ap_ = context.Operators.ConvertDateToDateTime(tuple_gechmkfhepfubfjyjevegqtrc.FollowupKCCQAssessmentDate);
			var aq_ = context.Operators.DateFrom(ap_);
			var as_ = context.Operators.DateFrom(y_);
			var at_ = context.Operators.Quantity(30m, "days");
			var au_ = context.Operators.Add(as_, at_);
			var aw_ = context.Operators.DateFrom(y_);
			var ay_ = context.Operators.Add(aw_, v_);
			var az_ = context.Operators.Interval(au_, ay_, true, true);
			var ba_ = context.Operators.ElementInInterval<CqlDate>(aq_, az_, "day");
			var bb_ = context.Operators.And(ao_, ba_);

			return bb_;
		};
		var i_ = context.Operators.WhereOrNull<Tuples.Tuple_GechMKfhePFUbfJYJeVegQTRC>(g_, h_);
		Encounter j_(Tuples.Tuple_GechMKfhePFUbfJYJeVegQTRC tuple_gechmkfhepfubfjyjevegqtrc) => 
			tuple_gechmkfhepfubfjyjevegqtrc.ValidEncounters;
		var k_ = context.Operators.SelectOrNull<Tuples.Tuple_GechMKfhePFUbfJYJeVegQTRC, Encounter>(i_, j_);
		var l_ = context.Operators.ExistsInList<Encounter>(k_);

		return l_;
	}

    [CqlDeclaration("Has Encounter with Initial and Follow Up KCCQ Domain Score Assessments")]
	public bool? Has_Encounter_with_Initial_and_Follow_Up_KCCQ_Domain_Score_Assessments() => 
		__Has_Encounter_with_Initial_and_Follow_Up_KCCQ_Domain_Score_Assessments.Value;

	private IEnumerable<CqlDate> Date_KCCQ_Total_Assessment_Completed_Value()
	{
		var a_ = this.Overall_summary_score__KCCQ_();
		var b_ = context.Operators.ToList<CqlCode>(a_);
		var c_ = context.Operators.RetrieveByCodes<Observation>(b_, null);
		var d_ = Status_1_6_000.Final_Survey_Observation(c_);
		bool? e_(Observation KCCQSummaryScore)
		{
			var i_ = FHIRHelpers_4_3_000.ToValue(KCCQSummaryScore?.Value);
			var j_ = context.Operators.Not((bool?)(i_ is null));

			return j_;
		};
		var f_ = context.Operators.WhereOrNull<Observation>(d_, e_);
		CqlDate g_(Observation KCCQSummaryScore)
		{
			var k_ = FHIRHelpers_4_3_000.ToValue(KCCQSummaryScore?.Effective);
			var l_ = QICoreCommon_2_0_000.ToInterval(k_);
			var m_ = context.Operators.Start(l_);
			var n_ = context.Operators.DateFrom(m_);
			var o_ = new CqlDate[]
			{
				n_,
			};
			var p_ = context.Operators.MaxOrNull<CqlDate>((o_ as IEnumerable<CqlDate>));

			return p_;
		};
		var h_ = context.Operators.SelectOrNull<Observation, CqlDate>(f_, g_);

		return h_;
	}

    [CqlDeclaration("Date KCCQ Total Assessment Completed")]
	public IEnumerable<CqlDate> Date_KCCQ_Total_Assessment_Completed() => 
		__Date_KCCQ_Total_Assessment_Completed.Value;

	private bool? Has_Encounter_with_Initial_and_Follow_Up_KCCQ_Total_Score_Assessments_Value()
	{
		var a_ = this.Qualifying_Encounters();
		IEnumerable<CqlDate> b_(Encounter _ValidEncounters)
		{
			var m_ = this.Date_KCCQ_Total_Assessment_Completed();

			return m_;
		};
		Tuples.Tuple_DSdKcfQMUMBjegQCVVeYhPYdf c_(Encounter _ValidEncounters, CqlDate _InitialKCCQTotalScore)
		{
			var n_ = new Tuples.Tuple_DSdKcfQMUMBjegQCVVeYhPYdf
			{
				ValidEncounters = _ValidEncounters,
				InitialKCCQTotalScore = _InitialKCCQTotalScore,
			};

			return n_;
		};
		var d_ = context.Operators.SelectManyResultsOrNull<Encounter, CqlDate, Tuples.Tuple_DSdKcfQMUMBjegQCVVeYhPYdf>(a_, b_, c_);
		IEnumerable<CqlDate> e_(Tuples.Tuple_DSdKcfQMUMBjegQCVVeYhPYdf _ValidEncountersInitialKCCQTotalScore)
		{
			var o_ = this.Date_KCCQ_Total_Assessment_Completed();

			return o_;
		};
		Tuples.Tuple_DSdKcfQMUMBjegQCVVeYhPYdf f_(Tuples.Tuple_DSdKcfQMUMBjegQCVVeYhPYdf ValidEncountersInitialKCCQTotalScore, CqlDate _FollowupKCCQTotalScore)
		{
			var p_ = new Tuples.Tuple_DSdKcfQMUMBjegQCVVeYhPYdf
			{
				ValidEncounters = ValidEncountersInitialKCCQTotalScore.ValidEncounters,
				InitialKCCQTotalScore = ValidEncountersInitialKCCQTotalScore.InitialKCCQTotalScore,
				FollowupKCCQTotalScore = _FollowupKCCQTotalScore,
			};

			return p_;
		};
		var g_ = context.Operators.SelectManyResultsOrNull<Tuples.Tuple_DSdKcfQMUMBjegQCVVeYhPYdf, CqlDate, Tuples.Tuple_DSdKcfQMUMBjegQCVVeYhPYdf>(d_, e_, f_);
		bool? h_(Tuples.Tuple_DSdKcfQMUMBjegQCVVeYhPYdf tuple_dsdkcfqmumbjegqcvveyhpydf)
		{
			var q_ = FHIRHelpers_4_3_000.ToInterval(tuple_dsdkcfqmumbjegqcvveyhpydf.ValidEncounters?.Period);
			var r_ = QICoreCommon_2_0_000.ToInterval((q_ as object));
			var s_ = context.Operators.End(r_);
			var t_ = this.Measurement_Period();
			var u_ = context.Operators.End(t_);
			var v_ = context.Operators.Quantity(180m, "days");
			var w_ = context.Operators.Subtract(u_, v_);
			var x_ = context.Operators.SameOrBefore(s_, w_, "day");
			var y_ = context.Operators.ConvertDateToDateTime(tuple_dsdkcfqmumbjegqcvveyhpydf.InitialKCCQTotalScore);
			var aa_ = QICoreCommon_2_0_000.ToInterval((q_ as object));
			var ab_ = context.Operators.End(aa_);
			var ac_ = context.Operators.Quantity(14m, "days");
			var ad_ = context.Operators.Subtract(ab_, ac_);
			var af_ = QICoreCommon_2_0_000.ToInterval((q_ as object));
			var ag_ = context.Operators.End(af_);
			var ah_ = context.Operators.Interval(ad_, ag_, true, true);
			var ai_ = context.Operators.ElementInInterval<CqlDateTime>(y_, ah_, "day");
			var ak_ = QICoreCommon_2_0_000.ToInterval((q_ as object));
			var al_ = context.Operators.End(ak_);
			var am_ = context.Operators.Not((bool?)(al_ is null));
			var an_ = context.Operators.And(ai_, am_);
			var ao_ = context.Operators.And(x_, an_);
			var ap_ = context.Operators.ConvertDateToDateTime(tuple_dsdkcfqmumbjegqcvveyhpydf.FollowupKCCQTotalScore);
			var aq_ = context.Operators.DateFrom(ap_);
			var as_ = context.Operators.DateFrom(y_);
			var at_ = context.Operators.Quantity(30m, "days");
			var au_ = context.Operators.Add(as_, at_);
			var aw_ = context.Operators.DateFrom(y_);
			var ay_ = context.Operators.Add(aw_, v_);
			var az_ = context.Operators.Interval(au_, ay_, true, true);
			var ba_ = context.Operators.ElementInInterval<CqlDate>(aq_, az_, "day");
			var bb_ = context.Operators.And(ao_, ba_);

			return bb_;
		};
		var i_ = context.Operators.WhereOrNull<Tuples.Tuple_DSdKcfQMUMBjegQCVVeYhPYdf>(g_, h_);
		Encounter j_(Tuples.Tuple_DSdKcfQMUMBjegQCVVeYhPYdf tuple_dsdkcfqmumbjegqcvveyhpydf) => 
			tuple_dsdkcfqmumbjegqcvveyhpydf.ValidEncounters;
		var k_ = context.Operators.SelectOrNull<Tuples.Tuple_DSdKcfQMUMBjegQCVVeYhPYdf, Encounter>(i_, j_);
		var l_ = context.Operators.ExistsInList<Encounter>(k_);

		return l_;
	}

    [CqlDeclaration("Has Encounter with Initial and Follow Up KCCQ Total Score Assessments")]
	public bool? Has_Encounter_with_Initial_and_Follow_Up_KCCQ_Total_Score_Assessments() => 
		__Has_Encounter_with_Initial_and_Follow_Up_KCCQ_Total_Score_Assessments.Value;

	private bool? Numerator_Value()
	{
		var a_ = this.Has_Encounter_with_Initial_and_Follow_Up_PROMIS10_Assessments();
		var b_ = this.Has_Encounter_with_Initial_and_Follow_Up_PROMIS29_Assessments();
		var c_ = context.Operators.Or(a_, b_);
		var d_ = this.Has_Encounter_with_Initial_and_Follow_Up_VR12_Oblique_Assessments();
		var e_ = context.Operators.Or(c_, d_);
		var f_ = this.Has_Encounter_with_Initial_and_Follow_Up_VR12_Orthogonal_Assessments();
		var g_ = context.Operators.Or(e_, f_);
		var h_ = this.Has_Encounter_with_Initial_and_Follow_Up_VR36_Oblique_Assessments();
		var i_ = context.Operators.Or(g_, h_);
		var j_ = this.Has_Encounter_with_Initial_and_Follow_Up_VR36_Orthogonal_Assessments();
		var k_ = context.Operators.Or(i_, j_);
		var l_ = this.Has_Encounter_with_Initial_and_Follow_Up_MLHFQ_Assessments();
		var m_ = context.Operators.Or(k_, l_);
		var n_ = this.Has_Encounter_with_Initial_and_Follow_Up_KCCQ12_Assessments();
		var o_ = context.Operators.Or(m_, n_);
		var p_ = this.Has_Encounter_with_Initial_and_Follow_Up_KCCQ_Domain_Score_Assessments();
		var q_ = context.Operators.Or(o_, p_);
		var r_ = this.Has_Encounter_with_Initial_and_Follow_Up_KCCQ_Total_Score_Assessments();
		var s_ = context.Operators.Or(q_, r_);

		return s_;
	}

    [CqlDeclaration("Numerator")]
	public bool? Numerator() => 
		__Numerator.Value;

}
