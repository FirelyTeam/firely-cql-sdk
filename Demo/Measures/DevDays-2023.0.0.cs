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
[CqlLibrary("DevDays", "2023.0.0")]
public class DevDays_2023_0_0
{


    internal CqlContext context;

    #region Cached values

    internal Lazy<CqlCode> __Sucked_into_jet_engine;
    internal Lazy<CqlCode> __Sucked_into_jet_engine__subsequent_encounter;
    internal Lazy<CqlCode[]> __ICD10;
    internal Lazy<CqlInterval<CqlDateTime>> __Measurement_Period;
    internal Lazy<Patient> __Patient;
    internal Lazy<IEnumerable<Condition>> __Jet_engine_conditions;
    internal Lazy<IEnumerable<Condition>> __Subsequent_encounters;
    internal Lazy<bool?> __Initial_population;
    internal Lazy<bool?> __Numerator;

    #endregion
    public DevDays_2023_0_0(CqlContext context)
    {
        this.context = context ?? throw new ArgumentNullException("context");

        FHIRHelpers_4_0_001 = new FHIRHelpers_4_0_001(context);

        __Sucked_into_jet_engine = new Lazy<CqlCode>(this.Sucked_into_jet_engine_Value);
        __Sucked_into_jet_engine__subsequent_encounter = new Lazy<CqlCode>(this.Sucked_into_jet_engine__subsequent_encounter_Value);
        __ICD10 = new Lazy<CqlCode[]>(this.ICD10_Value);
        __Measurement_Period = new Lazy<CqlInterval<CqlDateTime>>(this.Measurement_Period_Value);
        __Patient = new Lazy<Patient>(this.Patient_Value);
        __Jet_engine_conditions = new Lazy<IEnumerable<Condition>>(this.Jet_engine_conditions_Value);
        __Subsequent_encounters = new Lazy<IEnumerable<Condition>>(this.Subsequent_encounters_Value);
        __Initial_population = new Lazy<bool?>(this.Initial_population_Value);
        __Numerator = new Lazy<bool?>(this.Numerator_Value);
    }
    #region Dependencies

    public FHIRHelpers_4_0_001 FHIRHelpers_4_0_001 { get; }

    #endregion

    private CqlCode Sucked_into_jet_engine_Value() =>
		new CqlCode("V97.33", 
			"http://hl7.org/fhir/sid/icd-10", 
			null, 
			null);

    [CqlDeclaration("Sucked into jet engine")]
    public CqlCode Sucked_into_jet_engine() => __Sucked_into_jet_engine.Value;

    private CqlCode Sucked_into_jet_engine__subsequent_encounter_Value() =>
		new CqlCode("V97.33XD", 
			"http://hl7.org/fhir/sid/icd-10", 
			null, 
			null);

    [CqlDeclaration("Sucked into jet engine, subsequent encounter")]
    public CqlCode Sucked_into_jet_engine__subsequent_encounter() => __Sucked_into_jet_engine__subsequent_encounter.Value;

    private CqlCode[] ICD10_Value()
	{
		var a_ = new CqlCode("V97.33", 
			"http://hl7.org/fhir/sid/icd-10", 
			null, 
			null);
		var b_ = new CqlCode("V97.33XD", 
			"http://hl7.org/fhir/sid/icd-10", 
			null, 
			null);

		return new CqlCode[]
		{
			a_,
			b_,
		};
	}

    [CqlDeclaration("ICD10")]
    public CqlCode[] ICD10() => __ICD10.Value;

    private CqlInterval<CqlDateTime> Measurement_Period_Value() =>
		(CqlInterval<CqlDateTime>)context.ResolveParameter("DevDays-2023.0.0", "Measurement Period", null);

    [CqlDeclaration("Measurement Period")]
    public CqlInterval<CqlDateTime> Measurement_Period() => __Measurement_Period.Value;

    private Patient Patient_Value()
	{
		var a_ = context?.DataRetriever.RetrieveByValueSet<Patient>(null, null);

		return context?.Operators.SingleOrNull<Patient>(a_);
	}

    [CqlDeclaration("Patient")]
    public Patient Patient() => __Patient.Value;

    private IEnumerable<Condition> Jet_engine_conditions_Value()
	{
		var a_ = context?.DataRetriever.RetrieveByValueSet<Condition>(null, null);
		var b_ = (Condition c) =>
		{
			var a_ = (c?.Code?.Coding as IEnumerable<Coding>);
			var b_ = (Coding coding) =>
			{
				var a_ = (FHIRHelpers_4_0_001.ToCode(coding) as object);
				var b_ = (this.Sucked_into_jet_engine() as object);

				return context?.Operators.Equivalent(a_, b_);
			};
			var c_ = context?.Operators.WhereOrNull<Coding>(a_, b_);
			var d_ = context?.Operators.ExistsInList<Coding>(c_);
			var e_ = ((c?.Onset as object) as FhirDateTime);
			var f_ = FHIRHelpers_4_0_001.ToDateTime(e_);
			var g_ = this.Measurement_Period();
			var h_ = context?.Operators.ElementInInterval<CqlDateTime>(f_, g_, null);

			return context?.Operators.And(d_, h_);
		};

		return context?.Operators.WhereOrNull<Condition>(a_, b_);
	}

    [CqlDeclaration("Jet engine conditions")]
    public IEnumerable<Condition> Jet_engine_conditions() => __Jet_engine_conditions.Value;

    private IEnumerable<Condition> Subsequent_encounters_Value()
	{
		var a_ = context?.DataRetriever.RetrieveByValueSet<Condition>(null, null);
		var b_ = (Condition c) =>
		{
			var a_ = (c?.Code?.Coding as IEnumerable<Coding>);
			var b_ = (Coding coding) =>
			{
				var a_ = (FHIRHelpers_4_0_001.ToCode(coding) as object);
				var b_ = (this.Sucked_into_jet_engine__subsequent_encounter() as object);

				return context?.Operators.Equivalent(a_, b_);
			};
			var c_ = context?.Operators.WhereOrNull<Coding>(a_, b_);
			var d_ = context?.Operators.ExistsInList<Coding>(c_);
			var e_ = ((c?.Onset as object) as FhirDateTime);
			var f_ = FHIRHelpers_4_0_001.ToDateTime(e_);
			var g_ = this.Measurement_Period();
			var h_ = context?.Operators.ElementInInterval<CqlDateTime>(f_, g_, null);

			return context?.Operators.And(d_, h_);
		};

		return context?.Operators.WhereOrNull<Condition>(a_, b_);
	}

    [CqlDeclaration("Subsequent encounters")]
    public IEnumerable<Condition> Subsequent_encounters() => __Subsequent_encounters.Value;

    private bool? Initial_population_Value()
	{
		var a_ = this.Jet_engine_conditions();

		return context?.Operators.ExistsInList<Condition>(a_);
	}

    [CqlDeclaration("Initial population")]
    public bool? Initial_population() => __Initial_population.Value;

    private bool? Numerator_Value()
	{
		var a_ = this.Subsequent_encounters();

		return context?.Operators.ExistsInList<Condition>(a_);
	}

    [CqlDeclaration("Numerator")]
    public bool? Numerator() => __Numerator.Value;

}