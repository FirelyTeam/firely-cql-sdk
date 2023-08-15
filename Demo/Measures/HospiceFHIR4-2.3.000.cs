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
        var b_ = typeof(Encounter).GetProperty("Type");
        var c_ = context?.DataRetriever.RetrieveByValueSet<Encounter>(a_, 
			b_);
        Func<Encounter,bool?> y_ = (DischargeHospice) => 
        {
            var e_ = (DischargeHospice?.StatusElement as object);
            var d_ = ((context.Deeper(new CallStackEntry("ToString", 
		null, 
		null))?.Operators?.TypeConverter).Convert<string>(e_) as object);
            var f_ = ("finished" as object);
            var g_ = context?.Operators.Equal(d_, 
				f_);
            var i_ = DischargeHospice?.Hospitalization?.DischargeDisposition;
            var h_ = (FHIRHelpers_4_0_001.ToConcept(i_) as object);
            var k_ = this.Discharge_to_home_for_hospice_care__procedure_();
            var j_ = (context?.Operators.ConvertCodeToConcept(k_) as object);
            var l_ = context?.Operators.Equivalent(h_, 
				j_);
            var p_ = this.Discharge_to_healthcare_facility_for_hospice_care__procedure_();
            var o_ = (context?.Operators.ConvertCodeToConcept(p_) as object);
            var q_ = context?.Operators.Equivalent(h_, 
				o_);
            var r_ = context?.Operators.Or(l_, 
				q_);
            var s_ = context?.Operators.And(g_, 
				r_);
            var t_ = (DischargeHospice?.Period as object);
            var u_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Normalize_Interval(t_);
            var v_ = context?.Operators.End(u_);
            var w_ = this.Measurement_Period();
            var x_ = context?.Operators.ElementInInterval<CqlDateTime>(v_, 
				w_, 
				null);
            return context?.Operators.And(s_, 
				x_);
        };
        var z_ = context?.Operators.WhereOrNull<Encounter>(c_, 
			y_);
        var aa_ = context?.Operators.ExistsInList<Encounter>(z_);
        var ab_ = this.Hospice_care_ambulatory();
        var ac_ = typeof(ServiceRequest).GetProperty("Code");
        var ad_ = context?.DataRetriever.RetrieveByValueSet<ServiceRequest>(ab_, 
			ac_);
        Func<ServiceRequest,bool?> at_ = (HospiceOrder) => 
        {
            var ae_ = (HospiceOrder?.StatusElement as object);
            var af_ = (context.Deeper(new CallStackEntry("ToString", 
		null, 
		null))?.Operators?.TypeConverter).Convert<string>(ae_);
            var ah_ = "active";
            var ai_ = "completed";
            var ag_ = (new string[]
			{
				ah_,
				ai_,
			} as IEnumerable<string>);
            var aj_ = context?.Operators.InList<string>(af_, 
				ag_);
            var al_ = (HospiceOrder?.IntentElement as object);
            var ak_ = ((context.Deeper(new CallStackEntry("ToString", 
		null, 
		null))?.Operators?.TypeConverter).Convert<string>(al_) as object);
            var am_ = ("order" as object);
            var an_ = context?.Operators.Equal(ak_, 
				am_);
            var ao_ = context?.Operators.And(aj_, 
				an_);
            var ap_ = this.Measurement_Period();
            var aq_ = (HospiceOrder?.AuthoredOnElement as object);
            var ar_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Normalize_Interval(aq_);
            var as_ = context?.Operators.IntervalIncludesInterval<CqlDateTime>(ap_, 
				ar_, 
				null);
            return context?.Operators.And(ao_, 
				as_);
        };
        var au_ = context?.Operators.WhereOrNull<ServiceRequest>(ad_, 
			at_);
        var av_ = context?.Operators.ExistsInList<ServiceRequest>(au_);
        var aw_ = context?.Operators.Or(aa_, 
			av_);
        var ay_ = typeof(Procedure).GetProperty("Code");
        var az_ = context?.DataRetriever.RetrieveByValueSet<Procedure>(ab_, 
			ay_);
        Func<Procedure,bool?> bi_ = (HospicePerformed) => 
        {
            var bb_ = (HospicePerformed?.StatusElement as object);
            var ba_ = ((context.Deeper(new CallStackEntry("ToString", 
		null, 
		null))?.Operators?.TypeConverter).Convert<string>(bb_) as object);
            var bc_ = ("completed" as object);
            var bd_ = context?.Operators.Equal(ba_, 
				bc_);
            var be_ = (HospicePerformed?.Performed as object);
            var bf_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Normalize_Interval(be_);
            var bg_ = this.Measurement_Period();
            var bh_ = context?.Operators.Overlaps(bf_, 
				bg_, 
				null);
            return context?.Operators.And(bd_, 
				bh_);
        };
        var bj_ = context?.Operators.WhereOrNull<Procedure>(az_, 
			bi_);
        var bk_ = context?.Operators.ExistsInList<Procedure>(bj_);
        return context?.Operators.Or(aw_, 
			bk_);
    }
    [CqlDeclaration("Has Hospice")]
    public bool? Has_Hospice() => __Has_Hospice.Value;

}