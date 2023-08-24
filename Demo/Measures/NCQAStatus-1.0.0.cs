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
		var a_ = context?.DataRetriever.RetrieveByValueSet<Patient>(null, null);

		return context?.Operators.SingleOrNull<Patient>(a_);
	}

    [CqlDeclaration("Patient")]
    public Patient Patient() => __Patient.Value;

    [CqlDeclaration("Active Allergy")]
    public IEnumerable<AllergyIntolerance> Active_Allergy(IEnumerable<AllergyIntolerance> Allergy)
	{
		var g_ = (AllergyIntolerance A) =>
		{
			var a_ = A?.ClinicalStatus;
			var b_ = FHIRHelpers_4_0_001.ToConcept(a_);
			var c_ = (b_ as object);
			var d_ = NCQATerminology_1_0_0.allergy_active();
			var e_ = context?.Operators.ConvertCodeToConcept(d_);
			var f_ = (e_ as object);

			return context?.Operators.Equal(c_, f_);
		};

		return context?.Operators.WhereOrNull<AllergyIntolerance>(Allergy, g_);
	}


    [CqlDeclaration("Active Condition")]
    public IEnumerable<Condition> Active_Condition(IEnumerable<Condition> Condition)
	{
		var g_ = (Condition C) =>
		{
			var a_ = C?.ClinicalStatus;
			var b_ = FHIRHelpers_4_0_001.ToConcept(a_);
			var c_ = (b_ as object);
			var d_ = NCQATerminology_1_0_0.active();
			var e_ = context?.Operators.ConvertCodeToConcept(d_);
			var f_ = (e_ as object);

			return context?.Operators.Equal(c_, f_);
		};

		return context?.Operators.WhereOrNull<Condition>(Condition, g_);
	}


    [CqlDeclaration("Finished Encounter")]
    public IEnumerable<Encounter> Finished_Encounter(IEnumerable<Encounter> Enc)
	{
		var e_ = (Encounter E) =>
		{
			var a_ = E?.StatusElement;
			var b_ = (a_ as object);
			var c_ = (context.Deeper(new CallStackEntry("ToString", null, null))?.Operators?.TypeConverter).Convert<string>(b_);
			var d_ = (c_ as object);

			return context?.Operators.Equal(d_, ("finished" as object));
		};

		return context?.Operators.WhereOrNull<Encounter>(Enc, e_);
	}


    [CqlDeclaration("Completed Immunization")]
    public IEnumerable<Immunization> Completed_Immunization(IEnumerable<Immunization> Immunization)
	{
		var e_ = (Immunization I) =>
		{
			var a_ = I?.StatusElement;
			var b_ = (a_ as object);
			var c_ = (context.Deeper(new CallStackEntry("ToString", null, null))?.Operators?.TypeConverter).Convert<string>(b_);
			var d_ = (c_ as object);

			return context?.Operators.Equal(d_, ("completed" as object));
		};

		return context?.Operators.WhereOrNull<Immunization>(Immunization, e_);
	}


    [CqlDeclaration("Dispensed Medication")]
    public IEnumerable<MedicationDispense> Dispensed_Medication(IEnumerable<MedicationDispense> Med)
	{
		var e_ = (MedicationDispense M) =>
		{
			var a_ = M?.StatusElement;
			var b_ = (a_ as object);
			var c_ = (context.Deeper(new CallStackEntry("ToString", null, null))?.Operators?.TypeConverter).Convert<string>(b_);
			var d_ = (c_ as object);

			return context?.Operators.Equal(d_, ("completed" as object));
		};

		return context?.Operators.WhereOrNull<MedicationDispense>(Med, e_);
	}


    [CqlDeclaration("Active Medication")]
    public IEnumerable<MedicationRequest> Active_Medication(IEnumerable<MedicationRequest> Med)
	{
		var g_ = (MedicationRequest M) =>
		{
			var a_ = M?.StatusElement;
			var b_ = (a_ as object);
			var c_ = (context.Deeper(new CallStackEntry("ToString", null, null))?.Operators?.TypeConverter).Convert<string>(b_);
			var d_ = "completed";
			var e_ = new string[]
			{
				d_,
			};
			var f_ = (e_ as IEnumerable<string>);

			return context?.Operators.InList<string>(c_, f_);
		};

		return context?.Operators.WhereOrNull<MedicationRequest>(Med, g_);
	}


    [CqlDeclaration("Completed Procedure")]
    public IEnumerable<Procedure> Completed_Procedure(IEnumerable<Procedure> Proc)
	{
		var e_ = (Procedure P) =>
		{
			var a_ = P?.StatusElement;
			var b_ = (a_ as object);
			var c_ = (context.Deeper(new CallStackEntry("ToString", null, null))?.Operators?.TypeConverter).Convert<string>(b_);
			var d_ = (c_ as object);

			return context?.Operators.Equal(d_, ("completed" as object));
		};

		return context?.Operators.WhereOrNull<Procedure>(Proc, e_);
	}


    [CqlDeclaration("Completed or Ongoing Procedure")]
    public IEnumerable<Procedure> Completed_or_Ongoing_Procedure(IEnumerable<Procedure> Proc)
	{
		var h_ = (Procedure P) =>
		{
			var a_ = P?.StatusElement;
			var b_ = (a_ as object);
			var c_ = (context.Deeper(new CallStackEntry("ToString", null, null))?.Operators?.TypeConverter).Convert<string>(b_);
			var d_ = "completed";
			var e_ = "in-progress";
			var f_ = new string[]
			{
				d_,
				e_,
			};
			var g_ = (f_ as IEnumerable<string>);

			return context?.Operators.InList<string>(c_, g_);
		};

		return context?.Operators.WhereOrNull<Procedure>(Proc, h_);
	}


}