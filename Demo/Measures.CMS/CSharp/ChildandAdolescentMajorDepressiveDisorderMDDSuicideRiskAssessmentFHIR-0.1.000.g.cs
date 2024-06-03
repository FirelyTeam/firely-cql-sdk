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
[CqlLibrary("ChildandAdolescentMajorDepressiveDisorderMDDSuicideRiskAssessmentFHIR", "0.1.000")]
public class ChildandAdolescentMajorDepressiveDisorderMDDSuicideRiskAssessmentFHIR_0_1_000
{


    internal CqlContext context;

    #region Cached values

    internal Lazy<CqlValueSet> __Group_Psychotherapy;
    internal Lazy<CqlValueSet> __Major_Depressive_Disorder_Active;
    internal Lazy<CqlValueSet> __Office_Visit;
    internal Lazy<CqlValueSet> __Outpatient_Consultation;
    internal Lazy<CqlValueSet> __Psych_Visit_Diagnostic_Evaluation;
    internal Lazy<CqlValueSet> __Psych_Visit_for_Family_Psychotherapy;
    internal Lazy<CqlValueSet> __Psych_Visit_Psychotherapy;
    internal Lazy<CqlValueSet> __Psychoanalysis;
    internal Lazy<CqlValueSet> __Telehealth_Services;
    internal Lazy<CqlCode> __Birth_date;
    internal Lazy<CqlCode> __Suicide_risk_assessment__procedure_;
    internal Lazy<CqlCode> __AMB;
    internal Lazy<CqlCode[]> __LOINC;
    internal Lazy<CqlCode[]> __SNOMEDCT;
    internal Lazy<CqlCode[]> __ActCode;
    internal Lazy<CqlCode[]> __ICD10CM;
    internal Lazy<CqlInterval<CqlDateTime>> __Measurement_Period;
    internal Lazy<Patient> __Patient;
    internal Lazy<Tuple_HPcCiDPXQfZTXIORThMLfTQDR> __SDE_Ethnicity;
    internal Lazy<IEnumerable<Tuple_GPRWMPNAYaJRiGDFSTLJOPeIJ>> __SDE_Payer;
    internal Lazy<Tuple_HPcCiDPXQfZTXIORThMLfTQDR> __SDE_Race;
    internal Lazy<CqlCode> __SDE_Sex;
    internal Lazy<IEnumerable<Encounter>> __Major_Depressive_Disorder_Encounter;
    internal Lazy<IEnumerable<Encounter>> __Initial_Population;
    internal Lazy<IEnumerable<Encounter>> __Denominator;
    internal Lazy<IEnumerable<Encounter>> __Numerator;

    #endregion
    public ChildandAdolescentMajorDepressiveDisorderMDDSuicideRiskAssessmentFHIR_0_1_000(CqlContext context)
    {
        this.context = context ?? throw new ArgumentNullException("context");

        SupplementalDataElements_3_4_000 = new SupplementalDataElements_3_4_000(context);
        QICoreCommon_2_0_000 = new QICoreCommon_2_0_000(context);
        FHIRHelpers_4_3_000 = new FHIRHelpers_4_3_000(context);
        CQMCommon_2_0_000 = new CQMCommon_2_0_000(context);

        __Group_Psychotherapy = new Lazy<CqlValueSet>(this.Group_Psychotherapy_Value);
        __Major_Depressive_Disorder_Active = new Lazy<CqlValueSet>(this.Major_Depressive_Disorder_Active_Value);
        __Office_Visit = new Lazy<CqlValueSet>(this.Office_Visit_Value);
        __Outpatient_Consultation = new Lazy<CqlValueSet>(this.Outpatient_Consultation_Value);
        __Psych_Visit_Diagnostic_Evaluation = new Lazy<CqlValueSet>(this.Psych_Visit_Diagnostic_Evaluation_Value);
        __Psych_Visit_for_Family_Psychotherapy = new Lazy<CqlValueSet>(this.Psych_Visit_for_Family_Psychotherapy_Value);
        __Psych_Visit_Psychotherapy = new Lazy<CqlValueSet>(this.Psych_Visit_Psychotherapy_Value);
        __Psychoanalysis = new Lazy<CqlValueSet>(this.Psychoanalysis_Value);
        __Telehealth_Services = new Lazy<CqlValueSet>(this.Telehealth_Services_Value);
        __Birth_date = new Lazy<CqlCode>(this.Birth_date_Value);
        __Suicide_risk_assessment__procedure_ = new Lazy<CqlCode>(this.Suicide_risk_assessment__procedure__Value);
        __AMB = new Lazy<CqlCode>(this.AMB_Value);
        __LOINC = new Lazy<CqlCode[]>(this.LOINC_Value);
        __SNOMEDCT = new Lazy<CqlCode[]>(this.SNOMEDCT_Value);
        __ActCode = new Lazy<CqlCode[]>(this.ActCode_Value);
        __ICD10CM = new Lazy<CqlCode[]>(this.ICD10CM_Value);
        __Measurement_Period = new Lazy<CqlInterval<CqlDateTime>>(this.Measurement_Period_Value);
        __Patient = new Lazy<Patient>(this.Patient_Value);
        __SDE_Ethnicity = new Lazy<Tuple_HPcCiDPXQfZTXIORThMLfTQDR>(this.SDE_Ethnicity_Value);
        __SDE_Payer = new Lazy<IEnumerable<Tuple_GPRWMPNAYaJRiGDFSTLJOPeIJ>>(this.SDE_Payer_Value);
        __SDE_Race = new Lazy<Tuple_HPcCiDPXQfZTXIORThMLfTQDR>(this.SDE_Race_Value);
        __SDE_Sex = new Lazy<CqlCode>(this.SDE_Sex_Value);
        __Major_Depressive_Disorder_Encounter = new Lazy<IEnumerable<Encounter>>(this.Major_Depressive_Disorder_Encounter_Value);
        __Initial_Population = new Lazy<IEnumerable<Encounter>>(this.Initial_Population_Value);
        __Denominator = new Lazy<IEnumerable<Encounter>>(this.Denominator_Value);
        __Numerator = new Lazy<IEnumerable<Encounter>>(this.Numerator_Value);
    }
    #region Dependencies

    public SupplementalDataElements_3_4_000 SupplementalDataElements_3_4_000 { get; }
    public QICoreCommon_2_0_000 QICoreCommon_2_0_000 { get; }
    public FHIRHelpers_4_3_000 FHIRHelpers_4_3_000 { get; }
    public CQMCommon_2_0_000 CQMCommon_2_0_000 { get; }

    #endregion

    /// <seealso cref="Group_Psychotherapy"/>
	private CqlValueSet Group_Psychotherapy_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1187", null);

    /// <seealso cref="Group_Psychotherapy_Value"/>
    [CqlDeclaration("Group Psychotherapy")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1187")]
	public CqlValueSet Group_Psychotherapy() => 
		__Group_Psychotherapy.Value;

    /// <seealso cref="Major_Depressive_Disorder_Active"/>
	private CqlValueSet Major_Depressive_Disorder_Active_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1491", null);

    /// <seealso cref="Major_Depressive_Disorder_Active_Value"/>
    [CqlDeclaration("Major Depressive Disorder Active")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1491")]
	public CqlValueSet Major_Depressive_Disorder_Active() => 
		__Major_Depressive_Disorder_Active.Value;

    /// <seealso cref="Office_Visit"/>
	private CqlValueSet Office_Visit_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1001", null);

    /// <seealso cref="Office_Visit_Value"/>
    [CqlDeclaration("Office Visit")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1001")]
	public CqlValueSet Office_Visit() => 
		__Office_Visit.Value;

    /// <seealso cref="Outpatient_Consultation"/>
	private CqlValueSet Outpatient_Consultation_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1008", null);

    /// <seealso cref="Outpatient_Consultation_Value"/>
    [CqlDeclaration("Outpatient Consultation")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1008")]
	public CqlValueSet Outpatient_Consultation() => 
		__Outpatient_Consultation.Value;

    /// <seealso cref="Psych_Visit_Diagnostic_Evaluation"/>
	private CqlValueSet Psych_Visit_Diagnostic_Evaluation_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1492", null);

    /// <seealso cref="Psych_Visit_Diagnostic_Evaluation_Value"/>
    [CqlDeclaration("Psych Visit Diagnostic Evaluation")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1492")]
	public CqlValueSet Psych_Visit_Diagnostic_Evaluation() => 
		__Psych_Visit_Diagnostic_Evaluation.Value;

    /// <seealso cref="Psych_Visit_for_Family_Psychotherapy"/>
	private CqlValueSet Psych_Visit_for_Family_Psychotherapy_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1018", null);

    /// <seealso cref="Psych_Visit_for_Family_Psychotherapy_Value"/>
    [CqlDeclaration("Psych Visit for Family Psychotherapy")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1018")]
	public CqlValueSet Psych_Visit_for_Family_Psychotherapy() => 
		__Psych_Visit_for_Family_Psychotherapy.Value;

    /// <seealso cref="Psych_Visit_Psychotherapy"/>
	private CqlValueSet Psych_Visit_Psychotherapy_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1496", null);

    /// <seealso cref="Psych_Visit_Psychotherapy_Value"/>
    [CqlDeclaration("Psych Visit Psychotherapy")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1496")]
	public CqlValueSet Psych_Visit_Psychotherapy() => 
		__Psych_Visit_Psychotherapy.Value;

    /// <seealso cref="Psychoanalysis"/>
	private CqlValueSet Psychoanalysis_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1141", null);

    /// <seealso cref="Psychoanalysis_Value"/>
    [CqlDeclaration("Psychoanalysis")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1141")]
	public CqlValueSet Psychoanalysis() => 
		__Psychoanalysis.Value;

    /// <seealso cref="Telehealth_Services"/>
	private CqlValueSet Telehealth_Services_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1031", null);

    /// <seealso cref="Telehealth_Services_Value"/>
    [CqlDeclaration("Telehealth Services")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1031")]
	public CqlValueSet Telehealth_Services() => 
		__Telehealth_Services.Value;

    /// <seealso cref="Birth_date"/>
	private CqlCode Birth_date_Value() => 
		new CqlCode("21112-8", "http://loinc.org", null, null);

    /// <seealso cref="Birth_date_Value"/>
    [CqlDeclaration("Birth date")]
	public CqlCode Birth_date() => 
		__Birth_date.Value;

    /// <seealso cref="Suicide_risk_assessment__procedure_"/>
	private CqlCode Suicide_risk_assessment__procedure__Value() => 
		new CqlCode("225337009", "http://snomed.info/sct", null, null);

    /// <seealso cref="Suicide_risk_assessment__procedure__Value"/>
    [CqlDeclaration("Suicide risk assessment (procedure)")]
	public CqlCode Suicide_risk_assessment__procedure_() => 
		__Suicide_risk_assessment__procedure_.Value;

    /// <seealso cref="AMB"/>
	private CqlCode AMB_Value() => 
		new CqlCode("AMB", "http://terminology.hl7.org/CodeSystem/v3-ActCode", null, null);

    /// <seealso cref="AMB_Value"/>
    [CqlDeclaration("AMB")]
	public CqlCode AMB() => 
		__AMB.Value;

    /// <seealso cref="LOINC"/>
	private CqlCode[] LOINC_Value()
	{
		CqlCode[] a_ = new CqlCode[]
		{
			new CqlCode("21112-8", "http://loinc.org", null, null),
		};

		return a_;
	}

    /// <seealso cref="LOINC_Value"/>
    [CqlDeclaration("LOINC")]
	public CqlCode[] LOINC() => 
		__LOINC.Value;

    /// <seealso cref="SNOMEDCT"/>
	private CqlCode[] SNOMEDCT_Value()
	{
		CqlCode[] a_ = new CqlCode[]
		{
			new CqlCode("225337009", "http://snomed.info/sct", null, null),
		};

		return a_;
	}

    /// <seealso cref="SNOMEDCT_Value"/>
    [CqlDeclaration("SNOMEDCT")]
	public CqlCode[] SNOMEDCT() => 
		__SNOMEDCT.Value;

    /// <seealso cref="ActCode"/>
	private CqlCode[] ActCode_Value()
	{
		CqlCode[] a_ = new CqlCode[]
		{
			new CqlCode("AMB", "http://terminology.hl7.org/CodeSystem/v3-ActCode", null, null),
		};

		return a_;
	}

    /// <seealso cref="ActCode_Value"/>
    [CqlDeclaration("ActCode")]
	public CqlCode[] ActCode() => 
		__ActCode.Value;

    /// <seealso cref="ICD10CM"/>
	private CqlCode[] ICD10CM_Value()
	{
		CqlCode[] a_ = new CqlCode[0]
;

		return a_;
	}

    /// <seealso cref="ICD10CM_Value"/>
    [CqlDeclaration("ICD10CM")]
	public CqlCode[] ICD10CM() => 
		__ICD10CM.Value;

    /// <seealso cref="Measurement_Period"/>
	private CqlInterval<CqlDateTime> Measurement_Period_Value()
	{
		CqlDateTime a_ = context.Operators.DateTime(2025, 1, 1, 0, 0, 0, 0, default);
		CqlDateTime b_ = context.Operators.DateTime(2026, 1, 1, 0, 0, 0, 0, default);
		CqlInterval<CqlDateTime> c_ = context.Operators.Interval(a_, b_, true, false);
		object d_ = context.ResolveParameter("ChildandAdolescentMajorDepressiveDisorderMDDSuicideRiskAssessmentFHIR-0.1.000", "Measurement Period", c_);

		return (CqlInterval<CqlDateTime>)d_;
	}

    /// <seealso cref="Measurement_Period_Value"/>
    [CqlDeclaration("Measurement Period")]
	public CqlInterval<CqlDateTime> Measurement_Period() => 
		__Measurement_Period.Value;

    /// <seealso cref="Patient"/>
	private Patient Patient_Value()
	{
		IEnumerable<Patient> a_ = context.Operators.RetrieveByValueSet<Patient>(null, null);
		Patient b_ = context.Operators.SingletonFrom<Patient>(a_);

		return b_;
	}

    /// <seealso cref="Patient_Value"/>
    [CqlDeclaration("Patient")]
	public Patient Patient() => 
		__Patient.Value;

    /// <seealso cref="SDE_Ethnicity"/>
	private Tuple_HPcCiDPXQfZTXIORThMLfTQDR SDE_Ethnicity_Value()
	{
		Tuple_HPcCiDPXQfZTXIORThMLfTQDR a_ = SupplementalDataElements_3_4_000.SDE_Ethnicity();

		return a_;
	}

    /// <seealso cref="SDE_Ethnicity_Value"/>
    [CqlDeclaration("SDE Ethnicity")]
	public Tuple_HPcCiDPXQfZTXIORThMLfTQDR SDE_Ethnicity() => 
		__SDE_Ethnicity.Value;

    /// <seealso cref="SDE_Payer"/>
	private IEnumerable<Tuple_GPRWMPNAYaJRiGDFSTLJOPeIJ> SDE_Payer_Value()
	{
		IEnumerable<Tuple_GPRWMPNAYaJRiGDFSTLJOPeIJ> a_ = SupplementalDataElements_3_4_000.SDE_Payer();

		return a_;
	}

    /// <seealso cref="SDE_Payer_Value"/>
    [CqlDeclaration("SDE Payer")]
	public IEnumerable<Tuple_GPRWMPNAYaJRiGDFSTLJOPeIJ> SDE_Payer() => 
		__SDE_Payer.Value;

    /// <seealso cref="SDE_Race"/>
	private Tuple_HPcCiDPXQfZTXIORThMLfTQDR SDE_Race_Value()
	{
		Tuple_HPcCiDPXQfZTXIORThMLfTQDR a_ = SupplementalDataElements_3_4_000.SDE_Race();

		return a_;
	}

    /// <seealso cref="SDE_Race_Value"/>
    [CqlDeclaration("SDE Race")]
	public Tuple_HPcCiDPXQfZTXIORThMLfTQDR SDE_Race() => 
		__SDE_Race.Value;

    /// <seealso cref="SDE_Sex"/>
	private CqlCode SDE_Sex_Value()
	{
		CqlCode a_ = SupplementalDataElements_3_4_000.SDE_Sex();

		return a_;
	}

    /// <seealso cref="SDE_Sex_Value"/>
    [CqlDeclaration("SDE Sex")]
	public CqlCode SDE_Sex() => 
		__SDE_Sex.Value;

    /// <seealso cref="Major_Depressive_Disorder_Encounter"/>
	private IEnumerable<Encounter> Major_Depressive_Disorder_Encounter_Value()
	{
		CqlValueSet a_ = this.Office_Visit();
		IEnumerable<Encounter> b_ = context.Operators.RetrieveByValueSet<Encounter>(a_, null);
		CqlValueSet c_ = this.Outpatient_Consultation();
		IEnumerable<Encounter> d_ = context.Operators.RetrieveByValueSet<Encounter>(c_, null);
		IEnumerable<Encounter> e_ = context.Operators.Union<Encounter>(b_, d_);
		CqlValueSet f_ = this.Psych_Visit_Diagnostic_Evaluation();
		IEnumerable<Encounter> g_ = context.Operators.RetrieveByValueSet<Encounter>(f_, null);
		CqlValueSet h_ = this.Psych_Visit_for_Family_Psychotherapy();
		IEnumerable<Encounter> i_ = context.Operators.RetrieveByValueSet<Encounter>(h_, null);
		IEnumerable<Encounter> j_ = context.Operators.Union<Encounter>(g_, i_);
		IEnumerable<Encounter> k_ = context.Operators.Union<Encounter>(e_, j_);
		CqlValueSet l_ = this.Psych_Visit_Psychotherapy();
		IEnumerable<Encounter> m_ = context.Operators.RetrieveByValueSet<Encounter>(l_, null);
		CqlValueSet n_ = this.Psychoanalysis();
		IEnumerable<Encounter> o_ = context.Operators.RetrieveByValueSet<Encounter>(n_, null);
		IEnumerable<Encounter> p_ = context.Operators.Union<Encounter>(m_, o_);
		IEnumerable<Encounter> q_ = context.Operators.Union<Encounter>(k_, p_);
		CqlValueSet r_ = this.Group_Psychotherapy();
		IEnumerable<Encounter> s_ = context.Operators.RetrieveByValueSet<Encounter>(r_, null);
		CqlValueSet t_ = this.Telehealth_Services();
		IEnumerable<Encounter> u_ = context.Operators.RetrieveByValueSet<Encounter>(t_, null);
		IEnumerable<Encounter> v_ = context.Operators.Union<Encounter>(s_, u_);
		IEnumerable<Encounter> w_ = context.Operators.Union<Encounter>(q_, v_);
		bool? x_(Encounter ValidEncounter)
		{
			Code<Encounter.EncounterStatus> z_ = ValidEncounter?.StatusElement;
			Encounter.EncounterStatus? aa_ = z_?.Value;
			Code<Encounter.EncounterStatus> ab_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(aa_);
			bool? ac_ = context.Operators.Equal(ab_, "finished");
			List<CodeableConcept> ad_ = ValidEncounter?.ReasonCode;
			CqlConcept ae_(CodeableConcept @this)
			{
				CqlConcept at_ = FHIRHelpers_4_3_000.ToConcept(@this);

				return at_;
			};
			IEnumerable<CqlConcept> af_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)ad_, ae_);
			CqlValueSet ag_ = this.Major_Depressive_Disorder_Active();
			bool? ah_ = context.Operators.ConceptsInValueSet(af_, ag_);
			IEnumerable<Condition> ai_ = CQMCommon_2_0_000.EncounterDiagnosis(ValidEncounter);
			bool? aj_(Condition EncounterDiagnosis)
			{
				CodeableConcept au_ = EncounterDiagnosis?.Code;
				CqlConcept av_ = FHIRHelpers_4_3_000.ToConcept(au_);
				CqlValueSet aw_ = this.Major_Depressive_Disorder_Active();
				bool? ax_ = context.Operators.ConceptInValueSet(av_, aw_);

				return ax_;
			};
			IEnumerable<Condition> ak_ = context.Operators.Where<Condition>(ai_, aj_);
			bool? al_ = context.Operators.Exists<Condition>(ak_);
			bool? am_ = context.Operators.Or(ah_, al_);
			bool? an_ = context.Operators.And(ac_, am_);
			CqlInterval<CqlDateTime> ao_ = this.Measurement_Period();
			Period ap_ = ValidEncounter?.Period;
			CqlInterval<CqlDateTime> aq_ = FHIRHelpers_4_3_000.ToInterval(ap_);
			bool? ar_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(ao_, aq_, null);
			bool? as_ = context.Operators.And(an_, ar_);

			return as_;
		};
		IEnumerable<Encounter> y_ = context.Operators.Where<Encounter>(w_, x_);

		return y_;
	}

    /// <seealso cref="Major_Depressive_Disorder_Encounter_Value"/>
    [CqlDeclaration("Major Depressive Disorder Encounter")]
	public IEnumerable<Encounter> Major_Depressive_Disorder_Encounter() => 
		__Major_Depressive_Disorder_Encounter.Value;

    /// <seealso cref="Initial_Population"/>
	private IEnumerable<Encounter> Initial_Population_Value()
	{
		IEnumerable<Encounter> a_ = this.Major_Depressive_Disorder_Encounter();
		bool? b_(Encounter MDDEncounter)
		{
			Patient d_ = this.Patient();
			Date e_ = d_?.BirthDateElement;
			string f_ = e_?.Value;
			CqlDate g_ = context.Operators.Convert<CqlDate>(f_);
			CqlInterval<CqlDateTime> h_ = this.Measurement_Period();
			CqlDateTime i_ = context.Operators.Start(h_);
			CqlDate j_ = context.Operators.DateFrom(i_);
			int? k_ = context.Operators.CalculateAgeAt(g_, j_, "year");
			bool? l_ = context.Operators.GreaterOrEqual(k_, 6);
			Date n_ = d_?.BirthDateElement;
			string o_ = n_?.Value;
			CqlDate p_ = context.Operators.Convert<CqlDate>(o_);
			CqlDateTime r_ = context.Operators.Start(h_);
			CqlDate s_ = context.Operators.DateFrom(r_);
			int? t_ = context.Operators.CalculateAgeAt(p_, s_, "year");
			bool? u_ = context.Operators.LessOrEqual(t_, 16);
			bool? v_ = context.Operators.And(l_, u_);

			return v_;
		};
		IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);

		return c_;
	}

    /// <seealso cref="Initial_Population_Value"/>
    [CqlDeclaration("Initial Population")]
	public IEnumerable<Encounter> Initial_Population() => 
		__Initial_Population.Value;

    /// <seealso cref="Denominator"/>
	private IEnumerable<Encounter> Denominator_Value()
	{
		IEnumerable<Encounter> a_ = this.Initial_Population();

		return a_;
	}

    /// <seealso cref="Denominator_Value"/>
    [CqlDeclaration("Denominator")]
	public IEnumerable<Encounter> Denominator() => 
		__Denominator.Value;

    /// <seealso cref="Numerator"/>
	private IEnumerable<Encounter> Numerator_Value()
	{
		IEnumerable<Encounter> a_ = this.Major_Depressive_Disorder_Encounter();
		IEnumerable<Encounter> b_(Encounter MDDEncounter)
		{
			CqlCode d_ = this.Suicide_risk_assessment__procedure_();
			IEnumerable<CqlCode> e_ = context.Operators.ToList<CqlCode>(d_);
			IEnumerable<Procedure> f_ = context.Operators.RetrieveByCodes<Procedure>(e_, null);
			bool? g_(Procedure SuicideRiskAssessment)
			{
				Code<EventStatus> k_ = SuicideRiskAssessment?.StatusElement;
				EventStatus? l_ = k_?.Value;
				string m_ = context.Operators.Convert<string>(l_);
				bool? n_ = context.Operators.Equal(m_, "completed");
				Period o_ = MDDEncounter?.Period;
				CqlInterval<CqlDateTime> p_ = FHIRHelpers_4_3_000.ToInterval(o_);
				DataType q_ = SuicideRiskAssessment?.Performed;
				object r_ = FHIRHelpers_4_3_000.ToValue(q_);
				CqlInterval<CqlDateTime> s_ = QICoreCommon_2_0_000.ToInterval(r_);
				bool? t_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(p_, s_, null);
				bool? u_ = context.Operators.And(n_, t_);

				return u_;
			};
			IEnumerable<Procedure> h_ = context.Operators.Where<Procedure>(f_, g_);
			Encounter i_(Procedure SuicideRiskAssessment) => 
				MDDEncounter;
			IEnumerable<Encounter> j_ = context.Operators.Select<Procedure, Encounter>(h_, i_);

			return j_;
		};
		IEnumerable<Encounter> c_ = context.Operators.SelectMany<Encounter, Encounter>(a_, b_);

		return c_;
	}

    /// <seealso cref="Numerator_Value"/>
    [CqlDeclaration("Numerator")]
	public IEnumerable<Encounter> Numerator() => 
		__Numerator.Value;

}
