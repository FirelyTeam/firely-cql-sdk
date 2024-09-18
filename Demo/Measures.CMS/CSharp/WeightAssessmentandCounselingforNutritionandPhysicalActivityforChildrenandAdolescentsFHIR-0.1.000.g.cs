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
public static partial class WeightAssessmentandCounselingforNutritionandPhysicalActivityforChildrenandAdolescentsFHIR_0_1_000ServiceCollectionExtensions
{
    public static IServiceCollection AddWeightAssessmentandCounselingforNutritionandPhysicalActivityforChildrenandAdolescentsFHIR_0_1_000(this IServiceCollection services)
    {
        services.TryAddSingleton<WeightAssessmentandCounselingforNutritionandPhysicalActivityforChildrenandAdolescentsFHIR_0_1_000>();
        services.AddFHIRHelpers_4_3_000();
        services.AddQICoreCommon_2_0_000();
        services.AddSupplementalDataElements_3_4_000();
        services.AddHospice_6_9_000();
        services.AddStatus_1_6_000();
        return services;
    }
}

partial class WeightAssessmentandCounselingforNutritionandPhysicalActivityforChildrenandAdolescentsFHIR_0_1_000 : ICqlLibrary
{
    public static void AddLibraryService(IServiceCollection services) =>
        services.AddWeightAssessmentandCounselingforNutritionandPhysicalActivityforChildrenandAdolescentsFHIR_0_1_000();
}

[System.CodeDom.Compiler.GeneratedCode(".NET Code Generation", "2.0.3.0")]
[CqlLibrary("WeightAssessmentandCounselingforNutritionandPhysicalActivityforChildrenandAdolescentsFHIR", "0.1.000")]
public partial class WeightAssessmentandCounselingforNutritionandPhysicalActivityforChildrenandAdolescentsFHIR_0_1_000(
    FHIRHelpers_4_3_000 fhirHelpers_4_3_000,
    QICoreCommon_2_0_000 qiCoreCommon_2_0_000,
    SupplementalDataElements_3_4_000 supplementalDataElements_3_4_000,
    Hospice_6_9_000 hospice_6_9_000,
    Status_1_6_000 status_1_6_000)
{

    [CqlDeclaration("BMI percentile")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.121.12.1012")]
	public CqlValueSet BMI_percentile(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.121.12.1012", default);

    [CqlDeclaration("Counseling for Nutrition")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.195.12.1003")]
	public CqlValueSet Counseling_for_Nutrition(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.195.12.1003", default);

    [CqlDeclaration("Counseling for Physical Activity")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.118.12.1035")]
	public CqlValueSet Counseling_for_Physical_Activity(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.118.12.1035", default);

    [CqlDeclaration("Discharged to Health Care Facility for Hospice Care")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.207")]
	public CqlValueSet Discharged_to_Health_Care_Facility_for_Hospice_Care(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.207", default);

    [CqlDeclaration("Discharged to Home for Hospice Care")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.209")]
	public CqlValueSet Discharged_to_Home_for_Hospice_Care(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.209", default);

    [CqlDeclaration("Encounter Inpatient")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.666.5.307")]
	public CqlValueSet Encounter_Inpatient(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.666.5.307", default);

    [CqlDeclaration("Height")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.121.12.1014")]
	public CqlValueSet Height(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.121.12.1014", default);

    [CqlDeclaration("Home Healthcare Services")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1016")]
	public CqlValueSet Home_Healthcare_Services(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1016", default);

    [CqlDeclaration("Hospice care ambulatory")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1108.15")]
	public CqlValueSet Hospice_care_ambulatory(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1108.15", default);

    [CqlDeclaration("Office Visit")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1001")]
	public CqlValueSet Office_Visit(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1001", default);

    [CqlDeclaration("Pregnancy")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.378")]
	public CqlValueSet Pregnancy(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.378", default);

    [CqlDeclaration("Preventive Care Services - Group Counseling")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1027")]
	public CqlValueSet Preventive_Care_Services___Group_Counseling(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1027", default);

    [CqlDeclaration("Preventive Care Services, Initial Office Visit, 0 to 17")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1022")]
	public CqlValueSet Preventive_Care_Services__Initial_Office_Visit__0_to_17(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1022", default);

    [CqlDeclaration("Preventive Care Services-Individual Counseling")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1026")]
	public CqlValueSet Preventive_Care_Services_Individual_Counseling(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1026", default);

    [CqlDeclaration("Preventive Care, Established Office Visit, 0 to 17")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1024")]
	public CqlValueSet Preventive_Care__Established_Office_Visit__0_to_17(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1024", default);

    [CqlDeclaration("Telephone Visits")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1080")]
	public CqlValueSet Telephone_Visits(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1080", default);

    [CqlDeclaration("Weight")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.121.12.1015")]
	public CqlValueSet Weight(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.121.12.1015", default);

    [CqlDeclaration("[in_i]")]
	public CqlCode _in_i_(CqlContext context) => 
		new CqlCode("[in_i]", "http://unitsofmeasure.org", default, default);

    [CqlDeclaration("[lb_av]")]
	public CqlCode _lb_av_(CqlContext context) => 
		new CqlCode("[lb_av]", "http://unitsofmeasure.org", default, default);

    [CqlDeclaration("Birth date")]
	public CqlCode Birth_date(CqlContext context) => 
		new CqlCode("21112-8", "http://loinc.org", default, default);

    [CqlDeclaration("Body height")]
	public CqlCode Body_height(CqlContext context) => 
		new CqlCode("8302-2", "http://loinc.org", default, default);

    [CqlDeclaration("Body mass index (BMI) [Ratio]")]
	public CqlCode Body_mass_index__BMI___Ratio_(CqlContext context) => 
		new CqlCode("39156-5", "http://loinc.org", default, default);

    [CqlDeclaration("Body weight")]
	public CqlCode Body_weight(CqlContext context) => 
		new CqlCode("29463-7", "http://loinc.org", default, default);

    [CqlDeclaration("cm")]
	public CqlCode cm(CqlContext context) => 
		new CqlCode("cm", "http://unitsofmeasure.org", default, default);

    [CqlDeclaration("exam")]
	public CqlCode exam(CqlContext context) => 
		new CqlCode("exam", "http://terminology.hl7.org/CodeSystem/observation-category", default, default);

    [CqlDeclaration("g")]
	public CqlCode g(CqlContext context) => 
		new CqlCode("g", "http://unitsofmeasure.org", default, default);

    [CqlDeclaration("kg")]
	public CqlCode kg(CqlContext context) => 
		new CqlCode("kg", "http://unitsofmeasure.org", default, default);

    [CqlDeclaration("vital-signs")]
	public CqlCode vital_signs(CqlContext context) => 
		new CqlCode("vital-signs", "http://terminology.hl7.org/CodeSystem/observation-category", default, default);

    [CqlDeclaration("UCUM")]
	public CqlCode[] UCUM(CqlContext context)
	{
		CqlCode[] a_ = [
			new CqlCode("[in_i]", "http://unitsofmeasure.org", default, default),
			new CqlCode("[lb_av]", "http://unitsofmeasure.org", default, default),
			new CqlCode("cm", "http://unitsofmeasure.org", default, default),
			new CqlCode("g", "http://unitsofmeasure.org", default, default),
			new CqlCode("kg", "http://unitsofmeasure.org", default, default),
		];

		return a_;
	}

    [CqlDeclaration("LOINC")]
	public CqlCode[] LOINC(CqlContext context)
	{
		CqlCode[] a_ = [
			new CqlCode("21112-8", "http://loinc.org", default, default),
			new CqlCode("8302-2", "http://loinc.org", default, default),
			new CqlCode("39156-5", "http://loinc.org", default, default),
			new CqlCode("29463-7", "http://loinc.org", default, default),
		];

		return a_;
	}

    [CqlDeclaration("ObservationCategoryCodes")]
	public CqlCode[] ObservationCategoryCodes(CqlContext context)
	{
		CqlCode[] a_ = [
			new CqlCode("exam", "http://terminology.hl7.org/CodeSystem/observation-category", default, default),
			new CqlCode("vital-signs", "http://terminology.hl7.org/CodeSystem/observation-category", default, default),
		];

		return a_;
	}

    [CqlDeclaration("Measurement Period")]
	public CqlInterval<CqlDateTime> Measurement_Period(CqlContext context)
	{
		CqlDateTime a_ = context.Operators.DateTime(2025, 1, 1, 0, 0, 0, 0, default);
		CqlDateTime b_ = context.Operators.DateTime(2026, 1, 1, 0, 0, 0, 0, default);
		CqlInterval<CqlDateTime> c_ = context.Operators.Interval(a_, b_, true, false);
		object d_ = context.ResolveParameter("WeightAssessmentandCounselingforNutritionandPhysicalActivityforChildrenandAdolescentsFHIR-0.1.000", "Measurement Period", c_);

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
		CqlValueSet a_ = this.Office_Visit(context);
		IEnumerable<Encounter> b_ = context.Operators.RetrieveByValueSet<Encounter>(a_, default);
		CqlValueSet c_ = this.Preventive_Care_Services_Individual_Counseling(context);
		IEnumerable<Encounter> d_ = context.Operators.RetrieveByValueSet<Encounter>(c_, default);
		IEnumerable<Encounter> e_ = context.Operators.Union<Encounter>(b_, d_);
		CqlValueSet f_ = this.Preventive_Care_Services__Initial_Office_Visit__0_to_17(context);
		IEnumerable<Encounter> g_ = context.Operators.RetrieveByValueSet<Encounter>(f_, default);
		CqlValueSet h_ = this.Preventive_Care__Established_Office_Visit__0_to_17(context);
		IEnumerable<Encounter> i_ = context.Operators.RetrieveByValueSet<Encounter>(h_, default);
		IEnumerable<Encounter> j_ = context.Operators.Union<Encounter>(g_, i_);
		IEnumerable<Encounter> k_ = context.Operators.Union<Encounter>(e_, j_);
		CqlValueSet l_ = this.Preventive_Care_Services___Group_Counseling(context);
		IEnumerable<Encounter> m_ = context.Operators.RetrieveByValueSet<Encounter>(l_, default);
		CqlValueSet n_ = this.Home_Healthcare_Services(context);
		IEnumerable<Encounter> o_ = context.Operators.RetrieveByValueSet<Encounter>(n_, default);
		IEnumerable<Encounter> p_ = context.Operators.Union<Encounter>(m_, o_);
		IEnumerable<Encounter> q_ = context.Operators.Union<Encounter>(k_, p_);
		CqlValueSet r_ = this.Telephone_Visits(context);
		IEnumerable<Encounter> s_ = context.Operators.RetrieveByValueSet<Encounter>(r_, default);
		IEnumerable<Encounter> t_ = context.Operators.Union<Encounter>(q_, s_);
		IEnumerable<Encounter> u_ = status_1_6_000.Finished_Encounter(context, t_);
		bool? v_(Encounter ValidEncounters)
		{
			CqlInterval<CqlDateTime> x_ = this.Measurement_Period(context);
			Period y_ = ValidEncounters?.Period;
			CqlInterval<CqlDateTime> z_ = fhirHelpers_4_3_000.ToInterval(context, y_);
			CqlInterval<CqlDateTime> aa_ = qiCoreCommon_2_0_000.ToInterval(context, z_ as object);
			bool? ab_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(x_, aa_, default);

			return ab_;
		};
		IEnumerable<Encounter> w_ = context.Operators.Where<Encounter>(u_, v_);

		return w_;
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
		CqlInterval<int?> i_ = context.Operators.Interval(3, 17, true, true);
		bool? j_ = context.Operators.In<int?>(h_, i_, default);
		IEnumerable<Encounter> k_ = this.Qualifying_Encounter(context);
		bool? l_ = context.Operators.Exists<Encounter>(k_);
		bool? m_ = context.Operators.And(j_, l_);

		return m_;
	}

    [CqlDeclaration("Denominator")]
	public bool? Denominator(CqlContext context)
	{
		bool? a_ = this.Initial_Population(context);

		return a_;
	}

    [CqlDeclaration("Pregnancy Diagnosis Which Overlaps Measurement Period")]
	public IEnumerable<Condition> Pregnancy_Diagnosis_Which_Overlaps_Measurement_Period(CqlContext context)
	{
		CqlValueSet a_ = this.Pregnancy(context);
		IEnumerable<Condition> b_ = context.Operators.RetrieveByValueSet<Condition>(a_, default);
		IEnumerable<Condition> c_ = status_1_6_000.Active_Condition(context, b_);
		bool? d_(Condition Pregnancy)
		{
			CqlInterval<CqlDateTime> f_ = qiCoreCommon_2_0_000.ToPrevalenceInterval(context, Pregnancy);
			CqlInterval<CqlDateTime> g_ = this.Measurement_Period(context);
			bool? h_ = context.Operators.Overlaps(f_, g_, default);

			return h_;
		};
		IEnumerable<Condition> e_ = context.Operators.Where<Condition>(c_, d_);

		return e_;
	}

    [CqlDeclaration("Denominator Exclusions")]
	public bool? Denominator_Exclusions(CqlContext context)
	{
		bool? a_ = hospice_6_9_000.Has_Hospice_Services(context);
		IEnumerable<Condition> b_ = this.Pregnancy_Diagnosis_Which_Overlaps_Measurement_Period(context);
		bool? c_ = context.Operators.Exists<Condition>(b_);
		bool? d_ = context.Operators.Or(a_, c_);

		return d_;
	}

    [CqlDeclaration("BMI Percentile in Measurement Period")]
	public IEnumerable<Observation> BMI_Percentile_in_Measurement_Period(CqlContext context)
	{
		IEnumerable<Observation> a_ = context.Operators.RetrieveByValueSet<Observation>(default, default);
		IEnumerable<Observation> b_ = status_1_6_000.BMI(context, a_);
		bool? c_(Observation BMIPercentile)
		{
			CqlInterval<CqlDateTime> e_ = this.Measurement_Period(context);
			DataType f_ = BMIPercentile?.Effective;
			object g_ = fhirHelpers_4_3_000.ToValue(context, f_);
			CqlInterval<CqlDateTime> h_ = qiCoreCommon_2_0_000.ToInterval(context, g_);
			bool? i_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(e_, h_, "day");
			DataType j_ = BMIPercentile?.Value;
			CqlQuantity k_ = fhirHelpers_4_3_000.ToQuantity(context, j_ as Quantity);
			bool? l_ = context.Operators.Not((bool?)(k_ is null));
			bool? m_ = context.Operators.And(i_, l_);

			return m_;
		};
		IEnumerable<Observation> d_ = context.Operators.Where<Observation>(b_, c_);

		return d_;
	}

    [CqlDeclaration("Height in Measurement Period")]
	public IEnumerable<Observation> Height_in_Measurement_Period(CqlContext context)
	{
		IEnumerable<Observation> a_ = context.Operators.RetrieveByValueSet<Observation>(default, default);
		IEnumerable<Observation> b_ = status_1_6_000.BodyHeight(context, a_);
		bool? c_(Observation Height)
		{
			CqlInterval<CqlDateTime> e_ = this.Measurement_Period(context);
			DataType f_ = Height?.Effective;
			object g_ = fhirHelpers_4_3_000.ToValue(context, f_);
			CqlInterval<CqlDateTime> h_ = qiCoreCommon_2_0_000.ToInterval(context, g_);
			bool? i_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(e_, h_, "day");
			DataType j_ = Height?.Value;
			CqlQuantity k_ = fhirHelpers_4_3_000.ToQuantity(context, j_ as Quantity);
			bool? l_ = context.Operators.Not((bool?)(k_ is null));
			bool? m_ = context.Operators.And(i_, l_);

			return m_;
		};
		IEnumerable<Observation> d_ = context.Operators.Where<Observation>(b_, c_);

		return d_;
	}

    [CqlDeclaration("Weight in Measurement Period")]
	public IEnumerable<Observation> Weight_in_Measurement_Period(CqlContext context)
	{
		IEnumerable<Observation> a_ = context.Operators.RetrieveByValueSet<Observation>(default, default);
		IEnumerable<Observation> b_ = status_1_6_000.BodyWeight(context, a_);
		bool? c_(Observation Weight)
		{
			CqlInterval<CqlDateTime> e_ = this.Measurement_Period(context);
			DataType f_ = Weight?.Effective;
			object g_ = fhirHelpers_4_3_000.ToValue(context, f_);
			CqlInterval<CqlDateTime> h_ = qiCoreCommon_2_0_000.ToInterval(context, g_);
			bool? i_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(e_, h_, "day");
			DataType j_ = Weight?.Value;
			CqlQuantity k_ = fhirHelpers_4_3_000.ToQuantity(context, j_ as Quantity);
			bool? l_ = context.Operators.Not((bool?)(k_ is null));
			bool? m_ = context.Operators.And(i_, l_);

			return m_;
		};
		IEnumerable<Observation> d_ = context.Operators.Where<Observation>(b_, c_);

		return d_;
	}

    [CqlDeclaration("Numerator 1")]
	public bool? Numerator_1(CqlContext context)
	{
		IEnumerable<Observation> a_ = this.BMI_Percentile_in_Measurement_Period(context);
		bool? b_ = context.Operators.Exists<Observation>(a_);
		IEnumerable<Observation> c_ = this.Height_in_Measurement_Period(context);
		bool? d_ = context.Operators.Exists<Observation>(c_);
		bool? e_ = context.Operators.And(b_, d_);
		IEnumerable<Observation> f_ = this.Weight_in_Measurement_Period(context);
		bool? g_ = context.Operators.Exists<Observation>(f_);
		bool? h_ = context.Operators.And(e_, g_);

		return h_;
	}

    [CqlDeclaration("Numerator 2")]
	public bool? Numerator_2(CqlContext context)
	{
		CqlValueSet a_ = this.Counseling_for_Nutrition(context);
		IEnumerable<Procedure> b_ = context.Operators.RetrieveByValueSet<Procedure>(a_, default);
		IEnumerable<Procedure> c_ = status_1_6_000.Completed_Procedure(context, b_);
		bool? d_(Procedure NutritionCounseling)
		{
			CqlInterval<CqlDateTime> g_ = this.Measurement_Period(context);
			DataType h_ = NutritionCounseling?.Performed;
			object i_ = fhirHelpers_4_3_000.ToValue(context, h_);
			CqlInterval<CqlDateTime> j_ = qiCoreCommon_2_0_000.ToInterval(context, i_);
			bool? k_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(g_, j_, "day");

			return k_;
		};
		IEnumerable<Procedure> e_ = context.Operators.Where<Procedure>(c_, d_);
		bool? f_ = context.Operators.Exists<Procedure>(e_);

		return f_;
	}

    [CqlDeclaration("Numerator 3")]
	public bool? Numerator_3(CqlContext context)
	{
		CqlValueSet a_ = this.Counseling_for_Physical_Activity(context);
		IEnumerable<Procedure> b_ = context.Operators.RetrieveByValueSet<Procedure>(a_, default);
		IEnumerable<Procedure> c_ = status_1_6_000.Completed_Procedure(context, b_);
		bool? d_(Procedure ActivityCounseling)
		{
			CqlInterval<CqlDateTime> g_ = this.Measurement_Period(context);
			DataType h_ = ActivityCounseling?.Performed;
			object i_ = fhirHelpers_4_3_000.ToValue(context, h_);
			CqlInterval<CqlDateTime> j_ = qiCoreCommon_2_0_000.ToInterval(context, i_);
			bool? k_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(g_, j_, "day");

			return k_;
		};
		IEnumerable<Procedure> e_ = context.Operators.Where<Procedure>(c_, d_);
		bool? f_ = context.Operators.Exists<Procedure>(e_);

		return f_;
	}

    [CqlDeclaration("Stratifaction 1")]
	public bool? Stratifaction_1(CqlContext context)
	{
		Patient a_ = this.Patient(context);
		Date b_ = a_?.BirthDateElement;
		string c_ = b_?.Value;
		CqlDate d_ = context.Operators.ConvertStringToDate(c_);
		CqlInterval<CqlDateTime> e_ = this.Measurement_Period(context);
		CqlDateTime f_ = context.Operators.End(e_);
		CqlDate g_ = context.Operators.DateFrom(f_);
		int? h_ = context.Operators.CalculateAgeAt(d_, g_, "year");
		CqlInterval<int?> i_ = context.Operators.Interval(3, 11, true, true);
		bool? j_ = context.Operators.In<int?>(h_, i_, default);

		return j_;
	}

    [CqlDeclaration("Stratifaction 2")]
	public bool? Stratifaction_2(CqlContext context)
	{
		Patient a_ = this.Patient(context);
		Date b_ = a_?.BirthDateElement;
		string c_ = b_?.Value;
		CqlDate d_ = context.Operators.ConvertStringToDate(c_);
		CqlInterval<CqlDateTime> e_ = this.Measurement_Period(context);
		CqlDateTime f_ = context.Operators.End(e_);
		CqlDate g_ = context.Operators.DateFrom(f_);
		int? h_ = context.Operators.CalculateAgeAt(d_, g_, "year");
		CqlInterval<int?> i_ = context.Operators.Interval(12, 17, true, true);
		bool? j_ = context.Operators.In<int?>(h_, i_, default);

		return j_;
	}

}
