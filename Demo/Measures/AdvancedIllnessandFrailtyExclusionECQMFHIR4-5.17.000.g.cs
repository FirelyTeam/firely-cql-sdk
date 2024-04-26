using System;
using Tuples;
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
[CqlLibrary("AdvancedIllnessandFrailtyExclusionECQMFHIR4", "5.17.000")]
public class AdvancedIllnessandFrailtyExclusionECQMFHIR4_5_17_000
{


    internal CqlContext context;

    #region Cached values

    internal Lazy<CqlValueSet> __Acute_Inpatient;
    internal Lazy<CqlValueSet> __Advanced_Illness;
    internal Lazy<CqlValueSet> __Care_Services_in_Long_Term_Residential_Facility;
    internal Lazy<CqlValueSet> __Dementia_Medications;
    internal Lazy<CqlValueSet> __Emergency_Department_Visit;
    internal Lazy<CqlValueSet> __Frailty_Device;
    internal Lazy<CqlValueSet> __Frailty_Diagnosis;
    internal Lazy<CqlValueSet> __Frailty_Encounter;
    internal Lazy<CqlValueSet> __Frailty_Symptom;
    internal Lazy<CqlValueSet> __Nonacute_Inpatient;
    internal Lazy<CqlValueSet> __Nursing_Facility_Visit;
    internal Lazy<CqlValueSet> __Observation;
    internal Lazy<CqlValueSet> __Outpatient;
    internal Lazy<CqlInterval<CqlDateTime>> __Measurement_Period;
    internal Lazy<Patient> __Patient;
    internal Lazy<IEnumerable<MedicationRequest>> __Dementia_Medications_In_Year_Before_or_During_Measurement_Period;
    internal Lazy<IEnumerable<CqlInterval<CqlDateTime>>> __Long_Term_Care_Periods_During_Measurement_Period;
    internal Lazy<IEnumerable<Encounter>> __Outpatient_Encounters_with_Advanced_Illness;
    internal Lazy<IEnumerable<Encounter>> __Two_Outpatient_Encounters_with_Advanced_Illness_on_Different_Dates_of_Service;
    internal Lazy<IEnumerable<CqlInterval<CqlDateTime>>> __Long_Term_Care_Overlapping_Periods;
    internal Lazy<IEnumerable<CqlInterval<CqlDateTime>>> __Long_Term_Care_Adjacent_Periods;
    internal Lazy<int?> __Max_Long_Term_Care_Period_Length;
    internal Lazy<IEnumerable<Encounter>> __Inpatient_Encounter_with_Advanced_Illness;
    internal Lazy<bool?> __Has_Criteria_Indicating_Frailty;
    internal Lazy<bool?> __Advanced_Illness_and_Frailty_Exclusion_Including_Over_Age_80;
    internal Lazy<bool?> __Advanced_Illness_and_Frailty_Exclusion_Not_Including_Over_Age_80;
    internal Lazy<bool?> __Has_Long_Term_Care_Periods_Longer_Than_90_Consecutive_Days;

    #endregion
    public AdvancedIllnessandFrailtyExclusionECQMFHIR4_5_17_000(CqlContext context)
    {
        this.context = context ?? throw new ArgumentNullException("context");

        FHIRHelpers_4_0_001 = new FHIRHelpers_4_0_001(context);
        MATGlobalCommonFunctionsFHIR4_6_1_000 = new MATGlobalCommonFunctionsFHIR4_6_1_000(context);
        CumulativeMedicationDurationFHIR4_1_0_000 = new CumulativeMedicationDurationFHIR4_1_0_000(context);

        __Acute_Inpatient = new Lazy<CqlValueSet>(this.Acute_Inpatient_Value);
        __Advanced_Illness = new Lazy<CqlValueSet>(this.Advanced_Illness_Value);
        __Care_Services_in_Long_Term_Residential_Facility = new Lazy<CqlValueSet>(this.Care_Services_in_Long_Term_Residential_Facility_Value);
        __Dementia_Medications = new Lazy<CqlValueSet>(this.Dementia_Medications_Value);
        __Emergency_Department_Visit = new Lazy<CqlValueSet>(this.Emergency_Department_Visit_Value);
        __Frailty_Device = new Lazy<CqlValueSet>(this.Frailty_Device_Value);
        __Frailty_Diagnosis = new Lazy<CqlValueSet>(this.Frailty_Diagnosis_Value);
        __Frailty_Encounter = new Lazy<CqlValueSet>(this.Frailty_Encounter_Value);
        __Frailty_Symptom = new Lazy<CqlValueSet>(this.Frailty_Symptom_Value);
        __Nonacute_Inpatient = new Lazy<CqlValueSet>(this.Nonacute_Inpatient_Value);
        __Nursing_Facility_Visit = new Lazy<CqlValueSet>(this.Nursing_Facility_Visit_Value);
        __Observation = new Lazy<CqlValueSet>(this.Observation_Value);
        __Outpatient = new Lazy<CqlValueSet>(this.Outpatient_Value);
        __Measurement_Period = new Lazy<CqlInterval<CqlDateTime>>(this.Measurement_Period_Value);
        __Patient = new Lazy<Patient>(this.Patient_Value);
        __Dementia_Medications_In_Year_Before_or_During_Measurement_Period = new Lazy<IEnumerable<MedicationRequest>>(this.Dementia_Medications_In_Year_Before_or_During_Measurement_Period_Value);
        __Long_Term_Care_Periods_During_Measurement_Period = new Lazy<IEnumerable<CqlInterval<CqlDateTime>>>(this.Long_Term_Care_Periods_During_Measurement_Period_Value);
        __Outpatient_Encounters_with_Advanced_Illness = new Lazy<IEnumerable<Encounter>>(this.Outpatient_Encounters_with_Advanced_Illness_Value);
        __Two_Outpatient_Encounters_with_Advanced_Illness_on_Different_Dates_of_Service = new Lazy<IEnumerable<Encounter>>(this.Two_Outpatient_Encounters_with_Advanced_Illness_on_Different_Dates_of_Service_Value);
        __Long_Term_Care_Overlapping_Periods = new Lazy<IEnumerable<CqlInterval<CqlDateTime>>>(this.Long_Term_Care_Overlapping_Periods_Value);
        __Long_Term_Care_Adjacent_Periods = new Lazy<IEnumerable<CqlInterval<CqlDateTime>>>(this.Long_Term_Care_Adjacent_Periods_Value);
        __Max_Long_Term_Care_Period_Length = new Lazy<int?>(this.Max_Long_Term_Care_Period_Length_Value);
        __Inpatient_Encounter_with_Advanced_Illness = new Lazy<IEnumerable<Encounter>>(this.Inpatient_Encounter_with_Advanced_Illness_Value);
        __Has_Criteria_Indicating_Frailty = new Lazy<bool?>(this.Has_Criteria_Indicating_Frailty_Value);
        __Advanced_Illness_and_Frailty_Exclusion_Including_Over_Age_80 = new Lazy<bool?>(this.Advanced_Illness_and_Frailty_Exclusion_Including_Over_Age_80_Value);
        __Advanced_Illness_and_Frailty_Exclusion_Not_Including_Over_Age_80 = new Lazy<bool?>(this.Advanced_Illness_and_Frailty_Exclusion_Not_Including_Over_Age_80_Value);
        __Has_Long_Term_Care_Periods_Longer_Than_90_Consecutive_Days = new Lazy<bool?>(this.Has_Long_Term_Care_Periods_Longer_Than_90_Consecutive_Days_Value);
    }
    #region Dependencies

    public FHIRHelpers_4_0_001 FHIRHelpers_4_0_001 { get; }
    public MATGlobalCommonFunctionsFHIR4_6_1_000 MATGlobalCommonFunctionsFHIR4_6_1_000 { get; }
    public CumulativeMedicationDurationFHIR4_1_0_000 CumulativeMedicationDurationFHIR4_1_0_000 { get; }

    #endregion

	private CqlValueSet Acute_Inpatient_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1083", null);

    [CqlDeclaration("Acute Inpatient")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1083")]
	public CqlValueSet Acute_Inpatient() => 
		__Acute_Inpatient.Value;

	private CqlValueSet Advanced_Illness_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.110.12.1082", null);

    [CqlDeclaration("Advanced Illness")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.110.12.1082")]
	public CqlValueSet Advanced_Illness() => 
		__Advanced_Illness.Value;

	private CqlValueSet Care_Services_in_Long_Term_Residential_Facility_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1014", null);

    [CqlDeclaration("Care Services in Long-Term Residential Facility")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1014")]
	public CqlValueSet Care_Services_in_Long_Term_Residential_Facility() => 
		__Care_Services_in_Long_Term_Residential_Facility.Value;

	private CqlValueSet Dementia_Medications_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.196.12.1510", null);

    [CqlDeclaration("Dementia Medications")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.196.12.1510")]
	public CqlValueSet Dementia_Medications() => 
		__Dementia_Medications.Value;

	private CqlValueSet Emergency_Department_Visit_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1010", null);

    [CqlDeclaration("Emergency Department Visit")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1010")]
	public CqlValueSet Emergency_Department_Visit() => 
		__Emergency_Department_Visit.Value;

	private CqlValueSet Frailty_Device_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.118.12.1300", null);

    [CqlDeclaration("Frailty Device")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.118.12.1300")]
	public CqlValueSet Frailty_Device() => 
		__Frailty_Device.Value;

	private CqlValueSet Frailty_Diagnosis_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.113.12.1074", null);

    [CqlDeclaration("Frailty Diagnosis")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.113.12.1074")]
	public CqlValueSet Frailty_Diagnosis() => 
		__Frailty_Diagnosis.Value;

	private CqlValueSet Frailty_Encounter_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1088", null);

    [CqlDeclaration("Frailty Encounter")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1088")]
	public CqlValueSet Frailty_Encounter() => 
		__Frailty_Encounter.Value;

	private CqlValueSet Frailty_Symptom_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.113.12.1075", null);

    [CqlDeclaration("Frailty Symptom")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.113.12.1075")]
	public CqlValueSet Frailty_Symptom() => 
		__Frailty_Symptom.Value;

	private CqlValueSet Nonacute_Inpatient_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1084", null);

    [CqlDeclaration("Nonacute Inpatient")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1084")]
	public CqlValueSet Nonacute_Inpatient() => 
		__Nonacute_Inpatient.Value;

	private CqlValueSet Nursing_Facility_Visit_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1012", null);

    [CqlDeclaration("Nursing Facility Visit")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1012")]
	public CqlValueSet Nursing_Facility_Visit() => 
		__Nursing_Facility_Visit.Value;

	private CqlValueSet Observation_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1086", null);

    [CqlDeclaration("Observation")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1086")]
	public CqlValueSet Observation() => 
		__Observation.Value;

	private CqlValueSet Outpatient_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1087", null);

    [CqlDeclaration("Outpatient")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1087")]
	public CqlValueSet Outpatient() => 
		__Outpatient.Value;

	private CqlInterval<CqlDateTime> Measurement_Period_Value()
	{
		object a_ = context.ResolveParameter("AdvancedIllnessandFrailtyExclusionECQMFHIR4-5.17.000", "Measurement Period", null);

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

	private IEnumerable<MedicationRequest> Dementia_Medications_In_Year_Before_or_During_Measurement_Period_Value()
	{
		CqlValueSet a_ = this.Dementia_Medications();
		IEnumerable<MedicationRequest> b_ = context.Operators.RetrieveByValueSet<MedicationRequest>(a_, null);
		IEnumerable<MedicationRequest> d_ = context.Operators.RetrieveByValueSet<MedicationRequest>(a_, null);
		IEnumerable<MedicationRequest> e_ = context.Operators.ListUnion<MedicationRequest>(b_, d_);
		bool? f_(MedicationRequest DementiaMed)
		{
			string h_ = context.Operators.Convert<string>(DementiaMed?.StatusElement);
			bool? i_ = context.Operators.Equal(h_, "active");
			string j_ = context.Operators.Convert<string>(DementiaMed?.IntentElement);
			bool? k_ = context.Operators.Equal(j_, "order");
			bool? l_ = context.Operators.And(i_, k_);
			CqlInterval<CqlDateTime> m_ = CumulativeMedicationDurationFHIR4_1_0_000.MedicationPeriod((DementiaMed as object));
			CqlInterval<CqlDateTime> n_ = this.Measurement_Period();
			CqlDateTime o_ = context.Operators.Start(n_);
			CqlQuantity p_ = context.Operators.Quantity(1m, "year");
			CqlDateTime q_ = context.Operators.Subtract(o_, p_);
			CqlDateTime s_ = context.Operators.End(n_);
			CqlInterval<CqlDateTime> t_ = context.Operators.Interval(q_, s_, true, true);
			bool? u_ = context.Operators.Overlaps(m_, t_, null);
			bool? v_ = context.Operators.And(l_, u_);

			return v_;
		};
		IEnumerable<MedicationRequest> g_ = context.Operators.Where<MedicationRequest>(e_, f_);

		return g_;
	}

    [CqlDeclaration("Dementia Medications In Year Before or During Measurement Period")]
	public IEnumerable<MedicationRequest> Dementia_Medications_In_Year_Before_or_During_Measurement_Period() => 
		__Dementia_Medications_In_Year_Before_or_During_Measurement_Period.Value;

	private IEnumerable<CqlInterval<CqlDateTime>> Long_Term_Care_Periods_During_Measurement_Period_Value()
	{
		CqlValueSet a_ = this.Care_Services_in_Long_Term_Residential_Facility();
		IEnumerable<Encounter> b_ = context.Operators.RetrieveByValueSet<Encounter>(a_, null);
		CqlValueSet c_ = this.Nursing_Facility_Visit();
		IEnumerable<Encounter> d_ = context.Operators.RetrieveByValueSet<Encounter>(c_, null);
		IEnumerable<Encounter> e_ = context.Operators.ListUnion<Encounter>(b_, d_);
		bool? f_(Encounter LongTermFacilityEncounter)
		{
			string j_ = context.Operators.Convert<string>(LongTermFacilityEncounter?.StatusElement);
			bool? k_ = context.Operators.Equal(j_, "finished");
			CqlInterval<CqlDateTime> l_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Normalize_Interval((LongTermFacilityEncounter?.Period as object));
			CqlInterval<CqlDateTime> m_ = this.Measurement_Period();
			bool? n_ = context.Operators.Overlaps(l_, m_, null);
			bool? o_ = context.Operators.And(k_, n_);

			return o_;
		};
		IEnumerable<Encounter> g_ = context.Operators.Where<Encounter>(e_, f_);
		CqlInterval<CqlDateTime> h_(Encounter LongTermFacilityEncounter)
		{
			CqlInterval<CqlDateTime> p_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Normalize_Interval((LongTermFacilityEncounter?.Period as object));
			CqlInterval<CqlDateTime> q_ = this.Measurement_Period();
			CqlInterval<CqlDateTime> r_ = context.Operators.IntervalIntersect<CqlDateTime>(p_, q_);

			return r_;
		};
		IEnumerable<CqlInterval<CqlDateTime>> i_ = context.Operators.Select<Encounter, CqlInterval<CqlDateTime>>(g_, h_);

		return i_;
	}

    [CqlDeclaration("Long Term Care Periods During Measurement Period")]
	public IEnumerable<CqlInterval<CqlDateTime>> Long_Term_Care_Periods_During_Measurement_Period() => 
		__Long_Term_Care_Periods_During_Measurement_Period.Value;

	private IEnumerable<Encounter> Outpatient_Encounters_with_Advanced_Illness_Value()
	{
		CqlValueSet a_ = this.Outpatient();
		IEnumerable<Encounter> b_ = context.Operators.RetrieveByValueSet<Encounter>(a_, null);
		CqlValueSet c_ = this.Observation();
		IEnumerable<Encounter> d_ = context.Operators.RetrieveByValueSet<Encounter>(c_, null);
		IEnumerable<Encounter> e_ = context.Operators.ListUnion<Encounter>(b_, d_);
		CqlValueSet f_ = this.Emergency_Department_Visit();
		IEnumerable<Encounter> g_ = context.Operators.RetrieveByValueSet<Encounter>(f_, null);
		CqlValueSet h_ = this.Nonacute_Inpatient();
		IEnumerable<Encounter> i_ = context.Operators.RetrieveByValueSet<Encounter>(h_, null);
		IEnumerable<Encounter> j_ = context.Operators.ListUnion<Encounter>(g_, i_);
		IEnumerable<Encounter> k_ = context.Operators.ListUnion<Encounter>(e_, j_);
		bool? l_(Encounter Outpatient)
		{
			string p_ = context.Operators.Convert<string>(Outpatient?.StatusElement);
			bool? q_ = context.Operators.Equal(p_, "finished");

			return q_;
		};
		IEnumerable<Encounter> m_ = context.Operators.Where<Encounter>(k_, l_);
		IEnumerable<Encounter> n_(Encounter OutpatientEncounter)
		{
			CqlValueSet r_ = this.Advanced_Illness();
			IEnumerable<Condition> s_ = context.Operators.RetrieveByValueSet<Condition>(r_, null);
			bool? t_(Condition AdvancedIllnessDiagnosis)
			{
				IEnumerable<Condition> x_ = MATGlobalCommonFunctionsFHIR4_6_1_000.EncounterDiagnosis(OutpatientEncounter);
				bool? y_ = context.Operators.In<Condition>(AdvancedIllnessDiagnosis, x_);
				CqlInterval<CqlDateTime> z_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Normalize_Interval((OutpatientEncounter?.Period as object));
				CqlDateTime aa_ = context.Operators.Start(z_);
				CqlInterval<CqlDateTime> ab_ = this.Measurement_Period();
				CqlDateTime ac_ = context.Operators.End(ab_);
				CqlQuantity ad_ = context.Operators.Quantity(2m, "years");
				CqlDateTime ae_ = context.Operators.Subtract(ac_, ad_);
				CqlDateTime ag_ = context.Operators.End(ab_);
				CqlInterval<CqlDateTime> ah_ = context.Operators.Interval(ae_, ag_, true, true);
				bool? ai_ = context.Operators.In<CqlDateTime>(aa_, ah_, null);
				CqlDateTime ak_ = context.Operators.End(ab_);
				bool? al_ = context.Operators.Not((bool?)(ak_ is null));
				bool? am_ = context.Operators.And(ai_, al_);
				bool? an_ = context.Operators.And(y_, am_);

				return an_;
			};
			IEnumerable<Condition> u_ = context.Operators.Where<Condition>(s_, t_);
			Encounter v_(Condition AdvancedIllnessDiagnosis) => 
				OutpatientEncounter;
			IEnumerable<Encounter> w_ = context.Operators.Select<Condition, Encounter>(u_, v_);

			return w_;
		};
		IEnumerable<Encounter> o_ = context.Operators.SelectMany<Encounter, Encounter>(m_, n_);

		return o_;
	}

    [CqlDeclaration("Outpatient Encounters with Advanced Illness")]
	public IEnumerable<Encounter> Outpatient_Encounters_with_Advanced_Illness() => 
		__Outpatient_Encounters_with_Advanced_Illness.Value;

	private IEnumerable<Encounter> Two_Outpatient_Encounters_with_Advanced_Illness_on_Different_Dates_of_Service_Value()
	{
		IEnumerable<Encounter> a_ = this.Outpatient_Encounters_with_Advanced_Illness();
		IEnumerable<ValueTuple<Encounter,Encounter>> c_ = context.Operators.CrossJoin<Encounter, Encounter>(a_, a_);
		Tuple_EYKUVMTUWTABihhEAdHIGbSFe d_(ValueTuple<Encounter,Encounter> _valueTuple)
		{
			Tuple_EYKUVMTUWTABihhEAdHIGbSFe j_ = new Tuple_EYKUVMTUWTABihhEAdHIGbSFe
			{
				OutpatientEncounter1 = _valueTuple.Item1,
				OutpatientEncounter2 = _valueTuple.Item2,
			};

			return j_;
		};
		IEnumerable<Tuple_EYKUVMTUWTABihhEAdHIGbSFe> e_ = context.Operators.Select<ValueTuple<Encounter,Encounter>, Tuple_EYKUVMTUWTABihhEAdHIGbSFe>(c_, d_);
		bool? f_(Tuple_EYKUVMTUWTABihhEAdHIGbSFe tuple_eykuvmtuwtabihheadhigbsfe)
		{
			CqlInterval<CqlDateTime> k_ = FHIRHelpers_4_0_001.ToInterval(tuple_eykuvmtuwtabihheadhigbsfe.OutpatientEncounter2?.Period);
			CqlDateTime l_ = context.Operators.End(k_);
			CqlInterval<CqlDateTime> m_ = FHIRHelpers_4_0_001.ToInterval(tuple_eykuvmtuwtabihheadhigbsfe.OutpatientEncounter1?.Period);
			CqlDateTime n_ = context.Operators.End(m_);
			CqlQuantity o_ = context.Operators.Quantity(1m, "day");
			CqlDateTime p_ = context.Operators.Add(n_, o_);
			bool? q_ = context.Operators.SameOrAfter(l_, p_, "day");

			return q_;
		};
		IEnumerable<Tuple_EYKUVMTUWTABihhEAdHIGbSFe> g_ = context.Operators.Where<Tuple_EYKUVMTUWTABihhEAdHIGbSFe>(e_, f_);
		Encounter h_(Tuple_EYKUVMTUWTABihhEAdHIGbSFe tuple_eykuvmtuwtabihheadhigbsfe) => 
			tuple_eykuvmtuwtabihheadhigbsfe.OutpatientEncounter1;
		IEnumerable<Encounter> i_ = context.Operators.Select<Tuple_EYKUVMTUWTABihhEAdHIGbSFe, Encounter>(g_, h_);

		return i_;
	}

    [CqlDeclaration("Two Outpatient Encounters with Advanced Illness on Different Dates of Service")]
	public IEnumerable<Encounter> Two_Outpatient_Encounters_with_Advanced_Illness_on_Different_Dates_of_Service() => 
		__Two_Outpatient_Encounters_with_Advanced_Illness_on_Different_Dates_of_Service.Value;

	private IEnumerable<CqlInterval<CqlDateTime>> Long_Term_Care_Overlapping_Periods_Value()
	{
		IEnumerable<CqlInterval<CqlDateTime>> a_ = this.Long_Term_Care_Periods_During_Measurement_Period();
		IEnumerable<CqlInterval<CqlDateTime>> b_ = context.Operators.Collapse(a_, null);

		return b_;
	}

    [CqlDeclaration("Long Term Care Overlapping Periods")]
	public IEnumerable<CqlInterval<CqlDateTime>> Long_Term_Care_Overlapping_Periods() => 
		__Long_Term_Care_Overlapping_Periods.Value;

	private IEnumerable<CqlInterval<CqlDateTime>> Long_Term_Care_Adjacent_Periods_Value()
	{
		IEnumerable<CqlInterval<CqlDateTime>> a_ = this.Long_Term_Care_Overlapping_Periods();
		IEnumerable<ValueTuple<CqlInterval<CqlDateTime>,CqlInterval<CqlDateTime>>> c_ = context.Operators.CrossJoin<CqlInterval<CqlDateTime>, CqlInterval<CqlDateTime>>(a_, a_);
		Tuple_IWAGVXGPWIVBAWDaHPGIVVBK d_(ValueTuple<CqlInterval<CqlDateTime>,CqlInterval<CqlDateTime>> _valueTuple)
		{
			Tuple_IWAGVXGPWIVBAWDaHPGIVVBK j_ = new Tuple_IWAGVXGPWIVBAWDaHPGIVVBK
			{
				LTCPeriod1 = _valueTuple.Item1,
				LTCPeriod2 = _valueTuple.Item2,
			};

			return j_;
		};
		IEnumerable<Tuple_IWAGVXGPWIVBAWDaHPGIVVBK> e_ = context.Operators.Select<ValueTuple<CqlInterval<CqlDateTime>,CqlInterval<CqlDateTime>>, Tuple_IWAGVXGPWIVBAWDaHPGIVVBK>(c_, d_);
		bool? f_(Tuple_IWAGVXGPWIVBAWDaHPGIVVBK tuple_iwagvxgpwivbawdahpgivvbk)
		{
			CqlDateTime k_ = context.Operators.End(tuple_iwagvxgpwivbawdahpgivvbk.LTCPeriod1);
			CqlDateTime l_ = context.Operators.Start(tuple_iwagvxgpwivbawdahpgivvbk.LTCPeriod2);
			CqlQuantity m_ = context.Operators.Quantity(1m, "day");
			CqlDateTime n_ = context.Operators.Subtract(l_, m_);
			CqlDateTime q_ = context.Operators.Add(l_, m_);
			CqlInterval<CqlDateTime> r_ = context.Operators.Interval(n_, q_, true, true);
			bool? s_ = context.Operators.In<CqlDateTime>(k_, r_, null);
			bool? u_ = context.Operators.Not((bool?)(l_ is null));
			bool? v_ = context.Operators.And(s_, u_);

			return v_;
		};
		IEnumerable<Tuple_IWAGVXGPWIVBAWDaHPGIVVBK> g_ = context.Operators.Where<Tuple_IWAGVXGPWIVBAWDaHPGIVVBK>(e_, f_);
		CqlInterval<CqlDateTime> h_(Tuple_IWAGVXGPWIVBAWDaHPGIVVBK tuple_iwagvxgpwivbawdahpgivvbk)
		{
			CqlDateTime w_ = context.Operators.Start(tuple_iwagvxgpwivbawdahpgivvbk.LTCPeriod1);
			CqlDateTime x_ = context.Operators.End(tuple_iwagvxgpwivbawdahpgivvbk.LTCPeriod2);
			CqlInterval<CqlDateTime> y_ = context.Operators.Interval(w_, x_, true, true);

			return y_;
		};
		IEnumerable<CqlInterval<CqlDateTime>> i_ = context.Operators.Select<Tuple_IWAGVXGPWIVBAWDaHPGIVVBK, CqlInterval<CqlDateTime>>(g_, h_);

		return i_;
	}

    [CqlDeclaration("Long Term Care Adjacent Periods")]
	public IEnumerable<CqlInterval<CqlDateTime>> Long_Term_Care_Adjacent_Periods() => 
		__Long_Term_Care_Adjacent_Periods.Value;

	private int? Max_Long_Term_Care_Period_Length_Value()
	{
		IEnumerable<CqlInterval<CqlDateTime>> a_ = this.Long_Term_Care_Overlapping_Periods();
		IEnumerable<CqlInterval<CqlDateTime>> b_ = this.Long_Term_Care_Adjacent_Periods();
		IEnumerable<CqlInterval<CqlDateTime>> c_ = context.Operators.ListUnion<CqlInterval<CqlDateTime>>(a_, b_);
		IEnumerable<CqlInterval<CqlDateTime>> d_ = context.Operators.Collapse(c_, null);
		int? e_(CqlInterval<CqlDateTime> LTCPeriods)
		{
			CqlDateTime h_ = context.Operators.Start(LTCPeriods);
			CqlDateTime i_ = context.Operators.End(LTCPeriods);
			int? j_ = context.Operators.DurationBetween(h_, i_, "day");

			return j_;
		};
		IEnumerable<int?> f_ = context.Operators.Select<CqlInterval<CqlDateTime>, int?>(d_, e_);
		int? g_ = context.Operators.Max<int?>(f_);

		return g_;
	}

    [CqlDeclaration("Max Long Term Care Period Length")]
	public int? Max_Long_Term_Care_Period_Length() => 
		__Max_Long_Term_Care_Period_Length.Value;

	private IEnumerable<Encounter> Inpatient_Encounter_with_Advanced_Illness_Value()
	{
		CqlValueSet a_ = this.Acute_Inpatient();
		IEnumerable<Encounter> b_ = context.Operators.RetrieveByValueSet<Encounter>(a_, null);
		bool? c_(Encounter AcuteInpatient)
		{
			string g_ = context.Operators.Convert<string>(AcuteInpatient?.StatusElement);
			bool? h_ = context.Operators.Equal(g_, "finished");

			return h_;
		};
		IEnumerable<Encounter> d_ = context.Operators.Where<Encounter>(b_, c_);
		IEnumerable<Encounter> e_(Encounter InpatientEncounter)
		{
			CqlValueSet i_ = this.Advanced_Illness();
			IEnumerable<Condition> j_ = context.Operators.RetrieveByValueSet<Condition>(i_, null);
			bool? k_(Condition AdvancedIllnessDiagnosis)
			{
				IEnumerable<Condition> o_ = MATGlobalCommonFunctionsFHIR4_6_1_000.EncounterDiagnosis(InpatientEncounter);
				bool? p_ = context.Operators.In<Condition>(AdvancedIllnessDiagnosis, o_);
				CqlInterval<CqlDateTime> q_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Normalize_Interval((InpatientEncounter?.Period as object));
				CqlDateTime r_ = context.Operators.Start(q_);
				CqlInterval<CqlDateTime> s_ = this.Measurement_Period();
				CqlDateTime t_ = context.Operators.End(s_);
				CqlQuantity u_ = context.Operators.Quantity(2m, "years");
				CqlDateTime v_ = context.Operators.Subtract(t_, u_);
				CqlDateTime x_ = context.Operators.End(s_);
				CqlInterval<CqlDateTime> y_ = context.Operators.Interval(v_, x_, true, true);
				bool? z_ = context.Operators.In<CqlDateTime>(r_, y_, null);
				CqlDateTime ab_ = context.Operators.End(s_);
				bool? ac_ = context.Operators.Not((bool?)(ab_ is null));
				bool? ad_ = context.Operators.And(z_, ac_);
				bool? ae_ = context.Operators.And(p_, ad_);

				return ae_;
			};
			IEnumerable<Condition> l_ = context.Operators.Where<Condition>(j_, k_);
			Encounter m_(Condition AdvancedIllnessDiagnosis) => 
				InpatientEncounter;
			IEnumerable<Encounter> n_ = context.Operators.Select<Condition, Encounter>(l_, m_);

			return n_;
		};
		IEnumerable<Encounter> f_ = context.Operators.SelectMany<Encounter, Encounter>(d_, e_);

		return f_;
	}

    [CqlDeclaration("Inpatient Encounter with Advanced Illness")]
	public IEnumerable<Encounter> Inpatient_Encounter_with_Advanced_Illness() => 
		__Inpatient_Encounter_with_Advanced_Illness.Value;

	private bool? Has_Criteria_Indicating_Frailty_Value()
	{
		CqlValueSet a_ = this.Frailty_Device();
		IEnumerable<DeviceRequest> b_ = context.Operators.RetrieveByValueSet<DeviceRequest>(a_, null);
		IEnumerable<DeviceRequest> d_ = context.Operators.RetrieveByValueSet<DeviceRequest>(a_, null);
		IEnumerable<DeviceRequest> e_ = context.Operators.ListUnion<DeviceRequest>(b_, d_);
		bool? f_(DeviceRequest FrailtyDeviceOrder)
		{
			string ag_ = context.Operators.Convert<string>(FrailtyDeviceOrder?.StatusElement);
			string[] ah_ = new string[]
			{
				"active",
				"on-hold",
				"completed",
			};
			bool? ai_ = context.Operators.In<string>(ag_, (ah_ as IEnumerable<string>));
			string aj_ = context.Operators.Convert<string>(FrailtyDeviceOrder?.IntentElement);
			bool? ak_ = context.Operators.Equal(aj_, "order");
			bool? al_ = context.Operators.And(ai_, ak_);
			CqlInterval<CqlDateTime> am_ = this.Measurement_Period();
			CqlInterval<CqlDateTime> an_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Normalize_Interval((FrailtyDeviceOrder?.AuthoredOnElement as object));
			bool? ao_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(am_, an_, null);
			bool? ap_ = context.Operators.And(al_, ao_);

			return ap_;
		};
		IEnumerable<DeviceRequest> g_ = context.Operators.Where<DeviceRequest>(e_, f_);
		bool? h_ = context.Operators.Exists<DeviceRequest>(g_);
		IEnumerable<Observation> j_ = context.Operators.RetrieveByValueSet<Observation>(a_, null);
		bool? k_(Observation FrailtyDeviceApplied)
		{
			string aq_ = context.Operators.Convert<string>(FrailtyDeviceApplied?.StatusElement);
			string[] ar_ = new string[]
			{
				"final",
				"amended",
				"corrected",
			};
			bool? as_ = context.Operators.In<string>(aq_, (ar_ as IEnumerable<string>));
			CqlInterval<CqlDateTime> at_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Normalize_Interval(FrailtyDeviceApplied?.Effective);
			CqlInterval<CqlDateTime> au_ = this.Measurement_Period();
			bool? av_ = context.Operators.Overlaps(at_, au_, null);
			bool? aw_ = context.Operators.And(as_, av_);

			return aw_;
		};
		IEnumerable<Observation> l_ = context.Operators.Where<Observation>(j_, k_);
		bool? m_ = context.Operators.Exists<Observation>(l_);
		bool? n_ = context.Operators.Or(h_, m_);
		CqlValueSet o_ = this.Frailty_Diagnosis();
		IEnumerable<Condition> p_ = context.Operators.RetrieveByValueSet<Condition>(o_, null);
		bool? q_(Condition FrailtyDiagnosis)
		{
			CqlInterval<CqlDateTime> ax_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Prevalence_Period(FrailtyDiagnosis);
			CqlInterval<CqlDateTime> ay_ = this.Measurement_Period();
			bool? az_ = context.Operators.Overlaps(ax_, ay_, null);

			return az_;
		};
		IEnumerable<Condition> r_ = context.Operators.Where<Condition>(p_, q_);
		bool? s_ = context.Operators.Exists<Condition>(r_);
		bool? t_ = context.Operators.Or(n_, s_);
		CqlValueSet u_ = this.Frailty_Encounter();
		IEnumerable<Encounter> v_ = context.Operators.RetrieveByValueSet<Encounter>(u_, null);
		bool? w_(Encounter FrailtyEncounter)
		{
			string ba_ = context.Operators.Convert<string>(FrailtyEncounter?.StatusElement);
			bool? bb_ = context.Operators.Equal(ba_, "finished");
			CqlInterval<CqlDateTime> bc_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Normalize_Interval((FrailtyEncounter?.Period as object));
			CqlInterval<CqlDateTime> bd_ = this.Measurement_Period();
			bool? be_ = context.Operators.Overlaps(bc_, bd_, null);
			bool? bf_ = context.Operators.And(bb_, be_);

			return bf_;
		};
		IEnumerable<Encounter> x_ = context.Operators.Where<Encounter>(v_, w_);
		bool? y_ = context.Operators.Exists<Encounter>(x_);
		bool? z_ = context.Operators.Or(t_, y_);
		CqlValueSet aa_ = this.Frailty_Symptom();
		IEnumerable<Observation> ab_ = context.Operators.RetrieveByValueSet<Observation>(aa_, null);
		bool? ac_(Observation FrailtySymptom)
		{
			string bg_ = context.Operators.Convert<string>(FrailtySymptom?.StatusElement);
			string[] bh_ = new string[]
			{
				"preliminary",
				"final",
				"amended",
				"corrected",
			};
			bool? bi_ = context.Operators.In<string>(bg_, (bh_ as IEnumerable<string>));
			CqlInterval<CqlDateTime> bj_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Normalize_Interval(FrailtySymptom?.Effective);
			CqlInterval<CqlDateTime> bk_ = this.Measurement_Period();
			bool? bl_ = context.Operators.Overlaps(bj_, bk_, null);
			bool? bm_ = context.Operators.And(bi_, bl_);

			return bm_;
		};
		IEnumerable<Observation> ad_ = context.Operators.Where<Observation>(ab_, ac_);
		bool? ae_ = context.Operators.Exists<Observation>(ad_);
		bool? af_ = context.Operators.Or(z_, ae_);

		return af_;
	}

    [CqlDeclaration("Has Criteria Indicating Frailty")]
	public bool? Has_Criteria_Indicating_Frailty() => 
		__Has_Criteria_Indicating_Frailty.Value;

	private bool? Advanced_Illness_and_Frailty_Exclusion_Including_Over_Age_80_Value()
	{
		Patient a_ = this.Patient();
		CqlDate b_ = context.Operators.Convert<CqlDate>(a_?.BirthDateElement?.Value);
		CqlInterval<CqlDateTime> c_ = this.Measurement_Period();
		CqlDateTime d_ = context.Operators.Start(c_);
		CqlDate e_ = context.Operators.DateFrom(d_);
		int? f_ = context.Operators.CalculateAgeAt(b_, e_, "year");
		CqlInterval<int?> g_ = context.Operators.Interval(65, 79, true, true);
		bool? h_ = context.Operators.In<int?>(f_, g_, null);
		bool? i_ = this.Has_Criteria_Indicating_Frailty();
		bool? j_ = context.Operators.And(h_, i_);
		IEnumerable<Encounter> k_ = this.Two_Outpatient_Encounters_with_Advanced_Illness_on_Different_Dates_of_Service();
		bool? l_ = context.Operators.Exists<Encounter>(k_);
		IEnumerable<Encounter> m_ = this.Inpatient_Encounter_with_Advanced_Illness();
		bool? n_ = context.Operators.Exists<Encounter>(m_);
		bool? o_ = context.Operators.Or(l_, n_);
		IEnumerable<MedicationRequest> p_ = this.Dementia_Medications_In_Year_Before_or_During_Measurement_Period();
		bool? q_ = context.Operators.Exists<MedicationRequest>(p_);
		bool? r_ = context.Operators.Or(o_, q_);
		bool? s_ = context.Operators.And(j_, r_);
		CqlDate u_ = context.Operators.Convert<CqlDate>(a_?.BirthDateElement?.Value);
		CqlDateTime w_ = context.Operators.Start(c_);
		CqlDate x_ = context.Operators.DateFrom(w_);
		int? y_ = context.Operators.CalculateAgeAt(u_, x_, "year");
		bool? z_ = context.Operators.GreaterOrEqual(y_, 80);
		bool? ab_ = context.Operators.And(z_, i_);
		bool? ac_ = context.Operators.Or(s_, ab_);

		return ac_;
	}

    [CqlDeclaration("Advanced Illness and Frailty Exclusion Including Over Age 80")]
	public bool? Advanced_Illness_and_Frailty_Exclusion_Including_Over_Age_80() => 
		__Advanced_Illness_and_Frailty_Exclusion_Including_Over_Age_80.Value;

	private bool? Advanced_Illness_and_Frailty_Exclusion_Not_Including_Over_Age_80_Value()
	{
		Patient a_ = this.Patient();
		CqlDate b_ = context.Operators.Convert<CqlDate>(a_?.BirthDateElement?.Value);
		CqlInterval<CqlDateTime> c_ = this.Measurement_Period();
		CqlDateTime d_ = context.Operators.Start(c_);
		CqlDate e_ = context.Operators.DateFrom(d_);
		int? f_ = context.Operators.CalculateAgeAt(b_, e_, "year");
		bool? g_ = context.Operators.GreaterOrEqual(f_, 65);
		bool? h_ = this.Has_Criteria_Indicating_Frailty();
		bool? i_ = context.Operators.And(g_, h_);
		IEnumerable<Encounter> j_ = this.Two_Outpatient_Encounters_with_Advanced_Illness_on_Different_Dates_of_Service();
		bool? k_ = context.Operators.Exists<Encounter>(j_);
		IEnumerable<Encounter> l_ = this.Inpatient_Encounter_with_Advanced_Illness();
		bool? m_ = context.Operators.Exists<Encounter>(l_);
		bool? n_ = context.Operators.Or(k_, m_);
		IEnumerable<MedicationRequest> o_ = this.Dementia_Medications_In_Year_Before_or_During_Measurement_Period();
		bool? p_ = context.Operators.Exists<MedicationRequest>(o_);
		bool? q_ = context.Operators.Or(n_, p_);
		bool? r_ = context.Operators.And(i_, q_);

		return r_;
	}

    [CqlDeclaration("Advanced Illness and Frailty Exclusion Not Including Over Age 80")]
	public bool? Advanced_Illness_and_Frailty_Exclusion_Not_Including_Over_Age_80() => 
		__Advanced_Illness_and_Frailty_Exclusion_Not_Including_Over_Age_80.Value;

	private bool? Has_Long_Term_Care_Periods_Longer_Than_90_Consecutive_Days_Value()
	{
		int? a_ = this.Max_Long_Term_Care_Period_Length();
		bool? b_ = context.Operators.Greater(a_, 90);

		return b_;
	}

    [CqlDeclaration("Has Long Term Care Periods Longer Than 90 Consecutive Days")]
	public bool? Has_Long_Term_Care_Periods_Longer_Than_90_Consecutive_Days() => 
		__Has_Long_Term_Care_Periods_Longer_Than_90_Consecutive_Days.Value;

}
