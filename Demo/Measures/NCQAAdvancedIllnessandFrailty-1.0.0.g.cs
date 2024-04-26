using System;
using System.Linq;
using System.Collections.Generic;
using Hl7.Cql.Runtime;
using Hl7.Cql.Primitives;
using Hl7.Cql.Abstractions;
using Hl7.Cql.ValueSets;
using Hl7.Cql.Iso8601;
using Hl7.Fhir.Model;
using Range = Hl7.Fhir.Model.Range;
using Task = Hl7.Fhir.Model.Task;
[System.CodeDom.Compiler.GeneratedCode(".NET Code Generation", "2.0.0.0")]
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
		var a_ = context.Operators.RetrieveByValueSet<Patient>(null, null);
		var b_ = context.Operators.SingleOrNull<Patient>(a_);

		return b_;
	}

    [CqlDeclaration("Patient")]
	public Patient Patient() => 
		__Patient.Value;

	private bool? Has_Criteria_Indicating_Frailty_Value()
	{
		var a_ = this.Frailty_Device();
		var b_ = context.Operators.RetrieveByValueSet<Observation>(a_, null);
		bool? c_(Observation FrailtyDeviceApplied)
		{
			var z_ = NCQAFHIRBase_1_0_0.Normalize_Interval(FrailtyDeviceApplied?.Effective);
			var aa_ = this.Measurement_Period();
			var ab_ = context.Operators.Overlaps(z_, aa_, null);

			return ab_;
		};
		var d_ = context.Operators.WhereOrNull<Observation>(b_, c_);
		var e_ = context.Operators.ExistsInList<Observation>(d_);
		var f_ = this.Frailty_Diagnosis();
		var g_ = context.Operators.RetrieveByValueSet<Condition>(f_, null);
		var h_ = NCQAStatus_1_0_0.Active_Condition(g_);
		bool? i_(Condition FrailtyDiagnosis)
		{
			var ac_ = NCQAFHIRBase_1_0_0.Prevalence_Period(FrailtyDiagnosis);
			var ad_ = this.Measurement_Period();
			var ae_ = context.Operators.Overlaps(ac_, ad_, null);

			return ae_;
		};
		var j_ = context.Operators.WhereOrNull<Condition>(h_, i_);
		var k_ = context.Operators.ExistsInList<Condition>(j_);
		var l_ = context.Operators.Or(e_, k_);
		var m_ = this.Frailty_Encounter();
		var n_ = context.Operators.RetrieveByValueSet<Encounter>(m_, null);
		var o_ = NCQAStatus_1_0_0.Finished_Encounter(n_);
		bool? p_(Encounter FrailtyEncounter)
		{
			var af_ = NCQAFHIRBase_1_0_0.Normalize_Interval((FrailtyEncounter?.Period as object));
			var ag_ = this.Measurement_Period();
			var ah_ = context.Operators.Overlaps(af_, ag_, null);

			return ah_;
		};
		var q_ = context.Operators.WhereOrNull<Encounter>(o_, p_);
		var r_ = context.Operators.ExistsInList<Encounter>(q_);
		var s_ = context.Operators.Or(l_, r_);
		var t_ = this.Frailty_Symptom();
		var u_ = context.Operators.RetrieveByValueSet<Observation>(t_, null);
		bool? v_(Observation FrailtySymptom)
		{
			var ai_ = NCQAFHIRBase_1_0_0.Normalize_Interval(FrailtySymptom?.Effective);
			var aj_ = this.Measurement_Period();
			var ak_ = context.Operators.Overlaps(ai_, aj_, null);

			return ak_;
		};
		var w_ = context.Operators.WhereOrNull<Observation>(u_, v_);
		var x_ = context.Operators.ExistsInList<Observation>(w_);
		var y_ = context.Operators.Or(s_, x_);

		return y_;
	}

    [CqlDeclaration("Has Criteria Indicating Frailty")]
	public bool? Has_Criteria_Indicating_Frailty() => 
		__Has_Criteria_Indicating_Frailty.Value;

	private IEnumerable<CqlDate> Outpatient_Encounters_with_Advanced_Illness_Value()
	{
		var a_ = this.Outpatient();
		var b_ = context.Operators.RetrieveByValueSet<Encounter>(a_, null);
		var c_ = this.Observation();
		var d_ = context.Operators.RetrieveByValueSet<Encounter>(c_, null);
		var e_ = context.Operators.ListUnion<Encounter>(b_, d_);
		var f_ = this.ED();
		var g_ = context.Operators.RetrieveByValueSet<Encounter>(f_, null);
		var h_ = this.Telephone_Visits();
		var i_ = context.Operators.RetrieveByValueSet<Encounter>(h_, null);
		var j_ = context.Operators.ListUnion<Encounter>(g_, i_);
		var k_ = context.Operators.ListUnion<Encounter>(e_, j_);
		var l_ = this.Online_Assessments();
		var m_ = context.Operators.RetrieveByValueSet<Encounter>(l_, null);
		var n_ = this.Nonacute_Inpatient();
		var o_ = context.Operators.RetrieveByValueSet<Encounter>(n_, null);
		var p_ = context.Operators.ListUnion<Encounter>(m_, o_);
		var q_ = context.Operators.ListUnion<Encounter>(k_, p_);
		var r_ = NCQAStatus_1_0_0.Finished_Encounter(q_);
		bool? s_(Encounter OutpatientEncounter)
		{
			var w_ = this.Advanced_Illness();
			var x_ = context.Operators.RetrieveByValueSet<Condition>(w_, null);
			var y_ = NCQAEncounter_1_0_0.Encounter_Has_Diagnosis(OutpatientEncounter, x_);
			var z_ = NCQAFHIRBase_1_0_0.Normalize_Interval((OutpatientEncounter?.Period as object));
			var aa_ = context.Operators.Start(z_);
			var ab_ = context.Operators.DateFrom(aa_);
			var ac_ = this.Measurement_Period();
			var ad_ = context.Operators.Start(ac_);
			var ae_ = context.Operators.DateFrom(ad_);
			var af_ = context.Operators.Quantity((decimal?)1m, "year");
			var ag_ = context.Operators.Subtract(ae_, af_);
			var ai_ = context.Operators.End(ac_);
			var aj_ = context.Operators.DateFrom(ai_);
			var ak_ = context.Operators.Interval(ag_, aj_, true, true);
			var al_ = context.Operators.ElementInInterval<CqlDate>(ab_, ak_, null);
			var am_ = context.Operators.And(y_, al_);

			return am_;
		};
		var t_ = context.Operators.WhereOrNull<Encounter>(r_, s_);
		CqlDate u_(Encounter EncounterWithDiagnosis)
		{
			var an_ = NCQAFHIRBase_1_0_0.Normalize_Interval((EncounterWithDiagnosis?.Period as object));
			var ao_ = context.Operators.End(an_);
			var ap_ = context.Operators.DateFrom(ao_);

			return ap_;
		};
		var v_ = context.Operators.SelectOrNull<Encounter, CqlDate>(t_, u_);

		return v_;
	}

    [CqlDeclaration("Outpatient Encounters with Advanced Illness")]
	public IEnumerable<CqlDate> Outpatient_Encounters_with_Advanced_Illness() => 
		__Outpatient_Encounters_with_Advanced_Illness.Value;

	private IEnumerable<CqlDate> Nonacute_Inpatient_Discharge_with_Advanced_Illness_Value()
	{
		var a_ = context.Operators.RetrieveByValueSet<Claim>(null, null);
		var b_ = NCQAClaims_1_0_0.Medical_Claims_With_Nonacute_or_Acute_Inpatient_Discharge(a_);
		var c_ = this.Advanced_Illness();
		var d_ = context.Operators.CreateValueSetFacade(c_);
		var e_ = NCQAClaims_1_0_0.Medical_Claims_With_Diagnosis(b_?.NonacuteInpatientDischarge, (d_ as IEnumerable<CqlCode>));
		bool? f_(CqlInterval<CqlDateTime> DischargeWithDiagnosis)
		{
			var j_ = context.Operators.End(DischargeWithDiagnosis);
			var k_ = context.Operators.DateFrom(j_);
			var l_ = this.Measurement_Period();
			var m_ = context.Operators.Start(l_);
			var n_ = context.Operators.DateFrom(m_);
			var o_ = context.Operators.Quantity((decimal?)1m, "year");
			var p_ = context.Operators.Subtract(n_, o_);
			var r_ = context.Operators.End(l_);
			var s_ = context.Operators.DateFrom(r_);
			var t_ = context.Operators.Interval(p_, s_, true, true);
			var u_ = context.Operators.ElementInInterval<CqlDate>(k_, t_, null);

			return u_;
		};
		var g_ = context.Operators.WhereOrNull<CqlInterval<CqlDateTime>>(e_?.ServicePeriod, f_);
		CqlDate h_(CqlInterval<CqlDateTime> InpatientDischarge)
		{
			var v_ = context.Operators.End(InpatientDischarge);
			var w_ = context.Operators.DateFrom(v_);

			return w_;
		};
		var i_ = context.Operators.SelectOrNull<CqlInterval<CqlDateTime>, CqlDate>(g_, h_);

		return i_;
	}

    [CqlDeclaration("Nonacute Inpatient Discharge with Advanced Illness")]
	public IEnumerable<CqlDate> Nonacute_Inpatient_Discharge_with_Advanced_Illness() => 
		__Nonacute_Inpatient_Discharge_with_Advanced_Illness.Value;

	private IEnumerable<CqlDate> Outpatient_Encounters_or_Discharges_with_Advanced_Illness_Value()
	{
		IEnumerable<CqlDate> a_()
		{
			bool b_()
			{
				var c_ = this.Outpatient_Encounters_with_Advanced_Illness();
				var d_ = this.Nonacute_Inpatient_Discharge_with_Advanced_Illness();
				var e_ = context.Operators.ListUnion<CqlDate>(c_, d_);
				var f_ = context.Operators.Not((bool?)(e_ is null));

				return (f_ ?? false);
			};
			if (b_())
			{
				var g_ = this.Outpatient_Encounters_with_Advanced_Illness();
				var h_ = this.Nonacute_Inpatient_Discharge_with_Advanced_Illness();
				var i_ = context.Operators.ListUnion<CqlDate>(g_, h_);

				return i_;
			}
			else if ((this.Outpatient_Encounters_with_Advanced_Illness() is null))
			{
				var j_ = this.Nonacute_Inpatient_Discharge_with_Advanced_Illness();

				return j_;
			}
			else if ((this.Nonacute_Inpatient_Discharge_with_Advanced_Illness() is null))
			{
				var k_ = this.Outpatient_Encounters_with_Advanced_Illness();

				return k_;
			}
			else
			{
				IEnumerable<CqlDate> l_ = null;

				return (l_ as IEnumerable<CqlDate>);
			};
		};

		return a_();
	}

    [CqlDeclaration("Outpatient Encounters or Discharges with Advanced Illness")]
	public IEnumerable<CqlDate> Outpatient_Encounters_or_Discharges_with_Advanced_Illness() => 
		__Outpatient_Encounters_or_Discharges_with_Advanced_Illness.Value;

	private bool? Two_Outpatient_Visits_with_Advanced_Illness_on_Different_Dates_of_Service_Value()
	{
		var a_ = this.Outpatient_Encounters_or_Discharges_with_Advanced_Illness();
		var c_ = context.Operators.CrossJoin<CqlDate, CqlDate>(a_, a_);
		Tuples.Tuple_EaBFagdYTZfYEiNNhIYITEIUR d_(ValueTuple<CqlDate,CqlDate> _valueTuple)
		{
			var k_ = new Tuples.Tuple_EaBFagdYTZfYEiNNhIYITEIUR
			{
				OutpatientVisit1 = _valueTuple.Item1,
				OutpatientVisit2 = _valueTuple.Item2,
			};

			return k_;
		};
		var e_ = context.Operators.SelectOrNull<ValueTuple<CqlDate,CqlDate>, Tuples.Tuple_EaBFagdYTZfYEiNNhIYITEIUR>(c_, d_);
		bool? f_(Tuples.Tuple_EaBFagdYTZfYEiNNhIYITEIUR tuple_eabfagdytzfyeinnhiyiteiur)
		{
			var l_ = context.Operators.Convert<CqlDateTime>(tuple_eabfagdytzfyeinnhiyiteiur.OutpatientVisit2);
			var m_ = context.Operators.Quantity((decimal?)1m, "day");
			var n_ = context.Operators.Add(tuple_eabfagdytzfyeinnhiyiteiur.OutpatientVisit1, m_);
			var o_ = context.Operators.Convert<CqlDateTime>(n_);
			var p_ = context.Operators.SameOrAfter(l_, o_, null);

			return p_;
		};
		var g_ = context.Operators.WhereOrNull<Tuples.Tuple_EaBFagdYTZfYEiNNhIYITEIUR>(e_, f_);
		CqlDate h_(Tuples.Tuple_EaBFagdYTZfYEiNNhIYITEIUR tuple_eabfagdytzfyeinnhiyiteiur) => 
			tuple_eabfagdytzfyeinnhiyiteiur.OutpatientVisit1;
		var i_ = context.Operators.SelectOrNull<Tuples.Tuple_EaBFagdYTZfYEiNNhIYITEIUR, CqlDate>(g_, h_);
		var j_ = context.Operators.ExistsInList<CqlDate>(i_);

		return j_;
	}

    [CqlDeclaration("Two Outpatient Visits with Advanced Illness on Different Dates of Service")]
	public bool? Two_Outpatient_Visits_with_Advanced_Illness_on_Different_Dates_of_Service() => 
		__Two_Outpatient_Visits_with_Advanced_Illness_on_Different_Dates_of_Service.Value;

	private bool? Acute_Inpatient_Encounter_with_Advanced_Illness_Value()
	{
		var a_ = this.Acute_Inpatient();
		var b_ = context.Operators.RetrieveByValueSet<Encounter>(a_, null);
		var c_ = NCQAStatus_1_0_0.Finished_Encounter(b_);
		bool? d_(Encounter InpatientEncounter)
		{
			var g_ = this.Advanced_Illness();
			var h_ = context.Operators.RetrieveByValueSet<Condition>(g_, null);
			var i_ = NCQAEncounter_1_0_0.Encounter_Has_Diagnosis(InpatientEncounter, h_);
			var j_ = NCQAFHIRBase_1_0_0.Normalize_Interval((InpatientEncounter?.Period as object));
			var k_ = context.Operators.Start(j_);
			var l_ = context.Operators.DateFrom(k_);
			var m_ = this.Measurement_Period();
			var n_ = context.Operators.Start(m_);
			var o_ = context.Operators.DateFrom(n_);
			var p_ = context.Operators.Quantity((decimal?)1m, "year");
			var q_ = context.Operators.Subtract(o_, p_);
			var s_ = context.Operators.End(m_);
			var t_ = context.Operators.DateFrom(s_);
			var u_ = context.Operators.Interval(q_, t_, true, true);
			var v_ = context.Operators.ElementInInterval<CqlDate>(l_, u_, null);
			var w_ = context.Operators.And(i_, v_);

			return w_;
		};
		var e_ = context.Operators.WhereOrNull<Encounter>(c_, d_);
		var f_ = context.Operators.ExistsInList<Encounter>(e_);

		return f_;
	}

    [CqlDeclaration("Acute Inpatient Encounter with Advanced Illness")]
	public bool? Acute_Inpatient_Encounter_with_Advanced_Illness() => 
		__Acute_Inpatient_Encounter_with_Advanced_Illness.Value;

	private bool? Acute_Inpatient_Discharge_with_Advanced_Illness_Value()
	{
		var a_ = context.Operators.RetrieveByValueSet<Claim>(null, null);
		var b_ = NCQAClaims_1_0_0.Medical_Claims_With_Nonacute_or_Acute_Inpatient_Discharge(a_);
		var c_ = this.Advanced_Illness();
		var d_ = context.Operators.CreateValueSetFacade(c_);
		var e_ = NCQAClaims_1_0_0.Medical_Claims_With_Diagnosis(b_?.AcuteInpatientDischarge, (d_ as IEnumerable<CqlCode>));
		bool? f_(CqlInterval<CqlDateTime> InpatientDischarge)
		{
			var i_ = context.Operators.End(InpatientDischarge);
			var j_ = context.Operators.DateFrom(i_);
			var k_ = this.Measurement_Period();
			var l_ = context.Operators.Start(k_);
			var m_ = context.Operators.DateFrom(l_);
			var n_ = context.Operators.Quantity((decimal?)1m, "year");
			var o_ = context.Operators.Subtract(m_, n_);
			var q_ = context.Operators.End(k_);
			var r_ = context.Operators.DateFrom(q_);
			var s_ = context.Operators.Interval(o_, r_, true, true);
			var t_ = context.Operators.ElementInInterval<CqlDate>(j_, s_, null);

			return t_;
		};
		var g_ = context.Operators.WhereOrNull<CqlInterval<CqlDateTime>>(e_?.ServicePeriod, f_);
		var h_ = context.Operators.ExistsInList<CqlInterval<CqlDateTime>>(g_);

		return h_;
	}

    [CqlDeclaration("Acute Inpatient Discharge with Advanced Illness")]
	public bool? Acute_Inpatient_Discharge_with_Advanced_Illness() => 
		__Acute_Inpatient_Discharge_with_Advanced_Illness.Value;

	private bool? Dementia_Medications_In_Year_Before_or_During_Measurement_Period_Value()
	{
		var a_ = this.Dementia_Medications();
		var b_ = context.Operators.RetrieveByValueSet<MedicationDispense>(a_, null);
		var d_ = context.Operators.RetrieveByValueSet<MedicationDispense>(a_, null);
		var e_ = context.Operators.ListUnion<MedicationDispense>(b_, d_);
		var f_ = NCQAStatus_1_0_0.Dispensed_Medication(e_);
		bool? g_(MedicationDispense DementiaMedDispensed)
		{
			var j_ = NCQAFHIRBase_1_0_0.Normalize_Interval((DementiaMedDispensed?.WhenHandedOverElement as object));
			var k_ = context.Operators.Start(j_);
			var l_ = context.Operators.DateFrom(k_);
			var m_ = this.Measurement_Period();
			var n_ = context.Operators.Start(m_);
			var o_ = context.Operators.DateFrom(n_);
			var p_ = context.Operators.Quantity((decimal?)1m, "year");
			var q_ = context.Operators.Subtract(o_, p_);
			var s_ = context.Operators.End(m_);
			var t_ = context.Operators.DateFrom(s_);
			var u_ = context.Operators.Interval(q_, t_, true, true);
			var v_ = context.Operators.ElementInInterval<CqlDate>(l_, u_, null);

			return v_;
		};
		var h_ = context.Operators.WhereOrNull<MedicationDispense>(f_, g_);
		var i_ = context.Operators.ExistsInList<MedicationDispense>(h_);

		return i_;
	}

    [CqlDeclaration("Dementia Medications In Year Before or During Measurement Period")]
	public bool? Dementia_Medications_In_Year_Before_or_During_Measurement_Period() => 
		__Dementia_Medications_In_Year_Before_or_During_Measurement_Period.Value;

	private bool? Advanced_Illness_and_Frailty_Exclusion_Including_Over_Age_80_Value()
	{
		var a_ = this.Patient();
		var b_ = context.Operators.Convert<CqlDateTime>(a_?.BirthDateElement?.Value);
		var c_ = this.Measurement_Period();
		var d_ = context.Operators.End(c_);
		var e_ = context.Operators.DateFrom(d_);
		var f_ = context.Operators.Convert<CqlDateTime>(e_);
		var g_ = context.Operators.CalculateAgeAt(b_, f_, "year");
		var h_ = context.Operators.Interval((int?)66, (int?)80, true, true);
		var i_ = context.Operators.ElementInInterval<int?>(g_, h_, null);
		var j_ = this.Has_Criteria_Indicating_Frailty();
		var k_ = context.Operators.And(i_, j_);
		var l_ = this.Two_Outpatient_Visits_with_Advanced_Illness_on_Different_Dates_of_Service();
		var m_ = this.Acute_Inpatient_Encounter_with_Advanced_Illness();
		var n_ = context.Operators.Or(l_, m_);
		var o_ = this.Acute_Inpatient_Discharge_with_Advanced_Illness();
		var p_ = context.Operators.Or(n_, o_);
		var q_ = this.Dementia_Medications_In_Year_Before_or_During_Measurement_Period();
		var r_ = context.Operators.Or(p_, q_);
		var s_ = context.Operators.And(k_, r_);
		var u_ = context.Operators.Convert<CqlDateTime>(a_?.BirthDateElement?.Value);
		var w_ = context.Operators.End(c_);
		var x_ = context.Operators.DateFrom(w_);
		var y_ = context.Operators.Convert<CqlDateTime>(x_);
		var z_ = context.Operators.CalculateAgeAt(u_, y_, "year");
		var aa_ = context.Operators.GreaterOrEqual(z_, (int?)81);
		var ac_ = context.Operators.And(aa_, j_);
		var ad_ = context.Operators.Or(s_, ac_);

		return ad_;
	}

    [CqlDeclaration("Advanced Illness and Frailty Exclusion Including Over Age 80")]
	public bool? Advanced_Illness_and_Frailty_Exclusion_Including_Over_Age_80() => 
		__Advanced_Illness_and_Frailty_Exclusion_Including_Over_Age_80.Value;

	private bool? Advanced_Illness_and_Frailty_Exclusion_Not_Including_Over_Age_80_Value()
	{
		var a_ = this.Patient();
		var b_ = context.Operators.Convert<CqlDateTime>(a_?.BirthDateElement?.Value);
		var c_ = this.Measurement_Period();
		var d_ = context.Operators.End(c_);
		var e_ = context.Operators.DateFrom(d_);
		var f_ = context.Operators.Convert<CqlDateTime>(e_);
		var g_ = context.Operators.CalculateAgeAt(b_, f_, "year");
		var h_ = context.Operators.GreaterOrEqual(g_, (int?)66);
		var i_ = this.Has_Criteria_Indicating_Frailty();
		var j_ = context.Operators.And(h_, i_);
		var k_ = this.Two_Outpatient_Visits_with_Advanced_Illness_on_Different_Dates_of_Service();
		var l_ = this.Acute_Inpatient_Encounter_with_Advanced_Illness();
		var m_ = context.Operators.Or(k_, l_);
		var n_ = this.Acute_Inpatient_Discharge_with_Advanced_Illness();
		var o_ = context.Operators.Or(m_, n_);
		var p_ = this.Dementia_Medications_In_Year_Before_or_During_Measurement_Period();
		var q_ = context.Operators.Or(o_, p_);
		var r_ = context.Operators.And(j_, q_);

		return r_;
	}

    [CqlDeclaration("Advanced Illness and Frailty Exclusion Not Including Over Age 80")]
	public bool? Advanced_Illness_and_Frailty_Exclusion_Not_Including_Over_Age_80() => 
		__Advanced_Illness_and_Frailty_Exclusion_Not_Including_Over_Age_80.Value;

}
