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
		var a_ = context.Operators;
		var b_ = context.DataRetriever;
		var c_ = b_.RetrieveByValueSet<Patient>(null, null);
		var d_ = a_.SingleOrNull<Patient>(c_);

		return d_;
	}

    [CqlDeclaration("Patient")]
	public Patient Patient() => 
		__Patient.Value;

	private bool? Hospice_Intervention_or_Encounter_Value()
	{
		var a_ = context.Operators;
		var d_ = context.DataRetriever;
		var e_ = this.Hospice_Intervention();
		var f_ = d_.RetrieveByValueSet<Procedure>(e_, null);
		var g_ = NCQAStatus_1_0_0.Completed_or_Ongoing_Procedure(f_);
		bool? h_(Procedure HospiceInt)
		{
			var u_ = context.Operators;
			var v_ = HospiceInt?.Performed;
			var w_ = NCQAFHIRBase_1_0_0.Normalize_Interval(v_);
			var x_ = this.Measurement_Period();
			var y_ = u_.Overlaps(w_, x_, null);

			return y_;
		};
		var i_ = a_.WhereOrNull<Procedure>(g_, h_);
		var j_ = a_.ExistsInList<Procedure>(i_);
		var n_ = this.Hospice_Encounter();
		var o_ = d_.RetrieveByValueSet<Encounter>(n_, null);
		var p_ = NCQAStatus_1_0_0.Finished_Encounter(o_);
		bool? q_(Encounter HospiceEnc)
		{
			var z_ = context.Operators;
			var aa_ = HospiceEnc?.Period;
			var ab_ = NCQAFHIRBase_1_0_0.Normalize_Interval(aa_);
			var ac_ = this.Measurement_Period();
			var ad_ = z_.Overlaps(ab_, ac_, null);

			return ad_;
		};
		var r_ = a_.WhereOrNull<Encounter>(p_, q_);
		var s_ = a_.ExistsInList<Encounter>(r_);
		var t_ = a_.Or(j_, s_);

		return t_;
	}

    [CqlDeclaration("Hospice Intervention or Encounter")]
	public bool? Hospice_Intervention_or_Encounter() => 
		__Hospice_Intervention_or_Encounter.Value;

}