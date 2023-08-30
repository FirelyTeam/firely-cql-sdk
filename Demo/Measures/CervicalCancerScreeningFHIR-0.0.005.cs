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
		var a_ = context.Operators;
		var d_ = a_.ConvertIntegerToDecimal(default);
		var e_ = a_.DateTime((int?)2019, (int?)1, (int?)1, (int?)0, (int?)0, (int?)0, (int?)0, d_);
		var h_ = a_.ConvertIntegerToDecimal(default);
		var i_ = a_.DateTime((int?)2020, (int?)1, (int?)1, (int?)0, (int?)0, (int?)0, (int?)0, h_);
		var j_ = a_.Interval(e_, i_, true, false);
		var k_ = context.ResolveParameter("CervicalCancerScreeningFHIR-0.0.005", "Measurement Period", j_);

		return (CqlInterval<CqlDateTime>)k_;
	}

    [CqlDeclaration("Measurement Period")]
	public CqlInterval<CqlDateTime> Measurement_Period() => 
		__Measurement_Period.Value;

	private Patient Patient_Value()
	{
		var a_ = context.Operators;
		var b_ = context.DataRetriever;
		var c_ = b_.RetrieveByValueSet<Patient>(null, null);
		var d_ = a_.SingleOrNull<Patient>(c_);

		return d_;
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
		var a_ = context.Operators;
		var e_ = context.DataRetriever;
		var f_ = this.Office_Visit();
		var g_ = e_.RetrieveByValueSet<Encounter>(f_, null);
		var i_ = this.Preventive_Care_Services___Established_Office_Visit__18_and_Up();
		var j_ = e_.RetrieveByValueSet<Encounter>(i_, null);
		var k_ = a_.ListUnion<Encounter>(g_, j_);
		var n_ = this.Preventive_Care_Services_Initial_Office_Visit__18_and_Up();
		var o_ = e_.RetrieveByValueSet<Encounter>(n_, null);
		var q_ = this.Home_Healthcare_Services();
		var r_ = e_.RetrieveByValueSet<Encounter>(q_, null);
		var s_ = a_.ListUnion<Encounter>(o_, r_);
		var t_ = a_.ListUnion<Encounter>(k_, s_);
		var w_ = this.Telephone_Visits();
		var x_ = e_.RetrieveByValueSet<Encounter>(w_, null);
		var z_ = this.Online_Assessments();
		var aa_ = e_.RetrieveByValueSet<Encounter>(z_, null);
		var ab_ = a_.ListUnion<Encounter>(x_, aa_);
		var ac_ = a_.ListUnion<Encounter>(t_, ab_);
		bool? ad_(Encounter ValidEncounter)
		{
			var af_ = context.Operators;
			var ah_ = context.Deeper(new CallStackEntry("ToString", null, null));
			var ai_ = ah_.Operators;
			var aj_ = ai_.TypeConverter;
			var ak_ = ValidEncounter?.StatusElement;
			var al_ = aj_.Convert<string>(ak_);
			var am_ = af_.Equal(al_, "finished");
			var ao_ = this.Measurement_Period();
			var ap_ = ValidEncounter?.Period;
			var aq_ = FHIRHelpers_4_0_001.ToInterval(ap_);
			var ar_ = af_.IntervalIncludesInterval<CqlDateTime>(ao_, aq_, null);
			var as_ = af_.And(am_, ar_);

			return as_;
		};
		var ae_ = a_.WhereOrNull<Encounter>(ac_, ad_);

		return ae_;
	}

    [CqlDeclaration("Qualifying Encounters")]
	public IEnumerable<Encounter> Qualifying_Encounters() => 
		__Qualifying_Encounters.Value;

	private bool? Initial_Population_Value()
	{
		var a_ = context.Operators;
		var f_ = a_.TypeConverter;
		var g_ = this.Patient();
		var h_ = g_?.BirthDateElement;
		var i_ = h_?.Value;
		var j_ = f_.Convert<CqlDate>(i_);
		var m_ = this.Measurement_Period();
		var n_ = a_.Start(m_);
		var o_ = a_.DateFrom(n_);
		var p_ = a_.CalculateAgeAt(j_, o_, "year");
		var r_ = a_.Interval((int?)23, (int?)64, true, false);
		var s_ = a_.ElementInInterval<int?>(p_, r_, null);
		var u_ = context.Deeper(new CallStackEntry("ToString", null, null));
		var v_ = u_.Operators;
		var w_ = v_.TypeConverter;
		var y_ = g_?.GenderElement;
		var z_ = w_.Convert<string>(y_);
		var aa_ = a_.Equal(z_, "female");
		var ab_ = a_.And(s_, aa_);
		var ad_ = this.Qualifying_Encounters();
		var ae_ = a_.ExistsInList<Encounter>(ad_);
		var af_ = a_.And(ab_, ae_);

		return af_;
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
		var a_ = context.Operators;
		var c_ = context.DataRetriever;
		var d_ = this.Hysterectomy_with_No_Residual_Cervix();
		var e_ = c_.RetrieveByValueSet<Procedure>(d_, null);
		bool? f_(Procedure NoCervixProcedure)
		{
			var o_ = context.Operators;
			var q_ = context.Deeper(new CallStackEntry("ToString", null, null));
			var r_ = q_.Operators;
			var s_ = r_.TypeConverter;
			var t_ = NoCervixProcedure?.StatusElement;
			var u_ = s_.Convert<string>(t_);
			var v_ = o_.Equal(u_, "completed");
			var y_ = NoCervixProcedure?.Performed;
			var z_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Normalize_Interval(y_);
			var aa_ = o_.End(z_);
			var ac_ = this.Measurement_Period();
			var ad_ = o_.End(ac_);
			var ae_ = o_.SameOrBefore(aa_, ad_, null);
			var af_ = o_.And(v_, ae_);

			return af_;
		};
		var g_ = a_.WhereOrNull<Procedure>(e_, f_);
		var j_ = this.Congenital_or_Acquired_Absence_of_Cervix();
		var k_ = c_.RetrieveByValueSet<Condition>(j_, null);
		bool? l_(Condition NoCervixDiagnosis)
		{
			var ag_ = context.Operators;
			var ai_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Prevalence_Period(NoCervixDiagnosis);
			var aj_ = ag_.Start(ai_);
			var al_ = this.Measurement_Period();
			var am_ = ag_.End(al_);
			var an_ = ag_.SameOrBefore(aj_, am_, null);

			return an_;
		};
		var m_ = a_.WhereOrNull<Condition>(k_, l_);
		var n_ = a_.ListUnion<object>((g_ as IEnumerable<object>), (m_ as IEnumerable<object>));

		return n_;
	}

    [CqlDeclaration("Absence of Cervix")]
	public IEnumerable<object> Absence_of_Cervix() => 
		__Absence_of_Cervix.Value;

	private bool? Denominator_Exclusions_Value()
	{
		var a_ = context.Operators;
		var c_ = HospiceFHIR4_2_3_000.Has_Hospice();
		var e_ = this.Absence_of_Cervix();
		var f_ = a_.ExistsInList<object>(e_);
		var g_ = a_.Or(c_, f_);
		var h_ = PalliativeCareFHIR_0_6_000.Palliative_Care_in_the_Measurement_Period();
		var i_ = a_.Or(g_, h_);

		return i_;
	}

    [CqlDeclaration("Denominator Exclusions")]
	public bool? Denominator_Exclusions() => 
		__Denominator_Exclusions.Value;

	private IEnumerable<Observation> Cervical_Cytology_Within_3_Years_Value()
	{
		var a_ = context.Operators;
		var b_ = context.DataRetriever;
		var c_ = this.Pap_Test();
		var d_ = b_.RetrieveByValueSet<Observation>(c_, null);
		bool? e_(Observation CervicalCytology)
		{
			var g_ = context.Operators;
			var k_ = context.Deeper(new CallStackEntry("ToString", null, null));
			var l_ = k_.Operators;
			var m_ = l_.TypeConverter;
			var n_ = CervicalCytology?.StatusElement;
			var o_ = m_.Convert<string>(n_);
			var p_ = new string[]
			{
				"final",
				"amended",
				"corrected",
			};
			var q_ = g_.InList<string>(o_, (p_ as IEnumerable<string>));
			var t_ = CervicalCytology?.Category;
			bool? u_(CodeableConcept CervicalCytologyCategory)
			{
				var ba_ = context.Operators;
				var bb_ = this.laboratory();
				var bc_ = FHIRHelpers_4_0_001.ToConcept(CervicalCytologyCategory);
				var bd_ = bc_?.codes;
				var be_ = ba_.CodeInList(bb_, (bd_ as IEnumerable<CqlCode>));

				return be_;
			};
			var v_ = g_.WhereOrNull<CodeableConcept>((t_ as IEnumerable<CodeableConcept>), u_);
			var w_ = g_.ExistsInList<CodeableConcept>(v_);
			var x_ = g_.And(q_, w_);
			var aa_ = CervicalCytology?.Effective;
			var ab_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Latest(aa_);
			var af_ = this.Measurement_Period();
			var ag_ = g_.End(af_);
			var ai_ = g_.Quantity(3m, "years");
			var aj_ = g_.Subtract(ag_, ai_);
			var am_ = g_.End(af_);
			var an_ = g_.Interval(aj_, am_, true, true);
			var ao_ = g_.ElementInInterval<CqlDateTime>(ab_, an_, null);
			var as_ = g_.End(af_);
			var at_ = g_.Not((bool?)(as_ is null));
			var au_ = g_.And(ao_, at_);
			var av_ = g_.And(x_, au_);
			var ax_ = CervicalCytology?.Value;
			var ay_ = g_.Not((bool?)(ax_ is null));
			var az_ = g_.And(av_, ay_);

			return az_;
		};
		var f_ = a_.WhereOrNull<Observation>(d_, e_);

		return f_;
	}

    [CqlDeclaration("Cervical Cytology Within 3 Years")]
	public IEnumerable<Observation> Cervical_Cytology_Within_3_Years() => 
		__Cervical_Cytology_Within_3_Years.Value;

	private IEnumerable<Observation> HPV_Test_Within_5_Years_for_Women_Age_30_and_Older_Value()
	{
		var a_ = context.Operators;
		var b_ = context.DataRetriever;
		var c_ = this.HPV_Test();
		var d_ = b_.RetrieveByValueSet<Observation>(c_, null);
		bool? e_(Observation HPVTest)
		{
			var g_ = context.Operators;
			var l_ = context.Deeper(new CallStackEntry("ToString", null, null));
			var m_ = l_.Operators;
			var n_ = m_.TypeConverter;
			var o_ = HPVTest?.StatusElement;
			var p_ = n_.Convert<string>(o_);
			var q_ = new string[]
			{
				"final",
				"amended",
				"corrected",
			};
			var r_ = g_.InList<string>(p_, (q_ as IEnumerable<string>));
			var u_ = HPVTest?.Category;
			bool? v_(CodeableConcept HPVTestCategory)
			{
				var bs_ = context.Operators;
				var bt_ = this.laboratory();
				var bu_ = FHIRHelpers_4_0_001.ToConcept(HPVTestCategory);
				var bv_ = bu_?.codes;
				var bw_ = bs_.CodeInList(bt_, (bv_ as IEnumerable<CqlCode>));

				return bw_;
			};
			var w_ = g_.WhereOrNull<CodeableConcept>((u_ as IEnumerable<CodeableConcept>), v_);
			var x_ = g_.ExistsInList<CodeableConcept>(w_);
			var y_ = g_.And(r_, x_);
			var ac_ = g_.TypeConverter;
			var ad_ = this.Patient();
			var ae_ = ad_?.BirthDateElement;
			var af_ = ae_?.Value;
			var ag_ = ac_.Convert<CqlDate>(af_);
			var aj_ = HPVTest?.Effective;
			var ak_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Normalize_Interval(aj_);
			var al_ = g_.Start(ak_);
			var am_ = g_.DateFrom(al_);
			var an_ = g_.CalculateAgeAt(ag_, am_, "year");
			var ao_ = g_.GreaterOrEqual(an_, (int?)30);
			var ap_ = g_.And(y_, ao_);
			var at_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Latest(aj_);
			var ax_ = this.Measurement_Period();
			var ay_ = g_.End(ax_);
			var ba_ = g_.Quantity(5m, "years");
			var bb_ = g_.Subtract(ay_, ba_);
			var be_ = g_.End(ax_);
			var bf_ = g_.Interval(bb_, be_, true, true);
			var bg_ = g_.ElementInInterval<CqlDateTime>(at_, bf_, null);
			var bk_ = g_.End(ax_);
			var bl_ = g_.Not((bool?)(bk_ is null));
			var bm_ = g_.And(bg_, bl_);
			var bn_ = g_.And(ap_, bm_);
			var bp_ = HPVTest?.Value;
			var bq_ = g_.Not((bool?)(bp_ is null));
			var br_ = g_.And(bn_, bq_);

			return br_;
		};
		var f_ = a_.WhereOrNull<Observation>(d_, e_);

		return f_;
	}

    [CqlDeclaration("HPV Test Within 5 Years for Women Age 30 and Older")]
	public IEnumerable<Observation> HPV_Test_Within_5_Years_for_Women_Age_30_and_Older() => 
		__HPV_Test_Within_5_Years_for_Women_Age_30_and_Older.Value;

	private bool? Numerator_Value()
	{
		var a_ = context.Operators;
		var c_ = this.Cervical_Cytology_Within_3_Years();
		var d_ = a_.ExistsInList<Observation>(c_);
		var f_ = this.HPV_Test_Within_5_Years_for_Women_Age_30_and_Older();
		var g_ = a_.ExistsInList<Observation>(f_);
		var h_ = a_.Or(d_, g_);

		return h_;
	}

    [CqlDeclaration("Numerator")]
	public bool? Numerator() => 
		__Numerator.Value;

    [CqlDeclaration("isComplete")]
	public bool? isComplete(Observation observation)
	{
		var a_ = context.Operators;
		var b_ = context.Deeper(new CallStackEntry("ToString", null, null));
		var c_ = b_.Operators;
		var d_ = c_.TypeConverter;
		var e_ = observation?.StatusElement;
		var f_ = d_.Convert<string>(e_);
		var g_ = new string[]
		{
			"final",
			"amended",
			"corrected",
		};
		var h_ = a_.InList<string>(f_, (g_ as IEnumerable<string>));

		return h_;
	}

    [CqlDeclaration("isLaboratoryTest")]
	public bool? isLaboratoryTest(Observation observation)
	{
		var a_ = context.Operators;
		var c_ = observation?.Category;
		bool? d_(CodeableConcept category)
		{
			var g_ = context.Operators;
			var h_ = this.laboratory();
			var i_ = FHIRHelpers_4_0_001.ToConcept(category);
			var j_ = i_?.codes;
			var k_ = g_.CodeInList(h_, (j_ as IEnumerable<CqlCode>));

			return k_;
		};
		var e_ = a_.WhereOrNull<CodeableConcept>((c_ as IEnumerable<CodeableConcept>), d_);
		var f_ = a_.ExistsInList<CodeableConcept>(e_);

		return f_;
	}

    [CqlDeclaration("latest")]
	public CqlDateTime latest(object choice)
	{
		var a_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Latest(choice);

		return a_;
	}

	private IEnumerable<Observation> Cervical_Cytology_Within_3_Years__2__Value()
	{
		var a_ = context.Operators;
		var b_ = context.DataRetriever;
		var c_ = this.Pap_Test();
		var d_ = b_.RetrieveByValueSet<Observation>(c_, null);
		bool? e_(Observation CervicalCytology)
		{
			var g_ = context.Operators;
			var j_ = this.isComplete(CervicalCytology);
			var k_ = this.isLaboratoryTest(CervicalCytology);
			var l_ = g_.And(j_, k_);
			var o_ = CervicalCytology?.Effective;
			var p_ = this.latest(o_);
			var t_ = this.Measurement_Period();
			var u_ = g_.End(t_);
			var w_ = g_.Quantity(3m, "years");
			var x_ = g_.Subtract(u_, w_);
			var aa_ = g_.End(t_);
			var ab_ = g_.Interval(x_, aa_, true, true);
			var ac_ = g_.ElementInInterval<CqlDateTime>(p_, ab_, null);
			var ag_ = g_.End(t_);
			var ah_ = g_.Not((bool?)(ag_ is null));
			var ai_ = g_.And(ac_, ah_);
			var aj_ = g_.And(l_, ai_);
			var al_ = CervicalCytology?.Value;
			var am_ = g_.Not((bool?)(al_ is null));
			var an_ = g_.And(aj_, am_);

			return an_;
		};
		var f_ = a_.WhereOrNull<Observation>(d_, e_);

		return f_;
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
		var a_ = context.Operators;
		var b_ = context.DataRetriever;
		var c_ = this.HPV_Test();
		var d_ = b_.RetrieveByValueSet<Observation>(c_, null);
		bool? e_(Observation HPVTest)
		{
			var g_ = context.Operators;
			var k_ = this.isComplete(HPVTest);
			var l_ = this.isLaboratoryTest(HPVTest);
			var m_ = g_.And(k_, l_);
			var q_ = g_.TypeConverter;
			var r_ = this.Patient();
			var s_ = r_?.BirthDateElement;
			var t_ = s_?.Value;
			var u_ = q_.Convert<CqlDate>(t_);
			var x_ = HPVTest?.Effective;
			var y_ = this.toInterval(x_);
			var z_ = g_.Start(y_);
			var aa_ = g_.DateFrom(z_);
			var ab_ = g_.CalculateAgeAt(u_, aa_, "year");
			var ac_ = g_.GreaterOrEqual(ab_, (int?)30);
			var ad_ = g_.And(m_, ac_);
			var ah_ = this.latest(x_);
			var al_ = this.Measurement_Period();
			var am_ = g_.End(al_);
			var ao_ = g_.Quantity(5m, "years");
			var ap_ = g_.Subtract(am_, ao_);
			var as_ = g_.End(al_);
			var at_ = g_.Interval(ap_, as_, true, true);
			var au_ = g_.ElementInInterval<CqlDateTime>(ah_, at_, null);
			var ay_ = g_.End(al_);
			var az_ = g_.Not((bool?)(ay_ is null));
			var ba_ = g_.And(au_, az_);
			var bb_ = g_.And(ad_, ba_);
			var bd_ = HPVTest?.Value;
			var be_ = g_.Not((bool?)(bd_ is null));
			var bf_ = g_.And(bb_, be_);

			return bf_;
		};
		var f_ = a_.WhereOrNull<Observation>(d_, e_);

		return f_;
	}

    [CqlDeclaration("HPV Test Within 5 Years for Women Age 30 and Older (2)")]
	public IEnumerable<Observation> HPV_Test_Within_5_Years_for_Women_Age_30_and_Older__2_() => 
		__HPV_Test_Within_5_Years_for_Women_Age_30_and_Older__2_.Value;

}