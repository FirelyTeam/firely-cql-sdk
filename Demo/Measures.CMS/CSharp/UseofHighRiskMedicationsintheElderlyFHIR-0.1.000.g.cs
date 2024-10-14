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
[System.CodeDom.Compiler.GeneratedCode(".NET Code Generation", "2.0.5.0")]
[CqlLibrary("UseofHighRiskMedicationsintheElderlyFHIR", "0.1.000")]
public partial class UseofHighRiskMedicationsintheElderlyFHIR_0_1_000 : ILibrary, ISingleton<UseofHighRiskMedicationsintheElderlyFHIR_0_1_000>
{
    private UseofHighRiskMedicationsintheElderlyFHIR_0_1_000() {}

    public static UseofHighRiskMedicationsintheElderlyFHIR_0_1_000 Instance { get; } = new();

    #region Library Members
    public string Name => "UseofHighRiskMedicationsintheElderlyFHIR";
    public string Version => "0.1.000";
    public ILibrary[] Dependencies => [FHIRHelpers_4_3_000.Instance, SupplementalDataElements_3_4_000.Instance, CQMCommon_2_0_000.Instance, Hospice_6_9_000.Instance, PalliativeCare_1_9_000.Instance, CumulativeMedicationDuration_4_0_000.Instance, QICoreCommon_2_0_000.Instance, Status_1_6_000.Instance];
    #endregion Library Members

    [CqlDeclaration("Alcohol Withdrawal")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.105.12.1209")]
	public CqlValueSet Alcohol_Withdrawal(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.105.12.1209", default);


    [CqlDeclaration("Annual Wellness Visit")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1240")]
	public CqlValueSet Annual_Wellness_Visit(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1240", default);


    [CqlDeclaration("Anti Infectives, other")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.196.12.1481")]
	public CqlValueSet Anti_Infectives__other(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.196.12.1481", default);


    [CqlDeclaration("Anticholinergics, anti Parkinson agents")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.1049")]
	public CqlValueSet Anticholinergics__anti_Parkinson_agents(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.1049", default);


    [CqlDeclaration("Anticholinergics, first generation antihistamines")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.1043")]
	public CqlValueSet Anticholinergics__first_generation_antihistamines(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.1043", default);


    [CqlDeclaration("Antipsychotic")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.196.12.1523")]
	public CqlValueSet Antipsychotic(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.196.12.1523", default);


    [CqlDeclaration("Antispasmodics")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.1050")]
	public CqlValueSet Antispasmodics(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.1050", default);


    [CqlDeclaration("Antithrombotic")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.1051")]
	public CqlValueSet Antithrombotic(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.1051", default);


    [CqlDeclaration("Benzodiazepine Withdrawal")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.105.12.1208")]
	public CqlValueSet Benzodiazepine_Withdrawal(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.105.12.1208", default);


    [CqlDeclaration("Benzodiazepine")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.196.12.1522")]
	public CqlValueSet Benzodiazepine(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.196.12.1522", default);


    [CqlDeclaration("Bipolar Disorder")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.105.12.1157")]
	public CqlValueSet Bipolar_Disorder(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.105.12.1157", default);


    [CqlDeclaration("Cardiovascular, alpha agonists, central")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.1052")]
	public CqlValueSet Cardiovascular__alpha_agonists__central(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.1052", default);


    [CqlDeclaration("Cardiovascular, other")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.1053")]
	public CqlValueSet Cardiovascular__other(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.1053", default);


    [CqlDeclaration("Care Services in Long Term Residential Facility")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1014")]
	public CqlValueSet Care_Services_in_Long_Term_Residential_Facility(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1014", default);


    [CqlDeclaration("Central nervous system, antidepressants")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.1054")]
	public CqlValueSet Central_nervous_system__antidepressants(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.1054", default);


    [CqlDeclaration("Central nervous system, barbiturates")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.1055")]
	public CqlValueSet Central_nervous_system__barbiturates(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.1055", default);


    [CqlDeclaration("Central nervous system, other")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.1057")]
	public CqlValueSet Central_nervous_system__other(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.1057", default);


    [CqlDeclaration("Central nervous system, vasodilators")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.1056")]
	public CqlValueSet Central_nervous_system__vasodilators(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.1056", default);


    [CqlDeclaration("Digoxin")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.1065")]
	public CqlValueSet Digoxin(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.1065", default);


    [CqlDeclaration("Discharge Services Nursing Facility")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1013")]
	public CqlValueSet Discharge_Services_Nursing_Facility(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1013", default);


    [CqlDeclaration("Doxepin")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.1067")]
	public CqlValueSet Doxepin(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.1067", default);


    [CqlDeclaration("Endocrine system, estrogens with or without progestins")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.1058")]
	public CqlValueSet Endocrine_system__estrogens_with_or_without_progestins(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.1058", default);


    [CqlDeclaration("Endocrine system, other")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.1060")]
	public CqlValueSet Endocrine_system__other(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.1060", default);


    [CqlDeclaration("Endocrine system, sulfonylureas, long duration")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.1059")]
	public CqlValueSet Endocrine_system__sulfonylureas__long_duration(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.1059", default);


    [CqlDeclaration("Generalized Anxiety Disorder")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.105.12.1210")]
	public CqlValueSet Generalized_Anxiety_Disorder(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.105.12.1210", default);


    [CqlDeclaration("Home Healthcare Services")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1016")]
	public CqlValueSet Home_Healthcare_Services(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1016", default);


    [CqlDeclaration("Nonbenzodiazepine hypnotics")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.196.12.1480")]
	public CqlValueSet Nonbenzodiazepine_hypnotics(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.196.12.1480", default);


    [CqlDeclaration("Nursing Facility Visit")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1012")]
	public CqlValueSet Nursing_Facility_Visit(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1012", default);


    [CqlDeclaration("Office Visit")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1001")]
	public CqlValueSet Office_Visit(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1001", default);


    [CqlDeclaration("Online Assessments")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1089")]
	public CqlValueSet Online_Assessments(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1089", default);


    [CqlDeclaration("Ophthalmologic Services")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.11.1206")]
	public CqlValueSet Ophthalmologic_Services(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.11.1206", default);


    [CqlDeclaration("Pain medications, other")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.1063")]
	public CqlValueSet Pain_medications__other(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.1063", default);


    [CqlDeclaration("Pain medications, skeletal muscle relaxants")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.1062")]
	public CqlValueSet Pain_medications__skeletal_muscle_relaxants(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.1062", default);


    [CqlDeclaration("Preventive Care Services Established Office Visit, 18 and Up")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1025")]
	public CqlValueSet Preventive_Care_Services_Established_Office_Visit__18_and_Up(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1025", default);


    [CqlDeclaration("Preventive Care Services Initial Office Visit, 18 and Up")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1023")]
	public CqlValueSet Preventive_Care_Services_Initial_Office_Visit__18_and_Up(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1023", default);


    [CqlDeclaration("REM Sleep Behavior Disorder")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.105.12.1207")]
	public CqlValueSet REM_Sleep_Behavior_Disorder(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.105.12.1207", default);


    [CqlDeclaration("Reserpine")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.1044")]
	public CqlValueSet Reserpine(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.1044", default);


    [CqlDeclaration("Schizophrenia")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.105.12.1205")]
	public CqlValueSet Schizophrenia(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.105.12.1205", default);


    [CqlDeclaration("Seizure Disorder")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.105.12.1206")]
	public CqlValueSet Seizure_Disorder(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.105.12.1206", default);


    [CqlDeclaration("Telephone Visits")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1080")]
	public CqlValueSet Telephone_Visits(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1080", default);


    [CqlDeclaration("1 ML digoxin 0.1 MG/ML Injection")]
	public CqlCode _1_ML_digoxin_0_1_MG_ML_Injection(CqlContext context) => 
		new CqlCode("204504", "http://www.nlm.nih.gov/research/umls/rxnorm", default, default);


    [CqlDeclaration("2 ML digoxin 0.25 MG/ML Injection")]
	public CqlCode _2_ML_digoxin_0_25_MG_ML_Injection(CqlContext context) => 
		new CqlCode("104208", "http://www.nlm.nih.gov/research/umls/rxnorm", default, default);


    [CqlDeclaration("digoxin 0.05 MG/ML Oral Solution")]
	public CqlCode digoxin_0_05_MG_ML_Oral_Solution(CqlContext context) => 
		new CqlCode("393245", "http://www.nlm.nih.gov/research/umls/rxnorm", default, default);


    [CqlDeclaration("digoxin 0.0625 MG Oral Tablet")]
	public CqlCode digoxin_0_0625_MG_Oral_Tablet(CqlContext context) => 
		new CqlCode("245273", "http://www.nlm.nih.gov/research/umls/rxnorm", default, default);


    [CqlDeclaration("digoxin 0.125 MG Oral Tablet")]
	public CqlCode digoxin_0_125_MG_Oral_Tablet(CqlContext context) => 
		new CqlCode("197604", "http://www.nlm.nih.gov/research/umls/rxnorm", default, default);


    [CqlDeclaration("digoxin 0.1875 MG Oral Tablet")]
	public CqlCode digoxin_0_1875_MG_Oral_Tablet(CqlContext context) => 
		new CqlCode("1441565", "http://www.nlm.nih.gov/research/umls/rxnorm", default, default);


    [CqlDeclaration("digoxin 0.25 MG Oral Tablet")]
	public CqlCode digoxin_0_25_MG_Oral_Tablet(CqlContext context) => 
		new CqlCode("197606", "http://www.nlm.nih.gov/research/umls/rxnorm", default, default);


    [CqlDeclaration("doxepin 3 MG Oral Tablet")]
	public CqlCode doxepin_3_MG_Oral_Tablet(CqlContext context) => 
		new CqlCode("966787", "http://www.nlm.nih.gov/research/umls/rxnorm", default, default);


    [CqlDeclaration("doxepin 6 MG Oral Tablet")]
	public CqlCode doxepin_6_MG_Oral_Tablet(CqlContext context) => 
		new CqlCode("966793", "http://www.nlm.nih.gov/research/umls/rxnorm", default, default);


    [CqlDeclaration("doxepin hydrochloride 10 MG Oral Capsule")]
	public CqlCode doxepin_hydrochloride_10_MG_Oral_Capsule(CqlContext context) => 
		new CqlCode("1000048", "http://www.nlm.nih.gov/research/umls/rxnorm", default, default);


    [CqlDeclaration("doxepin hydrochloride 10 MG/ML Oral Solution")]
	public CqlCode doxepin_hydrochloride_10_MG_ML_Oral_Solution(CqlContext context) => 
		new CqlCode("1000054", "http://www.nlm.nih.gov/research/umls/rxnorm", default, default);


    [CqlDeclaration("doxepin hydrochloride 100 MG Oral Capsule")]
	public CqlCode doxepin_hydrochloride_100_MG_Oral_Capsule(CqlContext context) => 
		new CqlCode("1000058", "http://www.nlm.nih.gov/research/umls/rxnorm", default, default);


    [CqlDeclaration("doxepin hydrochloride 150 MG Oral Capsule")]
	public CqlCode doxepin_hydrochloride_150_MG_Oral_Capsule(CqlContext context) => 
		new CqlCode("1000064", "http://www.nlm.nih.gov/research/umls/rxnorm", default, default);


    [CqlDeclaration("doxepin hydrochloride 25 MG Oral Capsule")]
	public CqlCode doxepin_hydrochloride_25_MG_Oral_Capsule(CqlContext context) => 
		new CqlCode("1000070", "http://www.nlm.nih.gov/research/umls/rxnorm", default, default);


    [CqlDeclaration("doxepin hydrochloride 50 MG Oral Capsule")]
	public CqlCode doxepin_hydrochloride_50_MG_Oral_Capsule(CqlContext context) => 
		new CqlCode("1000076", "http://www.nlm.nih.gov/research/umls/rxnorm", default, default);


    [CqlDeclaration("doxepin hydrochloride 75 MG Oral Capsule")]
	public CqlCode doxepin_hydrochloride_75_MG_Oral_Capsule(CqlContext context) => 
		new CqlCode("1000097", "http://www.nlm.nih.gov/research/umls/rxnorm", default, default);


    [CqlDeclaration("Office or other outpatient visit for the evaluation and management of an established patient, that may not require the presence of a physician or other qualified health care professional. Usually, the presenting problem(s) are minimal.")]
	public CqlCode Office_or_other_outpatient_visit_for_the_evaluation_and_management_of_an_established_patient__that_may_not_require_the_presence_of_a_physician_or_other_qualified_health_care_professional__Usually__the_presenting_problem_s__are_minimal_(CqlContext context) => 
		new CqlCode("99211", "http://www.ama-assn.org/go/cpt", default, default);


    [CqlDeclaration("reserpine 0.1 MG Oral Tablet")]
	public CqlCode reserpine_0_1_MG_Oral_Tablet(CqlContext context) => 
		new CqlCode("198196", "http://www.nlm.nih.gov/research/umls/rxnorm", default, default);


    [CqlDeclaration("reserpine 0.25 MG Oral Tablet")]
	public CqlCode reserpine_0_25_MG_Oral_Tablet(CqlContext context) => 
		new CqlCode("198197", "http://www.nlm.nih.gov/research/umls/rxnorm", default, default);


    [CqlDeclaration("RXNORM")]
	public CqlCode[] RXNORM(CqlContext context)
	{
		CqlCode[] a_ = [
			new CqlCode("204504", "http://www.nlm.nih.gov/research/umls/rxnorm", default, default),
			new CqlCode("104208", "http://www.nlm.nih.gov/research/umls/rxnorm", default, default),
			new CqlCode("393245", "http://www.nlm.nih.gov/research/umls/rxnorm", default, default),
			new CqlCode("245273", "http://www.nlm.nih.gov/research/umls/rxnorm", default, default),
			new CqlCode("197604", "http://www.nlm.nih.gov/research/umls/rxnorm", default, default),
			new CqlCode("1441565", "http://www.nlm.nih.gov/research/umls/rxnorm", default, default),
			new CqlCode("197606", "http://www.nlm.nih.gov/research/umls/rxnorm", default, default),
			new CqlCode("966787", "http://www.nlm.nih.gov/research/umls/rxnorm", default, default),
			new CqlCode("966793", "http://www.nlm.nih.gov/research/umls/rxnorm", default, default),
			new CqlCode("1000048", "http://www.nlm.nih.gov/research/umls/rxnorm", default, default),
			new CqlCode("1000054", "http://www.nlm.nih.gov/research/umls/rxnorm", default, default),
			new CqlCode("1000058", "http://www.nlm.nih.gov/research/umls/rxnorm", default, default),
			new CqlCode("1000064", "http://www.nlm.nih.gov/research/umls/rxnorm", default, default),
			new CqlCode("1000070", "http://www.nlm.nih.gov/research/umls/rxnorm", default, default),
			new CqlCode("1000076", "http://www.nlm.nih.gov/research/umls/rxnorm", default, default),
			new CqlCode("1000097", "http://www.nlm.nih.gov/research/umls/rxnorm", default, default),
			new CqlCode("198196", "http://www.nlm.nih.gov/research/umls/rxnorm", default, default),
			new CqlCode("198197", "http://www.nlm.nih.gov/research/umls/rxnorm", default, default),
		];

		return a_;
	}


    [CqlDeclaration("CPT")]
	public CqlCode[] CPT(CqlContext context)
	{
		CqlCode[] a_ = [
			new CqlCode("99211", "http://www.ama-assn.org/go/cpt", default, default),
		];

		return a_;
	}


    [CqlDeclaration("Measurement Period")]
	public CqlInterval<CqlDateTime> Measurement_Period(CqlContext context)
	{
		CqlDateTime a_ = context.Operators.DateTime(2025, 1, 1, 0, 0, 0, 0, default);
		CqlDateTime b_ = context.Operators.DateTime(2026, 1, 1, 0, 0, 0, 0, default);
		CqlInterval<CqlDateTime> c_ = context.Operators.Interval(a_, b_, true, false);
		object d_ = context.ResolveParameter("UseofHighRiskMedicationsintheElderlyFHIR-0.1.000", "Measurement Period", c_);

		return (CqlInterval<CqlDateTime>)d_;
	}


    [CqlDeclaration("Patient")]
	public Patient Patient(CqlContext context)
	{
		IEnumerable<Patient> a_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-patient"));
		Patient b_ = context.Operators.SingletonFrom<Patient>(a_);

		return b_;
	}


    [CqlDeclaration("Qualifying Encounters")]
	public IEnumerable<Encounter> Qualifying_Encounters(CqlContext context)
	{
		CqlValueSet a_ = this.Office_Visit(context);
		IEnumerable<Encounter> b_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
		CqlValueSet c_ = this.Ophthalmologic_Services(context);
		IEnumerable<Encounter> d_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, c_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
		IEnumerable<Encounter> e_ = context.Operators.Union<Encounter>(b_, d_);
		CqlValueSet f_ = this.Preventive_Care_Services_Established_Office_Visit__18_and_Up(context);
		IEnumerable<Encounter> g_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, f_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
		CqlValueSet h_ = this.Discharge_Services_Nursing_Facility(context);
		IEnumerable<Encounter> i_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, h_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
		IEnumerable<Encounter> j_ = context.Operators.Union<Encounter>(g_, i_);
		IEnumerable<Encounter> k_ = context.Operators.Union<Encounter>(e_, j_);
		CqlValueSet l_ = this.Nursing_Facility_Visit(context);
		IEnumerable<Encounter> m_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, l_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
		CqlValueSet n_ = this.Care_Services_in_Long_Term_Residential_Facility(context);
		IEnumerable<Encounter> o_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, n_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
		IEnumerable<Encounter> p_ = context.Operators.Union<Encounter>(m_, o_);
		IEnumerable<Encounter> q_ = context.Operators.Union<Encounter>(k_, p_);
		CqlValueSet r_ = this.Preventive_Care_Services_Initial_Office_Visit__18_and_Up(context);
		IEnumerable<Encounter> s_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, r_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
		CqlValueSet t_ = this.Annual_Wellness_Visit(context);
		IEnumerable<Encounter> u_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, t_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
		IEnumerable<Encounter> v_ = context.Operators.Union<Encounter>(s_, u_);
		IEnumerable<Encounter> w_ = context.Operators.Union<Encounter>(q_, v_);
		CqlValueSet x_ = this.Home_Healthcare_Services(context);
		IEnumerable<Encounter> y_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, x_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
		CqlValueSet z_ = this.Telephone_Visits(context);
		IEnumerable<Encounter> aa_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, z_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
		IEnumerable<Encounter> ab_ = context.Operators.Union<Encounter>(y_, aa_);
		IEnumerable<Encounter> ac_ = context.Operators.Union<Encounter>(w_, ab_);
		CqlValueSet ad_ = this.Online_Assessments(context);
		IEnumerable<Encounter> ae_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, ad_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
		IEnumerable<Encounter> af_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
		bool? ag_(Encounter E)
		{
			List<CodeableConcept> am_ = E?.Type;
			CqlConcept an_(CodeableConcept @this)
			{
				CqlConcept as_ = FHIRHelpers_4_3_000.Instance.ToConcept(context, @this);

				return as_;
			};
			IEnumerable<CqlConcept> ao_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)am_, an_);
			bool? ap_(CqlConcept T)
			{
				CqlCode at_ = this.Office_or_other_outpatient_visit_for_the_evaluation_and_management_of_an_established_patient__that_may_not_require_the_presence_of_a_physician_or_other_qualified_health_care_professional__Usually__the_presenting_problem_s__are_minimal_(context);
				CqlConcept au_ = context.Operators.ConvertCodeToConcept(at_);
				bool? av_ = context.Operators.Equivalent(T, au_);

				return av_;
			};
			IEnumerable<CqlConcept> aq_ = context.Operators.Where<CqlConcept>(ao_, ap_);
			bool? ar_ = context.Operators.Exists<CqlConcept>(aq_);

			return ar_;
		};
		IEnumerable<Encounter> ah_ = context.Operators.Where<Encounter>(af_, ag_);
		IEnumerable<Encounter> ai_ = context.Operators.Union<Encounter>(ae_, ah_);
		IEnumerable<Encounter> aj_ = context.Operators.Union<Encounter>(ac_, ai_);
		bool? ak_(Encounter ValidEncounters)
		{
			CqlInterval<CqlDateTime> aw_ = this.Measurement_Period(context);
			Period ax_ = ValidEncounters?.Period;
			CqlInterval<CqlDateTime> ay_ = FHIRHelpers_4_3_000.Instance.ToInterval(context, ax_);
			bool? az_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(aw_, ay_, default);

			return az_;
		};
		IEnumerable<Encounter> al_ = context.Operators.Where<Encounter>(aj_, ak_);

		return al_;
	}


    [CqlDeclaration("Initial Population")]
	public bool? Initial_Population(CqlContext context)
	{
		Patient a_ = this.Patient(context);
		Date b_ = a_?.BirthDateElement;
		string c_ = b_?.Value;
		CqlDate d_ = context.Operators.ConvertStringToDate(c_);
		CqlInterval<CqlDateTime> e_ = this.Measurement_Period(context);
		CqlDateTime f_ = context.Operators.End(e_);
		CqlDate g_ = context.Operators.DateFrom(f_);
		int? h_ = context.Operators.CalculateAgeAt(d_, g_, "year");
		bool? i_ = context.Operators.GreaterOrEqual(h_, 65);
		IEnumerable<Encounter> j_ = this.Qualifying_Encounters(context);
		bool? k_ = context.Operators.Exists<Encounter>(j_);
		bool? l_ = context.Operators.And(i_, k_);

		return l_;
	}


    [CqlDeclaration("Denominator")]
	public bool? Denominator(CqlContext context)
	{
		bool? a_ = this.Initial_Population(context);

		return a_;
	}


    [CqlDeclaration("Denominator Exclusions")]
	public bool? Denominator_Exclusions(CqlContext context)
	{
		bool? a_ = Hospice_6_9_000.Instance.Has_Hospice_Services(context);
		bool? b_ = PalliativeCare_1_9_000.Instance.Has_Palliative_Care_in_the_Measurement_Period(context);
		bool? c_ = context.Operators.Or(a_, b_);

		return c_;
	}

	public IEnumerable<MedicationRequest> More_Than_One_Order(CqlContext context, IEnumerable<MedicationRequest> Medication)
	{
		IEnumerable<MedicationRequest> a_ = Status_1_6_000.Instance.Active_or_Completed_Medication_Request(context, Medication);
		IEnumerable<MedicationRequest> b_(MedicationRequest OrderMedication1)
		{
			IEnumerable<MedicationRequest> f_ = Status_1_6_000.Instance.Active_or_Completed_Medication_Request(context, Medication);
			bool? g_(MedicationRequest OrderMedication2)
			{
				FhirDateTime k_ = OrderMedication1?.AuthoredOnElement;
				CqlDateTime l_ = context.Operators.Convert<CqlDateTime>(k_);
				CqlInterval<CqlDateTime> m_ = this.Measurement_Period(context);
				bool? n_ = context.Operators.In<CqlDateTime>(l_, m_, default);
				MedicationRequest.DispenseRequestComponent o_ = OrderMedication1?.DispenseRequest;
				UnsignedInt p_ = o_?.NumberOfRepeatsAllowedElement;
				int? q_ = p_?.Value;
				bool? r_ = context.Operators.GreaterOrEqual(q_, 1);
				bool? s_ = context.Operators.And(n_, r_);
				CqlDateTime u_ = context.Operators.Convert<CqlDateTime>(k_);
				CqlDate v_ = context.Operators.DateFrom(u_);
				FhirDateTime w_ = OrderMedication2?.AuthoredOnElement;
				CqlDateTime x_ = context.Operators.Convert<CqlDateTime>(w_);
				CqlDate y_ = context.Operators.DateFrom(x_);
				bool? z_ = context.Operators.Equivalent(v_, y_);
				bool? aa_ = context.Operators.Not(z_);
				CqlDateTime ac_ = context.Operators.Convert<CqlDateTime>(k_);
				bool? ae_ = context.Operators.In<CqlDateTime>(ac_, m_, default);
				bool? af_ = context.Operators.And(aa_, ae_);
				CqlDateTime ah_ = context.Operators.Convert<CqlDateTime>(w_);
				bool? aj_ = context.Operators.In<CqlDateTime>(ah_, m_, default);
				bool? ak_ = context.Operators.And(af_, aj_);
				bool? al_ = context.Operators.Or(s_, ak_);
				CqlDateTime an_ = context.Operators.Convert<CqlDateTime>(k_);
				CqlDate ao_ = context.Operators.DateFrom(an_);
				CqlDateTime aq_ = context.Operators.Convert<CqlDateTime>(w_);
				CqlDate ar_ = context.Operators.DateFrom(aq_);
				bool? as_ = context.Operators.Equivalent(ao_, ar_);
				CqlDateTime au_ = context.Operators.Convert<CqlDateTime>(k_);
				bool? aw_ = context.Operators.In<CqlDateTime>(au_, m_, default);
				bool? ax_ = context.Operators.And(as_, aw_);
				CqlInterval<CqlDate> ay_ = CumulativeMedicationDuration_4_0_000.Instance.MedicationRequestPeriod(context, OrderMedication1);
				CqlDate az_ = context.Operators.Start(ay_);
				CqlDateTime ba_ = context.Operators.ConvertDateToDateTime(az_);
				CqlDate bb_ = context.Operators.DateFrom(ba_);
				CqlInterval<CqlDate> bc_ = CumulativeMedicationDuration_4_0_000.Instance.MedicationRequestPeriod(context, OrderMedication2);
				CqlDate bd_ = context.Operators.Start(bc_);
				CqlDateTime be_ = context.Operators.ConvertDateToDateTime(bd_);
				CqlDate bf_ = context.Operators.DateFrom(be_);
				bool? bg_ = context.Operators.Equivalent(bb_, bf_);
				bool? bh_ = context.Operators.Not(bg_);
				bool? bi_ = context.Operators.And(ax_, bh_);
				CqlDate bk_ = context.Operators.Start(ay_);
				CqlDateTime bl_ = context.Operators.ConvertDateToDateTime(bk_);
				bool? bn_ = context.Operators.In<CqlDateTime>(bl_, m_, default);
				bool? bo_ = context.Operators.And(bi_, bn_);
				CqlDate bq_ = context.Operators.Start(bc_);
				CqlDateTime br_ = context.Operators.ConvertDateToDateTime(bq_);
				bool? bt_ = context.Operators.In<CqlDateTime>(br_, m_, default);
				bool? bu_ = context.Operators.And(bo_, bt_);
				bool? bv_ = context.Operators.Or(al_, bu_);

				return bv_;
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


    [CqlDeclaration("Same High Risk Medications Ordered on Different Days")]
	public IEnumerable<MedicationRequest> Same_High_Risk_Medications_Ordered_on_Different_Days(CqlContext context)
	{
		CqlValueSet a_ = this.Anticholinergics__first_generation_antihistamines(context);
		IEnumerable<MedicationRequest> b_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
		IEnumerable<MedicationRequest> d_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
		IEnumerable<MedicationRequest> e_ = context.Operators.Union<MedicationRequest>(b_, d_);
		IEnumerable<MedicationRequest> f_ = this.More_Than_One_Order(context, e_);
		CqlValueSet g_ = this.Anticholinergics__anti_Parkinson_agents(context);
		IEnumerable<MedicationRequest> h_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, g_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
		IEnumerable<MedicationRequest> j_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, g_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
		IEnumerable<MedicationRequest> k_ = context.Operators.Union<MedicationRequest>(h_, j_);
		IEnumerable<MedicationRequest> l_ = this.More_Than_One_Order(context, k_);
		IEnumerable<MedicationRequest> m_ = context.Operators.Union<MedicationRequest>(f_, l_);
		CqlValueSet n_ = this.Antispasmodics(context);
		IEnumerable<MedicationRequest> o_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, n_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
		IEnumerable<MedicationRequest> q_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, n_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
		IEnumerable<MedicationRequest> r_ = context.Operators.Union<MedicationRequest>(o_, q_);
		IEnumerable<MedicationRequest> s_ = this.More_Than_One_Order(context, r_);
		CqlValueSet t_ = this.Antithrombotic(context);
		IEnumerable<MedicationRequest> u_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, t_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
		IEnumerable<MedicationRequest> w_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, t_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
		IEnumerable<MedicationRequest> x_ = context.Operators.Union<MedicationRequest>(u_, w_);
		IEnumerable<MedicationRequest> y_ = this.More_Than_One_Order(context, x_);
		IEnumerable<MedicationRequest> z_ = context.Operators.Union<MedicationRequest>(s_, y_);
		IEnumerable<MedicationRequest> aa_ = context.Operators.Union<MedicationRequest>(m_, z_);
		CqlValueSet ab_ = this.Cardiovascular__alpha_agonists__central(context);
		IEnumerable<MedicationRequest> ac_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, ab_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
		IEnumerable<MedicationRequest> ae_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, ab_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
		IEnumerable<MedicationRequest> af_ = context.Operators.Union<MedicationRequest>(ac_, ae_);
		IEnumerable<MedicationRequest> ag_ = this.More_Than_One_Order(context, af_);
		CqlValueSet ah_ = this.Cardiovascular__other(context);
		IEnumerable<MedicationRequest> ai_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, ah_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
		IEnumerable<MedicationRequest> ak_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, ah_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
		IEnumerable<MedicationRequest> al_ = context.Operators.Union<MedicationRequest>(ai_, ak_);
		IEnumerable<MedicationRequest> am_ = this.More_Than_One_Order(context, al_);
		IEnumerable<MedicationRequest> an_ = context.Operators.Union<MedicationRequest>(ag_, am_);
		IEnumerable<MedicationRequest> ao_ = context.Operators.Union<MedicationRequest>(aa_, an_);
		CqlValueSet ap_ = this.Central_nervous_system__antidepressants(context);
		IEnumerable<MedicationRequest> aq_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, ap_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
		IEnumerable<MedicationRequest> as_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, ap_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
		IEnumerable<MedicationRequest> at_ = context.Operators.Union<MedicationRequest>(aq_, as_);
		IEnumerable<MedicationRequest> au_ = this.More_Than_One_Order(context, at_);
		CqlValueSet av_ = this.Central_nervous_system__barbiturates(context);
		IEnumerable<MedicationRequest> aw_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, av_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
		IEnumerable<MedicationRequest> ay_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, av_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
		IEnumerable<MedicationRequest> az_ = context.Operators.Union<MedicationRequest>(aw_, ay_);
		IEnumerable<MedicationRequest> ba_ = this.More_Than_One_Order(context, az_);
		IEnumerable<MedicationRequest> bb_ = context.Operators.Union<MedicationRequest>(au_, ba_);
		IEnumerable<MedicationRequest> bc_ = context.Operators.Union<MedicationRequest>(ao_, bb_);
		CqlValueSet bd_ = this.Central_nervous_system__vasodilators(context);
		IEnumerable<MedicationRequest> be_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, bd_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
		IEnumerable<MedicationRequest> bg_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, bd_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
		IEnumerable<MedicationRequest> bh_ = context.Operators.Union<MedicationRequest>(be_, bg_);
		IEnumerable<MedicationRequest> bi_ = this.More_Than_One_Order(context, bh_);
		CqlValueSet bj_ = this.Central_nervous_system__other(context);
		IEnumerable<MedicationRequest> bk_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, bj_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
		IEnumerable<MedicationRequest> bm_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, bj_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
		IEnumerable<MedicationRequest> bn_ = context.Operators.Union<MedicationRequest>(bk_, bm_);
		IEnumerable<MedicationRequest> bo_ = this.More_Than_One_Order(context, bn_);
		IEnumerable<MedicationRequest> bp_ = context.Operators.Union<MedicationRequest>(bi_, bo_);
		IEnumerable<MedicationRequest> bq_ = context.Operators.Union<MedicationRequest>(bc_, bp_);
		CqlValueSet br_ = this.Endocrine_system__estrogens_with_or_without_progestins(context);
		IEnumerable<MedicationRequest> bs_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, br_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
		IEnumerable<MedicationRequest> bu_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, br_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
		IEnumerable<MedicationRequest> bv_ = context.Operators.Union<MedicationRequest>(bs_, bu_);
		IEnumerable<MedicationRequest> bw_ = this.More_Than_One_Order(context, bv_);
		CqlValueSet bx_ = this.Endocrine_system__sulfonylureas__long_duration(context);
		IEnumerable<MedicationRequest> by_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, bx_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
		IEnumerable<MedicationRequest> ca_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, bx_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
		IEnumerable<MedicationRequest> cb_ = context.Operators.Union<MedicationRequest>(by_, ca_);
		IEnumerable<MedicationRequest> cc_ = this.More_Than_One_Order(context, cb_);
		IEnumerable<MedicationRequest> cd_ = context.Operators.Union<MedicationRequest>(bw_, cc_);
		IEnumerable<MedicationRequest> ce_ = context.Operators.Union<MedicationRequest>(bq_, cd_);
		CqlValueSet cf_ = this.Endocrine_system__other(context);
		IEnumerable<MedicationRequest> cg_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, cf_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
		IEnumerable<MedicationRequest> ci_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, cf_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
		IEnumerable<MedicationRequest> cj_ = context.Operators.Union<MedicationRequest>(cg_, ci_);
		IEnumerable<MedicationRequest> ck_ = this.More_Than_One_Order(context, cj_);
		CqlValueSet cl_ = this.Nonbenzodiazepine_hypnotics(context);
		IEnumerable<MedicationRequest> cm_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, cl_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
		IEnumerable<MedicationRequest> co_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, cl_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
		IEnumerable<MedicationRequest> cp_ = context.Operators.Union<MedicationRequest>(cm_, co_);
		IEnumerable<MedicationRequest> cq_ = this.More_Than_One_Order(context, cp_);
		IEnumerable<MedicationRequest> cr_ = context.Operators.Union<MedicationRequest>(ck_, cq_);
		IEnumerable<MedicationRequest> cs_ = context.Operators.Union<MedicationRequest>(ce_, cr_);
		CqlValueSet ct_ = this.Pain_medications__skeletal_muscle_relaxants(context);
		IEnumerable<MedicationRequest> cu_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, ct_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
		IEnumerable<MedicationRequest> cw_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, ct_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
		IEnumerable<MedicationRequest> cx_ = context.Operators.Union<MedicationRequest>(cu_, cw_);
		IEnumerable<MedicationRequest> cy_ = this.More_Than_One_Order(context, cx_);
		CqlValueSet cz_ = this.Pain_medications__other(context);
		IEnumerable<MedicationRequest> da_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, cz_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
		IEnumerable<MedicationRequest> dc_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, cz_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
		IEnumerable<MedicationRequest> dd_ = context.Operators.Union<MedicationRequest>(da_, dc_);
		IEnumerable<MedicationRequest> de_ = this.More_Than_One_Order(context, dd_);
		IEnumerable<MedicationRequest> df_ = context.Operators.Union<MedicationRequest>(cy_, de_);
		IEnumerable<MedicationRequest> dg_ = context.Operators.Union<MedicationRequest>(cs_, df_);

		return dg_;
	}

	public decimal? MedicationRequestPeriodInDays(CqlContext context, MedicationRequest Request)
	{
		MedicationRequest[] a_ = [
			Request,
		];
		decimal? b_(MedicationRequest R)
		{
			MedicationRequest.DispenseRequestComponent e_ = R?.DispenseRequest;
			Duration f_ = e_?.ExpectedSupplyDuration;
			CqlQuantity g_ = FHIRHelpers_4_3_000.Instance.ToQuantity(context, f_);
			CqlQuantity h_ = context.Operators.ConvertQuantity(g_, "d");
			decimal? i_ = h_?.value;
			Quantity k_ = e_?.Quantity;
			CqlQuantity l_ = FHIRHelpers_4_3_000.Instance.ToQuantity(context, k_);
			decimal? m_ = l_?.value;
			List<Dosage> n_ = R?.DosageInstruction;
			Dosage o_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)n_);
			List<Dosage.DoseAndRateComponent> p_ = o_?.DoseAndRate;
			Dosage.DoseAndRateComponent q_ = context.Operators.SingletonFrom<Dosage.DoseAndRateComponent>((IEnumerable<Dosage.DoseAndRateComponent>)p_);
			DataType r_ = q_?.Dose;
			object s_ = FHIRHelpers_4_3_000.Instance.ToValue(context, r_);
			CqlQuantity t_ = context.Operators.End(s_ as CqlInterval<CqlQuantity>);
			Dosage v_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)n_);
			List<Dosage.DoseAndRateComponent> w_ = v_?.DoseAndRate;
			Dosage.DoseAndRateComponent x_ = context.Operators.SingletonFrom<Dosage.DoseAndRateComponent>((IEnumerable<Dosage.DoseAndRateComponent>)w_);
			DataType y_ = x_?.Dose;
			object z_ = FHIRHelpers_4_3_000.Instance.ToValue(context, y_);
			decimal? aa_ = (t_ ?? z_ as CqlQuantity)?.value;
			Dosage ac_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)n_);
			Timing ad_ = ac_?.Timing;
			Timing.RepeatComponent ae_ = ad_?.Repeat;
			PositiveInt af_ = ae_?.FrequencyMaxElement;
			int? ag_ = af_?.Value;
			Dosage ai_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)n_);
			Timing aj_ = ai_?.Timing;
			Timing.RepeatComponent ak_ = aj_?.Repeat;
			PositiveInt al_ = ak_?.FrequencyElement;
			int? am_ = al_?.Value;
			Dosage ao_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)n_);
			Timing ap_ = ao_?.Timing;
			Timing.RepeatComponent aq_ = ap_?.Repeat;
			FhirDecimal ar_ = aq_?.PeriodElement;
			decimal? as_ = ar_?.Value;
			Dosage au_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)n_);
			Timing av_ = au_?.Timing;
			Timing.RepeatComponent aw_ = av_?.Repeat;
			Code<Timing.UnitsOfTime> ax_ = aw_?.PeriodUnitElement;
			Timing.UnitsOfTime? ay_ = ax_?.Value;
			string az_ = context.Operators.Convert<string>(ay_);
			CqlQuantity ba_ = CumulativeMedicationDuration_4_0_000.Instance.Quantity(context, as_, az_);
			decimal? bb_ = CumulativeMedicationDuration_4_0_000.Instance.ToDaily(context, ag_ ?? am_, ba_);
			Dosage bd_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)n_);
			Timing be_ = bd_?.Timing;
			Timing.RepeatComponent bf_ = be_?.Repeat;
			List<Time> bg_ = bf_?.TimeOfDayElement;
			IEnumerable<CqlTime> bh_ = context.Operators.LateBoundProperty<IEnumerable<CqlTime>>(bg_, "value");
			int? bi_ = context.Operators.Count<CqlTime>(bh_);
			decimal? bj_ = context.Operators.ConvertIntegerToDecimal(bi_);
			decimal? bk_ = context.Operators.Multiply(aa_, (bb_ ?? bj_) ?? 1.0m);
			decimal? bl_ = context.Operators.Divide(m_, bk_);
			UnsignedInt bn_ = e_?.NumberOfRepeatsAllowedElement;
			int? bo_ = bn_?.Value;
			int? bp_ = context.Operators.Add(1, bo_ ?? 0);
			decimal? bq_ = context.Operators.ConvertIntegerToDecimal(bp_);
			decimal? br_ = context.Operators.Multiply(i_ ?? bl_, bq_);

			return br_;
		};
		IEnumerable<decimal?> c_ = context.Operators.Select<MedicationRequest, decimal?>((IEnumerable<MedicationRequest>)a_, b_);
		decimal? d_ = context.Operators.SingletonFrom<decimal?>(c_);

		return d_;
	}


    [CqlDeclaration("Two High Risk Medications with Prolonged Duration")]
	public bool? Two_High_Risk_Medications_with_Prolonged_Duration(CqlContext context)
	{
		CqlValueSet a_ = this.Anti_Infectives__other(context);
		IEnumerable<MedicationRequest> b_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
		IEnumerable<MedicationRequest> d_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
		IEnumerable<MedicationRequest> e_ = context.Operators.Union<MedicationRequest>(b_, d_);
		IEnumerable<MedicationRequest> f_ = this.More_Than_One_Order(context, e_);
		decimal? g_(MedicationRequest AntiInfectives)
		{
			decimal? l_ = this.MedicationRequestPeriodInDays(context, AntiInfectives);

			return l_;
		};
		IEnumerable<decimal?> h_ = context.Operators.Select<MedicationRequest, decimal?>(f_, g_);
		decimal? i_ = context.Operators.Sum(h_);
		decimal? j_ = context.Operators.ConvertIntegerToDecimal(90);
		bool? k_ = context.Operators.Greater(i_, j_);

		return k_;
	}

	public CqlQuantity MedicationStrengthPerUnit(CqlContext context, CqlConcept Strength)
	{
		CqlQuantity a_()
		{
			bool b_()
			{
				CqlCode t_ = this.reserpine_0_1_MG_Oral_Tablet(context);
				CqlConcept u_ = context.Operators.ConvertCodeToConcept(t_);
				bool? v_ = context.Operators.Equivalent(Strength, u_);

				return v_ ?? false;
			};
			bool c_()
			{
				CqlCode w_ = this.reserpine_0_25_MG_Oral_Tablet(context);
				CqlConcept x_ = context.Operators.ConvertCodeToConcept(w_);
				bool? y_ = context.Operators.Equivalent(Strength, x_);

				return y_ ?? false;
			};
			bool d_()
			{
				CqlCode z_ = this.digoxin_0_05_MG_ML_Oral_Solution(context);
				CqlConcept aa_ = context.Operators.ConvertCodeToConcept(z_);
				bool? ab_ = context.Operators.Equivalent(Strength, aa_);

				return ab_ ?? false;
			};
			bool e_()
			{
				CqlCode ac_ = this.digoxin_0_0625_MG_Oral_Tablet(context);
				CqlConcept ad_ = context.Operators.ConvertCodeToConcept(ac_);
				bool? ae_ = context.Operators.Equivalent(Strength, ad_);

				return ae_ ?? false;
			};
			bool f_()
			{
				CqlCode af_ = this._1_ML_digoxin_0_1_MG_ML_Injection(context);
				CqlConcept ag_ = context.Operators.ConvertCodeToConcept(af_);
				bool? ah_ = context.Operators.Equivalent(Strength, ag_);

				return ah_ ?? false;
			};
			bool g_()
			{
				CqlCode ai_ = this.digoxin_0_125_MG_Oral_Tablet(context);
				CqlConcept aj_ = context.Operators.ConvertCodeToConcept(ai_);
				bool? ak_ = context.Operators.Equivalent(Strength, aj_);

				return ak_ ?? false;
			};
			bool h_()
			{
				CqlCode al_ = this.digoxin_0_1875_MG_Oral_Tablet(context);
				CqlConcept am_ = context.Operators.ConvertCodeToConcept(al_);
				bool? an_ = context.Operators.Equivalent(Strength, am_);

				return an_ ?? false;
			};
			bool i_()
			{
				CqlCode ao_ = this.digoxin_0_25_MG_Oral_Tablet(context);
				CqlConcept ap_ = context.Operators.ConvertCodeToConcept(ao_);
				bool? aq_ = context.Operators.Equivalent(Strength, ap_);

				return aq_ ?? false;
			};
			bool j_()
			{
				CqlCode ar_ = this._2_ML_digoxin_0_25_MG_ML_Injection(context);
				CqlConcept as_ = context.Operators.ConvertCodeToConcept(ar_);
				bool? at_ = context.Operators.Equivalent(Strength, as_);

				return at_ ?? false;
			};
			bool k_()
			{
				CqlCode au_ = this.doxepin_3_MG_Oral_Tablet(context);
				CqlConcept av_ = context.Operators.ConvertCodeToConcept(au_);
				bool? aw_ = context.Operators.Equivalent(Strength, av_);

				return aw_ ?? false;
			};
			bool l_()
			{
				CqlCode ax_ = this.doxepin_6_MG_Oral_Tablet(context);
				CqlConcept ay_ = context.Operators.ConvertCodeToConcept(ax_);
				bool? az_ = context.Operators.Equivalent(Strength, ay_);

				return az_ ?? false;
			};
			bool m_()
			{
				CqlCode ba_ = this.doxepin_hydrochloride_10_MG_Oral_Capsule(context);
				CqlConcept bb_ = context.Operators.ConvertCodeToConcept(ba_);
				bool? bc_ = context.Operators.Equivalent(Strength, bb_);

				return bc_ ?? false;
			};
			bool n_()
			{
				CqlCode bd_ = this.doxepin_hydrochloride_10_MG_ML_Oral_Solution(context);
				CqlConcept be_ = context.Operators.ConvertCodeToConcept(bd_);
				bool? bf_ = context.Operators.Equivalent(Strength, be_);

				return bf_ ?? false;
			};
			bool o_()
			{
				CqlCode bg_ = this.doxepin_hydrochloride_25_MG_Oral_Capsule(context);
				CqlConcept bh_ = context.Operators.ConvertCodeToConcept(bg_);
				bool? bi_ = context.Operators.Equivalent(Strength, bh_);

				return bi_ ?? false;
			};
			bool p_()
			{
				CqlCode bj_ = this.doxepin_hydrochloride_50_MG_Oral_Capsule(context);
				CqlConcept bk_ = context.Operators.ConvertCodeToConcept(bj_);
				bool? bl_ = context.Operators.Equivalent(Strength, bk_);

				return bl_ ?? false;
			};
			bool q_()
			{
				CqlCode bm_ = this.doxepin_hydrochloride_75_MG_Oral_Capsule(context);
				CqlConcept bn_ = context.Operators.ConvertCodeToConcept(bm_);
				bool? bo_ = context.Operators.Equivalent(Strength, bn_);

				return bo_ ?? false;
			};
			bool r_()
			{
				CqlCode bp_ = this.doxepin_hydrochloride_100_MG_Oral_Capsule(context);
				CqlConcept bq_ = context.Operators.ConvertCodeToConcept(bp_);
				bool? br_ = context.Operators.Equivalent(Strength, bq_);

				return br_ ?? false;
			};
			bool s_()
			{
				CqlCode bs_ = this.doxepin_hydrochloride_150_MG_Oral_Capsule(context);
				CqlConcept bt_ = context.Operators.ConvertCodeToConcept(bs_);
				bool? bu_ = context.Operators.Equivalent(Strength, bt_);

				return bu_ ?? false;
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
				return default;
			}
		};

		return a_();
	}

	public CqlQuantity Average_Daily_Dose(CqlContext context, MedicationRequest MedicationRequest)
	{
		MedicationRequest[] a_ = [
			MedicationRequest,
		];
		CqlQuantity b_(MedicationRequest Order)
		{
			CqlQuantity e_()
			{
				bool f_()
				{
					decimal? g_ = this.MedicationRequestPeriodInDays(context, Order);
					bool? h_ = context.Operators.Not((bool?)(g_ is null));
					CqlConcept i_ = CQMCommon_2_0_000.Instance.getMedicationCode(context, Order);
					CqlQuantity j_ = this.MedicationStrengthPerUnit(context, i_);
					string k_ = j_?.unit;
					bool? l_ = context.Operators.Equal(k_, "mg");
					CqlQuantity n_ = this.MedicationStrengthPerUnit(context, i_);
					string o_ = n_?.unit;
					bool? p_ = context.Operators.Equal(o_, "mg/mL");
					MedicationRequest.DispenseRequestComponent q_ = Order?.DispenseRequest;
					Quantity r_ = q_?.Quantity;
					CqlQuantity s_ = FHIRHelpers_4_3_000.Instance.ToQuantity(context, r_);
					string t_ = s_?.unit;
					bool? u_ = context.Operators.Equal(t_, "mL");
					bool? v_ = context.Operators.And(p_, u_);
					bool? w_ = context.Operators.Or(l_, v_);
					bool? x_ = context.Operators.And(h_, w_);

					return x_ ?? false;
				};
				if (f_())
				{
					MedicationRequest.DispenseRequestComponent y_ = Order?.DispenseRequest;
					Quantity z_ = y_?.Quantity;
					CqlQuantity aa_ = FHIRHelpers_4_3_000.Instance.ToQuantity(context, z_);
					CqlConcept ab_ = CQMCommon_2_0_000.Instance.getMedicationCode(context, Order);
					CqlQuantity ac_ = this.MedicationStrengthPerUnit(context, ab_);
					CqlQuantity ad_ = context.Operators.Multiply(aa_, ac_);
					decimal? ae_ = this.MedicationRequestPeriodInDays(context, Order);
					CqlQuantity af_ = context.Operators.Divide(ad_, new CqlQuantity(ae_, "d"));

					return af_;
				}
				else
				{
					return default;
				}
			};

			return e_();
		};
		IEnumerable<CqlQuantity> c_ = context.Operators.Select<MedicationRequest, CqlQuantity>((IEnumerable<MedicationRequest>)a_, b_);
		CqlQuantity d_ = context.Operators.SingletonFrom<CqlQuantity>(c_);

		return d_;
	}


    [CqlDeclaration("High Risk Medications with Average Daily Dose Criteria")]
	public bool? High_Risk_Medications_with_Average_Daily_Dose_Criteria(CqlContext context)
	{
		CqlValueSet a_ = this.Reserpine(context);
		IEnumerable<MedicationRequest> b_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
		IEnumerable<MedicationRequest> d_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
		IEnumerable<MedicationRequest> e_ = context.Operators.Union<MedicationRequest>(b_, d_);
		bool? f_(MedicationRequest ReserpineOrdered)
		{
			CqlQuantity ad_ = this.Average_Daily_Dose(context, ReserpineOrdered);
			CqlQuantity ae_ = context.Operators.Quantity(0.1m, "mg/d");
			bool? af_ = context.Operators.Greater(ad_, ae_);

			return af_;
		};
		IEnumerable<MedicationRequest> g_ = context.Operators.Where<MedicationRequest>(e_, f_);
		IEnumerable<MedicationRequest> h_ = this.More_Than_One_Order(context, g_);
		bool? i_ = context.Operators.Exists<MedicationRequest>(h_);
		CqlValueSet j_ = this.Digoxin(context);
		IEnumerable<MedicationRequest> k_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, j_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
		IEnumerable<MedicationRequest> m_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, j_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
		IEnumerable<MedicationRequest> n_ = context.Operators.Union<MedicationRequest>(k_, m_);
		bool? o_(MedicationRequest DigoxinOrdered)
		{
			CqlQuantity ag_ = this.Average_Daily_Dose(context, DigoxinOrdered);
			CqlQuantity ah_ = context.Operators.Quantity(0.125m, "mg/d");
			bool? ai_ = context.Operators.Greater(ag_, ah_);

			return ai_;
		};
		IEnumerable<MedicationRequest> p_ = context.Operators.Where<MedicationRequest>(n_, o_);
		IEnumerable<MedicationRequest> q_ = this.More_Than_One_Order(context, p_);
		bool? r_ = context.Operators.Exists<MedicationRequest>(q_);
		bool? s_ = context.Operators.Or(i_, r_);
		CqlValueSet t_ = this.Doxepin(context);
		IEnumerable<MedicationRequest> u_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, t_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
		IEnumerable<MedicationRequest> w_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, t_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
		IEnumerable<MedicationRequest> x_ = context.Operators.Union<MedicationRequest>(u_, w_);
		bool? y_(MedicationRequest DoxepinOrdered)
		{
			CqlQuantity aj_ = this.Average_Daily_Dose(context, DoxepinOrdered);
			CqlQuantity ak_ = context.Operators.Quantity(6m, "mg/d");
			bool? al_ = context.Operators.Greater(aj_, ak_);

			return al_;
		};
		IEnumerable<MedicationRequest> z_ = context.Operators.Where<MedicationRequest>(x_, y_);
		IEnumerable<MedicationRequest> aa_ = this.More_Than_One_Order(context, z_);
		bool? ab_ = context.Operators.Exists<MedicationRequest>(aa_);
		bool? ac_ = context.Operators.Or(s_, ab_);

		return ac_;
	}


    [CqlDeclaration("Numerator 1")]
	public bool? Numerator_1(CqlContext context)
	{
		IEnumerable<MedicationRequest> a_ = this.Same_High_Risk_Medications_Ordered_on_Different_Days(context);
		bool? b_ = context.Operators.Exists<MedicationRequest>(a_);
		bool? c_ = this.Two_High_Risk_Medications_with_Prolonged_Duration(context);
		bool? d_ = context.Operators.Or(b_, c_);
		bool? e_ = this.High_Risk_Medications_with_Average_Daily_Dose_Criteria(context);
		bool? f_ = context.Operators.Or(d_, e_);

		return f_;
	}


    [CqlDeclaration("More than One Antipsychotic Order")]
	public bool? More_than_One_Antipsychotic_Order(CqlContext context)
	{
		CqlValueSet a_ = this.Antipsychotic(context);
		IEnumerable<MedicationRequest> b_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
		IEnumerable<MedicationRequest> d_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
		IEnumerable<MedicationRequest> e_ = context.Operators.Union<MedicationRequest>(b_, d_);
		IEnumerable<MedicationRequest> f_ = this.More_Than_One_Order(context, e_);
		bool? g_ = context.Operators.Exists<MedicationRequest>(f_);

		return g_;
	}


    [CqlDeclaration("Antipsychotic Index Prescription Start Date")]
	public CqlDateTime Antipsychotic_Index_Prescription_Start_Date(CqlContext context)
	{
		CqlValueSet a_ = this.Antipsychotic(context);
		IEnumerable<MedicationRequest> b_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
		IEnumerable<MedicationRequest> d_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
		IEnumerable<MedicationRequest> e_ = context.Operators.Union<MedicationRequest>(b_, d_);
		IEnumerable<MedicationRequest> f_ = Status_1_6_000.Instance.Active_or_Completed_Medication_Request(context, e_);
		bool? g_(MedicationRequest AntipsychoticMedication)
		{
			FhirDateTime m_ = AntipsychoticMedication?.AuthoredOnElement;
			CqlDateTime n_ = context.Operators.Convert<CqlDateTime>(m_);
			CqlInterval<CqlDateTime> o_ = this.Measurement_Period(context);
			bool? p_ = context.Operators.In<CqlDateTime>(n_, o_, default);

			return p_;
		};
		IEnumerable<MedicationRequest> h_ = context.Operators.Where<MedicationRequest>(f_, g_);
		CqlDateTime i_(MedicationRequest AntipsychoticMedication)
		{
			FhirDateTime q_ = AntipsychoticMedication?.AuthoredOnElement;
			CqlDateTime r_ = context.Operators.Convert<CqlDateTime>(q_);

			return r_;
		};
		IEnumerable<CqlDateTime> j_ = context.Operators.Select<MedicationRequest, CqlDateTime>(h_, i_);
		IEnumerable<CqlDateTime> k_ = context.Operators.ListSort<CqlDateTime>(j_, System.ComponentModel.ListSortDirection.Ascending);
		CqlDateTime l_ = context.Operators.First<CqlDateTime>(k_);

		return l_;
	}


    [CqlDeclaration("More than One Benzodiazepine Order")]
	public bool? More_than_One_Benzodiazepine_Order(CqlContext context)
	{
		CqlValueSet a_ = this.Benzodiazepine(context);
		IEnumerable<MedicationRequest> b_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
		IEnumerable<MedicationRequest> d_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
		IEnumerable<MedicationRequest> e_ = context.Operators.Union<MedicationRequest>(b_, d_);
		IEnumerable<MedicationRequest> f_ = this.More_Than_One_Order(context, e_);
		bool? g_ = context.Operators.Exists<MedicationRequest>(f_);

		return g_;
	}


    [CqlDeclaration("Benzodiazepine Index Prescription Start Date")]
	public CqlDateTime Benzodiazepine_Index_Prescription_Start_Date(CqlContext context)
	{
		CqlValueSet a_ = this.Benzodiazepine(context);
		IEnumerable<MedicationRequest> b_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
		IEnumerable<MedicationRequest> d_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
		IEnumerable<MedicationRequest> e_ = context.Operators.Union<MedicationRequest>(b_, d_);
		IEnumerable<MedicationRequest> f_ = Status_1_6_000.Instance.Active_or_Completed_Medication_Request(context, e_);
		bool? g_(MedicationRequest BenzodiazepineMedication)
		{
			FhirDateTime m_ = BenzodiazepineMedication?.AuthoredOnElement;
			CqlDateTime n_ = context.Operators.Convert<CqlDateTime>(m_);
			CqlInterval<CqlDateTime> o_ = this.Measurement_Period(context);
			bool? p_ = context.Operators.In<CqlDateTime>(n_, o_, default);

			return p_;
		};
		IEnumerable<MedicationRequest> h_ = context.Operators.Where<MedicationRequest>(f_, g_);
		CqlDateTime i_(MedicationRequest BenzodiazepineMedication)
		{
			FhirDateTime q_ = BenzodiazepineMedication?.AuthoredOnElement;
			CqlDateTime r_ = context.Operators.Convert<CqlDateTime>(q_);

			return r_;
		};
		IEnumerable<CqlDateTime> j_ = context.Operators.Select<MedicationRequest, CqlDateTime>(h_, i_);
		IEnumerable<CqlDateTime> k_ = context.Operators.ListSort<CqlDateTime>(j_, System.ComponentModel.ListSortDirection.Ascending);
		CqlDateTime l_ = context.Operators.First<CqlDateTime>(k_);

		return l_;
	}


    [CqlDeclaration("Numerator 2")]
	public bool? Numerator_2(CqlContext context)
	{
		bool? a_ = this.More_than_One_Antipsychotic_Order(context);
		CqlValueSet b_ = this.Schizophrenia(context);
		IEnumerable<Condition> c_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, b_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
		CqlValueSet d_ = this.Bipolar_Disorder(context);
		IEnumerable<Condition> e_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, d_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
		IEnumerable<Condition> f_ = context.Operators.Union<Condition>(c_, e_);
		bool? g_(Condition AntipsychoticTreatedDiagnoses)
		{
			CqlInterval<CqlDateTime> ag_ = QICoreCommon_2_0_000.Instance.ToPrevalenceInterval(context, AntipsychoticTreatedDiagnoses);
			CqlInterval<CqlDateTime> ah_ = this.Measurement_Period(context);
			CqlDateTime ai_ = context.Operators.Start(ah_);
			CqlQuantity aj_ = context.Operators.Quantity(1m, "year");
			CqlDateTime ak_ = context.Operators.Subtract(ai_, aj_);
			CqlDateTime al_ = this.Antipsychotic_Index_Prescription_Start_Date(context);
			CqlInterval<CqlDateTime> am_ = context.Operators.Interval(ak_, al_, true, true);
			bool? an_ = context.Operators.Overlaps(ag_, am_, default);

			return an_;
		};
		IEnumerable<Condition> h_ = context.Operators.Where<Condition>(f_, g_);
		bool? i_ = context.Operators.Exists<Condition>(h_);
		bool? j_ = context.Operators.Not(i_);
		bool? k_ = context.Operators.And(a_, j_);
		bool? l_ = this.More_than_One_Benzodiazepine_Order(context);
		CqlValueSet m_ = this.Seizure_Disorder(context);
		IEnumerable<Condition> n_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, m_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
		CqlValueSet o_ = this.REM_Sleep_Behavior_Disorder(context);
		IEnumerable<Condition> p_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, o_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
		IEnumerable<Condition> q_ = context.Operators.Union<Condition>(n_, p_);
		CqlValueSet r_ = this.Benzodiazepine_Withdrawal(context);
		IEnumerable<Condition> s_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, r_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
		CqlValueSet t_ = this.Alcohol_Withdrawal(context);
		IEnumerable<Condition> u_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, t_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
		IEnumerable<Condition> v_ = context.Operators.Union<Condition>(s_, u_);
		IEnumerable<Condition> w_ = context.Operators.Union<Condition>(q_, v_);
		CqlValueSet x_ = this.Generalized_Anxiety_Disorder(context);
		IEnumerable<Condition> y_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, x_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
		IEnumerable<Condition> z_ = context.Operators.Union<Condition>(w_, y_);
		bool? aa_(Condition BenzodiazepineTreatedDiagnoses)
		{
			CqlInterval<CqlDateTime> ao_ = QICoreCommon_2_0_000.Instance.ToPrevalenceInterval(context, BenzodiazepineTreatedDiagnoses);
			CqlInterval<CqlDateTime> ap_ = this.Measurement_Period(context);
			CqlDateTime aq_ = context.Operators.Start(ap_);
			CqlQuantity ar_ = context.Operators.Quantity(1m, "year");
			CqlDateTime as_ = context.Operators.Subtract(aq_, ar_);
			CqlDateTime at_ = this.Benzodiazepine_Index_Prescription_Start_Date(context);
			CqlInterval<CqlDateTime> au_ = context.Operators.Interval(as_, at_, true, true);
			bool? av_ = context.Operators.Overlaps(ao_, au_, default);

			return av_;
		};
		IEnumerable<Condition> ab_ = context.Operators.Where<Condition>(z_, aa_);
		bool? ac_ = context.Operators.Exists<Condition>(ab_);
		bool? ad_ = context.Operators.Not(ac_);
		bool? ae_ = context.Operators.And(l_, ad_);
		bool? af_ = context.Operators.Or(k_, ae_);

		return af_;
	}


    [CqlDeclaration("Numerator 3")]
	public bool? Numerator_3(CqlContext context)
	{
		bool? a_ = this.Numerator_2(context);
		bool? b_ = this.Numerator_1(context);
		bool? d_ = context.Operators.Not(a_);
		bool? e_ = context.Operators.And(b_, d_);
		bool? f_ = context.Operators.Or(a_, e_);

		return f_;
	}


    [CqlDeclaration("SDE Ethnicity")]
	public (IEnumerable<CqlCode> codes, string display)? SDE_Ethnicity(CqlContext context)
	{
		(IEnumerable<CqlCode> codes, string display)? a_ = SupplementalDataElements_3_4_000.Instance.SDE_Ethnicity(context);

		return a_;
	}


    [CqlDeclaration("SDE Payer")]
	public IEnumerable<(CqlConcept code, CqlInterval<CqlDateTime> period)?> SDE_Payer(CqlContext context)
	{
		IEnumerable<(CqlConcept code, CqlInterval<CqlDateTime> period)?> a_ = SupplementalDataElements_3_4_000.Instance.SDE_Payer(context);

		return a_;
	}


    [CqlDeclaration("SDE Race")]
	public (IEnumerable<CqlCode> codes, string display)? SDE_Race(CqlContext context)
	{
		(IEnumerable<CqlCode> codes, string display)? a_ = SupplementalDataElements_3_4_000.Instance.SDE_Race(context);

		return a_;
	}


    [CqlDeclaration("SDE Sex")]
	public CqlCode SDE_Sex(CqlContext context)
	{
		CqlCode a_ = SupplementalDataElements_3_4_000.Instance.SDE_Sex(context);

		return a_;
	}

}
