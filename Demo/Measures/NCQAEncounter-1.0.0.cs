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
		var a_ = Encounter.Diagnosis;
		FhirString b_(Encounter.DiagnosisComponent D)
		{
			var j_ = D.Condition;
			var k_ = j_.ReferenceElement;

			return k_;
		};
		var c_ = context.Operators;
		var d_ = c_.SelectOrNull<Encounter.DiagnosisComponent, FhirString>((a_ as IEnumerable<Encounter.DiagnosisComponent>), b_);
		bool? e_(FhirString CRef)
		{
			bool? l_(Condition C)
			{
				var q_ = C.IdElement;
				var r_ = new CallStackEntry("ToString", null, null);
				var s_ = context.Deeper(r_);
				var t_ = s_.Operators;
				var u_ = t_.TypeConverter;
				var v_ = u_.Convert<string>(q_);
				var x_ = context.Deeper(r_);
				var y_ = x_.Operators;
				var z_ = y_.TypeConverter;
				var aa_ = z_.Convert<string>(CRef);
				var ab_ = NCQAFHIRBase_1_0_0.GetId(aa_);
				var ac_ = context.Operators;
				var ad_ = ac_.Equal(v_, ab_);

				return ad_;
			};
			var m_ = context.Operators;
			var n_ = m_.WhereOrNull<Condition>(Conditions, l_);
			var p_ = m_.ExistsInList<Condition>(n_);

			return p_;
		};
		var g_ = c_.SelectOrNull<FhirString, bool?>(d_, e_);
		var i_ = c_.AnyTrue(g_);

		return i_;
	}


    [CqlDeclaration("Encounter Has Principal Diagnosis")]
    public bool? Encounter_Has_Principal_Diagnosis(Encounter Encounter, IEnumerable<Condition> Conditions)
	{
		var a_ = Encounter.Diagnosis;
		bool? b_(Encounter.DiagnosisComponent D)
		{
			var m_ = D.RankElement;
			var n_ = context.Operators;
			var o_ = n_.TypeConverter;
			var p_ = o_.Convert<Integer>(m_);
			var q_ = FHIRHelpers_4_0_001.ToInteger(p_);
			var s_ = n_.Equal(q_, (int?)1);

			return s_;
		};
		var c_ = context.Operators;
		var d_ = c_.WhereOrNull<Encounter.DiagnosisComponent>((a_ as IEnumerable<Encounter.DiagnosisComponent>), b_);
		var f_ = c_.SingleOrNull<Encounter.DiagnosisComponent>(d_);
		var g_ = new Encounter.DiagnosisComponent[]
		{
			f_,
		};
		bool? h_(Encounter.DiagnosisComponent PrincipalDiagnosis)
		{
			bool? t_(Condition C)
			{
				var y_ = C.IdElement;
				var z_ = new CallStackEntry("ToString", null, null);
				var aa_ = context.Deeper(z_);
				var ab_ = aa_.Operators;
				var ac_ = ab_.TypeConverter;
				var ad_ = ac_.Convert<string>(y_);
				var ae_ = PrincipalDiagnosis.Condition;
				var af_ = ae_.ReferenceElement;
				var ah_ = context.Deeper(z_);
				var ai_ = ah_.Operators;
				var aj_ = ai_.TypeConverter;
				var ak_ = aj_.Convert<string>(af_);
				var al_ = NCQAFHIRBase_1_0_0.GetId(ak_);
				var am_ = context.Operators;
				var an_ = am_.Equal(ad_, al_);

				return an_;
			};
			var u_ = context.Operators;
			var v_ = u_.WhereOrNull<Condition>(Conditions, t_);
			var x_ = u_.ExistsInList<Condition>(v_);

			return x_;
		};
		var j_ = c_.SelectOrNull<Encounter.DiagnosisComponent, bool?>(g_, h_);
		var l_ = c_.SingleOrNull<bool?>(j_);

		return l_;
	}


    [CqlDeclaration("Encounter Completed during Period")]
    public bool? Encounter_Completed_during_Period(IEnumerable<Encounter> Enc, CqlInterval<CqlDateTime> timeperiod)
	{
		var a_ = NCQAStatus_1_0_0.Finished_Encounter(Enc);
		bool? b_(Encounter EncounterPeriod)
		{
			var g_ = EncounterPeriod.Period;
			var h_ = NCQAFHIRBase_1_0_0.Normalize_Interval(g_);
			var i_ = context.Operators;
			var j_ = i_.End(h_);
			var l_ = i_.ElementInInterval<CqlDateTime>(j_, timeperiod, null);

			return l_;
		};
		var c_ = context.Operators;
		var d_ = c_.WhereOrNull<Encounter>(a_, b_);
		var f_ = c_.ExistsInList<Encounter>(d_);

		return f_;
	}


    [CqlDeclaration("Finished Encounter with Telehealth POS")]
    public IEnumerable<Encounter> Finished_Encounter_with_Telehealth_POS(IEnumerable<Encounter> Encounter)
	{
		var a_ = NCQAStatus_1_0_0.Finished_Encounter(Encounter);
		bool? b_(Encounter E)
		{
			var e_ = E.Class;
			var f_ = (e_ == null);
			var g_ = context.Operators;
			var h_ = g_.Not((bool?)f_);
			var j_ = FHIRHelpers_4_0_001.ToCode(e_);
			var k_ = NCQATerminology_1_0_0.@virtual();
			var m_ = g_.Equivalent(j_, k_);
			var o_ = g_.And(h_, m_);

			return o_;
		};
		var c_ = context.Operators;
		var d_ = c_.WhereOrNull<Encounter>(a_, b_);

		return d_;
	}


    [CqlDeclaration("Finished Encounter with Outpatient POS")]
    public IEnumerable<Encounter> Finished_Encounter_with_Outpatient_POS(IEnumerable<Encounter> Encounter)
	{
		var a_ = NCQAStatus_1_0_0.Finished_Encounter(Encounter);
		bool? b_(Encounter E)
		{
			var e_ = E.Class;
			var f_ = (e_ == null);
			var g_ = context.Operators;
			var h_ = g_.Not((bool?)f_);
			var j_ = FHIRHelpers_4_0_001.ToCode(e_);
			var k_ = NCQATerminology_1_0_0.ambulatory();
			var m_ = g_.Equivalent(j_, k_);
			var o_ = FHIRHelpers_4_0_001.ToCode(e_);
			var p_ = NCQATerminology_1_0_0.home_health();
			var r_ = g_.Equivalent(o_, p_);
			var t_ = g_.Or(m_, r_);
			var v_ = g_.And(h_, t_);

			return v_;
		};
		var c_ = context.Operators;
		var d_ = c_.WhereOrNull<Encounter>(a_, b_);

		return d_;
	}


    [CqlDeclaration("Finished Encounter with Ambulatory POS")]
    public IEnumerable<Encounter> Finished_Encounter_with_Ambulatory_POS(IEnumerable<Encounter> Encounter)
	{
		var a_ = NCQAStatus_1_0_0.Finished_Encounter(Encounter);
		bool? b_(Encounter E)
		{
			var e_ = E.Class;
			var f_ = (e_ == null);
			var g_ = context.Operators;
			var h_ = g_.Not((bool?)f_);
			var j_ = FHIRHelpers_4_0_001.ToCode(e_);
			var k_ = NCQATerminology_1_0_0.ambulatory();
			var m_ = g_.Equivalent(j_, k_);
			var o_ = g_.And(h_, m_);

			return o_;
		};
		var c_ = context.Operators;
		var d_ = c_.WhereOrNull<Encounter>(a_, b_);

		return d_;
	}


}