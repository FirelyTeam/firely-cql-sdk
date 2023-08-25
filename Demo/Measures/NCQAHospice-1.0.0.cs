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

    private CqlValueSet Hospice_Encounter_Value()
	{
		var a_ = new CqlValueSet("https://www.ncqa.org/fhir/valueset/2.16.840.1.113883.3.464.1004.1761", null);

		return a_;
	}

    [CqlDeclaration("Hospice Encounter")]
    [CqlValueSet("https://www.ncqa.org/fhir/valueset/2.16.840.1.113883.3.464.1004.1761")]
    public CqlValueSet Hospice_Encounter() => __Hospice_Encounter.Value;

    private CqlValueSet Hospice_Intervention_Value()
	{
		var a_ = new CqlValueSet("https://www.ncqa.org/fhir/valueset/2.16.840.1.113883.3.464.1004.1762", null);

		return a_;
	}

    [CqlDeclaration("Hospice Intervention")]
    [CqlValueSet("https://www.ncqa.org/fhir/valueset/2.16.840.1.113883.3.464.1004.1762")]
    public CqlValueSet Hospice_Intervention() => __Hospice_Intervention.Value;

    private CqlInterval<CqlDateTime> Measurement_Period_Value()
	{
		var a_ = context.ResolveParameter("NCQAHospice-1.0.0", "Measurement Period", null);
		var b_ = (CqlInterval<CqlDateTime>)a_;

		return b_;
	}

    [CqlDeclaration("Measurement Period")]
    public CqlInterval<CqlDateTime> Measurement_Period() => __Measurement_Period.Value;

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

    private bool? Hospice_Intervention_or_Encounter_Value()
	{
		var a_ = this.Hospice_Intervention();
		var b_ = context.DataRetriever;
		var c_ = b_.RetrieveByValueSet<Procedure>(a_, null);
		var d_ = NCQAStatus_1_0_0.Completed_or_Ongoing_Procedure(c_);
		var e_ = (Procedure HospiceInt) =>
		{
			var u_ = HospiceInt.Performed;
			var v_ = NCQAFHIRBase_1_0_0.Normalize_Interval(u_);
			var w_ = this.Measurement_Period();
			var x_ = context.Operators;
			var y_ = x_.Overlaps(v_, w_, null);

			return y_;
		};
		var f_ = context.Operators;
		var g_ = f_.WhereOrNull<Procedure>(d_, e_);
		var i_ = f_.ExistsInList<Procedure>(g_);
		var j_ = this.Hospice_Encounter();
		var l_ = b_.RetrieveByValueSet<Encounter>(j_, null);
		var m_ = NCQAStatus_1_0_0.Finished_Encounter(l_);
		var n_ = (Encounter HospiceEnc) =>
		{
			var z_ = HospiceEnc.Period;
			var aa_ = NCQAFHIRBase_1_0_0.Normalize_Interval(z_);
			var ab_ = this.Measurement_Period();
			var ac_ = context.Operators;
			var ad_ = ac_.Overlaps(aa_, ab_, null);

			return ad_;
		};
		var p_ = f_.WhereOrNull<Encounter>(m_, n_);
		var r_ = f_.ExistsInList<Encounter>(p_);
		var t_ = f_.Or(i_, r_);

		return t_;
	}

    [CqlDeclaration("Hospice Intervention or Encounter")]
    public bool? Hospice_Intervention_or_Encounter() => __Hospice_Intervention_or_Encounter.Value;

}