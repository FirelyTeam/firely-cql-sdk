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
[System.CodeDom.Compiler.GeneratedCode(".NET Code Generation", "2.0.3.0")]
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
    internal Lazy<int?> __Injury_due_to_falling_rock_within_measurement_period;

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
        __Injury_due_to_falling_rock_within_measurement_period = new Lazy<int?>(this.Injury_due_to_falling_rock_within_measurement_period_Value);
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

	private int? Injury_due_to_falling_rock_within_measurement_period_Value() => 
		1;

    [CqlDeclaration("Injury due to falling rock within measurement period")]
    [CqlTag("description", "Conditions of type 'Injury due to falling rock' within the measurement period")]
    [CqlTag("fhirquery", "akin to Condition?code:in=http://moh.alpha.alp/ValueSet/DiagnosisInjuryDueToFallingRock&onset-date=sa[Period-start]&onset-date=eb[Period-end]")]
    [CqlTag("datarequirement", "\"code\",\"onset.ofType(DateTime)\",\"subject.ofType(Patient)\"]")]
    [CqlTag("coderequirement", "Condition.code http://moh.alpha.alp/ValueSet/DiagnosisInjuryDueToFallingRock")]
	public int? Injury_due_to_falling_rock_within_measurement_period() => 
		__Injury_due_to_falling_rock_within_measurement_period.Value;

}
