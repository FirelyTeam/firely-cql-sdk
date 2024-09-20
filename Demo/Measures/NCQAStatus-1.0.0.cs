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
[CqlLibrary("NCQAStatus", "1.0.0")]
public class NCQAStatus_1_0_0
{

    public static NCQAStatus_1_0_0 Instance { get; }  = new();

    [CqlDeclaration("Patient")]
	public Patient Patient(CqlContext context)
	{
		var a_ = context.Operators.RetrieveByValueSet<Patient>(null, null);
		var b_ = context.Operators.SingleOrNull<Patient>(a_);

		return b_;
	}

    [CqlDeclaration("Active Allergy")]
	public IEnumerable<AllergyIntolerance> Active_Allergy(CqlContext context, IEnumerable<AllergyIntolerance> Allergy)
	{
		bool? a_(AllergyIntolerance A)
		{
			var c_ = FHIRHelpers_4_0_001.Instance.ToConcept(context, A?.ClinicalStatus);
			var d_ = NCQATerminology_1_0_0.Instance.allergy_active(context);
			var e_ = context.Operators.ConvertCodeToConcept(d_);
			var f_ = context.Operators.Equal(c_, e_);

			return f_;
		};
		var b_ = context.Operators.WhereOrNull<AllergyIntolerance>(Allergy, a_);

		return b_;
	}

    [CqlDeclaration("Active Condition")]
	public IEnumerable<Condition> Active_Condition(CqlContext context, IEnumerable<Condition> Condition)
	{
		bool? a_(Condition C)
		{
			var c_ = FHIRHelpers_4_0_001.Instance.ToConcept(context, C?.ClinicalStatus);
			var d_ = NCQATerminology_1_0_0.Instance.active(context);
			var e_ = context.Operators.ConvertCodeToConcept(d_);
			var f_ = context.Operators.Equal(c_, e_);

			return f_;
		};
		var b_ = context.Operators.WhereOrNull<Condition>(Condition, a_);

		return b_;
	}

    [CqlDeclaration("Finished Encounter")]
	public IEnumerable<Encounter> Finished_Encounter(CqlContext context, IEnumerable<Encounter> Enc)
	{
		bool? a_(Encounter E)
		{
			var c_ = context.Operators.Convert<string>(E?.StatusElement);
			var d_ = context.Operators.Equal(c_, "finished");

			return d_;
		};
		var b_ = context.Operators.WhereOrNull<Encounter>(Enc, a_);

		return b_;
	}

    [CqlDeclaration("Completed Immunization")]
	public IEnumerable<Immunization> Completed_Immunization(CqlContext context, IEnumerable<Immunization> Immunization)
	{
		bool? a_(Immunization I)
		{
			var c_ = context.Operators.Convert<string>(I?.StatusElement);
			var d_ = context.Operators.Equal(c_, "completed");

			return d_;
		};
		var b_ = context.Operators.WhereOrNull<Immunization>(Immunization, a_);

		return b_;
	}

    [CqlDeclaration("Dispensed Medication")]
	public IEnumerable<MedicationDispense> Dispensed_Medication(CqlContext context, IEnumerable<MedicationDispense> Med)
	{
		bool? a_(MedicationDispense M)
		{
			var c_ = context.Operators.Convert<string>(M?.StatusElement);
			var d_ = context.Operators.Equal(c_, "completed");

			return d_;
		};
		var b_ = context.Operators.WhereOrNull<MedicationDispense>(Med, a_);

		return b_;
	}

    [CqlDeclaration("Active Medication")]
	public IEnumerable<MedicationRequest> Active_Medication(CqlContext context, IEnumerable<MedicationRequest> Med)
	{
		bool? a_(MedicationRequest M)
		{
			var c_ = context.Operators.Convert<string>(M?.StatusElement);
			var d_ = new string[]
			{
				"completed",
			};
			var e_ = context.Operators.InList<string>(c_, (d_ as IEnumerable<string>));

			return e_;
		};
		var b_ = context.Operators.WhereOrNull<MedicationRequest>(Med, a_);

		return b_;
	}

    [CqlDeclaration("Completed Procedure")]
	public IEnumerable<Procedure> Completed_Procedure(CqlContext context, IEnumerable<Procedure> Proc)
	{
		bool? a_(Procedure P)
		{
			var c_ = context.Operators.Convert<string>(P?.StatusElement);
			var d_ = context.Operators.Equal(c_, "completed");

			return d_;
		};
		var b_ = context.Operators.WhereOrNull<Procedure>(Proc, a_);

		return b_;
	}

    [CqlDeclaration("Completed or Ongoing Procedure")]
	public IEnumerable<Procedure> Completed_or_Ongoing_Procedure(CqlContext context, IEnumerable<Procedure> Proc)
	{
		bool? a_(Procedure P)
		{
			var c_ = context.Operators.Convert<string>(P?.StatusElement);
			var d_ = new string[]
			{
				"completed",
				"in-progress",
			};
			var e_ = context.Operators.InList<string>(c_, (d_ as IEnumerable<string>));

			return e_;
		};
		var b_ = context.Operators.WhereOrNull<Procedure>(Proc, a_);

		return b_;
	}

}