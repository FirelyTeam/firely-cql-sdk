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
[System.CodeDom.Compiler.GeneratedCode(".NET Code Generation", "0.9.0.0")]
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
        return new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1029.206", 
			null);
    }

    [CqlDeclaration("Intensive Care Unit")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1029.206")]
    public CqlValueSet Intensive_Care_Unit() => __Intensive_Care_Unit.Value;

    private CqlInterval<CqlDateTime> Measurement_Period_Value()
    {
        return ((CqlInterval<CqlDateTime>)context.ResolveParameter("VTEFHIR4-4.8.000", 
			"Measurement Period", 
(context?.Operators.Interval(context?.Operators.DateTime(((int?)2019), 
((int?)1), 
((int?)1), 
((int?)0), 
((int?)0), 
((int?)0), 
((int?)0), 
					context?.Operators.ConvertIntegerToDecimal(default)), 
				context?.Operators.DateTime(((int?)2020), 
((int?)1), 
((int?)1), 
((int?)0), 
((int?)0), 
((int?)0), 
((int?)0), 
					context?.Operators.ConvertIntegerToDecimal(default)), 
				true, 
				false) as object)));
    }

    [CqlDeclaration("Measurement Period")]
    public CqlInterval<CqlDateTime> Measurement_Period() => __Measurement_Period.Value;

    private Patient Patient_Value()
    {
        var a_ = context?.Operators.RetrieveByValueSet<Patient>(null, 
			null);
        return context?.Operators.SingleOrNull<Patient>(a_);
    }
    [CqlDeclaration("Patient")]
    public Patient Patient() => __Patient.Value;

    [CqlDeclaration("FirstInpatientIntensiveCareUnit")]
    public Encounter.LocationComponent FirstInpatientIntensiveCareUnit(Encounter Encounter)
    {
        var a_ = (Encounter?.Location as IEnumerable<Encounter.LocationComponent>);
        Func<Encounter.LocationComponent,bool?> l_ = (HospitalLocation) => 
        {
            var b_ = (MATGlobalCommonFunctionsFHIR4_6_1_000.GetLocation(HospitalLocation?.Location)?.Type as IEnumerable<CodeableConcept>);
            Func<CodeableConcept,CqlConcept> c_ = (X) => 
            {
                return FHIRHelpers_4_0_001.ToConcept(X);
            };
            var d_ = context?.Operators.SelectOrNull<CodeableConcept, CqlConcept>(b_, 
				c_);
            var e_ = this.Intensive_Care_Unit();
            var f_ = context?.Operators.ConceptsInValueSet(d_, 
				e_);
            var g_ = Encounter?.Period;
            var h_ = FHIRHelpers_4_0_001.ToInterval(g_);
            var i_ = HospitalLocation?.Period;
            var j_ = FHIRHelpers_4_0_001.ToInterval(i_);
            var k_ = context?.Operators.IntervalIncludesInterval<CqlDateTime>(h_, 
				j_, 
				null);
            return context?.Operators.And(f_, 
				k_);
        };
        var m_ = context?.Operators.WhereOrNull<Encounter.LocationComponent>(a_, 
			l_);
        Func<Encounter.LocationComponent,object> n_ = (@this) => context?.Operators.Start(FHIRHelpers_4_0_001.ToInterval(@this?.Period));
        var o_ = context?.Operators.ListSortBy<Encounter.LocationComponent>(m_, 
			n_, 
			System.ComponentModel.ListSortDirection.Ascending);
        return context?.Operators.FirstOfList<Encounter.LocationComponent>(o_);
    }

    [CqlDeclaration("FirstICULocationPeriod")]
    public Period FirstICULocationPeriod(Encounter Encounter)
    {
        return this.FirstInpatientIntensiveCareUnit(Encounter)?.Period;
    }

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
        var c_ = context?.Operators.Quantity(1m, 
			"day");
        var d_ = context?.Operators.Add(a_, 
			c_);
        return context?.Operators.Interval(a_, 
			d_, 
			true, 
			true);
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
        var h_ = context?.Operators.Quantity(1m, 
			"day");
        var i_ = context?.Operators.Add(g_, 
			h_);
        return context?.Operators.Interval(c_, 
			i_, 
			true, 
			true);
    }

    [CqlDeclaration("FromDayOfStartOfHospitalizationToDayAfterFirstICU")]
    public CqlInterval<CqlDate> FromDayOfStartOfHospitalizationToDayAfterFirstICU(Encounter Encounter)
    {
        var a_ = MATGlobalCommonFunctionsFHIR4_6_1_000.HospitalizationWithObservation(Encounter);
        var b_ = context?.Operators.Start(a_);
        var c_ = context?.Operators.DateFrom(b_);
        var d_ = this.StartOfFirstICU(Encounter);
        var e_ = context?.Operators.DateFrom(d_);
        var f_ = context?.Operators.Quantity(1m, 
			"day");
        var g_ = context?.Operators.Add(e_, 
			f_);
        return context?.Operators.Interval(c_, 
			g_, 
			true, 
			true);
    }

}