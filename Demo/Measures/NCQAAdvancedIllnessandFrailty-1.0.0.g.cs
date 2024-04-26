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
		object a_ = context.ResolveParameter("NCQAAdvancedIllnessandFrailty-1.0.0", "Measurement Period", null);

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

	private bool? Has_Criteria_Indicating_Frailty_Value()
	{
		CqlValueSet a_ = this.Frailty_Device();
		IEnumerable<Observation> b_ = context.Operators.RetrieveByValueSet<Observation>(a_, null);
		bool? c_(Observation FrailtyDeviceApplied)
		{
			CqlInterval<CqlDateTime> z_ = NCQAFHIRBase_1_0_0.Normalize_Interval(FrailtyDeviceApplied?.Effective);
			CqlInterval<CqlDateTime> aa_ = this.Measurement_Period();
			bool? ab_ = context.Operators.Overlaps(z_, aa_, null);

			return ab_;
		};
		IEnumerable<Observation> d_ = context.Operators.Where<Observation>(b_, c_);
		bool? e_ = context.Operators.Exists<Observation>(d_);
		CqlValueSet f_ = this.Frailty_Diagnosis();
		IEnumerable<Condition> g_ = context.Operators.RetrieveByValueSet<Condition>(f_, null);
		IEnumerable<Condition> h_ = NCQAStatus_1_0_0.Active_Condition(g_);
		bool? i_(Condition FrailtyDiagnosis)
		{
			CqlInterval<CqlDateTime> ac_ = NCQAFHIRBase_1_0_0.Prevalence_Period(FrailtyDiagnosis);
			CqlInterval<CqlDateTime> ad_ = this.Measurement_Period();
			bool? ae_ = context.Operators.Overlaps(ac_, ad_, null);

			return ae_;
		};
		IEnumerable<Condition> j_ = context.Operators.Where<Condition>(h_, i_);
		bool? k_ = context.Operators.Exists<Condition>(j_);
		bool? l_ = context.Operators.Or(e_, k_);
		CqlValueSet m_ = this.Frailty_Encounter();
		IEnumerable<Encounter> n_ = context.Operators.RetrieveByValueSet<Encounter>(m_, null);
		IEnumerable<Encounter> o_ = NCQAStatus_1_0_0.Finished_Encounter(n_);
		bool? p_(Encounter FrailtyEncounter)
		{
			CqlInterval<CqlDateTime> af_ = NCQAFHIRBase_1_0_0.Normalize_Interval((FrailtyEncounter?.Period as object));
			CqlInterval<CqlDateTime> ag_ = this.Measurement_Period();
			bool? ah_ = context.Operators.Overlaps(af_, ag_, null);

			return ah_;
		};
		IEnumerable<Encounter> q_ = context.Operators.Where<Encounter>(o_, p_);
		bool? r_ = context.Operators.Exists<Encounter>(q_);
		bool? s_ = context.Operators.Or(l_, r_);
		CqlValueSet t_ = this.Frailty_Symptom();
		IEnumerable<Observation> u_ = context.Operators.RetrieveByValueSet<Observation>(t_, null);
		bool? v_(Observation FrailtySymptom)
		{
			CqlInterval<CqlDateTime> ai_ = NCQAFHIRBase_1_0_0.Normalize_Interval(FrailtySymptom?.Effective);
			CqlInterval<CqlDateTime> aj_ = this.Measurement_Period();
			bool? ak_ = context.Operators.Overlaps(ai_, aj_, null);

			return ak_;
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
		IEnumerable<Encounter> b_ = context.Operators.RetrieveByValueSet<Encounter>(a_, null);
		CqlValueSet c_ = this.Observation();
		IEnumerable<Encounter> d_ = context.Operators.RetrieveByValueSet<Encounter>(c_, null);
		IEnumerable<Encounter> e_ = context.Operators.ListUnion<Encounter>(b_, d_);
		CqlValueSet f_ = this.ED();
		IEnumerable<Encounter> g_ = context.Operators.RetrieveByValueSet<Encounter>(f_, null);
		CqlValueSet h_ = this.Telephone_Visits();
		IEnumerable<Encounter> i_ = context.Operators.RetrieveByValueSet<Encounter>(h_, null);
		IEnumerable<Encounter> j_ = context.Operators.ListUnion<Encounter>(g_, i_);
		IEnumerable<Encounter> k_ = context.Operators.ListUnion<Encounter>(e_, j_);
		CqlValueSet l_ = this.Online_Assessments();
		IEnumerable<Encounter> m_ = context.Operators.RetrieveByValueSet<Encounter>(l_, null);
		CqlValueSet n_ = this.Nonacute_Inpatient();
		IEnumerable<Encounter> o_ = context.Operators.RetrieveByValueSet<Encounter>(n_, null);
		IEnumerable<Encounter> p_ = context.Operators.ListUnion<Encounter>(m_, o_);
		IEnumerable<Encounter> q_ = context.Operators.ListUnion<Encounter>(k_, p_);
		IEnumerable<Encounter> r_ = NCQAStatus_1_0_0.Finished_Encounter(q_);
		bool? s_(Encounter OutpatientEncounter)
		{
			CqlValueSet w_ = this.Advanced_Illness();
			IEnumerable<Condition> x_ = context.Operators.RetrieveByValueSet<Condition>(w_, null);
			bool? y_ = NCQAEncounter_1_0_0.Encounter_Has_Diagnosis(OutpatientEncounter, x_);
			CqlInterval<CqlDateTime> z_ = NCQAFHIRBase_1_0_0.Normalize_Interval((OutpatientEncounter?.Period as object));
			CqlDateTime aa_ = context.Operators.Start(z_);
			CqlDate ab_ = context.Operators.DateFrom(aa_);
			CqlInterval<CqlDateTime> ac_ = this.Measurement_Period();
			CqlDateTime ad_ = context.Operators.Start(ac_);
			CqlDate ae_ = context.Operators.DateFrom(ad_);
			CqlQuantity af_ = context.Operators.Quantity(1m, "year");
			CqlDate ag_ = context.Operators.Subtract(ae_, af_);
			CqlDateTime ai_ = context.Operators.End(ac_);
			CqlDate aj_ = context.Operators.DateFrom(ai_);
			CqlInterval<CqlDate> ak_ = context.Operators.Interval(ag_, aj_, true, true);
			bool? al_ = context.Operators.In<CqlDate>(ab_, ak_, null);
			bool? am_ = context.Operators.And(y_, al_);

			return am_;
		};
		IEnumerable<Encounter> t_ = context.Operators.Where<Encounter>(r_, s_);
		CqlDate u_(Encounter EncounterWithDiagnosis)
		{
			CqlInterval<CqlDateTime> an_ = NCQAFHIRBase_1_0_0.Normalize_Interval((EncounterWithDiagnosis?.Period as object));
			CqlDateTime ao_ = context.Operators.End(an_);
			CqlDate ap_ = context.Operators.DateFrom(ao_);

			return ap_;
		};
		IEnumerable<CqlDate> v_ = context.Operators.Select<Encounter, CqlDate>(t_, u_);

		return v_;
	}

    [CqlDeclaration("Outpatient Encounters with Advanced Illness")]
	public IEnumerable<CqlDate> Outpatient_Encounters_with_Advanced_Illness() => 
		__Outpatient_Encounters_with_Advanced_Illness.Value;

	private IEnumerable<CqlDate> Nonacute_Inpatient_Discharge_with_Advanced_Illness_Value()
	{
		IEnumerable<Claim> a_ = context.Operators.RetrieveByValueSet<Claim>(null, null);
		Tuple_CYfZbbEjJgLODachBhLiZaXQE b_ = NCQAClaims_1_0_0.Medical_Claims_With_Nonacute_or_Acute_Inpatient_Discharge(a_);
		CqlValueSet c_ = this.Advanced_Illness();
		IValueSetFacade d_ = context.Operators.CreateValueSetFacade(c_);
		Tuple_HLLRUdKceDPKeIXGFiiNKjMKI e_ = NCQAClaims_1_0_0.Medical_Claims_With_Diagnosis(b_?.NonacuteInpatientDischarge, (d_ as IEnumerable<CqlCode>));
		bool? f_(CqlInterval<CqlDateTime> DischargeWithDiagnosis)
		{
			CqlDateTime j_ = context.Operators.End(DischargeWithDiagnosis);
			CqlDate k_ = context.Operators.DateFrom(j_);
			CqlInterval<CqlDateTime> l_ = this.Measurement_Period();
			CqlDateTime m_ = context.Operators.Start(l_);
			CqlDate n_ = context.Operators.DateFrom(m_);
			CqlQuantity o_ = context.Operators.Quantity(1m, "year");
			CqlDate p_ = context.Operators.Subtract(n_, o_);
			CqlDateTime r_ = context.Operators.End(l_);
			CqlDate s_ = context.Operators.DateFrom(r_);
			CqlInterval<CqlDate> t_ = context.Operators.Interval(p_, s_, true, true);
			bool? u_ = context.Operators.In<CqlDate>(k_, t_, null);

			return u_;
		};
		IEnumerable<CqlInterval<CqlDateTime>> g_ = context.Operators.Where<CqlInterval<CqlDateTime>>(e_?.ServicePeriod, f_);
		CqlDate h_(CqlInterval<CqlDateTime> InpatientDischarge)
		{
			CqlDateTime v_ = context.Operators.End(InpatientDischarge);
			CqlDate w_ = context.Operators.DateFrom(v_);

			return w_;
		};
		IEnumerable<CqlDate> i_ = context.Operators.Select<CqlInterval<CqlDateTime>, CqlDate>(g_, h_);

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
				IEnumerable<CqlDate> c_ = this.Outpatient_Encounters_with_Advanced_Illness();
				IEnumerable<CqlDate> d_ = this.Nonacute_Inpatient_Discharge_with_Advanced_Illness();
				IEnumerable<CqlDate> e_ = context.Operators.ListUnion<CqlDate>(c_, d_);
				bool? f_ = context.Operators.Not((bool?)(e_ is null));

				return (f_ ?? false);
			};
			if (b_())
			{
				IEnumerable<CqlDate> g_ = this.Outpatient_Encounters_with_Advanced_Illness();
				IEnumerable<CqlDate> h_ = this.Nonacute_Inpatient_Discharge_with_Advanced_Illness();
				IEnumerable<CqlDate> i_ = context.Operators.ListUnion<CqlDate>(g_, h_);

				return i_;
			}
			else if ((this.Outpatient_Encounters_with_Advanced_Illness() is null))
			{
				IEnumerable<CqlDate> j_ = this.Nonacute_Inpatient_Discharge_with_Advanced_Illness();

				return j_;
			}
			else if ((this.Nonacute_Inpatient_Discharge_with_Advanced_Illness() is null))
			{
				IEnumerable<CqlDate> k_ = this.Outpatient_Encounters_with_Advanced_Illness();

				return k_;
			}
			else
			{
				IEnumerable<CqlDate> l_ = null;

				return l_;
			};
		};

		return a_();
	}

    [CqlDeclaration("Outpatient Encounters or Discharges with Advanced Illness")]
	public IEnumerable<CqlDate> Outpatient_Encounters_or_Discharges_with_Advanced_Illness() => 
		__Outpatient_Encounters_or_Discharges_with_Advanced_Illness.Value;

	private bool? Two_Outpatient_Visits_with_Advanced_Illness_on_Different_Dates_of_Service_Value()
	{
		IEnumerable<CqlDate> a_ = this.Outpatient_Encounters_or_Discharges_with_Advanced_Illness();
		IEnumerable<ValueTuple<CqlDate,CqlDate>> c_ = context.Operators.CrossJoin<CqlDate, CqlDate>(a_, a_);
		Tuple_EaBFagdYTZfYEiNNhIYITEIUR d_(ValueTuple<CqlDate,CqlDate> _valueTuple)
		{
			Tuple_EaBFagdYTZfYEiNNhIYITEIUR k_ = new Tuple_EaBFagdYTZfYEiNNhIYITEIUR
			{
				OutpatientVisit1 = _valueTuple.Item1,
				OutpatientVisit2 = _valueTuple.Item2,
			};

			return k_;
		};
		IEnumerable<Tuple_EaBFagdYTZfYEiNNhIYITEIUR> e_ = context.Operators.Select<ValueTuple<CqlDate,CqlDate>, Tuple_EaBFagdYTZfYEiNNhIYITEIUR>(c_, d_);
		bool? f_(Tuple_EaBFagdYTZfYEiNNhIYITEIUR tuple_eabfagdytzfyeinnhiyiteiur)
		{
			CqlQuantity l_ = context.Operators.Quantity(1m, "day");
			CqlDate m_ = context.Operators.Add(tuple_eabfagdytzfyeinnhiyiteiur.OutpatientVisit1, l_);
			bool? n_ = context.Operators.SameOrAfter(tuple_eabfagdytzfyeinnhiyiteiur.OutpatientVisit2, m_, null);

			return n_;
		};
		IEnumerable<Tuple_EaBFagdYTZfYEiNNhIYITEIUR> g_ = context.Operators.Where<Tuple_EaBFagdYTZfYEiNNhIYITEIUR>(e_, f_);
		CqlDate h_(Tuple_EaBFagdYTZfYEiNNhIYITEIUR tuple_eabfagdytzfyeinnhiyiteiur) => 
			tuple_eabfagdytzfyeinnhiyiteiur.OutpatientVisit1;
		IEnumerable<CqlDate> i_ = context.Operators.Select<Tuple_EaBFagdYTZfYEiNNhIYITEIUR, CqlDate>(g_, h_);
		bool? j_ = context.Operators.Exists<CqlDate>(i_);

		return j_;
	}

    [CqlDeclaration("Two Outpatient Visits with Advanced Illness on Different Dates of Service")]
	public bool? Two_Outpatient_Visits_with_Advanced_Illness_on_Different_Dates_of_Service() => 
		__Two_Outpatient_Visits_with_Advanced_Illness_on_Different_Dates_of_Service.Value;

	private bool? Acute_Inpatient_Encounter_with_Advanced_Illness_Value()
	{
		CqlValueSet a_ = this.Acute_Inpatient();
		IEnumerable<Encounter> b_ = context.Operators.RetrieveByValueSet<Encounter>(a_, null);
		IEnumerable<Encounter> c_ = NCQAStatus_1_0_0.Finished_Encounter(b_);
		bool? d_(Encounter InpatientEncounter)
		{
			CqlValueSet g_ = this.Advanced_Illness();
			IEnumerable<Condition> h_ = context.Operators.RetrieveByValueSet<Condition>(g_, null);
			bool? i_ = NCQAEncounter_1_0_0.Encounter_Has_Diagnosis(InpatientEncounter, h_);
			CqlInterval<CqlDateTime> j_ = NCQAFHIRBase_1_0_0.Normalize_Interval((InpatientEncounter?.Period as object));
			CqlDateTime k_ = context.Operators.Start(j_);
			CqlDate l_ = context.Operators.DateFrom(k_);
			CqlInterval<CqlDateTime> m_ = this.Measurement_Period();
			CqlDateTime n_ = context.Operators.Start(m_);
			CqlDate o_ = context.Operators.DateFrom(n_);
			CqlQuantity p_ = context.Operators.Quantity(1m, "year");
			CqlDate q_ = context.Operators.Subtract(o_, p_);
			CqlDateTime s_ = context.Operators.End(m_);
			CqlDate t_ = context.Operators.DateFrom(s_);
			CqlInterval<CqlDate> u_ = context.Operators.Interval(q_, t_, true, true);
			bool? v_ = context.Operators.In<CqlDate>(l_, u_, null);
			bool? w_ = context.Operators.And(i_, v_);

			return w_;
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
		IEnumerable<Claim> a_ = context.Operators.RetrieveByValueSet<Claim>(null, null);
		Tuple_CYfZbbEjJgLODachBhLiZaXQE b_ = NCQAClaims_1_0_0.Medical_Claims_With_Nonacute_or_Acute_Inpatient_Discharge(a_);
		CqlValueSet c_ = this.Advanced_Illness();
		IValueSetFacade d_ = context.Operators.CreateValueSetFacade(c_);
		Tuple_HLLRUdKceDPKeIXGFiiNKjMKI e_ = NCQAClaims_1_0_0.Medical_Claims_With_Diagnosis(b_?.AcuteInpatientDischarge, (d_ as IEnumerable<CqlCode>));
		bool? f_(CqlInterval<CqlDateTime> InpatientDischarge)
		{
			CqlDateTime i_ = context.Operators.End(InpatientDischarge);
			CqlDate j_ = context.Operators.DateFrom(i_);
			CqlInterval<CqlDateTime> k_ = this.Measurement_Period();
			CqlDateTime l_ = context.Operators.Start(k_);
			CqlDate m_ = context.Operators.DateFrom(l_);
			CqlQuantity n_ = context.Operators.Quantity(1m, "year");
			CqlDate o_ = context.Operators.Subtract(m_, n_);
			CqlDateTime q_ = context.Operators.End(k_);
			CqlDate r_ = context.Operators.DateFrom(q_);
			CqlInterval<CqlDate> s_ = context.Operators.Interval(o_, r_, true, true);
			bool? t_ = context.Operators.In<CqlDate>(j_, s_, null);

			return t_;
		};
		IEnumerable<CqlInterval<CqlDateTime>> g_ = context.Operators.Where<CqlInterval<CqlDateTime>>(e_?.ServicePeriod, f_);
		bool? h_ = context.Operators.Exists<CqlInterval<CqlDateTime>>(g_);

		return h_;
	}

    [CqlDeclaration("Acute Inpatient Discharge with Advanced Illness")]
	public bool? Acute_Inpatient_Discharge_with_Advanced_Illness() => 
		__Acute_Inpatient_Discharge_with_Advanced_Illness.Value;

	private bool? Dementia_Medications_In_Year_Before_or_During_Measurement_Period_Value()
	{
		CqlValueSet a_ = this.Dementia_Medications();
		IEnumerable<MedicationDispense> b_ = context.Operators.RetrieveByValueSet<MedicationDispense>(a_, null);
		IEnumerable<MedicationDispense> d_ = context.Operators.RetrieveByValueSet<MedicationDispense>(a_, null);
		IEnumerable<MedicationDispense> e_ = context.Operators.ListUnion<MedicationDispense>(b_, d_);
		IEnumerable<MedicationDispense> f_ = NCQAStatus_1_0_0.Dispensed_Medication(e_);
		bool? g_(MedicationDispense DementiaMedDispensed)
		{
			CqlInterval<CqlDateTime> j_ = NCQAFHIRBase_1_0_0.Normalize_Interval((DementiaMedDispensed?.WhenHandedOverElement as object));
			CqlDateTime k_ = context.Operators.Start(j_);
			CqlDate l_ = context.Operators.DateFrom(k_);
			CqlInterval<CqlDateTime> m_ = this.Measurement_Period();
			CqlDateTime n_ = context.Operators.Start(m_);
			CqlDate o_ = context.Operators.DateFrom(n_);
			CqlQuantity p_ = context.Operators.Quantity(1m, "year");
			CqlDate q_ = context.Operators.Subtract(o_, p_);
			CqlDateTime s_ = context.Operators.End(m_);
			CqlDate t_ = context.Operators.DateFrom(s_);
			CqlInterval<CqlDate> u_ = context.Operators.Interval(q_, t_, true, true);
			bool? v_ = context.Operators.In<CqlDate>(l_, u_, null);

			return v_;
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
		CqlDate b_ = context.Operators.Convert<CqlDate>(a_?.BirthDateElement?.Value);
		CqlInterval<CqlDateTime> c_ = this.Measurement_Period();
		CqlDateTime d_ = context.Operators.End(c_);
		CqlDate e_ = context.Operators.DateFrom(d_);
		int? f_ = context.Operators.CalculateAgeAt(b_, e_, "year");
		CqlInterval<int?> g_ = context.Operators.Interval(66, 80, true, true);
		bool? h_ = context.Operators.In<int?>(f_, g_, null);
		bool? i_ = this.Has_Criteria_Indicating_Frailty();
		bool? j_ = context.Operators.And(h_, i_);
		bool? k_ = this.Two_Outpatient_Visits_with_Advanced_Illness_on_Different_Dates_of_Service();
		bool? l_ = this.Acute_Inpatient_Encounter_with_Advanced_Illness();
		bool? m_ = context.Operators.Or(k_, l_);
		bool? n_ = this.Acute_Inpatient_Discharge_with_Advanced_Illness();
		bool? o_ = context.Operators.Or(m_, n_);
		bool? p_ = this.Dementia_Medications_In_Year_Before_or_During_Measurement_Period();
		bool? q_ = context.Operators.Or(o_, p_);
		bool? r_ = context.Operators.And(j_, q_);
		CqlDate t_ = context.Operators.Convert<CqlDate>(a_?.BirthDateElement?.Value);
		CqlDateTime v_ = context.Operators.End(c_);
		CqlDate w_ = context.Operators.DateFrom(v_);
		int? x_ = context.Operators.CalculateAgeAt(t_, w_, "year");
		bool? y_ = context.Operators.GreaterOrEqual(x_, 81);
		bool? aa_ = context.Operators.And(y_, i_);
		bool? ab_ = context.Operators.Or(r_, aa_);

		return ab_;
	}

    [CqlDeclaration("Advanced Illness and Frailty Exclusion Including Over Age 80")]
	public bool? Advanced_Illness_and_Frailty_Exclusion_Including_Over_Age_80() => 
		__Advanced_Illness_and_Frailty_Exclusion_Including_Over_Age_80.Value;

	private bool? Advanced_Illness_and_Frailty_Exclusion_Not_Including_Over_Age_80_Value()
	{
		Patient a_ = this.Patient();
		CqlDate b_ = context.Operators.Convert<CqlDate>(a_?.BirthDateElement?.Value);
		CqlInterval<CqlDateTime> c_ = this.Measurement_Period();
		CqlDateTime d_ = context.Operators.End(c_);
		CqlDate e_ = context.Operators.DateFrom(d_);
		int? f_ = context.Operators.CalculateAgeAt(b_, e_, "year");
		bool? g_ = context.Operators.GreaterOrEqual(f_, 66);
		bool? h_ = this.Has_Criteria_Indicating_Frailty();
		bool? i_ = context.Operators.And(g_, h_);
		bool? j_ = this.Two_Outpatient_Visits_with_Advanced_Illness_on_Different_Dates_of_Service();
		bool? k_ = this.Acute_Inpatient_Encounter_with_Advanced_Illness();
		bool? l_ = context.Operators.Or(j_, k_);
		bool? m_ = this.Acute_Inpatient_Discharge_with_Advanced_Illness();
		bool? n_ = context.Operators.Or(l_, m_);
		bool? o_ = this.Dementia_Medications_In_Year_Before_or_During_Measurement_Period();
		bool? p_ = context.Operators.Or(n_, o_);
		bool? q_ = context.Operators.And(i_, p_);

		return q_;
	}

    [CqlDeclaration("Advanced Illness and Frailty Exclusion Not Including Over Age 80")]
	public bool? Advanced_Illness_and_Frailty_Exclusion_Not_Including_Over_Age_80() => 
		__Advanced_Illness_and_Frailty_Exclusion_Not_Including_Over_Age_80.Value;

}
