using System;
using System.Linq;
using System.Collections.Generic;
using Hl7.Cql.Runtime;
using Hl7.Cql.Primitives;
using Hl7.Cql.Abstractions;
using Hl7.Cql.ValueSets;
using Hl7.Cql.Iso8601;
using System.Reflection;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using Hl7.Fhir.Model;
using Range = Hl7.Fhir.Model.Range;
using Task = Hl7.Fhir.Model.Task;

#pragma warning disable CS9113 // Parameter is unread.

[System.CodeDom.Compiler.GeneratedCode(".NET Code Generation", "2.0.3.0")]
public static partial class NCQAStatus_1_0_0ServiceCollectionExtensions
{
    public static IServiceCollection AddNCQAStatus_1_0_0(this IServiceCollection services)
    {
        services.TryAddSingleton<NCQAStatus_1_0_0>();
        services.AddFHIRHelpers_4_0_001();
        services.AddNCQATerminology_1_0_0();
        return services;
    }
}

[System.CodeDom.Compiler.GeneratedCode(".NET Code Generation", "2.0.3.0")]
[CqlLibrary("NCQAStatus", "1.0.0")]
public partial class NCQAStatus_1_0_0(
    FHIRHelpers_4_0_001 fhirHelpers_4_0_001,
    NCQATerminology_1_0_0 ncqaTerminology_1_0_0)
{

    [CqlDeclaration("Patient")]
	public  Patient Patient(CqlContext context)
	{
		IEnumerable<Patient> a_ = context.Operators.RetrieveByValueSet<Patient>(default, default);
		Patient b_ = context.Operators.SingletonFrom<Patient>(a_);

		return b_;
	}

    [CqlDeclaration("Active Allergy")]
	public  IEnumerable<AllergyIntolerance> Active_Allergy(CqlContext context, IEnumerable<AllergyIntolerance> Allergy)
	{
		bool? a_(AllergyIntolerance A)
		{
			CodeableConcept c_ = A?.ClinicalStatus;
			CqlConcept d_ = fhirHelpers_4_0_001.ToConcept(context, c_);
			CqlCode e_ = ncqaTerminology_1_0_0.allergy_active(context);
			CqlConcept f_ = context.Operators.ConvertCodeToConcept(e_);
			bool? g_ = context.Operators.Equal(d_, f_);

			return g_;
		};
		IEnumerable<AllergyIntolerance> b_ = context.Operators.Where<AllergyIntolerance>(Allergy, a_);

		return b_;
	}

    [CqlDeclaration("Active Condition")]
	public  IEnumerable<Condition> Active_Condition(CqlContext context, IEnumerable<Condition> Condition)
	{
		bool? a_(Condition C)
		{
			CodeableConcept c_ = C?.ClinicalStatus;
			CqlConcept d_ = fhirHelpers_4_0_001.ToConcept(context, c_);
			CqlCode e_ = ncqaTerminology_1_0_0.active(context);
			CqlConcept f_ = context.Operators.ConvertCodeToConcept(e_);
			bool? g_ = context.Operators.Equal(d_, f_);

			return g_;
		};
		IEnumerable<Condition> b_ = context.Operators.Where<Condition>(Condition, a_);

		return b_;
	}

    [CqlDeclaration("Finished Encounter")]
	public  IEnumerable<Encounter> Finished_Encounter(CqlContext context, IEnumerable<Encounter> Enc)
	{
		bool? a_(Encounter E)
		{
			Code<Encounter.EncounterStatus> c_ = E?.StatusElement;
			string d_ = fhirHelpers_4_0_001.ToString(context, c_);
			bool? e_ = context.Operators.Equal(d_, "finished");

			return e_;
		};
		IEnumerable<Encounter> b_ = context.Operators.Where<Encounter>(Enc, a_);

		return b_;
	}

    [CqlDeclaration("Completed Immunization")]
	public  IEnumerable<Immunization> Completed_Immunization(CqlContext context, IEnumerable<Immunization> Immunization)
	{
		bool? a_(Immunization I)
		{
			Code<Immunization.ImmunizationStatusCodes> c_ = I?.StatusElement;
			string d_ = fhirHelpers_4_0_001.ToString(context, c_);
			bool? e_ = context.Operators.Equal(d_, "completed");

			return e_;
		};
		IEnumerable<Immunization> b_ = context.Operators.Where<Immunization>(Immunization, a_);

		return b_;
	}

    [CqlDeclaration("Dispensed Medication")]
	public  IEnumerable<MedicationDispense> Dispensed_Medication(CqlContext context, IEnumerable<MedicationDispense> Med)
	{
		bool? a_(MedicationDispense M)
		{
			Code<MedicationDispense.MedicationDispenseStatusCodes> c_ = M?.StatusElement;
			string d_ = fhirHelpers_4_0_001.ToString(context, c_);
			bool? e_ = context.Operators.Equal(d_, "completed");

			return e_;
		};
		IEnumerable<MedicationDispense> b_ = context.Operators.Where<MedicationDispense>(Med, a_);

		return b_;
	}

    [CqlDeclaration("Active Medication")]
	public  IEnumerable<MedicationRequest> Active_Medication(CqlContext context, IEnumerable<MedicationRequest> Med)
	{
		bool? a_(MedicationRequest M)
		{
			Code<MedicationRequest.MedicationrequestStatus> c_ = M?.StatusElement;
			string d_ = fhirHelpers_4_0_001.ToString(context, c_);
			string[] e_ = [
				"completed",
			];
			bool? f_ = context.Operators.In<string>(d_, e_ as IEnumerable<string>);

			return f_;
		};
		IEnumerable<MedicationRequest> b_ = context.Operators.Where<MedicationRequest>(Med, a_);

		return b_;
	}

    [CqlDeclaration("Completed Procedure")]
	public  IEnumerable<Procedure> Completed_Procedure(CqlContext context, IEnumerable<Procedure> Proc)
	{
		bool? a_(Procedure P)
		{
			Code<EventStatus> c_ = P?.StatusElement;
			string d_ = fhirHelpers_4_0_001.ToString(context, c_);
			bool? e_ = context.Operators.Equal(d_, "completed");

			return e_;
		};
		IEnumerable<Procedure> b_ = context.Operators.Where<Procedure>(Proc, a_);

		return b_;
	}

    [CqlDeclaration("Completed or Ongoing Procedure")]
	public  IEnumerable<Procedure> Completed_or_Ongoing_Procedure(CqlContext context, IEnumerable<Procedure> Proc)
	{
		bool? a_(Procedure P)
		{
			Code<EventStatus> c_ = P?.StatusElement;
			string d_ = fhirHelpers_4_0_001.ToString(context, c_);
			string[] e_ = [
				"completed",
				"in-progress",
			];
			bool? f_ = context.Operators.In<string>(d_, e_ as IEnumerable<string>);

			return f_;
		};
		IEnumerable<Procedure> b_ = context.Operators.Where<Procedure>(Proc, a_);

		return b_;
	}

}
