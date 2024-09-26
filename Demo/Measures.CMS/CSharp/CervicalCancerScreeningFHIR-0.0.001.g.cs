using System;
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
[System.CodeDom.Compiler.GeneratedCode(".NET Code Generation", "2.0.4.0")]
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
    internal Lazy<(IEnumerable<CqlCode> codes, string display)?> __SDE_Ethnicity;
    internal Lazy<IEnumerable<(CqlConcept code, CqlInterval<CqlDateTime> period)?>> __SDE_Payer;
    internal Lazy<(IEnumerable<CqlCode> codes, string display)?> __SDE_Race;
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
        __SDE_Ethnicity = new Lazy<(IEnumerable<CqlCode> codes, string display)?>(this.SDE_Ethnicity_Value);
        __SDE_Payer = new Lazy<IEnumerable<(CqlConcept code, CqlInterval<CqlDateTime> period)?>>(this.SDE_Payer_Value);
        __SDE_Race = new Lazy<(IEnumerable<CqlCode> codes, string display)?>(this.SDE_Race_Value);
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
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.111.12.1016", default);

    [CqlDeclaration("Congenital or Acquired Absence of Cervix")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.111.12.1016")]
	public CqlValueSet Congenital_or_Acquired_Absence_of_Cervix() => 
		__Congenital_or_Acquired_Absence_of_Cervix.Value;

	private CqlValueSet Home_Healthcare_Services_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1016", default);

    [CqlDeclaration("Home Healthcare Services")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1016")]
	public CqlValueSet Home_Healthcare_Services() => 
		__Home_Healthcare_Services.Value;

	private CqlValueSet HPV_Test_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.110.12.1059", default);

    [CqlDeclaration("HPV Test")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.110.12.1059")]
	public CqlValueSet HPV_Test() => 
		__HPV_Test.Value;

	private CqlValueSet Hysterectomy_with_No_Residual_Cervix_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.198.12.1014", default);

    [CqlDeclaration("Hysterectomy with No Residual Cervix")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.198.12.1014")]
	public CqlValueSet Hysterectomy_with_No_Residual_Cervix() => 
		__Hysterectomy_with_No_Residual_Cervix.Value;

	private CqlValueSet Office_Visit_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1001", default);

    [CqlDeclaration("Office Visit")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1001")]
	public CqlValueSet Office_Visit() => 
		__Office_Visit.Value;

	private CqlValueSet Online_Assessments_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1089", default);

    [CqlDeclaration("Online Assessments")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1089")]
	public CqlValueSet Online_Assessments() => 
		__Online_Assessments.Value;

	private CqlValueSet Pap_Test_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.108.12.1017", default);

    [CqlDeclaration("Pap Test")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.108.12.1017")]
	public CqlValueSet Pap_Test() => 
		__Pap_Test.Value;

	private CqlValueSet Preventive_Care_Services_Established_Office_Visit__18_and_Up_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1025", default);

    [CqlDeclaration("Preventive Care Services Established Office Visit, 18 and Up")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1025")]
	public CqlValueSet Preventive_Care_Services_Established_Office_Visit__18_and_Up() => 
		__Preventive_Care_Services_Established_Office_Visit__18_and_Up.Value;

	private CqlValueSet Preventive_Care_Services_Initial_Office_Visit__18_and_Up_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1023", default);

    [CqlDeclaration("Preventive Care Services Initial Office Visit, 18 and Up")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1023")]
	public CqlValueSet Preventive_Care_Services_Initial_Office_Visit__18_and_Up() => 
		__Preventive_Care_Services_Initial_Office_Visit__18_and_Up.Value;

	private CqlValueSet Telephone_Visits_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1080", default);

    [CqlDeclaration("Telephone Visits")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1080")]
	public CqlValueSet Telephone_Visits() => 
		__Telephone_Visits.Value;

	private CqlInterval<CqlDateTime> Measurement_Period_Value()
	{
		CqlDateTime a_ = context.Operators.DateTime(2025, 1, 1, 0, 0, 0, 0, default);
		CqlDateTime b_ = context.Operators.DateTime(2026, 1, 1, 0, 0, 0, 0, default);
		CqlInterval<CqlDateTime> c_ = context.Operators.Interval(a_, b_, true, false);
		object d_ = context.ResolveParameter("CervicalCancerScreeningFHIR-0.0.001", "Measurement Period", c_);

		return (CqlInterval<CqlDateTime>)d_;
	}

    [CqlDeclaration("Measurement Period")]
	public CqlInterval<CqlDateTime> Measurement_Period() => 
		__Measurement_Period.Value;

	private Patient Patient_Value()
	{
		IEnumerable<Patient> a_ = context.Operators.RetrieveByValueSet<Patient>(default, default);
		Patient b_ = context.Operators.SingletonFrom<Patient>(a_);

		return b_;
	}

    [CqlDeclaration("Patient")]
	public Patient Patient() => 
		__Patient.Value;

	private IEnumerable<Encounter> Qualifying_Encounters_Value()
	{
		CqlValueSet a_ = this.Office_Visit();
		IEnumerable<Encounter> b_ = context.Operators.RetrieveByValueSet<Encounter>(a_, default);
		CqlValueSet c_ = this.Preventive_Care_Services_Established_Office_Visit__18_and_Up();
		IEnumerable<Encounter> d_ = context.Operators.RetrieveByValueSet<Encounter>(c_, default);
		IEnumerable<Encounter> e_ = context.Operators.Union<Encounter>(b_, d_);
		CqlValueSet f_ = this.Preventive_Care_Services_Initial_Office_Visit__18_and_Up();
		IEnumerable<Encounter> g_ = context.Operators.RetrieveByValueSet<Encounter>(f_, default);
		CqlValueSet h_ = this.Home_Healthcare_Services();
		IEnumerable<Encounter> i_ = context.Operators.RetrieveByValueSet<Encounter>(h_, default);
		IEnumerable<Encounter> j_ = context.Operators.Union<Encounter>(g_, i_);
		IEnumerable<Encounter> k_ = context.Operators.Union<Encounter>(e_, j_);
		CqlValueSet l_ = this.Telephone_Visits();
		IEnumerable<Encounter> m_ = context.Operators.RetrieveByValueSet<Encounter>(l_, default);
		CqlValueSet n_ = this.Online_Assessments();
		IEnumerable<Encounter> o_ = context.Operators.RetrieveByValueSet<Encounter>(n_, default);
		IEnumerable<Encounter> p_ = context.Operators.Union<Encounter>(m_, o_);
		IEnumerable<Encounter> q_ = context.Operators.Union<Encounter>(k_, p_);
		IEnumerable<Encounter> r_ = Status_1_6_000.isEncounterPerformed(q_);
		bool? s_(Encounter ValidEncounters)
		{
			CqlInterval<CqlDateTime> u_ = this.Measurement_Period();
			Period v_ = ValidEncounters?.Period;
			CqlInterval<CqlDateTime> w_ = FHIRHelpers_4_3_000.ToInterval(v_);
			CqlInterval<CqlDateTime> x_ = QICoreCommon_2_0_000.toInterval(w_ as object);
			bool? y_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(u_, x_, "day");

			return y_;
		};
		IEnumerable<Encounter> t_ = context.Operators.Where<Encounter>(r_, s_);

		return t_;
	}

    [CqlDeclaration("Qualifying Encounters")]
	public IEnumerable<Encounter> Qualifying_Encounters() => 
		__Qualifying_Encounters.Value;

	private bool? Initial_Population_Value()
	{
		Patient a_ = this.Patient();
		Date b_ = a_?.BirthDateElement;
		string c_ = b_?.Value;
		CqlDate d_ = context.Operators.ConvertStringToDate(c_);
		CqlInterval<CqlDateTime> e_ = this.Measurement_Period();
		CqlDateTime f_ = context.Operators.End(e_);
		CqlDate g_ = context.Operators.DateFrom(f_);
		int? h_ = context.Operators.CalculateAgeAt(d_, g_, "year");
		CqlInterval<int?> i_ = context.Operators.Interval(24, 64, true, true);
		bool? j_ = context.Operators.In<int?>(h_, i_, default);
		Code<AdministrativeGender> l_ = a_?.GenderElement;
		AdministrativeGender? m_ = l_?.Value;
		string n_ = context.Operators.Convert<string>(m_);
		bool? o_ = context.Operators.Equal(n_, "female");
		bool? p_ = context.Operators.And(j_, o_);
		IEnumerable<Encounter> q_ = this.Qualifying_Encounters();
		bool? r_ = context.Operators.Exists<Encounter>(q_);
		bool? s_ = context.Operators.And(p_, r_);

		return s_;
	}

    [CqlDeclaration("Initial Population")]
	public bool? Initial_Population() => 
		__Initial_Population.Value;

	private bool? Denominator_Value()
	{
		bool? a_ = this.Initial_Population();

		return a_;
	}

    [CqlDeclaration("Denominator")]
	public bool? Denominator() => 
		__Denominator.Value;

	private IEnumerable<object> Absence_of_Cervix_Value()
	{
		CqlValueSet a_ = this.Hysterectomy_with_No_Residual_Cervix();
		IEnumerable<Procedure> b_ = context.Operators.RetrieveByValueSet<Procedure>(a_, default);
		IEnumerable<Procedure> c_ = Status_1_6_000.isProcedurePerformed(b_);
		bool? d_(Procedure NoCervixProcedure)
		{
			DataType k_ = NoCervixProcedure?.Performed;
			object l_ = FHIRHelpers_4_3_000.ToValue(k_);
			CqlInterval<CqlDateTime> m_ = QICoreCommon_2_0_000.toInterval(l_);
			CqlDateTime n_ = context.Operators.End(m_);
			CqlInterval<CqlDateTime> o_ = this.Measurement_Period();
			CqlDateTime p_ = context.Operators.End(o_);
			bool? q_ = context.Operators.SameOrBefore(n_, p_, default);

			return q_;
		};
		IEnumerable<Procedure> e_ = context.Operators.Where<Procedure>(c_, d_);
		CqlValueSet f_ = this.Congenital_or_Acquired_Absence_of_Cervix();
		IEnumerable<Condition> g_ = context.Operators.RetrieveByValueSet<Condition>(f_, default);
		bool? h_(Condition NoCervixDiagnosis)
		{
			CqlInterval<CqlDateTime> r_ = QICoreCommon_2_0_000.prevalenceInterval(NoCervixDiagnosis);
			CqlDateTime s_ = context.Operators.Start(r_);
			CqlInterval<CqlDateTime> t_ = this.Measurement_Period();
			CqlDateTime u_ = context.Operators.End(t_);
			bool? v_ = context.Operators.SameOrBefore(s_, u_, default);

			return v_;
		};
		IEnumerable<Condition> i_ = context.Operators.Where<Condition>(g_, h_);
		IEnumerable<object> j_ = context.Operators.Union<object>(e_ as IEnumerable<object>, i_ as IEnumerable<object>);

		return j_;
	}

    [CqlDeclaration("Absence of Cervix")]
	public IEnumerable<object> Absence_of_Cervix() => 
		__Absence_of_Cervix.Value;

	private bool? Denominator_Exclusions_Value()
	{
		bool? a_ = Hospice_6_9_000.Has_Hospice_Services();
		IEnumerable<object> b_ = this.Absence_of_Cervix();
		bool? c_ = context.Operators.Exists<object>(b_);
		bool? d_ = context.Operators.Or(a_, c_);
		bool? e_ = PalliativeCare_1_9_000.Has_Palliative_Care_in_the_Measurement_Period();
		bool? f_ = context.Operators.Or(d_, e_);

		return f_;
	}

    [CqlDeclaration("Denominator Exclusions")]
	public bool? Denominator_Exclusions() => 
		__Denominator_Exclusions.Value;

	private IEnumerable<Observation> Cervical_Cytology_Within_3_Years_Value()
	{
		CqlValueSet a_ = this.Pap_Test();
		IEnumerable<Observation> b_ = context.Operators.RetrieveByValueSet<Observation>(a_, default);
		IEnumerable<Observation> c_ = Status_1_6_000.isLaboratoryTestPerformed(b_);
		bool? d_(Observation CervicalCytology)
		{
			object f_()
			{
				bool t_()
				{
					DataType w_ = CervicalCytology?.Effective;
					object x_ = FHIRHelpers_4_3_000.ToValue(w_);
					bool y_ = x_ is CqlDateTime;

					return y_;
				};
				bool u_()
				{
					DataType z_ = CervicalCytology?.Effective;
					object aa_ = FHIRHelpers_4_3_000.ToValue(z_);
					bool ab_ = aa_ is CqlInterval<CqlDateTime>;

					return ab_;
				};
				bool v_()
				{
					DataType ac_ = CervicalCytology?.Effective;
					object ad_ = FHIRHelpers_4_3_000.ToValue(ac_);
					bool ae_ = ad_ is CqlDateTime;

					return ae_;
				};
				if (t_())
				{
					DataType af_ = CervicalCytology?.Effective;
					object ag_ = FHIRHelpers_4_3_000.ToValue(af_);
					CqlDateTime ah_ = ag_ switch { null => null , CqlDateTime a => a/* , CqlInterval<CqlDateTime> => ???, Timing => ??? */, _ => throw new System.Diagnostics.UnreachableException() };

					return ah_ as object;
				}
				else if (u_())
				{
					DataType ai_ = CervicalCytology?.Effective;
					object aj_ = FHIRHelpers_4_3_000.ToValue(ai_);
					CqlInterval<CqlDateTime> ak_ = aj_ switch { null => null , CqlInterval<CqlDateTime> b => b/* , CqlDateTime => ???, Timing => ???, CqlDateTime => ??? */, _ => throw new System.Diagnostics.UnreachableException() };

					return ak_ as object;
				}
				else if (v_())
				{
					DataType al_ = CervicalCytology?.Effective;
					object am_ = FHIRHelpers_4_3_000.ToValue(al_);
					CqlDateTime an_ = am_ switch { null => null , CqlDateTime c => c/* , CqlInterval<CqlDateTime> => ???, Timing => ??? */, _ => throw new System.Diagnostics.UnreachableException() };

					return an_ as object;
				}
				else
				{
					return null;
				}
			};
			CqlDateTime g_ = QICoreCommon_2_0_000.latest(f_());
			CqlInterval<CqlDateTime> h_ = this.Measurement_Period();
			CqlDateTime i_ = context.Operators.Start(h_);
			CqlQuantity j_ = context.Operators.Quantity(2m, "years");
			CqlDateTime k_ = context.Operators.Subtract(i_, j_);
			CqlDateTime m_ = context.Operators.End(h_);
			CqlInterval<CqlDateTime> n_ = context.Operators.Interval(k_, m_, true, true);
			bool? o_ = context.Operators.In<CqlDateTime>(g_, n_, "day");
			DataType p_ = CervicalCytology?.Value;
			object q_ = FHIRHelpers_4_3_000.ToValue(p_);
			bool? r_ = context.Operators.Not((bool?)(q_ is null));
			bool? s_ = context.Operators.And(o_, r_);

			return s_;
		};
		IEnumerable<Observation> e_ = context.Operators.Where<Observation>(c_, d_);

		return e_;
	}

    [CqlDeclaration("Cervical Cytology Within 3 Years")]
	public IEnumerable<Observation> Cervical_Cytology_Within_3_Years() => 
		__Cervical_Cytology_Within_3_Years.Value;

	private IEnumerable<Observation> HPV_Test_Within_5_Years_for_Women_Age_30_and_Older_Value()
	{
		CqlValueSet a_ = this.HPV_Test();
		IEnumerable<Observation> b_ = context.Operators.RetrieveByValueSet<Observation>(a_, default);
		IEnumerable<Observation> c_ = Status_1_6_000.isLaboratoryTestPerformed(b_);
		bool? d_(Observation HPVTest)
		{
			Patient f_ = this.Patient();
			Date g_ = f_?.BirthDateElement;
			string h_ = g_?.Value;
			CqlDate i_ = context.Operators.ConvertStringToDate(h_);
			object j_()
			{
				bool ad_()
				{
					DataType ag_ = HPVTest?.Effective;
					object ah_ = FHIRHelpers_4_3_000.ToValue(ag_);
					bool ai_ = ah_ is CqlDateTime;

					return ai_;
				};
				bool ae_()
				{
					DataType aj_ = HPVTest?.Effective;
					object ak_ = FHIRHelpers_4_3_000.ToValue(aj_);
					bool al_ = ak_ is CqlInterval<CqlDateTime>;

					return al_;
				};
				bool af_()
				{
					DataType am_ = HPVTest?.Effective;
					object an_ = FHIRHelpers_4_3_000.ToValue(am_);
					bool ao_ = an_ is CqlDateTime;

					return ao_;
				};
				if (ad_())
				{
					DataType ap_ = HPVTest?.Effective;
					object aq_ = FHIRHelpers_4_3_000.ToValue(ap_);
					CqlDateTime ar_ = aq_ switch { null => null , CqlDateTime a => a/* , CqlInterval<CqlDateTime> => ???, Timing => ??? */, _ => throw new System.Diagnostics.UnreachableException() };

					return ar_ as object;
				}
				else if (ae_())
				{
					DataType as_ = HPVTest?.Effective;
					object at_ = FHIRHelpers_4_3_000.ToValue(as_);
					CqlInterval<CqlDateTime> au_ = at_ switch { null => null , CqlInterval<CqlDateTime> b => b/* , CqlDateTime => ???, Timing => ???, CqlDateTime => ??? */, _ => throw new System.Diagnostics.UnreachableException() };

					return au_ as object;
				}
				else if (af_())
				{
					DataType av_ = HPVTest?.Effective;
					object aw_ = FHIRHelpers_4_3_000.ToValue(av_);
					CqlDateTime ax_ = aw_ switch { null => null , CqlDateTime c => c/* , CqlInterval<CqlDateTime> => ???, Timing => ??? */, _ => throw new System.Diagnostics.UnreachableException() };

					return ax_ as object;
				}
				else
				{
					return null;
				}
			};
			CqlDateTime k_ = QICoreCommon_2_0_000.latest(j_());
			CqlDate l_ = context.Operators.DateFrom(k_);
			int? m_ = context.Operators.CalculateAgeAt(i_, l_, "year");
			bool? n_ = context.Operators.GreaterOrEqual(m_, 30);
			object o_()
			{
				bool ay_()
				{
					DataType bb_ = HPVTest?.Effective;
					object bc_ = FHIRHelpers_4_3_000.ToValue(bb_);
					bool bd_ = bc_ is CqlDateTime;

					return bd_;
				};
				bool az_()
				{
					DataType be_ = HPVTest?.Effective;
					object bf_ = FHIRHelpers_4_3_000.ToValue(be_);
					bool bg_ = bf_ is CqlInterval<CqlDateTime>;

					return bg_;
				};
				bool ba_()
				{
					DataType bh_ = HPVTest?.Effective;
					object bi_ = FHIRHelpers_4_3_000.ToValue(bh_);
					bool bj_ = bi_ is CqlDateTime;

					return bj_;
				};
				if (ay_())
				{
					DataType bk_ = HPVTest?.Effective;
					object bl_ = FHIRHelpers_4_3_000.ToValue(bk_);
					CqlDateTime bm_ = bl_ switch { null => null , CqlDateTime d => d/* , CqlInterval<CqlDateTime> => ???, Timing => ??? */, _ => throw new System.Diagnostics.UnreachableException() };

					return bm_ as object;
				}
				else if (az_())
				{
					DataType bn_ = HPVTest?.Effective;
					object bo_ = FHIRHelpers_4_3_000.ToValue(bn_);
					CqlInterval<CqlDateTime> bp_ = bo_ switch { null => null , CqlInterval<CqlDateTime> e => e/* , CqlDateTime => ???, Timing => ???, CqlDateTime => ??? */, _ => throw new System.Diagnostics.UnreachableException() };

					return bp_ as object;
				}
				else if (ba_())
				{
					DataType bq_ = HPVTest?.Effective;
					object br_ = FHIRHelpers_4_3_000.ToValue(bq_);
					CqlDateTime bs_ = br_ switch { null => null , CqlDateTime f => f/* , CqlInterval<CqlDateTime> => ???, Timing => ??? */, _ => throw new System.Diagnostics.UnreachableException() };

					return bs_ as object;
				}
				else
				{
					return null;
				}
			};
			CqlDateTime p_ = QICoreCommon_2_0_000.latest(o_());
			CqlInterval<CqlDateTime> q_ = this.Measurement_Period();
			CqlDateTime r_ = context.Operators.Start(q_);
			CqlQuantity s_ = context.Operators.Quantity(4m, "years");
			CqlDateTime t_ = context.Operators.Subtract(r_, s_);
			CqlDateTime v_ = context.Operators.End(q_);
			CqlInterval<CqlDateTime> w_ = context.Operators.Interval(t_, v_, true, true);
			bool? x_ = context.Operators.In<CqlDateTime>(p_, w_, "day");
			bool? y_ = context.Operators.And(n_, x_);
			DataType z_ = HPVTest?.Value;
			object aa_ = FHIRHelpers_4_3_000.ToValue(z_);
			bool? ab_ = context.Operators.Not((bool?)(aa_ is null));
			bool? ac_ = context.Operators.And(y_, ab_);

			return ac_;
		};
		IEnumerable<Observation> e_ = context.Operators.Where<Observation>(c_, d_);

		return e_;
	}

    [CqlDeclaration("HPV Test Within 5 Years for Women Age 30 and Older")]
	public IEnumerable<Observation> HPV_Test_Within_5_Years_for_Women_Age_30_and_Older() => 
		__HPV_Test_Within_5_Years_for_Women_Age_30_and_Older.Value;

	private bool? Numerator_Value()
	{
		IEnumerable<Observation> a_ = this.Cervical_Cytology_Within_3_Years();
		bool? b_ = context.Operators.Exists<Observation>(a_);
		IEnumerable<Observation> c_ = this.HPV_Test_Within_5_Years_for_Women_Age_30_and_Older();
		bool? d_ = context.Operators.Exists<Observation>(c_);
		bool? e_ = context.Operators.Or(b_, d_);

		return e_;
	}

    [CqlDeclaration("Numerator")]
	public bool? Numerator() => 
		__Numerator.Value;

	private (IEnumerable<CqlCode> codes, string display)? SDE_Ethnicity_Value()
	{
		(IEnumerable<CqlCode> codes, string display)? a_ = SupplementalDataElements_3_4_000.SDE_Ethnicity();

		return a_;
	}

    [CqlDeclaration("SDE Ethnicity")]
	public (IEnumerable<CqlCode> codes, string display)? SDE_Ethnicity() => 
		__SDE_Ethnicity.Value;

	private IEnumerable<(CqlConcept code, CqlInterval<CqlDateTime> period)?> SDE_Payer_Value()
	{
		IEnumerable<(CqlConcept code, CqlInterval<CqlDateTime> period)?> a_ = SupplementalDataElements_3_4_000.SDE_Payer();

		return a_;
	}

    [CqlDeclaration("SDE Payer")]
	public IEnumerable<(CqlConcept code, CqlInterval<CqlDateTime> period)?> SDE_Payer() => 
		__SDE_Payer.Value;

	private (IEnumerable<CqlCode> codes, string display)? SDE_Race_Value()
	{
		(IEnumerable<CqlCode> codes, string display)? a_ = SupplementalDataElements_3_4_000.SDE_Race();

		return a_;
	}

    [CqlDeclaration("SDE Race")]
	public (IEnumerable<CqlCode> codes, string display)? SDE_Race() => 
		__SDE_Race.Value;

	private CqlCode SDE_Sex_Value()
	{
		CqlCode a_ = SupplementalDataElements_3_4_000.SDE_Sex();

		return a_;
	}

    [CqlDeclaration("SDE Sex")]
	public CqlCode SDE_Sex() => 
		__SDE_Sex.Value;

}
