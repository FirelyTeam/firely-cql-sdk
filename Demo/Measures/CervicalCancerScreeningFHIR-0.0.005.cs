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
    public CqlValueSet Congenital_or_Acquired_Absence_of_Cervix() => __Congenital_or_Acquired_Absence_of_Cervix.Value;

    private CqlValueSet Home_Healthcare_Services_Value() =>
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1016", null);

    [CqlDeclaration("Home Healthcare Services")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1016")]
    public CqlValueSet Home_Healthcare_Services() => __Home_Healthcare_Services.Value;

    private CqlValueSet HPV_Test_Value() =>
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.110.12.1059", null);

    [CqlDeclaration("HPV Test")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.110.12.1059")]
    public CqlValueSet HPV_Test() => __HPV_Test.Value;

    private CqlValueSet Hysterectomy_with_No_Residual_Cervix_Value() =>
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.198.12.1014", null);

    [CqlDeclaration("Hysterectomy with No Residual Cervix")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.198.12.1014")]
    public CqlValueSet Hysterectomy_with_No_Residual_Cervix() => __Hysterectomy_with_No_Residual_Cervix.Value;

    private CqlValueSet Office_Visit_Value() =>
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1001", null);

    [CqlDeclaration("Office Visit")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1001")]
    public CqlValueSet Office_Visit() => __Office_Visit.Value;

    private CqlValueSet Online_Assessments_Value() =>
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1089", null);

    [CqlDeclaration("Online Assessments")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1089")]
    public CqlValueSet Online_Assessments() => __Online_Assessments.Value;

    private CqlValueSet Pap_Test_Value() =>
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.108.12.1017", null);

    [CqlDeclaration("Pap Test")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.108.12.1017")]
    public CqlValueSet Pap_Test() => __Pap_Test.Value;

    private CqlValueSet Preventive_Care_Services___Established_Office_Visit__18_and_Up_Value() =>
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1025", null);

    [CqlDeclaration("Preventive Care Services - Established Office Visit, 18 and Up")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1025")]
    public CqlValueSet Preventive_Care_Services___Established_Office_Visit__18_and_Up() => __Preventive_Care_Services___Established_Office_Visit__18_and_Up.Value;

    private CqlValueSet Preventive_Care_Services_Initial_Office_Visit__18_and_Up_Value() =>
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1023", null);

    [CqlDeclaration("Preventive Care Services-Initial Office Visit, 18 and Up")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1023")]
    public CqlValueSet Preventive_Care_Services_Initial_Office_Visit__18_and_Up() => __Preventive_Care_Services_Initial_Office_Visit__18_and_Up.Value;

    private CqlValueSet Telephone_Visits_Value() =>
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1080", null);

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
		var a_ = context.Operators;
		var b_ = a_.ConvertIntegerToDecimal(default);
		var d_ = a_.DateTime((int?)2019, (int?)1, (int?)1, (int?)0, (int?)0, (int?)0, (int?)0, b_);
		var f_ = a_.ConvertIntegerToDecimal(default);
		var h_ = a_.DateTime((int?)2020, (int?)1, (int?)1, (int?)0, (int?)0, (int?)0, (int?)0, f_);
		var j_ = a_.Interval(d_, h_, true, false);
		var k_ = context.ResolveParameter("CervicalCancerScreeningFHIR-0.0.005", "Measurement Period", j_);

		return (CqlInterval<CqlDateTime>)k_;
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
		bool? ac_(Encounter ValidEncounter)
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
		var o_ = d_.Interval((int?)23, (int?)64, true, false);
		var q_ = d_.ElementInInterval<int?>(m_, o_, null);
		var s_ = a_.GenderElement;
		var t_ = new CallStackEntry("ToString", null, null);
		var u_ = context.Deeper(t_);
		var v_ = u_.Operators;
		var w_ = v_.TypeConverter;
		var x_ = w_.Convert<string>(s_);
		var z_ = d_.Equal(x_, "female");
		var ab_ = d_.And(q_, z_);
		var ac_ = this.Qualifying_Encounters();
		var ae_ = d_.ExistsInList<Encounter>(ac_);
		var ag_ = d_.And(ab_, ae_);

		return ag_;
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
		bool? d_(Procedure NoCervixProcedure)
		{
			var o_ = NoCervixProcedure.StatusElement;
			var p_ = new CallStackEntry("ToString", null, null);
			var q_ = context.Deeper(p_);
			var r_ = q_.Operators;
			var s_ = r_.TypeConverter;
			var t_ = s_.Convert<string>(o_);
			var u_ = context.Operators;
			var v_ = u_.Equal(t_, "completed");
			var w_ = NoCervixProcedure.Performed;
			var x_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Normalize_Interval(w_);
			var z_ = u_.End(x_);
			var aa_ = this.Measurement_Period();
			var ac_ = u_.End(aa_);
			var ae_ = u_.SameOrBefore(z_, ac_, null);
			var ag_ = u_.And(v_, ae_);

			return ag_;
		};
		var e_ = context.Operators;
		var f_ = e_.WhereOrNull<Procedure>(c_, d_);
		var g_ = this.Congenital_or_Acquired_Absence_of_Cervix();
		var i_ = b_.RetrieveByValueSet<Condition>(g_, null);
		bool? j_(Condition NoCervixDiagnosis)
		{
			var ah_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Prevalence_Period(NoCervixDiagnosis);
			var ai_ = context.Operators;
			var aj_ = ai_.Start(ah_);
			var ak_ = this.Measurement_Period();
			var am_ = ai_.End(ak_);
			var ao_ = ai_.SameOrBefore(aj_, am_, null);

			return ao_;
		};
		var l_ = e_.WhereOrNull<Condition>(i_, j_);
		var n_ = e_.ListUnion<object>((f_ as IEnumerable<object>), (l_ as IEnumerable<object>));

		return n_;
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
		bool? d_(Observation CervicalCytology)
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
			var n_ = context.Operators;
			var o_ = n_.InList<string>(l_, (m_ as IEnumerable<string>));
			var p_ = CervicalCytology.Category;
			bool? q_(CodeableConcept CervicalCytologyCategory)
			{
				var bd_ = this.laboratory();
				var be_ = FHIRHelpers_4_0_001.ToConcept(CervicalCytologyCategory);
				var bf_ = be_.codes;
				var bg_ = context.Operators;
				var bh_ = bg_.CodeInList(bd_, (bf_ as IEnumerable<CqlCode>));

				return bh_;
			};
			var s_ = n_.WhereOrNull<CodeableConcept>((p_ as IEnumerable<CodeableConcept>), q_);
			var u_ = n_.ExistsInList<CodeableConcept>(s_);
			var w_ = n_.And(o_, u_);
			var x_ = CervicalCytology.Effective;
			var y_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Latest(x_);
			var z_ = this.Measurement_Period();
			var ab_ = n_.End(z_);
			var ad_ = n_.Quantity(3m, "years");
			var af_ = n_.Subtract(ab_, ad_);
			var ai_ = n_.End(z_);
			var ak_ = n_.Interval(af_, ai_, true, true);
			var am_ = n_.ElementInInterval<CqlDateTime>(y_, ak_, null);
			var ap_ = n_.End(z_);
			var aq_ = (ap_ == null);
			var as_ = n_.Not((bool?)aq_);
			var au_ = n_.And(am_, as_);
			var aw_ = n_.And(w_, au_);
			var ax_ = CervicalCytology.Value;
			var ay_ = (ax_ == null);
			var ba_ = n_.Not((bool?)ay_);
			var bc_ = n_.And(aw_, ba_);

			return bc_;
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
		bool? d_(Observation HPVTest)
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
			var n_ = context.Operators;
			var o_ = n_.InList<string>(l_, (m_ as IEnumerable<string>));
			var p_ = HPVTest.Category;
			bool? q_(CodeableConcept HPVTestCategory)
			{
				var bv_ = this.laboratory();
				var bw_ = FHIRHelpers_4_0_001.ToConcept(HPVTestCategory);
				var bx_ = bw_.codes;
				var by_ = context.Operators;
				var bz_ = by_.CodeInList(bv_, (bx_ as IEnumerable<CqlCode>));

				return bz_;
			};
			var s_ = n_.WhereOrNull<CodeableConcept>((p_ as IEnumerable<CodeableConcept>), q_);
			var u_ = n_.ExistsInList<CodeableConcept>(s_);
			var w_ = n_.And(o_, u_);
			var x_ = this.Patient();
			var y_ = x_.BirthDateElement;
			var z_ = y_.Value;
			var ab_ = n_.TypeConverter;
			var ac_ = ab_.Convert<CqlDate>(z_);
			var ad_ = HPVTest.Effective;
			var ae_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Normalize_Interval(ad_);
			var ag_ = n_.Start(ae_);
			var ai_ = n_.DateFrom(ag_);
			var ak_ = n_.CalculateAgeAt(ac_, ai_, "year");
			var am_ = n_.GreaterOrEqual(ak_, (int?)30);
			var ao_ = n_.And(w_, am_);
			var aq_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Latest(ad_);
			var ar_ = this.Measurement_Period();
			var at_ = n_.End(ar_);
			var av_ = n_.Quantity(5m, "years");
			var ax_ = n_.Subtract(at_, av_);
			var ba_ = n_.End(ar_);
			var bc_ = n_.Interval(ax_, ba_, true, true);
			var be_ = n_.ElementInInterval<CqlDateTime>(aq_, bc_, null);
			var bh_ = n_.End(ar_);
			var bi_ = (bh_ == null);
			var bk_ = n_.Not((bool?)bi_);
			var bm_ = n_.And(be_, bk_);
			var bo_ = n_.And(ao_, bm_);
			var bp_ = HPVTest.Value;
			var bq_ = (bp_ == null);
			var bs_ = n_.Not((bool?)bq_);
			var bu_ = n_.And(bo_, bs_);

			return bu_;
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
		var h_ = context.Operators;
		var i_ = h_.InList<string>(f_, (g_ as IEnumerable<string>));

		return i_;
	}


    [CqlDeclaration("isLaboratoryTest")]
    public bool? isLaboratoryTest(Observation observation)
	{
		var a_ = observation.Category;
		bool? b_(CodeableConcept category)
		{
			var g_ = this.laboratory();
			var h_ = FHIRHelpers_4_0_001.ToConcept(category);
			var i_ = h_.codes;
			var j_ = context.Operators;
			var k_ = j_.CodeInList(g_, (i_ as IEnumerable<CqlCode>));

			return k_;
		};
		var c_ = context.Operators;
		var d_ = c_.WhereOrNull<CodeableConcept>((a_ as IEnumerable<CodeableConcept>), b_);
		var f_ = c_.ExistsInList<CodeableConcept>(d_);

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
		var a_ = this.Pap_Test();
		var b_ = context.DataRetriever;
		var c_ = b_.RetrieveByValueSet<Observation>(a_, null);
		bool? d_(Observation CervicalCytology)
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
			var af_ = i_.Not((bool?)ad_);
			var ah_ = i_.And(z_, af_);
			var aj_ = i_.And(j_, ah_);
			var ak_ = CervicalCytology.Value;
			var al_ = (ak_ == null);
			var an_ = i_.Not((bool?)al_);
			var ap_ = i_.And(aj_, an_);

			return ap_;
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
		bool? d_(Observation HPVTest)
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
			var z_ = i_.GreaterOrEqual(x_, (int?)30);
			var ab_ = i_.And(j_, z_);
			var ad_ = this.latest(q_);
			var ae_ = this.Measurement_Period();
			var ag_ = i_.End(ae_);
			var ai_ = i_.Quantity(5m, "years");
			var ak_ = i_.Subtract(ag_, ai_);
			var an_ = i_.End(ae_);
			var ap_ = i_.Interval(ak_, an_, true, true);
			var ar_ = i_.ElementInInterval<CqlDateTime>(ad_, ap_, null);
			var au_ = i_.End(ae_);
			var av_ = (au_ == null);
			var ax_ = i_.Not((bool?)av_);
			var az_ = i_.And(ar_, ax_);
			var bb_ = i_.And(ab_, az_);
			var bc_ = HPVTest.Value;
			var bd_ = (bc_ == null);
			var bf_ = i_.Not((bool?)bd_);
			var bh_ = i_.And(bb_, bf_);

			return bh_;
		};
		var e_ = context.Operators;
		var f_ = e_.WhereOrNull<Observation>(c_, d_);

		return f_;
	}

    [CqlDeclaration("HPV Test Within 5 Years for Women Age 30 and Older (2)")]
    public IEnumerable<Observation> HPV_Test_Within_5_Years_for_Women_Age_30_and_Older__2_() => __HPV_Test_Within_5_Years_for_Women_Age_30_and_Older__2_.Value;

}