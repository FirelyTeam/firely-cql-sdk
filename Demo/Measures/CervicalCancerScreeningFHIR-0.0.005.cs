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

    private CqlValueSet Congenital_or_Acquired_Absence_of_Cervix_Value()
    {
        return new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.111.12.1016", 
			null);
    }

    [CqlDeclaration("Congenital or Acquired Absence of Cervix")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.111.12.1016")]
    public CqlValueSet Congenital_or_Acquired_Absence_of_Cervix() => __Congenital_or_Acquired_Absence_of_Cervix.Value;

    private CqlValueSet Home_Healthcare_Services_Value()
    {
        return new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1016", 
			null);
    }

    [CqlDeclaration("Home Healthcare Services")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1016")]
    public CqlValueSet Home_Healthcare_Services() => __Home_Healthcare_Services.Value;

    private CqlValueSet HPV_Test_Value()
    {
        return new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.110.12.1059", 
			null);
    }

    [CqlDeclaration("HPV Test")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.110.12.1059")]
    public CqlValueSet HPV_Test() => __HPV_Test.Value;

    private CqlValueSet Hysterectomy_with_No_Residual_Cervix_Value()
    {
        return new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.198.12.1014", 
			null);
    }

    [CqlDeclaration("Hysterectomy with No Residual Cervix")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.198.12.1014")]
    public CqlValueSet Hysterectomy_with_No_Residual_Cervix() => __Hysterectomy_with_No_Residual_Cervix.Value;

    private CqlValueSet Office_Visit_Value()
    {
        return new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1001", 
			null);
    }

    [CqlDeclaration("Office Visit")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1001")]
    public CqlValueSet Office_Visit() => __Office_Visit.Value;

    private CqlValueSet Online_Assessments_Value()
    {
        return new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1089", 
			null);
    }

    [CqlDeclaration("Online Assessments")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1089")]
    public CqlValueSet Online_Assessments() => __Online_Assessments.Value;

    private CqlValueSet Pap_Test_Value()
    {
        return new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.108.12.1017", 
			null);
    }

    [CqlDeclaration("Pap Test")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.108.12.1017")]
    public CqlValueSet Pap_Test() => __Pap_Test.Value;

    private CqlValueSet Preventive_Care_Services___Established_Office_Visit__18_and_Up_Value()
    {
        return new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1025", 
			null);
    }

    [CqlDeclaration("Preventive Care Services - Established Office Visit, 18 and Up")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1025")]
    public CqlValueSet Preventive_Care_Services___Established_Office_Visit__18_and_Up() => __Preventive_Care_Services___Established_Office_Visit__18_and_Up.Value;

    private CqlValueSet Preventive_Care_Services_Initial_Office_Visit__18_and_Up_Value()
    {
        return new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1023", 
			null);
    }

    [CqlDeclaration("Preventive Care Services-Initial Office Visit, 18 and Up")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1023")]
    public CqlValueSet Preventive_Care_Services_Initial_Office_Visit__18_and_Up() => __Preventive_Care_Services_Initial_Office_Visit__18_and_Up.Value;

    private CqlValueSet Telephone_Visits_Value()
    {
        return new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1080", 
			null);
    }

    [CqlDeclaration("Telephone Visits")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1080")]
    public CqlValueSet Telephone_Visits() => __Telephone_Visits.Value;

    private CqlCode laboratory_Value()
    {
        return new CqlCode("laboratory", 
			"http://terminology.hl7.org/CodeSystem/observation-category", 
			null, 
			null);
    }

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
        return ((CqlInterval<CqlDateTime>)context.ResolveParameter("CervicalCancerScreeningFHIR-0.0.005", 
			"Measurement Period", 
			(context?.Operators.Interval(context?.Operators.DateTime(((int?)2019), 
					((int?)1), 
					((int?)1), 
					((int?)0), 
					((int?)0), 
					((int?)0), 
					((int?)0), 
					context?.Operators.ConvertIntegerToDecimal(default)), 
				context?.Operators.DateTime(((int?)2020), 
					((int?)1), 
					((int?)1), 
					((int?)0), 
					((int?)0), 
					((int?)0), 
					((int?)0), 
					context?.Operators.ConvertIntegerToDecimal(default)), 
				true, 
				false) as object)));
    }

    [CqlDeclaration("Measurement Period")]
    public CqlInterval<CqlDateTime> Measurement_Period() => __Measurement_Period.Value;

    private Patient Patient_Value()
    {
        var a_ = context?.Operators.RetrieveByValueSet<Patient>(null, 
			null);
        return context?.Operators.SingleOrNull<Patient>(a_);
    }
    [CqlDeclaration("Patient")]
    public Patient Patient() => __Patient.Value;

    private IEnumerable<Coding> SDE_Ethnicity_Value()
    {
        return SupplementalDataElementsFHIR4_2_0_000.SDE_Ethnicity();
    }
    [CqlDeclaration("SDE Ethnicity")]
    public IEnumerable<Coding> SDE_Ethnicity() => __SDE_Ethnicity.Value;

    private IEnumerable<Tuples.Tuple_CFQHSgYJOXjAOCKdWLdZNNHDG> SDE_Payer_Value()
    {
        return SupplementalDataElementsFHIR4_2_0_000.SDE_Payer();
    }
    [CqlDeclaration("SDE Payer")]
    public IEnumerable<Tuples.Tuple_CFQHSgYJOXjAOCKdWLdZNNHDG> SDE_Payer() => __SDE_Payer.Value;

    private IEnumerable<Coding> SDE_Race_Value()
    {
        return SupplementalDataElementsFHIR4_2_0_000.SDE_Race();
    }
    [CqlDeclaration("SDE Race")]
    public IEnumerable<Coding> SDE_Race() => __SDE_Race.Value;

    private CqlCode SDE_Sex_Value()
    {
        return SupplementalDataElementsFHIR4_2_0_000.SDE_Sex();
    }
    [CqlDeclaration("SDE Sex")]
    public CqlCode SDE_Sex() => __SDE_Sex.Value;

    private IEnumerable<Encounter> Qualifying_Encounters_Value()
    {
        var a_ = this.Office_Visit();
        var b_ = context?.Operators.RetrieveByValueSet<Encounter>(a_, 
			typeof(Encounter).GetProperty("Type"));
        var c_ = this.Preventive_Care_Services___Established_Office_Visit__18_and_Up();
        var d_ = context?.Operators.RetrieveByValueSet<Encounter>(c_, 
			typeof(Encounter).GetProperty("Type"));
        var e_ = context?.Operators.ListUnion<Encounter>(b_, 
			d_);
        var f_ = this.Preventive_Care_Services_Initial_Office_Visit__18_and_Up();
        var g_ = context?.Operators.RetrieveByValueSet<Encounter>(f_, 
			typeof(Encounter).GetProperty("Type"));
        var h_ = this.Home_Healthcare_Services();
        var i_ = context?.Operators.RetrieveByValueSet<Encounter>(h_, 
			typeof(Encounter).GetProperty("Type"));
        var j_ = context?.Operators.ListUnion<Encounter>(g_, 
			i_);
        var k_ = context?.Operators.ListUnion<Encounter>(e_, 
			j_);
        var l_ = this.Telephone_Visits();
        var m_ = context?.Operators.RetrieveByValueSet<Encounter>(l_, 
			typeof(Encounter).GetProperty("Type"));
        var n_ = this.Online_Assessments();
        var o_ = context?.Operators.RetrieveByValueSet<Encounter>(n_, 
			typeof(Encounter).GetProperty("Type"));
        var p_ = context?.Operators.ListUnion<Encounter>(m_, 
			o_);
        var q_ = context?.Operators.ListUnion<Encounter>(k_, 
			p_);
        Func<Encounter,bool?> z_ = (ValidEncounter) => 
        {
            var s_ = (ValidEncounter?.StatusElement as object);
            var r_ = (context?.Operators.Convert<string>(s_) as object);
            var t_ = ("finished" as object);
            var u_ = context?.Operators.Equal(r_, 
				t_);
            var v_ = this.Measurement_Period();
            var w_ = ValidEncounter?.Period;
            var x_ = FHIRHelpers_4_0_001.ToInterval(w_);
            var y_ = context?.Operators.IntervalIncludesInterval<CqlDateTime>(v_, 
				x_, 
				null);
            return context?.Operators.And(u_, 
				y_);
        };
        return context?.Operators.WhereOrNull<Encounter>(q_, 
			z_);
    }
    [CqlDeclaration("Qualifying Encounters")]
    public IEnumerable<Encounter> Qualifying_Encounters() => __Qualifying_Encounters.Value;

    private bool? Initial_Population_Value()
    {
        var a_ = (this.Patient()?.BirthDateElement?.Value as object);
        var b_ = context?.Operators.Convert<CqlDate>(a_);
        var c_ = this.Measurement_Period();
        var d_ = context?.Operators.Start(c_);
        var e_ = context?.Operators.DateFrom(d_);
        var f_ = context?.Operators.CalculateAgeAt(b_, 
			e_, 
			"year");
        var g_ = context?.Operators.Interval(((int?)23), 
			((int?)64), 
			true, 
			false);
        var h_ = context?.Operators.ElementInInterval<int?>(f_, 
			g_, 
			null);
        var j_ = (this.Patient()?.GenderElement as object);
        var i_ = (context?.Operators.Convert<string>(j_) as object);
        var k_ = ("female" as object);
        var l_ = context?.Operators.Equal(i_, 
			k_);
        var m_ = context?.Operators.And(h_, 
			l_);
        var n_ = this.Qualifying_Encounters();
        var o_ = context?.Operators.ExistsInList<Encounter>(n_);
        return context?.Operators.And(m_, 
			o_);
    }
    [CqlDeclaration("Initial Population")]
    public bool? Initial_Population() => __Initial_Population.Value;

    private bool? Denominator_Value()
    {
        return this.Initial_Population();
    }
    [CqlDeclaration("Denominator")]
    public bool? Denominator() => __Denominator.Value;

    private IEnumerable<object> Absence_of_Cervix_Value()
    {
        var b_ = this.Hysterectomy_with_No_Residual_Cervix();
        var c_ = context?.Operators.RetrieveByValueSet<Procedure>(b_, 
			typeof(Procedure).GetProperty("Code"));
        Func<Procedure,bool?> n_ = (NoCervixProcedure) => 
        {
            var e_ = (NoCervixProcedure?.StatusElement as object);
            var d_ = (context?.Operators.Convert<string>(e_) as object);
            var f_ = ("completed" as object);
            var g_ = context?.Operators.Equal(d_, 
				f_);
            var h_ = (NoCervixProcedure?.Performed as object);
            var i_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Normalize_Interval(h_);
            var j_ = context?.Operators.End(i_);
            var k_ = this.Measurement_Period();
            var l_ = context?.Operators.End(k_);
            var m_ = context?.Operators.SameOrBefore(j_, 
				l_, 
				null);
            return context?.Operators.And(g_, 
				m_);
        };
        var a_ = (context?.Operators.WhereOrNull<Procedure>(c_, 
			n_) as IEnumerable<object>);
        var p_ = this.Congenital_or_Acquired_Absence_of_Cervix();
        var q_ = context?.Operators.RetrieveByValueSet<Condition>(p_, 
			typeof(Condition).GetProperty("Code"));
        Func<Condition,bool?> v_ = (NoCervixDiagnosis) => 
        {
            var r_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Prevalence_Period(NoCervixDiagnosis);
            var s_ = context?.Operators.Start(r_);
            var t_ = this.Measurement_Period();
            var u_ = context?.Operators.End(t_);
            return context?.Operators.SameOrBefore(s_, 
				u_, 
				null);
        };
        var o_ = (context?.Operators.WhereOrNull<Condition>(q_, 
			v_) as IEnumerable<object>);
        return context?.Operators.ListUnion<object>(a_, 
			o_);
    }
    [CqlDeclaration("Absence of Cervix")]
    public IEnumerable<object> Absence_of_Cervix() => __Absence_of_Cervix.Value;

    private bool? Denominator_Exclusions_Value()
    {
        var a_ = HospiceFHIR4_2_3_000.Has_Hospice();
        var b_ = this.Absence_of_Cervix();
        var c_ = context?.Operators.ExistsInList<object>(b_);
        var d_ = context?.Operators.Or(a_, 
			c_);
        var e_ = PalliativeCareFHIR_0_6_000.Palliative_Care_in_the_Measurement_Period();
        return context?.Operators.Or(d_, 
			e_);
    }
    [CqlDeclaration("Denominator Exclusions")]
    public bool? Denominator_Exclusions() => __Denominator_Exclusions.Value;

    private IEnumerable<Observation> Cervical_Cytology_Within_3_Years_Value()
    {
        var a_ = this.Pap_Test();
        var b_ = context?.Operators.RetrieveByValueSet<Observation>(a_, 
			typeof(Observation).GetProperty("Code"));
        Func<Observation,bool?> ah_ = (CervicalCytology) => 
        {
            var c_ = (CervicalCytology?.StatusElement as object);
            var d_ = context?.Operators.Convert<string>(c_);
            var f_ = "final";
            var g_ = "amended";
            var h_ = "corrected";
            var e_ = (new string[]
			{
				f_,
				g_,
				h_,
			} as IEnumerable<string>);
            var i_ = context?.Operators.InList<string>(d_, 
				e_);
            var j_ = (CervicalCytology?.Category as IEnumerable<CodeableConcept>);
            Func<CodeableConcept,bool?> m_ = (CervicalCytologyCategory) => 
            {
                var k_ = this.laboratory();
                var l_ = (FHIRHelpers_4_0_001.ToConcept(CervicalCytologyCategory)?.codes as IEnumerable<CqlCode>);
                return context?.Operators.CodeInList(k_, 
					l_);
            };
            var n_ = context?.Operators.WhereOrNull<CodeableConcept>(j_, 
				m_);
            var o_ = context?.Operators.ExistsInList<CodeableConcept>(n_);
            var p_ = context?.Operators.And(i_, 
				o_);
            var q_ = (CervicalCytology?.Effective as object);
            var r_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Latest(q_);
            var s_ = this.Measurement_Period();
            var t_ = context?.Operators.End(s_);
            var u_ = context?.Operators.Quantity(3m, 
				"years");
            var v_ = context?.Operators.Subtract(t_, 
				u_);
            var y_ = context?.Operators.Interval(v_, 
				t_, 
				true, 
				true);
            var z_ = context?.Operators.ElementInInterval<CqlDateTime>(r_, 
				y_, 
				null);
            bool? aa_ = ((bool?)(context?.Operators.End(s_) == null));
            var ac_ = context?.Operators.Not(aa_);
            var ad_ = context?.Operators.And(z_, 
				ac_);
            var ae_ = context?.Operators.And(p_, 
				ad_);
            bool? af_ = ((bool?)((CervicalCytology?.Value as object) == null));
            var ag_ = context?.Operators.Not(af_);
            return context?.Operators.And(ae_, 
				ag_);
        };
        return context?.Operators.WhereOrNull<Observation>(b_, 
			ah_);
    }
    [CqlDeclaration("Cervical Cytology Within 3 Years")]
    public IEnumerable<Observation> Cervical_Cytology_Within_3_Years() => __Cervical_Cytology_Within_3_Years.Value;

    private IEnumerable<Observation> HPV_Test_Within_5_Years_for_Women_Age_30_and_Older_Value()
    {
        var a_ = this.HPV_Test();
        var b_ = context?.Operators.RetrieveByValueSet<Observation>(a_, 
			typeof(Observation).GetProperty("Code"));
        Func<Observation,bool?> ar_ = (HPVTest) => 
        {
            var c_ = (HPVTest?.StatusElement as object);
            var d_ = context?.Operators.Convert<string>(c_);
            var f_ = "final";
            var g_ = "amended";
            var h_ = "corrected";
            var e_ = (new string[]
			{
				f_,
				g_,
				h_,
			} as IEnumerable<string>);
            var i_ = context?.Operators.InList<string>(d_, 
				e_);
            var j_ = (HPVTest?.Category as IEnumerable<CodeableConcept>);
            Func<CodeableConcept,bool?> m_ = (HPVTestCategory) => 
            {
                var k_ = this.laboratory();
                var l_ = (FHIRHelpers_4_0_001.ToConcept(HPVTestCategory)?.codes as IEnumerable<CqlCode>);
                return context?.Operators.CodeInList(k_, 
					l_);
            };
            var n_ = context?.Operators.WhereOrNull<CodeableConcept>(j_, 
				m_);
            var o_ = context?.Operators.ExistsInList<CodeableConcept>(n_);
            var p_ = context?.Operators.And(i_, 
				o_);
            var r_ = (this.Patient()?.BirthDateElement?.Value as object);
            var s_ = context?.Operators.Convert<CqlDate>(r_);
            var t_ = (HPVTest?.Effective as object);
            var u_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Normalize_Interval(t_);
            var v_ = context?.Operators.Start(u_);
            var w_ = context?.Operators.DateFrom(v_);
            var q_ = (context?.Operators.CalculateAgeAt(s_, 
				w_, 
				"year") as object);
            var x_ = (((int?)30) as object);
            var y_ = context?.Operators.GreaterOrEqual(q_, 
				x_);
            var z_ = context?.Operators.And(p_, 
				y_);
            var ab_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Latest(t_);
            var ac_ = this.Measurement_Period();
            var ad_ = context?.Operators.End(ac_);
            var ae_ = context?.Operators.Quantity(5m, 
				"years");
            var af_ = context?.Operators.Subtract(ad_, 
				ae_);
            var ai_ = context?.Operators.Interval(af_, 
				ad_, 
				true, 
				true);
            var aj_ = context?.Operators.ElementInInterval<CqlDateTime>(ab_, 
				ai_, 
				null);
            bool? ak_ = ((bool?)(context?.Operators.End(ac_) == null));
            var am_ = context?.Operators.Not(ak_);
            var an_ = context?.Operators.And(aj_, 
				am_);
            var ao_ = context?.Operators.And(z_, 
				an_);
            bool? ap_ = ((bool?)((HPVTest?.Value as object) == null));
            var aq_ = context?.Operators.Not(ap_);
            return context?.Operators.And(ao_, 
				aq_);
        };
        return context?.Operators.WhereOrNull<Observation>(b_, 
			ar_);
    }
    [CqlDeclaration("HPV Test Within 5 Years for Women Age 30 and Older")]
    public IEnumerable<Observation> HPV_Test_Within_5_Years_for_Women_Age_30_and_Older() => __HPV_Test_Within_5_Years_for_Women_Age_30_and_Older.Value;

    private bool? Numerator_Value()
    {
        var a_ = this.Cervical_Cytology_Within_3_Years();
        var b_ = context?.Operators.ExistsInList<Observation>(a_);
        var c_ = this.HPV_Test_Within_5_Years_for_Women_Age_30_and_Older();
        var d_ = context?.Operators.ExistsInList<Observation>(c_);
        return context?.Operators.Or(b_, 
			d_);
    }
    [CqlDeclaration("Numerator")]
    public bool? Numerator() => __Numerator.Value;

    [CqlDeclaration("isComplete")]
    public bool? isComplete(Observation observation)
    {
        var a_ = (observation?.StatusElement as object);
        var b_ = context?.Operators.Convert<string>(a_);
        var d_ = "final";
        var e_ = "amended";
        var f_ = "corrected";
        var c_ = (new string[]
		{
			d_,
			e_,
			f_,
		} as IEnumerable<string>);
        return context?.Operators.InList<string>(b_, 
			c_);
    }

    [CqlDeclaration("isLaboratoryTest")]
    public bool? isLaboratoryTest(Observation observation)
    {
        var a_ = (observation?.Category as IEnumerable<CodeableConcept>);
        Func<CodeableConcept,bool?> d_ = (category) => 
        {
            var b_ = this.laboratory();
            var c_ = (FHIRHelpers_4_0_001.ToConcept(category)?.codes as IEnumerable<CqlCode>);
            return context?.Operators.CodeInList(b_, 
				c_);
        };
        var e_ = context?.Operators.WhereOrNull<CodeableConcept>(a_, 
			d_);
        return context?.Operators.ExistsInList<CodeableConcept>(e_);
    }

    [CqlDeclaration("latest")]
    public CqlDateTime latest(object choice)
    {
        return MATGlobalCommonFunctionsFHIR4_6_1_000.Latest(choice);
    }

    private IEnumerable<Observation> Cervical_Cytology_Within_3_Years__2__Value()
    {
        var a_ = this.Pap_Test();
        var b_ = context?.Operators.RetrieveByValueSet<Observation>(a_, 
			typeof(Observation).GetProperty("Code"));
        Func<Observation,bool?> w_ = (CervicalCytology) => 
        {
            var c_ = this.isComplete(CervicalCytology);
            var d_ = this.isLaboratoryTest(CervicalCytology);
            var e_ = context?.Operators.And(c_, 
				d_);
            var f_ = (CervicalCytology?.Effective as object);
            var g_ = this.latest(f_);
            var h_ = this.Measurement_Period();
            var i_ = context?.Operators.End(h_);
            var j_ = context?.Operators.Quantity(3m, 
				"years");
            var k_ = context?.Operators.Subtract(i_, 
				j_);
            var n_ = context?.Operators.Interval(k_, 
				i_, 
				true, 
				true);
            var o_ = context?.Operators.ElementInInterval<CqlDateTime>(g_, 
				n_, 
				null);
            bool? p_ = ((bool?)(context?.Operators.End(h_) == null));
            var r_ = context?.Operators.Not(p_);
            var s_ = context?.Operators.And(o_, 
				r_);
            var t_ = context?.Operators.And(e_, 
				s_);
            bool? u_ = ((bool?)((CervicalCytology?.Value as object) == null));
            var v_ = context?.Operators.Not(u_);
            return context?.Operators.And(t_, 
				v_);
        };
        return context?.Operators.WhereOrNull<Observation>(b_, 
			w_);
    }
    [CqlDeclaration("Cervical Cytology Within 3 Years (2)")]
    public IEnumerable<Observation> Cervical_Cytology_Within_3_Years__2_() => __Cervical_Cytology_Within_3_Years__2_.Value;

    [CqlDeclaration("toInterval")]
    public CqlInterval<CqlDateTime> toInterval(object choice)
    {
        return MATGlobalCommonFunctionsFHIR4_6_1_000.Normalize_Interval(choice);
    }

    private IEnumerable<Observation> HPV_Test_Within_5_Years_for_Women_Age_30_and_Older__2__Value()
    {
        var a_ = this.HPV_Test();
        var b_ = context?.Operators.RetrieveByValueSet<Observation>(a_, 
			typeof(Observation).GetProperty("Code"));
        Func<Observation,bool?> ag_ = (HPVTest) => 
        {
            var c_ = this.isComplete(HPVTest);
            var d_ = this.isLaboratoryTest(HPVTest);
            var e_ = context?.Operators.And(c_, 
				d_);
            var g_ = (this.Patient()?.BirthDateElement?.Value as object);
            var h_ = context?.Operators.Convert<CqlDate>(g_);
            var i_ = (HPVTest?.Effective as object);
            var j_ = this.toInterval(i_);
            var k_ = context?.Operators.Start(j_);
            var l_ = context?.Operators.DateFrom(k_);
            var f_ = (context?.Operators.CalculateAgeAt(h_, 
				l_, 
				"year") as object);
            var m_ = (((int?)30) as object);
            var n_ = context?.Operators.GreaterOrEqual(f_, 
				m_);
            var o_ = context?.Operators.And(e_, 
				n_);
            var q_ = this.latest(i_);
            var r_ = this.Measurement_Period();
            var s_ = context?.Operators.End(r_);
            var t_ = context?.Operators.Quantity(5m, 
				"years");
            var u_ = context?.Operators.Subtract(s_, 
				t_);
            var x_ = context?.Operators.Interval(u_, 
				s_, 
				true, 
				true);
            var y_ = context?.Operators.ElementInInterval<CqlDateTime>(q_, 
				x_, 
				null);
            bool? z_ = ((bool?)(context?.Operators.End(r_) == null));
            var ab_ = context?.Operators.Not(z_);
            var ac_ = context?.Operators.And(y_, 
				ab_);
            var ad_ = context?.Operators.And(o_, 
				ac_);
            bool? ae_ = ((bool?)((HPVTest?.Value as object) == null));
            var af_ = context?.Operators.Not(ae_);
            return context?.Operators.And(ad_, 
				af_);
        };
        return context?.Operators.WhereOrNull<Observation>(b_, 
			ag_);
    }
    [CqlDeclaration("HPV Test Within 5 Years for Women Age 30 and Older (2)")]
    public IEnumerable<Observation> HPV_Test_Within_5_Years_for_Women_Age_30_and_Older__2_() => __HPV_Test_Within_5_Years_for_Women_Age_30_and_Older__2_.Value;

}