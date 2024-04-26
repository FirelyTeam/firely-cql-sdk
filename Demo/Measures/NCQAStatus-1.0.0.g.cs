using System;
using Tuples;
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
[System.CodeDom.Compiler.GeneratedCode(".NET Code Generation", "2.0.0.0")]
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
		IEnumerable<Patient> a_ = context.Operators.RetrieveByValueSet<Patient>(null, null);
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
			CqlConcept c_ = FHIRHelpers_4_0_001.ToConcept(A?.ClinicalStatus);
			CqlCode d_ = NCQATerminology_1_0_0.allergy_active();
			CqlConcept e_ = context.Operators.ConvertCodeToConcept(d_);
			bool? f_ = context.Operators.Equal(c_, e_);

			return f_;
		};
		IEnumerable<AllergyIntolerance> b_ = context.Operators.Where<AllergyIntolerance>(Allergy, a_);

		return b_;
	}

    [CqlDeclaration("Active Condition")]
	public IEnumerable<Condition> Active_Condition(IEnumerable<Condition> Condition)
	{
		bool? a_(Condition C)
		{
			CqlConcept c_ = FHIRHelpers_4_0_001.ToConcept(C?.ClinicalStatus);
			CqlCode d_ = NCQATerminology_1_0_0.active();
			CqlConcept e_ = context.Operators.ConvertCodeToConcept(d_);
			bool? f_ = context.Operators.Equal(c_, e_);

			return f_;
		};
		IEnumerable<Condition> b_ = context.Operators.Where<Condition>(Condition, a_);

		return b_;
	}

    [CqlDeclaration("Finished Encounter")]
	public IEnumerable<Encounter> Finished_Encounter(IEnumerable<Encounter> Enc)
	{
		bool? a_(Encounter E)
		{
			string c_ = context.Operators.Convert<string>(E?.StatusElement);
			bool? d_ = context.Operators.Equal(c_, "finished");

			return d_;
		};
		IEnumerable<Encounter> b_ = context.Operators.Where<Encounter>(Enc, a_);

		return b_;
	}

    [CqlDeclaration("Completed Immunization")]
	public IEnumerable<Immunization> Completed_Immunization(IEnumerable<Immunization> Immunization)
	{
		bool? a_(Immunization I)
		{
			string c_ = context.Operators.Convert<string>(I?.StatusElement);
			bool? d_ = context.Operators.Equal(c_, "completed");

			return d_;
		};
		IEnumerable<Immunization> b_ = context.Operators.Where<Immunization>(Immunization, a_);

		return b_;
	}

    [CqlDeclaration("Dispensed Medication")]
	public IEnumerable<MedicationDispense> Dispensed_Medication(IEnumerable<MedicationDispense> Med)
	{
		bool? a_(MedicationDispense M)
		{
			string c_ = context.Operators.Convert<string>(M?.StatusElement);
			bool? d_ = context.Operators.Equal(c_, "completed");

			return d_;
		};
		IEnumerable<MedicationDispense> b_ = context.Operators.Where<MedicationDispense>(Med, a_);

		return b_;
	}

    [CqlDeclaration("Active Medication")]
	public IEnumerable<MedicationRequest> Active_Medication(IEnumerable<MedicationRequest> Med)
	{
		bool? a_(MedicationRequest M)
		{
			string c_ = context.Operators.Convert<string>(M?.StatusElement);
			string[] d_ = new string[]
			{
				"completed",
			};
			bool? e_ = context.Operators.In<string>(c_, (d_ as IEnumerable<string>));

			return e_;
		};
		IEnumerable<MedicationRequest> b_ = context.Operators.Where<MedicationRequest>(Med, a_);

		return b_;
	}

    [CqlDeclaration("Completed Procedure")]
	public IEnumerable<Procedure> Completed_Procedure(IEnumerable<Procedure> Proc)
	{
		bool? a_(Procedure P)
		{
			string c_ = context.Operators.Convert<string>(P?.StatusElement);
			bool? d_ = context.Operators.Equal(c_, "completed");

			return d_;
		};
		IEnumerable<Procedure> b_ = context.Operators.Where<Procedure>(Proc, a_);

		return b_;
	}

    [CqlDeclaration("Completed or Ongoing Procedure")]
	public IEnumerable<Procedure> Completed_or_Ongoing_Procedure(IEnumerable<Procedure> Proc)
	{
		bool? a_(Procedure P)
		{
			string c_ = context.Operators.Convert<string>(P?.StatusElement);
			string[] d_ = new string[]
			{
				"completed",
				"in-progress",
			};
			bool? e_ = context.Operators.In<string>(c_, (d_ as IEnumerable<string>));

			return e_;
		};
		IEnumerable<Procedure> b_ = context.Operators.Where<Procedure>(Proc, a_);

		return b_;
	}

}
