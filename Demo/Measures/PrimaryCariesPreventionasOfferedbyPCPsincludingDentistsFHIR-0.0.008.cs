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

    private CqlCode Birth_date_Value() =>
		new CqlCode("21112-8", "http://loinc.org", null, null);

    [CqlDeclaration("Birth date")]
    public CqlCode Birth_date() => __Birth_date.Value;

    private CqlCode[] LOINC_Value()
	{
		var a_ = new CqlCode("21112-8", "http://loinc.org", null, null);

		return new CqlCode[]
		{
			a_,
		};
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
		var k_ = this.Office_Visit();
		var l_ = context?.DataRetriever.RetrieveByValueSet<Encounter>(k_, null);
		var m_ = this.Preventive_Care___Established_Office_Visit__0_to_17();
		var n_ = context?.DataRetriever.RetrieveByValueSet<Encounter>(m_, null);
		var o_ = context?.Operators.ListUnion<Encounter>(l_, n_);
		var p_ = this.Preventive_Care__Initial_Office_Visit__0_to_17();
		var q_ = context?.DataRetriever.RetrieveByValueSet<Encounter>(p_, null);
		var r_ = this.Preventive_Care_Services___Established_Office_Visit__18_and_Up();
		var s_ = context?.DataRetriever.RetrieveByValueSet<Encounter>(r_, null);
		var t_ = context?.Operators.ListUnion<Encounter>(q_, s_);
		var u_ = context?.Operators.ListUnion<Encounter>(o_, t_);
		var v_ = this.Preventive_Care_Services_Initial_Office_Visit__18_and_Up();
		var w_ = context?.DataRetriever.RetrieveByValueSet<Encounter>(v_, null);
		var x_ = this.Clinical_Oral_Evaluation();
		var y_ = context?.DataRetriever.RetrieveByValueSet<Encounter>(x_, null);
		var z_ = context?.Operators.ListUnion<Encounter>(w_, y_);
		var aa_ = context?.Operators.ListUnion<Encounter>(u_, z_);
		var ab_ = this.Telephone_Visits();
		var ac_ = context?.DataRetriever.RetrieveByValueSet<Encounter>(ab_, null);
		var ad_ = this.Online_Assessments();
		var ae_ = context?.DataRetriever.RetrieveByValueSet<Encounter>(ad_, null);
		var af_ = context?.Operators.ListUnion<Encounter>(ac_, ae_);
		var ag_ = context?.Operators.ListUnion<Encounter>(aa_, af_);
		var ah_ = (Encounter ValidEncounter) =>
		{
			var a_ = this.Measurement_Period();
			var b_ = ValidEncounter?.Period;
			var c_ = (b_ as object);
			var d_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Normalize_Interval(c_);
			var e_ = context?.Operators.IntervalIncludesInterval<CqlDateTime>(a_, d_, null);
			var f_ = ValidEncounter?.StatusElement;
			var g_ = (f_ as object);
			var h_ = (context.Deeper(new CallStackEntry("ToString", null, null))?.Operators?.TypeConverter).Convert<string>(g_);
			var i_ = (h_ as object);
			var j_ = context?.Operators.Equal(i_, ("finished" as object));

			return context?.Operators.And(e_, j_);
		};

		return context?.Operators.WhereOrNull<Encounter>(ag_, ah_);
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
		var i_ = context?.Operators.CalculateAgeAt(e_, h_, "month");
		var j_ = i_;
		var k_ = (int?)6;
		var l_ = k_;
		var m_ = context?.Operators.GreaterOrEqual(j_, l_);
		var n_ = this.Patient();
		var o_ = n_?.BirthDateElement;
		var p_ = o_?.Value;
		var q_ = (p_ as object);
		var r_ = context?.Operators?.TypeConverter.Convert<CqlDate>(q_);
		var s_ = this.Measurement_Period();
		var t_ = context?.Operators.Start(s_);
		var u_ = context?.Operators.DateFrom(t_);
		var v_ = context?.Operators.CalculateAgeAt(r_, u_, "year");
		var w_ = v_;
		var x_ = (int?)20;
		var y_ = x_;
		var z_ = context?.Operators.Less(w_, y_);
		var aa_ = context?.Operators.And(m_, z_);
		var ab_ = this.Qualifying_Encounters();
		var ac_ = context?.Operators.ExistsInList<Encounter>(ab_);

		return context?.Operators.And(aa_, ac_);
	}

    [CqlDeclaration("Initial Population")]
    public bool? Initial_Population() => __Initial_Population.Value;

    private bool? Denominator_Value() =>
		this.Initial_Population();

    [CqlDeclaration("Denominator")]
    public bool? Denominator() => __Denominator.Value;

    private bool? Denominator_Exclusions_Value() =>
		HospiceFHIR4_2_3_000.Has_Hospice();

    [CqlDeclaration("Denominator Exclusions")]
    public bool? Denominator_Exclusions() => __Denominator_Exclusions.Value;

    private bool? Stratification_1_Value()
	{
		var a_ = this.Patient();
		var b_ = a_?.BirthDateElement;
		var c_ = b_?.Value;
		var d_ = (c_ as object);
		var e_ = context?.Operators?.TypeConverter.Convert<CqlDate>(d_);
		var f_ = this.Measurement_Period();
		var g_ = context?.Operators.Start(f_);
		var h_ = context?.Operators.DateFrom(g_);
		var i_ = context?.Operators.CalculateAgeAt(e_, h_, "month");
		var j_ = i_;
		var k_ = (int?)6;
		var l_ = k_;
		var m_ = context?.Operators.GreaterOrEqual(j_, l_);
		var n_ = this.Patient();
		var o_ = n_?.BirthDateElement;
		var p_ = o_?.Value;
		var q_ = (p_ as object);
		var r_ = context?.Operators?.TypeConverter.Convert<CqlDate>(q_);
		var s_ = this.Measurement_Period();
		var t_ = context?.Operators.Start(s_);
		var u_ = context?.Operators.DateFrom(t_);
		var v_ = context?.Operators.CalculateAgeAt(r_, u_, "year");
		var w_ = v_;
		var x_ = (int?)4;
		var y_ = x_;
		var z_ = context?.Operators.LessOrEqual(w_, y_);

		return context?.Operators.And(m_, z_);
	}

    [CqlDeclaration("Stratification 1")]
    public bool? Stratification_1() => __Stratification_1.Value;

    private bool? Stratification_2_Value()
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
		var j_ = context?.Operators.Interval((int?)5, (int?)11, true, true);

		return context?.Operators.ElementInInterval<int?>(i_, j_, null);
	}

    [CqlDeclaration("Stratification 2")]
    public bool? Stratification_2() => __Stratification_2.Value;

    private bool? Stratification_3_Value()
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
		var j_ = context?.Operators.Interval((int?)12, (int?)20, true, false);

		return context?.Operators.ElementInInterval<int?>(i_, j_, null);
	}

    [CqlDeclaration("Stratification 3")]
    public bool? Stratification_3() => __Stratification_3.Value;

    private bool? Numerator_Value()
	{
		var k_ = this.Fluoride_Varnish_Application_for_Children();
		var l_ = context?.DataRetriever.RetrieveByValueSet<Procedure>(k_, null);
		var m_ = (Procedure FluorideApplication) =>
		{
			var a_ = this.Measurement_Period();
			var b_ = FluorideApplication?.Performed;
			var c_ = (b_ as object);
			var d_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Normalize_Interval(c_);
			var e_ = context?.Operators.IntervalIncludesInterval<CqlDateTime>(a_, d_, null);
			var f_ = FluorideApplication?.StatusElement;
			var g_ = (f_ as object);
			var h_ = (context.Deeper(new CallStackEntry("ToString", null, null))?.Operators?.TypeConverter).Convert<string>(g_);
			var i_ = (h_ as object);
			var j_ = context?.Operators.Equal(i_, ("completed" as object));

			return context?.Operators.And(e_, j_);
		};
		var n_ = context?.Operators.WhereOrNull<Procedure>(l_, m_);

		return context?.Operators.ExistsInList<Procedure>(n_);
	}

    [CqlDeclaration("Numerator")]
    public bool? Numerator() => __Numerator.Value;

}