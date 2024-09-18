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
[CqlLibrary("NCQAHospice", "1.0.0")]
public class NCQAHospice_1_0_0
{

    public static NCQAHospice_1_0_0 Instance { get; }  = new();

    [CqlDeclaration("Hospice Encounter")]
    [CqlValueSet("https://www.ncqa.org/fhir/valueset/2.16.840.1.113883.3.464.1004.1761")]
	public CqlValueSet Hospice_Encounter(CqlContext context) => 
		new CqlValueSet("https://www.ncqa.org/fhir/valueset/2.16.840.1.113883.3.464.1004.1761", null);

    [CqlDeclaration("Hospice Intervention")]
    [CqlValueSet("https://www.ncqa.org/fhir/valueset/2.16.840.1.113883.3.464.1004.1762")]
	public CqlValueSet Hospice_Intervention(CqlContext context) => 
		new CqlValueSet("https://www.ncqa.org/fhir/valueset/2.16.840.1.113883.3.464.1004.1762", null);

    [CqlDeclaration("Measurement Period")]
	public CqlInterval<CqlDateTime> Measurement_Period(CqlContext context)
	{
		var a_ = context.ResolveParameter("NCQAHospice-1.0.0", "Measurement Period", null);

		return (CqlInterval<CqlDateTime>)a_;
	}

    [CqlDeclaration("Patient")]
	public Patient Patient(CqlContext context)
	{
		var a_ = context.Operators.RetrieveByValueSet<Patient>(null, null);
		var b_ = context.Operators.SingleOrNull<Patient>(a_);

		return b_;
	}

    [CqlDeclaration("Hospice Intervention or Encounter")]
	public bool? Hospice_Intervention_or_Encounter(CqlContext context)
	{
		var a_ = this.Hospice_Intervention(context);
		var b_ = context.Operators.RetrieveByValueSet<Procedure>(a_, null);
		var c_ = NCQAStatus_1_0_0.Instance.Completed_or_Ongoing_Procedure(context, b_);
		bool? d_(Procedure HospiceInt)
		{
			var n_ = NCQAFHIRBase_1_0_0.Instance.Normalize_Interval(context, HospiceInt?.Performed);
			var o_ = this.Measurement_Period(context);
			var p_ = context.Operators.Overlaps(n_, o_, null);

			return p_;
		};
		var e_ = context.Operators.WhereOrNull<Procedure>(c_, d_);
		var f_ = context.Operators.ExistsInList<Procedure>(e_);
		var g_ = this.Hospice_Encounter(context);
		var h_ = context.Operators.RetrieveByValueSet<Encounter>(g_, null);
		var i_ = NCQAStatus_1_0_0.Instance.Finished_Encounter(context, h_);
		bool? j_(Encounter HospiceEnc)
		{
			var q_ = NCQAFHIRBase_1_0_0.Instance.Normalize_Interval(context, (HospiceEnc?.Period as object));
			var r_ = this.Measurement_Period(context);
			var s_ = context.Operators.Overlaps(q_, r_, null);

			return s_;
		};
		var k_ = context.Operators.WhereOrNull<Encounter>(i_, j_);
		var l_ = context.Operators.ExistsInList<Encounter>(k_);
		var m_ = context.Operators.Or(f_, l_);

		return m_;
	}

}