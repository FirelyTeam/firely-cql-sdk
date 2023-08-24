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

    private CqlInterval<CqlDateTime> Measurement_Period_Value() =>
		(CqlInterval<CqlDateTime>)context.ResolveParameter("AdvancedIllnessandFrailtyExclusionECQMFHIR4-5.17.000", "Measurement Period", null);

    [CqlDeclaration("Measurement Period")]
    public CqlInterval<CqlDateTime> Measurement_Period() => __Measurement_Period.Value;

    private Patient Patient_Value()
	{
		var a_ = context?.DataRetriever.RetrieveByValueSet<Patient>(null, null);

		return context?.Operators.SingleOrNull<Patient>(a_);
	}

    [CqlDeclaration("Patient")]
    public Patient Patient() => __Patient.Value;

    private IEnumerable<MedicationRequest> Dementia_Medications_In_Year_Before_or_During_Measurement_Period_Value()
	{
		var s_ = this.Dementia_Medications();
		var t_ = context?.DataRetriever.RetrieveByValueSet<MedicationRequest>(s_, null);
		var u_ = this.Dementia_Medications();
		var v_ = context?.DataRetriever.RetrieveByValueSet<MedicationRequest>(u_, null);
		var w_ = context?.Operators.ListUnion<MedicationRequest>(t_, v_);
		var x_ = (MedicationRequest DementiaMed) =>
		{
			var a_ = (DementiaMed?.StatusElement as object);
			var b_ = (context.Deeper(new CallStackEntry("ToString", null, null))?.Operators?.TypeConverter).Convert<string>(a_);
			var c_ = (b_ as object);
			var d_ = context?.Operators.Equal(c_, ("active" as object));
			var e_ = (DementiaMed?.IntentElement as object);
			var f_ = (context.Deeper(new CallStackEntry("ToString", null, null))?.Operators?.TypeConverter).Convert<string>(e_);
			var g_ = (f_ as object);
			var h_ = context?.Operators.Equal(g_, ("order" as object));
			var i_ = context?.Operators.And(d_, h_);
			var j_ = CumulativeMedicationDurationFHIR4_1_0_000.MedicationPeriod((DementiaMed as object));
			var k_ = this.Measurement_Period();
			var l_ = context?.Operators.Start(k_);
			var m_ = context?.Operators.Quantity(1m, "year");
			var n_ = context?.Operators.Subtract(l_, m_);
			var o_ = this.Measurement_Period();
			var p_ = context?.Operators.End(o_);
			var q_ = context?.Operators.Interval(n_, p_, true, true);
			var r_ = context?.Operators.Overlaps(j_, q_, null);

			return context?.Operators.And(i_, r_);
		};

		return context?.Operators.WhereOrNull<MedicationRequest>(w_, x_);
	}

    [CqlDeclaration("Dementia Medications In Year Before or During Measurement Period")]
    public IEnumerable<MedicationRequest> Dementia_Medications_In_Year_Before_or_During_Measurement_Period() => __Dementia_Medications_In_Year_Before_or_During_Measurement_Period.Value;

    private IEnumerable<CqlInterval<CqlDateTime>> Long_Term_Care_Periods_During_Measurement_Period_Value()
	{
		var l_ = this.Care_Services_in_Long_Term_Residential_Facility();
		var m_ = context?.DataRetriever.RetrieveByValueSet<Encounter>(l_, null);
		var n_ = this.Nursing_Facility_Visit();
		var o_ = context?.DataRetriever.RetrieveByValueSet<Encounter>(n_, null);
		var p_ = context?.Operators.ListUnion<Encounter>(m_, o_);
		var q_ = (Encounter LongTermFacilityEncounter) =>
		{
			var a_ = (LongTermFacilityEncounter?.StatusElement as object);
			var b_ = (context.Deeper(new CallStackEntry("ToString", null, null))?.Operators?.TypeConverter).Convert<string>(a_);
			var c_ = (b_ as object);
			var d_ = context?.Operators.Equal(c_, ("finished" as object));
			var e_ = (LongTermFacilityEncounter?.Period as object);
			var f_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Normalize_Interval(e_);
			var g_ = this.Measurement_Period();
			var h_ = context?.Operators.Overlaps(f_, g_, null);

			return context?.Operators.And(d_, h_);
		};
		var r_ = context?.Operators.WhereOrNull<Encounter>(p_, q_);
		var s_ = (Encounter LongTermFacilityEncounter) =>
		{
			var i_ = (LongTermFacilityEncounter?.Period as object);
			var j_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Normalize_Interval(i_);
			var k_ = this.Measurement_Period();

			return context?.Operators.IntervalIntersectsInterval<CqlDateTime>(j_, k_);
		};

		return context?.Operators.SelectOrNull<Encounter, CqlInterval<CqlDateTime>>(r_, s_);
	}

    [CqlDeclaration("Long Term Care Periods During Measurement Period")]
    public IEnumerable<CqlInterval<CqlDateTime>> Long_Term_Care_Periods_During_Measurement_Period() => __Long_Term_Care_Periods_During_Measurement_Period.Value;

    private IEnumerable<Encounter> Outpatient_Encounters_with_Advanced_Illness_Value()
	{
		var aa_ = this.Outpatient();
		var ab_ = context?.DataRetriever.RetrieveByValueSet<Encounter>(aa_, null);
		var ac_ = this.Observation();
		var ad_ = context?.DataRetriever.RetrieveByValueSet<Encounter>(ac_, null);
		var ae_ = context?.Operators.ListUnion<Encounter>(ab_, ad_);
		var af_ = this.Emergency_Department_Visit();
		var ag_ = context?.DataRetriever.RetrieveByValueSet<Encounter>(af_, null);
		var ah_ = this.Nonacute_Inpatient();
		var ai_ = context?.DataRetriever.RetrieveByValueSet<Encounter>(ah_, null);
		var aj_ = context?.Operators.ListUnion<Encounter>(ag_, ai_);
		var ak_ = context?.Operators.ListUnion<Encounter>(ae_, aj_);
		var al_ = (Encounter Outpatient) =>
		{
			var a_ = (Outpatient?.StatusElement as object);
			var b_ = (context.Deeper(new CallStackEntry("ToString", null, null))?.Operators?.TypeConverter).Convert<string>(a_);
			var c_ = (b_ as object);

			return context?.Operators.Equal(c_, ("finished" as object));
		};
		var am_ = context?.Operators.WhereOrNull<Encounter>(ak_, al_);
		var an_ = (Encounter OutpatientEncounter) =>
		{
			var v_ = this.Advanced_Illness();
			var w_ = context?.DataRetriever.RetrieveByValueSet<Condition>(v_, null);
			var x_ = (Condition AdvancedIllnessDiagnosis) =>
			{
				var d_ = MATGlobalCommonFunctionsFHIR4_6_1_000.EncounterDiagnosis(OutpatientEncounter);
				var e_ = context?.Operators.InList<Condition>(AdvancedIllnessDiagnosis, d_);
				var f_ = (OutpatientEncounter?.Period as object);
				var g_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Normalize_Interval(f_);
				var h_ = context?.Operators.Start(g_);
				var i_ = this.Measurement_Period();
				var j_ = context?.Operators.End(i_);
				var k_ = context?.Operators.Quantity(2m, "years");
				var l_ = context?.Operators.Subtract(j_, k_);
				var m_ = this.Measurement_Period();
				var n_ = context?.Operators.End(m_);
				var o_ = context?.Operators.Interval(l_, n_, true, true);
				var p_ = context?.Operators.ElementInInterval<CqlDateTime>(h_, o_, null);
				var q_ = this.Measurement_Period();
				var r_ = context?.Operators.End(q_);
				var s_ = (bool?)(r_ == null);
				var t_ = context?.Operators.Not(s_);
				var u_ = context?.Operators.And(p_, t_);

				return context?.Operators.And(e_, u_);
			};
			var y_ = context?.Operators.WhereOrNull<Condition>(w_, x_);
			var z_ = (Condition AdvancedIllnessDiagnosis) => OutpatientEncounter;

			return context?.Operators.SelectOrNull<Condition, Encounter>(y_, z_);
		};

		return context?.Operators.SelectManyOrNull<Encounter, Encounter>(am_, an_);
	}

    [CqlDeclaration("Outpatient Encounters with Advanced Illness")]
    public IEnumerable<Encounter> Outpatient_Encounters_with_Advanced_Illness() => __Outpatient_Encounters_with_Advanced_Illness.Value;

    private IEnumerable<Encounter> Two_Outpatient_Encounters_with_Advanced_Illness_on_Different_Dates_of_Service_Value()
	{
		var k_ = this.Outpatient_Encounters_with_Advanced_Illness();
		var l_ = (Encounter _OutpatientEncounter1) => this.Outpatient_Encounters_with_Advanced_Illness();
		var m_ = (Encounter _OutpatientEncounter1, Encounter _OutpatientEncounter2) =>
		{
			var a_ = _OutpatientEncounter1;
			var b_ = _OutpatientEncounter2;

			return new Tuples.Tuple_EYKUVMTUWTABihhEAdHIGbSFe
			{
				OutpatientEncounter1 = a_,
				OutpatientEncounter2 = b_,
			};
		};
		var n_ = context?.Operators.SelectManyResultsOrNull<Encounter, Encounter, Tuples.Tuple_EYKUVMTUWTABihhEAdHIGbSFe>(k_, l_, m_);
		var o_ = (Tuples.Tuple_EYKUVMTUWTABihhEAdHIGbSFe tuple_eykuvmtuwtabihheadhigbsfe) =>
		{
			var c_ = tuple_eykuvmtuwtabihheadhigbsfe?.OutpatientEncounter2?.Period;
			var d_ = FHIRHelpers_4_0_001.ToInterval(c_);
			var e_ = context?.Operators.End(d_);
			var f_ = tuple_eykuvmtuwtabihheadhigbsfe?.OutpatientEncounter1?.Period;
			var g_ = FHIRHelpers_4_0_001.ToInterval(f_);
			var h_ = context?.Operators.End(g_);
			var i_ = context?.Operators.Quantity(1m, "day");
			var j_ = context?.Operators.Add(h_, i_);

			return context?.Operators.SameOrAfter(e_, j_, "day");
		};
		var p_ = context?.Operators.WhereOrNull<Tuples.Tuple_EYKUVMTUWTABihhEAdHIGbSFe>(n_, o_);
		var q_ = (Tuples.Tuple_EYKUVMTUWTABihhEAdHIGbSFe tuple_eykuvmtuwtabihheadhigbsfe) => tuple_eykuvmtuwtabihheadhigbsfe?.OutpatientEncounter1;

		return context?.Operators.SelectOrNull<Tuples.Tuple_EYKUVMTUWTABihhEAdHIGbSFe, Encounter>(p_, q_);
	}

    [CqlDeclaration("Two Outpatient Encounters with Advanced Illness on Different Dates of Service")]
    public IEnumerable<Encounter> Two_Outpatient_Encounters_with_Advanced_Illness_on_Different_Dates_of_Service() => __Two_Outpatient_Encounters_with_Advanced_Illness_on_Different_Dates_of_Service.Value;

    private IEnumerable<CqlInterval<CqlDateTime>> Long_Term_Care_Overlapping_Periods_Value()
	{
		var a_ = this.Long_Term_Care_Periods_During_Measurement_Period();

		return context?.Operators.Collapse(a_, null);
	}

    [CqlDeclaration("Long Term Care Overlapping Periods")]
    public IEnumerable<CqlInterval<CqlDateTime>> Long_Term_Care_Overlapping_Periods() => __Long_Term_Care_Overlapping_Periods.Value;

    private IEnumerable<CqlInterval<CqlDateTime>> Long_Term_Care_Adjacent_Periods_Value()
	{
		var w_ = this.Long_Term_Care_Overlapping_Periods();
		var x_ = (CqlInterval<CqlDateTime> _LTCPeriod1) => this.Long_Term_Care_Overlapping_Periods();
		var y_ = (CqlInterval<CqlDateTime> _LTCPeriod1, CqlInterval<CqlDateTime> _LTCPeriod2) =>
		{
			var a_ = _LTCPeriod1;
			var b_ = _LTCPeriod2;

			return new Tuples.Tuple_IWAGVXGPWIVBAWDaHPGIVVBK
			{
				LTCPeriod1 = a_,
				LTCPeriod2 = b_,
			};
		};
		var z_ = context?.Operators.SelectManyResultsOrNull<CqlInterval<CqlDateTime>, CqlInterval<CqlDateTime>, Tuples.Tuple_IWAGVXGPWIVBAWDaHPGIVVBK>(w_, x_, y_);
		var aa_ = (Tuples.Tuple_IWAGVXGPWIVBAWDaHPGIVVBK tuple_iwagvxgpwivbawdahpgivvbk) =>
		{
			var c_ = tuple_iwagvxgpwivbawdahpgivvbk?.LTCPeriod1;
			var d_ = context?.Operators.End(c_);
			var e_ = tuple_iwagvxgpwivbawdahpgivvbk?.LTCPeriod2;
			var f_ = context?.Operators.Start(e_);
			var g_ = context?.Operators.Quantity(1m, "day");
			var h_ = context?.Operators.Subtract(f_, g_);
			var i_ = tuple_iwagvxgpwivbawdahpgivvbk?.LTCPeriod2;
			var j_ = context?.Operators.Start(i_);
			var k_ = context?.Operators.Quantity(1m, "day");
			var l_ = context?.Operators.Add(j_, k_);
			var m_ = context?.Operators.Interval(h_, l_, true, true);
			var n_ = context?.Operators.ElementInInterval<CqlDateTime>(d_, m_, null);
			var o_ = tuple_iwagvxgpwivbawdahpgivvbk?.LTCPeriod2;
			var p_ = context?.Operators.Start(o_);
			var q_ = (bool?)(p_ == null);
			var r_ = context?.Operators.Not(q_);

			return context?.Operators.And(n_, r_);
		};
		var ab_ = context?.Operators.WhereOrNull<Tuples.Tuple_IWAGVXGPWIVBAWDaHPGIVVBK>(z_, aa_);
		var ac_ = (Tuples.Tuple_IWAGVXGPWIVBAWDaHPGIVVBK tuple_iwagvxgpwivbawdahpgivvbk) =>
		{
			var s_ = tuple_iwagvxgpwivbawdahpgivvbk?.LTCPeriod1;
			var t_ = context?.Operators.Start(s_);
			var u_ = tuple_iwagvxgpwivbawdahpgivvbk?.LTCPeriod2;
			var v_ = context?.Operators.End(u_);

			return context?.Operators.Interval(t_, v_, true, true);
		};

		return context?.Operators.SelectOrNull<Tuples.Tuple_IWAGVXGPWIVBAWDaHPGIVVBK, CqlInterval<CqlDateTime>>(ab_, ac_);
	}

    [CqlDeclaration("Long Term Care Adjacent Periods")]
    public IEnumerable<CqlInterval<CqlDateTime>> Long_Term_Care_Adjacent_Periods() => __Long_Term_Care_Adjacent_Periods.Value;

    private int? Max_Long_Term_Care_Period_Length_Value()
	{
		var c_ = this.Long_Term_Care_Overlapping_Periods();
		var d_ = this.Long_Term_Care_Adjacent_Periods();
		var e_ = context?.Operators.ListUnion<CqlInterval<CqlDateTime>>(c_, d_);
		var f_ = context?.Operators.Collapse(e_, null);
		var g_ = (CqlInterval<CqlDateTime> LTCPeriods) =>
		{
			var a_ = context?.Operators.Start(LTCPeriods);
			var b_ = context?.Operators.End(LTCPeriods);

			return context?.Operators.DurationBetween(a_, b_, "day");
		};
		var h_ = context?.Operators.SelectOrNull<CqlInterval<CqlDateTime>, int?>(f_, g_);

		return context?.Operators.MaxOrNull<int?>(h_);
	}

    [CqlDeclaration("Max Long Term Care Period Length")]
    public int? Max_Long_Term_Care_Period_Length() => __Max_Long_Term_Care_Period_Length.Value;

    private IEnumerable<Encounter> Inpatient_Encounter_with_Advanced_Illness_Value()
	{
		var aa_ = this.Acute_Inpatient();
		var ab_ = context?.DataRetriever.RetrieveByValueSet<Encounter>(aa_, null);
		var ac_ = (Encounter AcuteInpatient) =>
		{
			var a_ = (AcuteInpatient?.StatusElement as object);
			var b_ = (context.Deeper(new CallStackEntry("ToString", null, null))?.Operators?.TypeConverter).Convert<string>(a_);
			var c_ = (b_ as object);

			return context?.Operators.Equal(c_, ("finished" as object));
		};
		var ad_ = context?.Operators.WhereOrNull<Encounter>(ab_, ac_);
		var ae_ = (Encounter InpatientEncounter) =>
		{
			var v_ = this.Advanced_Illness();
			var w_ = context?.DataRetriever.RetrieveByValueSet<Condition>(v_, null);
			var x_ = (Condition AdvancedIllnessDiagnosis) =>
			{
				var d_ = MATGlobalCommonFunctionsFHIR4_6_1_000.EncounterDiagnosis(InpatientEncounter);
				var e_ = context?.Operators.InList<Condition>(AdvancedIllnessDiagnosis, d_);
				var f_ = (InpatientEncounter?.Period as object);
				var g_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Normalize_Interval(f_);
				var h_ = context?.Operators.Start(g_);
				var i_ = this.Measurement_Period();
				var j_ = context?.Operators.End(i_);
				var k_ = context?.Operators.Quantity(2m, "years");
				var l_ = context?.Operators.Subtract(j_, k_);
				var m_ = this.Measurement_Period();
				var n_ = context?.Operators.End(m_);
				var o_ = context?.Operators.Interval(l_, n_, true, true);
				var p_ = context?.Operators.ElementInInterval<CqlDateTime>(h_, o_, null);
				var q_ = this.Measurement_Period();
				var r_ = context?.Operators.End(q_);
				var s_ = (bool?)(r_ == null);
				var t_ = context?.Operators.Not(s_);
				var u_ = context?.Operators.And(p_, t_);

				return context?.Operators.And(e_, u_);
			};
			var y_ = context?.Operators.WhereOrNull<Condition>(w_, x_);
			var z_ = (Condition AdvancedIllnessDiagnosis) => InpatientEncounter;

			return context?.Operators.SelectOrNull<Condition, Encounter>(y_, z_);
		};

		return context?.Operators.SelectManyOrNull<Encounter, Encounter>(ad_, ae_);
	}

    [CqlDeclaration("Inpatient Encounter with Advanced Illness")]
    public IEnumerable<Encounter> Inpatient_Encounter_with_Advanced_Illness() => __Inpatient_Encounter_with_Advanced_Illness.Value;

    private bool? Has_Criteria_Indicating_Frailty_Value()
	{
		var ba_ = this.Frailty_Device();
		var bb_ = context?.DataRetriever.RetrieveByValueSet<DeviceRequest>(ba_, null);
		var bc_ = this.Frailty_Device();
		var bd_ = context?.DataRetriever.RetrieveByValueSet<DeviceRequest>(bc_, null);
		var be_ = context?.Operators.ListUnion<DeviceRequest>(bb_, bd_);
		var bf_ = (DeviceRequest FrailtyDeviceOrder) =>
		{
			var a_ = (FrailtyDeviceOrder?.StatusElement as object);
			var b_ = (context.Deeper(new CallStackEntry("ToString", null, null))?.Operators?.TypeConverter).Convert<string>(a_);
			var c_ = "active";
			var d_ = "on-hold";
			var e_ = "completed";
			var f_ = new string[]
			{
				c_,
				d_,
				e_,
			};
			var g_ = (f_ as IEnumerable<string>);
			var h_ = context?.Operators.InList<string>(b_, g_);
			var i_ = (FrailtyDeviceOrder?.IntentElement as object);
			var j_ = (context.Deeper(new CallStackEntry("ToString", null, null))?.Operators?.TypeConverter).Convert<string>(i_);
			var k_ = (j_ as object);
			var l_ = context?.Operators.Equal(k_, ("order" as object));
			var m_ = context?.Operators.And(h_, l_);
			var n_ = this.Measurement_Period();
			var o_ = (FrailtyDeviceOrder?.AuthoredOnElement as object);
			var p_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Normalize_Interval(o_);
			var q_ = context?.Operators.IntervalIncludesInterval<CqlDateTime>(n_, p_, null);

			return context?.Operators.And(m_, q_);
		};
		var bg_ = context?.Operators.WhereOrNull<DeviceRequest>(be_, bf_);
		var bh_ = context?.Operators.ExistsInList<DeviceRequest>(bg_);
		var bi_ = this.Frailty_Device();
		var bj_ = context?.DataRetriever.RetrieveByValueSet<Observation>(bi_, null);
		var bk_ = (Observation FrailtyDeviceApplied) =>
		{
			var r_ = (FrailtyDeviceApplied?.StatusElement as object);
			var s_ = (context.Deeper(new CallStackEntry("ToString", null, null))?.Operators?.TypeConverter).Convert<string>(r_);
			var t_ = "final";
			var u_ = "amended";
			var v_ = "corrected";
			var w_ = new string[]
			{
				t_,
				u_,
				v_,
			};
			var x_ = (w_ as IEnumerable<string>);
			var y_ = context?.Operators.InList<string>(s_, x_);
			var z_ = (FrailtyDeviceApplied?.Effective as object);
			var aa_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Normalize_Interval(z_);
			var ab_ = this.Measurement_Period();
			var ac_ = context?.Operators.Overlaps(aa_, ab_, null);

			return context?.Operators.And(y_, ac_);
		};
		var bl_ = context?.Operators.WhereOrNull<Observation>(bj_, bk_);
		var bm_ = context?.Operators.ExistsInList<Observation>(bl_);
		var bn_ = context?.Operators.Or(bh_, bm_);
		var bo_ = this.Frailty_Diagnosis();
		var bp_ = context?.DataRetriever.RetrieveByValueSet<Condition>(bo_, null);
		var bq_ = (Condition FrailtyDiagnosis) =>
		{
			var ad_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Prevalence_Period(FrailtyDiagnosis);
			var ae_ = this.Measurement_Period();

			return context?.Operators.Overlaps(ad_, ae_, null);
		};
		var br_ = context?.Operators.WhereOrNull<Condition>(bp_, bq_);
		var bs_ = context?.Operators.ExistsInList<Condition>(br_);
		var bt_ = context?.Operators.Or(bn_, bs_);
		var bu_ = this.Frailty_Encounter();
		var bv_ = context?.DataRetriever.RetrieveByValueSet<Encounter>(bu_, null);
		var bw_ = (Encounter FrailtyEncounter) =>
		{
			var af_ = (FrailtyEncounter?.StatusElement as object);
			var ag_ = (context.Deeper(new CallStackEntry("ToString", null, null))?.Operators?.TypeConverter).Convert<string>(af_);
			var ah_ = (ag_ as object);
			var ai_ = context?.Operators.Equal(ah_, ("finished" as object));
			var aj_ = (FrailtyEncounter?.Period as object);
			var ak_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Normalize_Interval(aj_);
			var al_ = this.Measurement_Period();
			var am_ = context?.Operators.Overlaps(ak_, al_, null);

			return context?.Operators.And(ai_, am_);
		};
		var bx_ = context?.Operators.WhereOrNull<Encounter>(bv_, bw_);
		var by_ = context?.Operators.ExistsInList<Encounter>(bx_);
		var bz_ = context?.Operators.Or(bt_, by_);
		var ca_ = this.Frailty_Symptom();
		var cb_ = context?.DataRetriever.RetrieveByValueSet<Observation>(ca_, null);
		var cc_ = (Observation FrailtySymptom) =>
		{
			var an_ = (FrailtySymptom?.StatusElement as object);
			var ao_ = (context.Deeper(new CallStackEntry("ToString", null, null))?.Operators?.TypeConverter).Convert<string>(an_);
			var ap_ = "preliminary";
			var aq_ = "final";
			var ar_ = "amended";
			var as_ = "corrected";
			var at_ = new string[]
			{
				ap_,
				aq_,
				ar_,
				as_,
			};
			var au_ = (at_ as IEnumerable<string>);
			var av_ = context?.Operators.InList<string>(ao_, au_);
			var aw_ = (FrailtySymptom?.Effective as object);
			var ax_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Normalize_Interval(aw_);
			var ay_ = this.Measurement_Period();
			var az_ = context?.Operators.Overlaps(ax_, ay_, null);

			return context?.Operators.And(av_, az_);
		};
		var cd_ = context?.Operators.WhereOrNull<Observation>(cb_, cc_);
		var ce_ = context?.Operators.ExistsInList<Observation>(cd_);

		return context?.Operators.Or(bz_, ce_);
	}

    [CqlDeclaration("Has Criteria Indicating Frailty")]
    public bool? Has_Criteria_Indicating_Frailty() => __Has_Criteria_Indicating_Frailty.Value;

    private bool? Advanced_Illness_and_Frailty_Exclusion_Including_Over_Age_80_Value()
	{
		var a_ = (this.Patient()?.BirthDateElement?.Value as object);
		var b_ = context?.Operators?.TypeConverter.Convert<CqlDate>(a_);
		var c_ = this.Measurement_Period();
		var d_ = context?.Operators.Start(c_);
		var e_ = context?.Operators.DateFrom(d_);
		var f_ = context?.Operators.CalculateAgeAt(b_, e_, "year");
		var g_ = context?.Operators.Interval((int?)65, (int?)79, true, true);
		var h_ = context?.Operators.ElementInInterval<int?>(f_, g_, null);
		var i_ = this.Has_Criteria_Indicating_Frailty();
		var j_ = context?.Operators.And(h_, i_);
		var k_ = this.Two_Outpatient_Encounters_with_Advanced_Illness_on_Different_Dates_of_Service();
		var l_ = context?.Operators.ExistsInList<Encounter>(k_);
		var m_ = this.Inpatient_Encounter_with_Advanced_Illness();
		var n_ = context?.Operators.ExistsInList<Encounter>(m_);
		var o_ = context?.Operators.Or(l_, n_);
		var p_ = this.Dementia_Medications_In_Year_Before_or_During_Measurement_Period();
		var q_ = context?.Operators.ExistsInList<MedicationRequest>(p_);
		var r_ = context?.Operators.Or(o_, q_);
		var s_ = context?.Operators.And(j_, r_);
		var t_ = (this.Patient()?.BirthDateElement?.Value as object);
		var u_ = context?.Operators?.TypeConverter.Convert<CqlDate>(t_);
		var v_ = this.Measurement_Period();
		var w_ = context?.Operators.Start(v_);
		var x_ = context?.Operators.DateFrom(w_);
		var y_ = context?.Operators.CalculateAgeAt(u_, x_, "year");
		var z_ = (y_ as object);
		var aa_ = ((int?)80 as object);
		var ab_ = context?.Operators.GreaterOrEqual(z_, aa_);
		var ac_ = this.Has_Criteria_Indicating_Frailty();
		var ad_ = context?.Operators.And(ab_, ac_);

		return context?.Operators.Or(s_, ad_);
	}

    [CqlDeclaration("Advanced Illness and Frailty Exclusion Including Over Age 80")]
    public bool? Advanced_Illness_and_Frailty_Exclusion_Including_Over_Age_80() => __Advanced_Illness_and_Frailty_Exclusion_Including_Over_Age_80.Value;

    private bool? Advanced_Illness_and_Frailty_Exclusion_Not_Including_Over_Age_80_Value()
	{
		var a_ = (this.Patient()?.BirthDateElement?.Value as object);
		var b_ = context?.Operators?.TypeConverter.Convert<CqlDate>(a_);
		var c_ = this.Measurement_Period();
		var d_ = context?.Operators.Start(c_);
		var e_ = context?.Operators.DateFrom(d_);
		var f_ = context?.Operators.CalculateAgeAt(b_, e_, "year");
		var g_ = (f_ as object);
		var h_ = ((int?)65 as object);
		var i_ = context?.Operators.GreaterOrEqual(g_, h_);
		var j_ = this.Has_Criteria_Indicating_Frailty();
		var k_ = context?.Operators.And(i_, j_);
		var l_ = this.Two_Outpatient_Encounters_with_Advanced_Illness_on_Different_Dates_of_Service();
		var m_ = context?.Operators.ExistsInList<Encounter>(l_);
		var n_ = this.Inpatient_Encounter_with_Advanced_Illness();
		var o_ = context?.Operators.ExistsInList<Encounter>(n_);
		var p_ = context?.Operators.Or(m_, o_);
		var q_ = this.Dementia_Medications_In_Year_Before_or_During_Measurement_Period();
		var r_ = context?.Operators.ExistsInList<MedicationRequest>(q_);
		var s_ = context?.Operators.Or(p_, r_);

		return context?.Operators.And(k_, s_);
	}

    [CqlDeclaration("Advanced Illness and Frailty Exclusion Not Including Over Age 80")]
    public bool? Advanced_Illness_and_Frailty_Exclusion_Not_Including_Over_Age_80() => __Advanced_Illness_and_Frailty_Exclusion_Not_Including_Over_Age_80.Value;

    private bool? Has_Long_Term_Care_Periods_Longer_Than_90_Consecutive_Days_Value()
	{
		var a_ = (this.Max_Long_Term_Care_Period_Length() as object);
		var b_ = ((int?)90 as object);

		return context?.Operators.Greater(a_, b_);
	}

    [CqlDeclaration("Has Long Term Care Periods Longer Than 90 Consecutive Days")]
    public bool? Has_Long_Term_Care_Periods_Longer_Than_90_Consecutive_Days() => __Has_Long_Term_Care_Periods_Longer_Than_90_Consecutive_Days.Value;

}