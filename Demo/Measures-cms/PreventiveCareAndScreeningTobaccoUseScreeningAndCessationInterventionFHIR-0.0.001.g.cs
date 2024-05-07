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
    internal Lazy<Tuple_FCiIaGHASIIbfXNJKRgLLXbgj> __SDE_Ethnicity;
    internal Lazy<IEnumerable<Tuple_COIQfKYbbjLZSGAMXWaFObiSa>> __SDE_Payer;
    internal Lazy<Tuple_FCiIaGHASIIbfXNJKRgLLXbgj> __SDE_Race;
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
        __SDE_Ethnicity = new Lazy<Tuple_FCiIaGHASIIbfXNJKRgLLXbgj>(this.SDE_Ethnicity_Value);
        __SDE_Payer = new Lazy<IEnumerable<Tuple_COIQfKYbbjLZSGAMXWaFObiSa>>(this.SDE_Payer_Value);
        __SDE_Race = new Lazy<Tuple_FCiIaGHASIIbfXNJKRgLLXbgj>(this.SDE_Race_Value);
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
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1240", null);

    [CqlDeclaration("Annual Wellness Visit")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1240")]
	public CqlValueSet Annual_Wellness_Visit() => 
		__Annual_Wellness_Visit.Value;

	private CqlValueSet Home_Healthcare_Services_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1016", null);

    [CqlDeclaration("Home Healthcare Services")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1016")]
	public CqlValueSet Home_Healthcare_Services() => 
		__Home_Healthcare_Services.Value;

	private CqlValueSet Limited_Life_Expectancy_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1259", null);

    [CqlDeclaration("Limited Life Expectancy")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1259")]
	public CqlValueSet Limited_Life_Expectancy() => 
		__Limited_Life_Expectancy.Value;

	private CqlValueSet Medical_Reason_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1007", null);

    [CqlDeclaration("Medical Reason")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1007")]
	public CqlValueSet Medical_Reason() => 
		__Medical_Reason.Value;

	private CqlValueSet Nutrition_Services_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.1006", null);

    [CqlDeclaration("Nutrition Services")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.1006")]
	public CqlValueSet Nutrition_Services() => 
		__Nutrition_Services.Value;

	private CqlValueSet Occupational_Therapy_Evaluation_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1011", null);

    [CqlDeclaration("Occupational Therapy Evaluation")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1011")]
	public CqlValueSet Occupational_Therapy_Evaluation() => 
		__Occupational_Therapy_Evaluation.Value;

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

	private CqlValueSet Ophthalmological_Services_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1285", null);

    [CqlDeclaration("Ophthalmological Services")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1285")]
	public CqlValueSet Ophthalmological_Services() => 
		__Ophthalmological_Services.Value;

	private CqlValueSet Physical_Therapy_Evaluation_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1022", null);

    [CqlDeclaration("Physical Therapy Evaluation")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1022")]
	public CqlValueSet Physical_Therapy_Evaluation() => 
		__Physical_Therapy_Evaluation.Value;

	private CqlValueSet Preventive_Care_Services_Established_Office_Visit__18_and_Up_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1025", null);

    [CqlDeclaration("Preventive Care Services Established Office Visit, 18 and Up")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1025")]
	public CqlValueSet Preventive_Care_Services_Established_Office_Visit__18_and_Up() => 
		__Preventive_Care_Services_Established_Office_Visit__18_and_Up.Value;

	private CqlValueSet Preventive_Care_Services_Group_Counseling_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1027", null);

    [CqlDeclaration("Preventive Care Services Group Counseling")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1027")]
	public CqlValueSet Preventive_Care_Services_Group_Counseling() => 
		__Preventive_Care_Services_Group_Counseling.Value;

	private CqlValueSet Preventive_Care_Services_Individual_Counseling_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1026", null);

    [CqlDeclaration("Preventive Care Services Individual Counseling")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1026")]
	public CqlValueSet Preventive_Care_Services_Individual_Counseling() => 
		__Preventive_Care_Services_Individual_Counseling.Value;

	private CqlValueSet Preventive_Care_Services_Initial_Office_Visit__18_and_Up_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1023", null);

    [CqlDeclaration("Preventive Care Services Initial Office Visit, 18 and Up")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1023")]
	public CqlValueSet Preventive_Care_Services_Initial_Office_Visit__18_and_Up() => 
		__Preventive_Care_Services_Initial_Office_Visit__18_and_Up.Value;

	private CqlValueSet Psych_Visit_Diagnostic_Evaluation_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1492", null);

    [CqlDeclaration("Psych Visit Diagnostic Evaluation")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1492")]
	public CqlValueSet Psych_Visit_Diagnostic_Evaluation() => 
		__Psych_Visit_Diagnostic_Evaluation.Value;

	private CqlValueSet Psych_Visit_Psychotherapy_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1496", null);

    [CqlDeclaration("Psych Visit Psychotherapy")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1496")]
	public CqlValueSet Psych_Visit_Psychotherapy() => 
		__Psych_Visit_Psychotherapy.Value;

	private CqlValueSet Psychoanalysis_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1141", null);

    [CqlDeclaration("Psychoanalysis")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1141")]
	public CqlValueSet Psychoanalysis() => 
		__Psychoanalysis.Value;

	private CqlValueSet Speech_and_Hearing_Evaluation_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1530", null);

    [CqlDeclaration("Speech and Hearing Evaluation")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1530")]
	public CqlValueSet Speech_and_Hearing_Evaluation() => 
		__Speech_and_Hearing_Evaluation.Value;

	private CqlValueSet Telephone_Visits_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1080", null);

    [CqlDeclaration("Telephone Visits")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1080")]
	public CqlValueSet Telephone_Visits() => 
		__Telephone_Visits.Value;

	private CqlValueSet Tobacco_Non_User_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1189", null);

    [CqlDeclaration("Tobacco Non User")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1189")]
	public CqlValueSet Tobacco_Non_User() => 
		__Tobacco_Non_User.Value;

	private CqlValueSet Tobacco_Use_Cessation_Counseling_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.509", null);

    [CqlDeclaration("Tobacco Use Cessation Counseling")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.509")]
	public CqlValueSet Tobacco_Use_Cessation_Counseling() => 
		__Tobacco_Use_Cessation_Counseling.Value;

	private CqlValueSet Tobacco_Use_Cessation_Pharmacotherapy_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1190", null);

    [CqlDeclaration("Tobacco Use Cessation Pharmacotherapy")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1190")]
	public CqlValueSet Tobacco_Use_Cessation_Pharmacotherapy() => 
		__Tobacco_Use_Cessation_Pharmacotherapy.Value;

	private CqlValueSet Tobacco_Use_Screening_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1278", null);

    [CqlDeclaration("Tobacco Use Screening")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1278")]
	public CqlValueSet Tobacco_Use_Screening() => 
		__Tobacco_Use_Screening.Value;

	private CqlValueSet Tobacco_User_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1170", null);

    [CqlDeclaration("Tobacco User")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1170")]
	public CqlValueSet Tobacco_User() => 
		__Tobacco_User.Value;

	private CqlCode Health_behavior_assessment__or_re_assessment__ie__health_focused_clinical_interview__behavioral_observations__clinical_decision_making__Value() => 
		new CqlCode("96156", "http://www.ama-assn.org/go/cpt", null, null);

    [CqlDeclaration("Health behavior assessment, or re-assessment (ie, health-focused clinical interview, behavioral observations, clinical decision making)")]
	public CqlCode Health_behavior_assessment__or_re_assessment__ie__health_focused_clinical_interview__behavioral_observations__clinical_decision_making_() => 
		__Health_behavior_assessment__or_re_assessment__ie__health_focused_clinical_interview__behavioral_observations__clinical_decision_making_.Value;

	private CqlCode Health_behavior_intervention__individual__face_to_face__initial_30_minutes_Value() => 
		new CqlCode("96158", "http://www.ama-assn.org/go/cpt", null, null);

    [CqlDeclaration("Health behavior intervention, individual, face-to-face; initial 30 minutes")]
	public CqlCode Health_behavior_intervention__individual__face_to_face__initial_30_minutes() => 
		__Health_behavior_intervention__individual__face_to_face__initial_30_minutes.Value;

	private CqlCode Postoperative_follow_up_visit__normally_included_in_the_surgical_package__to_indicate_that_an_evaluation_and_management_service_was_performed_during_a_postoperative_period_for_a_reason_s__related_to_the_original_procedure_Value() => 
		new CqlCode("99024", "http://www.ama-assn.org/go/cpt", null, null);

    [CqlDeclaration("Postoperative follow-up visit, normally included in the surgical package, to indicate that an evaluation and management service was performed during a postoperative period for a reason(s) related to the original procedure")]
	public CqlCode Postoperative_follow_up_visit__normally_included_in_the_surgical_package__to_indicate_that_an_evaluation_and_management_service_was_performed_during_a_postoperative_period_for_a_reason_s__related_to_the_original_procedure() => 
		__Postoperative_follow_up_visit__normally_included_in_the_surgical_package__to_indicate_that_an_evaluation_and_management_service_was_performed_during_a_postoperative_period_for_a_reason_s__related_to_the_original_procedure.Value;

	private CqlCode Tobacco_abuse_counseling_Value() => 
		new CqlCode("Z71.6", "http://hl7.org/fhir/sid/icd-10-cm", null, null);

    [CqlDeclaration("Tobacco abuse counseling")]
	public CqlCode Tobacco_abuse_counseling() => 
		__Tobacco_abuse_counseling.Value;

	private CqlCode Unlisted_preventive_medicine_service_Value() => 
		new CqlCode("99429", "http://www.ama-assn.org/go/cpt", null, null);

    [CqlDeclaration("Unlisted preventive medicine service")]
	public CqlCode Unlisted_preventive_medicine_service() => 
		__Unlisted_preventive_medicine_service.Value;

	private CqlCode[] CPT_Value()
	{
		var a_ = new CqlCode[]
		{
			new CqlCode("96156", "http://www.ama-assn.org/go/cpt", null, null),
			new CqlCode("96158", "http://www.ama-assn.org/go/cpt", null, null),
			new CqlCode("99024", "http://www.ama-assn.org/go/cpt", null, null),
			new CqlCode("99429", "http://www.ama-assn.org/go/cpt", null, null),
		};

		return a_;
	}

    [CqlDeclaration("CPT")]
	public CqlCode[] CPT() => 
		__CPT.Value;

	private CqlCode[] ICD10CM_Value()
	{
		var a_ = new CqlCode[]
		{
			new CqlCode("Z71.6", "http://hl7.org/fhir/sid/icd-10-cm", null, null),
		};

		return a_;
	}

    [CqlDeclaration("ICD10CM")]
	public CqlCode[] ICD10CM() => 
		__ICD10CM.Value;

	private CqlInterval<CqlDateTime> Measurement_Period_Value()
	{
		var a_ = context.Operators.DateTime(2025, 1, 1, 0, 0, 0, 0, default);
		var b_ = context.Operators.DateTime(2026, 1, 1, 0, 0, 0, 0, default);
		var c_ = context.Operators.Interval(a_, b_, true, false);
		var d_ = context.ResolveParameter("PreventiveCareAndScreeningTobaccoUseScreeningAndCessationInterventionFHIR-0.0.001", "Measurement Period", c_);

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

	private IEnumerable<Encounter> Qualifying_Visit_During_Measurement_Period_Value()
	{
		var a_ = this.Home_Healthcare_Services();
		var b_ = context.Operators.RetrieveByValueSet<Encounter>(a_, null);
		var c_ = context.Operators.RetrieveByValueSet<Encounter>(null, null);
		bool? d_(Encounter E)
		{
			CqlConcept ar_(CodeableConcept @this)
			{
				var aw_ = FHIRHelpers_4_3_000.ToConcept(@this);

				return aw_;
			};
			var as_ = context.Operators.Select<CodeableConcept, CqlConcept>(E?.Type, ar_);
			bool? at_(CqlConcept T)
			{
				var ax_ = this.Health_behavior_assessment__or_re_assessment__ie__health_focused_clinical_interview__behavioral_observations__clinical_decision_making_();
				var ay_ = context.Operators.ConvertCodeToConcept(ax_);
				var az_ = context.Operators.Equivalent(T, ay_);

				return az_;
			};
			var au_ = context.Operators.Where<CqlConcept>(as_, at_);
			var av_ = context.Operators.Exists<CqlConcept>(au_);

			return av_;
		};
		var e_ = context.Operators.Where<Encounter>(c_, d_);
		var f_ = context.Operators.ListUnion<Encounter>(b_, e_);
		bool? h_(Encounter E)
		{
			CqlConcept ba_(CodeableConcept @this)
			{
				var bf_ = FHIRHelpers_4_3_000.ToConcept(@this);

				return bf_;
			};
			var bb_ = context.Operators.Select<CodeableConcept, CqlConcept>(E?.Type, ba_);
			bool? bc_(CqlConcept T)
			{
				var bg_ = this.Health_behavior_intervention__individual__face_to_face__initial_30_minutes();
				var bh_ = context.Operators.ConvertCodeToConcept(bg_);
				var bi_ = context.Operators.Equivalent(T, bh_);

				return bi_;
			};
			var bd_ = context.Operators.Where<CqlConcept>(bb_, bc_);
			var be_ = context.Operators.Exists<CqlConcept>(bd_);

			return be_;
		};
		var i_ = context.Operators.Where<Encounter>(c_, h_);
		var j_ = this.Occupational_Therapy_Evaluation();
		var k_ = context.Operators.RetrieveByValueSet<Encounter>(j_, null);
		var l_ = context.Operators.ListUnion<Encounter>(i_, k_);
		var m_ = context.Operators.ListUnion<Encounter>(f_, l_);
		var n_ = this.Office_Visit();
		var o_ = context.Operators.RetrieveByValueSet<Encounter>(n_, null);
		var p_ = this.Ophthalmological_Services();
		var q_ = context.Operators.RetrieveByValueSet<Encounter>(p_, null);
		var r_ = context.Operators.ListUnion<Encounter>(o_, q_);
		var s_ = context.Operators.ListUnion<Encounter>(m_, r_);
		var t_ = this.Physical_Therapy_Evaluation();
		var u_ = context.Operators.RetrieveByValueSet<Encounter>(t_, null);
		var v_ = this.Psych_Visit_Diagnostic_Evaluation();
		var w_ = context.Operators.RetrieveByValueSet<Encounter>(v_, null);
		var x_ = context.Operators.ListUnion<Encounter>(u_, w_);
		var y_ = context.Operators.ListUnion<Encounter>(s_, x_);
		var z_ = this.Psych_Visit_Psychotherapy();
		var aa_ = context.Operators.RetrieveByValueSet<Encounter>(z_, null);
		var ab_ = this.Psychoanalysis();
		var ac_ = context.Operators.RetrieveByValueSet<Encounter>(ab_, null);
		var ad_ = context.Operators.ListUnion<Encounter>(aa_, ac_);
		var ae_ = context.Operators.ListUnion<Encounter>(y_, ad_);
		var af_ = this.Speech_and_Hearing_Evaluation();
		var ag_ = context.Operators.RetrieveByValueSet<Encounter>(af_, null);
		var ah_ = this.Telephone_Visits();
		var ai_ = context.Operators.RetrieveByValueSet<Encounter>(ah_, null);
		var aj_ = context.Operators.ListUnion<Encounter>(ag_, ai_);
		var ak_ = context.Operators.ListUnion<Encounter>(ae_, aj_);
		var al_ = this.Online_Assessments();
		var am_ = context.Operators.RetrieveByValueSet<Encounter>(al_, null);
		var an_ = context.Operators.ListUnion<Encounter>(ak_, am_);
		var ao_ = Status_1_6_000.isEncounterPerformed(an_);
		bool? ap_(Encounter OfficeBasedEncounter)
		{
			var bj_ = this.Measurement_Period();
			var bk_ = FHIRHelpers_4_3_000.ToInterval(OfficeBasedEncounter?.Period);
			var bl_ = QICoreCommon_2_0_000.toInterval((bk_ as object));
			var bm_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(bj_, bl_, "day");

			return bm_;
		};
		var aq_ = context.Operators.Where<Encounter>(ao_, ap_);

		return aq_;
	}

    [CqlDeclaration("Qualifying Visit During Measurement Period")]
	public IEnumerable<Encounter> Qualifying_Visit_During_Measurement_Period() => 
		__Qualifying_Visit_During_Measurement_Period.Value;

	private IEnumerable<Encounter> Preventive_Visit_During_Measurement_Period_Value()
	{
		var a_ = this.Annual_Wellness_Visit();
		var b_ = context.Operators.RetrieveByValueSet<Encounter>(a_, null);
		var c_ = this.Preventive_Care_Services_Established_Office_Visit__18_and_Up();
		var d_ = context.Operators.RetrieveByValueSet<Encounter>(c_, null);
		var e_ = context.Operators.ListUnion<Encounter>(b_, d_);
		var f_ = this.Preventive_Care_Services_Group_Counseling();
		var g_ = context.Operators.RetrieveByValueSet<Encounter>(f_, null);
		var h_ = context.Operators.RetrieveByValueSet<Encounter>(null, null);
		bool? i_(Encounter E)
		{
			CqlConcept ac_(CodeableConcept @this)
			{
				var ah_ = FHIRHelpers_4_3_000.ToConcept(@this);

				return ah_;
			};
			var ad_ = context.Operators.Select<CodeableConcept, CqlConcept>(E?.Type, ac_);
			bool? ae_(CqlConcept T)
			{
				var ai_ = this.Unlisted_preventive_medicine_service();
				var aj_ = context.Operators.ConvertCodeToConcept(ai_);
				var ak_ = context.Operators.Equivalent(T, aj_);

				return ak_;
			};
			var af_ = context.Operators.Where<CqlConcept>(ad_, ae_);
			var ag_ = context.Operators.Exists<CqlConcept>(af_);

			return ag_;
		};
		var j_ = context.Operators.Where<Encounter>(h_, i_);
		var k_ = context.Operators.ListUnion<Encounter>(g_, j_);
		var l_ = context.Operators.ListUnion<Encounter>(e_, k_);
		var m_ = this.Preventive_Care_Services_Individual_Counseling();
		var n_ = context.Operators.RetrieveByValueSet<Encounter>(m_, null);
		bool? p_(Encounter E)
		{
			CqlConcept al_(CodeableConcept @this)
			{
				var aq_ = FHIRHelpers_4_3_000.ToConcept(@this);

				return aq_;
			};
			var am_ = context.Operators.Select<CodeableConcept, CqlConcept>(E?.Type, al_);
			bool? an_(CqlConcept T)
			{
				var ar_ = this.Postoperative_follow_up_visit__normally_included_in_the_surgical_package__to_indicate_that_an_evaluation_and_management_service_was_performed_during_a_postoperative_period_for_a_reason_s__related_to_the_original_procedure();
				var as_ = context.Operators.ConvertCodeToConcept(ar_);
				var at_ = context.Operators.Equivalent(T, as_);

				return at_;
			};
			var ao_ = context.Operators.Where<CqlConcept>(am_, an_);
			var ap_ = context.Operators.Exists<CqlConcept>(ao_);

			return ap_;
		};
		var q_ = context.Operators.Where<Encounter>(h_, p_);
		var r_ = context.Operators.ListUnion<Encounter>(n_, q_);
		var s_ = context.Operators.ListUnion<Encounter>(l_, r_);
		var t_ = this.Nutrition_Services();
		var u_ = context.Operators.RetrieveByValueSet<Encounter>(t_, null);
		var v_ = this.Preventive_Care_Services_Initial_Office_Visit__18_and_Up();
		var w_ = context.Operators.RetrieveByValueSet<Encounter>(v_, null);
		var x_ = context.Operators.ListUnion<Encounter>(u_, w_);
		var y_ = context.Operators.ListUnion<Encounter>(s_, x_);
		var z_ = Status_1_6_000.isEncounterPerformed(y_);
		bool? aa_(Encounter PreventiveEncounter)
		{
			var au_ = this.Measurement_Period();
			var av_ = FHIRHelpers_4_3_000.ToInterval(PreventiveEncounter?.Period);
			var aw_ = QICoreCommon_2_0_000.toInterval((av_ as object));
			var ax_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(au_, aw_, "day");

			return ax_;
		};
		var ab_ = context.Operators.Where<Encounter>(z_, aa_);

		return ab_;
	}

    [CqlDeclaration("Preventive Visit During Measurement Period")]
	public IEnumerable<Encounter> Preventive_Visit_During_Measurement_Period() => 
		__Preventive_Visit_During_Measurement_Period.Value;

	private bool? Initial_Population_Value()
	{
		var a_ = this.Patient();
		var b_ = context.Operators.Convert<CqlDate>(a_?.BirthDateElement?.Value);
		var c_ = this.Measurement_Period();
		var d_ = context.Operators.Start(c_);
		var e_ = context.Operators.DateFrom(d_);
		var f_ = context.Operators.CalculateAgeAt(b_, e_, "year");
		var g_ = context.Operators.GreaterOrEqual(f_, 12);
		var h_ = this.Qualifying_Visit_During_Measurement_Period();
		var i_ = context.Operators.Count<Encounter>(h_);
		var j_ = context.Operators.GreaterOrEqual(i_, 2);
		var k_ = this.Preventive_Visit_During_Measurement_Period();
		var l_ = context.Operators.Exists<Encounter>(k_);
		var m_ = context.Operators.Or(j_, l_);
		var n_ = context.Operators.And(g_, m_);

		return n_;
	}

    [CqlDeclaration("Initial Population")]
	public bool? Initial_Population() => 
		__Initial_Population.Value;

	private bool? Denominator_1_Value()
	{
		var a_ = this.Initial_Population();

		return a_;
	}

    [CqlDeclaration("Denominator 1")]
	public bool? Denominator_1() => 
		__Denominator_1.Value;

	private Observation Most_Recent_Tobacco_Use_Screening_Indicates_Tobacco_User_Value()
	{
		var a_ = this.Tobacco_Use_Screening();
		var b_ = context.Operators.RetrieveByValueSet<Observation>(a_, null);
		var c_ = Status_1_6_000.isAssessmentPerformed(b_);
		bool? d_(Observation TobaccoUseScreening)
		{
			var m_ = this.Measurement_Period();
			var n_ = FHIRHelpers_4_3_000.ToValue(TobaccoUseScreening?.Effective);
			var o_ = QICoreCommon_2_0_000.toInterval(n_);
			var p_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(m_, o_, "day");

			return p_;
		};
		var e_ = context.Operators.Where<Observation>(c_, d_);
		object f_(Observation @this)
		{
			var q_ = FHIRHelpers_4_3_000.ToValue(@this?.Effective);
			var r_ = QICoreCommon_2_0_000.toInterval(q_);
			var s_ = context.Operators.Start(r_);

			return s_;
		};
		var g_ = context.Operators.SortBy<Observation>(e_, f_, System.ComponentModel.ListSortDirection.Ascending);
		var h_ = context.Operators.Last<Observation>(g_);
		var i_ = new Observation[]
		{
			h_,
		};
		bool? j_(Observation MostRecentTobaccoUseScreening)
		{
			var t_ = FHIRHelpers_4_3_000.ToValue(MostRecentTobaccoUseScreening?.Value);
			var u_ = this.Tobacco_User();
			var v_ = context.Operators.ConceptInValueSet((t_ as CqlConcept), u_);

			return v_;
		};
		var k_ = context.Operators.Where<Observation>(i_, j_);
		var l_ = context.Operators.SingletonFrom<Observation>(k_);

		return l_;
	}

    [CqlDeclaration("Most Recent Tobacco Use Screening Indicates Tobacco User")]
	public Observation Most_Recent_Tobacco_Use_Screening_Indicates_Tobacco_User() => 
		__Most_Recent_Tobacco_Use_Screening_Indicates_Tobacco_User.Value;

	private bool? Denominator_2_Value()
	{
		var a_ = this.Initial_Population();
		var b_ = this.Most_Recent_Tobacco_Use_Screening_Indicates_Tobacco_User();
		var c_ = context.Operators.Not((bool?)(b_ is null));
		var d_ = context.Operators.And(a_, c_);

		return d_;
	}

    [CqlDeclaration("Denominator 2")]
	public bool? Denominator_2() => 
		__Denominator_2.Value;

	private bool? Denominator_3_Value()
	{
		var a_ = this.Initial_Population();

		return a_;
	}

    [CqlDeclaration("Denominator 3")]
	public bool? Denominator_3() => 
		__Denominator_3.Value;

	private Observation Most_Recent_Tobacco_Use_Screening_Indicates_Tobacco_Non_User_Value()
	{
		var a_ = this.Tobacco_Use_Screening();
		var b_ = context.Operators.RetrieveByValueSet<Observation>(a_, null);
		var c_ = Status_1_6_000.isAssessmentPerformed(b_);
		bool? d_(Observation TobaccoUseScreening)
		{
			var m_ = this.Measurement_Period();
			var n_ = FHIRHelpers_4_3_000.ToValue(TobaccoUseScreening?.Effective);
			var o_ = QICoreCommon_2_0_000.toInterval(n_);
			var p_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(m_, o_, "day");

			return p_;
		};
		var e_ = context.Operators.Where<Observation>(c_, d_);
		object f_(Observation @this)
		{
			var q_ = FHIRHelpers_4_3_000.ToValue(@this?.Effective);
			var r_ = QICoreCommon_2_0_000.toInterval(q_);
			var s_ = context.Operators.Start(r_);

			return s_;
		};
		var g_ = context.Operators.SortBy<Observation>(e_, f_, System.ComponentModel.ListSortDirection.Ascending);
		var h_ = context.Operators.Last<Observation>(g_);
		var i_ = new Observation[]
		{
			h_,
		};
		bool? j_(Observation MostRecentTobaccoUseScreening)
		{
			var t_ = FHIRHelpers_4_3_000.ToValue(MostRecentTobaccoUseScreening?.Value);
			var u_ = this.Tobacco_Non_User();
			var v_ = context.Operators.ConceptInValueSet((t_ as CqlConcept), u_);

			return v_;
		};
		var k_ = context.Operators.Where<Observation>(i_, j_);
		var l_ = context.Operators.SingletonFrom<Observation>(k_);

		return l_;
	}

    [CqlDeclaration("Most Recent Tobacco Use Screening Indicates Tobacco Non User")]
	public Observation Most_Recent_Tobacco_Use_Screening_Indicates_Tobacco_Non_User() => 
		__Most_Recent_Tobacco_Use_Screening_Indicates_Tobacco_Non_User.Value;

	private bool? Numerator_1_Value()
	{
		var a_ = this.Most_Recent_Tobacco_Use_Screening_Indicates_Tobacco_Non_User();
		var b_ = context.Operators.Not((bool?)(a_ is null));
		var c_ = this.Most_Recent_Tobacco_Use_Screening_Indicates_Tobacco_User();
		var d_ = context.Operators.Not((bool?)(c_ is null));
		var e_ = context.Operators.Or(b_, d_);

		return e_;
	}

    [CqlDeclaration("Numerator 1")]
	public bool? Numerator_1() => 
		__Numerator_1.Value;

	private IEnumerable<object> Tobacco_Cessation_Counseling_Given_Value()
	{
		var a_ = this.Tobacco_Use_Cessation_Counseling();
		var b_ = context.Operators.RetrieveByValueSet<Procedure>(a_, null);
		var c_ = Status_1_6_000.isInterventionPerformed(b_);
		bool? d_(Procedure TobaccoCessationCounseling)
		{
			var l_ = this.Measurement_Period();
			var m_ = context.Operators.Start(l_);
			var n_ = context.Operators.Quantity(6m, "months");
			var o_ = context.Operators.Subtract(m_, n_);
			var q_ = context.Operators.End(l_);
			var r_ = context.Operators.Interval(o_, q_, true, true);
			var s_ = FHIRHelpers_4_3_000.ToValue(TobaccoCessationCounseling?.Performed);
			var t_ = QICoreCommon_2_0_000.toInterval(s_);
			var u_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(r_, t_, "day");

			return u_;
		};
		var e_ = context.Operators.Where<Procedure>(c_, d_);
		var f_ = this.Tobacco_abuse_counseling();
		var g_ = context.Operators.ToList<CqlCode>(f_);
		var h_ = context.Operators.RetrieveByCodes<Condition>(g_, null);
		bool? i_(Condition TobaccoCounseling)
		{
			var v_ = QICoreCommon_2_0_000.prevalenceInterval(TobaccoCounseling);
			var w_ = context.Operators.Start(v_);
			var x_ = this.Measurement_Period();
			var y_ = context.Operators.Start(x_);
			var z_ = context.Operators.Quantity(6m, "months");
			var aa_ = context.Operators.Subtract(y_, z_);
			var ac_ = context.Operators.End(x_);
			var ad_ = context.Operators.Interval(aa_, ac_, true, true);
			var ae_ = context.Operators.In<CqlDateTime>(w_, ad_, "day");

			return ae_;
		};
		var j_ = context.Operators.Where<Condition>(h_, i_);
		var k_ = context.Operators.ListUnion<object>((e_ as IEnumerable<object>), (j_ as IEnumerable<object>));

		return k_;
	}

    [CqlDeclaration("Tobacco Cessation Counseling Given")]
	public IEnumerable<object> Tobacco_Cessation_Counseling_Given() => 
		__Tobacco_Cessation_Counseling_Given.Value;

	private IEnumerable<MedicationRequest> Tobacco_Cessation_Pharmacotherapy_Ordered_Value()
	{
		var a_ = this.Tobacco_Use_Cessation_Pharmacotherapy();
		var b_ = context.Operators.RetrieveByValueSet<MedicationRequest>(a_, null);
		var d_ = context.Operators.RetrieveByValueSet<MedicationRequest>(a_, null);
		var e_ = context.Operators.ListUnion<MedicationRequest>(b_, d_);
		var f_ = Status_1_6_000.isMedicationOrder(e_);
		bool? g_(MedicationRequest CessationPharmacotherapyOrdered)
		{
			var i_ = context.Operators.Convert<CqlDateTime>(CessationPharmacotherapyOrdered?.AuthoredOnElement);
			var j_ = this.Measurement_Period();
			var k_ = context.Operators.Start(j_);
			var l_ = context.Operators.Quantity(6m, "months");
			var m_ = context.Operators.Subtract(k_, l_);
			var o_ = context.Operators.End(j_);
			var p_ = context.Operators.Interval(m_, o_, true, true);
			var q_ = context.Operators.In<CqlDateTime>(i_, p_, "day");

			return q_;
		};
		var h_ = context.Operators.Where<MedicationRequest>(f_, g_);

		return h_;
	}

    [CqlDeclaration("Tobacco Cessation Pharmacotherapy Ordered")]
	public IEnumerable<MedicationRequest> Tobacco_Cessation_Pharmacotherapy_Ordered() => 
		__Tobacco_Cessation_Pharmacotherapy_Ordered.Value;

	private IEnumerable<MedicationRequest> Active_Pharmacotherapy_for_Tobacco_Cessation_Value()
	{
		var a_ = this.Tobacco_Use_Cessation_Pharmacotherapy();
		var b_ = context.Operators.RetrieveByValueSet<MedicationRequest>(a_, null);
		var d_ = context.Operators.RetrieveByValueSet<MedicationRequest>(a_, null);
		var e_ = context.Operators.ListUnion<MedicationRequest>(b_, d_);
		var f_ = Status_1_6_000.isMedicationActive(e_);
		bool? g_(MedicationRequest TakingCessationPharmacotherapy)
		{
			var i_ = context.Operators.Convert<CqlDateTime>(TakingCessationPharmacotherapy?.AuthoredOnElement);
			var j_ = this.Measurement_Period();
			var k_ = context.Operators.Start(j_);
			var l_ = context.Operators.Quantity(6m, "months");
			var m_ = context.Operators.Subtract(k_, l_);
			var o_ = context.Operators.End(j_);
			var p_ = context.Operators.Interval(m_, o_, true, true);
			var q_ = context.Operators.In<CqlDateTime>(i_, p_, "day");

			return q_;
		};
		var h_ = context.Operators.Where<MedicationRequest>(f_, g_);

		return h_;
	}

    [CqlDeclaration("Active Pharmacotherapy for Tobacco Cessation")]
	public IEnumerable<MedicationRequest> Active_Pharmacotherapy_for_Tobacco_Cessation() => 
		__Active_Pharmacotherapy_for_Tobacco_Cessation.Value;

	private bool? Numerator_2_Value()
	{
		var a_ = this.Tobacco_Cessation_Counseling_Given();
		var b_ = context.Operators.Exists<object>(a_);
		var c_ = this.Tobacco_Cessation_Pharmacotherapy_Ordered();
		var d_ = context.Operators.Exists<MedicationRequest>(c_);
		var e_ = context.Operators.Or(b_, d_);
		var f_ = this.Active_Pharmacotherapy_for_Tobacco_Cessation();
		var g_ = context.Operators.Exists<MedicationRequest>(f_);
		var h_ = context.Operators.Or(e_, g_);

		return h_;
	}

    [CqlDeclaration("Numerator 2")]
	public bool? Numerator_2() => 
		__Numerator_2.Value;

	private bool? Numerator_3_Value()
	{
		var a_ = this.Most_Recent_Tobacco_Use_Screening_Indicates_Tobacco_Non_User();
		var b_ = context.Operators.Not((bool?)(a_ is null));
		var c_ = this.Most_Recent_Tobacco_Use_Screening_Indicates_Tobacco_User();
		var d_ = context.Operators.Not((bool?)(c_ is null));
		var e_ = this.Tobacco_Cessation_Counseling_Given();
		var f_ = context.Operators.Exists<object>(e_);
		var g_ = this.Tobacco_Cessation_Pharmacotherapy_Ordered();
		var h_ = context.Operators.Exists<MedicationRequest>(g_);
		var i_ = context.Operators.Or(f_, h_);
		var j_ = this.Active_Pharmacotherapy_for_Tobacco_Cessation();
		var k_ = context.Operators.Exists<MedicationRequest>(j_);
		var l_ = context.Operators.Or(i_, k_);
		var m_ = context.Operators.And(d_, l_);
		var n_ = context.Operators.Or(b_, m_);

		return n_;
	}

    [CqlDeclaration("Numerator 3")]
	public bool? Numerator_3() => 
		__Numerator_3.Value;

	private bool? Denominator_Exclusion_Value()
	{
		var a_ = Hospice_6_9_000.Has_Hospice_Services();

		return a_;
	}

    [CqlDeclaration("Denominator Exclusion")]
	public bool? Denominator_Exclusion() => 
		__Denominator_Exclusion.Value;

	private Tuple_FCiIaGHASIIbfXNJKRgLLXbgj SDE_Ethnicity_Value()
	{
		var a_ = SupplementalDataElements_3_4_000.SDE_Ethnicity();

		return a_;
	}

    [CqlDeclaration("SDE Ethnicity")]
	public Tuple_FCiIaGHASIIbfXNJKRgLLXbgj SDE_Ethnicity() => 
		__SDE_Ethnicity.Value;

	private IEnumerable<Tuple_COIQfKYbbjLZSGAMXWaFObiSa> SDE_Payer_Value()
	{
		var a_ = SupplementalDataElements_3_4_000.SDE_Payer();

		return a_;
	}

    [CqlDeclaration("SDE Payer")]
	public IEnumerable<Tuple_COIQfKYbbjLZSGAMXWaFObiSa> SDE_Payer() => 
		__SDE_Payer.Value;

	private Tuple_FCiIaGHASIIbfXNJKRgLLXbgj SDE_Race_Value()
	{
		var a_ = SupplementalDataElements_3_4_000.SDE_Race();

		return a_;
	}

    [CqlDeclaration("SDE Race")]
	public Tuple_FCiIaGHASIIbfXNJKRgLLXbgj SDE_Race() => 
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
