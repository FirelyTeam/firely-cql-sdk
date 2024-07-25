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
[System.CodeDom.Compiler.GeneratedCode(".NET Code Generation", "2.0.0.0")]
[CqlLibrary("VTEFHIR4", "4.8.000")]
public class VTEFHIR4_4_8_000
{


    internal CqlContext context;

    #region Cached values

    internal Lazy<CqlValueSet> __Intensive_Care_Unit;
    internal Lazy<CqlInterval<CqlDateTime>> __Measurement_Period;
    internal Lazy<Patient> __Patient;

    #endregion
    public VTEFHIR4_4_8_000(CqlContext context)
    {
        this.context = context ?? throw new ArgumentNullException("context");

        MATGlobalCommonFunctionsFHIR4_6_1_000 = new MATGlobalCommonFunctionsFHIR4_6_1_000(context);
        FHIRHelpers_4_0_001 = new FHIRHelpers_4_0_001(context);

        __Intensive_Care_Unit = new Lazy<CqlValueSet>(this.Intensive_Care_Unit_Value);
        __Measurement_Period = new Lazy<CqlInterval<CqlDateTime>>(this.Measurement_Period_Value);
        __Patient = new Lazy<Patient>(this.Patient_Value);
    }
    #region Dependencies

    public MATGlobalCommonFunctionsFHIR4_6_1_000 MATGlobalCommonFunctionsFHIR4_6_1_000 { get; }
    public FHIRHelpers_4_0_001 FHIRHelpers_4_0_001 { get; }

    #endregion

	private CqlValueSet Intensive_Care_Unit_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1029.206", null);

    [CqlDeclaration("Intensive Care Unit")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1029.206")]
	public CqlValueSet Intensive_Care_Unit() => 
		__Intensive_Care_Unit.Value;

	private CqlInterval<CqlDateTime> Measurement_Period_Value()
	{
		var a_ = context.Operators.DateTime(2019, 1, 1, 0, 0, 0, 0, default);
		var b_ = context.Operators.DateTime(2020, 1, 1, 0, 0, 0, 0, default);
		var c_ = context.Operators.Interval(a_, b_, true, false);
		var d_ = context.ResolveParameter("VTEFHIR4-4.8.000", "Measurement Period", c_);

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

    [CqlDeclaration("FirstInpatientIntensiveCareUnit")]
	public Encounter.LocationComponent FirstInpatientIntensiveCareUnit(Encounter Encounter)
	{
		bool? a_(Encounter.LocationComponent HospitalLocation)
		{
			var f_ = HospitalLocation.Location;
			var g_ = MATGlobalCommonFunctionsFHIR4_6_1_000.GetLocation(f_);
			var h_ = g_.Type;
			CqlConcept i_(CodeableConcept X)
			{
				var s_ = FHIRHelpers_4_0_001.ToConcept(X);

				return s_;
			};
			var j_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)h_, i_);
			var k_ = this.Intensive_Care_Unit();
			var l_ = context.Operators.ConceptsInValueSet(j_, k_);
			var m_ = Encounter.Period;
			var n_ = FHIRHelpers_4_0_001.ToInterval(m_);
			var o_ = HospitalLocation.Period;
			var p_ = FHIRHelpers_4_0_001.ToInterval(o_);
			var q_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(n_, p_, null);
			var r_ = context.Operators.And(l_, q_);

			return r_;
		};
		var b_ = context.Operators.Where<Encounter.LocationComponent>((IEnumerable<Encounter.LocationComponent>)Encounter.Location, a_);
		object c_(Encounter.LocationComponent @this)
		{
			var t_ = @this.Period;
			var u_ = FHIRHelpers_4_0_001.ToInterval(t_);
			var v_ = context.Operators.Start(u_);

			return v_;
		};
		var d_ = context.Operators.SortBy<Encounter.LocationComponent>(b_, c_, System.ComponentModel.ListSortDirection.Ascending);
		var e_ = context.Operators.First<Encounter.LocationComponent>(d_);

		return e_;
	}

    [CqlDeclaration("FirstICULocationPeriod")]
	public Period FirstICULocationPeriod(Encounter Encounter)
	{
		var a_ = this.FirstInpatientIntensiveCareUnit(Encounter);

		return a_.Period;
	}

    [CqlDeclaration("StartOfFirstICU")]
	public CqlDateTime StartOfFirstICU(Encounter Encounter)
	{
		var a_ = this.FirstICULocationPeriod(Encounter);
		var b_ = FHIRHelpers_4_0_001.ToInterval(a_);
		var c_ = context.Operators.Start(b_);

		return c_;
	}

    [CqlDeclaration("CalendarDayOfOrDayAfter")]
	public CqlInterval<CqlDate> CalendarDayOfOrDayAfter(CqlDateTime StartValue)
	{
		var a_ = context.Operators.DateFrom(StartValue);
		var c_ = context.Operators.Quantity(1m, "day");
		var d_ = context.Operators.Add(a_, c_);
		var e_ = context.Operators.Interval(a_, d_, true, true);

		return e_;
	}

    [CqlDeclaration("FromDayOfStartOfHospitalizationToDayAfterAdmission")]
	public CqlInterval<CqlDate> FromDayOfStartOfHospitalizationToDayAfterAdmission(Encounter Encounter)
	{
		var a_ = MATGlobalCommonFunctionsFHIR4_6_1_000.HospitalizationWithObservation(Encounter);
		var b_ = context.Operators.Start(a_);
		var c_ = context.Operators.DateFrom(b_);
		var d_ = FHIRHelpers_4_0_001.ToInterval(Encounter.Period);
		var e_ = context.Operators.Start(d_);
		var f_ = context.Operators.DateFrom(e_);
		var g_ = context.Operators.Quantity(1m, "day");
		var h_ = context.Operators.Add(f_, g_);
		var i_ = context.Operators.Interval(c_, h_, true, true);

		return i_;
	}

    [CqlDeclaration("FromDayOfStartOfHospitalizationToDayAfterFirstICU")]
	public CqlInterval<CqlDate> FromDayOfStartOfHospitalizationToDayAfterFirstICU(Encounter Encounter)
	{
		var a_ = MATGlobalCommonFunctionsFHIR4_6_1_000.HospitalizationWithObservation(Encounter);
		var b_ = context.Operators.Start(a_);
		var c_ = context.Operators.DateFrom(b_);
		var d_ = this.StartOfFirstICU(Encounter);
		var e_ = context.Operators.DateFrom(d_);
		var f_ = context.Operators.Quantity(1m, "day");
		var g_ = context.Operators.Add(e_, f_);
		var h_ = context.Operators.Interval(c_, g_, true, true);

		return h_;
	}

}
