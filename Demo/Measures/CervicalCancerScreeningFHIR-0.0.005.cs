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
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.111.12.1016", 
			null);

    [CqlDeclaration("Congenital or Acquired Absence of Cervix")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.111.12.1016")]
    public CqlValueSet Congenital_or_Acquired_Absence_of_Cervix() => __Congenital_or_Acquired_Absence_of_Cervix.Value;

    private CqlValueSet Home_Healthcare_Services_Value() =>
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1016", 
			null);

    [CqlDeclaration("Home Healthcare Services")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1016")]
    public CqlValueSet Home_Healthcare_Services() => __Home_Healthcare_Services.Value;

    private CqlValueSet HPV_Test_Value() =>
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.110.12.1059", 
			null);

    [CqlDeclaration("HPV Test")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.110.12.1059")]
    public CqlValueSet HPV_Test() => __HPV_Test.Value;

    private CqlValueSet Hysterectomy_with_No_Residual_Cervix_Value() =>
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.198.12.1014", 
			null);

    [CqlDeclaration("Hysterectomy with No Residual Cervix")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.198.12.1014")]
    public CqlValueSet Hysterectomy_with_No_Residual_Cervix() => __Hysterectomy_with_No_Residual_Cervix.Value;

    private CqlValueSet Office_Visit_Value() =>
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1001", 
			null);

    [CqlDeclaration("Office Visit")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1001")]
    public CqlValueSet Office_Visit() => __Office_Visit.Value;

    private CqlValueSet Online_Assessments_Value() =>
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1089", 
			null);

    [CqlDeclaration("Online Assessments")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1089")]
    public CqlValueSet Online_Assessments() => __Online_Assessments.Value;

    private CqlValueSet Pap_Test_Value() =>
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.108.12.1017", 
			null);

    [CqlDeclaration("Pap Test")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.108.12.1017")]
    public CqlValueSet Pap_Test() => __Pap_Test.Value;

    private CqlValueSet Preventive_Care_Services___Established_Office_Visit__18_and_Up_Value() =>
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1025", 
			null);

    [CqlDeclaration("Preventive Care Services - Established Office Visit, 18 and Up")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1025")]
    public CqlValueSet Preventive_Care_Services___Established_Office_Visit__18_and_Up() => __Preventive_Care_Services___Established_Office_Visit__18_and_Up.Value;

    private CqlValueSet Preventive_Care_Services_Initial_Office_Visit__18_and_Up_Value() =>
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1023", 
			null);

    [CqlDeclaration("Preventive Care Services-Initial Office Visit, 18 and Up")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1023")]
    public CqlValueSet Preventive_Care_Services_Initial_Office_Visit__18_and_Up() => __Preventive_Care_Services_Initial_Office_Visit__18_and_Up.Value;

    private CqlValueSet Telephone_Visits_Value() =>
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1080", 
			null);

    [CqlDeclaration("Telephone Visits")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1080")]
    public CqlValueSet Telephone_Visits() => __Telephone_Visits.Value;

    private CqlCode laboratory_Value() =>
		new CqlCode("laboratory", 
			"http://terminology.hl7.org/CodeSystem/observation-category", 
			null, 
			null);

    [CqlDeclaration("laboratory")]
    public CqlCode laboratory() => __laboratory.Value;

    private CqlCode[] ObservationCategoryCodes_Value()
	{
		var a_ = new CqlCode("laboratory", 
			"http://terminology.hl7.org/CodeSystem/observation-category", 
			null, 
			null);

		return new CqlCode[]
		{
			a_,
		};
	}

    [CqlDeclaration("ObservationCategoryCodes")]
    public CqlCode[] ObservationCategoryCodes() => __ObservationCategoryCodes.Value;

    private CqlInterval<CqlDateTime> Measurement_Period_Value()
	{
		var a_ = context?.Operators.ConvertIntegerToDecimal(default);
		var b_ = context?.Operators.DateTime((int?)2019, (int?)1, (int?)1, (int?)0, (int?)0, (int?)0, (int?)0, a_);
		var c_ = context?.Operators.ConvertIntegerToDecimal(default);
		var d_ = context?.Operators.DateTime((int?)2020, (int?)1, (int?)1, (int?)0, (int?)0, (int?)0, (int?)0, c_);
		var e_ = context?.Operators.Interval(b_, d_, true, false);
		var f_ = (e_ as object);
		var g_ = context.ResolveParameter("CervicalCancerScreeningFHIR-0.0.005", "Measurement Period", f_);

		return (CqlInterval<CqlDateTime>)g_;
	}

    [CqlDeclaration("Measurement Period")]
    public CqlInterval<CqlDateTime> Measurement_Period() => __Measurement_Period.Value;

    private Patient Patient_Value()
	{
		var a_ = context?.DataRetriever.RetrieveByValueSet<Patient>(null, null);

		return context?.Operators.SingleOrNull<Patient>(a_);
	}

    [CqlDeclaration("Patient")]
    public Patient Patient() => __Patient.Value;

    private IEnumerable<Coding> SDE_Ethnicity_Value() =>
		SupplementalDataElementsFHIR4_2_0_000.SDE_Ethnicity();

    [CqlDeclaration("SDE Ethnicity")]
    public IEnumerable<Coding> SDE_Ethnicity() => __SDE_Ethnicity.Value;

    private IEnumerable<Tuples.Tuple_CFQHSgYJOXjAOCKdWLdZNNHDG> SDE_Payer_Value() =>
		SupplementalDataElementsFHIR4_2_0_000.SDE_Payer();

    [CqlDeclaration("SDE Payer")]
    public IEnumerable<Tuples.Tuple_CFQHSgYJOXjAOCKdWLdZNNHDG> SDE_Payer() => __SDE_Payer.Value;

    private IEnumerable<Coding> SDE_Race_Value() =>
		SupplementalDataElementsFHIR4_2_0_000.SDE_Race();

    [CqlDeclaration("SDE Race")]
    public IEnumerable<Coding> SDE_Race() => __SDE_Race.Value;

    private CqlCode SDE_Sex_Value() =>
		SupplementalDataElementsFHIR4_2_0_000.SDE_Sex();

    [CqlDeclaration("SDE Sex")]
    public CqlCode SDE_Sex() => __SDE_Sex.Value;

    private IEnumerable<Encounter> Qualifying_Encounters_Value()
	{
		var a_ = this.Office_Visit();
		var b_ = context?.DataRetriever.RetrieveByValueSet<Encounter>(a_, null);
		var c_ = this.Preventive_Care_Services___Established_Office_Visit__18_and_Up();
		var d_ = context?.DataRetriever.RetrieveByValueSet<Encounter>(c_, null);
		var e_ = context?.Operators.ListUnion<Encounter>(b_, d_);
		var f_ = this.Preventive_Care_Services_Initial_Office_Visit__18_and_Up();
		var g_ = context?.DataRetriever.RetrieveByValueSet<Encounter>(f_, null);
		var h_ = this.Home_Healthcare_Services();
		var i_ = context?.DataRetriever.RetrieveByValueSet<Encounter>(h_, null);
		var j_ = context?.Operators.ListUnion<Encounter>(g_, i_);
		var k_ = context?.Operators.ListUnion<Encounter>(e_, j_);
		var l_ = this.Telephone_Visits();
		var m_ = context?.DataRetriever.RetrieveByValueSet<Encounter>(l_, null);
		var n_ = this.Online_Assessments();
		var o_ = context?.DataRetriever.RetrieveByValueSet<Encounter>(n_, null);
		var p_ = context?.Operators.ListUnion<Encounter>(m_, o_);
		var q_ = context?.Operators.ListUnion<Encounter>(k_, p_);
		var r_ = (Encounter ValidEncounter) =>
		{
			var a_ = (ValidEncounter?.StatusElement as object);
			var b_ = (context.Deeper(new CallStackEntry("ToString", 
		null, 
		null))?.Operators?.TypeConverter).Convert<string>(a_);
			var c_ = (b_ as object);
			var d_ = context?.Operators.Equal(c_, ("finished" as object));
			var e_ = this.Measurement_Period();
			var f_ = ValidEncounter?.Period;
			var g_ = FHIRHelpers_4_0_001.ToInterval(f_);
			var h_ = context?.Operators.IntervalIncludesInterval<CqlDateTime>(e_, g_, null);

			return context?.Operators.And(d_, h_);
		};

		return context?.Operators.WhereOrNull<Encounter>(q_, r_);
	}

    [CqlDeclaration("Qualifying Encounters")]
    public IEnumerable<Encounter> Qualifying_Encounters() => __Qualifying_Encounters.Value;

    private bool? Initial_Population_Value()
	{
		var a_ = (this.Patient()?.BirthDateElement?.Value as object);
		var b_ = context?.Operators?.TypeConverter.Convert<CqlDate>(a_);
		var c_ = this.Measurement_Period();
		var d_ = context?.Operators.Start(c_);
		var e_ = context?.Operators.DateFrom(d_);
		var f_ = context?.Operators.CalculateAgeAt(b_, e_, "year");
		var g_ = context?.Operators.Interval((int?)23, (int?)64, true, false);
		var h_ = context?.Operators.ElementInInterval<int?>(f_, g_, null);
		var i_ = (this.Patient()?.GenderElement as object);
		var j_ = (context.Deeper(new CallStackEntry("ToString", 
		null, 
		null))?.Operators?.TypeConverter).Convert<string>(i_);
		var k_ = (j_ as object);
		var l_ = context?.Operators.Equal(k_, ("female" as object));
		var m_ = context?.Operators.And(h_, l_);
		var n_ = this.Qualifying_Encounters();
		var o_ = context?.Operators.ExistsInList<Encounter>(n_);

		return context?.Operators.And(m_, o_);
	}

    [CqlDeclaration("Initial Population")]
    public bool? Initial_Population() => __Initial_Population.Value;

    private bool? Denominator_Value() =>
		this.Initial_Population();

    [CqlDeclaration("Denominator")]
    public bool? Denominator() => __Denominator.Value;

    private IEnumerable<object> Absence_of_Cervix_Value()
	{
		var a_ = this.Hysterectomy_with_No_Residual_Cervix();
		var b_ = context?.DataRetriever.RetrieveByValueSet<Procedure>(a_, null);
		var c_ = (Procedure NoCervixProcedure) =>
		{
			var a_ = (NoCervixProcedure?.StatusElement as object);
			var b_ = (context.Deeper(new CallStackEntry("ToString", 
		null, 
		null))?.Operators?.TypeConverter).Convert<string>(a_);
			var c_ = (b_ as object);
			var d_ = context?.Operators.Equal(c_, ("completed" as object));
			var e_ = (NoCervixProcedure?.Performed as object);
			var f_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Normalize_Interval(e_);
			var g_ = context?.Operators.End(f_);
			var h_ = this.Measurement_Period();
			var i_ = context?.Operators.End(h_);
			var j_ = context?.Operators.SameOrBefore(g_, i_, null);

			return context?.Operators.And(d_, j_);
		};
		var d_ = context?.Operators.WhereOrNull<Procedure>(b_, c_);
		var e_ = (d_ as IEnumerable<object>);
		var f_ = this.Congenital_or_Acquired_Absence_of_Cervix();
		var g_ = context?.DataRetriever.RetrieveByValueSet<Condition>(f_, null);
		var h_ = (Condition NoCervixDiagnosis) =>
		{
			var a_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Prevalence_Period(NoCervixDiagnosis);
			var b_ = context?.Operators.Start(a_);
			var c_ = this.Measurement_Period();
			var d_ = context?.Operators.End(c_);

			return context?.Operators.SameOrBefore(b_, d_, null);
		};
		var i_ = context?.Operators.WhereOrNull<Condition>(g_, h_);
		var j_ = (i_ as IEnumerable<object>);

		return context?.Operators.ListUnion<object>(e_, j_);
	}

    [CqlDeclaration("Absence of Cervix")]
    public IEnumerable<object> Absence_of_Cervix() => __Absence_of_Cervix.Value;

    private bool? Denominator_Exclusions_Value()
	{
		var a_ = HospiceFHIR4_2_3_000.Has_Hospice();
		var b_ = this.Absence_of_Cervix();
		var c_ = context?.Operators.ExistsInList<object>(b_);
		var d_ = context?.Operators.Or(a_, c_);
		var e_ = PalliativeCareFHIR_0_6_000.Palliative_Care_in_the_Measurement_Period();

		return context?.Operators.Or(d_, e_);
	}

    [CqlDeclaration("Denominator Exclusions")]
    public bool? Denominator_Exclusions() => __Denominator_Exclusions.Value;

    private IEnumerable<Observation> Cervical_Cytology_Within_3_Years_Value()
	{
		var a_ = this.Pap_Test();
		var b_ = context?.DataRetriever.RetrieveByValueSet<Observation>(a_, null);
		var c_ = (Observation CervicalCytology) =>
		{
			var a_ = (CervicalCytology?.StatusElement as object);
			var b_ = (context.Deeper(new CallStackEntry("ToString", 
		null, 
		null))?.Operators?.TypeConverter).Convert<string>(a_);
			var c_ = "final";
			var d_ = "amended";
			var e_ = "corrected";
			var f_ = new string[]
			{
				c_,
				d_,
				e_,
			};
			var g_ = (f_ as IEnumerable<string>);
			var h_ = context?.Operators.InList<string>(b_, g_);
			var i_ = (CervicalCytology?.Category as IEnumerable<CodeableConcept>);
			var j_ = (CodeableConcept CervicalCytologyCategory) =>
			{
				var a_ = this.laboratory();
				var b_ = (FHIRHelpers_4_0_001.ToConcept(CervicalCytologyCategory)?.codes as IEnumerable<CqlCode>);

				return context?.Operators.CodeInList(a_, b_);
			};
			var k_ = context?.Operators.WhereOrNull<CodeableConcept>(i_, j_);
			var l_ = context?.Operators.ExistsInList<CodeableConcept>(k_);
			var m_ = context?.Operators.And(h_, l_);
			var n_ = (CervicalCytology?.Effective as object);
			var o_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Latest(n_);
			var p_ = this.Measurement_Period();
			var q_ = context?.Operators.End(p_);
			var r_ = context?.Operators.Quantity(3m, "years");
			var s_ = context?.Operators.Subtract(q_, r_);
			var t_ = this.Measurement_Period();
			var u_ = context?.Operators.End(t_);
			var v_ = context?.Operators.Interval(s_, u_, true, true);
			var w_ = context?.Operators.ElementInInterval<CqlDateTime>(o_, v_, null);
			var x_ = this.Measurement_Period();
			var y_ = context?.Operators.End(x_);
			var z_ = (bool?)(y_ == null);
			var aa_ = context?.Operators.Not(z_);
			var ab_ = context?.Operators.And(w_, aa_);
			var ac_ = context?.Operators.And(m_, ab_);
			var ad_ = (bool?)((CervicalCytology?.Value as object) == null);
			var ae_ = context?.Operators.Not(ad_);

			return context?.Operators.And(ac_, ae_);
		};

		return context?.Operators.WhereOrNull<Observation>(b_, c_);
	}

    [CqlDeclaration("Cervical Cytology Within 3 Years")]
    public IEnumerable<Observation> Cervical_Cytology_Within_3_Years() => __Cervical_Cytology_Within_3_Years.Value;

    private IEnumerable<Observation> HPV_Test_Within_5_Years_for_Women_Age_30_and_Older_Value()
	{
		var a_ = this.HPV_Test();
		var b_ = context?.DataRetriever.RetrieveByValueSet<Observation>(a_, null);
		var c_ = (Observation HPVTest) =>
		{
			var a_ = (HPVTest?.StatusElement as object);
			var b_ = (context.Deeper(new CallStackEntry("ToString", 
		null, 
		null))?.Operators?.TypeConverter).Convert<string>(a_);
			var c_ = "final";
			var d_ = "amended";
			var e_ = "corrected";
			var f_ = new string[]
			{
				c_,
				d_,
				e_,
			};
			var g_ = (f_ as IEnumerable<string>);
			var h_ = context?.Operators.InList<string>(b_, g_);
			var i_ = (HPVTest?.Category as IEnumerable<CodeableConcept>);
			var j_ = (CodeableConcept HPVTestCategory) =>
			{
				var a_ = this.laboratory();
				var b_ = (FHIRHelpers_4_0_001.ToConcept(HPVTestCategory)?.codes as IEnumerable<CqlCode>);

				return context?.Operators.CodeInList(a_, b_);
			};
			var k_ = context?.Operators.WhereOrNull<CodeableConcept>(i_, j_);
			var l_ = context?.Operators.ExistsInList<CodeableConcept>(k_);
			var m_ = context?.Operators.And(h_, l_);
			var n_ = (this.Patient()?.BirthDateElement?.Value as object);
			var o_ = context?.Operators?.TypeConverter.Convert<CqlDate>(n_);
			var p_ = (HPVTest?.Effective as object);
			var q_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Normalize_Interval(p_);
			var r_ = context?.Operators.Start(q_);
			var s_ = context?.Operators.DateFrom(r_);
			var t_ = context?.Operators.CalculateAgeAt(o_, s_, "year");
			var u_ = (t_ as object);
			var v_ = ((int?)30 as object);
			var w_ = context?.Operators.GreaterOrEqual(u_, v_);
			var x_ = context?.Operators.And(m_, w_);
			var y_ = (HPVTest?.Effective as object);
			var z_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Latest(y_);
			var aa_ = this.Measurement_Period();
			var ab_ = context?.Operators.End(aa_);
			var ac_ = context?.Operators.Quantity(5m, "years");
			var ad_ = context?.Operators.Subtract(ab_, ac_);
			var ae_ = this.Measurement_Period();
			var af_ = context?.Operators.End(ae_);
			var ag_ = context?.Operators.Interval(ad_, af_, true, true);
			var ah_ = context?.Operators.ElementInInterval<CqlDateTime>(z_, ag_, null);
			var ai_ = this.Measurement_Period();
			var aj_ = context?.Operators.End(ai_);
			var ak_ = (bool?)(aj_ == null);
			var al_ = context?.Operators.Not(ak_);
			var am_ = context?.Operators.And(ah_, al_);
			var an_ = context?.Operators.And(x_, am_);
			var ao_ = (bool?)((HPVTest?.Value as object) == null);
			var ap_ = context?.Operators.Not(ao_);

			return context?.Operators.And(an_, ap_);
		};

		return context?.Operators.WhereOrNull<Observation>(b_, c_);
	}

    [CqlDeclaration("HPV Test Within 5 Years for Women Age 30 and Older")]
    public IEnumerable<Observation> HPV_Test_Within_5_Years_for_Women_Age_30_and_Older() => __HPV_Test_Within_5_Years_for_Women_Age_30_and_Older.Value;

    private bool? Numerator_Value()
	{
		var a_ = this.Cervical_Cytology_Within_3_Years();
		var b_ = context?.Operators.ExistsInList<Observation>(a_);
		var c_ = this.HPV_Test_Within_5_Years_for_Women_Age_30_and_Older();
		var d_ = context?.Operators.ExistsInList<Observation>(c_);

		return context?.Operators.Or(b_, d_);
	}

    [CqlDeclaration("Numerator")]
    public bool? Numerator() => __Numerator.Value;

    [CqlDeclaration("isComplete")]
    public bool? isComplete(Observation observation)
	{
		var a_ = (observation?.StatusElement as object);
		var b_ = (context.Deeper(new CallStackEntry("ToString", 
		null, 
		null))?.Operators?.TypeConverter).Convert<string>(a_);
		var c_ = "final";
		var d_ = "amended";
		var e_ = "corrected";
		var f_ = new string[]
		{
			c_,
			d_,
			e_,
		};
		var g_ = (f_ as IEnumerable<string>);

		return context?.Operators.InList<string>(b_, g_);
	}


    [CqlDeclaration("isLaboratoryTest")]
    public bool? isLaboratoryTest(Observation observation)
	{
		var a_ = (observation?.Category as IEnumerable<CodeableConcept>);
		var b_ = (CodeableConcept category) =>
		{
			var a_ = this.laboratory();
			var b_ = (FHIRHelpers_4_0_001.ToConcept(category)?.codes as IEnumerable<CqlCode>);

			return context?.Operators.CodeInList(a_, b_);
		};
		var c_ = context?.Operators.WhereOrNull<CodeableConcept>(a_, b_);

		return context?.Operators.ExistsInList<CodeableConcept>(c_);
	}


    [CqlDeclaration("latest")]
    public CqlDateTime latest(object choice) =>
		MATGlobalCommonFunctionsFHIR4_6_1_000.Latest(choice);


    private IEnumerable<Observation> Cervical_Cytology_Within_3_Years__2__Value()
	{
		var a_ = this.Pap_Test();
		var b_ = context?.DataRetriever.RetrieveByValueSet<Observation>(a_, null);
		var c_ = (Observation CervicalCytology) =>
		{
			var a_ = this.isComplete(CervicalCytology);
			var b_ = this.isLaboratoryTest(CervicalCytology);
			var c_ = context?.Operators.And(a_, b_);
			var d_ = (CervicalCytology?.Effective as object);
			var e_ = this.latest(d_);
			var f_ = this.Measurement_Period();
			var g_ = context?.Operators.End(f_);
			var h_ = context?.Operators.Quantity(3m, "years");
			var i_ = context?.Operators.Subtract(g_, h_);
			var j_ = this.Measurement_Period();
			var k_ = context?.Operators.End(j_);
			var l_ = context?.Operators.Interval(i_, k_, true, true);
			var m_ = context?.Operators.ElementInInterval<CqlDateTime>(e_, l_, null);
			var n_ = this.Measurement_Period();
			var o_ = context?.Operators.End(n_);
			var p_ = (bool?)(o_ == null);
			var q_ = context?.Operators.Not(p_);
			var r_ = context?.Operators.And(m_, q_);
			var s_ = context?.Operators.And(c_, r_);
			var t_ = (bool?)((CervicalCytology?.Value as object) == null);
			var u_ = context?.Operators.Not(t_);

			return context?.Operators.And(s_, u_);
		};

		return context?.Operators.WhereOrNull<Observation>(b_, c_);
	}

    [CqlDeclaration("Cervical Cytology Within 3 Years (2)")]
    public IEnumerable<Observation> Cervical_Cytology_Within_3_Years__2_() => __Cervical_Cytology_Within_3_Years__2_.Value;

    [CqlDeclaration("toInterval")]
    public CqlInterval<CqlDateTime> toInterval(object choice) =>
		MATGlobalCommonFunctionsFHIR4_6_1_000.Normalize_Interval(choice);


    private IEnumerable<Observation> HPV_Test_Within_5_Years_for_Women_Age_30_and_Older__2__Value()
	{
		var a_ = this.HPV_Test();
		var b_ = context?.DataRetriever.RetrieveByValueSet<Observation>(a_, null);
		var c_ = (Observation HPVTest) =>
		{
			var a_ = this.isComplete(HPVTest);
			var b_ = this.isLaboratoryTest(HPVTest);
			var c_ = context?.Operators.And(a_, b_);
			var d_ = (this.Patient()?.BirthDateElement?.Value as object);
			var e_ = context?.Operators?.TypeConverter.Convert<CqlDate>(d_);
			var f_ = (HPVTest?.Effective as object);
			var g_ = this.toInterval(f_);
			var h_ = context?.Operators.Start(g_);
			var i_ = context?.Operators.DateFrom(h_);
			var j_ = context?.Operators.CalculateAgeAt(e_, i_, "year");
			var k_ = (j_ as object);
			var l_ = ((int?)30 as object);
			var m_ = context?.Operators.GreaterOrEqual(k_, l_);
			var n_ = context?.Operators.And(c_, m_);
			var o_ = (HPVTest?.Effective as object);
			var p_ = this.latest(o_);
			var q_ = this.Measurement_Period();
			var r_ = context?.Operators.End(q_);
			var s_ = context?.Operators.Quantity(5m, "years");
			var t_ = context?.Operators.Subtract(r_, s_);
			var u_ = this.Measurement_Period();
			var v_ = context?.Operators.End(u_);
			var w_ = context?.Operators.Interval(t_, v_, true, true);
			var x_ = context?.Operators.ElementInInterval<CqlDateTime>(p_, w_, null);
			var y_ = this.Measurement_Period();
			var z_ = context?.Operators.End(y_);
			var aa_ = (bool?)(z_ == null);
			var ab_ = context?.Operators.Not(aa_);
			var ac_ = context?.Operators.And(x_, ab_);
			var ad_ = context?.Operators.And(n_, ac_);
			var ae_ = (bool?)((HPVTest?.Value as object) == null);
			var af_ = context?.Operators.Not(ae_);

			return context?.Operators.And(ad_, af_);
		};

		return context?.Operators.WhereOrNull<Observation>(b_, c_);
	}

    [CqlDeclaration("HPV Test Within 5 Years for Women Age 30 and Older (2)")]
    public IEnumerable<Observation> HPV_Test_Within_5_Years_for_Women_Age_30_and_Older__2_() => __HPV_Test_Within_5_Years_for_Women_Age_30_and_Older__2_.Value;

}