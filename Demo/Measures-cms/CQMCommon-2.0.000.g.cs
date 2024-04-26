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
[CqlLibrary("CQMCommon", "2.0.000")]
public class CQMCommon_2_0_000
{


    internal CqlContext context;

    #region Cached values

    internal Lazy<CqlValueSet> __Emergency_Department_Visit;
    internal Lazy<CqlValueSet> __Encounter_Inpatient;
    internal Lazy<CqlValueSet> __Intensive_Care_Unit;
    internal Lazy<CqlValueSet> __Observation_Services;
    internal Lazy<CqlValueSet> __Outpatient_Surgery_Service;
    internal Lazy<CqlValueSet> __Present_on_Admission_or_Clinically_Undetermined;
    internal Lazy<CqlInterval<CqlDateTime>> __Measurement_Period;
    internal Lazy<Patient> __Patient;
    internal Lazy<IEnumerable<Encounter>> __Inpatient_Encounter;

    #endregion
    public CQMCommon_2_0_000(CqlContext context)
    {
        this.context = context ?? throw new ArgumentNullException("context");

        FHIRHelpers_4_3_000 = new FHIRHelpers_4_3_000(context);
        QICoreCommon_2_0_000 = new QICoreCommon_2_0_000(context);

        __Emergency_Department_Visit = new Lazy<CqlValueSet>(this.Emergency_Department_Visit_Value);
        __Encounter_Inpatient = new Lazy<CqlValueSet>(this.Encounter_Inpatient_Value);
        __Intensive_Care_Unit = new Lazy<CqlValueSet>(this.Intensive_Care_Unit_Value);
        __Observation_Services = new Lazy<CqlValueSet>(this.Observation_Services_Value);
        __Outpatient_Surgery_Service = new Lazy<CqlValueSet>(this.Outpatient_Surgery_Service_Value);
        __Present_on_Admission_or_Clinically_Undetermined = new Lazy<CqlValueSet>(this.Present_on_Admission_or_Clinically_Undetermined_Value);
        __Measurement_Period = new Lazy<CqlInterval<CqlDateTime>>(this.Measurement_Period_Value);
        __Patient = new Lazy<Patient>(this.Patient_Value);
        __Inpatient_Encounter = new Lazy<IEnumerable<Encounter>>(this.Inpatient_Encounter_Value);
    }
    #region Dependencies

    public FHIRHelpers_4_3_000 FHIRHelpers_4_3_000 { get; }
    public QICoreCommon_2_0_000 QICoreCommon_2_0_000 { get; }

    #endregion

	private CqlValueSet Emergency_Department_Visit_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.292", null);

    [CqlDeclaration("Emergency Department Visit")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.292")]
	public CqlValueSet Emergency_Department_Visit() => 
		__Emergency_Department_Visit.Value;

	private CqlValueSet Encounter_Inpatient_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.666.5.307", null);

    [CqlDeclaration("Encounter Inpatient")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.666.5.307")]
	public CqlValueSet Encounter_Inpatient() => 
		__Encounter_Inpatient.Value;

	private CqlValueSet Intensive_Care_Unit_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1029.206", null);

    [CqlDeclaration("Intensive Care Unit")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1029.206")]
	public CqlValueSet Intensive_Care_Unit() => 
		__Intensive_Care_Unit.Value;

	private CqlValueSet Observation_Services_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1111.143", null);

    [CqlDeclaration("Observation Services")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1111.143")]
	public CqlValueSet Observation_Services() => 
		__Observation_Services.Value;

	private CqlValueSet Outpatient_Surgery_Service_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1110.38", null);

    [CqlDeclaration("Outpatient Surgery Service")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1110.38")]
	public CqlValueSet Outpatient_Surgery_Service() => 
		__Outpatient_Surgery_Service.Value;

	private CqlValueSet Present_on_Admission_or_Clinically_Undetermined_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1147.197", null);

    [CqlDeclaration("Present on Admission or Clinically Undetermined")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1147.197")]
	public CqlValueSet Present_on_Admission_or_Clinically_Undetermined() => 
		__Present_on_Admission_or_Clinically_Undetermined.Value;

	private CqlInterval<CqlDateTime> Measurement_Period_Value()
	{
		CqlDateTime a_ = context.Operators.DateTime(2025, 1, 1, 0, 0, 0, 0, default);
		CqlDateTime b_ = context.Operators.DateTime(2026, 1, 1, 0, 0, 0, 0, default);
		CqlInterval<CqlDateTime> c_ = context.Operators.Interval(a_, b_, true, false);
		object d_ = context.ResolveParameter("CQMCommon-2.0.000", "Measurement Period", c_);

		return (CqlInterval<CqlDateTime>)d_;
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

	private IEnumerable<Encounter> Inpatient_Encounter_Value()
	{
		CqlValueSet a_ = this.Encounter_Inpatient();
		IEnumerable<Encounter> b_ = context.Operators.RetrieveByValueSet<Encounter>(a_, null);
		bool? c_(Encounter EncounterInpatient)
		{
			Code<Encounter.EncounterStatus> e_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(EncounterInpatient?.StatusElement?.Value);
			bool? f_ = context.Operators.Equal(e_, "finished");
			CqlInterval<CqlDateTime> g_ = FHIRHelpers_4_3_000.ToInterval(EncounterInpatient?.Period);
			CqlDateTime h_ = context.Operators.End(g_);
			CqlInterval<CqlDateTime> i_ = this.Measurement_Period();
			bool? j_ = context.Operators.In<CqlDateTime>(h_, i_, "day");
			bool? k_ = context.Operators.And(f_, j_);

			return k_;
		};
		IEnumerable<Encounter> d_ = context.Operators.Where<Encounter>(b_, c_);

		return d_;
	}

    [CqlDeclaration("Inpatient Encounter")]
	public IEnumerable<Encounter> Inpatient_Encounter() => 
		__Inpatient_Encounter.Value;

    [CqlDeclaration("ToDateInterval")]
    [CqlTag("description", "Returns an interval of date values extracted from the input interval of date-time values")]
    [CqlTag("comment", "This function returns an interval constructed using the `date from` extractor on the start and end values of the input date-time interval. Note that using a precision specifier such as `day of` as part of a timing phrase is preferred to communicate intent to perform day-level comparison, as well as for general readability.")]
	public CqlInterval<CqlDate> ToDateInterval(CqlInterval<CqlDateTime> period)
	{
		CqlDateTime a_ = context.Operators.Start(period);
		CqlDate b_ = context.Operators.DateFrom(a_);
		CqlDateTime c_ = context.Operators.End(period);
		CqlDate d_ = context.Operators.DateFrom(c_);
		CqlInterval<CqlDate> e_ = context.Operators.Interval(b_, d_, true, true);

		return e_;
	}

    [CqlDeclaration("LengthInDays")]
    [CqlTag("description", "Calculates the difference in calendar days between the start and end of the given interval.")]
    [CqlTag("deprecated", "This function in deprecated. Use the fluent function `lengthInDays()` instead.")]
	public int? LengthInDays(CqlInterval<CqlDateTime> Value)
	{
		CqlDateTime a_ = context.Operators.Start(Value);
		CqlDateTime b_ = context.Operators.End(Value);
		int? c_ = context.Operators.DifferenceBetween(a_, b_, "day");

		return c_;
	}

    [CqlDeclaration("lengthInDays")]
    [CqlTag("description", "Calculates the difference in calendar days between the start and end of the given interval.")]
	public int? lengthInDays(CqlInterval<CqlDateTime> Value)
	{
		CqlDateTime a_ = context.Operators.Start(Value);
		CqlDateTime b_ = context.Operators.End(Value);
		int? c_ = context.Operators.DifferenceBetween(a_, b_, "day");

		return c_;
	}

    [CqlDeclaration("ED Visit")]
    [CqlTag("description", "Returns the most recent emergency department visit, if any, that occurs 1 hour or less prior to the given encounter.")]
    [CqlTag("deprecated", "This function is deprecated. Use the fluent function `edVisit()` instead.")]
	public Encounter ED_Visit(Encounter TheEncounter)
	{
		CqlValueSet a_ = this.Emergency_Department_Visit();
		IEnumerable<Encounter> b_ = context.Operators.RetrieveByValueSet<Encounter>(a_, null);
		bool? c_(Encounter EDVisit)
		{
			Code<Encounter.EncounterStatus> h_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(EDVisit?.StatusElement?.Value);
			bool? i_ = context.Operators.Equal(h_, "finished");
			CqlInterval<CqlDateTime> j_ = FHIRHelpers_4_3_000.ToInterval(EDVisit?.Period);
			CqlDateTime k_ = context.Operators.End(j_);
			CqlInterval<CqlDateTime> l_ = FHIRHelpers_4_3_000.ToInterval(TheEncounter?.Period);
			CqlDateTime m_ = context.Operators.Start(l_);
			CqlQuantity n_ = context.Operators.Quantity(1m, "hour");
			CqlDateTime o_ = context.Operators.Subtract(m_, n_);
			CqlDateTime q_ = context.Operators.Start(l_);
			CqlInterval<CqlDateTime> r_ = context.Operators.Interval(o_, q_, true, true);
			bool? s_ = context.Operators.In<CqlDateTime>(k_, r_, null);
			CqlDateTime u_ = context.Operators.Start(l_);
			bool? v_ = context.Operators.Not((bool?)(u_ is null));
			bool? w_ = context.Operators.And(s_, v_);
			bool? x_ = context.Operators.And(i_, w_);

			return x_;
		};
		IEnumerable<Encounter> d_ = context.Operators.Where<Encounter>(b_, c_);
		object e_(Encounter @this)
		{
			CqlInterval<CqlDateTime> y_ = FHIRHelpers_4_3_000.ToInterval(@this?.Period);
			CqlDateTime z_ = context.Operators.End(y_);

			return z_;
		};
		IEnumerable<Encounter> f_ = context.Operators.SortBy<Encounter>(d_, e_, System.ComponentModel.ListSortDirection.Ascending);
		Encounter g_ = context.Operators.Last<Encounter>(f_);

		return g_;
	}

    [CqlDeclaration("edVisit")]
    [CqlTag("description", "Returns the most recent emergency department visit, if any, that occurs 1 hour or less prior to the given encounter.")]
	public Encounter edVisit(Encounter TheEncounter)
	{
		CqlValueSet a_ = this.Emergency_Department_Visit();
		IEnumerable<Encounter> b_ = context.Operators.RetrieveByValueSet<Encounter>(a_, null);
		bool? c_(Encounter EDVisit)
		{
			Code<Encounter.EncounterStatus> h_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(EDVisit?.StatusElement?.Value);
			bool? i_ = context.Operators.Equal(h_, "finished");
			CqlInterval<CqlDateTime> j_ = FHIRHelpers_4_3_000.ToInterval(EDVisit?.Period);
			CqlDateTime k_ = context.Operators.End(j_);
			CqlInterval<CqlDateTime> l_ = FHIRHelpers_4_3_000.ToInterval(TheEncounter?.Period);
			CqlDateTime m_ = context.Operators.Start(l_);
			CqlQuantity n_ = context.Operators.Quantity(1m, "hour");
			CqlDateTime o_ = context.Operators.Subtract(m_, n_);
			CqlDateTime q_ = context.Operators.Start(l_);
			CqlInterval<CqlDateTime> r_ = context.Operators.Interval(o_, q_, true, true);
			bool? s_ = context.Operators.In<CqlDateTime>(k_, r_, null);
			CqlDateTime u_ = context.Operators.Start(l_);
			bool? v_ = context.Operators.Not((bool?)(u_ is null));
			bool? w_ = context.Operators.And(s_, v_);
			bool? x_ = context.Operators.And(i_, w_);

			return x_;
		};
		IEnumerable<Encounter> d_ = context.Operators.Where<Encounter>(b_, c_);
		object e_(Encounter @this)
		{
			CqlInterval<CqlDateTime> y_ = FHIRHelpers_4_3_000.ToInterval(@this?.Period);
			CqlDateTime z_ = context.Operators.End(y_);

			return z_;
		};
		IEnumerable<Encounter> f_ = context.Operators.SortBy<Encounter>(d_, e_, System.ComponentModel.ListSortDirection.Ascending);
		Encounter g_ = context.Operators.Last<Encounter>(f_);

		return g_;
	}

    [CqlDeclaration("Hospitalization")]
    [CqlTag("description", "Hospitalization returns the total interval for admission to discharge for the given encounter, or for the admission of any immediately prior emergency department visit to the discharge of the given encounter.")]
    [CqlTag("deprecated", "This function is deprecated. Use the fluent function `hospitalization()` instead.")]
	public CqlInterval<CqlDateTime> Hospitalization(Encounter TheEncounter)
	{
		Encounter a_ = this.ED_Visit(TheEncounter);
		Encounter[] b_ = new Encounter[]
		{
			a_,
		};
		CqlInterval<CqlDateTime> c_(Encounter X)
		{
			CqlInterval<CqlDateTime> f_()
			{
				if ((X is null))
				{
					CqlInterval<CqlDateTime> g_ = FHIRHelpers_4_3_000.ToInterval(TheEncounter?.Period);

					return g_;
				}
				else
				{
					CqlInterval<CqlDateTime> h_ = FHIRHelpers_4_3_000.ToInterval(X?.Period);
					CqlDateTime i_ = context.Operators.Start(h_);
					CqlInterval<CqlDateTime> j_ = FHIRHelpers_4_3_000.ToInterval(TheEncounter?.Period);
					CqlDateTime k_ = context.Operators.End(j_);
					CqlInterval<CqlDateTime> l_ = context.Operators.Interval(i_, k_, true, false);

					return l_;
				};
			};

			return f_();
		};
		IEnumerable<CqlInterval<CqlDateTime>> d_ = context.Operators.Select<Encounter, CqlInterval<CqlDateTime>>(b_, c_);
		CqlInterval<CqlDateTime> e_ = context.Operators.SingletonFrom<CqlInterval<CqlDateTime>>(d_);

		return e_;
	}

    [CqlDeclaration("hospitalization")]
    [CqlTag("description", "Hospitalization returns the total interval for admission to discharge for the given encounter, or for the admission of any immediately prior emergency department visit to the discharge of the given encounter.")]
	public CqlInterval<CqlDateTime> hospitalization(Encounter TheEncounter)
	{
		Encounter a_ = this.edVisit(TheEncounter);
		Encounter[] b_ = new Encounter[]
		{
			a_,
		};
		CqlInterval<CqlDateTime> c_(Encounter X)
		{
			CqlInterval<CqlDateTime> f_()
			{
				if ((X is null))
				{
					CqlInterval<CqlDateTime> g_ = FHIRHelpers_4_3_000.ToInterval(TheEncounter?.Period);

					return g_;
				}
				else
				{
					CqlInterval<CqlDateTime> h_ = FHIRHelpers_4_3_000.ToInterval(X?.Period);
					CqlDateTime i_ = context.Operators.Start(h_);
					CqlInterval<CqlDateTime> j_ = FHIRHelpers_4_3_000.ToInterval(TheEncounter?.Period);
					CqlDateTime k_ = context.Operators.End(j_);
					CqlInterval<CqlDateTime> l_ = context.Operators.Interval(i_, k_, true, true);

					return l_;
				};
			};

			return f_();
		};
		IEnumerable<CqlInterval<CqlDateTime>> d_ = context.Operators.Select<Encounter, CqlInterval<CqlDateTime>>(b_, c_);
		CqlInterval<CqlDateTime> e_ = context.Operators.SingletonFrom<CqlInterval<CqlDateTime>>(d_);

		return e_;
	}

    [CqlDeclaration("Hospitalization Locations")]
    [CqlTag("description", "Returns list of all locations within an encounter, including locations for immediately prior ED visit.")]
    [CqlTag("deprecated", "This function is deprecated. Use the fluent function `hospitalizationLocations()` instead.")]
	public IEnumerable<Encounter.LocationComponent> Hospitalization_Locations(Encounter TheEncounter)
	{
		Encounter a_ = this.ED_Visit(TheEncounter);
		Encounter[] b_ = new Encounter[]
		{
			a_,
		};
		IEnumerable<Encounter.LocationComponent> c_(Encounter EDEncounter)
		{
			IEnumerable<Encounter.LocationComponent> f_()
			{
				if ((EDEncounter is null))
				{
					return (TheEncounter?.Location as IEnumerable<Encounter.LocationComponent>);
				}
				else
				{
					IEnumerable<Encounter.LocationComponent>[] g_ = new IEnumerable<Encounter.LocationComponent>[]
					{
						(EDEncounter?.Location as IEnumerable<Encounter.LocationComponent>),
						(TheEncounter?.Location as IEnumerable<Encounter.LocationComponent>),
					};
					IEnumerable<Encounter.LocationComponent> h_ = context.Operators.Flatten<Encounter.LocationComponent>((g_ as IEnumerable<IEnumerable<Encounter.LocationComponent>>));

					return h_;
				};
			};

			return f_();
		};
		IEnumerable<IEnumerable<Encounter.LocationComponent>> d_ = context.Operators.Select<Encounter, IEnumerable<Encounter.LocationComponent>>(b_, c_);
		IEnumerable<Encounter.LocationComponent> e_ = context.Operators.SingletonFrom<IEnumerable<Encounter.LocationComponent>>(d_);

		return e_;
	}

    [CqlDeclaration("hospitalizationLocations")]
    [CqlTag("description", "Returns list of all locations within an encounter, including locations for immediately prior ED visit.")]
	public IEnumerable<Encounter.LocationComponent> hospitalizationLocations(Encounter TheEncounter)
	{
		Encounter a_ = this.edVisit(TheEncounter);
		Encounter[] b_ = new Encounter[]
		{
			a_,
		};
		IEnumerable<Encounter.LocationComponent> c_(Encounter EDEncounter)
		{
			IEnumerable<Encounter.LocationComponent> f_()
			{
				if ((EDEncounter is null))
				{
					return (TheEncounter?.Location as IEnumerable<Encounter.LocationComponent>);
				}
				else
				{
					IEnumerable<Encounter.LocationComponent>[] g_ = new IEnumerable<Encounter.LocationComponent>[]
					{
						(EDEncounter?.Location as IEnumerable<Encounter.LocationComponent>),
						(TheEncounter?.Location as IEnumerable<Encounter.LocationComponent>),
					};
					IEnumerable<Encounter.LocationComponent> h_ = context.Operators.Flatten<Encounter.LocationComponent>((g_ as IEnumerable<IEnumerable<Encounter.LocationComponent>>));

					return h_;
				};
			};

			return f_();
		};
		IEnumerable<IEnumerable<Encounter.LocationComponent>> d_ = context.Operators.Select<Encounter, IEnumerable<Encounter.LocationComponent>>(b_, c_);
		IEnumerable<Encounter.LocationComponent> e_ = context.Operators.SingletonFrom<IEnumerable<Encounter.LocationComponent>>(d_);

		return e_;
	}

    [CqlDeclaration("Hospitalization Length of Stay")]
    [CqlTag("description", "Returns the length of stay in days (i.e. the number of days between admission and discharge) for the given encounter, or from the admission of any immediately prior emergency department visit to the discharge of the encounter")]
    [CqlTag("deprecated", "This function is deprecated. Use the fluent function `hospitalizationLengthOfStay()` instead.")]
	public int? Hospitalization_Length_of_Stay(Encounter TheEncounter)
	{
		CqlInterval<CqlDateTime> a_ = this.Hospitalization(TheEncounter);
		int? b_ = this.LengthInDays(a_);

		return b_;
	}

    [CqlDeclaration("hospitalizationLengthOfStay")]
    [CqlTag("description", "Returns the length of stay in days (i.e. the number of days between admission and discharge) for the given encounter, or from the admission of any immediately prior emergency department visit to the discharge of the encounter")]
	public int? hospitalizationLengthOfStay(Encounter TheEncounter)
	{
		CqlInterval<CqlDateTime> a_ = this.hospitalization(TheEncounter);
		int? b_ = this.lengthInDays(a_);

		return b_;
	}

    [CqlDeclaration("Hospital Admission Time")]
    [CqlTag("description", "Returns admission time for an encounter or for immediately prior emergency department visit.")]
    [CqlTag("deprecated", "This function is deprecated. Use the fluent function `hospitalAdmissionTime()` instead.")]
	public CqlDateTime Hospital_Admission_Time(Encounter TheEncounter)
	{
		CqlInterval<CqlDateTime> a_ = this.Hospitalization(TheEncounter);
		CqlDateTime b_ = context.Operators.Start(a_);

		return b_;
	}

    [CqlDeclaration("hospitalAdmissionTime")]
    [CqlTag("description", "Returns admission time for an encounter or for immediately prior emergency department visit.")]
	public CqlDateTime hospitalAdmissionTime(Encounter TheEncounter)
	{
		CqlInterval<CqlDateTime> a_ = this.hospitalization(TheEncounter);
		CqlDateTime b_ = context.Operators.Start(a_);

		return b_;
	}

    [CqlDeclaration("Hospital Discharge Time")]
    [CqlTag("description", "Hospital Discharge Time returns the discharge time for an encounter")]
    [CqlTag("deprecated", "This function is deprecated. Use the fluent function `hospitalDischargeTime()` instead.")]
	public CqlDateTime Hospital_Discharge_Time(Encounter TheEncounter)
	{
		CqlInterval<CqlDateTime> a_ = FHIRHelpers_4_3_000.ToInterval(TheEncounter?.Period);
		CqlDateTime b_ = context.Operators.End(a_);

		return b_;
	}

    [CqlDeclaration("hospitalDischargeTime")]
    [CqlTag("description", "Hospital Discharge Time returns the discharge time for an encounter")]
	public CqlDateTime hospitalDischargeTime(Encounter TheEncounter)
	{
		CqlInterval<CqlDateTime> a_ = FHIRHelpers_4_3_000.ToInterval(TheEncounter?.Period);
		CqlDateTime b_ = context.Operators.End(a_);

		return b_;
	}

    [CqlDeclaration("Hospital Arrival Time")]
    [CqlTag("description", "Returns earliest arrival time for an encounter including any prior ED visit.")]
    [CqlTag("deprecated", "This function is deprecated. Use the fluent function `hospitalArrivalTime()` instead.")]
	public CqlDateTime Hospital_Arrival_Time(Encounter TheEncounter)
	{
		IEnumerable<Encounter.LocationComponent> a_ = this.Hospitalization_Locations(TheEncounter);
		object b_(Encounter.LocationComponent @this)
		{
			CqlInterval<CqlDateTime> g_ = FHIRHelpers_4_3_000.ToInterval(@this?.Period);
			CqlDateTime h_ = context.Operators.Start(g_);

			return h_;
		};
		IEnumerable<Encounter.LocationComponent> c_ = context.Operators.SortBy<Encounter.LocationComponent>(a_, b_, System.ComponentModel.ListSortDirection.Ascending);
		Encounter.LocationComponent d_ = context.Operators.First<Encounter.LocationComponent>(c_);
		CqlInterval<CqlDateTime> e_ = FHIRHelpers_4_3_000.ToInterval(d_?.Period);
		CqlDateTime f_ = context.Operators.Start(e_);

		return f_;
	}

    [CqlDeclaration("hospitalArrivalTime")]
    [CqlTag("description", "Returns earliest arrival time for an encounter including any prior ED visit.")]
	public CqlDateTime hospitalArrivalTime(Encounter TheEncounter)
	{
		IEnumerable<Encounter.LocationComponent> a_ = this.hospitalizationLocations(TheEncounter);
		object b_(Encounter.LocationComponent @this)
		{
			CqlInterval<CqlDateTime> g_ = FHIRHelpers_4_3_000.ToInterval(@this?.Period);
			CqlDateTime h_ = context.Operators.Start(g_);

			return h_;
		};
		IEnumerable<Encounter.LocationComponent> c_ = context.Operators.SortBy<Encounter.LocationComponent>(a_, b_, System.ComponentModel.ListSortDirection.Ascending);
		Encounter.LocationComponent d_ = context.Operators.First<Encounter.LocationComponent>(c_);
		CqlInterval<CqlDateTime> e_ = FHIRHelpers_4_3_000.ToInterval(d_?.Period);
		CqlDateTime f_ = context.Operators.Start(e_);

		return f_;
	}

    [CqlDeclaration("Hospital Departure Time")]
    [CqlTag("description", "Returns the latest departure time for encounter including any prior ED visit.")]
    [CqlTag("deprecated", "This function is deprecated. Use the fluent function `hospitalDepartureTime()` instead.")]
	public CqlDateTime Hospital_Departure_Time(Encounter TheEncounter)
	{
		IEnumerable<Encounter.LocationComponent> a_ = this.Hospitalization_Locations(TheEncounter);
		object b_(Encounter.LocationComponent @this)
		{
			CqlInterval<CqlDateTime> g_ = FHIRHelpers_4_3_000.ToInterval(@this?.Period);
			CqlDateTime h_ = context.Operators.Start(g_);

			return h_;
		};
		IEnumerable<Encounter.LocationComponent> c_ = context.Operators.SortBy<Encounter.LocationComponent>(a_, b_, System.ComponentModel.ListSortDirection.Ascending);
		Encounter.LocationComponent d_ = context.Operators.Last<Encounter.LocationComponent>(c_);
		CqlInterval<CqlDateTime> e_ = FHIRHelpers_4_3_000.ToInterval(d_?.Period);
		CqlDateTime f_ = context.Operators.End(e_);

		return f_;
	}

    [CqlDeclaration("hospitalDepartureTime")]
    [CqlTag("description", "Returns the latest departure time for encounter including any prior ED visit.")]
	public CqlDateTime hospitalDepartureTime(Encounter TheEncounter)
	{
		IEnumerable<Encounter.LocationComponent> a_ = this.hospitalizationLocations(TheEncounter);
		object b_(Encounter.LocationComponent @this)
		{
			CqlInterval<CqlDateTime> g_ = FHIRHelpers_4_3_000.ToInterval(@this?.Period);
			CqlDateTime h_ = context.Operators.Start(g_);

			return h_;
		};
		IEnumerable<Encounter.LocationComponent> c_ = context.Operators.SortBy<Encounter.LocationComponent>(a_, b_, System.ComponentModel.ListSortDirection.Ascending);
		Encounter.LocationComponent d_ = context.Operators.Last<Encounter.LocationComponent>(c_);
		CqlInterval<CqlDateTime> e_ = FHIRHelpers_4_3_000.ToInterval(d_?.Period);
		CqlDateTime f_ = context.Operators.End(e_);

		return f_;
	}

    [CqlDeclaration("GetLocation")]
    [CqlTag("description", "Returns the Location resource specified by the given reference")]
    [CqlTag("deprecated", "This function is deprecated. Use the fluent function `getLocation()` instead.")]
	public Location GetLocation(ResourceReference reference)
	{
		IEnumerable<Location> a_ = context.Operators.RetrieveByValueSet<Location>(null, null);
		bool? b_(Location L)
		{
			string e_ = QICoreCommon_2_0_000.getId(reference?.ReferenceElement?.Value);
			bool? f_ = context.Operators.Equal(L?.IdElement?.Value, e_);

			return f_;
		};
		IEnumerable<Location> c_ = context.Operators.Where<Location>(a_, b_);
		Location d_ = context.Operators.SingletonFrom<Location>(c_);

		return d_;
	}

    [CqlDeclaration("Emergency Department Arrival Time")]
    [CqlTag("description", "Returns the emergency department arrival time for the encounter.")]
	public CqlDateTime Emergency_Department_Arrival_Time(Encounter TheEncounter)
	{
		IEnumerable<Encounter.LocationComponent> a_ = this.Hospitalization_Locations(TheEncounter);
		bool? b_(Encounter.LocationComponent HospitalLocation)
		{
			Location g_ = this.GetLocation(HospitalLocation?.Location);
			CqlConcept h_(CodeableConcept @this)
			{
				CqlConcept l_ = FHIRHelpers_4_3_000.ToConcept(@this);

				return l_;
			};
			IEnumerable<CqlConcept> i_ = context.Operators.Select<CodeableConcept, CqlConcept>(g_?.Type, h_);
			CqlValueSet j_ = this.Emergency_Department_Visit();
			bool? k_ = context.Operators.ConceptsInValueSet(i_, j_);

			return k_;
		};
		IEnumerable<Encounter.LocationComponent> c_ = context.Operators.Where<Encounter.LocationComponent>(a_, b_);
		Encounter.LocationComponent d_ = context.Operators.SingletonFrom<Encounter.LocationComponent>(c_);
		CqlInterval<CqlDateTime> e_ = FHIRHelpers_4_3_000.ToInterval(d_?.Period);
		CqlDateTime f_ = context.Operators.Start(e_);

		return f_;
	}

    [CqlDeclaration("emergencyDepartmentArrivalTime")]
    [CqlTag("description", "Returns the emergency department arrival time for the encounter.")]
	public CqlDateTime emergencyDepartmentArrivalTime(Encounter TheEncounter)
	{
		IEnumerable<Encounter.LocationComponent> a_ = this.hospitalizationLocations(TheEncounter);
		bool? b_(Encounter.LocationComponent HospitalLocation)
		{
			Location g_ = this.GetLocation(HospitalLocation?.Location);
			CqlConcept h_(CodeableConcept @this)
			{
				CqlConcept l_ = FHIRHelpers_4_3_000.ToConcept(@this);

				return l_;
			};
			IEnumerable<CqlConcept> i_ = context.Operators.Select<CodeableConcept, CqlConcept>(g_?.Type, h_);
			CqlValueSet j_ = this.Emergency_Department_Visit();
			bool? k_ = context.Operators.ConceptsInValueSet(i_, j_);

			return k_;
		};
		IEnumerable<Encounter.LocationComponent> c_ = context.Operators.Where<Encounter.LocationComponent>(a_, b_);
		Encounter.LocationComponent d_ = context.Operators.SingletonFrom<Encounter.LocationComponent>(c_);
		CqlInterval<CqlDateTime> e_ = FHIRHelpers_4_3_000.ToInterval(d_?.Period);
		CqlDateTime f_ = context.Operators.Start(e_);

		return f_;
	}

    [CqlDeclaration("HospitalizationWithObservationAndOutpatientSurgeryService")]
    [CqlTag("description", "Hospitalization with Observation and Outpatient Surgery Service returns the total interval from the start of any immediately prior emergency department visit, outpatient surgery visit or observation visit to the discharge of the given encounter.")]
    [CqlTag("deprecated", "This function is deprecated. Use the fluent function `hospitalizationWithObservationAndOutpatientSurgeryService()` instead.")]
	public CqlInterval<CqlDateTime> HospitalizationWithObservationAndOutpatientSurgeryService(Encounter TheEncounter)
	{
		Encounter[] a_ = new Encounter[]
		{
			TheEncounter,
		};
		CqlInterval<CqlDateTime> b_(Encounter Visit)
		{
			CqlValueSet e_ = this.Outpatient_Surgery_Service();
			IEnumerable<Encounter> f_ = context.Operators.RetrieveByValueSet<Encounter>(e_, null);
			bool? g_(Encounter LastSurgeryOP)
			{
				CqlInterval<CqlDateTime> ak_ = FHIRHelpers_4_3_000.ToInterval(LastSurgeryOP?.Period);
				CqlDateTime al_ = context.Operators.End(ak_);
				CqlValueSet am_ = this.Emergency_Department_Visit();
				IEnumerable<Encounter> an_ = context.Operators.RetrieveByValueSet<Encounter>(am_, null);
				bool? ao_(Encounter LastED)
				{
					Code<Encounter.EncounterStatus> da_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(LastED?.StatusElement?.Value);
					bool? db_ = context.Operators.Equal(da_, "finished");
					CqlInterval<CqlDateTime> dc_ = FHIRHelpers_4_3_000.ToInterval(LastED?.Period);
					CqlDateTime dd_ = context.Operators.End(dc_);
					CqlValueSet de_ = this.Observation_Services();
					IEnumerable<Encounter> df_ = context.Operators.RetrieveByValueSet<Encounter>(de_, null);
					bool? dg_(Encounter LastObs)
					{
						Code<Encounter.EncounterStatus> es_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(LastObs?.StatusElement?.Value);
						bool? et_ = context.Operators.Equal(es_, "finished");
						CqlInterval<CqlDateTime> eu_ = FHIRHelpers_4_3_000.ToInterval(LastObs?.Period);
						CqlDateTime ev_ = context.Operators.End(eu_);
						CqlInterval<CqlDateTime> ew_ = FHIRHelpers_4_3_000.ToInterval(Visit?.Period);
						CqlDateTime ex_ = context.Operators.Start(ew_);
						CqlQuantity ey_ = context.Operators.Quantity(1m, "hour");
						CqlDateTime ez_ = context.Operators.Subtract(ex_, ey_);
						CqlDateTime fb_ = context.Operators.Start(ew_);
						CqlInterval<CqlDateTime> fc_ = context.Operators.Interval(ez_, fb_, true, true);
						bool? fd_ = context.Operators.In<CqlDateTime>(ev_, fc_, null);
						CqlDateTime ff_ = context.Operators.Start(ew_);
						bool? fg_ = context.Operators.Not((bool?)(ff_ is null));
						bool? fh_ = context.Operators.And(fd_, fg_);
						bool? fi_ = context.Operators.And(et_, fh_);

						return fi_;
					};
					IEnumerable<Encounter> dh_ = context.Operators.Where<Encounter>(df_, dg_);
					object di_(Encounter @this)
					{
						CqlInterval<CqlDateTime> fj_ = FHIRHelpers_4_3_000.ToInterval(@this?.Period);
						CqlDateTime fk_ = context.Operators.End(fj_);

						return fk_;
					};
					IEnumerable<Encounter> dj_ = context.Operators.SortBy<Encounter>(dh_, di_, System.ComponentModel.ListSortDirection.Ascending);
					Encounter dk_ = context.Operators.Last<Encounter>(dj_);
					CqlInterval<CqlDateTime> dl_ = FHIRHelpers_4_3_000.ToInterval(dk_?.Period);
					CqlDateTime dm_ = context.Operators.Start(dl_);
					CqlInterval<CqlDateTime> dn_ = FHIRHelpers_4_3_000.ToInterval(Visit?.Period);
					CqlDateTime do_ = context.Operators.Start(dn_);
					CqlQuantity dp_ = context.Operators.Quantity(1m, "hour");
					CqlDateTime dq_ = context.Operators.Subtract((dm_ ?? do_), dp_);
					IEnumerable<Encounter> ds_ = context.Operators.RetrieveByValueSet<Encounter>(de_, null);
					bool? dt_(Encounter LastObs)
					{
						Code<Encounter.EncounterStatus> fl_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(LastObs?.StatusElement?.Value);
						bool? fm_ = context.Operators.Equal(fl_, "finished");
						CqlInterval<CqlDateTime> fn_ = FHIRHelpers_4_3_000.ToInterval(LastObs?.Period);
						CqlDateTime fo_ = context.Operators.End(fn_);
						CqlInterval<CqlDateTime> fp_ = FHIRHelpers_4_3_000.ToInterval(Visit?.Period);
						CqlDateTime fq_ = context.Operators.Start(fp_);
						CqlQuantity fr_ = context.Operators.Quantity(1m, "hour");
						CqlDateTime fs_ = context.Operators.Subtract(fq_, fr_);
						CqlDateTime fu_ = context.Operators.Start(fp_);
						CqlInterval<CqlDateTime> fv_ = context.Operators.Interval(fs_, fu_, true, true);
						bool? fw_ = context.Operators.In<CqlDateTime>(fo_, fv_, null);
						CqlDateTime fy_ = context.Operators.Start(fp_);
						bool? fz_ = context.Operators.Not((bool?)(fy_ is null));
						bool? ga_ = context.Operators.And(fw_, fz_);
						bool? gb_ = context.Operators.And(fm_, ga_);

						return gb_;
					};
					IEnumerable<Encounter> du_ = context.Operators.Where<Encounter>(ds_, dt_);
					object dv_(Encounter @this)
					{
						CqlInterval<CqlDateTime> gc_ = FHIRHelpers_4_3_000.ToInterval(@this?.Period);
						CqlDateTime gd_ = context.Operators.End(gc_);

						return gd_;
					};
					IEnumerable<Encounter> dw_ = context.Operators.SortBy<Encounter>(du_, dv_, System.ComponentModel.ListSortDirection.Ascending);
					Encounter dx_ = context.Operators.Last<Encounter>(dw_);
					CqlInterval<CqlDateTime> dy_ = FHIRHelpers_4_3_000.ToInterval(dx_?.Period);
					CqlDateTime dz_ = context.Operators.Start(dy_);
					CqlDateTime eb_ = context.Operators.Start(dn_);
					CqlInterval<CqlDateTime> ec_ = context.Operators.Interval(dq_, (dz_ ?? eb_), true, true);
					bool? ed_ = context.Operators.In<CqlDateTime>(dd_, ec_, null);
					IEnumerable<Encounter> ef_ = context.Operators.RetrieveByValueSet<Encounter>(de_, null);
					bool? eg_(Encounter LastObs)
					{
						Code<Encounter.EncounterStatus> ge_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(LastObs?.StatusElement?.Value);
						bool? gf_ = context.Operators.Equal(ge_, "finished");
						CqlInterval<CqlDateTime> gg_ = FHIRHelpers_4_3_000.ToInterval(LastObs?.Period);
						CqlDateTime gh_ = context.Operators.End(gg_);
						CqlInterval<CqlDateTime> gi_ = FHIRHelpers_4_3_000.ToInterval(Visit?.Period);
						CqlDateTime gj_ = context.Operators.Start(gi_);
						CqlQuantity gk_ = context.Operators.Quantity(1m, "hour");
						CqlDateTime gl_ = context.Operators.Subtract(gj_, gk_);
						CqlDateTime gn_ = context.Operators.Start(gi_);
						CqlInterval<CqlDateTime> go_ = context.Operators.Interval(gl_, gn_, true, true);
						bool? gp_ = context.Operators.In<CqlDateTime>(gh_, go_, null);
						CqlDateTime gr_ = context.Operators.Start(gi_);
						bool? gs_ = context.Operators.Not((bool?)(gr_ is null));
						bool? gt_ = context.Operators.And(gp_, gs_);
						bool? gu_ = context.Operators.And(gf_, gt_);

						return gu_;
					};
					IEnumerable<Encounter> eh_ = context.Operators.Where<Encounter>(ef_, eg_);
					object ei_(Encounter @this)
					{
						CqlInterval<CqlDateTime> gv_ = FHIRHelpers_4_3_000.ToInterval(@this?.Period);
						CqlDateTime gw_ = context.Operators.End(gv_);

						return gw_;
					};
					IEnumerable<Encounter> ej_ = context.Operators.SortBy<Encounter>(eh_, ei_, System.ComponentModel.ListSortDirection.Ascending);
					Encounter ek_ = context.Operators.Last<Encounter>(ej_);
					CqlInterval<CqlDateTime> el_ = FHIRHelpers_4_3_000.ToInterval(ek_?.Period);
					CqlDateTime em_ = context.Operators.Start(el_);
					CqlDateTime eo_ = context.Operators.Start(dn_);
					bool? ep_ = context.Operators.Not((bool?)((em_ ?? eo_) is null));
					bool? eq_ = context.Operators.And(ed_, ep_);
					bool? er_ = context.Operators.And(db_, eq_);

					return er_;
				};
				IEnumerable<Encounter> ap_ = context.Operators.Where<Encounter>(an_, ao_);
				object aq_(Encounter @this)
				{
					CqlInterval<CqlDateTime> gx_ = FHIRHelpers_4_3_000.ToInterval(@this?.Period);
					CqlDateTime gy_ = context.Operators.End(gx_);

					return gy_;
				};
				IEnumerable<Encounter> ar_ = context.Operators.SortBy<Encounter>(ap_, aq_, System.ComponentModel.ListSortDirection.Ascending);
				Encounter as_ = context.Operators.Last<Encounter>(ar_);
				CqlInterval<CqlDateTime> at_ = FHIRHelpers_4_3_000.ToInterval(as_?.Period);
				CqlDateTime au_ = context.Operators.Start(at_);
				CqlValueSet av_ = this.Observation_Services();
				IEnumerable<Encounter> aw_ = context.Operators.RetrieveByValueSet<Encounter>(av_, null);
				bool? ax_(Encounter LastObs)
				{
					Code<Encounter.EncounterStatus> gz_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(LastObs?.StatusElement?.Value);
					bool? ha_ = context.Operators.Equal(gz_, "finished");
					CqlInterval<CqlDateTime> hb_ = FHIRHelpers_4_3_000.ToInterval(LastObs?.Period);
					CqlDateTime hc_ = context.Operators.End(hb_);
					CqlInterval<CqlDateTime> hd_ = FHIRHelpers_4_3_000.ToInterval(Visit?.Period);
					CqlDateTime he_ = context.Operators.Start(hd_);
					CqlQuantity hf_ = context.Operators.Quantity(1m, "hour");
					CqlDateTime hg_ = context.Operators.Subtract(he_, hf_);
					CqlDateTime hi_ = context.Operators.Start(hd_);
					CqlInterval<CqlDateTime> hj_ = context.Operators.Interval(hg_, hi_, true, true);
					bool? hk_ = context.Operators.In<CqlDateTime>(hc_, hj_, null);
					CqlDateTime hm_ = context.Operators.Start(hd_);
					bool? hn_ = context.Operators.Not((bool?)(hm_ is null));
					bool? ho_ = context.Operators.And(hk_, hn_);
					bool? hp_ = context.Operators.And(ha_, ho_);

					return hp_;
				};
				IEnumerable<Encounter> ay_ = context.Operators.Where<Encounter>(aw_, ax_);
				object az_(Encounter @this)
				{
					CqlInterval<CqlDateTime> hq_ = FHIRHelpers_4_3_000.ToInterval(@this?.Period);
					CqlDateTime hr_ = context.Operators.End(hq_);

					return hr_;
				};
				IEnumerable<Encounter> ba_ = context.Operators.SortBy<Encounter>(ay_, az_, System.ComponentModel.ListSortDirection.Ascending);
				Encounter bb_ = context.Operators.Last<Encounter>(ba_);
				CqlInterval<CqlDateTime> bc_ = FHIRHelpers_4_3_000.ToInterval(bb_?.Period);
				CqlDateTime bd_ = context.Operators.Start(bc_);
				CqlInterval<CqlDateTime> be_ = FHIRHelpers_4_3_000.ToInterval(Visit?.Period);
				CqlDateTime bf_ = context.Operators.Start(be_);
				CqlQuantity bg_ = context.Operators.Quantity(1m, "hour");
				CqlDateTime bh_ = context.Operators.Subtract((au_ ?? (bd_ ?? bf_)), bg_);
				IEnumerable<Encounter> bj_ = context.Operators.RetrieveByValueSet<Encounter>(am_, null);
				bool? bk_(Encounter LastED)
				{
					Code<Encounter.EncounterStatus> hs_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(LastED?.StatusElement?.Value);
					bool? ht_ = context.Operators.Equal(hs_, "finished");
					CqlInterval<CqlDateTime> hu_ = FHIRHelpers_4_3_000.ToInterval(LastED?.Period);
					CqlDateTime hv_ = context.Operators.End(hu_);
					CqlValueSet hw_ = this.Observation_Services();
					IEnumerable<Encounter> hx_ = context.Operators.RetrieveByValueSet<Encounter>(hw_, null);
					bool? hy_(Encounter LastObs)
					{
						Code<Encounter.EncounterStatus> jk_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(LastObs?.StatusElement?.Value);
						bool? jl_ = context.Operators.Equal(jk_, "finished");
						CqlInterval<CqlDateTime> jm_ = FHIRHelpers_4_3_000.ToInterval(LastObs?.Period);
						CqlDateTime jn_ = context.Operators.End(jm_);
						CqlInterval<CqlDateTime> jo_ = FHIRHelpers_4_3_000.ToInterval(Visit?.Period);
						CqlDateTime jp_ = context.Operators.Start(jo_);
						CqlQuantity jq_ = context.Operators.Quantity(1m, "hour");
						CqlDateTime jr_ = context.Operators.Subtract(jp_, jq_);
						CqlDateTime jt_ = context.Operators.Start(jo_);
						CqlInterval<CqlDateTime> ju_ = context.Operators.Interval(jr_, jt_, true, true);
						bool? jv_ = context.Operators.In<CqlDateTime>(jn_, ju_, null);
						CqlDateTime jx_ = context.Operators.Start(jo_);
						bool? jy_ = context.Operators.Not((bool?)(jx_ is null));
						bool? jz_ = context.Operators.And(jv_, jy_);
						bool? ka_ = context.Operators.And(jl_, jz_);

						return ka_;
					};
					IEnumerable<Encounter> hz_ = context.Operators.Where<Encounter>(hx_, hy_);
					object ia_(Encounter @this)
					{
						CqlInterval<CqlDateTime> kb_ = FHIRHelpers_4_3_000.ToInterval(@this?.Period);
						CqlDateTime kc_ = context.Operators.End(kb_);

						return kc_;
					};
					IEnumerable<Encounter> ib_ = context.Operators.SortBy<Encounter>(hz_, ia_, System.ComponentModel.ListSortDirection.Ascending);
					Encounter ic_ = context.Operators.Last<Encounter>(ib_);
					CqlInterval<CqlDateTime> id_ = FHIRHelpers_4_3_000.ToInterval(ic_?.Period);
					CqlDateTime ie_ = context.Operators.Start(id_);
					CqlInterval<CqlDateTime> if_ = FHIRHelpers_4_3_000.ToInterval(Visit?.Period);
					CqlDateTime ig_ = context.Operators.Start(if_);
					CqlQuantity ih_ = context.Operators.Quantity(1m, "hour");
					CqlDateTime ii_ = context.Operators.Subtract((ie_ ?? ig_), ih_);
					IEnumerable<Encounter> ik_ = context.Operators.RetrieveByValueSet<Encounter>(hw_, null);
					bool? il_(Encounter LastObs)
					{
						Code<Encounter.EncounterStatus> kd_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(LastObs?.StatusElement?.Value);
						bool? ke_ = context.Operators.Equal(kd_, "finished");
						CqlInterval<CqlDateTime> kf_ = FHIRHelpers_4_3_000.ToInterval(LastObs?.Period);
						CqlDateTime kg_ = context.Operators.End(kf_);
						CqlInterval<CqlDateTime> kh_ = FHIRHelpers_4_3_000.ToInterval(Visit?.Period);
						CqlDateTime ki_ = context.Operators.Start(kh_);
						CqlQuantity kj_ = context.Operators.Quantity(1m, "hour");
						CqlDateTime kk_ = context.Operators.Subtract(ki_, kj_);
						CqlDateTime km_ = context.Operators.Start(kh_);
						CqlInterval<CqlDateTime> kn_ = context.Operators.Interval(kk_, km_, true, true);
						bool? ko_ = context.Operators.In<CqlDateTime>(kg_, kn_, null);
						CqlDateTime kq_ = context.Operators.Start(kh_);
						bool? kr_ = context.Operators.Not((bool?)(kq_ is null));
						bool? ks_ = context.Operators.And(ko_, kr_);
						bool? kt_ = context.Operators.And(ke_, ks_);

						return kt_;
					};
					IEnumerable<Encounter> im_ = context.Operators.Where<Encounter>(ik_, il_);
					object in_(Encounter @this)
					{
						CqlInterval<CqlDateTime> ku_ = FHIRHelpers_4_3_000.ToInterval(@this?.Period);
						CqlDateTime kv_ = context.Operators.End(ku_);

						return kv_;
					};
					IEnumerable<Encounter> io_ = context.Operators.SortBy<Encounter>(im_, in_, System.ComponentModel.ListSortDirection.Ascending);
					Encounter ip_ = context.Operators.Last<Encounter>(io_);
					CqlInterval<CqlDateTime> iq_ = FHIRHelpers_4_3_000.ToInterval(ip_?.Period);
					CqlDateTime ir_ = context.Operators.Start(iq_);
					CqlDateTime it_ = context.Operators.Start(if_);
					CqlInterval<CqlDateTime> iu_ = context.Operators.Interval(ii_, (ir_ ?? it_), true, true);
					bool? iv_ = context.Operators.In<CqlDateTime>(hv_, iu_, null);
					IEnumerable<Encounter> ix_ = context.Operators.RetrieveByValueSet<Encounter>(hw_, null);
					bool? iy_(Encounter LastObs)
					{
						Code<Encounter.EncounterStatus> kw_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(LastObs?.StatusElement?.Value);
						bool? kx_ = context.Operators.Equal(kw_, "finished");
						CqlInterval<CqlDateTime> ky_ = FHIRHelpers_4_3_000.ToInterval(LastObs?.Period);
						CqlDateTime kz_ = context.Operators.End(ky_);
						CqlInterval<CqlDateTime> la_ = FHIRHelpers_4_3_000.ToInterval(Visit?.Period);
						CqlDateTime lb_ = context.Operators.Start(la_);
						CqlQuantity lc_ = context.Operators.Quantity(1m, "hour");
						CqlDateTime ld_ = context.Operators.Subtract(lb_, lc_);
						CqlDateTime lf_ = context.Operators.Start(la_);
						CqlInterval<CqlDateTime> lg_ = context.Operators.Interval(ld_, lf_, true, true);
						bool? lh_ = context.Operators.In<CqlDateTime>(kz_, lg_, null);
						CqlDateTime lj_ = context.Operators.Start(la_);
						bool? lk_ = context.Operators.Not((bool?)(lj_ is null));
						bool? ll_ = context.Operators.And(lh_, lk_);
						bool? lm_ = context.Operators.And(kx_, ll_);

						return lm_;
					};
					IEnumerable<Encounter> iz_ = context.Operators.Where<Encounter>(ix_, iy_);
					object ja_(Encounter @this)
					{
						CqlInterval<CqlDateTime> ln_ = FHIRHelpers_4_3_000.ToInterval(@this?.Period);
						CqlDateTime lo_ = context.Operators.End(ln_);

						return lo_;
					};
					IEnumerable<Encounter> jb_ = context.Operators.SortBy<Encounter>(iz_, ja_, System.ComponentModel.ListSortDirection.Ascending);
					Encounter jc_ = context.Operators.Last<Encounter>(jb_);
					CqlInterval<CqlDateTime> jd_ = FHIRHelpers_4_3_000.ToInterval(jc_?.Period);
					CqlDateTime je_ = context.Operators.Start(jd_);
					CqlDateTime jg_ = context.Operators.Start(if_);
					bool? jh_ = context.Operators.Not((bool?)((je_ ?? jg_) is null));
					bool? ji_ = context.Operators.And(iv_, jh_);
					bool? jj_ = context.Operators.And(ht_, ji_);

					return jj_;
				};
				IEnumerable<Encounter> bl_ = context.Operators.Where<Encounter>(bj_, bk_);
				object bm_(Encounter @this)
				{
					CqlInterval<CqlDateTime> lp_ = FHIRHelpers_4_3_000.ToInterval(@this?.Period);
					CqlDateTime lq_ = context.Operators.End(lp_);

					return lq_;
				};
				IEnumerable<Encounter> bn_ = context.Operators.SortBy<Encounter>(bl_, bm_, System.ComponentModel.ListSortDirection.Ascending);
				Encounter bo_ = context.Operators.Last<Encounter>(bn_);
				CqlInterval<CqlDateTime> bp_ = FHIRHelpers_4_3_000.ToInterval(bo_?.Period);
				CqlDateTime bq_ = context.Operators.Start(bp_);
				IEnumerable<Encounter> bs_ = context.Operators.RetrieveByValueSet<Encounter>(av_, null);
				bool? bt_(Encounter LastObs)
				{
					Code<Encounter.EncounterStatus> lr_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(LastObs?.StatusElement?.Value);
					bool? ls_ = context.Operators.Equal(lr_, "finished");
					CqlInterval<CqlDateTime> lt_ = FHIRHelpers_4_3_000.ToInterval(LastObs?.Period);
					CqlDateTime lu_ = context.Operators.End(lt_);
					CqlInterval<CqlDateTime> lv_ = FHIRHelpers_4_3_000.ToInterval(Visit?.Period);
					CqlDateTime lw_ = context.Operators.Start(lv_);
					CqlQuantity lx_ = context.Operators.Quantity(1m, "hour");
					CqlDateTime ly_ = context.Operators.Subtract(lw_, lx_);
					CqlDateTime ma_ = context.Operators.Start(lv_);
					CqlInterval<CqlDateTime> mb_ = context.Operators.Interval(ly_, ma_, true, true);
					bool? mc_ = context.Operators.In<CqlDateTime>(lu_, mb_, null);
					CqlDateTime me_ = context.Operators.Start(lv_);
					bool? mf_ = context.Operators.Not((bool?)(me_ is null));
					bool? mg_ = context.Operators.And(mc_, mf_);
					bool? mh_ = context.Operators.And(ls_, mg_);

					return mh_;
				};
				IEnumerable<Encounter> bu_ = context.Operators.Where<Encounter>(bs_, bt_);
				object bv_(Encounter @this)
				{
					CqlInterval<CqlDateTime> mi_ = FHIRHelpers_4_3_000.ToInterval(@this?.Period);
					CqlDateTime mj_ = context.Operators.End(mi_);

					return mj_;
				};
				IEnumerable<Encounter> bw_ = context.Operators.SortBy<Encounter>(bu_, bv_, System.ComponentModel.ListSortDirection.Ascending);
				Encounter bx_ = context.Operators.Last<Encounter>(bw_);
				CqlInterval<CqlDateTime> by_ = FHIRHelpers_4_3_000.ToInterval(bx_?.Period);
				CqlDateTime bz_ = context.Operators.Start(by_);
				CqlDateTime cb_ = context.Operators.Start(be_);
				CqlInterval<CqlDateTime> cc_ = context.Operators.Interval(bh_, (bq_ ?? (bz_ ?? cb_)), true, true);
				bool? cd_ = context.Operators.In<CqlDateTime>(al_, cc_, null);
				IEnumerable<Encounter> cf_ = context.Operators.RetrieveByValueSet<Encounter>(am_, null);
				bool? cg_(Encounter LastED)
				{
					Code<Encounter.EncounterStatus> mk_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(LastED?.StatusElement?.Value);
					bool? ml_ = context.Operators.Equal(mk_, "finished");
					CqlInterval<CqlDateTime> mm_ = FHIRHelpers_4_3_000.ToInterval(LastED?.Period);
					CqlDateTime mn_ = context.Operators.End(mm_);
					CqlValueSet mo_ = this.Observation_Services();
					IEnumerable<Encounter> mp_ = context.Operators.RetrieveByValueSet<Encounter>(mo_, null);
					bool? mq_(Encounter LastObs)
					{
						Code<Encounter.EncounterStatus> oc_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(LastObs?.StatusElement?.Value);
						bool? od_ = context.Operators.Equal(oc_, "finished");
						CqlInterval<CqlDateTime> oe_ = FHIRHelpers_4_3_000.ToInterval(LastObs?.Period);
						CqlDateTime of_ = context.Operators.End(oe_);
						CqlInterval<CqlDateTime> og_ = FHIRHelpers_4_3_000.ToInterval(Visit?.Period);
						CqlDateTime oh_ = context.Operators.Start(og_);
						CqlQuantity oi_ = context.Operators.Quantity(1m, "hour");
						CqlDateTime oj_ = context.Operators.Subtract(oh_, oi_);
						CqlDateTime ol_ = context.Operators.Start(og_);
						CqlInterval<CqlDateTime> om_ = context.Operators.Interval(oj_, ol_, true, true);
						bool? on_ = context.Operators.In<CqlDateTime>(of_, om_, null);
						CqlDateTime op_ = context.Operators.Start(og_);
						bool? oq_ = context.Operators.Not((bool?)(op_ is null));
						bool? or_ = context.Operators.And(on_, oq_);
						bool? os_ = context.Operators.And(od_, or_);

						return os_;
					};
					IEnumerable<Encounter> mr_ = context.Operators.Where<Encounter>(mp_, mq_);
					object ms_(Encounter @this)
					{
						CqlInterval<CqlDateTime> ot_ = FHIRHelpers_4_3_000.ToInterval(@this?.Period);
						CqlDateTime ou_ = context.Operators.End(ot_);

						return ou_;
					};
					IEnumerable<Encounter> mt_ = context.Operators.SortBy<Encounter>(mr_, ms_, System.ComponentModel.ListSortDirection.Ascending);
					Encounter mu_ = context.Operators.Last<Encounter>(mt_);
					CqlInterval<CqlDateTime> mv_ = FHIRHelpers_4_3_000.ToInterval(mu_?.Period);
					CqlDateTime mw_ = context.Operators.Start(mv_);
					CqlInterval<CqlDateTime> mx_ = FHIRHelpers_4_3_000.ToInterval(Visit?.Period);
					CqlDateTime my_ = context.Operators.Start(mx_);
					CqlQuantity mz_ = context.Operators.Quantity(1m, "hour");
					CqlDateTime na_ = context.Operators.Subtract((mw_ ?? my_), mz_);
					IEnumerable<Encounter> nc_ = context.Operators.RetrieveByValueSet<Encounter>(mo_, null);
					bool? nd_(Encounter LastObs)
					{
						Code<Encounter.EncounterStatus> ov_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(LastObs?.StatusElement?.Value);
						bool? ow_ = context.Operators.Equal(ov_, "finished");
						CqlInterval<CqlDateTime> ox_ = FHIRHelpers_4_3_000.ToInterval(LastObs?.Period);
						CqlDateTime oy_ = context.Operators.End(ox_);
						CqlInterval<CqlDateTime> oz_ = FHIRHelpers_4_3_000.ToInterval(Visit?.Period);
						CqlDateTime pa_ = context.Operators.Start(oz_);
						CqlQuantity pb_ = context.Operators.Quantity(1m, "hour");
						CqlDateTime pc_ = context.Operators.Subtract(pa_, pb_);
						CqlDateTime pe_ = context.Operators.Start(oz_);
						CqlInterval<CqlDateTime> pf_ = context.Operators.Interval(pc_, pe_, true, true);
						bool? pg_ = context.Operators.In<CqlDateTime>(oy_, pf_, null);
						CqlDateTime pi_ = context.Operators.Start(oz_);
						bool? pj_ = context.Operators.Not((bool?)(pi_ is null));
						bool? pk_ = context.Operators.And(pg_, pj_);
						bool? pl_ = context.Operators.And(ow_, pk_);

						return pl_;
					};
					IEnumerable<Encounter> ne_ = context.Operators.Where<Encounter>(nc_, nd_);
					object nf_(Encounter @this)
					{
						CqlInterval<CqlDateTime> pm_ = FHIRHelpers_4_3_000.ToInterval(@this?.Period);
						CqlDateTime pn_ = context.Operators.End(pm_);

						return pn_;
					};
					IEnumerable<Encounter> ng_ = context.Operators.SortBy<Encounter>(ne_, nf_, System.ComponentModel.ListSortDirection.Ascending);
					Encounter nh_ = context.Operators.Last<Encounter>(ng_);
					CqlInterval<CqlDateTime> ni_ = FHIRHelpers_4_3_000.ToInterval(nh_?.Period);
					CqlDateTime nj_ = context.Operators.Start(ni_);
					CqlDateTime nl_ = context.Operators.Start(mx_);
					CqlInterval<CqlDateTime> nm_ = context.Operators.Interval(na_, (nj_ ?? nl_), true, true);
					bool? nn_ = context.Operators.In<CqlDateTime>(mn_, nm_, null);
					IEnumerable<Encounter> np_ = context.Operators.RetrieveByValueSet<Encounter>(mo_, null);
					bool? nq_(Encounter LastObs)
					{
						Code<Encounter.EncounterStatus> po_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(LastObs?.StatusElement?.Value);
						bool? pp_ = context.Operators.Equal(po_, "finished");
						CqlInterval<CqlDateTime> pq_ = FHIRHelpers_4_3_000.ToInterval(LastObs?.Period);
						CqlDateTime pr_ = context.Operators.End(pq_);
						CqlInterval<CqlDateTime> ps_ = FHIRHelpers_4_3_000.ToInterval(Visit?.Period);
						CqlDateTime pt_ = context.Operators.Start(ps_);
						CqlQuantity pu_ = context.Operators.Quantity(1m, "hour");
						CqlDateTime pv_ = context.Operators.Subtract(pt_, pu_);
						CqlDateTime px_ = context.Operators.Start(ps_);
						CqlInterval<CqlDateTime> py_ = context.Operators.Interval(pv_, px_, true, true);
						bool? pz_ = context.Operators.In<CqlDateTime>(pr_, py_, null);
						CqlDateTime qb_ = context.Operators.Start(ps_);
						bool? qc_ = context.Operators.Not((bool?)(qb_ is null));
						bool? qd_ = context.Operators.And(pz_, qc_);
						bool? qe_ = context.Operators.And(pp_, qd_);

						return qe_;
					};
					IEnumerable<Encounter> nr_ = context.Operators.Where<Encounter>(np_, nq_);
					object ns_(Encounter @this)
					{
						CqlInterval<CqlDateTime> qf_ = FHIRHelpers_4_3_000.ToInterval(@this?.Period);
						CqlDateTime qg_ = context.Operators.End(qf_);

						return qg_;
					};
					IEnumerable<Encounter> nt_ = context.Operators.SortBy<Encounter>(nr_, ns_, System.ComponentModel.ListSortDirection.Ascending);
					Encounter nu_ = context.Operators.Last<Encounter>(nt_);
					CqlInterval<CqlDateTime> nv_ = FHIRHelpers_4_3_000.ToInterval(nu_?.Period);
					CqlDateTime nw_ = context.Operators.Start(nv_);
					CqlDateTime ny_ = context.Operators.Start(mx_);
					bool? nz_ = context.Operators.Not((bool?)((nw_ ?? ny_) is null));
					bool? oa_ = context.Operators.And(nn_, nz_);
					bool? ob_ = context.Operators.And(ml_, oa_);

					return ob_;
				};
				IEnumerable<Encounter> ch_ = context.Operators.Where<Encounter>(cf_, cg_);
				object ci_(Encounter @this)
				{
					CqlInterval<CqlDateTime> qh_ = FHIRHelpers_4_3_000.ToInterval(@this?.Period);
					CqlDateTime qi_ = context.Operators.End(qh_);

					return qi_;
				};
				IEnumerable<Encounter> cj_ = context.Operators.SortBy<Encounter>(ch_, ci_, System.ComponentModel.ListSortDirection.Ascending);
				Encounter ck_ = context.Operators.Last<Encounter>(cj_);
				CqlInterval<CqlDateTime> cl_ = FHIRHelpers_4_3_000.ToInterval(ck_?.Period);
				CqlDateTime cm_ = context.Operators.Start(cl_);
				IEnumerable<Encounter> co_ = context.Operators.RetrieveByValueSet<Encounter>(av_, null);
				bool? cp_(Encounter LastObs)
				{
					Code<Encounter.EncounterStatus> qj_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(LastObs?.StatusElement?.Value);
					bool? qk_ = context.Operators.Equal(qj_, "finished");
					CqlInterval<CqlDateTime> ql_ = FHIRHelpers_4_3_000.ToInterval(LastObs?.Period);
					CqlDateTime qm_ = context.Operators.End(ql_);
					CqlInterval<CqlDateTime> qn_ = FHIRHelpers_4_3_000.ToInterval(Visit?.Period);
					CqlDateTime qo_ = context.Operators.Start(qn_);
					CqlQuantity qp_ = context.Operators.Quantity(1m, "hour");
					CqlDateTime qq_ = context.Operators.Subtract(qo_, qp_);
					CqlDateTime qs_ = context.Operators.Start(qn_);
					CqlInterval<CqlDateTime> qt_ = context.Operators.Interval(qq_, qs_, true, true);
					bool? qu_ = context.Operators.In<CqlDateTime>(qm_, qt_, null);
					CqlDateTime qw_ = context.Operators.Start(qn_);
					bool? qx_ = context.Operators.Not((bool?)(qw_ is null));
					bool? qy_ = context.Operators.And(qu_, qx_);
					bool? qz_ = context.Operators.And(qk_, qy_);

					return qz_;
				};
				IEnumerable<Encounter> cq_ = context.Operators.Where<Encounter>(co_, cp_);
				object cr_(Encounter @this)
				{
					CqlInterval<CqlDateTime> ra_ = FHIRHelpers_4_3_000.ToInterval(@this?.Period);
					CqlDateTime rb_ = context.Operators.End(ra_);

					return rb_;
				};
				IEnumerable<Encounter> cs_ = context.Operators.SortBy<Encounter>(cq_, cr_, System.ComponentModel.ListSortDirection.Ascending);
				Encounter ct_ = context.Operators.Last<Encounter>(cs_);
				CqlInterval<CqlDateTime> cu_ = FHIRHelpers_4_3_000.ToInterval(ct_?.Period);
				CqlDateTime cv_ = context.Operators.Start(cu_);
				CqlDateTime cx_ = context.Operators.Start(be_);
				bool? cy_ = context.Operators.Not((bool?)((cm_ ?? (cv_ ?? cx_)) is null));
				bool? cz_ = context.Operators.And(cd_, cy_);

				return cz_;
			};
			IEnumerable<Encounter> h_ = context.Operators.Where<Encounter>(f_, g_);
			object i_(Encounter @this)
			{
				CqlInterval<CqlDateTime> rc_ = FHIRHelpers_4_3_000.ToInterval(@this?.Period);
				CqlDateTime rd_ = context.Operators.End(rc_);

				return rd_;
			};
			IEnumerable<Encounter> j_ = context.Operators.SortBy<Encounter>(h_, i_, System.ComponentModel.ListSortDirection.Ascending);
			Encounter k_ = context.Operators.Last<Encounter>(j_);
			CqlInterval<CqlDateTime> l_ = FHIRHelpers_4_3_000.ToInterval(k_?.Period);
			CqlDateTime m_ = context.Operators.Start(l_);
			CqlValueSet n_ = this.Emergency_Department_Visit();
			IEnumerable<Encounter> o_ = context.Operators.RetrieveByValueSet<Encounter>(n_, null);
			bool? p_(Encounter LastED)
			{
				Code<Encounter.EncounterStatus> re_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(LastED?.StatusElement?.Value);
				bool? rf_ = context.Operators.Equal(re_, "finished");
				CqlInterval<CqlDateTime> rg_ = FHIRHelpers_4_3_000.ToInterval(LastED?.Period);
				CqlDateTime rh_ = context.Operators.End(rg_);
				CqlValueSet ri_ = this.Observation_Services();
				IEnumerable<Encounter> rj_ = context.Operators.RetrieveByValueSet<Encounter>(ri_, null);
				bool? rk_(Encounter LastObs)
				{
					Code<Encounter.EncounterStatus> sw_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(LastObs?.StatusElement?.Value);
					bool? sx_ = context.Operators.Equal(sw_, "finished");
					CqlInterval<CqlDateTime> sy_ = FHIRHelpers_4_3_000.ToInterval(LastObs?.Period);
					CqlDateTime sz_ = context.Operators.End(sy_);
					CqlInterval<CqlDateTime> ta_ = FHIRHelpers_4_3_000.ToInterval(Visit?.Period);
					CqlDateTime tb_ = context.Operators.Start(ta_);
					CqlQuantity tc_ = context.Operators.Quantity(1m, "hour");
					CqlDateTime td_ = context.Operators.Subtract(tb_, tc_);
					CqlDateTime tf_ = context.Operators.Start(ta_);
					CqlInterval<CqlDateTime> tg_ = context.Operators.Interval(td_, tf_, true, true);
					bool? th_ = context.Operators.In<CqlDateTime>(sz_, tg_, null);
					CqlDateTime tj_ = context.Operators.Start(ta_);
					bool? tk_ = context.Operators.Not((bool?)(tj_ is null));
					bool? tl_ = context.Operators.And(th_, tk_);
					bool? tm_ = context.Operators.And(sx_, tl_);

					return tm_;
				};
				IEnumerable<Encounter> rl_ = context.Operators.Where<Encounter>(rj_, rk_);
				object rm_(Encounter @this)
				{
					CqlInterval<CqlDateTime> tn_ = FHIRHelpers_4_3_000.ToInterval(@this?.Period);
					CqlDateTime to_ = context.Operators.End(tn_);

					return to_;
				};
				IEnumerable<Encounter> rn_ = context.Operators.SortBy<Encounter>(rl_, rm_, System.ComponentModel.ListSortDirection.Ascending);
				Encounter ro_ = context.Operators.Last<Encounter>(rn_);
				CqlInterval<CqlDateTime> rp_ = FHIRHelpers_4_3_000.ToInterval(ro_?.Period);
				CqlDateTime rq_ = context.Operators.Start(rp_);
				CqlInterval<CqlDateTime> rr_ = FHIRHelpers_4_3_000.ToInterval(Visit?.Period);
				CqlDateTime rs_ = context.Operators.Start(rr_);
				CqlQuantity rt_ = context.Operators.Quantity(1m, "hour");
				CqlDateTime ru_ = context.Operators.Subtract((rq_ ?? rs_), rt_);
				IEnumerable<Encounter> rw_ = context.Operators.RetrieveByValueSet<Encounter>(ri_, null);
				bool? rx_(Encounter LastObs)
				{
					Code<Encounter.EncounterStatus> tp_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(LastObs?.StatusElement?.Value);
					bool? tq_ = context.Operators.Equal(tp_, "finished");
					CqlInterval<CqlDateTime> tr_ = FHIRHelpers_4_3_000.ToInterval(LastObs?.Period);
					CqlDateTime ts_ = context.Operators.End(tr_);
					CqlInterval<CqlDateTime> tt_ = FHIRHelpers_4_3_000.ToInterval(Visit?.Period);
					CqlDateTime tu_ = context.Operators.Start(tt_);
					CqlQuantity tv_ = context.Operators.Quantity(1m, "hour");
					CqlDateTime tw_ = context.Operators.Subtract(tu_, tv_);
					CqlDateTime ty_ = context.Operators.Start(tt_);
					CqlInterval<CqlDateTime> tz_ = context.Operators.Interval(tw_, ty_, true, true);
					bool? ua_ = context.Operators.In<CqlDateTime>(ts_, tz_, null);
					CqlDateTime uc_ = context.Operators.Start(tt_);
					bool? ud_ = context.Operators.Not((bool?)(uc_ is null));
					bool? ue_ = context.Operators.And(ua_, ud_);
					bool? uf_ = context.Operators.And(tq_, ue_);

					return uf_;
				};
				IEnumerable<Encounter> ry_ = context.Operators.Where<Encounter>(rw_, rx_);
				object rz_(Encounter @this)
				{
					CqlInterval<CqlDateTime> ug_ = FHIRHelpers_4_3_000.ToInterval(@this?.Period);
					CqlDateTime uh_ = context.Operators.End(ug_);

					return uh_;
				};
				IEnumerable<Encounter> sa_ = context.Operators.SortBy<Encounter>(ry_, rz_, System.ComponentModel.ListSortDirection.Ascending);
				Encounter sb_ = context.Operators.Last<Encounter>(sa_);
				CqlInterval<CqlDateTime> sc_ = FHIRHelpers_4_3_000.ToInterval(sb_?.Period);
				CqlDateTime sd_ = context.Operators.Start(sc_);
				CqlDateTime sf_ = context.Operators.Start(rr_);
				CqlInterval<CqlDateTime> sg_ = context.Operators.Interval(ru_, (sd_ ?? sf_), true, true);
				bool? sh_ = context.Operators.In<CqlDateTime>(rh_, sg_, null);
				IEnumerable<Encounter> sj_ = context.Operators.RetrieveByValueSet<Encounter>(ri_, null);
				bool? sk_(Encounter LastObs)
				{
					Code<Encounter.EncounterStatus> ui_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(LastObs?.StatusElement?.Value);
					bool? uj_ = context.Operators.Equal(ui_, "finished");
					CqlInterval<CqlDateTime> uk_ = FHIRHelpers_4_3_000.ToInterval(LastObs?.Period);
					CqlDateTime ul_ = context.Operators.End(uk_);
					CqlInterval<CqlDateTime> um_ = FHIRHelpers_4_3_000.ToInterval(Visit?.Period);
					CqlDateTime un_ = context.Operators.Start(um_);
					CqlQuantity uo_ = context.Operators.Quantity(1m, "hour");
					CqlDateTime up_ = context.Operators.Subtract(un_, uo_);
					CqlDateTime ur_ = context.Operators.Start(um_);
					CqlInterval<CqlDateTime> us_ = context.Operators.Interval(up_, ur_, true, true);
					bool? ut_ = context.Operators.In<CqlDateTime>(ul_, us_, null);
					CqlDateTime uv_ = context.Operators.Start(um_);
					bool? uw_ = context.Operators.Not((bool?)(uv_ is null));
					bool? ux_ = context.Operators.And(ut_, uw_);
					bool? uy_ = context.Operators.And(uj_, ux_);

					return uy_;
				};
				IEnumerable<Encounter> sl_ = context.Operators.Where<Encounter>(sj_, sk_);
				object sm_(Encounter @this)
				{
					CqlInterval<CqlDateTime> uz_ = FHIRHelpers_4_3_000.ToInterval(@this?.Period);
					CqlDateTime va_ = context.Operators.End(uz_);

					return va_;
				};
				IEnumerable<Encounter> sn_ = context.Operators.SortBy<Encounter>(sl_, sm_, System.ComponentModel.ListSortDirection.Ascending);
				Encounter so_ = context.Operators.Last<Encounter>(sn_);
				CqlInterval<CqlDateTime> sp_ = FHIRHelpers_4_3_000.ToInterval(so_?.Period);
				CqlDateTime sq_ = context.Operators.Start(sp_);
				CqlDateTime ss_ = context.Operators.Start(rr_);
				bool? st_ = context.Operators.Not((bool?)((sq_ ?? ss_) is null));
				bool? su_ = context.Operators.And(sh_, st_);
				bool? sv_ = context.Operators.And(rf_, su_);

				return sv_;
			};
			IEnumerable<Encounter> q_ = context.Operators.Where<Encounter>(o_, p_);
			object r_(Encounter @this)
			{
				CqlInterval<CqlDateTime> vb_ = FHIRHelpers_4_3_000.ToInterval(@this?.Period);
				CqlDateTime vc_ = context.Operators.End(vb_);

				return vc_;
			};
			IEnumerable<Encounter> s_ = context.Operators.SortBy<Encounter>(q_, r_, System.ComponentModel.ListSortDirection.Ascending);
			Encounter t_ = context.Operators.Last<Encounter>(s_);
			CqlInterval<CqlDateTime> u_ = FHIRHelpers_4_3_000.ToInterval(t_?.Period);
			CqlDateTime v_ = context.Operators.Start(u_);
			CqlValueSet w_ = this.Observation_Services();
			IEnumerable<Encounter> x_ = context.Operators.RetrieveByValueSet<Encounter>(w_, null);
			bool? y_(Encounter LastObs)
			{
				Code<Encounter.EncounterStatus> vd_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(LastObs?.StatusElement?.Value);
				bool? ve_ = context.Operators.Equal(vd_, "finished");
				CqlInterval<CqlDateTime> vf_ = FHIRHelpers_4_3_000.ToInterval(LastObs?.Period);
				CqlDateTime vg_ = context.Operators.End(vf_);
				CqlInterval<CqlDateTime> vh_ = FHIRHelpers_4_3_000.ToInterval(Visit?.Period);
				CqlDateTime vi_ = context.Operators.Start(vh_);
				CqlQuantity vj_ = context.Operators.Quantity(1m, "hour");
				CqlDateTime vk_ = context.Operators.Subtract(vi_, vj_);
				CqlDateTime vm_ = context.Operators.Start(vh_);
				CqlInterval<CqlDateTime> vn_ = context.Operators.Interval(vk_, vm_, true, true);
				bool? vo_ = context.Operators.In<CqlDateTime>(vg_, vn_, null);
				CqlDateTime vq_ = context.Operators.Start(vh_);
				bool? vr_ = context.Operators.Not((bool?)(vq_ is null));
				bool? vs_ = context.Operators.And(vo_, vr_);
				bool? vt_ = context.Operators.And(ve_, vs_);

				return vt_;
			};
			IEnumerable<Encounter> z_ = context.Operators.Where<Encounter>(x_, y_);
			object aa_(Encounter @this)
			{
				CqlInterval<CqlDateTime> vu_ = FHIRHelpers_4_3_000.ToInterval(@this?.Period);
				CqlDateTime vv_ = context.Operators.End(vu_);

				return vv_;
			};
			IEnumerable<Encounter> ab_ = context.Operators.SortBy<Encounter>(z_, aa_, System.ComponentModel.ListSortDirection.Ascending);
			Encounter ac_ = context.Operators.Last<Encounter>(ab_);
			CqlInterval<CqlDateTime> ad_ = FHIRHelpers_4_3_000.ToInterval(ac_?.Period);
			CqlDateTime ae_ = context.Operators.Start(ad_);
			CqlInterval<CqlDateTime> af_ = FHIRHelpers_4_3_000.ToInterval(Visit?.Period);
			CqlDateTime ag_ = context.Operators.Start(af_);
			CqlDateTime ai_ = context.Operators.End(af_);
			CqlInterval<CqlDateTime> aj_ = context.Operators.Interval((m_ ?? (v_ ?? (ae_ ?? ag_))), ai_, true, true);

			return aj_;
		};
		IEnumerable<CqlInterval<CqlDateTime>> c_ = context.Operators.Select<Encounter, CqlInterval<CqlDateTime>>(a_, b_);
		CqlInterval<CqlDateTime> d_ = context.Operators.SingletonFrom<CqlInterval<CqlDateTime>>(c_);

		return d_;
	}

    [CqlDeclaration("hospitalizationWithObservationAndOutpatientSurgeryService")]
    [CqlTag("description", "Hospitalization with Observation and Outpatient Surgery Service returns the total interval from the start of any immediately prior emergency department visit, outpatient surgery visit or observation visit to the discharge of the given encounter.")]
	public CqlInterval<CqlDateTime> hospitalizationWithObservationAndOutpatientSurgeryService(Encounter TheEncounter)
	{
		Encounter[] a_ = new Encounter[]
		{
			TheEncounter,
		};
		CqlInterval<CqlDateTime> b_(Encounter Visit)
		{
			CqlValueSet e_ = this.Outpatient_Surgery_Service();
			IEnumerable<Encounter> f_ = context.Operators.RetrieveByValueSet<Encounter>(e_, null);
			bool? g_(Encounter LastSurgeryOP)
			{
				CqlInterval<CqlDateTime> ak_ = FHIRHelpers_4_3_000.ToInterval(LastSurgeryOP?.Period);
				CqlDateTime al_ = context.Operators.End(ak_);
				CqlValueSet am_ = this.Emergency_Department_Visit();
				IEnumerable<Encounter> an_ = context.Operators.RetrieveByValueSet<Encounter>(am_, null);
				bool? ao_(Encounter LastED)
				{
					Code<Encounter.EncounterStatus> da_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(LastED?.StatusElement?.Value);
					bool? db_ = context.Operators.Equal(da_, "finished");
					CqlInterval<CqlDateTime> dc_ = FHIRHelpers_4_3_000.ToInterval(LastED?.Period);
					CqlDateTime dd_ = context.Operators.End(dc_);
					CqlValueSet de_ = this.Observation_Services();
					IEnumerable<Encounter> df_ = context.Operators.RetrieveByValueSet<Encounter>(de_, null);
					bool? dg_(Encounter LastObs)
					{
						Code<Encounter.EncounterStatus> es_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(LastObs?.StatusElement?.Value);
						bool? et_ = context.Operators.Equal(es_, "finished");
						CqlInterval<CqlDateTime> eu_ = FHIRHelpers_4_3_000.ToInterval(LastObs?.Period);
						CqlDateTime ev_ = context.Operators.End(eu_);
						CqlInterval<CqlDateTime> ew_ = FHIRHelpers_4_3_000.ToInterval(Visit?.Period);
						CqlDateTime ex_ = context.Operators.Start(ew_);
						CqlQuantity ey_ = context.Operators.Quantity(1m, "hour");
						CqlDateTime ez_ = context.Operators.Subtract(ex_, ey_);
						CqlDateTime fb_ = context.Operators.Start(ew_);
						CqlInterval<CqlDateTime> fc_ = context.Operators.Interval(ez_, fb_, true, true);
						bool? fd_ = context.Operators.In<CqlDateTime>(ev_, fc_, null);
						CqlDateTime ff_ = context.Operators.Start(ew_);
						bool? fg_ = context.Operators.Not((bool?)(ff_ is null));
						bool? fh_ = context.Operators.And(fd_, fg_);
						bool? fi_ = context.Operators.And(et_, fh_);

						return fi_;
					};
					IEnumerable<Encounter> dh_ = context.Operators.Where<Encounter>(df_, dg_);
					object di_(Encounter @this)
					{
						CqlInterval<CqlDateTime> fj_ = FHIRHelpers_4_3_000.ToInterval(@this?.Period);
						CqlDateTime fk_ = context.Operators.End(fj_);

						return fk_;
					};
					IEnumerable<Encounter> dj_ = context.Operators.SortBy<Encounter>(dh_, di_, System.ComponentModel.ListSortDirection.Ascending);
					Encounter dk_ = context.Operators.Last<Encounter>(dj_);
					CqlInterval<CqlDateTime> dl_ = FHIRHelpers_4_3_000.ToInterval(dk_?.Period);
					CqlDateTime dm_ = context.Operators.Start(dl_);
					CqlInterval<CqlDateTime> dn_ = FHIRHelpers_4_3_000.ToInterval(Visit?.Period);
					CqlDateTime do_ = context.Operators.Start(dn_);
					CqlQuantity dp_ = context.Operators.Quantity(1m, "hour");
					CqlDateTime dq_ = context.Operators.Subtract((dm_ ?? do_), dp_);
					IEnumerable<Encounter> ds_ = context.Operators.RetrieveByValueSet<Encounter>(de_, null);
					bool? dt_(Encounter LastObs)
					{
						Code<Encounter.EncounterStatus> fl_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(LastObs?.StatusElement?.Value);
						bool? fm_ = context.Operators.Equal(fl_, "finished");
						CqlInterval<CqlDateTime> fn_ = FHIRHelpers_4_3_000.ToInterval(LastObs?.Period);
						CqlDateTime fo_ = context.Operators.End(fn_);
						CqlInterval<CqlDateTime> fp_ = FHIRHelpers_4_3_000.ToInterval(Visit?.Period);
						CqlDateTime fq_ = context.Operators.Start(fp_);
						CqlQuantity fr_ = context.Operators.Quantity(1m, "hour");
						CqlDateTime fs_ = context.Operators.Subtract(fq_, fr_);
						CqlDateTime fu_ = context.Operators.Start(fp_);
						CqlInterval<CqlDateTime> fv_ = context.Operators.Interval(fs_, fu_, true, true);
						bool? fw_ = context.Operators.In<CqlDateTime>(fo_, fv_, null);
						CqlDateTime fy_ = context.Operators.Start(fp_);
						bool? fz_ = context.Operators.Not((bool?)(fy_ is null));
						bool? ga_ = context.Operators.And(fw_, fz_);
						bool? gb_ = context.Operators.And(fm_, ga_);

						return gb_;
					};
					IEnumerable<Encounter> du_ = context.Operators.Where<Encounter>(ds_, dt_);
					object dv_(Encounter @this)
					{
						CqlInterval<CqlDateTime> gc_ = FHIRHelpers_4_3_000.ToInterval(@this?.Period);
						CqlDateTime gd_ = context.Operators.End(gc_);

						return gd_;
					};
					IEnumerable<Encounter> dw_ = context.Operators.SortBy<Encounter>(du_, dv_, System.ComponentModel.ListSortDirection.Ascending);
					Encounter dx_ = context.Operators.Last<Encounter>(dw_);
					CqlInterval<CqlDateTime> dy_ = FHIRHelpers_4_3_000.ToInterval(dx_?.Period);
					CqlDateTime dz_ = context.Operators.Start(dy_);
					CqlDateTime eb_ = context.Operators.Start(dn_);
					CqlInterval<CqlDateTime> ec_ = context.Operators.Interval(dq_, (dz_ ?? eb_), true, true);
					bool? ed_ = context.Operators.In<CqlDateTime>(dd_, ec_, null);
					IEnumerable<Encounter> ef_ = context.Operators.RetrieveByValueSet<Encounter>(de_, null);
					bool? eg_(Encounter LastObs)
					{
						Code<Encounter.EncounterStatus> ge_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(LastObs?.StatusElement?.Value);
						bool? gf_ = context.Operators.Equal(ge_, "finished");
						CqlInterval<CqlDateTime> gg_ = FHIRHelpers_4_3_000.ToInterval(LastObs?.Period);
						CqlDateTime gh_ = context.Operators.End(gg_);
						CqlInterval<CqlDateTime> gi_ = FHIRHelpers_4_3_000.ToInterval(Visit?.Period);
						CqlDateTime gj_ = context.Operators.Start(gi_);
						CqlQuantity gk_ = context.Operators.Quantity(1m, "hour");
						CqlDateTime gl_ = context.Operators.Subtract(gj_, gk_);
						CqlDateTime gn_ = context.Operators.Start(gi_);
						CqlInterval<CqlDateTime> go_ = context.Operators.Interval(gl_, gn_, true, true);
						bool? gp_ = context.Operators.In<CqlDateTime>(gh_, go_, null);
						CqlDateTime gr_ = context.Operators.Start(gi_);
						bool? gs_ = context.Operators.Not((bool?)(gr_ is null));
						bool? gt_ = context.Operators.And(gp_, gs_);
						bool? gu_ = context.Operators.And(gf_, gt_);

						return gu_;
					};
					IEnumerable<Encounter> eh_ = context.Operators.Where<Encounter>(ef_, eg_);
					object ei_(Encounter @this)
					{
						CqlInterval<CqlDateTime> gv_ = FHIRHelpers_4_3_000.ToInterval(@this?.Period);
						CqlDateTime gw_ = context.Operators.End(gv_);

						return gw_;
					};
					IEnumerable<Encounter> ej_ = context.Operators.SortBy<Encounter>(eh_, ei_, System.ComponentModel.ListSortDirection.Ascending);
					Encounter ek_ = context.Operators.Last<Encounter>(ej_);
					CqlInterval<CqlDateTime> el_ = FHIRHelpers_4_3_000.ToInterval(ek_?.Period);
					CqlDateTime em_ = context.Operators.Start(el_);
					CqlDateTime eo_ = context.Operators.Start(dn_);
					bool? ep_ = context.Operators.Not((bool?)((em_ ?? eo_) is null));
					bool? eq_ = context.Operators.And(ed_, ep_);
					bool? er_ = context.Operators.And(db_, eq_);

					return er_;
				};
				IEnumerable<Encounter> ap_ = context.Operators.Where<Encounter>(an_, ao_);
				object aq_(Encounter @this)
				{
					CqlInterval<CqlDateTime> gx_ = FHIRHelpers_4_3_000.ToInterval(@this?.Period);
					CqlDateTime gy_ = context.Operators.End(gx_);

					return gy_;
				};
				IEnumerable<Encounter> ar_ = context.Operators.SortBy<Encounter>(ap_, aq_, System.ComponentModel.ListSortDirection.Ascending);
				Encounter as_ = context.Operators.Last<Encounter>(ar_);
				CqlInterval<CqlDateTime> at_ = FHIRHelpers_4_3_000.ToInterval(as_?.Period);
				CqlDateTime au_ = context.Operators.Start(at_);
				CqlValueSet av_ = this.Observation_Services();
				IEnumerable<Encounter> aw_ = context.Operators.RetrieveByValueSet<Encounter>(av_, null);
				bool? ax_(Encounter LastObs)
				{
					Code<Encounter.EncounterStatus> gz_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(LastObs?.StatusElement?.Value);
					bool? ha_ = context.Operators.Equal(gz_, "finished");
					CqlInterval<CqlDateTime> hb_ = FHIRHelpers_4_3_000.ToInterval(LastObs?.Period);
					CqlDateTime hc_ = context.Operators.End(hb_);
					CqlInterval<CqlDateTime> hd_ = FHIRHelpers_4_3_000.ToInterval(Visit?.Period);
					CqlDateTime he_ = context.Operators.Start(hd_);
					CqlQuantity hf_ = context.Operators.Quantity(1m, "hour");
					CqlDateTime hg_ = context.Operators.Subtract(he_, hf_);
					CqlDateTime hi_ = context.Operators.Start(hd_);
					CqlInterval<CqlDateTime> hj_ = context.Operators.Interval(hg_, hi_, true, true);
					bool? hk_ = context.Operators.In<CqlDateTime>(hc_, hj_, null);
					CqlDateTime hm_ = context.Operators.Start(hd_);
					bool? hn_ = context.Operators.Not((bool?)(hm_ is null));
					bool? ho_ = context.Operators.And(hk_, hn_);
					bool? hp_ = context.Operators.And(ha_, ho_);

					return hp_;
				};
				IEnumerable<Encounter> ay_ = context.Operators.Where<Encounter>(aw_, ax_);
				object az_(Encounter @this)
				{
					CqlInterval<CqlDateTime> hq_ = FHIRHelpers_4_3_000.ToInterval(@this?.Period);
					CqlDateTime hr_ = context.Operators.End(hq_);

					return hr_;
				};
				IEnumerable<Encounter> ba_ = context.Operators.SortBy<Encounter>(ay_, az_, System.ComponentModel.ListSortDirection.Ascending);
				Encounter bb_ = context.Operators.Last<Encounter>(ba_);
				CqlInterval<CqlDateTime> bc_ = FHIRHelpers_4_3_000.ToInterval(bb_?.Period);
				CqlDateTime bd_ = context.Operators.Start(bc_);
				CqlInterval<CqlDateTime> be_ = FHIRHelpers_4_3_000.ToInterval(Visit?.Period);
				CqlDateTime bf_ = context.Operators.Start(be_);
				CqlQuantity bg_ = context.Operators.Quantity(1m, "hour");
				CqlDateTime bh_ = context.Operators.Subtract((au_ ?? (bd_ ?? bf_)), bg_);
				IEnumerable<Encounter> bj_ = context.Operators.RetrieveByValueSet<Encounter>(am_, null);
				bool? bk_(Encounter LastED)
				{
					Code<Encounter.EncounterStatus> hs_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(LastED?.StatusElement?.Value);
					bool? ht_ = context.Operators.Equal(hs_, "finished");
					CqlInterval<CqlDateTime> hu_ = FHIRHelpers_4_3_000.ToInterval(LastED?.Period);
					CqlDateTime hv_ = context.Operators.End(hu_);
					CqlValueSet hw_ = this.Observation_Services();
					IEnumerable<Encounter> hx_ = context.Operators.RetrieveByValueSet<Encounter>(hw_, null);
					bool? hy_(Encounter LastObs)
					{
						Code<Encounter.EncounterStatus> jk_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(LastObs?.StatusElement?.Value);
						bool? jl_ = context.Operators.Equal(jk_, "finished");
						CqlInterval<CqlDateTime> jm_ = FHIRHelpers_4_3_000.ToInterval(LastObs?.Period);
						CqlDateTime jn_ = context.Operators.End(jm_);
						CqlInterval<CqlDateTime> jo_ = FHIRHelpers_4_3_000.ToInterval(Visit?.Period);
						CqlDateTime jp_ = context.Operators.Start(jo_);
						CqlQuantity jq_ = context.Operators.Quantity(1m, "hour");
						CqlDateTime jr_ = context.Operators.Subtract(jp_, jq_);
						CqlDateTime jt_ = context.Operators.Start(jo_);
						CqlInterval<CqlDateTime> ju_ = context.Operators.Interval(jr_, jt_, true, true);
						bool? jv_ = context.Operators.In<CqlDateTime>(jn_, ju_, null);
						CqlDateTime jx_ = context.Operators.Start(jo_);
						bool? jy_ = context.Operators.Not((bool?)(jx_ is null));
						bool? jz_ = context.Operators.And(jv_, jy_);
						bool? ka_ = context.Operators.And(jl_, jz_);

						return ka_;
					};
					IEnumerable<Encounter> hz_ = context.Operators.Where<Encounter>(hx_, hy_);
					object ia_(Encounter @this)
					{
						CqlInterval<CqlDateTime> kb_ = FHIRHelpers_4_3_000.ToInterval(@this?.Period);
						CqlDateTime kc_ = context.Operators.End(kb_);

						return kc_;
					};
					IEnumerable<Encounter> ib_ = context.Operators.SortBy<Encounter>(hz_, ia_, System.ComponentModel.ListSortDirection.Ascending);
					Encounter ic_ = context.Operators.Last<Encounter>(ib_);
					CqlInterval<CqlDateTime> id_ = FHIRHelpers_4_3_000.ToInterval(ic_?.Period);
					CqlDateTime ie_ = context.Operators.Start(id_);
					CqlInterval<CqlDateTime> if_ = FHIRHelpers_4_3_000.ToInterval(Visit?.Period);
					CqlDateTime ig_ = context.Operators.Start(if_);
					CqlQuantity ih_ = context.Operators.Quantity(1m, "hour");
					CqlDateTime ii_ = context.Operators.Subtract((ie_ ?? ig_), ih_);
					IEnumerable<Encounter> ik_ = context.Operators.RetrieveByValueSet<Encounter>(hw_, null);
					bool? il_(Encounter LastObs)
					{
						Code<Encounter.EncounterStatus> kd_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(LastObs?.StatusElement?.Value);
						bool? ke_ = context.Operators.Equal(kd_, "finished");
						CqlInterval<CqlDateTime> kf_ = FHIRHelpers_4_3_000.ToInterval(LastObs?.Period);
						CqlDateTime kg_ = context.Operators.End(kf_);
						CqlInterval<CqlDateTime> kh_ = FHIRHelpers_4_3_000.ToInterval(Visit?.Period);
						CqlDateTime ki_ = context.Operators.Start(kh_);
						CqlQuantity kj_ = context.Operators.Quantity(1m, "hour");
						CqlDateTime kk_ = context.Operators.Subtract(ki_, kj_);
						CqlDateTime km_ = context.Operators.Start(kh_);
						CqlInterval<CqlDateTime> kn_ = context.Operators.Interval(kk_, km_, true, true);
						bool? ko_ = context.Operators.In<CqlDateTime>(kg_, kn_, null);
						CqlDateTime kq_ = context.Operators.Start(kh_);
						bool? kr_ = context.Operators.Not((bool?)(kq_ is null));
						bool? ks_ = context.Operators.And(ko_, kr_);
						bool? kt_ = context.Operators.And(ke_, ks_);

						return kt_;
					};
					IEnumerable<Encounter> im_ = context.Operators.Where<Encounter>(ik_, il_);
					object in_(Encounter @this)
					{
						CqlInterval<CqlDateTime> ku_ = FHIRHelpers_4_3_000.ToInterval(@this?.Period);
						CqlDateTime kv_ = context.Operators.End(ku_);

						return kv_;
					};
					IEnumerable<Encounter> io_ = context.Operators.SortBy<Encounter>(im_, in_, System.ComponentModel.ListSortDirection.Ascending);
					Encounter ip_ = context.Operators.Last<Encounter>(io_);
					CqlInterval<CqlDateTime> iq_ = FHIRHelpers_4_3_000.ToInterval(ip_?.Period);
					CqlDateTime ir_ = context.Operators.Start(iq_);
					CqlDateTime it_ = context.Operators.Start(if_);
					CqlInterval<CqlDateTime> iu_ = context.Operators.Interval(ii_, (ir_ ?? it_), true, true);
					bool? iv_ = context.Operators.In<CqlDateTime>(hv_, iu_, null);
					IEnumerable<Encounter> ix_ = context.Operators.RetrieveByValueSet<Encounter>(hw_, null);
					bool? iy_(Encounter LastObs)
					{
						Code<Encounter.EncounterStatus> kw_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(LastObs?.StatusElement?.Value);
						bool? kx_ = context.Operators.Equal(kw_, "finished");
						CqlInterval<CqlDateTime> ky_ = FHIRHelpers_4_3_000.ToInterval(LastObs?.Period);
						CqlDateTime kz_ = context.Operators.End(ky_);
						CqlInterval<CqlDateTime> la_ = FHIRHelpers_4_3_000.ToInterval(Visit?.Period);
						CqlDateTime lb_ = context.Operators.Start(la_);
						CqlQuantity lc_ = context.Operators.Quantity(1m, "hour");
						CqlDateTime ld_ = context.Operators.Subtract(lb_, lc_);
						CqlDateTime lf_ = context.Operators.Start(la_);
						CqlInterval<CqlDateTime> lg_ = context.Operators.Interval(ld_, lf_, true, true);
						bool? lh_ = context.Operators.In<CqlDateTime>(kz_, lg_, null);
						CqlDateTime lj_ = context.Operators.Start(la_);
						bool? lk_ = context.Operators.Not((bool?)(lj_ is null));
						bool? ll_ = context.Operators.And(lh_, lk_);
						bool? lm_ = context.Operators.And(kx_, ll_);

						return lm_;
					};
					IEnumerable<Encounter> iz_ = context.Operators.Where<Encounter>(ix_, iy_);
					object ja_(Encounter @this)
					{
						CqlInterval<CqlDateTime> ln_ = FHIRHelpers_4_3_000.ToInterval(@this?.Period);
						CqlDateTime lo_ = context.Operators.End(ln_);

						return lo_;
					};
					IEnumerable<Encounter> jb_ = context.Operators.SortBy<Encounter>(iz_, ja_, System.ComponentModel.ListSortDirection.Ascending);
					Encounter jc_ = context.Operators.Last<Encounter>(jb_);
					CqlInterval<CqlDateTime> jd_ = FHIRHelpers_4_3_000.ToInterval(jc_?.Period);
					CqlDateTime je_ = context.Operators.Start(jd_);
					CqlDateTime jg_ = context.Operators.Start(if_);
					bool? jh_ = context.Operators.Not((bool?)((je_ ?? jg_) is null));
					bool? ji_ = context.Operators.And(iv_, jh_);
					bool? jj_ = context.Operators.And(ht_, ji_);

					return jj_;
				};
				IEnumerable<Encounter> bl_ = context.Operators.Where<Encounter>(bj_, bk_);
				object bm_(Encounter @this)
				{
					CqlInterval<CqlDateTime> lp_ = FHIRHelpers_4_3_000.ToInterval(@this?.Period);
					CqlDateTime lq_ = context.Operators.End(lp_);

					return lq_;
				};
				IEnumerable<Encounter> bn_ = context.Operators.SortBy<Encounter>(bl_, bm_, System.ComponentModel.ListSortDirection.Ascending);
				Encounter bo_ = context.Operators.Last<Encounter>(bn_);
				CqlInterval<CqlDateTime> bp_ = FHIRHelpers_4_3_000.ToInterval(bo_?.Period);
				CqlDateTime bq_ = context.Operators.Start(bp_);
				IEnumerable<Encounter> bs_ = context.Operators.RetrieveByValueSet<Encounter>(av_, null);
				bool? bt_(Encounter LastObs)
				{
					Code<Encounter.EncounterStatus> lr_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(LastObs?.StatusElement?.Value);
					bool? ls_ = context.Operators.Equal(lr_, "finished");
					CqlInterval<CqlDateTime> lt_ = FHIRHelpers_4_3_000.ToInterval(LastObs?.Period);
					CqlDateTime lu_ = context.Operators.End(lt_);
					CqlInterval<CqlDateTime> lv_ = FHIRHelpers_4_3_000.ToInterval(Visit?.Period);
					CqlDateTime lw_ = context.Operators.Start(lv_);
					CqlQuantity lx_ = context.Operators.Quantity(1m, "hour");
					CqlDateTime ly_ = context.Operators.Subtract(lw_, lx_);
					CqlDateTime ma_ = context.Operators.Start(lv_);
					CqlInterval<CqlDateTime> mb_ = context.Operators.Interval(ly_, ma_, true, true);
					bool? mc_ = context.Operators.In<CqlDateTime>(lu_, mb_, null);
					CqlDateTime me_ = context.Operators.Start(lv_);
					bool? mf_ = context.Operators.Not((bool?)(me_ is null));
					bool? mg_ = context.Operators.And(mc_, mf_);
					bool? mh_ = context.Operators.And(ls_, mg_);

					return mh_;
				};
				IEnumerable<Encounter> bu_ = context.Operators.Where<Encounter>(bs_, bt_);
				object bv_(Encounter @this)
				{
					CqlInterval<CqlDateTime> mi_ = FHIRHelpers_4_3_000.ToInterval(@this?.Period);
					CqlDateTime mj_ = context.Operators.End(mi_);

					return mj_;
				};
				IEnumerable<Encounter> bw_ = context.Operators.SortBy<Encounter>(bu_, bv_, System.ComponentModel.ListSortDirection.Ascending);
				Encounter bx_ = context.Operators.Last<Encounter>(bw_);
				CqlInterval<CqlDateTime> by_ = FHIRHelpers_4_3_000.ToInterval(bx_?.Period);
				CqlDateTime bz_ = context.Operators.Start(by_);
				CqlDateTime cb_ = context.Operators.Start(be_);
				CqlInterval<CqlDateTime> cc_ = context.Operators.Interval(bh_, (bq_ ?? (bz_ ?? cb_)), true, true);
				bool? cd_ = context.Operators.In<CqlDateTime>(al_, cc_, null);
				IEnumerable<Encounter> cf_ = context.Operators.RetrieveByValueSet<Encounter>(am_, null);
				bool? cg_(Encounter LastED)
				{
					Code<Encounter.EncounterStatus> mk_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(LastED?.StatusElement?.Value);
					bool? ml_ = context.Operators.Equal(mk_, "finished");
					CqlInterval<CqlDateTime> mm_ = FHIRHelpers_4_3_000.ToInterval(LastED?.Period);
					CqlDateTime mn_ = context.Operators.End(mm_);
					CqlValueSet mo_ = this.Observation_Services();
					IEnumerable<Encounter> mp_ = context.Operators.RetrieveByValueSet<Encounter>(mo_, null);
					bool? mq_(Encounter LastObs)
					{
						Code<Encounter.EncounterStatus> oc_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(LastObs?.StatusElement?.Value);
						bool? od_ = context.Operators.Equal(oc_, "finished");
						CqlInterval<CqlDateTime> oe_ = FHIRHelpers_4_3_000.ToInterval(LastObs?.Period);
						CqlDateTime of_ = context.Operators.End(oe_);
						CqlInterval<CqlDateTime> og_ = FHIRHelpers_4_3_000.ToInterval(Visit?.Period);
						CqlDateTime oh_ = context.Operators.Start(og_);
						CqlQuantity oi_ = context.Operators.Quantity(1m, "hour");
						CqlDateTime oj_ = context.Operators.Subtract(oh_, oi_);
						CqlDateTime ol_ = context.Operators.Start(og_);
						CqlInterval<CqlDateTime> om_ = context.Operators.Interval(oj_, ol_, true, true);
						bool? on_ = context.Operators.In<CqlDateTime>(of_, om_, null);
						CqlDateTime op_ = context.Operators.Start(og_);
						bool? oq_ = context.Operators.Not((bool?)(op_ is null));
						bool? or_ = context.Operators.And(on_, oq_);
						bool? os_ = context.Operators.And(od_, or_);

						return os_;
					};
					IEnumerable<Encounter> mr_ = context.Operators.Where<Encounter>(mp_, mq_);
					object ms_(Encounter @this)
					{
						CqlInterval<CqlDateTime> ot_ = FHIRHelpers_4_3_000.ToInterval(@this?.Period);
						CqlDateTime ou_ = context.Operators.End(ot_);

						return ou_;
					};
					IEnumerable<Encounter> mt_ = context.Operators.SortBy<Encounter>(mr_, ms_, System.ComponentModel.ListSortDirection.Ascending);
					Encounter mu_ = context.Operators.Last<Encounter>(mt_);
					CqlInterval<CqlDateTime> mv_ = FHIRHelpers_4_3_000.ToInterval(mu_?.Period);
					CqlDateTime mw_ = context.Operators.Start(mv_);
					CqlInterval<CqlDateTime> mx_ = FHIRHelpers_4_3_000.ToInterval(Visit?.Period);
					CqlDateTime my_ = context.Operators.Start(mx_);
					CqlQuantity mz_ = context.Operators.Quantity(1m, "hour");
					CqlDateTime na_ = context.Operators.Subtract((mw_ ?? my_), mz_);
					IEnumerable<Encounter> nc_ = context.Operators.RetrieveByValueSet<Encounter>(mo_, null);
					bool? nd_(Encounter LastObs)
					{
						Code<Encounter.EncounterStatus> ov_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(LastObs?.StatusElement?.Value);
						bool? ow_ = context.Operators.Equal(ov_, "finished");
						CqlInterval<CqlDateTime> ox_ = FHIRHelpers_4_3_000.ToInterval(LastObs?.Period);
						CqlDateTime oy_ = context.Operators.End(ox_);
						CqlInterval<CqlDateTime> oz_ = FHIRHelpers_4_3_000.ToInterval(Visit?.Period);
						CqlDateTime pa_ = context.Operators.Start(oz_);
						CqlQuantity pb_ = context.Operators.Quantity(1m, "hour");
						CqlDateTime pc_ = context.Operators.Subtract(pa_, pb_);
						CqlDateTime pe_ = context.Operators.Start(oz_);
						CqlInterval<CqlDateTime> pf_ = context.Operators.Interval(pc_, pe_, true, true);
						bool? pg_ = context.Operators.In<CqlDateTime>(oy_, pf_, null);
						CqlDateTime pi_ = context.Operators.Start(oz_);
						bool? pj_ = context.Operators.Not((bool?)(pi_ is null));
						bool? pk_ = context.Operators.And(pg_, pj_);
						bool? pl_ = context.Operators.And(ow_, pk_);

						return pl_;
					};
					IEnumerable<Encounter> ne_ = context.Operators.Where<Encounter>(nc_, nd_);
					object nf_(Encounter @this)
					{
						CqlInterval<CqlDateTime> pm_ = FHIRHelpers_4_3_000.ToInterval(@this?.Period);
						CqlDateTime pn_ = context.Operators.End(pm_);

						return pn_;
					};
					IEnumerable<Encounter> ng_ = context.Operators.SortBy<Encounter>(ne_, nf_, System.ComponentModel.ListSortDirection.Ascending);
					Encounter nh_ = context.Operators.Last<Encounter>(ng_);
					CqlInterval<CqlDateTime> ni_ = FHIRHelpers_4_3_000.ToInterval(nh_?.Period);
					CqlDateTime nj_ = context.Operators.Start(ni_);
					CqlDateTime nl_ = context.Operators.Start(mx_);
					CqlInterval<CqlDateTime> nm_ = context.Operators.Interval(na_, (nj_ ?? nl_), true, true);
					bool? nn_ = context.Operators.In<CqlDateTime>(mn_, nm_, null);
					IEnumerable<Encounter> np_ = context.Operators.RetrieveByValueSet<Encounter>(mo_, null);
					bool? nq_(Encounter LastObs)
					{
						Code<Encounter.EncounterStatus> po_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(LastObs?.StatusElement?.Value);
						bool? pp_ = context.Operators.Equal(po_, "finished");
						CqlInterval<CqlDateTime> pq_ = FHIRHelpers_4_3_000.ToInterval(LastObs?.Period);
						CqlDateTime pr_ = context.Operators.End(pq_);
						CqlInterval<CqlDateTime> ps_ = FHIRHelpers_4_3_000.ToInterval(Visit?.Period);
						CqlDateTime pt_ = context.Operators.Start(ps_);
						CqlQuantity pu_ = context.Operators.Quantity(1m, "hour");
						CqlDateTime pv_ = context.Operators.Subtract(pt_, pu_);
						CqlDateTime px_ = context.Operators.Start(ps_);
						CqlInterval<CqlDateTime> py_ = context.Operators.Interval(pv_, px_, true, true);
						bool? pz_ = context.Operators.In<CqlDateTime>(pr_, py_, null);
						CqlDateTime qb_ = context.Operators.Start(ps_);
						bool? qc_ = context.Operators.Not((bool?)(qb_ is null));
						bool? qd_ = context.Operators.And(pz_, qc_);
						bool? qe_ = context.Operators.And(pp_, qd_);

						return qe_;
					};
					IEnumerable<Encounter> nr_ = context.Operators.Where<Encounter>(np_, nq_);
					object ns_(Encounter @this)
					{
						CqlInterval<CqlDateTime> qf_ = FHIRHelpers_4_3_000.ToInterval(@this?.Period);
						CqlDateTime qg_ = context.Operators.End(qf_);

						return qg_;
					};
					IEnumerable<Encounter> nt_ = context.Operators.SortBy<Encounter>(nr_, ns_, System.ComponentModel.ListSortDirection.Ascending);
					Encounter nu_ = context.Operators.Last<Encounter>(nt_);
					CqlInterval<CqlDateTime> nv_ = FHIRHelpers_4_3_000.ToInterval(nu_?.Period);
					CqlDateTime nw_ = context.Operators.Start(nv_);
					CqlDateTime ny_ = context.Operators.Start(mx_);
					bool? nz_ = context.Operators.Not((bool?)((nw_ ?? ny_) is null));
					bool? oa_ = context.Operators.And(nn_, nz_);
					bool? ob_ = context.Operators.And(ml_, oa_);

					return ob_;
				};
				IEnumerable<Encounter> ch_ = context.Operators.Where<Encounter>(cf_, cg_);
				object ci_(Encounter @this)
				{
					CqlInterval<CqlDateTime> qh_ = FHIRHelpers_4_3_000.ToInterval(@this?.Period);
					CqlDateTime qi_ = context.Operators.End(qh_);

					return qi_;
				};
				IEnumerable<Encounter> cj_ = context.Operators.SortBy<Encounter>(ch_, ci_, System.ComponentModel.ListSortDirection.Ascending);
				Encounter ck_ = context.Operators.Last<Encounter>(cj_);
				CqlInterval<CqlDateTime> cl_ = FHIRHelpers_4_3_000.ToInterval(ck_?.Period);
				CqlDateTime cm_ = context.Operators.Start(cl_);
				IEnumerable<Encounter> co_ = context.Operators.RetrieveByValueSet<Encounter>(av_, null);
				bool? cp_(Encounter LastObs)
				{
					Code<Encounter.EncounterStatus> qj_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(LastObs?.StatusElement?.Value);
					bool? qk_ = context.Operators.Equal(qj_, "finished");
					CqlInterval<CqlDateTime> ql_ = FHIRHelpers_4_3_000.ToInterval(LastObs?.Period);
					CqlDateTime qm_ = context.Operators.End(ql_);
					CqlInterval<CqlDateTime> qn_ = FHIRHelpers_4_3_000.ToInterval(Visit?.Period);
					CqlDateTime qo_ = context.Operators.Start(qn_);
					CqlQuantity qp_ = context.Operators.Quantity(1m, "hour");
					CqlDateTime qq_ = context.Operators.Subtract(qo_, qp_);
					CqlDateTime qs_ = context.Operators.Start(qn_);
					CqlInterval<CqlDateTime> qt_ = context.Operators.Interval(qq_, qs_, true, true);
					bool? qu_ = context.Operators.In<CqlDateTime>(qm_, qt_, null);
					CqlDateTime qw_ = context.Operators.Start(qn_);
					bool? qx_ = context.Operators.Not((bool?)(qw_ is null));
					bool? qy_ = context.Operators.And(qu_, qx_);
					bool? qz_ = context.Operators.And(qk_, qy_);

					return qz_;
				};
				IEnumerable<Encounter> cq_ = context.Operators.Where<Encounter>(co_, cp_);
				object cr_(Encounter @this)
				{
					CqlInterval<CqlDateTime> ra_ = FHIRHelpers_4_3_000.ToInterval(@this?.Period);
					CqlDateTime rb_ = context.Operators.End(ra_);

					return rb_;
				};
				IEnumerable<Encounter> cs_ = context.Operators.SortBy<Encounter>(cq_, cr_, System.ComponentModel.ListSortDirection.Ascending);
				Encounter ct_ = context.Operators.Last<Encounter>(cs_);
				CqlInterval<CqlDateTime> cu_ = FHIRHelpers_4_3_000.ToInterval(ct_?.Period);
				CqlDateTime cv_ = context.Operators.Start(cu_);
				CqlDateTime cx_ = context.Operators.Start(be_);
				bool? cy_ = context.Operators.Not((bool?)((cm_ ?? (cv_ ?? cx_)) is null));
				bool? cz_ = context.Operators.And(cd_, cy_);

				return cz_;
			};
			IEnumerable<Encounter> h_ = context.Operators.Where<Encounter>(f_, g_);
			object i_(Encounter @this)
			{
				CqlInterval<CqlDateTime> rc_ = FHIRHelpers_4_3_000.ToInterval(@this?.Period);
				CqlDateTime rd_ = context.Operators.End(rc_);

				return rd_;
			};
			IEnumerable<Encounter> j_ = context.Operators.SortBy<Encounter>(h_, i_, System.ComponentModel.ListSortDirection.Ascending);
			Encounter k_ = context.Operators.Last<Encounter>(j_);
			CqlInterval<CqlDateTime> l_ = FHIRHelpers_4_3_000.ToInterval(k_?.Period);
			CqlDateTime m_ = context.Operators.Start(l_);
			CqlValueSet n_ = this.Emergency_Department_Visit();
			IEnumerable<Encounter> o_ = context.Operators.RetrieveByValueSet<Encounter>(n_, null);
			bool? p_(Encounter LastED)
			{
				Code<Encounter.EncounterStatus> re_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(LastED?.StatusElement?.Value);
				bool? rf_ = context.Operators.Equal(re_, "finished");
				CqlInterval<CqlDateTime> rg_ = FHIRHelpers_4_3_000.ToInterval(LastED?.Period);
				CqlDateTime rh_ = context.Operators.End(rg_);
				CqlValueSet ri_ = this.Observation_Services();
				IEnumerable<Encounter> rj_ = context.Operators.RetrieveByValueSet<Encounter>(ri_, null);
				bool? rk_(Encounter LastObs)
				{
					Code<Encounter.EncounterStatus> sw_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(LastObs?.StatusElement?.Value);
					bool? sx_ = context.Operators.Equal(sw_, "finished");
					CqlInterval<CqlDateTime> sy_ = FHIRHelpers_4_3_000.ToInterval(LastObs?.Period);
					CqlDateTime sz_ = context.Operators.End(sy_);
					CqlInterval<CqlDateTime> ta_ = FHIRHelpers_4_3_000.ToInterval(Visit?.Period);
					CqlDateTime tb_ = context.Operators.Start(ta_);
					CqlQuantity tc_ = context.Operators.Quantity(1m, "hour");
					CqlDateTime td_ = context.Operators.Subtract(tb_, tc_);
					CqlDateTime tf_ = context.Operators.Start(ta_);
					CqlInterval<CqlDateTime> tg_ = context.Operators.Interval(td_, tf_, true, true);
					bool? th_ = context.Operators.In<CqlDateTime>(sz_, tg_, null);
					CqlDateTime tj_ = context.Operators.Start(ta_);
					bool? tk_ = context.Operators.Not((bool?)(tj_ is null));
					bool? tl_ = context.Operators.And(th_, tk_);
					bool? tm_ = context.Operators.And(sx_, tl_);

					return tm_;
				};
				IEnumerable<Encounter> rl_ = context.Operators.Where<Encounter>(rj_, rk_);
				object rm_(Encounter @this)
				{
					CqlInterval<CqlDateTime> tn_ = FHIRHelpers_4_3_000.ToInterval(@this?.Period);
					CqlDateTime to_ = context.Operators.End(tn_);

					return to_;
				};
				IEnumerable<Encounter> rn_ = context.Operators.SortBy<Encounter>(rl_, rm_, System.ComponentModel.ListSortDirection.Ascending);
				Encounter ro_ = context.Operators.Last<Encounter>(rn_);
				CqlInterval<CqlDateTime> rp_ = FHIRHelpers_4_3_000.ToInterval(ro_?.Period);
				CqlDateTime rq_ = context.Operators.Start(rp_);
				CqlInterval<CqlDateTime> rr_ = FHIRHelpers_4_3_000.ToInterval(Visit?.Period);
				CqlDateTime rs_ = context.Operators.Start(rr_);
				CqlQuantity rt_ = context.Operators.Quantity(1m, "hour");
				CqlDateTime ru_ = context.Operators.Subtract((rq_ ?? rs_), rt_);
				IEnumerable<Encounter> rw_ = context.Operators.RetrieveByValueSet<Encounter>(ri_, null);
				bool? rx_(Encounter LastObs)
				{
					Code<Encounter.EncounterStatus> tp_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(LastObs?.StatusElement?.Value);
					bool? tq_ = context.Operators.Equal(tp_, "finished");
					CqlInterval<CqlDateTime> tr_ = FHIRHelpers_4_3_000.ToInterval(LastObs?.Period);
					CqlDateTime ts_ = context.Operators.End(tr_);
					CqlInterval<CqlDateTime> tt_ = FHIRHelpers_4_3_000.ToInterval(Visit?.Period);
					CqlDateTime tu_ = context.Operators.Start(tt_);
					CqlQuantity tv_ = context.Operators.Quantity(1m, "hour");
					CqlDateTime tw_ = context.Operators.Subtract(tu_, tv_);
					CqlDateTime ty_ = context.Operators.Start(tt_);
					CqlInterval<CqlDateTime> tz_ = context.Operators.Interval(tw_, ty_, true, true);
					bool? ua_ = context.Operators.In<CqlDateTime>(ts_, tz_, null);
					CqlDateTime uc_ = context.Operators.Start(tt_);
					bool? ud_ = context.Operators.Not((bool?)(uc_ is null));
					bool? ue_ = context.Operators.And(ua_, ud_);
					bool? uf_ = context.Operators.And(tq_, ue_);

					return uf_;
				};
				IEnumerable<Encounter> ry_ = context.Operators.Where<Encounter>(rw_, rx_);
				object rz_(Encounter @this)
				{
					CqlInterval<CqlDateTime> ug_ = FHIRHelpers_4_3_000.ToInterval(@this?.Period);
					CqlDateTime uh_ = context.Operators.End(ug_);

					return uh_;
				};
				IEnumerable<Encounter> sa_ = context.Operators.SortBy<Encounter>(ry_, rz_, System.ComponentModel.ListSortDirection.Ascending);
				Encounter sb_ = context.Operators.Last<Encounter>(sa_);
				CqlInterval<CqlDateTime> sc_ = FHIRHelpers_4_3_000.ToInterval(sb_?.Period);
				CqlDateTime sd_ = context.Operators.Start(sc_);
				CqlDateTime sf_ = context.Operators.Start(rr_);
				CqlInterval<CqlDateTime> sg_ = context.Operators.Interval(ru_, (sd_ ?? sf_), true, true);
				bool? sh_ = context.Operators.In<CqlDateTime>(rh_, sg_, null);
				IEnumerable<Encounter> sj_ = context.Operators.RetrieveByValueSet<Encounter>(ri_, null);
				bool? sk_(Encounter LastObs)
				{
					Code<Encounter.EncounterStatus> ui_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(LastObs?.StatusElement?.Value);
					bool? uj_ = context.Operators.Equal(ui_, "finished");
					CqlInterval<CqlDateTime> uk_ = FHIRHelpers_4_3_000.ToInterval(LastObs?.Period);
					CqlDateTime ul_ = context.Operators.End(uk_);
					CqlInterval<CqlDateTime> um_ = FHIRHelpers_4_3_000.ToInterval(Visit?.Period);
					CqlDateTime un_ = context.Operators.Start(um_);
					CqlQuantity uo_ = context.Operators.Quantity(1m, "hour");
					CqlDateTime up_ = context.Operators.Subtract(un_, uo_);
					CqlDateTime ur_ = context.Operators.Start(um_);
					CqlInterval<CqlDateTime> us_ = context.Operators.Interval(up_, ur_, true, true);
					bool? ut_ = context.Operators.In<CqlDateTime>(ul_, us_, null);
					CqlDateTime uv_ = context.Operators.Start(um_);
					bool? uw_ = context.Operators.Not((bool?)(uv_ is null));
					bool? ux_ = context.Operators.And(ut_, uw_);
					bool? uy_ = context.Operators.And(uj_, ux_);

					return uy_;
				};
				IEnumerable<Encounter> sl_ = context.Operators.Where<Encounter>(sj_, sk_);
				object sm_(Encounter @this)
				{
					CqlInterval<CqlDateTime> uz_ = FHIRHelpers_4_3_000.ToInterval(@this?.Period);
					CqlDateTime va_ = context.Operators.End(uz_);

					return va_;
				};
				IEnumerable<Encounter> sn_ = context.Operators.SortBy<Encounter>(sl_, sm_, System.ComponentModel.ListSortDirection.Ascending);
				Encounter so_ = context.Operators.Last<Encounter>(sn_);
				CqlInterval<CqlDateTime> sp_ = FHIRHelpers_4_3_000.ToInterval(so_?.Period);
				CqlDateTime sq_ = context.Operators.Start(sp_);
				CqlDateTime ss_ = context.Operators.Start(rr_);
				bool? st_ = context.Operators.Not((bool?)((sq_ ?? ss_) is null));
				bool? su_ = context.Operators.And(sh_, st_);
				bool? sv_ = context.Operators.And(rf_, su_);

				return sv_;
			};
			IEnumerable<Encounter> q_ = context.Operators.Where<Encounter>(o_, p_);
			object r_(Encounter @this)
			{
				CqlInterval<CqlDateTime> vb_ = FHIRHelpers_4_3_000.ToInterval(@this?.Period);
				CqlDateTime vc_ = context.Operators.End(vb_);

				return vc_;
			};
			IEnumerable<Encounter> s_ = context.Operators.SortBy<Encounter>(q_, r_, System.ComponentModel.ListSortDirection.Ascending);
			Encounter t_ = context.Operators.Last<Encounter>(s_);
			CqlInterval<CqlDateTime> u_ = FHIRHelpers_4_3_000.ToInterval(t_?.Period);
			CqlDateTime v_ = context.Operators.Start(u_);
			CqlValueSet w_ = this.Observation_Services();
			IEnumerable<Encounter> x_ = context.Operators.RetrieveByValueSet<Encounter>(w_, null);
			bool? y_(Encounter LastObs)
			{
				Code<Encounter.EncounterStatus> vd_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(LastObs?.StatusElement?.Value);
				bool? ve_ = context.Operators.Equal(vd_, "finished");
				CqlInterval<CqlDateTime> vf_ = FHIRHelpers_4_3_000.ToInterval(LastObs?.Period);
				CqlDateTime vg_ = context.Operators.End(vf_);
				CqlInterval<CqlDateTime> vh_ = FHIRHelpers_4_3_000.ToInterval(Visit?.Period);
				CqlDateTime vi_ = context.Operators.Start(vh_);
				CqlQuantity vj_ = context.Operators.Quantity(1m, "hour");
				CqlDateTime vk_ = context.Operators.Subtract(vi_, vj_);
				CqlDateTime vm_ = context.Operators.Start(vh_);
				CqlInterval<CqlDateTime> vn_ = context.Operators.Interval(vk_, vm_, true, true);
				bool? vo_ = context.Operators.In<CqlDateTime>(vg_, vn_, null);
				CqlDateTime vq_ = context.Operators.Start(vh_);
				bool? vr_ = context.Operators.Not((bool?)(vq_ is null));
				bool? vs_ = context.Operators.And(vo_, vr_);
				bool? vt_ = context.Operators.And(ve_, vs_);

				return vt_;
			};
			IEnumerable<Encounter> z_ = context.Operators.Where<Encounter>(x_, y_);
			object aa_(Encounter @this)
			{
				CqlInterval<CqlDateTime> vu_ = FHIRHelpers_4_3_000.ToInterval(@this?.Period);
				CqlDateTime vv_ = context.Operators.End(vu_);

				return vv_;
			};
			IEnumerable<Encounter> ab_ = context.Operators.SortBy<Encounter>(z_, aa_, System.ComponentModel.ListSortDirection.Ascending);
			Encounter ac_ = context.Operators.Last<Encounter>(ab_);
			CqlInterval<CqlDateTime> ad_ = FHIRHelpers_4_3_000.ToInterval(ac_?.Period);
			CqlDateTime ae_ = context.Operators.Start(ad_);
			CqlInterval<CqlDateTime> af_ = FHIRHelpers_4_3_000.ToInterval(Visit?.Period);
			CqlDateTime ag_ = context.Operators.Start(af_);
			CqlDateTime ai_ = context.Operators.End(af_);
			CqlInterval<CqlDateTime> aj_ = context.Operators.Interval((m_ ?? (v_ ?? (ae_ ?? ag_))), ai_, true, true);

			return aj_;
		};
		IEnumerable<CqlInterval<CqlDateTime>> c_ = context.Operators.Select<Encounter, CqlInterval<CqlDateTime>>(a_, b_);
		CqlInterval<CqlDateTime> d_ = context.Operators.SingletonFrom<CqlInterval<CqlDateTime>>(c_);

		return d_;
	}

    [CqlDeclaration("HospitalizationWithObservation")]
    [CqlTag("description", "Hospitalization with Observation returns the total interval from the start of any immediately prior emergency department visit through the observation visit to the discharge of the given encounter")]
    [CqlTag("deprecated", "This function is deprecated. Use the fluent function `hospitalizationWithObservation()` instead.")]
	public CqlInterval<CqlDateTime> HospitalizationWithObservation(Encounter TheEncounter)
	{
		Encounter[] a_ = new Encounter[]
		{
			TheEncounter,
		};
		CqlInterval<CqlDateTime> b_(Encounter Visit)
		{
			CqlValueSet e_ = this.Emergency_Department_Visit();
			IEnumerable<Encounter> f_ = context.Operators.RetrieveByValueSet<Encounter>(e_, null);
			bool? g_(Encounter LastED)
			{
				Code<Encounter.EncounterStatus> ab_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(LastED?.StatusElement?.Value);
				bool? ac_ = context.Operators.Equal(ab_, "finished");
				CqlInterval<CqlDateTime> ad_ = FHIRHelpers_4_3_000.ToInterval(LastED?.Period);
				CqlDateTime ae_ = context.Operators.End(ad_);
				CqlValueSet af_ = this.Observation_Services();
				IEnumerable<Encounter> ag_ = context.Operators.RetrieveByValueSet<Encounter>(af_, null);
				bool? ah_(Encounter LastObs)
				{
					Code<Encounter.EncounterStatus> bt_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(LastObs?.StatusElement?.Value);
					bool? bu_ = context.Operators.Equal(bt_, "finished");
					CqlInterval<CqlDateTime> bv_ = FHIRHelpers_4_3_000.ToInterval(LastObs?.Period);
					CqlDateTime bw_ = context.Operators.End(bv_);
					CqlInterval<CqlDateTime> bx_ = FHIRHelpers_4_3_000.ToInterval(Visit?.Period);
					CqlDateTime by_ = context.Operators.Start(bx_);
					CqlQuantity bz_ = context.Operators.Quantity(1m, "hour");
					CqlDateTime ca_ = context.Operators.Subtract(by_, bz_);
					CqlDateTime cc_ = context.Operators.Start(bx_);
					CqlInterval<CqlDateTime> cd_ = context.Operators.Interval(ca_, cc_, true, true);
					bool? ce_ = context.Operators.In<CqlDateTime>(bw_, cd_, null);
					CqlDateTime cg_ = context.Operators.Start(bx_);
					bool? ch_ = context.Operators.Not((bool?)(cg_ is null));
					bool? ci_ = context.Operators.And(ce_, ch_);
					bool? cj_ = context.Operators.And(bu_, ci_);

					return cj_;
				};
				IEnumerable<Encounter> ai_ = context.Operators.Where<Encounter>(ag_, ah_);
				object aj_(Encounter @this)
				{
					CqlInterval<CqlDateTime> ck_ = FHIRHelpers_4_3_000.ToInterval(@this?.Period);
					CqlDateTime cl_ = context.Operators.End(ck_);

					return cl_;
				};
				IEnumerable<Encounter> ak_ = context.Operators.SortBy<Encounter>(ai_, aj_, System.ComponentModel.ListSortDirection.Ascending);
				Encounter al_ = context.Operators.Last<Encounter>(ak_);
				CqlInterval<CqlDateTime> am_ = FHIRHelpers_4_3_000.ToInterval(al_?.Period);
				CqlDateTime an_ = context.Operators.Start(am_);
				CqlInterval<CqlDateTime> ao_ = FHIRHelpers_4_3_000.ToInterval(Visit?.Period);
				CqlDateTime ap_ = context.Operators.Start(ao_);
				CqlQuantity aq_ = context.Operators.Quantity(1m, "hour");
				CqlDateTime ar_ = context.Operators.Subtract((an_ ?? ap_), aq_);
				IEnumerable<Encounter> at_ = context.Operators.RetrieveByValueSet<Encounter>(af_, null);
				bool? au_(Encounter LastObs)
				{
					Code<Encounter.EncounterStatus> cm_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(LastObs?.StatusElement?.Value);
					bool? cn_ = context.Operators.Equal(cm_, "finished");
					CqlInterval<CqlDateTime> co_ = FHIRHelpers_4_3_000.ToInterval(LastObs?.Period);
					CqlDateTime cp_ = context.Operators.End(co_);
					CqlInterval<CqlDateTime> cq_ = FHIRHelpers_4_3_000.ToInterval(Visit?.Period);
					CqlDateTime cr_ = context.Operators.Start(cq_);
					CqlQuantity cs_ = context.Operators.Quantity(1m, "hour");
					CqlDateTime ct_ = context.Operators.Subtract(cr_, cs_);
					CqlDateTime cv_ = context.Operators.Start(cq_);
					CqlInterval<CqlDateTime> cw_ = context.Operators.Interval(ct_, cv_, true, true);
					bool? cx_ = context.Operators.In<CqlDateTime>(cp_, cw_, null);
					CqlDateTime cz_ = context.Operators.Start(cq_);
					bool? da_ = context.Operators.Not((bool?)(cz_ is null));
					bool? db_ = context.Operators.And(cx_, da_);
					bool? dc_ = context.Operators.And(cn_, db_);

					return dc_;
				};
				IEnumerable<Encounter> av_ = context.Operators.Where<Encounter>(at_, au_);
				object aw_(Encounter @this)
				{
					CqlInterval<CqlDateTime> dd_ = FHIRHelpers_4_3_000.ToInterval(@this?.Period);
					CqlDateTime de_ = context.Operators.End(dd_);

					return de_;
				};
				IEnumerable<Encounter> ax_ = context.Operators.SortBy<Encounter>(av_, aw_, System.ComponentModel.ListSortDirection.Ascending);
				Encounter ay_ = context.Operators.Last<Encounter>(ax_);
				CqlInterval<CqlDateTime> az_ = FHIRHelpers_4_3_000.ToInterval(ay_?.Period);
				CqlDateTime ba_ = context.Operators.Start(az_);
				CqlDateTime bc_ = context.Operators.Start(ao_);
				CqlInterval<CqlDateTime> bd_ = context.Operators.Interval(ar_, (ba_ ?? bc_), true, true);
				bool? be_ = context.Operators.In<CqlDateTime>(ae_, bd_, null);
				IEnumerable<Encounter> bg_ = context.Operators.RetrieveByValueSet<Encounter>(af_, null);
				bool? bh_(Encounter LastObs)
				{
					Code<Encounter.EncounterStatus> df_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(LastObs?.StatusElement?.Value);
					bool? dg_ = context.Operators.Equal(df_, "finished");
					CqlInterval<CqlDateTime> dh_ = FHIRHelpers_4_3_000.ToInterval(LastObs?.Period);
					CqlDateTime di_ = context.Operators.End(dh_);
					CqlInterval<CqlDateTime> dj_ = FHIRHelpers_4_3_000.ToInterval(Visit?.Period);
					CqlDateTime dk_ = context.Operators.Start(dj_);
					CqlQuantity dl_ = context.Operators.Quantity(1m, "hour");
					CqlDateTime dm_ = context.Operators.Subtract(dk_, dl_);
					CqlDateTime do_ = context.Operators.Start(dj_);
					CqlInterval<CqlDateTime> dp_ = context.Operators.Interval(dm_, do_, true, true);
					bool? dq_ = context.Operators.In<CqlDateTime>(di_, dp_, null);
					CqlDateTime ds_ = context.Operators.Start(dj_);
					bool? dt_ = context.Operators.Not((bool?)(ds_ is null));
					bool? du_ = context.Operators.And(dq_, dt_);
					bool? dv_ = context.Operators.And(dg_, du_);

					return dv_;
				};
				IEnumerable<Encounter> bi_ = context.Operators.Where<Encounter>(bg_, bh_);
				object bj_(Encounter @this)
				{
					CqlInterval<CqlDateTime> dw_ = FHIRHelpers_4_3_000.ToInterval(@this?.Period);
					CqlDateTime dx_ = context.Operators.End(dw_);

					return dx_;
				};
				IEnumerable<Encounter> bk_ = context.Operators.SortBy<Encounter>(bi_, bj_, System.ComponentModel.ListSortDirection.Ascending);
				Encounter bl_ = context.Operators.Last<Encounter>(bk_);
				CqlInterval<CqlDateTime> bm_ = FHIRHelpers_4_3_000.ToInterval(bl_?.Period);
				CqlDateTime bn_ = context.Operators.Start(bm_);
				CqlDateTime bp_ = context.Operators.Start(ao_);
				bool? bq_ = context.Operators.Not((bool?)((bn_ ?? bp_) is null));
				bool? br_ = context.Operators.And(be_, bq_);
				bool? bs_ = context.Operators.And(ac_, br_);

				return bs_;
			};
			IEnumerable<Encounter> h_ = context.Operators.Where<Encounter>(f_, g_);
			object i_(Encounter @this)
			{
				CqlInterval<CqlDateTime> dy_ = FHIRHelpers_4_3_000.ToInterval(@this?.Period);
				CqlDateTime dz_ = context.Operators.End(dy_);

				return dz_;
			};
			IEnumerable<Encounter> j_ = context.Operators.SortBy<Encounter>(h_, i_, System.ComponentModel.ListSortDirection.Ascending);
			Encounter k_ = context.Operators.Last<Encounter>(j_);
			CqlInterval<CqlDateTime> l_ = FHIRHelpers_4_3_000.ToInterval(k_?.Period);
			CqlDateTime m_ = context.Operators.Start(l_);
			CqlValueSet n_ = this.Observation_Services();
			IEnumerable<Encounter> o_ = context.Operators.RetrieveByValueSet<Encounter>(n_, null);
			bool? p_(Encounter LastObs)
			{
				Code<Encounter.EncounterStatus> ea_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(LastObs?.StatusElement?.Value);
				bool? eb_ = context.Operators.Equal(ea_, "finished");
				CqlInterval<CqlDateTime> ec_ = FHIRHelpers_4_3_000.ToInterval(LastObs?.Period);
				CqlDateTime ed_ = context.Operators.End(ec_);
				CqlInterval<CqlDateTime> ee_ = FHIRHelpers_4_3_000.ToInterval(Visit?.Period);
				CqlDateTime ef_ = context.Operators.Start(ee_);
				CqlQuantity eg_ = context.Operators.Quantity(1m, "hour");
				CqlDateTime eh_ = context.Operators.Subtract(ef_, eg_);
				CqlDateTime ej_ = context.Operators.Start(ee_);
				CqlInterval<CqlDateTime> ek_ = context.Operators.Interval(eh_, ej_, true, true);
				bool? el_ = context.Operators.In<CqlDateTime>(ed_, ek_, null);
				CqlDateTime en_ = context.Operators.Start(ee_);
				bool? eo_ = context.Operators.Not((bool?)(en_ is null));
				bool? ep_ = context.Operators.And(el_, eo_);
				bool? eq_ = context.Operators.And(eb_, ep_);

				return eq_;
			};
			IEnumerable<Encounter> q_ = context.Operators.Where<Encounter>(o_, p_);
			object r_(Encounter @this)
			{
				CqlInterval<CqlDateTime> er_ = FHIRHelpers_4_3_000.ToInterval(@this?.Period);
				CqlDateTime es_ = context.Operators.End(er_);

				return es_;
			};
			IEnumerable<Encounter> s_ = context.Operators.SortBy<Encounter>(q_, r_, System.ComponentModel.ListSortDirection.Ascending);
			Encounter t_ = context.Operators.Last<Encounter>(s_);
			CqlInterval<CqlDateTime> u_ = FHIRHelpers_4_3_000.ToInterval(t_?.Period);
			CqlDateTime v_ = context.Operators.Start(u_);
			CqlInterval<CqlDateTime> w_ = FHIRHelpers_4_3_000.ToInterval(Visit?.Period);
			CqlDateTime x_ = context.Operators.Start(w_);
			CqlDateTime z_ = context.Operators.End(w_);
			CqlInterval<CqlDateTime> aa_ = context.Operators.Interval((m_ ?? (v_ ?? x_)), z_, true, true);

			return aa_;
		};
		IEnumerable<CqlInterval<CqlDateTime>> c_ = context.Operators.Select<Encounter, CqlInterval<CqlDateTime>>(a_, b_);
		CqlInterval<CqlDateTime> d_ = context.Operators.SingletonFrom<CqlInterval<CqlDateTime>>(c_);

		return d_;
	}

    [CqlDeclaration("hospitalizationWithObservation")]
    [CqlTag("description", "Hospitalization with Observation returns the total interval from the start of any immediately prior emergency department visit through the observation visit to the discharge of the given encounter")]
	public CqlInterval<CqlDateTime> hospitalizationWithObservation(Encounter TheEncounter)
	{
		Encounter[] a_ = new Encounter[]
		{
			TheEncounter,
		};
		CqlInterval<CqlDateTime> b_(Encounter Visit)
		{
			CqlValueSet e_ = this.Emergency_Department_Visit();
			IEnumerable<Encounter> f_ = context.Operators.RetrieveByValueSet<Encounter>(e_, null);
			bool? g_(Encounter LastED)
			{
				Code<Encounter.EncounterStatus> ab_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(LastED?.StatusElement?.Value);
				bool? ac_ = context.Operators.Equal(ab_, "finished");
				CqlInterval<CqlDateTime> ad_ = FHIRHelpers_4_3_000.ToInterval(LastED?.Period);
				CqlDateTime ae_ = context.Operators.End(ad_);
				CqlValueSet af_ = this.Observation_Services();
				IEnumerable<Encounter> ag_ = context.Operators.RetrieveByValueSet<Encounter>(af_, null);
				bool? ah_(Encounter LastObs)
				{
					Code<Encounter.EncounterStatus> bt_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(LastObs?.StatusElement?.Value);
					bool? bu_ = context.Operators.Equal(bt_, "finished");
					CqlInterval<CqlDateTime> bv_ = FHIRHelpers_4_3_000.ToInterval(LastObs?.Period);
					CqlDateTime bw_ = context.Operators.End(bv_);
					CqlInterval<CqlDateTime> bx_ = FHIRHelpers_4_3_000.ToInterval(Visit?.Period);
					CqlDateTime by_ = context.Operators.Start(bx_);
					CqlQuantity bz_ = context.Operators.Quantity(1m, "hour");
					CqlDateTime ca_ = context.Operators.Subtract(by_, bz_);
					CqlDateTime cc_ = context.Operators.Start(bx_);
					CqlInterval<CqlDateTime> cd_ = context.Operators.Interval(ca_, cc_, true, true);
					bool? ce_ = context.Operators.In<CqlDateTime>(bw_, cd_, null);
					CqlDateTime cg_ = context.Operators.Start(bx_);
					bool? ch_ = context.Operators.Not((bool?)(cg_ is null));
					bool? ci_ = context.Operators.And(ce_, ch_);
					bool? cj_ = context.Operators.And(bu_, ci_);

					return cj_;
				};
				IEnumerable<Encounter> ai_ = context.Operators.Where<Encounter>(ag_, ah_);
				object aj_(Encounter @this)
				{
					CqlInterval<CqlDateTime> ck_ = FHIRHelpers_4_3_000.ToInterval(@this?.Period);
					CqlDateTime cl_ = context.Operators.End(ck_);

					return cl_;
				};
				IEnumerable<Encounter> ak_ = context.Operators.SortBy<Encounter>(ai_, aj_, System.ComponentModel.ListSortDirection.Ascending);
				Encounter al_ = context.Operators.Last<Encounter>(ak_);
				CqlInterval<CqlDateTime> am_ = FHIRHelpers_4_3_000.ToInterval(al_?.Period);
				CqlDateTime an_ = context.Operators.Start(am_);
				CqlInterval<CqlDateTime> ao_ = FHIRHelpers_4_3_000.ToInterval(Visit?.Period);
				CqlDateTime ap_ = context.Operators.Start(ao_);
				CqlQuantity aq_ = context.Operators.Quantity(1m, "hour");
				CqlDateTime ar_ = context.Operators.Subtract((an_ ?? ap_), aq_);
				IEnumerable<Encounter> at_ = context.Operators.RetrieveByValueSet<Encounter>(af_, null);
				bool? au_(Encounter LastObs)
				{
					Code<Encounter.EncounterStatus> cm_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(LastObs?.StatusElement?.Value);
					bool? cn_ = context.Operators.Equal(cm_, "finished");
					CqlInterval<CqlDateTime> co_ = FHIRHelpers_4_3_000.ToInterval(LastObs?.Period);
					CqlDateTime cp_ = context.Operators.End(co_);
					CqlInterval<CqlDateTime> cq_ = FHIRHelpers_4_3_000.ToInterval(Visit?.Period);
					CqlDateTime cr_ = context.Operators.Start(cq_);
					CqlQuantity cs_ = context.Operators.Quantity(1m, "hour");
					CqlDateTime ct_ = context.Operators.Subtract(cr_, cs_);
					CqlDateTime cv_ = context.Operators.Start(cq_);
					CqlInterval<CqlDateTime> cw_ = context.Operators.Interval(ct_, cv_, true, true);
					bool? cx_ = context.Operators.In<CqlDateTime>(cp_, cw_, null);
					CqlDateTime cz_ = context.Operators.Start(cq_);
					bool? da_ = context.Operators.Not((bool?)(cz_ is null));
					bool? db_ = context.Operators.And(cx_, da_);
					bool? dc_ = context.Operators.And(cn_, db_);

					return dc_;
				};
				IEnumerable<Encounter> av_ = context.Operators.Where<Encounter>(at_, au_);
				object aw_(Encounter @this)
				{
					CqlInterval<CqlDateTime> dd_ = FHIRHelpers_4_3_000.ToInterval(@this?.Period);
					CqlDateTime de_ = context.Operators.End(dd_);

					return de_;
				};
				IEnumerable<Encounter> ax_ = context.Operators.SortBy<Encounter>(av_, aw_, System.ComponentModel.ListSortDirection.Ascending);
				Encounter ay_ = context.Operators.Last<Encounter>(ax_);
				CqlInterval<CqlDateTime> az_ = FHIRHelpers_4_3_000.ToInterval(ay_?.Period);
				CqlDateTime ba_ = context.Operators.Start(az_);
				CqlDateTime bc_ = context.Operators.Start(ao_);
				CqlInterval<CqlDateTime> bd_ = context.Operators.Interval(ar_, (ba_ ?? bc_), true, true);
				bool? be_ = context.Operators.In<CqlDateTime>(ae_, bd_, null);
				IEnumerable<Encounter> bg_ = context.Operators.RetrieveByValueSet<Encounter>(af_, null);
				bool? bh_(Encounter LastObs)
				{
					Code<Encounter.EncounterStatus> df_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(LastObs?.StatusElement?.Value);
					bool? dg_ = context.Operators.Equal(df_, "finished");
					CqlInterval<CqlDateTime> dh_ = FHIRHelpers_4_3_000.ToInterval(LastObs?.Period);
					CqlDateTime di_ = context.Operators.End(dh_);
					CqlInterval<CqlDateTime> dj_ = FHIRHelpers_4_3_000.ToInterval(Visit?.Period);
					CqlDateTime dk_ = context.Operators.Start(dj_);
					CqlQuantity dl_ = context.Operators.Quantity(1m, "hour");
					CqlDateTime dm_ = context.Operators.Subtract(dk_, dl_);
					CqlDateTime do_ = context.Operators.Start(dj_);
					CqlInterval<CqlDateTime> dp_ = context.Operators.Interval(dm_, do_, true, true);
					bool? dq_ = context.Operators.In<CqlDateTime>(di_, dp_, null);
					CqlDateTime ds_ = context.Operators.Start(dj_);
					bool? dt_ = context.Operators.Not((bool?)(ds_ is null));
					bool? du_ = context.Operators.And(dq_, dt_);
					bool? dv_ = context.Operators.And(dg_, du_);

					return dv_;
				};
				IEnumerable<Encounter> bi_ = context.Operators.Where<Encounter>(bg_, bh_);
				object bj_(Encounter @this)
				{
					CqlInterval<CqlDateTime> dw_ = FHIRHelpers_4_3_000.ToInterval(@this?.Period);
					CqlDateTime dx_ = context.Operators.End(dw_);

					return dx_;
				};
				IEnumerable<Encounter> bk_ = context.Operators.SortBy<Encounter>(bi_, bj_, System.ComponentModel.ListSortDirection.Ascending);
				Encounter bl_ = context.Operators.Last<Encounter>(bk_);
				CqlInterval<CqlDateTime> bm_ = FHIRHelpers_4_3_000.ToInterval(bl_?.Period);
				CqlDateTime bn_ = context.Operators.Start(bm_);
				CqlDateTime bp_ = context.Operators.Start(ao_);
				bool? bq_ = context.Operators.Not((bool?)((bn_ ?? bp_) is null));
				bool? br_ = context.Operators.And(be_, bq_);
				bool? bs_ = context.Operators.And(ac_, br_);

				return bs_;
			};
			IEnumerable<Encounter> h_ = context.Operators.Where<Encounter>(f_, g_);
			object i_(Encounter @this)
			{
				CqlInterval<CqlDateTime> dy_ = FHIRHelpers_4_3_000.ToInterval(@this?.Period);
				CqlDateTime dz_ = context.Operators.End(dy_);

				return dz_;
			};
			IEnumerable<Encounter> j_ = context.Operators.SortBy<Encounter>(h_, i_, System.ComponentModel.ListSortDirection.Ascending);
			Encounter k_ = context.Operators.Last<Encounter>(j_);
			CqlInterval<CqlDateTime> l_ = FHIRHelpers_4_3_000.ToInterval(k_?.Period);
			CqlDateTime m_ = context.Operators.Start(l_);
			CqlValueSet n_ = this.Observation_Services();
			IEnumerable<Encounter> o_ = context.Operators.RetrieveByValueSet<Encounter>(n_, null);
			bool? p_(Encounter LastObs)
			{
				Code<Encounter.EncounterStatus> ea_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(LastObs?.StatusElement?.Value);
				bool? eb_ = context.Operators.Equal(ea_, "finished");
				CqlInterval<CqlDateTime> ec_ = FHIRHelpers_4_3_000.ToInterval(LastObs?.Period);
				CqlDateTime ed_ = context.Operators.End(ec_);
				CqlInterval<CqlDateTime> ee_ = FHIRHelpers_4_3_000.ToInterval(Visit?.Period);
				CqlDateTime ef_ = context.Operators.Start(ee_);
				CqlQuantity eg_ = context.Operators.Quantity(1m, "hour");
				CqlDateTime eh_ = context.Operators.Subtract(ef_, eg_);
				CqlDateTime ej_ = context.Operators.Start(ee_);
				CqlInterval<CqlDateTime> ek_ = context.Operators.Interval(eh_, ej_, true, true);
				bool? el_ = context.Operators.In<CqlDateTime>(ed_, ek_, null);
				CqlDateTime en_ = context.Operators.Start(ee_);
				bool? eo_ = context.Operators.Not((bool?)(en_ is null));
				bool? ep_ = context.Operators.And(el_, eo_);
				bool? eq_ = context.Operators.And(eb_, ep_);

				return eq_;
			};
			IEnumerable<Encounter> q_ = context.Operators.Where<Encounter>(o_, p_);
			object r_(Encounter @this)
			{
				CqlInterval<CqlDateTime> er_ = FHIRHelpers_4_3_000.ToInterval(@this?.Period);
				CqlDateTime es_ = context.Operators.End(er_);

				return es_;
			};
			IEnumerable<Encounter> s_ = context.Operators.SortBy<Encounter>(q_, r_, System.ComponentModel.ListSortDirection.Ascending);
			Encounter t_ = context.Operators.Last<Encounter>(s_);
			CqlInterval<CqlDateTime> u_ = FHIRHelpers_4_3_000.ToInterval(t_?.Period);
			CqlDateTime v_ = context.Operators.Start(u_);
			CqlInterval<CqlDateTime> w_ = FHIRHelpers_4_3_000.ToInterval(Visit?.Period);
			CqlDateTime x_ = context.Operators.Start(w_);
			CqlDateTime z_ = context.Operators.End(w_);
			CqlInterval<CqlDateTime> aa_ = context.Operators.Interval((m_ ?? (v_ ?? x_)), z_, true, true);

			return aa_;
		};
		IEnumerable<CqlInterval<CqlDateTime>> c_ = context.Operators.Select<Encounter, CqlInterval<CqlDateTime>>(a_, b_);
		CqlInterval<CqlDateTime> d_ = context.Operators.SingletonFrom<CqlInterval<CqlDateTime>>(c_);

		return d_;
	}

    [CqlDeclaration("HospitalizationWithObservationLengthofStay")]
    [CqlTag("description", "Hospitalization with Observation Length of Stay returns the length in days from the start of any immediately prior emergency department visit through the observation visit to the discharge of the given encounter")]
    [CqlTag("deprecated", "This function is deprecated. Use the fluent function `hospitalizationWithObservationLengthofStay()` instead.")]
	public int? HospitalizationWithObservationLengthofStay(Encounter TheEncounter)
	{
		CqlInterval<CqlDateTime> a_ = this.HospitalizationWithObservation(TheEncounter);
		int? b_ = this.LengthInDays(a_);

		return b_;
	}

    [CqlDeclaration("hospitalizationWithObservationLengthofStay")]
    [CqlTag("description", "Hospitalization with Observation Length of Stay returns the length in days from the start of any immediately prior emergency department visit through the observation visit to the discharge of the given encounter")]
	public int? hospitalizationWithObservationLengthofStay(Encounter TheEncounter)
	{
		CqlInterval<CqlDateTime> a_ = this.hospitalizationWithObservation(TheEncounter);
		int? b_ = this.lengthInDays(a_);

		return b_;
	}

    [CqlDeclaration("FirstInpatientIntensiveCareUnit")]
    [CqlTag("description", "First Inpatient Intensive Care Unit returns the first intensive care unit for the given encounter, without considering any immediately prior emergency department visit.")]
    [CqlTag("deprecated", "This function is deprecated. Use the fluent function `firstInpatientIntensiveCareUnit()` instead.")]
	public Encounter.LocationComponent FirstInpatientIntensiveCareUnit(Encounter Encounter)
	{
		bool? a_(Encounter.LocationComponent HospitalLocation)
		{
			Location f_ = this.GetLocation(HospitalLocation?.Location);
			CqlConcept g_(CodeableConcept @this)
			{
				CqlConcept o_ = FHIRHelpers_4_3_000.ToConcept(@this);

				return o_;
			};
			IEnumerable<CqlConcept> h_ = context.Operators.Select<CodeableConcept, CqlConcept>(f_?.Type, g_);
			CqlValueSet i_ = this.Intensive_Care_Unit();
			bool? j_ = context.Operators.ConceptsInValueSet(h_, i_);
			CqlInterval<CqlDateTime> k_ = FHIRHelpers_4_3_000.ToInterval(Encounter?.Period);
			CqlInterval<CqlDateTime> l_ = FHIRHelpers_4_3_000.ToInterval(HospitalLocation?.Period);
			bool? m_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(k_, l_, null);
			bool? n_ = context.Operators.And(j_, m_);

			return n_;
		};
		IEnumerable<Encounter.LocationComponent> b_ = context.Operators.Where<Encounter.LocationComponent>((Encounter?.Location as IEnumerable<Encounter.LocationComponent>), a_);
		object c_(Encounter.LocationComponent @this)
		{
			CqlInterval<CqlDateTime> p_ = FHIRHelpers_4_3_000.ToInterval(@this?.Period);
			CqlDateTime q_ = context.Operators.Start(p_);

			return q_;
		};
		IEnumerable<Encounter.LocationComponent> d_ = context.Operators.SortBy<Encounter.LocationComponent>(b_, c_, System.ComponentModel.ListSortDirection.Ascending);
		Encounter.LocationComponent e_ = context.Operators.First<Encounter.LocationComponent>(d_);

		return e_;
	}

    [CqlDeclaration("firstInpatientIntensiveCareUnit")]
    [CqlTag("description", "First Inpatient Intensive Care Unit returns the first intensive care unit for the given encounter, without considering any immediately prior emergency department visit.")]
	public Encounter.LocationComponent firstInpatientIntensiveCareUnit(Encounter Encounter)
	{
		bool? a_(Encounter.LocationComponent HospitalLocation)
		{
			Location f_ = this.GetLocation(HospitalLocation?.Location);
			CqlConcept g_(CodeableConcept @this)
			{
				CqlConcept o_ = FHIRHelpers_4_3_000.ToConcept(@this);

				return o_;
			};
			IEnumerable<CqlConcept> h_ = context.Operators.Select<CodeableConcept, CqlConcept>(f_?.Type, g_);
			CqlValueSet i_ = this.Intensive_Care_Unit();
			bool? j_ = context.Operators.ConceptsInValueSet(h_, i_);
			CqlInterval<CqlDateTime> k_ = FHIRHelpers_4_3_000.ToInterval(Encounter?.Period);
			CqlInterval<CqlDateTime> l_ = FHIRHelpers_4_3_000.ToInterval(HospitalLocation?.Period);
			bool? m_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(k_, l_, null);
			bool? n_ = context.Operators.And(j_, m_);

			return n_;
		};
		IEnumerable<Encounter.LocationComponent> b_ = context.Operators.Where<Encounter.LocationComponent>((Encounter?.Location as IEnumerable<Encounter.LocationComponent>), a_);
		object c_(Encounter.LocationComponent @this)
		{
			CqlInterval<CqlDateTime> p_ = FHIRHelpers_4_3_000.ToInterval(@this?.Period);
			CqlDateTime q_ = context.Operators.Start(p_);

			return q_;
		};
		IEnumerable<Encounter.LocationComponent> d_ = context.Operators.SortBy<Encounter.LocationComponent>(b_, c_, System.ComponentModel.ListSortDirection.Ascending);
		Encounter.LocationComponent e_ = context.Operators.First<Encounter.LocationComponent>(d_);

		return e_;
	}

    [CqlDeclaration("EncounterDiagnosis")]
    [CqlTag("description", "Returns the Condition resource referenced by the `diagnosis.condition` element of the Encounter")]
    [CqlTag("deprecated", "This function is deprecated. Use the fluent function `encounterDiagnosis()` instead.")]
	public IEnumerable<Condition> EncounterDiagnosis(Encounter Encounter)
	{
		Condition a_(Encounter.DiagnosisComponent D)
		{
			IEnumerable<Condition> c_ = context.Operators.RetrieveByValueSet<Condition>(null, null);
			bool? d_(Condition C)
			{
				string g_ = QICoreCommon_2_0_000.getId(D?.Condition?.ReferenceElement?.Value);
				bool? h_ = context.Operators.Equal(C?.IdElement?.Value, g_);

				return h_;
			};
			IEnumerable<Condition> e_ = context.Operators.Where<Condition>(c_, d_);
			Condition f_ = context.Operators.SingletonFrom<Condition>(e_);

			return f_;
		};
		IEnumerable<Condition> b_ = context.Operators.Select<Encounter.DiagnosisComponent, Condition>((Encounter?.Diagnosis as IEnumerable<Encounter.DiagnosisComponent>), a_);

		return b_;
	}

    [CqlDeclaration("encounterDiagnosis")]
    [CqlTag("description", "Returns the Condition resources referenced by the diagnosis element of the Encounter")]
	public IEnumerable<Condition> encounterDiagnosis(Encounter Encounter)
	{
		Condition a_(Encounter.DiagnosisComponent D)
		{
			IEnumerable<Condition> c_ = context.Operators.RetrieveByValueSet<Condition>(null, null);
			bool? d_(Condition C)
			{
				string g_ = QICoreCommon_2_0_000.getId(D?.Condition?.ReferenceElement?.Value);
				bool? h_ = context.Operators.Equal(C?.IdElement?.Value, g_);

				return h_;
			};
			IEnumerable<Condition> e_ = context.Operators.Where<Condition>(c_, d_);
			Condition f_ = context.Operators.SingletonFrom<Condition>(e_);

			return f_;
		};
		IEnumerable<Condition> b_ = context.Operators.Select<Encounter.DiagnosisComponent, Condition>((Encounter?.Diagnosis as IEnumerable<Encounter.DiagnosisComponent>), a_);

		return b_;
	}

    [CqlDeclaration("GetCondition")]
    [CqlTag("description", "Returns the Condition resource for the given reference")]
    [CqlTag("deprecated", "This function is deprecated. Use the fluent function `getCondition()` instead")]
	public Condition GetCondition(ResourceReference reference)
	{
		IEnumerable<Condition> a_ = context.Operators.RetrieveByValueSet<Condition>(null, null);
		bool? b_(Condition C)
		{
			string e_ = QICoreCommon_2_0_000.getId(reference?.ReferenceElement?.Value);
			bool? f_ = context.Operators.Equal(C?.IdElement?.Value, e_);

			return f_;
		};
		IEnumerable<Condition> c_ = context.Operators.Where<Condition>(a_, b_);
		Condition d_ = context.Operators.SingletonFrom<Condition>(c_);

		return d_;
	}

    [CqlDeclaration("getCondition")]
    [CqlTag("description", "Returns the Condition resource for the given reference")]
	public Condition getCondition(ResourceReference reference)
	{
		IEnumerable<Condition> a_ = context.Operators.RetrieveByValueSet<Condition>(null, null);
		bool? b_(Condition C)
		{
			string e_ = QICoreCommon_2_0_000.getId(reference?.ReferenceElement?.Value);
			bool? f_ = context.Operators.Equal(C?.IdElement?.Value, e_);

			return f_;
		};
		IEnumerable<Condition> c_ = context.Operators.Where<Condition>(a_, b_);
		Condition d_ = context.Operators.SingletonFrom<Condition>(c_);

		return d_;
	}

    [CqlDeclaration("PrincipalDiagnosis")]
    [CqlTag("description", "Returns the condition that is specified as the principal diagnosis for the encounter")]
    [CqlTag("deprecated", "This function is deprecated. Use the fluent function `principalDiagnosis()` instead.")]
	public Condition PrincipalDiagnosis(Encounter Encounter)
	{
		bool? a_(Encounter.DiagnosisComponent D)
		{
			bool? f_ = context.Operators.Equal(D?.RankElement?.Value, 1);

			return f_;
		};
		IEnumerable<Encounter.DiagnosisComponent> b_ = context.Operators.Where<Encounter.DiagnosisComponent>((Encounter?.Diagnosis as IEnumerable<Encounter.DiagnosisComponent>), a_);
		Condition c_(Encounter.DiagnosisComponent PD)
		{
			IEnumerable<Condition> g_ = context.Operators.RetrieveByValueSet<Condition>(null, null);
			bool? h_(Condition C)
			{
				string k_ = QICoreCommon_2_0_000.getId(PD?.Condition?.ReferenceElement?.Value);
				bool? l_ = context.Operators.Equal(C?.IdElement?.Value, k_);

				return l_;
			};
			IEnumerable<Condition> i_ = context.Operators.Where<Condition>(g_, h_);
			Condition j_ = context.Operators.SingletonFrom<Condition>(i_);

			return j_;
		};
		IEnumerable<Condition> d_ = context.Operators.Select<Encounter.DiagnosisComponent, Condition>(b_, c_);
		Condition e_ = context.Operators.SingletonFrom<Condition>(d_);

		return e_;
	}

    [CqlDeclaration("principalDiagnosis")]
    [CqlTag("description", "Returns the condition that is specified as the principal diagnosis for the encounter")]
	public Condition principalDiagnosis(Encounter Encounter)
	{
		bool? a_(Encounter.DiagnosisComponent D)
		{
			bool? f_ = context.Operators.Equal(D?.RankElement?.Value, 1);

			return f_;
		};
		IEnumerable<Encounter.DiagnosisComponent> b_ = context.Operators.Where<Encounter.DiagnosisComponent>((Encounter?.Diagnosis as IEnumerable<Encounter.DiagnosisComponent>), a_);
		Condition c_(Encounter.DiagnosisComponent PD)
		{
			IEnumerable<Condition> g_ = context.Operators.RetrieveByValueSet<Condition>(null, null);
			bool? h_(Condition C)
			{
				string k_ = QICoreCommon_2_0_000.getId(PD?.Condition?.ReferenceElement?.Value);
				bool? l_ = context.Operators.Equal(C?.IdElement?.Value, k_);

				return l_;
			};
			IEnumerable<Condition> i_ = context.Operators.Where<Condition>(g_, h_);
			Condition j_ = context.Operators.SingletonFrom<Condition>(i_);

			return j_;
		};
		IEnumerable<Condition> d_ = context.Operators.Select<Encounter.DiagnosisComponent, Condition>(b_, c_);
		Condition e_ = context.Operators.SingletonFrom<Condition>(d_);

		return e_;
	}

    [CqlDeclaration("getLocation")]
    [CqlTag("description", "Returns the Location resource specified by the given reference.")]
	public Location getLocation(ResourceReference reference)
	{
		IEnumerable<Location> a_ = context.Operators.RetrieveByValueSet<Location>(null, null);
		bool? b_(Location L)
		{
			string e_ = QICoreCommon_2_0_000.getId(reference?.ReferenceElement?.Value);
			bool? f_ = context.Operators.Equal(L?.IdElement?.Value, e_);

			return f_;
		};
		IEnumerable<Location> c_ = context.Operators.Where<Location>(a_, b_);
		Location d_ = context.Operators.SingletonFrom<Location>(c_);

		return d_;
	}

    [CqlDeclaration("GetMedicationCode")]
    [CqlTag("description", "Returns the medication code for the given MedicationRequest")]
    [CqlTag("deprecated", "This function is deprecated. Use the fluent function `getMedicationCode()` instead.")]
	public CqlConcept GetMedicationCode(MedicationRequest request)
	{
		CqlConcept a_()
		{
			bool b_()
			{
				object c_ = FHIRHelpers_4_3_000.ToValue(request?.Medication);
				bool d_ = c_ is CqlConcept;

				return d_;
			};
			if (b_())
			{
				object e_ = FHIRHelpers_4_3_000.ToValue(request?.Medication);

				return (e_ as CqlConcept);
			}
			else
			{
				IEnumerable<Medication> f_ = context.Operators.RetrieveByValueSet<Medication>(null, null);
				bool? g_(Medication M)
				{
					object k_ = FHIRHelpers_4_3_000.ToValue(request?.Medication);
					string l_ = QICoreCommon_2_0_000.getId(((k_ as ResourceReference)?.ReferenceElement)?.Value);
					bool? m_ = context.Operators.Equal(M?.IdElement?.Value, l_);

					return m_;
				};
				IEnumerable<Medication> h_ = context.Operators.Where<Medication>(f_, g_);
				Medication i_ = context.Operators.SingletonFrom<Medication>(h_);
				CqlConcept j_ = FHIRHelpers_4_3_000.ToConcept(i_?.Code);

				return j_;
			};
		};

		return a_();
	}

    [CqlDeclaration("getMedicationCode")]
    [CqlTag("description", "Returns the medication code for the given MedicationRequest")]
	public CqlConcept getMedicationCode(MedicationRequest request)
	{
		CqlConcept a_()
		{
			bool b_()
			{
				object c_ = FHIRHelpers_4_3_000.ToValue(request?.Medication);
				bool d_ = c_ is CqlConcept;

				return d_;
			};
			if (b_())
			{
				object e_ = FHIRHelpers_4_3_000.ToValue(request?.Medication);

				return (e_ as CqlConcept);
			}
			else
			{
				IEnumerable<Medication> f_ = context.Operators.RetrieveByValueSet<Medication>(null, null);
				bool? g_(Medication M)
				{
					object k_ = FHIRHelpers_4_3_000.ToValue(request?.Medication);
					string l_ = QICoreCommon_2_0_000.getId(((k_ as ResourceReference)?.ReferenceElement)?.Value);
					bool? m_ = context.Operators.Equal(M?.IdElement?.Value, l_);

					return m_;
				};
				IEnumerable<Medication> h_ = context.Operators.Where<Medication>(f_, g_);
				Medication i_ = context.Operators.SingletonFrom<Medication>(h_);
				CqlConcept j_ = FHIRHelpers_4_3_000.ToConcept(i_?.Code);

				return j_;
			};
		};

		return a_();
	}

}
