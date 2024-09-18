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
[CqlLibrary("ColonCancerScreeningFHIR", "0.1.000")]
public class ColonCancerScreeningFHIR_0_1_000(
    FHIRHelpers_4_3_000 fhirHelpers_4_3_000,
    SupplementalDataElements_3_4_000 supplementalDataElements_3_4_000,
    CQMCommon_2_0_000 cqmCommon_2_0_000,
    Hospice_6_9_000 hospice_6_9_000,
    PalliativeCare_1_9_000 palliativeCare_1_9_000,
    AdultOutpatientEncounters_4_8_000 adultOutpatientEncounters_4_8_000,
    AdvancedIllnessandFrailty_1_8_000 advancedIllnessandFrailty_1_8_000,
    Status_1_6_000 status_1_6_000,
    QICoreCommon_2_0_000 qiCoreCommon_2_0_000)
{

    [CqlDeclaration("Colonoscopy")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.108.12.1020")]
	public  CqlValueSet Colonoscopy(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.108.12.1020", default);

    [CqlDeclaration("CT Colonography")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.108.12.1038")]
	public  CqlValueSet CT_Colonography(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.108.12.1038", default);

    [CqlDeclaration("Fecal Occult Blood Test (FOBT)")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.198.12.1011")]
	public  CqlValueSet Fecal_Occult_Blood_Test__FOBT_(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.198.12.1011", default);

    [CqlDeclaration("sDNA FIT Test")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.108.12.1039")]
	public  CqlValueSet sDNA_FIT_Test(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.108.12.1039", default);

    [CqlDeclaration("Flexible Sigmoidoscopy")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.198.12.1010")]
	public  CqlValueSet Flexible_Sigmoidoscopy(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.198.12.1010", default);

    [CqlDeclaration("Malignant Neoplasm of Colon")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.108.12.1001")]
	public  CqlValueSet Malignant_Neoplasm_of_Colon(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.108.12.1001", default);

    [CqlDeclaration("Total Colectomy")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.198.12.1019")]
	public  CqlValueSet Total_Colectomy(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.198.12.1019", default);

    [CqlDeclaration("Measurement Period")]
	public  CqlInterval<CqlDateTime> Measurement_Period(CqlContext context)
	{
		CqlDateTime a_ = context.Operators.DateTime(2025, 1, 1, 0, 0, 0, 0, default);
		CqlDateTime b_ = context.Operators.DateTime(2026, 1, 1, 0, 0, 0, 0, default);
		CqlInterval<CqlDateTime> c_ = context.Operators.Interval(a_, b_, true, false);
		object d_ = context.ResolveParameter("ColonCancerScreeningFHIR-0.1.000", "Measurement Period", c_);

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
		CqlInterval<int?> i_ = context.Operators.Interval(46, 75, true, true);
		bool? j_ = context.Operators.In<int?>(h_, i_, default);
		IEnumerable<Encounter> k_ = adultOutpatientEncounters_4_8_000.Qualifying_Encounters(context);
		bool? l_ = context.Operators.Exists<Encounter>(k_);
		bool? m_ = context.Operators.And(j_, l_);

		return m_;
	}

    [CqlDeclaration("Denominator")]
	public  bool? Denominator(CqlContext context)
	{
		bool? a_ = this.Initial_Population(context);

		return a_;
	}

    [CqlDeclaration("Malignant Neoplasm")]
	public  IEnumerable<Condition> Malignant_Neoplasm(CqlContext context)
	{
		CqlValueSet a_ = this.Malignant_Neoplasm_of_Colon(context);
		IEnumerable<Condition> b_ = context.Operators.RetrieveByValueSet<Condition>(a_, default);
		IEnumerable<Condition> c_ = status_1_6_000.Active_Condition(context, b_);
		bool? d_(Condition ColorectalCancer)
		{
			CqlInterval<CqlDateTime> f_ = qiCoreCommon_2_0_000.ToPrevalenceInterval(context, ColorectalCancer);
			CqlDateTime g_ = context.Operators.Start(f_);
			CqlInterval<CqlDateTime> h_ = this.Measurement_Period(context);
			CqlDateTime i_ = context.Operators.End(h_);
			bool? j_ = context.Operators.SameOrBefore(g_, i_, "day");

			return j_;
		};
		IEnumerable<Condition> e_ = context.Operators.Where<Condition>(c_, d_);

		return e_;
	}

    [CqlDeclaration("Total Colectomy Performed")]
	public  IEnumerable<Procedure> Total_Colectomy_Performed(CqlContext context)
	{
		CqlValueSet a_ = this.Total_Colectomy(context);
		IEnumerable<Procedure> b_ = context.Operators.RetrieveByValueSet<Procedure>(a_, default);
		IEnumerable<Procedure> c_ = status_1_6_000.Completed_Procedure(context, b_);
		bool? d_(Procedure Colectomy)
		{
			DataType f_ = Colectomy?.Performed;
			object g_ = fhirHelpers_4_3_000.ToValue(context, f_);
			CqlInterval<CqlDateTime> h_ = qiCoreCommon_2_0_000.ToInterval(context, g_);
			CqlDateTime i_ = context.Operators.End(h_);
			CqlInterval<CqlDateTime> j_ = this.Measurement_Period(context);
			CqlDateTime k_ = context.Operators.End(j_);
			bool? l_ = context.Operators.SameOrBefore(i_, k_, "day");

			return l_;
		};
		IEnumerable<Procedure> e_ = context.Operators.Where<Procedure>(c_, d_);

		return e_;
	}

    [CqlDeclaration("Denominator Exclusion")]
	public  bool? Denominator_Exclusion(CqlContext context)
	{
		bool? a_ = hospice_6_9_000.Has_Hospice_Services(context);
		IEnumerable<Condition> b_ = this.Malignant_Neoplasm(context);
		bool? c_ = context.Operators.Exists<Condition>(b_);
		bool? d_ = context.Operators.Or(a_, c_);
		IEnumerable<Procedure> e_ = this.Total_Colectomy_Performed(context);
		bool? f_ = context.Operators.Exists<Procedure>(e_);
		bool? g_ = context.Operators.Or(d_, f_);
		bool? h_ = advancedIllnessandFrailty_1_8_000.Is_Age_66_or_Older_with_Advanced_Illness_and_Frailty(context);
		bool? i_ = context.Operators.Or(g_, h_);
		bool? j_ = advancedIllnessandFrailty_1_8_000.Is_Age_66_or_Older_Living_Long_Term_in_a_Nursing_Home(context);
		bool? k_ = context.Operators.Or(i_, j_);
		bool? l_ = palliativeCare_1_9_000.Has_Palliative_Care_in_the_Measurement_Period(context);
		bool? m_ = context.Operators.Or(k_, l_);

		return m_;
	}

    [CqlDeclaration("Fecal Occult Blood Test Performed")]
	public  IEnumerable<Observation> Fecal_Occult_Blood_Test_Performed(CqlContext context)
	{
		CqlValueSet a_ = this.Fecal_Occult_Blood_Test__FOBT_(context);
		IEnumerable<Observation> b_ = context.Operators.RetrieveByValueSet<Observation>(a_, default);
		IEnumerable<Observation> c_ = status_1_6_000.Final_Lab_Observation(context, b_);
		bool? d_(Observation FecalOccultResult)
		{
			DataType f_ = FecalOccultResult?.Value;
			object g_ = fhirHelpers_4_3_000.ToValue(context, f_);
			bool? h_ = context.Operators.Not((bool?)(g_ is null));
			object i_()
			{
				bool n_()
				{
					DataType q_ = FecalOccultResult?.Effective;
					object r_ = fhirHelpers_4_3_000.ToValue(context, q_);
					bool s_ = r_ is CqlDateTime;

					return s_;
				};
				bool o_()
				{
					DataType t_ = FecalOccultResult?.Effective;
					object u_ = fhirHelpers_4_3_000.ToValue(context, t_);
					bool v_ = u_ is CqlInterval<CqlDateTime>;

					return v_;
				};
				bool p_()
				{
					DataType w_ = FecalOccultResult?.Effective;
					object x_ = fhirHelpers_4_3_000.ToValue(context, w_);
					bool y_ = x_ is CqlDateTime;

					return y_;
				};
				if (n_())
				{
					DataType z_ = FecalOccultResult?.Effective;
					object aa_ = fhirHelpers_4_3_000.ToValue(context, z_);

					return (aa_ as CqlDateTime) as object;
				}
				else if (o_())
				{
					DataType ab_ = FecalOccultResult?.Effective;
					object ac_ = fhirHelpers_4_3_000.ToValue(context, ab_);

					return (ac_ as CqlInterval<CqlDateTime>) as object;
				}
				else if (p_())
				{
					DataType ad_ = FecalOccultResult?.Effective;
					object ae_ = fhirHelpers_4_3_000.ToValue(context, ad_);

					return (ae_ as CqlDateTime) as object;
				}
				else
				{
					return null;
				}
			};
			CqlDateTime j_ = qiCoreCommon_2_0_000.Latest(context, i_());
			CqlInterval<CqlDateTime> k_ = this.Measurement_Period(context);
			bool? l_ = context.Operators.In<CqlDateTime>(j_, k_, "day");
			bool? m_ = context.Operators.And(h_, l_);

			return m_;
		};
		IEnumerable<Observation> e_ = context.Operators.Where<Observation>(c_, d_);

		return e_;
	}

    [CqlDeclaration("Stool DNA with FIT Test Performed")]
	public  IEnumerable<Observation> Stool_DNA_with_FIT_Test_Performed(CqlContext context)
	{
		CqlValueSet a_ = this.sDNA_FIT_Test(context);
		IEnumerable<Observation> b_ = context.Operators.RetrieveByValueSet<Observation>(a_, default);
		IEnumerable<Observation> c_ = status_1_6_000.Final_Lab_Observation(context, b_);
		bool? d_(Observation sDNATest)
		{
			DataType f_ = sDNATest?.Value;
			object g_ = fhirHelpers_4_3_000.ToValue(context, f_);
			bool? h_ = context.Operators.Not((bool?)(g_ is null));
			object i_()
			{
				bool t_()
				{
					DataType w_ = sDNATest?.Effective;
					object x_ = fhirHelpers_4_3_000.ToValue(context, w_);
					bool y_ = x_ is CqlDateTime;

					return y_;
				};
				bool u_()
				{
					DataType z_ = sDNATest?.Effective;
					object aa_ = fhirHelpers_4_3_000.ToValue(context, z_);
					bool ab_ = aa_ is CqlInterval<CqlDateTime>;

					return ab_;
				};
				bool v_()
				{
					DataType ac_ = sDNATest?.Effective;
					object ad_ = fhirHelpers_4_3_000.ToValue(context, ac_);
					bool ae_ = ad_ is CqlDateTime;

					return ae_;
				};
				if (t_())
				{
					DataType af_ = sDNATest?.Effective;
					object ag_ = fhirHelpers_4_3_000.ToValue(context, af_);

					return (ag_ as CqlDateTime) as object;
				}
				else if (u_())
				{
					DataType ah_ = sDNATest?.Effective;
					object ai_ = fhirHelpers_4_3_000.ToValue(context, ah_);

					return (ai_ as CqlInterval<CqlDateTime>) as object;
				}
				else if (v_())
				{
					DataType aj_ = sDNATest?.Effective;
					object ak_ = fhirHelpers_4_3_000.ToValue(context, aj_);

					return (ak_ as CqlDateTime) as object;
				}
				else
				{
					return null;
				}
			};
			CqlDateTime j_ = qiCoreCommon_2_0_000.Latest(context, i_());
			CqlInterval<CqlDateTime> k_ = this.Measurement_Period(context);
			CqlDateTime l_ = context.Operators.Start(k_);
			CqlQuantity m_ = context.Operators.Quantity(2m, "years");
			CqlDateTime n_ = context.Operators.Subtract(l_, m_);
			CqlDateTime p_ = context.Operators.End(k_);
			CqlInterval<CqlDateTime> q_ = context.Operators.Interval(n_, p_, true, true);
			bool? r_ = context.Operators.In<CqlDateTime>(j_, q_, "day");
			bool? s_ = context.Operators.And(h_, r_);

			return s_;
		};
		IEnumerable<Observation> e_ = context.Operators.Where<Observation>(c_, d_);

		return e_;
	}

    [CqlDeclaration("Flexible Sigmoidoscopy Performed")]
	public  IEnumerable<Procedure> Flexible_Sigmoidoscopy_Performed(CqlContext context)
	{
		CqlValueSet a_ = this.Flexible_Sigmoidoscopy(context);
		IEnumerable<Procedure> b_ = context.Operators.RetrieveByValueSet<Procedure>(a_, default);
		IEnumerable<Procedure> c_ = status_1_6_000.Completed_Procedure(context, b_);
		bool? d_(Procedure FlexibleSigmoidoscopy)
		{
			DataType f_ = FlexibleSigmoidoscopy?.Performed;
			object g_ = fhirHelpers_4_3_000.ToValue(context, f_);
			CqlInterval<CqlDateTime> h_ = qiCoreCommon_2_0_000.ToInterval(context, g_);
			CqlDateTime i_ = context.Operators.End(h_);
			CqlInterval<CqlDateTime> j_ = this.Measurement_Period(context);
			CqlDateTime k_ = context.Operators.Start(j_);
			CqlQuantity l_ = context.Operators.Quantity(4m, "years");
			CqlDateTime m_ = context.Operators.Subtract(k_, l_);
			CqlDateTime o_ = context.Operators.End(j_);
			CqlInterval<CqlDateTime> p_ = context.Operators.Interval(m_, o_, true, true);
			bool? q_ = context.Operators.In<CqlDateTime>(i_, p_, "day");

			return q_;
		};
		IEnumerable<Procedure> e_ = context.Operators.Where<Procedure>(c_, d_);

		return e_;
	}

    [CqlDeclaration("CT Colonography Performed")]
	public  IEnumerable<Observation> CT_Colonography_Performed(CqlContext context)
	{
		CqlValueSet a_ = this.CT_Colonography(context);
		IEnumerable<Observation> b_ = context.Operators.RetrieveByValueSet<Observation>(a_, default);
		IEnumerable<Observation> c_ = status_1_6_000.Final_Observation(context, b_);
		bool? d_(Observation Colonography)
		{
			DataType f_ = Colonography?.Effective;
			object g_ = fhirHelpers_4_3_000.ToValue(context, f_);
			CqlInterval<CqlDateTime> h_ = qiCoreCommon_2_0_000.ToInterval(context, g_);
			CqlDateTime i_ = context.Operators.End(h_);
			CqlInterval<CqlDateTime> j_ = this.Measurement_Period(context);
			CqlDateTime k_ = context.Operators.Start(j_);
			CqlQuantity l_ = context.Operators.Quantity(4m, "years");
			CqlDateTime m_ = context.Operators.Subtract(k_, l_);
			CqlDateTime o_ = context.Operators.End(j_);
			CqlInterval<CqlDateTime> p_ = context.Operators.Interval(m_, o_, true, true);
			bool? q_ = context.Operators.In<CqlDateTime>(i_, p_, "day");

			return q_;
		};
		IEnumerable<Observation> e_ = context.Operators.Where<Observation>(c_, d_);

		return e_;
	}

    [CqlDeclaration("Colonoscopy Performed")]
	public  IEnumerable<Procedure> Colonoscopy_Performed(CqlContext context)
	{
		CqlValueSet a_ = this.Colonoscopy(context);
		IEnumerable<Procedure> b_ = context.Operators.RetrieveByValueSet<Procedure>(a_, default);
		IEnumerable<Procedure> c_ = status_1_6_000.Completed_Procedure(context, b_);
		bool? d_(Procedure Colonoscopy)
		{
			DataType f_ = Colonoscopy?.Performed;
			object g_ = fhirHelpers_4_3_000.ToValue(context, f_);
			CqlInterval<CqlDateTime> h_ = qiCoreCommon_2_0_000.ToInterval(context, g_);
			CqlDateTime i_ = context.Operators.End(h_);
			CqlInterval<CqlDateTime> j_ = this.Measurement_Period(context);
			CqlDateTime k_ = context.Operators.Start(j_);
			CqlQuantity l_ = context.Operators.Quantity(9m, "years");
			CqlDateTime m_ = context.Operators.Subtract(k_, l_);
			CqlDateTime o_ = context.Operators.End(j_);
			CqlInterval<CqlDateTime> p_ = context.Operators.Interval(m_, o_, true, true);
			bool? q_ = context.Operators.In<CqlDateTime>(i_, p_, "day");

			return q_;
		};
		IEnumerable<Procedure> e_ = context.Operators.Where<Procedure>(c_, d_);

		return e_;
	}

    [CqlDeclaration("Numerator")]
	public  bool? Numerator(CqlContext context)
	{
		IEnumerable<Observation> a_ = this.Fecal_Occult_Blood_Test_Performed(context);
		bool? b_ = context.Operators.Exists<Observation>(a_);
		IEnumerable<Observation> c_ = this.Stool_DNA_with_FIT_Test_Performed(context);
		bool? d_ = context.Operators.Exists<Observation>(c_);
		bool? e_ = context.Operators.Or(b_, d_);
		IEnumerable<Procedure> f_ = this.Flexible_Sigmoidoscopy_Performed(context);
		bool? g_ = context.Operators.Exists<Procedure>(f_);
		bool? h_ = context.Operators.Or(e_, g_);
		IEnumerable<Observation> i_ = this.CT_Colonography_Performed(context);
		bool? j_ = context.Operators.Exists<Observation>(i_);
		bool? k_ = context.Operators.Or(h_, j_);
		IEnumerable<Procedure> l_ = this.Colonoscopy_Performed(context);
		bool? m_ = context.Operators.Exists<Procedure>(l_);
		bool? n_ = context.Operators.Or(k_, m_);

		return n_;
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
		CqlInterval<int?> i_ = context.Operators.Interval(46, 49, true, true);
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
		CqlInterval<int?> i_ = context.Operators.Interval(50, 75, true, true);
		bool? j_ = context.Operators.In<int?>(h_, i_, default);

		return j_;
	}

}
