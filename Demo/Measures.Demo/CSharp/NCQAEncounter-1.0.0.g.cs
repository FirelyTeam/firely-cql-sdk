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
		FhirString a_(Encounter.DiagnosisComponent D)
		{
			var f_ = D.Condition;
			var g_ = f_.ReferenceElement;

			return g_;
		};
		var b_ = context.Operators.Select<Encounter.DiagnosisComponent, FhirString>((IEnumerable<Encounter.DiagnosisComponent>)Encounter.Diagnosis, a_);
		bool? c_(FhirString CRef)
		{
			bool? h_(Condition C)
			{
				var k_ = C.IdElement;
				var l_ = FHIRHelpers_4_0_001.ToString(k_);
				var m_ = FHIRHelpers_4_0_001.ToString(CRef);
				var n_ = NCQAFHIRBase_1_0_0.GetId(m_);
				var o_ = context.Operators.Equal(l_, n_);

				return o_;
			};
			var i_ = context.Operators.Where<Condition>(Conditions, h_);
			var j_ = context.Operators.Exists<Condition>(i_);

			return j_;
		};
		var d_ = context.Operators.Select<FhirString, bool?>(b_, c_);
		var e_ = context.Operators.AnyTrue(d_);

		return e_;
	}

    [CqlDeclaration("Encounter Has Principal Diagnosis")]
	public bool? Encounter_Has_Principal_Diagnosis(Encounter Encounter, IEnumerable<Condition> Conditions)
	{
		bool? a_(Encounter.DiagnosisComponent D)
		{
			var h_ = D.RankElement;
			var i_ = context.Operators.Convert<Integer>(h_);
			var j_ = FHIRHelpers_4_0_001.ToInteger(i_);
			var k_ = context.Operators.Equal(j_, 1);

			return k_;
		};
		var b_ = context.Operators.Where<Encounter.DiagnosisComponent>((IEnumerable<Encounter.DiagnosisComponent>)Encounter.Diagnosis, a_);
		var c_ = context.Operators.SingletonFrom<Encounter.DiagnosisComponent>(b_);
		var d_ = new Encounter.DiagnosisComponent[]
		{
			c_,
		};
		bool? e_(Encounter.DiagnosisComponent PrincipalDiagnosis)
		{
			bool? l_(Condition C)
			{
				var o_ = C.IdElement;
				var p_ = FHIRHelpers_4_0_001.ToString(o_);
				var q_ = PrincipalDiagnosis.Condition;
				var r_ = q_.ReferenceElement;
				var s_ = FHIRHelpers_4_0_001.ToString(r_);
				var t_ = NCQAFHIRBase_1_0_0.GetId(s_);
				var u_ = context.Operators.Equal(p_, t_);

				return u_;
			};
			var m_ = context.Operators.Where<Condition>(Conditions, l_);
			var n_ = context.Operators.Exists<Condition>(m_);

			return n_;
		};
		var f_ = context.Operators.Select<Encounter.DiagnosisComponent, bool?>((IEnumerable<Encounter.DiagnosisComponent>)d_, e_);
		var g_ = context.Operators.SingletonFrom<bool?>(f_);

		return g_;
	}

    [CqlDeclaration("Encounter Completed during Period")]
	public bool? Encounter_Completed_during_Period(IEnumerable<Encounter> Enc, CqlInterval<CqlDateTime> timeperiod)
	{
		var a_ = NCQAStatus_1_0_0.Finished_Encounter(Enc);
		bool? b_(Encounter EncounterPeriod)
		{
			var e_ = EncounterPeriod.Period;
			var f_ = NCQAFHIRBase_1_0_0.Normalize_Interval((e_ as object));
			var g_ = context.Operators.End(f_);
			var h_ = context.Operators.In<CqlDateTime>(g_, timeperiod, null);

			return h_;
		};
		var c_ = context.Operators.Where<Encounter>(a_, b_);
		var d_ = context.Operators.Exists<Encounter>(c_);

		return d_;
	}

    [CqlDeclaration("Finished Encounter with Telehealth POS")]
	public IEnumerable<Encounter> Finished_Encounter_with_Telehealth_POS(IEnumerable<Encounter> Encounter)
	{
		var a_ = NCQAStatus_1_0_0.Finished_Encounter(Encounter);
		bool? b_(Encounter E)
		{
			var d_ = E.Class;
			var e_ = context.Operators.Not((bool?)(d_ is null));
			var g_ = FHIRHelpers_4_0_001.ToCode(d_);
			var h_ = NCQATerminology_1_0_0.@virtual();
			var i_ = context.Operators.Equivalent(g_, h_);
			var j_ = context.Operators.And(e_, i_);

			return j_;
		};
		var c_ = context.Operators.Where<Encounter>(a_, b_);

		return c_;
	}

    [CqlDeclaration("Finished Encounter with Outpatient POS")]
	public IEnumerable<Encounter> Finished_Encounter_with_Outpatient_POS(IEnumerable<Encounter> Encounter)
	{
		var a_ = NCQAStatus_1_0_0.Finished_Encounter(Encounter);
		bool? b_(Encounter E)
		{
			var d_ = E.Class;
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
		var c_ = context.Operators.Where<Encounter>(a_, b_);

		return c_;
	}

    [CqlDeclaration("Finished Encounter with Ambulatory POS")]
	public IEnumerable<Encounter> Finished_Encounter_with_Ambulatory_POS(IEnumerable<Encounter> Encounter)
	{
		var a_ = NCQAStatus_1_0_0.Finished_Encounter(Encounter);
		bool? b_(Encounter E)
		{
			var d_ = E.Class;
			var e_ = context.Operators.Not((bool?)(d_ is null));
			var g_ = FHIRHelpers_4_0_001.ToCode(d_);
			var h_ = NCQATerminology_1_0_0.ambulatory();
			var i_ = context.Operators.Equivalent(g_, h_);
			var j_ = context.Operators.And(e_, i_);

			return j_;
		};
		var c_ = context.Operators.Where<Encounter>(a_, b_);

		return c_;
	}

}
