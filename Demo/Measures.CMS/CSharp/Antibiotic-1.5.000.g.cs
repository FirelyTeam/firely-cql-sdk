using System;
using Tuples;
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
[CqlLibrary("Antibiotic", "1.5.000")]
public class Antibiotic_1_5_000
{


    internal CqlContext context;

    #region Cached values

    internal Lazy<CqlInterval<CqlDateTime>> __Measurement_Period;
    internal Lazy<Patient> __Patient;

    #endregion
    public Antibiotic_1_5_000(CqlContext context)
    {
        this.context = context ?? throw new ArgumentNullException("context");

        FHIRHelpers_4_3_000 = new FHIRHelpers_4_3_000(context);
        QICoreCommon_2_0_000 = new QICoreCommon_2_0_000(context);

        __Measurement_Period = new Lazy<CqlInterval<CqlDateTime>>(this.Measurement_Period_Value);
        __Patient = new Lazy<Patient>(this.Patient_Value);
    }
    #region Dependencies

    public FHIRHelpers_4_3_000 FHIRHelpers_4_3_000 { get; }
    public QICoreCommon_2_0_000 QICoreCommon_2_0_000 { get; }

    #endregion

	private CqlInterval<CqlDateTime> Measurement_Period_Value()
	{
		var a_ = context.ResolveParameter("Antibiotic-1.5.000", "Measurement Period", null);

		return (CqlInterval<CqlDateTime>)a_;
	}

    [CqlDeclaration("Measurement Period")]
	public CqlInterval<CqlDateTime> Measurement_Period() => 
		__Measurement_Period.Value;

	private Patient Patient_Value()
	{
		var a_ = context.Operators.RetrieveByValueSet<Patient>(null, null);
		var b_ = context.Operators.SingletonFrom<Patient>(a_);

		return b_;
	}

    [CqlDeclaration("Patient")]
	public Patient Patient() => 
		__Patient.Value;

    [CqlDeclaration("Has Comorbid Condition History")]
	public IEnumerable<Encounter> Has_Comorbid_Condition_History(IEnumerable<Encounter> episodeDate, IEnumerable<Condition> comorbidConditions)
	{
		IEnumerable<Encounter> a_(Encounter eDate)
		{
			bool? e_(Condition comcondition)
			{
				var i_ = QICoreCommon_2_0_000.ToPrevalenceInterval(comcondition);
				var j_ = context.Operators.Start(i_);
				var k_ = context.Operators.DateFrom(j_);
				var l_ = eDate?.Period;
				var m_ = FHIRHelpers_4_3_000.ToInterval(l_);
				var n_ = QICoreCommon_2_0_000.ToInterval((m_ as object));
				var o_ = context.Operators.Start(n_);
				var p_ = context.Operators.DateFrom(o_);
				var q_ = context.Operators.Quantity(1m, "year");
				var r_ = context.Operators.Subtract(p_, q_);
				var t_ = FHIRHelpers_4_3_000.ToInterval(l_);
				var u_ = QICoreCommon_2_0_000.ToInterval((t_ as object));
				var v_ = context.Operators.Start(u_);
				var w_ = context.Operators.DateFrom(v_);
				var x_ = context.Operators.Interval(r_, w_, true, true);
				var y_ = context.Operators.In<CqlDate>(k_, x_, null);

				return y_;
			};
			var f_ = context.Operators.Where<Condition>(comorbidConditions, e_);
			Encounter g_(Condition comcondition) => 
				eDate;
			var h_ = context.Operators.Select<Condition, Encounter>(f_, g_);

			return h_;
		};
		var b_ = context.Operators.SelectMany<Encounter, Encounter>(episodeDate, a_);
		Encounter c_(Encounter eDate) => 
			eDate;
		var d_ = context.Operators.Select<Encounter, Encounter>(b_, c_);

		return d_;
	}

    [CqlDeclaration("Has Competing Diagnosis History")]
	public IEnumerable<Encounter> Has_Competing_Diagnosis_History(IEnumerable<Encounter> episodeDate, IEnumerable<Condition> competingConditions)
	{
		IEnumerable<Encounter> a_(Encounter eDate)
		{
			bool? e_(Condition competcondition)
			{
				var i_ = QICoreCommon_2_0_000.ToPrevalenceInterval(competcondition);
				var j_ = context.Operators.Start(i_);
				var k_ = eDate?.Period;
				var l_ = FHIRHelpers_4_3_000.ToInterval(k_);
				var m_ = context.Operators.Start(l_);
				var o_ = FHIRHelpers_4_3_000.ToInterval(k_);
				var p_ = context.Operators.Start(o_);
				var q_ = context.Operators.Quantity(3m, "days");
				var r_ = context.Operators.Add(p_, q_);
				var s_ = context.Operators.Interval(m_, r_, true, true);
				var t_ = context.Operators.In<CqlDateTime>(j_, s_, "day");
				var v_ = FHIRHelpers_4_3_000.ToInterval(k_);
				var w_ = context.Operators.Start(v_);
				var x_ = context.Operators.Not((bool?)(w_ is null));
				var y_ = context.Operators.And(t_, x_);

				return y_;
			};
			var f_ = context.Operators.Where<Condition>(competingConditions, e_);
			Encounter g_(Condition competcondition) => 
				eDate;
			var h_ = context.Operators.Select<Condition, Encounter>(f_, g_);

			return h_;
		};
		var b_ = context.Operators.SelectMany<Encounter, Encounter>(episodeDate, a_);
		Encounter c_(Encounter eDate) => 
			eDate;
		var d_ = context.Operators.Select<Encounter, Encounter>(b_, c_);

		return d_;
	}

    [CqlDeclaration("Has Antibiotic Medication History")]
	public IEnumerable<Encounter> Has_Antibiotic_Medication_History(IEnumerable<Encounter> episodeDate, IEnumerable<MedicationRequest> antibioticMedications)
	{
		IEnumerable<Encounter> a_(Encounter DateOfEpisode)
		{
			bool? c_(MedicationRequest ActiveMedication)
			{
				var g_ = ActiveMedication?.DosageInstruction;
				bool? h_(Dosage @this)
				{
					var o_ = @this?.Timing;
					var p_ = context.Operators.Not((bool?)(o_ is null));

					return p_;
				};
				var i_ = context.Operators.Where<Dosage>((IEnumerable<Dosage>)g_, h_);
				Timing j_(Dosage @this)
				{
					var q_ = @this?.Timing;

					return q_;
				};
				var k_ = context.Operators.Select<Dosage, Timing>(i_, j_);
				bool? l_(Timing T)
				{
					var r_ = T?.Repeat;
					var s_ = r_?.Bounds;
					var t_ = FHIRHelpers_4_3_000.ToValue(s_);
					var u_ = QICoreCommon_2_0_000.ToInterval(t_);
					var v_ = DateOfEpisode?.Period;
					var w_ = FHIRHelpers_4_3_000.ToInterval(v_);
					var x_ = QICoreCommon_2_0_000.ToInterval((w_ as object));
					var y_ = context.Operators.Start(x_);
					var z_ = context.Operators.DateFrom(y_);
					var aa_ = context.Operators.Quantity(30m, "days");
					var ab_ = context.Operators.Subtract(z_, aa_);
					var ad_ = FHIRHelpers_4_3_000.ToInterval(v_);
					var ae_ = QICoreCommon_2_0_000.ToInterval((ad_ as object));
					var af_ = context.Operators.Start(ae_);
					var ag_ = context.Operators.DateFrom(af_);
					var ah_ = context.Operators.Quantity(1m, "day");
					var ai_ = context.Operators.Subtract(ag_, ah_);
					var aj_ = context.Operators.Interval(ab_, ai_, true, true);
					var ak_ = aj_?.low;
					var al_ = context.Operators.ConvertDateToDateTime(ak_);
					var an_ = FHIRHelpers_4_3_000.ToInterval(v_);
					var ao_ = QICoreCommon_2_0_000.ToInterval((an_ as object));
					var ap_ = context.Operators.Start(ao_);
					var aq_ = context.Operators.DateFrom(ap_);
					var as_ = context.Operators.Subtract(aq_, aa_);
					var au_ = FHIRHelpers_4_3_000.ToInterval(v_);
					var av_ = QICoreCommon_2_0_000.ToInterval((au_ as object));
					var aw_ = context.Operators.Start(av_);
					var ax_ = context.Operators.DateFrom(aw_);
					var az_ = context.Operators.Subtract(ax_, ah_);
					var ba_ = context.Operators.Interval(as_, az_, true, true);
					var bb_ = ba_?.high;
					var bc_ = context.Operators.ConvertDateToDateTime(bb_);
					var be_ = FHIRHelpers_4_3_000.ToInterval(v_);
					var bf_ = QICoreCommon_2_0_000.ToInterval((be_ as object));
					var bg_ = context.Operators.Start(bf_);
					var bh_ = context.Operators.DateFrom(bg_);
					var bj_ = context.Operators.Subtract(bh_, aa_);
					var bl_ = FHIRHelpers_4_3_000.ToInterval(v_);
					var bm_ = QICoreCommon_2_0_000.ToInterval((bl_ as object));
					var bn_ = context.Operators.Start(bm_);
					var bo_ = context.Operators.DateFrom(bn_);
					var bq_ = context.Operators.Subtract(bo_, ah_);
					var br_ = context.Operators.Interval(bj_, bq_, true, true);
					var bs_ = br_?.lowClosed;
					var bu_ = FHIRHelpers_4_3_000.ToInterval(v_);
					var bv_ = QICoreCommon_2_0_000.ToInterval((bu_ as object));
					var bw_ = context.Operators.Start(bv_);
					var bx_ = context.Operators.DateFrom(bw_);
					var bz_ = context.Operators.Subtract(bx_, aa_);
					var cb_ = FHIRHelpers_4_3_000.ToInterval(v_);
					var cc_ = QICoreCommon_2_0_000.ToInterval((cb_ as object));
					var cd_ = context.Operators.Start(cc_);
					var ce_ = context.Operators.DateFrom(cd_);
					var cg_ = context.Operators.Subtract(ce_, ah_);
					var ch_ = context.Operators.Interval(bz_, cg_, true, true);
					var ci_ = ch_?.highClosed;
					var cj_ = context.Operators.Interval(al_, bc_, bs_, ci_);
					var ck_ = context.Operators.Overlaps(u_, cj_, "day");

					return ck_;
				};
				var m_ = context.Operators.Where<Timing>(k_, l_);
				var n_ = context.Operators.Exists<Timing>(m_);

				return n_;
			};
			var d_ = context.Operators.Where<MedicationRequest>(antibioticMedications, c_);
			Encounter e_(MedicationRequest ActiveMedication) => 
				DateOfEpisode;
			var f_ = context.Operators.Select<MedicationRequest, Encounter>(d_, e_);

			return f_;
		};
		var b_ = context.Operators.SelectMany<Encounter, Encounter>(episodeDate, a_);

		return b_;
	}

}
