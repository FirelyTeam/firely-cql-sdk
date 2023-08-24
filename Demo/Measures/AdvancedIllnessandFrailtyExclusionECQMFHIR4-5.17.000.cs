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
		var a_ = context?.DataRetriever.RetrieveByValueSet<Patient>(null, null);

		return context?.Operators.SingleOrNull<Patient>(a_);
	}

    [CqlDeclaration("Patient")]
    public Patient Patient() => __Patient.Value;

    private IEnumerable<MedicationRequest> Dementia_Medications_In_Year_Before_or_During_Measurement_Period_Value()
	{
		var u_ = this.Dementia_Medications();
		var v_ = context?.DataRetriever.RetrieveByValueSet<MedicationRequest>(u_, null);
		var w_ = this.Dementia_Medications();
		var x_ = context?.DataRetriever.RetrieveByValueSet<MedicationRequest>(w_, null);
		var y_ = context?.Operators.ListUnion<MedicationRequest>(v_, x_);
		var z_ = (MedicationRequest DementiaMed) =>
		{
			var a_ = DementiaMed?.StatusElement;
			var b_ = (a_ as object);
			var c_ = (context.Deeper(new CallStackEntry("ToString", null, null))?.Operators?.TypeConverter).Convert<string>(b_);
			var d_ = (c_ as object);
			var e_ = context?.Operators.Equal(d_, ("active" as object));
			var f_ = DementiaMed?.IntentElement;
			var g_ = (f_ as object);
			var h_ = (context.Deeper(new CallStackEntry("ToString", null, null))?.Operators?.TypeConverter).Convert<string>(g_);
			var i_ = (h_ as object);
			var j_ = context?.Operators.Equal(i_, ("order" as object));
			var k_ = context?.Operators.And(e_, j_);
			var l_ = CumulativeMedicationDurationFHIR4_1_0_000.MedicationPeriod((DementiaMed as object));
			var m_ = this.Measurement_Period();
			var n_ = context?.Operators.Start(m_);
			var o_ = context?.Operators.Quantity(1m, "year");
			var p_ = context?.Operators.Subtract(n_, o_);
			var q_ = this.Measurement_Period();
			var r_ = context?.Operators.End(q_);
			var s_ = context?.Operators.Interval(p_, r_, true, true);
			var t_ = context?.Operators.Overlaps(l_, s_, null);

			return context?.Operators.And(k_, t_);
		};

		return context?.Operators.WhereOrNull<MedicationRequest>(y_, z_);
	}

    [CqlDeclaration("Dementia Medications In Year Before or During Measurement Period")]
    public IEnumerable<MedicationRequest> Dementia_Medications_In_Year_Before_or_During_Measurement_Period() => __Dementia_Medications_In_Year_Before_or_During_Measurement_Period.Value;

    private IEnumerable<CqlInterval<CqlDateTime>> Long_Term_Care_Periods_During_Measurement_Period_Value()
	{
		var o_ = this.Care_Services_in_Long_Term_Residential_Facility();
		var p_ = context?.DataRetriever.RetrieveByValueSet<Encounter>(o_, null);
		var q_ = this.Nursing_Facility_Visit();
		var r_ = context?.DataRetriever.RetrieveByValueSet<Encounter>(q_, null);
		var s_ = context?.Operators.ListUnion<Encounter>(p_, r_);
		var t_ = (Encounter LongTermFacilityEncounter) =>
		{
			var a_ = LongTermFacilityEncounter?.StatusElement;
			var b_ = (a_ as object);
			var c_ = (context.Deeper(new CallStackEntry("ToString", null, null))?.Operators?.TypeConverter).Convert<string>(b_);
			var d_ = (c_ as object);
			var e_ = context?.Operators.Equal(d_, ("finished" as object));
			var f_ = LongTermFacilityEncounter?.Period;
			var g_ = (f_ as object);
			var h_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Normalize_Interval(g_);
			var i_ = this.Measurement_Period();
			var j_ = context?.Operators.Overlaps(h_, i_, null);

			return context?.Operators.And(e_, j_);
		};
		var u_ = context?.Operators.WhereOrNull<Encounter>(s_, t_);
		var v_ = (Encounter LongTermFacilityEncounter) =>
		{
			var k_ = LongTermFacilityEncounter?.Period;
			var l_ = (k_ as object);
			var m_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Normalize_Interval(l_);
			var n_ = this.Measurement_Period();

			return context?.Operators.IntervalIntersectsInterval<CqlDateTime>(m_, n_);
		};

		return context?.Operators.SelectOrNull<Encounter, CqlInterval<CqlDateTime>>(u_, v_);
	}

    [CqlDeclaration("Long Term Care Periods During Measurement Period")]
    public IEnumerable<CqlInterval<CqlDateTime>> Long_Term_Care_Periods_During_Measurement_Period() => __Long_Term_Care_Periods_During_Measurement_Period.Value;

    private IEnumerable<Encounter> Outpatient_Encounters_with_Advanced_Illness_Value()
	{
		var ad_ = this.Outpatient();
		var ae_ = context?.DataRetriever.RetrieveByValueSet<Encounter>(ad_, null);
		var af_ = this.Observation();
		var ag_ = context?.DataRetriever.RetrieveByValueSet<Encounter>(af_, null);
		var ah_ = context?.Operators.ListUnion<Encounter>(ae_, ag_);
		var ai_ = this.Emergency_Department_Visit();
		var aj_ = context?.DataRetriever.RetrieveByValueSet<Encounter>(ai_, null);
		var ak_ = this.Nonacute_Inpatient();
		var al_ = context?.DataRetriever.RetrieveByValueSet<Encounter>(ak_, null);
		var am_ = context?.Operators.ListUnion<Encounter>(aj_, al_);
		var an_ = context?.Operators.ListUnion<Encounter>(ah_, am_);
		var ao_ = (Encounter Outpatient) =>
		{
			var a_ = Outpatient?.StatusElement;
			var b_ = (a_ as object);
			var c_ = (context.Deeper(new CallStackEntry("ToString", null, null))?.Operators?.TypeConverter).Convert<string>(b_);
			var d_ = (c_ as object);

			return context?.Operators.Equal(d_, ("finished" as object));
		};
		var ap_ = context?.Operators.WhereOrNull<Encounter>(an_, ao_);
		var aq_ = (Encounter OutpatientEncounter) =>
		{
			var y_ = this.Advanced_Illness();
			var z_ = context?.DataRetriever.RetrieveByValueSet<Condition>(y_, null);
			var aa_ = (Condition AdvancedIllnessDiagnosis) =>
			{
				var e_ = MATGlobalCommonFunctionsFHIR4_6_1_000.EncounterDiagnosis(OutpatientEncounter);
				var f_ = context?.Operators.InList<Condition>(AdvancedIllnessDiagnosis, e_);
				var g_ = OutpatientEncounter?.Period;
				var h_ = (g_ as object);
				var i_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Normalize_Interval(h_);
				var j_ = context?.Operators.Start(i_);
				var k_ = this.Measurement_Period();
				var l_ = context?.Operators.End(k_);
				var m_ = context?.Operators.Quantity(2m, "years");
				var n_ = context?.Operators.Subtract(l_, m_);
				var o_ = this.Measurement_Period();
				var p_ = context?.Operators.End(o_);
				var q_ = context?.Operators.Interval(n_, p_, true, true);
				var r_ = context?.Operators.ElementInInterval<CqlDateTime>(j_, q_, null);
				var s_ = this.Measurement_Period();
				var t_ = context?.Operators.End(s_);
				var u_ = (t_ == null);
				var v_ = (bool?)u_;
				var w_ = context?.Operators.Not(v_);
				var x_ = context?.Operators.And(r_, w_);

				return context?.Operators.And(f_, x_);
			};
			var ab_ = context?.Operators.WhereOrNull<Condition>(z_, aa_);
			var ac_ = (Condition AdvancedIllnessDiagnosis) => OutpatientEncounter;

			return context?.Operators.SelectOrNull<Condition, Encounter>(ab_, ac_);
		};

		return context?.Operators.SelectManyOrNull<Encounter, Encounter>(ap_, aq_);
	}

    [CqlDeclaration("Outpatient Encounters with Advanced Illness")]
    public IEnumerable<Encounter> Outpatient_Encounters_with_Advanced_Illness() => __Outpatient_Encounters_with_Advanced_Illness.Value;

    private IEnumerable<Encounter> Two_Outpatient_Encounters_with_Advanced_Illness_on_Different_Dates_of_Service_Value()
	{
		var m_ = this.Outpatient_Encounters_with_Advanced_Illness();
		var n_ = (Encounter _OutpatientEncounter1) => this.Outpatient_Encounters_with_Advanced_Illness();
		var o_ = (Encounter _OutpatientEncounter1, Encounter _OutpatientEncounter2) =>
		{
			var a_ = _OutpatientEncounter1;
			var b_ = _OutpatientEncounter2;

			return new Tuples.Tuple_EYKUVMTUWTABihhEAdHIGbSFe
			{
				OutpatientEncounter1 = a_,
				OutpatientEncounter2 = b_,
			};
		};
		var p_ = context?.Operators.SelectManyResultsOrNull<Encounter, Encounter, Tuples.Tuple_EYKUVMTUWTABihhEAdHIGbSFe>(m_, n_, o_);
		var q_ = (Tuples.Tuple_EYKUVMTUWTABihhEAdHIGbSFe tuple_eykuvmtuwtabihheadhigbsfe) =>
		{
			var c_ = tuple_eykuvmtuwtabihheadhigbsfe?.OutpatientEncounter2;
			var d_ = c_?.Period;
			var e_ = FHIRHelpers_4_0_001.ToInterval(d_);
			var f_ = context?.Operators.End(e_);
			var g_ = tuple_eykuvmtuwtabihheadhigbsfe?.OutpatientEncounter1;
			var h_ = g_?.Period;
			var i_ = FHIRHelpers_4_0_001.ToInterval(h_);
			var j_ = context?.Operators.End(i_);
			var k_ = context?.Operators.Quantity(1m, "day");
			var l_ = context?.Operators.Add(j_, k_);

			return context?.Operators.SameOrAfter(f_, l_, "day");
		};
		var r_ = context?.Operators.WhereOrNull<Tuples.Tuple_EYKUVMTUWTABihhEAdHIGbSFe>(p_, q_);
		var s_ = (Tuples.Tuple_EYKUVMTUWTABihhEAdHIGbSFe tuple_eykuvmtuwtabihheadhigbsfe) => tuple_eykuvmtuwtabihheadhigbsfe?.OutpatientEncounter1;

		return context?.Operators.SelectOrNull<Tuples.Tuple_EYKUVMTUWTABihhEAdHIGbSFe, Encounter>(r_, s_);
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
		var x_ = this.Long_Term_Care_Overlapping_Periods();
		var y_ = (CqlInterval<CqlDateTime> _LTCPeriod1) => this.Long_Term_Care_Overlapping_Periods();
		var z_ = (CqlInterval<CqlDateTime> _LTCPeriod1, CqlInterval<CqlDateTime> _LTCPeriod2) =>
		{
			var a_ = _LTCPeriod1;
			var b_ = _LTCPeriod2;

			return new Tuples.Tuple_IWAGVXGPWIVBAWDaHPGIVVBK
			{
				LTCPeriod1 = a_,
				LTCPeriod2 = b_,
			};
		};
		var aa_ = context?.Operators.SelectManyResultsOrNull<CqlInterval<CqlDateTime>, CqlInterval<CqlDateTime>, Tuples.Tuple_IWAGVXGPWIVBAWDaHPGIVVBK>(x_, y_, z_);
		var ab_ = (Tuples.Tuple_IWAGVXGPWIVBAWDaHPGIVVBK tuple_iwagvxgpwivbawdahpgivvbk) =>
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
			var q_ = (p_ == null);
			var r_ = (bool?)q_;
			var s_ = context?.Operators.Not(r_);

			return context?.Operators.And(n_, s_);
		};
		var ac_ = context?.Operators.WhereOrNull<Tuples.Tuple_IWAGVXGPWIVBAWDaHPGIVVBK>(aa_, ab_);
		var ad_ = (Tuples.Tuple_IWAGVXGPWIVBAWDaHPGIVVBK tuple_iwagvxgpwivbawdahpgivvbk) =>
		{
			var t_ = tuple_iwagvxgpwivbawdahpgivvbk?.LTCPeriod1;
			var u_ = context?.Operators.Start(t_);
			var v_ = tuple_iwagvxgpwivbawdahpgivvbk?.LTCPeriod2;
			var w_ = context?.Operators.End(v_);

			return context?.Operators.Interval(u_, w_, true, true);
		};

		return context?.Operators.SelectOrNull<Tuples.Tuple_IWAGVXGPWIVBAWDaHPGIVVBK, CqlInterval<CqlDateTime>>(ac_, ad_);
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
		var ad_ = this.Acute_Inpatient();
		var ae_ = context?.DataRetriever.RetrieveByValueSet<Encounter>(ad_, null);
		var af_ = (Encounter AcuteInpatient) =>
		{
			var a_ = AcuteInpatient?.StatusElement;
			var b_ = (a_ as object);
			var c_ = (context.Deeper(new CallStackEntry("ToString", null, null))?.Operators?.TypeConverter).Convert<string>(b_);
			var d_ = (c_ as object);

			return context?.Operators.Equal(d_, ("finished" as object));
		};
		var ag_ = context?.Operators.WhereOrNull<Encounter>(ae_, af_);
		var ah_ = (Encounter InpatientEncounter) =>
		{
			var y_ = this.Advanced_Illness();
			var z_ = context?.DataRetriever.RetrieveByValueSet<Condition>(y_, null);
			var aa_ = (Condition AdvancedIllnessDiagnosis) =>
			{
				var e_ = MATGlobalCommonFunctionsFHIR4_6_1_000.EncounterDiagnosis(InpatientEncounter);
				var f_ = context?.Operators.InList<Condition>(AdvancedIllnessDiagnosis, e_);
				var g_ = InpatientEncounter?.Period;
				var h_ = (g_ as object);
				var i_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Normalize_Interval(h_);
				var j_ = context?.Operators.Start(i_);
				var k_ = this.Measurement_Period();
				var l_ = context?.Operators.End(k_);
				var m_ = context?.Operators.Quantity(2m, "years");
				var n_ = context?.Operators.Subtract(l_, m_);
				var o_ = this.Measurement_Period();
				var p_ = context?.Operators.End(o_);
				var q_ = context?.Operators.Interval(n_, p_, true, true);
				var r_ = context?.Operators.ElementInInterval<CqlDateTime>(j_, q_, null);
				var s_ = this.Measurement_Period();
				var t_ = context?.Operators.End(s_);
				var u_ = (t_ == null);
				var v_ = (bool?)u_;
				var w_ = context?.Operators.Not(v_);
				var x_ = context?.Operators.And(r_, w_);

				return context?.Operators.And(f_, x_);
			};
			var ab_ = context?.Operators.WhereOrNull<Condition>(z_, aa_);
			var ac_ = (Condition AdvancedIllnessDiagnosis) => InpatientEncounter;

			return context?.Operators.SelectOrNull<Condition, Encounter>(ab_, ac_);
		};

		return context?.Operators.SelectManyOrNull<Encounter, Encounter>(ag_, ah_);
	}

    [CqlDeclaration("Inpatient Encounter with Advanced Illness")]
    public IEnumerable<Encounter> Inpatient_Encounter_with_Advanced_Illness() => __Inpatient_Encounter_with_Advanced_Illness.Value;

    private bool? Has_Criteria_Indicating_Frailty_Value()
	{
		var bj_ = this.Frailty_Device();
		var bk_ = context?.DataRetriever.RetrieveByValueSet<DeviceRequest>(bj_, null);
		var bl_ = this.Frailty_Device();
		var bm_ = context?.DataRetriever.RetrieveByValueSet<DeviceRequest>(bl_, null);
		var bn_ = context?.Operators.ListUnion<DeviceRequest>(bk_, bm_);
		var bo_ = (DeviceRequest FrailtyDeviceOrder) =>
		{
			var a_ = FrailtyDeviceOrder?.StatusElement;
			var b_ = (a_ as object);
			var c_ = (context.Deeper(new CallStackEntry("ToString", null, null))?.Operators?.TypeConverter).Convert<string>(b_);
			var d_ = "active";
			var e_ = "on-hold";
			var f_ = "completed";
			var g_ = new string[]
			{
				d_,
				e_,
				f_,
			};
			var h_ = (g_ as IEnumerable<string>);
			var i_ = context?.Operators.InList<string>(c_, h_);
			var j_ = FrailtyDeviceOrder?.IntentElement;
			var k_ = (j_ as object);
			var l_ = (context.Deeper(new CallStackEntry("ToString", null, null))?.Operators?.TypeConverter).Convert<string>(k_);
			var m_ = (l_ as object);
			var n_ = context?.Operators.Equal(m_, ("order" as object));
			var o_ = context?.Operators.And(i_, n_);
			var p_ = this.Measurement_Period();
			var q_ = FrailtyDeviceOrder?.AuthoredOnElement;
			var r_ = (q_ as object);
			var s_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Normalize_Interval(r_);
			var t_ = context?.Operators.IntervalIncludesInterval<CqlDateTime>(p_, s_, null);

			return context?.Operators.And(o_, t_);
		};
		var bp_ = context?.Operators.WhereOrNull<DeviceRequest>(bn_, bo_);
		var bq_ = context?.Operators.ExistsInList<DeviceRequest>(bp_);
		var br_ = this.Frailty_Device();
		var bs_ = context?.DataRetriever.RetrieveByValueSet<Observation>(br_, null);
		var bt_ = (Observation FrailtyDeviceApplied) =>
		{
			var u_ = FrailtyDeviceApplied?.StatusElement;
			var v_ = (u_ as object);
			var w_ = (context.Deeper(new CallStackEntry("ToString", null, null))?.Operators?.TypeConverter).Convert<string>(v_);
			var x_ = "final";
			var y_ = "amended";
			var z_ = "corrected";
			var aa_ = new string[]
			{
				x_,
				y_,
				z_,
			};
			var ab_ = (aa_ as IEnumerable<string>);
			var ac_ = context?.Operators.InList<string>(w_, ab_);
			var ad_ = FrailtyDeviceApplied?.Effective;
			var ae_ = (ad_ as object);
			var af_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Normalize_Interval(ae_);
			var ag_ = this.Measurement_Period();
			var ah_ = context?.Operators.Overlaps(af_, ag_, null);

			return context?.Operators.And(ac_, ah_);
		};
		var bu_ = context?.Operators.WhereOrNull<Observation>(bs_, bt_);
		var bv_ = context?.Operators.ExistsInList<Observation>(bu_);
		var bw_ = context?.Operators.Or(bq_, bv_);
		var bx_ = this.Frailty_Diagnosis();
		var by_ = context?.DataRetriever.RetrieveByValueSet<Condition>(bx_, null);
		var bz_ = (Condition FrailtyDiagnosis) =>
		{
			var ai_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Prevalence_Period(FrailtyDiagnosis);
			var aj_ = this.Measurement_Period();

			return context?.Operators.Overlaps(ai_, aj_, null);
		};
		var ca_ = context?.Operators.WhereOrNull<Condition>(by_, bz_);
		var cb_ = context?.Operators.ExistsInList<Condition>(ca_);
		var cc_ = context?.Operators.Or(bw_, cb_);
		var cd_ = this.Frailty_Encounter();
		var ce_ = context?.DataRetriever.RetrieveByValueSet<Encounter>(cd_, null);
		var cf_ = (Encounter FrailtyEncounter) =>
		{
			var ak_ = FrailtyEncounter?.StatusElement;
			var al_ = (ak_ as object);
			var am_ = (context.Deeper(new CallStackEntry("ToString", null, null))?.Operators?.TypeConverter).Convert<string>(al_);
			var an_ = (am_ as object);
			var ao_ = context?.Operators.Equal(an_, ("finished" as object));
			var ap_ = FrailtyEncounter?.Period;
			var aq_ = (ap_ as object);
			var ar_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Normalize_Interval(aq_);
			var as_ = this.Measurement_Period();
			var at_ = context?.Operators.Overlaps(ar_, as_, null);

			return context?.Operators.And(ao_, at_);
		};
		var cg_ = context?.Operators.WhereOrNull<Encounter>(ce_, cf_);
		var ch_ = context?.Operators.ExistsInList<Encounter>(cg_);
		var ci_ = context?.Operators.Or(cc_, ch_);
		var cj_ = this.Frailty_Symptom();
		var ck_ = context?.DataRetriever.RetrieveByValueSet<Observation>(cj_, null);
		var cl_ = (Observation FrailtySymptom) =>
		{
			var au_ = FrailtySymptom?.StatusElement;
			var av_ = (au_ as object);
			var aw_ = (context.Deeper(new CallStackEntry("ToString", null, null))?.Operators?.TypeConverter).Convert<string>(av_);
			var ax_ = "preliminary";
			var ay_ = "final";
			var az_ = "amended";
			var ba_ = "corrected";
			var bb_ = new string[]
			{
				ax_,
				ay_,
				az_,
				ba_,
			};
			var bc_ = (bb_ as IEnumerable<string>);
			var bd_ = context?.Operators.InList<string>(aw_, bc_);
			var be_ = FrailtySymptom?.Effective;
			var bf_ = (be_ as object);
			var bg_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Normalize_Interval(bf_);
			var bh_ = this.Measurement_Period();
			var bi_ = context?.Operators.Overlaps(bg_, bh_, null);

			return context?.Operators.And(bd_, bi_);
		};
		var cm_ = context?.Operators.WhereOrNull<Observation>(ck_, cl_);
		var cn_ = context?.Operators.ExistsInList<Observation>(cm_);

		return context?.Operators.Or(ci_, cn_);
	}

    [CqlDeclaration("Has Criteria Indicating Frailty")]
    public bool? Has_Criteria_Indicating_Frailty() => __Has_Criteria_Indicating_Frailty.Value;

    private bool? Advanced_Illness_and_Frailty_Exclusion_Including_Over_Age_80_Value()
	{
		var a_ = this.Patient();
		var b_ = a_?.BirthDateElement;
		var c_ = b_?.Value;
		var d_ = (c_ as object);
		var e_ = context?.Operators?.TypeConverter.Convert<CqlDate>(d_);
		var f_ = this.Measurement_Period();
		var g_ = context?.Operators.Start(f_);
		var h_ = context?.Operators.DateFrom(g_);
		var i_ = context?.Operators.CalculateAgeAt(e_, h_, "year");
		var j_ = context?.Operators.Interval((int?)65, (int?)79, true, true);
		var k_ = context?.Operators.ElementInInterval<int?>(i_, j_, null);
		var l_ = this.Has_Criteria_Indicating_Frailty();
		var m_ = context?.Operators.And(k_, l_);
		var n_ = this.Two_Outpatient_Encounters_with_Advanced_Illness_on_Different_Dates_of_Service();
		var o_ = context?.Operators.ExistsInList<Encounter>(n_);
		var p_ = this.Inpatient_Encounter_with_Advanced_Illness();
		var q_ = context?.Operators.ExistsInList<Encounter>(p_);
		var r_ = context?.Operators.Or(o_, q_);
		var s_ = this.Dementia_Medications_In_Year_Before_or_During_Measurement_Period();
		var t_ = context?.Operators.ExistsInList<MedicationRequest>(s_);
		var u_ = context?.Operators.Or(r_, t_);
		var v_ = context?.Operators.And(m_, u_);
		var w_ = this.Patient();
		var x_ = w_?.BirthDateElement;
		var y_ = x_?.Value;
		var z_ = (y_ as object);
		var aa_ = context?.Operators?.TypeConverter.Convert<CqlDate>(z_);
		var ab_ = this.Measurement_Period();
		var ac_ = context?.Operators.Start(ab_);
		var ad_ = context?.Operators.DateFrom(ac_);
		var ae_ = context?.Operators.CalculateAgeAt(aa_, ad_, "year");
		var af_ = ae_;
		var ag_ = (int?)80;
		var ah_ = ag_;
		var ai_ = context?.Operators.GreaterOrEqual(af_, ah_);
		var aj_ = this.Has_Criteria_Indicating_Frailty();
		var ak_ = context?.Operators.And(ai_, aj_);

		return context?.Operators.Or(v_, ak_);
	}

    [CqlDeclaration("Advanced Illness and Frailty Exclusion Including Over Age 80")]
    public bool? Advanced_Illness_and_Frailty_Exclusion_Including_Over_Age_80() => __Advanced_Illness_and_Frailty_Exclusion_Including_Over_Age_80.Value;

    private bool? Advanced_Illness_and_Frailty_Exclusion_Not_Including_Over_Age_80_Value()
	{
		var a_ = this.Patient();
		var b_ = a_?.BirthDateElement;
		var c_ = b_?.Value;
		var d_ = (c_ as object);
		var e_ = context?.Operators?.TypeConverter.Convert<CqlDate>(d_);
		var f_ = this.Measurement_Period();
		var g_ = context?.Operators.Start(f_);
		var h_ = context?.Operators.DateFrom(g_);
		var i_ = context?.Operators.CalculateAgeAt(e_, h_, "year");
		var j_ = i_;
		var k_ = (int?)65;
		var l_ = k_;
		var m_ = context?.Operators.GreaterOrEqual(j_, l_);
		var n_ = this.Has_Criteria_Indicating_Frailty();
		var o_ = context?.Operators.And(m_, n_);
		var p_ = this.Two_Outpatient_Encounters_with_Advanced_Illness_on_Different_Dates_of_Service();
		var q_ = context?.Operators.ExistsInList<Encounter>(p_);
		var r_ = this.Inpatient_Encounter_with_Advanced_Illness();
		var s_ = context?.Operators.ExistsInList<Encounter>(r_);
		var t_ = context?.Operators.Or(q_, s_);
		var u_ = this.Dementia_Medications_In_Year_Before_or_During_Measurement_Period();
		var v_ = context?.Operators.ExistsInList<MedicationRequest>(u_);
		var w_ = context?.Operators.Or(t_, v_);

		return context?.Operators.And(o_, w_);
	}

    [CqlDeclaration("Advanced Illness and Frailty Exclusion Not Including Over Age 80")]
    public bool? Advanced_Illness_and_Frailty_Exclusion_Not_Including_Over_Age_80() => __Advanced_Illness_and_Frailty_Exclusion_Not_Including_Over_Age_80.Value;

    private bool? Has_Long_Term_Care_Periods_Longer_Than_90_Consecutive_Days_Value()
	{
		var a_ = this.Max_Long_Term_Care_Period_Length();
		var b_ = a_;
		var c_ = (int?)90;
		var d_ = c_;

		return context?.Operators.Greater(b_, d_);
	}

    [CqlDeclaration("Has Long Term Care Periods Longer Than 90 Consecutive Days")]
    public bool? Has_Long_Term_Care_Periods_Longer_Than_90_Consecutive_Days() => __Has_Long_Term_Care_Periods_Longer_Than_90_Consecutive_Days.Value;

}