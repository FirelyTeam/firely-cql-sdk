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
[System.CodeDom.Compiler.GeneratedCode(".NET Code Generation", "2.0.5.0")]
[CqlLibrary("HospiceFHIR4", "2.3.000")]
public partial class HospiceFHIR4_2_3_000 : ILibrary, ISingleton<HospiceFHIR4_2_3_000>
{
    private HospiceFHIR4_2_3_000() {}

    public static HospiceFHIR4_2_3_000 Instance { get; } = new();

    #region Library Members
    public string Name => "HospiceFHIR4";
    public string Version => "2.3.000";
    public ILibrary[] Dependencies => [MATGlobalCommonFunctionsFHIR4_6_1_000.Instance, FHIRHelpers_4_0_001.Instance];
    #endregion Library Members

    [CqlDeclaration("Encounter Inpatient")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.666.5.307")]
	public CqlValueSet Encounter_Inpatient	(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.666.5.307", default);


    [CqlDeclaration("Hospice care ambulatory")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1108.15")]
	public CqlValueSet Hospice_care_ambulatory	(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1108.15", default);


    [CqlDeclaration("Discharge to healthcare facility for hospice care (procedure)")]
	public CqlCode Discharge_to_healthcare_facility_for_hospice_care__procedure_	(CqlContext context) => 
		new CqlCode("428371000124100", "http://snomed.info/sct", default, default);


    [CqlDeclaration("Discharge to home for hospice care (procedure)")]
	public CqlCode Discharge_to_home_for_hospice_care__procedure_	(CqlContext context) => 
		new CqlCode("428361000124107", "http://snomed.info/sct", default, default);


    [CqlDeclaration("SNOMEDCT:2017-09")]
	public CqlCode[] SNOMEDCT_2017_09	(CqlContext context)
	{
		CqlCode[] a_ = [
			new CqlCode("428371000124100", "http://snomed.info/sct", default, default),
			new CqlCode("428361000124107", "http://snomed.info/sct", default, default),
		];

		return a_;
	}


    [CqlDeclaration("Measurement Period")]
	public CqlInterval<CqlDateTime> Measurement_Period	(CqlContext context)
	{
		object a_ = context.ResolveParameter("HospiceFHIR4-2.3.000", "Measurement Period", null);

		return (CqlInterval<CqlDateTime>)a_;
	}


    [CqlDeclaration("Patient")]
	public Patient Patient	(CqlContext context)
	{
		IEnumerable<Patient> a_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/StructureDefinition/Patient"));
		Patient b_ = context.Operators.SingletonFrom<Patient>(a_);

		return b_;
	}


    [CqlDeclaration("Has Hospice")]
	public bool? Has_Hospice	(CqlContext context)
	{
		CqlValueSet a_ = this.Encounter_Inpatient(context);
		IEnumerable<Encounter> b_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/StructureDefinition/Encounter"));
		bool? c_		(Encounter DischargeHospice)
		{
			Code<Encounter.EncounterStatus> r_ = DischargeHospice?.StatusElement;
			string s_ = FHIRHelpers_4_0_001.Instance.ToString(context, r_);
			bool? t_ = context.Operators.Equal(s_, "finished");
			Encounter.HospitalizationComponent u_ = DischargeHospice?.Hospitalization;
			CodeableConcept v_ = u_?.DischargeDisposition;
			CqlConcept w_ = FHIRHelpers_4_0_001.Instance.ToConcept(context, v_);
			CqlCode x_ = this.Discharge_to_home_for_hospice_care__procedure_(context);
			CqlConcept y_ = context.Operators.ConvertCodeToConcept(x_);
			bool? z_ = context.Operators.Equivalent(w_, y_);
			CodeableConcept ab_ = u_?.DischargeDisposition;
			CqlConcept ac_ = FHIRHelpers_4_0_001.Instance.ToConcept(context, ab_);
			CqlCode ad_ = this.Discharge_to_healthcare_facility_for_hospice_care__procedure_(context);
			CqlConcept ae_ = context.Operators.ConvertCodeToConcept(ad_);
			bool? af_ = context.Operators.Equivalent(ac_, ae_);
			bool? ag_ = context.Operators.Or(z_, af_);
			bool? ah_ = context.Operators.And(t_, ag_);
			Period ai_ = DischargeHospice?.Period;
			CqlInterval<CqlDateTime> aj_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, ai_ as object);
			CqlDateTime ak_ = context.Operators.End(aj_);
			CqlInterval<CqlDateTime> al_ = this.Measurement_Period(context);
			bool? am_ = context.Operators.In<CqlDateTime>(ak_, al_, default);
			bool? an_ = context.Operators.And(ah_, am_);

			return an_;
		};
		IEnumerable<Encounter> d_ = context.Operators.Where<Encounter>(b_, c_);
		bool? e_ = context.Operators.Exists<Encounter>(d_);
		CqlValueSet f_ = this.Hospice_care_ambulatory(context);
		IEnumerable<ServiceRequest> g_ = context.Operators.Retrieve<ServiceRequest>(new RetrieveParameters(default, f_, default, "http://hl7.org/fhir/StructureDefinition/ServiceRequest"));
		bool? h_		(ServiceRequest HospiceOrder)
		{
			Code<RequestStatus> ao_ = HospiceOrder?.StatusElement;
			string ap_ = FHIRHelpers_4_0_001.Instance.ToString(context, ao_);
			string[] aq_ = [
				"active",
				"completed",
			];
			bool? ar_ = context.Operators.In<string>(ap_, aq_ as IEnumerable<string>);
			Code<RequestIntent> as_ = HospiceOrder?.IntentElement;
			string at_ = FHIRHelpers_4_0_001.Instance.ToString(context, as_);
			bool? au_ = context.Operators.Equal(at_, "order");
			bool? av_ = context.Operators.And(ar_, au_);
			CqlInterval<CqlDateTime> aw_ = this.Measurement_Period(context);
			FhirDateTime ax_ = HospiceOrder?.AuthoredOnElement;
			CqlInterval<CqlDateTime> ay_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, ax_ as object);
			bool? az_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(aw_, ay_, default);
			bool? ba_ = context.Operators.And(av_, az_);

			return ba_;
		};
		IEnumerable<ServiceRequest> i_ = context.Operators.Where<ServiceRequest>(g_, h_);
		bool? j_ = context.Operators.Exists<ServiceRequest>(i_);
		bool? k_ = context.Operators.Or(e_, j_);
		IEnumerable<Procedure> m_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, f_, default, "http://hl7.org/fhir/StructureDefinition/Procedure"));
		bool? n_		(Procedure HospicePerformed)
		{
			Code<EventStatus> bb_ = HospicePerformed?.StatusElement;
			string bc_ = FHIRHelpers_4_0_001.Instance.ToString(context, bb_);
			bool? bd_ = context.Operators.Equal(bc_, "completed");
			DataType be_ = HospicePerformed?.Performed;
			CqlInterval<CqlDateTime> bf_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, be_);
			CqlInterval<CqlDateTime> bg_ = this.Measurement_Period(context);
			bool? bh_ = context.Operators.Overlaps(bf_, bg_, default);
			bool? bi_ = context.Operators.And(bd_, bh_);

			return bi_;
		};
		IEnumerable<Procedure> o_ = context.Operators.Where<Procedure>(m_, n_);
		bool? p_ = context.Operators.Exists<Procedure>(o_);
		bool? q_ = context.Operators.Or(k_, p_);

		return q_;
	}

}
