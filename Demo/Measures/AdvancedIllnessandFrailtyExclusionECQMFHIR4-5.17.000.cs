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

[System.CodeDom.Compiler.GeneratedCode(".NET Code Generation", "0.9.0.0")]
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
		var b_ = context.Operators.SingleOrNull<Patient>(a_);

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
			var h_ = DementiaMed?.StatusElement;
			var i_ = context.Operators.Convert<string>(h_);
			var j_ = context.Operators.Equal(i_, "active");
			var k_ = DementiaMed?.IntentElement;
			var l_ = context.Operators.Convert<string>(k_);
			var m_ = context.Operators.Equal(l_, "order");
			var n_ = context.Operators.And(j_, m_);
			var o_ = CumulativeMedicationDurationFHIR4_1_0_000.MedicationPeriod(DementiaMed);
			var p_ = this.Measurement_Period();
			var q_ = context.Operators.Start(p_);
			var r_ = context.Operators.Quantity(1m, "year");
			var s_ = context.Operators.Subtract(q_, r_);
			var u_ = context.Operators.End(p_);
			var v_ = context.Operators.Interval(s_, u_, true, true);
			var w_ = context.Operators.Overlaps(o_, v_, null);
			var x_ = context.Operators.And(n_, w_);

			return x_;
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
			var j_ = LongTermFacilityEncounter?.StatusElement;
			var k_ = context.Operators.Convert<string>(j_);
			var l_ = context.Operators.Equal(k_, "finished");
			var m_ = LongTermFacilityEncounter?.Period;
			var n_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Normalize_Interval(m_);
			var o_ = this.Measurement_Period();
			var p_ = context.Operators.Overlaps(n_, o_, null);
			var q_ = context.Operators.And(l_, p_);

			return q_;
		};
		var g_ = context.Operators.WhereOrNull<Encounter>(e_, f_);
		CqlInterval<CqlDateTime> h_(Encounter LongTermFacilityEncounter)
		{
			var r_ = LongTermFacilityEncounter?.Period;
			var s_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Normalize_Interval(r_);
			var t_ = this.Measurement_Period();
			var u_ = context.Operators.IntervalIntersectsInterval<CqlDateTime>(s_, t_);

			return u_;
		};
		var i_ = context.Operators.SelectOrNull<Encounter, CqlInterval<CqlDateTime>>(g_, h_);

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
			var p_ = Outpatient?.StatusElement;
			var q_ = context.Operators.Convert<string>(p_);
			var r_ = context.Operators.Equal(q_, "finished");

			return r_;
		};
		var m_ = context.Operators.WhereOrNull<Encounter>(k_, l_);
		IEnumerable<Encounter> n_(Encounter OutpatientEncounter)
		{
			var s_ = this.Advanced_Illness();
			var t_ = context.Operators.RetrieveByValueSet<Condition>(s_, null);
			bool? u_(Condition AdvancedIllnessDiagnosis)
			{
				var y_ = MATGlobalCommonFunctionsFHIR4_6_1_000.EncounterDiagnosis(OutpatientEncounter);
				var z_ = context.Operators.InList<Condition>(AdvancedIllnessDiagnosis, y_);
				var aa_ = OutpatientEncounter?.Period;
				var ab_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Normalize_Interval(aa_);
				var ac_ = context.Operators.Start(ab_);
				var ad_ = this.Measurement_Period();
				var ae_ = context.Operators.End(ad_);
				var af_ = context.Operators.Quantity(2m, "years");
				var ag_ = context.Operators.Subtract(ae_, af_);
				var ai_ = context.Operators.End(ad_);
				var aj_ = context.Operators.Interval(ag_, ai_, true, true);
				var ak_ = context.Operators.ElementInInterval<CqlDateTime>(ac_, aj_, null);
				var am_ = context.Operators.End(ad_);
				var an_ = context.Operators.Not((bool?)(am_ is null));
				var ao_ = context.Operators.And(ak_, an_);
				var ap_ = context.Operators.And(z_, ao_);

				return ap_;
			};
			var v_ = context.Operators.WhereOrNull<Condition>(t_, u_);
			Encounter w_(Condition AdvancedIllnessDiagnosis) => 
				OutpatientEncounter;
			var x_ = context.Operators.SelectOrNull<Condition, Encounter>(v_, w_);

			return x_;
		};
		var o_ = context.Operators.SelectManyOrNull<Encounter, Encounter>(m_, n_);

		return o_;
	}

    [CqlDeclaration("Outpatient Encounters with Advanced Illness")]
	public IEnumerable<Encounter> Outpatient_Encounters_with_Advanced_Illness() => 
		__Outpatient_Encounters_with_Advanced_Illness.Value;

	private IEnumerable<Encounter> Two_Outpatient_Encounters_with_Advanced_Illness_on_Different_Dates_of_Service_Value()
	{
		var a_ = this.Outpatient_Encounters_with_Advanced_Illness();
		IEnumerable<Encounter> b_(Encounter _OutpatientEncounter1)
		{
			var i_ = this.Outpatient_Encounters_with_Advanced_Illness();

			return i_;
		};
		Tuples.Tuple_EYKUVMTUWTABihhEAdHIGbSFe c_(Encounter _OutpatientEncounter1, Encounter _OutpatientEncounter2)
		{
			var j_ = new Tuples.Tuple_EYKUVMTUWTABihhEAdHIGbSFe
			{
				OutpatientEncounter1 = _OutpatientEncounter1,
				OutpatientEncounter2 = _OutpatientEncounter2,
			};

			return j_;
		};
		var d_ = context.Operators.SelectManyResultsOrNull<Encounter, Encounter, Tuples.Tuple_EYKUVMTUWTABihhEAdHIGbSFe>(a_, b_, c_);
		bool? e_(Tuples.Tuple_EYKUVMTUWTABihhEAdHIGbSFe tuple_eykuvmtuwtabihheadhigbsfe)
		{
			var k_ = tuple_eykuvmtuwtabihheadhigbsfe.OutpatientEncounter2?.Period;
			var l_ = FHIRHelpers_4_0_001.ToInterval(k_);
			var m_ = context.Operators.End(l_);
			var n_ = tuple_eykuvmtuwtabihheadhigbsfe.OutpatientEncounter1?.Period;
			var o_ = FHIRHelpers_4_0_001.ToInterval(n_);
			var p_ = context.Operators.End(o_);
			var q_ = context.Operators.Quantity(1m, "day");
			var r_ = context.Operators.Add(p_, q_);
			var s_ = context.Operators.SameOrAfter(m_, r_, "day");

			return s_;
		};
		var f_ = context.Operators.WhereOrNull<Tuples.Tuple_EYKUVMTUWTABihhEAdHIGbSFe>(d_, e_);
		Encounter g_(Tuples.Tuple_EYKUVMTUWTABihhEAdHIGbSFe tuple_eykuvmtuwtabihheadhigbsfe) => 
			tuple_eykuvmtuwtabihheadhigbsfe.OutpatientEncounter1;
		var h_ = context.Operators.SelectOrNull<Tuples.Tuple_EYKUVMTUWTABihhEAdHIGbSFe, Encounter>(f_, g_);

		return h_;
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
		IEnumerable<CqlInterval<CqlDateTime>> b_(CqlInterval<CqlDateTime> _LTCPeriod1)
		{
			var i_ = this.Long_Term_Care_Overlapping_Periods();

			return i_;
		};
		Tuples.Tuple_IWAGVXGPWIVBAWDaHPGIVVBK c_(CqlInterval<CqlDateTime> _LTCPeriod1, CqlInterval<CqlDateTime> _LTCPeriod2)
		{
			var j_ = new Tuples.Tuple_IWAGVXGPWIVBAWDaHPGIVVBK
			{
				LTCPeriod1 = _LTCPeriod1,
				LTCPeriod2 = _LTCPeriod2,
			};

			return j_;
		};
		var d_ = context.Operators.SelectManyResultsOrNull<CqlInterval<CqlDateTime>, CqlInterval<CqlDateTime>, Tuples.Tuple_IWAGVXGPWIVBAWDaHPGIVVBK>(a_, b_, c_);
		bool? e_(Tuples.Tuple_IWAGVXGPWIVBAWDaHPGIVVBK tuple_iwagvxgpwivbawdahpgivvbk)
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
		var f_ = context.Operators.WhereOrNull<Tuples.Tuple_IWAGVXGPWIVBAWDaHPGIVVBK>(d_, e_);
		CqlInterval<CqlDateTime> g_(Tuples.Tuple_IWAGVXGPWIVBAWDaHPGIVVBK tuple_iwagvxgpwivbawdahpgivvbk)
		{
			var w_ = context.Operators.Start(tuple_iwagvxgpwivbawdahpgivvbk.LTCPeriod1);
			var x_ = context.Operators.End(tuple_iwagvxgpwivbawdahpgivvbk.LTCPeriod2);
			var y_ = context.Operators.Interval(w_, x_, true, true);

			return y_;
		};
		var h_ = context.Operators.SelectOrNull<Tuples.Tuple_IWAGVXGPWIVBAWDaHPGIVVBK, CqlInterval<CqlDateTime>>(f_, g_);

		return h_;
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
		var f_ = context.Operators.SelectOrNull<CqlInterval<CqlDateTime>, int?>(d_, e_);
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
			var g_ = AcuteInpatient?.StatusElement;
			var h_ = context.Operators.Convert<string>(g_);
			var i_ = context.Operators.Equal(h_, "finished");

			return i_;
		};
		var d_ = context.Operators.WhereOrNull<Encounter>(b_, c_);
		IEnumerable<Encounter> e_(Encounter InpatientEncounter)
		{
			var j_ = this.Advanced_Illness();
			var k_ = context.Operators.RetrieveByValueSet<Condition>(j_, null);
			bool? l_(Condition AdvancedIllnessDiagnosis)
			{
				var p_ = MATGlobalCommonFunctionsFHIR4_6_1_000.EncounterDiagnosis(InpatientEncounter);
				var q_ = context.Operators.InList<Condition>(AdvancedIllnessDiagnosis, p_);
				var r_ = InpatientEncounter?.Period;
				var s_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Normalize_Interval(r_);
				var t_ = context.Operators.Start(s_);
				var u_ = this.Measurement_Period();
				var v_ = context.Operators.End(u_);
				var w_ = context.Operators.Quantity(2m, "years");
				var x_ = context.Operators.Subtract(v_, w_);
				var z_ = context.Operators.End(u_);
				var aa_ = context.Operators.Interval(x_, z_, true, true);
				var ab_ = context.Operators.ElementInInterval<CqlDateTime>(t_, aa_, null);
				var ad_ = context.Operators.End(u_);
				var ae_ = context.Operators.Not((bool?)(ad_ is null));
				var af_ = context.Operators.And(ab_, ae_);
				var ag_ = context.Operators.And(q_, af_);

				return ag_;
			};
			var m_ = context.Operators.WhereOrNull<Condition>(k_, l_);
			Encounter n_(Condition AdvancedIllnessDiagnosis) => 
				InpatientEncounter;
			var o_ = context.Operators.SelectOrNull<Condition, Encounter>(m_, n_);

			return o_;
		};
		var f_ = context.Operators.SelectManyOrNull<Encounter, Encounter>(d_, e_);

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
			var ag_ = FrailtyDeviceOrder?.StatusElement;
			var ah_ = context.Operators.Convert<string>(ag_);
			var ai_ = new string[]
			{
				"active",
				"on-hold",
				"completed",
			};
			var aj_ = context.Operators.InList<string>(ah_, (ai_ as IEnumerable<string>));
			var ak_ = FrailtyDeviceOrder?.IntentElement;
			var al_ = context.Operators.Convert<string>(ak_);
			var am_ = context.Operators.Equal(al_, "order");
			var an_ = context.Operators.And(aj_, am_);
			var ao_ = this.Measurement_Period();
			var ap_ = FrailtyDeviceOrder?.AuthoredOnElement;
			var aq_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Normalize_Interval(ap_);
			var ar_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(ao_, aq_, null);
			var as_ = context.Operators.And(an_, ar_);

			return as_;
		};
		var g_ = context.Operators.WhereOrNull<DeviceRequest>(e_, f_);
		var h_ = context.Operators.ExistsInList<DeviceRequest>(g_);
		var j_ = context.Operators.RetrieveByValueSet<Observation>(a_, null);
		bool? k_(Observation FrailtyDeviceApplied)
		{
			var at_ = FrailtyDeviceApplied?.StatusElement;
			var au_ = context.Operators.Convert<string>(at_);
			var av_ = new string[]
			{
				"final",
				"amended",
				"corrected",
			};
			var aw_ = context.Operators.InList<string>(au_, (av_ as IEnumerable<string>));
			var ax_ = FrailtyDeviceApplied?.Effective;
			var ay_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Normalize_Interval(ax_);
			var az_ = this.Measurement_Period();
			var ba_ = context.Operators.Overlaps(ay_, az_, null);
			var bb_ = context.Operators.And(aw_, ba_);

			return bb_;
		};
		var l_ = context.Operators.WhereOrNull<Observation>(j_, k_);
		var m_ = context.Operators.ExistsInList<Observation>(l_);
		var n_ = context.Operators.Or(h_, m_);
		var o_ = this.Frailty_Diagnosis();
		var p_ = context.Operators.RetrieveByValueSet<Condition>(o_, null);
		bool? q_(Condition FrailtyDiagnosis)
		{
			var bc_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Prevalence_Period(FrailtyDiagnosis);
			var bd_ = this.Measurement_Period();
			var be_ = context.Operators.Overlaps(bc_, bd_, null);

			return be_;
		};
		var r_ = context.Operators.WhereOrNull<Condition>(p_, q_);
		var s_ = context.Operators.ExistsInList<Condition>(r_);
		var t_ = context.Operators.Or(n_, s_);
		var u_ = this.Frailty_Encounter();
		var v_ = context.Operators.RetrieveByValueSet<Encounter>(u_, null);
		bool? w_(Encounter FrailtyEncounter)
		{
			var bf_ = FrailtyEncounter?.StatusElement;
			var bg_ = context.Operators.Convert<string>(bf_);
			var bh_ = context.Operators.Equal(bg_, "finished");
			var bi_ = FrailtyEncounter?.Period;
			var bj_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Normalize_Interval(bi_);
			var bk_ = this.Measurement_Period();
			var bl_ = context.Operators.Overlaps(bj_, bk_, null);
			var bm_ = context.Operators.And(bh_, bl_);

			return bm_;
		};
		var x_ = context.Operators.WhereOrNull<Encounter>(v_, w_);
		var y_ = context.Operators.ExistsInList<Encounter>(x_);
		var z_ = context.Operators.Or(t_, y_);
		var aa_ = this.Frailty_Symptom();
		var ab_ = context.Operators.RetrieveByValueSet<Observation>(aa_, null);
		bool? ac_(Observation FrailtySymptom)
		{
			var bn_ = FrailtySymptom?.StatusElement;
			var bo_ = context.Operators.Convert<string>(bn_);
			var bp_ = new string[]
			{
				"preliminary",
				"final",
				"amended",
				"corrected",
			};
			var bq_ = context.Operators.InList<string>(bo_, (bp_ as IEnumerable<string>));
			var br_ = FrailtySymptom?.Effective;
			var bs_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Normalize_Interval(br_);
			var bt_ = this.Measurement_Period();
			var bu_ = context.Operators.Overlaps(bs_, bt_, null);
			var bv_ = context.Operators.And(bq_, bu_);

			return bv_;
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
		var b_ = a_?.BirthDateElement;
		var c_ = b_?.Value;
		var d_ = context.Operators.Convert<CqlDate>(c_);
		var e_ = this.Measurement_Period();
		var f_ = context.Operators.Start(e_);
		var g_ = context.Operators.DateFrom(f_);
		var h_ = context.Operators.CalculateAgeAt(d_, g_, "year");
		var i_ = context.Operators.Interval((int?)65, (int?)79, true, true);
		var j_ = context.Operators.ElementInInterval<int?>(h_, i_, null);
		var k_ = this.Has_Criteria_Indicating_Frailty();
		var l_ = context.Operators.And(j_, k_);
		var m_ = this.Two_Outpatient_Encounters_with_Advanced_Illness_on_Different_Dates_of_Service();
		var n_ = context.Operators.ExistsInList<Encounter>(m_);
		var o_ = this.Inpatient_Encounter_with_Advanced_Illness();
		var p_ = context.Operators.ExistsInList<Encounter>(o_);
		var q_ = context.Operators.Or(n_, p_);
		var r_ = this.Dementia_Medications_In_Year_Before_or_During_Measurement_Period();
		var s_ = context.Operators.ExistsInList<MedicationRequest>(r_);
		var t_ = context.Operators.Or(q_, s_);
		var u_ = context.Operators.And(l_, t_);
		var w_ = a_?.BirthDateElement;
		var x_ = w_?.Value;
		var y_ = context.Operators.Convert<CqlDate>(x_);
		var aa_ = context.Operators.Start(e_);
		var ab_ = context.Operators.DateFrom(aa_);
		var ac_ = context.Operators.CalculateAgeAt(y_, ab_, "year");
		var ad_ = context.Operators.GreaterOrEqual(ac_, (int?)80);
		var af_ = context.Operators.And(ad_, k_);
		var ag_ = context.Operators.Or(u_, af_);

		return ag_;
	}

    [CqlDeclaration("Advanced Illness and Frailty Exclusion Including Over Age 80")]
	public bool? Advanced_Illness_and_Frailty_Exclusion_Including_Over_Age_80() => 
		__Advanced_Illness_and_Frailty_Exclusion_Including_Over_Age_80.Value;

	private bool? Advanced_Illness_and_Frailty_Exclusion_Not_Including_Over_Age_80_Value()
	{
		var a_ = this.Patient();
		var b_ = a_?.BirthDateElement;
		var c_ = b_?.Value;
		var d_ = context.Operators.Convert<CqlDate>(c_);
		var e_ = this.Measurement_Period();
		var f_ = context.Operators.Start(e_);
		var g_ = context.Operators.DateFrom(f_);
		var h_ = context.Operators.CalculateAgeAt(d_, g_, "year");
		var i_ = context.Operators.GreaterOrEqual(h_, (int?)65);
		var j_ = this.Has_Criteria_Indicating_Frailty();
		var k_ = context.Operators.And(i_, j_);
		var l_ = this.Two_Outpatient_Encounters_with_Advanced_Illness_on_Different_Dates_of_Service();
		var m_ = context.Operators.ExistsInList<Encounter>(l_);
		var n_ = this.Inpatient_Encounter_with_Advanced_Illness();
		var o_ = context.Operators.ExistsInList<Encounter>(n_);
		var p_ = context.Operators.Or(m_, o_);
		var q_ = this.Dementia_Medications_In_Year_Before_or_During_Measurement_Period();
		var r_ = context.Operators.ExistsInList<MedicationRequest>(q_);
		var s_ = context.Operators.Or(p_, r_);
		var t_ = context.Operators.And(k_, s_);

		return t_;
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