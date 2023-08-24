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
		var i_ = (Encounter?.Diagnosis as IEnumerable<Encounter.DiagnosisComponent>);
		var j_ = (Encounter.DiagnosisComponent D) => D?.Condition?.ReferenceElement;
		var k_ = context?.Operators.SelectOrNull<Encounter.DiagnosisComponent, FhirString>(i_, j_);
		var l_ = (FhirString CRef) =>
		{
			var g_ = (Condition C) =>
			{
				var a_ = (C?.IdElement as object);
				var b_ = (context.Deeper(new CallStackEntry("ToString", null, null))?.Operators?.TypeConverter).Convert<string>(a_);
				var c_ = (b_ as object);
				var d_ = (context.Deeper(new CallStackEntry("ToString", null, null))?.Operators?.TypeConverter).Convert<string>((CRef as object));
				var e_ = NCQAFHIRBase_1_0_0.GetId(d_);
				var f_ = (e_ as object);

				return context?.Operators.Equal(c_, f_);
			};
			var h_ = context?.Operators.WhereOrNull<Condition>(Conditions, g_);

			return context?.Operators.ExistsInList<Condition>(h_);
		};
		var m_ = context?.Operators.SelectOrNull<FhirString, bool?>(k_, l_);

		return context?.Operators.AnyTrue(m_);
	}


    [CqlDeclaration("Encounter Has Principal Diagnosis")]
    public bool? Encounter_Has_Principal_Diagnosis(Encounter Encounter, IEnumerable<Condition> Conditions)
	{
		var o_ = (Encounter?.Diagnosis as IEnumerable<Encounter.DiagnosisComponent>);
		var p_ = (Encounter.DiagnosisComponent D) =>
		{
			var a_ = (D?.RankElement as object);
			var b_ = context?.Operators?.TypeConverter.Convert<Integer>(a_);
			var c_ = FHIRHelpers_4_0_001.ToInteger(b_);
			var d_ = (c_ as object);
			var e_ = ((int?)1 as object);

			return context?.Operators.Equal(d_, e_);
		};
		var q_ = context?.Operators.WhereOrNull<Encounter.DiagnosisComponent>(o_, p_);
		var r_ = context?.Operators.SingleOrNull<Encounter.DiagnosisComponent>(q_);
		var s_ = new Encounter.DiagnosisComponent[]
		{
			r_,
		};
		var t_ = (Encounter.DiagnosisComponent PrincipalDiagnosis) =>
		{
			var m_ = (Condition C) =>
			{
				var f_ = (C?.IdElement as object);
				var g_ = (context.Deeper(new CallStackEntry("ToString", null, null))?.Operators?.TypeConverter).Convert<string>(f_);
				var h_ = (g_ as object);
				var i_ = (PrincipalDiagnosis?.Condition?.ReferenceElement as object);
				var j_ = (context.Deeper(new CallStackEntry("ToString", null, null))?.Operators?.TypeConverter).Convert<string>(i_);
				var k_ = NCQAFHIRBase_1_0_0.GetId(j_);
				var l_ = (k_ as object);

				return context?.Operators.Equal(h_, l_);
			};
			var n_ = context?.Operators.WhereOrNull<Condition>(Conditions, m_);

			return context?.Operators.ExistsInList<Condition>(n_);
		};
		var u_ = context?.Operators.SelectOrNull<Encounter.DiagnosisComponent, bool?>(s_, t_);

		return context?.Operators.SingleOrNull<bool?>(u_);
	}


    [CqlDeclaration("Encounter Completed during Period")]
    public bool? Encounter_Completed_during_Period(IEnumerable<Encounter> Enc, CqlInterval<CqlDateTime> timeperiod)
	{
		var d_ = NCQAStatus_1_0_0.Finished_Encounter(Enc);
		var e_ = (Encounter EncounterPeriod) =>
		{
			var a_ = (EncounterPeriod?.Period as object);
			var b_ = NCQAFHIRBase_1_0_0.Normalize_Interval(a_);
			var c_ = context?.Operators.End(b_);

			return context?.Operators.ElementInInterval<CqlDateTime>(c_, timeperiod, null);
		};
		var f_ = context?.Operators.WhereOrNull<Encounter>(d_, e_);

		return context?.Operators.ExistsInList<Encounter>(f_);
	}


    [CqlDeclaration("Finished Encounter with Telehealth POS")]
    public IEnumerable<Encounter> Finished_Encounter_with_Telehealth_POS(IEnumerable<Encounter> Encounter)
	{
		var h_ = NCQAStatus_1_0_0.Finished_Encounter(Encounter);
		var i_ = (Encounter E) =>
		{
			var a_ = (bool?)(E?.Class == null);
			var b_ = context?.Operators.Not(a_);
			var c_ = E?.Class;
			var d_ = FHIRHelpers_4_0_001.ToCode(c_);
			var e_ = (d_ as object);
			var f_ = (NCQATerminology_1_0_0.@virtual() as object);
			var g_ = context?.Operators.Equivalent(e_, f_);

			return context?.Operators.And(b_, g_);
		};

		return context?.Operators.WhereOrNull<Encounter>(h_, i_);
	}


    [CqlDeclaration("Finished Encounter with Outpatient POS")]
    public IEnumerable<Encounter> Finished_Encounter_with_Outpatient_POS(IEnumerable<Encounter> Encounter)
	{
		var n_ = NCQAStatus_1_0_0.Finished_Encounter(Encounter);
		var o_ = (Encounter E) =>
		{
			var a_ = (bool?)(E?.Class == null);
			var b_ = context?.Operators.Not(a_);
			var c_ = E?.Class;
			var d_ = FHIRHelpers_4_0_001.ToCode(c_);
			var e_ = (d_ as object);
			var f_ = (NCQATerminology_1_0_0.ambulatory() as object);
			var g_ = context?.Operators.Equivalent(e_, f_);
			var h_ = E?.Class;
			var i_ = FHIRHelpers_4_0_001.ToCode(h_);
			var j_ = (i_ as object);
			var k_ = (NCQATerminology_1_0_0.home_health() as object);
			var l_ = context?.Operators.Equivalent(j_, k_);
			var m_ = context?.Operators.Or(g_, l_);

			return context?.Operators.And(b_, m_);
		};

		return context?.Operators.WhereOrNull<Encounter>(n_, o_);
	}


    [CqlDeclaration("Finished Encounter with Ambulatory POS")]
    public IEnumerable<Encounter> Finished_Encounter_with_Ambulatory_POS(IEnumerable<Encounter> Encounter)
	{
		var h_ = NCQAStatus_1_0_0.Finished_Encounter(Encounter);
		var i_ = (Encounter E) =>
		{
			var a_ = (bool?)(E?.Class == null);
			var b_ = context?.Operators.Not(a_);
			var c_ = E?.Class;
			var d_ = FHIRHelpers_4_0_001.ToCode(c_);
			var e_ = (d_ as object);
			var f_ = (NCQATerminology_1_0_0.ambulatory() as object);
			var g_ = context?.Operators.Equivalent(e_, f_);

			return context?.Operators.And(b_, g_);
		};

		return context?.Operators.WhereOrNull<Encounter>(h_, i_);
	}


}