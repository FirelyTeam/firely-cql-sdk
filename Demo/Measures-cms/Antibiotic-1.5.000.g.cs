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
		object a_ = context.ResolveParameter("Antibiotic-1.5.000", "Measurement Period", null);

		return (CqlInterval<CqlDateTime>)a_;
	}

    [CqlDeclaration("Measurement Period")]
	public CqlInterval<CqlDateTime> Measurement_Period() => 
		__Measurement_Period.Value;

	private Patient Patient_Value()
	{
		IEnumerable<Patient> a_ = context.Operators.RetrieveByValueSet<Patient>(null, null);
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
				CqlInterval<CqlDateTime> l_ = FHIRHelpers_4_3_000.ToInterval(eDate?.Period);
				CqlInterval<CqlDateTime> m_ = QICoreCommon_2_0_000.ToInterval((l_ as object));
				CqlDateTime n_ = context.Operators.Start(m_);
				CqlDate o_ = context.Operators.DateFrom(n_);
				CqlQuantity p_ = context.Operators.Quantity(1m, "year");
				CqlDate q_ = context.Operators.Subtract(o_, p_);
				CqlInterval<CqlDateTime> s_ = QICoreCommon_2_0_000.ToInterval((l_ as object));
				CqlDateTime t_ = context.Operators.Start(s_);
				CqlDate u_ = context.Operators.DateFrom(t_);
				CqlInterval<CqlDate> v_ = context.Operators.Interval(q_, u_, true, true);
				bool? w_ = context.Operators.In<CqlDate>(k_, v_, null);

				return w_;
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
				CqlInterval<CqlDateTime> k_ = FHIRHelpers_4_3_000.ToInterval(eDate?.Period);
				CqlDateTime l_ = context.Operators.Start(k_);
				CqlDateTime n_ = context.Operators.Start(k_);
				CqlQuantity o_ = context.Operators.Quantity(3m, "days");
				CqlDateTime p_ = context.Operators.Add(n_, o_);
				CqlInterval<CqlDateTime> q_ = context.Operators.Interval(l_, p_, true, true);
				bool? r_ = context.Operators.In<CqlDateTime>(j_, q_, "day");
				CqlDateTime t_ = context.Operators.Start(k_);
				bool? u_ = context.Operators.Not((bool?)(t_ is null));
				bool? v_ = context.Operators.And(r_, u_);

				return v_;
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
				bool? g_(Dosage @this)
				{
					bool? n_ = context.Operators.Not((bool?)(@this?.Timing is null));

					return n_;
				};
				IEnumerable<Dosage> h_ = context.Operators.Where<Dosage>(ActiveMedication?.DosageInstruction, g_);
				Timing i_(Dosage @this) => 
					@this?.Timing;
				IEnumerable<Timing> j_ = context.Operators.Select<Dosage, Timing>(h_, i_);
				bool? k_(Timing T)
				{
					object o_ = FHIRHelpers_4_3_000.ToValue(T?.Repeat?.Bounds);
					CqlInterval<CqlDateTime> p_ = QICoreCommon_2_0_000.ToInterval(o_);
					CqlInterval<CqlDateTime> q_ = FHIRHelpers_4_3_000.ToInterval(DateOfEpisode?.Period);
					CqlInterval<CqlDateTime> r_ = QICoreCommon_2_0_000.ToInterval((q_ as object));
					CqlDateTime s_ = context.Operators.Start(r_);
					CqlDate t_ = context.Operators.DateFrom(s_);
					CqlQuantity u_ = context.Operators.Quantity(30m, "days");
					CqlDate v_ = context.Operators.Subtract(t_, u_);
					CqlInterval<CqlDateTime> x_ = QICoreCommon_2_0_000.ToInterval((q_ as object));
					CqlDateTime y_ = context.Operators.Start(x_);
					CqlDate z_ = context.Operators.DateFrom(y_);
					CqlQuantity aa_ = context.Operators.Quantity(1m, "day");
					CqlDate ab_ = context.Operators.Subtract(z_, aa_);
					CqlInterval<CqlDate> ac_ = context.Operators.Interval(v_, ab_, true, true);
					CqlDateTime ad_ = context.Operators.ConvertDateToDateTime(ac_?.low);
					CqlInterval<CqlDateTime> af_ = QICoreCommon_2_0_000.ToInterval((q_ as object));
					CqlDateTime ag_ = context.Operators.Start(af_);
					CqlDate ah_ = context.Operators.DateFrom(ag_);
					CqlDate aj_ = context.Operators.Subtract(ah_, u_);
					CqlInterval<CqlDateTime> al_ = QICoreCommon_2_0_000.ToInterval((q_ as object));
					CqlDateTime am_ = context.Operators.Start(al_);
					CqlDate an_ = context.Operators.DateFrom(am_);
					CqlDate ap_ = context.Operators.Subtract(an_, aa_);
					CqlInterval<CqlDate> aq_ = context.Operators.Interval(aj_, ap_, true, true);
					CqlDateTime ar_ = context.Operators.ConvertDateToDateTime(aq_?.high);
					CqlInterval<CqlDateTime> at_ = QICoreCommon_2_0_000.ToInterval((q_ as object));
					CqlDateTime au_ = context.Operators.Start(at_);
					CqlDate av_ = context.Operators.DateFrom(au_);
					CqlDate ax_ = context.Operators.Subtract(av_, u_);
					CqlInterval<CqlDateTime> az_ = QICoreCommon_2_0_000.ToInterval((q_ as object));
					CqlDateTime ba_ = context.Operators.Start(az_);
					CqlDate bb_ = context.Operators.DateFrom(ba_);
					CqlDate bd_ = context.Operators.Subtract(bb_, aa_);
					CqlInterval<CqlDate> be_ = context.Operators.Interval(ax_, bd_, true, true);
					CqlInterval<CqlDateTime> bg_ = QICoreCommon_2_0_000.ToInterval((q_ as object));
					CqlDateTime bh_ = context.Operators.Start(bg_);
					CqlDate bi_ = context.Operators.DateFrom(bh_);
					CqlDate bk_ = context.Operators.Subtract(bi_, u_);
					CqlInterval<CqlDateTime> bm_ = QICoreCommon_2_0_000.ToInterval((q_ as object));
					CqlDateTime bn_ = context.Operators.Start(bm_);
					CqlDate bo_ = context.Operators.DateFrom(bn_);
					CqlDate bq_ = context.Operators.Subtract(bo_, aa_);
					CqlInterval<CqlDate> br_ = context.Operators.Interval(bk_, bq_, true, true);
					CqlInterval<CqlDateTime> bs_ = context.Operators.Interval(ad_, ar_, be_?.lowClosed, br_?.highClosed);
					bool? bt_ = context.Operators.Overlaps(p_, bs_, "day");

					return bt_;
				};
				IEnumerable<Timing> l_ = context.Operators.Where<Timing>(j_, k_);
				bool? m_ = context.Operators.Exists<Timing>(l_);

				return m_;
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
