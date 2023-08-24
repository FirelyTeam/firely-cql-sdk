using System;
using System.Linq;
using System.Collections.Generic;
using Hl7.Cql.Runtime;
using Hl7.Cql.Primitives;
using Hl7.Cql;
using Hl7.Cql.ValueSets;
using Hl7.Cql.Iso8601;
using Hl7.Fhir.Model;
using Range = Hl7.Fhir.Model.Range;
using Task = Hl7.Fhir.Model.Task;
[System.CodeDom.Compiler.GeneratedCode(".NET Code Generation", "0.0.1.0")]
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
    public CqlValueSet Intensive_Care_Unit() => __Intensive_Care_Unit.Value;

    private CqlInterval<CqlDateTime> Measurement_Period_Value()
	{
		var a_ = context?.Operators.ConvertIntegerToDecimal(default);
		var b_ = context?.Operators.DateTime((int?)2019, (int?)1, (int?)1, (int?)0, (int?)0, (int?)0, (int?)0, a_);
		var c_ = context?.Operators.ConvertIntegerToDecimal(default);
		var d_ = context?.Operators.DateTime((int?)2020, (int?)1, (int?)1, (int?)0, (int?)0, (int?)0, (int?)0, c_);
		var e_ = context?.Operators.Interval(b_, d_, true, false);
		var f_ = (e_ as object);
		var g_ = context.ResolveParameter("VTEFHIR4-4.8.000", "Measurement Period", f_);

		return (CqlInterval<CqlDateTime>)g_;
	}

    [CqlDeclaration("Measurement Period")]
    public CqlInterval<CqlDateTime> Measurement_Period() => __Measurement_Period.Value;

    private Patient Patient_Value()
	{
		var a_ = context?.DataRetriever.RetrieveByValueSet<Patient>(null, null);

		return context?.Operators.SingleOrNull<Patient>(a_);
	}

    [CqlDeclaration("Patient")]
    public Patient Patient() => __Patient.Value;

    [CqlDeclaration("FirstInpatientIntensiveCareUnit")]
    public Encounter.LocationComponent FirstInpatientIntensiveCareUnit(Encounter Encounter)
	{
		var o_ = (Encounter?.Location as IEnumerable<Encounter.LocationComponent>);
		var p_ = (Encounter.LocationComponent HospitalLocation) =>
		{
			var a_ = HospitalLocation?.Location;
			var b_ = MATGlobalCommonFunctionsFHIR4_6_1_000.GetLocation(a_);
			var c_ = (b_?.Type as IEnumerable<CodeableConcept>);
			var d_ = (CodeableConcept X) => FHIRHelpers_4_0_001.ToConcept(X);
			var e_ = context?.Operators.SelectOrNull<CodeableConcept, CqlConcept>(c_, d_);
			var f_ = this.Intensive_Care_Unit();
			var g_ = context?.Operators.ConceptsInValueSet(e_, f_);
			var h_ = Encounter?.Period;
			var i_ = FHIRHelpers_4_0_001.ToInterval(h_);
			var j_ = HospitalLocation?.Period;
			var k_ = FHIRHelpers_4_0_001.ToInterval(j_);
			var l_ = context?.Operators.IntervalIncludesInterval<CqlDateTime>(i_, k_, null);

			return context?.Operators.And(g_, l_);
		};
		var q_ = context?.Operators.WhereOrNull<Encounter.LocationComponent>(o_, p_);
		var r_ = (Encounter.LocationComponent @this) =>
		{
			var m_ = @this?.Period;
			var n_ = FHIRHelpers_4_0_001.ToInterval(m_);

			return context?.Operators.Start(n_);
		};
		var s_ = context?.Operators.ListSortBy<Encounter.LocationComponent>(q_, r_, System.ComponentModel.ListSortDirection.Ascending);

		return context?.Operators.FirstOfList<Encounter.LocationComponent>(s_);
	}


    [CqlDeclaration("FirstICULocationPeriod")]
    public Period FirstICULocationPeriod(Encounter Encounter) =>
		this.FirstInpatientIntensiveCareUnit(Encounter)?.Period;


    [CqlDeclaration("StartOfFirstICU")]
    public CqlDateTime StartOfFirstICU(Encounter Encounter)
	{
		var a_ = this.FirstICULocationPeriod(Encounter);
		var b_ = FHIRHelpers_4_0_001.ToInterval(a_);

		return context?.Operators.Start(b_);
	}


    [CqlDeclaration("CalendarDayOfOrDayAfter")]
    public CqlInterval<CqlDate> CalendarDayOfOrDayAfter(CqlDateTime StartValue)
	{
		var a_ = context?.Operators.DateFrom(StartValue);
		var b_ = context?.Operators.DateFrom(StartValue);
		var c_ = context?.Operators.Quantity(1m, "day");
		var d_ = context?.Operators.Add(b_, c_);

		return context?.Operators.Interval(a_, d_, true, true);
	}


    [CqlDeclaration("FromDayOfStartOfHospitalizationToDayAfterAdmission")]
    public CqlInterval<CqlDate> FromDayOfStartOfHospitalizationToDayAfterAdmission(Encounter Encounter)
	{
		var a_ = MATGlobalCommonFunctionsFHIR4_6_1_000.HospitalizationWithObservation(Encounter);
		var b_ = context?.Operators.Start(a_);
		var c_ = context?.Operators.DateFrom(b_);
		var d_ = Encounter?.Period;
		var e_ = FHIRHelpers_4_0_001.ToInterval(d_);
		var f_ = context?.Operators.Start(e_);
		var g_ = context?.Operators.DateFrom(f_);
		var h_ = context?.Operators.Quantity(1m, "day");
		var i_ = context?.Operators.Add(g_, h_);

		return context?.Operators.Interval(c_, i_, true, true);
	}


    [CqlDeclaration("FromDayOfStartOfHospitalizationToDayAfterFirstICU")]
    public CqlInterval<CqlDate> FromDayOfStartOfHospitalizationToDayAfterFirstICU(Encounter Encounter)
	{
		var a_ = MATGlobalCommonFunctionsFHIR4_6_1_000.HospitalizationWithObservation(Encounter);
		var b_ = context?.Operators.Start(a_);
		var c_ = context?.Operators.DateFrom(b_);
		var d_ = this.StartOfFirstICU(Encounter);
		var e_ = context?.Operators.DateFrom(d_);
		var f_ = context?.Operators.Quantity(1m, "day");
		var g_ = context?.Operators.Add(e_, f_);

		return context?.Operators.Interval(c_, g_, true, true);
	}


}