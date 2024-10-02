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
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.666.5.307", default);

    [CqlDeclaration("Encounter Inpatient")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.666.5.307")]
	public CqlValueSet Encounter_Inpatient() => 
		__Encounter_Inpatient.Value;

	private CqlValueSet Hospice_care_ambulatory_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1108.15", default);

    [CqlDeclaration("Hospice care ambulatory")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1108.15")]
	public CqlValueSet Hospice_care_ambulatory() => 
		__Hospice_care_ambulatory.Value;

	private CqlCode Discharge_to_healthcare_facility_for_hospice_care__procedure__Value() => 
		new CqlCode("428371000124100", "http://snomed.info/sct", default, default);

    [CqlDeclaration("Discharge to healthcare facility for hospice care (procedure)")]
	public CqlCode Discharge_to_healthcare_facility_for_hospice_care__procedure_() => 
		__Discharge_to_healthcare_facility_for_hospice_care__procedure_.Value;

	private CqlCode Discharge_to_home_for_hospice_care__procedure__Value() => 
		new CqlCode("428361000124107", "http://snomed.info/sct", default, default);

    [CqlDeclaration("Discharge to home for hospice care (procedure)")]
	public CqlCode Discharge_to_home_for_hospice_care__procedure_() => 
		__Discharge_to_home_for_hospice_care__procedure_.Value;

	private CqlCode[] SNOMEDCT_2017_09_Value()
	{
		CqlCode[] a_ = [
			new CqlCode("428371000124100", "http://snomed.info/sct", default, default),
			new CqlCode("428361000124107", "http://snomed.info/sct", default, default),
		];

		return a_;
	}

    [CqlDeclaration("SNOMEDCT:2017-09")]
	public CqlCode[] SNOMEDCT_2017_09() => 
		__SNOMEDCT_2017_09.Value;

	private CqlInterval<CqlDateTime> Measurement_Period_Value()
	{
		object a_ = context.ResolveParameter("HospiceFHIR4-2.3.000", "Measurement Period", null);

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

	private bool? Has_Hospice_Value()
	{
		CqlValueSet a_ = this.Encounter_Inpatient();
		IEnumerable<Encounter> b_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/StructureDefinition/Encounter"));
		bool? c_(Encounter DischargeHospice)
		{
			Code<Encounter.EncounterStatus> r_ = DischargeHospice?.StatusElement;
			string s_ = FHIRHelpers_4_0_001.ToString(r_);
			bool? t_ = context.Operators.Equal(s_, "finished");
			Encounter.HospitalizationComponent u_ = DischargeHospice?.Hospitalization;
			CodeableConcept v_ = u_?.DischargeDisposition;
			CqlConcept w_ = FHIRHelpers_4_0_001.ToConcept(v_);
			CqlCode x_ = this.Discharge_to_home_for_hospice_care__procedure_();
			CqlConcept y_ = context.Operators.ConvertCodeToConcept(x_);
			bool? z_ = context.Operators.Equivalent(w_, y_);
			CodeableConcept ab_ = u_?.DischargeDisposition;
			CqlConcept ac_ = FHIRHelpers_4_0_001.ToConcept(ab_);
			CqlCode ad_ = this.Discharge_to_healthcare_facility_for_hospice_care__procedure_();
			CqlConcept ae_ = context.Operators.ConvertCodeToConcept(ad_);
			bool? af_ = context.Operators.Equivalent(ac_, ae_);
			bool? ag_ = context.Operators.Or(z_, af_);
			bool? ah_ = context.Operators.And(t_, ag_);
			Period ai_ = DischargeHospice?.Period;
			CqlInterval<CqlDateTime> aj_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Normalize_Interval(ai_ as object);
			CqlDateTime ak_ = context.Operators.End(aj_);
			CqlInterval<CqlDateTime> al_ = this.Measurement_Period();
			bool? am_ = context.Operators.In<CqlDateTime>(ak_, al_, default);
			bool? an_ = context.Operators.And(ah_, am_);

			return an_;
		};
		IEnumerable<Encounter> d_ = context.Operators.Where<Encounter>(b_, c_);
		bool? e_ = context.Operators.Exists<Encounter>(d_);
		CqlValueSet f_ = this.Hospice_care_ambulatory();
		IEnumerable<ServiceRequest> g_ = context.Operators.Retrieve<ServiceRequest>(new RetrieveParameters(default, f_, default, "http://hl7.org/fhir/StructureDefinition/ServiceRequest"));
		bool? h_(ServiceRequest HospiceOrder)
		{
			Code<RequestStatus> ao_ = HospiceOrder?.StatusElement;
			string ap_ = FHIRHelpers_4_0_001.ToString(ao_);
			string[] aq_ = [
				"active",
				"completed",
			];
			bool? ar_ = context.Operators.In<string>(ap_, aq_ as IEnumerable<string>);
			Code<RequestIntent> as_ = HospiceOrder?.IntentElement;
			string at_ = FHIRHelpers_4_0_001.ToString(as_);
			bool? au_ = context.Operators.Equal(at_, "order");
			bool? av_ = context.Operators.And(ar_, au_);
			CqlInterval<CqlDateTime> aw_ = this.Measurement_Period();
			FhirDateTime ax_ = HospiceOrder?.AuthoredOnElement;
			CqlInterval<CqlDateTime> ay_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Normalize_Interval(ax_ as object);
			bool? az_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(aw_, ay_, default);
			bool? ba_ = context.Operators.And(av_, az_);

			return ba_;
		};
		IEnumerable<ServiceRequest> i_ = context.Operators.Where<ServiceRequest>(g_, h_);
		bool? j_ = context.Operators.Exists<ServiceRequest>(i_);
		bool? k_ = context.Operators.Or(e_, j_);
		IEnumerable<Procedure> m_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, f_, default, "http://hl7.org/fhir/StructureDefinition/Procedure"));
		bool? n_(Procedure HospicePerformed)
		{
			Code<EventStatus> bb_ = HospicePerformed?.StatusElement;
			string bc_ = FHIRHelpers_4_0_001.ToString(bb_);
			bool? bd_ = context.Operators.Equal(bc_, "completed");
			DataType be_ = HospicePerformed?.Performed;
			CqlInterval<CqlDateTime> bf_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Normalize_Interval(be_);
			CqlInterval<CqlDateTime> bg_ = this.Measurement_Period();
			bool? bh_ = context.Operators.Overlaps(bf_, bg_, default);
			bool? bi_ = context.Operators.And(bd_, bh_);

			return bi_;
		};
		IEnumerable<Procedure> o_ = context.Operators.Where<Procedure>(m_, n_);
		bool? p_ = context.Operators.Exists<Procedure>(o_);
		bool? q_ = context.Operators.Or(k_, p_);

		return q_;
	}

    [CqlDeclaration("Has Hospice")]
	public bool? Has_Hospice() => 
		__Has_Hospice.Value;

}
