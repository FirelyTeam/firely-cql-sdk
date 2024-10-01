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
[CqlLibrary("HospitalHarmHyperglycemiainHospitalizedPatientsFHIR", "0.0.006")]
public class HospitalHarmHyperglycemiainHospitalizedPatientsFHIR_0_0_006
{

    public static HospitalHarmHyperglycemiainHospitalizedPatientsFHIR_0_0_006 Instance { get; }  = new();

    [CqlDeclaration("birth date")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.560.100.4")]
	public CqlValueSet birth_date(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.560.100.4", null);

    [CqlDeclaration("Diabetes")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.103.12.1001")]
	public CqlValueSet Diabetes(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.103.12.1001", null);

    [CqlDeclaration("Encounter Inpatient")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.666.5.307")]
	public CqlValueSet Encounter_Inpatient(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.666.5.307", null);

    [CqlDeclaration("Glucose lab test")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1045.134")]
	public CqlValueSet Glucose_lab_test(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1045.134", null);

    [CqlDeclaration("Hypoglycemics Treatment Medications")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1196.394")]
	public CqlValueSet Hypoglycemics_Treatment_Medications(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1196.394", null);

    [CqlDeclaration("Birth date")]
	public CqlCode Birth_date(CqlContext context) => 
		new CqlCode("21112-8", "http://loinc.org", null, null);

    [CqlDeclaration("LOINC")]
	public CqlCode[] LOINC(CqlContext context)
	{
		var a_ = new CqlCode[]
		{
			new CqlCode("21112-8", "http://loinc.org", null, null),
		};

		return a_;
	}

    [CqlDeclaration("Measurement Period")]
	public CqlInterval<CqlDateTime> Measurement_Period(CqlContext context)
	{
		var a_ = context.ResolveParameter("HospitalHarmHyperglycemiainHospitalizedPatientsFHIR-0.0.006", "Measurement Period", null);

		return (CqlInterval<CqlDateTime>)a_;
	}

    [CqlDeclaration("Patient")]
	public Patient Patient(CqlContext context)
	{
		var a_ = context.Operators.RetrieveByValueSet<Patient>(null, null);
		var b_ = context.Operators.SingleOrNull<Patient>(a_);

		return b_;
	}

    [CqlDeclaration("SDE Ethnicity")]
	public IEnumerable<Coding> SDE_Ethnicity(CqlContext context)
	{
		var a_ = SupplementalDataElementsFHIR4_2_0_000.Instance.SDE_Ethnicity(context);

		return a_;
	}

    [CqlDeclaration("SDE Payer")]
	public IEnumerable<Tuples.Tuple_CFQHSgYJOXjAOCKdWLdZNNHDG> SDE_Payer(CqlContext context)
	{
		var a_ = SupplementalDataElementsFHIR4_2_0_000.Instance.SDE_Payer(context);

		return a_;
	}

    [CqlDeclaration("SDE Race")]
	public IEnumerable<Coding> SDE_Race(CqlContext context)
	{
		var a_ = SupplementalDataElementsFHIR4_2_0_000.Instance.SDE_Race(context);

		return a_;
	}

    [CqlDeclaration("SDE Sex")]
	public CqlCode SDE_Sex(CqlContext context)
	{
		var a_ = SupplementalDataElementsFHIR4_2_0_000.Instance.SDE_Sex(context);

		return a_;
	}

    [CqlDeclaration("Inpatient Encounter During Measurement Period")]
	public IEnumerable<Encounter> Inpatient_Encounter_During_Measurement_Period(CqlContext context)
	{
		var a_ = this.Encounter_Inpatient(context);
		var b_ = context.Operators.RetrieveByValueSet<Encounter>(a_, null);

		return b_;
	}

    [CqlDeclaration("Qualifying Encounters")]
	public IEnumerable<Encounter> Qualifying_Encounters(CqlContext context)
	{
		var a_ = this.Inpatient_Encounter_During_Measurement_Period(context);
		bool? b_(Encounter InpatientEncounter)
		{
			var d_ = this.Patient(context);
			var e_ = context.Operators.ConvertStringToDateTime(d_?.BirthDateElement?.Value);
			var f_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.HospitalizationWithObservation(context, InpatientEncounter);
			var g_ = context.Operators.Start(f_);
			var h_ = context.Operators.CalculateAgeAt(e_, g_, "year");
			var i_ = context.Operators.GreaterOrEqual(h_, (int?)18);

			return i_;
		};
		var c_ = context.Operators.WhereOrNull<Encounter>(a_, b_);

		return c_;
	}

    [CqlDeclaration("Qualifying Encounters With Hospitalization Period")]
	public IEnumerable<Tuples.Tuple_CXAFdKaHNVUHbTOBaaLVHDiaW> Qualifying_Encounters_With_Hospitalization_Period(CqlContext context)
	{
		var a_ = this.Qualifying_Encounters(context);
		Tuples.Tuple_CXAFdKaHNVUHbTOBaaLVHDiaW b_(Encounter QualifyingEncounter)
		{
			var d_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.HospitalizationWithObservation(context, QualifyingEncounter);
			var e_ = new Tuples.Tuple_CXAFdKaHNVUHbTOBaaLVHDiaW
			{
				encounter = QualifyingEncounter,
				hospitalizationPeriod = d_,
			};

			return e_;
		};
		var c_ = context.Operators.SelectOrNull<Encounter, Tuples.Tuple_CXAFdKaHNVUHbTOBaaLVHDiaW>(a_, b_);

		return c_;
	}

    [CqlDeclaration("Qualifying Encounters With Existing Diabetes Diagnosis")]
	public IEnumerable<Encounter> Qualifying_Encounters_With_Existing_Diabetes_Diagnosis(CqlContext context)
	{
		var a_ = this.Qualifying_Encounters_With_Hospitalization_Period(context);
		IEnumerable<Tuples.Tuple_CXAFdKaHNVUHbTOBaaLVHDiaW> b_(Tuples.Tuple_CXAFdKaHNVUHbTOBaaLVHDiaW EncounterWithHospitalization)
		{
			var f_ = this.Diabetes(context);
			var g_ = context.Operators.RetrieveByValueSet<Condition>(f_, null);
			bool? h_(Condition DiabetesDiagnosis)
			{
				var l_ = FHIRHelpers_4_0_001.Instance.ToConcept(context, DiabetesDiagnosis?.VerificationStatus);
				var m_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.confirmed(context);
				var n_ = context.Operators.ConvertCodeToConcept(m_);
				var o_ = context.Operators.Equivalent(l_, n_);
				var p_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Prevalence_Period(context, DiabetesDiagnosis);
				var q_ = context.Operators.Start(p_);
				var r_ = context.Operators.End(EncounterWithHospitalization?.hospitalizationPeriod);
				var s_ = context.Operators.Before(q_, r_, null);
				var t_ = context.Operators.And(o_, s_);

				return t_;
			};
			var i_ = context.Operators.WhereOrNull<Condition>(g_, h_);
			Tuples.Tuple_CXAFdKaHNVUHbTOBaaLVHDiaW j_(Condition DiabetesDiagnosis) => 
				EncounterWithHospitalization;
			var k_ = context.Operators.SelectOrNull<Condition, Tuples.Tuple_CXAFdKaHNVUHbTOBaaLVHDiaW>(i_, j_);

			return k_;
		};
		var c_ = context.Operators.SelectManyOrNull<Tuples.Tuple_CXAFdKaHNVUHbTOBaaLVHDiaW, Tuples.Tuple_CXAFdKaHNVUHbTOBaaLVHDiaW>(a_, b_);
		Encounter d_(Tuples.Tuple_CXAFdKaHNVUHbTOBaaLVHDiaW EncounterWithHospitalization) => 
			EncounterWithHospitalization?.encounter;
		var e_ = context.Operators.SelectOrNull<Tuples.Tuple_CXAFdKaHNVUHbTOBaaLVHDiaW, Encounter>(c_, d_);

		return e_;
	}

    [CqlDeclaration("Qualifying Encounters With Hypoglycemic Medication")]
	public IEnumerable<Encounter> Qualifying_Encounters_With_Hypoglycemic_Medication(CqlContext context)
	{
		var a_ = this.Qualifying_Encounters_With_Hospitalization_Period(context);
		IEnumerable<MedicationAdministration> b_(Tuples.Tuple_CXAFdKaHNVUHbTOBaaLVHDiaW _EncounterWithHospitalization)
		{
			var i_ = this.Hypoglycemics_Treatment_Medications(context);
			var j_ = context.Operators.RetrieveByValueSet<MedicationAdministration>(i_, null);
			var l_ = context.Operators.RetrieveByValueSet<MedicationAdministration>(i_, null);
			var m_ = context.Operators.ListUnion<MedicationAdministration>(j_, l_);

			return m_;
		};
		Tuples.Tuple_EBCeiDEEJUjLQKCDbhKCQVIHW c_(Tuples.Tuple_CXAFdKaHNVUHbTOBaaLVHDiaW _EncounterWithHospitalization, MedicationAdministration _HypoglycemicMedication)
		{
			var n_ = new Tuples.Tuple_EBCeiDEEJUjLQKCDbhKCQVIHW
			{
				EncounterWithHospitalization = _EncounterWithHospitalization,
				HypoglycemicMedication = _HypoglycemicMedication,
			};

			return n_;
		};
		var d_ = context.Operators.SelectManyResultsOrNull<Tuples.Tuple_CXAFdKaHNVUHbTOBaaLVHDiaW, MedicationAdministration, Tuples.Tuple_EBCeiDEEJUjLQKCDbhKCQVIHW>(a_, b_, c_);
		bool? e_(Tuples.Tuple_EBCeiDEEJUjLQKCDbhKCQVIHW tuple_ebceideejujlqkcdbhkcqvihw)
		{
			var o_ = context.Operators.Convert<string>(tuple_ebceideejujlqkcdbhkcqvihw.HypoglycemicMedication?.StatusElement);
			var p_ = context.Operators.Equal(o_, "completed");
			var q_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, tuple_ebceideejujlqkcdbhkcqvihw.HypoglycemicMedication?.Effective);
			var r_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(tuple_ebceideejujlqkcdbhkcqvihw.EncounterWithHospitalization?.hospitalizationPeriod, q_, null);
			var s_ = context.Operators.And(p_, r_);

			return s_;
		};
		var f_ = context.Operators.WhereOrNull<Tuples.Tuple_EBCeiDEEJUjLQKCDbhKCQVIHW>(d_, e_);
		Encounter g_(Tuples.Tuple_EBCeiDEEJUjLQKCDbhKCQVIHW tuple_ebceideejujlqkcdbhkcqvihw) => 
			tuple_ebceideejujlqkcdbhkcqvihw.EncounterWithHospitalization?.encounter;
		var h_ = context.Operators.SelectOrNull<Tuples.Tuple_EBCeiDEEJUjLQKCDbhKCQVIHW, Encounter>(f_, g_);

		return h_;
	}

    [CqlDeclaration("Qualifying Encounters With Elevated Blood Glucose Lab")]
	public IEnumerable<Encounter> Qualifying_Encounters_With_Elevated_Blood_Glucose_Lab(CqlContext context)
	{
		var a_ = this.Qualifying_Encounters_With_Hospitalization_Period(context);
		IEnumerable<Tuples.Tuple_CXAFdKaHNVUHbTOBaaLVHDiaW> b_(Tuples.Tuple_CXAFdKaHNVUHbTOBaaLVHDiaW EncounterWithHospitalization)
		{
			var f_ = this.Glucose_lab_test(context);
			var g_ = context.Operators.RetrieveByValueSet<Observation>(f_, null);
			bool? h_(Observation BloodGlucoseLab)
			{
				var l_ = FHIRHelpers_4_0_001.Instance.ToDateTime(context, (BloodGlucoseLab?.Effective as FhirDateTime));
				var m_ = context.Operators.ElementInInterval<CqlDateTime>(l_, EncounterWithHospitalization?.hospitalizationPeriod, null);
				var n_ = context.Operators.Convert<string>(BloodGlucoseLab?.StatusElement);
				var o_ = context.Operators.Equal(n_, "final");
				var p_ = context.Operators.And(m_, o_);
				var q_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, (BloodGlucoseLab?.Value as Quantity));
				var r_ = context.Operators.Quantity(200m, "mg/dL");
				var s_ = context.Operators.GreaterOrEqual(q_, r_);
				var t_ = context.Operators.And(p_, s_);

				return t_;
			};
			var i_ = context.Operators.WhereOrNull<Observation>(g_, h_);
			Tuples.Tuple_CXAFdKaHNVUHbTOBaaLVHDiaW j_(Observation BloodGlucoseLab) => 
				EncounterWithHospitalization;
			var k_ = context.Operators.SelectOrNull<Observation, Tuples.Tuple_CXAFdKaHNVUHbTOBaaLVHDiaW>(i_, j_);

			return k_;
		};
		var c_ = context.Operators.SelectManyOrNull<Tuples.Tuple_CXAFdKaHNVUHbTOBaaLVHDiaW, Tuples.Tuple_CXAFdKaHNVUHbTOBaaLVHDiaW>(a_, b_);
		Encounter d_(Tuples.Tuple_CXAFdKaHNVUHbTOBaaLVHDiaW EncounterWithHospitalization) => 
			EncounterWithHospitalization?.encounter;
		var e_ = context.Operators.SelectOrNull<Tuples.Tuple_CXAFdKaHNVUHbTOBaaLVHDiaW, Encounter>(c_, d_);

		return e_;
	}

    [CqlDeclaration("Initial Population")]
	public IEnumerable<Encounter> Initial_Population(CqlContext context)
	{
		var a_ = this.Qualifying_Encounters_With_Existing_Diabetes_Diagnosis(context);
		var b_ = this.Qualifying_Encounters_With_Hypoglycemic_Medication(context);
		var c_ = context.Operators.ListUnion<Encounter>(a_, b_);
		var d_ = this.Qualifying_Encounters_With_Elevated_Blood_Glucose_Lab(context);
		var e_ = context.Operators.ListUnion<Encounter>(c_, d_);

		return e_;
	}

    [CqlDeclaration("Denominator")]
	public IEnumerable<Encounter> Denominator(CqlContext context)
	{
		var a_ = this.Initial_Population(context);

		return a_;
	}

    [CqlDeclaration("Crop Interval to 10 Days")]
	public CqlInterval<CqlDateTime> Crop_Interval_to_10_Days(CqlContext context, CqlInterval<CqlDateTime> Period)
	{
		var a_ = context.Operators.Start(Period);
		var b_ = context.Operators.End(Period);
		var d_ = context.Operators.Quantity(10m, "days");
		var e_ = context.Operators.Add(a_, d_);
		var f_ = new CqlDateTime[]
		{
			b_,
			e_,
		};
		var g_ = context.Operators.MinOrNull<CqlDateTime>((f_ as IEnumerable<CqlDateTime>));
		var h_ = context.Operators.Interval(a_, g_, true, true);

		return h_;
	}

    [CqlDeclaration("Interval To Day Numbers")]
	public IEnumerable<int?> Interval_To_Day_Numbers(CqlContext context, CqlInterval<CqlDateTime> Period)
	{
		var a_ = context.Operators.Start(Period);
		var b_ = context.Operators.End(Period);
		var c_ = context.Operators.DurationBetween(a_, b_, "day");
		var d_ = context.Operators.Interval((int?)1, c_, true, true);
		var e_ = new CqlInterval<int?>[]
		{
			d_,
		};
		var f_ = context.Operators.ExpandList((e_ as IEnumerable<CqlInterval<int?>>), null);
		int? g_(CqlInterval<int?> DayExpand)
		{
			var i_ = context.Operators.End(DayExpand);

			return i_;
		};
		var h_ = context.Operators.SelectOrNull<CqlInterval<int?>, int?>(f_, g_);

		return h_;
	}

    [CqlDeclaration("Days In Period")]
	public IEnumerable<Tuples.Tuple_BZfjDHYASdKbVKTOeigaYPBVf> Days_In_Period(CqlContext context, CqlInterval<CqlDateTime> Period)
	{
		var a_ = this.Interval_To_Day_Numbers(context, Period);
		Tuples.Tuple_BZfjDHYASdKbVKTOeigaYPBVf b_(int? DayIndex)
		{
			var d_ = context.Operators.Start(Period);
			var e_ = context.Operators.Quantity(24m, "hours");
			var f_ = context.Operators.Subtract(DayIndex, (int?)1);
			var g_ = context.Operators.ConvertIntegerToQuantity(f_);
			var h_ = context.Operators.Multiply(e_, g_);
			var i_ = context.Operators.Add(d_, h_);
			CqlDateTime j_()
			{
				if ((context.Operators.Less(context.Operators.DurationBetween(context.Operators.Add(context.Operators.Start(Period), context.Operators.Multiply(context.Operators.Quantity(24m, "hours"), context.Operators.ConvertIntegerToQuantity(context.Operators.Subtract(DayIndex, (int?)1)))), context.Operators.End(Period), "hour"), (int?)24) ?? false))
				{
					var m_ = context.Operators.Start(Period);
					var n_ = context.Operators.Quantity(24m, "hours");
					var o_ = context.Operators.Subtract(DayIndex, (int?)1);
					var p_ = context.Operators.ConvertIntegerToQuantity(o_);
					var q_ = context.Operators.Multiply(n_, p_);
					var r_ = context.Operators.Add(m_, q_);

					return r_;
				}
				else
				{
					var s_ = context.Operators.Start(Period);
					var t_ = context.Operators.Quantity(24m, "hours");
					var u_ = context.Operators.ConvertIntegerToQuantity(DayIndex);
					var v_ = context.Operators.Multiply(t_, u_);
					var w_ = context.Operators.Add(s_, v_);

					return w_;
				};
			};
			var k_ = context.Operators.Interval(i_, j_(), true, false);
			var l_ = new Tuples.Tuple_BZfjDHYASdKbVKTOeigaYPBVf
			{
				dayIndex = DayIndex,
				dayPeriod = k_,
			};

			return l_;
		};
		var c_ = context.Operators.SelectOrNull<int?, Tuples.Tuple_BZfjDHYASdKbVKTOeigaYPBVf>(a_, b_);

		return c_;
	}

    [CqlDeclaration("Pertinent Encounters With Days")]
	public IEnumerable<Tuples.Tuple_FdccSJcWTSebijGjABdUMLEdR> Pertinent_Encounters_With_Days(CqlContext context)
	{
		var a_ = this.Initial_Population(context);
		Tuples.Tuple_FdccSJcWTSebijGjABdUMLEdR b_(Encounter PertinentEncounter)
		{
			var d_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.HospitalizationWithObservation(context, PertinentEncounter);
			var f_ = this.Crop_Interval_to_10_Days(context, d_);
			var h_ = this.Crop_Interval_to_10_Days(context, d_);
			var i_ = this.Days_In_Period(context, h_);
			var j_ = new Tuples.Tuple_FdccSJcWTSebijGjABdUMLEdR
			{
				encounter = PertinentEncounter,
				hospitalizationPeriod = d_,
				relevantPeriod = f_,
				relevantDays = i_,
			};

			return j_;
		};
		var c_ = context.Operators.SelectOrNull<Encounter, Tuples.Tuple_FdccSJcWTSebijGjABdUMLEdR>(a_, b_);

		return c_;
	}

    [CqlDeclaration("Pertinent Encounters With Glucose Result Days")]
	public IEnumerable<Tuples.Tuple_GiWKJXbiXAiGGBDVZJdMTaVhK> Pertinent_Encounters_With_Glucose_Result_Days(CqlContext context)
	{
		var a_ = this.Pertinent_Encounters_With_Days(context);
		Tuples.Tuple_GiWKJXbiXAiGGBDVZJdMTaVhK b_(Tuples.Tuple_FdccSJcWTSebijGjABdUMLEdR PertinentEncounterDays)
		{
			Tuples.Tuple_EPQMNeOgChVRHOcBPRccPNZeF d_(Tuples.Tuple_BZfjDHYASdKbVKTOeigaYPBVf EncounterDay)
			{
				var g_ = this.Glucose_lab_test(context);
				var h_ = context.Operators.RetrieveByValueSet<Observation>(g_, null);
				bool? i_(Observation BloodGlucoseLab1)
				{
					var x_ = context.Operators.Convert<string>(BloodGlucoseLab1?.StatusElement);
					var y_ = context.Operators.Equal(x_, "final");
					var z_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, (BloodGlucoseLab1?.Value as Quantity));
					var aa_ = context.Operators.Quantity(300m, "mg/dL");
					var ab_ = context.Operators.Greater(z_, aa_);
					var ac_ = context.Operators.And(y_, ab_);
					var ad_ = FHIRHelpers_4_0_001.Instance.ToDateTime(context, (BloodGlucoseLab1?.Effective as FhirDateTime));
					var ae_ = context.Operators.ElementInInterval<CqlDateTime>(ad_, EncounterDay?.dayPeriod, null);
					var af_ = context.Operators.And(ac_, ae_);

					return af_;
				};
				var j_ = context.Operators.WhereOrNull<Observation>(h_, i_);
				var k_ = context.Operators.ExistsInList<Observation>(j_);
				var m_ = context.Operators.RetrieveByValueSet<Observation>(g_, null);
				bool? n_(Observation BloodGlucoseLab2)
				{
					var ag_ = context.Operators.Convert<string>(BloodGlucoseLab2?.StatusElement);
					var ah_ = context.Operators.Equal(ag_, "final");
					var ai_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, (BloodGlucoseLab2?.Value as Quantity));
					var aj_ = context.Operators.Quantity(200m, "mg/dL");
					var ak_ = context.Operators.GreaterOrEqual(ai_, aj_);
					var al_ = context.Operators.And(ah_, ak_);
					var am_ = FHIRHelpers_4_0_001.Instance.ToDateTime(context, (BloodGlucoseLab2?.Effective as FhirDateTime));
					var an_ = context.Operators.ElementInInterval<CqlDateTime>(am_, EncounterDay?.dayPeriod, null);
					var ao_ = context.Operators.And(al_, an_);

					return ao_;
				};
				var o_ = context.Operators.WhereOrNull<Observation>(m_, n_);
				var p_ = context.Operators.ExistsInList<Observation>(o_);
				var r_ = context.Operators.RetrieveByValueSet<Observation>(g_, null);
				bool? s_(Observation BloodGlucoseLab3)
				{
					var ap_ = context.Operators.Convert<string>(BloodGlucoseLab3?.StatusElement);
					var aq_ = context.Operators.Equal(ap_, "final");
					var ar_ = FHIRHelpers_4_0_001.Instance.ToDateTime(context, (BloodGlucoseLab3?.Effective as FhirDateTime));
					var as_ = context.Operators.ElementInInterval<CqlDateTime>(ar_, EncounterDay?.dayPeriod, null);
					var at_ = context.Operators.And(aq_, as_);

					return at_;
				};
				var t_ = context.Operators.WhereOrNull<Observation>(r_, s_);
				var u_ = context.Operators.ExistsInList<Observation>(t_);
				var v_ = context.Operators.Not(u_);
				var w_ = new Tuples.Tuple_EPQMNeOgChVRHOcBPRccPNZeF
				{
					dayIndex = EncounterDay?.dayIndex,
					dayPeriod = EncounterDay?.dayPeriod,
					hasSevereResult = k_,
					hasElevatedResult = p_,
					hasNoResult = v_,
				};

				return w_;
			};
			var e_ = context.Operators.SelectOrNull<Tuples.Tuple_BZfjDHYASdKbVKTOeigaYPBVf, Tuples.Tuple_EPQMNeOgChVRHOcBPRccPNZeF>(PertinentEncounterDays?.relevantDays, d_);
			var f_ = new Tuples.Tuple_GiWKJXbiXAiGGBDVZJdMTaVhK
			{
				encounter = PertinentEncounterDays?.encounter,
				relevantPeriod = PertinentEncounterDays?.relevantPeriod,
				relevantDays = e_,
			};

			return f_;
		};
		var c_ = context.Operators.SelectOrNull<Tuples.Tuple_FdccSJcWTSebijGjABdUMLEdR, Tuples.Tuple_GiWKJXbiXAiGGBDVZJdMTaVhK>(a_, b_);

		return c_;
	}

    [CqlDeclaration("Pertinent Encounters With Hyperglycemic Event Days")]
	public IEnumerable<Tuples.Tuple_CAbQjTVRCSKOYWiIhECGMcDPA> Pertinent_Encounters_With_Hyperglycemic_Event_Days(CqlContext context)
	{
		var a_ = this.Pertinent_Encounters_With_Glucose_Result_Days(context);
		Tuples.Tuple_CAbQjTVRCSKOYWiIhECGMcDPA b_(Tuples.Tuple_GiWKJXbiXAiGGBDVZJdMTaVhK EncounterWithResultDays)
		{
			bool? d_(Tuples.Tuple_EPQMNeOgChVRHOcBPRccPNZeF EncounterDay)
			{
				var i_ = context.Operators.Greater(EncounterDay?.dayIndex, (int?)1);

				return i_;
			};
			var e_ = context.Operators.WhereOrNull<Tuples.Tuple_EPQMNeOgChVRHOcBPRccPNZeF>(EncounterWithResultDays?.relevantDays, d_);
			Tuples.Tuple_HBBaLFUhhUfQBEJKjEZegSRLi f_(Tuples.Tuple_EPQMNeOgChVRHOcBPRccPNZeF EncounterDay)
			{
				var j_ = context.Operators.Subtract(EncounterDay?.dayIndex, (int?)2);
				var k_ = context.Operators.ListElementAt<Tuples.Tuple_EPQMNeOgChVRHOcBPRccPNZeF>(EncounterWithResultDays?.relevantDays, j_);
				var l_ = context.Operators.And(EncounterDay?.hasNoResult, k_?.hasElevatedResult);
				var m_ = context.Operators.Subtract(EncounterDay?.dayIndex, (int?)3);
				var n_ = context.Operators.ListElementAt<Tuples.Tuple_EPQMNeOgChVRHOcBPRccPNZeF>(EncounterWithResultDays?.relevantDays, m_);
				var o_ = context.Operators.And(l_, n_?.hasElevatedResult);
				var p_ = context.Operators.Or(EncounterDay?.hasSevereResult, o_);
				var q_ = new Tuples.Tuple_HBBaLFUhhUfQBEJKjEZegSRLi
				{
					dayIndex = EncounterDay?.dayIndex,
					dayPeriod = EncounterDay?.dayPeriod,
					hasHyperglycemicEvent = p_,
				};

				return q_;
			};
			var g_ = context.Operators.SelectOrNull<Tuples.Tuple_EPQMNeOgChVRHOcBPRccPNZeF, Tuples.Tuple_HBBaLFUhhUfQBEJKjEZegSRLi>(e_, f_);
			var h_ = new Tuples.Tuple_CAbQjTVRCSKOYWiIhECGMcDPA
			{
				encounter = EncounterWithResultDays?.encounter,
				relevantPeriod = EncounterWithResultDays?.relevantPeriod,
				eligibleEventDays = g_,
			};

			return h_;
		};
		var c_ = context.Operators.SelectOrNull<Tuples.Tuple_GiWKJXbiXAiGGBDVZJdMTaVhK, Tuples.Tuple_CAbQjTVRCSKOYWiIhECGMcDPA>(a_, b_);

		return c_;
	}

    [CqlDeclaration("Numerator")]
	public IEnumerable<Encounter> Numerator(CqlContext context)
	{
		var a_ = this.Pertinent_Encounters_With_Hyperglycemic_Event_Days(context);
		bool? b_(Tuples.Tuple_CAbQjTVRCSKOYWiIhECGMcDPA EncounterWithEventDays)
		{
			bool? f_(Tuples.Tuple_HBBaLFUhhUfQBEJKjEZegSRLi EligibleEventDay) => 
				EligibleEventDay?.hasHyperglycemicEvent;
			var g_ = context.Operators.WhereOrNull<Tuples.Tuple_HBBaLFUhhUfQBEJKjEZegSRLi>(EncounterWithEventDays?.eligibleEventDays, f_);
			var h_ = context.Operators.ExistsInList<Tuples.Tuple_HBBaLFUhhUfQBEJKjEZegSRLi>(g_);

			return h_;
		};
		var c_ = context.Operators.WhereOrNull<Tuples.Tuple_CAbQjTVRCSKOYWiIhECGMcDPA>(a_, b_);
		Encounter d_(Tuples.Tuple_CAbQjTVRCSKOYWiIhECGMcDPA EncounterWithEventDays) => 
			EncounterWithEventDays?.encounter;
		var e_ = context.Operators.SelectOrNull<Tuples.Tuple_CAbQjTVRCSKOYWiIhECGMcDPA, Encounter>(c_, d_);

		return e_;
	}

    [CqlDeclaration("Denominator Observations")]
	public int? Denominator_Observations(CqlContext context, Encounter QualifyingEncounter)
	{
		var a_ = this.Pertinent_Encounters_With_Hyperglycemic_Event_Days(context);
		bool? b_(Tuples.Tuple_CAbQjTVRCSKOYWiIhECGMcDPA EncounterWithEventDays)
		{
			var g_ = context.Operators.Equal(EncounterWithEventDays?.encounter, QualifyingEncounter);

			return g_;
		};
		var c_ = context.Operators.WhereOrNull<Tuples.Tuple_CAbQjTVRCSKOYWiIhECGMcDPA>(a_, b_);
		int? d_(Tuples.Tuple_CAbQjTVRCSKOYWiIhECGMcDPA EncounterWithEventDays)
		{
			var h_ = context.Operators.CountOrNull<Tuples.Tuple_HBBaLFUhhUfQBEJKjEZegSRLi>(EncounterWithEventDays?.eligibleEventDays);

			return h_;
		};
		var e_ = context.Operators.SelectOrNull<Tuples.Tuple_CAbQjTVRCSKOYWiIhECGMcDPA, int?>(c_, d_);
		var f_ = context.Operators.SingleOrNull<int?>(e_);

		return f_;
	}

    [CqlDeclaration("Numerator Observations")]
	public int? Numerator_Observations(CqlContext context, Encounter QualifyingEncounter)
	{
		var a_ = this.Pertinent_Encounters_With_Hyperglycemic_Event_Days(context);
		bool? b_(Tuples.Tuple_CAbQjTVRCSKOYWiIhECGMcDPA EncounterWithEventDays)
		{
			var g_ = context.Operators.Equal(EncounterWithEventDays?.encounter, QualifyingEncounter);

			return g_;
		};
		var c_ = context.Operators.WhereOrNull<Tuples.Tuple_CAbQjTVRCSKOYWiIhECGMcDPA>(a_, b_);
		int? d_(Tuples.Tuple_CAbQjTVRCSKOYWiIhECGMcDPA EncounterWithEventDays)
		{
			bool? h_(Tuples.Tuple_HBBaLFUhhUfQBEJKjEZegSRLi EligibleEventDay) => 
				EligibleEventDay?.hasHyperglycemicEvent;
			var i_ = context.Operators.WhereOrNull<Tuples.Tuple_HBBaLFUhhUfQBEJKjEZegSRLi>(EncounterWithEventDays?.eligibleEventDays, h_);
			var j_ = context.Operators.CountOrNull<Tuples.Tuple_HBBaLFUhhUfQBEJKjEZegSRLi>(i_);

			return j_;
		};
		var e_ = context.Operators.SelectOrNull<Tuples.Tuple_CAbQjTVRCSKOYWiIhECGMcDPA, int?>(c_, d_);
		var f_ = context.Operators.SingleOrNull<int?>(e_);

		return f_;
	}

}