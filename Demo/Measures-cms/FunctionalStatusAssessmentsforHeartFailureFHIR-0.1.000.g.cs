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
		var a_ = context.Operators.DateTime(2025, 1, 1, 0, 0, 0, 0, default);
		var b_ = context.Operators.DateTime(2026, 1, 1, 0, 0, 0, 0, default);
		var c_ = context.Operators.Interval(a_, b_, true, false);
		var d_ = context.ResolveParameter("FunctionalStatusAssessmentsforHeartFailureFHIR-0.1.000", "Measurement Period", c_);

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

	private IEnumerable<Tuple_GDKRbfOIHhLGieQSVDEMIaDPX> SDE_Payer_Value()
	{
		var a_ = SupplementalDataElements_3_4_000.SDE_Payer();

		return a_;
	}

    [CqlDeclaration("SDE Payer")]
	public IEnumerable<Tuple_GDKRbfOIHhLGieQSVDEMIaDPX> SDE_Payer() => 
		__SDE_Payer.Value;

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
		var k_ = context.Operators.Where<Encounter>(i_, j_);

		return k_;
	}

    [CqlDeclaration("Qualifying Encounters")]
	public IEnumerable<Encounter> Qualifying_Encounters() => 
		__Qualifying_Encounters.Value;

	private IEnumerable<Encounter> Two_Outpatient_Encounters_during_Measurement_Period_Value()
	{
		var a_ = this.Qualifying_Encounters();
		var c_ = context.Operators.CrossJoin<Encounter, Encounter>(a_, a_);
		Tuple_FGYJHhbRRZTDGeEKJQJIIbGUe d_(ValueTuple<Encounter,Encounter> _valueTuple)
		{
			var j_ = new Tuple_FGYJHhbRRZTDGeEKJQJIIbGUe
			{
				OfficeVisit1 = _valueTuple.Item1,
				OfficeVisit2 = _valueTuple.Item2,
			};

			return j_;
		};
		var e_ = context.Operators.Select<ValueTuple<Encounter,Encounter>, Tuple_FGYJHhbRRZTDGeEKJQJIIbGUe>(c_, d_);
		bool? f_(Tuple_FGYJHhbRRZTDGeEKJQJIIbGUe tuple_fgyjhhbrrztdgeekjqjiibgue)
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
		var g_ = context.Operators.Where<Tuple_FGYJHhbRRZTDGeEKJQJIIbGUe>(e_, f_);
		Encounter h_(Tuple_FGYJHhbRRZTDGeEKJQJIIbGUe tuple_fgyjhhbrrztdgeekjqjiibgue) => 
			tuple_fgyjhhbrrztdgeekjqjiibgue.OfficeVisit1;
		var i_ = context.Operators.Select<Tuple_FGYJHhbRRZTDGeEKJQJIIbGUe, Encounter>(g_, h_);

		return i_;
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
		var g_ = context.Operators.GreaterOrEqual(f_, 18);
		var h_ = this.Heart_Failure();
		var i_ = context.Operators.RetrieveByValueSet<Condition>(h_, null);
		bool? j_(Condition HeartFailure)
		{
			var q_ = QICoreCommon_2_0_000.ToPrevalenceInterval(HeartFailure);
			var r_ = this.Measurement_Period();
			var s_ = context.Operators.OverlapsBefore(q_, r_, null);

			return s_;
		};
		var k_ = context.Operators.Where<Condition>(i_, j_);
		var l_ = context.Operators.Exists<Condition>(k_);
		var m_ = context.Operators.And(g_, l_);
		var n_ = this.Two_Outpatient_Encounters_during_Measurement_Period();
		var o_ = context.Operators.Exists<Encounter>(n_);
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
		var f_ = context.Operators.Where<Condition>(d_, e_);
		var g_ = context.Operators.Exists<Condition>(f_);
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
		var e_ = this.PROMIS_10_Global_Physical_Health__GPH__score_T_score();
		var f_ = context.Operators.ToList<CqlCode>(e_);
		var g_ = context.Operators.RetrieveByCodes<Observation>(f_, null);
		var h_ = Status_1_6_000.Final_Survey_Observation(g_);
		var i_ = context.Operators.CrossJoin<Observation, Observation>(d_, h_);
		Tuple_CSQNXjbdUJCRVLSGAJQOISbPM j_(ValueTuple<Observation,Observation> _valueTuple)
		{
			var p_ = new Tuple_CSQNXjbdUJCRVLSGAJQOISbPM
			{
				PROMIS10MentalScore = _valueTuple.Item1,
				PROMIS10PhysicalScore = _valueTuple.Item2,
			};

			return p_;
		};
		var k_ = context.Operators.Select<ValueTuple<Observation,Observation>, Tuple_CSQNXjbdUJCRVLSGAJQOISbPM>(i_, j_);
		bool? l_(Tuple_CSQNXjbdUJCRVLSGAJQOISbPM tuple_csqnxjbdujcrvlsgajqoisbpm)
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
		var m_ = context.Operators.Where<Tuple_CSQNXjbdUJCRVLSGAJQOISbPM>(k_, l_);
		CqlDate n_(Tuple_CSQNXjbdUJCRVLSGAJQOISbPM tuple_csqnxjbdujcrvlsgajqoisbpm)
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
			var ao_ = context.Operators.Max<CqlDate>((an_ as IEnumerable<CqlDate>));

			return ao_;
		};
		var o_ = context.Operators.Select<Tuple_CSQNXjbdUJCRVLSGAJQOISbPM, CqlDate>(m_, n_);

		return o_;
	}

    [CqlDeclaration("Date PROMIS10 Total Assessment Completed")]
	public IEnumerable<CqlDate> Date_PROMIS10_Total_Assessment_Completed() => 
		__Date_PROMIS10_Total_Assessment_Completed.Value;

	private bool? Has_Encounter_with_Initial_and_Follow_Up_PROMIS10_Assessments_Value()
	{
		var a_ = this.Qualifying_Encounters();
		var b_ = this.Date_PROMIS10_Total_Assessment_Completed();
		var d_ = context.Operators.CrossJoin<Encounter, CqlDate, CqlDate>(a_, b_, b_);
		Tuple_BaPOXCdQPieFFFdPRAYQHJVMK e_(ValueTuple<Encounter,CqlDate,CqlDate> _valueTuple)
		{
			var l_ = new Tuple_BaPOXCdQPieFFFdPRAYQHJVMK
			{
				ValidEncounters = _valueTuple.Item1,
				InitialPROMIS10Date = _valueTuple.Item2,
				FollowupPROMIS10Date = _valueTuple.Item3,
			};

			return l_;
		};
		var f_ = context.Operators.Select<ValueTuple<Encounter,CqlDate,CqlDate>, Tuple_BaPOXCdQPieFFFdPRAYQHJVMK>(d_, e_);
		bool? g_(Tuple_BaPOXCdQPieFFFdPRAYQHJVMK tuple_bapoxcdqpiefffdprayqhjvmk)
		{
			var m_ = FHIRHelpers_4_3_000.ToInterval(tuple_bapoxcdqpiefffdprayqhjvmk.ValidEncounters?.Period);
			var n_ = QICoreCommon_2_0_000.ToInterval((m_ as object));
			var o_ = context.Operators.End(n_);
			var p_ = this.Measurement_Period();
			var q_ = context.Operators.End(p_);
			var r_ = context.Operators.Quantity(180m, "days");
			var s_ = context.Operators.Subtract(q_, r_);
			var t_ = context.Operators.SameOrBefore(o_, s_, "day");
			var u_ = context.Operators.ConvertDateToDateTime(tuple_bapoxcdqpiefffdprayqhjvmk.InitialPROMIS10Date);
			var w_ = QICoreCommon_2_0_000.ToInterval((m_ as object));
			var x_ = context.Operators.End(w_);
			var y_ = context.Operators.Quantity(14m, "days");
			var z_ = context.Operators.Subtract(x_, y_);
			var ab_ = QICoreCommon_2_0_000.ToInterval((m_ as object));
			var ac_ = context.Operators.End(ab_);
			var ad_ = context.Operators.Interval(z_, ac_, true, true);
			var ae_ = context.Operators.In<CqlDateTime>(u_, ad_, "day");
			var ag_ = QICoreCommon_2_0_000.ToInterval((m_ as object));
			var ah_ = context.Operators.End(ag_);
			var ai_ = context.Operators.Not((bool?)(ah_ is null));
			var aj_ = context.Operators.And(ae_, ai_);
			var ak_ = context.Operators.And(t_, aj_);
			var al_ = context.Operators.ConvertDateToDateTime(tuple_bapoxcdqpiefffdprayqhjvmk.FollowupPROMIS10Date);
			var am_ = context.Operators.DateFrom(al_);
			var ao_ = context.Operators.DateFrom(u_);
			var ap_ = context.Operators.Quantity(30m, "days");
			var aq_ = context.Operators.Add(ao_, ap_);
			var as_ = context.Operators.DateFrom(u_);
			var au_ = context.Operators.Add(as_, r_);
			var av_ = context.Operators.Interval(aq_, au_, true, true);
			var aw_ = context.Operators.In<CqlDate>(am_, av_, "day");
			var ax_ = context.Operators.And(ak_, aw_);

			return ax_;
		};
		var h_ = context.Operators.Where<Tuple_BaPOXCdQPieFFFdPRAYQHJVMK>(f_, g_);
		Encounter i_(Tuple_BaPOXCdQPieFFFdPRAYQHJVMK tuple_bapoxcdqpiefffdprayqhjvmk) => 
			tuple_bapoxcdqpiefffdprayqhjvmk.ValidEncounters;
		var j_ = context.Operators.Select<Tuple_BaPOXCdQPieFFFdPRAYQHJVMK, Encounter>(h_, i_);
		var k_ = context.Operators.Exists<Encounter>(j_);

		return k_;
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
		var e_ = this.PROMIS_29_Satisfaction_with_participation_in_social_roles_score_T_score();
		var f_ = context.Operators.ToList<CqlCode>(e_);
		var g_ = context.Operators.RetrieveByCodes<Observation>(f_, null);
		var h_ = Status_1_6_000.Final_Survey_Observation(g_);
		var i_ = this.PROMIS_29_Physical_function_score_T_score();
		var j_ = context.Operators.ToList<CqlCode>(i_);
		var k_ = context.Operators.RetrieveByCodes<Observation>(j_, null);
		var l_ = Status_1_6_000.Final_Survey_Observation(k_);
		var m_ = this.PROMIS_29_Pain_interference_score_T_score();
		var n_ = context.Operators.ToList<CqlCode>(m_);
		var o_ = context.Operators.RetrieveByCodes<Observation>(n_, null);
		var p_ = Status_1_6_000.Final_Survey_Observation(o_);
		var q_ = this.PROMIS_29_Fatigue_score_T_score();
		var r_ = context.Operators.ToList<CqlCode>(q_);
		var s_ = context.Operators.RetrieveByCodes<Observation>(r_, null);
		var t_ = Status_1_6_000.Final_Survey_Observation(s_);
		var u_ = this.PROMIS_29_Depression_score_T_score();
		var v_ = context.Operators.ToList<CqlCode>(u_);
		var w_ = context.Operators.RetrieveByCodes<Observation>(v_, null);
		var x_ = Status_1_6_000.Final_Survey_Observation(w_);
		var y_ = this.PROMIS_29_Anxiety_score_T_score();
		var z_ = context.Operators.ToList<CqlCode>(y_);
		var aa_ = context.Operators.RetrieveByCodes<Observation>(z_, null);
		var ab_ = Status_1_6_000.Final_Survey_Observation(aa_);
		var ac_ = context.Operators.CrossJoin<Observation, Observation, Observation, Observation, Observation, Observation, Observation>(d_, h_, l_, p_, t_, x_, ab_);
		Tuple_ITZjeBeBSEgNiFGcLhJYIJNb ad_(ValueTuple<Observation,Observation,Observation,Observation,Observation,Observation,Observation> _valueTuple)
		{
			var aj_ = new Tuple_ITZjeBeBSEgNiFGcLhJYIJNb
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
		var ae_ = context.Operators.Select<ValueTuple<Observation,Observation,Observation,Observation,Observation,Observation,Observation>, Tuple_ITZjeBeBSEgNiFGcLhJYIJNb>(ac_, ad_);
		bool? af_(Tuple_ITZjeBeBSEgNiFGcLhJYIJNb tuple_itzjebebsegnifgclhjyijnb)
		{
			var ak_ = FHIRHelpers_4_3_000.ToValue(tuple_itzjebebsegnifgclhjyijnb.Promis29Sleep?.Effective);
			var al_ = QICoreCommon_2_0_000.ToInterval(ak_);
			var am_ = context.Operators.Start(al_);
			var an_ = context.Operators.DateFrom(am_);
			var ao_ = FHIRHelpers_4_3_000.ToValue(tuple_itzjebebsegnifgclhjyijnb.Promis29SocialRoles?.Effective);
			var ap_ = QICoreCommon_2_0_000.ToInterval(ao_);
			var aq_ = context.Operators.Start(ap_);
			var ar_ = context.Operators.DateFrom(aq_);
			var as_ = context.Operators.SameAs(an_, ar_, "day");
			var at_ = FHIRHelpers_4_3_000.ToValue(tuple_itzjebebsegnifgclhjyijnb.Promis29SocialRoles?.Value);
			var au_ = context.Operators.Not((bool?)(at_ is null));
			var av_ = context.Operators.And(as_, au_);
			var ax_ = QICoreCommon_2_0_000.ToInterval(ak_);
			var ay_ = context.Operators.Start(ax_);
			var az_ = context.Operators.DateFrom(ay_);
			var ba_ = FHIRHelpers_4_3_000.ToValue(tuple_itzjebebsegnifgclhjyijnb.Promis29Physical?.Effective);
			var bb_ = QICoreCommon_2_0_000.ToInterval(ba_);
			var bc_ = context.Operators.Start(bb_);
			var bd_ = context.Operators.DateFrom(bc_);
			var be_ = context.Operators.SameAs(az_, bd_, "day");
			var bf_ = context.Operators.And(av_, be_);
			var bg_ = FHIRHelpers_4_3_000.ToValue(tuple_itzjebebsegnifgclhjyijnb.Promis29Physical?.Value);
			var bh_ = context.Operators.Not((bool?)(bg_ is null));
			var bi_ = context.Operators.And(bf_, bh_);
			var bk_ = QICoreCommon_2_0_000.ToInterval(ak_);
			var bl_ = context.Operators.Start(bk_);
			var bm_ = context.Operators.DateFrom(bl_);
			var bn_ = FHIRHelpers_4_3_000.ToValue(tuple_itzjebebsegnifgclhjyijnb.Promis29Pain?.Effective);
			var bo_ = QICoreCommon_2_0_000.ToInterval(bn_);
			var bp_ = context.Operators.Start(bo_);
			var bq_ = context.Operators.DateFrom(bp_);
			var br_ = context.Operators.SameAs(bm_, bq_, "day");
			var bs_ = context.Operators.And(bi_, br_);
			var bt_ = FHIRHelpers_4_3_000.ToValue(tuple_itzjebebsegnifgclhjyijnb.Promis29Pain?.Value);
			var bu_ = context.Operators.Not((bool?)(bt_ is null));
			var bv_ = context.Operators.And(bs_, bu_);
			var bx_ = QICoreCommon_2_0_000.ToInterval(ak_);
			var by_ = context.Operators.Start(bx_);
			var bz_ = context.Operators.DateFrom(by_);
			var ca_ = FHIRHelpers_4_3_000.ToValue(tuple_itzjebebsegnifgclhjyijnb.Promis29Fatigue?.Effective);
			var cb_ = QICoreCommon_2_0_000.ToInterval(ca_);
			var cc_ = context.Operators.Start(cb_);
			var cd_ = context.Operators.DateFrom(cc_);
			var ce_ = context.Operators.SameAs(bz_, cd_, "day");
			var cf_ = context.Operators.And(bv_, ce_);
			var cg_ = FHIRHelpers_4_3_000.ToValue(tuple_itzjebebsegnifgclhjyijnb.Promis29Fatigue?.Value);
			var ch_ = context.Operators.Not((bool?)(cg_ is null));
			var ci_ = context.Operators.And(cf_, ch_);
			var ck_ = QICoreCommon_2_0_000.ToInterval(ak_);
			var cl_ = context.Operators.Start(ck_);
			var cm_ = context.Operators.DateFrom(cl_);
			var cn_ = FHIRHelpers_4_3_000.ToValue(tuple_itzjebebsegnifgclhjyijnb.Promis29Depression?.Effective);
			var co_ = QICoreCommon_2_0_000.ToInterval(cn_);
			var cp_ = context.Operators.Start(co_);
			var cq_ = context.Operators.DateFrom(cp_);
			var cr_ = context.Operators.SameAs(cm_, cq_, "day");
			var cs_ = context.Operators.And(ci_, cr_);
			var ct_ = FHIRHelpers_4_3_000.ToValue(tuple_itzjebebsegnifgclhjyijnb.Promis29Depression?.Value);
			var cu_ = context.Operators.Not((bool?)(ct_ is null));
			var cv_ = context.Operators.And(cs_, cu_);
			var cx_ = QICoreCommon_2_0_000.ToInterval(ak_);
			var cy_ = context.Operators.Start(cx_);
			var cz_ = context.Operators.DateFrom(cy_);
			var da_ = FHIRHelpers_4_3_000.ToValue(tuple_itzjebebsegnifgclhjyijnb.Promis29Anxiety?.Effective);
			var db_ = QICoreCommon_2_0_000.ToInterval(da_);
			var dc_ = context.Operators.Start(db_);
			var dd_ = context.Operators.DateFrom(dc_);
			var de_ = context.Operators.SameAs(cz_, dd_, "day");
			var df_ = context.Operators.And(cv_, de_);
			var dg_ = FHIRHelpers_4_3_000.ToValue(tuple_itzjebebsegnifgclhjyijnb.Promis29Anxiety?.Value);
			var dh_ = context.Operators.Not((bool?)(dg_ is null));
			var di_ = context.Operators.And(df_, dh_);
			var dj_ = FHIRHelpers_4_3_000.ToValue(tuple_itzjebebsegnifgclhjyijnb.Promis29Sleep?.Value);
			var dk_ = context.Operators.Not((bool?)(dj_ is null));
			var dl_ = context.Operators.And(di_, dk_);

			return dl_;
		};
		var ag_ = context.Operators.Where<Tuple_ITZjeBeBSEgNiFGcLhJYIJNb>(ae_, af_);
		CqlDate ah_(Tuple_ITZjeBeBSEgNiFGcLhJYIJNb tuple_itzjebebsegnifgclhjyijnb)
		{
			var dm_ = FHIRHelpers_4_3_000.ToValue(tuple_itzjebebsegnifgclhjyijnb.Promis29Sleep?.Effective);
			var dn_ = QICoreCommon_2_0_000.ToInterval(dm_);
			var do_ = context.Operators.Start(dn_);
			var dp_ = context.Operators.DateFrom(do_);
			var dq_ = FHIRHelpers_4_3_000.ToValue(tuple_itzjebebsegnifgclhjyijnb.Promis29SocialRoles?.Effective);
			var dr_ = QICoreCommon_2_0_000.ToInterval(dq_);
			var ds_ = context.Operators.Start(dr_);
			var dt_ = context.Operators.DateFrom(ds_);
			var du_ = FHIRHelpers_4_3_000.ToValue(tuple_itzjebebsegnifgclhjyijnb.Promis29Physical?.Effective);
			var dv_ = QICoreCommon_2_0_000.ToInterval(du_);
			var dw_ = context.Operators.Start(dv_);
			var dx_ = context.Operators.DateFrom(dw_);
			var dy_ = FHIRHelpers_4_3_000.ToValue(tuple_itzjebebsegnifgclhjyijnb.Promis29Pain?.Effective);
			var dz_ = QICoreCommon_2_0_000.ToInterval(dy_);
			var ea_ = context.Operators.Start(dz_);
			var eb_ = context.Operators.DateFrom(ea_);
			var ec_ = FHIRHelpers_4_3_000.ToValue(tuple_itzjebebsegnifgclhjyijnb.Promis29Fatigue?.Effective);
			var ed_ = QICoreCommon_2_0_000.ToInterval(ec_);
			var ee_ = context.Operators.Start(ed_);
			var ef_ = context.Operators.DateFrom(ee_);
			var eg_ = FHIRHelpers_4_3_000.ToValue(tuple_itzjebebsegnifgclhjyijnb.Promis29Depression?.Effective);
			var eh_ = QICoreCommon_2_0_000.ToInterval(eg_);
			var ei_ = context.Operators.Start(eh_);
			var ej_ = context.Operators.DateFrom(ei_);
			var ek_ = FHIRHelpers_4_3_000.ToValue(tuple_itzjebebsegnifgclhjyijnb.Promis29Anxiety?.Effective);
			var el_ = QICoreCommon_2_0_000.ToInterval(ek_);
			var em_ = context.Operators.Start(el_);
			var en_ = context.Operators.DateFrom(em_);
			var eo_ = new CqlDate[]
			{
				dp_,
				dt_,
				dx_,
				eb_,
				ef_,
				ej_,
				en_,
			};
			var ep_ = context.Operators.Max<CqlDate>((eo_ as IEnumerable<CqlDate>));

			return ep_;
		};
		var ai_ = context.Operators.Select<Tuple_ITZjeBeBSEgNiFGcLhJYIJNb, CqlDate>(ag_, ah_);

		return ai_;
	}

    [CqlDeclaration("Date PROMIS29 Total Assessment Completed")]
	public IEnumerable<CqlDate> Date_PROMIS29_Total_Assessment_Completed() => 
		__Date_PROMIS29_Total_Assessment_Completed.Value;

	private bool? Has_Encounter_with_Initial_and_Follow_Up_PROMIS29_Assessments_Value()
	{
		var a_ = this.Qualifying_Encounters();
		var b_ = this.Date_PROMIS29_Total_Assessment_Completed();
		var d_ = context.Operators.CrossJoin<Encounter, CqlDate, CqlDate>(a_, b_, b_);
		Tuple_DcgYAFMUGiITLMLBigQTHXaba e_(ValueTuple<Encounter,CqlDate,CqlDate> _valueTuple)
		{
			var l_ = new Tuple_DcgYAFMUGiITLMLBigQTHXaba
			{
				ValidEncounters = _valueTuple.Item1,
				InitialPROMIS29Date = _valueTuple.Item2,
				FollowupPROMIS29Date = _valueTuple.Item3,
			};

			return l_;
		};
		var f_ = context.Operators.Select<ValueTuple<Encounter,CqlDate,CqlDate>, Tuple_DcgYAFMUGiITLMLBigQTHXaba>(d_, e_);
		bool? g_(Tuple_DcgYAFMUGiITLMLBigQTHXaba tuple_dcgyafmugiitlmlbigqthxaba)
		{
			var m_ = FHIRHelpers_4_3_000.ToInterval(tuple_dcgyafmugiitlmlbigqthxaba.ValidEncounters?.Period);
			var n_ = QICoreCommon_2_0_000.ToInterval((m_ as object));
			var o_ = context.Operators.End(n_);
			var p_ = this.Measurement_Period();
			var q_ = context.Operators.End(p_);
			var r_ = context.Operators.Quantity(180m, "days");
			var s_ = context.Operators.Subtract(q_, r_);
			var t_ = context.Operators.SameOrBefore(o_, s_, "day");
			var u_ = context.Operators.ConvertDateToDateTime(tuple_dcgyafmugiitlmlbigqthxaba.InitialPROMIS29Date);
			var w_ = QICoreCommon_2_0_000.ToInterval((m_ as object));
			var x_ = context.Operators.End(w_);
			var y_ = context.Operators.Quantity(14m, "days");
			var z_ = context.Operators.Subtract(x_, y_);
			var ab_ = QICoreCommon_2_0_000.ToInterval((m_ as object));
			var ac_ = context.Operators.End(ab_);
			var ad_ = context.Operators.Interval(z_, ac_, true, true);
			var ae_ = context.Operators.In<CqlDateTime>(u_, ad_, "day");
			var ag_ = QICoreCommon_2_0_000.ToInterval((m_ as object));
			var ah_ = context.Operators.End(ag_);
			var ai_ = context.Operators.Not((bool?)(ah_ is null));
			var aj_ = context.Operators.And(ae_, ai_);
			var ak_ = context.Operators.And(t_, aj_);
			var al_ = context.Operators.ConvertDateToDateTime(tuple_dcgyafmugiitlmlbigqthxaba.FollowupPROMIS29Date);
			var am_ = context.Operators.DateFrom(al_);
			var ao_ = context.Operators.DateFrom(u_);
			var ap_ = context.Operators.Quantity(30m, "days");
			var aq_ = context.Operators.Add(ao_, ap_);
			var as_ = context.Operators.DateFrom(u_);
			var au_ = context.Operators.Add(as_, r_);
			var av_ = context.Operators.Interval(aq_, au_, true, true);
			var aw_ = context.Operators.In<CqlDate>(am_, av_, "day");
			var ax_ = context.Operators.And(ak_, aw_);

			return ax_;
		};
		var h_ = context.Operators.Where<Tuple_DcgYAFMUGiITLMLBigQTHXaba>(f_, g_);
		Encounter i_(Tuple_DcgYAFMUGiITLMLBigQTHXaba tuple_dcgyafmugiitlmlbigqthxaba) => 
			tuple_dcgyafmugiitlmlbigqthxaba.ValidEncounters;
		var j_ = context.Operators.Select<Tuple_DcgYAFMUGiITLMLBigQTHXaba, Encounter>(h_, i_);
		var k_ = context.Operators.Exists<Encounter>(j_);

		return k_;
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
		var e_ = this.VR_12_Physical_component_summary__PCS__score___oblique_method_T_score();
		var f_ = context.Operators.ToList<CqlCode>(e_);
		var g_ = context.Operators.RetrieveByCodes<Observation>(f_, null);
		var h_ = Status_1_6_000.Final_Survey_Observation(g_);
		var i_ = context.Operators.CrossJoin<Observation, Observation>(d_, h_);
		Tuple_aWLEFJMGFWIGJKOEOKKQfQiJ j_(ValueTuple<Observation,Observation> _valueTuple)
		{
			var p_ = new Tuple_aWLEFJMGFWIGJKOEOKKQfQiJ
			{
				VR12MentalAssessment = _valueTuple.Item1,
				VR12PhysicalAssessment = _valueTuple.Item2,
			};

			return p_;
		};
		var k_ = context.Operators.Select<ValueTuple<Observation,Observation>, Tuple_aWLEFJMGFWIGJKOEOKKQfQiJ>(i_, j_);
		bool? l_(Tuple_aWLEFJMGFWIGJKOEOKKQfQiJ tuple_awlefjmgfwigjkoeokkqfqij)
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
		var m_ = context.Operators.Where<Tuple_aWLEFJMGFWIGJKOEOKKQfQiJ>(k_, l_);
		CqlDate n_(Tuple_aWLEFJMGFWIGJKOEOKKQfQiJ tuple_awlefjmgfwigjkoeokkqfqij)
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
			var ao_ = context.Operators.Max<CqlDate>((an_ as IEnumerable<CqlDate>));

			return ao_;
		};
		var o_ = context.Operators.Select<Tuple_aWLEFJMGFWIGJKOEOKKQfQiJ, CqlDate>(m_, n_);

		return o_;
	}

    [CqlDeclaration("Date VR12 Oblique Total Assessment Completed")]
	public IEnumerable<CqlDate> Date_VR12_Oblique_Total_Assessment_Completed() => 
		__Date_VR12_Oblique_Total_Assessment_Completed.Value;

	private bool? Has_Encounter_with_Initial_and_Follow_Up_VR12_Oblique_Assessments_Value()
	{
		var a_ = this.Qualifying_Encounters();
		var b_ = this.Date_VR12_Oblique_Total_Assessment_Completed();
		var d_ = context.Operators.CrossJoin<Encounter, CqlDate, CqlDate>(a_, b_, b_);
		Tuple_EhGfQcQTPMaVGfjeRNgbDIGOU e_(ValueTuple<Encounter,CqlDate,CqlDate> _valueTuple)
		{
			var l_ = new Tuple_EhGfQcQTPMaVGfjeRNgbDIGOU
			{
				ValidEncounters = _valueTuple.Item1,
				InitialVR12ObliqueDate = _valueTuple.Item2,
				FollowupVR12ObliqueDate = _valueTuple.Item3,
			};

			return l_;
		};
		var f_ = context.Operators.Select<ValueTuple<Encounter,CqlDate,CqlDate>, Tuple_EhGfQcQTPMaVGfjeRNgbDIGOU>(d_, e_);
		bool? g_(Tuple_EhGfQcQTPMaVGfjeRNgbDIGOU tuple_ehgfqcqtpmavgfjerngbdigou)
		{
			var m_ = FHIRHelpers_4_3_000.ToInterval(tuple_ehgfqcqtpmavgfjerngbdigou.ValidEncounters?.Period);
			var n_ = QICoreCommon_2_0_000.ToInterval((m_ as object));
			var o_ = context.Operators.End(n_);
			var p_ = this.Measurement_Period();
			var q_ = context.Operators.End(p_);
			var r_ = context.Operators.Quantity(180m, "days");
			var s_ = context.Operators.Subtract(q_, r_);
			var t_ = context.Operators.SameOrBefore(o_, s_, "day");
			var u_ = context.Operators.ConvertDateToDateTime(tuple_ehgfqcqtpmavgfjerngbdigou.InitialVR12ObliqueDate);
			var w_ = QICoreCommon_2_0_000.ToInterval((m_ as object));
			var x_ = context.Operators.End(w_);
			var y_ = context.Operators.Quantity(14m, "days");
			var z_ = context.Operators.Subtract(x_, y_);
			var ab_ = QICoreCommon_2_0_000.ToInterval((m_ as object));
			var ac_ = context.Operators.End(ab_);
			var ad_ = context.Operators.Interval(z_, ac_, true, true);
			var ae_ = context.Operators.In<CqlDateTime>(u_, ad_, "day");
			var ag_ = QICoreCommon_2_0_000.ToInterval((m_ as object));
			var ah_ = context.Operators.End(ag_);
			var ai_ = context.Operators.Not((bool?)(ah_ is null));
			var aj_ = context.Operators.And(ae_, ai_);
			var ak_ = context.Operators.And(t_, aj_);
			var al_ = context.Operators.ConvertDateToDateTime(tuple_ehgfqcqtpmavgfjerngbdigou.FollowupVR12ObliqueDate);
			var am_ = context.Operators.DateFrom(al_);
			var ao_ = context.Operators.DateFrom(u_);
			var ap_ = context.Operators.Quantity(30m, "days");
			var aq_ = context.Operators.Add(ao_, ap_);
			var as_ = context.Operators.DateFrom(u_);
			var au_ = context.Operators.Add(as_, r_);
			var av_ = context.Operators.Interval(aq_, au_, true, true);
			var aw_ = context.Operators.In<CqlDate>(am_, av_, "day");
			var ax_ = context.Operators.And(ak_, aw_);

			return ax_;
		};
		var h_ = context.Operators.Where<Tuple_EhGfQcQTPMaVGfjeRNgbDIGOU>(f_, g_);
		Encounter i_(Tuple_EhGfQcQTPMaVGfjeRNgbDIGOU tuple_ehgfqcqtpmavgfjerngbdigou) => 
			tuple_ehgfqcqtpmavgfjerngbdigou.ValidEncounters;
		var j_ = context.Operators.Select<Tuple_EhGfQcQTPMaVGfjeRNgbDIGOU, Encounter>(h_, i_);
		var k_ = context.Operators.Exists<Encounter>(j_);

		return k_;
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
		var e_ = this.VR_12_Physical_component_summary__PCS__score___orthogonal_method_T_score();
		var f_ = context.Operators.ToList<CqlCode>(e_);
		var g_ = context.Operators.RetrieveByCodes<Observation>(f_, null);
		var h_ = Status_1_6_000.Final_Survey_Observation(g_);
		var i_ = context.Operators.CrossJoin<Observation, Observation>(d_, h_);
		Tuple_aWLEFJMGFWIGJKOEOKKQfQiJ j_(ValueTuple<Observation,Observation> _valueTuple)
		{
			var p_ = new Tuple_aWLEFJMGFWIGJKOEOKKQfQiJ
			{
				VR12MentalAssessment = _valueTuple.Item1,
				VR12PhysicalAssessment = _valueTuple.Item2,
			};

			return p_;
		};
		var k_ = context.Operators.Select<ValueTuple<Observation,Observation>, Tuple_aWLEFJMGFWIGJKOEOKKQfQiJ>(i_, j_);
		bool? l_(Tuple_aWLEFJMGFWIGJKOEOKKQfQiJ tuple_awlefjmgfwigjkoeokkqfqij)
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
		var m_ = context.Operators.Where<Tuple_aWLEFJMGFWIGJKOEOKKQfQiJ>(k_, l_);
		CqlDate n_(Tuple_aWLEFJMGFWIGJKOEOKKQfQiJ tuple_awlefjmgfwigjkoeokkqfqij)
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
			var ao_ = context.Operators.Max<CqlDate>((an_ as IEnumerable<CqlDate>));

			return ao_;
		};
		var o_ = context.Operators.Select<Tuple_aWLEFJMGFWIGJKOEOKKQfQiJ, CqlDate>(m_, n_);

		return o_;
	}

    [CqlDeclaration("Date VR12 Orthogonal Total Assessment Completed")]
	public IEnumerable<CqlDate> Date_VR12_Orthogonal_Total_Assessment_Completed() => 
		__Date_VR12_Orthogonal_Total_Assessment_Completed.Value;

	private bool? Has_Encounter_with_Initial_and_Follow_Up_VR12_Orthogonal_Assessments_Value()
	{
		var a_ = this.Qualifying_Encounters();
		var b_ = this.Date_VR12_Orthogonal_Total_Assessment_Completed();
		var d_ = context.Operators.CrossJoin<Encounter, CqlDate, CqlDate>(a_, b_, b_);
		Tuple_DaTHNXWGHIVRYGRfGdXJYJKRZ e_(ValueTuple<Encounter,CqlDate,CqlDate> _valueTuple)
		{
			var l_ = new Tuple_DaTHNXWGHIVRYGRfGdXJYJKRZ
			{
				ValidEncounters = _valueTuple.Item1,
				InitialVR12OrthogonalDate = _valueTuple.Item2,
				FollowupVR12OrthogonalDate = _valueTuple.Item3,
			};

			return l_;
		};
		var f_ = context.Operators.Select<ValueTuple<Encounter,CqlDate,CqlDate>, Tuple_DaTHNXWGHIVRYGRfGdXJYJKRZ>(d_, e_);
		bool? g_(Tuple_DaTHNXWGHIVRYGRfGdXJYJKRZ tuple_dathnxwghivrygrfgdxjyjkrz)
		{
			var m_ = FHIRHelpers_4_3_000.ToInterval(tuple_dathnxwghivrygrfgdxjyjkrz.ValidEncounters?.Period);
			var n_ = QICoreCommon_2_0_000.ToInterval((m_ as object));
			var o_ = context.Operators.End(n_);
			var p_ = this.Measurement_Period();
			var q_ = context.Operators.End(p_);
			var r_ = context.Operators.Quantity(180m, "days");
			var s_ = context.Operators.Subtract(q_, r_);
			var t_ = context.Operators.SameOrBefore(o_, s_, "day");
			var u_ = context.Operators.ConvertDateToDateTime(tuple_dathnxwghivrygrfgdxjyjkrz.InitialVR12OrthogonalDate);
			var w_ = QICoreCommon_2_0_000.ToInterval((m_ as object));
			var x_ = context.Operators.End(w_);
			var y_ = context.Operators.Quantity(14m, "days");
			var z_ = context.Operators.Subtract(x_, y_);
			var ab_ = QICoreCommon_2_0_000.ToInterval((m_ as object));
			var ac_ = context.Operators.End(ab_);
			var ad_ = context.Operators.Interval(z_, ac_, true, true);
			var ae_ = context.Operators.In<CqlDateTime>(u_, ad_, "day");
			var ag_ = QICoreCommon_2_0_000.ToInterval((m_ as object));
			var ah_ = context.Operators.End(ag_);
			var ai_ = context.Operators.Not((bool?)(ah_ is null));
			var aj_ = context.Operators.And(ae_, ai_);
			var ak_ = context.Operators.And(t_, aj_);
			var al_ = context.Operators.ConvertDateToDateTime(tuple_dathnxwghivrygrfgdxjyjkrz.FollowupVR12OrthogonalDate);
			var am_ = context.Operators.DateFrom(al_);
			var ao_ = context.Operators.DateFrom(u_);
			var ap_ = context.Operators.Quantity(30m, "days");
			var aq_ = context.Operators.Add(ao_, ap_);
			var as_ = context.Operators.DateFrom(u_);
			var au_ = context.Operators.Add(as_, r_);
			var av_ = context.Operators.Interval(aq_, au_, true, true);
			var aw_ = context.Operators.In<CqlDate>(am_, av_, "day");
			var ax_ = context.Operators.And(ak_, aw_);

			return ax_;
		};
		var h_ = context.Operators.Where<Tuple_DaTHNXWGHIVRYGRfGdXJYJKRZ>(f_, g_);
		Encounter i_(Tuple_DaTHNXWGHIVRYGRfGdXJYJKRZ tuple_dathnxwghivrygrfgdxjyjkrz) => 
			tuple_dathnxwghivrygrfgdxjyjkrz.ValidEncounters;
		var j_ = context.Operators.Select<Tuple_DaTHNXWGHIVRYGRfGdXJYJKRZ, Encounter>(h_, i_);
		var k_ = context.Operators.Exists<Encounter>(j_);

		return k_;
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
		var e_ = this.VR_36_Physical_component_summary__PCS__score___oblique_method_T_score();
		var f_ = context.Operators.ToList<CqlCode>(e_);
		var g_ = context.Operators.RetrieveByCodes<Observation>(f_, null);
		var h_ = Status_1_6_000.Final_Survey_Observation(g_);
		var i_ = context.Operators.CrossJoin<Observation, Observation>(d_, h_);
		Tuple_EbSJTAdMHbBibBKjAIBeBhcjh j_(ValueTuple<Observation,Observation> _valueTuple)
		{
			var p_ = new Tuple_EbSJTAdMHbBibBKjAIBeBhcjh
			{
				VR36MentalAssessment = _valueTuple.Item1,
				VR36PhysicalAssessment = _valueTuple.Item2,
			};

			return p_;
		};
		var k_ = context.Operators.Select<ValueTuple<Observation,Observation>, Tuple_EbSJTAdMHbBibBKjAIBeBhcjh>(i_, j_);
		bool? l_(Tuple_EbSJTAdMHbBibBKjAIBeBhcjh tuple_ebsjtadmhbbibbkjaibebhcjh)
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
		var m_ = context.Operators.Where<Tuple_EbSJTAdMHbBibBKjAIBeBhcjh>(k_, l_);
		CqlDate n_(Tuple_EbSJTAdMHbBibBKjAIBeBhcjh tuple_ebsjtadmhbbibbkjaibebhcjh)
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
			var ao_ = context.Operators.Max<CqlDate>((an_ as IEnumerable<CqlDate>));

			return ao_;
		};
		var o_ = context.Operators.Select<Tuple_EbSJTAdMHbBibBKjAIBeBhcjh, CqlDate>(m_, n_);

		return o_;
	}

    [CqlDeclaration("Date VR36 Oblique Total Assessment Completed")]
	public IEnumerable<CqlDate> Date_VR36_Oblique_Total_Assessment_Completed() => 
		__Date_VR36_Oblique_Total_Assessment_Completed.Value;

	private bool? Has_Encounter_with_Initial_and_Follow_Up_VR36_Oblique_Assessments_Value()
	{
		var a_ = this.Qualifying_Encounters();
		var b_ = this.Date_VR36_Oblique_Total_Assessment_Completed();
		var d_ = context.Operators.CrossJoin<Encounter, CqlDate, CqlDate>(a_, b_, b_);
		Tuple_HNUZSEJfeiQXIhXGUDXLiWidi e_(ValueTuple<Encounter,CqlDate,CqlDate> _valueTuple)
		{
			var l_ = new Tuple_HNUZSEJfeiQXIhXGUDXLiWidi
			{
				ValidEncounters = _valueTuple.Item1,
				InitialVR36ObliqueDate = _valueTuple.Item2,
				FollowupVR36ObliqueDate = _valueTuple.Item3,
			};

			return l_;
		};
		var f_ = context.Operators.Select<ValueTuple<Encounter,CqlDate,CqlDate>, Tuple_HNUZSEJfeiQXIhXGUDXLiWidi>(d_, e_);
		bool? g_(Tuple_HNUZSEJfeiQXIhXGUDXLiWidi tuple_hnuzsejfeiqxihxgudxliwidi)
		{
			var m_ = FHIRHelpers_4_3_000.ToInterval(tuple_hnuzsejfeiqxihxgudxliwidi.ValidEncounters?.Period);
			var n_ = QICoreCommon_2_0_000.ToInterval((m_ as object));
			var o_ = context.Operators.End(n_);
			var p_ = this.Measurement_Period();
			var q_ = context.Operators.End(p_);
			var r_ = context.Operators.Quantity(180m, "days");
			var s_ = context.Operators.Subtract(q_, r_);
			var t_ = context.Operators.SameOrBefore(o_, s_, "day");
			var u_ = context.Operators.ConvertDateToDateTime(tuple_hnuzsejfeiqxihxgudxliwidi.InitialVR36ObliqueDate);
			var w_ = QICoreCommon_2_0_000.ToInterval((m_ as object));
			var x_ = context.Operators.End(w_);
			var y_ = context.Operators.Quantity(14m, "days");
			var z_ = context.Operators.Subtract(x_, y_);
			var ab_ = QICoreCommon_2_0_000.ToInterval((m_ as object));
			var ac_ = context.Operators.End(ab_);
			var ad_ = context.Operators.Interval(z_, ac_, true, true);
			var ae_ = context.Operators.In<CqlDateTime>(u_, ad_, "day");
			var ag_ = QICoreCommon_2_0_000.ToInterval((m_ as object));
			var ah_ = context.Operators.End(ag_);
			var ai_ = context.Operators.Not((bool?)(ah_ is null));
			var aj_ = context.Operators.And(ae_, ai_);
			var ak_ = context.Operators.And(t_, aj_);
			var al_ = context.Operators.ConvertDateToDateTime(tuple_hnuzsejfeiqxihxgudxliwidi.FollowupVR36ObliqueDate);
			var am_ = context.Operators.DateFrom(al_);
			var ao_ = context.Operators.DateFrom(u_);
			var ap_ = context.Operators.Quantity(30m, "days");
			var aq_ = context.Operators.Add(ao_, ap_);
			var as_ = context.Operators.DateFrom(u_);
			var au_ = context.Operators.Add(as_, r_);
			var av_ = context.Operators.Interval(aq_, au_, true, true);
			var aw_ = context.Operators.In<CqlDate>(am_, av_, "day");
			var ax_ = context.Operators.And(ak_, aw_);

			return ax_;
		};
		var h_ = context.Operators.Where<Tuple_HNUZSEJfeiQXIhXGUDXLiWidi>(f_, g_);
		Encounter i_(Tuple_HNUZSEJfeiQXIhXGUDXLiWidi tuple_hnuzsejfeiqxihxgudxliwidi) => 
			tuple_hnuzsejfeiqxihxgudxliwidi.ValidEncounters;
		var j_ = context.Operators.Select<Tuple_HNUZSEJfeiQXIhXGUDXLiWidi, Encounter>(h_, i_);
		var k_ = context.Operators.Exists<Encounter>(j_);

		return k_;
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
		var e_ = this.VR_36_Physical_component_summary__PCS__score___orthogonal_method_T_score();
		var f_ = context.Operators.ToList<CqlCode>(e_);
		var g_ = context.Operators.RetrieveByCodes<Observation>(f_, null);
		var h_ = Status_1_6_000.Final_Survey_Observation(g_);
		var i_ = context.Operators.CrossJoin<Observation, Observation>(d_, h_);
		Tuple_EbSJTAdMHbBibBKjAIBeBhcjh j_(ValueTuple<Observation,Observation> _valueTuple)
		{
			var p_ = new Tuple_EbSJTAdMHbBibBKjAIBeBhcjh
			{
				VR36MentalAssessment = _valueTuple.Item1,
				VR36PhysicalAssessment = _valueTuple.Item2,
			};

			return p_;
		};
		var k_ = context.Operators.Select<ValueTuple<Observation,Observation>, Tuple_EbSJTAdMHbBibBKjAIBeBhcjh>(i_, j_);
		bool? l_(Tuple_EbSJTAdMHbBibBKjAIBeBhcjh tuple_ebsjtadmhbbibbkjaibebhcjh)
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
		var m_ = context.Operators.Where<Tuple_EbSJTAdMHbBibBKjAIBeBhcjh>(k_, l_);
		CqlDate n_(Tuple_EbSJTAdMHbBibBKjAIBeBhcjh tuple_ebsjtadmhbbibbkjaibebhcjh)
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
			var ao_ = context.Operators.Max<CqlDate>((an_ as IEnumerable<CqlDate>));

			return ao_;
		};
		var o_ = context.Operators.Select<Tuple_EbSJTAdMHbBibBKjAIBeBhcjh, CqlDate>(m_, n_);

		return o_;
	}

    [CqlDeclaration("Date VR36 Orthogonal Total Assessment Completed")]
	public IEnumerable<CqlDate> Date_VR36_Orthogonal_Total_Assessment_Completed() => 
		__Date_VR36_Orthogonal_Total_Assessment_Completed.Value;

	private bool? Has_Encounter_with_Initial_and_Follow_Up_VR36_Orthogonal_Assessments_Value()
	{
		var a_ = this.Qualifying_Encounters();
		var b_ = this.Date_VR36_Orthogonal_Total_Assessment_Completed();
		var d_ = context.Operators.CrossJoin<Encounter, CqlDate, CqlDate>(a_, b_, b_);
		Tuple_FZFeLiXHKPLAfNDgWDMeScIDi e_(ValueTuple<Encounter,CqlDate,CqlDate> _valueTuple)
		{
			var l_ = new Tuple_FZFeLiXHKPLAfNDgWDMeScIDi
			{
				ValidEncounters = _valueTuple.Item1,
				InitialVR36OrthogonalDate = _valueTuple.Item2,
				FollowupVR36OrthogonalDate = _valueTuple.Item3,
			};

			return l_;
		};
		var f_ = context.Operators.Select<ValueTuple<Encounter,CqlDate,CqlDate>, Tuple_FZFeLiXHKPLAfNDgWDMeScIDi>(d_, e_);
		bool? g_(Tuple_FZFeLiXHKPLAfNDgWDMeScIDi tuple_fzfelixhkplafndgwdmescidi)
		{
			var m_ = FHIRHelpers_4_3_000.ToInterval(tuple_fzfelixhkplafndgwdmescidi.ValidEncounters?.Period);
			var n_ = QICoreCommon_2_0_000.ToInterval((m_ as object));
			var o_ = context.Operators.End(n_);
			var p_ = this.Measurement_Period();
			var q_ = context.Operators.End(p_);
			var r_ = context.Operators.Quantity(180m, "days");
			var s_ = context.Operators.Subtract(q_, r_);
			var t_ = context.Operators.SameOrBefore(o_, s_, "day");
			var u_ = context.Operators.ConvertDateToDateTime(tuple_fzfelixhkplafndgwdmescidi.InitialVR36OrthogonalDate);
			var w_ = QICoreCommon_2_0_000.ToInterval((m_ as object));
			var x_ = context.Operators.End(w_);
			var y_ = context.Operators.Quantity(14m, "days");
			var z_ = context.Operators.Subtract(x_, y_);
			var ab_ = QICoreCommon_2_0_000.ToInterval((m_ as object));
			var ac_ = context.Operators.End(ab_);
			var ad_ = context.Operators.Interval(z_, ac_, true, true);
			var ae_ = context.Operators.In<CqlDateTime>(u_, ad_, "day");
			var ag_ = QICoreCommon_2_0_000.ToInterval((m_ as object));
			var ah_ = context.Operators.End(ag_);
			var ai_ = context.Operators.Not((bool?)(ah_ is null));
			var aj_ = context.Operators.And(ae_, ai_);
			var ak_ = context.Operators.And(t_, aj_);
			var al_ = context.Operators.ConvertDateToDateTime(tuple_fzfelixhkplafndgwdmescidi.FollowupVR36OrthogonalDate);
			var am_ = context.Operators.DateFrom(al_);
			var ao_ = context.Operators.DateFrom(u_);
			var ap_ = context.Operators.Quantity(30m, "days");
			var aq_ = context.Operators.Add(ao_, ap_);
			var as_ = context.Operators.DateFrom(u_);
			var au_ = context.Operators.Add(as_, r_);
			var av_ = context.Operators.Interval(aq_, au_, true, true);
			var aw_ = context.Operators.In<CqlDate>(am_, av_, "day");
			var ax_ = context.Operators.And(ak_, aw_);

			return ax_;
		};
		var h_ = context.Operators.Where<Tuple_FZFeLiXHKPLAfNDgWDMeScIDi>(f_, g_);
		Encounter i_(Tuple_FZFeLiXHKPLAfNDgWDMeScIDi tuple_fzfelixhkplafndgwdmescidi) => 
			tuple_fzfelixhkplafndgwdmescidi.ValidEncounters;
		var j_ = context.Operators.Select<Tuple_FZFeLiXHKPLAfNDgWDMeScIDi, Encounter>(h_, i_);
		var k_ = context.Operators.Exists<Encounter>(j_);

		return k_;
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
		var e_ = this.Emotional_score__MLHFQ_();
		var f_ = context.Operators.ToList<CqlCode>(e_);
		var g_ = context.Operators.RetrieveByCodes<Observation>(f_, null);
		var h_ = Status_1_6_000.Final_Survey_Observation(g_);
		var i_ = context.Operators.CrossJoin<Observation, Observation>(d_, h_);
		Tuple_CBaKLCFRCUhXghPfCScgCAfHU j_(ValueTuple<Observation,Observation> _valueTuple)
		{
			var p_ = new Tuple_CBaKLCFRCUhXghPfCScgCAfHU
			{
				MLHFQPhysical = _valueTuple.Item1,
				MLHFQEmotional = _valueTuple.Item2,
			};

			return p_;
		};
		var k_ = context.Operators.Select<ValueTuple<Observation,Observation>, Tuple_CBaKLCFRCUhXghPfCScgCAfHU>(i_, j_);
		bool? l_(Tuple_CBaKLCFRCUhXghPfCScgCAfHU tuple_cbaklcfrcuhxghpfcscgcafhu)
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
		var m_ = context.Operators.Where<Tuple_CBaKLCFRCUhXghPfCScgCAfHU>(k_, l_);
		CqlDate n_(Tuple_CBaKLCFRCUhXghPfCScgCAfHU tuple_cbaklcfrcuhxghpfcscgcafhu)
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
			var ao_ = context.Operators.Max<CqlDate>((an_ as IEnumerable<CqlDate>));

			return ao_;
		};
		var o_ = context.Operators.Select<Tuple_CBaKLCFRCUhXghPfCScgCAfHU, CqlDate>(m_, n_);

		return o_;
	}

    [CqlDeclaration("Date MLHFQ Total Assessment Completed")]
	public IEnumerable<CqlDate> Date_MLHFQ_Total_Assessment_Completed() => 
		__Date_MLHFQ_Total_Assessment_Completed.Value;

	private bool? Has_Encounter_with_Initial_and_Follow_Up_MLHFQ_Assessments_Value()
	{
		var a_ = this.Qualifying_Encounters();
		var b_ = this.Date_MLHFQ_Total_Assessment_Completed();
		var d_ = context.Operators.CrossJoin<Encounter, CqlDate, CqlDate>(a_, b_, b_);
		Tuple_DgNBKfGfRHaWDZaDFPZKifXLi e_(ValueTuple<Encounter,CqlDate,CqlDate> _valueTuple)
		{
			var l_ = new Tuple_DgNBKfGfRHaWDZaDFPZKifXLi
			{
				ValidEncounters = _valueTuple.Item1,
				InitialMLHFQDate = _valueTuple.Item2,
				FollowupMLHFQDate = _valueTuple.Item3,
			};

			return l_;
		};
		var f_ = context.Operators.Select<ValueTuple<Encounter,CqlDate,CqlDate>, Tuple_DgNBKfGfRHaWDZaDFPZKifXLi>(d_, e_);
		bool? g_(Tuple_DgNBKfGfRHaWDZaDFPZKifXLi tuple_dgnbkfgfrhawdzadfpzkifxli)
		{
			var m_ = FHIRHelpers_4_3_000.ToInterval(tuple_dgnbkfgfrhawdzadfpzkifxli.ValidEncounters?.Period);
			var n_ = QICoreCommon_2_0_000.ToInterval((m_ as object));
			var o_ = context.Operators.End(n_);
			var p_ = this.Measurement_Period();
			var q_ = context.Operators.End(p_);
			var r_ = context.Operators.Quantity(180m, "days");
			var s_ = context.Operators.Subtract(q_, r_);
			var t_ = context.Operators.SameOrBefore(o_, s_, "day");
			var u_ = context.Operators.ConvertDateToDateTime(tuple_dgnbkfgfrhawdzadfpzkifxli.InitialMLHFQDate);
			var w_ = QICoreCommon_2_0_000.ToInterval((m_ as object));
			var x_ = context.Operators.End(w_);
			var y_ = context.Operators.Quantity(14m, "days");
			var z_ = context.Operators.Subtract(x_, y_);
			var ab_ = QICoreCommon_2_0_000.ToInterval((m_ as object));
			var ac_ = context.Operators.End(ab_);
			var ad_ = context.Operators.Interval(z_, ac_, true, true);
			var ae_ = context.Operators.In<CqlDateTime>(u_, ad_, "day");
			var ag_ = QICoreCommon_2_0_000.ToInterval((m_ as object));
			var ah_ = context.Operators.End(ag_);
			var ai_ = context.Operators.Not((bool?)(ah_ is null));
			var aj_ = context.Operators.And(ae_, ai_);
			var ak_ = context.Operators.And(t_, aj_);
			var al_ = context.Operators.ConvertDateToDateTime(tuple_dgnbkfgfrhawdzadfpzkifxli.FollowupMLHFQDate);
			var am_ = context.Operators.DateFrom(al_);
			var ao_ = context.Operators.DateFrom(u_);
			var ap_ = context.Operators.Quantity(30m, "days");
			var aq_ = context.Operators.Add(ao_, ap_);
			var as_ = context.Operators.DateFrom(u_);
			var au_ = context.Operators.Add(as_, r_);
			var av_ = context.Operators.Interval(aq_, au_, true, true);
			var aw_ = context.Operators.In<CqlDate>(am_, av_, "day");
			var ax_ = context.Operators.And(ak_, aw_);

			return ax_;
		};
		var h_ = context.Operators.Where<Tuple_DgNBKfGfRHaWDZaDFPZKifXLi>(f_, g_);
		Encounter i_(Tuple_DgNBKfGfRHaWDZaDFPZKifXLi tuple_dgnbkfgfrhawdzadfpzkifxli) => 
			tuple_dgnbkfgfrhawdzadfpzkifxli.ValidEncounters;
		var j_ = context.Operators.Select<Tuple_DgNBKfGfRHaWDZaDFPZKifXLi, Encounter>(h_, i_);
		var k_ = context.Operators.Exists<Encounter>(j_);

		return k_;
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
		var e_ = this.Overall_summary_score__KCCQ_12_();
		var f_ = context.Operators.ToList<CqlCode>(e_);
		var g_ = context.Operators.RetrieveByCodes<Observation>(f_, null);
		var h_ = Status_1_6_000.Final_Survey_Observation(g_);
		var i_ = context.Operators.CrossJoin<Observation, Observation>(d_, h_);
		Tuple_FFJNYaMQHZAOFYMNSKAHAUdLF j_(ValueTuple<Observation,Observation> _valueTuple)
		{
			var p_ = new Tuple_FFJNYaMQHZAOFYMNSKAHAUdLF
			{
				KCCQ12Item = _valueTuple.Item1,
				KCCQ12Summary = _valueTuple.Item2,
			};

			return p_;
		};
		var k_ = context.Operators.Select<ValueTuple<Observation,Observation>, Tuple_FFJNYaMQHZAOFYMNSKAHAUdLF>(i_, j_);
		bool? l_(Tuple_FFJNYaMQHZAOFYMNSKAHAUdLF tuple_ffjnyamqhzaofymnskahaudlf)
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
		var m_ = context.Operators.Where<Tuple_FFJNYaMQHZAOFYMNSKAHAUdLF>(k_, l_);
		CqlDate n_(Tuple_FFJNYaMQHZAOFYMNSKAHAUdLF tuple_ffjnyamqhzaofymnskahaudlf)
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
			var ao_ = context.Operators.Max<CqlDate>((an_ as IEnumerable<CqlDate>));

			return ao_;
		};
		var o_ = context.Operators.Select<Tuple_FFJNYaMQHZAOFYMNSKAHAUdLF, CqlDate>(m_, n_);

		return o_;
	}

    [CqlDeclaration("Date KCCQ12 Total Assessment Completed")]
	public IEnumerable<CqlDate> Date_KCCQ12_Total_Assessment_Completed() => 
		__Date_KCCQ12_Total_Assessment_Completed.Value;

	private bool? Has_Encounter_with_Initial_and_Follow_Up_KCCQ12_Assessments_Value()
	{
		var a_ = this.Qualifying_Encounters();
		var b_ = this.Date_KCCQ12_Total_Assessment_Completed();
		var d_ = context.Operators.CrossJoin<Encounter, CqlDate, CqlDate>(a_, b_, b_);
		Tuple_DNZcZTNIZUQfFfijaYDWagbfi e_(ValueTuple<Encounter,CqlDate,CqlDate> _valueTuple)
		{
			var l_ = new Tuple_DNZcZTNIZUQfFfijaYDWagbfi
			{
				ValidEncounters = _valueTuple.Item1,
				InitialKCCQ12Date = _valueTuple.Item2,
				FollowupKCCQ12Date = _valueTuple.Item3,
			};

			return l_;
		};
		var f_ = context.Operators.Select<ValueTuple<Encounter,CqlDate,CqlDate>, Tuple_DNZcZTNIZUQfFfijaYDWagbfi>(d_, e_);
		bool? g_(Tuple_DNZcZTNIZUQfFfijaYDWagbfi tuple_dnzcztnizuqfffijaydwagbfi)
		{
			var m_ = FHIRHelpers_4_3_000.ToInterval(tuple_dnzcztnizuqfffijaydwagbfi.ValidEncounters?.Period);
			var n_ = QICoreCommon_2_0_000.ToInterval((m_ as object));
			var o_ = context.Operators.End(n_);
			var p_ = this.Measurement_Period();
			var q_ = context.Operators.End(p_);
			var r_ = context.Operators.Quantity(180m, "days");
			var s_ = context.Operators.Subtract(q_, r_);
			var t_ = context.Operators.SameOrBefore(o_, s_, "day");
			var u_ = context.Operators.ConvertDateToDateTime(tuple_dnzcztnizuqfffijaydwagbfi.InitialKCCQ12Date);
			var w_ = QICoreCommon_2_0_000.ToInterval((m_ as object));
			var x_ = context.Operators.End(w_);
			var y_ = context.Operators.Quantity(14m, "days");
			var z_ = context.Operators.Subtract(x_, y_);
			var ab_ = QICoreCommon_2_0_000.ToInterval((m_ as object));
			var ac_ = context.Operators.End(ab_);
			var ad_ = context.Operators.Interval(z_, ac_, true, true);
			var ae_ = context.Operators.In<CqlDateTime>(u_, ad_, "day");
			var ag_ = QICoreCommon_2_0_000.ToInterval((m_ as object));
			var ah_ = context.Operators.End(ag_);
			var ai_ = context.Operators.Not((bool?)(ah_ is null));
			var aj_ = context.Operators.And(ae_, ai_);
			var ak_ = context.Operators.And(t_, aj_);
			var al_ = context.Operators.ConvertDateToDateTime(tuple_dnzcztnizuqfffijaydwagbfi.FollowupKCCQ12Date);
			var am_ = context.Operators.DateFrom(al_);
			var ao_ = context.Operators.DateFrom(u_);
			var ap_ = context.Operators.Quantity(30m, "days");
			var aq_ = context.Operators.Add(ao_, ap_);
			var as_ = context.Operators.DateFrom(u_);
			var au_ = context.Operators.Add(as_, r_);
			var av_ = context.Operators.Interval(aq_, au_, true, true);
			var aw_ = context.Operators.In<CqlDate>(am_, av_, "day");
			var ax_ = context.Operators.And(ak_, aw_);

			return ax_;
		};
		var h_ = context.Operators.Where<Tuple_DNZcZTNIZUQfFfijaYDWagbfi>(f_, g_);
		Encounter i_(Tuple_DNZcZTNIZUQfFfijaYDWagbfi tuple_dnzcztnizuqfffijaydwagbfi) => 
			tuple_dnzcztnizuqfffijaydwagbfi.ValidEncounters;
		var j_ = context.Operators.Select<Tuple_DNZcZTNIZUQfFfijaYDWagbfi, Encounter>(h_, i_);
		var k_ = context.Operators.Exists<Encounter>(j_);

		return k_;
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
		var e_ = this.Symptom_stability_score__KCCQ_();
		var f_ = context.Operators.ToList<CqlCode>(e_);
		var g_ = context.Operators.RetrieveByCodes<Observation>(f_, null);
		var h_ = Status_1_6_000.Final_Survey_Observation(g_);
		var i_ = this.Self_efficacy_score__KCCQ_();
		var j_ = context.Operators.ToList<CqlCode>(i_);
		var k_ = context.Operators.RetrieveByCodes<Observation>(j_, null);
		var l_ = Status_1_6_000.Final_Survey_Observation(k_);
		var m_ = this.Total_symptom_score__KCCQ_();
		var n_ = context.Operators.ToList<CqlCode>(m_);
		var o_ = context.Operators.RetrieveByCodes<Observation>(n_, null);
		var p_ = Status_1_6_000.Final_Survey_Observation(o_);
		var q_ = this.Physical_limitation_score__KCCQ_();
		var r_ = context.Operators.ToList<CqlCode>(q_);
		var s_ = context.Operators.RetrieveByCodes<Observation>(r_, null);
		var t_ = Status_1_6_000.Final_Survey_Observation(s_);
		var u_ = this.Social_limitation_score__KCCQ_();
		var v_ = context.Operators.ToList<CqlCode>(u_);
		var w_ = context.Operators.RetrieveByCodes<Observation>(v_, null);
		var x_ = Status_1_6_000.Final_Survey_Observation(w_);
		var y_ = context.Operators.CrossJoin<Observation, Observation, Observation, Observation, Observation, Observation>(d_, h_, l_, p_, t_, x_);
		Tuple_BbiPKFIYFfdQCLCHPcXKDaFMV z_(ValueTuple<Observation,Observation,Observation,Observation,Observation,Observation> _valueTuple)
		{
			var af_ = new Tuple_BbiPKFIYFfdQCLCHPcXKDaFMV
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
		var aa_ = context.Operators.Select<ValueTuple<Observation,Observation,Observation,Observation,Observation,Observation>, Tuple_BbiPKFIYFfdQCLCHPcXKDaFMV>(y_, z_);
		bool? ab_(Tuple_BbiPKFIYFfdQCLCHPcXKDaFMV tuple_bbipkfiyffdqclchpcxkdafmv)
		{
			var ag_ = FHIRHelpers_4_3_000.ToValue(tuple_bbipkfiyffdqclchpcxkdafmv.KCCQLifeQuality?.Effective);
			var ah_ = QICoreCommon_2_0_000.ToInterval(ag_);
			var ai_ = context.Operators.Start(ah_);
			var aj_ = context.Operators.DateFrom(ai_);
			var ak_ = FHIRHelpers_4_3_000.ToValue(tuple_bbipkfiyffdqclchpcxkdafmv.KCCQSymptomStability?.Effective);
			var al_ = QICoreCommon_2_0_000.ToInterval(ak_);
			var am_ = context.Operators.Start(al_);
			var an_ = context.Operators.DateFrom(am_);
			var ao_ = context.Operators.SameAs(aj_, an_, "day");
			var ap_ = FHIRHelpers_4_3_000.ToValue(tuple_bbipkfiyffdqclchpcxkdafmv.KCCQSymptomStability?.Value);
			var aq_ = context.Operators.Not((bool?)(ap_ is null));
			var ar_ = context.Operators.And(ao_, aq_);
			var at_ = QICoreCommon_2_0_000.ToInterval(ag_);
			var au_ = context.Operators.Start(at_);
			var av_ = context.Operators.DateFrom(au_);
			var aw_ = FHIRHelpers_4_3_000.ToValue(tuple_bbipkfiyffdqclchpcxkdafmv.KCCQSelfEfficacy?.Effective);
			var ax_ = QICoreCommon_2_0_000.ToInterval(aw_);
			var ay_ = context.Operators.Start(ax_);
			var az_ = context.Operators.DateFrom(ay_);
			var ba_ = context.Operators.SameAs(av_, az_, "day");
			var bb_ = context.Operators.And(ar_, ba_);
			var bc_ = FHIRHelpers_4_3_000.ToValue(tuple_bbipkfiyffdqclchpcxkdafmv.KCCQSelfEfficacy?.Value);
			var bd_ = context.Operators.Not((bool?)(bc_ is null));
			var be_ = context.Operators.And(bb_, bd_);
			var bg_ = QICoreCommon_2_0_000.ToInterval(ag_);
			var bh_ = context.Operators.Start(bg_);
			var bi_ = context.Operators.DateFrom(bh_);
			var bj_ = FHIRHelpers_4_3_000.ToValue(tuple_bbipkfiyffdqclchpcxkdafmv.KCCQSymptoms?.Effective);
			var bk_ = QICoreCommon_2_0_000.ToInterval(bj_);
			var bl_ = context.Operators.Start(bk_);
			var bm_ = context.Operators.DateFrom(bl_);
			var bn_ = context.Operators.SameAs(bi_, bm_, "day");
			var bo_ = context.Operators.And(be_, bn_);
			var bp_ = FHIRHelpers_4_3_000.ToValue(tuple_bbipkfiyffdqclchpcxkdafmv.KCCQSymptoms?.Value);
			var bq_ = context.Operators.Not((bool?)(bp_ is null));
			var br_ = context.Operators.And(bo_, bq_);
			var bt_ = QICoreCommon_2_0_000.ToInterval(ag_);
			var bu_ = context.Operators.Start(bt_);
			var bv_ = context.Operators.DateFrom(bu_);
			var bw_ = FHIRHelpers_4_3_000.ToValue(tuple_bbipkfiyffdqclchpcxkdafmv.KCCQPhysicalLimits?.Effective);
			var bx_ = QICoreCommon_2_0_000.ToInterval(bw_);
			var by_ = context.Operators.Start(bx_);
			var bz_ = context.Operators.DateFrom(by_);
			var ca_ = context.Operators.SameAs(bv_, bz_, "day");
			var cb_ = context.Operators.And(br_, ca_);
			var cc_ = FHIRHelpers_4_3_000.ToValue(tuple_bbipkfiyffdqclchpcxkdafmv.KCCQPhysicalLimits?.Value);
			var cd_ = context.Operators.Not((bool?)(cc_ is null));
			var ce_ = context.Operators.And(cb_, cd_);
			var cg_ = QICoreCommon_2_0_000.ToInterval(ag_);
			var ch_ = context.Operators.Start(cg_);
			var ci_ = context.Operators.DateFrom(ch_);
			var cj_ = FHIRHelpers_4_3_000.ToValue(tuple_bbipkfiyffdqclchpcxkdafmv.KCCQSocialLimits?.Effective);
			var ck_ = QICoreCommon_2_0_000.ToInterval(cj_);
			var cl_ = context.Operators.Start(ck_);
			var cm_ = context.Operators.DateFrom(cl_);
			var cn_ = context.Operators.SameAs(ci_, cm_, "day");
			var co_ = context.Operators.And(ce_, cn_);
			var cp_ = FHIRHelpers_4_3_000.ToValue(tuple_bbipkfiyffdqclchpcxkdafmv.KCCQSocialLimits?.Value);
			var cq_ = context.Operators.Not((bool?)(cp_ is null));
			var cr_ = context.Operators.And(co_, cq_);
			var cs_ = FHIRHelpers_4_3_000.ToValue(tuple_bbipkfiyffdqclchpcxkdafmv.KCCQLifeQuality?.Value);
			var ct_ = context.Operators.Not((bool?)(cs_ is null));
			var cu_ = context.Operators.And(cr_, ct_);

			return cu_;
		};
		var ac_ = context.Operators.Where<Tuple_BbiPKFIYFfdQCLCHPcXKDaFMV>(aa_, ab_);
		CqlDate ad_(Tuple_BbiPKFIYFfdQCLCHPcXKDaFMV tuple_bbipkfiyffdqclchpcxkdafmv)
		{
			var cv_ = FHIRHelpers_4_3_000.ToValue(tuple_bbipkfiyffdqclchpcxkdafmv.KCCQLifeQuality?.Effective);
			var cw_ = QICoreCommon_2_0_000.ToInterval(cv_);
			var cx_ = context.Operators.Start(cw_);
			var cy_ = context.Operators.DateFrom(cx_);
			var cz_ = FHIRHelpers_4_3_000.ToValue(tuple_bbipkfiyffdqclchpcxkdafmv.KCCQSymptomStability?.Effective);
			var da_ = QICoreCommon_2_0_000.ToInterval(cz_);
			var db_ = context.Operators.Start(da_);
			var dc_ = context.Operators.DateFrom(db_);
			var dd_ = FHIRHelpers_4_3_000.ToValue(tuple_bbipkfiyffdqclchpcxkdafmv.KCCQSelfEfficacy?.Effective);
			var de_ = QICoreCommon_2_0_000.ToInterval(dd_);
			var df_ = context.Operators.Start(de_);
			var dg_ = context.Operators.DateFrom(df_);
			var dh_ = FHIRHelpers_4_3_000.ToValue(tuple_bbipkfiyffdqclchpcxkdafmv.KCCQSymptoms?.Effective);
			var di_ = QICoreCommon_2_0_000.ToInterval(dh_);
			var dj_ = context.Operators.Start(di_);
			var dk_ = context.Operators.DateFrom(dj_);
			var dl_ = FHIRHelpers_4_3_000.ToValue(tuple_bbipkfiyffdqclchpcxkdafmv.KCCQPhysicalLimits?.Effective);
			var dm_ = QICoreCommon_2_0_000.ToInterval(dl_);
			var dn_ = context.Operators.Start(dm_);
			var do_ = context.Operators.DateFrom(dn_);
			var dp_ = FHIRHelpers_4_3_000.ToValue(tuple_bbipkfiyffdqclchpcxkdafmv.KCCQSocialLimits?.Effective);
			var dq_ = QICoreCommon_2_0_000.ToInterval(dp_);
			var dr_ = context.Operators.Start(dq_);
			var ds_ = context.Operators.DateFrom(dr_);
			var dt_ = new CqlDate[]
			{
				cy_,
				dc_,
				dg_,
				dk_,
				do_,
				ds_,
			};
			var du_ = context.Operators.Max<CqlDate>((dt_ as IEnumerable<CqlDate>));

			return du_;
		};
		var ae_ = context.Operators.Select<Tuple_BbiPKFIYFfdQCLCHPcXKDaFMV, CqlDate>(ac_, ad_);

		return ae_;
	}

    [CqlDeclaration("Date KCCQ Domain Assessment Completed")]
	public IEnumerable<CqlDate> Date_KCCQ_Domain_Assessment_Completed() => 
		__Date_KCCQ_Domain_Assessment_Completed.Value;

	private bool? Has_Encounter_with_Initial_and_Follow_Up_KCCQ_Domain_Score_Assessments_Value()
	{
		var a_ = this.Qualifying_Encounters();
		var b_ = this.Date_KCCQ_Domain_Assessment_Completed();
		var d_ = context.Operators.CrossJoin<Encounter, CqlDate, CqlDate>(a_, b_, b_);
		Tuple_GechMKfhePFUbfJYJeVegQTRC e_(ValueTuple<Encounter,CqlDate,CqlDate> _valueTuple)
		{
			var l_ = new Tuple_GechMKfhePFUbfJYJeVegQTRC
			{
				ValidEncounters = _valueTuple.Item1,
				InitialKCCQAssessmentDate = _valueTuple.Item2,
				FollowupKCCQAssessmentDate = _valueTuple.Item3,
			};

			return l_;
		};
		var f_ = context.Operators.Select<ValueTuple<Encounter,CqlDate,CqlDate>, Tuple_GechMKfhePFUbfJYJeVegQTRC>(d_, e_);
		bool? g_(Tuple_GechMKfhePFUbfJYJeVegQTRC tuple_gechmkfhepfubfjyjevegqtrc)
		{
			var m_ = FHIRHelpers_4_3_000.ToInterval(tuple_gechmkfhepfubfjyjevegqtrc.ValidEncounters?.Period);
			var n_ = QICoreCommon_2_0_000.ToInterval((m_ as object));
			var o_ = context.Operators.End(n_);
			var p_ = this.Measurement_Period();
			var q_ = context.Operators.End(p_);
			var r_ = context.Operators.Quantity(180m, "days");
			var s_ = context.Operators.Subtract(q_, r_);
			var t_ = context.Operators.SameOrBefore(o_, s_, "day");
			var u_ = context.Operators.ConvertDateToDateTime(tuple_gechmkfhepfubfjyjevegqtrc.InitialKCCQAssessmentDate);
			var w_ = QICoreCommon_2_0_000.ToInterval((m_ as object));
			var x_ = context.Operators.End(w_);
			var y_ = context.Operators.Quantity(14m, "days");
			var z_ = context.Operators.Subtract(x_, y_);
			var ab_ = QICoreCommon_2_0_000.ToInterval((m_ as object));
			var ac_ = context.Operators.End(ab_);
			var ad_ = context.Operators.Interval(z_, ac_, true, true);
			var ae_ = context.Operators.In<CqlDateTime>(u_, ad_, "day");
			var ag_ = QICoreCommon_2_0_000.ToInterval((m_ as object));
			var ah_ = context.Operators.End(ag_);
			var ai_ = context.Operators.Not((bool?)(ah_ is null));
			var aj_ = context.Operators.And(ae_, ai_);
			var ak_ = context.Operators.And(t_, aj_);
			var al_ = context.Operators.ConvertDateToDateTime(tuple_gechmkfhepfubfjyjevegqtrc.FollowupKCCQAssessmentDate);
			var am_ = context.Operators.DateFrom(al_);
			var ao_ = context.Operators.DateFrom(u_);
			var ap_ = context.Operators.Quantity(30m, "days");
			var aq_ = context.Operators.Add(ao_, ap_);
			var as_ = context.Operators.DateFrom(u_);
			var au_ = context.Operators.Add(as_, r_);
			var av_ = context.Operators.Interval(aq_, au_, true, true);
			var aw_ = context.Operators.In<CqlDate>(am_, av_, "day");
			var ax_ = context.Operators.And(ak_, aw_);

			return ax_;
		};
		var h_ = context.Operators.Where<Tuple_GechMKfhePFUbfJYJeVegQTRC>(f_, g_);
		Encounter i_(Tuple_GechMKfhePFUbfJYJeVegQTRC tuple_gechmkfhepfubfjyjevegqtrc) => 
			tuple_gechmkfhepfubfjyjevegqtrc.ValidEncounters;
		var j_ = context.Operators.Select<Tuple_GechMKfhePFUbfJYJeVegQTRC, Encounter>(h_, i_);
		var k_ = context.Operators.Exists<Encounter>(j_);

		return k_;
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
		var f_ = context.Operators.Where<Observation>(d_, e_);
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
			var p_ = context.Operators.Max<CqlDate>((o_ as IEnumerable<CqlDate>));

			return p_;
		};
		var h_ = context.Operators.Select<Observation, CqlDate>(f_, g_);

		return h_;
	}

    [CqlDeclaration("Date KCCQ Total Assessment Completed")]
	public IEnumerable<CqlDate> Date_KCCQ_Total_Assessment_Completed() => 
		__Date_KCCQ_Total_Assessment_Completed.Value;

	private bool? Has_Encounter_with_Initial_and_Follow_Up_KCCQ_Total_Score_Assessments_Value()
	{
		var a_ = this.Qualifying_Encounters();
		var b_ = this.Date_KCCQ_Total_Assessment_Completed();
		var d_ = context.Operators.CrossJoin<Encounter, CqlDate, CqlDate>(a_, b_, b_);
		Tuple_DSdKcfQMUMBjegQCVVeYhPYdf e_(ValueTuple<Encounter,CqlDate,CqlDate> _valueTuple)
		{
			var l_ = new Tuple_DSdKcfQMUMBjegQCVVeYhPYdf
			{
				ValidEncounters = _valueTuple.Item1,
				InitialKCCQTotalScore = _valueTuple.Item2,
				FollowupKCCQTotalScore = _valueTuple.Item3,
			};

			return l_;
		};
		var f_ = context.Operators.Select<ValueTuple<Encounter,CqlDate,CqlDate>, Tuple_DSdKcfQMUMBjegQCVVeYhPYdf>(d_, e_);
		bool? g_(Tuple_DSdKcfQMUMBjegQCVVeYhPYdf tuple_dsdkcfqmumbjegqcvveyhpydf)
		{
			var m_ = FHIRHelpers_4_3_000.ToInterval(tuple_dsdkcfqmumbjegqcvveyhpydf.ValidEncounters?.Period);
			var n_ = QICoreCommon_2_0_000.ToInterval((m_ as object));
			var o_ = context.Operators.End(n_);
			var p_ = this.Measurement_Period();
			var q_ = context.Operators.End(p_);
			var r_ = context.Operators.Quantity(180m, "days");
			var s_ = context.Operators.Subtract(q_, r_);
			var t_ = context.Operators.SameOrBefore(o_, s_, "day");
			var u_ = context.Operators.ConvertDateToDateTime(tuple_dsdkcfqmumbjegqcvveyhpydf.InitialKCCQTotalScore);
			var w_ = QICoreCommon_2_0_000.ToInterval((m_ as object));
			var x_ = context.Operators.End(w_);
			var y_ = context.Operators.Quantity(14m, "days");
			var z_ = context.Operators.Subtract(x_, y_);
			var ab_ = QICoreCommon_2_0_000.ToInterval((m_ as object));
			var ac_ = context.Operators.End(ab_);
			var ad_ = context.Operators.Interval(z_, ac_, true, true);
			var ae_ = context.Operators.In<CqlDateTime>(u_, ad_, "day");
			var ag_ = QICoreCommon_2_0_000.ToInterval((m_ as object));
			var ah_ = context.Operators.End(ag_);
			var ai_ = context.Operators.Not((bool?)(ah_ is null));
			var aj_ = context.Operators.And(ae_, ai_);
			var ak_ = context.Operators.And(t_, aj_);
			var al_ = context.Operators.ConvertDateToDateTime(tuple_dsdkcfqmumbjegqcvveyhpydf.FollowupKCCQTotalScore);
			var am_ = context.Operators.DateFrom(al_);
			var ao_ = context.Operators.DateFrom(u_);
			var ap_ = context.Operators.Quantity(30m, "days");
			var aq_ = context.Operators.Add(ao_, ap_);
			var as_ = context.Operators.DateFrom(u_);
			var au_ = context.Operators.Add(as_, r_);
			var av_ = context.Operators.Interval(aq_, au_, true, true);
			var aw_ = context.Operators.In<CqlDate>(am_, av_, "day");
			var ax_ = context.Operators.And(ak_, aw_);

			return ax_;
		};
		var h_ = context.Operators.Where<Tuple_DSdKcfQMUMBjegQCVVeYhPYdf>(f_, g_);
		Encounter i_(Tuple_DSdKcfQMUMBjegQCVVeYhPYdf tuple_dsdkcfqmumbjegqcvveyhpydf) => 
			tuple_dsdkcfqmumbjegqcvveyhpydf.ValidEncounters;
		var j_ = context.Operators.Select<Tuple_DSdKcfQMUMBjegQCVVeYhPYdf, Encounter>(h_, i_);
		var k_ = context.Operators.Exists<Encounter>(j_);

		return k_;
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
