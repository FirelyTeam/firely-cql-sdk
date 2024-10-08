﻿using System;
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
[System.CodeDom.Compiler.GeneratedCode(".NET Code Generation", "2.0.5.0")]
[CqlLibrary("PreventiveCareAndScreeningTobaccoUseScreeningAndCessationInterventionFHIR", "0.0.001")]
public partial class PreventiveCareAndScreeningTobaccoUseScreeningAndCessationInterventionFHIR_0_0_001 : ILibrary, ISingleton<PreventiveCareAndScreeningTobaccoUseScreeningAndCessationInterventionFHIR_0_0_001>
{
    private PreventiveCareAndScreeningTobaccoUseScreeningAndCessationInterventionFHIR_0_0_001() {}

    public static PreventiveCareAndScreeningTobaccoUseScreeningAndCessationInterventionFHIR_0_0_001 Instance { get; } = new();

    #region Library Members
    public string Name => "PreventiveCareAndScreeningTobaccoUseScreeningAndCessationInterventionFHIR";
    public string Version => "0.0.001";
    public ILibrary[] Dependencies => [CQMCommon_2_0_000.Instance, Status_1_6_000.Instance, FHIRHelpers_4_3_000.Instance, SupplementalDataElements_3_4_000.Instance, QICoreCommon_2_0_000.Instance, Hospice_6_9_000.Instance, CumulativeMedicationDuration_4_0_000.Instance];
    #endregion Library Members

    [CqlDeclaration("Annual Wellness Visit")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1240")]
	public CqlValueSet Annual_Wellness_Visit(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1240", default);


    [CqlDeclaration("Home Healthcare Services")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1016")]
	public CqlValueSet Home_Healthcare_Services(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1016", default);


    [CqlDeclaration("Limited Life Expectancy")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1259")]
	public CqlValueSet Limited_Life_Expectancy(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1259", default);


    [CqlDeclaration("Medical Reason")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1007")]
	public CqlValueSet Medical_Reason(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1007", default);


    [CqlDeclaration("Nutrition Services")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.1006")]
	public CqlValueSet Nutrition_Services(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.1006", default);


    [CqlDeclaration("Occupational Therapy Evaluation")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1011")]
	public CqlValueSet Occupational_Therapy_Evaluation(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1011", default);


    [CqlDeclaration("Office Visit")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1001")]
	public CqlValueSet Office_Visit(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1001", default);


    [CqlDeclaration("Online Assessments")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1089")]
	public CqlValueSet Online_Assessments(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1089", default);


    [CqlDeclaration("Ophthalmological Services")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1285")]
	public CqlValueSet Ophthalmological_Services(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1285", default);


    [CqlDeclaration("Physical Therapy Evaluation")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1022")]
	public CqlValueSet Physical_Therapy_Evaluation(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1022", default);


    [CqlDeclaration("Preventive Care Services Established Office Visit, 18 and Up")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1025")]
	public CqlValueSet Preventive_Care_Services_Established_Office_Visit__18_and_Up(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1025", default);


    [CqlDeclaration("Preventive Care Services Group Counseling")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1027")]
	public CqlValueSet Preventive_Care_Services_Group_Counseling(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1027", default);


    [CqlDeclaration("Preventive Care Services Individual Counseling")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1026")]
	public CqlValueSet Preventive_Care_Services_Individual_Counseling(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1026", default);


    [CqlDeclaration("Preventive Care Services Initial Office Visit, 18 and Up")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1023")]
	public CqlValueSet Preventive_Care_Services_Initial_Office_Visit__18_and_Up(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1023", default);


    [CqlDeclaration("Psych Visit Diagnostic Evaluation")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1492")]
	public CqlValueSet Psych_Visit_Diagnostic_Evaluation(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1492", default);


    [CqlDeclaration("Psych Visit Psychotherapy")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1496")]
	public CqlValueSet Psych_Visit_Psychotherapy(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1496", default);


    [CqlDeclaration("Psychoanalysis")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1141")]
	public CqlValueSet Psychoanalysis(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1141", default);


    [CqlDeclaration("Speech and Hearing Evaluation")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1530")]
	public CqlValueSet Speech_and_Hearing_Evaluation(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1530", default);


    [CqlDeclaration("Telephone Visits")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1080")]
	public CqlValueSet Telephone_Visits(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1080", default);


    [CqlDeclaration("Tobacco Non User")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1189")]
	public CqlValueSet Tobacco_Non_User(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1189", default);


    [CqlDeclaration("Tobacco Use Cessation Counseling")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.509")]
	public CqlValueSet Tobacco_Use_Cessation_Counseling(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.509", default);


    [CqlDeclaration("Tobacco Use Cessation Pharmacotherapy")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1190")]
	public CqlValueSet Tobacco_Use_Cessation_Pharmacotherapy(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1190", default);


    [CqlDeclaration("Tobacco Use Screening")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1278")]
	public CqlValueSet Tobacco_Use_Screening(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1278", default);


    [CqlDeclaration("Tobacco User")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1170")]
	public CqlValueSet Tobacco_User(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1170", default);


    [CqlDeclaration("Health behavior assessment, or re-assessment (ie, health-focused clinical interview, behavioral observations, clinical decision making)")]
	public CqlCode Health_behavior_assessment__or_re_assessment__ie__health_focused_clinical_interview__behavioral_observations__clinical_decision_making_(CqlContext context) => 
		new CqlCode("96156", "http://www.ama-assn.org/go/cpt", default, default);


    [CqlDeclaration("Health behavior intervention, individual, face-to-face; initial 30 minutes")]
	public CqlCode Health_behavior_intervention__individual__face_to_face__initial_30_minutes(CqlContext context) => 
		new CqlCode("96158", "http://www.ama-assn.org/go/cpt", default, default);


    [CqlDeclaration("Postoperative follow-up visit, normally included in the surgical package, to indicate that an evaluation and management service was performed during a postoperative period for a reason(s) related to the original procedure")]
	public CqlCode Postoperative_follow_up_visit__normally_included_in_the_surgical_package__to_indicate_that_an_evaluation_and_management_service_was_performed_during_a_postoperative_period_for_a_reason_s__related_to_the_original_procedure(CqlContext context) => 
		new CqlCode("99024", "http://www.ama-assn.org/go/cpt", default, default);


    [CqlDeclaration("Tobacco abuse counseling")]
	public CqlCode Tobacco_abuse_counseling(CqlContext context) => 
		new CqlCode("Z71.6", "http://hl7.org/fhir/sid/icd-10-cm", default, default);


    [CqlDeclaration("Unlisted preventive medicine service")]
	public CqlCode Unlisted_preventive_medicine_service(CqlContext context) => 
		new CqlCode("99429", "http://www.ama-assn.org/go/cpt", default, default);


    [CqlDeclaration("CPT")]
	public CqlCode[] CPT(CqlContext context)
	{
		CqlCode[] a_ = [
			new CqlCode("96156", "http://www.ama-assn.org/go/cpt", default, default),
			new CqlCode("96158", "http://www.ama-assn.org/go/cpt", default, default),
			new CqlCode("99024", "http://www.ama-assn.org/go/cpt", default, default),
			new CqlCode("99429", "http://www.ama-assn.org/go/cpt", default, default),
		];

		return a_;
	}


    [CqlDeclaration("ICD10CM")]
	public CqlCode[] ICD10CM(CqlContext context)
	{
		CqlCode[] a_ = [
			new CqlCode("Z71.6", "http://hl7.org/fhir/sid/icd-10-cm", default, default),
		];

		return a_;
	}


    [CqlDeclaration("Measurement Period")]
	public CqlInterval<CqlDateTime> Measurement_Period(CqlContext context)
	{
		CqlDateTime a_ = context.Operators.DateTime(2025, 1, 1, 0, 0, 0, 0, default);
		CqlDateTime b_ = context.Operators.DateTime(2026, 1, 1, 0, 0, 0, 0, default);
		CqlInterval<CqlDateTime> c_ = context.Operators.Interval(a_, b_, true, false);
		object d_ = context.ResolveParameter("PreventiveCareAndScreeningTobaccoUseScreeningAndCessationInterventionFHIR-0.0.001", "Measurement Period", c_);

		return (CqlInterval<CqlDateTime>)d_;
	}


    [CqlDeclaration("Patient")]
	public Patient Patient(CqlContext context)
	{
		IEnumerable<Patient> a_ = context.Operators.RetrieveByValueSet<Patient>(default, default);
		Patient b_ = context.Operators.SingletonFrom<Patient>(a_);

		return b_;
	}


    [CqlDeclaration("Qualifying Visit During Measurement Period")]
	public IEnumerable<Encounter> Qualifying_Visit_During_Measurement_Period(CqlContext context)
	{
		CqlValueSet a_ = this.Home_Healthcare_Services(context);
		IEnumerable<Encounter> b_ = context.Operators.RetrieveByValueSet<Encounter>(a_, default);
		IEnumerable<Encounter> c_ = context.Operators.RetrieveByValueSet<Encounter>(default, default);
		bool? d_(Encounter E)
		{
			List<CodeableConcept> ar_ = E?.Type;
			CqlConcept as_(CodeableConcept @this)
			{
				CqlConcept ax_ = FHIRHelpers_4_3_000.Instance.ToConcept(context, @this);

				return ax_;
			};
			IEnumerable<CqlConcept> at_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)ar_, as_);
			bool? au_(CqlConcept T)
			{
				CqlCode ay_ = this.Health_behavior_assessment__or_re_assessment__ie__health_focused_clinical_interview__behavioral_observations__clinical_decision_making_(context);
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
				CqlConcept bh_ = FHIRHelpers_4_3_000.Instance.ToConcept(context, @this);

				return bh_;
			};
			IEnumerable<CqlConcept> bd_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)bb_, bc_);
			bool? be_(CqlConcept T)
			{
				CqlCode bi_ = this.Health_behavior_intervention__individual__face_to_face__initial_30_minutes(context);
				CqlConcept bj_ = context.Operators.ConvertCodeToConcept(bi_);
				bool? bk_ = context.Operators.Equivalent(T, bj_);

				return bk_;
			};
			IEnumerable<CqlConcept> bf_ = context.Operators.Where<CqlConcept>(bd_, be_);
			bool? bg_ = context.Operators.Exists<CqlConcept>(bf_);

			return bg_;
		};
		IEnumerable<Encounter> i_ = context.Operators.Where<Encounter>(c_, h_);
		CqlValueSet j_ = this.Occupational_Therapy_Evaluation(context);
		IEnumerable<Encounter> k_ = context.Operators.RetrieveByValueSet<Encounter>(j_, default);
		IEnumerable<Encounter> l_ = context.Operators.Union<Encounter>(i_, k_);
		IEnumerable<Encounter> m_ = context.Operators.Union<Encounter>(f_, l_);
		CqlValueSet n_ = this.Office_Visit(context);
		IEnumerable<Encounter> o_ = context.Operators.RetrieveByValueSet<Encounter>(n_, default);
		CqlValueSet p_ = this.Ophthalmological_Services(context);
		IEnumerable<Encounter> q_ = context.Operators.RetrieveByValueSet<Encounter>(p_, default);
		IEnumerable<Encounter> r_ = context.Operators.Union<Encounter>(o_, q_);
		IEnumerable<Encounter> s_ = context.Operators.Union<Encounter>(m_, r_);
		CqlValueSet t_ = this.Physical_Therapy_Evaluation(context);
		IEnumerable<Encounter> u_ = context.Operators.RetrieveByValueSet<Encounter>(t_, default);
		CqlValueSet v_ = this.Psych_Visit_Diagnostic_Evaluation(context);
		IEnumerable<Encounter> w_ = context.Operators.RetrieveByValueSet<Encounter>(v_, default);
		IEnumerable<Encounter> x_ = context.Operators.Union<Encounter>(u_, w_);
		IEnumerable<Encounter> y_ = context.Operators.Union<Encounter>(s_, x_);
		CqlValueSet z_ = this.Psych_Visit_Psychotherapy(context);
		IEnumerable<Encounter> aa_ = context.Operators.RetrieveByValueSet<Encounter>(z_, default);
		CqlValueSet ab_ = this.Psychoanalysis(context);
		IEnumerable<Encounter> ac_ = context.Operators.RetrieveByValueSet<Encounter>(ab_, default);
		IEnumerable<Encounter> ad_ = context.Operators.Union<Encounter>(aa_, ac_);
		IEnumerable<Encounter> ae_ = context.Operators.Union<Encounter>(y_, ad_);
		CqlValueSet af_ = this.Speech_and_Hearing_Evaluation(context);
		IEnumerable<Encounter> ag_ = context.Operators.RetrieveByValueSet<Encounter>(af_, default);
		CqlValueSet ah_ = this.Telephone_Visits(context);
		IEnumerable<Encounter> ai_ = context.Operators.RetrieveByValueSet<Encounter>(ah_, default);
		IEnumerable<Encounter> aj_ = context.Operators.Union<Encounter>(ag_, ai_);
		IEnumerable<Encounter> ak_ = context.Operators.Union<Encounter>(ae_, aj_);
		CqlValueSet al_ = this.Online_Assessments(context);
		IEnumerable<Encounter> am_ = context.Operators.RetrieveByValueSet<Encounter>(al_, default);
		IEnumerable<Encounter> an_ = context.Operators.Union<Encounter>(ak_, am_);
		IEnumerable<Encounter> ao_ = Status_1_6_000.Instance.isEncounterPerformed(context, an_);
		bool? ap_(Encounter OfficeBasedEncounter)
		{
			CqlInterval<CqlDateTime> bl_ = this.Measurement_Period(context);
			Period bm_ = OfficeBasedEncounter?.Period;
			CqlInterval<CqlDateTime> bn_ = FHIRHelpers_4_3_000.Instance.ToInterval(context, bm_);
			CqlInterval<CqlDateTime> bo_ = QICoreCommon_2_0_000.Instance.toInterval(context, bn_ as object);
			bool? bp_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(bl_, bo_, "day");

			return bp_;
		};
		IEnumerable<Encounter> aq_ = context.Operators.Where<Encounter>(ao_, ap_);

		return aq_;
	}


    [CqlDeclaration("Preventive Visit During Measurement Period")]
	public IEnumerable<Encounter> Preventive_Visit_During_Measurement_Period(CqlContext context)
	{
		CqlValueSet a_ = this.Annual_Wellness_Visit(context);
		IEnumerable<Encounter> b_ = context.Operators.RetrieveByValueSet<Encounter>(a_, default);
		CqlValueSet c_ = this.Preventive_Care_Services_Established_Office_Visit__18_and_Up(context);
		IEnumerable<Encounter> d_ = context.Operators.RetrieveByValueSet<Encounter>(c_, default);
		IEnumerable<Encounter> e_ = context.Operators.Union<Encounter>(b_, d_);
		CqlValueSet f_ = this.Preventive_Care_Services_Group_Counseling(context);
		IEnumerable<Encounter> g_ = context.Operators.RetrieveByValueSet<Encounter>(f_, default);
		IEnumerable<Encounter> h_ = context.Operators.RetrieveByValueSet<Encounter>(default, default);
		bool? i_(Encounter E)
		{
			List<CodeableConcept> ac_ = E?.Type;
			CqlConcept ad_(CodeableConcept @this)
			{
				CqlConcept ai_ = FHIRHelpers_4_3_000.Instance.ToConcept(context, @this);

				return ai_;
			};
			IEnumerable<CqlConcept> ae_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)ac_, ad_);
			bool? af_(CqlConcept T)
			{
				CqlCode aj_ = this.Unlisted_preventive_medicine_service(context);
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
		CqlValueSet m_ = this.Preventive_Care_Services_Individual_Counseling(context);
		IEnumerable<Encounter> n_ = context.Operators.RetrieveByValueSet<Encounter>(m_, default);
		bool? p_(Encounter E)
		{
			List<CodeableConcept> am_ = E?.Type;
			CqlConcept an_(CodeableConcept @this)
			{
				CqlConcept as_ = FHIRHelpers_4_3_000.Instance.ToConcept(context, @this);

				return as_;
			};
			IEnumerable<CqlConcept> ao_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)am_, an_);
			bool? ap_(CqlConcept T)
			{
				CqlCode at_ = this.Postoperative_follow_up_visit__normally_included_in_the_surgical_package__to_indicate_that_an_evaluation_and_management_service_was_performed_during_a_postoperative_period_for_a_reason_s__related_to_the_original_procedure(context);
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
		CqlValueSet t_ = this.Nutrition_Services(context);
		IEnumerable<Encounter> u_ = context.Operators.RetrieveByValueSet<Encounter>(t_, default);
		CqlValueSet v_ = this.Preventive_Care_Services_Initial_Office_Visit__18_and_Up(context);
		IEnumerable<Encounter> w_ = context.Operators.RetrieveByValueSet<Encounter>(v_, default);
		IEnumerable<Encounter> x_ = context.Operators.Union<Encounter>(u_, w_);
		IEnumerable<Encounter> y_ = context.Operators.Union<Encounter>(s_, x_);
		IEnumerable<Encounter> z_ = Status_1_6_000.Instance.isEncounterPerformed(context, y_);
		bool? aa_(Encounter PreventiveEncounter)
		{
			CqlInterval<CqlDateTime> aw_ = this.Measurement_Period(context);
			Period ax_ = PreventiveEncounter?.Period;
			CqlInterval<CqlDateTime> ay_ = FHIRHelpers_4_3_000.Instance.ToInterval(context, ax_);
			CqlInterval<CqlDateTime> az_ = QICoreCommon_2_0_000.Instance.toInterval(context, ay_ as object);
			bool? ba_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(aw_, az_, "day");

			return ba_;
		};
		IEnumerable<Encounter> ab_ = context.Operators.Where<Encounter>(z_, aa_);

		return ab_;
	}


    [CqlDeclaration("Initial Population")]
	public bool? Initial_Population(CqlContext context)
	{
		Patient a_ = this.Patient(context);
		Date b_ = a_?.BirthDateElement;
		string c_ = b_?.Value;
		CqlDate d_ = context.Operators.ConvertStringToDate(c_);
		CqlInterval<CqlDateTime> e_ = this.Measurement_Period(context);
		CqlDateTime f_ = context.Operators.Start(e_);
		CqlDate g_ = context.Operators.DateFrom(f_);
		int? h_ = context.Operators.CalculateAgeAt(d_, g_, "year");
		bool? i_ = context.Operators.GreaterOrEqual(h_, 12);
		IEnumerable<Encounter> j_ = this.Qualifying_Visit_During_Measurement_Period(context);
		int? k_ = context.Operators.Count<Encounter>(j_);
		bool? l_ = context.Operators.GreaterOrEqual(k_, 2);
		IEnumerable<Encounter> m_ = this.Preventive_Visit_During_Measurement_Period(context);
		bool? n_ = context.Operators.Exists<Encounter>(m_);
		bool? o_ = context.Operators.Or(l_, n_);
		bool? p_ = context.Operators.And(i_, o_);

		return p_;
	}


    [CqlDeclaration("Denominator 1")]
	public bool? Denominator_1(CqlContext context)
	{
		bool? a_ = this.Initial_Population(context);

		return a_;
	}


    [CqlDeclaration("Most Recent Tobacco Use Screening Indicates Tobacco User")]
	public Observation Most_Recent_Tobacco_Use_Screening_Indicates_Tobacco_User(CqlContext context)
	{
		CqlValueSet a_ = this.Tobacco_Use_Screening(context);
		IEnumerable<Observation> b_ = context.Operators.RetrieveByValueSet<Observation>(a_, default);
		IEnumerable<Observation> c_ = Status_1_6_000.Instance.isAssessmentPerformed(context, b_);
		bool? d_(Observation TobaccoUseScreening)
		{
			CqlInterval<CqlDateTime> m_ = this.Measurement_Period(context);
			DataType n_ = TobaccoUseScreening?.Effective;
			object o_ = FHIRHelpers_4_3_000.Instance.ToValue(context, n_);
			CqlInterval<CqlDateTime> p_ = QICoreCommon_2_0_000.Instance.toInterval(context, o_);
			bool? q_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(m_, p_, "day");

			return q_;
		};
		IEnumerable<Observation> e_ = context.Operators.Where<Observation>(c_, d_);
		object f_(Observation @this)
		{
			DataType r_ = @this?.Effective;
			object s_ = FHIRHelpers_4_3_000.Instance.ToValue(context, r_);
			CqlInterval<CqlDateTime> t_ = QICoreCommon_2_0_000.Instance.toInterval(context, s_);
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
			object w_ = FHIRHelpers_4_3_000.Instance.ToValue(context, v_);
			CqlValueSet x_ = this.Tobacco_User(context);
			bool? y_ = context.Operators.ConceptInValueSet(w_ as CqlConcept, x_);

			return y_;
		};
		IEnumerable<Observation> k_ = context.Operators.Where<Observation>((IEnumerable<Observation>)i_, j_);
		Observation l_ = context.Operators.SingletonFrom<Observation>(k_);

		return l_;
	}


    [CqlDeclaration("Denominator 2")]
	public bool? Denominator_2(CqlContext context)
	{
		bool? a_ = this.Initial_Population(context);
		Observation b_ = this.Most_Recent_Tobacco_Use_Screening_Indicates_Tobacco_User(context);
		bool? c_ = context.Operators.Not((bool?)(b_ is null));
		bool? d_ = context.Operators.And(a_, c_);

		return d_;
	}


    [CqlDeclaration("Denominator 3")]
	public bool? Denominator_3(CqlContext context)
	{
		bool? a_ = this.Initial_Population(context);

		return a_;
	}


    [CqlDeclaration("Most Recent Tobacco Use Screening Indicates Tobacco Non User")]
	public Observation Most_Recent_Tobacco_Use_Screening_Indicates_Tobacco_Non_User(CqlContext context)
	{
		CqlValueSet a_ = this.Tobacco_Use_Screening(context);
		IEnumerable<Observation> b_ = context.Operators.RetrieveByValueSet<Observation>(a_, default);
		IEnumerable<Observation> c_ = Status_1_6_000.Instance.isAssessmentPerformed(context, b_);
		bool? d_(Observation TobaccoUseScreening)
		{
			CqlInterval<CqlDateTime> m_ = this.Measurement_Period(context);
			DataType n_ = TobaccoUseScreening?.Effective;
			object o_ = FHIRHelpers_4_3_000.Instance.ToValue(context, n_);
			CqlInterval<CqlDateTime> p_ = QICoreCommon_2_0_000.Instance.toInterval(context, o_);
			bool? q_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(m_, p_, "day");

			return q_;
		};
		IEnumerable<Observation> e_ = context.Operators.Where<Observation>(c_, d_);
		object f_(Observation @this)
		{
			DataType r_ = @this?.Effective;
			object s_ = FHIRHelpers_4_3_000.Instance.ToValue(context, r_);
			CqlInterval<CqlDateTime> t_ = QICoreCommon_2_0_000.Instance.toInterval(context, s_);
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
			object w_ = FHIRHelpers_4_3_000.Instance.ToValue(context, v_);
			CqlValueSet x_ = this.Tobacco_Non_User(context);
			bool? y_ = context.Operators.ConceptInValueSet(w_ as CqlConcept, x_);

			return y_;
		};
		IEnumerable<Observation> k_ = context.Operators.Where<Observation>((IEnumerable<Observation>)i_, j_);
		Observation l_ = context.Operators.SingletonFrom<Observation>(k_);

		return l_;
	}


    [CqlDeclaration("Numerator 1")]
	public bool? Numerator_1(CqlContext context)
	{
		Observation a_ = this.Most_Recent_Tobacco_Use_Screening_Indicates_Tobacco_Non_User(context);
		bool? b_ = context.Operators.Not((bool?)(a_ is null));
		Observation c_ = this.Most_Recent_Tobacco_Use_Screening_Indicates_Tobacco_User(context);
		bool? d_ = context.Operators.Not((bool?)(c_ is null));
		bool? e_ = context.Operators.Or(b_, d_);

		return e_;
	}


    [CqlDeclaration("Tobacco Cessation Counseling Given")]
	public IEnumerable<object> Tobacco_Cessation_Counseling_Given(CqlContext context)
	{
		CqlValueSet a_ = this.Tobacco_Use_Cessation_Counseling(context);
		IEnumerable<Procedure> b_ = context.Operators.RetrieveByValueSet<Procedure>(a_, default);
		IEnumerable<Procedure> c_ = Status_1_6_000.Instance.isInterventionPerformed(context, b_);
		bool? d_(Procedure TobaccoCessationCounseling)
		{
			CqlInterval<CqlDateTime> l_ = this.Measurement_Period(context);
			CqlDateTime m_ = context.Operators.Start(l_);
			CqlQuantity n_ = context.Operators.Quantity(6m, "months");
			CqlDateTime o_ = context.Operators.Subtract(m_, n_);
			CqlDateTime q_ = context.Operators.End(l_);
			CqlInterval<CqlDateTime> r_ = context.Operators.Interval(o_, q_, true, true);
			DataType s_ = TobaccoCessationCounseling?.Performed;
			object t_ = FHIRHelpers_4_3_000.Instance.ToValue(context, s_);
			CqlInterval<CqlDateTime> u_ = QICoreCommon_2_0_000.Instance.toInterval(context, t_);
			bool? v_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(r_, u_, "day");

			return v_;
		};
		IEnumerable<Procedure> e_ = context.Operators.Where<Procedure>(c_, d_);
		CqlCode f_ = this.Tobacco_abuse_counseling(context);
		IEnumerable<CqlCode> g_ = context.Operators.ToList<CqlCode>(f_);
		IEnumerable<Condition> h_ = context.Operators.RetrieveByCodes<Condition>(g_, default);
		bool? i_(Condition TobaccoCounseling)
		{
			CqlInterval<CqlDateTime> w_ = QICoreCommon_2_0_000.Instance.prevalenceInterval(context, TobaccoCounseling);
			CqlDateTime x_ = context.Operators.Start(w_);
			CqlInterval<CqlDateTime> y_ = this.Measurement_Period(context);
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


    [CqlDeclaration("Tobacco Cessation Pharmacotherapy Ordered")]
	public IEnumerable<MedicationRequest> Tobacco_Cessation_Pharmacotherapy_Ordered(CqlContext context)
	{
		CqlValueSet a_ = this.Tobacco_Use_Cessation_Pharmacotherapy(context);
		IEnumerable<MedicationRequest> b_ = context.Operators.RetrieveByValueSet<MedicationRequest>(a_, default);
		IEnumerable<MedicationRequest> d_ = context.Operators.RetrieveByValueSet<MedicationRequest>(a_, default);
		IEnumerable<MedicationRequest> e_ = context.Operators.Union<MedicationRequest>(b_, d_);
		IEnumerable<MedicationRequest> f_ = Status_1_6_000.Instance.isMedicationOrder(context, e_);
		bool? g_(MedicationRequest CessationPharmacotherapyOrdered)
		{
			FhirDateTime i_ = CessationPharmacotherapyOrdered?.AuthoredOnElement;
			CqlDateTime j_ = context.Operators.Convert<CqlDateTime>(i_);
			CqlInterval<CqlDateTime> k_ = this.Measurement_Period(context);
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
	public IEnumerable<MedicationRequest> Active_Pharmacotherapy_for_Tobacco_Cessation(CqlContext context)
	{
		CqlValueSet a_ = this.Tobacco_Use_Cessation_Pharmacotherapy(context);
		IEnumerable<MedicationRequest> b_ = context.Operators.RetrieveByValueSet<MedicationRequest>(a_, default);
		IEnumerable<MedicationRequest> d_ = context.Operators.RetrieveByValueSet<MedicationRequest>(a_, default);
		IEnumerable<MedicationRequest> e_ = context.Operators.Union<MedicationRequest>(b_, d_);
		IEnumerable<MedicationRequest> f_ = Status_1_6_000.Instance.isMedicationActive(context, e_);
		bool? g_(MedicationRequest TakingCessationPharmacotherapy)
		{
			FhirDateTime i_ = TakingCessationPharmacotherapy?.AuthoredOnElement;
			CqlDateTime j_ = context.Operators.Convert<CqlDateTime>(i_);
			CqlInterval<CqlDateTime> k_ = this.Measurement_Period(context);
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


    [CqlDeclaration("Numerator 2")]
	public bool? Numerator_2(CqlContext context)
	{
		IEnumerable<object> a_ = this.Tobacco_Cessation_Counseling_Given(context);
		bool? b_ = context.Operators.Exists<object>(a_);
		IEnumerable<MedicationRequest> c_ = this.Tobacco_Cessation_Pharmacotherapy_Ordered(context);
		bool? d_ = context.Operators.Exists<MedicationRequest>(c_);
		bool? e_ = context.Operators.Or(b_, d_);
		IEnumerable<MedicationRequest> f_ = this.Active_Pharmacotherapy_for_Tobacco_Cessation(context);
		bool? g_ = context.Operators.Exists<MedicationRequest>(f_);
		bool? h_ = context.Operators.Or(e_, g_);

		return h_;
	}


    [CqlDeclaration("Numerator 3")]
	public bool? Numerator_3(CqlContext context)
	{
		Observation a_ = this.Most_Recent_Tobacco_Use_Screening_Indicates_Tobacco_Non_User(context);
		bool? b_ = context.Operators.Not((bool?)(a_ is null));
		Observation c_ = this.Most_Recent_Tobacco_Use_Screening_Indicates_Tobacco_User(context);
		bool? d_ = context.Operators.Not((bool?)(c_ is null));
		IEnumerable<object> e_ = this.Tobacco_Cessation_Counseling_Given(context);
		bool? f_ = context.Operators.Exists<object>(e_);
		IEnumerable<MedicationRequest> g_ = this.Tobacco_Cessation_Pharmacotherapy_Ordered(context);
		bool? h_ = context.Operators.Exists<MedicationRequest>(g_);
		bool? i_ = context.Operators.Or(f_, h_);
		IEnumerable<MedicationRequest> j_ = this.Active_Pharmacotherapy_for_Tobacco_Cessation(context);
		bool? k_ = context.Operators.Exists<MedicationRequest>(j_);
		bool? l_ = context.Operators.Or(i_, k_);
		bool? m_ = context.Operators.And(d_, l_);
		bool? n_ = context.Operators.Or(b_, m_);

		return n_;
	}


    [CqlDeclaration("Denominator Exclusion")]
	public bool? Denominator_Exclusion(CqlContext context)
	{
		bool? a_ = Hospice_6_9_000.Instance.Has_Hospice_Services(context);

		return a_;
	}


    [CqlDeclaration("SDE Ethnicity")]
	public (IEnumerable<CqlCode> codes, string display)? SDE_Ethnicity(CqlContext context)
	{
		(IEnumerable<CqlCode> codes, string display)? a_ = SupplementalDataElements_3_4_000.Instance.SDE_Ethnicity(context);

		return a_;
	}


    [CqlDeclaration("SDE Payer")]
	public IEnumerable<(CqlConcept code, CqlInterval<CqlDateTime> period)?> SDE_Payer(CqlContext context)
	{
		IEnumerable<(CqlConcept code, CqlInterval<CqlDateTime> period)?> a_ = SupplementalDataElements_3_4_000.Instance.SDE_Payer(context);

		return a_;
	}


    [CqlDeclaration("SDE Race")]
	public (IEnumerable<CqlCode> codes, string display)? SDE_Race(CqlContext context)
	{
		(IEnumerable<CqlCode> codes, string display)? a_ = SupplementalDataElements_3_4_000.Instance.SDE_Race(context);

		return a_;
	}


    [CqlDeclaration("SDE Sex")]
	public CqlCode SDE_Sex(CqlContext context)
	{
		CqlCode a_ = SupplementalDataElements_3_4_000.Instance.SDE_Sex(context);

		return a_;
	}

}
