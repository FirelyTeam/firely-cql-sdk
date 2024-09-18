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
[CqlLibrary("CervicalCancerScreeningFHIR", "0.0.005")]
public class CervicalCancerScreeningFHIR_0_0_005
{

    public static CervicalCancerScreeningFHIR_0_0_005 Instance { get; }  = new();

    [CqlDeclaration("Congenital or Acquired Absence of Cervix")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.111.12.1016")]
	public CqlValueSet Congenital_or_Acquired_Absence_of_Cervix(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.111.12.1016", null);

    [CqlDeclaration("Home Healthcare Services")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1016")]
	public CqlValueSet Home_Healthcare_Services(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1016", null);

    [CqlDeclaration("HPV Test")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.110.12.1059")]
	public CqlValueSet HPV_Test(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.110.12.1059", null);

    [CqlDeclaration("Hysterectomy with No Residual Cervix")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.198.12.1014")]
	public CqlValueSet Hysterectomy_with_No_Residual_Cervix(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.198.12.1014", null);

    [CqlDeclaration("Office Visit")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1001")]
	public CqlValueSet Office_Visit(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1001", null);

    [CqlDeclaration("Online Assessments")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1089")]
	public CqlValueSet Online_Assessments(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1089", null);

    [CqlDeclaration("Pap Test")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.108.12.1017")]
	public CqlValueSet Pap_Test(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.108.12.1017", null);

    [CqlDeclaration("Preventive Care Services - Established Office Visit, 18 and Up")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1025")]
	public CqlValueSet Preventive_Care_Services___Established_Office_Visit__18_and_Up(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1025", null);

    [CqlDeclaration("Preventive Care Services-Initial Office Visit, 18 and Up")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1023")]
	public CqlValueSet Preventive_Care_Services_Initial_Office_Visit__18_and_Up(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1023", null);

    [CqlDeclaration("Telephone Visits")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1080")]
	public CqlValueSet Telephone_Visits(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1080", null);

    [CqlDeclaration("laboratory")]
	public CqlCode laboratory(CqlContext context) => 
		new CqlCode("laboratory", "http://terminology.hl7.org/CodeSystem/observation-category", null, null);

    [CqlDeclaration("ObservationCategoryCodes")]
	public CqlCode[] ObservationCategoryCodes(CqlContext context)
	{
		var a_ = new CqlCode[]
		{
			new CqlCode("laboratory", "http://terminology.hl7.org/CodeSystem/observation-category", null, null),
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
		var f_ = context.ResolveParameter("CervicalCancerScreeningFHIR-0.0.005", "Measurement Period", e_);

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

    [CqlDeclaration("Qualifying Encounters")]
	public IEnumerable<Encounter> Qualifying_Encounters(CqlContext context)
	{
		var a_ = this.Office_Visit(context);
		var b_ = context.Operators.RetrieveByValueSet<Encounter>(a_, null);
		var c_ = this.Preventive_Care_Services___Established_Office_Visit__18_and_Up(context);
		var d_ = context.Operators.RetrieveByValueSet<Encounter>(c_, null);
		var e_ = context.Operators.ListUnion<Encounter>(b_, d_);
		var f_ = this.Preventive_Care_Services_Initial_Office_Visit__18_and_Up(context);
		var g_ = context.Operators.RetrieveByValueSet<Encounter>(f_, null);
		var h_ = this.Home_Healthcare_Services(context);
		var i_ = context.Operators.RetrieveByValueSet<Encounter>(h_, null);
		var j_ = context.Operators.ListUnion<Encounter>(g_, i_);
		var k_ = context.Operators.ListUnion<Encounter>(e_, j_);
		var l_ = this.Telephone_Visits(context);
		var m_ = context.Operators.RetrieveByValueSet<Encounter>(l_, null);
		var n_ = this.Online_Assessments(context);
		var o_ = context.Operators.RetrieveByValueSet<Encounter>(n_, null);
		var p_ = context.Operators.ListUnion<Encounter>(m_, o_);
		var q_ = context.Operators.ListUnion<Encounter>(k_, p_);
		bool? r_(Encounter ValidEncounter)
		{
			var t_ = context.Operators.Convert<string>(ValidEncounter?.StatusElement);
			var u_ = context.Operators.Equal(t_, "finished");
			var v_ = this.Measurement_Period(context);
			var w_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, ValidEncounter?.Period);
			var x_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(v_, w_, null);
			var y_ = context.Operators.And(u_, x_);

			return y_;
		};
		var s_ = context.Operators.WhereOrNull<Encounter>(q_, r_);

		return s_;
	}

    [CqlDeclaration("Initial Population")]
	public bool? Initial_Population(CqlContext context)
	{
		var a_ = this.Patient(context);
		var b_ = context.Operators.Convert<CqlDate>(a_?.BirthDateElement?.Value);
		var c_ = this.Measurement_Period(context);
		var d_ = context.Operators.Start(c_);
		var e_ = context.Operators.DateFrom(d_);
		var f_ = context.Operators.CalculateAgeAt(b_, e_, "year");
		var g_ = context.Operators.Interval((int?)23, (int?)64, true, false);
		var h_ = context.Operators.ElementInInterval<int?>(f_, g_, null);
		var j_ = context.Operators.Convert<string>(a_?.GenderElement);
		var k_ = context.Operators.Equal(j_, "female");
		var l_ = context.Operators.And(h_, k_);
		var m_ = this.Qualifying_Encounters(context);
		var n_ = context.Operators.ExistsInList<Encounter>(m_);
		var o_ = context.Operators.And(l_, n_);

		return o_;
	}

    [CqlDeclaration("Denominator")]
	public bool? Denominator(CqlContext context)
	{
		var a_ = this.Initial_Population(context);

		return a_;
	}

    [CqlDeclaration("Absence of Cervix")]
	public IEnumerable<object> Absence_of_Cervix(CqlContext context)
	{
		var a_ = this.Hysterectomy_with_No_Residual_Cervix(context);
		var b_ = context.Operators.RetrieveByValueSet<Procedure>(a_, null);
		bool? c_(Procedure NoCervixProcedure)
		{
			var j_ = context.Operators.Convert<string>(NoCervixProcedure?.StatusElement);
			var k_ = context.Operators.Equal(j_, "completed");
			var l_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, NoCervixProcedure?.Performed);
			var m_ = context.Operators.End(l_);
			var n_ = this.Measurement_Period(context);
			var o_ = context.Operators.End(n_);
			var p_ = context.Operators.SameOrBefore(m_, o_, null);
			var q_ = context.Operators.And(k_, p_);

			return q_;
		};
		var d_ = context.Operators.WhereOrNull<Procedure>(b_, c_);
		var e_ = this.Congenital_or_Acquired_Absence_of_Cervix(context);
		var f_ = context.Operators.RetrieveByValueSet<Condition>(e_, null);
		bool? g_(Condition NoCervixDiagnosis)
		{
			var r_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Prevalence_Period(context, NoCervixDiagnosis);
			var s_ = context.Operators.Start(r_);
			var t_ = this.Measurement_Period(context);
			var u_ = context.Operators.End(t_);
			var v_ = context.Operators.SameOrBefore(s_, u_, null);

			return v_;
		};
		var h_ = context.Operators.WhereOrNull<Condition>(f_, g_);
		var i_ = context.Operators.ListUnion<object>((d_ as IEnumerable<object>), (h_ as IEnumerable<object>));

		return i_;
	}

    [CqlDeclaration("Denominator Exclusions")]
	public bool? Denominator_Exclusions(CqlContext context)
	{
		var a_ = HospiceFHIR4_2_3_000.Instance.Has_Hospice(context);
		var b_ = this.Absence_of_Cervix(context);
		var c_ = context.Operators.ExistsInList<object>(b_);
		var d_ = context.Operators.Or(a_, c_);
		var e_ = PalliativeCareFHIR_0_6_000.Instance.Palliative_Care_in_the_Measurement_Period(context);
		var f_ = context.Operators.Or(d_, e_);

		return f_;
	}

    [CqlDeclaration("Cervical Cytology Within 3 Years")]
	public IEnumerable<Observation> Cervical_Cytology_Within_3_Years(CqlContext context)
	{
		var a_ = this.Pap_Test(context);
		var b_ = context.Operators.RetrieveByValueSet<Observation>(a_, null);
		bool? c_(Observation CervicalCytology)
		{
			var e_ = context.Operators.Convert<string>(CervicalCytology?.StatusElement);
			var f_ = new string[]
			{
				"final",
				"amended",
				"corrected",
			};
			var g_ = context.Operators.InList<string>(e_, (f_ as IEnumerable<string>));
			bool? h_(CodeableConcept CervicalCytologyCategory)
			{
				var ab_ = this.laboratory(context);
				var ac_ = FHIRHelpers_4_0_001.Instance.ToConcept(context, CervicalCytologyCategory);
				var ad_ = context.Operators.CodeInList(ab_, (ac_?.codes as IEnumerable<CqlCode>));

				return ad_;
			};
			var i_ = context.Operators.WhereOrNull<CodeableConcept>((CervicalCytology?.Category as IEnumerable<CodeableConcept>), h_);
			var j_ = context.Operators.ExistsInList<CodeableConcept>(i_);
			var k_ = context.Operators.And(g_, j_);
			var l_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Latest(context, CervicalCytology?.Effective);
			var m_ = this.Measurement_Period(context);
			var n_ = context.Operators.End(m_);
			var o_ = context.Operators.Quantity(3m, "years");
			var p_ = context.Operators.Subtract(n_, o_);
			var r_ = context.Operators.End(m_);
			var s_ = context.Operators.Interval(p_, r_, true, true);
			var t_ = context.Operators.ElementInInterval<CqlDateTime>(l_, s_, null);
			var v_ = context.Operators.End(m_);
			var w_ = context.Operators.Not((bool?)(v_ is null));
			var x_ = context.Operators.And(t_, w_);
			var y_ = context.Operators.And(k_, x_);
			var z_ = context.Operators.Not((bool?)(CervicalCytology?.Value is null));
			var aa_ = context.Operators.And(y_, z_);

			return aa_;
		};
		var d_ = context.Operators.WhereOrNull<Observation>(b_, c_);

		return d_;
	}

    [CqlDeclaration("HPV Test Within 5 Years for Women Age 30 and Older")]
	public IEnumerable<Observation> HPV_Test_Within_5_Years_for_Women_Age_30_and_Older(CqlContext context)
	{
		var a_ = this.HPV_Test(context);
		var b_ = context.Operators.RetrieveByValueSet<Observation>(a_, null);
		bool? c_(Observation HPVTest)
		{
			var e_ = context.Operators.Convert<string>(HPVTest?.StatusElement);
			var f_ = new string[]
			{
				"final",
				"amended",
				"corrected",
			};
			var g_ = context.Operators.InList<string>(e_, (f_ as IEnumerable<string>));
			bool? h_(CodeableConcept HPVTestCategory)
			{
				var aj_ = this.laboratory(context);
				var ak_ = FHIRHelpers_4_0_001.Instance.ToConcept(context, HPVTestCategory);
				var al_ = context.Operators.CodeInList(aj_, (ak_?.codes as IEnumerable<CqlCode>));

				return al_;
			};
			var i_ = context.Operators.WhereOrNull<CodeableConcept>((HPVTest?.Category as IEnumerable<CodeableConcept>), h_);
			var j_ = context.Operators.ExistsInList<CodeableConcept>(i_);
			var k_ = context.Operators.And(g_, j_);
			var l_ = this.Patient(context);
			var m_ = context.Operators.Convert<CqlDate>(l_?.BirthDateElement?.Value);
			var n_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, HPVTest?.Effective);
			var o_ = context.Operators.Start(n_);
			var p_ = context.Operators.DateFrom(o_);
			var q_ = context.Operators.CalculateAgeAt(m_, p_, "year");
			var r_ = context.Operators.GreaterOrEqual(q_, (int?)30);
			var s_ = context.Operators.And(k_, r_);
			var t_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Latest(context, HPVTest?.Effective);
			var u_ = this.Measurement_Period(context);
			var v_ = context.Operators.End(u_);
			var w_ = context.Operators.Quantity(5m, "years");
			var x_ = context.Operators.Subtract(v_, w_);
			var z_ = context.Operators.End(u_);
			var aa_ = context.Operators.Interval(x_, z_, true, true);
			var ab_ = context.Operators.ElementInInterval<CqlDateTime>(t_, aa_, null);
			var ad_ = context.Operators.End(u_);
			var ae_ = context.Operators.Not((bool?)(ad_ is null));
			var af_ = context.Operators.And(ab_, ae_);
			var ag_ = context.Operators.And(s_, af_);
			var ah_ = context.Operators.Not((bool?)(HPVTest?.Value is null));
			var ai_ = context.Operators.And(ag_, ah_);

			return ai_;
		};
		var d_ = context.Operators.WhereOrNull<Observation>(b_, c_);

		return d_;
	}

    [CqlDeclaration("Numerator")]
	public bool? Numerator(CqlContext context)
	{
		var a_ = this.Cervical_Cytology_Within_3_Years(context);
		var b_ = context.Operators.ExistsInList<Observation>(a_);
		var c_ = this.HPV_Test_Within_5_Years_for_Women_Age_30_and_Older(context);
		var d_ = context.Operators.ExistsInList<Observation>(c_);
		var e_ = context.Operators.Or(b_, d_);

		return e_;
	}

    [CqlDeclaration("isComplete")]
	public bool? isComplete(CqlContext context, Observation observation)
	{
		var a_ = context.Operators.Convert<string>(observation?.StatusElement);
		var b_ = new string[]
		{
			"final",
			"amended",
			"corrected",
		};
		var c_ = context.Operators.InList<string>(a_, (b_ as IEnumerable<string>));

		return c_;
	}

    [CqlDeclaration("isLaboratoryTest")]
	public bool? isLaboratoryTest(CqlContext context, Observation observation)
	{
		bool? a_(CodeableConcept category)
		{
			var d_ = this.laboratory(context);
			var e_ = FHIRHelpers_4_0_001.Instance.ToConcept(context, category);
			var f_ = context.Operators.CodeInList(d_, (e_?.codes as IEnumerable<CqlCode>));

			return f_;
		};
		var b_ = context.Operators.WhereOrNull<CodeableConcept>((observation?.Category as IEnumerable<CodeableConcept>), a_);
		var c_ = context.Operators.ExistsInList<CodeableConcept>(b_);

		return c_;
	}

    [CqlDeclaration("latest")]
	public CqlDateTime latest(CqlContext context, object choice)
	{
		var a_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Latest(context, choice);

		return a_;
	}

    [CqlDeclaration("Cervical Cytology Within 3 Years (2)")]
	public IEnumerable<Observation> Cervical_Cytology_Within_3_Years__2_(CqlContext context)
	{
		var a_ = this.Pap_Test(context);
		var b_ = context.Operators.RetrieveByValueSet<Observation>(a_, null);
		bool? c_(Observation CervicalCytology)
		{
			var e_ = this.isComplete(context, CervicalCytology);
			var f_ = this.isLaboratoryTest(context, CervicalCytology);
			var g_ = context.Operators.And(e_, f_);
			var h_ = this.latest(context, CervicalCytology?.Effective);
			var i_ = this.Measurement_Period(context);
			var j_ = context.Operators.End(i_);
			var k_ = context.Operators.Quantity(3m, "years");
			var l_ = context.Operators.Subtract(j_, k_);
			var n_ = context.Operators.End(i_);
			var o_ = context.Operators.Interval(l_, n_, true, true);
			var p_ = context.Operators.ElementInInterval<CqlDateTime>(h_, o_, null);
			var r_ = context.Operators.End(i_);
			var s_ = context.Operators.Not((bool?)(r_ is null));
			var t_ = context.Operators.And(p_, s_);
			var u_ = context.Operators.And(g_, t_);
			var v_ = context.Operators.Not((bool?)(CervicalCytology?.Value is null));
			var w_ = context.Operators.And(u_, v_);

			return w_;
		};
		var d_ = context.Operators.WhereOrNull<Observation>(b_, c_);

		return d_;
	}

    [CqlDeclaration("toInterval")]
	public CqlInterval<CqlDateTime> toInterval(CqlContext context, object choice)
	{
		var a_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, choice);

		return a_;
	}

    [CqlDeclaration("HPV Test Within 5 Years for Women Age 30 and Older (2)")]
	public IEnumerable<Observation> HPV_Test_Within_5_Years_for_Women_Age_30_and_Older__2_(CqlContext context)
	{
		var a_ = this.HPV_Test(context);
		var b_ = context.Operators.RetrieveByValueSet<Observation>(a_, null);
		bool? c_(Observation HPVTest)
		{
			var e_ = this.isComplete(context, HPVTest);
			var f_ = this.isLaboratoryTest(context, HPVTest);
			var g_ = context.Operators.And(e_, f_);
			var h_ = this.Patient(context);
			var i_ = context.Operators.Convert<CqlDate>(h_?.BirthDateElement?.Value);
			var j_ = this.toInterval(context, HPVTest?.Effective);
			var k_ = context.Operators.Start(j_);
			var l_ = context.Operators.DateFrom(k_);
			var m_ = context.Operators.CalculateAgeAt(i_, l_, "year");
			var n_ = context.Operators.GreaterOrEqual(m_, (int?)30);
			var o_ = context.Operators.And(g_, n_);
			var p_ = this.latest(context, HPVTest?.Effective);
			var q_ = this.Measurement_Period(context);
			var r_ = context.Operators.End(q_);
			var s_ = context.Operators.Quantity(5m, "years");
			var t_ = context.Operators.Subtract(r_, s_);
			var v_ = context.Operators.End(q_);
			var w_ = context.Operators.Interval(t_, v_, true, true);
			var x_ = context.Operators.ElementInInterval<CqlDateTime>(p_, w_, null);
			var z_ = context.Operators.End(q_);
			var aa_ = context.Operators.Not((bool?)(z_ is null));
			var ab_ = context.Operators.And(x_, aa_);
			var ac_ = context.Operators.And(o_, ab_);
			var ad_ = context.Operators.Not((bool?)(HPVTest?.Value is null));
			var ae_ = context.Operators.And(ac_, ad_);

			return ae_;
		};
		var d_ = context.Operators.WhereOrNull<Observation>(b_, c_);

		return d_;
	}

}