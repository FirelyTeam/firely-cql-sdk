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
[CqlLibrary("PreventiveCareAndScreeningTobaccoUseScreeningAndCessationInterventionFHIR", "0.0.001")]
public class PreventiveCareAndScreeningTobaccoUseScreeningAndCessationInterventionFHIR_0_0_001
{


    internal CqlContext context;

    #region Cached values

    internal Lazy<CqlValueSet> __Annual_Wellness_Visit;
    internal Lazy<CqlValueSet> __Home_Healthcare_Services;
    internal Lazy<CqlValueSet> __Limited_Life_Expectancy;
    internal Lazy<CqlValueSet> __Medical_Reason;
    internal Lazy<CqlValueSet> __Nutrition_Services;
    internal Lazy<CqlValueSet> __Occupational_Therapy_Evaluation;
    internal Lazy<CqlValueSet> __Office_Visit;
    internal Lazy<CqlValueSet> __Online_Assessments;
    internal Lazy<CqlValueSet> __Ophthalmological_Services;
    internal Lazy<CqlValueSet> __Physical_Therapy_Evaluation;
    internal Lazy<CqlValueSet> __Preventive_Care_Services_Established_Office_Visit__18_and_Up;
    internal Lazy<CqlValueSet> __Preventive_Care_Services_Group_Counseling;
    internal Lazy<CqlValueSet> __Preventive_Care_Services_Individual_Counseling;
    internal Lazy<CqlValueSet> __Preventive_Care_Services_Initial_Office_Visit__18_and_Up;
    internal Lazy<CqlValueSet> __Psych_Visit_Diagnostic_Evaluation;
    internal Lazy<CqlValueSet> __Psych_Visit_Psychotherapy;
    internal Lazy<CqlValueSet> __Psychoanalysis;
    internal Lazy<CqlValueSet> __Speech_and_Hearing_Evaluation;
    internal Lazy<CqlValueSet> __Telephone_Visits;
    internal Lazy<CqlValueSet> __Tobacco_Non_User;
    internal Lazy<CqlValueSet> __Tobacco_Use_Cessation_Counseling;
    internal Lazy<CqlValueSet> __Tobacco_Use_Cessation_Pharmacotherapy;
    internal Lazy<CqlValueSet> __Tobacco_Use_Screening;
    internal Lazy<CqlValueSet> __Tobacco_User;
    internal Lazy<CqlCode> __Health_behavior_assessment__or_re_assessment__ie__health_focused_clinical_interview__behavioral_observations__clinical_decision_making_;
    internal Lazy<CqlCode> __Health_behavior_intervention__individual__face_to_face__initial_30_minutes;
    internal Lazy<CqlCode> __Postoperative_follow_up_visit__normally_included_in_the_surgical_package__to_indicate_that_an_evaluation_and_management_service_was_performed_during_a_postoperative_period_for_a_reason_s__related_to_the_original_procedure;
    internal Lazy<CqlCode> __Tobacco_abuse_counseling;
    internal Lazy<CqlCode> __Unlisted_preventive_medicine_service;
    internal Lazy<CqlCode[]> __CPT;
    internal Lazy<CqlCode[]> __ICD10CM;
    internal Lazy<CqlInterval<CqlDateTime>> __Measurement_Period;
    internal Lazy<Patient> __Patient;
    internal Lazy<IEnumerable<Encounter>> __Qualifying_Visit_During_Measurement_Period;
    internal Lazy<IEnumerable<Encounter>> __Preventive_Visit_During_Measurement_Period;
    internal Lazy<bool?> __Initial_Population;
    internal Lazy<bool?> __Denominator_1;
    internal Lazy<Observation> __Most_Recent_Tobacco_Use_Screening_Indicates_Tobacco_User;
    internal Lazy<bool?> __Denominator_2;
    internal Lazy<bool?> __Denominator_3;
    internal Lazy<Observation> __Most_Recent_Tobacco_Use_Screening_Indicates_Tobacco_Non_User;
    internal Lazy<bool?> __Numerator_1;
    internal Lazy<IEnumerable<object>> __Tobacco_Cessation_Counseling_Given;
    internal Lazy<IEnumerable<MedicationRequest>> __Tobacco_Cessation_Pharmacotherapy_Ordered;
    internal Lazy<IEnumerable<MedicationRequest>> __Active_Pharmacotherapy_for_Tobacco_Cessation;
    internal Lazy<bool?> __Numerator_2;
    internal Lazy<bool?> __Numerator_3;
    internal Lazy<bool?> __Denominator_Exclusion;
    internal Lazy<(IEnumerable<CqlCode> codes, string display)?> __SDE_Ethnicity;
    internal Lazy<IEnumerable<(CqlConcept code, CqlInterval<CqlDateTime> period)?>> __SDE_Payer;
    internal Lazy<(IEnumerable<CqlCode> codes, string display)?> __SDE_Race;
    internal Lazy<CqlCode> __SDE_Sex;

    #endregion
    public PreventiveCareAndScreeningTobaccoUseScreeningAndCessationInterventionFHIR_0_0_001(CqlContext context)
    {
        this.context = context ?? throw new ArgumentNullException("context");

        CQMCommon_2_0_000 = new CQMCommon_2_0_000(context);
        Status_1_6_000 = new Status_1_6_000(context);
        FHIRHelpers_4_3_000 = new FHIRHelpers_4_3_000(context);
        SupplementalDataElements_3_4_000 = new SupplementalDataElements_3_4_000(context);
        QICoreCommon_2_0_000 = new QICoreCommon_2_0_000(context);
        Hospice_6_9_000 = new Hospice_6_9_000(context);
        CumulativeMedicationDuration_4_0_000 = new CumulativeMedicationDuration_4_0_000(context);

        __Annual_Wellness_Visit = new Lazy<CqlValueSet>(this.Annual_Wellness_Visit_Value);
        __Home_Healthcare_Services = new Lazy<CqlValueSet>(this.Home_Healthcare_Services_Value);
        __Limited_Life_Expectancy = new Lazy<CqlValueSet>(this.Limited_Life_Expectancy_Value);
        __Medical_Reason = new Lazy<CqlValueSet>(this.Medical_Reason_Value);
        __Nutrition_Services = new Lazy<CqlValueSet>(this.Nutrition_Services_Value);
        __Occupational_Therapy_Evaluation = new Lazy<CqlValueSet>(this.Occupational_Therapy_Evaluation_Value);
        __Office_Visit = new Lazy<CqlValueSet>(this.Office_Visit_Value);
        __Online_Assessments = new Lazy<CqlValueSet>(this.Online_Assessments_Value);
        __Ophthalmological_Services = new Lazy<CqlValueSet>(this.Ophthalmological_Services_Value);
        __Physical_Therapy_Evaluation = new Lazy<CqlValueSet>(this.Physical_Therapy_Evaluation_Value);
        __Preventive_Care_Services_Established_Office_Visit__18_and_Up = new Lazy<CqlValueSet>(this.Preventive_Care_Services_Established_Office_Visit__18_and_Up_Value);
        __Preventive_Care_Services_Group_Counseling = new Lazy<CqlValueSet>(this.Preventive_Care_Services_Group_Counseling_Value);
        __Preventive_Care_Services_Individual_Counseling = new Lazy<CqlValueSet>(this.Preventive_Care_Services_Individual_Counseling_Value);
        __Preventive_Care_Services_Initial_Office_Visit__18_and_Up = new Lazy<CqlValueSet>(this.Preventive_Care_Services_Initial_Office_Visit__18_and_Up_Value);
        __Psych_Visit_Diagnostic_Evaluation = new Lazy<CqlValueSet>(this.Psych_Visit_Diagnostic_Evaluation_Value);
        __Psych_Visit_Psychotherapy = new Lazy<CqlValueSet>(this.Psych_Visit_Psychotherapy_Value);
        __Psychoanalysis = new Lazy<CqlValueSet>(this.Psychoanalysis_Value);
        __Speech_and_Hearing_Evaluation = new Lazy<CqlValueSet>(this.Speech_and_Hearing_Evaluation_Value);
        __Telephone_Visits = new Lazy<CqlValueSet>(this.Telephone_Visits_Value);
        __Tobacco_Non_User = new Lazy<CqlValueSet>(this.Tobacco_Non_User_Value);
        __Tobacco_Use_Cessation_Counseling = new Lazy<CqlValueSet>(this.Tobacco_Use_Cessation_Counseling_Value);
        __Tobacco_Use_Cessation_Pharmacotherapy = new Lazy<CqlValueSet>(this.Tobacco_Use_Cessation_Pharmacotherapy_Value);
        __Tobacco_Use_Screening = new Lazy<CqlValueSet>(this.Tobacco_Use_Screening_Value);
        __Tobacco_User = new Lazy<CqlValueSet>(this.Tobacco_User_Value);
        __Health_behavior_assessment__or_re_assessment__ie__health_focused_clinical_interview__behavioral_observations__clinical_decision_making_ = new Lazy<CqlCode>(this.Health_behavior_assessment__or_re_assessment__ie__health_focused_clinical_interview__behavioral_observations__clinical_decision_making__Value);
        __Health_behavior_intervention__individual__face_to_face__initial_30_minutes = new Lazy<CqlCode>(this.Health_behavior_intervention__individual__face_to_face__initial_30_minutes_Value);
        __Postoperative_follow_up_visit__normally_included_in_the_surgical_package__to_indicate_that_an_evaluation_and_management_service_was_performed_during_a_postoperative_period_for_a_reason_s__related_to_the_original_procedure = new Lazy<CqlCode>(this.Postoperative_follow_up_visit__normally_included_in_the_surgical_package__to_indicate_that_an_evaluation_and_management_service_was_performed_during_a_postoperative_period_for_a_reason_s__related_to_the_original_procedure_Value);
        __Tobacco_abuse_counseling = new Lazy<CqlCode>(this.Tobacco_abuse_counseling_Value);
        __Unlisted_preventive_medicine_service = new Lazy<CqlCode>(this.Unlisted_preventive_medicine_service_Value);
        __CPT = new Lazy<CqlCode[]>(this.CPT_Value);
        __ICD10CM = new Lazy<CqlCode[]>(this.ICD10CM_Value);
        __Measurement_Period = new Lazy<CqlInterval<CqlDateTime>>(this.Measurement_Period_Value);
        __Patient = new Lazy<Patient>(this.Patient_Value);
        __Qualifying_Visit_During_Measurement_Period = new Lazy<IEnumerable<Encounter>>(this.Qualifying_Visit_During_Measurement_Period_Value);
        __Preventive_Visit_During_Measurement_Period = new Lazy<IEnumerable<Encounter>>(this.Preventive_Visit_During_Measurement_Period_Value);
        __Initial_Population = new Lazy<bool?>(this.Initial_Population_Value);
        __Denominator_1 = new Lazy<bool?>(this.Denominator_1_Value);
        __Most_Recent_Tobacco_Use_Screening_Indicates_Tobacco_User = new Lazy<Observation>(this.Most_Recent_Tobacco_Use_Screening_Indicates_Tobacco_User_Value);
        __Denominator_2 = new Lazy<bool?>(this.Denominator_2_Value);
        __Denominator_3 = new Lazy<bool?>(this.Denominator_3_Value);
        __Most_Recent_Tobacco_Use_Screening_Indicates_Tobacco_Non_User = new Lazy<Observation>(this.Most_Recent_Tobacco_Use_Screening_Indicates_Tobacco_Non_User_Value);
        __Numerator_1 = new Lazy<bool?>(this.Numerator_1_Value);
        __Tobacco_Cessation_Counseling_Given = new Lazy<IEnumerable<object>>(this.Tobacco_Cessation_Counseling_Given_Value);
        __Tobacco_Cessation_Pharmacotherapy_Ordered = new Lazy<IEnumerable<MedicationRequest>>(this.Tobacco_Cessation_Pharmacotherapy_Ordered_Value);
        __Active_Pharmacotherapy_for_Tobacco_Cessation = new Lazy<IEnumerable<MedicationRequest>>(this.Active_Pharmacotherapy_for_Tobacco_Cessation_Value);
        __Numerator_2 = new Lazy<bool?>(this.Numerator_2_Value);
        __Numerator_3 = new Lazy<bool?>(this.Numerator_3_Value);
        __Denominator_Exclusion = new Lazy<bool?>(this.Denominator_Exclusion_Value);
        __SDE_Ethnicity = new Lazy<(IEnumerable<CqlCode> codes, string display)?>(this.SDE_Ethnicity_Value);
        __SDE_Payer = new Lazy<IEnumerable<(CqlConcept code, CqlInterval<CqlDateTime> period)?>>(this.SDE_Payer_Value);
        __SDE_Race = new Lazy<(IEnumerable<CqlCode> codes, string display)?>(this.SDE_Race_Value);
        __SDE_Sex = new Lazy<CqlCode>(this.SDE_Sex_Value);
    }
    #region Dependencies

    public CQMCommon_2_0_000 CQMCommon_2_0_000 { get; }
    public Status_1_6_000 Status_1_6_000 { get; }
    public FHIRHelpers_4_3_000 FHIRHelpers_4_3_000 { get; }
    public SupplementalDataElements_3_4_000 SupplementalDataElements_3_4_000 { get; }
    public QICoreCommon_2_0_000 QICoreCommon_2_0_000 { get; }
    public Hospice_6_9_000 Hospice_6_9_000 { get; }
    public CumulativeMedicationDuration_4_0_000 CumulativeMedicationDuration_4_0_000 { get; }

    #endregion

	private CqlValueSet Annual_Wellness_Visit_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1240", default);

    [CqlDeclaration("Annual Wellness Visit")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1240")]
	public CqlValueSet Annual_Wellness_Visit() => 
		__Annual_Wellness_Visit.Value;

	private CqlValueSet Home_Healthcare_Services_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1016", default);

    [CqlDeclaration("Home Healthcare Services")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1016")]
	public CqlValueSet Home_Healthcare_Services() => 
		__Home_Healthcare_Services.Value;

	private CqlValueSet Limited_Life_Expectancy_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1259", default);

    [CqlDeclaration("Limited Life Expectancy")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1259")]
	public CqlValueSet Limited_Life_Expectancy() => 
		__Limited_Life_Expectancy.Value;

	private CqlValueSet Medical_Reason_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1007", default);

    [CqlDeclaration("Medical Reason")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1007")]
	public CqlValueSet Medical_Reason() => 
		__Medical_Reason.Value;

	private CqlValueSet Nutrition_Services_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.1006", default);

    [CqlDeclaration("Nutrition Services")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.1006")]
	public CqlValueSet Nutrition_Services() => 
		__Nutrition_Services.Value;

	private CqlValueSet Occupational_Therapy_Evaluation_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1011", default);

    [CqlDeclaration("Occupational Therapy Evaluation")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1011")]
	public CqlValueSet Occupational_Therapy_Evaluation() => 
		__Occupational_Therapy_Evaluation.Value;

	private CqlValueSet Office_Visit_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1001", default);

    [CqlDeclaration("Office Visit")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1001")]
	public CqlValueSet Office_Visit() => 
		__Office_Visit.Value;

	private CqlValueSet Online_Assessments_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1089", default);

    [CqlDeclaration("Online Assessments")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1089")]
	public CqlValueSet Online_Assessments() => 
		__Online_Assessments.Value;

	private CqlValueSet Ophthalmological_Services_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1285", default);

    [CqlDeclaration("Ophthalmological Services")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1285")]
	public CqlValueSet Ophthalmological_Services() => 
		__Ophthalmological_Services.Value;

	private CqlValueSet Physical_Therapy_Evaluation_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1022", default);

    [CqlDeclaration("Physical Therapy Evaluation")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1022")]
	public CqlValueSet Physical_Therapy_Evaluation() => 
		__Physical_Therapy_Evaluation.Value;

	private CqlValueSet Preventive_Care_Services_Established_Office_Visit__18_and_Up_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1025", default);

    [CqlDeclaration("Preventive Care Services Established Office Visit, 18 and Up")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1025")]
	public CqlValueSet Preventive_Care_Services_Established_Office_Visit__18_and_Up() => 
		__Preventive_Care_Services_Established_Office_Visit__18_and_Up.Value;

	private CqlValueSet Preventive_Care_Services_Group_Counseling_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1027", default);

    [CqlDeclaration("Preventive Care Services Group Counseling")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1027")]
	public CqlValueSet Preventive_Care_Services_Group_Counseling() => 
		__Preventive_Care_Services_Group_Counseling.Value;

	private CqlValueSet Preventive_Care_Services_Individual_Counseling_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1026", default);

    [CqlDeclaration("Preventive Care Services Individual Counseling")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1026")]
	public CqlValueSet Preventive_Care_Services_Individual_Counseling() => 
		__Preventive_Care_Services_Individual_Counseling.Value;

	private CqlValueSet Preventive_Care_Services_Initial_Office_Visit__18_and_Up_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1023", default);

    [CqlDeclaration("Preventive Care Services Initial Office Visit, 18 and Up")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1023")]
	public CqlValueSet Preventive_Care_Services_Initial_Office_Visit__18_and_Up() => 
		__Preventive_Care_Services_Initial_Office_Visit__18_and_Up.Value;

	private CqlValueSet Psych_Visit_Diagnostic_Evaluation_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1492", default);

    [CqlDeclaration("Psych Visit Diagnostic Evaluation")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1492")]
	public CqlValueSet Psych_Visit_Diagnostic_Evaluation() => 
		__Psych_Visit_Diagnostic_Evaluation.Value;

	private CqlValueSet Psych_Visit_Psychotherapy_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1496", default);

    [CqlDeclaration("Psych Visit Psychotherapy")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1496")]
	public CqlValueSet Psych_Visit_Psychotherapy() => 
		__Psych_Visit_Psychotherapy.Value;

	private CqlValueSet Psychoanalysis_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1141", default);

    [CqlDeclaration("Psychoanalysis")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1141")]
	public CqlValueSet Psychoanalysis() => 
		__Psychoanalysis.Value;

	private CqlValueSet Speech_and_Hearing_Evaluation_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1530", default);

    [CqlDeclaration("Speech and Hearing Evaluation")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1530")]
	public CqlValueSet Speech_and_Hearing_Evaluation() => 
		__Speech_and_Hearing_Evaluation.Value;

	private CqlValueSet Telephone_Visits_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1080", default);

    [CqlDeclaration("Telephone Visits")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1080")]
	public CqlValueSet Telephone_Visits() => 
		__Telephone_Visits.Value;

	private CqlValueSet Tobacco_Non_User_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1189", default);

    [CqlDeclaration("Tobacco Non User")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1189")]
	public CqlValueSet Tobacco_Non_User() => 
		__Tobacco_Non_User.Value;

	private CqlValueSet Tobacco_Use_Cessation_Counseling_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.509", default);

    [CqlDeclaration("Tobacco Use Cessation Counseling")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.509")]
	public CqlValueSet Tobacco_Use_Cessation_Counseling() => 
		__Tobacco_Use_Cessation_Counseling.Value;

	private CqlValueSet Tobacco_Use_Cessation_Pharmacotherapy_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1190", default);

    [CqlDeclaration("Tobacco Use Cessation Pharmacotherapy")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1190")]
	public CqlValueSet Tobacco_Use_Cessation_Pharmacotherapy() => 
		__Tobacco_Use_Cessation_Pharmacotherapy.Value;

	private CqlValueSet Tobacco_Use_Screening_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1278", default);

    [CqlDeclaration("Tobacco Use Screening")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1278")]
	public CqlValueSet Tobacco_Use_Screening() => 
		__Tobacco_Use_Screening.Value;

	private CqlValueSet Tobacco_User_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1170", default);

    [CqlDeclaration("Tobacco User")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1170")]
	public CqlValueSet Tobacco_User() => 
		__Tobacco_User.Value;

	private CqlCode Health_behavior_assessment__or_re_assessment__ie__health_focused_clinical_interview__behavioral_observations__clinical_decision_making__Value() => 
		new CqlCode("96156", "http://www.ama-assn.org/go/cpt", default, default);

    [CqlDeclaration("Health behavior assessment, or re-assessment (ie, health-focused clinical interview, behavioral observations, clinical decision making)")]
	public CqlCode Health_behavior_assessment__or_re_assessment__ie__health_focused_clinical_interview__behavioral_observations__clinical_decision_making_() => 
		__Health_behavior_assessment__or_re_assessment__ie__health_focused_clinical_interview__behavioral_observations__clinical_decision_making_.Value;

	private CqlCode Health_behavior_intervention__individual__face_to_face__initial_30_minutes_Value() => 
		new CqlCode("96158", "http://www.ama-assn.org/go/cpt", default, default);

    [CqlDeclaration("Health behavior intervention, individual, face-to-face; initial 30 minutes")]
	public CqlCode Health_behavior_intervention__individual__face_to_face__initial_30_minutes() => 
		__Health_behavior_intervention__individual__face_to_face__initial_30_minutes.Value;

	private CqlCode Postoperative_follow_up_visit__normally_included_in_the_surgical_package__to_indicate_that_an_evaluation_and_management_service_was_performed_during_a_postoperative_period_for_a_reason_s__related_to_the_original_procedure_Value() => 
		new CqlCode("99024", "http://www.ama-assn.org/go/cpt", default, default);

    [CqlDeclaration("Postoperative follow-up visit, normally included in the surgical package, to indicate that an evaluation and management service was performed during a postoperative period for a reason(s) related to the original procedure")]
	public CqlCode Postoperative_follow_up_visit__normally_included_in_the_surgical_package__to_indicate_that_an_evaluation_and_management_service_was_performed_during_a_postoperative_period_for_a_reason_s__related_to_the_original_procedure() => 
		__Postoperative_follow_up_visit__normally_included_in_the_surgical_package__to_indicate_that_an_evaluation_and_management_service_was_performed_during_a_postoperative_period_for_a_reason_s__related_to_the_original_procedure.Value;

	private CqlCode Tobacco_abuse_counseling_Value() => 
		new CqlCode("Z71.6", "http://hl7.org/fhir/sid/icd-10-cm", default, default);

    [CqlDeclaration("Tobacco abuse counseling")]
	public CqlCode Tobacco_abuse_counseling() => 
		__Tobacco_abuse_counseling.Value;

	private CqlCode Unlisted_preventive_medicine_service_Value() => 
		new CqlCode("99429", "http://www.ama-assn.org/go/cpt", default, default);

    [CqlDeclaration("Unlisted preventive medicine service")]
	public CqlCode Unlisted_preventive_medicine_service() => 
		__Unlisted_preventive_medicine_service.Value;

	private CqlCode[] CPT_Value()
	{
		CqlCode[] a_ = [
			new CqlCode("96156", "http://www.ama-assn.org/go/cpt", default, default),
			new CqlCode("96158", "http://www.ama-assn.org/go/cpt", default, default),
			new CqlCode("99024", "http://www.ama-assn.org/go/cpt", default, default),
			new CqlCode("99429", "http://www.ama-assn.org/go/cpt", default, default),
		];

		return a_;
	}

    [CqlDeclaration("CPT")]
	public CqlCode[] CPT() => 
		__CPT.Value;

	private CqlCode[] ICD10CM_Value()
	{
		CqlCode[] a_ = [
			new CqlCode("Z71.6", "http://hl7.org/fhir/sid/icd-10-cm", default, default),
		];

		return a_;
	}

    [CqlDeclaration("ICD10CM")]
	public CqlCode[] ICD10CM() => 
		__ICD10CM.Value;

	private CqlInterval<CqlDateTime> Measurement_Period_Value()
	{
		CqlDateTime a_ = context.Operators.DateTime(2025, 1, 1, 0, 0, 0, 0, default);
		CqlDateTime b_ = context.Operators.DateTime(2026, 1, 1, 0, 0, 0, 0, default);
		CqlInterval<CqlDateTime> c_ = context.Operators.Interval(a_, b_, true, false);
		object d_ = context.ResolveParameter("PreventiveCareAndScreeningTobaccoUseScreeningAndCessationInterventionFHIR-0.0.001", "Measurement Period", c_);

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

	private IEnumerable<Encounter> Qualifying_Visit_During_Measurement_Period_Value()
	{
		CqlValueSet a_ = this.Home_Healthcare_Services();
		IEnumerable<Encounter> b_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
		IEnumerable<Encounter> c_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
		bool? d_(Encounter E)
		{
			List<CodeableConcept> ar_ = E?.Type;
			CqlConcept as_(CodeableConcept @this)
			{
				CqlConcept ax_ = FHIRHelpers_4_3_000.ToConcept(@this);

				return ax_;
			};
			IEnumerable<CqlConcept> at_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)ar_, as_);
			bool? au_(CqlConcept T)
			{
				CqlCode ay_ = this.Health_behavior_assessment__or_re_assessment__ie__health_focused_clinical_interview__behavioral_observations__clinical_decision_making_();
				CqlConcept az_ = context.Operators.ConvertCodeToConcept(ay_);
				bool? ba_ = context.Operators.Equivalent(T, az_);

				return ba_;
			};
			IEnumerable<CqlConcept> av_ = context.Operators.Where<CqlConcept>(at_, au_);
			bool? aw_ = context.Operators.Exists<CqlConcept>(av_);

			return aw_;
		};
		IEnumerable<Encounter> e_ = context.Operators.Where<Encounter>(c_, d_);
		IEnumerable<Encounter> f_ = context.Operators.Union<Encounter>(b_, e_);
		bool? h_(Encounter E)
		{
			List<CodeableConcept> bb_ = E?.Type;
			CqlConcept bc_(CodeableConcept @this)
			{
				CqlConcept bh_ = FHIRHelpers_4_3_000.ToConcept(@this);

				return bh_;
			};
			IEnumerable<CqlConcept> bd_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)bb_, bc_);
			bool? be_(CqlConcept T)
			{
				CqlCode bi_ = this.Health_behavior_intervention__individual__face_to_face__initial_30_minutes();
				CqlConcept bj_ = context.Operators.ConvertCodeToConcept(bi_);
				bool? bk_ = context.Operators.Equivalent(T, bj_);

				return bk_;
			};
			IEnumerable<CqlConcept> bf_ = context.Operators.Where<CqlConcept>(bd_, be_);
			bool? bg_ = context.Operators.Exists<CqlConcept>(bf_);

			return bg_;
		};
		IEnumerable<Encounter> i_ = context.Operators.Where<Encounter>(c_, h_);
		CqlValueSet j_ = this.Occupational_Therapy_Evaluation();
		IEnumerable<Encounter> k_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, j_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
		IEnumerable<Encounter> l_ = context.Operators.Union<Encounter>(i_, k_);
		IEnumerable<Encounter> m_ = context.Operators.Union<Encounter>(f_, l_);
		CqlValueSet n_ = this.Office_Visit();
		IEnumerable<Encounter> o_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, n_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
		CqlValueSet p_ = this.Ophthalmological_Services();
		IEnumerable<Encounter> q_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, p_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
		IEnumerable<Encounter> r_ = context.Operators.Union<Encounter>(o_, q_);
		IEnumerable<Encounter> s_ = context.Operators.Union<Encounter>(m_, r_);
		CqlValueSet t_ = this.Physical_Therapy_Evaluation();
		IEnumerable<Encounter> u_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, t_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
		CqlValueSet v_ = this.Psych_Visit_Diagnostic_Evaluation();
		IEnumerable<Encounter> w_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, v_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
		IEnumerable<Encounter> x_ = context.Operators.Union<Encounter>(u_, w_);
		IEnumerable<Encounter> y_ = context.Operators.Union<Encounter>(s_, x_);
		CqlValueSet z_ = this.Psych_Visit_Psychotherapy();
		IEnumerable<Encounter> aa_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, z_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
		CqlValueSet ab_ = this.Psychoanalysis();
		IEnumerable<Encounter> ac_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, ab_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
		IEnumerable<Encounter> ad_ = context.Operators.Union<Encounter>(aa_, ac_);
		IEnumerable<Encounter> ae_ = context.Operators.Union<Encounter>(y_, ad_);
		CqlValueSet af_ = this.Speech_and_Hearing_Evaluation();
		IEnumerable<Encounter> ag_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, af_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
		CqlValueSet ah_ = this.Telephone_Visits();
		IEnumerable<Encounter> ai_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, ah_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
		IEnumerable<Encounter> aj_ = context.Operators.Union<Encounter>(ag_, ai_);
		IEnumerable<Encounter> ak_ = context.Operators.Union<Encounter>(ae_, aj_);
		CqlValueSet al_ = this.Online_Assessments();
		IEnumerable<Encounter> am_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, al_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
		IEnumerable<Encounter> an_ = context.Operators.Union<Encounter>(ak_, am_);
		IEnumerable<Encounter> ao_ = Status_1_6_000.isEncounterPerformed(an_);
		bool? ap_(Encounter OfficeBasedEncounter)
		{
			CqlInterval<CqlDateTime> bl_ = this.Measurement_Period();
			Period bm_ = OfficeBasedEncounter?.Period;
			CqlInterval<CqlDateTime> bn_ = FHIRHelpers_4_3_000.ToInterval(bm_);
			CqlInterval<CqlDateTime> bo_ = QICoreCommon_2_0_000.toInterval(bn_ as object);
			bool? bp_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(bl_, bo_, "day");

			return bp_;
		};
		IEnumerable<Encounter> aq_ = context.Operators.Where<Encounter>(ao_, ap_);

		return aq_;
	}

    [CqlDeclaration("Qualifying Visit During Measurement Period")]
	public IEnumerable<Encounter> Qualifying_Visit_During_Measurement_Period() => 
		__Qualifying_Visit_During_Measurement_Period.Value;

	private IEnumerable<Encounter> Preventive_Visit_During_Measurement_Period_Value()
	{
		CqlValueSet a_ = this.Annual_Wellness_Visit();
		IEnumerable<Encounter> b_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
		CqlValueSet c_ = this.Preventive_Care_Services_Established_Office_Visit__18_and_Up();
		IEnumerable<Encounter> d_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, c_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
		IEnumerable<Encounter> e_ = context.Operators.Union<Encounter>(b_, d_);
		CqlValueSet f_ = this.Preventive_Care_Services_Group_Counseling();
		IEnumerable<Encounter> g_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, f_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
		IEnumerable<Encounter> h_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
		bool? i_(Encounter E)
		{
			List<CodeableConcept> ac_ = E?.Type;
			CqlConcept ad_(CodeableConcept @this)
			{
				CqlConcept ai_ = FHIRHelpers_4_3_000.ToConcept(@this);

				return ai_;
			};
			IEnumerable<CqlConcept> ae_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)ac_, ad_);
			bool? af_(CqlConcept T)
			{
				CqlCode aj_ = this.Unlisted_preventive_medicine_service();
				CqlConcept ak_ = context.Operators.ConvertCodeToConcept(aj_);
				bool? al_ = context.Operators.Equivalent(T, ak_);

				return al_;
			};
			IEnumerable<CqlConcept> ag_ = context.Operators.Where<CqlConcept>(ae_, af_);
			bool? ah_ = context.Operators.Exists<CqlConcept>(ag_);

			return ah_;
		};
		IEnumerable<Encounter> j_ = context.Operators.Where<Encounter>(h_, i_);
		IEnumerable<Encounter> k_ = context.Operators.Union<Encounter>(g_, j_);
		IEnumerable<Encounter> l_ = context.Operators.Union<Encounter>(e_, k_);
		CqlValueSet m_ = this.Preventive_Care_Services_Individual_Counseling();
		IEnumerable<Encounter> n_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, m_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
		bool? p_(Encounter E)
		{
			List<CodeableConcept> am_ = E?.Type;
			CqlConcept an_(CodeableConcept @this)
			{
				CqlConcept as_ = FHIRHelpers_4_3_000.ToConcept(@this);

				return as_;
			};
			IEnumerable<CqlConcept> ao_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)am_, an_);
			bool? ap_(CqlConcept T)
			{
				CqlCode at_ = this.Postoperative_follow_up_visit__normally_included_in_the_surgical_package__to_indicate_that_an_evaluation_and_management_service_was_performed_during_a_postoperative_period_for_a_reason_s__related_to_the_original_procedure();
				CqlConcept au_ = context.Operators.ConvertCodeToConcept(at_);
				bool? av_ = context.Operators.Equivalent(T, au_);

				return av_;
			};
			IEnumerable<CqlConcept> aq_ = context.Operators.Where<CqlConcept>(ao_, ap_);
			bool? ar_ = context.Operators.Exists<CqlConcept>(aq_);

			return ar_;
		};
		IEnumerable<Encounter> q_ = context.Operators.Where<Encounter>(h_, p_);
		IEnumerable<Encounter> r_ = context.Operators.Union<Encounter>(n_, q_);
		IEnumerable<Encounter> s_ = context.Operators.Union<Encounter>(l_, r_);
		CqlValueSet t_ = this.Nutrition_Services();
		IEnumerable<Encounter> u_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, t_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
		CqlValueSet v_ = this.Preventive_Care_Services_Initial_Office_Visit__18_and_Up();
		IEnumerable<Encounter> w_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, v_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
		IEnumerable<Encounter> x_ = context.Operators.Union<Encounter>(u_, w_);
		IEnumerable<Encounter> y_ = context.Operators.Union<Encounter>(s_, x_);
		IEnumerable<Encounter> z_ = Status_1_6_000.isEncounterPerformed(y_);
		bool? aa_(Encounter PreventiveEncounter)
		{
			CqlInterval<CqlDateTime> aw_ = this.Measurement_Period();
			Period ax_ = PreventiveEncounter?.Period;
			CqlInterval<CqlDateTime> ay_ = FHIRHelpers_4_3_000.ToInterval(ax_);
			CqlInterval<CqlDateTime> az_ = QICoreCommon_2_0_000.toInterval(ay_ as object);
			bool? ba_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(aw_, az_, "day");

			return ba_;
		};
		IEnumerable<Encounter> ab_ = context.Operators.Where<Encounter>(z_, aa_);

		return ab_;
	}

    [CqlDeclaration("Preventive Visit During Measurement Period")]
	public IEnumerable<Encounter> Preventive_Visit_During_Measurement_Period() => 
		__Preventive_Visit_During_Measurement_Period.Value;

	private bool? Initial_Population_Value()
	{
		Patient a_ = this.Patient();
		Date b_ = a_?.BirthDateElement;
		string c_ = b_?.Value;
		CqlDate d_ = context.Operators.ConvertStringToDate(c_);
		CqlInterval<CqlDateTime> e_ = this.Measurement_Period();
		CqlDateTime f_ = context.Operators.Start(e_);
		CqlDate g_ = context.Operators.DateFrom(f_);
		int? h_ = context.Operators.CalculateAgeAt(d_, g_, "year");
		bool? i_ = context.Operators.GreaterOrEqual(h_, 12);
		IEnumerable<Encounter> j_ = this.Qualifying_Visit_During_Measurement_Period();
		int? k_ = context.Operators.Count<Encounter>(j_);
		bool? l_ = context.Operators.GreaterOrEqual(k_, 2);
		IEnumerable<Encounter> m_ = this.Preventive_Visit_During_Measurement_Period();
		bool? n_ = context.Operators.Exists<Encounter>(m_);
		bool? o_ = context.Operators.Or(l_, n_);
		bool? p_ = context.Operators.And(i_, o_);

		return p_;
	}

    [CqlDeclaration("Initial Population")]
	public bool? Initial_Population() => 
		__Initial_Population.Value;

	private bool? Denominator_1_Value()
	{
		bool? a_ = this.Initial_Population();

		return a_;
	}

    [CqlDeclaration("Denominator 1")]
	public bool? Denominator_1() => 
		__Denominator_1.Value;

	private Observation Most_Recent_Tobacco_Use_Screening_Indicates_Tobacco_User_Value()
	{
		CqlValueSet a_ = this.Tobacco_Use_Screening();
		IEnumerable<Observation> b_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
		IEnumerable<Observation> c_ = Status_1_6_000.isAssessmentPerformed(b_);
		bool? d_(Observation TobaccoUseScreening)
		{
			CqlInterval<CqlDateTime> m_ = this.Measurement_Period();
			DataType n_ = TobaccoUseScreening?.Effective;
			object o_ = FHIRHelpers_4_3_000.ToValue(n_);
			CqlInterval<CqlDateTime> p_ = QICoreCommon_2_0_000.toInterval(o_);
			bool? q_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(m_, p_, "day");

			return q_;
		};
		IEnumerable<Observation> e_ = context.Operators.Where<Observation>(c_, d_);
		object f_(Observation @this)
		{
			DataType r_ = @this?.Effective;
			object s_ = FHIRHelpers_4_3_000.ToValue(r_);
			CqlInterval<CqlDateTime> t_ = QICoreCommon_2_0_000.toInterval(s_);
			CqlDateTime u_ = context.Operators.Start(t_);

			return u_;
		};
		IEnumerable<Observation> g_ = context.Operators.SortBy<Observation>(e_, f_, System.ComponentModel.ListSortDirection.Ascending);
		Observation h_ = context.Operators.Last<Observation>(g_);
		Observation[] i_ = [
			h_,
		];
		bool? j_(Observation MostRecentTobaccoUseScreening)
		{
			DataType v_ = MostRecentTobaccoUseScreening?.Value;
			object w_ = FHIRHelpers_4_3_000.ToValue(v_);
			CqlValueSet x_ = this.Tobacco_User();
			bool? y_ = context.Operators.ConceptInValueSet(w_ as CqlConcept, x_);

			return y_;
		};
		IEnumerable<Observation> k_ = context.Operators.Where<Observation>((IEnumerable<Observation>)i_, j_);
		Observation l_ = context.Operators.SingletonFrom<Observation>(k_);

		return l_;
	}

    [CqlDeclaration("Most Recent Tobacco Use Screening Indicates Tobacco User")]
	public Observation Most_Recent_Tobacco_Use_Screening_Indicates_Tobacco_User() => 
		__Most_Recent_Tobacco_Use_Screening_Indicates_Tobacco_User.Value;

	private bool? Denominator_2_Value()
	{
		bool? a_ = this.Initial_Population();
		Observation b_ = this.Most_Recent_Tobacco_Use_Screening_Indicates_Tobacco_User();
		bool? c_ = context.Operators.Not((bool?)(b_ is null));
		bool? d_ = context.Operators.And(a_, c_);

		return d_;
	}

    [CqlDeclaration("Denominator 2")]
	public bool? Denominator_2() => 
		__Denominator_2.Value;

	private bool? Denominator_3_Value()
	{
		bool? a_ = this.Initial_Population();

		return a_;
	}

    [CqlDeclaration("Denominator 3")]
	public bool? Denominator_3() => 
		__Denominator_3.Value;

	private Observation Most_Recent_Tobacco_Use_Screening_Indicates_Tobacco_Non_User_Value()
	{
		CqlValueSet a_ = this.Tobacco_Use_Screening();
		IEnumerable<Observation> b_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
		IEnumerable<Observation> c_ = Status_1_6_000.isAssessmentPerformed(b_);
		bool? d_(Observation TobaccoUseScreening)
		{
			CqlInterval<CqlDateTime> m_ = this.Measurement_Period();
			DataType n_ = TobaccoUseScreening?.Effective;
			object o_ = FHIRHelpers_4_3_000.ToValue(n_);
			CqlInterval<CqlDateTime> p_ = QICoreCommon_2_0_000.toInterval(o_);
			bool? q_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(m_, p_, "day");

			return q_;
		};
		IEnumerable<Observation> e_ = context.Operators.Where<Observation>(c_, d_);
		object f_(Observation @this)
		{
			DataType r_ = @this?.Effective;
			object s_ = FHIRHelpers_4_3_000.ToValue(r_);
			CqlInterval<CqlDateTime> t_ = QICoreCommon_2_0_000.toInterval(s_);
			CqlDateTime u_ = context.Operators.Start(t_);

			return u_;
		};
		IEnumerable<Observation> g_ = context.Operators.SortBy<Observation>(e_, f_, System.ComponentModel.ListSortDirection.Ascending);
		Observation h_ = context.Operators.Last<Observation>(g_);
		Observation[] i_ = [
			h_,
		];
		bool? j_(Observation MostRecentTobaccoUseScreening)
		{
			DataType v_ = MostRecentTobaccoUseScreening?.Value;
			object w_ = FHIRHelpers_4_3_000.ToValue(v_);
			CqlValueSet x_ = this.Tobacco_Non_User();
			bool? y_ = context.Operators.ConceptInValueSet(w_ as CqlConcept, x_);

			return y_;
		};
		IEnumerable<Observation> k_ = context.Operators.Where<Observation>((IEnumerable<Observation>)i_, j_);
		Observation l_ = context.Operators.SingletonFrom<Observation>(k_);

		return l_;
	}

    [CqlDeclaration("Most Recent Tobacco Use Screening Indicates Tobacco Non User")]
	public Observation Most_Recent_Tobacco_Use_Screening_Indicates_Tobacco_Non_User() => 
		__Most_Recent_Tobacco_Use_Screening_Indicates_Tobacco_Non_User.Value;

	private bool? Numerator_1_Value()
	{
		Observation a_ = this.Most_Recent_Tobacco_Use_Screening_Indicates_Tobacco_Non_User();
		bool? b_ = context.Operators.Not((bool?)(a_ is null));
		Observation c_ = this.Most_Recent_Tobacco_Use_Screening_Indicates_Tobacco_User();
		bool? d_ = context.Operators.Not((bool?)(c_ is null));
		bool? e_ = context.Operators.Or(b_, d_);

		return e_;
	}

    [CqlDeclaration("Numerator 1")]
	public bool? Numerator_1() => 
		__Numerator_1.Value;

	private IEnumerable<object> Tobacco_Cessation_Counseling_Given_Value()
	{
		CqlValueSet a_ = this.Tobacco_Use_Cessation_Counseling();
		IEnumerable<Procedure> b_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
		IEnumerable<Procedure> c_ = Status_1_6_000.isInterventionPerformed(b_);
		bool? d_(Procedure TobaccoCessationCounseling)
		{
			CqlInterval<CqlDateTime> l_ = this.Measurement_Period();
			CqlDateTime m_ = context.Operators.Start(l_);
			CqlQuantity n_ = context.Operators.Quantity(6m, "months");
			CqlDateTime o_ = context.Operators.Subtract(m_, n_);
			CqlDateTime q_ = context.Operators.End(l_);
			CqlInterval<CqlDateTime> r_ = context.Operators.Interval(o_, q_, true, true);
			DataType s_ = TobaccoCessationCounseling?.Performed;
			object t_ = FHIRHelpers_4_3_000.ToValue(s_);
			CqlInterval<CqlDateTime> u_ = QICoreCommon_2_0_000.toInterval(t_);
			bool? v_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(r_, u_, "day");

			return v_;
		};
		IEnumerable<Procedure> e_ = context.Operators.Where<Procedure>(c_, d_);
		CqlCode f_ = this.Tobacco_abuse_counseling();
		IEnumerable<CqlCode> g_ = context.Operators.ToList<CqlCode>(f_);
		IEnumerable<Condition> h_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, default, g_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
		bool? i_(Condition TobaccoCounseling)
		{
			CqlInterval<CqlDateTime> w_ = QICoreCommon_2_0_000.prevalenceInterval(TobaccoCounseling);
			CqlDateTime x_ = context.Operators.Start(w_);
			CqlInterval<CqlDateTime> y_ = this.Measurement_Period();
			CqlDateTime z_ = context.Operators.Start(y_);
			CqlQuantity aa_ = context.Operators.Quantity(6m, "months");
			CqlDateTime ab_ = context.Operators.Subtract(z_, aa_);
			CqlDateTime ad_ = context.Operators.End(y_);
			CqlInterval<CqlDateTime> ae_ = context.Operators.Interval(ab_, ad_, true, true);
			bool? af_ = context.Operators.In<CqlDateTime>(x_, ae_, "day");

			return af_;
		};
		IEnumerable<Condition> j_ = context.Operators.Where<Condition>(h_, i_);
		IEnumerable<object> k_ = context.Operators.Union<object>(e_ as IEnumerable<object>, j_ as IEnumerable<object>);

		return k_;
	}

    [CqlDeclaration("Tobacco Cessation Counseling Given")]
	public IEnumerable<object> Tobacco_Cessation_Counseling_Given() => 
		__Tobacco_Cessation_Counseling_Given.Value;

	private IEnumerable<MedicationRequest> Tobacco_Cessation_Pharmacotherapy_Ordered_Value()
	{
		CqlValueSet a_ = this.Tobacco_Use_Cessation_Pharmacotherapy();
		IEnumerable<MedicationRequest> b_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
		IEnumerable<MedicationRequest> d_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
		IEnumerable<MedicationRequest> e_ = context.Operators.Union<MedicationRequest>(b_, d_);
		IEnumerable<MedicationRequest> f_ = Status_1_6_000.isMedicationOrder(e_);
		bool? g_(MedicationRequest CessationPharmacotherapyOrdered)
		{
			FhirDateTime i_ = CessationPharmacotherapyOrdered?.AuthoredOnElement;
			CqlDateTime j_ = context.Operators.Convert<CqlDateTime>(i_);
			CqlInterval<CqlDateTime> k_ = this.Measurement_Period();
			CqlDateTime l_ = context.Operators.Start(k_);
			CqlQuantity m_ = context.Operators.Quantity(6m, "months");
			CqlDateTime n_ = context.Operators.Subtract(l_, m_);
			CqlDateTime p_ = context.Operators.End(k_);
			CqlInterval<CqlDateTime> q_ = context.Operators.Interval(n_, p_, true, true);
			bool? r_ = context.Operators.In<CqlDateTime>(j_, q_, "day");

			return r_;
		};
		IEnumerable<MedicationRequest> h_ = context.Operators.Where<MedicationRequest>(f_, g_);

		return h_;
	}

    [CqlDeclaration("Tobacco Cessation Pharmacotherapy Ordered")]
	public IEnumerable<MedicationRequest> Tobacco_Cessation_Pharmacotherapy_Ordered() => 
		__Tobacco_Cessation_Pharmacotherapy_Ordered.Value;

	private IEnumerable<MedicationRequest> Active_Pharmacotherapy_for_Tobacco_Cessation_Value()
	{
		CqlValueSet a_ = this.Tobacco_Use_Cessation_Pharmacotherapy();
		IEnumerable<MedicationRequest> b_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
		IEnumerable<MedicationRequest> d_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
		IEnumerable<MedicationRequest> e_ = context.Operators.Union<MedicationRequest>(b_, d_);
		IEnumerable<MedicationRequest> f_ = Status_1_6_000.isMedicationActive(e_);
		bool? g_(MedicationRequest TakingCessationPharmacotherapy)
		{
			FhirDateTime i_ = TakingCessationPharmacotherapy?.AuthoredOnElement;
			CqlDateTime j_ = context.Operators.Convert<CqlDateTime>(i_);
			CqlInterval<CqlDateTime> k_ = this.Measurement_Period();
			CqlDateTime l_ = context.Operators.Start(k_);
			CqlQuantity m_ = context.Operators.Quantity(6m, "months");
			CqlDateTime n_ = context.Operators.Subtract(l_, m_);
			CqlDateTime p_ = context.Operators.End(k_);
			CqlInterval<CqlDateTime> q_ = context.Operators.Interval(n_, p_, true, true);
			bool? r_ = context.Operators.In<CqlDateTime>(j_, q_, "day");

			return r_;
		};
		IEnumerable<MedicationRequest> h_ = context.Operators.Where<MedicationRequest>(f_, g_);

		return h_;
	}

    [CqlDeclaration("Active Pharmacotherapy for Tobacco Cessation")]
	public IEnumerable<MedicationRequest> Active_Pharmacotherapy_for_Tobacco_Cessation() => 
		__Active_Pharmacotherapy_for_Tobacco_Cessation.Value;

	private bool? Numerator_2_Value()
	{
		IEnumerable<object> a_ = this.Tobacco_Cessation_Counseling_Given();
		bool? b_ = context.Operators.Exists<object>(a_);
		IEnumerable<MedicationRequest> c_ = this.Tobacco_Cessation_Pharmacotherapy_Ordered();
		bool? d_ = context.Operators.Exists<MedicationRequest>(c_);
		bool? e_ = context.Operators.Or(b_, d_);
		IEnumerable<MedicationRequest> f_ = this.Active_Pharmacotherapy_for_Tobacco_Cessation();
		bool? g_ = context.Operators.Exists<MedicationRequest>(f_);
		bool? h_ = context.Operators.Or(e_, g_);

		return h_;
	}

    [CqlDeclaration("Numerator 2")]
	public bool? Numerator_2() => 
		__Numerator_2.Value;

	private bool? Numerator_3_Value()
	{
		Observation a_ = this.Most_Recent_Tobacco_Use_Screening_Indicates_Tobacco_Non_User();
		bool? b_ = context.Operators.Not((bool?)(a_ is null));
		Observation c_ = this.Most_Recent_Tobacco_Use_Screening_Indicates_Tobacco_User();
		bool? d_ = context.Operators.Not((bool?)(c_ is null));
		IEnumerable<object> e_ = this.Tobacco_Cessation_Counseling_Given();
		bool? f_ = context.Operators.Exists<object>(e_);
		IEnumerable<MedicationRequest> g_ = this.Tobacco_Cessation_Pharmacotherapy_Ordered();
		bool? h_ = context.Operators.Exists<MedicationRequest>(g_);
		bool? i_ = context.Operators.Or(f_, h_);
		IEnumerable<MedicationRequest> j_ = this.Active_Pharmacotherapy_for_Tobacco_Cessation();
		bool? k_ = context.Operators.Exists<MedicationRequest>(j_);
		bool? l_ = context.Operators.Or(i_, k_);
		bool? m_ = context.Operators.And(d_, l_);
		bool? n_ = context.Operators.Or(b_, m_);

		return n_;
	}

    [CqlDeclaration("Numerator 3")]
	public bool? Numerator_3() => 
		__Numerator_3.Value;

	private bool? Denominator_Exclusion_Value()
	{
		bool? a_ = Hospice_6_9_000.Has_Hospice_Services();

		return a_;
	}

    [CqlDeclaration("Denominator Exclusion")]
	public bool? Denominator_Exclusion() => 
		__Denominator_Exclusion.Value;

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
