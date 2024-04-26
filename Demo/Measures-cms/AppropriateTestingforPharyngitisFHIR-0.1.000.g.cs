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
[CqlLibrary("AppropriateTestingforPharyngitisFHIR", "0.1.000")]
public class AppropriateTestingforPharyngitisFHIR_0_1_000
{


    internal CqlContext context;

    #region Cached values

    internal Lazy<CqlValueSet> __Acute_Pharyngitis;
    internal Lazy<CqlValueSet> __Acute_Tonsillitis;
    internal Lazy<CqlValueSet> __Antibiotic_Medications_for_Pharyngitis;
    internal Lazy<CqlValueSet> __Comorbid_Conditions_for_Respiratory_Conditions;
    internal Lazy<CqlValueSet> __Competing_Conditions_for_Respiratory_Conditions;
    internal Lazy<CqlValueSet> __Discharge_Services_Observation_Care;
    internal Lazy<CqlValueSet> __Emergency_Department_Visit;
    internal Lazy<CqlValueSet> __Group_A_Streptococcus_Test;
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
    internal Lazy<CqlCode> __Observation_care_discharge_day_management__This_code_is_to_be_utilized_to_report_all_services_provided_to_a_patient_on_discharge_from_outpatient_hospital_observation_status_if_the_discharge_is_on_other_than_the_initial_date_of_observation_status__To_report_services_to_a_patient_designated_as_observation_status_or_inpatient_status_and_discharged_on_the_same_date__use_the_codes_for_Observation_or_Inpatient_Care_Services__including_Admission_and_Discharge_Services__99234_99236_as_appropriate___;
    internal Lazy<CqlCode> __Unlisted_preventive_medicine_service;
    internal Lazy<CqlCode[]> __CPT;
    internal Lazy<CqlInterval<CqlDateTime>> __Measurement_Period;
    internal Lazy<Patient> __Patient;
    internal Lazy<Tuple_DMgHTLENEHBHWJISQgKZGZVMB> __SDE_Ethnicity;
    internal Lazy<IEnumerable<Tuple_GDKRbfOIHhLGieQSVDEMIaDPX>> __SDE_Payer;
    internal Lazy<Tuple_DMgHTLENEHBHWJISQgKZGZVMB> __SDE_Race;
    internal Lazy<CqlCode> __SDE_Sex;
    internal Lazy<IEnumerable<Encounter>> __Qualifying_Encounter;
    internal Lazy<IEnumerable<Encounter>> __Encounter_With_Antibiotic_Ordered_Within_Three_Days;
    internal Lazy<IEnumerable<Condition>> __Pharyngitis_or_Tonsillitis;
    internal Lazy<IEnumerable<Encounter>> __Encounter_With_Pharyngitis_or_Tonsillitis_With_Antibiotic;
    internal Lazy<IEnumerable<Encounter>> __Initial_Population;
    internal Lazy<IEnumerable<Encounter>> __Denominator;
    internal Lazy<IEnumerable<Encounter>> __In_Hospice;
    internal Lazy<IEnumerable<Encounter>> __Denominator_Exclusions;
    internal Lazy<IEnumerable<Observation>> __Group_A_Streptococcus_Lab_Test_With_Result;
    internal Lazy<IEnumerable<Encounter>> __Numerator;
    internal Lazy<IEnumerable<Encounter>> __Stratification_1;
    internal Lazy<IEnumerable<Encounter>> __Stratification_2;
    internal Lazy<IEnumerable<Encounter>> __Stratification_3;

    #endregion
    public AppropriateTestingforPharyngitisFHIR_0_1_000(CqlContext context)
    {
        this.context = context ?? throw new ArgumentNullException("context");

        FHIRHelpers_4_3_000 = new FHIRHelpers_4_3_000(context);
        SupplementalDataElements_3_4_000 = new SupplementalDataElements_3_4_000(context);
        CQMCommon_2_0_000 = new CQMCommon_2_0_000(context);
        Hospice_6_9_000 = new Hospice_6_9_000(context);
        Antibiotic_1_5_000 = new Antibiotic_1_5_000(context);
        Status_1_6_000 = new Status_1_6_000(context);
        QICoreCommon_2_0_000 = new QICoreCommon_2_0_000(context);

        __Acute_Pharyngitis = new Lazy<CqlValueSet>(this.Acute_Pharyngitis_Value);
        __Acute_Tonsillitis = new Lazy<CqlValueSet>(this.Acute_Tonsillitis_Value);
        __Antibiotic_Medications_for_Pharyngitis = new Lazy<CqlValueSet>(this.Antibiotic_Medications_for_Pharyngitis_Value);
        __Comorbid_Conditions_for_Respiratory_Conditions = new Lazy<CqlValueSet>(this.Comorbid_Conditions_for_Respiratory_Conditions_Value);
        __Competing_Conditions_for_Respiratory_Conditions = new Lazy<CqlValueSet>(this.Competing_Conditions_for_Respiratory_Conditions_Value);
        __Discharge_Services_Observation_Care = new Lazy<CqlValueSet>(this.Discharge_Services_Observation_Care_Value);
        __Emergency_Department_Visit = new Lazy<CqlValueSet>(this.Emergency_Department_Visit_Value);
        __Group_A_Streptococcus_Test = new Lazy<CqlValueSet>(this.Group_A_Streptococcus_Test_Value);
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
        __Observation_care_discharge_day_management__This_code_is_to_be_utilized_to_report_all_services_provided_to_a_patient_on_discharge_from_outpatient_hospital_observation_status_if_the_discharge_is_on_other_than_the_initial_date_of_observation_status__To_report_services_to_a_patient_designated_as_observation_status_or_inpatient_status_and_discharged_on_the_same_date__use_the_codes_for_Observation_or_Inpatient_Care_Services__including_Admission_and_Discharge_Services__99234_99236_as_appropriate___ = new Lazy<CqlCode>(this.Observation_care_discharge_day_management__This_code_is_to_be_utilized_to_report_all_services_provided_to_a_patient_on_discharge_from_outpatient_hospital_observation_status_if_the_discharge_is_on_other_than_the_initial_date_of_observation_status__To_report_services_to_a_patient_designated_as_observation_status_or_inpatient_status_and_discharged_on_the_same_date__use_the_codes_for_Observation_or_Inpatient_Care_Services__including_Admission_and_Discharge_Services__99234_99236_as_appropriate____Value);
        __Unlisted_preventive_medicine_service = new Lazy<CqlCode>(this.Unlisted_preventive_medicine_service_Value);
        __CPT = new Lazy<CqlCode[]>(this.CPT_Value);
        __Measurement_Period = new Lazy<CqlInterval<CqlDateTime>>(this.Measurement_Period_Value);
        __Patient = new Lazy<Patient>(this.Patient_Value);
        __SDE_Ethnicity = new Lazy<Tuple_DMgHTLENEHBHWJISQgKZGZVMB>(this.SDE_Ethnicity_Value);
        __SDE_Payer = new Lazy<IEnumerable<Tuple_GDKRbfOIHhLGieQSVDEMIaDPX>>(this.SDE_Payer_Value);
        __SDE_Race = new Lazy<Tuple_DMgHTLENEHBHWJISQgKZGZVMB>(this.SDE_Race_Value);
        __SDE_Sex = new Lazy<CqlCode>(this.SDE_Sex_Value);
        __Qualifying_Encounter = new Lazy<IEnumerable<Encounter>>(this.Qualifying_Encounter_Value);
        __Encounter_With_Antibiotic_Ordered_Within_Three_Days = new Lazy<IEnumerable<Encounter>>(this.Encounter_With_Antibiotic_Ordered_Within_Three_Days_Value);
        __Pharyngitis_or_Tonsillitis = new Lazy<IEnumerable<Condition>>(this.Pharyngitis_or_Tonsillitis_Value);
        __Encounter_With_Pharyngitis_or_Tonsillitis_With_Antibiotic = new Lazy<IEnumerable<Encounter>>(this.Encounter_With_Pharyngitis_or_Tonsillitis_With_Antibiotic_Value);
        __Initial_Population = new Lazy<IEnumerable<Encounter>>(this.Initial_Population_Value);
        __Denominator = new Lazy<IEnumerable<Encounter>>(this.Denominator_Value);
        __In_Hospice = new Lazy<IEnumerable<Encounter>>(this.In_Hospice_Value);
        __Denominator_Exclusions = new Lazy<IEnumerable<Encounter>>(this.Denominator_Exclusions_Value);
        __Group_A_Streptococcus_Lab_Test_With_Result = new Lazy<IEnumerable<Observation>>(this.Group_A_Streptococcus_Lab_Test_With_Result_Value);
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
    public Antibiotic_1_5_000 Antibiotic_1_5_000 { get; }
    public Status_1_6_000 Status_1_6_000 { get; }
    public QICoreCommon_2_0_000 QICoreCommon_2_0_000 { get; }

    #endregion

	private CqlValueSet Acute_Pharyngitis_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.102.12.1011", null);

    [CqlDeclaration("Acute Pharyngitis")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.102.12.1011")]
	public CqlValueSet Acute_Pharyngitis() => 
		__Acute_Pharyngitis.Value;

	private CqlValueSet Acute_Tonsillitis_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.102.12.1012", null);

    [CqlDeclaration("Acute Tonsillitis")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.102.12.1012")]
	public CqlValueSet Acute_Tonsillitis() => 
		__Acute_Tonsillitis.Value;

	private CqlValueSet Antibiotic_Medications_for_Pharyngitis_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.196.12.1001", null);

    [CqlDeclaration("Antibiotic Medications for Pharyngitis")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.196.12.1001")]
	public CqlValueSet Antibiotic_Medications_for_Pharyngitis() => 
		__Antibiotic_Medications_for_Pharyngitis.Value;

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

	private CqlValueSet Discharge_Services_Observation_Care_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1039", null);

    [CqlDeclaration("Discharge Services Observation Care")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1039")]
	public CqlValueSet Discharge_Services_Observation_Care() => 
		__Discharge_Services_Observation_Care.Value;

	private CqlValueSet Emergency_Department_Visit_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1010", null);

    [CqlDeclaration("Emergency Department Visit")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1010")]
	public CqlValueSet Emergency_Department_Visit() => 
		__Emergency_Department_Visit.Value;

	private CqlValueSet Group_A_Streptococcus_Test_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.198.12.1012", null);

    [CqlDeclaration("Group A Streptococcus Test")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.198.12.1012")]
	public CqlValueSet Group_A_Streptococcus_Test() => 
		__Group_A_Streptococcus_Test.Value;

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

	private CqlCode Observation_care_discharge_day_management__This_code_is_to_be_utilized_to_report_all_services_provided_to_a_patient_on_discharge_from_outpatient_hospital_observation_status_if_the_discharge_is_on_other_than_the_initial_date_of_observation_status__To_report_services_to_a_patient_designated_as_observation_status_or_inpatient_status_and_discharged_on_the_same_date__use_the_codes_for_Observation_or_Inpatient_Care_Services__including_Admission_and_Discharge_Services__99234_99236_as_appropriate____Value() => 
		new CqlCode("99217", "http://www.ama-assn.org/go/cpt", null, null);

    [CqlDeclaration("Observation care discharge day management (This code is to be utilized to report all services provided to a patient on discharge from outpatient hospital observation status if the discharge is on other than the initial date of observation status. To report services to a patient designated as observation status or inpatient status and discharged on the same date, use the codes for Observation or Inpatient Care Services [including Admission and Discharge Services, 99234-99236 as appropriate.])")]
	public CqlCode Observation_care_discharge_day_management__This_code_is_to_be_utilized_to_report_all_services_provided_to_a_patient_on_discharge_from_outpatient_hospital_observation_status_if_the_discharge_is_on_other_than_the_initial_date_of_observation_status__To_report_services_to_a_patient_designated_as_observation_status_or_inpatient_status_and_discharged_on_the_same_date__use_the_codes_for_Observation_or_Inpatient_Care_Services__including_Admission_and_Discharge_Services__99234_99236_as_appropriate___() => 
		__Observation_care_discharge_day_management__This_code_is_to_be_utilized_to_report_all_services_provided_to_a_patient_on_discharge_from_outpatient_hospital_observation_status_if_the_discharge_is_on_other_than_the_initial_date_of_observation_status__To_report_services_to_a_patient_designated_as_observation_status_or_inpatient_status_and_discharged_on_the_same_date__use_the_codes_for_Observation_or_Inpatient_Care_Services__including_Admission_and_Discharge_Services__99234_99236_as_appropriate___.Value;

	private CqlCode Unlisted_preventive_medicine_service_Value() => 
		new CqlCode("99429", "http://www.ama-assn.org/go/cpt", null, null);

    [CqlDeclaration("Unlisted preventive medicine service")]
	public CqlCode Unlisted_preventive_medicine_service() => 
		__Unlisted_preventive_medicine_service.Value;

	private CqlCode[] CPT_Value()
	{
		CqlCode[] a_ = new CqlCode[]
		{
			new CqlCode("99217", "http://www.ama-assn.org/go/cpt", null, null),
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
		object d_ = context.ResolveParameter("AppropriateTestingforPharyngitisFHIR-0.1.000", "Measurement Period", c_);

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

	private IEnumerable<Encounter> Qualifying_Encounter_Value()
	{
		CqlValueSet a_ = this.Emergency_Department_Visit();
		IEnumerable<Encounter> b_ = context.Operators.RetrieveByValueSet<Encounter>(a_, null);
		IEnumerable<Encounter> c_ = context.Operators.RetrieveByValueSet<Encounter>(null, null);
		bool? d_(Encounter E)
		{
			CqlConcept bg_(CodeableConcept @this)
			{
				CqlConcept bl_ = FHIRHelpers_4_3_000.ToConcept(@this);

				return bl_;
			};
			IEnumerable<CqlConcept> bh_ = context.Operators.Select<CodeableConcept, CqlConcept>(E?.Type, bg_);
			bool? bi_(CqlConcept T)
			{
				CqlCode bm_ = this.Observation_care_discharge_day_management__This_code_is_to_be_utilized_to_report_all_services_provided_to_a_patient_on_discharge_from_outpatient_hospital_observation_status_if_the_discharge_is_on_other_than_the_initial_date_of_observation_status__To_report_services_to_a_patient_designated_as_observation_status_or_inpatient_status_and_discharged_on_the_same_date__use_the_codes_for_Observation_or_Inpatient_Care_Services__including_Admission_and_Discharge_Services__99234_99236_as_appropriate___();
				CqlConcept bn_ = context.Operators.ConvertCodeToConcept(bm_);
				bool? bo_ = context.Operators.Equivalent(T, bn_);

				return bo_;
			};
			IEnumerable<CqlConcept> bj_ = context.Operators.Where<CqlConcept>(bh_, bi_);
			bool? bk_ = context.Operators.Exists<CqlConcept>(bj_);

			return bk_;
		};
		IEnumerable<Encounter> e_ = context.Operators.Where<Encounter>(c_, d_);
		IEnumerable<Encounter> f_ = context.Operators.ListUnion<Encounter>(b_, e_);
		IEnumerable<Encounter> h_ = context.Operators.RetrieveByValueSet<Encounter>(a_, null);
		CqlValueSet i_ = this.Home_Healthcare_Services();
		IEnumerable<Encounter> j_ = context.Operators.RetrieveByValueSet<Encounter>(i_, null);
		IEnumerable<Encounter> k_ = context.Operators.ListUnion<Encounter>(h_, j_);
		IEnumerable<Encounter> l_ = context.Operators.ListUnion<Encounter>(f_, k_);
		CqlValueSet m_ = this.Initial_Hospital_Observation_Care();
		IEnumerable<Encounter> n_ = context.Operators.RetrieveByValueSet<Encounter>(m_, null);
		CqlValueSet o_ = this.Medical_Disability_Exam();
		IEnumerable<Encounter> p_ = context.Operators.RetrieveByValueSet<Encounter>(o_, null);
		IEnumerable<Encounter> q_ = context.Operators.ListUnion<Encounter>(n_, p_);
		IEnumerable<Encounter> r_ = context.Operators.ListUnion<Encounter>(l_, q_);
		CqlValueSet s_ = this.Observation();
		IEnumerable<Encounter> t_ = context.Operators.RetrieveByValueSet<Encounter>(s_, null);
		CqlValueSet u_ = this.Office_Visit();
		IEnumerable<Encounter> v_ = context.Operators.RetrieveByValueSet<Encounter>(u_, null);
		IEnumerable<Encounter> w_ = context.Operators.ListUnion<Encounter>(t_, v_);
		IEnumerable<Encounter> x_ = context.Operators.ListUnion<Encounter>(r_, w_);
		CqlValueSet y_ = this.Telephone_Visits();
		IEnumerable<Encounter> z_ = context.Operators.RetrieveByValueSet<Encounter>(y_, null);
		CqlValueSet aa_ = this.Online_Assessments();
		IEnumerable<Encounter> ab_ = context.Operators.RetrieveByValueSet<Encounter>(aa_, null);
		IEnumerable<Encounter> ac_ = context.Operators.ListUnion<Encounter>(z_, ab_);
		IEnumerable<Encounter> ad_ = context.Operators.ListUnion<Encounter>(x_, ac_);
		CqlValueSet ae_ = this.Outpatient_Consultation();
		IEnumerable<Encounter> af_ = context.Operators.RetrieveByValueSet<Encounter>(ae_, null);
		CqlValueSet ag_ = this.Preventive_Care_Services_Established_Office_Visit__18_and_Up();
		IEnumerable<Encounter> ah_ = context.Operators.RetrieveByValueSet<Encounter>(ag_, null);
		IEnumerable<Encounter> ai_ = context.Operators.ListUnion<Encounter>(af_, ah_);
		IEnumerable<Encounter> aj_ = context.Operators.ListUnion<Encounter>(ad_, ai_);
		CqlValueSet ak_ = this.Preventive_Care_Services_Group_Counseling();
		IEnumerable<Encounter> al_ = context.Operators.RetrieveByValueSet<Encounter>(ak_, null);
		bool? an_(Encounter E)
		{
			CqlConcept bp_(CodeableConcept @this)
			{
				CqlConcept bu_ = FHIRHelpers_4_3_000.ToConcept(@this);

				return bu_;
			};
			IEnumerable<CqlConcept> bq_ = context.Operators.Select<CodeableConcept, CqlConcept>(E?.Type, bp_);
			bool? br_(CqlConcept T)
			{
				CqlCode bv_ = this.Unlisted_preventive_medicine_service();
				CqlConcept bw_ = context.Operators.ConvertCodeToConcept(bv_);
				bool? bx_ = context.Operators.Equivalent(T, bw_);

				return bx_;
			};
			IEnumerable<CqlConcept> bs_ = context.Operators.Where<CqlConcept>(bq_, br_);
			bool? bt_ = context.Operators.Exists<CqlConcept>(bs_);

			return bt_;
		};
		IEnumerable<Encounter> ao_ = context.Operators.Where<Encounter>(c_, an_);
		IEnumerable<Encounter> ap_ = context.Operators.ListUnion<Encounter>(al_, ao_);
		IEnumerable<Encounter> aq_ = context.Operators.ListUnion<Encounter>(aj_, ap_);
		CqlValueSet ar_ = this.Preventive_Care_Services__Initial_Office_Visit__0_to_17();
		IEnumerable<Encounter> as_ = context.Operators.RetrieveByValueSet<Encounter>(ar_, null);
		CqlValueSet at_ = this.Preventive_Care_Services_Individual_Counseling();
		IEnumerable<Encounter> au_ = context.Operators.RetrieveByValueSet<Encounter>(at_, null);
		IEnumerable<Encounter> av_ = context.Operators.ListUnion<Encounter>(as_, au_);
		IEnumerable<Encounter> aw_ = context.Operators.ListUnion<Encounter>(aq_, av_);
		CqlValueSet ax_ = this.Preventive_Care_Services_Initial_Office_Visit__18_and_Up();
		IEnumerable<Encounter> ay_ = context.Operators.RetrieveByValueSet<Encounter>(ax_, null);
		CqlValueSet az_ = this.Preventive_Care__Established_Office_Visit__0_to_17();
		IEnumerable<Encounter> ba_ = context.Operators.RetrieveByValueSet<Encounter>(az_, null);
		IEnumerable<Encounter> bb_ = context.Operators.ListUnion<Encounter>(ay_, ba_);
		IEnumerable<Encounter> bc_ = context.Operators.ListUnion<Encounter>(aw_, bb_);
		IEnumerable<Encounter> bd_ = Status_1_6_000.Finished_Encounter(bc_);
		bool? be_(Encounter ValidEncounter)
		{
			CqlInterval<CqlDateTime> by_ = this.Measurement_Period();
			CqlInterval<CqlDateTime> bz_ = FHIRHelpers_4_3_000.ToInterval(ValidEncounter?.Period);
			CqlInterval<CqlDateTime> ca_ = QICoreCommon_2_0_000.ToInterval((bz_ as object));
			bool? cb_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(by_, ca_, null);

			return cb_;
		};
		IEnumerable<Encounter> bf_ = context.Operators.Where<Encounter>(bd_, be_);

		return bf_;
	}

    [CqlDeclaration("Qualifying Encounter")]
	public IEnumerable<Encounter> Qualifying_Encounter() => 
		__Qualifying_Encounter.Value;

	private IEnumerable<Encounter> Encounter_With_Antibiotic_Ordered_Within_Three_Days_Value()
	{
		IEnumerable<Encounter> a_ = this.Qualifying_Encounter();
		IEnumerable<Encounter> b_(Encounter EDOrAmbulatoryVisit)
		{
			CqlValueSet d_ = this.Antibiotic_Medications_for_Pharyngitis();
			IEnumerable<MedicationRequest> e_ = context.Operators.RetrieveByValueSet<MedicationRequest>(d_, null);
			IEnumerable<MedicationRequest> g_ = context.Operators.RetrieveByValueSet<MedicationRequest>(d_, null);
			IEnumerable<MedicationRequest> h_ = context.Operators.ListUnion<MedicationRequest>(e_, g_);
			IEnumerable<MedicationRequest> i_ = Status_1_6_000.Active_Medication(h_);
			bool? j_(MedicationRequest AntibioticOrdered)
			{
				CqlInterval<CqlDateTime> n_ = FHIRHelpers_4_3_000.ToInterval(EDOrAmbulatoryVisit?.Period);
				CqlInterval<CqlDateTime> o_ = QICoreCommon_2_0_000.ToInterval((n_ as object));
				CqlDateTime p_ = context.Operators.Start(o_);
				CqlDateTime q_ = context.Operators.Convert<CqlDateTime>(AntibioticOrdered?.AuthoredOnElement);
				CqlQuantity r_ = context.Operators.Quantity(3m, "days");
				CqlDateTime s_ = context.Operators.Subtract(q_, r_);
				CqlInterval<CqlDateTime> u_ = context.Operators.Interval(s_, q_, true, true);
				bool? v_ = context.Operators.In<CqlDateTime>(p_, u_, null);
				bool? x_ = context.Operators.Not((bool?)(q_ is null));
				bool? y_ = context.Operators.And(v_, x_);

				return y_;
			};
			IEnumerable<MedicationRequest> k_ = context.Operators.Where<MedicationRequest>(i_, j_);
			Encounter l_(MedicationRequest AntibioticOrdered) => 
				EDOrAmbulatoryVisit;
			IEnumerable<Encounter> m_ = context.Operators.Select<MedicationRequest, Encounter>(k_, l_);

			return m_;
		};
		IEnumerable<Encounter> c_ = context.Operators.SelectMany<Encounter, Encounter>(a_, b_);

		return c_;
	}

    [CqlDeclaration("Encounter With Antibiotic Ordered Within Three Days")]
	public IEnumerable<Encounter> Encounter_With_Antibiotic_Ordered_Within_Three_Days() => 
		__Encounter_With_Antibiotic_Ordered_Within_Three_Days.Value;

	private IEnumerable<Condition> Pharyngitis_or_Tonsillitis_Value()
	{
		CqlValueSet a_ = this.Acute_Pharyngitis();
		IEnumerable<Condition> b_ = context.Operators.RetrieveByValueSet<Condition>(a_, null);
		CqlValueSet c_ = this.Acute_Tonsillitis();
		IEnumerable<Condition> d_ = context.Operators.RetrieveByValueSet<Condition>(c_, null);
		IEnumerable<Condition> e_ = context.Operators.ListUnion<Condition>(b_, d_);
		IEnumerable<Condition> f_ = Status_1_6_000.Active_Condition(e_);

		return f_;
	}

    [CqlDeclaration("Pharyngitis or Tonsillitis")]
	public IEnumerable<Condition> Pharyngitis_or_Tonsillitis() => 
		__Pharyngitis_or_Tonsillitis.Value;

	private IEnumerable<Encounter> Encounter_With_Pharyngitis_or_Tonsillitis_With_Antibiotic_Value()
	{
		IEnumerable<Encounter> a_ = this.Encounter_With_Antibiotic_Ordered_Within_Three_Days();
		IEnumerable<Condition> b_ = this.Pharyngitis_or_Tonsillitis();
		IEnumerable<ValueTuple<Encounter,Condition>> c_ = context.Operators.CrossJoin<Encounter, Condition>(a_, b_);
		Tuple_GCVGMbOiaNAaiRPIPICSbUPeC d_(ValueTuple<Encounter,Condition> _valueTuple)
		{
			Tuple_GCVGMbOiaNAaiRPIPICSbUPeC j_ = new Tuple_GCVGMbOiaNAaiRPIPICSbUPeC
			{
				VisitWithAntibiotic = _valueTuple.Item1,
				AcutePharyngitisTonsillitis = _valueTuple.Item2,
			};

			return j_;
		};
		IEnumerable<Tuple_GCVGMbOiaNAaiRPIPICSbUPeC> e_ = context.Operators.Select<ValueTuple<Encounter,Condition>, Tuple_GCVGMbOiaNAaiRPIPICSbUPeC>(c_, d_);
		bool? f_(Tuple_GCVGMbOiaNAaiRPIPICSbUPeC tuple_gcvgmboianaairpipicsbupec)
		{
			CqlInterval<CqlDateTime> k_ = QICoreCommon_2_0_000.ToPrevalenceInterval(tuple_gcvgmboianaairpipicsbupec.AcutePharyngitisTonsillitis);
			CqlDateTime l_ = context.Operators.Start(k_);
			CqlInterval<CqlDateTime> m_ = FHIRHelpers_4_3_000.ToInterval(tuple_gcvgmboianaairpipicsbupec.VisitWithAntibiotic?.Period);
			CqlInterval<CqlDateTime> n_ = QICoreCommon_2_0_000.ToInterval((m_ as object));
			bool? o_ = context.Operators.In<CqlDateTime>(l_, n_, null);

			return o_;
		};
		IEnumerable<Tuple_GCVGMbOiaNAaiRPIPICSbUPeC> g_ = context.Operators.Where<Tuple_GCVGMbOiaNAaiRPIPICSbUPeC>(e_, f_);
		Encounter h_(Tuple_GCVGMbOiaNAaiRPIPICSbUPeC tuple_gcvgmboianaairpipicsbupec) => 
			tuple_gcvgmboianaairpipicsbupec.VisitWithAntibiotic;
		IEnumerable<Encounter> i_ = context.Operators.Select<Tuple_GCVGMbOiaNAaiRPIPICSbUPeC, Encounter>(g_, h_);

		return i_;
	}

    [CqlDeclaration("Encounter With Pharyngitis or Tonsillitis With Antibiotic")]
	public IEnumerable<Encounter> Encounter_With_Pharyngitis_or_Tonsillitis_With_Antibiotic() => 
		__Encounter_With_Pharyngitis_or_Tonsillitis_With_Antibiotic.Value;

	private IEnumerable<Encounter> Initial_Population_Value()
	{
		IEnumerable<Encounter> a_ = this.Encounter_With_Pharyngitis_or_Tonsillitis_With_Antibiotic();
		bool? b_(Encounter EncounterWithPharyngitis)
		{
			Patient f_ = this.Patient();
			CqlDate g_ = context.Operators.Convert<CqlDate>(f_?.BirthDateElement?.Value);
			CqlInterval<CqlDateTime> h_ = this.Measurement_Period();
			CqlDateTime i_ = context.Operators.Start(h_);
			CqlDate j_ = context.Operators.DateFrom(i_);
			int? k_ = context.Operators.CalculateAgeAt(g_, j_, "year");
			bool? l_ = context.Operators.GreaterOrEqual(k_, 3);

			return l_;
		};
		IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);
		Encounter d_(Encounter EncounterWithPharyngitis) => 
			EncounterWithPharyngitis;
		IEnumerable<Encounter> e_ = context.Operators.Select<Encounter, Encounter>(c_, d_);

		return e_;
	}

    [CqlDeclaration("Initial Population")]
	public IEnumerable<Encounter> Initial_Population() => 
		__Initial_Population.Value;

	private IEnumerable<Encounter> Denominator_Value()
	{
		IEnumerable<Encounter> a_ = this.Initial_Population();

		return a_;
	}

    [CqlDeclaration("Denominator")]
	public IEnumerable<Encounter> Denominator() => 
		__Denominator.Value;

	private IEnumerable<Encounter> In_Hospice_Value()
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

    [CqlDeclaration("In Hospice")]
	public IEnumerable<Encounter> In_Hospice() => 
		__In_Hospice.Value;

	private IEnumerable<Encounter> Denominator_Exclusions_Value()
	{
		IEnumerable<Encounter> a_ = this.In_Hospice();
		IEnumerable<Encounter> b_ = this.Encounter_With_Pharyngitis_or_Tonsillitis_With_Antibiotic();
		CqlValueSet c_ = this.Antibiotic_Medications_for_Pharyngitis();
		IEnumerable<MedicationRequest> d_ = context.Operators.RetrieveByValueSet<MedicationRequest>(c_, null);
		IEnumerable<MedicationRequest> f_ = context.Operators.RetrieveByValueSet<MedicationRequest>(c_, null);
		IEnumerable<MedicationRequest> g_ = context.Operators.ListUnion<MedicationRequest>(d_, f_);
		IEnumerable<Encounter> h_ = Antibiotic_1_5_000.Has_Antibiotic_Medication_History(b_, g_);
		IEnumerable<Encounter> i_ = context.Operators.ListUnion<Encounter>(a_, h_);
		CqlValueSet k_ = this.Competing_Conditions_for_Respiratory_Conditions();
		IEnumerable<Condition> l_ = context.Operators.RetrieveByValueSet<Condition>(k_, null);
		IEnumerable<Encounter> m_ = Antibiotic_1_5_000.Has_Competing_Diagnosis_History(b_, l_);
		CqlValueSet o_ = this.Comorbid_Conditions_for_Respiratory_Conditions();
		IEnumerable<Condition> p_ = context.Operators.RetrieveByValueSet<Condition>(o_, null);
		IEnumerable<Encounter> q_ = Antibiotic_1_5_000.Has_Comorbid_Condition_History(b_, p_);
		IEnumerable<Encounter> r_ = context.Operators.ListUnion<Encounter>(m_, q_);
		IEnumerable<Encounter> s_ = context.Operators.ListUnion<Encounter>(i_, r_);

		return s_;
	}

    [CqlDeclaration("Denominator Exclusions")]
	public IEnumerable<Encounter> Denominator_Exclusions() => 
		__Denominator_Exclusions.Value;

	private IEnumerable<Observation> Group_A_Streptococcus_Lab_Test_With_Result_Value()
	{
		CqlValueSet a_ = this.Group_A_Streptococcus_Test();
		IEnumerable<Observation> b_ = context.Operators.RetrieveByValueSet<Observation>(a_, null);
		IEnumerable<Observation> c_ = Status_1_6_000.Final_Lab_Observation(b_);
		bool? d_(Observation GroupAStreptococcusTest)
		{
			object f_ = FHIRHelpers_4_3_000.ToValue(GroupAStreptococcusTest?.Value);
			bool? g_ = context.Operators.Not((bool?)(f_ is null));

			return g_;
		};
		IEnumerable<Observation> e_ = context.Operators.Where<Observation>(c_, d_);

		return e_;
	}

    [CqlDeclaration("Group A Streptococcus Lab Test With Result")]
	public IEnumerable<Observation> Group_A_Streptococcus_Lab_Test_With_Result() => 
		__Group_A_Streptococcus_Lab_Test_With_Result.Value;

	private IEnumerable<Encounter> Numerator_Value()
	{
		IEnumerable<Observation> a_ = this.Group_A_Streptococcus_Lab_Test_With_Result();
		IEnumerable<Encounter> b_ = this.Encounter_With_Pharyngitis_or_Tonsillitis_With_Antibiotic();
		IEnumerable<ValueTuple<Observation,Encounter>> c_ = context.Operators.CrossJoin<Observation, Encounter>(a_, b_);
		Tuple_FeRJiKQTQgCPbSYWQKEAbBEeV d_(ValueTuple<Observation,Encounter> _valueTuple)
		{
			Tuple_FeRJiKQTQgCPbSYWQKEAbBEeV j_ = new Tuple_FeRJiKQTQgCPbSYWQKEAbBEeV
			{
				GroupAStreptococcusTest = _valueTuple.Item1,
				EncounterWithPharyngitis = _valueTuple.Item2,
			};

			return j_;
		};
		IEnumerable<Tuple_FeRJiKQTQgCPbSYWQKEAbBEeV> e_ = context.Operators.Select<ValueTuple<Observation,Encounter>, Tuple_FeRJiKQTQgCPbSYWQKEAbBEeV>(c_, d_);
		bool? f_(Tuple_FeRJiKQTQgCPbSYWQKEAbBEeV tuple_ferjikqtqgcpbsywqkeabbeev)
		{
			object k_ = FHIRHelpers_4_3_000.ToValue(tuple_ferjikqtqgcpbsywqkeabbeev.GroupAStreptococcusTest?.Effective);
			CqlInterval<CqlDateTime> l_ = QICoreCommon_2_0_000.ToInterval(k_);
			CqlDateTime m_ = context.Operators.Start(l_);
			CqlInterval<CqlDateTime> n_ = FHIRHelpers_4_3_000.ToInterval(tuple_ferjikqtqgcpbsywqkeabbeev.EncounterWithPharyngitis?.Period);
			CqlDateTime o_ = context.Operators.End(n_);
			CqlQuantity p_ = context.Operators.Quantity(3m, "days");
			CqlDateTime q_ = context.Operators.Subtract(o_, p_);
			CqlDateTime s_ = context.Operators.End(n_);
			CqlDateTime u_ = context.Operators.Add(s_, p_);
			CqlInterval<CqlDateTime> v_ = context.Operators.Interval(q_, u_, true, true);
			bool? w_ = context.Operators.In<CqlDateTime>(m_, v_, "day");

			return w_;
		};
		IEnumerable<Tuple_FeRJiKQTQgCPbSYWQKEAbBEeV> g_ = context.Operators.Where<Tuple_FeRJiKQTQgCPbSYWQKEAbBEeV>(e_, f_);
		Encounter h_(Tuple_FeRJiKQTQgCPbSYWQKEAbBEeV tuple_ferjikqtqgcpbsywqkeabbeev) => 
			tuple_ferjikqtqgcpbsywqkeabbeev.EncounterWithPharyngitis;
		IEnumerable<Encounter> i_ = context.Operators.Select<Tuple_FeRJiKQTQgCPbSYWQKEAbBEeV, Encounter>(g_, h_);

		return i_;
	}

    [CqlDeclaration("Numerator")]
	public IEnumerable<Encounter> Numerator() => 
		__Numerator.Value;

	private IEnumerable<Encounter> Stratification_1_Value()
	{
		IEnumerable<Encounter> a_ = this.Encounter_With_Pharyngitis_or_Tonsillitis_With_Antibiotic();
		bool? b_(Encounter EncounterWithPharyngitis)
		{
			Patient f_ = this.Patient();
			CqlDate g_ = context.Operators.Convert<CqlDate>(f_?.BirthDateElement?.Value);
			CqlInterval<CqlDateTime> h_ = this.Measurement_Period();
			CqlDateTime i_ = context.Operators.Start(h_);
			CqlDate j_ = context.Operators.DateFrom(i_);
			int? k_ = context.Operators.CalculateAgeAt(g_, j_, "year");
			CqlInterval<int?> l_ = context.Operators.Interval(3, 17, true, true);
			bool? m_ = context.Operators.In<int?>(k_, l_, null);

			return m_;
		};
		IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);
		Encounter d_(Encounter EncounterWithPharyngitis) => 
			EncounterWithPharyngitis;
		IEnumerable<Encounter> e_ = context.Operators.Select<Encounter, Encounter>(c_, d_);

		return e_;
	}

    [CqlDeclaration("Stratification 1")]
	public IEnumerable<Encounter> Stratification_1() => 
		__Stratification_1.Value;

	private IEnumerable<Encounter> Stratification_2_Value()
	{
		IEnumerable<Encounter> a_ = this.Encounter_With_Pharyngitis_or_Tonsillitis_With_Antibiotic();
		bool? b_(Encounter EncounterWithPharyngitis)
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
		Encounter d_(Encounter EncounterWithPharyngitis) => 
			EncounterWithPharyngitis;
		IEnumerable<Encounter> e_ = context.Operators.Select<Encounter, Encounter>(c_, d_);

		return e_;
	}

    [CqlDeclaration("Stratification 2")]
	public IEnumerable<Encounter> Stratification_2() => 
		__Stratification_2.Value;

	private IEnumerable<Encounter> Stratification_3_Value()
	{
		IEnumerable<Encounter> a_ = this.Encounter_With_Pharyngitis_or_Tonsillitis_With_Antibiotic();
		bool? b_(Encounter EncounterWithPharyngitis)
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
		Encounter d_(Encounter EncounterWithPharyngitis) => 
			EncounterWithPharyngitis;
		IEnumerable<Encounter> e_ = context.Operators.Select<Encounter, Encounter>(c_, d_);

		return e_;
	}

    [CqlDeclaration("Stratification 3")]
	public IEnumerable<Encounter> Stratification_3() => 
		__Stratification_3.Value;

}
