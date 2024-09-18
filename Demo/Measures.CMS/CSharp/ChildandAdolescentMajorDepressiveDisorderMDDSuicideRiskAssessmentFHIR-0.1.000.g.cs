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
public static partial class ChildandAdolescentMajorDepressiveDisorderMDDSuicideRiskAssessmentFHIR_0_1_000ServiceCollectionExtensions
{
    public static IServiceCollection AddChildandAdolescentMajorDepressiveDisorderMDDSuicideRiskAssessmentFHIR_0_1_000(this IServiceCollection services)
    {
        services.TryAddSingleton<ChildandAdolescentMajorDepressiveDisorderMDDSuicideRiskAssessmentFHIR_0_1_000>();
        services.AddSupplementalDataElements_3_4_000();
        services.AddQICoreCommon_2_0_000();
        services.AddFHIRHelpers_4_3_000();
        services.AddCQMCommon_2_0_000();
        return services;
    }
}

partial class ChildandAdolescentMajorDepressiveDisorderMDDSuicideRiskAssessmentFHIR_0_1_000 : ICqlLibrary
{
    public static void AddLibraryService(IServiceCollection services) =>
        services.AddChildandAdolescentMajorDepressiveDisorderMDDSuicideRiskAssessmentFHIR_0_1_000();
}

[System.CodeDom.Compiler.GeneratedCode(".NET Code Generation", "2.0.3.0")]
[CqlLibrary("ChildandAdolescentMajorDepressiveDisorderMDDSuicideRiskAssessmentFHIR", "0.1.000")]
public partial class ChildandAdolescentMajorDepressiveDisorderMDDSuicideRiskAssessmentFHIR_0_1_000(
    SupplementalDataElements_3_4_000 supplementalDataElements_3_4_000,
    QICoreCommon_2_0_000 qiCoreCommon_2_0_000,
    FHIRHelpers_4_3_000 fhirHelpers_4_3_000,
    CQMCommon_2_0_000 cqmCommon_2_0_000)
{

    [CqlDeclaration("Group Psychotherapy")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1187")]
	public CqlValueSet Group_Psychotherapy(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1187", default);

    [CqlDeclaration("Major Depressive Disorder Active")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1491")]
	public CqlValueSet Major_Depressive_Disorder_Active(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1491", default);

    [CqlDeclaration("Office Visit")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1001")]
	public CqlValueSet Office_Visit(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1001", default);

    [CqlDeclaration("Outpatient Consultation")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1008")]
	public CqlValueSet Outpatient_Consultation(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1008", default);

    [CqlDeclaration("Psych Visit Diagnostic Evaluation")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1492")]
	public CqlValueSet Psych_Visit_Diagnostic_Evaluation(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1492", default);

    [CqlDeclaration("Psych Visit for Family Psychotherapy")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1018")]
	public CqlValueSet Psych_Visit_for_Family_Psychotherapy(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1018", default);

    [CqlDeclaration("Psych Visit Psychotherapy")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1496")]
	public CqlValueSet Psych_Visit_Psychotherapy(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1496", default);

    [CqlDeclaration("Psychoanalysis")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1141")]
	public CqlValueSet Psychoanalysis(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1141", default);

    [CqlDeclaration("Telehealth Services")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1031")]
	public CqlValueSet Telehealth_Services(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1031", default);

    [CqlDeclaration("Birth date")]
	public CqlCode Birth_date(CqlContext context) => 
		new CqlCode("21112-8", "http://loinc.org", default, default);

    [CqlDeclaration("Suicide risk assessment (procedure)")]
	public CqlCode Suicide_risk_assessment__procedure_(CqlContext context) => 
		new CqlCode("225337009", "http://snomed.info/sct", default, default);

    [CqlDeclaration("AMB")]
	public CqlCode AMB(CqlContext context) => 
		new CqlCode("AMB", "http://terminology.hl7.org/CodeSystem/v3-ActCode", default, default);

    [CqlDeclaration("LOINC")]
	public CqlCode[] LOINC(CqlContext context)
	{
		CqlCode[] a_ = [
			new CqlCode("21112-8", "http://loinc.org", default, default),
		];

		return a_;
	}

    [CqlDeclaration("SNOMEDCT")]
	public CqlCode[] SNOMEDCT(CqlContext context)
	{
		CqlCode[] a_ = [
			new CqlCode("225337009", "http://snomed.info/sct", default, default),
		];

		return a_;
	}

    [CqlDeclaration("ActCode")]
	public CqlCode[] ActCode(CqlContext context)
	{
		CqlCode[] a_ = [
			new CqlCode("AMB", "http://terminology.hl7.org/CodeSystem/v3-ActCode", default, default),
		];

		return a_;
	}

    [CqlDeclaration("ICD10CM")]
	public CqlCode[] ICD10CM(CqlContext context)
	{
		CqlCode[] a_ = []
;

		return a_;
	}

    [CqlDeclaration("Measurement Period")]
	public CqlInterval<CqlDateTime> Measurement_Period(CqlContext context)
	{
		CqlDateTime a_ = context.Operators.DateTime(2025, 1, 1, 0, 0, 0, 0, default);
		CqlDateTime b_ = context.Operators.DateTime(2026, 1, 1, 0, 0, 0, 0, default);
		CqlInterval<CqlDateTime> c_ = context.Operators.Interval(a_, b_, true, false);
		object d_ = context.ResolveParameter("ChildandAdolescentMajorDepressiveDisorderMDDSuicideRiskAssessmentFHIR-0.1.000", "Measurement Period", c_);

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

    [CqlDeclaration("Major Depressive Disorder Encounter")]
	public IEnumerable<Encounter> Major_Depressive_Disorder_Encounter(CqlContext context)
	{
		CqlValueSet a_ = this.Office_Visit(context);
		IEnumerable<Encounter> b_ = context.Operators.RetrieveByValueSet<Encounter>(a_, default);
		CqlValueSet c_ = this.Outpatient_Consultation(context);
		IEnumerable<Encounter> d_ = context.Operators.RetrieveByValueSet<Encounter>(c_, default);
		IEnumerable<Encounter> e_ = context.Operators.Union<Encounter>(b_, d_);
		CqlValueSet f_ = this.Psych_Visit_Diagnostic_Evaluation(context);
		IEnumerable<Encounter> g_ = context.Operators.RetrieveByValueSet<Encounter>(f_, default);
		CqlValueSet h_ = this.Psych_Visit_for_Family_Psychotherapy(context);
		IEnumerable<Encounter> i_ = context.Operators.RetrieveByValueSet<Encounter>(h_, default);
		IEnumerable<Encounter> j_ = context.Operators.Union<Encounter>(g_, i_);
		IEnumerable<Encounter> k_ = context.Operators.Union<Encounter>(e_, j_);
		CqlValueSet l_ = this.Psych_Visit_Psychotherapy(context);
		IEnumerable<Encounter> m_ = context.Operators.RetrieveByValueSet<Encounter>(l_, default);
		CqlValueSet n_ = this.Psychoanalysis(context);
		IEnumerable<Encounter> o_ = context.Operators.RetrieveByValueSet<Encounter>(n_, default);
		IEnumerable<Encounter> p_ = context.Operators.Union<Encounter>(m_, o_);
		IEnumerable<Encounter> q_ = context.Operators.Union<Encounter>(k_, p_);
		CqlValueSet r_ = this.Group_Psychotherapy(context);
		IEnumerable<Encounter> s_ = context.Operators.RetrieveByValueSet<Encounter>(r_, default);
		CqlValueSet t_ = this.Telehealth_Services(context);
		IEnumerable<Encounter> u_ = context.Operators.RetrieveByValueSet<Encounter>(t_, default);
		IEnumerable<Encounter> v_ = context.Operators.Union<Encounter>(s_, u_);
		IEnumerable<Encounter> w_ = context.Operators.Union<Encounter>(q_, v_);
		bool? x_(Encounter ValidEncounter)
		{
			Code<Encounter.EncounterStatus> z_ = ValidEncounter?.StatusElement;
			Encounter.EncounterStatus? aa_ = z_?.Value;
			Code<Encounter.EncounterStatus> ab_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(aa_);
			bool? ac_ = context.Operators.Equal(ab_, "finished");
			List<CodeableConcept> ad_ = ValidEncounter?.ReasonCode;
			CqlConcept ae_(CodeableConcept @this)
			{
				CqlConcept at_ = fhirHelpers_4_3_000.ToConcept(context, @this);

				return at_;
			};
			IEnumerable<CqlConcept> af_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)ad_, ae_);
			CqlValueSet ag_ = this.Major_Depressive_Disorder_Active(context);
			bool? ah_ = context.Operators.ConceptsInValueSet(af_, ag_);
			IEnumerable<Condition> ai_ = cqmCommon_2_0_000.EncounterDiagnosis(context, ValidEncounter);
			bool? aj_(Condition EncounterDiagnosis)
			{
				CodeableConcept au_ = EncounterDiagnosis?.Code;
				CqlConcept av_ = fhirHelpers_4_3_000.ToConcept(context, au_);
				CqlValueSet aw_ = this.Major_Depressive_Disorder_Active(context);
				bool? ax_ = context.Operators.ConceptInValueSet(av_, aw_);

				return ax_;
			};
			IEnumerable<Condition> ak_ = context.Operators.Where<Condition>(ai_, aj_);
			bool? al_ = context.Operators.Exists<Condition>(ak_);
			bool? am_ = context.Operators.Or(ah_, al_);
			bool? an_ = context.Operators.And(ac_, am_);
			CqlInterval<CqlDateTime> ao_ = this.Measurement_Period(context);
			Period ap_ = ValidEncounter?.Period;
			CqlInterval<CqlDateTime> aq_ = fhirHelpers_4_3_000.ToInterval(context, ap_);
			bool? ar_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(ao_, aq_, default);
			bool? as_ = context.Operators.And(an_, ar_);

			return as_;
		};
		IEnumerable<Encounter> y_ = context.Operators.Where<Encounter>(w_, x_);

		return y_;
	}

    [CqlDeclaration("Initial Population")]
	public IEnumerable<Encounter> Initial_Population(CqlContext context)
	{
		IEnumerable<Encounter> a_ = this.Major_Depressive_Disorder_Encounter(context);
		bool? b_(Encounter MDDEncounter)
		{
			Patient d_ = this.Patient(context);
			Date e_ = d_?.BirthDateElement;
			string f_ = e_?.Value;
			CqlDate g_ = context.Operators.ConvertStringToDate(f_);
			CqlInterval<CqlDateTime> h_ = this.Measurement_Period(context);
			CqlDateTime i_ = context.Operators.Start(h_);
			CqlDate j_ = context.Operators.DateFrom(i_);
			int? k_ = context.Operators.CalculateAgeAt(g_, j_, "year");
			bool? l_ = context.Operators.GreaterOrEqual(k_, 6);
			Date n_ = d_?.BirthDateElement;
			string o_ = n_?.Value;
			CqlDate p_ = context.Operators.ConvertStringToDate(o_);
			CqlDateTime r_ = context.Operators.Start(h_);
			CqlDate s_ = context.Operators.DateFrom(r_);
			int? t_ = context.Operators.CalculateAgeAt(p_, s_, "year");
			bool? u_ = context.Operators.LessOrEqual(t_, 16);
			bool? v_ = context.Operators.And(l_, u_);

			return v_;
		};
		IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);

		return c_;
	}

    [CqlDeclaration("Denominator")]
	public IEnumerable<Encounter> Denominator(CqlContext context)
	{
		IEnumerable<Encounter> a_ = this.Initial_Population(context);

		return a_;
	}

    [CqlDeclaration("Numerator")]
	public IEnumerable<Encounter> Numerator(CqlContext context)
	{
		IEnumerable<Encounter> a_ = this.Major_Depressive_Disorder_Encounter(context);
		IEnumerable<Encounter> b_(Encounter MDDEncounter)
		{
			CqlCode d_ = this.Suicide_risk_assessment__procedure_(context);
			IEnumerable<CqlCode> e_ = context.Operators.ToList<CqlCode>(d_);
			IEnumerable<Procedure> f_ = context.Operators.RetrieveByCodes<Procedure>(e_, default);
			bool? g_(Procedure SuicideRiskAssessment)
			{
				Code<EventStatus> k_ = SuicideRiskAssessment?.StatusElement;
				EventStatus? l_ = k_?.Value;
				string m_ = context.Operators.Convert<string>(l_);
				bool? n_ = context.Operators.Equal(m_, "completed");
				Period o_ = MDDEncounter?.Period;
				CqlInterval<CqlDateTime> p_ = fhirHelpers_4_3_000.ToInterval(context, o_);
				DataType q_ = SuicideRiskAssessment?.Performed;
				object r_ = fhirHelpers_4_3_000.ToValue(context, q_);
				CqlInterval<CqlDateTime> s_ = qiCoreCommon_2_0_000.ToInterval(context, r_);
				bool? t_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(p_, s_, default);
				bool? u_ = context.Operators.And(n_, t_);

				return u_;
			};
			IEnumerable<Procedure> h_ = context.Operators.Where<Procedure>(f_, g_);
			Encounter i_(Procedure SuicideRiskAssessment) => 
				MDDEncounter;
			IEnumerable<Encounter> j_ = context.Operators.Select<Procedure, Encounter>(h_, i_);

			return j_;
		};
		IEnumerable<Encounter> c_ = context.Operators.SelectMany<Encounter, Encounter>(a_, b_);

		return c_;
	}

}
