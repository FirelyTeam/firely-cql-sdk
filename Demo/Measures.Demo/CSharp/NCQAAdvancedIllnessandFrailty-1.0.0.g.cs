using System;
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
[System.CodeDom.Compiler.GeneratedCode(".NET Code Generation", "2.0.4.0")]
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
		new CqlValueSet("https://www.ncqa.org/fhir/valueset/2.16.840.1.113883.3.464.1004.1810", default);

    [CqlDeclaration("Acute Inpatient")]
    [CqlValueSet("https://www.ncqa.org/fhir/valueset/2.16.840.1.113883.3.464.1004.1810")]
	public CqlValueSet Acute_Inpatient() => 
		__Acute_Inpatient.Value;

	private CqlValueSet Advanced_Illness_Value() => 
		new CqlValueSet("https://www.ncqa.org/fhir/valueset/2.16.840.1.113883.3.464.1004.1465", default);

    [CqlDeclaration("Advanced Illness")]
    [CqlValueSet("https://www.ncqa.org/fhir/valueset/2.16.840.1.113883.3.464.1004.1465")]
	public CqlValueSet Advanced_Illness() => 
		__Advanced_Illness.Value;

	private CqlValueSet Dementia_Medications_Value() => 
		new CqlValueSet("https://www.ncqa.org/fhir/valueset/2.16.840.1.113883.3.464.1004.1729", default);

    [CqlDeclaration("Dementia Medications")]
    [CqlValueSet("https://www.ncqa.org/fhir/valueset/2.16.840.1.113883.3.464.1004.1729")]
	public CqlValueSet Dementia_Medications() => 
		__Dementia_Medications.Value;

	private CqlValueSet ED_Value() => 
		new CqlValueSet("https://www.ncqa.org/fhir/valueset/2.16.840.1.113883.3.464.1004.1086", default);

    [CqlDeclaration("ED")]
    [CqlValueSet("https://www.ncqa.org/fhir/valueset/2.16.840.1.113883.3.464.1004.1086")]
	public CqlValueSet ED() => 
		__ED.Value;

	private CqlValueSet Frailty_Device_Value() => 
		new CqlValueSet("https://www.ncqa.org/fhir/valueset/2.16.840.1.113883.3.464.1004.1530", default);

    [CqlDeclaration("Frailty Device")]
    [CqlValueSet("https://www.ncqa.org/fhir/valueset/2.16.840.1.113883.3.464.1004.1530")]
	public CqlValueSet Frailty_Device() => 
		__Frailty_Device.Value;

	private CqlValueSet Frailty_Diagnosis_Value() => 
		new CqlValueSet("https://www.ncqa.org/fhir/valueset/2.16.840.1.113883.3.464.1004.1531", default);

    [CqlDeclaration("Frailty Diagnosis")]
    [CqlValueSet("https://www.ncqa.org/fhir/valueset/2.16.840.1.113883.3.464.1004.1531")]
	public CqlValueSet Frailty_Diagnosis() => 
		__Frailty_Diagnosis.Value;

	private CqlValueSet Frailty_Encounter_Value() => 
		new CqlValueSet("https://www.ncqa.org/fhir/valueset/2.16.840.1.113883.3.464.1004.1532", default);

    [CqlDeclaration("Frailty Encounter")]
    [CqlValueSet("https://www.ncqa.org/fhir/valueset/2.16.840.1.113883.3.464.1004.1532")]
	public CqlValueSet Frailty_Encounter() => 
		__Frailty_Encounter.Value;

	private CqlValueSet Frailty_Symptom_Value() => 
		new CqlValueSet("https://www.ncqa.org/fhir/valueset/2.16.840.1.113883.3.464.1004.1533", default);

    [CqlDeclaration("Frailty Symptom")]
    [CqlValueSet("https://www.ncqa.org/fhir/valueset/2.16.840.1.113883.3.464.1004.1533")]
	public CqlValueSet Frailty_Symptom() => 
		__Frailty_Symptom.Value;

	private CqlValueSet Nonacute_Inpatient_Value() => 
		new CqlValueSet("https://www.ncqa.org/fhir/valueset/2.16.840.1.113883.3.464.1004.1189", default);

    [CqlDeclaration("Nonacute Inpatient")]
    [CqlValueSet("https://www.ncqa.org/fhir/valueset/2.16.840.1.113883.3.464.1004.1189")]
	public CqlValueSet Nonacute_Inpatient() => 
		__Nonacute_Inpatient.Value;

	private CqlValueSet Observation_Value() => 
		new CqlValueSet("https://www.ncqa.org/fhir/valueset/2.16.840.1.113883.3.464.1004.1191", default);

    [CqlDeclaration("Observation")]
    [CqlValueSet("https://www.ncqa.org/fhir/valueset/2.16.840.1.113883.3.464.1004.1191")]
	public CqlValueSet Observation() => 
		__Observation.Value;

	private CqlValueSet Online_Assessments_Value() => 
		new CqlValueSet("https://www.ncqa.org/fhir/valueset/2.16.840.1.113883.3.464.1004.1446", default);

    [CqlDeclaration("Online Assessments")]
    [CqlValueSet("https://www.ncqa.org/fhir/valueset/2.16.840.1.113883.3.464.1004.1446")]
	public CqlValueSet Online_Assessments() => 
		__Online_Assessments.Value;

	private CqlValueSet Outpatient_Value() => 
		new CqlValueSet("https://www.ncqa.org/fhir/valueset/2.16.840.1.113883.3.464.1004.1202", default);

    [CqlDeclaration("Outpatient")]
    [CqlValueSet("https://www.ncqa.org/fhir/valueset/2.16.840.1.113883.3.464.1004.1202")]
	public CqlValueSet Outpatient() => 
		__Outpatient.Value;

	private CqlValueSet Telephone_Visits_Value() => 
		new CqlValueSet("https://www.ncqa.org/fhir/valueset/2.16.840.1.113883.3.464.1004.1246", default);

    [CqlDeclaration("Telephone Visits")]
    [CqlValueSet("https://www.ncqa.org/fhir/valueset/2.16.840.1.113883.3.464.1004.1246")]
	public CqlValueSet Telephone_Visits() => 
		__Telephone_Visits.Value;

	private CqlInterval<CqlDateTime> Measurement_Period_Value()
	{
		object a_ = context.ResolveParameter("NCQAAdvancedIllnessandFrailty-1.0.0", "Measurement Period", null);

		return (CqlInterval<CqlDateTime>)a_;
	}

    [CqlDeclaration("Measurement Period")]
	public CqlInterval<CqlDateTime> Measurement_Period() => 
		__Measurement_Period.Value;

	private Patient Patient_Value()
	{
		IEnumerable<Patient> a_ = context.Operators.RetrieveByValueSet<Patient>(default, default);
		Patient b_ = context.Operators.SingletonFrom<Patient>(a_);

		return b_;
	}

    [CqlDeclaration("Patient")]
	public Patient Patient() => 
		__Patient.Value;

	private bool? Has_Criteria_Indicating_Frailty_Value()
	{
		CqlValueSet a_ = this.Frailty_Device();
		IEnumerable<Observation> b_ = context.Operators.RetrieveByValueSet<Observation>(a_, default);
		bool? c_(Observation FrailtyDeviceApplied)
		{
			DataType z_ = FrailtyDeviceApplied?.Effective;
			CqlInterval<CqlDateTime> aa_ = NCQAFHIRBase_1_0_0.Normalize_Interval(z_);
			CqlInterval<CqlDateTime> ab_ = this.Measurement_Period();
			bool? ac_ = context.Operators.Overlaps(aa_, ab_, default);

			return ac_;
		};
		IEnumerable<Observation> d_ = context.Operators.Where<Observation>(b_, c_);
		bool? e_ = context.Operators.Exists<Observation>(d_);
		CqlValueSet f_ = this.Frailty_Diagnosis();
		IEnumerable<Condition> g_ = context.Operators.RetrieveByValueSet<Condition>(f_, default);
		IEnumerable<Condition> h_ = NCQAStatus_1_0_0.Active_Condition(g_);
		bool? i_(Condition FrailtyDiagnosis)
		{
			CqlInterval<CqlDateTime> ad_ = NCQAFHIRBase_1_0_0.Prevalence_Period(FrailtyDiagnosis);
			CqlInterval<CqlDateTime> ae_ = this.Measurement_Period();
			bool? af_ = context.Operators.Overlaps(ad_, ae_, default);

			return af_;
		};
		IEnumerable<Condition> j_ = context.Operators.Where<Condition>(h_, i_);
		bool? k_ = context.Operators.Exists<Condition>(j_);
		bool? l_ = context.Operators.Or(e_, k_);
		CqlValueSet m_ = this.Frailty_Encounter();
		IEnumerable<Encounter> n_ = context.Operators.RetrieveByValueSet<Encounter>(m_, default);
		IEnumerable<Encounter> o_ = NCQAStatus_1_0_0.Finished_Encounter(n_);
		bool? p_(Encounter FrailtyEncounter)
		{
			Period ag_ = FrailtyEncounter?.Period;
			CqlInterval<CqlDateTime> ah_ = NCQAFHIRBase_1_0_0.Normalize_Interval(ag_ as object);
			CqlInterval<CqlDateTime> ai_ = this.Measurement_Period();
			bool? aj_ = context.Operators.Overlaps(ah_, ai_, default);

			return aj_;
		};
		IEnumerable<Encounter> q_ = context.Operators.Where<Encounter>(o_, p_);
		bool? r_ = context.Operators.Exists<Encounter>(q_);
		bool? s_ = context.Operators.Or(l_, r_);
		CqlValueSet t_ = this.Frailty_Symptom();
		IEnumerable<Observation> u_ = context.Operators.RetrieveByValueSet<Observation>(t_, default);
		bool? v_(Observation FrailtySymptom)
		{
			DataType ak_ = FrailtySymptom?.Effective;
			CqlInterval<CqlDateTime> al_ = NCQAFHIRBase_1_0_0.Normalize_Interval(ak_);
			CqlInterval<CqlDateTime> am_ = this.Measurement_Period();
			bool? an_ = context.Operators.Overlaps(al_, am_, default);

			return an_;
		};
		IEnumerable<Observation> w_ = context.Operators.Where<Observation>(u_, v_);
		bool? x_ = context.Operators.Exists<Observation>(w_);
		bool? y_ = context.Operators.Or(s_, x_);

		return y_;
	}

    [CqlDeclaration("Has Criteria Indicating Frailty")]
	public bool? Has_Criteria_Indicating_Frailty() => 
		__Has_Criteria_Indicating_Frailty.Value;

	private IEnumerable<CqlDate> Outpatient_Encounters_with_Advanced_Illness_Value()
	{
		CqlValueSet a_ = this.Outpatient();
		IEnumerable<Encounter> b_ = context.Operators.RetrieveByValueSet<Encounter>(a_, default);
		CqlValueSet c_ = this.Observation();
		IEnumerable<Encounter> d_ = context.Operators.RetrieveByValueSet<Encounter>(c_, default);
		IEnumerable<Encounter> e_ = context.Operators.Union<Encounter>(b_, d_);
		CqlValueSet f_ = this.ED();
		IEnumerable<Encounter> g_ = context.Operators.RetrieveByValueSet<Encounter>(f_, default);
		CqlValueSet h_ = this.Telephone_Visits();
		IEnumerable<Encounter> i_ = context.Operators.RetrieveByValueSet<Encounter>(h_, default);
		IEnumerable<Encounter> j_ = context.Operators.Union<Encounter>(g_, i_);
		IEnumerable<Encounter> k_ = context.Operators.Union<Encounter>(e_, j_);
		CqlValueSet l_ = this.Online_Assessments();
		IEnumerable<Encounter> m_ = context.Operators.RetrieveByValueSet<Encounter>(l_, default);
		CqlValueSet n_ = this.Nonacute_Inpatient();
		IEnumerable<Encounter> o_ = context.Operators.RetrieveByValueSet<Encounter>(n_, default);
		IEnumerable<Encounter> p_ = context.Operators.Union<Encounter>(m_, o_);
		IEnumerable<Encounter> q_ = context.Operators.Union<Encounter>(k_, p_);
		IEnumerable<Encounter> r_ = NCQAStatus_1_0_0.Finished_Encounter(q_);
		bool? s_(Encounter OutpatientEncounter)
		{
			CqlValueSet w_ = this.Advanced_Illness();
			IEnumerable<Condition> x_ = context.Operators.RetrieveByValueSet<Condition>(w_, default);
			bool? y_ = NCQAEncounter_1_0_0.Encounter_Has_Diagnosis(OutpatientEncounter, x_);
			Period z_ = OutpatientEncounter?.Period;
			CqlInterval<CqlDateTime> aa_ = NCQAFHIRBase_1_0_0.Normalize_Interval(z_ as object);
			CqlDateTime ab_ = context.Operators.Start(aa_);
			CqlDate ac_ = context.Operators.DateFrom(ab_);
			CqlInterval<CqlDateTime> ad_ = this.Measurement_Period();
			CqlDateTime ae_ = context.Operators.Start(ad_);
			CqlDate af_ = context.Operators.DateFrom(ae_);
			CqlQuantity ag_ = context.Operators.Quantity(1m, "year");
			CqlDate ah_ = context.Operators.Subtract(af_, ag_);
			CqlDateTime aj_ = context.Operators.End(ad_);
			CqlDate ak_ = context.Operators.DateFrom(aj_);
			CqlInterval<CqlDate> al_ = context.Operators.Interval(ah_, ak_, true, true);
			bool? am_ = context.Operators.In<CqlDate>(ac_, al_, default);
			bool? an_ = context.Operators.And(y_, am_);

			return an_;
		};
		IEnumerable<Encounter> t_ = context.Operators.Where<Encounter>(r_, s_);
		CqlDate u_(Encounter EncounterWithDiagnosis)
		{
			Period ao_ = EncounterWithDiagnosis?.Period;
			CqlInterval<CqlDateTime> ap_ = NCQAFHIRBase_1_0_0.Normalize_Interval(ao_ as object);
			CqlDateTime aq_ = context.Operators.End(ap_);
			CqlDate ar_ = context.Operators.DateFrom(aq_);

			return ar_;
		};
		IEnumerable<CqlDate> v_ = context.Operators.Select<Encounter, CqlDate>(t_, u_);

		return v_;
	}

    [CqlDeclaration("Outpatient Encounters with Advanced Illness")]
	public IEnumerable<CqlDate> Outpatient_Encounters_with_Advanced_Illness() => 
		__Outpatient_Encounters_with_Advanced_Illness.Value;

	private IEnumerable<CqlDate> Nonacute_Inpatient_Discharge_with_Advanced_Illness_Value()
	{
		IEnumerable<Claim> a_ = context.Operators.RetrieveByValueSet<Claim>(default, default);
		(IEnumerable<Claim> InpatientDischarge, IEnumerable<Claim> NonacuteInpatientDischarge, IEnumerable<Claim> AcuteInpatientDischarge)? b_ = NCQAClaims_1_0_0.Medical_Claims_With_Nonacute_or_Acute_Inpatient_Discharge(a_);
		IEnumerable<Claim> c_ = b_?.NonacuteInpatientDischarge;
		CqlValueSet d_ = this.Advanced_Illness();
		IValueSetFacade e_ = context.Operators.CreateValueSetFacade(d_);
		(IEnumerable<Claim> Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? f_ = NCQAClaims_1_0_0.Medical_Claims_With_Diagnosis(c_, e_);
		IEnumerable<CqlInterval<CqlDateTime>> g_ = f_?.ServicePeriod;
		bool? h_(CqlInterval<CqlDateTime> DischargeWithDiagnosis)
		{
			CqlDateTime l_ = context.Operators.End(DischargeWithDiagnosis);
			CqlDate m_ = context.Operators.DateFrom(l_);
			CqlInterval<CqlDateTime> n_ = this.Measurement_Period();
			CqlDateTime o_ = context.Operators.Start(n_);
			CqlDate p_ = context.Operators.DateFrom(o_);
			CqlQuantity q_ = context.Operators.Quantity(1m, "year");
			CqlDate r_ = context.Operators.Subtract(p_, q_);
			CqlDateTime t_ = context.Operators.End(n_);
			CqlDate u_ = context.Operators.DateFrom(t_);
			CqlInterval<CqlDate> v_ = context.Operators.Interval(r_, u_, true, true);
			bool? w_ = context.Operators.In<CqlDate>(m_, v_, default);

			return w_;
		};
		IEnumerable<CqlInterval<CqlDateTime>> i_ = context.Operators.Where<CqlInterval<CqlDateTime>>(g_, h_);
		CqlDate j_(CqlInterval<CqlDateTime> InpatientDischarge)
		{
			CqlDateTime x_ = context.Operators.End(InpatientDischarge);
			CqlDate y_ = context.Operators.DateFrom(x_);

			return y_;
		};
		IEnumerable<CqlDate> k_ = context.Operators.Select<CqlInterval<CqlDateTime>, CqlDate>(i_, j_);

		return k_;
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
				IEnumerable<CqlDate> c_ = this.Outpatient_Encounters_with_Advanced_Illness();
				IEnumerable<CqlDate> d_ = this.Nonacute_Inpatient_Discharge_with_Advanced_Illness();
				IEnumerable<CqlDate> e_ = context.Operators.Union<CqlDate>(c_, d_);
				bool? f_ = context.Operators.Not((bool?)(e_ is null));

				return f_ ?? false;
			};
			if (b_())
			{
				IEnumerable<CqlDate> g_ = this.Outpatient_Encounters_with_Advanced_Illness();
				IEnumerable<CqlDate> h_ = this.Nonacute_Inpatient_Discharge_with_Advanced_Illness();
				IEnumerable<CqlDate> i_ = context.Operators.Union<CqlDate>(g_, h_);

				return i_;
			}
			else if ((this.Outpatient_Encounters_with_Advanced_Illness()) is null)
			{
				IEnumerable<CqlDate> j_ = this.Nonacute_Inpatient_Discharge_with_Advanced_Illness();

				return j_;
			}
			else if ((this.Nonacute_Inpatient_Discharge_with_Advanced_Illness()) is null)
			{
				IEnumerable<CqlDate> k_ = this.Outpatient_Encounters_with_Advanced_Illness();

				return k_;
			}
			else
			{
				return null;
			}
		};

		return a_();
	}

    [CqlDeclaration("Outpatient Encounters or Discharges with Advanced Illness")]
	public IEnumerable<CqlDate> Outpatient_Encounters_or_Discharges_with_Advanced_Illness() => 
		__Outpatient_Encounters_or_Discharges_with_Advanced_Illness.Value;

	private bool? Two_Outpatient_Visits_with_Advanced_Illness_on_Different_Dates_of_Service_Value()
	{
		IEnumerable<CqlDate> a_ = this.Outpatient_Encounters_or_Discharges_with_Advanced_Illness();
		IEnumerable<ValueTuple<CqlDate, CqlDate>> c_ = context.Operators.CrossJoin<CqlDate, CqlDate>(a_, a_);
		(CqlDate OutpatientVisit1, CqlDate OutpatientVisit2)? d_(ValueTuple<CqlDate, CqlDate> _valueTuple)
		{
			(CqlDate OutpatientVisit1, CqlDate OutpatientVisit2)? k_ = (_valueTuple.Item1, _valueTuple.Item2);

			return k_;
		};
		IEnumerable<(CqlDate OutpatientVisit1, CqlDate OutpatientVisit2)?> e_ = context.Operators.Select<ValueTuple<CqlDate, CqlDate>, (CqlDate OutpatientVisit1, CqlDate OutpatientVisit2)?>(c_, d_);
		bool? f_((CqlDate OutpatientVisit1, CqlDate OutpatientVisit2)? tuple_cmsergtjgkisksqucnzwkeggv)
		{
			CqlQuantity l_ = context.Operators.Quantity(1m, "day");
			CqlDate m_ = context.Operators.Add(tuple_cmsergtjgkisksqucnzwkeggv?.OutpatientVisit1, l_);
			bool? n_ = context.Operators.SameOrAfter(tuple_cmsergtjgkisksqucnzwkeggv?.OutpatientVisit2, m_, default);

			return n_;
		};
		IEnumerable<(CqlDate OutpatientVisit1, CqlDate OutpatientVisit2)?> g_ = context.Operators.Where<(CqlDate OutpatientVisit1, CqlDate OutpatientVisit2)?>(e_, f_);
		CqlDate h_((CqlDate OutpatientVisit1, CqlDate OutpatientVisit2)? tuple_cmsergtjgkisksqucnzwkeggv) => 
			tuple_cmsergtjgkisksqucnzwkeggv?.OutpatientVisit1;
		IEnumerable<CqlDate> i_ = context.Operators.Select<(CqlDate OutpatientVisit1, CqlDate OutpatientVisit2)?, CqlDate>(g_, h_);
		bool? j_ = context.Operators.Exists<CqlDate>(i_);

		return j_;
	}

    [CqlDeclaration("Two Outpatient Visits with Advanced Illness on Different Dates of Service")]
	public bool? Two_Outpatient_Visits_with_Advanced_Illness_on_Different_Dates_of_Service() => 
		__Two_Outpatient_Visits_with_Advanced_Illness_on_Different_Dates_of_Service.Value;

	private bool? Acute_Inpatient_Encounter_with_Advanced_Illness_Value()
	{
		CqlValueSet a_ = this.Acute_Inpatient();
		IEnumerable<Encounter> b_ = context.Operators.RetrieveByValueSet<Encounter>(a_, default);
		IEnumerable<Encounter> c_ = NCQAStatus_1_0_0.Finished_Encounter(b_);
		bool? d_(Encounter InpatientEncounter)
		{
			CqlValueSet g_ = this.Advanced_Illness();
			IEnumerable<Condition> h_ = context.Operators.RetrieveByValueSet<Condition>(g_, default);
			bool? i_ = NCQAEncounter_1_0_0.Encounter_Has_Diagnosis(InpatientEncounter, h_);
			Period j_ = InpatientEncounter?.Period;
			CqlInterval<CqlDateTime> k_ = NCQAFHIRBase_1_0_0.Normalize_Interval(j_ as object);
			CqlDateTime l_ = context.Operators.Start(k_);
			CqlDate m_ = context.Operators.DateFrom(l_);
			CqlInterval<CqlDateTime> n_ = this.Measurement_Period();
			CqlDateTime o_ = context.Operators.Start(n_);
			CqlDate p_ = context.Operators.DateFrom(o_);
			CqlQuantity q_ = context.Operators.Quantity(1m, "year");
			CqlDate r_ = context.Operators.Subtract(p_, q_);
			CqlDateTime t_ = context.Operators.End(n_);
			CqlDate u_ = context.Operators.DateFrom(t_);
			CqlInterval<CqlDate> v_ = context.Operators.Interval(r_, u_, true, true);
			bool? w_ = context.Operators.In<CqlDate>(m_, v_, default);
			bool? x_ = context.Operators.And(i_, w_);

			return x_;
		};
		IEnumerable<Encounter> e_ = context.Operators.Where<Encounter>(c_, d_);
		bool? f_ = context.Operators.Exists<Encounter>(e_);

		return f_;
	}

    [CqlDeclaration("Acute Inpatient Encounter with Advanced Illness")]
	public bool? Acute_Inpatient_Encounter_with_Advanced_Illness() => 
		__Acute_Inpatient_Encounter_with_Advanced_Illness.Value;

	private bool? Acute_Inpatient_Discharge_with_Advanced_Illness_Value()
	{
		IEnumerable<Claim> a_ = context.Operators.RetrieveByValueSet<Claim>(default, default);
		(IEnumerable<Claim> InpatientDischarge, IEnumerable<Claim> NonacuteInpatientDischarge, IEnumerable<Claim> AcuteInpatientDischarge)? b_ = NCQAClaims_1_0_0.Medical_Claims_With_Nonacute_or_Acute_Inpatient_Discharge(a_);
		IEnumerable<Claim> c_ = b_?.AcuteInpatientDischarge;
		CqlValueSet d_ = this.Advanced_Illness();
		IValueSetFacade e_ = context.Operators.CreateValueSetFacade(d_);
		(IEnumerable<Claim> Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? f_ = NCQAClaims_1_0_0.Medical_Claims_With_Diagnosis(c_, e_);
		IEnumerable<CqlInterval<CqlDateTime>> g_ = f_?.ServicePeriod;
		bool? h_(CqlInterval<CqlDateTime> InpatientDischarge)
		{
			CqlDateTime k_ = context.Operators.End(InpatientDischarge);
			CqlDate l_ = context.Operators.DateFrom(k_);
			CqlInterval<CqlDateTime> m_ = this.Measurement_Period();
			CqlDateTime n_ = context.Operators.Start(m_);
			CqlDate o_ = context.Operators.DateFrom(n_);
			CqlQuantity p_ = context.Operators.Quantity(1m, "year");
			CqlDate q_ = context.Operators.Subtract(o_, p_);
			CqlDateTime s_ = context.Operators.End(m_);
			CqlDate t_ = context.Operators.DateFrom(s_);
			CqlInterval<CqlDate> u_ = context.Operators.Interval(q_, t_, true, true);
			bool? v_ = context.Operators.In<CqlDate>(l_, u_, default);

			return v_;
		};
		IEnumerable<CqlInterval<CqlDateTime>> i_ = context.Operators.Where<CqlInterval<CqlDateTime>>(g_, h_);
		bool? j_ = context.Operators.Exists<CqlInterval<CqlDateTime>>(i_);

		return j_;
	}

    [CqlDeclaration("Acute Inpatient Discharge with Advanced Illness")]
	public bool? Acute_Inpatient_Discharge_with_Advanced_Illness() => 
		__Acute_Inpatient_Discharge_with_Advanced_Illness.Value;

	private bool? Dementia_Medications_In_Year_Before_or_During_Measurement_Period_Value()
	{
		CqlValueSet a_ = this.Dementia_Medications();
		IEnumerable<MedicationDispense> b_ = context.Operators.RetrieveByValueSet<MedicationDispense>(a_, default);
		IEnumerable<MedicationDispense> d_ = context.Operators.RetrieveByValueSet<MedicationDispense>(a_, default);
		IEnumerable<MedicationDispense> e_ = context.Operators.Union<MedicationDispense>(b_, d_);
		IEnumerable<MedicationDispense> f_ = NCQAStatus_1_0_0.Dispensed_Medication(e_);
		bool? g_(MedicationDispense DementiaMedDispensed)
		{
			FhirDateTime j_ = DementiaMedDispensed?.WhenHandedOverElement;
			CqlInterval<CqlDateTime> k_ = NCQAFHIRBase_1_0_0.Normalize_Interval(j_ as object);
			CqlDateTime l_ = context.Operators.Start(k_);
			CqlDate m_ = context.Operators.DateFrom(l_);
			CqlInterval<CqlDateTime> n_ = this.Measurement_Period();
			CqlDateTime o_ = context.Operators.Start(n_);
			CqlDate p_ = context.Operators.DateFrom(o_);
			CqlQuantity q_ = context.Operators.Quantity(1m, "year");
			CqlDate r_ = context.Operators.Subtract(p_, q_);
			CqlDateTime t_ = context.Operators.End(n_);
			CqlDate u_ = context.Operators.DateFrom(t_);
			CqlInterval<CqlDate> v_ = context.Operators.Interval(r_, u_, true, true);
			bool? w_ = context.Operators.In<CqlDate>(m_, v_, default);

			return w_;
		};
		IEnumerable<MedicationDispense> h_ = context.Operators.Where<MedicationDispense>(f_, g_);
		bool? i_ = context.Operators.Exists<MedicationDispense>(h_);

		return i_;
	}

    [CqlDeclaration("Dementia Medications In Year Before or During Measurement Period")]
	public bool? Dementia_Medications_In_Year_Before_or_During_Measurement_Period() => 
		__Dementia_Medications_In_Year_Before_or_During_Measurement_Period.Value;

	private bool? Advanced_Illness_and_Frailty_Exclusion_Including_Over_Age_80_Value()
	{
		Patient a_ = this.Patient();
		Date b_ = a_?.BirthDateElement;
		string c_ = b_?.Value;
		CqlDate d_ = context.Operators.ConvertStringToDate(c_);
		CqlInterval<CqlDateTime> e_ = this.Measurement_Period();
		CqlDateTime f_ = context.Operators.End(e_);
		CqlDate g_ = context.Operators.DateFrom(f_);
		int? h_ = context.Operators.CalculateAgeAt(d_, g_, "year");
		CqlInterval<int?> i_ = context.Operators.Interval(66, 80, true, true);
		bool? j_ = context.Operators.In<int?>(h_, i_, default);
		bool? k_ = this.Has_Criteria_Indicating_Frailty();
		bool? l_ = context.Operators.And(j_, k_);
		bool? m_ = this.Two_Outpatient_Visits_with_Advanced_Illness_on_Different_Dates_of_Service();
		bool? n_ = this.Acute_Inpatient_Encounter_with_Advanced_Illness();
		bool? o_ = context.Operators.Or(m_, n_);
		bool? p_ = this.Acute_Inpatient_Discharge_with_Advanced_Illness();
		bool? q_ = context.Operators.Or(o_, p_);
		bool? r_ = this.Dementia_Medications_In_Year_Before_or_During_Measurement_Period();
		bool? s_ = context.Operators.Or(q_, r_);
		bool? t_ = context.Operators.And(l_, s_);
		Date v_ = a_?.BirthDateElement;
		string w_ = v_?.Value;
		CqlDate x_ = context.Operators.ConvertStringToDate(w_);
		CqlDateTime z_ = context.Operators.End(e_);
		CqlDate aa_ = context.Operators.DateFrom(z_);
		int? ab_ = context.Operators.CalculateAgeAt(x_, aa_, "year");
		bool? ac_ = context.Operators.GreaterOrEqual(ab_, 81);
		bool? ae_ = context.Operators.And(ac_, k_);
		bool? af_ = context.Operators.Or(t_, ae_);

		return af_;
	}

    [CqlDeclaration("Advanced Illness and Frailty Exclusion Including Over Age 80")]
	public bool? Advanced_Illness_and_Frailty_Exclusion_Including_Over_Age_80() => 
		__Advanced_Illness_and_Frailty_Exclusion_Including_Over_Age_80.Value;

	private bool? Advanced_Illness_and_Frailty_Exclusion_Not_Including_Over_Age_80_Value()
	{
		Patient a_ = this.Patient();
		Date b_ = a_?.BirthDateElement;
		string c_ = b_?.Value;
		CqlDate d_ = context.Operators.ConvertStringToDate(c_);
		CqlInterval<CqlDateTime> e_ = this.Measurement_Period();
		CqlDateTime f_ = context.Operators.End(e_);
		CqlDate g_ = context.Operators.DateFrom(f_);
		int? h_ = context.Operators.CalculateAgeAt(d_, g_, "year");
		bool? i_ = context.Operators.GreaterOrEqual(h_, 66);
		bool? j_ = this.Has_Criteria_Indicating_Frailty();
		bool? k_ = context.Operators.And(i_, j_);
		bool? l_ = this.Two_Outpatient_Visits_with_Advanced_Illness_on_Different_Dates_of_Service();
		bool? m_ = this.Acute_Inpatient_Encounter_with_Advanced_Illness();
		bool? n_ = context.Operators.Or(l_, m_);
		bool? o_ = this.Acute_Inpatient_Discharge_with_Advanced_Illness();
		bool? p_ = context.Operators.Or(n_, o_);
		bool? q_ = this.Dementia_Medications_In_Year_Before_or_During_Measurement_Period();
		bool? r_ = context.Operators.Or(p_, q_);
		bool? s_ = context.Operators.And(k_, r_);

		return s_;
	}

    [CqlDeclaration("Advanced Illness and Frailty Exclusion Not Including Over Age 80")]
	public bool? Advanced_Illness_and_Frailty_Exclusion_Not_Including_Over_Age_80() => 
		__Advanced_Illness_and_Frailty_Exclusion_Not_Including_Over_Age_80.Value;

}
