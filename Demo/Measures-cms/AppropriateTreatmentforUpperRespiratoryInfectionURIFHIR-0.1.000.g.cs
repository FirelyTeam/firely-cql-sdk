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
		CqlCode[] a_ = new CqlCode[]
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
		IEnumerable<Patient> a_ = context.Operators.RetrieveByValueSet<Patient>(null, null);
		Patient b_ = context.Operators.SingletonFrom<Patient>(a_);

		return b_;
	}

    [CqlDeclaration("Patient")]
	public Patient Patient() => 
		__Patient.Value;

	private Tuple_DMgHTLENEHBHWJISQgKZGZVMB SDE_Ethnicity_Value()
	{
		Tuple_DMgHTLENEHBHWJISQgKZGZVMB a_ = SupplementalDataElements_3_4_000.SDE_Ethnicity();

		return a_;
	}

    [CqlDeclaration("SDE Ethnicity")]
	public Tuple_DMgHTLENEHBHWJISQgKZGZVMB SDE_Ethnicity() => 
		__SDE_Ethnicity.Value;

	private IEnumerable<Tuple_GDKRbfOIHhLGieQSVDEMIaDPX> SDE_Payer_Value()
	{
		IEnumerable<Tuple_GDKRbfOIHhLGieQSVDEMIaDPX> a_ = SupplementalDataElements_3_4_000.SDE_Payer();

		return a_;
	}

    [CqlDeclaration("SDE Payer")]
	public IEnumerable<Tuple_GDKRbfOIHhLGieQSVDEMIaDPX> SDE_Payer() => 
		__SDE_Payer.Value;

	private Tuple_DMgHTLENEHBHWJISQgKZGZVMB SDE_Race_Value()
	{
		Tuple_DMgHTLENEHBHWJISQgKZGZVMB a_ = SupplementalDataElements_3_4_000.SDE_Race();

		return a_;
	}

    [CqlDeclaration("SDE Race")]
	public Tuple_DMgHTLENEHBHWJISQgKZGZVMB SDE_Race() => 
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
		IEnumerable<Encounter> b_ = context.Operators.RetrieveByValueSet<Encounter>(a_, null);
		CqlValueSet c_ = this.Home_Healthcare_Services();
		IEnumerable<Encounter> d_ = context.Operators.RetrieveByValueSet<Encounter>(c_, null);
		IEnumerable<Encounter> e_ = context.Operators.ListUnion<Encounter>(b_, d_);
		CqlValueSet f_ = this.Initial_Hospital_Observation_Care();
		IEnumerable<Encounter> g_ = context.Operators.RetrieveByValueSet<Encounter>(f_, null);
		CqlValueSet h_ = this.Medical_Disability_Exam();
		IEnumerable<Encounter> i_ = context.Operators.RetrieveByValueSet<Encounter>(h_, null);
		IEnumerable<Encounter> j_ = context.Operators.ListUnion<Encounter>(g_, i_);
		IEnumerable<Encounter> k_ = context.Operators.ListUnion<Encounter>(e_, j_);
		CqlValueSet l_ = this.Observation();
		IEnumerable<Encounter> m_ = context.Operators.RetrieveByValueSet<Encounter>(l_, null);
		CqlValueSet n_ = this.Office_Visit();
		IEnumerable<Encounter> o_ = context.Operators.RetrieveByValueSet<Encounter>(n_, null);
		IEnumerable<Encounter> p_ = context.Operators.ListUnion<Encounter>(m_, o_);
		IEnumerable<Encounter> q_ = context.Operators.ListUnion<Encounter>(k_, p_);
		CqlValueSet r_ = this.Outpatient_Consultation();
		IEnumerable<Encounter> s_ = context.Operators.RetrieveByValueSet<Encounter>(r_, null);
		CqlValueSet t_ = this.Preventive_Care_Services_Group_Counseling();
		IEnumerable<Encounter> u_ = context.Operators.RetrieveByValueSet<Encounter>(t_, null);
		IEnumerable<Encounter> v_ = context.Operators.ListUnion<Encounter>(s_, u_);
		IEnumerable<Encounter> w_ = context.Operators.ListUnion<Encounter>(q_, v_);
		CqlValueSet x_ = this.Preventive_Care_Services_Individual_Counseling();
		IEnumerable<Encounter> y_ = context.Operators.RetrieveByValueSet<Encounter>(x_, null);
		CqlValueSet z_ = this.Preventive_Care_Services__Initial_Office_Visit__0_to_17();
		IEnumerable<Encounter> aa_ = context.Operators.RetrieveByValueSet<Encounter>(z_, null);
		IEnumerable<Encounter> ab_ = context.Operators.ListUnion<Encounter>(y_, aa_);
		IEnumerable<Encounter> ac_ = context.Operators.ListUnion<Encounter>(w_, ab_);
		CqlValueSet ad_ = this.Preventive_Care__Established_Office_Visit__0_to_17();
		IEnumerable<Encounter> ae_ = context.Operators.RetrieveByValueSet<Encounter>(ad_, null);
		CqlValueSet af_ = this.Preventive_Care_Services_Established_Office_Visit__18_and_Up();
		IEnumerable<Encounter> ag_ = context.Operators.RetrieveByValueSet<Encounter>(af_, null);
		IEnumerable<Encounter> ah_ = context.Operators.ListUnion<Encounter>(ae_, ag_);
		IEnumerable<Encounter> ai_ = context.Operators.ListUnion<Encounter>(ac_, ah_);
		CqlValueSet aj_ = this.Preventive_Care_Services_Initial_Office_Visit__18_and_Up();
		IEnumerable<Encounter> ak_ = context.Operators.RetrieveByValueSet<Encounter>(aj_, null);
		CqlValueSet al_ = this.Telephone_Visits();
		IEnumerable<Encounter> am_ = context.Operators.RetrieveByValueSet<Encounter>(al_, null);
		IEnumerable<Encounter> an_ = context.Operators.ListUnion<Encounter>(ak_, am_);
		IEnumerable<Encounter> ao_ = context.Operators.ListUnion<Encounter>(ai_, an_);
		CqlValueSet ap_ = this.Online_Assessments();
		IEnumerable<Encounter> aq_ = context.Operators.RetrieveByValueSet<Encounter>(ap_, null);
		IEnumerable<Encounter> ar_ = context.Operators.RetrieveByValueSet<Encounter>(null, null);
		bool? as_(Encounter E)
		{
			CqlConcept az_(CodeableConcept @this)
			{
				CqlConcept be_ = FHIRHelpers_4_3_000.ToConcept(@this);

				return be_;
			};
			IEnumerable<CqlConcept> ba_ = context.Operators.Select<CodeableConcept, CqlConcept>(E?.Type, az_);
			bool? bb_(CqlConcept T)
			{
				CqlCode bf_ = this.Unlisted_preventive_medicine_service();
				CqlConcept bg_ = context.Operators.ConvertCodeToConcept(bf_);
				bool? bh_ = context.Operators.Equivalent(T, bg_);

				return bh_;
			};
			IEnumerable<CqlConcept> bc_ = context.Operators.Where<CqlConcept>(ba_, bb_);
			bool? bd_ = context.Operators.Exists<CqlConcept>(bc_);

			return bd_;
		};
		IEnumerable<Encounter> at_ = context.Operators.Where<Encounter>(ar_, as_);
		IEnumerable<Encounter> au_ = context.Operators.ListUnion<Encounter>(aq_, at_);
		IEnumerable<Encounter> av_ = context.Operators.ListUnion<Encounter>(ao_, au_);
		IEnumerable<Encounter> aw_ = Status_1_6_000.Finished_Encounter(av_);
		bool? ax_(Encounter ValidEncounter)
		{
			CqlInterval<CqlDateTime> bi_ = FHIRHelpers_4_3_000.ToInterval(ValidEncounter?.Period);
			CqlInterval<CqlDateTime> bj_ = QICoreCommon_2_0_000.ToInterval((bi_ as object));
			CqlDateTime bk_ = context.Operators.End(bj_);
			CqlInterval<CqlDateTime> bl_ = this.Measurement_Period();
			CqlDateTime bm_ = context.Operators.Start(bl_);
			CqlDateTime bo_ = context.Operators.End(bl_);
			CqlQuantity bp_ = context.Operators.Quantity(3m, "days");
			CqlDateTime bq_ = context.Operators.Subtract(bo_, bp_);
			CqlInterval<CqlDateTime> br_ = context.Operators.Interval(bm_, bq_, true, true);
			bool? bs_ = context.Operators.In<CqlDateTime>(bk_, br_, "day");

			return bs_;
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
		IEnumerable<Condition> c_ = context.Operators.RetrieveByValueSet<Condition>(b_, null);
		IEnumerable<ValueTuple<Encounter,Condition>> d_ = context.Operators.CrossJoin<Encounter, Condition>(a_, c_);
		Tuple_CLQRPFFCjgiFZUVDVEDIIKeXW e_(ValueTuple<Encounter,Condition> _valueTuple)
		{
			Tuple_CLQRPFFCjgiFZUVDVEDIIKeXW k_ = new Tuple_CLQRPFFCjgiFZUVDVEDIIKeXW
			{
				QualifyingEncounters = _valueTuple.Item1,
				URI = _valueTuple.Item2,
			};

			return k_;
		};
		IEnumerable<Tuple_CLQRPFFCjgiFZUVDVEDIIKeXW> f_ = context.Operators.Select<ValueTuple<Encounter,Condition>, Tuple_CLQRPFFCjgiFZUVDVEDIIKeXW>(d_, e_);
		bool? g_(Tuple_CLQRPFFCjgiFZUVDVEDIIKeXW tuple_clqrpffcjgifzuvdvediikexw)
		{
			CqlInterval<CqlDateTime> l_ = QICoreCommon_2_0_000.ToPrevalenceInterval(tuple_clqrpffcjgifzuvdvediikexw.URI);
			CqlDateTime m_ = context.Operators.Start(l_);
			CqlInterval<CqlDateTime> n_ = FHIRHelpers_4_3_000.ToInterval(tuple_clqrpffcjgifzuvdvediikexw.QualifyingEncounters?.Period);
			CqlInterval<CqlDateTime> o_ = QICoreCommon_2_0_000.ToInterval((n_ as object));
			bool? p_ = context.Operators.In<CqlDateTime>(m_, o_, "day");
			CqlInterval<CqlDateTime> s_ = QICoreCommon_2_0_000.ToInterval((n_ as object));
			bool? t_ = context.Operators.OverlapsBefore(l_, s_, null);
			bool? u_ = context.Operators.Or(p_, t_);

			return u_;
		};
		IEnumerable<Tuple_CLQRPFFCjgiFZUVDVEDIIKeXW> h_ = context.Operators.Where<Tuple_CLQRPFFCjgiFZUVDVEDIIKeXW>(f_, g_);
		Encounter i_(Tuple_CLQRPFFCjgiFZUVDVEDIIKeXW tuple_clqrpffcjgifzuvdvediikexw) => 
			tuple_clqrpffcjgifzuvdvediikexw.QualifyingEncounters;
		IEnumerable<Encounter> j_ = context.Operators.Select<Tuple_CLQRPFFCjgiFZUVDVEDIIKeXW, Encounter>(h_, i_);

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
			CqlDate g_ = context.Operators.Convert<CqlDate>(f_?.BirthDateElement?.Value);
			CqlInterval<CqlDateTime> h_ = this.Measurement_Period();
			CqlDateTime i_ = context.Operators.Start(h_);
			CqlDate j_ = context.Operators.DateFrom(i_);
			int? k_ = context.Operators.CalculateAgeAt(g_, j_, "month");
			bool? l_ = context.Operators.GreaterOrEqual(k_, 3);

			return l_;
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
		IEnumerable<Condition> d_ = context.Operators.RetrieveByValueSet<Condition>(c_, null);
		IEnumerable<Encounter> e_ = Antibiotic_1_5_000.Has_Comorbid_Condition_History(b_, d_);
		IEnumerable<Encounter> f_ = context.Operators.ListUnion<Encounter>(a_, e_);
		CqlValueSet h_ = this.Antibiotic_Medications_for_Upper_Respiratory_Infection();
		IEnumerable<MedicationRequest> i_ = context.Operators.RetrieveByValueSet<MedicationRequest>(h_, null);
		IEnumerable<MedicationRequest> k_ = context.Operators.RetrieveByValueSet<MedicationRequest>(h_, null);
		IEnumerable<MedicationRequest> l_ = context.Operators.ListUnion<MedicationRequest>(i_, k_);
		IEnumerable<Encounter> m_ = Antibiotic_1_5_000.Has_Antibiotic_Medication_History(b_, l_);
		CqlValueSet o_ = this.Competing_Conditions_for_Respiratory_Conditions();
		IEnumerable<Condition> p_ = context.Operators.RetrieveByValueSet<Condition>(o_, null);
		IEnumerable<Encounter> q_ = Antibiotic_1_5_000.Has_Competing_Diagnosis_History(b_, p_);
		IEnumerable<Encounter> r_ = context.Operators.ListUnion<Encounter>(m_, q_);
		IEnumerable<Encounter> s_ = context.Operators.ListUnion<Encounter>(f_, r_);

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
			IEnumerable<MedicationRequest> i_ = context.Operators.RetrieveByValueSet<MedicationRequest>(h_, null);
			IEnumerable<MedicationRequest> k_ = context.Operators.RetrieveByValueSet<MedicationRequest>(h_, null);
			IEnumerable<MedicationRequest> l_ = context.Operators.ListUnion<MedicationRequest>(i_, k_);
			bool? m_(MedicationRequest OrderedAntibiotic)
			{
				CqlDateTime q_ = context.Operators.Convert<CqlDateTime>(OrderedAntibiotic?.AuthoredOnElement);
				CqlInterval<CqlDateTime> r_ = FHIRHelpers_4_3_000.ToInterval(EncounterWithURI?.Period);
				CqlInterval<CqlDateTime> s_ = QICoreCommon_2_0_000.ToInterval((r_ as object));
				CqlDateTime t_ = context.Operators.Start(s_);
				CqlInterval<CqlDateTime> v_ = QICoreCommon_2_0_000.ToInterval((r_ as object));
				CqlDateTime w_ = context.Operators.Start(v_);
				CqlQuantity x_ = context.Operators.Quantity(3m, "days");
				CqlDateTime y_ = context.Operators.Add(w_, x_);
				CqlInterval<CqlDateTime> z_ = context.Operators.Interval(t_, y_, true, true);
				bool? aa_ = context.Operators.In<CqlDateTime>(q_, z_, null);
				CqlInterval<CqlDateTime> ac_ = QICoreCommon_2_0_000.ToInterval((r_ as object));
				CqlDateTime ad_ = context.Operators.Start(ac_);
				bool? ae_ = context.Operators.Not((bool?)(ad_ is null));
				bool? af_ = context.Operators.And(aa_, ae_);

				return af_;
			};
			IEnumerable<MedicationRequest> n_ = context.Operators.Where<MedicationRequest>(l_, m_);
			Encounter o_(MedicationRequest OrderedAntibiotic) => 
				EncounterWithURI;
			IEnumerable<Encounter> p_ = context.Operators.Select<MedicationRequest, Encounter>(n_, o_);

			return p_;
		};
		IEnumerable<Encounter> d_ = context.Operators.SelectMany<Encounter, Encounter>(a_, c_);
		IEnumerable<Encounter> e_ = context.Operators.ListExcept<Encounter>(a_, d_);
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
			CqlDate g_ = context.Operators.Convert<CqlDate>(f_?.BirthDateElement?.Value);
			CqlInterval<CqlDateTime> h_ = this.Measurement_Period();
			CqlDateTime i_ = context.Operators.Start(h_);
			CqlDate j_ = context.Operators.DateFrom(i_);
			int? k_ = context.Operators.CalculateAgeAt(g_, j_, "month");
			bool? l_ = context.Operators.GreaterOrEqual(k_, 3);
			CqlDate n_ = context.Operators.Convert<CqlDate>(f_?.BirthDateElement?.Value);
			CqlDateTime p_ = context.Operators.Start(h_);
			CqlDate q_ = context.Operators.DateFrom(p_);
			int? r_ = context.Operators.CalculateAgeAt(n_, q_, "year");
			bool? s_ = context.Operators.LessOrEqual(r_, 17);
			bool? t_ = context.Operators.And(l_, s_);

			return t_;
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
			CqlDate g_ = context.Operators.Convert<CqlDate>(f_?.BirthDateElement?.Value);
			CqlInterval<CqlDateTime> h_ = this.Measurement_Period();
			CqlDateTime i_ = context.Operators.Start(h_);
			CqlDate j_ = context.Operators.DateFrom(i_);
			int? k_ = context.Operators.CalculateAgeAt(g_, j_, "year");
			CqlInterval<int?> l_ = context.Operators.Interval(18, 64, true, true);
			bool? m_ = context.Operators.In<int?>(k_, l_, null);

			return m_;
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
			CqlDate g_ = context.Operators.Convert<CqlDate>(f_?.BirthDateElement?.Value);
			CqlInterval<CqlDateTime> h_ = this.Measurement_Period();
			CqlDateTime i_ = context.Operators.Start(h_);
			CqlDate j_ = context.Operators.DateFrom(i_);
			int? k_ = context.Operators.CalculateAgeAt(g_, j_, "year");
			bool? l_ = context.Operators.GreaterOrEqual(k_, 65);

			return l_;
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
