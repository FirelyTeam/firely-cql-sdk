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
[System.CodeDom.Compiler.GeneratedCode(".NET Code Generation", "1.0.0.0")]
[CqlLibrary("VTEFHIR4", "4.8.000")]
public class VTEFHIR4_4_8_000
{

    public static VTEFHIR4_4_8_000 Instance { get; }  = new();

    [CqlDeclaration("Intensive Care Unit")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1029.206")]
	public CqlValueSet Intensive_Care_Unit(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1029.206", null);

    [CqlDeclaration("Measurement Period")]
	public CqlInterval<CqlDateTime> Measurement_Period(CqlContext context)
	{
		var a_ = context.Operators.ConvertIntegerToDecimal(default);
		var b_ = context.Operators.DateTime((int?)2019, (int?)1, (int?)1, (int?)0, (int?)0, (int?)0, (int?)0, a_);
		var d_ = context.Operators.DateTime((int?)2020, (int?)1, (int?)1, (int?)0, (int?)0, (int?)0, (int?)0, a_);
		var e_ = context.Operators.Interval(b_, d_, true, false);
		var f_ = context.ResolveParameter("VTEFHIR4-4.8.000", "Measurement Period", e_);

		return (CqlInterval<CqlDateTime>)f_;
	}

    [CqlDeclaration("Patient")]
	public Patient Patient(CqlContext context)
	{
		var a_ = context.Operators.RetrieveByValueSet<Patient>(null, null);
		var b_ = context.Operators.SingleOrNull<Patient>(a_);

		return b_;
	}

    [CqlDeclaration("FirstInpatientIntensiveCareUnit")]
	public Encounter.LocationComponent FirstInpatientIntensiveCareUnit(CqlContext context, Encounter Encounter)
	{
		bool? a_(Encounter.LocationComponent HospitalLocation)
		{
			var f_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.GetLocation(context, HospitalLocation?.Location);
			CqlConcept g_(CodeableConcept X)
			{
				var o_ = FHIRHelpers_4_0_001.Instance.ToConcept(context, X);

				return o_;
			};
			var h_ = context.Operators.SelectOrNull<CodeableConcept, CqlConcept>((f_?.Type as IEnumerable<CodeableConcept>), g_);
			var i_ = this.Intensive_Care_Unit(context);
			var j_ = context.Operators.ConceptsInValueSet(h_, i_);
			var k_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, Encounter?.Period);
			var l_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, HospitalLocation?.Period);
			var m_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(k_, l_, null);
			var n_ = context.Operators.And(j_, m_);

			return n_;
		};
		var b_ = context.Operators.WhereOrNull<Encounter.LocationComponent>((Encounter?.Location as IEnumerable<Encounter.LocationComponent>), a_);
		object c_(Encounter.LocationComponent @this)
		{
			var p_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, @this?.Period);
			var q_ = context.Operators.Start(p_);

			return q_;
		};
		var d_ = context.Operators.ListSortBy<Encounter.LocationComponent>(b_, c_, System.ComponentModel.ListSortDirection.Ascending);
		var e_ = context.Operators.FirstOfList<Encounter.LocationComponent>(d_);

		return e_;
	}

    [CqlDeclaration("FirstICULocationPeriod")]
	public Period FirstICULocationPeriod(CqlContext context, Encounter Encounter)
	{
		var a_ = this.FirstInpatientIntensiveCareUnit(context, Encounter);

		return a_?.Period;
	}

    [CqlDeclaration("StartOfFirstICU")]
	public CqlDateTime StartOfFirstICU(CqlContext context, Encounter Encounter)
	{
		var a_ = this.FirstICULocationPeriod(context, Encounter);
		var b_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, a_);
		var c_ = context.Operators.Start(b_);

		return c_;
	}

    [CqlDeclaration("CalendarDayOfOrDayAfter")]
	public CqlInterval<CqlDate> CalendarDayOfOrDayAfter(CqlContext context, CqlDateTime StartValue)
	{
		var a_ = context.Operators.DateFrom(StartValue);
		var c_ = context.Operators.Quantity(1m, "day");
		var d_ = context.Operators.Add(a_, c_);
		var e_ = context.Operators.Interval(a_, d_, true, true);

		return e_;
	}

    [CqlDeclaration("FromDayOfStartOfHospitalizationToDayAfterAdmission")]
	public CqlInterval<CqlDate> FromDayOfStartOfHospitalizationToDayAfterAdmission(CqlContext context, Encounter Encounter)
	{
		var a_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.HospitalizationWithObservation(context, Encounter);
		var b_ = context.Operators.Start(a_);
		var c_ = context.Operators.DateFrom(b_);
		var d_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, Encounter?.Period);
		var e_ = context.Operators.Start(d_);
		var f_ = context.Operators.DateFrom(e_);
		var g_ = context.Operators.Quantity(1m, "day");
		var h_ = context.Operators.Add(f_, g_);
		var i_ = context.Operators.Interval(c_, h_, true, true);

		return i_;
	}

    [CqlDeclaration("FromDayOfStartOfHospitalizationToDayAfterFirstICU")]
	public CqlInterval<CqlDate> FromDayOfStartOfHospitalizationToDayAfterFirstICU(CqlContext context, Encounter Encounter)
	{
		var a_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.HospitalizationWithObservation(context, Encounter);
		var b_ = context.Operators.Start(a_);
		var c_ = context.Operators.DateFrom(b_);
		var d_ = this.StartOfFirstICU(context, Encounter);
		var e_ = context.Operators.DateFrom(d_);
		var f_ = context.Operators.Quantity(1m, "day");
		var g_ = context.Operators.Add(e_, f_);
		var h_ = context.Operators.Interval(c_, g_, true, true);

		return h_;
	}

}