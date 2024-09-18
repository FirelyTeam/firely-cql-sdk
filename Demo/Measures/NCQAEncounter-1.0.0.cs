using System;
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
[System.CodeDom.Compiler.GeneratedCode(".NET Code Generation", "1.0.0.0")]
[CqlLibrary("NCQAEncounter", "1.0.0")]
public class NCQAEncounter_1_0_0
{

    public static NCQAEncounter_1_0_0 Instance { get; }  = new();

    [CqlDeclaration("Encounter Has Diagnosis")]
	public bool? Encounter_Has_Diagnosis(CqlContext context, Encounter Encounter, IEnumerable<Condition> Conditions)
	{
		FhirString a_(Encounter.DiagnosisComponent D) => 
			D?.Condition?.ReferenceElement;
		var b_ = context.Operators.SelectOrNull<Encounter.DiagnosisComponent, FhirString>((Encounter?.Diagnosis as IEnumerable<Encounter.DiagnosisComponent>), a_);
		bool? c_(FhirString CRef)
		{
			bool? f_(Condition C)
			{
				var i_ = context.Operators.Convert<string>(C?.IdElement);
				var j_ = context.Operators.Convert<string>(CRef);
				var k_ = NCQAFHIRBase_1_0_0.Instance.GetId(context, j_);
				var l_ = context.Operators.Equal(i_, k_);

				return l_;
			};
			var g_ = context.Operators.WhereOrNull<Condition>(Conditions, f_);
			var h_ = context.Operators.ExistsInList<Condition>(g_);

			return h_;
		};
		var d_ = context.Operators.SelectOrNull<FhirString, bool?>(b_, c_);
		var e_ = context.Operators.AnyTrue(d_);

		return e_;
	}

    [CqlDeclaration("Encounter Has Principal Diagnosis")]
	public bool? Encounter_Has_Principal_Diagnosis(CqlContext context, Encounter Encounter, IEnumerable<Condition> Conditions)
	{
		bool? a_(Encounter.DiagnosisComponent D)
		{
			var h_ = context.Operators.Convert<Integer>(D?.RankElement);
			var i_ = FHIRHelpers_4_0_001.Instance.ToInteger(context, h_);
			var j_ = context.Operators.Equal(i_, (int?)1);

			return j_;
		};
		var b_ = context.Operators.WhereOrNull<Encounter.DiagnosisComponent>((Encounter?.Diagnosis as IEnumerable<Encounter.DiagnosisComponent>), a_);
		var c_ = context.Operators.SingleOrNull<Encounter.DiagnosisComponent>(b_);
		var d_ = new Encounter.DiagnosisComponent[]
		{
			c_,
		};
		bool? e_(Encounter.DiagnosisComponent PrincipalDiagnosis)
		{
			bool? k_(Condition C)
			{
				var n_ = context.Operators.Convert<string>(C?.IdElement);
				var o_ = context.Operators.Convert<string>(PrincipalDiagnosis?.Condition?.ReferenceElement);
				var p_ = NCQAFHIRBase_1_0_0.Instance.GetId(context, o_);
				var q_ = context.Operators.Equal(n_, p_);

				return q_;
			};
			var l_ = context.Operators.WhereOrNull<Condition>(Conditions, k_);
			var m_ = context.Operators.ExistsInList<Condition>(l_);

			return m_;
		};
		var f_ = context.Operators.SelectOrNull<Encounter.DiagnosisComponent, bool?>(d_, e_);
		var g_ = context.Operators.SingleOrNull<bool?>(f_);

		return g_;
	}

    [CqlDeclaration("Encounter Completed during Period")]
	public bool? Encounter_Completed_during_Period(CqlContext context, IEnumerable<Encounter> Enc, CqlInterval<CqlDateTime> timeperiod)
	{
		var a_ = NCQAStatus_1_0_0.Instance.Finished_Encounter(context, Enc);
		bool? b_(Encounter EncounterPeriod)
		{
			var e_ = NCQAFHIRBase_1_0_0.Instance.Normalize_Interval(context, (EncounterPeriod?.Period as object));
			var f_ = context.Operators.End(e_);
			var g_ = context.Operators.ElementInInterval<CqlDateTime>(f_, timeperiod, null);

			return g_;
		};
		var c_ = context.Operators.WhereOrNull<Encounter>(a_, b_);
		var d_ = context.Operators.ExistsInList<Encounter>(c_);

		return d_;
	}

    [CqlDeclaration("Finished Encounter with Telehealth POS")]
	public IEnumerable<Encounter> Finished_Encounter_with_Telehealth_POS(CqlContext context, IEnumerable<Encounter> Encounter)
	{
		var a_ = NCQAStatus_1_0_0.Instance.Finished_Encounter(context, Encounter);
		bool? b_(Encounter E)
		{
			var d_ = context.Operators.Not((bool?)(E?.Class is null));
			var e_ = FHIRHelpers_4_0_001.Instance.ToCode(context, E?.Class);
			var f_ = NCQATerminology_1_0_0.Instance.@virtual(context);
			var g_ = context.Operators.Equivalent(e_, f_);
			var h_ = context.Operators.And(d_, g_);

			return h_;
		};
		var c_ = context.Operators.WhereOrNull<Encounter>(a_, b_);

		return c_;
	}

    [CqlDeclaration("Finished Encounter with Outpatient POS")]
	public IEnumerable<Encounter> Finished_Encounter_with_Outpatient_POS(CqlContext context, IEnumerable<Encounter> Encounter)
	{
		var a_ = NCQAStatus_1_0_0.Instance.Finished_Encounter(context, Encounter);
		bool? b_(Encounter E)
		{
			var d_ = context.Operators.Not((bool?)(E?.Class is null));
			var e_ = FHIRHelpers_4_0_001.Instance.ToCode(context, E?.Class);
			var f_ = NCQATerminology_1_0_0.Instance.ambulatory(context);
			var g_ = context.Operators.Equivalent(e_, f_);
			var i_ = NCQATerminology_1_0_0.Instance.home_health(context);
			var j_ = context.Operators.Equivalent(e_, i_);
			var k_ = context.Operators.Or(g_, j_);
			var l_ = context.Operators.And(d_, k_);

			return l_;
		};
		var c_ = context.Operators.WhereOrNull<Encounter>(a_, b_);

		return c_;
	}

    [CqlDeclaration("Finished Encounter with Ambulatory POS")]
	public IEnumerable<Encounter> Finished_Encounter_with_Ambulatory_POS(CqlContext context, IEnumerable<Encounter> Encounter)
	{
		var a_ = NCQAStatus_1_0_0.Instance.Finished_Encounter(context, Encounter);
		bool? b_(Encounter E)
		{
			var d_ = context.Operators.Not((bool?)(E?.Class is null));
			var e_ = FHIRHelpers_4_0_001.Instance.ToCode(context, E?.Class);
			var f_ = NCQATerminology_1_0_0.Instance.ambulatory(context);
			var g_ = context.Operators.Equivalent(e_, f_);
			var h_ = context.Operators.And(d_, g_);

			return h_;
		};
		var c_ = context.Operators.WhereOrNull<Encounter>(a_, b_);

		return c_;
	}

}