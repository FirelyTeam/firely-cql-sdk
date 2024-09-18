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
[CqlLibrary("DiabetesHemoglobinA1cHbA1cPoorControl9FHIR", "0.1.000")]
public partial class DiabetesHemoglobinA1cHbA1cPoorControl9FHIR_0_1_000(
    FHIRHelpers_4_3_000 fhirHelpers_4_3_000,
    QICoreCommon_2_0_000 qiCoreCommon_2_0_000,
    CQMCommon_2_0_000 cqmCommon_2_0_000,
    SupplementalDataElements_3_4_000 supplementalDataElements_3_4_000,
    Status_1_6_000 status_1_6_000,
    CumulativeMedicationDuration_4_0_000 cumulativeMedicationDuration_4_0_000,
    AdultOutpatientEncounters_4_8_000 adultOutpatientEncounters_4_8_000,
    AdvancedIllnessandFrailty_1_8_000 advancedIllnessandFrailty_1_8_000,
    Hospice_6_9_000 hospice_6_9_000,
    PalliativeCare_1_9_000 palliativeCare_1_9_000)
{

    [CqlDeclaration("Diabetes")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.103.12.1001")]
	public  CqlValueSet Diabetes(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.103.12.1001", default);

    [CqlDeclaration("HbA1c Laboratory Test")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.198.12.1013")]
	public  CqlValueSet HbA1c_Laboratory_Test(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.198.12.1013", default);

    [CqlDeclaration("Measurement Period")]
	public  CqlInterval<CqlDateTime> Measurement_Period(CqlContext context)
	{
		CqlDateTime a_ = context.Operators.DateTime(2025, 1, 1, 0, 0, 0, 0, default);
		CqlDateTime b_ = context.Operators.DateTime(2026, 1, 1, 0, 0, 0, 0, default);
		CqlInterval<CqlDateTime> c_ = context.Operators.Interval(a_, b_, true, false);
		object d_ = context.ResolveParameter("DiabetesHemoglobinA1cHbA1cPoorControl9FHIR-0.1.000", "Measurement Period", c_);

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
		CqlDateTime f_ = context.Operators.Start(e_);
		CqlDate g_ = context.Operators.DateFrom(f_);
		int? h_ = context.Operators.CalculateAgeAt(d_, g_, "year");
		CqlInterval<int?> i_ = context.Operators.Interval(18, 75, true, true);
		bool? j_ = context.Operators.In<int?>(h_, i_, default);
		IEnumerable<Encounter> k_ = adultOutpatientEncounters_4_8_000.Qualifying_Encounters(context);
		bool? l_ = context.Operators.Exists<Encounter>(k_);
		bool? m_ = context.Operators.And(j_, l_);
		CqlValueSet n_ = this.Diabetes(context);
		IEnumerable<Condition> o_ = context.Operators.RetrieveByValueSet<Condition>(n_, default);
		bool? p_(Condition Diabetes)
		{
			CqlInterval<CqlDateTime> t_ = qiCoreCommon_2_0_000.ToPrevalenceInterval(context, Diabetes);
			CqlInterval<CqlDateTime> u_ = this.Measurement_Period(context);
			bool? v_ = context.Operators.Overlaps(t_, u_, default);

			return v_;
		};
		IEnumerable<Condition> q_ = context.Operators.Where<Condition>(o_, p_);
		bool? r_ = context.Operators.Exists<Condition>(q_);
		bool? s_ = context.Operators.And(m_, r_);

		return s_;
	}

    [CqlDeclaration("Denominator")]
	public  bool? Denominator(CqlContext context)
	{
		bool? a_ = this.Initial_Population(context);

		return a_;
	}

    [CqlDeclaration("Denominator Exclusions")]
	public  bool? Denominator_Exclusions(CqlContext context)
	{
		bool? a_ = hospice_6_9_000.Has_Hospice_Services(context);
		bool? b_ = advancedIllnessandFrailty_1_8_000.Is_Age_66_or_Older_with_Advanced_Illness_and_Frailty(context);
		bool? c_ = context.Operators.Or(a_, b_);
		bool? d_ = advancedIllnessandFrailty_1_8_000.Is_Age_66_or_Older_Living_Long_Term_in_a_Nursing_Home(context);
		bool? e_ = context.Operators.Or(c_, d_);
		bool? f_ = palliativeCare_1_9_000.Has_Palliative_Care_in_the_Measurement_Period(context);
		bool? g_ = context.Operators.Or(e_, f_);

		return g_;
	}

    [CqlDeclaration("Most Recent HbA1c")]
	public  Observation Most_Recent_HbA1c(CqlContext context)
	{
		CqlValueSet a_ = this.HbA1c_Laboratory_Test(context);
		IEnumerable<Observation> b_ = context.Operators.RetrieveByValueSet<Observation>(a_, default);
		IEnumerable<Observation> c_ = status_1_6_000.isLaboratoryTestPerformed(context, b_);
		bool? d_(Observation RecentHbA1c)
		{
			object i_()
			{
				bool m_()
				{
					DataType p_ = RecentHbA1c?.Effective;
					object q_ = fhirHelpers_4_3_000.ToValue(context, p_);
					bool r_ = q_ is CqlDateTime;

					return r_;
				};
				bool n_()
				{
					DataType s_ = RecentHbA1c?.Effective;
					object t_ = fhirHelpers_4_3_000.ToValue(context, s_);
					bool u_ = t_ is CqlInterval<CqlDateTime>;

					return u_;
				};
				bool o_()
				{
					DataType v_ = RecentHbA1c?.Effective;
					object w_ = fhirHelpers_4_3_000.ToValue(context, v_);
					bool x_ = w_ is CqlDateTime;

					return x_;
				};
				if (m_())
				{
					DataType y_ = RecentHbA1c?.Effective;
					object z_ = fhirHelpers_4_3_000.ToValue(context, y_);

					return (z_ as CqlDateTime) as object;
				}
				else if (n_())
				{
					DataType aa_ = RecentHbA1c?.Effective;
					object ab_ = fhirHelpers_4_3_000.ToValue(context, aa_);

					return (ab_ as CqlInterval<CqlDateTime>) as object;
				}
				else if (o_())
				{
					DataType ac_ = RecentHbA1c?.Effective;
					object ad_ = fhirHelpers_4_3_000.ToValue(context, ac_);

					return (ad_ as CqlDateTime) as object;
				}
				else
				{
					return null;
				}
			};
			CqlDateTime j_ = qiCoreCommon_2_0_000.Latest(context, i_());
			CqlInterval<CqlDateTime> k_ = this.Measurement_Period(context);
			bool? l_ = context.Operators.In<CqlDateTime>(j_, k_, "day");

			return l_;
		};
		IEnumerable<Observation> e_ = context.Operators.Where<Observation>(c_, d_);
		object f_(Observation @this)
		{
			DataType ae_ = @this?.Effective;
			object af_ = fhirHelpers_4_3_000.ToValue(context, ae_);
			CqlInterval<CqlDateTime> ag_ = qiCoreCommon_2_0_000.ToInterval(context, af_);
			CqlDateTime ah_ = context.Operators.Start(ag_);

			return ah_;
		};
		IEnumerable<Observation> g_ = context.Operators.SortBy<Observation>(e_, f_, System.ComponentModel.ListSortDirection.Ascending);
		Observation h_ = context.Operators.Last<Observation>(g_);

		return h_;
	}

    [CqlDeclaration("Has Most Recent HbA1c Without Result")]
	public  bool? Has_Most_Recent_HbA1c_Without_Result(CqlContext context)
	{
		Observation a_ = this.Most_Recent_HbA1c(context);
		bool? b_ = context.Operators.Not((bool?)(a_ is null));
		DataType d_ = a_?.Value;
		object e_ = fhirHelpers_4_3_000.ToValue(context, d_);
		bool? f_ = context.Operators.And(b_, (bool?)(e_ is null));

		return f_;
	}

    [CqlDeclaration("Has Most Recent Elevated HbA1c")]
	public  bool? Has_Most_Recent_Elevated_HbA1c(CqlContext context)
	{
		Observation a_ = this.Most_Recent_HbA1c(context);
		DataType b_ = a_?.Value;
		object c_ = fhirHelpers_4_3_000.ToValue(context, b_);
		CqlQuantity d_ = context.Operators.Quantity(9m, "%");
		bool? e_ = context.Operators.Greater(c_ as CqlQuantity, d_);

		return e_;
	}

    [CqlDeclaration("Has No Record Of HbA1c")]
	public  bool? Has_No_Record_Of_HbA1c(CqlContext context)
	{
		CqlValueSet a_ = this.HbA1c_Laboratory_Test(context);
		IEnumerable<Observation> b_ = context.Operators.RetrieveByValueSet<Observation>(a_, default);
		IEnumerable<Observation> c_ = status_1_6_000.isLaboratoryTestPerformed(context, b_);
		bool? d_(Observation NoHbA1c)
		{
			object h_()
			{
				bool l_()
				{
					DataType o_ = NoHbA1c?.Effective;
					object p_ = fhirHelpers_4_3_000.ToValue(context, o_);
					bool q_ = p_ is CqlDateTime;

					return q_;
				};
				bool m_()
				{
					DataType r_ = NoHbA1c?.Effective;
					object s_ = fhirHelpers_4_3_000.ToValue(context, r_);
					bool t_ = s_ is CqlInterval<CqlDateTime>;

					return t_;
				};
				bool n_()
				{
					DataType u_ = NoHbA1c?.Effective;
					object v_ = fhirHelpers_4_3_000.ToValue(context, u_);
					bool w_ = v_ is CqlDateTime;

					return w_;
				};
				if (l_())
				{
					DataType x_ = NoHbA1c?.Effective;
					object y_ = fhirHelpers_4_3_000.ToValue(context, x_);

					return (y_ as CqlDateTime) as object;
				}
				else if (m_())
				{
					DataType z_ = NoHbA1c?.Effective;
					object aa_ = fhirHelpers_4_3_000.ToValue(context, z_);

					return (aa_ as CqlInterval<CqlDateTime>) as object;
				}
				else if (n_())
				{
					DataType ab_ = NoHbA1c?.Effective;
					object ac_ = fhirHelpers_4_3_000.ToValue(context, ab_);

					return (ac_ as CqlDateTime) as object;
				}
				else
				{
					return null;
				}
			};
			CqlDateTime i_ = qiCoreCommon_2_0_000.Latest(context, h_());
			CqlInterval<CqlDateTime> j_ = this.Measurement_Period(context);
			bool? k_ = context.Operators.In<CqlDateTime>(i_, j_, "day");

			return k_;
		};
		IEnumerable<Observation> e_ = context.Operators.Where<Observation>(c_, d_);
		bool? f_ = context.Operators.Exists<Observation>(e_);
		bool? g_ = context.Operators.Not(f_);

		return g_;
	}

    [CqlDeclaration("Numerator")]
	public  bool? Numerator(CqlContext context)
	{
		bool? a_ = this.Has_Most_Recent_HbA1c_Without_Result(context);
		bool? b_ = this.Has_Most_Recent_Elevated_HbA1c(context);
		bool? c_ = context.Operators.Or(a_, b_);
		bool? d_ = this.Has_No_Record_Of_HbA1c(context);
		bool? e_ = context.Operators.Or(c_, d_);

		return e_;
	}

}
