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
[CqlLibrary("NCQAHospice", "1.0.0")]
public class NCQAHospice_1_0_0
{


    internal CqlContext context;

    #region Cached values

    internal Lazy<CqlValueSet> __Hospice_Encounter;
    internal Lazy<CqlValueSet> __Hospice_Intervention;
    internal Lazy<CqlInterval<CqlDateTime>> __Measurement_Period;
    internal Lazy<Patient> __Patient;
    internal Lazy<bool?> __Hospice_Intervention_or_Encounter;

    #endregion
    public NCQAHospice_1_0_0(CqlContext context)
    {
        this.context = context ?? throw new ArgumentNullException("context");

        FHIRHelpers_4_0_001 = new FHIRHelpers_4_0_001(context);
        NCQAFHIRBase_1_0_0 = new NCQAFHIRBase_1_0_0(context);
        NCQAStatus_1_0_0 = new NCQAStatus_1_0_0(context);

        __Hospice_Encounter = new Lazy<CqlValueSet>(this.Hospice_Encounter_Value);
        __Hospice_Intervention = new Lazy<CqlValueSet>(this.Hospice_Intervention_Value);
        __Measurement_Period = new Lazy<CqlInterval<CqlDateTime>>(this.Measurement_Period_Value);
        __Patient = new Lazy<Patient>(this.Patient_Value);
        __Hospice_Intervention_or_Encounter = new Lazy<bool?>(this.Hospice_Intervention_or_Encounter_Value);
    }
    #region Dependencies

    public FHIRHelpers_4_0_001 FHIRHelpers_4_0_001 { get; }
    public NCQAFHIRBase_1_0_0 NCQAFHIRBase_1_0_0 { get; }
    public NCQAStatus_1_0_0 NCQAStatus_1_0_0 { get; }

    #endregion

	private CqlValueSet Hospice_Encounter_Value() => 
		new CqlValueSet("https://www.ncqa.org/fhir/valueset/2.16.840.1.113883.3.464.1004.1761", default);

    [CqlDeclaration("Hospice Encounter")]
    [CqlValueSet("https://www.ncqa.org/fhir/valueset/2.16.840.1.113883.3.464.1004.1761")]
	public CqlValueSet Hospice_Encounter() => 
		__Hospice_Encounter.Value;

	private CqlValueSet Hospice_Intervention_Value() => 
		new CqlValueSet("https://www.ncqa.org/fhir/valueset/2.16.840.1.113883.3.464.1004.1762", default);

    [CqlDeclaration("Hospice Intervention")]
    [CqlValueSet("https://www.ncqa.org/fhir/valueset/2.16.840.1.113883.3.464.1004.1762")]
	public CqlValueSet Hospice_Intervention() => 
		__Hospice_Intervention.Value;

	private CqlInterval<CqlDateTime> Measurement_Period_Value()
	{
		object a_ = context.ResolveParameter("NCQAHospice-1.0.0", "Measurement Period", null);

		return (CqlInterval<CqlDateTime>)a_;
	}

    [CqlDeclaration("Measurement Period")]
	public CqlInterval<CqlDateTime> Measurement_Period() => 
		__Measurement_Period.Value;

	private Patient Patient_Value()
	{
		IEnumerable<Patient> a_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/StructureDefinition/Patient"));
		Patient b_ = context.Operators.SingletonFrom<Patient>(a_);

		return b_;
	}

    [CqlDeclaration("Patient")]
	public Patient Patient() => 
		__Patient.Value;

	private bool? Hospice_Intervention_or_Encounter_Value()
	{
		CqlValueSet a_ = this.Hospice_Intervention();
		IEnumerable<Procedure> b_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/StructureDefinition/Procedure"));
		IEnumerable<Procedure> c_ = NCQAStatus_1_0_0.Completed_or_Ongoing_Procedure(b_);
		bool? d_(Procedure HospiceInt)
		{
			DataType n_ = HospiceInt?.Performed;
			CqlInterval<CqlDateTime> o_ = NCQAFHIRBase_1_0_0.Normalize_Interval(n_);
			CqlInterval<CqlDateTime> p_ = this.Measurement_Period();
			bool? q_ = context.Operators.Overlaps(o_, p_, default);

			return q_;
		};
		IEnumerable<Procedure> e_ = context.Operators.Where<Procedure>(c_, d_);
		bool? f_ = context.Operators.Exists<Procedure>(e_);
		CqlValueSet g_ = this.Hospice_Encounter();
		IEnumerable<Encounter> h_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, g_, default, "http://hl7.org/fhir/StructureDefinition/Encounter"));
		IEnumerable<Encounter> i_ = NCQAStatus_1_0_0.Finished_Encounter(h_);
		bool? j_(Encounter HospiceEnc)
		{
			Period r_ = HospiceEnc?.Period;
			CqlInterval<CqlDateTime> s_ = NCQAFHIRBase_1_0_0.Normalize_Interval(r_ as object);
			CqlInterval<CqlDateTime> t_ = this.Measurement_Period();
			bool? u_ = context.Operators.Overlaps(s_, t_, default);

			return u_;
		};
		IEnumerable<Encounter> k_ = context.Operators.Where<Encounter>(i_, j_);
		bool? l_ = context.Operators.Exists<Encounter>(k_);
		bool? m_ = context.Operators.Or(f_, l_);

		return m_;
	}

    [CqlDeclaration("Hospice Intervention or Encounter")]
	public bool? Hospice_Intervention_or_Encounter() => 
		__Hospice_Intervention_or_Encounter.Value;

}
