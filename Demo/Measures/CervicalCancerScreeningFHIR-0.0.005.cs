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
[System.CodeDom.Compiler.GeneratedCode(".NET Code Generation", "0.9.0.0")]
[CqlLibrary("CervicalCancerScreeningFHIR", "0.0.005")]
public class CervicalCancerScreeningFHIR_0_0_005
{


    internal CqlContext context;

    #region Cached values

    internal Lazy<CqlValueSet> __Congenital_or_Acquired_Absence_of_Cervix;
    internal Lazy<CqlValueSet> __Home_Healthcare_Services;
    internal Lazy<CqlValueSet> __HPV_Test;
    internal Lazy<CqlValueSet> __Hysterectomy_with_No_Residual_Cervix;
    internal Lazy<CqlValueSet> __Office_Visit;
    internal Lazy<CqlValueSet> __Online_Assessments;
    internal Lazy<CqlValueSet> __Pap_Test;
    internal Lazy<CqlValueSet> __Preventive_Care_Services___Established_Office_Visit__18_and_Up;
    internal Lazy<CqlValueSet> __Preventive_Care_Services_Initial_Office_Visit__18_and_Up;
    internal Lazy<CqlValueSet> __Telephone_Visits;
    internal Lazy<CqlCode> __laboratory;
    internal Lazy<CqlCode[]> __ObservationCategoryCodes;
    internal Lazy<CqlInterval<CqlDateTime>> __Measurement_Period;
    internal Lazy<Patient> __Patient;
    internal Lazy<IEnumerable<Coding>> __SDE_Ethnicity;
    internal Lazy<IEnumerable<Tuples.Tuple_CFQHSgYJOXjAOCKdWLdZNNHDG>> __SDE_Payer;
    internal Lazy<IEnumerable<Coding>> __SDE_Race;
    internal Lazy<CqlCode> __SDE_Sex;
    internal Lazy<IEnumerable<Encounter>> __Qualifying_Encounters;
    internal Lazy<bool?> __Initial_Population;
    internal Lazy<bool?> __Denominator;
    internal Lazy<IEnumerable<object>> __Absence_of_Cervix;
    internal Lazy<bool?> __Denominator_Exclusions;
    internal Lazy<IEnumerable<Observation>> __Cervical_Cytology_Within_3_Years;
    internal Lazy<IEnumerable<Observation>> __HPV_Test_Within_5_Years_for_Women_Age_30_and_Older;
    internal Lazy<bool?> __Numerator;
    internal Lazy<IEnumerable<Observation>> __Cervical_Cytology_Within_3_Years__2_;
    internal Lazy<IEnumerable<Observation>> __HPV_Test_Within_5_Years_for_Women_Age_30_and_Older__2_;

    #endregion
    public CervicalCancerScreeningFHIR_0_0_005(CqlContext context)
    {
        this.context = context ?? throw new ArgumentNullException("context");

        FHIRHelpers_4_0_001 = new FHIRHelpers_4_0_001(context);
        SupplementalDataElementsFHIR4_2_0_000 = new SupplementalDataElementsFHIR4_2_0_000(context);
        MATGlobalCommonFunctionsFHIR4_6_1_000 = new MATGlobalCommonFunctionsFHIR4_6_1_000(context);
        HospiceFHIR4_2_3_000 = new HospiceFHIR4_2_3_000(context);
        PalliativeCareFHIR_0_6_000 = new PalliativeCareFHIR_0_6_000(context);

        __Congenital_or_Acquired_Absence_of_Cervix = new Lazy<CqlValueSet>(this.Congenital_or_Acquired_Absence_of_Cervix_Value);
        __Home_Healthcare_Services = new Lazy<CqlValueSet>(this.Home_Healthcare_Services_Value);
        __HPV_Test = new Lazy<CqlValueSet>(this.HPV_Test_Value);
        __Hysterectomy_with_No_Residual_Cervix = new Lazy<CqlValueSet>(this.Hysterectomy_with_No_Residual_Cervix_Value);
        __Office_Visit = new Lazy<CqlValueSet>(this.Office_Visit_Value);
        __Online_Assessments = new Lazy<CqlValueSet>(this.Online_Assessments_Value);
        __Pap_Test = new Lazy<CqlValueSet>(this.Pap_Test_Value);
        __Preventive_Care_Services___Established_Office_Visit__18_and_Up = new Lazy<CqlValueSet>(this.Preventive_Care_Services___Established_Office_Visit__18_and_Up_Value);
        __Preventive_Care_Services_Initial_Office_Visit__18_and_Up = new Lazy<CqlValueSet>(this.Preventive_Care_Services_Initial_Office_Visit__18_and_Up_Value);
        __Telephone_Visits = new Lazy<CqlValueSet>(this.Telephone_Visits_Value);
        __laboratory = new Lazy<CqlCode>(this.laboratory_Value);
        __ObservationCategoryCodes = new Lazy<CqlCode[]>(this.ObservationCategoryCodes_Value);
        __Measurement_Period = new Lazy<CqlInterval<CqlDateTime>>(this.Measurement_Period_Value);
        __Patient = new Lazy<Patient>(this.Patient_Value);
        __SDE_Ethnicity = new Lazy<IEnumerable<Coding>>(this.SDE_Ethnicity_Value);
        __SDE_Payer = new Lazy<IEnumerable<Tuples.Tuple_CFQHSgYJOXjAOCKdWLdZNNHDG>>(this.SDE_Payer_Value);
        __SDE_Race = new Lazy<IEnumerable<Coding>>(this.SDE_Race_Value);
        __SDE_Sex = new Lazy<CqlCode>(this.SDE_Sex_Value);
        __Qualifying_Encounters = new Lazy<IEnumerable<Encounter>>(this.Qualifying_Encounters_Value);
        __Initial_Population = new Lazy<bool?>(this.Initial_Population_Value);
        __Denominator = new Lazy<bool?>(this.Denominator_Value);
        __Absence_of_Cervix = new Lazy<IEnumerable<object>>(this.Absence_of_Cervix_Value);
        __Denominator_Exclusions = new Lazy<bool?>(this.Denominator_Exclusions_Value);
        __Cervical_Cytology_Within_3_Years = new Lazy<IEnumerable<Observation>>(this.Cervical_Cytology_Within_3_Years_Value);
        __HPV_Test_Within_5_Years_for_Women_Age_30_and_Older = new Lazy<IEnumerable<Observation>>(this.HPV_Test_Within_5_Years_for_Women_Age_30_and_Older_Value);
        __Numerator = new Lazy<bool?>(this.Numerator_Value);
        __Cervical_Cytology_Within_3_Years__2_ = new Lazy<IEnumerable<Observation>>(this.Cervical_Cytology_Within_3_Years__2__Value);
        __HPV_Test_Within_5_Years_for_Women_Age_30_and_Older__2_ = new Lazy<IEnumerable<Observation>>(this.HPV_Test_Within_5_Years_for_Women_Age_30_and_Older__2__Value);
    }
    #region Dependencies

    public FHIRHelpers_4_0_001 FHIRHelpers_4_0_001 { get; }
    public SupplementalDataElementsFHIR4_2_0_000 SupplementalDataElementsFHIR4_2_0_000 { get; }
    public MATGlobalCommonFunctionsFHIR4_6_1_000 MATGlobalCommonFunctionsFHIR4_6_1_000 { get; }
    public HospiceFHIR4_2_3_000 HospiceFHIR4_2_3_000 { get; }
    public PalliativeCareFHIR_0_6_000 PalliativeCareFHIR_0_6_000 { get; }

    #endregion

	private CqlValueSet Congenital_or_Acquired_Absence_of_Cervix_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.111.12.1016", null);

    [CqlDeclaration("Congenital or Acquired Absence of Cervix")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.111.12.1016")]
	public CqlValueSet Congenital_or_Acquired_Absence_of_Cervix() => 
		__Congenital_or_Acquired_Absence_of_Cervix.Value;

	private CqlValueSet Home_Healthcare_Services_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1016", null);

    [CqlDeclaration("Home Healthcare Services")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1016")]
	public CqlValueSet Home_Healthcare_Services() => 
		__Home_Healthcare_Services.Value;

	private CqlValueSet HPV_Test_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.110.12.1059", null);

    [CqlDeclaration("HPV Test")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.110.12.1059")]
	public CqlValueSet HPV_Test() => 
		__HPV_Test.Value;

	private CqlValueSet Hysterectomy_with_No_Residual_Cervix_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.198.12.1014", null);

    [CqlDeclaration("Hysterectomy with No Residual Cervix")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.198.12.1014")]
	public CqlValueSet Hysterectomy_with_No_Residual_Cervix() => 
		__Hysterectomy_with_No_Residual_Cervix.Value;

	private CqlValueSet Office_Visit_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1001", null);

    [CqlDeclaration("Office Visit")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1001")]
	public CqlValueSet Office_Visit() => 
		__Office_Visit.Value;

	private CqlValueSet Online_Assessments_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1089", null);

    [CqlDeclaration("Online Assessments")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1089")]
	public CqlValueSet Online_Assessments() => 
		__Online_Assessments.Value;

	private CqlValueSet Pap_Test_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.108.12.1017", null);

    [CqlDeclaration("Pap Test")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.108.12.1017")]
	public CqlValueSet Pap_Test() => 
		__Pap_Test.Value;

	private CqlValueSet Preventive_Care_Services___Established_Office_Visit__18_and_Up_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1025", null);

    [CqlDeclaration("Preventive Care Services - Established Office Visit, 18 and Up")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1025")]
	public CqlValueSet Preventive_Care_Services___Established_Office_Visit__18_and_Up() => 
		__Preventive_Care_Services___Established_Office_Visit__18_and_Up.Value;

	private CqlValueSet Preventive_Care_Services_Initial_Office_Visit__18_and_Up_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1023", null);

    [CqlDeclaration("Preventive Care Services-Initial Office Visit, 18 and Up")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1023")]
	public CqlValueSet Preventive_Care_Services_Initial_Office_Visit__18_and_Up() => 
		__Preventive_Care_Services_Initial_Office_Visit__18_and_Up.Value;

	private CqlValueSet Telephone_Visits_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1080", null);

    [CqlDeclaration("Telephone Visits")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1080")]
	public CqlValueSet Telephone_Visits() => 
		__Telephone_Visits.Value;

	private CqlCode laboratory_Value() => 
		new CqlCode("laboratory", "http://terminology.hl7.org/CodeSystem/observation-category", null, null);

    [CqlDeclaration("laboratory")]
	public CqlCode laboratory() => 
		__laboratory.Value;

	private CqlCode[] ObservationCategoryCodes_Value()
	{
		var a_ = new CqlCode[]
		{
			new CqlCode("laboratory", "http://terminology.hl7.org/CodeSystem/observation-category", null, null),
		};

		return a_;
	}

    [CqlDeclaration("ObservationCategoryCodes")]
	public CqlCode[] ObservationCategoryCodes() => 
		__ObservationCategoryCodes.Value;

	private CqlInterval<CqlDateTime> Measurement_Period_Value()
	{
		var a_ = context.Operators.ConvertIntegerToDecimal(default);
		var b_ = context.Operators.DateTime((int?)2019, (int?)1, (int?)1, (int?)0, (int?)0, (int?)0, (int?)0, a_);
		var d_ = context.Operators.DateTime((int?)2020, (int?)1, (int?)1, (int?)0, (int?)0, (int?)0, (int?)0, a_);
		var e_ = context.Operators.Interval(b_, d_, true, false);
		var f_ = context.ResolveParameter("CervicalCancerScreeningFHIR-0.0.005", "Measurement Period", e_);

		return (CqlInterval<CqlDateTime>)f_;
	}

    [CqlDeclaration("Measurement Period")]
	public CqlInterval<CqlDateTime> Measurement_Period() => 
		__Measurement_Period.Value;

	private Patient Patient_Value()
	{
		var a_ = context.Operators.RetrieveByValueSet<Patient>(null, null);
		var b_ = context.Operators.SingleOrNull<Patient>(a_);

		return b_;
	}

    [CqlDeclaration("Patient")]
	public Patient Patient() => 
		__Patient.Value;

	private IEnumerable<Coding> SDE_Ethnicity_Value()
	{
		var a_ = SupplementalDataElementsFHIR4_2_0_000.SDE_Ethnicity();

		return a_;
	}

    [CqlDeclaration("SDE Ethnicity")]
	public IEnumerable<Coding> SDE_Ethnicity() => 
		__SDE_Ethnicity.Value;

	private IEnumerable<Tuples.Tuple_CFQHSgYJOXjAOCKdWLdZNNHDG> SDE_Payer_Value()
	{
		var a_ = SupplementalDataElementsFHIR4_2_0_000.SDE_Payer();

		return a_;
	}

    [CqlDeclaration("SDE Payer")]
	public IEnumerable<Tuples.Tuple_CFQHSgYJOXjAOCKdWLdZNNHDG> SDE_Payer() => 
		__SDE_Payer.Value;

	private IEnumerable<Coding> SDE_Race_Value()
	{
		var a_ = SupplementalDataElementsFHIR4_2_0_000.SDE_Race();

		return a_;
	}

    [CqlDeclaration("SDE Race")]
	public IEnumerable<Coding> SDE_Race() => 
		__SDE_Race.Value;

	private CqlCode SDE_Sex_Value()
	{
		var a_ = SupplementalDataElementsFHIR4_2_0_000.SDE_Sex();

		return a_;
	}

    [CqlDeclaration("SDE Sex")]
	public CqlCode SDE_Sex() => 
		__SDE_Sex.Value;

	private IEnumerable<Encounter> Qualifying_Encounters_Value()
	{
		var a_ = this.Office_Visit();
		var b_ = context.Operators.RetrieveByValueSet<Encounter>(a_, null);
		var c_ = this.Preventive_Care_Services___Established_Office_Visit__18_and_Up();
		var d_ = context.Operators.RetrieveByValueSet<Encounter>(c_, null);
		var e_ = context.Operators.ListUnion<Encounter>(b_, d_);
		var f_ = this.Preventive_Care_Services_Initial_Office_Visit__18_and_Up();
		var g_ = context.Operators.RetrieveByValueSet<Encounter>(f_, null);
		var h_ = this.Home_Healthcare_Services();
		var i_ = context.Operators.RetrieveByValueSet<Encounter>(h_, null);
		var j_ = context.Operators.ListUnion<Encounter>(g_, i_);
		var k_ = context.Operators.ListUnion<Encounter>(e_, j_);
		var l_ = this.Telephone_Visits();
		var m_ = context.Operators.RetrieveByValueSet<Encounter>(l_, null);
		var n_ = this.Online_Assessments();
		var o_ = context.Operators.RetrieveByValueSet<Encounter>(n_, null);
		var p_ = context.Operators.ListUnion<Encounter>(m_, o_);
		var q_ = context.Operators.ListUnion<Encounter>(k_, p_);
		bool? r_(Encounter ValidEncounter)
		{
			var t_ = ValidEncounter?.StatusElement;
			var u_ = context.Operators.Convert<string>(t_);
			var v_ = context.Operators.Equal(u_, "finished");
			var w_ = this.Measurement_Period();
			var x_ = ValidEncounter?.Period;
			var y_ = FHIRHelpers_4_0_001.ToInterval(x_);
			var z_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(w_, y_, null);
			var aa_ = context.Operators.And(v_, z_);

			return aa_;
		};
		var s_ = context.Operators.WhereOrNull<Encounter>(q_, r_);

		return s_;
	}

    [CqlDeclaration("Qualifying Encounters")]
	public IEnumerable<Encounter> Qualifying_Encounters() => 
		__Qualifying_Encounters.Value;

	private bool? Initial_Population_Value()
	{
		var a_ = this.Patient();
		var b_ = a_?.BirthDateElement;
		var c_ = b_?.Value;
		var d_ = context.Operators.Convert<CqlDate>(c_);
		var e_ = this.Measurement_Period();
		var f_ = context.Operators.Start(e_);
		var g_ = context.Operators.DateFrom(f_);
		var h_ = context.Operators.CalculateAgeAt(d_, g_, "year");
		var i_ = context.Operators.Interval((int?)23, (int?)64, true, false);
		var j_ = context.Operators.ElementInInterval<int?>(h_, i_, null);
		var l_ = a_?.GenderElement;
		var m_ = context.Operators.Convert<string>(l_);
		var n_ = context.Operators.Equal(m_, "female");
		var o_ = context.Operators.And(j_, n_);
		var p_ = this.Qualifying_Encounters();
		var q_ = context.Operators.ExistsInList<Encounter>(p_);
		var r_ = context.Operators.And(o_, q_);

		return r_;
	}

    [CqlDeclaration("Initial Population")]
	public bool? Initial_Population() => 
		__Initial_Population.Value;

	private bool? Denominator_Value()
	{
		var a_ = this.Initial_Population();

		return a_;
	}

    [CqlDeclaration("Denominator")]
	public bool? Denominator() => 
		__Denominator.Value;

	private IEnumerable<object> Absence_of_Cervix_Value()
	{
		var a_ = this.Hysterectomy_with_No_Residual_Cervix();
		var b_ = context.Operators.RetrieveByValueSet<Procedure>(a_, null);
		bool? c_(Procedure NoCervixProcedure)
		{
			var j_ = NoCervixProcedure?.StatusElement;
			var k_ = context.Operators.Convert<string>(j_);
			var l_ = context.Operators.Equal(k_, "completed");
			var m_ = NoCervixProcedure?.Performed;
			var n_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Normalize_Interval(m_);
			var o_ = context.Operators.End(n_);
			var p_ = this.Measurement_Period();
			var q_ = context.Operators.End(p_);
			var r_ = context.Operators.SameOrBefore(o_, q_, null);
			var s_ = context.Operators.And(l_, r_);

			return s_;
		};
		var d_ = context.Operators.WhereOrNull<Procedure>(b_, c_);
		var e_ = this.Congenital_or_Acquired_Absence_of_Cervix();
		var f_ = context.Operators.RetrieveByValueSet<Condition>(e_, null);
		bool? g_(Condition NoCervixDiagnosis)
		{
			var t_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Prevalence_Period(NoCervixDiagnosis);
			var u_ = context.Operators.Start(t_);
			var v_ = this.Measurement_Period();
			var w_ = context.Operators.End(v_);
			var x_ = context.Operators.SameOrBefore(u_, w_, null);

			return x_;
		};
		var h_ = context.Operators.WhereOrNull<Condition>(f_, g_);
		var i_ = context.Operators.ListUnion<object>((d_ as IEnumerable<object>), (h_ as IEnumerable<object>));

		return i_;
	}

    [CqlDeclaration("Absence of Cervix")]
	public IEnumerable<object> Absence_of_Cervix() => 
		__Absence_of_Cervix.Value;

	private bool? Denominator_Exclusions_Value()
	{
		var a_ = HospiceFHIR4_2_3_000.Has_Hospice();
		var b_ = this.Absence_of_Cervix();
		var c_ = context.Operators.ExistsInList<object>(b_);
		var d_ = context.Operators.Or(a_, c_);
		var e_ = PalliativeCareFHIR_0_6_000.Palliative_Care_in_the_Measurement_Period();
		var f_ = context.Operators.Or(d_, e_);

		return f_;
	}

    [CqlDeclaration("Denominator Exclusions")]
	public bool? Denominator_Exclusions() => 
		__Denominator_Exclusions.Value;

	private IEnumerable<Observation> Cervical_Cytology_Within_3_Years_Value()
	{
		var a_ = this.Pap_Test();
		var b_ = context.Operators.RetrieveByValueSet<Observation>(a_, null);
		bool? c_(Observation CervicalCytology)
		{
			var e_ = CervicalCytology?.StatusElement;
			var f_ = context.Operators.Convert<string>(e_);
			var g_ = new string[]
			{
				"final",
				"amended",
				"corrected",
			};
			var h_ = context.Operators.InList<string>(f_, (g_ as IEnumerable<string>));
			var i_ = CervicalCytology?.Category;
			bool? j_(CodeableConcept CervicalCytologyCategory)
			{
				var af_ = this.laboratory();
				var ag_ = FHIRHelpers_4_0_001.ToConcept(CervicalCytologyCategory);
				var ah_ = ag_?.codes;
				var ai_ = context.Operators.CodeInList(af_, (ah_ as IEnumerable<CqlCode>));

				return ai_;
			};
			var k_ = context.Operators.WhereOrNull<CodeableConcept>((i_ as IEnumerable<CodeableConcept>), j_);
			var l_ = context.Operators.ExistsInList<CodeableConcept>(k_);
			var m_ = context.Operators.And(h_, l_);
			var n_ = CervicalCytology?.Effective;
			var o_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Latest(n_);
			var p_ = this.Measurement_Period();
			var q_ = context.Operators.End(p_);
			var r_ = context.Operators.Quantity(3m, "years");
			var s_ = context.Operators.Subtract(q_, r_);
			var u_ = context.Operators.End(p_);
			var v_ = context.Operators.Interval(s_, u_, true, true);
			var w_ = context.Operators.ElementInInterval<CqlDateTime>(o_, v_, null);
			var y_ = context.Operators.End(p_);
			var z_ = context.Operators.Not((bool?)(y_ is null));
			var aa_ = context.Operators.And(w_, z_);
			var ab_ = context.Operators.And(m_, aa_);
			var ac_ = CervicalCytology?.Value;
			var ad_ = context.Operators.Not((bool?)(ac_ is null));
			var ae_ = context.Operators.And(ab_, ad_);

			return ae_;
		};
		var d_ = context.Operators.WhereOrNull<Observation>(b_, c_);

		return d_;
	}

    [CqlDeclaration("Cervical Cytology Within 3 Years")]
	public IEnumerable<Observation> Cervical_Cytology_Within_3_Years() => 
		__Cervical_Cytology_Within_3_Years.Value;

	private IEnumerable<Observation> HPV_Test_Within_5_Years_for_Women_Age_30_and_Older_Value()
	{
		var a_ = this.HPV_Test();
		var b_ = context.Operators.RetrieveByValueSet<Observation>(a_, null);
		bool? c_(Observation HPVTest)
		{
			var e_ = HPVTest?.StatusElement;
			var f_ = context.Operators.Convert<string>(e_);
			var g_ = new string[]
			{
				"final",
				"amended",
				"corrected",
			};
			var h_ = context.Operators.InList<string>(f_, (g_ as IEnumerable<string>));
			var i_ = HPVTest?.Category;
			bool? j_(CodeableConcept HPVTestCategory)
			{
				var aq_ = this.laboratory();
				var ar_ = FHIRHelpers_4_0_001.ToConcept(HPVTestCategory);
				var as_ = ar_?.codes;
				var at_ = context.Operators.CodeInList(aq_, (as_ as IEnumerable<CqlCode>));

				return at_;
			};
			var k_ = context.Operators.WhereOrNull<CodeableConcept>((i_ as IEnumerable<CodeableConcept>), j_);
			var l_ = context.Operators.ExistsInList<CodeableConcept>(k_);
			var m_ = context.Operators.And(h_, l_);
			var n_ = this.Patient();
			var o_ = n_?.BirthDateElement;
			var p_ = o_?.Value;
			var q_ = context.Operators.Convert<CqlDate>(p_);
			var r_ = HPVTest?.Effective;
			var s_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Normalize_Interval(r_);
			var t_ = context.Operators.Start(s_);
			var u_ = context.Operators.DateFrom(t_);
			var v_ = context.Operators.CalculateAgeAt(q_, u_, "year");
			var w_ = context.Operators.GreaterOrEqual(v_, (int?)30);
			var x_ = context.Operators.And(m_, w_);
			var z_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Latest(r_);
			var aa_ = this.Measurement_Period();
			var ab_ = context.Operators.End(aa_);
			var ac_ = context.Operators.Quantity(5m, "years");
			var ad_ = context.Operators.Subtract(ab_, ac_);
			var af_ = context.Operators.End(aa_);
			var ag_ = context.Operators.Interval(ad_, af_, true, true);
			var ah_ = context.Operators.ElementInInterval<CqlDateTime>(z_, ag_, null);
			var aj_ = context.Operators.End(aa_);
			var ak_ = context.Operators.Not((bool?)(aj_ is null));
			var al_ = context.Operators.And(ah_, ak_);
			var am_ = context.Operators.And(x_, al_);
			var an_ = HPVTest?.Value;
			var ao_ = context.Operators.Not((bool?)(an_ is null));
			var ap_ = context.Operators.And(am_, ao_);

			return ap_;
		};
		var d_ = context.Operators.WhereOrNull<Observation>(b_, c_);

		return d_;
	}

    [CqlDeclaration("HPV Test Within 5 Years for Women Age 30 and Older")]
	public IEnumerable<Observation> HPV_Test_Within_5_Years_for_Women_Age_30_and_Older() => 
		__HPV_Test_Within_5_Years_for_Women_Age_30_and_Older.Value;

	private bool? Numerator_Value()
	{
		var a_ = this.Cervical_Cytology_Within_3_Years();
		var b_ = context.Operators.ExistsInList<Observation>(a_);
		var c_ = this.HPV_Test_Within_5_Years_for_Women_Age_30_and_Older();
		var d_ = context.Operators.ExistsInList<Observation>(c_);
		var e_ = context.Operators.Or(b_, d_);

		return e_;
	}

    [CqlDeclaration("Numerator")]
	public bool? Numerator() => 
		__Numerator.Value;

    [CqlDeclaration("isComplete")]
	public bool? isComplete(Observation observation)
	{
		var a_ = observation?.StatusElement;
		var b_ = context.Operators.Convert<string>(a_);
		var c_ = new string[]
		{
			"final",
			"amended",
			"corrected",
		};
		var d_ = context.Operators.InList<string>(b_, (c_ as IEnumerable<string>));

		return d_;
	}

    [CqlDeclaration("isLaboratoryTest")]
	public bool? isLaboratoryTest(Observation observation)
	{
		var a_ = observation?.Category;
		bool? b_(CodeableConcept category)
		{
			var e_ = this.laboratory();
			var f_ = FHIRHelpers_4_0_001.ToConcept(category);
			var g_ = f_?.codes;
			var h_ = context.Operators.CodeInList(e_, (g_ as IEnumerable<CqlCode>));

			return h_;
		};
		var c_ = context.Operators.WhereOrNull<CodeableConcept>((a_ as IEnumerable<CodeableConcept>), b_);
		var d_ = context.Operators.ExistsInList<CodeableConcept>(c_);

		return d_;
	}

    [CqlDeclaration("latest")]
	public CqlDateTime latest(object choice)
	{
		var a_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Latest(choice);

		return a_;
	}

	private IEnumerable<Observation> Cervical_Cytology_Within_3_Years__2__Value()
	{
		var a_ = this.Pap_Test();
		var b_ = context.Operators.RetrieveByValueSet<Observation>(a_, null);
		bool? c_(Observation CervicalCytology)
		{
			var e_ = this.isComplete(CervicalCytology);
			var f_ = this.isLaboratoryTest(CervicalCytology);
			var g_ = context.Operators.And(e_, f_);
			var h_ = CervicalCytology?.Effective;
			var i_ = this.latest(h_);
			var j_ = this.Measurement_Period();
			var k_ = context.Operators.End(j_);
			var l_ = context.Operators.Quantity(3m, "years");
			var m_ = context.Operators.Subtract(k_, l_);
			var o_ = context.Operators.End(j_);
			var p_ = context.Operators.Interval(m_, o_, true, true);
			var q_ = context.Operators.ElementInInterval<CqlDateTime>(i_, p_, null);
			var s_ = context.Operators.End(j_);
			var t_ = context.Operators.Not((bool?)(s_ is null));
			var u_ = context.Operators.And(q_, t_);
			var v_ = context.Operators.And(g_, u_);
			var w_ = CervicalCytology?.Value;
			var x_ = context.Operators.Not((bool?)(w_ is null));
			var y_ = context.Operators.And(v_, x_);

			return y_;
		};
		var d_ = context.Operators.WhereOrNull<Observation>(b_, c_);

		return d_;
	}

    [CqlDeclaration("Cervical Cytology Within 3 Years (2)")]
	public IEnumerable<Observation> Cervical_Cytology_Within_3_Years__2_() => 
		__Cervical_Cytology_Within_3_Years__2_.Value;

    [CqlDeclaration("toInterval")]
	public CqlInterval<CqlDateTime> toInterval(object choice)
	{
		var a_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Normalize_Interval(choice);

		return a_;
	}

	private IEnumerable<Observation> HPV_Test_Within_5_Years_for_Women_Age_30_and_Older__2__Value()
	{
		var a_ = this.HPV_Test();
		var b_ = context.Operators.RetrieveByValueSet<Observation>(a_, null);
		bool? c_(Observation HPVTest)
		{
			var e_ = this.isComplete(HPVTest);
			var f_ = this.isLaboratoryTest(HPVTest);
			var g_ = context.Operators.And(e_, f_);
			var h_ = this.Patient();
			var i_ = h_?.BirthDateElement;
			var j_ = i_?.Value;
			var k_ = context.Operators.Convert<CqlDate>(j_);
			var l_ = HPVTest?.Effective;
			var m_ = this.toInterval(l_);
			var n_ = context.Operators.Start(m_);
			var o_ = context.Operators.DateFrom(n_);
			var p_ = context.Operators.CalculateAgeAt(k_, o_, "year");
			var q_ = context.Operators.GreaterOrEqual(p_, (int?)30);
			var r_ = context.Operators.And(g_, q_);
			var t_ = this.latest(l_);
			var u_ = this.Measurement_Period();
			var v_ = context.Operators.End(u_);
			var w_ = context.Operators.Quantity(5m, "years");
			var x_ = context.Operators.Subtract(v_, w_);
			var z_ = context.Operators.End(u_);
			var aa_ = context.Operators.Interval(x_, z_, true, true);
			var ab_ = context.Operators.ElementInInterval<CqlDateTime>(t_, aa_, null);
			var ad_ = context.Operators.End(u_);
			var ae_ = context.Operators.Not((bool?)(ad_ is null));
			var af_ = context.Operators.And(ab_, ae_);
			var ag_ = context.Operators.And(r_, af_);
			var ah_ = HPVTest?.Value;
			var ai_ = context.Operators.Not((bool?)(ah_ is null));
			var aj_ = context.Operators.And(ag_, ai_);

			return aj_;
		};
		var d_ = context.Operators.WhereOrNull<Observation>(b_, c_);

		return d_;
	}

    [CqlDeclaration("HPV Test Within 5 Years for Women Age 30 and Older (2)")]
	public IEnumerable<Observation> HPV_Test_Within_5_Years_for_Women_Age_30_and_Older__2_() => 
		__HPV_Test_Within_5_Years_for_Women_Age_30_and_Older__2_.Value;

}