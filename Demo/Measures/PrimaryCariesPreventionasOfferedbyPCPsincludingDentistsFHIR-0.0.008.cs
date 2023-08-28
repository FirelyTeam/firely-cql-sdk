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
[CqlLibrary("PrimaryCariesPreventionasOfferedbyPCPsincludingDentistsFHIR", "0.0.008")]
public class PrimaryCariesPreventionasOfferedbyPCPsincludingDentistsFHIR_0_0_008
{


    internal CqlContext context;

    #region Cached values

    internal Lazy<CqlValueSet> __Clinical_Oral_Evaluation;
    internal Lazy<CqlValueSet> __Fluoride_Varnish_Application_for_Children;
    internal Lazy<CqlValueSet> __Office_Visit;
    internal Lazy<CqlValueSet> __Online_Assessments;
    internal Lazy<CqlValueSet> __Preventive_Care___Established_Office_Visit__0_to_17;
    internal Lazy<CqlValueSet> __Preventive_Care_Services___Established_Office_Visit__18_and_Up;
    internal Lazy<CqlValueSet> __Preventive_Care_Services_Initial_Office_Visit__18_and_Up;
    internal Lazy<CqlValueSet> __Preventive_Care__Initial_Office_Visit__0_to_17;
    internal Lazy<CqlValueSet> __Telephone_Visits;
    internal Lazy<CqlCode> __Birth_date;
    internal Lazy<CqlCode[]> __LOINC;
    internal Lazy<CqlInterval<CqlDateTime>> __Measurement_Period;
    internal Lazy<Patient> __Patient;
    internal Lazy<IEnumerable<Coding>> __SDE_Ethnicity;
    internal Lazy<IEnumerable<Tuples.Tuple_CFQHSgYJOXjAOCKdWLdZNNHDG>> __SDE_Payer;
    internal Lazy<IEnumerable<Coding>> __SDE_Race;
    internal Lazy<CqlCode> __SDE_Sex;
    internal Lazy<IEnumerable<Encounter>> __Qualifying_Encounters;
    internal Lazy<bool?> __Initial_Population;
    internal Lazy<bool?> __Denominator;
    internal Lazy<bool?> __Denominator_Exclusions;
    internal Lazy<bool?> __Stratification_1;
    internal Lazy<bool?> __Stratification_2;
    internal Lazy<bool?> __Stratification_3;
    internal Lazy<bool?> __Numerator;

    #endregion
    public PrimaryCariesPreventionasOfferedbyPCPsincludingDentistsFHIR_0_0_008(CqlContext context)
    {
        this.context = context ?? throw new ArgumentNullException("context");

        FHIRHelpers_4_0_001 = new FHIRHelpers_4_0_001(context);
        SupplementalDataElementsFHIR4_2_0_000 = new SupplementalDataElementsFHIR4_2_0_000(context);
        MATGlobalCommonFunctionsFHIR4_6_1_000 = new MATGlobalCommonFunctionsFHIR4_6_1_000(context);
        HospiceFHIR4_2_3_000 = new HospiceFHIR4_2_3_000(context);

        __Clinical_Oral_Evaluation = new Lazy<CqlValueSet>(this.Clinical_Oral_Evaluation_Value);
        __Fluoride_Varnish_Application_for_Children = new Lazy<CqlValueSet>(this.Fluoride_Varnish_Application_for_Children_Value);
        __Office_Visit = new Lazy<CqlValueSet>(this.Office_Visit_Value);
        __Online_Assessments = new Lazy<CqlValueSet>(this.Online_Assessments_Value);
        __Preventive_Care___Established_Office_Visit__0_to_17 = new Lazy<CqlValueSet>(this.Preventive_Care___Established_Office_Visit__0_to_17_Value);
        __Preventive_Care_Services___Established_Office_Visit__18_and_Up = new Lazy<CqlValueSet>(this.Preventive_Care_Services___Established_Office_Visit__18_and_Up_Value);
        __Preventive_Care_Services_Initial_Office_Visit__18_and_Up = new Lazy<CqlValueSet>(this.Preventive_Care_Services_Initial_Office_Visit__18_and_Up_Value);
        __Preventive_Care__Initial_Office_Visit__0_to_17 = new Lazy<CqlValueSet>(this.Preventive_Care__Initial_Office_Visit__0_to_17_Value);
        __Telephone_Visits = new Lazy<CqlValueSet>(this.Telephone_Visits_Value);
        __Birth_date = new Lazy<CqlCode>(this.Birth_date_Value);
        __LOINC = new Lazy<CqlCode[]>(this.LOINC_Value);
        __Measurement_Period = new Lazy<CqlInterval<CqlDateTime>>(this.Measurement_Period_Value);
        __Patient = new Lazy<Patient>(this.Patient_Value);
        __SDE_Ethnicity = new Lazy<IEnumerable<Coding>>(this.SDE_Ethnicity_Value);
        __SDE_Payer = new Lazy<IEnumerable<Tuples.Tuple_CFQHSgYJOXjAOCKdWLdZNNHDG>>(this.SDE_Payer_Value);
        __SDE_Race = new Lazy<IEnumerable<Coding>>(this.SDE_Race_Value);
        __SDE_Sex = new Lazy<CqlCode>(this.SDE_Sex_Value);
        __Qualifying_Encounters = new Lazy<IEnumerable<Encounter>>(this.Qualifying_Encounters_Value);
        __Initial_Population = new Lazy<bool?>(this.Initial_Population_Value);
        __Denominator = new Lazy<bool?>(this.Denominator_Value);
        __Denominator_Exclusions = new Lazy<bool?>(this.Denominator_Exclusions_Value);
        __Stratification_1 = new Lazy<bool?>(this.Stratification_1_Value);
        __Stratification_2 = new Lazy<bool?>(this.Stratification_2_Value);
        __Stratification_3 = new Lazy<bool?>(this.Stratification_3_Value);
        __Numerator = new Lazy<bool?>(this.Numerator_Value);
    }
    #region Dependencies

    public FHIRHelpers_4_0_001 FHIRHelpers_4_0_001 { get; }
    public SupplementalDataElementsFHIR4_2_0_000 SupplementalDataElementsFHIR4_2_0_000 { get; }
    public MATGlobalCommonFunctionsFHIR4_6_1_000 MATGlobalCommonFunctionsFHIR4_6_1_000 { get; }
    public HospiceFHIR4_2_3_000 HospiceFHIR4_2_3_000 { get; }

    #endregion

    private CqlValueSet Clinical_Oral_Evaluation_Value() =>
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.125.12.1003", null);

    [CqlDeclaration("Clinical Oral Evaluation")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.125.12.1003")]
    public CqlValueSet Clinical_Oral_Evaluation() => __Clinical_Oral_Evaluation.Value;

    private CqlValueSet Fluoride_Varnish_Application_for_Children_Value() =>
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.125.12.1002", null);

    [CqlDeclaration("Fluoride Varnish Application for Children")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.125.12.1002")]
    public CqlValueSet Fluoride_Varnish_Application_for_Children() => __Fluoride_Varnish_Application_for_Children.Value;

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

    private CqlValueSet Preventive_Care___Established_Office_Visit__0_to_17_Value() =>
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1024", null);

    [CqlDeclaration("Preventive Care - Established Office Visit, 0 to 17")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1024")]
    public CqlValueSet Preventive_Care___Established_Office_Visit__0_to_17() => __Preventive_Care___Established_Office_Visit__0_to_17.Value;

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

    private CqlValueSet Preventive_Care__Initial_Office_Visit__0_to_17_Value() =>
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1022", null);

    [CqlDeclaration("Preventive Care- Initial Office Visit, 0 to 17")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1022")]
    public CqlValueSet Preventive_Care__Initial_Office_Visit__0_to_17() => __Preventive_Care__Initial_Office_Visit__0_to_17.Value;

    private CqlValueSet Telephone_Visits_Value() =>
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1080", null);

    [CqlDeclaration("Telephone Visits")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1080")]
    public CqlValueSet Telephone_Visits() => __Telephone_Visits.Value;

    private CqlCode Birth_date_Value()
	{
		var a_ = new CqlCode("21112-8", "http://loinc.org", null, null);

		return a_;
	}

    [CqlDeclaration("Birth date")]
    public CqlCode Birth_date() => __Birth_date.Value;

    private CqlCode[] LOINC_Value()
	{
		var a_ = new CqlCode("21112-8", "http://loinc.org", null, null);
		var b_ = new CqlCode[]
		{
			a_,
		};

		return b_;
	}

    [CqlDeclaration("LOINC")]
    public CqlCode[] LOINC() => __LOINC.Value;

    private CqlInterval<CqlDateTime> Measurement_Period_Value()
	{
		var a_ = context.ResolveParameter("PrimaryCariesPreventionasOfferedbyPCPsincludingDentistsFHIR-0.0.008", "Measurement Period", null);

		return (CqlInterval<CqlDateTime>)a_;
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
		var d_ = this.Preventive_Care___Established_Office_Visit__0_to_17();
		var f_ = b_.RetrieveByValueSet<Encounter>(d_, null);
		var g_ = context.Operators;
		var h_ = g_.ListUnion<Encounter>(c_, f_);
		var i_ = this.Preventive_Care__Initial_Office_Visit__0_to_17();
		var k_ = b_.RetrieveByValueSet<Encounter>(i_, null);
		var l_ = this.Preventive_Care_Services___Established_Office_Visit__18_and_Up();
		var n_ = b_.RetrieveByValueSet<Encounter>(l_, null);
		var p_ = g_.ListUnion<Encounter>(k_, n_);
		var r_ = g_.ListUnion<Encounter>(h_, p_);
		var s_ = this.Preventive_Care_Services_Initial_Office_Visit__18_and_Up();
		var u_ = b_.RetrieveByValueSet<Encounter>(s_, null);
		var v_ = this.Clinical_Oral_Evaluation();
		var x_ = b_.RetrieveByValueSet<Encounter>(v_, null);
		var z_ = g_.ListUnion<Encounter>(u_, x_);
		var ab_ = g_.ListUnion<Encounter>(r_, z_);
		var ac_ = this.Telephone_Visits();
		var ae_ = b_.RetrieveByValueSet<Encounter>(ac_, null);
		var af_ = this.Online_Assessments();
		var ah_ = b_.RetrieveByValueSet<Encounter>(af_, null);
		var aj_ = g_.ListUnion<Encounter>(ae_, ah_);
		var al_ = g_.ListUnion<Encounter>(ab_, aj_);
		bool? am_(Encounter ValidEncounter)
		{
			var ap_ = this.Measurement_Period();
			var aq_ = ValidEncounter.Period;
			var ar_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Normalize_Interval(aq_);
			var as_ = context.Operators;
			var at_ = as_.IntervalIncludesInterval<CqlDateTime>(ap_, ar_, null);
			var au_ = ValidEncounter.StatusElement;
			var av_ = new CallStackEntry("ToString", null, null);
			var aw_ = context.Deeper(av_);
			var ax_ = aw_.Operators;
			var ay_ = ax_.TypeConverter;
			var az_ = ay_.Convert<string>(au_);
			var bb_ = as_.Equal(az_, "finished");
			var bd_ = as_.And(at_, bb_);

			return bd_;
		};
		var ao_ = g_.WhereOrNull<Encounter>(al_, am_);

		return ao_;
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
		var m_ = d_.CalculateAgeAt(f_, k_, "month");
		var o_ = d_.GreaterOrEqual(m_, (int?)6);
		var q_ = a_.BirthDateElement;
		var r_ = q_.Value;
		var t_ = d_.TypeConverter;
		var u_ = t_.Convert<CqlDate>(r_);
		var x_ = d_.Start(g_);
		var z_ = d_.DateFrom(x_);
		var ab_ = d_.CalculateAgeAt(u_, z_, "year");
		var ad_ = d_.Less(ab_, (int?)20);
		var af_ = d_.And(o_, ad_);
		var ag_ = this.Qualifying_Encounters();
		var ai_ = d_.ExistsInList<Encounter>(ag_);
		var ak_ = d_.And(af_, ai_);

		return ak_;
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

    private bool? Denominator_Exclusions_Value()
	{
		var a_ = HospiceFHIR4_2_3_000.Has_Hospice();

		return a_;
	}

    [CqlDeclaration("Denominator Exclusions")]
    public bool? Denominator_Exclusions() => __Denominator_Exclusions.Value;

    private bool? Stratification_1_Value()
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
		var m_ = d_.CalculateAgeAt(f_, k_, "month");
		var o_ = d_.GreaterOrEqual(m_, (int?)6);
		var q_ = a_.BirthDateElement;
		var r_ = q_.Value;
		var t_ = d_.TypeConverter;
		var u_ = t_.Convert<CqlDate>(r_);
		var x_ = d_.Start(g_);
		var z_ = d_.DateFrom(x_);
		var ab_ = d_.CalculateAgeAt(u_, z_, "year");
		var ad_ = d_.LessOrEqual(ab_, (int?)4);
		var af_ = d_.And(o_, ad_);

		return af_;
	}

    [CqlDeclaration("Stratification 1")]
    public bool? Stratification_1() => __Stratification_1.Value;

    private bool? Stratification_2_Value()
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
		var o_ = d_.Interval((int?)5, (int?)11, true, true);
		var q_ = d_.ElementInInterval<int?>(m_, o_, null);

		return q_;
	}

    [CqlDeclaration("Stratification 2")]
    public bool? Stratification_2() => __Stratification_2.Value;

    private bool? Stratification_3_Value()
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
		var o_ = d_.Interval((int?)12, (int?)20, true, false);
		var q_ = d_.ElementInInterval<int?>(m_, o_, null);

		return q_;
	}

    [CqlDeclaration("Stratification 3")]
    public bool? Stratification_3() => __Stratification_3.Value;

    private bool? Numerator_Value()
	{
		var a_ = this.Fluoride_Varnish_Application_for_Children();
		var b_ = context.DataRetriever;
		var c_ = b_.RetrieveByValueSet<Procedure>(a_, null);
		bool? d_(Procedure FluorideApplication)
		{
			var i_ = this.Measurement_Period();
			var j_ = FluorideApplication.Performed;
			var k_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Normalize_Interval(j_);
			var l_ = context.Operators;
			var m_ = l_.IntervalIncludesInterval<CqlDateTime>(i_, k_, null);
			var n_ = FluorideApplication.StatusElement;
			var o_ = new CallStackEntry("ToString", null, null);
			var p_ = context.Deeper(o_);
			var q_ = p_.Operators;
			var r_ = q_.TypeConverter;
			var s_ = r_.Convert<string>(n_);
			var u_ = l_.Equal(s_, "completed");
			var w_ = l_.And(m_, u_);

			return w_;
		};
		var e_ = context.Operators;
		var f_ = e_.WhereOrNull<Procedure>(c_, d_);
		var h_ = e_.ExistsInList<Procedure>(f_);

		return h_;
	}

    [CqlDeclaration("Numerator")]
    public bool? Numerator() => __Numerator.Value;

}