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

    private CqlInterval<CqlDateTime> Measurement_Period_Value() =>
		(CqlInterval<CqlDateTime>)context.ResolveParameter("HospiceFHIR4-2.3.000", "Measurement Period", null);

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
		var ax_ = this.Encounter_Inpatient();
		var ay_ = context?.DataRetriever.RetrieveByValueSet<Encounter>(ax_, null);
		var az_ = (Encounter DischargeHospice) =>
		{
			var a_ = (DischargeHospice?.StatusElement as object);
			var b_ = (context.Deeper(new CallStackEntry("ToString", null, null))?.Operators?.TypeConverter).Convert<string>(a_);
			var c_ = (b_ as object);
			var d_ = context?.Operators.Equal(c_, ("finished" as object));
			var e_ = DischargeHospice?.Hospitalization?.DischargeDisposition;
			var f_ = FHIRHelpers_4_0_001.ToConcept(e_);
			var g_ = (f_ as object);
			var h_ = this.Discharge_to_home_for_hospice_care__procedure_();
			var i_ = context?.Operators.ConvertCodeToConcept(h_);
			var j_ = (i_ as object);
			var k_ = context?.Operators.Equivalent(g_, j_);
			var l_ = DischargeHospice?.Hospitalization?.DischargeDisposition;
			var m_ = FHIRHelpers_4_0_001.ToConcept(l_);
			var n_ = (m_ as object);
			var o_ = this.Discharge_to_healthcare_facility_for_hospice_care__procedure_();
			var p_ = context?.Operators.ConvertCodeToConcept(o_);
			var q_ = (p_ as object);
			var r_ = context?.Operators.Equivalent(n_, q_);
			var s_ = context?.Operators.Or(k_, r_);
			var t_ = context?.Operators.And(d_, s_);
			var u_ = (DischargeHospice?.Period as object);
			var v_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Normalize_Interval(u_);
			var w_ = context?.Operators.End(v_);
			var x_ = this.Measurement_Period();
			var y_ = context?.Operators.ElementInInterval<CqlDateTime>(w_, x_, null);

			return context?.Operators.And(t_, y_);
		};
		var ba_ = context?.Operators.WhereOrNull<Encounter>(ay_, az_);
		var bb_ = context?.Operators.ExistsInList<Encounter>(ba_);
		var bc_ = this.Hospice_care_ambulatory();
		var bd_ = context?.DataRetriever.RetrieveByValueSet<ServiceRequest>(bc_, null);
		var be_ = (ServiceRequest HospiceOrder) =>
		{
			var z_ = (HospiceOrder?.StatusElement as object);
			var aa_ = (context.Deeper(new CallStackEntry("ToString", null, null))?.Operators?.TypeConverter).Convert<string>(z_);
			var ab_ = "active";
			var ac_ = "completed";
			var ad_ = new string[]
			{
				ab_,
				ac_,
			};
			var ae_ = (ad_ as IEnumerable<string>);
			var af_ = context?.Operators.InList<string>(aa_, ae_);
			var ag_ = (HospiceOrder?.IntentElement as object);
			var ah_ = (context.Deeper(new CallStackEntry("ToString", null, null))?.Operators?.TypeConverter).Convert<string>(ag_);
			var ai_ = (ah_ as object);
			var aj_ = context?.Operators.Equal(ai_, ("order" as object));
			var ak_ = context?.Operators.And(af_, aj_);
			var al_ = this.Measurement_Period();
			var am_ = (HospiceOrder?.AuthoredOnElement as object);
			var an_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Normalize_Interval(am_);
			var ao_ = context?.Operators.IntervalIncludesInterval<CqlDateTime>(al_, an_, null);

			return context?.Operators.And(ak_, ao_);
		};
		var bf_ = context?.Operators.WhereOrNull<ServiceRequest>(bd_, be_);
		var bg_ = context?.Operators.ExistsInList<ServiceRequest>(bf_);
		var bh_ = context?.Operators.Or(bb_, bg_);
		var bi_ = this.Hospice_care_ambulatory();
		var bj_ = context?.DataRetriever.RetrieveByValueSet<Procedure>(bi_, null);
		var bk_ = (Procedure HospicePerformed) =>
		{
			var ap_ = (HospicePerformed?.StatusElement as object);
			var aq_ = (context.Deeper(new CallStackEntry("ToString", null, null))?.Operators?.TypeConverter).Convert<string>(ap_);
			var ar_ = (aq_ as object);
			var as_ = context?.Operators.Equal(ar_, ("completed" as object));
			var at_ = (HospicePerformed?.Performed as object);
			var au_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Normalize_Interval(at_);
			var av_ = this.Measurement_Period();
			var aw_ = context?.Operators.Overlaps(au_, av_, null);

			return context?.Operators.And(as_, aw_);
		};
		var bl_ = context?.Operators.WhereOrNull<Procedure>(bj_, bk_);
		var bm_ = context?.Operators.ExistsInList<Procedure>(bl_);

		return context?.Operators.Or(bh_, bm_);
	}

    [CqlDeclaration("Has Hospice")]
    public bool? Has_Hospice() => __Has_Hospice.Value;

}