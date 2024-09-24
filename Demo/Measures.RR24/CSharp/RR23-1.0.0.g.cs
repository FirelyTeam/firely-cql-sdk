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
    internal Lazy<object> __Measurement_Period;
    internal Lazy<Patient> __Patient;
    internal Lazy<IEnumerable<Condition>> __Injury_due_to_falling_rock_within_measurement_period;
    internal Lazy<bool?> __Initial_Population;
    internal Lazy<bool?> __Denominator;
    internal Lazy<Condition> __Latest_injury_due_to_falling_rock;
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
        __Measurement_Period = new Lazy<object>(this.Measurement_Period_Value);
        __Patient = new Lazy<Patient>(this.Patient_Value);
        __Injury_due_to_falling_rock_within_measurement_period = new Lazy<IEnumerable<Condition>>(this.Injury_due_to_falling_rock_within_measurement_period_Value);
        __Initial_Population = new Lazy<bool?>(this.Initial_Population_Value);
        __Denominator = new Lazy<bool?>(this.Denominator_Value);
        __Latest_injury_due_to_falling_rock = new Lazy<Condition>(this.Latest_injury_due_to_falling_rock_Value);
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

	private object Measurement_Period_Value()
	{
		CqlDate a_ = context.Operators.Date(2023, 1, 1);
		CqlDate b_ = context.Operators.Date(2023, 12, 31);
		CqlInterval<CqlDate> c_ = context.Operators.Interval(a_, b_, true, true);
		object d_ = context.ResolveParameter("RR23-1.0.0", "Measurement Period", c_);

		return d_;
	}

    [CqlDeclaration("Measurement Period")]
	public object Measurement_Period() => 
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
			object g_ = this.Measurement_Period();
			CqlDate h_ = ((CqlInterval<CqlDate>)g_)?.low;
			CqlDateTime i_ = context.Operators.ConvertDateToDateTime(h_);
			CqlDate k_ = ((CqlInterval<CqlDate>)g_)?.high;
			CqlDateTime l_ = context.Operators.ConvertDateToDateTime(k_);
			bool? n_ = ((CqlInterval<CqlDate>)g_)?.lowClosed;
			bool? p_ = ((CqlInterval<CqlDate>)g_)?.highClosed;
			CqlInterval<CqlDateTime> q_ = context.Operators.Interval(i_, l_, n_, p_);
			bool? r_ = context.Operators.In<CqlDateTime>(f_ as CqlDateTime, q_, default);

			return r_;
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
		CqlDate d_ = context.Operators.ConvertStringToDate(c_);
		object e_ = this.Measurement_Period();
		CqlDate f_ = context.Operators.Start((CqlInterval<CqlDate>)e_);
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

	private Condition Latest_injury_due_to_falling_rock_Value()
	{
		IEnumerable<Condition> a_ = this.Injury_due_to_falling_rock_within_measurement_period();
		object b_(Condition @this)
		{
			DataType e_ = @this?.Onset;
			object f_ = context.Operators.LateBoundProperty<object>(e_, "value");

			return f_ as CqlDateTime;
		};
		IEnumerable<Condition> c_ = context.Operators.SortBy<Condition>(a_, b_, System.ComponentModel.ListSortDirection.Ascending);
		Condition d_ = context.Operators.Last<Condition>(c_);

		return d_;
	}

    [CqlDeclaration("Latest injury due to falling rock")]
	public Condition Latest_injury_due_to_falling_rock() => 
		__Latest_injury_due_to_falling_rock.Value;

	private IEnumerable<SupplyDelivery> Tiny_Umbrella_Supply_within_7_days_after_most_recent_injury_due_to_falling_rock_Value()
	{
		IEnumerable<SupplyDelivery> a_ = context.Operators.RetrieveByValueSet<SupplyDelivery>(default, default);
		bool? b_(SupplyDelivery SD)
		{
			SupplyDelivery.SuppliedItemComponent d_ = SD?.SuppliedItem;
			DataType e_ = d_?.Item;
			CqlConcept f_ = FHIRHelpers_4_0_1.ToConcept(e_ as CodeableConcept);
			CqlCode g_ = this.Tiny_Umbrella();
			CqlConcept h_ = context.Operators.ConvertCodeToConcept(g_);
			bool? i_ = context.Operators.Equivalent(f_, h_);
			Condition j_ = this.Latest_injury_due_to_falling_rock();
			Condition[] k_ = [
				j_,
			];
			bool? l_(Condition C)
			{
				DataType q_ = C?.Onset;
				object r_ = context.Operators.LateBoundProperty<object>(q_, "value");
				DataType s_ = SD?.Occurrence;
				CqlDateTime t_ = context.Operators.LateBoundProperty<CqlDateTime>(s_, "value");
				CqlQuantity u_ = context.Operators.Quantity(7m, "days");
				CqlDateTime v_ = context.Operators.Subtract(t_, u_);
				CqlDateTime x_ = context.Operators.LateBoundProperty<CqlDateTime>(s_, "value");
				CqlInterval<CqlDateTime> y_ = context.Operators.Interval(v_, x_, true, false);
				bool? z_ = context.Operators.In<CqlDateTime>(r_ as CqlDateTime, y_, default);
				CqlDateTime ab_ = context.Operators.LateBoundProperty<CqlDateTime>(s_, "value");
				bool? ac_ = context.Operators.Not((bool?)(ab_ is null));
				bool? ad_ = context.Operators.And(z_, ac_);

				return ad_;
			};
			IEnumerable<Condition> m_ = context.Operators.Where<Condition>((IEnumerable<Condition>)k_, l_);
			Condition n_ = context.Operators.SingletonFrom<Condition>(m_);
			bool? o_ = context.Operators.Not((bool?)(n_ is null));
			bool? p_ = context.Operators.And(i_, o_);

			return p_;
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
