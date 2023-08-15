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
        var b_ = typeof(MedicationRequest).GetProperty("Medication");
        var c_ = context?.DataRetriever.RetrieveByValueSet<MedicationRequest>(a_, 
			b_);
        var g_ = context?.Operators.ListUnion<MedicationRequest>(c_, 
			c_);
        Func<MedicationRequest,bool?> aa_ = (DementiaMed) => 
        {
            var i_ = (DementiaMed?.StatusElement as object);
            var h_ = ((context.Deeper(new CallStackEntry("ToString", 
		null, 
		null))?.Operators?.TypeConverter).Convert<string>(i_) as object);
            var j_ = ("active" as object);
            var k_ = context?.Operators.Equal(h_, 
				j_);
            var m_ = (DementiaMed?.IntentElement as object);
            var l_ = ((context.Deeper(new CallStackEntry("ToString", 
		null, 
		null))?.Operators?.TypeConverter).Convert<string>(m_) as object);
            var n_ = ("order" as object);
            var o_ = context?.Operators.Equal(l_, 
				n_);
            var p_ = context?.Operators.And(k_, 
				o_);
            var q_ = (DementiaMed as object);
            var r_ = CumulativeMedicationDurationFHIR4_1_0_000.MedicationPeriod(q_);
            var s_ = this.Measurement_Period();
            var t_ = context?.Operators.Start(s_);
            var u_ = context?.Operators.Quantity(1m, 
				"year");
            var v_ = context?.Operators.Subtract(t_, 
				u_);
            var x_ = context?.Operators.End(s_);
            var y_ = context?.Operators.Interval(v_, 
				x_, 
				true, 
				true);
            var z_ = context?.Operators.Overlaps(r_, 
				y_, 
				null);
            return context?.Operators.And(p_, 
				z_);
        };
        return context?.Operators.WhereOrNull<MedicationRequest>(g_, 
			aa_);
    }
    [CqlDeclaration("Dementia Medications In Year Before or During Measurement Period")]
    public IEnumerable<MedicationRequest> Dementia_Medications_In_Year_Before_or_During_Measurement_Period() => __Dementia_Medications_In_Year_Before_or_During_Measurement_Period.Value;

    private IEnumerable<CqlInterval<CqlDateTime>> Long_Term_Care_Periods_During_Measurement_Period_Value()
    {
        var a_ = this.Care_Services_in_Long_Term_Residential_Facility();
        var b_ = typeof(Encounter).GetProperty("Type");
        var c_ = context?.DataRetriever.RetrieveByValueSet<Encounter>(a_, 
			b_);
        var d_ = this.Nursing_Facility_Visit();
        var f_ = context?.DataRetriever.RetrieveByValueSet<Encounter>(d_, 
			b_);
        var g_ = context?.Operators.ListUnion<Encounter>(c_, 
			f_);
        Func<Encounter,bool?> p_ = (LongTermFacilityEncounter) => 
        {
            var i_ = (LongTermFacilityEncounter?.StatusElement as object);
            var h_ = ((context.Deeper(new CallStackEntry("ToString", 
		null, 
		null))?.Operators?.TypeConverter).Convert<string>(i_) as object);
            var j_ = ("finished" as object);
            var k_ = context?.Operators.Equal(h_, 
				j_);
            var l_ = (LongTermFacilityEncounter?.Period as object);
            var m_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Normalize_Interval(l_);
            var n_ = this.Measurement_Period();
            var o_ = context?.Operators.Overlaps(m_, 
				n_, 
				null);
            return context?.Operators.And(k_, 
				o_);
        };
        var q_ = context?.Operators.WhereOrNull<Encounter>(g_, 
			p_);
        Func<Encounter,CqlInterval<CqlDateTime>> u_ = (LongTermFacilityEncounter) => 
        {
            var r_ = (LongTermFacilityEncounter?.Period as object);
            var s_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Normalize_Interval(r_);
            var t_ = this.Measurement_Period();
            return context?.Operators.IntervalIntersectsInterval<CqlDateTime>(s_, 
				t_);
        };
        return context?.Operators.SelectOrNull<Encounter, CqlInterval<CqlDateTime>>(q_, 
			u_);
    }
    [CqlDeclaration("Long Term Care Periods During Measurement Period")]
    public IEnumerable<CqlInterval<CqlDateTime>> Long_Term_Care_Periods_During_Measurement_Period() => __Long_Term_Care_Periods_During_Measurement_Period.Value;

    private IEnumerable<Encounter> Outpatient_Encounters_with_Advanced_Illness_Value()
    {
        var a_ = this.Outpatient();
        var b_ = typeof(Encounter).GetProperty("Type");
        var c_ = context?.DataRetriever.RetrieveByValueSet<Encounter>(a_, 
			b_);
        var d_ = this.Observation();
        var f_ = context?.DataRetriever.RetrieveByValueSet<Encounter>(d_, 
			b_);
        var g_ = context?.Operators.ListUnion<Encounter>(c_, 
			f_);
        var h_ = this.Emergency_Department_Visit();
        var j_ = context?.DataRetriever.RetrieveByValueSet<Encounter>(h_, 
			b_);
        var k_ = this.Nonacute_Inpatient();
        var m_ = context?.DataRetriever.RetrieveByValueSet<Encounter>(k_, 
			b_);
        var n_ = context?.Operators.ListUnion<Encounter>(j_, 
			m_);
        var o_ = context?.Operators.ListUnion<Encounter>(g_, 
			n_);
        Func<Encounter,bool?> s_ = (Outpatient) => 
        {
            var q_ = (Outpatient?.StatusElement as object);
            var p_ = ((context.Deeper(new CallStackEntry("ToString", 
		null, 
		null))?.Operators?.TypeConverter).Convert<string>(q_) as object);
            var r_ = ("finished" as object);
            return context?.Operators.Equal(p_, 
				r_);
        };
        var t_ = context?.Operators.WhereOrNull<Encounter>(o_, 
			s_);
        Func<Encounter,IEnumerable<Encounter>> ar_ = (OutpatientEncounter) => 
        {
            var u_ = this.Advanced_Illness();
            var v_ = typeof(Condition).GetProperty("Code");
            var w_ = context?.DataRetriever.RetrieveByValueSet<Condition>(u_, 
				v_);
            Func<Condition,bool?> ao_ = (AdvancedIllnessDiagnosis) => 
            {
                var x_ = MATGlobalCommonFunctionsFHIR4_6_1_000.EncounterDiagnosis(OutpatientEncounter);
                var y_ = context?.Operators.InList<Condition>(AdvancedIllnessDiagnosis, 
					x_);
                var z_ = (OutpatientEncounter?.Period as object);
                var aa_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Normalize_Interval(z_);
                var ab_ = context?.Operators.Start(aa_);
                var ac_ = this.Measurement_Period();
                var ad_ = context?.Operators.End(ac_);
                var ae_ = context?.Operators.Quantity(2m, 
					"years");
                var af_ = context?.Operators.Subtract(ad_, 
					ae_);
                var ai_ = context?.Operators.Interval(af_, 
					ad_, 
					true, 
					true);
                var aj_ = context?.Operators.ElementInInterval<CqlDateTime>(ab_, 
					ai_, 
					null);
                bool? ak_ = ((bool?)(context?.Operators.End(ac_) == null));
                var am_ = context?.Operators.Not(ak_);
                var an_ = context?.Operators.And(aj_, 
					am_);
                return context?.Operators.And(y_, 
					an_);
            };
            var ap_ = context?.Operators.WhereOrNull<Condition>(w_, 
				ao_);
            Func<Condition,Encounter> aq_ = (AdvancedIllnessDiagnosis) => OutpatientEncounter;
            return context?.Operators.SelectOrNull<Condition, Encounter>(ap_, 
				aq_);
        };
        return context?.Operators.SelectManyOrNull<Encounter, Encounter>(t_, 
			ar_);
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
        var b_ = typeof(Encounter).GetProperty("Type");
        var c_ = context?.DataRetriever.RetrieveByValueSet<Encounter>(a_, 
			b_);
        Func<Encounter,bool?> g_ = (AcuteInpatient) => 
        {
            var e_ = (AcuteInpatient?.StatusElement as object);
            var d_ = ((context.Deeper(new CallStackEntry("ToString", 
		null, 
		null))?.Operators?.TypeConverter).Convert<string>(e_) as object);
            var f_ = ("finished" as object);
            return context?.Operators.Equal(d_, 
				f_);
        };
        var h_ = context?.Operators.WhereOrNull<Encounter>(c_, 
			g_);
        Func<Encounter,IEnumerable<Encounter>> af_ = (InpatientEncounter) => 
        {
            var i_ = this.Advanced_Illness();
            var j_ = typeof(Condition).GetProperty("Code");
            var k_ = context?.DataRetriever.RetrieveByValueSet<Condition>(i_, 
				j_);
            Func<Condition,bool?> ac_ = (AdvancedIllnessDiagnosis) => 
            {
                var l_ = MATGlobalCommonFunctionsFHIR4_6_1_000.EncounterDiagnosis(InpatientEncounter);
                var m_ = context?.Operators.InList<Condition>(AdvancedIllnessDiagnosis, 
					l_);
                var n_ = (InpatientEncounter?.Period as object);
                var o_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Normalize_Interval(n_);
                var p_ = context?.Operators.Start(o_);
                var q_ = this.Measurement_Period();
                var r_ = context?.Operators.End(q_);
                var s_ = context?.Operators.Quantity(2m, 
					"years");
                var t_ = context?.Operators.Subtract(r_, 
					s_);
                var w_ = context?.Operators.Interval(t_, 
					r_, 
					true, 
					true);
                var x_ = context?.Operators.ElementInInterval<CqlDateTime>(p_, 
					w_, 
					null);
                bool? y_ = ((bool?)(context?.Operators.End(q_) == null));
                var aa_ = context?.Operators.Not(y_);
                var ab_ = context?.Operators.And(x_, 
					aa_);
                return context?.Operators.And(m_, 
					ab_);
            };
            var ad_ = context?.Operators.WhereOrNull<Condition>(k_, 
				ac_);
            Func<Condition,Encounter> ae_ = (AdvancedIllnessDiagnosis) => InpatientEncounter;
            return context?.Operators.SelectOrNull<Condition, Encounter>(ad_, 
				ae_);
        };
        return context?.Operators.SelectManyOrNull<Encounter, Encounter>(h_, 
			af_);
    }
    [CqlDeclaration("Inpatient Encounter with Advanced Illness")]
    public IEnumerable<Encounter> Inpatient_Encounter_with_Advanced_Illness() => __Inpatient_Encounter_with_Advanced_Illness.Value;

    private bool? Has_Criteria_Indicating_Frailty_Value()
    {
        var a_ = this.Frailty_Device();
        var b_ = typeof(DeviceRequest).GetProperty("Code");
        var c_ = context?.DataRetriever.RetrieveByValueSet<DeviceRequest>(a_, 
			b_);
        var g_ = context?.Operators.ListUnion<DeviceRequest>(c_, 
			c_);
        Func<DeviceRequest,bool?> x_ = (FrailtyDeviceOrder) => 
        {
            var h_ = (FrailtyDeviceOrder?.StatusElement as object);
            var i_ = (context.Deeper(new CallStackEntry("ToString", 
		null, 
		null))?.Operators?.TypeConverter).Convert<string>(h_);
            var k_ = "active";
            var l_ = "on-hold";
            var m_ = "completed";
            var j_ = (new string[]
			{
				k_,
				l_,
				m_,
			} as IEnumerable<string>);
            var n_ = context?.Operators.InList<string>(i_, 
				j_);
            var p_ = (FrailtyDeviceOrder?.IntentElement as object);
            var o_ = ((context.Deeper(new CallStackEntry("ToString", 
		null, 
		null))?.Operators?.TypeConverter).Convert<string>(p_) as object);
            var q_ = ("order" as object);
            var r_ = context?.Operators.Equal(o_, 
				q_);
            var s_ = context?.Operators.And(n_, 
				r_);
            var t_ = this.Measurement_Period();
            var u_ = (FrailtyDeviceOrder?.AuthoredOnElement as object);
            var v_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Normalize_Interval(u_);
            var w_ = context?.Operators.IntervalIncludesInterval<CqlDateTime>(t_, 
				v_, 
				null);
            return context?.Operators.And(s_, 
				w_);
        };
        var y_ = context?.Operators.WhereOrNull<DeviceRequest>(g_, 
			x_);
        var z_ = context?.Operators.ExistsInList<DeviceRequest>(y_);
        var ab_ = typeof(Observation).GetProperty("Code");
        var ac_ = context?.DataRetriever.RetrieveByValueSet<Observation>(a_, 
			ab_);
        Func<Observation,bool?> ao_ = (FrailtyDeviceApplied) => 
        {
            var ad_ = (FrailtyDeviceApplied?.StatusElement as object);
            var ae_ = (context.Deeper(new CallStackEntry("ToString", 
		null, 
		null))?.Operators?.TypeConverter).Convert<string>(ad_);
            var ag_ = "final";
            var ah_ = "amended";
            var ai_ = "corrected";
            var af_ = (new string[]
			{
				ag_,
				ah_,
				ai_,
			} as IEnumerable<string>);
            var aj_ = context?.Operators.InList<string>(ae_, 
				af_);
            var ak_ = (FrailtyDeviceApplied?.Effective as object);
            var al_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Normalize_Interval(ak_);
            var am_ = this.Measurement_Period();
            var an_ = context?.Operators.Overlaps(al_, 
				am_, 
				null);
            return context?.Operators.And(aj_, 
				an_);
        };
        var ap_ = context?.Operators.WhereOrNull<Observation>(ac_, 
			ao_);
        var aq_ = context?.Operators.ExistsInList<Observation>(ap_);
        var ar_ = context?.Operators.Or(z_, 
			aq_);
        var as_ = this.Frailty_Diagnosis();
        var at_ = typeof(Condition).GetProperty("Code");
        var au_ = context?.DataRetriever.RetrieveByValueSet<Condition>(as_, 
			at_);
        Func<Condition,bool?> ax_ = (FrailtyDiagnosis) => 
        {
            var av_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Prevalence_Period(FrailtyDiagnosis);
            var aw_ = this.Measurement_Period();
            return context?.Operators.Overlaps(av_, 
				aw_, 
				null);
        };
        var ay_ = context?.Operators.WhereOrNull<Condition>(au_, 
			ax_);
        var az_ = context?.Operators.ExistsInList<Condition>(ay_);
        var ba_ = context?.Operators.Or(ar_, 
			az_);
        var bb_ = this.Frailty_Encounter();
        var bc_ = typeof(Encounter).GetProperty("Type");
        var bd_ = context?.DataRetriever.RetrieveByValueSet<Encounter>(bb_, 
			bc_);
        Func<Encounter,bool?> bm_ = (FrailtyEncounter) => 
        {
            var bf_ = (FrailtyEncounter?.StatusElement as object);
            var be_ = ((context.Deeper(new CallStackEntry("ToString", 
		null, 
		null))?.Operators?.TypeConverter).Convert<string>(bf_) as object);
            var bg_ = ("finished" as object);
            var bh_ = context?.Operators.Equal(be_, 
				bg_);
            var bi_ = (FrailtyEncounter?.Period as object);
            var bj_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Normalize_Interval(bi_);
            var bk_ = this.Measurement_Period();
            var bl_ = context?.Operators.Overlaps(bj_, 
				bk_, 
				null);
            return context?.Operators.And(bh_, 
				bl_);
        };
        var bn_ = context?.Operators.WhereOrNull<Encounter>(bd_, 
			bm_);
        var bo_ = context?.Operators.ExistsInList<Encounter>(bn_);
        var bp_ = context?.Operators.Or(ba_, 
			bo_);
        var bq_ = this.Frailty_Symptom();
        var bs_ = context?.DataRetriever.RetrieveByValueSet<Observation>(bq_, 
			ab_);
        Func<Observation,bool?> cf_ = (FrailtySymptom) => 
        {
            var bt_ = (FrailtySymptom?.StatusElement as object);
            var bu_ = (context.Deeper(new CallStackEntry("ToString", 
		null, 
		null))?.Operators?.TypeConverter).Convert<string>(bt_);
            var bw_ = "preliminary";
            var bx_ = "final";
            var by_ = "amended";
            var bz_ = "corrected";
            var bv_ = (new string[]
			{
				bw_,
				bx_,
				by_,
				bz_,
			} as IEnumerable<string>);
            var ca_ = context?.Operators.InList<string>(bu_, 
				bv_);
            var cb_ = (FrailtySymptom?.Effective as object);
            var cc_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Normalize_Interval(cb_);
            var cd_ = this.Measurement_Period();
            var ce_ = context?.Operators.Overlaps(cc_, 
				cd_, 
				null);
            return context?.Operators.And(ca_, 
				ce_);
        };
        var cg_ = context?.Operators.WhereOrNull<Observation>(bs_, 
			cf_);
        var ch_ = context?.Operators.ExistsInList<Observation>(cg_);
        return context?.Operators.Or(bp_, 
			ch_);
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