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
		var a_ = context.Operators;
		var b_ = context.DataRetriever;
		var c_ = b_.RetrieveByValueSet<Patient>(null, null);
		var d_ = a_.SingleOrNull<Patient>(c_);

		return d_;
	}

    [CqlDeclaration("Patient")]
	public Patient Patient() => 
		__Patient.Value;

    [CqlDeclaration("Active Allergy")]
	public IEnumerable<AllergyIntolerance> Active_Allergy(IEnumerable<AllergyIntolerance> Allergy)
	{
		var a_ = context.Operators;
		bool? b_(AllergyIntolerance A)
		{
			var d_ = context.Operators;
			var e_ = A?.ClinicalStatus;
			var f_ = FHIRHelpers_4_0_001.ToConcept(e_);
			var h_ = NCQATerminology_1_0_0.allergy_active();
			var i_ = d_.ConvertCodeToConcept(h_);
			var j_ = d_.Equal(f_, i_);

			return j_;
		};
		var c_ = a_.WhereOrNull<AllergyIntolerance>(Allergy, b_);

		return c_;
	}

    [CqlDeclaration("Active Condition")]
	public IEnumerable<Condition> Active_Condition(IEnumerable<Condition> Condition)
	{
		var a_ = context.Operators;
		bool? b_(Condition C)
		{
			var d_ = context.Operators;
			var e_ = C?.ClinicalStatus;
			var f_ = FHIRHelpers_4_0_001.ToConcept(e_);
			var h_ = NCQATerminology_1_0_0.active();
			var i_ = d_.ConvertCodeToConcept(h_);
			var j_ = d_.Equal(f_, i_);

			return j_;
		};
		var c_ = a_.WhereOrNull<Condition>(Condition, b_);

		return c_;
	}

    [CqlDeclaration("Finished Encounter")]
	public IEnumerable<Encounter> Finished_Encounter(IEnumerable<Encounter> Enc)
	{
		var a_ = context.Operators;
		bool? b_(Encounter E)
		{
			var d_ = context.Operators;
			var e_ = context.Deeper(new CallStackEntry("ToString", null, null));
			var f_ = e_.Operators;
			var g_ = f_.TypeConverter;
			var h_ = E?.StatusElement;
			var i_ = g_.Convert<string>(h_);
			var j_ = d_.Equal(i_, "finished");

			return j_;
		};
		var c_ = a_.WhereOrNull<Encounter>(Enc, b_);

		return c_;
	}

    [CqlDeclaration("Completed Immunization")]
	public IEnumerable<Immunization> Completed_Immunization(IEnumerable<Immunization> Immunization)
	{
		var a_ = context.Operators;
		bool? b_(Immunization I)
		{
			var d_ = context.Operators;
			var e_ = context.Deeper(new CallStackEntry("ToString", null, null));
			var f_ = e_.Operators;
			var g_ = f_.TypeConverter;
			var h_ = I?.StatusElement;
			var i_ = g_.Convert<string>(h_);
			var j_ = d_.Equal(i_, "completed");

			return j_;
		};
		var c_ = a_.WhereOrNull<Immunization>(Immunization, b_);

		return c_;
	}

    [CqlDeclaration("Dispensed Medication")]
	public IEnumerable<MedicationDispense> Dispensed_Medication(IEnumerable<MedicationDispense> Med)
	{
		var a_ = context.Operators;
		bool? b_(MedicationDispense M)
		{
			var d_ = context.Operators;
			var e_ = context.Deeper(new CallStackEntry("ToString", null, null));
			var f_ = e_.Operators;
			var g_ = f_.TypeConverter;
			var h_ = M?.StatusElement;
			var i_ = g_.Convert<string>(h_);
			var j_ = d_.Equal(i_, "completed");

			return j_;
		};
		var c_ = a_.WhereOrNull<MedicationDispense>(Med, b_);

		return c_;
	}

    [CqlDeclaration("Active Medication")]
	public IEnumerable<MedicationRequest> Active_Medication(IEnumerable<MedicationRequest> Med)
	{
		var a_ = context.Operators;
		bool? b_(MedicationRequest M)
		{
			var d_ = context.Operators;
			var e_ = context.Deeper(new CallStackEntry("ToString", null, null));
			var f_ = e_.Operators;
			var g_ = f_.TypeConverter;
			var h_ = M?.StatusElement;
			var i_ = g_.Convert<string>(h_);
			var j_ = new string[]
			{
				"completed",
			};
			var k_ = d_.InList<string>(i_, (j_ as IEnumerable<string>));

			return k_;
		};
		var c_ = a_.WhereOrNull<MedicationRequest>(Med, b_);

		return c_;
	}

    [CqlDeclaration("Completed Procedure")]
	public IEnumerable<Procedure> Completed_Procedure(IEnumerable<Procedure> Proc)
	{
		var a_ = context.Operators;
		bool? b_(Procedure P)
		{
			var d_ = context.Operators;
			var e_ = context.Deeper(new CallStackEntry("ToString", null, null));
			var f_ = e_.Operators;
			var g_ = f_.TypeConverter;
			var h_ = P?.StatusElement;
			var i_ = g_.Convert<string>(h_);
			var j_ = d_.Equal(i_, "completed");

			return j_;
		};
		var c_ = a_.WhereOrNull<Procedure>(Proc, b_);

		return c_;
	}

    [CqlDeclaration("Completed or Ongoing Procedure")]
	public IEnumerable<Procedure> Completed_or_Ongoing_Procedure(IEnumerable<Procedure> Proc)
	{
		var a_ = context.Operators;
		bool? b_(Procedure P)
		{
			var d_ = context.Operators;
			var e_ = context.Deeper(new CallStackEntry("ToString", null, null));
			var f_ = e_.Operators;
			var g_ = f_.TypeConverter;
			var h_ = P?.StatusElement;
			var i_ = g_.Convert<string>(h_);
			var j_ = new string[]
			{
				"completed",
				"in-progress",
			};
			var k_ = d_.InList<string>(i_, (j_ as IEnumerable<string>));

			return k_;
		};
		var c_ = a_.WhereOrNull<Procedure>(Proc, b_);

		return c_;
	}

}