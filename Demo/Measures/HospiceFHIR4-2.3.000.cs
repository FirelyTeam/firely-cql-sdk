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
		var a_ = new CqlCode[]
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
		var a_ = context.ResolveParameter("HospiceFHIR4-2.3.000", "Measurement Period", null);

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

	private bool? Has_Hospice_Value()
	{
		var a_ = context.Operators;
		var e_ = context.DataRetriever;
		var f_ = this.Encounter_Inpatient();
		var g_ = e_.RetrieveByValueSet<Encounter>(f_, null);
		bool? h_(Encounter DischargeHospice)
		{
			var ac_ = context.Operators;
			var af_ = context.Deeper(new CallStackEntry("ToString", null, null));
			var ag_ = af_.Operators;
			var ah_ = ag_.TypeConverter;
			var ai_ = DischargeHospice?.StatusElement;
			var aj_ = ah_.Convert<string>(ai_);
			var ak_ = ac_.Equal(aj_, "finished");
			var an_ = DischargeHospice?.Hospitalization;
			var ao_ = an_?.DischargeDisposition;
			var ap_ = FHIRHelpers_4_0_001.ToConcept(ao_);
			var ar_ = this.Discharge_to_home_for_hospice_care__procedure_();
			var as_ = ac_.ConvertCodeToConcept(ar_);
			var at_ = ac_.Equivalent(ap_, as_);
			var aw_ = an_?.DischargeDisposition;
			var ax_ = FHIRHelpers_4_0_001.ToConcept(aw_);
			var az_ = this.Discharge_to_healthcare_facility_for_hospice_care__procedure_();
			var ba_ = ac_.ConvertCodeToConcept(az_);
			var bb_ = ac_.Equivalent(ax_, ba_);
			var bc_ = ac_.Or(at_, bb_);
			var bd_ = ac_.And(ak_, bc_);
			var bg_ = DischargeHospice?.Period;
			var bh_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Normalize_Interval(bg_);
			var bi_ = ac_.End(bh_);
			var bj_ = this.Measurement_Period();
			var bk_ = ac_.ElementInInterval<CqlDateTime>(bi_, bj_, null);
			var bl_ = ac_.And(bd_, bk_);

			return bl_;
		};
		var i_ = a_.WhereOrNull<Encounter>(g_, h_);
		var j_ = a_.ExistsInList<Encounter>(i_);
		var n_ = this.Hospice_care_ambulatory();
		var o_ = e_.RetrieveByValueSet<ServiceRequest>(n_, null);
		bool? p_(ServiceRequest HospiceOrder)
		{
			var bm_ = context.Operators;
			var bp_ = context.Deeper(new CallStackEntry("ToString", null, null));
			var bq_ = bp_.Operators;
			var br_ = bq_.TypeConverter;
			var bs_ = HospiceOrder?.StatusElement;
			var bt_ = br_.Convert<string>(bs_);
			var bu_ = new string[]
			{
				"active",
				"completed",
			};
			var bv_ = bm_.InList<string>(bt_, (bu_ as IEnumerable<string>));
			var by_ = bp_.Operators;
			var bz_ = by_.TypeConverter;
			var ca_ = HospiceOrder?.IntentElement;
			var cb_ = bz_.Convert<string>(ca_);
			var cc_ = bm_.Equal(cb_, "order");
			var cd_ = bm_.And(bv_, cc_);
			var cf_ = this.Measurement_Period();
			var cg_ = HospiceOrder?.AuthoredOnElement;
			var ch_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Normalize_Interval(cg_);
			var ci_ = bm_.IntervalIncludesInterval<CqlDateTime>(cf_, ch_, null);
			var cj_ = bm_.And(cd_, ci_);

			return cj_;
		};
		var q_ = a_.WhereOrNull<ServiceRequest>(o_, p_);
		var r_ = a_.ExistsInList<ServiceRequest>(q_);
		var s_ = a_.Or(j_, r_);
		var x_ = e_.RetrieveByValueSet<Procedure>(n_, null);
		bool? y_(Procedure HospicePerformed)
		{
			var ck_ = context.Operators;
			var cm_ = context.Deeper(new CallStackEntry("ToString", null, null));
			var cn_ = cm_.Operators;
			var co_ = cn_.TypeConverter;
			var cp_ = HospicePerformed?.StatusElement;
			var cq_ = co_.Convert<string>(cp_);
			var cr_ = ck_.Equal(cq_, "completed");
			var ct_ = HospicePerformed?.Performed;
			var cu_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Normalize_Interval(ct_);
			var cv_ = this.Measurement_Period();
			var cw_ = ck_.Overlaps(cu_, cv_, null);
			var cx_ = ck_.And(cr_, cw_);

			return cx_;
		};
		var z_ = a_.WhereOrNull<Procedure>(x_, y_);
		var aa_ = a_.ExistsInList<Procedure>(z_);
		var ab_ = a_.Or(s_, aa_);

		return ab_;
	}

    [CqlDeclaration("Has Hospice")]
	public bool? Has_Hospice() => 
		__Has_Hospice.Value;

}