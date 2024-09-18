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
public static partial class PalliativeCare_1_9_000ServiceCollectionExtensions
{
    public static IServiceCollection AddPalliativeCare_1_9_000(this IServiceCollection services)
    {
        services.TryAddSingleton<PalliativeCare_1_9_000>();
        services.AddFHIRHelpers_4_3_000();
        services.AddQICoreCommon_2_0_000();
        services.AddStatus_1_6_000();
        return services;
    }
}

partial class PalliativeCare_1_9_000 : ILibraryService
{
    static void ILibraryService.AddLibraryService(IServiceCollection services) =>
        services.AddPalliativeCare_1_9_000();
}

[System.CodeDom.Compiler.GeneratedCode(".NET Code Generation", "2.0.3.0")]
[CqlLibrary("PalliativeCare", "1.9.000")]
public partial class PalliativeCare_1_9_000(
    FHIRHelpers_4_3_000 fhirHelpers_4_3_000,
    QICoreCommon_2_0_000 qiCoreCommon_2_0_000,
    Status_1_6_000 status_1_6_000)
{

    [CqlDeclaration("Palliative Care Encounter")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1090")]
	public  CqlValueSet Palliative_Care_Encounter(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1090", default);

    [CqlDeclaration("Palliative Care Intervention")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.198.12.1135")]
	public  CqlValueSet Palliative_Care_Intervention(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.198.12.1135", default);

    [CqlDeclaration("Palliative Care Diagnosis")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.1167")]
	public  CqlValueSet Palliative_Care_Diagnosis(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.1167", default);

    [CqlDeclaration("Functional Assessment of Chronic Illness Therapy - Palliative Care Questionnaire (FACIT-Pal)")]
	public  CqlCode Functional_Assessment_of_Chronic_Illness_Therapy___Palliative_Care_Questionnaire__FACIT_Pal_(CqlContext context) => 
		new CqlCode("71007-9", "http://loinc.org", default, default);

    [CqlDeclaration("LOINC")]
	public  CqlCode[] LOINC(CqlContext context)
	{
		CqlCode[] a_ = [
			new CqlCode("71007-9", "http://loinc.org", default, default),
		];

		return a_;
	}

    [CqlDeclaration("Measurement Period")]
	public  CqlInterval<CqlDateTime> Measurement_Period(CqlContext context)
	{
		object a_ = context.ResolveParameter("PalliativeCare-1.9.000", "Measurement Period", null);

		return (CqlInterval<CqlDateTime>)a_;
	}

    [CqlDeclaration("Patient")]
	public  Patient Patient(CqlContext context)
	{
		IEnumerable<Patient> a_ = context.Operators.RetrieveByValueSet<Patient>(default, default);
		Patient b_ = context.Operators.SingletonFrom<Patient>(a_);

		return b_;
	}

    [CqlDeclaration("Has Palliative Care in the Measurement Period")]
	public  bool? Has_Palliative_Care_in_the_Measurement_Period(CqlContext context)
	{
		CqlCode a_ = this.Functional_Assessment_of_Chronic_Illness_Therapy___Palliative_Care_Questionnaire__FACIT_Pal_(context);
		IEnumerable<CqlCode> b_ = context.Operators.ToList<CqlCode>(a_);
		IEnumerable<Observation> c_ = context.Operators.RetrieveByCodes<Observation>(b_, default);
		IEnumerable<Observation> d_ = status_1_6_000.isAssessmentPerformed(context, c_);
		bool? e_(Observation PalliativeAssessment)
		{
			DataType ab_ = PalliativeAssessment?.Effective;
			object ac_ = fhirHelpers_4_3_000.ToValue(context, ab_);
			CqlInterval<CqlDateTime> ad_ = qiCoreCommon_2_0_000.toInterval(context, ac_);
			CqlInterval<CqlDateTime> ae_ = this.Measurement_Period(context);
			bool? af_ = context.Operators.Overlaps(ad_, ae_, "day");

			return af_;
		};
		IEnumerable<Observation> f_ = context.Operators.Where<Observation>(d_, e_);
		bool? g_ = context.Operators.Exists<Observation>(f_);
		CqlValueSet h_ = this.Palliative_Care_Diagnosis(context);
		IEnumerable<Condition> i_ = context.Operators.RetrieveByValueSet<Condition>(h_, default);
		bool? j_(Condition PalliativeDiagnosis)
		{
			CqlInterval<CqlDateTime> ag_ = qiCoreCommon_2_0_000.prevalenceInterval(context, PalliativeDiagnosis);
			CqlInterval<CqlDateTime> ah_ = this.Measurement_Period(context);
			bool? ai_ = context.Operators.Overlaps(ag_, ah_, "day");

			return ai_;
		};
		IEnumerable<Condition> k_ = context.Operators.Where<Condition>(i_, j_);
		bool? l_ = context.Operators.Exists<Condition>(k_);
		bool? m_ = context.Operators.Or(g_, l_);
		CqlValueSet n_ = this.Palliative_Care_Encounter(context);
		IEnumerable<Encounter> o_ = context.Operators.RetrieveByValueSet<Encounter>(n_, default);
		IEnumerable<Encounter> p_ = status_1_6_000.isEncounterPerformed(context, o_);
		bool? q_(Encounter PalliativeEncounter)
		{
			Period aj_ = PalliativeEncounter?.Period;
			CqlInterval<CqlDateTime> ak_ = fhirHelpers_4_3_000.ToInterval(context, aj_);
			CqlInterval<CqlDateTime> al_ = qiCoreCommon_2_0_000.toInterval(context, ak_ as object);
			CqlInterval<CqlDateTime> am_ = this.Measurement_Period(context);
			bool? an_ = context.Operators.Overlaps(al_, am_, "day");

			return an_;
		};
		IEnumerable<Encounter> r_ = context.Operators.Where<Encounter>(p_, q_);
		bool? s_ = context.Operators.Exists<Encounter>(r_);
		bool? t_ = context.Operators.Or(m_, s_);
		CqlValueSet u_ = this.Palliative_Care_Intervention(context);
		IEnumerable<Procedure> v_ = context.Operators.RetrieveByValueSet<Procedure>(u_, default);
		IEnumerable<Procedure> w_ = status_1_6_000.isInterventionPerformed(context, v_);
		bool? x_(Procedure PalliativeIntervention)
		{
			DataType ao_ = PalliativeIntervention?.Performed;
			object ap_ = fhirHelpers_4_3_000.ToValue(context, ao_);
			CqlInterval<CqlDateTime> aq_ = qiCoreCommon_2_0_000.toInterval(context, ap_);
			CqlInterval<CqlDateTime> ar_ = this.Measurement_Period(context);
			bool? as_ = context.Operators.Overlaps(aq_, ar_, "day");

			return as_;
		};
		IEnumerable<Procedure> y_ = context.Operators.Where<Procedure>(w_, x_);
		bool? z_ = context.Operators.Exists<Procedure>(y_);
		bool? aa_ = context.Operators.Or(t_, z_);

		return aa_;
	}

}
