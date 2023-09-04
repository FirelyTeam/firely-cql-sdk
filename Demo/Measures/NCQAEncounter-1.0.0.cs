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

[System.CodeDom.Compiler.GeneratedCode(".NET Code Generation", "0.9.0.0")]
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
        Func<Encounter.DiagnosisComponent,FhirString> b_ = (D) => 
        {
            return D?.Condition?.ReferenceElement;
        };
        var c_ = context?.Operators.SelectOrNull<Encounter.DiagnosisComponent, FhirString>(a_, 
			b_);
        Func<FhirString,bool?> k_ = (CRef) => 
        {
            Func<Condition,bool?> i_ = (C) => 
            {
                var e_ = (C?.IdElement as object);
                var d_ = ((context.OnFunctionCalled(new FunctionCallEvent("ToString", 
		null, 
		null))?.Operators).Convert<string>(e_) as object);
                var g_ = (CRef as object);
                var h_ = (context.OnFunctionCalled(new FunctionCallEvent("ToString", 
		null, 
		null))?.Operators).Convert<string>(g_);
                var f_ = (NCQAFHIRBase_1_0_0.GetId(h_) as object);
                return context?.Operators.Equal(d_, 
					f_);
            };
            var j_ = context?.Operators.WhereOrNull<Condition>(Conditions, 
				i_);
            return context?.Operators.ExistsInList<Condition>(j_);
        };
        var l_ = context?.Operators.SelectOrNull<FhirString, bool?>(c_, 
			k_);
        return context?.Operators.AnyTrue(l_);
    }

    [CqlDeclaration("Encounter Has Principal Diagnosis")]
    public bool? Encounter_Has_Principal_Diagnosis(Encounter Encounter, IEnumerable<Condition> Conditions)
    {
        var c_ = (Encounter?.Diagnosis as IEnumerable<Encounter.DiagnosisComponent>);
        Func<Encounter.DiagnosisComponent,bool?> h_ = (D) => 
        {
            var e_ = (D?.RankElement as object);
            var f_ = context?.Operators.Convert<Integer>(e_);
            var d_ = (FHIRHelpers_4_0_001.ToInteger(f_) as object);
            var g_ = (((int?)1) as object);
            return context?.Operators.Equal(d_, 
				g_);
        };
        var i_ = context?.Operators.WhereOrNull<Encounter.DiagnosisComponent>(c_, 
			h_);
        var b_ = context?.Operators.SingleOrNull<Encounter.DiagnosisComponent>(i_);
        var a_ = new Encounter.DiagnosisComponent[]
		{
			b_,
		};
        Func<Encounter.DiagnosisComponent,bool?> q_ = (PrincipalDiagnosis) => 
        {
            Func<Condition,bool?> o_ = (C) => 
            {
                var k_ = (C?.IdElement as object);
                var j_ = ((context.OnFunctionCalled(new FunctionCallEvent("ToString", 
		null, 
		null))?.Operators).Convert<string>(k_) as object);
                var m_ = (PrincipalDiagnosis?.Condition?.ReferenceElement as object);
                var n_ = (context.OnFunctionCalled(new FunctionCallEvent("ToString", 
		null, 
		null))?.Operators).Convert<string>(m_);
                var l_ = (NCQAFHIRBase_1_0_0.GetId(n_) as object);
                return context?.Operators.Equal(j_, 
					l_);
            };
            var p_ = context?.Operators.WhereOrNull<Condition>(Conditions, 
				o_);
            return context?.Operators.ExistsInList<Condition>(p_);
        };
        var r_ = context?.Operators.SelectOrNull<Encounter.DiagnosisComponent, bool?>(a_, 
			q_);
        return context?.Operators.SingleOrNull<bool?>(r_);
    }

    [CqlDeclaration("Encounter Completed during Period")]
    public bool? Encounter_Completed_during_Period(IEnumerable<Encounter> Enc, CqlInterval<CqlDateTime> timeperiod)
    {
        var a_ = NCQAStatus_1_0_0.Finished_Encounter(Enc);
        Func<Encounter,bool?> e_ = (EncounterPeriod) => 
        {
            var b_ = (EncounterPeriod?.Period as object);
            var c_ = NCQAFHIRBase_1_0_0.Normalize_Interval(b_);
            var d_ = context?.Operators.End(c_);
            return context?.Operators.ElementInInterval<CqlDateTime>(d_, 
				timeperiod, 
				null);
        };
        var f_ = context?.Operators.WhereOrNull<Encounter>(a_, 
			e_);
        return context?.Operators.ExistsInList<Encounter>(f_);
    }

    [CqlDeclaration("Finished Encounter with Telehealth POS")]
    public IEnumerable<Encounter> Finished_Encounter_with_Telehealth_POS(IEnumerable<Encounter> Encounter)
    {
        var a_ = NCQAStatus_1_0_0.Finished_Encounter(Encounter);
        Func<Encounter,bool?> h_ = (E) => 
        {
            bool? b_ = ((bool?)(E?.Class == null));
            var c_ = context?.Operators.Not(b_);
            var e_ = E?.Class;
            var d_ = (FHIRHelpers_4_0_001.ToCode(e_) as object);
            var f_ = (NCQATerminology_1_0_0.@virtual() as object);
            var g_ = context?.Operators.Equivalent(d_, 
				f_);
            return context?.Operators.And(c_, 
				g_);
        };
        return context?.Operators.WhereOrNull<Encounter>(a_, 
			h_);
    }

    [CqlDeclaration("Finished Encounter with Outpatient POS")]
    public IEnumerable<Encounter> Finished_Encounter_with_Outpatient_POS(IEnumerable<Encounter> Encounter)
    {
        var a_ = NCQAStatus_1_0_0.Finished_Encounter(Encounter);
        Func<Encounter,bool?> m_ = (E) => 
        {
            bool? b_ = ((bool?)(E?.Class == null));
            var c_ = context?.Operators.Not(b_);
            var e_ = E?.Class;
            var d_ = (FHIRHelpers_4_0_001.ToCode(e_) as object);
            var f_ = (NCQATerminology_1_0_0.ambulatory() as object);
            var g_ = context?.Operators.Equivalent(d_, 
				f_);
            var j_ = (NCQATerminology_1_0_0.home_health() as object);
            var k_ = context?.Operators.Equivalent(d_, 
				j_);
            var l_ = context?.Operators.Or(g_, 
				k_);
            return context?.Operators.And(c_, 
				l_);
        };
        return context?.Operators.WhereOrNull<Encounter>(a_, 
			m_);
    }

    [CqlDeclaration("Finished Encounter with Ambulatory POS")]
    public IEnumerable<Encounter> Finished_Encounter_with_Ambulatory_POS(IEnumerable<Encounter> Encounter)
    {
        var a_ = NCQAStatus_1_0_0.Finished_Encounter(Encounter);
        Func<Encounter,bool?> h_ = (E) => 
        {
            bool? b_ = ((bool?)(E?.Class == null));
            var c_ = context?.Operators.Not(b_);
            var e_ = E?.Class;
            var d_ = (FHIRHelpers_4_0_001.ToCode(e_) as object);
            var f_ = (NCQATerminology_1_0_0.ambulatory() as object);
            var g_ = context?.Operators.Equivalent(d_, 
				f_);
            return context?.Operators.And(c_, 
				g_);
        };
        return context?.Operators.WhereOrNull<Encounter>(a_, 
			h_);
    }

}