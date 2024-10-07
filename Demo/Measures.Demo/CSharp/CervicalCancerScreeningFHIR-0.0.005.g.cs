using System;
using System.Linq;
using System.Collections.Generic;
using Hl7.Cql.Runtime;
using Hl7.Cql.Primitives;
using Hl7.Cql.Abstractions;
using Hl7.Cql.ValueSets;
using Hl7.Cql.Iso8601;
using System.Reflection;
using Hl7.Fhir.Model;
using Range = Hl7.Fhir.Model.Range;
using Task = Hl7.Fhir.Model.Task;
[System.CodeDom.Compiler.GeneratedCode(".NET Code Generation", "2.0.4.0")]
[CqlLibrary("CervicalCancerScreeningFHIR", "0.0.005")]
public partial class CervicalCancerScreeningFHIR_0_0_005 : ISingleton<CervicalCancerScreeningFHIR_0_0_005>
{
    private CervicalCancerScreeningFHIR_0_0_005() {}

    public static CervicalCancerScreeningFHIR_0_0_005 Instance { get; } = new();


    [CqlDeclaration("Congenital or Acquired Absence of Cervix")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.111.12.1016")]
	public CqlValueSet Congenital_or_Acquired_Absence_of_Cervix(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.111.12.1016", default);


    [CqlDeclaration("Home Healthcare Services")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1016")]
	public CqlValueSet Home_Healthcare_Services(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1016", default);


    [CqlDeclaration("HPV Test")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.110.12.1059")]
	public CqlValueSet HPV_Test(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.110.12.1059", default);


    [CqlDeclaration("Hysterectomy with No Residual Cervix")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.198.12.1014")]
	public CqlValueSet Hysterectomy_with_No_Residual_Cervix(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.198.12.1014", default);


    [CqlDeclaration("Office Visit")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1001")]
	public CqlValueSet Office_Visit(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1001", default);


    [CqlDeclaration("Online Assessments")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1089")]
	public CqlValueSet Online_Assessments(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1089", default);


    [CqlDeclaration("Pap Test")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.108.12.1017")]
	public CqlValueSet Pap_Test(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.108.12.1017", default);


    [CqlDeclaration("Preventive Care Services - Established Office Visit, 18 and Up")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1025")]
	public CqlValueSet Preventive_Care_Services___Established_Office_Visit__18_and_Up(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1025", default);


    [CqlDeclaration("Preventive Care Services-Initial Office Visit, 18 and Up")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1023")]
	public CqlValueSet Preventive_Care_Services_Initial_Office_Visit__18_and_Up(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1023", default);


    [CqlDeclaration("Telephone Visits")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1080")]
	public CqlValueSet Telephone_Visits(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1080", default);


    [CqlDeclaration("laboratory")]
	public CqlCode laboratory(CqlContext context) => 
		new CqlCode("laboratory", "http://terminology.hl7.org/CodeSystem/observation-category", default, default);


    [CqlDeclaration("ObservationCategoryCodes")]
	public CqlCode[] ObservationCategoryCodes(CqlContext context)
	{
		CqlCode[] a_ = [
			new CqlCode("laboratory", "http://terminology.hl7.org/CodeSystem/observation-category", default, default),
		];

		return a_;
	}


    [CqlDeclaration("Measurement Period")]
	public CqlInterval<CqlDateTime> Measurement_Period(CqlContext context)
	{
		CqlDateTime a_ = context.Operators.DateTime(2019, 1, 1, 0, 0, 0, 0, default);
		CqlDateTime b_ = context.Operators.DateTime(2020, 1, 1, 0, 0, 0, 0, default);
		CqlInterval<CqlDateTime> c_ = context.Operators.Interval(a_, b_, true, false);
		object d_ = context.ResolveParameter("CervicalCancerScreeningFHIR-0.0.005", "Measurement Period", c_);

		return (CqlInterval<CqlDateTime>)d_;
	}


    [CqlDeclaration("Patient")]
	public Patient Patient(CqlContext context)
	{
		IEnumerable<Patient> a_ = context.Operators.RetrieveByValueSet<Patient>(default, default);
		Patient b_ = context.Operators.SingletonFrom<Patient>(a_);

		return b_;
	}


    [CqlDeclaration("SDE Ethnicity")]
	public IEnumerable<Coding> SDE_Ethnicity(CqlContext context)
	{
		IEnumerable<Coding> a_ = SupplementalDataElementsFHIR4_2_0_000.Instance.SDE_Ethnicity(context);

		return a_;
	}


    [CqlDeclaration("SDE Payer")]
	public IEnumerable<(CodeableConcept code, Period period)?> SDE_Payer(CqlContext context)
	{
		IEnumerable<(CodeableConcept code, Period period)?> a_ = SupplementalDataElementsFHIR4_2_0_000.Instance.SDE_Payer(context);

		return a_;
	}


    [CqlDeclaration("SDE Race")]
	public IEnumerable<Coding> SDE_Race(CqlContext context)
	{
		IEnumerable<Coding> a_ = SupplementalDataElementsFHIR4_2_0_000.Instance.SDE_Race(context);

		return a_;
	}


    [CqlDeclaration("SDE Sex")]
	public CqlCode SDE_Sex(CqlContext context)
	{
		CqlCode a_ = SupplementalDataElementsFHIR4_2_0_000.Instance.SDE_Sex(context);

		return a_;
	}


    [CqlDeclaration("Qualifying Encounters")]
	public IEnumerable<Encounter> Qualifying_Encounters(CqlContext context)
	{
		CqlValueSet a_ = this.Office_Visit(context);
		IEnumerable<Encounter> b_ = context.Operators.RetrieveByValueSet<Encounter>(a_, default);
		CqlValueSet c_ = this.Preventive_Care_Services___Established_Office_Visit__18_and_Up(context);
		IEnumerable<Encounter> d_ = context.Operators.RetrieveByValueSet<Encounter>(c_, default);
		IEnumerable<Encounter> e_ = context.Operators.Union<Encounter>(b_, d_);
		CqlValueSet f_ = this.Preventive_Care_Services_Initial_Office_Visit__18_and_Up(context);
		IEnumerable<Encounter> g_ = context.Operators.RetrieveByValueSet<Encounter>(f_, default);
		CqlValueSet h_ = this.Home_Healthcare_Services(context);
		IEnumerable<Encounter> i_ = context.Operators.RetrieveByValueSet<Encounter>(h_, default);
		IEnumerable<Encounter> j_ = context.Operators.Union<Encounter>(g_, i_);
		IEnumerable<Encounter> k_ = context.Operators.Union<Encounter>(e_, j_);
		CqlValueSet l_ = this.Telephone_Visits(context);
		IEnumerable<Encounter> m_ = context.Operators.RetrieveByValueSet<Encounter>(l_, default);
		CqlValueSet n_ = this.Online_Assessments(context);
		IEnumerable<Encounter> o_ = context.Operators.RetrieveByValueSet<Encounter>(n_, default);
		IEnumerable<Encounter> p_ = context.Operators.Union<Encounter>(m_, o_);
		IEnumerable<Encounter> q_ = context.Operators.Union<Encounter>(k_, p_);
		bool? r_(Encounter ValidEncounter)
		{
			Code<Encounter.EncounterStatus> t_ = ValidEncounter?.StatusElement;
			string u_ = FHIRHelpers_4_0_001.Instance.ToString(context, t_);
			bool? v_ = context.Operators.Equal(u_, "finished");
			CqlInterval<CqlDateTime> w_ = this.Measurement_Period(context);
			Period x_ = ValidEncounter?.Period;
			CqlInterval<CqlDateTime> y_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, x_);
			bool? z_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(w_, y_, default);
			bool? aa_ = context.Operators.And(v_, z_);

			return aa_;
		};
		IEnumerable<Encounter> s_ = context.Operators.Where<Encounter>(q_, r_);

		return s_;
	}


    [CqlDeclaration("Initial Population")]
	public bool? Initial_Population(CqlContext context)
	{
		Patient a_ = this.Patient(context);
		Date b_ = a_?.BirthDateElement;
		string c_ = b_?.Value;
		CqlDate d_ = context.Operators.ConvertStringToDate(c_);
		CqlInterval<CqlDateTime> e_ = this.Measurement_Period(context);
		CqlDateTime f_ = context.Operators.Start(e_);
		CqlDate g_ = context.Operators.DateFrom(f_);
		int? h_ = context.Operators.CalculateAgeAt(d_, g_, "year");
		CqlInterval<int?> i_ = context.Operators.Interval(23, 64, true, false);
		bool? j_ = context.Operators.In<int?>(h_, i_, default);
		Code<AdministrativeGender> l_ = a_?.GenderElement;
		string m_ = FHIRHelpers_4_0_001.Instance.ToString(context, l_);
		bool? n_ = context.Operators.Equal(m_, "female");
		bool? o_ = context.Operators.And(j_, n_);
		IEnumerable<Encounter> p_ = this.Qualifying_Encounters(context);
		bool? q_ = context.Operators.Exists<Encounter>(p_);
		bool? r_ = context.Operators.And(o_, q_);

		return r_;
	}


    [CqlDeclaration("Denominator")]
	public bool? Denominator(CqlContext context)
	{
		bool? a_ = this.Initial_Population(context);

		return a_;
	}


    [CqlDeclaration("Absence of Cervix")]
	public IEnumerable<object> Absence_of_Cervix(CqlContext context)
	{
		CqlValueSet a_ = this.Hysterectomy_with_No_Residual_Cervix(context);
		IEnumerable<Procedure> b_ = context.Operators.RetrieveByValueSet<Procedure>(a_, default);
		bool? c_(Procedure NoCervixProcedure)
		{
			Code<EventStatus> j_ = NoCervixProcedure?.StatusElement;
			string k_ = FHIRHelpers_4_0_001.Instance.ToString(context, j_);
			bool? l_ = context.Operators.Equal(k_, "completed");
			DataType m_ = NoCervixProcedure?.Performed;
			CqlInterval<CqlDateTime> n_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, m_);
			CqlDateTime o_ = context.Operators.End(n_);
			CqlInterval<CqlDateTime> p_ = this.Measurement_Period(context);
			CqlDateTime q_ = context.Operators.End(p_);
			bool? r_ = context.Operators.SameOrBefore(o_, q_, default);
			bool? s_ = context.Operators.And(l_, r_);

			return s_;
		};
		IEnumerable<Procedure> d_ = context.Operators.Where<Procedure>(b_, c_);
		CqlValueSet e_ = this.Congenital_or_Acquired_Absence_of_Cervix(context);
		IEnumerable<Condition> f_ = context.Operators.RetrieveByValueSet<Condition>(e_, default);
		bool? g_(Condition NoCervixDiagnosis)
		{
			CqlInterval<CqlDateTime> t_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Prevalence_Period(context, NoCervixDiagnosis);
			CqlDateTime u_ = context.Operators.Start(t_);
			CqlInterval<CqlDateTime> v_ = this.Measurement_Period(context);
			CqlDateTime w_ = context.Operators.End(v_);
			bool? x_ = context.Operators.SameOrBefore(u_, w_, default);

			return x_;
		};
		IEnumerable<Condition> h_ = context.Operators.Where<Condition>(f_, g_);
		IEnumerable<object> i_ = context.Operators.Union<object>(d_ as IEnumerable<object>, h_ as IEnumerable<object>);

		return i_;
	}


    [CqlDeclaration("Denominator Exclusions")]
	public bool? Denominator_Exclusions(CqlContext context)
	{
		bool? a_ = HospiceFHIR4_2_3_000.Instance.Has_Hospice(context);
		IEnumerable<object> b_ = this.Absence_of_Cervix(context);
		bool? c_ = context.Operators.Exists<object>(b_);
		bool? d_ = context.Operators.Or(a_, c_);
		bool? e_ = PalliativeCareFHIR_0_6_000.Instance.Palliative_Care_in_the_Measurement_Period(context);
		bool? f_ = context.Operators.Or(d_, e_);

		return f_;
	}


    [CqlDeclaration("Cervical Cytology Within 3 Years")]
	public IEnumerable<Observation> Cervical_Cytology_Within_3_Years(CqlContext context)
	{
		CqlValueSet a_ = this.Pap_Test(context);
		IEnumerable<Observation> b_ = context.Operators.RetrieveByValueSet<Observation>(a_, default);
		bool? c_(Observation CervicalCytology)
		{
			Code<ObservationStatus> e_ = CervicalCytology?.StatusElement;
			string f_ = FHIRHelpers_4_0_001.Instance.ToString(context, e_);
			string[] g_ = [
				"final",
				"amended",
				"corrected",
			];
			bool? h_ = context.Operators.In<string>(f_, g_ as IEnumerable<string>);
			List<CodeableConcept> i_ = CervicalCytology?.Category;
			bool? j_(CodeableConcept CervicalCytologyCategory)
			{
				CqlCode af_ = this.laboratory(context);
				CqlConcept ag_ = FHIRHelpers_4_0_001.Instance.ToConcept(context, CervicalCytologyCategory);
				CqlCode[] ah_ = ag_?.codes;
				bool? ai_ = context.Operators.In<CqlCode>(af_, (IEnumerable<CqlCode>)ah_);

				return ai_;
			};
			IEnumerable<CodeableConcept> k_ = context.Operators.Where<CodeableConcept>((IEnumerable<CodeableConcept>)i_, j_);
			bool? l_ = context.Operators.Exists<CodeableConcept>(k_);
			bool? m_ = context.Operators.And(h_, l_);
			DataType n_ = CervicalCytology?.Effective;
			CqlDateTime o_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Latest(context, n_);
			CqlInterval<CqlDateTime> p_ = this.Measurement_Period(context);
			CqlDateTime q_ = context.Operators.End(p_);
			CqlQuantity r_ = context.Operators.Quantity(3m, "years");
			CqlDateTime s_ = context.Operators.Subtract(q_, r_);
			CqlDateTime u_ = context.Operators.End(p_);
			CqlInterval<CqlDateTime> v_ = context.Operators.Interval(s_, u_, true, true);
			bool? w_ = context.Operators.In<CqlDateTime>(o_, v_, default);
			CqlDateTime y_ = context.Operators.End(p_);
			bool? z_ = context.Operators.Not((bool?)(y_ is null));
			bool? aa_ = context.Operators.And(w_, z_);
			bool? ab_ = context.Operators.And(m_, aa_);
			DataType ac_ = CervicalCytology?.Value;
			bool? ad_ = context.Operators.Not((bool?)(ac_ is null));
			bool? ae_ = context.Operators.And(ab_, ad_);

			return ae_;
		};
		IEnumerable<Observation> d_ = context.Operators.Where<Observation>(b_, c_);

		return d_;
	}


    [CqlDeclaration("HPV Test Within 5 Years for Women Age 30 and Older")]
	public IEnumerable<Observation> HPV_Test_Within_5_Years_for_Women_Age_30_and_Older(CqlContext context)
	{
		CqlValueSet a_ = this.HPV_Test(context);
		IEnumerable<Observation> b_ = context.Operators.RetrieveByValueSet<Observation>(a_, default);
		bool? c_(Observation HPVTest)
		{
			Code<ObservationStatus> e_ = HPVTest?.StatusElement;
			string f_ = FHIRHelpers_4_0_001.Instance.ToString(context, e_);
			string[] g_ = [
				"final",
				"amended",
				"corrected",
			];
			bool? h_ = context.Operators.In<string>(f_, g_ as IEnumerable<string>);
			List<CodeableConcept> i_ = HPVTest?.Category;
			bool? j_(CodeableConcept HPVTestCategory)
			{
				CqlCode aq_ = this.laboratory(context);
				CqlConcept ar_ = FHIRHelpers_4_0_001.Instance.ToConcept(context, HPVTestCategory);
				CqlCode[] as_ = ar_?.codes;
				bool? at_ = context.Operators.In<CqlCode>(aq_, (IEnumerable<CqlCode>)as_);

				return at_;
			};
			IEnumerable<CodeableConcept> k_ = context.Operators.Where<CodeableConcept>((IEnumerable<CodeableConcept>)i_, j_);
			bool? l_ = context.Operators.Exists<CodeableConcept>(k_);
			bool? m_ = context.Operators.And(h_, l_);
			Patient n_ = this.Patient(context);
			Date o_ = n_?.BirthDateElement;
			string p_ = o_?.Value;
			CqlDate q_ = context.Operators.ConvertStringToDate(p_);
			DataType r_ = HPVTest?.Effective;
			CqlInterval<CqlDateTime> s_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, r_);
			CqlDateTime t_ = context.Operators.Start(s_);
			CqlDate u_ = context.Operators.DateFrom(t_);
			int? v_ = context.Operators.CalculateAgeAt(q_, u_, "year");
			bool? w_ = context.Operators.GreaterOrEqual(v_, 30);
			bool? x_ = context.Operators.And(m_, w_);
			CqlDateTime z_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Latest(context, r_);
			CqlInterval<CqlDateTime> aa_ = this.Measurement_Period(context);
			CqlDateTime ab_ = context.Operators.End(aa_);
			CqlQuantity ac_ = context.Operators.Quantity(5m, "years");
			CqlDateTime ad_ = context.Operators.Subtract(ab_, ac_);
			CqlDateTime af_ = context.Operators.End(aa_);
			CqlInterval<CqlDateTime> ag_ = context.Operators.Interval(ad_, af_, true, true);
			bool? ah_ = context.Operators.In<CqlDateTime>(z_, ag_, default);
			CqlDateTime aj_ = context.Operators.End(aa_);
			bool? ak_ = context.Operators.Not((bool?)(aj_ is null));
			bool? al_ = context.Operators.And(ah_, ak_);
			bool? am_ = context.Operators.And(x_, al_);
			DataType an_ = HPVTest?.Value;
			bool? ao_ = context.Operators.Not((bool?)(an_ is null));
			bool? ap_ = context.Operators.And(am_, ao_);

			return ap_;
		};
		IEnumerable<Observation> d_ = context.Operators.Where<Observation>(b_, c_);

		return d_;
	}


    [CqlDeclaration("Numerator")]
	public bool? Numerator(CqlContext context)
	{
		IEnumerable<Observation> a_ = this.Cervical_Cytology_Within_3_Years(context);
		bool? b_ = context.Operators.Exists<Observation>(a_);
		IEnumerable<Observation> c_ = this.HPV_Test_Within_5_Years_for_Women_Age_30_and_Older(context);
		bool? d_ = context.Operators.Exists<Observation>(c_);
		bool? e_ = context.Operators.Or(b_, d_);

		return e_;
	}

	public bool? isComplete(CqlContext context, Observation observation)
	{
		Code<ObservationStatus> a_ = observation?.StatusElement;
		string b_ = FHIRHelpers_4_0_001.Instance.ToString(context, a_);
		string[] c_ = [
			"final",
			"amended",
			"corrected",
		];
		bool? d_ = context.Operators.In<string>(b_, c_ as IEnumerable<string>);

		return d_;
	}

	public bool? isLaboratoryTest(CqlContext context, Observation observation)
	{
		List<CodeableConcept> a_ = observation?.Category;
		bool? b_(CodeableConcept category)
		{
			CqlCode e_ = this.laboratory(context);
			CqlConcept f_ = FHIRHelpers_4_0_001.Instance.ToConcept(context, category);
			CqlCode[] g_ = f_?.codes;
			bool? h_ = context.Operators.In<CqlCode>(e_, (IEnumerable<CqlCode>)g_);

			return h_;
		};
		IEnumerable<CodeableConcept> c_ = context.Operators.Where<CodeableConcept>((IEnumerable<CodeableConcept>)a_, b_);
		bool? d_ = context.Operators.Exists<CodeableConcept>(c_);

		return d_;
	}

	public CqlDateTime latest(CqlContext context, object choice)
	{
		CqlDateTime a_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Latest(context, choice);

		return a_;
	}


    [CqlDeclaration("Cervical Cytology Within 3 Years (2)")]
	public IEnumerable<Observation> Cervical_Cytology_Within_3_Years__2_(CqlContext context)
	{
		CqlValueSet a_ = this.Pap_Test(context);
		IEnumerable<Observation> b_ = context.Operators.RetrieveByValueSet<Observation>(a_, default);
		bool? c_(Observation CervicalCytology)
		{
			bool? e_ = this.isComplete(context, CervicalCytology);
			bool? f_ = this.isLaboratoryTest(context, CervicalCytology);
			bool? g_ = context.Operators.And(e_, f_);
			DataType h_ = CervicalCytology?.Effective;
			CqlDateTime i_ = this.latest(context, h_);
			CqlInterval<CqlDateTime> j_ = this.Measurement_Period(context);
			CqlDateTime k_ = context.Operators.End(j_);
			CqlQuantity l_ = context.Operators.Quantity(3m, "years");
			CqlDateTime m_ = context.Operators.Subtract(k_, l_);
			CqlDateTime o_ = context.Operators.End(j_);
			CqlInterval<CqlDateTime> p_ = context.Operators.Interval(m_, o_, true, true);
			bool? q_ = context.Operators.In<CqlDateTime>(i_, p_, default);
			CqlDateTime s_ = context.Operators.End(j_);
			bool? t_ = context.Operators.Not((bool?)(s_ is null));
			bool? u_ = context.Operators.And(q_, t_);
			bool? v_ = context.Operators.And(g_, u_);
			DataType w_ = CervicalCytology?.Value;
			bool? x_ = context.Operators.Not((bool?)(w_ is null));
			bool? y_ = context.Operators.And(v_, x_);

			return y_;
		};
		IEnumerable<Observation> d_ = context.Operators.Where<Observation>(b_, c_);

		return d_;
	}

	public CqlInterval<CqlDateTime> toInterval(CqlContext context, object choice)
	{
		CqlInterval<CqlDateTime> a_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, choice);

		return a_;
	}


    [CqlDeclaration("HPV Test Within 5 Years for Women Age 30 and Older (2)")]
	public IEnumerable<Observation> HPV_Test_Within_5_Years_for_Women_Age_30_and_Older__2_(CqlContext context)
	{
		CqlValueSet a_ = this.HPV_Test(context);
		IEnumerable<Observation> b_ = context.Operators.RetrieveByValueSet<Observation>(a_, default);
		bool? c_(Observation HPVTest)
		{
			bool? e_ = this.isComplete(context, HPVTest);
			bool? f_ = this.isLaboratoryTest(context, HPVTest);
			bool? g_ = context.Operators.And(e_, f_);
			Patient h_ = this.Patient(context);
			Date i_ = h_?.BirthDateElement;
			string j_ = i_?.Value;
			CqlDate k_ = context.Operators.ConvertStringToDate(j_);
			DataType l_ = HPVTest?.Effective;
			CqlInterval<CqlDateTime> m_ = this.toInterval(context, l_);
			CqlDateTime n_ = context.Operators.Start(m_);
			CqlDate o_ = context.Operators.DateFrom(n_);
			int? p_ = context.Operators.CalculateAgeAt(k_, o_, "year");
			bool? q_ = context.Operators.GreaterOrEqual(p_, 30);
			bool? r_ = context.Operators.And(g_, q_);
			CqlDateTime t_ = this.latest(context, l_);
			CqlInterval<CqlDateTime> u_ = this.Measurement_Period(context);
			CqlDateTime v_ = context.Operators.End(u_);
			CqlQuantity w_ = context.Operators.Quantity(5m, "years");
			CqlDateTime x_ = context.Operators.Subtract(v_, w_);
			CqlDateTime z_ = context.Operators.End(u_);
			CqlInterval<CqlDateTime> aa_ = context.Operators.Interval(x_, z_, true, true);
			bool? ab_ = context.Operators.In<CqlDateTime>(t_, aa_, default);
			CqlDateTime ad_ = context.Operators.End(u_);
			bool? ae_ = context.Operators.Not((bool?)(ad_ is null));
			bool? af_ = context.Operators.And(ab_, ae_);
			bool? ag_ = context.Operators.And(r_, af_);
			DataType ah_ = HPVTest?.Value;
			bool? ai_ = context.Operators.Not((bool?)(ah_ is null));
			bool? aj_ = context.Operators.And(ag_, ai_);

			return aj_;
		};
		IEnumerable<Observation> d_ = context.Operators.Where<Observation>(b_, c_);

		return d_;
	}

}
