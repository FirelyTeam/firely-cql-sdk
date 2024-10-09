using System;
using System.Linq;
using System.Collections.Generic;
using Hl7.Cql.Runtime;
using Hl7.Cql.Primitives;
using Hl7.Cql.Abstractions;
using Hl7.Cql.ValueSets;
using Hl7.Cql.Iso8601;
using System.Reflection;
using Hl7.Cql.Operators;
using Hl7.Fhir.Model;
using Range = Hl7.Fhir.Model.Range;
using Task = Hl7.Fhir.Model.Task;
[System.CodeDom.Compiler.GeneratedCode(".NET Code Generation", "2.0.4.0")]
[CqlLibrary("NCQAEncounter", "1.0.0")]
public class NCQAEncounter_1_0_0
{


    internal CqlContext context;

    #region Cached values


    #endregion
    public NCQAEncounter_1_0_0(CqlContext context)
    {
        this.context = context ?? throw new ArgumentNullException("context");

        FHIRHelpers_4_0_001 = new FHIRHelpers_4_0_001(context);
        NCQAFHIRBase_1_0_0 = new NCQAFHIRBase_1_0_0(context);
        NCQAStatus_1_0_0 = new NCQAStatus_1_0_0(context);
        NCQATerminology_1_0_0 = new NCQATerminology_1_0_0(context);

    }
    #region Dependencies

    public FHIRHelpers_4_0_001 FHIRHelpers_4_0_001 { get; }
    public NCQAFHIRBase_1_0_0 NCQAFHIRBase_1_0_0 { get; }
    public NCQAStatus_1_0_0 NCQAStatus_1_0_0 { get; }
    public NCQATerminology_1_0_0 NCQATerminology_1_0_0 { get; }

    #endregion

    [CqlDeclaration("Encounter Has Diagnosis")]
	public bool? Encounter_Has_Diagnosis(Encounter Encounter, IEnumerable<Condition> Conditions)
	{
		List<Encounter.DiagnosisComponent> a_ = Encounter?.Diagnosis;
		FhirString b_(Encounter.DiagnosisComponent D)
		{
			ResourceReference g_ = D?.Condition;
			FhirString h_ = g_?.ReferenceElement;

			return h_;
		};
		IEnumerable<FhirString> c_ = context.Operators.Select<Encounter.DiagnosisComponent, FhirString>((IEnumerable<Encounter.DiagnosisComponent>)a_, b_);
		bool? d_(FhirString CRef)
		{
			bool? i_(Condition C)
			{
				Id l_ = C?.IdElement;
				string m_ = FHIRHelpers_4_0_001.ToString(l_);
				string n_ = FHIRHelpers_4_0_001.ToString(CRef);
				string o_ = NCQAFHIRBase_1_0_0.GetId(n_);
				bool? p_ = context.Operators.Equal(m_, o_);

				return p_;
			};
			IEnumerable<Condition> j_ = context.Operators.Where<Condition>(Conditions, i_);
			bool? k_ = context.Operators.Exists<Condition>(j_);

			return k_;
		};
		IEnumerable<bool?> e_ = context.Operators.Select<FhirString, bool?>(c_, d_);
		bool? f_ = context.Operators.AnyTrue(e_);

		return f_;
	}

    [CqlDeclaration("Encounter Has Principal Diagnosis")]
	public bool? Encounter_Has_Principal_Diagnosis(Encounter Encounter, IEnumerable<Condition> Conditions)
	{
		List<Encounter.DiagnosisComponent> a_ = Encounter?.Diagnosis;
		bool? b_(Encounter.DiagnosisComponent D)
		{
			PositiveInt i_ = D?.RankElement;
			Integer j_ = context.Operators.Convert<Integer>(i_);
			int? k_ = FHIRHelpers_4_0_001.ToInteger(j_);
			bool? l_ = context.Operators.Equal(k_, 1);

			return l_;
		};
		IEnumerable<Encounter.DiagnosisComponent> c_ = context.Operators.Where<Encounter.DiagnosisComponent>((IEnumerable<Encounter.DiagnosisComponent>)a_, b_);
		Encounter.DiagnosisComponent d_ = context.Operators.SingletonFrom<Encounter.DiagnosisComponent>(c_);
		Encounter.DiagnosisComponent[] e_ = [
			d_,
		];
		bool? f_(Encounter.DiagnosisComponent PrincipalDiagnosis)
		{
			bool? m_(Condition C)
			{
				Id p_ = C?.IdElement;
				string q_ = FHIRHelpers_4_0_001.ToString(p_);
				ResourceReference r_ = PrincipalDiagnosis?.Condition;
				FhirString s_ = r_?.ReferenceElement;
				string t_ = FHIRHelpers_4_0_001.ToString(s_);
				string u_ = NCQAFHIRBase_1_0_0.GetId(t_);
				bool? v_ = context.Operators.Equal(q_, u_);

				return v_;
			};
			IEnumerable<Condition> n_ = context.Operators.Where<Condition>(Conditions, m_);
			bool? o_ = context.Operators.Exists<Condition>(n_);

			return o_;
		};
		IEnumerable<bool?> g_ = context.Operators.Select<Encounter.DiagnosisComponent, bool?>((IEnumerable<Encounter.DiagnosisComponent>)e_, f_);
		bool? h_ = context.Operators.SingletonFrom<bool?>(g_);

		return h_;
	}

    [CqlDeclaration("Encounter Completed during Period")]
	public bool? Encounter_Completed_during_Period(IEnumerable<Encounter> Enc, CqlInterval<CqlDateTime> timeperiod)
	{
		IEnumerable<Encounter> a_ = NCQAStatus_1_0_0.Finished_Encounter(Enc);
		bool? b_(Encounter EncounterPeriod)
		{
			Period e_ = EncounterPeriod?.Period;
			CqlInterval<CqlDateTime> f_ = NCQAFHIRBase_1_0_0.Normalize_Interval(e_ as object);
			CqlDateTime g_ = context.Operators.End(f_);
			bool? h_ = context.Operators.In<CqlDateTime>(g_, timeperiod, default);

			return h_;
		};
		IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);
		bool? d_ = context.Operators.Exists<Encounter>(c_);

		return d_;
	}

    [CqlDeclaration("Finished Encounter with Telehealth POS")]
	public IEnumerable<Encounter> Finished_Encounter_with_Telehealth_POS(IEnumerable<Encounter> Encounter)
	{
		IEnumerable<Encounter> a_ = NCQAStatus_1_0_0.Finished_Encounter(Encounter);
		bool? b_(Encounter E)
		{
			Coding d_ = E?.Class;
			bool? e_ = context.Operators.Not((bool?)(d_ is null));
			CqlCode g_ = FHIRHelpers_4_0_001.ToCode(d_);
			CqlCode h_ = NCQATerminology_1_0_0.@virtual();
			bool? i_ = context.Operators.Equivalent(g_, h_);
			bool? j_ = context.Operators.And(e_, i_);

			return j_;
		};
		IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);

		return c_;
	}

    [CqlDeclaration("Finished Encounter with Outpatient POS")]
	public IEnumerable<Encounter> Finished_Encounter_with_Outpatient_POS(IEnumerable<Encounter> Encounter)
	{
		IEnumerable<Encounter> a_ = NCQAStatus_1_0_0.Finished_Encounter(Encounter);
		bool? b_(Encounter E)
		{
			Coding d_ = E?.Class;
			bool? e_ = context.Operators.Not((bool?)(d_ is null));
			CqlCode g_ = FHIRHelpers_4_0_001.ToCode(d_);
			CqlCode h_ = NCQATerminology_1_0_0.ambulatory();
			bool? i_ = context.Operators.Equivalent(g_, h_);
			CqlCode k_ = FHIRHelpers_4_0_001.ToCode(d_);
			CqlCode l_ = NCQATerminology_1_0_0.home_health();
			bool? m_ = context.Operators.Equivalent(k_, l_);
			bool? n_ = context.Operators.Or(i_, m_);
			bool? o_ = context.Operators.And(e_, n_);

			return o_;
		};
		IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);

		return c_;
	}

    [CqlDeclaration("Finished Encounter with Ambulatory POS")]
	public IEnumerable<Encounter> Finished_Encounter_with_Ambulatory_POS(IEnumerable<Encounter> Encounter)
	{
		IEnumerable<Encounter> a_ = NCQAStatus_1_0_0.Finished_Encounter(Encounter);
		bool? b_(Encounter E)
		{
			Coding d_ = E?.Class;
			bool? e_ = context.Operators.Not((bool?)(d_ is null));
			CqlCode g_ = FHIRHelpers_4_0_001.ToCode(d_);
			CqlCode h_ = NCQATerminology_1_0_0.ambulatory();
			bool? i_ = context.Operators.Equivalent(g_, h_);
			bool? j_ = context.Operators.And(e_, i_);

			return j_;
		};
		IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);

		return c_;
	}

}
