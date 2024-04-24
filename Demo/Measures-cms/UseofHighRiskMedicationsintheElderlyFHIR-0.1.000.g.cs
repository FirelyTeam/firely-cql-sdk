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
		var a_ = new CqlCode[]
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
		var a_ = new CqlCode[]
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
		var a_ = context.Operators.DateTime((int?)2025, (int?)1, (int?)1, (int?)0, (int?)0, (int?)0, (int?)0, default);
		var b_ = context.Operators.DateTime((int?)2026, (int?)1, (int?)1, (int?)0, (int?)0, (int?)0, (int?)0, default);
		var c_ = context.Operators.Interval(a_, b_, (bool?)true, (bool?)false);
		var d_ = context.ResolveParameter("UseofHighRiskMedicationsintheElderlyFHIR-0.1.000", "Measurement Period", c_);

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

	private IEnumerable<Encounter> Qualifying_Encounters_Value()
	{
		var a_ = this.Office_Visit();
		var b_ = context.Operators.RetrieveByValueSet<Encounter>(a_, null);
		var c_ = this.Ophthalmologic_Services();
		var d_ = context.Operators.RetrieveByValueSet<Encounter>(c_, null);
		var e_ = context.Operators.ListUnion<Encounter>(b_, d_);
		var f_ = this.Preventive_Care_Services_Established_Office_Visit__18_and_Up();
		var g_ = context.Operators.RetrieveByValueSet<Encounter>(f_, null);
		var h_ = this.Discharge_Services_Nursing_Facility();
		var i_ = context.Operators.RetrieveByValueSet<Encounter>(h_, null);
		var j_ = context.Operators.ListUnion<Encounter>(g_, i_);
		var k_ = context.Operators.ListUnion<Encounter>(e_, j_);
		var l_ = this.Nursing_Facility_Visit();
		var m_ = context.Operators.RetrieveByValueSet<Encounter>(l_, null);
		var n_ = this.Care_Services_in_Long_Term_Residential_Facility();
		var o_ = context.Operators.RetrieveByValueSet<Encounter>(n_, null);
		var p_ = context.Operators.ListUnion<Encounter>(m_, o_);
		var q_ = context.Operators.ListUnion<Encounter>(k_, p_);
		var r_ = this.Preventive_Care_Services_Initial_Office_Visit__18_and_Up();
		var s_ = context.Operators.RetrieveByValueSet<Encounter>(r_, null);
		var t_ = this.Annual_Wellness_Visit();
		var u_ = context.Operators.RetrieveByValueSet<Encounter>(t_, null);
		var v_ = context.Operators.ListUnion<Encounter>(s_, u_);
		var w_ = context.Operators.ListUnion<Encounter>(q_, v_);
		var x_ = this.Home_Healthcare_Services();
		var y_ = context.Operators.RetrieveByValueSet<Encounter>(x_, null);
		var z_ = this.Telephone_Visits();
		var aa_ = context.Operators.RetrieveByValueSet<Encounter>(z_, null);
		var ab_ = context.Operators.ListUnion<Encounter>(y_, aa_);
		var ac_ = context.Operators.ListUnion<Encounter>(w_, ab_);
		var ad_ = this.Online_Assessments();
		var ae_ = context.Operators.RetrieveByValueSet<Encounter>(ad_, null);
		var af_ = context.Operators.RetrieveByValueSet<Encounter>(null, null);
		bool? ag_(Encounter E)
		{
			CqlConcept am_(CodeableConcept @this)
			{
				var ar_ = FHIRHelpers_4_3_000.ToConcept(@this);

				return ar_;
			};
			var an_ = context.Operators.SelectOrNull<CodeableConcept, CqlConcept>(E?.Type, am_);
			bool? ao_(CqlConcept T)
			{
				var as_ = this.Office_or_other_outpatient_visit_for_the_evaluation_and_management_of_an_established_patient__that_may_not_require_the_presence_of_a_physician_or_other_qualified_health_care_professional__Usually__the_presenting_problem_s__are_minimal_();
				var at_ = context.Operators.ConvertCodeToConcept(as_);
				var au_ = context.Operators.Equivalent(T, at_);

				return au_;
			};
			var ap_ = context.Operators.WhereOrNull<CqlConcept>(an_, ao_);
			var aq_ = context.Operators.Exists<CqlConcept>(ap_);

			return aq_;
		};
		var ah_ = context.Operators.WhereOrNull<Encounter>(af_, ag_);
		var ai_ = context.Operators.ListUnion<Encounter>(ae_, ah_);
		var aj_ = context.Operators.ListUnion<Encounter>(ac_, ai_);
		bool? ak_(Encounter ValidEncounters)
		{
			var av_ = this.Measurement_Period();
			var aw_ = FHIRHelpers_4_3_000.ToInterval(ValidEncounters?.Period);
			var ax_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(av_, aw_, null);

			return ax_;
		};
		var al_ = context.Operators.WhereOrNull<Encounter>(aj_, ak_);

		return al_;
	}

    [CqlDeclaration("Qualifying Encounters")]
	public IEnumerable<Encounter> Qualifying_Encounters() => 
		__Qualifying_Encounters.Value;

	private bool? Initial_Population_Value()
	{
		var a_ = this.Patient();
		var b_ = context.Operators.Convert<CqlDate>(a_?.BirthDateElement?.Value);
		var c_ = this.Measurement_Period();
		var d_ = context.Operators.End(c_);
		var e_ = context.Operators.DateFrom(d_);
		var f_ = context.Operators.CalculateAgeAt(b_, e_, "year");
		var g_ = context.Operators.GreaterOrEqual(f_, (int?)65);
		var h_ = this.Qualifying_Encounters();
		var i_ = context.Operators.Exists<Encounter>(h_);
		var j_ = context.Operators.And(g_, i_);

		return j_;
	}

    [CqlDeclaration("Initial Population")]
	public bool? Initial_Population() => 
		__Initial_Population.Value;

	private bool? Denominator_Value()
	{
		var a_ = this.Initial_Population();

		return a_;
	}

    [CqlDeclaration("Denominator")]
	public bool? Denominator() => 
		__Denominator.Value;

	private bool? Denominator_Exclusions_Value()
	{
		var a_ = Hospice_6_9_000.Has_Hospice_Services();
		var b_ = PalliativeCare_1_9_000.Has_Palliative_Care_in_the_Measurement_Period();
		var c_ = context.Operators.Or(a_, b_);

		return c_;
	}

    [CqlDeclaration("Denominator Exclusions")]
	public bool? Denominator_Exclusions() => 
		__Denominator_Exclusions.Value;

    [CqlDeclaration("More Than One Order")]
	public IEnumerable<MedicationRequest> More_Than_One_Order(IEnumerable<MedicationRequest> Medication)
	{
		var a_ = Status_1_6_000.Active_or_Completed_Medication_Request(Medication);
		IEnumerable<MedicationRequest> b_(MedicationRequest OrderMedication1)
		{
			var f_ = Status_1_6_000.Active_or_Completed_Medication_Request(Medication);
			bool? g_(MedicationRequest OrderMedication2)
			{
				var k_ = context.Operators.Convert<CqlDateTime>(OrderMedication1?.AuthoredOnElement);
				var l_ = this.Measurement_Period();
				var m_ = context.Operators.In<CqlDateTime>(k_, l_, null);
				var n_ = context.Operators.GreaterOrEqual(OrderMedication1?.DispenseRequest?.NumberOfRepeatsAllowedElement?.Value, (int?)1);
				var o_ = context.Operators.And(m_, n_);
				var q_ = context.Operators.DateFrom(k_);
				var r_ = context.Operators.Convert<CqlDateTime>(OrderMedication2?.AuthoredOnElement);
				var s_ = context.Operators.DateFrom(r_);
				var t_ = context.Operators.Equivalent(q_, s_);
				var u_ = context.Operators.Not(t_);
				var x_ = context.Operators.In<CqlDateTime>(k_, l_, null);
				var y_ = context.Operators.And(u_, x_);
				var ab_ = context.Operators.In<CqlDateTime>(r_, l_, null);
				var ac_ = context.Operators.And(y_, ab_);
				var ad_ = context.Operators.Or(o_, ac_);
				var af_ = context.Operators.DateFrom(k_);
				var ah_ = context.Operators.DateFrom(r_);
				var ai_ = context.Operators.Equivalent(af_, ah_);
				var al_ = context.Operators.In<CqlDateTime>(k_, l_, null);
				var am_ = context.Operators.And(ai_, al_);
				var an_ = CumulativeMedicationDuration_4_0_000.MedicationRequestPeriod(OrderMedication1);
				var ao_ = context.Operators.Start(an_);
				var ap_ = context.Operators.ConvertDateToDateTime(ao_);
				var aq_ = context.Operators.DateFrom(ap_);
				var ar_ = CumulativeMedicationDuration_4_0_000.MedicationRequestPeriod(OrderMedication2);
				var as_ = context.Operators.Start(ar_);
				var at_ = context.Operators.ConvertDateToDateTime(as_);
				var au_ = context.Operators.DateFrom(at_);
				var av_ = context.Operators.Equivalent(aq_, au_);
				var aw_ = context.Operators.Not(av_);
				var ax_ = context.Operators.And(am_, aw_);
				var az_ = context.Operators.Start(an_);
				var ba_ = context.Operators.ConvertDateToDateTime(az_);
				var bc_ = context.Operators.In<CqlDateTime>(ba_, l_, null);
				var bd_ = context.Operators.And(ax_, bc_);
				var bf_ = context.Operators.Start(ar_);
				var bg_ = context.Operators.ConvertDateToDateTime(bf_);
				var bi_ = context.Operators.In<CqlDateTime>(bg_, l_, null);
				var bj_ = context.Operators.And(bd_, bi_);
				var bk_ = context.Operators.Or(ad_, bj_);

				return bk_;
			};
			var h_ = context.Operators.WhereOrNull<MedicationRequest>(f_, g_);
			MedicationRequest i_(MedicationRequest OrderMedication2) => 
				OrderMedication1;
			var j_ = context.Operators.SelectOrNull<MedicationRequest, MedicationRequest>(h_, i_);

			return j_;
		};
		var c_ = context.Operators.SelectManyOrNull<MedicationRequest, MedicationRequest>(a_, b_);
		MedicationRequest d_(MedicationRequest OrderMedication1) => 
			OrderMedication1;
		var e_ = context.Operators.SelectOrNull<MedicationRequest, MedicationRequest>(c_, d_);

		return e_;
	}

	private IEnumerable<MedicationRequest> Same_High_Risk_Medications_Ordered_on_Different_Days_Value()
	{
		var a_ = this.Anticholinergics__first_generation_antihistamines();
		var b_ = context.Operators.RetrieveByValueSet<MedicationRequest>(a_, null);
		var d_ = context.Operators.RetrieveByValueSet<MedicationRequest>(a_, null);
		var e_ = context.Operators.ListUnion<MedicationRequest>(b_, d_);
		var f_ = this.More_Than_One_Order(e_);
		var g_ = this.Anticholinergics__anti_Parkinson_agents();
		var h_ = context.Operators.RetrieveByValueSet<MedicationRequest>(g_, null);
		var j_ = context.Operators.RetrieveByValueSet<MedicationRequest>(g_, null);
		var k_ = context.Operators.ListUnion<MedicationRequest>(h_, j_);
		var l_ = this.More_Than_One_Order(k_);
		var m_ = context.Operators.ListUnion<MedicationRequest>(f_, l_);
		var n_ = this.Antispasmodics();
		var o_ = context.Operators.RetrieveByValueSet<MedicationRequest>(n_, null);
		var q_ = context.Operators.RetrieveByValueSet<MedicationRequest>(n_, null);
		var r_ = context.Operators.ListUnion<MedicationRequest>(o_, q_);
		var s_ = this.More_Than_One_Order(r_);
		var t_ = this.Antithrombotic();
		var u_ = context.Operators.RetrieveByValueSet<MedicationRequest>(t_, null);
		var w_ = context.Operators.RetrieveByValueSet<MedicationRequest>(t_, null);
		var x_ = context.Operators.ListUnion<MedicationRequest>(u_, w_);
		var y_ = this.More_Than_One_Order(x_);
		var z_ = context.Operators.ListUnion<MedicationRequest>(s_, y_);
		var aa_ = context.Operators.ListUnion<MedicationRequest>(m_, z_);
		var ab_ = this.Cardiovascular__alpha_agonists__central();
		var ac_ = context.Operators.RetrieveByValueSet<MedicationRequest>(ab_, null);
		var ae_ = context.Operators.RetrieveByValueSet<MedicationRequest>(ab_, null);
		var af_ = context.Operators.ListUnion<MedicationRequest>(ac_, ae_);
		var ag_ = this.More_Than_One_Order(af_);
		var ah_ = this.Cardiovascular__other();
		var ai_ = context.Operators.RetrieveByValueSet<MedicationRequest>(ah_, null);
		var ak_ = context.Operators.RetrieveByValueSet<MedicationRequest>(ah_, null);
		var al_ = context.Operators.ListUnion<MedicationRequest>(ai_, ak_);
		var am_ = this.More_Than_One_Order(al_);
		var an_ = context.Operators.ListUnion<MedicationRequest>(ag_, am_);
		var ao_ = context.Operators.ListUnion<MedicationRequest>(aa_, an_);
		var ap_ = this.Central_nervous_system__antidepressants();
		var aq_ = context.Operators.RetrieveByValueSet<MedicationRequest>(ap_, null);
		var as_ = context.Operators.RetrieveByValueSet<MedicationRequest>(ap_, null);
		var at_ = context.Operators.ListUnion<MedicationRequest>(aq_, as_);
		var au_ = this.More_Than_One_Order(at_);
		var av_ = this.Central_nervous_system__barbiturates();
		var aw_ = context.Operators.RetrieveByValueSet<MedicationRequest>(av_, null);
		var ay_ = context.Operators.RetrieveByValueSet<MedicationRequest>(av_, null);
		var az_ = context.Operators.ListUnion<MedicationRequest>(aw_, ay_);
		var ba_ = this.More_Than_One_Order(az_);
		var bb_ = context.Operators.ListUnion<MedicationRequest>(au_, ba_);
		var bc_ = context.Operators.ListUnion<MedicationRequest>(ao_, bb_);
		var bd_ = this.Central_nervous_system__vasodilators();
		var be_ = context.Operators.RetrieveByValueSet<MedicationRequest>(bd_, null);
		var bg_ = context.Operators.RetrieveByValueSet<MedicationRequest>(bd_, null);
		var bh_ = context.Operators.ListUnion<MedicationRequest>(be_, bg_);
		var bi_ = this.More_Than_One_Order(bh_);
		var bj_ = this.Central_nervous_system__other();
		var bk_ = context.Operators.RetrieveByValueSet<MedicationRequest>(bj_, null);
		var bm_ = context.Operators.RetrieveByValueSet<MedicationRequest>(bj_, null);
		var bn_ = context.Operators.ListUnion<MedicationRequest>(bk_, bm_);
		var bo_ = this.More_Than_One_Order(bn_);
		var bp_ = context.Operators.ListUnion<MedicationRequest>(bi_, bo_);
		var bq_ = context.Operators.ListUnion<MedicationRequest>(bc_, bp_);
		var br_ = this.Endocrine_system__estrogens_with_or_without_progestins();
		var bs_ = context.Operators.RetrieveByValueSet<MedicationRequest>(br_, null);
		var bu_ = context.Operators.RetrieveByValueSet<MedicationRequest>(br_, null);
		var bv_ = context.Operators.ListUnion<MedicationRequest>(bs_, bu_);
		var bw_ = this.More_Than_One_Order(bv_);
		var bx_ = this.Endocrine_system__sulfonylureas__long_duration();
		var by_ = context.Operators.RetrieveByValueSet<MedicationRequest>(bx_, null);
		var ca_ = context.Operators.RetrieveByValueSet<MedicationRequest>(bx_, null);
		var cb_ = context.Operators.ListUnion<MedicationRequest>(by_, ca_);
		var cc_ = this.More_Than_One_Order(cb_);
		var cd_ = context.Operators.ListUnion<MedicationRequest>(bw_, cc_);
		var ce_ = context.Operators.ListUnion<MedicationRequest>(bq_, cd_);
		var cf_ = this.Endocrine_system__other();
		var cg_ = context.Operators.RetrieveByValueSet<MedicationRequest>(cf_, null);
		var ci_ = context.Operators.RetrieveByValueSet<MedicationRequest>(cf_, null);
		var cj_ = context.Operators.ListUnion<MedicationRequest>(cg_, ci_);
		var ck_ = this.More_Than_One_Order(cj_);
		var cl_ = this.Nonbenzodiazepine_hypnotics();
		var cm_ = context.Operators.RetrieveByValueSet<MedicationRequest>(cl_, null);
		var co_ = context.Operators.RetrieveByValueSet<MedicationRequest>(cl_, null);
		var cp_ = context.Operators.ListUnion<MedicationRequest>(cm_, co_);
		var cq_ = this.More_Than_One_Order(cp_);
		var cr_ = context.Operators.ListUnion<MedicationRequest>(ck_, cq_);
		var cs_ = context.Operators.ListUnion<MedicationRequest>(ce_, cr_);
		var ct_ = this.Pain_medications__skeletal_muscle_relaxants();
		var cu_ = context.Operators.RetrieveByValueSet<MedicationRequest>(ct_, null);
		var cw_ = context.Operators.RetrieveByValueSet<MedicationRequest>(ct_, null);
		var cx_ = context.Operators.ListUnion<MedicationRequest>(cu_, cw_);
		var cy_ = this.More_Than_One_Order(cx_);
		var cz_ = this.Pain_medications__other();
		var da_ = context.Operators.RetrieveByValueSet<MedicationRequest>(cz_, null);
		var dc_ = context.Operators.RetrieveByValueSet<MedicationRequest>(cz_, null);
		var dd_ = context.Operators.ListUnion<MedicationRequest>(da_, dc_);
		var de_ = this.More_Than_One_Order(dd_);
		var df_ = context.Operators.ListUnion<MedicationRequest>(cy_, de_);
		var dg_ = context.Operators.ListUnion<MedicationRequest>(cs_, df_);

		return dg_;
	}

    [CqlDeclaration("Same High Risk Medications Ordered on Different Days")]
	public IEnumerable<MedicationRequest> Same_High_Risk_Medications_Ordered_on_Different_Days() => 
		__Same_High_Risk_Medications_Ordered_on_Different_Days.Value;

    [CqlDeclaration("MedicationRequestPeriodInDays")]
	public decimal? MedicationRequestPeriodInDays(MedicationRequest Request)
	{
		var a_ = new MedicationRequest[]
		{
			Request,
		};
		decimal? b_(MedicationRequest R)
		{
			var e_ = FHIRHelpers_4_3_000.ToQuantity((R?.DispenseRequest?.ExpectedSupplyDuration as Quantity));
			var f_ = context.Operators.ConvertQuantity(e_, "d");
			var g_ = FHIRHelpers_4_3_000.ToQuantity(R?.DispenseRequest?.Quantity);
			var h_ = context.Operators.SingletonFrom<Dosage>((R?.DosageInstruction as IEnumerable<Dosage>));
			var i_ = context.Operators.SingletonFrom<Dosage.DoseAndRateComponent>((h_?.DoseAndRate as IEnumerable<Dosage.DoseAndRateComponent>));
			var j_ = FHIRHelpers_4_3_000.ToValue(i_?.Dose);
			var k_ = context.Operators.End((j_ as CqlInterval<CqlQuantity>));
			var m_ = context.Operators.SingletonFrom<Dosage.DoseAndRateComponent>((h_?.DoseAndRate as IEnumerable<Dosage.DoseAndRateComponent>));
			var n_ = FHIRHelpers_4_3_000.ToValue(m_?.Dose);
			var s_ = context.Operators.Convert<Code<Timing.UnitsOfTime>>(h_?.Timing?.Repeat?.PeriodUnitElement?.Value);
			var t_ = context.Operators.Convert<string>(s_);
			var u_ = CumulativeMedicationDuration_4_0_000.Quantity(h_?.Timing?.Repeat?.PeriodElement?.Value, t_);
			var v_ = CumulativeMedicationDuration_4_0_000.ToDaily((h_?.Timing?.Repeat?.FrequencyMaxElement?.Value ?? h_?.Timing?.Repeat?.FrequencyElement?.Value), u_);
			var x_ = context.Operators.LateBoundProperty<IEnumerable<CqlTime>>(h_?.Timing?.Repeat?.TimeOfDayElement, "value");
			var y_ = context.Operators.Count<CqlTime>(x_);
			var z_ = context.Operators.ConvertIntegerToDecimal(y_);
			var aa_ = context.Operators.Multiply((k_ ?? (n_ as CqlQuantity))?.value, ((v_ ?? z_) ?? (decimal?)1.0m));
			var ab_ = context.Operators.Divide(g_?.value, aa_);
			var ac_ = context.Operators.Add((int?)1, (R?.DispenseRequest?.NumberOfRepeatsAllowedElement?.Value ?? (int?)0));
			var ad_ = context.Operators.ConvertIntegerToDecimal(ac_);
			var ae_ = context.Operators.Multiply((f_?.value ?? ab_), ad_);

			return ae_;
		};
		var c_ = context.Operators.SelectOrNull<MedicationRequest, decimal?>(a_, b_);
		var d_ = context.Operators.SingletonFrom<decimal?>(c_);

		return d_;
	}

	private bool? Two_High_Risk_Medications_with_Prolonged_Duration_Value()
	{
		var a_ = this.Anti_Infectives__other();
		var b_ = context.Operators.RetrieveByValueSet<MedicationRequest>(a_, null);
		var d_ = context.Operators.RetrieveByValueSet<MedicationRequest>(a_, null);
		var e_ = context.Operators.ListUnion<MedicationRequest>(b_, d_);
		var f_ = this.More_Than_One_Order(e_);
		decimal? g_(MedicationRequest AntiInfectives)
		{
			var l_ = this.MedicationRequestPeriodInDays(AntiInfectives);

			return l_;
		};
		var h_ = context.Operators.SelectOrNull<MedicationRequest, decimal?>(f_, g_);
		var i_ = context.Operators.Sum(h_);
		var j_ = context.Operators.ConvertIntegerToDecimal((int?)90);
		var k_ = context.Operators.Greater(i_, j_);

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
				var t_ = this.reserpine_0_1_MG_Oral_Tablet();
				var u_ = context.Operators.ConvertCodeToConcept(t_);
				var v_ = context.Operators.Equivalent(Strength, u_);

				return (v_ ?? false);
			};
			bool c_()
			{
				var w_ = this.reserpine_0_25_MG_Oral_Tablet();
				var x_ = context.Operators.ConvertCodeToConcept(w_);
				var y_ = context.Operators.Equivalent(Strength, x_);

				return (y_ ?? false);
			};
			bool d_()
			{
				var z_ = this.digoxin_0_05_MG_ML_Oral_Solution();
				var aa_ = context.Operators.ConvertCodeToConcept(z_);
				var ab_ = context.Operators.Equivalent(Strength, aa_);

				return (ab_ ?? false);
			};
			bool e_()
			{
				var ac_ = this.digoxin_0_0625_MG_Oral_Tablet();
				var ad_ = context.Operators.ConvertCodeToConcept(ac_);
				var ae_ = context.Operators.Equivalent(Strength, ad_);

				return (ae_ ?? false);
			};
			bool f_()
			{
				var af_ = this._1_ML_digoxin_0_1_MG_ML_Injection();
				var ag_ = context.Operators.ConvertCodeToConcept(af_);
				var ah_ = context.Operators.Equivalent(Strength, ag_);

				return (ah_ ?? false);
			};
			bool g_()
			{
				var ai_ = this.digoxin_0_125_MG_Oral_Tablet();
				var aj_ = context.Operators.ConvertCodeToConcept(ai_);
				var ak_ = context.Operators.Equivalent(Strength, aj_);

				return (ak_ ?? false);
			};
			bool h_()
			{
				var al_ = this.digoxin_0_1875_MG_Oral_Tablet();
				var am_ = context.Operators.ConvertCodeToConcept(al_);
				var an_ = context.Operators.Equivalent(Strength, am_);

				return (an_ ?? false);
			};
			bool i_()
			{
				var ao_ = this.digoxin_0_25_MG_Oral_Tablet();
				var ap_ = context.Operators.ConvertCodeToConcept(ao_);
				var aq_ = context.Operators.Equivalent(Strength, ap_);

				return (aq_ ?? false);
			};
			bool j_()
			{
				var ar_ = this._2_ML_digoxin_0_25_MG_ML_Injection();
				var as_ = context.Operators.ConvertCodeToConcept(ar_);
				var at_ = context.Operators.Equivalent(Strength, as_);

				return (at_ ?? false);
			};
			bool k_()
			{
				var au_ = this.doxepin_3_MG_Oral_Tablet();
				var av_ = context.Operators.ConvertCodeToConcept(au_);
				var aw_ = context.Operators.Equivalent(Strength, av_);

				return (aw_ ?? false);
			};
			bool l_()
			{
				var ax_ = this.doxepin_6_MG_Oral_Tablet();
				var ay_ = context.Operators.ConvertCodeToConcept(ax_);
				var az_ = context.Operators.Equivalent(Strength, ay_);

				return (az_ ?? false);
			};
			bool m_()
			{
				var ba_ = this.doxepin_hydrochloride_10_MG_Oral_Capsule();
				var bb_ = context.Operators.ConvertCodeToConcept(ba_);
				var bc_ = context.Operators.Equivalent(Strength, bb_);

				return (bc_ ?? false);
			};
			bool n_()
			{
				var bd_ = this.doxepin_hydrochloride_10_MG_ML_Oral_Solution();
				var be_ = context.Operators.ConvertCodeToConcept(bd_);
				var bf_ = context.Operators.Equivalent(Strength, be_);

				return (bf_ ?? false);
			};
			bool o_()
			{
				var bg_ = this.doxepin_hydrochloride_25_MG_Oral_Capsule();
				var bh_ = context.Operators.ConvertCodeToConcept(bg_);
				var bi_ = context.Operators.Equivalent(Strength, bh_);

				return (bi_ ?? false);
			};
			bool p_()
			{
				var bj_ = this.doxepin_hydrochloride_50_MG_Oral_Capsule();
				var bk_ = context.Operators.ConvertCodeToConcept(bj_);
				var bl_ = context.Operators.Equivalent(Strength, bk_);

				return (bl_ ?? false);
			};
			bool q_()
			{
				var bm_ = this.doxepin_hydrochloride_75_MG_Oral_Capsule();
				var bn_ = context.Operators.ConvertCodeToConcept(bm_);
				var bo_ = context.Operators.Equivalent(Strength, bn_);

				return (bo_ ?? false);
			};
			bool r_()
			{
				var bp_ = this.doxepin_hydrochloride_100_MG_Oral_Capsule();
				var bq_ = context.Operators.ConvertCodeToConcept(bp_);
				var br_ = context.Operators.Equivalent(Strength, bq_);

				return (br_ ?? false);
			};
			bool s_()
			{
				var bs_ = this.doxepin_hydrochloride_150_MG_Oral_Capsule();
				var bt_ = context.Operators.ConvertCodeToConcept(bs_);
				var bu_ = context.Operators.Equivalent(Strength, bt_);

				return (bu_ ?? false);
			};
			if (b_())
			{
				var bv_ = context.Operators.Quantity((decimal?)0.1m, "mg");

				return bv_;
			}
			else if (c_())
			{
				var bw_ = context.Operators.Quantity((decimal?)0.25m, "mg");

				return bw_;
			}
			else if (d_())
			{
				var bx_ = context.Operators.Quantity((decimal?)0.05m, "mg/mL");

				return bx_;
			}
			else if (e_())
			{
				var by_ = context.Operators.Quantity((decimal?)0.0625m, "mg");

				return by_;
			}
			else if (f_())
			{
				var bz_ = context.Operators.Quantity((decimal?)0.1m, "mg/mL");

				return bz_;
			}
			else if (g_())
			{
				var ca_ = context.Operators.Quantity((decimal?)0.125m, "mg");

				return ca_;
			}
			else if (h_())
			{
				var cb_ = context.Operators.Quantity((decimal?)0.1875m, "mg");

				return cb_;
			}
			else if (i_())
			{
				var cc_ = context.Operators.Quantity((decimal?)0.25m, "mg");

				return cc_;
			}
			else if (j_())
			{
				var cd_ = context.Operators.Quantity((decimal?)0.25m, "mg/mL");

				return cd_;
			}
			else if (k_())
			{
				var ce_ = context.Operators.Quantity((decimal?)3m, "mg");

				return ce_;
			}
			else if (l_())
			{
				var cf_ = context.Operators.Quantity((decimal?)6m, "mg");

				return cf_;
			}
			else if (m_())
			{
				var cg_ = context.Operators.Quantity((decimal?)10m, "mg");

				return cg_;
			}
			else if (n_())
			{
				var ch_ = context.Operators.Quantity((decimal?)10m, "mg/mL");

				return ch_;
			}
			else if (o_())
			{
				var ci_ = context.Operators.Quantity((decimal?)25m, "mg");

				return ci_;
			}
			else if (p_())
			{
				var cj_ = context.Operators.Quantity((decimal?)50m, "mg");

				return cj_;
			}
			else if (q_())
			{
				var ck_ = context.Operators.Quantity((decimal?)75m, "mg");

				return ck_;
			}
			else if (r_())
			{
				var cl_ = context.Operators.Quantity((decimal?)100m, "mg");

				return cl_;
			}
			else if (s_())
			{
				var cm_ = context.Operators.Quantity((decimal?)150m, "mg");

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
		var a_ = new MedicationRequest[]
		{
			MedicationRequest,
		};
		CqlQuantity b_(MedicationRequest Order)
		{
			CqlQuantity e_()
			{
				bool f_()
				{
					var g_ = this.MedicationRequestPeriodInDays(Order);
					var h_ = context.Operators.Not((bool?)(g_ is null));
					var i_ = CQMCommon_2_0_000.getMedicationCode(Order);
					var j_ = this.MedicationStrengthPerUnit(i_);
					var k_ = context.Operators.Equal(j_?.unit, "mg");
					var m_ = this.MedicationStrengthPerUnit(i_);
					var n_ = context.Operators.Equal(m_?.unit, "mg/mL");
					var o_ = FHIRHelpers_4_3_000.ToQuantity(Order?.DispenseRequest?.Quantity);
					var p_ = context.Operators.Equal(o_?.unit, "mL");
					var q_ = context.Operators.And(n_, p_);
					var r_ = context.Operators.Or(k_, q_);
					var s_ = context.Operators.And(h_, r_);

					return (s_ ?? false);
				};
				if (f_())
				{
					var t_ = FHIRHelpers_4_3_000.ToQuantity(Order?.DispenseRequest?.Quantity);
					var u_ = CQMCommon_2_0_000.getMedicationCode(Order);
					var v_ = this.MedicationStrengthPerUnit(u_);
					var w_ = context.Operators.Multiply(t_, v_);
					var x_ = this.MedicationRequestPeriodInDays(Order);
					var y_ = context.Operators.Divide(w_, new CqlQuantity(x_, "d"));

					return y_;
				}
				else
				{
					return null;
				};
			};

			return e_();
		};
		var c_ = context.Operators.SelectOrNull<MedicationRequest, CqlQuantity>(a_, b_);
		var d_ = context.Operators.SingletonFrom<CqlQuantity>(c_);

		return d_;
	}

	private bool? High_Risk_Medications_with_Average_Daily_Dose_Criteria_Value()
	{
		var a_ = this.Reserpine();
		var b_ = context.Operators.RetrieveByValueSet<MedicationRequest>(a_, null);
		var d_ = context.Operators.RetrieveByValueSet<MedicationRequest>(a_, null);
		var e_ = context.Operators.ListUnion<MedicationRequest>(b_, d_);
		bool? f_(MedicationRequest ReserpineOrdered)
		{
			var ad_ = this.Average_Daily_Dose(ReserpineOrdered);
			var ae_ = context.Operators.Quantity((decimal?)0.1m, "mg/d");
			var af_ = context.Operators.Greater(ad_, ae_);

			return af_;
		};
		var g_ = context.Operators.WhereOrNull<MedicationRequest>(e_, f_);
		var h_ = this.More_Than_One_Order(g_);
		var i_ = context.Operators.Exists<MedicationRequest>(h_);
		var j_ = this.Digoxin();
		var k_ = context.Operators.RetrieveByValueSet<MedicationRequest>(j_, null);
		var m_ = context.Operators.RetrieveByValueSet<MedicationRequest>(j_, null);
		var n_ = context.Operators.ListUnion<MedicationRequest>(k_, m_);
		bool? o_(MedicationRequest DigoxinOrdered)
		{
			var ag_ = this.Average_Daily_Dose(DigoxinOrdered);
			var ah_ = context.Operators.Quantity((decimal?)0.125m, "mg/d");
			var ai_ = context.Operators.Greater(ag_, ah_);

			return ai_;
		};
		var p_ = context.Operators.WhereOrNull<MedicationRequest>(n_, o_);
		var q_ = this.More_Than_One_Order(p_);
		var r_ = context.Operators.Exists<MedicationRequest>(q_);
		var s_ = context.Operators.Or(i_, r_);
		var t_ = this.Doxepin();
		var u_ = context.Operators.RetrieveByValueSet<MedicationRequest>(t_, null);
		var w_ = context.Operators.RetrieveByValueSet<MedicationRequest>(t_, null);
		var x_ = context.Operators.ListUnion<MedicationRequest>(u_, w_);
		bool? y_(MedicationRequest DoxepinOrdered)
		{
			var aj_ = this.Average_Daily_Dose(DoxepinOrdered);
			var ak_ = context.Operators.Quantity((decimal?)6m, "mg/d");
			var al_ = context.Operators.Greater(aj_, ak_);

			return al_;
		};
		var z_ = context.Operators.WhereOrNull<MedicationRequest>(x_, y_);
		var aa_ = this.More_Than_One_Order(z_);
		var ab_ = context.Operators.Exists<MedicationRequest>(aa_);
		var ac_ = context.Operators.Or(s_, ab_);

		return ac_;
	}

    [CqlDeclaration("High Risk Medications with Average Daily Dose Criteria")]
	public bool? High_Risk_Medications_with_Average_Daily_Dose_Criteria() => 
		__High_Risk_Medications_with_Average_Daily_Dose_Criteria.Value;

	private bool? Numerator_1_Value()
	{
		var a_ = this.Same_High_Risk_Medications_Ordered_on_Different_Days();
		var b_ = context.Operators.Exists<MedicationRequest>(a_);
		var c_ = this.Two_High_Risk_Medications_with_Prolonged_Duration();
		var d_ = context.Operators.Or(b_, c_);
		var e_ = this.High_Risk_Medications_with_Average_Daily_Dose_Criteria();
		var f_ = context.Operators.Or(d_, e_);

		return f_;
	}

    [CqlDeclaration("Numerator 1")]
	public bool? Numerator_1() => 
		__Numerator_1.Value;

	private bool? More_than_One_Antipsychotic_Order_Value()
	{
		var a_ = this.Antipsychotic();
		var b_ = context.Operators.RetrieveByValueSet<MedicationRequest>(a_, null);
		var d_ = context.Operators.RetrieveByValueSet<MedicationRequest>(a_, null);
		var e_ = context.Operators.ListUnion<MedicationRequest>(b_, d_);
		var f_ = this.More_Than_One_Order(e_);
		var g_ = context.Operators.Exists<MedicationRequest>(f_);

		return g_;
	}

    [CqlDeclaration("More than One Antipsychotic Order")]
	public bool? More_than_One_Antipsychotic_Order() => 
		__More_than_One_Antipsychotic_Order.Value;

	private CqlDateTime Antipsychotic_Index_Prescription_Start_Date_Value()
	{
		var a_ = this.Antipsychotic();
		var b_ = context.Operators.RetrieveByValueSet<MedicationRequest>(a_, null);
		var d_ = context.Operators.RetrieveByValueSet<MedicationRequest>(a_, null);
		var e_ = context.Operators.ListUnion<MedicationRequest>(b_, d_);
		var f_ = Status_1_6_000.Active_or_Completed_Medication_Request(e_);
		bool? g_(MedicationRequest AntipsychoticMedication)
		{
			var m_ = context.Operators.Convert<CqlDateTime>(AntipsychoticMedication?.AuthoredOnElement);
			var n_ = this.Measurement_Period();
			var o_ = context.Operators.In<CqlDateTime>(m_, n_, null);

			return o_;
		};
		var h_ = context.Operators.WhereOrNull<MedicationRequest>(f_, g_);
		CqlDateTime i_(MedicationRequest AntipsychoticMedication)
		{
			var p_ = context.Operators.Convert<CqlDateTime>(AntipsychoticMedication?.AuthoredOnElement);

			return p_;
		};
		var j_ = context.Operators.SelectOrNull<MedicationRequest, CqlDateTime>(h_, i_);
		var k_ = context.Operators.ListSort<CqlDateTime>(j_, System.ComponentModel.ListSortDirection.Ascending);
		var l_ = context.Operators.First<CqlDateTime>(k_);

		return l_;
	}

    [CqlDeclaration("Antipsychotic Index Prescription Start Date")]
	public CqlDateTime Antipsychotic_Index_Prescription_Start_Date() => 
		__Antipsychotic_Index_Prescription_Start_Date.Value;

	private bool? More_than_One_Benzodiazepine_Order_Value()
	{
		var a_ = this.Benzodiazepine();
		var b_ = context.Operators.RetrieveByValueSet<MedicationRequest>(a_, null);
		var d_ = context.Operators.RetrieveByValueSet<MedicationRequest>(a_, null);
		var e_ = context.Operators.ListUnion<MedicationRequest>(b_, d_);
		var f_ = this.More_Than_One_Order(e_);
		var g_ = context.Operators.Exists<MedicationRequest>(f_);

		return g_;
	}

    [CqlDeclaration("More than One Benzodiazepine Order")]
	public bool? More_than_One_Benzodiazepine_Order() => 
		__More_than_One_Benzodiazepine_Order.Value;

	private CqlDateTime Benzodiazepine_Index_Prescription_Start_Date_Value()
	{
		var a_ = this.Benzodiazepine();
		var b_ = context.Operators.RetrieveByValueSet<MedicationRequest>(a_, null);
		var d_ = context.Operators.RetrieveByValueSet<MedicationRequest>(a_, null);
		var e_ = context.Operators.ListUnion<MedicationRequest>(b_, d_);
		var f_ = Status_1_6_000.Active_or_Completed_Medication_Request(e_);
		bool? g_(MedicationRequest BenzodiazepineMedication)
		{
			var m_ = context.Operators.Convert<CqlDateTime>(BenzodiazepineMedication?.AuthoredOnElement);
			var n_ = this.Measurement_Period();
			var o_ = context.Operators.In<CqlDateTime>(m_, n_, null);

			return o_;
		};
		var h_ = context.Operators.WhereOrNull<MedicationRequest>(f_, g_);
		CqlDateTime i_(MedicationRequest BenzodiazepineMedication)
		{
			var p_ = context.Operators.Convert<CqlDateTime>(BenzodiazepineMedication?.AuthoredOnElement);

			return p_;
		};
		var j_ = context.Operators.SelectOrNull<MedicationRequest, CqlDateTime>(h_, i_);
		var k_ = context.Operators.ListSort<CqlDateTime>(j_, System.ComponentModel.ListSortDirection.Ascending);
		var l_ = context.Operators.First<CqlDateTime>(k_);

		return l_;
	}

    [CqlDeclaration("Benzodiazepine Index Prescription Start Date")]
	public CqlDateTime Benzodiazepine_Index_Prescription_Start_Date() => 
		__Benzodiazepine_Index_Prescription_Start_Date.Value;

	private bool? Numerator_2_Value()
	{
		var a_ = this.More_than_One_Antipsychotic_Order();
		var b_ = this.Schizophrenia();
		var c_ = context.Operators.RetrieveByValueSet<Condition>(b_, null);
		var d_ = this.Bipolar_Disorder();
		var e_ = context.Operators.RetrieveByValueSet<Condition>(d_, null);
		var f_ = context.Operators.ListUnion<Condition>(c_, e_);
		bool? g_(Condition AntipsychoticTreatedDiagnoses)
		{
			var ag_ = QICoreCommon_2_0_000.ToPrevalenceInterval(AntipsychoticTreatedDiagnoses);
			var ah_ = this.Measurement_Period();
			var ai_ = context.Operators.Start(ah_);
			var aj_ = context.Operators.Quantity((decimal?)1m, "year");
			var ak_ = context.Operators.Subtract(ai_, aj_);
			var al_ = this.Antipsychotic_Index_Prescription_Start_Date();
			var am_ = context.Operators.Interval(ak_, al_, (bool?)true, (bool?)true);
			var an_ = context.Operators.Overlaps(ag_, am_, null);

			return an_;
		};
		var h_ = context.Operators.WhereOrNull<Condition>(f_, g_);
		var i_ = context.Operators.Exists<Condition>(h_);
		var j_ = context.Operators.Not(i_);
		var k_ = context.Operators.And(a_, j_);
		var l_ = this.More_than_One_Benzodiazepine_Order();
		var m_ = this.Seizure_Disorder();
		var n_ = context.Operators.RetrieveByValueSet<Condition>(m_, null);
		var o_ = this.REM_Sleep_Behavior_Disorder();
		var p_ = context.Operators.RetrieveByValueSet<Condition>(o_, null);
		var q_ = context.Operators.ListUnion<Condition>(n_, p_);
		var r_ = this.Benzodiazepine_Withdrawal();
		var s_ = context.Operators.RetrieveByValueSet<Condition>(r_, null);
		var t_ = this.Alcohol_Withdrawal();
		var u_ = context.Operators.RetrieveByValueSet<Condition>(t_, null);
		var v_ = context.Operators.ListUnion<Condition>(s_, u_);
		var w_ = context.Operators.ListUnion<Condition>(q_, v_);
		var x_ = this.Generalized_Anxiety_Disorder();
		var y_ = context.Operators.RetrieveByValueSet<Condition>(x_, null);
		var z_ = context.Operators.ListUnion<Condition>(w_, y_);
		bool? aa_(Condition BenzodiazepineTreatedDiagnoses)
		{
			var ao_ = QICoreCommon_2_0_000.ToPrevalenceInterval(BenzodiazepineTreatedDiagnoses);
			var ap_ = this.Measurement_Period();
			var aq_ = context.Operators.Start(ap_);
			var ar_ = context.Operators.Quantity((decimal?)1m, "year");
			var as_ = context.Operators.Subtract(aq_, ar_);
			var at_ = this.Benzodiazepine_Index_Prescription_Start_Date();
			var au_ = context.Operators.Interval(as_, at_, (bool?)true, (bool?)true);
			var av_ = context.Operators.Overlaps(ao_, au_, null);

			return av_;
		};
		var ab_ = context.Operators.WhereOrNull<Condition>(z_, aa_);
		var ac_ = context.Operators.Exists<Condition>(ab_);
		var ad_ = context.Operators.Not(ac_);
		var ae_ = context.Operators.And(l_, ad_);
		var af_ = context.Operators.Or(k_, ae_);

		return af_;
	}

    [CqlDeclaration("Numerator 2")]
	public bool? Numerator_2() => 
		__Numerator_2.Value;

	private bool? Numerator_3_Value()
	{
		var a_ = this.Numerator_2();
		var b_ = this.Numerator_1();
		var d_ = context.Operators.Not(a_);
		var e_ = context.Operators.And(b_, d_);
		var f_ = context.Operators.Or(a_, e_);

		return f_;
	}

    [CqlDeclaration("Numerator 3")]
	public bool? Numerator_3() => 
		__Numerator_3.Value;

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

}
