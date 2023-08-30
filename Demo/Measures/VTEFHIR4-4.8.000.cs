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
	public CqlValueSet Intensive_Care_Unit() => 
		__Intensive_Care_Unit.Value;

	private CqlInterval<CqlDateTime> Measurement_Period_Value()
	{
		var a_ = context.Operators;
		var d_ = a_.ConvertIntegerToDecimal(default);
		var e_ = a_.DateTime((int?)2019, (int?)1, (int?)1, (int?)0, (int?)0, (int?)0, (int?)0, d_);
		var h_ = a_.ConvertIntegerToDecimal(default);
		var i_ = a_.DateTime((int?)2020, (int?)1, (int?)1, (int?)0, (int?)0, (int?)0, (int?)0, h_);
		var j_ = a_.Interval(e_, i_, true, false);
		var k_ = context.ResolveParameter("VTEFHIR4-4.8.000", "Measurement Period", j_);

		return (CqlInterval<CqlDateTime>)k_;
	}

    [CqlDeclaration("Measurement Period")]
	public CqlInterval<CqlDateTime> Measurement_Period() => 
		__Measurement_Period.Value;

	private Patient Patient_Value()
	{
		var a_ = context.Operators;
		var b_ = context.DataRetriever;
		var c_ = b_.RetrieveByValueSet<Patient>(null, null);
		var d_ = a_.SingleOrNull<Patient>(c_);

		return d_;
	}

    [CqlDeclaration("Patient")]
	public Patient Patient() => 
		__Patient.Value;

    [CqlDeclaration("FirstInpatientIntensiveCareUnit")]
	public Encounter.LocationComponent FirstInpatientIntensiveCareUnit(Encounter Encounter)
	{
		var a_ = context.Operators;
		var d_ = Encounter?.Location;
		bool? e_(Encounter.LocationComponent HospitalLocation)
		{
			var j_ = context.Operators;
			var m_ = HospitalLocation?.Location;
			var n_ = MATGlobalCommonFunctionsFHIR4_6_1_000.GetLocation(m_);
			var o_ = n_?.Type;
			CqlConcept p_(CodeableConcept X)
			{
				var aa_ = FHIRHelpers_4_0_001.ToConcept(X);

				return aa_;
			};
			var q_ = j_.SelectOrNull<CodeableConcept, CqlConcept>((o_ as IEnumerable<CodeableConcept>), p_);
			var r_ = this.Intensive_Care_Unit();
			var s_ = j_.ConceptsInValueSet(q_, r_);
			var u_ = Encounter?.Period;
			var v_ = FHIRHelpers_4_0_001.ToInterval(u_);
			var w_ = HospitalLocation?.Period;
			var x_ = FHIRHelpers_4_0_001.ToInterval(w_);
			var y_ = j_.IntervalIncludesInterval<CqlDateTime>(v_, x_, null);
			var z_ = j_.And(s_, y_);

			return z_;
		};
		var f_ = a_.WhereOrNull<Encounter.LocationComponent>((d_ as IEnumerable<Encounter.LocationComponent>), e_);
		object g_(Encounter.LocationComponent @this)
		{
			var ab_ = context.Operators;
			var ac_ = @this?.Period;
			var ad_ = FHIRHelpers_4_0_001.ToInterval(ac_);
			var ae_ = ab_.Start(ad_);

			return ae_;
		};
		var h_ = a_.ListSortBy<Encounter.LocationComponent>(f_, g_, System.ComponentModel.ListSortDirection.Ascending);
		var i_ = a_.FirstOfList<Encounter.LocationComponent>(h_);

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
		var a_ = context.Operators;
		var b_ = this.FirstICULocationPeriod(Encounter);
		var c_ = FHIRHelpers_4_0_001.ToInterval(b_);
		var d_ = a_.Start(c_);

		return d_;
	}

    [CqlDeclaration("CalendarDayOfOrDayAfter")]
	public CqlInterval<CqlDate> CalendarDayOfOrDayAfter(CqlDateTime StartValue)
	{
		var a_ = context.Operators;
		var c_ = a_.DateFrom(StartValue);
		var f_ = a_.DateFrom(StartValue);
		var h_ = a_.Quantity(1m, "day");
		var i_ = a_.Add(f_, h_);
		var j_ = a_.Interval(c_, i_, true, true);

		return j_;
	}

    [CqlDeclaration("FromDayOfStartOfHospitalizationToDayAfterAdmission")]
	public CqlInterval<CqlDate> FromDayOfStartOfHospitalizationToDayAfterAdmission(Encounter Encounter)
	{
		var a_ = context.Operators;
		var d_ = MATGlobalCommonFunctionsFHIR4_6_1_000.HospitalizationWithObservation(Encounter);
		var e_ = a_.Start(d_);
		var f_ = a_.DateFrom(e_);
		var j_ = Encounter?.Period;
		var k_ = FHIRHelpers_4_0_001.ToInterval(j_);
		var l_ = a_.Start(k_);
		var m_ = a_.DateFrom(l_);
		var o_ = a_.Quantity(1m, "day");
		var p_ = a_.Add(m_, o_);
		var q_ = a_.Interval(f_, p_, true, true);

		return q_;
	}

    [CqlDeclaration("FromDayOfStartOfHospitalizationToDayAfterFirstICU")]
	public CqlInterval<CqlDate> FromDayOfStartOfHospitalizationToDayAfterFirstICU(Encounter Encounter)
	{
		var a_ = context.Operators;
		var d_ = MATGlobalCommonFunctionsFHIR4_6_1_000.HospitalizationWithObservation(Encounter);
		var e_ = a_.Start(d_);
		var f_ = a_.DateFrom(e_);
		var i_ = this.StartOfFirstICU(Encounter);
		var j_ = a_.DateFrom(i_);
		var l_ = a_.Quantity(1m, "day");
		var m_ = a_.Add(j_, l_);
		var n_ = a_.Interval(f_, m_, true, true);

		return n_;
	}

}