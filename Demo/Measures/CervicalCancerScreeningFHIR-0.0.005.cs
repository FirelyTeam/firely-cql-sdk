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
        var a_ = context?.DataRetriever.RetrieveByValueSet<Patient>(null, 
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
        var b_ = typeof(Encounter).GetProperty("Type");
        var c_ = context?.DataRetriever.RetrieveByValueSet<Encounter>(a_, 
			b_);
        var d_ = this.Preventive_Care_Services___Established_Office_Visit__18_and_Up();
        var f_ = context?.DataRetriever.RetrieveByValueSet<Encounter>(d_, 
			b_);
        var g_ = context?.Operators.ListUnion<Encounter>(c_, 
			f_);
        var h_ = this.Preventive_Care_Services_Initial_Office_Visit__18_and_Up();
        var j_ = context?.DataRetriever.RetrieveByValueSet<Encounter>(h_, 
			b_);
        var k_ = this.Home_Healthcare_Services();
        var m_ = context?.DataRetriever.RetrieveByValueSet<Encounter>(k_, 
			b_);
        var n_ = context?.Operators.ListUnion<Encounter>(j_, 
			m_);
        var o_ = context?.Operators.ListUnion<Encounter>(g_, 
			n_);
        var p_ = this.Telephone_Visits();
        var r_ = context?.DataRetriever.RetrieveByValueSet<Encounter>(p_, 
			b_);
        var s_ = this.Online_Assessments();
        var u_ = context?.DataRetriever.RetrieveByValueSet<Encounter>(s_, 
			b_);
        var v_ = context?.Operators.ListUnion<Encounter>(r_, 
			u_);
        var w_ = context?.Operators.ListUnion<Encounter>(o_, 
			v_);
        Func<Encounter,bool?> af_ = (ValidEncounter) => 
        {
            var y_ = (ValidEncounter?.StatusElement as object);
            var x_ = ((context.Deeper(new CallStackEntry("ToString", 
		null, 
		null))?.Operators?.TypeConverter).Convert<string>(y_) as object);
            var z_ = ("finished" as object);
            var aa_ = context?.Operators.Equal(x_, 
				z_);
            var ab_ = this.Measurement_Period();
            var ac_ = ValidEncounter?.Period;
            var ad_ = FHIRHelpers_4_0_001.ToInterval(ac_);
            var ae_ = context?.Operators.IntervalIncludesInterval<CqlDateTime>(ab_, 
				ad_, 
				null);
            return context?.Operators.And(aa_, 
				ae_);
        };
        return context?.Operators.WhereOrNull<Encounter>(w_, 
			af_);
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
        var i_ = ((context.Deeper(new CallStackEntry("ToString", 
		null, 
		null))?.Operators?.TypeConverter).Convert<string>(j_) as object);
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
        var c_ = typeof(Procedure).GetProperty("Code");
        var d_ = context?.DataRetriever.RetrieveByValueSet<Procedure>(b_, 
			c_);
        Func<Procedure,bool?> o_ = (NoCervixProcedure) => 
        {
            var f_ = (NoCervixProcedure?.StatusElement as object);
            var e_ = ((context.Deeper(new CallStackEntry("ToString", 
		null, 
		null))?.Operators?.TypeConverter).Convert<string>(f_) as object);
            var g_ = ("completed" as object);
            var h_ = context?.Operators.Equal(e_, 
				g_);
            var i_ = (NoCervixProcedure?.Performed as object);
            var j_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Normalize_Interval(i_);
            var k_ = context?.Operators.End(j_);
            var l_ = this.Measurement_Period();
            var m_ = context?.Operators.End(l_);
            var n_ = context?.Operators.SameOrBefore(k_, 
				m_, 
				null);
            return context?.Operators.And(h_, 
				n_);
        };
        var a_ = (context?.Operators.WhereOrNull<Procedure>(d_, 
			o_) as IEnumerable<object>);
        var q_ = this.Congenital_or_Acquired_Absence_of_Cervix();
        var r_ = typeof(Condition).GetProperty("Code");
        var s_ = context?.DataRetriever.RetrieveByValueSet<Condition>(q_, 
			r_);
        Func<Condition,bool?> x_ = (NoCervixDiagnosis) => 
        {
            var t_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Prevalence_Period(NoCervixDiagnosis);
            var u_ = context?.Operators.Start(t_);
            var v_ = this.Measurement_Period();
            var w_ = context?.Operators.End(v_);
            return context?.Operators.SameOrBefore(u_, 
				w_, 
				null);
        };
        var p_ = (context?.Operators.WhereOrNull<Condition>(s_, 
			x_) as IEnumerable<object>);
        return context?.Operators.ListUnion<object>(a_, 
			p_);
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
        var b_ = typeof(Observation).GetProperty("Code");
        var c_ = context?.DataRetriever.RetrieveByValueSet<Observation>(a_, 
			b_);
        Func<Observation,bool?> ai_ = (CervicalCytology) => 
        {
            var d_ = (CervicalCytology?.StatusElement as object);
            var e_ = (context.Deeper(new CallStackEntry("ToString", 
		null, 
		null))?.Operators?.TypeConverter).Convert<string>(d_);
            var g_ = "final";
            var h_ = "amended";
            var i_ = "corrected";
            var f_ = (new string[]
			{
				g_,
				h_,
				i_,
			} as IEnumerable<string>);
            var j_ = context?.Operators.InList<string>(e_, 
				f_);
            var k_ = (CervicalCytology?.Category as IEnumerable<CodeableConcept>);
            Func<CodeableConcept,bool?> n_ = (CervicalCytologyCategory) => 
            {
                var l_ = this.laboratory();
                var m_ = (FHIRHelpers_4_0_001.ToConcept(CervicalCytologyCategory)?.codes as IEnumerable<CqlCode>);
                return context?.Operators.CodeInList(l_, 
					m_);
            };
            var o_ = context?.Operators.WhereOrNull<CodeableConcept>(k_, 
				n_);
            var p_ = context?.Operators.ExistsInList<CodeableConcept>(o_);
            var q_ = context?.Operators.And(j_, 
				p_);
            var r_ = (CervicalCytology?.Effective as object);
            var s_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Latest(r_);
            var t_ = this.Measurement_Period();
            var u_ = context?.Operators.End(t_);
            var v_ = context?.Operators.Quantity(3m, 
				"years");
            var w_ = context?.Operators.Subtract(u_, 
				v_);
            var z_ = context?.Operators.Interval(w_, 
				u_, 
				true, 
				true);
            var aa_ = context?.Operators.ElementInInterval<CqlDateTime>(s_, 
				z_, 
				null);
            bool? ab_ = ((bool?)(context?.Operators.End(t_) == null));
            var ad_ = context?.Operators.Not(ab_);
            var ae_ = context?.Operators.And(aa_, 
				ad_);
            var af_ = context?.Operators.And(q_, 
				ae_);
            bool? ag_ = ((bool?)((CervicalCytology?.Value as object) == null));
            var ah_ = context?.Operators.Not(ag_);
            return context?.Operators.And(af_, 
				ah_);
        };
        return context?.Operators.WhereOrNull<Observation>(c_, 
			ai_);
    }
    [CqlDeclaration("Cervical Cytology Within 3 Years")]
    public IEnumerable<Observation> Cervical_Cytology_Within_3_Years() => __Cervical_Cytology_Within_3_Years.Value;

    private IEnumerable<Observation> HPV_Test_Within_5_Years_for_Women_Age_30_and_Older_Value()
    {
        var a_ = this.HPV_Test();
        var b_ = typeof(Observation).GetProperty("Code");
        var c_ = context?.DataRetriever.RetrieveByValueSet<Observation>(a_, 
			b_);
        Func<Observation,bool?> as_ = (HPVTest) => 
        {
            var d_ = (HPVTest?.StatusElement as object);
            var e_ = (context.Deeper(new CallStackEntry("ToString", 
		null, 
		null))?.Operators?.TypeConverter).Convert<string>(d_);
            var g_ = "final";
            var h_ = "amended";
            var i_ = "corrected";
            var f_ = (new string[]
			{
				g_,
				h_,
				i_,
			} as IEnumerable<string>);
            var j_ = context?.Operators.InList<string>(e_, 
				f_);
            var k_ = (HPVTest?.Category as IEnumerable<CodeableConcept>);
            Func<CodeableConcept,bool?> n_ = (HPVTestCategory) => 
            {
                var l_ = this.laboratory();
                var m_ = (FHIRHelpers_4_0_001.ToConcept(HPVTestCategory)?.codes as IEnumerable<CqlCode>);
                return context?.Operators.CodeInList(l_, 
					m_);
            };
            var o_ = context?.Operators.WhereOrNull<CodeableConcept>(k_, 
				n_);
            var p_ = context?.Operators.ExistsInList<CodeableConcept>(o_);
            var q_ = context?.Operators.And(j_, 
				p_);
            var s_ = (this.Patient()?.BirthDateElement?.Value as object);
            var t_ = context?.Operators?.TypeConverter.Convert<CqlDate>(s_);
            var u_ = (HPVTest?.Effective as object);
            var v_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Normalize_Interval(u_);
            var w_ = context?.Operators.Start(v_);
            var x_ = context?.Operators.DateFrom(w_);
            var r_ = (context?.Operators.CalculateAgeAt(t_, 
				x_, 
				"year") as object);
            var y_ = (((int?)30) as object);
            var z_ = context?.Operators.GreaterOrEqual(r_, 
				y_);
            var aa_ = context?.Operators.And(q_, 
				z_);
            var ac_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Latest(u_);
            var ad_ = this.Measurement_Period();
            var ae_ = context?.Operators.End(ad_);
            var af_ = context?.Operators.Quantity(5m, 
				"years");
            var ag_ = context?.Operators.Subtract(ae_, 
				af_);
            var aj_ = context?.Operators.Interval(ag_, 
				ae_, 
				true, 
				true);
            var ak_ = context?.Operators.ElementInInterval<CqlDateTime>(ac_, 
				aj_, 
				null);
            bool? al_ = ((bool?)(context?.Operators.End(ad_) == null));
            var an_ = context?.Operators.Not(al_);
            var ao_ = context?.Operators.And(ak_, 
				an_);
            var ap_ = context?.Operators.And(aa_, 
				ao_);
            bool? aq_ = ((bool?)((HPVTest?.Value as object) == null));
            var ar_ = context?.Operators.Not(aq_);
            return context?.Operators.And(ap_, 
				ar_);
        };
        return context?.Operators.WhereOrNull<Observation>(c_, 
			as_);
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
        var b_ = (context.Deeper(new CallStackEntry("ToString", 
		null, 
		null))?.Operators?.TypeConverter).Convert<string>(a_);
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
        var b_ = typeof(Observation).GetProperty("Code");
        var c_ = context?.DataRetriever.RetrieveByValueSet<Observation>(a_, 
			b_);
        Func<Observation,bool?> x_ = (CervicalCytology) => 
        {
            var d_ = this.isComplete(CervicalCytology);
            var e_ = this.isLaboratoryTest(CervicalCytology);
            var f_ = context?.Operators.And(d_, 
				e_);
            var g_ = (CervicalCytology?.Effective as object);
            var h_ = this.latest(g_);
            var i_ = this.Measurement_Period();
            var j_ = context?.Operators.End(i_);
            var k_ = context?.Operators.Quantity(3m, 
				"years");
            var l_ = context?.Operators.Subtract(j_, 
				k_);
            var o_ = context?.Operators.Interval(l_, 
				j_, 
				true, 
				true);
            var p_ = context?.Operators.ElementInInterval<CqlDateTime>(h_, 
				o_, 
				null);
            bool? q_ = ((bool?)(context?.Operators.End(i_) == null));
            var s_ = context?.Operators.Not(q_);
            var t_ = context?.Operators.And(p_, 
				s_);
            var u_ = context?.Operators.And(f_, 
				t_);
            bool? v_ = ((bool?)((CervicalCytology?.Value as object) == null));
            var w_ = context?.Operators.Not(v_);
            return context?.Operators.And(u_, 
				w_);
        };
        return context?.Operators.WhereOrNull<Observation>(c_, 
			x_);
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
        var b_ = typeof(Observation).GetProperty("Code");
        var c_ = context?.DataRetriever.RetrieveByValueSet<Observation>(a_, 
			b_);
        Func<Observation,bool?> ah_ = (HPVTest) => 
        {
            var d_ = this.isComplete(HPVTest);
            var e_ = this.isLaboratoryTest(HPVTest);
            var f_ = context?.Operators.And(d_, 
				e_);
            var h_ = (this.Patient()?.BirthDateElement?.Value as object);
            var i_ = context?.Operators?.TypeConverter.Convert<CqlDate>(h_);
            var j_ = (HPVTest?.Effective as object);
            var k_ = this.toInterval(j_);
            var l_ = context?.Operators.Start(k_);
            var m_ = context?.Operators.DateFrom(l_);
            var g_ = (context?.Operators.CalculateAgeAt(i_, 
				m_, 
				"year") as object);
            var n_ = (((int?)30) as object);
            var o_ = context?.Operators.GreaterOrEqual(g_, 
				n_);
            var p_ = context?.Operators.And(f_, 
				o_);
            var r_ = this.latest(j_);
            var s_ = this.Measurement_Period();
            var t_ = context?.Operators.End(s_);
            var u_ = context?.Operators.Quantity(5m, 
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
            bool? af_ = ((bool?)((HPVTest?.Value as object) == null));
            var ag_ = context?.Operators.Not(af_);
            return context?.Operators.And(ae_, 
				ag_);
        };
        return context?.Operators.WhereOrNull<Observation>(c_, 
			ah_);
    }
    [CqlDeclaration("HPV Test Within 5 Years for Women Age 30 and Older (2)")]
    public IEnumerable<Observation> HPV_Test_Within_5_Years_for_Women_Age_30_and_Older__2_() => __HPV_Test_Within_5_Years_for_Women_Age_30_and_Older__2_.Value;

}