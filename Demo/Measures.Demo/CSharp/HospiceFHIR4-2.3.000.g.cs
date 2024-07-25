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
[System.CodeDom.Compiler.GeneratedCode(".NET Code Generation", "2.0.0.0")]
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
	public CqlValueSet Encounter_Inpatient() => 
		__Encounter_Inpatient?.Value;

	private CqlValueSet Hospice_care_ambulatory_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1108.15", null);

    [CqlDeclaration("Hospice care ambulatory")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1108.15")]
	public CqlValueSet Hospice_care_ambulatory() => 
		__Hospice_care_ambulatory?.Value;

	private CqlCode Discharge_to_healthcare_facility_for_hospice_care__procedure__Value() => 
		new CqlCode("428371000124100", "http://snomed.info/sct", null, null);

    [CqlDeclaration("Discharge to healthcare facility for hospice care (procedure)")]
	public CqlCode Discharge_to_healthcare_facility_for_hospice_care__procedure_() => 
		__Discharge_to_healthcare_facility_for_hospice_care__procedure_?.Value;

	private CqlCode Discharge_to_home_for_hospice_care__procedure__Value() => 
		new CqlCode("428361000124107", "http://snomed.info/sct", null, null);

    [CqlDeclaration("Discharge to home for hospice care (procedure)")]
	public CqlCode Discharge_to_home_for_hospice_care__procedure_() => 
		__Discharge_to_home_for_hospice_care__procedure_?.Value;

	private CqlCode[] SNOMEDCT_2017_09_Value()
	{
		var a_ = new CqlCode[]
		{
			new CqlCode("428371000124100", "http://snomed.info/sct", null, null),
			new CqlCode("428361000124107", "http://snomed.info/sct", null, null),
		};

		return a_;
	}

    [CqlDeclaration("SNOMEDCT:2017-09")]
	public CqlCode[] SNOMEDCT_2017_09() => 
		__SNOMEDCT_2017_09?.Value;

	private CqlInterval<CqlDateTime> Measurement_Period_Value()
	{
		var a_ = context.ResolveParameter("HospiceFHIR4-2.3.000", "Measurement Period", null);

		return (CqlInterval<CqlDateTime>)a_;
	}

    [CqlDeclaration("Measurement Period")]
	public CqlInterval<CqlDateTime> Measurement_Period() => 
		__Measurement_Period?.Value;

	private Patient Patient_Value()
	{
		var a_ = context?.Operators.RetrieveByValueSet<Patient>(null, null);
		var b_ = context?.Operators.SingletonFrom<Patient>(a_);

		return b_;
	}

    [CqlDeclaration("Patient")]
	public Patient Patient() => 
		__Patient?.Value;

	private bool? Has_Hospice_Value()
	{
		var a_ = this.Encounter_Inpatient();
		var b_ = context?.Operators.RetrieveByValueSet<Encounter>(a_, null);
		bool? c_(Encounter DischargeHospice)
		{
			var r_ = DischargeHospice.StatusElement;
			var s_ = FHIRHelpers_4_0_001.ToString(r_);
			var t_ = context?.Operators.Equal(s_, "finished");
			var u_ = DischargeHospice.Hospitalization;
			var v_ = u_.DischargeDisposition;
			var w_ = FHIRHelpers_4_0_001.ToConcept(v_);
			var x_ = this.Discharge_to_home_for_hospice_care__procedure_();
			var y_ = context?.Operators.ConvertCodeToConcept(x_);
			var z_ = context?.Operators.Equivalent(w_, y_);
			var ab_ = u_.DischargeDisposition;
			var ac_ = FHIRHelpers_4_0_001.ToConcept(ab_);
			var ad_ = this.Discharge_to_healthcare_facility_for_hospice_care__procedure_();
			var ae_ = context?.Operators.ConvertCodeToConcept(ad_);
			var af_ = context?.Operators.Equivalent(ac_, ae_);
			var ag_ = context?.Operators.Or(z_, af_);
			var ah_ = context?.Operators.And(t_, ag_);
			var ai_ = DischargeHospice.Period;
			var aj_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Normalize_Interval((ai_ as object));
			var ak_ = context?.Operators.End(aj_);
			var al_ = this.Measurement_Period();
			var am_ = context?.Operators.In<CqlDateTime>(ak_, al_, null);
			var an_ = context?.Operators.And(ah_, am_);

			return an_;
		};
		var d_ = context?.Operators.Where<Encounter>(b_, c_);
		var e_ = context?.Operators.Exists<Encounter>(d_);
		var f_ = this.Hospice_care_ambulatory();
		var g_ = context?.Operators.RetrieveByValueSet<ServiceRequest>(f_, null);
		bool? h_(ServiceRequest HospiceOrder)
		{
			var ao_ = HospiceOrder.StatusElement;
			var ap_ = FHIRHelpers_4_0_001.ToString(ao_);
			var aq_ = new string[]
			{
				"active",
				"completed",
			};
			var ar_ = context?.Operators.In<string>(ap_, (aq_ as IEnumerable<string>));
			var as_ = HospiceOrder.IntentElement;
			var at_ = FHIRHelpers_4_0_001.ToString(as_);
			var au_ = context?.Operators.Equal(at_, "order");
			var av_ = context?.Operators.And(ar_, au_);
			var aw_ = this.Measurement_Period();
			var ax_ = HospiceOrder.AuthoredOnElement;
			var ay_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Normalize_Interval((ax_ as object));
			var az_ = context?.Operators.IntervalIncludesInterval<CqlDateTime>(aw_, ay_, null);
			var ba_ = context?.Operators.And(av_, az_);

			return ba_;
		};
		var i_ = context?.Operators.Where<ServiceRequest>(g_, h_);
		var j_ = context?.Operators.Exists<ServiceRequest>(i_);
		var k_ = context?.Operators.Or(e_, j_);
		var m_ = context?.Operators.RetrieveByValueSet<Procedure>(f_, null);
		bool? n_(Procedure HospicePerformed)
		{
			var bb_ = HospicePerformed.StatusElement;
			var bc_ = FHIRHelpers_4_0_001.ToString(bb_);
			var bd_ = context?.Operators.Equal(bc_, "completed");
			var be_ = HospicePerformed.Performed;
			var bf_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Normalize_Interval(be_);
			var bg_ = this.Measurement_Period();
			var bh_ = context?.Operators.Overlaps(bf_, bg_, null);
			var bi_ = context?.Operators.And(bd_, bh_);

			return bi_;
		};
		var o_ = context?.Operators.Where<Procedure>(m_, n_);
		var p_ = context?.Operators.Exists<Procedure>(o_);
		var q_ = context?.Operators.Or(k_, p_);

		return q_;
	}

    [CqlDeclaration("Has Hospice")]
	public bool? Has_Hospice() => 
		__Has_Hospice?.Value;

}
