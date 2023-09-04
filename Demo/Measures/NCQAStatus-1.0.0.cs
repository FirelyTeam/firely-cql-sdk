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
[System.CodeDom.Compiler.GeneratedCode(".NET Code Generation", "0.9.0.0")]
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
        var a_ = context?.Operators.RetrieveByValueSet<Patient>(null, 
			null);
        return context?.Operators.SingleOrNull<Patient>(a_);
    }
    [CqlDeclaration("Patient")]
    public Patient Patient() => __Patient.Value;

    [CqlDeclaration("Active Allergy")]
    public IEnumerable<AllergyIntolerance> Active_Allergy(IEnumerable<AllergyIntolerance> Allergy)
    {
        Func<AllergyIntolerance,bool?> e_ = (A) => 
        {
            var b_ = A?.ClinicalStatus;
            var a_ = (FHIRHelpers_4_0_001.ToConcept(b_) as object);
            var d_ = NCQATerminology_1_0_0.allergy_active();
            var c_ = (context?.Operators.ConvertCodeToConcept(d_) as object);
            return context?.Operators.Equal(a_, 
				c_);
        };
        return context?.Operators.WhereOrNull<AllergyIntolerance>(Allergy, 
			e_);
    }

    [CqlDeclaration("Active Condition")]
    public IEnumerable<Condition> Active_Condition(IEnumerable<Condition> Condition)
    {
        Func<Condition,bool?> e_ = (C) => 
        {
            var b_ = C?.ClinicalStatus;
            var a_ = (FHIRHelpers_4_0_001.ToConcept(b_) as object);
            var d_ = NCQATerminology_1_0_0.active();
            var c_ = (context?.Operators.ConvertCodeToConcept(d_) as object);
            return context?.Operators.Equal(a_, 
				c_);
        };
        return context?.Operators.WhereOrNull<Condition>(Condition, 
			e_);
    }

    [CqlDeclaration("Finished Encounter")]
    public IEnumerable<Encounter> Finished_Encounter(IEnumerable<Encounter> Enc)
    {
        Func<Encounter,bool?> d_ = (E) => 
        {
            var b_ = (E?.StatusElement as object);
            var a_ = (context?.Operators.Convert<string>(b_) as object);
            var c_ = ("finished" as object);
            return context?.Operators.Equal(a_, 
				c_);
        };
        return context?.Operators.WhereOrNull<Encounter>(Enc, 
			d_);
    }

    [CqlDeclaration("Completed Immunization")]
    public IEnumerable<Immunization> Completed_Immunization(IEnumerable<Immunization> Immunization)
    {
        Func<Immunization,bool?> d_ = (I) => 
        {
            var b_ = (I?.StatusElement as object);
            var a_ = (context?.Operators.Convert<string>(b_) as object);
            var c_ = ("completed" as object);
            return context?.Operators.Equal(a_, 
				c_);
        };
        return context?.Operators.WhereOrNull<Immunization>(Immunization, 
			d_);
    }

    [CqlDeclaration("Dispensed Medication")]
    public IEnumerable<MedicationDispense> Dispensed_Medication(IEnumerable<MedicationDispense> Med)
    {
        Func<MedicationDispense,bool?> d_ = (M) => 
        {
            var b_ = (M?.StatusElement as object);
            var a_ = (context?.Operators.Convert<string>(b_) as object);
            var c_ = ("completed" as object);
            return context?.Operators.Equal(a_, 
				c_);
        };
        return context?.Operators.WhereOrNull<MedicationDispense>(Med, 
			d_);
    }

    [CqlDeclaration("Active Medication")]
    public IEnumerable<MedicationRequest> Active_Medication(IEnumerable<MedicationRequest> Med)
    {
        Func<MedicationRequest,bool?> e_ = (M) => 
        {
            var a_ = (M?.StatusElement as object);
            var b_ = context?.Operators.Convert<string>(a_);
            var d_ = "completed";
            var c_ = (new string[]
			{
				d_,
			} as IEnumerable<string>);
            return context?.Operators.InList<string>(b_, 
				c_);
        };
        return context?.Operators.WhereOrNull<MedicationRequest>(Med, 
			e_);
    }

    [CqlDeclaration("Completed Procedure")]
    public IEnumerable<Procedure> Completed_Procedure(IEnumerable<Procedure> Proc)
    {
        Func<Procedure,bool?> d_ = (P) => 
        {
            var b_ = (P?.StatusElement as object);
            var a_ = (context?.Operators.Convert<string>(b_) as object);
            var c_ = ("completed" as object);
            return context?.Operators.Equal(a_, 
				c_);
        };
        return context?.Operators.WhereOrNull<Procedure>(Proc, 
			d_);
    }

    [CqlDeclaration("Completed or Ongoing Procedure")]
    public IEnumerable<Procedure> Completed_or_Ongoing_Procedure(IEnumerable<Procedure> Proc)
    {
        Func<Procedure,bool?> f_ = (P) => 
        {
            var a_ = (P?.StatusElement as object);
            var b_ = context?.Operators.Convert<string>(a_);
            var d_ = "completed";
            var e_ = "in-progress";
            var c_ = (new string[]
			{
				d_,
				e_,
			} as IEnumerable<string>);
            return context?.Operators.InList<string>(b_, 
				c_);
        };
        return context?.Operators.WhereOrNull<Procedure>(Proc, 
			f_);
    }

}