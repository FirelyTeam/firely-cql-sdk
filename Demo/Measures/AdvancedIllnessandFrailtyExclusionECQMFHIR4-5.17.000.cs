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
        return new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1083", 
			null);
    }

    [CqlDeclaration("Acute Inpatient")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1083")]
    public CqlValueSet Acute_Inpatient() => __Acute_Inpatient.Value;

    private CqlValueSet Advanced_Illness_Value()
    {
        return new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.110.12.1082", 
			null);
    }

    [CqlDeclaration("Advanced Illness")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.110.12.1082")]
    public CqlValueSet Advanced_Illness() => __Advanced_Illness.Value;

    private CqlValueSet Care_Services_in_Long_Term_Residential_Facility_Value()
    {
        return new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1014", 
			null);
    }

    [CqlDeclaration("Care Services in Long-Term Residential Facility")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1014")]
    public CqlValueSet Care_Services_in_Long_Term_Residential_Facility() => __Care_Services_in_Long_Term_Residential_Facility.Value;

    private CqlValueSet Dementia_Medications_Value()
    {
        return new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.196.12.1510", 
			null);
    }

    [CqlDeclaration("Dementia Medications")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.196.12.1510")]
    public CqlValueSet Dementia_Medications() => __Dementia_Medications.Value;

    private CqlValueSet Emergency_Department_Visit_Value()
    {
        return new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1010", 
			null);
    }

    [CqlDeclaration("Emergency Department Visit")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1010")]
    public CqlValueSet Emergency_Department_Visit() => __Emergency_Department_Visit.Value;

    private CqlValueSet Frailty_Device_Value()
    {
        return new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.118.12.1300", 
			null);
    }

    [CqlDeclaration("Frailty Device")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.118.12.1300")]
    public CqlValueSet Frailty_Device() => __Frailty_Device.Value;

    private CqlValueSet Frailty_Diagnosis_Value()
    {
        return new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.113.12.1074", 
			null);
    }

    [CqlDeclaration("Frailty Diagnosis")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.113.12.1074")]
    public CqlValueSet Frailty_Diagnosis() => __Frailty_Diagnosis.Value;

    private CqlValueSet Frailty_Encounter_Value()
    {
        return new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1088", 
			null);
    }

    [CqlDeclaration("Frailty Encounter")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1088")]
    public CqlValueSet Frailty_Encounter() => __Frailty_Encounter.Value;

    private CqlValueSet Frailty_Symptom_Value()
    {
        return new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.113.12.1075", 
			null);
    }

    [CqlDeclaration("Frailty Symptom")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.113.12.1075")]
    public CqlValueSet Frailty_Symptom() => __Frailty_Symptom.Value;

    private CqlValueSet Nonacute_Inpatient_Value()
    {
        return new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1084", 
			null);
    }

    [CqlDeclaration("Nonacute Inpatient")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1084")]
    public CqlValueSet Nonacute_Inpatient() => __Nonacute_Inpatient.Value;

    private CqlValueSet Nursing_Facility_Visit_Value()
    {
        return new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1012", 
			null);
    }

    [CqlDeclaration("Nursing Facility Visit")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1012")]
    public CqlValueSet Nursing_Facility_Visit() => __Nursing_Facility_Visit.Value;

    private CqlValueSet Observation_Value()
    {
        return new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1086", 
			null);
    }

    [CqlDeclaration("Observation")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1086")]
    public CqlValueSet Observation() => __Observation.Value;

    private CqlValueSet Outpatient_Value()
    {
        return new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1087", 
			null);
    }

    [CqlDeclaration("Outpatient")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1087")]
    public CqlValueSet Outpatient() => __Outpatient.Value;

    private CqlInterval<CqlDateTime> Measurement_Period_Value()
    {
        return ((CqlInterval<CqlDateTime>)context.ResolveParameter("AdvancedIllnessandFrailtyExclusionECQMFHIR4-5.17.000", 
			"Measurement Period", 
			null));
    }

    [CqlDeclaration("Measurement Period")]
    public CqlInterval<CqlDateTime> Measurement_Period() => __Measurement_Period.Value;

    private Patient Patient_Value()
    {
        var a_ = context?.DataRetriever.RetrieveByValueSet<Patient>(null, 
			null);
        return context?.Operators.SingleOrNull<Patient>(a_);
    }
    [CqlDeclaration("Patient")]
    public Patient Patient() => __Patient.Value;

    private IEnumerable<MedicationRequest> Dementia_Medications_In_Year_Before_or_During_Measurement_Period_Value()
    {
        var a_ = this.Dementia_Medications();
        var b_ = context?.DataRetriever.RetrieveByValueSet<MedicationRequest>(a_, 
			null);
        var e_ = context?.Operators.ListUnion<MedicationRequest>(b_, 
			b_);
        Func<MedicationRequest,bool?> y_ = (DementiaMed) => 
        {
            var g_ = (DementiaMed?.StatusElement as object);
            var f_ = ((context.Deeper(new CallStackEntry("ToString", 
		null, 
		null))?.Operators?.TypeConverter).Convert<string>(g_) as object);
            var h_ = ("active" as object);
            var i_ = context?.Operators.Equal(f_, 
				h_);
            var k_ = (DementiaMed?.IntentElement as object);
            var j_ = ((context.Deeper(new CallStackEntry("ToString", 
		null, 
		null))?.Operators?.TypeConverter).Convert<string>(k_) as object);
            var l_ = ("order" as object);
            var m_ = context?.Operators.Equal(j_, 
				l_);
            var n_ = context?.Operators.And(i_, 
				m_);
            var o_ = (DementiaMed as object);
            var p_ = CumulativeMedicationDurationFHIR4_1_0_000.MedicationPeriod(o_);
            var q_ = this.Measurement_Period();
            var r_ = context?.Operators.Start(q_);
            var s_ = context?.Operators.Quantity(1m, 
				"year");
            var t_ = context?.Operators.Subtract(r_, 
				s_);
            var v_ = context?.Operators.End(q_);
            var w_ = context?.Operators.Interval(t_, 
				v_, 
				true, 
				true);
            var x_ = context?.Operators.Overlaps(p_, 
				w_, 
				null);
            return context?.Operators.And(n_, 
				x_);
        };
        return context?.Operators.WhereOrNull<MedicationRequest>(e_, 
			y_);
    }
    [CqlDeclaration("Dementia Medications In Year Before or During Measurement Period")]
    public IEnumerable<MedicationRequest> Dementia_Medications_In_Year_Before_or_During_Measurement_Period() => __Dementia_Medications_In_Year_Before_or_During_Measurement_Period.Value;

    private IEnumerable<CqlInterval<CqlDateTime>> Long_Term_Care_Periods_During_Measurement_Period_Value()
    {
        var a_ = this.Care_Services_in_Long_Term_Residential_Facility();
        var b_ = context?.DataRetriever.RetrieveByValueSet<Encounter>(a_, 
			null);
        var c_ = this.Nursing_Facility_Visit();
        var d_ = context?.DataRetriever.RetrieveByValueSet<Encounter>(c_, 
			null);
        var e_ = context?.Operators.ListUnion<Encounter>(b_, 
			d_);
        Func<Encounter,bool?> n_ = (LongTermFacilityEncounter) => 
        {
            var g_ = (LongTermFacilityEncounter?.StatusElement as object);
            var f_ = ((context.Deeper(new CallStackEntry("ToString", 
		null, 
		null))?.Operators?.TypeConverter).Convert<string>(g_) as object);
            var h_ = ("finished" as object);
            var i_ = context?.Operators.Equal(f_, 
				h_);
            var j_ = (LongTermFacilityEncounter?.Period as object);
            var k_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Normalize_Interval(j_);
            var l_ = this.Measurement_Period();
            var m_ = context?.Operators.Overlaps(k_, 
				l_, 
				null);
            return context?.Operators.And(i_, 
				m_);
        };
        var o_ = context?.Operators.WhereOrNull<Encounter>(e_, 
			n_);
        Func<Encounter,CqlInterval<CqlDateTime>> s_ = (LongTermFacilityEncounter) => 
        {
            var p_ = (LongTermFacilityEncounter?.Period as object);
            var q_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Normalize_Interval(p_);
            var r_ = this.Measurement_Period();
            return context?.Operators.IntervalIntersectsInterval<CqlDateTime>(q_, 
				r_);
        };
        return context?.Operators.SelectOrNull<Encounter, CqlInterval<CqlDateTime>>(o_, 
			s_);
    }
    [CqlDeclaration("Long Term Care Periods During Measurement Period")]
    public IEnumerable<CqlInterval<CqlDateTime>> Long_Term_Care_Periods_During_Measurement_Period() => __Long_Term_Care_Periods_During_Measurement_Period.Value;

    private IEnumerable<Encounter> Outpatient_Encounters_with_Advanced_Illness_Value()
    {
        var a_ = this.Outpatient();
        var b_ = context?.DataRetriever.RetrieveByValueSet<Encounter>(a_, 
			null);
        var c_ = this.Observation();
        var d_ = context?.DataRetriever.RetrieveByValueSet<Encounter>(c_, 
			null);
        var e_ = context?.Operators.ListUnion<Encounter>(b_, 
			d_);
        var f_ = this.Emergency_Department_Visit();
        var g_ = context?.DataRetriever.RetrieveByValueSet<Encounter>(f_, 
			null);
        var h_ = this.Nonacute_Inpatient();
        var i_ = context?.DataRetriever.RetrieveByValueSet<Encounter>(h_, 
			null);
        var j_ = context?.Operators.ListUnion<Encounter>(g_, 
			i_);
        var k_ = context?.Operators.ListUnion<Encounter>(e_, 
			j_);
        Func<Encounter,bool?> o_ = (Outpatient) => 
        {
            var m_ = (Outpatient?.StatusElement as object);
            var l_ = ((context.Deeper(new CallStackEntry("ToString", 
		null, 
		null))?.Operators?.TypeConverter).Convert<string>(m_) as object);
            var n_ = ("finished" as object);
            return context?.Operators.Equal(l_, 
				n_);
        };
        var p_ = context?.Operators.WhereOrNull<Encounter>(k_, 
			o_);
        Func<Encounter,IEnumerable<Encounter>> am_ = (OutpatientEncounter) => 
        {
            var q_ = this.Advanced_Illness();
            var r_ = context?.DataRetriever.RetrieveByValueSet<Condition>(q_, 
				null);
            Func<Condition,bool?> aj_ = (AdvancedIllnessDiagnosis) => 
            {
                var s_ = MATGlobalCommonFunctionsFHIR4_6_1_000.EncounterDiagnosis(OutpatientEncounter);
                var t_ = context?.Operators.InList<Condition>(AdvancedIllnessDiagnosis, 
					s_);
                var u_ = (OutpatientEncounter?.Period as object);
                var v_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Normalize_Interval(u_);
                var w_ = context?.Operators.Start(v_);
                var x_ = this.Measurement_Period();
                var y_ = context?.Operators.End(x_);
                var z_ = context?.Operators.Quantity(2m, 
					"years");
                var aa_ = context?.Operators.Subtract(y_, 
					z_);
                var ad_ = context?.Operators.Interval(aa_, 
					y_, 
					true, 
					true);
                var ae_ = context?.Operators.ElementInInterval<CqlDateTime>(w_, 
					ad_, 
					null);
                bool? af_ = ((bool?)(context?.Operators.End(x_) == null));
                var ah_ = context?.Operators.Not(af_);
                var ai_ = context?.Operators.And(ae_, 
					ah_);
                return context?.Operators.And(t_, 
					ai_);
            };
            var ak_ = context?.Operators.WhereOrNull<Condition>(r_, 
				aj_);
            Func<Condition,Encounter> al_ = (AdvancedIllnessDiagnosis) => OutpatientEncounter;
            return context?.Operators.SelectOrNull<Condition, Encounter>(ak_, 
				al_);
        };
        return context?.Operators.SelectManyOrNull<Encounter, Encounter>(p_, 
			am_);
    }
    [CqlDeclaration("Outpatient Encounters with Advanced Illness")]
    public IEnumerable<Encounter> Outpatient_Encounters_with_Advanced_Illness() => __Outpatient_Encounters_with_Advanced_Illness.Value;

    private IEnumerable<Encounter> Two_Outpatient_Encounters_with_Advanced_Illness_on_Different_Dates_of_Service_Value()
    {
        var a_ = this.Outpatient_Encounters_with_Advanced_Illness();
        Func<Encounter,IEnumerable<Encounter>> b_ = (_OutpatientEncounter1) => 
        {
            return this.Outpatient_Encounters_with_Advanced_Illness();
        };
        Func<Encounter,Encounter,Tuples.Tuple_EYKUVMTUWTABihhEAdHIGbSFe> e_ = (_OutpatientEncounter1, _OutpatientEncounter2) => 
        {
            var c_ = _OutpatientEncounter1;
            var d_ = _OutpatientEncounter2;
            return new Tuples.Tuple_EYKUVMTUWTABihhEAdHIGbSFe
			{
				OutpatientEncounter1 = c_,
				OutpatientEncounter2 = d_,
			};
        };
        var f_ = context?.Operators.SelectManyResultsOrNull<Encounter, Encounter, Tuples.Tuple_EYKUVMTUWTABihhEAdHIGbSFe>(a_, 
			b_, 
			e_);
        Func<Tuples.Tuple_EYKUVMTUWTABihhEAdHIGbSFe,bool?> o_ = (tuple_eykuvmtuwtabihheadhigbsfe) => 
        {
            var g_ = tuple_eykuvmtuwtabihheadhigbsfe?.OutpatientEncounter2?.Period;
            var h_ = FHIRHelpers_4_0_001.ToInterval(g_);
            var i_ = context?.Operators.End(h_);
            var j_ = tuple_eykuvmtuwtabihheadhigbsfe?.OutpatientEncounter1?.Period;
            var k_ = FHIRHelpers_4_0_001.ToInterval(j_);
            var l_ = context?.Operators.End(k_);
            var m_ = context?.Operators.Quantity(1m, 
				"day");
            var n_ = context?.Operators.Add(l_, 
				m_);
            return context?.Operators.SameOrAfter(i_, 
				n_, 
				"day");
        };
        var p_ = context?.Operators.WhereOrNull<Tuples.Tuple_EYKUVMTUWTABihhEAdHIGbSFe>(f_, 
			o_);
        Func<Tuples.Tuple_EYKUVMTUWTABihhEAdHIGbSFe,Encounter> q_ = (tuple_eykuvmtuwtabihheadhigbsfe) => tuple_eykuvmtuwtabihheadhigbsfe?.OutpatientEncounter1;
        return context?.Operators.SelectOrNull<Tuples.Tuple_EYKUVMTUWTABihhEAdHIGbSFe, Encounter>(p_, 
			q_);
    }
    [CqlDeclaration("Two Outpatient Encounters with Advanced Illness on Different Dates of Service")]
    public IEnumerable<Encounter> Two_Outpatient_Encounters_with_Advanced_Illness_on_Different_Dates_of_Service() => __Two_Outpatient_Encounters_with_Advanced_Illness_on_Different_Dates_of_Service.Value;

    private IEnumerable<CqlInterval<CqlDateTime>> Long_Term_Care_Overlapping_Periods_Value()
    {
        var a_ = this.Long_Term_Care_Periods_During_Measurement_Period();
        return context?.Operators.Collapse(a_, 
			null);
    }
    [CqlDeclaration("Long Term Care Overlapping Periods")]
    public IEnumerable<CqlInterval<CqlDateTime>> Long_Term_Care_Overlapping_Periods() => __Long_Term_Care_Overlapping_Periods.Value;

    private IEnumerable<CqlInterval<CqlDateTime>> Long_Term_Care_Adjacent_Periods_Value()
    {
        var a_ = this.Long_Term_Care_Overlapping_Periods();
        Func<CqlInterval<CqlDateTime>,IEnumerable<CqlInterval<CqlDateTime>>> b_ = (_LTCPeriod1) => 
        {
            return this.Long_Term_Care_Overlapping_Periods();
        };
        Func<CqlInterval<CqlDateTime>,CqlInterval<CqlDateTime>,Tuples.Tuple_IWAGVXGPWIVBAWDaHPGIVVBK> e_ = (_LTCPeriod1, _LTCPeriod2) => 
        {
            var c_ = _LTCPeriod1;
            var d_ = _LTCPeriod2;
            return new Tuples.Tuple_IWAGVXGPWIVBAWDaHPGIVVBK
			{
				LTCPeriod1 = c_,
				LTCPeriod2 = d_,
			};
        };
        var f_ = context?.Operators.SelectManyResultsOrNull<CqlInterval<CqlDateTime>, CqlInterval<CqlDateTime>, Tuples.Tuple_IWAGVXGPWIVBAWDaHPGIVVBK>(a_, 
			b_, 
			e_);
        Func<Tuples.Tuple_IWAGVXGPWIVBAWDaHPGIVVBK,bool?> r_ = (tuple_iwagvxgpwivbawdahpgivvbk) => 
        {
            var g_ = context?.Operators.End(tuple_iwagvxgpwivbawdahpgivvbk?.LTCPeriod1);
            var h_ = context?.Operators.Start(tuple_iwagvxgpwivbawdahpgivvbk?.LTCPeriod2);
            var i_ = context?.Operators.Quantity(1m, 
				"day");
            var j_ = context?.Operators.Subtract(h_, 
				i_);
            var m_ = context?.Operators.Add(h_, 
				i_);
            var n_ = context?.Operators.Interval(j_, 
				m_, 
				true, 
				true);
            var o_ = context?.Operators.ElementInInterval<CqlDateTime>(g_, 
				n_, 
				null);
            bool? p_ = ((bool?)(context?.Operators.Start(tuple_iwagvxgpwivbawdahpgivvbk?.LTCPeriod2) == null));
            var q_ = context?.Operators.Not(p_);
            return context?.Operators.And(o_, 
				q_);
        };
        var s_ = context?.Operators.WhereOrNull<Tuples.Tuple_IWAGVXGPWIVBAWDaHPGIVVBK>(f_, 
			r_);
        Func<Tuples.Tuple_IWAGVXGPWIVBAWDaHPGIVVBK,CqlInterval<CqlDateTime>> v_ = (tuple_iwagvxgpwivbawdahpgivvbk) => 
        {
            var t_ = context?.Operators.Start(tuple_iwagvxgpwivbawdahpgivvbk?.LTCPeriod1);
            var u_ = context?.Operators.End(tuple_iwagvxgpwivbawdahpgivvbk?.LTCPeriod2);
            return context?.Operators.Interval(t_, 
				u_, 
				true, 
				true);
        };
        return context?.Operators.SelectOrNull<Tuples.Tuple_IWAGVXGPWIVBAWDaHPGIVVBK, CqlInterval<CqlDateTime>>(s_, 
			v_);
    }
    [CqlDeclaration("Long Term Care Adjacent Periods")]
    public IEnumerable<CqlInterval<CqlDateTime>> Long_Term_Care_Adjacent_Periods() => __Long_Term_Care_Adjacent_Periods.Value;

    private int? Max_Long_Term_Care_Period_Length_Value()
    {
        var a_ = this.Long_Term_Care_Overlapping_Periods();
        var b_ = this.Long_Term_Care_Adjacent_Periods();
        var c_ = context?.Operators.ListUnion<CqlInterval<CqlDateTime>>(a_, 
			b_);
        var d_ = context?.Operators.Collapse(c_, 
			null);
        Func<CqlInterval<CqlDateTime>,int?> g_ = (LTCPeriods) => 
        {
            var e_ = context?.Operators.Start(LTCPeriods);
            var f_ = context?.Operators.End(LTCPeriods);
            return context?.Operators.DurationBetween(e_, 
				f_, 
				"day");
        };
        var h_ = context?.Operators.SelectOrNull<CqlInterval<CqlDateTime>, int?>(d_, 
			g_);
        return context?.Operators.MaxOrNull<int?>(h_);
    }
    [CqlDeclaration("Max Long Term Care Period Length")]
    public int? Max_Long_Term_Care_Period_Length() => __Max_Long_Term_Care_Period_Length.Value;

    private IEnumerable<Encounter> Inpatient_Encounter_with_Advanced_Illness_Value()
    {
        var a_ = this.Acute_Inpatient();
        var b_ = context?.DataRetriever.RetrieveByValueSet<Encounter>(a_, 
			null);
        Func<Encounter,bool?> f_ = (AcuteInpatient) => 
        {
            var d_ = (AcuteInpatient?.StatusElement as object);
            var c_ = ((context.Deeper(new CallStackEntry("ToString", 
		null, 
		null))?.Operators?.TypeConverter).Convert<string>(d_) as object);
            var e_ = ("finished" as object);
            return context?.Operators.Equal(c_, 
				e_);
        };
        var g_ = context?.Operators.WhereOrNull<Encounter>(b_, 
			f_);
        Func<Encounter,IEnumerable<Encounter>> ad_ = (InpatientEncounter) => 
        {
            var h_ = this.Advanced_Illness();
            var i_ = context?.DataRetriever.RetrieveByValueSet<Condition>(h_, 
				null);
            Func<Condition,bool?> aa_ = (AdvancedIllnessDiagnosis) => 
            {
                var j_ = MATGlobalCommonFunctionsFHIR4_6_1_000.EncounterDiagnosis(InpatientEncounter);
                var k_ = context?.Operators.InList<Condition>(AdvancedIllnessDiagnosis, 
					j_);
                var l_ = (InpatientEncounter?.Period as object);
                var m_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Normalize_Interval(l_);
                var n_ = context?.Operators.Start(m_);
                var o_ = this.Measurement_Period();
                var p_ = context?.Operators.End(o_);
                var q_ = context?.Operators.Quantity(2m, 
					"years");
                var r_ = context?.Operators.Subtract(p_, 
					q_);
                var u_ = context?.Operators.Interval(r_, 
					p_, 
					true, 
					true);
                var v_ = context?.Operators.ElementInInterval<CqlDateTime>(n_, 
					u_, 
					null);
                bool? w_ = ((bool?)(context?.Operators.End(o_) == null));
                var y_ = context?.Operators.Not(w_);
                var z_ = context?.Operators.And(v_, 
					y_);
                return context?.Operators.And(k_, 
					z_);
            };
            var ab_ = context?.Operators.WhereOrNull<Condition>(i_, 
				aa_);
            Func<Condition,Encounter> ac_ = (AdvancedIllnessDiagnosis) => InpatientEncounter;
            return context?.Operators.SelectOrNull<Condition, Encounter>(ab_, 
				ac_);
        };
        return context?.Operators.SelectManyOrNull<Encounter, Encounter>(g_, 
			ad_);
    }
    [CqlDeclaration("Inpatient Encounter with Advanced Illness")]
    public IEnumerable<Encounter> Inpatient_Encounter_with_Advanced_Illness() => __Inpatient_Encounter_with_Advanced_Illness.Value;

    private bool? Has_Criteria_Indicating_Frailty_Value()
    {
        var a_ = this.Frailty_Device();
        var b_ = context?.DataRetriever.RetrieveByValueSet<DeviceRequest>(a_, 
			null);
        var e_ = context?.Operators.ListUnion<DeviceRequest>(b_, 
			b_);
        Func<DeviceRequest,bool?> v_ = (FrailtyDeviceOrder) => 
        {
            var f_ = (FrailtyDeviceOrder?.StatusElement as object);
            var g_ = (context.Deeper(new CallStackEntry("ToString", 
		null, 
		null))?.Operators?.TypeConverter).Convert<string>(f_);
            var i_ = "active";
            var j_ = "on-hold";
            var k_ = "completed";
            var h_ = (new string[]
			{
				i_,
				j_,
				k_,
			} as IEnumerable<string>);
            var l_ = context?.Operators.InList<string>(g_, 
				h_);
            var n_ = (FrailtyDeviceOrder?.IntentElement as object);
            var m_ = ((context.Deeper(new CallStackEntry("ToString", 
		null, 
		null))?.Operators?.TypeConverter).Convert<string>(n_) as object);
            var o_ = ("order" as object);
            var p_ = context?.Operators.Equal(m_, 
				o_);
            var q_ = context?.Operators.And(l_, 
				p_);
            var r_ = this.Measurement_Period();
            var s_ = (FrailtyDeviceOrder?.AuthoredOnElement as object);
            var t_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Normalize_Interval(s_);
            var u_ = context?.Operators.IntervalIncludesInterval<CqlDateTime>(r_, 
				t_, 
				null);
            return context?.Operators.And(q_, 
				u_);
        };
        var w_ = context?.Operators.WhereOrNull<DeviceRequest>(e_, 
			v_);
        var x_ = context?.Operators.ExistsInList<DeviceRequest>(w_);
        var z_ = context?.DataRetriever.RetrieveByValueSet<Observation>(a_, 
			null);
        Func<Observation,bool?> al_ = (FrailtyDeviceApplied) => 
        {
            var aa_ = (FrailtyDeviceApplied?.StatusElement as object);
            var ab_ = (context.Deeper(new CallStackEntry("ToString", 
		null, 
		null))?.Operators?.TypeConverter).Convert<string>(aa_);
            var ad_ = "final";
            var ae_ = "amended";
            var af_ = "corrected";
            var ac_ = (new string[]
			{
				ad_,
				ae_,
				af_,
			} as IEnumerable<string>);
            var ag_ = context?.Operators.InList<string>(ab_, 
				ac_);
            var ah_ = (FrailtyDeviceApplied?.Effective as object);
            var ai_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Normalize_Interval(ah_);
            var aj_ = this.Measurement_Period();
            var ak_ = context?.Operators.Overlaps(ai_, 
				aj_, 
				null);
            return context?.Operators.And(ag_, 
				ak_);
        };
        var am_ = context?.Operators.WhereOrNull<Observation>(z_, 
			al_);
        var an_ = context?.Operators.ExistsInList<Observation>(am_);
        var ao_ = context?.Operators.Or(x_, 
			an_);
        var ap_ = this.Frailty_Diagnosis();
        var aq_ = context?.DataRetriever.RetrieveByValueSet<Condition>(ap_, 
			null);
        Func<Condition,bool?> at_ = (FrailtyDiagnosis) => 
        {
            var ar_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Prevalence_Period(FrailtyDiagnosis);
            var as_ = this.Measurement_Period();
            return context?.Operators.Overlaps(ar_, 
				as_, 
				null);
        };
        var au_ = context?.Operators.WhereOrNull<Condition>(aq_, 
			at_);
        var av_ = context?.Operators.ExistsInList<Condition>(au_);
        var aw_ = context?.Operators.Or(ao_, 
			av_);
        var ax_ = this.Frailty_Encounter();
        var ay_ = context?.DataRetriever.RetrieveByValueSet<Encounter>(ax_, 
			null);
        Func<Encounter,bool?> bh_ = (FrailtyEncounter) => 
        {
            var ba_ = (FrailtyEncounter?.StatusElement as object);
            var az_ = ((context.Deeper(new CallStackEntry("ToString", 
		null, 
		null))?.Operators?.TypeConverter).Convert<string>(ba_) as object);
            var bb_ = ("finished" as object);
            var bc_ = context?.Operators.Equal(az_, 
				bb_);
            var bd_ = (FrailtyEncounter?.Period as object);
            var be_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Normalize_Interval(bd_);
            var bf_ = this.Measurement_Period();
            var bg_ = context?.Operators.Overlaps(be_, 
				bf_, 
				null);
            return context?.Operators.And(bc_, 
				bg_);
        };
        var bi_ = context?.Operators.WhereOrNull<Encounter>(ay_, 
			bh_);
        var bj_ = context?.Operators.ExistsInList<Encounter>(bi_);
        var bk_ = context?.Operators.Or(aw_, 
			bj_);
        var bl_ = this.Frailty_Symptom();
        var bm_ = context?.DataRetriever.RetrieveByValueSet<Observation>(bl_, 
			null);
        Func<Observation,bool?> bz_ = (FrailtySymptom) => 
        {
            var bn_ = (FrailtySymptom?.StatusElement as object);
            var bo_ = (context.Deeper(new CallStackEntry("ToString", 
		null, 
		null))?.Operators?.TypeConverter).Convert<string>(bn_);
            var bq_ = "preliminary";
            var br_ = "final";
            var bs_ = "amended";
            var bt_ = "corrected";
            var bp_ = (new string[]
			{
				bq_,
				br_,
				bs_,
				bt_,
			} as IEnumerable<string>);
            var bu_ = context?.Operators.InList<string>(bo_, 
				bp_);
            var bv_ = (FrailtySymptom?.Effective as object);
            var bw_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Normalize_Interval(bv_);
            var bx_ = this.Measurement_Period();
            var by_ = context?.Operators.Overlaps(bw_, 
				bx_, 
				null);
            return context?.Operators.And(bu_, 
				by_);
        };
        var ca_ = context?.Operators.WhereOrNull<Observation>(bm_, 
			bz_);
        var cb_ = context?.Operators.ExistsInList<Observation>(ca_);
        return context?.Operators.Or(bk_, 
			cb_);
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
        var f_ = context?.Operators.CalculateAgeAt(b_, 
			e_, 
			"year");
        var g_ = context?.Operators.Interval(((int?)65), 
			((int?)79), 
			true, 
			true);
        var h_ = context?.Operators.ElementInInterval<int?>(f_, 
			g_, 
			null);
        var i_ = this.Has_Criteria_Indicating_Frailty();
        var j_ = context?.Operators.And(h_, 
			i_);
        var k_ = this.Two_Outpatient_Encounters_with_Advanced_Illness_on_Different_Dates_of_Service();
        var l_ = context?.Operators.ExistsInList<Encounter>(k_);
        var m_ = this.Inpatient_Encounter_with_Advanced_Illness();
        var n_ = context?.Operators.ExistsInList<Encounter>(m_);
        var o_ = context?.Operators.Or(l_, 
			n_);
        var p_ = this.Dementia_Medications_In_Year_Before_or_During_Measurement_Period();
        var q_ = context?.Operators.ExistsInList<MedicationRequest>(p_);
        var r_ = context?.Operators.Or(o_, 
			q_);
        var s_ = context?.Operators.And(j_, 
			r_);
        var t_ = (context?.Operators.CalculateAgeAt(b_, 
			e_, 
			"year") as object);
        var z_ = (((int?)80) as object);
        var aa_ = context?.Operators.GreaterOrEqual(t_, 
			z_);
        var ac_ = context?.Operators.And(aa_, 
			i_);
        return context?.Operators.Or(s_, 
			ac_);
    }
    [CqlDeclaration("Advanced Illness and Frailty Exclusion Including Over Age 80")]
    public bool? Advanced_Illness_and_Frailty_Exclusion_Including_Over_Age_80() => __Advanced_Illness_and_Frailty_Exclusion_Including_Over_Age_80.Value;

    private bool? Advanced_Illness_and_Frailty_Exclusion_Not_Including_Over_Age_80_Value()
    {
        var b_ = (this.Patient()?.BirthDateElement?.Value as object);
        var c_ = context?.Operators?.TypeConverter.Convert<CqlDate>(b_);
        var d_ = this.Measurement_Period();
        var e_ = context?.Operators.Start(d_);
        var f_ = context?.Operators.DateFrom(e_);
        var a_ = (context?.Operators.CalculateAgeAt(c_, 
			f_, 
			"year") as object);
        var g_ = (((int?)65) as object);
        var h_ = context?.Operators.GreaterOrEqual(a_, 
			g_);
        var i_ = this.Has_Criteria_Indicating_Frailty();
        var j_ = context?.Operators.And(h_, 
			i_);
        var k_ = this.Two_Outpatient_Encounters_with_Advanced_Illness_on_Different_Dates_of_Service();
        var l_ = context?.Operators.ExistsInList<Encounter>(k_);
        var m_ = this.Inpatient_Encounter_with_Advanced_Illness();
        var n_ = context?.Operators.ExistsInList<Encounter>(m_);
        var o_ = context?.Operators.Or(l_, 
			n_);
        var p_ = this.Dementia_Medications_In_Year_Before_or_During_Measurement_Period();
        var q_ = context?.Operators.ExistsInList<MedicationRequest>(p_);
        var r_ = context?.Operators.Or(o_, 
			q_);
        return context?.Operators.And(j_, 
			r_);
    }
    [CqlDeclaration("Advanced Illness and Frailty Exclusion Not Including Over Age 80")]
    public bool? Advanced_Illness_and_Frailty_Exclusion_Not_Including_Over_Age_80() => __Advanced_Illness_and_Frailty_Exclusion_Not_Including_Over_Age_80.Value;

    private bool? Has_Long_Term_Care_Periods_Longer_Than_90_Consecutive_Days_Value()
    {
        var a_ = (this.Max_Long_Term_Care_Period_Length() as object);
        var b_ = (((int?)90) as object);
        return context?.Operators.Greater(a_, 
			b_);
    }
    [CqlDeclaration("Has Long Term Care Periods Longer Than 90 Consecutive Days")]
    public bool? Has_Long_Term_Care_Periods_Longer_Than_90_Consecutive_Days() => __Has_Long_Term_Care_Periods_Longer_Than_90_Consecutive_Days.Value;

}