using System;
using System.Linq;
using System.Collections.Generic;
using Hl7.Cql.Runtime;
using Hl7.Cql.Primitives;
using Hl7.Cql.Abstractions;
using Hl7.Cql.ValueSets;
using Hl7.Cql.Iso8601;
using System.Reflection;
using Hl7.Cql.Operators;
using Hl7.Fhir.Model;
using Range = Hl7.Fhir.Model.Range;
using Task = Hl7.Fhir.Model.Task;
[System.CodeDom.Compiler.GeneratedCode(".NET Code Generation", "2.0.4.0")]
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
		object a_ = context.ResolveParameter("Antibiotic-1.5.000", "Measurement Period", null);

		return (CqlInterval<CqlDateTime>)a_;
	}

    [CqlDeclaration("Measurement Period")]
	public CqlInterval<CqlDateTime> Measurement_Period() => 
		__Measurement_Period.Value;

	private Patient Patient_Value()
	{
		IEnumerable<Patient> a_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-patient"));
		Patient b_ = context.Operators.SingletonFrom<Patient>(a_);

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
				CqlInterval<CqlDateTime> i_ = QICoreCommon_2_0_000.ToPrevalenceInterval(comcondition);
				CqlDateTime j_ = context.Operators.Start(i_);
				CqlDate k_ = context.Operators.DateFrom(j_);
				Period l_ = eDate?.Period;
				CqlInterval<CqlDateTime> m_ = FHIRHelpers_4_3_000.ToInterval(l_);
				CqlInterval<CqlDateTime> n_ = QICoreCommon_2_0_000.ToInterval(m_ as object);
				CqlDateTime o_ = context.Operators.Start(n_);
				CqlDate p_ = context.Operators.DateFrom(o_);
				CqlQuantity q_ = context.Operators.Quantity(1m, "year");
				CqlDate r_ = context.Operators.Subtract(p_, q_);
				CqlInterval<CqlDateTime> t_ = FHIRHelpers_4_3_000.ToInterval(l_);
				CqlInterval<CqlDateTime> u_ = QICoreCommon_2_0_000.ToInterval(t_ as object);
				CqlDateTime v_ = context.Operators.Start(u_);
				CqlDate w_ = context.Operators.DateFrom(v_);
				CqlInterval<CqlDate> x_ = context.Operators.Interval(r_, w_, true, true);
				bool? y_ = context.Operators.In<CqlDate>(k_, x_, default);

				return y_;
			};
			IEnumerable<Condition> f_ = context.Operators.Where<Condition>(comorbidConditions, e_);
			Encounter g_(Condition comcondition) => 
				eDate;
			IEnumerable<Encounter> h_ = context.Operators.Select<Condition, Encounter>(f_, g_);

			return h_;
		};
		IEnumerable<Encounter> b_ = context.Operators.SelectMany<Encounter, Encounter>(episodeDate, a_);
		Encounter c_(Encounter eDate) => 
			eDate;
		IEnumerable<Encounter> d_ = context.Operators.Select<Encounter, Encounter>(b_, c_);

		return d_;
	}

    [CqlDeclaration("Has Competing Diagnosis History")]
	public IEnumerable<Encounter> Has_Competing_Diagnosis_History(IEnumerable<Encounter> episodeDate, IEnumerable<Condition> competingConditions)
	{
		IEnumerable<Encounter> a_(Encounter eDate)
		{
			bool? e_(Condition competcondition)
			{
				CqlInterval<CqlDateTime> i_ = QICoreCommon_2_0_000.ToPrevalenceInterval(competcondition);
				CqlDateTime j_ = context.Operators.Start(i_);
				Period k_ = eDate?.Period;
				CqlInterval<CqlDateTime> l_ = FHIRHelpers_4_3_000.ToInterval(k_);
				CqlDateTime m_ = context.Operators.Start(l_);
				CqlInterval<CqlDateTime> o_ = FHIRHelpers_4_3_000.ToInterval(k_);
				CqlDateTime p_ = context.Operators.Start(o_);
				CqlQuantity q_ = context.Operators.Quantity(3m, "days");
				CqlDateTime r_ = context.Operators.Add(p_, q_);
				CqlInterval<CqlDateTime> s_ = context.Operators.Interval(m_, r_, true, true);
				bool? t_ = context.Operators.In<CqlDateTime>(j_, s_, "day");
				CqlInterval<CqlDateTime> v_ = FHIRHelpers_4_3_000.ToInterval(k_);
				CqlDateTime w_ = context.Operators.Start(v_);
				bool? x_ = context.Operators.Not((bool?)(w_ is null));
				bool? y_ = context.Operators.And(t_, x_);

				return y_;
			};
			IEnumerable<Condition> f_ = context.Operators.Where<Condition>(competingConditions, e_);
			Encounter g_(Condition competcondition) => 
				eDate;
			IEnumerable<Encounter> h_ = context.Operators.Select<Condition, Encounter>(f_, g_);

			return h_;
		};
		IEnumerable<Encounter> b_ = context.Operators.SelectMany<Encounter, Encounter>(episodeDate, a_);
		Encounter c_(Encounter eDate) => 
			eDate;
		IEnumerable<Encounter> d_ = context.Operators.Select<Encounter, Encounter>(b_, c_);

		return d_;
	}

    [CqlDeclaration("Has Antibiotic Medication History")]
	public IEnumerable<Encounter> Has_Antibiotic_Medication_History(IEnumerable<Encounter> episodeDate, IEnumerable<MedicationRequest> antibioticMedications)
	{
		IEnumerable<Encounter> a_(Encounter DateOfEpisode)
		{
			bool? c_(MedicationRequest ActiveMedication)
			{
				List<Dosage> g_ = ActiveMedication?.DosageInstruction;
				bool? h_(Dosage @this)
				{
					Timing o_ = @this?.Timing;
					bool? p_ = context.Operators.Not((bool?)(o_ is null));

					return p_;
				};
				IEnumerable<Dosage> i_ = context.Operators.Where<Dosage>((IEnumerable<Dosage>)g_, h_);
				Timing j_(Dosage @this)
				{
					Timing q_ = @this?.Timing;

					return q_;
				};
				IEnumerable<Timing> k_ = context.Operators.Select<Dosage, Timing>(i_, j_);
				bool? l_(Timing T)
				{
					Timing.RepeatComponent r_ = T?.Repeat;
					DataType s_ = r_?.Bounds;
					object t_ = FHIRHelpers_4_3_000.ToValue(s_);
					CqlInterval<CqlDateTime> u_ = QICoreCommon_2_0_000.ToInterval(t_);
					Period v_ = DateOfEpisode?.Period;
					CqlInterval<CqlDateTime> w_ = FHIRHelpers_4_3_000.ToInterval(v_);
					CqlInterval<CqlDateTime> x_ = QICoreCommon_2_0_000.ToInterval(w_ as object);
					CqlDateTime y_ = context.Operators.Start(x_);
					CqlDate z_ = context.Operators.DateFrom(y_);
					CqlQuantity aa_ = context.Operators.Quantity(30m, "days");
					CqlDate ab_ = context.Operators.Subtract(z_, aa_);
					CqlInterval<CqlDateTime> ad_ = FHIRHelpers_4_3_000.ToInterval(v_);
					CqlInterval<CqlDateTime> ae_ = QICoreCommon_2_0_000.ToInterval(ad_ as object);
					CqlDateTime af_ = context.Operators.Start(ae_);
					CqlDate ag_ = context.Operators.DateFrom(af_);
					CqlQuantity ah_ = context.Operators.Quantity(1m, "day");
					CqlDate ai_ = context.Operators.Subtract(ag_, ah_);
					CqlInterval<CqlDate> aj_ = context.Operators.Interval(ab_, ai_, true, true);
					CqlDate ak_ = aj_?.low;
					CqlDateTime al_ = context.Operators.ConvertDateToDateTime(ak_);
					CqlInterval<CqlDateTime> an_ = FHIRHelpers_4_3_000.ToInterval(v_);
					CqlInterval<CqlDateTime> ao_ = QICoreCommon_2_0_000.ToInterval(an_ as object);
					CqlDateTime ap_ = context.Operators.Start(ao_);
					CqlDate aq_ = context.Operators.DateFrom(ap_);
					CqlDate as_ = context.Operators.Subtract(aq_, aa_);
					CqlInterval<CqlDateTime> au_ = FHIRHelpers_4_3_000.ToInterval(v_);
					CqlInterval<CqlDateTime> av_ = QICoreCommon_2_0_000.ToInterval(au_ as object);
					CqlDateTime aw_ = context.Operators.Start(av_);
					CqlDate ax_ = context.Operators.DateFrom(aw_);
					CqlDate az_ = context.Operators.Subtract(ax_, ah_);
					CqlInterval<CqlDate> ba_ = context.Operators.Interval(as_, az_, true, true);
					CqlDate bb_ = ba_?.high;
					CqlDateTime bc_ = context.Operators.ConvertDateToDateTime(bb_);
					CqlInterval<CqlDateTime> be_ = FHIRHelpers_4_3_000.ToInterval(v_);
					CqlInterval<CqlDateTime> bf_ = QICoreCommon_2_0_000.ToInterval(be_ as object);
					CqlDateTime bg_ = context.Operators.Start(bf_);
					CqlDate bh_ = context.Operators.DateFrom(bg_);
					CqlDate bj_ = context.Operators.Subtract(bh_, aa_);
					CqlInterval<CqlDateTime> bl_ = FHIRHelpers_4_3_000.ToInterval(v_);
					CqlInterval<CqlDateTime> bm_ = QICoreCommon_2_0_000.ToInterval(bl_ as object);
					CqlDateTime bn_ = context.Operators.Start(bm_);
					CqlDate bo_ = context.Operators.DateFrom(bn_);
					CqlDate bq_ = context.Operators.Subtract(bo_, ah_);
					CqlInterval<CqlDate> br_ = context.Operators.Interval(bj_, bq_, true, true);
					bool? bs_ = br_?.lowClosed;
					CqlInterval<CqlDateTime> bu_ = FHIRHelpers_4_3_000.ToInterval(v_);
					CqlInterval<CqlDateTime> bv_ = QICoreCommon_2_0_000.ToInterval(bu_ as object);
					CqlDateTime bw_ = context.Operators.Start(bv_);
					CqlDate bx_ = context.Operators.DateFrom(bw_);
					CqlDate bz_ = context.Operators.Subtract(bx_, aa_);
					CqlInterval<CqlDateTime> cb_ = FHIRHelpers_4_3_000.ToInterval(v_);
					CqlInterval<CqlDateTime> cc_ = QICoreCommon_2_0_000.ToInterval(cb_ as object);
					CqlDateTime cd_ = context.Operators.Start(cc_);
					CqlDate ce_ = context.Operators.DateFrom(cd_);
					CqlDate cg_ = context.Operators.Subtract(ce_, ah_);
					CqlInterval<CqlDate> ch_ = context.Operators.Interval(bz_, cg_, true, true);
					bool? ci_ = ch_?.highClosed;
					CqlInterval<CqlDateTime> cj_ = context.Operators.Interval(al_, bc_, bs_, ci_);
					bool? ck_ = context.Operators.Overlaps(u_, cj_, "day");

					return ck_;
				};
				IEnumerable<Timing> m_ = context.Operators.Where<Timing>(k_, l_);
				bool? n_ = context.Operators.Exists<Timing>(m_);

				return n_;
			};
			IEnumerable<MedicationRequest> d_ = context.Operators.Where<MedicationRequest>(antibioticMedications, c_);
			Encounter e_(MedicationRequest ActiveMedication) => 
				DateOfEpisode;
			IEnumerable<Encounter> f_ = context.Operators.Select<MedicationRequest, Encounter>(d_, e_);

			return f_;
		};
		IEnumerable<Encounter> b_ = context.Operators.SelectMany<Encounter, Encounter>(episodeDate, a_);

		return b_;
	}

}
