using System;
using Tuples;
using System.Linq;
using System.Collections.Generic;
using Hl7.Cql.Runtime;
using Hl7.Cql.Primitives;
using Hl7.Cql.Abstractions;
using Hl7.Cql.ValueSets;
using Hl7.Cql.Iso8601;
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
				var l_ = FHIRHelpers_4_3_000.ToInterval(eDate?.Period);
				var m_ = QICoreCommon_2_0_000.ToInterval((l_ as object));
				var n_ = context.Operators.Start(m_);
				var o_ = context.Operators.DateFrom(n_);
				var p_ = context.Operators.Quantity(1m, "year");
				var q_ = context.Operators.Subtract(o_, p_);
				var s_ = QICoreCommon_2_0_000.ToInterval((l_ as object));
				var t_ = context.Operators.Start(s_);
				var u_ = context.Operators.DateFrom(t_);
				var v_ = context.Operators.Interval(q_, u_, true, true);
				var w_ = context.Operators.In<CqlDate>(k_, v_, null);

				return w_;
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
				var k_ = FHIRHelpers_4_3_000.ToInterval(eDate?.Period);
				var l_ = context.Operators.Start(k_);
				var n_ = context.Operators.Start(k_);
				var o_ = context.Operators.Quantity(3m, "days");
				var p_ = context.Operators.Add(n_, o_);
				var q_ = context.Operators.Interval(l_, p_, true, true);
				var r_ = context.Operators.In<CqlDateTime>(j_, q_, "day");
				var t_ = context.Operators.Start(k_);
				var u_ = context.Operators.Not((bool?)(t_ is null));
				var v_ = context.Operators.And(r_, u_);

				return v_;
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
				bool? g_(Dosage @this)
				{
					var n_ = context.Operators.Not((bool?)(@this?.Timing is null));

					return n_;
				};
				var h_ = context.Operators.Where<Dosage>(ActiveMedication?.DosageInstruction, g_);
				Timing i_(Dosage @this) => 
					@this?.Timing;
				var j_ = context.Operators.Select<Dosage, Timing>(h_, i_);
				bool? k_(Timing T)
				{
					var o_ = FHIRHelpers_4_3_000.ToValue(T?.Repeat?.Bounds);
					var p_ = QICoreCommon_2_0_000.ToInterval(o_);
					var q_ = FHIRHelpers_4_3_000.ToInterval(DateOfEpisode?.Period);
					var r_ = QICoreCommon_2_0_000.ToInterval((q_ as object));
					var s_ = context.Operators.Start(r_);
					var t_ = context.Operators.DateFrom(s_);
					var u_ = context.Operators.Quantity(30m, "days");
					var v_ = context.Operators.Subtract(t_, u_);
					var x_ = QICoreCommon_2_0_000.ToInterval((q_ as object));
					var y_ = context.Operators.Start(x_);
					var z_ = context.Operators.DateFrom(y_);
					var aa_ = context.Operators.Quantity(1m, "day");
					var ab_ = context.Operators.Subtract(z_, aa_);
					var ac_ = context.Operators.Interval(v_, ab_, true, true);
					var ad_ = context.Operators.ConvertDateToDateTime(ac_?.low);
					var af_ = QICoreCommon_2_0_000.ToInterval((q_ as object));
					var ag_ = context.Operators.Start(af_);
					var ah_ = context.Operators.DateFrom(ag_);
					var aj_ = context.Operators.Subtract(ah_, u_);
					var al_ = QICoreCommon_2_0_000.ToInterval((q_ as object));
					var am_ = context.Operators.Start(al_);
					var an_ = context.Operators.DateFrom(am_);
					var ap_ = context.Operators.Subtract(an_, aa_);
					var aq_ = context.Operators.Interval(aj_, ap_, true, true);
					var ar_ = context.Operators.ConvertDateToDateTime(aq_?.high);
					var at_ = QICoreCommon_2_0_000.ToInterval((q_ as object));
					var au_ = context.Operators.Start(at_);
					var av_ = context.Operators.DateFrom(au_);
					var ax_ = context.Operators.Subtract(av_, u_);
					var az_ = QICoreCommon_2_0_000.ToInterval((q_ as object));
					var ba_ = context.Operators.Start(az_);
					var bb_ = context.Operators.DateFrom(ba_);
					var bd_ = context.Operators.Subtract(bb_, aa_);
					var be_ = context.Operators.Interval(ax_, bd_, true, true);
					var bg_ = QICoreCommon_2_0_000.ToInterval((q_ as object));
					var bh_ = context.Operators.Start(bg_);
					var bi_ = context.Operators.DateFrom(bh_);
					var bk_ = context.Operators.Subtract(bi_, u_);
					var bm_ = QICoreCommon_2_0_000.ToInterval((q_ as object));
					var bn_ = context.Operators.Start(bm_);
					var bo_ = context.Operators.DateFrom(bn_);
					var bq_ = context.Operators.Subtract(bo_, aa_);
					var br_ = context.Operators.Interval(bk_, bq_, true, true);
					var bs_ = context.Operators.Interval(ad_, ar_, be_?.lowClosed, br_?.highClosed);
					var bt_ = context.Operators.Overlaps(p_, bs_, "day");

					return bt_;
				};
				var l_ = context.Operators.Where<Timing>(j_, k_);
				var m_ = context.Operators.Exists<Timing>(l_);

				return m_;
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
