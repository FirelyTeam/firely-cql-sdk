﻿using System;
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
[CqlLibrary("AppropriateTreatmentforUpperRespiratoryInfectionURIFHIR", "0.1.000")]
public class AppropriateTreatmentforUpperRespiratoryInfectionURIFHIR_0_1_000
{


    internal CqlContext context;

    #region Cached values

    internal Lazy<CqlValueSet> __Antibiotic_Medications_for_Upper_Respiratory_Infection;
    internal Lazy<CqlValueSet> __Comorbid_Conditions_for_Respiratory_Conditions;
    internal Lazy<CqlValueSet> __Competing_Conditions_for_Respiratory_Conditions;
    internal Lazy<CqlValueSet> __Emergency_Department_Evaluation_and_Management_Visit;
    internal Lazy<CqlValueSet> __Home_Healthcare_Services;
    internal Lazy<CqlValueSet> __Initial_Hospital_Observation_Care;
    internal Lazy<CqlValueSet> __Medical_Disability_Exam;
    internal Lazy<CqlValueSet> __Observation;
    internal Lazy<CqlValueSet> __Office_Visit;
    internal Lazy<CqlValueSet> __Online_Assessments;
    internal Lazy<CqlValueSet> __Outpatient_Consultation;
    internal Lazy<CqlValueSet> __Preventive_Care_Services_Established_Office_Visit__18_and_Up;
    internal Lazy<CqlValueSet> __Preventive_Care_Services_Group_Counseling;
    internal Lazy<CqlValueSet> __Preventive_Care_Services_Individual_Counseling;
    internal Lazy<CqlValueSet> __Preventive_Care_Services_Initial_Office_Visit__18_and_Up;
    internal Lazy<CqlValueSet> __Preventive_Care_Services__Initial_Office_Visit__0_to_17;
    internal Lazy<CqlValueSet> __Preventive_Care__Established_Office_Visit__0_to_17;
    internal Lazy<CqlValueSet> __Telephone_Visits;
    internal Lazy<CqlValueSet> __Upper_Respiratory_Infection;
    internal Lazy<CqlCode> __Unlisted_preventive_medicine_service;
    internal Lazy<CqlCode[]> __CPT;
    internal Lazy<CqlInterval<CqlDateTime>> __Measurement_Period;
    internal Lazy<Patient> __Patient;
    internal Lazy<Tuple_DMgHTLENEHBHWJISQgKZGZVMB> __SDE_Ethnicity;
    internal Lazy<IEnumerable<Tuple_GDKRbfOIHhLGieQSVDEMIaDPX>> __SDE_Payer;
    internal Lazy<Tuple_DMgHTLENEHBHWJISQgKZGZVMB> __SDE_Race;
    internal Lazy<CqlCode> __SDE_Sex;
    internal Lazy<IEnumerable<Encounter>> __Qualifying_Encounters;
    internal Lazy<IEnumerable<Encounter>> __Encounter_with_Upper_Respiratory_Infection;
    internal Lazy<IEnumerable<Encounter>> __Initial_Population;
    internal Lazy<IEnumerable<Encounter>> __Encounters_and_Assessments_with_Hospice_Patient;
    internal Lazy<IEnumerable<Encounter>> __Denominator;
    internal Lazy<IEnumerable<Encounter>> __Denominator_Exclusions;
    internal Lazy<IEnumerable<Encounter>> __Numerator;
    internal Lazy<IEnumerable<Encounter>> __Stratification_1;
    internal Lazy<IEnumerable<Encounter>> __Stratification_2;
    internal Lazy<IEnumerable<Encounter>> __Stratification_3;

    #endregion
    public AppropriateTreatmentforUpperRespiratoryInfectionURIFHIR_0_1_000(CqlContext context)
    {
        this.context = context ?? throw new ArgumentNullException("context");

        FHIRHelpers_4_3_000 = new FHIRHelpers_4_3_000(context);
        SupplementalDataElements_3_4_000 = new SupplementalDataElements_3_4_000(context);
        CQMCommon_2_0_000 = new CQMCommon_2_0_000(context);
        Hospice_6_9_000 = new Hospice_6_9_000(context);
        Status_1_6_000 = new Status_1_6_000(context);
        QICoreCommon_2_0_000 = new QICoreCommon_2_0_000(context);
        Antibiotic_1_5_000 = new Antibiotic_1_5_000(context);

        __Antibiotic_Medications_for_Upper_Respiratory_Infection = new Lazy<CqlValueSet>(this.Antibiotic_Medications_for_Upper_Respiratory_Infection_Value);
        __Comorbid_Conditions_for_Respiratory_Conditions = new Lazy<CqlValueSet>(this.Comorbid_Conditions_for_Respiratory_Conditions_Value);
        __Competing_Conditions_for_Respiratory_Conditions = new Lazy<CqlValueSet>(this.Competing_Conditions_for_Respiratory_Conditions_Value);
        __Emergency_Department_Evaluation_and_Management_Visit = new Lazy<CqlValueSet>(this.Emergency_Department_Evaluation_and_Management_Visit_Value);
        __Home_Healthcare_Services = new Lazy<CqlValueSet>(this.Home_Healthcare_Services_Value);
        __Initial_Hospital_Observation_Care = new Lazy<CqlValueSet>(this.Initial_Hospital_Observation_Care_Value);
        __Medical_Disability_Exam = new Lazy<CqlValueSet>(this.Medical_Disability_Exam_Value);
        __Observation = new Lazy<CqlValueSet>(this.Observation_Value);
        __Office_Visit = new Lazy<CqlValueSet>(this.Office_Visit_Value);
        __Online_Assessments = new Lazy<CqlValueSet>(this.Online_Assessments_Value);
        __Outpatient_Consultation = new Lazy<CqlValueSet>(this.Outpatient_Consultation_Value);
        __Preventive_Care_Services_Established_Office_Visit__18_and_Up = new Lazy<CqlValueSet>(this.Preventive_Care_Services_Established_Office_Visit__18_and_Up_Value);
        __Preventive_Care_Services_Group_Counseling = new Lazy<CqlValueSet>(this.Preventive_Care_Services_Group_Counseling_Value);
        __Preventive_Care_Services_Individual_Counseling = new Lazy<CqlValueSet>(this.Preventive_Care_Services_Individual_Counseling_Value);
        __Preventive_Care_Services_Initial_Office_Visit__18_and_Up = new Lazy<CqlValueSet>(this.Preventive_Care_Services_Initial_Office_Visit__18_and_Up_Value);
        __Preventive_Care_Services__Initial_Office_Visit__0_to_17 = new Lazy<CqlValueSet>(this.Preventive_Care_Services__Initial_Office_Visit__0_to_17_Value);
        __Preventive_Care__Established_Office_Visit__0_to_17 = new Lazy<CqlValueSet>(this.Preventive_Care__Established_Office_Visit__0_to_17_Value);
        __Telephone_Visits = new Lazy<CqlValueSet>(this.Telephone_Visits_Value);
        __Upper_Respiratory_Infection = new Lazy<CqlValueSet>(this.Upper_Respiratory_Infection_Value);
        __Unlisted_preventive_medicine_service = new Lazy<CqlCode>(this.Unlisted_preventive_medicine_service_Value);
        __CPT = new Lazy<CqlCode[]>(this.CPT_Value);
        __Measurement_Period = new Lazy<CqlInterval<CqlDateTime>>(this.Measurement_Period_Value);
        __Patient = new Lazy<Patient>(this.Patient_Value);
        __SDE_Ethnicity = new Lazy<Tuple_DMgHTLENEHBHWJISQgKZGZVMB>(this.SDE_Ethnicity_Value);
        __SDE_Payer = new Lazy<IEnumerable<Tuple_GDKRbfOIHhLGieQSVDEMIaDPX>>(this.SDE_Payer_Value);
        __SDE_Race = new Lazy<Tuple_DMgHTLENEHBHWJISQgKZGZVMB>(this.SDE_Race_Value);
        __SDE_Sex = new Lazy<CqlCode>(this.SDE_Sex_Value);
        __Qualifying_Encounters = new Lazy<IEnumerable<Encounter>>(this.Qualifying_Encounters_Value);
        __Encounter_with_Upper_Respiratory_Infection = new Lazy<IEnumerable<Encounter>>(this.Encounter_with_Upper_Respiratory_Infection_Value);
        __Initial_Population = new Lazy<IEnumerable<Encounter>>(this.Initial_Population_Value);
        __Encounters_and_Assessments_with_Hospice_Patient = new Lazy<IEnumerable<Encounter>>(this.Encounters_and_Assessments_with_Hospice_Patient_Value);
        __Denominator = new Lazy<IEnumerable<Encounter>>(this.Denominator_Value);
        __Denominator_Exclusions = new Lazy<IEnumerable<Encounter>>(this.Denominator_Exclusions_Value);
        __Numerator = new Lazy<IEnumerable<Encounter>>(this.Numerator_Value);
        __Stratification_1 = new Lazy<IEnumerable<Encounter>>(this.Stratification_1_Value);
        __Stratification_2 = new Lazy<IEnumerable<Encounter>>(this.Stratification_2_Value);
        __Stratification_3 = new Lazy<IEnumerable<Encounter>>(this.Stratification_3_Value);
    }
    #region Dependencies

    public FHIRHelpers_4_3_000 FHIRHelpers_4_3_000 { get; }
    public SupplementalDataElements_3_4_000 SupplementalDataElements_3_4_000 { get; }
    public CQMCommon_2_0_000 CQMCommon_2_0_000 { get; }
    public Hospice_6_9_000 Hospice_6_9_000 { get; }
    public Status_1_6_000 Status_1_6_000 { get; }
    public QICoreCommon_2_0_000 QICoreCommon_2_0_000 { get; }
    public Antibiotic_1_5_000 Antibiotic_1_5_000 { get; }

    #endregion

	private CqlValueSet Antibiotic_Medications_for_Upper_Respiratory_Infection_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.196.12.1001", null);

    [CqlDeclaration("Antibiotic Medications for Upper Respiratory Infection")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.196.12.1001")]
	public CqlValueSet Antibiotic_Medications_for_Upper_Respiratory_Infection() => 
		__Antibiotic_Medications_for_Upper_Respiratory_Infection.Value;

	private CqlValueSet Comorbid_Conditions_for_Respiratory_Conditions_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.102.12.1025", null);

    [CqlDeclaration("Comorbid Conditions for Respiratory Conditions")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.102.12.1025")]
	public CqlValueSet Comorbid_Conditions_for_Respiratory_Conditions() => 
		__Comorbid_Conditions_for_Respiratory_Conditions.Value;

	private CqlValueSet Competing_Conditions_for_Respiratory_Conditions_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.102.12.1017", null);

    [CqlDeclaration("Competing Conditions for Respiratory Conditions")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.102.12.1017")]
	public CqlValueSet Competing_Conditions_for_Respiratory_Conditions() => 
		__Competing_Conditions_for_Respiratory_Conditions.Value;

	private CqlValueSet Emergency_Department_Evaluation_and_Management_Visit_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1010", null);

    [CqlDeclaration("Emergency Department Evaluation and Management Visit")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1010")]
	public CqlValueSet Emergency_Department_Evaluation_and_Management_Visit() => 
		__Emergency_Department_Evaluation_and_Management_Visit.Value;

	private CqlValueSet Home_Healthcare_Services_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1016", null);

    [CqlDeclaration("Home Healthcare Services")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1016")]
	public CqlValueSet Home_Healthcare_Services() => 
		__Home_Healthcare_Services.Value;

	private CqlValueSet Initial_Hospital_Observation_Care_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1002", null);

    [CqlDeclaration("Initial Hospital Observation Care")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1002")]
	public CqlValueSet Initial_Hospital_Observation_Care() => 
		__Initial_Hospital_Observation_Care.Value;

	private CqlValueSet Medical_Disability_Exam_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1073", null);

    [CqlDeclaration("Medical Disability Exam")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1073")]
	public CqlValueSet Medical_Disability_Exam() => 
		__Medical_Disability_Exam.Value;

	private CqlValueSet Observation_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1086", null);

    [CqlDeclaration("Observation")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1086")]
	public CqlValueSet Observation() => 
		__Observation.Value;

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

	private CqlValueSet Outpatient_Consultation_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1008", null);

    [CqlDeclaration("Outpatient Consultation")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1008")]
	public CqlValueSet Outpatient_Consultation() => 
		__Outpatient_Consultation.Value;

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

	private CqlValueSet Preventive_Care_Services__Initial_Office_Visit__0_to_17_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1022", null);

    [CqlDeclaration("Preventive Care Services, Initial Office Visit, 0 to 17")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1022")]
	public CqlValueSet Preventive_Care_Services__Initial_Office_Visit__0_to_17() => 
		__Preventive_Care_Services__Initial_Office_Visit__0_to_17.Value;

	private CqlValueSet Preventive_Care__Established_Office_Visit__0_to_17_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1024", null);

    [CqlDeclaration("Preventive Care, Established Office Visit, 0 to 17")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1024")]
	public CqlValueSet Preventive_Care__Established_Office_Visit__0_to_17() => 
		__Preventive_Care__Established_Office_Visit__0_to_17.Value;

	private CqlValueSet Telephone_Visits_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1080", null);

    [CqlDeclaration("Telephone Visits")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1080")]
	public CqlValueSet Telephone_Visits() => 
		__Telephone_Visits.Value;

	private CqlValueSet Upper_Respiratory_Infection_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.102.12.1022", null);

    [CqlDeclaration("Upper Respiratory Infection")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.102.12.1022")]
	public CqlValueSet Upper_Respiratory_Infection() => 
		__Upper_Respiratory_Infection.Value;

	private CqlCode Unlisted_preventive_medicine_service_Value() => 
		new CqlCode("99429", "http://www.ama-assn.org/go/cpt", null, null);

    [CqlDeclaration("Unlisted preventive medicine service")]
	public CqlCode Unlisted_preventive_medicine_service() => 
		__Unlisted_preventive_medicine_service.Value;

	private CqlCode[] CPT_Value()
	{
		var a_ = new CqlCode[]
		{
			new CqlCode("99429", "http://www.ama-assn.org/go/cpt", null, null),
		};

		return a_;
	}

    [CqlDeclaration("CPT")]
	public CqlCode[] CPT() => 
		__CPT.Value;

	private CqlInterval<CqlDateTime> Measurement_Period_Value()
	{
		var a_ = context.Operators.DateTime((int?)2025, (int?)1, (int?)1, (int?)0, (int?)0, (int?)0, (int?)0, default);
		var b_ = context.Operators.DateTime((int?)2026, (int?)1, (int?)1, (int?)0, (int?)0, (int?)0, (int?)0, default);
		var c_ = context.Operators.Interval(a_, b_, (bool?)true, (bool?)false);
		var d_ = context.ResolveParameter("AppropriateTreatmentforUpperRespiratoryInfectionURIFHIR-0.1.000", "Measurement Period", c_);

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
		var a_ = this.Emergency_Department_Evaluation_and_Management_Visit();
		var b_ = context.Operators.RetrieveByValueSet<Encounter>(a_, null);
		var c_ = this.Home_Healthcare_Services();
		var d_ = context.Operators.RetrieveByValueSet<Encounter>(c_, null);
		var e_ = context.Operators.ListUnion<Encounter>(b_, d_);
		var f_ = this.Initial_Hospital_Observation_Care();
		var g_ = context.Operators.RetrieveByValueSet<Encounter>(f_, null);
		var h_ = this.Medical_Disability_Exam();
		var i_ = context.Operators.RetrieveByValueSet<Encounter>(h_, null);
		var j_ = context.Operators.ListUnion<Encounter>(g_, i_);
		var k_ = context.Operators.ListUnion<Encounter>(e_, j_);
		var l_ = this.Observation();
		var m_ = context.Operators.RetrieveByValueSet<Encounter>(l_, null);
		var n_ = this.Office_Visit();
		var o_ = context.Operators.RetrieveByValueSet<Encounter>(n_, null);
		var p_ = context.Operators.ListUnion<Encounter>(m_, o_);
		var q_ = context.Operators.ListUnion<Encounter>(k_, p_);
		var r_ = this.Outpatient_Consultation();
		var s_ = context.Operators.RetrieveByValueSet<Encounter>(r_, null);
		var t_ = this.Preventive_Care_Services_Group_Counseling();
		var u_ = context.Operators.RetrieveByValueSet<Encounter>(t_, null);
		var v_ = context.Operators.ListUnion<Encounter>(s_, u_);
		var w_ = context.Operators.ListUnion<Encounter>(q_, v_);
		var x_ = this.Preventive_Care_Services_Individual_Counseling();
		var y_ = context.Operators.RetrieveByValueSet<Encounter>(x_, null);
		var z_ = this.Preventive_Care_Services__Initial_Office_Visit__0_to_17();
		var aa_ = context.Operators.RetrieveByValueSet<Encounter>(z_, null);
		var ab_ = context.Operators.ListUnion<Encounter>(y_, aa_);
		var ac_ = context.Operators.ListUnion<Encounter>(w_, ab_);
		var ad_ = this.Preventive_Care__Established_Office_Visit__0_to_17();
		var ae_ = context.Operators.RetrieveByValueSet<Encounter>(ad_, null);
		var af_ = this.Preventive_Care_Services_Established_Office_Visit__18_and_Up();
		var ag_ = context.Operators.RetrieveByValueSet<Encounter>(af_, null);
		var ah_ = context.Operators.ListUnion<Encounter>(ae_, ag_);
		var ai_ = context.Operators.ListUnion<Encounter>(ac_, ah_);
		var aj_ = this.Preventive_Care_Services_Initial_Office_Visit__18_and_Up();
		var ak_ = context.Operators.RetrieveByValueSet<Encounter>(aj_, null);
		var al_ = this.Telephone_Visits();
		var am_ = context.Operators.RetrieveByValueSet<Encounter>(al_, null);
		var an_ = context.Operators.ListUnion<Encounter>(ak_, am_);
		var ao_ = context.Operators.ListUnion<Encounter>(ai_, an_);
		var ap_ = this.Online_Assessments();
		var aq_ = context.Operators.RetrieveByValueSet<Encounter>(ap_, null);
		var ar_ = context.Operators.RetrieveByValueSet<Encounter>(null, null);
		bool? as_(Encounter E)
		{
			CqlConcept az_(CodeableConcept @this)
			{
				var be_ = FHIRHelpers_4_3_000.ToConcept(@this);

				return be_;
			};
			var ba_ = context.Operators.SelectOrNull<CodeableConcept, CqlConcept>(E?.Type, az_);
			bool? bb_(CqlConcept T)
			{
				var bf_ = this.Unlisted_preventive_medicine_service();
				var bg_ = context.Operators.ConvertCodeToConcept(bf_);
				var bh_ = context.Operators.Equivalent(T, bg_);

				return bh_;
			};
			var bc_ = context.Operators.WhereOrNull<CqlConcept>(ba_, bb_);
			var bd_ = context.Operators.Exists<CqlConcept>(bc_);

			return bd_;
		};
		var at_ = context.Operators.WhereOrNull<Encounter>(ar_, as_);
		var au_ = context.Operators.ListUnion<Encounter>(aq_, at_);
		var av_ = context.Operators.ListUnion<Encounter>(ao_, au_);
		var aw_ = Status_1_6_000.Finished_Encounter(av_);
		bool? ax_(Encounter ValidEncounter)
		{
			var bi_ = FHIRHelpers_4_3_000.ToInterval(ValidEncounter?.Period);
			var bj_ = QICoreCommon_2_0_000.ToInterval((bi_ as object));
			var bk_ = context.Operators.End(bj_);
			var bl_ = this.Measurement_Period();
			var bm_ = context.Operators.Start(bl_);
			var bo_ = context.Operators.End(bl_);
			var bp_ = context.Operators.Quantity((decimal?)3m, "days");
			var bq_ = context.Operators.Subtract(bo_, bp_);
			var br_ = context.Operators.Interval(bm_, bq_, (bool?)true, (bool?)true);
			var bs_ = context.Operators.InInterval<CqlDateTime>(bk_, br_, "day");

			return bs_;
		};
		var ay_ = context.Operators.WhereOrNull<Encounter>(aw_, ax_);

		return ay_;
	}

    [CqlDeclaration("Qualifying Encounters")]
	public IEnumerable<Encounter> Qualifying_Encounters() => 
		__Qualifying_Encounters.Value;

	private IEnumerable<Encounter> Encounter_with_Upper_Respiratory_Infection_Value()
	{
		var a_ = this.Qualifying_Encounters();
		var b_ = this.Upper_Respiratory_Infection();
		var c_ = context.Operators.RetrieveByValueSet<Condition>(b_, null);
		var d_ = context.Operators.CrossJoin<Encounter, Condition>(a_, c_);
		Tuple_CLQRPFFCjgiFZUVDVEDIIKeXW e_(ValueTuple<Encounter,Condition> _valueTuple)
		{
			var k_ = new Tuple_CLQRPFFCjgiFZUVDVEDIIKeXW
			{
				QualifyingEncounters = _valueTuple.Item1,
				URI = _valueTuple.Item2,
			};

			return k_;
		};
		var f_ = context.Operators.SelectOrNull<ValueTuple<Encounter,Condition>, Tuple_CLQRPFFCjgiFZUVDVEDIIKeXW>(d_, e_);
		bool? g_(Tuple_CLQRPFFCjgiFZUVDVEDIIKeXW tuple_clqrpffcjgifzuvdvediikexw)
		{
			var l_ = QICoreCommon_2_0_000.ToPrevalenceInterval(tuple_clqrpffcjgifzuvdvediikexw.URI);
			var m_ = context.Operators.Start(l_);
			var n_ = FHIRHelpers_4_3_000.ToInterval(tuple_clqrpffcjgifzuvdvediikexw.QualifyingEncounters?.Period);
			var o_ = QICoreCommon_2_0_000.ToInterval((n_ as object));
			var p_ = context.Operators.InInterval<CqlDateTime>(m_, o_, "day");
			var s_ = QICoreCommon_2_0_000.ToInterval((n_ as object));
			var t_ = context.Operators.OverlapsBefore(l_, s_, null);
			var u_ = context.Operators.Or(p_, t_);

			return u_;
		};
		var h_ = context.Operators.WhereOrNull<Tuple_CLQRPFFCjgiFZUVDVEDIIKeXW>(f_, g_);
		Encounter i_(Tuple_CLQRPFFCjgiFZUVDVEDIIKeXW tuple_clqrpffcjgifzuvdvediikexw) => 
			tuple_clqrpffcjgifzuvdvediikexw.QualifyingEncounters;
		var j_ = context.Operators.SelectOrNull<Tuple_CLQRPFFCjgiFZUVDVEDIIKeXW, Encounter>(h_, i_);

		return j_;
	}

    [CqlDeclaration("Encounter with Upper Respiratory Infection")]
	public IEnumerable<Encounter> Encounter_with_Upper_Respiratory_Infection() => 
		__Encounter_with_Upper_Respiratory_Infection.Value;

	private IEnumerable<Encounter> Initial_Population_Value()
	{
		var a_ = this.Encounter_with_Upper_Respiratory_Infection();
		bool? b_(Encounter EncounterWithURI)
		{
			var f_ = this.Patient();
			var g_ = context.Operators.Convert<CqlDate>(f_?.BirthDateElement?.Value);
			var h_ = this.Measurement_Period();
			var i_ = context.Operators.Start(h_);
			var j_ = context.Operators.DateFrom(i_);
			var k_ = context.Operators.CalculateAgeAt(g_, j_, "month");
			var l_ = context.Operators.GreaterOrEqual(k_, (int?)3);

			return l_;
		};
		var c_ = context.Operators.WhereOrNull<Encounter>(a_, b_);
		Encounter d_(Encounter EncounterWithURI) => 
			EncounterWithURI;
		var e_ = context.Operators.SelectOrNull<Encounter, Encounter>(c_, d_);

		return e_;
	}

    [CqlDeclaration("Initial Population")]
	public IEnumerable<Encounter> Initial_Population() => 
		__Initial_Population.Value;

	private IEnumerable<Encounter> Encounters_and_Assessments_with_Hospice_Patient_Value()
	{
		var a_ = this.Initial_Population();
		bool? b_(Encounter EligibleEncounters)
		{
			var d_ = Hospice_6_9_000.Has_Hospice_Services();

			return d_;
		};
		var c_ = context.Operators.WhereOrNull<Encounter>(a_, b_);

		return c_;
	}

    [CqlDeclaration("Encounters and Assessments with Hospice Patient")]
	public IEnumerable<Encounter> Encounters_and_Assessments_with_Hospice_Patient() => 
		__Encounters_and_Assessments_with_Hospice_Patient.Value;

	private IEnumerable<Encounter> Denominator_Value()
	{
		var a_ = this.Initial_Population();

		return a_;
	}

    [CqlDeclaration("Denominator")]
	public IEnumerable<Encounter> Denominator() => 
		__Denominator.Value;

	private IEnumerable<Encounter> Denominator_Exclusions_Value()
	{
		var a_ = this.Encounters_and_Assessments_with_Hospice_Patient();
		var b_ = this.Encounter_with_Upper_Respiratory_Infection();
		var c_ = this.Comorbid_Conditions_for_Respiratory_Conditions();
		var d_ = context.Operators.RetrieveByValueSet<Condition>(c_, null);
		var e_ = Antibiotic_1_5_000.Has_Comorbid_Condition_History(b_, d_);
		var f_ = context.Operators.ListUnion<Encounter>(a_, e_);
		var h_ = this.Antibiotic_Medications_for_Upper_Respiratory_Infection();
		var i_ = context.Operators.RetrieveByValueSet<MedicationRequest>(h_, null);
		var k_ = context.Operators.RetrieveByValueSet<MedicationRequest>(h_, null);
		var l_ = context.Operators.ListUnion<MedicationRequest>(i_, k_);
		var m_ = Antibiotic_1_5_000.Has_Antibiotic_Medication_History(b_, l_);
		var o_ = this.Competing_Conditions_for_Respiratory_Conditions();
		var p_ = context.Operators.RetrieveByValueSet<Condition>(o_, null);
		var q_ = Antibiotic_1_5_000.Has_Competing_Diagnosis_History(b_, p_);
		var r_ = context.Operators.ListUnion<Encounter>(m_, q_);
		var s_ = context.Operators.ListUnion<Encounter>(f_, r_);

		return s_;
	}

    [CqlDeclaration("Denominator Exclusions")]
	public IEnumerable<Encounter> Denominator_Exclusions() => 
		__Denominator_Exclusions.Value;

	private IEnumerable<Encounter> Numerator_Value()
	{
		var a_ = this.Encounter_with_Upper_Respiratory_Infection();
		IEnumerable<Encounter> c_(Encounter EncounterWithURI)
		{
			var h_ = this.Antibiotic_Medications_for_Upper_Respiratory_Infection();
			var i_ = context.Operators.RetrieveByValueSet<MedicationRequest>(h_, null);
			var k_ = context.Operators.RetrieveByValueSet<MedicationRequest>(h_, null);
			var l_ = context.Operators.ListUnion<MedicationRequest>(i_, k_);
			bool? m_(MedicationRequest OrderedAntibiotic)
			{
				var q_ = context.Operators.Convert<CqlDateTime>(OrderedAntibiotic?.AuthoredOnElement);
				var r_ = FHIRHelpers_4_3_000.ToInterval(EncounterWithURI?.Period);
				var s_ = QICoreCommon_2_0_000.ToInterval((r_ as object));
				var t_ = context.Operators.Start(s_);
				var v_ = QICoreCommon_2_0_000.ToInterval((r_ as object));
				var w_ = context.Operators.Start(v_);
				var x_ = context.Operators.Quantity((decimal?)3m, "days");
				var y_ = context.Operators.Add(w_, x_);
				var z_ = context.Operators.Interval(t_, y_, (bool?)true, (bool?)true);
				var aa_ = context.Operators.InInterval<CqlDateTime>(q_, z_, null);
				var ac_ = QICoreCommon_2_0_000.ToInterval((r_ as object));
				var ad_ = context.Operators.Start(ac_);
				var ae_ = context.Operators.Not((bool?)(ad_ is null));
				var af_ = context.Operators.And(aa_, ae_);

				return af_;
			};
			var n_ = context.Operators.WhereOrNull<MedicationRequest>(l_, m_);
			Encounter o_(MedicationRequest OrderedAntibiotic) => 
				EncounterWithURI;
			var p_ = context.Operators.SelectOrNull<MedicationRequest, Encounter>(n_, o_);

			return p_;
		};
		var d_ = context.Operators.SelectManyOrNull<Encounter, Encounter>(a_, c_);
		var e_ = context.Operators.ListExcept<Encounter>(a_, d_);
		Encounter f_(Encounter EncounterWithURI) => 
			EncounterWithURI;
		var g_ = context.Operators.SelectOrNull<Encounter, Encounter>(e_, f_);

		return g_;
	}

    [CqlDeclaration("Numerator")]
	public IEnumerable<Encounter> Numerator() => 
		__Numerator.Value;

	private IEnumerable<Encounter> Stratification_1_Value()
	{
		var a_ = this.Encounter_with_Upper_Respiratory_Infection();
		bool? b_(Encounter EncounterWithURI)
		{
			var f_ = this.Patient();
			var g_ = context.Operators.Convert<CqlDate>(f_?.BirthDateElement?.Value);
			var h_ = this.Measurement_Period();
			var i_ = context.Operators.Start(h_);
			var j_ = context.Operators.DateFrom(i_);
			var k_ = context.Operators.CalculateAgeAt(g_, j_, "month");
			var l_ = context.Operators.GreaterOrEqual(k_, (int?)3);
			var n_ = context.Operators.Convert<CqlDate>(f_?.BirthDateElement?.Value);
			var p_ = context.Operators.Start(h_);
			var q_ = context.Operators.DateFrom(p_);
			var r_ = context.Operators.CalculateAgeAt(n_, q_, "year");
			var s_ = context.Operators.LessOrEqual(r_, (int?)17);
			var t_ = context.Operators.And(l_, s_);

			return t_;
		};
		var c_ = context.Operators.WhereOrNull<Encounter>(a_, b_);
		Encounter d_(Encounter EncounterWithURI) => 
			EncounterWithURI;
		var e_ = context.Operators.SelectOrNull<Encounter, Encounter>(c_, d_);

		return e_;
	}

    [CqlDeclaration("Stratification 1")]
	public IEnumerable<Encounter> Stratification_1() => 
		__Stratification_1.Value;

	private IEnumerable<Encounter> Stratification_2_Value()
	{
		var a_ = this.Encounter_with_Upper_Respiratory_Infection();
		bool? b_(Encounter EncounterWithURI)
		{
			var f_ = this.Patient();
			var g_ = context.Operators.Convert<CqlDate>(f_?.BirthDateElement?.Value);
			var h_ = this.Measurement_Period();
			var i_ = context.Operators.Start(h_);
			var j_ = context.Operators.DateFrom(i_);
			var k_ = context.Operators.CalculateAgeAt(g_, j_, "year");
			var l_ = context.Operators.Interval((int?)18, (int?)64, (bool?)true, (bool?)true);
			var m_ = context.Operators.InInterval<int?>(k_, l_, null);

			return m_;
		};
		var c_ = context.Operators.WhereOrNull<Encounter>(a_, b_);
		Encounter d_(Encounter EncounterWithURI) => 
			EncounterWithURI;
		var e_ = context.Operators.SelectOrNull<Encounter, Encounter>(c_, d_);

		return e_;
	}

    [CqlDeclaration("Stratification 2")]
	public IEnumerable<Encounter> Stratification_2() => 
		__Stratification_2.Value;

	private IEnumerable<Encounter> Stratification_3_Value()
	{
		var a_ = this.Encounter_with_Upper_Respiratory_Infection();
		bool? b_(Encounter EncounterWithURI)
		{
			var f_ = this.Patient();
			var g_ = context.Operators.Convert<CqlDate>(f_?.BirthDateElement?.Value);
			var h_ = this.Measurement_Period();
			var i_ = context.Operators.Start(h_);
			var j_ = context.Operators.DateFrom(i_);
			var k_ = context.Operators.CalculateAgeAt(g_, j_, "year");
			var l_ = context.Operators.GreaterOrEqual(k_, (int?)65);

			return l_;
		};
		var c_ = context.Operators.WhereOrNull<Encounter>(a_, b_);
		Encounter d_(Encounter EncounterWithURI) => 
			EncounterWithURI;
		var e_ = context.Operators.SelectOrNull<Encounter, Encounter>(c_, d_);

		return e_;
	}

    [CqlDeclaration("Stratification 3")]
	public IEnumerable<Encounter> Stratification_3() => 
		__Stratification_3.Value;

}
