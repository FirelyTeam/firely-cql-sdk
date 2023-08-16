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

    private CqlValueSet Encounter_Inpatient_Value()
    {
        return new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.666.5.307", 
			null);
    }

    [CqlDeclaration("Encounter Inpatient")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.666.5.307")]
    public CqlValueSet Encounter_Inpatient() => __Encounter_Inpatient.Value;

    private CqlValueSet Hospice_care_ambulatory_Value()
    {
        return new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1108.15", 
			null);
    }

    [CqlDeclaration("Hospice care ambulatory")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1108.15")]
    public CqlValueSet Hospice_care_ambulatory() => __Hospice_care_ambulatory.Value;

    private CqlCode Discharge_to_healthcare_facility_for_hospice_care__procedure__Value()
    {
        return new CqlCode("428371000124100", 
			"http://snomed.info/sct", 
			null, 
			null);
    }

    [CqlDeclaration("Discharge to healthcare facility for hospice care (procedure)")]
    public CqlCode Discharge_to_healthcare_facility_for_hospice_care__procedure_() => __Discharge_to_healthcare_facility_for_hospice_care__procedure_.Value;

    private CqlCode Discharge_to_home_for_hospice_care__procedure__Value()
    {
        return new CqlCode("428361000124107", 
			"http://snomed.info/sct", 
			null, 
			null);
    }

    [CqlDeclaration("Discharge to home for hospice care (procedure)")]
    public CqlCode Discharge_to_home_for_hospice_care__procedure_() => __Discharge_to_home_for_hospice_care__procedure_.Value;

    private CqlCode[] SNOMEDCT_2017_09_Value()
	{
		var a_ = new CqlCode("428371000124100", 
			"http://snomed.info/sct", 
			null, 
			null);
		var b_ = new CqlCode("428361000124107", 
			"http://snomed.info/sct", 
			null, 
			null);
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
        return ((CqlInterval<CqlDateTime>)context.ResolveParameter("HospiceFHIR4-2.3.000", 
			"Measurement Period", 
			null));
    }

    [CqlDeclaration("Measurement Period")]
    public CqlInterval<CqlDateTime> Measurement_Period() => __Measurement_Period.Value;

    private Patient Patient_Value()
	{
		var a_ = context?.DataRetriever.RetrieveByValueSet<Patient>(null, 
			null);
		return context?.Operators.SingleOrNull<Patient>(a_);
	}

    [CqlDeclaration("Patient")]
    public Patient Patient() => __Patient.Value;

    private bool? Has_Hospice_Value()
	{
		var a_ = this.Encounter_Inpatient();
		var b_ = context?.DataRetriever.RetrieveByValueSet<Encounter>(a_, 
			null);
		Func<Encounter,bool?> x_ = (DischargeHospice) => 
		{
			var d_ = (DischargeHospice?.StatusElement as object);
			var c_ = ((context.Deeper(new CallStackEntry("ToString", 
		null, 
		null))?.Operators?.TypeConverter).Convert<string>(d_) as object);
			var e_ = ("finished" as object);
			var f_ = context?.Operators.Equal(c_, 
				e_);
			var h_ = DischargeHospice?.Hospitalization?.DischargeDisposition;
			var g_ = (FHIRHelpers_4_0_001.ToConcept(h_) as object);
			var j_ = this.Discharge_to_home_for_hospice_care__procedure_();
			var i_ = (context?.Operators.ConvertCodeToConcept(j_) as object);
			var k_ = context?.Operators.Equivalent(g_, 
				i_);
			var o_ = this.Discharge_to_healthcare_facility_for_hospice_care__procedure_();
			var n_ = (context?.Operators.ConvertCodeToConcept(o_) as object);
			var p_ = context?.Operators.Equivalent(g_, 
				n_);
			var q_ = context?.Operators.Or(k_, 
				p_);
			var r_ = context?.Operators.And(f_, 
				q_);
			var s_ = (DischargeHospice?.Period as object);
			var t_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Normalize_Interval(s_);
			var u_ = context?.Operators.End(t_);
			var v_ = this.Measurement_Period();
			var w_ = context?.Operators.ElementInInterval<CqlDateTime>(u_, 
				v_, 
				null);
			return context?.Operators.And(r_, 
				w_);
		};
		var y_ = context?.Operators.WhereOrNull<Encounter>(b_, 
			x_);
		var z_ = context?.Operators.ExistsInList<Encounter>(y_);
		var aa_ = this.Hospice_care_ambulatory();
		var ab_ = context?.DataRetriever.RetrieveByValueSet<ServiceRequest>(aa_, 
			null);
		Func<ServiceRequest,bool?> ar_ = (HospiceOrder) => 
		{
			var ac_ = (HospiceOrder?.StatusElement as object);
			var ad_ = (context.Deeper(new CallStackEntry("ToString", 
		null, 
		null))?.Operators?.TypeConverter).Convert<string>(ac_);
			var af_ = "active";
			var ag_ = "completed";
			var ae_ = (new string[]
			{
				af_,
				ag_,
			} as IEnumerable<string>);
			var ah_ = context?.Operators.InList<string>(ad_, 
				ae_);
			var aj_ = (HospiceOrder?.IntentElement as object);
			var ai_ = ((context.Deeper(new CallStackEntry("ToString", 
		null, 
		null))?.Operators?.TypeConverter).Convert<string>(aj_) as object);
			var ak_ = ("order" as object);
			var al_ = context?.Operators.Equal(ai_, 
				ak_);
			var am_ = context?.Operators.And(ah_, 
				al_);
			var an_ = this.Measurement_Period();
			var ao_ = (HospiceOrder?.AuthoredOnElement as object);
			var ap_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Normalize_Interval(ao_);
			var aq_ = context?.Operators.IntervalIncludesInterval<CqlDateTime>(an_, 
				ap_, 
				null);
			return context?.Operators.And(am_, 
				aq_);
		};
		var as_ = context?.Operators.WhereOrNull<ServiceRequest>(ab_, 
			ar_);
		var at_ = context?.Operators.ExistsInList<ServiceRequest>(as_);
		var au_ = context?.Operators.Or(z_, 
			at_);
		var aw_ = context?.DataRetriever.RetrieveByValueSet<Procedure>(aa_, 
			null);
		Func<Procedure,bool?> bf_ = (HospicePerformed) => 
		{
			var ay_ = (HospicePerformed?.StatusElement as object);
			var ax_ = ((context.Deeper(new CallStackEntry("ToString", 
		null, 
		null))?.Operators?.TypeConverter).Convert<string>(ay_) as object);
			var az_ = ("completed" as object);
			var ba_ = context?.Operators.Equal(ax_, 
				az_);
			var bb_ = (HospicePerformed?.Performed as object);
			var bc_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Normalize_Interval(bb_);
			var bd_ = this.Measurement_Period();
			var be_ = context?.Operators.Overlaps(bc_, 
				bd_, 
				null);
			return context?.Operators.And(ba_, 
				be_);
		};
		var bg_ = context?.Operators.WhereOrNull<Procedure>(aw_, 
			bf_);
		var bh_ = context?.Operators.ExistsInList<Procedure>(bg_);
		return context?.Operators.Or(au_, 
			bh_);
	}

    [CqlDeclaration("Has Hospice")]
    public bool? Has_Hospice() => __Has_Hospice.Value;

}