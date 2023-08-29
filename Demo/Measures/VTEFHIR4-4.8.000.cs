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
		var a_ = context.Operators;
		var b_ = a_.ConvertIntegerToDecimal(default);
		var d_ = a_.DateTime((int?)2019, (int?)1, (int?)1, (int?)0, (int?)0, (int?)0, (int?)0, b_);
		var f_ = a_.ConvertIntegerToDecimal(default);
		var h_ = a_.DateTime((int?)2020, (int?)1, (int?)1, (int?)0, (int?)0, (int?)0, (int?)0, f_);
		var j_ = a_.Interval(d_, h_, true, false);
		var k_ = context.ResolveParameter("VTEFHIR4-4.8.000", "Measurement Period", j_);

		return (CqlInterval<CqlDateTime>)k_;
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
		var a_ = Encounter?.Location;
		bool? b_(Encounter.LocationComponent HospitalLocation)
		{
			var j_ = HospitalLocation?.Location;
			var k_ = MATGlobalCommonFunctionsFHIR4_6_1_000.GetLocation(j_);
			var l_ = k_?.Type;
			CqlConcept m_(CodeableConcept X)
			{
				var aa_ = FHIRHelpers_4_0_001.ToConcept(X);

				return aa_;
			};
			var n_ = context.Operators;
			var o_ = n_.SelectOrNull<CodeableConcept, CqlConcept>((l_ as IEnumerable<CodeableConcept>), m_);
			var p_ = this.Intensive_Care_Unit();
			var r_ = n_.ConceptsInValueSet(o_, p_);
			var s_ = Encounter?.Period;
			var t_ = FHIRHelpers_4_0_001.ToInterval(s_);
			var u_ = HospitalLocation?.Period;
			var v_ = FHIRHelpers_4_0_001.ToInterval(u_);
			var x_ = n_.IntervalIncludesInterval<CqlDateTime>(t_, v_, null);
			var z_ = n_.And(r_, x_);

			return z_;
		};
		var c_ = context.Operators;
		var d_ = c_.WhereOrNull<Encounter.LocationComponent>((a_ as IEnumerable<Encounter.LocationComponent>), b_);
		object e_(Encounter.LocationComponent @this)
		{
			var ab_ = @this?.Period;
			var ac_ = FHIRHelpers_4_0_001.ToInterval(ab_);
			var ad_ = context.Operators;
			var ae_ = ad_.Start(ac_);

			return ae_;
		};
		var g_ = c_.ListSortBy<Encounter.LocationComponent>(d_, e_, System.ComponentModel.ListSortDirection.Ascending);
		var i_ = c_.FirstOfList<Encounter.LocationComponent>(g_);

		return i_;
	}


    [CqlDeclaration("FirstICULocationPeriod")]
    public Period FirstICULocationPeriod(Encounter Encounter)
	{
		var a_ = this.FirstInpatientIntensiveCareUnit(Encounter);
		var b_ = a_?.Period;

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
		var f_ = Encounter?.Period;
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