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
		var a_ = context.DataRetriever;
		var b_ = a_.RetrieveByValueSet<Patient>(null, null);
		var c_ = context.Operators;
		var d_ = c_.SingleOrNull<Patient>(b_);

		return d_;
	}

    [CqlDeclaration("Patient")]
    public Patient Patient() => __Patient.Value;

    [CqlDeclaration("Active Allergy")]
    public IEnumerable<AllergyIntolerance> Active_Allergy(IEnumerable<AllergyIntolerance> Allergy)
	{
		bool? a_(AllergyIntolerance A)
		{
			var d_ = A.ClinicalStatus;
			var e_ = FHIRHelpers_4_0_001.ToConcept(d_);
			var f_ = NCQATerminology_1_0_0.allergy_active();
			var g_ = context.Operators;
			var h_ = g_.ConvertCodeToConcept(f_);
			var j_ = g_.Equal(e_, h_);

			return j_;
		};
		var b_ = context.Operators;
		var c_ = b_.WhereOrNull<AllergyIntolerance>(Allergy, a_);

		return c_;
	}


    [CqlDeclaration("Active Condition")]
    public IEnumerable<Condition> Active_Condition(IEnumerable<Condition> Condition)
	{
		bool? a_(Condition C)
		{
			var d_ = C.ClinicalStatus;
			var e_ = FHIRHelpers_4_0_001.ToConcept(d_);
			var f_ = NCQATerminology_1_0_0.active();
			var g_ = context.Operators;
			var h_ = g_.ConvertCodeToConcept(f_);
			var j_ = g_.Equal(e_, h_);

			return j_;
		};
		var b_ = context.Operators;
		var c_ = b_.WhereOrNull<Condition>(Condition, a_);

		return c_;
	}


    [CqlDeclaration("Finished Encounter")]
    public IEnumerable<Encounter> Finished_Encounter(IEnumerable<Encounter> Enc)
	{
		bool? a_(Encounter E)
		{
			var d_ = E.StatusElement;
			var e_ = new CallStackEntry("ToString", null, null);
			var f_ = context.Deeper(e_);
			var g_ = f_.Operators;
			var h_ = g_.TypeConverter;
			var i_ = h_.Convert<string>(d_);
			var j_ = context.Operators;
			var k_ = j_.Equal(i_, "finished");

			return k_;
		};
		var b_ = context.Operators;
		var c_ = b_.WhereOrNull<Encounter>(Enc, a_);

		return c_;
	}


    [CqlDeclaration("Completed Immunization")]
    public IEnumerable<Immunization> Completed_Immunization(IEnumerable<Immunization> Immunization)
	{
		bool? a_(Immunization I)
		{
			var d_ = I.StatusElement;
			var e_ = new CallStackEntry("ToString", null, null);
			var f_ = context.Deeper(e_);
			var g_ = f_.Operators;
			var h_ = g_.TypeConverter;
			var i_ = h_.Convert<string>(d_);
			var j_ = context.Operators;
			var k_ = j_.Equal(i_, "completed");

			return k_;
		};
		var b_ = context.Operators;
		var c_ = b_.WhereOrNull<Immunization>(Immunization, a_);

		return c_;
	}


    [CqlDeclaration("Dispensed Medication")]
    public IEnumerable<MedicationDispense> Dispensed_Medication(IEnumerable<MedicationDispense> Med)
	{
		bool? a_(MedicationDispense M)
		{
			var d_ = M.StatusElement;
			var e_ = new CallStackEntry("ToString", null, null);
			var f_ = context.Deeper(e_);
			var g_ = f_.Operators;
			var h_ = g_.TypeConverter;
			var i_ = h_.Convert<string>(d_);
			var j_ = context.Operators;
			var k_ = j_.Equal(i_, "completed");

			return k_;
		};
		var b_ = context.Operators;
		var c_ = b_.WhereOrNull<MedicationDispense>(Med, a_);

		return c_;
	}


    [CqlDeclaration("Active Medication")]
    public IEnumerable<MedicationRequest> Active_Medication(IEnumerable<MedicationRequest> Med)
	{
		bool? a_(MedicationRequest M)
		{
			var d_ = M.StatusElement;
			var e_ = new CallStackEntry("ToString", null, null);
			var f_ = context.Deeper(e_);
			var g_ = f_.Operators;
			var h_ = g_.TypeConverter;
			var i_ = h_.Convert<string>(d_);
			var j_ = new string[]
			{
				"completed",
			};
			var k_ = context.Operators;
			var l_ = k_.InList<string>(i_, (j_ as IEnumerable<string>));

			return l_;
		};
		var b_ = context.Operators;
		var c_ = b_.WhereOrNull<MedicationRequest>(Med, a_);

		return c_;
	}


    [CqlDeclaration("Completed Procedure")]
    public IEnumerable<Procedure> Completed_Procedure(IEnumerable<Procedure> Proc)
	{
		bool? a_(Procedure P)
		{
			var d_ = P.StatusElement;
			var e_ = new CallStackEntry("ToString", null, null);
			var f_ = context.Deeper(e_);
			var g_ = f_.Operators;
			var h_ = g_.TypeConverter;
			var i_ = h_.Convert<string>(d_);
			var j_ = context.Operators;
			var k_ = j_.Equal(i_, "completed");

			return k_;
		};
		var b_ = context.Operators;
		var c_ = b_.WhereOrNull<Procedure>(Proc, a_);

		return c_;
	}


    [CqlDeclaration("Completed or Ongoing Procedure")]
    public IEnumerable<Procedure> Completed_or_Ongoing_Procedure(IEnumerable<Procedure> Proc)
	{
		bool? a_(Procedure P)
		{
			var d_ = P.StatusElement;
			var e_ = new CallStackEntry("ToString", null, null);
			var f_ = context.Deeper(e_);
			var g_ = f_.Operators;
			var h_ = g_.TypeConverter;
			var i_ = h_.Convert<string>(d_);
			var j_ = new string[]
			{
				"completed",
				"in-progress",
			};
			var k_ = context.Operators;
			var l_ = k_.InList<string>(i_, (j_ as IEnumerable<string>));

			return l_;
		};
		var b_ = context.Operators;
		var c_ = b_.WhereOrNull<Procedure>(Proc, a_);

		return c_;
	}


}