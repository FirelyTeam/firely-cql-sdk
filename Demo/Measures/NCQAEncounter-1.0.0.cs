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
		var a_ = Encounter?.Diagnosis;
		FhirString b_(Encounter.DiagnosisComponent D)
		{
			var g_ = D?.Condition;
			var h_ = g_?.ReferenceElement;

			return h_;
		};
		var c_ = context.Operators.SelectOrNull<Encounter.DiagnosisComponent, FhirString>((a_ as IEnumerable<Encounter.DiagnosisComponent>), b_);
		bool? d_(FhirString CRef)
		{
			bool? i_(Condition C)
			{
				var l_ = C?.IdElement;
				var m_ = context.Operators.Convert<string>(l_);
				var n_ = context.Operators.Convert<string>(CRef);
				var o_ = NCQAFHIRBase_1_0_0.GetId(n_);
				var p_ = context.Operators.Equal(m_, o_);

				return p_;
			};
			var j_ = context.Operators.WhereOrNull<Condition>(Conditions, i_);
			var k_ = context.Operators.ExistsInList<Condition>(j_);

			return k_;
		};
		var e_ = context.Operators.SelectOrNull<FhirString, bool?>(c_, d_);
		var f_ = context.Operators.AnyTrue(e_);

		return f_;
	}

    [CqlDeclaration("Encounter Has Principal Diagnosis")]
	public bool? Encounter_Has_Principal_Diagnosis(Encounter Encounter, IEnumerable<Condition> Conditions)
	{
		var a_ = Encounter?.Diagnosis;
		bool? b_(Encounter.DiagnosisComponent D)
		{
			var i_ = D?.RankElement;
			var j_ = context.Operators.Convert<Integer>(i_);
			var k_ = FHIRHelpers_4_0_001.ToInteger(j_);
			var l_ = context.Operators.Equal(k_, (int?)1);

			return l_;
		};
		var c_ = context.Operators.WhereOrNull<Encounter.DiagnosisComponent>((a_ as IEnumerable<Encounter.DiagnosisComponent>), b_);
		var d_ = context.Operators.SingleOrNull<Encounter.DiagnosisComponent>(c_);
		var e_ = new Encounter.DiagnosisComponent[]
		{
			d_,
		};
		bool? f_(Encounter.DiagnosisComponent PrincipalDiagnosis)
		{
			bool? m_(Condition C)
			{
				var p_ = C?.IdElement;
				var q_ = context.Operators.Convert<string>(p_);
				var r_ = PrincipalDiagnosis?.Condition;
				var s_ = r_?.ReferenceElement;
				var t_ = context.Operators.Convert<string>(s_);
				var u_ = NCQAFHIRBase_1_0_0.GetId(t_);
				var v_ = context.Operators.Equal(q_, u_);

				return v_;
			};
			var n_ = context.Operators.WhereOrNull<Condition>(Conditions, m_);
			var o_ = context.Operators.ExistsInList<Condition>(n_);

			return o_;
		};
		var g_ = context.Operators.SelectOrNull<Encounter.DiagnosisComponent, bool?>(e_, f_);
		var h_ = context.Operators.SingleOrNull<bool?>(g_);

		return h_;
	}

    [CqlDeclaration("Encounter Completed during Period")]
	public bool? Encounter_Completed_during_Period(IEnumerable<Encounter> Enc, CqlInterval<CqlDateTime> timeperiod)
	{
		var a_ = NCQAStatus_1_0_0.Finished_Encounter(Enc);
		bool? b_(Encounter EncounterPeriod)
		{
			var e_ = EncounterPeriod?.Period;
			var f_ = NCQAFHIRBase_1_0_0.Normalize_Interval(e_);
			var g_ = context.Operators.End(f_);
			var h_ = context.Operators.ElementInInterval<CqlDateTime>(g_, timeperiod, null);

			return h_;
		};
		var c_ = context.Operators.WhereOrNull<Encounter>(a_, b_);
		var d_ = context.Operators.ExistsInList<Encounter>(c_);

		return d_;
	}

    [CqlDeclaration("Finished Encounter with Telehealth POS")]
	public IEnumerable<Encounter> Finished_Encounter_with_Telehealth_POS(IEnumerable<Encounter> Encounter)
	{
		var a_ = NCQAStatus_1_0_0.Finished_Encounter(Encounter);
		bool? b_(Encounter E)
		{
			var d_ = E?.Class;
			var e_ = context.Operators.Not((bool?)(d_ is null));
			var g_ = FHIRHelpers_4_0_001.ToCode(d_);
			var h_ = NCQATerminology_1_0_0.@virtual();
			var i_ = context.Operators.Equivalent(g_, h_);
			var j_ = context.Operators.And(e_, i_);

			return j_;
		};
		var c_ = context.Operators.WhereOrNull<Encounter>(a_, b_);

		return c_;
	}

    [CqlDeclaration("Finished Encounter with Outpatient POS")]
	public IEnumerable<Encounter> Finished_Encounter_with_Outpatient_POS(IEnumerable<Encounter> Encounter)
	{
		var a_ = NCQAStatus_1_0_0.Finished_Encounter(Encounter);
		bool? b_(Encounter E)
		{
			var d_ = E?.Class;
			var e_ = context.Operators.Not((bool?)(d_ is null));
			var g_ = FHIRHelpers_4_0_001.ToCode(d_);
			var h_ = NCQATerminology_1_0_0.ambulatory();
			var i_ = context.Operators.Equivalent(g_, h_);
			var k_ = FHIRHelpers_4_0_001.ToCode(d_);
			var l_ = NCQATerminology_1_0_0.home_health();
			var m_ = context.Operators.Equivalent(k_, l_);
			var n_ = context.Operators.Or(i_, m_);
			var o_ = context.Operators.And(e_, n_);

			return o_;
		};
		var c_ = context.Operators.WhereOrNull<Encounter>(a_, b_);

		return c_;
	}

    [CqlDeclaration("Finished Encounter with Ambulatory POS")]
	public IEnumerable<Encounter> Finished_Encounter_with_Ambulatory_POS(IEnumerable<Encounter> Encounter)
	{
		var a_ = NCQAStatus_1_0_0.Finished_Encounter(Encounter);
		bool? b_(Encounter E)
		{
			var d_ = E?.Class;
			var e_ = context.Operators.Not((bool?)(d_ is null));
			var g_ = FHIRHelpers_4_0_001.ToCode(d_);
			var h_ = NCQATerminology_1_0_0.ambulatory();
			var i_ = context.Operators.Equivalent(g_, h_);
			var j_ = context.Operators.And(e_, i_);

			return j_;
		};
		var c_ = context.Operators.WhereOrNull<Encounter>(a_, b_);

		return c_;
	}

}