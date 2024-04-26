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
[CqlLibrary("UseofHighRiskMedicationsintheElderlyFHIR", "0.1.000")]
public class UseofHighRiskMedicationsintheElderlyFHIR_0_1_000
{


    internal CqlContext context;

    #region Cached values

    internal Lazy<CqlValueSet> __Alcohol_Withdrawal;
    internal Lazy<CqlValueSet> __Annual_Wellness_Visit;
    internal Lazy<CqlValueSet> __Anti_Infectives__other;
    internal Lazy<CqlValueSet> __Anticholinergics__anti_Parkinson_agents;
    internal Lazy<CqlValueSet> __Anticholinergics__first_generation_antihistamines;
    internal Lazy<CqlValueSet> __Antipsychotic;
    internal Lazy<CqlValueSet> __Antispasmodics;
    internal Lazy<CqlValueSet> __Antithrombotic;
    internal Lazy<CqlValueSet> __Benzodiazepine_Withdrawal;
    internal Lazy<CqlValueSet> __Benzodiazepine;
    internal Lazy<CqlValueSet> __Bipolar_Disorder;
    internal Lazy<CqlValueSet> __Cardiovascular__alpha_agonists__central;
    internal Lazy<CqlValueSet> __Cardiovascular__other;
    internal Lazy<CqlValueSet> __Care_Services_in_Long_Term_Residential_Facility;
    internal Lazy<CqlValueSet> __Central_nervous_system__antidepressants;
    internal Lazy<CqlValueSet> __Central_nervous_system__barbiturates;
    internal Lazy<CqlValueSet> __Central_nervous_system__other;
    internal Lazy<CqlValueSet> __Central_nervous_system__vasodilators;
    internal Lazy<CqlValueSet> __Digoxin;
    internal Lazy<CqlValueSet> __Discharge_Services_Nursing_Facility;
    internal Lazy<CqlValueSet> __Doxepin;
    internal Lazy<CqlValueSet> __Endocrine_system__estrogens_with_or_without_progestins;
    internal Lazy<CqlValueSet> __Endocrine_system__other;
    internal Lazy<CqlValueSet> __Endocrine_system__sulfonylureas__long_duration;
    internal Lazy<CqlValueSet> __Generalized_Anxiety_Disorder;
    internal Lazy<CqlValueSet> __Home_Healthcare_Services;
    internal Lazy<CqlValueSet> __Nonbenzodiazepine_hypnotics;
    internal Lazy<CqlValueSet> __Nursing_Facility_Visit;
    internal Lazy<CqlValueSet> __Office_Visit;
    internal Lazy<CqlValueSet> __Online_Assessments;
    internal Lazy<CqlValueSet> __Ophthalmologic_Services;
    internal Lazy<CqlValueSet> __Pain_medications__other;
    internal Lazy<CqlValueSet> __Pain_medications__skeletal_muscle_relaxants;
    internal Lazy<CqlValueSet> __Preventive_Care_Services_Established_Office_Visit__18_and_Up;
    internal Lazy<CqlValueSet> __Preventive_Care_Services_Initial_Office_Visit__18_and_Up;
    internal Lazy<CqlValueSet> __REM_Sleep_Behavior_Disorder;
    internal Lazy<CqlValueSet> __Reserpine;
    internal Lazy<CqlValueSet> __Schizophrenia;
    internal Lazy<CqlValueSet> __Seizure_Disorder;
    internal Lazy<CqlValueSet> __Telephone_Visits;
    internal Lazy<CqlCode> ___1_ML_digoxin_0_1_MG_ML_Injection;
    internal Lazy<CqlCode> ___2_ML_digoxin_0_25_MG_ML_Injection;
    internal Lazy<CqlCode> __digoxin_0_05_MG_ML_Oral_Solution;
    internal Lazy<CqlCode> __digoxin_0_0625_MG_Oral_Tablet;
    internal Lazy<CqlCode> __digoxin_0_125_MG_Oral_Tablet;
    internal Lazy<CqlCode> __digoxin_0_1875_MG_Oral_Tablet;
    internal Lazy<CqlCode> __digoxin_0_25_MG_Oral_Tablet;
    internal Lazy<CqlCode> __doxepin_3_MG_Oral_Tablet;
    internal Lazy<CqlCode> __doxepin_6_MG_Oral_Tablet;
    internal Lazy<CqlCode> __doxepin_hydrochloride_10_MG_Oral_Capsule;
    internal Lazy<CqlCode> __doxepin_hydrochloride_10_MG_ML_Oral_Solution;
    internal Lazy<CqlCode> __doxepin_hydrochloride_100_MG_Oral_Capsule;
    internal Lazy<CqlCode> __doxepin_hydrochloride_150_MG_Oral_Capsule;
    internal Lazy<CqlCode> __doxepin_hydrochloride_25_MG_Oral_Capsule;
    internal Lazy<CqlCode> __doxepin_hydrochloride_50_MG_Oral_Capsule;
    internal Lazy<CqlCode> __doxepin_hydrochloride_75_MG_Oral_Capsule;
    internal Lazy<CqlCode> __Office_or_other_outpatient_visit_for_the_evaluation_and_management_of_an_established_patient__that_may_not_require_the_presence_of_a_physician_or_other_qualified_health_care_professional__Usually__the_presenting_problem_s__are_minimal_;
    internal Lazy<CqlCode> __reserpine_0_1_MG_Oral_Tablet;
    internal Lazy<CqlCode> __reserpine_0_25_MG_Oral_Tablet;
    internal Lazy<CqlCode[]> __RXNORM;
    internal Lazy<CqlCode[]> __CPT;
    internal Lazy<CqlInterval<CqlDateTime>> __Measurement_Period;
    internal Lazy<Patient> __Patient;
    internal Lazy<IEnumerable<Encounter>> __Qualifying_Encounters;
    internal Lazy<bool?> __Initial_Population;
    internal Lazy<bool?> __Denominator;
    internal Lazy<bool?> __Denominator_Exclusions;
    internal Lazy<IEnumerable<MedicationRequest>> __Same_High_Risk_Medications_Ordered_on_Different_Days;
    internal Lazy<bool?> __Two_High_Risk_Medications_with_Prolonged_Duration;
    internal Lazy<bool?> __High_Risk_Medications_with_Average_Daily_Dose_Criteria;
    internal Lazy<bool?> __Numerator_1;
    internal Lazy<bool?> __More_than_One_Antipsychotic_Order;
    internal Lazy<CqlDateTime> __Antipsychotic_Index_Prescription_Start_Date;
    internal Lazy<bool?> __More_than_One_Benzodiazepine_Order;
    internal Lazy<CqlDateTime> __Benzodiazepine_Index_Prescription_Start_Date;
    internal Lazy<bool?> __Numerator_2;
    internal Lazy<bool?> __Numerator_3;
    internal Lazy<Tuple_DMgHTLENEHBHWJISQgKZGZVMB> __SDE_Ethnicity;
    internal Lazy<IEnumerable<Tuple_GDKRbfOIHhLGieQSVDEMIaDPX>> __SDE_Payer;
    internal Lazy<Tuple_DMgHTLENEHBHWJISQgKZGZVMB> __SDE_Race;
    internal Lazy<CqlCode> __SDE_Sex;

    #endregion
    public UseofHighRiskMedicationsintheElderlyFHIR_0_1_000(CqlContext context)
    {
        this.context = context ?? throw new ArgumentNullException("context");

        FHIRHelpers_4_3_000 = new FHIRHelpers_4_3_000(context);
        SupplementalDataElements_3_4_000 = new SupplementalDataElements_3_4_000(context);
        CQMCommon_2_0_000 = new CQMCommon_2_0_000(context);
        Hospice_6_9_000 = new Hospice_6_9_000(context);
        PalliativeCare_1_9_000 = new PalliativeCare_1_9_000(context);
        CumulativeMedicationDuration_4_0_000 = new CumulativeMedicationDuration_4_0_000(context);
        QICoreCommon_2_0_000 = new QICoreCommon_2_0_000(context);
        Status_1_6_000 = new Status_1_6_000(context);

        __Alcohol_Withdrawal = new Lazy<CqlValueSet>(this.Alcohol_Withdrawal_Value);
        __Annual_Wellness_Visit = new Lazy<CqlValueSet>(this.Annual_Wellness_Visit_Value);
        __Anti_Infectives__other = new Lazy<CqlValueSet>(this.Anti_Infectives__other_Value);
        __Anticholinergics__anti_Parkinson_agents = new Lazy<CqlValueSet>(this.Anticholinergics__anti_Parkinson_agents_Value);
        __Anticholinergics__first_generation_antihistamines = new Lazy<CqlValueSet>(this.Anticholinergics__first_generation_antihistamines_Value);
        __Antipsychotic = new Lazy<CqlValueSet>(this.Antipsychotic_Value);
        __Antispasmodics = new Lazy<CqlValueSet>(this.Antispasmodics_Value);
        __Antithrombotic = new Lazy<CqlValueSet>(this.Antithrombotic_Value);
        __Benzodiazepine_Withdrawal = new Lazy<CqlValueSet>(this.Benzodiazepine_Withdrawal_Value);
        __Benzodiazepine = new Lazy<CqlValueSet>(this.Benzodiazepine_Value);
        __Bipolar_Disorder = new Lazy<CqlValueSet>(this.Bipolar_Disorder_Value);
        __Cardiovascular__alpha_agonists__central = new Lazy<CqlValueSet>(this.Cardiovascular__alpha_agonists__central_Value);
        __Cardiovascular__other = new Lazy<CqlValueSet>(this.Cardiovascular__other_Value);
        __Care_Services_in_Long_Term_Residential_Facility = new Lazy<CqlValueSet>(this.Care_Services_in_Long_Term_Residential_Facility_Value);
        __Central_nervous_system__antidepressants = new Lazy<CqlValueSet>(this.Central_nervous_system__antidepressants_Value);
        __Central_nervous_system__barbiturates = new Lazy<CqlValueSet>(this.Central_nervous_system__barbiturates_Value);
        __Central_nervous_system__other = new Lazy<CqlValueSet>(this.Central_nervous_system__other_Value);
        __Central_nervous_system__vasodilators = new Lazy<CqlValueSet>(this.Central_nervous_system__vasodilators_Value);
        __Digoxin = new Lazy<CqlValueSet>(this.Digoxin_Value);
        __Discharge_Services_Nursing_Facility = new Lazy<CqlValueSet>(this.Discharge_Services_Nursing_Facility_Value);
        __Doxepin = new Lazy<CqlValueSet>(this.Doxepin_Value);
        __Endocrine_system__estrogens_with_or_without_progestins = new Lazy<CqlValueSet>(this.Endocrine_system__estrogens_with_or_without_progestins_Value);
        __Endocrine_system__other = new Lazy<CqlValueSet>(this.Endocrine_system__other_Value);
        __Endocrine_system__sulfonylureas__long_duration = new Lazy<CqlValueSet>(this.Endocrine_system__sulfonylureas__long_duration_Value);
        __Generalized_Anxiety_Disorder = new Lazy<CqlValueSet>(this.Generalized_Anxiety_Disorder_Value);
        __Home_Healthcare_Services = new Lazy<CqlValueSet>(this.Home_Healthcare_Services_Value);
        __Nonbenzodiazepine_hypnotics = new Lazy<CqlValueSet>(this.Nonbenzodiazepine_hypnotics_Value);
        __Nursing_Facility_Visit = new Lazy<CqlValueSet>(this.Nursing_Facility_Visit_Value);
        __Office_Visit = new Lazy<CqlValueSet>(this.Office_Visit_Value);
        __Online_Assessments = new Lazy<CqlValueSet>(this.Online_Assessments_Value);
        __Ophthalmologic_Services = new Lazy<CqlValueSet>(this.Ophthalmologic_Services_Value);
        __Pain_medications__other = new Lazy<CqlValueSet>(this.Pain_medications__other_Value);
        __Pain_medications__skeletal_muscle_relaxants = new Lazy<CqlValueSet>(this.Pain_medications__skeletal_muscle_relaxants_Value);
        __Preventive_Care_Services_Established_Office_Visit__18_and_Up = new Lazy<CqlValueSet>(this.Preventive_Care_Services_Established_Office_Visit__18_and_Up_Value);
        __Preventive_Care_Services_Initial_Office_Visit__18_and_Up = new Lazy<CqlValueSet>(this.Preventive_Care_Services_Initial_Office_Visit__18_and_Up_Value);
        __REM_Sleep_Behavior_Disorder = new Lazy<CqlValueSet>(this.REM_Sleep_Behavior_Disorder_Value);
        __Reserpine = new Lazy<CqlValueSet>(this.Reserpine_Value);
        __Schizophrenia = new Lazy<CqlValueSet>(this.Schizophrenia_Value);
        __Seizure_Disorder = new Lazy<CqlValueSet>(this.Seizure_Disorder_Value);
        __Telephone_Visits = new Lazy<CqlValueSet>(this.Telephone_Visits_Value);
        ___1_ML_digoxin_0_1_MG_ML_Injection = new Lazy<CqlCode>(this._1_ML_digoxin_0_1_MG_ML_Injection_Value);
        ___2_ML_digoxin_0_25_MG_ML_Injection = new Lazy<CqlCode>(this._2_ML_digoxin_0_25_MG_ML_Injection_Value);
        __digoxin_0_05_MG_ML_Oral_Solution = new Lazy<CqlCode>(this.digoxin_0_05_MG_ML_Oral_Solution_Value);
        __digoxin_0_0625_MG_Oral_Tablet = new Lazy<CqlCode>(this.digoxin_0_0625_MG_Oral_Tablet_Value);
        __digoxin_0_125_MG_Oral_Tablet = new Lazy<CqlCode>(this.digoxin_0_125_MG_Oral_Tablet_Value);
        __digoxin_0_1875_MG_Oral_Tablet = new Lazy<CqlCode>(this.digoxin_0_1875_MG_Oral_Tablet_Value);
        __digoxin_0_25_MG_Oral_Tablet = new Lazy<CqlCode>(this.digoxin_0_25_MG_Oral_Tablet_Value);
        __doxepin_3_MG_Oral_Tablet = new Lazy<CqlCode>(this.doxepin_3_MG_Oral_Tablet_Value);
        __doxepin_6_MG_Oral_Tablet = new Lazy<CqlCode>(this.doxepin_6_MG_Oral_Tablet_Value);
        __doxepin_hydrochloride_10_MG_Oral_Capsule = new Lazy<CqlCode>(this.doxepin_hydrochloride_10_MG_Oral_Capsule_Value);
        __doxepin_hydrochloride_10_MG_ML_Oral_Solution = new Lazy<CqlCode>(this.doxepin_hydrochloride_10_MG_ML_Oral_Solution_Value);
        __doxepin_hydrochloride_100_MG_Oral_Capsule = new Lazy<CqlCode>(this.doxepin_hydrochloride_100_MG_Oral_Capsule_Value);
        __doxepin_hydrochloride_150_MG_Oral_Capsule = new Lazy<CqlCode>(this.doxepin_hydrochloride_150_MG_Oral_Capsule_Value);
        __doxepin_hydrochloride_25_MG_Oral_Capsule = new Lazy<CqlCode>(this.doxepin_hydrochloride_25_MG_Oral_Capsule_Value);
        __doxepin_hydrochloride_50_MG_Oral_Capsule = new Lazy<CqlCode>(this.doxepin_hydrochloride_50_MG_Oral_Capsule_Value);
        __doxepin_hydrochloride_75_MG_Oral_Capsule = new Lazy<CqlCode>(this.doxepin_hydrochloride_75_MG_Oral_Capsule_Value);
        __Office_or_other_outpatient_visit_for_the_evaluation_and_management_of_an_established_patient__that_may_not_require_the_presence_of_a_physician_or_other_qualified_health_care_professional__Usually__the_presenting_problem_s__are_minimal_ = new Lazy<CqlCode>(this.Office_or_other_outpatient_visit_for_the_evaluation_and_management_of_an_established_patient__that_may_not_require_the_presence_of_a_physician_or_other_qualified_health_care_professional__Usually__the_presenting_problem_s__are_minimal__Value);
        __reserpine_0_1_MG_Oral_Tablet = new Lazy<CqlCode>(this.reserpine_0_1_MG_Oral_Tablet_Value);
        __reserpine_0_25_MG_Oral_Tablet = new Lazy<CqlCode>(this.reserpine_0_25_MG_Oral_Tablet_Value);
        __RXNORM = new Lazy<CqlCode[]>(this.RXNORM_Value);
        __CPT = new Lazy<CqlCode[]>(this.CPT_Value);
        __Measurement_Period = new Lazy<CqlInterval<CqlDateTime>>(this.Measurement_Period_Value);
        __Patient = new Lazy<Patient>(this.Patient_Value);
        __Qualifying_Encounters = new Lazy<IEnumerable<Encounter>>(this.Qualifying_Encounters_Value);
        __Initial_Population = new Lazy<bool?>(this.Initial_Population_Value);
        __Denominator = new Lazy<bool?>(this.Denominator_Value);
        __Denominator_Exclusions = new Lazy<bool?>(this.Denominator_Exclusions_Value);
        __Same_High_Risk_Medications_Ordered_on_Different_Days = new Lazy<IEnumerable<MedicationRequest>>(this.Same_High_Risk_Medications_Ordered_on_Different_Days_Value);
        __Two_High_Risk_Medications_with_Prolonged_Duration = new Lazy<bool?>(this.Two_High_Risk_Medications_with_Prolonged_Duration_Value);
        __High_Risk_Medications_with_Average_Daily_Dose_Criteria = new Lazy<bool?>(this.High_Risk_Medications_with_Average_Daily_Dose_Criteria_Value);
        __Numerator_1 = new Lazy<bool?>(this.Numerator_1_Value);
        __More_than_One_Antipsychotic_Order = new Lazy<bool?>(this.More_than_One_Antipsychotic_Order_Value);
        __Antipsychotic_Index_Prescription_Start_Date = new Lazy<CqlDateTime>(this.Antipsychotic_Index_Prescription_Start_Date_Value);
        __More_than_One_Benzodiazepine_Order = new Lazy<bool?>(this.More_than_One_Benzodiazepine_Order_Value);
        __Benzodiazepine_Index_Prescription_Start_Date = new Lazy<CqlDateTime>(this.Benzodiazepine_Index_Prescription_Start_Date_Value);
        __Numerator_2 = new Lazy<bool?>(this.Numerator_2_Value);
        __Numerator_3 = new Lazy<bool?>(this.Numerator_3_Value);
        __SDE_Ethnicity = new Lazy<Tuple_DMgHTLENEHBHWJISQgKZGZVMB>(this.SDE_Ethnicity_Value);
        __SDE_Payer = new Lazy<IEnumerable<Tuple_GDKRbfOIHhLGieQSVDEMIaDPX>>(this.SDE_Payer_Value);
        __SDE_Race = new Lazy<Tuple_DMgHTLENEHBHWJISQgKZGZVMB>(this.SDE_Race_Value);
        __SDE_Sex = new Lazy<CqlCode>(this.SDE_Sex_Value);
    }
    #region Dependencies

    public FHIRHelpers_4_3_000 FHIRHelpers_4_3_000 { get; }
    public SupplementalDataElements_3_4_000 SupplementalDataElements_3_4_000 { get; }
    public CQMCommon_2_0_000 CQMCommon_2_0_000 { get; }
    public Hospice_6_9_000 Hospice_6_9_000 { get; }
    public PalliativeCare_1_9_000 PalliativeCare_1_9_000 { get; }
    public CumulativeMedicationDuration_4_0_000 CumulativeMedicationDuration_4_0_000 { get; }
    public QICoreCommon_2_0_000 QICoreCommon_2_0_000 { get; }
    public Status_1_6_000 Status_1_6_000 { get; }

    #endregion

	private CqlValueSet Alcohol_Withdrawal_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.105.12.1209", null);

    [CqlDeclaration("Alcohol Withdrawal")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.105.12.1209")]
	public CqlValueSet Alcohol_Withdrawal() => 
		__Alcohol_Withdrawal.Value;

	private CqlValueSet Annual_Wellness_Visit_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1240", null);

    [CqlDeclaration("Annual Wellness Visit")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1240")]
	public CqlValueSet Annual_Wellness_Visit() => 
		__Annual_Wellness_Visit.Value;

	private CqlValueSet Anti_Infectives__other_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.196.12.1481", null);

    [CqlDeclaration("Anti Infectives, other")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.196.12.1481")]
	public CqlValueSet Anti_Infectives__other() => 
		__Anti_Infectives__other.Value;

	private CqlValueSet Anticholinergics__anti_Parkinson_agents_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.1049", null);

    [CqlDeclaration("Anticholinergics, anti Parkinson agents")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.1049")]
	public CqlValueSet Anticholinergics__anti_Parkinson_agents() => 
		__Anticholinergics__anti_Parkinson_agents.Value;

	private CqlValueSet Anticholinergics__first_generation_antihistamines_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.1043", null);

    [CqlDeclaration("Anticholinergics, first generation antihistamines")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.1043")]
	public CqlValueSet Anticholinergics__first_generation_antihistamines() => 
		__Anticholinergics__first_generation_antihistamines.Value;

	private CqlValueSet Antipsychotic_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.196.12.1523", null);

    [CqlDeclaration("Antipsychotic")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.196.12.1523")]
	public CqlValueSet Antipsychotic() => 
		__Antipsychotic.Value;

	private CqlValueSet Antispasmodics_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.1050", null);

    [CqlDeclaration("Antispasmodics")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.1050")]
	public CqlValueSet Antispasmodics() => 
		__Antispasmodics.Value;

	private CqlValueSet Antithrombotic_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.1051", null);

    [CqlDeclaration("Antithrombotic")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.1051")]
	public CqlValueSet Antithrombotic() => 
		__Antithrombotic.Value;

	private CqlValueSet Benzodiazepine_Withdrawal_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.105.12.1208", null);

    [CqlDeclaration("Benzodiazepine Withdrawal")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.105.12.1208")]
	public CqlValueSet Benzodiazepine_Withdrawal() => 
		__Benzodiazepine_Withdrawal.Value;

	private CqlValueSet Benzodiazepine_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.196.12.1522", null);

    [CqlDeclaration("Benzodiazepine")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.196.12.1522")]
	public CqlValueSet Benzodiazepine() => 
		__Benzodiazepine.Value;

	private CqlValueSet Bipolar_Disorder_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.105.12.1157", null);

    [CqlDeclaration("Bipolar Disorder")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.105.12.1157")]
	public CqlValueSet Bipolar_Disorder() => 
		__Bipolar_Disorder.Value;

	private CqlValueSet Cardiovascular__alpha_agonists__central_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.1052", null);

    [CqlDeclaration("Cardiovascular, alpha agonists, central")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.1052")]
	public CqlValueSet Cardiovascular__alpha_agonists__central() => 
		__Cardiovascular__alpha_agonists__central.Value;

	private CqlValueSet Cardiovascular__other_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.1053", null);

    [CqlDeclaration("Cardiovascular, other")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.1053")]
	public CqlValueSet Cardiovascular__other() => 
		__Cardiovascular__other.Value;

	private CqlValueSet Care_Services_in_Long_Term_Residential_Facility_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1014", null);

    [CqlDeclaration("Care Services in Long Term Residential Facility")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1014")]
	public CqlValueSet Care_Services_in_Long_Term_Residential_Facility() => 
		__Care_Services_in_Long_Term_Residential_Facility.Value;

	private CqlValueSet Central_nervous_system__antidepressants_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.1054", null);

    [CqlDeclaration("Central nervous system, antidepressants")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.1054")]
	public CqlValueSet Central_nervous_system__antidepressants() => 
		__Central_nervous_system__antidepressants.Value;

	private CqlValueSet Central_nervous_system__barbiturates_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.1055", null);

    [CqlDeclaration("Central nervous system, barbiturates")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.1055")]
	public CqlValueSet Central_nervous_system__barbiturates() => 
		__Central_nervous_system__barbiturates.Value;

	private CqlValueSet Central_nervous_system__other_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.1057", null);

    [CqlDeclaration("Central nervous system, other")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.1057")]
	public CqlValueSet Central_nervous_system__other() => 
		__Central_nervous_system__other.Value;

	private CqlValueSet Central_nervous_system__vasodilators_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.1056", null);

    [CqlDeclaration("Central nervous system, vasodilators")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.1056")]
	public CqlValueSet Central_nervous_system__vasodilators() => 
		__Central_nervous_system__vasodilators.Value;

	private CqlValueSet Digoxin_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.1065", null);

    [CqlDeclaration("Digoxin")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.1065")]
	public CqlValueSet Digoxin() => 
		__Digoxin.Value;

	private CqlValueSet Discharge_Services_Nursing_Facility_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1013", null);

    [CqlDeclaration("Discharge Services Nursing Facility")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1013")]
	public CqlValueSet Discharge_Services_Nursing_Facility() => 
		__Discharge_Services_Nursing_Facility.Value;

	private CqlValueSet Doxepin_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.1067", null);

    [CqlDeclaration("Doxepin")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.1067")]
	public CqlValueSet Doxepin() => 
		__Doxepin.Value;

	private CqlValueSet Endocrine_system__estrogens_with_or_without_progestins_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.1058", null);

    [CqlDeclaration("Endocrine system, estrogens with or without progestins")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.1058")]
	public CqlValueSet Endocrine_system__estrogens_with_or_without_progestins() => 
		__Endocrine_system__estrogens_with_or_without_progestins.Value;

	private CqlValueSet Endocrine_system__other_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.1060", null);

    [CqlDeclaration("Endocrine system, other")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.1060")]
	public CqlValueSet Endocrine_system__other() => 
		__Endocrine_system__other.Value;

	private CqlValueSet Endocrine_system__sulfonylureas__long_duration_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.1059", null);

    [CqlDeclaration("Endocrine system, sulfonylureas, long duration")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.1059")]
	public CqlValueSet Endocrine_system__sulfonylureas__long_duration() => 
		__Endocrine_system__sulfonylureas__long_duration.Value;

	private CqlValueSet Generalized_Anxiety_Disorder_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.105.12.1210", null);

    [CqlDeclaration("Generalized Anxiety Disorder")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.105.12.1210")]
	public CqlValueSet Generalized_Anxiety_Disorder() => 
		__Generalized_Anxiety_Disorder.Value;

	private CqlValueSet Home_Healthcare_Services_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1016", null);

    [CqlDeclaration("Home Healthcare Services")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1016")]
	public CqlValueSet Home_Healthcare_Services() => 
		__Home_Healthcare_Services.Value;

	private CqlValueSet Nonbenzodiazepine_hypnotics_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.196.12.1480", null);

    [CqlDeclaration("Nonbenzodiazepine hypnotics")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.196.12.1480")]
	public CqlValueSet Nonbenzodiazepine_hypnotics() => 
		__Nonbenzodiazepine_hypnotics.Value;

	private CqlValueSet Nursing_Facility_Visit_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1012", null);

    [CqlDeclaration("Nursing Facility Visit")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1012")]
	public CqlValueSet Nursing_Facility_Visit() => 
		__Nursing_Facility_Visit.Value;

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

	private CqlValueSet Ophthalmologic_Services_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.11.1206", null);

    [CqlDeclaration("Ophthalmologic Services")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.11.1206")]
	public CqlValueSet Ophthalmologic_Services() => 
		__Ophthalmologic_Services.Value;

	private CqlValueSet Pain_medications__other_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.1063", null);

    [CqlDeclaration("Pain medications, other")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.1063")]
	public CqlValueSet Pain_medications__other() => 
		__Pain_medications__other.Value;

	private CqlValueSet Pain_medications__skeletal_muscle_relaxants_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.1062", null);

    [CqlDeclaration("Pain medications, skeletal muscle relaxants")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.1062")]
	public CqlValueSet Pain_medications__skeletal_muscle_relaxants() => 
		__Pain_medications__skeletal_muscle_relaxants.Value;

	private CqlValueSet Preventive_Care_Services_Established_Office_Visit__18_and_Up_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1025", null);

    [CqlDeclaration("Preventive Care Services Established Office Visit, 18 and Up")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1025")]
	public CqlValueSet Preventive_Care_Services_Established_Office_Visit__18_and_Up() => 
		__Preventive_Care_Services_Established_Office_Visit__18_and_Up.Value;

	private CqlValueSet Preventive_Care_Services_Initial_Office_Visit__18_and_Up_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1023", null);

    [CqlDeclaration("Preventive Care Services Initial Office Visit, 18 and Up")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1023")]
	public CqlValueSet Preventive_Care_Services_Initial_Office_Visit__18_and_Up() => 
		__Preventive_Care_Services_Initial_Office_Visit__18_and_Up.Value;

	private CqlValueSet REM_Sleep_Behavior_Disorder_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.105.12.1207", null);

    [CqlDeclaration("REM Sleep Behavior Disorder")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.105.12.1207")]
	public CqlValueSet REM_Sleep_Behavior_Disorder() => 
		__REM_Sleep_Behavior_Disorder.Value;

	private CqlValueSet Reserpine_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.1044", null);

    [CqlDeclaration("Reserpine")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.1044")]
	public CqlValueSet Reserpine() => 
		__Reserpine.Value;

	private CqlValueSet Schizophrenia_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.105.12.1205", null);

    [CqlDeclaration("Schizophrenia")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.105.12.1205")]
	public CqlValueSet Schizophrenia() => 
		__Schizophrenia.Value;

	private CqlValueSet Seizure_Disorder_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.105.12.1206", null);

    [CqlDeclaration("Seizure Disorder")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.105.12.1206")]
	public CqlValueSet Seizure_Disorder() => 
		__Seizure_Disorder.Value;

	private CqlValueSet Telephone_Visits_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1080", null);

    [CqlDeclaration("Telephone Visits")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1080")]
	public CqlValueSet Telephone_Visits() => 
		__Telephone_Visits.Value;

	private CqlCode _1_ML_digoxin_0_1_MG_ML_Injection_Value() => 
		new CqlCode("204504", "http://www.nlm.nih.gov/research/umls/rxnorm", null, null);

    [CqlDeclaration("1 ML digoxin 0.1 MG/ML Injection")]
	public CqlCode _1_ML_digoxin_0_1_MG_ML_Injection() => 
		___1_ML_digoxin_0_1_MG_ML_Injection.Value;

	private CqlCode _2_ML_digoxin_0_25_MG_ML_Injection_Value() => 
		new CqlCode("104208", "http://www.nlm.nih.gov/research/umls/rxnorm", null, null);

    [CqlDeclaration("2 ML digoxin 0.25 MG/ML Injection")]
	public CqlCode _2_ML_digoxin_0_25_MG_ML_Injection() => 
		___2_ML_digoxin_0_25_MG_ML_Injection.Value;

	private CqlCode digoxin_0_05_MG_ML_Oral_Solution_Value() => 
		new CqlCode("393245", "http://www.nlm.nih.gov/research/umls/rxnorm", null, null);

    [CqlDeclaration("digoxin 0.05 MG/ML Oral Solution")]
	public CqlCode digoxin_0_05_MG_ML_Oral_Solution() => 
		__digoxin_0_05_MG_ML_Oral_Solution.Value;

	private CqlCode digoxin_0_0625_MG_Oral_Tablet_Value() => 
		new CqlCode("245273", "http://www.nlm.nih.gov/research/umls/rxnorm", null, null);

    [CqlDeclaration("digoxin 0.0625 MG Oral Tablet")]
	public CqlCode digoxin_0_0625_MG_Oral_Tablet() => 
		__digoxin_0_0625_MG_Oral_Tablet.Value;

	private CqlCode digoxin_0_125_MG_Oral_Tablet_Value() => 
		new CqlCode("197604", "http://www.nlm.nih.gov/research/umls/rxnorm", null, null);

    [CqlDeclaration("digoxin 0.125 MG Oral Tablet")]
	public CqlCode digoxin_0_125_MG_Oral_Tablet() => 
		__digoxin_0_125_MG_Oral_Tablet.Value;

	private CqlCode digoxin_0_1875_MG_Oral_Tablet_Value() => 
		new CqlCode("1441565", "http://www.nlm.nih.gov/research/umls/rxnorm", null, null);

    [CqlDeclaration("digoxin 0.1875 MG Oral Tablet")]
	public CqlCode digoxin_0_1875_MG_Oral_Tablet() => 
		__digoxin_0_1875_MG_Oral_Tablet.Value;

	private CqlCode digoxin_0_25_MG_Oral_Tablet_Value() => 
		new CqlCode("197606", "http://www.nlm.nih.gov/research/umls/rxnorm", null, null);

    [CqlDeclaration("digoxin 0.25 MG Oral Tablet")]
	public CqlCode digoxin_0_25_MG_Oral_Tablet() => 
		__digoxin_0_25_MG_Oral_Tablet.Value;

	private CqlCode doxepin_3_MG_Oral_Tablet_Value() => 
		new CqlCode("966787", "http://www.nlm.nih.gov/research/umls/rxnorm", null, null);

    [CqlDeclaration("doxepin 3 MG Oral Tablet")]
	public CqlCode doxepin_3_MG_Oral_Tablet() => 
		__doxepin_3_MG_Oral_Tablet.Value;

	private CqlCode doxepin_6_MG_Oral_Tablet_Value() => 
		new CqlCode("966793", "http://www.nlm.nih.gov/research/umls/rxnorm", null, null);

    [CqlDeclaration("doxepin 6 MG Oral Tablet")]
	public CqlCode doxepin_6_MG_Oral_Tablet() => 
		__doxepin_6_MG_Oral_Tablet.Value;

	private CqlCode doxepin_hydrochloride_10_MG_Oral_Capsule_Value() => 
		new CqlCode("1000048", "http://www.nlm.nih.gov/research/umls/rxnorm", null, null);

    [CqlDeclaration("doxepin hydrochloride 10 MG Oral Capsule")]
	public CqlCode doxepin_hydrochloride_10_MG_Oral_Capsule() => 
		__doxepin_hydrochloride_10_MG_Oral_Capsule.Value;

	private CqlCode doxepin_hydrochloride_10_MG_ML_Oral_Solution_Value() => 
		new CqlCode("1000054", "http://www.nlm.nih.gov/research/umls/rxnorm", null, null);

    [CqlDeclaration("doxepin hydrochloride 10 MG/ML Oral Solution")]
	public CqlCode doxepin_hydrochloride_10_MG_ML_Oral_Solution() => 
		__doxepin_hydrochloride_10_MG_ML_Oral_Solution.Value;

	private CqlCode doxepin_hydrochloride_100_MG_Oral_Capsule_Value() => 
		new CqlCode("1000058", "http://www.nlm.nih.gov/research/umls/rxnorm", null, null);

    [CqlDeclaration("doxepin hydrochloride 100 MG Oral Capsule")]
	public CqlCode doxepin_hydrochloride_100_MG_Oral_Capsule() => 
		__doxepin_hydrochloride_100_MG_Oral_Capsule.Value;

	private CqlCode doxepin_hydrochloride_150_MG_Oral_Capsule_Value() => 
		new CqlCode("1000064", "http://www.nlm.nih.gov/research/umls/rxnorm", null, null);

    [CqlDeclaration("doxepin hydrochloride 150 MG Oral Capsule")]
	public CqlCode doxepin_hydrochloride_150_MG_Oral_Capsule() => 
		__doxepin_hydrochloride_150_MG_Oral_Capsule.Value;

	private CqlCode doxepin_hydrochloride_25_MG_Oral_Capsule_Value() => 
		new CqlCode("1000070", "http://www.nlm.nih.gov/research/umls/rxnorm", null, null);

    [CqlDeclaration("doxepin hydrochloride 25 MG Oral Capsule")]
	public CqlCode doxepin_hydrochloride_25_MG_Oral_Capsule() => 
		__doxepin_hydrochloride_25_MG_Oral_Capsule.Value;

	private CqlCode doxepin_hydrochloride_50_MG_Oral_Capsule_Value() => 
		new CqlCode("1000076", "http://www.nlm.nih.gov/research/umls/rxnorm", null, null);

    [CqlDeclaration("doxepin hydrochloride 50 MG Oral Capsule")]
	public CqlCode doxepin_hydrochloride_50_MG_Oral_Capsule() => 
		__doxepin_hydrochloride_50_MG_Oral_Capsule.Value;

	private CqlCode doxepin_hydrochloride_75_MG_Oral_Capsule_Value() => 
		new CqlCode("1000097", "http://www.nlm.nih.gov/research/umls/rxnorm", null, null);

    [CqlDeclaration("doxepin hydrochloride 75 MG Oral Capsule")]
	public CqlCode doxepin_hydrochloride_75_MG_Oral_Capsule() => 
		__doxepin_hydrochloride_75_MG_Oral_Capsule.Value;

	private CqlCode Office_or_other_outpatient_visit_for_the_evaluation_and_management_of_an_established_patient__that_may_not_require_the_presence_of_a_physician_or_other_qualified_health_care_professional__Usually__the_presenting_problem_s__are_minimal__Value() => 
		new CqlCode("99211", "http://www.ama-assn.org/go/cpt", null, null);

    [CqlDeclaration("Office or other outpatient visit for the evaluation and management of an established patient, that may not require the presence of a physician or other qualified health care professional. Usually, the presenting problem(s) are minimal.")]
	public CqlCode Office_or_other_outpatient_visit_for_the_evaluation_and_management_of_an_established_patient__that_may_not_require_the_presence_of_a_physician_or_other_qualified_health_care_professional__Usually__the_presenting_problem_s__are_minimal_() => 
		__Office_or_other_outpatient_visit_for_the_evaluation_and_management_of_an_established_patient__that_may_not_require_the_presence_of_a_physician_or_other_qualified_health_care_professional__Usually__the_presenting_problem_s__are_minimal_.Value;

	private CqlCode reserpine_0_1_MG_Oral_Tablet_Value() => 
		new CqlCode("198196", "http://www.nlm.nih.gov/research/umls/rxnorm", null, null);

    [CqlDeclaration("reserpine 0.1 MG Oral Tablet")]
	public CqlCode reserpine_0_1_MG_Oral_Tablet() => 
		__reserpine_0_1_MG_Oral_Tablet.Value;

	private CqlCode reserpine_0_25_MG_Oral_Tablet_Value() => 
		new CqlCode("198197", "http://www.nlm.nih.gov/research/umls/rxnorm", null, null);

    [CqlDeclaration("reserpine 0.25 MG Oral Tablet")]
	public CqlCode reserpine_0_25_MG_Oral_Tablet() => 
		__reserpine_0_25_MG_Oral_Tablet.Value;

	private CqlCode[] RXNORM_Value()
	{
		CqlCode[] a_ = new CqlCode[]
		{
			new CqlCode("204504", "http://www.nlm.nih.gov/research/umls/rxnorm", null, null),
			new CqlCode("104208", "http://www.nlm.nih.gov/research/umls/rxnorm", null, null),
			new CqlCode("393245", "http://www.nlm.nih.gov/research/umls/rxnorm", null, null),
			new CqlCode("245273", "http://www.nlm.nih.gov/research/umls/rxnorm", null, null),
			new CqlCode("197604", "http://www.nlm.nih.gov/research/umls/rxnorm", null, null),
			new CqlCode("1441565", "http://www.nlm.nih.gov/research/umls/rxnorm", null, null),
			new CqlCode("197606", "http://www.nlm.nih.gov/research/umls/rxnorm", null, null),
			new CqlCode("966787", "http://www.nlm.nih.gov/research/umls/rxnorm", null, null),
			new CqlCode("966793", "http://www.nlm.nih.gov/research/umls/rxnorm", null, null),
			new CqlCode("1000048", "http://www.nlm.nih.gov/research/umls/rxnorm", null, null),
			new CqlCode("1000054", "http://www.nlm.nih.gov/research/umls/rxnorm", null, null),
			new CqlCode("1000058", "http://www.nlm.nih.gov/research/umls/rxnorm", null, null),
			new CqlCode("1000064", "http://www.nlm.nih.gov/research/umls/rxnorm", null, null),
			new CqlCode("1000070", "http://www.nlm.nih.gov/research/umls/rxnorm", null, null),
			new CqlCode("1000076", "http://www.nlm.nih.gov/research/umls/rxnorm", null, null),
			new CqlCode("1000097", "http://www.nlm.nih.gov/research/umls/rxnorm", null, null),
			new CqlCode("198196", "http://www.nlm.nih.gov/research/umls/rxnorm", null, null),
			new CqlCode("198197", "http://www.nlm.nih.gov/research/umls/rxnorm", null, null),
		};

		return a_;
	}

    [CqlDeclaration("RXNORM")]
	public CqlCode[] RXNORM() => 
		__RXNORM.Value;

	private CqlCode[] CPT_Value()
	{
		CqlCode[] a_ = new CqlCode[]
		{
			new CqlCode("99211", "http://www.ama-assn.org/go/cpt", null, null),
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
		object d_ = context.ResolveParameter("UseofHighRiskMedicationsintheElderlyFHIR-0.1.000", "Measurement Period", c_);

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

	private IEnumerable<Encounter> Qualifying_Encounters_Value()
	{
		CqlValueSet a_ = this.Office_Visit();
		IEnumerable<Encounter> b_ = context.Operators.RetrieveByValueSet<Encounter>(a_, null);
		CqlValueSet c_ = this.Ophthalmologic_Services();
		IEnumerable<Encounter> d_ = context.Operators.RetrieveByValueSet<Encounter>(c_, null);
		IEnumerable<Encounter> e_ = context.Operators.ListUnion<Encounter>(b_, d_);
		CqlValueSet f_ = this.Preventive_Care_Services_Established_Office_Visit__18_and_Up();
		IEnumerable<Encounter> g_ = context.Operators.RetrieveByValueSet<Encounter>(f_, null);
		CqlValueSet h_ = this.Discharge_Services_Nursing_Facility();
		IEnumerable<Encounter> i_ = context.Operators.RetrieveByValueSet<Encounter>(h_, null);
		IEnumerable<Encounter> j_ = context.Operators.ListUnion<Encounter>(g_, i_);
		IEnumerable<Encounter> k_ = context.Operators.ListUnion<Encounter>(e_, j_);
		CqlValueSet l_ = this.Nursing_Facility_Visit();
		IEnumerable<Encounter> m_ = context.Operators.RetrieveByValueSet<Encounter>(l_, null);
		CqlValueSet n_ = this.Care_Services_in_Long_Term_Residential_Facility();
		IEnumerable<Encounter> o_ = context.Operators.RetrieveByValueSet<Encounter>(n_, null);
		IEnumerable<Encounter> p_ = context.Operators.ListUnion<Encounter>(m_, o_);
		IEnumerable<Encounter> q_ = context.Operators.ListUnion<Encounter>(k_, p_);
		CqlValueSet r_ = this.Preventive_Care_Services_Initial_Office_Visit__18_and_Up();
		IEnumerable<Encounter> s_ = context.Operators.RetrieveByValueSet<Encounter>(r_, null);
		CqlValueSet t_ = this.Annual_Wellness_Visit();
		IEnumerable<Encounter> u_ = context.Operators.RetrieveByValueSet<Encounter>(t_, null);
		IEnumerable<Encounter> v_ = context.Operators.ListUnion<Encounter>(s_, u_);
		IEnumerable<Encounter> w_ = context.Operators.ListUnion<Encounter>(q_, v_);
		CqlValueSet x_ = this.Home_Healthcare_Services();
		IEnumerable<Encounter> y_ = context.Operators.RetrieveByValueSet<Encounter>(x_, null);
		CqlValueSet z_ = this.Telephone_Visits();
		IEnumerable<Encounter> aa_ = context.Operators.RetrieveByValueSet<Encounter>(z_, null);
		IEnumerable<Encounter> ab_ = context.Operators.ListUnion<Encounter>(y_, aa_);
		IEnumerable<Encounter> ac_ = context.Operators.ListUnion<Encounter>(w_, ab_);
		CqlValueSet ad_ = this.Online_Assessments();
		IEnumerable<Encounter> ae_ = context.Operators.RetrieveByValueSet<Encounter>(ad_, null);
		IEnumerable<Encounter> af_ = context.Operators.RetrieveByValueSet<Encounter>(null, null);
		bool? ag_(Encounter E)
		{
			CqlConcept am_(CodeableConcept @this)
			{
				CqlConcept ar_ = FHIRHelpers_4_3_000.ToConcept(@this);

				return ar_;
			};
			IEnumerable<CqlConcept> an_ = context.Operators.Select<CodeableConcept, CqlConcept>(E?.Type, am_);
			bool? ao_(CqlConcept T)
			{
				CqlCode as_ = this.Office_or_other_outpatient_visit_for_the_evaluation_and_management_of_an_established_patient__that_may_not_require_the_presence_of_a_physician_or_other_qualified_health_care_professional__Usually__the_presenting_problem_s__are_minimal_();
				CqlConcept at_ = context.Operators.ConvertCodeToConcept(as_);
				bool? au_ = context.Operators.Equivalent(T, at_);

				return au_;
			};
			IEnumerable<CqlConcept> ap_ = context.Operators.Where<CqlConcept>(an_, ao_);
			bool? aq_ = context.Operators.Exists<CqlConcept>(ap_);

			return aq_;
		};
		IEnumerable<Encounter> ah_ = context.Operators.Where<Encounter>(af_, ag_);
		IEnumerable<Encounter> ai_ = context.Operators.ListUnion<Encounter>(ae_, ah_);
		IEnumerable<Encounter> aj_ = context.Operators.ListUnion<Encounter>(ac_, ai_);
		bool? ak_(Encounter ValidEncounters)
		{
			CqlInterval<CqlDateTime> av_ = this.Measurement_Period();
			CqlInterval<CqlDateTime> aw_ = FHIRHelpers_4_3_000.ToInterval(ValidEncounters?.Period);
			bool? ax_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(av_, aw_, null);

			return ax_;
		};
		IEnumerable<Encounter> al_ = context.Operators.Where<Encounter>(aj_, ak_);

		return al_;
	}

    [CqlDeclaration("Qualifying Encounters")]
	public IEnumerable<Encounter> Qualifying_Encounters() => 
		__Qualifying_Encounters.Value;

	private bool? Initial_Population_Value()
	{
		Patient a_ = this.Patient();
		CqlDate b_ = context.Operators.Convert<CqlDate>(a_?.BirthDateElement?.Value);
		CqlInterval<CqlDateTime> c_ = this.Measurement_Period();
		CqlDateTime d_ = context.Operators.End(c_);
		CqlDate e_ = context.Operators.DateFrom(d_);
		int? f_ = context.Operators.CalculateAgeAt(b_, e_, "year");
		bool? g_ = context.Operators.GreaterOrEqual(f_, 65);
		IEnumerable<Encounter> h_ = this.Qualifying_Encounters();
		bool? i_ = context.Operators.Exists<Encounter>(h_);
		bool? j_ = context.Operators.And(g_, i_);

		return j_;
	}

    [CqlDeclaration("Initial Population")]
	public bool? Initial_Population() => 
		__Initial_Population.Value;

	private bool? Denominator_Value()
	{
		bool? a_ = this.Initial_Population();

		return a_;
	}

    [CqlDeclaration("Denominator")]
	public bool? Denominator() => 
		__Denominator.Value;

	private bool? Denominator_Exclusions_Value()
	{
		bool? a_ = Hospice_6_9_000.Has_Hospice_Services();
		bool? b_ = PalliativeCare_1_9_000.Has_Palliative_Care_in_the_Measurement_Period();
		bool? c_ = context.Operators.Or(a_, b_);

		return c_;
	}

    [CqlDeclaration("Denominator Exclusions")]
	public bool? Denominator_Exclusions() => 
		__Denominator_Exclusions.Value;

    [CqlDeclaration("More Than One Order")]
	public IEnumerable<MedicationRequest> More_Than_One_Order(IEnumerable<MedicationRequest> Medication)
	{
		IEnumerable<MedicationRequest> a_ = Status_1_6_000.Active_or_Completed_Medication_Request(Medication);
		IEnumerable<MedicationRequest> b_(MedicationRequest OrderMedication1)
		{
			IEnumerable<MedicationRequest> f_ = Status_1_6_000.Active_or_Completed_Medication_Request(Medication);
			bool? g_(MedicationRequest OrderMedication2)
			{
				CqlDateTime k_ = context.Operators.Convert<CqlDateTime>(OrderMedication1?.AuthoredOnElement);
				CqlInterval<CqlDateTime> l_ = this.Measurement_Period();
				bool? m_ = context.Operators.In<CqlDateTime>(k_, l_, null);
				bool? n_ = context.Operators.GreaterOrEqual(OrderMedication1?.DispenseRequest?.NumberOfRepeatsAllowedElement?.Value, 1);
				bool? o_ = context.Operators.And(m_, n_);
				CqlDate q_ = context.Operators.DateFrom(k_);
				CqlDateTime r_ = context.Operators.Convert<CqlDateTime>(OrderMedication2?.AuthoredOnElement);
				CqlDate s_ = context.Operators.DateFrom(r_);
				bool? t_ = context.Operators.Equivalent(q_, s_);
				bool? u_ = context.Operators.Not(t_);
				bool? x_ = context.Operators.In<CqlDateTime>(k_, l_, null);
				bool? y_ = context.Operators.And(u_, x_);
				bool? ab_ = context.Operators.In<CqlDateTime>(r_, l_, null);
				bool? ac_ = context.Operators.And(y_, ab_);
				bool? ad_ = context.Operators.Or(o_, ac_);
				CqlDate af_ = context.Operators.DateFrom(k_);
				CqlDate ah_ = context.Operators.DateFrom(r_);
				bool? ai_ = context.Operators.Equivalent(af_, ah_);
				bool? al_ = context.Operators.In<CqlDateTime>(k_, l_, null);
				bool? am_ = context.Operators.And(ai_, al_);
				CqlInterval<CqlDate> an_ = CumulativeMedicationDuration_4_0_000.MedicationRequestPeriod(OrderMedication1);
				CqlDate ao_ = context.Operators.Start(an_);
				CqlDateTime ap_ = context.Operators.ConvertDateToDateTime(ao_);
				CqlDate aq_ = context.Operators.DateFrom(ap_);
				CqlInterval<CqlDate> ar_ = CumulativeMedicationDuration_4_0_000.MedicationRequestPeriod(OrderMedication2);
				CqlDate as_ = context.Operators.Start(ar_);
				CqlDateTime at_ = context.Operators.ConvertDateToDateTime(as_);
				CqlDate au_ = context.Operators.DateFrom(at_);
				bool? av_ = context.Operators.Equivalent(aq_, au_);
				bool? aw_ = context.Operators.Not(av_);
				bool? ax_ = context.Operators.And(am_, aw_);
				CqlDate az_ = context.Operators.Start(an_);
				CqlDateTime ba_ = context.Operators.ConvertDateToDateTime(az_);
				bool? bc_ = context.Operators.In<CqlDateTime>(ba_, l_, null);
				bool? bd_ = context.Operators.And(ax_, bc_);
				CqlDate bf_ = context.Operators.Start(ar_);
				CqlDateTime bg_ = context.Operators.ConvertDateToDateTime(bf_);
				bool? bi_ = context.Operators.In<CqlDateTime>(bg_, l_, null);
				bool? bj_ = context.Operators.And(bd_, bi_);
				bool? bk_ = context.Operators.Or(ad_, bj_);

				return bk_;
			};
			IEnumerable<MedicationRequest> h_ = context.Operators.Where<MedicationRequest>(f_, g_);
			MedicationRequest i_(MedicationRequest OrderMedication2) => 
				OrderMedication1;
			IEnumerable<MedicationRequest> j_ = context.Operators.Select<MedicationRequest, MedicationRequest>(h_, i_);

			return j_;
		};
		IEnumerable<MedicationRequest> c_ = context.Operators.SelectMany<MedicationRequest, MedicationRequest>(a_, b_);
		MedicationRequest d_(MedicationRequest OrderMedication1) => 
			OrderMedication1;
		IEnumerable<MedicationRequest> e_ = context.Operators.Select<MedicationRequest, MedicationRequest>(c_, d_);

		return e_;
	}

	private IEnumerable<MedicationRequest> Same_High_Risk_Medications_Ordered_on_Different_Days_Value()
	{
		CqlValueSet a_ = this.Anticholinergics__first_generation_antihistamines();
		IEnumerable<MedicationRequest> b_ = context.Operators.RetrieveByValueSet<MedicationRequest>(a_, null);
		IEnumerable<MedicationRequest> d_ = context.Operators.RetrieveByValueSet<MedicationRequest>(a_, null);
		IEnumerable<MedicationRequest> e_ = context.Operators.ListUnion<MedicationRequest>(b_, d_);
		IEnumerable<MedicationRequest> f_ = this.More_Than_One_Order(e_);
		CqlValueSet g_ = this.Anticholinergics__anti_Parkinson_agents();
		IEnumerable<MedicationRequest> h_ = context.Operators.RetrieveByValueSet<MedicationRequest>(g_, null);
		IEnumerable<MedicationRequest> j_ = context.Operators.RetrieveByValueSet<MedicationRequest>(g_, null);
		IEnumerable<MedicationRequest> k_ = context.Operators.ListUnion<MedicationRequest>(h_, j_);
		IEnumerable<MedicationRequest> l_ = this.More_Than_One_Order(k_);
		IEnumerable<MedicationRequest> m_ = context.Operators.ListUnion<MedicationRequest>(f_, l_);
		CqlValueSet n_ = this.Antispasmodics();
		IEnumerable<MedicationRequest> o_ = context.Operators.RetrieveByValueSet<MedicationRequest>(n_, null);
		IEnumerable<MedicationRequest> q_ = context.Operators.RetrieveByValueSet<MedicationRequest>(n_, null);
		IEnumerable<MedicationRequest> r_ = context.Operators.ListUnion<MedicationRequest>(o_, q_);
		IEnumerable<MedicationRequest> s_ = this.More_Than_One_Order(r_);
		CqlValueSet t_ = this.Antithrombotic();
		IEnumerable<MedicationRequest> u_ = context.Operators.RetrieveByValueSet<MedicationRequest>(t_, null);
		IEnumerable<MedicationRequest> w_ = context.Operators.RetrieveByValueSet<MedicationRequest>(t_, null);
		IEnumerable<MedicationRequest> x_ = context.Operators.ListUnion<MedicationRequest>(u_, w_);
		IEnumerable<MedicationRequest> y_ = this.More_Than_One_Order(x_);
		IEnumerable<MedicationRequest> z_ = context.Operators.ListUnion<MedicationRequest>(s_, y_);
		IEnumerable<MedicationRequest> aa_ = context.Operators.ListUnion<MedicationRequest>(m_, z_);
		CqlValueSet ab_ = this.Cardiovascular__alpha_agonists__central();
		IEnumerable<MedicationRequest> ac_ = context.Operators.RetrieveByValueSet<MedicationRequest>(ab_, null);
		IEnumerable<MedicationRequest> ae_ = context.Operators.RetrieveByValueSet<MedicationRequest>(ab_, null);
		IEnumerable<MedicationRequest> af_ = context.Operators.ListUnion<MedicationRequest>(ac_, ae_);
		IEnumerable<MedicationRequest> ag_ = this.More_Than_One_Order(af_);
		CqlValueSet ah_ = this.Cardiovascular__other();
		IEnumerable<MedicationRequest> ai_ = context.Operators.RetrieveByValueSet<MedicationRequest>(ah_, null);
		IEnumerable<MedicationRequest> ak_ = context.Operators.RetrieveByValueSet<MedicationRequest>(ah_, null);
		IEnumerable<MedicationRequest> al_ = context.Operators.ListUnion<MedicationRequest>(ai_, ak_);
		IEnumerable<MedicationRequest> am_ = this.More_Than_One_Order(al_);
		IEnumerable<MedicationRequest> an_ = context.Operators.ListUnion<MedicationRequest>(ag_, am_);
		IEnumerable<MedicationRequest> ao_ = context.Operators.ListUnion<MedicationRequest>(aa_, an_);
		CqlValueSet ap_ = this.Central_nervous_system__antidepressants();
		IEnumerable<MedicationRequest> aq_ = context.Operators.RetrieveByValueSet<MedicationRequest>(ap_, null);
		IEnumerable<MedicationRequest> as_ = context.Operators.RetrieveByValueSet<MedicationRequest>(ap_, null);
		IEnumerable<MedicationRequest> at_ = context.Operators.ListUnion<MedicationRequest>(aq_, as_);
		IEnumerable<MedicationRequest> au_ = this.More_Than_One_Order(at_);
		CqlValueSet av_ = this.Central_nervous_system__barbiturates();
		IEnumerable<MedicationRequest> aw_ = context.Operators.RetrieveByValueSet<MedicationRequest>(av_, null);
		IEnumerable<MedicationRequest> ay_ = context.Operators.RetrieveByValueSet<MedicationRequest>(av_, null);
		IEnumerable<MedicationRequest> az_ = context.Operators.ListUnion<MedicationRequest>(aw_, ay_);
		IEnumerable<MedicationRequest> ba_ = this.More_Than_One_Order(az_);
		IEnumerable<MedicationRequest> bb_ = context.Operators.ListUnion<MedicationRequest>(au_, ba_);
		IEnumerable<MedicationRequest> bc_ = context.Operators.ListUnion<MedicationRequest>(ao_, bb_);
		CqlValueSet bd_ = this.Central_nervous_system__vasodilators();
		IEnumerable<MedicationRequest> be_ = context.Operators.RetrieveByValueSet<MedicationRequest>(bd_, null);
		IEnumerable<MedicationRequest> bg_ = context.Operators.RetrieveByValueSet<MedicationRequest>(bd_, null);
		IEnumerable<MedicationRequest> bh_ = context.Operators.ListUnion<MedicationRequest>(be_, bg_);
		IEnumerable<MedicationRequest> bi_ = this.More_Than_One_Order(bh_);
		CqlValueSet bj_ = this.Central_nervous_system__other();
		IEnumerable<MedicationRequest> bk_ = context.Operators.RetrieveByValueSet<MedicationRequest>(bj_, null);
		IEnumerable<MedicationRequest> bm_ = context.Operators.RetrieveByValueSet<MedicationRequest>(bj_, null);
		IEnumerable<MedicationRequest> bn_ = context.Operators.ListUnion<MedicationRequest>(bk_, bm_);
		IEnumerable<MedicationRequest> bo_ = this.More_Than_One_Order(bn_);
		IEnumerable<MedicationRequest> bp_ = context.Operators.ListUnion<MedicationRequest>(bi_, bo_);
		IEnumerable<MedicationRequest> bq_ = context.Operators.ListUnion<MedicationRequest>(bc_, bp_);
		CqlValueSet br_ = this.Endocrine_system__estrogens_with_or_without_progestins();
		IEnumerable<MedicationRequest> bs_ = context.Operators.RetrieveByValueSet<MedicationRequest>(br_, null);
		IEnumerable<MedicationRequest> bu_ = context.Operators.RetrieveByValueSet<MedicationRequest>(br_, null);
		IEnumerable<MedicationRequest> bv_ = context.Operators.ListUnion<MedicationRequest>(bs_, bu_);
		IEnumerable<MedicationRequest> bw_ = this.More_Than_One_Order(bv_);
		CqlValueSet bx_ = this.Endocrine_system__sulfonylureas__long_duration();
		IEnumerable<MedicationRequest> by_ = context.Operators.RetrieveByValueSet<MedicationRequest>(bx_, null);
		IEnumerable<MedicationRequest> ca_ = context.Operators.RetrieveByValueSet<MedicationRequest>(bx_, null);
		IEnumerable<MedicationRequest> cb_ = context.Operators.ListUnion<MedicationRequest>(by_, ca_);
		IEnumerable<MedicationRequest> cc_ = this.More_Than_One_Order(cb_);
		IEnumerable<MedicationRequest> cd_ = context.Operators.ListUnion<MedicationRequest>(bw_, cc_);
		IEnumerable<MedicationRequest> ce_ = context.Operators.ListUnion<MedicationRequest>(bq_, cd_);
		CqlValueSet cf_ = this.Endocrine_system__other();
		IEnumerable<MedicationRequest> cg_ = context.Operators.RetrieveByValueSet<MedicationRequest>(cf_, null);
		IEnumerable<MedicationRequest> ci_ = context.Operators.RetrieveByValueSet<MedicationRequest>(cf_, null);
		IEnumerable<MedicationRequest> cj_ = context.Operators.ListUnion<MedicationRequest>(cg_, ci_);
		IEnumerable<MedicationRequest> ck_ = this.More_Than_One_Order(cj_);
		CqlValueSet cl_ = this.Nonbenzodiazepine_hypnotics();
		IEnumerable<MedicationRequest> cm_ = context.Operators.RetrieveByValueSet<MedicationRequest>(cl_, null);
		IEnumerable<MedicationRequest> co_ = context.Operators.RetrieveByValueSet<MedicationRequest>(cl_, null);
		IEnumerable<MedicationRequest> cp_ = context.Operators.ListUnion<MedicationRequest>(cm_, co_);
		IEnumerable<MedicationRequest> cq_ = this.More_Than_One_Order(cp_);
		IEnumerable<MedicationRequest> cr_ = context.Operators.ListUnion<MedicationRequest>(ck_, cq_);
		IEnumerable<MedicationRequest> cs_ = context.Operators.ListUnion<MedicationRequest>(ce_, cr_);
		CqlValueSet ct_ = this.Pain_medications__skeletal_muscle_relaxants();
		IEnumerable<MedicationRequest> cu_ = context.Operators.RetrieveByValueSet<MedicationRequest>(ct_, null);
		IEnumerable<MedicationRequest> cw_ = context.Operators.RetrieveByValueSet<MedicationRequest>(ct_, null);
		IEnumerable<MedicationRequest> cx_ = context.Operators.ListUnion<MedicationRequest>(cu_, cw_);
		IEnumerable<MedicationRequest> cy_ = this.More_Than_One_Order(cx_);
		CqlValueSet cz_ = this.Pain_medications__other();
		IEnumerable<MedicationRequest> da_ = context.Operators.RetrieveByValueSet<MedicationRequest>(cz_, null);
		IEnumerable<MedicationRequest> dc_ = context.Operators.RetrieveByValueSet<MedicationRequest>(cz_, null);
		IEnumerable<MedicationRequest> dd_ = context.Operators.ListUnion<MedicationRequest>(da_, dc_);
		IEnumerable<MedicationRequest> de_ = this.More_Than_One_Order(dd_);
		IEnumerable<MedicationRequest> df_ = context.Operators.ListUnion<MedicationRequest>(cy_, de_);
		IEnumerable<MedicationRequest> dg_ = context.Operators.ListUnion<MedicationRequest>(cs_, df_);

		return dg_;
	}

    [CqlDeclaration("Same High Risk Medications Ordered on Different Days")]
	public IEnumerable<MedicationRequest> Same_High_Risk_Medications_Ordered_on_Different_Days() => 
		__Same_High_Risk_Medications_Ordered_on_Different_Days.Value;

    [CqlDeclaration("MedicationRequestPeriodInDays")]
	public decimal? MedicationRequestPeriodInDays(MedicationRequest Request)
	{
		MedicationRequest[] a_ = new MedicationRequest[]
		{
			Request,
		};
		decimal? b_(MedicationRequest R)
		{
			CqlQuantity e_ = FHIRHelpers_4_3_000.ToQuantity((R?.DispenseRequest?.ExpectedSupplyDuration as Quantity));
			CqlQuantity f_ = context.Operators.ConvertQuantity(e_, "d");
			CqlQuantity g_ = FHIRHelpers_4_3_000.ToQuantity(R?.DispenseRequest?.Quantity);
			Dosage h_ = context.Operators.SingletonFrom<Dosage>((R?.DosageInstruction as IEnumerable<Dosage>));
			Dosage.DoseAndRateComponent i_ = context.Operators.SingletonFrom<Dosage.DoseAndRateComponent>((h_?.DoseAndRate as IEnumerable<Dosage.DoseAndRateComponent>));
			object j_ = FHIRHelpers_4_3_000.ToValue(i_?.Dose);
			CqlQuantity k_ = context.Operators.End((j_ as CqlInterval<CqlQuantity>));
			Dosage.DoseAndRateComponent m_ = context.Operators.SingletonFrom<Dosage.DoseAndRateComponent>((h_?.DoseAndRate as IEnumerable<Dosage.DoseAndRateComponent>));
			object n_ = FHIRHelpers_4_3_000.ToValue(m_?.Dose);
			Code<Timing.UnitsOfTime> s_ = context.Operators.Convert<Code<Timing.UnitsOfTime>>(h_?.Timing?.Repeat?.PeriodUnitElement?.Value);
			string t_ = context.Operators.Convert<string>(s_);
			CqlQuantity u_ = CumulativeMedicationDuration_4_0_000.Quantity(h_?.Timing?.Repeat?.PeriodElement?.Value, t_);
			decimal? v_ = CumulativeMedicationDuration_4_0_000.ToDaily((h_?.Timing?.Repeat?.FrequencyMaxElement?.Value ?? h_?.Timing?.Repeat?.FrequencyElement?.Value), u_);
			IEnumerable<CqlTime> x_ = context.Operators.LateBoundProperty<IEnumerable<CqlTime>>(h_?.Timing?.Repeat?.TimeOfDayElement, "value");
			int? y_ = context.Operators.Count<CqlTime>(x_);
			decimal? z_ = context.Operators.ConvertIntegerToDecimal(y_);
			decimal? aa_ = context.Operators.Multiply((k_ ?? (n_ as CqlQuantity))?.value, ((v_ ?? z_) ?? 1.0m));
			decimal? ab_ = context.Operators.Divide(g_?.value, aa_);
			int? ac_ = context.Operators.Add(1, (R?.DispenseRequest?.NumberOfRepeatsAllowedElement?.Value ?? 0));
			decimal? ad_ = context.Operators.ConvertIntegerToDecimal(ac_);
			decimal? ae_ = context.Operators.Multiply((f_?.value ?? ab_), ad_);

			return ae_;
		};
		IEnumerable<decimal?> c_ = context.Operators.Select<MedicationRequest, decimal?>(a_, b_);
		decimal? d_ = context.Operators.SingletonFrom<decimal?>(c_);

		return d_;
	}

	private bool? Two_High_Risk_Medications_with_Prolonged_Duration_Value()
	{
		CqlValueSet a_ = this.Anti_Infectives__other();
		IEnumerable<MedicationRequest> b_ = context.Operators.RetrieveByValueSet<MedicationRequest>(a_, null);
		IEnumerable<MedicationRequest> d_ = context.Operators.RetrieveByValueSet<MedicationRequest>(a_, null);
		IEnumerable<MedicationRequest> e_ = context.Operators.ListUnion<MedicationRequest>(b_, d_);
		IEnumerable<MedicationRequest> f_ = this.More_Than_One_Order(e_);
		decimal? g_(MedicationRequest AntiInfectives)
		{
			decimal? l_ = this.MedicationRequestPeriodInDays(AntiInfectives);

			return l_;
		};
		IEnumerable<decimal?> h_ = context.Operators.Select<MedicationRequest, decimal?>(f_, g_);
		decimal? i_ = context.Operators.Sum(h_);
		decimal? j_ = context.Operators.ConvertIntegerToDecimal(90);
		bool? k_ = context.Operators.Greater(i_, j_);

		return k_;
	}

    [CqlDeclaration("Two High Risk Medications with Prolonged Duration")]
	public bool? Two_High_Risk_Medications_with_Prolonged_Duration() => 
		__Two_High_Risk_Medications_with_Prolonged_Duration.Value;

    [CqlDeclaration("MedicationStrengthPerUnit")]
	public CqlQuantity MedicationStrengthPerUnit(CqlConcept Strength)
	{
		CqlQuantity a_()
		{
			bool b_()
			{
				CqlCode t_ = this.reserpine_0_1_MG_Oral_Tablet();
				CqlConcept u_ = context.Operators.ConvertCodeToConcept(t_);
				bool? v_ = context.Operators.Equivalent(Strength, u_);

				return (v_ ?? false);
			};
			bool c_()
			{
				CqlCode w_ = this.reserpine_0_25_MG_Oral_Tablet();
				CqlConcept x_ = context.Operators.ConvertCodeToConcept(w_);
				bool? y_ = context.Operators.Equivalent(Strength, x_);

				return (y_ ?? false);
			};
			bool d_()
			{
				CqlCode z_ = this.digoxin_0_05_MG_ML_Oral_Solution();
				CqlConcept aa_ = context.Operators.ConvertCodeToConcept(z_);
				bool? ab_ = context.Operators.Equivalent(Strength, aa_);

				return (ab_ ?? false);
			};
			bool e_()
			{
				CqlCode ac_ = this.digoxin_0_0625_MG_Oral_Tablet();
				CqlConcept ad_ = context.Operators.ConvertCodeToConcept(ac_);
				bool? ae_ = context.Operators.Equivalent(Strength, ad_);

				return (ae_ ?? false);
			};
			bool f_()
			{
				CqlCode af_ = this._1_ML_digoxin_0_1_MG_ML_Injection();
				CqlConcept ag_ = context.Operators.ConvertCodeToConcept(af_);
				bool? ah_ = context.Operators.Equivalent(Strength, ag_);

				return (ah_ ?? false);
			};
			bool g_()
			{
				CqlCode ai_ = this.digoxin_0_125_MG_Oral_Tablet();
				CqlConcept aj_ = context.Operators.ConvertCodeToConcept(ai_);
				bool? ak_ = context.Operators.Equivalent(Strength, aj_);

				return (ak_ ?? false);
			};
			bool h_()
			{
				CqlCode al_ = this.digoxin_0_1875_MG_Oral_Tablet();
				CqlConcept am_ = context.Operators.ConvertCodeToConcept(al_);
				bool? an_ = context.Operators.Equivalent(Strength, am_);

				return (an_ ?? false);
			};
			bool i_()
			{
				CqlCode ao_ = this.digoxin_0_25_MG_Oral_Tablet();
				CqlConcept ap_ = context.Operators.ConvertCodeToConcept(ao_);
				bool? aq_ = context.Operators.Equivalent(Strength, ap_);

				return (aq_ ?? false);
			};
			bool j_()
			{
				CqlCode ar_ = this._2_ML_digoxin_0_25_MG_ML_Injection();
				CqlConcept as_ = context.Operators.ConvertCodeToConcept(ar_);
				bool? at_ = context.Operators.Equivalent(Strength, as_);

				return (at_ ?? false);
			};
			bool k_()
			{
				CqlCode au_ = this.doxepin_3_MG_Oral_Tablet();
				CqlConcept av_ = context.Operators.ConvertCodeToConcept(au_);
				bool? aw_ = context.Operators.Equivalent(Strength, av_);

				return (aw_ ?? false);
			};
			bool l_()
			{
				CqlCode ax_ = this.doxepin_6_MG_Oral_Tablet();
				CqlConcept ay_ = context.Operators.ConvertCodeToConcept(ax_);
				bool? az_ = context.Operators.Equivalent(Strength, ay_);

				return (az_ ?? false);
			};
			bool m_()
			{
				CqlCode ba_ = this.doxepin_hydrochloride_10_MG_Oral_Capsule();
				CqlConcept bb_ = context.Operators.ConvertCodeToConcept(ba_);
				bool? bc_ = context.Operators.Equivalent(Strength, bb_);

				return (bc_ ?? false);
			};
			bool n_()
			{
				CqlCode bd_ = this.doxepin_hydrochloride_10_MG_ML_Oral_Solution();
				CqlConcept be_ = context.Operators.ConvertCodeToConcept(bd_);
				bool? bf_ = context.Operators.Equivalent(Strength, be_);

				return (bf_ ?? false);
			};
			bool o_()
			{
				CqlCode bg_ = this.doxepin_hydrochloride_25_MG_Oral_Capsule();
				CqlConcept bh_ = context.Operators.ConvertCodeToConcept(bg_);
				bool? bi_ = context.Operators.Equivalent(Strength, bh_);

				return (bi_ ?? false);
			};
			bool p_()
			{
				CqlCode bj_ = this.doxepin_hydrochloride_50_MG_Oral_Capsule();
				CqlConcept bk_ = context.Operators.ConvertCodeToConcept(bj_);
				bool? bl_ = context.Operators.Equivalent(Strength, bk_);

				return (bl_ ?? false);
			};
			bool q_()
			{
				CqlCode bm_ = this.doxepin_hydrochloride_75_MG_Oral_Capsule();
				CqlConcept bn_ = context.Operators.ConvertCodeToConcept(bm_);
				bool? bo_ = context.Operators.Equivalent(Strength, bn_);

				return (bo_ ?? false);
			};
			bool r_()
			{
				CqlCode bp_ = this.doxepin_hydrochloride_100_MG_Oral_Capsule();
				CqlConcept bq_ = context.Operators.ConvertCodeToConcept(bp_);
				bool? br_ = context.Operators.Equivalent(Strength, bq_);

				return (br_ ?? false);
			};
			bool s_()
			{
				CqlCode bs_ = this.doxepin_hydrochloride_150_MG_Oral_Capsule();
				CqlConcept bt_ = context.Operators.ConvertCodeToConcept(bs_);
				bool? bu_ = context.Operators.Equivalent(Strength, bt_);

				return (bu_ ?? false);
			};
			if (b_())
			{
				CqlQuantity bv_ = context.Operators.Quantity(0.1m, "mg");

				return bv_;
			}
			else if (c_())
			{
				CqlQuantity bw_ = context.Operators.Quantity(0.25m, "mg");

				return bw_;
			}
			else if (d_())
			{
				CqlQuantity bx_ = context.Operators.Quantity(0.05m, "mg/mL");

				return bx_;
			}
			else if (e_())
			{
				CqlQuantity by_ = context.Operators.Quantity(0.0625m, "mg");

				return by_;
			}
			else if (f_())
			{
				CqlQuantity bz_ = context.Operators.Quantity(0.1m, "mg/mL");

				return bz_;
			}
			else if (g_())
			{
				CqlQuantity ca_ = context.Operators.Quantity(0.125m, "mg");

				return ca_;
			}
			else if (h_())
			{
				CqlQuantity cb_ = context.Operators.Quantity(0.1875m, "mg");

				return cb_;
			}
			else if (i_())
			{
				CqlQuantity cc_ = context.Operators.Quantity(0.25m, "mg");

				return cc_;
			}
			else if (j_())
			{
				CqlQuantity cd_ = context.Operators.Quantity(0.25m, "mg/mL");

				return cd_;
			}
			else if (k_())
			{
				CqlQuantity ce_ = context.Operators.Quantity(3m, "mg");

				return ce_;
			}
			else if (l_())
			{
				CqlQuantity cf_ = context.Operators.Quantity(6m, "mg");

				return cf_;
			}
			else if (m_())
			{
				CqlQuantity cg_ = context.Operators.Quantity(10m, "mg");

				return cg_;
			}
			else if (n_())
			{
				CqlQuantity ch_ = context.Operators.Quantity(10m, "mg/mL");

				return ch_;
			}
			else if (o_())
			{
				CqlQuantity ci_ = context.Operators.Quantity(25m, "mg");

				return ci_;
			}
			else if (p_())
			{
				CqlQuantity cj_ = context.Operators.Quantity(50m, "mg");

				return cj_;
			}
			else if (q_())
			{
				CqlQuantity ck_ = context.Operators.Quantity(75m, "mg");

				return ck_;
			}
			else if (r_())
			{
				CqlQuantity cl_ = context.Operators.Quantity(100m, "mg");

				return cl_;
			}
			else if (s_())
			{
				CqlQuantity cm_ = context.Operators.Quantity(150m, "mg");

				return cm_;
			}
			else
			{
				return null;
			};
		};

		return a_();
	}

    [CqlDeclaration("Average Daily Dose")]
	public CqlQuantity Average_Daily_Dose(MedicationRequest MedicationRequest)
	{
		MedicationRequest[] a_ = new MedicationRequest[]
		{
			MedicationRequest,
		};
		CqlQuantity b_(MedicationRequest Order)
		{
			CqlQuantity e_()
			{
				bool f_()
				{
					decimal? g_ = this.MedicationRequestPeriodInDays(Order);
					bool? h_ = context.Operators.Not((bool?)(g_ is null));
					CqlConcept i_ = CQMCommon_2_0_000.getMedicationCode(Order);
					CqlQuantity j_ = this.MedicationStrengthPerUnit(i_);
					bool? k_ = context.Operators.Equal(j_?.unit, "mg");
					CqlQuantity m_ = this.MedicationStrengthPerUnit(i_);
					bool? n_ = context.Operators.Equal(m_?.unit, "mg/mL");
					CqlQuantity o_ = FHIRHelpers_4_3_000.ToQuantity(Order?.DispenseRequest?.Quantity);
					bool? p_ = context.Operators.Equal(o_?.unit, "mL");
					bool? q_ = context.Operators.And(n_, p_);
					bool? r_ = context.Operators.Or(k_, q_);
					bool? s_ = context.Operators.And(h_, r_);

					return (s_ ?? false);
				};
				if (f_())
				{
					CqlQuantity t_ = FHIRHelpers_4_3_000.ToQuantity(Order?.DispenseRequest?.Quantity);
					CqlConcept u_ = CQMCommon_2_0_000.getMedicationCode(Order);
					CqlQuantity v_ = this.MedicationStrengthPerUnit(u_);
					CqlQuantity w_ = context.Operators.Multiply(t_, v_);
					decimal? x_ = this.MedicationRequestPeriodInDays(Order);
					CqlQuantity y_ = context.Operators.Divide(w_, new CqlQuantity(x_, "d"));

					return y_;
				}
				else
				{
					return null;
				};
			};

			return e_();
		};
		IEnumerable<CqlQuantity> c_ = context.Operators.Select<MedicationRequest, CqlQuantity>(a_, b_);
		CqlQuantity d_ = context.Operators.SingletonFrom<CqlQuantity>(c_);

		return d_;
	}

	private bool? High_Risk_Medications_with_Average_Daily_Dose_Criteria_Value()
	{
		CqlValueSet a_ = this.Reserpine();
		IEnumerable<MedicationRequest> b_ = context.Operators.RetrieveByValueSet<MedicationRequest>(a_, null);
		IEnumerable<MedicationRequest> d_ = context.Operators.RetrieveByValueSet<MedicationRequest>(a_, null);
		IEnumerable<MedicationRequest> e_ = context.Operators.ListUnion<MedicationRequest>(b_, d_);
		bool? f_(MedicationRequest ReserpineOrdered)
		{
			CqlQuantity ad_ = this.Average_Daily_Dose(ReserpineOrdered);
			CqlQuantity ae_ = context.Operators.Quantity(0.1m, "mg/d");
			bool? af_ = context.Operators.Greater(ad_, ae_);

			return af_;
		};
		IEnumerable<MedicationRequest> g_ = context.Operators.Where<MedicationRequest>(e_, f_);
		IEnumerable<MedicationRequest> h_ = this.More_Than_One_Order(g_);
		bool? i_ = context.Operators.Exists<MedicationRequest>(h_);
		CqlValueSet j_ = this.Digoxin();
		IEnumerable<MedicationRequest> k_ = context.Operators.RetrieveByValueSet<MedicationRequest>(j_, null);
		IEnumerable<MedicationRequest> m_ = context.Operators.RetrieveByValueSet<MedicationRequest>(j_, null);
		IEnumerable<MedicationRequest> n_ = context.Operators.ListUnion<MedicationRequest>(k_, m_);
		bool? o_(MedicationRequest DigoxinOrdered)
		{
			CqlQuantity ag_ = this.Average_Daily_Dose(DigoxinOrdered);
			CqlQuantity ah_ = context.Operators.Quantity(0.125m, "mg/d");
			bool? ai_ = context.Operators.Greater(ag_, ah_);

			return ai_;
		};
		IEnumerable<MedicationRequest> p_ = context.Operators.Where<MedicationRequest>(n_, o_);
		IEnumerable<MedicationRequest> q_ = this.More_Than_One_Order(p_);
		bool? r_ = context.Operators.Exists<MedicationRequest>(q_);
		bool? s_ = context.Operators.Or(i_, r_);
		CqlValueSet t_ = this.Doxepin();
		IEnumerable<MedicationRequest> u_ = context.Operators.RetrieveByValueSet<MedicationRequest>(t_, null);
		IEnumerable<MedicationRequest> w_ = context.Operators.RetrieveByValueSet<MedicationRequest>(t_, null);
		IEnumerable<MedicationRequest> x_ = context.Operators.ListUnion<MedicationRequest>(u_, w_);
		bool? y_(MedicationRequest DoxepinOrdered)
		{
			CqlQuantity aj_ = this.Average_Daily_Dose(DoxepinOrdered);
			CqlQuantity ak_ = context.Operators.Quantity(6m, "mg/d");
			bool? al_ = context.Operators.Greater(aj_, ak_);

			return al_;
		};
		IEnumerable<MedicationRequest> z_ = context.Operators.Where<MedicationRequest>(x_, y_);
		IEnumerable<MedicationRequest> aa_ = this.More_Than_One_Order(z_);
		bool? ab_ = context.Operators.Exists<MedicationRequest>(aa_);
		bool? ac_ = context.Operators.Or(s_, ab_);

		return ac_;
	}

    [CqlDeclaration("High Risk Medications with Average Daily Dose Criteria")]
	public bool? High_Risk_Medications_with_Average_Daily_Dose_Criteria() => 
		__High_Risk_Medications_with_Average_Daily_Dose_Criteria.Value;

	private bool? Numerator_1_Value()
	{
		IEnumerable<MedicationRequest> a_ = this.Same_High_Risk_Medications_Ordered_on_Different_Days();
		bool? b_ = context.Operators.Exists<MedicationRequest>(a_);
		bool? c_ = this.Two_High_Risk_Medications_with_Prolonged_Duration();
		bool? d_ = context.Operators.Or(b_, c_);
		bool? e_ = this.High_Risk_Medications_with_Average_Daily_Dose_Criteria();
		bool? f_ = context.Operators.Or(d_, e_);

		return f_;
	}

    [CqlDeclaration("Numerator 1")]
	public bool? Numerator_1() => 
		__Numerator_1.Value;

	private bool? More_than_One_Antipsychotic_Order_Value()
	{
		CqlValueSet a_ = this.Antipsychotic();
		IEnumerable<MedicationRequest> b_ = context.Operators.RetrieveByValueSet<MedicationRequest>(a_, null);
		IEnumerable<MedicationRequest> d_ = context.Operators.RetrieveByValueSet<MedicationRequest>(a_, null);
		IEnumerable<MedicationRequest> e_ = context.Operators.ListUnion<MedicationRequest>(b_, d_);
		IEnumerable<MedicationRequest> f_ = this.More_Than_One_Order(e_);
		bool? g_ = context.Operators.Exists<MedicationRequest>(f_);

		return g_;
	}

    [CqlDeclaration("More than One Antipsychotic Order")]
	public bool? More_than_One_Antipsychotic_Order() => 
		__More_than_One_Antipsychotic_Order.Value;

	private CqlDateTime Antipsychotic_Index_Prescription_Start_Date_Value()
	{
		CqlValueSet a_ = this.Antipsychotic();
		IEnumerable<MedicationRequest> b_ = context.Operators.RetrieveByValueSet<MedicationRequest>(a_, null);
		IEnumerable<MedicationRequest> d_ = context.Operators.RetrieveByValueSet<MedicationRequest>(a_, null);
		IEnumerable<MedicationRequest> e_ = context.Operators.ListUnion<MedicationRequest>(b_, d_);
		IEnumerable<MedicationRequest> f_ = Status_1_6_000.Active_or_Completed_Medication_Request(e_);
		bool? g_(MedicationRequest AntipsychoticMedication)
		{
			CqlDateTime m_ = context.Operators.Convert<CqlDateTime>(AntipsychoticMedication?.AuthoredOnElement);
			CqlInterval<CqlDateTime> n_ = this.Measurement_Period();
			bool? o_ = context.Operators.In<CqlDateTime>(m_, n_, null);

			return o_;
		};
		IEnumerable<MedicationRequest> h_ = context.Operators.Where<MedicationRequest>(f_, g_);
		CqlDateTime i_(MedicationRequest AntipsychoticMedication)
		{
			CqlDateTime p_ = context.Operators.Convert<CqlDateTime>(AntipsychoticMedication?.AuthoredOnElement);

			return p_;
		};
		IEnumerable<CqlDateTime> j_ = context.Operators.Select<MedicationRequest, CqlDateTime>(h_, i_);
		IEnumerable<CqlDateTime> k_ = context.Operators.ListSort<CqlDateTime>(j_, System.ComponentModel.ListSortDirection.Ascending);
		CqlDateTime l_ = context.Operators.First<CqlDateTime>(k_);

		return l_;
	}

    [CqlDeclaration("Antipsychotic Index Prescription Start Date")]
	public CqlDateTime Antipsychotic_Index_Prescription_Start_Date() => 
		__Antipsychotic_Index_Prescription_Start_Date.Value;

	private bool? More_than_One_Benzodiazepine_Order_Value()
	{
		CqlValueSet a_ = this.Benzodiazepine();
		IEnumerable<MedicationRequest> b_ = context.Operators.RetrieveByValueSet<MedicationRequest>(a_, null);
		IEnumerable<MedicationRequest> d_ = context.Operators.RetrieveByValueSet<MedicationRequest>(a_, null);
		IEnumerable<MedicationRequest> e_ = context.Operators.ListUnion<MedicationRequest>(b_, d_);
		IEnumerable<MedicationRequest> f_ = this.More_Than_One_Order(e_);
		bool? g_ = context.Operators.Exists<MedicationRequest>(f_);

		return g_;
	}

    [CqlDeclaration("More than One Benzodiazepine Order")]
	public bool? More_than_One_Benzodiazepine_Order() => 
		__More_than_One_Benzodiazepine_Order.Value;

	private CqlDateTime Benzodiazepine_Index_Prescription_Start_Date_Value()
	{
		CqlValueSet a_ = this.Benzodiazepine();
		IEnumerable<MedicationRequest> b_ = context.Operators.RetrieveByValueSet<MedicationRequest>(a_, null);
		IEnumerable<MedicationRequest> d_ = context.Operators.RetrieveByValueSet<MedicationRequest>(a_, null);
		IEnumerable<MedicationRequest> e_ = context.Operators.ListUnion<MedicationRequest>(b_, d_);
		IEnumerable<MedicationRequest> f_ = Status_1_6_000.Active_or_Completed_Medication_Request(e_);
		bool? g_(MedicationRequest BenzodiazepineMedication)
		{
			CqlDateTime m_ = context.Operators.Convert<CqlDateTime>(BenzodiazepineMedication?.AuthoredOnElement);
			CqlInterval<CqlDateTime> n_ = this.Measurement_Period();
			bool? o_ = context.Operators.In<CqlDateTime>(m_, n_, null);

			return o_;
		};
		IEnumerable<MedicationRequest> h_ = context.Operators.Where<MedicationRequest>(f_, g_);
		CqlDateTime i_(MedicationRequest BenzodiazepineMedication)
		{
			CqlDateTime p_ = context.Operators.Convert<CqlDateTime>(BenzodiazepineMedication?.AuthoredOnElement);

			return p_;
		};
		IEnumerable<CqlDateTime> j_ = context.Operators.Select<MedicationRequest, CqlDateTime>(h_, i_);
		IEnumerable<CqlDateTime> k_ = context.Operators.ListSort<CqlDateTime>(j_, System.ComponentModel.ListSortDirection.Ascending);
		CqlDateTime l_ = context.Operators.First<CqlDateTime>(k_);

		return l_;
	}

    [CqlDeclaration("Benzodiazepine Index Prescription Start Date")]
	public CqlDateTime Benzodiazepine_Index_Prescription_Start_Date() => 
		__Benzodiazepine_Index_Prescription_Start_Date.Value;

	private bool? Numerator_2_Value()
	{
		bool? a_ = this.More_than_One_Antipsychotic_Order();
		CqlValueSet b_ = this.Schizophrenia();
		IEnumerable<Condition> c_ = context.Operators.RetrieveByValueSet<Condition>(b_, null);
		CqlValueSet d_ = this.Bipolar_Disorder();
		IEnumerable<Condition> e_ = context.Operators.RetrieveByValueSet<Condition>(d_, null);
		IEnumerable<Condition> f_ = context.Operators.ListUnion<Condition>(c_, e_);
		bool? g_(Condition AntipsychoticTreatedDiagnoses)
		{
			CqlInterval<CqlDateTime> ag_ = QICoreCommon_2_0_000.ToPrevalenceInterval(AntipsychoticTreatedDiagnoses);
			CqlInterval<CqlDateTime> ah_ = this.Measurement_Period();
			CqlDateTime ai_ = context.Operators.Start(ah_);
			CqlQuantity aj_ = context.Operators.Quantity(1m, "year");
			CqlDateTime ak_ = context.Operators.Subtract(ai_, aj_);
			CqlDateTime al_ = this.Antipsychotic_Index_Prescription_Start_Date();
			CqlInterval<CqlDateTime> am_ = context.Operators.Interval(ak_, al_, true, true);
			bool? an_ = context.Operators.Overlaps(ag_, am_, null);

			return an_;
		};
		IEnumerable<Condition> h_ = context.Operators.Where<Condition>(f_, g_);
		bool? i_ = context.Operators.Exists<Condition>(h_);
		bool? j_ = context.Operators.Not(i_);
		bool? k_ = context.Operators.And(a_, j_);
		bool? l_ = this.More_than_One_Benzodiazepine_Order();
		CqlValueSet m_ = this.Seizure_Disorder();
		IEnumerable<Condition> n_ = context.Operators.RetrieveByValueSet<Condition>(m_, null);
		CqlValueSet o_ = this.REM_Sleep_Behavior_Disorder();
		IEnumerable<Condition> p_ = context.Operators.RetrieveByValueSet<Condition>(o_, null);
		IEnumerable<Condition> q_ = context.Operators.ListUnion<Condition>(n_, p_);
		CqlValueSet r_ = this.Benzodiazepine_Withdrawal();
		IEnumerable<Condition> s_ = context.Operators.RetrieveByValueSet<Condition>(r_, null);
		CqlValueSet t_ = this.Alcohol_Withdrawal();
		IEnumerable<Condition> u_ = context.Operators.RetrieveByValueSet<Condition>(t_, null);
		IEnumerable<Condition> v_ = context.Operators.ListUnion<Condition>(s_, u_);
		IEnumerable<Condition> w_ = context.Operators.ListUnion<Condition>(q_, v_);
		CqlValueSet x_ = this.Generalized_Anxiety_Disorder();
		IEnumerable<Condition> y_ = context.Operators.RetrieveByValueSet<Condition>(x_, null);
		IEnumerable<Condition> z_ = context.Operators.ListUnion<Condition>(w_, y_);
		bool? aa_(Condition BenzodiazepineTreatedDiagnoses)
		{
			CqlInterval<CqlDateTime> ao_ = QICoreCommon_2_0_000.ToPrevalenceInterval(BenzodiazepineTreatedDiagnoses);
			CqlInterval<CqlDateTime> ap_ = this.Measurement_Period();
			CqlDateTime aq_ = context.Operators.Start(ap_);
			CqlQuantity ar_ = context.Operators.Quantity(1m, "year");
			CqlDateTime as_ = context.Operators.Subtract(aq_, ar_);
			CqlDateTime at_ = this.Benzodiazepine_Index_Prescription_Start_Date();
			CqlInterval<CqlDateTime> au_ = context.Operators.Interval(as_, at_, true, true);
			bool? av_ = context.Operators.Overlaps(ao_, au_, null);

			return av_;
		};
		IEnumerable<Condition> ab_ = context.Operators.Where<Condition>(z_, aa_);
		bool? ac_ = context.Operators.Exists<Condition>(ab_);
		bool? ad_ = context.Operators.Not(ac_);
		bool? ae_ = context.Operators.And(l_, ad_);
		bool? af_ = context.Operators.Or(k_, ae_);

		return af_;
	}

    [CqlDeclaration("Numerator 2")]
	public bool? Numerator_2() => 
		__Numerator_2.Value;

	private bool? Numerator_3_Value()
	{
		bool? a_ = this.Numerator_2();
		bool? b_ = this.Numerator_1();
		bool? d_ = context.Operators.Not(a_);
		bool? e_ = context.Operators.And(b_, d_);
		bool? f_ = context.Operators.Or(a_, e_);

		return f_;
	}

    [CqlDeclaration("Numerator 3")]
	public bool? Numerator_3() => 
		__Numerator_3.Value;

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
