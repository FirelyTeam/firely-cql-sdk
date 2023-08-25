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

    private CqlValueSet Congenital_or_Acquired_Absence_of_Cervix_Value()
	{
		var a_ = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.111.12.1016", null);

		return a_;
	}

    [CqlDeclaration("Congenital or Acquired Absence of Cervix")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.111.12.1016")]
    public CqlValueSet Congenital_or_Acquired_Absence_of_Cervix() => __Congenital_or_Acquired_Absence_of_Cervix.Value;

    private CqlValueSet Home_Healthcare_Services_Value()
	{
		var a_ = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1016", null);

		return a_;
	}

    [CqlDeclaration("Home Healthcare Services")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1016")]
    public CqlValueSet Home_Healthcare_Services() => __Home_Healthcare_Services.Value;

    private CqlValueSet HPV_Test_Value()
	{
		var a_ = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.110.12.1059", null);

		return a_;
	}

    [CqlDeclaration("HPV Test")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.110.12.1059")]
    public CqlValueSet HPV_Test() => __HPV_Test.Value;

    private CqlValueSet Hysterectomy_with_No_Residual_Cervix_Value()
	{
		var a_ = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.198.12.1014", null);

		return a_;
	}

    [CqlDeclaration("Hysterectomy with No Residual Cervix")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.198.12.1014")]
    public CqlValueSet Hysterectomy_with_No_Residual_Cervix() => __Hysterectomy_with_No_Residual_Cervix.Value;

    private CqlValueSet Office_Visit_Value()
	{
		var a_ = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1001", null);

		return a_;
	}

    [CqlDeclaration("Office Visit")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1001")]
    public CqlValueSet Office_Visit() => __Office_Visit.Value;

    private CqlValueSet Online_Assessments_Value()
	{
		var a_ = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1089", null);

		return a_;
	}

    [CqlDeclaration("Online Assessments")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1089")]
    public CqlValueSet Online_Assessments() => __Online_Assessments.Value;

    private CqlValueSet Pap_Test_Value()
	{
		var a_ = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.108.12.1017", null);

		return a_;
	}

    [CqlDeclaration("Pap Test")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.108.12.1017")]
    public CqlValueSet Pap_Test() => __Pap_Test.Value;

    private CqlValueSet Preventive_Care_Services___Established_Office_Visit__18_and_Up_Value()
	{
		var a_ = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1025", null);

		return a_;
	}

    [CqlDeclaration("Preventive Care Services - Established Office Visit, 18 and Up")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1025")]
    public CqlValueSet Preventive_Care_Services___Established_Office_Visit__18_and_Up() => __Preventive_Care_Services___Established_Office_Visit__18_and_Up.Value;

    private CqlValueSet Preventive_Care_Services_Initial_Office_Visit__18_and_Up_Value()
	{
		var a_ = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1023", null);

		return a_;
	}

    [CqlDeclaration("Preventive Care Services-Initial Office Visit, 18 and Up")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1023")]
    public CqlValueSet Preventive_Care_Services_Initial_Office_Visit__18_and_Up() => __Preventive_Care_Services_Initial_Office_Visit__18_and_Up.Value;

    private CqlValueSet Telephone_Visits_Value()
	{
		var a_ = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1080", null);

		return a_;
	}

    [CqlDeclaration("Telephone Visits")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1080")]
    public CqlValueSet Telephone_Visits() => __Telephone_Visits.Value;

    private CqlCode laboratory_Value()
	{
		var a_ = new CqlCode("laboratory", "http://terminology.hl7.org/CodeSystem/observation-category", null, null);

		return a_;
	}

    [CqlDeclaration("laboratory")]
    public CqlCode laboratory() => __laboratory.Value;

    private CqlCode[] ObservationCategoryCodes_Value()
	{
		var a_ = new CqlCode("laboratory", "http://terminology.hl7.org/CodeSystem/observation-category", null, null);
		var b_ = new CqlCode[]
		{
			a_,
		};

		return b_;
	}

    [CqlDeclaration("ObservationCategoryCodes")]
    public CqlCode[] ObservationCategoryCodes() => __ObservationCategoryCodes.Value;

    private CqlInterval<CqlDateTime> Measurement_Period_Value()
	{
		var a_ = (int?)2019;
		var b_ = (int?)1;
		var d_ = (int?)0;
		var h_ = context.Operators;
		var i_ = h_.ConvertIntegerToDecimal(default);
		var k_ = h_.DateTime(a_, b_, b_, d_, d_, d_, d_, i_);
		var l_ = (int?)2020;
		var t_ = h_.ConvertIntegerToDecimal(default);
		var v_ = h_.DateTime(l_, b_, b_, d_, d_, d_, d_, t_);
		var x_ = h_.Interval(k_, v_, true, false);
		var y_ = context.ResolveParameter("CervicalCancerScreeningFHIR-0.0.005", "Measurement Period", x_);
		var z_ = (CqlInterval<CqlDateTime>)y_;

		return z_;
	}

    [CqlDeclaration("Measurement Period")]
    public CqlInterval<CqlDateTime> Measurement_Period() => __Measurement_Period.Value;

    private Patient Patient_Value()
	{
		var a_ = context.DataRetriever;
		var b_ = a_.RetrieveByValueSet<Patient>(null, null);
		var c_ = context.Operators;
		var d_ = c_.SingleOrNull<Patient>(b_);

		return d_;
	}

    [CqlDeclaration("Patient")]
    public Patient Patient() => __Patient.Value;

    private IEnumerable<Coding> SDE_Ethnicity_Value()
	{
		var a_ = SupplementalDataElementsFHIR4_2_0_000.SDE_Ethnicity();

		return a_;
	}

    [CqlDeclaration("SDE Ethnicity")]
    public IEnumerable<Coding> SDE_Ethnicity() => __SDE_Ethnicity.Value;

    private IEnumerable<Tuples.Tuple_CFQHSgYJOXjAOCKdWLdZNNHDG> SDE_Payer_Value()
	{
		var a_ = SupplementalDataElementsFHIR4_2_0_000.SDE_Payer();

		return a_;
	}

    [CqlDeclaration("SDE Payer")]
    public IEnumerable<Tuples.Tuple_CFQHSgYJOXjAOCKdWLdZNNHDG> SDE_Payer() => __SDE_Payer.Value;

    private IEnumerable<Coding> SDE_Race_Value()
	{
		var a_ = SupplementalDataElementsFHIR4_2_0_000.SDE_Race();

		return a_;
	}

    [CqlDeclaration("SDE Race")]
    public IEnumerable<Coding> SDE_Race() => __SDE_Race.Value;

    private CqlCode SDE_Sex_Value()
	{
		var a_ = SupplementalDataElementsFHIR4_2_0_000.SDE_Sex();

		return a_;
	}

    [CqlDeclaration("SDE Sex")]
    public CqlCode SDE_Sex() => __SDE_Sex.Value;

    private IEnumerable<Encounter> Qualifying_Encounters_Value()
	{
		var a_ = this.Office_Visit();
		var b_ = context.DataRetriever;
		var c_ = b_.RetrieveByValueSet<Encounter>(a_, null);
		var d_ = this.Preventive_Care_Services___Established_Office_Visit__18_and_Up();
		var f_ = b_.RetrieveByValueSet<Encounter>(d_, null);
		var g_ = context.Operators;
		var h_ = g_.ListUnion<Encounter>(c_, f_);
		var i_ = this.Preventive_Care_Services_Initial_Office_Visit__18_and_Up();
		var k_ = b_.RetrieveByValueSet<Encounter>(i_, null);
		var l_ = this.Home_Healthcare_Services();
		var n_ = b_.RetrieveByValueSet<Encounter>(l_, null);
		var p_ = g_.ListUnion<Encounter>(k_, n_);
		var r_ = g_.ListUnion<Encounter>(h_, p_);
		var s_ = this.Telephone_Visits();
		var u_ = b_.RetrieveByValueSet<Encounter>(s_, null);
		var v_ = this.Online_Assessments();
		var x_ = b_.RetrieveByValueSet<Encounter>(v_, null);
		var z_ = g_.ListUnion<Encounter>(u_, x_);
		var ab_ = g_.ListUnion<Encounter>(r_, z_);
		var ac_ = (Encounter ValidEncounter) =>
		{
			var af_ = ValidEncounter.StatusElement;
			var ag_ = new CallStackEntry("ToString", null, null);
			var ah_ = context.Deeper(ag_);
			var ai_ = ah_.Operators;
			var aj_ = ai_.TypeConverter;
			var ak_ = aj_.Convert<string>(af_);
			var al_ = context.Operators;
			var am_ = al_.Equal(ak_, "finished");
			var an_ = this.Measurement_Period();
			var ao_ = ValidEncounter.Period;
			var ap_ = FHIRHelpers_4_0_001.ToInterval(ao_);
			var ar_ = al_.IntervalIncludesInterval<CqlDateTime>(an_, ap_, null);
			var at_ = al_.And(am_, ar_);

			return at_;
		};
		var ae_ = g_.WhereOrNull<Encounter>(ab_, ac_);

		return ae_;
	}

    [CqlDeclaration("Qualifying Encounters")]
    public IEnumerable<Encounter> Qualifying_Encounters() => __Qualifying_Encounters.Value;

    private bool? Initial_Population_Value()
	{
		var a_ = this.Patient();
		var b_ = a_.BirthDateElement;
		var c_ = b_.Value;
		var d_ = context.Operators;
		var e_ = d_.TypeConverter;
		var f_ = e_.Convert<CqlDate>(c_);
		var g_ = this.Measurement_Period();
		var i_ = d_.Start(g_);
		var k_ = d_.DateFrom(i_);
		var m_ = d_.CalculateAgeAt(f_, k_, "year");
		var n_ = (int?)23;
		var o_ = (int?)64;
		var q_ = d_.Interval(n_, o_, true, false);
		var s_ = d_.ElementInInterval<int?>(m_, q_, null);
		var u_ = a_.GenderElement;
		var v_ = new CallStackEntry("ToString", null, null);
		var w_ = context.Deeper(v_);
		var x_ = w_.Operators;
		var y_ = x_.TypeConverter;
		var z_ = y_.Convert<string>(u_);
		var ab_ = d_.Equal(z_, "female");
		var ad_ = d_.And(s_, ab_);
		var ae_ = this.Qualifying_Encounters();
		var ag_ = d_.ExistsInList<Encounter>(ae_);
		var ai_ = d_.And(ad_, ag_);

		return ai_;
	}

    [CqlDeclaration("Initial Population")]
    public bool? Initial_Population() => __Initial_Population.Value;

    private bool? Denominator_Value()
	{
		var a_ = this.Initial_Population();

		return a_;
	}

    [CqlDeclaration("Denominator")]
    public bool? Denominator() => __Denominator.Value;

    private IEnumerable<object> Absence_of_Cervix_Value()
	{
		var a_ = this.Hysterectomy_with_No_Residual_Cervix();
		var b_ = context.DataRetriever;
		var c_ = b_.RetrieveByValueSet<Procedure>(a_, null);
		var d_ = (Procedure NoCervixProcedure) =>
		{
			var q_ = NoCervixProcedure.StatusElement;
			var r_ = new CallStackEntry("ToString", null, null);
			var s_ = context.Deeper(r_);
			var t_ = s_.Operators;
			var u_ = t_.TypeConverter;
			var v_ = u_.Convert<string>(q_);
			var w_ = context.Operators;
			var x_ = w_.Equal(v_, "completed");
			var y_ = NoCervixProcedure.Performed;
			var z_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Normalize_Interval(y_);
			var ab_ = w_.End(z_);
			var ac_ = this.Measurement_Period();
			var ae_ = w_.End(ac_);
			var ag_ = w_.SameOrBefore(ab_, ae_, null);
			var ai_ = w_.And(x_, ag_);

			return ai_;
		};
		var e_ = context.Operators;
		var f_ = e_.WhereOrNull<Procedure>(c_, d_);
		var g_ = (f_ as IEnumerable<object>);
		var h_ = this.Congenital_or_Acquired_Absence_of_Cervix();
		var j_ = b_.RetrieveByValueSet<Condition>(h_, null);
		var k_ = (Condition NoCervixDiagnosis) =>
		{
			var aj_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Prevalence_Period(NoCervixDiagnosis);
			var ak_ = context.Operators;
			var al_ = ak_.Start(aj_);
			var am_ = this.Measurement_Period();
			var ao_ = ak_.End(am_);
			var aq_ = ak_.SameOrBefore(al_, ao_, null);

			return aq_;
		};
		var m_ = e_.WhereOrNull<Condition>(j_, k_);
		var n_ = (m_ as IEnumerable<object>);
		var p_ = e_.ListUnion<object>(g_, n_);

		return p_;
	}

    [CqlDeclaration("Absence of Cervix")]
    public IEnumerable<object> Absence_of_Cervix() => __Absence_of_Cervix.Value;

    private bool? Denominator_Exclusions_Value()
	{
		var a_ = HospiceFHIR4_2_3_000.Has_Hospice();
		var b_ = this.Absence_of_Cervix();
		var c_ = context.Operators;
		var d_ = c_.ExistsInList<object>(b_);
		var f_ = c_.Or(a_, d_);
		var g_ = PalliativeCareFHIR_0_6_000.Palliative_Care_in_the_Measurement_Period();
		var i_ = c_.Or(f_, g_);

		return i_;
	}

    [CqlDeclaration("Denominator Exclusions")]
    public bool? Denominator_Exclusions() => __Denominator_Exclusions.Value;

    private IEnumerable<Observation> Cervical_Cytology_Within_3_Years_Value()
	{
		var a_ = this.Pap_Test();
		var b_ = context.DataRetriever;
		var c_ = b_.RetrieveByValueSet<Observation>(a_, null);
		var d_ = (Observation CervicalCytology) =>
		{
			var g_ = CervicalCytology.StatusElement;
			var h_ = new CallStackEntry("ToString", null, null);
			var i_ = context.Deeper(h_);
			var j_ = i_.Operators;
			var k_ = j_.TypeConverter;
			var l_ = k_.Convert<string>(g_);
			var m_ = new string[]
			{
				"final",
				"amended",
				"corrected",
			};
			var n_ = (m_ as IEnumerable<string>);
			var o_ = context.Operators;
			var p_ = o_.InList<string>(l_, n_);
			var q_ = CervicalCytology.Category;
			var r_ = (q_ as IEnumerable<CodeableConcept>);
			var s_ = (CodeableConcept CervicalCytologyCategory) =>
			{
				var bh_ = this.laboratory();
				var bi_ = FHIRHelpers_4_0_001.ToConcept(CervicalCytologyCategory);
				var bj_ = bi_.codes;
				var bk_ = (bj_ as IEnumerable<CqlCode>);
				var bl_ = context.Operators;
				var bm_ = bl_.CodeInList(bh_, bk_);

				return bm_;
			};
			var u_ = o_.WhereOrNull<CodeableConcept>(r_, s_);
			var w_ = o_.ExistsInList<CodeableConcept>(u_);
			var y_ = o_.And(p_, w_);
			var z_ = CervicalCytology.Effective;
			var aa_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Latest(z_);
			var ab_ = this.Measurement_Period();
			var ad_ = o_.End(ab_);
			var af_ = o_.Quantity(3m, "years");
			var ah_ = o_.Subtract(ad_, af_);
			var ak_ = o_.End(ab_);
			var am_ = o_.Interval(ah_, ak_, true, true);
			var ao_ = o_.ElementInInterval<CqlDateTime>(aa_, am_, null);
			var ar_ = o_.End(ab_);
			var as_ = (ar_ == null);
			var at_ = (bool?)as_;
			var av_ = o_.Not(at_);
			var ax_ = o_.And(ao_, av_);
			var az_ = o_.And(y_, ax_);
			var ba_ = CervicalCytology.Value;
			var bb_ = (ba_ == null);
			var bc_ = (bool?)bb_;
			var be_ = o_.Not(bc_);
			var bg_ = o_.And(az_, be_);

			return bg_;
		};
		var e_ = context.Operators;
		var f_ = e_.WhereOrNull<Observation>(c_, d_);

		return f_;
	}

    [CqlDeclaration("Cervical Cytology Within 3 Years")]
    public IEnumerable<Observation> Cervical_Cytology_Within_3_Years() => __Cervical_Cytology_Within_3_Years.Value;

    private IEnumerable<Observation> HPV_Test_Within_5_Years_for_Women_Age_30_and_Older_Value()
	{
		var a_ = this.HPV_Test();
		var b_ = context.DataRetriever;
		var c_ = b_.RetrieveByValueSet<Observation>(a_, null);
		var d_ = (Observation HPVTest) =>
		{
			var g_ = HPVTest.StatusElement;
			var h_ = new CallStackEntry("ToString", null, null);
			var i_ = context.Deeper(h_);
			var j_ = i_.Operators;
			var k_ = j_.TypeConverter;
			var l_ = k_.Convert<string>(g_);
			var m_ = new string[]
			{
				"final",
				"amended",
				"corrected",
			};
			var n_ = (m_ as IEnumerable<string>);
			var o_ = context.Operators;
			var p_ = o_.InList<string>(l_, n_);
			var q_ = HPVTest.Category;
			var r_ = (q_ as IEnumerable<CodeableConcept>);
			var s_ = (CodeableConcept HPVTestCategory) =>
			{
				var cc_ = this.laboratory();
				var cd_ = FHIRHelpers_4_0_001.ToConcept(HPVTestCategory);
				var ce_ = cd_.codes;
				var cf_ = (ce_ as IEnumerable<CqlCode>);
				var cg_ = context.Operators;
				var ch_ = cg_.CodeInList(cc_, cf_);

				return ch_;
			};
			var u_ = o_.WhereOrNull<CodeableConcept>(r_, s_);
			var w_ = o_.ExistsInList<CodeableConcept>(u_);
			var y_ = o_.And(p_, w_);
			var z_ = this.Patient();
			var aa_ = z_.BirthDateElement;
			var ab_ = aa_.Value;
			var ad_ = o_.TypeConverter;
			var ae_ = ad_.Convert<CqlDate>(ab_);
			var af_ = HPVTest.Effective;
			var ag_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Normalize_Interval(af_);
			var ai_ = o_.Start(ag_);
			var ak_ = o_.DateFrom(ai_);
			var am_ = o_.CalculateAgeAt(ae_, ak_, "year");
			var an_ = am_;
			var ao_ = (int?)30;
			var ap_ = ao_;
			var ar_ = o_.GreaterOrEqual(an_, ap_);
			var at_ = o_.And(y_, ar_);
			var av_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Latest(af_);
			var aw_ = this.Measurement_Period();
			var ay_ = o_.End(aw_);
			var ba_ = o_.Quantity(5m, "years");
			var bc_ = o_.Subtract(ay_, ba_);
			var bf_ = o_.End(aw_);
			var bh_ = o_.Interval(bc_, bf_, true, true);
			var bj_ = o_.ElementInInterval<CqlDateTime>(av_, bh_, null);
			var bm_ = o_.End(aw_);
			var bn_ = (bm_ == null);
			var bo_ = (bool?)bn_;
			var bq_ = o_.Not(bo_);
			var bs_ = o_.And(bj_, bq_);
			var bu_ = o_.And(at_, bs_);
			var bv_ = HPVTest.Value;
			var bw_ = (bv_ == null);
			var bx_ = (bool?)bw_;
			var bz_ = o_.Not(bx_);
			var cb_ = o_.And(bu_, bz_);

			return cb_;
		};
		var e_ = context.Operators;
		var f_ = e_.WhereOrNull<Observation>(c_, d_);

		return f_;
	}

    [CqlDeclaration("HPV Test Within 5 Years for Women Age 30 and Older")]
    public IEnumerable<Observation> HPV_Test_Within_5_Years_for_Women_Age_30_and_Older() => __HPV_Test_Within_5_Years_for_Women_Age_30_and_Older.Value;

    private bool? Numerator_Value()
	{
		var a_ = this.Cervical_Cytology_Within_3_Years();
		var b_ = context.Operators;
		var c_ = b_.ExistsInList<Observation>(a_);
		var d_ = this.HPV_Test_Within_5_Years_for_Women_Age_30_and_Older();
		var f_ = b_.ExistsInList<Observation>(d_);
		var h_ = b_.Or(c_, f_);

		return h_;
	}

    [CqlDeclaration("Numerator")]
    public bool? Numerator() => __Numerator.Value;

    [CqlDeclaration("isComplete")]
    public bool? isComplete(Observation observation)
	{
		var a_ = observation.StatusElement;
		var b_ = new CallStackEntry("ToString", null, null);
		var c_ = context.Deeper(b_);
		var d_ = c_.Operators;
		var e_ = d_.TypeConverter;
		var f_ = e_.Convert<string>(a_);
		var g_ = new string[]
		{
			"final",
			"amended",
			"corrected",
		};
		var h_ = (g_ as IEnumerable<string>);
		var i_ = context.Operators;
		var j_ = i_.InList<string>(f_, h_);

		return j_;
	}


    [CqlDeclaration("isLaboratoryTest")]
    public bool? isLaboratoryTest(Observation observation)
	{
		var a_ = observation.Category;
		var b_ = (a_ as IEnumerable<CodeableConcept>);
		var c_ = (CodeableConcept category) =>
		{
			var h_ = this.laboratory();
			var i_ = FHIRHelpers_4_0_001.ToConcept(category);
			var j_ = i_.codes;
			var k_ = (j_ as IEnumerable<CqlCode>);
			var l_ = context.Operators;
			var m_ = l_.CodeInList(h_, k_);

			return m_;
		};
		var d_ = context.Operators;
		var e_ = d_.WhereOrNull<CodeableConcept>(b_, c_);
		var g_ = d_.ExistsInList<CodeableConcept>(e_);

		return g_;
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
		var b_ = context.DataRetriever;
		var c_ = b_.RetrieveByValueSet<Observation>(a_, null);
		var d_ = (Observation CervicalCytology) =>
		{
			var g_ = this.isComplete(CervicalCytology);
			var h_ = this.isLaboratoryTest(CervicalCytology);
			var i_ = context.Operators;
			var j_ = i_.And(g_, h_);
			var k_ = CervicalCytology.Effective;
			var l_ = this.latest(k_);
			var m_ = this.Measurement_Period();
			var o_ = i_.End(m_);
			var q_ = i_.Quantity(3m, "years");
			var s_ = i_.Subtract(o_, q_);
			var v_ = i_.End(m_);
			var x_ = i_.Interval(s_, v_, true, true);
			var z_ = i_.ElementInInterval<CqlDateTime>(l_, x_, null);
			var ac_ = i_.End(m_);
			var ad_ = (ac_ == null);
			var ae_ = (bool?)ad_;
			var ag_ = i_.Not(ae_);
			var ai_ = i_.And(z_, ag_);
			var ak_ = i_.And(j_, ai_);
			var al_ = CervicalCytology.Value;
			var am_ = (al_ == null);
			var an_ = (bool?)am_;
			var ap_ = i_.Not(an_);
			var ar_ = i_.And(ak_, ap_);

			return ar_;
		};
		var e_ = context.Operators;
		var f_ = e_.WhereOrNull<Observation>(c_, d_);

		return f_;
	}

    [CqlDeclaration("Cervical Cytology Within 3 Years (2)")]
    public IEnumerable<Observation> Cervical_Cytology_Within_3_Years__2_() => __Cervical_Cytology_Within_3_Years__2_.Value;

    [CqlDeclaration("toInterval")]
    public CqlInterval<CqlDateTime> toInterval(object choice)
	{
		var a_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Normalize_Interval(choice);

		return a_;
	}


    private IEnumerable<Observation> HPV_Test_Within_5_Years_for_Women_Age_30_and_Older__2__Value()
	{
		var a_ = this.HPV_Test();
		var b_ = context.DataRetriever;
		var c_ = b_.RetrieveByValueSet<Observation>(a_, null);
		var d_ = (Observation HPVTest) =>
		{
			var g_ = this.isComplete(HPVTest);
			var h_ = this.isLaboratoryTest(HPVTest);
			var i_ = context.Operators;
			var j_ = i_.And(g_, h_);
			var k_ = this.Patient();
			var l_ = k_.BirthDateElement;
			var m_ = l_.Value;
			var o_ = i_.TypeConverter;
			var p_ = o_.Convert<CqlDate>(m_);
			var q_ = HPVTest.Effective;
			var r_ = this.toInterval(q_);
			var t_ = i_.Start(r_);
			var v_ = i_.DateFrom(t_);
			var x_ = i_.CalculateAgeAt(p_, v_, "year");
			var y_ = x_;
			var z_ = (int?)30;
			var aa_ = z_;
			var ac_ = i_.GreaterOrEqual(y_, aa_);
			var ae_ = i_.And(j_, ac_);
			var ag_ = this.latest(q_);
			var ah_ = this.Measurement_Period();
			var aj_ = i_.End(ah_);
			var al_ = i_.Quantity(5m, "years");
			var an_ = i_.Subtract(aj_, al_);
			var aq_ = i_.End(ah_);
			var as_ = i_.Interval(an_, aq_, true, true);
			var au_ = i_.ElementInInterval<CqlDateTime>(ag_, as_, null);
			var ax_ = i_.End(ah_);
			var ay_ = (ax_ == null);
			var az_ = (bool?)ay_;
			var bb_ = i_.Not(az_);
			var bd_ = i_.And(au_, bb_);
			var bf_ = i_.And(ae_, bd_);
			var bg_ = HPVTest.Value;
			var bh_ = (bg_ == null);
			var bi_ = (bool?)bh_;
			var bk_ = i_.Not(bi_);
			var bm_ = i_.And(bf_, bk_);

			return bm_;
		};
		var e_ = context.Operators;
		var f_ = e_.WhereOrNull<Observation>(c_, d_);

		return f_;
	}

    [CqlDeclaration("HPV Test Within 5 Years for Women Age 30 and Older (2)")]
    public IEnumerable<Observation> HPV_Test_Within_5_Years_for_Women_Age_30_and_Older__2_() => __HPV_Test_Within_5_Years_for_Women_Age_30_and_Older__2_.Value;

}