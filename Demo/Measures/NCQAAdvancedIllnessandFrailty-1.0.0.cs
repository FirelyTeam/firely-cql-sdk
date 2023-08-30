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
[CqlLibrary("NCQAAdvancedIllnessandFrailty", "1.0.0")]
public class NCQAAdvancedIllnessandFrailty_1_0_0
{


    internal CqlContext context;

    #region Cached values

    internal Lazy<CqlValueSet> __Acute_Inpatient;
    internal Lazy<CqlValueSet> __Advanced_Illness;
    internal Lazy<CqlValueSet> __Dementia_Medications;
    internal Lazy<CqlValueSet> __ED;
    internal Lazy<CqlValueSet> __Frailty_Device;
    internal Lazy<CqlValueSet> __Frailty_Diagnosis;
    internal Lazy<CqlValueSet> __Frailty_Encounter;
    internal Lazy<CqlValueSet> __Frailty_Symptom;
    internal Lazy<CqlValueSet> __Nonacute_Inpatient;
    internal Lazy<CqlValueSet> __Observation;
    internal Lazy<CqlValueSet> __Online_Assessments;
    internal Lazy<CqlValueSet> __Outpatient;
    internal Lazy<CqlValueSet> __Telephone_Visits;
    internal Lazy<CqlInterval<CqlDateTime>> __Measurement_Period;
    internal Lazy<Patient> __Patient;
    internal Lazy<bool?> __Has_Criteria_Indicating_Frailty;
    internal Lazy<IEnumerable<CqlDate>> __Outpatient_Encounters_with_Advanced_Illness;
    internal Lazy<IEnumerable<CqlDate>> __Nonacute_Inpatient_Discharge_with_Advanced_Illness;
    internal Lazy<IEnumerable<CqlDate>> __Outpatient_Encounters_or_Discharges_with_Advanced_Illness;
    internal Lazy<bool?> __Two_Outpatient_Visits_with_Advanced_Illness_on_Different_Dates_of_Service;
    internal Lazy<bool?> __Acute_Inpatient_Encounter_with_Advanced_Illness;
    internal Lazy<bool?> __Acute_Inpatient_Discharge_with_Advanced_Illness;
    internal Lazy<bool?> __Dementia_Medications_In_Year_Before_or_During_Measurement_Period;
    internal Lazy<bool?> __Advanced_Illness_and_Frailty_Exclusion_Including_Over_Age_80;
    internal Lazy<bool?> __Advanced_Illness_and_Frailty_Exclusion_Not_Including_Over_Age_80;

    #endregion
    public NCQAAdvancedIllnessandFrailty_1_0_0(CqlContext context)
    {
        this.context = context ?? throw new ArgumentNullException("context");

        FHIRHelpers_4_0_001 = new FHIRHelpers_4_0_001(context);
        NCQAFHIRBase_1_0_0 = new NCQAFHIRBase_1_0_0(context);
        NCQAStatus_1_0_0 = new NCQAStatus_1_0_0(context);
        NCQAEncounter_1_0_0 = new NCQAEncounter_1_0_0(context);
        NCQAClaims_1_0_0 = new NCQAClaims_1_0_0(context);

        __Acute_Inpatient = new Lazy<CqlValueSet>(this.Acute_Inpatient_Value);
        __Advanced_Illness = new Lazy<CqlValueSet>(this.Advanced_Illness_Value);
        __Dementia_Medications = new Lazy<CqlValueSet>(this.Dementia_Medications_Value);
        __ED = new Lazy<CqlValueSet>(this.ED_Value);
        __Frailty_Device = new Lazy<CqlValueSet>(this.Frailty_Device_Value);
        __Frailty_Diagnosis = new Lazy<CqlValueSet>(this.Frailty_Diagnosis_Value);
        __Frailty_Encounter = new Lazy<CqlValueSet>(this.Frailty_Encounter_Value);
        __Frailty_Symptom = new Lazy<CqlValueSet>(this.Frailty_Symptom_Value);
        __Nonacute_Inpatient = new Lazy<CqlValueSet>(this.Nonacute_Inpatient_Value);
        __Observation = new Lazy<CqlValueSet>(this.Observation_Value);
        __Online_Assessments = new Lazy<CqlValueSet>(this.Online_Assessments_Value);
        __Outpatient = new Lazy<CqlValueSet>(this.Outpatient_Value);
        __Telephone_Visits = new Lazy<CqlValueSet>(this.Telephone_Visits_Value);
        __Measurement_Period = new Lazy<CqlInterval<CqlDateTime>>(this.Measurement_Period_Value);
        __Patient = new Lazy<Patient>(this.Patient_Value);
        __Has_Criteria_Indicating_Frailty = new Lazy<bool?>(this.Has_Criteria_Indicating_Frailty_Value);
        __Outpatient_Encounters_with_Advanced_Illness = new Lazy<IEnumerable<CqlDate>>(this.Outpatient_Encounters_with_Advanced_Illness_Value);
        __Nonacute_Inpatient_Discharge_with_Advanced_Illness = new Lazy<IEnumerable<CqlDate>>(this.Nonacute_Inpatient_Discharge_with_Advanced_Illness_Value);
        __Outpatient_Encounters_or_Discharges_with_Advanced_Illness = new Lazy<IEnumerable<CqlDate>>(this.Outpatient_Encounters_or_Discharges_with_Advanced_Illness_Value);
        __Two_Outpatient_Visits_with_Advanced_Illness_on_Different_Dates_of_Service = new Lazy<bool?>(this.Two_Outpatient_Visits_with_Advanced_Illness_on_Different_Dates_of_Service_Value);
        __Acute_Inpatient_Encounter_with_Advanced_Illness = new Lazy<bool?>(this.Acute_Inpatient_Encounter_with_Advanced_Illness_Value);
        __Acute_Inpatient_Discharge_with_Advanced_Illness = new Lazy<bool?>(this.Acute_Inpatient_Discharge_with_Advanced_Illness_Value);
        __Dementia_Medications_In_Year_Before_or_During_Measurement_Period = new Lazy<bool?>(this.Dementia_Medications_In_Year_Before_or_During_Measurement_Period_Value);
        __Advanced_Illness_and_Frailty_Exclusion_Including_Over_Age_80 = new Lazy<bool?>(this.Advanced_Illness_and_Frailty_Exclusion_Including_Over_Age_80_Value);
        __Advanced_Illness_and_Frailty_Exclusion_Not_Including_Over_Age_80 = new Lazy<bool?>(this.Advanced_Illness_and_Frailty_Exclusion_Not_Including_Over_Age_80_Value);
    }
    #region Dependencies

    public FHIRHelpers_4_0_001 FHIRHelpers_4_0_001 { get; }
    public NCQAFHIRBase_1_0_0 NCQAFHIRBase_1_0_0 { get; }
    public NCQAStatus_1_0_0 NCQAStatus_1_0_0 { get; }
    public NCQAEncounter_1_0_0 NCQAEncounter_1_0_0 { get; }
    public NCQAClaims_1_0_0 NCQAClaims_1_0_0 { get; }

    #endregion

	private CqlValueSet Acute_Inpatient_Value() => 
		new CqlValueSet("https://www.ncqa.org/fhir/valueset/2.16.840.1.113883.3.464.1004.1810", null);

    [CqlDeclaration("Acute Inpatient")]
    [CqlValueSet("https://www.ncqa.org/fhir/valueset/2.16.840.1.113883.3.464.1004.1810")]
	public CqlValueSet Acute_Inpatient() => 
		__Acute_Inpatient.Value;

	private CqlValueSet Advanced_Illness_Value() => 
		new CqlValueSet("https://www.ncqa.org/fhir/valueset/2.16.840.1.113883.3.464.1004.1465", null);

    [CqlDeclaration("Advanced Illness")]
    [CqlValueSet("https://www.ncqa.org/fhir/valueset/2.16.840.1.113883.3.464.1004.1465")]
	public CqlValueSet Advanced_Illness() => 
		__Advanced_Illness.Value;

	private CqlValueSet Dementia_Medications_Value() => 
		new CqlValueSet("https://www.ncqa.org/fhir/valueset/2.16.840.1.113883.3.464.1004.1729", null);

    [CqlDeclaration("Dementia Medications")]
    [CqlValueSet("https://www.ncqa.org/fhir/valueset/2.16.840.1.113883.3.464.1004.1729")]
	public CqlValueSet Dementia_Medications() => 
		__Dementia_Medications.Value;

	private CqlValueSet ED_Value() => 
		new CqlValueSet("https://www.ncqa.org/fhir/valueset/2.16.840.1.113883.3.464.1004.1086", null);

    [CqlDeclaration("ED")]
    [CqlValueSet("https://www.ncqa.org/fhir/valueset/2.16.840.1.113883.3.464.1004.1086")]
	public CqlValueSet ED() => 
		__ED.Value;

	private CqlValueSet Frailty_Device_Value() => 
		new CqlValueSet("https://www.ncqa.org/fhir/valueset/2.16.840.1.113883.3.464.1004.1530", null);

    [CqlDeclaration("Frailty Device")]
    [CqlValueSet("https://www.ncqa.org/fhir/valueset/2.16.840.1.113883.3.464.1004.1530")]
	public CqlValueSet Frailty_Device() => 
		__Frailty_Device.Value;

	private CqlValueSet Frailty_Diagnosis_Value() => 
		new CqlValueSet("https://www.ncqa.org/fhir/valueset/2.16.840.1.113883.3.464.1004.1531", null);

    [CqlDeclaration("Frailty Diagnosis")]
    [CqlValueSet("https://www.ncqa.org/fhir/valueset/2.16.840.1.113883.3.464.1004.1531")]
	public CqlValueSet Frailty_Diagnosis() => 
		__Frailty_Diagnosis.Value;

	private CqlValueSet Frailty_Encounter_Value() => 
		new CqlValueSet("https://www.ncqa.org/fhir/valueset/2.16.840.1.113883.3.464.1004.1532", null);

    [CqlDeclaration("Frailty Encounter")]
    [CqlValueSet("https://www.ncqa.org/fhir/valueset/2.16.840.1.113883.3.464.1004.1532")]
	public CqlValueSet Frailty_Encounter() => 
		__Frailty_Encounter.Value;

	private CqlValueSet Frailty_Symptom_Value() => 
		new CqlValueSet("https://www.ncqa.org/fhir/valueset/2.16.840.1.113883.3.464.1004.1533", null);

    [CqlDeclaration("Frailty Symptom")]
    [CqlValueSet("https://www.ncqa.org/fhir/valueset/2.16.840.1.113883.3.464.1004.1533")]
	public CqlValueSet Frailty_Symptom() => 
		__Frailty_Symptom.Value;

	private CqlValueSet Nonacute_Inpatient_Value() => 
		new CqlValueSet("https://www.ncqa.org/fhir/valueset/2.16.840.1.113883.3.464.1004.1189", null);

    [CqlDeclaration("Nonacute Inpatient")]
    [CqlValueSet("https://www.ncqa.org/fhir/valueset/2.16.840.1.113883.3.464.1004.1189")]
	public CqlValueSet Nonacute_Inpatient() => 
		__Nonacute_Inpatient.Value;

	private CqlValueSet Observation_Value() => 
		new CqlValueSet("https://www.ncqa.org/fhir/valueset/2.16.840.1.113883.3.464.1004.1191", null);

    [CqlDeclaration("Observation")]
    [CqlValueSet("https://www.ncqa.org/fhir/valueset/2.16.840.1.113883.3.464.1004.1191")]
	public CqlValueSet Observation() => 
		__Observation.Value;

	private CqlValueSet Online_Assessments_Value() => 
		new CqlValueSet("https://www.ncqa.org/fhir/valueset/2.16.840.1.113883.3.464.1004.1446", null);

    [CqlDeclaration("Online Assessments")]
    [CqlValueSet("https://www.ncqa.org/fhir/valueset/2.16.840.1.113883.3.464.1004.1446")]
	public CqlValueSet Online_Assessments() => 
		__Online_Assessments.Value;

	private CqlValueSet Outpatient_Value() => 
		new CqlValueSet("https://www.ncqa.org/fhir/valueset/2.16.840.1.113883.3.464.1004.1202", null);

    [CqlDeclaration("Outpatient")]
    [CqlValueSet("https://www.ncqa.org/fhir/valueset/2.16.840.1.113883.3.464.1004.1202")]
	public CqlValueSet Outpatient() => 
		__Outpatient.Value;

	private CqlValueSet Telephone_Visits_Value() => 
		new CqlValueSet("https://www.ncqa.org/fhir/valueset/2.16.840.1.113883.3.464.1004.1246", null);

    [CqlDeclaration("Telephone Visits")]
    [CqlValueSet("https://www.ncqa.org/fhir/valueset/2.16.840.1.113883.3.464.1004.1246")]
	public CqlValueSet Telephone_Visits() => 
		__Telephone_Visits.Value;

	private CqlInterval<CqlDateTime> Measurement_Period_Value()
	{
		var a_ = context.ResolveParameter("NCQAAdvancedIllnessandFrailty-1.0.0", "Measurement Period", null);

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

	private bool? Has_Criteria_Indicating_Frailty_Value()
	{
		var a_ = context.Operators;
		var f_ = context.DataRetriever;
		var g_ = this.Frailty_Device();
		var h_ = f_.RetrieveByValueSet<Observation>(g_, null);
		bool? i_(Observation FrailtyDeviceApplied)
		{
			var ao_ = context.Operators;
			var ap_ = FrailtyDeviceApplied?.Effective;
			var aq_ = NCQAFHIRBase_1_0_0.Normalize_Interval(ap_);
			var ar_ = this.Measurement_Period();
			var as_ = ao_.Overlaps(aq_, ar_, null);

			return as_;
		};
		var j_ = a_.WhereOrNull<Observation>(h_, i_);
		var k_ = a_.ExistsInList<Observation>(j_);
		var o_ = this.Frailty_Diagnosis();
		var p_ = f_.RetrieveByValueSet<Condition>(o_, null);
		var q_ = NCQAStatus_1_0_0.Active_Condition(p_);
		bool? r_(Condition FrailtyDiagnosis)
		{
			var at_ = context.Operators;
			var au_ = NCQAFHIRBase_1_0_0.Prevalence_Period(FrailtyDiagnosis);
			var av_ = this.Measurement_Period();
			var aw_ = at_.Overlaps(au_, av_, null);

			return aw_;
		};
		var s_ = a_.WhereOrNull<Condition>(q_, r_);
		var t_ = a_.ExistsInList<Condition>(s_);
		var u_ = a_.Or(k_, t_);
		var y_ = this.Frailty_Encounter();
		var z_ = f_.RetrieveByValueSet<Encounter>(y_, null);
		var aa_ = NCQAStatus_1_0_0.Finished_Encounter(z_);
		bool? ab_(Encounter FrailtyEncounter)
		{
			var ax_ = context.Operators;
			var ay_ = FrailtyEncounter?.Period;
			var az_ = NCQAFHIRBase_1_0_0.Normalize_Interval(ay_);
			var ba_ = this.Measurement_Period();
			var bb_ = ax_.Overlaps(az_, ba_, null);

			return bb_;
		};
		var ac_ = a_.WhereOrNull<Encounter>(aa_, ab_);
		var ad_ = a_.ExistsInList<Encounter>(ac_);
		var ae_ = a_.Or(u_, ad_);
		var ai_ = this.Frailty_Symptom();
		var aj_ = f_.RetrieveByValueSet<Observation>(ai_, null);
		bool? ak_(Observation FrailtySymptom)
		{
			var bc_ = context.Operators;
			var bd_ = FrailtySymptom?.Effective;
			var be_ = NCQAFHIRBase_1_0_0.Normalize_Interval(bd_);
			var bf_ = this.Measurement_Period();
			var bg_ = bc_.Overlaps(be_, bf_, null);

			return bg_;
		};
		var al_ = a_.WhereOrNull<Observation>(aj_, ak_);
		var am_ = a_.ExistsInList<Observation>(al_);
		var an_ = a_.Or(ae_, am_);

		return an_;
	}

    [CqlDeclaration("Has Criteria Indicating Frailty")]
	public bool? Has_Criteria_Indicating_Frailty() => 
		__Has_Criteria_Indicating_Frailty.Value;

	private IEnumerable<CqlDate> Outpatient_Encounters_with_Advanced_Illness_Value()
	{
		var a_ = context.Operators;
		var f_ = context.DataRetriever;
		var g_ = this.Outpatient();
		var h_ = f_.RetrieveByValueSet<Encounter>(g_, null);
		var j_ = this.Observation();
		var k_ = f_.RetrieveByValueSet<Encounter>(j_, null);
		var l_ = a_.ListUnion<Encounter>(h_, k_);
		var o_ = this.ED();
		var p_ = f_.RetrieveByValueSet<Encounter>(o_, null);
		var r_ = this.Telephone_Visits();
		var s_ = f_.RetrieveByValueSet<Encounter>(r_, null);
		var t_ = a_.ListUnion<Encounter>(p_, s_);
		var u_ = a_.ListUnion<Encounter>(l_, t_);
		var x_ = this.Online_Assessments();
		var y_ = f_.RetrieveByValueSet<Encounter>(x_, null);
		var aa_ = this.Nonacute_Inpatient();
		var ab_ = f_.RetrieveByValueSet<Encounter>(aa_, null);
		var ac_ = a_.ListUnion<Encounter>(y_, ab_);
		var ad_ = a_.ListUnion<Encounter>(u_, ac_);
		var ae_ = NCQAStatus_1_0_0.Finished_Encounter(ad_);
		bool? af_(Encounter OutpatientEncounter)
		{
			var aj_ = context.Operators;
			var ak_ = context.DataRetriever;
			var al_ = this.Advanced_Illness();
			var am_ = ak_.RetrieveByValueSet<Condition>(al_, null);
			var an_ = NCQAEncounter_1_0_0.Encounter_Has_Diagnosis(OutpatientEncounter, am_);
			var ar_ = OutpatientEncounter?.Period;
			var as_ = NCQAFHIRBase_1_0_0.Normalize_Interval(ar_);
			var at_ = aj_.Start(as_);
			var au_ = aj_.DateFrom(at_);
			var az_ = this.Measurement_Period();
			var ba_ = aj_.Start(az_);
			var bb_ = aj_.DateFrom(ba_);
			var bd_ = aj_.Quantity(1m, "year");
			var be_ = aj_.Subtract(bb_, bd_);
			var bi_ = aj_.End(az_);
			var bj_ = aj_.DateFrom(bi_);
			var bk_ = aj_.Interval(be_, bj_, true, true);
			var bl_ = aj_.ElementInInterval<CqlDate>(au_, bk_, null);
			var bm_ = aj_.And(an_, bl_);

			return bm_;
		};
		var ag_ = a_.WhereOrNull<Encounter>(ae_, af_);
		CqlDate ah_(Encounter EncounterWithDiagnosis)
		{
			var bn_ = context.Operators;
			var bp_ = EncounterWithDiagnosis?.Period;
			var bq_ = NCQAFHIRBase_1_0_0.Normalize_Interval(bp_);
			var br_ = bn_.End(bq_);
			var bs_ = bn_.DateFrom(br_);

			return bs_;
		};
		var ai_ = a_.SelectOrNull<Encounter, CqlDate>(ag_, ah_);

		return ai_;
	}

    [CqlDeclaration("Outpatient Encounters with Advanced Illness")]
	public IEnumerable<CqlDate> Outpatient_Encounters_with_Advanced_Illness() => 
		__Outpatient_Encounters_with_Advanced_Illness.Value;

	private IEnumerable<CqlDate> Nonacute_Inpatient_Discharge_with_Advanced_Illness_Value()
	{
		var a_ = context.Operators;
		var c_ = context.DataRetriever;
		var d_ = c_.RetrieveByValueSet<Claim>(null, null);
		var e_ = NCQAClaims_1_0_0.Medical_Claims_With_Nonacute_or_Acute_Inpatient_Discharge(d_);
		var f_ = e_?.NonacuteInpatientDischarge;
		var h_ = this.Advanced_Illness();
		var i_ = a_.CreateValueSetFacade(h_);
		var j_ = NCQAClaims_1_0_0.Medical_Claims_With_Diagnosis(f_, (IEnumerable<CqlCode>)i_);
		var k_ = j_?.ServicePeriod;
		bool? l_(CqlInterval<CqlDateTime> DischargeWithDiagnosis)
		{
			var p_ = context.Operators;
			var s_ = p_.End(DischargeWithDiagnosis);
			var t_ = p_.DateFrom(s_);
			var y_ = this.Measurement_Period();
			var z_ = p_.Start(y_);
			var aa_ = p_.DateFrom(z_);
			var ac_ = p_.Quantity(1m, "year");
			var ad_ = p_.Subtract(aa_, ac_);
			var ah_ = p_.End(y_);
			var ai_ = p_.DateFrom(ah_);
			var aj_ = p_.Interval(ad_, ai_, true, true);
			var ak_ = p_.ElementInInterval<CqlDate>(t_, aj_, null);

			return ak_;
		};
		var m_ = a_.WhereOrNull<CqlInterval<CqlDateTime>>(k_, l_);
		CqlDate n_(CqlInterval<CqlDateTime> InpatientDischarge)
		{
			var al_ = context.Operators;
			var an_ = al_.End(InpatientDischarge);
			var ao_ = al_.DateFrom(an_);

			return ao_;
		};
		var o_ = a_.SelectOrNull<CqlInterval<CqlDateTime>, CqlDate>(m_, n_);

		return o_;
	}

    [CqlDeclaration("Nonacute Inpatient Discharge with Advanced Illness")]
	public IEnumerable<CqlDate> Nonacute_Inpatient_Discharge_with_Advanced_Illness() => 
		__Nonacute_Inpatient_Discharge_with_Advanced_Illness.Value;

	private IEnumerable<CqlDate> Outpatient_Encounters_or_Discharges_with_Advanced_Illness_Value()
	{
		IEnumerable<CqlDate> a_()
		{
			if ((context.Operators.Not((bool?)(context.Operators.ListUnion<CqlDate>(this.Outpatient_Encounters_with_Advanced_Illness(), this.Nonacute_Inpatient_Discharge_with_Advanced_Illness()) is null)) ?? false))
			{
				var b_ = context.Operators;
				var c_ = this.Outpatient_Encounters_with_Advanced_Illness();
				var d_ = this.Nonacute_Inpatient_Discharge_with_Advanced_Illness();
				var e_ = b_.ListUnion<CqlDate>(c_, d_);

				return e_;
			}
			else if ((this.Outpatient_Encounters_with_Advanced_Illness() is null))
			{
				var f_ = this.Nonacute_Inpatient_Discharge_with_Advanced_Illness();

				return f_;
			}
			else if ((this.Nonacute_Inpatient_Discharge_with_Advanced_Illness() is null))
			{
				var g_ = this.Outpatient_Encounters_with_Advanced_Illness();

				return g_;
			}
			else
			{
				IEnumerable<CqlDate> h_ = null;

				return (h_ as IEnumerable<CqlDate>);
			};
		};

		return a_();
	}

    [CqlDeclaration("Outpatient Encounters or Discharges with Advanced Illness")]
	public IEnumerable<CqlDate> Outpatient_Encounters_or_Discharges_with_Advanced_Illness() => 
		__Outpatient_Encounters_or_Discharges_with_Advanced_Illness.Value;

	private bool? Two_Outpatient_Visits_with_Advanced_Illness_on_Different_Dates_of_Service_Value()
	{
		var a_ = context.Operators;
		var e_ = this.Outpatient_Encounters_or_Discharges_with_Advanced_Illness();
		IEnumerable<CqlDate> f_(CqlDate _OutpatientVisit1)
		{
			var n_ = this.Outpatient_Encounters_or_Discharges_with_Advanced_Illness();

			return n_;
		};
		Tuples.Tuple_EaBFagdYTZfYEiNNhIYITEIUR g_(CqlDate _OutpatientVisit1, CqlDate _OutpatientVisit2)
		{
			var o_ = new Tuples.Tuple_EaBFagdYTZfYEiNNhIYITEIUR
			{
				OutpatientVisit1 = _OutpatientVisit1,
				OutpatientVisit2 = _OutpatientVisit2,
			};

			return o_;
		};
		var h_ = a_.SelectManyResultsOrNull<CqlDate, CqlDate, Tuples.Tuple_EaBFagdYTZfYEiNNhIYITEIUR>(e_, f_, g_);
		bool? i_(Tuples.Tuple_EaBFagdYTZfYEiNNhIYITEIUR tuple_eabfagdytzfyeinnhiyiteiur)
		{
			var p_ = context.Operators;
			var q_ = tuple_eabfagdytzfyeinnhiyiteiur.OutpatientVisit2;
			var s_ = tuple_eabfagdytzfyeinnhiyiteiur.OutpatientVisit1;
			var u_ = p_.Quantity(1m, "day");
			var v_ = p_.Add(s_, u_);
			var w_ = p_.SameOrAfter(q_, v_, null);

			return w_;
		};
		var j_ = a_.WhereOrNull<Tuples.Tuple_EaBFagdYTZfYEiNNhIYITEIUR>(h_, i_);
		CqlDate k_(Tuples.Tuple_EaBFagdYTZfYEiNNhIYITEIUR tuple_eabfagdytzfyeinnhiyiteiur)
		{
			var x_ = tuple_eabfagdytzfyeinnhiyiteiur.OutpatientVisit1;

			return x_;
		};
		var l_ = a_.SelectOrNull<Tuples.Tuple_EaBFagdYTZfYEiNNhIYITEIUR, CqlDate>(j_, k_);
		var m_ = a_.ExistsInList<CqlDate>(l_);

		return m_;
	}

    [CqlDeclaration("Two Outpatient Visits with Advanced Illness on Different Dates of Service")]
	public bool? Two_Outpatient_Visits_with_Advanced_Illness_on_Different_Dates_of_Service() => 
		__Two_Outpatient_Visits_with_Advanced_Illness_on_Different_Dates_of_Service.Value;

	private bool? Acute_Inpatient_Encounter_with_Advanced_Illness_Value()
	{
		var a_ = context.Operators;
		var c_ = context.DataRetriever;
		var d_ = this.Acute_Inpatient();
		var e_ = c_.RetrieveByValueSet<Encounter>(d_, null);
		var f_ = NCQAStatus_1_0_0.Finished_Encounter(e_);
		bool? g_(Encounter InpatientEncounter)
		{
			var j_ = context.Operators;
			var k_ = context.DataRetriever;
			var l_ = this.Advanced_Illness();
			var m_ = k_.RetrieveByValueSet<Condition>(l_, null);
			var n_ = NCQAEncounter_1_0_0.Encounter_Has_Diagnosis(InpatientEncounter, m_);
			var r_ = InpatientEncounter?.Period;
			var s_ = NCQAFHIRBase_1_0_0.Normalize_Interval(r_);
			var t_ = j_.Start(s_);
			var u_ = j_.DateFrom(t_);
			var z_ = this.Measurement_Period();
			var aa_ = j_.Start(z_);
			var ab_ = j_.DateFrom(aa_);
			var ad_ = j_.Quantity(1m, "year");
			var ae_ = j_.Subtract(ab_, ad_);
			var ai_ = j_.End(z_);
			var aj_ = j_.DateFrom(ai_);
			var ak_ = j_.Interval(ae_, aj_, true, true);
			var al_ = j_.ElementInInterval<CqlDate>(u_, ak_, null);
			var am_ = j_.And(n_, al_);

			return am_;
		};
		var h_ = a_.WhereOrNull<Encounter>(f_, g_);
		var i_ = a_.ExistsInList<Encounter>(h_);

		return i_;
	}

    [CqlDeclaration("Acute Inpatient Encounter with Advanced Illness")]
	public bool? Acute_Inpatient_Encounter_with_Advanced_Illness() => 
		__Acute_Inpatient_Encounter_with_Advanced_Illness.Value;

	private bool? Acute_Inpatient_Discharge_with_Advanced_Illness_Value()
	{
		var a_ = context.Operators;
		var c_ = context.DataRetriever;
		var d_ = c_.RetrieveByValueSet<Claim>(null, null);
		var e_ = NCQAClaims_1_0_0.Medical_Claims_With_Nonacute_or_Acute_Inpatient_Discharge(d_);
		var f_ = e_?.AcuteInpatientDischarge;
		var h_ = this.Advanced_Illness();
		var i_ = a_.CreateValueSetFacade(h_);
		var j_ = NCQAClaims_1_0_0.Medical_Claims_With_Diagnosis(f_, (IEnumerable<CqlCode>)i_);
		var k_ = j_?.ServicePeriod;
		bool? l_(CqlInterval<CqlDateTime> InpatientDischarge)
		{
			var o_ = context.Operators;
			var r_ = o_.End(InpatientDischarge);
			var s_ = o_.DateFrom(r_);
			var x_ = this.Measurement_Period();
			var y_ = o_.Start(x_);
			var z_ = o_.DateFrom(y_);
			var ab_ = o_.Quantity(1m, "year");
			var ac_ = o_.Subtract(z_, ab_);
			var ag_ = o_.End(x_);
			var ah_ = o_.DateFrom(ag_);
			var ai_ = o_.Interval(ac_, ah_, true, true);
			var aj_ = o_.ElementInInterval<CqlDate>(s_, ai_, null);

			return aj_;
		};
		var m_ = a_.WhereOrNull<CqlInterval<CqlDateTime>>(k_, l_);
		var n_ = a_.ExistsInList<CqlInterval<CqlDateTime>>(m_);

		return n_;
	}

    [CqlDeclaration("Acute Inpatient Discharge with Advanced Illness")]
	public bool? Acute_Inpatient_Discharge_with_Advanced_Illness() => 
		__Acute_Inpatient_Discharge_with_Advanced_Illness.Value;

	private bool? Dementia_Medications_In_Year_Before_or_During_Measurement_Period_Value()
	{
		var a_ = context.Operators;
		var d_ = context.DataRetriever;
		var e_ = this.Dementia_Medications();
		var f_ = d_.RetrieveByValueSet<MedicationDispense>(e_, null);
		var i_ = d_.RetrieveByValueSet<MedicationDispense>(e_, null);
		var j_ = a_.ListUnion<MedicationDispense>(f_, i_);
		var k_ = NCQAStatus_1_0_0.Dispensed_Medication(j_);
		bool? l_(MedicationDispense DementiaMedDispensed)
		{
			var o_ = context.Operators;
			var r_ = DementiaMedDispensed?.WhenHandedOverElement;
			var s_ = NCQAFHIRBase_1_0_0.Normalize_Interval(r_);
			var t_ = o_.Start(s_);
			var u_ = o_.DateFrom(t_);
			var z_ = this.Measurement_Period();
			var aa_ = o_.Start(z_);
			var ab_ = o_.DateFrom(aa_);
			var ad_ = o_.Quantity(1m, "year");
			var ae_ = o_.Subtract(ab_, ad_);
			var ai_ = o_.End(z_);
			var aj_ = o_.DateFrom(ai_);
			var ak_ = o_.Interval(ae_, aj_, true, true);
			var al_ = o_.ElementInInterval<CqlDate>(u_, ak_, null);

			return al_;
		};
		var m_ = a_.WhereOrNull<MedicationDispense>(k_, l_);
		var n_ = a_.ExistsInList<MedicationDispense>(m_);

		return n_;
	}

    [CqlDeclaration("Dementia Medications In Year Before or During Measurement Period")]
	public bool? Dementia_Medications_In_Year_Before_or_During_Measurement_Period() => 
		__Dementia_Medications_In_Year_Before_or_During_Measurement_Period.Value;

	private bool? Advanced_Illness_and_Frailty_Exclusion_Including_Over_Age_80_Value()
	{
		var a_ = context.Operators;
		var g_ = a_.TypeConverter;
		var h_ = this.Patient();
		var i_ = h_?.BirthDateElement;
		var j_ = i_?.Value;
		var k_ = g_.Convert<CqlDate>(j_);
		var n_ = this.Measurement_Period();
		var o_ = a_.End(n_);
		var p_ = a_.DateFrom(o_);
		var q_ = a_.CalculateAgeAt(k_, p_, "year");
		var s_ = a_.Interval((int?)66, (int?)80, true, true);
		var t_ = a_.ElementInInterval<int?>(q_, s_, null);
		var u_ = this.Has_Criteria_Indicating_Frailty();
		var v_ = a_.And(t_, u_);
		var z_ = this.Two_Outpatient_Visits_with_Advanced_Illness_on_Different_Dates_of_Service();
		var aa_ = this.Acute_Inpatient_Encounter_with_Advanced_Illness();
		var ab_ = a_.Or(z_, aa_);
		var ac_ = this.Acute_Inpatient_Discharge_with_Advanced_Illness();
		var ad_ = a_.Or(ab_, ac_);
		var ae_ = this.Dementia_Medications_In_Year_Before_or_During_Measurement_Period();
		var af_ = a_.Or(ad_, ae_);
		var ag_ = a_.And(v_, af_);
		var al_ = a_.TypeConverter;
		var an_ = h_?.BirthDateElement;
		var ao_ = an_?.Value;
		var ap_ = al_.Convert<CqlDate>(ao_);
		var at_ = a_.End(n_);
		var au_ = a_.DateFrom(at_);
		var av_ = a_.CalculateAgeAt(ap_, au_, "year");
		var aw_ = a_.GreaterOrEqual(av_, (int?)81);
		var ay_ = a_.And(aw_, u_);
		var az_ = a_.Or(ag_, ay_);

		return az_;
	}

    [CqlDeclaration("Advanced Illness and Frailty Exclusion Including Over Age 80")]
	public bool? Advanced_Illness_and_Frailty_Exclusion_Including_Over_Age_80() => 
		__Advanced_Illness_and_Frailty_Exclusion_Including_Over_Age_80.Value;

	private bool? Advanced_Illness_and_Frailty_Exclusion_Not_Including_Over_Age_80_Value()
	{
		var a_ = context.Operators;
		var f_ = a_.TypeConverter;
		var g_ = this.Patient();
		var h_ = g_?.BirthDateElement;
		var i_ = h_?.Value;
		var j_ = f_.Convert<CqlDate>(i_);
		var m_ = this.Measurement_Period();
		var n_ = a_.End(m_);
		var o_ = a_.DateFrom(n_);
		var p_ = a_.CalculateAgeAt(j_, o_, "year");
		var q_ = a_.GreaterOrEqual(p_, (int?)66);
		var r_ = this.Has_Criteria_Indicating_Frailty();
		var s_ = a_.And(q_, r_);
		var w_ = this.Two_Outpatient_Visits_with_Advanced_Illness_on_Different_Dates_of_Service();
		var x_ = this.Acute_Inpatient_Encounter_with_Advanced_Illness();
		var y_ = a_.Or(w_, x_);
		var z_ = this.Acute_Inpatient_Discharge_with_Advanced_Illness();
		var aa_ = a_.Or(y_, z_);
		var ab_ = this.Dementia_Medications_In_Year_Before_or_During_Measurement_Period();
		var ac_ = a_.Or(aa_, ab_);
		var ad_ = a_.And(s_, ac_);

		return ad_;
	}

    [CqlDeclaration("Advanced Illness and Frailty Exclusion Not Including Over Age 80")]
	public bool? Advanced_Illness_and_Frailty_Exclusion_Not_Including_Over_Age_80() => 
		__Advanced_Illness_and_Frailty_Exclusion_Not_Including_Over_Age_80.Value;

}