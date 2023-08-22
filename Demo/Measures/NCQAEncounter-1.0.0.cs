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
		var a_ = (Encounter?.Diagnosis as IEnumerable<Encounter.DiagnosisComponent>);
		var b_ = (Encounter.DiagnosisComponent D) => D?.Condition?.ReferenceElement;
		var c_ = context?.Operators.SelectOrNull<Encounter.DiagnosisComponent, FhirString>(a_, b_);
		var d_ = (FhirString CRef) =>
		{
			var a_ = (Condition C) =>
			{
				var a_ = (C?.IdElement as object);
				var b_ = (context.Deeper(new CallStackEntry("ToString", 
		null, 
		null))?.Operators?.TypeConverter).Convert<string>(a_);
				var c_ = (b_ as object);
				var d_ = (context.Deeper(new CallStackEntry("ToString", 
		null, 
		null))?.Operators?.TypeConverter).Convert<string>((CRef as object));
				var e_ = NCQAFHIRBase_1_0_0.GetId(d_);
				var f_ = (e_ as object);

				return context?.Operators.Equal(c_, f_);
			};
			var b_ = context?.Operators.WhereOrNull<Condition>(Conditions, a_);

			return context?.Operators.ExistsInList<Condition>(b_);
		};
		var e_ = context?.Operators.SelectOrNull<FhirString, bool?>(c_, d_);

		return context?.Operators.AnyTrue(e_);
	}


    [CqlDeclaration("Encounter Has Principal Diagnosis")]
    public bool? Encounter_Has_Principal_Diagnosis(Encounter Encounter, IEnumerable<Condition> Conditions)
	{
		var a_ = (Encounter?.Diagnosis as IEnumerable<Encounter.DiagnosisComponent>);
		var b_ = (Encounter.DiagnosisComponent D) =>
		{
			var a_ = (D?.RankElement as object);
			var b_ = context?.Operators?.TypeConverter.Convert<Integer>(a_);
			var c_ = FHIRHelpers_4_0_001.ToInteger(b_);
			var d_ = (c_ as object);
			var e_ = ((int?)1 as object);

			return context?.Operators.Equal(d_, e_);
		};
		var c_ = context?.Operators.WhereOrNull<Encounter.DiagnosisComponent>(a_, b_);
		var d_ = context?.Operators.SingleOrNull<Encounter.DiagnosisComponent>(c_);
		var e_ = new Encounter.DiagnosisComponent[]
		{
			d_,
		};
		var f_ = (Encounter.DiagnosisComponent PrincipalDiagnosis) =>
		{
			var a_ = (Condition C) =>
			{
				var a_ = (C?.IdElement as object);
				var b_ = (context.Deeper(new CallStackEntry("ToString", 
		null, 
		null))?.Operators?.TypeConverter).Convert<string>(a_);
				var c_ = (b_ as object);
				var d_ = (PrincipalDiagnosis?.Condition?.ReferenceElement as object);
				var e_ = (context.Deeper(new CallStackEntry("ToString", 
		null, 
		null))?.Operators?.TypeConverter).Convert<string>(d_);
				var f_ = NCQAFHIRBase_1_0_0.GetId(e_);
				var g_ = (f_ as object);

				return context?.Operators.Equal(c_, g_);
			};
			var b_ = context?.Operators.WhereOrNull<Condition>(Conditions, a_);

			return context?.Operators.ExistsInList<Condition>(b_);
		};
		var g_ = context?.Operators.SelectOrNull<Encounter.DiagnosisComponent, bool?>(e_, f_);

		return context?.Operators.SingleOrNull<bool?>(g_);
	}


    [CqlDeclaration("Encounter Completed during Period")]
    public bool? Encounter_Completed_during_Period(IEnumerable<Encounter> Enc, CqlInterval<CqlDateTime> timeperiod)
	{
		var a_ = NCQAStatus_1_0_0.Finished_Encounter(Enc);
		var b_ = (Encounter EncounterPeriod) =>
		{
			var a_ = (EncounterPeriod?.Period as object);
			var b_ = NCQAFHIRBase_1_0_0.Normalize_Interval(a_);
			var c_ = context?.Operators.End(b_);

			return context?.Operators.ElementInInterval<CqlDateTime>(c_, timeperiod, null);
		};
		var c_ = context?.Operators.WhereOrNull<Encounter>(a_, b_);

		return context?.Operators.ExistsInList<Encounter>(c_);
	}


    [CqlDeclaration("Finished Encounter with Telehealth POS")]
    public IEnumerable<Encounter> Finished_Encounter_with_Telehealth_POS(IEnumerable<Encounter> Encounter)
	{
		var a_ = NCQAStatus_1_0_0.Finished_Encounter(Encounter);
		var b_ = (Encounter E) =>
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

		return context?.Operators.WhereOrNull<Encounter>(a_, b_);
	}


    [CqlDeclaration("Finished Encounter with Outpatient POS")]
    public IEnumerable<Encounter> Finished_Encounter_with_Outpatient_POS(IEnumerable<Encounter> Encounter)
	{
		var a_ = NCQAStatus_1_0_0.Finished_Encounter(Encounter);
		var b_ = (Encounter E) =>
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

		return context?.Operators.WhereOrNull<Encounter>(a_, b_);
	}


    [CqlDeclaration("Finished Encounter with Ambulatory POS")]
    public IEnumerable<Encounter> Finished_Encounter_with_Ambulatory_POS(IEnumerable<Encounter> Encounter)
	{
		var a_ = NCQAStatus_1_0_0.Finished_Encounter(Encounter);
		var b_ = (Encounter E) =>
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

		return context?.Operators.WhereOrNull<Encounter>(a_, b_);
	}


}