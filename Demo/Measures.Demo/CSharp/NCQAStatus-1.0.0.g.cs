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
		var a_ = context?.Operators.RetrieveByValueSet<Patient>(null, null);
		var b_ = context?.Operators.SingletonFrom<Patient>(a_);

		return b_;
	}

    [CqlDeclaration("Patient")]
	public Patient Patient() => 
		__Patient?.Value;

    [CqlDeclaration("Active Allergy")]
	public IEnumerable<AllergyIntolerance> Active_Allergy(IEnumerable<AllergyIntolerance> Allergy)
	{
		bool? a_(AllergyIntolerance A)
		{
			var c_ = A.ClinicalStatus;
			var d_ = FHIRHelpers_4_0_001.ToConcept(c_);
			var e_ = NCQATerminology_1_0_0.allergy_active();
			var f_ = context?.Operators.ConvertCodeToConcept(e_);
			var g_ = context?.Operators.Equal(d_, f_);

			return g_;
		};
		var b_ = context?.Operators.Where<AllergyIntolerance>(Allergy, a_);

		return b_;
	}

    [CqlDeclaration("Active Condition")]
	public IEnumerable<Condition> Active_Condition(IEnumerable<Condition> Condition)
	{
		bool? a_(Condition C)
		{
			var c_ = C.ClinicalStatus;
			var d_ = FHIRHelpers_4_0_001.ToConcept(c_);
			var e_ = NCQATerminology_1_0_0.active();
			var f_ = context?.Operators.ConvertCodeToConcept(e_);
			var g_ = context?.Operators.Equal(d_, f_);

			return g_;
		};
		var b_ = context?.Operators.Where<Condition>(Condition, a_);

		return b_;
	}

    [CqlDeclaration("Finished Encounter")]
	public IEnumerable<Encounter> Finished_Encounter(IEnumerable<Encounter> Enc)
	{
		bool? a_(Encounter E)
		{
			var c_ = E.StatusElement;
			var d_ = FHIRHelpers_4_0_001.ToString(c_);
			var e_ = context?.Operators.Equal(d_, "finished");

			return e_;
		};
		var b_ = context?.Operators.Where<Encounter>(Enc, a_);

		return b_;
	}

    [CqlDeclaration("Completed Immunization")]
	public IEnumerable<Immunization> Completed_Immunization(IEnumerable<Immunization> Immunization)
	{
		bool? a_(Immunization I)
		{
			var c_ = I.StatusElement;
			var d_ = FHIRHelpers_4_0_001.ToString(c_);
			var e_ = context?.Operators.Equal(d_, "completed");

			return e_;
		};
		var b_ = context?.Operators.Where<Immunization>(Immunization, a_);

		return b_;
	}

    [CqlDeclaration("Dispensed Medication")]
	public IEnumerable<MedicationDispense> Dispensed_Medication(IEnumerable<MedicationDispense> Med)
	{
		bool? a_(MedicationDispense M)
		{
			var c_ = M.StatusElement;
			var d_ = FHIRHelpers_4_0_001.ToString(c_);
			var e_ = context?.Operators.Equal(d_, "completed");

			return e_;
		};
		var b_ = context?.Operators.Where<MedicationDispense>(Med, a_);

		return b_;
	}

    [CqlDeclaration("Active Medication")]
	public IEnumerable<MedicationRequest> Active_Medication(IEnumerable<MedicationRequest> Med)
	{
		bool? a_(MedicationRequest M)
		{
			var c_ = M.StatusElement;
			var d_ = FHIRHelpers_4_0_001.ToString(c_);
			var e_ = new string[]
			{
				"completed",
			};
			var f_ = context?.Operators.In<string>(d_, (e_ as IEnumerable<string>));

			return f_;
		};
		var b_ = context?.Operators.Where<MedicationRequest>(Med, a_);

		return b_;
	}

    [CqlDeclaration("Completed Procedure")]
	public IEnumerable<Procedure> Completed_Procedure(IEnumerable<Procedure> Proc)
	{
		bool? a_(Procedure P)
		{
			var c_ = P.StatusElement;
			var d_ = FHIRHelpers_4_0_001.ToString(c_);
			var e_ = context?.Operators.Equal(d_, "completed");

			return e_;
		};
		var b_ = context?.Operators.Where<Procedure>(Proc, a_);

		return b_;
	}

    [CqlDeclaration("Completed or Ongoing Procedure")]
	public IEnumerable<Procedure> Completed_or_Ongoing_Procedure(IEnumerable<Procedure> Proc)
	{
		bool? a_(Procedure P)
		{
			var c_ = P.StatusElement;
			var d_ = FHIRHelpers_4_0_001.ToString(c_);
			var e_ = new string[]
			{
				"completed",
				"in-progress",
			};
			var f_ = context?.Operators.In<string>(d_, (e_ as IEnumerable<string>));

			return f_;
		};
		var b_ = context?.Operators.Where<Procedure>(Proc, a_);

		return b_;
	}

}
