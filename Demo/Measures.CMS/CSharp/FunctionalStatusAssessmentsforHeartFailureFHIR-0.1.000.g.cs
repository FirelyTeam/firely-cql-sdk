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
    internal Lazy<Tuple_HPcCiDPXQfZTXIORThMLfTQDR> __SDE_Ethnicity;
    internal Lazy<IEnumerable<Tuple_GPRWMPNAYaJRiGDFSTLJOPeIJ>> __SDE_Payer;
    internal Lazy<Tuple_HPcCiDPXQfZTXIORThMLfTQDR> __SDE_Race;
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
        __SDE_Ethnicity = new Lazy<Tuple_HPcCiDPXQfZTXIORThMLfTQDR>(this.SDE_Ethnicity_Value);
        __SDE_Payer = new Lazy<IEnumerable<Tuple_GPRWMPNAYaJRiGDFSTLJOPeIJ>>(this.SDE_Payer_Value);
        __SDE_Race = new Lazy<Tuple_HPcCiDPXQfZTXIORThMLfTQDR>(this.SDE_Race_Value);
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

	private IEnumerable<Encounter> Qualifying_Encounters_Value()
	{
		var a_ = this.Office_Visit();
		var b_ = context.Operators.RetrieveByValueSet<Encounter>(a_, null);
		var c_ = this.Telephone_Visits();
		var d_ = context.Operators.RetrieveByValueSet<Encounter>(c_, null);
		var e_ = context.Operators.Union<Encounter>(b_, d_);
		var f_ = this.Online_Assessments();
		var g_ = context.Operators.RetrieveByValueSet<Encounter>(f_, null);
		var h_ = context.Operators.Union<Encounter>(e_, g_);
		var i_ = Status_1_6_000.Finished_Encounter(h_);
		bool? j_(Encounter ValidEncounter)
		{
			var l_ = this.Measurement_Period();
			var m_ = ValidEncounter?.Period;
			var n_ = FHIRHelpers_4_3_000.ToInterval(m_);
			var o_ = QICoreCommon_2_0_000.ToInterval((n_ as object));
			var p_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(l_, o_, "day");

			return p_;
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
		Tuple_DbNMMZBTISSRTNdiShceSFVih d_(ValueTuple<Encounter, Encounter> _valueTuple)
		{
			var j_ = new Tuple_DbNMMZBTISSRTNdiShceSFVih
			{
				OfficeVisit1 = _valueTuple.Item1,
				OfficeVisit2 = _valueTuple.Item2,
			};

			return j_;
		};
		var e_ = context.Operators.Select<ValueTuple<Encounter, Encounter>, Tuple_DbNMMZBTISSRTNdiShceSFVih>(c_, d_);
		bool? f_(Tuple_DbNMMZBTISSRTNdiShceSFVih tuple_dbnmmzbtissrtndishcesfvih)
		{
			var k_ = tuple_dbnmmzbtissrtndishcesfvih.OfficeVisit2?.Period;
			var l_ = FHIRHelpers_4_3_000.ToInterval(k_);
			var m_ = QICoreCommon_2_0_000.ToInterval((l_ as object));
			var n_ = context.Operators.Start(m_);
			var o_ = tuple_dbnmmzbtissrtndishcesfvih.OfficeVisit1?.Period;
			var p_ = FHIRHelpers_4_3_000.ToInterval(o_);
			var q_ = QICoreCommon_2_0_000.ToInterval((p_ as object));
			var r_ = context.Operators.End(q_);
			var s_ = context.Operators.Quantity(1m, "day");
			var t_ = context.Operators.Add(r_, s_);
			var u_ = context.Operators.SameOrAfter(n_, t_, "day");

			return u_;
		};
		var g_ = context.Operators.Where<Tuple_DbNMMZBTISSRTNdiShceSFVih>(e_, f_);
		Encounter h_(Tuple_DbNMMZBTISSRTNdiShceSFVih tuple_dbnmmzbtissrtndishcesfvih) => 
			tuple_dbnmmzbtissrtndishcesfvih.OfficeVisit1;
		var i_ = context.Operators.Select<Tuple_DbNMMZBTISSRTNdiShceSFVih, Encounter>(g_, h_);

		return i_;
	}

    [CqlDeclaration("Two Outpatient Encounters during Measurement Period")]
	public IEnumerable<Encounter> Two_Outpatient_Encounters_during_Measurement_Period() => 
		__Two_Outpatient_Encounters_during_Measurement_Period.Value;

	private bool? Initial_Population_Value()
	{
		var a_ = this.Patient();
		var b_ = context.Operators.ConvertStringToDate(a_?.BirthDateElement?.Value);
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
		Tuple_DDTAOdcFieSJbGgRLLZPYbGQb j_(ValueTuple<Observation, Observation> _valueTuple)
		{
			var p_ = new Tuple_DDTAOdcFieSJbGgRLLZPYbGQb
			{
				PROMIS10MentalScore = _valueTuple.Item1,
				PROMIS10PhysicalScore = _valueTuple.Item2,
			};

			return p_;
		};
		var k_ = context.Operators.Select<ValueTuple<Observation, Observation>, Tuple_DDTAOdcFieSJbGgRLLZPYbGQb>(i_, j_);
		bool? l_(Tuple_DDTAOdcFieSJbGgRLLZPYbGQb tuple_ddtaodcfiesjbggrllzpybgqb)
		{
			var q_ = tuple_ddtaodcfiesjbggrllzpybgqb.PROMIS10MentalScore?.Effective;
			var r_ = FHIRHelpers_4_3_000.ToValue(q_);
			var s_ = QICoreCommon_2_0_000.ToInterval(r_);
			var t_ = context.Operators.Start(s_);
			var u_ = context.Operators.DateFrom(t_);
			var v_ = tuple_ddtaodcfiesjbggrllzpybgqb.PROMIS10PhysicalScore?.Effective;
			var w_ = FHIRHelpers_4_3_000.ToValue(v_);
			var x_ = QICoreCommon_2_0_000.ToInterval(w_);
			var y_ = context.Operators.Start(x_);
			var z_ = context.Operators.DateFrom(y_);
			var aa_ = context.Operators.SameAs(u_, z_, "day");
			var ab_ = tuple_ddtaodcfiesjbggrllzpybgqb.PROMIS10MentalScore?.Value;
			var ac_ = FHIRHelpers_4_3_000.ToValue(ab_);
			var ad_ = context.Operators.Not((bool?)(ac_ is null));
			var ae_ = context.Operators.And(aa_, ad_);
			var af_ = tuple_ddtaodcfiesjbggrllzpybgqb.PROMIS10PhysicalScore?.Value;
			var ag_ = FHIRHelpers_4_3_000.ToValue(af_);
			var ah_ = context.Operators.Not((bool?)(ag_ is null));
			var ai_ = context.Operators.And(ae_, ah_);

			return ai_;
		};
		var m_ = context.Operators.Where<Tuple_DDTAOdcFieSJbGgRLLZPYbGQb>(k_, l_);
		CqlDate n_(Tuple_DDTAOdcFieSJbGgRLLZPYbGQb tuple_ddtaodcfiesjbggrllzpybgqb)
		{
			var aj_ = tuple_ddtaodcfiesjbggrllzpybgqb.PROMIS10MentalScore?.Effective;
			var ak_ = FHIRHelpers_4_3_000.ToValue(aj_);
			var al_ = QICoreCommon_2_0_000.ToInterval(ak_);
			var am_ = context.Operators.Start(al_);
			var an_ = context.Operators.DateFrom(am_);
			var ao_ = tuple_ddtaodcfiesjbggrllzpybgqb.PROMIS10PhysicalScore?.Effective;
			var ap_ = FHIRHelpers_4_3_000.ToValue(ao_);
			var aq_ = QICoreCommon_2_0_000.ToInterval(ap_);
			var ar_ = context.Operators.Start(aq_);
			var as_ = context.Operators.DateFrom(ar_);
			var at_ = new CqlDate[]
			{
				an_,
				as_,
			};
			var au_ = context.Operators.Max<CqlDate>((at_ as IEnumerable<CqlDate>));

			return au_;
		};
		var o_ = context.Operators.Select<Tuple_DDTAOdcFieSJbGgRLLZPYbGQb, CqlDate>(m_, n_);

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
		Tuple_DZhWGXhMBfAVMZfaSZbEKSOHj e_(ValueTuple<Encounter, CqlDate, CqlDate> _valueTuple)
		{
			var l_ = new Tuple_DZhWGXhMBfAVMZfaSZbEKSOHj
			{
				ValidEncounters = _valueTuple.Item1,
				InitialPROMIS10Date = _valueTuple.Item2,
				FollowupPROMIS10Date = _valueTuple.Item3,
			};

			return l_;
		};
		var f_ = context.Operators.Select<ValueTuple<Encounter, CqlDate, CqlDate>, Tuple_DZhWGXhMBfAVMZfaSZbEKSOHj>(d_, e_);
		bool? g_(Tuple_DZhWGXhMBfAVMZfaSZbEKSOHj tuple_dzhwgxhmbfavmzfaszbeksohj)
		{
			var m_ = tuple_dzhwgxhmbfavmzfaszbeksohj.ValidEncounters?.Period;
			var n_ = FHIRHelpers_4_3_000.ToInterval(m_);
			var o_ = QICoreCommon_2_0_000.ToInterval((n_ as object));
			var p_ = context.Operators.End(o_);
			var q_ = this.Measurement_Period();
			var r_ = context.Operators.End(q_);
			var s_ = context.Operators.Quantity(180m, "days");
			var t_ = context.Operators.Subtract(r_, s_);
			var u_ = context.Operators.SameOrBefore(p_, t_, "day");
			var v_ = context.Operators.ConvertDateToDateTime(tuple_dzhwgxhmbfavmzfaszbeksohj.InitialPROMIS10Date);
			var x_ = FHIRHelpers_4_3_000.ToInterval(m_);
			var y_ = QICoreCommon_2_0_000.ToInterval((x_ as object));
			var z_ = context.Operators.End(y_);
			var aa_ = context.Operators.Quantity(14m, "days");
			var ab_ = context.Operators.Subtract(z_, aa_);
			var ad_ = FHIRHelpers_4_3_000.ToInterval(m_);
			var ae_ = QICoreCommon_2_0_000.ToInterval((ad_ as object));
			var af_ = context.Operators.End(ae_);
			var ag_ = context.Operators.Interval(ab_, af_, true, true);
			var ah_ = context.Operators.In<CqlDateTime>(v_, ag_, "day");
			var aj_ = FHIRHelpers_4_3_000.ToInterval(m_);
			var ak_ = QICoreCommon_2_0_000.ToInterval((aj_ as object));
			var al_ = context.Operators.End(ak_);
			var am_ = context.Operators.Not((bool?)(al_ is null));
			var an_ = context.Operators.And(ah_, am_);
			var ao_ = context.Operators.And(u_, an_);
			var ap_ = context.Operators.ConvertDateToDateTime(tuple_dzhwgxhmbfavmzfaszbeksohj.FollowupPROMIS10Date);
			var aq_ = context.Operators.DateFrom(ap_);
			var as_ = context.Operators.DateFrom(v_);
			var at_ = context.Operators.Quantity(30m, "days");
			var au_ = context.Operators.Add(as_, at_);
			var aw_ = context.Operators.DateFrom(v_);
			var ay_ = context.Operators.Add(aw_, s_);
			var az_ = context.Operators.Interval(au_, ay_, true, true);
			var ba_ = context.Operators.In<CqlDate>(aq_, az_, "day");
			var bb_ = context.Operators.And(ao_, ba_);

			return bb_;
		};
		var h_ = context.Operators.Where<Tuple_DZhWGXhMBfAVMZfaSZbEKSOHj>(f_, g_);
		Encounter i_(Tuple_DZhWGXhMBfAVMZfaSZbEKSOHj tuple_dzhwgxhmbfavmzfaszbeksohj) => 
			tuple_dzhwgxhmbfavmzfaszbeksohj.ValidEncounters;
		var j_ = context.Operators.Select<Tuple_DZhWGXhMBfAVMZfaSZbEKSOHj, Encounter>(h_, i_);
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
		Tuple_CbgPSARVWRSeWLgLehiNjaNiM ad_(ValueTuple<Observation, Observation, Observation, Observation, Observation, Observation, Observation> _valueTuple)
		{
			var aj_ = new Tuple_CbgPSARVWRSeWLgLehiNjaNiM
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
		var ae_ = context.Operators.Select<ValueTuple<Observation, Observation, Observation, Observation, Observation, Observation, Observation>, Tuple_CbgPSARVWRSeWLgLehiNjaNiM>(ac_, ad_);
		bool? af_(Tuple_CbgPSARVWRSeWLgLehiNjaNiM tuple_cbgpsarvwrsewlglehinjanim)
		{
			var ak_ = tuple_cbgpsarvwrsewlglehinjanim.Promis29Sleep?.Effective;
			var al_ = FHIRHelpers_4_3_000.ToValue(ak_);
			var am_ = QICoreCommon_2_0_000.ToInterval(al_);
			var an_ = context.Operators.Start(am_);
			var ao_ = context.Operators.DateFrom(an_);
			var ap_ = tuple_cbgpsarvwrsewlglehinjanim.Promis29SocialRoles?.Effective;
			var aq_ = FHIRHelpers_4_3_000.ToValue(ap_);
			var ar_ = QICoreCommon_2_0_000.ToInterval(aq_);
			var as_ = context.Operators.Start(ar_);
			var at_ = context.Operators.DateFrom(as_);
			var au_ = context.Operators.SameAs(ao_, at_, "day");
			var av_ = tuple_cbgpsarvwrsewlglehinjanim.Promis29SocialRoles?.Value;
			var aw_ = FHIRHelpers_4_3_000.ToValue(av_);
			var ax_ = context.Operators.Not((bool?)(aw_ is null));
			var ay_ = context.Operators.And(au_, ax_);
			var ba_ = FHIRHelpers_4_3_000.ToValue(ak_);
			var bb_ = QICoreCommon_2_0_000.ToInterval(ba_);
			var bc_ = context.Operators.Start(bb_);
			var bd_ = context.Operators.DateFrom(bc_);
			var be_ = tuple_cbgpsarvwrsewlglehinjanim.Promis29Physical?.Effective;
			var bf_ = FHIRHelpers_4_3_000.ToValue(be_);
			var bg_ = QICoreCommon_2_0_000.ToInterval(bf_);
			var bh_ = context.Operators.Start(bg_);
			var bi_ = context.Operators.DateFrom(bh_);
			var bj_ = context.Operators.SameAs(bd_, bi_, "day");
			var bk_ = context.Operators.And(ay_, bj_);
			var bl_ = tuple_cbgpsarvwrsewlglehinjanim.Promis29Physical?.Value;
			var bm_ = FHIRHelpers_4_3_000.ToValue(bl_);
			var bn_ = context.Operators.Not((bool?)(bm_ is null));
			var bo_ = context.Operators.And(bk_, bn_);
			var bq_ = FHIRHelpers_4_3_000.ToValue(ak_);
			var br_ = QICoreCommon_2_0_000.ToInterval(bq_);
			var bs_ = context.Operators.Start(br_);
			var bt_ = context.Operators.DateFrom(bs_);
			var bu_ = tuple_cbgpsarvwrsewlglehinjanim.Promis29Pain?.Effective;
			var bv_ = FHIRHelpers_4_3_000.ToValue(bu_);
			var bw_ = QICoreCommon_2_0_000.ToInterval(bv_);
			var bx_ = context.Operators.Start(bw_);
			var by_ = context.Operators.DateFrom(bx_);
			var bz_ = context.Operators.SameAs(bt_, by_, "day");
			var ca_ = context.Operators.And(bo_, bz_);
			var cb_ = tuple_cbgpsarvwrsewlglehinjanim.Promis29Pain?.Value;
			var cc_ = FHIRHelpers_4_3_000.ToValue(cb_);
			var cd_ = context.Operators.Not((bool?)(cc_ is null));
			var ce_ = context.Operators.And(ca_, cd_);
			var cg_ = FHIRHelpers_4_3_000.ToValue(ak_);
			var ch_ = QICoreCommon_2_0_000.ToInterval(cg_);
			var ci_ = context.Operators.Start(ch_);
			var cj_ = context.Operators.DateFrom(ci_);
			var ck_ = tuple_cbgpsarvwrsewlglehinjanim.Promis29Fatigue?.Effective;
			var cl_ = FHIRHelpers_4_3_000.ToValue(ck_);
			var cm_ = QICoreCommon_2_0_000.ToInterval(cl_);
			var cn_ = context.Operators.Start(cm_);
			var co_ = context.Operators.DateFrom(cn_);
			var cp_ = context.Operators.SameAs(cj_, co_, "day");
			var cq_ = context.Operators.And(ce_, cp_);
			var cr_ = tuple_cbgpsarvwrsewlglehinjanim.Promis29Fatigue?.Value;
			var cs_ = FHIRHelpers_4_3_000.ToValue(cr_);
			var ct_ = context.Operators.Not((bool?)(cs_ is null));
			var cu_ = context.Operators.And(cq_, ct_);
			var cw_ = FHIRHelpers_4_3_000.ToValue(ak_);
			var cx_ = QICoreCommon_2_0_000.ToInterval(cw_);
			var cy_ = context.Operators.Start(cx_);
			var cz_ = context.Operators.DateFrom(cy_);
			var da_ = tuple_cbgpsarvwrsewlglehinjanim.Promis29Depression?.Effective;
			var db_ = FHIRHelpers_4_3_000.ToValue(da_);
			var dc_ = QICoreCommon_2_0_000.ToInterval(db_);
			var dd_ = context.Operators.Start(dc_);
			var de_ = context.Operators.DateFrom(dd_);
			var df_ = context.Operators.SameAs(cz_, de_, "day");
			var dg_ = context.Operators.And(cu_, df_);
			var dh_ = tuple_cbgpsarvwrsewlglehinjanim.Promis29Depression?.Value;
			var di_ = FHIRHelpers_4_3_000.ToValue(dh_);
			var dj_ = context.Operators.Not((bool?)(di_ is null));
			var dk_ = context.Operators.And(dg_, dj_);
			var dm_ = FHIRHelpers_4_3_000.ToValue(ak_);
			var dn_ = QICoreCommon_2_0_000.ToInterval(dm_);
			var do_ = context.Operators.Start(dn_);
			var dp_ = context.Operators.DateFrom(do_);
			var dq_ = tuple_cbgpsarvwrsewlglehinjanim.Promis29Anxiety?.Effective;
			var dr_ = FHIRHelpers_4_3_000.ToValue(dq_);
			var ds_ = QICoreCommon_2_0_000.ToInterval(dr_);
			var dt_ = context.Operators.Start(ds_);
			var du_ = context.Operators.DateFrom(dt_);
			var dv_ = context.Operators.SameAs(dp_, du_, "day");
			var dw_ = context.Operators.And(dk_, dv_);
			var dx_ = tuple_cbgpsarvwrsewlglehinjanim.Promis29Anxiety?.Value;
			var dy_ = FHIRHelpers_4_3_000.ToValue(dx_);
			var dz_ = context.Operators.Not((bool?)(dy_ is null));
			var ea_ = context.Operators.And(dw_, dz_);
			var eb_ = tuple_cbgpsarvwrsewlglehinjanim.Promis29Sleep?.Value;
			var ec_ = FHIRHelpers_4_3_000.ToValue(eb_);
			var ed_ = context.Operators.Not((bool?)(ec_ is null));
			var ee_ = context.Operators.And(ea_, ed_);

			return ee_;
		};
		var ag_ = context.Operators.Where<Tuple_CbgPSARVWRSeWLgLehiNjaNiM>(ae_, af_);
		CqlDate ah_(Tuple_CbgPSARVWRSeWLgLehiNjaNiM tuple_cbgpsarvwrsewlglehinjanim)
		{
			var ef_ = tuple_cbgpsarvwrsewlglehinjanim.Promis29Sleep?.Effective;
			var eg_ = FHIRHelpers_4_3_000.ToValue(ef_);
			var eh_ = QICoreCommon_2_0_000.ToInterval(eg_);
			var ei_ = context.Operators.Start(eh_);
			var ej_ = context.Operators.DateFrom(ei_);
			var ek_ = tuple_cbgpsarvwrsewlglehinjanim.Promis29SocialRoles?.Effective;
			var el_ = FHIRHelpers_4_3_000.ToValue(ek_);
			var em_ = QICoreCommon_2_0_000.ToInterval(el_);
			var en_ = context.Operators.Start(em_);
			var eo_ = context.Operators.DateFrom(en_);
			var ep_ = tuple_cbgpsarvwrsewlglehinjanim.Promis29Physical?.Effective;
			var eq_ = FHIRHelpers_4_3_000.ToValue(ep_);
			var er_ = QICoreCommon_2_0_000.ToInterval(eq_);
			var es_ = context.Operators.Start(er_);
			var et_ = context.Operators.DateFrom(es_);
			var eu_ = tuple_cbgpsarvwrsewlglehinjanim.Promis29Pain?.Effective;
			var ev_ = FHIRHelpers_4_3_000.ToValue(eu_);
			var ew_ = QICoreCommon_2_0_000.ToInterval(ev_);
			var ex_ = context.Operators.Start(ew_);
			var ey_ = context.Operators.DateFrom(ex_);
			var ez_ = tuple_cbgpsarvwrsewlglehinjanim.Promis29Fatigue?.Effective;
			var fa_ = FHIRHelpers_4_3_000.ToValue(ez_);
			var fb_ = QICoreCommon_2_0_000.ToInterval(fa_);
			var fc_ = context.Operators.Start(fb_);
			var fd_ = context.Operators.DateFrom(fc_);
			var fe_ = tuple_cbgpsarvwrsewlglehinjanim.Promis29Depression?.Effective;
			var ff_ = FHIRHelpers_4_3_000.ToValue(fe_);
			var fg_ = QICoreCommon_2_0_000.ToInterval(ff_);
			var fh_ = context.Operators.Start(fg_);
			var fi_ = context.Operators.DateFrom(fh_);
			var fj_ = tuple_cbgpsarvwrsewlglehinjanim.Promis29Anxiety?.Effective;
			var fk_ = FHIRHelpers_4_3_000.ToValue(fj_);
			var fl_ = QICoreCommon_2_0_000.ToInterval(fk_);
			var fm_ = context.Operators.Start(fl_);
			var fn_ = context.Operators.DateFrom(fm_);
			var fo_ = new CqlDate[]
			{
				ej_,
				eo_,
				et_,
				ey_,
				fd_,
				fi_,
				fn_,
			};
			var fp_ = context.Operators.Max<CqlDate>((fo_ as IEnumerable<CqlDate>));

			return fp_;
		};
		var ai_ = context.Operators.Select<Tuple_CbgPSARVWRSeWLgLehiNjaNiM, CqlDate>(ag_, ah_);

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
		Tuple_KMPNTXjUhKPBcWGfTQIGieaO e_(ValueTuple<Encounter, CqlDate, CqlDate> _valueTuple)
		{
			var l_ = new Tuple_KMPNTXjUhKPBcWGfTQIGieaO
			{
				ValidEncounters = _valueTuple.Item1,
				InitialPROMIS29Date = _valueTuple.Item2,
				FollowupPROMIS29Date = _valueTuple.Item3,
			};

			return l_;
		};
		var f_ = context.Operators.Select<ValueTuple<Encounter, CqlDate, CqlDate>, Tuple_KMPNTXjUhKPBcWGfTQIGieaO>(d_, e_);
		bool? g_(Tuple_KMPNTXjUhKPBcWGfTQIGieaO tuple_kmpntxjuhkpbcwgftqigieao)
		{
			var m_ = tuple_kmpntxjuhkpbcwgftqigieao.ValidEncounters?.Period;
			var n_ = FHIRHelpers_4_3_000.ToInterval(m_);
			var o_ = QICoreCommon_2_0_000.ToInterval((n_ as object));
			var p_ = context.Operators.End(o_);
			var q_ = this.Measurement_Period();
			var r_ = context.Operators.End(q_);
			var s_ = context.Operators.Quantity(180m, "days");
			var t_ = context.Operators.Subtract(r_, s_);
			var u_ = context.Operators.SameOrBefore(p_, t_, "day");
			var v_ = context.Operators.ConvertDateToDateTime(tuple_kmpntxjuhkpbcwgftqigieao.InitialPROMIS29Date);
			var x_ = FHIRHelpers_4_3_000.ToInterval(m_);
			var y_ = QICoreCommon_2_0_000.ToInterval((x_ as object));
			var z_ = context.Operators.End(y_);
			var aa_ = context.Operators.Quantity(14m, "days");
			var ab_ = context.Operators.Subtract(z_, aa_);
			var ad_ = FHIRHelpers_4_3_000.ToInterval(m_);
			var ae_ = QICoreCommon_2_0_000.ToInterval((ad_ as object));
			var af_ = context.Operators.End(ae_);
			var ag_ = context.Operators.Interval(ab_, af_, true, true);
			var ah_ = context.Operators.In<CqlDateTime>(v_, ag_, "day");
			var aj_ = FHIRHelpers_4_3_000.ToInterval(m_);
			var ak_ = QICoreCommon_2_0_000.ToInterval((aj_ as object));
			var al_ = context.Operators.End(ak_);
			var am_ = context.Operators.Not((bool?)(al_ is null));
			var an_ = context.Operators.And(ah_, am_);
			var ao_ = context.Operators.And(u_, an_);
			var ap_ = context.Operators.ConvertDateToDateTime(tuple_kmpntxjuhkpbcwgftqigieao.FollowupPROMIS29Date);
			var aq_ = context.Operators.DateFrom(ap_);
			var as_ = context.Operators.DateFrom(v_);
			var at_ = context.Operators.Quantity(30m, "days");
			var au_ = context.Operators.Add(as_, at_);
			var aw_ = context.Operators.DateFrom(v_);
			var ay_ = context.Operators.Add(aw_, s_);
			var az_ = context.Operators.Interval(au_, ay_, true, true);
			var ba_ = context.Operators.In<CqlDate>(aq_, az_, "day");
			var bb_ = context.Operators.And(ao_, ba_);

			return bb_;
		};
		var h_ = context.Operators.Where<Tuple_KMPNTXjUhKPBcWGfTQIGieaO>(f_, g_);
		Encounter i_(Tuple_KMPNTXjUhKPBcWGfTQIGieaO tuple_kmpntxjuhkpbcwgftqigieao) => 
			tuple_kmpntxjuhkpbcwgftqigieao.ValidEncounters;
		var j_ = context.Operators.Select<Tuple_KMPNTXjUhKPBcWGfTQIGieaO, Encounter>(h_, i_);
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
		Tuple_GAdRFKRaHUUGJcVHWQWRUjhRH j_(ValueTuple<Observation, Observation> _valueTuple)
		{
			var p_ = new Tuple_GAdRFKRaHUUGJcVHWQWRUjhRH
			{
				VR12MentalAssessment = _valueTuple.Item1,
				VR12PhysicalAssessment = _valueTuple.Item2,
			};

			return p_;
		};
		var k_ = context.Operators.Select<ValueTuple<Observation, Observation>, Tuple_GAdRFKRaHUUGJcVHWQWRUjhRH>(i_, j_);
		bool? l_(Tuple_GAdRFKRaHUUGJcVHWQWRUjhRH tuple_gadrfkrahuugjcvhwqwrujhrh)
		{
			var q_ = tuple_gadrfkrahuugjcvhwqwrujhrh.VR12MentalAssessment?.Effective;
			var r_ = FHIRHelpers_4_3_000.ToValue(q_);
			var s_ = QICoreCommon_2_0_000.ToInterval(r_);
			var t_ = context.Operators.Start(s_);
			var u_ = context.Operators.DateFrom(t_);
			var v_ = tuple_gadrfkrahuugjcvhwqwrujhrh.VR12PhysicalAssessment?.Effective;
			var w_ = FHIRHelpers_4_3_000.ToValue(v_);
			var x_ = QICoreCommon_2_0_000.ToInterval(w_);
			var y_ = context.Operators.Start(x_);
			var z_ = context.Operators.DateFrom(y_);
			var aa_ = context.Operators.SameAs(u_, z_, "day");
			var ab_ = tuple_gadrfkrahuugjcvhwqwrujhrh.VR12MentalAssessment?.Value;
			var ac_ = FHIRHelpers_4_3_000.ToValue(ab_);
			var ad_ = context.Operators.Not((bool?)(ac_ is null));
			var ae_ = context.Operators.And(aa_, ad_);
			var af_ = tuple_gadrfkrahuugjcvhwqwrujhrh.VR12PhysicalAssessment?.Value;
			var ag_ = FHIRHelpers_4_3_000.ToValue(af_);
			var ah_ = context.Operators.Not((bool?)(ag_ is null));
			var ai_ = context.Operators.And(ae_, ah_);

			return ai_;
		};
		var m_ = context.Operators.Where<Tuple_GAdRFKRaHUUGJcVHWQWRUjhRH>(k_, l_);
		CqlDate n_(Tuple_GAdRFKRaHUUGJcVHWQWRUjhRH tuple_gadrfkrahuugjcvhwqwrujhrh)
		{
			var aj_ = tuple_gadrfkrahuugjcvhwqwrujhrh.VR12MentalAssessment?.Effective;
			var ak_ = FHIRHelpers_4_3_000.ToValue(aj_);
			var al_ = QICoreCommon_2_0_000.ToInterval(ak_);
			var am_ = context.Operators.Start(al_);
			var an_ = context.Operators.DateFrom(am_);
			var ao_ = tuple_gadrfkrahuugjcvhwqwrujhrh.VR12PhysicalAssessment?.Effective;
			var ap_ = FHIRHelpers_4_3_000.ToValue(ao_);
			var aq_ = QICoreCommon_2_0_000.ToInterval(ap_);
			var ar_ = context.Operators.Start(aq_);
			var as_ = context.Operators.DateFrom(ar_);
			var at_ = new CqlDate[]
			{
				an_,
				as_,
			};
			var au_ = context.Operators.Max<CqlDate>((at_ as IEnumerable<CqlDate>));

			return au_;
		};
		var o_ = context.Operators.Select<Tuple_GAdRFKRaHUUGJcVHWQWRUjhRH, CqlDate>(m_, n_);

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
		Tuple_FPPKTdIagiEKHPTNSBAcPSWH e_(ValueTuple<Encounter, CqlDate, CqlDate> _valueTuple)
		{
			var l_ = new Tuple_FPPKTdIagiEKHPTNSBAcPSWH
			{
				ValidEncounters = _valueTuple.Item1,
				InitialVR12ObliqueDate = _valueTuple.Item2,
				FollowupVR12ObliqueDate = _valueTuple.Item3,
			};

			return l_;
		};
		var f_ = context.Operators.Select<ValueTuple<Encounter, CqlDate, CqlDate>, Tuple_FPPKTdIagiEKHPTNSBAcPSWH>(d_, e_);
		bool? g_(Tuple_FPPKTdIagiEKHPTNSBAcPSWH tuple_fppktdiagiekhptnsbacpswh)
		{
			var m_ = tuple_fppktdiagiekhptnsbacpswh.ValidEncounters?.Period;
			var n_ = FHIRHelpers_4_3_000.ToInterval(m_);
			var o_ = QICoreCommon_2_0_000.ToInterval((n_ as object));
			var p_ = context.Operators.End(o_);
			var q_ = this.Measurement_Period();
			var r_ = context.Operators.End(q_);
			var s_ = context.Operators.Quantity(180m, "days");
			var t_ = context.Operators.Subtract(r_, s_);
			var u_ = context.Operators.SameOrBefore(p_, t_, "day");
			var v_ = context.Operators.ConvertDateToDateTime(tuple_fppktdiagiekhptnsbacpswh.InitialVR12ObliqueDate);
			var x_ = FHIRHelpers_4_3_000.ToInterval(m_);
			var y_ = QICoreCommon_2_0_000.ToInterval((x_ as object));
			var z_ = context.Operators.End(y_);
			var aa_ = context.Operators.Quantity(14m, "days");
			var ab_ = context.Operators.Subtract(z_, aa_);
			var ad_ = FHIRHelpers_4_3_000.ToInterval(m_);
			var ae_ = QICoreCommon_2_0_000.ToInterval((ad_ as object));
			var af_ = context.Operators.End(ae_);
			var ag_ = context.Operators.Interval(ab_, af_, true, true);
			var ah_ = context.Operators.In<CqlDateTime>(v_, ag_, "day");
			var aj_ = FHIRHelpers_4_3_000.ToInterval(m_);
			var ak_ = QICoreCommon_2_0_000.ToInterval((aj_ as object));
			var al_ = context.Operators.End(ak_);
			var am_ = context.Operators.Not((bool?)(al_ is null));
			var an_ = context.Operators.And(ah_, am_);
			var ao_ = context.Operators.And(u_, an_);
			var ap_ = context.Operators.ConvertDateToDateTime(tuple_fppktdiagiekhptnsbacpswh.FollowupVR12ObliqueDate);
			var aq_ = context.Operators.DateFrom(ap_);
			var as_ = context.Operators.DateFrom(v_);
			var at_ = context.Operators.Quantity(30m, "days");
			var au_ = context.Operators.Add(as_, at_);
			var aw_ = context.Operators.DateFrom(v_);
			var ay_ = context.Operators.Add(aw_, s_);
			var az_ = context.Operators.Interval(au_, ay_, true, true);
			var ba_ = context.Operators.In<CqlDate>(aq_, az_, "day");
			var bb_ = context.Operators.And(ao_, ba_);

			return bb_;
		};
		var h_ = context.Operators.Where<Tuple_FPPKTdIagiEKHPTNSBAcPSWH>(f_, g_);
		Encounter i_(Tuple_FPPKTdIagiEKHPTNSBAcPSWH tuple_fppktdiagiekhptnsbacpswh) => 
			tuple_fppktdiagiekhptnsbacpswh.ValidEncounters;
		var j_ = context.Operators.Select<Tuple_FPPKTdIagiEKHPTNSBAcPSWH, Encounter>(h_, i_);
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
		Tuple_GAdRFKRaHUUGJcVHWQWRUjhRH j_(ValueTuple<Observation, Observation> _valueTuple)
		{
			var p_ = new Tuple_GAdRFKRaHUUGJcVHWQWRUjhRH
			{
				VR12MentalAssessment = _valueTuple.Item1,
				VR12PhysicalAssessment = _valueTuple.Item2,
			};

			return p_;
		};
		var k_ = context.Operators.Select<ValueTuple<Observation, Observation>, Tuple_GAdRFKRaHUUGJcVHWQWRUjhRH>(i_, j_);
		bool? l_(Tuple_GAdRFKRaHUUGJcVHWQWRUjhRH tuple_gadrfkrahuugjcvhwqwrujhrh)
		{
			var q_ = tuple_gadrfkrahuugjcvhwqwrujhrh.VR12MentalAssessment?.Effective;
			var r_ = FHIRHelpers_4_3_000.ToValue(q_);
			var s_ = QICoreCommon_2_0_000.ToInterval(r_);
			var t_ = context.Operators.Start(s_);
			var u_ = context.Operators.DateFrom(t_);
			var v_ = tuple_gadrfkrahuugjcvhwqwrujhrh.VR12PhysicalAssessment?.Effective;
			var w_ = FHIRHelpers_4_3_000.ToValue(v_);
			var x_ = QICoreCommon_2_0_000.ToInterval(w_);
			var y_ = context.Operators.Start(x_);
			var z_ = context.Operators.DateFrom(y_);
			var aa_ = context.Operators.SameAs(u_, z_, "day");
			var ab_ = tuple_gadrfkrahuugjcvhwqwrujhrh.VR12MentalAssessment?.Value;
			var ac_ = FHIRHelpers_4_3_000.ToValue(ab_);
			var ad_ = context.Operators.Not((bool?)(ac_ is null));
			var ae_ = context.Operators.And(aa_, ad_);
			var af_ = tuple_gadrfkrahuugjcvhwqwrujhrh.VR12PhysicalAssessment?.Value;
			var ag_ = FHIRHelpers_4_3_000.ToValue(af_);
			var ah_ = context.Operators.Not((bool?)(ag_ is null));
			var ai_ = context.Operators.And(ae_, ah_);

			return ai_;
		};
		var m_ = context.Operators.Where<Tuple_GAdRFKRaHUUGJcVHWQWRUjhRH>(k_, l_);
		CqlDate n_(Tuple_GAdRFKRaHUUGJcVHWQWRUjhRH tuple_gadrfkrahuugjcvhwqwrujhrh)
		{
			var aj_ = tuple_gadrfkrahuugjcvhwqwrujhrh.VR12MentalAssessment?.Effective;
			var ak_ = FHIRHelpers_4_3_000.ToValue(aj_);
			var al_ = QICoreCommon_2_0_000.ToInterval(ak_);
			var am_ = context.Operators.Start(al_);
			var an_ = context.Operators.DateFrom(am_);
			var ao_ = tuple_gadrfkrahuugjcvhwqwrujhrh.VR12PhysicalAssessment?.Effective;
			var ap_ = FHIRHelpers_4_3_000.ToValue(ao_);
			var aq_ = QICoreCommon_2_0_000.ToInterval(ap_);
			var ar_ = context.Operators.Start(aq_);
			var as_ = context.Operators.DateFrom(ar_);
			var at_ = new CqlDate[]
			{
				an_,
				as_,
			};
			var au_ = context.Operators.Max<CqlDate>((at_ as IEnumerable<CqlDate>));

			return au_;
		};
		var o_ = context.Operators.Select<Tuple_GAdRFKRaHUUGJcVHWQWRUjhRH, CqlDate>(m_, n_);

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
		Tuple_FaNSVMJaEDMVSdOYROZXdLSaI e_(ValueTuple<Encounter, CqlDate, CqlDate> _valueTuple)
		{
			var l_ = new Tuple_FaNSVMJaEDMVSdOYROZXdLSaI
			{
				ValidEncounters = _valueTuple.Item1,
				InitialVR12OrthogonalDate = _valueTuple.Item2,
				FollowupVR12OrthogonalDate = _valueTuple.Item3,
			};

			return l_;
		};
		var f_ = context.Operators.Select<ValueTuple<Encounter, CqlDate, CqlDate>, Tuple_FaNSVMJaEDMVSdOYROZXdLSaI>(d_, e_);
		bool? g_(Tuple_FaNSVMJaEDMVSdOYROZXdLSaI tuple_fansvmjaedmvsdoyrozxdlsai)
		{
			var m_ = tuple_fansvmjaedmvsdoyrozxdlsai.ValidEncounters?.Period;
			var n_ = FHIRHelpers_4_3_000.ToInterval(m_);
			var o_ = QICoreCommon_2_0_000.ToInterval((n_ as object));
			var p_ = context.Operators.End(o_);
			var q_ = this.Measurement_Period();
			var r_ = context.Operators.End(q_);
			var s_ = context.Operators.Quantity(180m, "days");
			var t_ = context.Operators.Subtract(r_, s_);
			var u_ = context.Operators.SameOrBefore(p_, t_, "day");
			var v_ = context.Operators.ConvertDateToDateTime(tuple_fansvmjaedmvsdoyrozxdlsai.InitialVR12OrthogonalDate);
			var x_ = FHIRHelpers_4_3_000.ToInterval(m_);
			var y_ = QICoreCommon_2_0_000.ToInterval((x_ as object));
			var z_ = context.Operators.End(y_);
			var aa_ = context.Operators.Quantity(14m, "days");
			var ab_ = context.Operators.Subtract(z_, aa_);
			var ad_ = FHIRHelpers_4_3_000.ToInterval(m_);
			var ae_ = QICoreCommon_2_0_000.ToInterval((ad_ as object));
			var af_ = context.Operators.End(ae_);
			var ag_ = context.Operators.Interval(ab_, af_, true, true);
			var ah_ = context.Operators.In<CqlDateTime>(v_, ag_, "day");
			var aj_ = FHIRHelpers_4_3_000.ToInterval(m_);
			var ak_ = QICoreCommon_2_0_000.ToInterval((aj_ as object));
			var al_ = context.Operators.End(ak_);
			var am_ = context.Operators.Not((bool?)(al_ is null));
			var an_ = context.Operators.And(ah_, am_);
			var ao_ = context.Operators.And(u_, an_);
			var ap_ = context.Operators.ConvertDateToDateTime(tuple_fansvmjaedmvsdoyrozxdlsai.FollowupVR12OrthogonalDate);
			var aq_ = context.Operators.DateFrom(ap_);
			var as_ = context.Operators.DateFrom(v_);
			var at_ = context.Operators.Quantity(30m, "days");
			var au_ = context.Operators.Add(as_, at_);
			var aw_ = context.Operators.DateFrom(v_);
			var ay_ = context.Operators.Add(aw_, s_);
			var az_ = context.Operators.Interval(au_, ay_, true, true);
			var ba_ = context.Operators.In<CqlDate>(aq_, az_, "day");
			var bb_ = context.Operators.And(ao_, ba_);

			return bb_;
		};
		var h_ = context.Operators.Where<Tuple_FaNSVMJaEDMVSdOYROZXdLSaI>(f_, g_);
		Encounter i_(Tuple_FaNSVMJaEDMVSdOYROZXdLSaI tuple_fansvmjaedmvsdoyrozxdlsai) => 
			tuple_fansvmjaedmvsdoyrozxdlsai.ValidEncounters;
		var j_ = context.Operators.Select<Tuple_FaNSVMJaEDMVSdOYROZXdLSaI, Encounter>(h_, i_);
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
		Tuple_DUcFTCLcQEWDGGQdFCWTHFaUK j_(ValueTuple<Observation, Observation> _valueTuple)
		{
			var p_ = new Tuple_DUcFTCLcQEWDGGQdFCWTHFaUK
			{
				VR36MentalAssessment = _valueTuple.Item1,
				VR36PhysicalAssessment = _valueTuple.Item2,
			};

			return p_;
		};
		var k_ = context.Operators.Select<ValueTuple<Observation, Observation>, Tuple_DUcFTCLcQEWDGGQdFCWTHFaUK>(i_, j_);
		bool? l_(Tuple_DUcFTCLcQEWDGGQdFCWTHFaUK tuple_ducftclcqewdggqdfcwthfauk)
		{
			var q_ = tuple_ducftclcqewdggqdfcwthfauk.VR36MentalAssessment?.Effective;
			var r_ = FHIRHelpers_4_3_000.ToValue(q_);
			var s_ = QICoreCommon_2_0_000.ToInterval(r_);
			var t_ = context.Operators.Start(s_);
			var u_ = context.Operators.DateFrom(t_);
			var v_ = tuple_ducftclcqewdggqdfcwthfauk.VR36PhysicalAssessment?.Effective;
			var w_ = FHIRHelpers_4_3_000.ToValue(v_);
			var x_ = QICoreCommon_2_0_000.ToInterval(w_);
			var y_ = context.Operators.Start(x_);
			var z_ = context.Operators.DateFrom(y_);
			var aa_ = context.Operators.SameAs(u_, z_, "day");
			var ab_ = tuple_ducftclcqewdggqdfcwthfauk.VR36MentalAssessment?.Value;
			var ac_ = FHIRHelpers_4_3_000.ToValue(ab_);
			var ad_ = context.Operators.Not((bool?)(ac_ is null));
			var ae_ = context.Operators.And(aa_, ad_);
			var af_ = tuple_ducftclcqewdggqdfcwthfauk.VR36PhysicalAssessment?.Value;
			var ag_ = FHIRHelpers_4_3_000.ToValue(af_);
			var ah_ = context.Operators.Not((bool?)(ag_ is null));
			var ai_ = context.Operators.And(ae_, ah_);

			return ai_;
		};
		var m_ = context.Operators.Where<Tuple_DUcFTCLcQEWDGGQdFCWTHFaUK>(k_, l_);
		CqlDate n_(Tuple_DUcFTCLcQEWDGGQdFCWTHFaUK tuple_ducftclcqewdggqdfcwthfauk)
		{
			var aj_ = tuple_ducftclcqewdggqdfcwthfauk.VR36MentalAssessment?.Effective;
			var ak_ = FHIRHelpers_4_3_000.ToValue(aj_);
			var al_ = QICoreCommon_2_0_000.ToInterval(ak_);
			var am_ = context.Operators.Start(al_);
			var an_ = context.Operators.DateFrom(am_);
			var ao_ = tuple_ducftclcqewdggqdfcwthfauk.VR36PhysicalAssessment?.Effective;
			var ap_ = FHIRHelpers_4_3_000.ToValue(ao_);
			var aq_ = QICoreCommon_2_0_000.ToInterval(ap_);
			var ar_ = context.Operators.Start(aq_);
			var as_ = context.Operators.DateFrom(ar_);
			var at_ = new CqlDate[]
			{
				an_,
				as_,
			};
			var au_ = context.Operators.Max<CqlDate>((at_ as IEnumerable<CqlDate>));

			return au_;
		};
		var o_ = context.Operators.Select<Tuple_DUcFTCLcQEWDGGQdFCWTHFaUK, CqlDate>(m_, n_);

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
		Tuple_ELXIcYHRDPYZPQYJPHdiFBiGA e_(ValueTuple<Encounter, CqlDate, CqlDate> _valueTuple)
		{
			var l_ = new Tuple_ELXIcYHRDPYZPQYJPHdiFBiGA
			{
				ValidEncounters = _valueTuple.Item1,
				InitialVR36ObliqueDate = _valueTuple.Item2,
				FollowupVR36ObliqueDate = _valueTuple.Item3,
			};

			return l_;
		};
		var f_ = context.Operators.Select<ValueTuple<Encounter, CqlDate, CqlDate>, Tuple_ELXIcYHRDPYZPQYJPHdiFBiGA>(d_, e_);
		bool? g_(Tuple_ELXIcYHRDPYZPQYJPHdiFBiGA tuple_elxicyhrdpyzpqyjphdifbiga)
		{
			var m_ = tuple_elxicyhrdpyzpqyjphdifbiga.ValidEncounters?.Period;
			var n_ = FHIRHelpers_4_3_000.ToInterval(m_);
			var o_ = QICoreCommon_2_0_000.ToInterval((n_ as object));
			var p_ = context.Operators.End(o_);
			var q_ = this.Measurement_Period();
			var r_ = context.Operators.End(q_);
			var s_ = context.Operators.Quantity(180m, "days");
			var t_ = context.Operators.Subtract(r_, s_);
			var u_ = context.Operators.SameOrBefore(p_, t_, "day");
			var v_ = context.Operators.ConvertDateToDateTime(tuple_elxicyhrdpyzpqyjphdifbiga.InitialVR36ObliqueDate);
			var x_ = FHIRHelpers_4_3_000.ToInterval(m_);
			var y_ = QICoreCommon_2_0_000.ToInterval((x_ as object));
			var z_ = context.Operators.End(y_);
			var aa_ = context.Operators.Quantity(14m, "days");
			var ab_ = context.Operators.Subtract(z_, aa_);
			var ad_ = FHIRHelpers_4_3_000.ToInterval(m_);
			var ae_ = QICoreCommon_2_0_000.ToInterval((ad_ as object));
			var af_ = context.Operators.End(ae_);
			var ag_ = context.Operators.Interval(ab_, af_, true, true);
			var ah_ = context.Operators.In<CqlDateTime>(v_, ag_, "day");
			var aj_ = FHIRHelpers_4_3_000.ToInterval(m_);
			var ak_ = QICoreCommon_2_0_000.ToInterval((aj_ as object));
			var al_ = context.Operators.End(ak_);
			var am_ = context.Operators.Not((bool?)(al_ is null));
			var an_ = context.Operators.And(ah_, am_);
			var ao_ = context.Operators.And(u_, an_);
			var ap_ = context.Operators.ConvertDateToDateTime(tuple_elxicyhrdpyzpqyjphdifbiga.FollowupVR36ObliqueDate);
			var aq_ = context.Operators.DateFrom(ap_);
			var as_ = context.Operators.DateFrom(v_);
			var at_ = context.Operators.Quantity(30m, "days");
			var au_ = context.Operators.Add(as_, at_);
			var aw_ = context.Operators.DateFrom(v_);
			var ay_ = context.Operators.Add(aw_, s_);
			var az_ = context.Operators.Interval(au_, ay_, true, true);
			var ba_ = context.Operators.In<CqlDate>(aq_, az_, "day");
			var bb_ = context.Operators.And(ao_, ba_);

			return bb_;
		};
		var h_ = context.Operators.Where<Tuple_ELXIcYHRDPYZPQYJPHdiFBiGA>(f_, g_);
		Encounter i_(Tuple_ELXIcYHRDPYZPQYJPHdiFBiGA tuple_elxicyhrdpyzpqyjphdifbiga) => 
			tuple_elxicyhrdpyzpqyjphdifbiga.ValidEncounters;
		var j_ = context.Operators.Select<Tuple_ELXIcYHRDPYZPQYJPHdiFBiGA, Encounter>(h_, i_);
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
		Tuple_DUcFTCLcQEWDGGQdFCWTHFaUK j_(ValueTuple<Observation, Observation> _valueTuple)
		{
			var p_ = new Tuple_DUcFTCLcQEWDGGQdFCWTHFaUK
			{
				VR36MentalAssessment = _valueTuple.Item1,
				VR36PhysicalAssessment = _valueTuple.Item2,
			};

			return p_;
		};
		var k_ = context.Operators.Select<ValueTuple<Observation, Observation>, Tuple_DUcFTCLcQEWDGGQdFCWTHFaUK>(i_, j_);
		bool? l_(Tuple_DUcFTCLcQEWDGGQdFCWTHFaUK tuple_ducftclcqewdggqdfcwthfauk)
		{
			var q_ = tuple_ducftclcqewdggqdfcwthfauk.VR36MentalAssessment?.Effective;
			var r_ = FHIRHelpers_4_3_000.ToValue(q_);
			var s_ = QICoreCommon_2_0_000.ToInterval(r_);
			var t_ = context.Operators.Start(s_);
			var u_ = context.Operators.DateFrom(t_);
			var v_ = tuple_ducftclcqewdggqdfcwthfauk.VR36PhysicalAssessment?.Effective;
			var w_ = FHIRHelpers_4_3_000.ToValue(v_);
			var x_ = QICoreCommon_2_0_000.ToInterval(w_);
			var y_ = context.Operators.Start(x_);
			var z_ = context.Operators.DateFrom(y_);
			var aa_ = context.Operators.SameAs(u_, z_, "day");
			var ab_ = tuple_ducftclcqewdggqdfcwthfauk.VR36MentalAssessment?.Value;
			var ac_ = FHIRHelpers_4_3_000.ToValue(ab_);
			var ad_ = context.Operators.Not((bool?)(ac_ is null));
			var ae_ = context.Operators.And(aa_, ad_);
			var af_ = tuple_ducftclcqewdggqdfcwthfauk.VR36PhysicalAssessment?.Value;
			var ag_ = FHIRHelpers_4_3_000.ToValue(af_);
			var ah_ = context.Operators.Not((bool?)(ag_ is null));
			var ai_ = context.Operators.And(ae_, ah_);

			return ai_;
		};
		var m_ = context.Operators.Where<Tuple_DUcFTCLcQEWDGGQdFCWTHFaUK>(k_, l_);
		CqlDate n_(Tuple_DUcFTCLcQEWDGGQdFCWTHFaUK tuple_ducftclcqewdggqdfcwthfauk)
		{
			var aj_ = tuple_ducftclcqewdggqdfcwthfauk.VR36MentalAssessment?.Effective;
			var ak_ = FHIRHelpers_4_3_000.ToValue(aj_);
			var al_ = QICoreCommon_2_0_000.ToInterval(ak_);
			var am_ = context.Operators.Start(al_);
			var an_ = context.Operators.DateFrom(am_);
			var ao_ = tuple_ducftclcqewdggqdfcwthfauk.VR36PhysicalAssessment?.Effective;
			var ap_ = FHIRHelpers_4_3_000.ToValue(ao_);
			var aq_ = QICoreCommon_2_0_000.ToInterval(ap_);
			var ar_ = context.Operators.Start(aq_);
			var as_ = context.Operators.DateFrom(ar_);
			var at_ = new CqlDate[]
			{
				an_,
				as_,
			};
			var au_ = context.Operators.Max<CqlDate>((at_ as IEnumerable<CqlDate>));

			return au_;
		};
		var o_ = context.Operators.Select<Tuple_DUcFTCLcQEWDGGQdFCWTHFaUK, CqlDate>(m_, n_);

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
		Tuple_fUCQUjAdjiZABIHDfFFORMHT e_(ValueTuple<Encounter, CqlDate, CqlDate> _valueTuple)
		{
			var l_ = new Tuple_fUCQUjAdjiZABIHDfFFORMHT
			{
				ValidEncounters = _valueTuple.Item1,
				InitialVR36OrthogonalDate = _valueTuple.Item2,
				FollowupVR36OrthogonalDate = _valueTuple.Item3,
			};

			return l_;
		};
		var f_ = context.Operators.Select<ValueTuple<Encounter, CqlDate, CqlDate>, Tuple_fUCQUjAdjiZABIHDfFFORMHT>(d_, e_);
		bool? g_(Tuple_fUCQUjAdjiZABIHDfFFORMHT tuple_fucqujadjizabihdffformht)
		{
			var m_ = tuple_fucqujadjizabihdffformht.ValidEncounters?.Period;
			var n_ = FHIRHelpers_4_3_000.ToInterval(m_);
			var o_ = QICoreCommon_2_0_000.ToInterval((n_ as object));
			var p_ = context.Operators.End(o_);
			var q_ = this.Measurement_Period();
			var r_ = context.Operators.End(q_);
			var s_ = context.Operators.Quantity(180m, "days");
			var t_ = context.Operators.Subtract(r_, s_);
			var u_ = context.Operators.SameOrBefore(p_, t_, "day");
			var v_ = context.Operators.ConvertDateToDateTime(tuple_fucqujadjizabihdffformht.InitialVR36OrthogonalDate);
			var x_ = FHIRHelpers_4_3_000.ToInterval(m_);
			var y_ = QICoreCommon_2_0_000.ToInterval((x_ as object));
			var z_ = context.Operators.End(y_);
			var aa_ = context.Operators.Quantity(14m, "days");
			var ab_ = context.Operators.Subtract(z_, aa_);
			var ad_ = FHIRHelpers_4_3_000.ToInterval(m_);
			var ae_ = QICoreCommon_2_0_000.ToInterval((ad_ as object));
			var af_ = context.Operators.End(ae_);
			var ag_ = context.Operators.Interval(ab_, af_, true, true);
			var ah_ = context.Operators.In<CqlDateTime>(v_, ag_, "day");
			var aj_ = FHIRHelpers_4_3_000.ToInterval(m_);
			var ak_ = QICoreCommon_2_0_000.ToInterval((aj_ as object));
			var al_ = context.Operators.End(ak_);
			var am_ = context.Operators.Not((bool?)(al_ is null));
			var an_ = context.Operators.And(ah_, am_);
			var ao_ = context.Operators.And(u_, an_);
			var ap_ = context.Operators.ConvertDateToDateTime(tuple_fucqujadjizabihdffformht.FollowupVR36OrthogonalDate);
			var aq_ = context.Operators.DateFrom(ap_);
			var as_ = context.Operators.DateFrom(v_);
			var at_ = context.Operators.Quantity(30m, "days");
			var au_ = context.Operators.Add(as_, at_);
			var aw_ = context.Operators.DateFrom(v_);
			var ay_ = context.Operators.Add(aw_, s_);
			var az_ = context.Operators.Interval(au_, ay_, true, true);
			var ba_ = context.Operators.In<CqlDate>(aq_, az_, "day");
			var bb_ = context.Operators.And(ao_, ba_);

			return bb_;
		};
		var h_ = context.Operators.Where<Tuple_fUCQUjAdjiZABIHDfFFORMHT>(f_, g_);
		Encounter i_(Tuple_fUCQUjAdjiZABIHDfFFORMHT tuple_fucqujadjizabihdffformht) => 
			tuple_fucqujadjizabihdffformht.ValidEncounters;
		var j_ = context.Operators.Select<Tuple_fUCQUjAdjiZABIHDfFFORMHT, Encounter>(h_, i_);
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
		Tuple_FNOFXCKadAeUSJERHBDQfOShE j_(ValueTuple<Observation, Observation> _valueTuple)
		{
			var p_ = new Tuple_FNOFXCKadAeUSJERHBDQfOShE
			{
				MLHFQPhysical = _valueTuple.Item1,
				MLHFQEmotional = _valueTuple.Item2,
			};

			return p_;
		};
		var k_ = context.Operators.Select<ValueTuple<Observation, Observation>, Tuple_FNOFXCKadAeUSJERHBDQfOShE>(i_, j_);
		bool? l_(Tuple_FNOFXCKadAeUSJERHBDQfOShE tuple_fnofxckadaeusjerhbdqfoshe)
		{
			var q_ = tuple_fnofxckadaeusjerhbdqfoshe.MLHFQPhysical?.Effective;
			var r_ = FHIRHelpers_4_3_000.ToValue(q_);
			var s_ = QICoreCommon_2_0_000.ToInterval(r_);
			var t_ = context.Operators.Start(s_);
			var u_ = context.Operators.DateFrom(t_);
			var v_ = tuple_fnofxckadaeusjerhbdqfoshe.MLHFQEmotional?.Effective;
			var w_ = FHIRHelpers_4_3_000.ToValue(v_);
			var x_ = QICoreCommon_2_0_000.ToInterval(w_);
			var y_ = context.Operators.Start(x_);
			var z_ = context.Operators.DateFrom(y_);
			var aa_ = context.Operators.SameAs(u_, z_, "day");
			var ab_ = tuple_fnofxckadaeusjerhbdqfoshe.MLHFQPhysical?.Value;
			var ac_ = FHIRHelpers_4_3_000.ToValue(ab_);
			var ad_ = context.Operators.Not((bool?)(ac_ is null));
			var ae_ = context.Operators.And(aa_, ad_);
			var af_ = tuple_fnofxckadaeusjerhbdqfoshe.MLHFQEmotional?.Value;
			var ag_ = FHIRHelpers_4_3_000.ToValue(af_);
			var ah_ = context.Operators.Not((bool?)(ag_ is null));
			var ai_ = context.Operators.And(ae_, ah_);

			return ai_;
		};
		var m_ = context.Operators.Where<Tuple_FNOFXCKadAeUSJERHBDQfOShE>(k_, l_);
		CqlDate n_(Tuple_FNOFXCKadAeUSJERHBDQfOShE tuple_fnofxckadaeusjerhbdqfoshe)
		{
			var aj_ = tuple_fnofxckadaeusjerhbdqfoshe.MLHFQPhysical?.Effective;
			var ak_ = FHIRHelpers_4_3_000.ToValue(aj_);
			var al_ = QICoreCommon_2_0_000.ToInterval(ak_);
			var am_ = context.Operators.Start(al_);
			var an_ = context.Operators.DateFrom(am_);
			var ao_ = tuple_fnofxckadaeusjerhbdqfoshe.MLHFQEmotional?.Effective;
			var ap_ = FHIRHelpers_4_3_000.ToValue(ao_);
			var aq_ = QICoreCommon_2_0_000.ToInterval(ap_);
			var ar_ = context.Operators.Start(aq_);
			var as_ = context.Operators.DateFrom(ar_);
			var at_ = new CqlDate[]
			{
				an_,
				as_,
			};
			var au_ = context.Operators.Max<CqlDate>((at_ as IEnumerable<CqlDate>));

			return au_;
		};
		var o_ = context.Operators.Select<Tuple_FNOFXCKadAeUSJERHBDQfOShE, CqlDate>(m_, n_);

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
		Tuple_NCDAWCTNMBFMTibMiHSFBAIG e_(ValueTuple<Encounter, CqlDate, CqlDate> _valueTuple)
		{
			var l_ = new Tuple_NCDAWCTNMBFMTibMiHSFBAIG
			{
				ValidEncounters = _valueTuple.Item1,
				InitialMLHFQDate = _valueTuple.Item2,
				FollowupMLHFQDate = _valueTuple.Item3,
			};

			return l_;
		};
		var f_ = context.Operators.Select<ValueTuple<Encounter, CqlDate, CqlDate>, Tuple_NCDAWCTNMBFMTibMiHSFBAIG>(d_, e_);
		bool? g_(Tuple_NCDAWCTNMBFMTibMiHSFBAIG tuple_ncdawctnmbfmtibmihsfbaig)
		{
			var m_ = tuple_ncdawctnmbfmtibmihsfbaig.ValidEncounters?.Period;
			var n_ = FHIRHelpers_4_3_000.ToInterval(m_);
			var o_ = QICoreCommon_2_0_000.ToInterval((n_ as object));
			var p_ = context.Operators.End(o_);
			var q_ = this.Measurement_Period();
			var r_ = context.Operators.End(q_);
			var s_ = context.Operators.Quantity(180m, "days");
			var t_ = context.Operators.Subtract(r_, s_);
			var u_ = context.Operators.SameOrBefore(p_, t_, "day");
			var v_ = context.Operators.ConvertDateToDateTime(tuple_ncdawctnmbfmtibmihsfbaig.InitialMLHFQDate);
			var x_ = FHIRHelpers_4_3_000.ToInterval(m_);
			var y_ = QICoreCommon_2_0_000.ToInterval((x_ as object));
			var z_ = context.Operators.End(y_);
			var aa_ = context.Operators.Quantity(14m, "days");
			var ab_ = context.Operators.Subtract(z_, aa_);
			var ad_ = FHIRHelpers_4_3_000.ToInterval(m_);
			var ae_ = QICoreCommon_2_0_000.ToInterval((ad_ as object));
			var af_ = context.Operators.End(ae_);
			var ag_ = context.Operators.Interval(ab_, af_, true, true);
			var ah_ = context.Operators.In<CqlDateTime>(v_, ag_, "day");
			var aj_ = FHIRHelpers_4_3_000.ToInterval(m_);
			var ak_ = QICoreCommon_2_0_000.ToInterval((aj_ as object));
			var al_ = context.Operators.End(ak_);
			var am_ = context.Operators.Not((bool?)(al_ is null));
			var an_ = context.Operators.And(ah_, am_);
			var ao_ = context.Operators.And(u_, an_);
			var ap_ = context.Operators.ConvertDateToDateTime(tuple_ncdawctnmbfmtibmihsfbaig.FollowupMLHFQDate);
			var aq_ = context.Operators.DateFrom(ap_);
			var as_ = context.Operators.DateFrom(v_);
			var at_ = context.Operators.Quantity(30m, "days");
			var au_ = context.Operators.Add(as_, at_);
			var aw_ = context.Operators.DateFrom(v_);
			var ay_ = context.Operators.Add(aw_, s_);
			var az_ = context.Operators.Interval(au_, ay_, true, true);
			var ba_ = context.Operators.In<CqlDate>(aq_, az_, "day");
			var bb_ = context.Operators.And(ao_, ba_);

			return bb_;
		};
		var h_ = context.Operators.Where<Tuple_NCDAWCTNMBFMTibMiHSFBAIG>(f_, g_);
		Encounter i_(Tuple_NCDAWCTNMBFMTibMiHSFBAIG tuple_ncdawctnmbfmtibmihsfbaig) => 
			tuple_ncdawctnmbfmtibmihsfbaig.ValidEncounters;
		var j_ = context.Operators.Select<Tuple_NCDAWCTNMBFMTibMiHSFBAIG, Encounter>(h_, i_);
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
		Tuple_DFKXORghhYafccUSbQaMfNTDj j_(ValueTuple<Observation, Observation> _valueTuple)
		{
			var p_ = new Tuple_DFKXORghhYafccUSbQaMfNTDj
			{
				KCCQ12Item = _valueTuple.Item1,
				KCCQ12Summary = _valueTuple.Item2,
			};

			return p_;
		};
		var k_ = context.Operators.Select<ValueTuple<Observation, Observation>, Tuple_DFKXORghhYafccUSbQaMfNTDj>(i_, j_);
		bool? l_(Tuple_DFKXORghhYafccUSbQaMfNTDj tuple_dfkxorghhyafccusbqamfntdj)
		{
			var q_ = tuple_dfkxorghhyafccusbqamfntdj.KCCQ12Item?.Effective;
			var r_ = FHIRHelpers_4_3_000.ToValue(q_);
			var s_ = QICoreCommon_2_0_000.ToInterval(r_);
			var t_ = context.Operators.Start(s_);
			var u_ = context.Operators.DateFrom(t_);
			var v_ = tuple_dfkxorghhyafccusbqamfntdj.KCCQ12Summary?.Effective;
			var w_ = FHIRHelpers_4_3_000.ToValue(v_);
			var x_ = QICoreCommon_2_0_000.ToInterval(w_);
			var y_ = context.Operators.Start(x_);
			var z_ = context.Operators.DateFrom(y_);
			var aa_ = context.Operators.SameAs(u_, z_, "day");
			var ab_ = tuple_dfkxorghhyafccusbqamfntdj.KCCQ12Item?.Value;
			var ac_ = FHIRHelpers_4_3_000.ToValue(ab_);
			var ad_ = context.Operators.Not((bool?)(ac_ is null));
			var ae_ = context.Operators.And(aa_, ad_);
			var af_ = tuple_dfkxorghhyafccusbqamfntdj.KCCQ12Summary?.Value;
			var ag_ = FHIRHelpers_4_3_000.ToValue(af_);
			var ah_ = context.Operators.Not((bool?)(ag_ is null));
			var ai_ = context.Operators.And(ae_, ah_);

			return ai_;
		};
		var m_ = context.Operators.Where<Tuple_DFKXORghhYafccUSbQaMfNTDj>(k_, l_);
		CqlDate n_(Tuple_DFKXORghhYafccUSbQaMfNTDj tuple_dfkxorghhyafccusbqamfntdj)
		{
			var aj_ = tuple_dfkxorghhyafccusbqamfntdj.KCCQ12Item?.Effective;
			var ak_ = FHIRHelpers_4_3_000.ToValue(aj_);
			var al_ = QICoreCommon_2_0_000.ToInterval(ak_);
			var am_ = context.Operators.Start(al_);
			var an_ = context.Operators.DateFrom(am_);
			var ao_ = tuple_dfkxorghhyafccusbqamfntdj.KCCQ12Summary?.Effective;
			var ap_ = FHIRHelpers_4_3_000.ToValue(ao_);
			var aq_ = QICoreCommon_2_0_000.ToInterval(ap_);
			var ar_ = context.Operators.Start(aq_);
			var as_ = context.Operators.DateFrom(ar_);
			var at_ = new CqlDate[]
			{
				an_,
				as_,
			};
			var au_ = context.Operators.Max<CqlDate>((at_ as IEnumerable<CqlDate>));

			return au_;
		};
		var o_ = context.Operators.Select<Tuple_DFKXORghhYafccUSbQaMfNTDj, CqlDate>(m_, n_);

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
		Tuple_EOaHGTWWdfQIJhCjZQNViDVUO e_(ValueTuple<Encounter, CqlDate, CqlDate> _valueTuple)
		{
			var l_ = new Tuple_EOaHGTWWdfQIJhCjZQNViDVUO
			{
				ValidEncounters = _valueTuple.Item1,
				InitialKCCQ12Date = _valueTuple.Item2,
				FollowupKCCQ12Date = _valueTuple.Item3,
			};

			return l_;
		};
		var f_ = context.Operators.Select<ValueTuple<Encounter, CqlDate, CqlDate>, Tuple_EOaHGTWWdfQIJhCjZQNViDVUO>(d_, e_);
		bool? g_(Tuple_EOaHGTWWdfQIJhCjZQNViDVUO tuple_eoahgtwwdfqijhcjzqnvidvuo)
		{
			var m_ = tuple_eoahgtwwdfqijhcjzqnvidvuo.ValidEncounters?.Period;
			var n_ = FHIRHelpers_4_3_000.ToInterval(m_);
			var o_ = QICoreCommon_2_0_000.ToInterval((n_ as object));
			var p_ = context.Operators.End(o_);
			var q_ = this.Measurement_Period();
			var r_ = context.Operators.End(q_);
			var s_ = context.Operators.Quantity(180m, "days");
			var t_ = context.Operators.Subtract(r_, s_);
			var u_ = context.Operators.SameOrBefore(p_, t_, "day");
			var v_ = context.Operators.ConvertDateToDateTime(tuple_eoahgtwwdfqijhcjzqnvidvuo.InitialKCCQ12Date);
			var x_ = FHIRHelpers_4_3_000.ToInterval(m_);
			var y_ = QICoreCommon_2_0_000.ToInterval((x_ as object));
			var z_ = context.Operators.End(y_);
			var aa_ = context.Operators.Quantity(14m, "days");
			var ab_ = context.Operators.Subtract(z_, aa_);
			var ad_ = FHIRHelpers_4_3_000.ToInterval(m_);
			var ae_ = QICoreCommon_2_0_000.ToInterval((ad_ as object));
			var af_ = context.Operators.End(ae_);
			var ag_ = context.Operators.Interval(ab_, af_, true, true);
			var ah_ = context.Operators.In<CqlDateTime>(v_, ag_, "day");
			var aj_ = FHIRHelpers_4_3_000.ToInterval(m_);
			var ak_ = QICoreCommon_2_0_000.ToInterval((aj_ as object));
			var al_ = context.Operators.End(ak_);
			var am_ = context.Operators.Not((bool?)(al_ is null));
			var an_ = context.Operators.And(ah_, am_);
			var ao_ = context.Operators.And(u_, an_);
			var ap_ = context.Operators.ConvertDateToDateTime(tuple_eoahgtwwdfqijhcjzqnvidvuo.FollowupKCCQ12Date);
			var aq_ = context.Operators.DateFrom(ap_);
			var as_ = context.Operators.DateFrom(v_);
			var at_ = context.Operators.Quantity(30m, "days");
			var au_ = context.Operators.Add(as_, at_);
			var aw_ = context.Operators.DateFrom(v_);
			var ay_ = context.Operators.Add(aw_, s_);
			var az_ = context.Operators.Interval(au_, ay_, true, true);
			var ba_ = context.Operators.In<CqlDate>(aq_, az_, "day");
			var bb_ = context.Operators.And(ao_, ba_);

			return bb_;
		};
		var h_ = context.Operators.Where<Tuple_EOaHGTWWdfQIJhCjZQNViDVUO>(f_, g_);
		Encounter i_(Tuple_EOaHGTWWdfQIJhCjZQNViDVUO tuple_eoahgtwwdfqijhcjzqnvidvuo) => 
			tuple_eoahgtwwdfqijhcjzqnvidvuo.ValidEncounters;
		var j_ = context.Operators.Select<Tuple_EOaHGTWWdfQIJhCjZQNViDVUO, Encounter>(h_, i_);
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
		Tuple_ETfcAWdPMcQFBNAYQdMDQQSdN z_(ValueTuple<Observation, Observation, Observation, Observation, Observation, Observation> _valueTuple)
		{
			var af_ = new Tuple_ETfcAWdPMcQFBNAYQdMDQQSdN
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
		var aa_ = context.Operators.Select<ValueTuple<Observation, Observation, Observation, Observation, Observation, Observation>, Tuple_ETfcAWdPMcQFBNAYQdMDQQSdN>(y_, z_);
		bool? ab_(Tuple_ETfcAWdPMcQFBNAYQdMDQQSdN tuple_etfcawdpmcqfbnayqdmdqqsdn)
		{
			var ag_ = tuple_etfcawdpmcqfbnayqdmdqqsdn.KCCQLifeQuality?.Effective;
			var ah_ = FHIRHelpers_4_3_000.ToValue(ag_);
			var ai_ = QICoreCommon_2_0_000.ToInterval(ah_);
			var aj_ = context.Operators.Start(ai_);
			var ak_ = context.Operators.DateFrom(aj_);
			var al_ = tuple_etfcawdpmcqfbnayqdmdqqsdn.KCCQSymptomStability?.Effective;
			var am_ = FHIRHelpers_4_3_000.ToValue(al_);
			var an_ = QICoreCommon_2_0_000.ToInterval(am_);
			var ao_ = context.Operators.Start(an_);
			var ap_ = context.Operators.DateFrom(ao_);
			var aq_ = context.Operators.SameAs(ak_, ap_, "day");
			var ar_ = tuple_etfcawdpmcqfbnayqdmdqqsdn.KCCQSymptomStability?.Value;
			var as_ = FHIRHelpers_4_3_000.ToValue(ar_);
			var at_ = context.Operators.Not((bool?)(as_ is null));
			var au_ = context.Operators.And(aq_, at_);
			var aw_ = FHIRHelpers_4_3_000.ToValue(ag_);
			var ax_ = QICoreCommon_2_0_000.ToInterval(aw_);
			var ay_ = context.Operators.Start(ax_);
			var az_ = context.Operators.DateFrom(ay_);
			var ba_ = tuple_etfcawdpmcqfbnayqdmdqqsdn.KCCQSelfEfficacy?.Effective;
			var bb_ = FHIRHelpers_4_3_000.ToValue(ba_);
			var bc_ = QICoreCommon_2_0_000.ToInterval(bb_);
			var bd_ = context.Operators.Start(bc_);
			var be_ = context.Operators.DateFrom(bd_);
			var bf_ = context.Operators.SameAs(az_, be_, "day");
			var bg_ = context.Operators.And(au_, bf_);
			var bh_ = tuple_etfcawdpmcqfbnayqdmdqqsdn.KCCQSelfEfficacy?.Value;
			var bi_ = FHIRHelpers_4_3_000.ToValue(bh_);
			var bj_ = context.Operators.Not((bool?)(bi_ is null));
			var bk_ = context.Operators.And(bg_, bj_);
			var bm_ = FHIRHelpers_4_3_000.ToValue(ag_);
			var bn_ = QICoreCommon_2_0_000.ToInterval(bm_);
			var bo_ = context.Operators.Start(bn_);
			var bp_ = context.Operators.DateFrom(bo_);
			var bq_ = tuple_etfcawdpmcqfbnayqdmdqqsdn.KCCQSymptoms?.Effective;
			var br_ = FHIRHelpers_4_3_000.ToValue(bq_);
			var bs_ = QICoreCommon_2_0_000.ToInterval(br_);
			var bt_ = context.Operators.Start(bs_);
			var bu_ = context.Operators.DateFrom(bt_);
			var bv_ = context.Operators.SameAs(bp_, bu_, "day");
			var bw_ = context.Operators.And(bk_, bv_);
			var bx_ = tuple_etfcawdpmcqfbnayqdmdqqsdn.KCCQSymptoms?.Value;
			var by_ = FHIRHelpers_4_3_000.ToValue(bx_);
			var bz_ = context.Operators.Not((bool?)(by_ is null));
			var ca_ = context.Operators.And(bw_, bz_);
			var cc_ = FHIRHelpers_4_3_000.ToValue(ag_);
			var cd_ = QICoreCommon_2_0_000.ToInterval(cc_);
			var ce_ = context.Operators.Start(cd_);
			var cf_ = context.Operators.DateFrom(ce_);
			var cg_ = tuple_etfcawdpmcqfbnayqdmdqqsdn.KCCQPhysicalLimits?.Effective;
			var ch_ = FHIRHelpers_4_3_000.ToValue(cg_);
			var ci_ = QICoreCommon_2_0_000.ToInterval(ch_);
			var cj_ = context.Operators.Start(ci_);
			var ck_ = context.Operators.DateFrom(cj_);
			var cl_ = context.Operators.SameAs(cf_, ck_, "day");
			var cm_ = context.Operators.And(ca_, cl_);
			var cn_ = tuple_etfcawdpmcqfbnayqdmdqqsdn.KCCQPhysicalLimits?.Value;
			var co_ = FHIRHelpers_4_3_000.ToValue(cn_);
			var cp_ = context.Operators.Not((bool?)(co_ is null));
			var cq_ = context.Operators.And(cm_, cp_);
			var cs_ = FHIRHelpers_4_3_000.ToValue(ag_);
			var ct_ = QICoreCommon_2_0_000.ToInterval(cs_);
			var cu_ = context.Operators.Start(ct_);
			var cv_ = context.Operators.DateFrom(cu_);
			var cw_ = tuple_etfcawdpmcqfbnayqdmdqqsdn.KCCQSocialLimits?.Effective;
			var cx_ = FHIRHelpers_4_3_000.ToValue(cw_);
			var cy_ = QICoreCommon_2_0_000.ToInterval(cx_);
			var cz_ = context.Operators.Start(cy_);
			var da_ = context.Operators.DateFrom(cz_);
			var db_ = context.Operators.SameAs(cv_, da_, "day");
			var dc_ = context.Operators.And(cq_, db_);
			var dd_ = tuple_etfcawdpmcqfbnayqdmdqqsdn.KCCQSocialLimits?.Value;
			var de_ = FHIRHelpers_4_3_000.ToValue(dd_);
			var df_ = context.Operators.Not((bool?)(de_ is null));
			var dg_ = context.Operators.And(dc_, df_);
			var dh_ = tuple_etfcawdpmcqfbnayqdmdqqsdn.KCCQLifeQuality?.Value;
			var di_ = FHIRHelpers_4_3_000.ToValue(dh_);
			var dj_ = context.Operators.Not((bool?)(di_ is null));
			var dk_ = context.Operators.And(dg_, dj_);

			return dk_;
		};
		var ac_ = context.Operators.Where<Tuple_ETfcAWdPMcQFBNAYQdMDQQSdN>(aa_, ab_);
		CqlDate ad_(Tuple_ETfcAWdPMcQFBNAYQdMDQQSdN tuple_etfcawdpmcqfbnayqdmdqqsdn)
		{
			var dl_ = tuple_etfcawdpmcqfbnayqdmdqqsdn.KCCQLifeQuality?.Effective;
			var dm_ = FHIRHelpers_4_3_000.ToValue(dl_);
			var dn_ = QICoreCommon_2_0_000.ToInterval(dm_);
			var do_ = context.Operators.Start(dn_);
			var dp_ = context.Operators.DateFrom(do_);
			var dq_ = tuple_etfcawdpmcqfbnayqdmdqqsdn.KCCQSymptomStability?.Effective;
			var dr_ = FHIRHelpers_4_3_000.ToValue(dq_);
			var ds_ = QICoreCommon_2_0_000.ToInterval(dr_);
			var dt_ = context.Operators.Start(ds_);
			var du_ = context.Operators.DateFrom(dt_);
			var dv_ = tuple_etfcawdpmcqfbnayqdmdqqsdn.KCCQSelfEfficacy?.Effective;
			var dw_ = FHIRHelpers_4_3_000.ToValue(dv_);
			var dx_ = QICoreCommon_2_0_000.ToInterval(dw_);
			var dy_ = context.Operators.Start(dx_);
			var dz_ = context.Operators.DateFrom(dy_);
			var ea_ = tuple_etfcawdpmcqfbnayqdmdqqsdn.KCCQSymptoms?.Effective;
			var eb_ = FHIRHelpers_4_3_000.ToValue(ea_);
			var ec_ = QICoreCommon_2_0_000.ToInterval(eb_);
			var ed_ = context.Operators.Start(ec_);
			var ee_ = context.Operators.DateFrom(ed_);
			var ef_ = tuple_etfcawdpmcqfbnayqdmdqqsdn.KCCQPhysicalLimits?.Effective;
			var eg_ = FHIRHelpers_4_3_000.ToValue(ef_);
			var eh_ = QICoreCommon_2_0_000.ToInterval(eg_);
			var ei_ = context.Operators.Start(eh_);
			var ej_ = context.Operators.DateFrom(ei_);
			var ek_ = tuple_etfcawdpmcqfbnayqdmdqqsdn.KCCQSocialLimits?.Effective;
			var el_ = FHIRHelpers_4_3_000.ToValue(ek_);
			var em_ = QICoreCommon_2_0_000.ToInterval(el_);
			var en_ = context.Operators.Start(em_);
			var eo_ = context.Operators.DateFrom(en_);
			var ep_ = new CqlDate[]
			{
				dp_,
				du_,
				dz_,
				ee_,
				ej_,
				eo_,
			};
			var eq_ = context.Operators.Max<CqlDate>((ep_ as IEnumerable<CqlDate>));

			return eq_;
		};
		var ae_ = context.Operators.Select<Tuple_ETfcAWdPMcQFBNAYQdMDQQSdN, CqlDate>(ac_, ad_);

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
		Tuple_HRLUHbCfCSVNVRRNjajAHdcEA e_(ValueTuple<Encounter, CqlDate, CqlDate> _valueTuple)
		{
			var l_ = new Tuple_HRLUHbCfCSVNVRRNjajAHdcEA
			{
				ValidEncounters = _valueTuple.Item1,
				InitialKCCQAssessmentDate = _valueTuple.Item2,
				FollowupKCCQAssessmentDate = _valueTuple.Item3,
			};

			return l_;
		};
		var f_ = context.Operators.Select<ValueTuple<Encounter, CqlDate, CqlDate>, Tuple_HRLUHbCfCSVNVRRNjajAHdcEA>(d_, e_);
		bool? g_(Tuple_HRLUHbCfCSVNVRRNjajAHdcEA tuple_hrluhbcfcsvnvrrnjajahdcea)
		{
			var m_ = tuple_hrluhbcfcsvnvrrnjajahdcea.ValidEncounters?.Period;
			var n_ = FHIRHelpers_4_3_000.ToInterval(m_);
			var o_ = QICoreCommon_2_0_000.ToInterval((n_ as object));
			var p_ = context.Operators.End(o_);
			var q_ = this.Measurement_Period();
			var r_ = context.Operators.End(q_);
			var s_ = context.Operators.Quantity(180m, "days");
			var t_ = context.Operators.Subtract(r_, s_);
			var u_ = context.Operators.SameOrBefore(p_, t_, "day");
			var v_ = context.Operators.ConvertDateToDateTime(tuple_hrluhbcfcsvnvrrnjajahdcea.InitialKCCQAssessmentDate);
			var x_ = FHIRHelpers_4_3_000.ToInterval(m_);
			var y_ = QICoreCommon_2_0_000.ToInterval((x_ as object));
			var z_ = context.Operators.End(y_);
			var aa_ = context.Operators.Quantity(14m, "days");
			var ab_ = context.Operators.Subtract(z_, aa_);
			var ad_ = FHIRHelpers_4_3_000.ToInterval(m_);
			var ae_ = QICoreCommon_2_0_000.ToInterval((ad_ as object));
			var af_ = context.Operators.End(ae_);
			var ag_ = context.Operators.Interval(ab_, af_, true, true);
			var ah_ = context.Operators.In<CqlDateTime>(v_, ag_, "day");
			var aj_ = FHIRHelpers_4_3_000.ToInterval(m_);
			var ak_ = QICoreCommon_2_0_000.ToInterval((aj_ as object));
			var al_ = context.Operators.End(ak_);
			var am_ = context.Operators.Not((bool?)(al_ is null));
			var an_ = context.Operators.And(ah_, am_);
			var ao_ = context.Operators.And(u_, an_);
			var ap_ = context.Operators.ConvertDateToDateTime(tuple_hrluhbcfcsvnvrrnjajahdcea.FollowupKCCQAssessmentDate);
			var aq_ = context.Operators.DateFrom(ap_);
			var as_ = context.Operators.DateFrom(v_);
			var at_ = context.Operators.Quantity(30m, "days");
			var au_ = context.Operators.Add(as_, at_);
			var aw_ = context.Operators.DateFrom(v_);
			var ay_ = context.Operators.Add(aw_, s_);
			var az_ = context.Operators.Interval(au_, ay_, true, true);
			var ba_ = context.Operators.In<CqlDate>(aq_, az_, "day");
			var bb_ = context.Operators.And(ao_, ba_);

			return bb_;
		};
		var h_ = context.Operators.Where<Tuple_HRLUHbCfCSVNVRRNjajAHdcEA>(f_, g_);
		Encounter i_(Tuple_HRLUHbCfCSVNVRRNjajAHdcEA tuple_hrluhbcfcsvnvrrnjajahdcea) => 
			tuple_hrluhbcfcsvnvrrnjajahdcea.ValidEncounters;
		var j_ = context.Operators.Select<Tuple_HRLUHbCfCSVNVRRNjajAHdcEA, Encounter>(h_, i_);
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
			var i_ = KCCQSummaryScore?.Value;
			var j_ = FHIRHelpers_4_3_000.ToValue(i_);
			var k_ = context.Operators.Not((bool?)(j_ is null));

			return k_;
		};
		var f_ = context.Operators.Where<Observation>(d_, e_);
		CqlDate g_(Observation KCCQSummaryScore)
		{
			var l_ = KCCQSummaryScore?.Effective;
			var m_ = FHIRHelpers_4_3_000.ToValue(l_);
			var n_ = QICoreCommon_2_0_000.ToInterval(m_);
			var o_ = context.Operators.Start(n_);
			var p_ = context.Operators.DateFrom(o_);
			var q_ = new CqlDate[]
			{
				p_,
			};
			var r_ = context.Operators.Max<CqlDate>((q_ as IEnumerable<CqlDate>));

			return r_;
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
		Tuple_DGROjeEKDVIZSVYiSEPDjhJgj e_(ValueTuple<Encounter, CqlDate, CqlDate> _valueTuple)
		{
			var l_ = new Tuple_DGROjeEKDVIZSVYiSEPDjhJgj
			{
				ValidEncounters = _valueTuple.Item1,
				InitialKCCQTotalScore = _valueTuple.Item2,
				FollowupKCCQTotalScore = _valueTuple.Item3,
			};

			return l_;
		};
		var f_ = context.Operators.Select<ValueTuple<Encounter, CqlDate, CqlDate>, Tuple_DGROjeEKDVIZSVYiSEPDjhJgj>(d_, e_);
		bool? g_(Tuple_DGROjeEKDVIZSVYiSEPDjhJgj tuple_dgrojeekdvizsvyisepdjhjgj)
		{
			var m_ = tuple_dgrojeekdvizsvyisepdjhjgj.ValidEncounters?.Period;
			var n_ = FHIRHelpers_4_3_000.ToInterval(m_);
			var o_ = QICoreCommon_2_0_000.ToInterval((n_ as object));
			var p_ = context.Operators.End(o_);
			var q_ = this.Measurement_Period();
			var r_ = context.Operators.End(q_);
			var s_ = context.Operators.Quantity(180m, "days");
			var t_ = context.Operators.Subtract(r_, s_);
			var u_ = context.Operators.SameOrBefore(p_, t_, "day");
			var v_ = context.Operators.ConvertDateToDateTime(tuple_dgrojeekdvizsvyisepdjhjgj.InitialKCCQTotalScore);
			var x_ = FHIRHelpers_4_3_000.ToInterval(m_);
			var y_ = QICoreCommon_2_0_000.ToInterval((x_ as object));
			var z_ = context.Operators.End(y_);
			var aa_ = context.Operators.Quantity(14m, "days");
			var ab_ = context.Operators.Subtract(z_, aa_);
			var ad_ = FHIRHelpers_4_3_000.ToInterval(m_);
			var ae_ = QICoreCommon_2_0_000.ToInterval((ad_ as object));
			var af_ = context.Operators.End(ae_);
			var ag_ = context.Operators.Interval(ab_, af_, true, true);
			var ah_ = context.Operators.In<CqlDateTime>(v_, ag_, "day");
			var aj_ = FHIRHelpers_4_3_000.ToInterval(m_);
			var ak_ = QICoreCommon_2_0_000.ToInterval((aj_ as object));
			var al_ = context.Operators.End(ak_);
			var am_ = context.Operators.Not((bool?)(al_ is null));
			var an_ = context.Operators.And(ah_, am_);
			var ao_ = context.Operators.And(u_, an_);
			var ap_ = context.Operators.ConvertDateToDateTime(tuple_dgrojeekdvizsvyisepdjhjgj.FollowupKCCQTotalScore);
			var aq_ = context.Operators.DateFrom(ap_);
			var as_ = context.Operators.DateFrom(v_);
			var at_ = context.Operators.Quantity(30m, "days");
			var au_ = context.Operators.Add(as_, at_);
			var aw_ = context.Operators.DateFrom(v_);
			var ay_ = context.Operators.Add(aw_, s_);
			var az_ = context.Operators.Interval(au_, ay_, true, true);
			var ba_ = context.Operators.In<CqlDate>(aq_, az_, "day");
			var bb_ = context.Operators.And(ao_, ba_);

			return bb_;
		};
		var h_ = context.Operators.Where<Tuple_DGROjeEKDVIZSVYiSEPDjhJgj>(f_, g_);
		Encounter i_(Tuple_DGROjeEKDVIZSVYiSEPDjhJgj tuple_dgrojeekdvizsvyisepdjhjgj) => 
			tuple_dgrojeekdvizsvyisepdjhjgj.ValidEncounters;
		var j_ = context.Operators.Select<Tuple_DGROjeEKDVIZSVYiSEPDjhJgj, Encounter>(h_, i_);
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
