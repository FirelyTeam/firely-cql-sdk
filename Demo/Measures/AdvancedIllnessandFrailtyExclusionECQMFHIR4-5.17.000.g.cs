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
		var a_ = context.ResolveParameter("AdvancedIllnessandFrailtyExclusionECQMFHIR4-5.17.000", "Measurement Period", null);

		return (CqlInterval<CqlDateTime>)a_;
	}

    [CqlDeclaration("Measurement Period")]
	public CqlInterval<CqlDateTime> Measurement_Period() => 
		__Measurement_Period.Value;

	private Patient Patient_Value()
	{
		var a_ = context.Operators.RetrieveByValueSet<Patient>(null, null);
		var b_ = context.Operators.Single<Patient>(a_);

		return b_;
	}

    [CqlDeclaration("Patient")]
	public Patient Patient() => 
		__Patient.Value;

	private IEnumerable<MedicationRequest> Dementia_Medications_In_Year_Before_or_During_Measurement_Period_Value()
	{
		var a_ = this.Dementia_Medications();
		var b_ = context.Operators.RetrieveByValueSet<MedicationRequest>(a_, null);
		var d_ = context.Operators.RetrieveByValueSet<MedicationRequest>(a_, null);
		var e_ = context.Operators.ListUnion<MedicationRequest>(b_, d_);
		bool? f_(MedicationRequest DementiaMed)
		{
			var h_ = context.Operators.Convert<string>(DementiaMed?.StatusElement);
			var i_ = context.Operators.Equal(h_, "active");
			var j_ = context.Operators.Convert<string>(DementiaMed?.IntentElement);
			var k_ = context.Operators.Equal(j_, "order");
			var l_ = context.Operators.And(i_, k_);
			var m_ = CumulativeMedicationDurationFHIR4_1_0_000.MedicationPeriod((DementiaMed as object));
			var n_ = this.Measurement_Period();
			var o_ = context.Operators.Start(n_);
			var p_ = context.Operators.Quantity(1m, "year");
			var q_ = context.Operators.Subtract(o_, p_);
			var s_ = context.Operators.End(n_);
			var t_ = context.Operators.Interval(q_, s_, true, true);
			var u_ = context.Operators.Overlaps(m_, t_, null);
			var v_ = context.Operators.And(l_, u_);

			return v_;
		};
		var g_ = context.Operators.WhereOrNull<MedicationRequest>(e_, f_);

		return g_;
	}

    [CqlDeclaration("Dementia Medications In Year Before or During Measurement Period")]
	public IEnumerable<MedicationRequest> Dementia_Medications_In_Year_Before_or_During_Measurement_Period() => 
		__Dementia_Medications_In_Year_Before_or_During_Measurement_Period.Value;

	private IEnumerable<CqlInterval<CqlDateTime>> Long_Term_Care_Periods_During_Measurement_Period_Value()
	{
		var a_ = this.Care_Services_in_Long_Term_Residential_Facility();
		var b_ = context.Operators.RetrieveByValueSet<Encounter>(a_, null);
		var c_ = this.Nursing_Facility_Visit();
		var d_ = context.Operators.RetrieveByValueSet<Encounter>(c_, null);
		var e_ = context.Operators.ListUnion<Encounter>(b_, d_);
		bool? f_(Encounter LongTermFacilityEncounter)
		{
			var j_ = context.Operators.Convert<string>(LongTermFacilityEncounter?.StatusElement);
			var k_ = context.Operators.Equal(j_, "finished");
			var l_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Normalize_Interval((LongTermFacilityEncounter?.Period as object));
			var m_ = this.Measurement_Period();
			var n_ = context.Operators.Overlaps(l_, m_, null);
			var o_ = context.Operators.And(k_, n_);

			return o_;
		};
		var g_ = context.Operators.WhereOrNull<Encounter>(e_, f_);
		CqlInterval<CqlDateTime> h_(Encounter LongTermFacilityEncounter)
		{
			var p_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Normalize_Interval((LongTermFacilityEncounter?.Period as object));
			var q_ = this.Measurement_Period();
			var r_ = context.Operators.IntervalIntersect<CqlDateTime>(p_, q_);

			return r_;
		};
		var i_ = context.Operators.Select<Encounter, CqlInterval<CqlDateTime>>(g_, h_);

		return i_;
	}

    [CqlDeclaration("Long Term Care Periods During Measurement Period")]
	public IEnumerable<CqlInterval<CqlDateTime>> Long_Term_Care_Periods_During_Measurement_Period() => 
		__Long_Term_Care_Periods_During_Measurement_Period.Value;

	private IEnumerable<Encounter> Outpatient_Encounters_with_Advanced_Illness_Value()
	{
		var a_ = this.Outpatient();
		var b_ = context.Operators.RetrieveByValueSet<Encounter>(a_, null);
		var c_ = this.Observation();
		var d_ = context.Operators.RetrieveByValueSet<Encounter>(c_, null);
		var e_ = context.Operators.ListUnion<Encounter>(b_, d_);
		var f_ = this.Emergency_Department_Visit();
		var g_ = context.Operators.RetrieveByValueSet<Encounter>(f_, null);
		var h_ = this.Nonacute_Inpatient();
		var i_ = context.Operators.RetrieveByValueSet<Encounter>(h_, null);
		var j_ = context.Operators.ListUnion<Encounter>(g_, i_);
		var k_ = context.Operators.ListUnion<Encounter>(e_, j_);
		bool? l_(Encounter Outpatient)
		{
			var p_ = context.Operators.Convert<string>(Outpatient?.StatusElement);
			var q_ = context.Operators.Equal(p_, "finished");

			return q_;
		};
		var m_ = context.Operators.WhereOrNull<Encounter>(k_, l_);
		IEnumerable<Encounter> n_(Encounter OutpatientEncounter)
		{
			var r_ = this.Advanced_Illness();
			var s_ = context.Operators.RetrieveByValueSet<Condition>(r_, null);
			bool? t_(Condition AdvancedIllnessDiagnosis)
			{
				var x_ = MATGlobalCommonFunctionsFHIR4_6_1_000.EncounterDiagnosis(OutpatientEncounter);
				var y_ = context.Operators.InList<Condition>(AdvancedIllnessDiagnosis, x_);
				var z_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Normalize_Interval((OutpatientEncounter?.Period as object));
				var aa_ = context.Operators.Start(z_);
				var ab_ = this.Measurement_Period();
				var ac_ = context.Operators.End(ab_);
				var ad_ = context.Operators.Quantity(2m, "years");
				var ae_ = context.Operators.Subtract(ac_, ad_);
				var ag_ = context.Operators.End(ab_);
				var ah_ = context.Operators.Interval(ae_, ag_, true, true);
				var ai_ = context.Operators.ElementInInterval<CqlDateTime>(aa_, ah_, null);
				var ak_ = context.Operators.End(ab_);
				var al_ = context.Operators.Not((bool?)(ak_ is null));
				var am_ = context.Operators.And(ai_, al_);
				var an_ = context.Operators.And(y_, am_);

				return an_;
			};
			var u_ = context.Operators.WhereOrNull<Condition>(s_, t_);
			Encounter v_(Condition AdvancedIllnessDiagnosis) => 
				OutpatientEncounter;
			var w_ = context.Operators.Select<Condition, Encounter>(u_, v_);

			return w_;
		};
		var o_ = context.Operators.SelectMany<Encounter, Encounter>(m_, n_);

		return o_;
	}

    [CqlDeclaration("Outpatient Encounters with Advanced Illness")]
	public IEnumerable<Encounter> Outpatient_Encounters_with_Advanced_Illness() => 
		__Outpatient_Encounters_with_Advanced_Illness.Value;

	private IEnumerable<Encounter> Two_Outpatient_Encounters_with_Advanced_Illness_on_Different_Dates_of_Service_Value()
	{
		var a_ = this.Outpatient_Encounters_with_Advanced_Illness();
		var c_ = context.Operators.CrossJoin<Encounter, Encounter>(a_, a_);
		Tuples.Tuple_EYKUVMTUWTABihhEAdHIGbSFe d_(ValueTuple<Encounter,Encounter> _valueTuple)
		{
			var j_ = new Tuples.Tuple_EYKUVMTUWTABihhEAdHIGbSFe
			{
				OutpatientEncounter1 = _valueTuple.Item1,
				OutpatientEncounter2 = _valueTuple.Item2,
			};

			return j_;
		};
		var e_ = context.Operators.Select<ValueTuple<Encounter,Encounter>, Tuples.Tuple_EYKUVMTUWTABihhEAdHIGbSFe>(c_, d_);
		bool? f_(Tuples.Tuple_EYKUVMTUWTABihhEAdHIGbSFe tuple_eykuvmtuwtabihheadhigbsfe)
		{
			var k_ = FHIRHelpers_4_0_001.ToInterval(tuple_eykuvmtuwtabihheadhigbsfe.OutpatientEncounter2?.Period);
			var l_ = context.Operators.End(k_);
			var m_ = FHIRHelpers_4_0_001.ToInterval(tuple_eykuvmtuwtabihheadhigbsfe.OutpatientEncounter1?.Period);
			var n_ = context.Operators.End(m_);
			var o_ = context.Operators.Quantity(1m, "day");
			var p_ = context.Operators.Add(n_, o_);
			var q_ = context.Operators.SameOrAfter(l_, p_, "day");

			return q_;
		};
		var g_ = context.Operators.WhereOrNull<Tuples.Tuple_EYKUVMTUWTABihhEAdHIGbSFe>(e_, f_);
		Encounter h_(Tuples.Tuple_EYKUVMTUWTABihhEAdHIGbSFe tuple_eykuvmtuwtabihheadhigbsfe) => 
			tuple_eykuvmtuwtabihheadhigbsfe.OutpatientEncounter1;
		var i_ = context.Operators.Select<Tuples.Tuple_EYKUVMTUWTABihhEAdHIGbSFe, Encounter>(g_, h_);

		return i_;
	}

    [CqlDeclaration("Two Outpatient Encounters with Advanced Illness on Different Dates of Service")]
	public IEnumerable<Encounter> Two_Outpatient_Encounters_with_Advanced_Illness_on_Different_Dates_of_Service() => 
		__Two_Outpatient_Encounters_with_Advanced_Illness_on_Different_Dates_of_Service.Value;

	private IEnumerable<CqlInterval<CqlDateTime>> Long_Term_Care_Overlapping_Periods_Value()
	{
		var a_ = this.Long_Term_Care_Periods_During_Measurement_Period();
		var b_ = context.Operators.Collapse(a_, null);

		return b_;
	}

    [CqlDeclaration("Long Term Care Overlapping Periods")]
	public IEnumerable<CqlInterval<CqlDateTime>> Long_Term_Care_Overlapping_Periods() => 
		__Long_Term_Care_Overlapping_Periods.Value;

	private IEnumerable<CqlInterval<CqlDateTime>> Long_Term_Care_Adjacent_Periods_Value()
	{
		var a_ = this.Long_Term_Care_Overlapping_Periods();
		var c_ = context.Operators.CrossJoin<CqlInterval<CqlDateTime>, CqlInterval<CqlDateTime>>(a_, a_);
		Tuples.Tuple_IWAGVXGPWIVBAWDaHPGIVVBK d_(ValueTuple<CqlInterval<CqlDateTime>,CqlInterval<CqlDateTime>> _valueTuple)
		{
			var j_ = new Tuples.Tuple_IWAGVXGPWIVBAWDaHPGIVVBK
			{
				LTCPeriod1 = _valueTuple.Item1,
				LTCPeriod2 = _valueTuple.Item2,
			};

			return j_;
		};
		var e_ = context.Operators.Select<ValueTuple<CqlInterval<CqlDateTime>,CqlInterval<CqlDateTime>>, Tuples.Tuple_IWAGVXGPWIVBAWDaHPGIVVBK>(c_, d_);
		bool? f_(Tuples.Tuple_IWAGVXGPWIVBAWDaHPGIVVBK tuple_iwagvxgpwivbawdahpgivvbk)
		{
			var k_ = context.Operators.End(tuple_iwagvxgpwivbawdahpgivvbk.LTCPeriod1);
			var l_ = context.Operators.Start(tuple_iwagvxgpwivbawdahpgivvbk.LTCPeriod2);
			var m_ = context.Operators.Quantity(1m, "day");
			var n_ = context.Operators.Subtract(l_, m_);
			var q_ = context.Operators.Add(l_, m_);
			var r_ = context.Operators.Interval(n_, q_, true, true);
			var s_ = context.Operators.ElementInInterval<CqlDateTime>(k_, r_, null);
			var u_ = context.Operators.Not((bool?)(l_ is null));
			var v_ = context.Operators.And(s_, u_);

			return v_;
		};
		var g_ = context.Operators.WhereOrNull<Tuples.Tuple_IWAGVXGPWIVBAWDaHPGIVVBK>(e_, f_);
		CqlInterval<CqlDateTime> h_(Tuples.Tuple_IWAGVXGPWIVBAWDaHPGIVVBK tuple_iwagvxgpwivbawdahpgivvbk)
		{
			var w_ = context.Operators.Start(tuple_iwagvxgpwivbawdahpgivvbk.LTCPeriod1);
			var x_ = context.Operators.End(tuple_iwagvxgpwivbawdahpgivvbk.LTCPeriod2);
			var y_ = context.Operators.Interval(w_, x_, true, true);

			return y_;
		};
		var i_ = context.Operators.Select<Tuples.Tuple_IWAGVXGPWIVBAWDaHPGIVVBK, CqlInterval<CqlDateTime>>(g_, h_);

		return i_;
	}

    [CqlDeclaration("Long Term Care Adjacent Periods")]
	public IEnumerable<CqlInterval<CqlDateTime>> Long_Term_Care_Adjacent_Periods() => 
		__Long_Term_Care_Adjacent_Periods.Value;

	private int? Max_Long_Term_Care_Period_Length_Value()
	{
		var a_ = this.Long_Term_Care_Overlapping_Periods();
		var b_ = this.Long_Term_Care_Adjacent_Periods();
		var c_ = context.Operators.ListUnion<CqlInterval<CqlDateTime>>(a_, b_);
		var d_ = context.Operators.Collapse(c_, null);
		int? e_(CqlInterval<CqlDateTime> LTCPeriods)
		{
			var h_ = context.Operators.Start(LTCPeriods);
			var i_ = context.Operators.End(LTCPeriods);
			var j_ = context.Operators.DurationBetween(h_, i_, "day");

			return j_;
		};
		var f_ = context.Operators.Select<CqlInterval<CqlDateTime>, int?>(d_, e_);
		var g_ = context.Operators.MaxOrNull<int?>(f_);

		return g_;
	}

    [CqlDeclaration("Max Long Term Care Period Length")]
	public int? Max_Long_Term_Care_Period_Length() => 
		__Max_Long_Term_Care_Period_Length.Value;

	private IEnumerable<Encounter> Inpatient_Encounter_with_Advanced_Illness_Value()
	{
		var a_ = this.Acute_Inpatient();
		var b_ = context.Operators.RetrieveByValueSet<Encounter>(a_, null);
		bool? c_(Encounter AcuteInpatient)
		{
			var g_ = context.Operators.Convert<string>(AcuteInpatient?.StatusElement);
			var h_ = context.Operators.Equal(g_, "finished");

			return h_;
		};
		var d_ = context.Operators.WhereOrNull<Encounter>(b_, c_);
		IEnumerable<Encounter> e_(Encounter InpatientEncounter)
		{
			var i_ = this.Advanced_Illness();
			var j_ = context.Operators.RetrieveByValueSet<Condition>(i_, null);
			bool? k_(Condition AdvancedIllnessDiagnosis)
			{
				var o_ = MATGlobalCommonFunctionsFHIR4_6_1_000.EncounterDiagnosis(InpatientEncounter);
				var p_ = context.Operators.InList<Condition>(AdvancedIllnessDiagnosis, o_);
				var q_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Normalize_Interval((InpatientEncounter?.Period as object));
				var r_ = context.Operators.Start(q_);
				var s_ = this.Measurement_Period();
				var t_ = context.Operators.End(s_);
				var u_ = context.Operators.Quantity(2m, "years");
				var v_ = context.Operators.Subtract(t_, u_);
				var x_ = context.Operators.End(s_);
				var y_ = context.Operators.Interval(v_, x_, true, true);
				var z_ = context.Operators.ElementInInterval<CqlDateTime>(r_, y_, null);
				var ab_ = context.Operators.End(s_);
				var ac_ = context.Operators.Not((bool?)(ab_ is null));
				var ad_ = context.Operators.And(z_, ac_);
				var ae_ = context.Operators.And(p_, ad_);

				return ae_;
			};
			var l_ = context.Operators.WhereOrNull<Condition>(j_, k_);
			Encounter m_(Condition AdvancedIllnessDiagnosis) => 
				InpatientEncounter;
			var n_ = context.Operators.Select<Condition, Encounter>(l_, m_);

			return n_;
		};
		var f_ = context.Operators.SelectMany<Encounter, Encounter>(d_, e_);

		return f_;
	}

    [CqlDeclaration("Inpatient Encounter with Advanced Illness")]
	public IEnumerable<Encounter> Inpatient_Encounter_with_Advanced_Illness() => 
		__Inpatient_Encounter_with_Advanced_Illness.Value;

	private bool? Has_Criteria_Indicating_Frailty_Value()
	{
		var a_ = this.Frailty_Device();
		var b_ = context.Operators.RetrieveByValueSet<DeviceRequest>(a_, null);
		var d_ = context.Operators.RetrieveByValueSet<DeviceRequest>(a_, null);
		var e_ = context.Operators.ListUnion<DeviceRequest>(b_, d_);
		bool? f_(DeviceRequest FrailtyDeviceOrder)
		{
			var ag_ = context.Operators.Convert<string>(FrailtyDeviceOrder?.StatusElement);
			var ah_ = new string[]
			{
				"active",
				"on-hold",
				"completed",
			};
			var ai_ = context.Operators.InList<string>(ag_, (ah_ as IEnumerable<string>));
			var aj_ = context.Operators.Convert<string>(FrailtyDeviceOrder?.IntentElement);
			var ak_ = context.Operators.Equal(aj_, "order");
			var al_ = context.Operators.And(ai_, ak_);
			var am_ = this.Measurement_Period();
			var an_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Normalize_Interval((FrailtyDeviceOrder?.AuthoredOnElement as object));
			var ao_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(am_, an_, null);
			var ap_ = context.Operators.And(al_, ao_);

			return ap_;
		};
		var g_ = context.Operators.WhereOrNull<DeviceRequest>(e_, f_);
		var h_ = context.Operators.ExistsInList<DeviceRequest>(g_);
		var j_ = context.Operators.RetrieveByValueSet<Observation>(a_, null);
		bool? k_(Observation FrailtyDeviceApplied)
		{
			var aq_ = context.Operators.Convert<string>(FrailtyDeviceApplied?.StatusElement);
			var ar_ = new string[]
			{
				"final",
				"amended",
				"corrected",
			};
			var as_ = context.Operators.InList<string>(aq_, (ar_ as IEnumerable<string>));
			var at_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Normalize_Interval(FrailtyDeviceApplied?.Effective);
			var au_ = this.Measurement_Period();
			var av_ = context.Operators.Overlaps(at_, au_, null);
			var aw_ = context.Operators.And(as_, av_);

			return aw_;
		};
		var l_ = context.Operators.WhereOrNull<Observation>(j_, k_);
		var m_ = context.Operators.ExistsInList<Observation>(l_);
		var n_ = context.Operators.Or(h_, m_);
		var o_ = this.Frailty_Diagnosis();
		var p_ = context.Operators.RetrieveByValueSet<Condition>(o_, null);
		bool? q_(Condition FrailtyDiagnosis)
		{
			var ax_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Prevalence_Period(FrailtyDiagnosis);
			var ay_ = this.Measurement_Period();
			var az_ = context.Operators.Overlaps(ax_, ay_, null);

			return az_;
		};
		var r_ = context.Operators.WhereOrNull<Condition>(p_, q_);
		var s_ = context.Operators.ExistsInList<Condition>(r_);
		var t_ = context.Operators.Or(n_, s_);
		var u_ = this.Frailty_Encounter();
		var v_ = context.Operators.RetrieveByValueSet<Encounter>(u_, null);
		bool? w_(Encounter FrailtyEncounter)
		{
			var ba_ = context.Operators.Convert<string>(FrailtyEncounter?.StatusElement);
			var bb_ = context.Operators.Equal(ba_, "finished");
			var bc_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Normalize_Interval((FrailtyEncounter?.Period as object));
			var bd_ = this.Measurement_Period();
			var be_ = context.Operators.Overlaps(bc_, bd_, null);
			var bf_ = context.Operators.And(bb_, be_);

			return bf_;
		};
		var x_ = context.Operators.WhereOrNull<Encounter>(v_, w_);
		var y_ = context.Operators.ExistsInList<Encounter>(x_);
		var z_ = context.Operators.Or(t_, y_);
		var aa_ = this.Frailty_Symptom();
		var ab_ = context.Operators.RetrieveByValueSet<Observation>(aa_, null);
		bool? ac_(Observation FrailtySymptom)
		{
			var bg_ = context.Operators.Convert<string>(FrailtySymptom?.StatusElement);
			var bh_ = new string[]
			{
				"preliminary",
				"final",
				"amended",
				"corrected",
			};
			var bi_ = context.Operators.InList<string>(bg_, (bh_ as IEnumerable<string>));
			var bj_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Normalize_Interval(FrailtySymptom?.Effective);
			var bk_ = this.Measurement_Period();
			var bl_ = context.Operators.Overlaps(bj_, bk_, null);
			var bm_ = context.Operators.And(bi_, bl_);

			return bm_;
		};
		var ad_ = context.Operators.WhereOrNull<Observation>(ab_, ac_);
		var ae_ = context.Operators.ExistsInList<Observation>(ad_);
		var af_ = context.Operators.Or(z_, ae_);

		return af_;
	}

    [CqlDeclaration("Has Criteria Indicating Frailty")]
	public bool? Has_Criteria_Indicating_Frailty() => 
		__Has_Criteria_Indicating_Frailty.Value;

	private bool? Advanced_Illness_and_Frailty_Exclusion_Including_Over_Age_80_Value()
	{
		var a_ = this.Patient();
		var b_ = context.Operators.Convert<CqlDate>(a_?.BirthDateElement?.Value);
		var c_ = this.Measurement_Period();
		var d_ = context.Operators.Start(c_);
		var e_ = context.Operators.DateFrom(d_);
		var f_ = context.Operators.CalculateAgeAt(b_, e_, "year");
		var g_ = context.Operators.Interval((int?)65, (int?)79, true, true);
		var h_ = context.Operators.ElementInInterval<int?>(f_, g_, null);
		var i_ = this.Has_Criteria_Indicating_Frailty();
		var j_ = context.Operators.And(h_, i_);
		var k_ = this.Two_Outpatient_Encounters_with_Advanced_Illness_on_Different_Dates_of_Service();
		var l_ = context.Operators.ExistsInList<Encounter>(k_);
		var m_ = this.Inpatient_Encounter_with_Advanced_Illness();
		var n_ = context.Operators.ExistsInList<Encounter>(m_);
		var o_ = context.Operators.Or(l_, n_);
		var p_ = this.Dementia_Medications_In_Year_Before_or_During_Measurement_Period();
		var q_ = context.Operators.ExistsInList<MedicationRequest>(p_);
		var r_ = context.Operators.Or(o_, q_);
		var s_ = context.Operators.And(j_, r_);
		var u_ = context.Operators.Convert<CqlDate>(a_?.BirthDateElement?.Value);
		var w_ = context.Operators.Start(c_);
		var x_ = context.Operators.DateFrom(w_);
		var y_ = context.Operators.CalculateAgeAt(u_, x_, "year");
		var z_ = context.Operators.GreaterOrEqual(y_, (int?)80);
		var ab_ = context.Operators.And(z_, i_);
		var ac_ = context.Operators.Or(s_, ab_);

		return ac_;
	}

    [CqlDeclaration("Advanced Illness and Frailty Exclusion Including Over Age 80")]
	public bool? Advanced_Illness_and_Frailty_Exclusion_Including_Over_Age_80() => 
		__Advanced_Illness_and_Frailty_Exclusion_Including_Over_Age_80.Value;

	private bool? Advanced_Illness_and_Frailty_Exclusion_Not_Including_Over_Age_80_Value()
	{
		var a_ = this.Patient();
		var b_ = context.Operators.Convert<CqlDate>(a_?.BirthDateElement?.Value);
		var c_ = this.Measurement_Period();
		var d_ = context.Operators.Start(c_);
		var e_ = context.Operators.DateFrom(d_);
		var f_ = context.Operators.CalculateAgeAt(b_, e_, "year");
		var g_ = context.Operators.GreaterOrEqual(f_, (int?)65);
		var h_ = this.Has_Criteria_Indicating_Frailty();
		var i_ = context.Operators.And(g_, h_);
		var j_ = this.Two_Outpatient_Encounters_with_Advanced_Illness_on_Different_Dates_of_Service();
		var k_ = context.Operators.ExistsInList<Encounter>(j_);
		var l_ = this.Inpatient_Encounter_with_Advanced_Illness();
		var m_ = context.Operators.ExistsInList<Encounter>(l_);
		var n_ = context.Operators.Or(k_, m_);
		var o_ = this.Dementia_Medications_In_Year_Before_or_During_Measurement_Period();
		var p_ = context.Operators.ExistsInList<MedicationRequest>(o_);
		var q_ = context.Operators.Or(n_, p_);
		var r_ = context.Operators.And(i_, q_);

		return r_;
	}

    [CqlDeclaration("Advanced Illness and Frailty Exclusion Not Including Over Age 80")]
	public bool? Advanced_Illness_and_Frailty_Exclusion_Not_Including_Over_Age_80() => 
		__Advanced_Illness_and_Frailty_Exclusion_Not_Including_Over_Age_80.Value;

	private bool? Has_Long_Term_Care_Periods_Longer_Than_90_Consecutive_Days_Value()
	{
		var a_ = this.Max_Long_Term_Care_Period_Length();
		var b_ = context.Operators.Greater(a_, (int?)90);

		return b_;
	}

    [CqlDeclaration("Has Long Term Care Periods Longer Than 90 Consecutive Days")]
	public bool? Has_Long_Term_Care_Periods_Longer_Than_90_Consecutive_Days() => 
		__Has_Long_Term_Care_Periods_Longer_Than_90_Consecutive_Days.Value;

}
