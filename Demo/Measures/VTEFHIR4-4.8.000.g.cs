using System;
using Tuples;
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
		CqlDateTime a_ = context.Operators.DateTime(2019, 1, 1, 0, 0, 0, 0, default);
		CqlDateTime b_ = context.Operators.DateTime(2020, 1, 1, 0, 0, 0, 0, default);
		CqlInterval<CqlDateTime> c_ = context.Operators.Interval(a_, b_, true, false);
		object d_ = context.ResolveParameter("VTEFHIR4-4.8.000", "Measurement Period", c_);

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

    [CqlDeclaration("FirstInpatientIntensiveCareUnit")]
	public Encounter.LocationComponent FirstInpatientIntensiveCareUnit(Encounter Encounter)
	{
		bool? a_(Encounter.LocationComponent HospitalLocation)
		{
			Location f_ = MATGlobalCommonFunctionsFHIR4_6_1_000.GetLocation(HospitalLocation?.Location);
			CqlConcept g_(CodeableConcept X)
			{
				CqlConcept o_ = FHIRHelpers_4_0_001.ToConcept(X);

				return o_;
			};
			IEnumerable<CqlConcept> h_ = context.Operators.Select<CodeableConcept, CqlConcept>((f_?.Type as IEnumerable<CodeableConcept>), g_);
			CqlValueSet i_ = this.Intensive_Care_Unit();
			bool? j_ = context.Operators.ConceptsInValueSet(h_, i_);
			CqlInterval<CqlDateTime> k_ = FHIRHelpers_4_0_001.ToInterval(Encounter?.Period);
			CqlInterval<CqlDateTime> l_ = FHIRHelpers_4_0_001.ToInterval(HospitalLocation?.Period);
			bool? m_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(k_, l_, null);
			bool? n_ = context.Operators.And(j_, m_);

			return n_;
		};
		IEnumerable<Encounter.LocationComponent> b_ = context.Operators.Where<Encounter.LocationComponent>((Encounter?.Location as IEnumerable<Encounter.LocationComponent>), a_);
		object c_(Encounter.LocationComponent @this)
		{
			CqlInterval<CqlDateTime> p_ = FHIRHelpers_4_0_001.ToInterval(@this?.Period);
			CqlDateTime q_ = context.Operators.Start(p_);

			return q_;
		};
		IEnumerable<Encounter.LocationComponent> d_ = context.Operators.SortBy<Encounter.LocationComponent>(b_, c_, System.ComponentModel.ListSortDirection.Ascending);
		Encounter.LocationComponent e_ = context.Operators.First<Encounter.LocationComponent>(d_);

		return e_;
	}

    [CqlDeclaration("FirstICULocationPeriod")]
	public Period FirstICULocationPeriod(Encounter Encounter)
	{
		Encounter.LocationComponent a_ = this.FirstInpatientIntensiveCareUnit(Encounter);

		return a_?.Period;
	}

    [CqlDeclaration("StartOfFirstICU")]
	public CqlDateTime StartOfFirstICU(Encounter Encounter)
	{
		Period a_ = this.FirstICULocationPeriod(Encounter);
		CqlInterval<CqlDateTime> b_ = FHIRHelpers_4_0_001.ToInterval(a_);
		CqlDateTime c_ = context.Operators.Start(b_);

		return c_;
	}

    [CqlDeclaration("CalendarDayOfOrDayAfter")]
	public CqlInterval<CqlDate> CalendarDayOfOrDayAfter(CqlDateTime StartValue)
	{
		CqlDate a_ = context.Operators.DateFrom(StartValue);
		CqlQuantity c_ = context.Operators.Quantity(1m, "day");
		CqlDate d_ = context.Operators.Add(a_, c_);
		CqlInterval<CqlDate> e_ = context.Operators.Interval(a_, d_, true, true);

		return e_;
	}

    [CqlDeclaration("FromDayOfStartOfHospitalizationToDayAfterAdmission")]
	public CqlInterval<CqlDate> FromDayOfStartOfHospitalizationToDayAfterAdmission(Encounter Encounter)
	{
		CqlInterval<CqlDateTime> a_ = MATGlobalCommonFunctionsFHIR4_6_1_000.HospitalizationWithObservation(Encounter);
		CqlDateTime b_ = context.Operators.Start(a_);
		CqlDate c_ = context.Operators.DateFrom(b_);
		CqlInterval<CqlDateTime> d_ = FHIRHelpers_4_0_001.ToInterval(Encounter?.Period);
		CqlDateTime e_ = context.Operators.Start(d_);
		CqlDate f_ = context.Operators.DateFrom(e_);
		CqlQuantity g_ = context.Operators.Quantity(1m, "day");
		CqlDate h_ = context.Operators.Add(f_, g_);
		CqlInterval<CqlDate> i_ = context.Operators.Interval(c_, h_, true, true);

		return i_;
	}

    [CqlDeclaration("FromDayOfStartOfHospitalizationToDayAfterFirstICU")]
	public CqlInterval<CqlDate> FromDayOfStartOfHospitalizationToDayAfterFirstICU(Encounter Encounter)
	{
		CqlInterval<CqlDateTime> a_ = MATGlobalCommonFunctionsFHIR4_6_1_000.HospitalizationWithObservation(Encounter);
		CqlDateTime b_ = context.Operators.Start(a_);
		CqlDate c_ = context.Operators.DateFrom(b_);
		CqlDateTime d_ = this.StartOfFirstICU(Encounter);
		CqlDate e_ = context.Operators.DateFrom(d_);
		CqlQuantity f_ = context.Operators.Quantity(1m, "day");
		CqlDate g_ = context.Operators.Add(e_, f_);
		CqlInterval<CqlDate> h_ = context.Operators.Interval(c_, g_, true, true);

		return h_;
	}

}
