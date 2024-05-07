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
		var a_ = context.Operators.DateTime(2025, 1, 1, 0, 0, 0, 0, default);
		var b_ = context.Operators.DateTime(2026, 1, 1, 0, 0, 0, 0, default);
		var c_ = context.Operators.Interval(a_, b_, true, false);
		var d_ = context.ResolveParameter("CQMCommon-2.0.000", "Measurement Period", c_);

		return (CqlInterval<CqlDateTime>)d_;
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

	private IEnumerable<Encounter> Inpatient_Encounter_Value()
	{
		var a_ = this.Encounter_Inpatient();
		var b_ = context.Operators.RetrieveByValueSet<Encounter>(a_, null);
		bool? c_(Encounter EncounterInpatient)
		{
			var e_ = EncounterInpatient?.StatusElement;
			var f_ = e_?.Value;
			var g_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(f_);
			var h_ = context.Operators.Equal(g_, "finished");
			var i_ = EncounterInpatient?.Period;
			var j_ = FHIRHelpers_4_3_000.ToInterval(i_);
			var k_ = context.Operators.End(j_);
			var l_ = this.Measurement_Period();
			var m_ = context.Operators.In<CqlDateTime>(k_, l_, "day");
			var n_ = context.Operators.And(h_, m_);

			return n_;
		};
		var d_ = context.Operators.Where<Encounter>(b_, c_);

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
		var a_ = context.Operators.Start(period);
		var b_ = context.Operators.DateFrom(a_);
		var c_ = context.Operators.End(period);
		var d_ = context.Operators.DateFrom(c_);
		var e_ = context.Operators.Interval(b_, d_, true, true);

		return e_;
	}

    [CqlDeclaration("LengthInDays")]
    [CqlTag("description", "Calculates the difference in calendar days between the start and end of the given interval.")]
    [CqlTag("deprecated", "This function in deprecated. Use the fluent function `lengthInDays()` instead.")]
	public int? LengthInDays(CqlInterval<CqlDateTime> Value)
	{
		var a_ = context.Operators.Start(Value);
		var b_ = context.Operators.End(Value);
		var c_ = context.Operators.DifferenceBetween(a_, b_, "day");

		return c_;
	}

    [CqlDeclaration("lengthInDays")]
    [CqlTag("description", "Calculates the difference in calendar days between the start and end of the given interval.")]
	public int? lengthInDays(CqlInterval<CqlDateTime> Value)
	{
		var a_ = context.Operators.Start(Value);
		var b_ = context.Operators.End(Value);
		var c_ = context.Operators.DifferenceBetween(a_, b_, "day");

		return c_;
	}

    [CqlDeclaration("ED Visit")]
    [CqlTag("description", "Returns the most recent emergency department visit, if any, that occurs 1 hour or less prior to the given encounter.")]
    [CqlTag("deprecated", "This function is deprecated. Use the fluent function `edVisit()` instead.")]
	public Encounter ED_Visit(Encounter TheEncounter)
	{
		var a_ = this.Emergency_Department_Visit();
		var b_ = context.Operators.RetrieveByValueSet<Encounter>(a_, null);
		bool? c_(Encounter EDVisit)
		{
			var h_ = EDVisit?.StatusElement;
			var i_ = h_?.Value;
			var j_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(i_);
			var k_ = context.Operators.Equal(j_, "finished");
			var l_ = EDVisit?.Period;
			var m_ = FHIRHelpers_4_3_000.ToInterval(l_);
			var n_ = context.Operators.End(m_);
			var o_ = TheEncounter?.Period;
			var p_ = FHIRHelpers_4_3_000.ToInterval(o_);
			var q_ = context.Operators.Start(p_);
			var r_ = context.Operators.Quantity(1m, "hour");
			var s_ = context.Operators.Subtract(q_, r_);
			var u_ = FHIRHelpers_4_3_000.ToInterval(o_);
			var v_ = context.Operators.Start(u_);
			var w_ = context.Operators.Interval(s_, v_, true, true);
			var x_ = context.Operators.In<CqlDateTime>(n_, w_, null);
			var z_ = FHIRHelpers_4_3_000.ToInterval(o_);
			var aa_ = context.Operators.Start(z_);
			var ab_ = context.Operators.Not((bool?)(aa_ is null));
			var ac_ = context.Operators.And(x_, ab_);
			var ad_ = context.Operators.And(k_, ac_);

			return ad_;
		};
		var d_ = context.Operators.Where<Encounter>(b_, c_);
		object e_(Encounter @this)
		{
			var ae_ = @this?.Period;
			var af_ = FHIRHelpers_4_3_000.ToInterval(ae_);
			var ag_ = context.Operators.End(af_);

			return ag_;
		};
		var f_ = context.Operators.SortBy<Encounter>(d_, e_, System.ComponentModel.ListSortDirection.Ascending);
		var g_ = context.Operators.Last<Encounter>(f_);

		return g_;
	}

    [CqlDeclaration("edVisit")]
    [CqlTag("description", "Returns the most recent emergency department visit, if any, that occurs 1 hour or less prior to the given encounter.")]
	public Encounter edVisit(Encounter TheEncounter)
	{
		var a_ = this.Emergency_Department_Visit();
		var b_ = context.Operators.RetrieveByValueSet<Encounter>(a_, null);
		bool? c_(Encounter EDVisit)
		{
			var h_ = EDVisit?.StatusElement;
			var i_ = h_?.Value;
			var j_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(i_);
			var k_ = context.Operators.Equal(j_, "finished");
			var l_ = EDVisit?.Period;
			var m_ = FHIRHelpers_4_3_000.ToInterval(l_);
			var n_ = context.Operators.End(m_);
			var o_ = TheEncounter?.Period;
			var p_ = FHIRHelpers_4_3_000.ToInterval(o_);
			var q_ = context.Operators.Start(p_);
			var r_ = context.Operators.Quantity(1m, "hour");
			var s_ = context.Operators.Subtract(q_, r_);
			var u_ = FHIRHelpers_4_3_000.ToInterval(o_);
			var v_ = context.Operators.Start(u_);
			var w_ = context.Operators.Interval(s_, v_, true, true);
			var x_ = context.Operators.In<CqlDateTime>(n_, w_, null);
			var z_ = FHIRHelpers_4_3_000.ToInterval(o_);
			var aa_ = context.Operators.Start(z_);
			var ab_ = context.Operators.Not((bool?)(aa_ is null));
			var ac_ = context.Operators.And(x_, ab_);
			var ad_ = context.Operators.And(k_, ac_);

			return ad_;
		};
		var d_ = context.Operators.Where<Encounter>(b_, c_);
		object e_(Encounter @this)
		{
			var ae_ = @this?.Period;
			var af_ = FHIRHelpers_4_3_000.ToInterval(ae_);
			var ag_ = context.Operators.End(af_);

			return ag_;
		};
		var f_ = context.Operators.SortBy<Encounter>(d_, e_, System.ComponentModel.ListSortDirection.Ascending);
		var g_ = context.Operators.Last<Encounter>(f_);

		return g_;
	}

    [CqlDeclaration("Hospitalization")]
    [CqlTag("description", "Hospitalization returns the total interval for admission to discharge for the given encounter, or for the admission of any immediately prior emergency department visit to the discharge of the given encounter.")]
    [CqlTag("deprecated", "This function is deprecated. Use the fluent function `hospitalization()` instead.")]
	public CqlInterval<CqlDateTime> Hospitalization(Encounter TheEncounter)
	{
		var a_ = this.ED_Visit(TheEncounter);
		var b_ = new Encounter[]
		{
			a_,
		};
		CqlInterval<CqlDateTime> c_(Encounter X)
		{
			CqlInterval<CqlDateTime> f_()
			{
				if ((X is null))
				{
					var g_ = TheEncounter?.Period;
					var h_ = FHIRHelpers_4_3_000.ToInterval(g_);

					return h_;
				}
				else
				{
					var i_ = X?.Period;
					var j_ = FHIRHelpers_4_3_000.ToInterval(i_);
					var k_ = context.Operators.Start(j_);
					var l_ = TheEncounter?.Period;
					var m_ = FHIRHelpers_4_3_000.ToInterval(l_);
					var n_ = context.Operators.End(m_);
					var o_ = context.Operators.Interval(k_, n_, true, false);

					return o_;
				}
			};

			return f_();
		};
		var d_ = context.Operators.Select<Encounter, CqlInterval<CqlDateTime>>((IEnumerable<Encounter>)b_, c_);
		var e_ = context.Operators.SingletonFrom<CqlInterval<CqlDateTime>>(d_);

		return e_;
	}

    [CqlDeclaration("hospitalization")]
    [CqlTag("description", "Hospitalization returns the total interval for admission to discharge for the given encounter, or for the admission of any immediately prior emergency department visit to the discharge of the given encounter.")]
	public CqlInterval<CqlDateTime> hospitalization(Encounter TheEncounter)
	{
		var a_ = this.edVisit(TheEncounter);
		var b_ = new Encounter[]
		{
			a_,
		};
		CqlInterval<CqlDateTime> c_(Encounter X)
		{
			CqlInterval<CqlDateTime> f_()
			{
				if ((X is null))
				{
					var g_ = TheEncounter?.Period;
					var h_ = FHIRHelpers_4_3_000.ToInterval(g_);

					return h_;
				}
				else
				{
					var i_ = X?.Period;
					var j_ = FHIRHelpers_4_3_000.ToInterval(i_);
					var k_ = context.Operators.Start(j_);
					var l_ = TheEncounter?.Period;
					var m_ = FHIRHelpers_4_3_000.ToInterval(l_);
					var n_ = context.Operators.End(m_);
					var o_ = context.Operators.Interval(k_, n_, true, true);

					return o_;
				}
			};

			return f_();
		};
		var d_ = context.Operators.Select<Encounter, CqlInterval<CqlDateTime>>((IEnumerable<Encounter>)b_, c_);
		var e_ = context.Operators.SingletonFrom<CqlInterval<CqlDateTime>>(d_);

		return e_;
	}

    [CqlDeclaration("Hospitalization Locations")]
    [CqlTag("description", "Returns list of all locations within an encounter, including locations for immediately prior ED visit.")]
    [CqlTag("deprecated", "This function is deprecated. Use the fluent function `hospitalizationLocations()` instead.")]
	public IEnumerable<Encounter.LocationComponent> Hospitalization_Locations(Encounter TheEncounter)
	{
		var a_ = this.ED_Visit(TheEncounter);
		var b_ = new Encounter[]
		{
			a_,
		};
		IEnumerable<Encounter.LocationComponent> c_(Encounter EDEncounter)
		{
			IEnumerable<Encounter.LocationComponent> f_()
			{
				if ((EDEncounter is null))
				{
					var g_ = TheEncounter?.Location;

					return (IEnumerable<Encounter.LocationComponent>)g_;
				}
				else
				{
					var h_ = EDEncounter?.Location;
					var i_ = TheEncounter?.Location;
					var j_ = new IEnumerable<Encounter.LocationComponent>[]
					{
						(IEnumerable<Encounter.LocationComponent>)h_,
						(IEnumerable<Encounter.LocationComponent>)i_,
					};
					var k_ = context.Operators.Flatten<Encounter.LocationComponent>((j_ as IEnumerable<IEnumerable<Encounter.LocationComponent>>));

					return k_;
				}
			};

			return f_();
		};
		var d_ = context.Operators.Select<Encounter, IEnumerable<Encounter.LocationComponent>>((IEnumerable<Encounter>)b_, c_);
		var e_ = context.Operators.SingletonFrom<IEnumerable<Encounter.LocationComponent>>(d_);

		return e_;
	}

    [CqlDeclaration("hospitalizationLocations")]
    [CqlTag("description", "Returns list of all locations within an encounter, including locations for immediately prior ED visit.")]
	public IEnumerable<Encounter.LocationComponent> hospitalizationLocations(Encounter TheEncounter)
	{
		var a_ = this.edVisit(TheEncounter);
		var b_ = new Encounter[]
		{
			a_,
		};
		IEnumerable<Encounter.LocationComponent> c_(Encounter EDEncounter)
		{
			IEnumerable<Encounter.LocationComponent> f_()
			{
				if ((EDEncounter is null))
				{
					var g_ = TheEncounter?.Location;

					return (IEnumerable<Encounter.LocationComponent>)g_;
				}
				else
				{
					var h_ = EDEncounter?.Location;
					var i_ = TheEncounter?.Location;
					var j_ = new IEnumerable<Encounter.LocationComponent>[]
					{
						(IEnumerable<Encounter.LocationComponent>)h_,
						(IEnumerable<Encounter.LocationComponent>)i_,
					};
					var k_ = context.Operators.Flatten<Encounter.LocationComponent>((j_ as IEnumerable<IEnumerable<Encounter.LocationComponent>>));

					return k_;
				}
			};

			return f_();
		};
		var d_ = context.Operators.Select<Encounter, IEnumerable<Encounter.LocationComponent>>((IEnumerable<Encounter>)b_, c_);
		var e_ = context.Operators.SingletonFrom<IEnumerable<Encounter.LocationComponent>>(d_);

		return e_;
	}

    [CqlDeclaration("Hospitalization Length of Stay")]
    [CqlTag("description", "Returns the length of stay in days (i.e. the number of days between admission and discharge) for the given encounter, or from the admission of any immediately prior emergency department visit to the discharge of the encounter")]
    [CqlTag("deprecated", "This function is deprecated. Use the fluent function `hospitalizationLengthOfStay()` instead.")]
	public int? Hospitalization_Length_of_Stay(Encounter TheEncounter)
	{
		var a_ = this.Hospitalization(TheEncounter);
		var b_ = this.LengthInDays(a_);

		return b_;
	}

    [CqlDeclaration("hospitalizationLengthOfStay")]
    [CqlTag("description", "Returns the length of stay in days (i.e. the number of days between admission and discharge) for the given encounter, or from the admission of any immediately prior emergency department visit to the discharge of the encounter")]
	public int? hospitalizationLengthOfStay(Encounter TheEncounter)
	{
		var a_ = this.hospitalization(TheEncounter);
		var b_ = this.lengthInDays(a_);

		return b_;
	}

    [CqlDeclaration("Hospital Admission Time")]
    [CqlTag("description", "Returns admission time for an encounter or for immediately prior emergency department visit.")]
    [CqlTag("deprecated", "This function is deprecated. Use the fluent function `hospitalAdmissionTime()` instead.")]
	public CqlDateTime Hospital_Admission_Time(Encounter TheEncounter)
	{
		var a_ = this.Hospitalization(TheEncounter);
		var b_ = context.Operators.Start(a_);

		return b_;
	}

    [CqlDeclaration("hospitalAdmissionTime")]
    [CqlTag("description", "Returns admission time for an encounter or for immediately prior emergency department visit.")]
	public CqlDateTime hospitalAdmissionTime(Encounter TheEncounter)
	{
		var a_ = this.hospitalization(TheEncounter);
		var b_ = context.Operators.Start(a_);

		return b_;
	}

    [CqlDeclaration("Hospital Discharge Time")]
    [CqlTag("description", "Hospital Discharge Time returns the discharge time for an encounter")]
    [CqlTag("deprecated", "This function is deprecated. Use the fluent function `hospitalDischargeTime()` instead.")]
	public CqlDateTime Hospital_Discharge_Time(Encounter TheEncounter)
	{
		var a_ = FHIRHelpers_4_3_000.ToInterval(TheEncounter?.Period);
		var b_ = context.Operators.End(a_);

		return b_;
	}

    [CqlDeclaration("hospitalDischargeTime")]
    [CqlTag("description", "Hospital Discharge Time returns the discharge time for an encounter")]
	public CqlDateTime hospitalDischargeTime(Encounter TheEncounter)
	{
		var a_ = FHIRHelpers_4_3_000.ToInterval(TheEncounter?.Period);
		var b_ = context.Operators.End(a_);

		return b_;
	}

    [CqlDeclaration("Hospital Arrival Time")]
    [CqlTag("description", "Returns earliest arrival time for an encounter including any prior ED visit.")]
    [CqlTag("deprecated", "This function is deprecated. Use the fluent function `hospitalArrivalTime()` instead.")]
	public CqlDateTime Hospital_Arrival_Time(Encounter TheEncounter)
	{
		var a_ = this.Hospitalization_Locations(TheEncounter);
		object b_(Encounter.LocationComponent @this)
		{
			var g_ = @this?.Period;
			var h_ = FHIRHelpers_4_3_000.ToInterval(g_);
			var i_ = context.Operators.Start(h_);

			return i_;
		};
		var c_ = context.Operators.SortBy<Encounter.LocationComponent>(a_, b_, System.ComponentModel.ListSortDirection.Ascending);
		var d_ = context.Operators.First<Encounter.LocationComponent>(c_);
		var e_ = FHIRHelpers_4_3_000.ToInterval(d_?.Period);
		var f_ = context.Operators.Start(e_);

		return f_;
	}

    [CqlDeclaration("hospitalArrivalTime")]
    [CqlTag("description", "Returns earliest arrival time for an encounter including any prior ED visit.")]
	public CqlDateTime hospitalArrivalTime(Encounter TheEncounter)
	{
		var a_ = this.hospitalizationLocations(TheEncounter);
		object b_(Encounter.LocationComponent @this)
		{
			var g_ = @this?.Period;
			var h_ = FHIRHelpers_4_3_000.ToInterval(g_);
			var i_ = context.Operators.Start(h_);

			return i_;
		};
		var c_ = context.Operators.SortBy<Encounter.LocationComponent>(a_, b_, System.ComponentModel.ListSortDirection.Ascending);
		var d_ = context.Operators.First<Encounter.LocationComponent>(c_);
		var e_ = FHIRHelpers_4_3_000.ToInterval(d_?.Period);
		var f_ = context.Operators.Start(e_);

		return f_;
	}

    [CqlDeclaration("Hospital Departure Time")]
    [CqlTag("description", "Returns the latest departure time for encounter including any prior ED visit.")]
    [CqlTag("deprecated", "This function is deprecated. Use the fluent function `hospitalDepartureTime()` instead.")]
	public CqlDateTime Hospital_Departure_Time(Encounter TheEncounter)
	{
		var a_ = this.Hospitalization_Locations(TheEncounter);
		object b_(Encounter.LocationComponent @this)
		{
			var g_ = @this?.Period;
			var h_ = FHIRHelpers_4_3_000.ToInterval(g_);
			var i_ = context.Operators.Start(h_);

			return i_;
		};
		var c_ = context.Operators.SortBy<Encounter.LocationComponent>(a_, b_, System.ComponentModel.ListSortDirection.Ascending);
		var d_ = context.Operators.Last<Encounter.LocationComponent>(c_);
		var e_ = FHIRHelpers_4_3_000.ToInterval(d_?.Period);
		var f_ = context.Operators.End(e_);

		return f_;
	}

    [CqlDeclaration("hospitalDepartureTime")]
    [CqlTag("description", "Returns the latest departure time for encounter including any prior ED visit.")]
	public CqlDateTime hospitalDepartureTime(Encounter TheEncounter)
	{
		var a_ = this.hospitalizationLocations(TheEncounter);
		object b_(Encounter.LocationComponent @this)
		{
			var g_ = @this?.Period;
			var h_ = FHIRHelpers_4_3_000.ToInterval(g_);
			var i_ = context.Operators.Start(h_);

			return i_;
		};
		var c_ = context.Operators.SortBy<Encounter.LocationComponent>(a_, b_, System.ComponentModel.ListSortDirection.Ascending);
		var d_ = context.Operators.Last<Encounter.LocationComponent>(c_);
		var e_ = FHIRHelpers_4_3_000.ToInterval(d_?.Period);
		var f_ = context.Operators.End(e_);

		return f_;
	}

    [CqlDeclaration("GetLocation")]
    [CqlTag("description", "Returns the Location resource specified by the given reference")]
    [CqlTag("deprecated", "This function is deprecated. Use the fluent function `getLocation()` instead.")]
	public Location GetLocation(ResourceReference reference)
	{
		var a_ = context.Operators.RetrieveByValueSet<Location>(null, null);
		bool? b_(Location L)
		{
			var e_ = L?.IdElement;
			var f_ = e_?.Value;
			var g_ = reference?.ReferenceElement;
			var h_ = g_?.Value;
			var i_ = QICoreCommon_2_0_000.getId(h_);
			var j_ = context.Operators.Equal(f_, i_);

			return j_;
		};
		var c_ = context.Operators.Where<Location>(a_, b_);
		var d_ = context.Operators.SingletonFrom<Location>(c_);

		return d_;
	}

    [CqlDeclaration("Emergency Department Arrival Time")]
    [CqlTag("description", "Returns the emergency department arrival time for the encounter.")]
	public CqlDateTime Emergency_Department_Arrival_Time(Encounter TheEncounter)
	{
		var a_ = this.Hospitalization_Locations(TheEncounter);
		bool? b_(Encounter.LocationComponent HospitalLocation)
		{
			var g_ = HospitalLocation?.Location;
			var h_ = this.GetLocation(g_);
			var i_ = h_?.Type;
			CqlConcept j_(CodeableConcept @this)
			{
				var n_ = FHIRHelpers_4_3_000.ToConcept(@this);

				return n_;
			};
			var k_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)i_, j_);
			var l_ = this.Emergency_Department_Visit();
			var m_ = context.Operators.ConceptsInValueSet(k_, l_);

			return m_;
		};
		var c_ = context.Operators.Where<Encounter.LocationComponent>(a_, b_);
		var d_ = context.Operators.SingletonFrom<Encounter.LocationComponent>(c_);
		var e_ = FHIRHelpers_4_3_000.ToInterval(d_?.Period);
		var f_ = context.Operators.Start(e_);

		return f_;
	}

    [CqlDeclaration("emergencyDepartmentArrivalTime")]
    [CqlTag("description", "Returns the emergency department arrival time for the encounter.")]
	public CqlDateTime emergencyDepartmentArrivalTime(Encounter TheEncounter)
	{
		var a_ = this.hospitalizationLocations(TheEncounter);
		bool? b_(Encounter.LocationComponent HospitalLocation)
		{
			var g_ = HospitalLocation?.Location;
			var h_ = this.GetLocation(g_);
			var i_ = h_?.Type;
			CqlConcept j_(CodeableConcept @this)
			{
				var n_ = FHIRHelpers_4_3_000.ToConcept(@this);

				return n_;
			};
			var k_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)i_, j_);
			var l_ = this.Emergency_Department_Visit();
			var m_ = context.Operators.ConceptsInValueSet(k_, l_);

			return m_;
		};
		var c_ = context.Operators.Where<Encounter.LocationComponent>(a_, b_);
		var d_ = context.Operators.SingletonFrom<Encounter.LocationComponent>(c_);
		var e_ = FHIRHelpers_4_3_000.ToInterval(d_?.Period);
		var f_ = context.Operators.Start(e_);

		return f_;
	}

    [CqlDeclaration("HospitalizationWithObservationAndOutpatientSurgeryService")]
    [CqlTag("description", "Hospitalization with Observation and Outpatient Surgery Service returns the total interval from the start of any immediately prior emergency department visit, outpatient surgery visit or observation visit to the discharge of the given encounter.")]
    [CqlTag("deprecated", "This function is deprecated. Use the fluent function `hospitalizationWithObservationAndOutpatientSurgeryService()` instead.")]
	public CqlInterval<CqlDateTime> HospitalizationWithObservationAndOutpatientSurgeryService(Encounter TheEncounter)
	{
		var a_ = new Encounter[]
		{
			TheEncounter,
		};
		CqlInterval<CqlDateTime> b_(Encounter Visit)
		{
			var e_ = this.Outpatient_Surgery_Service();
			var f_ = context.Operators.RetrieveByValueSet<Encounter>(e_, null);
			bool? g_(Encounter LastSurgeryOP)
			{
				var ap_ = LastSurgeryOP?.Period;
				var aq_ = FHIRHelpers_4_3_000.ToInterval(ap_);
				var ar_ = context.Operators.End(aq_);
				var as_ = this.Emergency_Department_Visit();
				var at_ = context.Operators.RetrieveByValueSet<Encounter>(as_, null);
				bool? au_(Encounter LastED)
				{
					var dp_ = LastED?.StatusElement;
					var dq_ = dp_?.Value;
					var dr_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(dq_);
					var ds_ = context.Operators.Equal(dr_, "finished");
					var dt_ = LastED?.Period;
					var du_ = FHIRHelpers_4_3_000.ToInterval(dt_);
					var dv_ = context.Operators.End(du_);
					var dw_ = this.Observation_Services();
					var dx_ = context.Operators.RetrieveByValueSet<Encounter>(dw_, null);
					bool? dy_(Encounter LastObs)
					{
						var fq_ = LastObs?.StatusElement;
						var fr_ = fq_?.Value;
						var fs_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(fr_);
						var ft_ = context.Operators.Equal(fs_, "finished");
						var fu_ = LastObs?.Period;
						var fv_ = FHIRHelpers_4_3_000.ToInterval(fu_);
						var fw_ = context.Operators.End(fv_);
						var fx_ = Visit?.Period;
						var fy_ = FHIRHelpers_4_3_000.ToInterval(fx_);
						var fz_ = context.Operators.Start(fy_);
						var ga_ = context.Operators.Quantity(1m, "hour");
						var gb_ = context.Operators.Subtract(fz_, ga_);
						var gd_ = FHIRHelpers_4_3_000.ToInterval(fx_);
						var ge_ = context.Operators.Start(gd_);
						var gf_ = context.Operators.Interval(gb_, ge_, true, true);
						var gg_ = context.Operators.In<CqlDateTime>(fw_, gf_, null);
						var gi_ = FHIRHelpers_4_3_000.ToInterval(fx_);
						var gj_ = context.Operators.Start(gi_);
						var gk_ = context.Operators.Not((bool?)(gj_ is null));
						var gl_ = context.Operators.And(gg_, gk_);
						var gm_ = context.Operators.And(ft_, gl_);

						return gm_;
					};
					var dz_ = context.Operators.Where<Encounter>(dx_, dy_);
					object ea_(Encounter @this)
					{
						var gn_ = @this?.Period;
						var go_ = FHIRHelpers_4_3_000.ToInterval(gn_);
						var gp_ = context.Operators.End(go_);

						return gp_;
					};
					var eb_ = context.Operators.SortBy<Encounter>(dz_, ea_, System.ComponentModel.ListSortDirection.Ascending);
					var ec_ = context.Operators.Last<Encounter>(eb_);
					var ed_ = ec_?.Period;
					var ee_ = FHIRHelpers_4_3_000.ToInterval(ed_);
					var ef_ = context.Operators.Start(ee_);
					var eg_ = Visit?.Period;
					var eh_ = FHIRHelpers_4_3_000.ToInterval(eg_);
					var ei_ = context.Operators.Start(eh_);
					var ej_ = context.Operators.Quantity(1m, "hour");
					var ek_ = context.Operators.Subtract((ef_ ?? ei_), ej_);
					var em_ = context.Operators.RetrieveByValueSet<Encounter>(dw_, null);
					bool? en_(Encounter LastObs)
					{
						var gq_ = LastObs?.StatusElement;
						var gr_ = gq_?.Value;
						var gs_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(gr_);
						var gt_ = context.Operators.Equal(gs_, "finished");
						var gu_ = LastObs?.Period;
						var gv_ = FHIRHelpers_4_3_000.ToInterval(gu_);
						var gw_ = context.Operators.End(gv_);
						var gx_ = Visit?.Period;
						var gy_ = FHIRHelpers_4_3_000.ToInterval(gx_);
						var gz_ = context.Operators.Start(gy_);
						var ha_ = context.Operators.Quantity(1m, "hour");
						var hb_ = context.Operators.Subtract(gz_, ha_);
						var hd_ = FHIRHelpers_4_3_000.ToInterval(gx_);
						var he_ = context.Operators.Start(hd_);
						var hf_ = context.Operators.Interval(hb_, he_, true, true);
						var hg_ = context.Operators.In<CqlDateTime>(gw_, hf_, null);
						var hi_ = FHIRHelpers_4_3_000.ToInterval(gx_);
						var hj_ = context.Operators.Start(hi_);
						var hk_ = context.Operators.Not((bool?)(hj_ is null));
						var hl_ = context.Operators.And(hg_, hk_);
						var hm_ = context.Operators.And(gt_, hl_);

						return hm_;
					};
					var eo_ = context.Operators.Where<Encounter>(em_, en_);
					object ep_(Encounter @this)
					{
						var hn_ = @this?.Period;
						var ho_ = FHIRHelpers_4_3_000.ToInterval(hn_);
						var hp_ = context.Operators.End(ho_);

						return hp_;
					};
					var eq_ = context.Operators.SortBy<Encounter>(eo_, ep_, System.ComponentModel.ListSortDirection.Ascending);
					var er_ = context.Operators.Last<Encounter>(eq_);
					var es_ = er_?.Period;
					var et_ = FHIRHelpers_4_3_000.ToInterval(es_);
					var eu_ = context.Operators.Start(et_);
					var ew_ = FHIRHelpers_4_3_000.ToInterval(eg_);
					var ex_ = context.Operators.Start(ew_);
					var ey_ = context.Operators.Interval(ek_, (eu_ ?? ex_), true, true);
					var ez_ = context.Operators.In<CqlDateTime>(dv_, ey_, null);
					var fb_ = context.Operators.RetrieveByValueSet<Encounter>(dw_, null);
					bool? fc_(Encounter LastObs)
					{
						var hq_ = LastObs?.StatusElement;
						var hr_ = hq_?.Value;
						var hs_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(hr_);
						var ht_ = context.Operators.Equal(hs_, "finished");
						var hu_ = LastObs?.Period;
						var hv_ = FHIRHelpers_4_3_000.ToInterval(hu_);
						var hw_ = context.Operators.End(hv_);
						var hx_ = Visit?.Period;
						var hy_ = FHIRHelpers_4_3_000.ToInterval(hx_);
						var hz_ = context.Operators.Start(hy_);
						var ia_ = context.Operators.Quantity(1m, "hour");
						var ib_ = context.Operators.Subtract(hz_, ia_);
						var id_ = FHIRHelpers_4_3_000.ToInterval(hx_);
						var ie_ = context.Operators.Start(id_);
						var if_ = context.Operators.Interval(ib_, ie_, true, true);
						var ig_ = context.Operators.In<CqlDateTime>(hw_, if_, null);
						var ii_ = FHIRHelpers_4_3_000.ToInterval(hx_);
						var ij_ = context.Operators.Start(ii_);
						var ik_ = context.Operators.Not((bool?)(ij_ is null));
						var il_ = context.Operators.And(ig_, ik_);
						var im_ = context.Operators.And(ht_, il_);

						return im_;
					};
					var fd_ = context.Operators.Where<Encounter>(fb_, fc_);
					object fe_(Encounter @this)
					{
						var in_ = @this?.Period;
						var io_ = FHIRHelpers_4_3_000.ToInterval(in_);
						var ip_ = context.Operators.End(io_);

						return ip_;
					};
					var ff_ = context.Operators.SortBy<Encounter>(fd_, fe_, System.ComponentModel.ListSortDirection.Ascending);
					var fg_ = context.Operators.Last<Encounter>(ff_);
					var fh_ = fg_?.Period;
					var fi_ = FHIRHelpers_4_3_000.ToInterval(fh_);
					var fj_ = context.Operators.Start(fi_);
					var fl_ = FHIRHelpers_4_3_000.ToInterval(eg_);
					var fm_ = context.Operators.Start(fl_);
					var fn_ = context.Operators.Not((bool?)((fj_ ?? fm_) is null));
					var fo_ = context.Operators.And(ez_, fn_);
					var fp_ = context.Operators.And(ds_, fo_);

					return fp_;
				};
				var av_ = context.Operators.Where<Encounter>(at_, au_);
				object aw_(Encounter @this)
				{
					var iq_ = @this?.Period;
					var ir_ = FHIRHelpers_4_3_000.ToInterval(iq_);
					var is_ = context.Operators.End(ir_);

					return is_;
				};
				var ax_ = context.Operators.SortBy<Encounter>(av_, aw_, System.ComponentModel.ListSortDirection.Ascending);
				var ay_ = context.Operators.Last<Encounter>(ax_);
				var az_ = ay_?.Period;
				var ba_ = FHIRHelpers_4_3_000.ToInterval(az_);
				var bb_ = context.Operators.Start(ba_);
				var bc_ = this.Observation_Services();
				var bd_ = context.Operators.RetrieveByValueSet<Encounter>(bc_, null);
				bool? be_(Encounter LastObs)
				{
					var it_ = LastObs?.StatusElement;
					var iu_ = it_?.Value;
					var iv_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(iu_);
					var iw_ = context.Operators.Equal(iv_, "finished");
					var ix_ = LastObs?.Period;
					var iy_ = FHIRHelpers_4_3_000.ToInterval(ix_);
					var iz_ = context.Operators.End(iy_);
					var ja_ = Visit?.Period;
					var jb_ = FHIRHelpers_4_3_000.ToInterval(ja_);
					var jc_ = context.Operators.Start(jb_);
					var jd_ = context.Operators.Quantity(1m, "hour");
					var je_ = context.Operators.Subtract(jc_, jd_);
					var jg_ = FHIRHelpers_4_3_000.ToInterval(ja_);
					var jh_ = context.Operators.Start(jg_);
					var ji_ = context.Operators.Interval(je_, jh_, true, true);
					var jj_ = context.Operators.In<CqlDateTime>(iz_, ji_, null);
					var jl_ = FHIRHelpers_4_3_000.ToInterval(ja_);
					var jm_ = context.Operators.Start(jl_);
					var jn_ = context.Operators.Not((bool?)(jm_ is null));
					var jo_ = context.Operators.And(jj_, jn_);
					var jp_ = context.Operators.And(iw_, jo_);

					return jp_;
				};
				var bf_ = context.Operators.Where<Encounter>(bd_, be_);
				object bg_(Encounter @this)
				{
					var jq_ = @this?.Period;
					var jr_ = FHIRHelpers_4_3_000.ToInterval(jq_);
					var js_ = context.Operators.End(jr_);

					return js_;
				};
				var bh_ = context.Operators.SortBy<Encounter>(bf_, bg_, System.ComponentModel.ListSortDirection.Ascending);
				var bi_ = context.Operators.Last<Encounter>(bh_);
				var bj_ = bi_?.Period;
				var bk_ = FHIRHelpers_4_3_000.ToInterval(bj_);
				var bl_ = context.Operators.Start(bk_);
				var bm_ = Visit?.Period;
				var bn_ = FHIRHelpers_4_3_000.ToInterval(bm_);
				var bo_ = context.Operators.Start(bn_);
				var bp_ = context.Operators.Quantity(1m, "hour");
				var bq_ = context.Operators.Subtract((bb_ ?? (bl_ ?? bo_)), bp_);
				var bs_ = context.Operators.RetrieveByValueSet<Encounter>(as_, null);
				bool? bt_(Encounter LastED)
				{
					var jt_ = LastED?.StatusElement;
					var ju_ = jt_?.Value;
					var jv_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(ju_);
					var jw_ = context.Operators.Equal(jv_, "finished");
					var jx_ = LastED?.Period;
					var jy_ = FHIRHelpers_4_3_000.ToInterval(jx_);
					var jz_ = context.Operators.End(jy_);
					var ka_ = this.Observation_Services();
					var kb_ = context.Operators.RetrieveByValueSet<Encounter>(ka_, null);
					bool? kc_(Encounter LastObs)
					{
						var lu_ = LastObs?.StatusElement;
						var lv_ = lu_?.Value;
						var lw_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(lv_);
						var lx_ = context.Operators.Equal(lw_, "finished");
						var ly_ = LastObs?.Period;
						var lz_ = FHIRHelpers_4_3_000.ToInterval(ly_);
						var ma_ = context.Operators.End(lz_);
						var mb_ = Visit?.Period;
						var mc_ = FHIRHelpers_4_3_000.ToInterval(mb_);
						var md_ = context.Operators.Start(mc_);
						var me_ = context.Operators.Quantity(1m, "hour");
						var mf_ = context.Operators.Subtract(md_, me_);
						var mh_ = FHIRHelpers_4_3_000.ToInterval(mb_);
						var mi_ = context.Operators.Start(mh_);
						var mj_ = context.Operators.Interval(mf_, mi_, true, true);
						var mk_ = context.Operators.In<CqlDateTime>(ma_, mj_, null);
						var mm_ = FHIRHelpers_4_3_000.ToInterval(mb_);
						var mn_ = context.Operators.Start(mm_);
						var mo_ = context.Operators.Not((bool?)(mn_ is null));
						var mp_ = context.Operators.And(mk_, mo_);
						var mq_ = context.Operators.And(lx_, mp_);

						return mq_;
					};
					var kd_ = context.Operators.Where<Encounter>(kb_, kc_);
					object ke_(Encounter @this)
					{
						var mr_ = @this?.Period;
						var ms_ = FHIRHelpers_4_3_000.ToInterval(mr_);
						var mt_ = context.Operators.End(ms_);

						return mt_;
					};
					var kf_ = context.Operators.SortBy<Encounter>(kd_, ke_, System.ComponentModel.ListSortDirection.Ascending);
					var kg_ = context.Operators.Last<Encounter>(kf_);
					var kh_ = kg_?.Period;
					var ki_ = FHIRHelpers_4_3_000.ToInterval(kh_);
					var kj_ = context.Operators.Start(ki_);
					var kk_ = Visit?.Period;
					var kl_ = FHIRHelpers_4_3_000.ToInterval(kk_);
					var km_ = context.Operators.Start(kl_);
					var kn_ = context.Operators.Quantity(1m, "hour");
					var ko_ = context.Operators.Subtract((kj_ ?? km_), kn_);
					var kq_ = context.Operators.RetrieveByValueSet<Encounter>(ka_, null);
					bool? kr_(Encounter LastObs)
					{
						var mu_ = LastObs?.StatusElement;
						var mv_ = mu_?.Value;
						var mw_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(mv_);
						var mx_ = context.Operators.Equal(mw_, "finished");
						var my_ = LastObs?.Period;
						var mz_ = FHIRHelpers_4_3_000.ToInterval(my_);
						var na_ = context.Operators.End(mz_);
						var nb_ = Visit?.Period;
						var nc_ = FHIRHelpers_4_3_000.ToInterval(nb_);
						var nd_ = context.Operators.Start(nc_);
						var ne_ = context.Operators.Quantity(1m, "hour");
						var nf_ = context.Operators.Subtract(nd_, ne_);
						var nh_ = FHIRHelpers_4_3_000.ToInterval(nb_);
						var ni_ = context.Operators.Start(nh_);
						var nj_ = context.Operators.Interval(nf_, ni_, true, true);
						var nk_ = context.Operators.In<CqlDateTime>(na_, nj_, null);
						var nm_ = FHIRHelpers_4_3_000.ToInterval(nb_);
						var nn_ = context.Operators.Start(nm_);
						var no_ = context.Operators.Not((bool?)(nn_ is null));
						var np_ = context.Operators.And(nk_, no_);
						var nq_ = context.Operators.And(mx_, np_);

						return nq_;
					};
					var ks_ = context.Operators.Where<Encounter>(kq_, kr_);
					object kt_(Encounter @this)
					{
						var nr_ = @this?.Period;
						var ns_ = FHIRHelpers_4_3_000.ToInterval(nr_);
						var nt_ = context.Operators.End(ns_);

						return nt_;
					};
					var ku_ = context.Operators.SortBy<Encounter>(ks_, kt_, System.ComponentModel.ListSortDirection.Ascending);
					var kv_ = context.Operators.Last<Encounter>(ku_);
					var kw_ = kv_?.Period;
					var kx_ = FHIRHelpers_4_3_000.ToInterval(kw_);
					var ky_ = context.Operators.Start(kx_);
					var la_ = FHIRHelpers_4_3_000.ToInterval(kk_);
					var lb_ = context.Operators.Start(la_);
					var lc_ = context.Operators.Interval(ko_, (ky_ ?? lb_), true, true);
					var ld_ = context.Operators.In<CqlDateTime>(jz_, lc_, null);
					var lf_ = context.Operators.RetrieveByValueSet<Encounter>(ka_, null);
					bool? lg_(Encounter LastObs)
					{
						var nu_ = LastObs?.StatusElement;
						var nv_ = nu_?.Value;
						var nw_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(nv_);
						var nx_ = context.Operators.Equal(nw_, "finished");
						var ny_ = LastObs?.Period;
						var nz_ = FHIRHelpers_4_3_000.ToInterval(ny_);
						var oa_ = context.Operators.End(nz_);
						var ob_ = Visit?.Period;
						var oc_ = FHIRHelpers_4_3_000.ToInterval(ob_);
						var od_ = context.Operators.Start(oc_);
						var oe_ = context.Operators.Quantity(1m, "hour");
						var of_ = context.Operators.Subtract(od_, oe_);
						var oh_ = FHIRHelpers_4_3_000.ToInterval(ob_);
						var oi_ = context.Operators.Start(oh_);
						var oj_ = context.Operators.Interval(of_, oi_, true, true);
						var ok_ = context.Operators.In<CqlDateTime>(oa_, oj_, null);
						var om_ = FHIRHelpers_4_3_000.ToInterval(ob_);
						var on_ = context.Operators.Start(om_);
						var oo_ = context.Operators.Not((bool?)(on_ is null));
						var op_ = context.Operators.And(ok_, oo_);
						var oq_ = context.Operators.And(nx_, op_);

						return oq_;
					};
					var lh_ = context.Operators.Where<Encounter>(lf_, lg_);
					object li_(Encounter @this)
					{
						var or_ = @this?.Period;
						var os_ = FHIRHelpers_4_3_000.ToInterval(or_);
						var ot_ = context.Operators.End(os_);

						return ot_;
					};
					var lj_ = context.Operators.SortBy<Encounter>(lh_, li_, System.ComponentModel.ListSortDirection.Ascending);
					var lk_ = context.Operators.Last<Encounter>(lj_);
					var ll_ = lk_?.Period;
					var lm_ = FHIRHelpers_4_3_000.ToInterval(ll_);
					var ln_ = context.Operators.Start(lm_);
					var lp_ = FHIRHelpers_4_3_000.ToInterval(kk_);
					var lq_ = context.Operators.Start(lp_);
					var lr_ = context.Operators.Not((bool?)((ln_ ?? lq_) is null));
					var ls_ = context.Operators.And(ld_, lr_);
					var lt_ = context.Operators.And(jw_, ls_);

					return lt_;
				};
				var bu_ = context.Operators.Where<Encounter>(bs_, bt_);
				object bv_(Encounter @this)
				{
					var ou_ = @this?.Period;
					var ov_ = FHIRHelpers_4_3_000.ToInterval(ou_);
					var ow_ = context.Operators.End(ov_);

					return ow_;
				};
				var bw_ = context.Operators.SortBy<Encounter>(bu_, bv_, System.ComponentModel.ListSortDirection.Ascending);
				var bx_ = context.Operators.Last<Encounter>(bw_);
				var by_ = bx_?.Period;
				var bz_ = FHIRHelpers_4_3_000.ToInterval(by_);
				var ca_ = context.Operators.Start(bz_);
				var cc_ = context.Operators.RetrieveByValueSet<Encounter>(bc_, null);
				bool? cd_(Encounter LastObs)
				{
					var ox_ = LastObs?.StatusElement;
					var oy_ = ox_?.Value;
					var oz_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(oy_);
					var pa_ = context.Operators.Equal(oz_, "finished");
					var pb_ = LastObs?.Period;
					var pc_ = FHIRHelpers_4_3_000.ToInterval(pb_);
					var pd_ = context.Operators.End(pc_);
					var pe_ = Visit?.Period;
					var pf_ = FHIRHelpers_4_3_000.ToInterval(pe_);
					var pg_ = context.Operators.Start(pf_);
					var ph_ = context.Operators.Quantity(1m, "hour");
					var pi_ = context.Operators.Subtract(pg_, ph_);
					var pk_ = FHIRHelpers_4_3_000.ToInterval(pe_);
					var pl_ = context.Operators.Start(pk_);
					var pm_ = context.Operators.Interval(pi_, pl_, true, true);
					var pn_ = context.Operators.In<CqlDateTime>(pd_, pm_, null);
					var pp_ = FHIRHelpers_4_3_000.ToInterval(pe_);
					var pq_ = context.Operators.Start(pp_);
					var pr_ = context.Operators.Not((bool?)(pq_ is null));
					var ps_ = context.Operators.And(pn_, pr_);
					var pt_ = context.Operators.And(pa_, ps_);

					return pt_;
				};
				var ce_ = context.Operators.Where<Encounter>(cc_, cd_);
				object cf_(Encounter @this)
				{
					var pu_ = @this?.Period;
					var pv_ = FHIRHelpers_4_3_000.ToInterval(pu_);
					var pw_ = context.Operators.End(pv_);

					return pw_;
				};
				var cg_ = context.Operators.SortBy<Encounter>(ce_, cf_, System.ComponentModel.ListSortDirection.Ascending);
				var ch_ = context.Operators.Last<Encounter>(cg_);
				var ci_ = ch_?.Period;
				var cj_ = FHIRHelpers_4_3_000.ToInterval(ci_);
				var ck_ = context.Operators.Start(cj_);
				var cm_ = FHIRHelpers_4_3_000.ToInterval(bm_);
				var cn_ = context.Operators.Start(cm_);
				var co_ = context.Operators.Interval(bq_, (ca_ ?? (ck_ ?? cn_)), true, true);
				var cp_ = context.Operators.In<CqlDateTime>(ar_, co_, null);
				var cr_ = context.Operators.RetrieveByValueSet<Encounter>(as_, null);
				bool? cs_(Encounter LastED)
				{
					var px_ = LastED?.StatusElement;
					var py_ = px_?.Value;
					var pz_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(py_);
					var qa_ = context.Operators.Equal(pz_, "finished");
					var qb_ = LastED?.Period;
					var qc_ = FHIRHelpers_4_3_000.ToInterval(qb_);
					var qd_ = context.Operators.End(qc_);
					var qe_ = this.Observation_Services();
					var qf_ = context.Operators.RetrieveByValueSet<Encounter>(qe_, null);
					bool? qg_(Encounter LastObs)
					{
						var ry_ = LastObs?.StatusElement;
						var rz_ = ry_?.Value;
						var sa_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(rz_);
						var sb_ = context.Operators.Equal(sa_, "finished");
						var sc_ = LastObs?.Period;
						var sd_ = FHIRHelpers_4_3_000.ToInterval(sc_);
						var se_ = context.Operators.End(sd_);
						var sf_ = Visit?.Period;
						var sg_ = FHIRHelpers_4_3_000.ToInterval(sf_);
						var sh_ = context.Operators.Start(sg_);
						var si_ = context.Operators.Quantity(1m, "hour");
						var sj_ = context.Operators.Subtract(sh_, si_);
						var sl_ = FHIRHelpers_4_3_000.ToInterval(sf_);
						var sm_ = context.Operators.Start(sl_);
						var sn_ = context.Operators.Interval(sj_, sm_, true, true);
						var so_ = context.Operators.In<CqlDateTime>(se_, sn_, null);
						var sq_ = FHIRHelpers_4_3_000.ToInterval(sf_);
						var sr_ = context.Operators.Start(sq_);
						var ss_ = context.Operators.Not((bool?)(sr_ is null));
						var st_ = context.Operators.And(so_, ss_);
						var su_ = context.Operators.And(sb_, st_);

						return su_;
					};
					var qh_ = context.Operators.Where<Encounter>(qf_, qg_);
					object qi_(Encounter @this)
					{
						var sv_ = @this?.Period;
						var sw_ = FHIRHelpers_4_3_000.ToInterval(sv_);
						var sx_ = context.Operators.End(sw_);

						return sx_;
					};
					var qj_ = context.Operators.SortBy<Encounter>(qh_, qi_, System.ComponentModel.ListSortDirection.Ascending);
					var qk_ = context.Operators.Last<Encounter>(qj_);
					var ql_ = qk_?.Period;
					var qm_ = FHIRHelpers_4_3_000.ToInterval(ql_);
					var qn_ = context.Operators.Start(qm_);
					var qo_ = Visit?.Period;
					var qp_ = FHIRHelpers_4_3_000.ToInterval(qo_);
					var qq_ = context.Operators.Start(qp_);
					var qr_ = context.Operators.Quantity(1m, "hour");
					var qs_ = context.Operators.Subtract((qn_ ?? qq_), qr_);
					var qu_ = context.Operators.RetrieveByValueSet<Encounter>(qe_, null);
					bool? qv_(Encounter LastObs)
					{
						var sy_ = LastObs?.StatusElement;
						var sz_ = sy_?.Value;
						var ta_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(sz_);
						var tb_ = context.Operators.Equal(ta_, "finished");
						var tc_ = LastObs?.Period;
						var td_ = FHIRHelpers_4_3_000.ToInterval(tc_);
						var te_ = context.Operators.End(td_);
						var tf_ = Visit?.Period;
						var tg_ = FHIRHelpers_4_3_000.ToInterval(tf_);
						var th_ = context.Operators.Start(tg_);
						var ti_ = context.Operators.Quantity(1m, "hour");
						var tj_ = context.Operators.Subtract(th_, ti_);
						var tl_ = FHIRHelpers_4_3_000.ToInterval(tf_);
						var tm_ = context.Operators.Start(tl_);
						var tn_ = context.Operators.Interval(tj_, tm_, true, true);
						var to_ = context.Operators.In<CqlDateTime>(te_, tn_, null);
						var tq_ = FHIRHelpers_4_3_000.ToInterval(tf_);
						var tr_ = context.Operators.Start(tq_);
						var ts_ = context.Operators.Not((bool?)(tr_ is null));
						var tt_ = context.Operators.And(to_, ts_);
						var tu_ = context.Operators.And(tb_, tt_);

						return tu_;
					};
					var qw_ = context.Operators.Where<Encounter>(qu_, qv_);
					object qx_(Encounter @this)
					{
						var tv_ = @this?.Period;
						var tw_ = FHIRHelpers_4_3_000.ToInterval(tv_);
						var tx_ = context.Operators.End(tw_);

						return tx_;
					};
					var qy_ = context.Operators.SortBy<Encounter>(qw_, qx_, System.ComponentModel.ListSortDirection.Ascending);
					var qz_ = context.Operators.Last<Encounter>(qy_);
					var ra_ = qz_?.Period;
					var rb_ = FHIRHelpers_4_3_000.ToInterval(ra_);
					var rc_ = context.Operators.Start(rb_);
					var re_ = FHIRHelpers_4_3_000.ToInterval(qo_);
					var rf_ = context.Operators.Start(re_);
					var rg_ = context.Operators.Interval(qs_, (rc_ ?? rf_), true, true);
					var rh_ = context.Operators.In<CqlDateTime>(qd_, rg_, null);
					var rj_ = context.Operators.RetrieveByValueSet<Encounter>(qe_, null);
					bool? rk_(Encounter LastObs)
					{
						var ty_ = LastObs?.StatusElement;
						var tz_ = ty_?.Value;
						var ua_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(tz_);
						var ub_ = context.Operators.Equal(ua_, "finished");
						var uc_ = LastObs?.Period;
						var ud_ = FHIRHelpers_4_3_000.ToInterval(uc_);
						var ue_ = context.Operators.End(ud_);
						var uf_ = Visit?.Period;
						var ug_ = FHIRHelpers_4_3_000.ToInterval(uf_);
						var uh_ = context.Operators.Start(ug_);
						var ui_ = context.Operators.Quantity(1m, "hour");
						var uj_ = context.Operators.Subtract(uh_, ui_);
						var ul_ = FHIRHelpers_4_3_000.ToInterval(uf_);
						var um_ = context.Operators.Start(ul_);
						var un_ = context.Operators.Interval(uj_, um_, true, true);
						var uo_ = context.Operators.In<CqlDateTime>(ue_, un_, null);
						var uq_ = FHIRHelpers_4_3_000.ToInterval(uf_);
						var ur_ = context.Operators.Start(uq_);
						var us_ = context.Operators.Not((bool?)(ur_ is null));
						var ut_ = context.Operators.And(uo_, us_);
						var uu_ = context.Operators.And(ub_, ut_);

						return uu_;
					};
					var rl_ = context.Operators.Where<Encounter>(rj_, rk_);
					object rm_(Encounter @this)
					{
						var uv_ = @this?.Period;
						var uw_ = FHIRHelpers_4_3_000.ToInterval(uv_);
						var ux_ = context.Operators.End(uw_);

						return ux_;
					};
					var rn_ = context.Operators.SortBy<Encounter>(rl_, rm_, System.ComponentModel.ListSortDirection.Ascending);
					var ro_ = context.Operators.Last<Encounter>(rn_);
					var rp_ = ro_?.Period;
					var rq_ = FHIRHelpers_4_3_000.ToInterval(rp_);
					var rr_ = context.Operators.Start(rq_);
					var rt_ = FHIRHelpers_4_3_000.ToInterval(qo_);
					var ru_ = context.Operators.Start(rt_);
					var rv_ = context.Operators.Not((bool?)((rr_ ?? ru_) is null));
					var rw_ = context.Operators.And(rh_, rv_);
					var rx_ = context.Operators.And(qa_, rw_);

					return rx_;
				};
				var ct_ = context.Operators.Where<Encounter>(cr_, cs_);
				object cu_(Encounter @this)
				{
					var uy_ = @this?.Period;
					var uz_ = FHIRHelpers_4_3_000.ToInterval(uy_);
					var va_ = context.Operators.End(uz_);

					return va_;
				};
				var cv_ = context.Operators.SortBy<Encounter>(ct_, cu_, System.ComponentModel.ListSortDirection.Ascending);
				var cw_ = context.Operators.Last<Encounter>(cv_);
				var cx_ = cw_?.Period;
				var cy_ = FHIRHelpers_4_3_000.ToInterval(cx_);
				var cz_ = context.Operators.Start(cy_);
				var db_ = context.Operators.RetrieveByValueSet<Encounter>(bc_, null);
				bool? dc_(Encounter LastObs)
				{
					var vb_ = LastObs?.StatusElement;
					var vc_ = vb_?.Value;
					var vd_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(vc_);
					var ve_ = context.Operators.Equal(vd_, "finished");
					var vf_ = LastObs?.Period;
					var vg_ = FHIRHelpers_4_3_000.ToInterval(vf_);
					var vh_ = context.Operators.End(vg_);
					var vi_ = Visit?.Period;
					var vj_ = FHIRHelpers_4_3_000.ToInterval(vi_);
					var vk_ = context.Operators.Start(vj_);
					var vl_ = context.Operators.Quantity(1m, "hour");
					var vm_ = context.Operators.Subtract(vk_, vl_);
					var vo_ = FHIRHelpers_4_3_000.ToInterval(vi_);
					var vp_ = context.Operators.Start(vo_);
					var vq_ = context.Operators.Interval(vm_, vp_, true, true);
					var vr_ = context.Operators.In<CqlDateTime>(vh_, vq_, null);
					var vt_ = FHIRHelpers_4_3_000.ToInterval(vi_);
					var vu_ = context.Operators.Start(vt_);
					var vv_ = context.Operators.Not((bool?)(vu_ is null));
					var vw_ = context.Operators.And(vr_, vv_);
					var vx_ = context.Operators.And(ve_, vw_);

					return vx_;
				};
				var dd_ = context.Operators.Where<Encounter>(db_, dc_);
				object de_(Encounter @this)
				{
					var vy_ = @this?.Period;
					var vz_ = FHIRHelpers_4_3_000.ToInterval(vy_);
					var wa_ = context.Operators.End(vz_);

					return wa_;
				};
				var df_ = context.Operators.SortBy<Encounter>(dd_, de_, System.ComponentModel.ListSortDirection.Ascending);
				var dg_ = context.Operators.Last<Encounter>(df_);
				var dh_ = dg_?.Period;
				var di_ = FHIRHelpers_4_3_000.ToInterval(dh_);
				var dj_ = context.Operators.Start(di_);
				var dl_ = FHIRHelpers_4_3_000.ToInterval(bm_);
				var dm_ = context.Operators.Start(dl_);
				var dn_ = context.Operators.Not((bool?)((cz_ ?? (dj_ ?? dm_)) is null));
				var do_ = context.Operators.And(cp_, dn_);

				return do_;
			};
			var h_ = context.Operators.Where<Encounter>(f_, g_);
			object i_(Encounter @this)
			{
				var wb_ = @this?.Period;
				var wc_ = FHIRHelpers_4_3_000.ToInterval(wb_);
				var wd_ = context.Operators.End(wc_);

				return wd_;
			};
			var j_ = context.Operators.SortBy<Encounter>(h_, i_, System.ComponentModel.ListSortDirection.Ascending);
			var k_ = context.Operators.Last<Encounter>(j_);
			var l_ = k_?.Period;
			var m_ = FHIRHelpers_4_3_000.ToInterval(l_);
			var n_ = context.Operators.Start(m_);
			var o_ = this.Emergency_Department_Visit();
			var p_ = context.Operators.RetrieveByValueSet<Encounter>(o_, null);
			bool? q_(Encounter LastED)
			{
				var we_ = LastED?.StatusElement;
				var wf_ = we_?.Value;
				var wg_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(wf_);
				var wh_ = context.Operators.Equal(wg_, "finished");
				var wi_ = LastED?.Period;
				var wj_ = FHIRHelpers_4_3_000.ToInterval(wi_);
				var wk_ = context.Operators.End(wj_);
				var wl_ = this.Observation_Services();
				var wm_ = context.Operators.RetrieveByValueSet<Encounter>(wl_, null);
				bool? wn_(Encounter LastObs)
				{
					var yf_ = LastObs?.StatusElement;
					var yg_ = yf_?.Value;
					var yh_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(yg_);
					var yi_ = context.Operators.Equal(yh_, "finished");
					var yj_ = LastObs?.Period;
					var yk_ = FHIRHelpers_4_3_000.ToInterval(yj_);
					var yl_ = context.Operators.End(yk_);
					var ym_ = Visit?.Period;
					var yn_ = FHIRHelpers_4_3_000.ToInterval(ym_);
					var yo_ = context.Operators.Start(yn_);
					var yp_ = context.Operators.Quantity(1m, "hour");
					var yq_ = context.Operators.Subtract(yo_, yp_);
					var ys_ = FHIRHelpers_4_3_000.ToInterval(ym_);
					var yt_ = context.Operators.Start(ys_);
					var yu_ = context.Operators.Interval(yq_, yt_, true, true);
					var yv_ = context.Operators.In<CqlDateTime>(yl_, yu_, null);
					var yx_ = FHIRHelpers_4_3_000.ToInterval(ym_);
					var yy_ = context.Operators.Start(yx_);
					var yz_ = context.Operators.Not((bool?)(yy_ is null));
					var za_ = context.Operators.And(yv_, yz_);
					var zb_ = context.Operators.And(yi_, za_);

					return zb_;
				};
				var wo_ = context.Operators.Where<Encounter>(wm_, wn_);
				object wp_(Encounter @this)
				{
					var zc_ = @this?.Period;
					var zd_ = FHIRHelpers_4_3_000.ToInterval(zc_);
					var ze_ = context.Operators.End(zd_);

					return ze_;
				};
				var wq_ = context.Operators.SortBy<Encounter>(wo_, wp_, System.ComponentModel.ListSortDirection.Ascending);
				var wr_ = context.Operators.Last<Encounter>(wq_);
				var ws_ = wr_?.Period;
				var wt_ = FHIRHelpers_4_3_000.ToInterval(ws_);
				var wu_ = context.Operators.Start(wt_);
				var wv_ = Visit?.Period;
				var ww_ = FHIRHelpers_4_3_000.ToInterval(wv_);
				var wx_ = context.Operators.Start(ww_);
				var wy_ = context.Operators.Quantity(1m, "hour");
				var wz_ = context.Operators.Subtract((wu_ ?? wx_), wy_);
				var xb_ = context.Operators.RetrieveByValueSet<Encounter>(wl_, null);
				bool? xc_(Encounter LastObs)
				{
					var zf_ = LastObs?.StatusElement;
					var zg_ = zf_?.Value;
					var zh_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(zg_);
					var zi_ = context.Operators.Equal(zh_, "finished");
					var zj_ = LastObs?.Period;
					var zk_ = FHIRHelpers_4_3_000.ToInterval(zj_);
					var zl_ = context.Operators.End(zk_);
					var zm_ = Visit?.Period;
					var zn_ = FHIRHelpers_4_3_000.ToInterval(zm_);
					var zo_ = context.Operators.Start(zn_);
					var zp_ = context.Operators.Quantity(1m, "hour");
					var zq_ = context.Operators.Subtract(zo_, zp_);
					var zs_ = FHIRHelpers_4_3_000.ToInterval(zm_);
					var zt_ = context.Operators.Start(zs_);
					var zu_ = context.Operators.Interval(zq_, zt_, true, true);
					var zv_ = context.Operators.In<CqlDateTime>(zl_, zu_, null);
					var zx_ = FHIRHelpers_4_3_000.ToInterval(zm_);
					var zy_ = context.Operators.Start(zx_);
					var zz_ = context.Operators.Not((bool?)(zy_ is null));
					var aza_ = context.Operators.And(zv_, zz_);
					var azb_ = context.Operators.And(zi_, aza_);

					return azb_;
				};
				var xd_ = context.Operators.Where<Encounter>(xb_, xc_);
				object xe_(Encounter @this)
				{
					var azc_ = @this?.Period;
					var azd_ = FHIRHelpers_4_3_000.ToInterval(azc_);
					var aze_ = context.Operators.End(azd_);

					return aze_;
				};
				var xf_ = context.Operators.SortBy<Encounter>(xd_, xe_, System.ComponentModel.ListSortDirection.Ascending);
				var xg_ = context.Operators.Last<Encounter>(xf_);
				var xh_ = xg_?.Period;
				var xi_ = FHIRHelpers_4_3_000.ToInterval(xh_);
				var xj_ = context.Operators.Start(xi_);
				var xl_ = FHIRHelpers_4_3_000.ToInterval(wv_);
				var xm_ = context.Operators.Start(xl_);
				var xn_ = context.Operators.Interval(wz_, (xj_ ?? xm_), true, true);
				var xo_ = context.Operators.In<CqlDateTime>(wk_, xn_, null);
				var xq_ = context.Operators.RetrieveByValueSet<Encounter>(wl_, null);
				bool? xr_(Encounter LastObs)
				{
					var azf_ = LastObs?.StatusElement;
					var azg_ = azf_?.Value;
					var azh_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(azg_);
					var azi_ = context.Operators.Equal(azh_, "finished");
					var azj_ = LastObs?.Period;
					var azk_ = FHIRHelpers_4_3_000.ToInterval(azj_);
					var azl_ = context.Operators.End(azk_);
					var azm_ = Visit?.Period;
					var azn_ = FHIRHelpers_4_3_000.ToInterval(azm_);
					var azo_ = context.Operators.Start(azn_);
					var azp_ = context.Operators.Quantity(1m, "hour");
					var azq_ = context.Operators.Subtract(azo_, azp_);
					var azs_ = FHIRHelpers_4_3_000.ToInterval(azm_);
					var azt_ = context.Operators.Start(azs_);
					var azu_ = context.Operators.Interval(azq_, azt_, true, true);
					var azv_ = context.Operators.In<CqlDateTime>(azl_, azu_, null);
					var azx_ = FHIRHelpers_4_3_000.ToInterval(azm_);
					var azy_ = context.Operators.Start(azx_);
					var azz_ = context.Operators.Not((bool?)(azy_ is null));
					var bza_ = context.Operators.And(azv_, azz_);
					var bzb_ = context.Operators.And(azi_, bza_);

					return bzb_;
				};
				var xs_ = context.Operators.Where<Encounter>(xq_, xr_);
				object xt_(Encounter @this)
				{
					var bzc_ = @this?.Period;
					var bzd_ = FHIRHelpers_4_3_000.ToInterval(bzc_);
					var bze_ = context.Operators.End(bzd_);

					return bze_;
				};
				var xu_ = context.Operators.SortBy<Encounter>(xs_, xt_, System.ComponentModel.ListSortDirection.Ascending);
				var xv_ = context.Operators.Last<Encounter>(xu_);
				var xw_ = xv_?.Period;
				var xx_ = FHIRHelpers_4_3_000.ToInterval(xw_);
				var xy_ = context.Operators.Start(xx_);
				var ya_ = FHIRHelpers_4_3_000.ToInterval(wv_);
				var yb_ = context.Operators.Start(ya_);
				var yc_ = context.Operators.Not((bool?)((xy_ ?? yb_) is null));
				var yd_ = context.Operators.And(xo_, yc_);
				var ye_ = context.Operators.And(wh_, yd_);

				return ye_;
			};
			var r_ = context.Operators.Where<Encounter>(p_, q_);
			object s_(Encounter @this)
			{
				var bzf_ = @this?.Period;
				var bzg_ = FHIRHelpers_4_3_000.ToInterval(bzf_);
				var bzh_ = context.Operators.End(bzg_);

				return bzh_;
			};
			var t_ = context.Operators.SortBy<Encounter>(r_, s_, System.ComponentModel.ListSortDirection.Ascending);
			var u_ = context.Operators.Last<Encounter>(t_);
			var v_ = u_?.Period;
			var w_ = FHIRHelpers_4_3_000.ToInterval(v_);
			var x_ = context.Operators.Start(w_);
			var y_ = this.Observation_Services();
			var z_ = context.Operators.RetrieveByValueSet<Encounter>(y_, null);
			bool? aa_(Encounter LastObs)
			{
				var bzi_ = LastObs?.StatusElement;
				var bzj_ = bzi_?.Value;
				var bzk_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(bzj_);
				var bzl_ = context.Operators.Equal(bzk_, "finished");
				var bzm_ = LastObs?.Period;
				var bzn_ = FHIRHelpers_4_3_000.ToInterval(bzm_);
				var bzo_ = context.Operators.End(bzn_);
				var bzp_ = Visit?.Period;
				var bzq_ = FHIRHelpers_4_3_000.ToInterval(bzp_);
				var bzr_ = context.Operators.Start(bzq_);
				var bzs_ = context.Operators.Quantity(1m, "hour");
				var bzt_ = context.Operators.Subtract(bzr_, bzs_);
				var bzv_ = FHIRHelpers_4_3_000.ToInterval(bzp_);
				var bzw_ = context.Operators.Start(bzv_);
				var bzx_ = context.Operators.Interval(bzt_, bzw_, true, true);
				var bzy_ = context.Operators.In<CqlDateTime>(bzo_, bzx_, null);
				var cza_ = FHIRHelpers_4_3_000.ToInterval(bzp_);
				var czb_ = context.Operators.Start(cza_);
				var czc_ = context.Operators.Not((bool?)(czb_ is null));
				var czd_ = context.Operators.And(bzy_, czc_);
				var cze_ = context.Operators.And(bzl_, czd_);

				return cze_;
			};
			var ab_ = context.Operators.Where<Encounter>(z_, aa_);
			object ac_(Encounter @this)
			{
				var czf_ = @this?.Period;
				var czg_ = FHIRHelpers_4_3_000.ToInterval(czf_);
				var czh_ = context.Operators.End(czg_);

				return czh_;
			};
			var ad_ = context.Operators.SortBy<Encounter>(ab_, ac_, System.ComponentModel.ListSortDirection.Ascending);
			var ae_ = context.Operators.Last<Encounter>(ad_);
			var af_ = ae_?.Period;
			var ag_ = FHIRHelpers_4_3_000.ToInterval(af_);
			var ah_ = context.Operators.Start(ag_);
			var ai_ = Visit?.Period;
			var aj_ = FHIRHelpers_4_3_000.ToInterval(ai_);
			var ak_ = context.Operators.Start(aj_);
			var am_ = FHIRHelpers_4_3_000.ToInterval(ai_);
			var an_ = context.Operators.End(am_);
			var ao_ = context.Operators.Interval((n_ ?? (x_ ?? (ah_ ?? ak_))), an_, true, true);

			return ao_;
		};
		var c_ = context.Operators.Select<Encounter, CqlInterval<CqlDateTime>>((IEnumerable<Encounter>)a_, b_);
		var d_ = context.Operators.SingletonFrom<CqlInterval<CqlDateTime>>(c_);

		return d_;
	}

    [CqlDeclaration("hospitalizationWithObservationAndOutpatientSurgeryService")]
    [CqlTag("description", "Hospitalization with Observation and Outpatient Surgery Service returns the total interval from the start of any immediately prior emergency department visit, outpatient surgery visit or observation visit to the discharge of the given encounter.")]
	public CqlInterval<CqlDateTime> hospitalizationWithObservationAndOutpatientSurgeryService(Encounter TheEncounter)
	{
		var a_ = new Encounter[]
		{
			TheEncounter,
		};
		CqlInterval<CqlDateTime> b_(Encounter Visit)
		{
			var e_ = this.Outpatient_Surgery_Service();
			var f_ = context.Operators.RetrieveByValueSet<Encounter>(e_, null);
			bool? g_(Encounter LastSurgeryOP)
			{
				var ap_ = LastSurgeryOP?.Period;
				var aq_ = FHIRHelpers_4_3_000.ToInterval(ap_);
				var ar_ = context.Operators.End(aq_);
				var as_ = this.Emergency_Department_Visit();
				var at_ = context.Operators.RetrieveByValueSet<Encounter>(as_, null);
				bool? au_(Encounter LastED)
				{
					var dp_ = LastED?.StatusElement;
					var dq_ = dp_?.Value;
					var dr_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(dq_);
					var ds_ = context.Operators.Equal(dr_, "finished");
					var dt_ = LastED?.Period;
					var du_ = FHIRHelpers_4_3_000.ToInterval(dt_);
					var dv_ = context.Operators.End(du_);
					var dw_ = this.Observation_Services();
					var dx_ = context.Operators.RetrieveByValueSet<Encounter>(dw_, null);
					bool? dy_(Encounter LastObs)
					{
						var fq_ = LastObs?.StatusElement;
						var fr_ = fq_?.Value;
						var fs_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(fr_);
						var ft_ = context.Operators.Equal(fs_, "finished");
						var fu_ = LastObs?.Period;
						var fv_ = FHIRHelpers_4_3_000.ToInterval(fu_);
						var fw_ = context.Operators.End(fv_);
						var fx_ = Visit?.Period;
						var fy_ = FHIRHelpers_4_3_000.ToInterval(fx_);
						var fz_ = context.Operators.Start(fy_);
						var ga_ = context.Operators.Quantity(1m, "hour");
						var gb_ = context.Operators.Subtract(fz_, ga_);
						var gd_ = FHIRHelpers_4_3_000.ToInterval(fx_);
						var ge_ = context.Operators.Start(gd_);
						var gf_ = context.Operators.Interval(gb_, ge_, true, true);
						var gg_ = context.Operators.In<CqlDateTime>(fw_, gf_, null);
						var gi_ = FHIRHelpers_4_3_000.ToInterval(fx_);
						var gj_ = context.Operators.Start(gi_);
						var gk_ = context.Operators.Not((bool?)(gj_ is null));
						var gl_ = context.Operators.And(gg_, gk_);
						var gm_ = context.Operators.And(ft_, gl_);

						return gm_;
					};
					var dz_ = context.Operators.Where<Encounter>(dx_, dy_);
					object ea_(Encounter @this)
					{
						var gn_ = @this?.Period;
						var go_ = FHIRHelpers_4_3_000.ToInterval(gn_);
						var gp_ = context.Operators.End(go_);

						return gp_;
					};
					var eb_ = context.Operators.SortBy<Encounter>(dz_, ea_, System.ComponentModel.ListSortDirection.Ascending);
					var ec_ = context.Operators.Last<Encounter>(eb_);
					var ed_ = ec_?.Period;
					var ee_ = FHIRHelpers_4_3_000.ToInterval(ed_);
					var ef_ = context.Operators.Start(ee_);
					var eg_ = Visit?.Period;
					var eh_ = FHIRHelpers_4_3_000.ToInterval(eg_);
					var ei_ = context.Operators.Start(eh_);
					var ej_ = context.Operators.Quantity(1m, "hour");
					var ek_ = context.Operators.Subtract((ef_ ?? ei_), ej_);
					var em_ = context.Operators.RetrieveByValueSet<Encounter>(dw_, null);
					bool? en_(Encounter LastObs)
					{
						var gq_ = LastObs?.StatusElement;
						var gr_ = gq_?.Value;
						var gs_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(gr_);
						var gt_ = context.Operators.Equal(gs_, "finished");
						var gu_ = LastObs?.Period;
						var gv_ = FHIRHelpers_4_3_000.ToInterval(gu_);
						var gw_ = context.Operators.End(gv_);
						var gx_ = Visit?.Period;
						var gy_ = FHIRHelpers_4_3_000.ToInterval(gx_);
						var gz_ = context.Operators.Start(gy_);
						var ha_ = context.Operators.Quantity(1m, "hour");
						var hb_ = context.Operators.Subtract(gz_, ha_);
						var hd_ = FHIRHelpers_4_3_000.ToInterval(gx_);
						var he_ = context.Operators.Start(hd_);
						var hf_ = context.Operators.Interval(hb_, he_, true, true);
						var hg_ = context.Operators.In<CqlDateTime>(gw_, hf_, null);
						var hi_ = FHIRHelpers_4_3_000.ToInterval(gx_);
						var hj_ = context.Operators.Start(hi_);
						var hk_ = context.Operators.Not((bool?)(hj_ is null));
						var hl_ = context.Operators.And(hg_, hk_);
						var hm_ = context.Operators.And(gt_, hl_);

						return hm_;
					};
					var eo_ = context.Operators.Where<Encounter>(em_, en_);
					object ep_(Encounter @this)
					{
						var hn_ = @this?.Period;
						var ho_ = FHIRHelpers_4_3_000.ToInterval(hn_);
						var hp_ = context.Operators.End(ho_);

						return hp_;
					};
					var eq_ = context.Operators.SortBy<Encounter>(eo_, ep_, System.ComponentModel.ListSortDirection.Ascending);
					var er_ = context.Operators.Last<Encounter>(eq_);
					var es_ = er_?.Period;
					var et_ = FHIRHelpers_4_3_000.ToInterval(es_);
					var eu_ = context.Operators.Start(et_);
					var ew_ = FHIRHelpers_4_3_000.ToInterval(eg_);
					var ex_ = context.Operators.Start(ew_);
					var ey_ = context.Operators.Interval(ek_, (eu_ ?? ex_), true, true);
					var ez_ = context.Operators.In<CqlDateTime>(dv_, ey_, null);
					var fb_ = context.Operators.RetrieveByValueSet<Encounter>(dw_, null);
					bool? fc_(Encounter LastObs)
					{
						var hq_ = LastObs?.StatusElement;
						var hr_ = hq_?.Value;
						var hs_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(hr_);
						var ht_ = context.Operators.Equal(hs_, "finished");
						var hu_ = LastObs?.Period;
						var hv_ = FHIRHelpers_4_3_000.ToInterval(hu_);
						var hw_ = context.Operators.End(hv_);
						var hx_ = Visit?.Period;
						var hy_ = FHIRHelpers_4_3_000.ToInterval(hx_);
						var hz_ = context.Operators.Start(hy_);
						var ia_ = context.Operators.Quantity(1m, "hour");
						var ib_ = context.Operators.Subtract(hz_, ia_);
						var id_ = FHIRHelpers_4_3_000.ToInterval(hx_);
						var ie_ = context.Operators.Start(id_);
						var if_ = context.Operators.Interval(ib_, ie_, true, true);
						var ig_ = context.Operators.In<CqlDateTime>(hw_, if_, null);
						var ii_ = FHIRHelpers_4_3_000.ToInterval(hx_);
						var ij_ = context.Operators.Start(ii_);
						var ik_ = context.Operators.Not((bool?)(ij_ is null));
						var il_ = context.Operators.And(ig_, ik_);
						var im_ = context.Operators.And(ht_, il_);

						return im_;
					};
					var fd_ = context.Operators.Where<Encounter>(fb_, fc_);
					object fe_(Encounter @this)
					{
						var in_ = @this?.Period;
						var io_ = FHIRHelpers_4_3_000.ToInterval(in_);
						var ip_ = context.Operators.End(io_);

						return ip_;
					};
					var ff_ = context.Operators.SortBy<Encounter>(fd_, fe_, System.ComponentModel.ListSortDirection.Ascending);
					var fg_ = context.Operators.Last<Encounter>(ff_);
					var fh_ = fg_?.Period;
					var fi_ = FHIRHelpers_4_3_000.ToInterval(fh_);
					var fj_ = context.Operators.Start(fi_);
					var fl_ = FHIRHelpers_4_3_000.ToInterval(eg_);
					var fm_ = context.Operators.Start(fl_);
					var fn_ = context.Operators.Not((bool?)((fj_ ?? fm_) is null));
					var fo_ = context.Operators.And(ez_, fn_);
					var fp_ = context.Operators.And(ds_, fo_);

					return fp_;
				};
				var av_ = context.Operators.Where<Encounter>(at_, au_);
				object aw_(Encounter @this)
				{
					var iq_ = @this?.Period;
					var ir_ = FHIRHelpers_4_3_000.ToInterval(iq_);
					var is_ = context.Operators.End(ir_);

					return is_;
				};
				var ax_ = context.Operators.SortBy<Encounter>(av_, aw_, System.ComponentModel.ListSortDirection.Ascending);
				var ay_ = context.Operators.Last<Encounter>(ax_);
				var az_ = ay_?.Period;
				var ba_ = FHIRHelpers_4_3_000.ToInterval(az_);
				var bb_ = context.Operators.Start(ba_);
				var bc_ = this.Observation_Services();
				var bd_ = context.Operators.RetrieveByValueSet<Encounter>(bc_, null);
				bool? be_(Encounter LastObs)
				{
					var it_ = LastObs?.StatusElement;
					var iu_ = it_?.Value;
					var iv_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(iu_);
					var iw_ = context.Operators.Equal(iv_, "finished");
					var ix_ = LastObs?.Period;
					var iy_ = FHIRHelpers_4_3_000.ToInterval(ix_);
					var iz_ = context.Operators.End(iy_);
					var ja_ = Visit?.Period;
					var jb_ = FHIRHelpers_4_3_000.ToInterval(ja_);
					var jc_ = context.Operators.Start(jb_);
					var jd_ = context.Operators.Quantity(1m, "hour");
					var je_ = context.Operators.Subtract(jc_, jd_);
					var jg_ = FHIRHelpers_4_3_000.ToInterval(ja_);
					var jh_ = context.Operators.Start(jg_);
					var ji_ = context.Operators.Interval(je_, jh_, true, true);
					var jj_ = context.Operators.In<CqlDateTime>(iz_, ji_, null);
					var jl_ = FHIRHelpers_4_3_000.ToInterval(ja_);
					var jm_ = context.Operators.Start(jl_);
					var jn_ = context.Operators.Not((bool?)(jm_ is null));
					var jo_ = context.Operators.And(jj_, jn_);
					var jp_ = context.Operators.And(iw_, jo_);

					return jp_;
				};
				var bf_ = context.Operators.Where<Encounter>(bd_, be_);
				object bg_(Encounter @this)
				{
					var jq_ = @this?.Period;
					var jr_ = FHIRHelpers_4_3_000.ToInterval(jq_);
					var js_ = context.Operators.End(jr_);

					return js_;
				};
				var bh_ = context.Operators.SortBy<Encounter>(bf_, bg_, System.ComponentModel.ListSortDirection.Ascending);
				var bi_ = context.Operators.Last<Encounter>(bh_);
				var bj_ = bi_?.Period;
				var bk_ = FHIRHelpers_4_3_000.ToInterval(bj_);
				var bl_ = context.Operators.Start(bk_);
				var bm_ = Visit?.Period;
				var bn_ = FHIRHelpers_4_3_000.ToInterval(bm_);
				var bo_ = context.Operators.Start(bn_);
				var bp_ = context.Operators.Quantity(1m, "hour");
				var bq_ = context.Operators.Subtract((bb_ ?? (bl_ ?? bo_)), bp_);
				var bs_ = context.Operators.RetrieveByValueSet<Encounter>(as_, null);
				bool? bt_(Encounter LastED)
				{
					var jt_ = LastED?.StatusElement;
					var ju_ = jt_?.Value;
					var jv_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(ju_);
					var jw_ = context.Operators.Equal(jv_, "finished");
					var jx_ = LastED?.Period;
					var jy_ = FHIRHelpers_4_3_000.ToInterval(jx_);
					var jz_ = context.Operators.End(jy_);
					var ka_ = this.Observation_Services();
					var kb_ = context.Operators.RetrieveByValueSet<Encounter>(ka_, null);
					bool? kc_(Encounter LastObs)
					{
						var lu_ = LastObs?.StatusElement;
						var lv_ = lu_?.Value;
						var lw_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(lv_);
						var lx_ = context.Operators.Equal(lw_, "finished");
						var ly_ = LastObs?.Period;
						var lz_ = FHIRHelpers_4_3_000.ToInterval(ly_);
						var ma_ = context.Operators.End(lz_);
						var mb_ = Visit?.Period;
						var mc_ = FHIRHelpers_4_3_000.ToInterval(mb_);
						var md_ = context.Operators.Start(mc_);
						var me_ = context.Operators.Quantity(1m, "hour");
						var mf_ = context.Operators.Subtract(md_, me_);
						var mh_ = FHIRHelpers_4_3_000.ToInterval(mb_);
						var mi_ = context.Operators.Start(mh_);
						var mj_ = context.Operators.Interval(mf_, mi_, true, true);
						var mk_ = context.Operators.In<CqlDateTime>(ma_, mj_, null);
						var mm_ = FHIRHelpers_4_3_000.ToInterval(mb_);
						var mn_ = context.Operators.Start(mm_);
						var mo_ = context.Operators.Not((bool?)(mn_ is null));
						var mp_ = context.Operators.And(mk_, mo_);
						var mq_ = context.Operators.And(lx_, mp_);

						return mq_;
					};
					var kd_ = context.Operators.Where<Encounter>(kb_, kc_);
					object ke_(Encounter @this)
					{
						var mr_ = @this?.Period;
						var ms_ = FHIRHelpers_4_3_000.ToInterval(mr_);
						var mt_ = context.Operators.End(ms_);

						return mt_;
					};
					var kf_ = context.Operators.SortBy<Encounter>(kd_, ke_, System.ComponentModel.ListSortDirection.Ascending);
					var kg_ = context.Operators.Last<Encounter>(kf_);
					var kh_ = kg_?.Period;
					var ki_ = FHIRHelpers_4_3_000.ToInterval(kh_);
					var kj_ = context.Operators.Start(ki_);
					var kk_ = Visit?.Period;
					var kl_ = FHIRHelpers_4_3_000.ToInterval(kk_);
					var km_ = context.Operators.Start(kl_);
					var kn_ = context.Operators.Quantity(1m, "hour");
					var ko_ = context.Operators.Subtract((kj_ ?? km_), kn_);
					var kq_ = context.Operators.RetrieveByValueSet<Encounter>(ka_, null);
					bool? kr_(Encounter LastObs)
					{
						var mu_ = LastObs?.StatusElement;
						var mv_ = mu_?.Value;
						var mw_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(mv_);
						var mx_ = context.Operators.Equal(mw_, "finished");
						var my_ = LastObs?.Period;
						var mz_ = FHIRHelpers_4_3_000.ToInterval(my_);
						var na_ = context.Operators.End(mz_);
						var nb_ = Visit?.Period;
						var nc_ = FHIRHelpers_4_3_000.ToInterval(nb_);
						var nd_ = context.Operators.Start(nc_);
						var ne_ = context.Operators.Quantity(1m, "hour");
						var nf_ = context.Operators.Subtract(nd_, ne_);
						var nh_ = FHIRHelpers_4_3_000.ToInterval(nb_);
						var ni_ = context.Operators.Start(nh_);
						var nj_ = context.Operators.Interval(nf_, ni_, true, true);
						var nk_ = context.Operators.In<CqlDateTime>(na_, nj_, null);
						var nm_ = FHIRHelpers_4_3_000.ToInterval(nb_);
						var nn_ = context.Operators.Start(nm_);
						var no_ = context.Operators.Not((bool?)(nn_ is null));
						var np_ = context.Operators.And(nk_, no_);
						var nq_ = context.Operators.And(mx_, np_);

						return nq_;
					};
					var ks_ = context.Operators.Where<Encounter>(kq_, kr_);
					object kt_(Encounter @this)
					{
						var nr_ = @this?.Period;
						var ns_ = FHIRHelpers_4_3_000.ToInterval(nr_);
						var nt_ = context.Operators.End(ns_);

						return nt_;
					};
					var ku_ = context.Operators.SortBy<Encounter>(ks_, kt_, System.ComponentModel.ListSortDirection.Ascending);
					var kv_ = context.Operators.Last<Encounter>(ku_);
					var kw_ = kv_?.Period;
					var kx_ = FHIRHelpers_4_3_000.ToInterval(kw_);
					var ky_ = context.Operators.Start(kx_);
					var la_ = FHIRHelpers_4_3_000.ToInterval(kk_);
					var lb_ = context.Operators.Start(la_);
					var lc_ = context.Operators.Interval(ko_, (ky_ ?? lb_), true, true);
					var ld_ = context.Operators.In<CqlDateTime>(jz_, lc_, null);
					var lf_ = context.Operators.RetrieveByValueSet<Encounter>(ka_, null);
					bool? lg_(Encounter LastObs)
					{
						var nu_ = LastObs?.StatusElement;
						var nv_ = nu_?.Value;
						var nw_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(nv_);
						var nx_ = context.Operators.Equal(nw_, "finished");
						var ny_ = LastObs?.Period;
						var nz_ = FHIRHelpers_4_3_000.ToInterval(ny_);
						var oa_ = context.Operators.End(nz_);
						var ob_ = Visit?.Period;
						var oc_ = FHIRHelpers_4_3_000.ToInterval(ob_);
						var od_ = context.Operators.Start(oc_);
						var oe_ = context.Operators.Quantity(1m, "hour");
						var of_ = context.Operators.Subtract(od_, oe_);
						var oh_ = FHIRHelpers_4_3_000.ToInterval(ob_);
						var oi_ = context.Operators.Start(oh_);
						var oj_ = context.Operators.Interval(of_, oi_, true, true);
						var ok_ = context.Operators.In<CqlDateTime>(oa_, oj_, null);
						var om_ = FHIRHelpers_4_3_000.ToInterval(ob_);
						var on_ = context.Operators.Start(om_);
						var oo_ = context.Operators.Not((bool?)(on_ is null));
						var op_ = context.Operators.And(ok_, oo_);
						var oq_ = context.Operators.And(nx_, op_);

						return oq_;
					};
					var lh_ = context.Operators.Where<Encounter>(lf_, lg_);
					object li_(Encounter @this)
					{
						var or_ = @this?.Period;
						var os_ = FHIRHelpers_4_3_000.ToInterval(or_);
						var ot_ = context.Operators.End(os_);

						return ot_;
					};
					var lj_ = context.Operators.SortBy<Encounter>(lh_, li_, System.ComponentModel.ListSortDirection.Ascending);
					var lk_ = context.Operators.Last<Encounter>(lj_);
					var ll_ = lk_?.Period;
					var lm_ = FHIRHelpers_4_3_000.ToInterval(ll_);
					var ln_ = context.Operators.Start(lm_);
					var lp_ = FHIRHelpers_4_3_000.ToInterval(kk_);
					var lq_ = context.Operators.Start(lp_);
					var lr_ = context.Operators.Not((bool?)((ln_ ?? lq_) is null));
					var ls_ = context.Operators.And(ld_, lr_);
					var lt_ = context.Operators.And(jw_, ls_);

					return lt_;
				};
				var bu_ = context.Operators.Where<Encounter>(bs_, bt_);
				object bv_(Encounter @this)
				{
					var ou_ = @this?.Period;
					var ov_ = FHIRHelpers_4_3_000.ToInterval(ou_);
					var ow_ = context.Operators.End(ov_);

					return ow_;
				};
				var bw_ = context.Operators.SortBy<Encounter>(bu_, bv_, System.ComponentModel.ListSortDirection.Ascending);
				var bx_ = context.Operators.Last<Encounter>(bw_);
				var by_ = bx_?.Period;
				var bz_ = FHIRHelpers_4_3_000.ToInterval(by_);
				var ca_ = context.Operators.Start(bz_);
				var cc_ = context.Operators.RetrieveByValueSet<Encounter>(bc_, null);
				bool? cd_(Encounter LastObs)
				{
					var ox_ = LastObs?.StatusElement;
					var oy_ = ox_?.Value;
					var oz_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(oy_);
					var pa_ = context.Operators.Equal(oz_, "finished");
					var pb_ = LastObs?.Period;
					var pc_ = FHIRHelpers_4_3_000.ToInterval(pb_);
					var pd_ = context.Operators.End(pc_);
					var pe_ = Visit?.Period;
					var pf_ = FHIRHelpers_4_3_000.ToInterval(pe_);
					var pg_ = context.Operators.Start(pf_);
					var ph_ = context.Operators.Quantity(1m, "hour");
					var pi_ = context.Operators.Subtract(pg_, ph_);
					var pk_ = FHIRHelpers_4_3_000.ToInterval(pe_);
					var pl_ = context.Operators.Start(pk_);
					var pm_ = context.Operators.Interval(pi_, pl_, true, true);
					var pn_ = context.Operators.In<CqlDateTime>(pd_, pm_, null);
					var pp_ = FHIRHelpers_4_3_000.ToInterval(pe_);
					var pq_ = context.Operators.Start(pp_);
					var pr_ = context.Operators.Not((bool?)(pq_ is null));
					var ps_ = context.Operators.And(pn_, pr_);
					var pt_ = context.Operators.And(pa_, ps_);

					return pt_;
				};
				var ce_ = context.Operators.Where<Encounter>(cc_, cd_);
				object cf_(Encounter @this)
				{
					var pu_ = @this?.Period;
					var pv_ = FHIRHelpers_4_3_000.ToInterval(pu_);
					var pw_ = context.Operators.End(pv_);

					return pw_;
				};
				var cg_ = context.Operators.SortBy<Encounter>(ce_, cf_, System.ComponentModel.ListSortDirection.Ascending);
				var ch_ = context.Operators.Last<Encounter>(cg_);
				var ci_ = ch_?.Period;
				var cj_ = FHIRHelpers_4_3_000.ToInterval(ci_);
				var ck_ = context.Operators.Start(cj_);
				var cm_ = FHIRHelpers_4_3_000.ToInterval(bm_);
				var cn_ = context.Operators.Start(cm_);
				var co_ = context.Operators.Interval(bq_, (ca_ ?? (ck_ ?? cn_)), true, true);
				var cp_ = context.Operators.In<CqlDateTime>(ar_, co_, null);
				var cr_ = context.Operators.RetrieveByValueSet<Encounter>(as_, null);
				bool? cs_(Encounter LastED)
				{
					var px_ = LastED?.StatusElement;
					var py_ = px_?.Value;
					var pz_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(py_);
					var qa_ = context.Operators.Equal(pz_, "finished");
					var qb_ = LastED?.Period;
					var qc_ = FHIRHelpers_4_3_000.ToInterval(qb_);
					var qd_ = context.Operators.End(qc_);
					var qe_ = this.Observation_Services();
					var qf_ = context.Operators.RetrieveByValueSet<Encounter>(qe_, null);
					bool? qg_(Encounter LastObs)
					{
						var ry_ = LastObs?.StatusElement;
						var rz_ = ry_?.Value;
						var sa_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(rz_);
						var sb_ = context.Operators.Equal(sa_, "finished");
						var sc_ = LastObs?.Period;
						var sd_ = FHIRHelpers_4_3_000.ToInterval(sc_);
						var se_ = context.Operators.End(sd_);
						var sf_ = Visit?.Period;
						var sg_ = FHIRHelpers_4_3_000.ToInterval(sf_);
						var sh_ = context.Operators.Start(sg_);
						var si_ = context.Operators.Quantity(1m, "hour");
						var sj_ = context.Operators.Subtract(sh_, si_);
						var sl_ = FHIRHelpers_4_3_000.ToInterval(sf_);
						var sm_ = context.Operators.Start(sl_);
						var sn_ = context.Operators.Interval(sj_, sm_, true, true);
						var so_ = context.Operators.In<CqlDateTime>(se_, sn_, null);
						var sq_ = FHIRHelpers_4_3_000.ToInterval(sf_);
						var sr_ = context.Operators.Start(sq_);
						var ss_ = context.Operators.Not((bool?)(sr_ is null));
						var st_ = context.Operators.And(so_, ss_);
						var su_ = context.Operators.And(sb_, st_);

						return su_;
					};
					var qh_ = context.Operators.Where<Encounter>(qf_, qg_);
					object qi_(Encounter @this)
					{
						var sv_ = @this?.Period;
						var sw_ = FHIRHelpers_4_3_000.ToInterval(sv_);
						var sx_ = context.Operators.End(sw_);

						return sx_;
					};
					var qj_ = context.Operators.SortBy<Encounter>(qh_, qi_, System.ComponentModel.ListSortDirection.Ascending);
					var qk_ = context.Operators.Last<Encounter>(qj_);
					var ql_ = qk_?.Period;
					var qm_ = FHIRHelpers_4_3_000.ToInterval(ql_);
					var qn_ = context.Operators.Start(qm_);
					var qo_ = Visit?.Period;
					var qp_ = FHIRHelpers_4_3_000.ToInterval(qo_);
					var qq_ = context.Operators.Start(qp_);
					var qr_ = context.Operators.Quantity(1m, "hour");
					var qs_ = context.Operators.Subtract((qn_ ?? qq_), qr_);
					var qu_ = context.Operators.RetrieveByValueSet<Encounter>(qe_, null);
					bool? qv_(Encounter LastObs)
					{
						var sy_ = LastObs?.StatusElement;
						var sz_ = sy_?.Value;
						var ta_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(sz_);
						var tb_ = context.Operators.Equal(ta_, "finished");
						var tc_ = LastObs?.Period;
						var td_ = FHIRHelpers_4_3_000.ToInterval(tc_);
						var te_ = context.Operators.End(td_);
						var tf_ = Visit?.Period;
						var tg_ = FHIRHelpers_4_3_000.ToInterval(tf_);
						var th_ = context.Operators.Start(tg_);
						var ti_ = context.Operators.Quantity(1m, "hour");
						var tj_ = context.Operators.Subtract(th_, ti_);
						var tl_ = FHIRHelpers_4_3_000.ToInterval(tf_);
						var tm_ = context.Operators.Start(tl_);
						var tn_ = context.Operators.Interval(tj_, tm_, true, true);
						var to_ = context.Operators.In<CqlDateTime>(te_, tn_, null);
						var tq_ = FHIRHelpers_4_3_000.ToInterval(tf_);
						var tr_ = context.Operators.Start(tq_);
						var ts_ = context.Operators.Not((bool?)(tr_ is null));
						var tt_ = context.Operators.And(to_, ts_);
						var tu_ = context.Operators.And(tb_, tt_);

						return tu_;
					};
					var qw_ = context.Operators.Where<Encounter>(qu_, qv_);
					object qx_(Encounter @this)
					{
						var tv_ = @this?.Period;
						var tw_ = FHIRHelpers_4_3_000.ToInterval(tv_);
						var tx_ = context.Operators.End(tw_);

						return tx_;
					};
					var qy_ = context.Operators.SortBy<Encounter>(qw_, qx_, System.ComponentModel.ListSortDirection.Ascending);
					var qz_ = context.Operators.Last<Encounter>(qy_);
					var ra_ = qz_?.Period;
					var rb_ = FHIRHelpers_4_3_000.ToInterval(ra_);
					var rc_ = context.Operators.Start(rb_);
					var re_ = FHIRHelpers_4_3_000.ToInterval(qo_);
					var rf_ = context.Operators.Start(re_);
					var rg_ = context.Operators.Interval(qs_, (rc_ ?? rf_), true, true);
					var rh_ = context.Operators.In<CqlDateTime>(qd_, rg_, null);
					var rj_ = context.Operators.RetrieveByValueSet<Encounter>(qe_, null);
					bool? rk_(Encounter LastObs)
					{
						var ty_ = LastObs?.StatusElement;
						var tz_ = ty_?.Value;
						var ua_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(tz_);
						var ub_ = context.Operators.Equal(ua_, "finished");
						var uc_ = LastObs?.Period;
						var ud_ = FHIRHelpers_4_3_000.ToInterval(uc_);
						var ue_ = context.Operators.End(ud_);
						var uf_ = Visit?.Period;
						var ug_ = FHIRHelpers_4_3_000.ToInterval(uf_);
						var uh_ = context.Operators.Start(ug_);
						var ui_ = context.Operators.Quantity(1m, "hour");
						var uj_ = context.Operators.Subtract(uh_, ui_);
						var ul_ = FHIRHelpers_4_3_000.ToInterval(uf_);
						var um_ = context.Operators.Start(ul_);
						var un_ = context.Operators.Interval(uj_, um_, true, true);
						var uo_ = context.Operators.In<CqlDateTime>(ue_, un_, null);
						var uq_ = FHIRHelpers_4_3_000.ToInterval(uf_);
						var ur_ = context.Operators.Start(uq_);
						var us_ = context.Operators.Not((bool?)(ur_ is null));
						var ut_ = context.Operators.And(uo_, us_);
						var uu_ = context.Operators.And(ub_, ut_);

						return uu_;
					};
					var rl_ = context.Operators.Where<Encounter>(rj_, rk_);
					object rm_(Encounter @this)
					{
						var uv_ = @this?.Period;
						var uw_ = FHIRHelpers_4_3_000.ToInterval(uv_);
						var ux_ = context.Operators.End(uw_);

						return ux_;
					};
					var rn_ = context.Operators.SortBy<Encounter>(rl_, rm_, System.ComponentModel.ListSortDirection.Ascending);
					var ro_ = context.Operators.Last<Encounter>(rn_);
					var rp_ = ro_?.Period;
					var rq_ = FHIRHelpers_4_3_000.ToInterval(rp_);
					var rr_ = context.Operators.Start(rq_);
					var rt_ = FHIRHelpers_4_3_000.ToInterval(qo_);
					var ru_ = context.Operators.Start(rt_);
					var rv_ = context.Operators.Not((bool?)((rr_ ?? ru_) is null));
					var rw_ = context.Operators.And(rh_, rv_);
					var rx_ = context.Operators.And(qa_, rw_);

					return rx_;
				};
				var ct_ = context.Operators.Where<Encounter>(cr_, cs_);
				object cu_(Encounter @this)
				{
					var uy_ = @this?.Period;
					var uz_ = FHIRHelpers_4_3_000.ToInterval(uy_);
					var va_ = context.Operators.End(uz_);

					return va_;
				};
				var cv_ = context.Operators.SortBy<Encounter>(ct_, cu_, System.ComponentModel.ListSortDirection.Ascending);
				var cw_ = context.Operators.Last<Encounter>(cv_);
				var cx_ = cw_?.Period;
				var cy_ = FHIRHelpers_4_3_000.ToInterval(cx_);
				var cz_ = context.Operators.Start(cy_);
				var db_ = context.Operators.RetrieveByValueSet<Encounter>(bc_, null);
				bool? dc_(Encounter LastObs)
				{
					var vb_ = LastObs?.StatusElement;
					var vc_ = vb_?.Value;
					var vd_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(vc_);
					var ve_ = context.Operators.Equal(vd_, "finished");
					var vf_ = LastObs?.Period;
					var vg_ = FHIRHelpers_4_3_000.ToInterval(vf_);
					var vh_ = context.Operators.End(vg_);
					var vi_ = Visit?.Period;
					var vj_ = FHIRHelpers_4_3_000.ToInterval(vi_);
					var vk_ = context.Operators.Start(vj_);
					var vl_ = context.Operators.Quantity(1m, "hour");
					var vm_ = context.Operators.Subtract(vk_, vl_);
					var vo_ = FHIRHelpers_4_3_000.ToInterval(vi_);
					var vp_ = context.Operators.Start(vo_);
					var vq_ = context.Operators.Interval(vm_, vp_, true, true);
					var vr_ = context.Operators.In<CqlDateTime>(vh_, vq_, null);
					var vt_ = FHIRHelpers_4_3_000.ToInterval(vi_);
					var vu_ = context.Operators.Start(vt_);
					var vv_ = context.Operators.Not((bool?)(vu_ is null));
					var vw_ = context.Operators.And(vr_, vv_);
					var vx_ = context.Operators.And(ve_, vw_);

					return vx_;
				};
				var dd_ = context.Operators.Where<Encounter>(db_, dc_);
				object de_(Encounter @this)
				{
					var vy_ = @this?.Period;
					var vz_ = FHIRHelpers_4_3_000.ToInterval(vy_);
					var wa_ = context.Operators.End(vz_);

					return wa_;
				};
				var df_ = context.Operators.SortBy<Encounter>(dd_, de_, System.ComponentModel.ListSortDirection.Ascending);
				var dg_ = context.Operators.Last<Encounter>(df_);
				var dh_ = dg_?.Period;
				var di_ = FHIRHelpers_4_3_000.ToInterval(dh_);
				var dj_ = context.Operators.Start(di_);
				var dl_ = FHIRHelpers_4_3_000.ToInterval(bm_);
				var dm_ = context.Operators.Start(dl_);
				var dn_ = context.Operators.Not((bool?)((cz_ ?? (dj_ ?? dm_)) is null));
				var do_ = context.Operators.And(cp_, dn_);

				return do_;
			};
			var h_ = context.Operators.Where<Encounter>(f_, g_);
			object i_(Encounter @this)
			{
				var wb_ = @this?.Period;
				var wc_ = FHIRHelpers_4_3_000.ToInterval(wb_);
				var wd_ = context.Operators.End(wc_);

				return wd_;
			};
			var j_ = context.Operators.SortBy<Encounter>(h_, i_, System.ComponentModel.ListSortDirection.Ascending);
			var k_ = context.Operators.Last<Encounter>(j_);
			var l_ = k_?.Period;
			var m_ = FHIRHelpers_4_3_000.ToInterval(l_);
			var n_ = context.Operators.Start(m_);
			var o_ = this.Emergency_Department_Visit();
			var p_ = context.Operators.RetrieveByValueSet<Encounter>(o_, null);
			bool? q_(Encounter LastED)
			{
				var we_ = LastED?.StatusElement;
				var wf_ = we_?.Value;
				var wg_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(wf_);
				var wh_ = context.Operators.Equal(wg_, "finished");
				var wi_ = LastED?.Period;
				var wj_ = FHIRHelpers_4_3_000.ToInterval(wi_);
				var wk_ = context.Operators.End(wj_);
				var wl_ = this.Observation_Services();
				var wm_ = context.Operators.RetrieveByValueSet<Encounter>(wl_, null);
				bool? wn_(Encounter LastObs)
				{
					var yf_ = LastObs?.StatusElement;
					var yg_ = yf_?.Value;
					var yh_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(yg_);
					var yi_ = context.Operators.Equal(yh_, "finished");
					var yj_ = LastObs?.Period;
					var yk_ = FHIRHelpers_4_3_000.ToInterval(yj_);
					var yl_ = context.Operators.End(yk_);
					var ym_ = Visit?.Period;
					var yn_ = FHIRHelpers_4_3_000.ToInterval(ym_);
					var yo_ = context.Operators.Start(yn_);
					var yp_ = context.Operators.Quantity(1m, "hour");
					var yq_ = context.Operators.Subtract(yo_, yp_);
					var ys_ = FHIRHelpers_4_3_000.ToInterval(ym_);
					var yt_ = context.Operators.Start(ys_);
					var yu_ = context.Operators.Interval(yq_, yt_, true, true);
					var yv_ = context.Operators.In<CqlDateTime>(yl_, yu_, null);
					var yx_ = FHIRHelpers_4_3_000.ToInterval(ym_);
					var yy_ = context.Operators.Start(yx_);
					var yz_ = context.Operators.Not((bool?)(yy_ is null));
					var za_ = context.Operators.And(yv_, yz_);
					var zb_ = context.Operators.And(yi_, za_);

					return zb_;
				};
				var wo_ = context.Operators.Where<Encounter>(wm_, wn_);
				object wp_(Encounter @this)
				{
					var zc_ = @this?.Period;
					var zd_ = FHIRHelpers_4_3_000.ToInterval(zc_);
					var ze_ = context.Operators.End(zd_);

					return ze_;
				};
				var wq_ = context.Operators.SortBy<Encounter>(wo_, wp_, System.ComponentModel.ListSortDirection.Ascending);
				var wr_ = context.Operators.Last<Encounter>(wq_);
				var ws_ = wr_?.Period;
				var wt_ = FHIRHelpers_4_3_000.ToInterval(ws_);
				var wu_ = context.Operators.Start(wt_);
				var wv_ = Visit?.Period;
				var ww_ = FHIRHelpers_4_3_000.ToInterval(wv_);
				var wx_ = context.Operators.Start(ww_);
				var wy_ = context.Operators.Quantity(1m, "hour");
				var wz_ = context.Operators.Subtract((wu_ ?? wx_), wy_);
				var xb_ = context.Operators.RetrieveByValueSet<Encounter>(wl_, null);
				bool? xc_(Encounter LastObs)
				{
					var zf_ = LastObs?.StatusElement;
					var zg_ = zf_?.Value;
					var zh_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(zg_);
					var zi_ = context.Operators.Equal(zh_, "finished");
					var zj_ = LastObs?.Period;
					var zk_ = FHIRHelpers_4_3_000.ToInterval(zj_);
					var zl_ = context.Operators.End(zk_);
					var zm_ = Visit?.Period;
					var zn_ = FHIRHelpers_4_3_000.ToInterval(zm_);
					var zo_ = context.Operators.Start(zn_);
					var zp_ = context.Operators.Quantity(1m, "hour");
					var zq_ = context.Operators.Subtract(zo_, zp_);
					var zs_ = FHIRHelpers_4_3_000.ToInterval(zm_);
					var zt_ = context.Operators.Start(zs_);
					var zu_ = context.Operators.Interval(zq_, zt_, true, true);
					var zv_ = context.Operators.In<CqlDateTime>(zl_, zu_, null);
					var zx_ = FHIRHelpers_4_3_000.ToInterval(zm_);
					var zy_ = context.Operators.Start(zx_);
					var zz_ = context.Operators.Not((bool?)(zy_ is null));
					var aza_ = context.Operators.And(zv_, zz_);
					var azb_ = context.Operators.And(zi_, aza_);

					return azb_;
				};
				var xd_ = context.Operators.Where<Encounter>(xb_, xc_);
				object xe_(Encounter @this)
				{
					var azc_ = @this?.Period;
					var azd_ = FHIRHelpers_4_3_000.ToInterval(azc_);
					var aze_ = context.Operators.End(azd_);

					return aze_;
				};
				var xf_ = context.Operators.SortBy<Encounter>(xd_, xe_, System.ComponentModel.ListSortDirection.Ascending);
				var xg_ = context.Operators.Last<Encounter>(xf_);
				var xh_ = xg_?.Period;
				var xi_ = FHIRHelpers_4_3_000.ToInterval(xh_);
				var xj_ = context.Operators.Start(xi_);
				var xl_ = FHIRHelpers_4_3_000.ToInterval(wv_);
				var xm_ = context.Operators.Start(xl_);
				var xn_ = context.Operators.Interval(wz_, (xj_ ?? xm_), true, true);
				var xo_ = context.Operators.In<CqlDateTime>(wk_, xn_, null);
				var xq_ = context.Operators.RetrieveByValueSet<Encounter>(wl_, null);
				bool? xr_(Encounter LastObs)
				{
					var azf_ = LastObs?.StatusElement;
					var azg_ = azf_?.Value;
					var azh_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(azg_);
					var azi_ = context.Operators.Equal(azh_, "finished");
					var azj_ = LastObs?.Period;
					var azk_ = FHIRHelpers_4_3_000.ToInterval(azj_);
					var azl_ = context.Operators.End(azk_);
					var azm_ = Visit?.Period;
					var azn_ = FHIRHelpers_4_3_000.ToInterval(azm_);
					var azo_ = context.Operators.Start(azn_);
					var azp_ = context.Operators.Quantity(1m, "hour");
					var azq_ = context.Operators.Subtract(azo_, azp_);
					var azs_ = FHIRHelpers_4_3_000.ToInterval(azm_);
					var azt_ = context.Operators.Start(azs_);
					var azu_ = context.Operators.Interval(azq_, azt_, true, true);
					var azv_ = context.Operators.In<CqlDateTime>(azl_, azu_, null);
					var azx_ = FHIRHelpers_4_3_000.ToInterval(azm_);
					var azy_ = context.Operators.Start(azx_);
					var azz_ = context.Operators.Not((bool?)(azy_ is null));
					var bza_ = context.Operators.And(azv_, azz_);
					var bzb_ = context.Operators.And(azi_, bza_);

					return bzb_;
				};
				var xs_ = context.Operators.Where<Encounter>(xq_, xr_);
				object xt_(Encounter @this)
				{
					var bzc_ = @this?.Period;
					var bzd_ = FHIRHelpers_4_3_000.ToInterval(bzc_);
					var bze_ = context.Operators.End(bzd_);

					return bze_;
				};
				var xu_ = context.Operators.SortBy<Encounter>(xs_, xt_, System.ComponentModel.ListSortDirection.Ascending);
				var xv_ = context.Operators.Last<Encounter>(xu_);
				var xw_ = xv_?.Period;
				var xx_ = FHIRHelpers_4_3_000.ToInterval(xw_);
				var xy_ = context.Operators.Start(xx_);
				var ya_ = FHIRHelpers_4_3_000.ToInterval(wv_);
				var yb_ = context.Operators.Start(ya_);
				var yc_ = context.Operators.Not((bool?)((xy_ ?? yb_) is null));
				var yd_ = context.Operators.And(xo_, yc_);
				var ye_ = context.Operators.And(wh_, yd_);

				return ye_;
			};
			var r_ = context.Operators.Where<Encounter>(p_, q_);
			object s_(Encounter @this)
			{
				var bzf_ = @this?.Period;
				var bzg_ = FHIRHelpers_4_3_000.ToInterval(bzf_);
				var bzh_ = context.Operators.End(bzg_);

				return bzh_;
			};
			var t_ = context.Operators.SortBy<Encounter>(r_, s_, System.ComponentModel.ListSortDirection.Ascending);
			var u_ = context.Operators.Last<Encounter>(t_);
			var v_ = u_?.Period;
			var w_ = FHIRHelpers_4_3_000.ToInterval(v_);
			var x_ = context.Operators.Start(w_);
			var y_ = this.Observation_Services();
			var z_ = context.Operators.RetrieveByValueSet<Encounter>(y_, null);
			bool? aa_(Encounter LastObs)
			{
				var bzi_ = LastObs?.StatusElement;
				var bzj_ = bzi_?.Value;
				var bzk_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(bzj_);
				var bzl_ = context.Operators.Equal(bzk_, "finished");
				var bzm_ = LastObs?.Period;
				var bzn_ = FHIRHelpers_4_3_000.ToInterval(bzm_);
				var bzo_ = context.Operators.End(bzn_);
				var bzp_ = Visit?.Period;
				var bzq_ = FHIRHelpers_4_3_000.ToInterval(bzp_);
				var bzr_ = context.Operators.Start(bzq_);
				var bzs_ = context.Operators.Quantity(1m, "hour");
				var bzt_ = context.Operators.Subtract(bzr_, bzs_);
				var bzv_ = FHIRHelpers_4_3_000.ToInterval(bzp_);
				var bzw_ = context.Operators.Start(bzv_);
				var bzx_ = context.Operators.Interval(bzt_, bzw_, true, true);
				var bzy_ = context.Operators.In<CqlDateTime>(bzo_, bzx_, null);
				var cza_ = FHIRHelpers_4_3_000.ToInterval(bzp_);
				var czb_ = context.Operators.Start(cza_);
				var czc_ = context.Operators.Not((bool?)(czb_ is null));
				var czd_ = context.Operators.And(bzy_, czc_);
				var cze_ = context.Operators.And(bzl_, czd_);

				return cze_;
			};
			var ab_ = context.Operators.Where<Encounter>(z_, aa_);
			object ac_(Encounter @this)
			{
				var czf_ = @this?.Period;
				var czg_ = FHIRHelpers_4_3_000.ToInterval(czf_);
				var czh_ = context.Operators.End(czg_);

				return czh_;
			};
			var ad_ = context.Operators.SortBy<Encounter>(ab_, ac_, System.ComponentModel.ListSortDirection.Ascending);
			var ae_ = context.Operators.Last<Encounter>(ad_);
			var af_ = ae_?.Period;
			var ag_ = FHIRHelpers_4_3_000.ToInterval(af_);
			var ah_ = context.Operators.Start(ag_);
			var ai_ = Visit?.Period;
			var aj_ = FHIRHelpers_4_3_000.ToInterval(ai_);
			var ak_ = context.Operators.Start(aj_);
			var am_ = FHIRHelpers_4_3_000.ToInterval(ai_);
			var an_ = context.Operators.End(am_);
			var ao_ = context.Operators.Interval((n_ ?? (x_ ?? (ah_ ?? ak_))), an_, true, true);

			return ao_;
		};
		var c_ = context.Operators.Select<Encounter, CqlInterval<CqlDateTime>>((IEnumerable<Encounter>)a_, b_);
		var d_ = context.Operators.SingletonFrom<CqlInterval<CqlDateTime>>(c_);

		return d_;
	}

    [CqlDeclaration("HospitalizationWithObservation")]
    [CqlTag("description", "Hospitalization with Observation returns the total interval from the start of any immediately prior emergency department visit through the observation visit to the discharge of the given encounter")]
    [CqlTag("deprecated", "This function is deprecated. Use the fluent function `hospitalizationWithObservation()` instead.")]
	public CqlInterval<CqlDateTime> HospitalizationWithObservation(Encounter TheEncounter)
	{
		var a_ = new Encounter[]
		{
			TheEncounter,
		};
		CqlInterval<CqlDateTime> b_(Encounter Visit)
		{
			var e_ = this.Emergency_Department_Visit();
			var f_ = context.Operators.RetrieveByValueSet<Encounter>(e_, null);
			bool? g_(Encounter LastED)
			{
				var af_ = LastED?.StatusElement;
				var ag_ = af_?.Value;
				var ah_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(ag_);
				var ai_ = context.Operators.Equal(ah_, "finished");
				var aj_ = LastED?.Period;
				var ak_ = FHIRHelpers_4_3_000.ToInterval(aj_);
				var al_ = context.Operators.End(ak_);
				var am_ = this.Observation_Services();
				var an_ = context.Operators.RetrieveByValueSet<Encounter>(am_, null);
				bool? ao_(Encounter LastObs)
				{
					var cg_ = LastObs?.StatusElement;
					var ch_ = cg_?.Value;
					var ci_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(ch_);
					var cj_ = context.Operators.Equal(ci_, "finished");
					var ck_ = LastObs?.Period;
					var cl_ = FHIRHelpers_4_3_000.ToInterval(ck_);
					var cm_ = context.Operators.End(cl_);
					var cn_ = Visit?.Period;
					var co_ = FHIRHelpers_4_3_000.ToInterval(cn_);
					var cp_ = context.Operators.Start(co_);
					var cq_ = context.Operators.Quantity(1m, "hour");
					var cr_ = context.Operators.Subtract(cp_, cq_);
					var ct_ = FHIRHelpers_4_3_000.ToInterval(cn_);
					var cu_ = context.Operators.Start(ct_);
					var cv_ = context.Operators.Interval(cr_, cu_, true, true);
					var cw_ = context.Operators.In<CqlDateTime>(cm_, cv_, null);
					var cy_ = FHIRHelpers_4_3_000.ToInterval(cn_);
					var cz_ = context.Operators.Start(cy_);
					var da_ = context.Operators.Not((bool?)(cz_ is null));
					var db_ = context.Operators.And(cw_, da_);
					var dc_ = context.Operators.And(cj_, db_);

					return dc_;
				};
				var ap_ = context.Operators.Where<Encounter>(an_, ao_);
				object aq_(Encounter @this)
				{
					var dd_ = @this?.Period;
					var de_ = FHIRHelpers_4_3_000.ToInterval(dd_);
					var df_ = context.Operators.End(de_);

					return df_;
				};
				var ar_ = context.Operators.SortBy<Encounter>(ap_, aq_, System.ComponentModel.ListSortDirection.Ascending);
				var as_ = context.Operators.Last<Encounter>(ar_);
				var at_ = as_?.Period;
				var au_ = FHIRHelpers_4_3_000.ToInterval(at_);
				var av_ = context.Operators.Start(au_);
				var aw_ = Visit?.Period;
				var ax_ = FHIRHelpers_4_3_000.ToInterval(aw_);
				var ay_ = context.Operators.Start(ax_);
				var az_ = context.Operators.Quantity(1m, "hour");
				var ba_ = context.Operators.Subtract((av_ ?? ay_), az_);
				var bc_ = context.Operators.RetrieveByValueSet<Encounter>(am_, null);
				bool? bd_(Encounter LastObs)
				{
					var dg_ = LastObs?.StatusElement;
					var dh_ = dg_?.Value;
					var di_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(dh_);
					var dj_ = context.Operators.Equal(di_, "finished");
					var dk_ = LastObs?.Period;
					var dl_ = FHIRHelpers_4_3_000.ToInterval(dk_);
					var dm_ = context.Operators.End(dl_);
					var dn_ = Visit?.Period;
					var do_ = FHIRHelpers_4_3_000.ToInterval(dn_);
					var dp_ = context.Operators.Start(do_);
					var dq_ = context.Operators.Quantity(1m, "hour");
					var dr_ = context.Operators.Subtract(dp_, dq_);
					var dt_ = FHIRHelpers_4_3_000.ToInterval(dn_);
					var du_ = context.Operators.Start(dt_);
					var dv_ = context.Operators.Interval(dr_, du_, true, true);
					var dw_ = context.Operators.In<CqlDateTime>(dm_, dv_, null);
					var dy_ = FHIRHelpers_4_3_000.ToInterval(dn_);
					var dz_ = context.Operators.Start(dy_);
					var ea_ = context.Operators.Not((bool?)(dz_ is null));
					var eb_ = context.Operators.And(dw_, ea_);
					var ec_ = context.Operators.And(dj_, eb_);

					return ec_;
				};
				var be_ = context.Operators.Where<Encounter>(bc_, bd_);
				object bf_(Encounter @this)
				{
					var ed_ = @this?.Period;
					var ee_ = FHIRHelpers_4_3_000.ToInterval(ed_);
					var ef_ = context.Operators.End(ee_);

					return ef_;
				};
				var bg_ = context.Operators.SortBy<Encounter>(be_, bf_, System.ComponentModel.ListSortDirection.Ascending);
				var bh_ = context.Operators.Last<Encounter>(bg_);
				var bi_ = bh_?.Period;
				var bj_ = FHIRHelpers_4_3_000.ToInterval(bi_);
				var bk_ = context.Operators.Start(bj_);
				var bm_ = FHIRHelpers_4_3_000.ToInterval(aw_);
				var bn_ = context.Operators.Start(bm_);
				var bo_ = context.Operators.Interval(ba_, (bk_ ?? bn_), true, true);
				var bp_ = context.Operators.In<CqlDateTime>(al_, bo_, null);
				var br_ = context.Operators.RetrieveByValueSet<Encounter>(am_, null);
				bool? bs_(Encounter LastObs)
				{
					var eg_ = LastObs?.StatusElement;
					var eh_ = eg_?.Value;
					var ei_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(eh_);
					var ej_ = context.Operators.Equal(ei_, "finished");
					var ek_ = LastObs?.Period;
					var el_ = FHIRHelpers_4_3_000.ToInterval(ek_);
					var em_ = context.Operators.End(el_);
					var en_ = Visit?.Period;
					var eo_ = FHIRHelpers_4_3_000.ToInterval(en_);
					var ep_ = context.Operators.Start(eo_);
					var eq_ = context.Operators.Quantity(1m, "hour");
					var er_ = context.Operators.Subtract(ep_, eq_);
					var et_ = FHIRHelpers_4_3_000.ToInterval(en_);
					var eu_ = context.Operators.Start(et_);
					var ev_ = context.Operators.Interval(er_, eu_, true, true);
					var ew_ = context.Operators.In<CqlDateTime>(em_, ev_, null);
					var ey_ = FHIRHelpers_4_3_000.ToInterval(en_);
					var ez_ = context.Operators.Start(ey_);
					var fa_ = context.Operators.Not((bool?)(ez_ is null));
					var fb_ = context.Operators.And(ew_, fa_);
					var fc_ = context.Operators.And(ej_, fb_);

					return fc_;
				};
				var bt_ = context.Operators.Where<Encounter>(br_, bs_);
				object bu_(Encounter @this)
				{
					var fd_ = @this?.Period;
					var fe_ = FHIRHelpers_4_3_000.ToInterval(fd_);
					var ff_ = context.Operators.End(fe_);

					return ff_;
				};
				var bv_ = context.Operators.SortBy<Encounter>(bt_, bu_, System.ComponentModel.ListSortDirection.Ascending);
				var bw_ = context.Operators.Last<Encounter>(bv_);
				var bx_ = bw_?.Period;
				var by_ = FHIRHelpers_4_3_000.ToInterval(bx_);
				var bz_ = context.Operators.Start(by_);
				var cb_ = FHIRHelpers_4_3_000.ToInterval(aw_);
				var cc_ = context.Operators.Start(cb_);
				var cd_ = context.Operators.Not((bool?)((bz_ ?? cc_) is null));
				var ce_ = context.Operators.And(bp_, cd_);
				var cf_ = context.Operators.And(ai_, ce_);

				return cf_;
			};
			var h_ = context.Operators.Where<Encounter>(f_, g_);
			object i_(Encounter @this)
			{
				var fg_ = @this?.Period;
				var fh_ = FHIRHelpers_4_3_000.ToInterval(fg_);
				var fi_ = context.Operators.End(fh_);

				return fi_;
			};
			var j_ = context.Operators.SortBy<Encounter>(h_, i_, System.ComponentModel.ListSortDirection.Ascending);
			var k_ = context.Operators.Last<Encounter>(j_);
			var l_ = k_?.Period;
			var m_ = FHIRHelpers_4_3_000.ToInterval(l_);
			var n_ = context.Operators.Start(m_);
			var o_ = this.Observation_Services();
			var p_ = context.Operators.RetrieveByValueSet<Encounter>(o_, null);
			bool? q_(Encounter LastObs)
			{
				var fj_ = LastObs?.StatusElement;
				var fk_ = fj_?.Value;
				var fl_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(fk_);
				var fm_ = context.Operators.Equal(fl_, "finished");
				var fn_ = LastObs?.Period;
				var fo_ = FHIRHelpers_4_3_000.ToInterval(fn_);
				var fp_ = context.Operators.End(fo_);
				var fq_ = Visit?.Period;
				var fr_ = FHIRHelpers_4_3_000.ToInterval(fq_);
				var fs_ = context.Operators.Start(fr_);
				var ft_ = context.Operators.Quantity(1m, "hour");
				var fu_ = context.Operators.Subtract(fs_, ft_);
				var fw_ = FHIRHelpers_4_3_000.ToInterval(fq_);
				var fx_ = context.Operators.Start(fw_);
				var fy_ = context.Operators.Interval(fu_, fx_, true, true);
				var fz_ = context.Operators.In<CqlDateTime>(fp_, fy_, null);
				var gb_ = FHIRHelpers_4_3_000.ToInterval(fq_);
				var gc_ = context.Operators.Start(gb_);
				var gd_ = context.Operators.Not((bool?)(gc_ is null));
				var ge_ = context.Operators.And(fz_, gd_);
				var gf_ = context.Operators.And(fm_, ge_);

				return gf_;
			};
			var r_ = context.Operators.Where<Encounter>(p_, q_);
			object s_(Encounter @this)
			{
				var gg_ = @this?.Period;
				var gh_ = FHIRHelpers_4_3_000.ToInterval(gg_);
				var gi_ = context.Operators.End(gh_);

				return gi_;
			};
			var t_ = context.Operators.SortBy<Encounter>(r_, s_, System.ComponentModel.ListSortDirection.Ascending);
			var u_ = context.Operators.Last<Encounter>(t_);
			var v_ = u_?.Period;
			var w_ = FHIRHelpers_4_3_000.ToInterval(v_);
			var x_ = context.Operators.Start(w_);
			var y_ = Visit?.Period;
			var z_ = FHIRHelpers_4_3_000.ToInterval(y_);
			var aa_ = context.Operators.Start(z_);
			var ac_ = FHIRHelpers_4_3_000.ToInterval(y_);
			var ad_ = context.Operators.End(ac_);
			var ae_ = context.Operators.Interval((n_ ?? (x_ ?? aa_)), ad_, true, true);

			return ae_;
		};
		var c_ = context.Operators.Select<Encounter, CqlInterval<CqlDateTime>>((IEnumerable<Encounter>)a_, b_);
		var d_ = context.Operators.SingletonFrom<CqlInterval<CqlDateTime>>(c_);

		return d_;
	}

    [CqlDeclaration("hospitalizationWithObservation")]
    [CqlTag("description", "Hospitalization with Observation returns the total interval from the start of any immediately prior emergency department visit through the observation visit to the discharge of the given encounter")]
	public CqlInterval<CqlDateTime> hospitalizationWithObservation(Encounter TheEncounter)
	{
		var a_ = new Encounter[]
		{
			TheEncounter,
		};
		CqlInterval<CqlDateTime> b_(Encounter Visit)
		{
			var e_ = this.Emergency_Department_Visit();
			var f_ = context.Operators.RetrieveByValueSet<Encounter>(e_, null);
			bool? g_(Encounter LastED)
			{
				var af_ = LastED?.StatusElement;
				var ag_ = af_?.Value;
				var ah_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(ag_);
				var ai_ = context.Operators.Equal(ah_, "finished");
				var aj_ = LastED?.Period;
				var ak_ = FHIRHelpers_4_3_000.ToInterval(aj_);
				var al_ = context.Operators.End(ak_);
				var am_ = this.Observation_Services();
				var an_ = context.Operators.RetrieveByValueSet<Encounter>(am_, null);
				bool? ao_(Encounter LastObs)
				{
					var cg_ = LastObs?.StatusElement;
					var ch_ = cg_?.Value;
					var ci_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(ch_);
					var cj_ = context.Operators.Equal(ci_, "finished");
					var ck_ = LastObs?.Period;
					var cl_ = FHIRHelpers_4_3_000.ToInterval(ck_);
					var cm_ = context.Operators.End(cl_);
					var cn_ = Visit?.Period;
					var co_ = FHIRHelpers_4_3_000.ToInterval(cn_);
					var cp_ = context.Operators.Start(co_);
					var cq_ = context.Operators.Quantity(1m, "hour");
					var cr_ = context.Operators.Subtract(cp_, cq_);
					var ct_ = FHIRHelpers_4_3_000.ToInterval(cn_);
					var cu_ = context.Operators.Start(ct_);
					var cv_ = context.Operators.Interval(cr_, cu_, true, true);
					var cw_ = context.Operators.In<CqlDateTime>(cm_, cv_, null);
					var cy_ = FHIRHelpers_4_3_000.ToInterval(cn_);
					var cz_ = context.Operators.Start(cy_);
					var da_ = context.Operators.Not((bool?)(cz_ is null));
					var db_ = context.Operators.And(cw_, da_);
					var dc_ = context.Operators.And(cj_, db_);

					return dc_;
				};
				var ap_ = context.Operators.Where<Encounter>(an_, ao_);
				object aq_(Encounter @this)
				{
					var dd_ = @this?.Period;
					var de_ = FHIRHelpers_4_3_000.ToInterval(dd_);
					var df_ = context.Operators.End(de_);

					return df_;
				};
				var ar_ = context.Operators.SortBy<Encounter>(ap_, aq_, System.ComponentModel.ListSortDirection.Ascending);
				var as_ = context.Operators.Last<Encounter>(ar_);
				var at_ = as_?.Period;
				var au_ = FHIRHelpers_4_3_000.ToInterval(at_);
				var av_ = context.Operators.Start(au_);
				var aw_ = Visit?.Period;
				var ax_ = FHIRHelpers_4_3_000.ToInterval(aw_);
				var ay_ = context.Operators.Start(ax_);
				var az_ = context.Operators.Quantity(1m, "hour");
				var ba_ = context.Operators.Subtract((av_ ?? ay_), az_);
				var bc_ = context.Operators.RetrieveByValueSet<Encounter>(am_, null);
				bool? bd_(Encounter LastObs)
				{
					var dg_ = LastObs?.StatusElement;
					var dh_ = dg_?.Value;
					var di_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(dh_);
					var dj_ = context.Operators.Equal(di_, "finished");
					var dk_ = LastObs?.Period;
					var dl_ = FHIRHelpers_4_3_000.ToInterval(dk_);
					var dm_ = context.Operators.End(dl_);
					var dn_ = Visit?.Period;
					var do_ = FHIRHelpers_4_3_000.ToInterval(dn_);
					var dp_ = context.Operators.Start(do_);
					var dq_ = context.Operators.Quantity(1m, "hour");
					var dr_ = context.Operators.Subtract(dp_, dq_);
					var dt_ = FHIRHelpers_4_3_000.ToInterval(dn_);
					var du_ = context.Operators.Start(dt_);
					var dv_ = context.Operators.Interval(dr_, du_, true, true);
					var dw_ = context.Operators.In<CqlDateTime>(dm_, dv_, null);
					var dy_ = FHIRHelpers_4_3_000.ToInterval(dn_);
					var dz_ = context.Operators.Start(dy_);
					var ea_ = context.Operators.Not((bool?)(dz_ is null));
					var eb_ = context.Operators.And(dw_, ea_);
					var ec_ = context.Operators.And(dj_, eb_);

					return ec_;
				};
				var be_ = context.Operators.Where<Encounter>(bc_, bd_);
				object bf_(Encounter @this)
				{
					var ed_ = @this?.Period;
					var ee_ = FHIRHelpers_4_3_000.ToInterval(ed_);
					var ef_ = context.Operators.End(ee_);

					return ef_;
				};
				var bg_ = context.Operators.SortBy<Encounter>(be_, bf_, System.ComponentModel.ListSortDirection.Ascending);
				var bh_ = context.Operators.Last<Encounter>(bg_);
				var bi_ = bh_?.Period;
				var bj_ = FHIRHelpers_4_3_000.ToInterval(bi_);
				var bk_ = context.Operators.Start(bj_);
				var bm_ = FHIRHelpers_4_3_000.ToInterval(aw_);
				var bn_ = context.Operators.Start(bm_);
				var bo_ = context.Operators.Interval(ba_, (bk_ ?? bn_), true, true);
				var bp_ = context.Operators.In<CqlDateTime>(al_, bo_, null);
				var br_ = context.Operators.RetrieveByValueSet<Encounter>(am_, null);
				bool? bs_(Encounter LastObs)
				{
					var eg_ = LastObs?.StatusElement;
					var eh_ = eg_?.Value;
					var ei_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(eh_);
					var ej_ = context.Operators.Equal(ei_, "finished");
					var ek_ = LastObs?.Period;
					var el_ = FHIRHelpers_4_3_000.ToInterval(ek_);
					var em_ = context.Operators.End(el_);
					var en_ = Visit?.Period;
					var eo_ = FHIRHelpers_4_3_000.ToInterval(en_);
					var ep_ = context.Operators.Start(eo_);
					var eq_ = context.Operators.Quantity(1m, "hour");
					var er_ = context.Operators.Subtract(ep_, eq_);
					var et_ = FHIRHelpers_4_3_000.ToInterval(en_);
					var eu_ = context.Operators.Start(et_);
					var ev_ = context.Operators.Interval(er_, eu_, true, true);
					var ew_ = context.Operators.In<CqlDateTime>(em_, ev_, null);
					var ey_ = FHIRHelpers_4_3_000.ToInterval(en_);
					var ez_ = context.Operators.Start(ey_);
					var fa_ = context.Operators.Not((bool?)(ez_ is null));
					var fb_ = context.Operators.And(ew_, fa_);
					var fc_ = context.Operators.And(ej_, fb_);

					return fc_;
				};
				var bt_ = context.Operators.Where<Encounter>(br_, bs_);
				object bu_(Encounter @this)
				{
					var fd_ = @this?.Period;
					var fe_ = FHIRHelpers_4_3_000.ToInterval(fd_);
					var ff_ = context.Operators.End(fe_);

					return ff_;
				};
				var bv_ = context.Operators.SortBy<Encounter>(bt_, bu_, System.ComponentModel.ListSortDirection.Ascending);
				var bw_ = context.Operators.Last<Encounter>(bv_);
				var bx_ = bw_?.Period;
				var by_ = FHIRHelpers_4_3_000.ToInterval(bx_);
				var bz_ = context.Operators.Start(by_);
				var cb_ = FHIRHelpers_4_3_000.ToInterval(aw_);
				var cc_ = context.Operators.Start(cb_);
				var cd_ = context.Operators.Not((bool?)((bz_ ?? cc_) is null));
				var ce_ = context.Operators.And(bp_, cd_);
				var cf_ = context.Operators.And(ai_, ce_);

				return cf_;
			};
			var h_ = context.Operators.Where<Encounter>(f_, g_);
			object i_(Encounter @this)
			{
				var fg_ = @this?.Period;
				var fh_ = FHIRHelpers_4_3_000.ToInterval(fg_);
				var fi_ = context.Operators.End(fh_);

				return fi_;
			};
			var j_ = context.Operators.SortBy<Encounter>(h_, i_, System.ComponentModel.ListSortDirection.Ascending);
			var k_ = context.Operators.Last<Encounter>(j_);
			var l_ = k_?.Period;
			var m_ = FHIRHelpers_4_3_000.ToInterval(l_);
			var n_ = context.Operators.Start(m_);
			var o_ = this.Observation_Services();
			var p_ = context.Operators.RetrieveByValueSet<Encounter>(o_, null);
			bool? q_(Encounter LastObs)
			{
				var fj_ = LastObs?.StatusElement;
				var fk_ = fj_?.Value;
				var fl_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(fk_);
				var fm_ = context.Operators.Equal(fl_, "finished");
				var fn_ = LastObs?.Period;
				var fo_ = FHIRHelpers_4_3_000.ToInterval(fn_);
				var fp_ = context.Operators.End(fo_);
				var fq_ = Visit?.Period;
				var fr_ = FHIRHelpers_4_3_000.ToInterval(fq_);
				var fs_ = context.Operators.Start(fr_);
				var ft_ = context.Operators.Quantity(1m, "hour");
				var fu_ = context.Operators.Subtract(fs_, ft_);
				var fw_ = FHIRHelpers_4_3_000.ToInterval(fq_);
				var fx_ = context.Operators.Start(fw_);
				var fy_ = context.Operators.Interval(fu_, fx_, true, true);
				var fz_ = context.Operators.In<CqlDateTime>(fp_, fy_, null);
				var gb_ = FHIRHelpers_4_3_000.ToInterval(fq_);
				var gc_ = context.Operators.Start(gb_);
				var gd_ = context.Operators.Not((bool?)(gc_ is null));
				var ge_ = context.Operators.And(fz_, gd_);
				var gf_ = context.Operators.And(fm_, ge_);

				return gf_;
			};
			var r_ = context.Operators.Where<Encounter>(p_, q_);
			object s_(Encounter @this)
			{
				var gg_ = @this?.Period;
				var gh_ = FHIRHelpers_4_3_000.ToInterval(gg_);
				var gi_ = context.Operators.End(gh_);

				return gi_;
			};
			var t_ = context.Operators.SortBy<Encounter>(r_, s_, System.ComponentModel.ListSortDirection.Ascending);
			var u_ = context.Operators.Last<Encounter>(t_);
			var v_ = u_?.Period;
			var w_ = FHIRHelpers_4_3_000.ToInterval(v_);
			var x_ = context.Operators.Start(w_);
			var y_ = Visit?.Period;
			var z_ = FHIRHelpers_4_3_000.ToInterval(y_);
			var aa_ = context.Operators.Start(z_);
			var ac_ = FHIRHelpers_4_3_000.ToInterval(y_);
			var ad_ = context.Operators.End(ac_);
			var ae_ = context.Operators.Interval((n_ ?? (x_ ?? aa_)), ad_, true, true);

			return ae_;
		};
		var c_ = context.Operators.Select<Encounter, CqlInterval<CqlDateTime>>((IEnumerable<Encounter>)a_, b_);
		var d_ = context.Operators.SingletonFrom<CqlInterval<CqlDateTime>>(c_);

		return d_;
	}

    [CqlDeclaration("HospitalizationWithObservationLengthofStay")]
    [CqlTag("description", "Hospitalization with Observation Length of Stay returns the length in days from the start of any immediately prior emergency department visit through the observation visit to the discharge of the given encounter")]
    [CqlTag("deprecated", "This function is deprecated. Use the fluent function `hospitalizationWithObservationLengthofStay()` instead.")]
	public int? HospitalizationWithObservationLengthofStay(Encounter TheEncounter)
	{
		var a_ = this.HospitalizationWithObservation(TheEncounter);
		var b_ = this.LengthInDays(a_);

		return b_;
	}

    [CqlDeclaration("hospitalizationWithObservationLengthofStay")]
    [CqlTag("description", "Hospitalization with Observation Length of Stay returns the length in days from the start of any immediately prior emergency department visit through the observation visit to the discharge of the given encounter")]
	public int? hospitalizationWithObservationLengthofStay(Encounter TheEncounter)
	{
		var a_ = this.hospitalizationWithObservation(TheEncounter);
		var b_ = this.lengthInDays(a_);

		return b_;
	}

    [CqlDeclaration("FirstInpatientIntensiveCareUnit")]
    [CqlTag("description", "First Inpatient Intensive Care Unit returns the first intensive care unit for the given encounter, without considering any immediately prior emergency department visit.")]
    [CqlTag("deprecated", "This function is deprecated. Use the fluent function `firstInpatientIntensiveCareUnit()` instead.")]
	public Encounter.LocationComponent FirstInpatientIntensiveCareUnit(Encounter Encounter)
	{
		bool? a_(Encounter.LocationComponent HospitalLocation)
		{
			var f_ = HospitalLocation?.Location;
			var g_ = this.GetLocation(f_);
			var h_ = g_?.Type;
			CqlConcept i_(CodeableConcept @this)
			{
				var s_ = FHIRHelpers_4_3_000.ToConcept(@this);

				return s_;
			};
			var j_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)h_, i_);
			var k_ = this.Intensive_Care_Unit();
			var l_ = context.Operators.ConceptsInValueSet(j_, k_);
			var m_ = Encounter?.Period;
			var n_ = FHIRHelpers_4_3_000.ToInterval(m_);
			var o_ = HospitalLocation?.Period;
			var p_ = FHIRHelpers_4_3_000.ToInterval(o_);
			var q_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(n_, p_, null);
			var r_ = context.Operators.And(l_, q_);

			return r_;
		};
		var b_ = context.Operators.Where<Encounter.LocationComponent>((IEnumerable<Encounter.LocationComponent>)Encounter?.Location, a_);
		object c_(Encounter.LocationComponent @this)
		{
			var t_ = @this?.Period;
			var u_ = FHIRHelpers_4_3_000.ToInterval(t_);
			var v_ = context.Operators.Start(u_);

			return v_;
		};
		var d_ = context.Operators.SortBy<Encounter.LocationComponent>(b_, c_, System.ComponentModel.ListSortDirection.Ascending);
		var e_ = context.Operators.First<Encounter.LocationComponent>(d_);

		return e_;
	}

    [CqlDeclaration("firstInpatientIntensiveCareUnit")]
    [CqlTag("description", "First Inpatient Intensive Care Unit returns the first intensive care unit for the given encounter, without considering any immediately prior emergency department visit.")]
	public Encounter.LocationComponent firstInpatientIntensiveCareUnit(Encounter Encounter)
	{
		bool? a_(Encounter.LocationComponent HospitalLocation)
		{
			var f_ = HospitalLocation?.Location;
			var g_ = this.GetLocation(f_);
			var h_ = g_?.Type;
			CqlConcept i_(CodeableConcept @this)
			{
				var s_ = FHIRHelpers_4_3_000.ToConcept(@this);

				return s_;
			};
			var j_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)h_, i_);
			var k_ = this.Intensive_Care_Unit();
			var l_ = context.Operators.ConceptsInValueSet(j_, k_);
			var m_ = Encounter?.Period;
			var n_ = FHIRHelpers_4_3_000.ToInterval(m_);
			var o_ = HospitalLocation?.Period;
			var p_ = FHIRHelpers_4_3_000.ToInterval(o_);
			var q_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(n_, p_, null);
			var r_ = context.Operators.And(l_, q_);

			return r_;
		};
		var b_ = context.Operators.Where<Encounter.LocationComponent>((IEnumerable<Encounter.LocationComponent>)Encounter?.Location, a_);
		object c_(Encounter.LocationComponent @this)
		{
			var t_ = @this?.Period;
			var u_ = FHIRHelpers_4_3_000.ToInterval(t_);
			var v_ = context.Operators.Start(u_);

			return v_;
		};
		var d_ = context.Operators.SortBy<Encounter.LocationComponent>(b_, c_, System.ComponentModel.ListSortDirection.Ascending);
		var e_ = context.Operators.First<Encounter.LocationComponent>(d_);

		return e_;
	}

    [CqlDeclaration("EncounterDiagnosis")]
    [CqlTag("description", "Returns the Condition resource referenced by the `diagnosis.condition` element of the Encounter")]
    [CqlTag("deprecated", "This function is deprecated. Use the fluent function `encounterDiagnosis()` instead.")]
	public IEnumerable<Condition> EncounterDiagnosis(Encounter Encounter)
	{
		Condition a_(Encounter.DiagnosisComponent D)
		{
			var c_ = context.Operators.RetrieveByValueSet<Condition>(null, null);
			bool? d_(Condition C)
			{
				var g_ = C?.IdElement;
				var h_ = g_?.Value;
				var i_ = D?.Condition;
				var j_ = i_?.ReferenceElement;
				var k_ = j_?.Value;
				var l_ = QICoreCommon_2_0_000.getId(k_);
				var m_ = context.Operators.Equal(h_, l_);

				return m_;
			};
			var e_ = context.Operators.Where<Condition>(c_, d_);
			var f_ = context.Operators.SingletonFrom<Condition>(e_);

			return f_;
		};
		var b_ = context.Operators.Select<Encounter.DiagnosisComponent, Condition>((IEnumerable<Encounter.DiagnosisComponent>)Encounter?.Diagnosis, a_);

		return b_;
	}

    [CqlDeclaration("encounterDiagnosis")]
    [CqlTag("description", "Returns the Condition resources referenced by the diagnosis element of the Encounter")]
	public IEnumerable<Condition> encounterDiagnosis(Encounter Encounter)
	{
		Condition a_(Encounter.DiagnosisComponent D)
		{
			var c_ = context.Operators.RetrieveByValueSet<Condition>(null, null);
			bool? d_(Condition C)
			{
				var g_ = C?.IdElement;
				var h_ = g_?.Value;
				var i_ = D?.Condition;
				var j_ = i_?.ReferenceElement;
				var k_ = j_?.Value;
				var l_ = QICoreCommon_2_0_000.getId(k_);
				var m_ = context.Operators.Equal(h_, l_);

				return m_;
			};
			var e_ = context.Operators.Where<Condition>(c_, d_);
			var f_ = context.Operators.SingletonFrom<Condition>(e_);

			return f_;
		};
		var b_ = context.Operators.Select<Encounter.DiagnosisComponent, Condition>((IEnumerable<Encounter.DiagnosisComponent>)Encounter?.Diagnosis, a_);

		return b_;
	}

    [CqlDeclaration("GetCondition")]
    [CqlTag("description", "Returns the Condition resource for the given reference")]
    [CqlTag("deprecated", "This function is deprecated. Use the fluent function `getCondition()` instead")]
	public Condition GetCondition(ResourceReference reference)
	{
		var a_ = context.Operators.RetrieveByValueSet<Condition>(null, null);
		bool? b_(Condition C)
		{
			var e_ = C?.IdElement;
			var f_ = e_?.Value;
			var g_ = reference?.ReferenceElement;
			var h_ = g_?.Value;
			var i_ = QICoreCommon_2_0_000.getId(h_);
			var j_ = context.Operators.Equal(f_, i_);

			return j_;
		};
		var c_ = context.Operators.Where<Condition>(a_, b_);
		var d_ = context.Operators.SingletonFrom<Condition>(c_);

		return d_;
	}

    [CqlDeclaration("getCondition")]
    [CqlTag("description", "Returns the Condition resource for the given reference")]
	public Condition getCondition(ResourceReference reference)
	{
		var a_ = context.Operators.RetrieveByValueSet<Condition>(null, null);
		bool? b_(Condition C)
		{
			var e_ = C?.IdElement;
			var f_ = e_?.Value;
			var g_ = reference?.ReferenceElement;
			var h_ = g_?.Value;
			var i_ = QICoreCommon_2_0_000.getId(h_);
			var j_ = context.Operators.Equal(f_, i_);

			return j_;
		};
		var c_ = context.Operators.Where<Condition>(a_, b_);
		var d_ = context.Operators.SingletonFrom<Condition>(c_);

		return d_;
	}

    [CqlDeclaration("PrincipalDiagnosis")]
    [CqlTag("description", "Returns the condition that is specified as the principal diagnosis for the encounter")]
    [CqlTag("deprecated", "This function is deprecated. Use the fluent function `principalDiagnosis()` instead.")]
	public Condition PrincipalDiagnosis(Encounter Encounter)
	{
		bool? a_(Encounter.DiagnosisComponent D)
		{
			var f_ = D?.RankElement;
			var g_ = f_?.Value;
			var h_ = context.Operators.Equal(g_, 1);

			return h_;
		};
		var b_ = context.Operators.Where<Encounter.DiagnosisComponent>((IEnumerable<Encounter.DiagnosisComponent>)Encounter?.Diagnosis, a_);
		Condition c_(Encounter.DiagnosisComponent PD)
		{
			var i_ = context.Operators.RetrieveByValueSet<Condition>(null, null);
			bool? j_(Condition C)
			{
				var m_ = C?.IdElement;
				var n_ = m_?.Value;
				var o_ = PD?.Condition;
				var p_ = o_?.ReferenceElement;
				var q_ = p_?.Value;
				var r_ = QICoreCommon_2_0_000.getId(q_);
				var s_ = context.Operators.Equal(n_, r_);

				return s_;
			};
			var k_ = context.Operators.Where<Condition>(i_, j_);
			var l_ = context.Operators.SingletonFrom<Condition>(k_);

			return l_;
		};
		var d_ = context.Operators.Select<Encounter.DiagnosisComponent, Condition>(b_, c_);
		var e_ = context.Operators.SingletonFrom<Condition>(d_);

		return e_;
	}

    [CqlDeclaration("principalDiagnosis")]
    [CqlTag("description", "Returns the condition that is specified as the principal diagnosis for the encounter")]
	public Condition principalDiagnosis(Encounter Encounter)
	{
		bool? a_(Encounter.DiagnosisComponent D)
		{
			var f_ = D?.RankElement;
			var g_ = f_?.Value;
			var h_ = context.Operators.Equal(g_, 1);

			return h_;
		};
		var b_ = context.Operators.Where<Encounter.DiagnosisComponent>((IEnumerable<Encounter.DiagnosisComponent>)Encounter?.Diagnosis, a_);
		Condition c_(Encounter.DiagnosisComponent PD)
		{
			var i_ = context.Operators.RetrieveByValueSet<Condition>(null, null);
			bool? j_(Condition C)
			{
				var m_ = C?.IdElement;
				var n_ = m_?.Value;
				var o_ = PD?.Condition;
				var p_ = o_?.ReferenceElement;
				var q_ = p_?.Value;
				var r_ = QICoreCommon_2_0_000.getId(q_);
				var s_ = context.Operators.Equal(n_, r_);

				return s_;
			};
			var k_ = context.Operators.Where<Condition>(i_, j_);
			var l_ = context.Operators.SingletonFrom<Condition>(k_);

			return l_;
		};
		var d_ = context.Operators.Select<Encounter.DiagnosisComponent, Condition>(b_, c_);
		var e_ = context.Operators.SingletonFrom<Condition>(d_);

		return e_;
	}

    [CqlDeclaration("getLocation")]
    [CqlTag("description", "Returns the Location resource specified by the given reference.")]
	public Location getLocation(ResourceReference reference)
	{
		var a_ = context.Operators.RetrieveByValueSet<Location>(null, null);
		bool? b_(Location L)
		{
			var e_ = L?.IdElement;
			var f_ = e_?.Value;
			var g_ = reference?.ReferenceElement;
			var h_ = g_?.Value;
			var i_ = QICoreCommon_2_0_000.getId(h_);
			var j_ = context.Operators.Equal(f_, i_);

			return j_;
		};
		var c_ = context.Operators.Where<Location>(a_, b_);
		var d_ = context.Operators.SingletonFrom<Location>(c_);

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
				var c_ = request?.Medication;
				var d_ = FHIRHelpers_4_3_000.ToValue(c_);
				var e_ = d_ is CqlConcept;

				return e_;
			};
			if (b_())
			{
				var f_ = request?.Medication;
				var g_ = FHIRHelpers_4_3_000.ToValue(f_);

				return (g_ as CqlConcept);
			}
			else
			{
				var h_ = context.Operators.RetrieveByValueSet<Medication>(null, null);
				bool? i_(Medication M)
				{
					var m_ = M?.IdElement;
					var n_ = m_?.Value;
					var o_ = request?.Medication;
					var p_ = FHIRHelpers_4_3_000.ToValue(o_);
					var q_ = (p_ as ResourceReference)?.ReferenceElement;
					var r_ = q_?.Value;
					var s_ = QICoreCommon_2_0_000.getId(r_);
					var t_ = context.Operators.Equal(n_, s_);

					return t_;
				};
				var j_ = context.Operators.Where<Medication>(h_, i_);
				var k_ = context.Operators.SingletonFrom<Medication>(j_);
				var l_ = FHIRHelpers_4_3_000.ToConcept(k_?.Code);

				return l_;
			}
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
				var c_ = request?.Medication;
				var d_ = FHIRHelpers_4_3_000.ToValue(c_);
				var e_ = d_ is CqlConcept;

				return e_;
			};
			if (b_())
			{
				var f_ = request?.Medication;
				var g_ = FHIRHelpers_4_3_000.ToValue(f_);

				return (g_ as CqlConcept);
			}
			else
			{
				var h_ = context.Operators.RetrieveByValueSet<Medication>(null, null);
				bool? i_(Medication M)
				{
					var m_ = M?.IdElement;
					var n_ = m_?.Value;
					var o_ = request?.Medication;
					var p_ = FHIRHelpers_4_3_000.ToValue(o_);
					var q_ = (p_ as ResourceReference)?.ReferenceElement;
					var r_ = q_?.Value;
					var s_ = QICoreCommon_2_0_000.getId(r_);
					var t_ = context.Operators.Equal(n_, s_);

					return t_;
				};
				var j_ = context.Operators.Where<Medication>(h_, i_);
				var k_ = context.Operators.SingletonFrom<Medication>(j_);
				var l_ = FHIRHelpers_4_3_000.ToConcept(k_?.Code);

				return l_;
			}
		};

		return a_();
	}

}
