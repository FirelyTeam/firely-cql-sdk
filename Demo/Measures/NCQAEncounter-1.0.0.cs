using System;
using System.Linq;
using System.Collections.Generic;
using Hl7.Cql.Runtime;
using Hl7.Cql.Primitives;
using Hl7.Cql;
using Hl7.Cql.ValueSets;
using Hl7.Cql.Iso8601;
using Hl7.Fhir.Model;
using Range = Hl7.Fhir.Model.Range;
using Task = Hl7.Fhir.Model.Task;
[System.CodeDom.Compiler.GeneratedCode(".NET Code Generation", "0.0.1.0")]
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
		var k_ = Encounter?.Diagnosis;
		var l_ = (k_ as IEnumerable<Encounter.DiagnosisComponent>);
		var m_ = (Encounter.DiagnosisComponent D) =>
		{
			var a_ = D?.Condition;

			return a_?.ReferenceElement;
		};
		var n_ = context?.Operators.SelectOrNull<Encounter.DiagnosisComponent, FhirString>(l_, m_);
		var o_ = (FhirString CRef) =>
		{
			var i_ = (Condition C) =>
			{
				var b_ = C?.IdElement;
				var c_ = (b_ as object);
				var d_ = (context.Deeper(new CallStackEntry("ToString", null, null))?.Operators?.TypeConverter).Convert<string>(c_);
				var e_ = (d_ as object);
				var f_ = (context.Deeper(new CallStackEntry("ToString", null, null))?.Operators?.TypeConverter).Convert<string>((CRef as object));
				var g_ = NCQAFHIRBase_1_0_0.GetId(f_);
				var h_ = (g_ as object);

				return context?.Operators.Equal(e_, h_);
			};
			var j_ = context?.Operators.WhereOrNull<Condition>(Conditions, i_);

			return context?.Operators.ExistsInList<Condition>(j_);
		};
		var p_ = context?.Operators.SelectOrNull<FhirString, bool?>(n_, o_);

		return context?.Operators.AnyTrue(p_);
	}


    [CqlDeclaration("Encounter Has Principal Diagnosis")]
    public bool? Encounter_Has_Principal_Diagnosis(Encounter Encounter, IEnumerable<Condition> Conditions)
	{
		var t_ = Encounter?.Diagnosis;
		var u_ = (t_ as IEnumerable<Encounter.DiagnosisComponent>);
		var v_ = (Encounter.DiagnosisComponent D) =>
		{
			var a_ = D?.RankElement;
			var b_ = (a_ as object);
			var c_ = context?.Operators?.TypeConverter.Convert<Integer>(b_);
			var d_ = FHIRHelpers_4_0_001.ToInteger(c_);
			var e_ = d_;
			var f_ = (int?)1;
			var g_ = f_;

			return context?.Operators.Equal(e_, g_);
		};
		var w_ = context?.Operators.WhereOrNull<Encounter.DiagnosisComponent>(u_, v_);
		var x_ = context?.Operators.SingleOrNull<Encounter.DiagnosisComponent>(w_);
		var y_ = new Encounter.DiagnosisComponent[]
		{
			x_,
		};
		var z_ = (Encounter.DiagnosisComponent PrincipalDiagnosis) =>
		{
			var r_ = (Condition C) =>
			{
				var h_ = C?.IdElement;
				var i_ = (h_ as object);
				var j_ = (context.Deeper(new CallStackEntry("ToString", null, null))?.Operators?.TypeConverter).Convert<string>(i_);
				var k_ = (j_ as object);
				var l_ = PrincipalDiagnosis?.Condition;
				var m_ = l_?.ReferenceElement;
				var n_ = (m_ as object);
				var o_ = (context.Deeper(new CallStackEntry("ToString", null, null))?.Operators?.TypeConverter).Convert<string>(n_);
				var p_ = NCQAFHIRBase_1_0_0.GetId(o_);
				var q_ = (p_ as object);

				return context?.Operators.Equal(k_, q_);
			};
			var s_ = context?.Operators.WhereOrNull<Condition>(Conditions, r_);

			return context?.Operators.ExistsInList<Condition>(s_);
		};
		var aa_ = context?.Operators.SelectOrNull<Encounter.DiagnosisComponent, bool?>(y_, z_);

		return context?.Operators.SingleOrNull<bool?>(aa_);
	}


    [CqlDeclaration("Encounter Completed during Period")]
    public bool? Encounter_Completed_during_Period(IEnumerable<Encounter> Enc, CqlInterval<CqlDateTime> timeperiod)
	{
		var e_ = NCQAStatus_1_0_0.Finished_Encounter(Enc);
		var f_ = (Encounter EncounterPeriod) =>
		{
			var a_ = EncounterPeriod?.Period;
			var b_ = (a_ as object);
			var c_ = NCQAFHIRBase_1_0_0.Normalize_Interval(b_);
			var d_ = context?.Operators.End(c_);

			return context?.Operators.ElementInInterval<CqlDateTime>(d_, timeperiod, null);
		};
		var g_ = context?.Operators.WhereOrNull<Encounter>(e_, f_);

		return context?.Operators.ExistsInList<Encounter>(g_);
	}


    [CqlDeclaration("Finished Encounter with Telehealth POS")]
    public IEnumerable<Encounter> Finished_Encounter_with_Telehealth_POS(IEnumerable<Encounter> Encounter)
	{
		var k_ = NCQAStatus_1_0_0.Finished_Encounter(Encounter);
		var l_ = (Encounter E) =>
		{
			var a_ = E?.Class;
			var b_ = (a_ == null);
			var c_ = (bool?)b_;
			var d_ = context?.Operators.Not(c_);
			var e_ = E?.Class;
			var f_ = FHIRHelpers_4_0_001.ToCode(e_);
			var g_ = (f_ as object);
			var h_ = NCQATerminology_1_0_0.@virtual();
			var i_ = (h_ as object);
			var j_ = context?.Operators.Equivalent(g_, i_);

			return context?.Operators.And(d_, j_);
		};

		return context?.Operators.WhereOrNull<Encounter>(k_, l_);
	}


    [CqlDeclaration("Finished Encounter with Outpatient POS")]
    public IEnumerable<Encounter> Finished_Encounter_with_Outpatient_POS(IEnumerable<Encounter> Encounter)
	{
		var r_ = NCQAStatus_1_0_0.Finished_Encounter(Encounter);
		var s_ = (Encounter E) =>
		{
			var a_ = E?.Class;
			var b_ = (a_ == null);
			var c_ = (bool?)b_;
			var d_ = context?.Operators.Not(c_);
			var e_ = E?.Class;
			var f_ = FHIRHelpers_4_0_001.ToCode(e_);
			var g_ = (f_ as object);
			var h_ = NCQATerminology_1_0_0.ambulatory();
			var i_ = (h_ as object);
			var j_ = context?.Operators.Equivalent(g_, i_);
			var k_ = E?.Class;
			var l_ = FHIRHelpers_4_0_001.ToCode(k_);
			var m_ = (l_ as object);
			var n_ = NCQATerminology_1_0_0.home_health();
			var o_ = (n_ as object);
			var p_ = context?.Operators.Equivalent(m_, o_);
			var q_ = context?.Operators.Or(j_, p_);

			return context?.Operators.And(d_, q_);
		};

		return context?.Operators.WhereOrNull<Encounter>(r_, s_);
	}


    [CqlDeclaration("Finished Encounter with Ambulatory POS")]
    public IEnumerable<Encounter> Finished_Encounter_with_Ambulatory_POS(IEnumerable<Encounter> Encounter)
	{
		var k_ = NCQAStatus_1_0_0.Finished_Encounter(Encounter);
		var l_ = (Encounter E) =>
		{
			var a_ = E?.Class;
			var b_ = (a_ == null);
			var c_ = (bool?)b_;
			var d_ = context?.Operators.Not(c_);
			var e_ = E?.Class;
			var f_ = FHIRHelpers_4_0_001.ToCode(e_);
			var g_ = (f_ as object);
			var h_ = NCQATerminology_1_0_0.ambulatory();
			var i_ = (h_ as object);
			var j_ = context?.Operators.Equivalent(g_, i_);

			return context?.Operators.And(d_, j_);
		};

		return context?.Operators.WhereOrNull<Encounter>(k_, l_);
	}


}