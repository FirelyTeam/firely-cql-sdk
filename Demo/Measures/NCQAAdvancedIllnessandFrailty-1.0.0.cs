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
[CqlLibrary("NCQAAdvancedIllnessandFrailty", "1.0.0")]
public class NCQAAdvancedIllnessandFrailty_1_0_0
{

    public static NCQAAdvancedIllnessandFrailty_1_0_0 Instance { get; }  = new();

    [CqlDeclaration("Acute Inpatient")]
    [CqlValueSet("https://www.ncqa.org/fhir/valueset/2.16.840.1.113883.3.464.1004.1810")]
	public CqlValueSet Acute_Inpatient(CqlContext context) => 
		new CqlValueSet("https://www.ncqa.org/fhir/valueset/2.16.840.1.113883.3.464.1004.1810", null);

    [CqlDeclaration("Advanced Illness")]
    [CqlValueSet("https://www.ncqa.org/fhir/valueset/2.16.840.1.113883.3.464.1004.1465")]
	public CqlValueSet Advanced_Illness(CqlContext context) => 
		new CqlValueSet("https://www.ncqa.org/fhir/valueset/2.16.840.1.113883.3.464.1004.1465", null);

    [CqlDeclaration("Dementia Medications")]
    [CqlValueSet("https://www.ncqa.org/fhir/valueset/2.16.840.1.113883.3.464.1004.1729")]
	public CqlValueSet Dementia_Medications(CqlContext context) => 
		new CqlValueSet("https://www.ncqa.org/fhir/valueset/2.16.840.1.113883.3.464.1004.1729", null);

    [CqlDeclaration("ED")]
    [CqlValueSet("https://www.ncqa.org/fhir/valueset/2.16.840.1.113883.3.464.1004.1086")]
	public CqlValueSet ED(CqlContext context) => 
		new CqlValueSet("https://www.ncqa.org/fhir/valueset/2.16.840.1.113883.3.464.1004.1086", null);

    [CqlDeclaration("Frailty Device")]
    [CqlValueSet("https://www.ncqa.org/fhir/valueset/2.16.840.1.113883.3.464.1004.1530")]
	public CqlValueSet Frailty_Device(CqlContext context) => 
		new CqlValueSet("https://www.ncqa.org/fhir/valueset/2.16.840.1.113883.3.464.1004.1530", null);

    [CqlDeclaration("Frailty Diagnosis")]
    [CqlValueSet("https://www.ncqa.org/fhir/valueset/2.16.840.1.113883.3.464.1004.1531")]
	public CqlValueSet Frailty_Diagnosis(CqlContext context) => 
		new CqlValueSet("https://www.ncqa.org/fhir/valueset/2.16.840.1.113883.3.464.1004.1531", null);

    [CqlDeclaration("Frailty Encounter")]
    [CqlValueSet("https://www.ncqa.org/fhir/valueset/2.16.840.1.113883.3.464.1004.1532")]
	public CqlValueSet Frailty_Encounter(CqlContext context) => 
		new CqlValueSet("https://www.ncqa.org/fhir/valueset/2.16.840.1.113883.3.464.1004.1532", null);

    [CqlDeclaration("Frailty Symptom")]
    [CqlValueSet("https://www.ncqa.org/fhir/valueset/2.16.840.1.113883.3.464.1004.1533")]
	public CqlValueSet Frailty_Symptom(CqlContext context) => 
		new CqlValueSet("https://www.ncqa.org/fhir/valueset/2.16.840.1.113883.3.464.1004.1533", null);

    [CqlDeclaration("Nonacute Inpatient")]
    [CqlValueSet("https://www.ncqa.org/fhir/valueset/2.16.840.1.113883.3.464.1004.1189")]
	public CqlValueSet Nonacute_Inpatient(CqlContext context) => 
		new CqlValueSet("https://www.ncqa.org/fhir/valueset/2.16.840.1.113883.3.464.1004.1189", null);

    [CqlDeclaration("Observation")]
    [CqlValueSet("https://www.ncqa.org/fhir/valueset/2.16.840.1.113883.3.464.1004.1191")]
	public CqlValueSet Observation(CqlContext context) => 
		new CqlValueSet("https://www.ncqa.org/fhir/valueset/2.16.840.1.113883.3.464.1004.1191", null);

    [CqlDeclaration("Online Assessments")]
    [CqlValueSet("https://www.ncqa.org/fhir/valueset/2.16.840.1.113883.3.464.1004.1446")]
	public CqlValueSet Online_Assessments(CqlContext context) => 
		new CqlValueSet("https://www.ncqa.org/fhir/valueset/2.16.840.1.113883.3.464.1004.1446", null);

    [CqlDeclaration("Outpatient")]
    [CqlValueSet("https://www.ncqa.org/fhir/valueset/2.16.840.1.113883.3.464.1004.1202")]
	public CqlValueSet Outpatient(CqlContext context) => 
		new CqlValueSet("https://www.ncqa.org/fhir/valueset/2.16.840.1.113883.3.464.1004.1202", null);

    [CqlDeclaration("Telephone Visits")]
    [CqlValueSet("https://www.ncqa.org/fhir/valueset/2.16.840.1.113883.3.464.1004.1246")]
	public CqlValueSet Telephone_Visits(CqlContext context) => 
		new CqlValueSet("https://www.ncqa.org/fhir/valueset/2.16.840.1.113883.3.464.1004.1246", null);

    [CqlDeclaration("Measurement Period")]
	public CqlInterval<CqlDateTime> Measurement_Period(CqlContext context)
	{
		var a_ = context.ResolveParameter("NCQAAdvancedIllnessandFrailty-1.0.0", "Measurement Period", null);

		return (CqlInterval<CqlDateTime>)a_;
	}

    [CqlDeclaration("Patient")]
	public Patient Patient(CqlContext context)
	{
		var a_ = context.Operators.RetrieveByValueSet<Patient>(null, null);
		var b_ = context.Operators.SingleOrNull<Patient>(a_);

		return b_;
	}

    [CqlDeclaration("Has Criteria Indicating Frailty")]
	public bool? Has_Criteria_Indicating_Frailty(CqlContext context)
	{
		var a_ = this.Frailty_Device(context);
		var b_ = context.Operators.RetrieveByValueSet<Observation>(a_, null);
		bool? c_(Observation FrailtyDeviceApplied)
		{
			var z_ = NCQAFHIRBase_1_0_0.Instance.Normalize_Interval(context, FrailtyDeviceApplied?.Effective);
			var aa_ = this.Measurement_Period(context);
			var ab_ = context.Operators.Overlaps(z_, aa_, null);

			return ab_;
		};
		var d_ = context.Operators.WhereOrNull<Observation>(b_, c_);
		var e_ = context.Operators.ExistsInList<Observation>(d_);
		var f_ = this.Frailty_Diagnosis(context);
		var g_ = context.Operators.RetrieveByValueSet<Condition>(f_, null);
		var h_ = NCQAStatus_1_0_0.Instance.Active_Condition(context, g_);
		bool? i_(Condition FrailtyDiagnosis)
		{
			var ac_ = NCQAFHIRBase_1_0_0.Instance.Prevalence_Period(context, FrailtyDiagnosis);
			var ad_ = this.Measurement_Period(context);
			var ae_ = context.Operators.Overlaps(ac_, ad_, null);

			return ae_;
		};
		var j_ = context.Operators.WhereOrNull<Condition>(h_, i_);
		var k_ = context.Operators.ExistsInList<Condition>(j_);
		var l_ = context.Operators.Or(e_, k_);
		var m_ = this.Frailty_Encounter(context);
		var n_ = context.Operators.RetrieveByValueSet<Encounter>(m_, null);
		var o_ = NCQAStatus_1_0_0.Instance.Finished_Encounter(context, n_);
		bool? p_(Encounter FrailtyEncounter)
		{
			var af_ = NCQAFHIRBase_1_0_0.Instance.Normalize_Interval(context, (FrailtyEncounter?.Period as object));
			var ag_ = this.Measurement_Period(context);
			var ah_ = context.Operators.Overlaps(af_, ag_, null);

			return ah_;
		};
		var q_ = context.Operators.WhereOrNull<Encounter>(o_, p_);
		var r_ = context.Operators.ExistsInList<Encounter>(q_);
		var s_ = context.Operators.Or(l_, r_);
		var t_ = this.Frailty_Symptom(context);
		var u_ = context.Operators.RetrieveByValueSet<Observation>(t_, null);
		bool? v_(Observation FrailtySymptom)
		{
			var ai_ = NCQAFHIRBase_1_0_0.Instance.Normalize_Interval(context, FrailtySymptom?.Effective);
			var aj_ = this.Measurement_Period(context);
			var ak_ = context.Operators.Overlaps(ai_, aj_, null);

			return ak_;
		};
		var w_ = context.Operators.WhereOrNull<Observation>(u_, v_);
		var x_ = context.Operators.ExistsInList<Observation>(w_);
		var y_ = context.Operators.Or(s_, x_);

		return y_;
	}

    [CqlDeclaration("Outpatient Encounters with Advanced Illness")]
	public IEnumerable<CqlDate> Outpatient_Encounters_with_Advanced_Illness(CqlContext context)
	{
		var a_ = this.Outpatient(context);
		var b_ = context.Operators.RetrieveByValueSet<Encounter>(a_, null);
		var c_ = this.Observation(context);
		var d_ = context.Operators.RetrieveByValueSet<Encounter>(c_, null);
		var e_ = context.Operators.ListUnion<Encounter>(b_, d_);
		var f_ = this.ED(context);
		var g_ = context.Operators.RetrieveByValueSet<Encounter>(f_, null);
		var h_ = this.Telephone_Visits(context);
		var i_ = context.Operators.RetrieveByValueSet<Encounter>(h_, null);
		var j_ = context.Operators.ListUnion<Encounter>(g_, i_);
		var k_ = context.Operators.ListUnion<Encounter>(e_, j_);
		var l_ = this.Online_Assessments(context);
		var m_ = context.Operators.RetrieveByValueSet<Encounter>(l_, null);
		var n_ = this.Nonacute_Inpatient(context);
		var o_ = context.Operators.RetrieveByValueSet<Encounter>(n_, null);
		var p_ = context.Operators.ListUnion<Encounter>(m_, o_);
		var q_ = context.Operators.ListUnion<Encounter>(k_, p_);
		var r_ = NCQAStatus_1_0_0.Instance.Finished_Encounter(context, q_);
		bool? s_(Encounter OutpatientEncounter)
		{
			var w_ = this.Advanced_Illness(context);
			var x_ = context.Operators.RetrieveByValueSet<Condition>(w_, null);
			var y_ = NCQAEncounter_1_0_0.Instance.Encounter_Has_Diagnosis(context, OutpatientEncounter, x_);
			var z_ = NCQAFHIRBase_1_0_0.Instance.Normalize_Interval(context, (OutpatientEncounter?.Period as object));
			var aa_ = context.Operators.Start(z_);
			var ab_ = context.Operators.DateFrom(aa_);
			var ac_ = this.Measurement_Period(context);
			var ad_ = context.Operators.Start(ac_);
			var ae_ = context.Operators.DateFrom(ad_);
			var af_ = context.Operators.Quantity(1m, "year");
			var ag_ = context.Operators.Subtract(ae_, af_);
			var ai_ = context.Operators.End(ac_);
			var aj_ = context.Operators.DateFrom(ai_);
			var ak_ = context.Operators.Interval(ag_, aj_, true, true);
			var al_ = context.Operators.ElementInInterval<CqlDate>(ab_, ak_, null);
			var am_ = context.Operators.And(y_, al_);

			return am_;
		};
		var t_ = context.Operators.WhereOrNull<Encounter>(r_, s_);
		CqlDate u_(Encounter EncounterWithDiagnosis)
		{
			var an_ = NCQAFHIRBase_1_0_0.Instance.Normalize_Interval(context, (EncounterWithDiagnosis?.Period as object));
			var ao_ = context.Operators.End(an_);
			var ap_ = context.Operators.DateFrom(ao_);

			return ap_;
		};
		var v_ = context.Operators.SelectOrNull<Encounter, CqlDate>(t_, u_);

		return v_;
	}

    [CqlDeclaration("Nonacute Inpatient Discharge with Advanced Illness")]
	public IEnumerable<CqlDate> Nonacute_Inpatient_Discharge_with_Advanced_Illness(CqlContext context)
	{
		var a_ = context.Operators.RetrieveByValueSet<Claim>(null, null);
		var b_ = NCQAClaims_1_0_0.Instance.Medical_Claims_With_Nonacute_or_Acute_Inpatient_Discharge(context, a_);
		var c_ = this.Advanced_Illness(context);
		var d_ = context.Operators.CreateValueSetFacade(c_);
		var e_ = NCQAClaims_1_0_0.Instance.Medical_Claims_With_Diagnosis(context, b_?.NonacuteInpatientDischarge, d_);
		bool? f_(CqlInterval<CqlDateTime> DischargeWithDiagnosis)
		{
			var j_ = context.Operators.End(DischargeWithDiagnosis);
			var k_ = context.Operators.DateFrom(j_);
			var l_ = this.Measurement_Period(context);
			var m_ = context.Operators.Start(l_);
			var n_ = context.Operators.DateFrom(m_);
			var o_ = context.Operators.Quantity(1m, "year");
			var p_ = context.Operators.Subtract(n_, o_);
			var r_ = context.Operators.End(l_);
			var s_ = context.Operators.DateFrom(r_);
			var t_ = context.Operators.Interval(p_, s_, true, true);
			var u_ = context.Operators.ElementInInterval<CqlDate>(k_, t_, null);

			return u_;
		};
		var g_ = context.Operators.WhereOrNull<CqlInterval<CqlDateTime>>(e_?.ServicePeriod, f_);
		CqlDate h_(CqlInterval<CqlDateTime> InpatientDischarge)
		{
			var v_ = context.Operators.End(InpatientDischarge);
			var w_ = context.Operators.DateFrom(v_);

			return w_;
		};
		var i_ = context.Operators.SelectOrNull<CqlInterval<CqlDateTime>, CqlDate>(g_, h_);

		return i_;
	}

    [CqlDeclaration("Outpatient Encounters or Discharges with Advanced Illness")]
	public IEnumerable<CqlDate> Outpatient_Encounters_or_Discharges_with_Advanced_Illness(CqlContext context)
	{
		IEnumerable<CqlDate> a_()
		{
			if ((context.Operators.Not((bool?)(context.Operators.ListUnion<CqlDate>(this.Outpatient_Encounters_with_Advanced_Illness(context), this.Nonacute_Inpatient_Discharge_with_Advanced_Illness(context)) is null)) ?? false))
			{
				var b_ = this.Outpatient_Encounters_with_Advanced_Illness(context);
				var c_ = this.Nonacute_Inpatient_Discharge_with_Advanced_Illness(context);
				var d_ = context.Operators.ListUnion<CqlDate>(b_, c_);

				return d_;
			}
			else if ((this.Outpatient_Encounters_with_Advanced_Illness(context) is null))
			{
				var e_ = this.Nonacute_Inpatient_Discharge_with_Advanced_Illness(context);

				return e_;
			}
			else if ((this.Nonacute_Inpatient_Discharge_with_Advanced_Illness(context) is null))
			{
				var f_ = this.Outpatient_Encounters_with_Advanced_Illness(context);

				return f_;
			}
			else
			{
				IEnumerable<CqlDate> g_ = null;

				return (g_ as IEnumerable<CqlDate>);
			};
		};

		return a_();
	}

    [CqlDeclaration("Two Outpatient Visits with Advanced Illness on Different Dates of Service")]
	public bool? Two_Outpatient_Visits_with_Advanced_Illness_on_Different_Dates_of_Service(CqlContext context)
	{
		var a_ = this.Outpatient_Encounters_or_Discharges_with_Advanced_Illness(context);
		IEnumerable<CqlDate> b_(CqlDate _OutpatientVisit1)
		{
			var j_ = this.Outpatient_Encounters_or_Discharges_with_Advanced_Illness(context);

			return j_;
		};
		Tuples.Tuple_EaBFagdYTZfYEiNNhIYITEIUR c_(CqlDate _OutpatientVisit1, CqlDate _OutpatientVisit2)
		{
			var k_ = new Tuples.Tuple_EaBFagdYTZfYEiNNhIYITEIUR
			{
				OutpatientVisit1 = _OutpatientVisit1,
				OutpatientVisit2 = _OutpatientVisit2,
			};

			return k_;
		};
		var d_ = context.Operators.SelectManyResultsOrNull<CqlDate, CqlDate, Tuples.Tuple_EaBFagdYTZfYEiNNhIYITEIUR>(a_, b_, c_);
		bool? e_(Tuples.Tuple_EaBFagdYTZfYEiNNhIYITEIUR tuple_eabfagdytzfyeinnhiyiteiur)
		{
			var l_ = context.Operators.Quantity(1m, "day");
			var m_ = context.Operators.Add(tuple_eabfagdytzfyeinnhiyiteiur.OutpatientVisit1, l_);
			var n_ = context.Operators.SameOrAfter(tuple_eabfagdytzfyeinnhiyiteiur.OutpatientVisit2, m_, null);

			return n_;
		};
		var f_ = context.Operators.WhereOrNull<Tuples.Tuple_EaBFagdYTZfYEiNNhIYITEIUR>(d_, e_);
		CqlDate g_(Tuples.Tuple_EaBFagdYTZfYEiNNhIYITEIUR tuple_eabfagdytzfyeinnhiyiteiur) => 
			tuple_eabfagdytzfyeinnhiyiteiur.OutpatientVisit1;
		var h_ = context.Operators.SelectOrNull<Tuples.Tuple_EaBFagdYTZfYEiNNhIYITEIUR, CqlDate>(f_, g_);
		var i_ = context.Operators.ExistsInList<CqlDate>(h_);

		return i_;
	}

    [CqlDeclaration("Acute Inpatient Encounter with Advanced Illness")]
	public bool? Acute_Inpatient_Encounter_with_Advanced_Illness(CqlContext context)
	{
		var a_ = this.Acute_Inpatient(context);
		var b_ = context.Operators.RetrieveByValueSet<Encounter>(a_, null);
		var c_ = NCQAStatus_1_0_0.Instance.Finished_Encounter(context, b_);
		bool? d_(Encounter InpatientEncounter)
		{
			var g_ = this.Advanced_Illness(context);
			var h_ = context.Operators.RetrieveByValueSet<Condition>(g_, null);
			var i_ = NCQAEncounter_1_0_0.Instance.Encounter_Has_Diagnosis(context, InpatientEncounter, h_);
			var j_ = NCQAFHIRBase_1_0_0.Instance.Normalize_Interval(context, (InpatientEncounter?.Period as object));
			var k_ = context.Operators.Start(j_);
			var l_ = context.Operators.DateFrom(k_);
			var m_ = this.Measurement_Period(context);
			var n_ = context.Operators.Start(m_);
			var o_ = context.Operators.DateFrom(n_);
			var p_ = context.Operators.Quantity(1m, "year");
			var q_ = context.Operators.Subtract(o_, p_);
			var s_ = context.Operators.End(m_);
			var t_ = context.Operators.DateFrom(s_);
			var u_ = context.Operators.Interval(q_, t_, true, true);
			var v_ = context.Operators.ElementInInterval<CqlDate>(l_, u_, null);
			var w_ = context.Operators.And(i_, v_);

			return w_;
		};
		var e_ = context.Operators.WhereOrNull<Encounter>(c_, d_);
		var f_ = context.Operators.ExistsInList<Encounter>(e_);

		return f_;
	}

    [CqlDeclaration("Acute Inpatient Discharge with Advanced Illness")]
	public bool? Acute_Inpatient_Discharge_with_Advanced_Illness(CqlContext context)
	{
		var a_ = context.Operators.RetrieveByValueSet<Claim>(null, null);
		var b_ = NCQAClaims_1_0_0.Instance.Medical_Claims_With_Nonacute_or_Acute_Inpatient_Discharge(context, a_);
		var c_ = this.Advanced_Illness(context);
		var d_ = context.Operators.CreateValueSetFacade(c_);
		var e_ = NCQAClaims_1_0_0.Instance.Medical_Claims_With_Diagnosis(context, b_?.AcuteInpatientDischarge, d_);
		bool? f_(CqlInterval<CqlDateTime> InpatientDischarge)
		{
			var i_ = context.Operators.End(InpatientDischarge);
			var j_ = context.Operators.DateFrom(i_);
			var k_ = this.Measurement_Period(context);
			var l_ = context.Operators.Start(k_);
			var m_ = context.Operators.DateFrom(l_);
			var n_ = context.Operators.Quantity(1m, "year");
			var o_ = context.Operators.Subtract(m_, n_);
			var q_ = context.Operators.End(k_);
			var r_ = context.Operators.DateFrom(q_);
			var s_ = context.Operators.Interval(o_, r_, true, true);
			var t_ = context.Operators.ElementInInterval<CqlDate>(j_, s_, null);

			return t_;
		};
		var g_ = context.Operators.WhereOrNull<CqlInterval<CqlDateTime>>(e_?.ServicePeriod, f_);
		var h_ = context.Operators.ExistsInList<CqlInterval<CqlDateTime>>(g_);

		return h_;
	}

    [CqlDeclaration("Dementia Medications In Year Before or During Measurement Period")]
	public bool? Dementia_Medications_In_Year_Before_or_During_Measurement_Period(CqlContext context)
	{
		var a_ = this.Dementia_Medications(context);
		var b_ = context.Operators.RetrieveByValueSet<MedicationDispense>(a_, null);
		var d_ = context.Operators.RetrieveByValueSet<MedicationDispense>(a_, null);
		var e_ = context.Operators.ListUnion<MedicationDispense>(b_, d_);
		var f_ = NCQAStatus_1_0_0.Instance.Dispensed_Medication(context, e_);
		bool? g_(MedicationDispense DementiaMedDispensed)
		{
			var j_ = NCQAFHIRBase_1_0_0.Instance.Normalize_Interval(context, (DementiaMedDispensed?.WhenHandedOverElement as object));
			var k_ = context.Operators.Start(j_);
			var l_ = context.Operators.DateFrom(k_);
			var m_ = this.Measurement_Period(context);
			var n_ = context.Operators.Start(m_);
			var o_ = context.Operators.DateFrom(n_);
			var p_ = context.Operators.Quantity(1m, "year");
			var q_ = context.Operators.Subtract(o_, p_);
			var s_ = context.Operators.End(m_);
			var t_ = context.Operators.DateFrom(s_);
			var u_ = context.Operators.Interval(q_, t_, true, true);
			var v_ = context.Operators.ElementInInterval<CqlDate>(l_, u_, null);

			return v_;
		};
		var h_ = context.Operators.WhereOrNull<MedicationDispense>(f_, g_);
		var i_ = context.Operators.ExistsInList<MedicationDispense>(h_);

		return i_;
	}

    [CqlDeclaration("Advanced Illness and Frailty Exclusion Including Over Age 80")]
	public bool? Advanced_Illness_and_Frailty_Exclusion_Including_Over_Age_80(CqlContext context)
	{
		var a_ = this.Patient(context);
		var b_ = context.Operators.Convert<CqlDate>(a_?.BirthDateElement?.Value);
		var c_ = this.Measurement_Period(context);
		var d_ = context.Operators.End(c_);
		var e_ = context.Operators.DateFrom(d_);
		var f_ = context.Operators.CalculateAgeAt(b_, e_, "year");
		var g_ = context.Operators.Interval((int?)66, (int?)80, true, true);
		var h_ = context.Operators.ElementInInterval<int?>(f_, g_, null);
		var i_ = this.Has_Criteria_Indicating_Frailty(context);
		var j_ = context.Operators.And(h_, i_);
		var k_ = this.Two_Outpatient_Visits_with_Advanced_Illness_on_Different_Dates_of_Service(context);
		var l_ = this.Acute_Inpatient_Encounter_with_Advanced_Illness(context);
		var m_ = context.Operators.Or(k_, l_);
		var n_ = this.Acute_Inpatient_Discharge_with_Advanced_Illness(context);
		var o_ = context.Operators.Or(m_, n_);
		var p_ = this.Dementia_Medications_In_Year_Before_or_During_Measurement_Period(context);
		var q_ = context.Operators.Or(o_, p_);
		var r_ = context.Operators.And(j_, q_);
		var t_ = context.Operators.Convert<CqlDate>(a_?.BirthDateElement?.Value);
		var v_ = context.Operators.End(c_);
		var w_ = context.Operators.DateFrom(v_);
		var x_ = context.Operators.CalculateAgeAt(t_, w_, "year");
		var y_ = context.Operators.GreaterOrEqual(x_, (int?)81);
		var aa_ = context.Operators.And(y_, i_);
		var ab_ = context.Operators.Or(r_, aa_);

		return ab_;
	}

    [CqlDeclaration("Advanced Illness and Frailty Exclusion Not Including Over Age 80")]
	public bool? Advanced_Illness_and_Frailty_Exclusion_Not_Including_Over_Age_80(CqlContext context)
	{
		var a_ = this.Patient(context);
		var b_ = context.Operators.Convert<CqlDate>(a_?.BirthDateElement?.Value);
		var c_ = this.Measurement_Period(context);
		var d_ = context.Operators.End(c_);
		var e_ = context.Operators.DateFrom(d_);
		var f_ = context.Operators.CalculateAgeAt(b_, e_, "year");
		var g_ = context.Operators.GreaterOrEqual(f_, (int?)66);
		var h_ = this.Has_Criteria_Indicating_Frailty(context);
		var i_ = context.Operators.And(g_, h_);
		var j_ = this.Two_Outpatient_Visits_with_Advanced_Illness_on_Different_Dates_of_Service(context);
		var k_ = this.Acute_Inpatient_Encounter_with_Advanced_Illness(context);
		var l_ = context.Operators.Or(j_, k_);
		var m_ = this.Acute_Inpatient_Discharge_with_Advanced_Illness(context);
		var n_ = context.Operators.Or(l_, m_);
		var o_ = this.Dementia_Medications_In_Year_Before_or_During_Measurement_Period(context);
		var p_ = context.Operators.Or(n_, o_);
		var q_ = context.Operators.And(i_, p_);

		return q_;
	}

}