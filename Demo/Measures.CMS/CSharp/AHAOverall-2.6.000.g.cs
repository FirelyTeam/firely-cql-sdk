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
		var a_ = new CqlCode[]
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
		var a_ = new CqlCode[]
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
		var a_ = context.Operators.DateTime(2025, 1, 1, 0, 0, 0, 0, default);
		var b_ = context.Operators.DateTime(2026, 1, 1, 0, 0, 0, 0, default);
		var c_ = context.Operators.Interval(a_, b_, true, false);
		var d_ = context.ResolveParameter("AHAOverall-2.6.000", "Measurement Period", c_);

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

    [CqlDeclaration("isConfirmedActiveDiagnosis")]
	public bool? isConfirmedActiveDiagnosis(Condition Condition)
	{
		var a_ = new Condition[]
		{
			Condition,
		};
		bool? b_(Condition Diagnosis)
		{
			var f_ = Diagnosis?.ClinicalStatus;
			var g_ = FHIRHelpers_4_3_000.ToConcept(f_);
			var h_ = QICoreCommon_2_0_000.active();
			var i_ = context.Operators.ConvertCodeToConcept(h_);
			var j_ = context.Operators.Equivalent(g_, i_);
			var k_ = Diagnosis?.VerificationStatus;
			var l_ = FHIRHelpers_4_3_000.ToConcept(k_);
			var m_ = QICoreCommon_2_0_000.unconfirmed();
			var n_ = context.Operators.ConvertCodeToConcept(m_);
			var o_ = context.Operators.Equivalent(l_, n_);
			var q_ = FHIRHelpers_4_3_000.ToConcept(k_);
			var r_ = QICoreCommon_2_0_000.refuted();
			var s_ = context.Operators.ConvertCodeToConcept(r_);
			var t_ = context.Operators.Equivalent(q_, s_);
			var u_ = context.Operators.Or(o_, t_);
			var w_ = FHIRHelpers_4_3_000.ToConcept(k_);
			var x_ = QICoreCommon_2_0_000.entered_in_error();
			var y_ = context.Operators.ConvertCodeToConcept(x_);
			var z_ = context.Operators.Equivalent(w_, y_);
			var aa_ = context.Operators.Or(u_, z_);
			var ab_ = context.Operators.Not(aa_);
			var ac_ = context.Operators.And(j_, ab_);

			return ac_;
		};
		var c_ = context.Operators.Where<Condition>((IEnumerable<Condition>)a_, b_);
		var d_ = context.Operators.SingletonFrom<Condition>(c_);
		var e_ = context.Operators.Not((bool?)(d_ is null));

		return e_;
	}

    [CqlDeclaration("isFinished")]
	public bool? isFinished(Encounter Visit)
	{
		var a_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(Visit?.StatusElement?.Value);
		var b_ = context.Operators.Equal(a_, "finished");

		return b_;
	}

	private IEnumerable<Encounter> Heart_Failure_Outpatient_Encounter_Value()
	{
		var a_ = this.Care_Services_in_Long_Term_Residential_Facility();
		var b_ = context.Operators.RetrieveByValueSet<Encounter>(a_, null);
		var c_ = this.Home_Healthcare_Services();
		var d_ = context.Operators.RetrieveByValueSet<Encounter>(c_, null);
		var e_ = context.Operators.Union<Encounter>(b_, d_);
		var f_ = this.Nursing_Facility_Visit();
		var g_ = context.Operators.RetrieveByValueSet<Encounter>(f_, null);
		var h_ = this.Office_Visit();
		var i_ = context.Operators.RetrieveByValueSet<Encounter>(h_, null);
		var j_ = context.Operators.Union<Encounter>(g_, i_);
		var k_ = context.Operators.Union<Encounter>(e_, j_);
		var l_ = this.Outpatient_Consultation();
		var m_ = context.Operators.RetrieveByValueSet<Encounter>(l_, null);
		var n_ = context.Operators.Union<Encounter>(k_, m_);
		IEnumerable<Encounter> o_(Encounter QualifyingEncounter)
		{
			var s_ = this.Heart_Failure();
			var t_ = context.Operators.RetrieveByValueSet<Condition>(s_, null);
			bool? u_(Condition HeartFailure)
			{
				var y_ = QICoreCommon_2_0_000.prevalenceInterval(HeartFailure);
				var z_ = QualifyingEncounter?.Period;
				var aa_ = FHIRHelpers_4_3_000.ToInterval(z_);
				var ab_ = context.Operators.Overlaps(y_, aa_, null);
				var ac_ = this.isConfirmedActiveDiagnosis(HeartFailure);
				var ad_ = context.Operators.And(ab_, ac_);

				return ad_;
			};
			var v_ = context.Operators.Where<Condition>(t_, u_);
			Encounter w_(Condition HeartFailure) => 
				QualifyingEncounter;
			var x_ = context.Operators.Select<Condition, Encounter>(v_, w_);

			return x_;
		};
		var p_ = context.Operators.SelectMany<Encounter, Encounter>(n_, o_);
		bool? q_(Encounter QualifyingEncounter)
		{
			var ae_ = this.Measurement_Period();
			var af_ = QualifyingEncounter?.Period;
			var ag_ = FHIRHelpers_4_3_000.ToInterval(af_);
			var ah_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(ae_, ag_, null);
			var ai_ = this.isFinished(QualifyingEncounter);
			var aj_ = context.Operators.And(ah_, ai_);

			return aj_;
		};
		var r_ = context.Operators.Where<Encounter>(p_, q_);

		return r_;
	}

    [CqlDeclaration("Heart Failure Outpatient Encounter")]
	public IEnumerable<Encounter> Heart_Failure_Outpatient_Encounter() => 
		__Heart_Failure_Outpatient_Encounter.Value;

	private IEnumerable<object> Moderate_or_Severe_LVSD_Findings_Value()
	{
		var a_ = this.Ejection_Fraction();
		var b_ = context.Operators.RetrieveByValueSet<Observation>(a_, null);
		bool? c_(Observation EjectionFraction)
		{
			var n_ = EjectionFraction?.Value;
			var o_ = FHIRHelpers_4_3_000.ToValue(n_);
			var p_ = context.Operators.Quantity(40m, "%");
			var q_ = context.Operators.LessOrEqual((o_ as CqlQuantity), p_);
			var r_ = EjectionFraction?.StatusElement;
			var s_ = r_?.Value;
			var t_ = context.Operators.Convert<Code<ObservationStatus>>(s_);
			var u_ = context.Operators.Convert<string>(t_);
			var v_ = new string[]
			{
				"final",
				"amended",
				"corrected",
			};
			var w_ = context.Operators.In<string>(u_, (v_ as IEnumerable<string>));
			var x_ = context.Operators.And(q_, w_);

			return x_;
		};
		var d_ = context.Operators.Where<Observation>(b_, c_);
		var e_ = this.Moderate_or_Severe_LVSD();
		var f_ = context.Operators.RetrieveByValueSet<Condition>(e_, null);
		var g_ = context.Operators.Union<object>((d_ as IEnumerable<object>), (f_ as IEnumerable<object>));
		var h_ = this.Left_ventricular_systolic_dysfunction__disorder_();
		var i_ = context.Operators.ToList<CqlCode>(h_);
		var j_ = context.Operators.RetrieveByCodes<Condition>(i_, null);
		bool? k_(Condition LVSDDiagnosis)
		{
			var y_ = LVSDDiagnosis?.Severity;
			var z_ = FHIRHelpers_4_3_000.ToConcept(y_);
			var aa_ = this.Moderate_or_Severe();
			var ab_ = context.Operators.ConceptInValueSet(z_, aa_);

			return ab_;
		};
		var l_ = context.Operators.Where<Condition>(j_, k_);
		var m_ = context.Operators.Union<object>((g_ as IEnumerable<object>), (l_ as IEnumerable<object>));

		return m_;
	}

    [CqlDeclaration("Moderate or Severe LVSD Findings")]
	public IEnumerable<object> Moderate_or_Severe_LVSD_Findings() => 
		__Moderate_or_Severe_LVSD_Findings.Value;

	private IEnumerable<Encounter> Heart_Failure_Outpatient_Encounter_with_History_of_Moderate_or_Severe_LVSD_Value()
	{
		var a_ = this.Heart_Failure_Outpatient_Encounter();
		IEnumerable<Encounter> b_(Encounter HFOutpatientEncounter)
		{
			var d_ = this.Moderate_or_Severe_LVSD_Findings();
			bool? e_(object LVSDFindings)
			{
				var i_ = QICoreCommon_2_0_000.prevalenceInterval((LVSDFindings as Condition));
				var j_ = context.Operators.LateBoundProperty<object>(LVSDFindings, "effective");
				var k_ = FHIRHelpers_4_3_000.ToValue(j_);
				var l_ = QICoreCommon_2_0_000.toInterval(k_);
				var m_ = context.Operators.Start((i_ ?? l_));
				var n_ = HFOutpatientEncounter?.Period;
				var o_ = FHIRHelpers_4_3_000.ToInterval(n_);
				var p_ = context.Operators.End(o_);
				var q_ = context.Operators.Before(m_, p_, null);

				return q_;
			};
			var f_ = context.Operators.Where<object>(d_, e_);
			Encounter g_(object LVSDFindings) => 
				HFOutpatientEncounter;
			var h_ = context.Operators.Select<object, Encounter>(f_, g_);

			return h_;
		};
		var c_ = context.Operators.SelectMany<Encounter, Encounter>(a_, b_);

		return c_;
	}

    [CqlDeclaration("Heart Failure Outpatient Encounter with History of Moderate or Severe LVSD")]
	public IEnumerable<Encounter> Heart_Failure_Outpatient_Encounter_with_History_of_Moderate_or_Severe_LVSD() => 
		__Heart_Failure_Outpatient_Encounter_with_History_of_Moderate_or_Severe_LVSD.Value;

	private bool? Has_Heart_Transplant_Complications_Value()
	{
		var a_ = this.Heart_Transplant_Complications();
		var b_ = context.Operators.RetrieveByValueSet<Condition>(a_, null);
		IEnumerable<Condition> c_(Condition HeartTransplantComplications)
		{
			var h_ = this.Heart_Failure_Outpatient_Encounter_with_History_of_Moderate_or_Severe_LVSD();
			bool? i_(Encounter ModerateOrSevereLVSDHFOutpatientEncounter)
			{
				var m_ = HeartTransplantComplications?.RecordedDateElement;
				var n_ = context.Operators.Convert<CqlDateTime>(m_);
				var o_ = QICoreCommon_2_0_000.toInterval((n_ as object));
				var p_ = QICoreCommon_2_0_000.prevalenceInterval(HeartTransplantComplications);
				var q_ = context.Operators.Start((o_ ?? p_));
				var r_ = ModerateOrSevereLVSDHFOutpatientEncounter?.Period;
				var s_ = FHIRHelpers_4_3_000.ToInterval(r_);
				var t_ = context.Operators.End(s_);
				var u_ = context.Operators.Before(q_, t_, null);

				return u_;
			};
			var j_ = context.Operators.Where<Encounter>(h_, i_);
			Condition k_(Encounter ModerateOrSevereLVSDHFOutpatientEncounter) => 
				HeartTransplantComplications;
			var l_ = context.Operators.Select<Encounter, Condition>(j_, k_);

			return l_;
		};
		var d_ = context.Operators.SelectMany<Condition, Condition>(b_, c_);
		bool? e_(Condition HeartTransplantComplications)
		{
			var v_ = this.isConfirmedActiveDiagnosis(HeartTransplantComplications);

			return v_;
		};
		var f_ = context.Operators.Where<Condition>(d_, e_);
		var g_ = context.Operators.Exists<Condition>(f_);

		return g_;
	}

    [CqlDeclaration("Has Heart Transplant Complications")]
	public bool? Has_Heart_Transplant_Complications() => 
		__Has_Heart_Transplant_Complications.Value;

	private bool? Has_Left_Ventricular_Assist_Device_Value()
	{
		var a_ = this.Left_Ventricular_Assist_Device_Placement();
		var b_ = context.Operators.RetrieveByValueSet<Procedure>(a_, null);
		IEnumerable<Procedure> c_(Procedure LVADOutpatient)
		{
			var h_ = this.Heart_Failure_Outpatient_Encounter_with_History_of_Moderate_or_Severe_LVSD();
			bool? i_(Encounter ModerateOrSevereLVSDHFOutpatientEncounter)
			{
				var m_ = LVADOutpatient?.Performed;
				var n_ = FHIRHelpers_4_3_000.ToValue(m_);
				var o_ = QICoreCommon_2_0_000.toInterval(n_);
				var p_ = context.Operators.Start(o_);
				var q_ = ModerateOrSevereLVSDHFOutpatientEncounter?.Period;
				var r_ = FHIRHelpers_4_3_000.ToInterval(q_);
				var s_ = context.Operators.End(r_);
				var t_ = context.Operators.Before(p_, s_, null);

				return t_;
			};
			var j_ = context.Operators.Where<Encounter>(h_, i_);
			Procedure k_(Encounter ModerateOrSevereLVSDHFOutpatientEncounter) => 
				LVADOutpatient;
			var l_ = context.Operators.Select<Encounter, Procedure>(j_, k_);

			return l_;
		};
		var d_ = context.Operators.SelectMany<Procedure, Procedure>(b_, c_);
		bool? e_(Procedure LVADOutpatient)
		{
			var u_ = LVADOutpatient?.StatusElement;
			var v_ = u_?.Value;
			var w_ = context.Operators.Convert<string>(v_);
			var x_ = context.Operators.Equal(w_, "completed");

			return x_;
		};
		var f_ = context.Operators.Where<Procedure>(d_, e_);
		var g_ = context.Operators.Exists<Procedure>(f_);

		return g_;
	}

    [CqlDeclaration("Has Left Ventricular Assist Device")]
	public bool? Has_Left_Ventricular_Assist_Device() => 
		__Has_Left_Ventricular_Assist_Device.Value;

	private bool? Has_Left_Ventricular_Assist_Device_Complications_Value()
	{
		var a_ = this.Left_Ventricular_Assist_Device_Complications();
		var b_ = context.Operators.RetrieveByValueSet<Condition>(a_, null);
		IEnumerable<Condition> c_(Condition LVADComplications)
		{
			var h_ = this.Heart_Failure_Outpatient_Encounter_with_History_of_Moderate_or_Severe_LVSD();
			bool? i_(Encounter ModerateOrSevereLVSDHFOutpatientEncounter)
			{
				var m_ = LVADComplications?.RecordedDateElement;
				var n_ = context.Operators.Convert<CqlDateTime>(m_);
				var o_ = QICoreCommon_2_0_000.toInterval((n_ as object));
				var p_ = QICoreCommon_2_0_000.prevalenceInterval(LVADComplications);
				var q_ = context.Operators.Start((o_ ?? p_));
				var r_ = ModerateOrSevereLVSDHFOutpatientEncounter?.Period;
				var s_ = FHIRHelpers_4_3_000.ToInterval(r_);
				var t_ = context.Operators.End(s_);
				var u_ = context.Operators.Before(q_, t_, null);

				return u_;
			};
			var j_ = context.Operators.Where<Encounter>(h_, i_);
			Condition k_(Encounter ModerateOrSevereLVSDHFOutpatientEncounter) => 
				LVADComplications;
			var l_ = context.Operators.Select<Encounter, Condition>(j_, k_);

			return l_;
		};
		var d_ = context.Operators.SelectMany<Condition, Condition>(b_, c_);
		bool? e_(Condition LVADComplications)
		{
			var v_ = this.isConfirmedActiveDiagnosis(LVADComplications);

			return v_;
		};
		var f_ = context.Operators.Where<Condition>(d_, e_);
		var g_ = context.Operators.Exists<Condition>(f_);

		return g_;
	}

    [CqlDeclaration("Has Left Ventricular Assist Device Complications")]
	public bool? Has_Left_Ventricular_Assist_Device_Complications() => 
		__Has_Left_Ventricular_Assist_Device_Complications.Value;

	private IEnumerable<Encounter> Qualifying_Outpatient_Encounter_During_Measurement_Period_Value()
	{
		var a_ = this.Care_Services_in_Long_Term_Residential_Facility();
		var b_ = context.Operators.RetrieveByValueSet<Encounter>(a_, null);
		var c_ = this.Home_Healthcare_Services();
		var d_ = context.Operators.RetrieveByValueSet<Encounter>(c_, null);
		var e_ = context.Operators.Union<Encounter>(b_, d_);
		var f_ = this.Nursing_Facility_Visit();
		var g_ = context.Operators.RetrieveByValueSet<Encounter>(f_, null);
		var h_ = this.Office_Visit();
		var i_ = context.Operators.RetrieveByValueSet<Encounter>(h_, null);
		var j_ = context.Operators.Union<Encounter>(g_, i_);
		var k_ = context.Operators.Union<Encounter>(e_, j_);
		var l_ = this.Outpatient_Consultation();
		var m_ = context.Operators.RetrieveByValueSet<Encounter>(l_, null);
		var n_ = this.Patient_Provider_Interaction();
		var o_ = context.Operators.RetrieveByValueSet<Encounter>(n_, null);
		var p_ = context.Operators.Union<Encounter>(m_, o_);
		var q_ = context.Operators.Union<Encounter>(k_, p_);
		bool? r_(Encounter ValidEncounter)
		{
			var t_ = this.Measurement_Period();
			var u_ = ValidEncounter?.Period;
			var v_ = FHIRHelpers_4_3_000.ToInterval(u_);
			var w_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(t_, v_, null);
			var x_ = this.isFinished(ValidEncounter);
			var y_ = context.Operators.And(w_, x_);

			return y_;
		};
		var s_ = context.Operators.Where<Encounter>(q_, r_);

		return s_;
	}

    [CqlDeclaration("Qualifying Outpatient Encounter During Measurement Period")]
	public IEnumerable<Encounter> Qualifying_Outpatient_Encounter_During_Measurement_Period() => 
		__Qualifying_Outpatient_Encounter_During_Measurement_Period.Value;

	private bool? Has_Two_Qualifying_Outpatient_Encounters_and_Heart_Failure_Outpatient_Encounter_During_the_Measurement_Period_Value()
	{
		var a_ = this.Patient();
		var b_ = context.Operators.Convert<CqlDate>(a_?.BirthDateElement?.Value);
		var c_ = this.Measurement_Period();
		var d_ = context.Operators.Start(c_);
		var e_ = context.Operators.DateFrom(d_);
		var f_ = context.Operators.CalculateAgeAt(b_, e_, "year");
		var g_ = context.Operators.GreaterOrEqual(f_, 18);
		var h_ = this.Qualifying_Outpatient_Encounter_During_Measurement_Period();
		IEnumerable<Encounter> i_(Encounter Encounter1)
		{
			var p_ = this.Qualifying_Outpatient_Encounter_During_Measurement_Period();
			bool? q_(Encounter Encounter2)
			{
				var u_ = Encounter2?.IdElement;
				var v_ = u_?.Value;
				var w_ = Encounter1?.IdElement;
				var x_ = w_?.Value;
				var y_ = context.Operators.Equivalent(v_, x_);
				var z_ = context.Operators.Not(y_);

				return z_;
			};
			var r_ = context.Operators.Where<Encounter>(p_, q_);
			Encounter s_(Encounter Encounter2) => 
				Encounter1;
			var t_ = context.Operators.Select<Encounter, Encounter>(r_, s_);

			return t_;
		};
		var j_ = context.Operators.SelectMany<Encounter, Encounter>(h_, i_);
		var k_ = context.Operators.Exists<Encounter>(j_);
		var l_ = context.Operators.And(g_, k_);
		var m_ = this.Heart_Failure_Outpatient_Encounter();
		var n_ = context.Operators.Exists<Encounter>(m_);
		var o_ = context.Operators.And(l_, n_);

		return o_;
	}

    [CqlDeclaration("Has Two Qualifying Outpatient Encounters and Heart Failure Outpatient Encounter During the Measurement Period")]
	public bool? Has_Two_Qualifying_Outpatient_Encounters_and_Heart_Failure_Outpatient_Encounter_During_the_Measurement_Period() => 
		__Has_Two_Qualifying_Outpatient_Encounters_and_Heart_Failure_Outpatient_Encounter_During_the_Measurement_Period.Value;

	private bool? Has_Heart_Transplant_Value()
	{
		var a_ = this.Heart_Transplant();
		var b_ = context.Operators.RetrieveByValueSet<Procedure>(a_, null);
		IEnumerable<Procedure> c_(Procedure HeartTransplant)
		{
			var h_ = this.Heart_Failure_Outpatient_Encounter_with_History_of_Moderate_or_Severe_LVSD();
			bool? i_(Encounter ModerateOrSevereLVSDHFOutpatientEncounter)
			{
				var m_ = HeartTransplant?.Performed;
				var n_ = FHIRHelpers_4_3_000.ToValue(m_);
				var o_ = QICoreCommon_2_0_000.toInterval(n_);
				var p_ = context.Operators.Start(o_);
				var q_ = ModerateOrSevereLVSDHFOutpatientEncounter?.Period;
				var r_ = FHIRHelpers_4_3_000.ToInterval(q_);
				var s_ = context.Operators.End(r_);
				var t_ = context.Operators.Before(p_, s_, null);

				return t_;
			};
			var j_ = context.Operators.Where<Encounter>(h_, i_);
			Procedure k_(Encounter ModerateOrSevereLVSDHFOutpatientEncounter) => 
				HeartTransplant;
			var l_ = context.Operators.Select<Encounter, Procedure>(j_, k_);

			return l_;
		};
		var d_ = context.Operators.SelectMany<Procedure, Procedure>(b_, c_);
		bool? e_(Procedure HeartTransplant)
		{
			var u_ = HeartTransplant?.StatusElement;
			var v_ = u_?.Value;
			var w_ = context.Operators.Convert<string>(v_);
			var x_ = context.Operators.Equal(w_, "completed");

			return x_;
		};
		var f_ = context.Operators.Where<Procedure>(d_, e_);
		var g_ = context.Operators.Exists<Procedure>(f_);

		return g_;
	}

    [CqlDeclaration("Has Heart Transplant")]
	public bool? Has_Heart_Transplant() => 
		__Has_Heart_Transplant.Value;

    [CqlDeclaration("isOrderedDuringHeartFailureOutpatientEncounter")]
	public bool? isOrderedDuringHeartFailureOutpatientEncounter(MedicationRequest Order)
	{
		var a_ = this.Heart_Failure_Outpatient_Encounter_with_History_of_Moderate_or_Severe_LVSD();
		bool? b_(Encounter ModerateOrSevereLVSDHFOutpatientEncounter)
		{
			var e_ = Order?.AuthoredOnElement;
			var f_ = context.Operators.Convert<CqlDateTime>(e_);
			var g_ = ModerateOrSevereLVSDHFOutpatientEncounter?.Period;
			var h_ = FHIRHelpers_4_3_000.ToInterval(g_);
			var i_ = context.Operators.In<CqlDateTime>(f_, h_, "day");
			var j_ = Order?.StatusElement;
			var k_ = j_?.Value;
			var l_ = context.Operators.Convert<string>(k_);
			var m_ = new string[]
			{
				"active",
				"completed",
			};
			var n_ = context.Operators.In<string>(l_, (m_ as IEnumerable<string>));
			var o_ = context.Operators.And(i_, n_);
			var p_ = Order?.IntentElement;
			var q_ = p_?.Value;
			var r_ = context.Operators.Convert<string>(q_);
			var s_ = new string[]
			{
				"order",
				"original-order",
				"reflex-order",
				"filler-order",
				"instance-order",
			};
			var t_ = context.Operators.In<string>(r_, (s_ as IEnumerable<string>));
			var u_ = context.Operators.And(o_, t_);
			var v_ = Order?.DoNotPerformElement;
			var w_ = v_?.Value;
			var x_ = context.Operators.IsTrue(w_);
			var y_ = context.Operators.Not(x_);
			var z_ = context.Operators.And(u_, y_);

			return z_;
		};
		var c_ = context.Operators.Where<Encounter>(a_, b_);
		var d_ = context.Operators.Exists<Encounter>(c_);

		return d_;
	}

    [CqlDeclaration("overlapsHeartFailureOutpatientEncounter")]
	public bool? overlapsHeartFailureOutpatientEncounter(Condition Diagnosis)
	{
		var a_ = this.Heart_Failure_Outpatient_Encounter_with_History_of_Moderate_or_Severe_LVSD();
		bool? b_(Encounter ModerateOrSevereLVSDHFOutpatientEncounter)
		{
			var e_ = QICoreCommon_2_0_000.prevalenceInterval(Diagnosis);
			var f_ = ModerateOrSevereLVSDHFOutpatientEncounter?.Period;
			var g_ = FHIRHelpers_4_3_000.ToInterval(f_);
			var h_ = context.Operators.Overlaps(e_, g_, "day");
			var i_ = this.isConfirmedActiveDiagnosis(Diagnosis);
			var j_ = context.Operators.And(h_, i_);

			return j_;
		};
		var c_ = context.Operators.Where<Encounter>(a_, b_);
		var d_ = context.Operators.Exists<Encounter>(c_);

		return d_;
	}

    [CqlDeclaration("overlapsAfterHeartFailureOutpatientEncounter")]
	public bool? overlapsAfterHeartFailureOutpatientEncounter(object Event)
	{
		var a_ = this.Heart_Failure_Outpatient_Encounter_with_History_of_Moderate_or_Severe_LVSD();
		bool? b_(Encounter ModerateOrSevereLVSDHFOutpatientEncounter)
		{
			bool? e_()
			{
				if (Event is Condition)
				{
					var f_ = QICoreCommon_2_0_000.prevalenceInterval((Event as Condition));
					var g_ = ModerateOrSevereLVSDHFOutpatientEncounter?.Period;
					var h_ = FHIRHelpers_4_3_000.ToInterval(g_);
					var i_ = context.Operators.OverlapsAfter(f_, h_, "day");
					var j_ = this.isConfirmedActiveDiagnosis((Event as Condition));
					var k_ = context.Operators.And(i_, j_);

					return k_;
				}
				else if (Event is Procedure)
				{
					var l_ = (Event as Procedure)?.Performed;
					var m_ = FHIRHelpers_4_3_000.ToValue(l_);
					var n_ = QICoreCommon_2_0_000.toInterval(m_);
					var o_ = ModerateOrSevereLVSDHFOutpatientEncounter?.Period;
					var p_ = FHIRHelpers_4_3_000.ToInterval(o_);
					var q_ = context.Operators.OverlapsAfter(n_, p_, "day");
					var r_ = (Event as Procedure)?.StatusElement;
					var s_ = r_?.Value;
					var t_ = context.Operators.Convert<string>(s_);
					var u_ = context.Operators.Equal(t_, "completed");
					var v_ = context.Operators.And(q_, u_);

					return v_;
				}
				else if (Event is AllergyIntolerance)
				{
					var w_ = (Event as AllergyIntolerance)?.Onset;
					var x_ = FHIRHelpers_4_3_000.ToValue(w_);
					var y_ = QICoreCommon_2_0_000.toInterval(x_);
					var z_ = context.Operators.Start(y_);
					var aa_ = (Event as AllergyIntolerance)?.LastOccurrenceElement;
					var ab_ = context.Operators.Convert<CqlDateTime>(aa_);
					var ac_ = context.Operators.Interval(z_, ab_, true, true);
					var ad_ = ModerateOrSevereLVSDHFOutpatientEncounter?.Period;
					var ae_ = FHIRHelpers_4_3_000.ToInterval(ad_);
					var af_ = context.Operators.OverlapsAfter(ac_, ae_, "day");
					var ag_ = (Event as AllergyIntolerance)?.ClinicalStatus;
					var ah_ = FHIRHelpers_4_3_000.ToConcept(ag_);
					var ai_ = QICoreCommon_2_0_000.allergy_active();
					var aj_ = context.Operators.ConvertCodeToConcept(ai_);
					var ak_ = context.Operators.Equivalent(ah_, aj_);
					var al_ = context.Operators.And(af_, ak_);
					var am_ = (Event as AllergyIntolerance)?.VerificationStatus;
					var an_ = FHIRHelpers_4_3_000.ToConcept(am_);
					var ao_ = QICoreCommon_2_0_000.allergy_unconfirmed();
					var ap_ = context.Operators.ConvertCodeToConcept(ao_);
					var aq_ = context.Operators.Equivalent(an_, ap_);
					var as_ = FHIRHelpers_4_3_000.ToConcept(am_);
					var at_ = QICoreCommon_2_0_000.allergy_refuted();
					var au_ = context.Operators.ConvertCodeToConcept(at_);
					var av_ = context.Operators.Equivalent(as_, au_);
					var aw_ = context.Operators.Or(aq_, av_);
					var ay_ = FHIRHelpers_4_3_000.ToConcept(am_);
					var az_ = this.allergy_entered_in_error();
					var ba_ = context.Operators.ConvertCodeToConcept(az_);
					var bb_ = context.Operators.Equivalent(ay_, ba_);
					var bc_ = context.Operators.Or(aw_, bb_);
					var bd_ = context.Operators.Not(bc_);
					var be_ = context.Operators.And(al_, bd_);

					return be_;
				}
				else if (Event is MedicationRequest)
				{
					var bf_ = context.Operators.LateBoundProperty<object>(Event, "dosageInstruction");
					var bg_ = new object[]
					{
						bf_,
					};
					bool? bh_(object @this)
					{
						var cz_ = context.Operators.LateBoundProperty<object>(@this, "timing");
						var da_ = context.Operators.Not((bool?)(cz_ is null));

						return da_;
					};
					var bi_ = context.Operators.Where<object>((IEnumerable<object>)bg_, bh_);
					object bj_(object @this)
					{
						var db_ = context.Operators.LateBoundProperty<object>(@this, "timing");

						return db_;
					};
					var bk_ = context.Operators.Select<object, object>(bi_, bj_);
					var bl_ = context.Operators.SingletonFrom<object>(bk_);
					var bm_ = new object[]
					{
						bl_,
					};
					bool? bn_(object @this)
					{
						var dc_ = context.Operators.LateBoundProperty<object>(@this, "repeat");
						var dd_ = context.Operators.Not((bool?)(dc_ is null));

						return dd_;
					};
					var bo_ = context.Operators.Where<object>((IEnumerable<object>)bm_, bn_);
					object bp_(object @this)
					{
						var de_ = context.Operators.LateBoundProperty<object>(@this, "repeat");

						return de_;
					};
					var bq_ = context.Operators.Select<object, object>(bo_, bp_);
					var br_ = context.Operators.SingletonFrom<object>(bq_);
					var bs_ = new object[]
					{
						br_,
					};
					bool? bt_(object @this)
					{
						var df_ = context.Operators.LateBoundProperty<object>(@this, "bounds");
						var dg_ = FHIRHelpers_4_3_000.ToValue(df_);
						var dh_ = context.Operators.Not((bool?)(dg_ is null));

						return dh_;
					};
					var bu_ = context.Operators.Where<object>((IEnumerable<object>)bs_, bt_);
					object bv_(object @this)
					{
						var di_ = context.Operators.LateBoundProperty<object>(@this, "bounds");
						var dj_ = FHIRHelpers_4_3_000.ToValue(di_);

						return dj_;
					};
					var bw_ = context.Operators.Select<object, object>(bu_, bv_);
					var bx_ = context.Operators.SingletonFrom<object>(bw_);
					var by_ = new object[]
					{
						bx_,
					};
					CqlInterval<CqlDateTime> bz_(object DoseTime)
					{
						var dk_ = QICoreCommon_2_0_000.toInterval(DoseTime);

						return dk_;
					};
					var ca_ = context.Operators.Select<object, CqlInterval<CqlDateTime>>((IEnumerable<object>)by_, bz_);
					var cb_ = context.Operators.Collapse(ca_, null);
					object cc_(CqlInterval<CqlDateTime> @this)
					{
						var dl_ = context.Operators.Start(@this);

						return dl_;
					};
					var cd_ = context.Operators.SortBy<CqlInterval<CqlDateTime>>(cb_, cc_, System.ComponentModel.ListSortDirection.Ascending);
					var ce_ = context.Operators.First<CqlInterval<CqlDateTime>>(cd_);
					var cf_ = ModerateOrSevereLVSDHFOutpatientEncounter?.Period;
					var cg_ = FHIRHelpers_4_3_000.ToInterval(cf_);
					var ch_ = context.Operators.OverlapsAfter(ce_, cg_, "day");
					var ci_ = (Event as MedicationRequest)?.StatusElement;
					var cj_ = ci_?.Value;
					var ck_ = context.Operators.Convert<string>(cj_);
					var cl_ = new string[]
					{
						"active",
						"completed",
					};
					var cm_ = context.Operators.In<string>(ck_, (cl_ as IEnumerable<string>));
					var cn_ = context.Operators.And(ch_, cm_);
					var co_ = (Event as MedicationRequest)?.IntentElement;
					var cp_ = co_?.Value;
					var cq_ = context.Operators.Convert<string>(cp_);
					var cr_ = new string[]
					{
						"order",
						"original-order",
						"reflex-order",
						"filler-order",
						"instance-order",
					};
					var cs_ = context.Operators.In<string>(cq_, (cr_ as IEnumerable<string>));
					var ct_ = context.Operators.And(cn_, cs_);
					var cu_ = (Event as MedicationRequest)?.DoNotPerformElement;
					var cv_ = cu_?.Value;
					var cw_ = context.Operators.IsTrue(cv_);
					var cx_ = context.Operators.Not(cw_);
					var cy_ = context.Operators.And(ct_, cx_);

					return cy_;
				}
				else if (Event is Observation)
				{
					var dm_ = (Event as Observation)?.Effective;
					var dn_ = FHIRHelpers_4_3_000.ToValue(dm_);
					var do_ = QICoreCommon_2_0_000.toInterval(dn_);
					var dp_ = ModerateOrSevereLVSDHFOutpatientEncounter?.Period;
					var dq_ = FHIRHelpers_4_3_000.ToInterval(dp_);
					var dr_ = context.Operators.OverlapsAfter(do_, dq_, "day");
					var ds_ = (Event as Observation)?.StatusElement;
					var dt_ = ds_?.Value;
					var du_ = context.Operators.Convert<string>(dt_);
					var dv_ = new string[]
					{
						"final",
						"amended",
						"corrected",
					};
					var dw_ = context.Operators.In<string>(du_, (dv_ as IEnumerable<string>));
					var dx_ = context.Operators.And(dr_, dw_);

					return dx_;
				}
				else
				{
					return false;
				}
			};

			return e_();
		};
		var c_ = context.Operators.Where<Encounter>(a_, b_);
		var d_ = context.Operators.Exists<Encounter>(c_);

		return d_;
	}

}
