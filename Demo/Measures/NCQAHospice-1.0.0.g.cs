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
[System.CodeDom.Compiler.GeneratedCode(".NET Code Generation", "2.0.0.0")]
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
		new CqlValueSet("https://www.ncqa.org/fhir/valueset/2.16.840.1.113883.3.464.1004.1761", null);

    [CqlDeclaration("Hospice Encounter")]
    [CqlValueSet("https://www.ncqa.org/fhir/valueset/2.16.840.1.113883.3.464.1004.1761")]
	public CqlValueSet Hospice_Encounter() => 
		__Hospice_Encounter.Value;

	private CqlValueSet Hospice_Intervention_Value() => 
		new CqlValueSet("https://www.ncqa.org/fhir/valueset/2.16.840.1.113883.3.464.1004.1762", null);

    [CqlDeclaration("Hospice Intervention")]
    [CqlValueSet("https://www.ncqa.org/fhir/valueset/2.16.840.1.113883.3.464.1004.1762")]
	public CqlValueSet Hospice_Intervention() => 
		__Hospice_Intervention.Value;

	private CqlInterval<CqlDateTime> Measurement_Period_Value()
	{
		var a_ = context.ResolveParameter("NCQAHospice-1.0.0", "Measurement Period", null);

		return (CqlInterval<CqlDateTime>)a_;
	}

    [CqlDeclaration("Measurement Period")]
	public CqlInterval<CqlDateTime> Measurement_Period() => 
		__Measurement_Period.Value;

	private Patient Patient_Value()
	{
		var a_ = context.Operators.RetrieveByValueSet<Patient>(null, null);
		var b_ = context.Operators.Single<Patient>(a_);

		return b_;
	}

    [CqlDeclaration("Patient")]
	public Patient Patient() => 
		__Patient.Value;

	private bool? Hospice_Intervention_or_Encounter_Value()
	{
		var a_ = this.Hospice_Intervention();
		var b_ = context.Operators.RetrieveByValueSet<Procedure>(a_, null);
		var c_ = NCQAStatus_1_0_0.Completed_or_Ongoing_Procedure(b_);
		bool? d_(Procedure HospiceInt)
		{
			var n_ = NCQAFHIRBase_1_0_0.Normalize_Interval(HospiceInt?.Performed);
			var o_ = this.Measurement_Period();
			var p_ = context.Operators.Overlaps(n_, o_, null);

			return p_;
		};
		var e_ = context.Operators.WhereOrNull<Procedure>(c_, d_);
		var f_ = context.Operators.ExistsInList<Procedure>(e_);
		var g_ = this.Hospice_Encounter();
		var h_ = context.Operators.RetrieveByValueSet<Encounter>(g_, null);
		var i_ = NCQAStatus_1_0_0.Finished_Encounter(h_);
		bool? j_(Encounter HospiceEnc)
		{
			var q_ = NCQAFHIRBase_1_0_0.Normalize_Interval((HospiceEnc?.Period as object));
			var r_ = this.Measurement_Period();
			var s_ = context.Operators.Overlaps(q_, r_, null);

			return s_;
		};
		var k_ = context.Operators.WhereOrNull<Encounter>(i_, j_);
		var l_ = context.Operators.ExistsInList<Encounter>(k_);
		var m_ = context.Operators.Or(f_, l_);

		return m_;
	}

    [CqlDeclaration("Hospice Intervention or Encounter")]
	public bool? Hospice_Intervention_or_Encounter() => 
		__Hospice_Intervention_or_Encounter.Value;

}
