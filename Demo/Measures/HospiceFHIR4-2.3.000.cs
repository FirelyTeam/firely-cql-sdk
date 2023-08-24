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
[CqlLibrary("HospiceFHIR4", "2.3.000")]
public class HospiceFHIR4_2_3_000
{


    internal CqlContext context;

    #region Cached values

    internal Lazy<CqlValueSet> __Encounter_Inpatient;
    internal Lazy<CqlValueSet> __Hospice_care_ambulatory;
    internal Lazy<CqlCode> __Discharge_to_healthcare_facility_for_hospice_care__procedure_;
    internal Lazy<CqlCode> __Discharge_to_home_for_hospice_care__procedure_;
    internal Lazy<CqlCode[]> __SNOMEDCT_2017_09;
    internal Lazy<CqlInterval<CqlDateTime>> __Measurement_Period;
    internal Lazy<Patient> __Patient;
    internal Lazy<bool?> __Has_Hospice;

    #endregion
    public HospiceFHIR4_2_3_000(CqlContext context)
    {
        this.context = context ?? throw new ArgumentNullException("context");

        MATGlobalCommonFunctionsFHIR4_6_1_000 = new MATGlobalCommonFunctionsFHIR4_6_1_000(context);
        FHIRHelpers_4_0_001 = new FHIRHelpers_4_0_001(context);

        __Encounter_Inpatient = new Lazy<CqlValueSet>(this.Encounter_Inpatient_Value);
        __Hospice_care_ambulatory = new Lazy<CqlValueSet>(this.Hospice_care_ambulatory_Value);
        __Discharge_to_healthcare_facility_for_hospice_care__procedure_ = new Lazy<CqlCode>(this.Discharge_to_healthcare_facility_for_hospice_care__procedure__Value);
        __Discharge_to_home_for_hospice_care__procedure_ = new Lazy<CqlCode>(this.Discharge_to_home_for_hospice_care__procedure__Value);
        __SNOMEDCT_2017_09 = new Lazy<CqlCode[]>(this.SNOMEDCT_2017_09_Value);
        __Measurement_Period = new Lazy<CqlInterval<CqlDateTime>>(this.Measurement_Period_Value);
        __Patient = new Lazy<Patient>(this.Patient_Value);
        __Has_Hospice = new Lazy<bool?>(this.Has_Hospice_Value);
    }
    #region Dependencies

    public MATGlobalCommonFunctionsFHIR4_6_1_000 MATGlobalCommonFunctionsFHIR4_6_1_000 { get; }
    public FHIRHelpers_4_0_001 FHIRHelpers_4_0_001 { get; }

    #endregion

    private CqlValueSet Encounter_Inpatient_Value() =>
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.666.5.307", null);

    [CqlDeclaration("Encounter Inpatient")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.666.5.307")]
    public CqlValueSet Encounter_Inpatient() => __Encounter_Inpatient.Value;

    private CqlValueSet Hospice_care_ambulatory_Value() =>
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1108.15", null);

    [CqlDeclaration("Hospice care ambulatory")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1108.15")]
    public CqlValueSet Hospice_care_ambulatory() => __Hospice_care_ambulatory.Value;

    private CqlCode Discharge_to_healthcare_facility_for_hospice_care__procedure__Value() =>
		new CqlCode("428371000124100", "http://snomed.info/sct", null, null);

    [CqlDeclaration("Discharge to healthcare facility for hospice care (procedure)")]
    public CqlCode Discharge_to_healthcare_facility_for_hospice_care__procedure_() => __Discharge_to_healthcare_facility_for_hospice_care__procedure_.Value;

    private CqlCode Discharge_to_home_for_hospice_care__procedure__Value() =>
		new CqlCode("428361000124107", "http://snomed.info/sct", null, null);

    [CqlDeclaration("Discharge to home for hospice care (procedure)")]
    public CqlCode Discharge_to_home_for_hospice_care__procedure_() => __Discharge_to_home_for_hospice_care__procedure_.Value;

    private CqlCode[] SNOMEDCT_2017_09_Value()
	{
		var a_ = new CqlCode("428371000124100", "http://snomed.info/sct", null, null);
		var b_ = new CqlCode("428361000124107", "http://snomed.info/sct", null, null);

		return new CqlCode[]
		{
			a_,
			b_,
		};
	}

    [CqlDeclaration("SNOMEDCT:2017-09")]
    public CqlCode[] SNOMEDCT_2017_09() => __SNOMEDCT_2017_09.Value;

    private CqlInterval<CqlDateTime> Measurement_Period_Value()
	{
		var a_ = context.ResolveParameter("HospiceFHIR4-2.3.000", "Measurement Period", null);

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

    private bool? Has_Hospice_Value()
	{
		var bg_ = this.Encounter_Inpatient();
		var bh_ = context?.DataRetriever.RetrieveByValueSet<Encounter>(bg_, null);
		var bi_ = (Encounter DischargeHospice) =>
		{
			var a_ = DischargeHospice?.StatusElement;
			var b_ = (a_ as object);
			var c_ = (context.Deeper(new CallStackEntry("ToString", null, null))?.Operators?.TypeConverter).Convert<string>(b_);
			var d_ = (c_ as object);
			var e_ = context?.Operators.Equal(d_, ("finished" as object));
			var f_ = DischargeHospice?.Hospitalization;
			var g_ = f_?.DischargeDisposition;
			var h_ = FHIRHelpers_4_0_001.ToConcept(g_);
			var i_ = (h_ as object);
			var j_ = this.Discharge_to_home_for_hospice_care__procedure_();
			var k_ = context?.Operators.ConvertCodeToConcept(j_);
			var l_ = (k_ as object);
			var m_ = context?.Operators.Equivalent(i_, l_);
			var n_ = DischargeHospice?.Hospitalization;
			var o_ = n_?.DischargeDisposition;
			var p_ = FHIRHelpers_4_0_001.ToConcept(o_);
			var q_ = (p_ as object);
			var r_ = this.Discharge_to_healthcare_facility_for_hospice_care__procedure_();
			var s_ = context?.Operators.ConvertCodeToConcept(r_);
			var t_ = (s_ as object);
			var u_ = context?.Operators.Equivalent(q_, t_);
			var v_ = context?.Operators.Or(m_, u_);
			var w_ = context?.Operators.And(e_, v_);
			var x_ = DischargeHospice?.Period;
			var y_ = (x_ as object);
			var z_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Normalize_Interval(y_);
			var aa_ = context?.Operators.End(z_);
			var ab_ = this.Measurement_Period();
			var ac_ = context?.Operators.ElementInInterval<CqlDateTime>(aa_, ab_, null);

			return context?.Operators.And(w_, ac_);
		};
		var bj_ = context?.Operators.WhereOrNull<Encounter>(bh_, bi_);
		var bk_ = context?.Operators.ExistsInList<Encounter>(bj_);
		var bl_ = this.Hospice_care_ambulatory();
		var bm_ = context?.DataRetriever.RetrieveByValueSet<ServiceRequest>(bl_, null);
		var bn_ = (ServiceRequest HospiceOrder) =>
		{
			var ad_ = HospiceOrder?.StatusElement;
			var ae_ = (ad_ as object);
			var af_ = (context.Deeper(new CallStackEntry("ToString", null, null))?.Operators?.TypeConverter).Convert<string>(ae_);
			var ag_ = "active";
			var ah_ = "completed";
			var ai_ = new string[]
			{
				ag_,
				ah_,
			};
			var aj_ = (ai_ as IEnumerable<string>);
			var ak_ = context?.Operators.InList<string>(af_, aj_);
			var al_ = HospiceOrder?.IntentElement;
			var am_ = (al_ as object);
			var an_ = (context.Deeper(new CallStackEntry("ToString", null, null))?.Operators?.TypeConverter).Convert<string>(am_);
			var ao_ = (an_ as object);
			var ap_ = context?.Operators.Equal(ao_, ("order" as object));
			var aq_ = context?.Operators.And(ak_, ap_);
			var ar_ = this.Measurement_Period();
			var as_ = HospiceOrder?.AuthoredOnElement;
			var at_ = (as_ as object);
			var au_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Normalize_Interval(at_);
			var av_ = context?.Operators.IntervalIncludesInterval<CqlDateTime>(ar_, au_, null);

			return context?.Operators.And(aq_, av_);
		};
		var bo_ = context?.Operators.WhereOrNull<ServiceRequest>(bm_, bn_);
		var bp_ = context?.Operators.ExistsInList<ServiceRequest>(bo_);
		var bq_ = context?.Operators.Or(bk_, bp_);
		var br_ = this.Hospice_care_ambulatory();
		var bs_ = context?.DataRetriever.RetrieveByValueSet<Procedure>(br_, null);
		var bt_ = (Procedure HospicePerformed) =>
		{
			var aw_ = HospicePerformed?.StatusElement;
			var ax_ = (aw_ as object);
			var ay_ = (context.Deeper(new CallStackEntry("ToString", null, null))?.Operators?.TypeConverter).Convert<string>(ax_);
			var az_ = (ay_ as object);
			var ba_ = context?.Operators.Equal(az_, ("completed" as object));
			var bb_ = HospicePerformed?.Performed;
			var bc_ = (bb_ as object);
			var bd_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Normalize_Interval(bc_);
			var be_ = this.Measurement_Period();
			var bf_ = context?.Operators.Overlaps(bd_, be_, null);

			return context?.Operators.And(ba_, bf_);
		};
		var bu_ = context?.Operators.WhereOrNull<Procedure>(bs_, bt_);
		var bv_ = context?.Operators.ExistsInList<Procedure>(bu_);

		return context?.Operators.Or(bq_, bv_);
	}

    [CqlDeclaration("Has Hospice")]
    public bool? Has_Hospice() => __Has_Hospice.Value;

}