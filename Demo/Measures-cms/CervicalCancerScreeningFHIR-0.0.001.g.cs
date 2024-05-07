using System;
using Tuples;
using System.Linq;
using System.Collections.Generic;
using Hl7.Cql.Runtime;
using Hl7.Cql.Primitives;
using Hl7.Cql.Abstractions;
using Hl7.Cql.ValueSets;
using Hl7.Cql.Iso8601;
using System.Reflection;
using Hl7.Fhir.Model;
using Range = Hl7.Fhir.Model.Range;
using Task = Hl7.Fhir.Model.Task;
[System.CodeDom.Compiler.GeneratedCode(".NET Code Generation", "2.0.0.0")]
[CqlLibrary("CervicalCancerScreeningFHIR", "0.0.001")]
public class CervicalCancerScreeningFHIR_0_0_001
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
    internal Lazy<CqlValueSet> __Preventive_Care_Services_Established_Office_Visit__18_and_Up;
    internal Lazy<CqlValueSet> __Preventive_Care_Services_Initial_Office_Visit__18_and_Up;
    internal Lazy<CqlValueSet> __Telephone_Visits;
    internal Lazy<CqlInterval<CqlDateTime>> __Measurement_Period;
    internal Lazy<Patient> __Patient;
    internal Lazy<IEnumerable<Encounter>> __Qualifying_Encounters;
    internal Lazy<bool?> __Initial_Population;
    internal Lazy<bool?> __Denominator;
    internal Lazy<IEnumerable<object>> __Absence_of_Cervix;
    internal Lazy<bool?> __Denominator_Exclusions;
    internal Lazy<IEnumerable<Observation>> __Cervical_Cytology_Within_3_Years;
    internal Lazy<IEnumerable<Observation>> __HPV_Test_Within_5_Years_for_Women_Age_30_and_Older;
    internal Lazy<bool?> __Numerator;
    internal Lazy<Tuple_HPcCiDPXQfZTXIORThMLfTQDR> __SDE_Ethnicity;
    internal Lazy<IEnumerable<Tuple_GPRWMPNAYaJRiGDFSTLJOPeIJ>> __SDE_Payer;
    internal Lazy<Tuple_HPcCiDPXQfZTXIORThMLfTQDR> __SDE_Race;
    internal Lazy<CqlCode> __SDE_Sex;

    #endregion
    public CervicalCancerScreeningFHIR_0_0_001(CqlContext context)
    {
        this.context = context ?? throw new ArgumentNullException("context");

        FHIRHelpers_4_3_000 = new FHIRHelpers_4_3_000(context);
        SupplementalDataElements_3_4_000 = new SupplementalDataElements_3_4_000(context);
        QICoreCommon_2_0_000 = new QICoreCommon_2_0_000(context);
        Hospice_6_9_000 = new Hospice_6_9_000(context);
        PalliativeCare_1_9_000 = new PalliativeCare_1_9_000(context);
        Status_1_6_000 = new Status_1_6_000(context);

        __Congenital_or_Acquired_Absence_of_Cervix = new Lazy<CqlValueSet>(this.Congenital_or_Acquired_Absence_of_Cervix_Value);
        __Home_Healthcare_Services = new Lazy<CqlValueSet>(this.Home_Healthcare_Services_Value);
        __HPV_Test = new Lazy<CqlValueSet>(this.HPV_Test_Value);
        __Hysterectomy_with_No_Residual_Cervix = new Lazy<CqlValueSet>(this.Hysterectomy_with_No_Residual_Cervix_Value);
        __Office_Visit = new Lazy<CqlValueSet>(this.Office_Visit_Value);
        __Online_Assessments = new Lazy<CqlValueSet>(this.Online_Assessments_Value);
        __Pap_Test = new Lazy<CqlValueSet>(this.Pap_Test_Value);
        __Preventive_Care_Services_Established_Office_Visit__18_and_Up = new Lazy<CqlValueSet>(this.Preventive_Care_Services_Established_Office_Visit__18_and_Up_Value);
        __Preventive_Care_Services_Initial_Office_Visit__18_and_Up = new Lazy<CqlValueSet>(this.Preventive_Care_Services_Initial_Office_Visit__18_and_Up_Value);
        __Telephone_Visits = new Lazy<CqlValueSet>(this.Telephone_Visits_Value);
        __Measurement_Period = new Lazy<CqlInterval<CqlDateTime>>(this.Measurement_Period_Value);
        __Patient = new Lazy<Patient>(this.Patient_Value);
        __Qualifying_Encounters = new Lazy<IEnumerable<Encounter>>(this.Qualifying_Encounters_Value);
        __Initial_Population = new Lazy<bool?>(this.Initial_Population_Value);
        __Denominator = new Lazy<bool?>(this.Denominator_Value);
        __Absence_of_Cervix = new Lazy<IEnumerable<object>>(this.Absence_of_Cervix_Value);
        __Denominator_Exclusions = new Lazy<bool?>(this.Denominator_Exclusions_Value);
        __Cervical_Cytology_Within_3_Years = new Lazy<IEnumerable<Observation>>(this.Cervical_Cytology_Within_3_Years_Value);
        __HPV_Test_Within_5_Years_for_Women_Age_30_and_Older = new Lazy<IEnumerable<Observation>>(this.HPV_Test_Within_5_Years_for_Women_Age_30_and_Older_Value);
        __Numerator = new Lazy<bool?>(this.Numerator_Value);
        __SDE_Ethnicity = new Lazy<Tuple_HPcCiDPXQfZTXIORThMLfTQDR>(this.SDE_Ethnicity_Value);
        __SDE_Payer = new Lazy<IEnumerable<Tuple_GPRWMPNAYaJRiGDFSTLJOPeIJ>>(this.SDE_Payer_Value);
        __SDE_Race = new Lazy<Tuple_HPcCiDPXQfZTXIORThMLfTQDR>(this.SDE_Race_Value);
        __SDE_Sex = new Lazy<CqlCode>(this.SDE_Sex_Value);
    }
    #region Dependencies

    public FHIRHelpers_4_3_000 FHIRHelpers_4_3_000 { get; }
    public SupplementalDataElements_3_4_000 SupplementalDataElements_3_4_000 { get; }
    public QICoreCommon_2_0_000 QICoreCommon_2_0_000 { get; }
    public Hospice_6_9_000 Hospice_6_9_000 { get; }
    public PalliativeCare_1_9_000 PalliativeCare_1_9_000 { get; }
    public Status_1_6_000 Status_1_6_000 { get; }

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

	private CqlValueSet Preventive_Care_Services_Established_Office_Visit__18_and_Up_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1025", null);

    [CqlDeclaration("Preventive Care Services Established Office Visit, 18 and Up")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1025")]
	public CqlValueSet Preventive_Care_Services_Established_Office_Visit__18_and_Up() => 
		__Preventive_Care_Services_Established_Office_Visit__18_and_Up.Value;

	private CqlValueSet Preventive_Care_Services_Initial_Office_Visit__18_and_Up_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1023", null);

    [CqlDeclaration("Preventive Care Services Initial Office Visit, 18 and Up")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1023")]
	public CqlValueSet Preventive_Care_Services_Initial_Office_Visit__18_and_Up() => 
		__Preventive_Care_Services_Initial_Office_Visit__18_and_Up.Value;

	private CqlValueSet Telephone_Visits_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1080", null);

    [CqlDeclaration("Telephone Visits")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1080")]
	public CqlValueSet Telephone_Visits() => 
		__Telephone_Visits.Value;

	private CqlInterval<CqlDateTime> Measurement_Period_Value()
	{
		var a_ = context.Operators.DateTime(2025, 1, 1, 0, 0, 0, 0, default);
		var b_ = context.Operators.DateTime(2026, 1, 1, 0, 0, 0, 0, default);
		var c_ = context.Operators.Interval(a_, b_, true, false);
		var d_ = context.ResolveParameter("CervicalCancerScreeningFHIR-0.0.001", "Measurement Period", c_);

		return (CqlInterval<CqlDateTime>)d_;
	}

    [CqlDeclaration("Measurement Period")]
	public CqlInterval<CqlDateTime> Measurement_Period() => 
		__Measurement_Period.Value;

	private Patient Patient_Value()
	{
		var a_ = context.Operators.RetrieveByValueSet<Patient>(null, null);
		var b_ = context.Operators.SingletonFrom<Patient>(a_);

		return b_;
	}

    [CqlDeclaration("Patient")]
	public Patient Patient() => 
		__Patient.Value;

	private IEnumerable<Encounter> Qualifying_Encounters_Value()
	{
		var a_ = this.Office_Visit();
		var b_ = context.Operators.RetrieveByValueSet<Encounter>(a_, null);
		var c_ = this.Preventive_Care_Services_Established_Office_Visit__18_and_Up();
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
		var r_ = Status_1_6_000.isEncounterPerformed(q_);
		bool? s_(Encounter ValidEncounters)
		{
			var u_ = this.Measurement_Period();
			var v_ = ValidEncounters?.Period;
			var w_ = FHIRHelpers_4_3_000.ToInterval(v_);
			var x_ = QICoreCommon_2_0_000.toInterval((w_ as object));
			var y_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(u_, x_, "day");

			return y_;
		};
		var t_ = context.Operators.Where<Encounter>(r_, s_);

		return t_;
	}

    [CqlDeclaration("Qualifying Encounters")]
	public IEnumerable<Encounter> Qualifying_Encounters() => 
		__Qualifying_Encounters.Value;

	private bool? Initial_Population_Value()
	{
		var a_ = this.Patient();
		var b_ = context.Operators.Convert<CqlDate>(a_?.BirthDateElement?.Value);
		var c_ = this.Measurement_Period();
		var d_ = context.Operators.End(c_);
		var e_ = context.Operators.DateFrom(d_);
		var f_ = context.Operators.CalculateAgeAt(b_, e_, "year");
		var g_ = context.Operators.Interval(24, 64, true, true);
		var h_ = context.Operators.In<int?>(f_, g_, null);
		var j_ = context.Operators.Convert<string>(a_?.GenderElement?.Value);
		var k_ = context.Operators.Equal(j_, "female");
		var l_ = context.Operators.And(h_, k_);
		var m_ = this.Qualifying_Encounters();
		var n_ = context.Operators.Exists<Encounter>(m_);
		var o_ = context.Operators.And(l_, n_);

		return o_;
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
		var c_ = Status_1_6_000.isProcedurePerformed(b_);
		bool? d_(Procedure NoCervixProcedure)
		{
			var k_ = NoCervixProcedure?.Performed;
			var l_ = FHIRHelpers_4_3_000.ToValue(k_);
			var m_ = QICoreCommon_2_0_000.toInterval(l_);
			var n_ = context.Operators.End(m_);
			var o_ = this.Measurement_Period();
			var p_ = context.Operators.End(o_);
			var q_ = context.Operators.SameOrBefore(n_, p_, null);

			return q_;
		};
		var e_ = context.Operators.Where<Procedure>(c_, d_);
		var f_ = this.Congenital_or_Acquired_Absence_of_Cervix();
		var g_ = context.Operators.RetrieveByValueSet<Condition>(f_, null);
		bool? h_(Condition NoCervixDiagnosis)
		{
			var r_ = QICoreCommon_2_0_000.prevalenceInterval(NoCervixDiagnosis);
			var s_ = context.Operators.Start(r_);
			var t_ = this.Measurement_Period();
			var u_ = context.Operators.End(t_);
			var v_ = context.Operators.SameOrBefore(s_, u_, null);

			return v_;
		};
		var i_ = context.Operators.Where<Condition>(g_, h_);
		var j_ = context.Operators.ListUnion<object>((e_ as IEnumerable<object>), (i_ as IEnumerable<object>));

		return j_;
	}

    [CqlDeclaration("Absence of Cervix")]
	public IEnumerable<object> Absence_of_Cervix() => 
		__Absence_of_Cervix.Value;

	private bool? Denominator_Exclusions_Value()
	{
		var a_ = Hospice_6_9_000.Has_Hospice_Services();
		var b_ = this.Absence_of_Cervix();
		var c_ = context.Operators.Exists<object>(b_);
		var d_ = context.Operators.Or(a_, c_);
		var e_ = PalliativeCare_1_9_000.Has_Palliative_Care_in_the_Measurement_Period();
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
		var c_ = Status_1_6_000.isLaboratoryTestPerformed(b_);
		bool? d_(Observation CervicalCytology)
		{
			object f_()
			{
				bool t_()
				{
					var w_ = CervicalCytology?.Effective;
					var x_ = FHIRHelpers_4_3_000.ToValue(w_);
					var y_ = x_ is CqlDateTime;

					return y_;
				};
				bool u_()
				{
					var z_ = CervicalCytology?.Effective;
					var aa_ = FHIRHelpers_4_3_000.ToValue(z_);
					var ab_ = aa_ is CqlInterval<CqlDateTime>;

					return ab_;
				};
				bool v_()
				{
					var ac_ = CervicalCytology?.Effective;
					var ad_ = FHIRHelpers_4_3_000.ToValue(ac_);
					var ae_ = ad_ is CqlDateTime;

					return ae_;
				};
				if (t_())
				{
					var af_ = CervicalCytology?.Effective;
					var ag_ = FHIRHelpers_4_3_000.ToValue(af_);

					return ((ag_ as CqlDateTime) as object);
				}
				else if (u_())
				{
					var ah_ = CervicalCytology?.Effective;
					var ai_ = FHIRHelpers_4_3_000.ToValue(ah_);

					return ((ai_ as CqlInterval<CqlDateTime>) as object);
				}
				else if (v_())
				{
					var aj_ = CervicalCytology?.Effective;
					var ak_ = FHIRHelpers_4_3_000.ToValue(aj_);

					return ((ak_ as CqlDateTime) as object);
				}
				else
				{
					return null;
				}
			};
			var g_ = QICoreCommon_2_0_000.latest(f_());
			var h_ = this.Measurement_Period();
			var i_ = context.Operators.Start(h_);
			var j_ = context.Operators.Quantity(2m, "years");
			var k_ = context.Operators.Subtract(i_, j_);
			var m_ = context.Operators.End(h_);
			var n_ = context.Operators.Interval(k_, m_, true, true);
			var o_ = context.Operators.In<CqlDateTime>(g_, n_, "day");
			var p_ = CervicalCytology?.Value;
			var q_ = FHIRHelpers_4_3_000.ToValue(p_);
			var r_ = context.Operators.Not((bool?)(q_ is null));
			var s_ = context.Operators.And(o_, r_);

			return s_;
		};
		var e_ = context.Operators.Where<Observation>(c_, d_);

		return e_;
	}

    [CqlDeclaration("Cervical Cytology Within 3 Years")]
	public IEnumerable<Observation> Cervical_Cytology_Within_3_Years() => 
		__Cervical_Cytology_Within_3_Years.Value;

	private IEnumerable<Observation> HPV_Test_Within_5_Years_for_Women_Age_30_and_Older_Value()
	{
		var a_ = this.HPV_Test();
		var b_ = context.Operators.RetrieveByValueSet<Observation>(a_, null);
		var c_ = Status_1_6_000.isLaboratoryTestPerformed(b_);
		bool? d_(Observation HPVTest)
		{
			var f_ = this.Patient();
			var g_ = f_?.BirthDateElement;
			var h_ = g_?.Value;
			var i_ = context.Operators.Convert<CqlDate>(h_);
			object j_()
			{
				bool ad_()
				{
					var ag_ = HPVTest?.Effective;
					var ah_ = FHIRHelpers_4_3_000.ToValue(ag_);
					var ai_ = ah_ is CqlDateTime;

					return ai_;
				};
				bool ae_()
				{
					var aj_ = HPVTest?.Effective;
					var ak_ = FHIRHelpers_4_3_000.ToValue(aj_);
					var al_ = ak_ is CqlInterval<CqlDateTime>;

					return al_;
				};
				bool af_()
				{
					var am_ = HPVTest?.Effective;
					var an_ = FHIRHelpers_4_3_000.ToValue(am_);
					var ao_ = an_ is CqlDateTime;

					return ao_;
				};
				if (ad_())
				{
					var ap_ = HPVTest?.Effective;
					var aq_ = FHIRHelpers_4_3_000.ToValue(ap_);

					return ((aq_ as CqlDateTime) as object);
				}
				else if (ae_())
				{
					var ar_ = HPVTest?.Effective;
					var as_ = FHIRHelpers_4_3_000.ToValue(ar_);

					return ((as_ as CqlInterval<CqlDateTime>) as object);
				}
				else if (af_())
				{
					var at_ = HPVTest?.Effective;
					var au_ = FHIRHelpers_4_3_000.ToValue(at_);

					return ((au_ as CqlDateTime) as object);
				}
				else
				{
					return null;
				}
			};
			var k_ = QICoreCommon_2_0_000.latest(j_());
			var l_ = context.Operators.DateFrom(k_);
			var m_ = context.Operators.CalculateAgeAt(i_, l_, "year");
			var n_ = context.Operators.GreaterOrEqual(m_, 30);
			object o_()
			{
				bool av_()
				{
					var ay_ = HPVTest?.Effective;
					var az_ = FHIRHelpers_4_3_000.ToValue(ay_);
					var ba_ = az_ is CqlDateTime;

					return ba_;
				};
				bool aw_()
				{
					var bb_ = HPVTest?.Effective;
					var bc_ = FHIRHelpers_4_3_000.ToValue(bb_);
					var bd_ = bc_ is CqlInterval<CqlDateTime>;

					return bd_;
				};
				bool ax_()
				{
					var be_ = HPVTest?.Effective;
					var bf_ = FHIRHelpers_4_3_000.ToValue(be_);
					var bg_ = bf_ is CqlDateTime;

					return bg_;
				};
				if (av_())
				{
					var bh_ = HPVTest?.Effective;
					var bi_ = FHIRHelpers_4_3_000.ToValue(bh_);

					return ((bi_ as CqlDateTime) as object);
				}
				else if (aw_())
				{
					var bj_ = HPVTest?.Effective;
					var bk_ = FHIRHelpers_4_3_000.ToValue(bj_);

					return ((bk_ as CqlInterval<CqlDateTime>) as object);
				}
				else if (ax_())
				{
					var bl_ = HPVTest?.Effective;
					var bm_ = FHIRHelpers_4_3_000.ToValue(bl_);

					return ((bm_ as CqlDateTime) as object);
				}
				else
				{
					return null;
				}
			};
			var p_ = QICoreCommon_2_0_000.latest(o_());
			var q_ = this.Measurement_Period();
			var r_ = context.Operators.Start(q_);
			var s_ = context.Operators.Quantity(4m, "years");
			var t_ = context.Operators.Subtract(r_, s_);
			var v_ = context.Operators.End(q_);
			var w_ = context.Operators.Interval(t_, v_, true, true);
			var x_ = context.Operators.In<CqlDateTime>(p_, w_, "day");
			var y_ = context.Operators.And(n_, x_);
			var z_ = HPVTest?.Value;
			var aa_ = FHIRHelpers_4_3_000.ToValue(z_);
			var ab_ = context.Operators.Not((bool?)(aa_ is null));
			var ac_ = context.Operators.And(y_, ab_);

			return ac_;
		};
		var e_ = context.Operators.Where<Observation>(c_, d_);

		return e_;
	}

    [CqlDeclaration("HPV Test Within 5 Years for Women Age 30 and Older")]
	public IEnumerable<Observation> HPV_Test_Within_5_Years_for_Women_Age_30_and_Older() => 
		__HPV_Test_Within_5_Years_for_Women_Age_30_and_Older.Value;

	private bool? Numerator_Value()
	{
		var a_ = this.Cervical_Cytology_Within_3_Years();
		var b_ = context.Operators.Exists<Observation>(a_);
		var c_ = this.HPV_Test_Within_5_Years_for_Women_Age_30_and_Older();
		var d_ = context.Operators.Exists<Observation>(c_);
		var e_ = context.Operators.Or(b_, d_);

		return e_;
	}

    [CqlDeclaration("Numerator")]
	public bool? Numerator() => 
		__Numerator.Value;

	private Tuple_HPcCiDPXQfZTXIORThMLfTQDR SDE_Ethnicity_Value()
	{
		var a_ = SupplementalDataElements_3_4_000.SDE_Ethnicity();

		return a_;
	}

    [CqlDeclaration("SDE Ethnicity")]
	public Tuple_HPcCiDPXQfZTXIORThMLfTQDR SDE_Ethnicity() => 
		__SDE_Ethnicity.Value;

	private IEnumerable<Tuple_GPRWMPNAYaJRiGDFSTLJOPeIJ> SDE_Payer_Value()
	{
		var a_ = SupplementalDataElements_3_4_000.SDE_Payer();

		return a_;
	}

    [CqlDeclaration("SDE Payer")]
	public IEnumerable<Tuple_GPRWMPNAYaJRiGDFSTLJOPeIJ> SDE_Payer() => 
		__SDE_Payer.Value;

	private Tuple_HPcCiDPXQfZTXIORThMLfTQDR SDE_Race_Value()
	{
		var a_ = SupplementalDataElements_3_4_000.SDE_Race();

		return a_;
	}

    [CqlDeclaration("SDE Race")]
	public Tuple_HPcCiDPXQfZTXIORThMLfTQDR SDE_Race() => 
		__SDE_Race.Value;

	private CqlCode SDE_Sex_Value()
	{
		var a_ = SupplementalDataElements_3_4_000.SDE_Sex();

		return a_;
	}

    [CqlDeclaration("SDE Sex")]
	public CqlCode SDE_Sex() => 
		__SDE_Sex.Value;

}
