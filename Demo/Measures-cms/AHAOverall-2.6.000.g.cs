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
[CqlLibrary("AHAOverall", "2.6.000")]
public class AHAOverall_2_6_000
{


    internal CqlContext context;

    #region Cached values

    internal Lazy<CqlValueSet> __Care_Services_in_Long_Term_Residential_Facility;
    internal Lazy<CqlValueSet> __Ejection_Fraction;
    internal Lazy<CqlValueSet> __Heart_Failure;
    internal Lazy<CqlValueSet> __Heart_Transplant;
    internal Lazy<CqlValueSet> __Heart_Transplant_Complications;
    internal Lazy<CqlValueSet> __Home_Healthcare_Services;
    internal Lazy<CqlValueSet> __Left_Ventricular_Assist_Device_Complications;
    internal Lazy<CqlValueSet> __Left_Ventricular_Assist_Device_Placement;
    internal Lazy<CqlValueSet> __Moderate_or_Severe;
    internal Lazy<CqlValueSet> __Moderate_or_Severe_LVSD;
    internal Lazy<CqlValueSet> __Nursing_Facility_Visit;
    internal Lazy<CqlValueSet> __Office_Visit;
    internal Lazy<CqlValueSet> __Outpatient_Consultation;
    internal Lazy<CqlValueSet> __Patient_Provider_Interaction;
    internal Lazy<CqlCode> __Left_ventricular_systolic_dysfunction__disorder_;
    internal Lazy<CqlCode> __allergy_entered_in_error;
    internal Lazy<CqlCode[]> __SNOMEDCT;
    internal Lazy<CqlCode[]> __AllergyIntoleranceVerificationStatusCodes;
    internal Lazy<CqlInterval<CqlDateTime>> __Measurement_Period;
    internal Lazy<Patient> __Patient;
    internal Lazy<IEnumerable<Encounter>> __Heart_Failure_Outpatient_Encounter;
    internal Lazy<IEnumerable<object>> __Moderate_or_Severe_LVSD_Findings;
    internal Lazy<IEnumerable<Encounter>> __Heart_Failure_Outpatient_Encounter_with_History_of_Moderate_or_Severe_LVSD;
    internal Lazy<bool?> __Has_Heart_Transplant_Complications;
    internal Lazy<bool?> __Has_Left_Ventricular_Assist_Device;
    internal Lazy<bool?> __Has_Left_Ventricular_Assist_Device_Complications;
    internal Lazy<IEnumerable<Encounter>> __Qualifying_Outpatient_Encounter_During_Measurement_Period;
    internal Lazy<bool?> __Has_Two_Qualifying_Outpatient_Encounters_and_Heart_Failure_Outpatient_Encounter_During_the_Measurement_Period;
    internal Lazy<bool?> __Has_Heart_Transplant;

    #endregion
    public AHAOverall_2_6_000(CqlContext context)
    {
        this.context = context ?? throw new ArgumentNullException("context");

        FHIRHelpers_4_3_000 = new FHIRHelpers_4_3_000(context);
        QICoreCommon_2_0_000 = new QICoreCommon_2_0_000(context);

        __Care_Services_in_Long_Term_Residential_Facility = new Lazy<CqlValueSet>(this.Care_Services_in_Long_Term_Residential_Facility_Value);
        __Ejection_Fraction = new Lazy<CqlValueSet>(this.Ejection_Fraction_Value);
        __Heart_Failure = new Lazy<CqlValueSet>(this.Heart_Failure_Value);
        __Heart_Transplant = new Lazy<CqlValueSet>(this.Heart_Transplant_Value);
        __Heart_Transplant_Complications = new Lazy<CqlValueSet>(this.Heart_Transplant_Complications_Value);
        __Home_Healthcare_Services = new Lazy<CqlValueSet>(this.Home_Healthcare_Services_Value);
        __Left_Ventricular_Assist_Device_Complications = new Lazy<CqlValueSet>(this.Left_Ventricular_Assist_Device_Complications_Value);
        __Left_Ventricular_Assist_Device_Placement = new Lazy<CqlValueSet>(this.Left_Ventricular_Assist_Device_Placement_Value);
        __Moderate_or_Severe = new Lazy<CqlValueSet>(this.Moderate_or_Severe_Value);
        __Moderate_or_Severe_LVSD = new Lazy<CqlValueSet>(this.Moderate_or_Severe_LVSD_Value);
        __Nursing_Facility_Visit = new Lazy<CqlValueSet>(this.Nursing_Facility_Visit_Value);
        __Office_Visit = new Lazy<CqlValueSet>(this.Office_Visit_Value);
        __Outpatient_Consultation = new Lazy<CqlValueSet>(this.Outpatient_Consultation_Value);
        __Patient_Provider_Interaction = new Lazy<CqlValueSet>(this.Patient_Provider_Interaction_Value);
        __Left_ventricular_systolic_dysfunction__disorder_ = new Lazy<CqlCode>(this.Left_ventricular_systolic_dysfunction__disorder__Value);
        __allergy_entered_in_error = new Lazy<CqlCode>(this.allergy_entered_in_error_Value);
        __SNOMEDCT = new Lazy<CqlCode[]>(this.SNOMEDCT_Value);
        __AllergyIntoleranceVerificationStatusCodes = new Lazy<CqlCode[]>(this.AllergyIntoleranceVerificationStatusCodes_Value);
        __Measurement_Period = new Lazy<CqlInterval<CqlDateTime>>(this.Measurement_Period_Value);
        __Patient = new Lazy<Patient>(this.Patient_Value);
        __Heart_Failure_Outpatient_Encounter = new Lazy<IEnumerable<Encounter>>(this.Heart_Failure_Outpatient_Encounter_Value);
        __Moderate_or_Severe_LVSD_Findings = new Lazy<IEnumerable<object>>(this.Moderate_or_Severe_LVSD_Findings_Value);
        __Heart_Failure_Outpatient_Encounter_with_History_of_Moderate_or_Severe_LVSD = new Lazy<IEnumerable<Encounter>>(this.Heart_Failure_Outpatient_Encounter_with_History_of_Moderate_or_Severe_LVSD_Value);
        __Has_Heart_Transplant_Complications = new Lazy<bool?>(this.Has_Heart_Transplant_Complications_Value);
        __Has_Left_Ventricular_Assist_Device = new Lazy<bool?>(this.Has_Left_Ventricular_Assist_Device_Value);
        __Has_Left_Ventricular_Assist_Device_Complications = new Lazy<bool?>(this.Has_Left_Ventricular_Assist_Device_Complications_Value);
        __Qualifying_Outpatient_Encounter_During_Measurement_Period = new Lazy<IEnumerable<Encounter>>(this.Qualifying_Outpatient_Encounter_During_Measurement_Period_Value);
        __Has_Two_Qualifying_Outpatient_Encounters_and_Heart_Failure_Outpatient_Encounter_During_the_Measurement_Period = new Lazy<bool?>(this.Has_Two_Qualifying_Outpatient_Encounters_and_Heart_Failure_Outpatient_Encounter_During_the_Measurement_Period_Value);
        __Has_Heart_Transplant = new Lazy<bool?>(this.Has_Heart_Transplant_Value);
    }
    #region Dependencies

    public FHIRHelpers_4_3_000 FHIRHelpers_4_3_000 { get; }
    public QICoreCommon_2_0_000 QICoreCommon_2_0_000 { get; }

    #endregion

	private CqlValueSet Care_Services_in_Long_Term_Residential_Facility_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1014", null);

    [CqlDeclaration("Care Services in Long Term Residential Facility")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1014")]
	public CqlValueSet Care_Services_in_Long_Term_Residential_Facility() => 
		__Care_Services_in_Long_Term_Residential_Facility.Value;

	private CqlValueSet Ejection_Fraction_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1134", null);

    [CqlDeclaration("Ejection Fraction")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1134")]
	public CqlValueSet Ejection_Fraction() => 
		__Ejection_Fraction.Value;

	private CqlValueSet Heart_Failure_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.376", null);

    [CqlDeclaration("Heart Failure")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.376")]
	public CqlValueSet Heart_Failure() => 
		__Heart_Failure.Value;

	private CqlValueSet Heart_Transplant_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1178.33", null);

    [CqlDeclaration("Heart Transplant")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1178.33")]
	public CqlValueSet Heart_Transplant() => 
		__Heart_Transplant.Value;

	private CqlValueSet Heart_Transplant_Complications_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1178.56", null);

    [CqlDeclaration("Heart Transplant Complications")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1178.56")]
	public CqlValueSet Heart_Transplant_Complications() => 
		__Heart_Transplant_Complications.Value;

	private CqlValueSet Home_Healthcare_Services_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1016", null);

    [CqlDeclaration("Home Healthcare Services")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1016")]
	public CqlValueSet Home_Healthcare_Services() => 
		__Home_Healthcare_Services.Value;

	private CqlValueSet Left_Ventricular_Assist_Device_Complications_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1178.58", null);

    [CqlDeclaration("Left Ventricular Assist Device Complications")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1178.58")]
	public CqlValueSet Left_Ventricular_Assist_Device_Complications() => 
		__Left_Ventricular_Assist_Device_Complications.Value;

	private CqlValueSet Left_Ventricular_Assist_Device_Placement_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1178.61", null);

    [CqlDeclaration("Left Ventricular Assist Device Placement")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1178.61")]
	public CqlValueSet Left_Ventricular_Assist_Device_Placement() => 
		__Left_Ventricular_Assist_Device_Placement.Value;

	private CqlValueSet Moderate_or_Severe_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1092", null);

    [CqlDeclaration("Moderate or Severe")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1092")]
	public CqlValueSet Moderate_or_Severe() => 
		__Moderate_or_Severe.Value;

	private CqlValueSet Moderate_or_Severe_LVSD_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1090", null);

    [CqlDeclaration("Moderate or Severe LVSD")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1090")]
	public CqlValueSet Moderate_or_Severe_LVSD() => 
		__Moderate_or_Severe_LVSD.Value;

	private CqlValueSet Nursing_Facility_Visit_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1012", null);

    [CqlDeclaration("Nursing Facility Visit")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1012")]
	public CqlValueSet Nursing_Facility_Visit() => 
		__Nursing_Facility_Visit.Value;

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

	private CqlValueSet Patient_Provider_Interaction_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1012", null);

    [CqlDeclaration("Patient Provider Interaction")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1012")]
	public CqlValueSet Patient_Provider_Interaction() => 
		__Patient_Provider_Interaction.Value;

	private CqlCode Left_ventricular_systolic_dysfunction__disorder__Value() => 
		new CqlCode("134401001", "http://snomed.info/sct", null, null);

    [CqlDeclaration("Left ventricular systolic dysfunction (disorder)")]
	public CqlCode Left_ventricular_systolic_dysfunction__disorder_() => 
		__Left_ventricular_systolic_dysfunction__disorder_.Value;

	private CqlCode allergy_entered_in_error_Value() => 
		new CqlCode("entered-in-error", "http://terminology.hl7.org/CodeSystem/allergyintolerance-verification", null, null);

    [CqlDeclaration("allergy-entered-in-error")]
	public CqlCode allergy_entered_in_error() => 
		__allergy_entered_in_error.Value;

	private CqlCode[] SNOMEDCT_Value()
	{
		CqlCode[] a_ = new CqlCode[]
		{
			new CqlCode("134401001", "http://snomed.info/sct", null, null),
		};

		return a_;
	}

    [CqlDeclaration("SNOMEDCT")]
	public CqlCode[] SNOMEDCT() => 
		__SNOMEDCT.Value;

	private CqlCode[] AllergyIntoleranceVerificationStatusCodes_Value()
	{
		CqlCode[] a_ = new CqlCode[]
		{
			new CqlCode("entered-in-error", "http://terminology.hl7.org/CodeSystem/allergyintolerance-verification", null, null),
		};

		return a_;
	}

    [CqlDeclaration("AllergyIntoleranceVerificationStatusCodes")]
	public CqlCode[] AllergyIntoleranceVerificationStatusCodes() => 
		__AllergyIntoleranceVerificationStatusCodes.Value;

	private CqlInterval<CqlDateTime> Measurement_Period_Value()
	{
		CqlDateTime a_ = context.Operators.DateTime(2025, 1, 1, 0, 0, 0, 0, default);
		CqlDateTime b_ = context.Operators.DateTime(2026, 1, 1, 0, 0, 0, 0, default);
		CqlInterval<CqlDateTime> c_ = context.Operators.Interval(a_, b_, true, false);
		object d_ = context.ResolveParameter("AHAOverall-2.6.000", "Measurement Period", c_);

		return (CqlInterval<CqlDateTime>)d_;
	}

    [CqlDeclaration("Measurement Period")]
	public CqlInterval<CqlDateTime> Measurement_Period() => 
		__Measurement_Period.Value;

	private Patient Patient_Value()
	{
		IEnumerable<Patient> a_ = context.Operators.RetrieveByValueSet<Patient>(null, null);
		Patient b_ = context.Operators.SingletonFrom<Patient>(a_);

		return b_;
	}

    [CqlDeclaration("Patient")]
	public Patient Patient() => 
		__Patient.Value;

    [CqlDeclaration("isConfirmedActiveDiagnosis")]
	public bool? isConfirmedActiveDiagnosis(Condition Condition)
	{
		Condition[] a_ = new Condition[]
		{
			Condition,
		};
		bool? b_(Condition Diagnosis)
		{
			CqlConcept f_ = FHIRHelpers_4_3_000.ToConcept(Diagnosis?.ClinicalStatus);
			CqlCode g_ = QICoreCommon_2_0_000.active();
			CqlConcept h_ = context.Operators.ConvertCodeToConcept(g_);
			bool? i_ = context.Operators.Equivalent(f_, h_);
			CqlConcept j_ = FHIRHelpers_4_3_000.ToConcept(Diagnosis?.VerificationStatus);
			CqlCode k_ = QICoreCommon_2_0_000.unconfirmed();
			CqlConcept l_ = context.Operators.ConvertCodeToConcept(k_);
			bool? m_ = context.Operators.Equivalent(j_, l_);
			CqlCode o_ = QICoreCommon_2_0_000.refuted();
			CqlConcept p_ = context.Operators.ConvertCodeToConcept(o_);
			bool? q_ = context.Operators.Equivalent(j_, p_);
			bool? r_ = context.Operators.Or(m_, q_);
			CqlCode t_ = QICoreCommon_2_0_000.entered_in_error();
			CqlConcept u_ = context.Operators.ConvertCodeToConcept(t_);
			bool? v_ = context.Operators.Equivalent(j_, u_);
			bool? w_ = context.Operators.Or(r_, v_);
			bool? x_ = context.Operators.Not(w_);
			bool? y_ = context.Operators.And(i_, x_);

			return y_;
		};
		IEnumerable<Condition> c_ = context.Operators.Where<Condition>(a_, b_);
		Condition d_ = context.Operators.SingletonFrom<Condition>(c_);
		bool? e_ = context.Operators.Not((bool?)(d_ is null));

		return e_;
	}

    [CqlDeclaration("isFinished")]
	public bool? isFinished(Encounter Visit)
	{
		Code<Encounter.EncounterStatus> a_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(Visit?.StatusElement?.Value);
		bool? b_ = context.Operators.Equal(a_, "finished");

		return b_;
	}

	private IEnumerable<Encounter> Heart_Failure_Outpatient_Encounter_Value()
	{
		CqlValueSet a_ = this.Care_Services_in_Long_Term_Residential_Facility();
		IEnumerable<Encounter> b_ = context.Operators.RetrieveByValueSet<Encounter>(a_, null);
		CqlValueSet c_ = this.Home_Healthcare_Services();
		IEnumerable<Encounter> d_ = context.Operators.RetrieveByValueSet<Encounter>(c_, null);
		IEnumerable<Encounter> e_ = context.Operators.ListUnion<Encounter>(b_, d_);
		CqlValueSet f_ = this.Nursing_Facility_Visit();
		IEnumerable<Encounter> g_ = context.Operators.RetrieveByValueSet<Encounter>(f_, null);
		CqlValueSet h_ = this.Office_Visit();
		IEnumerable<Encounter> i_ = context.Operators.RetrieveByValueSet<Encounter>(h_, null);
		IEnumerable<Encounter> j_ = context.Operators.ListUnion<Encounter>(g_, i_);
		IEnumerable<Encounter> k_ = context.Operators.ListUnion<Encounter>(e_, j_);
		CqlValueSet l_ = this.Outpatient_Consultation();
		IEnumerable<Encounter> m_ = context.Operators.RetrieveByValueSet<Encounter>(l_, null);
		IEnumerable<Encounter> n_ = context.Operators.ListUnion<Encounter>(k_, m_);
		IEnumerable<Encounter> o_(Encounter QualifyingEncounter)
		{
			CqlValueSet s_ = this.Heart_Failure();
			IEnumerable<Condition> t_ = context.Operators.RetrieveByValueSet<Condition>(s_, null);
			bool? u_(Condition HeartFailure)
			{
				CqlInterval<CqlDateTime> y_ = QICoreCommon_2_0_000.prevalenceInterval(HeartFailure);
				CqlInterval<CqlDateTime> z_ = FHIRHelpers_4_3_000.ToInterval(QualifyingEncounter?.Period);
				bool? aa_ = context.Operators.Overlaps(y_, z_, null);
				bool? ab_ = this.isConfirmedActiveDiagnosis(HeartFailure);
				bool? ac_ = context.Operators.And(aa_, ab_);

				return ac_;
			};
			IEnumerable<Condition> v_ = context.Operators.Where<Condition>(t_, u_);
			Encounter w_(Condition HeartFailure) => 
				QualifyingEncounter;
			IEnumerable<Encounter> x_ = context.Operators.Select<Condition, Encounter>(v_, w_);

			return x_;
		};
		IEnumerable<Encounter> p_ = context.Operators.SelectMany<Encounter, Encounter>(n_, o_);
		bool? q_(Encounter QualifyingEncounter)
		{
			CqlInterval<CqlDateTime> ad_ = this.Measurement_Period();
			CqlInterval<CqlDateTime> ae_ = FHIRHelpers_4_3_000.ToInterval(QualifyingEncounter?.Period);
			bool? af_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(ad_, ae_, null);
			bool? ag_ = this.isFinished(QualifyingEncounter);
			bool? ah_ = context.Operators.And(af_, ag_);

			return ah_;
		};
		IEnumerable<Encounter> r_ = context.Operators.Where<Encounter>(p_, q_);

		return r_;
	}

    [CqlDeclaration("Heart Failure Outpatient Encounter")]
	public IEnumerable<Encounter> Heart_Failure_Outpatient_Encounter() => 
		__Heart_Failure_Outpatient_Encounter.Value;

	private IEnumerable<object> Moderate_or_Severe_LVSD_Findings_Value()
	{
		CqlValueSet a_ = this.Ejection_Fraction();
		IEnumerable<Observation> b_ = context.Operators.RetrieveByValueSet<Observation>(a_, null);
		bool? c_(Observation EjectionFraction)
		{
			object n_ = FHIRHelpers_4_3_000.ToValue(EjectionFraction?.Value);
			CqlQuantity o_ = context.Operators.Quantity(40m, "%");
			bool? p_ = context.Operators.LessOrEqual((n_ as CqlQuantity), o_);
			Code<ObservationStatus> q_ = context.Operators.Convert<Code<ObservationStatus>>(EjectionFraction?.StatusElement?.Value);
			string r_ = context.Operators.Convert<string>(q_);
			string[] s_ = new string[]
			{
				"final",
				"amended",
				"corrected",
			};
			bool? t_ = context.Operators.In<string>(r_, (s_ as IEnumerable<string>));
			bool? u_ = context.Operators.And(p_, t_);

			return u_;
		};
		IEnumerable<Observation> d_ = context.Operators.Where<Observation>(b_, c_);
		CqlValueSet e_ = this.Moderate_or_Severe_LVSD();
		IEnumerable<Condition> f_ = context.Operators.RetrieveByValueSet<Condition>(e_, null);
		IEnumerable<object> g_ = context.Operators.ListUnion<object>((d_ as IEnumerable<object>), (f_ as IEnumerable<object>));
		CqlCode h_ = this.Left_ventricular_systolic_dysfunction__disorder_();
		IEnumerable<CqlCode> i_ = context.Operators.ToList<CqlCode>(h_);
		IEnumerable<Condition> j_ = context.Operators.RetrieveByCodes<Condition>(i_, null);
		bool? k_(Condition LVSDDiagnosis)
		{
			CqlConcept v_ = FHIRHelpers_4_3_000.ToConcept(LVSDDiagnosis?.Severity);
			CqlValueSet w_ = this.Moderate_or_Severe();
			bool? x_ = context.Operators.ConceptInValueSet(v_, w_);

			return x_;
		};
		IEnumerable<Condition> l_ = context.Operators.Where<Condition>(j_, k_);
		IEnumerable<object> m_ = context.Operators.ListUnion<object>(g_, (l_ as IEnumerable<object>));

		return m_;
	}

    [CqlDeclaration("Moderate or Severe LVSD Findings")]
	public IEnumerable<object> Moderate_or_Severe_LVSD_Findings() => 
		__Moderate_or_Severe_LVSD_Findings.Value;

	private IEnumerable<Encounter> Heart_Failure_Outpatient_Encounter_with_History_of_Moderate_or_Severe_LVSD_Value()
	{
		IEnumerable<Encounter> a_ = this.Heart_Failure_Outpatient_Encounter();
		IEnumerable<Encounter> b_(Encounter HFOutpatientEncounter)
		{
			IEnumerable<object> d_ = this.Moderate_or_Severe_LVSD_Findings();
			bool? e_(object LVSDFindings)
			{
				CqlInterval<CqlDateTime> i_ = QICoreCommon_2_0_000.prevalenceInterval((LVSDFindings as Condition));
				object j_ = context.Operators.LateBoundProperty<object>(LVSDFindings, "effective");
				object k_ = FHIRHelpers_4_3_000.ToValue(j_);
				CqlInterval<CqlDateTime> l_ = QICoreCommon_2_0_000.toInterval(k_);
				CqlDateTime m_ = context.Operators.Start((i_ ?? l_));
				CqlInterval<CqlDateTime> n_ = FHIRHelpers_4_3_000.ToInterval(HFOutpatientEncounter?.Period);
				CqlDateTime o_ = context.Operators.End(n_);
				bool? p_ = context.Operators.Before(m_, o_, null);

				return p_;
			};
			IEnumerable<object> f_ = context.Operators.Where<object>(d_, e_);
			Encounter g_(object LVSDFindings) => 
				HFOutpatientEncounter;
			IEnumerable<Encounter> h_ = context.Operators.Select<object, Encounter>(f_, g_);

			return h_;
		};
		IEnumerable<Encounter> c_ = context.Operators.SelectMany<Encounter, Encounter>(a_, b_);

		return c_;
	}

    [CqlDeclaration("Heart Failure Outpatient Encounter with History of Moderate or Severe LVSD")]
	public IEnumerable<Encounter> Heart_Failure_Outpatient_Encounter_with_History_of_Moderate_or_Severe_LVSD() => 
		__Heart_Failure_Outpatient_Encounter_with_History_of_Moderate_or_Severe_LVSD.Value;

	private bool? Has_Heart_Transplant_Complications_Value()
	{
		CqlValueSet a_ = this.Heart_Transplant_Complications();
		IEnumerable<Condition> b_ = context.Operators.RetrieveByValueSet<Condition>(a_, null);
		IEnumerable<Condition> c_(Condition HeartTransplantComplications)
		{
			IEnumerable<Encounter> h_ = this.Heart_Failure_Outpatient_Encounter_with_History_of_Moderate_or_Severe_LVSD();
			bool? i_(Encounter ModerateOrSevereLVSDHFOutpatientEncounter)
			{
				CqlDateTime m_ = context.Operators.Convert<CqlDateTime>(HeartTransplantComplications?.RecordedDateElement);
				CqlInterval<CqlDateTime> n_ = QICoreCommon_2_0_000.toInterval((m_ as object));
				CqlInterval<CqlDateTime> o_ = QICoreCommon_2_0_000.prevalenceInterval(HeartTransplantComplications);
				CqlDateTime p_ = context.Operators.Start((n_ ?? o_));
				CqlInterval<CqlDateTime> q_ = FHIRHelpers_4_3_000.ToInterval(ModerateOrSevereLVSDHFOutpatientEncounter?.Period);
				CqlDateTime r_ = context.Operators.End(q_);
				bool? s_ = context.Operators.Before(p_, r_, null);

				return s_;
			};
			IEnumerable<Encounter> j_ = context.Operators.Where<Encounter>(h_, i_);
			Condition k_(Encounter ModerateOrSevereLVSDHFOutpatientEncounter) => 
				HeartTransplantComplications;
			IEnumerable<Condition> l_ = context.Operators.Select<Encounter, Condition>(j_, k_);

			return l_;
		};
		IEnumerable<Condition> d_ = context.Operators.SelectMany<Condition, Condition>(b_, c_);
		bool? e_(Condition HeartTransplantComplications)
		{
			bool? t_ = this.isConfirmedActiveDiagnosis(HeartTransplantComplications);

			return t_;
		};
		IEnumerable<Condition> f_ = context.Operators.Where<Condition>(d_, e_);
		bool? g_ = context.Operators.Exists<Condition>(f_);

		return g_;
	}

    [CqlDeclaration("Has Heart Transplant Complications")]
	public bool? Has_Heart_Transplant_Complications() => 
		__Has_Heart_Transplant_Complications.Value;

	private bool? Has_Left_Ventricular_Assist_Device_Value()
	{
		CqlValueSet a_ = this.Left_Ventricular_Assist_Device_Placement();
		IEnumerable<Procedure> b_ = context.Operators.RetrieveByValueSet<Procedure>(a_, null);
		IEnumerable<Procedure> c_(Procedure LVADOutpatient)
		{
			IEnumerable<Encounter> h_ = this.Heart_Failure_Outpatient_Encounter_with_History_of_Moderate_or_Severe_LVSD();
			bool? i_(Encounter ModerateOrSevereLVSDHFOutpatientEncounter)
			{
				object m_ = FHIRHelpers_4_3_000.ToValue(LVADOutpatient?.Performed);
				CqlInterval<CqlDateTime> n_ = QICoreCommon_2_0_000.toInterval(m_);
				CqlDateTime o_ = context.Operators.Start(n_);
				CqlInterval<CqlDateTime> p_ = FHIRHelpers_4_3_000.ToInterval(ModerateOrSevereLVSDHFOutpatientEncounter?.Period);
				CqlDateTime q_ = context.Operators.End(p_);
				bool? r_ = context.Operators.Before(o_, q_, null);

				return r_;
			};
			IEnumerable<Encounter> j_ = context.Operators.Where<Encounter>(h_, i_);
			Procedure k_(Encounter ModerateOrSevereLVSDHFOutpatientEncounter) => 
				LVADOutpatient;
			IEnumerable<Procedure> l_ = context.Operators.Select<Encounter, Procedure>(j_, k_);

			return l_;
		};
		IEnumerable<Procedure> d_ = context.Operators.SelectMany<Procedure, Procedure>(b_, c_);
		bool? e_(Procedure LVADOutpatient)
		{
			string s_ = context.Operators.Convert<string>(LVADOutpatient?.StatusElement?.Value);
			bool? t_ = context.Operators.Equal(s_, "completed");

			return t_;
		};
		IEnumerable<Procedure> f_ = context.Operators.Where<Procedure>(d_, e_);
		bool? g_ = context.Operators.Exists<Procedure>(f_);

		return g_;
	}

    [CqlDeclaration("Has Left Ventricular Assist Device")]
	public bool? Has_Left_Ventricular_Assist_Device() => 
		__Has_Left_Ventricular_Assist_Device.Value;

	private bool? Has_Left_Ventricular_Assist_Device_Complications_Value()
	{
		CqlValueSet a_ = this.Left_Ventricular_Assist_Device_Complications();
		IEnumerable<Condition> b_ = context.Operators.RetrieveByValueSet<Condition>(a_, null);
		IEnumerable<Condition> c_(Condition LVADComplications)
		{
			IEnumerable<Encounter> h_ = this.Heart_Failure_Outpatient_Encounter_with_History_of_Moderate_or_Severe_LVSD();
			bool? i_(Encounter ModerateOrSevereLVSDHFOutpatientEncounter)
			{
				CqlDateTime m_ = context.Operators.Convert<CqlDateTime>(LVADComplications?.RecordedDateElement);
				CqlInterval<CqlDateTime> n_ = QICoreCommon_2_0_000.toInterval((m_ as object));
				CqlInterval<CqlDateTime> o_ = QICoreCommon_2_0_000.prevalenceInterval(LVADComplications);
				CqlDateTime p_ = context.Operators.Start((n_ ?? o_));
				CqlInterval<CqlDateTime> q_ = FHIRHelpers_4_3_000.ToInterval(ModerateOrSevereLVSDHFOutpatientEncounter?.Period);
				CqlDateTime r_ = context.Operators.End(q_);
				bool? s_ = context.Operators.Before(p_, r_, null);

				return s_;
			};
			IEnumerable<Encounter> j_ = context.Operators.Where<Encounter>(h_, i_);
			Condition k_(Encounter ModerateOrSevereLVSDHFOutpatientEncounter) => 
				LVADComplications;
			IEnumerable<Condition> l_ = context.Operators.Select<Encounter, Condition>(j_, k_);

			return l_;
		};
		IEnumerable<Condition> d_ = context.Operators.SelectMany<Condition, Condition>(b_, c_);
		bool? e_(Condition LVADComplications)
		{
			bool? t_ = this.isConfirmedActiveDiagnosis(LVADComplications);

			return t_;
		};
		IEnumerable<Condition> f_ = context.Operators.Where<Condition>(d_, e_);
		bool? g_ = context.Operators.Exists<Condition>(f_);

		return g_;
	}

    [CqlDeclaration("Has Left Ventricular Assist Device Complications")]
	public bool? Has_Left_Ventricular_Assist_Device_Complications() => 
		__Has_Left_Ventricular_Assist_Device_Complications.Value;

	private IEnumerable<Encounter> Qualifying_Outpatient_Encounter_During_Measurement_Period_Value()
	{
		CqlValueSet a_ = this.Care_Services_in_Long_Term_Residential_Facility();
		IEnumerable<Encounter> b_ = context.Operators.RetrieveByValueSet<Encounter>(a_, null);
		CqlValueSet c_ = this.Home_Healthcare_Services();
		IEnumerable<Encounter> d_ = context.Operators.RetrieveByValueSet<Encounter>(c_, null);
		IEnumerable<Encounter> e_ = context.Operators.ListUnion<Encounter>(b_, d_);
		CqlValueSet f_ = this.Nursing_Facility_Visit();
		IEnumerable<Encounter> g_ = context.Operators.RetrieveByValueSet<Encounter>(f_, null);
		CqlValueSet h_ = this.Office_Visit();
		IEnumerable<Encounter> i_ = context.Operators.RetrieveByValueSet<Encounter>(h_, null);
		IEnumerable<Encounter> j_ = context.Operators.ListUnion<Encounter>(g_, i_);
		IEnumerable<Encounter> k_ = context.Operators.ListUnion<Encounter>(e_, j_);
		CqlValueSet l_ = this.Outpatient_Consultation();
		IEnumerable<Encounter> m_ = context.Operators.RetrieveByValueSet<Encounter>(l_, null);
		CqlValueSet n_ = this.Patient_Provider_Interaction();
		IEnumerable<Encounter> o_ = context.Operators.RetrieveByValueSet<Encounter>(n_, null);
		IEnumerable<Encounter> p_ = context.Operators.ListUnion<Encounter>(m_, o_);
		IEnumerable<Encounter> q_ = context.Operators.ListUnion<Encounter>(k_, p_);
		bool? r_(Encounter ValidEncounter)
		{
			CqlInterval<CqlDateTime> t_ = this.Measurement_Period();
			CqlInterval<CqlDateTime> u_ = FHIRHelpers_4_3_000.ToInterval(ValidEncounter?.Period);
			bool? v_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(t_, u_, null);
			bool? w_ = this.isFinished(ValidEncounter);
			bool? x_ = context.Operators.And(v_, w_);

			return x_;
		};
		IEnumerable<Encounter> s_ = context.Operators.Where<Encounter>(q_, r_);

		return s_;
	}

    [CqlDeclaration("Qualifying Outpatient Encounter During Measurement Period")]
	public IEnumerable<Encounter> Qualifying_Outpatient_Encounter_During_Measurement_Period() => 
		__Qualifying_Outpatient_Encounter_During_Measurement_Period.Value;

	private bool? Has_Two_Qualifying_Outpatient_Encounters_and_Heart_Failure_Outpatient_Encounter_During_the_Measurement_Period_Value()
	{
		Patient a_ = this.Patient();
		CqlDate b_ = context.Operators.Convert<CqlDate>(a_?.BirthDateElement?.Value);
		CqlInterval<CqlDateTime> c_ = this.Measurement_Period();
		CqlDateTime d_ = context.Operators.Start(c_);
		CqlDate e_ = context.Operators.DateFrom(d_);
		int? f_ = context.Operators.CalculateAgeAt(b_, e_, "year");
		bool? g_ = context.Operators.GreaterOrEqual(f_, 18);
		IEnumerable<Encounter> h_ = this.Qualifying_Outpatient_Encounter_During_Measurement_Period();
		IEnumerable<Encounter> i_(Encounter Encounter1)
		{
			IEnumerable<Encounter> p_ = this.Qualifying_Outpatient_Encounter_During_Measurement_Period();
			bool? q_(Encounter Encounter2)
			{
				bool? u_ = context.Operators.Equivalent(Encounter2?.IdElement?.Value, Encounter1?.IdElement?.Value);
				bool? v_ = context.Operators.Not(u_);

				return v_;
			};
			IEnumerable<Encounter> r_ = context.Operators.Where<Encounter>(p_, q_);
			Encounter s_(Encounter Encounter2) => 
				Encounter1;
			IEnumerable<Encounter> t_ = context.Operators.Select<Encounter, Encounter>(r_, s_);

			return t_;
		};
		IEnumerable<Encounter> j_ = context.Operators.SelectMany<Encounter, Encounter>(h_, i_);
		bool? k_ = context.Operators.Exists<Encounter>(j_);
		bool? l_ = context.Operators.And(g_, k_);
		IEnumerable<Encounter> m_ = this.Heart_Failure_Outpatient_Encounter();
		bool? n_ = context.Operators.Exists<Encounter>(m_);
		bool? o_ = context.Operators.And(l_, n_);

		return o_;
	}

    [CqlDeclaration("Has Two Qualifying Outpatient Encounters and Heart Failure Outpatient Encounter During the Measurement Period")]
	public bool? Has_Two_Qualifying_Outpatient_Encounters_and_Heart_Failure_Outpatient_Encounter_During_the_Measurement_Period() => 
		__Has_Two_Qualifying_Outpatient_Encounters_and_Heart_Failure_Outpatient_Encounter_During_the_Measurement_Period.Value;

	private bool? Has_Heart_Transplant_Value()
	{
		CqlValueSet a_ = this.Heart_Transplant();
		IEnumerable<Procedure> b_ = context.Operators.RetrieveByValueSet<Procedure>(a_, null);
		IEnumerable<Procedure> c_(Procedure HeartTransplant)
		{
			IEnumerable<Encounter> h_ = this.Heart_Failure_Outpatient_Encounter_with_History_of_Moderate_or_Severe_LVSD();
			bool? i_(Encounter ModerateOrSevereLVSDHFOutpatientEncounter)
			{
				object m_ = FHIRHelpers_4_3_000.ToValue(HeartTransplant?.Performed);
				CqlInterval<CqlDateTime> n_ = QICoreCommon_2_0_000.toInterval(m_);
				CqlDateTime o_ = context.Operators.Start(n_);
				CqlInterval<CqlDateTime> p_ = FHIRHelpers_4_3_000.ToInterval(ModerateOrSevereLVSDHFOutpatientEncounter?.Period);
				CqlDateTime q_ = context.Operators.End(p_);
				bool? r_ = context.Operators.Before(o_, q_, null);

				return r_;
			};
			IEnumerable<Encounter> j_ = context.Operators.Where<Encounter>(h_, i_);
			Procedure k_(Encounter ModerateOrSevereLVSDHFOutpatientEncounter) => 
				HeartTransplant;
			IEnumerable<Procedure> l_ = context.Operators.Select<Encounter, Procedure>(j_, k_);

			return l_;
		};
		IEnumerable<Procedure> d_ = context.Operators.SelectMany<Procedure, Procedure>(b_, c_);
		bool? e_(Procedure HeartTransplant)
		{
			string s_ = context.Operators.Convert<string>(HeartTransplant?.StatusElement?.Value);
			bool? t_ = context.Operators.Equal(s_, "completed");

			return t_;
		};
		IEnumerable<Procedure> f_ = context.Operators.Where<Procedure>(d_, e_);
		bool? g_ = context.Operators.Exists<Procedure>(f_);

		return g_;
	}

    [CqlDeclaration("Has Heart Transplant")]
	public bool? Has_Heart_Transplant() => 
		__Has_Heart_Transplant.Value;

    [CqlDeclaration("isOrderedDuringHeartFailureOutpatientEncounter")]
	public bool? isOrderedDuringHeartFailureOutpatientEncounter(MedicationRequest Order)
	{
		IEnumerable<Encounter> a_ = this.Heart_Failure_Outpatient_Encounter_with_History_of_Moderate_or_Severe_LVSD();
		bool? b_(Encounter ModerateOrSevereLVSDHFOutpatientEncounter)
		{
			CqlDateTime e_ = context.Operators.Convert<CqlDateTime>(Order?.AuthoredOnElement);
			CqlInterval<CqlDateTime> f_ = FHIRHelpers_4_3_000.ToInterval(ModerateOrSevereLVSDHFOutpatientEncounter?.Period);
			bool? g_ = context.Operators.In<CqlDateTime>(e_, f_, "day");
			string h_ = context.Operators.Convert<string>(Order?.StatusElement?.Value);
			string[] i_ = new string[]
			{
				"active",
				"completed",
			};
			bool? j_ = context.Operators.In<string>(h_, (i_ as IEnumerable<string>));
			bool? k_ = context.Operators.And(g_, j_);
			string l_ = context.Operators.Convert<string>(Order?.IntentElement?.Value);
			string[] m_ = new string[]
			{
				"order",
				"original-order",
				"reflex-order",
				"filler-order",
				"instance-order",
			};
			bool? n_ = context.Operators.In<string>(l_, (m_ as IEnumerable<string>));
			bool? o_ = context.Operators.And(k_, n_);
			bool? p_ = context.Operators.IsTrue(Order?.DoNotPerformElement?.Value);
			bool? q_ = context.Operators.Not(p_);
			bool? r_ = context.Operators.And(o_, q_);

			return r_;
		};
		IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);
		bool? d_ = context.Operators.Exists<Encounter>(c_);

		return d_;
	}

    [CqlDeclaration("overlapsHeartFailureOutpatientEncounter")]
	public bool? overlapsHeartFailureOutpatientEncounter(Condition Diagnosis)
	{
		IEnumerable<Encounter> a_ = this.Heart_Failure_Outpatient_Encounter_with_History_of_Moderate_or_Severe_LVSD();
		bool? b_(Encounter ModerateOrSevereLVSDHFOutpatientEncounter)
		{
			CqlInterval<CqlDateTime> e_ = QICoreCommon_2_0_000.prevalenceInterval(Diagnosis);
			CqlInterval<CqlDateTime> f_ = FHIRHelpers_4_3_000.ToInterval(ModerateOrSevereLVSDHFOutpatientEncounter?.Period);
			bool? g_ = context.Operators.Overlaps(e_, f_, "day");
			bool? h_ = this.isConfirmedActiveDiagnosis(Diagnosis);
			bool? i_ = context.Operators.And(g_, h_);

			return i_;
		};
		IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);
		bool? d_ = context.Operators.Exists<Encounter>(c_);

		return d_;
	}

    [CqlDeclaration("overlapsAfterHeartFailureOutpatientEncounter")]
	public bool? overlapsAfterHeartFailureOutpatientEncounter(object Event)
	{
		IEnumerable<Encounter> a_ = this.Heart_Failure_Outpatient_Encounter_with_History_of_Moderate_or_Severe_LVSD();
		bool? b_(Encounter ModerateOrSevereLVSDHFOutpatientEncounter)
		{
			bool? e_()
			{
				if (Event is Condition)
				{
					CqlInterval<CqlDateTime> f_ = QICoreCommon_2_0_000.prevalenceInterval((Event as Condition));
					CqlInterval<CqlDateTime> g_ = FHIRHelpers_4_3_000.ToInterval(ModerateOrSevereLVSDHFOutpatientEncounter?.Period);
					bool? h_ = context.Operators.OverlapsAfter(f_, g_, "day");
					bool? i_ = this.isConfirmedActiveDiagnosis((Event as Condition));
					bool? j_ = context.Operators.And(h_, i_);

					return j_;
				}
				else if (Event is Procedure)
				{
					object k_ = FHIRHelpers_4_3_000.ToValue((Event as Procedure)?.Performed);
					CqlInterval<CqlDateTime> l_ = QICoreCommon_2_0_000.toInterval(k_);
					CqlInterval<CqlDateTime> m_ = FHIRHelpers_4_3_000.ToInterval(ModerateOrSevereLVSDHFOutpatientEncounter?.Period);
					bool? n_ = context.Operators.OverlapsAfter(l_, m_, "day");
					string o_ = context.Operators.Convert<string>(((Event as Procedure)?.StatusElement)?.Value);
					bool? p_ = context.Operators.Equal(o_, "completed");
					bool? q_ = context.Operators.And(n_, p_);

					return q_;
				}
				else if (Event is AllergyIntolerance)
				{
					object r_ = FHIRHelpers_4_3_000.ToValue((Event as AllergyIntolerance)?.Onset);
					CqlInterval<CqlDateTime> s_ = QICoreCommon_2_0_000.toInterval(r_);
					CqlDateTime t_ = context.Operators.Start(s_);
					CqlDateTime u_ = context.Operators.Convert<CqlDateTime>((Event as AllergyIntolerance)?.LastOccurrenceElement);
					CqlInterval<CqlDateTime> v_ = context.Operators.Interval(t_, u_, true, true);
					CqlInterval<CqlDateTime> w_ = FHIRHelpers_4_3_000.ToInterval(ModerateOrSevereLVSDHFOutpatientEncounter?.Period);
					bool? x_ = context.Operators.OverlapsAfter(v_, w_, "day");
					CqlConcept y_ = FHIRHelpers_4_3_000.ToConcept((Event as AllergyIntolerance)?.ClinicalStatus);
					CqlCode z_ = QICoreCommon_2_0_000.allergy_active();
					CqlConcept aa_ = context.Operators.ConvertCodeToConcept(z_);
					bool? ab_ = context.Operators.Equivalent(y_, aa_);
					bool? ac_ = context.Operators.And(x_, ab_);
					CqlConcept ad_ = FHIRHelpers_4_3_000.ToConcept((Event as AllergyIntolerance)?.VerificationStatus);
					CqlCode ae_ = QICoreCommon_2_0_000.allergy_unconfirmed();
					CqlConcept af_ = context.Operators.ConvertCodeToConcept(ae_);
					bool? ag_ = context.Operators.Equivalent(ad_, af_);
					CqlCode ai_ = QICoreCommon_2_0_000.allergy_refuted();
					CqlConcept aj_ = context.Operators.ConvertCodeToConcept(ai_);
					bool? ak_ = context.Operators.Equivalent(ad_, aj_);
					bool? al_ = context.Operators.Or(ag_, ak_);
					CqlCode an_ = this.allergy_entered_in_error();
					CqlConcept ao_ = context.Operators.ConvertCodeToConcept(an_);
					bool? ap_ = context.Operators.Equivalent(ad_, ao_);
					bool? aq_ = context.Operators.Or(al_, ap_);
					bool? ar_ = context.Operators.Not(aq_);
					bool? as_ = context.Operators.And(ac_, ar_);

					return as_;
				}
				else if (Event is MedicationRequest)
				{
					object at_ = context.Operators.LateBoundProperty<object>(Event, "dosageInstruction");
					object[] au_ = new object[]
					{
						at_,
					};
					bool? av_(object @this)
					{
						object cg_ = context.Operators.LateBoundProperty<object>(@this, "timing");
						bool? ch_ = context.Operators.Not((bool?)(cg_ is null));

						return ch_;
					};
					IEnumerable<object> aw_ = context.Operators.Where<object>(au_, av_);
					object ax_(object @this)
					{
						object ci_ = context.Operators.LateBoundProperty<object>(@this, "timing");

						return ci_;
					};
					IEnumerable<object> ay_ = context.Operators.Select<object, object>(aw_, ax_);
					object az_ = context.Operators.SingletonFrom<object>(ay_);
					object[] ba_ = new object[]
					{
						az_,
					};
					bool? bb_(object @this)
					{
						object cj_ = context.Operators.LateBoundProperty<object>(@this, "repeat");
						bool? ck_ = context.Operators.Not((bool?)(cj_ is null));

						return ck_;
					};
					IEnumerable<object> bc_ = context.Operators.Where<object>(ba_, bb_);
					object bd_(object @this)
					{
						object cl_ = context.Operators.LateBoundProperty<object>(@this, "repeat");

						return cl_;
					};
					IEnumerable<object> be_ = context.Operators.Select<object, object>(bc_, bd_);
					object bf_ = context.Operators.SingletonFrom<object>(be_);
					object[] bg_ = new object[]
					{
						bf_,
					};
					bool? bh_(object @this)
					{
						object cm_ = context.Operators.LateBoundProperty<object>(@this, "bounds");
						object cn_ = FHIRHelpers_4_3_000.ToValue(cm_);
						bool? co_ = context.Operators.Not((bool?)(cn_ is null));

						return co_;
					};
					IEnumerable<object> bi_ = context.Operators.Where<object>(bg_, bh_);
					object bj_(object @this)
					{
						object cp_ = context.Operators.LateBoundProperty<object>(@this, "bounds");
						object cq_ = FHIRHelpers_4_3_000.ToValue(cp_);

						return cq_;
					};
					IEnumerable<object> bk_ = context.Operators.Select<object, object>(bi_, bj_);
					object bl_ = context.Operators.SingletonFrom<object>(bk_);
					object[] bm_ = new object[]
					{
						bl_,
					};
					CqlInterval<CqlDateTime> bn_(object DoseTime)
					{
						CqlInterval<CqlDateTime> cr_ = QICoreCommon_2_0_000.toInterval(DoseTime);

						return cr_;
					};
					IEnumerable<CqlInterval<CqlDateTime>> bo_ = context.Operators.Select<object, CqlInterval<CqlDateTime>>(bm_, bn_);
					IEnumerable<CqlInterval<CqlDateTime>> bp_ = context.Operators.Collapse(bo_, null);
					object bq_(CqlInterval<CqlDateTime> @this)
					{
						CqlDateTime cs_ = context.Operators.Start(@this);

						return cs_;
					};
					IEnumerable<CqlInterval<CqlDateTime>> br_ = context.Operators.SortBy<CqlInterval<CqlDateTime>>(bp_, bq_, System.ComponentModel.ListSortDirection.Ascending);
					CqlInterval<CqlDateTime> bs_ = context.Operators.First<CqlInterval<CqlDateTime>>(br_);
					CqlInterval<CqlDateTime> bt_ = FHIRHelpers_4_3_000.ToInterval(ModerateOrSevereLVSDHFOutpatientEncounter?.Period);
					bool? bu_ = context.Operators.OverlapsAfter(bs_, bt_, "day");
					string bv_ = context.Operators.Convert<string>(((Event as MedicationRequest)?.StatusElement)?.Value);
					string[] bw_ = new string[]
					{
						"active",
						"completed",
					};
					bool? bx_ = context.Operators.In<string>(bv_, (bw_ as IEnumerable<string>));
					bool? by_ = context.Operators.And(bu_, bx_);
					string bz_ = context.Operators.Convert<string>(((Event as MedicationRequest)?.IntentElement)?.Value);
					string[] ca_ = new string[]
					{
						"order",
						"original-order",
						"reflex-order",
						"filler-order",
						"instance-order",
					};
					bool? cb_ = context.Operators.In<string>(bz_, (ca_ as IEnumerable<string>));
					bool? cc_ = context.Operators.And(by_, cb_);
					bool? cd_ = context.Operators.IsTrue(((Event as MedicationRequest)?.DoNotPerformElement)?.Value);
					bool? ce_ = context.Operators.Not(cd_);
					bool? cf_ = context.Operators.And(cc_, ce_);

					return cf_;
				}
				else if (Event is Observation)
				{
					object ct_ = FHIRHelpers_4_3_000.ToValue((Event as Observation)?.Effective);
					CqlInterval<CqlDateTime> cu_ = QICoreCommon_2_0_000.toInterval(ct_);
					CqlInterval<CqlDateTime> cv_ = FHIRHelpers_4_3_000.ToInterval(ModerateOrSevereLVSDHFOutpatientEncounter?.Period);
					bool? cw_ = context.Operators.OverlapsAfter(cu_, cv_, "day");
					string cx_ = context.Operators.Convert<string>(((Event as Observation)?.StatusElement)?.Value);
					string[] cy_ = new string[]
					{
						"final",
						"amended",
						"corrected",
					};
					bool? cz_ = context.Operators.In<string>(cx_, (cy_ as IEnumerable<string>));
					bool? da_ = context.Operators.And(cw_, cz_);

					return da_;
				}
				else
				{
					return false;
				};
			};

			return e_();
		};
		IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);
		bool? d_ = context.Operators.Exists<Encounter>(c_);

		return d_;
	}

}
