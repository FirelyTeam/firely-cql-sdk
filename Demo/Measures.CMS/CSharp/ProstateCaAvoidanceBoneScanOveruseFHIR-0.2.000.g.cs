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
public static partial class ProstateCaAvoidanceBoneScanOveruseFHIR_0_2_000ServiceCollectionExtensions
{
    public static IServiceCollection AddProstateCaAvoidanceBoneScanOveruseFHIR_0_2_000(this IServiceCollection services)
    {
        services.TryAddSingleton<ProstateCaAvoidanceBoneScanOveruseFHIR_0_2_000>();
        services.AddFHIRHelpers_4_3_000();
        services.AddSupplementalDataElements_3_4_000();
        services.AddQICoreCommon_2_0_000();
        return services;
    }
}

partial class ProstateCaAvoidanceBoneScanOveruseFHIR_0_2_000 : ILibraryService
{
    static void ILibraryService.AddLibraryService(IServiceCollection services) =>
        services.AddProstateCaAvoidanceBoneScanOveruseFHIR_0_2_000();
}

[System.CodeDom.Compiler.GeneratedCode(".NET Code Generation", "2.0.3.0")]
[CqlLibrary("ProstateCaAvoidanceBoneScanOveruseFHIR", "0.2.000")]
public partial class ProstateCaAvoidanceBoneScanOveruseFHIR_0_2_000(
    FHIRHelpers_4_3_000 fhirHelpers_4_3_000,
    SupplementalDataElements_3_4_000 supplementalDataElements_3_4_000,
    QICoreCommon_2_0_000 qiCoreCommon_2_0_000)
{

    [CqlDeclaration("Bone Scan")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.320")]
	public  CqlValueSet Bone_Scan(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.320", default);

    [CqlDeclaration("Pain Warranting Further Investigation for Prostate Cancer")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.451")]
	public  CqlValueSet Pain_Warranting_Further_Investigation_for_Prostate_Cancer(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.451", default);

    [CqlDeclaration("Prostate Cancer")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.319")]
	public  CqlValueSet Prostate_Cancer(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.319", default);

    [CqlDeclaration("Prostate Cancer Treatment")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.398")]
	public  CqlValueSet Prostate_Cancer_Treatment(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.398", default);

    [CqlDeclaration("Prostate Specific Antigen Test")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.401")]
	public  CqlValueSet Prostate_Specific_Antigen_Test(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.401", default);

    [CqlDeclaration("Salvage Therapy")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.399")]
	public  CqlValueSet Salvage_Therapy(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.399", default);

    [CqlDeclaration("Gleason score in Specimen Qualitative")]
	public  CqlCode Gleason_score_in_Specimen_Qualitative(CqlContext context) => 
		new CqlCode("35266-6", "http://loinc.org", default, default);

    [CqlDeclaration("Neoplasm of prostate primary tumor staging category T1c: Tumor identified by needle biopsy (finding)")]
	public  CqlCode Neoplasm_of_prostate_primary_tumor_staging_category_T1c__Tumor_identified_by_needle_biopsy__finding_(CqlContext context) => 
		new CqlCode("433351000124101", "http://snomed.info/sct", default, default);

    [CqlDeclaration("Neoplasm of prostate primary tumor staging category T2a: Involves one-half of one lobe or less (finding)")]
	public  CqlCode Neoplasm_of_prostate_primary_tumor_staging_category_T2a__Involves_one_half_of_one_lobe_or_less__finding_(CqlContext context) => 
		new CqlCode("433361000124104", "http://snomed.info/sct", default, default);

    [CqlDeclaration("Procedure reason record (record artifact)")]
	public  CqlCode Procedure_reason_record__record_artifact_(CqlContext context) => 
		new CqlCode("433611000124109", "http://snomed.info/sct", default, default);

    [CqlDeclaration("T1a: Prostate tumor incidental histologic finding in 5 percent or less of tissue resected (finding)")]
	public  CqlCode T1a__Prostate_tumor_incidental_histologic_finding_in_5_percent_or_less_of_tissue_resected__finding_(CqlContext context) => 
		new CqlCode("369833007", "http://snomed.info/sct", default, default);

    [CqlDeclaration("T1b: Prostate tumor incidental histologic finding in greater than 5 percent of tissue resected (finding)")]
	public  CqlCode T1b__Prostate_tumor_incidental_histologic_finding_in_greater_than_5_percent_of_tissue_resected__finding_(CqlContext context) => 
		new CqlCode("369834001", "http://snomed.info/sct", default, default);

    [CqlDeclaration("Tumor staging (tumor staging)")]
	public  CqlCode Tumor_staging__tumor_staging_(CqlContext context) => 
		new CqlCode("254292007", "http://snomed.info/sct", default, default);

    [CqlDeclaration("LOINC")]
	public  CqlCode[] LOINC(CqlContext context)
	{
		CqlCode[] a_ = [
			new CqlCode("35266-6", "http://loinc.org", default, default),
		];

		return a_;
	}

    [CqlDeclaration("SNOMEDCT")]
	public  CqlCode[] SNOMEDCT(CqlContext context)
	{
		CqlCode[] a_ = [
			new CqlCode("433351000124101", "http://snomed.info/sct", default, default),
			new CqlCode("433361000124104", "http://snomed.info/sct", default, default),
			new CqlCode("433611000124109", "http://snomed.info/sct", default, default),
			new CqlCode("369833007", "http://snomed.info/sct", default, default),
			new CqlCode("369834001", "http://snomed.info/sct", default, default),
			new CqlCode("254292007", "http://snomed.info/sct", default, default),
		];

		return a_;
	}

    [CqlDeclaration("Measurement Period")]
	public  CqlInterval<CqlDateTime> Measurement_Period(CqlContext context)
	{
		CqlDateTime a_ = context.Operators.DateTime(2025, 1, 1, 0, 0, 0, 0, default);
		CqlDateTime b_ = context.Operators.DateTime(2026, 1, 1, 0, 0, 0, 0, default);
		CqlInterval<CqlDateTime> c_ = context.Operators.Interval(a_, b_, true, false);
		object d_ = context.ResolveParameter("ProstateCaAvoidanceBoneScanOveruseFHIR-0.2.000", "Measurement Period", c_);

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

    [CqlDeclaration("Prostate Cancer Diagnosis")]
	public  IEnumerable<Condition> Prostate_Cancer_Diagnosis(CqlContext context)
	{
		CqlValueSet a_ = this.Prostate_Cancer(context);
		IEnumerable<Condition> b_ = context.Operators.RetrieveByValueSet<Condition>(a_, default);
		bool? c_(Condition ProstateCancer)
		{
			CqlInterval<CqlDateTime> e_ = qiCoreCommon_2_0_000.prevalenceInterval(context, ProstateCancer);
			CqlInterval<CqlDateTime> f_ = this.Measurement_Period(context);
			bool? g_ = context.Operators.Overlaps(e_, f_, "day");
			bool? h_ = qiCoreCommon_2_0_000.isProblemListItem(context, ProstateCancer);
			bool? i_ = qiCoreCommon_2_0_000.isHealthConcern(context, ProstateCancer);
			bool? j_ = context.Operators.Or(h_, i_);
			bool? k_ = context.Operators.And(g_, j_);
			bool? l_ = qiCoreCommon_2_0_000.isActive(context, ProstateCancer);
			bool? m_ = context.Operators.And(k_, l_);

			return m_;
		};
		IEnumerable<Condition> d_ = context.Operators.Where<Condition>(b_, c_);

		return d_;
	}

    [CqlDeclaration("Has Diagnosis of Pain related to Prostate Cancer")]
	public  bool? Has_Diagnosis_of_Pain_related_to_Prostate_Cancer(CqlContext context)
	{
		CqlValueSet a_ = this.Pain_Warranting_Further_Investigation_for_Prostate_Cancer(context);
		IEnumerable<Condition> b_ = context.Operators.RetrieveByValueSet<Condition>(a_, default);
		IEnumerable<Condition> c_(Condition ProstateCancerPain)
		{
			IEnumerable<Condition> f_ = this.Prostate_Cancer_Diagnosis(context);
			bool? g_(Condition ActiveProstateCancer)
			{
				CqlInterval<CqlDateTime> k_ = qiCoreCommon_2_0_000.prevalenceInterval(context, ProstateCancerPain);
				CqlDateTime l_ = context.Operators.Start(k_);
				CqlInterval<CqlDateTime> m_ = qiCoreCommon_2_0_000.prevalenceInterval(context, ActiveProstateCancer);
				CqlDateTime n_ = context.Operators.Start(m_);
				bool? o_ = context.Operators.After(l_, n_, default);
				bool? p_ = qiCoreCommon_2_0_000.isProblemListItem(context, ProstateCancerPain);
				bool? q_ = qiCoreCommon_2_0_000.isHealthConcern(context, ProstateCancerPain);
				bool? r_ = context.Operators.Or(p_, q_);
				bool? s_ = context.Operators.And(o_, r_);
				bool? t_ = qiCoreCommon_2_0_000.isActive(context, ProstateCancerPain);
				bool? u_ = context.Operators.And(s_, t_);

				return u_;
			};
			IEnumerable<Condition> h_ = context.Operators.Where<Condition>(f_, g_);
			Condition i_(Condition ActiveProstateCancer) => 
				ProstateCancerPain;
			IEnumerable<Condition> j_ = context.Operators.Select<Condition, Condition>(h_, i_);

			return j_;
		};
		IEnumerable<Condition> d_ = context.Operators.SelectMany<Condition, Condition>(b_, c_);
		bool? e_ = context.Operators.Exists<Condition>(d_);

		return e_;
	}

    [CqlDeclaration("Has Salvage Therapy Performed after Prostate Cancer Diagnosis")]
	public  bool? Has_Salvage_Therapy_Performed_after_Prostate_Cancer_Diagnosis(CqlContext context)
	{
		CqlValueSet a_ = this.Salvage_Therapy(context);
		IEnumerable<Procedure> b_ = context.Operators.RetrieveByValueSet<Procedure>(a_, default);
		IEnumerable<Procedure> c_(Procedure SalvageTherapy)
		{
			IEnumerable<Condition> f_ = this.Prostate_Cancer_Diagnosis(context);
			bool? g_(Condition ActiveProstateCancer)
			{
				DataType k_ = SalvageTherapy?.Performed;
				object l_ = fhirHelpers_4_3_000.ToValue(context, k_);
				CqlInterval<CqlDateTime> m_ = qiCoreCommon_2_0_000.toInterval(context, l_);
				CqlDateTime n_ = context.Operators.Start(m_);
				CqlInterval<CqlDateTime> o_ = qiCoreCommon_2_0_000.prevalenceInterval(context, ActiveProstateCancer);
				CqlDateTime p_ = context.Operators.Start(o_);
				bool? q_ = context.Operators.After(n_, p_, default);
				Code<EventStatus> r_ = SalvageTherapy?.StatusElement;
				EventStatus? s_ = r_?.Value;
				string t_ = context.Operators.Convert<string>(s_);
				bool? u_ = context.Operators.Equal(t_, "completed");
				bool? v_ = context.Operators.And(q_, u_);

				return v_;
			};
			IEnumerable<Condition> h_ = context.Operators.Where<Condition>(f_, g_);
			Procedure i_(Condition ActiveProstateCancer) => 
				SalvageTherapy;
			IEnumerable<Procedure> j_ = context.Operators.Select<Condition, Procedure>(h_, i_);

			return j_;
		};
		IEnumerable<Procedure> d_ = context.Operators.SelectMany<Procedure, Procedure>(b_, c_);
		bool? e_ = context.Operators.Exists<Procedure>(d_);

		return e_;
	}

    [CqlDeclaration("Bone Scan Study Performed")]
	public  IEnumerable<Observation> Bone_Scan_Study_Performed(CqlContext context)
	{
		CqlValueSet a_ = this.Bone_Scan(context);
		IEnumerable<Observation> b_ = context.Operators.RetrieveByValueSet<Observation>(a_, default);
		IEnumerable<Observation> c_(Observation BoneScan)
		{
			IEnumerable<Condition> e_ = this.Prostate_Cancer_Diagnosis(context);
			bool? f_(Condition ActiveProstateCancer)
			{
				DataType j_ = BoneScan?.Effective;
				object k_ = fhirHelpers_4_3_000.ToValue(context, j_);
				CqlInterval<CqlDateTime> l_ = qiCoreCommon_2_0_000.toInterval(context, k_);
				CqlDateTime m_ = context.Operators.Start(l_);
				CqlInterval<CqlDateTime> n_ = qiCoreCommon_2_0_000.prevalenceInterval(context, ActiveProstateCancer);
				CqlDateTime o_ = context.Operators.Start(n_);
				bool? p_ = context.Operators.After(m_, o_, default);

				return p_;
			};
			IEnumerable<Condition> g_ = context.Operators.Where<Condition>(e_, f_);
			Observation h_(Condition ActiveProstateCancer) => 
				BoneScan;
			IEnumerable<Observation> i_ = context.Operators.Select<Condition, Observation>(g_, h_);

			return i_;
		};
		IEnumerable<Observation> d_ = context.Operators.SelectMany<Observation, Observation>(b_, c_);

		return d_;
	}

    [CqlDeclaration("Has Bone Scan Study Performed with Documented Reason")]
	public  bool? Has_Bone_Scan_Study_Performed_with_Documented_Reason(CqlContext context)
	{
		IEnumerable<Observation> a_ = this.Bone_Scan_Study_Performed(context);
		bool? b_(Observation BoneScanAfterDiagnosis)
		{
			DataType e_ = BoneScanAfterDiagnosis?.Value;
			object f_ = fhirHelpers_4_3_000.ToValue(context, e_);
			CqlCode g_ = this.Procedure_reason_record__record_artifact_(context);
			CqlConcept h_ = context.Operators.ConvertCodeToConcept(g_);
			bool? i_ = context.Operators.Equivalent(f_ as CqlConcept, h_);

			return i_;
		};
		IEnumerable<Observation> c_ = context.Operators.Where<Observation>(a_, b_);
		bool? d_ = context.Operators.Exists<Observation>(c_);

		return d_;
	}

    [CqlDeclaration("Denominator Exceptions")]
	public  bool? Denominator_Exceptions(CqlContext context)
	{
		bool? a_ = this.Has_Diagnosis_of_Pain_related_to_Prostate_Cancer(context);
		bool? b_ = this.Has_Salvage_Therapy_Performed_after_Prostate_Cancer_Diagnosis(context);
		bool? c_ = context.Operators.Or(a_, b_);
		bool? d_ = this.Has_Bone_Scan_Study_Performed_with_Documented_Reason(context);
		bool? e_ = context.Operators.Or(c_, d_);

		return e_;
	}

    [CqlDeclaration("First Prostate Cancer Treatment during day of Measurement Period")]
	public  Procedure First_Prostate_Cancer_Treatment_during_day_of_Measurement_Period(CqlContext context)
	{
		CqlValueSet a_ = this.Prostate_Cancer_Treatment(context);
		IEnumerable<Procedure> b_ = context.Operators.RetrieveByValueSet<Procedure>(a_, default);
		bool? c_(Procedure ProstateCancerTreatment)
		{
			DataType h_ = ProstateCancerTreatment?.Performed;
			object i_ = fhirHelpers_4_3_000.ToValue(context, h_);
			CqlInterval<CqlDateTime> j_ = qiCoreCommon_2_0_000.toInterval(context, i_);
			CqlDateTime k_ = context.Operators.End(j_);
			CqlInterval<CqlDateTime> l_ = this.Measurement_Period(context);
			bool? m_ = context.Operators.In<CqlDateTime>(k_, l_, "day");
			Code<EventStatus> n_ = ProstateCancerTreatment?.StatusElement;
			EventStatus? o_ = n_?.Value;
			string p_ = context.Operators.Convert<string>(o_);
			bool? q_ = context.Operators.Equal(p_, "completed");
			bool? r_ = context.Operators.And(m_, q_);

			return r_;
		};
		IEnumerable<Procedure> d_ = context.Operators.Where<Procedure>(b_, c_);
		object e_(Procedure @this)
		{
			DataType s_ = @this?.Performed;
			object t_ = fhirHelpers_4_3_000.ToValue(context, s_);
			CqlInterval<CqlDateTime> u_ = qiCoreCommon_2_0_000.toInterval(context, t_);
			CqlDateTime v_ = context.Operators.Start(u_);

			return v_;
		};
		IEnumerable<Procedure> f_ = context.Operators.SortBy<Procedure>(d_, e_, System.ComponentModel.ListSortDirection.Ascending);
		Procedure g_ = context.Operators.First<Procedure>(f_);

		return g_;
	}

    [CqlDeclaration("Initial Population")]
	public  bool? Initial_Population(CqlContext context)
	{
		IEnumerable<Condition> a_ = this.Prostate_Cancer_Diagnosis(context);
		bool? b_ = context.Operators.Exists<Condition>(a_);

		return b_;
	}

    [CqlDeclaration("Most Recent Gleason Score is Low")]
	public  bool? Most_Recent_Gleason_Score_is_Low(CqlContext context)
	{
		CqlCode a_ = this.Gleason_score_in_Specimen_Qualitative(context);
		IEnumerable<CqlCode> b_ = context.Operators.ToList<CqlCode>(a_);
		IEnumerable<Observation> c_ = context.Operators.RetrieveByCodes<Observation>(b_, default);
		IEnumerable<Observation> d_(Observation GleasonScore)
		{
			Procedure m_ = this.First_Prostate_Cancer_Treatment_during_day_of_Measurement_Period(context);
			Procedure[] n_ = [
				m_,
			];
			bool? o_(Procedure FirstProstateCancerTreatment)
			{
				DataType s_ = GleasonScore?.Effective;
				object t_ = fhirHelpers_4_3_000.ToValue(context, s_);
				CqlInterval<CqlDateTime> u_ = qiCoreCommon_2_0_000.toInterval(context, t_);
				CqlDateTime v_ = context.Operators.Start(u_);
				DataType w_ = FirstProstateCancerTreatment?.Performed;
				object x_ = fhirHelpers_4_3_000.ToValue(context, w_);
				CqlInterval<CqlDateTime> y_ = qiCoreCommon_2_0_000.toInterval(context, x_);
				CqlDateTime z_ = context.Operators.Start(y_);
				bool? aa_ = context.Operators.Before(v_, z_, default);
				Code<ObservationStatus> ab_ = GleasonScore?.StatusElement;
				ObservationStatus? ac_ = ab_?.Value;
				Code<ObservationStatus> ad_ = context.Operators.Convert<Code<ObservationStatus>>(ac_);
				string ae_ = context.Operators.Convert<string>(ad_);
				string[] af_ = [
					"final",
					"amended",
					"corrected",
				];
				bool? ag_ = context.Operators.In<string>(ae_, af_ as IEnumerable<string>);
				bool? ah_ = context.Operators.And(aa_, ag_);

				return ah_;
			};
			IEnumerable<Procedure> p_ = context.Operators.Where<Procedure>((IEnumerable<Procedure>)n_, o_);
			Observation q_(Procedure FirstProstateCancerTreatment) => 
				GleasonScore;
			IEnumerable<Observation> r_ = context.Operators.Select<Procedure, Observation>(p_, q_);

			return r_;
		};
		IEnumerable<Observation> e_ = context.Operators.SelectMany<Observation, Observation>(c_, d_);
		object f_(Observation @this)
		{
			DataType ai_ = @this?.Effective;
			object aj_ = fhirHelpers_4_3_000.ToValue(context, ai_);
			CqlInterval<CqlDateTime> ak_ = qiCoreCommon_2_0_000.toInterval(context, aj_);
			CqlDateTime al_ = context.Operators.Start(ak_);

			return al_;
		};
		IEnumerable<Observation> g_ = context.Operators.SortBy<Observation>(e_, f_, System.ComponentModel.ListSortDirection.Ascending);
		Observation h_ = context.Operators.Last<Observation>(g_);
		Observation[] i_ = [
			h_,
		];
		bool? j_(Observation LastGleasonScore)
		{
			DataType am_ = LastGleasonScore?.Value;
			object an_ = fhirHelpers_4_3_000.ToValue(context, am_);
			bool? ao_ = context.Operators.LessOrEqual(an_ as int?, 6);

			return ao_;
		};
		IEnumerable<bool?> k_ = context.Operators.Select<Observation, bool?>((IEnumerable<Observation>)i_, j_);
		bool? l_ = context.Operators.SingletonFrom<bool?>(k_);

		return l_;
	}

    [CqlDeclaration("Most Recent Prostate Cancer Staging Tumor Size T1a to T2a")]
	public  Observation Most_Recent_Prostate_Cancer_Staging_Tumor_Size_T1a_to_T2a(CqlContext context)
	{
		CqlCode a_ = this.Tumor_staging__tumor_staging_(context);
		IEnumerable<CqlCode> b_ = context.Operators.ToList<CqlCode>(a_);
		IEnumerable<Observation> c_ = context.Operators.RetrieveByCodes<Observation>(b_, default);
		IEnumerable<Observation> d_(Observation ProstateCancerStaging)
		{
			Procedure m_ = this.First_Prostate_Cancer_Treatment_during_day_of_Measurement_Period(context);
			Procedure[] n_ = [
				m_,
			];
			bool? o_(Procedure FirstProstateCancerTreatment)
			{
				DataType s_ = ProstateCancerStaging?.Effective;
				object t_ = fhirHelpers_4_3_000.ToValue(context, s_);
				CqlInterval<CqlDateTime> u_ = qiCoreCommon_2_0_000.toInterval(context, t_);
				CqlDateTime v_ = context.Operators.Start(u_);
				DataType w_ = FirstProstateCancerTreatment?.Performed;
				object x_ = fhirHelpers_4_3_000.ToValue(context, w_);
				CqlInterval<CqlDateTime> y_ = qiCoreCommon_2_0_000.toInterval(context, x_);
				CqlDateTime z_ = context.Operators.Start(y_);
				bool? aa_ = context.Operators.Before(v_, z_, default);
				Code<ObservationStatus> ab_ = ProstateCancerStaging?.StatusElement;
				ObservationStatus? ac_ = ab_?.Value;
				Code<ObservationStatus> ad_ = context.Operators.Convert<Code<ObservationStatus>>(ac_);
				string ae_ = context.Operators.Convert<string>(ad_);
				string[] af_ = [
					"final",
					"amended",
					"corrected",
				];
				bool? ag_ = context.Operators.In<string>(ae_, af_ as IEnumerable<string>);
				bool? ah_ = context.Operators.And(aa_, ag_);

				return ah_;
			};
			IEnumerable<Procedure> p_ = context.Operators.Where<Procedure>((IEnumerable<Procedure>)n_, o_);
			Observation q_(Procedure FirstProstateCancerTreatment) => 
				ProstateCancerStaging;
			IEnumerable<Observation> r_ = context.Operators.Select<Procedure, Observation>(p_, q_);

			return r_;
		};
		IEnumerable<Observation> e_ = context.Operators.SelectMany<Observation, Observation>(c_, d_);
		object f_(Observation @this)
		{
			DataType ai_ = @this?.Effective;
			object aj_ = fhirHelpers_4_3_000.ToValue(context, ai_);
			CqlInterval<CqlDateTime> ak_ = qiCoreCommon_2_0_000.toInterval(context, aj_);
			CqlDateTime al_ = context.Operators.Start(ak_);

			return al_;
		};
		IEnumerable<Observation> g_ = context.Operators.SortBy<Observation>(e_, f_, System.ComponentModel.ListSortDirection.Ascending);
		Observation h_ = context.Operators.Last<Observation>(g_);
		Observation[] i_ = [
			h_,
		];
		bool? j_(Observation LastProstateCancerStaging)
		{
			DataType am_ = LastProstateCancerStaging?.Value;
			object an_ = fhirHelpers_4_3_000.ToValue(context, am_);
			CqlCode ao_ = this.T1a__Prostate_tumor_incidental_histologic_finding_in_5_percent_or_less_of_tissue_resected__finding_(context);
			CqlConcept ap_ = context.Operators.ConvertCodeToConcept(ao_);
			bool? aq_ = context.Operators.Equivalent(an_ as CqlConcept, ap_);
			object as_ = fhirHelpers_4_3_000.ToValue(context, am_);
			CqlCode at_ = this.T1b__Prostate_tumor_incidental_histologic_finding_in_greater_than_5_percent_of_tissue_resected__finding_(context);
			CqlConcept au_ = context.Operators.ConvertCodeToConcept(at_);
			bool? av_ = context.Operators.Equivalent(as_ as CqlConcept, au_);
			bool? aw_ = context.Operators.Or(aq_, av_);
			object ay_ = fhirHelpers_4_3_000.ToValue(context, am_);
			CqlCode az_ = this.Neoplasm_of_prostate_primary_tumor_staging_category_T1c__Tumor_identified_by_needle_biopsy__finding_(context);
			CqlConcept ba_ = context.Operators.ConvertCodeToConcept(az_);
			bool? bb_ = context.Operators.Equivalent(ay_ as CqlConcept, ba_);
			bool? bc_ = context.Operators.Or(aw_, bb_);
			object be_ = fhirHelpers_4_3_000.ToValue(context, am_);
			CqlCode bf_ = this.Neoplasm_of_prostate_primary_tumor_staging_category_T2a__Involves_one_half_of_one_lobe_or_less__finding_(context);
			CqlConcept bg_ = context.Operators.ConvertCodeToConcept(bf_);
			bool? bh_ = context.Operators.Equivalent(be_ as CqlConcept, bg_);
			bool? bi_ = context.Operators.Or(bc_, bh_);

			return bi_;
		};
		IEnumerable<Observation> k_ = context.Operators.Where<Observation>((IEnumerable<Observation>)i_, j_);
		Observation l_ = context.Operators.SingletonFrom<Observation>(k_);

		return l_;
	}

    [CqlDeclaration("Numerator")]
	public  bool? Numerator(CqlContext context)
	{
		IEnumerable<Observation> a_ = this.Bone_Scan_Study_Performed(context);
		bool? b_ = context.Operators.Exists<Observation>(a_);
		bool? c_ = context.Operators.Not(b_);

		return c_;
	}

    [CqlDeclaration("Most Recent PSA Test Result is Low")]
	public  bool? Most_Recent_PSA_Test_Result_is_Low(CqlContext context)
	{
		CqlValueSet a_ = this.Prostate_Specific_Antigen_Test(context);
		IEnumerable<Observation> b_ = context.Operators.RetrieveByValueSet<Observation>(a_, default);
		IEnumerable<Observation> c_(Observation PSATest)
		{
			Observation l_ = this.Most_Recent_Prostate_Cancer_Staging_Tumor_Size_T1a_to_T2a(context);
			Observation[] m_ = [
				l_,
			];
			bool? n_(Observation MostRecentProstateCancerStaging)
			{
				CqlInterval<CqlDateTime> r_()
				{
					bool ad_()
					{
						DataType ae_ = PSATest?.Effective;
						object af_ = fhirHelpers_4_3_000.ToValue(context, ae_);
						CqlInterval<CqlDateTime> ag_ = qiCoreCommon_2_0_000.toInterval(context, af_);
						CqlDateTime ah_ = context.Operators.Start(ag_);

						return ah_ is null;
					};
					if (ad_())
					{
						return default;
					}
					else
					{
						DataType ai_ = PSATest?.Effective;
						object aj_ = fhirHelpers_4_3_000.ToValue(context, ai_);
						CqlInterval<CqlDateTime> ak_ = qiCoreCommon_2_0_000.toInterval(context, aj_);
						CqlDateTime al_ = context.Operators.Start(ak_);
						object an_ = fhirHelpers_4_3_000.ToValue(context, ai_);
						CqlInterval<CqlDateTime> ao_ = qiCoreCommon_2_0_000.toInterval(context, an_);
						CqlDateTime ap_ = context.Operators.Start(ao_);
						CqlInterval<CqlDateTime> aq_ = context.Operators.Interval(al_, ap_, true, true);

						return aq_;
					}
				};
				DataType s_ = MostRecentProstateCancerStaging?.Effective;
				object t_ = fhirHelpers_4_3_000.ToValue(context, s_);
				CqlInterval<CqlDateTime> u_ = qiCoreCommon_2_0_000.toInterval(context, t_);
				bool? v_ = context.Operators.Before(r_(), u_, default);
				Code<ObservationStatus> w_ = PSATest?.StatusElement;
				ObservationStatus? x_ = w_?.Value;
				Code<ObservationStatus> y_ = context.Operators.Convert<Code<ObservationStatus>>(x_);
				string z_ = context.Operators.Convert<string>(y_);
				string[] aa_ = [
					"final",
					"amended",
					"corrected",
				];
				bool? ab_ = context.Operators.In<string>(z_, aa_ as IEnumerable<string>);
				bool? ac_ = context.Operators.And(v_, ab_);

				return ac_;
			};
			IEnumerable<Observation> o_ = context.Operators.Where<Observation>((IEnumerable<Observation>)m_, n_);
			Observation p_(Observation MostRecentProstateCancerStaging) => 
				PSATest;
			IEnumerable<Observation> q_ = context.Operators.Select<Observation, Observation>(o_, p_);

			return q_;
		};
		IEnumerable<Observation> d_ = context.Operators.SelectMany<Observation, Observation>(b_, c_);
		object e_(Observation @this)
		{
			DataType ar_ = @this?.Effective;
			object as_ = fhirHelpers_4_3_000.ToValue(context, ar_);
			CqlInterval<CqlDateTime> at_ = qiCoreCommon_2_0_000.toInterval(context, as_);
			CqlDateTime au_ = context.Operators.Start(at_);

			return au_;
		};
		IEnumerable<Observation> f_ = context.Operators.SortBy<Observation>(d_, e_, System.ComponentModel.ListSortDirection.Ascending);
		Observation g_ = context.Operators.Last<Observation>(f_);
		Observation[] h_ = [
			g_,
		];
		bool? i_(Observation LastPSATest)
		{
			DataType av_ = LastPSATest?.Value;
			object aw_ = fhirHelpers_4_3_000.ToValue(context, av_);
			CqlQuantity ax_ = context.Operators.Quantity(10m, "ng/mL");
			bool? ay_ = context.Operators.Less(aw_ as CqlQuantity, ax_);

			return ay_;
		};
		IEnumerable<bool?> j_ = context.Operators.Select<Observation, bool?>((IEnumerable<Observation>)h_, i_);
		bool? k_ = context.Operators.SingletonFrom<bool?>(j_);

		return k_;
	}

    [CqlDeclaration("Denominator")]
	public  bool? Denominator(CqlContext context)
	{
		bool? a_ = this.Initial_Population(context);
		Procedure b_ = this.First_Prostate_Cancer_Treatment_during_day_of_Measurement_Period(context);
		bool? c_ = context.Operators.Not((bool?)(b_ is null));
		bool? d_ = context.Operators.And(a_, c_);
		Observation e_ = this.Most_Recent_Prostate_Cancer_Staging_Tumor_Size_T1a_to_T2a(context);
		bool? f_ = context.Operators.Not((bool?)(e_ is null));
		bool? g_ = context.Operators.And(d_, f_);
		bool? h_ = this.Most_Recent_PSA_Test_Result_is_Low(context);
		bool? i_ = context.Operators.And(g_, h_);
		bool? j_ = this.Most_Recent_Gleason_Score_is_Low(context);
		bool? k_ = context.Operators.And(i_, j_);

		return k_;
	}

}
