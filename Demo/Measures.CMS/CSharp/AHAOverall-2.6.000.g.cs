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
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1014", default);

    [CqlDeclaration("Care Services in Long Term Residential Facility")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1014")]
	public CqlValueSet Care_Services_in_Long_Term_Residential_Facility() => 
		__Care_Services_in_Long_Term_Residential_Facility.Value;

	private CqlValueSet Ejection_Fraction_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1134", default);

    [CqlDeclaration("Ejection Fraction")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1134")]
	public CqlValueSet Ejection_Fraction() => 
		__Ejection_Fraction.Value;

	private CqlValueSet Heart_Failure_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.376", default);

    [CqlDeclaration("Heart Failure")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.376")]
	public CqlValueSet Heart_Failure() => 
		__Heart_Failure.Value;

	private CqlValueSet Heart_Transplant_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1178.33", default);

    [CqlDeclaration("Heart Transplant")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1178.33")]
	public CqlValueSet Heart_Transplant() => 
		__Heart_Transplant.Value;

	private CqlValueSet Heart_Transplant_Complications_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1178.56", default);

    [CqlDeclaration("Heart Transplant Complications")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1178.56")]
	public CqlValueSet Heart_Transplant_Complications() => 
		__Heart_Transplant_Complications.Value;

	private CqlValueSet Home_Healthcare_Services_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1016", default);

    [CqlDeclaration("Home Healthcare Services")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1016")]
	public CqlValueSet Home_Healthcare_Services() => 
		__Home_Healthcare_Services.Value;

	private CqlValueSet Left_Ventricular_Assist_Device_Complications_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1178.58", default);

    [CqlDeclaration("Left Ventricular Assist Device Complications")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1178.58")]
	public CqlValueSet Left_Ventricular_Assist_Device_Complications() => 
		__Left_Ventricular_Assist_Device_Complications.Value;

	private CqlValueSet Left_Ventricular_Assist_Device_Placement_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1178.61", default);

    [CqlDeclaration("Left Ventricular Assist Device Placement")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1178.61")]
	public CqlValueSet Left_Ventricular_Assist_Device_Placement() => 
		__Left_Ventricular_Assist_Device_Placement.Value;

	private CqlValueSet Moderate_or_Severe_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1092", default);

    [CqlDeclaration("Moderate or Severe")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1092")]
	public CqlValueSet Moderate_or_Severe() => 
		__Moderate_or_Severe.Value;

	private CqlValueSet Moderate_or_Severe_LVSD_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1090", default);

    [CqlDeclaration("Moderate or Severe LVSD")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1090")]
	public CqlValueSet Moderate_or_Severe_LVSD() => 
		__Moderate_or_Severe_LVSD.Value;

	private CqlValueSet Nursing_Facility_Visit_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1012", default);

    [CqlDeclaration("Nursing Facility Visit")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1012")]
	public CqlValueSet Nursing_Facility_Visit() => 
		__Nursing_Facility_Visit.Value;

	private CqlValueSet Office_Visit_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1001", default);

    [CqlDeclaration("Office Visit")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1001")]
	public CqlValueSet Office_Visit() => 
		__Office_Visit.Value;

	private CqlValueSet Outpatient_Consultation_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1008", default);

    [CqlDeclaration("Outpatient Consultation")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1008")]
	public CqlValueSet Outpatient_Consultation() => 
		__Outpatient_Consultation.Value;

	private CqlValueSet Patient_Provider_Interaction_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1012", default);

    [CqlDeclaration("Patient Provider Interaction")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1012")]
	public CqlValueSet Patient_Provider_Interaction() => 
		__Patient_Provider_Interaction.Value;

	private CqlCode Left_ventricular_systolic_dysfunction__disorder__Value() => 
		new CqlCode("134401001", "http://snomed.info/sct", default, default);

    [CqlDeclaration("Left ventricular systolic dysfunction (disorder)")]
	public CqlCode Left_ventricular_systolic_dysfunction__disorder_() => 
		__Left_ventricular_systolic_dysfunction__disorder_.Value;

	private CqlCode allergy_entered_in_error_Value() => 
		new CqlCode("entered-in-error", "http://terminology.hl7.org/CodeSystem/allergyintolerance-verification", default, default);

    [CqlDeclaration("allergy-entered-in-error")]
	public CqlCode allergy_entered_in_error() => 
		__allergy_entered_in_error.Value;

	private CqlCode[] SNOMEDCT_Value()
	{
		CqlCode[] a_ = [
			new CqlCode("134401001", "http://snomed.info/sct", default, default),
		];

		return a_;
	}

    [CqlDeclaration("SNOMEDCT")]
	public CqlCode[] SNOMEDCT() => 
		__SNOMEDCT.Value;

	private CqlCode[] AllergyIntoleranceVerificationStatusCodes_Value()
	{
		CqlCode[] a_ = [
			new CqlCode("entered-in-error", "http://terminology.hl7.org/CodeSystem/allergyintolerance-verification", default, default),
		];

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
		IEnumerable<Patient> a_ = context.Operators.RetrieveByValueSet<Patient>(default, default);
		Patient b_ = context.Operators.SingletonFrom<Patient>(a_);

		return b_;
	}

    [CqlDeclaration("Patient")]
	public Patient Patient() => 
		__Patient.Value;

    [CqlDeclaration("isConfirmedActiveDiagnosis")]
	public bool? isConfirmedActiveDiagnosis(Condition Condition)
	{
		Condition[] a_ = [
			Condition,
		];
		bool? b_(Condition Diagnosis)
		{
			CodeableConcept f_ = Diagnosis?.ClinicalStatus;
			CqlConcept g_ = FHIRHelpers_4_3_000.ToConcept(f_);
			CqlCode h_ = QICoreCommon_2_0_000.active();
			CqlConcept i_ = context.Operators.ConvertCodeToConcept(h_);
			bool? j_ = context.Operators.Equivalent(g_, i_);
			CodeableConcept k_ = Diagnosis?.VerificationStatus;
			CqlConcept l_ = FHIRHelpers_4_3_000.ToConcept(k_);
			CqlCode m_ = QICoreCommon_2_0_000.unconfirmed();
			CqlConcept n_ = context.Operators.ConvertCodeToConcept(m_);
			bool? o_ = context.Operators.Equivalent(l_, n_);
			CqlConcept q_ = FHIRHelpers_4_3_000.ToConcept(k_);
			CqlCode r_ = QICoreCommon_2_0_000.refuted();
			CqlConcept s_ = context.Operators.ConvertCodeToConcept(r_);
			bool? t_ = context.Operators.Equivalent(q_, s_);
			bool? u_ = context.Operators.Or(o_, t_);
			CqlConcept w_ = FHIRHelpers_4_3_000.ToConcept(k_);
			CqlCode x_ = QICoreCommon_2_0_000.entered_in_error();
			CqlConcept y_ = context.Operators.ConvertCodeToConcept(x_);
			bool? z_ = context.Operators.Equivalent(w_, y_);
			bool? aa_ = context.Operators.Or(u_, z_);
			bool? ab_ = context.Operators.Not(aa_);
			bool? ac_ = context.Operators.And(j_, ab_);

			return ac_;
		};
		IEnumerable<Condition> c_ = context.Operators.Where<Condition>((IEnumerable<Condition>)a_, b_);
		Condition d_ = context.Operators.SingletonFrom<Condition>(c_);
		bool? e_ = context.Operators.Not((bool?)(d_ is null));

		return e_;
	}

    [CqlDeclaration("isFinished")]
	public bool? isFinished(Encounter Visit)
	{
		Code<Encounter.EncounterStatus> a_ = Visit?.StatusElement;
		Encounter.EncounterStatus? b_ = a_?.Value;
		Code<Encounter.EncounterStatus> c_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(b_);
		bool? d_ = context.Operators.Equal(c_, "finished");

		return d_;
	}

	private IEnumerable<Encounter> Heart_Failure_Outpatient_Encounter_Value()
	{
		CqlValueSet a_ = this.Care_Services_in_Long_Term_Residential_Facility();
		IEnumerable<Encounter> b_ = context.Operators.RetrieveByValueSet<Encounter>(a_, default);
		CqlValueSet c_ = this.Home_Healthcare_Services();
		IEnumerable<Encounter> d_ = context.Operators.RetrieveByValueSet<Encounter>(c_, default);
		IEnumerable<Encounter> e_ = context.Operators.Union<Encounter>(b_, d_);
		CqlValueSet f_ = this.Nursing_Facility_Visit();
		IEnumerable<Encounter> g_ = context.Operators.RetrieveByValueSet<Encounter>(f_, default);
		CqlValueSet h_ = this.Office_Visit();
		IEnumerable<Encounter> i_ = context.Operators.RetrieveByValueSet<Encounter>(h_, default);
		IEnumerable<Encounter> j_ = context.Operators.Union<Encounter>(g_, i_);
		IEnumerable<Encounter> k_ = context.Operators.Union<Encounter>(e_, j_);
		CqlValueSet l_ = this.Outpatient_Consultation();
		IEnumerable<Encounter> m_ = context.Operators.RetrieveByValueSet<Encounter>(l_, default);
		IEnumerable<Encounter> n_ = context.Operators.Union<Encounter>(k_, m_);
		IEnumerable<Encounter> o_(Encounter QualifyingEncounter)
		{
			CqlValueSet s_ = this.Heart_Failure();
			IEnumerable<Condition> t_ = context.Operators.RetrieveByValueSet<Condition>(s_, default);
			bool? u_(Condition HeartFailure)
			{
				CqlInterval<CqlDateTime> y_ = QICoreCommon_2_0_000.prevalenceInterval(HeartFailure);
				Period z_ = QualifyingEncounter?.Period;
				CqlInterval<CqlDateTime> aa_ = FHIRHelpers_4_3_000.ToInterval(z_);
				bool? ab_ = context.Operators.Overlaps(y_, aa_, default);
				bool? ac_ = this.isConfirmedActiveDiagnosis(HeartFailure);
				bool? ad_ = context.Operators.And(ab_, ac_);

				return ad_;
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
			CqlInterval<CqlDateTime> ae_ = this.Measurement_Period();
			Period af_ = QualifyingEncounter?.Period;
			CqlInterval<CqlDateTime> ag_ = FHIRHelpers_4_3_000.ToInterval(af_);
			bool? ah_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(ae_, ag_, default);
			bool? ai_ = this.isFinished(QualifyingEncounter);
			bool? aj_ = context.Operators.And(ah_, ai_);

			return aj_;
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
		IEnumerable<Observation> b_ = context.Operators.RetrieveByValueSet<Observation>(a_, default);
		bool? c_(Observation EjectionFraction)
		{
			DataType n_ = EjectionFraction?.Value;
			object o_ = FHIRHelpers_4_3_000.ToValue(n_);
			CqlQuantity p_ = o_ switch { null => null , CqlQuantity a => a/* , CqlConcept => ???, bool => ???, CqlInterval<CqlQuantity> => ???, CqlRatio => ???, SampledData => ???, CqlTime => ???, CqlDateTime => ???, CqlInterval<CqlDateTime> => ??? */, _ => throw new System.Diagnostics.UnreachableException() };
			CqlQuantity q_ = context.Operators.Quantity(40m, "%");
			bool? r_ = context.Operators.LessOrEqual(p_, q_);
			Code<ObservationStatus> s_ = EjectionFraction?.StatusElement;
			ObservationStatus? t_ = s_?.Value;
			Code<ObservationStatus> u_ = context.Operators.Convert<Code<ObservationStatus>>(t_);
			string v_ = context.Operators.Convert<string>(u_);
			string[] w_ = [
				"final",
				"amended",
				"corrected",
			];
			bool? x_ = context.Operators.In<string>(v_, w_ as IEnumerable<string>);
			bool? y_ = context.Operators.And(r_, x_);

			return y_;
		};
		IEnumerable<Observation> d_ = context.Operators.Where<Observation>(b_, c_);
		CqlValueSet e_ = this.Moderate_or_Severe_LVSD();
		IEnumerable<Condition> f_ = context.Operators.RetrieveByValueSet<Condition>(e_, default);
		IEnumerable<object> g_ = context.Operators.Union<object>(d_ as IEnumerable<object>, f_ as IEnumerable<object>);
		CqlCode h_ = this.Left_ventricular_systolic_dysfunction__disorder_();
		IEnumerable<CqlCode> i_ = context.Operators.ToList<CqlCode>(h_);
		IEnumerable<Condition> j_ = context.Operators.RetrieveByCodes<Condition>(i_, default);
		bool? k_(Condition LVSDDiagnosis)
		{
			CodeableConcept z_ = LVSDDiagnosis?.Severity;
			CqlConcept aa_ = FHIRHelpers_4_3_000.ToConcept(z_);
			CqlValueSet ab_ = this.Moderate_or_Severe();
			bool? ac_ = context.Operators.ConceptInValueSet(aa_, ab_);

			return ac_;
		};
		IEnumerable<Condition> l_ = context.Operators.Where<Condition>(j_, k_);
		IEnumerable<object> m_ = context.Operators.Union<object>(g_ as IEnumerable<object>, l_ as IEnumerable<object>);

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
				Condition i_ = LVSDFindings switch { null => null , Condition a => a/* , Observation => ??? */, _ => throw new System.Diagnostics.UnreachableException() };
				CqlInterval<CqlDateTime> j_ = QICoreCommon_2_0_000.prevalenceInterval(i_);
				object k_ = context.Operators.LateBoundProperty<object>(LVSDFindings, "effective");
				object l_ = FHIRHelpers_4_3_000.ToValue(k_);
				CqlInterval<CqlDateTime> m_ = QICoreCommon_2_0_000.toInterval(l_);
				CqlDateTime n_ = context.Operators.Start(j_ ?? m_);
				Period o_ = HFOutpatientEncounter?.Period;
				CqlInterval<CqlDateTime> p_ = FHIRHelpers_4_3_000.ToInterval(o_);
				CqlDateTime q_ = context.Operators.End(p_);
				bool? r_ = context.Operators.Before(n_, q_, default);

				return r_;
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
		IEnumerable<Condition> b_ = context.Operators.RetrieveByValueSet<Condition>(a_, default);
		IEnumerable<Condition> c_(Condition HeartTransplantComplications)
		{
			IEnumerable<Encounter> h_ = this.Heart_Failure_Outpatient_Encounter_with_History_of_Moderate_or_Severe_LVSD();
			bool? i_(Encounter ModerateOrSevereLVSDHFOutpatientEncounter)
			{
				FhirDateTime m_ = HeartTransplantComplications?.RecordedDateElement;
				CqlDateTime n_ = context.Operators.Convert<CqlDateTime>(m_);
				CqlInterval<CqlDateTime> o_ = QICoreCommon_2_0_000.toInterval(n_ as object);
				CqlInterval<CqlDateTime> p_ = QICoreCommon_2_0_000.prevalenceInterval(HeartTransplantComplications);
				CqlDateTime q_ = context.Operators.Start(o_ ?? p_);
				Period r_ = ModerateOrSevereLVSDHFOutpatientEncounter?.Period;
				CqlInterval<CqlDateTime> s_ = FHIRHelpers_4_3_000.ToInterval(r_);
				CqlDateTime t_ = context.Operators.End(s_);
				bool? u_ = context.Operators.Before(q_, t_, default);

				return u_;
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
			bool? v_ = this.isConfirmedActiveDiagnosis(HeartTransplantComplications);

			return v_;
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
		IEnumerable<Procedure> b_ = context.Operators.RetrieveByValueSet<Procedure>(a_, default);
		IEnumerable<Procedure> c_(Procedure LVADOutpatient)
		{
			IEnumerable<Encounter> h_ = this.Heart_Failure_Outpatient_Encounter_with_History_of_Moderate_or_Severe_LVSD();
			bool? i_(Encounter ModerateOrSevereLVSDHFOutpatientEncounter)
			{
				DataType m_ = LVADOutpatient?.Performed;
				object n_ = FHIRHelpers_4_3_000.ToValue(m_);
				CqlInterval<CqlDateTime> o_ = QICoreCommon_2_0_000.toInterval(n_);
				CqlDateTime p_ = context.Operators.Start(o_);
				Period q_ = ModerateOrSevereLVSDHFOutpatientEncounter?.Period;
				CqlInterval<CqlDateTime> r_ = FHIRHelpers_4_3_000.ToInterval(q_);
				CqlDateTime s_ = context.Operators.End(r_);
				bool? t_ = context.Operators.Before(p_, s_, default);

				return t_;
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
			Code<EventStatus> u_ = LVADOutpatient?.StatusElement;
			EventStatus? v_ = u_?.Value;
			string w_ = context.Operators.Convert<string>(v_);
			bool? x_ = context.Operators.Equal(w_, "completed");

			return x_;
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
		IEnumerable<Condition> b_ = context.Operators.RetrieveByValueSet<Condition>(a_, default);
		IEnumerable<Condition> c_(Condition LVADComplications)
		{
			IEnumerable<Encounter> h_ = this.Heart_Failure_Outpatient_Encounter_with_History_of_Moderate_or_Severe_LVSD();
			bool? i_(Encounter ModerateOrSevereLVSDHFOutpatientEncounter)
			{
				FhirDateTime m_ = LVADComplications?.RecordedDateElement;
				CqlDateTime n_ = context.Operators.Convert<CqlDateTime>(m_);
				CqlInterval<CqlDateTime> o_ = QICoreCommon_2_0_000.toInterval(n_ as object);
				CqlInterval<CqlDateTime> p_ = QICoreCommon_2_0_000.prevalenceInterval(LVADComplications);
				CqlDateTime q_ = context.Operators.Start(o_ ?? p_);
				Period r_ = ModerateOrSevereLVSDHFOutpatientEncounter?.Period;
				CqlInterval<CqlDateTime> s_ = FHIRHelpers_4_3_000.ToInterval(r_);
				CqlDateTime t_ = context.Operators.End(s_);
				bool? u_ = context.Operators.Before(q_, t_, default);

				return u_;
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
			bool? v_ = this.isConfirmedActiveDiagnosis(LVADComplications);

			return v_;
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
		IEnumerable<Encounter> b_ = context.Operators.RetrieveByValueSet<Encounter>(a_, default);
		CqlValueSet c_ = this.Home_Healthcare_Services();
		IEnumerable<Encounter> d_ = context.Operators.RetrieveByValueSet<Encounter>(c_, default);
		IEnumerable<Encounter> e_ = context.Operators.Union<Encounter>(b_, d_);
		CqlValueSet f_ = this.Nursing_Facility_Visit();
		IEnumerable<Encounter> g_ = context.Operators.RetrieveByValueSet<Encounter>(f_, default);
		CqlValueSet h_ = this.Office_Visit();
		IEnumerable<Encounter> i_ = context.Operators.RetrieveByValueSet<Encounter>(h_, default);
		IEnumerable<Encounter> j_ = context.Operators.Union<Encounter>(g_, i_);
		IEnumerable<Encounter> k_ = context.Operators.Union<Encounter>(e_, j_);
		CqlValueSet l_ = this.Outpatient_Consultation();
		IEnumerable<Encounter> m_ = context.Operators.RetrieveByValueSet<Encounter>(l_, default);
		CqlValueSet n_ = this.Patient_Provider_Interaction();
		IEnumerable<Encounter> o_ = context.Operators.RetrieveByValueSet<Encounter>(n_, default);
		IEnumerable<Encounter> p_ = context.Operators.Union<Encounter>(m_, o_);
		IEnumerable<Encounter> q_ = context.Operators.Union<Encounter>(k_, p_);
		bool? r_(Encounter ValidEncounter)
		{
			CqlInterval<CqlDateTime> t_ = this.Measurement_Period();
			Period u_ = ValidEncounter?.Period;
			CqlInterval<CqlDateTime> v_ = FHIRHelpers_4_3_000.ToInterval(u_);
			bool? w_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(t_, v_, default);
			bool? x_ = this.isFinished(ValidEncounter);
			bool? y_ = context.Operators.And(w_, x_);

			return y_;
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
		Date b_ = a_?.BirthDateElement;
		string c_ = b_?.Value;
		CqlDate d_ = context.Operators.ConvertStringToDate(c_);
		CqlInterval<CqlDateTime> e_ = this.Measurement_Period();
		CqlDateTime f_ = context.Operators.Start(e_);
		CqlDate g_ = context.Operators.DateFrom(f_);
		int? h_ = context.Operators.CalculateAgeAt(d_, g_, "year");
		bool? i_ = context.Operators.GreaterOrEqual(h_, 18);
		IEnumerable<Encounter> j_ = this.Qualifying_Outpatient_Encounter_During_Measurement_Period();
		IEnumerable<Encounter> k_(Encounter Encounter1)
		{
			IEnumerable<Encounter> r_ = this.Qualifying_Outpatient_Encounter_During_Measurement_Period();
			bool? s_(Encounter Encounter2)
			{
				Id w_ = Encounter2?.IdElement;
				string x_ = w_?.Value;
				Id y_ = Encounter1?.IdElement;
				string z_ = y_?.Value;
				bool? aa_ = context.Operators.Equivalent(x_, z_);
				bool? ab_ = context.Operators.Not(aa_);

				return ab_;
			};
			IEnumerable<Encounter> t_ = context.Operators.Where<Encounter>(r_, s_);
			Encounter u_(Encounter Encounter2) => 
				Encounter1;
			IEnumerable<Encounter> v_ = context.Operators.Select<Encounter, Encounter>(t_, u_);

			return v_;
		};
		IEnumerable<Encounter> l_ = context.Operators.SelectMany<Encounter, Encounter>(j_, k_);
		bool? m_ = context.Operators.Exists<Encounter>(l_);
		bool? n_ = context.Operators.And(i_, m_);
		IEnumerable<Encounter> o_ = this.Heart_Failure_Outpatient_Encounter();
		bool? p_ = context.Operators.Exists<Encounter>(o_);
		bool? q_ = context.Operators.And(n_, p_);

		return q_;
	}

    [CqlDeclaration("Has Two Qualifying Outpatient Encounters and Heart Failure Outpatient Encounter During the Measurement Period")]
	public bool? Has_Two_Qualifying_Outpatient_Encounters_and_Heart_Failure_Outpatient_Encounter_During_the_Measurement_Period() => 
		__Has_Two_Qualifying_Outpatient_Encounters_and_Heart_Failure_Outpatient_Encounter_During_the_Measurement_Period.Value;

	private bool? Has_Heart_Transplant_Value()
	{
		CqlValueSet a_ = this.Heart_Transplant();
		IEnumerable<Procedure> b_ = context.Operators.RetrieveByValueSet<Procedure>(a_, default);
		IEnumerable<Procedure> c_(Procedure HeartTransplant)
		{
			IEnumerable<Encounter> h_ = this.Heart_Failure_Outpatient_Encounter_with_History_of_Moderate_or_Severe_LVSD();
			bool? i_(Encounter ModerateOrSevereLVSDHFOutpatientEncounter)
			{
				DataType m_ = HeartTransplant?.Performed;
				object n_ = FHIRHelpers_4_3_000.ToValue(m_);
				CqlInterval<CqlDateTime> o_ = QICoreCommon_2_0_000.toInterval(n_);
				CqlDateTime p_ = context.Operators.Start(o_);
				Period q_ = ModerateOrSevereLVSDHFOutpatientEncounter?.Period;
				CqlInterval<CqlDateTime> r_ = FHIRHelpers_4_3_000.ToInterval(q_);
				CqlDateTime s_ = context.Operators.End(r_);
				bool? t_ = context.Operators.Before(p_, s_, default);

				return t_;
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
			Code<EventStatus> u_ = HeartTransplant?.StatusElement;
			EventStatus? v_ = u_?.Value;
			string w_ = context.Operators.Convert<string>(v_);
			bool? x_ = context.Operators.Equal(w_, "completed");

			return x_;
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
			FhirDateTime e_ = Order?.AuthoredOnElement;
			CqlDateTime f_ = context.Operators.Convert<CqlDateTime>(e_);
			Period g_ = ModerateOrSevereLVSDHFOutpatientEncounter?.Period;
			CqlInterval<CqlDateTime> h_ = FHIRHelpers_4_3_000.ToInterval(g_);
			bool? i_ = context.Operators.In<CqlDateTime>(f_, h_, "day");
			Code<MedicationRequest.MedicationrequestStatus> j_ = Order?.StatusElement;
			MedicationRequest.MedicationrequestStatus? k_ = j_?.Value;
			string l_ = context.Operators.Convert<string>(k_);
			string[] m_ = [
				"active",
				"completed",
			];
			bool? n_ = context.Operators.In<string>(l_, m_ as IEnumerable<string>);
			bool? o_ = context.Operators.And(i_, n_);
			Code<MedicationRequest.MedicationRequestIntent> p_ = Order?.IntentElement;
			MedicationRequest.MedicationRequestIntent? q_ = p_?.Value;
			string r_ = context.Operators.Convert<string>(q_);
			string[] s_ = [
				"order",
				"original-order",
				"reflex-order",
				"filler-order",
				"instance-order",
			];
			bool? t_ = context.Operators.In<string>(r_, s_ as IEnumerable<string>);
			bool? u_ = context.Operators.And(o_, t_);
			FhirBoolean v_ = Order?.DoNotPerformElement;
			bool? w_ = v_?.Value;
			bool? x_ = context.Operators.IsTrue(w_);
			bool? y_ = context.Operators.Not(x_);
			bool? z_ = context.Operators.And(u_, y_);

			return z_;
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
			Period f_ = ModerateOrSevereLVSDHFOutpatientEncounter?.Period;
			CqlInterval<CqlDateTime> g_ = FHIRHelpers_4_3_000.ToInterval(f_);
			bool? h_ = context.Operators.Overlaps(e_, g_, "day");
			bool? i_ = this.isConfirmedActiveDiagnosis(Diagnosis);
			bool? j_ = context.Operators.And(h_, i_);

			return j_;
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
					Condition f_ = Event switch { null => null , Condition a => a/* , Procedure => ???, AllergyIntolerance => ???, MedicationRequest => ???, Observation => ??? */, _ => throw new System.Diagnostics.UnreachableException() };
					CqlInterval<CqlDateTime> g_ = QICoreCommon_2_0_000.prevalenceInterval(f_);
					Period h_ = ModerateOrSevereLVSDHFOutpatientEncounter?.Period;
					CqlInterval<CqlDateTime> i_ = FHIRHelpers_4_3_000.ToInterval(h_);
					bool? j_ = context.Operators.OverlapsAfter(g_, i_, "day");
					bool? l_ = this.isConfirmedActiveDiagnosis(f_);
					bool? m_ = context.Operators.And(j_, l_);

					return m_;
				}
				else if (Event is Procedure)
				{
					Procedure n_ = Event switch { null => null , Procedure b => b/* , Condition => ???, AllergyIntolerance => ???, MedicationRequest => ???, Observation => ??? */, _ => throw new System.Diagnostics.UnreachableException() };
					DataType o_ = n_?.Performed;
					object p_ = FHIRHelpers_4_3_000.ToValue(o_);
					CqlInterval<CqlDateTime> q_ = QICoreCommon_2_0_000.toInterval(p_);
					Period r_ = ModerateOrSevereLVSDHFOutpatientEncounter?.Period;
					CqlInterval<CqlDateTime> s_ = FHIRHelpers_4_3_000.ToInterval(r_);
					bool? t_ = context.Operators.OverlapsAfter(q_, s_, "day");
					Code<EventStatus> v_ = n_?.StatusElement;
					EventStatus? w_ = v_?.Value;
					string x_ = context.Operators.Convert<string>(w_);
					bool? y_ = context.Operators.Equal(x_, "completed");
					bool? z_ = context.Operators.And(t_, y_);

					return z_;
				}
				else if (Event is AllergyIntolerance)
				{
					AllergyIntolerance aa_ = Event switch { null => null , AllergyIntolerance c => c/* , Condition => ???, Procedure => ???, MedicationRequest => ???, Observation => ??? */, _ => throw new System.Diagnostics.UnreachableException() };
					DataType ab_ = aa_?.Onset;
					object ac_ = FHIRHelpers_4_3_000.ToValue(ab_);
					CqlInterval<CqlDateTime> ad_ = QICoreCommon_2_0_000.toInterval(ac_);
					CqlDateTime ae_ = context.Operators.Start(ad_);
					FhirDateTime ag_ = aa_?.LastOccurrenceElement;
					CqlDateTime ah_ = context.Operators.Convert<CqlDateTime>(ag_);
					CqlInterval<CqlDateTime> ai_ = context.Operators.Interval(ae_, ah_, true, true);
					Period aj_ = ModerateOrSevereLVSDHFOutpatientEncounter?.Period;
					CqlInterval<CqlDateTime> ak_ = FHIRHelpers_4_3_000.ToInterval(aj_);
					bool? al_ = context.Operators.OverlapsAfter(ai_, ak_, "day");
					CodeableConcept an_ = aa_?.ClinicalStatus;
					CqlConcept ao_ = FHIRHelpers_4_3_000.ToConcept(an_);
					CqlCode ap_ = QICoreCommon_2_0_000.allergy_active();
					CqlConcept aq_ = context.Operators.ConvertCodeToConcept(ap_);
					bool? ar_ = context.Operators.Equivalent(ao_, aq_);
					bool? as_ = context.Operators.And(al_, ar_);
					CodeableConcept au_ = aa_?.VerificationStatus;
					CqlConcept av_ = FHIRHelpers_4_3_000.ToConcept(au_);
					CqlCode aw_ = QICoreCommon_2_0_000.allergy_unconfirmed();
					CqlConcept ax_ = context.Operators.ConvertCodeToConcept(aw_);
					bool? ay_ = context.Operators.Equivalent(av_, ax_);
					CodeableConcept ba_ = aa_?.VerificationStatus;
					CqlConcept bb_ = FHIRHelpers_4_3_000.ToConcept(ba_);
					CqlCode bc_ = QICoreCommon_2_0_000.allergy_refuted();
					CqlConcept bd_ = context.Operators.ConvertCodeToConcept(bc_);
					bool? be_ = context.Operators.Equivalent(bb_, bd_);
					bool? bf_ = context.Operators.Or(ay_, be_);
					CodeableConcept bh_ = aa_?.VerificationStatus;
					CqlConcept bi_ = FHIRHelpers_4_3_000.ToConcept(bh_);
					CqlCode bj_ = this.allergy_entered_in_error();
					CqlConcept bk_ = context.Operators.ConvertCodeToConcept(bj_);
					bool? bl_ = context.Operators.Equivalent(bi_, bk_);
					bool? bm_ = context.Operators.Or(bf_, bl_);
					bool? bn_ = context.Operators.Not(bm_);
					bool? bo_ = context.Operators.And(as_, bn_);

					return bo_;
				}
				else if (Event is MedicationRequest)
				{
					object bp_ = context.Operators.LateBoundProperty<object>(Event, "dosageInstruction");
					object[] bq_ = [
						bp_,
					];
					bool? br_(object @this)
					{
						object dm_ = context.Operators.LateBoundProperty<object>(@this, "timing");
						bool? dn_ = context.Operators.Not((bool?)(dm_ is null));

						return dn_;
					};
					IEnumerable<object> bs_ = context.Operators.Where<object>((IEnumerable<object>)bq_, br_);
					object bt_(object @this)
					{
						object do_ = context.Operators.LateBoundProperty<object>(@this, "timing");

						return do_;
					};
					IEnumerable<object> bu_ = context.Operators.Select<object, object>(bs_, bt_);
					object bv_ = context.Operators.SingletonFrom<object>(bu_);
					object[] bw_ = [
						bv_,
					];
					bool? bx_(object @this)
					{
						object dp_ = context.Operators.LateBoundProperty<object>(@this, "repeat");
						bool? dq_ = context.Operators.Not((bool?)(dp_ is null));

						return dq_;
					};
					IEnumerable<object> by_ = context.Operators.Where<object>((IEnumerable<object>)bw_, bx_);
					object bz_(object @this)
					{
						object dr_ = context.Operators.LateBoundProperty<object>(@this, "repeat");

						return dr_;
					};
					IEnumerable<object> ca_ = context.Operators.Select<object, object>(by_, bz_);
					object cb_ = context.Operators.SingletonFrom<object>(ca_);
					object[] cc_ = [
						cb_,
					];
					bool? cd_(object @this)
					{
						object ds_ = context.Operators.LateBoundProperty<object>(@this, "bounds");
						object dt_ = FHIRHelpers_4_3_000.ToValue(ds_);
						bool? du_ = context.Operators.Not((bool?)(dt_ is null));

						return du_;
					};
					IEnumerable<object> ce_ = context.Operators.Where<object>((IEnumerable<object>)cc_, cd_);
					object cf_(object @this)
					{
						object dv_ = context.Operators.LateBoundProperty<object>(@this, "bounds");
						object dw_ = FHIRHelpers_4_3_000.ToValue(dv_);

						return dw_;
					};
					IEnumerable<object> cg_ = context.Operators.Select<object, object>(ce_, cf_);
					object ch_ = context.Operators.SingletonFrom<object>(cg_);
					object[] ci_ = [
						ch_,
					];
					CqlInterval<CqlDateTime> cj_(object DoseTime)
					{
						CqlInterval<CqlDateTime> dx_ = QICoreCommon_2_0_000.toInterval(DoseTime);

						return dx_;
					};
					IEnumerable<CqlInterval<CqlDateTime>> ck_ = context.Operators.Select<object, CqlInterval<CqlDateTime>>((IEnumerable<object>)ci_, cj_);
					IEnumerable<CqlInterval<CqlDateTime>> cl_ = context.Operators.Collapse(ck_, default);
					object cm_(CqlInterval<CqlDateTime> @this)
					{
						CqlDateTime dy_ = context.Operators.Start(@this);

						return dy_;
					};
					IEnumerable<CqlInterval<CqlDateTime>> cn_ = context.Operators.SortBy<CqlInterval<CqlDateTime>>(cl_, cm_, System.ComponentModel.ListSortDirection.Ascending);
					CqlInterval<CqlDateTime> co_ = context.Operators.First<CqlInterval<CqlDateTime>>(cn_);
					Period cp_ = ModerateOrSevereLVSDHFOutpatientEncounter?.Period;
					CqlInterval<CqlDateTime> cq_ = FHIRHelpers_4_3_000.ToInterval(cp_);
					bool? cr_ = context.Operators.OverlapsAfter(co_, cq_, "day");
					MedicationRequest cs_ = Event switch { null => null , MedicationRequest d => d/* , Condition => ???, Procedure => ???, AllergyIntolerance => ???, Observation => ??? */, _ => throw new System.Diagnostics.UnreachableException() };
					Code<MedicationRequest.MedicationrequestStatus> ct_ = cs_?.StatusElement;
					MedicationRequest.MedicationrequestStatus? cu_ = ct_?.Value;
					string cv_ = context.Operators.Convert<string>(cu_);
					string[] cw_ = [
						"active",
						"completed",
					];
					bool? cx_ = context.Operators.In<string>(cv_, cw_ as IEnumerable<string>);
					bool? cy_ = context.Operators.And(cr_, cx_);
					Code<MedicationRequest.MedicationRequestIntent> da_ = cs_?.IntentElement;
					MedicationRequest.MedicationRequestIntent? db_ = da_?.Value;
					string dc_ = context.Operators.Convert<string>(db_);
					string[] dd_ = [
						"order",
						"original-order",
						"reflex-order",
						"filler-order",
						"instance-order",
					];
					bool? de_ = context.Operators.In<string>(dc_, dd_ as IEnumerable<string>);
					bool? df_ = context.Operators.And(cy_, de_);
					FhirBoolean dh_ = cs_?.DoNotPerformElement;
					bool? di_ = dh_?.Value;
					bool? dj_ = context.Operators.IsTrue(di_);
					bool? dk_ = context.Operators.Not(dj_);
					bool? dl_ = context.Operators.And(df_, dk_);

					return dl_;
				}
				else if (Event is Observation)
				{
					Observation dz_ = Event switch { null => null , Observation e => e/* , Condition => ???, Procedure => ???, AllergyIntolerance => ???, MedicationRequest => ??? */, _ => throw new System.Diagnostics.UnreachableException() };
					DataType ea_ = dz_?.Effective;
					object eb_ = FHIRHelpers_4_3_000.ToValue(ea_);
					CqlInterval<CqlDateTime> ec_ = QICoreCommon_2_0_000.toInterval(eb_);
					Period ed_ = ModerateOrSevereLVSDHFOutpatientEncounter?.Period;
					CqlInterval<CqlDateTime> ee_ = FHIRHelpers_4_3_000.ToInterval(ed_);
					bool? ef_ = context.Operators.OverlapsAfter(ec_, ee_, "day");
					Code<ObservationStatus> eh_ = dz_?.StatusElement;
					ObservationStatus? ei_ = eh_?.Value;
					string ej_ = context.Operators.Convert<string>(ei_);
					string[] ek_ = [
						"final",
						"amended",
						"corrected",
					];
					bool? el_ = context.Operators.In<string>(ej_, ek_ as IEnumerable<string>);
					bool? em_ = context.Operators.And(ef_, el_);

					return em_;
				}
				else
				{
					return false;
				}
			};

			return e_();
		};
		IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);
		bool? d_ = context.Operators.Exists<Encounter>(c_);

		return d_;
	}

}
