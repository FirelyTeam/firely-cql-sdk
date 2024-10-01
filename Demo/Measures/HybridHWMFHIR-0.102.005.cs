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
[CqlLibrary("HybridHWMFHIR", "0.102.005")]
public class HybridHWMFHIR_0_102_005
{

    public static HybridHWMFHIR_0_102_005 Instance { get; }  = new();

    [CqlDeclaration("Bicarbonate lab test")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1045.139")]
	public CqlValueSet Bicarbonate_lab_test(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1045.139", null);

    [CqlDeclaration("Body temperature")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1045.152")]
	public CqlValueSet Body_temperature(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1045.152", null);

    [CqlDeclaration("Creatinine lab test")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.666.5.2363")]
	public CqlValueSet Creatinine_lab_test(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.666.5.2363", null);

    [CqlDeclaration("Emergency Department Visit")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.292")]
	public CqlValueSet Emergency_Department_Visit(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.292", null);

    [CqlDeclaration("Encounter Inpatient")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.666.5.307")]
	public CqlValueSet Encounter_Inpatient(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.666.5.307", null);

    [CqlDeclaration("Ethnicity")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.114222.4.11.837")]
	public CqlValueSet Ethnicity(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.114222.4.11.837", null);

    [CqlDeclaration("Hematocrit lab test")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1045.114")]
	public CqlValueSet Hematocrit_lab_test(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1045.114", null);

    [CqlDeclaration("Medicare payer")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1104.10")]
	public CqlValueSet Medicare_payer(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1104.10", null);

    [CqlDeclaration("Observation Services")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1111.143")]
	public CqlValueSet Observation_Services(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1111.143", null);

    [CqlDeclaration("ONC Administrative Sex")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1")]
	public CqlValueSet ONC_Administrative_Sex(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1", null);

    [CqlDeclaration("Payer")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.114222.4.11.3591")]
	public CqlValueSet Payer(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.114222.4.11.3591", null);

    [CqlDeclaration("Platelet count lab test")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1045.127")]
	public CqlValueSet Platelet_count_lab_test(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1045.127", null);

    [CqlDeclaration("Race")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.114222.4.11.836")]
	public CqlValueSet Race(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.114222.4.11.836", null);

    [CqlDeclaration("Sodium lab test")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1045.119")]
	public CqlValueSet Sodium_lab_test(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1045.119", null);

    [CqlDeclaration("White blood cells count lab test")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1045.129")]
	public CqlValueSet White_blood_cells_count_lab_test(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1045.129", null);

    [CqlDeclaration("Birth date")]
	public CqlCode Birth_date(CqlContext context) => 
		new CqlCode("21112-8", "http://loinc.org", null, null);

    [CqlDeclaration("Heart rate")]
	public CqlCode Heart_rate(CqlContext context) => 
		new CqlCode("8867-4", "http://loinc.org", null, null);

    [CqlDeclaration("Oxygen saturation in Arterial blood by Pulse oximetry")]
	public CqlCode Oxygen_saturation_in_Arterial_blood_by_Pulse_oximetry(CqlContext context) => 
		new CqlCode("59408-5", "http://loinc.org", null, null);

    [CqlDeclaration("Systolic blood pressure")]
	public CqlCode Systolic_blood_pressure(CqlContext context) => 
		new CqlCode("8480-6", "http://loinc.org", null, null);

    [CqlDeclaration("LOINC:2.69")]
	public CqlCode[] LOINC_2_69(CqlContext context)
	{
		var a_ = new CqlCode[]
		{
			new CqlCode("21112-8", "http://loinc.org", null, null),
			new CqlCode("8867-4", "http://loinc.org", null, null),
			new CqlCode("59408-5", "http://loinc.org", null, null),
			new CqlCode("8480-6", "http://loinc.org", null, null),
		};

		return a_;
	}

    [CqlDeclaration("Measurement Period")]
	public CqlInterval<CqlDateTime> Measurement_Period(CqlContext context)
	{
		var a_ = context.Operators.ConvertIntegerToDecimal(default);
		var b_ = context.Operators.DateTime((int?)2019, (int?)1, (int?)1, (int?)0, (int?)0, (int?)0, (int?)0, a_);
		var d_ = context.Operators.DateTime((int?)2020, (int?)1, (int?)1, (int?)0, (int?)0, (int?)0, (int?)0, a_);
		var e_ = context.Operators.Interval(b_, d_, true, false);
		var f_ = context.ResolveParameter("HybridHWMFHIR-0.102.005", "Measurement Period", e_);

		return (CqlInterval<CqlDateTime>)f_;
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

    [CqlDeclaration("LengthInDays")]
	public int? LengthInDays(CqlContext context, CqlInterval<CqlDateTime> Value)
	{
		var a_ = context.Operators.Start(Value);
		var b_ = context.Operators.End(Value);
		var c_ = context.Operators.DifferenceBetween(a_, b_, "day");

		return c_;
	}

    [CqlDeclaration("Inpatient Encounters")]
	public IEnumerable<Encounter> Inpatient_Encounters(CqlContext context)
	{
		var a_ = this.Encounter_Inpatient(context);
		var b_ = context.Operators.RetrieveByValueSet<Encounter>(a_, null);
		IEnumerable<Coverage> c_(Encounter _InpatientEncounter)
		{
			var j_ = this.Medicare_payer(context);
			var k_ = context.Operators.RetrieveByValueSet<Coverage>(j_, null);

			return k_;
		};
		Tuples.Tuple_CZdRYXLJAeJaPSIRaUHDXVHPV d_(Encounter _InpatientEncounter, Coverage _Payer)
		{
			var l_ = new Tuples.Tuple_CZdRYXLJAeJaPSIRaUHDXVHPV
			{
				InpatientEncounter = _InpatientEncounter,
				Payer = _Payer,
			};

			return l_;
		};
		var e_ = context.Operators.SelectManyResultsOrNull<Encounter, Coverage, Tuples.Tuple_CZdRYXLJAeJaPSIRaUHDXVHPV>(b_, c_, d_);
		bool? f_(Tuples.Tuple_CZdRYXLJAeJaPSIRaUHDXVHPV tuple_czdryxljaejapsirauhdxvhpv)
		{
			var m_ = context.Operators.Convert<string>(tuple_czdryxljaejapsirauhdxvhpv.InpatientEncounter?.StatusElement);
			var n_ = context.Operators.Equal(m_, "finished");
			var o_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.HospitalizationWithObservation(context, tuple_czdryxljaejapsirauhdxvhpv.InpatientEncounter);
			var p_ = this.LengthInDays(context, o_);
			var q_ = context.Operators.Less(p_, (int?)365);
			var r_ = context.Operators.And(n_, q_);
			var s_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, tuple_czdryxljaejapsirauhdxvhpv.InpatientEncounter?.Period);
			var t_ = context.Operators.End(s_);
			var u_ = this.Measurement_Period(context);
			var v_ = context.Operators.ElementInInterval<CqlDateTime>(t_, u_, "day");
			var w_ = context.Operators.And(r_, v_);
			var x_ = this.Patient(context);
			var y_ = context.Operators.Convert<CqlDate>(x_?.BirthDateElement?.Value);
			var aa_ = context.Operators.Start(s_);
			var ab_ = context.Operators.DateFrom(aa_);
			var ac_ = context.Operators.CalculateAgeAt(y_, ab_, "year");
			var ad_ = context.Operators.Interval((int?)65, (int?)94, true, true);
			var ae_ = context.Operators.ElementInInterval<int?>(ac_, ad_, null);
			var af_ = context.Operators.And(w_, ae_);

			return af_;
		};
		var g_ = context.Operators.WhereOrNull<Tuples.Tuple_CZdRYXLJAeJaPSIRaUHDXVHPV>(e_, f_);
		Encounter h_(Tuples.Tuple_CZdRYXLJAeJaPSIRaUHDXVHPV tuple_czdryxljaejapsirauhdxvhpv) => 
			tuple_czdryxljaejapsirauhdxvhpv.InpatientEncounter;
		var i_ = context.Operators.SelectOrNull<Tuples.Tuple_CZdRYXLJAeJaPSIRaUHDXVHPV, Encounter>(g_, h_);

		return i_;
	}

    [CqlDeclaration("Initial Population")]
	public IEnumerable<Encounter> Initial_Population(CqlContext context)
	{
		var a_ = this.Inpatient_Encounters(context);

		return a_;
	}

    [CqlDeclaration("FirstPhysicalExamWithEncounterId")]
	public IEnumerable<string> FirstPhysicalExamWithEncounterId(CqlContext context, IEnumerable<Observation> ExamList, string CCDE)
	{
		var a_ = this.Inpatient_Encounters(context);
		string b_(Encounter Encounter)
		{
			var d_ = context.Operators.Concatenate("\r\n", (CCDE ?? ""));
			var e_ = context.Operators.Concatenate((d_ ?? ""), ",");
			var f_ = context.Operators.Convert<string>(Encounter?.IdElement);
			var g_ = context.Operators.Concatenate((e_ ?? ""), (f_ ?? ""));
			var h_ = context.Operators.Concatenate((g_ ?? ""), " , ");
			bool? i_(Observation Exam)
			{
				var aa_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, Exam?.Effective);
				var ab_ = context.Operators.Start(aa_);
				var ac_ = context.Operators.Not((bool?)(ab_ is null));
				var ae_ = context.Operators.Start(aa_);
				var af_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, Encounter?.Period);
				var ag_ = context.Operators.Start(af_);
				var ah_ = context.Operators.Quantity(1440m, "minutes");
				var ai_ = context.Operators.Subtract(ag_, ah_);
				var ak_ = context.Operators.Start(af_);
				var al_ = context.Operators.Quantity(120m, "minutes");
				var am_ = context.Operators.Add(ak_, al_);
				var an_ = context.Operators.Interval(ai_, am_, true, true);
				var ao_ = context.Operators.ElementInInterval<CqlDateTime>(ae_, an_, null);
				var ap_ = context.Operators.And(ac_, ao_);
				var aq_ = context.Operators.Convert<string>(Exam?.StatusElement);
				var ar_ = new string[]
				{
					"final",
					"amended",
					"preliminary",
				};
				var as_ = context.Operators.InList<string>(aq_, (ar_ as IEnumerable<string>));
				var at_ = context.Operators.And(ap_, as_);
				var au_ = context.Operators.Not((bool?)(Exam?.Value is null));
				var av_ = context.Operators.And(at_, au_);

				return av_;
			};
			var j_ = context.Operators.WhereOrNull<Observation>(ExamList, i_);
			object k_(Observation @this)
			{
				var aw_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, @this?.Effective);
				var ax_ = context.Operators.Start(aw_);

				return ax_;
			};
			var l_ = context.Operators.ListSortBy<Observation>(j_, k_, System.ComponentModel.ListSortDirection.Ascending);
			var m_ = context.Operators.FirstOfList<Observation>(l_);
			var n_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, (m_?.Value as Quantity));
			var o_ = context.Operators.ConvertQuantityToString(n_);
			var p_ = context.Operators.Concatenate((h_ ?? ""), (o_ ?? ""));
			var q_ = context.Operators.Concatenate((p_ ?? ""), ",");
			bool? r_(Observation Exam)
			{
				var ay_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, Exam?.Effective);
				var az_ = context.Operators.Start(ay_);
				var ba_ = context.Operators.Not((bool?)(az_ is null));
				var bc_ = context.Operators.Start(ay_);
				var bd_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, Encounter?.Period);
				var be_ = context.Operators.Start(bd_);
				var bf_ = context.Operators.Quantity(1440m, "minutes");
				var bg_ = context.Operators.Subtract(be_, bf_);
				var bi_ = context.Operators.Start(bd_);
				var bj_ = context.Operators.Quantity(120m, "minutes");
				var bk_ = context.Operators.Add(bi_, bj_);
				var bl_ = context.Operators.Interval(bg_, bk_, true, true);
				var bm_ = context.Operators.ElementInInterval<CqlDateTime>(bc_, bl_, null);
				var bn_ = context.Operators.And(ba_, bm_);
				var bo_ = context.Operators.Convert<string>(Exam?.StatusElement);
				var bp_ = new string[]
				{
					"final",
					"amended",
					"preliminary",
				};
				var bq_ = context.Operators.InList<string>(bo_, (bp_ as IEnumerable<string>));
				var br_ = context.Operators.And(bn_, bq_);
				var bs_ = context.Operators.Not((bool?)(Exam?.Value is null));
				var bt_ = context.Operators.And(br_, bs_);

				return bt_;
			};
			var s_ = context.Operators.WhereOrNull<Observation>(ExamList, r_);
			object t_(Observation @this)
			{
				var bu_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, @this?.Effective);
				var bv_ = context.Operators.Start(bu_);

				return bv_;
			};
			var u_ = context.Operators.ListSortBy<Observation>(s_, t_, System.ComponentModel.ListSortDirection.Ascending);
			var v_ = context.Operators.FirstOfList<Observation>(u_);
			var w_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, v_?.Effective);
			var x_ = context.Operators.Start(w_);
			var y_ = context.Operators.ConvertDateTimeToString(x_);
			var z_ = context.Operators.Concatenate((q_ ?? ""), (y_ ?? ""));

			return z_;
		};
		var c_ = context.Operators.SelectOrNull<Encounter, string>(a_, b_);

		return c_;
	}

    [CqlDeclaration("FirstLabTestWithEncounterId")]
	public IEnumerable<string> FirstLabTestWithEncounterId(CqlContext context, IEnumerable<Observation> LabList, string CCDE)
	{
		var a_ = this.Inpatient_Encounters(context);
		string b_(Encounter Encounter)
		{
			var d_ = context.Operators.Concatenate("\r\n", (CCDE ?? ""));
			var e_ = context.Operators.Concatenate((d_ ?? ""), ",");
			var f_ = context.Operators.Convert<string>(Encounter?.IdElement);
			var g_ = context.Operators.Concatenate((e_ ?? ""), (f_ ?? ""));
			var h_ = context.Operators.Concatenate((g_ ?? ""), ",");
			bool? i_(Observation Lab)
			{
				var z_ = context.Operators.Not((bool?)(Lab?.IssuedElement is null));
				var aa_ = FHIRHelpers_4_0_001.Instance.ToDateTime(context, Lab?.IssuedElement);
				var ab_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, Encounter?.Period);
				var ac_ = context.Operators.Start(ab_);
				var ad_ = context.Operators.Quantity(1440m, "minutes");
				var ae_ = context.Operators.Subtract(ac_, ad_);
				var ag_ = context.Operators.Start(ab_);
				var ai_ = context.Operators.Add(ag_, ad_);
				var aj_ = context.Operators.Interval(ae_, ai_, true, true);
				var ak_ = context.Operators.ElementInInterval<CqlDateTime>(aa_, aj_, null);
				var al_ = context.Operators.And(z_, ak_);
				var am_ = context.Operators.Convert<string>(Lab?.StatusElement);
				var an_ = new string[]
				{
					"final",
					"amended",
					"preliminary",
				};
				var ao_ = context.Operators.InList<string>(am_, (an_ as IEnumerable<string>));
				var ap_ = context.Operators.And(al_, ao_);
				var aq_ = context.Operators.Not((bool?)(Lab?.Value is null));
				var ar_ = context.Operators.And(ap_, aq_);

				return ar_;
			};
			var j_ = context.Operators.WhereOrNull<Observation>(LabList, i_);
			object k_(Observation @this) => 
				@this?.IssuedElement;
			var l_ = context.Operators.ListSortBy<Observation>(j_, k_, System.ComponentModel.ListSortDirection.Ascending);
			var m_ = context.Operators.FirstOfList<Observation>(l_);
			var n_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, (m_?.Value as Quantity));
			var o_ = context.Operators.ConvertQuantityToString(n_);
			var p_ = context.Operators.Concatenate((h_ ?? ""), (o_ ?? ""));
			var q_ = context.Operators.Concatenate((p_ ?? ""), ",");
			bool? r_(Observation Lab)
			{
				var as_ = context.Operators.Not((bool?)(Lab?.IssuedElement is null));
				var at_ = FHIRHelpers_4_0_001.Instance.ToDateTime(context, Lab?.IssuedElement);
				var au_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, Encounter?.Period);
				var av_ = context.Operators.Start(au_);
				var aw_ = context.Operators.Quantity(1440m, "minutes");
				var ax_ = context.Operators.Subtract(av_, aw_);
				var az_ = context.Operators.Start(au_);
				var bb_ = context.Operators.Add(az_, aw_);
				var bc_ = context.Operators.Interval(ax_, bb_, true, true);
				var bd_ = context.Operators.ElementInInterval<CqlDateTime>(at_, bc_, null);
				var be_ = context.Operators.And(as_, bd_);
				var bf_ = context.Operators.Convert<string>(Lab?.StatusElement);
				var bg_ = new string[]
				{
					"final",
					"amended",
					"preliminary",
				};
				var bh_ = context.Operators.InList<string>(bf_, (bg_ as IEnumerable<string>));
				var bi_ = context.Operators.And(be_, bh_);
				var bj_ = context.Operators.Not((bool?)(Lab?.Value is null));
				var bk_ = context.Operators.And(bi_, bj_);

				return bk_;
			};
			var s_ = context.Operators.WhereOrNull<Observation>(LabList, r_);
			var u_ = context.Operators.ListSortBy<Observation>(s_, k_, System.ComponentModel.ListSortDirection.Ascending);
			var v_ = context.Operators.FirstOfList<Observation>(u_);
			var w_ = FHIRHelpers_4_0_001.Instance.ToDateTime(context, v_?.IssuedElement);
			var x_ = context.Operators.ConvertDateTimeToString(w_);
			var y_ = context.Operators.Concatenate((q_ ?? ""), (x_ ?? ""));

			return y_;
		};
		var c_ = context.Operators.SelectOrNull<Encounter, string>(a_, b_);

		return c_;
	}

    [CqlDeclaration("Results")]
	public IEnumerable<string> Results(CqlContext context)
	{
		var a_ = this.Heart_rate(context);
		var b_ = context.Operators.ToList<CqlCode>(a_);
		var c_ = context.Operators.RetrieveByCodes<Observation>(b_, null);
		var d_ = this.FirstPhysicalExamWithEncounterId(context, c_, "FirstHeartRate");
		var e_ = this.Systolic_blood_pressure(context);
		var f_ = context.Operators.ToList<CqlCode>(e_);
		var g_ = context.Operators.RetrieveByCodes<Observation>(f_, null);
		var h_ = this.FirstPhysicalExamWithEncounterId(context, g_, "FirstSystolicBP");
		var i_ = this.Body_temperature(context);
		var j_ = context.Operators.RetrieveByValueSet<Observation>(i_, null);
		var k_ = this.FirstPhysicalExamWithEncounterId(context, j_, "FirstTemperature");
		var l_ = this.Oxygen_saturation_in_Arterial_blood_by_Pulse_oximetry(context);
		var m_ = context.Operators.ToList<CqlCode>(l_);
		var n_ = context.Operators.RetrieveByCodes<Observation>(m_, null);
		var o_ = this.FirstPhysicalExamWithEncounterId(context, n_, "FirstO2Saturation");
		var p_ = this.Hematocrit_lab_test(context);
		var q_ = context.Operators.RetrieveByValueSet<Observation>(p_, null);
		var r_ = this.FirstLabTestWithEncounterId(context, q_, "FirstHematocrit");
		var s_ = this.Platelet_count_lab_test(context);
		var t_ = context.Operators.RetrieveByValueSet<Observation>(s_, null);
		var u_ = this.FirstLabTestWithEncounterId(context, t_, "FirstPlateletCount");
		var v_ = this.White_blood_cells_count_lab_test(context);
		var w_ = context.Operators.RetrieveByValueSet<Observation>(v_, null);
		var x_ = this.FirstLabTestWithEncounterId(context, w_, "FirstWhiteBloodCell");
		var y_ = this.Sodium_lab_test(context);
		var z_ = context.Operators.RetrieveByValueSet<Observation>(y_, null);
		var aa_ = this.FirstLabTestWithEncounterId(context, z_, "FirstSodium");
		var ab_ = this.Bicarbonate_lab_test(context);
		var ac_ = context.Operators.RetrieveByValueSet<Observation>(ab_, null);
		var ad_ = this.FirstLabTestWithEncounterId(context, ac_, "FirstBicarbonate");
		var ae_ = this.Creatinine_lab_test(context);
		var af_ = context.Operators.RetrieveByValueSet<Observation>(ae_, null);
		var ag_ = this.FirstLabTestWithEncounterId(context, af_, "FirstCreatinine");
		var ah_ = new IEnumerable<string>[]
		{
			d_,
			h_,
			k_,
			o_,
			r_,
			u_,
			x_,
			aa_,
			ad_,
			ag_,
		};
		var ai_ = context.Operators.FlattenList<string>((ah_ as IEnumerable<IEnumerable<string>>));

		return ai_;
	}

    [CqlDeclaration("CalendarAgeInYearsAt")]
	public int? CalendarAgeInYearsAt(CqlContext context, CqlDateTime BirthDateTime, CqlDateTime AsOf)
	{
		var a_ = context.Operators.ConvertDateTimeToDate(BirthDateTime);
		var b_ = context.Operators.ConvertDateTimeToDate(AsOf);
		var c_ = context.Operators.DurationBetween(a_, b_, "year");

		return c_;
	}

    [CqlDeclaration("ToDate")]
	public CqlDateTime ToDate(CqlContext context, CqlDateTime Value)
	{
		var a_ = context.Operators.ComponentFrom(Value, "year");
		var b_ = context.Operators.ComponentFrom(Value, "month");
		var c_ = context.Operators.ComponentFrom(Value, "day");
		var d_ = context.Operators.TimezoneOffsetFrom(Value);
		var e_ = context.Operators.DateTime(a_, b_, c_, (int?)0, (int?)0, (int?)0, (int?)0, d_);

		return e_;
	}

    [CqlDeclaration("LengthOfStay")]
	public int? LengthOfStay(CqlContext context, CqlInterval<CqlDateTime> Stay)
	{
		var a_ = context.Operators.Start(Stay);
		var b_ = context.Operators.End(Stay);
		var c_ = context.Operators.DifferenceBetween(a_, b_, "day");

		return c_;
	}

    [CqlDeclaration("HospitalizationWithObservation")]
	public CqlInterval<CqlDateTime> HospitalizationWithObservation(CqlContext context, Encounter TheEncounter)
	{
		var a_ = new Encounter[]
		{
			TheEncounter,
		};
		CqlInterval<CqlDateTime> b_(Encounter Visit)
		{
			var e_ = this.Emergency_Department_Visit(context);
			var f_ = context.Operators.RetrieveByValueSet<Encounter>(e_, null);
			bool? g_(Encounter LastED)
			{
				var ab_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, LastED?.Period);
				var ac_ = context.Operators.End(ab_);
				var ad_ = this.Observation_Services(context);
				var ae_ = context.Operators.RetrieveByValueSet<Encounter>(ad_, null);
				bool? af_(Encounter LastObs)
				{
					var bq_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, LastObs?.Period);
					var br_ = context.Operators.End(bq_);
					var bs_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, Visit?.Period);
					var bt_ = context.Operators.Start(bs_);
					var bu_ = context.Operators.Quantity(1m, "hour");
					var bv_ = context.Operators.Subtract(bt_, bu_);
					var bx_ = context.Operators.Start(bs_);
					var by_ = context.Operators.Interval(bv_, bx_, true, true);
					var bz_ = context.Operators.ElementInInterval<CqlDateTime>(br_, by_, null);
					var cb_ = context.Operators.Start(bs_);
					var cc_ = context.Operators.Not((bool?)(cb_ is null));
					var cd_ = context.Operators.And(bz_, cc_);

					return cd_;
				};
				var ag_ = context.Operators.WhereOrNull<Encounter>(ae_, af_);
				object ah_(Encounter @this)
				{
					var ce_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, @this?.Period);
					var cf_ = context.Operators.End(ce_);

					return cf_;
				};
				var ai_ = context.Operators.ListSortBy<Encounter>(ag_, ah_, System.ComponentModel.ListSortDirection.Ascending);
				var aj_ = context.Operators.LastOfList<Encounter>(ai_);
				var ak_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, aj_?.Period);
				var al_ = context.Operators.Start(ak_);
				var am_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, Visit?.Period);
				var an_ = context.Operators.Start(am_);
				var ao_ = context.Operators.Quantity(1m, "hour");
				var ap_ = context.Operators.Subtract((al_ ?? an_), ao_);
				var ar_ = context.Operators.RetrieveByValueSet<Encounter>(ad_, null);
				bool? as_(Encounter LastObs)
				{
					var cg_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, LastObs?.Period);
					var ch_ = context.Operators.End(cg_);
					var ci_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, Visit?.Period);
					var cj_ = context.Operators.Start(ci_);
					var ck_ = context.Operators.Quantity(1m, "hour");
					var cl_ = context.Operators.Subtract(cj_, ck_);
					var cn_ = context.Operators.Start(ci_);
					var co_ = context.Operators.Interval(cl_, cn_, true, true);
					var cp_ = context.Operators.ElementInInterval<CqlDateTime>(ch_, co_, null);
					var cr_ = context.Operators.Start(ci_);
					var cs_ = context.Operators.Not((bool?)(cr_ is null));
					var ct_ = context.Operators.And(cp_, cs_);

					return ct_;
				};
				var at_ = context.Operators.WhereOrNull<Encounter>(ar_, as_);
				object au_(Encounter @this)
				{
					var cu_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, @this?.Period);
					var cv_ = context.Operators.End(cu_);

					return cv_;
				};
				var av_ = context.Operators.ListSortBy<Encounter>(at_, au_, System.ComponentModel.ListSortDirection.Ascending);
				var aw_ = context.Operators.LastOfList<Encounter>(av_);
				var ax_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, aw_?.Period);
				var ay_ = context.Operators.Start(ax_);
				var ba_ = context.Operators.Start(am_);
				var bb_ = context.Operators.Interval(ap_, (ay_ ?? ba_), true, true);
				var bc_ = context.Operators.ElementInInterval<CqlDateTime>(ac_, bb_, null);
				var be_ = context.Operators.RetrieveByValueSet<Encounter>(ad_, null);
				bool? bf_(Encounter LastObs)
				{
					var cw_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, LastObs?.Period);
					var cx_ = context.Operators.End(cw_);
					var cy_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, Visit?.Period);
					var cz_ = context.Operators.Start(cy_);
					var da_ = context.Operators.Quantity(1m, "hour");
					var db_ = context.Operators.Subtract(cz_, da_);
					var dd_ = context.Operators.Start(cy_);
					var de_ = context.Operators.Interval(db_, dd_, true, true);
					var df_ = context.Operators.ElementInInterval<CqlDateTime>(cx_, de_, null);
					var dh_ = context.Operators.Start(cy_);
					var di_ = context.Operators.Not((bool?)(dh_ is null));
					var dj_ = context.Operators.And(df_, di_);

					return dj_;
				};
				var bg_ = context.Operators.WhereOrNull<Encounter>(be_, bf_);
				object bh_(Encounter @this)
				{
					var dk_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, @this?.Period);
					var dl_ = context.Operators.End(dk_);

					return dl_;
				};
				var bi_ = context.Operators.ListSortBy<Encounter>(bg_, bh_, System.ComponentModel.ListSortDirection.Ascending);
				var bj_ = context.Operators.LastOfList<Encounter>(bi_);
				var bk_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, bj_?.Period);
				var bl_ = context.Operators.Start(bk_);
				var bn_ = context.Operators.Start(am_);
				var bo_ = context.Operators.Not((bool?)((bl_ ?? bn_) is null));
				var bp_ = context.Operators.And(bc_, bo_);

				return bp_;
			};
			var h_ = context.Operators.WhereOrNull<Encounter>(f_, g_);
			object i_(Encounter @this)
			{
				var dm_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, @this?.Period);
				var dn_ = context.Operators.End(dm_);

				return dn_;
			};
			var j_ = context.Operators.ListSortBy<Encounter>(h_, i_, System.ComponentModel.ListSortDirection.Ascending);
			var k_ = context.Operators.LastOfList<Encounter>(j_);
			var l_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, k_?.Period);
			var m_ = context.Operators.Start(l_);
			var n_ = this.Observation_Services(context);
			var o_ = context.Operators.RetrieveByValueSet<Encounter>(n_, null);
			bool? p_(Encounter LastObs)
			{
				var do_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, LastObs?.Period);
				var dp_ = context.Operators.End(do_);
				var dq_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, Visit?.Period);
				var dr_ = context.Operators.Start(dq_);
				var ds_ = context.Operators.Quantity(1m, "hour");
				var dt_ = context.Operators.Subtract(dr_, ds_);
				var dv_ = context.Operators.Start(dq_);
				var dw_ = context.Operators.Interval(dt_, dv_, true, true);
				var dx_ = context.Operators.ElementInInterval<CqlDateTime>(dp_, dw_, null);
				var dz_ = context.Operators.Start(dq_);
				var ea_ = context.Operators.Not((bool?)(dz_ is null));
				var eb_ = context.Operators.And(dx_, ea_);

				return eb_;
			};
			var q_ = context.Operators.WhereOrNull<Encounter>(o_, p_);
			object r_(Encounter @this)
			{
				var ec_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, @this?.Period);
				var ed_ = context.Operators.End(ec_);

				return ed_;
			};
			var s_ = context.Operators.ListSortBy<Encounter>(q_, r_, System.ComponentModel.ListSortDirection.Ascending);
			var t_ = context.Operators.LastOfList<Encounter>(s_);
			var u_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, t_?.Period);
			var v_ = context.Operators.Start(u_);
			var w_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, Visit?.Period);
			var x_ = context.Operators.Start(w_);
			var z_ = context.Operators.End(w_);
			var aa_ = context.Operators.Interval((m_ ?? (v_ ?? x_)), z_, true, true);

			return aa_;
		};
		var c_ = context.Operators.SelectOrNull<Encounter, CqlInterval<CqlDateTime>>(a_, b_);
		var d_ = context.Operators.SingleOrNull<CqlInterval<CqlDateTime>>(c_);

		return d_;
	}

    [CqlDeclaration("HospitalizationWithObservationLengthofStay")]
	public int? HospitalizationWithObservationLengthofStay(CqlContext context, Encounter Encounter)
	{
		var a_ = this.HospitalizationWithObservation(context, Encounter);
		var b_ = this.LengthInDays(context, a_);

		return b_;
	}

}