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
    internal Lazy<(IEnumerable<CqlCode> codes, string display)?> __SDE_Ethnicity;
    internal Lazy<IEnumerable<(CqlConcept code, CqlInterval<CqlDateTime> period)?>> __SDE_Payer;
    internal Lazy<(IEnumerable<CqlCode> codes, string display)?> __SDE_Race;
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
        __SDE_Ethnicity = new Lazy<(IEnumerable<CqlCode> codes, string display)?>(this.SDE_Ethnicity_Value);
        __SDE_Payer = new Lazy<IEnumerable<(CqlConcept code, CqlInterval<CqlDateTime> period)?>>(this.SDE_Payer_Value);
        __SDE_Race = new Lazy<(IEnumerable<CqlCode> codes, string display)?>(this.SDE_Race_Value);
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
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.102.12.1011", default);

    [CqlDeclaration("Acute Pharyngitis")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.102.12.1011")]
	public CqlValueSet Acute_Pharyngitis() => 
		__Acute_Pharyngitis.Value;

	private CqlValueSet Acute_Tonsillitis_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.102.12.1012", default);

    [CqlDeclaration("Acute Tonsillitis")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.102.12.1012")]
	public CqlValueSet Acute_Tonsillitis() => 
		__Acute_Tonsillitis.Value;

	private CqlValueSet Antibiotic_Medications_for_Pharyngitis_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.196.12.1001", default);

    [CqlDeclaration("Antibiotic Medications for Pharyngitis")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.196.12.1001")]
	public CqlValueSet Antibiotic_Medications_for_Pharyngitis() => 
		__Antibiotic_Medications_for_Pharyngitis.Value;

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

	private CqlValueSet Discharge_Services_Observation_Care_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1039", default);

    [CqlDeclaration("Discharge Services Observation Care")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1039")]
	public CqlValueSet Discharge_Services_Observation_Care() => 
		__Discharge_Services_Observation_Care.Value;

	private CqlValueSet Emergency_Department_Visit_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1010", default);

    [CqlDeclaration("Emergency Department Visit")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1010")]
	public CqlValueSet Emergency_Department_Visit() => 
		__Emergency_Department_Visit.Value;

	private CqlValueSet Group_A_Streptococcus_Test_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.198.12.1012", default);

    [CqlDeclaration("Group A Streptococcus Test")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.198.12.1012")]
	public CqlValueSet Group_A_Streptococcus_Test() => 
		__Group_A_Streptococcus_Test.Value;

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

	private CqlCode Observation_care_discharge_day_management__This_code_is_to_be_utilized_to_report_all_services_provided_to_a_patient_on_discharge_from_outpatient_hospital_observation_status_if_the_discharge_is_on_other_than_the_initial_date_of_observation_status__To_report_services_to_a_patient_designated_as_observation_status_or_inpatient_status_and_discharged_on_the_same_date__use_the_codes_for_Observation_or_Inpatient_Care_Services__including_Admission_and_Discharge_Services__99234_99236_as_appropriate____Value() => 
		new CqlCode("99217", "http://www.ama-assn.org/go/cpt", default, default);

    [CqlDeclaration("Observation care discharge day management (This code is to be utilized to report all services provided to a patient on discharge from outpatient hospital observation status if the discharge is on other than the initial date of observation status. To report services to a patient designated as observation status or inpatient status and discharged on the same date, use the codes for Observation or Inpatient Care Services [including Admission and Discharge Services, 99234-99236 as appropriate.])")]
	public CqlCode Observation_care_discharge_day_management__This_code_is_to_be_utilized_to_report_all_services_provided_to_a_patient_on_discharge_from_outpatient_hospital_observation_status_if_the_discharge_is_on_other_than_the_initial_date_of_observation_status__To_report_services_to_a_patient_designated_as_observation_status_or_inpatient_status_and_discharged_on_the_same_date__use_the_codes_for_Observation_or_Inpatient_Care_Services__including_Admission_and_Discharge_Services__99234_99236_as_appropriate___() => 
		__Observation_care_discharge_day_management__This_code_is_to_be_utilized_to_report_all_services_provided_to_a_patient_on_discharge_from_outpatient_hospital_observation_status_if_the_discharge_is_on_other_than_the_initial_date_of_observation_status__To_report_services_to_a_patient_designated_as_observation_status_or_inpatient_status_and_discharged_on_the_same_date__use_the_codes_for_Observation_or_Inpatient_Care_Services__including_Admission_and_Discharge_Services__99234_99236_as_appropriate___.Value;

	private CqlCode Unlisted_preventive_medicine_service_Value() => 
		new CqlCode("99429", "http://www.ama-assn.org/go/cpt", default, default);

    [CqlDeclaration("Unlisted preventive medicine service")]
	public CqlCode Unlisted_preventive_medicine_service() => 
		__Unlisted_preventive_medicine_service.Value;

	private CqlCode[] CPT_Value()
	{
		CqlCode[] a_ = [
			new CqlCode("99217", "http://www.ama-assn.org/go/cpt", default, default),
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
		object d_ = context.ResolveParameter("AppropriateTestingforPharyngitisFHIR-0.1.000", "Measurement Period", c_);

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

	private IEnumerable<Encounter> Qualifying_Encounter_Value()
	{
		CqlValueSet a_ = this.Emergency_Department_Visit();
		IEnumerable<Encounter> b_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
		IEnumerable<Encounter> c_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
		bool? d_(Encounter E)
		{
			List<CodeableConcept> bg_ = E?.Type;
			CqlConcept bh_(CodeableConcept @this)
			{
				CqlConcept bm_ = FHIRHelpers_4_3_000.ToConcept(@this);

				return bm_;
			};
			IEnumerable<CqlConcept> bi_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)bg_, bh_);
			bool? bj_(CqlConcept T)
			{
				CqlCode bn_ = this.Observation_care_discharge_day_management__This_code_is_to_be_utilized_to_report_all_services_provided_to_a_patient_on_discharge_from_outpatient_hospital_observation_status_if_the_discharge_is_on_other_than_the_initial_date_of_observation_status__To_report_services_to_a_patient_designated_as_observation_status_or_inpatient_status_and_discharged_on_the_same_date__use_the_codes_for_Observation_or_Inpatient_Care_Services__including_Admission_and_Discharge_Services__99234_99236_as_appropriate___();
				CqlConcept bo_ = context.Operators.ConvertCodeToConcept(bn_);
				bool? bp_ = context.Operators.Equivalent(T, bo_);

				return bp_;
			};
			IEnumerable<CqlConcept> bk_ = context.Operators.Where<CqlConcept>(bi_, bj_);
			bool? bl_ = context.Operators.Exists<CqlConcept>(bk_);

			return bl_;
		};
		IEnumerable<Encounter> e_ = context.Operators.Where<Encounter>(c_, d_);
		IEnumerable<Encounter> f_ = context.Operators.Union<Encounter>(b_, e_);
		IEnumerable<Encounter> h_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
		CqlValueSet i_ = this.Home_Healthcare_Services();
		IEnumerable<Encounter> j_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, i_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
		IEnumerable<Encounter> k_ = context.Operators.Union<Encounter>(h_, j_);
		IEnumerable<Encounter> l_ = context.Operators.Union<Encounter>(f_, k_);
		CqlValueSet m_ = this.Initial_Hospital_Observation_Care();
		IEnumerable<Encounter> n_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, m_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
		CqlValueSet o_ = this.Medical_Disability_Exam();
		IEnumerable<Encounter> p_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, o_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
		IEnumerable<Encounter> q_ = context.Operators.Union<Encounter>(n_, p_);
		IEnumerable<Encounter> r_ = context.Operators.Union<Encounter>(l_, q_);
		CqlValueSet s_ = this.Observation();
		IEnumerable<Encounter> t_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, s_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
		CqlValueSet u_ = this.Office_Visit();
		IEnumerable<Encounter> v_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, u_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
		IEnumerable<Encounter> w_ = context.Operators.Union<Encounter>(t_, v_);
		IEnumerable<Encounter> x_ = context.Operators.Union<Encounter>(r_, w_);
		CqlValueSet y_ = this.Telephone_Visits();
		IEnumerable<Encounter> z_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, y_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
		CqlValueSet aa_ = this.Online_Assessments();
		IEnumerable<Encounter> ab_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, aa_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
		IEnumerable<Encounter> ac_ = context.Operators.Union<Encounter>(z_, ab_);
		IEnumerable<Encounter> ad_ = context.Operators.Union<Encounter>(x_, ac_);
		CqlValueSet ae_ = this.Outpatient_Consultation();
		IEnumerable<Encounter> af_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, ae_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
		CqlValueSet ag_ = this.Preventive_Care_Services_Established_Office_Visit__18_and_Up();
		IEnumerable<Encounter> ah_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, ag_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
		IEnumerable<Encounter> ai_ = context.Operators.Union<Encounter>(af_, ah_);
		IEnumerable<Encounter> aj_ = context.Operators.Union<Encounter>(ad_, ai_);
		CqlValueSet ak_ = this.Preventive_Care_Services_Group_Counseling();
		IEnumerable<Encounter> al_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, ak_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
		bool? an_(Encounter E)
		{
			List<CodeableConcept> bq_ = E?.Type;
			CqlConcept br_(CodeableConcept @this)
			{
				CqlConcept bw_ = FHIRHelpers_4_3_000.ToConcept(@this);

				return bw_;
			};
			IEnumerable<CqlConcept> bs_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)bq_, br_);
			bool? bt_(CqlConcept T)
			{
				CqlCode bx_ = this.Unlisted_preventive_medicine_service();
				CqlConcept by_ = context.Operators.ConvertCodeToConcept(bx_);
				bool? bz_ = context.Operators.Equivalent(T, by_);

				return bz_;
			};
			IEnumerable<CqlConcept> bu_ = context.Operators.Where<CqlConcept>(bs_, bt_);
			bool? bv_ = context.Operators.Exists<CqlConcept>(bu_);

			return bv_;
		};
		IEnumerable<Encounter> ao_ = context.Operators.Where<Encounter>(c_, an_);
		IEnumerable<Encounter> ap_ = context.Operators.Union<Encounter>(al_, ao_);
		IEnumerable<Encounter> aq_ = context.Operators.Union<Encounter>(aj_, ap_);
		CqlValueSet ar_ = this.Preventive_Care_Services__Initial_Office_Visit__0_to_17();
		IEnumerable<Encounter> as_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, ar_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
		CqlValueSet at_ = this.Preventive_Care_Services_Individual_Counseling();
		IEnumerable<Encounter> au_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, at_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
		IEnumerable<Encounter> av_ = context.Operators.Union<Encounter>(as_, au_);
		IEnumerable<Encounter> aw_ = context.Operators.Union<Encounter>(aq_, av_);
		CqlValueSet ax_ = this.Preventive_Care_Services_Initial_Office_Visit__18_and_Up();
		IEnumerable<Encounter> ay_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, ax_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
		CqlValueSet az_ = this.Preventive_Care__Established_Office_Visit__0_to_17();
		IEnumerable<Encounter> ba_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, az_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
		IEnumerable<Encounter> bb_ = context.Operators.Union<Encounter>(ay_, ba_);
		IEnumerable<Encounter> bc_ = context.Operators.Union<Encounter>(aw_, bb_);
		IEnumerable<Encounter> bd_ = Status_1_6_000.Finished_Encounter(bc_);
		bool? be_(Encounter ValidEncounter)
		{
			CqlInterval<CqlDateTime> ca_ = this.Measurement_Period();
			Period cb_ = ValidEncounter?.Period;
			CqlInterval<CqlDateTime> cc_ = FHIRHelpers_4_3_000.ToInterval(cb_);
			CqlInterval<CqlDateTime> cd_ = QICoreCommon_2_0_000.ToInterval(cc_ as object);
			bool? ce_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(ca_, cd_, default);

			return ce_;
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
			IEnumerable<MedicationRequest> e_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, d_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
			IEnumerable<MedicationRequest> g_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, d_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
			IEnumerable<MedicationRequest> h_ = context.Operators.Union<MedicationRequest>(e_, g_);
			IEnumerable<MedicationRequest> i_ = Status_1_6_000.Active_Medication(h_);
			bool? j_(MedicationRequest AntibioticOrdered)
			{
				Period n_ = EDOrAmbulatoryVisit?.Period;
				CqlInterval<CqlDateTime> o_ = FHIRHelpers_4_3_000.ToInterval(n_);
				CqlInterval<CqlDateTime> p_ = QICoreCommon_2_0_000.ToInterval(o_ as object);
				CqlDateTime q_ = context.Operators.Start(p_);
				FhirDateTime r_ = AntibioticOrdered?.AuthoredOnElement;
				CqlDateTime s_ = context.Operators.Convert<CqlDateTime>(r_);
				CqlQuantity t_ = context.Operators.Quantity(3m, "days");
				CqlDateTime u_ = context.Operators.Subtract(s_, t_);
				CqlDateTime w_ = context.Operators.Convert<CqlDateTime>(r_);
				CqlInterval<CqlDateTime> x_ = context.Operators.Interval(u_, w_, true, true);
				bool? y_ = context.Operators.In<CqlDateTime>(q_, x_, default);
				CqlDateTime aa_ = context.Operators.Convert<CqlDateTime>(r_);
				bool? ab_ = context.Operators.Not((bool?)(aa_ is null));
				bool? ac_ = context.Operators.And(y_, ab_);

				return ac_;
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
		IEnumerable<Condition> b_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
		CqlValueSet c_ = this.Acute_Tonsillitis();
		IEnumerable<Condition> d_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, c_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
		IEnumerable<Condition> e_ = context.Operators.Union<Condition>(b_, d_);
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
		IEnumerable<ValueTuple<Encounter, Condition>> c_ = context.Operators.CrossJoin<Encounter, Condition>(a_, b_);
		(Encounter VisitWithAntibiotic, Condition AcutePharyngitisTonsillitis)? d_(ValueTuple<Encounter, Condition> _valueTuple)
		{
			(Encounter VisitWithAntibiotic, Condition AcutePharyngitisTonsillitis)? j_ = (_valueTuple.Item1, _valueTuple.Item2);

			return j_;
		};
		IEnumerable<(Encounter VisitWithAntibiotic, Condition AcutePharyngitisTonsillitis)?> e_ = context.Operators.Select<ValueTuple<Encounter, Condition>, (Encounter VisitWithAntibiotic, Condition AcutePharyngitisTonsillitis)?>(c_, d_);
		bool? f_((Encounter VisitWithAntibiotic, Condition AcutePharyngitisTonsillitis)? tuple_ypyxedbbcqbdavhxvckuwmfh)
		{
			CqlInterval<CqlDateTime> k_ = QICoreCommon_2_0_000.ToPrevalenceInterval(tuple_ypyxedbbcqbdavhxvckuwmfh?.AcutePharyngitisTonsillitis);
			CqlDateTime l_ = context.Operators.Start(k_);
			Period m_ = tuple_ypyxedbbcqbdavhxvckuwmfh?.VisitWithAntibiotic?.Period;
			CqlInterval<CqlDateTime> n_ = FHIRHelpers_4_3_000.ToInterval(m_);
			CqlInterval<CqlDateTime> o_ = QICoreCommon_2_0_000.ToInterval(n_ as object);
			bool? p_ = context.Operators.In<CqlDateTime>(l_, o_, default);

			return p_;
		};
		IEnumerable<(Encounter VisitWithAntibiotic, Condition AcutePharyngitisTonsillitis)?> g_ = context.Operators.Where<(Encounter VisitWithAntibiotic, Condition AcutePharyngitisTonsillitis)?>(e_, f_);
		Encounter h_((Encounter VisitWithAntibiotic, Condition AcutePharyngitisTonsillitis)? tuple_ypyxedbbcqbdavhxvckuwmfh) => 
			tuple_ypyxedbbcqbdavhxvckuwmfh?.VisitWithAntibiotic;
		IEnumerable<Encounter> i_ = context.Operators.Select<(Encounter VisitWithAntibiotic, Condition AcutePharyngitisTonsillitis)?, Encounter>(g_, h_);

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
			Date g_ = f_?.BirthDateElement;
			string h_ = g_?.Value;
			CqlDate i_ = context.Operators.ConvertStringToDate(h_);
			CqlInterval<CqlDateTime> j_ = this.Measurement_Period();
			CqlDateTime k_ = context.Operators.Start(j_);
			CqlDate l_ = context.Operators.DateFrom(k_);
			int? m_ = context.Operators.CalculateAgeAt(i_, l_, "year");
			bool? n_ = context.Operators.GreaterOrEqual(m_, 3);

			return n_;
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
		IEnumerable<MedicationRequest> d_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, c_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
		IEnumerable<MedicationRequest> f_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, c_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
		IEnumerable<MedicationRequest> g_ = context.Operators.Union<MedicationRequest>(d_, f_);
		IEnumerable<Encounter> h_ = Antibiotic_1_5_000.Has_Antibiotic_Medication_History(b_, g_);
		IEnumerable<Encounter> i_ = context.Operators.Union<Encounter>(a_, h_);
		CqlValueSet k_ = this.Competing_Conditions_for_Respiratory_Conditions();
		IEnumerable<Condition> l_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, k_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
		IEnumerable<Encounter> m_ = Antibiotic_1_5_000.Has_Competing_Diagnosis_History(b_, l_);
		CqlValueSet o_ = this.Comorbid_Conditions_for_Respiratory_Conditions();
		IEnumerable<Condition> p_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, o_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
		IEnumerable<Encounter> q_ = Antibiotic_1_5_000.Has_Comorbid_Condition_History(b_, p_);
		IEnumerable<Encounter> r_ = context.Operators.Union<Encounter>(m_, q_);
		IEnumerable<Encounter> s_ = context.Operators.Union<Encounter>(i_, r_);

		return s_;
	}

    [CqlDeclaration("Denominator Exclusions")]
	public IEnumerable<Encounter> Denominator_Exclusions() => 
		__Denominator_Exclusions.Value;

	private IEnumerable<Observation> Group_A_Streptococcus_Lab_Test_With_Result_Value()
	{
		CqlValueSet a_ = this.Group_A_Streptococcus_Test();
		IEnumerable<Observation> b_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
		IEnumerable<Observation> c_ = Status_1_6_000.Final_Lab_Observation(b_);
		bool? d_(Observation GroupAStreptococcusTest)
		{
			DataType f_ = GroupAStreptococcusTest?.Value;
			object g_ = FHIRHelpers_4_3_000.ToValue(f_);
			bool? h_ = context.Operators.Not((bool?)(g_ is null));

			return h_;
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
		IEnumerable<ValueTuple<Observation, Encounter>> c_ = context.Operators.CrossJoin<Observation, Encounter>(a_, b_);
		(Observation GroupAStreptococcusTest, Encounter EncounterWithPharyngitis)? d_(ValueTuple<Observation, Encounter> _valueTuple)
		{
			(Observation GroupAStreptococcusTest, Encounter EncounterWithPharyngitis)? j_ = (_valueTuple.Item1, _valueTuple.Item2);

			return j_;
		};
		IEnumerable<(Observation GroupAStreptococcusTest, Encounter EncounterWithPharyngitis)?> e_ = context.Operators.Select<ValueTuple<Observation, Encounter>, (Observation GroupAStreptococcusTest, Encounter EncounterWithPharyngitis)?>(c_, d_);
		bool? f_((Observation GroupAStreptococcusTest, Encounter EncounterWithPharyngitis)? tuple_ffguysnebcxllexfcmjoehbij)
		{
			DataType k_ = tuple_ffguysnebcxllexfcmjoehbij?.GroupAStreptococcusTest?.Effective;
			object l_ = FHIRHelpers_4_3_000.ToValue(k_);
			CqlInterval<CqlDateTime> m_ = QICoreCommon_2_0_000.ToInterval(l_);
			CqlDateTime n_ = context.Operators.Start(m_);
			Period o_ = tuple_ffguysnebcxllexfcmjoehbij?.EncounterWithPharyngitis?.Period;
			CqlInterval<CqlDateTime> p_ = FHIRHelpers_4_3_000.ToInterval(o_);
			CqlDateTime q_ = context.Operators.End(p_);
			CqlQuantity r_ = context.Operators.Quantity(3m, "days");
			CqlDateTime s_ = context.Operators.Subtract(q_, r_);
			CqlInterval<CqlDateTime> u_ = FHIRHelpers_4_3_000.ToInterval(o_);
			CqlDateTime v_ = context.Operators.End(u_);
			CqlDateTime x_ = context.Operators.Add(v_, r_);
			CqlInterval<CqlDateTime> y_ = context.Operators.Interval(s_, x_, true, true);
			bool? z_ = context.Operators.In<CqlDateTime>(n_, y_, "day");

			return z_;
		};
		IEnumerable<(Observation GroupAStreptococcusTest, Encounter EncounterWithPharyngitis)?> g_ = context.Operators.Where<(Observation GroupAStreptococcusTest, Encounter EncounterWithPharyngitis)?>(e_, f_);
		Encounter h_((Observation GroupAStreptococcusTest, Encounter EncounterWithPharyngitis)? tuple_ffguysnebcxllexfcmjoehbij) => 
			tuple_ffguysnebcxllexfcmjoehbij?.EncounterWithPharyngitis;
		IEnumerable<Encounter> i_ = context.Operators.Select<(Observation GroupAStreptococcusTest, Encounter EncounterWithPharyngitis)?, Encounter>(g_, h_);

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
			Date g_ = f_?.BirthDateElement;
			string h_ = g_?.Value;
			CqlDate i_ = context.Operators.ConvertStringToDate(h_);
			CqlInterval<CqlDateTime> j_ = this.Measurement_Period();
			CqlDateTime k_ = context.Operators.Start(j_);
			CqlDate l_ = context.Operators.DateFrom(k_);
			int? m_ = context.Operators.CalculateAgeAt(i_, l_, "year");
			CqlInterval<int?> n_ = context.Operators.Interval(3, 17, true, true);
			bool? o_ = context.Operators.In<int?>(m_, n_, default);

			return o_;
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
		Encounter d_(Encounter EncounterWithPharyngitis) => 
			EncounterWithPharyngitis;
		IEnumerable<Encounter> e_ = context.Operators.Select<Encounter, Encounter>(c_, d_);

		return e_;
	}

    [CqlDeclaration("Stratification 3")]
	public IEnumerable<Encounter> Stratification_3() => 
		__Stratification_3.Value;

}
