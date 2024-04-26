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
    internal Lazy<IEnumerable<Tuple_GgbdNTdhNeafRfiEMSgeHDMdE>> __ADHD_Medication_Prescribed_During_Intake_Period_and_Not_Previously_on_ADHD_Medication;
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
    internal Lazy<Tuple_DMgHTLENEHBHWJISQgKZGZVMB> __SDE_Ethnicity;
    internal Lazy<IEnumerable<Tuple_GDKRbfOIHhLGieQSVDEMIaDPX>> __SDE_Payer;
    internal Lazy<Tuple_DMgHTLENEHBHWJISQgKZGZVMB> __SDE_Race;
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
        __ADHD_Medication_Prescribed_During_Intake_Period_and_Not_Previously_on_ADHD_Medication = new Lazy<IEnumerable<Tuple_GgbdNTdhNeafRfiEMSgeHDMdE>>(this.ADHD_Medication_Prescribed_During_Intake_Period_and_Not_Previously_on_ADHD_Medication_Value);
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
        __SDE_Ethnicity = new Lazy<Tuple_DMgHTLENEHBHWJISQgKZGZVMB>(this.SDE_Ethnicity_Value);
        __SDE_Payer = new Lazy<IEnumerable<Tuple_GDKRbfOIHhLGieQSVDEMIaDPX>>(this.SDE_Payer_Value);
        __SDE_Race = new Lazy<Tuple_DMgHTLENEHBHWJISQgKZGZVMB>(this.SDE_Race_Value);
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
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.122.12.1003", null);

    [CqlDeclaration("Ambulatory")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.122.12.1003")]
	public CqlValueSet Ambulatory() => 
		__Ambulatory.Value;

	private CqlValueSet Atomoxetine_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.1170", null);

    [CqlDeclaration("Atomoxetine")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.1170")]
	public CqlValueSet Atomoxetine() => 
		__Atomoxetine.Value;

	private CqlValueSet Behavioral_Health_Follow_up_Visit_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1054", null);

    [CqlDeclaration("Behavioral Health Follow up Visit")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1054")]
	public CqlValueSet Behavioral_Health_Follow_up_Visit() => 
		__Behavioral_Health_Follow_up_Visit.Value;

	private CqlValueSet Clonidine_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.1171", null);

    [CqlDeclaration("Clonidine")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.1171")]
	public CqlValueSet Clonidine() => 
		__Clonidine.Value;

	private CqlValueSet Dexmethylphenidate_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.1172", null);

    [CqlDeclaration("Dexmethylphenidate")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.1172")]
	public CqlValueSet Dexmethylphenidate() => 
		__Dexmethylphenidate.Value;

	private CqlValueSet Dextroamphetamine_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.1173", null);

    [CqlDeclaration("Dextroamphetamine")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.1173")]
	public CqlValueSet Dextroamphetamine() => 
		__Dextroamphetamine.Value;

	private CqlValueSet Encounter_Inpatient_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.666.5.307", null);

    [CqlDeclaration("Encounter Inpatient")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.666.5.307")]
	public CqlValueSet Encounter_Inpatient() => 
		__Encounter_Inpatient.Value;

	private CqlValueSet Guanfacine_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.196.11.1252", null);

    [CqlDeclaration("Guanfacine")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.196.11.1252")]
	public CqlValueSet Guanfacine() => 
		__Guanfacine.Value;

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

	private CqlValueSet Lisdexamfetamine_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.1174", null);

    [CqlDeclaration("Lisdexamfetamine")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.1174")]
	public CqlValueSet Lisdexamfetamine() => 
		__Lisdexamfetamine.Value;

	private CqlValueSet Mental_Behavioral_and_Neurodevelopmental_Disorders_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.105.12.1203", null);

    [CqlDeclaration("Mental Behavioral and Neurodevelopmental Disorders")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.105.12.1203")]
	public CqlValueSet Mental_Behavioral_and_Neurodevelopmental_Disorders() => 
		__Mental_Behavioral_and_Neurodevelopmental_Disorders.Value;

	private CqlValueSet Methylphenidate_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.1176", null);

    [CqlDeclaration("Methylphenidate")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.1176")]
	public CqlValueSet Methylphenidate() => 
		__Methylphenidate.Value;

	private CqlValueSet Narcolepsy_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.114.12.1011", null);

    [CqlDeclaration("Narcolepsy")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.114.12.1011")]
	public CqlValueSet Narcolepsy() => 
		__Narcolepsy.Value;

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

	private CqlValueSet Psychotherapy_and_Pharmacologic_Management_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1055", null);

    [CqlDeclaration("Psychotherapy and Pharmacologic Management")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1055")]
	public CqlValueSet Psychotherapy_and_Pharmacologic_Management() => 
		__Psychotherapy_and_Pharmacologic_Management.Value;

	private CqlValueSet Telephone_Visits_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1080", null);

    [CqlDeclaration("Telephone Visits")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1080")]
	public CqlValueSet Telephone_Visits() => 
		__Telephone_Visits.Value;

	private CqlCode _24_HR_dexmethylphenidate_hydrochloride_40_MG_Extended_Release_Oral_Capsule_Value() => 
		new CqlCode("1006608", "http://www.nlm.nih.gov/research/umls/rxnorm", null, null);

    [CqlDeclaration("24 HR dexmethylphenidate hydrochloride 40 MG Extended Release Oral Capsule")]
	public CqlCode _24_HR_dexmethylphenidate_hydrochloride_40_MG_Extended_Release_Oral_Capsule() => 
		___24_HR_dexmethylphenidate_hydrochloride_40_MG_Extended_Release_Oral_Capsule.Value;

	private CqlCode methamphetamine_hydrochloride_5_MG_Oral_Tablet_Value() => 
		new CqlCode("977860", "http://www.nlm.nih.gov/research/umls/rxnorm", null, null);

    [CqlDeclaration("methamphetamine hydrochloride 5 MG Oral Tablet")]
	public CqlCode methamphetamine_hydrochloride_5_MG_Oral_Tablet() => 
		__methamphetamine_hydrochloride_5_MG_Oral_Tablet.Value;

	private CqlCode[] RXNORM_Value()
	{
		CqlCode[] a_ = new CqlCode[]
		{
			new CqlCode("1006608", "http://www.nlm.nih.gov/research/umls/rxnorm", null, null),
			new CqlCode("977860", "http://www.nlm.nih.gov/research/umls/rxnorm", null, null),
		};

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
		IEnumerable<Patient> a_ = context.Operators.RetrieveByValueSet<Patient>(null, null);
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

	private IEnumerable<Tuple_GgbdNTdhNeafRfiEMSgeHDMdE> ADHD_Medication_Prescribed_During_Intake_Period_and_Not_Previously_on_ADHD_Medication_Value()
	{
		CqlValueSet a_ = this.Atomoxetine();
		IEnumerable<MedicationRequest> b_ = context.Operators.RetrieveByValueSet<MedicationRequest>(a_, null);
		IEnumerable<MedicationRequest> d_ = context.Operators.RetrieveByValueSet<MedicationRequest>(a_, null);
		IEnumerable<MedicationRequest> e_ = context.Operators.ListUnion<MedicationRequest>(b_, d_);
		CqlValueSet f_ = this.Clonidine();
		IEnumerable<MedicationRequest> g_ = context.Operators.RetrieveByValueSet<MedicationRequest>(f_, null);
		IEnumerable<MedicationRequest> i_ = context.Operators.RetrieveByValueSet<MedicationRequest>(f_, null);
		IEnumerable<MedicationRequest> j_ = context.Operators.ListUnion<MedicationRequest>(g_, i_);
		IEnumerable<MedicationRequest> k_ = context.Operators.ListUnion<MedicationRequest>(e_, j_);
		CqlValueSet l_ = this.Dexmethylphenidate();
		IEnumerable<MedicationRequest> m_ = context.Operators.RetrieveByValueSet<MedicationRequest>(l_, null);
		IEnumerable<MedicationRequest> o_ = context.Operators.RetrieveByValueSet<MedicationRequest>(l_, null);
		IEnumerable<MedicationRequest> p_ = context.Operators.ListUnion<MedicationRequest>(m_, o_);
		IEnumerable<MedicationRequest> q_ = context.Operators.ListUnion<MedicationRequest>(k_, p_);
		CqlValueSet r_ = this.Dextroamphetamine();
		IEnumerable<MedicationRequest> s_ = context.Operators.RetrieveByValueSet<MedicationRequest>(r_, null);
		IEnumerable<MedicationRequest> u_ = context.Operators.RetrieveByValueSet<MedicationRequest>(r_, null);
		IEnumerable<MedicationRequest> v_ = context.Operators.ListUnion<MedicationRequest>(s_, u_);
		IEnumerable<MedicationRequest> w_ = context.Operators.ListUnion<MedicationRequest>(q_, v_);
		CqlValueSet x_ = this.Lisdexamfetamine();
		IEnumerable<MedicationRequest> y_ = context.Operators.RetrieveByValueSet<MedicationRequest>(x_, null);
		IEnumerable<MedicationRequest> aa_ = context.Operators.RetrieveByValueSet<MedicationRequest>(x_, null);
		IEnumerable<MedicationRequest> ab_ = context.Operators.ListUnion<MedicationRequest>(y_, aa_);
		IEnumerable<MedicationRequest> ac_ = context.Operators.ListUnion<MedicationRequest>(w_, ab_);
		CqlCode ad_ = this.methamphetamine_hydrochloride_5_MG_Oral_Tablet();
		IEnumerable<CqlCode> ae_ = context.Operators.ToList<CqlCode>(ad_);
		IEnumerable<MedicationRequest> af_ = context.Operators.RetrieveByCodes<MedicationRequest>(ae_, null);
		IEnumerable<CqlCode> ah_ = context.Operators.ToList<CqlCode>(ad_);
		IEnumerable<MedicationRequest> ai_ = context.Operators.RetrieveByCodes<MedicationRequest>(ah_, null);
		IEnumerable<MedicationRequest> aj_ = context.Operators.ListUnion<MedicationRequest>(af_, ai_);
		IEnumerable<MedicationRequest> ak_ = context.Operators.ListUnion<MedicationRequest>(ac_, aj_);
		CqlValueSet al_ = this.Methylphenidate();
		IEnumerable<MedicationRequest> am_ = context.Operators.RetrieveByValueSet<MedicationRequest>(al_, null);
		IEnumerable<MedicationRequest> ao_ = context.Operators.RetrieveByValueSet<MedicationRequest>(al_, null);
		IEnumerable<MedicationRequest> ap_ = context.Operators.ListUnion<MedicationRequest>(am_, ao_);
		IEnumerable<MedicationRequest> aq_ = context.Operators.ListUnion<MedicationRequest>(ak_, ap_);
		CqlValueSet ar_ = this.Guanfacine();
		IEnumerable<MedicationRequest> as_ = context.Operators.RetrieveByValueSet<MedicationRequest>(ar_, null);
		IEnumerable<MedicationRequest> au_ = context.Operators.RetrieveByValueSet<MedicationRequest>(ar_, null);
		IEnumerable<MedicationRequest> av_ = context.Operators.ListUnion<MedicationRequest>(as_, au_);
		IEnumerable<MedicationRequest> aw_ = context.Operators.ListUnion<MedicationRequest>(aq_, av_);
		bool? ax_(MedicationRequest ADHDMedications)
		{
			CqlInterval<CqlDate> df_ = CumulativeMedicationDuration_4_0_000.MedicationRequestPeriod(ADHDMedications);
			CqlDate dg_ = context.Operators.Start(df_);
			CqlDateTime dh_ = context.Operators.ConvertDateToDateTime(dg_);
			CqlInterval<CqlDateTime> di_ = this.Intake_Period();
			bool? dj_ = context.Operators.In<CqlDateTime>(dh_, di_, null);

			return dj_;
		};
		IEnumerable<MedicationRequest> ay_ = context.Operators.Where<MedicationRequest>(aw_, ax_);
		IEnumerable<MedicationRequest> ba_ = context.Operators.RetrieveByValueSet<MedicationRequest>(a_, null);
		IEnumerable<MedicationRequest> bc_ = context.Operators.RetrieveByValueSet<MedicationRequest>(a_, null);
		IEnumerable<MedicationRequest> bd_ = context.Operators.ListUnion<MedicationRequest>(ba_, bc_);
		IEnumerable<MedicationRequest> bf_ = context.Operators.RetrieveByValueSet<MedicationRequest>(f_, null);
		IEnumerable<MedicationRequest> bh_ = context.Operators.RetrieveByValueSet<MedicationRequest>(f_, null);
		IEnumerable<MedicationRequest> bi_ = context.Operators.ListUnion<MedicationRequest>(bf_, bh_);
		IEnumerable<MedicationRequest> bj_ = context.Operators.ListUnion<MedicationRequest>(bd_, bi_);
		IEnumerable<MedicationRequest> bl_ = context.Operators.RetrieveByValueSet<MedicationRequest>(l_, null);
		IEnumerable<MedicationRequest> bn_ = context.Operators.RetrieveByValueSet<MedicationRequest>(l_, null);
		IEnumerable<MedicationRequest> bo_ = context.Operators.ListUnion<MedicationRequest>(bl_, bn_);
		IEnumerable<MedicationRequest> bp_ = context.Operators.ListUnion<MedicationRequest>(bj_, bo_);
		IEnumerable<MedicationRequest> br_ = context.Operators.RetrieveByValueSet<MedicationRequest>(r_, null);
		IEnumerable<MedicationRequest> bt_ = context.Operators.RetrieveByValueSet<MedicationRequest>(r_, null);
		IEnumerable<MedicationRequest> bu_ = context.Operators.ListUnion<MedicationRequest>(br_, bt_);
		IEnumerable<MedicationRequest> bv_ = context.Operators.ListUnion<MedicationRequest>(bp_, bu_);
		IEnumerable<MedicationRequest> bx_ = context.Operators.RetrieveByValueSet<MedicationRequest>(x_, null);
		IEnumerable<MedicationRequest> bz_ = context.Operators.RetrieveByValueSet<MedicationRequest>(x_, null);
		IEnumerable<MedicationRequest> ca_ = context.Operators.ListUnion<MedicationRequest>(bx_, bz_);
		IEnumerable<MedicationRequest> cb_ = context.Operators.ListUnion<MedicationRequest>(bv_, ca_);
		IEnumerable<CqlCode> cd_ = context.Operators.ToList<CqlCode>(ad_);
		IEnumerable<MedicationRequest> ce_ = context.Operators.RetrieveByCodes<MedicationRequest>(cd_, null);
		IEnumerable<CqlCode> cg_ = context.Operators.ToList<CqlCode>(ad_);
		IEnumerable<MedicationRequest> ch_ = context.Operators.RetrieveByCodes<MedicationRequest>(cg_, null);
		IEnumerable<MedicationRequest> ci_ = context.Operators.ListUnion<MedicationRequest>(ce_, ch_);
		IEnumerable<MedicationRequest> cj_ = context.Operators.ListUnion<MedicationRequest>(cb_, ci_);
		IEnumerable<MedicationRequest> cl_ = context.Operators.RetrieveByValueSet<MedicationRequest>(al_, null);
		IEnumerable<MedicationRequest> cn_ = context.Operators.RetrieveByValueSet<MedicationRequest>(al_, null);
		IEnumerable<MedicationRequest> co_ = context.Operators.ListUnion<MedicationRequest>(cl_, cn_);
		IEnumerable<MedicationRequest> cp_ = context.Operators.ListUnion<MedicationRequest>(cj_, co_);
		IEnumerable<MedicationRequest> cr_ = context.Operators.RetrieveByValueSet<MedicationRequest>(ar_, null);
		IEnumerable<MedicationRequest> ct_ = context.Operators.RetrieveByValueSet<MedicationRequest>(ar_, null);
		IEnumerable<MedicationRequest> cu_ = context.Operators.ListUnion<MedicationRequest>(cr_, ct_);
		IEnumerable<MedicationRequest> cv_ = context.Operators.ListUnion<MedicationRequest>(cp_, cu_);
		bool? cw_(MedicationRequest ADHDMedications)
		{
			CqlInterval<CqlDate> dk_ = CumulativeMedicationDuration_4_0_000.MedicationRequestPeriod(ADHDMedications);
			CqlDate dl_ = context.Operators.Start(dk_);
			CqlDateTime dm_ = context.Operators.ConvertDateToDateTime(dl_);
			CqlInterval<CqlDateTime> dn_ = this.Intake_Period();
			bool? do_ = context.Operators.In<CqlDateTime>(dm_, dn_, null);

			return do_;
		};
		IEnumerable<MedicationRequest> cx_ = context.Operators.Where<MedicationRequest>(cv_, cw_);
		IEnumerable<MedicationRequest> cy_(MedicationRequest ADHDMedicationOrder)
		{
			CqlValueSet dp_ = this.Atomoxetine();
			IEnumerable<MedicationRequest> dq_ = context.Operators.RetrieveByValueSet<MedicationRequest>(dp_, null);
			IEnumerable<MedicationRequest> ds_ = context.Operators.RetrieveByValueSet<MedicationRequest>(dp_, null);
			IEnumerable<MedicationRequest> dt_ = context.Operators.ListUnion<MedicationRequest>(dq_, ds_);
			CqlValueSet du_ = this.Clonidine();
			IEnumerable<MedicationRequest> dv_ = context.Operators.RetrieveByValueSet<MedicationRequest>(du_, null);
			IEnumerable<MedicationRequest> dx_ = context.Operators.RetrieveByValueSet<MedicationRequest>(du_, null);
			IEnumerable<MedicationRequest> dy_ = context.Operators.ListUnion<MedicationRequest>(dv_, dx_);
			IEnumerable<MedicationRequest> dz_ = context.Operators.ListUnion<MedicationRequest>(dt_, dy_);
			CqlValueSet ea_ = this.Dexmethylphenidate();
			IEnumerable<MedicationRequest> eb_ = context.Operators.RetrieveByValueSet<MedicationRequest>(ea_, null);
			IEnumerable<MedicationRequest> ed_ = context.Operators.RetrieveByValueSet<MedicationRequest>(ea_, null);
			IEnumerable<MedicationRequest> ee_ = context.Operators.ListUnion<MedicationRequest>(eb_, ed_);
			IEnumerable<MedicationRequest> ef_ = context.Operators.ListUnion<MedicationRequest>(dz_, ee_);
			CqlValueSet eg_ = this.Dextroamphetamine();
			IEnumerable<MedicationRequest> eh_ = context.Operators.RetrieveByValueSet<MedicationRequest>(eg_, null);
			IEnumerable<MedicationRequest> ej_ = context.Operators.RetrieveByValueSet<MedicationRequest>(eg_, null);
			IEnumerable<MedicationRequest> ek_ = context.Operators.ListUnion<MedicationRequest>(eh_, ej_);
			IEnumerable<MedicationRequest> el_ = context.Operators.ListUnion<MedicationRequest>(ef_, ek_);
			CqlValueSet em_ = this.Lisdexamfetamine();
			IEnumerable<MedicationRequest> en_ = context.Operators.RetrieveByValueSet<MedicationRequest>(em_, null);
			IEnumerable<MedicationRequest> ep_ = context.Operators.RetrieveByValueSet<MedicationRequest>(em_, null);
			IEnumerable<MedicationRequest> eq_ = context.Operators.ListUnion<MedicationRequest>(en_, ep_);
			IEnumerable<MedicationRequest> er_ = context.Operators.ListUnion<MedicationRequest>(el_, eq_);
			CqlCode es_ = this.methamphetamine_hydrochloride_5_MG_Oral_Tablet();
			IEnumerable<CqlCode> et_ = context.Operators.ToList<CqlCode>(es_);
			IEnumerable<MedicationRequest> eu_ = context.Operators.RetrieveByCodes<MedicationRequest>(et_, null);
			IEnumerable<CqlCode> ew_ = context.Operators.ToList<CqlCode>(es_);
			IEnumerable<MedicationRequest> ex_ = context.Operators.RetrieveByCodes<MedicationRequest>(ew_, null);
			IEnumerable<MedicationRequest> ey_ = context.Operators.ListUnion<MedicationRequest>(eu_, ex_);
			IEnumerable<MedicationRequest> ez_ = context.Operators.ListUnion<MedicationRequest>(er_, ey_);
			CqlValueSet fa_ = this.Methylphenidate();
			IEnumerable<MedicationRequest> fb_ = context.Operators.RetrieveByValueSet<MedicationRequest>(fa_, null);
			IEnumerable<MedicationRequest> fd_ = context.Operators.RetrieveByValueSet<MedicationRequest>(fa_, null);
			IEnumerable<MedicationRequest> fe_ = context.Operators.ListUnion<MedicationRequest>(fb_, fd_);
			IEnumerable<MedicationRequest> ff_ = context.Operators.ListUnion<MedicationRequest>(ez_, fe_);
			CqlValueSet fg_ = this.Guanfacine();
			IEnumerable<MedicationRequest> fh_ = context.Operators.RetrieveByValueSet<MedicationRequest>(fg_, null);
			IEnumerable<MedicationRequest> fj_ = context.Operators.RetrieveByValueSet<MedicationRequest>(fg_, null);
			IEnumerable<MedicationRequest> fk_ = context.Operators.ListUnion<MedicationRequest>(fh_, fj_);
			IEnumerable<MedicationRequest> fl_ = context.Operators.ListUnion<MedicationRequest>(ff_, fk_);
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
				bool? gc_ = context.Operators.Overlaps(fq_, gb_, null);

				return gc_;
			};
			IEnumerable<MedicationRequest> fn_ = context.Operators.Where<MedicationRequest>(fl_, fm_);
			MedicationRequest fo_(MedicationRequest ActiveADHDMedication) => 
				ADHDMedicationOrder;
			IEnumerable<MedicationRequest> fp_ = context.Operators.Select<MedicationRequest, MedicationRequest>(fn_, fo_);

			return fp_;
		};
		IEnumerable<MedicationRequest> cz_ = context.Operators.SelectMany<MedicationRequest, MedicationRequest>(cx_, cy_);
		IEnumerable<MedicationRequest> da_ = context.Operators.ListExcept<MedicationRequest>(ay_, cz_);
		Tuple_GgbdNTdhNeafRfiEMSgeHDMdE db_(MedicationRequest QualifyingMed)
		{
			CqlInterval<CqlDate> gd_ = CumulativeMedicationDuration_4_0_000.MedicationRequestPeriod(QualifyingMed);
			CqlDate ge_ = context.Operators.Start(gd_);
			Tuple_GgbdNTdhNeafRfiEMSgeHDMdE gf_ = new Tuple_GgbdNTdhNeafRfiEMSgeHDMdE
			{
				startDate = ge_,
			};

			return gf_;
		};
		IEnumerable<Tuple_GgbdNTdhNeafRfiEMSgeHDMdE> dc_ = context.Operators.Select<MedicationRequest, Tuple_GgbdNTdhNeafRfiEMSgeHDMdE>(da_, db_);
		object dd_(Tuple_GgbdNTdhNeafRfiEMSgeHDMdE @this) => 
			@this?.startDate;
		IEnumerable<Tuple_GgbdNTdhNeafRfiEMSgeHDMdE> de_ = context.Operators.SortBy<Tuple_GgbdNTdhNeafRfiEMSgeHDMdE>(dc_, dd_, System.ComponentModel.ListSortDirection.Ascending);

		return de_;
	}

    [CqlDeclaration("ADHD Medication Prescribed During Intake Period and Not Previously on ADHD Medication")]
	public IEnumerable<Tuple_GgbdNTdhNeafRfiEMSgeHDMdE> ADHD_Medication_Prescribed_During_Intake_Period_and_Not_Previously_on_ADHD_Medication() => 
		__ADHD_Medication_Prescribed_During_Intake_Period_and_Not_Previously_on_ADHD_Medication.Value;

	private CqlDate First_ADHD_Medication_Prescribed_During_Intake_Period_Value()
	{
		IEnumerable<Tuple_GgbdNTdhNeafRfiEMSgeHDMdE> a_ = this.ADHD_Medication_Prescribed_During_Intake_Period_and_Not_Previously_on_ADHD_Medication();
		bool? b_(Tuple_GgbdNTdhNeafRfiEMSgeHDMdE @this)
		{
			bool? g_ = context.Operators.Not((bool?)(@this?.startDate is null));

			return g_;
		};
		IEnumerable<Tuple_GgbdNTdhNeafRfiEMSgeHDMdE> c_ = context.Operators.Where<Tuple_GgbdNTdhNeafRfiEMSgeHDMdE>(a_, b_);
		CqlDate d_(Tuple_GgbdNTdhNeafRfiEMSgeHDMdE @this) => 
			@this?.startDate;
		IEnumerable<CqlDate> e_ = context.Operators.Select<Tuple_GgbdNTdhNeafRfiEMSgeHDMdE, CqlDate>(c_, d_);
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
		IEnumerable<Encounter> b_ = context.Operators.RetrieveByValueSet<Encounter>(a_, null);
		CqlValueSet c_ = this.Home_Healthcare_Services();
		IEnumerable<Encounter> d_ = context.Operators.RetrieveByValueSet<Encounter>(c_, null);
		IEnumerable<Encounter> e_ = context.Operators.ListUnion<Encounter>(b_, d_);
		CqlValueSet f_ = this.Preventive_Care__Established_Office_Visit__0_to_17();
		IEnumerable<Encounter> g_ = context.Operators.RetrieveByValueSet<Encounter>(f_, null);
		CqlValueSet h_ = this.Preventive_Care_Services__Initial_Office_Visit__0_to_17();
		IEnumerable<Encounter> i_ = context.Operators.RetrieveByValueSet<Encounter>(h_, null);
		IEnumerable<Encounter> j_ = context.Operators.ListUnion<Encounter>(g_, i_);
		IEnumerable<Encounter> k_ = context.Operators.ListUnion<Encounter>(e_, j_);
		bool? l_(Encounter ValidEncounters)
		{
			CqlDate n_ = this.IPSD();
			CqlQuantity o_ = context.Operators.Quantity(6m, "months");
			CqlDate p_ = context.Operators.Subtract(n_, o_);
			CqlInterval<CqlDate> r_ = context.Operators.Interval(p_, n_, true, true);
			CqlDateTime s_ = context.Operators.ConvertDateToDateTime(r_?.low);
			CqlDate v_ = context.Operators.Subtract(n_, o_);
			CqlInterval<CqlDate> x_ = context.Operators.Interval(v_, n_, true, true);
			CqlDateTime y_ = context.Operators.ConvertDateToDateTime(x_?.high);
			CqlDate ab_ = context.Operators.Subtract(n_, o_);
			CqlInterval<CqlDate> ad_ = context.Operators.Interval(ab_, n_, true, true);
			CqlDate ag_ = context.Operators.Subtract(n_, o_);
			CqlInterval<CqlDate> ai_ = context.Operators.Interval(ag_, n_, true, true);
			CqlInterval<CqlDateTime> aj_ = context.Operators.Interval(s_, y_, ad_?.lowClosed, ai_?.highClosed);
			CqlInterval<CqlDateTime> ak_ = FHIRHelpers_4_3_000.ToInterval(ValidEncounters?.Period);
			CqlInterval<CqlDateTime> al_ = QICoreCommon_2_0_000.ToInterval((ak_ as object));
			bool? am_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(aj_, al_, "day");

			return am_;
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
		bool? a_(Encounter.DiagnosisComponent D)
		{
			bool? e_ = context.Operators.Equal(D?.RankElement?.Value, 1);

			return e_;
		};
		IEnumerable<Encounter.DiagnosisComponent> b_ = context.Operators.Where<Encounter.DiagnosisComponent>((Encounter?.Diagnosis as IEnumerable<Encounter.DiagnosisComponent>), a_);
		Condition c_(Encounter.DiagnosisComponent PD)
		{
			IEnumerable<Condition> f_ = context.Operators.RetrieveByValueSet<Condition>(null, null);
			bool? g_(Condition C)
			{
				string j_ = QICoreCommon_2_0_000.getId(PD?.Condition?.ReferenceElement?.Value);
				bool? k_ = context.Operators.Equal(C?.IdElement?.Value, j_);

				return k_;
			};
			IEnumerable<Condition> h_ = context.Operators.Where<Condition>(f_, g_);
			Condition i_ = context.Operators.SingletonFrom<Condition>(h_);

			return i_;
		};
		IEnumerable<Condition> d_ = context.Operators.Select<Encounter.DiagnosisComponent, Condition>(b_, c_);

		return d_;
	}

	private IEnumerable<Encounter> Inpatient_Stay_with_Qualifying_Diagnosis_Value()
	{
		CqlValueSet a_ = this.Encounter_Inpatient();
		IEnumerable<Encounter> b_ = context.Operators.RetrieveByValueSet<Encounter>(a_, null);
		bool? c_(Encounter InpatientStay)
		{
			IEnumerable<Condition> e_ = this.PrincipalDiagnosis(InpatientStay);
			bool? f_(Condition EncounterDiagnosis)
			{
				CqlConcept i_ = FHIRHelpers_4_3_000.ToConcept(EncounterDiagnosis?.Code);
				CqlValueSet j_ = this.Mental_Behavioral_and_Neurodevelopmental_Disorders();
				bool? k_ = context.Operators.ConceptInValueSet(i_, j_);

				return k_;
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
			CqlInterval<CqlDateTime> d_ = FHIRHelpers_4_3_000.ToInterval(InpatientStay?.Period);
			CqlInterval<CqlDate> e_ = CQMCommon_2_0_000.ToDateInterval(d_);
			CqlDate f_ = context.Operators.Start(e_);
			CqlDate g_ = this.IPSD();
			CqlQuantity i_ = context.Operators.Quantity(30m, "days");
			CqlDate j_ = context.Operators.Add(g_, i_);
			CqlInterval<CqlDate> k_ = context.Operators.Interval(g_, j_, false, true);
			bool? l_ = context.Operators.In<CqlDate>(f_, k_, "day");
			bool? n_ = context.Operators.Not((bool?)(g_ is null));
			bool? o_ = context.Operators.And(l_, n_);

			return o_;
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
		CqlDate b_ = context.Operators.Convert<CqlDate>(a_?.BirthDateElement?.Value);
		CqlInterval<CqlDateTime> c_ = this.Intake_Period();
		CqlDateTime d_ = context.Operators.Start(c_);
		CqlDate e_ = context.Operators.DateFrom(d_);
		int? f_ = context.Operators.CalculateAgeAt(b_, e_, "year");
		bool? g_ = context.Operators.GreaterOrEqual(f_, 6);
		CqlDate i_ = context.Operators.Convert<CqlDate>(a_?.BirthDateElement?.Value);
		CqlDateTime k_ = context.Operators.End(c_);
		CqlDate l_ = context.Operators.DateFrom(k_);
		int? m_ = context.Operators.CalculateAgeAt(i_, l_, "year");
		bool? n_ = context.Operators.LessOrEqual(m_, 12);
		bool? o_ = context.Operators.And(g_, n_);
		IEnumerable<Encounter> p_ = this.Qualifying_Encounter();
		bool? q_ = context.Operators.Exists<Encounter>(p_);
		bool? r_ = context.Operators.And(o_, q_);
		CqlDate s_ = this.First_ADHD_Medication_Prescribed_During_Intake_Period();
		bool? t_ = context.Operators.Not((bool?)(s_ is null));
		bool? u_ = context.Operators.And(r_, t_);
		IEnumerable<Encounter> v_ = this.Inpatient_Stay_with_Qualifying_Diagnosis_During_Initiation_Phase();
		bool? w_ = context.Operators.Exists<Encounter>(v_);
		bool? x_ = context.Operators.Not(w_);
		bool? y_ = context.Operators.And(u_, x_);

		return y_;
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
		IEnumerable<Condition> b_ = context.Operators.RetrieveByValueSet<Condition>(a_, null);
		bool? c_(Condition Narcolepsy)
		{
			CqlInterval<CqlDateTime> e_ = QICoreCommon_2_0_000.ToPrevalenceInterval(Narcolepsy);
			CqlDateTime f_ = context.Operators.Start(e_);
			CqlInterval<CqlDateTime> g_ = this.Measurement_Period();
			CqlDateTime h_ = context.Operators.End(g_);
			bool? i_ = context.Operators.SameOrBefore(f_, h_, null);

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
		IEnumerable<Encounter> b_ = context.Operators.RetrieveByValueSet<Encounter>(a_, null);
		CqlValueSet c_ = this.Initial_Hospital_Observation_Care();
		IEnumerable<Encounter> d_ = context.Operators.RetrieveByValueSet<Encounter>(c_, null);
		IEnumerable<Encounter> e_ = context.Operators.ListUnion<Encounter>(b_, d_);
		CqlValueSet f_ = this.Preventive_Care_Services_Group_Counseling();
		IEnumerable<Encounter> g_ = context.Operators.RetrieveByValueSet<Encounter>(f_, null);
		CqlValueSet h_ = this.Behavioral_Health_Follow_up_Visit();
		IEnumerable<Encounter> i_ = context.Operators.RetrieveByValueSet<Encounter>(h_, null);
		IEnumerable<Encounter> j_ = context.Operators.ListUnion<Encounter>(g_, i_);
		IEnumerable<Encounter> k_ = context.Operators.ListUnion<Encounter>(e_, j_);
		CqlValueSet l_ = this.Preventive_Care_Services_Individual_Counseling();
		IEnumerable<Encounter> m_ = context.Operators.RetrieveByValueSet<Encounter>(l_, null);
		CqlValueSet n_ = this.Psychotherapy_and_Pharmacologic_Management();
		IEnumerable<Encounter> o_ = context.Operators.RetrieveByValueSet<Encounter>(n_, null);
		bool? p_(Encounter PsychPharmManagement)
		{
			bool? ao_(Encounter.LocationComponent Location)
			{
				Location ar_ = CQMCommon_2_0_000.GetLocation(Location?.Location);
				CqlConcept as_(CodeableConcept @this)
				{
					CqlConcept aw_ = FHIRHelpers_4_3_000.ToConcept(@this);

					return aw_;
				};
				IEnumerable<CqlConcept> at_ = context.Operators.Select<CodeableConcept, CqlConcept>(ar_?.Type, as_);
				CqlValueSet au_ = this.Ambulatory();
				bool? av_ = context.Operators.ConceptsInValueSet(at_, au_);

				return av_;
			};
			IEnumerable<Encounter.LocationComponent> ap_ = context.Operators.Where<Encounter.LocationComponent>((PsychPharmManagement?.Location as IEnumerable<Encounter.LocationComponent>), ao_);
			bool? aq_ = context.Operators.Exists<Encounter.LocationComponent>(ap_);

			return aq_;
		};
		IEnumerable<Encounter> q_ = context.Operators.Where<Encounter>(o_, p_);
		IEnumerable<Encounter> r_ = context.Operators.ListUnion<Encounter>(m_, q_);
		IEnumerable<Encounter> s_ = context.Operators.ListUnion<Encounter>(k_, r_);
		CqlValueSet t_ = this.Outpatient_Consultation();
		IEnumerable<Encounter> u_ = context.Operators.RetrieveByValueSet<Encounter>(t_, null);
		CqlValueSet v_ = this.Home_Healthcare_Services();
		IEnumerable<Encounter> w_ = context.Operators.RetrieveByValueSet<Encounter>(v_, null);
		IEnumerable<Encounter> x_ = context.Operators.ListUnion<Encounter>(u_, w_);
		IEnumerable<Encounter> y_ = context.Operators.ListUnion<Encounter>(s_, x_);
		CqlValueSet z_ = this.Preventive_Care_Services__Initial_Office_Visit__0_to_17();
		IEnumerable<Encounter> aa_ = context.Operators.RetrieveByValueSet<Encounter>(z_, null);
		CqlValueSet ab_ = this.Preventive_Care__Established_Office_Visit__0_to_17();
		IEnumerable<Encounter> ac_ = context.Operators.RetrieveByValueSet<Encounter>(ab_, null);
		IEnumerable<Encounter> ad_ = context.Operators.ListUnion<Encounter>(aa_, ac_);
		IEnumerable<Encounter> ae_ = context.Operators.ListUnion<Encounter>(y_, ad_);
		CqlValueSet af_ = this.Psych_Visit_Diagnostic_Evaluation();
		IEnumerable<Encounter> ag_ = context.Operators.RetrieveByValueSet<Encounter>(af_, null);
		CqlValueSet ah_ = this.Psych_Visit_Psychotherapy();
		IEnumerable<Encounter> ai_ = context.Operators.RetrieveByValueSet<Encounter>(ah_, null);
		IEnumerable<Encounter> aj_ = context.Operators.ListUnion<Encounter>(ag_, ai_);
		IEnumerable<Encounter> ak_ = context.Operators.ListUnion<Encounter>(ae_, aj_);
		CqlValueSet al_ = this.Telephone_Visits();
		IEnumerable<Encounter> am_ = context.Operators.RetrieveByValueSet<Encounter>(al_, null);
		IEnumerable<Encounter> an_ = context.Operators.ListUnion<Encounter>(ak_, am_);

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
			CqlInterval<CqlDateTime> d_ = FHIRHelpers_4_3_000.ToInterval(ValidNumeratorEncounter?.Period);
			CqlInterval<CqlDate> e_ = CQMCommon_2_0_000.ToDateInterval(d_);
			CqlDate f_ = context.Operators.Start(e_);
			CqlDate g_ = this.IPSD();
			CqlQuantity i_ = context.Operators.Quantity(30m, "days");
			CqlDate j_ = context.Operators.Add(g_, i_);
			CqlInterval<CqlDate> k_ = context.Operators.Interval(g_, j_, false, true);
			bool? l_ = context.Operators.In<CqlDate>(f_, k_, "day");
			bool? n_ = context.Operators.Not((bool?)(g_ is null));
			bool? o_ = context.Operators.And(l_, n_);

			return o_;
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
		IEnumerable<MedicationRequest> b_ = context.Operators.RetrieveByValueSet<MedicationRequest>(a_, null);
		IEnumerable<MedicationRequest> d_ = context.Operators.RetrieveByValueSet<MedicationRequest>(a_, null);
		IEnumerable<MedicationRequest> e_ = context.Operators.ListUnion<MedicationRequest>(b_, d_);
		Tuple_DAGCHJJjDfWYJVbiHKMLJjYRS f_(MedicationRequest AtomoxetineMed)
		{
			CqlInterval<CqlDate> dt_ = CumulativeMedicationDuration_4_0_000.MedicationRequestPeriod(AtomoxetineMed);
			CqlDate dv_ = context.Operators.Start(dt_);
			Tuple_DAGCHJJjDfWYJVbiHKMLJjYRS dw_ = new Tuple_DAGCHJJjDfWYJVbiHKMLJjYRS
			{
				period = dt_,
				periodStart = dv_,
			};

			return dw_;
		};
		IEnumerable<Tuple_DAGCHJJjDfWYJVbiHKMLJjYRS> g_ = context.Operators.Select<MedicationRequest, Tuple_DAGCHJJjDfWYJVbiHKMLJjYRS>(e_, f_);
		object h_(Tuple_DAGCHJJjDfWYJVbiHKMLJjYRS @this) => 
			@this?.periodStart;
		IEnumerable<Tuple_DAGCHJJjDfWYJVbiHKMLJjYRS> i_ = context.Operators.SortBy<Tuple_DAGCHJJjDfWYJVbiHKMLJjYRS>(g_, h_, System.ComponentModel.ListSortDirection.Ascending);
		bool? j_(Tuple_DAGCHJJjDfWYJVbiHKMLJjYRS @this)
		{
			bool? dx_ = context.Operators.Not((bool?)(@this?.period is null));

			return dx_;
		};
		IEnumerable<Tuple_DAGCHJJjDfWYJVbiHKMLJjYRS> k_ = context.Operators.Where<Tuple_DAGCHJJjDfWYJVbiHKMLJjYRS>(i_, j_);
		CqlInterval<CqlDate> l_(Tuple_DAGCHJJjDfWYJVbiHKMLJjYRS @this) => 
			@this?.period;
		IEnumerable<CqlInterval<CqlDate>> m_ = context.Operators.Select<Tuple_DAGCHJJjDfWYJVbiHKMLJjYRS, CqlInterval<CqlDate>>(k_, l_);
		IEnumerable<CqlInterval<CqlDate>> n_ = CumulativeMedicationDuration_4_0_000.RolloutIntervals(m_);
		CqlValueSet o_ = this.Clonidine();
		IEnumerable<MedicationRequest> p_ = context.Operators.RetrieveByValueSet<MedicationRequest>(o_, null);
		IEnumerable<MedicationRequest> r_ = context.Operators.RetrieveByValueSet<MedicationRequest>(o_, null);
		IEnumerable<MedicationRequest> s_ = context.Operators.ListUnion<MedicationRequest>(p_, r_);
		Tuple_DAGCHJJjDfWYJVbiHKMLJjYRS t_(MedicationRequest ClonidineMed)
		{
			CqlInterval<CqlDate> dy_ = CumulativeMedicationDuration_4_0_000.MedicationRequestPeriod(ClonidineMed);
			CqlDate ea_ = context.Operators.Start(dy_);
			Tuple_DAGCHJJjDfWYJVbiHKMLJjYRS eb_ = new Tuple_DAGCHJJjDfWYJVbiHKMLJjYRS
			{
				period = dy_,
				periodStart = ea_,
			};

			return eb_;
		};
		IEnumerable<Tuple_DAGCHJJjDfWYJVbiHKMLJjYRS> u_ = context.Operators.Select<MedicationRequest, Tuple_DAGCHJJjDfWYJVbiHKMLJjYRS>(s_, t_);
		IEnumerable<Tuple_DAGCHJJjDfWYJVbiHKMLJjYRS> w_ = context.Operators.SortBy<Tuple_DAGCHJJjDfWYJVbiHKMLJjYRS>(u_, h_, System.ComponentModel.ListSortDirection.Ascending);
		bool? x_(Tuple_DAGCHJJjDfWYJVbiHKMLJjYRS @this)
		{
			bool? ec_ = context.Operators.Not((bool?)(@this?.period is null));

			return ec_;
		};
		IEnumerable<Tuple_DAGCHJJjDfWYJVbiHKMLJjYRS> y_ = context.Operators.Where<Tuple_DAGCHJJjDfWYJVbiHKMLJjYRS>(w_, x_);
		IEnumerable<CqlInterval<CqlDate>> aa_ = context.Operators.Select<Tuple_DAGCHJJjDfWYJVbiHKMLJjYRS, CqlInterval<CqlDate>>(y_, l_);
		IEnumerable<CqlInterval<CqlDate>> ab_ = CumulativeMedicationDuration_4_0_000.RolloutIntervals(aa_);
		IEnumerable<CqlInterval<CqlDate>> ac_ = context.Operators.ListUnion<CqlInterval<CqlDate>>(n_, ab_);
		CqlValueSet ad_ = this.Dexmethylphenidate();
		IEnumerable<MedicationRequest> ae_ = context.Operators.RetrieveByValueSet<MedicationRequest>(ad_, null);
		IEnumerable<MedicationRequest> ag_ = context.Operators.RetrieveByValueSet<MedicationRequest>(ad_, null);
		IEnumerable<MedicationRequest> ah_ = context.Operators.ListUnion<MedicationRequest>(ae_, ag_);
		Tuple_DAGCHJJjDfWYJVbiHKMLJjYRS ai_(MedicationRequest DexmethylphenidateMed)
		{
			CqlInterval<CqlDate> ed_ = CumulativeMedicationDuration_4_0_000.MedicationRequestPeriod(DexmethylphenidateMed);
			CqlDate ef_ = context.Operators.Start(ed_);
			Tuple_DAGCHJJjDfWYJVbiHKMLJjYRS eg_ = new Tuple_DAGCHJJjDfWYJVbiHKMLJjYRS
			{
				period = ed_,
				periodStart = ef_,
			};

			return eg_;
		};
		IEnumerable<Tuple_DAGCHJJjDfWYJVbiHKMLJjYRS> aj_ = context.Operators.Select<MedicationRequest, Tuple_DAGCHJJjDfWYJVbiHKMLJjYRS>(ah_, ai_);
		IEnumerable<Tuple_DAGCHJJjDfWYJVbiHKMLJjYRS> al_ = context.Operators.SortBy<Tuple_DAGCHJJjDfWYJVbiHKMLJjYRS>(aj_, h_, System.ComponentModel.ListSortDirection.Ascending);
		bool? am_(Tuple_DAGCHJJjDfWYJVbiHKMLJjYRS @this)
		{
			bool? eh_ = context.Operators.Not((bool?)(@this?.period is null));

			return eh_;
		};
		IEnumerable<Tuple_DAGCHJJjDfWYJVbiHKMLJjYRS> an_ = context.Operators.Where<Tuple_DAGCHJJjDfWYJVbiHKMLJjYRS>(al_, am_);
		IEnumerable<CqlInterval<CqlDate>> ap_ = context.Operators.Select<Tuple_DAGCHJJjDfWYJVbiHKMLJjYRS, CqlInterval<CqlDate>>(an_, l_);
		IEnumerable<CqlInterval<CqlDate>> aq_ = CumulativeMedicationDuration_4_0_000.RolloutIntervals(ap_);
		CqlValueSet ar_ = this.Dextroamphetamine();
		IEnumerable<MedicationRequest> as_ = context.Operators.RetrieveByValueSet<MedicationRequest>(ar_, null);
		IEnumerable<MedicationRequest> au_ = context.Operators.RetrieveByValueSet<MedicationRequest>(ar_, null);
		IEnumerable<MedicationRequest> av_ = context.Operators.ListUnion<MedicationRequest>(as_, au_);
		Tuple_DAGCHJJjDfWYJVbiHKMLJjYRS aw_(MedicationRequest DextroamphetamineMed)
		{
			CqlInterval<CqlDate> ei_ = CumulativeMedicationDuration_4_0_000.MedicationRequestPeriod(DextroamphetamineMed);
			CqlDate ek_ = context.Operators.Start(ei_);
			Tuple_DAGCHJJjDfWYJVbiHKMLJjYRS el_ = new Tuple_DAGCHJJjDfWYJVbiHKMLJjYRS
			{
				period = ei_,
				periodStart = ek_,
			};

			return el_;
		};
		IEnumerable<Tuple_DAGCHJJjDfWYJVbiHKMLJjYRS> ax_ = context.Operators.Select<MedicationRequest, Tuple_DAGCHJJjDfWYJVbiHKMLJjYRS>(av_, aw_);
		IEnumerable<Tuple_DAGCHJJjDfWYJVbiHKMLJjYRS> az_ = context.Operators.SortBy<Tuple_DAGCHJJjDfWYJVbiHKMLJjYRS>(ax_, h_, System.ComponentModel.ListSortDirection.Ascending);
		bool? ba_(Tuple_DAGCHJJjDfWYJVbiHKMLJjYRS @this)
		{
			bool? em_ = context.Operators.Not((bool?)(@this?.period is null));

			return em_;
		};
		IEnumerable<Tuple_DAGCHJJjDfWYJVbiHKMLJjYRS> bb_ = context.Operators.Where<Tuple_DAGCHJJjDfWYJVbiHKMLJjYRS>(az_, ba_);
		IEnumerable<CqlInterval<CqlDate>> bd_ = context.Operators.Select<Tuple_DAGCHJJjDfWYJVbiHKMLJjYRS, CqlInterval<CqlDate>>(bb_, l_);
		IEnumerable<CqlInterval<CqlDate>> be_ = CumulativeMedicationDuration_4_0_000.RolloutIntervals(bd_);
		IEnumerable<CqlInterval<CqlDate>> bf_ = context.Operators.ListUnion<CqlInterval<CqlDate>>(aq_, be_);
		IEnumerable<CqlInterval<CqlDate>> bg_ = context.Operators.ListUnion<CqlInterval<CqlDate>>(ac_, bf_);
		CqlValueSet bh_ = this.Lisdexamfetamine();
		IEnumerable<MedicationRequest> bi_ = context.Operators.RetrieveByValueSet<MedicationRequest>(bh_, null);
		IEnumerable<MedicationRequest> bk_ = context.Operators.RetrieveByValueSet<MedicationRequest>(bh_, null);
		IEnumerable<MedicationRequest> bl_ = context.Operators.ListUnion<MedicationRequest>(bi_, bk_);
		Tuple_DAGCHJJjDfWYJVbiHKMLJjYRS bm_(MedicationRequest LisdexamfetamineMed)
		{
			CqlInterval<CqlDate> en_ = CumulativeMedicationDuration_4_0_000.MedicationRequestPeriod(LisdexamfetamineMed);
			CqlDate ep_ = context.Operators.Start(en_);
			Tuple_DAGCHJJjDfWYJVbiHKMLJjYRS eq_ = new Tuple_DAGCHJJjDfWYJVbiHKMLJjYRS
			{
				period = en_,
				periodStart = ep_,
			};

			return eq_;
		};
		IEnumerable<Tuple_DAGCHJJjDfWYJVbiHKMLJjYRS> bn_ = context.Operators.Select<MedicationRequest, Tuple_DAGCHJJjDfWYJVbiHKMLJjYRS>(bl_, bm_);
		IEnumerable<Tuple_DAGCHJJjDfWYJVbiHKMLJjYRS> bp_ = context.Operators.SortBy<Tuple_DAGCHJJjDfWYJVbiHKMLJjYRS>(bn_, h_, System.ComponentModel.ListSortDirection.Ascending);
		bool? bq_(Tuple_DAGCHJJjDfWYJVbiHKMLJjYRS @this)
		{
			bool? er_ = context.Operators.Not((bool?)(@this?.period is null));

			return er_;
		};
		IEnumerable<Tuple_DAGCHJJjDfWYJVbiHKMLJjYRS> br_ = context.Operators.Where<Tuple_DAGCHJJjDfWYJVbiHKMLJjYRS>(bp_, bq_);
		IEnumerable<CqlInterval<CqlDate>> bt_ = context.Operators.Select<Tuple_DAGCHJJjDfWYJVbiHKMLJjYRS, CqlInterval<CqlDate>>(br_, l_);
		IEnumerable<CqlInterval<CqlDate>> bu_ = CumulativeMedicationDuration_4_0_000.RolloutIntervals(bt_);
		CqlValueSet bv_ = this.Methylphenidate();
		IEnumerable<MedicationRequest> bw_ = context.Operators.RetrieveByValueSet<MedicationRequest>(bv_, null);
		IEnumerable<MedicationRequest> by_ = context.Operators.RetrieveByValueSet<MedicationRequest>(bv_, null);
		IEnumerable<MedicationRequest> bz_ = context.Operators.ListUnion<MedicationRequest>(bw_, by_);
		Tuple_DAGCHJJjDfWYJVbiHKMLJjYRS ca_(MedicationRequest MethylphenidateMed)
		{
			CqlInterval<CqlDate> es_ = CumulativeMedicationDuration_4_0_000.MedicationRequestPeriod(MethylphenidateMed);
			CqlDate eu_ = context.Operators.Start(es_);
			Tuple_DAGCHJJjDfWYJVbiHKMLJjYRS ev_ = new Tuple_DAGCHJJjDfWYJVbiHKMLJjYRS
			{
				period = es_,
				periodStart = eu_,
			};

			return ev_;
		};
		IEnumerable<Tuple_DAGCHJJjDfWYJVbiHKMLJjYRS> cb_ = context.Operators.Select<MedicationRequest, Tuple_DAGCHJJjDfWYJVbiHKMLJjYRS>(bz_, ca_);
		IEnumerable<Tuple_DAGCHJJjDfWYJVbiHKMLJjYRS> cd_ = context.Operators.SortBy<Tuple_DAGCHJJjDfWYJVbiHKMLJjYRS>(cb_, h_, System.ComponentModel.ListSortDirection.Ascending);
		bool? ce_(Tuple_DAGCHJJjDfWYJVbiHKMLJjYRS @this)
		{
			bool? ew_ = context.Operators.Not((bool?)(@this?.period is null));

			return ew_;
		};
		IEnumerable<Tuple_DAGCHJJjDfWYJVbiHKMLJjYRS> cf_ = context.Operators.Where<Tuple_DAGCHJJjDfWYJVbiHKMLJjYRS>(cd_, ce_);
		IEnumerable<CqlInterval<CqlDate>> ch_ = context.Operators.Select<Tuple_DAGCHJJjDfWYJVbiHKMLJjYRS, CqlInterval<CqlDate>>(cf_, l_);
		IEnumerable<CqlInterval<CqlDate>> ci_ = CumulativeMedicationDuration_4_0_000.RolloutIntervals(ch_);
		IEnumerable<CqlInterval<CqlDate>> cj_ = context.Operators.ListUnion<CqlInterval<CqlDate>>(bu_, ci_);
		IEnumerable<CqlInterval<CqlDate>> ck_ = context.Operators.ListUnion<CqlInterval<CqlDate>>(bg_, cj_);
		CqlValueSet cl_ = this.Guanfacine();
		IEnumerable<MedicationRequest> cm_ = context.Operators.RetrieveByValueSet<MedicationRequest>(cl_, null);
		IEnumerable<MedicationRequest> co_ = context.Operators.RetrieveByValueSet<MedicationRequest>(cl_, null);
		IEnumerable<MedicationRequest> cp_ = context.Operators.ListUnion<MedicationRequest>(cm_, co_);
		Tuple_DAGCHJJjDfWYJVbiHKMLJjYRS cq_(MedicationRequest GuanfacineMed)
		{
			CqlInterval<CqlDate> ex_ = CumulativeMedicationDuration_4_0_000.MedicationRequestPeriod(GuanfacineMed);
			CqlDate ez_ = context.Operators.Start(ex_);
			Tuple_DAGCHJJjDfWYJVbiHKMLJjYRS fa_ = new Tuple_DAGCHJJjDfWYJVbiHKMLJjYRS
			{
				period = ex_,
				periodStart = ez_,
			};

			return fa_;
		};
		IEnumerable<Tuple_DAGCHJJjDfWYJVbiHKMLJjYRS> cr_ = context.Operators.Select<MedicationRequest, Tuple_DAGCHJJjDfWYJVbiHKMLJjYRS>(cp_, cq_);
		IEnumerable<Tuple_DAGCHJJjDfWYJVbiHKMLJjYRS> ct_ = context.Operators.SortBy<Tuple_DAGCHJJjDfWYJVbiHKMLJjYRS>(cr_, h_, System.ComponentModel.ListSortDirection.Ascending);
		bool? cu_(Tuple_DAGCHJJjDfWYJVbiHKMLJjYRS @this)
		{
			bool? fb_ = context.Operators.Not((bool?)(@this?.period is null));

			return fb_;
		};
		IEnumerable<Tuple_DAGCHJJjDfWYJVbiHKMLJjYRS> cv_ = context.Operators.Where<Tuple_DAGCHJJjDfWYJVbiHKMLJjYRS>(ct_, cu_);
		IEnumerable<CqlInterval<CqlDate>> cx_ = context.Operators.Select<Tuple_DAGCHJJjDfWYJVbiHKMLJjYRS, CqlInterval<CqlDate>>(cv_, l_);
		IEnumerable<CqlInterval<CqlDate>> cy_ = CumulativeMedicationDuration_4_0_000.RolloutIntervals(cx_);
		CqlCode cz_ = this.methamphetamine_hydrochloride_5_MG_Oral_Tablet();
		IEnumerable<CqlCode> da_ = context.Operators.ToList<CqlCode>(cz_);
		IEnumerable<MedicationRequest> db_ = context.Operators.RetrieveByCodes<MedicationRequest>(da_, null);
		IEnumerable<CqlCode> dd_ = context.Operators.ToList<CqlCode>(cz_);
		IEnumerable<MedicationRequest> de_ = context.Operators.RetrieveByCodes<MedicationRequest>(dd_, null);
		IEnumerable<MedicationRequest> df_ = context.Operators.ListUnion<MedicationRequest>(db_, de_);
		Tuple_DAGCHJJjDfWYJVbiHKMLJjYRS dg_(MedicationRequest MethamphetamineMed)
		{
			CqlInterval<CqlDate> fc_ = CumulativeMedicationDuration_4_0_000.MedicationRequestPeriod(MethamphetamineMed);
			CqlDate fe_ = context.Operators.Start(fc_);
			Tuple_DAGCHJJjDfWYJVbiHKMLJjYRS ff_ = new Tuple_DAGCHJJjDfWYJVbiHKMLJjYRS
			{
				period = fc_,
				periodStart = fe_,
			};

			return ff_;
		};
		IEnumerable<Tuple_DAGCHJJjDfWYJVbiHKMLJjYRS> dh_ = context.Operators.Select<MedicationRequest, Tuple_DAGCHJJjDfWYJVbiHKMLJjYRS>(df_, dg_);
		IEnumerable<Tuple_DAGCHJJjDfWYJVbiHKMLJjYRS> dj_ = context.Operators.SortBy<Tuple_DAGCHJJjDfWYJVbiHKMLJjYRS>(dh_, h_, System.ComponentModel.ListSortDirection.Ascending);
		bool? dk_(Tuple_DAGCHJJjDfWYJVbiHKMLJjYRS @this)
		{
			bool? fg_ = context.Operators.Not((bool?)(@this?.period is null));

			return fg_;
		};
		IEnumerable<Tuple_DAGCHJJjDfWYJVbiHKMLJjYRS> dl_ = context.Operators.Where<Tuple_DAGCHJJjDfWYJVbiHKMLJjYRS>(dj_, dk_);
		IEnumerable<CqlInterval<CqlDate>> dn_ = context.Operators.Select<Tuple_DAGCHJJjDfWYJVbiHKMLJjYRS, CqlInterval<CqlDate>>(dl_, l_);
		IEnumerable<CqlInterval<CqlDate>> do_ = CumulativeMedicationDuration_4_0_000.RolloutIntervals(dn_);
		IEnumerable<CqlInterval<CqlDate>> dp_ = context.Operators.ListUnion<CqlInterval<CqlDate>>(cy_, do_);
		IEnumerable<CqlInterval<CqlDate>> dq_ = context.Operators.ListUnion<CqlInterval<CqlDate>>(ck_, dp_);
		CqlInterval<CqlDate> dr_(CqlInterval<CqlDate> ADHDMedication)
		{
			CqlDate fh_ = this.IPSD();
			CqlQuantity fj_ = context.Operators.Quantity(300m, "days");
			CqlDate fk_ = context.Operators.Add(fh_, fj_);
			CqlInterval<CqlDate> fl_ = context.Operators.Interval(fh_, fk_, true, true);
			CqlInterval<CqlDate> fm_ = context.Operators.IntervalIntersect<CqlDate>(ADHDMedication, fl_);

			return fm_;
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
			CqlInterval<CqlDateTime> d_ = FHIRHelpers_4_3_000.ToInterval(InpatientStay?.Period);
			CqlInterval<CqlDate> e_ = CQMCommon_2_0_000.ToDateInterval(d_);
			CqlDate f_ = context.Operators.Start(e_);
			CqlDate g_ = this.IPSD();
			CqlQuantity i_ = context.Operators.Quantity(300m, "days");
			CqlDate j_ = context.Operators.Add(g_, i_);
			CqlInterval<CqlDate> k_ = context.Operators.Interval(g_, j_, false, true);
			bool? l_ = context.Operators.In<CqlDate>(f_, k_, "day");
			bool? n_ = context.Operators.Not((bool?)(g_ is null));
			bool? o_ = context.Operators.And(l_, n_);

			return o_;
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
		CqlDate b_ = context.Operators.Convert<CqlDate>(a_?.BirthDateElement?.Value);
		CqlInterval<CqlDateTime> c_ = this.Intake_Period();
		CqlDateTime d_ = context.Operators.Start(c_);
		CqlDate e_ = context.Operators.DateFrom(d_);
		int? f_ = context.Operators.CalculateAgeAt(b_, e_, "year");
		bool? g_ = context.Operators.GreaterOrEqual(f_, 6);
		CqlDate i_ = context.Operators.Convert<CqlDate>(a_?.BirthDateElement?.Value);
		CqlDateTime k_ = context.Operators.End(c_);
		CqlDate l_ = context.Operators.DateFrom(k_);
		int? m_ = context.Operators.CalculateAgeAt(i_, l_, "year");
		bool? n_ = context.Operators.LessOrEqual(m_, 12);
		bool? o_ = context.Operators.And(g_, n_);
		IEnumerable<Encounter> p_ = this.Qualifying_Encounter();
		bool? q_ = context.Operators.Exists<Encounter>(p_);
		bool? r_ = context.Operators.And(o_, q_);
		CqlDate s_ = this.First_ADHD_Medication_Prescribed_During_Intake_Period();
		bool? t_ = context.Operators.Not((bool?)(s_ is null));
		bool? u_ = context.Operators.And(r_, t_);
		bool? v_ = this.Has_ADHD_Cumulative_Medication_Duration_Greater_Than_or_Equal_to_210_Days();
		bool? w_ = context.Operators.And(u_, v_);
		IEnumerable<Encounter> x_ = this.Inpatient_Stay_with_Qualifying_Diagnosis_During_Continuation_and_Maintenance_Phase();
		bool? y_ = context.Operators.Exists<Encounter>(x_);
		bool? z_ = context.Operators.Not(y_);
		bool? aa_ = context.Operators.And(w_, z_);

		return aa_;
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
			CqlInterval<CqlDateTime> f_ = FHIRHelpers_4_3_000.ToInterval(ValidNumeratorEncounter?.Period);
			CqlInterval<CqlDate> g_ = CQMCommon_2_0_000.ToDateInterval(f_);
			CqlDate h_ = context.Operators.Start(g_);
			CqlDate i_ = this.IPSD();
			CqlQuantity j_ = context.Operators.Quantity(31m, "days");
			CqlDate k_ = context.Operators.Add(i_, j_);
			CqlQuantity m_ = context.Operators.Quantity(300m, "days");
			CqlDate n_ = context.Operators.Add(i_, m_);
			CqlInterval<CqlDate> o_ = context.Operators.Interval(k_, n_, true, true);
			bool? p_ = context.Operators.In<CqlDate>(h_, o_, "day");

			return p_;
		};
		IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);
		CqlDate d_(Encounter ValidNumeratorEncounter)
		{
			CqlInterval<CqlDateTime> q_ = FHIRHelpers_4_3_000.ToInterval(ValidNumeratorEncounter?.Period);
			CqlDateTime r_ = context.Operators.Start(q_);
			CqlDate s_ = context.Operators.DateFrom(r_);

			return s_;
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
		IEnumerable<Encounter> b_ = context.Operators.RetrieveByValueSet<Encounter>(a_, null);
		bool? c_(Encounter OnlineAssessment)
		{
			CqlInterval<CqlDateTime> g_ = FHIRHelpers_4_3_000.ToInterval(OnlineAssessment?.Period);
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
		IEnumerable<Encounter> d_ = context.Operators.Where<Encounter>(b_, c_);
		CqlDate e_(Encounter OnlineAssessment)
		{
			CqlInterval<CqlDateTime> r_ = FHIRHelpers_4_3_000.ToInterval(OnlineAssessment?.Period);
			CqlDateTime s_ = context.Operators.Start(r_);
			CqlDate t_ = context.Operators.DateFrom(s_);

			return t_;
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

}
