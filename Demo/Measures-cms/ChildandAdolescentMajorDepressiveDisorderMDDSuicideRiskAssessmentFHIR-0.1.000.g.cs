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

	private CqlValueSet Group_Psychotherapy_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1187", null);

    [CqlDeclaration("Group Psychotherapy")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1187")]
	public CqlValueSet Group_Psychotherapy() => 
		__Group_Psychotherapy.Value;

	private CqlValueSet Major_Depressive_Disorder_Active_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1491", null);

    [CqlDeclaration("Major Depressive Disorder Active")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1491")]
	public CqlValueSet Major_Depressive_Disorder_Active() => 
		__Major_Depressive_Disorder_Active.Value;

	private CqlValueSet Office_Visit_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1001", null);

    [CqlDeclaration("Office Visit")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1001")]
	public CqlValueSet Office_Visit() => 
		__Office_Visit.Value;

	private CqlValueSet Outpatient_Consultation_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1008", null);

    [CqlDeclaration("Outpatient Consultation")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1008")]
	public CqlValueSet Outpatient_Consultation() => 
		__Outpatient_Consultation.Value;

	private CqlValueSet Psych_Visit_Diagnostic_Evaluation_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1492", null);

    [CqlDeclaration("Psych Visit Diagnostic Evaluation")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1492")]
	public CqlValueSet Psych_Visit_Diagnostic_Evaluation() => 
		__Psych_Visit_Diagnostic_Evaluation.Value;

	private CqlValueSet Psych_Visit_for_Family_Psychotherapy_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1018", null);

    [CqlDeclaration("Psych Visit for Family Psychotherapy")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1018")]
	public CqlValueSet Psych_Visit_for_Family_Psychotherapy() => 
		__Psych_Visit_for_Family_Psychotherapy.Value;

	private CqlValueSet Psych_Visit_Psychotherapy_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1496", null);

    [CqlDeclaration("Psych Visit Psychotherapy")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1496")]
	public CqlValueSet Psych_Visit_Psychotherapy() => 
		__Psych_Visit_Psychotherapy.Value;

	private CqlValueSet Psychoanalysis_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1141", null);

    [CqlDeclaration("Psychoanalysis")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1141")]
	public CqlValueSet Psychoanalysis() => 
		__Psychoanalysis.Value;

	private CqlValueSet Telehealth_Services_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1031", null);

    [CqlDeclaration("Telehealth Services")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1031")]
	public CqlValueSet Telehealth_Services() => 
		__Telehealth_Services.Value;

	private CqlCode Birth_date_Value() => 
		new CqlCode("21112-8", "http://loinc.org", null, null);

    [CqlDeclaration("Birth date")]
	public CqlCode Birth_date() => 
		__Birth_date.Value;

	private CqlCode Suicide_risk_assessment__procedure__Value() => 
		new CqlCode("225337009", "http://snomed.info/sct", null, null);

    [CqlDeclaration("Suicide risk assessment (procedure)")]
	public CqlCode Suicide_risk_assessment__procedure_() => 
		__Suicide_risk_assessment__procedure_.Value;

	private CqlCode AMB_Value() => 
		new CqlCode("AMB", "http://terminology.hl7.org/CodeSystem/v3-ActCode", null, null);

    [CqlDeclaration("AMB")]
	public CqlCode AMB() => 
		__AMB.Value;

	private CqlCode[] LOINC_Value()
	{
		var a_ = new CqlCode[]
		{
			new CqlCode("21112-8", "http://loinc.org", null, null),
		};

		return a_;
	}

    [CqlDeclaration("LOINC")]
	public CqlCode[] LOINC() => 
		__LOINC.Value;

	private CqlCode[] SNOMEDCT_Value()
	{
		var a_ = new CqlCode[]
		{
			new CqlCode("225337009", "http://snomed.info/sct", null, null),
		};

		return a_;
	}

    [CqlDeclaration("SNOMEDCT")]
	public CqlCode[] SNOMEDCT() => 
		__SNOMEDCT.Value;

	private CqlCode[] ActCode_Value()
	{
		var a_ = new CqlCode[]
		{
			new CqlCode("AMB", "http://terminology.hl7.org/CodeSystem/v3-ActCode", null, null),
		};

		return a_;
	}

    [CqlDeclaration("ActCode")]
	public CqlCode[] ActCode() => 
		__ActCode.Value;

	private CqlCode[] ICD10CM_Value()
	{
		var a_ = new CqlCode[0]
;

		return a_;
	}

    [CqlDeclaration("ICD10CM")]
	public CqlCode[] ICD10CM() => 
		__ICD10CM.Value;

	private CqlInterval<CqlDateTime> Measurement_Period_Value()
	{
		var a_ = context.Operators.DateTime(2025, 1, 1, 0, 0, 0, 0, default);
		var b_ = context.Operators.DateTime(2026, 1, 1, 0, 0, 0, 0, default);
		var c_ = context.Operators.Interval(a_, b_, true, false);
		var d_ = context.ResolveParameter("ChildandAdolescentMajorDepressiveDisorderMDDSuicideRiskAssessmentFHIR-0.1.000", "Measurement Period", c_);

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

	private IEnumerable<Encounter> Major_Depressive_Disorder_Encounter_Value()
	{
		var a_ = this.Office_Visit();
		var b_ = context.Operators.RetrieveByValueSet<Encounter>(a_, null);
		var c_ = this.Outpatient_Consultation();
		var d_ = context.Operators.RetrieveByValueSet<Encounter>(c_, null);
		var e_ = context.Operators.ListUnion<Encounter>(b_, d_);
		var f_ = this.Psych_Visit_Diagnostic_Evaluation();
		var g_ = context.Operators.RetrieveByValueSet<Encounter>(f_, null);
		var h_ = this.Psych_Visit_for_Family_Psychotherapy();
		var i_ = context.Operators.RetrieveByValueSet<Encounter>(h_, null);
		var j_ = context.Operators.ListUnion<Encounter>(g_, i_);
		var k_ = context.Operators.ListUnion<Encounter>(e_, j_);
		var l_ = this.Psych_Visit_Psychotherapy();
		var m_ = context.Operators.RetrieveByValueSet<Encounter>(l_, null);
		var n_ = this.Psychoanalysis();
		var o_ = context.Operators.RetrieveByValueSet<Encounter>(n_, null);
		var p_ = context.Operators.ListUnion<Encounter>(m_, o_);
		var q_ = context.Operators.ListUnion<Encounter>(k_, p_);
		var r_ = this.Group_Psychotherapy();
		var s_ = context.Operators.RetrieveByValueSet<Encounter>(r_, null);
		var t_ = this.Telehealth_Services();
		var u_ = context.Operators.RetrieveByValueSet<Encounter>(t_, null);
		var v_ = context.Operators.ListUnion<Encounter>(s_, u_);
		var w_ = context.Operators.ListUnion<Encounter>(q_, v_);
		bool? x_(Encounter ValidEncounter)
		{
			var z_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(ValidEncounter?.StatusElement?.Value);
			var aa_ = context.Operators.Equal(z_, "finished");
			CqlConcept ab_(CodeableConcept @this)
			{
				var ap_ = FHIRHelpers_4_3_000.ToConcept(@this);

				return ap_;
			};
			var ac_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)ValidEncounter?.ReasonCode, ab_);
			var ad_ = this.Major_Depressive_Disorder_Active();
			var ae_ = context.Operators.ConceptsInValueSet(ac_, ad_);
			var af_ = CQMCommon_2_0_000.EncounterDiagnosis(ValidEncounter);
			bool? ag_(Condition EncounterDiagnosis)
			{
				var aq_ = FHIRHelpers_4_3_000.ToConcept(EncounterDiagnosis?.Code);
				var ar_ = this.Major_Depressive_Disorder_Active();
				var as_ = context.Operators.ConceptInValueSet(aq_, ar_);

				return as_;
			};
			var ah_ = context.Operators.Where<Condition>(af_, ag_);
			var ai_ = context.Operators.Exists<Condition>(ah_);
			var aj_ = context.Operators.Or(ae_, ai_);
			var ak_ = context.Operators.And(aa_, aj_);
			var al_ = this.Measurement_Period();
			var am_ = FHIRHelpers_4_3_000.ToInterval(ValidEncounter?.Period);
			var an_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(al_, am_, null);
			var ao_ = context.Operators.And(ak_, an_);

			return ao_;
		};
		var y_ = context.Operators.Where<Encounter>(w_, x_);

		return y_;
	}

    [CqlDeclaration("Major Depressive Disorder Encounter")]
	public IEnumerable<Encounter> Major_Depressive_Disorder_Encounter() => 
		__Major_Depressive_Disorder_Encounter.Value;

	private IEnumerable<Encounter> Initial_Population_Value()
	{
		var a_ = this.Major_Depressive_Disorder_Encounter();
		bool? b_(Encounter MDDEncounter)
		{
			var d_ = this.Patient();
			var e_ = context.Operators.Convert<CqlDate>(d_?.BirthDateElement?.Value);
			var f_ = this.Measurement_Period();
			var g_ = context.Operators.Start(f_);
			var h_ = context.Operators.DateFrom(g_);
			var i_ = context.Operators.CalculateAgeAt(e_, h_, "year");
			var j_ = context.Operators.GreaterOrEqual(i_, 6);
			var l_ = context.Operators.Convert<CqlDate>(d_?.BirthDateElement?.Value);
			var n_ = context.Operators.Start(f_);
			var o_ = context.Operators.DateFrom(n_);
			var p_ = context.Operators.CalculateAgeAt(l_, o_, "year");
			var q_ = context.Operators.LessOrEqual(p_, 16);
			var r_ = context.Operators.And(j_, q_);

			return r_;
		};
		var c_ = context.Operators.Where<Encounter>(a_, b_);

		return c_;
	}

    [CqlDeclaration("Initial Population")]
	public IEnumerable<Encounter> Initial_Population() => 
		__Initial_Population.Value;

	private IEnumerable<Encounter> Denominator_Value()
	{
		var a_ = this.Initial_Population();

		return a_;
	}

    [CqlDeclaration("Denominator")]
	public IEnumerable<Encounter> Denominator() => 
		__Denominator.Value;

	private IEnumerable<Encounter> Numerator_Value()
	{
		var a_ = this.Major_Depressive_Disorder_Encounter();
		IEnumerable<Encounter> b_(Encounter MDDEncounter)
		{
			var d_ = this.Suicide_risk_assessment__procedure_();
			var e_ = context.Operators.ToList<CqlCode>(d_);
			var f_ = context.Operators.RetrieveByCodes<Procedure>(e_, null);
			bool? g_(Procedure SuicideRiskAssessment)
			{
				var k_ = context.Operators.Convert<string>(SuicideRiskAssessment?.StatusElement?.Value);
				var l_ = context.Operators.Equal(k_, "completed");
				var m_ = FHIRHelpers_4_3_000.ToInterval(MDDEncounter?.Period);
				var n_ = FHIRHelpers_4_3_000.ToValue(SuicideRiskAssessment?.Performed);
				var o_ = QICoreCommon_2_0_000.ToInterval(n_);
				var p_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(m_, o_, null);
				var q_ = context.Operators.And(l_, p_);

				return q_;
			};
			var h_ = context.Operators.Where<Procedure>(f_, g_);
			Encounter i_(Procedure SuicideRiskAssessment) => 
				MDDEncounter;
			var j_ = context.Operators.Select<Procedure, Encounter>(h_, i_);

			return j_;
		};
		var c_ = context.Operators.SelectMany<Encounter, Encounter>(a_, b_);

		return c_;
	}

    [CqlDeclaration("Numerator")]
	public IEnumerable<Encounter> Numerator() => 
		__Numerator.Value;

}
