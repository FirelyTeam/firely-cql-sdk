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
		var b_ = (a_ as IEnumerable<Encounter.DiagnosisComponent>);
		var c_ = (Encounter.DiagnosisComponent D) =>
		{
			var k_ = D.Condition;
			var l_ = k_.ReferenceElement;

			return l_;
		};
		var d_ = context.Operators;
		var e_ = d_.SelectOrNull<Encounter.DiagnosisComponent, FhirString>(b_, c_);
		var f_ = (FhirString CRef) =>
		{
			var m_ = (Condition C) =>
			{
				var r_ = C.IdElement;
				var s_ = new CallStackEntry("ToString", null, null);
				var t_ = context.Deeper(s_);
				var u_ = t_.Operators;
				var v_ = u_.TypeConverter;
				var w_ = v_.Convert<string>(r_);
				var y_ = context.Deeper(s_);
				var z_ = y_.Operators;
				var aa_ = z_.TypeConverter;
				var ab_ = aa_.Convert<string>(CRef);
				var ac_ = NCQAFHIRBase_1_0_0.GetId(ab_);
				var ad_ = context.Operators;
				var ae_ = ad_.Equal(w_, ac_);

				return ae_;
			};
			var n_ = context.Operators;
			var o_ = n_.WhereOrNull<Condition>(Conditions, m_);
			var q_ = n_.ExistsInList<Condition>(o_);

			return q_;
		};
		var h_ = d_.SelectOrNull<FhirString, bool?>(e_, f_);
		var j_ = d_.AnyTrue(h_);

		return j_;
	}


    [CqlDeclaration("Encounter Has Principal Diagnosis")]
    public bool? Encounter_Has_Principal_Diagnosis(Encounter Encounter, IEnumerable<Condition> Conditions)
	{
		var a_ = Encounter.Diagnosis;
		var b_ = (a_ as IEnumerable<Encounter.DiagnosisComponent>);
		var c_ = (Encounter.DiagnosisComponent D) =>
		{
			var n_ = D.RankElement;
			var o_ = context.Operators;
			var p_ = o_.TypeConverter;
			var q_ = p_.Convert<Integer>(n_);
			var r_ = FHIRHelpers_4_0_001.ToInteger(q_);
			var s_ = r_;
			var t_ = (int?)1;
			var u_ = t_;
			var w_ = o_.Equal(s_, u_);

			return w_;
		};
		var d_ = context.Operators;
		var e_ = d_.WhereOrNull<Encounter.DiagnosisComponent>(b_, c_);
		var g_ = d_.SingleOrNull<Encounter.DiagnosisComponent>(e_);
		var h_ = new Encounter.DiagnosisComponent[]
		{
			g_,
		};
		var i_ = (Encounter.DiagnosisComponent PrincipalDiagnosis) =>
		{
			var x_ = (Condition C) =>
			{
				var ac_ = C.IdElement;
				var ad_ = new CallStackEntry("ToString", null, null);
				var ae_ = context.Deeper(ad_);
				var af_ = ae_.Operators;
				var ag_ = af_.TypeConverter;
				var ah_ = ag_.Convert<string>(ac_);
				var ai_ = PrincipalDiagnosis.Condition;
				var aj_ = ai_.ReferenceElement;
				var al_ = context.Deeper(ad_);
				var am_ = al_.Operators;
				var an_ = am_.TypeConverter;
				var ao_ = an_.Convert<string>(aj_);
				var ap_ = NCQAFHIRBase_1_0_0.GetId(ao_);
				var aq_ = context.Operators;
				var ar_ = aq_.Equal(ah_, ap_);

				return ar_;
			};
			var y_ = context.Operators;
			var z_ = y_.WhereOrNull<Condition>(Conditions, x_);
			var ab_ = y_.ExistsInList<Condition>(z_);

			return ab_;
		};
		var k_ = d_.SelectOrNull<Encounter.DiagnosisComponent, bool?>(h_, i_);
		var m_ = d_.SingleOrNull<bool?>(k_);

		return m_;
	}


    [CqlDeclaration("Encounter Completed during Period")]
    public bool? Encounter_Completed_during_Period(IEnumerable<Encounter> Enc, CqlInterval<CqlDateTime> timeperiod)
	{
		var a_ = NCQAStatus_1_0_0.Finished_Encounter(Enc);
		var b_ = (Encounter EncounterPeriod) =>
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
		var b_ = (Encounter E) =>
		{
			var e_ = E.Class;
			var f_ = (e_ == null);
			var g_ = (bool?)f_;
			var h_ = context.Operators;
			var i_ = h_.Not(g_);
			var k_ = FHIRHelpers_4_0_001.ToCode(e_);
			var l_ = NCQATerminology_1_0_0.@virtual();
			var n_ = h_.Equivalent(k_, l_);
			var p_ = h_.And(i_, n_);

			return p_;
		};
		var c_ = context.Operators;
		var d_ = c_.WhereOrNull<Encounter>(a_, b_);

		return d_;
	}


    [CqlDeclaration("Finished Encounter with Outpatient POS")]
    public IEnumerable<Encounter> Finished_Encounter_with_Outpatient_POS(IEnumerable<Encounter> Encounter)
	{
		var a_ = NCQAStatus_1_0_0.Finished_Encounter(Encounter);
		var b_ = (Encounter E) =>
		{
			var e_ = E.Class;
			var f_ = (e_ == null);
			var g_ = (bool?)f_;
			var h_ = context.Operators;
			var i_ = h_.Not(g_);
			var k_ = FHIRHelpers_4_0_001.ToCode(e_);
			var l_ = NCQATerminology_1_0_0.ambulatory();
			var n_ = h_.Equivalent(k_, l_);
			var p_ = FHIRHelpers_4_0_001.ToCode(e_);
			var q_ = NCQATerminology_1_0_0.home_health();
			var s_ = h_.Equivalent(p_, q_);
			var u_ = h_.Or(n_, s_);
			var w_ = h_.And(i_, u_);

			return w_;
		};
		var c_ = context.Operators;
		var d_ = c_.WhereOrNull<Encounter>(a_, b_);

		return d_;
	}


    [CqlDeclaration("Finished Encounter with Ambulatory POS")]
    public IEnumerable<Encounter> Finished_Encounter_with_Ambulatory_POS(IEnumerable<Encounter> Encounter)
	{
		var a_ = NCQAStatus_1_0_0.Finished_Encounter(Encounter);
		var b_ = (Encounter E) =>
		{
			var e_ = E.Class;
			var f_ = (e_ == null);
			var g_ = (bool?)f_;
			var h_ = context.Operators;
			var i_ = h_.Not(g_);
			var k_ = FHIRHelpers_4_0_001.ToCode(e_);
			var l_ = NCQATerminology_1_0_0.ambulatory();
			var n_ = h_.Equivalent(k_, l_);
			var p_ = h_.And(i_, n_);

			return p_;
		};
		var c_ = context.Operators;
		var d_ = c_.WhereOrNull<Encounter>(a_, b_);

		return d_;
	}


}