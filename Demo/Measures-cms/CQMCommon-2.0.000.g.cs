using System;
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
		var a_ = context.Operators.DateTime((int?)2025, (int?)1, (int?)1, (int?)0, (int?)0, (int?)0, (int?)0, default);
		var b_ = context.Operators.DateTime((int?)2026, (int?)1, (int?)1, (int?)0, (int?)0, (int?)0, (int?)0, default);
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
		var b_ = context.Operators.SingleOrNull<Patient>(a_);

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
			var e_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(EncounterInpatient?.StatusElement?.Value);
			var f_ = context.Operators.Equal(e_, "finished");
			var g_ = FHIRHelpers_4_3_000.ToInterval(EncounterInpatient?.Period);
			var h_ = context.Operators.End(g_);
			var i_ = this.Measurement_Period();
			var j_ = context.Operators.ElementInInterval<CqlDateTime>(h_, i_, "day");
			var k_ = context.Operators.And(f_, j_);

			return k_;
		};
		var d_ = context.Operators.WhereOrNull<Encounter>(b_, c_);

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
			var h_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(EDVisit?.StatusElement?.Value);
			var i_ = context.Operators.Equal(h_, "finished");
			var j_ = FHIRHelpers_4_3_000.ToInterval(EDVisit?.Period);
			var k_ = context.Operators.End(j_);
			var l_ = FHIRHelpers_4_3_000.ToInterval(TheEncounter?.Period);
			var m_ = context.Operators.Start(l_);
			var n_ = context.Operators.Quantity((decimal?)1m, "hour");
			var o_ = context.Operators.Subtract(m_, n_);
			var q_ = context.Operators.Start(l_);
			var r_ = context.Operators.Interval(o_, q_, true, true);
			var s_ = context.Operators.ElementInInterval<CqlDateTime>(k_, r_, null);
			var u_ = context.Operators.Start(l_);
			var v_ = context.Operators.Not((bool?)(u_ is null));
			var w_ = context.Operators.And(s_, v_);
			var x_ = context.Operators.And(i_, w_);

			return x_;
		};
		var d_ = context.Operators.WhereOrNull<Encounter>(b_, c_);
		object e_(Encounter @this)
		{
			var y_ = FHIRHelpers_4_3_000.ToInterval(@this?.Period);
			var z_ = context.Operators.End(y_);

			return z_;
		};
		var f_ = context.Operators.ListSortBy<Encounter>(d_, e_, System.ComponentModel.ListSortDirection.Ascending);
		var g_ = context.Operators.LastOfList<Encounter>(f_);

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
			var h_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(EDVisit?.StatusElement?.Value);
			var i_ = context.Operators.Equal(h_, "finished");
			var j_ = FHIRHelpers_4_3_000.ToInterval(EDVisit?.Period);
			var k_ = context.Operators.End(j_);
			var l_ = FHIRHelpers_4_3_000.ToInterval(TheEncounter?.Period);
			var m_ = context.Operators.Start(l_);
			var n_ = context.Operators.Quantity((decimal?)1m, "hour");
			var o_ = context.Operators.Subtract(m_, n_);
			var q_ = context.Operators.Start(l_);
			var r_ = context.Operators.Interval(o_, q_, true, true);
			var s_ = context.Operators.ElementInInterval<CqlDateTime>(k_, r_, null);
			var u_ = context.Operators.Start(l_);
			var v_ = context.Operators.Not((bool?)(u_ is null));
			var w_ = context.Operators.And(s_, v_);
			var x_ = context.Operators.And(i_, w_);

			return x_;
		};
		var d_ = context.Operators.WhereOrNull<Encounter>(b_, c_);
		object e_(Encounter @this)
		{
			var y_ = FHIRHelpers_4_3_000.ToInterval(@this?.Period);
			var z_ = context.Operators.End(y_);

			return z_;
		};
		var f_ = context.Operators.ListSortBy<Encounter>(d_, e_, System.ComponentModel.ListSortDirection.Ascending);
		var g_ = context.Operators.LastOfList<Encounter>(f_);

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
					var g_ = FHIRHelpers_4_3_000.ToInterval(TheEncounter?.Period);

					return g_;
				}
				else
				{
					var h_ = FHIRHelpers_4_3_000.ToInterval(X?.Period);
					var i_ = context.Operators.Start(h_);
					var j_ = FHIRHelpers_4_3_000.ToInterval(TheEncounter?.Period);
					var k_ = context.Operators.End(j_);
					var l_ = context.Operators.Interval(i_, k_, true, false);

					return l_;
				};
			};

			return f_();
		};
		var d_ = context.Operators.SelectOrNull<Encounter, CqlInterval<CqlDateTime>>(b_, c_);
		var e_ = context.Operators.SingleOrNull<CqlInterval<CqlDateTime>>(d_);

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
					var g_ = FHIRHelpers_4_3_000.ToInterval(TheEncounter?.Period);

					return g_;
				}
				else
				{
					var h_ = FHIRHelpers_4_3_000.ToInterval(X?.Period);
					var i_ = context.Operators.Start(h_);
					var j_ = FHIRHelpers_4_3_000.ToInterval(TheEncounter?.Period);
					var k_ = context.Operators.End(j_);
					var l_ = context.Operators.Interval(i_, k_, true, true);

					return l_;
				};
			};

			return f_();
		};
		var d_ = context.Operators.SelectOrNull<Encounter, CqlInterval<CqlDateTime>>(b_, c_);
		var e_ = context.Operators.SingleOrNull<CqlInterval<CqlDateTime>>(d_);

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
					return (TheEncounter?.Location as IEnumerable<Encounter.LocationComponent>);
				}
				else
				{
					var g_ = new IEnumerable<Encounter.LocationComponent>[]
					{
						(EDEncounter?.Location as IEnumerable<Encounter.LocationComponent>),
						(TheEncounter?.Location as IEnumerable<Encounter.LocationComponent>),
					};
					var h_ = context.Operators.FlattenList<Encounter.LocationComponent>((g_ as IEnumerable<IEnumerable<Encounter.LocationComponent>>));

					return h_;
				};
			};

			return f_();
		};
		var d_ = context.Operators.SelectOrNull<Encounter, IEnumerable<Encounter.LocationComponent>>(b_, c_);
		var e_ = context.Operators.SingleOrNull<IEnumerable<Encounter.LocationComponent>>(d_);

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
					return (TheEncounter?.Location as IEnumerable<Encounter.LocationComponent>);
				}
				else
				{
					var g_ = new IEnumerable<Encounter.LocationComponent>[]
					{
						(EDEncounter?.Location as IEnumerable<Encounter.LocationComponent>),
						(TheEncounter?.Location as IEnumerable<Encounter.LocationComponent>),
					};
					var h_ = context.Operators.FlattenList<Encounter.LocationComponent>((g_ as IEnumerable<IEnumerable<Encounter.LocationComponent>>));

					return h_;
				};
			};

			return f_();
		};
		var d_ = context.Operators.SelectOrNull<Encounter, IEnumerable<Encounter.LocationComponent>>(b_, c_);
		var e_ = context.Operators.SingleOrNull<IEnumerable<Encounter.LocationComponent>>(d_);

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
			var g_ = FHIRHelpers_4_3_000.ToInterval(@this?.Period);
			var h_ = context.Operators.Start(g_);

			return h_;
		};
		var c_ = context.Operators.ListSortBy<Encounter.LocationComponent>(a_, b_, System.ComponentModel.ListSortDirection.Ascending);
		var d_ = context.Operators.FirstOfList<Encounter.LocationComponent>(c_);
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
			var g_ = FHIRHelpers_4_3_000.ToInterval(@this?.Period);
			var h_ = context.Operators.Start(g_);

			return h_;
		};
		var c_ = context.Operators.ListSortBy<Encounter.LocationComponent>(a_, b_, System.ComponentModel.ListSortDirection.Ascending);
		var d_ = context.Operators.FirstOfList<Encounter.LocationComponent>(c_);
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
			var g_ = FHIRHelpers_4_3_000.ToInterval(@this?.Period);
			var h_ = context.Operators.Start(g_);

			return h_;
		};
		var c_ = context.Operators.ListSortBy<Encounter.LocationComponent>(a_, b_, System.ComponentModel.ListSortDirection.Ascending);
		var d_ = context.Operators.LastOfList<Encounter.LocationComponent>(c_);
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
			var g_ = FHIRHelpers_4_3_000.ToInterval(@this?.Period);
			var h_ = context.Operators.Start(g_);

			return h_;
		};
		var c_ = context.Operators.ListSortBy<Encounter.LocationComponent>(a_, b_, System.ComponentModel.ListSortDirection.Ascending);
		var d_ = context.Operators.LastOfList<Encounter.LocationComponent>(c_);
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
			var e_ = QICoreCommon_2_0_000.getId(reference?.ReferenceElement?.Value);
			var f_ = context.Operators.Equal(L?.IdElement?.Value, e_);

			return f_;
		};
		var c_ = context.Operators.WhereOrNull<Location>(a_, b_);
		var d_ = context.Operators.SingleOrNull<Location>(c_);

		return d_;
	}

    [CqlDeclaration("Emergency Department Arrival Time")]
    [CqlTag("description", "Returns the emergency department arrival time for the encounter.")]
	public CqlDateTime Emergency_Department_Arrival_Time(Encounter TheEncounter)
	{
		var a_ = this.Hospitalization_Locations(TheEncounter);
		bool? b_(Encounter.LocationComponent HospitalLocation)
		{
			var g_ = this.GetLocation(HospitalLocation?.Location);
			CqlConcept h_(CodeableConcept @this)
			{
				var l_ = FHIRHelpers_4_3_000.ToConcept(@this);

				return l_;
			};
			var i_ = context.Operators.SelectOrNull<CodeableConcept, CqlConcept>(g_?.Type, h_);
			var j_ = this.Emergency_Department_Visit();
			var k_ = context.Operators.ConceptsInValueSet(i_, j_);

			return k_;
		};
		var c_ = context.Operators.WhereOrNull<Encounter.LocationComponent>(a_, b_);
		var d_ = context.Operators.SingleOrNull<Encounter.LocationComponent>(c_);
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
			var g_ = this.GetLocation(HospitalLocation?.Location);
			CqlConcept h_(CodeableConcept @this)
			{
				var l_ = FHIRHelpers_4_3_000.ToConcept(@this);

				return l_;
			};
			var i_ = context.Operators.SelectOrNull<CodeableConcept, CqlConcept>(g_?.Type, h_);
			var j_ = this.Emergency_Department_Visit();
			var k_ = context.Operators.ConceptsInValueSet(i_, j_);

			return k_;
		};
		var c_ = context.Operators.WhereOrNull<Encounter.LocationComponent>(a_, b_);
		var d_ = context.Operators.SingleOrNull<Encounter.LocationComponent>(c_);
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
				var ak_ = FHIRHelpers_4_3_000.ToInterval(LastSurgeryOP?.Period);
				var al_ = context.Operators.End(ak_);
				var am_ = this.Emergency_Department_Visit();
				var an_ = context.Operators.RetrieveByValueSet<Encounter>(am_, null);
				bool? ao_(Encounter LastED)
				{
					var da_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(LastED?.StatusElement?.Value);
					var db_ = context.Operators.Equal(da_, "finished");
					var dc_ = FHIRHelpers_4_3_000.ToInterval(LastED?.Period);
					var dd_ = context.Operators.End(dc_);
					var de_ = this.Observation_Services();
					var df_ = context.Operators.RetrieveByValueSet<Encounter>(de_, null);
					bool? dg_(Encounter LastObs)
					{
						var es_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(LastObs?.StatusElement?.Value);
						var et_ = context.Operators.Equal(es_, "finished");
						var eu_ = FHIRHelpers_4_3_000.ToInterval(LastObs?.Period);
						var ev_ = context.Operators.End(eu_);
						var ew_ = FHIRHelpers_4_3_000.ToInterval(Visit?.Period);
						var ex_ = context.Operators.Start(ew_);
						var ey_ = context.Operators.Quantity((decimal?)1m, "hour");
						var ez_ = context.Operators.Subtract(ex_, ey_);
						var fb_ = context.Operators.Start(ew_);
						var fc_ = context.Operators.Interval(ez_, fb_, true, true);
						var fd_ = context.Operators.ElementInInterval<CqlDateTime>(ev_, fc_, null);
						var ff_ = context.Operators.Start(ew_);
						var fg_ = context.Operators.Not((bool?)(ff_ is null));
						var fh_ = context.Operators.And(fd_, fg_);
						var fi_ = context.Operators.And(et_, fh_);

						return fi_;
					};
					var dh_ = context.Operators.WhereOrNull<Encounter>(df_, dg_);
					object di_(Encounter @this)
					{
						var fj_ = FHIRHelpers_4_3_000.ToInterval(@this?.Period);
						var fk_ = context.Operators.End(fj_);

						return fk_;
					};
					var dj_ = context.Operators.ListSortBy<Encounter>(dh_, di_, System.ComponentModel.ListSortDirection.Ascending);
					var dk_ = context.Operators.LastOfList<Encounter>(dj_);
					var dl_ = FHIRHelpers_4_3_000.ToInterval(dk_?.Period);
					var dm_ = context.Operators.Start(dl_);
					var dn_ = FHIRHelpers_4_3_000.ToInterval(Visit?.Period);
					var do_ = context.Operators.Start(dn_);
					var dp_ = context.Operators.Quantity((decimal?)1m, "hour");
					var dq_ = context.Operators.Subtract((dm_ ?? do_), dp_);
					var ds_ = context.Operators.RetrieveByValueSet<Encounter>(de_, null);
					bool? dt_(Encounter LastObs)
					{
						var fl_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(LastObs?.StatusElement?.Value);
						var fm_ = context.Operators.Equal(fl_, "finished");
						var fn_ = FHIRHelpers_4_3_000.ToInterval(LastObs?.Period);
						var fo_ = context.Operators.End(fn_);
						var fp_ = FHIRHelpers_4_3_000.ToInterval(Visit?.Period);
						var fq_ = context.Operators.Start(fp_);
						var fr_ = context.Operators.Quantity((decimal?)1m, "hour");
						var fs_ = context.Operators.Subtract(fq_, fr_);
						var fu_ = context.Operators.Start(fp_);
						var fv_ = context.Operators.Interval(fs_, fu_, true, true);
						var fw_ = context.Operators.ElementInInterval<CqlDateTime>(fo_, fv_, null);
						var fy_ = context.Operators.Start(fp_);
						var fz_ = context.Operators.Not((bool?)(fy_ is null));
						var ga_ = context.Operators.And(fw_, fz_);
						var gb_ = context.Operators.And(fm_, ga_);

						return gb_;
					};
					var du_ = context.Operators.WhereOrNull<Encounter>(ds_, dt_);
					object dv_(Encounter @this)
					{
						var gc_ = FHIRHelpers_4_3_000.ToInterval(@this?.Period);
						var gd_ = context.Operators.End(gc_);

						return gd_;
					};
					var dw_ = context.Operators.ListSortBy<Encounter>(du_, dv_, System.ComponentModel.ListSortDirection.Ascending);
					var dx_ = context.Operators.LastOfList<Encounter>(dw_);
					var dy_ = FHIRHelpers_4_3_000.ToInterval(dx_?.Period);
					var dz_ = context.Operators.Start(dy_);
					var eb_ = context.Operators.Start(dn_);
					var ec_ = context.Operators.Interval(dq_, (dz_ ?? eb_), true, true);
					var ed_ = context.Operators.ElementInInterval<CqlDateTime>(dd_, ec_, null);
					var ef_ = context.Operators.RetrieveByValueSet<Encounter>(de_, null);
					bool? eg_(Encounter LastObs)
					{
						var ge_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(LastObs?.StatusElement?.Value);
						var gf_ = context.Operators.Equal(ge_, "finished");
						var gg_ = FHIRHelpers_4_3_000.ToInterval(LastObs?.Period);
						var gh_ = context.Operators.End(gg_);
						var gi_ = FHIRHelpers_4_3_000.ToInterval(Visit?.Period);
						var gj_ = context.Operators.Start(gi_);
						var gk_ = context.Operators.Quantity((decimal?)1m, "hour");
						var gl_ = context.Operators.Subtract(gj_, gk_);
						var gn_ = context.Operators.Start(gi_);
						var go_ = context.Operators.Interval(gl_, gn_, true, true);
						var gp_ = context.Operators.ElementInInterval<CqlDateTime>(gh_, go_, null);
						var gr_ = context.Operators.Start(gi_);
						var gs_ = context.Operators.Not((bool?)(gr_ is null));
						var gt_ = context.Operators.And(gp_, gs_);
						var gu_ = context.Operators.And(gf_, gt_);

						return gu_;
					};
					var eh_ = context.Operators.WhereOrNull<Encounter>(ef_, eg_);
					object ei_(Encounter @this)
					{
						var gv_ = FHIRHelpers_4_3_000.ToInterval(@this?.Period);
						var gw_ = context.Operators.End(gv_);

						return gw_;
					};
					var ej_ = context.Operators.ListSortBy<Encounter>(eh_, ei_, System.ComponentModel.ListSortDirection.Ascending);
					var ek_ = context.Operators.LastOfList<Encounter>(ej_);
					var el_ = FHIRHelpers_4_3_000.ToInterval(ek_?.Period);
					var em_ = context.Operators.Start(el_);
					var eo_ = context.Operators.Start(dn_);
					var ep_ = context.Operators.Not((bool?)((em_ ?? eo_) is null));
					var eq_ = context.Operators.And(ed_, ep_);
					var er_ = context.Operators.And(db_, eq_);

					return er_;
				};
				var ap_ = context.Operators.WhereOrNull<Encounter>(an_, ao_);
				object aq_(Encounter @this)
				{
					var gx_ = FHIRHelpers_4_3_000.ToInterval(@this?.Period);
					var gy_ = context.Operators.End(gx_);

					return gy_;
				};
				var ar_ = context.Operators.ListSortBy<Encounter>(ap_, aq_, System.ComponentModel.ListSortDirection.Ascending);
				var as_ = context.Operators.LastOfList<Encounter>(ar_);
				var at_ = FHIRHelpers_4_3_000.ToInterval(as_?.Period);
				var au_ = context.Operators.Start(at_);
				var av_ = this.Observation_Services();
				var aw_ = context.Operators.RetrieveByValueSet<Encounter>(av_, null);
				bool? ax_(Encounter LastObs)
				{
					var gz_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(LastObs?.StatusElement?.Value);
					var ha_ = context.Operators.Equal(gz_, "finished");
					var hb_ = FHIRHelpers_4_3_000.ToInterval(LastObs?.Period);
					var hc_ = context.Operators.End(hb_);
					var hd_ = FHIRHelpers_4_3_000.ToInterval(Visit?.Period);
					var he_ = context.Operators.Start(hd_);
					var hf_ = context.Operators.Quantity((decimal?)1m, "hour");
					var hg_ = context.Operators.Subtract(he_, hf_);
					var hi_ = context.Operators.Start(hd_);
					var hj_ = context.Operators.Interval(hg_, hi_, true, true);
					var hk_ = context.Operators.ElementInInterval<CqlDateTime>(hc_, hj_, null);
					var hm_ = context.Operators.Start(hd_);
					var hn_ = context.Operators.Not((bool?)(hm_ is null));
					var ho_ = context.Operators.And(hk_, hn_);
					var hp_ = context.Operators.And(ha_, ho_);

					return hp_;
				};
				var ay_ = context.Operators.WhereOrNull<Encounter>(aw_, ax_);
				object az_(Encounter @this)
				{
					var hq_ = FHIRHelpers_4_3_000.ToInterval(@this?.Period);
					var hr_ = context.Operators.End(hq_);

					return hr_;
				};
				var ba_ = context.Operators.ListSortBy<Encounter>(ay_, az_, System.ComponentModel.ListSortDirection.Ascending);
				var bb_ = context.Operators.LastOfList<Encounter>(ba_);
				var bc_ = FHIRHelpers_4_3_000.ToInterval(bb_?.Period);
				var bd_ = context.Operators.Start(bc_);
				var be_ = FHIRHelpers_4_3_000.ToInterval(Visit?.Period);
				var bf_ = context.Operators.Start(be_);
				var bg_ = context.Operators.Quantity((decimal?)1m, "hour");
				var bh_ = context.Operators.Subtract((au_ ?? (bd_ ?? bf_)), bg_);
				var bj_ = context.Operators.RetrieveByValueSet<Encounter>(am_, null);
				bool? bk_(Encounter LastED)
				{
					var hs_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(LastED?.StatusElement?.Value);
					var ht_ = context.Operators.Equal(hs_, "finished");
					var hu_ = FHIRHelpers_4_3_000.ToInterval(LastED?.Period);
					var hv_ = context.Operators.End(hu_);
					var hw_ = this.Observation_Services();
					var hx_ = context.Operators.RetrieveByValueSet<Encounter>(hw_, null);
					bool? hy_(Encounter LastObs)
					{
						var jk_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(LastObs?.StatusElement?.Value);
						var jl_ = context.Operators.Equal(jk_, "finished");
						var jm_ = FHIRHelpers_4_3_000.ToInterval(LastObs?.Period);
						var jn_ = context.Operators.End(jm_);
						var jo_ = FHIRHelpers_4_3_000.ToInterval(Visit?.Period);
						var jp_ = context.Operators.Start(jo_);
						var jq_ = context.Operators.Quantity((decimal?)1m, "hour");
						var jr_ = context.Operators.Subtract(jp_, jq_);
						var jt_ = context.Operators.Start(jo_);
						var ju_ = context.Operators.Interval(jr_, jt_, true, true);
						var jv_ = context.Operators.ElementInInterval<CqlDateTime>(jn_, ju_, null);
						var jx_ = context.Operators.Start(jo_);
						var jy_ = context.Operators.Not((bool?)(jx_ is null));
						var jz_ = context.Operators.And(jv_, jy_);
						var ka_ = context.Operators.And(jl_, jz_);

						return ka_;
					};
					var hz_ = context.Operators.WhereOrNull<Encounter>(hx_, hy_);
					object ia_(Encounter @this)
					{
						var kb_ = FHIRHelpers_4_3_000.ToInterval(@this?.Period);
						var kc_ = context.Operators.End(kb_);

						return kc_;
					};
					var ib_ = context.Operators.ListSortBy<Encounter>(hz_, ia_, System.ComponentModel.ListSortDirection.Ascending);
					var ic_ = context.Operators.LastOfList<Encounter>(ib_);
					var id_ = FHIRHelpers_4_3_000.ToInterval(ic_?.Period);
					var ie_ = context.Operators.Start(id_);
					var if_ = FHIRHelpers_4_3_000.ToInterval(Visit?.Period);
					var ig_ = context.Operators.Start(if_);
					var ih_ = context.Operators.Quantity((decimal?)1m, "hour");
					var ii_ = context.Operators.Subtract((ie_ ?? ig_), ih_);
					var ik_ = context.Operators.RetrieveByValueSet<Encounter>(hw_, null);
					bool? il_(Encounter LastObs)
					{
						var kd_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(LastObs?.StatusElement?.Value);
						var ke_ = context.Operators.Equal(kd_, "finished");
						var kf_ = FHIRHelpers_4_3_000.ToInterval(LastObs?.Period);
						var kg_ = context.Operators.End(kf_);
						var kh_ = FHIRHelpers_4_3_000.ToInterval(Visit?.Period);
						var ki_ = context.Operators.Start(kh_);
						var kj_ = context.Operators.Quantity((decimal?)1m, "hour");
						var kk_ = context.Operators.Subtract(ki_, kj_);
						var km_ = context.Operators.Start(kh_);
						var kn_ = context.Operators.Interval(kk_, km_, true, true);
						var ko_ = context.Operators.ElementInInterval<CqlDateTime>(kg_, kn_, null);
						var kq_ = context.Operators.Start(kh_);
						var kr_ = context.Operators.Not((bool?)(kq_ is null));
						var ks_ = context.Operators.And(ko_, kr_);
						var kt_ = context.Operators.And(ke_, ks_);

						return kt_;
					};
					var im_ = context.Operators.WhereOrNull<Encounter>(ik_, il_);
					object in_(Encounter @this)
					{
						var ku_ = FHIRHelpers_4_3_000.ToInterval(@this?.Period);
						var kv_ = context.Operators.End(ku_);

						return kv_;
					};
					var io_ = context.Operators.ListSortBy<Encounter>(im_, in_, System.ComponentModel.ListSortDirection.Ascending);
					var ip_ = context.Operators.LastOfList<Encounter>(io_);
					var iq_ = FHIRHelpers_4_3_000.ToInterval(ip_?.Period);
					var ir_ = context.Operators.Start(iq_);
					var it_ = context.Operators.Start(if_);
					var iu_ = context.Operators.Interval(ii_, (ir_ ?? it_), true, true);
					var iv_ = context.Operators.ElementInInterval<CqlDateTime>(hv_, iu_, null);
					var ix_ = context.Operators.RetrieveByValueSet<Encounter>(hw_, null);
					bool? iy_(Encounter LastObs)
					{
						var kw_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(LastObs?.StatusElement?.Value);
						var kx_ = context.Operators.Equal(kw_, "finished");
						var ky_ = FHIRHelpers_4_3_000.ToInterval(LastObs?.Period);
						var kz_ = context.Operators.End(ky_);
						var la_ = FHIRHelpers_4_3_000.ToInterval(Visit?.Period);
						var lb_ = context.Operators.Start(la_);
						var lc_ = context.Operators.Quantity((decimal?)1m, "hour");
						var ld_ = context.Operators.Subtract(lb_, lc_);
						var lf_ = context.Operators.Start(la_);
						var lg_ = context.Operators.Interval(ld_, lf_, true, true);
						var lh_ = context.Operators.ElementInInterval<CqlDateTime>(kz_, lg_, null);
						var lj_ = context.Operators.Start(la_);
						var lk_ = context.Operators.Not((bool?)(lj_ is null));
						var ll_ = context.Operators.And(lh_, lk_);
						var lm_ = context.Operators.And(kx_, ll_);

						return lm_;
					};
					var iz_ = context.Operators.WhereOrNull<Encounter>(ix_, iy_);
					object ja_(Encounter @this)
					{
						var ln_ = FHIRHelpers_4_3_000.ToInterval(@this?.Period);
						var lo_ = context.Operators.End(ln_);

						return lo_;
					};
					var jb_ = context.Operators.ListSortBy<Encounter>(iz_, ja_, System.ComponentModel.ListSortDirection.Ascending);
					var jc_ = context.Operators.LastOfList<Encounter>(jb_);
					var jd_ = FHIRHelpers_4_3_000.ToInterval(jc_?.Period);
					var je_ = context.Operators.Start(jd_);
					var jg_ = context.Operators.Start(if_);
					var jh_ = context.Operators.Not((bool?)((je_ ?? jg_) is null));
					var ji_ = context.Operators.And(iv_, jh_);
					var jj_ = context.Operators.And(ht_, ji_);

					return jj_;
				};
				var bl_ = context.Operators.WhereOrNull<Encounter>(bj_, bk_);
				object bm_(Encounter @this)
				{
					var lp_ = FHIRHelpers_4_3_000.ToInterval(@this?.Period);
					var lq_ = context.Operators.End(lp_);

					return lq_;
				};
				var bn_ = context.Operators.ListSortBy<Encounter>(bl_, bm_, System.ComponentModel.ListSortDirection.Ascending);
				var bo_ = context.Operators.LastOfList<Encounter>(bn_);
				var bp_ = FHIRHelpers_4_3_000.ToInterval(bo_?.Period);
				var bq_ = context.Operators.Start(bp_);
				var bs_ = context.Operators.RetrieveByValueSet<Encounter>(av_, null);
				bool? bt_(Encounter LastObs)
				{
					var lr_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(LastObs?.StatusElement?.Value);
					var ls_ = context.Operators.Equal(lr_, "finished");
					var lt_ = FHIRHelpers_4_3_000.ToInterval(LastObs?.Period);
					var lu_ = context.Operators.End(lt_);
					var lv_ = FHIRHelpers_4_3_000.ToInterval(Visit?.Period);
					var lw_ = context.Operators.Start(lv_);
					var lx_ = context.Operators.Quantity((decimal?)1m, "hour");
					var ly_ = context.Operators.Subtract(lw_, lx_);
					var ma_ = context.Operators.Start(lv_);
					var mb_ = context.Operators.Interval(ly_, ma_, true, true);
					var mc_ = context.Operators.ElementInInterval<CqlDateTime>(lu_, mb_, null);
					var me_ = context.Operators.Start(lv_);
					var mf_ = context.Operators.Not((bool?)(me_ is null));
					var mg_ = context.Operators.And(mc_, mf_);
					var mh_ = context.Operators.And(ls_, mg_);

					return mh_;
				};
				var bu_ = context.Operators.WhereOrNull<Encounter>(bs_, bt_);
				object bv_(Encounter @this)
				{
					var mi_ = FHIRHelpers_4_3_000.ToInterval(@this?.Period);
					var mj_ = context.Operators.End(mi_);

					return mj_;
				};
				var bw_ = context.Operators.ListSortBy<Encounter>(bu_, bv_, System.ComponentModel.ListSortDirection.Ascending);
				var bx_ = context.Operators.LastOfList<Encounter>(bw_);
				var by_ = FHIRHelpers_4_3_000.ToInterval(bx_?.Period);
				var bz_ = context.Operators.Start(by_);
				var cb_ = context.Operators.Start(be_);
				var cc_ = context.Operators.Interval(bh_, (bq_ ?? (bz_ ?? cb_)), true, true);
				var cd_ = context.Operators.ElementInInterval<CqlDateTime>(al_, cc_, null);
				var cf_ = context.Operators.RetrieveByValueSet<Encounter>(am_, null);
				bool? cg_(Encounter LastED)
				{
					var mk_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(LastED?.StatusElement?.Value);
					var ml_ = context.Operators.Equal(mk_, "finished");
					var mm_ = FHIRHelpers_4_3_000.ToInterval(LastED?.Period);
					var mn_ = context.Operators.End(mm_);
					var mo_ = this.Observation_Services();
					var mp_ = context.Operators.RetrieveByValueSet<Encounter>(mo_, null);
					bool? mq_(Encounter LastObs)
					{
						var oc_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(LastObs?.StatusElement?.Value);
						var od_ = context.Operators.Equal(oc_, "finished");
						var oe_ = FHIRHelpers_4_3_000.ToInterval(LastObs?.Period);
						var of_ = context.Operators.End(oe_);
						var og_ = FHIRHelpers_4_3_000.ToInterval(Visit?.Period);
						var oh_ = context.Operators.Start(og_);
						var oi_ = context.Operators.Quantity((decimal?)1m, "hour");
						var oj_ = context.Operators.Subtract(oh_, oi_);
						var ol_ = context.Operators.Start(og_);
						var om_ = context.Operators.Interval(oj_, ol_, true, true);
						var on_ = context.Operators.ElementInInterval<CqlDateTime>(of_, om_, null);
						var op_ = context.Operators.Start(og_);
						var oq_ = context.Operators.Not((bool?)(op_ is null));
						var or_ = context.Operators.And(on_, oq_);
						var os_ = context.Operators.And(od_, or_);

						return os_;
					};
					var mr_ = context.Operators.WhereOrNull<Encounter>(mp_, mq_);
					object ms_(Encounter @this)
					{
						var ot_ = FHIRHelpers_4_3_000.ToInterval(@this?.Period);
						var ou_ = context.Operators.End(ot_);

						return ou_;
					};
					var mt_ = context.Operators.ListSortBy<Encounter>(mr_, ms_, System.ComponentModel.ListSortDirection.Ascending);
					var mu_ = context.Operators.LastOfList<Encounter>(mt_);
					var mv_ = FHIRHelpers_4_3_000.ToInterval(mu_?.Period);
					var mw_ = context.Operators.Start(mv_);
					var mx_ = FHIRHelpers_4_3_000.ToInterval(Visit?.Period);
					var my_ = context.Operators.Start(mx_);
					var mz_ = context.Operators.Quantity((decimal?)1m, "hour");
					var na_ = context.Operators.Subtract((mw_ ?? my_), mz_);
					var nc_ = context.Operators.RetrieveByValueSet<Encounter>(mo_, null);
					bool? nd_(Encounter LastObs)
					{
						var ov_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(LastObs?.StatusElement?.Value);
						var ow_ = context.Operators.Equal(ov_, "finished");
						var ox_ = FHIRHelpers_4_3_000.ToInterval(LastObs?.Period);
						var oy_ = context.Operators.End(ox_);
						var oz_ = FHIRHelpers_4_3_000.ToInterval(Visit?.Period);
						var pa_ = context.Operators.Start(oz_);
						var pb_ = context.Operators.Quantity((decimal?)1m, "hour");
						var pc_ = context.Operators.Subtract(pa_, pb_);
						var pe_ = context.Operators.Start(oz_);
						var pf_ = context.Operators.Interval(pc_, pe_, true, true);
						var pg_ = context.Operators.ElementInInterval<CqlDateTime>(oy_, pf_, null);
						var pi_ = context.Operators.Start(oz_);
						var pj_ = context.Operators.Not((bool?)(pi_ is null));
						var pk_ = context.Operators.And(pg_, pj_);
						var pl_ = context.Operators.And(ow_, pk_);

						return pl_;
					};
					var ne_ = context.Operators.WhereOrNull<Encounter>(nc_, nd_);
					object nf_(Encounter @this)
					{
						var pm_ = FHIRHelpers_4_3_000.ToInterval(@this?.Period);
						var pn_ = context.Operators.End(pm_);

						return pn_;
					};
					var ng_ = context.Operators.ListSortBy<Encounter>(ne_, nf_, System.ComponentModel.ListSortDirection.Ascending);
					var nh_ = context.Operators.LastOfList<Encounter>(ng_);
					var ni_ = FHIRHelpers_4_3_000.ToInterval(nh_?.Period);
					var nj_ = context.Operators.Start(ni_);
					var nl_ = context.Operators.Start(mx_);
					var nm_ = context.Operators.Interval(na_, (nj_ ?? nl_), true, true);
					var nn_ = context.Operators.ElementInInterval<CqlDateTime>(mn_, nm_, null);
					var np_ = context.Operators.RetrieveByValueSet<Encounter>(mo_, null);
					bool? nq_(Encounter LastObs)
					{
						var po_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(LastObs?.StatusElement?.Value);
						var pp_ = context.Operators.Equal(po_, "finished");
						var pq_ = FHIRHelpers_4_3_000.ToInterval(LastObs?.Period);
						var pr_ = context.Operators.End(pq_);
						var ps_ = FHIRHelpers_4_3_000.ToInterval(Visit?.Period);
						var pt_ = context.Operators.Start(ps_);
						var pu_ = context.Operators.Quantity((decimal?)1m, "hour");
						var pv_ = context.Operators.Subtract(pt_, pu_);
						var px_ = context.Operators.Start(ps_);
						var py_ = context.Operators.Interval(pv_, px_, true, true);
						var pz_ = context.Operators.ElementInInterval<CqlDateTime>(pr_, py_, null);
						var qb_ = context.Operators.Start(ps_);
						var qc_ = context.Operators.Not((bool?)(qb_ is null));
						var qd_ = context.Operators.And(pz_, qc_);
						var qe_ = context.Operators.And(pp_, qd_);

						return qe_;
					};
					var nr_ = context.Operators.WhereOrNull<Encounter>(np_, nq_);
					object ns_(Encounter @this)
					{
						var qf_ = FHIRHelpers_4_3_000.ToInterval(@this?.Period);
						var qg_ = context.Operators.End(qf_);

						return qg_;
					};
					var nt_ = context.Operators.ListSortBy<Encounter>(nr_, ns_, System.ComponentModel.ListSortDirection.Ascending);
					var nu_ = context.Operators.LastOfList<Encounter>(nt_);
					var nv_ = FHIRHelpers_4_3_000.ToInterval(nu_?.Period);
					var nw_ = context.Operators.Start(nv_);
					var ny_ = context.Operators.Start(mx_);
					var nz_ = context.Operators.Not((bool?)((nw_ ?? ny_) is null));
					var oa_ = context.Operators.And(nn_, nz_);
					var ob_ = context.Operators.And(ml_, oa_);

					return ob_;
				};
				var ch_ = context.Operators.WhereOrNull<Encounter>(cf_, cg_);
				object ci_(Encounter @this)
				{
					var qh_ = FHIRHelpers_4_3_000.ToInterval(@this?.Period);
					var qi_ = context.Operators.End(qh_);

					return qi_;
				};
				var cj_ = context.Operators.ListSortBy<Encounter>(ch_, ci_, System.ComponentModel.ListSortDirection.Ascending);
				var ck_ = context.Operators.LastOfList<Encounter>(cj_);
				var cl_ = FHIRHelpers_4_3_000.ToInterval(ck_?.Period);
				var cm_ = context.Operators.Start(cl_);
				var co_ = context.Operators.RetrieveByValueSet<Encounter>(av_, null);
				bool? cp_(Encounter LastObs)
				{
					var qj_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(LastObs?.StatusElement?.Value);
					var qk_ = context.Operators.Equal(qj_, "finished");
					var ql_ = FHIRHelpers_4_3_000.ToInterval(LastObs?.Period);
					var qm_ = context.Operators.End(ql_);
					var qn_ = FHIRHelpers_4_3_000.ToInterval(Visit?.Period);
					var qo_ = context.Operators.Start(qn_);
					var qp_ = context.Operators.Quantity((decimal?)1m, "hour");
					var qq_ = context.Operators.Subtract(qo_, qp_);
					var qs_ = context.Operators.Start(qn_);
					var qt_ = context.Operators.Interval(qq_, qs_, true, true);
					var qu_ = context.Operators.ElementInInterval<CqlDateTime>(qm_, qt_, null);
					var qw_ = context.Operators.Start(qn_);
					var qx_ = context.Operators.Not((bool?)(qw_ is null));
					var qy_ = context.Operators.And(qu_, qx_);
					var qz_ = context.Operators.And(qk_, qy_);

					return qz_;
				};
				var cq_ = context.Operators.WhereOrNull<Encounter>(co_, cp_);
				object cr_(Encounter @this)
				{
					var ra_ = FHIRHelpers_4_3_000.ToInterval(@this?.Period);
					var rb_ = context.Operators.End(ra_);

					return rb_;
				};
				var cs_ = context.Operators.ListSortBy<Encounter>(cq_, cr_, System.ComponentModel.ListSortDirection.Ascending);
				var ct_ = context.Operators.LastOfList<Encounter>(cs_);
				var cu_ = FHIRHelpers_4_3_000.ToInterval(ct_?.Period);
				var cv_ = context.Operators.Start(cu_);
				var cx_ = context.Operators.Start(be_);
				var cy_ = context.Operators.Not((bool?)((cm_ ?? (cv_ ?? cx_)) is null));
				var cz_ = context.Operators.And(cd_, cy_);

				return cz_;
			};
			var h_ = context.Operators.WhereOrNull<Encounter>(f_, g_);
			object i_(Encounter @this)
			{
				var rc_ = FHIRHelpers_4_3_000.ToInterval(@this?.Period);
				var rd_ = context.Operators.End(rc_);

				return rd_;
			};
			var j_ = context.Operators.ListSortBy<Encounter>(h_, i_, System.ComponentModel.ListSortDirection.Ascending);
			var k_ = context.Operators.LastOfList<Encounter>(j_);
			var l_ = FHIRHelpers_4_3_000.ToInterval(k_?.Period);
			var m_ = context.Operators.Start(l_);
			var n_ = this.Emergency_Department_Visit();
			var o_ = context.Operators.RetrieveByValueSet<Encounter>(n_, null);
			bool? p_(Encounter LastED)
			{
				var re_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(LastED?.StatusElement?.Value);
				var rf_ = context.Operators.Equal(re_, "finished");
				var rg_ = FHIRHelpers_4_3_000.ToInterval(LastED?.Period);
				var rh_ = context.Operators.End(rg_);
				var ri_ = this.Observation_Services();
				var rj_ = context.Operators.RetrieveByValueSet<Encounter>(ri_, null);
				bool? rk_(Encounter LastObs)
				{
					var sw_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(LastObs?.StatusElement?.Value);
					var sx_ = context.Operators.Equal(sw_, "finished");
					var sy_ = FHIRHelpers_4_3_000.ToInterval(LastObs?.Period);
					var sz_ = context.Operators.End(sy_);
					var ta_ = FHIRHelpers_4_3_000.ToInterval(Visit?.Period);
					var tb_ = context.Operators.Start(ta_);
					var tc_ = context.Operators.Quantity((decimal?)1m, "hour");
					var td_ = context.Operators.Subtract(tb_, tc_);
					var tf_ = context.Operators.Start(ta_);
					var tg_ = context.Operators.Interval(td_, tf_, true, true);
					var th_ = context.Operators.ElementInInterval<CqlDateTime>(sz_, tg_, null);
					var tj_ = context.Operators.Start(ta_);
					var tk_ = context.Operators.Not((bool?)(tj_ is null));
					var tl_ = context.Operators.And(th_, tk_);
					var tm_ = context.Operators.And(sx_, tl_);

					return tm_;
				};
				var rl_ = context.Operators.WhereOrNull<Encounter>(rj_, rk_);
				object rm_(Encounter @this)
				{
					var tn_ = FHIRHelpers_4_3_000.ToInterval(@this?.Period);
					var to_ = context.Operators.End(tn_);

					return to_;
				};
				var rn_ = context.Operators.ListSortBy<Encounter>(rl_, rm_, System.ComponentModel.ListSortDirection.Ascending);
				var ro_ = context.Operators.LastOfList<Encounter>(rn_);
				var rp_ = FHIRHelpers_4_3_000.ToInterval(ro_?.Period);
				var rq_ = context.Operators.Start(rp_);
				var rr_ = FHIRHelpers_4_3_000.ToInterval(Visit?.Period);
				var rs_ = context.Operators.Start(rr_);
				var rt_ = context.Operators.Quantity((decimal?)1m, "hour");
				var ru_ = context.Operators.Subtract((rq_ ?? rs_), rt_);
				var rw_ = context.Operators.RetrieveByValueSet<Encounter>(ri_, null);
				bool? rx_(Encounter LastObs)
				{
					var tp_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(LastObs?.StatusElement?.Value);
					var tq_ = context.Operators.Equal(tp_, "finished");
					var tr_ = FHIRHelpers_4_3_000.ToInterval(LastObs?.Period);
					var ts_ = context.Operators.End(tr_);
					var tt_ = FHIRHelpers_4_3_000.ToInterval(Visit?.Period);
					var tu_ = context.Operators.Start(tt_);
					var tv_ = context.Operators.Quantity((decimal?)1m, "hour");
					var tw_ = context.Operators.Subtract(tu_, tv_);
					var ty_ = context.Operators.Start(tt_);
					var tz_ = context.Operators.Interval(tw_, ty_, true, true);
					var ua_ = context.Operators.ElementInInterval<CqlDateTime>(ts_, tz_, null);
					var uc_ = context.Operators.Start(tt_);
					var ud_ = context.Operators.Not((bool?)(uc_ is null));
					var ue_ = context.Operators.And(ua_, ud_);
					var uf_ = context.Operators.And(tq_, ue_);

					return uf_;
				};
				var ry_ = context.Operators.WhereOrNull<Encounter>(rw_, rx_);
				object rz_(Encounter @this)
				{
					var ug_ = FHIRHelpers_4_3_000.ToInterval(@this?.Period);
					var uh_ = context.Operators.End(ug_);

					return uh_;
				};
				var sa_ = context.Operators.ListSortBy<Encounter>(ry_, rz_, System.ComponentModel.ListSortDirection.Ascending);
				var sb_ = context.Operators.LastOfList<Encounter>(sa_);
				var sc_ = FHIRHelpers_4_3_000.ToInterval(sb_?.Period);
				var sd_ = context.Operators.Start(sc_);
				var sf_ = context.Operators.Start(rr_);
				var sg_ = context.Operators.Interval(ru_, (sd_ ?? sf_), true, true);
				var sh_ = context.Operators.ElementInInterval<CqlDateTime>(rh_, sg_, null);
				var sj_ = context.Operators.RetrieveByValueSet<Encounter>(ri_, null);
				bool? sk_(Encounter LastObs)
				{
					var ui_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(LastObs?.StatusElement?.Value);
					var uj_ = context.Operators.Equal(ui_, "finished");
					var uk_ = FHIRHelpers_4_3_000.ToInterval(LastObs?.Period);
					var ul_ = context.Operators.End(uk_);
					var um_ = FHIRHelpers_4_3_000.ToInterval(Visit?.Period);
					var un_ = context.Operators.Start(um_);
					var uo_ = context.Operators.Quantity((decimal?)1m, "hour");
					var up_ = context.Operators.Subtract(un_, uo_);
					var ur_ = context.Operators.Start(um_);
					var us_ = context.Operators.Interval(up_, ur_, true, true);
					var ut_ = context.Operators.ElementInInterval<CqlDateTime>(ul_, us_, null);
					var uv_ = context.Operators.Start(um_);
					var uw_ = context.Operators.Not((bool?)(uv_ is null));
					var ux_ = context.Operators.And(ut_, uw_);
					var uy_ = context.Operators.And(uj_, ux_);

					return uy_;
				};
				var sl_ = context.Operators.WhereOrNull<Encounter>(sj_, sk_);
				object sm_(Encounter @this)
				{
					var uz_ = FHIRHelpers_4_3_000.ToInterval(@this?.Period);
					var va_ = context.Operators.End(uz_);

					return va_;
				};
				var sn_ = context.Operators.ListSortBy<Encounter>(sl_, sm_, System.ComponentModel.ListSortDirection.Ascending);
				var so_ = context.Operators.LastOfList<Encounter>(sn_);
				var sp_ = FHIRHelpers_4_3_000.ToInterval(so_?.Period);
				var sq_ = context.Operators.Start(sp_);
				var ss_ = context.Operators.Start(rr_);
				var st_ = context.Operators.Not((bool?)((sq_ ?? ss_) is null));
				var su_ = context.Operators.And(sh_, st_);
				var sv_ = context.Operators.And(rf_, su_);

				return sv_;
			};
			var q_ = context.Operators.WhereOrNull<Encounter>(o_, p_);
			object r_(Encounter @this)
			{
				var vb_ = FHIRHelpers_4_3_000.ToInterval(@this?.Period);
				var vc_ = context.Operators.End(vb_);

				return vc_;
			};
			var s_ = context.Operators.ListSortBy<Encounter>(q_, r_, System.ComponentModel.ListSortDirection.Ascending);
			var t_ = context.Operators.LastOfList<Encounter>(s_);
			var u_ = FHIRHelpers_4_3_000.ToInterval(t_?.Period);
			var v_ = context.Operators.Start(u_);
			var w_ = this.Observation_Services();
			var x_ = context.Operators.RetrieveByValueSet<Encounter>(w_, null);
			bool? y_(Encounter LastObs)
			{
				var vd_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(LastObs?.StatusElement?.Value);
				var ve_ = context.Operators.Equal(vd_, "finished");
				var vf_ = FHIRHelpers_4_3_000.ToInterval(LastObs?.Period);
				var vg_ = context.Operators.End(vf_);
				var vh_ = FHIRHelpers_4_3_000.ToInterval(Visit?.Period);
				var vi_ = context.Operators.Start(vh_);
				var vj_ = context.Operators.Quantity((decimal?)1m, "hour");
				var vk_ = context.Operators.Subtract(vi_, vj_);
				var vm_ = context.Operators.Start(vh_);
				var vn_ = context.Operators.Interval(vk_, vm_, true, true);
				var vo_ = context.Operators.ElementInInterval<CqlDateTime>(vg_, vn_, null);
				var vq_ = context.Operators.Start(vh_);
				var vr_ = context.Operators.Not((bool?)(vq_ is null));
				var vs_ = context.Operators.And(vo_, vr_);
				var vt_ = context.Operators.And(ve_, vs_);

				return vt_;
			};
			var z_ = context.Operators.WhereOrNull<Encounter>(x_, y_);
			object aa_(Encounter @this)
			{
				var vu_ = FHIRHelpers_4_3_000.ToInterval(@this?.Period);
				var vv_ = context.Operators.End(vu_);

				return vv_;
			};
			var ab_ = context.Operators.ListSortBy<Encounter>(z_, aa_, System.ComponentModel.ListSortDirection.Ascending);
			var ac_ = context.Operators.LastOfList<Encounter>(ab_);
			var ad_ = FHIRHelpers_4_3_000.ToInterval(ac_?.Period);
			var ae_ = context.Operators.Start(ad_);
			var af_ = FHIRHelpers_4_3_000.ToInterval(Visit?.Period);
			var ag_ = context.Operators.Start(af_);
			var ai_ = context.Operators.End(af_);
			var aj_ = context.Operators.Interval((m_ ?? (v_ ?? (ae_ ?? ag_))), ai_, true, true);

			return aj_;
		};
		var c_ = context.Operators.SelectOrNull<Encounter, CqlInterval<CqlDateTime>>(a_, b_);
		var d_ = context.Operators.SingleOrNull<CqlInterval<CqlDateTime>>(c_);

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
				var ak_ = FHIRHelpers_4_3_000.ToInterval(LastSurgeryOP?.Period);
				var al_ = context.Operators.End(ak_);
				var am_ = this.Emergency_Department_Visit();
				var an_ = context.Operators.RetrieveByValueSet<Encounter>(am_, null);
				bool? ao_(Encounter LastED)
				{
					var da_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(LastED?.StatusElement?.Value);
					var db_ = context.Operators.Equal(da_, "finished");
					var dc_ = FHIRHelpers_4_3_000.ToInterval(LastED?.Period);
					var dd_ = context.Operators.End(dc_);
					var de_ = this.Observation_Services();
					var df_ = context.Operators.RetrieveByValueSet<Encounter>(de_, null);
					bool? dg_(Encounter LastObs)
					{
						var es_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(LastObs?.StatusElement?.Value);
						var et_ = context.Operators.Equal(es_, "finished");
						var eu_ = FHIRHelpers_4_3_000.ToInterval(LastObs?.Period);
						var ev_ = context.Operators.End(eu_);
						var ew_ = FHIRHelpers_4_3_000.ToInterval(Visit?.Period);
						var ex_ = context.Operators.Start(ew_);
						var ey_ = context.Operators.Quantity((decimal?)1m, "hour");
						var ez_ = context.Operators.Subtract(ex_, ey_);
						var fb_ = context.Operators.Start(ew_);
						var fc_ = context.Operators.Interval(ez_, fb_, true, true);
						var fd_ = context.Operators.ElementInInterval<CqlDateTime>(ev_, fc_, null);
						var ff_ = context.Operators.Start(ew_);
						var fg_ = context.Operators.Not((bool?)(ff_ is null));
						var fh_ = context.Operators.And(fd_, fg_);
						var fi_ = context.Operators.And(et_, fh_);

						return fi_;
					};
					var dh_ = context.Operators.WhereOrNull<Encounter>(df_, dg_);
					object di_(Encounter @this)
					{
						var fj_ = FHIRHelpers_4_3_000.ToInterval(@this?.Period);
						var fk_ = context.Operators.End(fj_);

						return fk_;
					};
					var dj_ = context.Operators.ListSortBy<Encounter>(dh_, di_, System.ComponentModel.ListSortDirection.Ascending);
					var dk_ = context.Operators.LastOfList<Encounter>(dj_);
					var dl_ = FHIRHelpers_4_3_000.ToInterval(dk_?.Period);
					var dm_ = context.Operators.Start(dl_);
					var dn_ = FHIRHelpers_4_3_000.ToInterval(Visit?.Period);
					var do_ = context.Operators.Start(dn_);
					var dp_ = context.Operators.Quantity((decimal?)1m, "hour");
					var dq_ = context.Operators.Subtract((dm_ ?? do_), dp_);
					var ds_ = context.Operators.RetrieveByValueSet<Encounter>(de_, null);
					bool? dt_(Encounter LastObs)
					{
						var fl_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(LastObs?.StatusElement?.Value);
						var fm_ = context.Operators.Equal(fl_, "finished");
						var fn_ = FHIRHelpers_4_3_000.ToInterval(LastObs?.Period);
						var fo_ = context.Operators.End(fn_);
						var fp_ = FHIRHelpers_4_3_000.ToInterval(Visit?.Period);
						var fq_ = context.Operators.Start(fp_);
						var fr_ = context.Operators.Quantity((decimal?)1m, "hour");
						var fs_ = context.Operators.Subtract(fq_, fr_);
						var fu_ = context.Operators.Start(fp_);
						var fv_ = context.Operators.Interval(fs_, fu_, true, true);
						var fw_ = context.Operators.ElementInInterval<CqlDateTime>(fo_, fv_, null);
						var fy_ = context.Operators.Start(fp_);
						var fz_ = context.Operators.Not((bool?)(fy_ is null));
						var ga_ = context.Operators.And(fw_, fz_);
						var gb_ = context.Operators.And(fm_, ga_);

						return gb_;
					};
					var du_ = context.Operators.WhereOrNull<Encounter>(ds_, dt_);
					object dv_(Encounter @this)
					{
						var gc_ = FHIRHelpers_4_3_000.ToInterval(@this?.Period);
						var gd_ = context.Operators.End(gc_);

						return gd_;
					};
					var dw_ = context.Operators.ListSortBy<Encounter>(du_, dv_, System.ComponentModel.ListSortDirection.Ascending);
					var dx_ = context.Operators.LastOfList<Encounter>(dw_);
					var dy_ = FHIRHelpers_4_3_000.ToInterval(dx_?.Period);
					var dz_ = context.Operators.Start(dy_);
					var eb_ = context.Operators.Start(dn_);
					var ec_ = context.Operators.Interval(dq_, (dz_ ?? eb_), true, true);
					var ed_ = context.Operators.ElementInInterval<CqlDateTime>(dd_, ec_, null);
					var ef_ = context.Operators.RetrieveByValueSet<Encounter>(de_, null);
					bool? eg_(Encounter LastObs)
					{
						var ge_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(LastObs?.StatusElement?.Value);
						var gf_ = context.Operators.Equal(ge_, "finished");
						var gg_ = FHIRHelpers_4_3_000.ToInterval(LastObs?.Period);
						var gh_ = context.Operators.End(gg_);
						var gi_ = FHIRHelpers_4_3_000.ToInterval(Visit?.Period);
						var gj_ = context.Operators.Start(gi_);
						var gk_ = context.Operators.Quantity((decimal?)1m, "hour");
						var gl_ = context.Operators.Subtract(gj_, gk_);
						var gn_ = context.Operators.Start(gi_);
						var go_ = context.Operators.Interval(gl_, gn_, true, true);
						var gp_ = context.Operators.ElementInInterval<CqlDateTime>(gh_, go_, null);
						var gr_ = context.Operators.Start(gi_);
						var gs_ = context.Operators.Not((bool?)(gr_ is null));
						var gt_ = context.Operators.And(gp_, gs_);
						var gu_ = context.Operators.And(gf_, gt_);

						return gu_;
					};
					var eh_ = context.Operators.WhereOrNull<Encounter>(ef_, eg_);
					object ei_(Encounter @this)
					{
						var gv_ = FHIRHelpers_4_3_000.ToInterval(@this?.Period);
						var gw_ = context.Operators.End(gv_);

						return gw_;
					};
					var ej_ = context.Operators.ListSortBy<Encounter>(eh_, ei_, System.ComponentModel.ListSortDirection.Ascending);
					var ek_ = context.Operators.LastOfList<Encounter>(ej_);
					var el_ = FHIRHelpers_4_3_000.ToInterval(ek_?.Period);
					var em_ = context.Operators.Start(el_);
					var eo_ = context.Operators.Start(dn_);
					var ep_ = context.Operators.Not((bool?)((em_ ?? eo_) is null));
					var eq_ = context.Operators.And(ed_, ep_);
					var er_ = context.Operators.And(db_, eq_);

					return er_;
				};
				var ap_ = context.Operators.WhereOrNull<Encounter>(an_, ao_);
				object aq_(Encounter @this)
				{
					var gx_ = FHIRHelpers_4_3_000.ToInterval(@this?.Period);
					var gy_ = context.Operators.End(gx_);

					return gy_;
				};
				var ar_ = context.Operators.ListSortBy<Encounter>(ap_, aq_, System.ComponentModel.ListSortDirection.Ascending);
				var as_ = context.Operators.LastOfList<Encounter>(ar_);
				var at_ = FHIRHelpers_4_3_000.ToInterval(as_?.Period);
				var au_ = context.Operators.Start(at_);
				var av_ = this.Observation_Services();
				var aw_ = context.Operators.RetrieveByValueSet<Encounter>(av_, null);
				bool? ax_(Encounter LastObs)
				{
					var gz_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(LastObs?.StatusElement?.Value);
					var ha_ = context.Operators.Equal(gz_, "finished");
					var hb_ = FHIRHelpers_4_3_000.ToInterval(LastObs?.Period);
					var hc_ = context.Operators.End(hb_);
					var hd_ = FHIRHelpers_4_3_000.ToInterval(Visit?.Period);
					var he_ = context.Operators.Start(hd_);
					var hf_ = context.Operators.Quantity((decimal?)1m, "hour");
					var hg_ = context.Operators.Subtract(he_, hf_);
					var hi_ = context.Operators.Start(hd_);
					var hj_ = context.Operators.Interval(hg_, hi_, true, true);
					var hk_ = context.Operators.ElementInInterval<CqlDateTime>(hc_, hj_, null);
					var hm_ = context.Operators.Start(hd_);
					var hn_ = context.Operators.Not((bool?)(hm_ is null));
					var ho_ = context.Operators.And(hk_, hn_);
					var hp_ = context.Operators.And(ha_, ho_);

					return hp_;
				};
				var ay_ = context.Operators.WhereOrNull<Encounter>(aw_, ax_);
				object az_(Encounter @this)
				{
					var hq_ = FHIRHelpers_4_3_000.ToInterval(@this?.Period);
					var hr_ = context.Operators.End(hq_);

					return hr_;
				};
				var ba_ = context.Operators.ListSortBy<Encounter>(ay_, az_, System.ComponentModel.ListSortDirection.Ascending);
				var bb_ = context.Operators.LastOfList<Encounter>(ba_);
				var bc_ = FHIRHelpers_4_3_000.ToInterval(bb_?.Period);
				var bd_ = context.Operators.Start(bc_);
				var be_ = FHIRHelpers_4_3_000.ToInterval(Visit?.Period);
				var bf_ = context.Operators.Start(be_);
				var bg_ = context.Operators.Quantity((decimal?)1m, "hour");
				var bh_ = context.Operators.Subtract((au_ ?? (bd_ ?? bf_)), bg_);
				var bj_ = context.Operators.RetrieveByValueSet<Encounter>(am_, null);
				bool? bk_(Encounter LastED)
				{
					var hs_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(LastED?.StatusElement?.Value);
					var ht_ = context.Operators.Equal(hs_, "finished");
					var hu_ = FHIRHelpers_4_3_000.ToInterval(LastED?.Period);
					var hv_ = context.Operators.End(hu_);
					var hw_ = this.Observation_Services();
					var hx_ = context.Operators.RetrieveByValueSet<Encounter>(hw_, null);
					bool? hy_(Encounter LastObs)
					{
						var jk_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(LastObs?.StatusElement?.Value);
						var jl_ = context.Operators.Equal(jk_, "finished");
						var jm_ = FHIRHelpers_4_3_000.ToInterval(LastObs?.Period);
						var jn_ = context.Operators.End(jm_);
						var jo_ = FHIRHelpers_4_3_000.ToInterval(Visit?.Period);
						var jp_ = context.Operators.Start(jo_);
						var jq_ = context.Operators.Quantity((decimal?)1m, "hour");
						var jr_ = context.Operators.Subtract(jp_, jq_);
						var jt_ = context.Operators.Start(jo_);
						var ju_ = context.Operators.Interval(jr_, jt_, true, true);
						var jv_ = context.Operators.ElementInInterval<CqlDateTime>(jn_, ju_, null);
						var jx_ = context.Operators.Start(jo_);
						var jy_ = context.Operators.Not((bool?)(jx_ is null));
						var jz_ = context.Operators.And(jv_, jy_);
						var ka_ = context.Operators.And(jl_, jz_);

						return ka_;
					};
					var hz_ = context.Operators.WhereOrNull<Encounter>(hx_, hy_);
					object ia_(Encounter @this)
					{
						var kb_ = FHIRHelpers_4_3_000.ToInterval(@this?.Period);
						var kc_ = context.Operators.End(kb_);

						return kc_;
					};
					var ib_ = context.Operators.ListSortBy<Encounter>(hz_, ia_, System.ComponentModel.ListSortDirection.Ascending);
					var ic_ = context.Operators.LastOfList<Encounter>(ib_);
					var id_ = FHIRHelpers_4_3_000.ToInterval(ic_?.Period);
					var ie_ = context.Operators.Start(id_);
					var if_ = FHIRHelpers_4_3_000.ToInterval(Visit?.Period);
					var ig_ = context.Operators.Start(if_);
					var ih_ = context.Operators.Quantity((decimal?)1m, "hour");
					var ii_ = context.Operators.Subtract((ie_ ?? ig_), ih_);
					var ik_ = context.Operators.RetrieveByValueSet<Encounter>(hw_, null);
					bool? il_(Encounter LastObs)
					{
						var kd_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(LastObs?.StatusElement?.Value);
						var ke_ = context.Operators.Equal(kd_, "finished");
						var kf_ = FHIRHelpers_4_3_000.ToInterval(LastObs?.Period);
						var kg_ = context.Operators.End(kf_);
						var kh_ = FHIRHelpers_4_3_000.ToInterval(Visit?.Period);
						var ki_ = context.Operators.Start(kh_);
						var kj_ = context.Operators.Quantity((decimal?)1m, "hour");
						var kk_ = context.Operators.Subtract(ki_, kj_);
						var km_ = context.Operators.Start(kh_);
						var kn_ = context.Operators.Interval(kk_, km_, true, true);
						var ko_ = context.Operators.ElementInInterval<CqlDateTime>(kg_, kn_, null);
						var kq_ = context.Operators.Start(kh_);
						var kr_ = context.Operators.Not((bool?)(kq_ is null));
						var ks_ = context.Operators.And(ko_, kr_);
						var kt_ = context.Operators.And(ke_, ks_);

						return kt_;
					};
					var im_ = context.Operators.WhereOrNull<Encounter>(ik_, il_);
					object in_(Encounter @this)
					{
						var ku_ = FHIRHelpers_4_3_000.ToInterval(@this?.Period);
						var kv_ = context.Operators.End(ku_);

						return kv_;
					};
					var io_ = context.Operators.ListSortBy<Encounter>(im_, in_, System.ComponentModel.ListSortDirection.Ascending);
					var ip_ = context.Operators.LastOfList<Encounter>(io_);
					var iq_ = FHIRHelpers_4_3_000.ToInterval(ip_?.Period);
					var ir_ = context.Operators.Start(iq_);
					var it_ = context.Operators.Start(if_);
					var iu_ = context.Operators.Interval(ii_, (ir_ ?? it_), true, true);
					var iv_ = context.Operators.ElementInInterval<CqlDateTime>(hv_, iu_, null);
					var ix_ = context.Operators.RetrieveByValueSet<Encounter>(hw_, null);
					bool? iy_(Encounter LastObs)
					{
						var kw_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(LastObs?.StatusElement?.Value);
						var kx_ = context.Operators.Equal(kw_, "finished");
						var ky_ = FHIRHelpers_4_3_000.ToInterval(LastObs?.Period);
						var kz_ = context.Operators.End(ky_);
						var la_ = FHIRHelpers_4_3_000.ToInterval(Visit?.Period);
						var lb_ = context.Operators.Start(la_);
						var lc_ = context.Operators.Quantity((decimal?)1m, "hour");
						var ld_ = context.Operators.Subtract(lb_, lc_);
						var lf_ = context.Operators.Start(la_);
						var lg_ = context.Operators.Interval(ld_, lf_, true, true);
						var lh_ = context.Operators.ElementInInterval<CqlDateTime>(kz_, lg_, null);
						var lj_ = context.Operators.Start(la_);
						var lk_ = context.Operators.Not((bool?)(lj_ is null));
						var ll_ = context.Operators.And(lh_, lk_);
						var lm_ = context.Operators.And(kx_, ll_);

						return lm_;
					};
					var iz_ = context.Operators.WhereOrNull<Encounter>(ix_, iy_);
					object ja_(Encounter @this)
					{
						var ln_ = FHIRHelpers_4_3_000.ToInterval(@this?.Period);
						var lo_ = context.Operators.End(ln_);

						return lo_;
					};
					var jb_ = context.Operators.ListSortBy<Encounter>(iz_, ja_, System.ComponentModel.ListSortDirection.Ascending);
					var jc_ = context.Operators.LastOfList<Encounter>(jb_);
					var jd_ = FHIRHelpers_4_3_000.ToInterval(jc_?.Period);
					var je_ = context.Operators.Start(jd_);
					var jg_ = context.Operators.Start(if_);
					var jh_ = context.Operators.Not((bool?)((je_ ?? jg_) is null));
					var ji_ = context.Operators.And(iv_, jh_);
					var jj_ = context.Operators.And(ht_, ji_);

					return jj_;
				};
				var bl_ = context.Operators.WhereOrNull<Encounter>(bj_, bk_);
				object bm_(Encounter @this)
				{
					var lp_ = FHIRHelpers_4_3_000.ToInterval(@this?.Period);
					var lq_ = context.Operators.End(lp_);

					return lq_;
				};
				var bn_ = context.Operators.ListSortBy<Encounter>(bl_, bm_, System.ComponentModel.ListSortDirection.Ascending);
				var bo_ = context.Operators.LastOfList<Encounter>(bn_);
				var bp_ = FHIRHelpers_4_3_000.ToInterval(bo_?.Period);
				var bq_ = context.Operators.Start(bp_);
				var bs_ = context.Operators.RetrieveByValueSet<Encounter>(av_, null);
				bool? bt_(Encounter LastObs)
				{
					var lr_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(LastObs?.StatusElement?.Value);
					var ls_ = context.Operators.Equal(lr_, "finished");
					var lt_ = FHIRHelpers_4_3_000.ToInterval(LastObs?.Period);
					var lu_ = context.Operators.End(lt_);
					var lv_ = FHIRHelpers_4_3_000.ToInterval(Visit?.Period);
					var lw_ = context.Operators.Start(lv_);
					var lx_ = context.Operators.Quantity((decimal?)1m, "hour");
					var ly_ = context.Operators.Subtract(lw_, lx_);
					var ma_ = context.Operators.Start(lv_);
					var mb_ = context.Operators.Interval(ly_, ma_, true, true);
					var mc_ = context.Operators.ElementInInterval<CqlDateTime>(lu_, mb_, null);
					var me_ = context.Operators.Start(lv_);
					var mf_ = context.Operators.Not((bool?)(me_ is null));
					var mg_ = context.Operators.And(mc_, mf_);
					var mh_ = context.Operators.And(ls_, mg_);

					return mh_;
				};
				var bu_ = context.Operators.WhereOrNull<Encounter>(bs_, bt_);
				object bv_(Encounter @this)
				{
					var mi_ = FHIRHelpers_4_3_000.ToInterval(@this?.Period);
					var mj_ = context.Operators.End(mi_);

					return mj_;
				};
				var bw_ = context.Operators.ListSortBy<Encounter>(bu_, bv_, System.ComponentModel.ListSortDirection.Ascending);
				var bx_ = context.Operators.LastOfList<Encounter>(bw_);
				var by_ = FHIRHelpers_4_3_000.ToInterval(bx_?.Period);
				var bz_ = context.Operators.Start(by_);
				var cb_ = context.Operators.Start(be_);
				var cc_ = context.Operators.Interval(bh_, (bq_ ?? (bz_ ?? cb_)), true, true);
				var cd_ = context.Operators.ElementInInterval<CqlDateTime>(al_, cc_, null);
				var cf_ = context.Operators.RetrieveByValueSet<Encounter>(am_, null);
				bool? cg_(Encounter LastED)
				{
					var mk_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(LastED?.StatusElement?.Value);
					var ml_ = context.Operators.Equal(mk_, "finished");
					var mm_ = FHIRHelpers_4_3_000.ToInterval(LastED?.Period);
					var mn_ = context.Operators.End(mm_);
					var mo_ = this.Observation_Services();
					var mp_ = context.Operators.RetrieveByValueSet<Encounter>(mo_, null);
					bool? mq_(Encounter LastObs)
					{
						var oc_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(LastObs?.StatusElement?.Value);
						var od_ = context.Operators.Equal(oc_, "finished");
						var oe_ = FHIRHelpers_4_3_000.ToInterval(LastObs?.Period);
						var of_ = context.Operators.End(oe_);
						var og_ = FHIRHelpers_4_3_000.ToInterval(Visit?.Period);
						var oh_ = context.Operators.Start(og_);
						var oi_ = context.Operators.Quantity((decimal?)1m, "hour");
						var oj_ = context.Operators.Subtract(oh_, oi_);
						var ol_ = context.Operators.Start(og_);
						var om_ = context.Operators.Interval(oj_, ol_, true, true);
						var on_ = context.Operators.ElementInInterval<CqlDateTime>(of_, om_, null);
						var op_ = context.Operators.Start(og_);
						var oq_ = context.Operators.Not((bool?)(op_ is null));
						var or_ = context.Operators.And(on_, oq_);
						var os_ = context.Operators.And(od_, or_);

						return os_;
					};
					var mr_ = context.Operators.WhereOrNull<Encounter>(mp_, mq_);
					object ms_(Encounter @this)
					{
						var ot_ = FHIRHelpers_4_3_000.ToInterval(@this?.Period);
						var ou_ = context.Operators.End(ot_);

						return ou_;
					};
					var mt_ = context.Operators.ListSortBy<Encounter>(mr_, ms_, System.ComponentModel.ListSortDirection.Ascending);
					var mu_ = context.Operators.LastOfList<Encounter>(mt_);
					var mv_ = FHIRHelpers_4_3_000.ToInterval(mu_?.Period);
					var mw_ = context.Operators.Start(mv_);
					var mx_ = FHIRHelpers_4_3_000.ToInterval(Visit?.Period);
					var my_ = context.Operators.Start(mx_);
					var mz_ = context.Operators.Quantity((decimal?)1m, "hour");
					var na_ = context.Operators.Subtract((mw_ ?? my_), mz_);
					var nc_ = context.Operators.RetrieveByValueSet<Encounter>(mo_, null);
					bool? nd_(Encounter LastObs)
					{
						var ov_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(LastObs?.StatusElement?.Value);
						var ow_ = context.Operators.Equal(ov_, "finished");
						var ox_ = FHIRHelpers_4_3_000.ToInterval(LastObs?.Period);
						var oy_ = context.Operators.End(ox_);
						var oz_ = FHIRHelpers_4_3_000.ToInterval(Visit?.Period);
						var pa_ = context.Operators.Start(oz_);
						var pb_ = context.Operators.Quantity((decimal?)1m, "hour");
						var pc_ = context.Operators.Subtract(pa_, pb_);
						var pe_ = context.Operators.Start(oz_);
						var pf_ = context.Operators.Interval(pc_, pe_, true, true);
						var pg_ = context.Operators.ElementInInterval<CqlDateTime>(oy_, pf_, null);
						var pi_ = context.Operators.Start(oz_);
						var pj_ = context.Operators.Not((bool?)(pi_ is null));
						var pk_ = context.Operators.And(pg_, pj_);
						var pl_ = context.Operators.And(ow_, pk_);

						return pl_;
					};
					var ne_ = context.Operators.WhereOrNull<Encounter>(nc_, nd_);
					object nf_(Encounter @this)
					{
						var pm_ = FHIRHelpers_4_3_000.ToInterval(@this?.Period);
						var pn_ = context.Operators.End(pm_);

						return pn_;
					};
					var ng_ = context.Operators.ListSortBy<Encounter>(ne_, nf_, System.ComponentModel.ListSortDirection.Ascending);
					var nh_ = context.Operators.LastOfList<Encounter>(ng_);
					var ni_ = FHIRHelpers_4_3_000.ToInterval(nh_?.Period);
					var nj_ = context.Operators.Start(ni_);
					var nl_ = context.Operators.Start(mx_);
					var nm_ = context.Operators.Interval(na_, (nj_ ?? nl_), true, true);
					var nn_ = context.Operators.ElementInInterval<CqlDateTime>(mn_, nm_, null);
					var np_ = context.Operators.RetrieveByValueSet<Encounter>(mo_, null);
					bool? nq_(Encounter LastObs)
					{
						var po_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(LastObs?.StatusElement?.Value);
						var pp_ = context.Operators.Equal(po_, "finished");
						var pq_ = FHIRHelpers_4_3_000.ToInterval(LastObs?.Period);
						var pr_ = context.Operators.End(pq_);
						var ps_ = FHIRHelpers_4_3_000.ToInterval(Visit?.Period);
						var pt_ = context.Operators.Start(ps_);
						var pu_ = context.Operators.Quantity((decimal?)1m, "hour");
						var pv_ = context.Operators.Subtract(pt_, pu_);
						var px_ = context.Operators.Start(ps_);
						var py_ = context.Operators.Interval(pv_, px_, true, true);
						var pz_ = context.Operators.ElementInInterval<CqlDateTime>(pr_, py_, null);
						var qb_ = context.Operators.Start(ps_);
						var qc_ = context.Operators.Not((bool?)(qb_ is null));
						var qd_ = context.Operators.And(pz_, qc_);
						var qe_ = context.Operators.And(pp_, qd_);

						return qe_;
					};
					var nr_ = context.Operators.WhereOrNull<Encounter>(np_, nq_);
					object ns_(Encounter @this)
					{
						var qf_ = FHIRHelpers_4_3_000.ToInterval(@this?.Period);
						var qg_ = context.Operators.End(qf_);

						return qg_;
					};
					var nt_ = context.Operators.ListSortBy<Encounter>(nr_, ns_, System.ComponentModel.ListSortDirection.Ascending);
					var nu_ = context.Operators.LastOfList<Encounter>(nt_);
					var nv_ = FHIRHelpers_4_3_000.ToInterval(nu_?.Period);
					var nw_ = context.Operators.Start(nv_);
					var ny_ = context.Operators.Start(mx_);
					var nz_ = context.Operators.Not((bool?)((nw_ ?? ny_) is null));
					var oa_ = context.Operators.And(nn_, nz_);
					var ob_ = context.Operators.And(ml_, oa_);

					return ob_;
				};
				var ch_ = context.Operators.WhereOrNull<Encounter>(cf_, cg_);
				object ci_(Encounter @this)
				{
					var qh_ = FHIRHelpers_4_3_000.ToInterval(@this?.Period);
					var qi_ = context.Operators.End(qh_);

					return qi_;
				};
				var cj_ = context.Operators.ListSortBy<Encounter>(ch_, ci_, System.ComponentModel.ListSortDirection.Ascending);
				var ck_ = context.Operators.LastOfList<Encounter>(cj_);
				var cl_ = FHIRHelpers_4_3_000.ToInterval(ck_?.Period);
				var cm_ = context.Operators.Start(cl_);
				var co_ = context.Operators.RetrieveByValueSet<Encounter>(av_, null);
				bool? cp_(Encounter LastObs)
				{
					var qj_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(LastObs?.StatusElement?.Value);
					var qk_ = context.Operators.Equal(qj_, "finished");
					var ql_ = FHIRHelpers_4_3_000.ToInterval(LastObs?.Period);
					var qm_ = context.Operators.End(ql_);
					var qn_ = FHIRHelpers_4_3_000.ToInterval(Visit?.Period);
					var qo_ = context.Operators.Start(qn_);
					var qp_ = context.Operators.Quantity((decimal?)1m, "hour");
					var qq_ = context.Operators.Subtract(qo_, qp_);
					var qs_ = context.Operators.Start(qn_);
					var qt_ = context.Operators.Interval(qq_, qs_, true, true);
					var qu_ = context.Operators.ElementInInterval<CqlDateTime>(qm_, qt_, null);
					var qw_ = context.Operators.Start(qn_);
					var qx_ = context.Operators.Not((bool?)(qw_ is null));
					var qy_ = context.Operators.And(qu_, qx_);
					var qz_ = context.Operators.And(qk_, qy_);

					return qz_;
				};
				var cq_ = context.Operators.WhereOrNull<Encounter>(co_, cp_);
				object cr_(Encounter @this)
				{
					var ra_ = FHIRHelpers_4_3_000.ToInterval(@this?.Period);
					var rb_ = context.Operators.End(ra_);

					return rb_;
				};
				var cs_ = context.Operators.ListSortBy<Encounter>(cq_, cr_, System.ComponentModel.ListSortDirection.Ascending);
				var ct_ = context.Operators.LastOfList<Encounter>(cs_);
				var cu_ = FHIRHelpers_4_3_000.ToInterval(ct_?.Period);
				var cv_ = context.Operators.Start(cu_);
				var cx_ = context.Operators.Start(be_);
				var cy_ = context.Operators.Not((bool?)((cm_ ?? (cv_ ?? cx_)) is null));
				var cz_ = context.Operators.And(cd_, cy_);

				return cz_;
			};
			var h_ = context.Operators.WhereOrNull<Encounter>(f_, g_);
			object i_(Encounter @this)
			{
				var rc_ = FHIRHelpers_4_3_000.ToInterval(@this?.Period);
				var rd_ = context.Operators.End(rc_);

				return rd_;
			};
			var j_ = context.Operators.ListSortBy<Encounter>(h_, i_, System.ComponentModel.ListSortDirection.Ascending);
			var k_ = context.Operators.LastOfList<Encounter>(j_);
			var l_ = FHIRHelpers_4_3_000.ToInterval(k_?.Period);
			var m_ = context.Operators.Start(l_);
			var n_ = this.Emergency_Department_Visit();
			var o_ = context.Operators.RetrieveByValueSet<Encounter>(n_, null);
			bool? p_(Encounter LastED)
			{
				var re_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(LastED?.StatusElement?.Value);
				var rf_ = context.Operators.Equal(re_, "finished");
				var rg_ = FHIRHelpers_4_3_000.ToInterval(LastED?.Period);
				var rh_ = context.Operators.End(rg_);
				var ri_ = this.Observation_Services();
				var rj_ = context.Operators.RetrieveByValueSet<Encounter>(ri_, null);
				bool? rk_(Encounter LastObs)
				{
					var sw_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(LastObs?.StatusElement?.Value);
					var sx_ = context.Operators.Equal(sw_, "finished");
					var sy_ = FHIRHelpers_4_3_000.ToInterval(LastObs?.Period);
					var sz_ = context.Operators.End(sy_);
					var ta_ = FHIRHelpers_4_3_000.ToInterval(Visit?.Period);
					var tb_ = context.Operators.Start(ta_);
					var tc_ = context.Operators.Quantity((decimal?)1m, "hour");
					var td_ = context.Operators.Subtract(tb_, tc_);
					var tf_ = context.Operators.Start(ta_);
					var tg_ = context.Operators.Interval(td_, tf_, true, true);
					var th_ = context.Operators.ElementInInterval<CqlDateTime>(sz_, tg_, null);
					var tj_ = context.Operators.Start(ta_);
					var tk_ = context.Operators.Not((bool?)(tj_ is null));
					var tl_ = context.Operators.And(th_, tk_);
					var tm_ = context.Operators.And(sx_, tl_);

					return tm_;
				};
				var rl_ = context.Operators.WhereOrNull<Encounter>(rj_, rk_);
				object rm_(Encounter @this)
				{
					var tn_ = FHIRHelpers_4_3_000.ToInterval(@this?.Period);
					var to_ = context.Operators.End(tn_);

					return to_;
				};
				var rn_ = context.Operators.ListSortBy<Encounter>(rl_, rm_, System.ComponentModel.ListSortDirection.Ascending);
				var ro_ = context.Operators.LastOfList<Encounter>(rn_);
				var rp_ = FHIRHelpers_4_3_000.ToInterval(ro_?.Period);
				var rq_ = context.Operators.Start(rp_);
				var rr_ = FHIRHelpers_4_3_000.ToInterval(Visit?.Period);
				var rs_ = context.Operators.Start(rr_);
				var rt_ = context.Operators.Quantity((decimal?)1m, "hour");
				var ru_ = context.Operators.Subtract((rq_ ?? rs_), rt_);
				var rw_ = context.Operators.RetrieveByValueSet<Encounter>(ri_, null);
				bool? rx_(Encounter LastObs)
				{
					var tp_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(LastObs?.StatusElement?.Value);
					var tq_ = context.Operators.Equal(tp_, "finished");
					var tr_ = FHIRHelpers_4_3_000.ToInterval(LastObs?.Period);
					var ts_ = context.Operators.End(tr_);
					var tt_ = FHIRHelpers_4_3_000.ToInterval(Visit?.Period);
					var tu_ = context.Operators.Start(tt_);
					var tv_ = context.Operators.Quantity((decimal?)1m, "hour");
					var tw_ = context.Operators.Subtract(tu_, tv_);
					var ty_ = context.Operators.Start(tt_);
					var tz_ = context.Operators.Interval(tw_, ty_, true, true);
					var ua_ = context.Operators.ElementInInterval<CqlDateTime>(ts_, tz_, null);
					var uc_ = context.Operators.Start(tt_);
					var ud_ = context.Operators.Not((bool?)(uc_ is null));
					var ue_ = context.Operators.And(ua_, ud_);
					var uf_ = context.Operators.And(tq_, ue_);

					return uf_;
				};
				var ry_ = context.Operators.WhereOrNull<Encounter>(rw_, rx_);
				object rz_(Encounter @this)
				{
					var ug_ = FHIRHelpers_4_3_000.ToInterval(@this?.Period);
					var uh_ = context.Operators.End(ug_);

					return uh_;
				};
				var sa_ = context.Operators.ListSortBy<Encounter>(ry_, rz_, System.ComponentModel.ListSortDirection.Ascending);
				var sb_ = context.Operators.LastOfList<Encounter>(sa_);
				var sc_ = FHIRHelpers_4_3_000.ToInterval(sb_?.Period);
				var sd_ = context.Operators.Start(sc_);
				var sf_ = context.Operators.Start(rr_);
				var sg_ = context.Operators.Interval(ru_, (sd_ ?? sf_), true, true);
				var sh_ = context.Operators.ElementInInterval<CqlDateTime>(rh_, sg_, null);
				var sj_ = context.Operators.RetrieveByValueSet<Encounter>(ri_, null);
				bool? sk_(Encounter LastObs)
				{
					var ui_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(LastObs?.StatusElement?.Value);
					var uj_ = context.Operators.Equal(ui_, "finished");
					var uk_ = FHIRHelpers_4_3_000.ToInterval(LastObs?.Period);
					var ul_ = context.Operators.End(uk_);
					var um_ = FHIRHelpers_4_3_000.ToInterval(Visit?.Period);
					var un_ = context.Operators.Start(um_);
					var uo_ = context.Operators.Quantity((decimal?)1m, "hour");
					var up_ = context.Operators.Subtract(un_, uo_);
					var ur_ = context.Operators.Start(um_);
					var us_ = context.Operators.Interval(up_, ur_, true, true);
					var ut_ = context.Operators.ElementInInterval<CqlDateTime>(ul_, us_, null);
					var uv_ = context.Operators.Start(um_);
					var uw_ = context.Operators.Not((bool?)(uv_ is null));
					var ux_ = context.Operators.And(ut_, uw_);
					var uy_ = context.Operators.And(uj_, ux_);

					return uy_;
				};
				var sl_ = context.Operators.WhereOrNull<Encounter>(sj_, sk_);
				object sm_(Encounter @this)
				{
					var uz_ = FHIRHelpers_4_3_000.ToInterval(@this?.Period);
					var va_ = context.Operators.End(uz_);

					return va_;
				};
				var sn_ = context.Operators.ListSortBy<Encounter>(sl_, sm_, System.ComponentModel.ListSortDirection.Ascending);
				var so_ = context.Operators.LastOfList<Encounter>(sn_);
				var sp_ = FHIRHelpers_4_3_000.ToInterval(so_?.Period);
				var sq_ = context.Operators.Start(sp_);
				var ss_ = context.Operators.Start(rr_);
				var st_ = context.Operators.Not((bool?)((sq_ ?? ss_) is null));
				var su_ = context.Operators.And(sh_, st_);
				var sv_ = context.Operators.And(rf_, su_);

				return sv_;
			};
			var q_ = context.Operators.WhereOrNull<Encounter>(o_, p_);
			object r_(Encounter @this)
			{
				var vb_ = FHIRHelpers_4_3_000.ToInterval(@this?.Period);
				var vc_ = context.Operators.End(vb_);

				return vc_;
			};
			var s_ = context.Operators.ListSortBy<Encounter>(q_, r_, System.ComponentModel.ListSortDirection.Ascending);
			var t_ = context.Operators.LastOfList<Encounter>(s_);
			var u_ = FHIRHelpers_4_3_000.ToInterval(t_?.Period);
			var v_ = context.Operators.Start(u_);
			var w_ = this.Observation_Services();
			var x_ = context.Operators.RetrieveByValueSet<Encounter>(w_, null);
			bool? y_(Encounter LastObs)
			{
				var vd_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(LastObs?.StatusElement?.Value);
				var ve_ = context.Operators.Equal(vd_, "finished");
				var vf_ = FHIRHelpers_4_3_000.ToInterval(LastObs?.Period);
				var vg_ = context.Operators.End(vf_);
				var vh_ = FHIRHelpers_4_3_000.ToInterval(Visit?.Period);
				var vi_ = context.Operators.Start(vh_);
				var vj_ = context.Operators.Quantity((decimal?)1m, "hour");
				var vk_ = context.Operators.Subtract(vi_, vj_);
				var vm_ = context.Operators.Start(vh_);
				var vn_ = context.Operators.Interval(vk_, vm_, true, true);
				var vo_ = context.Operators.ElementInInterval<CqlDateTime>(vg_, vn_, null);
				var vq_ = context.Operators.Start(vh_);
				var vr_ = context.Operators.Not((bool?)(vq_ is null));
				var vs_ = context.Operators.And(vo_, vr_);
				var vt_ = context.Operators.And(ve_, vs_);

				return vt_;
			};
			var z_ = context.Operators.WhereOrNull<Encounter>(x_, y_);
			object aa_(Encounter @this)
			{
				var vu_ = FHIRHelpers_4_3_000.ToInterval(@this?.Period);
				var vv_ = context.Operators.End(vu_);

				return vv_;
			};
			var ab_ = context.Operators.ListSortBy<Encounter>(z_, aa_, System.ComponentModel.ListSortDirection.Ascending);
			var ac_ = context.Operators.LastOfList<Encounter>(ab_);
			var ad_ = FHIRHelpers_4_3_000.ToInterval(ac_?.Period);
			var ae_ = context.Operators.Start(ad_);
			var af_ = FHIRHelpers_4_3_000.ToInterval(Visit?.Period);
			var ag_ = context.Operators.Start(af_);
			var ai_ = context.Operators.End(af_);
			var aj_ = context.Operators.Interval((m_ ?? (v_ ?? (ae_ ?? ag_))), ai_, true, true);

			return aj_;
		};
		var c_ = context.Operators.SelectOrNull<Encounter, CqlInterval<CqlDateTime>>(a_, b_);
		var d_ = context.Operators.SingleOrNull<CqlInterval<CqlDateTime>>(c_);

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
				var ab_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(LastED?.StatusElement?.Value);
				var ac_ = context.Operators.Equal(ab_, "finished");
				var ad_ = FHIRHelpers_4_3_000.ToInterval(LastED?.Period);
				var ae_ = context.Operators.End(ad_);
				var af_ = this.Observation_Services();
				var ag_ = context.Operators.RetrieveByValueSet<Encounter>(af_, null);
				bool? ah_(Encounter LastObs)
				{
					var bt_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(LastObs?.StatusElement?.Value);
					var bu_ = context.Operators.Equal(bt_, "finished");
					var bv_ = FHIRHelpers_4_3_000.ToInterval(LastObs?.Period);
					var bw_ = context.Operators.End(bv_);
					var bx_ = FHIRHelpers_4_3_000.ToInterval(Visit?.Period);
					var by_ = context.Operators.Start(bx_);
					var bz_ = context.Operators.Quantity((decimal?)1m, "hour");
					var ca_ = context.Operators.Subtract(by_, bz_);
					var cc_ = context.Operators.Start(bx_);
					var cd_ = context.Operators.Interval(ca_, cc_, true, true);
					var ce_ = context.Operators.ElementInInterval<CqlDateTime>(bw_, cd_, null);
					var cg_ = context.Operators.Start(bx_);
					var ch_ = context.Operators.Not((bool?)(cg_ is null));
					var ci_ = context.Operators.And(ce_, ch_);
					var cj_ = context.Operators.And(bu_, ci_);

					return cj_;
				};
				var ai_ = context.Operators.WhereOrNull<Encounter>(ag_, ah_);
				object aj_(Encounter @this)
				{
					var ck_ = FHIRHelpers_4_3_000.ToInterval(@this?.Period);
					var cl_ = context.Operators.End(ck_);

					return cl_;
				};
				var ak_ = context.Operators.ListSortBy<Encounter>(ai_, aj_, System.ComponentModel.ListSortDirection.Ascending);
				var al_ = context.Operators.LastOfList<Encounter>(ak_);
				var am_ = FHIRHelpers_4_3_000.ToInterval(al_?.Period);
				var an_ = context.Operators.Start(am_);
				var ao_ = FHIRHelpers_4_3_000.ToInterval(Visit?.Period);
				var ap_ = context.Operators.Start(ao_);
				var aq_ = context.Operators.Quantity((decimal?)1m, "hour");
				var ar_ = context.Operators.Subtract((an_ ?? ap_), aq_);
				var at_ = context.Operators.RetrieveByValueSet<Encounter>(af_, null);
				bool? au_(Encounter LastObs)
				{
					var cm_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(LastObs?.StatusElement?.Value);
					var cn_ = context.Operators.Equal(cm_, "finished");
					var co_ = FHIRHelpers_4_3_000.ToInterval(LastObs?.Period);
					var cp_ = context.Operators.End(co_);
					var cq_ = FHIRHelpers_4_3_000.ToInterval(Visit?.Period);
					var cr_ = context.Operators.Start(cq_);
					var cs_ = context.Operators.Quantity((decimal?)1m, "hour");
					var ct_ = context.Operators.Subtract(cr_, cs_);
					var cv_ = context.Operators.Start(cq_);
					var cw_ = context.Operators.Interval(ct_, cv_, true, true);
					var cx_ = context.Operators.ElementInInterval<CqlDateTime>(cp_, cw_, null);
					var cz_ = context.Operators.Start(cq_);
					var da_ = context.Operators.Not((bool?)(cz_ is null));
					var db_ = context.Operators.And(cx_, da_);
					var dc_ = context.Operators.And(cn_, db_);

					return dc_;
				};
				var av_ = context.Operators.WhereOrNull<Encounter>(at_, au_);
				object aw_(Encounter @this)
				{
					var dd_ = FHIRHelpers_4_3_000.ToInterval(@this?.Period);
					var de_ = context.Operators.End(dd_);

					return de_;
				};
				var ax_ = context.Operators.ListSortBy<Encounter>(av_, aw_, System.ComponentModel.ListSortDirection.Ascending);
				var ay_ = context.Operators.LastOfList<Encounter>(ax_);
				var az_ = FHIRHelpers_4_3_000.ToInterval(ay_?.Period);
				var ba_ = context.Operators.Start(az_);
				var bc_ = context.Operators.Start(ao_);
				var bd_ = context.Operators.Interval(ar_, (ba_ ?? bc_), true, true);
				var be_ = context.Operators.ElementInInterval<CqlDateTime>(ae_, bd_, null);
				var bg_ = context.Operators.RetrieveByValueSet<Encounter>(af_, null);
				bool? bh_(Encounter LastObs)
				{
					var df_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(LastObs?.StatusElement?.Value);
					var dg_ = context.Operators.Equal(df_, "finished");
					var dh_ = FHIRHelpers_4_3_000.ToInterval(LastObs?.Period);
					var di_ = context.Operators.End(dh_);
					var dj_ = FHIRHelpers_4_3_000.ToInterval(Visit?.Period);
					var dk_ = context.Operators.Start(dj_);
					var dl_ = context.Operators.Quantity((decimal?)1m, "hour");
					var dm_ = context.Operators.Subtract(dk_, dl_);
					var do_ = context.Operators.Start(dj_);
					var dp_ = context.Operators.Interval(dm_, do_, true, true);
					var dq_ = context.Operators.ElementInInterval<CqlDateTime>(di_, dp_, null);
					var ds_ = context.Operators.Start(dj_);
					var dt_ = context.Operators.Not((bool?)(ds_ is null));
					var du_ = context.Operators.And(dq_, dt_);
					var dv_ = context.Operators.And(dg_, du_);

					return dv_;
				};
				var bi_ = context.Operators.WhereOrNull<Encounter>(bg_, bh_);
				object bj_(Encounter @this)
				{
					var dw_ = FHIRHelpers_4_3_000.ToInterval(@this?.Period);
					var dx_ = context.Operators.End(dw_);

					return dx_;
				};
				var bk_ = context.Operators.ListSortBy<Encounter>(bi_, bj_, System.ComponentModel.ListSortDirection.Ascending);
				var bl_ = context.Operators.LastOfList<Encounter>(bk_);
				var bm_ = FHIRHelpers_4_3_000.ToInterval(bl_?.Period);
				var bn_ = context.Operators.Start(bm_);
				var bp_ = context.Operators.Start(ao_);
				var bq_ = context.Operators.Not((bool?)((bn_ ?? bp_) is null));
				var br_ = context.Operators.And(be_, bq_);
				var bs_ = context.Operators.And(ac_, br_);

				return bs_;
			};
			var h_ = context.Operators.WhereOrNull<Encounter>(f_, g_);
			object i_(Encounter @this)
			{
				var dy_ = FHIRHelpers_4_3_000.ToInterval(@this?.Period);
				var dz_ = context.Operators.End(dy_);

				return dz_;
			};
			var j_ = context.Operators.ListSortBy<Encounter>(h_, i_, System.ComponentModel.ListSortDirection.Ascending);
			var k_ = context.Operators.LastOfList<Encounter>(j_);
			var l_ = FHIRHelpers_4_3_000.ToInterval(k_?.Period);
			var m_ = context.Operators.Start(l_);
			var n_ = this.Observation_Services();
			var o_ = context.Operators.RetrieveByValueSet<Encounter>(n_, null);
			bool? p_(Encounter LastObs)
			{
				var ea_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(LastObs?.StatusElement?.Value);
				var eb_ = context.Operators.Equal(ea_, "finished");
				var ec_ = FHIRHelpers_4_3_000.ToInterval(LastObs?.Period);
				var ed_ = context.Operators.End(ec_);
				var ee_ = FHIRHelpers_4_3_000.ToInterval(Visit?.Period);
				var ef_ = context.Operators.Start(ee_);
				var eg_ = context.Operators.Quantity((decimal?)1m, "hour");
				var eh_ = context.Operators.Subtract(ef_, eg_);
				var ej_ = context.Operators.Start(ee_);
				var ek_ = context.Operators.Interval(eh_, ej_, true, true);
				var el_ = context.Operators.ElementInInterval<CqlDateTime>(ed_, ek_, null);
				var en_ = context.Operators.Start(ee_);
				var eo_ = context.Operators.Not((bool?)(en_ is null));
				var ep_ = context.Operators.And(el_, eo_);
				var eq_ = context.Operators.And(eb_, ep_);

				return eq_;
			};
			var q_ = context.Operators.WhereOrNull<Encounter>(o_, p_);
			object r_(Encounter @this)
			{
				var er_ = FHIRHelpers_4_3_000.ToInterval(@this?.Period);
				var es_ = context.Operators.End(er_);

				return es_;
			};
			var s_ = context.Operators.ListSortBy<Encounter>(q_, r_, System.ComponentModel.ListSortDirection.Ascending);
			var t_ = context.Operators.LastOfList<Encounter>(s_);
			var u_ = FHIRHelpers_4_3_000.ToInterval(t_?.Period);
			var v_ = context.Operators.Start(u_);
			var w_ = FHIRHelpers_4_3_000.ToInterval(Visit?.Period);
			var x_ = context.Operators.Start(w_);
			var z_ = context.Operators.End(w_);
			var aa_ = context.Operators.Interval((m_ ?? (v_ ?? x_)), z_, true, true);

			return aa_;
		};
		var c_ = context.Operators.SelectOrNull<Encounter, CqlInterval<CqlDateTime>>(a_, b_);
		var d_ = context.Operators.SingleOrNull<CqlInterval<CqlDateTime>>(c_);

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
				var ab_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(LastED?.StatusElement?.Value);
				var ac_ = context.Operators.Equal(ab_, "finished");
				var ad_ = FHIRHelpers_4_3_000.ToInterval(LastED?.Period);
				var ae_ = context.Operators.End(ad_);
				var af_ = this.Observation_Services();
				var ag_ = context.Operators.RetrieveByValueSet<Encounter>(af_, null);
				bool? ah_(Encounter LastObs)
				{
					var bt_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(LastObs?.StatusElement?.Value);
					var bu_ = context.Operators.Equal(bt_, "finished");
					var bv_ = FHIRHelpers_4_3_000.ToInterval(LastObs?.Period);
					var bw_ = context.Operators.End(bv_);
					var bx_ = FHIRHelpers_4_3_000.ToInterval(Visit?.Period);
					var by_ = context.Operators.Start(bx_);
					var bz_ = context.Operators.Quantity((decimal?)1m, "hour");
					var ca_ = context.Operators.Subtract(by_, bz_);
					var cc_ = context.Operators.Start(bx_);
					var cd_ = context.Operators.Interval(ca_, cc_, true, true);
					var ce_ = context.Operators.ElementInInterval<CqlDateTime>(bw_, cd_, null);
					var cg_ = context.Operators.Start(bx_);
					var ch_ = context.Operators.Not((bool?)(cg_ is null));
					var ci_ = context.Operators.And(ce_, ch_);
					var cj_ = context.Operators.And(bu_, ci_);

					return cj_;
				};
				var ai_ = context.Operators.WhereOrNull<Encounter>(ag_, ah_);
				object aj_(Encounter @this)
				{
					var ck_ = FHIRHelpers_4_3_000.ToInterval(@this?.Period);
					var cl_ = context.Operators.End(ck_);

					return cl_;
				};
				var ak_ = context.Operators.ListSortBy<Encounter>(ai_, aj_, System.ComponentModel.ListSortDirection.Ascending);
				var al_ = context.Operators.LastOfList<Encounter>(ak_);
				var am_ = FHIRHelpers_4_3_000.ToInterval(al_?.Period);
				var an_ = context.Operators.Start(am_);
				var ao_ = FHIRHelpers_4_3_000.ToInterval(Visit?.Period);
				var ap_ = context.Operators.Start(ao_);
				var aq_ = context.Operators.Quantity((decimal?)1m, "hour");
				var ar_ = context.Operators.Subtract((an_ ?? ap_), aq_);
				var at_ = context.Operators.RetrieveByValueSet<Encounter>(af_, null);
				bool? au_(Encounter LastObs)
				{
					var cm_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(LastObs?.StatusElement?.Value);
					var cn_ = context.Operators.Equal(cm_, "finished");
					var co_ = FHIRHelpers_4_3_000.ToInterval(LastObs?.Period);
					var cp_ = context.Operators.End(co_);
					var cq_ = FHIRHelpers_4_3_000.ToInterval(Visit?.Period);
					var cr_ = context.Operators.Start(cq_);
					var cs_ = context.Operators.Quantity((decimal?)1m, "hour");
					var ct_ = context.Operators.Subtract(cr_, cs_);
					var cv_ = context.Operators.Start(cq_);
					var cw_ = context.Operators.Interval(ct_, cv_, true, true);
					var cx_ = context.Operators.ElementInInterval<CqlDateTime>(cp_, cw_, null);
					var cz_ = context.Operators.Start(cq_);
					var da_ = context.Operators.Not((bool?)(cz_ is null));
					var db_ = context.Operators.And(cx_, da_);
					var dc_ = context.Operators.And(cn_, db_);

					return dc_;
				};
				var av_ = context.Operators.WhereOrNull<Encounter>(at_, au_);
				object aw_(Encounter @this)
				{
					var dd_ = FHIRHelpers_4_3_000.ToInterval(@this?.Period);
					var de_ = context.Operators.End(dd_);

					return de_;
				};
				var ax_ = context.Operators.ListSortBy<Encounter>(av_, aw_, System.ComponentModel.ListSortDirection.Ascending);
				var ay_ = context.Operators.LastOfList<Encounter>(ax_);
				var az_ = FHIRHelpers_4_3_000.ToInterval(ay_?.Period);
				var ba_ = context.Operators.Start(az_);
				var bc_ = context.Operators.Start(ao_);
				var bd_ = context.Operators.Interval(ar_, (ba_ ?? bc_), true, true);
				var be_ = context.Operators.ElementInInterval<CqlDateTime>(ae_, bd_, null);
				var bg_ = context.Operators.RetrieveByValueSet<Encounter>(af_, null);
				bool? bh_(Encounter LastObs)
				{
					var df_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(LastObs?.StatusElement?.Value);
					var dg_ = context.Operators.Equal(df_, "finished");
					var dh_ = FHIRHelpers_4_3_000.ToInterval(LastObs?.Period);
					var di_ = context.Operators.End(dh_);
					var dj_ = FHIRHelpers_4_3_000.ToInterval(Visit?.Period);
					var dk_ = context.Operators.Start(dj_);
					var dl_ = context.Operators.Quantity((decimal?)1m, "hour");
					var dm_ = context.Operators.Subtract(dk_, dl_);
					var do_ = context.Operators.Start(dj_);
					var dp_ = context.Operators.Interval(dm_, do_, true, true);
					var dq_ = context.Operators.ElementInInterval<CqlDateTime>(di_, dp_, null);
					var ds_ = context.Operators.Start(dj_);
					var dt_ = context.Operators.Not((bool?)(ds_ is null));
					var du_ = context.Operators.And(dq_, dt_);
					var dv_ = context.Operators.And(dg_, du_);

					return dv_;
				};
				var bi_ = context.Operators.WhereOrNull<Encounter>(bg_, bh_);
				object bj_(Encounter @this)
				{
					var dw_ = FHIRHelpers_4_3_000.ToInterval(@this?.Period);
					var dx_ = context.Operators.End(dw_);

					return dx_;
				};
				var bk_ = context.Operators.ListSortBy<Encounter>(bi_, bj_, System.ComponentModel.ListSortDirection.Ascending);
				var bl_ = context.Operators.LastOfList<Encounter>(bk_);
				var bm_ = FHIRHelpers_4_3_000.ToInterval(bl_?.Period);
				var bn_ = context.Operators.Start(bm_);
				var bp_ = context.Operators.Start(ao_);
				var bq_ = context.Operators.Not((bool?)((bn_ ?? bp_) is null));
				var br_ = context.Operators.And(be_, bq_);
				var bs_ = context.Operators.And(ac_, br_);

				return bs_;
			};
			var h_ = context.Operators.WhereOrNull<Encounter>(f_, g_);
			object i_(Encounter @this)
			{
				var dy_ = FHIRHelpers_4_3_000.ToInterval(@this?.Period);
				var dz_ = context.Operators.End(dy_);

				return dz_;
			};
			var j_ = context.Operators.ListSortBy<Encounter>(h_, i_, System.ComponentModel.ListSortDirection.Ascending);
			var k_ = context.Operators.LastOfList<Encounter>(j_);
			var l_ = FHIRHelpers_4_3_000.ToInterval(k_?.Period);
			var m_ = context.Operators.Start(l_);
			var n_ = this.Observation_Services();
			var o_ = context.Operators.RetrieveByValueSet<Encounter>(n_, null);
			bool? p_(Encounter LastObs)
			{
				var ea_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(LastObs?.StatusElement?.Value);
				var eb_ = context.Operators.Equal(ea_, "finished");
				var ec_ = FHIRHelpers_4_3_000.ToInterval(LastObs?.Period);
				var ed_ = context.Operators.End(ec_);
				var ee_ = FHIRHelpers_4_3_000.ToInterval(Visit?.Period);
				var ef_ = context.Operators.Start(ee_);
				var eg_ = context.Operators.Quantity((decimal?)1m, "hour");
				var eh_ = context.Operators.Subtract(ef_, eg_);
				var ej_ = context.Operators.Start(ee_);
				var ek_ = context.Operators.Interval(eh_, ej_, true, true);
				var el_ = context.Operators.ElementInInterval<CqlDateTime>(ed_, ek_, null);
				var en_ = context.Operators.Start(ee_);
				var eo_ = context.Operators.Not((bool?)(en_ is null));
				var ep_ = context.Operators.And(el_, eo_);
				var eq_ = context.Operators.And(eb_, ep_);

				return eq_;
			};
			var q_ = context.Operators.WhereOrNull<Encounter>(o_, p_);
			object r_(Encounter @this)
			{
				var er_ = FHIRHelpers_4_3_000.ToInterval(@this?.Period);
				var es_ = context.Operators.End(er_);

				return es_;
			};
			var s_ = context.Operators.ListSortBy<Encounter>(q_, r_, System.ComponentModel.ListSortDirection.Ascending);
			var t_ = context.Operators.LastOfList<Encounter>(s_);
			var u_ = FHIRHelpers_4_3_000.ToInterval(t_?.Period);
			var v_ = context.Operators.Start(u_);
			var w_ = FHIRHelpers_4_3_000.ToInterval(Visit?.Period);
			var x_ = context.Operators.Start(w_);
			var z_ = context.Operators.End(w_);
			var aa_ = context.Operators.Interval((m_ ?? (v_ ?? x_)), z_, true, true);

			return aa_;
		};
		var c_ = context.Operators.SelectOrNull<Encounter, CqlInterval<CqlDateTime>>(a_, b_);
		var d_ = context.Operators.SingleOrNull<CqlInterval<CqlDateTime>>(c_);

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
			var f_ = this.GetLocation(HospitalLocation?.Location);
			CqlConcept g_(CodeableConcept @this)
			{
				var o_ = FHIRHelpers_4_3_000.ToConcept(@this);

				return o_;
			};
			var h_ = context.Operators.SelectOrNull<CodeableConcept, CqlConcept>(f_?.Type, g_);
			var i_ = this.Intensive_Care_Unit();
			var j_ = context.Operators.ConceptsInValueSet(h_, i_);
			var k_ = FHIRHelpers_4_3_000.ToInterval(Encounter?.Period);
			var l_ = FHIRHelpers_4_3_000.ToInterval(HospitalLocation?.Period);
			var m_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(k_, l_, null);
			var n_ = context.Operators.And(j_, m_);

			return n_;
		};
		var b_ = context.Operators.WhereOrNull<Encounter.LocationComponent>((Encounter?.Location as IEnumerable<Encounter.LocationComponent>), a_);
		object c_(Encounter.LocationComponent @this)
		{
			var p_ = FHIRHelpers_4_3_000.ToInterval(@this?.Period);
			var q_ = context.Operators.Start(p_);

			return q_;
		};
		var d_ = context.Operators.ListSortBy<Encounter.LocationComponent>(b_, c_, System.ComponentModel.ListSortDirection.Ascending);
		var e_ = context.Operators.FirstOfList<Encounter.LocationComponent>(d_);

		return e_;
	}

    [CqlDeclaration("firstInpatientIntensiveCareUnit")]
    [CqlTag("description", "First Inpatient Intensive Care Unit returns the first intensive care unit for the given encounter, without considering any immediately prior emergency department visit.")]
	public Encounter.LocationComponent firstInpatientIntensiveCareUnit(Encounter Encounter)
	{
		bool? a_(Encounter.LocationComponent HospitalLocation)
		{
			var f_ = this.GetLocation(HospitalLocation?.Location);
			CqlConcept g_(CodeableConcept @this)
			{
				var o_ = FHIRHelpers_4_3_000.ToConcept(@this);

				return o_;
			};
			var h_ = context.Operators.SelectOrNull<CodeableConcept, CqlConcept>(f_?.Type, g_);
			var i_ = this.Intensive_Care_Unit();
			var j_ = context.Operators.ConceptsInValueSet(h_, i_);
			var k_ = FHIRHelpers_4_3_000.ToInterval(Encounter?.Period);
			var l_ = FHIRHelpers_4_3_000.ToInterval(HospitalLocation?.Period);
			var m_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(k_, l_, null);
			var n_ = context.Operators.And(j_, m_);

			return n_;
		};
		var b_ = context.Operators.WhereOrNull<Encounter.LocationComponent>((Encounter?.Location as IEnumerable<Encounter.LocationComponent>), a_);
		object c_(Encounter.LocationComponent @this)
		{
			var p_ = FHIRHelpers_4_3_000.ToInterval(@this?.Period);
			var q_ = context.Operators.Start(p_);

			return q_;
		};
		var d_ = context.Operators.ListSortBy<Encounter.LocationComponent>(b_, c_, System.ComponentModel.ListSortDirection.Ascending);
		var e_ = context.Operators.FirstOfList<Encounter.LocationComponent>(d_);

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
				var g_ = QICoreCommon_2_0_000.getId(D?.Condition?.ReferenceElement?.Value);
				var h_ = context.Operators.Equal(C?.IdElement?.Value, g_);

				return h_;
			};
			var e_ = context.Operators.WhereOrNull<Condition>(c_, d_);
			var f_ = context.Operators.SingleOrNull<Condition>(e_);

			return f_;
		};
		var b_ = context.Operators.SelectOrNull<Encounter.DiagnosisComponent, Condition>((Encounter?.Diagnosis as IEnumerable<Encounter.DiagnosisComponent>), a_);

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
				var g_ = QICoreCommon_2_0_000.getId(D?.Condition?.ReferenceElement?.Value);
				var h_ = context.Operators.Equal(C?.IdElement?.Value, g_);

				return h_;
			};
			var e_ = context.Operators.WhereOrNull<Condition>(c_, d_);
			var f_ = context.Operators.SingleOrNull<Condition>(e_);

			return f_;
		};
		var b_ = context.Operators.SelectOrNull<Encounter.DiagnosisComponent, Condition>((Encounter?.Diagnosis as IEnumerable<Encounter.DiagnosisComponent>), a_);

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
			var e_ = QICoreCommon_2_0_000.getId(reference?.ReferenceElement?.Value);
			var f_ = context.Operators.Equal(C?.IdElement?.Value, e_);

			return f_;
		};
		var c_ = context.Operators.WhereOrNull<Condition>(a_, b_);
		var d_ = context.Operators.SingleOrNull<Condition>(c_);

		return d_;
	}

    [CqlDeclaration("getCondition")]
    [CqlTag("description", "Returns the Condition resource for the given reference")]
	public Condition getCondition(ResourceReference reference)
	{
		var a_ = context.Operators.RetrieveByValueSet<Condition>(null, null);
		bool? b_(Condition C)
		{
			var e_ = QICoreCommon_2_0_000.getId(reference?.ReferenceElement?.Value);
			var f_ = context.Operators.Equal(C?.IdElement?.Value, e_);

			return f_;
		};
		var c_ = context.Operators.WhereOrNull<Condition>(a_, b_);
		var d_ = context.Operators.SingleOrNull<Condition>(c_);

		return d_;
	}

    [CqlDeclaration("PrincipalDiagnosis")]
    [CqlTag("description", "Returns the condition that is specified as the principal diagnosis for the encounter")]
    [CqlTag("deprecated", "This function is deprecated. Use the fluent function `principalDiagnosis()` instead.")]
	public Condition PrincipalDiagnosis(Encounter Encounter)
	{
		bool? a_(Encounter.DiagnosisComponent D)
		{
			var f_ = context.Operators.Equal(D?.RankElement?.Value, (int?)1);

			return f_;
		};
		var b_ = context.Operators.WhereOrNull<Encounter.DiagnosisComponent>((Encounter?.Diagnosis as IEnumerable<Encounter.DiagnosisComponent>), a_);
		Condition c_(Encounter.DiagnosisComponent PD)
		{
			var g_ = context.Operators.RetrieveByValueSet<Condition>(null, null);
			bool? h_(Condition C)
			{
				var k_ = QICoreCommon_2_0_000.getId(PD?.Condition?.ReferenceElement?.Value);
				var l_ = context.Operators.Equal(C?.IdElement?.Value, k_);

				return l_;
			};
			var i_ = context.Operators.WhereOrNull<Condition>(g_, h_);
			var j_ = context.Operators.SingleOrNull<Condition>(i_);

			return j_;
		};
		var d_ = context.Operators.SelectOrNull<Encounter.DiagnosisComponent, Condition>(b_, c_);
		var e_ = context.Operators.SingleOrNull<Condition>(d_);

		return e_;
	}

    [CqlDeclaration("principalDiagnosis")]
    [CqlTag("description", "Returns the condition that is specified as the principal diagnosis for the encounter")]
	public Condition principalDiagnosis(Encounter Encounter)
	{
		bool? a_(Encounter.DiagnosisComponent D)
		{
			var f_ = context.Operators.Equal(D?.RankElement?.Value, (int?)1);

			return f_;
		};
		var b_ = context.Operators.WhereOrNull<Encounter.DiagnosisComponent>((Encounter?.Diagnosis as IEnumerable<Encounter.DiagnosisComponent>), a_);
		Condition c_(Encounter.DiagnosisComponent PD)
		{
			var g_ = context.Operators.RetrieveByValueSet<Condition>(null, null);
			bool? h_(Condition C)
			{
				var k_ = QICoreCommon_2_0_000.getId(PD?.Condition?.ReferenceElement?.Value);
				var l_ = context.Operators.Equal(C?.IdElement?.Value, k_);

				return l_;
			};
			var i_ = context.Operators.WhereOrNull<Condition>(g_, h_);
			var j_ = context.Operators.SingleOrNull<Condition>(i_);

			return j_;
		};
		var d_ = context.Operators.SelectOrNull<Encounter.DiagnosisComponent, Condition>(b_, c_);
		var e_ = context.Operators.SingleOrNull<Condition>(d_);

		return e_;
	}

    [CqlDeclaration("getLocation")]
    [CqlTag("description", "Returns the Location resource specified by the given reference.")]
	public Location getLocation(ResourceReference reference)
	{
		var a_ = context.Operators.RetrieveByValueSet<Location>(null, null);
		bool? b_(Location L)
		{
			var e_ = QICoreCommon_2_0_000.getId(reference?.ReferenceElement?.Value);
			var f_ = context.Operators.Equal(L?.IdElement?.Value, e_);

			return f_;
		};
		var c_ = context.Operators.WhereOrNull<Location>(a_, b_);
		var d_ = context.Operators.SingleOrNull<Location>(c_);

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
				var c_ = FHIRHelpers_4_3_000.ToValue(request?.Medication);
				var d_ = c_ is CqlConcept;

				return d_;
			};
			if (b_())
			{
				var e_ = FHIRHelpers_4_3_000.ToValue(request?.Medication);

				return (e_ as CqlConcept);
			}
			else
			{
				var f_ = context.Operators.RetrieveByValueSet<Medication>(null, null);
				bool? g_(Medication M)
				{
					var k_ = FHIRHelpers_4_3_000.ToValue(request?.Medication);
					var l_ = QICoreCommon_2_0_000.getId(((k_ as ResourceReference)?.ReferenceElement)?.Value);
					var m_ = context.Operators.Equal(M?.IdElement?.Value, l_);

					return m_;
				};
				var h_ = context.Operators.WhereOrNull<Medication>(f_, g_);
				var i_ = context.Operators.SingleOrNull<Medication>(h_);
				var j_ = FHIRHelpers_4_3_000.ToConcept(i_?.Code);

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
				var c_ = FHIRHelpers_4_3_000.ToValue(request?.Medication);
				var d_ = c_ is CqlConcept;

				return d_;
			};
			if (b_())
			{
				var e_ = FHIRHelpers_4_3_000.ToValue(request?.Medication);

				return (e_ as CqlConcept);
			}
			else
			{
				var f_ = context.Operators.RetrieveByValueSet<Medication>(null, null);
				bool? g_(Medication M)
				{
					var k_ = FHIRHelpers_4_3_000.ToValue(request?.Medication);
					var l_ = QICoreCommon_2_0_000.getId(((k_ as ResourceReference)?.ReferenceElement)?.Value);
					var m_ = context.Operators.Equal(M?.IdElement?.Value, l_);

					return m_;
				};
				var h_ = context.Operators.WhereOrNull<Medication>(f_, g_);
				var i_ = context.Operators.SingleOrNull<Medication>(h_);
				var j_ = FHIRHelpers_4_3_000.ToConcept(i_?.Code);

				return j_;
			};
		};

		return a_();
	}

}
