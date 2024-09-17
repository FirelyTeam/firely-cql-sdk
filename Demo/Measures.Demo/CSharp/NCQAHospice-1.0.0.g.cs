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
[System.CodeDom.Compiler.GeneratedCode(".NET Code Generation", "2.0.3.0")]
[CqlLibrary("NCQAHospice", "1.0.0")]
public static class NCQAHospice_1_0_0
{

    [CqlDeclaration("Hospice Encounter")]
    [CqlValueSet("https://www.ncqa.org/fhir/valueset/2.16.840.1.113883.3.464.1004.1761")]
	public static CqlValueSet Hospice_Encounter(CqlContext context) => 
		new CqlValueSet("https://www.ncqa.org/fhir/valueset/2.16.840.1.113883.3.464.1004.1761", default);

    [CqlDeclaration("Hospice Intervention")]
    [CqlValueSet("https://www.ncqa.org/fhir/valueset/2.16.840.1.113883.3.464.1004.1762")]
	public static CqlValueSet Hospice_Intervention(CqlContext context) => 
		new CqlValueSet("https://www.ncqa.org/fhir/valueset/2.16.840.1.113883.3.464.1004.1762", default);

    [CqlDeclaration("Measurement Period")]
	public static CqlInterval<CqlDateTime> Measurement_Period(CqlContext context)
	{
		object a_ = context.ResolveParameter("NCQAHospice-1.0.0", "Measurement Period", null);

		return (CqlInterval<CqlDateTime>)a_;
	}

    [CqlDeclaration("Patient")]
	public static Patient Patient(CqlContext context)
	{
		IEnumerable<Patient> a_ = context.Operators.RetrieveByValueSet<Patient>(default, default);
		Patient b_ = context.Operators.SingletonFrom<Patient>(a_);

		return b_;
	}

    [CqlDeclaration("Hospice Intervention or Encounter")]
	public static bool? Hospice_Intervention_or_Encounter(CqlContext context)
	{
		CqlValueSet a_ = NCQAHospice_1_0_0.Hospice_Intervention(context);
		IEnumerable<Procedure> b_ = context.Operators.RetrieveByValueSet<Procedure>(a_, default);
		IEnumerable<Procedure> c_ = NCQAStatus_1_0_0.Completed_or_Ongoing_Procedure(context, b_);
		bool? d_(Procedure HospiceInt)
		{
			DataType n_ = HospiceInt?.Performed;
			CqlInterval<CqlDateTime> o_ = NCQAFHIRBase_1_0_0.Normalize_Interval(context, n_);
			CqlInterval<CqlDateTime> p_ = NCQAHospice_1_0_0.Measurement_Period(context);
			bool? q_ = context.Operators.Overlaps(o_, p_, default);

			return q_;
		};
		IEnumerable<Procedure> e_ = context.Operators.Where<Procedure>(c_, d_);
		bool? f_ = context.Operators.Exists<Procedure>(e_);
		CqlValueSet g_ = NCQAHospice_1_0_0.Hospice_Encounter(context);
		IEnumerable<Encounter> h_ = context.Operators.RetrieveByValueSet<Encounter>(g_, default);
		IEnumerable<Encounter> i_ = NCQAStatus_1_0_0.Finished_Encounter(context, h_);
		bool? j_(Encounter HospiceEnc)
		{
			Period r_ = HospiceEnc?.Period;
			CqlInterval<CqlDateTime> s_ = NCQAFHIRBase_1_0_0.Normalize_Interval(context, r_ as object);
			CqlInterval<CqlDateTime> t_ = NCQAHospice_1_0_0.Measurement_Period(context);
			bool? u_ = context.Operators.Overlaps(s_, t_, default);

			return u_;
		};
		IEnumerable<Encounter> k_ = context.Operators.Where<Encounter>(i_, j_);
		bool? l_ = context.Operators.Exists<Encounter>(k_);
		bool? m_ = context.Operators.Or(f_, l_);

		return m_;
	}

}
