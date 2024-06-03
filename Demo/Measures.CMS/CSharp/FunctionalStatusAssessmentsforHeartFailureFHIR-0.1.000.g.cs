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

    /// <seealso cref="Heart_Failure"/>
	private CqlValueSet Heart_Failure_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.376", null);

    /// <seealso cref="Heart_Failure_Value"/>
    [CqlDeclaration("Heart Failure")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.376")]
	public CqlValueSet Heart_Failure() => 
		__Heart_Failure.Value;

    /// <seealso cref="Office_Visit"/>
	private CqlValueSet Office_Visit_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1001", null);

    /// <seealso cref="Office_Visit_Value"/>
    [CqlDeclaration("Office Visit")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1001")]
	public CqlValueSet Office_Visit() => 
		__Office_Visit.Value;

    /// <seealso cref="Online_Assessments"/>
	private CqlValueSet Online_Assessments_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1089", null);

    /// <seealso cref="Online_Assessments_Value"/>
    [CqlDeclaration("Online Assessments")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1089")]
	public CqlValueSet Online_Assessments() => 
		__Online_Assessments.Value;

    /// <seealso cref="Telephone_Visits"/>
	private CqlValueSet Telephone_Visits_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1080", null);

    /// <seealso cref="Telephone_Visits_Value"/>
    [CqlDeclaration("Telephone Visits")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1080")]
	public CqlValueSet Telephone_Visits() => 
		__Telephone_Visits.Value;

    /// <seealso cref="Emotional_score__MLHFQ_"/>
	private CqlCode Emotional_score__MLHFQ__Value() => 
		new CqlCode("85609-6", "http://loinc.org", null, null);

    /// <seealso cref="Emotional_score__MLHFQ__Value"/>
    [CqlDeclaration("Emotional score [MLHFQ]")]
	public CqlCode Emotional_score__MLHFQ_() => 
		__Emotional_score__MLHFQ_.Value;

    /// <seealso cref="Kansas_City_Cardiomyopathy_Questionnaire___12_item__KCCQ_12_"/>
	private CqlCode Kansas_City_Cardiomyopathy_Questionnaire___12_item__KCCQ_12__Value() => 
		new CqlCode("86923-0", "http://loinc.org", null, null);

    /// <seealso cref="Kansas_City_Cardiomyopathy_Questionnaire___12_item__KCCQ_12__Value"/>
    [CqlDeclaration("Kansas City Cardiomyopathy Questionnaire - 12 item [KCCQ-12]")]
	public CqlCode Kansas_City_Cardiomyopathy_Questionnaire___12_item__KCCQ_12_() => 
		__Kansas_City_Cardiomyopathy_Questionnaire___12_item__KCCQ_12_.Value;

    /// <seealso cref="Overall_summary_score__KCCQ_12_"/>
	private CqlCode Overall_summary_score__KCCQ_12__Value() => 
		new CqlCode("86924-8", "http://loinc.org", null, null);

    /// <seealso cref="Overall_summary_score__KCCQ_12__Value"/>
    [CqlDeclaration("Overall summary score [KCCQ-12]")]
	public CqlCode Overall_summary_score__KCCQ_12_() => 
		__Overall_summary_score__KCCQ_12_.Value;

    /// <seealso cref="Overall_summary_score__KCCQ_"/>
	private CqlCode Overall_summary_score__KCCQ__Value() => 
		new CqlCode("71940-1", "http://loinc.org", null, null);

    /// <seealso cref="Overall_summary_score__KCCQ__Value"/>
    [CqlDeclaration("Overall summary score [KCCQ]")]
	public CqlCode Overall_summary_score__KCCQ_() => 
		__Overall_summary_score__KCCQ_.Value;

    /// <seealso cref="Physical_limitation_score__KCCQ_"/>
	private CqlCode Physical_limitation_score__KCCQ__Value() => 
		new CqlCode("72195-1", "http://loinc.org", null, null);

    /// <seealso cref="Physical_limitation_score__KCCQ__Value"/>
    [CqlDeclaration("Physical limitation score [KCCQ]")]
	public CqlCode Physical_limitation_score__KCCQ_() => 
		__Physical_limitation_score__KCCQ_.Value;

    /// <seealso cref="Physical_score__MLHFQ_"/>
	private CqlCode Physical_score__MLHFQ__Value() => 
		new CqlCode("85618-7", "http://loinc.org", null, null);

    /// <seealso cref="Physical_score__MLHFQ__Value"/>
    [CqlDeclaration("Physical score [MLHFQ]")]
	public CqlCode Physical_score__MLHFQ_() => 
		__Physical_score__MLHFQ_.Value;

    /// <seealso cref="PROMIS_10_Global_Mental_Health__GMH__score_T_score"/>
	private CqlCode PROMIS_10_Global_Mental_Health__GMH__score_T_score_Value() => 
		new CqlCode("71969-0", "http://loinc.org", null, null);

    /// <seealso cref="PROMIS_10_Global_Mental_Health__GMH__score_T_score_Value"/>
    [CqlDeclaration("PROMIS-10 Global Mental Health (GMH) score T-score")]
	public CqlCode PROMIS_10_Global_Mental_Health__GMH__score_T_score() => 
		__PROMIS_10_Global_Mental_Health__GMH__score_T_score.Value;

    /// <seealso cref="PROMIS_10_Global_Physical_Health__GPH__score_T_score"/>
	private CqlCode PROMIS_10_Global_Physical_Health__GPH__score_T_score_Value() => 
		new CqlCode("71971-6", "http://loinc.org", null, null);

    /// <seealso cref="PROMIS_10_Global_Physical_Health__GPH__score_T_score_Value"/>
    [CqlDeclaration("PROMIS-10 Global Physical Health (GPH) score T-score")]
	public CqlCode PROMIS_10_Global_Physical_Health__GPH__score_T_score() => 
		__PROMIS_10_Global_Physical_Health__GPH__score_T_score.Value;

    /// <seealso cref="PROMIS_29_Anxiety_score_T_score"/>
	private CqlCode PROMIS_29_Anxiety_score_T_score_Value() => 
		new CqlCode("71967-4", "http://loinc.org", null, null);

    /// <seealso cref="PROMIS_29_Anxiety_score_T_score_Value"/>
    [CqlDeclaration("PROMIS-29 Anxiety score T-score")]
	public CqlCode PROMIS_29_Anxiety_score_T_score() => 
		__PROMIS_29_Anxiety_score_T_score.Value;

    /// <seealso cref="PROMIS_29_Depression_score_T_score"/>
	private CqlCode PROMIS_29_Depression_score_T_score_Value() => 
		new CqlCode("71965-8", "http://loinc.org", null, null);

    /// <seealso cref="PROMIS_29_Depression_score_T_score_Value"/>
    [CqlDeclaration("PROMIS-29 Depression score T-score")]
	public CqlCode PROMIS_29_Depression_score_T_score() => 
		__PROMIS_29_Depression_score_T_score.Value;

    /// <seealso cref="PROMIS_29_Fatigue_score_T_score"/>
	private CqlCode PROMIS_29_Fatigue_score_T_score_Value() => 
		new CqlCode("71963-3", "http://loinc.org", null, null);

    /// <seealso cref="PROMIS_29_Fatigue_score_T_score_Value"/>
    [CqlDeclaration("PROMIS-29 Fatigue score T-score")]
	public CqlCode PROMIS_29_Fatigue_score_T_score() => 
		__PROMIS_29_Fatigue_score_T_score.Value;

    /// <seealso cref="PROMIS_29_Pain_interference_score_T_score"/>
	private CqlCode PROMIS_29_Pain_interference_score_T_score_Value() => 
		new CqlCode("71961-7", "http://loinc.org", null, null);

    /// <seealso cref="PROMIS_29_Pain_interference_score_T_score_Value"/>
    [CqlDeclaration("PROMIS-29 Pain interference score T-score")]
	public CqlCode PROMIS_29_Pain_interference_score_T_score() => 
		__PROMIS_29_Pain_interference_score_T_score.Value;

    /// <seealso cref="PROMIS_29_Physical_function_score_T_score"/>
	private CqlCode PROMIS_29_Physical_function_score_T_score_Value() => 
		new CqlCode("71959-1", "http://loinc.org", null, null);

    /// <seealso cref="PROMIS_29_Physical_function_score_T_score_Value"/>
    [CqlDeclaration("PROMIS-29 Physical function score T-score")]
	public CqlCode PROMIS_29_Physical_function_score_T_score() => 
		__PROMIS_29_Physical_function_score_T_score.Value;

    /// <seealso cref="PROMIS_29_Satisfaction_with_participation_in_social_roles_score_T_score"/>
	private CqlCode PROMIS_29_Satisfaction_with_participation_in_social_roles_score_T_score_Value() => 
		new CqlCode("71957-5", "http://loinc.org", null, null);

    /// <seealso cref="PROMIS_29_Satisfaction_with_participation_in_social_roles_score_T_score_Value"/>
    [CqlDeclaration("PROMIS-29 Satisfaction with participation in social roles score T-score")]
	public CqlCode PROMIS_29_Satisfaction_with_participation_in_social_roles_score_T_score() => 
		__PROMIS_29_Satisfaction_with_participation_in_social_roles_score_T_score.Value;

    /// <seealso cref="PROMIS_29_Sleep_disturbance_score_T_score"/>
	private CqlCode PROMIS_29_Sleep_disturbance_score_T_score_Value() => 
		new CqlCode("71955-9", "http://loinc.org", null, null);

    /// <seealso cref="PROMIS_29_Sleep_disturbance_score_T_score_Value"/>
    [CqlDeclaration("PROMIS-29 Sleep disturbance score T-score")]
	public CqlCode PROMIS_29_Sleep_disturbance_score_T_score() => 
		__PROMIS_29_Sleep_disturbance_score_T_score.Value;

    /// <seealso cref="Quality_of_life_score__KCCQ_"/>
	private CqlCode Quality_of_life_score__KCCQ__Value() => 
		new CqlCode("72189-4", "http://loinc.org", null, null);

    /// <seealso cref="Quality_of_life_score__KCCQ__Value"/>
    [CqlDeclaration("Quality of life score [KCCQ]")]
	public CqlCode Quality_of_life_score__KCCQ_() => 
		__Quality_of_life_score__KCCQ_.Value;

    /// <seealso cref="Self_efficacy_score__KCCQ_"/>
	private CqlCode Self_efficacy_score__KCCQ__Value() => 
		new CqlCode("72190-2", "http://loinc.org", null, null);

    /// <seealso cref="Self_efficacy_score__KCCQ__Value"/>
    [CqlDeclaration("Self-efficacy score [KCCQ]")]
	public CqlCode Self_efficacy_score__KCCQ_() => 
		__Self_efficacy_score__KCCQ_.Value;

    /// <seealso cref="Severe_cognitive_impairment__finding_"/>
	private CqlCode Severe_cognitive_impairment__finding__Value() => 
		new CqlCode("702956004", "http://snomed.info/sct", null, null);

    /// <seealso cref="Severe_cognitive_impairment__finding__Value"/>
    [CqlDeclaration("Severe cognitive impairment (finding)")]
	public CqlCode Severe_cognitive_impairment__finding_() => 
		__Severe_cognitive_impairment__finding_.Value;

    /// <seealso cref="Social_limitation_score__KCCQ_"/>
	private CqlCode Social_limitation_score__KCCQ__Value() => 
		new CqlCode("72196-9", "http://loinc.org", null, null);

    /// <seealso cref="Social_limitation_score__KCCQ__Value"/>
    [CqlDeclaration("Social limitation score [KCCQ]")]
	public CqlCode Social_limitation_score__KCCQ_() => 
		__Social_limitation_score__KCCQ_.Value;

    /// <seealso cref="Symptom_stability_score__KCCQ_"/>
	private CqlCode Symptom_stability_score__KCCQ__Value() => 
		new CqlCode("72194-4", "http://loinc.org", null, null);

    /// <seealso cref="Symptom_stability_score__KCCQ__Value"/>
    [CqlDeclaration("Symptom stability score [KCCQ]")]
	public CqlCode Symptom_stability_score__KCCQ_() => 
		__Symptom_stability_score__KCCQ_.Value;

    /// <seealso cref="Total_score__MLHFQ_"/>
	private CqlCode Total_score__MLHFQ__Value() => 
		new CqlCode("71938-5", "http://loinc.org", null, null);

    /// <seealso cref="Total_score__MLHFQ__Value"/>
    [CqlDeclaration("Total score [MLHFQ]")]
	public CqlCode Total_score__MLHFQ_() => 
		__Total_score__MLHFQ_.Value;

    /// <seealso cref="Total_symptom_score__KCCQ_"/>
	private CqlCode Total_symptom_score__KCCQ__Value() => 
		new CqlCode("72191-0", "http://loinc.org", null, null);

    /// <seealso cref="Total_symptom_score__KCCQ__Value"/>
    [CqlDeclaration("Total symptom score [KCCQ]")]
	public CqlCode Total_symptom_score__KCCQ_() => 
		__Total_symptom_score__KCCQ_.Value;

    /// <seealso cref="VR_12_Mental_component_summary__MCS__score___oblique_method_T_score"/>
	private CqlCode VR_12_Mental_component_summary__MCS__score___oblique_method_T_score_Value() => 
		new CqlCode("72026-8", "http://loinc.org", null, null);

    /// <seealso cref="VR_12_Mental_component_summary__MCS__score___oblique_method_T_score_Value"/>
    [CqlDeclaration("VR-12 Mental component summary (MCS) score - oblique method T-score")]
	public CqlCode VR_12_Mental_component_summary__MCS__score___oblique_method_T_score() => 
		__VR_12_Mental_component_summary__MCS__score___oblique_method_T_score.Value;

    /// <seealso cref="VR_12_Mental_component_summary__MCS__score___orthogonal_method_T_score"/>
	private CqlCode VR_12_Mental_component_summary__MCS__score___orthogonal_method_T_score_Value() => 
		new CqlCode("72028-4", "http://loinc.org", null, null);

    /// <seealso cref="VR_12_Mental_component_summary__MCS__score___orthogonal_method_T_score_Value"/>
    [CqlDeclaration("VR-12 Mental component summary (MCS) score - orthogonal method T-score")]
	public CqlCode VR_12_Mental_component_summary__MCS__score___orthogonal_method_T_score() => 
		__VR_12_Mental_component_summary__MCS__score___orthogonal_method_T_score.Value;

    /// <seealso cref="VR_12_Physical_component_summary__PCS__score___oblique_method_T_score"/>
	private CqlCode VR_12_Physical_component_summary__PCS__score___oblique_method_T_score_Value() => 
		new CqlCode("72025-0", "http://loinc.org", null, null);

    /// <seealso cref="VR_12_Physical_component_summary__PCS__score___oblique_method_T_score_Value"/>
    [CqlDeclaration("VR-12 Physical component summary (PCS) score - oblique method T-score")]
	public CqlCode VR_12_Physical_component_summary__PCS__score___oblique_method_T_score() => 
		__VR_12_Physical_component_summary__PCS__score___oblique_method_T_score.Value;

    /// <seealso cref="VR_12_Physical_component_summary__PCS__score___orthogonal_method_T_score"/>
	private CqlCode VR_12_Physical_component_summary__PCS__score___orthogonal_method_T_score_Value() => 
		new CqlCode("72027-6", "http://loinc.org", null, null);

    /// <seealso cref="VR_12_Physical_component_summary__PCS__score___orthogonal_method_T_score_Value"/>
    [CqlDeclaration("VR-12 Physical component summary (PCS) score - orthogonal method T-score")]
	public CqlCode VR_12_Physical_component_summary__PCS__score___orthogonal_method_T_score() => 
		__VR_12_Physical_component_summary__PCS__score___orthogonal_method_T_score.Value;

    /// <seealso cref="VR_36_Mental_component_summary__MCS__score___oblique_method_T_score"/>
	private CqlCode VR_36_Mental_component_summary__MCS__score___oblique_method_T_score_Value() => 
		new CqlCode("71990-6", "http://loinc.org", null, null);

    /// <seealso cref="VR_36_Mental_component_summary__MCS__score___oblique_method_T_score_Value"/>
    [CqlDeclaration("VR-36 Mental component summary (MCS) score - oblique method T-score")]
	public CqlCode VR_36_Mental_component_summary__MCS__score___oblique_method_T_score() => 
		__VR_36_Mental_component_summary__MCS__score___oblique_method_T_score.Value;

    /// <seealso cref="VR_36_Mental_component_summary__MCS__score___orthogonal_method_T_score"/>
	private CqlCode VR_36_Mental_component_summary__MCS__score___orthogonal_method_T_score_Value() => 
		new CqlCode("72008-6", "http://loinc.org", null, null);

    /// <seealso cref="VR_36_Mental_component_summary__MCS__score___orthogonal_method_T_score_Value"/>
    [CqlDeclaration("VR-36 Mental component summary (MCS) score - orthogonal method T-score")]
	public CqlCode VR_36_Mental_component_summary__MCS__score___orthogonal_method_T_score() => 
		__VR_36_Mental_component_summary__MCS__score___orthogonal_method_T_score.Value;

    /// <seealso cref="VR_36_Physical_component_summary__PCS__score___oblique_method_T_score"/>
	private CqlCode VR_36_Physical_component_summary__PCS__score___oblique_method_T_score_Value() => 
		new CqlCode("71989-8", "http://loinc.org", null, null);

    /// <seealso cref="VR_36_Physical_component_summary__PCS__score___oblique_method_T_score_Value"/>
    [CqlDeclaration("VR-36 Physical component summary (PCS) score - oblique method T-score")]
	public CqlCode VR_36_Physical_component_summary__PCS__score___oblique_method_T_score() => 
		__VR_36_Physical_component_summary__PCS__score___oblique_method_T_score.Value;

    /// <seealso cref="VR_36_Physical_component_summary__PCS__score___orthogonal_method_T_score"/>
	private CqlCode VR_36_Physical_component_summary__PCS__score___orthogonal_method_T_score_Value() => 
		new CqlCode("72007-8", "http://loinc.org", null, null);

    /// <seealso cref="VR_36_Physical_component_summary__PCS__score___orthogonal_method_T_score_Value"/>
    [CqlDeclaration("VR-36 Physical component summary (PCS) score - orthogonal method T-score")]
	public CqlCode VR_36_Physical_component_summary__PCS__score___orthogonal_method_T_score() => 
		__VR_36_Physical_component_summary__PCS__score___orthogonal_method_T_score.Value;

    /// <seealso cref="LOINC"/>
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

    /// <seealso cref="LOINC_Value"/>
    [CqlDeclaration("LOINC")]
	public CqlCode[] LOINC() => 
		__LOINC.Value;

    /// <seealso cref="SNOMEDCT"/>
	private CqlCode[] SNOMEDCT_Value()
	{
		CqlCode[] a_ = new CqlCode[]
		{
			new CqlCode("702956004", "http://snomed.info/sct", null, null),
		};

		return a_;
	}

    /// <seealso cref="SNOMEDCT_Value"/>
    [CqlDeclaration("SNOMEDCT")]
	public CqlCode[] SNOMEDCT() => 
		__SNOMEDCT.Value;

    /// <seealso cref="Measurement_Period"/>
	private CqlInterval<CqlDateTime> Measurement_Period_Value()
	{
		CqlDateTime a_ = context.Operators.DateTime(2025, 1, 1, 0, 0, 0, 0, default);
		CqlDateTime b_ = context.Operators.DateTime(2026, 1, 1, 0, 0, 0, 0, default);
		CqlInterval<CqlDateTime> c_ = context.Operators.Interval(a_, b_, true, false);
		object d_ = context.ResolveParameter("FunctionalStatusAssessmentsforHeartFailureFHIR-0.1.000", "Measurement Period", c_);

		return (CqlInterval<CqlDateTime>)d_;
	}

    /// <seealso cref="Measurement_Period_Value"/>
    [CqlDeclaration("Measurement Period")]
	public CqlInterval<CqlDateTime> Measurement_Period() => 
		__Measurement_Period.Value;

    /// <seealso cref="Patient"/>
	private Patient Patient_Value()
	{
		IEnumerable<Patient> a_ = context.Operators.RetrieveByValueSet<Patient>(null, null);
		Patient b_ = context.Operators.SingletonFrom<Patient>(a_);

		return b_;
	}

    /// <seealso cref="Patient_Value"/>
    [CqlDeclaration("Patient")]
	public Patient Patient() => 
		__Patient.Value;

    /// <seealso cref="SDE_Ethnicity"/>
	private Tuple_HPcCiDPXQfZTXIORThMLfTQDR SDE_Ethnicity_Value()
	{
		Tuple_HPcCiDPXQfZTXIORThMLfTQDR a_ = SupplementalDataElements_3_4_000.SDE_Ethnicity();

		return a_;
	}

    /// <seealso cref="SDE_Ethnicity_Value"/>
    [CqlDeclaration("SDE Ethnicity")]
	public Tuple_HPcCiDPXQfZTXIORThMLfTQDR SDE_Ethnicity() => 
		__SDE_Ethnicity.Value;

    /// <seealso cref="SDE_Payer"/>
	private IEnumerable<Tuple_GPRWMPNAYaJRiGDFSTLJOPeIJ> SDE_Payer_Value()
	{
		IEnumerable<Tuple_GPRWMPNAYaJRiGDFSTLJOPeIJ> a_ = SupplementalDataElements_3_4_000.SDE_Payer();

		return a_;
	}

    /// <seealso cref="SDE_Payer_Value"/>
    [CqlDeclaration("SDE Payer")]
	public IEnumerable<Tuple_GPRWMPNAYaJRiGDFSTLJOPeIJ> SDE_Payer() => 
		__SDE_Payer.Value;

    /// <seealso cref="SDE_Race"/>
	private Tuple_HPcCiDPXQfZTXIORThMLfTQDR SDE_Race_Value()
	{
		Tuple_HPcCiDPXQfZTXIORThMLfTQDR a_ = SupplementalDataElements_3_4_000.SDE_Race();

		return a_;
	}

    /// <seealso cref="SDE_Race_Value"/>
    [CqlDeclaration("SDE Race")]
	public Tuple_HPcCiDPXQfZTXIORThMLfTQDR SDE_Race() => 
		__SDE_Race.Value;

    /// <seealso cref="SDE_Sex"/>
	private CqlCode SDE_Sex_Value()
	{
		CqlCode a_ = SupplementalDataElements_3_4_000.SDE_Sex();

		return a_;
	}

    /// <seealso cref="SDE_Sex_Value"/>
    [CqlDeclaration("SDE Sex")]
	public CqlCode SDE_Sex() => 
		__SDE_Sex.Value;

    /// <seealso cref="Qualifying_Encounters"/>
	private IEnumerable<Encounter> Qualifying_Encounters_Value()
	{
		CqlValueSet a_ = this.Office_Visit();
		IEnumerable<Encounter> b_ = context.Operators.RetrieveByValueSet<Encounter>(a_, null);
		CqlValueSet c_ = this.Telephone_Visits();
		IEnumerable<Encounter> d_ = context.Operators.RetrieveByValueSet<Encounter>(c_, null);
		IEnumerable<Encounter> e_ = context.Operators.Union<Encounter>(b_, d_);
		CqlValueSet f_ = this.Online_Assessments();
		IEnumerable<Encounter> g_ = context.Operators.RetrieveByValueSet<Encounter>(f_, null);
		IEnumerable<Encounter> h_ = context.Operators.Union<Encounter>(e_, g_);
		IEnumerable<Encounter> i_ = Status_1_6_000.Finished_Encounter(h_);
		bool? j_(Encounter ValidEncounter)
		{
			CqlInterval<CqlDateTime> l_ = this.Measurement_Period();
			Period m_ = ValidEncounter?.Period;
			CqlInterval<CqlDateTime> n_ = FHIRHelpers_4_3_000.ToInterval(m_);
			CqlInterval<CqlDateTime> o_ = QICoreCommon_2_0_000.ToInterval((n_ as object));
			bool? p_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(l_, o_, "day");

			return p_;
		};
		IEnumerable<Encounter> k_ = context.Operators.Where<Encounter>(i_, j_);

		return k_;
	}

    /// <seealso cref="Qualifying_Encounters_Value"/>
    [CqlDeclaration("Qualifying Encounters")]
	public IEnumerable<Encounter> Qualifying_Encounters() => 
		__Qualifying_Encounters.Value;

    /// <seealso cref="Two_Outpatient_Encounters_during_Measurement_Period"/>
	private IEnumerable<Encounter> Two_Outpatient_Encounters_during_Measurement_Period_Value()
	{
		IEnumerable<Encounter> a_ = this.Qualifying_Encounters();
		IEnumerable<ValueTuple<Encounter, Encounter>> c_ = context.Operators.CrossJoin<Encounter, Encounter>(a_, a_);
		Tuple_DbNMMZBTISSRTNdiShceSFVih d_(ValueTuple<Encounter, Encounter> _valueTuple)
		{
			Tuple_DbNMMZBTISSRTNdiShceSFVih j_ = new Tuple_DbNMMZBTISSRTNdiShceSFVih
			{
				OfficeVisit1 = _valueTuple.Item1,
				OfficeVisit2 = _valueTuple.Item2,
			};

			return j_;
		};
		IEnumerable<Tuple_DbNMMZBTISSRTNdiShceSFVih> e_ = context.Operators.Select<ValueTuple<Encounter, Encounter>, Tuple_DbNMMZBTISSRTNdiShceSFVih>(c_, d_);
		bool? f_(Tuple_DbNMMZBTISSRTNdiShceSFVih tuple_dbnmmzbtissrtndishcesfvih)
		{
			Period k_ = tuple_dbnmmzbtissrtndishcesfvih.OfficeVisit2?.Period;
			CqlInterval<CqlDateTime> l_ = FHIRHelpers_4_3_000.ToInterval(k_);
			CqlInterval<CqlDateTime> m_ = QICoreCommon_2_0_000.ToInterval((l_ as object));
			CqlDateTime n_ = context.Operators.Start(m_);
			Period o_ = tuple_dbnmmzbtissrtndishcesfvih.OfficeVisit1?.Period;
			CqlInterval<CqlDateTime> p_ = FHIRHelpers_4_3_000.ToInterval(o_);
			CqlInterval<CqlDateTime> q_ = QICoreCommon_2_0_000.ToInterval((p_ as object));
			CqlDateTime r_ = context.Operators.End(q_);
			CqlQuantity s_ = context.Operators.Quantity(1m, "day");
			CqlDateTime t_ = context.Operators.Add(r_, s_);
			bool? u_ = context.Operators.SameOrAfter(n_, t_, "day");

			return u_;
		};
		IEnumerable<Tuple_DbNMMZBTISSRTNdiShceSFVih> g_ = context.Operators.Where<Tuple_DbNMMZBTISSRTNdiShceSFVih>(e_, f_);
		Encounter h_(Tuple_DbNMMZBTISSRTNdiShceSFVih tuple_dbnmmzbtissrtndishcesfvih) => 
			tuple_dbnmmzbtissrtndishcesfvih.OfficeVisit1;
		IEnumerable<Encounter> i_ = context.Operators.Select<Tuple_DbNMMZBTISSRTNdiShceSFVih, Encounter>(g_, h_);

		return i_;
	}

    /// <seealso cref="Two_Outpatient_Encounters_during_Measurement_Period_Value"/>
    [CqlDeclaration("Two Outpatient Encounters during Measurement Period")]
	public IEnumerable<Encounter> Two_Outpatient_Encounters_during_Measurement_Period() => 
		__Two_Outpatient_Encounters_during_Measurement_Period.Value;

    /// <seealso cref="Initial_Population"/>
	private bool? Initial_Population_Value()
	{
		Patient a_ = this.Patient();
		Date b_ = a_?.BirthDateElement;
		string c_ = b_?.Value;
		CqlDate d_ = context.Operators.Convert<CqlDate>(c_);
		CqlInterval<CqlDateTime> e_ = this.Measurement_Period();
		CqlDateTime f_ = context.Operators.Start(e_);
		CqlDate g_ = context.Operators.DateFrom(f_);
		int? h_ = context.Operators.CalculateAgeAt(d_, g_, "year");
		bool? i_ = context.Operators.GreaterOrEqual(h_, 18);
		CqlValueSet j_ = this.Heart_Failure();
		IEnumerable<Condition> k_ = context.Operators.RetrieveByValueSet<Condition>(j_, null);
		bool? l_(Condition HeartFailure)
		{
			CqlInterval<CqlDateTime> s_ = QICoreCommon_2_0_000.ToPrevalenceInterval(HeartFailure);
			CqlInterval<CqlDateTime> t_ = this.Measurement_Period();
			bool? u_ = context.Operators.OverlapsBefore(s_, t_, null);

			return u_;
		};
		IEnumerable<Condition> m_ = context.Operators.Where<Condition>(k_, l_);
		bool? n_ = context.Operators.Exists<Condition>(m_);
		bool? o_ = context.Operators.And(i_, n_);
		IEnumerable<Encounter> p_ = this.Two_Outpatient_Encounters_during_Measurement_Period();
		bool? q_ = context.Operators.Exists<Encounter>(p_);
		bool? r_ = context.Operators.And(o_, q_);

		return r_;
	}

    /// <seealso cref="Initial_Population_Value"/>
    [CqlDeclaration("Initial Population")]
	public bool? Initial_Population() => 
		__Initial_Population.Value;

    /// <seealso cref="Denominator"/>
	private bool? Denominator_Value()
	{
		bool? a_ = this.Initial_Population();

		return a_;
	}

    /// <seealso cref="Denominator_Value"/>
    [CqlDeclaration("Denominator")]
	public bool? Denominator() => 
		__Denominator.Value;

    /// <seealso cref="Denominator_Exclusions"/>
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

    /// <seealso cref="Denominator_Exclusions_Value"/>
    [CqlDeclaration("Denominator Exclusions")]
	public bool? Denominator_Exclusions() => 
		__Denominator_Exclusions.Value;

    /// <seealso cref="Date_PROMIS10_Total_Assessment_Completed"/>
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
		IEnumerable<ValueTuple<Observation, Observation>> i_ = context.Operators.CrossJoin<Observation, Observation>(d_, h_);
		Tuple_DDTAOdcFieSJbGgRLLZPYbGQb j_(ValueTuple<Observation, Observation> _valueTuple)
		{
			Tuple_DDTAOdcFieSJbGgRLLZPYbGQb p_ = new Tuple_DDTAOdcFieSJbGgRLLZPYbGQb
			{
				PROMIS10MentalScore = _valueTuple.Item1,
				PROMIS10PhysicalScore = _valueTuple.Item2,
			};

			return p_;
		};
		IEnumerable<Tuple_DDTAOdcFieSJbGgRLLZPYbGQb> k_ = context.Operators.Select<ValueTuple<Observation, Observation>, Tuple_DDTAOdcFieSJbGgRLLZPYbGQb>(i_, j_);
		bool? l_(Tuple_DDTAOdcFieSJbGgRLLZPYbGQb tuple_ddtaodcfiesjbggrllzpybgqb)
		{
			DataType q_ = tuple_ddtaodcfiesjbggrllzpybgqb.PROMIS10MentalScore?.Effective;
			object r_ = FHIRHelpers_4_3_000.ToValue(q_);
			CqlInterval<CqlDateTime> s_ = QICoreCommon_2_0_000.ToInterval(r_);
			CqlDateTime t_ = context.Operators.Start(s_);
			CqlDate u_ = context.Operators.DateFrom(t_);
			DataType v_ = tuple_ddtaodcfiesjbggrllzpybgqb.PROMIS10PhysicalScore?.Effective;
			object w_ = FHIRHelpers_4_3_000.ToValue(v_);
			CqlInterval<CqlDateTime> x_ = QICoreCommon_2_0_000.ToInterval(w_);
			CqlDateTime y_ = context.Operators.Start(x_);
			CqlDate z_ = context.Operators.DateFrom(y_);
			bool? aa_ = context.Operators.SameAs(u_, z_, "day");
			DataType ab_ = tuple_ddtaodcfiesjbggrllzpybgqb.PROMIS10MentalScore?.Value;
			object ac_ = FHIRHelpers_4_3_000.ToValue(ab_);
			bool? ad_ = context.Operators.Not((bool?)(ac_ is null));
			bool? ae_ = context.Operators.And(aa_, ad_);
			DataType af_ = tuple_ddtaodcfiesjbggrllzpybgqb.PROMIS10PhysicalScore?.Value;
			object ag_ = FHIRHelpers_4_3_000.ToValue(af_);
			bool? ah_ = context.Operators.Not((bool?)(ag_ is null));
			bool? ai_ = context.Operators.And(ae_, ah_);

			return ai_;
		};
		IEnumerable<Tuple_DDTAOdcFieSJbGgRLLZPYbGQb> m_ = context.Operators.Where<Tuple_DDTAOdcFieSJbGgRLLZPYbGQb>(k_, l_);
		CqlDate n_(Tuple_DDTAOdcFieSJbGgRLLZPYbGQb tuple_ddtaodcfiesjbggrllzpybgqb)
		{
			DataType aj_ = tuple_ddtaodcfiesjbggrllzpybgqb.PROMIS10MentalScore?.Effective;
			object ak_ = FHIRHelpers_4_3_000.ToValue(aj_);
			CqlInterval<CqlDateTime> al_ = QICoreCommon_2_0_000.ToInterval(ak_);
			CqlDateTime am_ = context.Operators.Start(al_);
			CqlDate an_ = context.Operators.DateFrom(am_);
			DataType ao_ = tuple_ddtaodcfiesjbggrllzpybgqb.PROMIS10PhysicalScore?.Effective;
			object ap_ = FHIRHelpers_4_3_000.ToValue(ao_);
			CqlInterval<CqlDateTime> aq_ = QICoreCommon_2_0_000.ToInterval(ap_);
			CqlDateTime ar_ = context.Operators.Start(aq_);
			CqlDate as_ = context.Operators.DateFrom(ar_);
			CqlDate[] at_ = new CqlDate[]
			{
				an_,
				as_,
			};
			CqlDate au_ = context.Operators.Max<CqlDate>((at_ as IEnumerable<CqlDate>));

			return au_;
		};
		IEnumerable<CqlDate> o_ = context.Operators.Select<Tuple_DDTAOdcFieSJbGgRLLZPYbGQb, CqlDate>(m_, n_);

		return o_;
	}

    /// <seealso cref="Date_PROMIS10_Total_Assessment_Completed_Value"/>
    [CqlDeclaration("Date PROMIS10 Total Assessment Completed")]
	public IEnumerable<CqlDate> Date_PROMIS10_Total_Assessment_Completed() => 
		__Date_PROMIS10_Total_Assessment_Completed.Value;

    /// <seealso cref="Has_Encounter_with_Initial_and_Follow_Up_PROMIS10_Assessments"/>
	private bool? Has_Encounter_with_Initial_and_Follow_Up_PROMIS10_Assessments_Value()
	{
		IEnumerable<Encounter> a_ = this.Qualifying_Encounters();
		IEnumerable<CqlDate> b_ = this.Date_PROMIS10_Total_Assessment_Completed();
		IEnumerable<ValueTuple<Encounter, CqlDate, CqlDate>> d_ = context.Operators.CrossJoin<Encounter, CqlDate, CqlDate>(a_, b_, b_);
		Tuple_DZhWGXhMBfAVMZfaSZbEKSOHj e_(ValueTuple<Encounter, CqlDate, CqlDate> _valueTuple)
		{
			Tuple_DZhWGXhMBfAVMZfaSZbEKSOHj l_ = new Tuple_DZhWGXhMBfAVMZfaSZbEKSOHj
			{
				ValidEncounters = _valueTuple.Item1,
				InitialPROMIS10Date = _valueTuple.Item2,
				FollowupPROMIS10Date = _valueTuple.Item3,
			};

			return l_;
		};
		IEnumerable<Tuple_DZhWGXhMBfAVMZfaSZbEKSOHj> f_ = context.Operators.Select<ValueTuple<Encounter, CqlDate, CqlDate>, Tuple_DZhWGXhMBfAVMZfaSZbEKSOHj>(d_, e_);
		bool? g_(Tuple_DZhWGXhMBfAVMZfaSZbEKSOHj tuple_dzhwgxhmbfavmzfaszbeksohj)
		{
			Period m_ = tuple_dzhwgxhmbfavmzfaszbeksohj.ValidEncounters?.Period;
			CqlInterval<CqlDateTime> n_ = FHIRHelpers_4_3_000.ToInterval(m_);
			CqlInterval<CqlDateTime> o_ = QICoreCommon_2_0_000.ToInterval((n_ as object));
			CqlDateTime p_ = context.Operators.End(o_);
			CqlInterval<CqlDateTime> q_ = this.Measurement_Period();
			CqlDateTime r_ = context.Operators.End(q_);
			CqlQuantity s_ = context.Operators.Quantity(180m, "days");
			CqlDateTime t_ = context.Operators.Subtract(r_, s_);
			bool? u_ = context.Operators.SameOrBefore(p_, t_, "day");
			CqlDateTime v_ = context.Operators.ConvertDateToDateTime(tuple_dzhwgxhmbfavmzfaszbeksohj.InitialPROMIS10Date);
			CqlInterval<CqlDateTime> x_ = FHIRHelpers_4_3_000.ToInterval(m_);
			CqlInterval<CqlDateTime> y_ = QICoreCommon_2_0_000.ToInterval((x_ as object));
			CqlDateTime z_ = context.Operators.End(y_);
			CqlQuantity aa_ = context.Operators.Quantity(14m, "days");
			CqlDateTime ab_ = context.Operators.Subtract(z_, aa_);
			CqlInterval<CqlDateTime> ad_ = FHIRHelpers_4_3_000.ToInterval(m_);
			CqlInterval<CqlDateTime> ae_ = QICoreCommon_2_0_000.ToInterval((ad_ as object));
			CqlDateTime af_ = context.Operators.End(ae_);
			CqlInterval<CqlDateTime> ag_ = context.Operators.Interval(ab_, af_, true, true);
			bool? ah_ = context.Operators.In<CqlDateTime>(v_, ag_, "day");
			CqlInterval<CqlDateTime> aj_ = FHIRHelpers_4_3_000.ToInterval(m_);
			CqlInterval<CqlDateTime> ak_ = QICoreCommon_2_0_000.ToInterval((aj_ as object));
			CqlDateTime al_ = context.Operators.End(ak_);
			bool? am_ = context.Operators.Not((bool?)(al_ is null));
			bool? an_ = context.Operators.And(ah_, am_);
			bool? ao_ = context.Operators.And(u_, an_);
			CqlDateTime ap_ = context.Operators.ConvertDateToDateTime(tuple_dzhwgxhmbfavmzfaszbeksohj.FollowupPROMIS10Date);
			CqlDate aq_ = context.Operators.DateFrom(ap_);
			CqlDate as_ = context.Operators.DateFrom(v_);
			CqlQuantity at_ = context.Operators.Quantity(30m, "days");
			CqlDate au_ = context.Operators.Add(as_, at_);
			CqlDate aw_ = context.Operators.DateFrom(v_);
			CqlDate ay_ = context.Operators.Add(aw_, s_);
			CqlInterval<CqlDate> az_ = context.Operators.Interval(au_, ay_, true, true);
			bool? ba_ = context.Operators.In<CqlDate>(aq_, az_, "day");
			bool? bb_ = context.Operators.And(ao_, ba_);

			return bb_;
		};
		IEnumerable<Tuple_DZhWGXhMBfAVMZfaSZbEKSOHj> h_ = context.Operators.Where<Tuple_DZhWGXhMBfAVMZfaSZbEKSOHj>(f_, g_);
		Encounter i_(Tuple_DZhWGXhMBfAVMZfaSZbEKSOHj tuple_dzhwgxhmbfavmzfaszbeksohj) => 
			tuple_dzhwgxhmbfavmzfaszbeksohj.ValidEncounters;
		IEnumerable<Encounter> j_ = context.Operators.Select<Tuple_DZhWGXhMBfAVMZfaSZbEKSOHj, Encounter>(h_, i_);
		bool? k_ = context.Operators.Exists<Encounter>(j_);

		return k_;
	}

    /// <seealso cref="Has_Encounter_with_Initial_and_Follow_Up_PROMIS10_Assessments_Value"/>
    [CqlDeclaration("Has Encounter with Initial and Follow Up PROMIS10 Assessments")]
	public bool? Has_Encounter_with_Initial_and_Follow_Up_PROMIS10_Assessments() => 
		__Has_Encounter_with_Initial_and_Follow_Up_PROMIS10_Assessments.Value;

    /// <seealso cref="Date_PROMIS29_Total_Assessment_Completed"/>
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
		IEnumerable<ValueTuple<Observation, Observation, Observation, Observation, Observation, Observation, Observation>> ac_ = context.Operators.CrossJoin<Observation, Observation, Observation, Observation, Observation, Observation, Observation>(d_, h_, l_, p_, t_, x_, ab_);
		Tuple_CbgPSARVWRSeWLgLehiNjaNiM ad_(ValueTuple<Observation, Observation, Observation, Observation, Observation, Observation, Observation> _valueTuple)
		{
			Tuple_CbgPSARVWRSeWLgLehiNjaNiM aj_ = new Tuple_CbgPSARVWRSeWLgLehiNjaNiM
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
		IEnumerable<Tuple_CbgPSARVWRSeWLgLehiNjaNiM> ae_ = context.Operators.Select<ValueTuple<Observation, Observation, Observation, Observation, Observation, Observation, Observation>, Tuple_CbgPSARVWRSeWLgLehiNjaNiM>(ac_, ad_);
		bool? af_(Tuple_CbgPSARVWRSeWLgLehiNjaNiM tuple_cbgpsarvwrsewlglehinjanim)
		{
			DataType ak_ = tuple_cbgpsarvwrsewlglehinjanim.Promis29Sleep?.Effective;
			object al_ = FHIRHelpers_4_3_000.ToValue(ak_);
			CqlInterval<CqlDateTime> am_ = QICoreCommon_2_0_000.ToInterval(al_);
			CqlDateTime an_ = context.Operators.Start(am_);
			CqlDate ao_ = context.Operators.DateFrom(an_);
			DataType ap_ = tuple_cbgpsarvwrsewlglehinjanim.Promis29SocialRoles?.Effective;
			object aq_ = FHIRHelpers_4_3_000.ToValue(ap_);
			CqlInterval<CqlDateTime> ar_ = QICoreCommon_2_0_000.ToInterval(aq_);
			CqlDateTime as_ = context.Operators.Start(ar_);
			CqlDate at_ = context.Operators.DateFrom(as_);
			bool? au_ = context.Operators.SameAs(ao_, at_, "day");
			DataType av_ = tuple_cbgpsarvwrsewlglehinjanim.Promis29SocialRoles?.Value;
			object aw_ = FHIRHelpers_4_3_000.ToValue(av_);
			bool? ax_ = context.Operators.Not((bool?)(aw_ is null));
			bool? ay_ = context.Operators.And(au_, ax_);
			object ba_ = FHIRHelpers_4_3_000.ToValue(ak_);
			CqlInterval<CqlDateTime> bb_ = QICoreCommon_2_0_000.ToInterval(ba_);
			CqlDateTime bc_ = context.Operators.Start(bb_);
			CqlDate bd_ = context.Operators.DateFrom(bc_);
			DataType be_ = tuple_cbgpsarvwrsewlglehinjanim.Promis29Physical?.Effective;
			object bf_ = FHIRHelpers_4_3_000.ToValue(be_);
			CqlInterval<CqlDateTime> bg_ = QICoreCommon_2_0_000.ToInterval(bf_);
			CqlDateTime bh_ = context.Operators.Start(bg_);
			CqlDate bi_ = context.Operators.DateFrom(bh_);
			bool? bj_ = context.Operators.SameAs(bd_, bi_, "day");
			bool? bk_ = context.Operators.And(ay_, bj_);
			DataType bl_ = tuple_cbgpsarvwrsewlglehinjanim.Promis29Physical?.Value;
			object bm_ = FHIRHelpers_4_3_000.ToValue(bl_);
			bool? bn_ = context.Operators.Not((bool?)(bm_ is null));
			bool? bo_ = context.Operators.And(bk_, bn_);
			object bq_ = FHIRHelpers_4_3_000.ToValue(ak_);
			CqlInterval<CqlDateTime> br_ = QICoreCommon_2_0_000.ToInterval(bq_);
			CqlDateTime bs_ = context.Operators.Start(br_);
			CqlDate bt_ = context.Operators.DateFrom(bs_);
			DataType bu_ = tuple_cbgpsarvwrsewlglehinjanim.Promis29Pain?.Effective;
			object bv_ = FHIRHelpers_4_3_000.ToValue(bu_);
			CqlInterval<CqlDateTime> bw_ = QICoreCommon_2_0_000.ToInterval(bv_);
			CqlDateTime bx_ = context.Operators.Start(bw_);
			CqlDate by_ = context.Operators.DateFrom(bx_);
			bool? bz_ = context.Operators.SameAs(bt_, by_, "day");
			bool? ca_ = context.Operators.And(bo_, bz_);
			DataType cb_ = tuple_cbgpsarvwrsewlglehinjanim.Promis29Pain?.Value;
			object cc_ = FHIRHelpers_4_3_000.ToValue(cb_);
			bool? cd_ = context.Operators.Not((bool?)(cc_ is null));
			bool? ce_ = context.Operators.And(ca_, cd_);
			object cg_ = FHIRHelpers_4_3_000.ToValue(ak_);
			CqlInterval<CqlDateTime> ch_ = QICoreCommon_2_0_000.ToInterval(cg_);
			CqlDateTime ci_ = context.Operators.Start(ch_);
			CqlDate cj_ = context.Operators.DateFrom(ci_);
			DataType ck_ = tuple_cbgpsarvwrsewlglehinjanim.Promis29Fatigue?.Effective;
			object cl_ = FHIRHelpers_4_3_000.ToValue(ck_);
			CqlInterval<CqlDateTime> cm_ = QICoreCommon_2_0_000.ToInterval(cl_);
			CqlDateTime cn_ = context.Operators.Start(cm_);
			CqlDate co_ = context.Operators.DateFrom(cn_);
			bool? cp_ = context.Operators.SameAs(cj_, co_, "day");
			bool? cq_ = context.Operators.And(ce_, cp_);
			DataType cr_ = tuple_cbgpsarvwrsewlglehinjanim.Promis29Fatigue?.Value;
			object cs_ = FHIRHelpers_4_3_000.ToValue(cr_);
			bool? ct_ = context.Operators.Not((bool?)(cs_ is null));
			bool? cu_ = context.Operators.And(cq_, ct_);
			object cw_ = FHIRHelpers_4_3_000.ToValue(ak_);
			CqlInterval<CqlDateTime> cx_ = QICoreCommon_2_0_000.ToInterval(cw_);
			CqlDateTime cy_ = context.Operators.Start(cx_);
			CqlDate cz_ = context.Operators.DateFrom(cy_);
			DataType da_ = tuple_cbgpsarvwrsewlglehinjanim.Promis29Depression?.Effective;
			object db_ = FHIRHelpers_4_3_000.ToValue(da_);
			CqlInterval<CqlDateTime> dc_ = QICoreCommon_2_0_000.ToInterval(db_);
			CqlDateTime dd_ = context.Operators.Start(dc_);
			CqlDate de_ = context.Operators.DateFrom(dd_);
			bool? df_ = context.Operators.SameAs(cz_, de_, "day");
			bool? dg_ = context.Operators.And(cu_, df_);
			DataType dh_ = tuple_cbgpsarvwrsewlglehinjanim.Promis29Depression?.Value;
			object di_ = FHIRHelpers_4_3_000.ToValue(dh_);
			bool? dj_ = context.Operators.Not((bool?)(di_ is null));
			bool? dk_ = context.Operators.And(dg_, dj_);
			object dm_ = FHIRHelpers_4_3_000.ToValue(ak_);
			CqlInterval<CqlDateTime> dn_ = QICoreCommon_2_0_000.ToInterval(dm_);
			CqlDateTime do_ = context.Operators.Start(dn_);
			CqlDate dp_ = context.Operators.DateFrom(do_);
			DataType dq_ = tuple_cbgpsarvwrsewlglehinjanim.Promis29Anxiety?.Effective;
			object dr_ = FHIRHelpers_4_3_000.ToValue(dq_);
			CqlInterval<CqlDateTime> ds_ = QICoreCommon_2_0_000.ToInterval(dr_);
			CqlDateTime dt_ = context.Operators.Start(ds_);
			CqlDate du_ = context.Operators.DateFrom(dt_);
			bool? dv_ = context.Operators.SameAs(dp_, du_, "day");
			bool? dw_ = context.Operators.And(dk_, dv_);
			DataType dx_ = tuple_cbgpsarvwrsewlglehinjanim.Promis29Anxiety?.Value;
			object dy_ = FHIRHelpers_4_3_000.ToValue(dx_);
			bool? dz_ = context.Operators.Not((bool?)(dy_ is null));
			bool? ea_ = context.Operators.And(dw_, dz_);
			DataType eb_ = tuple_cbgpsarvwrsewlglehinjanim.Promis29Sleep?.Value;
			object ec_ = FHIRHelpers_4_3_000.ToValue(eb_);
			bool? ed_ = context.Operators.Not((bool?)(ec_ is null));
			bool? ee_ = context.Operators.And(ea_, ed_);

			return ee_;
		};
		IEnumerable<Tuple_CbgPSARVWRSeWLgLehiNjaNiM> ag_ = context.Operators.Where<Tuple_CbgPSARVWRSeWLgLehiNjaNiM>(ae_, af_);
		CqlDate ah_(Tuple_CbgPSARVWRSeWLgLehiNjaNiM tuple_cbgpsarvwrsewlglehinjanim)
		{
			DataType ef_ = tuple_cbgpsarvwrsewlglehinjanim.Promis29Sleep?.Effective;
			object eg_ = FHIRHelpers_4_3_000.ToValue(ef_);
			CqlInterval<CqlDateTime> eh_ = QICoreCommon_2_0_000.ToInterval(eg_);
			CqlDateTime ei_ = context.Operators.Start(eh_);
			CqlDate ej_ = context.Operators.DateFrom(ei_);
			DataType ek_ = tuple_cbgpsarvwrsewlglehinjanim.Promis29SocialRoles?.Effective;
			object el_ = FHIRHelpers_4_3_000.ToValue(ek_);
			CqlInterval<CqlDateTime> em_ = QICoreCommon_2_0_000.ToInterval(el_);
			CqlDateTime en_ = context.Operators.Start(em_);
			CqlDate eo_ = context.Operators.DateFrom(en_);
			DataType ep_ = tuple_cbgpsarvwrsewlglehinjanim.Promis29Physical?.Effective;
			object eq_ = FHIRHelpers_4_3_000.ToValue(ep_);
			CqlInterval<CqlDateTime> er_ = QICoreCommon_2_0_000.ToInterval(eq_);
			CqlDateTime es_ = context.Operators.Start(er_);
			CqlDate et_ = context.Operators.DateFrom(es_);
			DataType eu_ = tuple_cbgpsarvwrsewlglehinjanim.Promis29Pain?.Effective;
			object ev_ = FHIRHelpers_4_3_000.ToValue(eu_);
			CqlInterval<CqlDateTime> ew_ = QICoreCommon_2_0_000.ToInterval(ev_);
			CqlDateTime ex_ = context.Operators.Start(ew_);
			CqlDate ey_ = context.Operators.DateFrom(ex_);
			DataType ez_ = tuple_cbgpsarvwrsewlglehinjanim.Promis29Fatigue?.Effective;
			object fa_ = FHIRHelpers_4_3_000.ToValue(ez_);
			CqlInterval<CqlDateTime> fb_ = QICoreCommon_2_0_000.ToInterval(fa_);
			CqlDateTime fc_ = context.Operators.Start(fb_);
			CqlDate fd_ = context.Operators.DateFrom(fc_);
			DataType fe_ = tuple_cbgpsarvwrsewlglehinjanim.Promis29Depression?.Effective;
			object ff_ = FHIRHelpers_4_3_000.ToValue(fe_);
			CqlInterval<CqlDateTime> fg_ = QICoreCommon_2_0_000.ToInterval(ff_);
			CqlDateTime fh_ = context.Operators.Start(fg_);
			CqlDate fi_ = context.Operators.DateFrom(fh_);
			DataType fj_ = tuple_cbgpsarvwrsewlglehinjanim.Promis29Anxiety?.Effective;
			object fk_ = FHIRHelpers_4_3_000.ToValue(fj_);
			CqlInterval<CqlDateTime> fl_ = QICoreCommon_2_0_000.ToInterval(fk_);
			CqlDateTime fm_ = context.Operators.Start(fl_);
			CqlDate fn_ = context.Operators.DateFrom(fm_);
			CqlDate[] fo_ = new CqlDate[]
			{
				ej_,
				eo_,
				et_,
				ey_,
				fd_,
				fi_,
				fn_,
			};
			CqlDate fp_ = context.Operators.Max<CqlDate>((fo_ as IEnumerable<CqlDate>));

			return fp_;
		};
		IEnumerable<CqlDate> ai_ = context.Operators.Select<Tuple_CbgPSARVWRSeWLgLehiNjaNiM, CqlDate>(ag_, ah_);

		return ai_;
	}

    /// <seealso cref="Date_PROMIS29_Total_Assessment_Completed_Value"/>
    [CqlDeclaration("Date PROMIS29 Total Assessment Completed")]
	public IEnumerable<CqlDate> Date_PROMIS29_Total_Assessment_Completed() => 
		__Date_PROMIS29_Total_Assessment_Completed.Value;

    /// <seealso cref="Has_Encounter_with_Initial_and_Follow_Up_PROMIS29_Assessments"/>
	private bool? Has_Encounter_with_Initial_and_Follow_Up_PROMIS29_Assessments_Value()
	{
		IEnumerable<Encounter> a_ = this.Qualifying_Encounters();
		IEnumerable<CqlDate> b_ = this.Date_PROMIS29_Total_Assessment_Completed();
		IEnumerable<ValueTuple<Encounter, CqlDate, CqlDate>> d_ = context.Operators.CrossJoin<Encounter, CqlDate, CqlDate>(a_, b_, b_);
		Tuple_KMPNTXjUhKPBcWGfTQIGieaO e_(ValueTuple<Encounter, CqlDate, CqlDate> _valueTuple)
		{
			Tuple_KMPNTXjUhKPBcWGfTQIGieaO l_ = new Tuple_KMPNTXjUhKPBcWGfTQIGieaO
			{
				ValidEncounters = _valueTuple.Item1,
				InitialPROMIS29Date = _valueTuple.Item2,
				FollowupPROMIS29Date = _valueTuple.Item3,
			};

			return l_;
		};
		IEnumerable<Tuple_KMPNTXjUhKPBcWGfTQIGieaO> f_ = context.Operators.Select<ValueTuple<Encounter, CqlDate, CqlDate>, Tuple_KMPNTXjUhKPBcWGfTQIGieaO>(d_, e_);
		bool? g_(Tuple_KMPNTXjUhKPBcWGfTQIGieaO tuple_kmpntxjuhkpbcwgftqigieao)
		{
			Period m_ = tuple_kmpntxjuhkpbcwgftqigieao.ValidEncounters?.Period;
			CqlInterval<CqlDateTime> n_ = FHIRHelpers_4_3_000.ToInterval(m_);
			CqlInterval<CqlDateTime> o_ = QICoreCommon_2_0_000.ToInterval((n_ as object));
			CqlDateTime p_ = context.Operators.End(o_);
			CqlInterval<CqlDateTime> q_ = this.Measurement_Period();
			CqlDateTime r_ = context.Operators.End(q_);
			CqlQuantity s_ = context.Operators.Quantity(180m, "days");
			CqlDateTime t_ = context.Operators.Subtract(r_, s_);
			bool? u_ = context.Operators.SameOrBefore(p_, t_, "day");
			CqlDateTime v_ = context.Operators.ConvertDateToDateTime(tuple_kmpntxjuhkpbcwgftqigieao.InitialPROMIS29Date);
			CqlInterval<CqlDateTime> x_ = FHIRHelpers_4_3_000.ToInterval(m_);
			CqlInterval<CqlDateTime> y_ = QICoreCommon_2_0_000.ToInterval((x_ as object));
			CqlDateTime z_ = context.Operators.End(y_);
			CqlQuantity aa_ = context.Operators.Quantity(14m, "days");
			CqlDateTime ab_ = context.Operators.Subtract(z_, aa_);
			CqlInterval<CqlDateTime> ad_ = FHIRHelpers_4_3_000.ToInterval(m_);
			CqlInterval<CqlDateTime> ae_ = QICoreCommon_2_0_000.ToInterval((ad_ as object));
			CqlDateTime af_ = context.Operators.End(ae_);
			CqlInterval<CqlDateTime> ag_ = context.Operators.Interval(ab_, af_, true, true);
			bool? ah_ = context.Operators.In<CqlDateTime>(v_, ag_, "day");
			CqlInterval<CqlDateTime> aj_ = FHIRHelpers_4_3_000.ToInterval(m_);
			CqlInterval<CqlDateTime> ak_ = QICoreCommon_2_0_000.ToInterval((aj_ as object));
			CqlDateTime al_ = context.Operators.End(ak_);
			bool? am_ = context.Operators.Not((bool?)(al_ is null));
			bool? an_ = context.Operators.And(ah_, am_);
			bool? ao_ = context.Operators.And(u_, an_);
			CqlDateTime ap_ = context.Operators.ConvertDateToDateTime(tuple_kmpntxjuhkpbcwgftqigieao.FollowupPROMIS29Date);
			CqlDate aq_ = context.Operators.DateFrom(ap_);
			CqlDate as_ = context.Operators.DateFrom(v_);
			CqlQuantity at_ = context.Operators.Quantity(30m, "days");
			CqlDate au_ = context.Operators.Add(as_, at_);
			CqlDate aw_ = context.Operators.DateFrom(v_);
			CqlDate ay_ = context.Operators.Add(aw_, s_);
			CqlInterval<CqlDate> az_ = context.Operators.Interval(au_, ay_, true, true);
			bool? ba_ = context.Operators.In<CqlDate>(aq_, az_, "day");
			bool? bb_ = context.Operators.And(ao_, ba_);

			return bb_;
		};
		IEnumerable<Tuple_KMPNTXjUhKPBcWGfTQIGieaO> h_ = context.Operators.Where<Tuple_KMPNTXjUhKPBcWGfTQIGieaO>(f_, g_);
		Encounter i_(Tuple_KMPNTXjUhKPBcWGfTQIGieaO tuple_kmpntxjuhkpbcwgftqigieao) => 
			tuple_kmpntxjuhkpbcwgftqigieao.ValidEncounters;
		IEnumerable<Encounter> j_ = context.Operators.Select<Tuple_KMPNTXjUhKPBcWGfTQIGieaO, Encounter>(h_, i_);
		bool? k_ = context.Operators.Exists<Encounter>(j_);

		return k_;
	}

    /// <seealso cref="Has_Encounter_with_Initial_and_Follow_Up_PROMIS29_Assessments_Value"/>
    [CqlDeclaration("Has Encounter with Initial and Follow Up PROMIS29 Assessments")]
	public bool? Has_Encounter_with_Initial_and_Follow_Up_PROMIS29_Assessments() => 
		__Has_Encounter_with_Initial_and_Follow_Up_PROMIS29_Assessments.Value;

    /// <seealso cref="Date_VR12_Oblique_Total_Assessment_Completed"/>
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
		IEnumerable<ValueTuple<Observation, Observation>> i_ = context.Operators.CrossJoin<Observation, Observation>(d_, h_);
		Tuple_GAdRFKRaHUUGJcVHWQWRUjhRH j_(ValueTuple<Observation, Observation> _valueTuple)
		{
			Tuple_GAdRFKRaHUUGJcVHWQWRUjhRH p_ = new Tuple_GAdRFKRaHUUGJcVHWQWRUjhRH
			{
				VR12MentalAssessment = _valueTuple.Item1,
				VR12PhysicalAssessment = _valueTuple.Item2,
			};

			return p_;
		};
		IEnumerable<Tuple_GAdRFKRaHUUGJcVHWQWRUjhRH> k_ = context.Operators.Select<ValueTuple<Observation, Observation>, Tuple_GAdRFKRaHUUGJcVHWQWRUjhRH>(i_, j_);
		bool? l_(Tuple_GAdRFKRaHUUGJcVHWQWRUjhRH tuple_gadrfkrahuugjcvhwqwrujhrh)
		{
			DataType q_ = tuple_gadrfkrahuugjcvhwqwrujhrh.VR12MentalAssessment?.Effective;
			object r_ = FHIRHelpers_4_3_000.ToValue(q_);
			CqlInterval<CqlDateTime> s_ = QICoreCommon_2_0_000.ToInterval(r_);
			CqlDateTime t_ = context.Operators.Start(s_);
			CqlDate u_ = context.Operators.DateFrom(t_);
			DataType v_ = tuple_gadrfkrahuugjcvhwqwrujhrh.VR12PhysicalAssessment?.Effective;
			object w_ = FHIRHelpers_4_3_000.ToValue(v_);
			CqlInterval<CqlDateTime> x_ = QICoreCommon_2_0_000.ToInterval(w_);
			CqlDateTime y_ = context.Operators.Start(x_);
			CqlDate z_ = context.Operators.DateFrom(y_);
			bool? aa_ = context.Operators.SameAs(u_, z_, "day");
			DataType ab_ = tuple_gadrfkrahuugjcvhwqwrujhrh.VR12MentalAssessment?.Value;
			object ac_ = FHIRHelpers_4_3_000.ToValue(ab_);
			bool? ad_ = context.Operators.Not((bool?)(ac_ is null));
			bool? ae_ = context.Operators.And(aa_, ad_);
			DataType af_ = tuple_gadrfkrahuugjcvhwqwrujhrh.VR12PhysicalAssessment?.Value;
			object ag_ = FHIRHelpers_4_3_000.ToValue(af_);
			bool? ah_ = context.Operators.Not((bool?)(ag_ is null));
			bool? ai_ = context.Operators.And(ae_, ah_);

			return ai_;
		};
		IEnumerable<Tuple_GAdRFKRaHUUGJcVHWQWRUjhRH> m_ = context.Operators.Where<Tuple_GAdRFKRaHUUGJcVHWQWRUjhRH>(k_, l_);
		CqlDate n_(Tuple_GAdRFKRaHUUGJcVHWQWRUjhRH tuple_gadrfkrahuugjcvhwqwrujhrh)
		{
			DataType aj_ = tuple_gadrfkrahuugjcvhwqwrujhrh.VR12MentalAssessment?.Effective;
			object ak_ = FHIRHelpers_4_3_000.ToValue(aj_);
			CqlInterval<CqlDateTime> al_ = QICoreCommon_2_0_000.ToInterval(ak_);
			CqlDateTime am_ = context.Operators.Start(al_);
			CqlDate an_ = context.Operators.DateFrom(am_);
			DataType ao_ = tuple_gadrfkrahuugjcvhwqwrujhrh.VR12PhysicalAssessment?.Effective;
			object ap_ = FHIRHelpers_4_3_000.ToValue(ao_);
			CqlInterval<CqlDateTime> aq_ = QICoreCommon_2_0_000.ToInterval(ap_);
			CqlDateTime ar_ = context.Operators.Start(aq_);
			CqlDate as_ = context.Operators.DateFrom(ar_);
			CqlDate[] at_ = new CqlDate[]
			{
				an_,
				as_,
			};
			CqlDate au_ = context.Operators.Max<CqlDate>((at_ as IEnumerable<CqlDate>));

			return au_;
		};
		IEnumerable<CqlDate> o_ = context.Operators.Select<Tuple_GAdRFKRaHUUGJcVHWQWRUjhRH, CqlDate>(m_, n_);

		return o_;
	}

    /// <seealso cref="Date_VR12_Oblique_Total_Assessment_Completed_Value"/>
    [CqlDeclaration("Date VR12 Oblique Total Assessment Completed")]
	public IEnumerable<CqlDate> Date_VR12_Oblique_Total_Assessment_Completed() => 
		__Date_VR12_Oblique_Total_Assessment_Completed.Value;

    /// <seealso cref="Has_Encounter_with_Initial_and_Follow_Up_VR12_Oblique_Assessments"/>
	private bool? Has_Encounter_with_Initial_and_Follow_Up_VR12_Oblique_Assessments_Value()
	{
		IEnumerable<Encounter> a_ = this.Qualifying_Encounters();
		IEnumerable<CqlDate> b_ = this.Date_VR12_Oblique_Total_Assessment_Completed();
		IEnumerable<ValueTuple<Encounter, CqlDate, CqlDate>> d_ = context.Operators.CrossJoin<Encounter, CqlDate, CqlDate>(a_, b_, b_);
		Tuple_FPPKTdIagiEKHPTNSBAcPSWH e_(ValueTuple<Encounter, CqlDate, CqlDate> _valueTuple)
		{
			Tuple_FPPKTdIagiEKHPTNSBAcPSWH l_ = new Tuple_FPPKTdIagiEKHPTNSBAcPSWH
			{
				ValidEncounters = _valueTuple.Item1,
				InitialVR12ObliqueDate = _valueTuple.Item2,
				FollowupVR12ObliqueDate = _valueTuple.Item3,
			};

			return l_;
		};
		IEnumerable<Tuple_FPPKTdIagiEKHPTNSBAcPSWH> f_ = context.Operators.Select<ValueTuple<Encounter, CqlDate, CqlDate>, Tuple_FPPKTdIagiEKHPTNSBAcPSWH>(d_, e_);
		bool? g_(Tuple_FPPKTdIagiEKHPTNSBAcPSWH tuple_fppktdiagiekhptnsbacpswh)
		{
			Period m_ = tuple_fppktdiagiekhptnsbacpswh.ValidEncounters?.Period;
			CqlInterval<CqlDateTime> n_ = FHIRHelpers_4_3_000.ToInterval(m_);
			CqlInterval<CqlDateTime> o_ = QICoreCommon_2_0_000.ToInterval((n_ as object));
			CqlDateTime p_ = context.Operators.End(o_);
			CqlInterval<CqlDateTime> q_ = this.Measurement_Period();
			CqlDateTime r_ = context.Operators.End(q_);
			CqlQuantity s_ = context.Operators.Quantity(180m, "days");
			CqlDateTime t_ = context.Operators.Subtract(r_, s_);
			bool? u_ = context.Operators.SameOrBefore(p_, t_, "day");
			CqlDateTime v_ = context.Operators.ConvertDateToDateTime(tuple_fppktdiagiekhptnsbacpswh.InitialVR12ObliqueDate);
			CqlInterval<CqlDateTime> x_ = FHIRHelpers_4_3_000.ToInterval(m_);
			CqlInterval<CqlDateTime> y_ = QICoreCommon_2_0_000.ToInterval((x_ as object));
			CqlDateTime z_ = context.Operators.End(y_);
			CqlQuantity aa_ = context.Operators.Quantity(14m, "days");
			CqlDateTime ab_ = context.Operators.Subtract(z_, aa_);
			CqlInterval<CqlDateTime> ad_ = FHIRHelpers_4_3_000.ToInterval(m_);
			CqlInterval<CqlDateTime> ae_ = QICoreCommon_2_0_000.ToInterval((ad_ as object));
			CqlDateTime af_ = context.Operators.End(ae_);
			CqlInterval<CqlDateTime> ag_ = context.Operators.Interval(ab_, af_, true, true);
			bool? ah_ = context.Operators.In<CqlDateTime>(v_, ag_, "day");
			CqlInterval<CqlDateTime> aj_ = FHIRHelpers_4_3_000.ToInterval(m_);
			CqlInterval<CqlDateTime> ak_ = QICoreCommon_2_0_000.ToInterval((aj_ as object));
			CqlDateTime al_ = context.Operators.End(ak_);
			bool? am_ = context.Operators.Not((bool?)(al_ is null));
			bool? an_ = context.Operators.And(ah_, am_);
			bool? ao_ = context.Operators.And(u_, an_);
			CqlDateTime ap_ = context.Operators.ConvertDateToDateTime(tuple_fppktdiagiekhptnsbacpswh.FollowupVR12ObliqueDate);
			CqlDate aq_ = context.Operators.DateFrom(ap_);
			CqlDate as_ = context.Operators.DateFrom(v_);
			CqlQuantity at_ = context.Operators.Quantity(30m, "days");
			CqlDate au_ = context.Operators.Add(as_, at_);
			CqlDate aw_ = context.Operators.DateFrom(v_);
			CqlDate ay_ = context.Operators.Add(aw_, s_);
			CqlInterval<CqlDate> az_ = context.Operators.Interval(au_, ay_, true, true);
			bool? ba_ = context.Operators.In<CqlDate>(aq_, az_, "day");
			bool? bb_ = context.Operators.And(ao_, ba_);

			return bb_;
		};
		IEnumerable<Tuple_FPPKTdIagiEKHPTNSBAcPSWH> h_ = context.Operators.Where<Tuple_FPPKTdIagiEKHPTNSBAcPSWH>(f_, g_);
		Encounter i_(Tuple_FPPKTdIagiEKHPTNSBAcPSWH tuple_fppktdiagiekhptnsbacpswh) => 
			tuple_fppktdiagiekhptnsbacpswh.ValidEncounters;
		IEnumerable<Encounter> j_ = context.Operators.Select<Tuple_FPPKTdIagiEKHPTNSBAcPSWH, Encounter>(h_, i_);
		bool? k_ = context.Operators.Exists<Encounter>(j_);

		return k_;
	}

    /// <seealso cref="Has_Encounter_with_Initial_and_Follow_Up_VR12_Oblique_Assessments_Value"/>
    [CqlDeclaration("Has Encounter with Initial and Follow Up VR12 Oblique Assessments")]
	public bool? Has_Encounter_with_Initial_and_Follow_Up_VR12_Oblique_Assessments() => 
		__Has_Encounter_with_Initial_and_Follow_Up_VR12_Oblique_Assessments.Value;

    /// <seealso cref="Date_VR12_Orthogonal_Total_Assessment_Completed"/>
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
		IEnumerable<ValueTuple<Observation, Observation>> i_ = context.Operators.CrossJoin<Observation, Observation>(d_, h_);
		Tuple_GAdRFKRaHUUGJcVHWQWRUjhRH j_(ValueTuple<Observation, Observation> _valueTuple)
		{
			Tuple_GAdRFKRaHUUGJcVHWQWRUjhRH p_ = new Tuple_GAdRFKRaHUUGJcVHWQWRUjhRH
			{
				VR12MentalAssessment = _valueTuple.Item1,
				VR12PhysicalAssessment = _valueTuple.Item2,
			};

			return p_;
		};
		IEnumerable<Tuple_GAdRFKRaHUUGJcVHWQWRUjhRH> k_ = context.Operators.Select<ValueTuple<Observation, Observation>, Tuple_GAdRFKRaHUUGJcVHWQWRUjhRH>(i_, j_);
		bool? l_(Tuple_GAdRFKRaHUUGJcVHWQWRUjhRH tuple_gadrfkrahuugjcvhwqwrujhrh)
		{
			DataType q_ = tuple_gadrfkrahuugjcvhwqwrujhrh.VR12MentalAssessment?.Effective;
			object r_ = FHIRHelpers_4_3_000.ToValue(q_);
			CqlInterval<CqlDateTime> s_ = QICoreCommon_2_0_000.ToInterval(r_);
			CqlDateTime t_ = context.Operators.Start(s_);
			CqlDate u_ = context.Operators.DateFrom(t_);
			DataType v_ = tuple_gadrfkrahuugjcvhwqwrujhrh.VR12PhysicalAssessment?.Effective;
			object w_ = FHIRHelpers_4_3_000.ToValue(v_);
			CqlInterval<CqlDateTime> x_ = QICoreCommon_2_0_000.ToInterval(w_);
			CqlDateTime y_ = context.Operators.Start(x_);
			CqlDate z_ = context.Operators.DateFrom(y_);
			bool? aa_ = context.Operators.SameAs(u_, z_, "day");
			DataType ab_ = tuple_gadrfkrahuugjcvhwqwrujhrh.VR12MentalAssessment?.Value;
			object ac_ = FHIRHelpers_4_3_000.ToValue(ab_);
			bool? ad_ = context.Operators.Not((bool?)(ac_ is null));
			bool? ae_ = context.Operators.And(aa_, ad_);
			DataType af_ = tuple_gadrfkrahuugjcvhwqwrujhrh.VR12PhysicalAssessment?.Value;
			object ag_ = FHIRHelpers_4_3_000.ToValue(af_);
			bool? ah_ = context.Operators.Not((bool?)(ag_ is null));
			bool? ai_ = context.Operators.And(ae_, ah_);

			return ai_;
		};
		IEnumerable<Tuple_GAdRFKRaHUUGJcVHWQWRUjhRH> m_ = context.Operators.Where<Tuple_GAdRFKRaHUUGJcVHWQWRUjhRH>(k_, l_);
		CqlDate n_(Tuple_GAdRFKRaHUUGJcVHWQWRUjhRH tuple_gadrfkrahuugjcvhwqwrujhrh)
		{
			DataType aj_ = tuple_gadrfkrahuugjcvhwqwrujhrh.VR12MentalAssessment?.Effective;
			object ak_ = FHIRHelpers_4_3_000.ToValue(aj_);
			CqlInterval<CqlDateTime> al_ = QICoreCommon_2_0_000.ToInterval(ak_);
			CqlDateTime am_ = context.Operators.Start(al_);
			CqlDate an_ = context.Operators.DateFrom(am_);
			DataType ao_ = tuple_gadrfkrahuugjcvhwqwrujhrh.VR12PhysicalAssessment?.Effective;
			object ap_ = FHIRHelpers_4_3_000.ToValue(ao_);
			CqlInterval<CqlDateTime> aq_ = QICoreCommon_2_0_000.ToInterval(ap_);
			CqlDateTime ar_ = context.Operators.Start(aq_);
			CqlDate as_ = context.Operators.DateFrom(ar_);
			CqlDate[] at_ = new CqlDate[]
			{
				an_,
				as_,
			};
			CqlDate au_ = context.Operators.Max<CqlDate>((at_ as IEnumerable<CqlDate>));

			return au_;
		};
		IEnumerable<CqlDate> o_ = context.Operators.Select<Tuple_GAdRFKRaHUUGJcVHWQWRUjhRH, CqlDate>(m_, n_);

		return o_;
	}

    /// <seealso cref="Date_VR12_Orthogonal_Total_Assessment_Completed_Value"/>
    [CqlDeclaration("Date VR12 Orthogonal Total Assessment Completed")]
	public IEnumerable<CqlDate> Date_VR12_Orthogonal_Total_Assessment_Completed() => 
		__Date_VR12_Orthogonal_Total_Assessment_Completed.Value;

    /// <seealso cref="Has_Encounter_with_Initial_and_Follow_Up_VR12_Orthogonal_Assessments"/>
	private bool? Has_Encounter_with_Initial_and_Follow_Up_VR12_Orthogonal_Assessments_Value()
	{
		IEnumerable<Encounter> a_ = this.Qualifying_Encounters();
		IEnumerable<CqlDate> b_ = this.Date_VR12_Orthogonal_Total_Assessment_Completed();
		IEnumerable<ValueTuple<Encounter, CqlDate, CqlDate>> d_ = context.Operators.CrossJoin<Encounter, CqlDate, CqlDate>(a_, b_, b_);
		Tuple_FaNSVMJaEDMVSdOYROZXdLSaI e_(ValueTuple<Encounter, CqlDate, CqlDate> _valueTuple)
		{
			Tuple_FaNSVMJaEDMVSdOYROZXdLSaI l_ = new Tuple_FaNSVMJaEDMVSdOYROZXdLSaI
			{
				ValidEncounters = _valueTuple.Item1,
				InitialVR12OrthogonalDate = _valueTuple.Item2,
				FollowupVR12OrthogonalDate = _valueTuple.Item3,
			};

			return l_;
		};
		IEnumerable<Tuple_FaNSVMJaEDMVSdOYROZXdLSaI> f_ = context.Operators.Select<ValueTuple<Encounter, CqlDate, CqlDate>, Tuple_FaNSVMJaEDMVSdOYROZXdLSaI>(d_, e_);
		bool? g_(Tuple_FaNSVMJaEDMVSdOYROZXdLSaI tuple_fansvmjaedmvsdoyrozxdlsai)
		{
			Period m_ = tuple_fansvmjaedmvsdoyrozxdlsai.ValidEncounters?.Period;
			CqlInterval<CqlDateTime> n_ = FHIRHelpers_4_3_000.ToInterval(m_);
			CqlInterval<CqlDateTime> o_ = QICoreCommon_2_0_000.ToInterval((n_ as object));
			CqlDateTime p_ = context.Operators.End(o_);
			CqlInterval<CqlDateTime> q_ = this.Measurement_Period();
			CqlDateTime r_ = context.Operators.End(q_);
			CqlQuantity s_ = context.Operators.Quantity(180m, "days");
			CqlDateTime t_ = context.Operators.Subtract(r_, s_);
			bool? u_ = context.Operators.SameOrBefore(p_, t_, "day");
			CqlDateTime v_ = context.Operators.ConvertDateToDateTime(tuple_fansvmjaedmvsdoyrozxdlsai.InitialVR12OrthogonalDate);
			CqlInterval<CqlDateTime> x_ = FHIRHelpers_4_3_000.ToInterval(m_);
			CqlInterval<CqlDateTime> y_ = QICoreCommon_2_0_000.ToInterval((x_ as object));
			CqlDateTime z_ = context.Operators.End(y_);
			CqlQuantity aa_ = context.Operators.Quantity(14m, "days");
			CqlDateTime ab_ = context.Operators.Subtract(z_, aa_);
			CqlInterval<CqlDateTime> ad_ = FHIRHelpers_4_3_000.ToInterval(m_);
			CqlInterval<CqlDateTime> ae_ = QICoreCommon_2_0_000.ToInterval((ad_ as object));
			CqlDateTime af_ = context.Operators.End(ae_);
			CqlInterval<CqlDateTime> ag_ = context.Operators.Interval(ab_, af_, true, true);
			bool? ah_ = context.Operators.In<CqlDateTime>(v_, ag_, "day");
			CqlInterval<CqlDateTime> aj_ = FHIRHelpers_4_3_000.ToInterval(m_);
			CqlInterval<CqlDateTime> ak_ = QICoreCommon_2_0_000.ToInterval((aj_ as object));
			CqlDateTime al_ = context.Operators.End(ak_);
			bool? am_ = context.Operators.Not((bool?)(al_ is null));
			bool? an_ = context.Operators.And(ah_, am_);
			bool? ao_ = context.Operators.And(u_, an_);
			CqlDateTime ap_ = context.Operators.ConvertDateToDateTime(tuple_fansvmjaedmvsdoyrozxdlsai.FollowupVR12OrthogonalDate);
			CqlDate aq_ = context.Operators.DateFrom(ap_);
			CqlDate as_ = context.Operators.DateFrom(v_);
			CqlQuantity at_ = context.Operators.Quantity(30m, "days");
			CqlDate au_ = context.Operators.Add(as_, at_);
			CqlDate aw_ = context.Operators.DateFrom(v_);
			CqlDate ay_ = context.Operators.Add(aw_, s_);
			CqlInterval<CqlDate> az_ = context.Operators.Interval(au_, ay_, true, true);
			bool? ba_ = context.Operators.In<CqlDate>(aq_, az_, "day");
			bool? bb_ = context.Operators.And(ao_, ba_);

			return bb_;
		};
		IEnumerable<Tuple_FaNSVMJaEDMVSdOYROZXdLSaI> h_ = context.Operators.Where<Tuple_FaNSVMJaEDMVSdOYROZXdLSaI>(f_, g_);
		Encounter i_(Tuple_FaNSVMJaEDMVSdOYROZXdLSaI tuple_fansvmjaedmvsdoyrozxdlsai) => 
			tuple_fansvmjaedmvsdoyrozxdlsai.ValidEncounters;
		IEnumerable<Encounter> j_ = context.Operators.Select<Tuple_FaNSVMJaEDMVSdOYROZXdLSaI, Encounter>(h_, i_);
		bool? k_ = context.Operators.Exists<Encounter>(j_);

		return k_;
	}

    /// <seealso cref="Has_Encounter_with_Initial_and_Follow_Up_VR12_Orthogonal_Assessments_Value"/>
    [CqlDeclaration("Has Encounter with Initial and Follow Up VR12 Orthogonal Assessments")]
	public bool? Has_Encounter_with_Initial_and_Follow_Up_VR12_Orthogonal_Assessments() => 
		__Has_Encounter_with_Initial_and_Follow_Up_VR12_Orthogonal_Assessments.Value;

    /// <seealso cref="Date_VR36_Oblique_Total_Assessment_Completed"/>
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
		IEnumerable<ValueTuple<Observation, Observation>> i_ = context.Operators.CrossJoin<Observation, Observation>(d_, h_);
		Tuple_DUcFTCLcQEWDGGQdFCWTHFaUK j_(ValueTuple<Observation, Observation> _valueTuple)
		{
			Tuple_DUcFTCLcQEWDGGQdFCWTHFaUK p_ = new Tuple_DUcFTCLcQEWDGGQdFCWTHFaUK
			{
				VR36MentalAssessment = _valueTuple.Item1,
				VR36PhysicalAssessment = _valueTuple.Item2,
			};

			return p_;
		};
		IEnumerable<Tuple_DUcFTCLcQEWDGGQdFCWTHFaUK> k_ = context.Operators.Select<ValueTuple<Observation, Observation>, Tuple_DUcFTCLcQEWDGGQdFCWTHFaUK>(i_, j_);
		bool? l_(Tuple_DUcFTCLcQEWDGGQdFCWTHFaUK tuple_ducftclcqewdggqdfcwthfauk)
		{
			DataType q_ = tuple_ducftclcqewdggqdfcwthfauk.VR36MentalAssessment?.Effective;
			object r_ = FHIRHelpers_4_3_000.ToValue(q_);
			CqlInterval<CqlDateTime> s_ = QICoreCommon_2_0_000.ToInterval(r_);
			CqlDateTime t_ = context.Operators.Start(s_);
			CqlDate u_ = context.Operators.DateFrom(t_);
			DataType v_ = tuple_ducftclcqewdggqdfcwthfauk.VR36PhysicalAssessment?.Effective;
			object w_ = FHIRHelpers_4_3_000.ToValue(v_);
			CqlInterval<CqlDateTime> x_ = QICoreCommon_2_0_000.ToInterval(w_);
			CqlDateTime y_ = context.Operators.Start(x_);
			CqlDate z_ = context.Operators.DateFrom(y_);
			bool? aa_ = context.Operators.SameAs(u_, z_, "day");
			DataType ab_ = tuple_ducftclcqewdggqdfcwthfauk.VR36MentalAssessment?.Value;
			object ac_ = FHIRHelpers_4_3_000.ToValue(ab_);
			bool? ad_ = context.Operators.Not((bool?)(ac_ is null));
			bool? ae_ = context.Operators.And(aa_, ad_);
			DataType af_ = tuple_ducftclcqewdggqdfcwthfauk.VR36PhysicalAssessment?.Value;
			object ag_ = FHIRHelpers_4_3_000.ToValue(af_);
			bool? ah_ = context.Operators.Not((bool?)(ag_ is null));
			bool? ai_ = context.Operators.And(ae_, ah_);

			return ai_;
		};
		IEnumerable<Tuple_DUcFTCLcQEWDGGQdFCWTHFaUK> m_ = context.Operators.Where<Tuple_DUcFTCLcQEWDGGQdFCWTHFaUK>(k_, l_);
		CqlDate n_(Tuple_DUcFTCLcQEWDGGQdFCWTHFaUK tuple_ducftclcqewdggqdfcwthfauk)
		{
			DataType aj_ = tuple_ducftclcqewdggqdfcwthfauk.VR36MentalAssessment?.Effective;
			object ak_ = FHIRHelpers_4_3_000.ToValue(aj_);
			CqlInterval<CqlDateTime> al_ = QICoreCommon_2_0_000.ToInterval(ak_);
			CqlDateTime am_ = context.Operators.Start(al_);
			CqlDate an_ = context.Operators.DateFrom(am_);
			DataType ao_ = tuple_ducftclcqewdggqdfcwthfauk.VR36PhysicalAssessment?.Effective;
			object ap_ = FHIRHelpers_4_3_000.ToValue(ao_);
			CqlInterval<CqlDateTime> aq_ = QICoreCommon_2_0_000.ToInterval(ap_);
			CqlDateTime ar_ = context.Operators.Start(aq_);
			CqlDate as_ = context.Operators.DateFrom(ar_);
			CqlDate[] at_ = new CqlDate[]
			{
				an_,
				as_,
			};
			CqlDate au_ = context.Operators.Max<CqlDate>((at_ as IEnumerable<CqlDate>));

			return au_;
		};
		IEnumerable<CqlDate> o_ = context.Operators.Select<Tuple_DUcFTCLcQEWDGGQdFCWTHFaUK, CqlDate>(m_, n_);

		return o_;
	}

    /// <seealso cref="Date_VR36_Oblique_Total_Assessment_Completed_Value"/>
    [CqlDeclaration("Date VR36 Oblique Total Assessment Completed")]
	public IEnumerable<CqlDate> Date_VR36_Oblique_Total_Assessment_Completed() => 
		__Date_VR36_Oblique_Total_Assessment_Completed.Value;

    /// <seealso cref="Has_Encounter_with_Initial_and_Follow_Up_VR36_Oblique_Assessments"/>
	private bool? Has_Encounter_with_Initial_and_Follow_Up_VR36_Oblique_Assessments_Value()
	{
		IEnumerable<Encounter> a_ = this.Qualifying_Encounters();
		IEnumerable<CqlDate> b_ = this.Date_VR36_Oblique_Total_Assessment_Completed();
		IEnumerable<ValueTuple<Encounter, CqlDate, CqlDate>> d_ = context.Operators.CrossJoin<Encounter, CqlDate, CqlDate>(a_, b_, b_);
		Tuple_ELXIcYHRDPYZPQYJPHdiFBiGA e_(ValueTuple<Encounter, CqlDate, CqlDate> _valueTuple)
		{
			Tuple_ELXIcYHRDPYZPQYJPHdiFBiGA l_ = new Tuple_ELXIcYHRDPYZPQYJPHdiFBiGA
			{
				ValidEncounters = _valueTuple.Item1,
				InitialVR36ObliqueDate = _valueTuple.Item2,
				FollowupVR36ObliqueDate = _valueTuple.Item3,
			};

			return l_;
		};
		IEnumerable<Tuple_ELXIcYHRDPYZPQYJPHdiFBiGA> f_ = context.Operators.Select<ValueTuple<Encounter, CqlDate, CqlDate>, Tuple_ELXIcYHRDPYZPQYJPHdiFBiGA>(d_, e_);
		bool? g_(Tuple_ELXIcYHRDPYZPQYJPHdiFBiGA tuple_elxicyhrdpyzpqyjphdifbiga)
		{
			Period m_ = tuple_elxicyhrdpyzpqyjphdifbiga.ValidEncounters?.Period;
			CqlInterval<CqlDateTime> n_ = FHIRHelpers_4_3_000.ToInterval(m_);
			CqlInterval<CqlDateTime> o_ = QICoreCommon_2_0_000.ToInterval((n_ as object));
			CqlDateTime p_ = context.Operators.End(o_);
			CqlInterval<CqlDateTime> q_ = this.Measurement_Period();
			CqlDateTime r_ = context.Operators.End(q_);
			CqlQuantity s_ = context.Operators.Quantity(180m, "days");
			CqlDateTime t_ = context.Operators.Subtract(r_, s_);
			bool? u_ = context.Operators.SameOrBefore(p_, t_, "day");
			CqlDateTime v_ = context.Operators.ConvertDateToDateTime(tuple_elxicyhrdpyzpqyjphdifbiga.InitialVR36ObliqueDate);
			CqlInterval<CqlDateTime> x_ = FHIRHelpers_4_3_000.ToInterval(m_);
			CqlInterval<CqlDateTime> y_ = QICoreCommon_2_0_000.ToInterval((x_ as object));
			CqlDateTime z_ = context.Operators.End(y_);
			CqlQuantity aa_ = context.Operators.Quantity(14m, "days");
			CqlDateTime ab_ = context.Operators.Subtract(z_, aa_);
			CqlInterval<CqlDateTime> ad_ = FHIRHelpers_4_3_000.ToInterval(m_);
			CqlInterval<CqlDateTime> ae_ = QICoreCommon_2_0_000.ToInterval((ad_ as object));
			CqlDateTime af_ = context.Operators.End(ae_);
			CqlInterval<CqlDateTime> ag_ = context.Operators.Interval(ab_, af_, true, true);
			bool? ah_ = context.Operators.In<CqlDateTime>(v_, ag_, "day");
			CqlInterval<CqlDateTime> aj_ = FHIRHelpers_4_3_000.ToInterval(m_);
			CqlInterval<CqlDateTime> ak_ = QICoreCommon_2_0_000.ToInterval((aj_ as object));
			CqlDateTime al_ = context.Operators.End(ak_);
			bool? am_ = context.Operators.Not((bool?)(al_ is null));
			bool? an_ = context.Operators.And(ah_, am_);
			bool? ao_ = context.Operators.And(u_, an_);
			CqlDateTime ap_ = context.Operators.ConvertDateToDateTime(tuple_elxicyhrdpyzpqyjphdifbiga.FollowupVR36ObliqueDate);
			CqlDate aq_ = context.Operators.DateFrom(ap_);
			CqlDate as_ = context.Operators.DateFrom(v_);
			CqlQuantity at_ = context.Operators.Quantity(30m, "days");
			CqlDate au_ = context.Operators.Add(as_, at_);
			CqlDate aw_ = context.Operators.DateFrom(v_);
			CqlDate ay_ = context.Operators.Add(aw_, s_);
			CqlInterval<CqlDate> az_ = context.Operators.Interval(au_, ay_, true, true);
			bool? ba_ = context.Operators.In<CqlDate>(aq_, az_, "day");
			bool? bb_ = context.Operators.And(ao_, ba_);

			return bb_;
		};
		IEnumerable<Tuple_ELXIcYHRDPYZPQYJPHdiFBiGA> h_ = context.Operators.Where<Tuple_ELXIcYHRDPYZPQYJPHdiFBiGA>(f_, g_);
		Encounter i_(Tuple_ELXIcYHRDPYZPQYJPHdiFBiGA tuple_elxicyhrdpyzpqyjphdifbiga) => 
			tuple_elxicyhrdpyzpqyjphdifbiga.ValidEncounters;
		IEnumerable<Encounter> j_ = context.Operators.Select<Tuple_ELXIcYHRDPYZPQYJPHdiFBiGA, Encounter>(h_, i_);
		bool? k_ = context.Operators.Exists<Encounter>(j_);

		return k_;
	}

    /// <seealso cref="Has_Encounter_with_Initial_and_Follow_Up_VR36_Oblique_Assessments_Value"/>
    [CqlDeclaration("Has Encounter with Initial and Follow Up VR36 Oblique Assessments")]
	public bool? Has_Encounter_with_Initial_and_Follow_Up_VR36_Oblique_Assessments() => 
		__Has_Encounter_with_Initial_and_Follow_Up_VR36_Oblique_Assessments.Value;

    /// <seealso cref="Date_VR36_Orthogonal_Total_Assessment_Completed"/>
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
		IEnumerable<ValueTuple<Observation, Observation>> i_ = context.Operators.CrossJoin<Observation, Observation>(d_, h_);
		Tuple_DUcFTCLcQEWDGGQdFCWTHFaUK j_(ValueTuple<Observation, Observation> _valueTuple)
		{
			Tuple_DUcFTCLcQEWDGGQdFCWTHFaUK p_ = new Tuple_DUcFTCLcQEWDGGQdFCWTHFaUK
			{
				VR36MentalAssessment = _valueTuple.Item1,
				VR36PhysicalAssessment = _valueTuple.Item2,
			};

			return p_;
		};
		IEnumerable<Tuple_DUcFTCLcQEWDGGQdFCWTHFaUK> k_ = context.Operators.Select<ValueTuple<Observation, Observation>, Tuple_DUcFTCLcQEWDGGQdFCWTHFaUK>(i_, j_);
		bool? l_(Tuple_DUcFTCLcQEWDGGQdFCWTHFaUK tuple_ducftclcqewdggqdfcwthfauk)
		{
			DataType q_ = tuple_ducftclcqewdggqdfcwthfauk.VR36MentalAssessment?.Effective;
			object r_ = FHIRHelpers_4_3_000.ToValue(q_);
			CqlInterval<CqlDateTime> s_ = QICoreCommon_2_0_000.ToInterval(r_);
			CqlDateTime t_ = context.Operators.Start(s_);
			CqlDate u_ = context.Operators.DateFrom(t_);
			DataType v_ = tuple_ducftclcqewdggqdfcwthfauk.VR36PhysicalAssessment?.Effective;
			object w_ = FHIRHelpers_4_3_000.ToValue(v_);
			CqlInterval<CqlDateTime> x_ = QICoreCommon_2_0_000.ToInterval(w_);
			CqlDateTime y_ = context.Operators.Start(x_);
			CqlDate z_ = context.Operators.DateFrom(y_);
			bool? aa_ = context.Operators.SameAs(u_, z_, "day");
			DataType ab_ = tuple_ducftclcqewdggqdfcwthfauk.VR36MentalAssessment?.Value;
			object ac_ = FHIRHelpers_4_3_000.ToValue(ab_);
			bool? ad_ = context.Operators.Not((bool?)(ac_ is null));
			bool? ae_ = context.Operators.And(aa_, ad_);
			DataType af_ = tuple_ducftclcqewdggqdfcwthfauk.VR36PhysicalAssessment?.Value;
			object ag_ = FHIRHelpers_4_3_000.ToValue(af_);
			bool? ah_ = context.Operators.Not((bool?)(ag_ is null));
			bool? ai_ = context.Operators.And(ae_, ah_);

			return ai_;
		};
		IEnumerable<Tuple_DUcFTCLcQEWDGGQdFCWTHFaUK> m_ = context.Operators.Where<Tuple_DUcFTCLcQEWDGGQdFCWTHFaUK>(k_, l_);
		CqlDate n_(Tuple_DUcFTCLcQEWDGGQdFCWTHFaUK tuple_ducftclcqewdggqdfcwthfauk)
		{
			DataType aj_ = tuple_ducftclcqewdggqdfcwthfauk.VR36MentalAssessment?.Effective;
			object ak_ = FHIRHelpers_4_3_000.ToValue(aj_);
			CqlInterval<CqlDateTime> al_ = QICoreCommon_2_0_000.ToInterval(ak_);
			CqlDateTime am_ = context.Operators.Start(al_);
			CqlDate an_ = context.Operators.DateFrom(am_);
			DataType ao_ = tuple_ducftclcqewdggqdfcwthfauk.VR36PhysicalAssessment?.Effective;
			object ap_ = FHIRHelpers_4_3_000.ToValue(ao_);
			CqlInterval<CqlDateTime> aq_ = QICoreCommon_2_0_000.ToInterval(ap_);
			CqlDateTime ar_ = context.Operators.Start(aq_);
			CqlDate as_ = context.Operators.DateFrom(ar_);
			CqlDate[] at_ = new CqlDate[]
			{
				an_,
				as_,
			};
			CqlDate au_ = context.Operators.Max<CqlDate>((at_ as IEnumerable<CqlDate>));

			return au_;
		};
		IEnumerable<CqlDate> o_ = context.Operators.Select<Tuple_DUcFTCLcQEWDGGQdFCWTHFaUK, CqlDate>(m_, n_);

		return o_;
	}

    /// <seealso cref="Date_VR36_Orthogonal_Total_Assessment_Completed_Value"/>
    [CqlDeclaration("Date VR36 Orthogonal Total Assessment Completed")]
	public IEnumerable<CqlDate> Date_VR36_Orthogonal_Total_Assessment_Completed() => 
		__Date_VR36_Orthogonal_Total_Assessment_Completed.Value;

    /// <seealso cref="Has_Encounter_with_Initial_and_Follow_Up_VR36_Orthogonal_Assessments"/>
	private bool? Has_Encounter_with_Initial_and_Follow_Up_VR36_Orthogonal_Assessments_Value()
	{
		IEnumerable<Encounter> a_ = this.Qualifying_Encounters();
		IEnumerable<CqlDate> b_ = this.Date_VR36_Orthogonal_Total_Assessment_Completed();
		IEnumerable<ValueTuple<Encounter, CqlDate, CqlDate>> d_ = context.Operators.CrossJoin<Encounter, CqlDate, CqlDate>(a_, b_, b_);
		Tuple_fUCQUjAdjiZABIHDfFFORMHT e_(ValueTuple<Encounter, CqlDate, CqlDate> _valueTuple)
		{
			Tuple_fUCQUjAdjiZABIHDfFFORMHT l_ = new Tuple_fUCQUjAdjiZABIHDfFFORMHT
			{
				ValidEncounters = _valueTuple.Item1,
				InitialVR36OrthogonalDate = _valueTuple.Item2,
				FollowupVR36OrthogonalDate = _valueTuple.Item3,
			};

			return l_;
		};
		IEnumerable<Tuple_fUCQUjAdjiZABIHDfFFORMHT> f_ = context.Operators.Select<ValueTuple<Encounter, CqlDate, CqlDate>, Tuple_fUCQUjAdjiZABIHDfFFORMHT>(d_, e_);
		bool? g_(Tuple_fUCQUjAdjiZABIHDfFFORMHT tuple_fucqujadjizabihdffformht)
		{
			Period m_ = tuple_fucqujadjizabihdffformht.ValidEncounters?.Period;
			CqlInterval<CqlDateTime> n_ = FHIRHelpers_4_3_000.ToInterval(m_);
			CqlInterval<CqlDateTime> o_ = QICoreCommon_2_0_000.ToInterval((n_ as object));
			CqlDateTime p_ = context.Operators.End(o_);
			CqlInterval<CqlDateTime> q_ = this.Measurement_Period();
			CqlDateTime r_ = context.Operators.End(q_);
			CqlQuantity s_ = context.Operators.Quantity(180m, "days");
			CqlDateTime t_ = context.Operators.Subtract(r_, s_);
			bool? u_ = context.Operators.SameOrBefore(p_, t_, "day");
			CqlDateTime v_ = context.Operators.ConvertDateToDateTime(tuple_fucqujadjizabihdffformht.InitialVR36OrthogonalDate);
			CqlInterval<CqlDateTime> x_ = FHIRHelpers_4_3_000.ToInterval(m_);
			CqlInterval<CqlDateTime> y_ = QICoreCommon_2_0_000.ToInterval((x_ as object));
			CqlDateTime z_ = context.Operators.End(y_);
			CqlQuantity aa_ = context.Operators.Quantity(14m, "days");
			CqlDateTime ab_ = context.Operators.Subtract(z_, aa_);
			CqlInterval<CqlDateTime> ad_ = FHIRHelpers_4_3_000.ToInterval(m_);
			CqlInterval<CqlDateTime> ae_ = QICoreCommon_2_0_000.ToInterval((ad_ as object));
			CqlDateTime af_ = context.Operators.End(ae_);
			CqlInterval<CqlDateTime> ag_ = context.Operators.Interval(ab_, af_, true, true);
			bool? ah_ = context.Operators.In<CqlDateTime>(v_, ag_, "day");
			CqlInterval<CqlDateTime> aj_ = FHIRHelpers_4_3_000.ToInterval(m_);
			CqlInterval<CqlDateTime> ak_ = QICoreCommon_2_0_000.ToInterval((aj_ as object));
			CqlDateTime al_ = context.Operators.End(ak_);
			bool? am_ = context.Operators.Not((bool?)(al_ is null));
			bool? an_ = context.Operators.And(ah_, am_);
			bool? ao_ = context.Operators.And(u_, an_);
			CqlDateTime ap_ = context.Operators.ConvertDateToDateTime(tuple_fucqujadjizabihdffformht.FollowupVR36OrthogonalDate);
			CqlDate aq_ = context.Operators.DateFrom(ap_);
			CqlDate as_ = context.Operators.DateFrom(v_);
			CqlQuantity at_ = context.Operators.Quantity(30m, "days");
			CqlDate au_ = context.Operators.Add(as_, at_);
			CqlDate aw_ = context.Operators.DateFrom(v_);
			CqlDate ay_ = context.Operators.Add(aw_, s_);
			CqlInterval<CqlDate> az_ = context.Operators.Interval(au_, ay_, true, true);
			bool? ba_ = context.Operators.In<CqlDate>(aq_, az_, "day");
			bool? bb_ = context.Operators.And(ao_, ba_);

			return bb_;
		};
		IEnumerable<Tuple_fUCQUjAdjiZABIHDfFFORMHT> h_ = context.Operators.Where<Tuple_fUCQUjAdjiZABIHDfFFORMHT>(f_, g_);
		Encounter i_(Tuple_fUCQUjAdjiZABIHDfFFORMHT tuple_fucqujadjizabihdffformht) => 
			tuple_fucqujadjizabihdffformht.ValidEncounters;
		IEnumerable<Encounter> j_ = context.Operators.Select<Tuple_fUCQUjAdjiZABIHDfFFORMHT, Encounter>(h_, i_);
		bool? k_ = context.Operators.Exists<Encounter>(j_);

		return k_;
	}

    /// <seealso cref="Has_Encounter_with_Initial_and_Follow_Up_VR36_Orthogonal_Assessments_Value"/>
    [CqlDeclaration("Has Encounter with Initial and Follow Up VR36 Orthogonal Assessments")]
	public bool? Has_Encounter_with_Initial_and_Follow_Up_VR36_Orthogonal_Assessments() => 
		__Has_Encounter_with_Initial_and_Follow_Up_VR36_Orthogonal_Assessments.Value;

    /// <seealso cref="Date_MLHFQ_Total_Assessment_Completed"/>
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
		IEnumerable<ValueTuple<Observation, Observation>> i_ = context.Operators.CrossJoin<Observation, Observation>(d_, h_);
		Tuple_FNOFXCKadAeUSJERHBDQfOShE j_(ValueTuple<Observation, Observation> _valueTuple)
		{
			Tuple_FNOFXCKadAeUSJERHBDQfOShE p_ = new Tuple_FNOFXCKadAeUSJERHBDQfOShE
			{
				MLHFQPhysical = _valueTuple.Item1,
				MLHFQEmotional = _valueTuple.Item2,
			};

			return p_;
		};
		IEnumerable<Tuple_FNOFXCKadAeUSJERHBDQfOShE> k_ = context.Operators.Select<ValueTuple<Observation, Observation>, Tuple_FNOFXCKadAeUSJERHBDQfOShE>(i_, j_);
		bool? l_(Tuple_FNOFXCKadAeUSJERHBDQfOShE tuple_fnofxckadaeusjerhbdqfoshe)
		{
			DataType q_ = tuple_fnofxckadaeusjerhbdqfoshe.MLHFQPhysical?.Effective;
			object r_ = FHIRHelpers_4_3_000.ToValue(q_);
			CqlInterval<CqlDateTime> s_ = QICoreCommon_2_0_000.ToInterval(r_);
			CqlDateTime t_ = context.Operators.Start(s_);
			CqlDate u_ = context.Operators.DateFrom(t_);
			DataType v_ = tuple_fnofxckadaeusjerhbdqfoshe.MLHFQEmotional?.Effective;
			object w_ = FHIRHelpers_4_3_000.ToValue(v_);
			CqlInterval<CqlDateTime> x_ = QICoreCommon_2_0_000.ToInterval(w_);
			CqlDateTime y_ = context.Operators.Start(x_);
			CqlDate z_ = context.Operators.DateFrom(y_);
			bool? aa_ = context.Operators.SameAs(u_, z_, "day");
			DataType ab_ = tuple_fnofxckadaeusjerhbdqfoshe.MLHFQPhysical?.Value;
			object ac_ = FHIRHelpers_4_3_000.ToValue(ab_);
			bool? ad_ = context.Operators.Not((bool?)(ac_ is null));
			bool? ae_ = context.Operators.And(aa_, ad_);
			DataType af_ = tuple_fnofxckadaeusjerhbdqfoshe.MLHFQEmotional?.Value;
			object ag_ = FHIRHelpers_4_3_000.ToValue(af_);
			bool? ah_ = context.Operators.Not((bool?)(ag_ is null));
			bool? ai_ = context.Operators.And(ae_, ah_);

			return ai_;
		};
		IEnumerable<Tuple_FNOFXCKadAeUSJERHBDQfOShE> m_ = context.Operators.Where<Tuple_FNOFXCKadAeUSJERHBDQfOShE>(k_, l_);
		CqlDate n_(Tuple_FNOFXCKadAeUSJERHBDQfOShE tuple_fnofxckadaeusjerhbdqfoshe)
		{
			DataType aj_ = tuple_fnofxckadaeusjerhbdqfoshe.MLHFQPhysical?.Effective;
			object ak_ = FHIRHelpers_4_3_000.ToValue(aj_);
			CqlInterval<CqlDateTime> al_ = QICoreCommon_2_0_000.ToInterval(ak_);
			CqlDateTime am_ = context.Operators.Start(al_);
			CqlDate an_ = context.Operators.DateFrom(am_);
			DataType ao_ = tuple_fnofxckadaeusjerhbdqfoshe.MLHFQEmotional?.Effective;
			object ap_ = FHIRHelpers_4_3_000.ToValue(ao_);
			CqlInterval<CqlDateTime> aq_ = QICoreCommon_2_0_000.ToInterval(ap_);
			CqlDateTime ar_ = context.Operators.Start(aq_);
			CqlDate as_ = context.Operators.DateFrom(ar_);
			CqlDate[] at_ = new CqlDate[]
			{
				an_,
				as_,
			};
			CqlDate au_ = context.Operators.Max<CqlDate>((at_ as IEnumerable<CqlDate>));

			return au_;
		};
		IEnumerable<CqlDate> o_ = context.Operators.Select<Tuple_FNOFXCKadAeUSJERHBDQfOShE, CqlDate>(m_, n_);

		return o_;
	}

    /// <seealso cref="Date_MLHFQ_Total_Assessment_Completed_Value"/>
    [CqlDeclaration("Date MLHFQ Total Assessment Completed")]
	public IEnumerable<CqlDate> Date_MLHFQ_Total_Assessment_Completed() => 
		__Date_MLHFQ_Total_Assessment_Completed.Value;

    /// <seealso cref="Has_Encounter_with_Initial_and_Follow_Up_MLHFQ_Assessments"/>
	private bool? Has_Encounter_with_Initial_and_Follow_Up_MLHFQ_Assessments_Value()
	{
		IEnumerable<Encounter> a_ = this.Qualifying_Encounters();
		IEnumerable<CqlDate> b_ = this.Date_MLHFQ_Total_Assessment_Completed();
		IEnumerable<ValueTuple<Encounter, CqlDate, CqlDate>> d_ = context.Operators.CrossJoin<Encounter, CqlDate, CqlDate>(a_, b_, b_);
		Tuple_NCDAWCTNMBFMTibMiHSFBAIG e_(ValueTuple<Encounter, CqlDate, CqlDate> _valueTuple)
		{
			Tuple_NCDAWCTNMBFMTibMiHSFBAIG l_ = new Tuple_NCDAWCTNMBFMTibMiHSFBAIG
			{
				ValidEncounters = _valueTuple.Item1,
				InitialMLHFQDate = _valueTuple.Item2,
				FollowupMLHFQDate = _valueTuple.Item3,
			};

			return l_;
		};
		IEnumerable<Tuple_NCDAWCTNMBFMTibMiHSFBAIG> f_ = context.Operators.Select<ValueTuple<Encounter, CqlDate, CqlDate>, Tuple_NCDAWCTNMBFMTibMiHSFBAIG>(d_, e_);
		bool? g_(Tuple_NCDAWCTNMBFMTibMiHSFBAIG tuple_ncdawctnmbfmtibmihsfbaig)
		{
			Period m_ = tuple_ncdawctnmbfmtibmihsfbaig.ValidEncounters?.Period;
			CqlInterval<CqlDateTime> n_ = FHIRHelpers_4_3_000.ToInterval(m_);
			CqlInterval<CqlDateTime> o_ = QICoreCommon_2_0_000.ToInterval((n_ as object));
			CqlDateTime p_ = context.Operators.End(o_);
			CqlInterval<CqlDateTime> q_ = this.Measurement_Period();
			CqlDateTime r_ = context.Operators.End(q_);
			CqlQuantity s_ = context.Operators.Quantity(180m, "days");
			CqlDateTime t_ = context.Operators.Subtract(r_, s_);
			bool? u_ = context.Operators.SameOrBefore(p_, t_, "day");
			CqlDateTime v_ = context.Operators.ConvertDateToDateTime(tuple_ncdawctnmbfmtibmihsfbaig.InitialMLHFQDate);
			CqlInterval<CqlDateTime> x_ = FHIRHelpers_4_3_000.ToInterval(m_);
			CqlInterval<CqlDateTime> y_ = QICoreCommon_2_0_000.ToInterval((x_ as object));
			CqlDateTime z_ = context.Operators.End(y_);
			CqlQuantity aa_ = context.Operators.Quantity(14m, "days");
			CqlDateTime ab_ = context.Operators.Subtract(z_, aa_);
			CqlInterval<CqlDateTime> ad_ = FHIRHelpers_4_3_000.ToInterval(m_);
			CqlInterval<CqlDateTime> ae_ = QICoreCommon_2_0_000.ToInterval((ad_ as object));
			CqlDateTime af_ = context.Operators.End(ae_);
			CqlInterval<CqlDateTime> ag_ = context.Operators.Interval(ab_, af_, true, true);
			bool? ah_ = context.Operators.In<CqlDateTime>(v_, ag_, "day");
			CqlInterval<CqlDateTime> aj_ = FHIRHelpers_4_3_000.ToInterval(m_);
			CqlInterval<CqlDateTime> ak_ = QICoreCommon_2_0_000.ToInterval((aj_ as object));
			CqlDateTime al_ = context.Operators.End(ak_);
			bool? am_ = context.Operators.Not((bool?)(al_ is null));
			bool? an_ = context.Operators.And(ah_, am_);
			bool? ao_ = context.Operators.And(u_, an_);
			CqlDateTime ap_ = context.Operators.ConvertDateToDateTime(tuple_ncdawctnmbfmtibmihsfbaig.FollowupMLHFQDate);
			CqlDate aq_ = context.Operators.DateFrom(ap_);
			CqlDate as_ = context.Operators.DateFrom(v_);
			CqlQuantity at_ = context.Operators.Quantity(30m, "days");
			CqlDate au_ = context.Operators.Add(as_, at_);
			CqlDate aw_ = context.Operators.DateFrom(v_);
			CqlDate ay_ = context.Operators.Add(aw_, s_);
			CqlInterval<CqlDate> az_ = context.Operators.Interval(au_, ay_, true, true);
			bool? ba_ = context.Operators.In<CqlDate>(aq_, az_, "day");
			bool? bb_ = context.Operators.And(ao_, ba_);

			return bb_;
		};
		IEnumerable<Tuple_NCDAWCTNMBFMTibMiHSFBAIG> h_ = context.Operators.Where<Tuple_NCDAWCTNMBFMTibMiHSFBAIG>(f_, g_);
		Encounter i_(Tuple_NCDAWCTNMBFMTibMiHSFBAIG tuple_ncdawctnmbfmtibmihsfbaig) => 
			tuple_ncdawctnmbfmtibmihsfbaig.ValidEncounters;
		IEnumerable<Encounter> j_ = context.Operators.Select<Tuple_NCDAWCTNMBFMTibMiHSFBAIG, Encounter>(h_, i_);
		bool? k_ = context.Operators.Exists<Encounter>(j_);

		return k_;
	}

    /// <seealso cref="Has_Encounter_with_Initial_and_Follow_Up_MLHFQ_Assessments_Value"/>
    [CqlDeclaration("Has Encounter with Initial and Follow Up MLHFQ Assessments")]
	public bool? Has_Encounter_with_Initial_and_Follow_Up_MLHFQ_Assessments() => 
		__Has_Encounter_with_Initial_and_Follow_Up_MLHFQ_Assessments.Value;

    /// <seealso cref="Date_KCCQ12_Total_Assessment_Completed"/>
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
		IEnumerable<ValueTuple<Observation, Observation>> i_ = context.Operators.CrossJoin<Observation, Observation>(d_, h_);
		Tuple_DFKXORghhYafccUSbQaMfNTDj j_(ValueTuple<Observation, Observation> _valueTuple)
		{
			Tuple_DFKXORghhYafccUSbQaMfNTDj p_ = new Tuple_DFKXORghhYafccUSbQaMfNTDj
			{
				KCCQ12Item = _valueTuple.Item1,
				KCCQ12Summary = _valueTuple.Item2,
			};

			return p_;
		};
		IEnumerable<Tuple_DFKXORghhYafccUSbQaMfNTDj> k_ = context.Operators.Select<ValueTuple<Observation, Observation>, Tuple_DFKXORghhYafccUSbQaMfNTDj>(i_, j_);
		bool? l_(Tuple_DFKXORghhYafccUSbQaMfNTDj tuple_dfkxorghhyafccusbqamfntdj)
		{
			DataType q_ = tuple_dfkxorghhyafccusbqamfntdj.KCCQ12Item?.Effective;
			object r_ = FHIRHelpers_4_3_000.ToValue(q_);
			CqlInterval<CqlDateTime> s_ = QICoreCommon_2_0_000.ToInterval(r_);
			CqlDateTime t_ = context.Operators.Start(s_);
			CqlDate u_ = context.Operators.DateFrom(t_);
			DataType v_ = tuple_dfkxorghhyafccusbqamfntdj.KCCQ12Summary?.Effective;
			object w_ = FHIRHelpers_4_3_000.ToValue(v_);
			CqlInterval<CqlDateTime> x_ = QICoreCommon_2_0_000.ToInterval(w_);
			CqlDateTime y_ = context.Operators.Start(x_);
			CqlDate z_ = context.Operators.DateFrom(y_);
			bool? aa_ = context.Operators.SameAs(u_, z_, "day");
			DataType ab_ = tuple_dfkxorghhyafccusbqamfntdj.KCCQ12Item?.Value;
			object ac_ = FHIRHelpers_4_3_000.ToValue(ab_);
			bool? ad_ = context.Operators.Not((bool?)(ac_ is null));
			bool? ae_ = context.Operators.And(aa_, ad_);
			DataType af_ = tuple_dfkxorghhyafccusbqamfntdj.KCCQ12Summary?.Value;
			object ag_ = FHIRHelpers_4_3_000.ToValue(af_);
			bool? ah_ = context.Operators.Not((bool?)(ag_ is null));
			bool? ai_ = context.Operators.And(ae_, ah_);

			return ai_;
		};
		IEnumerable<Tuple_DFKXORghhYafccUSbQaMfNTDj> m_ = context.Operators.Where<Tuple_DFKXORghhYafccUSbQaMfNTDj>(k_, l_);
		CqlDate n_(Tuple_DFKXORghhYafccUSbQaMfNTDj tuple_dfkxorghhyafccusbqamfntdj)
		{
			DataType aj_ = tuple_dfkxorghhyafccusbqamfntdj.KCCQ12Item?.Effective;
			object ak_ = FHIRHelpers_4_3_000.ToValue(aj_);
			CqlInterval<CqlDateTime> al_ = QICoreCommon_2_0_000.ToInterval(ak_);
			CqlDateTime am_ = context.Operators.Start(al_);
			CqlDate an_ = context.Operators.DateFrom(am_);
			DataType ao_ = tuple_dfkxorghhyafccusbqamfntdj.KCCQ12Summary?.Effective;
			object ap_ = FHIRHelpers_4_3_000.ToValue(ao_);
			CqlInterval<CqlDateTime> aq_ = QICoreCommon_2_0_000.ToInterval(ap_);
			CqlDateTime ar_ = context.Operators.Start(aq_);
			CqlDate as_ = context.Operators.DateFrom(ar_);
			CqlDate[] at_ = new CqlDate[]
			{
				an_,
				as_,
			};
			CqlDate au_ = context.Operators.Max<CqlDate>((at_ as IEnumerable<CqlDate>));

			return au_;
		};
		IEnumerable<CqlDate> o_ = context.Operators.Select<Tuple_DFKXORghhYafccUSbQaMfNTDj, CqlDate>(m_, n_);

		return o_;
	}

    /// <seealso cref="Date_KCCQ12_Total_Assessment_Completed_Value"/>
    [CqlDeclaration("Date KCCQ12 Total Assessment Completed")]
	public IEnumerable<CqlDate> Date_KCCQ12_Total_Assessment_Completed() => 
		__Date_KCCQ12_Total_Assessment_Completed.Value;

    /// <seealso cref="Has_Encounter_with_Initial_and_Follow_Up_KCCQ12_Assessments"/>
	private bool? Has_Encounter_with_Initial_and_Follow_Up_KCCQ12_Assessments_Value()
	{
		IEnumerable<Encounter> a_ = this.Qualifying_Encounters();
		IEnumerable<CqlDate> b_ = this.Date_KCCQ12_Total_Assessment_Completed();
		IEnumerable<ValueTuple<Encounter, CqlDate, CqlDate>> d_ = context.Operators.CrossJoin<Encounter, CqlDate, CqlDate>(a_, b_, b_);
		Tuple_EOaHGTWWdfQIJhCjZQNViDVUO e_(ValueTuple<Encounter, CqlDate, CqlDate> _valueTuple)
		{
			Tuple_EOaHGTWWdfQIJhCjZQNViDVUO l_ = new Tuple_EOaHGTWWdfQIJhCjZQNViDVUO
			{
				ValidEncounters = _valueTuple.Item1,
				InitialKCCQ12Date = _valueTuple.Item2,
				FollowupKCCQ12Date = _valueTuple.Item3,
			};

			return l_;
		};
		IEnumerable<Tuple_EOaHGTWWdfQIJhCjZQNViDVUO> f_ = context.Operators.Select<ValueTuple<Encounter, CqlDate, CqlDate>, Tuple_EOaHGTWWdfQIJhCjZQNViDVUO>(d_, e_);
		bool? g_(Tuple_EOaHGTWWdfQIJhCjZQNViDVUO tuple_eoahgtwwdfqijhcjzqnvidvuo)
		{
			Period m_ = tuple_eoahgtwwdfqijhcjzqnvidvuo.ValidEncounters?.Period;
			CqlInterval<CqlDateTime> n_ = FHIRHelpers_4_3_000.ToInterval(m_);
			CqlInterval<CqlDateTime> o_ = QICoreCommon_2_0_000.ToInterval((n_ as object));
			CqlDateTime p_ = context.Operators.End(o_);
			CqlInterval<CqlDateTime> q_ = this.Measurement_Period();
			CqlDateTime r_ = context.Operators.End(q_);
			CqlQuantity s_ = context.Operators.Quantity(180m, "days");
			CqlDateTime t_ = context.Operators.Subtract(r_, s_);
			bool? u_ = context.Operators.SameOrBefore(p_, t_, "day");
			CqlDateTime v_ = context.Operators.ConvertDateToDateTime(tuple_eoahgtwwdfqijhcjzqnvidvuo.InitialKCCQ12Date);
			CqlInterval<CqlDateTime> x_ = FHIRHelpers_4_3_000.ToInterval(m_);
			CqlInterval<CqlDateTime> y_ = QICoreCommon_2_0_000.ToInterval((x_ as object));
			CqlDateTime z_ = context.Operators.End(y_);
			CqlQuantity aa_ = context.Operators.Quantity(14m, "days");
			CqlDateTime ab_ = context.Operators.Subtract(z_, aa_);
			CqlInterval<CqlDateTime> ad_ = FHIRHelpers_4_3_000.ToInterval(m_);
			CqlInterval<CqlDateTime> ae_ = QICoreCommon_2_0_000.ToInterval((ad_ as object));
			CqlDateTime af_ = context.Operators.End(ae_);
			CqlInterval<CqlDateTime> ag_ = context.Operators.Interval(ab_, af_, true, true);
			bool? ah_ = context.Operators.In<CqlDateTime>(v_, ag_, "day");
			CqlInterval<CqlDateTime> aj_ = FHIRHelpers_4_3_000.ToInterval(m_);
			CqlInterval<CqlDateTime> ak_ = QICoreCommon_2_0_000.ToInterval((aj_ as object));
			CqlDateTime al_ = context.Operators.End(ak_);
			bool? am_ = context.Operators.Not((bool?)(al_ is null));
			bool? an_ = context.Operators.And(ah_, am_);
			bool? ao_ = context.Operators.And(u_, an_);
			CqlDateTime ap_ = context.Operators.ConvertDateToDateTime(tuple_eoahgtwwdfqijhcjzqnvidvuo.FollowupKCCQ12Date);
			CqlDate aq_ = context.Operators.DateFrom(ap_);
			CqlDate as_ = context.Operators.DateFrom(v_);
			CqlQuantity at_ = context.Operators.Quantity(30m, "days");
			CqlDate au_ = context.Operators.Add(as_, at_);
			CqlDate aw_ = context.Operators.DateFrom(v_);
			CqlDate ay_ = context.Operators.Add(aw_, s_);
			CqlInterval<CqlDate> az_ = context.Operators.Interval(au_, ay_, true, true);
			bool? ba_ = context.Operators.In<CqlDate>(aq_, az_, "day");
			bool? bb_ = context.Operators.And(ao_, ba_);

			return bb_;
		};
		IEnumerable<Tuple_EOaHGTWWdfQIJhCjZQNViDVUO> h_ = context.Operators.Where<Tuple_EOaHGTWWdfQIJhCjZQNViDVUO>(f_, g_);
		Encounter i_(Tuple_EOaHGTWWdfQIJhCjZQNViDVUO tuple_eoahgtwwdfqijhcjzqnvidvuo) => 
			tuple_eoahgtwwdfqijhcjzqnvidvuo.ValidEncounters;
		IEnumerable<Encounter> j_ = context.Operators.Select<Tuple_EOaHGTWWdfQIJhCjZQNViDVUO, Encounter>(h_, i_);
		bool? k_ = context.Operators.Exists<Encounter>(j_);

		return k_;
	}

    /// <seealso cref="Has_Encounter_with_Initial_and_Follow_Up_KCCQ12_Assessments_Value"/>
    [CqlDeclaration("Has Encounter with Initial and Follow Up KCCQ12 Assessments")]
	public bool? Has_Encounter_with_Initial_and_Follow_Up_KCCQ12_Assessments() => 
		__Has_Encounter_with_Initial_and_Follow_Up_KCCQ12_Assessments.Value;

    /// <seealso cref="Date_KCCQ_Domain_Assessment_Completed"/>
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
		IEnumerable<ValueTuple<Observation, Observation, Observation, Observation, Observation, Observation>> y_ = context.Operators.CrossJoin<Observation, Observation, Observation, Observation, Observation, Observation>(d_, h_, l_, p_, t_, x_);
		Tuple_ETfcAWdPMcQFBNAYQdMDQQSdN z_(ValueTuple<Observation, Observation, Observation, Observation, Observation, Observation> _valueTuple)
		{
			Tuple_ETfcAWdPMcQFBNAYQdMDQQSdN af_ = new Tuple_ETfcAWdPMcQFBNAYQdMDQQSdN
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
		IEnumerable<Tuple_ETfcAWdPMcQFBNAYQdMDQQSdN> aa_ = context.Operators.Select<ValueTuple<Observation, Observation, Observation, Observation, Observation, Observation>, Tuple_ETfcAWdPMcQFBNAYQdMDQQSdN>(y_, z_);
		bool? ab_(Tuple_ETfcAWdPMcQFBNAYQdMDQQSdN tuple_etfcawdpmcqfbnayqdmdqqsdn)
		{
			DataType ag_ = tuple_etfcawdpmcqfbnayqdmdqqsdn.KCCQLifeQuality?.Effective;
			object ah_ = FHIRHelpers_4_3_000.ToValue(ag_);
			CqlInterval<CqlDateTime> ai_ = QICoreCommon_2_0_000.ToInterval(ah_);
			CqlDateTime aj_ = context.Operators.Start(ai_);
			CqlDate ak_ = context.Operators.DateFrom(aj_);
			DataType al_ = tuple_etfcawdpmcqfbnayqdmdqqsdn.KCCQSymptomStability?.Effective;
			object am_ = FHIRHelpers_4_3_000.ToValue(al_);
			CqlInterval<CqlDateTime> an_ = QICoreCommon_2_0_000.ToInterval(am_);
			CqlDateTime ao_ = context.Operators.Start(an_);
			CqlDate ap_ = context.Operators.DateFrom(ao_);
			bool? aq_ = context.Operators.SameAs(ak_, ap_, "day");
			DataType ar_ = tuple_etfcawdpmcqfbnayqdmdqqsdn.KCCQSymptomStability?.Value;
			object as_ = FHIRHelpers_4_3_000.ToValue(ar_);
			bool? at_ = context.Operators.Not((bool?)(as_ is null));
			bool? au_ = context.Operators.And(aq_, at_);
			object aw_ = FHIRHelpers_4_3_000.ToValue(ag_);
			CqlInterval<CqlDateTime> ax_ = QICoreCommon_2_0_000.ToInterval(aw_);
			CqlDateTime ay_ = context.Operators.Start(ax_);
			CqlDate az_ = context.Operators.DateFrom(ay_);
			DataType ba_ = tuple_etfcawdpmcqfbnayqdmdqqsdn.KCCQSelfEfficacy?.Effective;
			object bb_ = FHIRHelpers_4_3_000.ToValue(ba_);
			CqlInterval<CqlDateTime> bc_ = QICoreCommon_2_0_000.ToInterval(bb_);
			CqlDateTime bd_ = context.Operators.Start(bc_);
			CqlDate be_ = context.Operators.DateFrom(bd_);
			bool? bf_ = context.Operators.SameAs(az_, be_, "day");
			bool? bg_ = context.Operators.And(au_, bf_);
			DataType bh_ = tuple_etfcawdpmcqfbnayqdmdqqsdn.KCCQSelfEfficacy?.Value;
			object bi_ = FHIRHelpers_4_3_000.ToValue(bh_);
			bool? bj_ = context.Operators.Not((bool?)(bi_ is null));
			bool? bk_ = context.Operators.And(bg_, bj_);
			object bm_ = FHIRHelpers_4_3_000.ToValue(ag_);
			CqlInterval<CqlDateTime> bn_ = QICoreCommon_2_0_000.ToInterval(bm_);
			CqlDateTime bo_ = context.Operators.Start(bn_);
			CqlDate bp_ = context.Operators.DateFrom(bo_);
			DataType bq_ = tuple_etfcawdpmcqfbnayqdmdqqsdn.KCCQSymptoms?.Effective;
			object br_ = FHIRHelpers_4_3_000.ToValue(bq_);
			CqlInterval<CqlDateTime> bs_ = QICoreCommon_2_0_000.ToInterval(br_);
			CqlDateTime bt_ = context.Operators.Start(bs_);
			CqlDate bu_ = context.Operators.DateFrom(bt_);
			bool? bv_ = context.Operators.SameAs(bp_, bu_, "day");
			bool? bw_ = context.Operators.And(bk_, bv_);
			DataType bx_ = tuple_etfcawdpmcqfbnayqdmdqqsdn.KCCQSymptoms?.Value;
			object by_ = FHIRHelpers_4_3_000.ToValue(bx_);
			bool? bz_ = context.Operators.Not((bool?)(by_ is null));
			bool? ca_ = context.Operators.And(bw_, bz_);
			object cc_ = FHIRHelpers_4_3_000.ToValue(ag_);
			CqlInterval<CqlDateTime> cd_ = QICoreCommon_2_0_000.ToInterval(cc_);
			CqlDateTime ce_ = context.Operators.Start(cd_);
			CqlDate cf_ = context.Operators.DateFrom(ce_);
			DataType cg_ = tuple_etfcawdpmcqfbnayqdmdqqsdn.KCCQPhysicalLimits?.Effective;
			object ch_ = FHIRHelpers_4_3_000.ToValue(cg_);
			CqlInterval<CqlDateTime> ci_ = QICoreCommon_2_0_000.ToInterval(ch_);
			CqlDateTime cj_ = context.Operators.Start(ci_);
			CqlDate ck_ = context.Operators.DateFrom(cj_);
			bool? cl_ = context.Operators.SameAs(cf_, ck_, "day");
			bool? cm_ = context.Operators.And(ca_, cl_);
			DataType cn_ = tuple_etfcawdpmcqfbnayqdmdqqsdn.KCCQPhysicalLimits?.Value;
			object co_ = FHIRHelpers_4_3_000.ToValue(cn_);
			bool? cp_ = context.Operators.Not((bool?)(co_ is null));
			bool? cq_ = context.Operators.And(cm_, cp_);
			object cs_ = FHIRHelpers_4_3_000.ToValue(ag_);
			CqlInterval<CqlDateTime> ct_ = QICoreCommon_2_0_000.ToInterval(cs_);
			CqlDateTime cu_ = context.Operators.Start(ct_);
			CqlDate cv_ = context.Operators.DateFrom(cu_);
			DataType cw_ = tuple_etfcawdpmcqfbnayqdmdqqsdn.KCCQSocialLimits?.Effective;
			object cx_ = FHIRHelpers_4_3_000.ToValue(cw_);
			CqlInterval<CqlDateTime> cy_ = QICoreCommon_2_0_000.ToInterval(cx_);
			CqlDateTime cz_ = context.Operators.Start(cy_);
			CqlDate da_ = context.Operators.DateFrom(cz_);
			bool? db_ = context.Operators.SameAs(cv_, da_, "day");
			bool? dc_ = context.Operators.And(cq_, db_);
			DataType dd_ = tuple_etfcawdpmcqfbnayqdmdqqsdn.KCCQSocialLimits?.Value;
			object de_ = FHIRHelpers_4_3_000.ToValue(dd_);
			bool? df_ = context.Operators.Not((bool?)(de_ is null));
			bool? dg_ = context.Operators.And(dc_, df_);
			DataType dh_ = tuple_etfcawdpmcqfbnayqdmdqqsdn.KCCQLifeQuality?.Value;
			object di_ = FHIRHelpers_4_3_000.ToValue(dh_);
			bool? dj_ = context.Operators.Not((bool?)(di_ is null));
			bool? dk_ = context.Operators.And(dg_, dj_);

			return dk_;
		};
		IEnumerable<Tuple_ETfcAWdPMcQFBNAYQdMDQQSdN> ac_ = context.Operators.Where<Tuple_ETfcAWdPMcQFBNAYQdMDQQSdN>(aa_, ab_);
		CqlDate ad_(Tuple_ETfcAWdPMcQFBNAYQdMDQQSdN tuple_etfcawdpmcqfbnayqdmdqqsdn)
		{
			DataType dl_ = tuple_etfcawdpmcqfbnayqdmdqqsdn.KCCQLifeQuality?.Effective;
			object dm_ = FHIRHelpers_4_3_000.ToValue(dl_);
			CqlInterval<CqlDateTime> dn_ = QICoreCommon_2_0_000.ToInterval(dm_);
			CqlDateTime do_ = context.Operators.Start(dn_);
			CqlDate dp_ = context.Operators.DateFrom(do_);
			DataType dq_ = tuple_etfcawdpmcqfbnayqdmdqqsdn.KCCQSymptomStability?.Effective;
			object dr_ = FHIRHelpers_4_3_000.ToValue(dq_);
			CqlInterval<CqlDateTime> ds_ = QICoreCommon_2_0_000.ToInterval(dr_);
			CqlDateTime dt_ = context.Operators.Start(ds_);
			CqlDate du_ = context.Operators.DateFrom(dt_);
			DataType dv_ = tuple_etfcawdpmcqfbnayqdmdqqsdn.KCCQSelfEfficacy?.Effective;
			object dw_ = FHIRHelpers_4_3_000.ToValue(dv_);
			CqlInterval<CqlDateTime> dx_ = QICoreCommon_2_0_000.ToInterval(dw_);
			CqlDateTime dy_ = context.Operators.Start(dx_);
			CqlDate dz_ = context.Operators.DateFrom(dy_);
			DataType ea_ = tuple_etfcawdpmcqfbnayqdmdqqsdn.KCCQSymptoms?.Effective;
			object eb_ = FHIRHelpers_4_3_000.ToValue(ea_);
			CqlInterval<CqlDateTime> ec_ = QICoreCommon_2_0_000.ToInterval(eb_);
			CqlDateTime ed_ = context.Operators.Start(ec_);
			CqlDate ee_ = context.Operators.DateFrom(ed_);
			DataType ef_ = tuple_etfcawdpmcqfbnayqdmdqqsdn.KCCQPhysicalLimits?.Effective;
			object eg_ = FHIRHelpers_4_3_000.ToValue(ef_);
			CqlInterval<CqlDateTime> eh_ = QICoreCommon_2_0_000.ToInterval(eg_);
			CqlDateTime ei_ = context.Operators.Start(eh_);
			CqlDate ej_ = context.Operators.DateFrom(ei_);
			DataType ek_ = tuple_etfcawdpmcqfbnayqdmdqqsdn.KCCQSocialLimits?.Effective;
			object el_ = FHIRHelpers_4_3_000.ToValue(ek_);
			CqlInterval<CqlDateTime> em_ = QICoreCommon_2_0_000.ToInterval(el_);
			CqlDateTime en_ = context.Operators.Start(em_);
			CqlDate eo_ = context.Operators.DateFrom(en_);
			CqlDate[] ep_ = new CqlDate[]
			{
				dp_,
				du_,
				dz_,
				ee_,
				ej_,
				eo_,
			};
			CqlDate eq_ = context.Operators.Max<CqlDate>((ep_ as IEnumerable<CqlDate>));

			return eq_;
		};
		IEnumerable<CqlDate> ae_ = context.Operators.Select<Tuple_ETfcAWdPMcQFBNAYQdMDQQSdN, CqlDate>(ac_, ad_);

		return ae_;
	}

    /// <seealso cref="Date_KCCQ_Domain_Assessment_Completed_Value"/>
    [CqlDeclaration("Date KCCQ Domain Assessment Completed")]
	public IEnumerable<CqlDate> Date_KCCQ_Domain_Assessment_Completed() => 
		__Date_KCCQ_Domain_Assessment_Completed.Value;

    /// <seealso cref="Has_Encounter_with_Initial_and_Follow_Up_KCCQ_Domain_Score_Assessments"/>
	private bool? Has_Encounter_with_Initial_and_Follow_Up_KCCQ_Domain_Score_Assessments_Value()
	{
		IEnumerable<Encounter> a_ = this.Qualifying_Encounters();
		IEnumerable<CqlDate> b_ = this.Date_KCCQ_Domain_Assessment_Completed();
		IEnumerable<ValueTuple<Encounter, CqlDate, CqlDate>> d_ = context.Operators.CrossJoin<Encounter, CqlDate, CqlDate>(a_, b_, b_);
		Tuple_HRLUHbCfCSVNVRRNjajAHdcEA e_(ValueTuple<Encounter, CqlDate, CqlDate> _valueTuple)
		{
			Tuple_HRLUHbCfCSVNVRRNjajAHdcEA l_ = new Tuple_HRLUHbCfCSVNVRRNjajAHdcEA
			{
				ValidEncounters = _valueTuple.Item1,
				InitialKCCQAssessmentDate = _valueTuple.Item2,
				FollowupKCCQAssessmentDate = _valueTuple.Item3,
			};

			return l_;
		};
		IEnumerable<Tuple_HRLUHbCfCSVNVRRNjajAHdcEA> f_ = context.Operators.Select<ValueTuple<Encounter, CqlDate, CqlDate>, Tuple_HRLUHbCfCSVNVRRNjajAHdcEA>(d_, e_);
		bool? g_(Tuple_HRLUHbCfCSVNVRRNjajAHdcEA tuple_hrluhbcfcsvnvrrnjajahdcea)
		{
			Period m_ = tuple_hrluhbcfcsvnvrrnjajahdcea.ValidEncounters?.Period;
			CqlInterval<CqlDateTime> n_ = FHIRHelpers_4_3_000.ToInterval(m_);
			CqlInterval<CqlDateTime> o_ = QICoreCommon_2_0_000.ToInterval((n_ as object));
			CqlDateTime p_ = context.Operators.End(o_);
			CqlInterval<CqlDateTime> q_ = this.Measurement_Period();
			CqlDateTime r_ = context.Operators.End(q_);
			CqlQuantity s_ = context.Operators.Quantity(180m, "days");
			CqlDateTime t_ = context.Operators.Subtract(r_, s_);
			bool? u_ = context.Operators.SameOrBefore(p_, t_, "day");
			CqlDateTime v_ = context.Operators.ConvertDateToDateTime(tuple_hrluhbcfcsvnvrrnjajahdcea.InitialKCCQAssessmentDate);
			CqlInterval<CqlDateTime> x_ = FHIRHelpers_4_3_000.ToInterval(m_);
			CqlInterval<CqlDateTime> y_ = QICoreCommon_2_0_000.ToInterval((x_ as object));
			CqlDateTime z_ = context.Operators.End(y_);
			CqlQuantity aa_ = context.Operators.Quantity(14m, "days");
			CqlDateTime ab_ = context.Operators.Subtract(z_, aa_);
			CqlInterval<CqlDateTime> ad_ = FHIRHelpers_4_3_000.ToInterval(m_);
			CqlInterval<CqlDateTime> ae_ = QICoreCommon_2_0_000.ToInterval((ad_ as object));
			CqlDateTime af_ = context.Operators.End(ae_);
			CqlInterval<CqlDateTime> ag_ = context.Operators.Interval(ab_, af_, true, true);
			bool? ah_ = context.Operators.In<CqlDateTime>(v_, ag_, "day");
			CqlInterval<CqlDateTime> aj_ = FHIRHelpers_4_3_000.ToInterval(m_);
			CqlInterval<CqlDateTime> ak_ = QICoreCommon_2_0_000.ToInterval((aj_ as object));
			CqlDateTime al_ = context.Operators.End(ak_);
			bool? am_ = context.Operators.Not((bool?)(al_ is null));
			bool? an_ = context.Operators.And(ah_, am_);
			bool? ao_ = context.Operators.And(u_, an_);
			CqlDateTime ap_ = context.Operators.ConvertDateToDateTime(tuple_hrluhbcfcsvnvrrnjajahdcea.FollowupKCCQAssessmentDate);
			CqlDate aq_ = context.Operators.DateFrom(ap_);
			CqlDate as_ = context.Operators.DateFrom(v_);
			CqlQuantity at_ = context.Operators.Quantity(30m, "days");
			CqlDate au_ = context.Operators.Add(as_, at_);
			CqlDate aw_ = context.Operators.DateFrom(v_);
			CqlDate ay_ = context.Operators.Add(aw_, s_);
			CqlInterval<CqlDate> az_ = context.Operators.Interval(au_, ay_, true, true);
			bool? ba_ = context.Operators.In<CqlDate>(aq_, az_, "day");
			bool? bb_ = context.Operators.And(ao_, ba_);

			return bb_;
		};
		IEnumerable<Tuple_HRLUHbCfCSVNVRRNjajAHdcEA> h_ = context.Operators.Where<Tuple_HRLUHbCfCSVNVRRNjajAHdcEA>(f_, g_);
		Encounter i_(Tuple_HRLUHbCfCSVNVRRNjajAHdcEA tuple_hrluhbcfcsvnvrrnjajahdcea) => 
			tuple_hrluhbcfcsvnvrrnjajahdcea.ValidEncounters;
		IEnumerable<Encounter> j_ = context.Operators.Select<Tuple_HRLUHbCfCSVNVRRNjajAHdcEA, Encounter>(h_, i_);
		bool? k_ = context.Operators.Exists<Encounter>(j_);

		return k_;
	}

    /// <seealso cref="Has_Encounter_with_Initial_and_Follow_Up_KCCQ_Domain_Score_Assessments_Value"/>
    [CqlDeclaration("Has Encounter with Initial and Follow Up KCCQ Domain Score Assessments")]
	public bool? Has_Encounter_with_Initial_and_Follow_Up_KCCQ_Domain_Score_Assessments() => 
		__Has_Encounter_with_Initial_and_Follow_Up_KCCQ_Domain_Score_Assessments.Value;

    /// <seealso cref="Date_KCCQ_Total_Assessment_Completed"/>
	private IEnumerable<CqlDate> Date_KCCQ_Total_Assessment_Completed_Value()
	{
		CqlCode a_ = this.Overall_summary_score__KCCQ_();
		IEnumerable<CqlCode> b_ = context.Operators.ToList<CqlCode>(a_);
		IEnumerable<Observation> c_ = context.Operators.RetrieveByCodes<Observation>(b_, null);
		IEnumerable<Observation> d_ = Status_1_6_000.Final_Survey_Observation(c_);
		bool? e_(Observation KCCQSummaryScore)
		{
			DataType i_ = KCCQSummaryScore?.Value;
			object j_ = FHIRHelpers_4_3_000.ToValue(i_);
			bool? k_ = context.Operators.Not((bool?)(j_ is null));

			return k_;
		};
		IEnumerable<Observation> f_ = context.Operators.Where<Observation>(d_, e_);
		CqlDate g_(Observation KCCQSummaryScore)
		{
			DataType l_ = KCCQSummaryScore?.Effective;
			object m_ = FHIRHelpers_4_3_000.ToValue(l_);
			CqlInterval<CqlDateTime> n_ = QICoreCommon_2_0_000.ToInterval(m_);
			CqlDateTime o_ = context.Operators.Start(n_);
			CqlDate p_ = context.Operators.DateFrom(o_);
			CqlDate[] q_ = new CqlDate[]
			{
				p_,
			};
			CqlDate r_ = context.Operators.Max<CqlDate>((q_ as IEnumerable<CqlDate>));

			return r_;
		};
		IEnumerable<CqlDate> h_ = context.Operators.Select<Observation, CqlDate>(f_, g_);

		return h_;
	}

    /// <seealso cref="Date_KCCQ_Total_Assessment_Completed_Value"/>
    [CqlDeclaration("Date KCCQ Total Assessment Completed")]
	public IEnumerable<CqlDate> Date_KCCQ_Total_Assessment_Completed() => 
		__Date_KCCQ_Total_Assessment_Completed.Value;

    /// <seealso cref="Has_Encounter_with_Initial_and_Follow_Up_KCCQ_Total_Score_Assessments"/>
	private bool? Has_Encounter_with_Initial_and_Follow_Up_KCCQ_Total_Score_Assessments_Value()
	{
		IEnumerable<Encounter> a_ = this.Qualifying_Encounters();
		IEnumerable<CqlDate> b_ = this.Date_KCCQ_Total_Assessment_Completed();
		IEnumerable<ValueTuple<Encounter, CqlDate, CqlDate>> d_ = context.Operators.CrossJoin<Encounter, CqlDate, CqlDate>(a_, b_, b_);
		Tuple_DGROjeEKDVIZSVYiSEPDjhJgj e_(ValueTuple<Encounter, CqlDate, CqlDate> _valueTuple)
		{
			Tuple_DGROjeEKDVIZSVYiSEPDjhJgj l_ = new Tuple_DGROjeEKDVIZSVYiSEPDjhJgj
			{
				ValidEncounters = _valueTuple.Item1,
				InitialKCCQTotalScore = _valueTuple.Item2,
				FollowupKCCQTotalScore = _valueTuple.Item3,
			};

			return l_;
		};
		IEnumerable<Tuple_DGROjeEKDVIZSVYiSEPDjhJgj> f_ = context.Operators.Select<ValueTuple<Encounter, CqlDate, CqlDate>, Tuple_DGROjeEKDVIZSVYiSEPDjhJgj>(d_, e_);
		bool? g_(Tuple_DGROjeEKDVIZSVYiSEPDjhJgj tuple_dgrojeekdvizsvyisepdjhjgj)
		{
			Period m_ = tuple_dgrojeekdvizsvyisepdjhjgj.ValidEncounters?.Period;
			CqlInterval<CqlDateTime> n_ = FHIRHelpers_4_3_000.ToInterval(m_);
			CqlInterval<CqlDateTime> o_ = QICoreCommon_2_0_000.ToInterval((n_ as object));
			CqlDateTime p_ = context.Operators.End(o_);
			CqlInterval<CqlDateTime> q_ = this.Measurement_Period();
			CqlDateTime r_ = context.Operators.End(q_);
			CqlQuantity s_ = context.Operators.Quantity(180m, "days");
			CqlDateTime t_ = context.Operators.Subtract(r_, s_);
			bool? u_ = context.Operators.SameOrBefore(p_, t_, "day");
			CqlDateTime v_ = context.Operators.ConvertDateToDateTime(tuple_dgrojeekdvizsvyisepdjhjgj.InitialKCCQTotalScore);
			CqlInterval<CqlDateTime> x_ = FHIRHelpers_4_3_000.ToInterval(m_);
			CqlInterval<CqlDateTime> y_ = QICoreCommon_2_0_000.ToInterval((x_ as object));
			CqlDateTime z_ = context.Operators.End(y_);
			CqlQuantity aa_ = context.Operators.Quantity(14m, "days");
			CqlDateTime ab_ = context.Operators.Subtract(z_, aa_);
			CqlInterval<CqlDateTime> ad_ = FHIRHelpers_4_3_000.ToInterval(m_);
			CqlInterval<CqlDateTime> ae_ = QICoreCommon_2_0_000.ToInterval((ad_ as object));
			CqlDateTime af_ = context.Operators.End(ae_);
			CqlInterval<CqlDateTime> ag_ = context.Operators.Interval(ab_, af_, true, true);
			bool? ah_ = context.Operators.In<CqlDateTime>(v_, ag_, "day");
			CqlInterval<CqlDateTime> aj_ = FHIRHelpers_4_3_000.ToInterval(m_);
			CqlInterval<CqlDateTime> ak_ = QICoreCommon_2_0_000.ToInterval((aj_ as object));
			CqlDateTime al_ = context.Operators.End(ak_);
			bool? am_ = context.Operators.Not((bool?)(al_ is null));
			bool? an_ = context.Operators.And(ah_, am_);
			bool? ao_ = context.Operators.And(u_, an_);
			CqlDateTime ap_ = context.Operators.ConvertDateToDateTime(tuple_dgrojeekdvizsvyisepdjhjgj.FollowupKCCQTotalScore);
			CqlDate aq_ = context.Operators.DateFrom(ap_);
			CqlDate as_ = context.Operators.DateFrom(v_);
			CqlQuantity at_ = context.Operators.Quantity(30m, "days");
			CqlDate au_ = context.Operators.Add(as_, at_);
			CqlDate aw_ = context.Operators.DateFrom(v_);
			CqlDate ay_ = context.Operators.Add(aw_, s_);
			CqlInterval<CqlDate> az_ = context.Operators.Interval(au_, ay_, true, true);
			bool? ba_ = context.Operators.In<CqlDate>(aq_, az_, "day");
			bool? bb_ = context.Operators.And(ao_, ba_);

			return bb_;
		};
		IEnumerable<Tuple_DGROjeEKDVIZSVYiSEPDjhJgj> h_ = context.Operators.Where<Tuple_DGROjeEKDVIZSVYiSEPDjhJgj>(f_, g_);
		Encounter i_(Tuple_DGROjeEKDVIZSVYiSEPDjhJgj tuple_dgrojeekdvizsvyisepdjhjgj) => 
			tuple_dgrojeekdvizsvyisepdjhjgj.ValidEncounters;
		IEnumerable<Encounter> j_ = context.Operators.Select<Tuple_DGROjeEKDVIZSVYiSEPDjhJgj, Encounter>(h_, i_);
		bool? k_ = context.Operators.Exists<Encounter>(j_);

		return k_;
	}

    /// <seealso cref="Has_Encounter_with_Initial_and_Follow_Up_KCCQ_Total_Score_Assessments_Value"/>
    [CqlDeclaration("Has Encounter with Initial and Follow Up KCCQ Total Score Assessments")]
	public bool? Has_Encounter_with_Initial_and_Follow_Up_KCCQ_Total_Score_Assessments() => 
		__Has_Encounter_with_Initial_and_Follow_Up_KCCQ_Total_Score_Assessments.Value;

    /// <seealso cref="Numerator"/>
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

    /// <seealso cref="Numerator_Value"/>
    [CqlDeclaration("Numerator")]
	public bool? Numerator() => 
		__Numerator.Value;

}
