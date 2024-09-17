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
[System.CodeDom.Compiler.GeneratedCode(".NET Code Generation", "2.0.3.0")]
[CqlLibrary("FollowUpCareforChildrenPrescribedADHDMedicationADDFHIR", "0.1.000")]
public static class FollowUpCareforChildrenPrescribedADHDMedicationADDFHIR_0_1_000
{

    [CqlDeclaration("Ambulatory")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.122.12.1003")]
	public static CqlValueSet Ambulatory(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.122.12.1003", default);

    [CqlDeclaration("Atomoxetine")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.1170")]
	public static CqlValueSet Atomoxetine(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.1170", default);

    [CqlDeclaration("Behavioral Health Follow up Visit")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1054")]
	public static CqlValueSet Behavioral_Health_Follow_up_Visit(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1054", default);

    [CqlDeclaration("Clonidine")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.1171")]
	public static CqlValueSet Clonidine(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.1171", default);

    [CqlDeclaration("Dexmethylphenidate")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.1172")]
	public static CqlValueSet Dexmethylphenidate(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.1172", default);

    [CqlDeclaration("Dextroamphetamine")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.1173")]
	public static CqlValueSet Dextroamphetamine(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.1173", default);

    [CqlDeclaration("Encounter Inpatient")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.666.5.307")]
	public static CqlValueSet Encounter_Inpatient(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.666.5.307", default);

    [CqlDeclaration("Guanfacine")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.196.11.1252")]
	public static CqlValueSet Guanfacine(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.196.11.1252", default);

    [CqlDeclaration("Home Healthcare Services")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1016")]
	public static CqlValueSet Home_Healthcare_Services(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1016", default);

    [CqlDeclaration("Initial Hospital Observation Care")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1002")]
	public static CqlValueSet Initial_Hospital_Observation_Care(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1002", default);

    [CqlDeclaration("Lisdexamfetamine")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.1174")]
	public static CqlValueSet Lisdexamfetamine(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.1174", default);

    [CqlDeclaration("Mental Behavioral and Neurodevelopmental Disorders")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.105.12.1203")]
	public static CqlValueSet Mental_Behavioral_and_Neurodevelopmental_Disorders(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.105.12.1203", default);

    [CqlDeclaration("Methylphenidate")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.1176")]
	public static CqlValueSet Methylphenidate(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.1176", default);

    [CqlDeclaration("Narcolepsy")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.114.12.1011")]
	public static CqlValueSet Narcolepsy(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.114.12.1011", default);

    [CqlDeclaration("Office Visit")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1001")]
	public static CqlValueSet Office_Visit(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1001", default);

    [CqlDeclaration("Online Assessments")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1089")]
	public static CqlValueSet Online_Assessments(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1089", default);

    [CqlDeclaration("Outpatient Consultation")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1008")]
	public static CqlValueSet Outpatient_Consultation(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1008", default);

    [CqlDeclaration("Preventive Care Services Group Counseling")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1027")]
	public static CqlValueSet Preventive_Care_Services_Group_Counseling(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1027", default);

    [CqlDeclaration("Preventive Care Services Individual Counseling")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1026")]
	public static CqlValueSet Preventive_Care_Services_Individual_Counseling(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1026", default);

    [CqlDeclaration("Preventive Care Services, Initial Office Visit, 0 to 17")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1022")]
	public static CqlValueSet Preventive_Care_Services__Initial_Office_Visit__0_to_17(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1022", default);

    [CqlDeclaration("Preventive Care, Established Office Visit, 0 to 17")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1024")]
	public static CqlValueSet Preventive_Care__Established_Office_Visit__0_to_17(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1024", default);

    [CqlDeclaration("Psych Visit Diagnostic Evaluation")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1492")]
	public static CqlValueSet Psych_Visit_Diagnostic_Evaluation(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1492", default);

    [CqlDeclaration("Psych Visit Psychotherapy")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1496")]
	public static CqlValueSet Psych_Visit_Psychotherapy(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1496", default);

    [CqlDeclaration("Psychotherapy and Pharmacologic Management")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1055")]
	public static CqlValueSet Psychotherapy_and_Pharmacologic_Management(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1055", default);

    [CqlDeclaration("Telephone Visits")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1080")]
	public static CqlValueSet Telephone_Visits(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1080", default);

    [CqlDeclaration("24 HR dexmethylphenidate hydrochloride 40 MG Extended Release Oral Capsule")]
	public static CqlCode _24_HR_dexmethylphenidate_hydrochloride_40_MG_Extended_Release_Oral_Capsule(CqlContext context) => 
		new CqlCode("1006608", "http://www.nlm.nih.gov/research/umls/rxnorm", default, default);

    [CqlDeclaration("methamphetamine hydrochloride 5 MG Oral Tablet")]
	public static CqlCode methamphetamine_hydrochloride_5_MG_Oral_Tablet(CqlContext context) => 
		new CqlCode("977860", "http://www.nlm.nih.gov/research/umls/rxnorm", default, default);

    [CqlDeclaration("RXNORM")]
	public static CqlCode[] RXNORM(CqlContext context)
	{
		CqlCode[] a_ = [
			new CqlCode("1006608", "http://www.nlm.nih.gov/research/umls/rxnorm", default, default),
			new CqlCode("977860", "http://www.nlm.nih.gov/research/umls/rxnorm", default, default),
		];

		return a_;
	}

    [CqlDeclaration("Measurement Period")]
	public static CqlInterval<CqlDateTime> Measurement_Period(CqlContext context)
	{
		CqlDateTime a_ = context.Operators.DateTime(2025, 1, 1, 0, 0, 0, 0, default);
		CqlDateTime b_ = context.Operators.DateTime(2026, 1, 1, 0, 0, 0, 0, default);
		CqlInterval<CqlDateTime> c_ = context.Operators.Interval(a_, b_, true, false);
		object d_ = context.ResolveParameter("FollowUpCareforChildrenPrescribedADHDMedicationADDFHIR-0.1.000", "Measurement Period", c_);

		return (CqlInterval<CqlDateTime>)d_;
	}

    [CqlDeclaration("Patient")]
	public static Patient Patient(CqlContext context)
	{
		IEnumerable<Patient> a_ = context.Operators.RetrieveByValueSet<Patient>(default, default);
		Patient b_ = context.Operators.SingletonFrom<Patient>(a_);

		return b_;
	}

    [CqlDeclaration("March 1 of Year Prior to Measurement Period")]
	public static CqlDateTime March_1_of_Year_Prior_to_Measurement_Period(CqlContext context)
	{
		CqlInterval<CqlDateTime> a_ = FollowUpCareforChildrenPrescribedADHDMedicationADDFHIR_0_1_000.Measurement_Period(context);
		CqlDateTime b_ = context.Operators.Start(a_);
		int? c_ = context.Operators.DateTimeComponentFrom(b_, "year");
		int? d_ = context.Operators.Subtract(c_, 1);
		decimal? e_ = context.Operators.ConvertIntegerToDecimal(0);
		CqlDateTime f_ = context.Operators.DateTime(d_, 3, 1, 0, 0, 0, 0, e_);

		return f_;
	}

    [CqlDeclaration("Last Calendar Day of February of Measurement Period")]
	public static CqlDateTime Last_Calendar_Day_of_February_of_Measurement_Period(CqlContext context)
	{
		CqlInterval<CqlDateTime> a_ = FollowUpCareforChildrenPrescribedADHDMedicationADDFHIR_0_1_000.Measurement_Period(context);
		CqlDateTime b_ = context.Operators.Start(a_);
		int? c_ = context.Operators.DateTimeComponentFrom(b_, "year");
		decimal? d_ = context.Operators.ConvertIntegerToDecimal(0);
		CqlDateTime e_ = context.Operators.DateTime(c_, 3, 1, 23, 59, 59, 0, d_);
		CqlQuantity f_ = context.Operators.Quantity(1m, "day");
		CqlDateTime g_ = context.Operators.Subtract(e_, f_);

		return g_;
	}

    [CqlDeclaration("Intake Period")]
	public static CqlInterval<CqlDateTime> Intake_Period(CqlContext context)
	{
		CqlDateTime a_ = FollowUpCareforChildrenPrescribedADHDMedicationADDFHIR_0_1_000.March_1_of_Year_Prior_to_Measurement_Period(context);
		CqlDateTime b_ = FollowUpCareforChildrenPrescribedADHDMedicationADDFHIR_0_1_000.Last_Calendar_Day_of_February_of_Measurement_Period(context);
		CqlInterval<CqlDateTime> c_ = context.Operators.Interval(a_, b_, true, true);

		return c_;
	}

    [CqlDeclaration("ADHD Medication Prescribed During Intake Period and Not Previously on ADHD Medication")]
	public static IEnumerable<(CqlDate startDate, nint _)?> ADHD_Medication_Prescribed_During_Intake_Period_and_Not_Previously_on_ADHD_Medication(CqlContext context)
	{
		CqlValueSet a_ = FollowUpCareforChildrenPrescribedADHDMedicationADDFHIR_0_1_000.Atomoxetine(context);
		IEnumerable<MedicationRequest> b_ = context.Operators.RetrieveByValueSet<MedicationRequest>(a_, default);
		IEnumerable<MedicationRequest> d_ = context.Operators.RetrieveByValueSet<MedicationRequest>(a_, default);
		IEnumerable<MedicationRequest> e_ = context.Operators.Union<MedicationRequest>(b_, d_);
		CqlValueSet f_ = FollowUpCareforChildrenPrescribedADHDMedicationADDFHIR_0_1_000.Clonidine(context);
		IEnumerable<MedicationRequest> g_ = context.Operators.RetrieveByValueSet<MedicationRequest>(f_, default);
		IEnumerable<MedicationRequest> i_ = context.Operators.RetrieveByValueSet<MedicationRequest>(f_, default);
		IEnumerable<MedicationRequest> j_ = context.Operators.Union<MedicationRequest>(g_, i_);
		IEnumerable<MedicationRequest> k_ = context.Operators.Union<MedicationRequest>(e_, j_);
		CqlValueSet l_ = FollowUpCareforChildrenPrescribedADHDMedicationADDFHIR_0_1_000.Dexmethylphenidate(context);
		IEnumerable<MedicationRequest> m_ = context.Operators.RetrieveByValueSet<MedicationRequest>(l_, default);
		IEnumerable<MedicationRequest> o_ = context.Operators.RetrieveByValueSet<MedicationRequest>(l_, default);
		IEnumerable<MedicationRequest> p_ = context.Operators.Union<MedicationRequest>(m_, o_);
		IEnumerable<MedicationRequest> q_ = context.Operators.Union<MedicationRequest>(k_, p_);
		CqlValueSet r_ = FollowUpCareforChildrenPrescribedADHDMedicationADDFHIR_0_1_000.Dextroamphetamine(context);
		IEnumerable<MedicationRequest> s_ = context.Operators.RetrieveByValueSet<MedicationRequest>(r_, default);
		IEnumerable<MedicationRequest> u_ = context.Operators.RetrieveByValueSet<MedicationRequest>(r_, default);
		IEnumerable<MedicationRequest> v_ = context.Operators.Union<MedicationRequest>(s_, u_);
		IEnumerable<MedicationRequest> w_ = context.Operators.Union<MedicationRequest>(q_, v_);
		CqlValueSet x_ = FollowUpCareforChildrenPrescribedADHDMedicationADDFHIR_0_1_000.Lisdexamfetamine(context);
		IEnumerable<MedicationRequest> y_ = context.Operators.RetrieveByValueSet<MedicationRequest>(x_, default);
		IEnumerable<MedicationRequest> aa_ = context.Operators.RetrieveByValueSet<MedicationRequest>(x_, default);
		IEnumerable<MedicationRequest> ab_ = context.Operators.Union<MedicationRequest>(y_, aa_);
		IEnumerable<MedicationRequest> ac_ = context.Operators.Union<MedicationRequest>(w_, ab_);
		CqlCode ad_ = FollowUpCareforChildrenPrescribedADHDMedicationADDFHIR_0_1_000.methamphetamine_hydrochloride_5_MG_Oral_Tablet(context);
		IEnumerable<CqlCode> ae_ = context.Operators.ToList<CqlCode>(ad_);
		IEnumerable<MedicationRequest> af_ = context.Operators.RetrieveByCodes<MedicationRequest>(ae_, default);
		IEnumerable<CqlCode> ah_ = context.Operators.ToList<CqlCode>(ad_);
		IEnumerable<MedicationRequest> ai_ = context.Operators.RetrieveByCodes<MedicationRequest>(ah_, default);
		IEnumerable<MedicationRequest> aj_ = context.Operators.Union<MedicationRequest>(af_, ai_);
		IEnumerable<MedicationRequest> ak_ = context.Operators.Union<MedicationRequest>(ac_, aj_);
		CqlValueSet al_ = FollowUpCareforChildrenPrescribedADHDMedicationADDFHIR_0_1_000.Methylphenidate(context);
		IEnumerable<MedicationRequest> am_ = context.Operators.RetrieveByValueSet<MedicationRequest>(al_, default);
		IEnumerable<MedicationRequest> ao_ = context.Operators.RetrieveByValueSet<MedicationRequest>(al_, default);
		IEnumerable<MedicationRequest> ap_ = context.Operators.Union<MedicationRequest>(am_, ao_);
		IEnumerable<MedicationRequest> aq_ = context.Operators.Union<MedicationRequest>(ak_, ap_);
		CqlValueSet ar_ = FollowUpCareforChildrenPrescribedADHDMedicationADDFHIR_0_1_000.Guanfacine(context);
		IEnumerable<MedicationRequest> as_ = context.Operators.RetrieveByValueSet<MedicationRequest>(ar_, default);
		IEnumerable<MedicationRequest> au_ = context.Operators.RetrieveByValueSet<MedicationRequest>(ar_, default);
		IEnumerable<MedicationRequest> av_ = context.Operators.Union<MedicationRequest>(as_, au_);
		IEnumerable<MedicationRequest> aw_ = context.Operators.Union<MedicationRequest>(aq_, av_);
		bool? ax_(MedicationRequest ADHDMedications)
		{
			CqlInterval<CqlDate> df_ = CumulativeMedicationDuration_4_0_000.MedicationRequestPeriod(context, ADHDMedications);
			CqlDate dg_ = context.Operators.Start(df_);
			CqlDateTime dh_ = context.Operators.ConvertDateToDateTime(dg_);
			CqlInterval<CqlDateTime> di_ = FollowUpCareforChildrenPrescribedADHDMedicationADDFHIR_0_1_000.Intake_Period(context);
			bool? dj_ = context.Operators.In<CqlDateTime>(dh_, di_, default);

			return dj_;
		};
		IEnumerable<MedicationRequest> ay_ = context.Operators.Where<MedicationRequest>(aw_, ax_);
		IEnumerable<MedicationRequest> ba_ = context.Operators.RetrieveByValueSet<MedicationRequest>(a_, default);
		IEnumerable<MedicationRequest> bc_ = context.Operators.RetrieveByValueSet<MedicationRequest>(a_, default);
		IEnumerable<MedicationRequest> bd_ = context.Operators.Union<MedicationRequest>(ba_, bc_);
		IEnumerable<MedicationRequest> bf_ = context.Operators.RetrieveByValueSet<MedicationRequest>(f_, default);
		IEnumerable<MedicationRequest> bh_ = context.Operators.RetrieveByValueSet<MedicationRequest>(f_, default);
		IEnumerable<MedicationRequest> bi_ = context.Operators.Union<MedicationRequest>(bf_, bh_);
		IEnumerable<MedicationRequest> bj_ = context.Operators.Union<MedicationRequest>(bd_, bi_);
		IEnumerable<MedicationRequest> bl_ = context.Operators.RetrieveByValueSet<MedicationRequest>(l_, default);
		IEnumerable<MedicationRequest> bn_ = context.Operators.RetrieveByValueSet<MedicationRequest>(l_, default);
		IEnumerable<MedicationRequest> bo_ = context.Operators.Union<MedicationRequest>(bl_, bn_);
		IEnumerable<MedicationRequest> bp_ = context.Operators.Union<MedicationRequest>(bj_, bo_);
		IEnumerable<MedicationRequest> br_ = context.Operators.RetrieveByValueSet<MedicationRequest>(r_, default);
		IEnumerable<MedicationRequest> bt_ = context.Operators.RetrieveByValueSet<MedicationRequest>(r_, default);
		IEnumerable<MedicationRequest> bu_ = context.Operators.Union<MedicationRequest>(br_, bt_);
		IEnumerable<MedicationRequest> bv_ = context.Operators.Union<MedicationRequest>(bp_, bu_);
		IEnumerable<MedicationRequest> bx_ = context.Operators.RetrieveByValueSet<MedicationRequest>(x_, default);
		IEnumerable<MedicationRequest> bz_ = context.Operators.RetrieveByValueSet<MedicationRequest>(x_, default);
		IEnumerable<MedicationRequest> ca_ = context.Operators.Union<MedicationRequest>(bx_, bz_);
		IEnumerable<MedicationRequest> cb_ = context.Operators.Union<MedicationRequest>(bv_, ca_);
		IEnumerable<CqlCode> cd_ = context.Operators.ToList<CqlCode>(ad_);
		IEnumerable<MedicationRequest> ce_ = context.Operators.RetrieveByCodes<MedicationRequest>(cd_, default);
		IEnumerable<CqlCode> cg_ = context.Operators.ToList<CqlCode>(ad_);
		IEnumerable<MedicationRequest> ch_ = context.Operators.RetrieveByCodes<MedicationRequest>(cg_, default);
		IEnumerable<MedicationRequest> ci_ = context.Operators.Union<MedicationRequest>(ce_, ch_);
		IEnumerable<MedicationRequest> cj_ = context.Operators.Union<MedicationRequest>(cb_, ci_);
		IEnumerable<MedicationRequest> cl_ = context.Operators.RetrieveByValueSet<MedicationRequest>(al_, default);
		IEnumerable<MedicationRequest> cn_ = context.Operators.RetrieveByValueSet<MedicationRequest>(al_, default);
		IEnumerable<MedicationRequest> co_ = context.Operators.Union<MedicationRequest>(cl_, cn_);
		IEnumerable<MedicationRequest> cp_ = context.Operators.Union<MedicationRequest>(cj_, co_);
		IEnumerable<MedicationRequest> cr_ = context.Operators.RetrieveByValueSet<MedicationRequest>(ar_, default);
		IEnumerable<MedicationRequest> ct_ = context.Operators.RetrieveByValueSet<MedicationRequest>(ar_, default);
		IEnumerable<MedicationRequest> cu_ = context.Operators.Union<MedicationRequest>(cr_, ct_);
		IEnumerable<MedicationRequest> cv_ = context.Operators.Union<MedicationRequest>(cp_, cu_);
		bool? cw_(MedicationRequest ADHDMedications)
		{
			CqlInterval<CqlDate> dk_ = CumulativeMedicationDuration_4_0_000.MedicationRequestPeriod(context, ADHDMedications);
			CqlDate dl_ = context.Operators.Start(dk_);
			CqlDateTime dm_ = context.Operators.ConvertDateToDateTime(dl_);
			CqlInterval<CqlDateTime> dn_ = FollowUpCareforChildrenPrescribedADHDMedicationADDFHIR_0_1_000.Intake_Period(context);
			bool? do_ = context.Operators.In<CqlDateTime>(dm_, dn_, default);

			return do_;
		};
		IEnumerable<MedicationRequest> cx_ = context.Operators.Where<MedicationRequest>(cv_, cw_);
		IEnumerable<MedicationRequest> cy_(MedicationRequest ADHDMedicationOrder)
		{
			CqlValueSet dp_ = FollowUpCareforChildrenPrescribedADHDMedicationADDFHIR_0_1_000.Atomoxetine(context);
			IEnumerable<MedicationRequest> dq_ = context.Operators.RetrieveByValueSet<MedicationRequest>(dp_, default);
			IEnumerable<MedicationRequest> ds_ = context.Operators.RetrieveByValueSet<MedicationRequest>(dp_, default);
			IEnumerable<MedicationRequest> dt_ = context.Operators.Union<MedicationRequest>(dq_, ds_);
			CqlValueSet du_ = FollowUpCareforChildrenPrescribedADHDMedicationADDFHIR_0_1_000.Clonidine(context);
			IEnumerable<MedicationRequest> dv_ = context.Operators.RetrieveByValueSet<MedicationRequest>(du_, default);
			IEnumerable<MedicationRequest> dx_ = context.Operators.RetrieveByValueSet<MedicationRequest>(du_, default);
			IEnumerable<MedicationRequest> dy_ = context.Operators.Union<MedicationRequest>(dv_, dx_);
			IEnumerable<MedicationRequest> dz_ = context.Operators.Union<MedicationRequest>(dt_, dy_);
			CqlValueSet ea_ = FollowUpCareforChildrenPrescribedADHDMedicationADDFHIR_0_1_000.Dexmethylphenidate(context);
			IEnumerable<MedicationRequest> eb_ = context.Operators.RetrieveByValueSet<MedicationRequest>(ea_, default);
			IEnumerable<MedicationRequest> ed_ = context.Operators.RetrieveByValueSet<MedicationRequest>(ea_, default);
			IEnumerable<MedicationRequest> ee_ = context.Operators.Union<MedicationRequest>(eb_, ed_);
			IEnumerable<MedicationRequest> ef_ = context.Operators.Union<MedicationRequest>(dz_, ee_);
			CqlValueSet eg_ = FollowUpCareforChildrenPrescribedADHDMedicationADDFHIR_0_1_000.Dextroamphetamine(context);
			IEnumerable<MedicationRequest> eh_ = context.Operators.RetrieveByValueSet<MedicationRequest>(eg_, default);
			IEnumerable<MedicationRequest> ej_ = context.Operators.RetrieveByValueSet<MedicationRequest>(eg_, default);
			IEnumerable<MedicationRequest> ek_ = context.Operators.Union<MedicationRequest>(eh_, ej_);
			IEnumerable<MedicationRequest> el_ = context.Operators.Union<MedicationRequest>(ef_, ek_);
			CqlValueSet em_ = FollowUpCareforChildrenPrescribedADHDMedicationADDFHIR_0_1_000.Lisdexamfetamine(context);
			IEnumerable<MedicationRequest> en_ = context.Operators.RetrieveByValueSet<MedicationRequest>(em_, default);
			IEnumerable<MedicationRequest> ep_ = context.Operators.RetrieveByValueSet<MedicationRequest>(em_, default);
			IEnumerable<MedicationRequest> eq_ = context.Operators.Union<MedicationRequest>(en_, ep_);
			IEnumerable<MedicationRequest> er_ = context.Operators.Union<MedicationRequest>(el_, eq_);
			CqlCode es_ = FollowUpCareforChildrenPrescribedADHDMedicationADDFHIR_0_1_000.methamphetamine_hydrochloride_5_MG_Oral_Tablet(context);
			IEnumerable<CqlCode> et_ = context.Operators.ToList<CqlCode>(es_);
			IEnumerable<MedicationRequest> eu_ = context.Operators.RetrieveByCodes<MedicationRequest>(et_, default);
			IEnumerable<CqlCode> ew_ = context.Operators.ToList<CqlCode>(es_);
			IEnumerable<MedicationRequest> ex_ = context.Operators.RetrieveByCodes<MedicationRequest>(ew_, default);
			IEnumerable<MedicationRequest> ey_ = context.Operators.Union<MedicationRequest>(eu_, ex_);
			IEnumerable<MedicationRequest> ez_ = context.Operators.Union<MedicationRequest>(er_, ey_);
			CqlValueSet fa_ = FollowUpCareforChildrenPrescribedADHDMedicationADDFHIR_0_1_000.Methylphenidate(context);
			IEnumerable<MedicationRequest> fb_ = context.Operators.RetrieveByValueSet<MedicationRequest>(fa_, default);
			IEnumerable<MedicationRequest> fd_ = context.Operators.RetrieveByValueSet<MedicationRequest>(fa_, default);
			IEnumerable<MedicationRequest> fe_ = context.Operators.Union<MedicationRequest>(fb_, fd_);
			IEnumerable<MedicationRequest> ff_ = context.Operators.Union<MedicationRequest>(ez_, fe_);
			CqlValueSet fg_ = FollowUpCareforChildrenPrescribedADHDMedicationADDFHIR_0_1_000.Guanfacine(context);
			IEnumerable<MedicationRequest> fh_ = context.Operators.RetrieveByValueSet<MedicationRequest>(fg_, default);
			IEnumerable<MedicationRequest> fj_ = context.Operators.RetrieveByValueSet<MedicationRequest>(fg_, default);
			IEnumerable<MedicationRequest> fk_ = context.Operators.Union<MedicationRequest>(fh_, fj_);
			IEnumerable<MedicationRequest> fl_ = context.Operators.Union<MedicationRequest>(ff_, fk_);
			bool? fm_(MedicationRequest ActiveADHDMedication)
			{
				CqlInterval<CqlDate> fq_ = CumulativeMedicationDuration_4_0_000.MedicationRequestPeriod(context, ActiveADHDMedication);
				CqlInterval<CqlDate> fr_ = CumulativeMedicationDuration_4_0_000.MedicationRequestPeriod(context, ADHDMedicationOrder);
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
			CqlInterval<CqlDate> gd_ = CumulativeMedicationDuration_4_0_000.MedicationRequestPeriod(context, QualifyingMed);
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

    [CqlDeclaration("First ADHD Medication Prescribed During Intake Period")]
	public static CqlDate First_ADHD_Medication_Prescribed_During_Intake_Period(CqlContext context)
	{
		IEnumerable<(CqlDate startDate, nint _)?> a_ = FollowUpCareforChildrenPrescribedADHDMedicationADDFHIR_0_1_000.ADHD_Medication_Prescribed_During_Intake_Period_and_Not_Previously_on_ADHD_Medication(context);
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

    [CqlDeclaration("IPSD")]
	public static CqlDate IPSD(CqlContext context)
	{
		CqlDate a_ = FollowUpCareforChildrenPrescribedADHDMedicationADDFHIR_0_1_000.First_ADHD_Medication_Prescribed_During_Intake_Period(context);

		return a_;
	}

    [CqlDeclaration("Qualifying Encounter")]
	public static IEnumerable<Encounter> Qualifying_Encounter(CqlContext context)
	{
		CqlValueSet a_ = FollowUpCareforChildrenPrescribedADHDMedicationADDFHIR_0_1_000.Office_Visit(context);
		IEnumerable<Encounter> b_ = context.Operators.RetrieveByValueSet<Encounter>(a_, default);
		CqlValueSet c_ = FollowUpCareforChildrenPrescribedADHDMedicationADDFHIR_0_1_000.Home_Healthcare_Services(context);
		IEnumerable<Encounter> d_ = context.Operators.RetrieveByValueSet<Encounter>(c_, default);
		IEnumerable<Encounter> e_ = context.Operators.Union<Encounter>(b_, d_);
		CqlValueSet f_ = FollowUpCareforChildrenPrescribedADHDMedicationADDFHIR_0_1_000.Preventive_Care__Established_Office_Visit__0_to_17(context);
		IEnumerable<Encounter> g_ = context.Operators.RetrieveByValueSet<Encounter>(f_, default);
		CqlValueSet h_ = FollowUpCareforChildrenPrescribedADHDMedicationADDFHIR_0_1_000.Preventive_Care_Services__Initial_Office_Visit__0_to_17(context);
		IEnumerable<Encounter> i_ = context.Operators.RetrieveByValueSet<Encounter>(h_, default);
		IEnumerable<Encounter> j_ = context.Operators.Union<Encounter>(g_, i_);
		IEnumerable<Encounter> k_ = context.Operators.Union<Encounter>(e_, j_);
		bool? l_(Encounter ValidEncounters)
		{
			CqlDate n_ = FollowUpCareforChildrenPrescribedADHDMedicationADDFHIR_0_1_000.IPSD(context);
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
			CqlInterval<CqlDateTime> ap_ = FHIRHelpers_4_3_000.ToInterval(context, ao_);
			CqlInterval<CqlDateTime> aq_ = QICoreCommon_2_0_000.ToInterval(context, ap_ as object);
			bool? ar_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(an_, aq_, "day");

			return ar_;
		};
		IEnumerable<Encounter> m_ = context.Operators.Where<Encounter>(k_, l_);

		return m_;
	}

    [CqlDeclaration("PrincipalDiagnosis")]
	public static IEnumerable<Condition> PrincipalDiagnosis(CqlContext context, Encounter Encounter)
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
			IEnumerable<Condition> i_ = context.Operators.RetrieveByValueSet<Condition>(default, default);
			bool? j_(Condition C)
			{
				Id m_ = C?.IdElement;
				string n_ = m_?.Value;
				ResourceReference o_ = PD?.Condition;
				FhirString p_ = o_?.ReferenceElement;
				string q_ = p_?.Value;
				string r_ = QICoreCommon_2_0_000.getId(context, q_);
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

    [CqlDeclaration("Inpatient Stay with Qualifying Diagnosis")]
	public static IEnumerable<Encounter> Inpatient_Stay_with_Qualifying_Diagnosis(CqlContext context)
	{
		CqlValueSet a_ = FollowUpCareforChildrenPrescribedADHDMedicationADDFHIR_0_1_000.Encounter_Inpatient(context);
		IEnumerable<Encounter> b_ = context.Operators.RetrieveByValueSet<Encounter>(a_, default);
		bool? c_(Encounter InpatientStay)
		{
			IEnumerable<Condition> e_ = FollowUpCareforChildrenPrescribedADHDMedicationADDFHIR_0_1_000.PrincipalDiagnosis(context, InpatientStay);
			bool? f_(Condition EncounterDiagnosis)
			{
				CodeableConcept i_ = EncounterDiagnosis?.Code;
				CqlConcept j_ = FHIRHelpers_4_3_000.ToConcept(context, i_);
				CqlValueSet k_ = FollowUpCareforChildrenPrescribedADHDMedicationADDFHIR_0_1_000.Mental_Behavioral_and_Neurodevelopmental_Disorders(context);
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

    [CqlDeclaration("Inpatient Stay with Qualifying Diagnosis During Initiation Phase")]
	public static IEnumerable<Encounter> Inpatient_Stay_with_Qualifying_Diagnosis_During_Initiation_Phase(CqlContext context)
	{
		IEnumerable<Encounter> a_ = FollowUpCareforChildrenPrescribedADHDMedicationADDFHIR_0_1_000.Inpatient_Stay_with_Qualifying_Diagnosis(context);
		bool? b_(Encounter InpatientStay)
		{
			Period d_ = InpatientStay?.Period;
			CqlInterval<CqlDateTime> e_ = FHIRHelpers_4_3_000.ToInterval(context, d_);
			CqlInterval<CqlDate> f_ = CQMCommon_2_0_000.ToDateInterval(context, e_);
			CqlDate g_ = context.Operators.Start(f_);
			CqlDate h_ = FollowUpCareforChildrenPrescribedADHDMedicationADDFHIR_0_1_000.IPSD(context);
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

    [CqlDeclaration("Initial Population 1")]
	public static bool? Initial_Population_1(CqlContext context)
	{
		Patient a_ = FollowUpCareforChildrenPrescribedADHDMedicationADDFHIR_0_1_000.Patient(context);
		Date b_ = a_?.BirthDateElement;
		string c_ = b_?.Value;
		CqlDate d_ = context.Operators.ConvertStringToDate(c_);
		CqlInterval<CqlDateTime> e_ = FollowUpCareforChildrenPrescribedADHDMedicationADDFHIR_0_1_000.Intake_Period(context);
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
		IEnumerable<Encounter> t_ = FollowUpCareforChildrenPrescribedADHDMedicationADDFHIR_0_1_000.Qualifying_Encounter(context);
		bool? u_ = context.Operators.Exists<Encounter>(t_);
		bool? v_ = context.Operators.And(s_, u_);
		CqlDate w_ = FollowUpCareforChildrenPrescribedADHDMedicationADDFHIR_0_1_000.First_ADHD_Medication_Prescribed_During_Intake_Period(context);
		bool? x_ = context.Operators.Not((bool?)(w_ is null));
		bool? y_ = context.Operators.And(v_, x_);
		IEnumerable<Encounter> z_ = FollowUpCareforChildrenPrescribedADHDMedicationADDFHIR_0_1_000.Inpatient_Stay_with_Qualifying_Diagnosis_During_Initiation_Phase(context);
		bool? aa_ = context.Operators.Exists<Encounter>(z_);
		bool? ab_ = context.Operators.Not(aa_);
		bool? ac_ = context.Operators.And(y_, ab_);

		return ac_;
	}

    [CqlDeclaration("Denominator 1")]
	public static bool? Denominator_1(CqlContext context)
	{
		bool? a_ = FollowUpCareforChildrenPrescribedADHDMedicationADDFHIR_0_1_000.Initial_Population_1(context);

		return a_;
	}

    [CqlDeclaration("Narcolepsy Exclusion")]
	public static IEnumerable<Condition> Narcolepsy_Exclusion(CqlContext context)
	{
		CqlValueSet a_ = FollowUpCareforChildrenPrescribedADHDMedicationADDFHIR_0_1_000.Narcolepsy(context);
		IEnumerable<Condition> b_ = context.Operators.RetrieveByValueSet<Condition>(a_, default);
		bool? c_(Condition Narcolepsy)
		{
			CqlInterval<CqlDateTime> e_ = QICoreCommon_2_0_000.ToPrevalenceInterval(context, Narcolepsy);
			CqlDateTime f_ = context.Operators.Start(e_);
			CqlInterval<CqlDateTime> g_ = FollowUpCareforChildrenPrescribedADHDMedicationADDFHIR_0_1_000.Measurement_Period(context);
			CqlDateTime h_ = context.Operators.End(g_);
			bool? i_ = context.Operators.SameOrBefore(f_, h_, default);

			return i_;
		};
		IEnumerable<Condition> d_ = context.Operators.Where<Condition>(b_, c_);

		return d_;
	}

    [CqlDeclaration("Denominator Exclusions")]
	public static bool? Denominator_Exclusions(CqlContext context)
	{
		bool? a_ = Hospice_6_9_000.Has_Hospice_Services(context);
		IEnumerable<Condition> b_ = FollowUpCareforChildrenPrescribedADHDMedicationADDFHIR_0_1_000.Narcolepsy_Exclusion(context);
		bool? c_ = context.Operators.Exists<Condition>(b_);
		bool? d_ = context.Operators.Or(a_, c_);

		return d_;
	}

    [CqlDeclaration("Qualifying Numerator Encounter")]
	public static IEnumerable<Encounter> Qualifying_Numerator_Encounter(CqlContext context)
	{
		CqlValueSet a_ = FollowUpCareforChildrenPrescribedADHDMedicationADDFHIR_0_1_000.Office_Visit(context);
		IEnumerable<Encounter> b_ = context.Operators.RetrieveByValueSet<Encounter>(a_, default);
		CqlValueSet c_ = FollowUpCareforChildrenPrescribedADHDMedicationADDFHIR_0_1_000.Initial_Hospital_Observation_Care(context);
		IEnumerable<Encounter> d_ = context.Operators.RetrieveByValueSet<Encounter>(c_, default);
		IEnumerable<Encounter> e_ = context.Operators.Union<Encounter>(b_, d_);
		CqlValueSet f_ = FollowUpCareforChildrenPrescribedADHDMedicationADDFHIR_0_1_000.Preventive_Care_Services_Group_Counseling(context);
		IEnumerable<Encounter> g_ = context.Operators.RetrieveByValueSet<Encounter>(f_, default);
		CqlValueSet h_ = FollowUpCareforChildrenPrescribedADHDMedicationADDFHIR_0_1_000.Behavioral_Health_Follow_up_Visit(context);
		IEnumerable<Encounter> i_ = context.Operators.RetrieveByValueSet<Encounter>(h_, default);
		IEnumerable<Encounter> j_ = context.Operators.Union<Encounter>(g_, i_);
		IEnumerable<Encounter> k_ = context.Operators.Union<Encounter>(e_, j_);
		CqlValueSet l_ = FollowUpCareforChildrenPrescribedADHDMedicationADDFHIR_0_1_000.Preventive_Care_Services_Individual_Counseling(context);
		IEnumerable<Encounter> m_ = context.Operators.RetrieveByValueSet<Encounter>(l_, default);
		CqlValueSet n_ = FollowUpCareforChildrenPrescribedADHDMedicationADDFHIR_0_1_000.Psychotherapy_and_Pharmacologic_Management(context);
		IEnumerable<Encounter> o_ = context.Operators.RetrieveByValueSet<Encounter>(n_, default);
		bool? p_(Encounter PsychPharmManagement)
		{
			List<Encounter.LocationComponent> ao_ = PsychPharmManagement?.Location;
			bool? ap_(Encounter.LocationComponent Location)
			{
				ResourceReference as_ = Location?.Location;
				Location at_ = CQMCommon_2_0_000.GetLocation(context, as_);
				List<CodeableConcept> au_ = at_?.Type;
				CqlConcept av_(CodeableConcept @this)
				{
					CqlConcept az_ = FHIRHelpers_4_3_000.ToConcept(context, @this);

					return az_;
				};
				IEnumerable<CqlConcept> aw_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)au_, av_);
				CqlValueSet ax_ = FollowUpCareforChildrenPrescribedADHDMedicationADDFHIR_0_1_000.Ambulatory(context);
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
		CqlValueSet t_ = FollowUpCareforChildrenPrescribedADHDMedicationADDFHIR_0_1_000.Outpatient_Consultation(context);
		IEnumerable<Encounter> u_ = context.Operators.RetrieveByValueSet<Encounter>(t_, default);
		CqlValueSet v_ = FollowUpCareforChildrenPrescribedADHDMedicationADDFHIR_0_1_000.Home_Healthcare_Services(context);
		IEnumerable<Encounter> w_ = context.Operators.RetrieveByValueSet<Encounter>(v_, default);
		IEnumerable<Encounter> x_ = context.Operators.Union<Encounter>(u_, w_);
		IEnumerable<Encounter> y_ = context.Operators.Union<Encounter>(s_, x_);
		CqlValueSet z_ = FollowUpCareforChildrenPrescribedADHDMedicationADDFHIR_0_1_000.Preventive_Care_Services__Initial_Office_Visit__0_to_17(context);
		IEnumerable<Encounter> aa_ = context.Operators.RetrieveByValueSet<Encounter>(z_, default);
		CqlValueSet ab_ = FollowUpCareforChildrenPrescribedADHDMedicationADDFHIR_0_1_000.Preventive_Care__Established_Office_Visit__0_to_17(context);
		IEnumerable<Encounter> ac_ = context.Operators.RetrieveByValueSet<Encounter>(ab_, default);
		IEnumerable<Encounter> ad_ = context.Operators.Union<Encounter>(aa_, ac_);
		IEnumerable<Encounter> ae_ = context.Operators.Union<Encounter>(y_, ad_);
		CqlValueSet af_ = FollowUpCareforChildrenPrescribedADHDMedicationADDFHIR_0_1_000.Psych_Visit_Diagnostic_Evaluation(context);
		IEnumerable<Encounter> ag_ = context.Operators.RetrieveByValueSet<Encounter>(af_, default);
		CqlValueSet ah_ = FollowUpCareforChildrenPrescribedADHDMedicationADDFHIR_0_1_000.Psych_Visit_Psychotherapy(context);
		IEnumerable<Encounter> ai_ = context.Operators.RetrieveByValueSet<Encounter>(ah_, default);
		IEnumerable<Encounter> aj_ = context.Operators.Union<Encounter>(ag_, ai_);
		IEnumerable<Encounter> ak_ = context.Operators.Union<Encounter>(ae_, aj_);
		CqlValueSet al_ = FollowUpCareforChildrenPrescribedADHDMedicationADDFHIR_0_1_000.Telephone_Visits(context);
		IEnumerable<Encounter> am_ = context.Operators.RetrieveByValueSet<Encounter>(al_, default);
		IEnumerable<Encounter> an_ = context.Operators.Union<Encounter>(ak_, am_);

		return an_;
	}

    [CqlDeclaration("Encounter During Initiation Phase")]
	public static IEnumerable<Encounter> Encounter_During_Initiation_Phase(CqlContext context)
	{
		IEnumerable<Encounter> a_ = FollowUpCareforChildrenPrescribedADHDMedicationADDFHIR_0_1_000.Qualifying_Numerator_Encounter(context);
		bool? b_(Encounter ValidNumeratorEncounter)
		{
			Period d_ = ValidNumeratorEncounter?.Period;
			CqlInterval<CqlDateTime> e_ = FHIRHelpers_4_3_000.ToInterval(context, d_);
			CqlInterval<CqlDate> f_ = CQMCommon_2_0_000.ToDateInterval(context, e_);
			CqlDate g_ = context.Operators.Start(f_);
			CqlDate h_ = FollowUpCareforChildrenPrescribedADHDMedicationADDFHIR_0_1_000.IPSD(context);
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

    [CqlDeclaration("Numerator 1")]
	public static bool? Numerator_1(CqlContext context)
	{
		IEnumerable<Encounter> a_ = FollowUpCareforChildrenPrescribedADHDMedicationADDFHIR_0_1_000.Encounter_During_Initiation_Phase(context);
		bool? b_ = context.Operators.Exists<Encounter>(a_);

		return b_;
	}

    [CqlDeclaration("ADHD Medications Taken on IPSD or During Continuation and Maintenance Phase")]
	public static IEnumerable<CqlInterval<CqlDate>> ADHD_Medications_Taken_on_IPSD_or_During_Continuation_and_Maintenance_Phase(CqlContext context)
	{
		CqlValueSet a_ = FollowUpCareforChildrenPrescribedADHDMedicationADDFHIR_0_1_000.Atomoxetine(context);
		IEnumerable<MedicationRequest> b_ = context.Operators.RetrieveByValueSet<MedicationRequest>(a_, default);
		IEnumerable<MedicationRequest> d_ = context.Operators.RetrieveByValueSet<MedicationRequest>(a_, default);
		IEnumerable<MedicationRequest> e_ = context.Operators.Union<MedicationRequest>(b_, d_);
		(CqlInterval<CqlDate> period, CqlDate periodStart)? f_(MedicationRequest AtomoxetineMed)
		{
			CqlInterval<CqlDate> dt_ = CumulativeMedicationDuration_4_0_000.MedicationRequestPeriod(context, AtomoxetineMed);
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
		IEnumerable<CqlInterval<CqlDate>> n_ = CumulativeMedicationDuration_4_0_000.RolloutIntervals(context, m_);
		CqlValueSet o_ = FollowUpCareforChildrenPrescribedADHDMedicationADDFHIR_0_1_000.Clonidine(context);
		IEnumerable<MedicationRequest> p_ = context.Operators.RetrieveByValueSet<MedicationRequest>(o_, default);
		IEnumerable<MedicationRequest> r_ = context.Operators.RetrieveByValueSet<MedicationRequest>(o_, default);
		IEnumerable<MedicationRequest> s_ = context.Operators.Union<MedicationRequest>(p_, r_);
		(CqlInterval<CqlDate> period, CqlDate periodStart)? t_(MedicationRequest ClonidineMed)
		{
			CqlInterval<CqlDate> eb_ = CumulativeMedicationDuration_4_0_000.MedicationRequestPeriod(context, ClonidineMed);
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
		IEnumerable<CqlInterval<CqlDate>> ab_ = CumulativeMedicationDuration_4_0_000.RolloutIntervals(context, aa_);
		IEnumerable<CqlInterval<CqlDate>> ac_ = context.Operators.Union<CqlInterval<CqlDate>>(n_, ab_);
		CqlValueSet ad_ = FollowUpCareforChildrenPrescribedADHDMedicationADDFHIR_0_1_000.Dexmethylphenidate(context);
		IEnumerable<MedicationRequest> ae_ = context.Operators.RetrieveByValueSet<MedicationRequest>(ad_, default);
		IEnumerable<MedicationRequest> ag_ = context.Operators.RetrieveByValueSet<MedicationRequest>(ad_, default);
		IEnumerable<MedicationRequest> ah_ = context.Operators.Union<MedicationRequest>(ae_, ag_);
		(CqlInterval<CqlDate> period, CqlDate periodStart)? ai_(MedicationRequest DexmethylphenidateMed)
		{
			CqlInterval<CqlDate> ej_ = CumulativeMedicationDuration_4_0_000.MedicationRequestPeriod(context, DexmethylphenidateMed);
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
		IEnumerable<CqlInterval<CqlDate>> aq_ = CumulativeMedicationDuration_4_0_000.RolloutIntervals(context, ap_);
		CqlValueSet ar_ = FollowUpCareforChildrenPrescribedADHDMedicationADDFHIR_0_1_000.Dextroamphetamine(context);
		IEnumerable<MedicationRequest> as_ = context.Operators.RetrieveByValueSet<MedicationRequest>(ar_, default);
		IEnumerable<MedicationRequest> au_ = context.Operators.RetrieveByValueSet<MedicationRequest>(ar_, default);
		IEnumerable<MedicationRequest> av_ = context.Operators.Union<MedicationRequest>(as_, au_);
		(CqlInterval<CqlDate> period, CqlDate periodStart)? aw_(MedicationRequest DextroamphetamineMed)
		{
			CqlInterval<CqlDate> er_ = CumulativeMedicationDuration_4_0_000.MedicationRequestPeriod(context, DextroamphetamineMed);
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
		IEnumerable<CqlInterval<CqlDate>> be_ = CumulativeMedicationDuration_4_0_000.RolloutIntervals(context, bd_);
		IEnumerable<CqlInterval<CqlDate>> bf_ = context.Operators.Union<CqlInterval<CqlDate>>(aq_, be_);
		IEnumerable<CqlInterval<CqlDate>> bg_ = context.Operators.Union<CqlInterval<CqlDate>>(ac_, bf_);
		CqlValueSet bh_ = FollowUpCareforChildrenPrescribedADHDMedicationADDFHIR_0_1_000.Lisdexamfetamine(context);
		IEnumerable<MedicationRequest> bi_ = context.Operators.RetrieveByValueSet<MedicationRequest>(bh_, default);
		IEnumerable<MedicationRequest> bk_ = context.Operators.RetrieveByValueSet<MedicationRequest>(bh_, default);
		IEnumerable<MedicationRequest> bl_ = context.Operators.Union<MedicationRequest>(bi_, bk_);
		(CqlInterval<CqlDate> period, CqlDate periodStart)? bm_(MedicationRequest LisdexamfetamineMed)
		{
			CqlInterval<CqlDate> ez_ = CumulativeMedicationDuration_4_0_000.MedicationRequestPeriod(context, LisdexamfetamineMed);
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
		IEnumerable<CqlInterval<CqlDate>> bu_ = CumulativeMedicationDuration_4_0_000.RolloutIntervals(context, bt_);
		CqlValueSet bv_ = FollowUpCareforChildrenPrescribedADHDMedicationADDFHIR_0_1_000.Methylphenidate(context);
		IEnumerable<MedicationRequest> bw_ = context.Operators.RetrieveByValueSet<MedicationRequest>(bv_, default);
		IEnumerable<MedicationRequest> by_ = context.Operators.RetrieveByValueSet<MedicationRequest>(bv_, default);
		IEnumerable<MedicationRequest> bz_ = context.Operators.Union<MedicationRequest>(bw_, by_);
		(CqlInterval<CqlDate> period, CqlDate periodStart)? ca_(MedicationRequest MethylphenidateMed)
		{
			CqlInterval<CqlDate> fh_ = CumulativeMedicationDuration_4_0_000.MedicationRequestPeriod(context, MethylphenidateMed);
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
		IEnumerable<CqlInterval<CqlDate>> ci_ = CumulativeMedicationDuration_4_0_000.RolloutIntervals(context, ch_);
		IEnumerable<CqlInterval<CqlDate>> cj_ = context.Operators.Union<CqlInterval<CqlDate>>(bu_, ci_);
		IEnumerable<CqlInterval<CqlDate>> ck_ = context.Operators.Union<CqlInterval<CqlDate>>(bg_, cj_);
		CqlValueSet cl_ = FollowUpCareforChildrenPrescribedADHDMedicationADDFHIR_0_1_000.Guanfacine(context);
		IEnumerable<MedicationRequest> cm_ = context.Operators.RetrieveByValueSet<MedicationRequest>(cl_, default);
		IEnumerable<MedicationRequest> co_ = context.Operators.RetrieveByValueSet<MedicationRequest>(cl_, default);
		IEnumerable<MedicationRequest> cp_ = context.Operators.Union<MedicationRequest>(cm_, co_);
		(CqlInterval<CqlDate> period, CqlDate periodStart)? cq_(MedicationRequest GuanfacineMed)
		{
			CqlInterval<CqlDate> fp_ = CumulativeMedicationDuration_4_0_000.MedicationRequestPeriod(context, GuanfacineMed);
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
		IEnumerable<CqlInterval<CqlDate>> cy_ = CumulativeMedicationDuration_4_0_000.RolloutIntervals(context, cx_);
		CqlCode cz_ = FollowUpCareforChildrenPrescribedADHDMedicationADDFHIR_0_1_000.methamphetamine_hydrochloride_5_MG_Oral_Tablet(context);
		IEnumerable<CqlCode> da_ = context.Operators.ToList<CqlCode>(cz_);
		IEnumerable<MedicationRequest> db_ = context.Operators.RetrieveByCodes<MedicationRequest>(da_, default);
		IEnumerable<CqlCode> dd_ = context.Operators.ToList<CqlCode>(cz_);
		IEnumerable<MedicationRequest> de_ = context.Operators.RetrieveByCodes<MedicationRequest>(dd_, default);
		IEnumerable<MedicationRequest> df_ = context.Operators.Union<MedicationRequest>(db_, de_);
		(CqlInterval<CqlDate> period, CqlDate periodStart)? dg_(MedicationRequest MethamphetamineMed)
		{
			CqlInterval<CqlDate> fx_ = CumulativeMedicationDuration_4_0_000.MedicationRequestPeriod(context, MethamphetamineMed);
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
		IEnumerable<CqlInterval<CqlDate>> do_ = CumulativeMedicationDuration_4_0_000.RolloutIntervals(context, dn_);
		IEnumerable<CqlInterval<CqlDate>> dp_ = context.Operators.Union<CqlInterval<CqlDate>>(cy_, do_);
		IEnumerable<CqlInterval<CqlDate>> dq_ = context.Operators.Union<CqlInterval<CqlDate>>(ck_, dp_);
		CqlInterval<CqlDate> dr_(CqlInterval<CqlDate> ADHDMedication)
		{
			CqlDate gf_ = FollowUpCareforChildrenPrescribedADHDMedicationADDFHIR_0_1_000.IPSD(context);
			CqlQuantity gh_ = context.Operators.Quantity(300m, "days");
			CqlDate gi_ = context.Operators.Add(gf_, gh_);
			CqlInterval<CqlDate> gj_ = context.Operators.Interval(gf_, gi_, true, true);
			CqlInterval<CqlDate> gk_ = context.Operators.Intersect<CqlDate>(ADHDMedication, gj_);

			return gk_;
		};
		IEnumerable<CqlInterval<CqlDate>> ds_ = context.Operators.Select<CqlInterval<CqlDate>, CqlInterval<CqlDate>>(dq_, dr_);

		return ds_;
	}

    [CqlDeclaration("ADHD Cumulative Medication Duration")]
	public static int? ADHD_Cumulative_Medication_Duration(CqlContext context)
	{
		IEnumerable<CqlInterval<CqlDate>> a_ = FollowUpCareforChildrenPrescribedADHDMedicationADDFHIR_0_1_000.ADHD_Medications_Taken_on_IPSD_or_During_Continuation_and_Maintenance_Phase(context);
		int? b_ = CumulativeMedicationDuration_4_0_000.CumulativeDuration(context, a_);

		return b_;
	}

    [CqlDeclaration("Has ADHD Cumulative Medication Duration Greater Than or Equal to 210 Days")]
	public static bool? Has_ADHD_Cumulative_Medication_Duration_Greater_Than_or_Equal_to_210_Days(CqlContext context)
	{
		int? a_ = FollowUpCareforChildrenPrescribedADHDMedicationADDFHIR_0_1_000.ADHD_Cumulative_Medication_Duration(context);
		bool? b_ = context.Operators.GreaterOrEqual(a_, 210);

		return b_;
	}

    [CqlDeclaration("Inpatient Stay with Qualifying Diagnosis During Continuation and Maintenance Phase")]
	public static IEnumerable<Encounter> Inpatient_Stay_with_Qualifying_Diagnosis_During_Continuation_and_Maintenance_Phase(CqlContext context)
	{
		IEnumerable<Encounter> a_ = FollowUpCareforChildrenPrescribedADHDMedicationADDFHIR_0_1_000.Inpatient_Stay_with_Qualifying_Diagnosis(context);
		bool? b_(Encounter InpatientStay)
		{
			Period d_ = InpatientStay?.Period;
			CqlInterval<CqlDateTime> e_ = FHIRHelpers_4_3_000.ToInterval(context, d_);
			CqlInterval<CqlDate> f_ = CQMCommon_2_0_000.ToDateInterval(context, e_);
			CqlDate g_ = context.Operators.Start(f_);
			CqlDate h_ = FollowUpCareforChildrenPrescribedADHDMedicationADDFHIR_0_1_000.IPSD(context);
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

    [CqlDeclaration("Initial Population 2")]
	public static bool? Initial_Population_2(CqlContext context)
	{
		Patient a_ = FollowUpCareforChildrenPrescribedADHDMedicationADDFHIR_0_1_000.Patient(context);
		Date b_ = a_?.BirthDateElement;
		string c_ = b_?.Value;
		CqlDate d_ = context.Operators.ConvertStringToDate(c_);
		CqlInterval<CqlDateTime> e_ = FollowUpCareforChildrenPrescribedADHDMedicationADDFHIR_0_1_000.Intake_Period(context);
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
		IEnumerable<Encounter> t_ = FollowUpCareforChildrenPrescribedADHDMedicationADDFHIR_0_1_000.Qualifying_Encounter(context);
		bool? u_ = context.Operators.Exists<Encounter>(t_);
		bool? v_ = context.Operators.And(s_, u_);
		CqlDate w_ = FollowUpCareforChildrenPrescribedADHDMedicationADDFHIR_0_1_000.First_ADHD_Medication_Prescribed_During_Intake_Period(context);
		bool? x_ = context.Operators.Not((bool?)(w_ is null));
		bool? y_ = context.Operators.And(v_, x_);
		bool? z_ = FollowUpCareforChildrenPrescribedADHDMedicationADDFHIR_0_1_000.Has_ADHD_Cumulative_Medication_Duration_Greater_Than_or_Equal_to_210_Days(context);
		bool? aa_ = context.Operators.And(y_, z_);
		IEnumerable<Encounter> ab_ = FollowUpCareforChildrenPrescribedADHDMedicationADDFHIR_0_1_000.Inpatient_Stay_with_Qualifying_Diagnosis_During_Continuation_and_Maintenance_Phase(context);
		bool? ac_ = context.Operators.Exists<Encounter>(ab_);
		bool? ad_ = context.Operators.Not(ac_);
		bool? ae_ = context.Operators.And(aa_, ad_);

		return ae_;
	}

    [CqlDeclaration("Denominator 2")]
	public static bool? Denominator_2(CqlContext context)
	{
		bool? a_ = FollowUpCareforChildrenPrescribedADHDMedicationADDFHIR_0_1_000.Initial_Population_2(context);

		return a_;
	}

    [CqlDeclaration("Encounter 31 to 300 Days into Continuation and Maintenance Phase")]
	public static IEnumerable<CqlDate> Encounter_31_to_300_Days_into_Continuation_and_Maintenance_Phase(CqlContext context)
	{
		IEnumerable<Encounter> a_ = FollowUpCareforChildrenPrescribedADHDMedicationADDFHIR_0_1_000.Qualifying_Numerator_Encounter(context);
		bool? b_(Encounter ValidNumeratorEncounter)
		{
			Period f_ = ValidNumeratorEncounter?.Period;
			CqlInterval<CqlDateTime> g_ = FHIRHelpers_4_3_000.ToInterval(context, f_);
			CqlInterval<CqlDate> h_ = CQMCommon_2_0_000.ToDateInterval(context, g_);
			CqlDate i_ = context.Operators.Start(h_);
			CqlDate j_ = FollowUpCareforChildrenPrescribedADHDMedicationADDFHIR_0_1_000.IPSD(context);
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
			CqlInterval<CqlDateTime> s_ = FHIRHelpers_4_3_000.ToInterval(context, r_);
			CqlDateTime t_ = context.Operators.Start(s_);
			CqlDate u_ = context.Operators.DateFrom(t_);

			return u_;
		};
		IEnumerable<CqlDate> e_ = context.Operators.Select<Encounter, CqlDate>(c_, d_);

		return e_;
	}

    [CqlDeclaration("Two or More Encounters 31 to 300 Days into Continuation and Maintenance Phase")]
	public static bool? Two_or_More_Encounters_31_to_300_Days_into_Continuation_and_Maintenance_Phase(CqlContext context)
	{
		IEnumerable<CqlDate> a_ = FollowUpCareforChildrenPrescribedADHDMedicationADDFHIR_0_1_000.Encounter_31_to_300_Days_into_Continuation_and_Maintenance_Phase(context);
		int? b_ = context.Operators.Count<CqlDate>(a_);
		bool? c_ = context.Operators.GreaterOrEqual(b_, 2);

		return c_;
	}

    [CqlDeclaration("Online Assessment 31 to 300 Days into Continuation and Maintenance Phase")]
	public static IEnumerable<CqlDate> Online_Assessment_31_to_300_Days_into_Continuation_and_Maintenance_Phase(CqlContext context)
	{
		CqlValueSet a_ = FollowUpCareforChildrenPrescribedADHDMedicationADDFHIR_0_1_000.Online_Assessments(context);
		IEnumerable<Encounter> b_ = context.Operators.RetrieveByValueSet<Encounter>(a_, default);
		bool? c_(Encounter OnlineAssessment)
		{
			Period g_ = OnlineAssessment?.Period;
			CqlInterval<CqlDateTime> h_ = FHIRHelpers_4_3_000.ToInterval(context, g_);
			CqlInterval<CqlDate> i_ = CQMCommon_2_0_000.ToDateInterval(context, h_);
			CqlDate j_ = context.Operators.Start(i_);
			CqlDate k_ = FollowUpCareforChildrenPrescribedADHDMedicationADDFHIR_0_1_000.IPSD(context);
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
			CqlInterval<CqlDateTime> t_ = FHIRHelpers_4_3_000.ToInterval(context, s_);
			CqlDateTime u_ = context.Operators.Start(t_);
			CqlDate v_ = context.Operators.DateFrom(u_);

			return v_;
		};
		IEnumerable<CqlDate> f_ = context.Operators.Select<Encounter, CqlDate>(d_, e_);

		return f_;
	}

    [CqlDeclaration("Numerator 2")]
	public static bool? Numerator_2(CqlContext context)
	{
		IEnumerable<Encounter> a_ = FollowUpCareforChildrenPrescribedADHDMedicationADDFHIR_0_1_000.Encounter_During_Initiation_Phase(context);
		bool? b_ = context.Operators.Exists<Encounter>(a_);
		bool? c_ = FollowUpCareforChildrenPrescribedADHDMedicationADDFHIR_0_1_000.Two_or_More_Encounters_31_to_300_Days_into_Continuation_and_Maintenance_Phase(context);
		IEnumerable<CqlDate> d_ = FollowUpCareforChildrenPrescribedADHDMedicationADDFHIR_0_1_000.Encounter_31_to_300_Days_into_Continuation_and_Maintenance_Phase(context);
		IEnumerable<CqlDate> e_(CqlDate Encounter1)
		{
			IEnumerable<CqlDate> j_ = FollowUpCareforChildrenPrescribedADHDMedicationADDFHIR_0_1_000.Online_Assessment_31_to_300_Days_into_Continuation_and_Maintenance_Phase(context);
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

    [CqlDeclaration("SDE Ethnicity")]
	public static (IEnumerable<CqlCode> codes, string display)? SDE_Ethnicity(CqlContext context)
	{
		(IEnumerable<CqlCode> codes, string display)? a_ = SupplementalDataElements_3_4_000.SDE_Ethnicity(context);

		return a_;
	}

    [CqlDeclaration("SDE Payer")]
	public static IEnumerable<(CqlConcept code, CqlInterval<CqlDateTime> period)?> SDE_Payer(CqlContext context)
	{
		IEnumerable<(CqlConcept code, CqlInterval<CqlDateTime> period)?> a_ = SupplementalDataElements_3_4_000.SDE_Payer(context);

		return a_;
	}

    [CqlDeclaration("SDE Race")]
	public static (IEnumerable<CqlCode> codes, string display)? SDE_Race(CqlContext context)
	{
		(IEnumerable<CqlCode> codes, string display)? a_ = SupplementalDataElements_3_4_000.SDE_Race(context);

		return a_;
	}

    [CqlDeclaration("SDE Sex")]
	public static CqlCode SDE_Sex(CqlContext context)
	{
		CqlCode a_ = SupplementalDataElements_3_4_000.SDE_Sex(context);

		return a_;
	}

}
