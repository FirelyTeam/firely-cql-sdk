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
		var a_ = context.Operators;
		var d_ = Encounter?.Diagnosis;
		FhirString e_(Encounter.DiagnosisComponent D)
		{
			var j_ = D?.Condition;
			var k_ = j_?.ReferenceElement;

			return k_;
		};
		var f_ = a_.SelectOrNull<Encounter.DiagnosisComponent, FhirString>((d_ as IEnumerable<Encounter.DiagnosisComponent>), e_);
		bool? g_(FhirString CRef)
		{
			var l_ = context.Operators;
			bool? n_(Condition C)
			{
				var q_ = context.Operators;
				var r_ = context.Deeper(new CallStackEntry("ToString", null, null));
				var s_ = r_.Operators;
				var t_ = s_.TypeConverter;
				var u_ = C?.IdElement;
				var v_ = t_.Convert<string>(u_);
				var x_ = r_.Operators;
				var y_ = x_.TypeConverter;
				var z_ = y_.Convert<string>(CRef);
				var aa_ = NCQAFHIRBase_1_0_0.GetId(z_);
				var ab_ = q_.Equal(v_, aa_);

				return ab_;
			};
			var o_ = l_.WhereOrNull<Condition>(Conditions, n_);
			var p_ = l_.ExistsInList<Condition>(o_);

			return p_;
		};
		var h_ = a_.SelectOrNull<FhirString, bool?>(f_, g_);
		var i_ = a_.AnyTrue(h_);

		return i_;
	}

    [CqlDeclaration("Encounter Has Principal Diagnosis")]
	public bool? Encounter_Has_Principal_Diagnosis(Encounter Encounter, IEnumerable<Condition> Conditions)
	{
		var a_ = context.Operators;
		var e_ = Encounter?.Diagnosis;
		bool? f_(Encounter.DiagnosisComponent D)
		{
			var m_ = context.Operators;
			var o_ = m_.TypeConverter;
			var p_ = D?.RankElement;
			var q_ = o_.Convert<Integer>(p_);
			var r_ = FHIRHelpers_4_0_001.ToInteger(q_);
			var s_ = m_.Equal(r_, (int?)1);

			return s_;
		};
		var g_ = a_.WhereOrNull<Encounter.DiagnosisComponent>((e_ as IEnumerable<Encounter.DiagnosisComponent>), f_);
		var h_ = a_.SingleOrNull<Encounter.DiagnosisComponent>(g_);
		var i_ = new Encounter.DiagnosisComponent[]
		{
			h_,
		};
		bool? j_(Encounter.DiagnosisComponent PrincipalDiagnosis)
		{
			var t_ = context.Operators;
			bool? v_(Condition C)
			{
				var y_ = context.Operators;
				var z_ = context.Deeper(new CallStackEntry("ToString", null, null));
				var aa_ = z_.Operators;
				var ab_ = aa_.TypeConverter;
				var ac_ = C?.IdElement;
				var ad_ = ab_.Convert<string>(ac_);
				var af_ = z_.Operators;
				var ag_ = af_.TypeConverter;
				var ah_ = PrincipalDiagnosis?.Condition;
				var ai_ = ah_?.ReferenceElement;
				var aj_ = ag_.Convert<string>(ai_);
				var ak_ = NCQAFHIRBase_1_0_0.GetId(aj_);
				var al_ = y_.Equal(ad_, ak_);

				return al_;
			};
			var w_ = t_.WhereOrNull<Condition>(Conditions, v_);
			var x_ = t_.ExistsInList<Condition>(w_);

			return x_;
		};
		var k_ = a_.SelectOrNull<Encounter.DiagnosisComponent, bool?>(i_, j_);
		var l_ = a_.SingleOrNull<bool?>(k_);

		return l_;
	}

    [CqlDeclaration("Encounter Completed during Period")]
	public bool? Encounter_Completed_during_Period(IEnumerable<Encounter> Enc, CqlInterval<CqlDateTime> timeperiod)
	{
		var a_ = context.Operators;
		var c_ = NCQAStatus_1_0_0.Finished_Encounter(Enc);
		bool? d_(Encounter EncounterPeriod)
		{
			var g_ = context.Operators;
			var i_ = EncounterPeriod?.Period;
			var j_ = NCQAFHIRBase_1_0_0.Normalize_Interval(i_);
			var k_ = g_.End(j_);
			var l_ = g_.ElementInInterval<CqlDateTime>(k_, timeperiod, null);

			return l_;
		};
		var e_ = a_.WhereOrNull<Encounter>(c_, d_);
		var f_ = a_.ExistsInList<Encounter>(e_);

		return f_;
	}

    [CqlDeclaration("Finished Encounter with Telehealth POS")]
	public IEnumerable<Encounter> Finished_Encounter_with_Telehealth_POS(IEnumerable<Encounter> Encounter)
	{
		var a_ = context.Operators;
		var b_ = NCQAStatus_1_0_0.Finished_Encounter(Encounter);
		bool? c_(Encounter E)
		{
			var e_ = context.Operators;
			var g_ = E?.Class;
			var h_ = e_.Not((bool?)(g_ is null));
			var k_ = FHIRHelpers_4_0_001.ToCode(g_);
			var l_ = NCQATerminology_1_0_0.@virtual();
			var m_ = e_.Equivalent(k_, l_);
			var n_ = e_.And(h_, m_);

			return n_;
		};
		var d_ = a_.WhereOrNull<Encounter>(b_, c_);

		return d_;
	}

    [CqlDeclaration("Finished Encounter with Outpatient POS")]
	public IEnumerable<Encounter> Finished_Encounter_with_Outpatient_POS(IEnumerable<Encounter> Encounter)
	{
		var a_ = context.Operators;
		var b_ = NCQAStatus_1_0_0.Finished_Encounter(Encounter);
		bool? c_(Encounter E)
		{
			var e_ = context.Operators;
			var g_ = E?.Class;
			var h_ = e_.Not((bool?)(g_ is null));
			var l_ = FHIRHelpers_4_0_001.ToCode(g_);
			var m_ = NCQATerminology_1_0_0.ambulatory();
			var n_ = e_.Equivalent(l_, m_);
			var q_ = FHIRHelpers_4_0_001.ToCode(g_);
			var r_ = NCQATerminology_1_0_0.home_health();
			var s_ = e_.Equivalent(q_, r_);
			var t_ = e_.Or(n_, s_);
			var u_ = e_.And(h_, t_);

			return u_;
		};
		var d_ = a_.WhereOrNull<Encounter>(b_, c_);

		return d_;
	}

    [CqlDeclaration("Finished Encounter with Ambulatory POS")]
	public IEnumerable<Encounter> Finished_Encounter_with_Ambulatory_POS(IEnumerable<Encounter> Encounter)
	{
		var a_ = context.Operators;
		var b_ = NCQAStatus_1_0_0.Finished_Encounter(Encounter);
		bool? c_(Encounter E)
		{
			var e_ = context.Operators;
			var g_ = E?.Class;
			var h_ = e_.Not((bool?)(g_ is null));
			var k_ = FHIRHelpers_4_0_001.ToCode(g_);
			var l_ = NCQATerminology_1_0_0.ambulatory();
			var m_ = e_.Equivalent(k_, l_);
			var n_ = e_.And(h_, m_);

			return n_;
		};
		var d_ = a_.WhereOrNull<Encounter>(b_, c_);

		return d_;
	}

}