using System;
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
		var a_ = new CqlCode[]
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
		var a_ = context.Operators.DateTime((int?)2025, (int?)1, (int?)1, (int?)0, (int?)0, (int?)0, (int?)0, default);
		var b_ = context.Operators.DateTime((int?)2026, (int?)1, (int?)1, (int?)0, (int?)0, (int?)0, (int?)0, default);
		var c_ = context.Operators.Interval(a_, b_, (bool?)true, (bool?)false);
		var d_ = context.ResolveParameter("AppropriateTestingforPharyngitisFHIR-0.1.000", "Measurement Period", c_);

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

	private IEnumerable<Encounter> Qualifying_Encounter_Value()
	{
		var a_ = this.Emergency_Department_Visit();
		var b_ = context.Operators.RetrieveByValueSet<Encounter>(a_, null);
		var c_ = context.Operators.RetrieveByValueSet<Encounter>(null, null);
		bool? d_(Encounter E)
		{
			CqlConcept bg_(CodeableConcept @this)
			{
				var bl_ = FHIRHelpers_4_3_000.ToConcept(@this);

				return bl_;
			};
			var bh_ = context.Operators.Select<CodeableConcept, CqlConcept>(E?.Type, bg_);
			bool? bi_(CqlConcept T)
			{
				var bm_ = this.Observation_care_discharge_day_management__This_code_is_to_be_utilized_to_report_all_services_provided_to_a_patient_on_discharge_from_outpatient_hospital_observation_status_if_the_discharge_is_on_other_than_the_initial_date_of_observation_status__To_report_services_to_a_patient_designated_as_observation_status_or_inpatient_status_and_discharged_on_the_same_date__use_the_codes_for_Observation_or_Inpatient_Care_Services__including_Admission_and_Discharge_Services__99234_99236_as_appropriate___();
				var bn_ = context.Operators.ConvertCodeToConcept(bm_);
				var bo_ = context.Operators.Equivalent(T, bn_);

				return bo_;
			};
			var bj_ = context.Operators.Where<CqlConcept>(bh_, bi_);
			var bk_ = context.Operators.Exists<CqlConcept>(bj_);

			return bk_;
		};
		var e_ = context.Operators.Where<Encounter>(c_, d_);
		var f_ = context.Operators.ListUnion<Encounter>(b_, e_);
		var h_ = context.Operators.RetrieveByValueSet<Encounter>(a_, null);
		var i_ = this.Home_Healthcare_Services();
		var j_ = context.Operators.RetrieveByValueSet<Encounter>(i_, null);
		var k_ = context.Operators.ListUnion<Encounter>(h_, j_);
		var l_ = context.Operators.ListUnion<Encounter>(f_, k_);
		var m_ = this.Initial_Hospital_Observation_Care();
		var n_ = context.Operators.RetrieveByValueSet<Encounter>(m_, null);
		var o_ = this.Medical_Disability_Exam();
		var p_ = context.Operators.RetrieveByValueSet<Encounter>(o_, null);
		var q_ = context.Operators.ListUnion<Encounter>(n_, p_);
		var r_ = context.Operators.ListUnion<Encounter>(l_, q_);
		var s_ = this.Observation();
		var t_ = context.Operators.RetrieveByValueSet<Encounter>(s_, null);
		var u_ = this.Office_Visit();
		var v_ = context.Operators.RetrieveByValueSet<Encounter>(u_, null);
		var w_ = context.Operators.ListUnion<Encounter>(t_, v_);
		var x_ = context.Operators.ListUnion<Encounter>(r_, w_);
		var y_ = this.Telephone_Visits();
		var z_ = context.Operators.RetrieveByValueSet<Encounter>(y_, null);
		var aa_ = this.Online_Assessments();
		var ab_ = context.Operators.RetrieveByValueSet<Encounter>(aa_, null);
		var ac_ = context.Operators.ListUnion<Encounter>(z_, ab_);
		var ad_ = context.Operators.ListUnion<Encounter>(x_, ac_);
		var ae_ = this.Outpatient_Consultation();
		var af_ = context.Operators.RetrieveByValueSet<Encounter>(ae_, null);
		var ag_ = this.Preventive_Care_Services_Established_Office_Visit__18_and_Up();
		var ah_ = context.Operators.RetrieveByValueSet<Encounter>(ag_, null);
		var ai_ = context.Operators.ListUnion<Encounter>(af_, ah_);
		var aj_ = context.Operators.ListUnion<Encounter>(ad_, ai_);
		var ak_ = this.Preventive_Care_Services_Group_Counseling();
		var al_ = context.Operators.RetrieveByValueSet<Encounter>(ak_, null);
		bool? an_(Encounter E)
		{
			CqlConcept bp_(CodeableConcept @this)
			{
				var bu_ = FHIRHelpers_4_3_000.ToConcept(@this);

				return bu_;
			};
			var bq_ = context.Operators.Select<CodeableConcept, CqlConcept>(E?.Type, bp_);
			bool? br_(CqlConcept T)
			{
				var bv_ = this.Unlisted_preventive_medicine_service();
				var bw_ = context.Operators.ConvertCodeToConcept(bv_);
				var bx_ = context.Operators.Equivalent(T, bw_);

				return bx_;
			};
			var bs_ = context.Operators.Where<CqlConcept>(bq_, br_);
			var bt_ = context.Operators.Exists<CqlConcept>(bs_);

			return bt_;
		};
		var ao_ = context.Operators.Where<Encounter>(c_, an_);
		var ap_ = context.Operators.ListUnion<Encounter>(al_, ao_);
		var aq_ = context.Operators.ListUnion<Encounter>(aj_, ap_);
		var ar_ = this.Preventive_Care_Services__Initial_Office_Visit__0_to_17();
		var as_ = context.Operators.RetrieveByValueSet<Encounter>(ar_, null);
		var at_ = this.Preventive_Care_Services_Individual_Counseling();
		var au_ = context.Operators.RetrieveByValueSet<Encounter>(at_, null);
		var av_ = context.Operators.ListUnion<Encounter>(as_, au_);
		var aw_ = context.Operators.ListUnion<Encounter>(aq_, av_);
		var ax_ = this.Preventive_Care_Services_Initial_Office_Visit__18_and_Up();
		var ay_ = context.Operators.RetrieveByValueSet<Encounter>(ax_, null);
		var az_ = this.Preventive_Care__Established_Office_Visit__0_to_17();
		var ba_ = context.Operators.RetrieveByValueSet<Encounter>(az_, null);
		var bb_ = context.Operators.ListUnion<Encounter>(ay_, ba_);
		var bc_ = context.Operators.ListUnion<Encounter>(aw_, bb_);
		var bd_ = Status_1_6_000.Finished_Encounter(bc_);
		bool? be_(Encounter ValidEncounter)
		{
			var by_ = this.Measurement_Period();
			var bz_ = FHIRHelpers_4_3_000.ToInterval(ValidEncounter?.Period);
			var ca_ = QICoreCommon_2_0_000.ToInterval((bz_ as object));
			var cb_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(by_, ca_, null);

			return cb_;
		};
		var bf_ = context.Operators.Where<Encounter>(bd_, be_);

		return bf_;
	}

    [CqlDeclaration("Qualifying Encounter")]
	public IEnumerable<Encounter> Qualifying_Encounter() => 
		__Qualifying_Encounter.Value;

	private IEnumerable<Encounter> Encounter_With_Antibiotic_Ordered_Within_Three_Days_Value()
	{
		var a_ = this.Qualifying_Encounter();
		IEnumerable<Encounter> b_(Encounter EDOrAmbulatoryVisit)
		{
			var d_ = this.Antibiotic_Medications_for_Pharyngitis();
			var e_ = context.Operators.RetrieveByValueSet<MedicationRequest>(d_, null);
			var g_ = context.Operators.RetrieveByValueSet<MedicationRequest>(d_, null);
			var h_ = context.Operators.ListUnion<MedicationRequest>(e_, g_);
			var i_ = Status_1_6_000.Active_Medication(h_);
			bool? j_(MedicationRequest AntibioticOrdered)
			{
				var n_ = FHIRHelpers_4_3_000.ToInterval(EDOrAmbulatoryVisit?.Period);
				var o_ = QICoreCommon_2_0_000.ToInterval((n_ as object));
				var p_ = context.Operators.Start(o_);
				var q_ = context.Operators.Convert<CqlDateTime>(AntibioticOrdered?.AuthoredOnElement);
				var r_ = context.Operators.Quantity((decimal?)3m, "days");
				var s_ = context.Operators.Subtract(q_, r_);
				var u_ = context.Operators.Interval(s_, q_, (bool?)true, (bool?)true);
				var v_ = context.Operators.In<CqlDateTime>(p_, u_, null);
				var x_ = context.Operators.Not((bool?)(q_ is null));
				var y_ = context.Operators.And(v_, x_);

				return y_;
			};
			var k_ = context.Operators.Where<MedicationRequest>(i_, j_);
			Encounter l_(MedicationRequest AntibioticOrdered) => 
				EDOrAmbulatoryVisit;
			var m_ = context.Operators.Select<MedicationRequest, Encounter>(k_, l_);

			return m_;
		};
		var c_ = context.Operators.SelectMany<Encounter, Encounter>(a_, b_);

		return c_;
	}

    [CqlDeclaration("Encounter With Antibiotic Ordered Within Three Days")]
	public IEnumerable<Encounter> Encounter_With_Antibiotic_Ordered_Within_Three_Days() => 
		__Encounter_With_Antibiotic_Ordered_Within_Three_Days.Value;

	private IEnumerable<Condition> Pharyngitis_or_Tonsillitis_Value()
	{
		var a_ = this.Acute_Pharyngitis();
		var b_ = context.Operators.RetrieveByValueSet<Condition>(a_, null);
		var c_ = this.Acute_Tonsillitis();
		var d_ = context.Operators.RetrieveByValueSet<Condition>(c_, null);
		var e_ = context.Operators.ListUnion<Condition>(b_, d_);
		var f_ = Status_1_6_000.Active_Condition(e_);

		return f_;
	}

    [CqlDeclaration("Pharyngitis or Tonsillitis")]
	public IEnumerable<Condition> Pharyngitis_or_Tonsillitis() => 
		__Pharyngitis_or_Tonsillitis.Value;

	private IEnumerable<Encounter> Encounter_With_Pharyngitis_or_Tonsillitis_With_Antibiotic_Value()
	{
		var a_ = this.Encounter_With_Antibiotic_Ordered_Within_Three_Days();
		var b_ = this.Pharyngitis_or_Tonsillitis();
		var c_ = context.Operators.CrossJoin<Encounter, Condition>(a_, b_);
		Tuple_GCVGMbOiaNAaiRPIPICSbUPeC d_(ValueTuple<Encounter,Condition> _valueTuple)
		{
			var j_ = new Tuple_GCVGMbOiaNAaiRPIPICSbUPeC
			{
				VisitWithAntibiotic = _valueTuple.Item1,
				AcutePharyngitisTonsillitis = _valueTuple.Item2,
			};

			return j_;
		};
		var e_ = context.Operators.Select<ValueTuple<Encounter,Condition>, Tuple_GCVGMbOiaNAaiRPIPICSbUPeC>(c_, d_);
		bool? f_(Tuple_GCVGMbOiaNAaiRPIPICSbUPeC tuple_gcvgmboianaairpipicsbupec)
		{
			var k_ = QICoreCommon_2_0_000.ToPrevalenceInterval(tuple_gcvgmboianaairpipicsbupec.AcutePharyngitisTonsillitis);
			var l_ = context.Operators.Start(k_);
			var m_ = FHIRHelpers_4_3_000.ToInterval(tuple_gcvgmboianaairpipicsbupec.VisitWithAntibiotic?.Period);
			var n_ = QICoreCommon_2_0_000.ToInterval((m_ as object));
			var o_ = context.Operators.In<CqlDateTime>(l_, n_, null);

			return o_;
		};
		var g_ = context.Operators.Where<Tuple_GCVGMbOiaNAaiRPIPICSbUPeC>(e_, f_);
		Encounter h_(Tuple_GCVGMbOiaNAaiRPIPICSbUPeC tuple_gcvgmboianaairpipicsbupec) => 
			tuple_gcvgmboianaairpipicsbupec.VisitWithAntibiotic;
		var i_ = context.Operators.Select<Tuple_GCVGMbOiaNAaiRPIPICSbUPeC, Encounter>(g_, h_);

		return i_;
	}

    [CqlDeclaration("Encounter With Pharyngitis or Tonsillitis With Antibiotic")]
	public IEnumerable<Encounter> Encounter_With_Pharyngitis_or_Tonsillitis_With_Antibiotic() => 
		__Encounter_With_Pharyngitis_or_Tonsillitis_With_Antibiotic.Value;

	private IEnumerable<Encounter> Initial_Population_Value()
	{
		var a_ = this.Encounter_With_Pharyngitis_or_Tonsillitis_With_Antibiotic();
		bool? b_(Encounter EncounterWithPharyngitis)
		{
			var f_ = this.Patient();
			var g_ = context.Operators.Convert<CqlDate>(f_?.BirthDateElement?.Value);
			var h_ = this.Measurement_Period();
			var i_ = context.Operators.Start(h_);
			var j_ = context.Operators.DateFrom(i_);
			var k_ = context.Operators.CalculateAgeAt(g_, j_, "year");
			var l_ = context.Operators.GreaterOrEqual(k_, (int?)3);

			return l_;
		};
		var c_ = context.Operators.Where<Encounter>(a_, b_);
		Encounter d_(Encounter EncounterWithPharyngitis) => 
			EncounterWithPharyngitis;
		var e_ = context.Operators.Select<Encounter, Encounter>(c_, d_);

		return e_;
	}

    [CqlDeclaration("Initial Population")]
	public IEnumerable<Encounter> Initial_Population() => 
		__Initial_Population.Value;

	private IEnumerable<Encounter> Denominator_Value()
	{
		var a_ = this.Initial_Population();

		return a_;
	}

    [CqlDeclaration("Denominator")]
	public IEnumerable<Encounter> Denominator() => 
		__Denominator.Value;

	private IEnumerable<Encounter> In_Hospice_Value()
	{
		var a_ = this.Initial_Population();
		bool? b_(Encounter EligibleEncounters)
		{
			var d_ = Hospice_6_9_000.Has_Hospice_Services();

			return d_;
		};
		var c_ = context.Operators.Where<Encounter>(a_, b_);

		return c_;
	}

    [CqlDeclaration("In Hospice")]
	public IEnumerable<Encounter> In_Hospice() => 
		__In_Hospice.Value;

	private IEnumerable<Encounter> Denominator_Exclusions_Value()
	{
		var a_ = this.In_Hospice();
		var b_ = this.Encounter_With_Pharyngitis_or_Tonsillitis_With_Antibiotic();
		var c_ = this.Antibiotic_Medications_for_Pharyngitis();
		var d_ = context.Operators.RetrieveByValueSet<MedicationRequest>(c_, null);
		var f_ = context.Operators.RetrieveByValueSet<MedicationRequest>(c_, null);
		var g_ = context.Operators.ListUnion<MedicationRequest>(d_, f_);
		var h_ = Antibiotic_1_5_000.Has_Antibiotic_Medication_History(b_, g_);
		var i_ = context.Operators.ListUnion<Encounter>(a_, h_);
		var k_ = this.Competing_Conditions_for_Respiratory_Conditions();
		var l_ = context.Operators.RetrieveByValueSet<Condition>(k_, null);
		var m_ = Antibiotic_1_5_000.Has_Competing_Diagnosis_History(b_, l_);
		var o_ = this.Comorbid_Conditions_for_Respiratory_Conditions();
		var p_ = context.Operators.RetrieveByValueSet<Condition>(o_, null);
		var q_ = Antibiotic_1_5_000.Has_Comorbid_Condition_History(b_, p_);
		var r_ = context.Operators.ListUnion<Encounter>(m_, q_);
		var s_ = context.Operators.ListUnion<Encounter>(i_, r_);

		return s_;
	}

    [CqlDeclaration("Denominator Exclusions")]
	public IEnumerable<Encounter> Denominator_Exclusions() => 
		__Denominator_Exclusions.Value;

	private IEnumerable<Observation> Group_A_Streptococcus_Lab_Test_With_Result_Value()
	{
		var a_ = this.Group_A_Streptococcus_Test();
		var b_ = context.Operators.RetrieveByValueSet<Observation>(a_, null);
		var c_ = Status_1_6_000.Final_Lab_Observation(b_);
		bool? d_(Observation GroupAStreptococcusTest)
		{
			var f_ = FHIRHelpers_4_3_000.ToValue(GroupAStreptococcusTest?.Value);
			var g_ = context.Operators.Not((bool?)(f_ is null));

			return g_;
		};
		var e_ = context.Operators.Where<Observation>(c_, d_);

		return e_;
	}

    [CqlDeclaration("Group A Streptococcus Lab Test With Result")]
	public IEnumerable<Observation> Group_A_Streptococcus_Lab_Test_With_Result() => 
		__Group_A_Streptococcus_Lab_Test_With_Result.Value;

	private IEnumerable<Encounter> Numerator_Value()
	{
		var a_ = this.Group_A_Streptococcus_Lab_Test_With_Result();
		var b_ = this.Encounter_With_Pharyngitis_or_Tonsillitis_With_Antibiotic();
		var c_ = context.Operators.CrossJoin<Observation, Encounter>(a_, b_);
		Tuple_FeRJiKQTQgCPbSYWQKEAbBEeV d_(ValueTuple<Observation,Encounter> _valueTuple)
		{
			var j_ = new Tuple_FeRJiKQTQgCPbSYWQKEAbBEeV
			{
				GroupAStreptococcusTest = _valueTuple.Item1,
				EncounterWithPharyngitis = _valueTuple.Item2,
			};

			return j_;
		};
		var e_ = context.Operators.Select<ValueTuple<Observation,Encounter>, Tuple_FeRJiKQTQgCPbSYWQKEAbBEeV>(c_, d_);
		bool? f_(Tuple_FeRJiKQTQgCPbSYWQKEAbBEeV tuple_ferjikqtqgcpbsywqkeabbeev)
		{
			var k_ = FHIRHelpers_4_3_000.ToValue(tuple_ferjikqtqgcpbsywqkeabbeev.GroupAStreptococcusTest?.Effective);
			var l_ = QICoreCommon_2_0_000.ToInterval(k_);
			var m_ = context.Operators.Start(l_);
			var n_ = FHIRHelpers_4_3_000.ToInterval(tuple_ferjikqtqgcpbsywqkeabbeev.EncounterWithPharyngitis?.Period);
			var o_ = context.Operators.End(n_);
			var p_ = context.Operators.Quantity((decimal?)3m, "days");
			var q_ = context.Operators.Subtract(o_, p_);
			var s_ = context.Operators.End(n_);
			var u_ = context.Operators.Add(s_, p_);
			var v_ = context.Operators.Interval(q_, u_, (bool?)true, (bool?)true);
			var w_ = context.Operators.In<CqlDateTime>(m_, v_, "day");

			return w_;
		};
		var g_ = context.Operators.Where<Tuple_FeRJiKQTQgCPbSYWQKEAbBEeV>(e_, f_);
		Encounter h_(Tuple_FeRJiKQTQgCPbSYWQKEAbBEeV tuple_ferjikqtqgcpbsywqkeabbeev) => 
			tuple_ferjikqtqgcpbsywqkeabbeev.EncounterWithPharyngitis;
		var i_ = context.Operators.Select<Tuple_FeRJiKQTQgCPbSYWQKEAbBEeV, Encounter>(g_, h_);

		return i_;
	}

    [CqlDeclaration("Numerator")]
	public IEnumerable<Encounter> Numerator() => 
		__Numerator.Value;

	private IEnumerable<Encounter> Stratification_1_Value()
	{
		var a_ = this.Encounter_With_Pharyngitis_or_Tonsillitis_With_Antibiotic();
		bool? b_(Encounter EncounterWithPharyngitis)
		{
			var f_ = this.Patient();
			var g_ = context.Operators.Convert<CqlDate>(f_?.BirthDateElement?.Value);
			var h_ = this.Measurement_Period();
			var i_ = context.Operators.Start(h_);
			var j_ = context.Operators.DateFrom(i_);
			var k_ = context.Operators.CalculateAgeAt(g_, j_, "year");
			var l_ = context.Operators.Interval((int?)3, (int?)17, (bool?)true, (bool?)true);
			var m_ = context.Operators.In<int?>(k_, l_, null);

			return m_;
		};
		var c_ = context.Operators.Where<Encounter>(a_, b_);
		Encounter d_(Encounter EncounterWithPharyngitis) => 
			EncounterWithPharyngitis;
		var e_ = context.Operators.Select<Encounter, Encounter>(c_, d_);

		return e_;
	}

    [CqlDeclaration("Stratification 1")]
	public IEnumerable<Encounter> Stratification_1() => 
		__Stratification_1.Value;

	private IEnumerable<Encounter> Stratification_2_Value()
	{
		var a_ = this.Encounter_With_Pharyngitis_or_Tonsillitis_With_Antibiotic();
		bool? b_(Encounter EncounterWithPharyngitis)
		{
			var f_ = this.Patient();
			var g_ = context.Operators.Convert<CqlDate>(f_?.BirthDateElement?.Value);
			var h_ = this.Measurement_Period();
			var i_ = context.Operators.Start(h_);
			var j_ = context.Operators.DateFrom(i_);
			var k_ = context.Operators.CalculateAgeAt(g_, j_, "year");
			var l_ = context.Operators.Interval((int?)18, (int?)64, (bool?)true, (bool?)true);
			var m_ = context.Operators.In<int?>(k_, l_, null);

			return m_;
		};
		var c_ = context.Operators.Where<Encounter>(a_, b_);
		Encounter d_(Encounter EncounterWithPharyngitis) => 
			EncounterWithPharyngitis;
		var e_ = context.Operators.Select<Encounter, Encounter>(c_, d_);

		return e_;
	}

    [CqlDeclaration("Stratification 2")]
	public IEnumerable<Encounter> Stratification_2() => 
		__Stratification_2.Value;

	private IEnumerable<Encounter> Stratification_3_Value()
	{
		var a_ = this.Encounter_With_Pharyngitis_or_Tonsillitis_With_Antibiotic();
		bool? b_(Encounter EncounterWithPharyngitis)
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
		var c_ = context.Operators.Where<Encounter>(a_, b_);
		Encounter d_(Encounter EncounterWithPharyngitis) => 
			EncounterWithPharyngitis;
		var e_ = context.Operators.Select<Encounter, Encounter>(c_, d_);

		return e_;
	}

    [CqlDeclaration("Stratification 3")]
	public IEnumerable<Encounter> Stratification_3() => 
		__Stratification_3.Value;

}
