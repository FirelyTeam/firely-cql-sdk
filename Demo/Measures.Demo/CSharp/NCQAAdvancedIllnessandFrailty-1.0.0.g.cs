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
		var b_ = context.Operators.SingletonFrom<Patient>(a_);

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
			var z_ = FrailtyDeviceApplied?.Effective;
			var aa_ = NCQAFHIRBase_1_0_0.Normalize_Interval(z_);
			var ab_ = this.Measurement_Period();
			var ac_ = context.Operators.Overlaps(aa_, ab_, null);

			return ac_;
		};
		var d_ = context.Operators.Where<Observation>(b_, c_);
		var e_ = context.Operators.Exists<Observation>(d_);
		var f_ = this.Frailty_Diagnosis();
		var g_ = context.Operators.RetrieveByValueSet<Condition>(f_, null);
		var h_ = NCQAStatus_1_0_0.Active_Condition(g_);
		bool? i_(Condition FrailtyDiagnosis)
		{
			var ad_ = NCQAFHIRBase_1_0_0.Prevalence_Period(FrailtyDiagnosis);
			var ae_ = this.Measurement_Period();
			var af_ = context.Operators.Overlaps(ad_, ae_, null);

			return af_;
		};
		var j_ = context.Operators.Where<Condition>(h_, i_);
		var k_ = context.Operators.Exists<Condition>(j_);
		var l_ = context.Operators.Or(e_, k_);
		var m_ = this.Frailty_Encounter();
		var n_ = context.Operators.RetrieveByValueSet<Encounter>(m_, null);
		var o_ = NCQAStatus_1_0_0.Finished_Encounter(n_);
		bool? p_(Encounter FrailtyEncounter)
		{
			var ag_ = FrailtyEncounter?.Period;
			var ah_ = NCQAFHIRBase_1_0_0.Normalize_Interval((ag_ as object));
			var ai_ = this.Measurement_Period();
			var aj_ = context.Operators.Overlaps(ah_, ai_, null);

			return aj_;
		};
		var q_ = context.Operators.Where<Encounter>(o_, p_);
		var r_ = context.Operators.Exists<Encounter>(q_);
		var s_ = context.Operators.Or(l_, r_);
		var t_ = this.Frailty_Symptom();
		var u_ = context.Operators.RetrieveByValueSet<Observation>(t_, null);
		bool? v_(Observation FrailtySymptom)
		{
			var ak_ = FrailtySymptom?.Effective;
			var al_ = NCQAFHIRBase_1_0_0.Normalize_Interval(ak_);
			var am_ = this.Measurement_Period();
			var an_ = context.Operators.Overlaps(al_, am_, null);

			return an_;
		};
		var w_ = context.Operators.Where<Observation>(u_, v_);
		var x_ = context.Operators.Exists<Observation>(w_);
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
		var e_ = context.Operators.Union<Encounter>(b_, d_);
		var f_ = this.ED();
		var g_ = context.Operators.RetrieveByValueSet<Encounter>(f_, null);
		var h_ = this.Telephone_Visits();
		var i_ = context.Operators.RetrieveByValueSet<Encounter>(h_, null);
		var j_ = context.Operators.Union<Encounter>(g_, i_);
		var k_ = context.Operators.Union<Encounter>(e_, j_);
		var l_ = this.Online_Assessments();
		var m_ = context.Operators.RetrieveByValueSet<Encounter>(l_, null);
		var n_ = this.Nonacute_Inpatient();
		var o_ = context.Operators.RetrieveByValueSet<Encounter>(n_, null);
		var p_ = context.Operators.Union<Encounter>(m_, o_);
		var q_ = context.Operators.Union<Encounter>(k_, p_);
		var r_ = NCQAStatus_1_0_0.Finished_Encounter(q_);
		bool? s_(Encounter OutpatientEncounter)
		{
			var w_ = this.Advanced_Illness();
			var x_ = context.Operators.RetrieveByValueSet<Condition>(w_, null);
			var y_ = NCQAEncounter_1_0_0.Encounter_Has_Diagnosis(OutpatientEncounter, x_);
			var z_ = OutpatientEncounter?.Period;
			var aa_ = NCQAFHIRBase_1_0_0.Normalize_Interval((z_ as object));
			var ab_ = context.Operators.Start(aa_);
			var ac_ = context.Operators.DateFrom(ab_);
			var ad_ = this.Measurement_Period();
			var ae_ = context.Operators.Start(ad_);
			var af_ = context.Operators.DateFrom(ae_);
			var ag_ = context.Operators.Quantity(1m, "year");
			var ah_ = context.Operators.Subtract(af_, ag_);
			var aj_ = context.Operators.End(ad_);
			var ak_ = context.Operators.DateFrom(aj_);
			var al_ = context.Operators.Interval(ah_, ak_, true, true);
			var am_ = context.Operators.In<CqlDate>(ac_, al_, null);
			var an_ = context.Operators.And(y_, am_);

			return an_;
		};
		var t_ = context.Operators.Where<Encounter>(r_, s_);
		CqlDate u_(Encounter EncounterWithDiagnosis)
		{
			var ao_ = EncounterWithDiagnosis?.Period;
			var ap_ = NCQAFHIRBase_1_0_0.Normalize_Interval((ao_ as object));
			var aq_ = context.Operators.End(ap_);
			var ar_ = context.Operators.DateFrom(aq_);

			return ar_;
		};
		var v_ = context.Operators.Select<Encounter, CqlDate>(t_, u_);

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
		var e_ = NCQAClaims_1_0_0.Medical_Claims_With_Diagnosis(b_?.NonacuteInpatientDischarge, (IEnumerable<CqlCode>)d_);
		bool? f_(CqlInterval<CqlDateTime> DischargeWithDiagnosis)
		{
			var j_ = context.Operators.End(DischargeWithDiagnosis);
			var k_ = context.Operators.DateFrom(j_);
			var l_ = this.Measurement_Period();
			var m_ = context.Operators.Start(l_);
			var n_ = context.Operators.DateFrom(m_);
			var o_ = context.Operators.Quantity(1m, "year");
			var p_ = context.Operators.Subtract(n_, o_);
			var r_ = context.Operators.End(l_);
			var s_ = context.Operators.DateFrom(r_);
			var t_ = context.Operators.Interval(p_, s_, true, true);
			var u_ = context.Operators.In<CqlDate>(k_, t_, null);

			return u_;
		};
		var g_ = context.Operators.Where<CqlInterval<CqlDateTime>>(e_?.ServicePeriod, f_);
		CqlDate h_(CqlInterval<CqlDateTime> InpatientDischarge)
		{
			var v_ = context.Operators.End(InpatientDischarge);
			var w_ = context.Operators.DateFrom(v_);

			return w_;
		};
		var i_ = context.Operators.Select<CqlInterval<CqlDateTime>, CqlDate>(g_, h_);

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
				var e_ = context.Operators.Union<CqlDate>(c_, d_);
				var f_ = context.Operators.Not((bool?)(e_ is null));

				return (f_ ?? false);
			};
			if (b_())
			{
				var g_ = this.Outpatient_Encounters_with_Advanced_Illness();
				var h_ = this.Nonacute_Inpatient_Discharge_with_Advanced_Illness();
				var i_ = context.Operators.Union<CqlDate>(g_, h_);

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
				return (null as IEnumerable<CqlDate>);
			}
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
		Tuple_CMSeRgTJgKISKSQUcNZWKegGV d_(ValueTuple<CqlDate, CqlDate> _valueTuple)
		{
			var k_ = new Tuple_CMSeRgTJgKISKSQUcNZWKegGV
			{
				OutpatientVisit1 = _valueTuple.Item1,
				OutpatientVisit2 = _valueTuple.Item2,
			};

			return k_;
		};
		var e_ = context.Operators.Select<ValueTuple<CqlDate, CqlDate>, Tuple_CMSeRgTJgKISKSQUcNZWKegGV>(c_, d_);
		bool? f_(Tuple_CMSeRgTJgKISKSQUcNZWKegGV tuple_cmsergtjgkisksqucnzwkeggv)
		{
			var l_ = context.Operators.Quantity(1m, "day");
			var m_ = context.Operators.Add(tuple_cmsergtjgkisksqucnzwkeggv.OutpatientVisit1, l_);
			var n_ = context.Operators.SameOrAfter(tuple_cmsergtjgkisksqucnzwkeggv.OutpatientVisit2, m_, null);

			return n_;
		};
		var g_ = context.Operators.Where<Tuple_CMSeRgTJgKISKSQUcNZWKegGV>(e_, f_);
		CqlDate h_(Tuple_CMSeRgTJgKISKSQUcNZWKegGV tuple_cmsergtjgkisksqucnzwkeggv) => 
			tuple_cmsergtjgkisksqucnzwkeggv.OutpatientVisit1;
		var i_ = context.Operators.Select<Tuple_CMSeRgTJgKISKSQUcNZWKegGV, CqlDate>(g_, h_);
		var j_ = context.Operators.Exists<CqlDate>(i_);

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
			var j_ = InpatientEncounter?.Period;
			var k_ = NCQAFHIRBase_1_0_0.Normalize_Interval((j_ as object));
			var l_ = context.Operators.Start(k_);
			var m_ = context.Operators.DateFrom(l_);
			var n_ = this.Measurement_Period();
			var o_ = context.Operators.Start(n_);
			var p_ = context.Operators.DateFrom(o_);
			var q_ = context.Operators.Quantity(1m, "year");
			var r_ = context.Operators.Subtract(p_, q_);
			var t_ = context.Operators.End(n_);
			var u_ = context.Operators.DateFrom(t_);
			var v_ = context.Operators.Interval(r_, u_, true, true);
			var w_ = context.Operators.In<CqlDate>(m_, v_, null);
			var x_ = context.Operators.And(i_, w_);

			return x_;
		};
		var e_ = context.Operators.Where<Encounter>(c_, d_);
		var f_ = context.Operators.Exists<Encounter>(e_);

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
		var e_ = NCQAClaims_1_0_0.Medical_Claims_With_Diagnosis(b_?.AcuteInpatientDischarge, (IEnumerable<CqlCode>)d_);
		bool? f_(CqlInterval<CqlDateTime> InpatientDischarge)
		{
			var i_ = context.Operators.End(InpatientDischarge);
			var j_ = context.Operators.DateFrom(i_);
			var k_ = this.Measurement_Period();
			var l_ = context.Operators.Start(k_);
			var m_ = context.Operators.DateFrom(l_);
			var n_ = context.Operators.Quantity(1m, "year");
			var o_ = context.Operators.Subtract(m_, n_);
			var q_ = context.Operators.End(k_);
			var r_ = context.Operators.DateFrom(q_);
			var s_ = context.Operators.Interval(o_, r_, true, true);
			var t_ = context.Operators.In<CqlDate>(j_, s_, null);

			return t_;
		};
		var g_ = context.Operators.Where<CqlInterval<CqlDateTime>>(e_?.ServicePeriod, f_);
		var h_ = context.Operators.Exists<CqlInterval<CqlDateTime>>(g_);

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
		var e_ = context.Operators.Union<MedicationDispense>(b_, d_);
		var f_ = NCQAStatus_1_0_0.Dispensed_Medication(e_);
		bool? g_(MedicationDispense DementiaMedDispensed)
		{
			var j_ = DementiaMedDispensed?.WhenHandedOverElement;
			var k_ = NCQAFHIRBase_1_0_0.Normalize_Interval((j_ as object));
			var l_ = context.Operators.Start(k_);
			var m_ = context.Operators.DateFrom(l_);
			var n_ = this.Measurement_Period();
			var o_ = context.Operators.Start(n_);
			var p_ = context.Operators.DateFrom(o_);
			var q_ = context.Operators.Quantity(1m, "year");
			var r_ = context.Operators.Subtract(p_, q_);
			var t_ = context.Operators.End(n_);
			var u_ = context.Operators.DateFrom(t_);
			var v_ = context.Operators.Interval(r_, u_, true, true);
			var w_ = context.Operators.In<CqlDate>(m_, v_, null);

			return w_;
		};
		var h_ = context.Operators.Where<MedicationDispense>(f_, g_);
		var i_ = context.Operators.Exists<MedicationDispense>(h_);

		return i_;
	}

    [CqlDeclaration("Dementia Medications In Year Before or During Measurement Period")]
	public bool? Dementia_Medications_In_Year_Before_or_During_Measurement_Period() => 
		__Dementia_Medications_In_Year_Before_or_During_Measurement_Period.Value;

	private bool? Advanced_Illness_and_Frailty_Exclusion_Including_Over_Age_80_Value()
	{
		var a_ = this.Patient();
		var b_ = context.Operators.Convert<CqlDate>(a_?.BirthDateElement?.Value);
		var c_ = this.Measurement_Period();
		var d_ = context.Operators.End(c_);
		var e_ = context.Operators.DateFrom(d_);
		var f_ = context.Operators.CalculateAgeAt(b_, e_, "year");
		var g_ = context.Operators.Interval(66, 80, true, true);
		var h_ = context.Operators.In<int?>(f_, g_, null);
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
		var t_ = context.Operators.Convert<CqlDate>(a_?.BirthDateElement?.Value);
		var v_ = context.Operators.End(c_);
		var w_ = context.Operators.DateFrom(v_);
		var x_ = context.Operators.CalculateAgeAt(t_, w_, "year");
		var y_ = context.Operators.GreaterOrEqual(x_, 81);
		var aa_ = context.Operators.And(y_, i_);
		var ab_ = context.Operators.Or(r_, aa_);

		return ab_;
	}

    [CqlDeclaration("Advanced Illness and Frailty Exclusion Including Over Age 80")]
	public bool? Advanced_Illness_and_Frailty_Exclusion_Including_Over_Age_80() => 
		__Advanced_Illness_and_Frailty_Exclusion_Including_Over_Age_80.Value;

	private bool? Advanced_Illness_and_Frailty_Exclusion_Not_Including_Over_Age_80_Value()
	{
		var a_ = this.Patient();
		var b_ = context.Operators.Convert<CqlDate>(a_?.BirthDateElement?.Value);
		var c_ = this.Measurement_Period();
		var d_ = context.Operators.End(c_);
		var e_ = context.Operators.DateFrom(d_);
		var f_ = context.Operators.CalculateAgeAt(b_, e_, "year");
		var g_ = context.Operators.GreaterOrEqual(f_, 66);
		var h_ = this.Has_Criteria_Indicating_Frailty();
		var i_ = context.Operators.And(g_, h_);
		var j_ = this.Two_Outpatient_Visits_with_Advanced_Illness_on_Different_Dates_of_Service();
		var k_ = this.Acute_Inpatient_Encounter_with_Advanced_Illness();
		var l_ = context.Operators.Or(j_, k_);
		var m_ = this.Acute_Inpatient_Discharge_with_Advanced_Illness();
		var n_ = context.Operators.Or(l_, m_);
		var o_ = this.Dementia_Medications_In_Year_Before_or_During_Measurement_Period();
		var p_ = context.Operators.Or(n_, o_);
		var q_ = context.Operators.And(i_, p_);

		return q_;
	}

    [CqlDeclaration("Advanced Illness and Frailty Exclusion Not Including Over Age 80")]
	public bool? Advanced_Illness_and_Frailty_Exclusion_Not_Including_Over_Age_80() => 
		__Advanced_Illness_and_Frailty_Exclusion_Not_Including_Over_Age_80.Value;

}
