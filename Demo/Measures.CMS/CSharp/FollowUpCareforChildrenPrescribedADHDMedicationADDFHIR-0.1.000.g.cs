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
[CqlLibrary("FollowUpCareforChildrenPrescribedADHDMedicationADDFHIR", "0.1.000")]
public class FollowUpCareforChildrenPrescribedADHDMedicationADDFHIR_0_1_000
{


    internal CqlContext context;

    #region Cached values

    internal Lazy<CqlValueSet> __Ambulatory;
    internal Lazy<CqlValueSet> __Atomoxetine;
    internal Lazy<CqlValueSet> __Behavioral_Health_Follow_up_Visit;
    internal Lazy<CqlValueSet> __Clonidine;
    internal Lazy<CqlValueSet> __Dexmethylphenidate;
    internal Lazy<CqlValueSet> __Dextroamphetamine;
    internal Lazy<CqlValueSet> __Encounter_Inpatient;
    internal Lazy<CqlValueSet> __Guanfacine;
    internal Lazy<CqlValueSet> __Home_Healthcare_Services;
    internal Lazy<CqlValueSet> __Initial_Hospital_Observation_Care;
    internal Lazy<CqlValueSet> __Lisdexamfetamine;
    internal Lazy<CqlValueSet> __Mental_Behavioral_and_Neurodevelopmental_Disorders;
    internal Lazy<CqlValueSet> __Methylphenidate;
    internal Lazy<CqlValueSet> __Narcolepsy;
    internal Lazy<CqlValueSet> __Office_Visit;
    internal Lazy<CqlValueSet> __Online_Assessments;
    internal Lazy<CqlValueSet> __Outpatient_Consultation;
    internal Lazy<CqlValueSet> __Preventive_Care_Services_Group_Counseling;
    internal Lazy<CqlValueSet> __Preventive_Care_Services_Individual_Counseling;
    internal Lazy<CqlValueSet> __Preventive_Care_Services__Initial_Office_Visit__0_to_17;
    internal Lazy<CqlValueSet> __Preventive_Care__Established_Office_Visit__0_to_17;
    internal Lazy<CqlValueSet> __Psych_Visit_Diagnostic_Evaluation;
    internal Lazy<CqlValueSet> __Psych_Visit_Psychotherapy;
    internal Lazy<CqlValueSet> __Psychotherapy_and_Pharmacologic_Management;
    internal Lazy<CqlValueSet> __Telephone_Visits;
    internal Lazy<CqlCode> ___24_HR_dexmethylphenidate_hydrochloride_40_MG_Extended_Release_Oral_Capsule;
    internal Lazy<CqlCode> __methamphetamine_hydrochloride_5_MG_Oral_Tablet;
    internal Lazy<CqlCode[]> __RXNORM;
    internal Lazy<CqlInterval<CqlDateTime>> __Measurement_Period;
    internal Lazy<Patient> __Patient;
    internal Lazy<CqlDateTime> __March_1_of_Year_Prior_to_Measurement_Period;
    internal Lazy<CqlDateTime> __Last_Calendar_Day_of_February_of_Measurement_Period;
    internal Lazy<CqlInterval<CqlDateTime>> __Intake_Period;
    internal Lazy<IEnumerable<(CqlDate startDate, nint _)?>> __ADHD_Medication_Prescribed_During_Intake_Period_and_Not_Previously_on_ADHD_Medication;
    internal Lazy<CqlDate> __First_ADHD_Medication_Prescribed_During_Intake_Period;
    internal Lazy<CqlDate> __IPSD;
    internal Lazy<IEnumerable<Encounter>> __Qualifying_Encounter;
    internal Lazy<IEnumerable<Encounter>> __Inpatient_Stay_with_Qualifying_Diagnosis;
    internal Lazy<IEnumerable<Encounter>> __Inpatient_Stay_with_Qualifying_Diagnosis_During_Initiation_Phase;
    internal Lazy<bool?> __Initial_Population_1;
    internal Lazy<bool?> __Denominator_1;
    internal Lazy<IEnumerable<Condition>> __Narcolepsy_Exclusion;
    internal Lazy<bool?> __Denominator_Exclusions;
    internal Lazy<IEnumerable<Encounter>> __Qualifying_Numerator_Encounter;
    internal Lazy<IEnumerable<Encounter>> __Encounter_During_Initiation_Phase;
    internal Lazy<bool?> __Numerator_1;
    internal Lazy<IEnumerable<CqlInterval<CqlDate>>> __ADHD_Medications_Taken_on_IPSD_or_During_Continuation_and_Maintenance_Phase;
    internal Lazy<int?> __ADHD_Cumulative_Medication_Duration;
    internal Lazy<bool?> __Has_ADHD_Cumulative_Medication_Duration_Greater_Than_or_Equal_to_210_Days;
    internal Lazy<IEnumerable<Encounter>> __Inpatient_Stay_with_Qualifying_Diagnosis_During_Continuation_and_Maintenance_Phase;
    internal Lazy<bool?> __Initial_Population_2;
    internal Lazy<bool?> __Denominator_2;
    internal Lazy<IEnumerable<CqlDate>> __Encounter_31_to_300_Days_into_Continuation_and_Maintenance_Phase;
    internal Lazy<bool?> __Two_or_More_Encounters_31_to_300_Days_into_Continuation_and_Maintenance_Phase;
    internal Lazy<IEnumerable<CqlDate>> __Online_Assessment_31_to_300_Days_into_Continuation_and_Maintenance_Phase;
    internal Lazy<bool?> __Numerator_2;
    internal Lazy<(IEnumerable<CqlCode> codes, string display)?> __SDE_Ethnicity;
    internal Lazy<IEnumerable<(CqlConcept code, CqlInterval<CqlDateTime> period)?>> __SDE_Payer;
    internal Lazy<(IEnumerable<CqlCode> codes, string display)?> __SDE_Race;
    internal Lazy<CqlCode> __SDE_Sex;

    #endregion
    public FollowUpCareforChildrenPrescribedADHDMedicationADDFHIR_0_1_000(CqlContext context)
    {
        this.context = context ?? throw new ArgumentNullException("context");

        FHIRHelpers_4_3_000 = new FHIRHelpers_4_3_000(context);
        SupplementalDataElements_3_4_000 = new SupplementalDataElements_3_4_000(context);
        QICoreCommon_2_0_000 = new QICoreCommon_2_0_000(context);
        CQMCommon_2_0_000 = new CQMCommon_2_0_000(context);
        Hospice_6_9_000 = new Hospice_6_9_000(context);
        CumulativeMedicationDuration_4_0_000 = new CumulativeMedicationDuration_4_0_000(context);

        __Ambulatory = new Lazy<CqlValueSet>(this.Ambulatory_Value);
        __Atomoxetine = new Lazy<CqlValueSet>(this.Atomoxetine_Value);
        __Behavioral_Health_Follow_up_Visit = new Lazy<CqlValueSet>(this.Behavioral_Health_Follow_up_Visit_Value);
        __Clonidine = new Lazy<CqlValueSet>(this.Clonidine_Value);
        __Dexmethylphenidate = new Lazy<CqlValueSet>(this.Dexmethylphenidate_Value);
        __Dextroamphetamine = new Lazy<CqlValueSet>(this.Dextroamphetamine_Value);
        __Encounter_Inpatient = new Lazy<CqlValueSet>(this.Encounter_Inpatient_Value);
        __Guanfacine = new Lazy<CqlValueSet>(this.Guanfacine_Value);
        __Home_Healthcare_Services = new Lazy<CqlValueSet>(this.Home_Healthcare_Services_Value);
        __Initial_Hospital_Observation_Care = new Lazy<CqlValueSet>(this.Initial_Hospital_Observation_Care_Value);
        __Lisdexamfetamine = new Lazy<CqlValueSet>(this.Lisdexamfetamine_Value);
        __Mental_Behavioral_and_Neurodevelopmental_Disorders = new Lazy<CqlValueSet>(this.Mental_Behavioral_and_Neurodevelopmental_Disorders_Value);
        __Methylphenidate = new Lazy<CqlValueSet>(this.Methylphenidate_Value);
        __Narcolepsy = new Lazy<CqlValueSet>(this.Narcolepsy_Value);
        __Office_Visit = new Lazy<CqlValueSet>(this.Office_Visit_Value);
        __Online_Assessments = new Lazy<CqlValueSet>(this.Online_Assessments_Value);
        __Outpatient_Consultation = new Lazy<CqlValueSet>(this.Outpatient_Consultation_Value);
        __Preventive_Care_Services_Group_Counseling = new Lazy<CqlValueSet>(this.Preventive_Care_Services_Group_Counseling_Value);
        __Preventive_Care_Services_Individual_Counseling = new Lazy<CqlValueSet>(this.Preventive_Care_Services_Individual_Counseling_Value);
        __Preventive_Care_Services__Initial_Office_Visit__0_to_17 = new Lazy<CqlValueSet>(this.Preventive_Care_Services__Initial_Office_Visit__0_to_17_Value);
        __Preventive_Care__Established_Office_Visit__0_to_17 = new Lazy<CqlValueSet>(this.Preventive_Care__Established_Office_Visit__0_to_17_Value);
        __Psych_Visit_Diagnostic_Evaluation = new Lazy<CqlValueSet>(this.Psych_Visit_Diagnostic_Evaluation_Value);
        __Psych_Visit_Psychotherapy = new Lazy<CqlValueSet>(this.Psych_Visit_Psychotherapy_Value);
        __Psychotherapy_and_Pharmacologic_Management = new Lazy<CqlValueSet>(this.Psychotherapy_and_Pharmacologic_Management_Value);
        __Telephone_Visits = new Lazy<CqlValueSet>(this.Telephone_Visits_Value);
        ___24_HR_dexmethylphenidate_hydrochloride_40_MG_Extended_Release_Oral_Capsule = new Lazy<CqlCode>(this._24_HR_dexmethylphenidate_hydrochloride_40_MG_Extended_Release_Oral_Capsule_Value);
        __methamphetamine_hydrochloride_5_MG_Oral_Tablet = new Lazy<CqlCode>(this.methamphetamine_hydrochloride_5_MG_Oral_Tablet_Value);
        __RXNORM = new Lazy<CqlCode[]>(this.RXNORM_Value);
        __Measurement_Period = new Lazy<CqlInterval<CqlDateTime>>(this.Measurement_Period_Value);
        __Patient = new Lazy<Patient>(this.Patient_Value);
        __March_1_of_Year_Prior_to_Measurement_Period = new Lazy<CqlDateTime>(this.March_1_of_Year_Prior_to_Measurement_Period_Value);
        __Last_Calendar_Day_of_February_of_Measurement_Period = new Lazy<CqlDateTime>(this.Last_Calendar_Day_of_February_of_Measurement_Period_Value);
        __Intake_Period = new Lazy<CqlInterval<CqlDateTime>>(this.Intake_Period_Value);
        __ADHD_Medication_Prescribed_During_Intake_Period_and_Not_Previously_on_ADHD_Medication = new Lazy<IEnumerable<(CqlDate startDate, nint _)?>>(this.ADHD_Medication_Prescribed_During_Intake_Period_and_Not_Previously_on_ADHD_Medication_Value);
        __First_ADHD_Medication_Prescribed_During_Intake_Period = new Lazy<CqlDate>(this.First_ADHD_Medication_Prescribed_During_Intake_Period_Value);
        __IPSD = new Lazy<CqlDate>(this.IPSD_Value);
        __Qualifying_Encounter = new Lazy<IEnumerable<Encounter>>(this.Qualifying_Encounter_Value);
        __Inpatient_Stay_with_Qualifying_Diagnosis = new Lazy<IEnumerable<Encounter>>(this.Inpatient_Stay_with_Qualifying_Diagnosis_Value);
        __Inpatient_Stay_with_Qualifying_Diagnosis_During_Initiation_Phase = new Lazy<IEnumerable<Encounter>>(this.Inpatient_Stay_with_Qualifying_Diagnosis_During_Initiation_Phase_Value);
        __Initial_Population_1 = new Lazy<bool?>(this.Initial_Population_1_Value);
        __Denominator_1 = new Lazy<bool?>(this.Denominator_1_Value);
        __Narcolepsy_Exclusion = new Lazy<IEnumerable<Condition>>(this.Narcolepsy_Exclusion_Value);
        __Denominator_Exclusions = new Lazy<bool?>(this.Denominator_Exclusions_Value);
        __Qualifying_Numerator_Encounter = new Lazy<IEnumerable<Encounter>>(this.Qualifying_Numerator_Encounter_Value);
        __Encounter_During_Initiation_Phase = new Lazy<IEnumerable<Encounter>>(this.Encounter_During_Initiation_Phase_Value);
        __Numerator_1 = new Lazy<bool?>(this.Numerator_1_Value);
        __ADHD_Medications_Taken_on_IPSD_or_During_Continuation_and_Maintenance_Phase = new Lazy<IEnumerable<CqlInterval<CqlDate>>>(this.ADHD_Medications_Taken_on_IPSD_or_During_Continuation_and_Maintenance_Phase_Value);
        __ADHD_Cumulative_Medication_Duration = new Lazy<int?>(this.ADHD_Cumulative_Medication_Duration_Value);
        __Has_ADHD_Cumulative_Medication_Duration_Greater_Than_or_Equal_to_210_Days = new Lazy<bool?>(this.Has_ADHD_Cumulative_Medication_Duration_Greater_Than_or_Equal_to_210_Days_Value);
        __Inpatient_Stay_with_Qualifying_Diagnosis_During_Continuation_and_Maintenance_Phase = new Lazy<IEnumerable<Encounter>>(this.Inpatient_Stay_with_Qualifying_Diagnosis_During_Continuation_and_Maintenance_Phase_Value);
        __Initial_Population_2 = new Lazy<bool?>(this.Initial_Population_2_Value);
        __Denominator_2 = new Lazy<bool?>(this.Denominator_2_Value);
        __Encounter_31_to_300_Days_into_Continuation_and_Maintenance_Phase = new Lazy<IEnumerable<CqlDate>>(this.Encounter_31_to_300_Days_into_Continuation_and_Maintenance_Phase_Value);
        __Two_or_More_Encounters_31_to_300_Days_into_Continuation_and_Maintenance_Phase = new Lazy<bool?>(this.Two_or_More_Encounters_31_to_300_Days_into_Continuation_and_Maintenance_Phase_Value);
        __Online_Assessment_31_to_300_Days_into_Continuation_and_Maintenance_Phase = new Lazy<IEnumerable<CqlDate>>(this.Online_Assessment_31_to_300_Days_into_Continuation_and_Maintenance_Phase_Value);
        __Numerator_2 = new Lazy<bool?>(this.Numerator_2_Value);
        __SDE_Ethnicity = new Lazy<(IEnumerable<CqlCode> codes, string display)?>(this.SDE_Ethnicity_Value);
        __SDE_Payer = new Lazy<IEnumerable<(CqlConcept code, CqlInterval<CqlDateTime> period)?>>(this.SDE_Payer_Value);
        __SDE_Race = new Lazy<(IEnumerable<CqlCode> codes, string display)?>(this.SDE_Race_Value);
        __SDE_Sex = new Lazy<CqlCode>(this.SDE_Sex_Value);
    }
    #region Dependencies

    public FHIRHelpers_4_3_000 FHIRHelpers_4_3_000 { get; }
    public SupplementalDataElements_3_4_000 SupplementalDataElements_3_4_000 { get; }
    public QICoreCommon_2_0_000 QICoreCommon_2_0_000 { get; }
    public CQMCommon_2_0_000 CQMCommon_2_0_000 { get; }
    public Hospice_6_9_000 Hospice_6_9_000 { get; }
    public CumulativeMedicationDuration_4_0_000 CumulativeMedicationDuration_4_0_000 { get; }

    #endregion

	private CqlValueSet Ambulatory_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.122.12.1003", default);

    [CqlDeclaration("Ambulatory")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.122.12.1003")]
	public CqlValueSet Ambulatory() => 
		__Ambulatory.Value;

	private CqlValueSet Atomoxetine_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.1170", default);

    [CqlDeclaration("Atomoxetine")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.1170")]
	public CqlValueSet Atomoxetine() => 
		__Atomoxetine.Value;

	private CqlValueSet Behavioral_Health_Follow_up_Visit_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1054", default);

    [CqlDeclaration("Behavioral Health Follow up Visit")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1054")]
	public CqlValueSet Behavioral_Health_Follow_up_Visit() => 
		__Behavioral_Health_Follow_up_Visit.Value;

	private CqlValueSet Clonidine_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.1171", default);

    [CqlDeclaration("Clonidine")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.1171")]
	public CqlValueSet Clonidine() => 
		__Clonidine.Value;

	private CqlValueSet Dexmethylphenidate_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.1172", default);

    [CqlDeclaration("Dexmethylphenidate")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.1172")]
	public CqlValueSet Dexmethylphenidate() => 
		__Dexmethylphenidate.Value;

	private CqlValueSet Dextroamphetamine_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.1173", default);

    [CqlDeclaration("Dextroamphetamine")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.1173")]
	public CqlValueSet Dextroamphetamine() => 
		__Dextroamphetamine.Value;

	private CqlValueSet Encounter_Inpatient_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.666.5.307", default);

    [CqlDeclaration("Encounter Inpatient")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.666.5.307")]
	public CqlValueSet Encounter_Inpatient() => 
		__Encounter_Inpatient.Value;

	private CqlValueSet Guanfacine_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.196.11.1252", default);

    [CqlDeclaration("Guanfacine")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.196.11.1252")]
	public CqlValueSet Guanfacine() => 
		__Guanfacine.Value;

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

	private CqlValueSet Lisdexamfetamine_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.1174", default);

    [CqlDeclaration("Lisdexamfetamine")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.1174")]
	public CqlValueSet Lisdexamfetamine() => 
		__Lisdexamfetamine.Value;

	private CqlValueSet Mental_Behavioral_and_Neurodevelopmental_Disorders_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.105.12.1203", default);

    [CqlDeclaration("Mental Behavioral and Neurodevelopmental Disorders")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.105.12.1203")]
	public CqlValueSet Mental_Behavioral_and_Neurodevelopmental_Disorders() => 
		__Mental_Behavioral_and_Neurodevelopmental_Disorders.Value;

	private CqlValueSet Methylphenidate_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.1176", default);

    [CqlDeclaration("Methylphenidate")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.1176")]
	public CqlValueSet Methylphenidate() => 
		__Methylphenidate.Value;

	private CqlValueSet Narcolepsy_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.114.12.1011", default);

    [CqlDeclaration("Narcolepsy")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.114.12.1011")]
	public CqlValueSet Narcolepsy() => 
		__Narcolepsy.Value;

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

	private CqlValueSet Psychotherapy_and_Pharmacologic_Management_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1055", default);

    [CqlDeclaration("Psychotherapy and Pharmacologic Management")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1055")]
	public CqlValueSet Psychotherapy_and_Pharmacologic_Management() => 
		__Psychotherapy_and_Pharmacologic_Management.Value;

	private CqlValueSet Telephone_Visits_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1080", default);

    [CqlDeclaration("Telephone Visits")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1080")]
	public CqlValueSet Telephone_Visits() => 
		__Telephone_Visits.Value;

	private CqlCode _24_HR_dexmethylphenidate_hydrochloride_40_MG_Extended_Release_Oral_Capsule_Value() => 
		new CqlCode("1006608", "http://www.nlm.nih.gov/research/umls/rxnorm", default, default);

    [CqlDeclaration("24 HR dexmethylphenidate hydrochloride 40 MG Extended Release Oral Capsule")]
	public CqlCode _24_HR_dexmethylphenidate_hydrochloride_40_MG_Extended_Release_Oral_Capsule() => 
		___24_HR_dexmethylphenidate_hydrochloride_40_MG_Extended_Release_Oral_Capsule.Value;

	private CqlCode methamphetamine_hydrochloride_5_MG_Oral_Tablet_Value() => 
		new CqlCode("977860", "http://www.nlm.nih.gov/research/umls/rxnorm", default, default);

    [CqlDeclaration("methamphetamine hydrochloride 5 MG Oral Tablet")]
	public CqlCode methamphetamine_hydrochloride_5_MG_Oral_Tablet() => 
		__methamphetamine_hydrochloride_5_MG_Oral_Tablet.Value;

	private CqlCode[] RXNORM_Value()
	{
		CqlCode[] a_ = [
			new CqlCode("1006608", "http://www.nlm.nih.gov/research/umls/rxnorm", default, default),
			new CqlCode("977860", "http://www.nlm.nih.gov/research/umls/rxnorm", default, default),
		];

		return a_;
	}

    [CqlDeclaration("RXNORM")]
	public CqlCode[] RXNORM() => 
		__RXNORM.Value;

	private CqlInterval<CqlDateTime> Measurement_Period_Value()
	{
		CqlDateTime a_ = context.Operators.DateTime(2025, 1, 1, 0, 0, 0, 0, default);
		CqlDateTime b_ = context.Operators.DateTime(2026, 1, 1, 0, 0, 0, 0, default);
		CqlInterval<CqlDateTime> c_ = context.Operators.Interval(a_, b_, true, false);
		object d_ = context.ResolveParameter("FollowUpCareforChildrenPrescribedADHDMedicationADDFHIR-0.1.000", "Measurement Period", c_);

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

	private CqlDateTime March_1_of_Year_Prior_to_Measurement_Period_Value()
	{
		CqlInterval<CqlDateTime> a_ = this.Measurement_Period();
		CqlDateTime b_ = context.Operators.Start(a_);
		int? c_ = context.Operators.DateTimeComponentFrom(b_, "year");
		int? d_ = context.Operators.Subtract(c_, 1);
		decimal? e_ = context.Operators.ConvertIntegerToDecimal(0);
		CqlDateTime f_ = context.Operators.DateTime(d_, 3, 1, 0, 0, 0, 0, e_);

		return f_;
	}

    [CqlDeclaration("March 1 of Year Prior to Measurement Period")]
	public CqlDateTime March_1_of_Year_Prior_to_Measurement_Period() => 
		__March_1_of_Year_Prior_to_Measurement_Period.Value;

	private CqlDateTime Last_Calendar_Day_of_February_of_Measurement_Period_Value()
	{
		CqlInterval<CqlDateTime> a_ = this.Measurement_Period();
		CqlDateTime b_ = context.Operators.Start(a_);
		int? c_ = context.Operators.DateTimeComponentFrom(b_, "year");
		decimal? d_ = context.Operators.ConvertIntegerToDecimal(0);
		CqlDateTime e_ = context.Operators.DateTime(c_, 3, 1, 23, 59, 59, 0, d_);
		CqlQuantity f_ = context.Operators.Quantity(1m, "day");
		CqlDateTime g_ = context.Operators.Subtract(e_, f_);

		return g_;
	}

    [CqlDeclaration("Last Calendar Day of February of Measurement Period")]
	public CqlDateTime Last_Calendar_Day_of_February_of_Measurement_Period() => 
		__Last_Calendar_Day_of_February_of_Measurement_Period.Value;

	private CqlInterval<CqlDateTime> Intake_Period_Value()
	{
		CqlDateTime a_ = this.March_1_of_Year_Prior_to_Measurement_Period();
		CqlDateTime b_ = this.Last_Calendar_Day_of_February_of_Measurement_Period();
		CqlInterval<CqlDateTime> c_ = context.Operators.Interval(a_, b_, true, true);

		return c_;
	}

    [CqlDeclaration("Intake Period")]
	public CqlInterval<CqlDateTime> Intake_Period() => 
		__Intake_Period.Value;

	private IEnumerable<(CqlDate startDate, nint _)?> ADHD_Medication_Prescribed_During_Intake_Period_and_Not_Previously_on_ADHD_Medication_Value()
	{
		CqlValueSet a_ = this.Atomoxetine();
		IEnumerable<MedicationRequest> b_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
		IEnumerable<MedicationRequest> d_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
		IEnumerable<MedicationRequest> e_ = context.Operators.Union<MedicationRequest>(b_, d_);
		CqlValueSet f_ = this.Clonidine();
		IEnumerable<MedicationRequest> g_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, f_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
		IEnumerable<MedicationRequest> i_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, f_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
		IEnumerable<MedicationRequest> j_ = context.Operators.Union<MedicationRequest>(g_, i_);
		IEnumerable<MedicationRequest> k_ = context.Operators.Union<MedicationRequest>(e_, j_);
		CqlValueSet l_ = this.Dexmethylphenidate();
		IEnumerable<MedicationRequest> m_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, l_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
		IEnumerable<MedicationRequest> o_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, l_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
		IEnumerable<MedicationRequest> p_ = context.Operators.Union<MedicationRequest>(m_, o_);
		IEnumerable<MedicationRequest> q_ = context.Operators.Union<MedicationRequest>(k_, p_);
		CqlValueSet r_ = this.Dextroamphetamine();
		IEnumerable<MedicationRequest> s_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, r_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
		IEnumerable<MedicationRequest> u_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, r_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
		IEnumerable<MedicationRequest> v_ = context.Operators.Union<MedicationRequest>(s_, u_);
		IEnumerable<MedicationRequest> w_ = context.Operators.Union<MedicationRequest>(q_, v_);
		CqlValueSet x_ = this.Lisdexamfetamine();
		IEnumerable<MedicationRequest> y_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, x_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
		IEnumerable<MedicationRequest> aa_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, x_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
		IEnumerable<MedicationRequest> ab_ = context.Operators.Union<MedicationRequest>(y_, aa_);
		IEnumerable<MedicationRequest> ac_ = context.Operators.Union<MedicationRequest>(w_, ab_);
		CqlCode ad_ = this.methamphetamine_hydrochloride_5_MG_Oral_Tablet();
		IEnumerable<CqlCode> ae_ = context.Operators.ToList<CqlCode>(ad_);
		IEnumerable<MedicationRequest> af_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, default, ae_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
		IEnumerable<CqlCode> ah_ = context.Operators.ToList<CqlCode>(ad_);
		IEnumerable<MedicationRequest> ai_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, default, ah_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
		IEnumerable<MedicationRequest> aj_ = context.Operators.Union<MedicationRequest>(af_, ai_);
		IEnumerable<MedicationRequest> ak_ = context.Operators.Union<MedicationRequest>(ac_, aj_);
		CqlValueSet al_ = this.Methylphenidate();
		IEnumerable<MedicationRequest> am_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, al_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
		IEnumerable<MedicationRequest> ao_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, al_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
		IEnumerable<MedicationRequest> ap_ = context.Operators.Union<MedicationRequest>(am_, ao_);
		IEnumerable<MedicationRequest> aq_ = context.Operators.Union<MedicationRequest>(ak_, ap_);
		CqlValueSet ar_ = this.Guanfacine();
		IEnumerable<MedicationRequest> as_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, ar_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
		IEnumerable<MedicationRequest> au_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, ar_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
		IEnumerable<MedicationRequest> av_ = context.Operators.Union<MedicationRequest>(as_, au_);
		IEnumerable<MedicationRequest> aw_ = context.Operators.Union<MedicationRequest>(aq_, av_);
		bool? ax_(MedicationRequest ADHDMedications)
		{
			CqlInterval<CqlDate> df_ = CumulativeMedicationDuration_4_0_000.MedicationRequestPeriod(ADHDMedications);
			CqlDate dg_ = context.Operators.Start(df_);
			CqlDateTime dh_ = context.Operators.ConvertDateToDateTime(dg_);
			CqlInterval<CqlDateTime> di_ = this.Intake_Period();
			bool? dj_ = context.Operators.In<CqlDateTime>(dh_, di_, default);

			return dj_;
		};
		IEnumerable<MedicationRequest> ay_ = context.Operators.Where<MedicationRequest>(aw_, ax_);
		IEnumerable<MedicationRequest> ba_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
		IEnumerable<MedicationRequest> bc_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
		IEnumerable<MedicationRequest> bd_ = context.Operators.Union<MedicationRequest>(ba_, bc_);
		IEnumerable<MedicationRequest> bf_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, f_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
		IEnumerable<MedicationRequest> bh_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, f_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
		IEnumerable<MedicationRequest> bi_ = context.Operators.Union<MedicationRequest>(bf_, bh_);
		IEnumerable<MedicationRequest> bj_ = context.Operators.Union<MedicationRequest>(bd_, bi_);
		IEnumerable<MedicationRequest> bl_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, l_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
		IEnumerable<MedicationRequest> bn_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, l_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
		IEnumerable<MedicationRequest> bo_ = context.Operators.Union<MedicationRequest>(bl_, bn_);
		IEnumerable<MedicationRequest> bp_ = context.Operators.Union<MedicationRequest>(bj_, bo_);
		IEnumerable<MedicationRequest> br_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, r_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
		IEnumerable<MedicationRequest> bt_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, r_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
		IEnumerable<MedicationRequest> bu_ = context.Operators.Union<MedicationRequest>(br_, bt_);
		IEnumerable<MedicationRequest> bv_ = context.Operators.Union<MedicationRequest>(bp_, bu_);
		IEnumerable<MedicationRequest> bx_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, x_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
		IEnumerable<MedicationRequest> bz_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, x_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
		IEnumerable<MedicationRequest> ca_ = context.Operators.Union<MedicationRequest>(bx_, bz_);
		IEnumerable<MedicationRequest> cb_ = context.Operators.Union<MedicationRequest>(bv_, ca_);
		IEnumerable<CqlCode> cd_ = context.Operators.ToList<CqlCode>(ad_);
		IEnumerable<MedicationRequest> ce_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, default, cd_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
		IEnumerable<CqlCode> cg_ = context.Operators.ToList<CqlCode>(ad_);
		IEnumerable<MedicationRequest> ch_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, default, cg_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
		IEnumerable<MedicationRequest> ci_ = context.Operators.Union<MedicationRequest>(ce_, ch_);
		IEnumerable<MedicationRequest> cj_ = context.Operators.Union<MedicationRequest>(cb_, ci_);
		IEnumerable<MedicationRequest> cl_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, al_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
		IEnumerable<MedicationRequest> cn_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, al_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
		IEnumerable<MedicationRequest> co_ = context.Operators.Union<MedicationRequest>(cl_, cn_);
		IEnumerable<MedicationRequest> cp_ = context.Operators.Union<MedicationRequest>(cj_, co_);
		IEnumerable<MedicationRequest> cr_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, ar_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
		IEnumerable<MedicationRequest> ct_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, ar_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
		IEnumerable<MedicationRequest> cu_ = context.Operators.Union<MedicationRequest>(cr_, ct_);
		IEnumerable<MedicationRequest> cv_ = context.Operators.Union<MedicationRequest>(cp_, cu_);
		bool? cw_(MedicationRequest ADHDMedications)
		{
			CqlInterval<CqlDate> dk_ = CumulativeMedicationDuration_4_0_000.MedicationRequestPeriod(ADHDMedications);
			CqlDate dl_ = context.Operators.Start(dk_);
			CqlDateTime dm_ = context.Operators.ConvertDateToDateTime(dl_);
			CqlInterval<CqlDateTime> dn_ = this.Intake_Period();
			bool? do_ = context.Operators.In<CqlDateTime>(dm_, dn_, default);

			return do_;
		};
		IEnumerable<MedicationRequest> cx_ = context.Operators.Where<MedicationRequest>(cv_, cw_);
		IEnumerable<MedicationRequest> cy_(MedicationRequest ADHDMedicationOrder)
		{
			CqlValueSet dp_ = this.Atomoxetine();
			IEnumerable<MedicationRequest> dq_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, dp_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
			IEnumerable<MedicationRequest> ds_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, dp_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
			IEnumerable<MedicationRequest> dt_ = context.Operators.Union<MedicationRequest>(dq_, ds_);
			CqlValueSet du_ = this.Clonidine();
			IEnumerable<MedicationRequest> dv_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, du_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
			IEnumerable<MedicationRequest> dx_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, du_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
			IEnumerable<MedicationRequest> dy_ = context.Operators.Union<MedicationRequest>(dv_, dx_);
			IEnumerable<MedicationRequest> dz_ = context.Operators.Union<MedicationRequest>(dt_, dy_);
			CqlValueSet ea_ = this.Dexmethylphenidate();
			IEnumerable<MedicationRequest> eb_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, ea_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
			IEnumerable<MedicationRequest> ed_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, ea_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
			IEnumerable<MedicationRequest> ee_ = context.Operators.Union<MedicationRequest>(eb_, ed_);
			IEnumerable<MedicationRequest> ef_ = context.Operators.Union<MedicationRequest>(dz_, ee_);
			CqlValueSet eg_ = this.Dextroamphetamine();
			IEnumerable<MedicationRequest> eh_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, eg_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
			IEnumerable<MedicationRequest> ej_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, eg_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
			IEnumerable<MedicationRequest> ek_ = context.Operators.Union<MedicationRequest>(eh_, ej_);
			IEnumerable<MedicationRequest> el_ = context.Operators.Union<MedicationRequest>(ef_, ek_);
			CqlValueSet em_ = this.Lisdexamfetamine();
			IEnumerable<MedicationRequest> en_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, em_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
			IEnumerable<MedicationRequest> ep_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, em_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
			IEnumerable<MedicationRequest> eq_ = context.Operators.Union<MedicationRequest>(en_, ep_);
			IEnumerable<MedicationRequest> er_ = context.Operators.Union<MedicationRequest>(el_, eq_);
			CqlCode es_ = this.methamphetamine_hydrochloride_5_MG_Oral_Tablet();
			IEnumerable<CqlCode> et_ = context.Operators.ToList<CqlCode>(es_);
			IEnumerable<MedicationRequest> eu_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, default, et_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
			IEnumerable<CqlCode> ew_ = context.Operators.ToList<CqlCode>(es_);
			IEnumerable<MedicationRequest> ex_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, default, ew_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
			IEnumerable<MedicationRequest> ey_ = context.Operators.Union<MedicationRequest>(eu_, ex_);
			IEnumerable<MedicationRequest> ez_ = context.Operators.Union<MedicationRequest>(er_, ey_);
			CqlValueSet fa_ = this.Methylphenidate();
			IEnumerable<MedicationRequest> fb_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, fa_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
			IEnumerable<MedicationRequest> fd_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, fa_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
			IEnumerable<MedicationRequest> fe_ = context.Operators.Union<MedicationRequest>(fb_, fd_);
			IEnumerable<MedicationRequest> ff_ = context.Operators.Union<MedicationRequest>(ez_, fe_);
			CqlValueSet fg_ = this.Guanfacine();
			IEnumerable<MedicationRequest> fh_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, fg_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
			IEnumerable<MedicationRequest> fj_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, fg_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
			IEnumerable<MedicationRequest> fk_ = context.Operators.Union<MedicationRequest>(fh_, fj_);
			IEnumerable<MedicationRequest> fl_ = context.Operators.Union<MedicationRequest>(ff_, fk_);
			bool? fm_(MedicationRequest ActiveADHDMedication)
			{
				CqlInterval<CqlDate> fq_ = CumulativeMedicationDuration_4_0_000.MedicationRequestPeriod(ActiveADHDMedication);
				CqlInterval<CqlDate> fr_ = CumulativeMedicationDuration_4_0_000.MedicationRequestPeriod(ADHDMedicationOrder);
				CqlDate fs_ = context.Operators.Start(fr_);
				CqlDateTime ft_ = context.Operators.ConvertDateToDateTime(fs_);
				CqlDate fu_ = context.Operators.DateFrom(ft_);
				CqlQuantity fv_ = context.Operators.Quantity(120m, "days");
				CqlDate fw_ = context.Operators.Subtract(fu_, fv_);
				CqlDate fy_ = context.Operators.Start(fr_);
				CqlDateTime fz_ = context.Operators.ConvertDateToDateTime(fy_);
				CqlDate ga_ = context.Operators.DateFrom(fz_);
				CqlInterval<CqlDate> gb_ = context.Operators.Interval(fw_, ga_, true, false);
				bool? gc_ = context.Operators.Overlaps(fq_, gb_, default);

				return gc_;
			};
			IEnumerable<MedicationRequest> fn_ = context.Operators.Where<MedicationRequest>(fl_, fm_);
			MedicationRequest fo_(MedicationRequest ActiveADHDMedication) => 
				ADHDMedicationOrder;
			IEnumerable<MedicationRequest> fp_ = context.Operators.Select<MedicationRequest, MedicationRequest>(fn_, fo_);

			return fp_;
		};
		IEnumerable<MedicationRequest> cz_ = context.Operators.SelectMany<MedicationRequest, MedicationRequest>(cx_, cy_);
		IEnumerable<MedicationRequest> da_ = context.Operators.Except<MedicationRequest>(ay_, cz_);
		(CqlDate startDate, nint _)? db_(MedicationRequest QualifyingMed)
		{
			CqlInterval<CqlDate> gd_ = CumulativeMedicationDuration_4_0_000.MedicationRequestPeriod(QualifyingMed);
			CqlDate ge_ = context.Operators.Start(gd_);
			(CqlDate startDate, nint _)? gf_ = (ge_, default);

			return gf_;
		};
		IEnumerable<(CqlDate startDate, nint _)?> dc_ = context.Operators.Select<MedicationRequest, (CqlDate startDate, nint _)?>(da_, db_);
		object dd_((CqlDate startDate, nint _)? @this)
		{
			CqlDate gg_ = @this?.startDate;

			return gg_;
		};
		IEnumerable<(CqlDate startDate, nint _)?> de_ = context.Operators.SortBy<(CqlDate startDate, nint _)?>(dc_, dd_, System.ComponentModel.ListSortDirection.Ascending);

		return de_;
	}

    [CqlDeclaration("ADHD Medication Prescribed During Intake Period and Not Previously on ADHD Medication")]
	public IEnumerable<(CqlDate startDate, nint _)?> ADHD_Medication_Prescribed_During_Intake_Period_and_Not_Previously_on_ADHD_Medication() => 
		__ADHD_Medication_Prescribed_During_Intake_Period_and_Not_Previously_on_ADHD_Medication.Value;

	private CqlDate First_ADHD_Medication_Prescribed_During_Intake_Period_Value()
	{
		IEnumerable<(CqlDate startDate, nint _)?> a_ = this.ADHD_Medication_Prescribed_During_Intake_Period_and_Not_Previously_on_ADHD_Medication();
		bool? b_((CqlDate startDate, nint _)? @this)
		{
			CqlDate g_ = @this?.startDate;
			bool? h_ = context.Operators.Not((bool?)(g_ is null));

			return h_;
		};
		IEnumerable<(CqlDate startDate, nint _)?> c_ = context.Operators.Where<(CqlDate startDate, nint _)?>(a_, b_);
		CqlDate d_((CqlDate startDate, nint _)? @this)
		{
			CqlDate i_ = @this?.startDate;

			return i_;
		};
		IEnumerable<CqlDate> e_ = context.Operators.Select<(CqlDate startDate, nint _)?, CqlDate>(c_, d_);
		CqlDate f_ = context.Operators.First<CqlDate>(e_);

		return f_;
	}

    [CqlDeclaration("First ADHD Medication Prescribed During Intake Period")]
	public CqlDate First_ADHD_Medication_Prescribed_During_Intake_Period() => 
		__First_ADHD_Medication_Prescribed_During_Intake_Period.Value;

	private CqlDate IPSD_Value()
	{
		CqlDate a_ = this.First_ADHD_Medication_Prescribed_During_Intake_Period();

		return a_;
	}

    [CqlDeclaration("IPSD")]
	public CqlDate IPSD() => 
		__IPSD.Value;

	private IEnumerable<Encounter> Qualifying_Encounter_Value()
	{
		CqlValueSet a_ = this.Office_Visit();
		IEnumerable<Encounter> b_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
		CqlValueSet c_ = this.Home_Healthcare_Services();
		IEnumerable<Encounter> d_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, c_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
		IEnumerable<Encounter> e_ = context.Operators.Union<Encounter>(b_, d_);
		CqlValueSet f_ = this.Preventive_Care__Established_Office_Visit__0_to_17();
		IEnumerable<Encounter> g_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, f_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
		CqlValueSet h_ = this.Preventive_Care_Services__Initial_Office_Visit__0_to_17();
		IEnumerable<Encounter> i_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, h_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
		IEnumerable<Encounter> j_ = context.Operators.Union<Encounter>(g_, i_);
		IEnumerable<Encounter> k_ = context.Operators.Union<Encounter>(e_, j_);
		bool? l_(Encounter ValidEncounters)
		{
			CqlDate n_ = this.IPSD();
			CqlQuantity o_ = context.Operators.Quantity(6m, "months");
			CqlDate p_ = context.Operators.Subtract(n_, o_);
			CqlInterval<CqlDate> r_ = context.Operators.Interval(p_, n_, true, true);
			CqlDate s_ = r_?.low;
			CqlDateTime t_ = context.Operators.ConvertDateToDateTime(s_);
			CqlDate w_ = context.Operators.Subtract(n_, o_);
			CqlInterval<CqlDate> y_ = context.Operators.Interval(w_, n_, true, true);
			CqlDate z_ = y_?.high;
			CqlDateTime aa_ = context.Operators.ConvertDateToDateTime(z_);
			CqlDate ad_ = context.Operators.Subtract(n_, o_);
			CqlInterval<CqlDate> af_ = context.Operators.Interval(ad_, n_, true, true);
			bool? ag_ = af_?.lowClosed;
			CqlDate aj_ = context.Operators.Subtract(n_, o_);
			CqlInterval<CqlDate> al_ = context.Operators.Interval(aj_, n_, true, true);
			bool? am_ = al_?.highClosed;
			CqlInterval<CqlDateTime> an_ = context.Operators.Interval(t_, aa_, ag_, am_);
			Period ao_ = ValidEncounters?.Period;
			CqlInterval<CqlDateTime> ap_ = FHIRHelpers_4_3_000.ToInterval(ao_);
			CqlInterval<CqlDateTime> aq_ = QICoreCommon_2_0_000.ToInterval(ap_ as object);
			bool? ar_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(an_, aq_, "day");

			return ar_;
		};
		IEnumerable<Encounter> m_ = context.Operators.Where<Encounter>(k_, l_);

		return m_;
	}

    [CqlDeclaration("Qualifying Encounter")]
	public IEnumerable<Encounter> Qualifying_Encounter() => 
		__Qualifying_Encounter.Value;

    [CqlDeclaration("PrincipalDiagnosis")]
	public IEnumerable<Condition> PrincipalDiagnosis(Encounter Encounter)
	{
		List<Encounter.DiagnosisComponent> a_ = Encounter?.Diagnosis;
		bool? b_(Encounter.DiagnosisComponent D)
		{
			PositiveInt f_ = D?.RankElement;
			int? g_ = f_?.Value;
			bool? h_ = context.Operators.Equal(g_, 1);

			return h_;
		};
		IEnumerable<Encounter.DiagnosisComponent> c_ = context.Operators.Where<Encounter.DiagnosisComponent>((IEnumerable<Encounter.DiagnosisComponent>)a_, b_);
		Condition d_(Encounter.DiagnosisComponent PD)
		{
			IEnumerable<Condition> i_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
			bool? j_(Condition C)
			{
				Id m_ = C?.IdElement;
				string n_ = m_?.Value;
				ResourceReference o_ = PD?.Condition;
				FhirString p_ = o_?.ReferenceElement;
				string q_ = p_?.Value;
				string r_ = QICoreCommon_2_0_000.getId(q_);
				bool? s_ = context.Operators.Equal(n_, r_);

				return s_;
			};
			IEnumerable<Condition> k_ = context.Operators.Where<Condition>(i_, j_);
			Condition l_ = context.Operators.SingletonFrom<Condition>(k_);

			return l_;
		};
		IEnumerable<Condition> e_ = context.Operators.Select<Encounter.DiagnosisComponent, Condition>(c_, d_);

		return e_;
	}

	private IEnumerable<Encounter> Inpatient_Stay_with_Qualifying_Diagnosis_Value()
	{
		CqlValueSet a_ = this.Encounter_Inpatient();
		IEnumerable<Encounter> b_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
		bool? c_(Encounter InpatientStay)
		{
			IEnumerable<Condition> e_ = this.PrincipalDiagnosis(InpatientStay);
			bool? f_(Condition EncounterDiagnosis)
			{
				CodeableConcept i_ = EncounterDiagnosis?.Code;
				CqlConcept j_ = FHIRHelpers_4_3_000.ToConcept(i_);
				CqlValueSet k_ = this.Mental_Behavioral_and_Neurodevelopmental_Disorders();
				bool? l_ = context.Operators.ConceptInValueSet(j_, k_);

				return l_;
			};
			IEnumerable<Condition> g_ = context.Operators.Where<Condition>(e_, f_);
			bool? h_ = context.Operators.Exists<Condition>(g_);

			return h_;
		};
		IEnumerable<Encounter> d_ = context.Operators.Where<Encounter>(b_, c_);

		return d_;
	}

    [CqlDeclaration("Inpatient Stay with Qualifying Diagnosis")]
	public IEnumerable<Encounter> Inpatient_Stay_with_Qualifying_Diagnosis() => 
		__Inpatient_Stay_with_Qualifying_Diagnosis.Value;

	private IEnumerable<Encounter> Inpatient_Stay_with_Qualifying_Diagnosis_During_Initiation_Phase_Value()
	{
		IEnumerable<Encounter> a_ = this.Inpatient_Stay_with_Qualifying_Diagnosis();
		bool? b_(Encounter InpatientStay)
		{
			Period d_ = InpatientStay?.Period;
			CqlInterval<CqlDateTime> e_ = FHIRHelpers_4_3_000.ToInterval(d_);
			CqlInterval<CqlDate> f_ = CQMCommon_2_0_000.ToDateInterval(e_);
			CqlDate g_ = context.Operators.Start(f_);
			CqlDate h_ = this.IPSD();
			CqlQuantity j_ = context.Operators.Quantity(30m, "days");
			CqlDate k_ = context.Operators.Add(h_, j_);
			CqlInterval<CqlDate> l_ = context.Operators.Interval(h_, k_, false, true);
			bool? m_ = context.Operators.In<CqlDate>(g_, l_, "day");
			bool? o_ = context.Operators.Not((bool?)(h_ is null));
			bool? p_ = context.Operators.And(m_, o_);

			return p_;
		};
		IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);

		return c_;
	}

    [CqlDeclaration("Inpatient Stay with Qualifying Diagnosis During Initiation Phase")]
	public IEnumerable<Encounter> Inpatient_Stay_with_Qualifying_Diagnosis_During_Initiation_Phase() => 
		__Inpatient_Stay_with_Qualifying_Diagnosis_During_Initiation_Phase.Value;

	private bool? Initial_Population_1_Value()
	{
		Patient a_ = this.Patient();
		Date b_ = a_?.BirthDateElement;
		string c_ = b_?.Value;
		CqlDate d_ = context.Operators.ConvertStringToDate(c_);
		CqlInterval<CqlDateTime> e_ = this.Intake_Period();
		CqlDateTime f_ = context.Operators.Start(e_);
		CqlDate g_ = context.Operators.DateFrom(f_);
		int? h_ = context.Operators.CalculateAgeAt(d_, g_, "year");
		bool? i_ = context.Operators.GreaterOrEqual(h_, 6);
		Date k_ = a_?.BirthDateElement;
		string l_ = k_?.Value;
		CqlDate m_ = context.Operators.ConvertStringToDate(l_);
		CqlDateTime o_ = context.Operators.End(e_);
		CqlDate p_ = context.Operators.DateFrom(o_);
		int? q_ = context.Operators.CalculateAgeAt(m_, p_, "year");
		bool? r_ = context.Operators.LessOrEqual(q_, 12);
		bool? s_ = context.Operators.And(i_, r_);
		IEnumerable<Encounter> t_ = this.Qualifying_Encounter();
		bool? u_ = context.Operators.Exists<Encounter>(t_);
		bool? v_ = context.Operators.And(s_, u_);
		CqlDate w_ = this.First_ADHD_Medication_Prescribed_During_Intake_Period();
		bool? x_ = context.Operators.Not((bool?)(w_ is null));
		bool? y_ = context.Operators.And(v_, x_);
		IEnumerable<Encounter> z_ = this.Inpatient_Stay_with_Qualifying_Diagnosis_During_Initiation_Phase();
		bool? aa_ = context.Operators.Exists<Encounter>(z_);
		bool? ab_ = context.Operators.Not(aa_);
		bool? ac_ = context.Operators.And(y_, ab_);

		return ac_;
	}

    [CqlDeclaration("Initial Population 1")]
	public bool? Initial_Population_1() => 
		__Initial_Population_1.Value;

	private bool? Denominator_1_Value()
	{
		bool? a_ = this.Initial_Population_1();

		return a_;
	}

    [CqlDeclaration("Denominator 1")]
	public bool? Denominator_1() => 
		__Denominator_1.Value;

	private IEnumerable<Condition> Narcolepsy_Exclusion_Value()
	{
		CqlValueSet a_ = this.Narcolepsy();
		IEnumerable<Condition> b_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
		bool? c_(Condition Narcolepsy)
		{
			CqlInterval<CqlDateTime> e_ = QICoreCommon_2_0_000.ToPrevalenceInterval(Narcolepsy);
			CqlDateTime f_ = context.Operators.Start(e_);
			CqlInterval<CqlDateTime> g_ = this.Measurement_Period();
			CqlDateTime h_ = context.Operators.End(g_);
			bool? i_ = context.Operators.SameOrBefore(f_, h_, default);

			return i_;
		};
		IEnumerable<Condition> d_ = context.Operators.Where<Condition>(b_, c_);

		return d_;
	}

    [CqlDeclaration("Narcolepsy Exclusion")]
	public IEnumerable<Condition> Narcolepsy_Exclusion() => 
		__Narcolepsy_Exclusion.Value;

	private bool? Denominator_Exclusions_Value()
	{
		bool? a_ = Hospice_6_9_000.Has_Hospice_Services();
		IEnumerable<Condition> b_ = this.Narcolepsy_Exclusion();
		bool? c_ = context.Operators.Exists<Condition>(b_);
		bool? d_ = context.Operators.Or(a_, c_);

		return d_;
	}

    [CqlDeclaration("Denominator Exclusions")]
	public bool? Denominator_Exclusions() => 
		__Denominator_Exclusions.Value;

	private IEnumerable<Encounter> Qualifying_Numerator_Encounter_Value()
	{
		CqlValueSet a_ = this.Office_Visit();
		IEnumerable<Encounter> b_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
		CqlValueSet c_ = this.Initial_Hospital_Observation_Care();
		IEnumerable<Encounter> d_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, c_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
		IEnumerable<Encounter> e_ = context.Operators.Union<Encounter>(b_, d_);
		CqlValueSet f_ = this.Preventive_Care_Services_Group_Counseling();
		IEnumerable<Encounter> g_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, f_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
		CqlValueSet h_ = this.Behavioral_Health_Follow_up_Visit();
		IEnumerable<Encounter> i_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, h_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
		IEnumerable<Encounter> j_ = context.Operators.Union<Encounter>(g_, i_);
		IEnumerable<Encounter> k_ = context.Operators.Union<Encounter>(e_, j_);
		CqlValueSet l_ = this.Preventive_Care_Services_Individual_Counseling();
		IEnumerable<Encounter> m_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, l_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
		CqlValueSet n_ = this.Psychotherapy_and_Pharmacologic_Management();
		IEnumerable<Encounter> o_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, n_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
		bool? p_(Encounter PsychPharmManagement)
		{
			List<Encounter.LocationComponent> ao_ = PsychPharmManagement?.Location;
			bool? ap_(Encounter.LocationComponent Location)
			{
				ResourceReference as_ = Location?.Location;
				Location at_ = CQMCommon_2_0_000.GetLocation(as_);
				List<CodeableConcept> au_ = at_?.Type;
				CqlConcept av_(CodeableConcept @this)
				{
					CqlConcept az_ = FHIRHelpers_4_3_000.ToConcept(@this);

					return az_;
				};
				IEnumerable<CqlConcept> aw_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)au_, av_);
				CqlValueSet ax_ = this.Ambulatory();
				bool? ay_ = context.Operators.ConceptsInValueSet(aw_, ax_);

				return ay_;
			};
			IEnumerable<Encounter.LocationComponent> aq_ = context.Operators.Where<Encounter.LocationComponent>((IEnumerable<Encounter.LocationComponent>)ao_, ap_);
			bool? ar_ = context.Operators.Exists<Encounter.LocationComponent>(aq_);

			return ar_;
		};
		IEnumerable<Encounter> q_ = context.Operators.Where<Encounter>(o_, p_);
		IEnumerable<Encounter> r_ = context.Operators.Union<Encounter>(m_, q_);
		IEnumerable<Encounter> s_ = context.Operators.Union<Encounter>(k_, r_);
		CqlValueSet t_ = this.Outpatient_Consultation();
		IEnumerable<Encounter> u_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, t_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
		CqlValueSet v_ = this.Home_Healthcare_Services();
		IEnumerable<Encounter> w_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, v_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
		IEnumerable<Encounter> x_ = context.Operators.Union<Encounter>(u_, w_);
		IEnumerable<Encounter> y_ = context.Operators.Union<Encounter>(s_, x_);
		CqlValueSet z_ = this.Preventive_Care_Services__Initial_Office_Visit__0_to_17();
		IEnumerable<Encounter> aa_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, z_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
		CqlValueSet ab_ = this.Preventive_Care__Established_Office_Visit__0_to_17();
		IEnumerable<Encounter> ac_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, ab_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
		IEnumerable<Encounter> ad_ = context.Operators.Union<Encounter>(aa_, ac_);
		IEnumerable<Encounter> ae_ = context.Operators.Union<Encounter>(y_, ad_);
		CqlValueSet af_ = this.Psych_Visit_Diagnostic_Evaluation();
		IEnumerable<Encounter> ag_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, af_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
		CqlValueSet ah_ = this.Psych_Visit_Psychotherapy();
		IEnumerable<Encounter> ai_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, ah_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
		IEnumerable<Encounter> aj_ = context.Operators.Union<Encounter>(ag_, ai_);
		IEnumerable<Encounter> ak_ = context.Operators.Union<Encounter>(ae_, aj_);
		CqlValueSet al_ = this.Telephone_Visits();
		IEnumerable<Encounter> am_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, al_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
		IEnumerable<Encounter> an_ = context.Operators.Union<Encounter>(ak_, am_);

		return an_;
	}

    [CqlDeclaration("Qualifying Numerator Encounter")]
	public IEnumerable<Encounter> Qualifying_Numerator_Encounter() => 
		__Qualifying_Numerator_Encounter.Value;

	private IEnumerable<Encounter> Encounter_During_Initiation_Phase_Value()
	{
		IEnumerable<Encounter> a_ = this.Qualifying_Numerator_Encounter();
		bool? b_(Encounter ValidNumeratorEncounter)
		{
			Period d_ = ValidNumeratorEncounter?.Period;
			CqlInterval<CqlDateTime> e_ = FHIRHelpers_4_3_000.ToInterval(d_);
			CqlInterval<CqlDate> f_ = CQMCommon_2_0_000.ToDateInterval(e_);
			CqlDate g_ = context.Operators.Start(f_);
			CqlDate h_ = this.IPSD();
			CqlQuantity j_ = context.Operators.Quantity(30m, "days");
			CqlDate k_ = context.Operators.Add(h_, j_);
			CqlInterval<CqlDate> l_ = context.Operators.Interval(h_, k_, false, true);
			bool? m_ = context.Operators.In<CqlDate>(g_, l_, "day");
			bool? o_ = context.Operators.Not((bool?)(h_ is null));
			bool? p_ = context.Operators.And(m_, o_);

			return p_;
		};
		IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);

		return c_;
	}

    [CqlDeclaration("Encounter During Initiation Phase")]
	public IEnumerable<Encounter> Encounter_During_Initiation_Phase() => 
		__Encounter_During_Initiation_Phase.Value;

	private bool? Numerator_1_Value()
	{
		IEnumerable<Encounter> a_ = this.Encounter_During_Initiation_Phase();
		bool? b_ = context.Operators.Exists<Encounter>(a_);

		return b_;
	}

    [CqlDeclaration("Numerator 1")]
	public bool? Numerator_1() => 
		__Numerator_1.Value;

	private IEnumerable<CqlInterval<CqlDate>> ADHD_Medications_Taken_on_IPSD_or_During_Continuation_and_Maintenance_Phase_Value()
	{
		CqlValueSet a_ = this.Atomoxetine();
		IEnumerable<MedicationRequest> b_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
		IEnumerable<MedicationRequest> d_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
		IEnumerable<MedicationRequest> e_ = context.Operators.Union<MedicationRequest>(b_, d_);
		(CqlInterval<CqlDate> period, CqlDate periodStart)? f_(MedicationRequest AtomoxetineMed)
		{
			CqlInterval<CqlDate> dt_ = CumulativeMedicationDuration_4_0_000.MedicationRequestPeriod(AtomoxetineMed);
			CqlDate dv_ = context.Operators.Start(dt_);
			(CqlInterval<CqlDate> period, CqlDate periodStart)? dw_ = (dt_, dv_);

			return dw_;
		};
		IEnumerable<(CqlInterval<CqlDate> period, CqlDate periodStart)?> g_ = context.Operators.Select<MedicationRequest, (CqlInterval<CqlDate> period, CqlDate periodStart)?>(e_, f_);
		object h_((CqlInterval<CqlDate> period, CqlDate periodStart)? @this)
		{
			CqlDate dx_ = @this?.periodStart;

			return dx_;
		};
		IEnumerable<(CqlInterval<CqlDate> period, CqlDate periodStart)?> i_ = context.Operators.SortBy<(CqlInterval<CqlDate> period, CqlDate periodStart)?>(g_, h_, System.ComponentModel.ListSortDirection.Ascending);
		bool? j_((CqlInterval<CqlDate> period, CqlDate periodStart)? @this)
		{
			CqlInterval<CqlDate> dy_ = @this?.period;
			bool? dz_ = context.Operators.Not((bool?)(dy_ is null));

			return dz_;
		};
		IEnumerable<(CqlInterval<CqlDate> period, CqlDate periodStart)?> k_ = context.Operators.Where<(CqlInterval<CqlDate> period, CqlDate periodStart)?>(i_, j_);
		CqlInterval<CqlDate> l_((CqlInterval<CqlDate> period, CqlDate periodStart)? @this)
		{
			CqlInterval<CqlDate> ea_ = @this?.period;

			return ea_;
		};
		IEnumerable<CqlInterval<CqlDate>> m_ = context.Operators.Select<(CqlInterval<CqlDate> period, CqlDate periodStart)?, CqlInterval<CqlDate>>(k_, l_);
		IEnumerable<CqlInterval<CqlDate>> n_ = CumulativeMedicationDuration_4_0_000.RolloutIntervals(m_);
		CqlValueSet o_ = this.Clonidine();
		IEnumerable<MedicationRequest> p_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, o_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
		IEnumerable<MedicationRequest> r_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, o_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
		IEnumerable<MedicationRequest> s_ = context.Operators.Union<MedicationRequest>(p_, r_);
		(CqlInterval<CqlDate> period, CqlDate periodStart)? t_(MedicationRequest ClonidineMed)
		{
			CqlInterval<CqlDate> eb_ = CumulativeMedicationDuration_4_0_000.MedicationRequestPeriod(ClonidineMed);
			CqlDate ed_ = context.Operators.Start(eb_);
			(CqlInterval<CqlDate> period, CqlDate periodStart)? ee_ = (eb_, ed_);

			return ee_;
		};
		IEnumerable<(CqlInterval<CqlDate> period, CqlDate periodStart)?> u_ = context.Operators.Select<MedicationRequest, (CqlInterval<CqlDate> period, CqlDate periodStart)?>(s_, t_);
		object v_((CqlInterval<CqlDate> period, CqlDate periodStart)? @this)
		{
			CqlDate ef_ = @this?.periodStart;

			return ef_;
		};
		IEnumerable<(CqlInterval<CqlDate> period, CqlDate periodStart)?> w_ = context.Operators.SortBy<(CqlInterval<CqlDate> period, CqlDate periodStart)?>(u_, v_, System.ComponentModel.ListSortDirection.Ascending);
		bool? x_((CqlInterval<CqlDate> period, CqlDate periodStart)? @this)
		{
			CqlInterval<CqlDate> eg_ = @this?.period;
			bool? eh_ = context.Operators.Not((bool?)(eg_ is null));

			return eh_;
		};
		IEnumerable<(CqlInterval<CqlDate> period, CqlDate periodStart)?> y_ = context.Operators.Where<(CqlInterval<CqlDate> period, CqlDate periodStart)?>(w_, x_);
		CqlInterval<CqlDate> z_((CqlInterval<CqlDate> period, CqlDate periodStart)? @this)
		{
			CqlInterval<CqlDate> ei_ = @this?.period;

			return ei_;
		};
		IEnumerable<CqlInterval<CqlDate>> aa_ = context.Operators.Select<(CqlInterval<CqlDate> period, CqlDate periodStart)?, CqlInterval<CqlDate>>(y_, z_);
		IEnumerable<CqlInterval<CqlDate>> ab_ = CumulativeMedicationDuration_4_0_000.RolloutIntervals(aa_);
		IEnumerable<CqlInterval<CqlDate>> ac_ = context.Operators.Union<CqlInterval<CqlDate>>(n_, ab_);
		CqlValueSet ad_ = this.Dexmethylphenidate();
		IEnumerable<MedicationRequest> ae_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, ad_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
		IEnumerable<MedicationRequest> ag_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, ad_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
		IEnumerable<MedicationRequest> ah_ = context.Operators.Union<MedicationRequest>(ae_, ag_);
		(CqlInterval<CqlDate> period, CqlDate periodStart)? ai_(MedicationRequest DexmethylphenidateMed)
		{
			CqlInterval<CqlDate> ej_ = CumulativeMedicationDuration_4_0_000.MedicationRequestPeriod(DexmethylphenidateMed);
			CqlDate el_ = context.Operators.Start(ej_);
			(CqlInterval<CqlDate> period, CqlDate periodStart)? em_ = (ej_, el_);

			return em_;
		};
		IEnumerable<(CqlInterval<CqlDate> period, CqlDate periodStart)?> aj_ = context.Operators.Select<MedicationRequest, (CqlInterval<CqlDate> period, CqlDate periodStart)?>(ah_, ai_);
		object ak_((CqlInterval<CqlDate> period, CqlDate periodStart)? @this)
		{
			CqlDate en_ = @this?.periodStart;

			return en_;
		};
		IEnumerable<(CqlInterval<CqlDate> period, CqlDate periodStart)?> al_ = context.Operators.SortBy<(CqlInterval<CqlDate> period, CqlDate periodStart)?>(aj_, ak_, System.ComponentModel.ListSortDirection.Ascending);
		bool? am_((CqlInterval<CqlDate> period, CqlDate periodStart)? @this)
		{
			CqlInterval<CqlDate> eo_ = @this?.period;
			bool? ep_ = context.Operators.Not((bool?)(eo_ is null));

			return ep_;
		};
		IEnumerable<(CqlInterval<CqlDate> period, CqlDate periodStart)?> an_ = context.Operators.Where<(CqlInterval<CqlDate> period, CqlDate periodStart)?>(al_, am_);
		CqlInterval<CqlDate> ao_((CqlInterval<CqlDate> period, CqlDate periodStart)? @this)
		{
			CqlInterval<CqlDate> eq_ = @this?.period;

			return eq_;
		};
		IEnumerable<CqlInterval<CqlDate>> ap_ = context.Operators.Select<(CqlInterval<CqlDate> period, CqlDate periodStart)?, CqlInterval<CqlDate>>(an_, ao_);
		IEnumerable<CqlInterval<CqlDate>> aq_ = CumulativeMedicationDuration_4_0_000.RolloutIntervals(ap_);
		CqlValueSet ar_ = this.Dextroamphetamine();
		IEnumerable<MedicationRequest> as_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, ar_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
		IEnumerable<MedicationRequest> au_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, ar_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
		IEnumerable<MedicationRequest> av_ = context.Operators.Union<MedicationRequest>(as_, au_);
		(CqlInterval<CqlDate> period, CqlDate periodStart)? aw_(MedicationRequest DextroamphetamineMed)
		{
			CqlInterval<CqlDate> er_ = CumulativeMedicationDuration_4_0_000.MedicationRequestPeriod(DextroamphetamineMed);
			CqlDate et_ = context.Operators.Start(er_);
			(CqlInterval<CqlDate> period, CqlDate periodStart)? eu_ = (er_, et_);

			return eu_;
		};
		IEnumerable<(CqlInterval<CqlDate> period, CqlDate periodStart)?> ax_ = context.Operators.Select<MedicationRequest, (CqlInterval<CqlDate> period, CqlDate periodStart)?>(av_, aw_);
		object ay_((CqlInterval<CqlDate> period, CqlDate periodStart)? @this)
		{
			CqlDate ev_ = @this?.periodStart;

			return ev_;
		};
		IEnumerable<(CqlInterval<CqlDate> period, CqlDate periodStart)?> az_ = context.Operators.SortBy<(CqlInterval<CqlDate> period, CqlDate periodStart)?>(ax_, ay_, System.ComponentModel.ListSortDirection.Ascending);
		bool? ba_((CqlInterval<CqlDate> period, CqlDate periodStart)? @this)
		{
			CqlInterval<CqlDate> ew_ = @this?.period;
			bool? ex_ = context.Operators.Not((bool?)(ew_ is null));

			return ex_;
		};
		IEnumerable<(CqlInterval<CqlDate> period, CqlDate periodStart)?> bb_ = context.Operators.Where<(CqlInterval<CqlDate> period, CqlDate periodStart)?>(az_, ba_);
		CqlInterval<CqlDate> bc_((CqlInterval<CqlDate> period, CqlDate periodStart)? @this)
		{
			CqlInterval<CqlDate> ey_ = @this?.period;

			return ey_;
		};
		IEnumerable<CqlInterval<CqlDate>> bd_ = context.Operators.Select<(CqlInterval<CqlDate> period, CqlDate periodStart)?, CqlInterval<CqlDate>>(bb_, bc_);
		IEnumerable<CqlInterval<CqlDate>> be_ = CumulativeMedicationDuration_4_0_000.RolloutIntervals(bd_);
		IEnumerable<CqlInterval<CqlDate>> bf_ = context.Operators.Union<CqlInterval<CqlDate>>(aq_, be_);
		IEnumerable<CqlInterval<CqlDate>> bg_ = context.Operators.Union<CqlInterval<CqlDate>>(ac_, bf_);
		CqlValueSet bh_ = this.Lisdexamfetamine();
		IEnumerable<MedicationRequest> bi_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, bh_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
		IEnumerable<MedicationRequest> bk_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, bh_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
		IEnumerable<MedicationRequest> bl_ = context.Operators.Union<MedicationRequest>(bi_, bk_);
		(CqlInterval<CqlDate> period, CqlDate periodStart)? bm_(MedicationRequest LisdexamfetamineMed)
		{
			CqlInterval<CqlDate> ez_ = CumulativeMedicationDuration_4_0_000.MedicationRequestPeriod(LisdexamfetamineMed);
			CqlDate fb_ = context.Operators.Start(ez_);
			(CqlInterval<CqlDate> period, CqlDate periodStart)? fc_ = (ez_, fb_);

			return fc_;
		};
		IEnumerable<(CqlInterval<CqlDate> period, CqlDate periodStart)?> bn_ = context.Operators.Select<MedicationRequest, (CqlInterval<CqlDate> period, CqlDate periodStart)?>(bl_, bm_);
		object bo_((CqlInterval<CqlDate> period, CqlDate periodStart)? @this)
		{
			CqlDate fd_ = @this?.periodStart;

			return fd_;
		};
		IEnumerable<(CqlInterval<CqlDate> period, CqlDate periodStart)?> bp_ = context.Operators.SortBy<(CqlInterval<CqlDate> period, CqlDate periodStart)?>(bn_, bo_, System.ComponentModel.ListSortDirection.Ascending);
		bool? bq_((CqlInterval<CqlDate> period, CqlDate periodStart)? @this)
		{
			CqlInterval<CqlDate> fe_ = @this?.period;
			bool? ff_ = context.Operators.Not((bool?)(fe_ is null));

			return ff_;
		};
		IEnumerable<(CqlInterval<CqlDate> period, CqlDate periodStart)?> br_ = context.Operators.Where<(CqlInterval<CqlDate> period, CqlDate periodStart)?>(bp_, bq_);
		CqlInterval<CqlDate> bs_((CqlInterval<CqlDate> period, CqlDate periodStart)? @this)
		{
			CqlInterval<CqlDate> fg_ = @this?.period;

			return fg_;
		};
		IEnumerable<CqlInterval<CqlDate>> bt_ = context.Operators.Select<(CqlInterval<CqlDate> period, CqlDate periodStart)?, CqlInterval<CqlDate>>(br_, bs_);
		IEnumerable<CqlInterval<CqlDate>> bu_ = CumulativeMedicationDuration_4_0_000.RolloutIntervals(bt_);
		CqlValueSet bv_ = this.Methylphenidate();
		IEnumerable<MedicationRequest> bw_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, bv_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
		IEnumerable<MedicationRequest> by_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, bv_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
		IEnumerable<MedicationRequest> bz_ = context.Operators.Union<MedicationRequest>(bw_, by_);
		(CqlInterval<CqlDate> period, CqlDate periodStart)? ca_(MedicationRequest MethylphenidateMed)
		{
			CqlInterval<CqlDate> fh_ = CumulativeMedicationDuration_4_0_000.MedicationRequestPeriod(MethylphenidateMed);
			CqlDate fj_ = context.Operators.Start(fh_);
			(CqlInterval<CqlDate> period, CqlDate periodStart)? fk_ = (fh_, fj_);

			return fk_;
		};
		IEnumerable<(CqlInterval<CqlDate> period, CqlDate periodStart)?> cb_ = context.Operators.Select<MedicationRequest, (CqlInterval<CqlDate> period, CqlDate periodStart)?>(bz_, ca_);
		object cc_((CqlInterval<CqlDate> period, CqlDate periodStart)? @this)
		{
			CqlDate fl_ = @this?.periodStart;

			return fl_;
		};
		IEnumerable<(CqlInterval<CqlDate> period, CqlDate periodStart)?> cd_ = context.Operators.SortBy<(CqlInterval<CqlDate> period, CqlDate periodStart)?>(cb_, cc_, System.ComponentModel.ListSortDirection.Ascending);
		bool? ce_((CqlInterval<CqlDate> period, CqlDate periodStart)? @this)
		{
			CqlInterval<CqlDate> fm_ = @this?.period;
			bool? fn_ = context.Operators.Not((bool?)(fm_ is null));

			return fn_;
		};
		IEnumerable<(CqlInterval<CqlDate> period, CqlDate periodStart)?> cf_ = context.Operators.Where<(CqlInterval<CqlDate> period, CqlDate periodStart)?>(cd_, ce_);
		CqlInterval<CqlDate> cg_((CqlInterval<CqlDate> period, CqlDate periodStart)? @this)
		{
			CqlInterval<CqlDate> fo_ = @this?.period;

			return fo_;
		};
		IEnumerable<CqlInterval<CqlDate>> ch_ = context.Operators.Select<(CqlInterval<CqlDate> period, CqlDate periodStart)?, CqlInterval<CqlDate>>(cf_, cg_);
		IEnumerable<CqlInterval<CqlDate>> ci_ = CumulativeMedicationDuration_4_0_000.RolloutIntervals(ch_);
		IEnumerable<CqlInterval<CqlDate>> cj_ = context.Operators.Union<CqlInterval<CqlDate>>(bu_, ci_);
		IEnumerable<CqlInterval<CqlDate>> ck_ = context.Operators.Union<CqlInterval<CqlDate>>(bg_, cj_);
		CqlValueSet cl_ = this.Guanfacine();
		IEnumerable<MedicationRequest> cm_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, cl_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
		IEnumerable<MedicationRequest> co_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, cl_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
		IEnumerable<MedicationRequest> cp_ = context.Operators.Union<MedicationRequest>(cm_, co_);
		(CqlInterval<CqlDate> period, CqlDate periodStart)? cq_(MedicationRequest GuanfacineMed)
		{
			CqlInterval<CqlDate> fp_ = CumulativeMedicationDuration_4_0_000.MedicationRequestPeriod(GuanfacineMed);
			CqlDate fr_ = context.Operators.Start(fp_);
			(CqlInterval<CqlDate> period, CqlDate periodStart)? fs_ = (fp_, fr_);

			return fs_;
		};
		IEnumerable<(CqlInterval<CqlDate> period, CqlDate periodStart)?> cr_ = context.Operators.Select<MedicationRequest, (CqlInterval<CqlDate> period, CqlDate periodStart)?>(cp_, cq_);
		object cs_((CqlInterval<CqlDate> period, CqlDate periodStart)? @this)
		{
			CqlDate ft_ = @this?.periodStart;

			return ft_;
		};
		IEnumerable<(CqlInterval<CqlDate> period, CqlDate periodStart)?> ct_ = context.Operators.SortBy<(CqlInterval<CqlDate> period, CqlDate periodStart)?>(cr_, cs_, System.ComponentModel.ListSortDirection.Ascending);
		bool? cu_((CqlInterval<CqlDate> period, CqlDate periodStart)? @this)
		{
			CqlInterval<CqlDate> fu_ = @this?.period;
			bool? fv_ = context.Operators.Not((bool?)(fu_ is null));

			return fv_;
		};
		IEnumerable<(CqlInterval<CqlDate> period, CqlDate periodStart)?> cv_ = context.Operators.Where<(CqlInterval<CqlDate> period, CqlDate periodStart)?>(ct_, cu_);
		CqlInterval<CqlDate> cw_((CqlInterval<CqlDate> period, CqlDate periodStart)? @this)
		{
			CqlInterval<CqlDate> fw_ = @this?.period;

			return fw_;
		};
		IEnumerable<CqlInterval<CqlDate>> cx_ = context.Operators.Select<(CqlInterval<CqlDate> period, CqlDate periodStart)?, CqlInterval<CqlDate>>(cv_, cw_);
		IEnumerable<CqlInterval<CqlDate>> cy_ = CumulativeMedicationDuration_4_0_000.RolloutIntervals(cx_);
		CqlCode cz_ = this.methamphetamine_hydrochloride_5_MG_Oral_Tablet();
		IEnumerable<CqlCode> da_ = context.Operators.ToList<CqlCode>(cz_);
		IEnumerable<MedicationRequest> db_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, default, da_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
		IEnumerable<CqlCode> dd_ = context.Operators.ToList<CqlCode>(cz_);
		IEnumerable<MedicationRequest> de_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, default, dd_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
		IEnumerable<MedicationRequest> df_ = context.Operators.Union<MedicationRequest>(db_, de_);
		(CqlInterval<CqlDate> period, CqlDate periodStart)? dg_(MedicationRequest MethamphetamineMed)
		{
			CqlInterval<CqlDate> fx_ = CumulativeMedicationDuration_4_0_000.MedicationRequestPeriod(MethamphetamineMed);
			CqlDate fz_ = context.Operators.Start(fx_);
			(CqlInterval<CqlDate> period, CqlDate periodStart)? ga_ = (fx_, fz_);

			return ga_;
		};
		IEnumerable<(CqlInterval<CqlDate> period, CqlDate periodStart)?> dh_ = context.Operators.Select<MedicationRequest, (CqlInterval<CqlDate> period, CqlDate periodStart)?>(df_, dg_);
		object di_((CqlInterval<CqlDate> period, CqlDate periodStart)? @this)
		{
			CqlDate gb_ = @this?.periodStart;

			return gb_;
		};
		IEnumerable<(CqlInterval<CqlDate> period, CqlDate periodStart)?> dj_ = context.Operators.SortBy<(CqlInterval<CqlDate> period, CqlDate periodStart)?>(dh_, di_, System.ComponentModel.ListSortDirection.Ascending);
		bool? dk_((CqlInterval<CqlDate> period, CqlDate periodStart)? @this)
		{
			CqlInterval<CqlDate> gc_ = @this?.period;
			bool? gd_ = context.Operators.Not((bool?)(gc_ is null));

			return gd_;
		};
		IEnumerable<(CqlInterval<CqlDate> period, CqlDate periodStart)?> dl_ = context.Operators.Where<(CqlInterval<CqlDate> period, CqlDate periodStart)?>(dj_, dk_);
		CqlInterval<CqlDate> dm_((CqlInterval<CqlDate> period, CqlDate periodStart)? @this)
		{
			CqlInterval<CqlDate> ge_ = @this?.period;

			return ge_;
		};
		IEnumerable<CqlInterval<CqlDate>> dn_ = context.Operators.Select<(CqlInterval<CqlDate> period, CqlDate periodStart)?, CqlInterval<CqlDate>>(dl_, dm_);
		IEnumerable<CqlInterval<CqlDate>> do_ = CumulativeMedicationDuration_4_0_000.RolloutIntervals(dn_);
		IEnumerable<CqlInterval<CqlDate>> dp_ = context.Operators.Union<CqlInterval<CqlDate>>(cy_, do_);
		IEnumerable<CqlInterval<CqlDate>> dq_ = context.Operators.Union<CqlInterval<CqlDate>>(ck_, dp_);
		CqlInterval<CqlDate> dr_(CqlInterval<CqlDate> ADHDMedication)
		{
			CqlDate gf_ = this.IPSD();
			CqlQuantity gh_ = context.Operators.Quantity(300m, "days");
			CqlDate gi_ = context.Operators.Add(gf_, gh_);
			CqlInterval<CqlDate> gj_ = context.Operators.Interval(gf_, gi_, true, true);
			CqlInterval<CqlDate> gk_ = context.Operators.Intersect<CqlDate>(ADHDMedication, gj_);

			return gk_;
		};
		IEnumerable<CqlInterval<CqlDate>> ds_ = context.Operators.Select<CqlInterval<CqlDate>, CqlInterval<CqlDate>>(dq_, dr_);

		return ds_;
	}

    [CqlDeclaration("ADHD Medications Taken on IPSD or During Continuation and Maintenance Phase")]
	public IEnumerable<CqlInterval<CqlDate>> ADHD_Medications_Taken_on_IPSD_or_During_Continuation_and_Maintenance_Phase() => 
		__ADHD_Medications_Taken_on_IPSD_or_During_Continuation_and_Maintenance_Phase.Value;

	private int? ADHD_Cumulative_Medication_Duration_Value()
	{
		IEnumerable<CqlInterval<CqlDate>> a_ = this.ADHD_Medications_Taken_on_IPSD_or_During_Continuation_and_Maintenance_Phase();
		int? b_ = CumulativeMedicationDuration_4_0_000.CumulativeDuration(a_);

		return b_;
	}

    [CqlDeclaration("ADHD Cumulative Medication Duration")]
	public int? ADHD_Cumulative_Medication_Duration() => 
		__ADHD_Cumulative_Medication_Duration.Value;

	private bool? Has_ADHD_Cumulative_Medication_Duration_Greater_Than_or_Equal_to_210_Days_Value()
	{
		int? a_ = this.ADHD_Cumulative_Medication_Duration();
		bool? b_ = context.Operators.GreaterOrEqual(a_, 210);

		return b_;
	}

    [CqlDeclaration("Has ADHD Cumulative Medication Duration Greater Than or Equal to 210 Days")]
	public bool? Has_ADHD_Cumulative_Medication_Duration_Greater_Than_or_Equal_to_210_Days() => 
		__Has_ADHD_Cumulative_Medication_Duration_Greater_Than_or_Equal_to_210_Days.Value;

	private IEnumerable<Encounter> Inpatient_Stay_with_Qualifying_Diagnosis_During_Continuation_and_Maintenance_Phase_Value()
	{
		IEnumerable<Encounter> a_ = this.Inpatient_Stay_with_Qualifying_Diagnosis();
		bool? b_(Encounter InpatientStay)
		{
			Period d_ = InpatientStay?.Period;
			CqlInterval<CqlDateTime> e_ = FHIRHelpers_4_3_000.ToInterval(d_);
			CqlInterval<CqlDate> f_ = CQMCommon_2_0_000.ToDateInterval(e_);
			CqlDate g_ = context.Operators.Start(f_);
			CqlDate h_ = this.IPSD();
			CqlQuantity j_ = context.Operators.Quantity(300m, "days");
			CqlDate k_ = context.Operators.Add(h_, j_);
			CqlInterval<CqlDate> l_ = context.Operators.Interval(h_, k_, false, true);
			bool? m_ = context.Operators.In<CqlDate>(g_, l_, "day");
			bool? o_ = context.Operators.Not((bool?)(h_ is null));
			bool? p_ = context.Operators.And(m_, o_);

			return p_;
		};
		IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);

		return c_;
	}

    [CqlDeclaration("Inpatient Stay with Qualifying Diagnosis During Continuation and Maintenance Phase")]
	public IEnumerable<Encounter> Inpatient_Stay_with_Qualifying_Diagnosis_During_Continuation_and_Maintenance_Phase() => 
		__Inpatient_Stay_with_Qualifying_Diagnosis_During_Continuation_and_Maintenance_Phase.Value;

	private bool? Initial_Population_2_Value()
	{
		Patient a_ = this.Patient();
		Date b_ = a_?.BirthDateElement;
		string c_ = b_?.Value;
		CqlDate d_ = context.Operators.ConvertStringToDate(c_);
		CqlInterval<CqlDateTime> e_ = this.Intake_Period();
		CqlDateTime f_ = context.Operators.Start(e_);
		CqlDate g_ = context.Operators.DateFrom(f_);
		int? h_ = context.Operators.CalculateAgeAt(d_, g_, "year");
		bool? i_ = context.Operators.GreaterOrEqual(h_, 6);
		Date k_ = a_?.BirthDateElement;
		string l_ = k_?.Value;
		CqlDate m_ = context.Operators.ConvertStringToDate(l_);
		CqlDateTime o_ = context.Operators.End(e_);
		CqlDate p_ = context.Operators.DateFrom(o_);
		int? q_ = context.Operators.CalculateAgeAt(m_, p_, "year");
		bool? r_ = context.Operators.LessOrEqual(q_, 12);
		bool? s_ = context.Operators.And(i_, r_);
		IEnumerable<Encounter> t_ = this.Qualifying_Encounter();
		bool? u_ = context.Operators.Exists<Encounter>(t_);
		bool? v_ = context.Operators.And(s_, u_);
		CqlDate w_ = this.First_ADHD_Medication_Prescribed_During_Intake_Period();
		bool? x_ = context.Operators.Not((bool?)(w_ is null));
		bool? y_ = context.Operators.And(v_, x_);
		bool? z_ = this.Has_ADHD_Cumulative_Medication_Duration_Greater_Than_or_Equal_to_210_Days();
		bool? aa_ = context.Operators.And(y_, z_);
		IEnumerable<Encounter> ab_ = this.Inpatient_Stay_with_Qualifying_Diagnosis_During_Continuation_and_Maintenance_Phase();
		bool? ac_ = context.Operators.Exists<Encounter>(ab_);
		bool? ad_ = context.Operators.Not(ac_);
		bool? ae_ = context.Operators.And(aa_, ad_);

		return ae_;
	}

    [CqlDeclaration("Initial Population 2")]
	public bool? Initial_Population_2() => 
		__Initial_Population_2.Value;

	private bool? Denominator_2_Value()
	{
		bool? a_ = this.Initial_Population_2();

		return a_;
	}

    [CqlDeclaration("Denominator 2")]
	public bool? Denominator_2() => 
		__Denominator_2.Value;

	private IEnumerable<CqlDate> Encounter_31_to_300_Days_into_Continuation_and_Maintenance_Phase_Value()
	{
		IEnumerable<Encounter> a_ = this.Qualifying_Numerator_Encounter();
		bool? b_(Encounter ValidNumeratorEncounter)
		{
			Period f_ = ValidNumeratorEncounter?.Period;
			CqlInterval<CqlDateTime> g_ = FHIRHelpers_4_3_000.ToInterval(f_);
			CqlInterval<CqlDate> h_ = CQMCommon_2_0_000.ToDateInterval(g_);
			CqlDate i_ = context.Operators.Start(h_);
			CqlDate j_ = this.IPSD();
			CqlQuantity k_ = context.Operators.Quantity(31m, "days");
			CqlDate l_ = context.Operators.Add(j_, k_);
			CqlQuantity n_ = context.Operators.Quantity(300m, "days");
			CqlDate o_ = context.Operators.Add(j_, n_);
			CqlInterval<CqlDate> p_ = context.Operators.Interval(l_, o_, true, true);
			bool? q_ = context.Operators.In<CqlDate>(i_, p_, "day");

			return q_;
		};
		IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);
		CqlDate d_(Encounter ValidNumeratorEncounter)
		{
			Period r_ = ValidNumeratorEncounter?.Period;
			CqlInterval<CqlDateTime> s_ = FHIRHelpers_4_3_000.ToInterval(r_);
			CqlDateTime t_ = context.Operators.Start(s_);
			CqlDate u_ = context.Operators.DateFrom(t_);

			return u_;
		};
		IEnumerable<CqlDate> e_ = context.Operators.Select<Encounter, CqlDate>(c_, d_);

		return e_;
	}

    [CqlDeclaration("Encounter 31 to 300 Days into Continuation and Maintenance Phase")]
	public IEnumerable<CqlDate> Encounter_31_to_300_Days_into_Continuation_and_Maintenance_Phase() => 
		__Encounter_31_to_300_Days_into_Continuation_and_Maintenance_Phase.Value;

	private bool? Two_or_More_Encounters_31_to_300_Days_into_Continuation_and_Maintenance_Phase_Value()
	{
		IEnumerable<CqlDate> a_ = this.Encounter_31_to_300_Days_into_Continuation_and_Maintenance_Phase();
		int? b_ = context.Operators.Count<CqlDate>(a_);
		bool? c_ = context.Operators.GreaterOrEqual(b_, 2);

		return c_;
	}

    [CqlDeclaration("Two or More Encounters 31 to 300 Days into Continuation and Maintenance Phase")]
	public bool? Two_or_More_Encounters_31_to_300_Days_into_Continuation_and_Maintenance_Phase() => 
		__Two_or_More_Encounters_31_to_300_Days_into_Continuation_and_Maintenance_Phase.Value;

	private IEnumerable<CqlDate> Online_Assessment_31_to_300_Days_into_Continuation_and_Maintenance_Phase_Value()
	{
		CqlValueSet a_ = this.Online_Assessments();
		IEnumerable<Encounter> b_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
		bool? c_(Encounter OnlineAssessment)
		{
			Period g_ = OnlineAssessment?.Period;
			CqlInterval<CqlDateTime> h_ = FHIRHelpers_4_3_000.ToInterval(g_);
			CqlInterval<CqlDate> i_ = CQMCommon_2_0_000.ToDateInterval(h_);
			CqlDate j_ = context.Operators.Start(i_);
			CqlDate k_ = this.IPSD();
			CqlQuantity l_ = context.Operators.Quantity(31m, "days");
			CqlDate m_ = context.Operators.Add(k_, l_);
			CqlQuantity o_ = context.Operators.Quantity(300m, "days");
			CqlDate p_ = context.Operators.Add(k_, o_);
			CqlInterval<CqlDate> q_ = context.Operators.Interval(m_, p_, true, true);
			bool? r_ = context.Operators.In<CqlDate>(j_, q_, "day");

			return r_;
		};
		IEnumerable<Encounter> d_ = context.Operators.Where<Encounter>(b_, c_);
		CqlDate e_(Encounter OnlineAssessment)
		{
			Period s_ = OnlineAssessment?.Period;
			CqlInterval<CqlDateTime> t_ = FHIRHelpers_4_3_000.ToInterval(s_);
			CqlDateTime u_ = context.Operators.Start(t_);
			CqlDate v_ = context.Operators.DateFrom(u_);

			return v_;
		};
		IEnumerable<CqlDate> f_ = context.Operators.Select<Encounter, CqlDate>(d_, e_);

		return f_;
	}

    [CqlDeclaration("Online Assessment 31 to 300 Days into Continuation and Maintenance Phase")]
	public IEnumerable<CqlDate> Online_Assessment_31_to_300_Days_into_Continuation_and_Maintenance_Phase() => 
		__Online_Assessment_31_to_300_Days_into_Continuation_and_Maintenance_Phase.Value;

	private bool? Numerator_2_Value()
	{
		IEnumerable<Encounter> a_ = this.Encounter_During_Initiation_Phase();
		bool? b_ = context.Operators.Exists<Encounter>(a_);
		bool? c_ = this.Two_or_More_Encounters_31_to_300_Days_into_Continuation_and_Maintenance_Phase();
		IEnumerable<CqlDate> d_ = this.Encounter_31_to_300_Days_into_Continuation_and_Maintenance_Phase();
		IEnumerable<CqlDate> e_(CqlDate Encounter1)
		{
			IEnumerable<CqlDate> j_ = this.Online_Assessment_31_to_300_Days_into_Continuation_and_Maintenance_Phase();
			bool? k_(CqlDate Encounter2)
			{
				bool? o_ = context.Operators.Not((bool?)(Encounter1 is null));
				bool? p_ = context.Operators.Not((bool?)(Encounter2 is null));
				bool? q_ = context.Operators.And(o_, p_);
				bool? r_ = context.Operators.Equivalent(Encounter1, Encounter2);
				bool? s_ = context.Operators.Not(r_);
				bool? t_ = context.Operators.And(q_, s_);

				return t_;
			};
			IEnumerable<CqlDate> l_ = context.Operators.Where<CqlDate>(j_, k_);
			CqlDate m_(CqlDate Encounter2) => 
				Encounter1;
			IEnumerable<CqlDate> n_ = context.Operators.Select<CqlDate, CqlDate>(l_, m_);

			return n_;
		};
		IEnumerable<CqlDate> f_ = context.Operators.SelectMany<CqlDate, CqlDate>(d_, e_);
		bool? g_ = context.Operators.Exists<CqlDate>(f_);
		bool? h_ = context.Operators.Or(c_, g_);
		bool? i_ = context.Operators.And(b_, h_);

		return i_;
	}

    [CqlDeclaration("Numerator 2")]
	public bool? Numerator_2() => 
		__Numerator_2.Value;

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
