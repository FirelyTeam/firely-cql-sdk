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
		new CqlCode("V97.33", "http://hl7.org/fhir/sid/icd-10", null, null);

    [CqlDeclaration("Sucked into jet engine")]
	public CqlCode Sucked_into_jet_engine() => 
		__Sucked_into_jet_engine.Value;

	private CqlCode Sucked_into_jet_engine__subsequent_encounter_Value() => 
		new CqlCode("V97.33XD", "http://hl7.org/fhir/sid/icd-10", null, null);

    [CqlDeclaration("Sucked into jet engine, subsequent encounter")]
	public CqlCode Sucked_into_jet_engine__subsequent_encounter() => 
		__Sucked_into_jet_engine__subsequent_encounter.Value;

	private CqlCode[] ICD10_Value()
	{
		var a_ = new CqlCode[]
		{
			new CqlCode("V97.33", "http://hl7.org/fhir/sid/icd-10", null, null),
			new CqlCode("V97.33XD", "http://hl7.org/fhir/sid/icd-10", null, null),
		};

		return a_;
	}

    [CqlDeclaration("ICD10")]
	public CqlCode[] ICD10() => 
		__ICD10.Value;

	private CqlInterval<CqlDateTime> Measurement_Period_Value()
	{
		var a_ = context.ResolveParameter("DevDays-2023.0.0", "Measurement Period", null);

		return (CqlInterval<CqlDateTime>)a_;
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

	private IEnumerable<Condition> Jet_engine_conditions_Value()
	{
		var a_ = context.Operators;
		var b_ = context.DataRetriever;
		var c_ = b_.RetrieveByValueSet<Condition>(null, null);
		bool? d_(Condition c)
		{
			var f_ = context.Operators;
			var i_ = c?.Code;
			var j_ = i_?.Coding;
			bool? k_(Coding coding)
			{
				var t_ = context.Operators;
				var u_ = FHIRHelpers_4_0_001.ToCode(coding);
				var v_ = this.Sucked_into_jet_engine();
				var w_ = t_.Equivalent(u_, v_);

				return w_;
			};
			var l_ = f_.WhereOrNull<Coding>((j_ as IEnumerable<Coding>), k_);
			var m_ = f_.ExistsInList<Coding>(l_);
			var o_ = c?.Onset;
			var p_ = FHIRHelpers_4_0_001.ToDateTime((o_ as FhirDateTime));
			var q_ = this.Measurement_Period();
			var r_ = f_.ElementInInterval<CqlDateTime>(p_, q_, null);
			var s_ = f_.And(m_, r_);

			return s_;
		};
		var e_ = a_.WhereOrNull<Condition>(c_, d_);

		return e_;
	}

    [CqlDeclaration("Jet engine conditions")]
	public IEnumerable<Condition> Jet_engine_conditions() => 
		__Jet_engine_conditions.Value;

	private IEnumerable<Condition> Subsequent_encounters_Value()
	{
		var a_ = context.Operators;
		var b_ = context.DataRetriever;
		var c_ = b_.RetrieveByValueSet<Condition>(null, null);
		bool? d_(Condition c)
		{
			var f_ = context.Operators;
			var i_ = c?.Code;
			var j_ = i_?.Coding;
			bool? k_(Coding coding)
			{
				var t_ = context.Operators;
				var u_ = FHIRHelpers_4_0_001.ToCode(coding);
				var v_ = this.Sucked_into_jet_engine__subsequent_encounter();
				var w_ = t_.Equivalent(u_, v_);

				return w_;
			};
			var l_ = f_.WhereOrNull<Coding>((j_ as IEnumerable<Coding>), k_);
			var m_ = f_.ExistsInList<Coding>(l_);
			var o_ = c?.Onset;
			var p_ = FHIRHelpers_4_0_001.ToDateTime((o_ as FhirDateTime));
			var q_ = this.Measurement_Period();
			var r_ = f_.ElementInInterval<CqlDateTime>(p_, q_, null);
			var s_ = f_.And(m_, r_);

			return s_;
		};
		var e_ = a_.WhereOrNull<Condition>(c_, d_);

		return e_;
	}

    [CqlDeclaration("Subsequent encounters")]
	public IEnumerable<Condition> Subsequent_encounters() => 
		__Subsequent_encounters.Value;

	private bool? Initial_population_Value()
	{
		var a_ = context.Operators;
		var b_ = this.Jet_engine_conditions();
		var c_ = a_.ExistsInList<Condition>(b_);

		return c_;
	}

    [CqlDeclaration("Initial population")]
	public bool? Initial_population() => 
		__Initial_population.Value;

	private bool? Numerator_Value()
	{
		var a_ = context.Operators;
		var b_ = this.Subsequent_encounters();
		var c_ = a_.ExistsInList<Condition>(b_);

		return c_;
	}

    [CqlDeclaration("Numerator")]
	public bool? Numerator() => 
		__Numerator.Value;

}