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

    private CqlCode Discharge_to_healthcare_facility_for_hospice_care__procedure__Value()
	{
		var a_ = new CqlCode("428371000124100", "http://snomed.info/sct", null, null);

		return a_;
	}

    [CqlDeclaration("Discharge to healthcare facility for hospice care (procedure)")]
    public CqlCode Discharge_to_healthcare_facility_for_hospice_care__procedure_() => __Discharge_to_healthcare_facility_for_hospice_care__procedure_.Value;

    private CqlCode Discharge_to_home_for_hospice_care__procedure__Value()
	{
		var a_ = new CqlCode("428361000124107", "http://snomed.info/sct", null, null);

		return a_;
	}

    [CqlDeclaration("Discharge to home for hospice care (procedure)")]
    public CqlCode Discharge_to_home_for_hospice_care__procedure_() => __Discharge_to_home_for_hospice_care__procedure_.Value;

    private CqlCode[] SNOMEDCT_2017_09_Value()
	{
		var a_ = new CqlCode("428371000124100", "http://snomed.info/sct", null, null);
		var b_ = new CqlCode("428361000124107", "http://snomed.info/sct", null, null);
		var c_ = new CqlCode[]
		{
			a_,
			b_,
		};

		return c_;
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
		var a_ = context.DataRetriever;
		var b_ = a_.RetrieveByValueSet<Patient>(null, null);
		var c_ = context.Operators;
		var d_ = c_.SingleOrNull<Patient>(b_);

		return d_;
	}

    [CqlDeclaration("Patient")]
    public Patient Patient() => __Patient.Value;

    private bool? Has_Hospice_Value()
	{
		var a_ = this.Encounter_Inpatient();
		var b_ = context.DataRetriever;
		var c_ = b_.RetrieveByValueSet<Encounter>(a_, null);
		bool? d_(Encounter DischargeHospice)
		{
			var ac_ = DischargeHospice.StatusElement;
			var ad_ = new CallStackEntry("ToString", null, null);
			var ae_ = context.Deeper(ad_);
			var af_ = ae_.Operators;
			var ag_ = af_.TypeConverter;
			var ah_ = ag_.Convert<string>(ac_);
			var ai_ = context.Operators;
			var aj_ = ai_.Equal(ah_, "finished");
			var ak_ = DischargeHospice.Hospitalization;
			var al_ = ak_.DischargeDisposition;
			var am_ = FHIRHelpers_4_0_001.ToConcept(al_);
			var an_ = this.Discharge_to_home_for_hospice_care__procedure_();
			var ap_ = ai_.ConvertCodeToConcept(an_);
			var ar_ = ai_.Equivalent(am_, ap_);
			var at_ = ak_.DischargeDisposition;
			var au_ = FHIRHelpers_4_0_001.ToConcept(at_);
			var av_ = this.Discharge_to_healthcare_facility_for_hospice_care__procedure_();
			var ax_ = ai_.ConvertCodeToConcept(av_);
			var az_ = ai_.Equivalent(au_, ax_);
			var bb_ = ai_.Or(ar_, az_);
			var bd_ = ai_.And(aj_, bb_);
			var be_ = DischargeHospice.Period;
			var bf_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Normalize_Interval(be_);
			var bh_ = ai_.End(bf_);
			var bi_ = this.Measurement_Period();
			var bk_ = ai_.ElementInInterval<CqlDateTime>(bh_, bi_, null);
			var bm_ = ai_.And(bd_, bk_);

			return bm_;
		};
		var e_ = context.Operators;
		var f_ = e_.WhereOrNull<Encounter>(c_, d_);
		var h_ = e_.ExistsInList<Encounter>(f_);
		var i_ = this.Hospice_care_ambulatory();
		var k_ = b_.RetrieveByValueSet<ServiceRequest>(i_, null);
		bool? l_(ServiceRequest HospiceOrder)
		{
			var bn_ = HospiceOrder.StatusElement;
			var bo_ = new CallStackEntry("ToString", null, null);
			var bp_ = context.Deeper(bo_);
			var bq_ = bp_.Operators;
			var br_ = bq_.TypeConverter;
			var bs_ = br_.Convert<string>(bn_);
			var bt_ = new string[]
			{
				"active",
				"completed",
			};
			var bu_ = context.Operators;
			var bv_ = bu_.InList<string>(bs_, (bt_ as IEnumerable<string>));
			var bw_ = HospiceOrder.IntentElement;
			var by_ = context.Deeper(bo_);
			var bz_ = by_.Operators;
			var ca_ = bz_.TypeConverter;
			var cb_ = ca_.Convert<string>(bw_);
			var cd_ = bu_.Equal(cb_, "order");
			var cf_ = bu_.And(bv_, cd_);
			var cg_ = this.Measurement_Period();
			var ch_ = HospiceOrder.AuthoredOnElement;
			var ci_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Normalize_Interval(ch_);
			var ck_ = bu_.IntervalIncludesInterval<CqlDateTime>(cg_, ci_, null);
			var cm_ = bu_.And(cf_, ck_);

			return cm_;
		};
		var n_ = e_.WhereOrNull<ServiceRequest>(k_, l_);
		var p_ = e_.ExistsInList<ServiceRequest>(n_);
		var r_ = e_.Or(h_, p_);
		var u_ = b_.RetrieveByValueSet<Procedure>(i_, null);
		bool? v_(Procedure HospicePerformed)
		{
			var cn_ = HospicePerformed.StatusElement;
			var co_ = new CallStackEntry("ToString", null, null);
			var cp_ = context.Deeper(co_);
			var cq_ = cp_.Operators;
			var cr_ = cq_.TypeConverter;
			var cs_ = cr_.Convert<string>(cn_);
			var ct_ = context.Operators;
			var cu_ = ct_.Equal(cs_, "completed");
			var cv_ = HospicePerformed.Performed;
			var cw_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Normalize_Interval(cv_);
			var cx_ = this.Measurement_Period();
			var cz_ = ct_.Overlaps(cw_, cx_, null);
			var db_ = ct_.And(cu_, cz_);

			return db_;
		};
		var x_ = e_.WhereOrNull<Procedure>(u_, v_);
		var z_ = e_.ExistsInList<Procedure>(x_);
		var ab_ = e_.Or(r_, z_);

		return ab_;
	}

    [CqlDeclaration("Has Hospice")]
    public bool? Has_Hospice() => __Has_Hospice.Value;

}