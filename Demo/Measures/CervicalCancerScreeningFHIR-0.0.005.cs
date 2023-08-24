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

    private CqlCode laboratory_Value() =>
		new CqlCode("laboratory", "http://terminology.hl7.org/CodeSystem/observation-category", null, null);

    [CqlDeclaration("laboratory")]
    public CqlCode laboratory() => __laboratory.Value;

    private CqlCode[] ObservationCategoryCodes_Value()
	{
		var a_ = new CqlCode("laboratory", "http://terminology.hl7.org/CodeSystem/observation-category", null, null);

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
		var j_ = this.Office_Visit();
		var k_ = context?.DataRetriever.RetrieveByValueSet<Encounter>(j_, null);
		var l_ = this.Preventive_Care_Services___Established_Office_Visit__18_and_Up();
		var m_ = context?.DataRetriever.RetrieveByValueSet<Encounter>(l_, null);
		var n_ = context?.Operators.ListUnion<Encounter>(k_, m_);
		var o_ = this.Preventive_Care_Services_Initial_Office_Visit__18_and_Up();
		var p_ = context?.DataRetriever.RetrieveByValueSet<Encounter>(o_, null);
		var q_ = this.Home_Healthcare_Services();
		var r_ = context?.DataRetriever.RetrieveByValueSet<Encounter>(q_, null);
		var s_ = context?.Operators.ListUnion<Encounter>(p_, r_);
		var t_ = context?.Operators.ListUnion<Encounter>(n_, s_);
		var u_ = this.Telephone_Visits();
		var v_ = context?.DataRetriever.RetrieveByValueSet<Encounter>(u_, null);
		var w_ = this.Online_Assessments();
		var x_ = context?.DataRetriever.RetrieveByValueSet<Encounter>(w_, null);
		var y_ = context?.Operators.ListUnion<Encounter>(v_, x_);
		var z_ = context?.Operators.ListUnion<Encounter>(t_, y_);
		var aa_ = (Encounter ValidEncounter) =>
		{
			var a_ = ValidEncounter?.StatusElement;
			var b_ = (a_ as object);
			var c_ = (context.Deeper(new CallStackEntry("ToString", null, null))?.Operators?.TypeConverter).Convert<string>(b_);
			var d_ = (c_ as object);
			var e_ = context?.Operators.Equal(d_, ("finished" as object));
			var f_ = this.Measurement_Period();
			var g_ = ValidEncounter?.Period;
			var h_ = FHIRHelpers_4_0_001.ToInterval(g_);
			var i_ = context?.Operators.IntervalIncludesInterval<CqlDateTime>(f_, h_, null);

			return context?.Operators.And(e_, i_);
		};

		return context?.Operators.WhereOrNull<Encounter>(z_, aa_);
	}

    [CqlDeclaration("Qualifying Encounters")]
    public IEnumerable<Encounter> Qualifying_Encounters() => __Qualifying_Encounters.Value;

    private bool? Initial_Population_Value()
	{
		var a_ = this.Patient();
		var b_ = a_?.BirthDateElement;
		var c_ = b_?.Value;
		var d_ = (c_ as object);
		var e_ = context?.Operators?.TypeConverter.Convert<CqlDate>(d_);
		var f_ = this.Measurement_Period();
		var g_ = context?.Operators.Start(f_);
		var h_ = context?.Operators.DateFrom(g_);
		var i_ = context?.Operators.CalculateAgeAt(e_, h_, "year");
		var j_ = context?.Operators.Interval((int?)23, (int?)64, true, false);
		var k_ = context?.Operators.ElementInInterval<int?>(i_, j_, null);
		var l_ = this.Patient();
		var m_ = l_?.GenderElement;
		var n_ = (m_ as object);
		var o_ = (context.Deeper(new CallStackEntry("ToString", null, null))?.Operators?.TypeConverter).Convert<string>(n_);
		var p_ = (o_ as object);
		var q_ = context?.Operators.Equal(p_, ("female" as object));
		var r_ = context?.Operators.And(k_, q_);
		var s_ = this.Qualifying_Encounters();
		var t_ = context?.Operators.ExistsInList<Encounter>(s_);

		return context?.Operators.And(r_, t_);
	}

    [CqlDeclaration("Initial Population")]
    public bool? Initial_Population() => __Initial_Population.Value;

    private bool? Denominator_Value() =>
		this.Initial_Population();

    [CqlDeclaration("Denominator")]
    public bool? Denominator() => __Denominator.Value;

    private IEnumerable<object> Absence_of_Cervix_Value()
	{
		var q_ = this.Hysterectomy_with_No_Residual_Cervix();
		var r_ = context?.DataRetriever.RetrieveByValueSet<Procedure>(q_, null);
		var s_ = (Procedure NoCervixProcedure) =>
		{
			var a_ = NoCervixProcedure?.StatusElement;
			var b_ = (a_ as object);
			var c_ = (context.Deeper(new CallStackEntry("ToString", null, null))?.Operators?.TypeConverter).Convert<string>(b_);
			var d_ = (c_ as object);
			var e_ = context?.Operators.Equal(d_, ("completed" as object));
			var f_ = NoCervixProcedure?.Performed;
			var g_ = (f_ as object);
			var h_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Normalize_Interval(g_);
			var i_ = context?.Operators.End(h_);
			var j_ = this.Measurement_Period();
			var k_ = context?.Operators.End(j_);
			var l_ = context?.Operators.SameOrBefore(i_, k_, null);

			return context?.Operators.And(e_, l_);
		};
		var t_ = context?.Operators.WhereOrNull<Procedure>(r_, s_);
		var u_ = (t_ as IEnumerable<object>);
		var v_ = this.Congenital_or_Acquired_Absence_of_Cervix();
		var w_ = context?.DataRetriever.RetrieveByValueSet<Condition>(v_, null);
		var x_ = (Condition NoCervixDiagnosis) =>
		{
			var m_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Prevalence_Period(NoCervixDiagnosis);
			var n_ = context?.Operators.Start(m_);
			var o_ = this.Measurement_Period();
			var p_ = context?.Operators.End(o_);

			return context?.Operators.SameOrBefore(n_, p_, null);
		};
		var y_ = context?.Operators.WhereOrNull<Condition>(w_, x_);
		var z_ = (y_ as IEnumerable<object>);

		return context?.Operators.ListUnion<object>(u_, z_);
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
		var aq_ = this.Pap_Test();
		var ar_ = context?.DataRetriever.RetrieveByValueSet<Observation>(aq_, null);
		var as_ = (Observation CervicalCytology) =>
		{
			var e_ = CervicalCytology?.StatusElement;
			var f_ = (e_ as object);
			var g_ = (context.Deeper(new CallStackEntry("ToString", null, null))?.Operators?.TypeConverter).Convert<string>(f_);
			var h_ = "final";
			var i_ = "amended";
			var j_ = "corrected";
			var k_ = new string[]
			{
				h_,
				i_,
				j_,
			};
			var l_ = (k_ as IEnumerable<string>);
			var m_ = context?.Operators.InList<string>(g_, l_);
			var n_ = CervicalCytology?.Category;
			var o_ = (n_ as IEnumerable<CodeableConcept>);
			var p_ = (CodeableConcept CervicalCytologyCategory) =>
			{
				var a_ = this.laboratory();
				var b_ = FHIRHelpers_4_0_001.ToConcept(CervicalCytologyCategory);
				var c_ = b_?.codes;
				var d_ = (c_ as IEnumerable<CqlCode>);

				return context?.Operators.CodeInList(a_, d_);
			};
			var q_ = context?.Operators.WhereOrNull<CodeableConcept>(o_, p_);
			var r_ = context?.Operators.ExistsInList<CodeableConcept>(q_);
			var s_ = context?.Operators.And(m_, r_);
			var t_ = CervicalCytology?.Effective;
			var u_ = (t_ as object);
			var v_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Latest(u_);
			var w_ = this.Measurement_Period();
			var x_ = context?.Operators.End(w_);
			var y_ = context?.Operators.Quantity(3m, "years");
			var z_ = context?.Operators.Subtract(x_, y_);
			var aa_ = this.Measurement_Period();
			var ab_ = context?.Operators.End(aa_);
			var ac_ = context?.Operators.Interval(z_, ab_, true, true);
			var ad_ = context?.Operators.ElementInInterval<CqlDateTime>(v_, ac_, null);
			var ae_ = this.Measurement_Period();
			var af_ = context?.Operators.End(ae_);
			var ag_ = (af_ == null);
			var ah_ = (bool?)ag_;
			var ai_ = context?.Operators.Not(ah_);
			var aj_ = context?.Operators.And(ad_, ai_);
			var ak_ = context?.Operators.And(s_, aj_);
			var al_ = CervicalCytology?.Value;
			var am_ = (al_ as object);
			var an_ = (am_ == null);
			var ao_ = (bool?)an_;
			var ap_ = context?.Operators.Not(ao_);

			return context?.Operators.And(ak_, ap_);
		};

		return context?.Operators.WhereOrNull<Observation>(ar_, as_);
	}

    [CqlDeclaration("Cervical Cytology Within 3 Years")]
    public IEnumerable<Observation> Cervical_Cytology_Within_3_Years() => __Cervical_Cytology_Within_3_Years.Value;

    private IEnumerable<Observation> HPV_Test_Within_5_Years_for_Women_Age_30_and_Older_Value()
	{
		var bg_ = this.HPV_Test();
		var bh_ = context?.DataRetriever.RetrieveByValueSet<Observation>(bg_, null);
		var bi_ = (Observation HPVTest) =>
		{
			var e_ = HPVTest?.StatusElement;
			var f_ = (e_ as object);
			var g_ = (context.Deeper(new CallStackEntry("ToString", null, null))?.Operators?.TypeConverter).Convert<string>(f_);
			var h_ = "final";
			var i_ = "amended";
			var j_ = "corrected";
			var k_ = new string[]
			{
				h_,
				i_,
				j_,
			};
			var l_ = (k_ as IEnumerable<string>);
			var m_ = context?.Operators.InList<string>(g_, l_);
			var n_ = HPVTest?.Category;
			var o_ = (n_ as IEnumerable<CodeableConcept>);
			var p_ = (CodeableConcept HPVTestCategory) =>
			{
				var a_ = this.laboratory();
				var b_ = FHIRHelpers_4_0_001.ToConcept(HPVTestCategory);
				var c_ = b_?.codes;
				var d_ = (c_ as IEnumerable<CqlCode>);

				return context?.Operators.CodeInList(a_, d_);
			};
			var q_ = context?.Operators.WhereOrNull<CodeableConcept>(o_, p_);
			var r_ = context?.Operators.ExistsInList<CodeableConcept>(q_);
			var s_ = context?.Operators.And(m_, r_);
			var t_ = this.Patient();
			var u_ = t_?.BirthDateElement;
			var v_ = u_?.Value;
			var w_ = (v_ as object);
			var x_ = context?.Operators?.TypeConverter.Convert<CqlDate>(w_);
			var y_ = HPVTest?.Effective;
			var z_ = (y_ as object);
			var aa_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Normalize_Interval(z_);
			var ab_ = context?.Operators.Start(aa_);
			var ac_ = context?.Operators.DateFrom(ab_);
			var ad_ = context?.Operators.CalculateAgeAt(x_, ac_, "year");
			var ae_ = ad_;
			var af_ = (int?)30;
			var ag_ = af_;
			var ah_ = context?.Operators.GreaterOrEqual(ae_, ag_);
			var ai_ = context?.Operators.And(s_, ah_);
			var aj_ = HPVTest?.Effective;
			var ak_ = (aj_ as object);
			var al_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Latest(ak_);
			var am_ = this.Measurement_Period();
			var an_ = context?.Operators.End(am_);
			var ao_ = context?.Operators.Quantity(5m, "years");
			var ap_ = context?.Operators.Subtract(an_, ao_);
			var aq_ = this.Measurement_Period();
			var ar_ = context?.Operators.End(aq_);
			var as_ = context?.Operators.Interval(ap_, ar_, true, true);
			var at_ = context?.Operators.ElementInInterval<CqlDateTime>(al_, as_, null);
			var au_ = this.Measurement_Period();
			var av_ = context?.Operators.End(au_);
			var aw_ = (av_ == null);
			var ax_ = (bool?)aw_;
			var ay_ = context?.Operators.Not(ax_);
			var az_ = context?.Operators.And(at_, ay_);
			var ba_ = context?.Operators.And(ai_, az_);
			var bb_ = HPVTest?.Value;
			var bc_ = (bb_ as object);
			var bd_ = (bc_ == null);
			var be_ = (bool?)bd_;
			var bf_ = context?.Operators.Not(be_);

			return context?.Operators.And(ba_, bf_);
		};

		return context?.Operators.WhereOrNull<Observation>(bh_, bi_);
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
		var a_ = observation?.StatusElement;
		var b_ = (a_ as object);
		var c_ = (context.Deeper(new CallStackEntry("ToString", null, null))?.Operators?.TypeConverter).Convert<string>(b_);
		var d_ = "final";
		var e_ = "amended";
		var f_ = "corrected";
		var g_ = new string[]
		{
			d_,
			e_,
			f_,
		};
		var h_ = (g_ as IEnumerable<string>);

		return context?.Operators.InList<string>(c_, h_);
	}


    [CqlDeclaration("isLaboratoryTest")]
    public bool? isLaboratoryTest(Observation observation)
	{
		var e_ = observation?.Category;
		var f_ = (e_ as IEnumerable<CodeableConcept>);
		var g_ = (CodeableConcept category) =>
		{
			var a_ = this.laboratory();
			var b_ = FHIRHelpers_4_0_001.ToConcept(category);
			var c_ = b_?.codes;
			var d_ = (c_ as IEnumerable<CqlCode>);

			return context?.Operators.CodeInList(a_, d_);
		};
		var h_ = context?.Operators.WhereOrNull<CodeableConcept>(f_, g_);

		return context?.Operators.ExistsInList<CodeableConcept>(h_);
	}


    [CqlDeclaration("latest")]
    public CqlDateTime latest(object choice) =>
		MATGlobalCommonFunctionsFHIR4_6_1_000.Latest(choice);


    private IEnumerable<Observation> Cervical_Cytology_Within_3_Years__2__Value()
	{
		var aa_ = this.Pap_Test();
		var ab_ = context?.DataRetriever.RetrieveByValueSet<Observation>(aa_, null);
		var ac_ = (Observation CervicalCytology) =>
		{
			var a_ = this.isComplete(CervicalCytology);
			var b_ = this.isLaboratoryTest(CervicalCytology);
			var c_ = context?.Operators.And(a_, b_);
			var d_ = CervicalCytology?.Effective;
			var e_ = (d_ as object);
			var f_ = this.latest(e_);
			var g_ = this.Measurement_Period();
			var h_ = context?.Operators.End(g_);
			var i_ = context?.Operators.Quantity(3m, "years");
			var j_ = context?.Operators.Subtract(h_, i_);
			var k_ = this.Measurement_Period();
			var l_ = context?.Operators.End(k_);
			var m_ = context?.Operators.Interval(j_, l_, true, true);
			var n_ = context?.Operators.ElementInInterval<CqlDateTime>(f_, m_, null);
			var o_ = this.Measurement_Period();
			var p_ = context?.Operators.End(o_);
			var q_ = (p_ == null);
			var r_ = (bool?)q_;
			var s_ = context?.Operators.Not(r_);
			var t_ = context?.Operators.And(n_, s_);
			var u_ = context?.Operators.And(c_, t_);
			var v_ = CervicalCytology?.Value;
			var w_ = (v_ as object);
			var x_ = (w_ == null);
			var y_ = (bool?)x_;
			var z_ = context?.Operators.Not(y_);

			return context?.Operators.And(u_, z_);
		};

		return context?.Operators.WhereOrNull<Observation>(ab_, ac_);
	}

    [CqlDeclaration("Cervical Cytology Within 3 Years (2)")]
    public IEnumerable<Observation> Cervical_Cytology_Within_3_Years__2_() => __Cervical_Cytology_Within_3_Years__2_.Value;

    [CqlDeclaration("toInterval")]
    public CqlInterval<CqlDateTime> toInterval(object choice) =>
		MATGlobalCommonFunctionsFHIR4_6_1_000.Normalize_Interval(choice);


    private IEnumerable<Observation> HPV_Test_Within_5_Years_for_Women_Age_30_and_Older__2__Value()
	{
		var aq_ = this.HPV_Test();
		var ar_ = context?.DataRetriever.RetrieveByValueSet<Observation>(aq_, null);
		var as_ = (Observation HPVTest) =>
		{
			var a_ = this.isComplete(HPVTest);
			var b_ = this.isLaboratoryTest(HPVTest);
			var c_ = context?.Operators.And(a_, b_);
			var d_ = this.Patient();
			var e_ = d_?.BirthDateElement;
			var f_ = e_?.Value;
			var g_ = (f_ as object);
			var h_ = context?.Operators?.TypeConverter.Convert<CqlDate>(g_);
			var i_ = HPVTest?.Effective;
			var j_ = (i_ as object);
			var k_ = this.toInterval(j_);
			var l_ = context?.Operators.Start(k_);
			var m_ = context?.Operators.DateFrom(l_);
			var n_ = context?.Operators.CalculateAgeAt(h_, m_, "year");
			var o_ = n_;
			var p_ = (int?)30;
			var q_ = p_;
			var r_ = context?.Operators.GreaterOrEqual(o_, q_);
			var s_ = context?.Operators.And(c_, r_);
			var t_ = HPVTest?.Effective;
			var u_ = (t_ as object);
			var v_ = this.latest(u_);
			var w_ = this.Measurement_Period();
			var x_ = context?.Operators.End(w_);
			var y_ = context?.Operators.Quantity(5m, "years");
			var z_ = context?.Operators.Subtract(x_, y_);
			var aa_ = this.Measurement_Period();
			var ab_ = context?.Operators.End(aa_);
			var ac_ = context?.Operators.Interval(z_, ab_, true, true);
			var ad_ = context?.Operators.ElementInInterval<CqlDateTime>(v_, ac_, null);
			var ae_ = this.Measurement_Period();
			var af_ = context?.Operators.End(ae_);
			var ag_ = (af_ == null);
			var ah_ = (bool?)ag_;
			var ai_ = context?.Operators.Not(ah_);
			var aj_ = context?.Operators.And(ad_, ai_);
			var ak_ = context?.Operators.And(s_, aj_);
			var al_ = HPVTest?.Value;
			var am_ = (al_ as object);
			var an_ = (am_ == null);
			var ao_ = (bool?)an_;
			var ap_ = context?.Operators.Not(ao_);

			return context?.Operators.And(ak_, ap_);
		};

		return context?.Operators.WhereOrNull<Observation>(ar_, as_);
	}

    [CqlDeclaration("HPV Test Within 5 Years for Women Age 30 and Older (2)")]
    public IEnumerable<Observation> HPV_Test_Within_5_Years_for_Women_Age_30_and_Older__2_() => __HPV_Test_Within_5_Years_for_Women_Age_30_and_Older__2_.Value;

}