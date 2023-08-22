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
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1083", 
			null);

    [CqlDeclaration("Acute Inpatient")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1083")]
    public CqlValueSet Acute_Inpatient() => __Acute_Inpatient.Value;

    private CqlValueSet Advanced_Illness_Value() =>
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.110.12.1082", 
			null);

    [CqlDeclaration("Advanced Illness")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.110.12.1082")]
    public CqlValueSet Advanced_Illness() => __Advanced_Illness.Value;

    private CqlValueSet Care_Services_in_Long_Term_Residential_Facility_Value() =>
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1014", 
			null);

    [CqlDeclaration("Care Services in Long-Term Residential Facility")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1014")]
    public CqlValueSet Care_Services_in_Long_Term_Residential_Facility() => __Care_Services_in_Long_Term_Residential_Facility.Value;

    private CqlValueSet Dementia_Medications_Value() =>
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.196.12.1510", 
			null);

    [CqlDeclaration("Dementia Medications")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.196.12.1510")]
    public CqlValueSet Dementia_Medications() => __Dementia_Medications.Value;

    private CqlValueSet Emergency_Department_Visit_Value() =>
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1010", 
			null);

    [CqlDeclaration("Emergency Department Visit")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1010")]
    public CqlValueSet Emergency_Department_Visit() => __Emergency_Department_Visit.Value;

    private CqlValueSet Frailty_Device_Value() =>
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.118.12.1300", 
			null);

    [CqlDeclaration("Frailty Device")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.118.12.1300")]
    public CqlValueSet Frailty_Device() => __Frailty_Device.Value;

    private CqlValueSet Frailty_Diagnosis_Value() =>
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.113.12.1074", 
			null);

    [CqlDeclaration("Frailty Diagnosis")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.113.12.1074")]
    public CqlValueSet Frailty_Diagnosis() => __Frailty_Diagnosis.Value;

    private CqlValueSet Frailty_Encounter_Value() =>
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1088", 
			null);

    [CqlDeclaration("Frailty Encounter")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1088")]
    public CqlValueSet Frailty_Encounter() => __Frailty_Encounter.Value;

    private CqlValueSet Frailty_Symptom_Value() =>
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.113.12.1075", 
			null);

    [CqlDeclaration("Frailty Symptom")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.113.12.1075")]
    public CqlValueSet Frailty_Symptom() => __Frailty_Symptom.Value;

    private CqlValueSet Nonacute_Inpatient_Value() =>
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1084", 
			null);

    [CqlDeclaration("Nonacute Inpatient")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1084")]
    public CqlValueSet Nonacute_Inpatient() => __Nonacute_Inpatient.Value;

    private CqlValueSet Nursing_Facility_Visit_Value() =>
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1012", 
			null);

    [CqlDeclaration("Nursing Facility Visit")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1012")]
    public CqlValueSet Nursing_Facility_Visit() => __Nursing_Facility_Visit.Value;

    private CqlValueSet Observation_Value() =>
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1086", 
			null);

    [CqlDeclaration("Observation")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1086")]
    public CqlValueSet Observation() => __Observation.Value;

    private CqlValueSet Outpatient_Value() =>
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1087", 
			null);

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
		var a_ = this.Dementia_Medications();
		var b_ = context?.DataRetriever.RetrieveByValueSet<MedicationRequest>(a_, null);
		var c_ = this.Dementia_Medications();
		var d_ = context?.DataRetriever.RetrieveByValueSet<MedicationRequest>(c_, null);
		var e_ = context?.Operators.ListUnion<MedicationRequest>(b_, d_);
		var f_ = (MedicationRequest DementiaMed) =>
		{
			var a_ = (DementiaMed?.StatusElement as object);
			var b_ = (context.Deeper(new CallStackEntry("ToString", 
		null, 
		null))?.Operators?.TypeConverter).Convert<string>(a_);
			var c_ = (b_ as object);
			var d_ = context?.Operators.Equal(c_, ("active" as object));
			var e_ = (DementiaMed?.IntentElement as object);
			var f_ = (context.Deeper(new CallStackEntry("ToString", 
		null, 
		null))?.Operators?.TypeConverter).Convert<string>(e_);
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

		return context?.Operators.WhereOrNull<MedicationRequest>(e_, f_);
	}

    [CqlDeclaration("Dementia Medications In Year Before or During Measurement Period")]
    public IEnumerable<MedicationRequest> Dementia_Medications_In_Year_Before_or_During_Measurement_Period() => __Dementia_Medications_In_Year_Before_or_During_Measurement_Period.Value;

    private IEnumerable<CqlInterval<CqlDateTime>> Long_Term_Care_Periods_During_Measurement_Period_Value()
	{
		var a_ = this.Care_Services_in_Long_Term_Residential_Facility();
		var b_ = context?.DataRetriever.RetrieveByValueSet<Encounter>(a_, null);
		var c_ = this.Nursing_Facility_Visit();
		var d_ = context?.DataRetriever.RetrieveByValueSet<Encounter>(c_, null);
		var e_ = context?.Operators.ListUnion<Encounter>(b_, d_);
		var f_ = (Encounter LongTermFacilityEncounter) =>
		{
			var a_ = (LongTermFacilityEncounter?.StatusElement as object);
			var b_ = (context.Deeper(new CallStackEntry("ToString", 
		null, 
		null))?.Operators?.TypeConverter).Convert<string>(a_);
			var c_ = (b_ as object);
			var d_ = context?.Operators.Equal(c_, ("finished" as object));
			var e_ = (LongTermFacilityEncounter?.Period as object);
			var f_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Normalize_Interval(e_);
			var g_ = this.Measurement_Period();
			var h_ = context?.Operators.Overlaps(f_, g_, null);

			return context?.Operators.And(d_, h_);
		};
		var g_ = context?.Operators.WhereOrNull<Encounter>(e_, f_);
		var h_ = (Encounter LongTermFacilityEncounter) =>
		{
			var a_ = (LongTermFacilityEncounter?.Period as object);
			var b_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Normalize_Interval(a_);
			var c_ = this.Measurement_Period();

			return context?.Operators.IntervalIntersectsInterval<CqlDateTime>(b_, c_);
		};

		return context?.Operators.SelectOrNull<Encounter, CqlInterval<CqlDateTime>>(g_, h_);
	}

    [CqlDeclaration("Long Term Care Periods During Measurement Period")]
    public IEnumerable<CqlInterval<CqlDateTime>> Long_Term_Care_Periods_During_Measurement_Period() => __Long_Term_Care_Periods_During_Measurement_Period.Value;

    private IEnumerable<Encounter> Outpatient_Encounters_with_Advanced_Illness_Value()
	{
		var a_ = this.Outpatient();
		var b_ = context?.DataRetriever.RetrieveByValueSet<Encounter>(a_, null);
		var c_ = this.Observation();
		var d_ = context?.DataRetriever.RetrieveByValueSet<Encounter>(c_, null);
		var e_ = context?.Operators.ListUnion<Encounter>(b_, d_);
		var f_ = this.Emergency_Department_Visit();
		var g_ = context?.DataRetriever.RetrieveByValueSet<Encounter>(f_, null);
		var h_ = this.Nonacute_Inpatient();
		var i_ = context?.DataRetriever.RetrieveByValueSet<Encounter>(h_, null);
		var j_ = context?.Operators.ListUnion<Encounter>(g_, i_);
		var k_ = context?.Operators.ListUnion<Encounter>(e_, j_);
		var l_ = (Encounter Outpatient) =>
		{
			var a_ = (Outpatient?.StatusElement as object);
			var b_ = (context.Deeper(new CallStackEntry("ToString", 
		null, 
		null))?.Operators?.TypeConverter).Convert<string>(a_);
			var c_ = (b_ as object);

			return context?.Operators.Equal(c_, ("finished" as object));
		};
		var m_ = context?.Operators.WhereOrNull<Encounter>(k_, l_);
		var n_ = (Encounter OutpatientEncounter) =>
		{
			var a_ = this.Advanced_Illness();
			var b_ = context?.DataRetriever.RetrieveByValueSet<Condition>(a_, null);
			var c_ = (Condition AdvancedIllnessDiagnosis) =>
			{
				var a_ = MATGlobalCommonFunctionsFHIR4_6_1_000.EncounterDiagnosis(OutpatientEncounter);
				var b_ = context?.Operators.InList<Condition>(AdvancedIllnessDiagnosis, a_);
				var c_ = (OutpatientEncounter?.Period as object);
				var d_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Normalize_Interval(c_);
				var e_ = context?.Operators.Start(d_);
				var f_ = this.Measurement_Period();
				var g_ = context?.Operators.End(f_);
				var h_ = context?.Operators.Quantity(2m, "years");
				var i_ = context?.Operators.Subtract(g_, h_);
				var j_ = this.Measurement_Period();
				var k_ = context?.Operators.End(j_);
				var l_ = context?.Operators.Interval(i_, k_, true, true);
				var m_ = context?.Operators.ElementInInterval<CqlDateTime>(e_, l_, null);
				var n_ = this.Measurement_Period();
				var o_ = context?.Operators.End(n_);
				var p_ = (bool?)(o_ == null);
				var q_ = context?.Operators.Not(p_);
				var r_ = context?.Operators.And(m_, q_);

				return context?.Operators.And(b_, r_);
			};
			var d_ = context?.Operators.WhereOrNull<Condition>(b_, c_);
			var e_ = (Condition AdvancedIllnessDiagnosis) => OutpatientEncounter;

			return context?.Operators.SelectOrNull<Condition, Encounter>(d_, e_);
		};

		return context?.Operators.SelectManyOrNull<Encounter, Encounter>(m_, n_);
	}

    [CqlDeclaration("Outpatient Encounters with Advanced Illness")]
    public IEnumerable<Encounter> Outpatient_Encounters_with_Advanced_Illness() => __Outpatient_Encounters_with_Advanced_Illness.Value;

    private IEnumerable<Encounter> Two_Outpatient_Encounters_with_Advanced_Illness_on_Different_Dates_of_Service_Value()
	{
		var a_ = this.Outpatient_Encounters_with_Advanced_Illness();
		var b_ = (Encounter _OutpatientEncounter1) => this.Outpatient_Encounters_with_Advanced_Illness();
		var c_ = (Encounter _OutpatientEncounter1, Encounter _OutpatientEncounter2) =>
		{
			var a_ = _OutpatientEncounter1;
			var b_ = _OutpatientEncounter2;

			return new Tuples.Tuple_EYKUVMTUWTABihhEAdHIGbSFe
			{
				OutpatientEncounter1 = a_,
				OutpatientEncounter2 = b_,
			};
		};
		var d_ = context?.Operators.SelectManyResultsOrNull<Encounter, Encounter, Tuples.Tuple_EYKUVMTUWTABihhEAdHIGbSFe>(a_, b_, c_);
		var e_ = (Tuples.Tuple_EYKUVMTUWTABihhEAdHIGbSFe tuple_eykuvmtuwtabihheadhigbsfe) =>
		{
			var a_ = tuple_eykuvmtuwtabihheadhigbsfe?.OutpatientEncounter2?.Period;
			var b_ = FHIRHelpers_4_0_001.ToInterval(a_);
			var c_ = context?.Operators.End(b_);
			var d_ = tuple_eykuvmtuwtabihheadhigbsfe?.OutpatientEncounter1?.Period;
			var e_ = FHIRHelpers_4_0_001.ToInterval(d_);
			var f_ = context?.Operators.End(e_);
			var g_ = context?.Operators.Quantity(1m, "day");
			var h_ = context?.Operators.Add(f_, g_);

			return context?.Operators.SameOrAfter(c_, h_, "day");
		};
		var f_ = context?.Operators.WhereOrNull<Tuples.Tuple_EYKUVMTUWTABihhEAdHIGbSFe>(d_, e_);
		var g_ = (Tuples.Tuple_EYKUVMTUWTABihhEAdHIGbSFe tuple_eykuvmtuwtabihheadhigbsfe) => tuple_eykuvmtuwtabihheadhigbsfe?.OutpatientEncounter1;

		return context?.Operators.SelectOrNull<Tuples.Tuple_EYKUVMTUWTABihhEAdHIGbSFe, Encounter>(f_, g_);
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
		var a_ = this.Long_Term_Care_Overlapping_Periods();
		var b_ = (CqlInterval<CqlDateTime> _LTCPeriod1) => this.Long_Term_Care_Overlapping_Periods();
		var c_ = (CqlInterval<CqlDateTime> _LTCPeriod1, CqlInterval<CqlDateTime> _LTCPeriod2) =>
		{
			var a_ = _LTCPeriod1;
			var b_ = _LTCPeriod2;

			return new Tuples.Tuple_IWAGVXGPWIVBAWDaHPGIVVBK
			{
				LTCPeriod1 = a_,
				LTCPeriod2 = b_,
			};
		};
		var d_ = context?.Operators.SelectManyResultsOrNull<CqlInterval<CqlDateTime>, CqlInterval<CqlDateTime>, Tuples.Tuple_IWAGVXGPWIVBAWDaHPGIVVBK>(a_, b_, c_);
		var e_ = (Tuples.Tuple_IWAGVXGPWIVBAWDaHPGIVVBK tuple_iwagvxgpwivbawdahpgivvbk) =>
		{
			var a_ = tuple_iwagvxgpwivbawdahpgivvbk?.LTCPeriod1;
			var b_ = context?.Operators.End(a_);
			var c_ = tuple_iwagvxgpwivbawdahpgivvbk?.LTCPeriod2;
			var d_ = context?.Operators.Start(c_);
			var e_ = context?.Operators.Quantity(1m, "day");
			var f_ = context?.Operators.Subtract(d_, e_);
			var g_ = tuple_iwagvxgpwivbawdahpgivvbk?.LTCPeriod2;
			var h_ = context?.Operators.Start(g_);
			var i_ = context?.Operators.Quantity(1m, "day");
			var j_ = context?.Operators.Add(h_, i_);
			var k_ = context?.Operators.Interval(f_, j_, true, true);
			var l_ = context?.Operators.ElementInInterval<CqlDateTime>(b_, k_, null);
			var m_ = tuple_iwagvxgpwivbawdahpgivvbk?.LTCPeriod2;
			var n_ = context?.Operators.Start(m_);
			var o_ = (bool?)(n_ == null);
			var p_ = context?.Operators.Not(o_);

			return context?.Operators.And(l_, p_);
		};
		var f_ = context?.Operators.WhereOrNull<Tuples.Tuple_IWAGVXGPWIVBAWDaHPGIVVBK>(d_, e_);
		var g_ = (Tuples.Tuple_IWAGVXGPWIVBAWDaHPGIVVBK tuple_iwagvxgpwivbawdahpgivvbk) =>
		{
			var a_ = tuple_iwagvxgpwivbawdahpgivvbk?.LTCPeriod1;
			var b_ = context?.Operators.Start(a_);
			var c_ = tuple_iwagvxgpwivbawdahpgivvbk?.LTCPeriod2;
			var d_ = context?.Operators.End(c_);

			return context?.Operators.Interval(b_, d_, true, true);
		};

		return context?.Operators.SelectOrNull<Tuples.Tuple_IWAGVXGPWIVBAWDaHPGIVVBK, CqlInterval<CqlDateTime>>(f_, g_);
	}

    [CqlDeclaration("Long Term Care Adjacent Periods")]
    public IEnumerable<CqlInterval<CqlDateTime>> Long_Term_Care_Adjacent_Periods() => __Long_Term_Care_Adjacent_Periods.Value;

    private int? Max_Long_Term_Care_Period_Length_Value()
	{
		var a_ = this.Long_Term_Care_Overlapping_Periods();
		var b_ = this.Long_Term_Care_Adjacent_Periods();
		var c_ = context?.Operators.ListUnion<CqlInterval<CqlDateTime>>(a_, b_);
		var d_ = context?.Operators.Collapse(c_, null);
		var e_ = (CqlInterval<CqlDateTime> LTCPeriods) =>
		{
			var a_ = context?.Operators.Start(LTCPeriods);
			var b_ = context?.Operators.End(LTCPeriods);

			return context?.Operators.DurationBetween(a_, b_, "day");
		};
		var f_ = context?.Operators.SelectOrNull<CqlInterval<CqlDateTime>, int?>(d_, e_);

		return context?.Operators.MaxOrNull<int?>(f_);
	}

    [CqlDeclaration("Max Long Term Care Period Length")]
    public int? Max_Long_Term_Care_Period_Length() => __Max_Long_Term_Care_Period_Length.Value;

    private IEnumerable<Encounter> Inpatient_Encounter_with_Advanced_Illness_Value()
	{
		var a_ = this.Acute_Inpatient();
		var b_ = context?.DataRetriever.RetrieveByValueSet<Encounter>(a_, null);
		var c_ = (Encounter AcuteInpatient) =>
		{
			var a_ = (AcuteInpatient?.StatusElement as object);
			var b_ = (context.Deeper(new CallStackEntry("ToString", 
		null, 
		null))?.Operators?.TypeConverter).Convert<string>(a_);
			var c_ = (b_ as object);

			return context?.Operators.Equal(c_, ("finished" as object));
		};
		var d_ = context?.Operators.WhereOrNull<Encounter>(b_, c_);
		var e_ = (Encounter InpatientEncounter) =>
		{
			var a_ = this.Advanced_Illness();
			var b_ = context?.DataRetriever.RetrieveByValueSet<Condition>(a_, null);
			var c_ = (Condition AdvancedIllnessDiagnosis) =>
			{
				var a_ = MATGlobalCommonFunctionsFHIR4_6_1_000.EncounterDiagnosis(InpatientEncounter);
				var b_ = context?.Operators.InList<Condition>(AdvancedIllnessDiagnosis, a_);
				var c_ = (InpatientEncounter?.Period as object);
				var d_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Normalize_Interval(c_);
				var e_ = context?.Operators.Start(d_);
				var f_ = this.Measurement_Period();
				var g_ = context?.Operators.End(f_);
				var h_ = context?.Operators.Quantity(2m, "years");
				var i_ = context?.Operators.Subtract(g_, h_);
				var j_ = this.Measurement_Period();
				var k_ = context?.Operators.End(j_);
				var l_ = context?.Operators.Interval(i_, k_, true, true);
				var m_ = context?.Operators.ElementInInterval<CqlDateTime>(e_, l_, null);
				var n_ = this.Measurement_Period();
				var o_ = context?.Operators.End(n_);
				var p_ = (bool?)(o_ == null);
				var q_ = context?.Operators.Not(p_);
				var r_ = context?.Operators.And(m_, q_);

				return context?.Operators.And(b_, r_);
			};
			var d_ = context?.Operators.WhereOrNull<Condition>(b_, c_);
			var e_ = (Condition AdvancedIllnessDiagnosis) => InpatientEncounter;

			return context?.Operators.SelectOrNull<Condition, Encounter>(d_, e_);
		};

		return context?.Operators.SelectManyOrNull<Encounter, Encounter>(d_, e_);
	}

    [CqlDeclaration("Inpatient Encounter with Advanced Illness")]
    public IEnumerable<Encounter> Inpatient_Encounter_with_Advanced_Illness() => __Inpatient_Encounter_with_Advanced_Illness.Value;

    private bool? Has_Criteria_Indicating_Frailty_Value()
	{
		var a_ = this.Frailty_Device();
		var b_ = context?.DataRetriever.RetrieveByValueSet<DeviceRequest>(a_, null);
		var c_ = this.Frailty_Device();
		var d_ = context?.DataRetriever.RetrieveByValueSet<DeviceRequest>(c_, null);
		var e_ = context?.Operators.ListUnion<DeviceRequest>(b_, d_);
		var f_ = (DeviceRequest FrailtyDeviceOrder) =>
		{
			var a_ = (FrailtyDeviceOrder?.StatusElement as object);
			var b_ = (context.Deeper(new CallStackEntry("ToString", 
		null, 
		null))?.Operators?.TypeConverter).Convert<string>(a_);
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
			var j_ = (context.Deeper(new CallStackEntry("ToString", 
		null, 
		null))?.Operators?.TypeConverter).Convert<string>(i_);
			var k_ = (j_ as object);
			var l_ = context?.Operators.Equal(k_, ("order" as object));
			var m_ = context?.Operators.And(h_, l_);
			var n_ = this.Measurement_Period();
			var o_ = (FrailtyDeviceOrder?.AuthoredOnElement as object);
			var p_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Normalize_Interval(o_);
			var q_ = context?.Operators.IntervalIncludesInterval<CqlDateTime>(n_, p_, null);

			return context?.Operators.And(m_, q_);
		};
		var g_ = context?.Operators.WhereOrNull<DeviceRequest>(e_, f_);
		var h_ = context?.Operators.ExistsInList<DeviceRequest>(g_);
		var i_ = this.Frailty_Device();
		var j_ = context?.DataRetriever.RetrieveByValueSet<Observation>(i_, null);
		var k_ = (Observation FrailtyDeviceApplied) =>
		{
			var a_ = (FrailtyDeviceApplied?.StatusElement as object);
			var b_ = (context.Deeper(new CallStackEntry("ToString", 
		null, 
		null))?.Operators?.TypeConverter).Convert<string>(a_);
			var c_ = "final";
			var d_ = "amended";
			var e_ = "corrected";
			var f_ = new string[]
			{
				c_,
				d_,
				e_,
			};
			var g_ = (f_ as IEnumerable<string>);
			var h_ = context?.Operators.InList<string>(b_, g_);
			var i_ = (FrailtyDeviceApplied?.Effective as object);
			var j_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Normalize_Interval(i_);
			var k_ = this.Measurement_Period();
			var l_ = context?.Operators.Overlaps(j_, k_, null);

			return context?.Operators.And(h_, l_);
		};
		var l_ = context?.Operators.WhereOrNull<Observation>(j_, k_);
		var m_ = context?.Operators.ExistsInList<Observation>(l_);
		var n_ = context?.Operators.Or(h_, m_);
		var o_ = this.Frailty_Diagnosis();
		var p_ = context?.DataRetriever.RetrieveByValueSet<Condition>(o_, null);
		var q_ = (Condition FrailtyDiagnosis) =>
		{
			var a_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Prevalence_Period(FrailtyDiagnosis);
			var b_ = this.Measurement_Period();

			return context?.Operators.Overlaps(a_, b_, null);
		};
		var r_ = context?.Operators.WhereOrNull<Condition>(p_, q_);
		var s_ = context?.Operators.ExistsInList<Condition>(r_);
		var t_ = context?.Operators.Or(n_, s_);
		var u_ = this.Frailty_Encounter();
		var v_ = context?.DataRetriever.RetrieveByValueSet<Encounter>(u_, null);
		var w_ = (Encounter FrailtyEncounter) =>
		{
			var a_ = (FrailtyEncounter?.StatusElement as object);
			var b_ = (context.Deeper(new CallStackEntry("ToString", 
		null, 
		null))?.Operators?.TypeConverter).Convert<string>(a_);
			var c_ = (b_ as object);
			var d_ = context?.Operators.Equal(c_, ("finished" as object));
			var e_ = (FrailtyEncounter?.Period as object);
			var f_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Normalize_Interval(e_);
			var g_ = this.Measurement_Period();
			var h_ = context?.Operators.Overlaps(f_, g_, null);

			return context?.Operators.And(d_, h_);
		};
		var x_ = context?.Operators.WhereOrNull<Encounter>(v_, w_);
		var y_ = context?.Operators.ExistsInList<Encounter>(x_);
		var z_ = context?.Operators.Or(t_, y_);
		var aa_ = this.Frailty_Symptom();
		var ab_ = context?.DataRetriever.RetrieveByValueSet<Observation>(aa_, null);
		var ac_ = (Observation FrailtySymptom) =>
		{
			var a_ = (FrailtySymptom?.StatusElement as object);
			var b_ = (context.Deeper(new CallStackEntry("ToString", 
		null, 
		null))?.Operators?.TypeConverter).Convert<string>(a_);
			var c_ = "preliminary";
			var d_ = "final";
			var e_ = "amended";
			var f_ = "corrected";
			var g_ = new string[]
			{
				c_,
				d_,
				e_,
				f_,
			};
			var h_ = (g_ as IEnumerable<string>);
			var i_ = context?.Operators.InList<string>(b_, h_);
			var j_ = (FrailtySymptom?.Effective as object);
			var k_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Normalize_Interval(j_);
			var l_ = this.Measurement_Period();
			var m_ = context?.Operators.Overlaps(k_, l_, null);

			return context?.Operators.And(i_, m_);
		};
		var ad_ = context?.Operators.WhereOrNull<Observation>(ab_, ac_);
		var ae_ = context?.Operators.ExistsInList<Observation>(ad_);

		return context?.Operators.Or(z_, ae_);
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