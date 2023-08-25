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

    private CqlValueSet Acute_Inpatient_Value()
	{
		var a_ = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1083", null);

		return a_;
	}

    [CqlDeclaration("Acute Inpatient")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1083")]
    public CqlValueSet Acute_Inpatient() => __Acute_Inpatient.Value;

    private CqlValueSet Advanced_Illness_Value()
	{
		var a_ = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.110.12.1082", null);

		return a_;
	}

    [CqlDeclaration("Advanced Illness")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.110.12.1082")]
    public CqlValueSet Advanced_Illness() => __Advanced_Illness.Value;

    private CqlValueSet Care_Services_in_Long_Term_Residential_Facility_Value()
	{
		var a_ = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1014", null);

		return a_;
	}

    [CqlDeclaration("Care Services in Long-Term Residential Facility")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1014")]
    public CqlValueSet Care_Services_in_Long_Term_Residential_Facility() => __Care_Services_in_Long_Term_Residential_Facility.Value;

    private CqlValueSet Dementia_Medications_Value()
	{
		var a_ = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.196.12.1510", null);

		return a_;
	}

    [CqlDeclaration("Dementia Medications")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.196.12.1510")]
    public CqlValueSet Dementia_Medications() => __Dementia_Medications.Value;

    private CqlValueSet Emergency_Department_Visit_Value()
	{
		var a_ = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1010", null);

		return a_;
	}

    [CqlDeclaration("Emergency Department Visit")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1010")]
    public CqlValueSet Emergency_Department_Visit() => __Emergency_Department_Visit.Value;

    private CqlValueSet Frailty_Device_Value()
	{
		var a_ = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.118.12.1300", null);

		return a_;
	}

    [CqlDeclaration("Frailty Device")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.118.12.1300")]
    public CqlValueSet Frailty_Device() => __Frailty_Device.Value;

    private CqlValueSet Frailty_Diagnosis_Value()
	{
		var a_ = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.113.12.1074", null);

		return a_;
	}

    [CqlDeclaration("Frailty Diagnosis")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.113.12.1074")]
    public CqlValueSet Frailty_Diagnosis() => __Frailty_Diagnosis.Value;

    private CqlValueSet Frailty_Encounter_Value()
	{
		var a_ = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1088", null);

		return a_;
	}

    [CqlDeclaration("Frailty Encounter")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1088")]
    public CqlValueSet Frailty_Encounter() => __Frailty_Encounter.Value;

    private CqlValueSet Frailty_Symptom_Value()
	{
		var a_ = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.113.12.1075", null);

		return a_;
	}

    [CqlDeclaration("Frailty Symptom")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.113.12.1075")]
    public CqlValueSet Frailty_Symptom() => __Frailty_Symptom.Value;

    private CqlValueSet Nonacute_Inpatient_Value()
	{
		var a_ = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1084", null);

		return a_;
	}

    [CqlDeclaration("Nonacute Inpatient")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1084")]
    public CqlValueSet Nonacute_Inpatient() => __Nonacute_Inpatient.Value;

    private CqlValueSet Nursing_Facility_Visit_Value()
	{
		var a_ = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1012", null);

		return a_;
	}

    [CqlDeclaration("Nursing Facility Visit")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1012")]
    public CqlValueSet Nursing_Facility_Visit() => __Nursing_Facility_Visit.Value;

    private CqlValueSet Observation_Value()
	{
		var a_ = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1086", null);

		return a_;
	}

    [CqlDeclaration("Observation")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1086")]
    public CqlValueSet Observation() => __Observation.Value;

    private CqlValueSet Outpatient_Value()
	{
		var a_ = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1087", null);

		return a_;
	}

    [CqlDeclaration("Outpatient")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1087")]
    public CqlValueSet Outpatient() => __Outpatient.Value;

    private CqlInterval<CqlDateTime> Measurement_Period_Value()
	{
		var a_ = context.ResolveParameter("AdvancedIllnessandFrailtyExclusionECQMFHIR4-5.17.000", "Measurement Period", null);
		var b_ = (CqlInterval<CqlDateTime>)a_;

		return b_;
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
		var i_ = (MedicationRequest DementiaMed) =>
		{
			var l_ = DementiaMed.StatusElement;
			var m_ = new CallStackEntry("ToString", null, null);
			var n_ = context.Deeper(m_);
			var o_ = n_.Operators;
			var p_ = o_.TypeConverter;
			var q_ = p_.Convert<string>(l_);
			var r_ = context.Operators;
			var s_ = r_.Equal(q_, "active");
			var t_ = DementiaMed.IntentElement;
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
		var i_ = (Encounter LongTermFacilityEncounter) =>
		{
			var o_ = LongTermFacilityEncounter.StatusElement;
			var p_ = new CallStackEntry("ToString", null, null);
			var q_ = context.Deeper(p_);
			var r_ = q_.Operators;
			var s_ = r_.TypeConverter;
			var t_ = s_.Convert<string>(o_);
			var u_ = context.Operators;
			var v_ = u_.Equal(t_, "finished");
			var w_ = LongTermFacilityEncounter.Period;
			var x_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Normalize_Interval(w_);
			var y_ = this.Measurement_Period();
			var aa_ = u_.Overlaps(x_, y_, null);
			var ac_ = u_.And(v_, aa_);

			return ac_;
		};
		var k_ = g_.WhereOrNull<Encounter>(h_, i_);
		var l_ = (Encounter LongTermFacilityEncounter) =>
		{
			var ad_ = LongTermFacilityEncounter.Period;
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
		var s_ = (Encounter Outpatient) =>
		{
			var y_ = Outpatient.StatusElement;
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
		var v_ = (Encounter OutpatientEncounter) =>
		{
			var ag_ = this.Advanced_Illness();
			var ah_ = context.DataRetriever;
			var ai_ = ah_.RetrieveByValueSet<Condition>(ag_, null);
			var aj_ = (Condition AdvancedIllnessDiagnosis) =>
			{
				var ap_ = MATGlobalCommonFunctionsFHIR4_6_1_000.EncounterDiagnosis(OutpatientEncounter);
				var aq_ = context.Operators;
				var ar_ = aq_.InList<Condition>(AdvancedIllnessDiagnosis, ap_);
				var as_ = OutpatientEncounter.Period;
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
				var bn_ = (bm_ == null);
				var bo_ = (bool?)bn_;
				var bq_ = aq_.Not(bo_);
				var bs_ = aq_.And(bj_, bq_);
				var bu_ = aq_.And(ar_, bs_);

				return bu_;
			};
			var ak_ = context.Operators;
			var al_ = ak_.WhereOrNull<Condition>(ai_, aj_);
			var am_ = (Condition AdvancedIllnessDiagnosis) => OutpatientEncounter;
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
		var b_ = (Encounter _OutpatientEncounter1) =>
		{
			var l_ = this.Outpatient_Encounters_with_Advanced_Illness();

			return l_;
		};
		var c_ = (Encounter _OutpatientEncounter1, Encounter _OutpatientEncounter2) =>
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
		var f_ = (Tuples.Tuple_EYKUVMTUWTABihhEAdHIGbSFe tuple_eykuvmtuwtabihheadhigbsfe) =>
		{
			var n_ = tuple_eykuvmtuwtabihheadhigbsfe.OutpatientEncounter2;
			var o_ = n_.Period;
			var p_ = FHIRHelpers_4_0_001.ToInterval(o_);
			var q_ = context.Operators;
			var r_ = q_.End(p_);
			var s_ = tuple_eykuvmtuwtabihheadhigbsfe.OutpatientEncounter1;
			var t_ = s_.Period;
			var u_ = FHIRHelpers_4_0_001.ToInterval(t_);
			var w_ = q_.End(u_);
			var y_ = q_.Quantity(1m, "day");
			var aa_ = q_.Add(w_, y_);
			var ac_ = q_.SameOrAfter(r_, aa_, "day");

			return ac_;
		};
		var h_ = d_.WhereOrNull<Tuples.Tuple_EYKUVMTUWTABihhEAdHIGbSFe>(e_, f_);
		var i_ = (Tuples.Tuple_EYKUVMTUWTABihhEAdHIGbSFe tuple_eykuvmtuwtabihheadhigbsfe) =>
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
		var b_ = (CqlInterval<CqlDateTime> _LTCPeriod1) =>
		{
			var l_ = this.Long_Term_Care_Overlapping_Periods();

			return l_;
		};
		var c_ = (CqlInterval<CqlDateTime> _LTCPeriod1, CqlInterval<CqlDateTime> _LTCPeriod2) =>
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
		var f_ = (Tuples.Tuple_IWAGVXGPWIVBAWDaHPGIVVBK tuple_iwagvxgpwivbawdahpgivvbk) =>
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
			var al_ = (ak_ == null);
			var am_ = (bool?)al_;
			var ao_ = o_.Not(am_);
			var aq_ = o_.And(ah_, ao_);

			return aq_;
		};
		var h_ = d_.WhereOrNull<Tuples.Tuple_IWAGVXGPWIVBAWDaHPGIVVBK>(e_, f_);
		var i_ = (Tuples.Tuple_IWAGVXGPWIVBAWDaHPGIVVBK tuple_iwagvxgpwivbawdahpgivvbk) =>
		{
			var ar_ = tuple_iwagvxgpwivbawdahpgivvbk.LTCPeriod1;
			var as_ = context.Operators;
			var at_ = as_.Start(ar_);
			var au_ = tuple_iwagvxgpwivbawdahpgivvbk.LTCPeriod2;
			var aw_ = as_.End(au_);
			var ay_ = as_.Interval(at_, aw_, true, true);

			return ay_;
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
		var g_ = (CqlInterval<CqlDateTime> LTCPeriods) =>
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
		var d_ = (Encounter AcuteInpatient) =>
		{
			var j_ = AcuteInpatient.StatusElement;
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
		var g_ = (Encounter InpatientEncounter) =>
		{
			var r_ = this.Advanced_Illness();
			var s_ = context.DataRetriever;
			var t_ = s_.RetrieveByValueSet<Condition>(r_, null);
			var u_ = (Condition AdvancedIllnessDiagnosis) =>
			{
				var aa_ = MATGlobalCommonFunctionsFHIR4_6_1_000.EncounterDiagnosis(InpatientEncounter);
				var ab_ = context.Operators;
				var ac_ = ab_.InList<Condition>(AdvancedIllnessDiagnosis, aa_);
				var ad_ = InpatientEncounter.Period;
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
				var ay_ = (ax_ == null);
				var az_ = (bool?)ay_;
				var bb_ = ab_.Not(az_);
				var bd_ = ab_.And(au_, bb_);
				var bf_ = ab_.And(ac_, bd_);

				return bf_;
			};
			var v_ = context.Operators;
			var w_ = v_.WhereOrNull<Condition>(t_, u_);
			var x_ = (Condition AdvancedIllnessDiagnosis) => InpatientEncounter;
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
		var i_ = (DeviceRequest FrailtyDeviceOrder) =>
		{
			var bb_ = FrailtyDeviceOrder.StatusElement;
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
			var bi_ = (bh_ as IEnumerable<string>);
			var bj_ = context.Operators;
			var bk_ = bj_.InList<string>(bg_, bi_);
			var bl_ = FrailtyDeviceOrder.IntentElement;
			var bn_ = context.Deeper(bc_);
			var bo_ = bn_.Operators;
			var bp_ = bo_.TypeConverter;
			var bq_ = bp_.Convert<string>(bl_);
			var bs_ = bj_.Equal(bq_, "order");
			var bu_ = bj_.And(bk_, bs_);
			var bv_ = this.Measurement_Period();
			var bw_ = FrailtyDeviceOrder.AuthoredOnElement;
			var bx_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Normalize_Interval(bw_);
			var bz_ = bj_.IntervalIncludesInterval<CqlDateTime>(bv_, bx_, null);
			var cb_ = bj_.And(bu_, bz_);

			return cb_;
		};
		var k_ = g_.WhereOrNull<DeviceRequest>(h_, i_);
		var m_ = g_.ExistsInList<DeviceRequest>(k_);
		var p_ = b_.RetrieveByValueSet<Observation>(a_, null);
		var q_ = (Observation FrailtyDeviceApplied) =>
		{
			var cc_ = FrailtyDeviceApplied.StatusElement;
			var cd_ = new CallStackEntry("ToString", null, null);
			var ce_ = context.Deeper(cd_);
			var cf_ = ce_.Operators;
			var cg_ = cf_.TypeConverter;
			var ch_ = cg_.Convert<string>(cc_);
			var ci_ = new string[]
			{
				"final",
				"amended",
				"corrected",
			};
			var cj_ = (ci_ as IEnumerable<string>);
			var ck_ = context.Operators;
			var cl_ = ck_.InList<string>(ch_, cj_);
			var cm_ = FrailtyDeviceApplied.Effective;
			var cn_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Normalize_Interval(cm_);
			var co_ = this.Measurement_Period();
			var cq_ = ck_.Overlaps(cn_, co_, null);
			var cs_ = ck_.And(cl_, cq_);

			return cs_;
		};
		var s_ = g_.WhereOrNull<Observation>(p_, q_);
		var u_ = g_.ExistsInList<Observation>(s_);
		var w_ = g_.Or(m_, u_);
		var x_ = this.Frailty_Diagnosis();
		var z_ = b_.RetrieveByValueSet<Condition>(x_, null);
		var aa_ = (Condition FrailtyDiagnosis) =>
		{
			var ct_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Prevalence_Period(FrailtyDiagnosis);
			var cu_ = this.Measurement_Period();
			var cv_ = context.Operators;
			var cw_ = cv_.Overlaps(ct_, cu_, null);

			return cw_;
		};
		var ac_ = g_.WhereOrNull<Condition>(z_, aa_);
		var ae_ = g_.ExistsInList<Condition>(ac_);
		var ag_ = g_.Or(w_, ae_);
		var ah_ = this.Frailty_Encounter();
		var aj_ = b_.RetrieveByValueSet<Encounter>(ah_, null);
		var ak_ = (Encounter FrailtyEncounter) =>
		{
			var cx_ = FrailtyEncounter.StatusElement;
			var cy_ = new CallStackEntry("ToString", null, null);
			var cz_ = context.Deeper(cy_);
			var da_ = cz_.Operators;
			var db_ = da_.TypeConverter;
			var dc_ = db_.Convert<string>(cx_);
			var dd_ = context.Operators;
			var de_ = dd_.Equal(dc_, "finished");
			var df_ = FrailtyEncounter.Period;
			var dg_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Normalize_Interval(df_);
			var dh_ = this.Measurement_Period();
			var dj_ = dd_.Overlaps(dg_, dh_, null);
			var dl_ = dd_.And(de_, dj_);

			return dl_;
		};
		var am_ = g_.WhereOrNull<Encounter>(aj_, ak_);
		var ao_ = g_.ExistsInList<Encounter>(am_);
		var aq_ = g_.Or(ag_, ao_);
		var ar_ = this.Frailty_Symptom();
		var at_ = b_.RetrieveByValueSet<Observation>(ar_, null);
		var au_ = (Observation FrailtySymptom) =>
		{
			var dm_ = FrailtySymptom.StatusElement;
			var dn_ = new CallStackEntry("ToString", null, null);
			var do_ = context.Deeper(dn_);
			var dp_ = do_.Operators;
			var dq_ = dp_.TypeConverter;
			var dr_ = dq_.Convert<string>(dm_);
			var ds_ = new string[]
			{
				"preliminary",
				"final",
				"amended",
				"corrected",
			};
			var dt_ = (ds_ as IEnumerable<string>);
			var du_ = context.Operators;
			var dv_ = du_.InList<string>(dr_, dt_);
			var dw_ = FrailtySymptom.Effective;
			var dx_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Normalize_Interval(dw_);
			var dy_ = this.Measurement_Period();
			var ea_ = du_.Overlaps(dx_, dy_, null);
			var ec_ = du_.And(dv_, ea_);

			return ec_;
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
		var b_ = a_.BirthDateElement;
		var c_ = b_.Value;
		var d_ = context.Operators;
		var e_ = d_.TypeConverter;
		var f_ = e_.Convert<CqlDate>(c_);
		var g_ = this.Measurement_Period();
		var i_ = d_.Start(g_);
		var k_ = d_.DateFrom(i_);
		var m_ = d_.CalculateAgeAt(f_, k_, "year");
		var n_ = (int?)65;
		var o_ = (int?)79;
		var q_ = d_.Interval(n_, o_, true, true);
		var s_ = d_.ElementInInterval<int?>(m_, q_, null);
		var t_ = this.Has_Criteria_Indicating_Frailty();
		var v_ = d_.And(s_, t_);
		var w_ = this.Two_Outpatient_Encounters_with_Advanced_Illness_on_Different_Dates_of_Service();
		var y_ = d_.ExistsInList<Encounter>(w_);
		var z_ = this.Inpatient_Encounter_with_Advanced_Illness();
		var ab_ = d_.ExistsInList<Encounter>(z_);
		var ad_ = d_.Or(y_, ab_);
		var ae_ = this.Dementia_Medications_In_Year_Before_or_During_Measurement_Period();
		var ag_ = d_.ExistsInList<MedicationRequest>(ae_);
		var ai_ = d_.Or(ad_, ag_);
		var ak_ = d_.And(v_, ai_);
		var am_ = a_.BirthDateElement;
		var an_ = am_.Value;
		var ap_ = d_.TypeConverter;
		var aq_ = ap_.Convert<CqlDate>(an_);
		var at_ = d_.Start(g_);
		var av_ = d_.DateFrom(at_);
		var ax_ = d_.CalculateAgeAt(aq_, av_, "year");
		var ay_ = ax_;
		var az_ = (int?)80;
		var ba_ = az_;
		var bc_ = d_.GreaterOrEqual(ay_, ba_);
		var bf_ = d_.And(bc_, t_);
		var bh_ = d_.Or(ak_, bf_);

		return bh_;
	}

    [CqlDeclaration("Advanced Illness and Frailty Exclusion Including Over Age 80")]
    public bool? Advanced_Illness_and_Frailty_Exclusion_Including_Over_Age_80() => __Advanced_Illness_and_Frailty_Exclusion_Including_Over_Age_80.Value;

    private bool? Advanced_Illness_and_Frailty_Exclusion_Not_Including_Over_Age_80_Value()
	{
		var a_ = this.Patient();
		var b_ = a_.BirthDateElement;
		var c_ = b_.Value;
		var d_ = context.Operators;
		var e_ = d_.TypeConverter;
		var f_ = e_.Convert<CqlDate>(c_);
		var g_ = this.Measurement_Period();
		var i_ = d_.Start(g_);
		var k_ = d_.DateFrom(i_);
		var m_ = d_.CalculateAgeAt(f_, k_, "year");
		var n_ = m_;
		var o_ = (int?)65;
		var p_ = o_;
		var r_ = d_.GreaterOrEqual(n_, p_);
		var s_ = this.Has_Criteria_Indicating_Frailty();
		var u_ = d_.And(r_, s_);
		var v_ = this.Two_Outpatient_Encounters_with_Advanced_Illness_on_Different_Dates_of_Service();
		var x_ = d_.ExistsInList<Encounter>(v_);
		var y_ = this.Inpatient_Encounter_with_Advanced_Illness();
		var aa_ = d_.ExistsInList<Encounter>(y_);
		var ac_ = d_.Or(x_, aa_);
		var ad_ = this.Dementia_Medications_In_Year_Before_or_During_Measurement_Period();
		var af_ = d_.ExistsInList<MedicationRequest>(ad_);
		var ah_ = d_.Or(ac_, af_);
		var aj_ = d_.And(u_, ah_);

		return aj_;
	}

    [CqlDeclaration("Advanced Illness and Frailty Exclusion Not Including Over Age 80")]
    public bool? Advanced_Illness_and_Frailty_Exclusion_Not_Including_Over_Age_80() => __Advanced_Illness_and_Frailty_Exclusion_Not_Including_Over_Age_80.Value;

    private bool? Has_Long_Term_Care_Periods_Longer_Than_90_Consecutive_Days_Value()
	{
		var a_ = this.Max_Long_Term_Care_Period_Length();
		var b_ = a_;
		var c_ = (int?)90;
		var d_ = c_;
		var e_ = context.Operators;
		var f_ = e_.Greater(b_, d_);

		return f_;
	}

    [CqlDeclaration("Has Long Term Care Periods Longer Than 90 Consecutive Days")]
    public bool? Has_Long_Term_Care_Periods_Longer_Than_90_Consecutive_Days() => __Has_Long_Term_Care_Periods_Longer_Than_90_Consecutive_Days.Value;

}