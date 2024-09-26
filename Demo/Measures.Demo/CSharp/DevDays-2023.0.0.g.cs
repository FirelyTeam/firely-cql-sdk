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
		new CqlCode("V97.33", "http://hl7.org/fhir/sid/icd-10", default, default);

    [CqlDeclaration("Sucked into jet engine")]
	public CqlCode Sucked_into_jet_engine() => 
		__Sucked_into_jet_engine.Value;

	private CqlCode Sucked_into_jet_engine__subsequent_encounter_Value() => 
		new CqlCode("V97.33XD", "http://hl7.org/fhir/sid/icd-10", default, default);

    [CqlDeclaration("Sucked into jet engine, subsequent encounter")]
	public CqlCode Sucked_into_jet_engine__subsequent_encounter() => 
		__Sucked_into_jet_engine__subsequent_encounter.Value;

	private CqlCode[] ICD10_Value()
	{
		CqlCode[] a_ = [
			new CqlCode("V97.33", "http://hl7.org/fhir/sid/icd-10", default, default),
			new CqlCode("V97.33XD", "http://hl7.org/fhir/sid/icd-10", default, default),
		];

		return a_;
	}

    [CqlDeclaration("ICD10")]
	public CqlCode[] ICD10() => 
		__ICD10.Value;

	private CqlInterval<CqlDateTime> Measurement_Period_Value()
	{
		object a_ = context.ResolveParameter("DevDays-2023.0.0", "Measurement Period", null);

		return (CqlInterval<CqlDateTime>)a_;
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

	private IEnumerable<Condition> Jet_engine_conditions_Value()
	{
		IEnumerable<Condition> a_ = context.Operators.RetrieveByValueSet<Condition>(default, default);
		bool? b_(Condition c)
		{
			CodeableConcept d_ = c?.Code;
			List<Coding> e_ = d_?.Coding;
			bool? f_(Coding coding)
			{
				CqlCode o_ = FHIRHelpers_4_0_001.ToCode(coding);
				CqlCode p_ = this.Sucked_into_jet_engine();
				bool? q_ = context.Operators.Equivalent(o_, p_);

				return q_;
			};
			IEnumerable<Coding> g_ = context.Operators.Where<Coding>((IEnumerable<Coding>)e_, f_);
			bool? h_ = context.Operators.Exists<Coding>(g_);
			DataType i_ = c?.Onset;
			FhirDateTime j_ = i_ switch { null => null , FhirDateTime a => a/* , Age => ???, Period => ???, Range => ???, FhirString => ??? */, _ => throw new System.Diagnostics.UnreachableException() };
			CqlDateTime k_ = FHIRHelpers_4_0_001.ToDateTime(j_);
			CqlInterval<CqlDateTime> l_ = this.Measurement_Period();
			bool? m_ = context.Operators.In<CqlDateTime>(k_, l_, default);
			bool? n_ = context.Operators.And(h_, m_);

			return n_;
		};
		IEnumerable<Condition> c_ = context.Operators.Where<Condition>(a_, b_);

		return c_;
	}

    [CqlDeclaration("Jet engine conditions")]
	public IEnumerable<Condition> Jet_engine_conditions() => 
		__Jet_engine_conditions.Value;

	private IEnumerable<Condition> Subsequent_encounters_Value()
	{
		IEnumerable<Condition> a_ = context.Operators.RetrieveByValueSet<Condition>(default, default);
		bool? b_(Condition c)
		{
			CodeableConcept d_ = c?.Code;
			List<Coding> e_ = d_?.Coding;
			bool? f_(Coding coding)
			{
				CqlCode o_ = FHIRHelpers_4_0_001.ToCode(coding);
				CqlCode p_ = this.Sucked_into_jet_engine__subsequent_encounter();
				bool? q_ = context.Operators.Equivalent(o_, p_);

				return q_;
			};
			IEnumerable<Coding> g_ = context.Operators.Where<Coding>((IEnumerable<Coding>)e_, f_);
			bool? h_ = context.Operators.Exists<Coding>(g_);
			DataType i_ = c?.Onset;
			FhirDateTime j_ = i_ switch { null => null , FhirDateTime a => a/* , Age => ???, Period => ???, Range => ???, FhirString => ??? */, _ => throw new System.Diagnostics.UnreachableException() };
			CqlDateTime k_ = FHIRHelpers_4_0_001.ToDateTime(j_);
			CqlInterval<CqlDateTime> l_ = this.Measurement_Period();
			bool? m_ = context.Operators.In<CqlDateTime>(k_, l_, default);
			bool? n_ = context.Operators.And(h_, m_);

			return n_;
		};
		IEnumerable<Condition> c_ = context.Operators.Where<Condition>(a_, b_);

		return c_;
	}

    [CqlDeclaration("Subsequent encounters")]
	public IEnumerable<Condition> Subsequent_encounters() => 
		__Subsequent_encounters.Value;

	private bool? Initial_population_Value()
	{
		IEnumerable<Condition> a_ = this.Jet_engine_conditions();
		bool? b_ = context.Operators.Exists<Condition>(a_);

		return b_;
	}

    [CqlDeclaration("Initial population")]
	public bool? Initial_population() => 
		__Initial_population.Value;

	private bool? Numerator_Value()
	{
		IEnumerable<Condition> a_ = this.Subsequent_encounters();
		bool? b_ = context.Operators.Exists<Condition>(a_);

		return b_;
	}

    [CqlDeclaration("Numerator")]
	public bool? Numerator() => 
		__Numerator.Value;

}
