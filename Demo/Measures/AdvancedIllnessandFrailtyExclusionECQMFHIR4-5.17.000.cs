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
[System.CodeDom.Compiler.GeneratedCode(".NET Code Generation", "1.0.0.0")]
[CqlLibrary("AdvancedIllnessandFrailtyExclusionECQMFHIR4", "5.17.000")]
public class AdvancedIllnessandFrailtyExclusionECQMFHIR4_5_17_000
{

    public static AdvancedIllnessandFrailtyExclusionECQMFHIR4_5_17_000 Instance { get; }  = new();

    [CqlDeclaration("Acute Inpatient")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1083")]
	public CqlValueSet Acute_Inpatient(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1083", null);

    [CqlDeclaration("Advanced Illness")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.110.12.1082")]
	public CqlValueSet Advanced_Illness(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.110.12.1082", null);

    [CqlDeclaration("Care Services in Long-Term Residential Facility")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1014")]
	public CqlValueSet Care_Services_in_Long_Term_Residential_Facility(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1014", null);

    [CqlDeclaration("Dementia Medications")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.196.12.1510")]
	public CqlValueSet Dementia_Medications(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.196.12.1510", null);

    [CqlDeclaration("Emergency Department Visit")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1010")]
	public CqlValueSet Emergency_Department_Visit(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1010", null);

    [CqlDeclaration("Frailty Device")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.118.12.1300")]
	public CqlValueSet Frailty_Device(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.118.12.1300", null);

    [CqlDeclaration("Frailty Diagnosis")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.113.12.1074")]
	public CqlValueSet Frailty_Diagnosis(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.113.12.1074", null);

    [CqlDeclaration("Frailty Encounter")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1088")]
	public CqlValueSet Frailty_Encounter(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1088", null);

    [CqlDeclaration("Frailty Symptom")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.113.12.1075")]
	public CqlValueSet Frailty_Symptom(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.113.12.1075", null);

    [CqlDeclaration("Nonacute Inpatient")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1084")]
	public CqlValueSet Nonacute_Inpatient(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1084", null);

    [CqlDeclaration("Nursing Facility Visit")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1012")]
	public CqlValueSet Nursing_Facility_Visit(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1012", null);

    [CqlDeclaration("Observation")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1086")]
	public CqlValueSet Observation(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1086", null);

    [CqlDeclaration("Outpatient")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1087")]
	public CqlValueSet Outpatient(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1087", null);

    [CqlDeclaration("Measurement Period")]
	public CqlInterval<CqlDateTime> Measurement_Period(CqlContext context)
	{
		var a_ = context.ResolveParameter("AdvancedIllnessandFrailtyExclusionECQMFHIR4-5.17.000", "Measurement Period", null);

		return (CqlInterval<CqlDateTime>)a_;
	}

    [CqlDeclaration("Patient")]
	public Patient Patient(CqlContext context)
	{
		var a_ = context.Operators.RetrieveByValueSet<Patient>(null, null);
		var b_ = context.Operators.SingleOrNull<Patient>(a_);

		return b_;
	}

    [CqlDeclaration("Dementia Medications In Year Before or During Measurement Period")]
	public IEnumerable<MedicationRequest> Dementia_Medications_In_Year_Before_or_During_Measurement_Period(CqlContext context)
	{
		var a_ = this.Dementia_Medications(context);
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
			var m_ = CumulativeMedicationDurationFHIR4_1_0_000.Instance.MedicationPeriod(context, (DementiaMed as object));
			var n_ = this.Measurement_Period(context);
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

    [CqlDeclaration("Long Term Care Periods During Measurement Period")]
	public IEnumerable<CqlInterval<CqlDateTime>> Long_Term_Care_Periods_During_Measurement_Period(CqlContext context)
	{
		var a_ = this.Care_Services_in_Long_Term_Residential_Facility(context);
		var b_ = context.Operators.RetrieveByValueSet<Encounter>(a_, null);
		var c_ = this.Nursing_Facility_Visit(context);
		var d_ = context.Operators.RetrieveByValueSet<Encounter>(c_, null);
		var e_ = context.Operators.ListUnion<Encounter>(b_, d_);
		bool? f_(Encounter LongTermFacilityEncounter)
		{
			var j_ = context.Operators.Convert<string>(LongTermFacilityEncounter?.StatusElement);
			var k_ = context.Operators.Equal(j_, "finished");
			var l_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, (LongTermFacilityEncounter?.Period as object));
			var m_ = this.Measurement_Period(context);
			var n_ = context.Operators.Overlaps(l_, m_, null);
			var o_ = context.Operators.And(k_, n_);

			return o_;
		};
		var g_ = context.Operators.WhereOrNull<Encounter>(e_, f_);
		CqlInterval<CqlDateTime> h_(Encounter LongTermFacilityEncounter)
		{
			var p_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, (LongTermFacilityEncounter?.Period as object));
			var q_ = this.Measurement_Period(context);
			var r_ = context.Operators.IntervalIntersectsInterval<CqlDateTime>(p_, q_);

			return r_;
		};
		var i_ = context.Operators.SelectOrNull<Encounter, CqlInterval<CqlDateTime>>(g_, h_);

		return i_;
	}

    [CqlDeclaration("Outpatient Encounters with Advanced Illness")]
	public IEnumerable<Encounter> Outpatient_Encounters_with_Advanced_Illness(CqlContext context)
	{
		var a_ = this.Outpatient(context);
		var b_ = context.Operators.RetrieveByValueSet<Encounter>(a_, null);
		var c_ = this.Observation(context);
		var d_ = context.Operators.RetrieveByValueSet<Encounter>(c_, null);
		var e_ = context.Operators.ListUnion<Encounter>(b_, d_);
		var f_ = this.Emergency_Department_Visit(context);
		var g_ = context.Operators.RetrieveByValueSet<Encounter>(f_, null);
		var h_ = this.Nonacute_Inpatient(context);
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
			var r_ = this.Advanced_Illness(context);
			var s_ = context.Operators.RetrieveByValueSet<Condition>(r_, null);
			bool? t_(Condition AdvancedIllnessDiagnosis)
			{
				var x_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.EncounterDiagnosis(context, OutpatientEncounter);
				var y_ = context.Operators.InList<Condition>(AdvancedIllnessDiagnosis, x_);
				var z_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, (OutpatientEncounter?.Period as object));
				var aa_ = context.Operators.Start(z_);
				var ab_ = this.Measurement_Period(context);
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
			var w_ = context.Operators.SelectOrNull<Condition, Encounter>(u_, v_);

			return w_;
		};
		var o_ = context.Operators.SelectManyOrNull<Encounter, Encounter>(m_, n_);

		return o_;
	}

    [CqlDeclaration("Two Outpatient Encounters with Advanced Illness on Different Dates of Service")]
	public IEnumerable<Encounter> Two_Outpatient_Encounters_with_Advanced_Illness_on_Different_Dates_of_Service(CqlContext context)
	{
		var a_ = this.Outpatient_Encounters_with_Advanced_Illness(context);
		IEnumerable<Encounter> b_(Encounter _OutpatientEncounter1)
		{
			var i_ = this.Outpatient_Encounters_with_Advanced_Illness(context);

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
			var k_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, tuple_eykuvmtuwtabihheadhigbsfe.OutpatientEncounter2?.Period);
			var l_ = context.Operators.End(k_);
			var m_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, tuple_eykuvmtuwtabihheadhigbsfe.OutpatientEncounter1?.Period);
			var n_ = context.Operators.End(m_);
			var o_ = context.Operators.Quantity(1m, "day");
			var p_ = context.Operators.Add(n_, o_);
			var q_ = context.Operators.SameOrAfter(l_, p_, "day");

			return q_;
		};
		var f_ = context.Operators.WhereOrNull<Tuples.Tuple_EYKUVMTUWTABihhEAdHIGbSFe>(d_, e_);
		Encounter g_(Tuples.Tuple_EYKUVMTUWTABihhEAdHIGbSFe tuple_eykuvmtuwtabihheadhigbsfe) => 
			tuple_eykuvmtuwtabihheadhigbsfe.OutpatientEncounter1;
		var h_ = context.Operators.SelectOrNull<Tuples.Tuple_EYKUVMTUWTABihhEAdHIGbSFe, Encounter>(f_, g_);

		return h_;
	}

    [CqlDeclaration("Long Term Care Overlapping Periods")]
	public IEnumerable<CqlInterval<CqlDateTime>> Long_Term_Care_Overlapping_Periods(CqlContext context)
	{
		var a_ = this.Long_Term_Care_Periods_During_Measurement_Period(context);
		var b_ = context.Operators.Collapse(a_, null);

		return b_;
	}

    [CqlDeclaration("Long Term Care Adjacent Periods")]
	public IEnumerable<CqlInterval<CqlDateTime>> Long_Term_Care_Adjacent_Periods(CqlContext context)
	{
		var a_ = this.Long_Term_Care_Overlapping_Periods(context);
		IEnumerable<CqlInterval<CqlDateTime>> b_(CqlInterval<CqlDateTime> _LTCPeriod1)
		{
			var i_ = this.Long_Term_Care_Overlapping_Periods(context);

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

    [CqlDeclaration("Max Long Term Care Period Length")]
	public int? Max_Long_Term_Care_Period_Length(CqlContext context)
	{
		var a_ = this.Long_Term_Care_Overlapping_Periods(context);
		var b_ = this.Long_Term_Care_Adjacent_Periods(context);
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

    [CqlDeclaration("Inpatient Encounter with Advanced Illness")]
	public IEnumerable<Encounter> Inpatient_Encounter_with_Advanced_Illness(CqlContext context)
	{
		var a_ = this.Acute_Inpatient(context);
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
			var i_ = this.Advanced_Illness(context);
			var j_ = context.Operators.RetrieveByValueSet<Condition>(i_, null);
			bool? k_(Condition AdvancedIllnessDiagnosis)
			{
				var o_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.EncounterDiagnosis(context, InpatientEncounter);
				var p_ = context.Operators.InList<Condition>(AdvancedIllnessDiagnosis, o_);
				var q_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, (InpatientEncounter?.Period as object));
				var r_ = context.Operators.Start(q_);
				var s_ = this.Measurement_Period(context);
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
			var n_ = context.Operators.SelectOrNull<Condition, Encounter>(l_, m_);

			return n_;
		};
		var f_ = context.Operators.SelectManyOrNull<Encounter, Encounter>(d_, e_);

		return f_;
	}

    [CqlDeclaration("Has Criteria Indicating Frailty")]
	public bool? Has_Criteria_Indicating_Frailty(CqlContext context)
	{
		var a_ = this.Frailty_Device(context);
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
			var am_ = this.Measurement_Period(context);
			var an_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, (FrailtyDeviceOrder?.AuthoredOnElement as object));
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
			var at_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, FrailtyDeviceApplied?.Effective);
			var au_ = this.Measurement_Period(context);
			var av_ = context.Operators.Overlaps(at_, au_, null);
			var aw_ = context.Operators.And(as_, av_);

			return aw_;
		};
		var l_ = context.Operators.WhereOrNull<Observation>(j_, k_);
		var m_ = context.Operators.ExistsInList<Observation>(l_);
		var n_ = context.Operators.Or(h_, m_);
		var o_ = this.Frailty_Diagnosis(context);
		var p_ = context.Operators.RetrieveByValueSet<Condition>(o_, null);
		bool? q_(Condition FrailtyDiagnosis)
		{
			var ax_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Prevalence_Period(context, FrailtyDiagnosis);
			var ay_ = this.Measurement_Period(context);
			var az_ = context.Operators.Overlaps(ax_, ay_, null);

			return az_;
		};
		var r_ = context.Operators.WhereOrNull<Condition>(p_, q_);
		var s_ = context.Operators.ExistsInList<Condition>(r_);
		var t_ = context.Operators.Or(n_, s_);
		var u_ = this.Frailty_Encounter(context);
		var v_ = context.Operators.RetrieveByValueSet<Encounter>(u_, null);
		bool? w_(Encounter FrailtyEncounter)
		{
			var ba_ = context.Operators.Convert<string>(FrailtyEncounter?.StatusElement);
			var bb_ = context.Operators.Equal(ba_, "finished");
			var bc_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, (FrailtyEncounter?.Period as object));
			var bd_ = this.Measurement_Period(context);
			var be_ = context.Operators.Overlaps(bc_, bd_, null);
			var bf_ = context.Operators.And(bb_, be_);

			return bf_;
		};
		var x_ = context.Operators.WhereOrNull<Encounter>(v_, w_);
		var y_ = context.Operators.ExistsInList<Encounter>(x_);
		var z_ = context.Operators.Or(t_, y_);
		var aa_ = this.Frailty_Symptom(context);
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
			var bj_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, FrailtySymptom?.Effective);
			var bk_ = this.Measurement_Period(context);
			var bl_ = context.Operators.Overlaps(bj_, bk_, null);
			var bm_ = context.Operators.And(bi_, bl_);

			return bm_;
		};
		var ad_ = context.Operators.WhereOrNull<Observation>(ab_, ac_);
		var ae_ = context.Operators.ExistsInList<Observation>(ad_);
		var af_ = context.Operators.Or(z_, ae_);

		return af_;
	}

    [CqlDeclaration("Advanced Illness and Frailty Exclusion Including Over Age 80")]
	public bool? Advanced_Illness_and_Frailty_Exclusion_Including_Over_Age_80(CqlContext context)
	{
		var a_ = this.Patient(context);
		var b_ = context.Operators.Convert<CqlDate>(a_?.BirthDateElement?.Value);
		var c_ = this.Measurement_Period(context);
		var d_ = context.Operators.Start(c_);
		var e_ = context.Operators.DateFrom(d_);
		var f_ = context.Operators.CalculateAgeAt(b_, e_, "year");
		var g_ = context.Operators.Interval((int?)65, (int?)79, true, true);
		var h_ = context.Operators.ElementInInterval<int?>(f_, g_, null);
		var i_ = this.Has_Criteria_Indicating_Frailty(context);
		var j_ = context.Operators.And(h_, i_);
		var k_ = this.Two_Outpatient_Encounters_with_Advanced_Illness_on_Different_Dates_of_Service(context);
		var l_ = context.Operators.ExistsInList<Encounter>(k_);
		var m_ = this.Inpatient_Encounter_with_Advanced_Illness(context);
		var n_ = context.Operators.ExistsInList<Encounter>(m_);
		var o_ = context.Operators.Or(l_, n_);
		var p_ = this.Dementia_Medications_In_Year_Before_or_During_Measurement_Period(context);
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

    [CqlDeclaration("Advanced Illness and Frailty Exclusion Not Including Over Age 80")]
	public bool? Advanced_Illness_and_Frailty_Exclusion_Not_Including_Over_Age_80(CqlContext context)
	{
		var a_ = this.Patient(context);
		var b_ = context.Operators.Convert<CqlDate>(a_?.BirthDateElement?.Value);
		var c_ = this.Measurement_Period(context);
		var d_ = context.Operators.Start(c_);
		var e_ = context.Operators.DateFrom(d_);
		var f_ = context.Operators.CalculateAgeAt(b_, e_, "year");
		var g_ = context.Operators.GreaterOrEqual(f_, (int?)65);
		var h_ = this.Has_Criteria_Indicating_Frailty(context);
		var i_ = context.Operators.And(g_, h_);
		var j_ = this.Two_Outpatient_Encounters_with_Advanced_Illness_on_Different_Dates_of_Service(context);
		var k_ = context.Operators.ExistsInList<Encounter>(j_);
		var l_ = this.Inpatient_Encounter_with_Advanced_Illness(context);
		var m_ = context.Operators.ExistsInList<Encounter>(l_);
		var n_ = context.Operators.Or(k_, m_);
		var o_ = this.Dementia_Medications_In_Year_Before_or_During_Measurement_Period(context);
		var p_ = context.Operators.ExistsInList<MedicationRequest>(o_);
		var q_ = context.Operators.Or(n_, p_);
		var r_ = context.Operators.And(i_, q_);

		return r_;
	}

    [CqlDeclaration("Has Long Term Care Periods Longer Than 90 Consecutive Days")]
	public bool? Has_Long_Term_Care_Periods_Longer_Than_90_Consecutive_Days(CqlContext context)
	{
		var a_ = this.Max_Long_Term_Care_Period_Length(context);
		var b_ = context.Operators.Greater(a_, (int?)90);

		return b_;
	}

}