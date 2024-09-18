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
public static partial class ChlamydiaScreeninginWomenFHIR_0_1_000ServiceCollectionExtensions
{
    public static IServiceCollection AddChlamydiaScreeninginWomenFHIR_0_1_000(this IServiceCollection services)
    {
        services.TryAddSingleton<ChlamydiaScreeninginWomenFHIR_0_1_000>();
        services.AddFHIRHelpers_4_3_000();
        services.AddQICoreCommon_2_0_000();
        services.AddCQMCommon_2_0_000();
        services.AddSupplementalDataElements_3_4_000();
        services.AddHospice_6_9_000();
        services.AddCumulativeMedicationDuration_4_0_000();
        services.AddStatus_1_6_000();
        return services;
    }
}

partial class ChlamydiaScreeninginWomenFHIR_0_1_000 : ICqlLibrary
{
    public static void AddLibraryService(IServiceCollection services) =>
        services.AddChlamydiaScreeninginWomenFHIR_0_1_000();
}

[System.CodeDom.Compiler.GeneratedCode(".NET Code Generation", "2.0.3.0")]
[CqlLibrary("ChlamydiaScreeninginWomenFHIR", "0.1.000")]
public partial class ChlamydiaScreeninginWomenFHIR_0_1_000(
    FHIRHelpers_4_3_000 fhirHelpers_4_3_000,
    QICoreCommon_2_0_000 qiCoreCommon_2_0_000,
    CQMCommon_2_0_000 cqmCommon_2_0_000,
    SupplementalDataElements_3_4_000 supplementalDataElements_3_4_000,
    Hospice_6_9_000 hospice_6_9_000,
    CumulativeMedicationDuration_4_0_000 cumulativeMedicationDuration_4_0_000,
    Status_1_6_000 status_1_6_000)
{

    [CqlDeclaration("Chlamydia Screening")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.110.12.1052")]
	public  CqlValueSet Chlamydia_Screening(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.110.12.1052", default);

    [CqlDeclaration("Complications of Pregnancy, Childbirth and the Puerperium")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.111.12.1012")]
	public  CqlValueSet Complications_of_Pregnancy__Childbirth_and_the_Puerperium(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.111.12.1012", default);

    [CqlDeclaration("Contraceptive Medications")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.196.12.1080")]
	public  CqlValueSet Contraceptive_Medications(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.196.12.1080", default);

    [CqlDeclaration("Diagnoses Used to Indicate Sexual Activity")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.111.12.1018")]
	public  CqlValueSet Diagnoses_Used_to_Indicate_Sexual_Activity(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.111.12.1018", default);

    [CqlDeclaration("Diagnostic Studies During Pregnancy")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.111.12.1008")]
	public  CqlValueSet Diagnostic_Studies_During_Pregnancy(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.111.12.1008", default);

    [CqlDeclaration("HIV")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.120.12.1003")]
	public  CqlValueSet HIV(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.120.12.1003", default);

    [CqlDeclaration("Home Healthcare Services")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1016")]
	public  CqlValueSet Home_Healthcare_Services(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1016", default);

    [CqlDeclaration("Isotretinoin")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.196.12.1143")]
	public  CqlValueSet Isotretinoin(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.196.12.1143", default);

    [CqlDeclaration("Lab Tests During Pregnancy")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.111.12.1007")]
	public  CqlValueSet Lab_Tests_During_Pregnancy(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.111.12.1007", default);

    [CqlDeclaration("Lab Tests for Sexually Transmitted Infections")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.110.12.1051")]
	public  CqlValueSet Lab_Tests_for_Sexually_Transmitted_Infections(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.110.12.1051", default);

    [CqlDeclaration("Office Visit")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1001")]
	public  CqlValueSet Office_Visit(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1001", default);

    [CqlDeclaration("Online Assessments")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1089")]
	public  CqlValueSet Online_Assessments(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1089", default);

    [CqlDeclaration("Pap Test")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.108.12.1017")]
	public  CqlValueSet Pap_Test(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.108.12.1017", default);

    [CqlDeclaration("Pregnancy Test")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.111.12.1011")]
	public  CqlValueSet Pregnancy_Test(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.111.12.1011", default);

    [CqlDeclaration("Preventive Care Services Established Office Visit, 18 and Up")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1025")]
	public  CqlValueSet Preventive_Care_Services_Established_Office_Visit__18_and_Up(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1025", default);

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

    [CqlDeclaration("Procedures Used to Indicate Sexual Activity")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.111.12.1017")]
	public  CqlValueSet Procedures_Used_to_Indicate_Sexual_Activity(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.111.12.1017", default);

    [CqlDeclaration("Telephone Visits")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1080")]
	public  CqlValueSet Telephone_Visits(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1080", default);

    [CqlDeclaration("XRay Study")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.198.12.1034")]
	public  CqlValueSet XRay_Study(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.198.12.1034", default);

    [CqlDeclaration("Female")]
	public  CqlCode Female(CqlContext context) => 
		new CqlCode("F", "http://terminology.hl7.org/CodeSystem/v3-AdministrativeGender", default, default);

    [CqlDeclaration("Have you ever had vaginal intercourse [PhenX]")]
	public  CqlCode Have_you_ever_had_vaginal_intercourse__PhenX_(CqlContext context) => 
		new CqlCode("64728-9", "http://loinc.org", default, default);

    [CqlDeclaration("Yes (qualifier value)")]
	public  CqlCode Yes__qualifier_value_(CqlContext context) => 
		new CqlCode("373066001", "http://snomed.info/sct", default, default);

    [CqlDeclaration("AdministrativeGender")]
	public  CqlCode[] AdministrativeGender(CqlContext context)
	{
		CqlCode[] a_ = [
			new CqlCode("F", "http://terminology.hl7.org/CodeSystem/v3-AdministrativeGender", default, default),
		];

		return a_;
	}

    [CqlDeclaration("LOINC")]
	public  CqlCode[] LOINC(CqlContext context)
	{
		CqlCode[] a_ = [
			new CqlCode("64728-9", "http://loinc.org", default, default),
		];

		return a_;
	}

    [CqlDeclaration("SNOMEDCT")]
	public  CqlCode[] SNOMEDCT(CqlContext context)
	{
		CqlCode[] a_ = [
			new CqlCode("373066001", "http://snomed.info/sct", default, default),
		];

		return a_;
	}

    [CqlDeclaration("Measurement Period")]
	public  CqlInterval<CqlDateTime> Measurement_Period(CqlContext context)
	{
		CqlDateTime a_ = context.Operators.DateTime(2025, 1, 1, 0, 0, 0, 0, default);
		CqlDateTime b_ = context.Operators.DateTime(2026, 1, 1, 0, 0, 0, 0, default);
		CqlInterval<CqlDateTime> c_ = context.Operators.Interval(a_, b_, true, false);
		object d_ = context.ResolveParameter("ChlamydiaScreeninginWomenFHIR-0.1.000", "Measurement Period", c_);

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
		CqlValueSet a_ = this.Office_Visit(context);
		IEnumerable<Encounter> b_ = context.Operators.RetrieveByValueSet<Encounter>(a_, default);
		CqlValueSet c_ = this.Preventive_Care_Services_Established_Office_Visit__18_and_Up(context);
		IEnumerable<Encounter> d_ = context.Operators.RetrieveByValueSet<Encounter>(c_, default);
		IEnumerable<Encounter> e_ = context.Operators.Union<Encounter>(b_, d_);
		CqlValueSet f_ = this.Preventive_Care_Services_Initial_Office_Visit__18_and_Up(context);
		IEnumerable<Encounter> g_ = context.Operators.RetrieveByValueSet<Encounter>(f_, default);
		CqlValueSet h_ = this.Preventive_Care_Services__Initial_Office_Visit__0_to_17(context);
		IEnumerable<Encounter> i_ = context.Operators.RetrieveByValueSet<Encounter>(h_, default);
		IEnumerable<Encounter> j_ = context.Operators.Union<Encounter>(g_, i_);
		IEnumerable<Encounter> k_ = context.Operators.Union<Encounter>(e_, j_);
		CqlValueSet l_ = this.Preventive_Care__Established_Office_Visit__0_to_17(context);
		IEnumerable<Encounter> m_ = context.Operators.RetrieveByValueSet<Encounter>(l_, default);
		CqlValueSet n_ = this.Home_Healthcare_Services(context);
		IEnumerable<Encounter> o_ = context.Operators.RetrieveByValueSet<Encounter>(n_, default);
		IEnumerable<Encounter> p_ = context.Operators.Union<Encounter>(m_, o_);
		IEnumerable<Encounter> q_ = context.Operators.Union<Encounter>(k_, p_);
		CqlValueSet r_ = this.Telephone_Visits(context);
		IEnumerable<Encounter> s_ = context.Operators.RetrieveByValueSet<Encounter>(r_, default);
		CqlValueSet t_ = this.Online_Assessments(context);
		IEnumerable<Encounter> u_ = context.Operators.RetrieveByValueSet<Encounter>(t_, default);
		IEnumerable<Encounter> v_ = context.Operators.Union<Encounter>(s_, u_);
		IEnumerable<Encounter> w_ = context.Operators.Union<Encounter>(q_, v_);
		IEnumerable<Encounter> x_ = status_1_6_000.Finished_Encounter(context, w_);
		bool? y_(Encounter ValidEncounters)
		{
			CqlInterval<CqlDateTime> aa_ = this.Measurement_Period(context);
			Period ab_ = ValidEncounters?.Period;
			CqlInterval<CqlDateTime> ac_ = fhirHelpers_4_3_000.ToInterval(context, ab_);
			CqlInterval<CqlDateTime> ad_ = qiCoreCommon_2_0_000.ToInterval(context, ac_ as object);
			bool? ae_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(aa_, ad_, "day");

			return ae_;
		};
		IEnumerable<Encounter> z_ = context.Operators.Where<Encounter>(x_, y_);

		return z_;
	}

    [CqlDeclaration("Has Assessments Identifying Sexual Activity")]
	public  bool? Has_Assessments_Identifying_Sexual_Activity(CqlContext context)
	{
		CqlCode a_ = this.Have_you_ever_had_vaginal_intercourse__PhenX_(context);
		IEnumerable<CqlCode> b_ = context.Operators.ToList<CqlCode>(a_);
		IEnumerable<Observation> c_ = context.Operators.RetrieveByCodes<Observation>(b_, default);
		IEnumerable<Observation> d_ = status_1_6_000.Final_Survey_Observation(context, c_);
		bool? e_(Observation SexualActivityAssessment)
		{
			DataType h_ = SexualActivityAssessment?.Value;
			object i_ = fhirHelpers_4_3_000.ToValue(context, h_);
			CqlCode j_ = this.Yes__qualifier_value_(context);
			CqlConcept k_ = context.Operators.ConvertCodeToConcept(j_);
			bool? l_ = context.Operators.Equivalent(i_ as CqlConcept, k_);
			DataType m_ = SexualActivityAssessment?.Effective;
			object n_ = fhirHelpers_4_3_000.ToValue(context, m_);
			CqlInterval<CqlDateTime> o_ = qiCoreCommon_2_0_000.ToInterval(context, n_);
			CqlInterval<CqlDateTime> p_()
			{
				bool s_()
				{
					CqlInterval<CqlDateTime> t_ = this.Measurement_Period(context);
					CqlDateTime u_ = context.Operators.End(t_);

					return u_ is null;
				};
				if (s_())
				{
					return default;
				}
				else
				{
					CqlInterval<CqlDateTime> v_ = this.Measurement_Period(context);
					CqlDateTime w_ = context.Operators.End(v_);
					CqlDateTime y_ = context.Operators.End(v_);
					CqlInterval<CqlDateTime> z_ = context.Operators.Interval(w_, y_, true, true);

					return z_;
				}
			};
			bool? q_ = context.Operators.SameOrBefore(o_, p_(), default);
			bool? r_ = context.Operators.And(l_, q_);

			return r_;
		};
		IEnumerable<Observation> f_ = context.Operators.Where<Observation>(d_, e_);
		bool? g_ = context.Operators.Exists<Observation>(f_);

		return g_;
	}

    [CqlDeclaration("Has Diagnoses Identifying Sexual Activity")]
	public  bool? Has_Diagnoses_Identifying_Sexual_Activity(CqlContext context)
	{
		CqlValueSet a_ = this.Diagnoses_Used_to_Indicate_Sexual_Activity(context);
		IEnumerable<Condition> b_ = context.Operators.RetrieveByValueSet<Condition>(a_, default);
		CqlValueSet c_ = this.HIV(context);
		IEnumerable<Condition> d_ = context.Operators.RetrieveByValueSet<Condition>(c_, default);
		IEnumerable<Condition> e_ = context.Operators.Union<Condition>(b_, d_);
		CqlValueSet f_ = this.Complications_of_Pregnancy__Childbirth_and_the_Puerperium(context);
		IEnumerable<Condition> g_ = context.Operators.RetrieveByValueSet<Condition>(f_, default);
		IEnumerable<Condition> h_ = context.Operators.Union<Condition>(e_, g_);
		bool? i_(Condition SexualActivityDiagnosis)
		{
			CqlInterval<CqlDateTime> l_ = qiCoreCommon_2_0_000.ToPrevalenceInterval(context, SexualActivityDiagnosis);
			CqlInterval<CqlDateTime> m_ = this.Measurement_Period(context);
			bool? n_ = context.Operators.Overlaps(l_, m_, default);

			return n_;
		};
		IEnumerable<Condition> j_ = context.Operators.Where<Condition>(h_, i_);
		bool? k_ = context.Operators.Exists<Condition>(j_);

		return k_;
	}

    [CqlDeclaration("Has Active Contraceptive Medications")]
	public  bool? Has_Active_Contraceptive_Medications(CqlContext context)
	{
		CqlValueSet a_ = this.Contraceptive_Medications(context);
		IEnumerable<MedicationRequest> b_ = context.Operators.RetrieveByValueSet<MedicationRequest>(a_, default);
		IEnumerable<MedicationRequest> d_ = context.Operators.RetrieveByValueSet<MedicationRequest>(a_, default);
		IEnumerable<MedicationRequest> e_ = context.Operators.Union<MedicationRequest>(b_, d_);
		IEnumerable<MedicationRequest> f_ = status_1_6_000.Active_Medication(context, e_);
		bool? g_(MedicationRequest ActiveContraceptives)
		{
			CqlInterval<CqlDate> j_ = cumulativeMedicationDuration_4_0_000.MedicationRequestPeriod(context, ActiveContraceptives);
			CqlDate k_ = j_?.low;
			CqlDateTime l_ = context.Operators.ConvertDateToDateTime(k_);
			CqlDate n_ = j_?.high;
			CqlDateTime o_ = context.Operators.ConvertDateToDateTime(n_);
			bool? q_ = j_?.lowClosed;
			bool? s_ = j_?.highClosed;
			CqlInterval<CqlDateTime> t_ = context.Operators.Interval(l_, o_, q_, s_);
			CqlInterval<CqlDateTime> u_ = this.Measurement_Period(context);
			bool? v_ = context.Operators.Overlaps(t_, u_, default);

			return v_;
		};
		IEnumerable<MedicationRequest> h_ = context.Operators.Where<MedicationRequest>(f_, g_);
		bool? i_ = context.Operators.Exists<MedicationRequest>(h_);

		return i_;
	}

    [CqlDeclaration("Has Ordered Contraceptive Medications")]
	public  bool? Has_Ordered_Contraceptive_Medications(CqlContext context)
	{
		CqlValueSet a_ = this.Contraceptive_Medications(context);
		IEnumerable<MedicationRequest> b_ = context.Operators.RetrieveByValueSet<MedicationRequest>(a_, default);
		IEnumerable<MedicationRequest> d_ = context.Operators.RetrieveByValueSet<MedicationRequest>(a_, default);
		IEnumerable<MedicationRequest> e_ = context.Operators.Union<MedicationRequest>(b_, d_);
		IEnumerable<MedicationRequest> f_ = status_1_6_000.Active_or_Completed_Medication_Request(context, e_);
		bool? g_(MedicationRequest OrderedContraceptives)
		{
			CqlInterval<CqlDateTime> j_ = this.Measurement_Period(context);
			FhirDateTime k_ = OrderedContraceptives?.AuthoredOnElement;
			CqlDateTime l_ = context.Operators.Convert<CqlDateTime>(k_);
			CqlInterval<CqlDateTime> m_ = qiCoreCommon_2_0_000.ToInterval(context, l_ as object);
			bool? n_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(j_, m_, "day");

			return n_;
		};
		IEnumerable<MedicationRequest> h_ = context.Operators.Where<MedicationRequest>(f_, g_);
		bool? i_ = context.Operators.Exists<MedicationRequest>(h_);

		return i_;
	}

    [CqlDeclaration("Has Laboratory Tests Identifying Sexual Activity But Not Pregnancy")]
	public  bool? Has_Laboratory_Tests_Identifying_Sexual_Activity_But_Not_Pregnancy(CqlContext context)
	{
		CqlValueSet a_ = this.Pap_Test(context);
		IEnumerable<ServiceRequest> b_ = context.Operators.RetrieveByValueSet<ServiceRequest>(a_, default);
		CqlValueSet c_ = this.Lab_Tests_During_Pregnancy(context);
		IEnumerable<ServiceRequest> d_ = context.Operators.RetrieveByValueSet<ServiceRequest>(c_, default);
		IEnumerable<ServiceRequest> e_ = context.Operators.Union<ServiceRequest>(b_, d_);
		CqlValueSet f_ = this.Lab_Tests_for_Sexually_Transmitted_Infections(context);
		IEnumerable<ServiceRequest> g_ = context.Operators.RetrieveByValueSet<ServiceRequest>(f_, default);
		IEnumerable<ServiceRequest> h_ = context.Operators.Union<ServiceRequest>(e_, g_);
		IEnumerable<ServiceRequest> i_ = status_1_6_000.Completed_or_Ongoing_Service_Request(context, h_);
		bool? j_(ServiceRequest LabOrders)
		{
			CqlInterval<CqlDateTime> m_ = this.Measurement_Period(context);
			FhirDateTime n_ = LabOrders?.AuthoredOnElement;
			CqlDateTime o_ = context.Operators.Convert<CqlDateTime>(n_);
			CqlInterval<CqlDateTime> p_ = qiCoreCommon_2_0_000.ToInterval(context, o_ as object);
			bool? q_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(m_, p_, "day");

			return q_;
		};
		IEnumerable<ServiceRequest> k_ = context.Operators.Where<ServiceRequest>(i_, j_);
		bool? l_ = context.Operators.Exists<ServiceRequest>(k_);

		return l_;
	}

    [CqlDeclaration("Has Laboratory Tests Identifying Sexual Activity")]
	public  bool? Has_Laboratory_Tests_Identifying_Sexual_Activity(CqlContext context)
	{
		CqlValueSet a_ = this.Pregnancy_Test(context);
		IEnumerable<ServiceRequest> b_ = context.Operators.RetrieveByValueSet<ServiceRequest>(a_, default);
		IEnumerable<ServiceRequest> c_ = status_1_6_000.Completed_or_Ongoing_Service_Request(context, b_);
		bool? d_(ServiceRequest PregnancyTest)
		{
			CqlInterval<CqlDateTime> i_ = this.Measurement_Period(context);
			FhirDateTime j_ = PregnancyTest?.AuthoredOnElement;
			CqlDateTime k_ = context.Operators.Convert<CqlDateTime>(j_);
			CqlInterval<CqlDateTime> l_ = qiCoreCommon_2_0_000.ToInterval(context, k_ as object);
			bool? m_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(i_, l_, "day");

			return m_;
		};
		IEnumerable<ServiceRequest> e_ = context.Operators.Where<ServiceRequest>(c_, d_);
		bool? f_ = context.Operators.Exists<ServiceRequest>(e_);
		bool? g_ = this.Has_Laboratory_Tests_Identifying_Sexual_Activity_But_Not_Pregnancy(context);
		bool? h_ = context.Operators.Or(f_, g_);

		return h_;
	}

    [CqlDeclaration("Has Diagnostic Studies Identifying Sexual Activity")]
	public  bool? Has_Diagnostic_Studies_Identifying_Sexual_Activity(CqlContext context)
	{
		CqlValueSet a_ = this.Diagnostic_Studies_During_Pregnancy(context);
		IEnumerable<ServiceRequest> b_ = context.Operators.RetrieveByValueSet<ServiceRequest>(a_, default);
		IEnumerable<ServiceRequest> c_ = status_1_6_000.Completed_or_Ongoing_Service_Request(context, b_);
		bool? d_(ServiceRequest SexualActivityDiagnostics)
		{
			CqlInterval<CqlDateTime> g_ = this.Measurement_Period(context);
			FhirDateTime h_ = SexualActivityDiagnostics?.AuthoredOnElement;
			CqlDateTime i_ = context.Operators.Convert<CqlDateTime>(h_);
			CqlInterval<CqlDateTime> j_ = qiCoreCommon_2_0_000.ToInterval(context, i_ as object);
			bool? k_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(g_, j_, "day");

			return k_;
		};
		IEnumerable<ServiceRequest> e_ = context.Operators.Where<ServiceRequest>(c_, d_);
		bool? f_ = context.Operators.Exists<ServiceRequest>(e_);

		return f_;
	}

    [CqlDeclaration("Has Procedures Identifying Sexual Activity")]
	public  bool? Has_Procedures_Identifying_Sexual_Activity(CqlContext context)
	{
		CqlValueSet a_ = this.Procedures_Used_to_Indicate_Sexual_Activity(context);
		IEnumerable<Procedure> b_ = context.Operators.RetrieveByValueSet<Procedure>(a_, default);
		IEnumerable<Procedure> c_ = status_1_6_000.Completed_Procedure(context, b_);
		bool? d_(Procedure ProceduresForSexualActivity)
		{
			CqlInterval<CqlDateTime> g_ = this.Measurement_Period(context);
			DataType h_ = ProceduresForSexualActivity?.Performed;
			object i_ = fhirHelpers_4_3_000.ToValue(context, h_);
			CqlInterval<CqlDateTime> j_ = qiCoreCommon_2_0_000.ToInterval(context, i_);
			bool? k_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(g_, j_, "day");

			return k_;
		};
		IEnumerable<Procedure> e_ = context.Operators.Where<Procedure>(c_, d_);
		bool? f_ = context.Operators.Exists<Procedure>(e_);

		return f_;
	}

    [CqlDeclaration("Initial Population")]
	public  bool? Initial_Population(CqlContext context)
	{
		Patient a_ = this.Patient(context);
		Date b_ = a_?.BirthDateElement;
		string c_ = b_?.Value;
		CqlDate d_ = context.Operators.ConvertStringToDate(c_);
		CqlInterval<CqlDateTime> e_ = this.Measurement_Period(context);
		CqlDateTime f_ = context.Operators.End(e_);
		CqlDate g_ = context.Operators.DateFrom(f_);
		int? h_ = context.Operators.CalculateAgeAt(d_, g_, "year");
		CqlInterval<int?> i_ = context.Operators.Interval(16, 24, true, true);
		bool? j_ = context.Operators.In<int?>(h_, i_, default);
		Code<AdministrativeGender> l_ = a_?.GenderElement;
		AdministrativeGender? m_ = l_?.Value;
		string n_ = context.Operators.Convert<string>(m_);
		bool? o_ = context.Operators.Equal(n_, "female");
		bool? p_ = context.Operators.And(j_, o_);
		IEnumerable<Encounter> q_ = this.Qualifying_Encounters(context);
		bool? r_ = context.Operators.Exists<Encounter>(q_);
		bool? s_ = context.Operators.And(p_, r_);
		bool? t_ = this.Has_Assessments_Identifying_Sexual_Activity(context);
		bool? u_ = this.Has_Diagnoses_Identifying_Sexual_Activity(context);
		bool? v_ = context.Operators.Or(t_, u_);
		bool? w_ = this.Has_Active_Contraceptive_Medications(context);
		bool? x_ = context.Operators.Or(v_, w_);
		bool? y_ = this.Has_Ordered_Contraceptive_Medications(context);
		bool? z_ = context.Operators.Or(x_, y_);
		bool? aa_ = this.Has_Laboratory_Tests_Identifying_Sexual_Activity(context);
		bool? ab_ = context.Operators.Or(z_, aa_);
		bool? ac_ = this.Has_Diagnostic_Studies_Identifying_Sexual_Activity(context);
		bool? ad_ = context.Operators.Or(ab_, ac_);
		bool? ae_ = this.Has_Procedures_Identifying_Sexual_Activity(context);
		bool? af_ = context.Operators.Or(ad_, ae_);
		bool? ag_ = context.Operators.And(s_, af_);

		return ag_;
	}

    [CqlDeclaration("Denominator")]
	public  bool? Denominator(CqlContext context)
	{
		bool? a_ = this.Initial_Population(context);

		return a_;
	}

    [CqlDeclaration("Has Pregnancy Test Exclusion")]
	public  bool? Has_Pregnancy_Test_Exclusion(CqlContext context)
	{
		CqlValueSet a_ = this.Pregnancy_Test(context);
		IEnumerable<ServiceRequest> b_ = context.Operators.RetrieveByValueSet<ServiceRequest>(a_, default);
		IEnumerable<ServiceRequest> c_ = status_1_6_000.Completed_or_Ongoing_Service_Request(context, b_);
		IEnumerable<ServiceRequest> d_(ServiceRequest PregnancyTest)
		{
			CqlValueSet m_ = this.XRay_Study(context);
			IEnumerable<ServiceRequest> n_ = context.Operators.RetrieveByValueSet<ServiceRequest>(m_, default);
			IEnumerable<ServiceRequest> o_ = status_1_6_000.Completed_or_Ongoing_Service_Request(context, n_);
			bool? p_(ServiceRequest XrayOrder)
			{
				FhirDateTime t_ = XrayOrder?.AuthoredOnElement;
				CqlDateTime u_ = context.Operators.Convert<CqlDateTime>(t_);
				CqlInterval<CqlDateTime> v_ = qiCoreCommon_2_0_000.ToInterval(context, u_ as object);
				CqlDateTime w_ = context.Operators.Start(v_);
				FhirDateTime x_ = PregnancyTest?.AuthoredOnElement;
				CqlDateTime y_ = context.Operators.Convert<CqlDateTime>(x_);
				CqlInterval<CqlDateTime> z_ = qiCoreCommon_2_0_000.ToInterval(context, y_ as object);
				CqlDateTime aa_ = context.Operators.End(z_);
				CqlDateTime ac_ = context.Operators.Convert<CqlDateTime>(x_);
				CqlInterval<CqlDateTime> ad_ = qiCoreCommon_2_0_000.ToInterval(context, ac_ as object);
				CqlDateTime ae_ = context.Operators.End(ad_);
				CqlQuantity af_ = context.Operators.Quantity(6m, "days");
				CqlDateTime ag_ = context.Operators.Add(ae_, af_);
				CqlInterval<CqlDateTime> ah_ = context.Operators.Interval(aa_, ag_, true, true);
				bool? ai_ = context.Operators.In<CqlDateTime>(w_, ah_, "day");
				CqlDateTime ak_ = context.Operators.Convert<CqlDateTime>(x_);
				CqlInterval<CqlDateTime> al_ = qiCoreCommon_2_0_000.ToInterval(context, ak_ as object);
				CqlDateTime am_ = context.Operators.End(al_);
				bool? an_ = context.Operators.Not((bool?)(am_ is null));
				bool? ao_ = context.Operators.And(ai_, an_);
				CqlInterval<CqlDateTime> ap_ = this.Measurement_Period(context);
				CqlDateTime ar_ = context.Operators.Convert<CqlDateTime>(x_);
				CqlInterval<CqlDateTime> as_ = qiCoreCommon_2_0_000.ToInterval(context, ar_ as object);
				bool? at_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(ap_, as_, default);
				bool? au_ = context.Operators.And(ao_, at_);

				return au_;
			};
			IEnumerable<ServiceRequest> q_ = context.Operators.Where<ServiceRequest>(o_, p_);
			ServiceRequest r_(ServiceRequest XrayOrder) => 
				PregnancyTest;
			IEnumerable<ServiceRequest> s_ = context.Operators.Select<ServiceRequest, ServiceRequest>(q_, r_);

			return s_;
		};
		IEnumerable<ServiceRequest> e_ = context.Operators.SelectMany<ServiceRequest, ServiceRequest>(c_, d_);
		IEnumerable<ServiceRequest> g_ = context.Operators.RetrieveByValueSet<ServiceRequest>(a_, default);
		IEnumerable<ServiceRequest> h_ = status_1_6_000.Completed_or_Ongoing_Service_Request(context, g_);
		IEnumerable<ServiceRequest> i_(ServiceRequest PregnancyTestOrder)
		{
			CqlValueSet av_ = this.Isotretinoin(context);
			IEnumerable<MedicationRequest> aw_ = context.Operators.RetrieveByValueSet<MedicationRequest>(av_, default);
			IEnumerable<MedicationRequest> ay_ = context.Operators.RetrieveByValueSet<MedicationRequest>(av_, default);
			IEnumerable<MedicationRequest> az_ = context.Operators.Union<MedicationRequest>(aw_, ay_);
			IEnumerable<MedicationRequest> ba_ = status_1_6_000.Active_or_Completed_Medication_Request(context, az_);
			bool? bb_(MedicationRequest AccutaneOrder)
			{
				FhirDateTime bf_ = AccutaneOrder?.AuthoredOnElement;
				CqlDateTime bg_ = context.Operators.Convert<CqlDateTime>(bf_);
				CqlInterval<CqlDateTime> bh_ = qiCoreCommon_2_0_000.ToInterval(context, bg_ as object);
				CqlDateTime bi_ = context.Operators.Start(bh_);
				FhirDateTime bj_ = PregnancyTestOrder?.AuthoredOnElement;
				CqlDateTime bk_ = context.Operators.Convert<CqlDateTime>(bj_);
				CqlInterval<CqlDateTime> bl_ = qiCoreCommon_2_0_000.ToInterval(context, bk_ as object);
				CqlDateTime bm_ = context.Operators.End(bl_);
				CqlDateTime bo_ = context.Operators.Convert<CqlDateTime>(bj_);
				CqlInterval<CqlDateTime> bp_ = qiCoreCommon_2_0_000.ToInterval(context, bo_ as object);
				CqlDateTime bq_ = context.Operators.End(bp_);
				CqlQuantity br_ = context.Operators.Quantity(6m, "days");
				CqlDateTime bs_ = context.Operators.Add(bq_, br_);
				CqlInterval<CqlDateTime> bt_ = context.Operators.Interval(bm_, bs_, true, true);
				bool? bu_ = context.Operators.In<CqlDateTime>(bi_, bt_, "day");
				CqlDateTime bw_ = context.Operators.Convert<CqlDateTime>(bj_);
				CqlInterval<CqlDateTime> bx_ = qiCoreCommon_2_0_000.ToInterval(context, bw_ as object);
				CqlDateTime by_ = context.Operators.End(bx_);
				bool? bz_ = context.Operators.Not((bool?)(by_ is null));
				bool? ca_ = context.Operators.And(bu_, bz_);
				CqlInterval<CqlDateTime> cb_ = this.Measurement_Period(context);
				CqlDateTime cd_ = context.Operators.Convert<CqlDateTime>(bj_);
				CqlInterval<CqlDateTime> ce_ = qiCoreCommon_2_0_000.ToInterval(context, cd_ as object);
				bool? cf_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(cb_, ce_, default);
				bool? cg_ = context.Operators.And(ca_, cf_);

				return cg_;
			};
			IEnumerable<MedicationRequest> bc_ = context.Operators.Where<MedicationRequest>(ba_, bb_);
			ServiceRequest bd_(MedicationRequest AccutaneOrder) => 
				PregnancyTestOrder;
			IEnumerable<ServiceRequest> be_ = context.Operators.Select<MedicationRequest, ServiceRequest>(bc_, bd_);

			return be_;
		};
		IEnumerable<ServiceRequest> j_ = context.Operators.SelectMany<ServiceRequest, ServiceRequest>(h_, i_);
		IEnumerable<ServiceRequest> k_ = context.Operators.Union<ServiceRequest>(e_, j_);
		bool? l_ = context.Operators.Exists<ServiceRequest>(k_);

		return l_;
	}

    [CqlDeclaration("Denominator Exclusions")]
	public  bool? Denominator_Exclusions(CqlContext context)
	{
		bool? a_ = hospice_6_9_000.Has_Hospice_Services(context);
		bool? b_ = this.Has_Pregnancy_Test_Exclusion(context);
		bool? c_ = this.Has_Assessments_Identifying_Sexual_Activity(context);
		bool? d_ = context.Operators.Not(c_);
		bool? e_ = context.Operators.And(b_, d_);
		bool? f_ = this.Has_Diagnoses_Identifying_Sexual_Activity(context);
		bool? g_ = context.Operators.Not(f_);
		bool? h_ = context.Operators.And(e_, g_);
		bool? i_ = this.Has_Active_Contraceptive_Medications(context);
		bool? j_ = context.Operators.Not(i_);
		bool? k_ = context.Operators.And(h_, j_);
		bool? l_ = this.Has_Ordered_Contraceptive_Medications(context);
		bool? m_ = context.Operators.Not(l_);
		bool? n_ = context.Operators.And(k_, m_);
		bool? o_ = this.Has_Laboratory_Tests_Identifying_Sexual_Activity_But_Not_Pregnancy(context);
		bool? p_ = context.Operators.Not(o_);
		bool? q_ = context.Operators.And(n_, p_);
		bool? r_ = this.Has_Diagnostic_Studies_Identifying_Sexual_Activity(context);
		bool? s_ = context.Operators.Not(r_);
		bool? t_ = context.Operators.And(q_, s_);
		bool? u_ = this.Has_Procedures_Identifying_Sexual_Activity(context);
		bool? v_ = context.Operators.Not(u_);
		bool? w_ = context.Operators.And(t_, v_);
		bool? x_ = context.Operators.Or(a_, w_);

		return x_;
	}

    [CqlDeclaration("Numerator")]
	public  bool? Numerator(CqlContext context)
	{
		CqlValueSet a_ = this.Chlamydia_Screening(context);
		IEnumerable<Observation> b_ = context.Operators.RetrieveByValueSet<Observation>(a_, default);
		IEnumerable<Observation> c_ = status_1_6_000.Final_Lab_Observation(context, b_);
		bool? d_(Observation ChlamydiaTest)
		{
			object g_()
			{
				bool o_()
				{
					DataType r_ = ChlamydiaTest?.Effective;
					object s_ = fhirHelpers_4_3_000.ToValue(context, r_);
					bool t_ = s_ is CqlDateTime;

					return t_;
				};
				bool p_()
				{
					DataType u_ = ChlamydiaTest?.Effective;
					object v_ = fhirHelpers_4_3_000.ToValue(context, u_);
					bool w_ = v_ is CqlInterval<CqlDateTime>;

					return w_;
				};
				bool q_()
				{
					DataType x_ = ChlamydiaTest?.Effective;
					object y_ = fhirHelpers_4_3_000.ToValue(context, x_);
					bool z_ = y_ is CqlDateTime;

					return z_;
				};
				if (o_())
				{
					DataType aa_ = ChlamydiaTest?.Effective;
					object ab_ = fhirHelpers_4_3_000.ToValue(context, aa_);

					return (ab_ as CqlDateTime) as object;
				}
				else if (p_())
				{
					DataType ac_ = ChlamydiaTest?.Effective;
					object ad_ = fhirHelpers_4_3_000.ToValue(context, ac_);

					return (ad_ as CqlInterval<CqlDateTime>) as object;
				}
				else if (q_())
				{
					DataType ae_ = ChlamydiaTest?.Effective;
					object af_ = fhirHelpers_4_3_000.ToValue(context, ae_);

					return (af_ as CqlDateTime) as object;
				}
				else
				{
					return null;
				}
			};
			CqlDateTime h_ = qiCoreCommon_2_0_000.Latest(context, g_());
			CqlInterval<CqlDateTime> i_ = this.Measurement_Period(context);
			bool? j_ = context.Operators.In<CqlDateTime>(h_, i_, "day");
			DataType k_ = ChlamydiaTest?.Value;
			object l_ = fhirHelpers_4_3_000.ToValue(context, k_);
			bool? m_ = context.Operators.Not((bool?)(l_ is null));
			bool? n_ = context.Operators.And(j_, m_);

			return n_;
		};
		IEnumerable<Observation> e_ = context.Operators.Where<Observation>(c_, d_);
		bool? f_ = context.Operators.Exists<Observation>(e_);

		return f_;
	}

    [CqlDeclaration("Stratification 1")]
	public  bool? Stratification_1(CqlContext context)
	{
		Patient a_ = this.Patient(context);
		Date b_ = a_?.BirthDateElement;
		string c_ = b_?.Value;
		CqlDate d_ = context.Operators.ConvertStringToDate(c_);
		CqlInterval<CqlDateTime> e_ = this.Measurement_Period(context);
		CqlDateTime f_ = context.Operators.End(e_);
		CqlDate g_ = context.Operators.DateFrom(f_);
		int? h_ = context.Operators.CalculateAgeAt(d_, g_, "year");
		CqlInterval<int?> i_ = context.Operators.Interval(16, 20, true, true);
		bool? j_ = context.Operators.In<int?>(h_, i_, default);

		return j_;
	}

    [CqlDeclaration("Stratification 2")]
	public  bool? Stratification_2(CqlContext context)
	{
		Patient a_ = this.Patient(context);
		Date b_ = a_?.BirthDateElement;
		string c_ = b_?.Value;
		CqlDate d_ = context.Operators.ConvertStringToDate(c_);
		CqlInterval<CqlDateTime> e_ = this.Measurement_Period(context);
		CqlDateTime f_ = context.Operators.End(e_);
		CqlDate g_ = context.Operators.DateFrom(f_);
		int? h_ = context.Operators.CalculateAgeAt(d_, g_, "year");
		CqlInterval<int?> i_ = context.Operators.Interval(21, 24, true, true);
		bool? j_ = context.Operators.In<int?>(h_, i_, default);

		return j_;
	}

}
