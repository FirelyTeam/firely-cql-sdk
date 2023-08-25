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

    private CqlValueSet Intensive_Care_Unit_Value()
	{
		var a_ = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1029.206", null);

		return a_;
	}

    [CqlDeclaration("Intensive Care Unit")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1029.206")]
    public CqlValueSet Intensive_Care_Unit() => __Intensive_Care_Unit.Value;

    private CqlInterval<CqlDateTime> Measurement_Period_Value()
	{
		var a_ = (int?)2019;
		var b_ = (int?)1;
		var d_ = (int?)0;
		var h_ = context.Operators;
		var i_ = h_.ConvertIntegerToDecimal(default);
		var k_ = h_.DateTime(a_, b_, b_, d_, d_, d_, d_, i_);
		var l_ = (int?)2020;
		var t_ = h_.ConvertIntegerToDecimal(default);
		var v_ = h_.DateTime(l_, b_, b_, d_, d_, d_, d_, t_);
		var x_ = h_.Interval(k_, v_, true, false);
		var y_ = context.ResolveParameter("VTEFHIR4-4.8.000", "Measurement Period", x_);
		var z_ = (CqlInterval<CqlDateTime>)y_;

		return z_;
	}

    [CqlDeclaration("Measurement Period")]
    public CqlInterval<CqlDateTime> Measurement_Period() => __Measurement_Period.Value;

    private Patient Patient_Value()
	{
		var a_ = context.DataRetriever;
		var b_ = a_.RetrieveByValueSet<Patient>(null, null);
		var c_ = context.Operators;
		var d_ = c_.SingleOrNull<Patient>(b_);

		return d_;
	}

    [CqlDeclaration("Patient")]
    public Patient Patient() => __Patient.Value;

    [CqlDeclaration("FirstInpatientIntensiveCareUnit")]
    public Encounter.LocationComponent FirstInpatientIntensiveCareUnit(Encounter Encounter)
	{
		var a_ = Encounter.Location;
		var b_ = (a_ as IEnumerable<Encounter.LocationComponent>);
		var c_ = (Encounter.LocationComponent HospitalLocation) =>
		{
			var k_ = HospitalLocation.Location;
			var l_ = MATGlobalCommonFunctionsFHIR4_6_1_000.GetLocation(k_);
			var m_ = l_.Type;
			var n_ = (m_ as IEnumerable<CodeableConcept>);
			var o_ = (CodeableConcept X) =>
			{
				var ac_ = FHIRHelpers_4_0_001.ToConcept(X);

				return ac_;
			};
			var p_ = context.Operators;
			var q_ = p_.SelectOrNull<CodeableConcept, CqlConcept>(n_, o_);
			var r_ = this.Intensive_Care_Unit();
			var t_ = p_.ConceptsInValueSet(q_, r_);
			var u_ = Encounter.Period;
			var v_ = FHIRHelpers_4_0_001.ToInterval(u_);
			var w_ = HospitalLocation.Period;
			var x_ = FHIRHelpers_4_0_001.ToInterval(w_);
			var z_ = p_.IntervalIncludesInterval<CqlDateTime>(v_, x_, null);
			var ab_ = p_.And(t_, z_);

			return ab_;
		};
		var d_ = context.Operators;
		var e_ = d_.WhereOrNull<Encounter.LocationComponent>(b_, c_);
		var f_ = (Encounter.LocationComponent @this) =>
		{
			var ad_ = @this.Period;
			var ae_ = FHIRHelpers_4_0_001.ToInterval(ad_);
			var af_ = context.Operators;
			var ag_ = af_.Start(ae_);

			return ag_;
		};
		var h_ = d_.ListSortBy<Encounter.LocationComponent>(e_, f_, System.ComponentModel.ListSortDirection.Ascending);
		var j_ = d_.FirstOfList<Encounter.LocationComponent>(h_);

		return j_;
	}


    [CqlDeclaration("FirstICULocationPeriod")]
    public Period FirstICULocationPeriod(Encounter Encounter)
	{
		var a_ = this.FirstInpatientIntensiveCareUnit(Encounter);
		var b_ = a_.Period;

		return b_;
	}


    [CqlDeclaration("StartOfFirstICU")]
    public CqlDateTime StartOfFirstICU(Encounter Encounter)
	{
		var a_ = this.FirstICULocationPeriod(Encounter);
		var b_ = FHIRHelpers_4_0_001.ToInterval(a_);
		var c_ = context.Operators;
		var d_ = c_.Start(b_);

		return d_;
	}


    [CqlDeclaration("CalendarDayOfOrDayAfter")]
    public CqlInterval<CqlDate> CalendarDayOfOrDayAfter(CqlDateTime StartValue)
	{
		var a_ = context.Operators;
		var b_ = a_.DateFrom(StartValue);
		var d_ = a_.DateFrom(StartValue);
		var f_ = a_.Quantity(1m, "day");
		var h_ = a_.Add(d_, f_);
		var j_ = a_.Interval(b_, h_, true, true);

		return j_;
	}


    [CqlDeclaration("FromDayOfStartOfHospitalizationToDayAfterAdmission")]
    public CqlInterval<CqlDate> FromDayOfStartOfHospitalizationToDayAfterAdmission(Encounter Encounter)
	{
		var a_ = MATGlobalCommonFunctionsFHIR4_6_1_000.HospitalizationWithObservation(Encounter);
		var b_ = context.Operators;
		var c_ = b_.Start(a_);
		var e_ = b_.DateFrom(c_);
		var f_ = Encounter.Period;
		var g_ = FHIRHelpers_4_0_001.ToInterval(f_);
		var i_ = b_.Start(g_);
		var k_ = b_.DateFrom(i_);
		var m_ = b_.Quantity(1m, "day");
		var o_ = b_.Add(k_, m_);
		var q_ = b_.Interval(e_, o_, true, true);

		return q_;
	}


    [CqlDeclaration("FromDayOfStartOfHospitalizationToDayAfterFirstICU")]
    public CqlInterval<CqlDate> FromDayOfStartOfHospitalizationToDayAfterFirstICU(Encounter Encounter)
	{
		var a_ = MATGlobalCommonFunctionsFHIR4_6_1_000.HospitalizationWithObservation(Encounter);
		var b_ = context.Operators;
		var c_ = b_.Start(a_);
		var e_ = b_.DateFrom(c_);
		var f_ = this.StartOfFirstICU(Encounter);
		var h_ = b_.DateFrom(f_);
		var j_ = b_.Quantity(1m, "day");
		var l_ = b_.Add(h_, j_);
		var n_ = b_.Interval(e_, l_, true, true);

		return n_;
	}


}