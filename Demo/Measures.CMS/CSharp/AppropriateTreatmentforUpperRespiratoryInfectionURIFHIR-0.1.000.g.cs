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
    internal Lazy<(IEnumerable<CqlCode> codes, string display)?> __SDE_Ethnicity;
    internal Lazy<IEnumerable<(CqlConcept code, CqlInterval<CqlDateTime> period)?>> __SDE_Payer;
    internal Lazy<(IEnumerable<CqlCode> codes, string display)?> __SDE_Race;
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
        __SDE_Ethnicity = new Lazy<(IEnumerable<CqlCode> codes, string display)?>(this.SDE_Ethnicity_Value);
        __SDE_Payer = new Lazy<IEnumerable<(CqlConcept code, CqlInterval<CqlDateTime> period)?>>(this.SDE_Payer_Value);
        __SDE_Race = new Lazy<(IEnumerable<CqlCode> codes, string display)?>(this.SDE_Race_Value);
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
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.196.12.1001", default);

    [CqlDeclaration("Antibiotic Medications for Upper Respiratory Infection")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.196.12.1001")]
	public CqlValueSet Antibiotic_Medications_for_Upper_Respiratory_Infection() => 
		__Antibiotic_Medications_for_Upper_Respiratory_Infection.Value;

	private CqlValueSet Comorbid_Conditions_for_Respiratory_Conditions_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.102.12.1025", default);

    [CqlDeclaration("Comorbid Conditions for Respiratory Conditions")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.102.12.1025")]
	public CqlValueSet Comorbid_Conditions_for_Respiratory_Conditions() => 
		__Comorbid_Conditions_for_Respiratory_Conditions.Value;

	private CqlValueSet Competing_Conditions_for_Respiratory_Conditions_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.102.12.1017", default);

    [CqlDeclaration("Competing Conditions for Respiratory Conditions")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.102.12.1017")]
	public CqlValueSet Competing_Conditions_for_Respiratory_Conditions() => 
		__Competing_Conditions_for_Respiratory_Conditions.Value;

	private CqlValueSet Emergency_Department_Evaluation_and_Management_Visit_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1010", default);

    [CqlDeclaration("Emergency Department Evaluation and Management Visit")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1010")]
	public CqlValueSet Emergency_Department_Evaluation_and_Management_Visit() => 
		__Emergency_Department_Evaluation_and_Management_Visit.Value;

	private CqlValueSet Home_Healthcare_Services_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1016", default);

    [CqlDeclaration("Home Healthcare Services")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1016")]
	public CqlValueSet Home_Healthcare_Services() => 
		__Home_Healthcare_Services.Value;

	private CqlValueSet Initial_Hospital_Observation_Care_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1002", default);

    [CqlDeclaration("Initial Hospital Observation Care")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1002")]
	public CqlValueSet Initial_Hospital_Observation_Care() => 
		__Initial_Hospital_Observation_Care.Value;

	private CqlValueSet Medical_Disability_Exam_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1073", default);

    [CqlDeclaration("Medical Disability Exam")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1073")]
	public CqlValueSet Medical_Disability_Exam() => 
		__Medical_Disability_Exam.Value;

	private CqlValueSet Observation_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1086", default);

    [CqlDeclaration("Observation")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1086")]
	public CqlValueSet Observation() => 
		__Observation.Value;

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

	private CqlValueSet Outpatient_Consultation_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1008", default);

    [CqlDeclaration("Outpatient Consultation")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1008")]
	public CqlValueSet Outpatient_Consultation() => 
		__Outpatient_Consultation.Value;

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

	private CqlValueSet Preventive_Care_Services__Initial_Office_Visit__0_to_17_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1022", default);

    [CqlDeclaration("Preventive Care Services, Initial Office Visit, 0 to 17")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1022")]
	public CqlValueSet Preventive_Care_Services__Initial_Office_Visit__0_to_17() => 
		__Preventive_Care_Services__Initial_Office_Visit__0_to_17.Value;

	private CqlValueSet Preventive_Care__Established_Office_Visit__0_to_17_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1024", default);

    [CqlDeclaration("Preventive Care, Established Office Visit, 0 to 17")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1024")]
	public CqlValueSet Preventive_Care__Established_Office_Visit__0_to_17() => 
		__Preventive_Care__Established_Office_Visit__0_to_17.Value;

	private CqlValueSet Telephone_Visits_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1080", default);

    [CqlDeclaration("Telephone Visits")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1080")]
	public CqlValueSet Telephone_Visits() => 
		__Telephone_Visits.Value;

	private CqlValueSet Upper_Respiratory_Infection_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.102.12.1022", default);

    [CqlDeclaration("Upper Respiratory Infection")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.102.12.1022")]
	public CqlValueSet Upper_Respiratory_Infection() => 
		__Upper_Respiratory_Infection.Value;

	private CqlCode Unlisted_preventive_medicine_service_Value() => 
		new CqlCode("99429", "http://www.ama-assn.org/go/cpt", default, default);

    [CqlDeclaration("Unlisted preventive medicine service")]
	public CqlCode Unlisted_preventive_medicine_service() => 
		__Unlisted_preventive_medicine_service.Value;

	private CqlCode[] CPT_Value()
	{
		CqlCode[] a_ = [
			new CqlCode("99429", "http://www.ama-assn.org/go/cpt", default, default),
		];

		return a_;
	}

    [CqlDeclaration("CPT")]
	public CqlCode[] CPT() => 
		__CPT.Value;

	private CqlInterval<CqlDateTime> Measurement_Period_Value()
	{
		CqlDateTime a_ = context.Operators.DateTime(2025, 1, 1, 0, 0, 0, 0, default);
		CqlDateTime b_ = context.Operators.DateTime(2026, 1, 1, 0, 0, 0, 0, default);
		CqlInterval<CqlDateTime> c_ = context.Operators.Interval(a_, b_, true, false);
		object d_ = context.ResolveParameter("AppropriateTreatmentforUpperRespiratoryInfectionURIFHIR-0.1.000", "Measurement Period", c_);

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

	private IEnumerable<Encounter> Qualifying_Encounters_Value()
	{
		CqlValueSet a_ = this.Emergency_Department_Evaluation_and_Management_Visit();
		IEnumerable<Encounter> b_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
		CqlValueSet c_ = this.Home_Healthcare_Services();
		IEnumerable<Encounter> d_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, c_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
		IEnumerable<Encounter> e_ = context.Operators.Union<Encounter>(b_, d_);
		CqlValueSet f_ = this.Initial_Hospital_Observation_Care();
		IEnumerable<Encounter> g_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, f_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
		CqlValueSet h_ = this.Medical_Disability_Exam();
		IEnumerable<Encounter> i_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, h_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
		IEnumerable<Encounter> j_ = context.Operators.Union<Encounter>(g_, i_);
		IEnumerable<Encounter> k_ = context.Operators.Union<Encounter>(e_, j_);
		CqlValueSet l_ = this.Observation();
		IEnumerable<Encounter> m_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, l_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
		CqlValueSet n_ = this.Office_Visit();
		IEnumerable<Encounter> o_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, n_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
		IEnumerable<Encounter> p_ = context.Operators.Union<Encounter>(m_, o_);
		IEnumerable<Encounter> q_ = context.Operators.Union<Encounter>(k_, p_);
		CqlValueSet r_ = this.Outpatient_Consultation();
		IEnumerable<Encounter> s_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, r_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
		CqlValueSet t_ = this.Preventive_Care_Services_Group_Counseling();
		IEnumerable<Encounter> u_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, t_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
		IEnumerable<Encounter> v_ = context.Operators.Union<Encounter>(s_, u_);
		IEnumerable<Encounter> w_ = context.Operators.Union<Encounter>(q_, v_);
		CqlValueSet x_ = this.Preventive_Care_Services_Individual_Counseling();
		IEnumerable<Encounter> y_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, x_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
		CqlValueSet z_ = this.Preventive_Care_Services__Initial_Office_Visit__0_to_17();
		IEnumerable<Encounter> aa_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, z_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
		IEnumerable<Encounter> ab_ = context.Operators.Union<Encounter>(y_, aa_);
		IEnumerable<Encounter> ac_ = context.Operators.Union<Encounter>(w_, ab_);
		CqlValueSet ad_ = this.Preventive_Care__Established_Office_Visit__0_to_17();
		IEnumerable<Encounter> ae_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, ad_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
		CqlValueSet af_ = this.Preventive_Care_Services_Established_Office_Visit__18_and_Up();
		IEnumerable<Encounter> ag_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, af_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
		IEnumerable<Encounter> ah_ = context.Operators.Union<Encounter>(ae_, ag_);
		IEnumerable<Encounter> ai_ = context.Operators.Union<Encounter>(ac_, ah_);
		CqlValueSet aj_ = this.Preventive_Care_Services_Initial_Office_Visit__18_and_Up();
		IEnumerable<Encounter> ak_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, aj_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
		CqlValueSet al_ = this.Telephone_Visits();
		IEnumerable<Encounter> am_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, al_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
		IEnumerable<Encounter> an_ = context.Operators.Union<Encounter>(ak_, am_);
		IEnumerable<Encounter> ao_ = context.Operators.Union<Encounter>(ai_, an_);
		CqlValueSet ap_ = this.Online_Assessments();
		IEnumerable<Encounter> aq_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, ap_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
		IEnumerable<Encounter> ar_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
		bool? as_(Encounter E)
		{
			List<CodeableConcept> az_ = E?.Type;
			CqlConcept ba_(CodeableConcept @this)
			{
				CqlConcept bf_ = FHIRHelpers_4_3_000.ToConcept(@this);

				return bf_;
			};
			IEnumerable<CqlConcept> bb_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)az_, ba_);
			bool? bc_(CqlConcept T)
			{
				CqlCode bg_ = this.Unlisted_preventive_medicine_service();
				CqlConcept bh_ = context.Operators.ConvertCodeToConcept(bg_);
				bool? bi_ = context.Operators.Equivalent(T, bh_);

				return bi_;
			};
			IEnumerable<CqlConcept> bd_ = context.Operators.Where<CqlConcept>(bb_, bc_);
			bool? be_ = context.Operators.Exists<CqlConcept>(bd_);

			return be_;
		};
		IEnumerable<Encounter> at_ = context.Operators.Where<Encounter>(ar_, as_);
		IEnumerable<Encounter> au_ = context.Operators.Union<Encounter>(aq_, at_);
		IEnumerable<Encounter> av_ = context.Operators.Union<Encounter>(ao_, au_);
		IEnumerable<Encounter> aw_ = Status_1_6_000.Finished_Encounter(av_);
		bool? ax_(Encounter ValidEncounter)
		{
			Period bj_ = ValidEncounter?.Period;
			CqlInterval<CqlDateTime> bk_ = FHIRHelpers_4_3_000.ToInterval(bj_);
			CqlInterval<CqlDateTime> bl_ = QICoreCommon_2_0_000.ToInterval(bk_ as object);
			CqlDateTime bm_ = context.Operators.End(bl_);
			CqlInterval<CqlDateTime> bn_ = this.Measurement_Period();
			CqlDateTime bo_ = context.Operators.Start(bn_);
			CqlDateTime bq_ = context.Operators.End(bn_);
			CqlQuantity br_ = context.Operators.Quantity(3m, "days");
			CqlDateTime bs_ = context.Operators.Subtract(bq_, br_);
			CqlInterval<CqlDateTime> bt_ = context.Operators.Interval(bo_, bs_, true, true);
			bool? bu_ = context.Operators.In<CqlDateTime>(bm_, bt_, "day");

			return bu_;
		};
		IEnumerable<Encounter> ay_ = context.Operators.Where<Encounter>(aw_, ax_);

		return ay_;
	}

    [CqlDeclaration("Qualifying Encounters")]
	public IEnumerable<Encounter> Qualifying_Encounters() => 
		__Qualifying_Encounters.Value;

	private IEnumerable<Encounter> Encounter_with_Upper_Respiratory_Infection_Value()
	{
		IEnumerable<Encounter> a_ = this.Qualifying_Encounters();
		CqlValueSet b_ = this.Upper_Respiratory_Infection();
		IEnumerable<Condition> c_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, b_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
		IEnumerable<ValueTuple<Encounter, Condition>> d_ = context.Operators.CrossJoin<Encounter, Condition>(a_, c_);
		(Encounter QualifyingEncounters, Condition URI)? e_(ValueTuple<Encounter, Condition> _valueTuple)
		{
			(Encounter QualifyingEncounters, Condition URI)? k_ = (_valueTuple.Item1, _valueTuple.Item2);

			return k_;
		};
		IEnumerable<(Encounter QualifyingEncounters, Condition URI)?> f_ = context.Operators.Select<ValueTuple<Encounter, Condition>, (Encounter QualifyingEncounters, Condition URI)?>(d_, e_);
		bool? g_((Encounter QualifyingEncounters, Condition URI)? tuple_figmirinmncaavfkbmahdktce)
		{
			CqlInterval<CqlDateTime> l_ = QICoreCommon_2_0_000.ToPrevalenceInterval(tuple_figmirinmncaavfkbmahdktce?.URI);
			CqlDateTime m_ = context.Operators.Start(l_);
			Period n_ = tuple_figmirinmncaavfkbmahdktce?.QualifyingEncounters?.Period;
			CqlInterval<CqlDateTime> o_ = FHIRHelpers_4_3_000.ToInterval(n_);
			CqlInterval<CqlDateTime> p_ = QICoreCommon_2_0_000.ToInterval(o_ as object);
			bool? q_ = context.Operators.In<CqlDateTime>(m_, p_, "day");
			CqlInterval<CqlDateTime> t_ = FHIRHelpers_4_3_000.ToInterval(n_);
			CqlInterval<CqlDateTime> u_ = QICoreCommon_2_0_000.ToInterval(t_ as object);
			bool? v_ = context.Operators.OverlapsBefore(l_, u_, default);
			bool? w_ = context.Operators.Or(q_, v_);

			return w_;
		};
		IEnumerable<(Encounter QualifyingEncounters, Condition URI)?> h_ = context.Operators.Where<(Encounter QualifyingEncounters, Condition URI)?>(f_, g_);
		Encounter i_((Encounter QualifyingEncounters, Condition URI)? tuple_figmirinmncaavfkbmahdktce) => 
			tuple_figmirinmncaavfkbmahdktce?.QualifyingEncounters;
		IEnumerable<Encounter> j_ = context.Operators.Select<(Encounter QualifyingEncounters, Condition URI)?, Encounter>(h_, i_);

		return j_;
	}

    [CqlDeclaration("Encounter with Upper Respiratory Infection")]
	public IEnumerable<Encounter> Encounter_with_Upper_Respiratory_Infection() => 
		__Encounter_with_Upper_Respiratory_Infection.Value;

	private IEnumerable<Encounter> Initial_Population_Value()
	{
		IEnumerable<Encounter> a_ = this.Encounter_with_Upper_Respiratory_Infection();
		bool? b_(Encounter EncounterWithURI)
		{
			Patient f_ = this.Patient();
			Date g_ = f_?.BirthDateElement;
			string h_ = g_?.Value;
			CqlDate i_ = context.Operators.ConvertStringToDate(h_);
			CqlInterval<CqlDateTime> j_ = this.Measurement_Period();
			CqlDateTime k_ = context.Operators.Start(j_);
			CqlDate l_ = context.Operators.DateFrom(k_);
			int? m_ = context.Operators.CalculateAgeAt(i_, l_, "month");
			bool? n_ = context.Operators.GreaterOrEqual(m_, 3);

			return n_;
		};
		IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);
		Encounter d_(Encounter EncounterWithURI) => 
			EncounterWithURI;
		IEnumerable<Encounter> e_ = context.Operators.Select<Encounter, Encounter>(c_, d_);

		return e_;
	}

    [CqlDeclaration("Initial Population")]
	public IEnumerable<Encounter> Initial_Population() => 
		__Initial_Population.Value;

	private IEnumerable<Encounter> Encounters_and_Assessments_with_Hospice_Patient_Value()
	{
		IEnumerable<Encounter> a_ = this.Initial_Population();
		bool? b_(Encounter EligibleEncounters)
		{
			bool? d_ = Hospice_6_9_000.Has_Hospice_Services();

			return d_;
		};
		IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);

		return c_;
	}

    [CqlDeclaration("Encounters and Assessments with Hospice Patient")]
	public IEnumerable<Encounter> Encounters_and_Assessments_with_Hospice_Patient() => 
		__Encounters_and_Assessments_with_Hospice_Patient.Value;

	private IEnumerable<Encounter> Denominator_Value()
	{
		IEnumerable<Encounter> a_ = this.Initial_Population();

		return a_;
	}

    [CqlDeclaration("Denominator")]
	public IEnumerable<Encounter> Denominator() => 
		__Denominator.Value;

	private IEnumerable<Encounter> Denominator_Exclusions_Value()
	{
		IEnumerable<Encounter> a_ = this.Encounters_and_Assessments_with_Hospice_Patient();
		IEnumerable<Encounter> b_ = this.Encounter_with_Upper_Respiratory_Infection();
		CqlValueSet c_ = this.Comorbid_Conditions_for_Respiratory_Conditions();
		IEnumerable<Condition> d_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, c_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
		IEnumerable<Encounter> e_ = Antibiotic_1_5_000.Has_Comorbid_Condition_History(b_, d_);
		IEnumerable<Encounter> f_ = context.Operators.Union<Encounter>(a_, e_);
		CqlValueSet h_ = this.Antibiotic_Medications_for_Upper_Respiratory_Infection();
		IEnumerable<MedicationRequest> i_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, h_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
		IEnumerable<MedicationRequest> k_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, h_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
		IEnumerable<MedicationRequest> l_ = context.Operators.Union<MedicationRequest>(i_, k_);
		IEnumerable<Encounter> m_ = Antibiotic_1_5_000.Has_Antibiotic_Medication_History(b_, l_);
		CqlValueSet o_ = this.Competing_Conditions_for_Respiratory_Conditions();
		IEnumerable<Condition> p_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, o_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
		IEnumerable<Encounter> q_ = Antibiotic_1_5_000.Has_Competing_Diagnosis_History(b_, p_);
		IEnumerable<Encounter> r_ = context.Operators.Union<Encounter>(m_, q_);
		IEnumerable<Encounter> s_ = context.Operators.Union<Encounter>(f_, r_);

		return s_;
	}

    [CqlDeclaration("Denominator Exclusions")]
	public IEnumerable<Encounter> Denominator_Exclusions() => 
		__Denominator_Exclusions.Value;

	private IEnumerable<Encounter> Numerator_Value()
	{
		IEnumerable<Encounter> a_ = this.Encounter_with_Upper_Respiratory_Infection();
		IEnumerable<Encounter> c_(Encounter EncounterWithURI)
		{
			CqlValueSet h_ = this.Antibiotic_Medications_for_Upper_Respiratory_Infection();
			IEnumerable<MedicationRequest> i_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, h_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
			IEnumerable<MedicationRequest> k_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, h_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
			IEnumerable<MedicationRequest> l_ = context.Operators.Union<MedicationRequest>(i_, k_);
			bool? m_(MedicationRequest OrderedAntibiotic)
			{
				FhirDateTime q_ = OrderedAntibiotic?.AuthoredOnElement;
				CqlDateTime r_ = context.Operators.Convert<CqlDateTime>(q_);
				Period s_ = EncounterWithURI?.Period;
				CqlInterval<CqlDateTime> t_ = FHIRHelpers_4_3_000.ToInterval(s_);
				CqlInterval<CqlDateTime> u_ = QICoreCommon_2_0_000.ToInterval(t_ as object);
				CqlDateTime v_ = context.Operators.Start(u_);
				CqlInterval<CqlDateTime> x_ = FHIRHelpers_4_3_000.ToInterval(s_);
				CqlInterval<CqlDateTime> y_ = QICoreCommon_2_0_000.ToInterval(x_ as object);
				CqlDateTime z_ = context.Operators.Start(y_);
				CqlQuantity aa_ = context.Operators.Quantity(3m, "days");
				CqlDateTime ab_ = context.Operators.Add(z_, aa_);
				CqlInterval<CqlDateTime> ac_ = context.Operators.Interval(v_, ab_, true, true);
				bool? ad_ = context.Operators.In<CqlDateTime>(r_, ac_, default);
				CqlInterval<CqlDateTime> af_ = FHIRHelpers_4_3_000.ToInterval(s_);
				CqlInterval<CqlDateTime> ag_ = QICoreCommon_2_0_000.ToInterval(af_ as object);
				CqlDateTime ah_ = context.Operators.Start(ag_);
				bool? ai_ = context.Operators.Not((bool?)(ah_ is null));
				bool? aj_ = context.Operators.And(ad_, ai_);

				return aj_;
			};
			IEnumerable<MedicationRequest> n_ = context.Operators.Where<MedicationRequest>(l_, m_);
			Encounter o_(MedicationRequest OrderedAntibiotic) => 
				EncounterWithURI;
			IEnumerable<Encounter> p_ = context.Operators.Select<MedicationRequest, Encounter>(n_, o_);

			return p_;
		};
		IEnumerable<Encounter> d_ = context.Operators.SelectMany<Encounter, Encounter>(a_, c_);
		IEnumerable<Encounter> e_ = context.Operators.Except<Encounter>(a_, d_);
		Encounter f_(Encounter EncounterWithURI) => 
			EncounterWithURI;
		IEnumerable<Encounter> g_ = context.Operators.Select<Encounter, Encounter>(e_, f_);

		return g_;
	}

    [CqlDeclaration("Numerator")]
	public IEnumerable<Encounter> Numerator() => 
		__Numerator.Value;

	private IEnumerable<Encounter> Stratification_1_Value()
	{
		IEnumerable<Encounter> a_ = this.Encounter_with_Upper_Respiratory_Infection();
		bool? b_(Encounter EncounterWithURI)
		{
			Patient f_ = this.Patient();
			Date g_ = f_?.BirthDateElement;
			string h_ = g_?.Value;
			CqlDate i_ = context.Operators.ConvertStringToDate(h_);
			CqlInterval<CqlDateTime> j_ = this.Measurement_Period();
			CqlDateTime k_ = context.Operators.Start(j_);
			CqlDate l_ = context.Operators.DateFrom(k_);
			int? m_ = context.Operators.CalculateAgeAt(i_, l_, "month");
			bool? n_ = context.Operators.GreaterOrEqual(m_, 3);
			Date p_ = f_?.BirthDateElement;
			string q_ = p_?.Value;
			CqlDate r_ = context.Operators.ConvertStringToDate(q_);
			CqlDateTime t_ = context.Operators.Start(j_);
			CqlDate u_ = context.Operators.DateFrom(t_);
			int? v_ = context.Operators.CalculateAgeAt(r_, u_, "year");
			bool? w_ = context.Operators.LessOrEqual(v_, 17);
			bool? x_ = context.Operators.And(n_, w_);

			return x_;
		};
		IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);
		Encounter d_(Encounter EncounterWithURI) => 
			EncounterWithURI;
		IEnumerable<Encounter> e_ = context.Operators.Select<Encounter, Encounter>(c_, d_);

		return e_;
	}

    [CqlDeclaration("Stratification 1")]
	public IEnumerable<Encounter> Stratification_1() => 
		__Stratification_1.Value;

	private IEnumerable<Encounter> Stratification_2_Value()
	{
		IEnumerable<Encounter> a_ = this.Encounter_with_Upper_Respiratory_Infection();
		bool? b_(Encounter EncounterWithURI)
		{
			Patient f_ = this.Patient();
			Date g_ = f_?.BirthDateElement;
			string h_ = g_?.Value;
			CqlDate i_ = context.Operators.ConvertStringToDate(h_);
			CqlInterval<CqlDateTime> j_ = this.Measurement_Period();
			CqlDateTime k_ = context.Operators.Start(j_);
			CqlDate l_ = context.Operators.DateFrom(k_);
			int? m_ = context.Operators.CalculateAgeAt(i_, l_, "year");
			CqlInterval<int?> n_ = context.Operators.Interval(18, 64, true, true);
			bool? o_ = context.Operators.In<int?>(m_, n_, default);

			return o_;
		};
		IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);
		Encounter d_(Encounter EncounterWithURI) => 
			EncounterWithURI;
		IEnumerable<Encounter> e_ = context.Operators.Select<Encounter, Encounter>(c_, d_);

		return e_;
	}

    [CqlDeclaration("Stratification 2")]
	public IEnumerable<Encounter> Stratification_2() => 
		__Stratification_2.Value;

	private IEnumerable<Encounter> Stratification_3_Value()
	{
		IEnumerable<Encounter> a_ = this.Encounter_with_Upper_Respiratory_Infection();
		bool? b_(Encounter EncounterWithURI)
		{
			Patient f_ = this.Patient();
			Date g_ = f_?.BirthDateElement;
			string h_ = g_?.Value;
			CqlDate i_ = context.Operators.ConvertStringToDate(h_);
			CqlInterval<CqlDateTime> j_ = this.Measurement_Period();
			CqlDateTime k_ = context.Operators.Start(j_);
			CqlDate l_ = context.Operators.DateFrom(k_);
			int? m_ = context.Operators.CalculateAgeAt(i_, l_, "year");
			bool? n_ = context.Operators.GreaterOrEqual(m_, 65);

			return n_;
		};
		IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);
		Encounter d_(Encounter EncounterWithURI) => 
			EncounterWithURI;
		IEnumerable<Encounter> e_ = context.Operators.Select<Encounter, Encounter>(c_, d_);

		return e_;
	}

    [CqlDeclaration("Stratification 3")]
	public IEnumerable<Encounter> Stratification_3() => 
		__Stratification_3.Value;

}
