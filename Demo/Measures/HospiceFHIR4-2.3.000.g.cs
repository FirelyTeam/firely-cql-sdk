using System;
using Tuples;
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
		__Encounter_Inpatient.Value;

	private CqlValueSet Hospice_care_ambulatory_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1108.15", null);

    [CqlDeclaration("Hospice care ambulatory")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1108.15")]
	public CqlValueSet Hospice_care_ambulatory() => 
		__Hospice_care_ambulatory.Value;

	private CqlCode Discharge_to_healthcare_facility_for_hospice_care__procedure__Value() => 
		new CqlCode("428371000124100", "http://snomed.info/sct", null, null);

    [CqlDeclaration("Discharge to healthcare facility for hospice care (procedure)")]
	public CqlCode Discharge_to_healthcare_facility_for_hospice_care__procedure_() => 
		__Discharge_to_healthcare_facility_for_hospice_care__procedure_.Value;

	private CqlCode Discharge_to_home_for_hospice_care__procedure__Value() => 
		new CqlCode("428361000124107", "http://snomed.info/sct", null, null);

    [CqlDeclaration("Discharge to home for hospice care (procedure)")]
	public CqlCode Discharge_to_home_for_hospice_care__procedure_() => 
		__Discharge_to_home_for_hospice_care__procedure_.Value;

	private CqlCode[] SNOMEDCT_2017_09_Value()
	{
		CqlCode[] a_ = new CqlCode[]
		{
			new CqlCode("428371000124100", "http://snomed.info/sct", null, null),
			new CqlCode("428361000124107", "http://snomed.info/sct", null, null),
		};

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
		IEnumerable<Patient> a_ = context.Operators.RetrieveByValueSet<Patient>(null, null);
		Patient b_ = context.Operators.SingletonFrom<Patient>(a_);

		return b_;
	}

    [CqlDeclaration("Patient")]
	public Patient Patient() => 
		__Patient.Value;

	private bool? Has_Hospice_Value()
	{
		CqlValueSet a_ = this.Encounter_Inpatient();
		IEnumerable<Encounter> b_ = context.Operators.RetrieveByValueSet<Encounter>(a_, null);
		bool? c_(Encounter DischargeHospice)
		{
			string r_ = context.Operators.Convert<string>(DischargeHospice?.StatusElement);
			bool? s_ = context.Operators.Equal(r_, "finished");
			CqlConcept t_ = FHIRHelpers_4_0_001.ToConcept(DischargeHospice?.Hospitalization?.DischargeDisposition);
			CqlCode u_ = this.Discharge_to_home_for_hospice_care__procedure_();
			CqlConcept v_ = context.Operators.ConvertCodeToConcept(u_);
			bool? w_ = context.Operators.Equivalent(t_, v_);
			CqlCode y_ = this.Discharge_to_healthcare_facility_for_hospice_care__procedure_();
			CqlConcept z_ = context.Operators.ConvertCodeToConcept(y_);
			bool? aa_ = context.Operators.Equivalent(t_, z_);
			bool? ab_ = context.Operators.Or(w_, aa_);
			bool? ac_ = context.Operators.And(s_, ab_);
			CqlInterval<CqlDateTime> ad_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Normalize_Interval((DischargeHospice?.Period as object));
			CqlDateTime ae_ = context.Operators.End(ad_);
			CqlInterval<CqlDateTime> af_ = this.Measurement_Period();
			bool? ag_ = context.Operators.In<CqlDateTime>(ae_, af_, null);
			bool? ah_ = context.Operators.And(ac_, ag_);

			return ah_;
		};
		IEnumerable<Encounter> d_ = context.Operators.Where<Encounter>(b_, c_);
		bool? e_ = context.Operators.Exists<Encounter>(d_);
		CqlValueSet f_ = this.Hospice_care_ambulatory();
		IEnumerable<ServiceRequest> g_ = context.Operators.RetrieveByValueSet<ServiceRequest>(f_, null);
		bool? h_(ServiceRequest HospiceOrder)
		{
			string ai_ = context.Operators.Convert<string>(HospiceOrder?.StatusElement);
			string[] aj_ = new string[]
			{
				"active",
				"completed",
			};
			bool? ak_ = context.Operators.In<string>(ai_, (aj_ as IEnumerable<string>));
			string al_ = context.Operators.Convert<string>(HospiceOrder?.IntentElement);
			bool? am_ = context.Operators.Equal(al_, "order");
			bool? an_ = context.Operators.And(ak_, am_);
			CqlInterval<CqlDateTime> ao_ = this.Measurement_Period();
			CqlInterval<CqlDateTime> ap_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Normalize_Interval((HospiceOrder?.AuthoredOnElement as object));
			bool? aq_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(ao_, ap_, null);
			bool? ar_ = context.Operators.And(an_, aq_);

			return ar_;
		};
		IEnumerable<ServiceRequest> i_ = context.Operators.Where<ServiceRequest>(g_, h_);
		bool? j_ = context.Operators.Exists<ServiceRequest>(i_);
		bool? k_ = context.Operators.Or(e_, j_);
		IEnumerable<Procedure> m_ = context.Operators.RetrieveByValueSet<Procedure>(f_, null);
		bool? n_(Procedure HospicePerformed)
		{
			string as_ = context.Operators.Convert<string>(HospicePerformed?.StatusElement);
			bool? at_ = context.Operators.Equal(as_, "completed");
			CqlInterval<CqlDateTime> au_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Normalize_Interval(HospicePerformed?.Performed);
			CqlInterval<CqlDateTime> av_ = this.Measurement_Period();
			bool? aw_ = context.Operators.Overlaps(au_, av_, null);
			bool? ax_ = context.Operators.And(at_, aw_);

			return ax_;
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
