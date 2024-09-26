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
[System.CodeDom.Compiler.GeneratedCode(".NET Code Generation", "2.0.4.0")]
[CqlLibrary("RR23", "1.0.0")]
public class RR23_1_0_0
{


    internal CqlContext context;

    #region Cached values

    internal Lazy<CqlValueSet> __Injury_due_to_falling_rock;
    internal Lazy<CqlValueSet> __Roadrunners_Syndrome_Indicators;
    internal Lazy<CqlCode> __Tiny_Umbrella;
    internal Lazy<CqlCode> __entered_in_error;
    internal Lazy<CqlCode[]> __ACME_Product_Catalog;
    internal Lazy<CqlCode[]> __ConditionVerificationStatusCodes;
    internal Lazy<CqlInterval<CqlDateTime>> __Measurement_Period;
    internal Lazy<Patient> __Patient;
    internal Lazy<IEnumerable<Condition>> __Injury_due_to_falling_rock_within_measurement_period;
    internal Lazy<bool?> __Initial_Population;
    internal Lazy<bool?> __Denominator;
    internal Lazy<Condition> __Last_injury_due_to_falling_rock;
    internal Lazy<CqlDateTime> __Date_of_last_injury_due_to_falling_rock;
    internal Lazy<IEnumerable<SupplyDelivery>> __Tiny_Umbrella_Supply_within_7_days_after_most_recent_injury_due_to_falling_rock;
    internal Lazy<bool?> __Numerator;

    #endregion
    public RR23_1_0_0(CqlContext context)
    {
        this.context = context ?? throw new ArgumentNullException("context");

        FHIRHelpers_4_0_1 = new FHIRHelpers_4_0_1(context);

        __Injury_due_to_falling_rock = new Lazy<CqlValueSet>(this.Injury_due_to_falling_rock_Value);
        __Roadrunners_Syndrome_Indicators = new Lazy<CqlValueSet>(this.Roadrunners_Syndrome_Indicators_Value);
        __Tiny_Umbrella = new Lazy<CqlCode>(this.Tiny_Umbrella_Value);
        __entered_in_error = new Lazy<CqlCode>(this.entered_in_error_Value);
        __ACME_Product_Catalog = new Lazy<CqlCode[]>(this.ACME_Product_Catalog_Value);
        __ConditionVerificationStatusCodes = new Lazy<CqlCode[]>(this.ConditionVerificationStatusCodes_Value);
        __Measurement_Period = new Lazy<CqlInterval<CqlDateTime>>(this.Measurement_Period_Value);
        __Patient = new Lazy<Patient>(this.Patient_Value);
        __Injury_due_to_falling_rock_within_measurement_period = new Lazy<IEnumerable<Condition>>(this.Injury_due_to_falling_rock_within_measurement_period_Value);
        __Initial_Population = new Lazy<bool?>(this.Initial_Population_Value);
        __Denominator = new Lazy<bool?>(this.Denominator_Value);
        __Last_injury_due_to_falling_rock = new Lazy<Condition>(this.Last_injury_due_to_falling_rock_Value);
        __Date_of_last_injury_due_to_falling_rock = new Lazy<CqlDateTime>(this.Date_of_last_injury_due_to_falling_rock_Value);
        __Tiny_Umbrella_Supply_within_7_days_after_most_recent_injury_due_to_falling_rock = new Lazy<IEnumerable<SupplyDelivery>>(this.Tiny_Umbrella_Supply_within_7_days_after_most_recent_injury_due_to_falling_rock_Value);
        __Numerator = new Lazy<bool?>(this.Numerator_Value);
    }
    #region Dependencies

    public FHIRHelpers_4_0_1 FHIRHelpers_4_0_1 { get; }

    #endregion

	private CqlValueSet Injury_due_to_falling_rock_Value() => 
		new CqlValueSet("http://moh.alpha.alp/ValueSet/DiagnosisInjuryDueToFallingRock", default);

    [CqlDeclaration("Injury due to falling rock")]
    [CqlValueSet("http://moh.alpha.alp/ValueSet/DiagnosisInjuryDueToFallingRock")]
	public CqlValueSet Injury_due_to_falling_rock() => 
		__Injury_due_to_falling_rock.Value;

	private CqlValueSet Roadrunners_Syndrome_Indicators_Value() => 
		new CqlValueSet("http://moh.alpha.alp/ValueSet/DiagnosisRoadrunnerSyndrome", default);

    [CqlDeclaration("Roadrunners Syndrome Indicators")]
    [CqlValueSet("http://moh.alpha.alp/ValueSet/DiagnosisRoadrunnerSyndrome")]
	public CqlValueSet Roadrunners_Syndrome_Indicators() => 
		__Roadrunners_Syndrome_Indicators.Value;

	private CqlCode Tiny_Umbrella_Value() => 
		new CqlCode("U707", "http://acme.org/product-catalog", default, default);

    [CqlDeclaration("Tiny Umbrella")]
	public CqlCode Tiny_Umbrella() => 
		__Tiny_Umbrella.Value;

	private CqlCode entered_in_error_Value() => 
		new CqlCode("entered-in-error", "http://terminology.hl7.org/CodeSystem/condition-ver-status", default, default);

    [CqlDeclaration("entered-in-error")]
	public CqlCode entered_in_error() => 
		__entered_in_error.Value;

	private CqlCode[] ACME_Product_Catalog_Value()
	{
		CqlCode[] a_ = [
			new CqlCode("U707", "http://acme.org/product-catalog", default, default),
		];

		return a_;
	}

    [CqlDeclaration("ACME Product Catalog")]
	public CqlCode[] ACME_Product_Catalog() => 
		__ACME_Product_Catalog.Value;

	private CqlCode[] ConditionVerificationStatusCodes_Value()
	{
		CqlCode[] a_ = [
			new CqlCode("entered-in-error", "http://terminology.hl7.org/CodeSystem/condition-ver-status", default, default),
		];

		return a_;
	}

    [CqlDeclaration("ConditionVerificationStatusCodes")]
	public CqlCode[] ConditionVerificationStatusCodes() => 
		__ConditionVerificationStatusCodes.Value;

	private CqlInterval<CqlDateTime> Measurement_Period_Value()
	{
		CqlDateTime a_ = context.Operators.DateTime(2023, 1, 1, default, default, default, default, default);
		CqlDateTime b_ = context.Operators.DateTime(2023, 12, 31, default, default, default, default, default);
		CqlInterval<CqlDateTime> c_ = context.Operators.Interval(a_, b_, true, true);
		object d_ = context.ResolveParameter("RR23-1.0.0", "Measurement Period", c_);

		return (CqlInterval<CqlDateTime>)d_;
	}

    [CqlDeclaration("Measurement Period")]
	public CqlInterval<CqlDateTime> Measurement_Period() => 
		__Measurement_Period.Value;

	private Patient Patient_Value()
	{
		IEnumerable<Patient> a_ = context.Operators.RetrieveByValueSet<Patient>(default, default);
		Patient b_ = context.Operators.SingletonFrom<Patient>(a_);

		return b_;
	}

    [CqlDeclaration("Patient")]
	public Patient Patient() => 
		__Patient.Value;

	private IEnumerable<Condition> Injury_due_to_falling_rock_within_measurement_period_Value()
	{
		CqlValueSet a_ = this.Injury_due_to_falling_rock();
		IEnumerable<Condition> b_ = context.Operators.RetrieveByValueSet<Condition>(a_, default);
		bool? c_(Condition C)
		{
			DataType e_ = C?.Onset;
			object f_ = context.Operators.LateBoundProperty<object>(e_, "value");
			CqlDateTime g_ = f_ switch { null => null , CqlDateTime a => a/* , FhirDecimal => ??? */, _ => throw new System.Diagnostics.UnreachableException() };
			CqlInterval<CqlDateTime> h_ = this.Measurement_Period();
			bool? i_ = context.Operators.In<CqlDateTime>(g_, h_, default);

			return i_;
		};
		IEnumerable<Condition> d_ = context.Operators.Where<Condition>(b_, c_);

		return d_;
	}

    [CqlDeclaration("Injury due to falling rock within measurement period")]
    [CqlTag("description", "Conditions of type 'Injury due to falling rock' within the measurement period")]
    [CqlTag("fhirquery", "akin to Condition?code:in=http://moh.alpha.alp/ValueSet/DiagnosisInjuryDueToFallingRock&onset-date=sa[Period-start]&onset-date=eb[Period-end]")]
    [CqlTag("datarequirement", "\"code\",\"onset.ofType(DateTime)\",\"subject.ofType(Patient)\"]")]
    [CqlTag("coderequirement", "Condition.code http://moh.alpha.alp/ValueSet/DiagnosisInjuryDueToFallingRock")]
	public IEnumerable<Condition> Injury_due_to_falling_rock_within_measurement_period() => 
		__Injury_due_to_falling_rock_within_measurement_period.Value;

	private bool? Initial_Population_Value()
	{
		Patient a_ = this.Patient();
		Date b_ = a_?.BirthDateElement;
		string c_ = b_?.Value;
		CqlDateTime d_ = context.Operators.ConvertStringToDateTime(c_);
		CqlInterval<CqlDateTime> e_ = this.Measurement_Period();
		CqlDateTime f_ = context.Operators.Start(e_);
		int? g_ = context.Operators.CalculateAgeAt(d_, f_, "year");
		bool? h_ = context.Operators.GreaterOrEqual(g_, 16);
		IEnumerable<Condition> i_ = this.Injury_due_to_falling_rock_within_measurement_period();
		bool? j_ = context.Operators.Exists<Condition>(i_);
		bool? k_ = context.Operators.And(h_, j_);

		return k_;
	}

    [CqlDeclaration("Initial Population")]
    [CqlTag("description", "Is Patient in Initial Population ? Patients aged 16 and older who have sustained injuries due to falling rock.")]
    [CqlTag("parameter", "out")]
	public bool? Initial_Population() => 
		__Initial_Population.Value;

	private bool? Denominator_Value()
	{
		bool? a_ = this.Initial_Population();

		return a_;
	}

    [CqlDeclaration("Denominator")]
    [CqlTag("description", "Is Patient in Denominator ? Denominator equals the initial population.")]
    [CqlTag("parameter", "out")]
	public bool? Denominator() => 
		__Denominator.Value;

	private Condition Last_injury_due_to_falling_rock_Value()
	{
		IEnumerable<Condition> a_ = this.Injury_due_to_falling_rock_within_measurement_period();
		object b_(Condition @this)
		{
			DataType e_ = @this?.Onset;
			object f_ = context.Operators.LateBoundProperty<object>(e_, "value");
			CqlDateTime g_ = f_ switch { null => null , CqlDateTime a => a/* , FhirDecimal => ??? */, _ => throw new System.Diagnostics.UnreachableException() };

			return g_;
		};
		IEnumerable<Condition> c_ = context.Operators.SortBy<Condition>(a_, b_, System.ComponentModel.ListSortDirection.Ascending);
		Condition d_ = context.Operators.Last<Condition>(c_);

		return d_;
	}

    [CqlDeclaration("Last injury due to falling rock")]
	public Condition Last_injury_due_to_falling_rock() => 
		__Last_injury_due_to_falling_rock.Value;

	private CqlDateTime Date_of_last_injury_due_to_falling_rock_Value()
	{
		Condition a_ = this.Last_injury_due_to_falling_rock();
		DataType b_ = a_?.Onset;
		object c_ = context.Operators.LateBoundProperty<object>(b_, "value");
		CqlDateTime d_ = c_ switch { null => null , CqlDateTime a => a/* , FhirDecimal => ??? */, _ => throw new System.Diagnostics.UnreachableException() };

		return d_;
	}

    [CqlDeclaration("Date of last injury due to falling rock")]
	public CqlDateTime Date_of_last_injury_due_to_falling_rock() => 
		__Date_of_last_injury_due_to_falling_rock.Value;

	private IEnumerable<SupplyDelivery> Tiny_Umbrella_Supply_within_7_days_after_most_recent_injury_due_to_falling_rock_Value()
	{
		IEnumerable<SupplyDelivery> a_ = context.Operators.RetrieveByValueSet<SupplyDelivery>(default, default);
		bool? b_(SupplyDelivery SD)
		{
			SupplyDelivery.SuppliedItemComponent d_ = SD?.SuppliedItem;
			DataType e_ = d_?.Item;
			CodeableConcept f_ = e_ switch { null => null , CodeableConcept a => a/* , ResourceReference => ??? */, _ => throw new System.Diagnostics.UnreachableException() };
			CqlConcept g_ = FHIRHelpers_4_0_1.ToConcept(f_);
			CqlCode h_ = this.Tiny_Umbrella();
			CqlConcept i_ = context.Operators.ConvertCodeToConcept(h_);
			bool? j_ = context.Operators.Equivalent(g_, i_);
			CqlDateTime k_ = this.Date_of_last_injury_due_to_falling_rock();
			DataType l_ = SD?.Occurrence;
			CqlDateTime m_ = context.Operators.LateBoundProperty<CqlDateTime>(l_, "value");
			CqlQuantity n_ = context.Operators.Quantity(7m, "days");
			CqlDateTime o_ = context.Operators.Subtract(m_ as CqlDateTime, n_);
			CqlDateTime q_ = context.Operators.LateBoundProperty<CqlDateTime>(l_, "value");
			CqlInterval<CqlDateTime> r_ = context.Operators.Interval(o_, q_ as CqlDateTime, true, false);
			bool? s_ = context.Operators.In<CqlDateTime>(k_, r_, default);
			CqlDateTime u_ = context.Operators.LateBoundProperty<CqlDateTime>(l_, "value");
			bool? v_ = context.Operators.Not((bool?)((u_ as CqlDateTime) is null));
			bool? w_ = context.Operators.And(s_, v_);
			bool? x_ = context.Operators.And(j_, w_);

			return x_;
		};
		IEnumerable<SupplyDelivery> c_ = context.Operators.Where<SupplyDelivery>(a_, b_);

		return c_;
	}

    [CqlDeclaration("Tiny Umbrella Supply within 7 days after most recent injury due to falling rock")]
    [CqlTag("description", "\"recording of the (latest) rock fall condition within the measurement period\"")]
    [CqlTag("fhirquery", "akin to /SupplyDelivery?supplied-item=http://acme.org/product-catalog|U707&ocurrence-datetime=lt[Condition onset date+7 days]")]
    [CqlTag("datarequirement", "\"suppliedItem.item.ofType(CodeableConcept)\",\"occurrenceDateTime\",\"patient\"]")]
    [CqlTag("coderequirement", "SupplyDelivery.item.orfType(CodeableConcept) http://acme.org/product-catalog|U707")]
	public IEnumerable<SupplyDelivery> Tiny_Umbrella_Supply_within_7_days_after_most_recent_injury_due_to_falling_rock() => 
		__Tiny_Umbrella_Supply_within_7_days_after_most_recent_injury_due_to_falling_rock.Value;

	private bool? Numerator_Value()
	{
		IEnumerable<SupplyDelivery> a_ = this.Tiny_Umbrella_Supply_within_7_days_after_most_recent_injury_due_to_falling_rock();
		bool? b_ = context.Operators.Exists<SupplyDelivery>(a_);

		return b_;
	}

    [CqlDeclaration("Numerator")]
    [CqlTag("description", "\"recording of the (latestmost recent) rock fall condition within the measurement period\"")]
    [CqlTag("parameter", "out")]
	public bool? Numerator() => 
		__Numerator.Value;

}
