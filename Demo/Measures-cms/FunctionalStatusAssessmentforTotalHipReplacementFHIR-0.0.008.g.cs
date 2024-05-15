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
[CqlLibrary("FunctionalStatusAssessmentforTotalHipReplacementFHIR", "0.0.008")]
public class FunctionalStatusAssessmentforTotalHipReplacementFHIR_0_0_008
{


    internal CqlContext context;

    #region Cached values

    internal Lazy<CqlValueSet> __Encounter_Inpatient;
    internal Lazy<CqlValueSet> __Ethnicity;
    internal Lazy<CqlValueSet> __Lower_Body_Fractures_Excluding_Ankle_and_Foot;
    internal Lazy<CqlValueSet> __Malignant_Neoplasms_of_Lower_and_Unspecified_Limbs;
    internal Lazy<CqlValueSet> __Mechanical_Complications_Excluding_Upper_Body;
    internal Lazy<CqlValueSet> __Office_Visit;
    internal Lazy<CqlValueSet> __ONC_Administrative_Sex;
    internal Lazy<CqlValueSet> __Online_Assessments;
    internal Lazy<CqlValueSet> __Outpatient_Consultation;
    internal Lazy<CqlValueSet> __Partial_Arthroplasty_of_Hip;
    internal Lazy<CqlValueSet> __Payer;
    internal Lazy<CqlValueSet> __Primary_THA_Procedure;
    internal Lazy<CqlValueSet> __Race;
    internal Lazy<CqlValueSet> __Removal__Revision_and_Supplement_Procedures_of_the_Lower_Body_and_Spine;
    internal Lazy<CqlValueSet> __Telephone_Visits;
    internal Lazy<CqlCode> __Activities_of_daily_living_score__HOOS_;
    internal Lazy<CqlCode> __Dead__finding_;
    internal Lazy<CqlCode> __Discharge_to_healthcare_facility_for_hospice_care__procedure_;
    internal Lazy<CqlCode> __Discharge_to_home_for_hospice_care__procedure_;
    internal Lazy<CqlCode> __Hospice_care__Minimum_Data_Set_;
    internal Lazy<CqlCode> __Pain_score__HOOS_;
    internal Lazy<CqlCode> __Postoperative_follow_up_visit__normally_included_in_the_surgical_package__to_indicate_that_an_evaluation_and_management_service_was_performed_during_a_postoperative_period_for_a_reason_s__related_to_the_original_procedure;
    internal Lazy<CqlCode> __PROMIS_10_Global_Mental_Health__GMH__score_T_score;
    internal Lazy<CqlCode> __PROMIS_10_Global_Physical_Health__GPH__score_T_score;
    internal Lazy<CqlCode> __Quality_of_life_score__HOOS_;
    internal Lazy<CqlCode> __Severe_cognitive_impairment__finding_;
    internal Lazy<CqlCode> __Sport_recreation_score__HOOS_;
    internal Lazy<CqlCode> __survey;
    internal Lazy<CqlCode> __Symptoms_score__HOOS_;
    internal Lazy<CqlCode> __Total_interval_score__HOOSJR_;
    internal Lazy<CqlCode> __VR_12_Mental_component_summary__MCS__score___oblique_method_T_score;
    internal Lazy<CqlCode> __VR_12_Mental_component_summary__MCS__score___orthogonal_method_T_score;
    internal Lazy<CqlCode> __VR_12_Physical_component_summary__PCS__score___oblique_method_T_score;
    internal Lazy<CqlCode> __VR_12_Physical_component_summary__PCS__score___orthogonal_method_T_score;
    internal Lazy<CqlCode> __Yes__qualifier_value_;
    internal Lazy<CqlCode[]> __LOINC;
    internal Lazy<CqlCode[]> __CPT;
    internal Lazy<CqlCode[]> __ConditionCategoryCodes;
    internal Lazy<CqlCode[]> __SNOMEDCT;
    internal Lazy<CqlCode[]> __ObservationCategoryCodes;
    internal Lazy<CqlInterval<CqlDateTime>> __Measurement_Period;
    internal Lazy<Patient> __Patient;
    internal Lazy<Tuple_HPcCiDPXQfZTXIORThMLfTQDR> __SDE_Ethnicity;
    internal Lazy<IEnumerable<Tuple_GPRWMPNAYaJRiGDFSTLJOPeIJ>> __SDE_Payer;
    internal Lazy<Tuple_HPcCiDPXQfZTXIORThMLfTQDR> __SDE_Race;
    internal Lazy<CqlCode> __SDE_Sex;
    internal Lazy<CqlDateTime> __November_1_Year_Prior_to_the_Measurement_Period;
    internal Lazy<bool?> __Has_Qualifying_Encounter;
    internal Lazy<CqlDateTime> __November_1_Two_Years_Prior_to_the_Measurement_Period;
    internal Lazy<CqlDateTime> __October_31_Year_Prior_to_the_Measurement_Period;
    internal Lazy<IEnumerable<Procedure>> __Total_Hip_Arthroplasty_Procedure;
    internal Lazy<bool?> __Initial_Population;
    internal Lazy<bool?> __Denominator;
    internal Lazy<bool?> __Has_Severe_Cognitive_Impairment;
    internal Lazy<bool?> __Has_Total_Hip_Arthroplasty_with_1_or_More_Lower_Body_Fractures;
    internal Lazy<bool?> __Has_Partial_Hip_Arthroplasty_Procedure;
    internal Lazy<bool?> __Has_Revision_Hip_Arthroplasty_Procedure_or_Implanted_Device_or_Prosthesis_Removal_Procedure;
    internal Lazy<bool?> __Has_Malignant_Neoplasm_of_Lower_and_Unspecified_Limbs;
    internal Lazy<bool?> __Has_Mechanical_Complication;
    internal Lazy<bool?> __Has_More_Than_One_Elective_Primary_Total_Hip_Arthroplasty_Performed;
    internal Lazy<bool?> __Death_Within_300_Days_of_the_THA_Procedure;
    internal Lazy<bool?> __Denominator_Exclusions;
    internal Lazy<IEnumerable<CqlDate>> __Date_HOOS_Total_Assessment_Completed;
    internal Lazy<bool?> __Has_THA_with_Initial_and_Follow_Up_HOOS_Assessments;
    internal Lazy<IEnumerable<CqlDate>> __Date_HOOSJr_Total_Assessment_Completed;
    internal Lazy<bool?> __Has_THA_with_Initial_and_Follow_Up_HOOSJr_Assessments;
    internal Lazy<IEnumerable<CqlDate>> __Date_PROMIS10_Total_Assessment_Completed;
    internal Lazy<bool?> __Has_THA_with_Initial_and_Follow_Up_PROMIS10_Assessments;
    internal Lazy<IEnumerable<CqlDate>> __Date_VR12_Oblique_Total_Assessment_Completed;
    internal Lazy<bool?> __Has_THA_with_Initial_and_Follow_Up_VR12_Oblique_Assessments;
    internal Lazy<IEnumerable<CqlDate>> __Date_VR12_Orthogonal_Total_Assessment_Completed;
    internal Lazy<bool?> __Has_THA_with_Initial_and_Follow_Up_VR12_Orthogonal_Assessments;
    internal Lazy<bool?> __Numerator;

    #endregion
    public FunctionalStatusAssessmentforTotalHipReplacementFHIR_0_0_008(CqlContext context)
    {
        this.context = context ?? throw new ArgumentNullException("context");

        FHIRHelpers_4_3_000 = new FHIRHelpers_4_3_000(context);
        QICoreCommon_2_0_000 = new QICoreCommon_2_0_000(context);
        SupplementalDataElements_3_4_000 = new SupplementalDataElements_3_4_000(context);
        CQMCommon_2_0_000 = new CQMCommon_2_0_000(context);
        Hospice_6_9_000 = new Hospice_6_9_000(context);
        Status_1_6_000 = new Status_1_6_000(context);

        __Encounter_Inpatient = new Lazy<CqlValueSet>(this.Encounter_Inpatient_Value);
        __Ethnicity = new Lazy<CqlValueSet>(this.Ethnicity_Value);
        __Lower_Body_Fractures_Excluding_Ankle_and_Foot = new Lazy<CqlValueSet>(this.Lower_Body_Fractures_Excluding_Ankle_and_Foot_Value);
        __Malignant_Neoplasms_of_Lower_and_Unspecified_Limbs = new Lazy<CqlValueSet>(this.Malignant_Neoplasms_of_Lower_and_Unspecified_Limbs_Value);
        __Mechanical_Complications_Excluding_Upper_Body = new Lazy<CqlValueSet>(this.Mechanical_Complications_Excluding_Upper_Body_Value);
        __Office_Visit = new Lazy<CqlValueSet>(this.Office_Visit_Value);
        __ONC_Administrative_Sex = new Lazy<CqlValueSet>(this.ONC_Administrative_Sex_Value);
        __Online_Assessments = new Lazy<CqlValueSet>(this.Online_Assessments_Value);
        __Outpatient_Consultation = new Lazy<CqlValueSet>(this.Outpatient_Consultation_Value);
        __Partial_Arthroplasty_of_Hip = new Lazy<CqlValueSet>(this.Partial_Arthroplasty_of_Hip_Value);
        __Payer = new Lazy<CqlValueSet>(this.Payer_Value);
        __Primary_THA_Procedure = new Lazy<CqlValueSet>(this.Primary_THA_Procedure_Value);
        __Race = new Lazy<CqlValueSet>(this.Race_Value);
        __Removal__Revision_and_Supplement_Procedures_of_the_Lower_Body_and_Spine = new Lazy<CqlValueSet>(this.Removal__Revision_and_Supplement_Procedures_of_the_Lower_Body_and_Spine_Value);
        __Telephone_Visits = new Lazy<CqlValueSet>(this.Telephone_Visits_Value);
        __Activities_of_daily_living_score__HOOS_ = new Lazy<CqlCode>(this.Activities_of_daily_living_score__HOOS__Value);
        __Dead__finding_ = new Lazy<CqlCode>(this.Dead__finding__Value);
        __Discharge_to_healthcare_facility_for_hospice_care__procedure_ = new Lazy<CqlCode>(this.Discharge_to_healthcare_facility_for_hospice_care__procedure__Value);
        __Discharge_to_home_for_hospice_care__procedure_ = new Lazy<CqlCode>(this.Discharge_to_home_for_hospice_care__procedure__Value);
        __Hospice_care__Minimum_Data_Set_ = new Lazy<CqlCode>(this.Hospice_care__Minimum_Data_Set__Value);
        __Pain_score__HOOS_ = new Lazy<CqlCode>(this.Pain_score__HOOS__Value);
        __Postoperative_follow_up_visit__normally_included_in_the_surgical_package__to_indicate_that_an_evaluation_and_management_service_was_performed_during_a_postoperative_period_for_a_reason_s__related_to_the_original_procedure = new Lazy<CqlCode>(this.Postoperative_follow_up_visit__normally_included_in_the_surgical_package__to_indicate_that_an_evaluation_and_management_service_was_performed_during_a_postoperative_period_for_a_reason_s__related_to_the_original_procedure_Value);
        __PROMIS_10_Global_Mental_Health__GMH__score_T_score = new Lazy<CqlCode>(this.PROMIS_10_Global_Mental_Health__GMH__score_T_score_Value);
        __PROMIS_10_Global_Physical_Health__GPH__score_T_score = new Lazy<CqlCode>(this.PROMIS_10_Global_Physical_Health__GPH__score_T_score_Value);
        __Quality_of_life_score__HOOS_ = new Lazy<CqlCode>(this.Quality_of_life_score__HOOS__Value);
        __Severe_cognitive_impairment__finding_ = new Lazy<CqlCode>(this.Severe_cognitive_impairment__finding__Value);
        __Sport_recreation_score__HOOS_ = new Lazy<CqlCode>(this.Sport_recreation_score__HOOS__Value);
        __survey = new Lazy<CqlCode>(this.survey_Value);
        __Symptoms_score__HOOS_ = new Lazy<CqlCode>(this.Symptoms_score__HOOS__Value);
        __Total_interval_score__HOOSJR_ = new Lazy<CqlCode>(this.Total_interval_score__HOOSJR__Value);
        __VR_12_Mental_component_summary__MCS__score___oblique_method_T_score = new Lazy<CqlCode>(this.VR_12_Mental_component_summary__MCS__score___oblique_method_T_score_Value);
        __VR_12_Mental_component_summary__MCS__score___orthogonal_method_T_score = new Lazy<CqlCode>(this.VR_12_Mental_component_summary__MCS__score___orthogonal_method_T_score_Value);
        __VR_12_Physical_component_summary__PCS__score___oblique_method_T_score = new Lazy<CqlCode>(this.VR_12_Physical_component_summary__PCS__score___oblique_method_T_score_Value);
        __VR_12_Physical_component_summary__PCS__score___orthogonal_method_T_score = new Lazy<CqlCode>(this.VR_12_Physical_component_summary__PCS__score___orthogonal_method_T_score_Value);
        __Yes__qualifier_value_ = new Lazy<CqlCode>(this.Yes__qualifier_value__Value);
        __LOINC = new Lazy<CqlCode[]>(this.LOINC_Value);
        __CPT = new Lazy<CqlCode[]>(this.CPT_Value);
        __ConditionCategoryCodes = new Lazy<CqlCode[]>(this.ConditionCategoryCodes_Value);
        __SNOMEDCT = new Lazy<CqlCode[]>(this.SNOMEDCT_Value);
        __ObservationCategoryCodes = new Lazy<CqlCode[]>(this.ObservationCategoryCodes_Value);
        __Measurement_Period = new Lazy<CqlInterval<CqlDateTime>>(this.Measurement_Period_Value);
        __Patient = new Lazy<Patient>(this.Patient_Value);
        __SDE_Ethnicity = new Lazy<Tuple_HPcCiDPXQfZTXIORThMLfTQDR>(this.SDE_Ethnicity_Value);
        __SDE_Payer = new Lazy<IEnumerable<Tuple_GPRWMPNAYaJRiGDFSTLJOPeIJ>>(this.SDE_Payer_Value);
        __SDE_Race = new Lazy<Tuple_HPcCiDPXQfZTXIORThMLfTQDR>(this.SDE_Race_Value);
        __SDE_Sex = new Lazy<CqlCode>(this.SDE_Sex_Value);
        __November_1_Year_Prior_to_the_Measurement_Period = new Lazy<CqlDateTime>(this.November_1_Year_Prior_to_the_Measurement_Period_Value);
        __Has_Qualifying_Encounter = new Lazy<bool?>(this.Has_Qualifying_Encounter_Value);
        __November_1_Two_Years_Prior_to_the_Measurement_Period = new Lazy<CqlDateTime>(this.November_1_Two_Years_Prior_to_the_Measurement_Period_Value);
        __October_31_Year_Prior_to_the_Measurement_Period = new Lazy<CqlDateTime>(this.October_31_Year_Prior_to_the_Measurement_Period_Value);
        __Total_Hip_Arthroplasty_Procedure = new Lazy<IEnumerable<Procedure>>(this.Total_Hip_Arthroplasty_Procedure_Value);
        __Initial_Population = new Lazy<bool?>(this.Initial_Population_Value);
        __Denominator = new Lazy<bool?>(this.Denominator_Value);
        __Has_Severe_Cognitive_Impairment = new Lazy<bool?>(this.Has_Severe_Cognitive_Impairment_Value);
        __Has_Total_Hip_Arthroplasty_with_1_or_More_Lower_Body_Fractures = new Lazy<bool?>(this.Has_Total_Hip_Arthroplasty_with_1_or_More_Lower_Body_Fractures_Value);
        __Has_Partial_Hip_Arthroplasty_Procedure = new Lazy<bool?>(this.Has_Partial_Hip_Arthroplasty_Procedure_Value);
        __Has_Revision_Hip_Arthroplasty_Procedure_or_Implanted_Device_or_Prosthesis_Removal_Procedure = new Lazy<bool?>(this.Has_Revision_Hip_Arthroplasty_Procedure_or_Implanted_Device_or_Prosthesis_Removal_Procedure_Value);
        __Has_Malignant_Neoplasm_of_Lower_and_Unspecified_Limbs = new Lazy<bool?>(this.Has_Malignant_Neoplasm_of_Lower_and_Unspecified_Limbs_Value);
        __Has_Mechanical_Complication = new Lazy<bool?>(this.Has_Mechanical_Complication_Value);
        __Has_More_Than_One_Elective_Primary_Total_Hip_Arthroplasty_Performed = new Lazy<bool?>(this.Has_More_Than_One_Elective_Primary_Total_Hip_Arthroplasty_Performed_Value);
        __Death_Within_300_Days_of_the_THA_Procedure = new Lazy<bool?>(this.Death_Within_300_Days_of_the_THA_Procedure_Value);
        __Denominator_Exclusions = new Lazy<bool?>(this.Denominator_Exclusions_Value);
        __Date_HOOS_Total_Assessment_Completed = new Lazy<IEnumerable<CqlDate>>(this.Date_HOOS_Total_Assessment_Completed_Value);
        __Has_THA_with_Initial_and_Follow_Up_HOOS_Assessments = new Lazy<bool?>(this.Has_THA_with_Initial_and_Follow_Up_HOOS_Assessments_Value);
        __Date_HOOSJr_Total_Assessment_Completed = new Lazy<IEnumerable<CqlDate>>(this.Date_HOOSJr_Total_Assessment_Completed_Value);
        __Has_THA_with_Initial_and_Follow_Up_HOOSJr_Assessments = new Lazy<bool?>(this.Has_THA_with_Initial_and_Follow_Up_HOOSJr_Assessments_Value);
        __Date_PROMIS10_Total_Assessment_Completed = new Lazy<IEnumerable<CqlDate>>(this.Date_PROMIS10_Total_Assessment_Completed_Value);
        __Has_THA_with_Initial_and_Follow_Up_PROMIS10_Assessments = new Lazy<bool?>(this.Has_THA_with_Initial_and_Follow_Up_PROMIS10_Assessments_Value);
        __Date_VR12_Oblique_Total_Assessment_Completed = new Lazy<IEnumerable<CqlDate>>(this.Date_VR12_Oblique_Total_Assessment_Completed_Value);
        __Has_THA_with_Initial_and_Follow_Up_VR12_Oblique_Assessments = new Lazy<bool?>(this.Has_THA_with_Initial_and_Follow_Up_VR12_Oblique_Assessments_Value);
        __Date_VR12_Orthogonal_Total_Assessment_Completed = new Lazy<IEnumerable<CqlDate>>(this.Date_VR12_Orthogonal_Total_Assessment_Completed_Value);
        __Has_THA_with_Initial_and_Follow_Up_VR12_Orthogonal_Assessments = new Lazy<bool?>(this.Has_THA_with_Initial_and_Follow_Up_VR12_Orthogonal_Assessments_Value);
        __Numerator = new Lazy<bool?>(this.Numerator_Value);
    }
    #region Dependencies

    public FHIRHelpers_4_3_000 FHIRHelpers_4_3_000 { get; }
    public QICoreCommon_2_0_000 QICoreCommon_2_0_000 { get; }
    public SupplementalDataElements_3_4_000 SupplementalDataElements_3_4_000 { get; }
    public CQMCommon_2_0_000 CQMCommon_2_0_000 { get; }
    public Hospice_6_9_000 Hospice_6_9_000 { get; }
    public Status_1_6_000 Status_1_6_000 { get; }

    #endregion

	private CqlValueSet Encounter_Inpatient_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.666.5.307", null);

    [CqlDeclaration("Encounter Inpatient")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.666.5.307")]
	public CqlValueSet Encounter_Inpatient() => 
		__Encounter_Inpatient.Value;

	private CqlValueSet Ethnicity_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.114222.4.11.837", null);

    [CqlDeclaration("Ethnicity")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.114222.4.11.837")]
	public CqlValueSet Ethnicity() => 
		__Ethnicity.Value;

	private CqlValueSet Lower_Body_Fractures_Excluding_Ankle_and_Foot_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.1178", null);

    [CqlDeclaration("Lower Body Fractures Excluding Ankle and Foot")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.1178")]
	public CqlValueSet Lower_Body_Fractures_Excluding_Ankle_and_Foot() => 
		__Lower_Body_Fractures_Excluding_Ankle_and_Foot.Value;

	private CqlValueSet Malignant_Neoplasms_of_Lower_and_Unspecified_Limbs_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.1180", null);

    [CqlDeclaration("Malignant Neoplasms of Lower and Unspecified Limbs")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.1180")]
	public CqlValueSet Malignant_Neoplasms_of_Lower_and_Unspecified_Limbs() => 
		__Malignant_Neoplasms_of_Lower_and_Unspecified_Limbs.Value;

	private CqlValueSet Mechanical_Complications_Excluding_Upper_Body_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.1182", null);

    [CqlDeclaration("Mechanical Complications Excluding Upper Body")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.1182")]
	public CqlValueSet Mechanical_Complications_Excluding_Upper_Body() => 
		__Mechanical_Complications_Excluding_Upper_Body.Value;

	private CqlValueSet Office_Visit_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1001", null);

    [CqlDeclaration("Office Visit")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1001")]
	public CqlValueSet Office_Visit() => 
		__Office_Visit.Value;

	private CqlValueSet ONC_Administrative_Sex_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1", null);

    [CqlDeclaration("ONC Administrative Sex")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1")]
	public CqlValueSet ONC_Administrative_Sex() => 
		__ONC_Administrative_Sex.Value;

	private CqlValueSet Online_Assessments_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1089", null);

    [CqlDeclaration("Online Assessments")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1089")]
	public CqlValueSet Online_Assessments() => 
		__Online_Assessments.Value;

	private CqlValueSet Outpatient_Consultation_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1008", null);

    [CqlDeclaration("Outpatient Consultation")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1008")]
	public CqlValueSet Outpatient_Consultation() => 
		__Outpatient_Consultation.Value;

	private CqlValueSet Partial_Arthroplasty_of_Hip_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.1184", null);

    [CqlDeclaration("Partial Arthroplasty of Hip")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.1184")]
	public CqlValueSet Partial_Arthroplasty_of_Hip() => 
		__Partial_Arthroplasty_of_Hip.Value;

	private CqlValueSet Payer_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.114222.4.11.3591", null);

    [CqlDeclaration("Payer")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.114222.4.11.3591")]
	public CqlValueSet Payer() => 
		__Payer.Value;

	private CqlValueSet Primary_THA_Procedure_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.198.12.1006", null);

    [CqlDeclaration("Primary THA Procedure")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.198.12.1006")]
	public CqlValueSet Primary_THA_Procedure() => 
		__Primary_THA_Procedure.Value;

	private CqlValueSet Race_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.114222.4.11.836", null);

    [CqlDeclaration("Race")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.114222.4.11.836")]
	public CqlValueSet Race() => 
		__Race.Value;

	private CqlValueSet Removal__Revision_and_Supplement_Procedures_of_the_Lower_Body_and_Spine_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.1189", null);

    [CqlDeclaration("Removal, Revision and Supplement Procedures of the Lower Body and Spine")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.1189")]
	public CqlValueSet Removal__Revision_and_Supplement_Procedures_of_the_Lower_Body_and_Spine() => 
		__Removal__Revision_and_Supplement_Procedures_of_the_Lower_Body_and_Spine.Value;

	private CqlValueSet Telephone_Visits_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1080", null);

    [CqlDeclaration("Telephone Visits")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1080")]
	public CqlValueSet Telephone_Visits() => 
		__Telephone_Visits.Value;

	private CqlCode Activities_of_daily_living_score__HOOS__Value() => 
		new CqlCode("72095-3", "http://loinc.org", null, null);

    [CqlDeclaration("Activities of daily living score [HOOS]")]
	public CqlCode Activities_of_daily_living_score__HOOS_() => 
		__Activities_of_daily_living_score__HOOS_.Value;

	private CqlCode Dead__finding__Value() => 
		new CqlCode("419099009", "http://snomed.info/sct", null, null);

    [CqlDeclaration("Dead (finding)")]
	public CqlCode Dead__finding_() => 
		__Dead__finding_.Value;

	private CqlCode Discharge_to_healthcare_facility_for_hospice_care__procedure__Value() => 
		new CqlCode("428371000124100", "http://snomed.info/sct", null, null);

    [CqlDeclaration("Discharge to healthcare facility for hospice care (procedure)")]
	public CqlCode Discharge_to_healthcare_facility_for_hospice_care__procedure_() => 
		__Discharge_to_healthcare_facility_for_hospice_care__procedure_.Value;

	private CqlCode Discharge_to_home_for_hospice_care__procedure__Value() => 
		new CqlCode("428371000124100", "http://snomed.info/sct", null, null);

    [CqlDeclaration("Discharge to home for hospice care (procedure)")]
	public CqlCode Discharge_to_home_for_hospice_care__procedure_() => 
		__Discharge_to_home_for_hospice_care__procedure_.Value;

	private CqlCode Hospice_care__Minimum_Data_Set__Value() => 
		new CqlCode("45755-6", "http://loinc.org", null, null);

    [CqlDeclaration("Hospice care [Minimum Data Set]")]
	public CqlCode Hospice_care__Minimum_Data_Set_() => 
		__Hospice_care__Minimum_Data_Set_.Value;

	private CqlCode Pain_score__HOOS__Value() => 
		new CqlCode("72097-9", "http://loinc.org", null, null);

    [CqlDeclaration("Pain score [HOOS]")]
	public CqlCode Pain_score__HOOS_() => 
		__Pain_score__HOOS_.Value;

	private CqlCode Postoperative_follow_up_visit__normally_included_in_the_surgical_package__to_indicate_that_an_evaluation_and_management_service_was_performed_during_a_postoperative_period_for_a_reason_s__related_to_the_original_procedure_Value() => 
		new CqlCode("99024", "http://www.ama-assn.org/go/cpt", null, null);

    [CqlDeclaration("Postoperative follow-up visit, normally included in the surgical package, to indicate that an evaluation and management service was performed during a postoperative period for a reason(s) related to the original procedure")]
	public CqlCode Postoperative_follow_up_visit__normally_included_in_the_surgical_package__to_indicate_that_an_evaluation_and_management_service_was_performed_during_a_postoperative_period_for_a_reason_s__related_to_the_original_procedure() => 
		__Postoperative_follow_up_visit__normally_included_in_the_surgical_package__to_indicate_that_an_evaluation_and_management_service_was_performed_during_a_postoperative_period_for_a_reason_s__related_to_the_original_procedure.Value;

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

	private CqlCode Quality_of_life_score__HOOS__Value() => 
		new CqlCode("72093-8", "http://loinc.org", null, null);

    [CqlDeclaration("Quality of life score [HOOS]")]
	public CqlCode Quality_of_life_score__HOOS_() => 
		__Quality_of_life_score__HOOS_.Value;

	private CqlCode Severe_cognitive_impairment__finding__Value() => 
		new CqlCode("702956004", "http://snomed.info/sct", null, null);

    [CqlDeclaration("Severe cognitive impairment (finding)")]
	public CqlCode Severe_cognitive_impairment__finding_() => 
		__Severe_cognitive_impairment__finding_.Value;

	private CqlCode Sport_recreation_score__HOOS__Value() => 
		new CqlCode("72094-6", "http://loinc.org", null, null);

    [CqlDeclaration("Sport-recreation score [HOOS]")]
	public CqlCode Sport_recreation_score__HOOS_() => 
		__Sport_recreation_score__HOOS_.Value;

	private CqlCode survey_Value() => 
		new CqlCode("survey", "http://terminology.hl7.org/CodeSystem/v3-ObservationCategory", null, null);

    [CqlDeclaration("survey")]
	public CqlCode survey() => 
		__survey.Value;

	private CqlCode Symptoms_score__HOOS__Value() => 
		new CqlCode("72096-1", "http://loinc.org", null, null);

    [CqlDeclaration("Symptoms score [HOOS]")]
	public CqlCode Symptoms_score__HOOS_() => 
		__Symptoms_score__HOOS_.Value;

	private CqlCode Total_interval_score__HOOSJR__Value() => 
		new CqlCode("82323-7", "http://loinc.org", null, null);

    [CqlDeclaration("Total interval score [HOOSJR]")]
	public CqlCode Total_interval_score__HOOSJR_() => 
		__Total_interval_score__HOOSJR_.Value;

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

	private CqlCode Yes__qualifier_value__Value() => 
		new CqlCode("373066001", "http://snomed.info/sct", null, null);

    [CqlDeclaration("Yes (qualifier value)")]
	public CqlCode Yes__qualifier_value_() => 
		__Yes__qualifier_value_.Value;

	private CqlCode[] LOINC_Value()
	{
		var a_ = new CqlCode[]
		{
			new CqlCode("72095-3", "http://loinc.org", null, null),
			new CqlCode("45755-6", "http://loinc.org", null, null),
			new CqlCode("72097-9", "http://loinc.org", null, null),
			new CqlCode("71969-0", "http://loinc.org", null, null),
			new CqlCode("71971-6", "http://loinc.org", null, null),
			new CqlCode("72093-8", "http://loinc.org", null, null),
			new CqlCode("72094-6", "http://loinc.org", null, null),
			new CqlCode("72096-1", "http://loinc.org", null, null),
			new CqlCode("82323-7", "http://loinc.org", null, null),
			new CqlCode("72026-8", "http://loinc.org", null, null),
			new CqlCode("72028-4", "http://loinc.org", null, null),
			new CqlCode("72025-0", "http://loinc.org", null, null),
			new CqlCode("72027-6", "http://loinc.org", null, null),
		};

		return a_;
	}

    [CqlDeclaration("LOINC")]
	public CqlCode[] LOINC() => 
		__LOINC.Value;

	private CqlCode[] CPT_Value()
	{
		var a_ = new CqlCode[]
		{
			new CqlCode("99024", "http://www.ama-assn.org/go/cpt", null, null),
		};

		return a_;
	}

    [CqlDeclaration("CPT")]
	public CqlCode[] CPT() => 
		__CPT.Value;

	private CqlCode[] ConditionCategoryCodes_Value()
	{
		var a_ = new CqlCode[0]
;

		return a_;
	}

    [CqlDeclaration("ConditionCategoryCodes")]
	public CqlCode[] ConditionCategoryCodes() => 
		__ConditionCategoryCodes.Value;

	private CqlCode[] SNOMEDCT_Value()
	{
		var a_ = new CqlCode[]
		{
			new CqlCode("419099009", "http://snomed.info/sct", null, null),
			new CqlCode("428371000124100", "http://snomed.info/sct", null, null),
			new CqlCode("428371000124100", "http://snomed.info/sct", null, null),
			new CqlCode("702956004", "http://snomed.info/sct", null, null),
			new CqlCode("373066001", "http://snomed.info/sct", null, null),
		};

		return a_;
	}

    [CqlDeclaration("SNOMEDCT")]
	public CqlCode[] SNOMEDCT() => 
		__SNOMEDCT.Value;

	private CqlCode[] ObservationCategoryCodes_Value()
	{
		var a_ = new CqlCode[]
		{
			new CqlCode("survey", "http://terminology.hl7.org/CodeSystem/v3-ObservationCategory", null, null),
		};

		return a_;
	}

    [CqlDeclaration("ObservationCategoryCodes")]
	public CqlCode[] ObservationCategoryCodes() => 
		__ObservationCategoryCodes.Value;

	private CqlInterval<CqlDateTime> Measurement_Period_Value()
	{
		var a_ = context.Operators.DateTime(2025, 1, 1, 0, 0, 0, 0, default);
		var b_ = context.Operators.DateTime(2026, 1, 1, 0, 0, 0, 0, default);
		var c_ = context.Operators.Interval(a_, b_, true, false);
		var d_ = context.ResolveParameter("FunctionalStatusAssessmentforTotalHipReplacementFHIR-0.0.008", "Measurement Period", c_);

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

	private CqlDateTime November_1_Year_Prior_to_the_Measurement_Period_Value()
	{
		var a_ = this.Measurement_Period();
		var b_ = context.Operators.Start(a_);
		var c_ = context.Operators.DateTimeComponentFrom(b_, "year");
		var d_ = context.Operators.Subtract(c_, 1);
		var e_ = context.Operators.ConvertIntegerToDecimal(0);
		var f_ = context.Operators.DateTime(d_, 11, 1, 0, 0, 0, 0, e_);

		return f_;
	}

    [CqlDeclaration("November 1 Year Prior to the Measurement Period")]
	public CqlDateTime November_1_Year_Prior_to_the_Measurement_Period() => 
		__November_1_Year_Prior_to_the_Measurement_Period.Value;

	private bool? Has_Qualifying_Encounter_Value()
	{
		var a_ = this.Outpatient_Consultation();
		var b_ = context.Operators.RetrieveByValueSet<Encounter>(a_, null);
		var c_ = this.Office_Visit();
		var d_ = context.Operators.RetrieveByValueSet<Encounter>(c_, null);
		var e_ = context.Operators.ListUnion<Encounter>(b_, d_);
		var f_ = context.Operators.RetrieveByValueSet<Encounter>(null, null);
		bool? g_(Encounter E)
		{
			var t_ = E?.Type;
			CqlConcept u_(CodeableConcept @this)
			{
				var z_ = FHIRHelpers_4_3_000.ToConcept(@this);

				return z_;
			};
			var v_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)t_, u_);
			bool? w_(CqlConcept T)
			{
				var aa_ = this.Postoperative_follow_up_visit__normally_included_in_the_surgical_package__to_indicate_that_an_evaluation_and_management_service_was_performed_during_a_postoperative_period_for_a_reason_s__related_to_the_original_procedure();
				var ab_ = context.Operators.ConvertCodeToConcept(aa_);
				var ac_ = context.Operators.Equivalent(T, ab_);

				return ac_;
			};
			var x_ = context.Operators.Where<CqlConcept>(v_, w_);
			var y_ = context.Operators.Exists<CqlConcept>(x_);

			return y_;
		};
		var h_ = context.Operators.Where<Encounter>(f_, g_);
		var i_ = this.Telephone_Visits();
		var j_ = context.Operators.RetrieveByValueSet<Encounter>(i_, null);
		var k_ = context.Operators.ListUnion<Encounter>(h_, j_);
		var l_ = context.Operators.ListUnion<Encounter>(e_, k_);
		var m_ = this.Online_Assessments();
		var n_ = context.Operators.RetrieveByValueSet<Encounter>(m_, null);
		var o_ = context.Operators.ListUnion<Encounter>(l_, n_);
		var p_ = Status_1_6_000.isEncounterPerformed(o_);
		bool? q_(Encounter ValidEncounters)
		{
			var ad_ = this.November_1_Year_Prior_to_the_Measurement_Period();
			var ae_ = this.Measurement_Period();
			var af_ = context.Operators.End(ae_);
			var ag_ = context.Operators.Interval(ad_, af_, true, true);
			var ah_ = ValidEncounters?.Period;
			var ai_ = FHIRHelpers_4_3_000.ToInterval(ah_);
			var aj_ = QICoreCommon_2_0_000.toInterval((ai_ as object));
			var ak_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(ag_, aj_, "day");

			return ak_;
		};
		var r_ = context.Operators.Where<Encounter>(p_, q_);
		var s_ = context.Operators.Exists<Encounter>(r_);

		return s_;
	}

    [CqlDeclaration("Has Qualifying Encounter")]
	public bool? Has_Qualifying_Encounter() => 
		__Has_Qualifying_Encounter.Value;

	private CqlDateTime November_1_Two_Years_Prior_to_the_Measurement_Period_Value()
	{
		var a_ = this.Measurement_Period();
		var b_ = context.Operators.Start(a_);
		var c_ = context.Operators.DateTimeComponentFrom(b_, "year");
		var d_ = context.Operators.Subtract(c_, 2);
		var e_ = context.Operators.ConvertIntegerToDecimal(0);
		var f_ = context.Operators.DateTime(d_, 11, 1, 0, 0, 0, 0, e_);

		return f_;
	}

    [CqlDeclaration("November 1 Two Years Prior to the Measurement Period")]
	public CqlDateTime November_1_Two_Years_Prior_to_the_Measurement_Period() => 
		__November_1_Two_Years_Prior_to_the_Measurement_Period.Value;

	private CqlDateTime October_31_Year_Prior_to_the_Measurement_Period_Value()
	{
		var a_ = this.Measurement_Period();
		var b_ = context.Operators.Start(a_);
		var c_ = context.Operators.DateTimeComponentFrom(b_, "year");
		var d_ = context.Operators.Subtract(c_, 1);
		var e_ = context.Operators.ConvertIntegerToDecimal(0);
		var f_ = context.Operators.DateTime(d_, 10, 31, 23, 59, 59, 0, e_);

		return f_;
	}

    [CqlDeclaration("October 31 Year Prior to the Measurement Period")]
	public CqlDateTime October_31_Year_Prior_to_the_Measurement_Period() => 
		__October_31_Year_Prior_to_the_Measurement_Period.Value;

	private IEnumerable<Procedure> Total_Hip_Arthroplasty_Procedure_Value()
	{
		var a_ = this.Primary_THA_Procedure();
		var b_ = context.Operators.RetrieveByValueSet<Procedure>(a_, null);
		var c_ = Status_1_6_000.isProcedurePerformed(b_);
		bool? d_(Procedure THAProcedure)
		{
			var f_ = THAProcedure?.Performed;
			var g_ = FHIRHelpers_4_3_000.ToValue(f_);
			var h_ = QICoreCommon_2_0_000.toInterval(g_);
			var i_ = context.Operators.Start(h_);
			var j_ = this.November_1_Two_Years_Prior_to_the_Measurement_Period();
			var k_ = this.October_31_Year_Prior_to_the_Measurement_Period();
			var l_ = context.Operators.Interval(j_, k_, true, true);
			var m_ = context.Operators.In<CqlDateTime>(i_, l_, "day");

			return m_;
		};
		var e_ = context.Operators.Where<Procedure>(c_, d_);

		return e_;
	}

    [CqlDeclaration("Total Hip Arthroplasty Procedure")]
	public IEnumerable<Procedure> Total_Hip_Arthroplasty_Procedure() => 
		__Total_Hip_Arthroplasty_Procedure.Value;

	private bool? Initial_Population_Value()
	{
		var a_ = this.Has_Qualifying_Encounter();
		var b_ = this.Total_Hip_Arthroplasty_Procedure();
		var c_ = context.Operators.Exists<Procedure>(b_);
		var d_ = context.Operators.And(a_, c_);
		var e_ = this.Patient();
		var f_ = context.Operators.Convert<CqlDate>(e_?.BirthDateElement?.Value);
		var g_ = this.Measurement_Period();
		var h_ = context.Operators.Start(g_);
		var i_ = context.Operators.DateFrom(h_);
		var j_ = context.Operators.CalculateAgeAt(f_, i_, "year");
		var k_ = context.Operators.GreaterOrEqual(j_, 19);
		var l_ = context.Operators.And(d_, k_);

		return l_;
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

	private bool? Has_Severe_Cognitive_Impairment_Value()
	{
		var a_ = this.Severe_cognitive_impairment__finding_();
		var b_ = context.Operators.ToList<CqlCode>(a_);
		var c_ = context.Operators.RetrieveByCodes<Condition>(b_, null);
		bool? d_(Condition Dementia)
		{
			var g_ = QICoreCommon_2_0_000.prevalenceInterval(Dementia);
			var h_ = this.Measurement_Period();
			var i_ = context.Operators.Overlaps(g_, h_, null);

			return i_;
		};
		var e_ = context.Operators.Where<Condition>(c_, d_);
		var f_ = context.Operators.Exists<Condition>(e_);

		return f_;
	}

    [CqlDeclaration("Has Severe Cognitive Impairment")]
	public bool? Has_Severe_Cognitive_Impairment() => 
		__Has_Severe_Cognitive_Impairment.Value;

	private bool? Has_Total_Hip_Arthroplasty_with_1_or_More_Lower_Body_Fractures_Value()
	{
		var a_ = this.Total_Hip_Arthroplasty_Procedure();
		IEnumerable<Procedure> b_(Procedure THAProcedure)
		{
			var e_ = this.Lower_Body_Fractures_Excluding_Ankle_and_Foot();
			var f_ = context.Operators.RetrieveByValueSet<Condition>(e_, null);
			bool? g_(Condition LowerBodyFracture)
			{
				var k_ = QICoreCommon_2_0_000.prevalenceInterval(LowerBodyFracture);
				var l_ = context.Operators.Start(k_);
				var m_ = THAProcedure?.Performed;
				var n_ = FHIRHelpers_4_3_000.ToValue(m_);
				var o_ = QICoreCommon_2_0_000.toInterval(n_);
				var p_ = context.Operators.Start(o_);
				var q_ = context.Operators.Quantity(24m, "hours");
				var r_ = context.Operators.Subtract(p_, q_);
				var t_ = FHIRHelpers_4_3_000.ToValue(m_);
				var u_ = QICoreCommon_2_0_000.toInterval(t_);
				var v_ = context.Operators.Start(u_);
				var w_ = context.Operators.Interval(r_, v_, true, true);
				var x_ = context.Operators.In<CqlDateTime>(l_, w_, null);
				var z_ = FHIRHelpers_4_3_000.ToValue(m_);
				var aa_ = QICoreCommon_2_0_000.toInterval(z_);
				var ab_ = context.Operators.Start(aa_);
				var ac_ = context.Operators.Not((bool?)(ab_ is null));
				var ad_ = context.Operators.And(x_, ac_);

				return ad_;
			};
			var h_ = context.Operators.Where<Condition>(f_, g_);
			Procedure i_(Condition LowerBodyFracture) => 
				THAProcedure;
			var j_ = context.Operators.Select<Condition, Procedure>(h_, i_);

			return j_;
		};
		var c_ = context.Operators.SelectMany<Procedure, Procedure>(a_, b_);
		var d_ = context.Operators.Exists<Procedure>(c_);

		return d_;
	}

    [CqlDeclaration("Has Total Hip Arthroplasty with 1 or More Lower Body Fractures")]
	public bool? Has_Total_Hip_Arthroplasty_with_1_or_More_Lower_Body_Fractures() => 
		__Has_Total_Hip_Arthroplasty_with_1_or_More_Lower_Body_Fractures.Value;

	private bool? Has_Partial_Hip_Arthroplasty_Procedure_Value()
	{
		var a_ = this.Partial_Arthroplasty_of_Hip();
		var b_ = context.Operators.RetrieveByValueSet<Procedure>(a_, null);
		var c_ = Status_1_6_000.isProcedurePerformed(b_);
		IEnumerable<Procedure> d_(Procedure PartialTHAProcedure)
		{
			var g_ = this.Total_Hip_Arthroplasty_Procedure();
			bool? h_(Procedure THAProcedure)
			{
				var l_ = THAProcedure?.Performed;
				var m_ = FHIRHelpers_4_3_000.ToValue(l_);
				var n_ = QICoreCommon_2_0_000.toInterval(m_);
				var o_ = PartialTHAProcedure?.Performed;
				var p_ = FHIRHelpers_4_3_000.ToValue(o_);
				var q_ = QICoreCommon_2_0_000.toInterval(p_);
				var r_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(n_, q_, "day");

				return r_;
			};
			var i_ = context.Operators.Where<Procedure>(g_, h_);
			Procedure j_(Procedure THAProcedure) => 
				PartialTHAProcedure;
			var k_ = context.Operators.Select<Procedure, Procedure>(i_, j_);

			return k_;
		};
		var e_ = context.Operators.SelectMany<Procedure, Procedure>(c_, d_);
		var f_ = context.Operators.Exists<Procedure>(e_);

		return f_;
	}

    [CqlDeclaration("Has Partial Hip Arthroplasty Procedure")]
	public bool? Has_Partial_Hip_Arthroplasty_Procedure() => 
		__Has_Partial_Hip_Arthroplasty_Procedure.Value;

	private bool? Has_Revision_Hip_Arthroplasty_Procedure_or_Implanted_Device_or_Prosthesis_Removal_Procedure_Value()
	{
		var a_ = this.Total_Hip_Arthroplasty_Procedure();
		IEnumerable<Procedure> b_(Procedure THAProcedure)
		{
			var e_ = this.Removal__Revision_and_Supplement_Procedures_of_the_Lower_Body_and_Spine();
			var f_ = context.Operators.RetrieveByValueSet<Procedure>(e_, null);
			var g_ = Status_1_6_000.isProcedurePerformed(f_);
			bool? h_(Procedure RevisionTHAProcedure)
			{
				var l_ = THAProcedure?.Performed;
				var m_ = FHIRHelpers_4_3_000.ToValue(l_);
				var n_ = QICoreCommon_2_0_000.toInterval(m_);
				var o_ = RevisionTHAProcedure?.Performed;
				var p_ = FHIRHelpers_4_3_000.ToValue(o_);
				var q_ = QICoreCommon_2_0_000.toInterval(p_);
				var r_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(n_, q_, "day");

				return r_;
			};
			var i_ = context.Operators.Where<Procedure>(g_, h_);
			Procedure j_(Procedure RevisionTHAProcedure) => 
				THAProcedure;
			var k_ = context.Operators.Select<Procedure, Procedure>(i_, j_);

			return k_;
		};
		var c_ = context.Operators.SelectMany<Procedure, Procedure>(a_, b_);
		var d_ = context.Operators.Exists<Procedure>(c_);

		return d_;
	}

    [CqlDeclaration("Has Revision Hip Arthroplasty Procedure or Implanted Device or Prosthesis Removal Procedure")]
	public bool? Has_Revision_Hip_Arthroplasty_Procedure_or_Implanted_Device_or_Prosthesis_Removal_Procedure() => 
		__Has_Revision_Hip_Arthroplasty_Procedure_or_Implanted_Device_or_Prosthesis_Removal_Procedure.Value;

	private bool? Has_Malignant_Neoplasm_of_Lower_and_Unspecified_Limbs_Value()
	{
		var a_ = this.Malignant_Neoplasms_of_Lower_and_Unspecified_Limbs();
		var b_ = context.Operators.RetrieveByValueSet<Condition>(a_, null);
		IEnumerable<Condition> c_(Condition MalignantNeoplasm)
		{
			var f_ = this.Total_Hip_Arthroplasty_Procedure();
			bool? g_(Procedure THAProcedure)
			{
				var k_ = QICoreCommon_2_0_000.prevalenceInterval(MalignantNeoplasm);
				var l_ = THAProcedure?.Performed;
				var m_ = FHIRHelpers_4_3_000.ToValue(l_);
				var n_ = QICoreCommon_2_0_000.toInterval(m_);
				var o_ = context.Operators.Overlaps(k_, n_, null);

				return o_;
			};
			var h_ = context.Operators.Where<Procedure>(f_, g_);
			Condition i_(Procedure THAProcedure) => 
				MalignantNeoplasm;
			var j_ = context.Operators.Select<Procedure, Condition>(h_, i_);

			return j_;
		};
		var d_ = context.Operators.SelectMany<Condition, Condition>(b_, c_);
		var e_ = context.Operators.Exists<Condition>(d_);

		return e_;
	}

    [CqlDeclaration("Has Malignant Neoplasm of Lower and Unspecified Limbs")]
	public bool? Has_Malignant_Neoplasm_of_Lower_and_Unspecified_Limbs() => 
		__Has_Malignant_Neoplasm_of_Lower_and_Unspecified_Limbs.Value;

	private bool? Has_Mechanical_Complication_Value()
	{
		var a_ = this.Mechanical_Complications_Excluding_Upper_Body();
		var b_ = context.Operators.RetrieveByValueSet<Condition>(a_, null);
		IEnumerable<Condition> c_(Condition MechanicalComplications)
		{
			var f_ = this.Total_Hip_Arthroplasty_Procedure();
			bool? g_(Procedure THAProcedure)
			{
				var k_ = QICoreCommon_2_0_000.prevalenceInterval(MechanicalComplications);
				var l_ = THAProcedure?.Performed;
				var m_ = FHIRHelpers_4_3_000.ToValue(l_);
				var n_ = QICoreCommon_2_0_000.toInterval(m_);
				var o_ = context.Operators.Overlaps(k_, n_, null);

				return o_;
			};
			var h_ = context.Operators.Where<Procedure>(f_, g_);
			Condition i_(Procedure THAProcedure) => 
				MechanicalComplications;
			var j_ = context.Operators.Select<Procedure, Condition>(h_, i_);

			return j_;
		};
		var d_ = context.Operators.SelectMany<Condition, Condition>(b_, c_);
		var e_ = context.Operators.Exists<Condition>(d_);

		return e_;
	}

    [CqlDeclaration("Has Mechanical Complication")]
	public bool? Has_Mechanical_Complication() => 
		__Has_Mechanical_Complication.Value;

	private bool? Has_More_Than_One_Elective_Primary_Total_Hip_Arthroplasty_Performed_Value()
	{
		var a_ = this.Total_Hip_Arthroplasty_Procedure();
		IEnumerable<Procedure> b_(Procedure THAProcedure)
		{
			var e_ = this.Primary_THA_Procedure();
			var f_ = context.Operators.RetrieveByValueSet<Procedure>(e_, null);
			var g_ = Status_1_6_000.isProcedurePerformed(f_);
			bool? h_(Procedure ElectiveTHAProcedure)
			{
				var l_ = THAProcedure?.IdElement;
				var m_ = l_?.Value;
				var n_ = ElectiveTHAProcedure?.IdElement;
				var o_ = n_?.Value;
				var p_ = context.Operators.Equivalent(m_, o_);
				var q_ = context.Operators.Not(p_);
				var r_ = ElectiveTHAProcedure?.Performed;
				var s_ = FHIRHelpers_4_3_000.ToValue(r_);
				var t_ = QICoreCommon_2_0_000.toInterval(s_);
				var u_ = context.Operators.Start(t_);
				var v_ = THAProcedure?.Performed;
				var w_ = FHIRHelpers_4_3_000.ToValue(v_);
				var x_ = QICoreCommon_2_0_000.toInterval(w_);
				var y_ = context.Operators.Start(x_);
				var z_ = context.Operators.Quantity(1m, "year");
				var aa_ = context.Operators.Subtract(y_, z_);
				var ac_ = FHIRHelpers_4_3_000.ToValue(v_);
				var ad_ = QICoreCommon_2_0_000.toInterval(ac_);
				var ae_ = context.Operators.Start(ad_);
				var ag_ = context.Operators.Add(ae_, z_);
				var ah_ = context.Operators.Interval(aa_, ag_, true, true);
				var ai_ = context.Operators.In<CqlDateTime>(u_, ah_, "day");
				var aj_ = context.Operators.And(q_, ai_);

				return aj_;
			};
			var i_ = context.Operators.Where<Procedure>(g_, h_);
			Procedure j_(Procedure ElectiveTHAProcedure) => 
				THAProcedure;
			var k_ = context.Operators.Select<Procedure, Procedure>(i_, j_);

			return k_;
		};
		var c_ = context.Operators.SelectMany<Procedure, Procedure>(a_, b_);
		var d_ = context.Operators.Exists<Procedure>(c_);

		return d_;
	}

    [CqlDeclaration("Has More Than One Elective Primary Total Hip Arthroplasty Performed")]
	public bool? Has_More_Than_One_Elective_Primary_Total_Hip_Arthroplasty_Performed() => 
		__Has_More_Than_One_Elective_Primary_Total_Hip_Arthroplasty_Performed.Value;

	private bool? Death_Within_300_Days_of_the_THA_Procedure_Value()
	{
		var a_ = this.Total_Hip_Arthroplasty_Procedure();
		bool? b_(Procedure THAProcedure)
		{
			var e_ = this.Patient();
			var f_ = e_?.Deceased;
			var g_ = FHIRHelpers_4_3_000.ToValue(f_);
			var h_ = context.Operators.DateFrom((g_ as CqlDateTime));
			var i_ = THAProcedure?.Performed;
			var j_ = FHIRHelpers_4_3_000.ToValue(i_);
			var k_ = QICoreCommon_2_0_000.toInterval(j_);
			var l_ = context.Operators.Start(k_);
			var m_ = context.Operators.DateFrom(l_);
			var o_ = FHIRHelpers_4_3_000.ToValue(i_);
			var p_ = QICoreCommon_2_0_000.toInterval(o_);
			var q_ = context.Operators.Start(p_);
			var r_ = context.Operators.DateFrom(q_);
			var s_ = context.Operators.Quantity(300m, "days");
			var t_ = context.Operators.Add(r_, s_);
			var u_ = context.Operators.Interval(m_, t_, true, true);
			var v_ = context.Operators.In<CqlDate>(h_, u_, "day");

			return v_;
		};
		var c_ = context.Operators.Where<Procedure>(a_, b_);
		var d_ = context.Operators.Exists<Procedure>(c_);

		return d_;
	}

    [CqlDeclaration("Death Within 300 Days of the THA Procedure")]
	public bool? Death_Within_300_Days_of_the_THA_Procedure() => 
		__Death_Within_300_Days_of_the_THA_Procedure.Value;

	private bool? Denominator_Exclusions_Value()
	{
		var a_ = Hospice_6_9_000.Has_Hospice_Services();
		var b_ = this.Has_Severe_Cognitive_Impairment();
		var c_ = context.Operators.Or(a_, b_);
		var d_ = this.Has_Total_Hip_Arthroplasty_with_1_or_More_Lower_Body_Fractures();
		var e_ = context.Operators.Or(c_, d_);
		var f_ = this.Has_Partial_Hip_Arthroplasty_Procedure();
		var g_ = context.Operators.Or(e_, f_);
		var h_ = this.Has_Revision_Hip_Arthroplasty_Procedure_or_Implanted_Device_or_Prosthesis_Removal_Procedure();
		var i_ = context.Operators.Or(g_, h_);
		var j_ = this.Has_Malignant_Neoplasm_of_Lower_and_Unspecified_Limbs();
		var k_ = context.Operators.Or(i_, j_);
		var l_ = this.Has_Mechanical_Complication();
		var m_ = context.Operators.Or(k_, l_);
		var n_ = this.Has_More_Than_One_Elective_Primary_Total_Hip_Arthroplasty_Performed();
		var o_ = context.Operators.Or(m_, n_);
		var p_ = this.Death_Within_300_Days_of_the_THA_Procedure();
		var q_ = context.Operators.Or(o_, p_);

		return q_;
	}

    [CqlDeclaration("Denominator Exclusions")]
	public bool? Denominator_Exclusions() => 
		__Denominator_Exclusions.Value;

	private IEnumerable<CqlDate> Date_HOOS_Total_Assessment_Completed_Value()
	{
		var a_ = this.Quality_of_life_score__HOOS_();
		var b_ = context.Operators.ToList<CqlCode>(a_);
		var c_ = context.Operators.RetrieveByCodes<Observation>(b_, null);
		var d_ = Status_1_6_000.isAssessmentPerformed(c_);
		var e_ = this.Sport_recreation_score__HOOS_();
		var f_ = context.Operators.ToList<CqlCode>(e_);
		var g_ = context.Operators.RetrieveByCodes<Observation>(f_, null);
		var h_ = Status_1_6_000.isAssessmentPerformed(g_);
		var i_ = this.Activities_of_daily_living_score__HOOS_();
		var j_ = context.Operators.ToList<CqlCode>(i_);
		var k_ = context.Operators.RetrieveByCodes<Observation>(j_, null);
		var l_ = Status_1_6_000.isAssessmentPerformed(k_);
		var m_ = this.Symptoms_score__HOOS_();
		var n_ = context.Operators.ToList<CqlCode>(m_);
		var o_ = context.Operators.RetrieveByCodes<Observation>(n_, null);
		var p_ = Status_1_6_000.isAssessmentPerformed(o_);
		var q_ = this.Pain_score__HOOS_();
		var r_ = context.Operators.ToList<CqlCode>(q_);
		var s_ = context.Operators.RetrieveByCodes<Observation>(r_, null);
		var t_ = Status_1_6_000.isAssessmentPerformed(s_);
		var u_ = context.Operators.CrossJoin<Observation, Observation, Observation, Observation, Observation>(d_, h_, l_, p_, t_);
		Tuple_EIPfMaZVhFScjijaOFHiCPVMb v_(ValueTuple<Observation, Observation, Observation, Observation, Observation> _valueTuple)
		{
			var ab_ = new Tuple_EIPfMaZVhFScjijaOFHiCPVMb
			{
				HOOSLifeQuality = _valueTuple.Item1,
				HOOSSport = _valueTuple.Item2,
				HOOSActivityScore = _valueTuple.Item3,
				HOOSSymptoms = _valueTuple.Item4,
				HOOSPain = _valueTuple.Item5,
			};

			return ab_;
		};
		var w_ = context.Operators.Select<ValueTuple<Observation, Observation, Observation, Observation, Observation>, Tuple_EIPfMaZVhFScjijaOFHiCPVMb>(u_, v_);
		bool? x_(Tuple_EIPfMaZVhFScjijaOFHiCPVMb tuple_eipfmazvhfscjijaofhicpvmb)
		{
			var ac_ = tuple_eipfmazvhfscjijaofhicpvmb.HOOSLifeQuality?.Effective;
			var ad_ = FHIRHelpers_4_3_000.ToValue(ac_);
			var ae_ = QICoreCommon_2_0_000.toInterval(ad_);
			var af_ = context.Operators.Start(ae_);
			var ag_ = context.Operators.DateFrom(af_);
			var ah_ = tuple_eipfmazvhfscjijaofhicpvmb.HOOSSport?.Effective;
			var ai_ = FHIRHelpers_4_3_000.ToValue(ah_);
			var aj_ = QICoreCommon_2_0_000.toInterval(ai_);
			var ak_ = context.Operators.Start(aj_);
			var al_ = context.Operators.DateFrom(ak_);
			var am_ = context.Operators.SameAs(ag_, al_, "day");
			var an_ = tuple_eipfmazvhfscjijaofhicpvmb.HOOSSport?.Value;
			var ao_ = FHIRHelpers_4_3_000.ToValue(an_);
			var ap_ = context.Operators.Not((bool?)(ao_ is null));
			var aq_ = context.Operators.And(am_, ap_);
			var as_ = FHIRHelpers_4_3_000.ToValue(ac_);
			var at_ = QICoreCommon_2_0_000.toInterval(as_);
			var au_ = context.Operators.Start(at_);
			var av_ = context.Operators.DateFrom(au_);
			var aw_ = tuple_eipfmazvhfscjijaofhicpvmb.HOOSActivityScore?.Effective;
			var ax_ = FHIRHelpers_4_3_000.ToValue(aw_);
			var ay_ = QICoreCommon_2_0_000.toInterval(ax_);
			var az_ = context.Operators.Start(ay_);
			var ba_ = context.Operators.DateFrom(az_);
			var bb_ = context.Operators.SameAs(av_, ba_, "day");
			var bc_ = context.Operators.And(aq_, bb_);
			var bd_ = tuple_eipfmazvhfscjijaofhicpvmb.HOOSActivityScore?.Value;
			var be_ = FHIRHelpers_4_3_000.ToValue(bd_);
			var bf_ = context.Operators.Not((bool?)(be_ is null));
			var bg_ = context.Operators.And(bc_, bf_);
			var bi_ = FHIRHelpers_4_3_000.ToValue(ac_);
			var bj_ = QICoreCommon_2_0_000.toInterval(bi_);
			var bk_ = context.Operators.Start(bj_);
			var bl_ = context.Operators.DateFrom(bk_);
			var bm_ = tuple_eipfmazvhfscjijaofhicpvmb.HOOSSymptoms?.Effective;
			var bn_ = FHIRHelpers_4_3_000.ToValue(bm_);
			var bo_ = QICoreCommon_2_0_000.toInterval(bn_);
			var bp_ = context.Operators.Start(bo_);
			var bq_ = context.Operators.DateFrom(bp_);
			var br_ = context.Operators.SameAs(bl_, bq_, "day");
			var bs_ = context.Operators.And(bg_, br_);
			var bt_ = tuple_eipfmazvhfscjijaofhicpvmb.HOOSSymptoms?.Value;
			var bu_ = FHIRHelpers_4_3_000.ToValue(bt_);
			var bv_ = context.Operators.Not((bool?)(bu_ is null));
			var bw_ = context.Operators.And(bs_, bv_);
			var by_ = FHIRHelpers_4_3_000.ToValue(ac_);
			var bz_ = QICoreCommon_2_0_000.toInterval(by_);
			var ca_ = context.Operators.Start(bz_);
			var cb_ = context.Operators.DateFrom(ca_);
			var cc_ = tuple_eipfmazvhfscjijaofhicpvmb.HOOSPain?.Effective;
			var cd_ = FHIRHelpers_4_3_000.ToValue(cc_);
			var ce_ = QICoreCommon_2_0_000.toInterval(cd_);
			var cf_ = context.Operators.Start(ce_);
			var cg_ = context.Operators.DateFrom(cf_);
			var ch_ = context.Operators.SameAs(cb_, cg_, "day");
			var ci_ = context.Operators.And(bw_, ch_);
			var cj_ = tuple_eipfmazvhfscjijaofhicpvmb.HOOSPain?.Value;
			var ck_ = FHIRHelpers_4_3_000.ToValue(cj_);
			var cl_ = context.Operators.Not((bool?)(ck_ is null));
			var cm_ = context.Operators.And(ci_, cl_);
			var cn_ = tuple_eipfmazvhfscjijaofhicpvmb.HOOSLifeQuality?.Value;
			var co_ = FHIRHelpers_4_3_000.ToValue(cn_);
			var cp_ = context.Operators.Not((bool?)(co_ is null));
			var cq_ = context.Operators.And(cm_, cp_);

			return cq_;
		};
		var y_ = context.Operators.Where<Tuple_EIPfMaZVhFScjijaOFHiCPVMb>(w_, x_);
		CqlDate z_(Tuple_EIPfMaZVhFScjijaOFHiCPVMb tuple_eipfmazvhfscjijaofhicpvmb)
		{
			var cr_ = tuple_eipfmazvhfscjijaofhicpvmb.HOOSLifeQuality?.Effective;
			var cs_ = FHIRHelpers_4_3_000.ToValue(cr_);
			var ct_ = QICoreCommon_2_0_000.toInterval(cs_);
			var cu_ = context.Operators.Start(ct_);
			var cv_ = context.Operators.DateFrom(cu_);
			var cw_ = tuple_eipfmazvhfscjijaofhicpvmb.HOOSSport?.Effective;
			var cx_ = FHIRHelpers_4_3_000.ToValue(cw_);
			var cy_ = QICoreCommon_2_0_000.toInterval(cx_);
			var cz_ = context.Operators.Start(cy_);
			var da_ = context.Operators.DateFrom(cz_);
			var db_ = tuple_eipfmazvhfscjijaofhicpvmb.HOOSActivityScore?.Effective;
			var dc_ = FHIRHelpers_4_3_000.ToValue(db_);
			var dd_ = QICoreCommon_2_0_000.toInterval(dc_);
			var de_ = context.Operators.Start(dd_);
			var df_ = context.Operators.DateFrom(de_);
			var dg_ = tuple_eipfmazvhfscjijaofhicpvmb.HOOSSymptoms?.Effective;
			var dh_ = FHIRHelpers_4_3_000.ToValue(dg_);
			var di_ = QICoreCommon_2_0_000.toInterval(dh_);
			var dj_ = context.Operators.Start(di_);
			var dk_ = context.Operators.DateFrom(dj_);
			var dl_ = tuple_eipfmazvhfscjijaofhicpvmb.HOOSPain?.Effective;
			var dm_ = FHIRHelpers_4_3_000.ToValue(dl_);
			var dn_ = QICoreCommon_2_0_000.toInterval(dm_);
			var do_ = context.Operators.Start(dn_);
			var dp_ = context.Operators.DateFrom(do_);
			var dq_ = new CqlDate[]
			{
				cv_,
				da_,
				df_,
				dk_,
				dp_,
			};
			var dr_ = context.Operators.Max<CqlDate>((dq_ as IEnumerable<CqlDate>));

			return dr_;
		};
		var aa_ = context.Operators.Select<Tuple_EIPfMaZVhFScjijaOFHiCPVMb, CqlDate>(y_, z_);

		return aa_;
	}

    [CqlDeclaration("Date HOOS Total Assessment Completed")]
	public IEnumerable<CqlDate> Date_HOOS_Total_Assessment_Completed() => 
		__Date_HOOS_Total_Assessment_Completed.Value;

	private bool? Has_THA_with_Initial_and_Follow_Up_HOOS_Assessments_Value()
	{
		var a_ = this.Total_Hip_Arthroplasty_Procedure();
		CqlInterval<CqlDateTime> b_(Procedure THAProcedure)
		{
			var i_ = THAProcedure?.Performed;
			var j_ = FHIRHelpers_4_3_000.ToValue(i_);
			var k_ = QICoreCommon_2_0_000.toInterval(j_);

			return k_;
		};
		var c_ = context.Operators.Select<Procedure, CqlInterval<CqlDateTime>>(a_, b_);
		IEnumerable<CqlInterval<CqlDateTime>> d_(CqlInterval<CqlDateTime> TotalHip)
		{
			var l_ = this.Date_HOOS_Total_Assessment_Completed();
			bool? m_(CqlDate InitialHipAssessmentHOOS)
			{
				var q_ = context.Operators.Start(TotalHip);
				var r_ = context.Operators.Quantity(90m, "days");
				var s_ = context.Operators.Add(InitialHipAssessmentHOOS, r_);
				var t_ = context.Operators.Interval(InitialHipAssessmentHOOS, s_, true, true);
				var u_ = t_?.low;
				var v_ = context.Operators.ConvertDateToDateTime(u_);
				var x_ = context.Operators.Add(InitialHipAssessmentHOOS, r_);
				var y_ = context.Operators.Interval(InitialHipAssessmentHOOS, x_, true, true);
				var z_ = y_?.high;
				var aa_ = context.Operators.ConvertDateToDateTime(z_);
				var ac_ = context.Operators.Add(InitialHipAssessmentHOOS, r_);
				var ad_ = context.Operators.Interval(InitialHipAssessmentHOOS, ac_, true, true);
				var ae_ = ad_?.lowClosed;
				var ag_ = context.Operators.Add(InitialHipAssessmentHOOS, r_);
				var ah_ = context.Operators.Interval(InitialHipAssessmentHOOS, ag_, true, true);
				var ai_ = ah_?.highClosed;
				var aj_ = context.Operators.Interval(v_, aa_, ae_, ai_);
				var ak_ = context.Operators.In<CqlDateTime>(q_, aj_, "day");
				var al_ = context.Operators.Not((bool?)(InitialHipAssessmentHOOS is null));
				var am_ = context.Operators.And(ak_, al_);

				return am_;
			};
			var n_ = context.Operators.Where<CqlDate>(l_, m_);
			CqlInterval<CqlDateTime> o_(CqlDate InitialHipAssessmentHOOS) => 
				TotalHip;
			var p_ = context.Operators.Select<CqlDate, CqlInterval<CqlDateTime>>(n_, o_);

			return p_;
		};
		var e_ = context.Operators.SelectMany<CqlInterval<CqlDateTime>, CqlInterval<CqlDateTime>>(c_, d_);
		IEnumerable<CqlInterval<CqlDateTime>> f_(CqlInterval<CqlDateTime> TotalHip)
		{
			var an_ = this.Date_HOOS_Total_Assessment_Completed();
			bool? ao_(CqlDate FollowUpHipAssessmentHOOS)
			{
				var as_ = context.Operators.ConvertDateToDateTime(FollowUpHipAssessmentHOOS);
				var at_ = context.Operators.DateFrom(as_);
				var au_ = context.Operators.End(TotalHip);
				var av_ = context.Operators.DateFrom(au_);
				var aw_ = context.Operators.Quantity(300m, "days");
				var ax_ = context.Operators.Add(av_, aw_);
				var az_ = context.Operators.DateFrom(au_);
				var ba_ = context.Operators.Quantity(425m, "days");
				var bb_ = context.Operators.Add(az_, ba_);
				var bc_ = context.Operators.Interval(ax_, bb_, true, true);
				var bd_ = context.Operators.In<CqlDate>(at_, bc_, "day");

				return bd_;
			};
			var ap_ = context.Operators.Where<CqlDate>(an_, ao_);
			CqlInterval<CqlDateTime> aq_(CqlDate FollowUpHipAssessmentHOOS) => 
				TotalHip;
			var ar_ = context.Operators.Select<CqlDate, CqlInterval<CqlDateTime>>(ap_, aq_);

			return ar_;
		};
		var g_ = context.Operators.SelectMany<CqlInterval<CqlDateTime>, CqlInterval<CqlDateTime>>(e_, f_);
		var h_ = context.Operators.Exists<CqlInterval<CqlDateTime>>(g_);

		return h_;
	}

    [CqlDeclaration("Has THA with Initial and Follow Up HOOS Assessments")]
	public bool? Has_THA_with_Initial_and_Follow_Up_HOOS_Assessments() => 
		__Has_THA_with_Initial_and_Follow_Up_HOOS_Assessments.Value;

	private IEnumerable<CqlDate> Date_HOOSJr_Total_Assessment_Completed_Value()
	{
		var a_ = this.Total_interval_score__HOOSJR_();
		var b_ = context.Operators.ToList<CqlCode>(a_);
		var c_ = context.Operators.RetrieveByCodes<Observation>(b_, null);
		bool? d_(Observation HOOSJr)
		{
			var h_ = HOOSJr?.Value;
			var i_ = FHIRHelpers_4_3_000.ToValue(h_);
			var j_ = context.Operators.Not((bool?)(i_ is null));

			return j_;
		};
		var e_ = context.Operators.Where<Observation>(c_, d_);
		CqlDate f_(Observation DocumentedHOOSJr)
		{
			var k_ = DocumentedHOOSJr?.Effective;
			var l_ = FHIRHelpers_4_3_000.ToValue(k_);
			var m_ = QICoreCommon_2_0_000.toInterval(l_);
			var n_ = context.Operators.Start(m_);
			var o_ = context.Operators.DateFrom(n_);

			return o_;
		};
		var g_ = context.Operators.Select<Observation, CqlDate>(e_, f_);

		return g_;
	}

    [CqlDeclaration("Date HOOSJr Total Assessment Completed")]
	public IEnumerable<CqlDate> Date_HOOSJr_Total_Assessment_Completed() => 
		__Date_HOOSJr_Total_Assessment_Completed.Value;

	private bool? Has_THA_with_Initial_and_Follow_Up_HOOSJr_Assessments_Value()
	{
		var a_ = this.Total_Hip_Arthroplasty_Procedure();
		CqlInterval<CqlDateTime> b_(Procedure THAProcedure)
		{
			var i_ = THAProcedure?.Performed;
			var j_ = FHIRHelpers_4_3_000.ToValue(i_);
			var k_ = QICoreCommon_2_0_000.toInterval(j_);

			return k_;
		};
		var c_ = context.Operators.Select<Procedure, CqlInterval<CqlDateTime>>(a_, b_);
		IEnumerable<CqlInterval<CqlDateTime>> d_(CqlInterval<CqlDateTime> TotalHip)
		{
			var l_ = this.Date_HOOSJr_Total_Assessment_Completed();
			bool? m_(CqlDate InitialHipAssessment)
			{
				var q_ = context.Operators.Start(TotalHip);
				var r_ = context.Operators.Quantity(90m, "days");
				var s_ = context.Operators.Add(InitialHipAssessment, r_);
				var t_ = context.Operators.Interval(InitialHipAssessment, s_, true, true);
				var u_ = t_?.low;
				var v_ = context.Operators.ConvertDateToDateTime(u_);
				var x_ = context.Operators.Add(InitialHipAssessment, r_);
				var y_ = context.Operators.Interval(InitialHipAssessment, x_, true, true);
				var z_ = y_?.high;
				var aa_ = context.Operators.ConvertDateToDateTime(z_);
				var ac_ = context.Operators.Add(InitialHipAssessment, r_);
				var ad_ = context.Operators.Interval(InitialHipAssessment, ac_, true, true);
				var ae_ = ad_?.lowClosed;
				var ag_ = context.Operators.Add(InitialHipAssessment, r_);
				var ah_ = context.Operators.Interval(InitialHipAssessment, ag_, true, true);
				var ai_ = ah_?.highClosed;
				var aj_ = context.Operators.Interval(v_, aa_, ae_, ai_);
				var ak_ = context.Operators.In<CqlDateTime>(q_, aj_, "day");
				var al_ = context.Operators.Not((bool?)(InitialHipAssessment is null));
				var am_ = context.Operators.And(ak_, al_);

				return am_;
			};
			var n_ = context.Operators.Where<CqlDate>(l_, m_);
			CqlInterval<CqlDateTime> o_(CqlDate InitialHipAssessment) => 
				TotalHip;
			var p_ = context.Operators.Select<CqlDate, CqlInterval<CqlDateTime>>(n_, o_);

			return p_;
		};
		var e_ = context.Operators.SelectMany<CqlInterval<CqlDateTime>, CqlInterval<CqlDateTime>>(c_, d_);
		IEnumerable<CqlInterval<CqlDateTime>> f_(CqlInterval<CqlDateTime> TotalHip)
		{
			var an_ = this.Date_HOOSJr_Total_Assessment_Completed();
			bool? ao_(CqlDate FollowUpHipAssessment)
			{
				var as_ = context.Operators.ConvertDateToDateTime(FollowUpHipAssessment);
				var at_ = context.Operators.DateFrom(as_);
				var au_ = context.Operators.End(TotalHip);
				var av_ = context.Operators.DateFrom(au_);
				var aw_ = context.Operators.Quantity(300m, "days");
				var ax_ = context.Operators.Add(av_, aw_);
				var az_ = context.Operators.DateFrom(au_);
				var ba_ = context.Operators.Quantity(425m, "days");
				var bb_ = context.Operators.Add(az_, ba_);
				var bc_ = context.Operators.Interval(ax_, bb_, true, true);
				var bd_ = context.Operators.In<CqlDate>(at_, bc_, "day");

				return bd_;
			};
			var ap_ = context.Operators.Where<CqlDate>(an_, ao_);
			CqlInterval<CqlDateTime> aq_(CqlDate FollowUpHipAssessment) => 
				TotalHip;
			var ar_ = context.Operators.Select<CqlDate, CqlInterval<CqlDateTime>>(ap_, aq_);

			return ar_;
		};
		var g_ = context.Operators.SelectMany<CqlInterval<CqlDateTime>, CqlInterval<CqlDateTime>>(e_, f_);
		var h_ = context.Operators.Exists<CqlInterval<CqlDateTime>>(g_);

		return h_;
	}

    [CqlDeclaration("Has THA with Initial and Follow Up HOOSJr Assessments")]
	public bool? Has_THA_with_Initial_and_Follow_Up_HOOSJr_Assessments() => 
		__Has_THA_with_Initial_and_Follow_Up_HOOSJr_Assessments.Value;

	private IEnumerable<CqlDate> Date_PROMIS10_Total_Assessment_Completed_Value()
	{
		var a_ = this.PROMIS_10_Global_Mental_Health__GMH__score_T_score();
		var b_ = context.Operators.ToList<CqlCode>(a_);
		var c_ = context.Operators.RetrieveByCodes<Observation>(b_, null);
		var d_ = this.PROMIS_10_Global_Physical_Health__GPH__score_T_score();
		var e_ = context.Operators.ToList<CqlCode>(d_);
		var f_ = context.Operators.RetrieveByCodes<Observation>(e_, null);
		var g_ = context.Operators.CrossJoin<Observation, Observation>(c_, f_);
		Tuple_DDTAOdcFieSJbGgRLLZPYbGQb h_(ValueTuple<Observation, Observation> _valueTuple)
		{
			var n_ = new Tuple_DDTAOdcFieSJbGgRLLZPYbGQb
			{
				PROMIS10MentalScore = _valueTuple.Item1,
				PROMIS10PhysicalScore = _valueTuple.Item2,
			};

			return n_;
		};
		var i_ = context.Operators.Select<ValueTuple<Observation, Observation>, Tuple_DDTAOdcFieSJbGgRLLZPYbGQb>(g_, h_);
		bool? j_(Tuple_DDTAOdcFieSJbGgRLLZPYbGQb tuple_ddtaodcfiesjbggrllzpybgqb)
		{
			var o_ = tuple_ddtaodcfiesjbggrllzpybgqb.PROMIS10MentalScore?.Effective;
			var p_ = FHIRHelpers_4_3_000.ToValue(o_);
			var q_ = QICoreCommon_2_0_000.toInterval(p_);
			var r_ = context.Operators.Start(q_);
			var s_ = context.Operators.DateFrom(r_);
			var t_ = tuple_ddtaodcfiesjbggrllzpybgqb.PROMIS10PhysicalScore?.Effective;
			var u_ = FHIRHelpers_4_3_000.ToValue(t_);
			var v_ = QICoreCommon_2_0_000.toInterval(u_);
			var w_ = context.Operators.Start(v_);
			var x_ = context.Operators.DateFrom(w_);
			var y_ = context.Operators.SameAs(s_, x_, "day");
			var z_ = tuple_ddtaodcfiesjbggrllzpybgqb.PROMIS10PhysicalScore?.Value;
			var aa_ = FHIRHelpers_4_3_000.ToValue(z_);
			var ab_ = context.Operators.Not((bool?)(aa_ is null));
			var ac_ = context.Operators.And(y_, ab_);
			var ad_ = tuple_ddtaodcfiesjbggrllzpybgqb.PROMIS10MentalScore?.Value;
			var ae_ = FHIRHelpers_4_3_000.ToValue(ad_);
			var af_ = context.Operators.Not((bool?)(ae_ is null));
			var ag_ = context.Operators.And(ac_, af_);

			return ag_;
		};
		var k_ = context.Operators.Where<Tuple_DDTAOdcFieSJbGgRLLZPYbGQb>(i_, j_);
		CqlDate l_(Tuple_DDTAOdcFieSJbGgRLLZPYbGQb tuple_ddtaodcfiesjbggrllzpybgqb)
		{
			var ah_ = tuple_ddtaodcfiesjbggrllzpybgqb.PROMIS10MentalScore?.Effective;
			var ai_ = FHIRHelpers_4_3_000.ToValue(ah_);
			var aj_ = QICoreCommon_2_0_000.toInterval(ai_);
			var ak_ = context.Operators.Start(aj_);
			var al_ = context.Operators.DateFrom(ak_);
			var am_ = tuple_ddtaodcfiesjbggrllzpybgqb.PROMIS10PhysicalScore?.Effective;
			var an_ = FHIRHelpers_4_3_000.ToValue(am_);
			var ao_ = QICoreCommon_2_0_000.toInterval(an_);
			var ap_ = context.Operators.Start(ao_);
			var aq_ = context.Operators.DateFrom(ap_);
			var ar_ = new CqlDate[]
			{
				al_,
				aq_,
			};
			var as_ = context.Operators.Max<CqlDate>((ar_ as IEnumerable<CqlDate>));

			return as_;
		};
		var m_ = context.Operators.Select<Tuple_DDTAOdcFieSJbGgRLLZPYbGQb, CqlDate>(k_, l_);

		return m_;
	}

    [CqlDeclaration("Date PROMIS10 Total Assessment Completed")]
	public IEnumerable<CqlDate> Date_PROMIS10_Total_Assessment_Completed() => 
		__Date_PROMIS10_Total_Assessment_Completed.Value;

	private bool? Has_THA_with_Initial_and_Follow_Up_PROMIS10_Assessments_Value()
	{
		var a_ = this.Total_Hip_Arthroplasty_Procedure();
		CqlInterval<CqlDateTime> b_(Procedure THAProcedure)
		{
			var i_ = THAProcedure?.Performed;
			var j_ = FHIRHelpers_4_3_000.ToValue(i_);
			var k_ = QICoreCommon_2_0_000.toInterval(j_);

			return k_;
		};
		var c_ = context.Operators.Select<Procedure, CqlInterval<CqlDateTime>>(a_, b_);
		IEnumerable<CqlInterval<CqlDateTime>> d_(CqlInterval<CqlDateTime> TotalHip)
		{
			var l_ = this.Date_PROMIS10_Total_Assessment_Completed();
			bool? m_(CqlDate InitialHipAssessmentPROMIS10)
			{
				var q_ = context.Operators.Start(TotalHip);
				var r_ = context.Operators.Quantity(90m, "days");
				var s_ = context.Operators.Add(InitialHipAssessmentPROMIS10, r_);
				var t_ = context.Operators.Interval(InitialHipAssessmentPROMIS10, s_, true, true);
				var u_ = t_?.low;
				var v_ = context.Operators.ConvertDateToDateTime(u_);
				var x_ = context.Operators.Add(InitialHipAssessmentPROMIS10, r_);
				var y_ = context.Operators.Interval(InitialHipAssessmentPROMIS10, x_, true, true);
				var z_ = y_?.high;
				var aa_ = context.Operators.ConvertDateToDateTime(z_);
				var ac_ = context.Operators.Add(InitialHipAssessmentPROMIS10, r_);
				var ad_ = context.Operators.Interval(InitialHipAssessmentPROMIS10, ac_, true, true);
				var ae_ = ad_?.lowClosed;
				var ag_ = context.Operators.Add(InitialHipAssessmentPROMIS10, r_);
				var ah_ = context.Operators.Interval(InitialHipAssessmentPROMIS10, ag_, true, true);
				var ai_ = ah_?.highClosed;
				var aj_ = context.Operators.Interval(v_, aa_, ae_, ai_);
				var ak_ = context.Operators.In<CqlDateTime>(q_, aj_, "day");
				var al_ = context.Operators.Not((bool?)(InitialHipAssessmentPROMIS10 is null));
				var am_ = context.Operators.And(ak_, al_);

				return am_;
			};
			var n_ = context.Operators.Where<CqlDate>(l_, m_);
			CqlInterval<CqlDateTime> o_(CqlDate InitialHipAssessmentPROMIS10) => 
				TotalHip;
			var p_ = context.Operators.Select<CqlDate, CqlInterval<CqlDateTime>>(n_, o_);

			return p_;
		};
		var e_ = context.Operators.SelectMany<CqlInterval<CqlDateTime>, CqlInterval<CqlDateTime>>(c_, d_);
		IEnumerable<CqlInterval<CqlDateTime>> f_(CqlInterval<CqlDateTime> TotalHip)
		{
			var an_ = this.Date_PROMIS10_Total_Assessment_Completed();
			bool? ao_(CqlDate FollowUpHipAssessmentPROMIS10)
			{
				var as_ = context.Operators.ConvertDateToDateTime(FollowUpHipAssessmentPROMIS10);
				var at_ = context.Operators.DateFrom(as_);
				var au_ = context.Operators.End(TotalHip);
				var av_ = context.Operators.DateFrom(au_);
				var aw_ = context.Operators.Quantity(300m, "days");
				var ax_ = context.Operators.Add(av_, aw_);
				var az_ = context.Operators.DateFrom(au_);
				var ba_ = context.Operators.Quantity(425m, "days");
				var bb_ = context.Operators.Add(az_, ba_);
				var bc_ = context.Operators.Interval(ax_, bb_, true, true);
				var bd_ = context.Operators.In<CqlDate>(at_, bc_, "day");

				return bd_;
			};
			var ap_ = context.Operators.Where<CqlDate>(an_, ao_);
			CqlInterval<CqlDateTime> aq_(CqlDate FollowUpHipAssessmentPROMIS10) => 
				TotalHip;
			var ar_ = context.Operators.Select<CqlDate, CqlInterval<CqlDateTime>>(ap_, aq_);

			return ar_;
		};
		var g_ = context.Operators.SelectMany<CqlInterval<CqlDateTime>, CqlInterval<CqlDateTime>>(e_, f_);
		var h_ = context.Operators.Exists<CqlInterval<CqlDateTime>>(g_);

		return h_;
	}

    [CqlDeclaration("Has THA with Initial and Follow Up PROMIS10 Assessments")]
	public bool? Has_THA_with_Initial_and_Follow_Up_PROMIS10_Assessments() => 
		__Has_THA_with_Initial_and_Follow_Up_PROMIS10_Assessments.Value;

	private IEnumerable<CqlDate> Date_VR12_Oblique_Total_Assessment_Completed_Value()
	{
		var a_ = this.VR_12_Mental_component_summary__MCS__score___oblique_method_T_score();
		var b_ = context.Operators.ToList<CqlCode>(a_);
		var c_ = context.Operators.RetrieveByCodes<Observation>(b_, null);
		var d_ = this.VR_12_Physical_component_summary__PCS__score___oblique_method_T_score();
		var e_ = context.Operators.ToList<CqlCode>(d_);
		var f_ = context.Operators.RetrieveByCodes<Observation>(e_, null);
		var g_ = context.Operators.CrossJoin<Observation, Observation>(c_, f_);
		Tuple_GAdRFKRaHUUGJcVHWQWRUjhRH h_(ValueTuple<Observation, Observation> _valueTuple)
		{
			var n_ = new Tuple_GAdRFKRaHUUGJcVHWQWRUjhRH
			{
				VR12MentalAssessment = _valueTuple.Item1,
				VR12PhysicalAssessment = _valueTuple.Item2,
			};

			return n_;
		};
		var i_ = context.Operators.Select<ValueTuple<Observation, Observation>, Tuple_GAdRFKRaHUUGJcVHWQWRUjhRH>(g_, h_);
		bool? j_(Tuple_GAdRFKRaHUUGJcVHWQWRUjhRH tuple_gadrfkrahuugjcvhwqwrujhrh)
		{
			var o_ = tuple_gadrfkrahuugjcvhwqwrujhrh.VR12MentalAssessment?.Effective;
			var p_ = FHIRHelpers_4_3_000.ToValue(o_);
			var q_ = QICoreCommon_2_0_000.toInterval(p_);
			var r_ = context.Operators.Start(q_);
			var s_ = context.Operators.DateFrom(r_);
			var t_ = tuple_gadrfkrahuugjcvhwqwrujhrh.VR12PhysicalAssessment?.Effective;
			var u_ = FHIRHelpers_4_3_000.ToValue(t_);
			var v_ = QICoreCommon_2_0_000.toInterval(u_);
			var w_ = context.Operators.Start(v_);
			var x_ = context.Operators.DateFrom(w_);
			var y_ = context.Operators.SameAs(s_, x_, "day");
			var z_ = tuple_gadrfkrahuugjcvhwqwrujhrh.VR12MentalAssessment?.Value;
			var aa_ = FHIRHelpers_4_3_000.ToValue(z_);
			var ab_ = context.Operators.Not((bool?)(aa_ is null));
			var ac_ = context.Operators.And(y_, ab_);
			var ad_ = tuple_gadrfkrahuugjcvhwqwrujhrh.VR12PhysicalAssessment?.Value;
			var ae_ = FHIRHelpers_4_3_000.ToValue(ad_);
			var af_ = context.Operators.Not((bool?)(ae_ is null));
			var ag_ = context.Operators.And(ac_, af_);

			return ag_;
		};
		var k_ = context.Operators.Where<Tuple_GAdRFKRaHUUGJcVHWQWRUjhRH>(i_, j_);
		CqlDate l_(Tuple_GAdRFKRaHUUGJcVHWQWRUjhRH tuple_gadrfkrahuugjcvhwqwrujhrh)
		{
			var ah_ = tuple_gadrfkrahuugjcvhwqwrujhrh.VR12MentalAssessment?.Effective;
			var ai_ = FHIRHelpers_4_3_000.ToValue(ah_);
			var aj_ = QICoreCommon_2_0_000.toInterval(ai_);
			var ak_ = context.Operators.Start(aj_);
			var al_ = context.Operators.DateFrom(ak_);
			var am_ = tuple_gadrfkrahuugjcvhwqwrujhrh.VR12PhysicalAssessment?.Effective;
			var an_ = FHIRHelpers_4_3_000.ToValue(am_);
			var ao_ = QICoreCommon_2_0_000.toInterval(an_);
			var ap_ = context.Operators.Start(ao_);
			var aq_ = context.Operators.DateFrom(ap_);
			var ar_ = new CqlDate[]
			{
				al_,
				aq_,
			};
			var as_ = context.Operators.Max<CqlDate>((ar_ as IEnumerable<CqlDate>));

			return as_;
		};
		var m_ = context.Operators.Select<Tuple_GAdRFKRaHUUGJcVHWQWRUjhRH, CqlDate>(k_, l_);

		return m_;
	}

    [CqlDeclaration("Date VR12 Oblique Total Assessment Completed")]
	public IEnumerable<CqlDate> Date_VR12_Oblique_Total_Assessment_Completed() => 
		__Date_VR12_Oblique_Total_Assessment_Completed.Value;

	private bool? Has_THA_with_Initial_and_Follow_Up_VR12_Oblique_Assessments_Value()
	{
		var a_ = this.Total_Hip_Arthroplasty_Procedure();
		CqlInterval<CqlDateTime> b_(Procedure THAProcedure)
		{
			var i_ = THAProcedure?.Performed;
			var j_ = FHIRHelpers_4_3_000.ToValue(i_);
			var k_ = QICoreCommon_2_0_000.toInterval(j_);

			return k_;
		};
		var c_ = context.Operators.Select<Procedure, CqlInterval<CqlDateTime>>(a_, b_);
		IEnumerable<CqlInterval<CqlDateTime>> d_(CqlInterval<CqlDateTime> TotalHip)
		{
			var l_ = this.Date_VR12_Oblique_Total_Assessment_Completed();
			bool? m_(CqlDate InitialHipAssessmentOblique)
			{
				var q_ = context.Operators.Start(TotalHip);
				var r_ = context.Operators.Quantity(90m, "days");
				var s_ = context.Operators.Add(InitialHipAssessmentOblique, r_);
				var t_ = context.Operators.Interval(InitialHipAssessmentOblique, s_, true, true);
				var u_ = t_?.low;
				var v_ = context.Operators.ConvertDateToDateTime(u_);
				var x_ = context.Operators.Add(InitialHipAssessmentOblique, r_);
				var y_ = context.Operators.Interval(InitialHipAssessmentOblique, x_, true, true);
				var z_ = y_?.high;
				var aa_ = context.Operators.ConvertDateToDateTime(z_);
				var ac_ = context.Operators.Add(InitialHipAssessmentOblique, r_);
				var ad_ = context.Operators.Interval(InitialHipAssessmentOblique, ac_, true, true);
				var ae_ = ad_?.lowClosed;
				var ag_ = context.Operators.Add(InitialHipAssessmentOblique, r_);
				var ah_ = context.Operators.Interval(InitialHipAssessmentOblique, ag_, true, true);
				var ai_ = ah_?.highClosed;
				var aj_ = context.Operators.Interval(v_, aa_, ae_, ai_);
				var ak_ = context.Operators.In<CqlDateTime>(q_, aj_, "day");
				var al_ = context.Operators.Not((bool?)(InitialHipAssessmentOblique is null));
				var am_ = context.Operators.And(ak_, al_);

				return am_;
			};
			var n_ = context.Operators.Where<CqlDate>(l_, m_);
			CqlInterval<CqlDateTime> o_(CqlDate InitialHipAssessmentOblique) => 
				TotalHip;
			var p_ = context.Operators.Select<CqlDate, CqlInterval<CqlDateTime>>(n_, o_);

			return p_;
		};
		var e_ = context.Operators.SelectMany<CqlInterval<CqlDateTime>, CqlInterval<CqlDateTime>>(c_, d_);
		IEnumerable<CqlInterval<CqlDateTime>> f_(CqlInterval<CqlDateTime> TotalHip)
		{
			var an_ = this.Date_VR12_Oblique_Total_Assessment_Completed();
			bool? ao_(CqlDate FollowUpHipAssessmentOblique)
			{
				var as_ = context.Operators.ConvertDateToDateTime(FollowUpHipAssessmentOblique);
				var at_ = context.Operators.DateFrom(as_);
				var au_ = context.Operators.End(TotalHip);
				var av_ = context.Operators.DateFrom(au_);
				var aw_ = context.Operators.Quantity(300m, "days");
				var ax_ = context.Operators.Add(av_, aw_);
				var az_ = context.Operators.DateFrom(au_);
				var ba_ = context.Operators.Quantity(425m, "days");
				var bb_ = context.Operators.Add(az_, ba_);
				var bc_ = context.Operators.Interval(ax_, bb_, true, true);
				var bd_ = context.Operators.In<CqlDate>(at_, bc_, "day");

				return bd_;
			};
			var ap_ = context.Operators.Where<CqlDate>(an_, ao_);
			CqlInterval<CqlDateTime> aq_(CqlDate FollowUpHipAssessmentOblique) => 
				TotalHip;
			var ar_ = context.Operators.Select<CqlDate, CqlInterval<CqlDateTime>>(ap_, aq_);

			return ar_;
		};
		var g_ = context.Operators.SelectMany<CqlInterval<CqlDateTime>, CqlInterval<CqlDateTime>>(e_, f_);
		var h_ = context.Operators.Exists<CqlInterval<CqlDateTime>>(g_);

		return h_;
	}

    [CqlDeclaration("Has THA with Initial and Follow Up VR12 Oblique Assessments")]
	public bool? Has_THA_with_Initial_and_Follow_Up_VR12_Oblique_Assessments() => 
		__Has_THA_with_Initial_and_Follow_Up_VR12_Oblique_Assessments.Value;

	private IEnumerable<CqlDate> Date_VR12_Orthogonal_Total_Assessment_Completed_Value()
	{
		var a_ = this.VR_12_Mental_component_summary__MCS__score___orthogonal_method_T_score();
		var b_ = context.Operators.ToList<CqlCode>(a_);
		var c_ = context.Operators.RetrieveByCodes<Observation>(b_, null);
		var d_ = this.VR_12_Physical_component_summary__PCS__score___orthogonal_method_T_score();
		var e_ = context.Operators.ToList<CqlCode>(d_);
		var f_ = context.Operators.RetrieveByCodes<Observation>(e_, null);
		var g_ = context.Operators.CrossJoin<Observation, Observation>(c_, f_);
		Tuple_GAdRFKRaHUUGJcVHWQWRUjhRH h_(ValueTuple<Observation, Observation> _valueTuple)
		{
			var n_ = new Tuple_GAdRFKRaHUUGJcVHWQWRUjhRH
			{
				VR12MentalAssessment = _valueTuple.Item1,
				VR12PhysicalAssessment = _valueTuple.Item2,
			};

			return n_;
		};
		var i_ = context.Operators.Select<ValueTuple<Observation, Observation>, Tuple_GAdRFKRaHUUGJcVHWQWRUjhRH>(g_, h_);
		bool? j_(Tuple_GAdRFKRaHUUGJcVHWQWRUjhRH tuple_gadrfkrahuugjcvhwqwrujhrh)
		{
			var o_ = tuple_gadrfkrahuugjcvhwqwrujhrh.VR12MentalAssessment?.Effective;
			var p_ = FHIRHelpers_4_3_000.ToValue(o_);
			var q_ = QICoreCommon_2_0_000.toInterval(p_);
			var r_ = context.Operators.Start(q_);
			var s_ = context.Operators.DateFrom(r_);
			var t_ = tuple_gadrfkrahuugjcvhwqwrujhrh.VR12PhysicalAssessment?.Effective;
			var u_ = FHIRHelpers_4_3_000.ToValue(t_);
			var v_ = QICoreCommon_2_0_000.toInterval(u_);
			var w_ = context.Operators.Start(v_);
			var x_ = context.Operators.DateFrom(w_);
			var y_ = context.Operators.SameAs(s_, x_, "day");
			var z_ = tuple_gadrfkrahuugjcvhwqwrujhrh.VR12MentalAssessment?.Value;
			var aa_ = FHIRHelpers_4_3_000.ToValue(z_);
			var ab_ = context.Operators.Not((bool?)(aa_ is null));
			var ac_ = context.Operators.And(y_, ab_);
			var ad_ = tuple_gadrfkrahuugjcvhwqwrujhrh.VR12PhysicalAssessment?.Value;
			var ae_ = FHIRHelpers_4_3_000.ToValue(ad_);
			var af_ = context.Operators.Not((bool?)(ae_ is null));
			var ag_ = context.Operators.And(ac_, af_);

			return ag_;
		};
		var k_ = context.Operators.Where<Tuple_GAdRFKRaHUUGJcVHWQWRUjhRH>(i_, j_);
		CqlDate l_(Tuple_GAdRFKRaHUUGJcVHWQWRUjhRH tuple_gadrfkrahuugjcvhwqwrujhrh)
		{
			var ah_ = tuple_gadrfkrahuugjcvhwqwrujhrh.VR12MentalAssessment?.Effective;
			var ai_ = FHIRHelpers_4_3_000.ToValue(ah_);
			var aj_ = QICoreCommon_2_0_000.toInterval(ai_);
			var ak_ = context.Operators.Start(aj_);
			var al_ = context.Operators.DateFrom(ak_);
			var am_ = tuple_gadrfkrahuugjcvhwqwrujhrh.VR12PhysicalAssessment?.Effective;
			var an_ = FHIRHelpers_4_3_000.ToValue(am_);
			var ao_ = QICoreCommon_2_0_000.toInterval(an_);
			var ap_ = context.Operators.Start(ao_);
			var aq_ = context.Operators.DateFrom(ap_);
			var ar_ = new CqlDate[]
			{
				al_,
				aq_,
			};
			var as_ = context.Operators.Max<CqlDate>((ar_ as IEnumerable<CqlDate>));

			return as_;
		};
		var m_ = context.Operators.Select<Tuple_GAdRFKRaHUUGJcVHWQWRUjhRH, CqlDate>(k_, l_);

		return m_;
	}

    [CqlDeclaration("Date VR12 Orthogonal Total Assessment Completed")]
	public IEnumerable<CqlDate> Date_VR12_Orthogonal_Total_Assessment_Completed() => 
		__Date_VR12_Orthogonal_Total_Assessment_Completed.Value;

	private bool? Has_THA_with_Initial_and_Follow_Up_VR12_Orthogonal_Assessments_Value()
	{
		var a_ = this.Total_Hip_Arthroplasty_Procedure();
		CqlInterval<CqlDateTime> b_(Procedure THAProcedure)
		{
			var i_ = THAProcedure?.Performed;
			var j_ = FHIRHelpers_4_3_000.ToValue(i_);
			var k_ = QICoreCommon_2_0_000.toInterval(j_);

			return k_;
		};
		var c_ = context.Operators.Select<Procedure, CqlInterval<CqlDateTime>>(a_, b_);
		IEnumerable<CqlInterval<CqlDateTime>> d_(CqlInterval<CqlDateTime> TotalHip)
		{
			var l_ = this.Date_VR12_Orthogonal_Total_Assessment_Completed();
			bool? m_(CqlDate InitialHipAssessmentOrthogonal)
			{
				var q_ = context.Operators.Start(TotalHip);
				var r_ = context.Operators.Quantity(90m, "days");
				var s_ = context.Operators.Add(InitialHipAssessmentOrthogonal, r_);
				var t_ = context.Operators.Interval(InitialHipAssessmentOrthogonal, s_, true, true);
				var u_ = t_?.low;
				var v_ = context.Operators.ConvertDateToDateTime(u_);
				var x_ = context.Operators.Add(InitialHipAssessmentOrthogonal, r_);
				var y_ = context.Operators.Interval(InitialHipAssessmentOrthogonal, x_, true, true);
				var z_ = y_?.high;
				var aa_ = context.Operators.ConvertDateToDateTime(z_);
				var ac_ = context.Operators.Add(InitialHipAssessmentOrthogonal, r_);
				var ad_ = context.Operators.Interval(InitialHipAssessmentOrthogonal, ac_, true, true);
				var ae_ = ad_?.lowClosed;
				var ag_ = context.Operators.Add(InitialHipAssessmentOrthogonal, r_);
				var ah_ = context.Operators.Interval(InitialHipAssessmentOrthogonal, ag_, true, true);
				var ai_ = ah_?.highClosed;
				var aj_ = context.Operators.Interval(v_, aa_, ae_, ai_);
				var ak_ = context.Operators.In<CqlDateTime>(q_, aj_, "day");
				var al_ = context.Operators.Not((bool?)(InitialHipAssessmentOrthogonal is null));
				var am_ = context.Operators.And(ak_, al_);

				return am_;
			};
			var n_ = context.Operators.Where<CqlDate>(l_, m_);
			CqlInterval<CqlDateTime> o_(CqlDate InitialHipAssessmentOrthogonal) => 
				TotalHip;
			var p_ = context.Operators.Select<CqlDate, CqlInterval<CqlDateTime>>(n_, o_);

			return p_;
		};
		var e_ = context.Operators.SelectMany<CqlInterval<CqlDateTime>, CqlInterval<CqlDateTime>>(c_, d_);
		IEnumerable<CqlInterval<CqlDateTime>> f_(CqlInterval<CqlDateTime> TotalHip)
		{
			var an_ = this.Date_VR12_Orthogonal_Total_Assessment_Completed();
			bool? ao_(CqlDate FollowUpHipAssessmentOrthogonal)
			{
				var as_ = context.Operators.ConvertDateToDateTime(FollowUpHipAssessmentOrthogonal);
				var at_ = context.Operators.DateFrom(as_);
				var au_ = context.Operators.End(TotalHip);
				var av_ = context.Operators.DateFrom(au_);
				var aw_ = context.Operators.Quantity(300m, "days");
				var ax_ = context.Operators.Add(av_, aw_);
				var az_ = context.Operators.DateFrom(au_);
				var ba_ = context.Operators.Quantity(425m, "days");
				var bb_ = context.Operators.Add(az_, ba_);
				var bc_ = context.Operators.Interval(ax_, bb_, true, true);
				var bd_ = context.Operators.In<CqlDate>(at_, bc_, "day");

				return bd_;
			};
			var ap_ = context.Operators.Where<CqlDate>(an_, ao_);
			CqlInterval<CqlDateTime> aq_(CqlDate FollowUpHipAssessmentOrthogonal) => 
				TotalHip;
			var ar_ = context.Operators.Select<CqlDate, CqlInterval<CqlDateTime>>(ap_, aq_);

			return ar_;
		};
		var g_ = context.Operators.SelectMany<CqlInterval<CqlDateTime>, CqlInterval<CqlDateTime>>(e_, f_);
		var h_ = context.Operators.Exists<CqlInterval<CqlDateTime>>(g_);

		return h_;
	}

    [CqlDeclaration("Has THA with Initial and Follow Up VR12 Orthogonal Assessments")]
	public bool? Has_THA_with_Initial_and_Follow_Up_VR12_Orthogonal_Assessments() => 
		__Has_THA_with_Initial_and_Follow_Up_VR12_Orthogonal_Assessments.Value;

	private bool? Numerator_Value()
	{
		var a_ = this.Has_THA_with_Initial_and_Follow_Up_HOOS_Assessments();
		var b_ = this.Has_THA_with_Initial_and_Follow_Up_HOOSJr_Assessments();
		var c_ = context.Operators.Or(a_, b_);
		var d_ = this.Has_THA_with_Initial_and_Follow_Up_PROMIS10_Assessments();
		var e_ = context.Operators.Or(c_, d_);
		var f_ = this.Has_THA_with_Initial_and_Follow_Up_VR12_Oblique_Assessments();
		var g_ = context.Operators.Or(e_, f_);
		var h_ = this.Has_THA_with_Initial_and_Follow_Up_VR12_Orthogonal_Assessments();
		var i_ = context.Operators.Or(g_, h_);

		return i_;
	}

    [CqlDeclaration("Numerator")]
	public bool? Numerator() => 
		__Numerator.Value;

}
