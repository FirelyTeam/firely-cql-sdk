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
		var a_ = context.Operators;
		var b_ = context.DataRetriever;
		var c_ = b_.RetrieveByValueSet<Patient>(null, null);
		var d_ = a_.SingleOrNull<Patient>(c_);

		return d_;
	}

    [CqlDeclaration("Patient")]
	public Patient Patient() => 
		__Patient.Value;

	private IEnumerable<MedicationRequest> Dementia_Medications_In_Year_Before_or_During_Measurement_Period_Value()
	{
		var a_ = context.Operators;
		var c_ = context.DataRetriever;
		var d_ = this.Dementia_Medications();
		var e_ = c_.RetrieveByValueSet<MedicationRequest>(d_, null);
		var h_ = c_.RetrieveByValueSet<MedicationRequest>(d_, null);
		var i_ = a_.ListUnion<MedicationRequest>(e_, h_);
		bool? j_(MedicationRequest DementiaMed)
		{
			var l_ = context.Operators;
			var o_ = context.Deeper(new CallStackEntry("ToString", null, null));
			var p_ = o_.Operators;
			var q_ = p_.TypeConverter;
			var r_ = DementiaMed?.StatusElement;
			var s_ = q_.Convert<string>(r_);
			var t_ = l_.Equal(s_, "active");
			var w_ = o_.Operators;
			var x_ = w_.TypeConverter;
			var y_ = DementiaMed?.IntentElement;
			var z_ = x_.Convert<string>(y_);
			var aa_ = l_.Equal(z_, "order");
			var ab_ = l_.And(t_, aa_);
			var ad_ = CumulativeMedicationDurationFHIR4_1_0_000.MedicationPeriod(DementiaMed);
			var ah_ = this.Measurement_Period();
			var ai_ = l_.Start(ah_);
			var ak_ = l_.Quantity(1m, "year");
			var al_ = l_.Subtract(ai_, ak_);
			var ao_ = l_.End(ah_);
			var ap_ = l_.Interval(al_, ao_, true, true);
			var aq_ = l_.Overlaps(ad_, ap_, null);
			var ar_ = l_.And(ab_, aq_);

			return ar_;
		};
		var k_ = a_.WhereOrNull<MedicationRequest>(i_, j_);

		return k_;
	}

    [CqlDeclaration("Dementia Medications In Year Before or During Measurement Period")]
	public IEnumerable<MedicationRequest> Dementia_Medications_In_Year_Before_or_During_Measurement_Period() => 
		__Dementia_Medications_In_Year_Before_or_During_Measurement_Period.Value;

	private IEnumerable<CqlInterval<CqlDateTime>> Long_Term_Care_Periods_During_Measurement_Period_Value()
	{
		var a_ = context.Operators;
		var d_ = context.DataRetriever;
		var e_ = this.Care_Services_in_Long_Term_Residential_Facility();
		var f_ = d_.RetrieveByValueSet<Encounter>(e_, null);
		var h_ = this.Nursing_Facility_Visit();
		var i_ = d_.RetrieveByValueSet<Encounter>(h_, null);
		var j_ = a_.ListUnion<Encounter>(f_, i_);
		bool? k_(Encounter LongTermFacilityEncounter)
		{
			var o_ = context.Operators;
			var q_ = context.Deeper(new CallStackEntry("ToString", null, null));
			var r_ = q_.Operators;
			var s_ = r_.TypeConverter;
			var t_ = LongTermFacilityEncounter?.StatusElement;
			var u_ = s_.Convert<string>(t_);
			var v_ = o_.Equal(u_, "finished");
			var x_ = LongTermFacilityEncounter?.Period;
			var y_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Normalize_Interval(x_);
			var z_ = this.Measurement_Period();
			var aa_ = o_.Overlaps(y_, z_, null);
			var ab_ = o_.And(v_, aa_);

			return ab_;
		};
		var l_ = a_.WhereOrNull<Encounter>(j_, k_);
		CqlInterval<CqlDateTime> m_(Encounter LongTermFacilityEncounter)
		{
			var ac_ = context.Operators;
			var ad_ = LongTermFacilityEncounter?.Period;
			var ae_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Normalize_Interval(ad_);
			var af_ = this.Measurement_Period();
			var ag_ = ac_.IntervalIntersectsInterval<CqlDateTime>(ae_, af_);

			return ag_;
		};
		var n_ = a_.SelectOrNull<Encounter, CqlInterval<CqlDateTime>>(l_, m_);

		return n_;
	}

    [CqlDeclaration("Long Term Care Periods During Measurement Period")]
	public IEnumerable<CqlInterval<CqlDateTime>> Long_Term_Care_Periods_During_Measurement_Period() => 
		__Long_Term_Care_Periods_During_Measurement_Period.Value;

	private IEnumerable<Encounter> Outpatient_Encounters_with_Advanced_Illness_Value()
	{
		var a_ = context.Operators;
		var e_ = context.DataRetriever;
		var f_ = this.Outpatient();
		var g_ = e_.RetrieveByValueSet<Encounter>(f_, null);
		var i_ = this.Observation();
		var j_ = e_.RetrieveByValueSet<Encounter>(i_, null);
		var k_ = a_.ListUnion<Encounter>(g_, j_);
		var n_ = this.Emergency_Department_Visit();
		var o_ = e_.RetrieveByValueSet<Encounter>(n_, null);
		var q_ = this.Nonacute_Inpatient();
		var r_ = e_.RetrieveByValueSet<Encounter>(q_, null);
		var s_ = a_.ListUnion<Encounter>(o_, r_);
		var t_ = a_.ListUnion<Encounter>(k_, s_);
		bool? u_(Encounter Outpatient)
		{
			var y_ = context.Operators;
			var z_ = context.Deeper(new CallStackEntry("ToString", null, null));
			var aa_ = z_.Operators;
			var ab_ = aa_.TypeConverter;
			var ac_ = Outpatient?.StatusElement;
			var ad_ = ab_.Convert<string>(ac_);
			var ae_ = y_.Equal(ad_, "finished");

			return ae_;
		};
		var v_ = a_.WhereOrNull<Encounter>(t_, u_);
		IEnumerable<Encounter> w_(Encounter OutpatientEncounter)
		{
			var af_ = context.Operators;
			var ah_ = context.DataRetriever;
			var ai_ = this.Advanced_Illness();
			var aj_ = ah_.RetrieveByValueSet<Condition>(ai_, null);
			bool? ak_(Condition AdvancedIllnessDiagnosis)
			{
				var ao_ = context.Operators;
				var aq_ = MATGlobalCommonFunctionsFHIR4_6_1_000.EncounterDiagnosis(OutpatientEncounter);
				var ar_ = ao_.InList<Condition>(AdvancedIllnessDiagnosis, aq_);
				var av_ = OutpatientEncounter?.Period;
				var aw_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Normalize_Interval(av_);
				var ax_ = ao_.Start(aw_);
				var bb_ = this.Measurement_Period();
				var bc_ = ao_.End(bb_);
				var be_ = ao_.Quantity(2m, "years");
				var bf_ = ao_.Subtract(bc_, be_);
				var bi_ = ao_.End(bb_);
				var bj_ = ao_.Interval(bf_, bi_, true, true);
				var bk_ = ao_.ElementInInterval<CqlDateTime>(ax_, bj_, null);
				var bo_ = ao_.End(bb_);
				var bp_ = ao_.Not((bool?)(bo_ is null));
				var bq_ = ao_.And(bk_, bp_);
				var br_ = ao_.And(ar_, bq_);

				return br_;
			};
			var al_ = af_.WhereOrNull<Condition>(aj_, ak_);
			Encounter am_(Condition AdvancedIllnessDiagnosis) => 
				OutpatientEncounter;
			var an_ = af_.SelectOrNull<Condition, Encounter>(al_, am_);

			return an_;
		};
		var x_ = a_.SelectManyOrNull<Encounter, Encounter>(v_, w_);

		return x_;
	}

    [CqlDeclaration("Outpatient Encounters with Advanced Illness")]
	public IEnumerable<Encounter> Outpatient_Encounters_with_Advanced_Illness() => 
		__Outpatient_Encounters_with_Advanced_Illness.Value;

	private IEnumerable<Encounter> Two_Outpatient_Encounters_with_Advanced_Illness_on_Different_Dates_of_Service_Value()
	{
		var a_ = context.Operators;
		var d_ = this.Outpatient_Encounters_with_Advanced_Illness();
		IEnumerable<Encounter> e_(Encounter _OutpatientEncounter1)
		{
			var l_ = this.Outpatient_Encounters_with_Advanced_Illness();

			return l_;
		};
		Tuples.Tuple_EYKUVMTUWTABihhEAdHIGbSFe f_(Encounter _OutpatientEncounter1, Encounter _OutpatientEncounter2)
		{
			var m_ = new Tuples.Tuple_EYKUVMTUWTABihhEAdHIGbSFe
			{
				OutpatientEncounter1 = _OutpatientEncounter1,
				OutpatientEncounter2 = _OutpatientEncounter2,
			};

			return m_;
		};
		var g_ = a_.SelectManyResultsOrNull<Encounter, Encounter, Tuples.Tuple_EYKUVMTUWTABihhEAdHIGbSFe>(d_, e_, f_);
		bool? h_(Tuples.Tuple_EYKUVMTUWTABihhEAdHIGbSFe tuple_eykuvmtuwtabihheadhigbsfe)
		{
			var n_ = context.Operators;
			var p_ = tuple_eykuvmtuwtabihheadhigbsfe.OutpatientEncounter2;
			var q_ = p_?.Period;
			var r_ = FHIRHelpers_4_0_001.ToInterval(q_);
			var s_ = n_.End(r_);
			var v_ = tuple_eykuvmtuwtabihheadhigbsfe.OutpatientEncounter1;
			var w_ = v_?.Period;
			var x_ = FHIRHelpers_4_0_001.ToInterval(w_);
			var y_ = n_.End(x_);
			var aa_ = n_.Quantity(1m, "day");
			var ab_ = n_.Add(y_, aa_);
			var ac_ = n_.SameOrAfter(s_, ab_, "day");

			return ac_;
		};
		var i_ = a_.WhereOrNull<Tuples.Tuple_EYKUVMTUWTABihhEAdHIGbSFe>(g_, h_);
		Encounter j_(Tuples.Tuple_EYKUVMTUWTABihhEAdHIGbSFe tuple_eykuvmtuwtabihheadhigbsfe)
		{
			var ad_ = tuple_eykuvmtuwtabihheadhigbsfe.OutpatientEncounter1;

			return ad_;
		};
		var k_ = a_.SelectOrNull<Tuples.Tuple_EYKUVMTUWTABihhEAdHIGbSFe, Encounter>(i_, j_);

		return k_;
	}

    [CqlDeclaration("Two Outpatient Encounters with Advanced Illness on Different Dates of Service")]
	public IEnumerable<Encounter> Two_Outpatient_Encounters_with_Advanced_Illness_on_Different_Dates_of_Service() => 
		__Two_Outpatient_Encounters_with_Advanced_Illness_on_Different_Dates_of_Service.Value;

	private IEnumerable<CqlInterval<CqlDateTime>> Long_Term_Care_Overlapping_Periods_Value()
	{
		var a_ = context.Operators;
		var b_ = this.Long_Term_Care_Periods_During_Measurement_Period();
		var c_ = a_.Collapse(b_, null);

		return c_;
	}

    [CqlDeclaration("Long Term Care Overlapping Periods")]
	public IEnumerable<CqlInterval<CqlDateTime>> Long_Term_Care_Overlapping_Periods() => 
		__Long_Term_Care_Overlapping_Periods.Value;

	private IEnumerable<CqlInterval<CqlDateTime>> Long_Term_Care_Adjacent_Periods_Value()
	{
		var a_ = context.Operators;
		var d_ = this.Long_Term_Care_Overlapping_Periods();
		IEnumerable<CqlInterval<CqlDateTime>> e_(CqlInterval<CqlDateTime> _LTCPeriod1)
		{
			var l_ = this.Long_Term_Care_Overlapping_Periods();

			return l_;
		};
		Tuples.Tuple_IWAGVXGPWIVBAWDaHPGIVVBK f_(CqlInterval<CqlDateTime> _LTCPeriod1, CqlInterval<CqlDateTime> _LTCPeriod2)
		{
			var m_ = new Tuples.Tuple_IWAGVXGPWIVBAWDaHPGIVVBK
			{
				LTCPeriod1 = _LTCPeriod1,
				LTCPeriod2 = _LTCPeriod2,
			};

			return m_;
		};
		var g_ = a_.SelectManyResultsOrNull<CqlInterval<CqlDateTime>, CqlInterval<CqlDateTime>, Tuples.Tuple_IWAGVXGPWIVBAWDaHPGIVVBK>(d_, e_, f_);
		bool? h_(Tuples.Tuple_IWAGVXGPWIVBAWDaHPGIVVBK tuple_iwagvxgpwivbawdahpgivvbk)
		{
			var n_ = context.Operators;
			var q_ = tuple_iwagvxgpwivbawdahpgivvbk.LTCPeriod1;
			var r_ = n_.End(q_);
			var v_ = tuple_iwagvxgpwivbawdahpgivvbk.LTCPeriod2;
			var w_ = n_.Start(v_);
			var y_ = n_.Quantity(1m, "day");
			var z_ = n_.Subtract(w_, y_);
			var ad_ = n_.Start(v_);
			var af_ = n_.Quantity(1m, "day");
			var ag_ = n_.Add(ad_, af_);
			var ah_ = n_.Interval(z_, ag_, true, true);
			var ai_ = n_.ElementInInterval<CqlDateTime>(r_, ah_, null);
			var am_ = n_.Start(v_);
			var an_ = n_.Not((bool?)(am_ is null));
			var ao_ = n_.And(ai_, an_);

			return ao_;
		};
		var i_ = a_.WhereOrNull<Tuples.Tuple_IWAGVXGPWIVBAWDaHPGIVVBK>(g_, h_);
		CqlInterval<CqlDateTime> j_(Tuples.Tuple_IWAGVXGPWIVBAWDaHPGIVVBK tuple_iwagvxgpwivbawdahpgivvbk)
		{
			var ap_ = context.Operators;
			var ar_ = tuple_iwagvxgpwivbawdahpgivvbk.LTCPeriod1;
			var as_ = ap_.Start(ar_);
			var au_ = tuple_iwagvxgpwivbawdahpgivvbk.LTCPeriod2;
			var av_ = ap_.End(au_);
			var aw_ = ap_.Interval(as_, av_, true, true);

			return aw_;
		};
		var k_ = a_.SelectOrNull<Tuples.Tuple_IWAGVXGPWIVBAWDaHPGIVVBK, CqlInterval<CqlDateTime>>(i_, j_);

		return k_;
	}

    [CqlDeclaration("Long Term Care Adjacent Periods")]
	public IEnumerable<CqlInterval<CqlDateTime>> Long_Term_Care_Adjacent_Periods() => 
		__Long_Term_Care_Adjacent_Periods.Value;

	private int? Max_Long_Term_Care_Period_Length_Value()
	{
		var a_ = context.Operators;
		var e_ = this.Long_Term_Care_Overlapping_Periods();
		var f_ = this.Long_Term_Care_Adjacent_Periods();
		var g_ = a_.ListUnion<CqlInterval<CqlDateTime>>(e_, f_);
		var h_ = a_.Collapse(g_, null);
		int? i_(CqlInterval<CqlDateTime> LTCPeriods)
		{
			var l_ = context.Operators;
			var n_ = l_.Start(LTCPeriods);
			var p_ = l_.End(LTCPeriods);
			var q_ = l_.DurationBetween(n_, p_, "day");

			return q_;
		};
		var j_ = a_.SelectOrNull<CqlInterval<CqlDateTime>, int?>(h_, i_);
		var k_ = a_.MaxOrNull<int?>(j_);

		return k_;
	}

    [CqlDeclaration("Max Long Term Care Period Length")]
	public int? Max_Long_Term_Care_Period_Length() => 
		__Max_Long_Term_Care_Period_Length.Value;

	private IEnumerable<Encounter> Inpatient_Encounter_with_Advanced_Illness_Value()
	{
		var a_ = context.Operators;
		var c_ = context.DataRetriever;
		var d_ = this.Acute_Inpatient();
		var e_ = c_.RetrieveByValueSet<Encounter>(d_, null);
		bool? f_(Encounter AcuteInpatient)
		{
			var j_ = context.Operators;
			var k_ = context.Deeper(new CallStackEntry("ToString", null, null));
			var l_ = k_.Operators;
			var m_ = l_.TypeConverter;
			var n_ = AcuteInpatient?.StatusElement;
			var o_ = m_.Convert<string>(n_);
			var p_ = j_.Equal(o_, "finished");

			return p_;
		};
		var g_ = a_.WhereOrNull<Encounter>(e_, f_);
		IEnumerable<Encounter> h_(Encounter InpatientEncounter)
		{
			var q_ = context.Operators;
			var s_ = context.DataRetriever;
			var t_ = this.Advanced_Illness();
			var u_ = s_.RetrieveByValueSet<Condition>(t_, null);
			bool? v_(Condition AdvancedIllnessDiagnosis)
			{
				var z_ = context.Operators;
				var ab_ = MATGlobalCommonFunctionsFHIR4_6_1_000.EncounterDiagnosis(InpatientEncounter);
				var ac_ = z_.InList<Condition>(AdvancedIllnessDiagnosis, ab_);
				var ag_ = InpatientEncounter?.Period;
				var ah_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Normalize_Interval(ag_);
				var ai_ = z_.Start(ah_);
				var am_ = this.Measurement_Period();
				var an_ = z_.End(am_);
				var ap_ = z_.Quantity(2m, "years");
				var aq_ = z_.Subtract(an_, ap_);
				var at_ = z_.End(am_);
				var au_ = z_.Interval(aq_, at_, true, true);
				var av_ = z_.ElementInInterval<CqlDateTime>(ai_, au_, null);
				var az_ = z_.End(am_);
				var ba_ = z_.Not((bool?)(az_ is null));
				var bb_ = z_.And(av_, ba_);
				var bc_ = z_.And(ac_, bb_);

				return bc_;
			};
			var w_ = q_.WhereOrNull<Condition>(u_, v_);
			Encounter x_(Condition AdvancedIllnessDiagnosis) => 
				InpatientEncounter;
			var y_ = q_.SelectOrNull<Condition, Encounter>(w_, x_);

			return y_;
		};
		var i_ = a_.SelectManyOrNull<Encounter, Encounter>(g_, h_);

		return i_;
	}

    [CqlDeclaration("Inpatient Encounter with Advanced Illness")]
	public IEnumerable<Encounter> Inpatient_Encounter_with_Advanced_Illness() => 
		__Inpatient_Encounter_with_Advanced_Illness.Value;

	private bool? Has_Criteria_Indicating_Frailty_Value()
	{
		var a_ = context.Operators;
		var h_ = context.DataRetriever;
		var i_ = this.Frailty_Device();
		var j_ = h_.RetrieveByValueSet<DeviceRequest>(i_, null);
		var m_ = h_.RetrieveByValueSet<DeviceRequest>(i_, null);
		var n_ = a_.ListUnion<DeviceRequest>(j_, m_);
		bool? o_(DeviceRequest FrailtyDeviceOrder)
		{
			var bb_ = context.Operators;
			var be_ = context.Deeper(new CallStackEntry("ToString", null, null));
			var bf_ = be_.Operators;
			var bg_ = bf_.TypeConverter;
			var bh_ = FrailtyDeviceOrder?.StatusElement;
			var bi_ = bg_.Convert<string>(bh_);
			var bj_ = new string[]
			{
				"active",
				"on-hold",
				"completed",
			};
			var bk_ = bb_.InList<string>(bi_, (bj_ as IEnumerable<string>));
			var bn_ = be_.Operators;
			var bo_ = bn_.TypeConverter;
			var bp_ = FrailtyDeviceOrder?.IntentElement;
			var bq_ = bo_.Convert<string>(bp_);
			var br_ = bb_.Equal(bq_, "order");
			var bs_ = bb_.And(bk_, br_);
			var bu_ = this.Measurement_Period();
			var bv_ = FrailtyDeviceOrder?.AuthoredOnElement;
			var bw_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Normalize_Interval(bv_);
			var bx_ = bb_.IntervalIncludesInterval<CqlDateTime>(bu_, bw_, null);
			var by_ = bb_.And(bs_, bx_);

			return by_;
		};
		var p_ = a_.WhereOrNull<DeviceRequest>(n_, o_);
		var q_ = a_.ExistsInList<DeviceRequest>(p_);
		var v_ = h_.RetrieveByValueSet<Observation>(i_, null);
		bool? w_(Observation FrailtyDeviceApplied)
		{
			var bz_ = context.Operators;
			var cb_ = context.Deeper(new CallStackEntry("ToString", null, null));
			var cc_ = cb_.Operators;
			var cd_ = cc_.TypeConverter;
			var ce_ = FrailtyDeviceApplied?.StatusElement;
			var cf_ = cd_.Convert<string>(ce_);
			var cg_ = new string[]
			{
				"final",
				"amended",
				"corrected",
			};
			var ch_ = bz_.InList<string>(cf_, (cg_ as IEnumerable<string>));
			var cj_ = FrailtyDeviceApplied?.Effective;
			var ck_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Normalize_Interval(cj_);
			var cl_ = this.Measurement_Period();
			var cm_ = bz_.Overlaps(ck_, cl_, null);
			var cn_ = bz_.And(ch_, cm_);

			return cn_;
		};
		var x_ = a_.WhereOrNull<Observation>(v_, w_);
		var y_ = a_.ExistsInList<Observation>(x_);
		var z_ = a_.Or(q_, y_);
		var ad_ = this.Frailty_Diagnosis();
		var ae_ = h_.RetrieveByValueSet<Condition>(ad_, null);
		bool? af_(Condition FrailtyDiagnosis)
		{
			var co_ = context.Operators;
			var cp_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Prevalence_Period(FrailtyDiagnosis);
			var cq_ = this.Measurement_Period();
			var cr_ = co_.Overlaps(cp_, cq_, null);

			return cr_;
		};
		var ag_ = a_.WhereOrNull<Condition>(ae_, af_);
		var ah_ = a_.ExistsInList<Condition>(ag_);
		var ai_ = a_.Or(z_, ah_);
		var am_ = this.Frailty_Encounter();
		var an_ = h_.RetrieveByValueSet<Encounter>(am_, null);
		bool? ao_(Encounter FrailtyEncounter)
		{
			var cs_ = context.Operators;
			var cu_ = context.Deeper(new CallStackEntry("ToString", null, null));
			var cv_ = cu_.Operators;
			var cw_ = cv_.TypeConverter;
			var cx_ = FrailtyEncounter?.StatusElement;
			var cy_ = cw_.Convert<string>(cx_);
			var cz_ = cs_.Equal(cy_, "finished");
			var db_ = FrailtyEncounter?.Period;
			var dc_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Normalize_Interval(db_);
			var dd_ = this.Measurement_Period();
			var de_ = cs_.Overlaps(dc_, dd_, null);
			var df_ = cs_.And(cz_, de_);

			return df_;
		};
		var ap_ = a_.WhereOrNull<Encounter>(an_, ao_);
		var aq_ = a_.ExistsInList<Encounter>(ap_);
		var ar_ = a_.Or(ai_, aq_);
		var av_ = this.Frailty_Symptom();
		var aw_ = h_.RetrieveByValueSet<Observation>(av_, null);
		bool? ax_(Observation FrailtySymptom)
		{
			var dg_ = context.Operators;
			var di_ = context.Deeper(new CallStackEntry("ToString", null, null));
			var dj_ = di_.Operators;
			var dk_ = dj_.TypeConverter;
			var dl_ = FrailtySymptom?.StatusElement;
			var dm_ = dk_.Convert<string>(dl_);
			var dn_ = new string[]
			{
				"preliminary",
				"final",
				"amended",
				"corrected",
			};
			var do_ = dg_.InList<string>(dm_, (dn_ as IEnumerable<string>));
			var dq_ = FrailtySymptom?.Effective;
			var dr_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Normalize_Interval(dq_);
			var ds_ = this.Measurement_Period();
			var dt_ = dg_.Overlaps(dr_, ds_, null);
			var du_ = dg_.And(do_, dt_);

			return du_;
		};
		var ay_ = a_.WhereOrNull<Observation>(aw_, ax_);
		var az_ = a_.ExistsInList<Observation>(ay_);
		var ba_ = a_.Or(ar_, az_);

		return ba_;
	}

    [CqlDeclaration("Has Criteria Indicating Frailty")]
	public bool? Has_Criteria_Indicating_Frailty() => 
		__Has_Criteria_Indicating_Frailty.Value;

	private bool? Advanced_Illness_and_Frailty_Exclusion_Including_Over_Age_80_Value()
	{
		var a_ = context.Operators;
		var g_ = a_.TypeConverter;
		var h_ = this.Patient();
		var i_ = h_?.BirthDateElement;
		var j_ = i_?.Value;
		var k_ = g_.Convert<CqlDate>(j_);
		var n_ = this.Measurement_Period();
		var o_ = a_.Start(n_);
		var p_ = a_.DateFrom(o_);
		var q_ = a_.CalculateAgeAt(k_, p_, "year");
		var s_ = a_.Interval((int?)65, (int?)79, true, true);
		var t_ = a_.ElementInInterval<int?>(q_, s_, null);
		var u_ = this.Has_Criteria_Indicating_Frailty();
		var v_ = a_.And(t_, u_);
		var z_ = this.Two_Outpatient_Encounters_with_Advanced_Illness_on_Different_Dates_of_Service();
		var aa_ = a_.ExistsInList<Encounter>(z_);
		var ac_ = this.Inpatient_Encounter_with_Advanced_Illness();
		var ad_ = a_.ExistsInList<Encounter>(ac_);
		var ae_ = a_.Or(aa_, ad_);
		var ag_ = this.Dementia_Medications_In_Year_Before_or_During_Measurement_Period();
		var ah_ = a_.ExistsInList<MedicationRequest>(ag_);
		var ai_ = a_.Or(ae_, ah_);
		var aj_ = a_.And(v_, ai_);
		var ao_ = a_.TypeConverter;
		var aq_ = h_?.BirthDateElement;
		var ar_ = aq_?.Value;
		var as_ = ao_.Convert<CqlDate>(ar_);
		var aw_ = a_.Start(n_);
		var ax_ = a_.DateFrom(aw_);
		var ay_ = a_.CalculateAgeAt(as_, ax_, "year");
		var az_ = a_.GreaterOrEqual(ay_, (int?)80);
		var bb_ = a_.And(az_, u_);
		var bc_ = a_.Or(aj_, bb_);

		return bc_;
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
		var n_ = a_.Start(m_);
		var o_ = a_.DateFrom(n_);
		var p_ = a_.CalculateAgeAt(j_, o_, "year");
		var q_ = a_.GreaterOrEqual(p_, (int?)65);
		var r_ = this.Has_Criteria_Indicating_Frailty();
		var s_ = a_.And(q_, r_);
		var w_ = this.Two_Outpatient_Encounters_with_Advanced_Illness_on_Different_Dates_of_Service();
		var x_ = a_.ExistsInList<Encounter>(w_);
		var z_ = this.Inpatient_Encounter_with_Advanced_Illness();
		var aa_ = a_.ExistsInList<Encounter>(z_);
		var ab_ = a_.Or(x_, aa_);
		var ad_ = this.Dementia_Medications_In_Year_Before_or_During_Measurement_Period();
		var ae_ = a_.ExistsInList<MedicationRequest>(ad_);
		var af_ = a_.Or(ab_, ae_);
		var ag_ = a_.And(s_, af_);

		return ag_;
	}

    [CqlDeclaration("Advanced Illness and Frailty Exclusion Not Including Over Age 80")]
	public bool? Advanced_Illness_and_Frailty_Exclusion_Not_Including_Over_Age_80() => 
		__Advanced_Illness_and_Frailty_Exclusion_Not_Including_Over_Age_80.Value;

	private bool? Has_Long_Term_Care_Periods_Longer_Than_90_Consecutive_Days_Value()
	{
		var a_ = context.Operators;
		var b_ = this.Max_Long_Term_Care_Period_Length();
		var c_ = a_.Greater(b_, (int?)90);

		return c_;
	}

    [CqlDeclaration("Has Long Term Care Periods Longer Than 90 Consecutive Days")]
	public bool? Has_Long_Term_Care_Periods_Longer_Than_90_Consecutive_Days() => 
		__Has_Long_Term_Care_Periods_Longer_Than_90_Consecutive_Days.Value;

}