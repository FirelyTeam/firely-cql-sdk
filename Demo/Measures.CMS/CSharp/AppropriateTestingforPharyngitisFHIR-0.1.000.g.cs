using System;
using System.Linq;
using System.Collections.Generic;
using Hl7.Cql.Runtime;
using Hl7.Cql.Primitives;
using Hl7.Cql.Abstractions;
using Hl7.Cql.ValueSets;
using Hl7.Cql.Iso8601;
using System.Reflection;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using Hl7.Fhir.Model;
using Range = Hl7.Fhir.Model.Range;
using Task = Hl7.Fhir.Model.Task;

#pragma warning disable CS9113 // Parameter is unread.

[System.CodeDom.Compiler.GeneratedCode(".NET Code Generation", "2.0.3.0")]
public static partial class AppropriateTestingforPharyngitisFHIR_0_1_000ServiceCollectionExtensions
{
    public static IServiceCollection AddAppropriateTestingforPharyngitisFHIR_0_1_000(this IServiceCollection services)
    {
        services.TryAddSingleton<AppropriateTestingforPharyngitisFHIR_0_1_000>();
        services.AddFHIRHelpers_4_3_000();
        services.AddSupplementalDataElements_3_4_000();
        services.AddCQMCommon_2_0_000();
        services.AddHospice_6_9_000();
        services.AddAntibiotic_1_5_000();
        services.AddStatus_1_6_000();
        services.AddQICoreCommon_2_0_000();
        return services;
    }
}

partial class AppropriateTestingforPharyngitisFHIR_0_1_000 : ICqlLibrary
{
    public static void AddLibraryService(IServiceCollection services) =>
        services.AddAppropriateTestingforPharyngitisFHIR_0_1_000();
}

[System.CodeDom.Compiler.GeneratedCode(".NET Code Generation", "2.0.3.0")]
[CqlLibrary("AppropriateTestingforPharyngitisFHIR", "0.1.000")]
public partial class AppropriateTestingforPharyngitisFHIR_0_1_000(
    FHIRHelpers_4_3_000 fhirHelpers_4_3_000,
    SupplementalDataElements_3_4_000 supplementalDataElements_3_4_000,
    CQMCommon_2_0_000 cqmCommon_2_0_000,
    Hospice_6_9_000 hospice_6_9_000,
    Antibiotic_1_5_000 antibiotic_1_5_000,
    Status_1_6_000 status_1_6_000,
    QICoreCommon_2_0_000 qiCoreCommon_2_0_000)
{

    [CqlDeclaration("Acute Pharyngitis")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.102.12.1011")]
	public CqlValueSet Acute_Pharyngitis(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.102.12.1011", default);

    [CqlDeclaration("Acute Tonsillitis")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.102.12.1012")]
	public CqlValueSet Acute_Tonsillitis(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.102.12.1012", default);

    [CqlDeclaration("Antibiotic Medications for Pharyngitis")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.196.12.1001")]
	public CqlValueSet Antibiotic_Medications_for_Pharyngitis(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.196.12.1001", default);

    [CqlDeclaration("Comorbid Conditions for Respiratory Conditions")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.102.12.1025")]
	public CqlValueSet Comorbid_Conditions_for_Respiratory_Conditions(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.102.12.1025", default);

    [CqlDeclaration("Competing Conditions for Respiratory Conditions")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.102.12.1017")]
	public CqlValueSet Competing_Conditions_for_Respiratory_Conditions(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.102.12.1017", default);

    [CqlDeclaration("Discharge Services Observation Care")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1039")]
	public CqlValueSet Discharge_Services_Observation_Care(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1039", default);

    [CqlDeclaration("Emergency Department Visit")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1010")]
	public CqlValueSet Emergency_Department_Visit(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1010", default);

    [CqlDeclaration("Group A Streptococcus Test")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.198.12.1012")]
	public CqlValueSet Group_A_Streptococcus_Test(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.198.12.1012", default);

    [CqlDeclaration("Home Healthcare Services")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1016")]
	public CqlValueSet Home_Healthcare_Services(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1016", default);

    [CqlDeclaration("Initial Hospital Observation Care")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1002")]
	public CqlValueSet Initial_Hospital_Observation_Care(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1002", default);

    [CqlDeclaration("Medical Disability Exam")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1073")]
	public CqlValueSet Medical_Disability_Exam(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1073", default);

    [CqlDeclaration("Observation")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1086")]
	public CqlValueSet Observation(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1086", default);

    [CqlDeclaration("Office Visit")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1001")]
	public CqlValueSet Office_Visit(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1001", default);

    [CqlDeclaration("Online Assessments")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1089")]
	public CqlValueSet Online_Assessments(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1089", default);

    [CqlDeclaration("Outpatient Consultation")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1008")]
	public CqlValueSet Outpatient_Consultation(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1008", default);

    [CqlDeclaration("Preventive Care Services Established Office Visit, 18 and Up")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1025")]
	public CqlValueSet Preventive_Care_Services_Established_Office_Visit__18_and_Up(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1025", default);

    [CqlDeclaration("Preventive Care Services Group Counseling")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1027")]
	public CqlValueSet Preventive_Care_Services_Group_Counseling(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1027", default);

    [CqlDeclaration("Preventive Care Services Individual Counseling")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1026")]
	public CqlValueSet Preventive_Care_Services_Individual_Counseling(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1026", default);

    [CqlDeclaration("Preventive Care Services Initial Office Visit, 18 and Up")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1023")]
	public CqlValueSet Preventive_Care_Services_Initial_Office_Visit__18_and_Up(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1023", default);

    [CqlDeclaration("Preventive Care Services, Initial Office Visit, 0 to 17")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1022")]
	public CqlValueSet Preventive_Care_Services__Initial_Office_Visit__0_to_17(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1022", default);

    [CqlDeclaration("Preventive Care, Established Office Visit, 0 to 17")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1024")]
	public CqlValueSet Preventive_Care__Established_Office_Visit__0_to_17(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1024", default);

    [CqlDeclaration("Telephone Visits")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1080")]
	public CqlValueSet Telephone_Visits(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1080", default);

    [CqlDeclaration("Observation care discharge day management (This code is to be utilized to report all services provided to a patient on discharge from outpatient hospital observation status if the discharge is on other than the initial date of observation status. To report services to a patient designated as observation status or inpatient status and discharged on the same date, use the codes for Observation or Inpatient Care Services [including Admission and Discharge Services, 99234-99236 as appropriate.])")]
	public CqlCode Observation_care_discharge_day_management__This_code_is_to_be_utilized_to_report_all_services_provided_to_a_patient_on_discharge_from_outpatient_hospital_observation_status_if_the_discharge_is_on_other_than_the_initial_date_of_observation_status__To_report_services_to_a_patient_designated_as_observation_status_or_inpatient_status_and_discharged_on_the_same_date__use_the_codes_for_Observation_or_Inpatient_Care_Services__including_Admission_and_Discharge_Services__99234_99236_as_appropriate___(CqlContext context) => 
		new CqlCode("99217", "http://www.ama-assn.org/go/cpt", default, default);

    [CqlDeclaration("Unlisted preventive medicine service")]
	public CqlCode Unlisted_preventive_medicine_service(CqlContext context) => 
		new CqlCode("99429", "http://www.ama-assn.org/go/cpt", default, default);

    [CqlDeclaration("CPT")]
	public CqlCode[] CPT(CqlContext context)
	{
		CqlCode[] a_ = [
			new CqlCode("99217", "http://www.ama-assn.org/go/cpt", default, default),
			new CqlCode("99429", "http://www.ama-assn.org/go/cpt", default, default),
		];

		return a_;
	}

    [CqlDeclaration("Measurement Period")]
	public CqlInterval<CqlDateTime> Measurement_Period(CqlContext context)
	{
		CqlDateTime a_ = context.Operators.DateTime(2025, 1, 1, 0, 0, 0, 0, default);
		CqlDateTime b_ = context.Operators.DateTime(2026, 1, 1, 0, 0, 0, 0, default);
		CqlInterval<CqlDateTime> c_ = context.Operators.Interval(a_, b_, true, false);
		object d_ = context.ResolveParameter("AppropriateTestingforPharyngitisFHIR-0.1.000", "Measurement Period", c_);

		return (CqlInterval<CqlDateTime>)d_;
	}

    [CqlDeclaration("Patient")]
	public Patient Patient(CqlContext context)
	{
		IEnumerable<Patient> a_ = context.Operators.RetrieveByValueSet<Patient>(default, default);
		Patient b_ = context.Operators.SingletonFrom<Patient>(a_);

		return b_;
	}

    [CqlDeclaration("SDE Ethnicity")]
	public (IEnumerable<CqlCode> codes, string display)? SDE_Ethnicity(CqlContext context)
	{
		(IEnumerable<CqlCode> codes, string display)? a_ = supplementalDataElements_3_4_000.SDE_Ethnicity(context);

		return a_;
	}

    [CqlDeclaration("SDE Payer")]
	public IEnumerable<(CqlConcept code, CqlInterval<CqlDateTime> period)?> SDE_Payer(CqlContext context)
	{
		IEnumerable<(CqlConcept code, CqlInterval<CqlDateTime> period)?> a_ = supplementalDataElements_3_4_000.SDE_Payer(context);

		return a_;
	}

    [CqlDeclaration("SDE Race")]
	public (IEnumerable<CqlCode> codes, string display)? SDE_Race(CqlContext context)
	{
		(IEnumerable<CqlCode> codes, string display)? a_ = supplementalDataElements_3_4_000.SDE_Race(context);

		return a_;
	}

    [CqlDeclaration("SDE Sex")]
	public CqlCode SDE_Sex(CqlContext context)
	{
		CqlCode a_ = supplementalDataElements_3_4_000.SDE_Sex(context);

		return a_;
	}

    [CqlDeclaration("Qualifying Encounter")]
	public IEnumerable<Encounter> Qualifying_Encounter(CqlContext context)
	{
		CqlValueSet a_ = this.Emergency_Department_Visit(context);
		IEnumerable<Encounter> b_ = context.Operators.RetrieveByValueSet<Encounter>(a_, default);
		IEnumerable<Encounter> c_ = context.Operators.RetrieveByValueSet<Encounter>(default, default);
		bool? d_(Encounter E)
		{
			List<CodeableConcept> bg_ = E?.Type;
			CqlConcept bh_(CodeableConcept @this)
			{
				CqlConcept bm_ = fhirHelpers_4_3_000.ToConcept(context, @this);

				return bm_;
			};
			IEnumerable<CqlConcept> bi_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)bg_, bh_);
			bool? bj_(CqlConcept T)
			{
				CqlCode bn_ = this.Observation_care_discharge_day_management__This_code_is_to_be_utilized_to_report_all_services_provided_to_a_patient_on_discharge_from_outpatient_hospital_observation_status_if_the_discharge_is_on_other_than_the_initial_date_of_observation_status__To_report_services_to_a_patient_designated_as_observation_status_or_inpatient_status_and_discharged_on_the_same_date__use_the_codes_for_Observation_or_Inpatient_Care_Services__including_Admission_and_Discharge_Services__99234_99236_as_appropriate___(context);
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
		IEnumerable<Encounter> h_ = context.Operators.RetrieveByValueSet<Encounter>(a_, default);
		CqlValueSet i_ = this.Home_Healthcare_Services(context);
		IEnumerable<Encounter> j_ = context.Operators.RetrieveByValueSet<Encounter>(i_, default);
		IEnumerable<Encounter> k_ = context.Operators.Union<Encounter>(h_, j_);
		IEnumerable<Encounter> l_ = context.Operators.Union<Encounter>(f_, k_);
		CqlValueSet m_ = this.Initial_Hospital_Observation_Care(context);
		IEnumerable<Encounter> n_ = context.Operators.RetrieveByValueSet<Encounter>(m_, default);
		CqlValueSet o_ = this.Medical_Disability_Exam(context);
		IEnumerable<Encounter> p_ = context.Operators.RetrieveByValueSet<Encounter>(o_, default);
		IEnumerable<Encounter> q_ = context.Operators.Union<Encounter>(n_, p_);
		IEnumerable<Encounter> r_ = context.Operators.Union<Encounter>(l_, q_);
		CqlValueSet s_ = this.Observation(context);
		IEnumerable<Encounter> t_ = context.Operators.RetrieveByValueSet<Encounter>(s_, default);
		CqlValueSet u_ = this.Office_Visit(context);
		IEnumerable<Encounter> v_ = context.Operators.RetrieveByValueSet<Encounter>(u_, default);
		IEnumerable<Encounter> w_ = context.Operators.Union<Encounter>(t_, v_);
		IEnumerable<Encounter> x_ = context.Operators.Union<Encounter>(r_, w_);
		CqlValueSet y_ = this.Telephone_Visits(context);
		IEnumerable<Encounter> z_ = context.Operators.RetrieveByValueSet<Encounter>(y_, default);
		CqlValueSet aa_ = this.Online_Assessments(context);
		IEnumerable<Encounter> ab_ = context.Operators.RetrieveByValueSet<Encounter>(aa_, default);
		IEnumerable<Encounter> ac_ = context.Operators.Union<Encounter>(z_, ab_);
		IEnumerable<Encounter> ad_ = context.Operators.Union<Encounter>(x_, ac_);
		CqlValueSet ae_ = this.Outpatient_Consultation(context);
		IEnumerable<Encounter> af_ = context.Operators.RetrieveByValueSet<Encounter>(ae_, default);
		CqlValueSet ag_ = this.Preventive_Care_Services_Established_Office_Visit__18_and_Up(context);
		IEnumerable<Encounter> ah_ = context.Operators.RetrieveByValueSet<Encounter>(ag_, default);
		IEnumerable<Encounter> ai_ = context.Operators.Union<Encounter>(af_, ah_);
		IEnumerable<Encounter> aj_ = context.Operators.Union<Encounter>(ad_, ai_);
		CqlValueSet ak_ = this.Preventive_Care_Services_Group_Counseling(context);
		IEnumerable<Encounter> al_ = context.Operators.RetrieveByValueSet<Encounter>(ak_, default);
		bool? an_(Encounter E)
		{
			List<CodeableConcept> bq_ = E?.Type;
			CqlConcept br_(CodeableConcept @this)
			{
				CqlConcept bw_ = fhirHelpers_4_3_000.ToConcept(context, @this);

				return bw_;
			};
			IEnumerable<CqlConcept> bs_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)bq_, br_);
			bool? bt_(CqlConcept T)
			{
				CqlCode bx_ = this.Unlisted_preventive_medicine_service(context);
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
		CqlValueSet ar_ = this.Preventive_Care_Services__Initial_Office_Visit__0_to_17(context);
		IEnumerable<Encounter> as_ = context.Operators.RetrieveByValueSet<Encounter>(ar_, default);
		CqlValueSet at_ = this.Preventive_Care_Services_Individual_Counseling(context);
		IEnumerable<Encounter> au_ = context.Operators.RetrieveByValueSet<Encounter>(at_, default);
		IEnumerable<Encounter> av_ = context.Operators.Union<Encounter>(as_, au_);
		IEnumerable<Encounter> aw_ = context.Operators.Union<Encounter>(aq_, av_);
		CqlValueSet ax_ = this.Preventive_Care_Services_Initial_Office_Visit__18_and_Up(context);
		IEnumerable<Encounter> ay_ = context.Operators.RetrieveByValueSet<Encounter>(ax_, default);
		CqlValueSet az_ = this.Preventive_Care__Established_Office_Visit__0_to_17(context);
		IEnumerable<Encounter> ba_ = context.Operators.RetrieveByValueSet<Encounter>(az_, default);
		IEnumerable<Encounter> bb_ = context.Operators.Union<Encounter>(ay_, ba_);
		IEnumerable<Encounter> bc_ = context.Operators.Union<Encounter>(aw_, bb_);
		IEnumerable<Encounter> bd_ = status_1_6_000.Finished_Encounter(context, bc_);
		bool? be_(Encounter ValidEncounter)
		{
			CqlInterval<CqlDateTime> ca_ = this.Measurement_Period(context);
			Period cb_ = ValidEncounter?.Period;
			CqlInterval<CqlDateTime> cc_ = fhirHelpers_4_3_000.ToInterval(context, cb_);
			CqlInterval<CqlDateTime> cd_ = qiCoreCommon_2_0_000.ToInterval(context, cc_ as object);
			bool? ce_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(ca_, cd_, default);

			return ce_;
		};
		IEnumerable<Encounter> bf_ = context.Operators.Where<Encounter>(bd_, be_);

		return bf_;
	}

    [CqlDeclaration("Encounter With Antibiotic Ordered Within Three Days")]
	public IEnumerable<Encounter> Encounter_With_Antibiotic_Ordered_Within_Three_Days(CqlContext context)
	{
		IEnumerable<Encounter> a_ = this.Qualifying_Encounter(context);
		IEnumerable<Encounter> b_(Encounter EDOrAmbulatoryVisit)
		{
			CqlValueSet d_ = this.Antibiotic_Medications_for_Pharyngitis(context);
			IEnumerable<MedicationRequest> e_ = context.Operators.RetrieveByValueSet<MedicationRequest>(d_, default);
			IEnumerable<MedicationRequest> g_ = context.Operators.RetrieveByValueSet<MedicationRequest>(d_, default);
			IEnumerable<MedicationRequest> h_ = context.Operators.Union<MedicationRequest>(e_, g_);
			IEnumerable<MedicationRequest> i_ = status_1_6_000.Active_Medication(context, h_);
			bool? j_(MedicationRequest AntibioticOrdered)
			{
				Period n_ = EDOrAmbulatoryVisit?.Period;
				CqlInterval<CqlDateTime> o_ = fhirHelpers_4_3_000.ToInterval(context, n_);
				CqlInterval<CqlDateTime> p_ = qiCoreCommon_2_0_000.ToInterval(context, o_ as object);
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

    [CqlDeclaration("Pharyngitis or Tonsillitis")]
	public IEnumerable<Condition> Pharyngitis_or_Tonsillitis(CqlContext context)
	{
		CqlValueSet a_ = this.Acute_Pharyngitis(context);
		IEnumerable<Condition> b_ = context.Operators.RetrieveByValueSet<Condition>(a_, default);
		CqlValueSet c_ = this.Acute_Tonsillitis(context);
		IEnumerable<Condition> d_ = context.Operators.RetrieveByValueSet<Condition>(c_, default);
		IEnumerable<Condition> e_ = context.Operators.Union<Condition>(b_, d_);
		IEnumerable<Condition> f_ = status_1_6_000.Active_Condition(context, e_);

		return f_;
	}

    [CqlDeclaration("Encounter With Pharyngitis or Tonsillitis With Antibiotic")]
	public IEnumerable<Encounter> Encounter_With_Pharyngitis_or_Tonsillitis_With_Antibiotic(CqlContext context)
	{
		IEnumerable<Encounter> a_ = this.Encounter_With_Antibiotic_Ordered_Within_Three_Days(context);
		IEnumerable<Condition> b_ = this.Pharyngitis_or_Tonsillitis(context);
		IEnumerable<ValueTuple<Encounter, Condition>> c_ = context.Operators.CrossJoin<Encounter, Condition>(a_, b_);
		(Encounter VisitWithAntibiotic, Condition AcutePharyngitisTonsillitis)? d_(ValueTuple<Encounter, Condition> _valueTuple)
		{
			(Encounter VisitWithAntibiotic, Condition AcutePharyngitisTonsillitis)? j_ = (_valueTuple.Item1, _valueTuple.Item2);

			return j_;
		};
		IEnumerable<(Encounter VisitWithAntibiotic, Condition AcutePharyngitisTonsillitis)?> e_ = context.Operators.Select<ValueTuple<Encounter, Condition>, (Encounter VisitWithAntibiotic, Condition AcutePharyngitisTonsillitis)?>(c_, d_);
		bool? f_((Encounter VisitWithAntibiotic, Condition AcutePharyngitisTonsillitis)? tuple_ypyxedbbcqbdavhxvckuwmfh)
		{
			CqlInterval<CqlDateTime> k_ = qiCoreCommon_2_0_000.ToPrevalenceInterval(context, tuple_ypyxedbbcqbdavhxvckuwmfh?.AcutePharyngitisTonsillitis);
			CqlDateTime l_ = context.Operators.Start(k_);
			Period m_ = tuple_ypyxedbbcqbdavhxvckuwmfh?.VisitWithAntibiotic?.Period;
			CqlInterval<CqlDateTime> n_ = fhirHelpers_4_3_000.ToInterval(context, m_);
			CqlInterval<CqlDateTime> o_ = qiCoreCommon_2_0_000.ToInterval(context, n_ as object);
			bool? p_ = context.Operators.In<CqlDateTime>(l_, o_, default);

			return p_;
		};
		IEnumerable<(Encounter VisitWithAntibiotic, Condition AcutePharyngitisTonsillitis)?> g_ = context.Operators.Where<(Encounter VisitWithAntibiotic, Condition AcutePharyngitisTonsillitis)?>(e_, f_);
		Encounter h_((Encounter VisitWithAntibiotic, Condition AcutePharyngitisTonsillitis)? tuple_ypyxedbbcqbdavhxvckuwmfh) => 
			tuple_ypyxedbbcqbdavhxvckuwmfh?.VisitWithAntibiotic;
		IEnumerable<Encounter> i_ = context.Operators.Select<(Encounter VisitWithAntibiotic, Condition AcutePharyngitisTonsillitis)?, Encounter>(g_, h_);

		return i_;
	}

    [CqlDeclaration("Initial Population")]
	public IEnumerable<Encounter> Initial_Population(CqlContext context)
	{
		IEnumerable<Encounter> a_ = this.Encounter_With_Pharyngitis_or_Tonsillitis_With_Antibiotic(context);
		bool? b_(Encounter EncounterWithPharyngitis)
		{
			Patient f_ = this.Patient(context);
			Date g_ = f_?.BirthDateElement;
			string h_ = g_?.Value;
			CqlDate i_ = context.Operators.ConvertStringToDate(h_);
			CqlInterval<CqlDateTime> j_ = this.Measurement_Period(context);
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

    [CqlDeclaration("Denominator")]
	public IEnumerable<Encounter> Denominator(CqlContext context)
	{
		IEnumerable<Encounter> a_ = this.Initial_Population(context);

		return a_;
	}

    [CqlDeclaration("In Hospice")]
	public IEnumerable<Encounter> In_Hospice(CqlContext context)
	{
		IEnumerable<Encounter> a_ = this.Initial_Population(context);
		bool? b_(Encounter EligibleEncounters)
		{
			bool? d_ = hospice_6_9_000.Has_Hospice_Services(context);

			return d_;
		};
		IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);

		return c_;
	}

    [CqlDeclaration("Denominator Exclusions")]
	public IEnumerable<Encounter> Denominator_Exclusions(CqlContext context)
	{
		IEnumerable<Encounter> a_ = this.In_Hospice(context);
		IEnumerable<Encounter> b_ = this.Encounter_With_Pharyngitis_or_Tonsillitis_With_Antibiotic(context);
		CqlValueSet c_ = this.Antibiotic_Medications_for_Pharyngitis(context);
		IEnumerable<MedicationRequest> d_ = context.Operators.RetrieveByValueSet<MedicationRequest>(c_, default);
		IEnumerable<MedicationRequest> f_ = context.Operators.RetrieveByValueSet<MedicationRequest>(c_, default);
		IEnumerable<MedicationRequest> g_ = context.Operators.Union<MedicationRequest>(d_, f_);
		IEnumerable<Encounter> h_ = antibiotic_1_5_000.Has_Antibiotic_Medication_History(context, b_, g_);
		IEnumerable<Encounter> i_ = context.Operators.Union<Encounter>(a_, h_);
		CqlValueSet k_ = this.Competing_Conditions_for_Respiratory_Conditions(context);
		IEnumerable<Condition> l_ = context.Operators.RetrieveByValueSet<Condition>(k_, default);
		IEnumerable<Encounter> m_ = antibiotic_1_5_000.Has_Competing_Diagnosis_History(context, b_, l_);
		CqlValueSet o_ = this.Comorbid_Conditions_for_Respiratory_Conditions(context);
		IEnumerable<Condition> p_ = context.Operators.RetrieveByValueSet<Condition>(o_, default);
		IEnumerable<Encounter> q_ = antibiotic_1_5_000.Has_Comorbid_Condition_History(context, b_, p_);
		IEnumerable<Encounter> r_ = context.Operators.Union<Encounter>(m_, q_);
		IEnumerable<Encounter> s_ = context.Operators.Union<Encounter>(i_, r_);

		return s_;
	}

    [CqlDeclaration("Group A Streptococcus Lab Test With Result")]
	public IEnumerable<Observation> Group_A_Streptococcus_Lab_Test_With_Result(CqlContext context)
	{
		CqlValueSet a_ = this.Group_A_Streptococcus_Test(context);
		IEnumerable<Observation> b_ = context.Operators.RetrieveByValueSet<Observation>(a_, default);
		IEnumerable<Observation> c_ = status_1_6_000.Final_Lab_Observation(context, b_);
		bool? d_(Observation GroupAStreptococcusTest)
		{
			DataType f_ = GroupAStreptococcusTest?.Value;
			object g_ = fhirHelpers_4_3_000.ToValue(context, f_);
			bool? h_ = context.Operators.Not((bool?)(g_ is null));

			return h_;
		};
		IEnumerable<Observation> e_ = context.Operators.Where<Observation>(c_, d_);

		return e_;
	}

    [CqlDeclaration("Numerator")]
	public IEnumerable<Encounter> Numerator(CqlContext context)
	{
		IEnumerable<Observation> a_ = this.Group_A_Streptococcus_Lab_Test_With_Result(context);
		IEnumerable<Encounter> b_ = this.Encounter_With_Pharyngitis_or_Tonsillitis_With_Antibiotic(context);
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
			object l_ = fhirHelpers_4_3_000.ToValue(context, k_);
			CqlInterval<CqlDateTime> m_ = qiCoreCommon_2_0_000.ToInterval(context, l_);
			CqlDateTime n_ = context.Operators.Start(m_);
			Period o_ = tuple_ffguysnebcxllexfcmjoehbij?.EncounterWithPharyngitis?.Period;
			CqlInterval<CqlDateTime> p_ = fhirHelpers_4_3_000.ToInterval(context, o_);
			CqlDateTime q_ = context.Operators.End(p_);
			CqlQuantity r_ = context.Operators.Quantity(3m, "days");
			CqlDateTime s_ = context.Operators.Subtract(q_, r_);
			CqlInterval<CqlDateTime> u_ = fhirHelpers_4_3_000.ToInterval(context, o_);
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

    [CqlDeclaration("Stratification 1")]
	public IEnumerable<Encounter> Stratification_1(CqlContext context)
	{
		IEnumerable<Encounter> a_ = this.Encounter_With_Pharyngitis_or_Tonsillitis_With_Antibiotic(context);
		bool? b_(Encounter EncounterWithPharyngitis)
		{
			Patient f_ = this.Patient(context);
			Date g_ = f_?.BirthDateElement;
			string h_ = g_?.Value;
			CqlDate i_ = context.Operators.ConvertStringToDate(h_);
			CqlInterval<CqlDateTime> j_ = this.Measurement_Period(context);
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

    [CqlDeclaration("Stratification 2")]
	public IEnumerable<Encounter> Stratification_2(CqlContext context)
	{
		IEnumerable<Encounter> a_ = this.Encounter_With_Pharyngitis_or_Tonsillitis_With_Antibiotic(context);
		bool? b_(Encounter EncounterWithPharyngitis)
		{
			Patient f_ = this.Patient(context);
			Date g_ = f_?.BirthDateElement;
			string h_ = g_?.Value;
			CqlDate i_ = context.Operators.ConvertStringToDate(h_);
			CqlInterval<CqlDateTime> j_ = this.Measurement_Period(context);
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

    [CqlDeclaration("Stratification 3")]
	public IEnumerable<Encounter> Stratification_3(CqlContext context)
	{
		IEnumerable<Encounter> a_ = this.Encounter_With_Pharyngitis_or_Tonsillitis_With_Antibiotic(context);
		bool? b_(Encounter EncounterWithPharyngitis)
		{
			Patient f_ = this.Patient(context);
			Date g_ = f_?.BirthDateElement;
			string h_ = g_?.Value;
			CqlDate i_ = context.Operators.ConvertStringToDate(h_);
			CqlInterval<CqlDateTime> j_ = this.Measurement_Period(context);
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

}
