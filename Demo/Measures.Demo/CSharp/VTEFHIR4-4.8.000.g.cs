using System;
using System.Linq;
using System.Collections.Generic;
using Hl7.Cql.Runtime;
using Hl7.Cql.Primitives;
using Hl7.Cql.Abstractions;
using Hl7.Cql.ValueSets;
using Hl7.Cql.Iso8601;
using System.Reflection;
using Hl7.Cql.Operators;
using Hl7.Fhir.Model;
using Range = Hl7.Fhir.Model.Range;
using Task = Hl7.Fhir.Model.Task;
[System.CodeDom.Compiler.GeneratedCode(".NET Code Generation", "2.0.4.0")]
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
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1029.206", default);

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
		IEnumerable<Patient> a_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/StructureDefinition/Patient"));
		Patient b_ = context.Operators.SingletonFrom<Patient>(a_);

		return b_;
	}

    [CqlDeclaration("Patient")]
	public Patient Patient() => 
		__Patient.Value;

    [CqlDeclaration("FirstInpatientIntensiveCareUnit")]
	public Encounter.LocationComponent FirstInpatientIntensiveCareUnit(Encounter Encounter)
	{
		List<Encounter.LocationComponent> a_ = Encounter?.Location;
		bool? b_(Encounter.LocationComponent HospitalLocation)
		{
			ResourceReference g_ = HospitalLocation?.Location;
			Location h_ = MATGlobalCommonFunctionsFHIR4_6_1_000.GetLocation(g_);
			List<CodeableConcept> i_ = h_?.Type;
			CqlConcept j_(CodeableConcept X)
			{
				CqlConcept t_ = FHIRHelpers_4_0_001.ToConcept(X);

				return t_;
			};
			IEnumerable<CqlConcept> k_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)i_, j_);
			CqlValueSet l_ = this.Intensive_Care_Unit();
			bool? m_ = context.Operators.ConceptsInValueSet(k_, l_);
			Period n_ = Encounter?.Period;
			CqlInterval<CqlDateTime> o_ = FHIRHelpers_4_0_001.ToInterval(n_);
			Period p_ = HospitalLocation?.Period;
			CqlInterval<CqlDateTime> q_ = FHIRHelpers_4_0_001.ToInterval(p_);
			bool? r_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(o_, q_, default);
			bool? s_ = context.Operators.And(m_, r_);

			return s_;
		};
		IEnumerable<Encounter.LocationComponent> c_ = context.Operators.Where<Encounter.LocationComponent>((IEnumerable<Encounter.LocationComponent>)a_, b_);
		object d_(Encounter.LocationComponent @this)
		{
			Period u_ = @this?.Period;
			CqlInterval<CqlDateTime> v_ = FHIRHelpers_4_0_001.ToInterval(u_);
			CqlDateTime w_ = context.Operators.Start(v_);

			return w_;
		};
		IEnumerable<Encounter.LocationComponent> e_ = context.Operators.SortBy<Encounter.LocationComponent>(c_, d_, System.ComponentModel.ListSortDirection.Ascending);
		Encounter.LocationComponent f_ = context.Operators.First<Encounter.LocationComponent>(e_);

		return f_;
	}

    [CqlDeclaration("FirstICULocationPeriod")]
	public Period FirstICULocationPeriod(Encounter Encounter)
	{
		Encounter.LocationComponent a_ = this.FirstInpatientIntensiveCareUnit(Encounter);
		Period b_ = a_?.Period;

		return b_;
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
		Period d_ = Encounter?.Period;
		CqlInterval<CqlDateTime> e_ = FHIRHelpers_4_0_001.ToInterval(d_);
		CqlDateTime f_ = context.Operators.Start(e_);
		CqlDate g_ = context.Operators.DateFrom(f_);
		CqlQuantity h_ = context.Operators.Quantity(1m, "day");
		CqlDate i_ = context.Operators.Add(g_, h_);
		CqlInterval<CqlDate> j_ = context.Operators.Interval(c_, i_, true, true);

		return j_;
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
