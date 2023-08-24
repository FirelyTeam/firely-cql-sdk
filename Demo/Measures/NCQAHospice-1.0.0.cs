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
    public CqlValueSet Hospice_Encounter() => __Hospice_Encounter.Value;

    private CqlValueSet Hospice_Intervention_Value() =>
		new CqlValueSet("https://www.ncqa.org/fhir/valueset/2.16.840.1.113883.3.464.1004.1762", null);

    [CqlDeclaration("Hospice Intervention")]
    [CqlValueSet("https://www.ncqa.org/fhir/valueset/2.16.840.1.113883.3.464.1004.1762")]
    public CqlValueSet Hospice_Intervention() => __Hospice_Intervention.Value;

    private CqlInterval<CqlDateTime> Measurement_Period_Value()
	{
		var a_ = context.ResolveParameter("NCQAHospice-1.0.0", "Measurement Period", null);

		return (CqlInterval<CqlDateTime>)a_;
	}

    [CqlDeclaration("Measurement Period")]
    public CqlInterval<CqlDateTime> Measurement_Period() => __Measurement_Period.Value;

    private Patient Patient_Value()
	{
		var a_ = context?.DataRetriever.RetrieveByValueSet<Patient>(null, null);

		return context?.Operators.SingleOrNull<Patient>(a_);
	}

    [CqlDeclaration("Patient")]
    public Patient Patient() => __Patient.Value;

    private bool? Hospice_Intervention_or_Encounter_Value()
	{
		var i_ = this.Hospice_Intervention();
		var j_ = context?.DataRetriever.RetrieveByValueSet<Procedure>(i_, null);
		var k_ = NCQAStatus_1_0_0.Completed_or_Ongoing_Procedure(j_);
		var l_ = (Procedure HospiceInt) =>
		{
			var a_ = HospiceInt?.Performed;
			var b_ = (a_ as object);
			var c_ = NCQAFHIRBase_1_0_0.Normalize_Interval(b_);
			var d_ = this.Measurement_Period();

			return context?.Operators.Overlaps(c_, d_, null);
		};
		var m_ = context?.Operators.WhereOrNull<Procedure>(k_, l_);
		var n_ = context?.Operators.ExistsInList<Procedure>(m_);
		var o_ = this.Hospice_Encounter();
		var p_ = context?.DataRetriever.RetrieveByValueSet<Encounter>(o_, null);
		var q_ = NCQAStatus_1_0_0.Finished_Encounter(p_);
		var r_ = (Encounter HospiceEnc) =>
		{
			var e_ = HospiceEnc?.Period;
			var f_ = (e_ as object);
			var g_ = NCQAFHIRBase_1_0_0.Normalize_Interval(f_);
			var h_ = this.Measurement_Period();

			return context?.Operators.Overlaps(g_, h_, null);
		};
		var s_ = context?.Operators.WhereOrNull<Encounter>(q_, r_);
		var t_ = context?.Operators.ExistsInList<Encounter>(s_);

		return context?.Operators.Or(n_, t_);
	}

    [CqlDeclaration("Hospice Intervention or Encounter")]
    public bool? Hospice_Intervention_or_Encounter() => __Hospice_Intervention_or_Encounter.Value;

}