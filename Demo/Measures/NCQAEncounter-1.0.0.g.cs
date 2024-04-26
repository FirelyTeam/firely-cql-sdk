using System;
using Tuples;
using System.Linq;
using System.Collections.Generic;
using Hl7.Cql.Runtime;
using Hl7.Cql.Primitives;
using Hl7.Cql.Abstractions;
using Hl7.Cql.ValueSets;
using Hl7.Cql.Iso8601;
using Hl7.Fhir.Model;
using Range = Hl7.Fhir.Model.Range;
using Task = Hl7.Fhir.Model.Task;
[System.CodeDom.Compiler.GeneratedCode(".NET Code Generation", "2.0.0.0")]
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
		FhirString a_(Encounter.DiagnosisComponent D) => 
			D?.Condition?.ReferenceElement;
		IEnumerable<FhirString> b_ = context.Operators.Select<Encounter.DiagnosisComponent, FhirString>((Encounter?.Diagnosis as IEnumerable<Encounter.DiagnosisComponent>), a_);
		bool? c_(FhirString CRef)
		{
			bool? f_(Condition C)
			{
				string i_ = context.Operators.Convert<string>(C?.IdElement);
				string j_ = context.Operators.Convert<string>(CRef);
				string k_ = NCQAFHIRBase_1_0_0.GetId(j_);
				bool? l_ = context.Operators.Equal(i_, k_);

				return l_;
			};
			IEnumerable<Condition> g_ = context.Operators.Where<Condition>(Conditions, f_);
			bool? h_ = context.Operators.Exists<Condition>(g_);

			return h_;
		};
		IEnumerable<bool?> d_ = context.Operators.Select<FhirString, bool?>(b_, c_);
		bool? e_ = context.Operators.AnyTrue(d_);

		return e_;
	}

    [CqlDeclaration("Encounter Has Principal Diagnosis")]
	public bool? Encounter_Has_Principal_Diagnosis(Encounter Encounter, IEnumerable<Condition> Conditions)
	{
		bool? a_(Encounter.DiagnosisComponent D)
		{
			Integer h_ = context.Operators.Convert<Integer>(D?.RankElement);
			int? i_ = FHIRHelpers_4_0_001.ToInteger(h_);
			bool? j_ = context.Operators.Equal(i_, 1);

			return j_;
		};
		IEnumerable<Encounter.DiagnosisComponent> b_ = context.Operators.Where<Encounter.DiagnosisComponent>((Encounter?.Diagnosis as IEnumerable<Encounter.DiagnosisComponent>), a_);
		Encounter.DiagnosisComponent c_ = context.Operators.SingletonFrom<Encounter.DiagnosisComponent>(b_);
		Encounter.DiagnosisComponent[] d_ = new Encounter.DiagnosisComponent[]
		{
			c_,
		};
		bool? e_(Encounter.DiagnosisComponent PrincipalDiagnosis)
		{
			bool? k_(Condition C)
			{
				string n_ = context.Operators.Convert<string>(C?.IdElement);
				string o_ = context.Operators.Convert<string>(PrincipalDiagnosis?.Condition?.ReferenceElement);
				string p_ = NCQAFHIRBase_1_0_0.GetId(o_);
				bool? q_ = context.Operators.Equal(n_, p_);

				return q_;
			};
			IEnumerable<Condition> l_ = context.Operators.Where<Condition>(Conditions, k_);
			bool? m_ = context.Operators.Exists<Condition>(l_);

			return m_;
		};
		IEnumerable<bool?> f_ = context.Operators.Select<Encounter.DiagnosisComponent, bool?>(d_, e_);
		bool? g_ = context.Operators.SingletonFrom<bool?>(f_);

		return g_;
	}

    [CqlDeclaration("Encounter Completed during Period")]
	public bool? Encounter_Completed_during_Period(IEnumerable<Encounter> Enc, CqlInterval<CqlDateTime> timeperiod)
	{
		IEnumerable<Encounter> a_ = NCQAStatus_1_0_0.Finished_Encounter(Enc);
		bool? b_(Encounter EncounterPeriod)
		{
			CqlInterval<CqlDateTime> e_ = NCQAFHIRBase_1_0_0.Normalize_Interval((EncounterPeriod?.Period as object));
			CqlDateTime f_ = context.Operators.End(e_);
			bool? g_ = context.Operators.In<CqlDateTime>(f_, timeperiod, null);

			return g_;
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
			bool? d_ = context.Operators.Not((bool?)(E?.Class is null));
			CqlCode e_ = FHIRHelpers_4_0_001.ToCode(E?.Class);
			CqlCode f_ = NCQATerminology_1_0_0.@virtual();
			bool? g_ = context.Operators.Equivalent(e_, f_);
			bool? h_ = context.Operators.And(d_, g_);

			return h_;
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
			bool? d_ = context.Operators.Not((bool?)(E?.Class is null));
			CqlCode e_ = FHIRHelpers_4_0_001.ToCode(E?.Class);
			CqlCode f_ = NCQATerminology_1_0_0.ambulatory();
			bool? g_ = context.Operators.Equivalent(e_, f_);
			CqlCode i_ = NCQATerminology_1_0_0.home_health();
			bool? j_ = context.Operators.Equivalent(e_, i_);
			bool? k_ = context.Operators.Or(g_, j_);
			bool? l_ = context.Operators.And(d_, k_);

			return l_;
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
			bool? d_ = context.Operators.Not((bool?)(E?.Class is null));
			CqlCode e_ = FHIRHelpers_4_0_001.ToCode(E?.Class);
			CqlCode f_ = NCQATerminology_1_0_0.ambulatory();
			bool? g_ = context.Operators.Equivalent(e_, f_);
			bool? h_ = context.Operators.And(d_, g_);

			return h_;
		};
		IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);

		return c_;
	}

}
