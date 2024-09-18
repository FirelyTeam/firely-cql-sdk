﻿using System;
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
public static partial class IntravesicalBacillusCalmetteGuerinForBladderCancerFHIR_1_3_000ServiceCollectionExtensions
{
    public static IServiceCollection AddIntravesicalBacillusCalmetteGuerinForBladderCancerFHIR_1_3_000(this IServiceCollection services)
    {
        services.TryAddSingleton<IntravesicalBacillusCalmetteGuerinForBladderCancerFHIR_1_3_000>();
        services.AddFHIRHelpers_4_3_000();
        services.AddQICoreCommon_2_0_000();
        services.AddSupplementalDataElements_3_4_000();
        services.AddCumulativeMedicationDuration_4_0_000();
        return services;
    }
}

partial class IntravesicalBacillusCalmetteGuerinForBladderCancerFHIR_1_3_000 : ICqlLibrary
{
    public static void AddLibraryService(IServiceCollection services) =>
        services.AddIntravesicalBacillusCalmetteGuerinForBladderCancerFHIR_1_3_000();
}

[System.CodeDom.Compiler.GeneratedCode(".NET Code Generation", "2.0.3.0")]
[CqlLibrary("IntravesicalBacillusCalmetteGuerinForBladderCancerFHIR", "1.3.000")]
public partial class IntravesicalBacillusCalmetteGuerinForBladderCancerFHIR_1_3_000(
    FHIRHelpers_4_3_000 fhirHelpers_4_3_000,
    QICoreCommon_2_0_000 qiCoreCommon_2_0_000,
    SupplementalDataElements_3_4_000 supplementalDataElements_3_4_000,
    CumulativeMedicationDuration_4_0_000 cumulativeMedicationDuration_4_0_000)
{

    [CqlDeclaration("Active Tuberculosis for Urology Care")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1151.56")]
	public CqlValueSet Active_Tuberculosis_for_Urology_Care(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1151.56", default);

    [CqlDeclaration("BCG Bacillus Calmette Guerin for Urology Care")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1151.52")]
	public CqlValueSet BCG_Bacillus_Calmette_Guerin_for_Urology_Care(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1151.52", default);

    [CqlDeclaration("Bladder Cancer for Urology Care")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1151.45")]
	public CqlValueSet Bladder_Cancer_for_Urology_Care(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1151.45", default);

    [CqlDeclaration("Chemotherapy Agents for Advanced Cancer")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1151.60")]
	public CqlValueSet Chemotherapy_Agents_for_Advanced_Cancer(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1151.60", default);

    [CqlDeclaration("Cystectomy for Urology Care")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1151.55")]
	public CqlValueSet Cystectomy_for_Urology_Care(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1151.55", default);

    [CqlDeclaration("HIV")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.120.12.1003")]
	public CqlValueSet HIV(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.120.12.1003", default);

    [CqlDeclaration("Immunocompromised Conditions")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.666.5.1940")]
	public CqlValueSet Immunocompromised_Conditions(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.666.5.1940", default);

    [CqlDeclaration("Immunosuppressive Drugs for Urology Care")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1151.32")]
	public CqlValueSet Immunosuppressive_Drugs_for_Urology_Care(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1151.32", default);

    [CqlDeclaration("Mixed histology urothelial cell carcinoma for Urology Care")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1151.39")]
	public CqlValueSet Mixed_histology_urothelial_cell_carcinoma_for_Urology_Care(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1151.39", default);

    [CqlDeclaration("Office Visit")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1001")]
	public CqlValueSet Office_Visit(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1001", default);

    [CqlDeclaration("Unavailability of Bacillus Calmette Guerin for urology care")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1151.44")]
	public CqlValueSet Unavailability_of_Bacillus_Calmette_Guerin_for_urology_care(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1151.44", default);

    [CqlDeclaration("Carcinoma in situ of bladder")]
	public CqlCode Carcinoma_in_situ_of_bladder(CqlContext context) => 
		new CqlCode("D09.0", "http://hl7.org/fhir/sid/icd-10-cm", default, default);

    [CqlDeclaration("Combined radiotherapy (procedure)")]
	public CqlCode Combined_radiotherapy__procedure_(CqlContext context) => 
		new CqlCode("169331000", "http://snomed.info/sct", default, default);

    [CqlDeclaration("T1: Urinary tract tumor invades subepithelial connective tissue (finding)")]
	public CqlCode T1__Urinary_tract_tumor_invades_subepithelial_connective_tissue__finding_(CqlContext context) => 
		new CqlCode("369935001", "http://snomed.info/sct", default, default);

    [CqlDeclaration("Ta: Noninvasive papillary carcinoma (urinary tract) (finding)")]
	public CqlCode Ta__Noninvasive_papillary_carcinoma__urinary_tract___finding_(CqlContext context) => 
		new CqlCode("369949005", "http://snomed.info/sct", default, default);

    [CqlDeclaration("Tis: Carcinoma in situ (flat tumor of urinary bladder) (finding)")]
	public CqlCode Tis__Carcinoma_in_situ__flat_tumor_of_urinary_bladder___finding_(CqlContext context) => 
		new CqlCode("369934002", "http://snomed.info/sct", default, default);

    [CqlDeclaration("Tumor staging (tumor staging)")]
	public CqlCode Tumor_staging__tumor_staging_(CqlContext context) => 
		new CqlCode("254292007", "http://snomed.info/sct", default, default);

    [CqlDeclaration("Dead (finding)")]
	public CqlCode Dead__finding_(CqlContext context) => 
		new CqlCode("419099009", "http://snomed.info/sct", default, default);

    [CqlDeclaration("virtual")]
	public CqlCode @virtual(CqlContext context) => 
		new CqlCode("VR", "http://terminology.hl7.org/CodeSystem/v3-ActCode", default, default);

    [CqlDeclaration("Stage group.pathology Cancer")]
	public CqlCode Stage_group_pathology_Cancer(CqlContext context) => 
		new CqlCode("21902-2", "http://loinc.org", default, default);

    [CqlDeclaration("SNOMEDCT")]
	public CqlCode[] SNOMEDCT(CqlContext context)
	{
		CqlCode[] a_ = [
			new CqlCode("169331000", "http://snomed.info/sct", default, default),
			new CqlCode("369935001", "http://snomed.info/sct", default, default),
			new CqlCode("369949005", "http://snomed.info/sct", default, default),
			new CqlCode("369934002", "http://snomed.info/sct", default, default),
			new CqlCode("254292007", "http://snomed.info/sct", default, default),
			new CqlCode("419099009", "http://snomed.info/sct", default, default),
		];

		return a_;
	}

    [CqlDeclaration("ICD10CM")]
	public CqlCode[] ICD10CM(CqlContext context)
	{
		CqlCode[] a_ = [
			new CqlCode("D09.0", "http://hl7.org/fhir/sid/icd-10-cm", default, default),
		];

		return a_;
	}

    [CqlDeclaration("LOINC")]
	public CqlCode[] LOINC(CqlContext context)
	{
		CqlCode[] a_ = [
			new CqlCode("21902-2", "http://loinc.org", default, default),
		];

		return a_;
	}

    [CqlDeclaration("ActCode")]
	public CqlCode[] ActCode(CqlContext context)
	{
		CqlCode[] a_ = [
			new CqlCode("VR", "http://terminology.hl7.org/CodeSystem/v3-ActCode", default, default),
		];

		return a_;
	}

    [CqlDeclaration("Measurement Period")]
	public CqlInterval<CqlDateTime> Measurement_Period(CqlContext context)
	{
		CqlDateTime a_ = context.Operators.DateTime(2025, 1, 1, 0, 0, 0, 0, default);
		CqlDateTime b_ = context.Operators.DateTime(2026, 1, 1, 0, 0, 0, 0, default);
		CqlInterval<CqlDateTime> c_ = context.Operators.Interval(a_, b_, true, false);
		object d_ = context.ResolveParameter("IntravesicalBacillusCalmetteGuerinForBladderCancerFHIR-1.3.000", "Measurement Period", c_);

		return (CqlInterval<CqlDateTime>)d_;
	}

    [CqlDeclaration("Patient")]
	public Patient Patient(CqlContext context)
	{
		IEnumerable<Patient> a_ = context.Operators.RetrieveByValueSet<Patient>(default, default);
		Patient b_ = context.Operators.SingletonFrom<Patient>(a_);

		return b_;
	}

    [CqlDeclaration("isConfirmedActiveDiagnosis")]
	public bool? isConfirmedActiveDiagnosis(CqlContext context, Condition Condition)
	{
		Condition[] a_ = [
			Condition,
		];
		bool? b_(Condition Diagnosis)
		{
			CodeableConcept f_ = Diagnosis?.ClinicalStatus;
			CqlConcept g_ = fhirHelpers_4_3_000.ToConcept(context, f_);
			CqlCode h_ = qiCoreCommon_2_0_000.active(context);
			CqlConcept i_ = context.Operators.ConvertCodeToConcept(h_);
			bool? j_ = context.Operators.Equivalent(g_, i_);
			CodeableConcept k_ = Diagnosis?.VerificationStatus;
			CqlConcept l_ = fhirHelpers_4_3_000.ToConcept(context, k_);
			CqlCode m_ = qiCoreCommon_2_0_000.unconfirmed(context);
			CqlConcept n_ = context.Operators.ConvertCodeToConcept(m_);
			bool? o_ = context.Operators.Equivalent(l_, n_);
			CqlConcept q_ = fhirHelpers_4_3_000.ToConcept(context, k_);
			CqlCode r_ = qiCoreCommon_2_0_000.refuted(context);
			CqlConcept s_ = context.Operators.ConvertCodeToConcept(r_);
			bool? t_ = context.Operators.Equivalent(q_, s_);
			bool? u_ = context.Operators.Or(o_, t_);
			CqlConcept w_ = fhirHelpers_4_3_000.ToConcept(context, k_);
			CqlCode x_ = qiCoreCommon_2_0_000.entered_in_error(context);
			CqlConcept y_ = context.Operators.ConvertCodeToConcept(x_);
			bool? z_ = context.Operators.Equivalent(w_, y_);
			bool? aa_ = context.Operators.Or(u_, z_);
			bool? ab_ = context.Operators.Not(aa_);
			bool? ac_ = context.Operators.And(j_, ab_);

			return ac_;
		};
		IEnumerable<Condition> c_ = context.Operators.Where<Condition>((IEnumerable<Condition>)a_, b_);
		Condition d_ = context.Operators.SingletonFrom<Condition>(c_);
		bool? e_ = context.Operators.Not((bool?)(d_ is null));

		return e_;
	}

    [CqlDeclaration("Bladder Cancer Diagnosis")]
	public IEnumerable<Condition> Bladder_Cancer_Diagnosis(CqlContext context)
	{
		CqlValueSet a_ = this.Bladder_Cancer_for_Urology_Care(context);
		IEnumerable<Condition> b_ = context.Operators.RetrieveByValueSet<Condition>(a_, default);
		bool? c_(Condition BladderCancer)
		{
			CqlInterval<CqlDateTime> e_ = qiCoreCommon_2_0_000.prevalenceInterval(context, BladderCancer);
			CqlDateTime f_ = context.Operators.Start(e_);
			CqlInterval<CqlDateTime> g_ = this.Measurement_Period(context);
			CqlDateTime h_ = context.Operators.End(g_);
			bool? i_ = context.Operators.Before(f_, h_, default);
			bool? j_ = this.isConfirmedActiveDiagnosis(context, BladderCancer);
			bool? k_ = context.Operators.And(i_, j_);

			return k_;
		};
		IEnumerable<Condition> d_ = context.Operators.Where<Condition>(b_, c_);

		return d_;
	}

    [CqlDeclaration("First Bladder Cancer Staging Procedure")]
	public Procedure First_Bladder_Cancer_Staging_Procedure(CqlContext context)
	{
		CqlCode a_ = this.Tumor_staging__tumor_staging_(context);
		IEnumerable<CqlCode> b_ = context.Operators.ToList<CqlCode>(a_);
		IEnumerable<Procedure> c_ = context.Operators.RetrieveByCodes<Procedure>(b_, default);
		IEnumerable<Procedure> d_(Procedure BladderCancerStaging)
		{
			IEnumerable<Condition> k_ = this.Bladder_Cancer_Diagnosis(context);
			bool? l_(Condition BladderCancer)
			{
				DataType p_ = BladderCancerStaging?.Performed;
				object q_ = fhirHelpers_4_3_000.ToValue(context, p_);
				CqlInterval<CqlDateTime> r_ = qiCoreCommon_2_0_000.toInterval(context, q_);
				CqlDateTime s_ = context.Operators.Start(r_);
				CqlInterval<CqlDateTime> t_ = qiCoreCommon_2_0_000.prevalenceInterval(context, BladderCancer);
				CqlDateTime u_ = context.Operators.Start(t_);
				bool? v_ = context.Operators.SameOrBefore(s_, u_, "day");
				object x_ = fhirHelpers_4_3_000.ToValue(context, p_);
				CqlInterval<CqlDateTime> y_ = qiCoreCommon_2_0_000.toInterval(context, x_);
				bool? aa_ = context.Operators.Overlaps(y_, t_, "day");
				bool? ab_ = context.Operators.And(v_, aa_);

				return ab_;
			};
			IEnumerable<Condition> m_ = context.Operators.Where<Condition>(k_, l_);
			Procedure n_(Condition BladderCancer) => 
				BladderCancerStaging;
			IEnumerable<Procedure> o_ = context.Operators.Select<Condition, Procedure>(m_, n_);

			return o_;
		};
		IEnumerable<Procedure> e_ = context.Operators.SelectMany<Procedure, Procedure>(c_, d_);
		bool? f_(Procedure BladderCancerStaging)
		{
			Code<EventStatus> ac_ = BladderCancerStaging?.StatusElement;
			EventStatus? ad_ = ac_?.Value;
			string ae_ = context.Operators.Convert<string>(ad_);
			bool? af_ = context.Operators.Equal(ae_, "completed");

			return af_;
		};
		IEnumerable<Procedure> g_ = context.Operators.Where<Procedure>(e_, f_);
		object h_(Procedure @this)
		{
			DataType ag_ = @this?.Performed;
			object ah_ = fhirHelpers_4_3_000.ToValue(context, ag_);
			CqlInterval<CqlDateTime> ai_ = qiCoreCommon_2_0_000.toInterval(context, ah_);
			CqlDateTime aj_ = context.Operators.Start(ai_);

			return aj_;
		};
		IEnumerable<Procedure> i_ = context.Operators.SortBy<Procedure>(g_, h_, System.ComponentModel.ListSortDirection.Ascending);
		Procedure j_ = context.Operators.First<Procedure>(i_);

		return j_;
	}

    [CqlDeclaration("July 1 of Year Prior to the Measurement Period")]
	public CqlDateTime July_1_of_Year_Prior_to_the_Measurement_Period(CqlContext context)
	{
		CqlInterval<CqlDateTime> a_ = this.Measurement_Period(context);
		CqlDateTime b_ = context.Operators.Start(a_);
		int? c_ = context.Operators.DateTimeComponentFrom(b_, "year");
		int? d_ = context.Operators.Subtract(c_, 1);
		decimal? e_ = context.Operators.ConvertIntegerToDecimal(0);
		CqlDateTime f_ = context.Operators.DateTime(d_, 7, 1, 0, 0, 0, 0, e_);

		return f_;
	}

    [CqlDeclaration("June 30 of the Measurement Period")]
	public CqlDateTime June_30_of_the_Measurement_Period(CqlContext context)
	{
		CqlInterval<CqlDateTime> a_ = this.Measurement_Period(context);
		CqlDateTime b_ = context.Operators.Start(a_);
		int? c_ = context.Operators.DateTimeComponentFrom(b_, "year");
		decimal? d_ = context.Operators.ConvertIntegerToDecimal(0);
		CqlDateTime e_ = context.Operators.DateTime(c_, 6, 30, 23, 59, 59, 0, d_);

		return e_;
	}

    [CqlDeclaration("First Qualifying Bladder Cancer Staging Procedure")]
	public Procedure First_Qualifying_Bladder_Cancer_Staging_Procedure(CqlContext context)
	{
		Procedure a_ = this.First_Bladder_Cancer_Staging_Procedure(context);
		Procedure[] b_ = [
			a_,
		];
		bool? c_(Procedure FirstBladderCancerStaging)
		{
			CqlDateTime f_ = this.July_1_of_Year_Prior_to_the_Measurement_Period(context);
			CqlDateTime g_ = this.June_30_of_the_Measurement_Period(context);
			CqlInterval<CqlDateTime> h_ = context.Operators.Interval(f_, g_, true, true);
			DataType i_ = FirstBladderCancerStaging?.Performed;
			object j_ = fhirHelpers_4_3_000.ToValue(context, i_);
			CqlInterval<CqlDateTime> k_ = qiCoreCommon_2_0_000.toInterval(context, j_);
			bool? l_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(h_, k_, "day");

			return l_;
		};
		IEnumerable<Procedure> d_ = context.Operators.Where<Procedure>((IEnumerable<Procedure>)b_, c_);
		Procedure e_ = context.Operators.SingletonFrom<Procedure>(d_);

		return e_;
	}

    [CqlDeclaration("First Bladder Cancer Staging Procedure during 6 Months Prior to Measurement Period through the First 6 Months of Measurement Period")]
	public Procedure First_Bladder_Cancer_Staging_Procedure_during_6_Months_Prior_to_Measurement_Period_through_the_First_6_Months_of_Measurement_Period(CqlContext context)
	{
		Procedure a_ = this.First_Bladder_Cancer_Staging_Procedure(context);
		Procedure[] b_ = [
			a_,
		];
		bool? c_(Procedure FirstBladderCancerStaging)
		{
			CqlDateTime f_ = this.July_1_of_Year_Prior_to_the_Measurement_Period(context);
			CqlDateTime g_ = this.June_30_of_the_Measurement_Period(context);
			CqlInterval<CqlDateTime> h_ = context.Operators.Interval(f_, g_, true, true);
			DataType i_ = FirstBladderCancerStaging?.Performed;
			object j_ = fhirHelpers_4_3_000.ToValue(context, i_);
			CqlInterval<CqlDateTime> k_ = qiCoreCommon_2_0_000.toInterval(context, j_);
			bool? l_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(h_, k_, "day");

			return l_;
		};
		IEnumerable<Procedure> d_ = context.Operators.Where<Procedure>((IEnumerable<Procedure>)b_, c_);
		Procedure e_ = context.Operators.SingletonFrom<Procedure>(d_);

		return e_;
	}

    [CqlDeclaration("getStagingProcedure")]
	public IEnumerable<Procedure> getStagingProcedure(CqlContext context, Observation StagingObservation)
	{
		List<ResourceReference> a_ = StagingObservation?.PartOf;
		Procedure b_(ResourceReference StagingReference)
		{
			Procedure d_ = this.First_Bladder_Cancer_Staging_Procedure_during_6_Months_Prior_to_Measurement_Period_through_the_First_6_Months_of_Measurement_Period(context);
			Procedure[] e_ = [
				d_,
			];
			bool? f_(Procedure FirstBladderCancerStagingMP)
			{
				Id i_ = FirstBladderCancerStagingMP?.IdElement;
				string j_ = i_?.Value;
				FhirString k_ = StagingReference?.ReferenceElement;
				string l_ = k_?.Value;
				string m_ = qiCoreCommon_2_0_000.getId(context, l_);
				bool? n_ = context.Operators.Equal(j_, m_);

				return n_;
			};
			IEnumerable<Procedure> g_ = context.Operators.Where<Procedure>((IEnumerable<Procedure>)e_, f_);
			Procedure h_ = context.Operators.SingletonFrom<Procedure>(g_);

			return h_;
		};
		IEnumerable<Procedure> c_ = context.Operators.Select<ResourceReference, Procedure>((IEnumerable<ResourceReference>)a_, b_);

		return c_;
	}

    [CqlDeclaration("Has Most Recent Bladder Cancer Tumor Staging is Ta HG, Tis, T1")]
	public bool? Has_Most_Recent_Bladder_Cancer_Tumor_Staging_is_Ta_HG__Tis__T1(CqlContext context)
	{
		CqlCode a_ = this.Stage_group_pathology_Cancer(context);
		IEnumerable<CqlCode> b_ = context.Operators.ToList<CqlCode>(a_);
		IEnumerable<Observation> c_ = context.Operators.RetrieveByCodes<Observation>(b_, default);
		bool? d_(Observation StagingObservation)
		{
			IEnumerable<Procedure> g_ = this.getStagingProcedure(context, StagingObservation);
			bool? h_ = context.Operators.Not((bool?)(g_ is null));
			DataType i_ = StagingObservation?.Value;
			object j_ = fhirHelpers_4_3_000.ToValue(context, i_);
			CqlCode k_ = this.T1__Urinary_tract_tumor_invades_subepithelial_connective_tissue__finding_(context);
			CqlConcept l_ = context.Operators.ConvertCodeToConcept(k_);
			bool? m_ = context.Operators.Equivalent(j_ as CqlConcept, l_);
			object o_ = fhirHelpers_4_3_000.ToValue(context, i_);
			CqlCode p_ = this.Ta__Noninvasive_papillary_carcinoma__urinary_tract___finding_(context);
			CqlConcept q_ = context.Operators.ConvertCodeToConcept(p_);
			bool? r_ = context.Operators.Equivalent(o_ as CqlConcept, q_);
			bool? s_ = context.Operators.Or(m_, r_);
			object u_ = fhirHelpers_4_3_000.ToValue(context, i_);
			CqlCode v_ = this.Tis__Carcinoma_in_situ__flat_tumor_of_urinary_bladder___finding_(context);
			CqlConcept w_ = context.Operators.ConvertCodeToConcept(v_);
			bool? x_ = context.Operators.Equivalent(u_ as CqlConcept, w_);
			bool? y_ = context.Operators.Or(s_, x_);
			object aa_ = fhirHelpers_4_3_000.ToValue(context, i_);
			CqlCode ab_ = this.Carcinoma_in_situ_of_bladder(context);
			CqlConcept ac_ = context.Operators.ConvertCodeToConcept(ab_);
			bool? ad_ = context.Operators.Equivalent(aa_ as CqlConcept, ac_);
			bool? ae_ = context.Operators.Or(y_, ad_);
			bool? af_ = context.Operators.And(h_, ae_);
			Code<ObservationStatus> ag_ = StagingObservation?.StatusElement;
			ObservationStatus? ah_ = ag_?.Value;
			Code<ObservationStatus> ai_ = context.Operators.Convert<Code<ObservationStatus>>(ah_);
			string aj_ = context.Operators.Convert<string>(ai_);
			string[] ak_ = [
				"final",
				"amended",
				"corrected",
			];
			bool? al_ = context.Operators.In<string>(aj_, ak_ as IEnumerable<string>);
			bool? am_ = context.Operators.And(af_, al_);

			return am_;
		};
		IEnumerable<Observation> e_ = context.Operators.Where<Observation>(c_, d_);
		bool? f_ = context.Operators.Exists<Observation>(e_);

		return f_;
	}

    [CqlDeclaration("Has Qualifying Encounter")]
	public bool? Has_Qualifying_Encounter(CqlContext context)
	{
		CqlValueSet a_ = this.Office_Visit(context);
		IEnumerable<Encounter> b_ = context.Operators.RetrieveByValueSet<Encounter>(a_, default);
		bool? c_(Encounter ValidEncounter)
		{
			CqlInterval<CqlDateTime> f_ = this.Measurement_Period(context);
			Period g_ = ValidEncounter?.Period;
			CqlInterval<CqlDateTime> h_ = fhirHelpers_4_3_000.ToInterval(context, g_);
			bool? i_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(f_, h_, default);
			Coding j_ = ValidEncounter?.Class;
			CqlCode k_ = fhirHelpers_4_3_000.ToCode(context, j_);
			CqlCode l_ = this.@virtual(context);
			bool? m_ = context.Operators.Equivalent(k_, l_);
			bool? n_ = context.Operators.Not(m_);
			bool? o_ = context.Operators.And(i_, n_);
			Code<Encounter.EncounterStatus> p_ = ValidEncounter?.StatusElement;
			Encounter.EncounterStatus? q_ = p_?.Value;
			Code<Encounter.EncounterStatus> r_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(q_);
			bool? s_ = context.Operators.Equal(r_, "finished");
			bool? t_ = context.Operators.And(o_, s_);

			return t_;
		};
		IEnumerable<Encounter> d_ = context.Operators.Where<Encounter>(b_, c_);
		bool? e_ = context.Operators.Exists<Encounter>(d_);

		return e_;
	}

    [CqlDeclaration("Initial Population")]
	public bool? Initial_Population(CqlContext context)
	{
		Procedure a_ = this.First_Qualifying_Bladder_Cancer_Staging_Procedure(context);
		bool? b_ = context.Operators.Not((bool?)(a_ is null));
		bool? c_ = this.Has_Most_Recent_Bladder_Cancer_Tumor_Staging_is_Ta_HG__Tis__T1(context);
		bool? d_ = context.Operators.And(b_, c_);
		bool? e_ = this.Has_Qualifying_Encounter(context);
		bool? f_ = context.Operators.And(d_, e_);

		return f_;
	}

    [CqlDeclaration("Denominator")]
	public bool? Denominator(CqlContext context)
	{
		bool? a_ = this.Initial_Population(context);

		return a_;
	}

    [CqlDeclaration("BCG Not Available Within 6 Months After Bladder Cancer Staging")]
	public IEnumerable<MedicationAdministration> BCG_Not_Available_Within_6_Months_After_Bladder_Cancer_Staging(CqlContext context)
	{
		CqlValueSet a_ = this.BCG_Bacillus_Calmette_Guerin_for_Urology_Care(context);
		IEnumerable<MedicationAdministration> b_ = context.Operators.RetrieveByValueSet<MedicationAdministration>(a_, default);
		IEnumerable<MedicationAdministration> d_ = context.Operators.RetrieveByValueSet<MedicationAdministration>(a_, default);
		IEnumerable<MedicationAdministration> e_ = context.Operators.Union<MedicationAdministration>(b_, d_);
		IEnumerable<MedicationAdministration> f_(MedicationAdministration BCGNotGiven)
		{
			Procedure j_ = this.First_Bladder_Cancer_Staging_Procedure(context);
			Procedure[] k_ = [
				j_,
			];
			bool? l_(Procedure FirstBladderCancerStaging)
			{
				bool? p_(Extension @this)
				{
					string aw_ = @this?.Url;
					FhirString ax_ = context.Operators.Convert<FhirString>(aw_);
					string ay_ = fhirHelpers_4_3_000.ToString(context, ax_);
					bool? az_ = context.Operators.Equal(ay_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-recorded");

					return az_;
				};
				IEnumerable<Extension> q_ = context.Operators.Where<Extension>((IEnumerable<Extension>)(BCGNotGiven is DomainResource
						? (BCGNotGiven as DomainResource).Extension
						: default), p_);
				DataType r_(Extension @this)
				{
					DataType ba_ = @this?.Value;

					return ba_;
				};
				IEnumerable<DataType> s_ = context.Operators.Select<Extension, DataType>(q_, r_);
				DataType t_ = context.Operators.SingletonFrom<DataType>(s_);
				CqlDateTime u_ = context.Operators.Convert<CqlDateTime>(t_);
				DataType v_ = FirstBladderCancerStaging?.Performed;
				object w_ = fhirHelpers_4_3_000.ToValue(context, v_);
				CqlInterval<CqlDateTime> x_ = qiCoreCommon_2_0_000.toInterval(context, w_);
				CqlDateTime y_ = context.Operators.Start(x_);
				object aa_ = fhirHelpers_4_3_000.ToValue(context, v_);
				CqlInterval<CqlDateTime> ab_ = qiCoreCommon_2_0_000.toInterval(context, aa_);
				CqlDateTime ac_ = context.Operators.Start(ab_);
				CqlQuantity ad_ = context.Operators.Quantity(6m, "months");
				CqlDateTime ae_ = context.Operators.Add(ac_, ad_);
				CqlInterval<CqlDateTime> af_ = context.Operators.Interval(y_, ae_, false, true);
				bool? ag_ = context.Operators.In<CqlDateTime>(u_, af_, default);
				object ai_ = fhirHelpers_4_3_000.ToValue(context, v_);
				CqlInterval<CqlDateTime> aj_ = qiCoreCommon_2_0_000.toInterval(context, ai_);
				CqlDateTime ak_ = context.Operators.Start(aj_);
				bool? al_ = context.Operators.Not((bool?)(ak_ is null));
				bool? am_ = context.Operators.And(ag_, al_);
				bool? an_(Extension @this)
				{
					string bb_ = @this?.Url;
					FhirString bc_ = context.Operators.Convert<FhirString>(bb_);
					string bd_ = fhirHelpers_4_3_000.ToString(context, bc_);
					bool? be_ = context.Operators.Equal(bd_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-recorded");

					return be_;
				};
				IEnumerable<Extension> ao_ = context.Operators.Where<Extension>((IEnumerable<Extension>)(BCGNotGiven is DomainResource
						? (BCGNotGiven as DomainResource).Extension
						: default), an_);
				DataType ap_(Extension @this)
				{
					DataType bf_ = @this?.Value;

					return bf_;
				};
				IEnumerable<DataType> aq_ = context.Operators.Select<Extension, DataType>(ao_, ap_);
				DataType ar_ = context.Operators.SingletonFrom<DataType>(aq_);
				CqlDateTime as_ = context.Operators.Convert<CqlDateTime>(ar_);
				CqlInterval<CqlDateTime> at_ = this.Measurement_Period(context);
				bool? au_ = context.Operators.In<CqlDateTime>(as_, at_, default);
				bool? av_ = context.Operators.And(am_, au_);

				return av_;
			};
			IEnumerable<Procedure> m_ = context.Operators.Where<Procedure>((IEnumerable<Procedure>)k_, l_);
			MedicationAdministration n_(Procedure FirstBladderCancerStaging) => 
				BCGNotGiven;
			IEnumerable<MedicationAdministration> o_ = context.Operators.Select<Procedure, MedicationAdministration>(m_, n_);

			return o_;
		};
		IEnumerable<MedicationAdministration> g_ = context.Operators.SelectMany<MedicationAdministration, MedicationAdministration>(e_, f_);
		bool? h_(MedicationAdministration BCGNotGiven)
		{
			List<CodeableConcept> bg_ = BCGNotGiven?.StatusReason;
			CqlConcept bh_(CodeableConcept @this)
			{
				CqlConcept bl_ = fhirHelpers_4_3_000.ToConcept(context, @this);

				return bl_;
			};
			IEnumerable<CqlConcept> bi_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)bg_, bh_);
			CqlValueSet bj_ = this.Unavailability_of_Bacillus_Calmette_Guerin_for_urology_care(context);
			bool? bk_ = context.Operators.ConceptsInValueSet(bi_, bj_);

			return bk_;
		};
		IEnumerable<MedicationAdministration> i_ = context.Operators.Where<MedicationAdministration>(g_, h_);

		return i_;
	}

    [CqlDeclaration("Denominator Exception")]
	public bool? Denominator_Exception(CqlContext context)
	{
		IEnumerable<MedicationAdministration> a_ = this.BCG_Not_Available_Within_6_Months_After_Bladder_Cancer_Staging(context);
		bool? b_ = context.Operators.Exists<MedicationAdministration>(a_);

		return b_;
	}

    [CqlDeclaration("First BCG Administered")]
	public MedicationAdministration First_BCG_Administered(CqlContext context)
	{
		CqlValueSet a_ = this.BCG_Bacillus_Calmette_Guerin_for_Urology_Care(context);
		IEnumerable<MedicationAdministration> b_ = context.Operators.RetrieveByValueSet<MedicationAdministration>(a_, default);
		IEnumerable<MedicationAdministration> d_ = context.Operators.RetrieveByValueSet<MedicationAdministration>(a_, default);
		IEnumerable<MedicationAdministration> e_ = context.Operators.Union<MedicationAdministration>(b_, d_);
		IEnumerable<MedicationAdministration> f_(MedicationAdministration BCG)
		{
			Procedure m_ = this.First_Bladder_Cancer_Staging_Procedure(context);
			Procedure[] n_ = [
				m_,
			];
			bool? o_(Procedure FirstBladderCancerStaging)
			{
				DataType s_ = BCG?.Effective;
				object t_ = fhirHelpers_4_3_000.ToValue(context, s_);
				CqlInterval<CqlDateTime> u_ = qiCoreCommon_2_0_000.toInterval(context, t_);
				CqlDateTime v_ = context.Operators.Start(u_);
				DataType w_ = FirstBladderCancerStaging?.Performed;
				object x_ = fhirHelpers_4_3_000.ToValue(context, w_);
				CqlInterval<CqlDateTime> y_ = qiCoreCommon_2_0_000.toInterval(context, x_);
				CqlDateTime z_ = context.Operators.Start(y_);
				object ab_ = fhirHelpers_4_3_000.ToValue(context, w_);
				CqlInterval<CqlDateTime> ac_ = qiCoreCommon_2_0_000.toInterval(context, ab_);
				CqlDateTime ad_ = context.Operators.Start(ac_);
				CqlQuantity ae_ = context.Operators.Quantity(6m, "months");
				CqlDateTime af_ = context.Operators.Add(ad_, ae_);
				CqlInterval<CqlDateTime> ag_ = context.Operators.Interval(z_, af_, false, true);
				bool? ah_ = context.Operators.In<CqlDateTime>(v_, ag_, default);
				object aj_ = fhirHelpers_4_3_000.ToValue(context, w_);
				CqlInterval<CqlDateTime> ak_ = qiCoreCommon_2_0_000.toInterval(context, aj_);
				CqlDateTime al_ = context.Operators.Start(ak_);
				bool? am_ = context.Operators.Not((bool?)(al_ is null));
				bool? an_ = context.Operators.And(ah_, am_);
				object ap_ = fhirHelpers_4_3_000.ToValue(context, s_);
				CqlInterval<CqlDateTime> aq_ = qiCoreCommon_2_0_000.toInterval(context, ap_);
				CqlDateTime ar_ = context.Operators.Start(aq_);
				CqlInterval<CqlDateTime> as_ = this.Measurement_Period(context);
				bool? at_ = context.Operators.In<CqlDateTime>(ar_, as_, default);
				bool? au_ = context.Operators.And(an_, at_);

				return au_;
			};
			IEnumerable<Procedure> p_ = context.Operators.Where<Procedure>((IEnumerable<Procedure>)n_, o_);
			MedicationAdministration q_(Procedure FirstBladderCancerStaging) => 
				BCG;
			IEnumerable<MedicationAdministration> r_ = context.Operators.Select<Procedure, MedicationAdministration>(p_, q_);

			return r_;
		};
		IEnumerable<MedicationAdministration> g_ = context.Operators.SelectMany<MedicationAdministration, MedicationAdministration>(e_, f_);
		bool? h_(MedicationAdministration BCG)
		{
			Code<MedicationAdministration.MedicationAdministrationStatusCodes> av_ = BCG?.StatusElement;
			MedicationAdministration.MedicationAdministrationStatusCodes? aw_ = av_?.Value;
			Code<MedicationAdministration.MedicationAdministrationStatusCodes> ax_ = context.Operators.Convert<Code<MedicationAdministration.MedicationAdministrationStatusCodes>>(aw_);
			string ay_ = context.Operators.Convert<string>(ax_);
			string[] az_ = [
				"in-progress",
				"completed",
			];
			bool? ba_ = context.Operators.In<string>(ay_, az_ as IEnumerable<string>);

			return ba_;
		};
		IEnumerable<MedicationAdministration> i_ = context.Operators.Where<MedicationAdministration>(g_, h_);
		object j_(MedicationAdministration @this)
		{
			DataType bb_ = @this?.Effective;
			object bc_ = fhirHelpers_4_3_000.ToValue(context, bb_);
			CqlInterval<CqlDateTime> bd_ = qiCoreCommon_2_0_000.toInterval(context, bc_);
			CqlDateTime be_ = context.Operators.Start(bd_);

			return be_;
		};
		IEnumerable<MedicationAdministration> k_ = context.Operators.SortBy<MedicationAdministration>(i_, j_, System.ComponentModel.ListSortDirection.Ascending);
		MedicationAdministration l_ = context.Operators.First<MedicationAdministration>(k_);

		return l_;
	}

    [CqlDeclaration("Numerator")]
	public bool? Numerator(CqlContext context)
	{
		MedicationAdministration a_ = this.First_BCG_Administered(context);
		bool? b_ = context.Operators.Not((bool?)(a_ is null));

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

    [CqlDeclaration("Acute Tuberculosis Diagnosis")]
	public IEnumerable<Condition> Acute_Tuberculosis_Diagnosis(CqlContext context)
	{
		CqlValueSet a_ = this.Active_Tuberculosis_for_Urology_Care(context);
		IEnumerable<Condition> b_ = context.Operators.RetrieveByValueSet<Condition>(a_, default);
		IEnumerable<Condition> c_(Condition ActiveTuberculosis)
		{
			Procedure g_ = this.First_Bladder_Cancer_Staging_Procedure(context);
			Procedure[] h_ = [
				g_,
			];
			bool? i_(Procedure FirstBladderCancerStaging)
			{
				CqlInterval<CqlDateTime> m_ = qiCoreCommon_2_0_000.prevalenceInterval(context, ActiveTuberculosis);
				DataType n_ = FirstBladderCancerStaging?.Performed;
				object o_ = fhirHelpers_4_3_000.ToValue(context, n_);
				CqlInterval<CqlDateTime> p_ = qiCoreCommon_2_0_000.toInterval(context, o_);
				bool? q_ = context.Operators.OverlapsAfter(m_, p_, default);

				return q_;
			};
			IEnumerable<Procedure> j_ = context.Operators.Where<Procedure>((IEnumerable<Procedure>)h_, i_);
			Condition k_(Procedure FirstBladderCancerStaging) => 
				ActiveTuberculosis;
			IEnumerable<Condition> l_ = context.Operators.Select<Procedure, Condition>(j_, k_);

			return l_;
		};
		IEnumerable<Condition> d_ = context.Operators.SelectMany<Condition, Condition>(b_, c_);
		bool? e_(Condition ActiveTuberculosis)
		{
			bool? r_ = this.isConfirmedActiveDiagnosis(context, ActiveTuberculosis);

			return r_;
		};
		IEnumerable<Condition> f_ = context.Operators.Where<Condition>(d_, e_);

		return f_;
	}

    [CqlDeclaration("Immunosuppressive Drugs")]
	public IEnumerable<MedicationRequest> Immunosuppressive_Drugs(CqlContext context)
	{
		CqlValueSet a_ = this.Immunosuppressive_Drugs_for_Urology_Care(context);
		IEnumerable<MedicationRequest> b_ = context.Operators.RetrieveByValueSet<MedicationRequest>(a_, default);
		IEnumerable<MedicationRequest> d_ = context.Operators.RetrieveByValueSet<MedicationRequest>(a_, default);
		IEnumerable<MedicationRequest> e_ = context.Operators.Union<MedicationRequest>(b_, d_);
		IEnumerable<MedicationRequest> f_(MedicationRequest ImmunosuppressiveDrugs)
		{
			Procedure h_ = this.First_Bladder_Cancer_Staging_Procedure(context);
			Procedure[] i_ = [
				h_,
			];
			bool? j_(Procedure FirstBladderCancerStaging)
			{
				CqlInterval<CqlDate> n_ = cumulativeMedicationDuration_4_0_000.MedicationRequestPeriod(context, ImmunosuppressiveDrugs);
				CqlDate o_ = context.Operators.Start(n_);
				CqlDateTime p_ = context.Operators.ConvertDateToDateTime(o_);
				DataType q_ = FirstBladderCancerStaging?.Performed;
				object r_ = fhirHelpers_4_3_000.ToValue(context, q_);
				CqlInterval<CqlDateTime> s_ = qiCoreCommon_2_0_000.toInterval(context, r_);
				CqlDateTime t_ = context.Operators.Start(s_);
				bool? u_ = context.Operators.SameOrBefore(p_, t_, default);

				return u_;
			};
			IEnumerable<Procedure> k_ = context.Operators.Where<Procedure>((IEnumerable<Procedure>)i_, j_);
			MedicationRequest l_(Procedure FirstBladderCancerStaging) => 
				ImmunosuppressiveDrugs;
			IEnumerable<MedicationRequest> m_ = context.Operators.Select<Procedure, MedicationRequest>(k_, l_);

			return m_;
		};
		IEnumerable<MedicationRequest> g_ = context.Operators.SelectMany<MedicationRequest, MedicationRequest>(e_, f_);

		return g_;
	}

    [CqlDeclaration("Cystectomy Done")]
	public IEnumerable<Procedure> Cystectomy_Done(CqlContext context)
	{
		CqlValueSet a_ = this.Cystectomy_for_Urology_Care(context);
		IEnumerable<Procedure> b_ = context.Operators.RetrieveByValueSet<Procedure>(a_, default);
		IEnumerable<Procedure> c_(Procedure Cystectomy)
		{
			Procedure g_ = this.First_Bladder_Cancer_Staging_Procedure(context);
			Procedure[] h_ = [
				g_,
			];
			bool? i_(Procedure FirstBladderCancerStaging)
			{
				DataType m_ = Cystectomy?.Performed;
				object n_ = fhirHelpers_4_3_000.ToValue(context, m_);
				CqlInterval<CqlDateTime> o_ = qiCoreCommon_2_0_000.toInterval(context, n_);
				CqlDateTime p_ = context.Operators.End(o_);
				DataType q_ = FirstBladderCancerStaging?.Performed;
				object r_ = fhirHelpers_4_3_000.ToValue(context, q_);
				CqlInterval<CqlDateTime> s_ = qiCoreCommon_2_0_000.toInterval(context, r_);
				CqlDateTime t_ = context.Operators.Start(s_);
				CqlQuantity u_ = context.Operators.Quantity(6m, "months");
				CqlDateTime v_ = context.Operators.Subtract(t_, u_);
				object x_ = fhirHelpers_4_3_000.ToValue(context, q_);
				CqlInterval<CqlDateTime> y_ = qiCoreCommon_2_0_000.toInterval(context, x_);
				CqlDateTime z_ = context.Operators.Start(y_);
				CqlInterval<CqlDateTime> aa_ = context.Operators.Interval(v_, z_, true, false);
				bool? ab_ = context.Operators.In<CqlDateTime>(p_, aa_, default);
				object ad_ = fhirHelpers_4_3_000.ToValue(context, q_);
				CqlInterval<CqlDateTime> ae_ = qiCoreCommon_2_0_000.toInterval(context, ad_);
				CqlDateTime af_ = context.Operators.Start(ae_);
				bool? ag_ = context.Operators.Not((bool?)(af_ is null));
				bool? ah_ = context.Operators.And(ab_, ag_);

				return ah_;
			};
			IEnumerable<Procedure> j_ = context.Operators.Where<Procedure>((IEnumerable<Procedure>)h_, i_);
			Procedure k_(Procedure FirstBladderCancerStaging) => 
				Cystectomy;
			IEnumerable<Procedure> l_ = context.Operators.Select<Procedure, Procedure>(j_, k_);

			return l_;
		};
		IEnumerable<Procedure> d_ = context.Operators.SelectMany<Procedure, Procedure>(b_, c_);
		bool? e_(Procedure Cystectomy)
		{
			Code<EventStatus> ai_ = Cystectomy?.StatusElement;
			EventStatus? aj_ = ai_?.Value;
			string ak_ = context.Operators.Convert<string>(aj_);
			bool? al_ = context.Operators.Equal(ak_, "completed");

			return al_;
		};
		IEnumerable<Procedure> f_ = context.Operators.Where<Procedure>(d_, e_);

		return f_;
	}

    [CqlDeclaration("Has Excluding  HIV, Immunocompromised Conditions or Mixed Histology Before Staging")]
	public bool? Has_Excluding__HIV__Immunocompromised_Conditions_or_Mixed_Histology_Before_Staging(CqlContext context)
	{
		CqlValueSet a_ = this.HIV(context);
		IEnumerable<Condition> b_ = context.Operators.RetrieveByValueSet<Condition>(a_, default);
		CqlValueSet c_ = this.Immunocompromised_Conditions(context);
		IEnumerable<Condition> d_ = context.Operators.RetrieveByValueSet<Condition>(c_, default);
		IEnumerable<Condition> e_ = context.Operators.Union<Condition>(b_, d_);
		CqlValueSet f_ = this.Mixed_histology_urothelial_cell_carcinoma_for_Urology_Care(context);
		IEnumerable<Condition> g_ = context.Operators.RetrieveByValueSet<Condition>(f_, default);
		IEnumerable<Condition> h_ = context.Operators.Union<Condition>(e_, g_);
		IEnumerable<Condition> i_(Condition ExclusionDiagnosis)
		{
			Procedure n_ = this.First_Bladder_Cancer_Staging_Procedure(context);
			Procedure[] o_ = [
				n_,
			];
			bool? p_(Procedure FirstBladderCancerStaging)
			{
				CqlInterval<CqlDateTime> t_ = qiCoreCommon_2_0_000.prevalenceInterval(context, ExclusionDiagnosis);
				CqlDateTime u_ = context.Operators.Start(t_);
				DataType v_ = FirstBladderCancerStaging?.Performed;
				object w_ = fhirHelpers_4_3_000.ToValue(context, v_);
				CqlInterval<CqlDateTime> x_ = qiCoreCommon_2_0_000.toInterval(context, w_);
				CqlDateTime y_ = context.Operators.Start(x_);
				bool? z_ = context.Operators.SameOrBefore(u_, y_, default);

				return z_;
			};
			IEnumerable<Procedure> q_ = context.Operators.Where<Procedure>((IEnumerable<Procedure>)o_, p_);
			Condition r_(Procedure FirstBladderCancerStaging) => 
				ExclusionDiagnosis;
			IEnumerable<Condition> s_ = context.Operators.Select<Procedure, Condition>(q_, r_);

			return s_;
		};
		IEnumerable<Condition> j_ = context.Operators.SelectMany<Condition, Condition>(h_, i_);
		bool? k_(Condition ExclusionDiagnosis)
		{
			bool? aa_ = this.isConfirmedActiveDiagnosis(context, ExclusionDiagnosis);

			return aa_;
		};
		IEnumerable<Condition> l_ = context.Operators.Where<Condition>(j_, k_);
		bool? m_ = context.Operators.Exists<Condition>(l_);

		return m_;
	}

    [CqlDeclaration("Has Excluding Chemotherapy or Radiotherapy Procedure Before Staging")]
	public bool? Has_Excluding_Chemotherapy_or_Radiotherapy_Procedure_Before_Staging(CqlContext context)
	{
		CqlValueSet a_ = this.Chemotherapy_Agents_for_Advanced_Cancer(context);
		IEnumerable<MedicationRequest> b_ = context.Operators.RetrieveByValueSet<MedicationRequest>(a_, default);
		IEnumerable<MedicationRequest> d_ = context.Operators.RetrieveByValueSet<MedicationRequest>(a_, default);
		IEnumerable<MedicationRequest> e_ = context.Operators.Union<MedicationRequest>(b_, d_);
		IEnumerable<MedicationRequest> f_(MedicationRequest ExclusionMed)
		{
			Procedure s_ = this.First_Bladder_Cancer_Staging_Procedure(context);
			Procedure[] t_ = [
				s_,
			];
			bool? u_(Procedure FirstBladderCancerStaging)
			{
				CqlInterval<CqlDate> y_ = cumulativeMedicationDuration_4_0_000.MedicationRequestPeriod(context, ExclusionMed);
				CqlDate z_ = context.Operators.Start(y_);
				CqlDateTime aa_ = context.Operators.ConvertDateToDateTime(z_);
				DataType ab_ = FirstBladderCancerStaging?.Performed;
				object ac_ = fhirHelpers_4_3_000.ToValue(context, ab_);
				CqlInterval<CqlDateTime> ad_ = qiCoreCommon_2_0_000.toInterval(context, ac_);
				CqlDateTime ae_ = context.Operators.Start(ad_);
				CqlQuantity af_ = context.Operators.Quantity(6m, "months");
				CqlDateTime ag_ = context.Operators.Subtract(ae_, af_);
				object ai_ = fhirHelpers_4_3_000.ToValue(context, ab_);
				CqlInterval<CqlDateTime> aj_ = qiCoreCommon_2_0_000.toInterval(context, ai_);
				CqlDateTime ak_ = context.Operators.Start(aj_);
				CqlInterval<CqlDateTime> al_ = context.Operators.Interval(ag_, ak_, true, false);
				bool? am_ = context.Operators.In<CqlDateTime>(aa_, al_, default);
				object ao_ = fhirHelpers_4_3_000.ToValue(context, ab_);
				CqlInterval<CqlDateTime> ap_ = qiCoreCommon_2_0_000.toInterval(context, ao_);
				CqlDateTime aq_ = context.Operators.Start(ap_);
				bool? ar_ = context.Operators.Not((bool?)(aq_ is null));
				bool? as_ = context.Operators.And(am_, ar_);

				return as_;
			};
			IEnumerable<Procedure> v_ = context.Operators.Where<Procedure>((IEnumerable<Procedure>)t_, u_);
			MedicationRequest w_(Procedure FirstBladderCancerStaging) => 
				ExclusionMed;
			IEnumerable<MedicationRequest> x_ = context.Operators.Select<Procedure, MedicationRequest>(v_, w_);

			return x_;
		};
		IEnumerable<MedicationRequest> g_ = context.Operators.SelectMany<MedicationRequest, MedicationRequest>(e_, f_);
		bool? h_(MedicationRequest ExclusionMed)
		{
			Code<MedicationRequest.MedicationrequestStatus> at_ = ExclusionMed?.StatusElement;
			MedicationRequest.MedicationrequestStatus? au_ = at_?.Value;
			string av_ = context.Operators.Convert<string>(au_);
			string[] aw_ = [
				"active",
				"completed",
			];
			bool? ax_ = context.Operators.In<string>(av_, aw_ as IEnumerable<string>);
			Code<MedicationRequest.MedicationRequestIntent> ay_ = ExclusionMed?.IntentElement;
			MedicationRequest.MedicationRequestIntent? az_ = ay_?.Value;
			string ba_ = context.Operators.Convert<string>(az_);
			bool? bb_ = context.Operators.Equal(ba_, "order");
			bool? bc_ = context.Operators.And(ax_, bb_);
			FhirBoolean bd_ = ExclusionMed?.DoNotPerformElement;
			bool? be_ = bd_?.Value;
			bool? bf_ = context.Operators.IsTrue(be_);
			bool? bg_ = context.Operators.Not(bf_);
			bool? bh_ = context.Operators.And(bc_, bg_);

			return bh_;
		};
		IEnumerable<MedicationRequest> i_ = context.Operators.Where<MedicationRequest>(g_, h_);
		CqlCode j_ = this.Combined_radiotherapy__procedure_(context);
		IEnumerable<CqlCode> k_ = context.Operators.ToList<CqlCode>(j_);
		IEnumerable<Procedure> l_ = context.Operators.RetrieveByCodes<Procedure>(k_, default);
		IEnumerable<Procedure> m_(Procedure ExclusionProcedure)
		{
			Procedure bi_ = this.First_Bladder_Cancer_Staging_Procedure(context);
			Procedure[] bj_ = [
				bi_,
			];
			bool? bk_(Procedure FirstBladderCancerStaging)
			{
				DataType bo_ = ExclusionProcedure?.Performed;
				object bp_ = fhirHelpers_4_3_000.ToValue(context, bo_);
				CqlInterval<CqlDateTime> bq_ = qiCoreCommon_2_0_000.toInterval(context, bp_);
				CqlDateTime br_ = context.Operators.Start(bq_);
				DataType bs_ = FirstBladderCancerStaging?.Performed;
				object bt_ = fhirHelpers_4_3_000.ToValue(context, bs_);
				CqlInterval<CqlDateTime> bu_ = qiCoreCommon_2_0_000.toInterval(context, bt_);
				CqlDateTime bv_ = context.Operators.Start(bu_);
				CqlQuantity bw_ = context.Operators.Quantity(6m, "months");
				CqlDateTime bx_ = context.Operators.Subtract(bv_, bw_);
				object bz_ = fhirHelpers_4_3_000.ToValue(context, bs_);
				CqlInterval<CqlDateTime> ca_ = qiCoreCommon_2_0_000.toInterval(context, bz_);
				CqlDateTime cb_ = context.Operators.Start(ca_);
				CqlInterval<CqlDateTime> cc_ = context.Operators.Interval(bx_, cb_, true, false);
				bool? cd_ = context.Operators.In<CqlDateTime>(br_, cc_, default);
				object cf_ = fhirHelpers_4_3_000.ToValue(context, bs_);
				CqlInterval<CqlDateTime> cg_ = qiCoreCommon_2_0_000.toInterval(context, cf_);
				CqlDateTime ch_ = context.Operators.Start(cg_);
				bool? ci_ = context.Operators.Not((bool?)(ch_ is null));
				bool? cj_ = context.Operators.And(cd_, ci_);

				return cj_;
			};
			IEnumerable<Procedure> bl_ = context.Operators.Where<Procedure>((IEnumerable<Procedure>)bj_, bk_);
			Procedure bm_(Procedure FirstBladderCancerStaging) => 
				ExclusionProcedure;
			IEnumerable<Procedure> bn_ = context.Operators.Select<Procedure, Procedure>(bl_, bm_);

			return bn_;
		};
		IEnumerable<Procedure> n_ = context.Operators.SelectMany<Procedure, Procedure>(l_, m_);
		bool? o_(Procedure ExclusionProcedure)
		{
			Code<EventStatus> ck_ = ExclusionProcedure?.StatusElement;
			EventStatus? cl_ = ck_?.Value;
			string cm_ = context.Operators.Convert<string>(cl_);
			bool? cn_ = context.Operators.Equal(cm_, "completed");

			return cn_;
		};
		IEnumerable<Procedure> p_ = context.Operators.Where<Procedure>(n_, o_);
		IEnumerable<object> q_ = context.Operators.Union<object>(i_ as IEnumerable<object>, p_ as IEnumerable<object>);
		bool? r_ = context.Operators.Exists<object>(q_);

		return r_;
	}

    [CqlDeclaration("Denominator Exclusion")]
	public bool? Denominator_Exclusion(CqlContext context)
	{
		IEnumerable<Condition> a_ = this.Acute_Tuberculosis_Diagnosis(context);
		bool? b_ = context.Operators.Exists<Condition>(a_);
		IEnumerable<MedicationRequest> c_ = this.Immunosuppressive_Drugs(context);
		bool? d_ = context.Operators.Exists<MedicationRequest>(c_);
		bool? e_ = context.Operators.Or(b_, d_);
		IEnumerable<Procedure> f_ = this.Cystectomy_Done(context);
		bool? g_ = context.Operators.Exists<Procedure>(f_);
		bool? h_ = context.Operators.Or(e_, g_);
		bool? i_ = this.Has_Excluding__HIV__Immunocompromised_Conditions_or_Mixed_Histology_Before_Staging(context);
		bool? j_ = context.Operators.Or(h_, i_);
		bool? k_ = this.Has_Excluding_Chemotherapy_or_Radiotherapy_Procedure_Before_Staging(context);
		bool? l_ = context.Operators.Or(j_, k_);

		return l_;
	}

    [CqlDeclaration("NormalizePeriod")]
	public CqlInterval<CqlDateTime> NormalizePeriod(CqlContext context, CqlDateTime pointInTime, CqlInterval<CqlDateTime> dateTimeInterval)
	{
		CqlInterval<CqlDateTime> a_()
		{
			if ((context.Operators.Not((bool?)(pointInTime is null))) ?? false)
			{
				CqlInterval<CqlDateTime> b_ = context.Operators.Interval(pointInTime, pointInTime, true, true);

				return b_;
			}
			else if ((context.Operators.Not((bool?)(dateTimeInterval is null))) ?? false)
			{
				return dateTimeInterval;
			}
			else
			{
				return null as CqlInterval<CqlDateTime>;
			}
		};

		return a_();
	}

}
