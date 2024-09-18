using System;
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

#pragma warning disable CS9113 // Parameter is unread.

[System.CodeDom.Compiler.GeneratedCode(".NET Code Generation", "2.0.3.0")]
[CqlLibrary("AppropriateTreatmentforUpperRespiratoryInfectionURIFHIR", "0.1.000")]
public class AppropriateTreatmentforUpperRespiratoryInfectionURIFHIR_0_1_000(
    FHIRHelpers_4_3_000 fhirHelpers_4_3_000,
    SupplementalDataElements_3_4_000 supplementalDataElements_3_4_000,
    CQMCommon_2_0_000 cqmCommon_2_0_000,
    Hospice_6_9_000 hospice_6_9_000,
    Status_1_6_000 status_1_6_000,
    QICoreCommon_2_0_000 qiCoreCommon_2_0_000,
    Antibiotic_1_5_000 antibiotic_1_5_000)
{

    [CqlDeclaration("Antibiotic Medications for Upper Respiratory Infection")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.196.12.1001")]
	public  CqlValueSet Antibiotic_Medications_for_Upper_Respiratory_Infection(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.196.12.1001", default);

    [CqlDeclaration("Comorbid Conditions for Respiratory Conditions")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.102.12.1025")]
	public  CqlValueSet Comorbid_Conditions_for_Respiratory_Conditions(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.102.12.1025", default);

    [CqlDeclaration("Competing Conditions for Respiratory Conditions")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.102.12.1017")]
	public  CqlValueSet Competing_Conditions_for_Respiratory_Conditions(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.102.12.1017", default);

    [CqlDeclaration("Emergency Department Evaluation and Management Visit")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1010")]
	public  CqlValueSet Emergency_Department_Evaluation_and_Management_Visit(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1010", default);

    [CqlDeclaration("Home Healthcare Services")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1016")]
	public  CqlValueSet Home_Healthcare_Services(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1016", default);

    [CqlDeclaration("Initial Hospital Observation Care")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1002")]
	public  CqlValueSet Initial_Hospital_Observation_Care(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1002", default);

    [CqlDeclaration("Medical Disability Exam")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1073")]
	public  CqlValueSet Medical_Disability_Exam(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1073", default);

    [CqlDeclaration("Observation")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1086")]
	public  CqlValueSet Observation(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1086", default);

    [CqlDeclaration("Office Visit")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1001")]
	public  CqlValueSet Office_Visit(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1001", default);

    [CqlDeclaration("Online Assessments")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1089")]
	public  CqlValueSet Online_Assessments(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1089", default);

    [CqlDeclaration("Outpatient Consultation")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1008")]
	public  CqlValueSet Outpatient_Consultation(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1008", default);

    [CqlDeclaration("Preventive Care Services Established Office Visit, 18 and Up")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1025")]
	public  CqlValueSet Preventive_Care_Services_Established_Office_Visit__18_and_Up(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1025", default);

    [CqlDeclaration("Preventive Care Services Group Counseling")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1027")]
	public  CqlValueSet Preventive_Care_Services_Group_Counseling(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1027", default);

    [CqlDeclaration("Preventive Care Services Individual Counseling")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1026")]
	public  CqlValueSet Preventive_Care_Services_Individual_Counseling(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1026", default);

    [CqlDeclaration("Preventive Care Services Initial Office Visit, 18 and Up")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1023")]
	public  CqlValueSet Preventive_Care_Services_Initial_Office_Visit__18_and_Up(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1023", default);

    [CqlDeclaration("Preventive Care Services, Initial Office Visit, 0 to 17")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1022")]
	public  CqlValueSet Preventive_Care_Services__Initial_Office_Visit__0_to_17(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1022", default);

    [CqlDeclaration("Preventive Care, Established Office Visit, 0 to 17")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1024")]
	public  CqlValueSet Preventive_Care__Established_Office_Visit__0_to_17(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1024", default);

    [CqlDeclaration("Telephone Visits")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1080")]
	public  CqlValueSet Telephone_Visits(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1080", default);

    [CqlDeclaration("Upper Respiratory Infection")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.102.12.1022")]
	public  CqlValueSet Upper_Respiratory_Infection(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.102.12.1022", default);

    [CqlDeclaration("Unlisted preventive medicine service")]
	public  CqlCode Unlisted_preventive_medicine_service(CqlContext context) => 
		new CqlCode("99429", "http://www.ama-assn.org/go/cpt", default, default);

    [CqlDeclaration("CPT")]
	public  CqlCode[] CPT(CqlContext context)
	{
		CqlCode[] a_ = [
			new CqlCode("99429", "http://www.ama-assn.org/go/cpt", default, default),
		];

		return a_;
	}

    [CqlDeclaration("Measurement Period")]
	public  CqlInterval<CqlDateTime> Measurement_Period(CqlContext context)
	{
		CqlDateTime a_ = context.Operators.DateTime(2025, 1, 1, 0, 0, 0, 0, default);
		CqlDateTime b_ = context.Operators.DateTime(2026, 1, 1, 0, 0, 0, 0, default);
		CqlInterval<CqlDateTime> c_ = context.Operators.Interval(a_, b_, true, false);
		object d_ = context.ResolveParameter("AppropriateTreatmentforUpperRespiratoryInfectionURIFHIR-0.1.000", "Measurement Period", c_);

		return (CqlInterval<CqlDateTime>)d_;
	}

    [CqlDeclaration("Patient")]
	public  Patient Patient(CqlContext context)
	{
		IEnumerable<Patient> a_ = context.Operators.RetrieveByValueSet<Patient>(default, default);
		Patient b_ = context.Operators.SingletonFrom<Patient>(a_);

		return b_;
	}

    [CqlDeclaration("SDE Ethnicity")]
	public  (IEnumerable<CqlCode> codes, string display)? SDE_Ethnicity(CqlContext context)
	{
		(IEnumerable<CqlCode> codes, string display)? a_ = supplementalDataElements_3_4_000.SDE_Ethnicity(context);

		return a_;
	}

    [CqlDeclaration("SDE Payer")]
	public  IEnumerable<(CqlConcept code, CqlInterval<CqlDateTime> period)?> SDE_Payer(CqlContext context)
	{
		IEnumerable<(CqlConcept code, CqlInterval<CqlDateTime> period)?> a_ = supplementalDataElements_3_4_000.SDE_Payer(context);

		return a_;
	}

    [CqlDeclaration("SDE Race")]
	public  (IEnumerable<CqlCode> codes, string display)? SDE_Race(CqlContext context)
	{
		(IEnumerable<CqlCode> codes, string display)? a_ = supplementalDataElements_3_4_000.SDE_Race(context);

		return a_;
	}

    [CqlDeclaration("SDE Sex")]
	public  CqlCode SDE_Sex(CqlContext context)
	{
		CqlCode a_ = supplementalDataElements_3_4_000.SDE_Sex(context);

		return a_;
	}

    [CqlDeclaration("Qualifying Encounters")]
	public  IEnumerable<Encounter> Qualifying_Encounters(CqlContext context)
	{
		CqlValueSet a_ = this.Emergency_Department_Evaluation_and_Management_Visit(context);
		IEnumerable<Encounter> b_ = context.Operators.RetrieveByValueSet<Encounter>(a_, default);
		CqlValueSet c_ = this.Home_Healthcare_Services(context);
		IEnumerable<Encounter> d_ = context.Operators.RetrieveByValueSet<Encounter>(c_, default);
		IEnumerable<Encounter> e_ = context.Operators.Union<Encounter>(b_, d_);
		CqlValueSet f_ = this.Initial_Hospital_Observation_Care(context);
		IEnumerable<Encounter> g_ = context.Operators.RetrieveByValueSet<Encounter>(f_, default);
		CqlValueSet h_ = this.Medical_Disability_Exam(context);
		IEnumerable<Encounter> i_ = context.Operators.RetrieveByValueSet<Encounter>(h_, default);
		IEnumerable<Encounter> j_ = context.Operators.Union<Encounter>(g_, i_);
		IEnumerable<Encounter> k_ = context.Operators.Union<Encounter>(e_, j_);
		CqlValueSet l_ = this.Observation(context);
		IEnumerable<Encounter> m_ = context.Operators.RetrieveByValueSet<Encounter>(l_, default);
		CqlValueSet n_ = this.Office_Visit(context);
		IEnumerable<Encounter> o_ = context.Operators.RetrieveByValueSet<Encounter>(n_, default);
		IEnumerable<Encounter> p_ = context.Operators.Union<Encounter>(m_, o_);
		IEnumerable<Encounter> q_ = context.Operators.Union<Encounter>(k_, p_);
		CqlValueSet r_ = this.Outpatient_Consultation(context);
		IEnumerable<Encounter> s_ = context.Operators.RetrieveByValueSet<Encounter>(r_, default);
		CqlValueSet t_ = this.Preventive_Care_Services_Group_Counseling(context);
		IEnumerable<Encounter> u_ = context.Operators.RetrieveByValueSet<Encounter>(t_, default);
		IEnumerable<Encounter> v_ = context.Operators.Union<Encounter>(s_, u_);
		IEnumerable<Encounter> w_ = context.Operators.Union<Encounter>(q_, v_);
		CqlValueSet x_ = this.Preventive_Care_Services_Individual_Counseling(context);
		IEnumerable<Encounter> y_ = context.Operators.RetrieveByValueSet<Encounter>(x_, default);
		CqlValueSet z_ = this.Preventive_Care_Services__Initial_Office_Visit__0_to_17(context);
		IEnumerable<Encounter> aa_ = context.Operators.RetrieveByValueSet<Encounter>(z_, default);
		IEnumerable<Encounter> ab_ = context.Operators.Union<Encounter>(y_, aa_);
		IEnumerable<Encounter> ac_ = context.Operators.Union<Encounter>(w_, ab_);
		CqlValueSet ad_ = this.Preventive_Care__Established_Office_Visit__0_to_17(context);
		IEnumerable<Encounter> ae_ = context.Operators.RetrieveByValueSet<Encounter>(ad_, default);
		CqlValueSet af_ = this.Preventive_Care_Services_Established_Office_Visit__18_and_Up(context);
		IEnumerable<Encounter> ag_ = context.Operators.RetrieveByValueSet<Encounter>(af_, default);
		IEnumerable<Encounter> ah_ = context.Operators.Union<Encounter>(ae_, ag_);
		IEnumerable<Encounter> ai_ = context.Operators.Union<Encounter>(ac_, ah_);
		CqlValueSet aj_ = this.Preventive_Care_Services_Initial_Office_Visit__18_and_Up(context);
		IEnumerable<Encounter> ak_ = context.Operators.RetrieveByValueSet<Encounter>(aj_, default);
		CqlValueSet al_ = this.Telephone_Visits(context);
		IEnumerable<Encounter> am_ = context.Operators.RetrieveByValueSet<Encounter>(al_, default);
		IEnumerable<Encounter> an_ = context.Operators.Union<Encounter>(ak_, am_);
		IEnumerable<Encounter> ao_ = context.Operators.Union<Encounter>(ai_, an_);
		CqlValueSet ap_ = this.Online_Assessments(context);
		IEnumerable<Encounter> aq_ = context.Operators.RetrieveByValueSet<Encounter>(ap_, default);
		IEnumerable<Encounter> ar_ = context.Operators.RetrieveByValueSet<Encounter>(default, default);
		bool? as_(Encounter E)
		{
			List<CodeableConcept> az_ = E?.Type;
			CqlConcept ba_(CodeableConcept @this)
			{
				CqlConcept bf_ = fhirHelpers_4_3_000.ToConcept(context, @this);

				return bf_;
			};
			IEnumerable<CqlConcept> bb_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)az_, ba_);
			bool? bc_(CqlConcept T)
			{
				CqlCode bg_ = this.Unlisted_preventive_medicine_service(context);
				CqlConcept bh_ = context.Operators.ConvertCodeToConcept(bg_);
				bool? bi_ = context.Operators.Equivalent(T, bh_);

				return bi_;
			};
			IEnumerable<CqlConcept> bd_ = context.Operators.Where<CqlConcept>(bb_, bc_);
			bool? be_ = context.Operators.Exists<CqlConcept>(bd_);

			return be_;
		};
		IEnumerable<Encounter> at_ = context.Operators.Where<Encounter>(ar_, as_);
		IEnumerable<Encounter> au_ = context.Operators.Union<Encounter>(aq_, at_);
		IEnumerable<Encounter> av_ = context.Operators.Union<Encounter>(ao_, au_);
		IEnumerable<Encounter> aw_ = status_1_6_000.Finished_Encounter(context, av_);
		bool? ax_(Encounter ValidEncounter)
		{
			Period bj_ = ValidEncounter?.Period;
			CqlInterval<CqlDateTime> bk_ = fhirHelpers_4_3_000.ToInterval(context, bj_);
			CqlInterval<CqlDateTime> bl_ = qiCoreCommon_2_0_000.ToInterval(context, bk_ as object);
			CqlDateTime bm_ = context.Operators.End(bl_);
			CqlInterval<CqlDateTime> bn_ = this.Measurement_Period(context);
			CqlDateTime bo_ = context.Operators.Start(bn_);
			CqlDateTime bq_ = context.Operators.End(bn_);
			CqlQuantity br_ = context.Operators.Quantity(3m, "days");
			CqlDateTime bs_ = context.Operators.Subtract(bq_, br_);
			CqlInterval<CqlDateTime> bt_ = context.Operators.Interval(bo_, bs_, true, true);
			bool? bu_ = context.Operators.In<CqlDateTime>(bm_, bt_, "day");

			return bu_;
		};
		IEnumerable<Encounter> ay_ = context.Operators.Where<Encounter>(aw_, ax_);

		return ay_;
	}

    [CqlDeclaration("Encounter with Upper Respiratory Infection")]
	public  IEnumerable<Encounter> Encounter_with_Upper_Respiratory_Infection(CqlContext context)
	{
		IEnumerable<Encounter> a_ = this.Qualifying_Encounters(context);
		CqlValueSet b_ = this.Upper_Respiratory_Infection(context);
		IEnumerable<Condition> c_ = context.Operators.RetrieveByValueSet<Condition>(b_, default);
		IEnumerable<ValueTuple<Encounter, Condition>> d_ = context.Operators.CrossJoin<Encounter, Condition>(a_, c_);
		(Encounter QualifyingEncounters, Condition URI)? e_(ValueTuple<Encounter, Condition> _valueTuple)
		{
			(Encounter QualifyingEncounters, Condition URI)? k_ = (_valueTuple.Item1, _valueTuple.Item2);

			return k_;
		};
		IEnumerable<(Encounter QualifyingEncounters, Condition URI)?> f_ = context.Operators.Select<ValueTuple<Encounter, Condition>, (Encounter QualifyingEncounters, Condition URI)?>(d_, e_);
		bool? g_((Encounter QualifyingEncounters, Condition URI)? tuple_figmirinmncaavfkbmahdktce)
		{
			CqlInterval<CqlDateTime> l_ = qiCoreCommon_2_0_000.ToPrevalenceInterval(context, tuple_figmirinmncaavfkbmahdktce?.URI);
			CqlDateTime m_ = context.Operators.Start(l_);
			Period n_ = tuple_figmirinmncaavfkbmahdktce?.QualifyingEncounters?.Period;
			CqlInterval<CqlDateTime> o_ = fhirHelpers_4_3_000.ToInterval(context, n_);
			CqlInterval<CqlDateTime> p_ = qiCoreCommon_2_0_000.ToInterval(context, o_ as object);
			bool? q_ = context.Operators.In<CqlDateTime>(m_, p_, "day");
			CqlInterval<CqlDateTime> t_ = fhirHelpers_4_3_000.ToInterval(context, n_);
			CqlInterval<CqlDateTime> u_ = qiCoreCommon_2_0_000.ToInterval(context, t_ as object);
			bool? v_ = context.Operators.OverlapsBefore(l_, u_, default);
			bool? w_ = context.Operators.Or(q_, v_);

			return w_;
		};
		IEnumerable<(Encounter QualifyingEncounters, Condition URI)?> h_ = context.Operators.Where<(Encounter QualifyingEncounters, Condition URI)?>(f_, g_);
		Encounter i_((Encounter QualifyingEncounters, Condition URI)? tuple_figmirinmncaavfkbmahdktce) => 
			tuple_figmirinmncaavfkbmahdktce?.QualifyingEncounters;
		IEnumerable<Encounter> j_ = context.Operators.Select<(Encounter QualifyingEncounters, Condition URI)?, Encounter>(h_, i_);

		return j_;
	}

    [CqlDeclaration("Initial Population")]
	public  IEnumerable<Encounter> Initial_Population(CqlContext context)
	{
		IEnumerable<Encounter> a_ = this.Encounter_with_Upper_Respiratory_Infection(context);
		bool? b_(Encounter EncounterWithURI)
		{
			Patient f_ = this.Patient(context);
			Date g_ = f_?.BirthDateElement;
			string h_ = g_?.Value;
			CqlDate i_ = context.Operators.ConvertStringToDate(h_);
			CqlInterval<CqlDateTime> j_ = this.Measurement_Period(context);
			CqlDateTime k_ = context.Operators.Start(j_);
			CqlDate l_ = context.Operators.DateFrom(k_);
			int? m_ = context.Operators.CalculateAgeAt(i_, l_, "month");
			bool? n_ = context.Operators.GreaterOrEqual(m_, 3);

			return n_;
		};
		IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);
		Encounter d_(Encounter EncounterWithURI) => 
			EncounterWithURI;
		IEnumerable<Encounter> e_ = context.Operators.Select<Encounter, Encounter>(c_, d_);

		return e_;
	}

    [CqlDeclaration("Encounters and Assessments with Hospice Patient")]
	public  IEnumerable<Encounter> Encounters_and_Assessments_with_Hospice_Patient(CqlContext context)
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

    [CqlDeclaration("Denominator")]
	public  IEnumerable<Encounter> Denominator(CqlContext context)
	{
		IEnumerable<Encounter> a_ = this.Initial_Population(context);

		return a_;
	}

    [CqlDeclaration("Denominator Exclusions")]
	public  IEnumerable<Encounter> Denominator_Exclusions(CqlContext context)
	{
		IEnumerable<Encounter> a_ = this.Encounters_and_Assessments_with_Hospice_Patient(context);
		IEnumerable<Encounter> b_ = this.Encounter_with_Upper_Respiratory_Infection(context);
		CqlValueSet c_ = this.Comorbid_Conditions_for_Respiratory_Conditions(context);
		IEnumerable<Condition> d_ = context.Operators.RetrieveByValueSet<Condition>(c_, default);
		IEnumerable<Encounter> e_ = antibiotic_1_5_000.Has_Comorbid_Condition_History(context, b_, d_);
		IEnumerable<Encounter> f_ = context.Operators.Union<Encounter>(a_, e_);
		CqlValueSet h_ = this.Antibiotic_Medications_for_Upper_Respiratory_Infection(context);
		IEnumerable<MedicationRequest> i_ = context.Operators.RetrieveByValueSet<MedicationRequest>(h_, default);
		IEnumerable<MedicationRequest> k_ = context.Operators.RetrieveByValueSet<MedicationRequest>(h_, default);
		IEnumerable<MedicationRequest> l_ = context.Operators.Union<MedicationRequest>(i_, k_);
		IEnumerable<Encounter> m_ = antibiotic_1_5_000.Has_Antibiotic_Medication_History(context, b_, l_);
		CqlValueSet o_ = this.Competing_Conditions_for_Respiratory_Conditions(context);
		IEnumerable<Condition> p_ = context.Operators.RetrieveByValueSet<Condition>(o_, default);
		IEnumerable<Encounter> q_ = antibiotic_1_5_000.Has_Competing_Diagnosis_History(context, b_, p_);
		IEnumerable<Encounter> r_ = context.Operators.Union<Encounter>(m_, q_);
		IEnumerable<Encounter> s_ = context.Operators.Union<Encounter>(f_, r_);

		return s_;
	}

    [CqlDeclaration("Numerator")]
	public  IEnumerable<Encounter> Numerator(CqlContext context)
	{
		IEnumerable<Encounter> a_ = this.Encounter_with_Upper_Respiratory_Infection(context);
		IEnumerable<Encounter> c_(Encounter EncounterWithURI)
		{
			CqlValueSet h_ = this.Antibiotic_Medications_for_Upper_Respiratory_Infection(context);
			IEnumerable<MedicationRequest> i_ = context.Operators.RetrieveByValueSet<MedicationRequest>(h_, default);
			IEnumerable<MedicationRequest> k_ = context.Operators.RetrieveByValueSet<MedicationRequest>(h_, default);
			IEnumerable<MedicationRequest> l_ = context.Operators.Union<MedicationRequest>(i_, k_);
			bool? m_(MedicationRequest OrderedAntibiotic)
			{
				FhirDateTime q_ = OrderedAntibiotic?.AuthoredOnElement;
				CqlDateTime r_ = context.Operators.Convert<CqlDateTime>(q_);
				Period s_ = EncounterWithURI?.Period;
				CqlInterval<CqlDateTime> t_ = fhirHelpers_4_3_000.ToInterval(context, s_);
				CqlInterval<CqlDateTime> u_ = qiCoreCommon_2_0_000.ToInterval(context, t_ as object);
				CqlDateTime v_ = context.Operators.Start(u_);
				CqlInterval<CqlDateTime> x_ = fhirHelpers_4_3_000.ToInterval(context, s_);
				CqlInterval<CqlDateTime> y_ = qiCoreCommon_2_0_000.ToInterval(context, x_ as object);
				CqlDateTime z_ = context.Operators.Start(y_);
				CqlQuantity aa_ = context.Operators.Quantity(3m, "days");
				CqlDateTime ab_ = context.Operators.Add(z_, aa_);
				CqlInterval<CqlDateTime> ac_ = context.Operators.Interval(v_, ab_, true, true);
				bool? ad_ = context.Operators.In<CqlDateTime>(r_, ac_, default);
				CqlInterval<CqlDateTime> af_ = fhirHelpers_4_3_000.ToInterval(context, s_);
				CqlInterval<CqlDateTime> ag_ = qiCoreCommon_2_0_000.ToInterval(context, af_ as object);
				CqlDateTime ah_ = context.Operators.Start(ag_);
				bool? ai_ = context.Operators.Not((bool?)(ah_ is null));
				bool? aj_ = context.Operators.And(ad_, ai_);

				return aj_;
			};
			IEnumerable<MedicationRequest> n_ = context.Operators.Where<MedicationRequest>(l_, m_);
			Encounter o_(MedicationRequest OrderedAntibiotic) => 
				EncounterWithURI;
			IEnumerable<Encounter> p_ = context.Operators.Select<MedicationRequest, Encounter>(n_, o_);

			return p_;
		};
		IEnumerable<Encounter> d_ = context.Operators.SelectMany<Encounter, Encounter>(a_, c_);
		IEnumerable<Encounter> e_ = context.Operators.Except<Encounter>(a_, d_);
		Encounter f_(Encounter EncounterWithURI) => 
			EncounterWithURI;
		IEnumerable<Encounter> g_ = context.Operators.Select<Encounter, Encounter>(e_, f_);

		return g_;
	}

    [CqlDeclaration("Stratification 1")]
	public  IEnumerable<Encounter> Stratification_1(CqlContext context)
	{
		IEnumerable<Encounter> a_ = this.Encounter_with_Upper_Respiratory_Infection(context);
		bool? b_(Encounter EncounterWithURI)
		{
			Patient f_ = this.Patient(context);
			Date g_ = f_?.BirthDateElement;
			string h_ = g_?.Value;
			CqlDate i_ = context.Operators.ConvertStringToDate(h_);
			CqlInterval<CqlDateTime> j_ = this.Measurement_Period(context);
			CqlDateTime k_ = context.Operators.Start(j_);
			CqlDate l_ = context.Operators.DateFrom(k_);
			int? m_ = context.Operators.CalculateAgeAt(i_, l_, "month");
			bool? n_ = context.Operators.GreaterOrEqual(m_, 3);
			Date p_ = f_?.BirthDateElement;
			string q_ = p_?.Value;
			CqlDate r_ = context.Operators.ConvertStringToDate(q_);
			CqlDateTime t_ = context.Operators.Start(j_);
			CqlDate u_ = context.Operators.DateFrom(t_);
			int? v_ = context.Operators.CalculateAgeAt(r_, u_, "year");
			bool? w_ = context.Operators.LessOrEqual(v_, 17);
			bool? x_ = context.Operators.And(n_, w_);

			return x_;
		};
		IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);
		Encounter d_(Encounter EncounterWithURI) => 
			EncounterWithURI;
		IEnumerable<Encounter> e_ = context.Operators.Select<Encounter, Encounter>(c_, d_);

		return e_;
	}

    [CqlDeclaration("Stratification 2")]
	public  IEnumerable<Encounter> Stratification_2(CqlContext context)
	{
		IEnumerable<Encounter> a_ = this.Encounter_with_Upper_Respiratory_Infection(context);
		bool? b_(Encounter EncounterWithURI)
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
		Encounter d_(Encounter EncounterWithURI) => 
			EncounterWithURI;
		IEnumerable<Encounter> e_ = context.Operators.Select<Encounter, Encounter>(c_, d_);

		return e_;
	}

    [CqlDeclaration("Stratification 3")]
	public  IEnumerable<Encounter> Stratification_3(CqlContext context)
	{
		IEnumerable<Encounter> a_ = this.Encounter_with_Upper_Respiratory_Infection(context);
		bool? b_(Encounter EncounterWithURI)
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
		Encounter d_(Encounter EncounterWithURI) => 
			EncounterWithURI;
		IEnumerable<Encounter> e_ = context.Operators.Select<Encounter, Encounter>(c_, d_);

		return e_;
	}

}
