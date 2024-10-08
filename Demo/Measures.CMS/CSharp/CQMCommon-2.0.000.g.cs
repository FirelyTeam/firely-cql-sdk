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
[System.CodeDom.Compiler.GeneratedCode(".NET Code Generation", "2.0.5.0")]
[CqlLibrary("CQMCommon", "2.0.000")]
public partial class CQMCommon_2_0_000 : ILibrary, ISingleton<CQMCommon_2_0_000>
{
    private CQMCommon_2_0_000() {}

    public static CQMCommon_2_0_000 Instance { get; } = new();

    #region Library Members
    public string Name => "CQMCommon";
    public string Version => "2.0.000";
    public ILibrary Dependencies => [FHIRHelpers_4_3_000.Instance, QICoreCommon_2_0_000.Instance]
    #endregion Library Members

    [CqlDeclaration("Emergency Department Visit")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.292")]
	public CqlValueSet Emergency_Department_Visit(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.292", default);


    [CqlDeclaration("Encounter Inpatient")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.666.5.307")]
	public CqlValueSet Encounter_Inpatient(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.666.5.307", default);


    [CqlDeclaration("Intensive Care Unit")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1029.206")]
	public CqlValueSet Intensive_Care_Unit(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1029.206", default);


    [CqlDeclaration("Observation Services")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1111.143")]
	public CqlValueSet Observation_Services(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1111.143", default);


    [CqlDeclaration("Outpatient Surgery Service")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1110.38")]
	public CqlValueSet Outpatient_Surgery_Service(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1110.38", default);


    [CqlDeclaration("Present on Admission or Clinically Undetermined")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1147.197")]
	public CqlValueSet Present_on_Admission_or_Clinically_Undetermined(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1147.197", default);


    [CqlDeclaration("Measurement Period")]
	public CqlInterval<CqlDateTime> Measurement_Period(CqlContext context)
	{
		CqlDateTime a_ = context.Operators.DateTime(2025, 1, 1, 0, 0, 0, 0, default);
		CqlDateTime b_ = context.Operators.DateTime(2026, 1, 1, 0, 0, 0, 0, default);
		CqlInterval<CqlDateTime> c_ = context.Operators.Interval(a_, b_, true, false);
		object d_ = context.ResolveParameter("CQMCommon-2.0.000", "Measurement Period", c_);

		return (CqlInterval<CqlDateTime>)d_;
	}


    [CqlDeclaration("Patient")]
	public Patient Patient(CqlContext context)
	{
		IEnumerable<Patient> a_ = context.Operators.RetrieveByValueSet<Patient>(default, default);
		Patient b_ = context.Operators.SingletonFrom<Patient>(a_);

		return b_;
	}


    [CqlDeclaration("Inpatient Encounter")]
	public IEnumerable<Encounter> Inpatient_Encounter(CqlContext context)
	{
		CqlValueSet a_ = this.Encounter_Inpatient(context);
		IEnumerable<Encounter> b_ = context.Operators.RetrieveByValueSet<Encounter>(a_, default);
		bool? c_(Encounter EncounterInpatient)
		{
			Code<Encounter.EncounterStatus> e_ = EncounterInpatient?.StatusElement;
			Encounter.EncounterStatus? f_ = e_?.Value;
			Code<Encounter.EncounterStatus> g_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(f_);
			bool? h_ = context.Operators.Equal(g_, "finished");
			Period i_ = EncounterInpatient?.Period;
			CqlInterval<CqlDateTime> j_ = FHIRHelpers_4_3_000.Instance.ToInterval(context, i_);
			CqlDateTime k_ = context.Operators.End(j_);
			CqlInterval<CqlDateTime> l_ = this.Measurement_Period(context);
			bool? m_ = context.Operators.In<CqlDateTime>(k_, l_, "day");
			bool? n_ = context.Operators.And(h_, m_);

			return n_;
		};
		IEnumerable<Encounter> d_ = context.Operators.Where<Encounter>(b_, c_);

		return d_;
	}

	public CqlInterval<CqlDate> ToDateInterval(CqlContext context, CqlInterval<CqlDateTime> period)
	{
		CqlDateTime a_ = context.Operators.Start(period);
		CqlDate b_ = context.Operators.DateFrom(a_);
		CqlDateTime c_ = context.Operators.End(period);
		CqlDate d_ = context.Operators.DateFrom(c_);
		CqlInterval<CqlDate> e_ = context.Operators.Interval(b_, d_, true, true);

		return e_;
	}

	public int? LengthInDays(CqlContext context, CqlInterval<CqlDateTime> Value)
	{
		CqlDateTime a_ = context.Operators.Start(Value);
		CqlDateTime b_ = context.Operators.End(Value);
		int? c_ = context.Operators.DifferenceBetween(a_, b_, "day");

		return c_;
	}

	public int? lengthInDays(CqlContext context, CqlInterval<CqlDateTime> Value)
	{
		CqlDateTime a_ = context.Operators.Start(Value);
		CqlDateTime b_ = context.Operators.End(Value);
		int? c_ = context.Operators.DifferenceBetween(a_, b_, "day");

		return c_;
	}

	public Encounter ED_Visit(CqlContext context, Encounter TheEncounter)
	{
		CqlValueSet a_ = this.Emergency_Department_Visit(context);
		IEnumerable<Encounter> b_ = context.Operators.RetrieveByValueSet<Encounter>(a_, default);
		bool? c_(Encounter EDVisit)
		{
			Code<Encounter.EncounterStatus> h_ = EDVisit?.StatusElement;
			Encounter.EncounterStatus? i_ = h_?.Value;
			Code<Encounter.EncounterStatus> j_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(i_);
			bool? k_ = context.Operators.Equal(j_, "finished");
			Period l_ = EDVisit?.Period;
			CqlInterval<CqlDateTime> m_ = FHIRHelpers_4_3_000.Instance.ToInterval(context, l_);
			CqlDateTime n_ = context.Operators.End(m_);
			Period o_ = TheEncounter?.Period;
			CqlInterval<CqlDateTime> p_ = FHIRHelpers_4_3_000.Instance.ToInterval(context, o_);
			CqlDateTime q_ = context.Operators.Start(p_);
			CqlQuantity r_ = context.Operators.Quantity(1m, "hour");
			CqlDateTime s_ = context.Operators.Subtract(q_, r_);
			CqlInterval<CqlDateTime> u_ = FHIRHelpers_4_3_000.Instance.ToInterval(context, o_);
			CqlDateTime v_ = context.Operators.Start(u_);
			CqlInterval<CqlDateTime> w_ = context.Operators.Interval(s_, v_, true, true);
			bool? x_ = context.Operators.In<CqlDateTime>(n_, w_, default);
			CqlInterval<CqlDateTime> z_ = FHIRHelpers_4_3_000.Instance.ToInterval(context, o_);
			CqlDateTime aa_ = context.Operators.Start(z_);
			bool? ab_ = context.Operators.Not((bool?)(aa_ is null));
			bool? ac_ = context.Operators.And(x_, ab_);
			bool? ad_ = context.Operators.And(k_, ac_);

			return ad_;
		};
		IEnumerable<Encounter> d_ = context.Operators.Where<Encounter>(b_, c_);
		object e_(Encounter @this)
		{
			Period ae_ = @this?.Period;
			CqlInterval<CqlDateTime> af_ = FHIRHelpers_4_3_000.Instance.ToInterval(context, ae_);
			CqlDateTime ag_ = context.Operators.End(af_);

			return ag_;
		};
		IEnumerable<Encounter> f_ = context.Operators.SortBy<Encounter>(d_, e_, System.ComponentModel.ListSortDirection.Ascending);
		Encounter g_ = context.Operators.Last<Encounter>(f_);

		return g_;
	}

	public Encounter edVisit(CqlContext context, Encounter TheEncounter)
	{
		CqlValueSet a_ = this.Emergency_Department_Visit(context);
		IEnumerable<Encounter> b_ = context.Operators.RetrieveByValueSet<Encounter>(a_, default);
		bool? c_(Encounter EDVisit)
		{
			Code<Encounter.EncounterStatus> h_ = EDVisit?.StatusElement;
			Encounter.EncounterStatus? i_ = h_?.Value;
			Code<Encounter.EncounterStatus> j_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(i_);
			bool? k_ = context.Operators.Equal(j_, "finished");
			Period l_ = EDVisit?.Period;
			CqlInterval<CqlDateTime> m_ = FHIRHelpers_4_3_000.Instance.ToInterval(context, l_);
			CqlDateTime n_ = context.Operators.End(m_);
			Period o_ = TheEncounter?.Period;
			CqlInterval<CqlDateTime> p_ = FHIRHelpers_4_3_000.Instance.ToInterval(context, o_);
			CqlDateTime q_ = context.Operators.Start(p_);
			CqlQuantity r_ = context.Operators.Quantity(1m, "hour");
			CqlDateTime s_ = context.Operators.Subtract(q_, r_);
			CqlInterval<CqlDateTime> u_ = FHIRHelpers_4_3_000.Instance.ToInterval(context, o_);
			CqlDateTime v_ = context.Operators.Start(u_);
			CqlInterval<CqlDateTime> w_ = context.Operators.Interval(s_, v_, true, true);
			bool? x_ = context.Operators.In<CqlDateTime>(n_, w_, default);
			CqlInterval<CqlDateTime> z_ = FHIRHelpers_4_3_000.Instance.ToInterval(context, o_);
			CqlDateTime aa_ = context.Operators.Start(z_);
			bool? ab_ = context.Operators.Not((bool?)(aa_ is null));
			bool? ac_ = context.Operators.And(x_, ab_);
			bool? ad_ = context.Operators.And(k_, ac_);

			return ad_;
		};
		IEnumerable<Encounter> d_ = context.Operators.Where<Encounter>(b_, c_);
		object e_(Encounter @this)
		{
			Period ae_ = @this?.Period;
			CqlInterval<CqlDateTime> af_ = FHIRHelpers_4_3_000.Instance.ToInterval(context, ae_);
			CqlDateTime ag_ = context.Operators.End(af_);

			return ag_;
		};
		IEnumerable<Encounter> f_ = context.Operators.SortBy<Encounter>(d_, e_, System.ComponentModel.ListSortDirection.Ascending);
		Encounter g_ = context.Operators.Last<Encounter>(f_);

		return g_;
	}

	public CqlInterval<CqlDateTime> Hospitalization(CqlContext context, Encounter TheEncounter)
	{
		Encounter a_ = this.ED_Visit(context, TheEncounter);
		Encounter[] b_ = [
			a_,
		];
		CqlInterval<CqlDateTime> c_(Encounter X)
		{
			CqlInterval<CqlDateTime> f_()
			{
				if (X is null)
				{
					Period g_ = TheEncounter?.Period;
					CqlInterval<CqlDateTime> h_ = FHIRHelpers_4_3_000.Instance.ToInterval(context, g_);

					return h_;
				}
				else
				{
					Period i_ = X?.Period;
					CqlInterval<CqlDateTime> j_ = FHIRHelpers_4_3_000.Instance.ToInterval(context, i_);
					CqlDateTime k_ = context.Operators.Start(j_);
					Period l_ = TheEncounter?.Period;
					CqlInterval<CqlDateTime> m_ = FHIRHelpers_4_3_000.Instance.ToInterval(context, l_);
					CqlDateTime n_ = context.Operators.End(m_);
					CqlInterval<CqlDateTime> o_ = context.Operators.Interval(k_, n_, true, false);

					return o_;
				}
			};

			return f_();
		};
		IEnumerable<CqlInterval<CqlDateTime>> d_ = context.Operators.Select<Encounter, CqlInterval<CqlDateTime>>((IEnumerable<Encounter>)b_, c_);
		CqlInterval<CqlDateTime> e_ = context.Operators.SingletonFrom<CqlInterval<CqlDateTime>>(d_);

		return e_;
	}

	public CqlInterval<CqlDateTime> hospitalization(CqlContext context, Encounter TheEncounter)
	{
		Encounter a_ = this.edVisit(context, TheEncounter);
		Encounter[] b_ = [
			a_,
		];
		CqlInterval<CqlDateTime> c_(Encounter X)
		{
			CqlInterval<CqlDateTime> f_()
			{
				if (X is null)
				{
					Period g_ = TheEncounter?.Period;
					CqlInterval<CqlDateTime> h_ = FHIRHelpers_4_3_000.Instance.ToInterval(context, g_);

					return h_;
				}
				else
				{
					Period i_ = X?.Period;
					CqlInterval<CqlDateTime> j_ = FHIRHelpers_4_3_000.Instance.ToInterval(context, i_);
					CqlDateTime k_ = context.Operators.Start(j_);
					Period l_ = TheEncounter?.Period;
					CqlInterval<CqlDateTime> m_ = FHIRHelpers_4_3_000.Instance.ToInterval(context, l_);
					CqlDateTime n_ = context.Operators.End(m_);
					CqlInterval<CqlDateTime> o_ = context.Operators.Interval(k_, n_, true, true);

					return o_;
				}
			};

			return f_();
		};
		IEnumerable<CqlInterval<CqlDateTime>> d_ = context.Operators.Select<Encounter, CqlInterval<CqlDateTime>>((IEnumerable<Encounter>)b_, c_);
		CqlInterval<CqlDateTime> e_ = context.Operators.SingletonFrom<CqlInterval<CqlDateTime>>(d_);

		return e_;
	}

	public IEnumerable<Encounter.LocationComponent> Hospitalization_Locations(CqlContext context, Encounter TheEncounter)
	{
		Encounter a_ = this.ED_Visit(context, TheEncounter);
		Encounter[] b_ = [
			a_,
		];
		IEnumerable<Encounter.LocationComponent> c_(Encounter EDEncounter)
		{
			IEnumerable<Encounter.LocationComponent> f_()
			{
				if (EDEncounter is null)
				{
					List<Encounter.LocationComponent> g_ = TheEncounter?.Location;

					return (IEnumerable<Encounter.LocationComponent>)g_;
				}
				else
				{
					List<Encounter.LocationComponent> h_ = EDEncounter?.Location;
					List<Encounter.LocationComponent> i_ = TheEncounter?.Location;
					IEnumerable<Encounter.LocationComponent>[] j_ = [
						(IEnumerable<Encounter.LocationComponent>)h_,
						(IEnumerable<Encounter.LocationComponent>)i_,
					];
					IEnumerable<Encounter.LocationComponent> k_ = context.Operators.Flatten<Encounter.LocationComponent>(j_ as IEnumerable<IEnumerable<Encounter.LocationComponent>>);

					return k_;
				}
			};

			return f_();
		};
		IEnumerable<IEnumerable<Encounter.LocationComponent>> d_ = context.Operators.Select<Encounter, IEnumerable<Encounter.LocationComponent>>((IEnumerable<Encounter>)b_, c_);
		IEnumerable<Encounter.LocationComponent> e_ = context.Operators.SingletonFrom<IEnumerable<Encounter.LocationComponent>>(d_);

		return e_;
	}

	public IEnumerable<Encounter.LocationComponent> hospitalizationLocations(CqlContext context, Encounter TheEncounter)
	{
		Encounter a_ = this.edVisit(context, TheEncounter);
		Encounter[] b_ = [
			a_,
		];
		IEnumerable<Encounter.LocationComponent> c_(Encounter EDEncounter)
		{
			IEnumerable<Encounter.LocationComponent> f_()
			{
				if (EDEncounter is null)
				{
					List<Encounter.LocationComponent> g_ = TheEncounter?.Location;

					return (IEnumerable<Encounter.LocationComponent>)g_;
				}
				else
				{
					List<Encounter.LocationComponent> h_ = EDEncounter?.Location;
					List<Encounter.LocationComponent> i_ = TheEncounter?.Location;
					IEnumerable<Encounter.LocationComponent>[] j_ = [
						(IEnumerable<Encounter.LocationComponent>)h_,
						(IEnumerable<Encounter.LocationComponent>)i_,
					];
					IEnumerable<Encounter.LocationComponent> k_ = context.Operators.Flatten<Encounter.LocationComponent>(j_ as IEnumerable<IEnumerable<Encounter.LocationComponent>>);

					return k_;
				}
			};

			return f_();
		};
		IEnumerable<IEnumerable<Encounter.LocationComponent>> d_ = context.Operators.Select<Encounter, IEnumerable<Encounter.LocationComponent>>((IEnumerable<Encounter>)b_, c_);
		IEnumerable<Encounter.LocationComponent> e_ = context.Operators.SingletonFrom<IEnumerable<Encounter.LocationComponent>>(d_);

		return e_;
	}

	public int? Hospitalization_Length_of_Stay(CqlContext context, Encounter TheEncounter)
	{
		CqlInterval<CqlDateTime> a_ = this.Hospitalization(context, TheEncounter);
		int? b_ = this.LengthInDays(context, a_);

		return b_;
	}

	public int? hospitalizationLengthOfStay(CqlContext context, Encounter TheEncounter)
	{
		CqlInterval<CqlDateTime> a_ = this.hospitalization(context, TheEncounter);
		int? b_ = this.lengthInDays(context, a_);

		return b_;
	}

	public CqlDateTime Hospital_Admission_Time(CqlContext context, Encounter TheEncounter)
	{
		CqlInterval<CqlDateTime> a_ = this.Hospitalization(context, TheEncounter);
		CqlDateTime b_ = context.Operators.Start(a_);

		return b_;
	}

	public CqlDateTime hospitalAdmissionTime(CqlContext context, Encounter TheEncounter)
	{
		CqlInterval<CqlDateTime> a_ = this.hospitalization(context, TheEncounter);
		CqlDateTime b_ = context.Operators.Start(a_);

		return b_;
	}

	public CqlDateTime Hospital_Discharge_Time(CqlContext context, Encounter TheEncounter)
	{
		Period a_ = TheEncounter?.Period;
		CqlInterval<CqlDateTime> b_ = FHIRHelpers_4_3_000.Instance.ToInterval(context, a_);
		CqlDateTime c_ = context.Operators.End(b_);

		return c_;
	}

	public CqlDateTime hospitalDischargeTime(CqlContext context, Encounter TheEncounter)
	{
		Period a_ = TheEncounter?.Period;
		CqlInterval<CqlDateTime> b_ = FHIRHelpers_4_3_000.Instance.ToInterval(context, a_);
		CqlDateTime c_ = context.Operators.End(b_);

		return c_;
	}

	public CqlDateTime Hospital_Arrival_Time(CqlContext context, Encounter TheEncounter)
	{
		IEnumerable<Encounter.LocationComponent> a_ = this.Hospitalization_Locations(context, TheEncounter);
		object b_(Encounter.LocationComponent @this)
		{
			Period h_ = @this?.Period;
			CqlInterval<CqlDateTime> i_ = FHIRHelpers_4_3_000.Instance.ToInterval(context, h_);
			CqlDateTime j_ = context.Operators.Start(i_);

			return j_;
		};
		IEnumerable<Encounter.LocationComponent> c_ = context.Operators.SortBy<Encounter.LocationComponent>(a_, b_, System.ComponentModel.ListSortDirection.Ascending);
		Encounter.LocationComponent d_ = context.Operators.First<Encounter.LocationComponent>(c_);
		Period e_ = d_?.Period;
		CqlInterval<CqlDateTime> f_ = FHIRHelpers_4_3_000.Instance.ToInterval(context, e_);
		CqlDateTime g_ = context.Operators.Start(f_);

		return g_;
	}

	public CqlDateTime hospitalArrivalTime(CqlContext context, Encounter TheEncounter)
	{
		IEnumerable<Encounter.LocationComponent> a_ = this.hospitalizationLocations(context, TheEncounter);
		object b_(Encounter.LocationComponent @this)
		{
			Period h_ = @this?.Period;
			CqlInterval<CqlDateTime> i_ = FHIRHelpers_4_3_000.Instance.ToInterval(context, h_);
			CqlDateTime j_ = context.Operators.Start(i_);

			return j_;
		};
		IEnumerable<Encounter.LocationComponent> c_ = context.Operators.SortBy<Encounter.LocationComponent>(a_, b_, System.ComponentModel.ListSortDirection.Ascending);
		Encounter.LocationComponent d_ = context.Operators.First<Encounter.LocationComponent>(c_);
		Period e_ = d_?.Period;
		CqlInterval<CqlDateTime> f_ = FHIRHelpers_4_3_000.Instance.ToInterval(context, e_);
		CqlDateTime g_ = context.Operators.Start(f_);

		return g_;
	}

	public CqlDateTime Hospital_Departure_Time(CqlContext context, Encounter TheEncounter)
	{
		IEnumerable<Encounter.LocationComponent> a_ = this.Hospitalization_Locations(context, TheEncounter);
		object b_(Encounter.LocationComponent @this)
		{
			Period h_ = @this?.Period;
			CqlInterval<CqlDateTime> i_ = FHIRHelpers_4_3_000.Instance.ToInterval(context, h_);
			CqlDateTime j_ = context.Operators.Start(i_);

			return j_;
		};
		IEnumerable<Encounter.LocationComponent> c_ = context.Operators.SortBy<Encounter.LocationComponent>(a_, b_, System.ComponentModel.ListSortDirection.Ascending);
		Encounter.LocationComponent d_ = context.Operators.Last<Encounter.LocationComponent>(c_);
		Period e_ = d_?.Period;
		CqlInterval<CqlDateTime> f_ = FHIRHelpers_4_3_000.Instance.ToInterval(context, e_);
		CqlDateTime g_ = context.Operators.End(f_);

		return g_;
	}

	public CqlDateTime hospitalDepartureTime(CqlContext context, Encounter TheEncounter)
	{
		IEnumerable<Encounter.LocationComponent> a_ = this.hospitalizationLocations(context, TheEncounter);
		object b_(Encounter.LocationComponent @this)
		{
			Period h_ = @this?.Period;
			CqlInterval<CqlDateTime> i_ = FHIRHelpers_4_3_000.Instance.ToInterval(context, h_);
			CqlDateTime j_ = context.Operators.Start(i_);

			return j_;
		};
		IEnumerable<Encounter.LocationComponent> c_ = context.Operators.SortBy<Encounter.LocationComponent>(a_, b_, System.ComponentModel.ListSortDirection.Ascending);
		Encounter.LocationComponent d_ = context.Operators.Last<Encounter.LocationComponent>(c_);
		Period e_ = d_?.Period;
		CqlInterval<CqlDateTime> f_ = FHIRHelpers_4_3_000.Instance.ToInterval(context, e_);
		CqlDateTime g_ = context.Operators.End(f_);

		return g_;
	}

	public Location GetLocation(CqlContext context, ResourceReference reference)
	{
		IEnumerable<Location> a_ = context.Operators.RetrieveByValueSet<Location>(default, default);
		bool? b_(Location L)
		{
			Id e_ = L?.IdElement;
			string f_ = e_?.Value;
			FhirString g_ = reference?.ReferenceElement;
			string h_ = g_?.Value;
			string i_ = QICoreCommon_2_0_000.Instance.getId(context, h_);
			bool? j_ = context.Operators.Equal(f_, i_);

			return j_;
		};
		IEnumerable<Location> c_ = context.Operators.Where<Location>(a_, b_);
		Location d_ = context.Operators.SingletonFrom<Location>(c_);

		return d_;
	}

	public CqlDateTime Emergency_Department_Arrival_Time(CqlContext context, Encounter TheEncounter)
	{
		IEnumerable<Encounter.LocationComponent> a_ = this.Hospitalization_Locations(context, TheEncounter);
		bool? b_(Encounter.LocationComponent HospitalLocation)
		{
			ResourceReference h_ = HospitalLocation?.Location;
			Location i_ = this.GetLocation(context, h_);
			List<CodeableConcept> j_ = i_?.Type;
			CqlConcept k_(CodeableConcept @this)
			{
				CqlConcept o_ = FHIRHelpers_4_3_000.Instance.ToConcept(context, @this);

				return o_;
			};
			IEnumerable<CqlConcept> l_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)j_, k_);
			CqlValueSet m_ = this.Emergency_Department_Visit(context);
			bool? n_ = context.Operators.ConceptsInValueSet(l_, m_);

			return n_;
		};
		IEnumerable<Encounter.LocationComponent> c_ = context.Operators.Where<Encounter.LocationComponent>(a_, b_);
		Encounter.LocationComponent d_ = context.Operators.SingletonFrom<Encounter.LocationComponent>(c_);
		Period e_ = d_?.Period;
		CqlInterval<CqlDateTime> f_ = FHIRHelpers_4_3_000.Instance.ToInterval(context, e_);
		CqlDateTime g_ = context.Operators.Start(f_);

		return g_;
	}

	public CqlDateTime emergencyDepartmentArrivalTime(CqlContext context, Encounter TheEncounter)
	{
		IEnumerable<Encounter.LocationComponent> a_ = this.hospitalizationLocations(context, TheEncounter);
		bool? b_(Encounter.LocationComponent HospitalLocation)
		{
			ResourceReference h_ = HospitalLocation?.Location;
			Location i_ = this.GetLocation(context, h_);
			List<CodeableConcept> j_ = i_?.Type;
			CqlConcept k_(CodeableConcept @this)
			{
				CqlConcept o_ = FHIRHelpers_4_3_000.Instance.ToConcept(context, @this);

				return o_;
			};
			IEnumerable<CqlConcept> l_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)j_, k_);
			CqlValueSet m_ = this.Emergency_Department_Visit(context);
			bool? n_ = context.Operators.ConceptsInValueSet(l_, m_);

			return n_;
		};
		IEnumerable<Encounter.LocationComponent> c_ = context.Operators.Where<Encounter.LocationComponent>(a_, b_);
		Encounter.LocationComponent d_ = context.Operators.SingletonFrom<Encounter.LocationComponent>(c_);
		Period e_ = d_?.Period;
		CqlInterval<CqlDateTime> f_ = FHIRHelpers_4_3_000.Instance.ToInterval(context, e_);
		CqlDateTime g_ = context.Operators.Start(f_);

		return g_;
	}

	public CqlInterval<CqlDateTime> HospitalizationWithObservationAndOutpatientSurgeryService(CqlContext context, Encounter TheEncounter)
	{
		Encounter[] a_ = [
			TheEncounter,
		];
		CqlInterval<CqlDateTime> b_(Encounter Visit)
		{
			CqlValueSet e_ = this.Outpatient_Surgery_Service(context);
			IEnumerable<Encounter> f_ = context.Operators.RetrieveByValueSet<Encounter>(e_, default);
			bool? g_(Encounter LastSurgeryOP)
			{
				Period ap_ = LastSurgeryOP?.Period;
				CqlInterval<CqlDateTime> aq_ = FHIRHelpers_4_3_000.Instance.ToInterval(context, ap_);
				CqlDateTime ar_ = context.Operators.End(aq_);
				CqlValueSet as_ = this.Emergency_Department_Visit(context);
				IEnumerable<Encounter> at_ = context.Operators.RetrieveByValueSet<Encounter>(as_, default);
				bool? au_(Encounter LastED)
				{
					Code<Encounter.EncounterStatus> dp_ = LastED?.StatusElement;
					Encounter.EncounterStatus? dq_ = dp_?.Value;
					Code<Encounter.EncounterStatus> dr_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(dq_);
					bool? ds_ = context.Operators.Equal(dr_, "finished");
					Period dt_ = LastED?.Period;
					CqlInterval<CqlDateTime> du_ = FHIRHelpers_4_3_000.Instance.ToInterval(context, dt_);
					CqlDateTime dv_ = context.Operators.End(du_);
					CqlValueSet dw_ = this.Observation_Services(context);
					IEnumerable<Encounter> dx_ = context.Operators.RetrieveByValueSet<Encounter>(dw_, default);
					bool? dy_(Encounter LastObs)
					{
						Code<Encounter.EncounterStatus> fq_ = LastObs?.StatusElement;
						Encounter.EncounterStatus? fr_ = fq_?.Value;
						Code<Encounter.EncounterStatus> fs_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(fr_);
						bool? ft_ = context.Operators.Equal(fs_, "finished");
						Period fu_ = LastObs?.Period;
						CqlInterval<CqlDateTime> fv_ = FHIRHelpers_4_3_000.Instance.ToInterval(context, fu_);
						CqlDateTime fw_ = context.Operators.End(fv_);
						Period fx_ = Visit?.Period;
						CqlInterval<CqlDateTime> fy_ = FHIRHelpers_4_3_000.Instance.ToInterval(context, fx_);
						CqlDateTime fz_ = context.Operators.Start(fy_);
						CqlQuantity ga_ = context.Operators.Quantity(1m, "hour");
						CqlDateTime gb_ = context.Operators.Subtract(fz_, ga_);
						CqlInterval<CqlDateTime> gd_ = FHIRHelpers_4_3_000.Instance.ToInterval(context, fx_);
						CqlDateTime ge_ = context.Operators.Start(gd_);
						CqlInterval<CqlDateTime> gf_ = context.Operators.Interval(gb_, ge_, true, true);
						bool? gg_ = context.Operators.In<CqlDateTime>(fw_, gf_, default);
						CqlInterval<CqlDateTime> gi_ = FHIRHelpers_4_3_000.Instance.ToInterval(context, fx_);
						CqlDateTime gj_ = context.Operators.Start(gi_);
						bool? gk_ = context.Operators.Not((bool?)(gj_ is null));
						bool? gl_ = context.Operators.And(gg_, gk_);
						bool? gm_ = context.Operators.And(ft_, gl_);

						return gm_;
					};
					IEnumerable<Encounter> dz_ = context.Operators.Where<Encounter>(dx_, dy_);
					object ea_(Encounter @this)
					{
						Period gn_ = @this?.Period;
						CqlInterval<CqlDateTime> go_ = FHIRHelpers_4_3_000.Instance.ToInterval(context, gn_);
						CqlDateTime gp_ = context.Operators.End(go_);

						return gp_;
					};
					IEnumerable<Encounter> eb_ = context.Operators.SortBy<Encounter>(dz_, ea_, System.ComponentModel.ListSortDirection.Ascending);
					Encounter ec_ = context.Operators.Last<Encounter>(eb_);
					Period ed_ = ec_?.Period;
					CqlInterval<CqlDateTime> ee_ = FHIRHelpers_4_3_000.Instance.ToInterval(context, ed_);
					CqlDateTime ef_ = context.Operators.Start(ee_);
					Period eg_ = Visit?.Period;
					CqlInterval<CqlDateTime> eh_ = FHIRHelpers_4_3_000.Instance.ToInterval(context, eg_);
					CqlDateTime ei_ = context.Operators.Start(eh_);
					CqlQuantity ej_ = context.Operators.Quantity(1m, "hour");
					CqlDateTime ek_ = context.Operators.Subtract(ef_ ?? ei_, ej_);
					IEnumerable<Encounter> em_ = context.Operators.RetrieveByValueSet<Encounter>(dw_, default);
					bool? en_(Encounter LastObs)
					{
						Code<Encounter.EncounterStatus> gq_ = LastObs?.StatusElement;
						Encounter.EncounterStatus? gr_ = gq_?.Value;
						Code<Encounter.EncounterStatus> gs_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(gr_);
						bool? gt_ = context.Operators.Equal(gs_, "finished");
						Period gu_ = LastObs?.Period;
						CqlInterval<CqlDateTime> gv_ = FHIRHelpers_4_3_000.Instance.ToInterval(context, gu_);
						CqlDateTime gw_ = context.Operators.End(gv_);
						Period gx_ = Visit?.Period;
						CqlInterval<CqlDateTime> gy_ = FHIRHelpers_4_3_000.Instance.ToInterval(context, gx_);
						CqlDateTime gz_ = context.Operators.Start(gy_);
						CqlQuantity ha_ = context.Operators.Quantity(1m, "hour");
						CqlDateTime hb_ = context.Operators.Subtract(gz_, ha_);
						CqlInterval<CqlDateTime> hd_ = FHIRHelpers_4_3_000.Instance.ToInterval(context, gx_);
						CqlDateTime he_ = context.Operators.Start(hd_);
						CqlInterval<CqlDateTime> hf_ = context.Operators.Interval(hb_, he_, true, true);
						bool? hg_ = context.Operators.In<CqlDateTime>(gw_, hf_, default);
						CqlInterval<CqlDateTime> hi_ = FHIRHelpers_4_3_000.Instance.ToInterval(context, gx_);
						CqlDateTime hj_ = context.Operators.Start(hi_);
						bool? hk_ = context.Operators.Not((bool?)(hj_ is null));
						bool? hl_ = context.Operators.And(hg_, hk_);
						bool? hm_ = context.Operators.And(gt_, hl_);

						return hm_;
					};
					IEnumerable<Encounter> eo_ = context.Operators.Where<Encounter>(em_, en_);
					object ep_(Encounter @this)
					{
						Period hn_ = @this?.Period;
						CqlInterval<CqlDateTime> ho_ = FHIRHelpers_4_3_000.Instance.ToInterval(context, hn_);
						CqlDateTime hp_ = context.Operators.End(ho_);

						return hp_;
					};
					IEnumerable<Encounter> eq_ = context.Operators.SortBy<Encounter>(eo_, ep_, System.ComponentModel.ListSortDirection.Ascending);
					Encounter er_ = context.Operators.Last<Encounter>(eq_);
					Period es_ = er_?.Period;
					CqlInterval<CqlDateTime> et_ = FHIRHelpers_4_3_000.Instance.ToInterval(context, es_);
					CqlDateTime eu_ = context.Operators.Start(et_);
					CqlInterval<CqlDateTime> ew_ = FHIRHelpers_4_3_000.Instance.ToInterval(context, eg_);
					CqlDateTime ex_ = context.Operators.Start(ew_);
					CqlInterval<CqlDateTime> ey_ = context.Operators.Interval(ek_, eu_ ?? ex_, true, true);
					bool? ez_ = context.Operators.In<CqlDateTime>(dv_, ey_, default);
					IEnumerable<Encounter> fb_ = context.Operators.RetrieveByValueSet<Encounter>(dw_, default);
					bool? fc_(Encounter LastObs)
					{
						Code<Encounter.EncounterStatus> hq_ = LastObs?.StatusElement;
						Encounter.EncounterStatus? hr_ = hq_?.Value;
						Code<Encounter.EncounterStatus> hs_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(hr_);
						bool? ht_ = context.Operators.Equal(hs_, "finished");
						Period hu_ = LastObs?.Period;
						CqlInterval<CqlDateTime> hv_ = FHIRHelpers_4_3_000.Instance.ToInterval(context, hu_);
						CqlDateTime hw_ = context.Operators.End(hv_);
						Period hx_ = Visit?.Period;
						CqlInterval<CqlDateTime> hy_ = FHIRHelpers_4_3_000.Instance.ToInterval(context, hx_);
						CqlDateTime hz_ = context.Operators.Start(hy_);
						CqlQuantity ia_ = context.Operators.Quantity(1m, "hour");
						CqlDateTime ib_ = context.Operators.Subtract(hz_, ia_);
						CqlInterval<CqlDateTime> id_ = FHIRHelpers_4_3_000.Instance.ToInterval(context, hx_);
						CqlDateTime ie_ = context.Operators.Start(id_);
						CqlInterval<CqlDateTime> if_ = context.Operators.Interval(ib_, ie_, true, true);
						bool? ig_ = context.Operators.In<CqlDateTime>(hw_, if_, default);
						CqlInterval<CqlDateTime> ii_ = FHIRHelpers_4_3_000.Instance.ToInterval(context, hx_);
						CqlDateTime ij_ = context.Operators.Start(ii_);
						bool? ik_ = context.Operators.Not((bool?)(ij_ is null));
						bool? il_ = context.Operators.And(ig_, ik_);
						bool? im_ = context.Operators.And(ht_, il_);

						return im_;
					};
					IEnumerable<Encounter> fd_ = context.Operators.Where<Encounter>(fb_, fc_);
					object fe_(Encounter @this)
					{
						Period in_ = @this?.Period;
						CqlInterval<CqlDateTime> io_ = FHIRHelpers_4_3_000.Instance.ToInterval(context, in_);
						CqlDateTime ip_ = context.Operators.End(io_);

						return ip_;
					};
					IEnumerable<Encounter> ff_ = context.Operators.SortBy<Encounter>(fd_, fe_, System.ComponentModel.ListSortDirection.Ascending);
					Encounter fg_ = context.Operators.Last<Encounter>(ff_);
					Period fh_ = fg_?.Period;
					CqlInterval<CqlDateTime> fi_ = FHIRHelpers_4_3_000.Instance.ToInterval(context, fh_);
					CqlDateTime fj_ = context.Operators.Start(fi_);
					CqlInterval<CqlDateTime> fl_ = FHIRHelpers_4_3_000.Instance.ToInterval(context, eg_);
					CqlDateTime fm_ = context.Operators.Start(fl_);
					bool? fn_ = context.Operators.Not((bool?)((fj_ ?? fm_) is null));
					bool? fo_ = context.Operators.And(ez_, fn_);
					bool? fp_ = context.Operators.And(ds_, fo_);

					return fp_;
				};
				IEnumerable<Encounter> av_ = context.Operators.Where<Encounter>(at_, au_);
				object aw_(Encounter @this)
				{
					Period iq_ = @this?.Period;
					CqlInterval<CqlDateTime> ir_ = FHIRHelpers_4_3_000.Instance.ToInterval(context, iq_);
					CqlDateTime is_ = context.Operators.End(ir_);

					return is_;
				};
				IEnumerable<Encounter> ax_ = context.Operators.SortBy<Encounter>(av_, aw_, System.ComponentModel.ListSortDirection.Ascending);
				Encounter ay_ = context.Operators.Last<Encounter>(ax_);
				Period az_ = ay_?.Period;
				CqlInterval<CqlDateTime> ba_ = FHIRHelpers_4_3_000.Instance.ToInterval(context, az_);
				CqlDateTime bb_ = context.Operators.Start(ba_);
				CqlValueSet bc_ = this.Observation_Services(context);
				IEnumerable<Encounter> bd_ = context.Operators.RetrieveByValueSet<Encounter>(bc_, default);
				bool? be_(Encounter LastObs)
				{
					Code<Encounter.EncounterStatus> it_ = LastObs?.StatusElement;
					Encounter.EncounterStatus? iu_ = it_?.Value;
					Code<Encounter.EncounterStatus> iv_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(iu_);
					bool? iw_ = context.Operators.Equal(iv_, "finished");
					Period ix_ = LastObs?.Period;
					CqlInterval<CqlDateTime> iy_ = FHIRHelpers_4_3_000.Instance.ToInterval(context, ix_);
					CqlDateTime iz_ = context.Operators.End(iy_);
					Period ja_ = Visit?.Period;
					CqlInterval<CqlDateTime> jb_ = FHIRHelpers_4_3_000.Instance.ToInterval(context, ja_);
					CqlDateTime jc_ = context.Operators.Start(jb_);
					CqlQuantity jd_ = context.Operators.Quantity(1m, "hour");
					CqlDateTime je_ = context.Operators.Subtract(jc_, jd_);
					CqlInterval<CqlDateTime> jg_ = FHIRHelpers_4_3_000.Instance.ToInterval(context, ja_);
					CqlDateTime jh_ = context.Operators.Start(jg_);
					CqlInterval<CqlDateTime> ji_ = context.Operators.Interval(je_, jh_, true, true);
					bool? jj_ = context.Operators.In<CqlDateTime>(iz_, ji_, default);
					CqlInterval<CqlDateTime> jl_ = FHIRHelpers_4_3_000.Instance.ToInterval(context, ja_);
					CqlDateTime jm_ = context.Operators.Start(jl_);
					bool? jn_ = context.Operators.Not((bool?)(jm_ is null));
					bool? jo_ = context.Operators.And(jj_, jn_);
					bool? jp_ = context.Operators.And(iw_, jo_);

					return jp_;
				};
				IEnumerable<Encounter> bf_ = context.Operators.Where<Encounter>(bd_, be_);
				object bg_(Encounter @this)
				{
					Period jq_ = @this?.Period;
					CqlInterval<CqlDateTime> jr_ = FHIRHelpers_4_3_000.Instance.ToInterval(context, jq_);
					CqlDateTime js_ = context.Operators.End(jr_);

					return js_;
				};
				IEnumerable<Encounter> bh_ = context.Operators.SortBy<Encounter>(bf_, bg_, System.ComponentModel.ListSortDirection.Ascending);
				Encounter bi_ = context.Operators.Last<Encounter>(bh_);
				Period bj_ = bi_?.Period;
				CqlInterval<CqlDateTime> bk_ = FHIRHelpers_4_3_000.Instance.ToInterval(context, bj_);
				CqlDateTime bl_ = context.Operators.Start(bk_);
				Period bm_ = Visit?.Period;
				CqlInterval<CqlDateTime> bn_ = FHIRHelpers_4_3_000.Instance.ToInterval(context, bm_);
				CqlDateTime bo_ = context.Operators.Start(bn_);
				CqlQuantity bp_ = context.Operators.Quantity(1m, "hour");
				CqlDateTime bq_ = context.Operators.Subtract(bb_ ?? bl_ ?? bo_, bp_);
				IEnumerable<Encounter> bs_ = context.Operators.RetrieveByValueSet<Encounter>(as_, default);
				bool? bt_(Encounter LastED)
				{
					Code<Encounter.EncounterStatus> jt_ = LastED?.StatusElement;
					Encounter.EncounterStatus? ju_ = jt_?.Value;
					Code<Encounter.EncounterStatus> jv_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(ju_);
					bool? jw_ = context.Operators.Equal(jv_, "finished");
					Period jx_ = LastED?.Period;
					CqlInterval<CqlDateTime> jy_ = FHIRHelpers_4_3_000.Instance.ToInterval(context, jx_);
					CqlDateTime jz_ = context.Operators.End(jy_);
					CqlValueSet ka_ = this.Observation_Services(context);
					IEnumerable<Encounter> kb_ = context.Operators.RetrieveByValueSet<Encounter>(ka_, default);
					bool? kc_(Encounter LastObs)
					{
						Code<Encounter.EncounterStatus> lu_ = LastObs?.StatusElement;
						Encounter.EncounterStatus? lv_ = lu_?.Value;
						Code<Encounter.EncounterStatus> lw_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(lv_);
						bool? lx_ = context.Operators.Equal(lw_, "finished");
						Period ly_ = LastObs?.Period;
						CqlInterval<CqlDateTime> lz_ = FHIRHelpers_4_3_000.Instance.ToInterval(context, ly_);
						CqlDateTime ma_ = context.Operators.End(lz_);
						Period mb_ = Visit?.Period;
						CqlInterval<CqlDateTime> mc_ = FHIRHelpers_4_3_000.Instance.ToInterval(context, mb_);
						CqlDateTime md_ = context.Operators.Start(mc_);
						CqlQuantity me_ = context.Operators.Quantity(1m, "hour");
						CqlDateTime mf_ = context.Operators.Subtract(md_, me_);
						CqlInterval<CqlDateTime> mh_ = FHIRHelpers_4_3_000.Instance.ToInterval(context, mb_);
						CqlDateTime mi_ = context.Operators.Start(mh_);
						CqlInterval<CqlDateTime> mj_ = context.Operators.Interval(mf_, mi_, true, true);
						bool? mk_ = context.Operators.In<CqlDateTime>(ma_, mj_, default);
						CqlInterval<CqlDateTime> mm_ = FHIRHelpers_4_3_000.Instance.ToInterval(context, mb_);
						CqlDateTime mn_ = context.Operators.Start(mm_);
						bool? mo_ = context.Operators.Not((bool?)(mn_ is null));
						bool? mp_ = context.Operators.And(mk_, mo_);
						bool? mq_ = context.Operators.And(lx_, mp_);

						return mq_;
					};
					IEnumerable<Encounter> kd_ = context.Operators.Where<Encounter>(kb_, kc_);
					object ke_(Encounter @this)
					{
						Period mr_ = @this?.Period;
						CqlInterval<CqlDateTime> ms_ = FHIRHelpers_4_3_000.Instance.ToInterval(context, mr_);
						CqlDateTime mt_ = context.Operators.End(ms_);

						return mt_;
					};
					IEnumerable<Encounter> kf_ = context.Operators.SortBy<Encounter>(kd_, ke_, System.ComponentModel.ListSortDirection.Ascending);
					Encounter kg_ = context.Operators.Last<Encounter>(kf_);
					Period kh_ = kg_?.Period;
					CqlInterval<CqlDateTime> ki_ = FHIRHelpers_4_3_000.Instance.ToInterval(context, kh_);
					CqlDateTime kj_ = context.Operators.Start(ki_);
					Period kk_ = Visit?.Period;
					CqlInterval<CqlDateTime> kl_ = FHIRHelpers_4_3_000.Instance.ToInterval(context, kk_);
					CqlDateTime km_ = context.Operators.Start(kl_);
					CqlQuantity kn_ = context.Operators.Quantity(1m, "hour");
					CqlDateTime ko_ = context.Operators.Subtract(kj_ ?? km_, kn_);
					IEnumerable<Encounter> kq_ = context.Operators.RetrieveByValueSet<Encounter>(ka_, default);
					bool? kr_(Encounter LastObs)
					{
						Code<Encounter.EncounterStatus> mu_ = LastObs?.StatusElement;
						Encounter.EncounterStatus? mv_ = mu_?.Value;
						Code<Encounter.EncounterStatus> mw_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(mv_);
						bool? mx_ = context.Operators.Equal(mw_, "finished");
						Period my_ = LastObs?.Period;
						CqlInterval<CqlDateTime> mz_ = FHIRHelpers_4_3_000.Instance.ToInterval(context, my_);
						CqlDateTime na_ = context.Operators.End(mz_);
						Period nb_ = Visit?.Period;
						CqlInterval<CqlDateTime> nc_ = FHIRHelpers_4_3_000.Instance.ToInterval(context, nb_);
						CqlDateTime nd_ = context.Operators.Start(nc_);
						CqlQuantity ne_ = context.Operators.Quantity(1m, "hour");
						CqlDateTime nf_ = context.Operators.Subtract(nd_, ne_);
						CqlInterval<CqlDateTime> nh_ = FHIRHelpers_4_3_000.Instance.ToInterval(context, nb_);
						CqlDateTime ni_ = context.Operators.Start(nh_);
						CqlInterval<CqlDateTime> nj_ = context.Operators.Interval(nf_, ni_, true, true);
						bool? nk_ = context.Operators.In<CqlDateTime>(na_, nj_, default);
						CqlInterval<CqlDateTime> nm_ = FHIRHelpers_4_3_000.Instance.ToInterval(context, nb_);
						CqlDateTime nn_ = context.Operators.Start(nm_);
						bool? no_ = context.Operators.Not((bool?)(nn_ is null));
						bool? np_ = context.Operators.And(nk_, no_);
						bool? nq_ = context.Operators.And(mx_, np_);

						return nq_;
					};
					IEnumerable<Encounter> ks_ = context.Operators.Where<Encounter>(kq_, kr_);
					object kt_(Encounter @this)
					{
						Period nr_ = @this?.Period;
						CqlInterval<CqlDateTime> ns_ = FHIRHelpers_4_3_000.Instance.ToInterval(context, nr_);
						CqlDateTime nt_ = context.Operators.End(ns_);

						return nt_;
					};
					IEnumerable<Encounter> ku_ = context.Operators.SortBy<Encounter>(ks_, kt_, System.ComponentModel.ListSortDirection.Ascending);
					Encounter kv_ = context.Operators.Last<Encounter>(ku_);
					Period kw_ = kv_?.Period;
					CqlInterval<CqlDateTime> kx_ = FHIRHelpers_4_3_000.Instance.ToInterval(context, kw_);
					CqlDateTime ky_ = context.Operators.Start(kx_);
					CqlInterval<CqlDateTime> la_ = FHIRHelpers_4_3_000.Instance.ToInterval(context, kk_);
					CqlDateTime lb_ = context.Operators.Start(la_);
					CqlInterval<CqlDateTime> lc_ = context.Operators.Interval(ko_, ky_ ?? lb_, true, true);
					bool? ld_ = context.Operators.In<CqlDateTime>(jz_, lc_, default);
					IEnumerable<Encounter> lf_ = context.Operators.RetrieveByValueSet<Encounter>(ka_, default);
					bool? lg_(Encounter LastObs)
					{
						Code<Encounter.EncounterStatus> nu_ = LastObs?.StatusElement;
						Encounter.EncounterStatus? nv_ = nu_?.Value;
						Code<Encounter.EncounterStatus> nw_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(nv_);
						bool? nx_ = context.Operators.Equal(nw_, "finished");
						Period ny_ = LastObs?.Period;
						CqlInterval<CqlDateTime> nz_ = FHIRHelpers_4_3_000.Instance.ToInterval(context, ny_);
						CqlDateTime oa_ = context.Operators.End(nz_);
						Period ob_ = Visit?.Period;
						CqlInterval<CqlDateTime> oc_ = FHIRHelpers_4_3_000.Instance.ToInterval(context, ob_);
						CqlDateTime od_ = context.Operators.Start(oc_);
						CqlQuantity oe_ = context.Operators.Quantity(1m, "hour");
						CqlDateTime of_ = context.Operators.Subtract(od_, oe_);
						CqlInterval<CqlDateTime> oh_ = FHIRHelpers_4_3_000.Instance.ToInterval(context, ob_);
						CqlDateTime oi_ = context.Operators.Start(oh_);
						CqlInterval<CqlDateTime> oj_ = context.Operators.Interval(of_, oi_, true, true);
						bool? ok_ = context.Operators.In<CqlDateTime>(oa_, oj_, default);
						CqlInterval<CqlDateTime> om_ = FHIRHelpers_4_3_000.Instance.ToInterval(context, ob_);
						CqlDateTime on_ = context.Operators.Start(om_);
						bool? oo_ = context.Operators.Not((bool?)(on_ is null));
						bool? op_ = context.Operators.And(ok_, oo_);
						bool? oq_ = context.Operators.And(nx_, op_);

						return oq_;
					};
					IEnumerable<Encounter> lh_ = context.Operators.Where<Encounter>(lf_, lg_);
					object li_(Encounter @this)
					{
						Period or_ = @this?.Period;
						CqlInterval<CqlDateTime> os_ = FHIRHelpers_4_3_000.Instance.ToInterval(context, or_);
						CqlDateTime ot_ = context.Operators.End(os_);

						return ot_;
					};
					IEnumerable<Encounter> lj_ = context.Operators.SortBy<Encounter>(lh_, li_, System.ComponentModel.ListSortDirection.Ascending);
					Encounter lk_ = context.Operators.Last<Encounter>(lj_);
					Period ll_ = lk_?.Period;
					CqlInterval<CqlDateTime> lm_ = FHIRHelpers_4_3_000.Instance.ToInterval(context, ll_);
					CqlDateTime ln_ = context.Operators.Start(lm_);
					CqlInterval<CqlDateTime> lp_ = FHIRHelpers_4_3_000.Instance.ToInterval(context, kk_);
					CqlDateTime lq_ = context.Operators.Start(lp_);
					bool? lr_ = context.Operators.Not((bool?)((ln_ ?? lq_) is null));
					bool? ls_ = context.Operators.And(ld_, lr_);
					bool? lt_ = context.Operators.And(jw_, ls_);

					return lt_;
				};
				IEnumerable<Encounter> bu_ = context.Operators.Where<Encounter>(bs_, bt_);
				object bv_(Encounter @this)
				{
					Period ou_ = @this?.Period;
					CqlInterval<CqlDateTime> ov_ = FHIRHelpers_4_3_000.Instance.ToInterval(context, ou_);
					CqlDateTime ow_ = context.Operators.End(ov_);

					return ow_;
				};
				IEnumerable<Encounter> bw_ = context.Operators.SortBy<Encounter>(bu_, bv_, System.ComponentModel.ListSortDirection.Ascending);
				Encounter bx_ = context.Operators.Last<Encounter>(bw_);
				Period by_ = bx_?.Period;
				CqlInterval<CqlDateTime> bz_ = FHIRHelpers_4_3_000.Instance.ToInterval(context, by_);
				CqlDateTime ca_ = context.Operators.Start(bz_);
				IEnumerable<Encounter> cc_ = context.Operators.RetrieveByValueSet<Encounter>(bc_, default);
				bool? cd_(Encounter LastObs)
				{
					Code<Encounter.EncounterStatus> ox_ = LastObs?.StatusElement;
					Encounter.EncounterStatus? oy_ = ox_?.Value;
					Code<Encounter.EncounterStatus> oz_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(oy_);
					bool? pa_ = context.Operators.Equal(oz_, "finished");
					Period pb_ = LastObs?.Period;
					CqlInterval<CqlDateTime> pc_ = FHIRHelpers_4_3_000.Instance.ToInterval(context, pb_);
					CqlDateTime pd_ = context.Operators.End(pc_);
					Period pe_ = Visit?.Period;
					CqlInterval<CqlDateTime> pf_ = FHIRHelpers_4_3_000.Instance.ToInterval(context, pe_);
					CqlDateTime pg_ = context.Operators.Start(pf_);
					CqlQuantity ph_ = context.Operators.Quantity(1m, "hour");
					CqlDateTime pi_ = context.Operators.Subtract(pg_, ph_);
					CqlInterval<CqlDateTime> pk_ = FHIRHelpers_4_3_000.Instance.ToInterval(context, pe_);
					CqlDateTime pl_ = context.Operators.Start(pk_);
					CqlInterval<CqlDateTime> pm_ = context.Operators.Interval(pi_, pl_, true, true);
					bool? pn_ = context.Operators.In<CqlDateTime>(pd_, pm_, default);
					CqlInterval<CqlDateTime> pp_ = FHIRHelpers_4_3_000.Instance.ToInterval(context, pe_);
					CqlDateTime pq_ = context.Operators.Start(pp_);
					bool? pr_ = context.Operators.Not((bool?)(pq_ is null));
					bool? ps_ = context.Operators.And(pn_, pr_);
					bool? pt_ = context.Operators.And(pa_, ps_);

					return pt_;
				};
				IEnumerable<Encounter> ce_ = context.Operators.Where<Encounter>(cc_, cd_);
				object cf_(Encounter @this)
				{
					Period pu_ = @this?.Period;
					CqlInterval<CqlDateTime> pv_ = FHIRHelpers_4_3_000.Instance.ToInterval(context, pu_);
					CqlDateTime pw_ = context.Operators.End(pv_);

					return pw_;
				};
				IEnumerable<Encounter> cg_ = context.Operators.SortBy<Encounter>(ce_, cf_, System.ComponentModel.ListSortDirection.Ascending);
				Encounter ch_ = context.Operators.Last<Encounter>(cg_);
				Period ci_ = ch_?.Period;
				CqlInterval<CqlDateTime> cj_ = FHIRHelpers_4_3_000.Instance.ToInterval(context, ci_);
				CqlDateTime ck_ = context.Operators.Start(cj_);
				CqlInterval<CqlDateTime> cm_ = FHIRHelpers_4_3_000.Instance.ToInterval(context, bm_);
				CqlDateTime cn_ = context.Operators.Start(cm_);
				CqlInterval<CqlDateTime> co_ = context.Operators.Interval(bq_, ca_ ?? ck_ ?? cn_, true, true);
				bool? cp_ = context.Operators.In<CqlDateTime>(ar_, co_, default);
				IEnumerable<Encounter> cr_ = context.Operators.RetrieveByValueSet<Encounter>(as_, default);
				bool? cs_(Encounter LastED)
				{
					Code<Encounter.EncounterStatus> px_ = LastED?.StatusElement;
					Encounter.EncounterStatus? py_ = px_?.Value;
					Code<Encounter.EncounterStatus> pz_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(py_);
					bool? qa_ = context.Operators.Equal(pz_, "finished");
					Period qb_ = LastED?.Period;
					CqlInterval<CqlDateTime> qc_ = FHIRHelpers_4_3_000.Instance.ToInterval(context, qb_);
					CqlDateTime qd_ = context.Operators.End(qc_);
					CqlValueSet qe_ = this.Observation_Services(context);
					IEnumerable<Encounter> qf_ = context.Operators.RetrieveByValueSet<Encounter>(qe_, default);
					bool? qg_(Encounter LastObs)
					{
						Code<Encounter.EncounterStatus> ry_ = LastObs?.StatusElement;
						Encounter.EncounterStatus? rz_ = ry_?.Value;
						Code<Encounter.EncounterStatus> sa_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(rz_);
						bool? sb_ = context.Operators.Equal(sa_, "finished");
						Period sc_ = LastObs?.Period;
						CqlInterval<CqlDateTime> sd_ = FHIRHelpers_4_3_000.Instance.ToInterval(context, sc_);
						CqlDateTime se_ = context.Operators.End(sd_);
						Period sf_ = Visit?.Period;
						CqlInterval<CqlDateTime> sg_ = FHIRHelpers_4_3_000.Instance.ToInterval(context, sf_);
						CqlDateTime sh_ = context.Operators.Start(sg_);
						CqlQuantity si_ = context.Operators.Quantity(1m, "hour");
						CqlDateTime sj_ = context.Operators.Subtract(sh_, si_);
						CqlInterval<CqlDateTime> sl_ = FHIRHelpers_4_3_000.Instance.ToInterval(context, sf_);
						CqlDateTime sm_ = context.Operators.Start(sl_);
						CqlInterval<CqlDateTime> sn_ = context.Operators.Interval(sj_, sm_, true, true);
						bool? so_ = context.Operators.In<CqlDateTime>(se_, sn_, default);
						CqlInterval<CqlDateTime> sq_ = FHIRHelpers_4_3_000.Instance.ToInterval(context, sf_);
						CqlDateTime sr_ = context.Operators.Start(sq_);
						bool? ss_ = context.Operators.Not((bool?)(sr_ is null));
						bool? st_ = context.Operators.And(so_, ss_);
						bool? su_ = context.Operators.And(sb_, st_);

						return su_;
					};
					IEnumerable<Encounter> qh_ = context.Operators.Where<Encounter>(qf_, qg_);
					object qi_(Encounter @this)
					{
						Period sv_ = @this?.Period;
						CqlInterval<CqlDateTime> sw_ = FHIRHelpers_4_3_000.Instance.ToInterval(context, sv_);
						CqlDateTime sx_ = context.Operators.End(sw_);

						return sx_;
					};
					IEnumerable<Encounter> qj_ = context.Operators.SortBy<Encounter>(qh_, qi_, System.ComponentModel.ListSortDirection.Ascending);
					Encounter qk_ = context.Operators.Last<Encounter>(qj_);
					Period ql_ = qk_?.Period;
					CqlInterval<CqlDateTime> qm_ = FHIRHelpers_4_3_000.Instance.ToInterval(context, ql_);
					CqlDateTime qn_ = context.Operators.Start(qm_);
					Period qo_ = Visit?.Period;
					CqlInterval<CqlDateTime> qp_ = FHIRHelpers_4_3_000.Instance.ToInterval(context, qo_);
					CqlDateTime qq_ = context.Operators.Start(qp_);
					CqlQuantity qr_ = context.Operators.Quantity(1m, "hour");
					CqlDateTime qs_ = context.Operators.Subtract(qn_ ?? qq_, qr_);
					IEnumerable<Encounter> qu_ = context.Operators.RetrieveByValueSet<Encounter>(qe_, default);
					bool? qv_(Encounter LastObs)
					{
						Code<Encounter.EncounterStatus> sy_ = LastObs?.StatusElement;
						Encounter.EncounterStatus? sz_ = sy_?.Value;
						Code<Encounter.EncounterStatus> ta_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(sz_);
						bool? tb_ = context.Operators.Equal(ta_, "finished");
						Period tc_ = LastObs?.Period;
						CqlInterval<CqlDateTime> td_ = FHIRHelpers_4_3_000.Instance.ToInterval(context, tc_);
						CqlDateTime te_ = context.Operators.End(td_);
						Period tf_ = Visit?.Period;
						CqlInterval<CqlDateTime> tg_ = FHIRHelpers_4_3_000.Instance.ToInterval(context, tf_);
						CqlDateTime th_ = context.Operators.Start(tg_);
						CqlQuantity ti_ = context.Operators.Quantity(1m, "hour");
						CqlDateTime tj_ = context.Operators.Subtract(th_, ti_);
						CqlInterval<CqlDateTime> tl_ = FHIRHelpers_4_3_000.Instance.ToInterval(context, tf_);
						CqlDateTime tm_ = context.Operators.Start(tl_);
						CqlInterval<CqlDateTime> tn_ = context.Operators.Interval(tj_, tm_, true, true);
						bool? to_ = context.Operators.In<CqlDateTime>(te_, tn_, default);
						CqlInterval<CqlDateTime> tq_ = FHIRHelpers_4_3_000.Instance.ToInterval(context, tf_);
						CqlDateTime tr_ = context.Operators.Start(tq_);
						bool? ts_ = context.Operators.Not((bool?)(tr_ is null));
						bool? tt_ = context.Operators.And(to_, ts_);
						bool? tu_ = context.Operators.And(tb_, tt_);

						return tu_;
					};
					IEnumerable<Encounter> qw_ = context.Operators.Where<Encounter>(qu_, qv_);
					object qx_(Encounter @this)
					{
						Period tv_ = @this?.Period;
						CqlInterval<CqlDateTime> tw_ = FHIRHelpers_4_3_000.Instance.ToInterval(context, tv_);
						CqlDateTime tx_ = context.Operators.End(tw_);

						return tx_;
					};
					IEnumerable<Encounter> qy_ = context.Operators.SortBy<Encounter>(qw_, qx_, System.ComponentModel.ListSortDirection.Ascending);
					Encounter qz_ = context.Operators.Last<Encounter>(qy_);
					Period ra_ = qz_?.Period;
					CqlInterval<CqlDateTime> rb_ = FHIRHelpers_4_3_000.Instance.ToInterval(context, ra_);
					CqlDateTime rc_ = context.Operators.Start(rb_);
					CqlInterval<CqlDateTime> re_ = FHIRHelpers_4_3_000.Instance.ToInterval(context, qo_);
					CqlDateTime rf_ = context.Operators.Start(re_);
					CqlInterval<CqlDateTime> rg_ = context.Operators.Interval(qs_, rc_ ?? rf_, true, true);
					bool? rh_ = context.Operators.In<CqlDateTime>(qd_, rg_, default);
					IEnumerable<Encounter> rj_ = context.Operators.RetrieveByValueSet<Encounter>(qe_, default);
					bool? rk_(Encounter LastObs)
					{
						Code<Encounter.EncounterStatus> ty_ = LastObs?.StatusElement;
						Encounter.EncounterStatus? tz_ = ty_?.Value;
						Code<Encounter.EncounterStatus> ua_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(tz_);
						bool? ub_ = context.Operators.Equal(ua_, "finished");
						Period uc_ = LastObs?.Period;
						CqlInterval<CqlDateTime> ud_ = FHIRHelpers_4_3_000.Instance.ToInterval(context, uc_);
						CqlDateTime ue_ = context.Operators.End(ud_);
						Period uf_ = Visit?.Period;
						CqlInterval<CqlDateTime> ug_ = FHIRHelpers_4_3_000.Instance.ToInterval(context, uf_);
						CqlDateTime uh_ = context.Operators.Start(ug_);
						CqlQuantity ui_ = context.Operators.Quantity(1m, "hour");
						CqlDateTime uj_ = context.Operators.Subtract(uh_, ui_);
						CqlInterval<CqlDateTime> ul_ = FHIRHelpers_4_3_000.Instance.ToInterval(context, uf_);
						CqlDateTime um_ = context.Operators.Start(ul_);
						CqlInterval<CqlDateTime> un_ = context.Operators.Interval(uj_, um_, true, true);
						bool? uo_ = context.Operators.In<CqlDateTime>(ue_, un_, default);
						CqlInterval<CqlDateTime> uq_ = FHIRHelpers_4_3_000.Instance.ToInterval(context, uf_);
						CqlDateTime ur_ = context.Operators.Start(uq_);
						bool? us_ = context.Operators.Not((bool?)(ur_ is null));
						bool? ut_ = context.Operators.And(uo_, us_);
						bool? uu_ = context.Operators.And(ub_, ut_);

						return uu_;
					};
					IEnumerable<Encounter> rl_ = context.Operators.Where<Encounter>(rj_, rk_);
					object rm_(Encounter @this)
					{
						Period uv_ = @this?.Period;
						CqlInterval<CqlDateTime> uw_ = FHIRHelpers_4_3_000.Instance.ToInterval(context, uv_);
						CqlDateTime ux_ = context.Operators.End(uw_);

						return ux_;
					};
					IEnumerable<Encounter> rn_ = context.Operators.SortBy<Encounter>(rl_, rm_, System.ComponentModel.ListSortDirection.Ascending);
					Encounter ro_ = context.Operators.Last<Encounter>(rn_);
					Period rp_ = ro_?.Period;
					CqlInterval<CqlDateTime> rq_ = FHIRHelpers_4_3_000.Instance.ToInterval(context, rp_);
					CqlDateTime rr_ = context.Operators.Start(rq_);
					CqlInterval<CqlDateTime> rt_ = FHIRHelpers_4_3_000.Instance.ToInterval(context, qo_);
					CqlDateTime ru_ = context.Operators.Start(rt_);
					bool? rv_ = context.Operators.Not((bool?)((rr_ ?? ru_) is null));
					bool? rw_ = context.Operators.And(rh_, rv_);
					bool? rx_ = context.Operators.And(qa_, rw_);

					return rx_;
				};
				IEnumerable<Encounter> ct_ = context.Operators.Where<Encounter>(cr_, cs_);
				object cu_(Encounter @this)
				{
					Period uy_ = @this?.Period;
					CqlInterval<CqlDateTime> uz_ = FHIRHelpers_4_3_000.Instance.ToInterval(context, uy_);
					CqlDateTime va_ = context.Operators.End(uz_);

					return va_;
				};
				IEnumerable<Encounter> cv_ = context.Operators.SortBy<Encounter>(ct_, cu_, System.ComponentModel.ListSortDirection.Ascending);
				Encounter cw_ = context.Operators.Last<Encounter>(cv_);
				Period cx_ = cw_?.Period;
				CqlInterval<CqlDateTime> cy_ = FHIRHelpers_4_3_000.Instance.ToInterval(context, cx_);
				CqlDateTime cz_ = context.Operators.Start(cy_);
				IEnumerable<Encounter> db_ = context.Operators.RetrieveByValueSet<Encounter>(bc_, default);
				bool? dc_(Encounter LastObs)
				{
					Code<Encounter.EncounterStatus> vb_ = LastObs?.StatusElement;
					Encounter.EncounterStatus? vc_ = vb_?.Value;
					Code<Encounter.EncounterStatus> vd_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(vc_);
					bool? ve_ = context.Operators.Equal(vd_, "finished");
					Period vf_ = LastObs?.Period;
					CqlInterval<CqlDateTime> vg_ = FHIRHelpers_4_3_000.Instance.ToInterval(context, vf_);
					CqlDateTime vh_ = context.Operators.End(vg_);
					Period vi_ = Visit?.Period;
					CqlInterval<CqlDateTime> vj_ = FHIRHelpers_4_3_000.Instance.ToInterval(context, vi_);
					CqlDateTime vk_ = context.Operators.Start(vj_);
					CqlQuantity vl_ = context.Operators.Quantity(1m, "hour");
					CqlDateTime vm_ = context.Operators.Subtract(vk_, vl_);
					CqlInterval<CqlDateTime> vo_ = FHIRHelpers_4_3_000.Instance.ToInterval(context, vi_);
					CqlDateTime vp_ = context.Operators.Start(vo_);
					CqlInterval<CqlDateTime> vq_ = context.Operators.Interval(vm_, vp_, true, true);
					bool? vr_ = context.Operators.In<CqlDateTime>(vh_, vq_, default);
					CqlInterval<CqlDateTime> vt_ = FHIRHelpers_4_3_000.Instance.ToInterval(context, vi_);
					CqlDateTime vu_ = context.Operators.Start(vt_);
					bool? vv_ = context.Operators.Not((bool?)(vu_ is null));
					bool? vw_ = context.Operators.And(vr_, vv_);
					bool? vx_ = context.Operators.And(ve_, vw_);

					return vx_;
				};
				IEnumerable<Encounter> dd_ = context.Operators.Where<Encounter>(db_, dc_);
				object de_(Encounter @this)
				{
					Period vy_ = @this?.Period;
					CqlInterval<CqlDateTime> vz_ = FHIRHelpers_4_3_000.Instance.ToInterval(context, vy_);
					CqlDateTime wa_ = context.Operators.End(vz_);

					return wa_;
				};
				IEnumerable<Encounter> df_ = context.Operators.SortBy<Encounter>(dd_, de_, System.ComponentModel.ListSortDirection.Ascending);
				Encounter dg_ = context.Operators.Last<Encounter>(df_);
				Period dh_ = dg_?.Period;
				CqlInterval<CqlDateTime> di_ = FHIRHelpers_4_3_000.Instance.ToInterval(context, dh_);
				CqlDateTime dj_ = context.Operators.Start(di_);
				CqlInterval<CqlDateTime> dl_ = FHIRHelpers_4_3_000.Instance.ToInterval(context, bm_);
				CqlDateTime dm_ = context.Operators.Start(dl_);
				bool? dn_ = context.Operators.Not((bool?)((cz_ ?? dj_ ?? dm_) is null));
				bool? do_ = context.Operators.And(cp_, dn_);

				return do_;
			};
			IEnumerable<Encounter> h_ = context.Operators.Where<Encounter>(f_, g_);
			object i_(Encounter @this)
			{
				Period wb_ = @this?.Period;
				CqlInterval<CqlDateTime> wc_ = FHIRHelpers_4_3_000.Instance.ToInterval(context, wb_);
				CqlDateTime wd_ = context.Operators.End(wc_);

				return wd_;
			};
			IEnumerable<Encounter> j_ = context.Operators.SortBy<Encounter>(h_, i_, System.ComponentModel.ListSortDirection.Ascending);
			Encounter k_ = context.Operators.Last<Encounter>(j_);
			Period l_ = k_?.Period;
			CqlInterval<CqlDateTime> m_ = FHIRHelpers_4_3_000.Instance.ToInterval(context, l_);
			CqlDateTime n_ = context.Operators.Start(m_);
			CqlValueSet o_ = this.Emergency_Department_Visit(context);
			IEnumerable<Encounter> p_ = context.Operators.RetrieveByValueSet<Encounter>(o_, default);
			bool? q_(Encounter LastED)
			{
				Code<Encounter.EncounterStatus> we_ = LastED?.StatusElement;
				Encounter.EncounterStatus? wf_ = we_?.Value;
				Code<Encounter.EncounterStatus> wg_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(wf_);
				bool? wh_ = context.Operators.Equal(wg_, "finished");
				Period wi_ = LastED?.Period;
				CqlInterval<CqlDateTime> wj_ = FHIRHelpers_4_3_000.Instance.ToInterval(context, wi_);
				CqlDateTime wk_ = context.Operators.End(wj_);
				CqlValueSet wl_ = this.Observation_Services(context);
				IEnumerable<Encounter> wm_ = context.Operators.RetrieveByValueSet<Encounter>(wl_, default);
				bool? wn_(Encounter LastObs)
				{
					Code<Encounter.EncounterStatus> yf_ = LastObs?.StatusElement;
					Encounter.EncounterStatus? yg_ = yf_?.Value;
					Code<Encounter.EncounterStatus> yh_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(yg_);
					bool? yi_ = context.Operators.Equal(yh_, "finished");
					Period yj_ = LastObs?.Period;
					CqlInterval<CqlDateTime> yk_ = FHIRHelpers_4_3_000.Instance.ToInterval(context, yj_);
					CqlDateTime yl_ = context.Operators.End(yk_);
					Period ym_ = Visit?.Period;
					CqlInterval<CqlDateTime> yn_ = FHIRHelpers_4_3_000.Instance.ToInterval(context, ym_);
					CqlDateTime yo_ = context.Operators.Start(yn_);
					CqlQuantity yp_ = context.Operators.Quantity(1m, "hour");
					CqlDateTime yq_ = context.Operators.Subtract(yo_, yp_);
					CqlInterval<CqlDateTime> ys_ = FHIRHelpers_4_3_000.Instance.ToInterval(context, ym_);
					CqlDateTime yt_ = context.Operators.Start(ys_);
					CqlInterval<CqlDateTime> yu_ = context.Operators.Interval(yq_, yt_, true, true);
					bool? yv_ = context.Operators.In<CqlDateTime>(yl_, yu_, default);
					CqlInterval<CqlDateTime> yx_ = FHIRHelpers_4_3_000.Instance.ToInterval(context, ym_);
					CqlDateTime yy_ = context.Operators.Start(yx_);
					bool? yz_ = context.Operators.Not((bool?)(yy_ is null));
					bool? za_ = context.Operators.And(yv_, yz_);
					bool? zb_ = context.Operators.And(yi_, za_);

					return zb_;
				};
				IEnumerable<Encounter> wo_ = context.Operators.Where<Encounter>(wm_, wn_);
				object wp_(Encounter @this)
				{
					Period zc_ = @this?.Period;
					CqlInterval<CqlDateTime> zd_ = FHIRHelpers_4_3_000.Instance.ToInterval(context, zc_);
					CqlDateTime ze_ = context.Operators.End(zd_);

					return ze_;
				};
				IEnumerable<Encounter> wq_ = context.Operators.SortBy<Encounter>(wo_, wp_, System.ComponentModel.ListSortDirection.Ascending);
				Encounter wr_ = context.Operators.Last<Encounter>(wq_);
				Period ws_ = wr_?.Period;
				CqlInterval<CqlDateTime> wt_ = FHIRHelpers_4_3_000.Instance.ToInterval(context, ws_);
				CqlDateTime wu_ = context.Operators.Start(wt_);
				Period wv_ = Visit?.Period;
				CqlInterval<CqlDateTime> ww_ = FHIRHelpers_4_3_000.Instance.ToInterval(context, wv_);
				CqlDateTime wx_ = context.Operators.Start(ww_);
				CqlQuantity wy_ = context.Operators.Quantity(1m, "hour");
				CqlDateTime wz_ = context.Operators.Subtract(wu_ ?? wx_, wy_);
				IEnumerable<Encounter> xb_ = context.Operators.RetrieveByValueSet<Encounter>(wl_, default);
				bool? xc_(Encounter LastObs)
				{
					Code<Encounter.EncounterStatus> zf_ = LastObs?.StatusElement;
					Encounter.EncounterStatus? zg_ = zf_?.Value;
					Code<Encounter.EncounterStatus> zh_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(zg_);
					bool? zi_ = context.Operators.Equal(zh_, "finished");
					Period zj_ = LastObs?.Period;
					CqlInterval<CqlDateTime> zk_ = FHIRHelpers_4_3_000.Instance.ToInterval(context, zj_);
					CqlDateTime zl_ = context.Operators.End(zk_);
					Period zm_ = Visit?.Period;
					CqlInterval<CqlDateTime> zn_ = FHIRHelpers_4_3_000.Instance.ToInterval(context, zm_);
					CqlDateTime zo_ = context.Operators.Start(zn_);
					CqlQuantity zp_ = context.Operators.Quantity(1m, "hour");
					CqlDateTime zq_ = context.Operators.Subtract(zo_, zp_);
					CqlInterval<CqlDateTime> zs_ = FHIRHelpers_4_3_000.Instance.ToInterval(context, zm_);
					CqlDateTime zt_ = context.Operators.Start(zs_);
					CqlInterval<CqlDateTime> zu_ = context.Operators.Interval(zq_, zt_, true, true);
					bool? zv_ = context.Operators.In<CqlDateTime>(zl_, zu_, default);
					CqlInterval<CqlDateTime> zx_ = FHIRHelpers_4_3_000.Instance.ToInterval(context, zm_);
					CqlDateTime zy_ = context.Operators.Start(zx_);
					bool? zz_ = context.Operators.Not((bool?)(zy_ is null));
					bool? aza_ = context.Operators.And(zv_, zz_);
					bool? azb_ = context.Operators.And(zi_, aza_);

					return azb_;
				};
				IEnumerable<Encounter> xd_ = context.Operators.Where<Encounter>(xb_, xc_);
				object xe_(Encounter @this)
				{
					Period azc_ = @this?.Period;
					CqlInterval<CqlDateTime> azd_ = FHIRHelpers_4_3_000.Instance.ToInterval(context, azc_);
					CqlDateTime aze_ = context.Operators.End(azd_);

					return aze_;
				};
				IEnumerable<Encounter> xf_ = context.Operators.SortBy<Encounter>(xd_, xe_, System.ComponentModel.ListSortDirection.Ascending);
				Encounter xg_ = context.Operators.Last<Encounter>(xf_);
				Period xh_ = xg_?.Period;
				CqlInterval<CqlDateTime> xi_ = FHIRHelpers_4_3_000.Instance.ToInterval(context, xh_);
				CqlDateTime xj_ = context.Operators.Start(xi_);
				CqlInterval<CqlDateTime> xl_ = FHIRHelpers_4_3_000.Instance.ToInterval(context, wv_);
				CqlDateTime xm_ = context.Operators.Start(xl_);
				CqlInterval<CqlDateTime> xn_ = context.Operators.Interval(wz_, xj_ ?? xm_, true, true);
				bool? xo_ = context.Operators.In<CqlDateTime>(wk_, xn_, default);
				IEnumerable<Encounter> xq_ = context.Operators.RetrieveByValueSet<Encounter>(wl_, default);
				bool? xr_(Encounter LastObs)
				{
					Code<Encounter.EncounterStatus> azf_ = LastObs?.StatusElement;
					Encounter.EncounterStatus? azg_ = azf_?.Value;
					Code<Encounter.EncounterStatus> azh_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(azg_);
					bool? azi_ = context.Operators.Equal(azh_, "finished");
					Period azj_ = LastObs?.Period;
					CqlInterval<CqlDateTime> azk_ = FHIRHelpers_4_3_000.Instance.ToInterval(context, azj_);
					CqlDateTime azl_ = context.Operators.End(azk_);
					Period azm_ = Visit?.Period;
					CqlInterval<CqlDateTime> azn_ = FHIRHelpers_4_3_000.Instance.ToInterval(context, azm_);
					CqlDateTime azo_ = context.Operators.Start(azn_);
					CqlQuantity azp_ = context.Operators.Quantity(1m, "hour");
					CqlDateTime azq_ = context.Operators.Subtract(azo_, azp_);
					CqlInterval<CqlDateTime> azs_ = FHIRHelpers_4_3_000.Instance.ToInterval(context, azm_);
					CqlDateTime azt_ = context.Operators.Start(azs_);
					CqlInterval<CqlDateTime> azu_ = context.Operators.Interval(azq_, azt_, true, true);
					bool? azv_ = context.Operators.In<CqlDateTime>(azl_, azu_, default);
					CqlInterval<CqlDateTime> azx_ = FHIRHelpers_4_3_000.Instance.ToInterval(context, azm_);
					CqlDateTime azy_ = context.Operators.Start(azx_);
					bool? azz_ = context.Operators.Not((bool?)(azy_ is null));
					bool? bza_ = context.Operators.And(azv_, azz_);
					bool? bzb_ = context.Operators.And(azi_, bza_);

					return bzb_;
				};
				IEnumerable<Encounter> xs_ = context.Operators.Where<Encounter>(xq_, xr_);
				object xt_(Encounter @this)
				{
					Period bzc_ = @this?.Period;
					CqlInterval<CqlDateTime> bzd_ = FHIRHelpers_4_3_000.Instance.ToInterval(context, bzc_);
					CqlDateTime bze_ = context.Operators.End(bzd_);

					return bze_;
				};
				IEnumerable<Encounter> xu_ = context.Operators.SortBy<Encounter>(xs_, xt_, System.ComponentModel.ListSortDirection.Ascending);
				Encounter xv_ = context.Operators.Last<Encounter>(xu_);
				Period xw_ = xv_?.Period;
				CqlInterval<CqlDateTime> xx_ = FHIRHelpers_4_3_000.Instance.ToInterval(context, xw_);
				CqlDateTime xy_ = context.Operators.Start(xx_);
				CqlInterval<CqlDateTime> ya_ = FHIRHelpers_4_3_000.Instance.ToInterval(context, wv_);
				CqlDateTime yb_ = context.Operators.Start(ya_);
				bool? yc_ = context.Operators.Not((bool?)((xy_ ?? yb_) is null));
				bool? yd_ = context.Operators.And(xo_, yc_);
				bool? ye_ = context.Operators.And(wh_, yd_);

				return ye_;
			};
			IEnumerable<Encounter> r_ = context.Operators.Where<Encounter>(p_, q_);
			object s_(Encounter @this)
			{
				Period bzf_ = @this?.Period;
				CqlInterval<CqlDateTime> bzg_ = FHIRHelpers_4_3_000.Instance.ToInterval(context, bzf_);
				CqlDateTime bzh_ = context.Operators.End(bzg_);

				return bzh_;
			};
			IEnumerable<Encounter> t_ = context.Operators.SortBy<Encounter>(r_, s_, System.ComponentModel.ListSortDirection.Ascending);
			Encounter u_ = context.Operators.Last<Encounter>(t_);
			Period v_ = u_?.Period;
			CqlInterval<CqlDateTime> w_ = FHIRHelpers_4_3_000.Instance.ToInterval(context, v_);
			CqlDateTime x_ = context.Operators.Start(w_);
			CqlValueSet y_ = this.Observation_Services(context);
			IEnumerable<Encounter> z_ = context.Operators.RetrieveByValueSet<Encounter>(y_, default);
			bool? aa_(Encounter LastObs)
			{
				Code<Encounter.EncounterStatus> bzi_ = LastObs?.StatusElement;
				Encounter.EncounterStatus? bzj_ = bzi_?.Value;
				Code<Encounter.EncounterStatus> bzk_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(bzj_);
				bool? bzl_ = context.Operators.Equal(bzk_, "finished");
				Period bzm_ = LastObs?.Period;
				CqlInterval<CqlDateTime> bzn_ = FHIRHelpers_4_3_000.Instance.ToInterval(context, bzm_);
				CqlDateTime bzo_ = context.Operators.End(bzn_);
				Period bzp_ = Visit?.Period;
				CqlInterval<CqlDateTime> bzq_ = FHIRHelpers_4_3_000.Instance.ToInterval(context, bzp_);
				CqlDateTime bzr_ = context.Operators.Start(bzq_);
				CqlQuantity bzs_ = context.Operators.Quantity(1m, "hour");
				CqlDateTime bzt_ = context.Operators.Subtract(bzr_, bzs_);
				CqlInterval<CqlDateTime> bzv_ = FHIRHelpers_4_3_000.Instance.ToInterval(context, bzp_);
				CqlDateTime bzw_ = context.Operators.Start(bzv_);
				CqlInterval<CqlDateTime> bzx_ = context.Operators.Interval(bzt_, bzw_, true, true);
				bool? bzy_ = context.Operators.In<CqlDateTime>(bzo_, bzx_, default);
				CqlInterval<CqlDateTime> cza_ = FHIRHelpers_4_3_000.Instance.ToInterval(context, bzp_);
				CqlDateTime czb_ = context.Operators.Start(cza_);
				bool? czc_ = context.Operators.Not((bool?)(czb_ is null));
				bool? czd_ = context.Operators.And(bzy_, czc_);
				bool? cze_ = context.Operators.And(bzl_, czd_);

				return cze_;
			};
			IEnumerable<Encounter> ab_ = context.Operators.Where<Encounter>(z_, aa_);
			object ac_(Encounter @this)
			{
				Period czf_ = @this?.Period;
				CqlInterval<CqlDateTime> czg_ = FHIRHelpers_4_3_000.Instance.ToInterval(context, czf_);
				CqlDateTime czh_ = context.Operators.End(czg_);

				return czh_;
			};
			IEnumerable<Encounter> ad_ = context.Operators.SortBy<Encounter>(ab_, ac_, System.ComponentModel.ListSortDirection.Ascending);
			Encounter ae_ = context.Operators.Last<Encounter>(ad_);
			Period af_ = ae_?.Period;
			CqlInterval<CqlDateTime> ag_ = FHIRHelpers_4_3_000.Instance.ToInterval(context, af_);
			CqlDateTime ah_ = context.Operators.Start(ag_);
			Period ai_ = Visit?.Period;
			CqlInterval<CqlDateTime> aj_ = FHIRHelpers_4_3_000.Instance.ToInterval(context, ai_);
			CqlDateTime ak_ = context.Operators.Start(aj_);
			CqlInterval<CqlDateTime> am_ = FHIRHelpers_4_3_000.Instance.ToInterval(context, ai_);
			CqlDateTime an_ = context.Operators.End(am_);
			CqlInterval<CqlDateTime> ao_ = context.Operators.Interval(n_ ?? x_ ?? ah_ ?? ak_, an_, true, true);

			return ao_;
		};
		IEnumerable<CqlInterval<CqlDateTime>> c_ = context.Operators.Select<Encounter, CqlInterval<CqlDateTime>>((IEnumerable<Encounter>)a_, b_);
		CqlInterval<CqlDateTime> d_ = context.Operators.SingletonFrom<CqlInterval<CqlDateTime>>(c_);

		return d_;
	}

	public CqlInterval<CqlDateTime> hospitalizationWithObservationAndOutpatientSurgeryService(CqlContext context, Encounter TheEncounter)
	{
		Encounter[] a_ = [
			TheEncounter,
		];
		CqlInterval<CqlDateTime> b_(Encounter Visit)
		{
			CqlValueSet e_ = this.Outpatient_Surgery_Service(context);
			IEnumerable<Encounter> f_ = context.Operators.RetrieveByValueSet<Encounter>(e_, default);
			bool? g_(Encounter LastSurgeryOP)
			{
				Period ap_ = LastSurgeryOP?.Period;
				CqlInterval<CqlDateTime> aq_ = FHIRHelpers_4_3_000.Instance.ToInterval(context, ap_);
				CqlDateTime ar_ = context.Operators.End(aq_);
				CqlValueSet as_ = this.Emergency_Department_Visit(context);
				IEnumerable<Encounter> at_ = context.Operators.RetrieveByValueSet<Encounter>(as_, default);
				bool? au_(Encounter LastED)
				{
					Code<Encounter.EncounterStatus> dp_ = LastED?.StatusElement;
					Encounter.EncounterStatus? dq_ = dp_?.Value;
					Code<Encounter.EncounterStatus> dr_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(dq_);
					bool? ds_ = context.Operators.Equal(dr_, "finished");
					Period dt_ = LastED?.Period;
					CqlInterval<CqlDateTime> du_ = FHIRHelpers_4_3_000.Instance.ToInterval(context, dt_);
					CqlDateTime dv_ = context.Operators.End(du_);
					CqlValueSet dw_ = this.Observation_Services(context);
					IEnumerable<Encounter> dx_ = context.Operators.RetrieveByValueSet<Encounter>(dw_, default);
					bool? dy_(Encounter LastObs)
					{
						Code<Encounter.EncounterStatus> fq_ = LastObs?.StatusElement;
						Encounter.EncounterStatus? fr_ = fq_?.Value;
						Code<Encounter.EncounterStatus> fs_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(fr_);
						bool? ft_ = context.Operators.Equal(fs_, "finished");
						Period fu_ = LastObs?.Period;
						CqlInterval<CqlDateTime> fv_ = FHIRHelpers_4_3_000.Instance.ToInterval(context, fu_);
						CqlDateTime fw_ = context.Operators.End(fv_);
						Period fx_ = Visit?.Period;
						CqlInterval<CqlDateTime> fy_ = FHIRHelpers_4_3_000.Instance.ToInterval(context, fx_);
						CqlDateTime fz_ = context.Operators.Start(fy_);
						CqlQuantity ga_ = context.Operators.Quantity(1m, "hour");
						CqlDateTime gb_ = context.Operators.Subtract(fz_, ga_);
						CqlInterval<CqlDateTime> gd_ = FHIRHelpers_4_3_000.Instance.ToInterval(context, fx_);
						CqlDateTime ge_ = context.Operators.Start(gd_);
						CqlInterval<CqlDateTime> gf_ = context.Operators.Interval(gb_, ge_, true, true);
						bool? gg_ = context.Operators.In<CqlDateTime>(fw_, gf_, default);
						CqlInterval<CqlDateTime> gi_ = FHIRHelpers_4_3_000.Instance.ToInterval(context, fx_);
						CqlDateTime gj_ = context.Operators.Start(gi_);
						bool? gk_ = context.Operators.Not((bool?)(gj_ is null));
						bool? gl_ = context.Operators.And(gg_, gk_);
						bool? gm_ = context.Operators.And(ft_, gl_);

						return gm_;
					};
					IEnumerable<Encounter> dz_ = context.Operators.Where<Encounter>(dx_, dy_);
					object ea_(Encounter @this)
					{
						Period gn_ = @this?.Period;
						CqlInterval<CqlDateTime> go_ = FHIRHelpers_4_3_000.Instance.ToInterval(context, gn_);
						CqlDateTime gp_ = context.Operators.End(go_);

						return gp_;
					};
					IEnumerable<Encounter> eb_ = context.Operators.SortBy<Encounter>(dz_, ea_, System.ComponentModel.ListSortDirection.Ascending);
					Encounter ec_ = context.Operators.Last<Encounter>(eb_);
					Period ed_ = ec_?.Period;
					CqlInterval<CqlDateTime> ee_ = FHIRHelpers_4_3_000.Instance.ToInterval(context, ed_);
					CqlDateTime ef_ = context.Operators.Start(ee_);
					Period eg_ = Visit?.Period;
					CqlInterval<CqlDateTime> eh_ = FHIRHelpers_4_3_000.Instance.ToInterval(context, eg_);
					CqlDateTime ei_ = context.Operators.Start(eh_);
					CqlQuantity ej_ = context.Operators.Quantity(1m, "hour");
					CqlDateTime ek_ = context.Operators.Subtract(ef_ ?? ei_, ej_);
					IEnumerable<Encounter> em_ = context.Operators.RetrieveByValueSet<Encounter>(dw_, default);
					bool? en_(Encounter LastObs)
					{
						Code<Encounter.EncounterStatus> gq_ = LastObs?.StatusElement;
						Encounter.EncounterStatus? gr_ = gq_?.Value;
						Code<Encounter.EncounterStatus> gs_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(gr_);
						bool? gt_ = context.Operators.Equal(gs_, "finished");
						Period gu_ = LastObs?.Period;
						CqlInterval<CqlDateTime> gv_ = FHIRHelpers_4_3_000.Instance.ToInterval(context, gu_);
						CqlDateTime gw_ = context.Operators.End(gv_);
						Period gx_ = Visit?.Period;
						CqlInterval<CqlDateTime> gy_ = FHIRHelpers_4_3_000.Instance.ToInterval(context, gx_);
						CqlDateTime gz_ = context.Operators.Start(gy_);
						CqlQuantity ha_ = context.Operators.Quantity(1m, "hour");
						CqlDateTime hb_ = context.Operators.Subtract(gz_, ha_);
						CqlInterval<CqlDateTime> hd_ = FHIRHelpers_4_3_000.Instance.ToInterval(context, gx_);
						CqlDateTime he_ = context.Operators.Start(hd_);
						CqlInterval<CqlDateTime> hf_ = context.Operators.Interval(hb_, he_, true, true);
						bool? hg_ = context.Operators.In<CqlDateTime>(gw_, hf_, default);
						CqlInterval<CqlDateTime> hi_ = FHIRHelpers_4_3_000.Instance.ToInterval(context, gx_);
						CqlDateTime hj_ = context.Operators.Start(hi_);
						bool? hk_ = context.Operators.Not((bool?)(hj_ is null));
						bool? hl_ = context.Operators.And(hg_, hk_);
						bool? hm_ = context.Operators.And(gt_, hl_);

						return hm_;
					};
					IEnumerable<Encounter> eo_ = context.Operators.Where<Encounter>(em_, en_);
					object ep_(Encounter @this)
					{
						Period hn_ = @this?.Period;
						CqlInterval<CqlDateTime> ho_ = FHIRHelpers_4_3_000.Instance.ToInterval(context, hn_);
						CqlDateTime hp_ = context.Operators.End(ho_);

						return hp_;
					};
					IEnumerable<Encounter> eq_ = context.Operators.SortBy<Encounter>(eo_, ep_, System.ComponentModel.ListSortDirection.Ascending);
					Encounter er_ = context.Operators.Last<Encounter>(eq_);
					Period es_ = er_?.Period;
					CqlInterval<CqlDateTime> et_ = FHIRHelpers_4_3_000.Instance.ToInterval(context, es_);
					CqlDateTime eu_ = context.Operators.Start(et_);
					CqlInterval<CqlDateTime> ew_ = FHIRHelpers_4_3_000.Instance.ToInterval(context, eg_);
					CqlDateTime ex_ = context.Operators.Start(ew_);
					CqlInterval<CqlDateTime> ey_ = context.Operators.Interval(ek_, eu_ ?? ex_, true, true);
					bool? ez_ = context.Operators.In<CqlDateTime>(dv_, ey_, default);
					IEnumerable<Encounter> fb_ = context.Operators.RetrieveByValueSet<Encounter>(dw_, default);
					bool? fc_(Encounter LastObs)
					{
						Code<Encounter.EncounterStatus> hq_ = LastObs?.StatusElement;
						Encounter.EncounterStatus? hr_ = hq_?.Value;
						Code<Encounter.EncounterStatus> hs_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(hr_);
						bool? ht_ = context.Operators.Equal(hs_, "finished");
						Period hu_ = LastObs?.Period;
						CqlInterval<CqlDateTime> hv_ = FHIRHelpers_4_3_000.Instance.ToInterval(context, hu_);
						CqlDateTime hw_ = context.Operators.End(hv_);
						Period hx_ = Visit?.Period;
						CqlInterval<CqlDateTime> hy_ = FHIRHelpers_4_3_000.Instance.ToInterval(context, hx_);
						CqlDateTime hz_ = context.Operators.Start(hy_);
						CqlQuantity ia_ = context.Operators.Quantity(1m, "hour");
						CqlDateTime ib_ = context.Operators.Subtract(hz_, ia_);
						CqlInterval<CqlDateTime> id_ = FHIRHelpers_4_3_000.Instance.ToInterval(context, hx_);
						CqlDateTime ie_ = context.Operators.Start(id_);
						CqlInterval<CqlDateTime> if_ = context.Operators.Interval(ib_, ie_, true, true);
						bool? ig_ = context.Operators.In<CqlDateTime>(hw_, if_, default);
						CqlInterval<CqlDateTime> ii_ = FHIRHelpers_4_3_000.Instance.ToInterval(context, hx_);
						CqlDateTime ij_ = context.Operators.Start(ii_);
						bool? ik_ = context.Operators.Not((bool?)(ij_ is null));
						bool? il_ = context.Operators.And(ig_, ik_);
						bool? im_ = context.Operators.And(ht_, il_);

						return im_;
					};
					IEnumerable<Encounter> fd_ = context.Operators.Where<Encounter>(fb_, fc_);
					object fe_(Encounter @this)
					{
						Period in_ = @this?.Period;
						CqlInterval<CqlDateTime> io_ = FHIRHelpers_4_3_000.Instance.ToInterval(context, in_);
						CqlDateTime ip_ = context.Operators.End(io_);

						return ip_;
					};
					IEnumerable<Encounter> ff_ = context.Operators.SortBy<Encounter>(fd_, fe_, System.ComponentModel.ListSortDirection.Ascending);
					Encounter fg_ = context.Operators.Last<Encounter>(ff_);
					Period fh_ = fg_?.Period;
					CqlInterval<CqlDateTime> fi_ = FHIRHelpers_4_3_000.Instance.ToInterval(context, fh_);
					CqlDateTime fj_ = context.Operators.Start(fi_);
					CqlInterval<CqlDateTime> fl_ = FHIRHelpers_4_3_000.Instance.ToInterval(context, eg_);
					CqlDateTime fm_ = context.Operators.Start(fl_);
					bool? fn_ = context.Operators.Not((bool?)((fj_ ?? fm_) is null));
					bool? fo_ = context.Operators.And(ez_, fn_);
					bool? fp_ = context.Operators.And(ds_, fo_);

					return fp_;
				};
				IEnumerable<Encounter> av_ = context.Operators.Where<Encounter>(at_, au_);
				object aw_(Encounter @this)
				{
					Period iq_ = @this?.Period;
					CqlInterval<CqlDateTime> ir_ = FHIRHelpers_4_3_000.Instance.ToInterval(context, iq_);
					CqlDateTime is_ = context.Operators.End(ir_);

					return is_;
				};
				IEnumerable<Encounter> ax_ = context.Operators.SortBy<Encounter>(av_, aw_, System.ComponentModel.ListSortDirection.Ascending);
				Encounter ay_ = context.Operators.Last<Encounter>(ax_);
				Period az_ = ay_?.Period;
				CqlInterval<CqlDateTime> ba_ = FHIRHelpers_4_3_000.Instance.ToInterval(context, az_);
				CqlDateTime bb_ = context.Operators.Start(ba_);
				CqlValueSet bc_ = this.Observation_Services(context);
				IEnumerable<Encounter> bd_ = context.Operators.RetrieveByValueSet<Encounter>(bc_, default);
				bool? be_(Encounter LastObs)
				{
					Code<Encounter.EncounterStatus> it_ = LastObs?.StatusElement;
					Encounter.EncounterStatus? iu_ = it_?.Value;
					Code<Encounter.EncounterStatus> iv_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(iu_);
					bool? iw_ = context.Operators.Equal(iv_, "finished");
					Period ix_ = LastObs?.Period;
					CqlInterval<CqlDateTime> iy_ = FHIRHelpers_4_3_000.Instance.ToInterval(context, ix_);
					CqlDateTime iz_ = context.Operators.End(iy_);
					Period ja_ = Visit?.Period;
					CqlInterval<CqlDateTime> jb_ = FHIRHelpers_4_3_000.Instance.ToInterval(context, ja_);
					CqlDateTime jc_ = context.Operators.Start(jb_);
					CqlQuantity jd_ = context.Operators.Quantity(1m, "hour");
					CqlDateTime je_ = context.Operators.Subtract(jc_, jd_);
					CqlInterval<CqlDateTime> jg_ = FHIRHelpers_4_3_000.Instance.ToInterval(context, ja_);
					CqlDateTime jh_ = context.Operators.Start(jg_);
					CqlInterval<CqlDateTime> ji_ = context.Operators.Interval(je_, jh_, true, true);
					bool? jj_ = context.Operators.In<CqlDateTime>(iz_, ji_, default);
					CqlInterval<CqlDateTime> jl_ = FHIRHelpers_4_3_000.Instance.ToInterval(context, ja_);
					CqlDateTime jm_ = context.Operators.Start(jl_);
					bool? jn_ = context.Operators.Not((bool?)(jm_ is null));
					bool? jo_ = context.Operators.And(jj_, jn_);
					bool? jp_ = context.Operators.And(iw_, jo_);

					return jp_;
				};
				IEnumerable<Encounter> bf_ = context.Operators.Where<Encounter>(bd_, be_);
				object bg_(Encounter @this)
				{
					Period jq_ = @this?.Period;
					CqlInterval<CqlDateTime> jr_ = FHIRHelpers_4_3_000.Instance.ToInterval(context, jq_);
					CqlDateTime js_ = context.Operators.End(jr_);

					return js_;
				};
				IEnumerable<Encounter> bh_ = context.Operators.SortBy<Encounter>(bf_, bg_, System.ComponentModel.ListSortDirection.Ascending);
				Encounter bi_ = context.Operators.Last<Encounter>(bh_);
				Period bj_ = bi_?.Period;
				CqlInterval<CqlDateTime> bk_ = FHIRHelpers_4_3_000.Instance.ToInterval(context, bj_);
				CqlDateTime bl_ = context.Operators.Start(bk_);
				Period bm_ = Visit?.Period;
				CqlInterval<CqlDateTime> bn_ = FHIRHelpers_4_3_000.Instance.ToInterval(context, bm_);
				CqlDateTime bo_ = context.Operators.Start(bn_);
				CqlQuantity bp_ = context.Operators.Quantity(1m, "hour");
				CqlDateTime bq_ = context.Operators.Subtract(bb_ ?? bl_ ?? bo_, bp_);
				IEnumerable<Encounter> bs_ = context.Operators.RetrieveByValueSet<Encounter>(as_, default);
				bool? bt_(Encounter LastED)
				{
					Code<Encounter.EncounterStatus> jt_ = LastED?.StatusElement;
					Encounter.EncounterStatus? ju_ = jt_?.Value;
					Code<Encounter.EncounterStatus> jv_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(ju_);
					bool? jw_ = context.Operators.Equal(jv_, "finished");
					Period jx_ = LastED?.Period;
					CqlInterval<CqlDateTime> jy_ = FHIRHelpers_4_3_000.Instance.ToInterval(context, jx_);
					CqlDateTime jz_ = context.Operators.End(jy_);
					CqlValueSet ka_ = this.Observation_Services(context);
					IEnumerable<Encounter> kb_ = context.Operators.RetrieveByValueSet<Encounter>(ka_, default);
					bool? kc_(Encounter LastObs)
					{
						Code<Encounter.EncounterStatus> lu_ = LastObs?.StatusElement;
						Encounter.EncounterStatus? lv_ = lu_?.Value;
						Code<Encounter.EncounterStatus> lw_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(lv_);
						bool? lx_ = context.Operators.Equal(lw_, "finished");
						Period ly_ = LastObs?.Period;
						CqlInterval<CqlDateTime> lz_ = FHIRHelpers_4_3_000.Instance.ToInterval(context, ly_);
						CqlDateTime ma_ = context.Operators.End(lz_);
						Period mb_ = Visit?.Period;
						CqlInterval<CqlDateTime> mc_ = FHIRHelpers_4_3_000.Instance.ToInterval(context, mb_);
						CqlDateTime md_ = context.Operators.Start(mc_);
						CqlQuantity me_ = context.Operators.Quantity(1m, "hour");
						CqlDateTime mf_ = context.Operators.Subtract(md_, me_);
						CqlInterval<CqlDateTime> mh_ = FHIRHelpers_4_3_000.Instance.ToInterval(context, mb_);
						CqlDateTime mi_ = context.Operators.Start(mh_);
						CqlInterval<CqlDateTime> mj_ = context.Operators.Interval(mf_, mi_, true, true);
						bool? mk_ = context.Operators.In<CqlDateTime>(ma_, mj_, default);
						CqlInterval<CqlDateTime> mm_ = FHIRHelpers_4_3_000.Instance.ToInterval(context, mb_);
						CqlDateTime mn_ = context.Operators.Start(mm_);
						bool? mo_ = context.Operators.Not((bool?)(mn_ is null));
						bool? mp_ = context.Operators.And(mk_, mo_);
						bool? mq_ = context.Operators.And(lx_, mp_);

						return mq_;
					};
					IEnumerable<Encounter> kd_ = context.Operators.Where<Encounter>(kb_, kc_);
					object ke_(Encounter @this)
					{
						Period mr_ = @this?.Period;
						CqlInterval<CqlDateTime> ms_ = FHIRHelpers_4_3_000.Instance.ToInterval(context, mr_);
						CqlDateTime mt_ = context.Operators.End(ms_);

						return mt_;
					};
					IEnumerable<Encounter> kf_ = context.Operators.SortBy<Encounter>(kd_, ke_, System.ComponentModel.ListSortDirection.Ascending);
					Encounter kg_ = context.Operators.Last<Encounter>(kf_);
					Period kh_ = kg_?.Period;
					CqlInterval<CqlDateTime> ki_ = FHIRHelpers_4_3_000.Instance.ToInterval(context, kh_);
					CqlDateTime kj_ = context.Operators.Start(ki_);
					Period kk_ = Visit?.Period;
					CqlInterval<CqlDateTime> kl_ = FHIRHelpers_4_3_000.Instance.ToInterval(context, kk_);
					CqlDateTime km_ = context.Operators.Start(kl_);
					CqlQuantity kn_ = context.Operators.Quantity(1m, "hour");
					CqlDateTime ko_ = context.Operators.Subtract(kj_ ?? km_, kn_);
					IEnumerable<Encounter> kq_ = context.Operators.RetrieveByValueSet<Encounter>(ka_, default);
					bool? kr_(Encounter LastObs)
					{
						Code<Encounter.EncounterStatus> mu_ = LastObs?.StatusElement;
						Encounter.EncounterStatus? mv_ = mu_?.Value;
						Code<Encounter.EncounterStatus> mw_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(mv_);
						bool? mx_ = context.Operators.Equal(mw_, "finished");
						Period my_ = LastObs?.Period;
						CqlInterval<CqlDateTime> mz_ = FHIRHelpers_4_3_000.Instance.ToInterval(context, my_);
						CqlDateTime na_ = context.Operators.End(mz_);
						Period nb_ = Visit?.Period;
						CqlInterval<CqlDateTime> nc_ = FHIRHelpers_4_3_000.Instance.ToInterval(context, nb_);
						CqlDateTime nd_ = context.Operators.Start(nc_);
						CqlQuantity ne_ = context.Operators.Quantity(1m, "hour");
						CqlDateTime nf_ = context.Operators.Subtract(nd_, ne_);
						CqlInterval<CqlDateTime> nh_ = FHIRHelpers_4_3_000.Instance.ToInterval(context, nb_);
						CqlDateTime ni_ = context.Operators.Start(nh_);
						CqlInterval<CqlDateTime> nj_ = context.Operators.Interval(nf_, ni_, true, true);
						bool? nk_ = context.Operators.In<CqlDateTime>(na_, nj_, default);
						CqlInterval<CqlDateTime> nm_ = FHIRHelpers_4_3_000.Instance.ToInterval(context, nb_);
						CqlDateTime nn_ = context.Operators.Start(nm_);
						bool? no_ = context.Operators.Not((bool?)(nn_ is null));
						bool? np_ = context.Operators.And(nk_, no_);
						bool? nq_ = context.Operators.And(mx_, np_);

						return nq_;
					};
					IEnumerable<Encounter> ks_ = context.Operators.Where<Encounter>(kq_, kr_);
					object kt_(Encounter @this)
					{
						Period nr_ = @this?.Period;
						CqlInterval<CqlDateTime> ns_ = FHIRHelpers_4_3_000.Instance.ToInterval(context, nr_);
						CqlDateTime nt_ = context.Operators.End(ns_);

						return nt_;
					};
					IEnumerable<Encounter> ku_ = context.Operators.SortBy<Encounter>(ks_, kt_, System.ComponentModel.ListSortDirection.Ascending);
					Encounter kv_ = context.Operators.Last<Encounter>(ku_);
					Period kw_ = kv_?.Period;
					CqlInterval<CqlDateTime> kx_ = FHIRHelpers_4_3_000.Instance.ToInterval(context, kw_);
					CqlDateTime ky_ = context.Operators.Start(kx_);
					CqlInterval<CqlDateTime> la_ = FHIRHelpers_4_3_000.Instance.ToInterval(context, kk_);
					CqlDateTime lb_ = context.Operators.Start(la_);
					CqlInterval<CqlDateTime> lc_ = context.Operators.Interval(ko_, ky_ ?? lb_, true, true);
					bool? ld_ = context.Operators.In<CqlDateTime>(jz_, lc_, default);
					IEnumerable<Encounter> lf_ = context.Operators.RetrieveByValueSet<Encounter>(ka_, default);
					bool? lg_(Encounter LastObs)
					{
						Code<Encounter.EncounterStatus> nu_ = LastObs?.StatusElement;
						Encounter.EncounterStatus? nv_ = nu_?.Value;
						Code<Encounter.EncounterStatus> nw_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(nv_);
						bool? nx_ = context.Operators.Equal(nw_, "finished");
						Period ny_ = LastObs?.Period;
						CqlInterval<CqlDateTime> nz_ = FHIRHelpers_4_3_000.Instance.ToInterval(context, ny_);
						CqlDateTime oa_ = context.Operators.End(nz_);
						Period ob_ = Visit?.Period;
						CqlInterval<CqlDateTime> oc_ = FHIRHelpers_4_3_000.Instance.ToInterval(context, ob_);
						CqlDateTime od_ = context.Operators.Start(oc_);
						CqlQuantity oe_ = context.Operators.Quantity(1m, "hour");
						CqlDateTime of_ = context.Operators.Subtract(od_, oe_);
						CqlInterval<CqlDateTime> oh_ = FHIRHelpers_4_3_000.Instance.ToInterval(context, ob_);
						CqlDateTime oi_ = context.Operators.Start(oh_);
						CqlInterval<CqlDateTime> oj_ = context.Operators.Interval(of_, oi_, true, true);
						bool? ok_ = context.Operators.In<CqlDateTime>(oa_, oj_, default);
						CqlInterval<CqlDateTime> om_ = FHIRHelpers_4_3_000.Instance.ToInterval(context, ob_);
						CqlDateTime on_ = context.Operators.Start(om_);
						bool? oo_ = context.Operators.Not((bool?)(on_ is null));
						bool? op_ = context.Operators.And(ok_, oo_);
						bool? oq_ = context.Operators.And(nx_, op_);

						return oq_;
					};
					IEnumerable<Encounter> lh_ = context.Operators.Where<Encounter>(lf_, lg_);
					object li_(Encounter @this)
					{
						Period or_ = @this?.Period;
						CqlInterval<CqlDateTime> os_ = FHIRHelpers_4_3_000.Instance.ToInterval(context, or_);
						CqlDateTime ot_ = context.Operators.End(os_);

						return ot_;
					};
					IEnumerable<Encounter> lj_ = context.Operators.SortBy<Encounter>(lh_, li_, System.ComponentModel.ListSortDirection.Ascending);
					Encounter lk_ = context.Operators.Last<Encounter>(lj_);
					Period ll_ = lk_?.Period;
					CqlInterval<CqlDateTime> lm_ = FHIRHelpers_4_3_000.Instance.ToInterval(context, ll_);
					CqlDateTime ln_ = context.Operators.Start(lm_);
					CqlInterval<CqlDateTime> lp_ = FHIRHelpers_4_3_000.Instance.ToInterval(context, kk_);
					CqlDateTime lq_ = context.Operators.Start(lp_);
					bool? lr_ = context.Operators.Not((bool?)((ln_ ?? lq_) is null));
					bool? ls_ = context.Operators.And(ld_, lr_);
					bool? lt_ = context.Operators.And(jw_, ls_);

					return lt_;
				};
				IEnumerable<Encounter> bu_ = context.Operators.Where<Encounter>(bs_, bt_);
				object bv_(Encounter @this)
				{
					Period ou_ = @this?.Period;
					CqlInterval<CqlDateTime> ov_ = FHIRHelpers_4_3_000.Instance.ToInterval(context, ou_);
					CqlDateTime ow_ = context.Operators.End(ov_);

					return ow_;
				};
				IEnumerable<Encounter> bw_ = context.Operators.SortBy<Encounter>(bu_, bv_, System.ComponentModel.ListSortDirection.Ascending);
				Encounter bx_ = context.Operators.Last<Encounter>(bw_);
				Period by_ = bx_?.Period;
				CqlInterval<CqlDateTime> bz_ = FHIRHelpers_4_3_000.Instance.ToInterval(context, by_);
				CqlDateTime ca_ = context.Operators.Start(bz_);
				IEnumerable<Encounter> cc_ = context.Operators.RetrieveByValueSet<Encounter>(bc_, default);
				bool? cd_(Encounter LastObs)
				{
					Code<Encounter.EncounterStatus> ox_ = LastObs?.StatusElement;
					Encounter.EncounterStatus? oy_ = ox_?.Value;
					Code<Encounter.EncounterStatus> oz_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(oy_);
					bool? pa_ = context.Operators.Equal(oz_, "finished");
					Period pb_ = LastObs?.Period;
					CqlInterval<CqlDateTime> pc_ = FHIRHelpers_4_3_000.Instance.ToInterval(context, pb_);
					CqlDateTime pd_ = context.Operators.End(pc_);
					Period pe_ = Visit?.Period;
					CqlInterval<CqlDateTime> pf_ = FHIRHelpers_4_3_000.Instance.ToInterval(context, pe_);
					CqlDateTime pg_ = context.Operators.Start(pf_);
					CqlQuantity ph_ = context.Operators.Quantity(1m, "hour");
					CqlDateTime pi_ = context.Operators.Subtract(pg_, ph_);
					CqlInterval<CqlDateTime> pk_ = FHIRHelpers_4_3_000.Instance.ToInterval(context, pe_);
					CqlDateTime pl_ = context.Operators.Start(pk_);
					CqlInterval<CqlDateTime> pm_ = context.Operators.Interval(pi_, pl_, true, true);
					bool? pn_ = context.Operators.In<CqlDateTime>(pd_, pm_, default);
					CqlInterval<CqlDateTime> pp_ = FHIRHelpers_4_3_000.Instance.ToInterval(context, pe_);
					CqlDateTime pq_ = context.Operators.Start(pp_);
					bool? pr_ = context.Operators.Not((bool?)(pq_ is null));
					bool? ps_ = context.Operators.And(pn_, pr_);
					bool? pt_ = context.Operators.And(pa_, ps_);

					return pt_;
				};
				IEnumerable<Encounter> ce_ = context.Operators.Where<Encounter>(cc_, cd_);
				object cf_(Encounter @this)
				{
					Period pu_ = @this?.Period;
					CqlInterval<CqlDateTime> pv_ = FHIRHelpers_4_3_000.Instance.ToInterval(context, pu_);
					CqlDateTime pw_ = context.Operators.End(pv_);

					return pw_;
				};
				IEnumerable<Encounter> cg_ = context.Operators.SortBy<Encounter>(ce_, cf_, System.ComponentModel.ListSortDirection.Ascending);
				Encounter ch_ = context.Operators.Last<Encounter>(cg_);
				Period ci_ = ch_?.Period;
				CqlInterval<CqlDateTime> cj_ = FHIRHelpers_4_3_000.Instance.ToInterval(context, ci_);
				CqlDateTime ck_ = context.Operators.Start(cj_);
				CqlInterval<CqlDateTime> cm_ = FHIRHelpers_4_3_000.Instance.ToInterval(context, bm_);
				CqlDateTime cn_ = context.Operators.Start(cm_);
				CqlInterval<CqlDateTime> co_ = context.Operators.Interval(bq_, ca_ ?? ck_ ?? cn_, true, true);
				bool? cp_ = context.Operators.In<CqlDateTime>(ar_, co_, default);
				IEnumerable<Encounter> cr_ = context.Operators.RetrieveByValueSet<Encounter>(as_, default);
				bool? cs_(Encounter LastED)
				{
					Code<Encounter.EncounterStatus> px_ = LastED?.StatusElement;
					Encounter.EncounterStatus? py_ = px_?.Value;
					Code<Encounter.EncounterStatus> pz_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(py_);
					bool? qa_ = context.Operators.Equal(pz_, "finished");
					Period qb_ = LastED?.Period;
					CqlInterval<CqlDateTime> qc_ = FHIRHelpers_4_3_000.Instance.ToInterval(context, qb_);
					CqlDateTime qd_ = context.Operators.End(qc_);
					CqlValueSet qe_ = this.Observation_Services(context);
					IEnumerable<Encounter> qf_ = context.Operators.RetrieveByValueSet<Encounter>(qe_, default);
					bool? qg_(Encounter LastObs)
					{
						Code<Encounter.EncounterStatus> ry_ = LastObs?.StatusElement;
						Encounter.EncounterStatus? rz_ = ry_?.Value;
						Code<Encounter.EncounterStatus> sa_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(rz_);
						bool? sb_ = context.Operators.Equal(sa_, "finished");
						Period sc_ = LastObs?.Period;
						CqlInterval<CqlDateTime> sd_ = FHIRHelpers_4_3_000.Instance.ToInterval(context, sc_);
						CqlDateTime se_ = context.Operators.End(sd_);
						Period sf_ = Visit?.Period;
						CqlInterval<CqlDateTime> sg_ = FHIRHelpers_4_3_000.Instance.ToInterval(context, sf_);
						CqlDateTime sh_ = context.Operators.Start(sg_);
						CqlQuantity si_ = context.Operators.Quantity(1m, "hour");
						CqlDateTime sj_ = context.Operators.Subtract(sh_, si_);
						CqlInterval<CqlDateTime> sl_ = FHIRHelpers_4_3_000.Instance.ToInterval(context, sf_);
						CqlDateTime sm_ = context.Operators.Start(sl_);
						CqlInterval<CqlDateTime> sn_ = context.Operators.Interval(sj_, sm_, true, true);
						bool? so_ = context.Operators.In<CqlDateTime>(se_, sn_, default);
						CqlInterval<CqlDateTime> sq_ = FHIRHelpers_4_3_000.Instance.ToInterval(context, sf_);
						CqlDateTime sr_ = context.Operators.Start(sq_);
						bool? ss_ = context.Operators.Not((bool?)(sr_ is null));
						bool? st_ = context.Operators.And(so_, ss_);
						bool? su_ = context.Operators.And(sb_, st_);

						return su_;
					};
					IEnumerable<Encounter> qh_ = context.Operators.Where<Encounter>(qf_, qg_);
					object qi_(Encounter @this)
					{
						Period sv_ = @this?.Period;
						CqlInterval<CqlDateTime> sw_ = FHIRHelpers_4_3_000.Instance.ToInterval(context, sv_);
						CqlDateTime sx_ = context.Operators.End(sw_);

						return sx_;
					};
					IEnumerable<Encounter> qj_ = context.Operators.SortBy<Encounter>(qh_, qi_, System.ComponentModel.ListSortDirection.Ascending);
					Encounter qk_ = context.Operators.Last<Encounter>(qj_);
					Period ql_ = qk_?.Period;
					CqlInterval<CqlDateTime> qm_ = FHIRHelpers_4_3_000.Instance.ToInterval(context, ql_);
					CqlDateTime qn_ = context.Operators.Start(qm_);
					Period qo_ = Visit?.Period;
					CqlInterval<CqlDateTime> qp_ = FHIRHelpers_4_3_000.Instance.ToInterval(context, qo_);
					CqlDateTime qq_ = context.Operators.Start(qp_);
					CqlQuantity qr_ = context.Operators.Quantity(1m, "hour");
					CqlDateTime qs_ = context.Operators.Subtract(qn_ ?? qq_, qr_);
					IEnumerable<Encounter> qu_ = context.Operators.RetrieveByValueSet<Encounter>(qe_, default);
					bool? qv_(Encounter LastObs)
					{
						Code<Encounter.EncounterStatus> sy_ = LastObs?.StatusElement;
						Encounter.EncounterStatus? sz_ = sy_?.Value;
						Code<Encounter.EncounterStatus> ta_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(sz_);
						bool? tb_ = context.Operators.Equal(ta_, "finished");
						Period tc_ = LastObs?.Period;
						CqlInterval<CqlDateTime> td_ = FHIRHelpers_4_3_000.Instance.ToInterval(context, tc_);
						CqlDateTime te_ = context.Operators.End(td_);
						Period tf_ = Visit?.Period;
						CqlInterval<CqlDateTime> tg_ = FHIRHelpers_4_3_000.Instance.ToInterval(context, tf_);
						CqlDateTime th_ = context.Operators.Start(tg_);
						CqlQuantity ti_ = context.Operators.Quantity(1m, "hour");
						CqlDateTime tj_ = context.Operators.Subtract(th_, ti_);
						CqlInterval<CqlDateTime> tl_ = FHIRHelpers_4_3_000.Instance.ToInterval(context, tf_);
						CqlDateTime tm_ = context.Operators.Start(tl_);
						CqlInterval<CqlDateTime> tn_ = context.Operators.Interval(tj_, tm_, true, true);
						bool? to_ = context.Operators.In<CqlDateTime>(te_, tn_, default);
						CqlInterval<CqlDateTime> tq_ = FHIRHelpers_4_3_000.Instance.ToInterval(context, tf_);
						CqlDateTime tr_ = context.Operators.Start(tq_);
						bool? ts_ = context.Operators.Not((bool?)(tr_ is null));
						bool? tt_ = context.Operators.And(to_, ts_);
						bool? tu_ = context.Operators.And(tb_, tt_);

						return tu_;
					};
					IEnumerable<Encounter> qw_ = context.Operators.Where<Encounter>(qu_, qv_);
					object qx_(Encounter @this)
					{
						Period tv_ = @this?.Period;
						CqlInterval<CqlDateTime> tw_ = FHIRHelpers_4_3_000.Instance.ToInterval(context, tv_);
						CqlDateTime tx_ = context.Operators.End(tw_);

						return tx_;
					};
					IEnumerable<Encounter> qy_ = context.Operators.SortBy<Encounter>(qw_, qx_, System.ComponentModel.ListSortDirection.Ascending);
					Encounter qz_ = context.Operators.Last<Encounter>(qy_);
					Period ra_ = qz_?.Period;
					CqlInterval<CqlDateTime> rb_ = FHIRHelpers_4_3_000.Instance.ToInterval(context, ra_);
					CqlDateTime rc_ = context.Operators.Start(rb_);
					CqlInterval<CqlDateTime> re_ = FHIRHelpers_4_3_000.Instance.ToInterval(context, qo_);
					CqlDateTime rf_ = context.Operators.Start(re_);
					CqlInterval<CqlDateTime> rg_ = context.Operators.Interval(qs_, rc_ ?? rf_, true, true);
					bool? rh_ = context.Operators.In<CqlDateTime>(qd_, rg_, default);
					IEnumerable<Encounter> rj_ = context.Operators.RetrieveByValueSet<Encounter>(qe_, default);
					bool? rk_(Encounter LastObs)
					{
						Code<Encounter.EncounterStatus> ty_ = LastObs?.StatusElement;
						Encounter.EncounterStatus? tz_ = ty_?.Value;
						Code<Encounter.EncounterStatus> ua_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(tz_);
						bool? ub_ = context.Operators.Equal(ua_, "finished");
						Period uc_ = LastObs?.Period;
						CqlInterval<CqlDateTime> ud_ = FHIRHelpers_4_3_000.Instance.ToInterval(context, uc_);
						CqlDateTime ue_ = context.Operators.End(ud_);
						Period uf_ = Visit?.Period;
						CqlInterval<CqlDateTime> ug_ = FHIRHelpers_4_3_000.Instance.ToInterval(context, uf_);
						CqlDateTime uh_ = context.Operators.Start(ug_);
						CqlQuantity ui_ = context.Operators.Quantity(1m, "hour");
						CqlDateTime uj_ = context.Operators.Subtract(uh_, ui_);
						CqlInterval<CqlDateTime> ul_ = FHIRHelpers_4_3_000.Instance.ToInterval(context, uf_);
						CqlDateTime um_ = context.Operators.Start(ul_);
						CqlInterval<CqlDateTime> un_ = context.Operators.Interval(uj_, um_, true, true);
						bool? uo_ = context.Operators.In<CqlDateTime>(ue_, un_, default);
						CqlInterval<CqlDateTime> uq_ = FHIRHelpers_4_3_000.Instance.ToInterval(context, uf_);
						CqlDateTime ur_ = context.Operators.Start(uq_);
						bool? us_ = context.Operators.Not((bool?)(ur_ is null));
						bool? ut_ = context.Operators.And(uo_, us_);
						bool? uu_ = context.Operators.And(ub_, ut_);

						return uu_;
					};
					IEnumerable<Encounter> rl_ = context.Operators.Where<Encounter>(rj_, rk_);
					object rm_(Encounter @this)
					{
						Period uv_ = @this?.Period;
						CqlInterval<CqlDateTime> uw_ = FHIRHelpers_4_3_000.Instance.ToInterval(context, uv_);
						CqlDateTime ux_ = context.Operators.End(uw_);

						return ux_;
					};
					IEnumerable<Encounter> rn_ = context.Operators.SortBy<Encounter>(rl_, rm_, System.ComponentModel.ListSortDirection.Ascending);
					Encounter ro_ = context.Operators.Last<Encounter>(rn_);
					Period rp_ = ro_?.Period;
					CqlInterval<CqlDateTime> rq_ = FHIRHelpers_4_3_000.Instance.ToInterval(context, rp_);
					CqlDateTime rr_ = context.Operators.Start(rq_);
					CqlInterval<CqlDateTime> rt_ = FHIRHelpers_4_3_000.Instance.ToInterval(context, qo_);
					CqlDateTime ru_ = context.Operators.Start(rt_);
					bool? rv_ = context.Operators.Not((bool?)((rr_ ?? ru_) is null));
					bool? rw_ = context.Operators.And(rh_, rv_);
					bool? rx_ = context.Operators.And(qa_, rw_);

					return rx_;
				};
				IEnumerable<Encounter> ct_ = context.Operators.Where<Encounter>(cr_, cs_);
				object cu_(Encounter @this)
				{
					Period uy_ = @this?.Period;
					CqlInterval<CqlDateTime> uz_ = FHIRHelpers_4_3_000.Instance.ToInterval(context, uy_);
					CqlDateTime va_ = context.Operators.End(uz_);

					return va_;
				};
				IEnumerable<Encounter> cv_ = context.Operators.SortBy<Encounter>(ct_, cu_, System.ComponentModel.ListSortDirection.Ascending);
				Encounter cw_ = context.Operators.Last<Encounter>(cv_);
				Period cx_ = cw_?.Period;
				CqlInterval<CqlDateTime> cy_ = FHIRHelpers_4_3_000.Instance.ToInterval(context, cx_);
				CqlDateTime cz_ = context.Operators.Start(cy_);
				IEnumerable<Encounter> db_ = context.Operators.RetrieveByValueSet<Encounter>(bc_, default);
				bool? dc_(Encounter LastObs)
				{
					Code<Encounter.EncounterStatus> vb_ = LastObs?.StatusElement;
					Encounter.EncounterStatus? vc_ = vb_?.Value;
					Code<Encounter.EncounterStatus> vd_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(vc_);
					bool? ve_ = context.Operators.Equal(vd_, "finished");
					Period vf_ = LastObs?.Period;
					CqlInterval<CqlDateTime> vg_ = FHIRHelpers_4_3_000.Instance.ToInterval(context, vf_);
					CqlDateTime vh_ = context.Operators.End(vg_);
					Period vi_ = Visit?.Period;
					CqlInterval<CqlDateTime> vj_ = FHIRHelpers_4_3_000.Instance.ToInterval(context, vi_);
					CqlDateTime vk_ = context.Operators.Start(vj_);
					CqlQuantity vl_ = context.Operators.Quantity(1m, "hour");
					CqlDateTime vm_ = context.Operators.Subtract(vk_, vl_);
					CqlInterval<CqlDateTime> vo_ = FHIRHelpers_4_3_000.Instance.ToInterval(context, vi_);
					CqlDateTime vp_ = context.Operators.Start(vo_);
					CqlInterval<CqlDateTime> vq_ = context.Operators.Interval(vm_, vp_, true, true);
					bool? vr_ = context.Operators.In<CqlDateTime>(vh_, vq_, default);
					CqlInterval<CqlDateTime> vt_ = FHIRHelpers_4_3_000.Instance.ToInterval(context, vi_);
					CqlDateTime vu_ = context.Operators.Start(vt_);
					bool? vv_ = context.Operators.Not((bool?)(vu_ is null));
					bool? vw_ = context.Operators.And(vr_, vv_);
					bool? vx_ = context.Operators.And(ve_, vw_);

					return vx_;
				};
				IEnumerable<Encounter> dd_ = context.Operators.Where<Encounter>(db_, dc_);
				object de_(Encounter @this)
				{
					Period vy_ = @this?.Period;
					CqlInterval<CqlDateTime> vz_ = FHIRHelpers_4_3_000.Instance.ToInterval(context, vy_);
					CqlDateTime wa_ = context.Operators.End(vz_);

					return wa_;
				};
				IEnumerable<Encounter> df_ = context.Operators.SortBy<Encounter>(dd_, de_, System.ComponentModel.ListSortDirection.Ascending);
				Encounter dg_ = context.Operators.Last<Encounter>(df_);
				Period dh_ = dg_?.Period;
				CqlInterval<CqlDateTime> di_ = FHIRHelpers_4_3_000.Instance.ToInterval(context, dh_);
				CqlDateTime dj_ = context.Operators.Start(di_);
				CqlInterval<CqlDateTime> dl_ = FHIRHelpers_4_3_000.Instance.ToInterval(context, bm_);
				CqlDateTime dm_ = context.Operators.Start(dl_);
				bool? dn_ = context.Operators.Not((bool?)((cz_ ?? dj_ ?? dm_) is null));
				bool? do_ = context.Operators.And(cp_, dn_);

				return do_;
			};
			IEnumerable<Encounter> h_ = context.Operators.Where<Encounter>(f_, g_);
			object i_(Encounter @this)
			{
				Period wb_ = @this?.Period;
				CqlInterval<CqlDateTime> wc_ = FHIRHelpers_4_3_000.Instance.ToInterval(context, wb_);
				CqlDateTime wd_ = context.Operators.End(wc_);

				return wd_;
			};
			IEnumerable<Encounter> j_ = context.Operators.SortBy<Encounter>(h_, i_, System.ComponentModel.ListSortDirection.Ascending);
			Encounter k_ = context.Operators.Last<Encounter>(j_);
			Period l_ = k_?.Period;
			CqlInterval<CqlDateTime> m_ = FHIRHelpers_4_3_000.Instance.ToInterval(context, l_);
			CqlDateTime n_ = context.Operators.Start(m_);
			CqlValueSet o_ = this.Emergency_Department_Visit(context);
			IEnumerable<Encounter> p_ = context.Operators.RetrieveByValueSet<Encounter>(o_, default);
			bool? q_(Encounter LastED)
			{
				Code<Encounter.EncounterStatus> we_ = LastED?.StatusElement;
				Encounter.EncounterStatus? wf_ = we_?.Value;
				Code<Encounter.EncounterStatus> wg_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(wf_);
				bool? wh_ = context.Operators.Equal(wg_, "finished");
				Period wi_ = LastED?.Period;
				CqlInterval<CqlDateTime> wj_ = FHIRHelpers_4_3_000.Instance.ToInterval(context, wi_);
				CqlDateTime wk_ = context.Operators.End(wj_);
				CqlValueSet wl_ = this.Observation_Services(context);
				IEnumerable<Encounter> wm_ = context.Operators.RetrieveByValueSet<Encounter>(wl_, default);
				bool? wn_(Encounter LastObs)
				{
					Code<Encounter.EncounterStatus> yf_ = LastObs?.StatusElement;
					Encounter.EncounterStatus? yg_ = yf_?.Value;
					Code<Encounter.EncounterStatus> yh_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(yg_);
					bool? yi_ = context.Operators.Equal(yh_, "finished");
					Period yj_ = LastObs?.Period;
					CqlInterval<CqlDateTime> yk_ = FHIRHelpers_4_3_000.Instance.ToInterval(context, yj_);
					CqlDateTime yl_ = context.Operators.End(yk_);
					Period ym_ = Visit?.Period;
					CqlInterval<CqlDateTime> yn_ = FHIRHelpers_4_3_000.Instance.ToInterval(context, ym_);
					CqlDateTime yo_ = context.Operators.Start(yn_);
					CqlQuantity yp_ = context.Operators.Quantity(1m, "hour");
					CqlDateTime yq_ = context.Operators.Subtract(yo_, yp_);
					CqlInterval<CqlDateTime> ys_ = FHIRHelpers_4_3_000.Instance.ToInterval(context, ym_);
					CqlDateTime yt_ = context.Operators.Start(ys_);
					CqlInterval<CqlDateTime> yu_ = context.Operators.Interval(yq_, yt_, true, true);
					bool? yv_ = context.Operators.In<CqlDateTime>(yl_, yu_, default);
					CqlInterval<CqlDateTime> yx_ = FHIRHelpers_4_3_000.Instance.ToInterval(context, ym_);
					CqlDateTime yy_ = context.Operators.Start(yx_);
					bool? yz_ = context.Operators.Not((bool?)(yy_ is null));
					bool? za_ = context.Operators.And(yv_, yz_);
					bool? zb_ = context.Operators.And(yi_, za_);

					return zb_;
				};
				IEnumerable<Encounter> wo_ = context.Operators.Where<Encounter>(wm_, wn_);
				object wp_(Encounter @this)
				{
					Period zc_ = @this?.Period;
					CqlInterval<CqlDateTime> zd_ = FHIRHelpers_4_3_000.Instance.ToInterval(context, zc_);
					CqlDateTime ze_ = context.Operators.End(zd_);

					return ze_;
				};
				IEnumerable<Encounter> wq_ = context.Operators.SortBy<Encounter>(wo_, wp_, System.ComponentModel.ListSortDirection.Ascending);
				Encounter wr_ = context.Operators.Last<Encounter>(wq_);
				Period ws_ = wr_?.Period;
				CqlInterval<CqlDateTime> wt_ = FHIRHelpers_4_3_000.Instance.ToInterval(context, ws_);
				CqlDateTime wu_ = context.Operators.Start(wt_);
				Period wv_ = Visit?.Period;
				CqlInterval<CqlDateTime> ww_ = FHIRHelpers_4_3_000.Instance.ToInterval(context, wv_);
				CqlDateTime wx_ = context.Operators.Start(ww_);
				CqlQuantity wy_ = context.Operators.Quantity(1m, "hour");
				CqlDateTime wz_ = context.Operators.Subtract(wu_ ?? wx_, wy_);
				IEnumerable<Encounter> xb_ = context.Operators.RetrieveByValueSet<Encounter>(wl_, default);
				bool? xc_(Encounter LastObs)
				{
					Code<Encounter.EncounterStatus> zf_ = LastObs?.StatusElement;
					Encounter.EncounterStatus? zg_ = zf_?.Value;
					Code<Encounter.EncounterStatus> zh_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(zg_);
					bool? zi_ = context.Operators.Equal(zh_, "finished");
					Period zj_ = LastObs?.Period;
					CqlInterval<CqlDateTime> zk_ = FHIRHelpers_4_3_000.Instance.ToInterval(context, zj_);
					CqlDateTime zl_ = context.Operators.End(zk_);
					Period zm_ = Visit?.Period;
					CqlInterval<CqlDateTime> zn_ = FHIRHelpers_4_3_000.Instance.ToInterval(context, zm_);
					CqlDateTime zo_ = context.Operators.Start(zn_);
					CqlQuantity zp_ = context.Operators.Quantity(1m, "hour");
					CqlDateTime zq_ = context.Operators.Subtract(zo_, zp_);
					CqlInterval<CqlDateTime> zs_ = FHIRHelpers_4_3_000.Instance.ToInterval(context, zm_);
					CqlDateTime zt_ = context.Operators.Start(zs_);
					CqlInterval<CqlDateTime> zu_ = context.Operators.Interval(zq_, zt_, true, true);
					bool? zv_ = context.Operators.In<CqlDateTime>(zl_, zu_, default);
					CqlInterval<CqlDateTime> zx_ = FHIRHelpers_4_3_000.Instance.ToInterval(context, zm_);
					CqlDateTime zy_ = context.Operators.Start(zx_);
					bool? zz_ = context.Operators.Not((bool?)(zy_ is null));
					bool? aza_ = context.Operators.And(zv_, zz_);
					bool? azb_ = context.Operators.And(zi_, aza_);

					return azb_;
				};
				IEnumerable<Encounter> xd_ = context.Operators.Where<Encounter>(xb_, xc_);
				object xe_(Encounter @this)
				{
					Period azc_ = @this?.Period;
					CqlInterval<CqlDateTime> azd_ = FHIRHelpers_4_3_000.Instance.ToInterval(context, azc_);
					CqlDateTime aze_ = context.Operators.End(azd_);

					return aze_;
				};
				IEnumerable<Encounter> xf_ = context.Operators.SortBy<Encounter>(xd_, xe_, System.ComponentModel.ListSortDirection.Ascending);
				Encounter xg_ = context.Operators.Last<Encounter>(xf_);
				Period xh_ = xg_?.Period;
				CqlInterval<CqlDateTime> xi_ = FHIRHelpers_4_3_000.Instance.ToInterval(context, xh_);
				CqlDateTime xj_ = context.Operators.Start(xi_);
				CqlInterval<CqlDateTime> xl_ = FHIRHelpers_4_3_000.Instance.ToInterval(context, wv_);
				CqlDateTime xm_ = context.Operators.Start(xl_);
				CqlInterval<CqlDateTime> xn_ = context.Operators.Interval(wz_, xj_ ?? xm_, true, true);
				bool? xo_ = context.Operators.In<CqlDateTime>(wk_, xn_, default);
				IEnumerable<Encounter> xq_ = context.Operators.RetrieveByValueSet<Encounter>(wl_, default);
				bool? xr_(Encounter LastObs)
				{
					Code<Encounter.EncounterStatus> azf_ = LastObs?.StatusElement;
					Encounter.EncounterStatus? azg_ = azf_?.Value;
					Code<Encounter.EncounterStatus> azh_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(azg_);
					bool? azi_ = context.Operators.Equal(azh_, "finished");
					Period azj_ = LastObs?.Period;
					CqlInterval<CqlDateTime> azk_ = FHIRHelpers_4_3_000.Instance.ToInterval(context, azj_);
					CqlDateTime azl_ = context.Operators.End(azk_);
					Period azm_ = Visit?.Period;
					CqlInterval<CqlDateTime> azn_ = FHIRHelpers_4_3_000.Instance.ToInterval(context, azm_);
					CqlDateTime azo_ = context.Operators.Start(azn_);
					CqlQuantity azp_ = context.Operators.Quantity(1m, "hour");
					CqlDateTime azq_ = context.Operators.Subtract(azo_, azp_);
					CqlInterval<CqlDateTime> azs_ = FHIRHelpers_4_3_000.Instance.ToInterval(context, azm_);
					CqlDateTime azt_ = context.Operators.Start(azs_);
					CqlInterval<CqlDateTime> azu_ = context.Operators.Interval(azq_, azt_, true, true);
					bool? azv_ = context.Operators.In<CqlDateTime>(azl_, azu_, default);
					CqlInterval<CqlDateTime> azx_ = FHIRHelpers_4_3_000.Instance.ToInterval(context, azm_);
					CqlDateTime azy_ = context.Operators.Start(azx_);
					bool? azz_ = context.Operators.Not((bool?)(azy_ is null));
					bool? bza_ = context.Operators.And(azv_, azz_);
					bool? bzb_ = context.Operators.And(azi_, bza_);

					return bzb_;
				};
				IEnumerable<Encounter> xs_ = context.Operators.Where<Encounter>(xq_, xr_);
				object xt_(Encounter @this)
				{
					Period bzc_ = @this?.Period;
					CqlInterval<CqlDateTime> bzd_ = FHIRHelpers_4_3_000.Instance.ToInterval(context, bzc_);
					CqlDateTime bze_ = context.Operators.End(bzd_);

					return bze_;
				};
				IEnumerable<Encounter> xu_ = context.Operators.SortBy<Encounter>(xs_, xt_, System.ComponentModel.ListSortDirection.Ascending);
				Encounter xv_ = context.Operators.Last<Encounter>(xu_);
				Period xw_ = xv_?.Period;
				CqlInterval<CqlDateTime> xx_ = FHIRHelpers_4_3_000.Instance.ToInterval(context, xw_);
				CqlDateTime xy_ = context.Operators.Start(xx_);
				CqlInterval<CqlDateTime> ya_ = FHIRHelpers_4_3_000.Instance.ToInterval(context, wv_);
				CqlDateTime yb_ = context.Operators.Start(ya_);
				bool? yc_ = context.Operators.Not((bool?)((xy_ ?? yb_) is null));
				bool? yd_ = context.Operators.And(xo_, yc_);
				bool? ye_ = context.Operators.And(wh_, yd_);

				return ye_;
			};
			IEnumerable<Encounter> r_ = context.Operators.Where<Encounter>(p_, q_);
			object s_(Encounter @this)
			{
				Period bzf_ = @this?.Period;
				CqlInterval<CqlDateTime> bzg_ = FHIRHelpers_4_3_000.Instance.ToInterval(context, bzf_);
				CqlDateTime bzh_ = context.Operators.End(bzg_);

				return bzh_;
			};
			IEnumerable<Encounter> t_ = context.Operators.SortBy<Encounter>(r_, s_, System.ComponentModel.ListSortDirection.Ascending);
			Encounter u_ = context.Operators.Last<Encounter>(t_);
			Period v_ = u_?.Period;
			CqlInterval<CqlDateTime> w_ = FHIRHelpers_4_3_000.Instance.ToInterval(context, v_);
			CqlDateTime x_ = context.Operators.Start(w_);
			CqlValueSet y_ = this.Observation_Services(context);
			IEnumerable<Encounter> z_ = context.Operators.RetrieveByValueSet<Encounter>(y_, default);
			bool? aa_(Encounter LastObs)
			{
				Code<Encounter.EncounterStatus> bzi_ = LastObs?.StatusElement;
				Encounter.EncounterStatus? bzj_ = bzi_?.Value;
				Code<Encounter.EncounterStatus> bzk_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(bzj_);
				bool? bzl_ = context.Operators.Equal(bzk_, "finished");
				Period bzm_ = LastObs?.Period;
				CqlInterval<CqlDateTime> bzn_ = FHIRHelpers_4_3_000.Instance.ToInterval(context, bzm_);
				CqlDateTime bzo_ = context.Operators.End(bzn_);
				Period bzp_ = Visit?.Period;
				CqlInterval<CqlDateTime> bzq_ = FHIRHelpers_4_3_000.Instance.ToInterval(context, bzp_);
				CqlDateTime bzr_ = context.Operators.Start(bzq_);
				CqlQuantity bzs_ = context.Operators.Quantity(1m, "hour");
				CqlDateTime bzt_ = context.Operators.Subtract(bzr_, bzs_);
				CqlInterval<CqlDateTime> bzv_ = FHIRHelpers_4_3_000.Instance.ToInterval(context, bzp_);
				CqlDateTime bzw_ = context.Operators.Start(bzv_);
				CqlInterval<CqlDateTime> bzx_ = context.Operators.Interval(bzt_, bzw_, true, true);
				bool? bzy_ = context.Operators.In<CqlDateTime>(bzo_, bzx_, default);
				CqlInterval<CqlDateTime> cza_ = FHIRHelpers_4_3_000.Instance.ToInterval(context, bzp_);
				CqlDateTime czb_ = context.Operators.Start(cza_);
				bool? czc_ = context.Operators.Not((bool?)(czb_ is null));
				bool? czd_ = context.Operators.And(bzy_, czc_);
				bool? cze_ = context.Operators.And(bzl_, czd_);

				return cze_;
			};
			IEnumerable<Encounter> ab_ = context.Operators.Where<Encounter>(z_, aa_);
			object ac_(Encounter @this)
			{
				Period czf_ = @this?.Period;
				CqlInterval<CqlDateTime> czg_ = FHIRHelpers_4_3_000.Instance.ToInterval(context, czf_);
				CqlDateTime czh_ = context.Operators.End(czg_);

				return czh_;
			};
			IEnumerable<Encounter> ad_ = context.Operators.SortBy<Encounter>(ab_, ac_, System.ComponentModel.ListSortDirection.Ascending);
			Encounter ae_ = context.Operators.Last<Encounter>(ad_);
			Period af_ = ae_?.Period;
			CqlInterval<CqlDateTime> ag_ = FHIRHelpers_4_3_000.Instance.ToInterval(context, af_);
			CqlDateTime ah_ = context.Operators.Start(ag_);
			Period ai_ = Visit?.Period;
			CqlInterval<CqlDateTime> aj_ = FHIRHelpers_4_3_000.Instance.ToInterval(context, ai_);
			CqlDateTime ak_ = context.Operators.Start(aj_);
			CqlInterval<CqlDateTime> am_ = FHIRHelpers_4_3_000.Instance.ToInterval(context, ai_);
			CqlDateTime an_ = context.Operators.End(am_);
			CqlInterval<CqlDateTime> ao_ = context.Operators.Interval(n_ ?? x_ ?? ah_ ?? ak_, an_, true, true);

			return ao_;
		};
		IEnumerable<CqlInterval<CqlDateTime>> c_ = context.Operators.Select<Encounter, CqlInterval<CqlDateTime>>((IEnumerable<Encounter>)a_, b_);
		CqlInterval<CqlDateTime> d_ = context.Operators.SingletonFrom<CqlInterval<CqlDateTime>>(c_);

		return d_;
	}

	public CqlInterval<CqlDateTime> HospitalizationWithObservation(CqlContext context, Encounter TheEncounter)
	{
		Encounter[] a_ = [
			TheEncounter,
		];
		CqlInterval<CqlDateTime> b_(Encounter Visit)
		{
			CqlValueSet e_ = this.Emergency_Department_Visit(context);
			IEnumerable<Encounter> f_ = context.Operators.RetrieveByValueSet<Encounter>(e_, default);
			bool? g_(Encounter LastED)
			{
				Code<Encounter.EncounterStatus> af_ = LastED?.StatusElement;
				Encounter.EncounterStatus? ag_ = af_?.Value;
				Code<Encounter.EncounterStatus> ah_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(ag_);
				bool? ai_ = context.Operators.Equal(ah_, "finished");
				Period aj_ = LastED?.Period;
				CqlInterval<CqlDateTime> ak_ = FHIRHelpers_4_3_000.Instance.ToInterval(context, aj_);
				CqlDateTime al_ = context.Operators.End(ak_);
				CqlValueSet am_ = this.Observation_Services(context);
				IEnumerable<Encounter> an_ = context.Operators.RetrieveByValueSet<Encounter>(am_, default);
				bool? ao_(Encounter LastObs)
				{
					Code<Encounter.EncounterStatus> cg_ = LastObs?.StatusElement;
					Encounter.EncounterStatus? ch_ = cg_?.Value;
					Code<Encounter.EncounterStatus> ci_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(ch_);
					bool? cj_ = context.Operators.Equal(ci_, "finished");
					Period ck_ = LastObs?.Period;
					CqlInterval<CqlDateTime> cl_ = FHIRHelpers_4_3_000.Instance.ToInterval(context, ck_);
					CqlDateTime cm_ = context.Operators.End(cl_);
					Period cn_ = Visit?.Period;
					CqlInterval<CqlDateTime> co_ = FHIRHelpers_4_3_000.Instance.ToInterval(context, cn_);
					CqlDateTime cp_ = context.Operators.Start(co_);
					CqlQuantity cq_ = context.Operators.Quantity(1m, "hour");
					CqlDateTime cr_ = context.Operators.Subtract(cp_, cq_);
					CqlInterval<CqlDateTime> ct_ = FHIRHelpers_4_3_000.Instance.ToInterval(context, cn_);
					CqlDateTime cu_ = context.Operators.Start(ct_);
					CqlInterval<CqlDateTime> cv_ = context.Operators.Interval(cr_, cu_, true, true);
					bool? cw_ = context.Operators.In<CqlDateTime>(cm_, cv_, default);
					CqlInterval<CqlDateTime> cy_ = FHIRHelpers_4_3_000.Instance.ToInterval(context, cn_);
					CqlDateTime cz_ = context.Operators.Start(cy_);
					bool? da_ = context.Operators.Not((bool?)(cz_ is null));
					bool? db_ = context.Operators.And(cw_, da_);
					bool? dc_ = context.Operators.And(cj_, db_);

					return dc_;
				};
				IEnumerable<Encounter> ap_ = context.Operators.Where<Encounter>(an_, ao_);
				object aq_(Encounter @this)
				{
					Period dd_ = @this?.Period;
					CqlInterval<CqlDateTime> de_ = FHIRHelpers_4_3_000.Instance.ToInterval(context, dd_);
					CqlDateTime df_ = context.Operators.End(de_);

					return df_;
				};
				IEnumerable<Encounter> ar_ = context.Operators.SortBy<Encounter>(ap_, aq_, System.ComponentModel.ListSortDirection.Ascending);
				Encounter as_ = context.Operators.Last<Encounter>(ar_);
				Period at_ = as_?.Period;
				CqlInterval<CqlDateTime> au_ = FHIRHelpers_4_3_000.Instance.ToInterval(context, at_);
				CqlDateTime av_ = context.Operators.Start(au_);
				Period aw_ = Visit?.Period;
				CqlInterval<CqlDateTime> ax_ = FHIRHelpers_4_3_000.Instance.ToInterval(context, aw_);
				CqlDateTime ay_ = context.Operators.Start(ax_);
				CqlQuantity az_ = context.Operators.Quantity(1m, "hour");
				CqlDateTime ba_ = context.Operators.Subtract(av_ ?? ay_, az_);
				IEnumerable<Encounter> bc_ = context.Operators.RetrieveByValueSet<Encounter>(am_, default);
				bool? bd_(Encounter LastObs)
				{
					Code<Encounter.EncounterStatus> dg_ = LastObs?.StatusElement;
					Encounter.EncounterStatus? dh_ = dg_?.Value;
					Code<Encounter.EncounterStatus> di_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(dh_);
					bool? dj_ = context.Operators.Equal(di_, "finished");
					Period dk_ = LastObs?.Period;
					CqlInterval<CqlDateTime> dl_ = FHIRHelpers_4_3_000.Instance.ToInterval(context, dk_);
					CqlDateTime dm_ = context.Operators.End(dl_);
					Period dn_ = Visit?.Period;
					CqlInterval<CqlDateTime> do_ = FHIRHelpers_4_3_000.Instance.ToInterval(context, dn_);
					CqlDateTime dp_ = context.Operators.Start(do_);
					CqlQuantity dq_ = context.Operators.Quantity(1m, "hour");
					CqlDateTime dr_ = context.Operators.Subtract(dp_, dq_);
					CqlInterval<CqlDateTime> dt_ = FHIRHelpers_4_3_000.Instance.ToInterval(context, dn_);
					CqlDateTime du_ = context.Operators.Start(dt_);
					CqlInterval<CqlDateTime> dv_ = context.Operators.Interval(dr_, du_, true, true);
					bool? dw_ = context.Operators.In<CqlDateTime>(dm_, dv_, default);
					CqlInterval<CqlDateTime> dy_ = FHIRHelpers_4_3_000.Instance.ToInterval(context, dn_);
					CqlDateTime dz_ = context.Operators.Start(dy_);
					bool? ea_ = context.Operators.Not((bool?)(dz_ is null));
					bool? eb_ = context.Operators.And(dw_, ea_);
					bool? ec_ = context.Operators.And(dj_, eb_);

					return ec_;
				};
				IEnumerable<Encounter> be_ = context.Operators.Where<Encounter>(bc_, bd_);
				object bf_(Encounter @this)
				{
					Period ed_ = @this?.Period;
					CqlInterval<CqlDateTime> ee_ = FHIRHelpers_4_3_000.Instance.ToInterval(context, ed_);
					CqlDateTime ef_ = context.Operators.End(ee_);

					return ef_;
				};
				IEnumerable<Encounter> bg_ = context.Operators.SortBy<Encounter>(be_, bf_, System.ComponentModel.ListSortDirection.Ascending);
				Encounter bh_ = context.Operators.Last<Encounter>(bg_);
				Period bi_ = bh_?.Period;
				CqlInterval<CqlDateTime> bj_ = FHIRHelpers_4_3_000.Instance.ToInterval(context, bi_);
				CqlDateTime bk_ = context.Operators.Start(bj_);
				CqlInterval<CqlDateTime> bm_ = FHIRHelpers_4_3_000.Instance.ToInterval(context, aw_);
				CqlDateTime bn_ = context.Operators.Start(bm_);
				CqlInterval<CqlDateTime> bo_ = context.Operators.Interval(ba_, bk_ ?? bn_, true, true);
				bool? bp_ = context.Operators.In<CqlDateTime>(al_, bo_, default);
				IEnumerable<Encounter> br_ = context.Operators.RetrieveByValueSet<Encounter>(am_, default);
				bool? bs_(Encounter LastObs)
				{
					Code<Encounter.EncounterStatus> eg_ = LastObs?.StatusElement;
					Encounter.EncounterStatus? eh_ = eg_?.Value;
					Code<Encounter.EncounterStatus> ei_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(eh_);
					bool? ej_ = context.Operators.Equal(ei_, "finished");
					Period ek_ = LastObs?.Period;
					CqlInterval<CqlDateTime> el_ = FHIRHelpers_4_3_000.Instance.ToInterval(context, ek_);
					CqlDateTime em_ = context.Operators.End(el_);
					Period en_ = Visit?.Period;
					CqlInterval<CqlDateTime> eo_ = FHIRHelpers_4_3_000.Instance.ToInterval(context, en_);
					CqlDateTime ep_ = context.Operators.Start(eo_);
					CqlQuantity eq_ = context.Operators.Quantity(1m, "hour");
					CqlDateTime er_ = context.Operators.Subtract(ep_, eq_);
					CqlInterval<CqlDateTime> et_ = FHIRHelpers_4_3_000.Instance.ToInterval(context, en_);
					CqlDateTime eu_ = context.Operators.Start(et_);
					CqlInterval<CqlDateTime> ev_ = context.Operators.Interval(er_, eu_, true, true);
					bool? ew_ = context.Operators.In<CqlDateTime>(em_, ev_, default);
					CqlInterval<CqlDateTime> ey_ = FHIRHelpers_4_3_000.Instance.ToInterval(context, en_);
					CqlDateTime ez_ = context.Operators.Start(ey_);
					bool? fa_ = context.Operators.Not((bool?)(ez_ is null));
					bool? fb_ = context.Operators.And(ew_, fa_);
					bool? fc_ = context.Operators.And(ej_, fb_);

					return fc_;
				};
				IEnumerable<Encounter> bt_ = context.Operators.Where<Encounter>(br_, bs_);
				object bu_(Encounter @this)
				{
					Period fd_ = @this?.Period;
					CqlInterval<CqlDateTime> fe_ = FHIRHelpers_4_3_000.Instance.ToInterval(context, fd_);
					CqlDateTime ff_ = context.Operators.End(fe_);

					return ff_;
				};
				IEnumerable<Encounter> bv_ = context.Operators.SortBy<Encounter>(bt_, bu_, System.ComponentModel.ListSortDirection.Ascending);
				Encounter bw_ = context.Operators.Last<Encounter>(bv_);
				Period bx_ = bw_?.Period;
				CqlInterval<CqlDateTime> by_ = FHIRHelpers_4_3_000.Instance.ToInterval(context, bx_);
				CqlDateTime bz_ = context.Operators.Start(by_);
				CqlInterval<CqlDateTime> cb_ = FHIRHelpers_4_3_000.Instance.ToInterval(context, aw_);
				CqlDateTime cc_ = context.Operators.Start(cb_);
				bool? cd_ = context.Operators.Not((bool?)((bz_ ?? cc_) is null));
				bool? ce_ = context.Operators.And(bp_, cd_);
				bool? cf_ = context.Operators.And(ai_, ce_);

				return cf_;
			};
			IEnumerable<Encounter> h_ = context.Operators.Where<Encounter>(f_, g_);
			object i_(Encounter @this)
			{
				Period fg_ = @this?.Period;
				CqlInterval<CqlDateTime> fh_ = FHIRHelpers_4_3_000.Instance.ToInterval(context, fg_);
				CqlDateTime fi_ = context.Operators.End(fh_);

				return fi_;
			};
			IEnumerable<Encounter> j_ = context.Operators.SortBy<Encounter>(h_, i_, System.ComponentModel.ListSortDirection.Ascending);
			Encounter k_ = context.Operators.Last<Encounter>(j_);
			Period l_ = k_?.Period;
			CqlInterval<CqlDateTime> m_ = FHIRHelpers_4_3_000.Instance.ToInterval(context, l_);
			CqlDateTime n_ = context.Operators.Start(m_);
			CqlValueSet o_ = this.Observation_Services(context);
			IEnumerable<Encounter> p_ = context.Operators.RetrieveByValueSet<Encounter>(o_, default);
			bool? q_(Encounter LastObs)
			{
				Code<Encounter.EncounterStatus> fj_ = LastObs?.StatusElement;
				Encounter.EncounterStatus? fk_ = fj_?.Value;
				Code<Encounter.EncounterStatus> fl_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(fk_);
				bool? fm_ = context.Operators.Equal(fl_, "finished");
				Period fn_ = LastObs?.Period;
				CqlInterval<CqlDateTime> fo_ = FHIRHelpers_4_3_000.Instance.ToInterval(context, fn_);
				CqlDateTime fp_ = context.Operators.End(fo_);
				Period fq_ = Visit?.Period;
				CqlInterval<CqlDateTime> fr_ = FHIRHelpers_4_3_000.Instance.ToInterval(context, fq_);
				CqlDateTime fs_ = context.Operators.Start(fr_);
				CqlQuantity ft_ = context.Operators.Quantity(1m, "hour");
				CqlDateTime fu_ = context.Operators.Subtract(fs_, ft_);
				CqlInterval<CqlDateTime> fw_ = FHIRHelpers_4_3_000.Instance.ToInterval(context, fq_);
				CqlDateTime fx_ = context.Operators.Start(fw_);
				CqlInterval<CqlDateTime> fy_ = context.Operators.Interval(fu_, fx_, true, true);
				bool? fz_ = context.Operators.In<CqlDateTime>(fp_, fy_, default);
				CqlInterval<CqlDateTime> gb_ = FHIRHelpers_4_3_000.Instance.ToInterval(context, fq_);
				CqlDateTime gc_ = context.Operators.Start(gb_);
				bool? gd_ = context.Operators.Not((bool?)(gc_ is null));
				bool? ge_ = context.Operators.And(fz_, gd_);
				bool? gf_ = context.Operators.And(fm_, ge_);

				return gf_;
			};
			IEnumerable<Encounter> r_ = context.Operators.Where<Encounter>(p_, q_);
			object s_(Encounter @this)
			{
				Period gg_ = @this?.Period;
				CqlInterval<CqlDateTime> gh_ = FHIRHelpers_4_3_000.Instance.ToInterval(context, gg_);
				CqlDateTime gi_ = context.Operators.End(gh_);

				return gi_;
			};
			IEnumerable<Encounter> t_ = context.Operators.SortBy<Encounter>(r_, s_, System.ComponentModel.ListSortDirection.Ascending);
			Encounter u_ = context.Operators.Last<Encounter>(t_);
			Period v_ = u_?.Period;
			CqlInterval<CqlDateTime> w_ = FHIRHelpers_4_3_000.Instance.ToInterval(context, v_);
			CqlDateTime x_ = context.Operators.Start(w_);
			Period y_ = Visit?.Period;
			CqlInterval<CqlDateTime> z_ = FHIRHelpers_4_3_000.Instance.ToInterval(context, y_);
			CqlDateTime aa_ = context.Operators.Start(z_);
			CqlInterval<CqlDateTime> ac_ = FHIRHelpers_4_3_000.Instance.ToInterval(context, y_);
			CqlDateTime ad_ = context.Operators.End(ac_);
			CqlInterval<CqlDateTime> ae_ = context.Operators.Interval(n_ ?? x_ ?? aa_, ad_, true, true);

			return ae_;
		};
		IEnumerable<CqlInterval<CqlDateTime>> c_ = context.Operators.Select<Encounter, CqlInterval<CqlDateTime>>((IEnumerable<Encounter>)a_, b_);
		CqlInterval<CqlDateTime> d_ = context.Operators.SingletonFrom<CqlInterval<CqlDateTime>>(c_);

		return d_;
	}

	public CqlInterval<CqlDateTime> hospitalizationWithObservation(CqlContext context, Encounter TheEncounter)
	{
		Encounter[] a_ = [
			TheEncounter,
		];
		CqlInterval<CqlDateTime> b_(Encounter Visit)
		{
			CqlValueSet e_ = this.Emergency_Department_Visit(context);
			IEnumerable<Encounter> f_ = context.Operators.RetrieveByValueSet<Encounter>(e_, default);
			bool? g_(Encounter LastED)
			{
				Code<Encounter.EncounterStatus> af_ = LastED?.StatusElement;
				Encounter.EncounterStatus? ag_ = af_?.Value;
				Code<Encounter.EncounterStatus> ah_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(ag_);
				bool? ai_ = context.Operators.Equal(ah_, "finished");
				Period aj_ = LastED?.Period;
				CqlInterval<CqlDateTime> ak_ = FHIRHelpers_4_3_000.Instance.ToInterval(context, aj_);
				CqlDateTime al_ = context.Operators.End(ak_);
				CqlValueSet am_ = this.Observation_Services(context);
				IEnumerable<Encounter> an_ = context.Operators.RetrieveByValueSet<Encounter>(am_, default);
				bool? ao_(Encounter LastObs)
				{
					Code<Encounter.EncounterStatus> cg_ = LastObs?.StatusElement;
					Encounter.EncounterStatus? ch_ = cg_?.Value;
					Code<Encounter.EncounterStatus> ci_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(ch_);
					bool? cj_ = context.Operators.Equal(ci_, "finished");
					Period ck_ = LastObs?.Period;
					CqlInterval<CqlDateTime> cl_ = FHIRHelpers_4_3_000.Instance.ToInterval(context, ck_);
					CqlDateTime cm_ = context.Operators.End(cl_);
					Period cn_ = Visit?.Period;
					CqlInterval<CqlDateTime> co_ = FHIRHelpers_4_3_000.Instance.ToInterval(context, cn_);
					CqlDateTime cp_ = context.Operators.Start(co_);
					CqlQuantity cq_ = context.Operators.Quantity(1m, "hour");
					CqlDateTime cr_ = context.Operators.Subtract(cp_, cq_);
					CqlInterval<CqlDateTime> ct_ = FHIRHelpers_4_3_000.Instance.ToInterval(context, cn_);
					CqlDateTime cu_ = context.Operators.Start(ct_);
					CqlInterval<CqlDateTime> cv_ = context.Operators.Interval(cr_, cu_, true, true);
					bool? cw_ = context.Operators.In<CqlDateTime>(cm_, cv_, default);
					CqlInterval<CqlDateTime> cy_ = FHIRHelpers_4_3_000.Instance.ToInterval(context, cn_);
					CqlDateTime cz_ = context.Operators.Start(cy_);
					bool? da_ = context.Operators.Not((bool?)(cz_ is null));
					bool? db_ = context.Operators.And(cw_, da_);
					bool? dc_ = context.Operators.And(cj_, db_);

					return dc_;
				};
				IEnumerable<Encounter> ap_ = context.Operators.Where<Encounter>(an_, ao_);
				object aq_(Encounter @this)
				{
					Period dd_ = @this?.Period;
					CqlInterval<CqlDateTime> de_ = FHIRHelpers_4_3_000.Instance.ToInterval(context, dd_);
					CqlDateTime df_ = context.Operators.End(de_);

					return df_;
				};
				IEnumerable<Encounter> ar_ = context.Operators.SortBy<Encounter>(ap_, aq_, System.ComponentModel.ListSortDirection.Ascending);
				Encounter as_ = context.Operators.Last<Encounter>(ar_);
				Period at_ = as_?.Period;
				CqlInterval<CqlDateTime> au_ = FHIRHelpers_4_3_000.Instance.ToInterval(context, at_);
				CqlDateTime av_ = context.Operators.Start(au_);
				Period aw_ = Visit?.Period;
				CqlInterval<CqlDateTime> ax_ = FHIRHelpers_4_3_000.Instance.ToInterval(context, aw_);
				CqlDateTime ay_ = context.Operators.Start(ax_);
				CqlQuantity az_ = context.Operators.Quantity(1m, "hour");
				CqlDateTime ba_ = context.Operators.Subtract(av_ ?? ay_, az_);
				IEnumerable<Encounter> bc_ = context.Operators.RetrieveByValueSet<Encounter>(am_, default);
				bool? bd_(Encounter LastObs)
				{
					Code<Encounter.EncounterStatus> dg_ = LastObs?.StatusElement;
					Encounter.EncounterStatus? dh_ = dg_?.Value;
					Code<Encounter.EncounterStatus> di_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(dh_);
					bool? dj_ = context.Operators.Equal(di_, "finished");
					Period dk_ = LastObs?.Period;
					CqlInterval<CqlDateTime> dl_ = FHIRHelpers_4_3_000.Instance.ToInterval(context, dk_);
					CqlDateTime dm_ = context.Operators.End(dl_);
					Period dn_ = Visit?.Period;
					CqlInterval<CqlDateTime> do_ = FHIRHelpers_4_3_000.Instance.ToInterval(context, dn_);
					CqlDateTime dp_ = context.Operators.Start(do_);
					CqlQuantity dq_ = context.Operators.Quantity(1m, "hour");
					CqlDateTime dr_ = context.Operators.Subtract(dp_, dq_);
					CqlInterval<CqlDateTime> dt_ = FHIRHelpers_4_3_000.Instance.ToInterval(context, dn_);
					CqlDateTime du_ = context.Operators.Start(dt_);
					CqlInterval<CqlDateTime> dv_ = context.Operators.Interval(dr_, du_, true, true);
					bool? dw_ = context.Operators.In<CqlDateTime>(dm_, dv_, default);
					CqlInterval<CqlDateTime> dy_ = FHIRHelpers_4_3_000.Instance.ToInterval(context, dn_);
					CqlDateTime dz_ = context.Operators.Start(dy_);
					bool? ea_ = context.Operators.Not((bool?)(dz_ is null));
					bool? eb_ = context.Operators.And(dw_, ea_);
					bool? ec_ = context.Operators.And(dj_, eb_);

					return ec_;
				};
				IEnumerable<Encounter> be_ = context.Operators.Where<Encounter>(bc_, bd_);
				object bf_(Encounter @this)
				{
					Period ed_ = @this?.Period;
					CqlInterval<CqlDateTime> ee_ = FHIRHelpers_4_3_000.Instance.ToInterval(context, ed_);
					CqlDateTime ef_ = context.Operators.End(ee_);

					return ef_;
				};
				IEnumerable<Encounter> bg_ = context.Operators.SortBy<Encounter>(be_, bf_, System.ComponentModel.ListSortDirection.Ascending);
				Encounter bh_ = context.Operators.Last<Encounter>(bg_);
				Period bi_ = bh_?.Period;
				CqlInterval<CqlDateTime> bj_ = FHIRHelpers_4_3_000.Instance.ToInterval(context, bi_);
				CqlDateTime bk_ = context.Operators.Start(bj_);
				CqlInterval<CqlDateTime> bm_ = FHIRHelpers_4_3_000.Instance.ToInterval(context, aw_);
				CqlDateTime bn_ = context.Operators.Start(bm_);
				CqlInterval<CqlDateTime> bo_ = context.Operators.Interval(ba_, bk_ ?? bn_, true, true);
				bool? bp_ = context.Operators.In<CqlDateTime>(al_, bo_, default);
				IEnumerable<Encounter> br_ = context.Operators.RetrieveByValueSet<Encounter>(am_, default);
				bool? bs_(Encounter LastObs)
				{
					Code<Encounter.EncounterStatus> eg_ = LastObs?.StatusElement;
					Encounter.EncounterStatus? eh_ = eg_?.Value;
					Code<Encounter.EncounterStatus> ei_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(eh_);
					bool? ej_ = context.Operators.Equal(ei_, "finished");
					Period ek_ = LastObs?.Period;
					CqlInterval<CqlDateTime> el_ = FHIRHelpers_4_3_000.Instance.ToInterval(context, ek_);
					CqlDateTime em_ = context.Operators.End(el_);
					Period en_ = Visit?.Period;
					CqlInterval<CqlDateTime> eo_ = FHIRHelpers_4_3_000.Instance.ToInterval(context, en_);
					CqlDateTime ep_ = context.Operators.Start(eo_);
					CqlQuantity eq_ = context.Operators.Quantity(1m, "hour");
					CqlDateTime er_ = context.Operators.Subtract(ep_, eq_);
					CqlInterval<CqlDateTime> et_ = FHIRHelpers_4_3_000.Instance.ToInterval(context, en_);
					CqlDateTime eu_ = context.Operators.Start(et_);
					CqlInterval<CqlDateTime> ev_ = context.Operators.Interval(er_, eu_, true, true);
					bool? ew_ = context.Operators.In<CqlDateTime>(em_, ev_, default);
					CqlInterval<CqlDateTime> ey_ = FHIRHelpers_4_3_000.Instance.ToInterval(context, en_);
					CqlDateTime ez_ = context.Operators.Start(ey_);
					bool? fa_ = context.Operators.Not((bool?)(ez_ is null));
					bool? fb_ = context.Operators.And(ew_, fa_);
					bool? fc_ = context.Operators.And(ej_, fb_);

					return fc_;
				};
				IEnumerable<Encounter> bt_ = context.Operators.Where<Encounter>(br_, bs_);
				object bu_(Encounter @this)
				{
					Period fd_ = @this?.Period;
					CqlInterval<CqlDateTime> fe_ = FHIRHelpers_4_3_000.Instance.ToInterval(context, fd_);
					CqlDateTime ff_ = context.Operators.End(fe_);

					return ff_;
				};
				IEnumerable<Encounter> bv_ = context.Operators.SortBy<Encounter>(bt_, bu_, System.ComponentModel.ListSortDirection.Ascending);
				Encounter bw_ = context.Operators.Last<Encounter>(bv_);
				Period bx_ = bw_?.Period;
				CqlInterval<CqlDateTime> by_ = FHIRHelpers_4_3_000.Instance.ToInterval(context, bx_);
				CqlDateTime bz_ = context.Operators.Start(by_);
				CqlInterval<CqlDateTime> cb_ = FHIRHelpers_4_3_000.Instance.ToInterval(context, aw_);
				CqlDateTime cc_ = context.Operators.Start(cb_);
				bool? cd_ = context.Operators.Not((bool?)((bz_ ?? cc_) is null));
				bool? ce_ = context.Operators.And(bp_, cd_);
				bool? cf_ = context.Operators.And(ai_, ce_);

				return cf_;
			};
			IEnumerable<Encounter> h_ = context.Operators.Where<Encounter>(f_, g_);
			object i_(Encounter @this)
			{
				Period fg_ = @this?.Period;
				CqlInterval<CqlDateTime> fh_ = FHIRHelpers_4_3_000.Instance.ToInterval(context, fg_);
				CqlDateTime fi_ = context.Operators.End(fh_);

				return fi_;
			};
			IEnumerable<Encounter> j_ = context.Operators.SortBy<Encounter>(h_, i_, System.ComponentModel.ListSortDirection.Ascending);
			Encounter k_ = context.Operators.Last<Encounter>(j_);
			Period l_ = k_?.Period;
			CqlInterval<CqlDateTime> m_ = FHIRHelpers_4_3_000.Instance.ToInterval(context, l_);
			CqlDateTime n_ = context.Operators.Start(m_);
			CqlValueSet o_ = this.Observation_Services(context);
			IEnumerable<Encounter> p_ = context.Operators.RetrieveByValueSet<Encounter>(o_, default);
			bool? q_(Encounter LastObs)
			{
				Code<Encounter.EncounterStatus> fj_ = LastObs?.StatusElement;
				Encounter.EncounterStatus? fk_ = fj_?.Value;
				Code<Encounter.EncounterStatus> fl_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(fk_);
				bool? fm_ = context.Operators.Equal(fl_, "finished");
				Period fn_ = LastObs?.Period;
				CqlInterval<CqlDateTime> fo_ = FHIRHelpers_4_3_000.Instance.ToInterval(context, fn_);
				CqlDateTime fp_ = context.Operators.End(fo_);
				Period fq_ = Visit?.Period;
				CqlInterval<CqlDateTime> fr_ = FHIRHelpers_4_3_000.Instance.ToInterval(context, fq_);
				CqlDateTime fs_ = context.Operators.Start(fr_);
				CqlQuantity ft_ = context.Operators.Quantity(1m, "hour");
				CqlDateTime fu_ = context.Operators.Subtract(fs_, ft_);
				CqlInterval<CqlDateTime> fw_ = FHIRHelpers_4_3_000.Instance.ToInterval(context, fq_);
				CqlDateTime fx_ = context.Operators.Start(fw_);
				CqlInterval<CqlDateTime> fy_ = context.Operators.Interval(fu_, fx_, true, true);
				bool? fz_ = context.Operators.In<CqlDateTime>(fp_, fy_, default);
				CqlInterval<CqlDateTime> gb_ = FHIRHelpers_4_3_000.Instance.ToInterval(context, fq_);
				CqlDateTime gc_ = context.Operators.Start(gb_);
				bool? gd_ = context.Operators.Not((bool?)(gc_ is null));
				bool? ge_ = context.Operators.And(fz_, gd_);
				bool? gf_ = context.Operators.And(fm_, ge_);

				return gf_;
			};
			IEnumerable<Encounter> r_ = context.Operators.Where<Encounter>(p_, q_);
			object s_(Encounter @this)
			{
				Period gg_ = @this?.Period;
				CqlInterval<CqlDateTime> gh_ = FHIRHelpers_4_3_000.Instance.ToInterval(context, gg_);
				CqlDateTime gi_ = context.Operators.End(gh_);

				return gi_;
			};
			IEnumerable<Encounter> t_ = context.Operators.SortBy<Encounter>(r_, s_, System.ComponentModel.ListSortDirection.Ascending);
			Encounter u_ = context.Operators.Last<Encounter>(t_);
			Period v_ = u_?.Period;
			CqlInterval<CqlDateTime> w_ = FHIRHelpers_4_3_000.Instance.ToInterval(context, v_);
			CqlDateTime x_ = context.Operators.Start(w_);
			Period y_ = Visit?.Period;
			CqlInterval<CqlDateTime> z_ = FHIRHelpers_4_3_000.Instance.ToInterval(context, y_);
			CqlDateTime aa_ = context.Operators.Start(z_);
			CqlInterval<CqlDateTime> ac_ = FHIRHelpers_4_3_000.Instance.ToInterval(context, y_);
			CqlDateTime ad_ = context.Operators.End(ac_);
			CqlInterval<CqlDateTime> ae_ = context.Operators.Interval(n_ ?? x_ ?? aa_, ad_, true, true);

			return ae_;
		};
		IEnumerable<CqlInterval<CqlDateTime>> c_ = context.Operators.Select<Encounter, CqlInterval<CqlDateTime>>((IEnumerable<Encounter>)a_, b_);
		CqlInterval<CqlDateTime> d_ = context.Operators.SingletonFrom<CqlInterval<CqlDateTime>>(c_);

		return d_;
	}

	public int? HospitalizationWithObservationLengthofStay(CqlContext context, Encounter TheEncounter)
	{
		CqlInterval<CqlDateTime> a_ = this.HospitalizationWithObservation(context, TheEncounter);
		int? b_ = this.LengthInDays(context, a_);

		return b_;
	}

	public int? hospitalizationWithObservationLengthofStay(CqlContext context, Encounter TheEncounter)
	{
		CqlInterval<CqlDateTime> a_ = this.hospitalizationWithObservation(context, TheEncounter);
		int? b_ = this.lengthInDays(context, a_);

		return b_;
	}

	public Encounter.LocationComponent FirstInpatientIntensiveCareUnit(CqlContext context, Encounter Encounter)
	{
		List<Encounter.LocationComponent> a_ = Encounter?.Location;
		bool? b_(Encounter.LocationComponent HospitalLocation)
		{
			ResourceReference g_ = HospitalLocation?.Location;
			Location h_ = this.GetLocation(context, g_);
			List<CodeableConcept> i_ = h_?.Type;
			CqlConcept j_(CodeableConcept @this)
			{
				CqlConcept t_ = FHIRHelpers_4_3_000.Instance.ToConcept(context, @this);

				return t_;
			};
			IEnumerable<CqlConcept> k_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)i_, j_);
			CqlValueSet l_ = this.Intensive_Care_Unit(context);
			bool? m_ = context.Operators.ConceptsInValueSet(k_, l_);
			Period n_ = Encounter?.Period;
			CqlInterval<CqlDateTime> o_ = FHIRHelpers_4_3_000.Instance.ToInterval(context, n_);
			Period p_ = HospitalLocation?.Period;
			CqlInterval<CqlDateTime> q_ = FHIRHelpers_4_3_000.Instance.ToInterval(context, p_);
			bool? r_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(o_, q_, default);
			bool? s_ = context.Operators.And(m_, r_);

			return s_;
		};
		IEnumerable<Encounter.LocationComponent> c_ = context.Operators.Where<Encounter.LocationComponent>((IEnumerable<Encounter.LocationComponent>)a_, b_);
		object d_(Encounter.LocationComponent @this)
		{
			Period u_ = @this?.Period;
			CqlInterval<CqlDateTime> v_ = FHIRHelpers_4_3_000.Instance.ToInterval(context, u_);
			CqlDateTime w_ = context.Operators.Start(v_);

			return w_;
		};
		IEnumerable<Encounter.LocationComponent> e_ = context.Operators.SortBy<Encounter.LocationComponent>(c_, d_, System.ComponentModel.ListSortDirection.Ascending);
		Encounter.LocationComponent f_ = context.Operators.First<Encounter.LocationComponent>(e_);

		return f_;
	}

	public Encounter.LocationComponent firstInpatientIntensiveCareUnit(CqlContext context, Encounter Encounter)
	{
		List<Encounter.LocationComponent> a_ = Encounter?.Location;
		bool? b_(Encounter.LocationComponent HospitalLocation)
		{
			ResourceReference g_ = HospitalLocation?.Location;
			Location h_ = this.GetLocation(context, g_);
			List<CodeableConcept> i_ = h_?.Type;
			CqlConcept j_(CodeableConcept @this)
			{
				CqlConcept t_ = FHIRHelpers_4_3_000.Instance.ToConcept(context, @this);

				return t_;
			};
			IEnumerable<CqlConcept> k_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)i_, j_);
			CqlValueSet l_ = this.Intensive_Care_Unit(context);
			bool? m_ = context.Operators.ConceptsInValueSet(k_, l_);
			Period n_ = Encounter?.Period;
			CqlInterval<CqlDateTime> o_ = FHIRHelpers_4_3_000.Instance.ToInterval(context, n_);
			Period p_ = HospitalLocation?.Period;
			CqlInterval<CqlDateTime> q_ = FHIRHelpers_4_3_000.Instance.ToInterval(context, p_);
			bool? r_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(o_, q_, default);
			bool? s_ = context.Operators.And(m_, r_);

			return s_;
		};
		IEnumerable<Encounter.LocationComponent> c_ = context.Operators.Where<Encounter.LocationComponent>((IEnumerable<Encounter.LocationComponent>)a_, b_);
		object d_(Encounter.LocationComponent @this)
		{
			Period u_ = @this?.Period;
			CqlInterval<CqlDateTime> v_ = FHIRHelpers_4_3_000.Instance.ToInterval(context, u_);
			CqlDateTime w_ = context.Operators.Start(v_);

			return w_;
		};
		IEnumerable<Encounter.LocationComponent> e_ = context.Operators.SortBy<Encounter.LocationComponent>(c_, d_, System.ComponentModel.ListSortDirection.Ascending);
		Encounter.LocationComponent f_ = context.Operators.First<Encounter.LocationComponent>(e_);

		return f_;
	}

	public IEnumerable<Condition> EncounterDiagnosis(CqlContext context, Encounter Encounter)
	{
		List<Encounter.DiagnosisComponent> a_ = Encounter?.Diagnosis;
		Condition b_(Encounter.DiagnosisComponent D)
		{
			IEnumerable<Condition> d_ = context.Operators.RetrieveByValueSet<Condition>(default, default);
			bool? e_(Condition C)
			{
				Id h_ = C?.IdElement;
				string i_ = h_?.Value;
				ResourceReference j_ = D?.Condition;
				FhirString k_ = j_?.ReferenceElement;
				string l_ = k_?.Value;
				string m_ = QICoreCommon_2_0_000.Instance.getId(context, l_);
				bool? n_ = context.Operators.Equal(i_, m_);

				return n_;
			};
			IEnumerable<Condition> f_ = context.Operators.Where<Condition>(d_, e_);
			Condition g_ = context.Operators.SingletonFrom<Condition>(f_);

			return g_;
		};
		IEnumerable<Condition> c_ = context.Operators.Select<Encounter.DiagnosisComponent, Condition>((IEnumerable<Encounter.DiagnosisComponent>)a_, b_);

		return c_;
	}

	public IEnumerable<Condition> encounterDiagnosis(CqlContext context, Encounter Encounter)
	{
		List<Encounter.DiagnosisComponent> a_ = Encounter?.Diagnosis;
		Condition b_(Encounter.DiagnosisComponent D)
		{
			IEnumerable<Condition> d_ = context.Operators.RetrieveByValueSet<Condition>(default, default);
			bool? e_(Condition C)
			{
				Id h_ = C?.IdElement;
				string i_ = h_?.Value;
				ResourceReference j_ = D?.Condition;
				FhirString k_ = j_?.ReferenceElement;
				string l_ = k_?.Value;
				string m_ = QICoreCommon_2_0_000.Instance.getId(context, l_);
				bool? n_ = context.Operators.Equal(i_, m_);

				return n_;
			};
			IEnumerable<Condition> f_ = context.Operators.Where<Condition>(d_, e_);
			Condition g_ = context.Operators.SingletonFrom<Condition>(f_);

			return g_;
		};
		IEnumerable<Condition> c_ = context.Operators.Select<Encounter.DiagnosisComponent, Condition>((IEnumerable<Encounter.DiagnosisComponent>)a_, b_);

		return c_;
	}

	public Condition GetCondition(CqlContext context, ResourceReference reference)
	{
		IEnumerable<Condition> a_ = context.Operators.RetrieveByValueSet<Condition>(default, default);
		bool? b_(Condition C)
		{
			Id e_ = C?.IdElement;
			string f_ = e_?.Value;
			FhirString g_ = reference?.ReferenceElement;
			string h_ = g_?.Value;
			string i_ = QICoreCommon_2_0_000.Instance.getId(context, h_);
			bool? j_ = context.Operators.Equal(f_, i_);

			return j_;
		};
		IEnumerable<Condition> c_ = context.Operators.Where<Condition>(a_, b_);
		Condition d_ = context.Operators.SingletonFrom<Condition>(c_);

		return d_;
	}

	public Condition getCondition(CqlContext context, ResourceReference reference)
	{
		IEnumerable<Condition> a_ = context.Operators.RetrieveByValueSet<Condition>(default, default);
		bool? b_(Condition C)
		{
			Id e_ = C?.IdElement;
			string f_ = e_?.Value;
			FhirString g_ = reference?.ReferenceElement;
			string h_ = g_?.Value;
			string i_ = QICoreCommon_2_0_000.Instance.getId(context, h_);
			bool? j_ = context.Operators.Equal(f_, i_);

			return j_;
		};
		IEnumerable<Condition> c_ = context.Operators.Where<Condition>(a_, b_);
		Condition d_ = context.Operators.SingletonFrom<Condition>(c_);

		return d_;
	}

	public Condition PrincipalDiagnosis(CqlContext context, Encounter Encounter)
	{
		List<Encounter.DiagnosisComponent> a_ = Encounter?.Diagnosis;
		bool? b_(Encounter.DiagnosisComponent D)
		{
			PositiveInt g_ = D?.RankElement;
			int? h_ = g_?.Value;
			bool? i_ = context.Operators.Equal(h_, 1);

			return i_;
		};
		IEnumerable<Encounter.DiagnosisComponent> c_ = context.Operators.Where<Encounter.DiagnosisComponent>((IEnumerable<Encounter.DiagnosisComponent>)a_, b_);
		Condition d_(Encounter.DiagnosisComponent PD)
		{
			IEnumerable<Condition> j_ = context.Operators.RetrieveByValueSet<Condition>(default, default);
			bool? k_(Condition C)
			{
				Id n_ = C?.IdElement;
				string o_ = n_?.Value;
				ResourceReference p_ = PD?.Condition;
				FhirString q_ = p_?.ReferenceElement;
				string r_ = q_?.Value;
				string s_ = QICoreCommon_2_0_000.Instance.getId(context, r_);
				bool? t_ = context.Operators.Equal(o_, s_);

				return t_;
			};
			IEnumerable<Condition> l_ = context.Operators.Where<Condition>(j_, k_);
			Condition m_ = context.Operators.SingletonFrom<Condition>(l_);

			return m_;
		};
		IEnumerable<Condition> e_ = context.Operators.Select<Encounter.DiagnosisComponent, Condition>(c_, d_);
		Condition f_ = context.Operators.SingletonFrom<Condition>(e_);

		return f_;
	}

	public Condition principalDiagnosis(CqlContext context, Encounter Encounter)
	{
		List<Encounter.DiagnosisComponent> a_ = Encounter?.Diagnosis;
		bool? b_(Encounter.DiagnosisComponent D)
		{
			PositiveInt g_ = D?.RankElement;
			int? h_ = g_?.Value;
			bool? i_ = context.Operators.Equal(h_, 1);

			return i_;
		};
		IEnumerable<Encounter.DiagnosisComponent> c_ = context.Operators.Where<Encounter.DiagnosisComponent>((IEnumerable<Encounter.DiagnosisComponent>)a_, b_);
		Condition d_(Encounter.DiagnosisComponent PD)
		{
			IEnumerable<Condition> j_ = context.Operators.RetrieveByValueSet<Condition>(default, default);
			bool? k_(Condition C)
			{
				Id n_ = C?.IdElement;
				string o_ = n_?.Value;
				ResourceReference p_ = PD?.Condition;
				FhirString q_ = p_?.ReferenceElement;
				string r_ = q_?.Value;
				string s_ = QICoreCommon_2_0_000.Instance.getId(context, r_);
				bool? t_ = context.Operators.Equal(o_, s_);

				return t_;
			};
			IEnumerable<Condition> l_ = context.Operators.Where<Condition>(j_, k_);
			Condition m_ = context.Operators.SingletonFrom<Condition>(l_);

			return m_;
		};
		IEnumerable<Condition> e_ = context.Operators.Select<Encounter.DiagnosisComponent, Condition>(c_, d_);
		Condition f_ = context.Operators.SingletonFrom<Condition>(e_);

		return f_;
	}

	public Location getLocation(CqlContext context, ResourceReference reference)
	{
		IEnumerable<Location> a_ = context.Operators.RetrieveByValueSet<Location>(default, default);
		bool? b_(Location L)
		{
			Id e_ = L?.IdElement;
			string f_ = e_?.Value;
			FhirString g_ = reference?.ReferenceElement;
			string h_ = g_?.Value;
			string i_ = QICoreCommon_2_0_000.Instance.getId(context, h_);
			bool? j_ = context.Operators.Equal(f_, i_);

			return j_;
		};
		IEnumerable<Location> c_ = context.Operators.Where<Location>(a_, b_);
		Location d_ = context.Operators.SingletonFrom<Location>(c_);

		return d_;
	}

	public CqlConcept GetMedicationCode(CqlContext context, MedicationRequest request)
	{
		CqlConcept a_()
		{
			bool b_()
			{
				DataType c_ = request?.Medication;
				object d_ = FHIRHelpers_4_3_000.Instance.ToValue(context, c_);
				bool e_ = d_ is CqlConcept;

				return e_;
			};
			if (b_())
			{
				DataType f_ = request?.Medication;
				object g_ = FHIRHelpers_4_3_000.Instance.ToValue(context, f_);

				return g_ as CqlConcept;
			}
			else
			{
				IEnumerable<Medication> h_ = context.Operators.RetrieveByValueSet<Medication>(default, default);
				bool? i_(Medication M)
				{
					Id n_ = M?.IdElement;
					string o_ = n_?.Value;
					DataType p_ = request?.Medication;
					object q_ = FHIRHelpers_4_3_000.Instance.ToValue(context, p_);
					FhirString r_ = (q_ as ResourceReference)?.ReferenceElement;
					string s_ = r_?.Value;
					string t_ = QICoreCommon_2_0_000.Instance.getId(context, s_);
					bool? u_ = context.Operators.Equal(o_, t_);

					return u_;
				};
				IEnumerable<Medication> j_ = context.Operators.Where<Medication>(h_, i_);
				Medication k_ = context.Operators.SingletonFrom<Medication>(j_);
				CodeableConcept l_ = k_?.Code;
				CqlConcept m_ = FHIRHelpers_4_3_000.Instance.ToConcept(context, l_);

				return m_;
			}
		};

		return a_();
	}

	public CqlConcept getMedicationCode(CqlContext context, MedicationRequest request)
	{
		CqlConcept a_()
		{
			bool b_()
			{
				DataType c_ = request?.Medication;
				object d_ = FHIRHelpers_4_3_000.Instance.ToValue(context, c_);
				bool e_ = d_ is CqlConcept;

				return e_;
			};
			if (b_())
			{
				DataType f_ = request?.Medication;
				object g_ = FHIRHelpers_4_3_000.Instance.ToValue(context, f_);

				return g_ as CqlConcept;
			}
			else
			{
				IEnumerable<Medication> h_ = context.Operators.RetrieveByValueSet<Medication>(default, default);
				bool? i_(Medication M)
				{
					Id n_ = M?.IdElement;
					string o_ = n_?.Value;
					DataType p_ = request?.Medication;
					object q_ = FHIRHelpers_4_3_000.Instance.ToValue(context, p_);
					FhirString r_ = (q_ as ResourceReference)?.ReferenceElement;
					string s_ = r_?.Value;
					string t_ = QICoreCommon_2_0_000.Instance.getId(context, s_);
					bool? u_ = context.Operators.Equal(o_, t_);

					return u_;
				};
				IEnumerable<Medication> j_ = context.Operators.Where<Medication>(h_, i_);
				Medication k_ = context.Operators.SingletonFrom<Medication>(j_);
				CodeableConcept l_ = k_?.Code;
				CqlConcept m_ = FHIRHelpers_4_3_000.Instance.ToConcept(context, l_);

				return m_;
			}
		};

		return a_();
	}

}
