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
[CqlLibrary("NCQAStatus", "1.0.0")]
public class NCQAStatus_1_0_0
{


    internal CqlContext context;

    #region Cached values

    internal Lazy<Patient> __Patient;

    #endregion
    public NCQAStatus_1_0_0(CqlContext context)
    {
        this.context = context ?? throw new ArgumentNullException("context");

        FHIRHelpers_4_0_001 = new FHIRHelpers_4_0_001(context);
        NCQATerminology_1_0_0 = new NCQATerminology_1_0_0(context);

        __Patient = new Lazy<Patient>(this.Patient_Value);
    }
    #region Dependencies

    public FHIRHelpers_4_0_001 FHIRHelpers_4_0_001 { get; }
    public NCQATerminology_1_0_0 NCQATerminology_1_0_0 { get; }

    #endregion

	private Patient Patient_Value()
	{
		IEnumerable<Patient> a_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/StructureDefinition/Patient"));
		Patient b_ = context.Operators.SingletonFrom<Patient>(a_);

		return b_;
	}

    [CqlDeclaration("Patient")]
	public Patient Patient() => 
		__Patient.Value;

    [CqlDeclaration("Active Allergy")]
	public IEnumerable<AllergyIntolerance> Active_Allergy(IEnumerable<AllergyIntolerance> Allergy)
	{
		bool? a_(AllergyIntolerance A)
		{
			CodeableConcept c_ = A?.ClinicalStatus;
			CqlConcept d_ = FHIRHelpers_4_0_001.ToConcept(c_);
			CqlCode e_ = NCQATerminology_1_0_0.allergy_active();
			CqlConcept f_ = context.Operators.ConvertCodeToConcept(e_);
			bool? g_ = context.Operators.Equal(d_, f_);

			return g_;
		};
		IEnumerable<AllergyIntolerance> b_ = context.Operators.Where<AllergyIntolerance>(Allergy, a_);

		return b_;
	}

    [CqlDeclaration("Active Condition")]
	public IEnumerable<Condition> Active_Condition(IEnumerable<Condition> Condition)
	{
		bool? a_(Condition C)
		{
			CodeableConcept c_ = C?.ClinicalStatus;
			CqlConcept d_ = FHIRHelpers_4_0_001.ToConcept(c_);
			CqlCode e_ = NCQATerminology_1_0_0.active();
			CqlConcept f_ = context.Operators.ConvertCodeToConcept(e_);
			bool? g_ = context.Operators.Equal(d_, f_);

			return g_;
		};
		IEnumerable<Condition> b_ = context.Operators.Where<Condition>(Condition, a_);

		return b_;
	}

    [CqlDeclaration("Finished Encounter")]
	public IEnumerable<Encounter> Finished_Encounter(IEnumerable<Encounter> Enc)
	{
		bool? a_(Encounter E)
		{
			Code<Encounter.EncounterStatus> c_ = E?.StatusElement;
			string d_ = FHIRHelpers_4_0_001.ToString(c_);
			bool? e_ = context.Operators.Equal(d_, "finished");

			return e_;
		};
		IEnumerable<Encounter> b_ = context.Operators.Where<Encounter>(Enc, a_);

		return b_;
	}

    [CqlDeclaration("Completed Immunization")]
	public IEnumerable<Immunization> Completed_Immunization(IEnumerable<Immunization> Immunization)
	{
		bool? a_(Immunization I)
		{
			Code<Immunization.ImmunizationStatusCodes> c_ = I?.StatusElement;
			string d_ = FHIRHelpers_4_0_001.ToString(c_);
			bool? e_ = context.Operators.Equal(d_, "completed");

			return e_;
		};
		IEnumerable<Immunization> b_ = context.Operators.Where<Immunization>(Immunization, a_);

		return b_;
	}

    [CqlDeclaration("Dispensed Medication")]
	public IEnumerable<MedicationDispense> Dispensed_Medication(IEnumerable<MedicationDispense> Med)
	{
		bool? a_(MedicationDispense M)
		{
			Code<MedicationDispense.MedicationDispenseStatusCodes> c_ = M?.StatusElement;
			string d_ = FHIRHelpers_4_0_001.ToString(c_);
			bool? e_ = context.Operators.Equal(d_, "completed");

			return e_;
		};
		IEnumerable<MedicationDispense> b_ = context.Operators.Where<MedicationDispense>(Med, a_);

		return b_;
	}

    [CqlDeclaration("Active Medication")]
	public IEnumerable<MedicationRequest> Active_Medication(IEnumerable<MedicationRequest> Med)
	{
		bool? a_(MedicationRequest M)
		{
			Code<MedicationRequest.MedicationrequestStatus> c_ = M?.StatusElement;
			string d_ = FHIRHelpers_4_0_001.ToString(c_);
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
	public IEnumerable<Procedure> Completed_Procedure(IEnumerable<Procedure> Proc)
	{
		bool? a_(Procedure P)
		{
			Code<EventStatus> c_ = P?.StatusElement;
			string d_ = FHIRHelpers_4_0_001.ToString(c_);
			bool? e_ = context.Operators.Equal(d_, "completed");

			return e_;
		};
		IEnumerable<Procedure> b_ = context.Operators.Where<Procedure>(Proc, a_);

		return b_;
	}

    [CqlDeclaration("Completed or Ongoing Procedure")]
	public IEnumerable<Procedure> Completed_or_Ongoing_Procedure(IEnumerable<Procedure> Proc)
	{
		bool? a_(Procedure P)
		{
			Code<EventStatus> c_ = P?.StatusElement;
			string d_ = FHIRHelpers_4_0_001.ToString(c_);
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
