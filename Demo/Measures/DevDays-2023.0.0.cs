using System;
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
[System.CodeDom.Compiler.GeneratedCode(".NET Code Generation", "1.0.0.0")]
[CqlLibrary("DevDays", "2023.0.0")]
public class DevDays_2023_0_0
{

    public static DevDays_2023_0_0 Instance { get; }  = new();

    [CqlDeclaration("Sucked into jet engine")]
	public CqlCode Sucked_into_jet_engine(CqlContext context) => 
		new CqlCode("V97.33", "http://hl7.org/fhir/sid/icd-10", null, null);

    [CqlDeclaration("Sucked into jet engine, subsequent encounter")]
	public CqlCode Sucked_into_jet_engine__subsequent_encounter(CqlContext context) => 
		new CqlCode("V97.33XD", "http://hl7.org/fhir/sid/icd-10", null, null);

    [CqlDeclaration("ICD10")]
	public CqlCode[] ICD10(CqlContext context)
	{
		var a_ = new CqlCode[]
		{
			new CqlCode("V97.33", "http://hl7.org/fhir/sid/icd-10", null, null),
			new CqlCode("V97.33XD", "http://hl7.org/fhir/sid/icd-10", null, null),
		};

		return a_;
	}

    [CqlDeclaration("Measurement Period")]
	public CqlInterval<CqlDateTime> Measurement_Period(CqlContext context)
	{
		var a_ = context.ResolveParameter("DevDays-2023.0.0", "Measurement Period", null);

		return (CqlInterval<CqlDateTime>)a_;
	}

    [CqlDeclaration("Patient")]
	public Patient Patient(CqlContext context)
	{
		var a_ = context.Operators.RetrieveByValueSet<Patient>(null, null);
		var b_ = context.Operators.SingleOrNull<Patient>(a_);

		return b_;
	}

    [CqlDeclaration("Jet engine conditions")]
	public IEnumerable<Condition> Jet_engine_conditions(CqlContext context)
	{
		var a_ = context.Operators.RetrieveByValueSet<Condition>(null, null);
		bool? b_(Condition c)
		{
			bool? d_(Coding coding)
			{
				var k_ = FHIRHelpers_4_0_001.Instance.ToCode(context, coding);
				var l_ = this.Sucked_into_jet_engine(context);
				var m_ = context.Operators.Equivalent(k_, l_);

				return m_;
			};
			var e_ = context.Operators.WhereOrNull<Coding>((c?.Code?.Coding as IEnumerable<Coding>), d_);
			var f_ = context.Operators.ExistsInList<Coding>(e_);
			var g_ = FHIRHelpers_4_0_001.Instance.ToDateTime(context, (c?.Onset as FhirDateTime));
			var h_ = this.Measurement_Period(context);
			var i_ = context.Operators.ElementInInterval<CqlDateTime>(g_, h_, null);
			var j_ = context.Operators.And(f_, i_);

			return j_;
		};
		var c_ = context.Operators.WhereOrNull<Condition>(a_, b_);

		return c_;
	}

    [CqlDeclaration("Subsequent encounters")]
	public IEnumerable<Condition> Subsequent_encounters(CqlContext context)
	{
		var a_ = context.Operators.RetrieveByValueSet<Condition>(null, null);
		bool? b_(Condition c)
		{
			bool? d_(Coding coding)
			{
				var k_ = FHIRHelpers_4_0_001.Instance.ToCode(context, coding);
				var l_ = this.Sucked_into_jet_engine__subsequent_encounter(context);
				var m_ = context.Operators.Equivalent(k_, l_);

				return m_;
			};
			var e_ = context.Operators.WhereOrNull<Coding>((c?.Code?.Coding as IEnumerable<Coding>), d_);
			var f_ = context.Operators.ExistsInList<Coding>(e_);
			var g_ = FHIRHelpers_4_0_001.Instance.ToDateTime(context, (c?.Onset as FhirDateTime));
			var h_ = this.Measurement_Period(context);
			var i_ = context.Operators.ElementInInterval<CqlDateTime>(g_, h_, null);
			var j_ = context.Operators.And(f_, i_);

			return j_;
		};
		var c_ = context.Operators.WhereOrNull<Condition>(a_, b_);

		return c_;
	}

    [CqlDeclaration("Initial population")]
	public bool? Initial_population(CqlContext context)
	{
		var a_ = this.Jet_engine_conditions(context);
		var b_ = context.Operators.ExistsInList<Condition>(a_);

		return b_;
	}

    [CqlDeclaration("Numerator")]
	public bool? Numerator(CqlContext context)
	{
		var a_ = this.Subsequent_encounters(context);
		var b_ = context.Operators.ExistsInList<Condition>(a_);

		return b_;
	}

}