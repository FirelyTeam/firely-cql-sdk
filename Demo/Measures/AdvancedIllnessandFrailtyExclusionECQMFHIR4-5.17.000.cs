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
    public CqlValueSet Acute_Inpatient() => __Acute_Inpatient.Value;

    private CqlValueSet Advanced_Illness_Value() =>
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.110.12.1082", null);

    [CqlDeclaration("Advanced Illness")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.110.12.1082")]
    public CqlValueSet Advanced_Illness() => __Advanced_Illness.Value;

    private CqlValueSet Care_Services_in_Long_Term_Residential_Facility_Value() =>
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1014", null);

    [CqlDeclaration("Care Services in Long-Term Residential Facility")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1014")]
    public CqlValueSet Care_Services_in_Long_Term_Residential_Facility() => __Care_Services_in_Long_Term_Residential_Facility.Value;

    private CqlValueSet Dementia_Medications_Value() =>
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.196.12.1510", null);

    [CqlDeclaration("Dementia Medications")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.196.12.1510")]
    public CqlValueSet Dementia_Medications() => __Dementia_Medications.Value;

    private CqlValueSet Emergency_Department_Visit_Value() =>
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1010", null);

    [CqlDeclaration("Emergency Department Visit")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1010")]
    public CqlValueSet Emergency_Department_Visit() => __Emergency_Department_Visit.Value;

    private CqlValueSet Frailty_Device_Value() =>
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.118.12.1300", null);

    [CqlDeclaration("Frailty Device")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.118.12.1300")]
    public CqlValueSet Frailty_Device() => __Frailty_Device.Value;

    private CqlValueSet Frailty_Diagnosis_Value() =>
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.113.12.1074", null);

    [CqlDeclaration("Frailty Diagnosis")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.113.12.1074")]
    public CqlValueSet Frailty_Diagnosis() => __Frailty_Diagnosis.Value;

    private CqlValueSet Frailty_Encounter_Value() =>
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1088", null);

    [CqlDeclaration("Frailty Encounter")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1088")]
    public CqlValueSet Frailty_Encounter() => __Frailty_Encounter.Value;

    private CqlValueSet Frailty_Symptom_Value() =>
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.113.12.1075", null);

    [CqlDeclaration("Frailty Symptom")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.113.12.1075")]
    public CqlValueSet Frailty_Symptom() => __Frailty_Symptom.Value;

    private CqlValueSet Nonacute_Inpatient_Value() =>
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1084", null);

    [CqlDeclaration("Nonacute Inpatient")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1084")]
    public CqlValueSet Nonacute_Inpatient() => __Nonacute_Inpatient.Value;

    private CqlValueSet Nursing_Facility_Visit_Value() =>
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1012", null);

    [CqlDeclaration("Nursing Facility Visit")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1012")]
    public CqlValueSet Nursing_Facility_Visit() => __Nursing_Facility_Visit.Value;

    private CqlValueSet Observation_Value() =>
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1086", null);

    [CqlDeclaration("Observation")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1086")]
    public CqlValueSet Observation() => __Observation.Value;

    private CqlValueSet Outpatient_Value() =>
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1087", null);

    [CqlDeclaration("Outpatient")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1087")]
    public CqlValueSet Outpatient() => __Outpatient.Value;

    private CqlInterval<CqlDateTime> Measurement_Period_Value()
	{
		var a_ = context.ResolveParameter("AdvancedIllnessandFrailtyExclusionECQMFHIR4-5.17.000", "Measurement Period", null);

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

    private IEnumerable<MedicationRequest> Dementia_Medications_In_Year_Before_or_During_Measurement_Period_Value()
	{
		var a_ = this.Dementia_Medications();
		var b_ = context.DataRetriever;
		var c_ = b_.RetrieveByValueSet<MedicationRequest>(a_, null);
		var f_ = b_.RetrieveByValueSet<MedicationRequest>(a_, null);
		var g_ = context.Operators;
		var h_ = g_.ListUnion<MedicationRequest>(c_, f_);
		bool? i_(MedicationRequest DementiaMed)
		{
			var l_ = DementiaMed?.StatusElement;
			var m_ = new CallStackEntry("ToString", null, null);
			var n_ = context.Deeper(m_);
			var o_ = n_.Operators;
			var p_ = o_.TypeConverter;
			var q_ = p_.Convert<string>(l_);
			var r_ = context.Operators;
			var s_ = r_.Equal(q_, "active");
			var t_ = DementiaMed?.IntentElement;
			var v_ = context.Deeper(m_);
			var w_ = v_.Operators;
			var x_ = w_.TypeConverter;
			var y_ = x_.Convert<string>(t_);
			var aa_ = r_.Equal(y_, "order");
			var ac_ = r_.And(s_, aa_);
			var ad_ = CumulativeMedicationDurationFHIR4_1_0_000.MedicationPeriod(DementiaMed);
			var ae_ = this.Measurement_Period();
			var ag_ = r_.Start(ae_);
			var ai_ = r_.Quantity(1m, "year");
			var ak_ = r_.Subtract(ag_, ai_);
			var an_ = r_.End(ae_);
			var ap_ = r_.Interval(ak_, an_, true, true);
			var ar_ = r_.Overlaps(ad_, ap_, null);
			var at_ = r_.And(ac_, ar_);

			return at_;
		};
		var k_ = g_.WhereOrNull<MedicationRequest>(h_, i_);

		return k_;
	}

    [CqlDeclaration("Dementia Medications In Year Before or During Measurement Period")]
    public IEnumerable<MedicationRequest> Dementia_Medications_In_Year_Before_or_During_Measurement_Period() => __Dementia_Medications_In_Year_Before_or_During_Measurement_Period.Value;

    private IEnumerable<CqlInterval<CqlDateTime>> Long_Term_Care_Periods_During_Measurement_Period_Value()
	{
		var a_ = this.Care_Services_in_Long_Term_Residential_Facility();
		var b_ = context.DataRetriever;
		var c_ = b_.RetrieveByValueSet<Encounter>(a_, null);
		var d_ = this.Nursing_Facility_Visit();
		var f_ = b_.RetrieveByValueSet<Encounter>(d_, null);
		var g_ = context.Operators;
		var h_ = g_.ListUnion<Encounter>(c_, f_);
		bool? i_(Encounter LongTermFacilityEncounter)
		{
			var o_ = LongTermFacilityEncounter?.StatusElement;
			var p_ = new CallStackEntry("ToString", null, null);
			var q_ = context.Deeper(p_);
			var r_ = q_.Operators;
			var s_ = r_.TypeConverter;
			var t_ = s_.Convert<string>(o_);
			var u_ = context.Operators;
			var v_ = u_.Equal(t_, "finished");
			var w_ = LongTermFacilityEncounter?.Period;
			var x_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Normalize_Interval(w_);
			var y_ = this.Measurement_Period();
			var aa_ = u_.Overlaps(x_, y_, null);
			var ac_ = u_.And(v_, aa_);

			return ac_;
		};
		var k_ = g_.WhereOrNull<Encounter>(h_, i_);
		CqlInterval<CqlDateTime> l_(Encounter LongTermFacilityEncounter)
		{
			var ad_ = LongTermFacilityEncounter?.Period;
			var ae_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Normalize_Interval(ad_);
			var af_ = this.Measurement_Period();
			var ag_ = context.Operators;
			var ah_ = ag_.IntervalIntersectsInterval<CqlDateTime>(ae_, af_);

			return ah_;
		};
		var n_ = g_.SelectOrNull<Encounter, CqlInterval<CqlDateTime>>(k_, l_);

		return n_;
	}

    [CqlDeclaration("Long Term Care Periods During Measurement Period")]
    public IEnumerable<CqlInterval<CqlDateTime>> Long_Term_Care_Periods_During_Measurement_Period() => __Long_Term_Care_Periods_During_Measurement_Period.Value;

    private IEnumerable<Encounter> Outpatient_Encounters_with_Advanced_Illness_Value()
	{
		var a_ = this.Outpatient();
		var b_ = context.DataRetriever;
		var c_ = b_.RetrieveByValueSet<Encounter>(a_, null);
		var d_ = this.Observation();
		var f_ = b_.RetrieveByValueSet<Encounter>(d_, null);
		var g_ = context.Operators;
		var h_ = g_.ListUnion<Encounter>(c_, f_);
		var i_ = this.Emergency_Department_Visit();
		var k_ = b_.RetrieveByValueSet<Encounter>(i_, null);
		var l_ = this.Nonacute_Inpatient();
		var n_ = b_.RetrieveByValueSet<Encounter>(l_, null);
		var p_ = g_.ListUnion<Encounter>(k_, n_);
		var r_ = g_.ListUnion<Encounter>(h_, p_);
		bool? s_(Encounter Outpatient)
		{
			var y_ = Outpatient?.StatusElement;
			var z_ = new CallStackEntry("ToString", null, null);
			var aa_ = context.Deeper(z_);
			var ab_ = aa_.Operators;
			var ac_ = ab_.TypeConverter;
			var ad_ = ac_.Convert<string>(y_);
			var ae_ = context.Operators;
			var af_ = ae_.Equal(ad_, "finished");

			return af_;
		};
		var u_ = g_.WhereOrNull<Encounter>(r_, s_);
		IEnumerable<Encounter> v_(Encounter OutpatientEncounter)
		{
			var ag_ = this.Advanced_Illness();
			var ah_ = context.DataRetriever;
			var ai_ = ah_.RetrieveByValueSet<Condition>(ag_, null);
			bool? aj_(Condition AdvancedIllnessDiagnosis)
			{
				var ap_ = MATGlobalCommonFunctionsFHIR4_6_1_000.EncounterDiagnosis(OutpatientEncounter);
				var aq_ = context.Operators;
				var ar_ = aq_.InList<Condition>(AdvancedIllnessDiagnosis, ap_);
				var as_ = OutpatientEncounter?.Period;
				var at_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Normalize_Interval(as_);
				var av_ = aq_.Start(at_);
				var aw_ = this.Measurement_Period();
				var ay_ = aq_.End(aw_);
				var ba_ = aq_.Quantity(2m, "years");
				var bc_ = aq_.Subtract(ay_, ba_);
				var bf_ = aq_.End(aw_);
				var bh_ = aq_.Interval(bc_, bf_, true, true);
				var bj_ = aq_.ElementInInterval<CqlDateTime>(av_, bh_, null);
				var bm_ = aq_.End(aw_);
				var bo_ = aq_.Not((bool?)(bm_ is null));
				var bq_ = aq_.And(bj_, bo_);
				var bs_ = aq_.And(ar_, bq_);

				return bs_;
			};
			var ak_ = context.Operators;
			var al_ = ak_.WhereOrNull<Condition>(ai_, aj_);
			Encounter am_(Condition AdvancedIllnessDiagnosis) => OutpatientEncounter;
			var ao_ = ak_.SelectOrNull<Condition, Encounter>(al_, am_);

			return ao_;
		};
		var x_ = g_.SelectManyOrNull<Encounter, Encounter>(u_, v_);

		return x_;
	}

    [CqlDeclaration("Outpatient Encounters with Advanced Illness")]
    public IEnumerable<Encounter> Outpatient_Encounters_with_Advanced_Illness() => __Outpatient_Encounters_with_Advanced_Illness.Value;

    private IEnumerable<Encounter> Two_Outpatient_Encounters_with_Advanced_Illness_on_Different_Dates_of_Service_Value()
	{
		var a_ = this.Outpatient_Encounters_with_Advanced_Illness();
		IEnumerable<Encounter> b_(Encounter _OutpatientEncounter1)
		{
			var l_ = this.Outpatient_Encounters_with_Advanced_Illness();

			return l_;
		};
		Tuples.Tuple_EYKUVMTUWTABihhEAdHIGbSFe c_(Encounter _OutpatientEncounter1, Encounter _OutpatientEncounter2)
		{
			var m_ = new Tuples.Tuple_EYKUVMTUWTABihhEAdHIGbSFe
			{
				OutpatientEncounter1 = _OutpatientEncounter1,
				OutpatientEncounter2 = _OutpatientEncounter2,
			};

			return m_;
		};
		var d_ = context.Operators;
		var e_ = d_.SelectManyResultsOrNull<Encounter, Encounter, Tuples.Tuple_EYKUVMTUWTABihhEAdHIGbSFe>(a_, b_, c_);
		bool? f_(Tuples.Tuple_EYKUVMTUWTABihhEAdHIGbSFe tuple_eykuvmtuwtabihheadhigbsfe)
		{
			var n_ = tuple_eykuvmtuwtabihheadhigbsfe.OutpatientEncounter2;
			var o_ = n_?.Period;
			var p_ = FHIRHelpers_4_0_001.ToInterval(o_);
			var q_ = context.Operators;
			var r_ = q_.End(p_);
			var s_ = tuple_eykuvmtuwtabihheadhigbsfe.OutpatientEncounter1;
			var t_ = s_?.Period;
			var u_ = FHIRHelpers_4_0_001.ToInterval(t_);
			var w_ = q_.End(u_);
			var y_ = q_.Quantity(1m, "day");
			var aa_ = q_.Add(w_, y_);
			var ac_ = q_.SameOrAfter(r_, aa_, "day");

			return ac_;
		};
		var h_ = d_.WhereOrNull<Tuples.Tuple_EYKUVMTUWTABihhEAdHIGbSFe>(e_, f_);
		Encounter i_(Tuples.Tuple_EYKUVMTUWTABihhEAdHIGbSFe tuple_eykuvmtuwtabihheadhigbsfe)
		{
			var ad_ = tuple_eykuvmtuwtabihheadhigbsfe.OutpatientEncounter1;

			return ad_;
		};
		var k_ = d_.SelectOrNull<Tuples.Tuple_EYKUVMTUWTABihhEAdHIGbSFe, Encounter>(h_, i_);

		return k_;
	}

    [CqlDeclaration("Two Outpatient Encounters with Advanced Illness on Different Dates of Service")]
    public IEnumerable<Encounter> Two_Outpatient_Encounters_with_Advanced_Illness_on_Different_Dates_of_Service() => __Two_Outpatient_Encounters_with_Advanced_Illness_on_Different_Dates_of_Service.Value;

    private IEnumerable<CqlInterval<CqlDateTime>> Long_Term_Care_Overlapping_Periods_Value()
	{
		var a_ = this.Long_Term_Care_Periods_During_Measurement_Period();
		var b_ = context.Operators;
		var c_ = b_.Collapse(a_, null);

		return c_;
	}

    [CqlDeclaration("Long Term Care Overlapping Periods")]
    public IEnumerable<CqlInterval<CqlDateTime>> Long_Term_Care_Overlapping_Periods() => __Long_Term_Care_Overlapping_Periods.Value;

    private IEnumerable<CqlInterval<CqlDateTime>> Long_Term_Care_Adjacent_Periods_Value()
	{
		var a_ = this.Long_Term_Care_Overlapping_Periods();
		IEnumerable<CqlInterval<CqlDateTime>> b_(CqlInterval<CqlDateTime> _LTCPeriod1)
		{
			var l_ = this.Long_Term_Care_Overlapping_Periods();

			return l_;
		};
		Tuples.Tuple_IWAGVXGPWIVBAWDaHPGIVVBK c_(CqlInterval<CqlDateTime> _LTCPeriod1, CqlInterval<CqlDateTime> _LTCPeriod2)
		{
			var m_ = new Tuples.Tuple_IWAGVXGPWIVBAWDaHPGIVVBK
			{
				LTCPeriod1 = _LTCPeriod1,
				LTCPeriod2 = _LTCPeriod2,
			};

			return m_;
		};
		var d_ = context.Operators;
		var e_ = d_.SelectManyResultsOrNull<CqlInterval<CqlDateTime>, CqlInterval<CqlDateTime>, Tuples.Tuple_IWAGVXGPWIVBAWDaHPGIVVBK>(a_, b_, c_);
		bool? f_(Tuples.Tuple_IWAGVXGPWIVBAWDaHPGIVVBK tuple_iwagvxgpwivbawdahpgivvbk)
		{
			var n_ = tuple_iwagvxgpwivbawdahpgivvbk.LTCPeriod1;
			var o_ = context.Operators;
			var p_ = o_.End(n_);
			var q_ = tuple_iwagvxgpwivbawdahpgivvbk.LTCPeriod2;
			var s_ = o_.Start(q_);
			var u_ = o_.Quantity(1m, "day");
			var w_ = o_.Subtract(s_, u_);
			var z_ = o_.Start(q_);
			var ab_ = o_.Quantity(1m, "day");
			var ad_ = o_.Add(z_, ab_);
			var af_ = o_.Interval(w_, ad_, true, true);
			var ah_ = o_.ElementInInterval<CqlDateTime>(p_, af_, null);
			var ak_ = o_.Start(q_);
			var am_ = o_.Not((bool?)(ak_ is null));
			var ao_ = o_.And(ah_, am_);

			return ao_;
		};
		var h_ = d_.WhereOrNull<Tuples.Tuple_IWAGVXGPWIVBAWDaHPGIVVBK>(e_, f_);
		CqlInterval<CqlDateTime> i_(Tuples.Tuple_IWAGVXGPWIVBAWDaHPGIVVBK tuple_iwagvxgpwivbawdahpgivvbk)
		{
			var ap_ = tuple_iwagvxgpwivbawdahpgivvbk.LTCPeriod1;
			var aq_ = context.Operators;
			var ar_ = aq_.Start(ap_);
			var as_ = tuple_iwagvxgpwivbawdahpgivvbk.LTCPeriod2;
			var au_ = aq_.End(as_);
			var aw_ = aq_.Interval(ar_, au_, true, true);

			return aw_;
		};
		var k_ = d_.SelectOrNull<Tuples.Tuple_IWAGVXGPWIVBAWDaHPGIVVBK, CqlInterval<CqlDateTime>>(h_, i_);

		return k_;
	}

    [CqlDeclaration("Long Term Care Adjacent Periods")]
    public IEnumerable<CqlInterval<CqlDateTime>> Long_Term_Care_Adjacent_Periods() => __Long_Term_Care_Adjacent_Periods.Value;

    private int? Max_Long_Term_Care_Period_Length_Value()
	{
		var a_ = this.Long_Term_Care_Overlapping_Periods();
		var b_ = this.Long_Term_Care_Adjacent_Periods();
		var c_ = context.Operators;
		var d_ = c_.ListUnion<CqlInterval<CqlDateTime>>(a_, b_);
		var f_ = c_.Collapse(d_, null);
		int? g_(CqlInterval<CqlDateTime> LTCPeriods)
		{
			var l_ = context.Operators;
			var m_ = l_.Start(LTCPeriods);
			var o_ = l_.End(LTCPeriods);
			var q_ = l_.DurationBetween(m_, o_, "day");

			return q_;
		};
		var i_ = c_.SelectOrNull<CqlInterval<CqlDateTime>, int?>(f_, g_);
		var k_ = c_.MaxOrNull<int?>(i_);

		return k_;
	}

    [CqlDeclaration("Max Long Term Care Period Length")]
    public int? Max_Long_Term_Care_Period_Length() => __Max_Long_Term_Care_Period_Length.Value;

    private IEnumerable<Encounter> Inpatient_Encounter_with_Advanced_Illness_Value()
	{
		var a_ = this.Acute_Inpatient();
		var b_ = context.DataRetriever;
		var c_ = b_.RetrieveByValueSet<Encounter>(a_, null);
		bool? d_(Encounter AcuteInpatient)
		{
			var j_ = AcuteInpatient?.StatusElement;
			var k_ = new CallStackEntry("ToString", null, null);
			var l_ = context.Deeper(k_);
			var m_ = l_.Operators;
			var n_ = m_.TypeConverter;
			var o_ = n_.Convert<string>(j_);
			var p_ = context.Operators;
			var q_ = p_.Equal(o_, "finished");

			return q_;
		};
		var e_ = context.Operators;
		var f_ = e_.WhereOrNull<Encounter>(c_, d_);
		IEnumerable<Encounter> g_(Encounter InpatientEncounter)
		{
			var r_ = this.Advanced_Illness();
			var s_ = context.DataRetriever;
			var t_ = s_.RetrieveByValueSet<Condition>(r_, null);
			bool? u_(Condition AdvancedIllnessDiagnosis)
			{
				var aa_ = MATGlobalCommonFunctionsFHIR4_6_1_000.EncounterDiagnosis(InpatientEncounter);
				var ab_ = context.Operators;
				var ac_ = ab_.InList<Condition>(AdvancedIllnessDiagnosis, aa_);
				var ad_ = InpatientEncounter?.Period;
				var ae_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Normalize_Interval(ad_);
				var ag_ = ab_.Start(ae_);
				var ah_ = this.Measurement_Period();
				var aj_ = ab_.End(ah_);
				var al_ = ab_.Quantity(2m, "years");
				var an_ = ab_.Subtract(aj_, al_);
				var aq_ = ab_.End(ah_);
				var as_ = ab_.Interval(an_, aq_, true, true);
				var au_ = ab_.ElementInInterval<CqlDateTime>(ag_, as_, null);
				var ax_ = ab_.End(ah_);
				var az_ = ab_.Not((bool?)(ax_ is null));
				var bb_ = ab_.And(au_, az_);
				var bd_ = ab_.And(ac_, bb_);

				return bd_;
			};
			var v_ = context.Operators;
			var w_ = v_.WhereOrNull<Condition>(t_, u_);
			Encounter x_(Condition AdvancedIllnessDiagnosis) => InpatientEncounter;
			var z_ = v_.SelectOrNull<Condition, Encounter>(w_, x_);

			return z_;
		};
		var i_ = e_.SelectManyOrNull<Encounter, Encounter>(f_, g_);

		return i_;
	}

    [CqlDeclaration("Inpatient Encounter with Advanced Illness")]
    public IEnumerable<Encounter> Inpatient_Encounter_with_Advanced_Illness() => __Inpatient_Encounter_with_Advanced_Illness.Value;

    private bool? Has_Criteria_Indicating_Frailty_Value()
	{
		var a_ = this.Frailty_Device();
		var b_ = context.DataRetriever;
		var c_ = b_.RetrieveByValueSet<DeviceRequest>(a_, null);
		var f_ = b_.RetrieveByValueSet<DeviceRequest>(a_, null);
		var g_ = context.Operators;
		var h_ = g_.ListUnion<DeviceRequest>(c_, f_);
		bool? i_(DeviceRequest FrailtyDeviceOrder)
		{
			var bb_ = FrailtyDeviceOrder?.StatusElement;
			var bc_ = new CallStackEntry("ToString", null, null);
			var bd_ = context.Deeper(bc_);
			var be_ = bd_.Operators;
			var bf_ = be_.TypeConverter;
			var bg_ = bf_.Convert<string>(bb_);
			var bh_ = new string[]
			{
				"active",
				"on-hold",
				"completed",
			};
			var bi_ = context.Operators;
			var bj_ = bi_.InList<string>(bg_, (bh_ as IEnumerable<string>));
			var bk_ = FrailtyDeviceOrder?.IntentElement;
			var bm_ = context.Deeper(bc_);
			var bn_ = bm_.Operators;
			var bo_ = bn_.TypeConverter;
			var bp_ = bo_.Convert<string>(bk_);
			var br_ = bi_.Equal(bp_, "order");
			var bt_ = bi_.And(bj_, br_);
			var bu_ = this.Measurement_Period();
			var bv_ = FrailtyDeviceOrder?.AuthoredOnElement;
			var bw_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Normalize_Interval(bv_);
			var by_ = bi_.IntervalIncludesInterval<CqlDateTime>(bu_, bw_, null);
			var ca_ = bi_.And(bt_, by_);

			return ca_;
		};
		var k_ = g_.WhereOrNull<DeviceRequest>(h_, i_);
		var m_ = g_.ExistsInList<DeviceRequest>(k_);
		var p_ = b_.RetrieveByValueSet<Observation>(a_, null);
		bool? q_(Observation FrailtyDeviceApplied)
		{
			var cb_ = FrailtyDeviceApplied?.StatusElement;
			var cc_ = new CallStackEntry("ToString", null, null);
			var cd_ = context.Deeper(cc_);
			var ce_ = cd_.Operators;
			var cf_ = ce_.TypeConverter;
			var cg_ = cf_.Convert<string>(cb_);
			var ch_ = new string[]
			{
				"final",
				"amended",
				"corrected",
			};
			var ci_ = context.Operators;
			var cj_ = ci_.InList<string>(cg_, (ch_ as IEnumerable<string>));
			var ck_ = FrailtyDeviceApplied?.Effective;
			var cl_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Normalize_Interval(ck_);
			var cm_ = this.Measurement_Period();
			var co_ = ci_.Overlaps(cl_, cm_, null);
			var cq_ = ci_.And(cj_, co_);

			return cq_;
		};
		var s_ = g_.WhereOrNull<Observation>(p_, q_);
		var u_ = g_.ExistsInList<Observation>(s_);
		var w_ = g_.Or(m_, u_);
		var x_ = this.Frailty_Diagnosis();
		var z_ = b_.RetrieveByValueSet<Condition>(x_, null);
		bool? aa_(Condition FrailtyDiagnosis)
		{
			var cr_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Prevalence_Period(FrailtyDiagnosis);
			var cs_ = this.Measurement_Period();
			var ct_ = context.Operators;
			var cu_ = ct_.Overlaps(cr_, cs_, null);

			return cu_;
		};
		var ac_ = g_.WhereOrNull<Condition>(z_, aa_);
		var ae_ = g_.ExistsInList<Condition>(ac_);
		var ag_ = g_.Or(w_, ae_);
		var ah_ = this.Frailty_Encounter();
		var aj_ = b_.RetrieveByValueSet<Encounter>(ah_, null);
		bool? ak_(Encounter FrailtyEncounter)
		{
			var cv_ = FrailtyEncounter?.StatusElement;
			var cw_ = new CallStackEntry("ToString", null, null);
			var cx_ = context.Deeper(cw_);
			var cy_ = cx_.Operators;
			var cz_ = cy_.TypeConverter;
			var da_ = cz_.Convert<string>(cv_);
			var db_ = context.Operators;
			var dc_ = db_.Equal(da_, "finished");
			var dd_ = FrailtyEncounter?.Period;
			var de_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Normalize_Interval(dd_);
			var df_ = this.Measurement_Period();
			var dh_ = db_.Overlaps(de_, df_, null);
			var dj_ = db_.And(dc_, dh_);

			return dj_;
		};
		var am_ = g_.WhereOrNull<Encounter>(aj_, ak_);
		var ao_ = g_.ExistsInList<Encounter>(am_);
		var aq_ = g_.Or(ag_, ao_);
		var ar_ = this.Frailty_Symptom();
		var at_ = b_.RetrieveByValueSet<Observation>(ar_, null);
		bool? au_(Observation FrailtySymptom)
		{
			var dk_ = FrailtySymptom?.StatusElement;
			var dl_ = new CallStackEntry("ToString", null, null);
			var dm_ = context.Deeper(dl_);
			var dn_ = dm_.Operators;
			var do_ = dn_.TypeConverter;
			var dp_ = do_.Convert<string>(dk_);
			var dq_ = new string[]
			{
				"preliminary",
				"final",
				"amended",
				"corrected",
			};
			var dr_ = context.Operators;
			var ds_ = dr_.InList<string>(dp_, (dq_ as IEnumerable<string>));
			var dt_ = FrailtySymptom?.Effective;
			var du_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Normalize_Interval(dt_);
			var dv_ = this.Measurement_Period();
			var dx_ = dr_.Overlaps(du_, dv_, null);
			var dz_ = dr_.And(ds_, dx_);

			return dz_;
		};
		var aw_ = g_.WhereOrNull<Observation>(at_, au_);
		var ay_ = g_.ExistsInList<Observation>(aw_);
		var ba_ = g_.Or(aq_, ay_);

		return ba_;
	}

    [CqlDeclaration("Has Criteria Indicating Frailty")]
    public bool? Has_Criteria_Indicating_Frailty() => __Has_Criteria_Indicating_Frailty.Value;

    private bool? Advanced_Illness_and_Frailty_Exclusion_Including_Over_Age_80_Value()
	{
		var a_ = this.Patient();
		var b_ = a_?.BirthDateElement;
		var c_ = b_?.Value;
		var d_ = context.Operators;
		var e_ = d_.TypeConverter;
		var f_ = e_.Convert<CqlDate>(c_);
		var g_ = this.Measurement_Period();
		var i_ = d_.Start(g_);
		var k_ = d_.DateFrom(i_);
		var m_ = d_.CalculateAgeAt(f_, k_, "year");
		var o_ = d_.Interval((int?)65, (int?)79, true, true);
		var q_ = d_.ElementInInterval<int?>(m_, o_, null);
		var r_ = this.Has_Criteria_Indicating_Frailty();
		var t_ = d_.And(q_, r_);
		var u_ = this.Two_Outpatient_Encounters_with_Advanced_Illness_on_Different_Dates_of_Service();
		var w_ = d_.ExistsInList<Encounter>(u_);
		var x_ = this.Inpatient_Encounter_with_Advanced_Illness();
		var z_ = d_.ExistsInList<Encounter>(x_);
		var ab_ = d_.Or(w_, z_);
		var ac_ = this.Dementia_Medications_In_Year_Before_or_During_Measurement_Period();
		var ae_ = d_.ExistsInList<MedicationRequest>(ac_);
		var ag_ = d_.Or(ab_, ae_);
		var ai_ = d_.And(t_, ag_);
		var ak_ = a_?.BirthDateElement;
		var al_ = ak_?.Value;
		var an_ = d_.TypeConverter;
		var ao_ = an_.Convert<CqlDate>(al_);
		var ar_ = d_.Start(g_);
		var at_ = d_.DateFrom(ar_);
		var av_ = d_.CalculateAgeAt(ao_, at_, "year");
		var ax_ = d_.GreaterOrEqual(av_, (int?)80);
		var ba_ = d_.And(ax_, r_);
		var bc_ = d_.Or(ai_, ba_);

		return bc_;
	}

    [CqlDeclaration("Advanced Illness and Frailty Exclusion Including Over Age 80")]
    public bool? Advanced_Illness_and_Frailty_Exclusion_Including_Over_Age_80() => __Advanced_Illness_and_Frailty_Exclusion_Including_Over_Age_80.Value;

    private bool? Advanced_Illness_and_Frailty_Exclusion_Not_Including_Over_Age_80_Value()
	{
		var a_ = this.Patient();
		var b_ = a_?.BirthDateElement;
		var c_ = b_?.Value;
		var d_ = context.Operators;
		var e_ = d_.TypeConverter;
		var f_ = e_.Convert<CqlDate>(c_);
		var g_ = this.Measurement_Period();
		var i_ = d_.Start(g_);
		var k_ = d_.DateFrom(i_);
		var m_ = d_.CalculateAgeAt(f_, k_, "year");
		var o_ = d_.GreaterOrEqual(m_, (int?)65);
		var p_ = this.Has_Criteria_Indicating_Frailty();
		var r_ = d_.And(o_, p_);
		var s_ = this.Two_Outpatient_Encounters_with_Advanced_Illness_on_Different_Dates_of_Service();
		var u_ = d_.ExistsInList<Encounter>(s_);
		var v_ = this.Inpatient_Encounter_with_Advanced_Illness();
		var x_ = d_.ExistsInList<Encounter>(v_);
		var z_ = d_.Or(u_, x_);
		var aa_ = this.Dementia_Medications_In_Year_Before_or_During_Measurement_Period();
		var ac_ = d_.ExistsInList<MedicationRequest>(aa_);
		var ae_ = d_.Or(z_, ac_);
		var ag_ = d_.And(r_, ae_);

		return ag_;
	}

    [CqlDeclaration("Advanced Illness and Frailty Exclusion Not Including Over Age 80")]
    public bool? Advanced_Illness_and_Frailty_Exclusion_Not_Including_Over_Age_80() => __Advanced_Illness_and_Frailty_Exclusion_Not_Including_Over_Age_80.Value;

    private bool? Has_Long_Term_Care_Periods_Longer_Than_90_Consecutive_Days_Value()
	{
		var a_ = this.Max_Long_Term_Care_Period_Length();
		var b_ = context.Operators;
		var c_ = b_.Greater(a_, (int?)90);

		return c_;
	}

    [CqlDeclaration("Has Long Term Care Periods Longer Than 90 Consecutive Days")]
    public bool? Has_Long_Term_Care_Periods_Longer_Than_90_Consecutive_Days() => __Has_Long_Term_Care_Periods_Longer_Than_90_Consecutive_Days.Value;

}