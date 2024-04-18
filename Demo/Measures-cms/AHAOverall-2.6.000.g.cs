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
		var a_ = context.Operators.DateTime((int?)2025, (int?)1, (int?)1, (int?)0, (int?)0, (int?)0, (int?)0, default);
		var b_ = context.Operators.DateTime((int?)2026, (int?)1, (int?)1, (int?)0, (int?)0, (int?)0, (int?)0, default);
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
		var b_ = context.Operators.SingleOrNull<Patient>(a_);

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
			var f_ = FHIRHelpers_4_3_000.ToConcept(Diagnosis?.ClinicalStatus);
			var g_ = QICoreCommon_2_0_000.active();
			var h_ = context.Operators.ConvertCodeToConcept(g_);
			var i_ = context.Operators.Equivalent(f_, h_);
			var j_ = FHIRHelpers_4_3_000.ToConcept(Diagnosis?.VerificationStatus);
			var k_ = QICoreCommon_2_0_000.unconfirmed();
			var l_ = context.Operators.ConvertCodeToConcept(k_);
			var m_ = context.Operators.Equivalent(j_, l_);
			var o_ = QICoreCommon_2_0_000.refuted();
			var p_ = context.Operators.ConvertCodeToConcept(o_);
			var q_ = context.Operators.Equivalent(j_, p_);
			var r_ = context.Operators.Or(m_, q_);
			var t_ = QICoreCommon_2_0_000.entered_in_error();
			var u_ = context.Operators.ConvertCodeToConcept(t_);
			var v_ = context.Operators.Equivalent(j_, u_);
			var w_ = context.Operators.Or(r_, v_);
			var x_ = context.Operators.Not(w_);
			var y_ = context.Operators.And(i_, x_);

			return y_;
		};
		var c_ = context.Operators.WhereOrNull<Condition>(a_, b_);
		var d_ = context.Operators.SingleOrNull<Condition>(c_);
		var e_ = context.Operators.Not((bool?)(d_ is null));

		return e_;
	}

    [CqlDeclaration("isFinished")]
	public bool? isFinished(Encounter Visit)
	{
		var a_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(Visit?.StatusElement?.Value);
		var b_ = context.Operators.Equal(a_, (string)"finished");

		return b_;
	}

	private IEnumerable<Encounter> Heart_Failure_Outpatient_Encounter_Value()
	{
		var a_ = this.Care_Services_in_Long_Term_Residential_Facility();
		var b_ = context.Operators.RetrieveByValueSet<Encounter>(a_, null);
		var c_ = this.Home_Healthcare_Services();
		var d_ = context.Operators.RetrieveByValueSet<Encounter>(c_, null);
		var e_ = context.Operators.ListUnion<Encounter>(b_, d_);
		var f_ = this.Nursing_Facility_Visit();
		var g_ = context.Operators.RetrieveByValueSet<Encounter>(f_, null);
		var h_ = this.Office_Visit();
		var i_ = context.Operators.RetrieveByValueSet<Encounter>(h_, null);
		var j_ = context.Operators.ListUnion<Encounter>(g_, i_);
		var k_ = context.Operators.ListUnion<Encounter>(e_, j_);
		var l_ = this.Outpatient_Consultation();
		var m_ = context.Operators.RetrieveByValueSet<Encounter>(l_, null);
		var n_ = context.Operators.ListUnion<Encounter>(k_, m_);
		IEnumerable<Encounter> o_(Encounter QualifyingEncounter)
		{
			var s_ = this.Heart_Failure();
			var t_ = context.Operators.RetrieveByValueSet<Condition>(s_, null);
			bool? u_(Condition HeartFailure)
			{
				var y_ = QICoreCommon_2_0_000.prevalenceInterval(HeartFailure);
				var z_ = FHIRHelpers_4_3_000.ToInterval(QualifyingEncounter?.Period);
				var aa_ = context.Operators.Overlaps(y_, z_, null);
				var ab_ = this.isConfirmedActiveDiagnosis(HeartFailure);
				var ac_ = context.Operators.And(aa_, ab_);

				return ac_;
			};
			var v_ = context.Operators.WhereOrNull<Condition>(t_, u_);
			Encounter w_(Condition HeartFailure) => 
				QualifyingEncounter;
			var x_ = context.Operators.SelectOrNull<Condition, Encounter>(v_, w_);

			return x_;
		};
		var p_ = context.Operators.SelectManyOrNull<Encounter, Encounter>(n_, o_);
		bool? q_(Encounter QualifyingEncounter)
		{
			var ad_ = this.Measurement_Period();
			var ae_ = FHIRHelpers_4_3_000.ToInterval(QualifyingEncounter?.Period);
			var af_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(ad_, ae_, null);
			var ag_ = this.isFinished(QualifyingEncounter);
			var ah_ = context.Operators.And(af_, ag_);

			return ah_;
		};
		var r_ = context.Operators.WhereOrNull<Encounter>(p_, q_);

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
			var n_ = FHIRHelpers_4_3_000.ToValue(EjectionFraction?.Value);
			var o_ = context.Operators.Quantity((decimal?)40m, "%");
			var p_ = context.Operators.LessOrEqual((n_ as CqlQuantity), o_);
			var q_ = context.Operators.Convert<Code<ObservationStatus>>(EjectionFraction?.StatusElement?.Value);
			var r_ = context.Operators.Convert<string>(q_);
			var s_ = new string[]
			{
				(string)"final",
				(string)"amended",
				(string)"corrected",
			};
			var t_ = context.Operators.InList<string>(r_, (s_ as IEnumerable<string>));
			var u_ = context.Operators.And(p_, t_);

			return u_;
		};
		var d_ = context.Operators.WhereOrNull<Observation>(b_, c_);
		var e_ = this.Moderate_or_Severe_LVSD();
		var f_ = context.Operators.RetrieveByValueSet<Condition>(e_, null);
		var g_ = context.Operators.ListUnion<object>((d_ as IEnumerable<object>), (f_ as IEnumerable<object>));
		var h_ = this.Left_ventricular_systolic_dysfunction__disorder_();
		var i_ = context.Operators.ToList<CqlCode>(h_);
		var j_ = context.Operators.RetrieveByCodes<Condition>(i_, null);
		bool? k_(Condition LVSDDiagnosis)
		{
			var v_ = FHIRHelpers_4_3_000.ToConcept(LVSDDiagnosis?.Severity);
			var w_ = this.Moderate_or_Severe();
			var x_ = context.Operators.ConceptInValueSet(v_, w_);

			return x_;
		};
		var l_ = context.Operators.WhereOrNull<Condition>(j_, k_);
		var m_ = context.Operators.ListUnion<object>((g_ as IEnumerable<object>), (l_ as IEnumerable<object>));

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
				var n_ = FHIRHelpers_4_3_000.ToInterval(HFOutpatientEncounter?.Period);
				var o_ = context.Operators.End(n_);
				var p_ = context.Operators.Before(m_, o_, null);

				return p_;
			};
			var f_ = context.Operators.WhereOrNull<object>(d_, e_);
			Encounter g_(object LVSDFindings) => 
				HFOutpatientEncounter;
			var h_ = context.Operators.SelectOrNull<object, Encounter>(f_, g_);

			return h_;
		};
		var c_ = context.Operators.SelectManyOrNull<Encounter, Encounter>(a_, b_);

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
				var m_ = context.Operators.Convert<CqlDateTime>(HeartTransplantComplications?.RecordedDateElement);
				var n_ = QICoreCommon_2_0_000.toInterval((m_ as object));
				var o_ = QICoreCommon_2_0_000.prevalenceInterval(HeartTransplantComplications);
				var p_ = context.Operators.Start((n_ ?? o_));
				var q_ = FHIRHelpers_4_3_000.ToInterval(ModerateOrSevereLVSDHFOutpatientEncounter?.Period);
				var r_ = context.Operators.End(q_);
				var s_ = context.Operators.Before(p_, r_, null);

				return s_;
			};
			var j_ = context.Operators.WhereOrNull<Encounter>(h_, i_);
			Condition k_(Encounter ModerateOrSevereLVSDHFOutpatientEncounter) => 
				HeartTransplantComplications;
			var l_ = context.Operators.SelectOrNull<Encounter, Condition>(j_, k_);

			return l_;
		};
		var d_ = context.Operators.SelectManyOrNull<Condition, Condition>(b_, c_);
		bool? e_(Condition HeartTransplantComplications)
		{
			var t_ = this.isConfirmedActiveDiagnosis(HeartTransplantComplications);

			return t_;
		};
		var f_ = context.Operators.WhereOrNull<Condition>(d_, e_);
		var g_ = context.Operators.ExistsInList<Condition>(f_);

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
				var m_ = FHIRHelpers_4_3_000.ToValue(LVADOutpatient?.Performed);
				var n_ = QICoreCommon_2_0_000.toInterval(m_);
				var o_ = context.Operators.Start(n_);
				var p_ = FHIRHelpers_4_3_000.ToInterval(ModerateOrSevereLVSDHFOutpatientEncounter?.Period);
				var q_ = context.Operators.End(p_);
				var r_ = context.Operators.Before(o_, q_, null);

				return r_;
			};
			var j_ = context.Operators.WhereOrNull<Encounter>(h_, i_);
			Procedure k_(Encounter ModerateOrSevereLVSDHFOutpatientEncounter) => 
				LVADOutpatient;
			var l_ = context.Operators.SelectOrNull<Encounter, Procedure>(j_, k_);

			return l_;
		};
		var d_ = context.Operators.SelectManyOrNull<Procedure, Procedure>(b_, c_);
		bool? e_(Procedure LVADOutpatient)
		{
			var s_ = context.Operators.Convert<string>(LVADOutpatient?.StatusElement?.Value);
			var t_ = context.Operators.Equal(s_, (string)"completed");

			return t_;
		};
		var f_ = context.Operators.WhereOrNull<Procedure>(d_, e_);
		var g_ = context.Operators.ExistsInList<Procedure>(f_);

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
				var m_ = context.Operators.Convert<CqlDateTime>(LVADComplications?.RecordedDateElement);
				var n_ = QICoreCommon_2_0_000.toInterval((m_ as object));
				var o_ = QICoreCommon_2_0_000.prevalenceInterval(LVADComplications);
				var p_ = context.Operators.Start((n_ ?? o_));
				var q_ = FHIRHelpers_4_3_000.ToInterval(ModerateOrSevereLVSDHFOutpatientEncounter?.Period);
				var r_ = context.Operators.End(q_);
				var s_ = context.Operators.Before(p_, r_, null);

				return s_;
			};
			var j_ = context.Operators.WhereOrNull<Encounter>(h_, i_);
			Condition k_(Encounter ModerateOrSevereLVSDHFOutpatientEncounter) => 
				LVADComplications;
			var l_ = context.Operators.SelectOrNull<Encounter, Condition>(j_, k_);

			return l_;
		};
		var d_ = context.Operators.SelectManyOrNull<Condition, Condition>(b_, c_);
		bool? e_(Condition LVADComplications)
		{
			var t_ = this.isConfirmedActiveDiagnosis(LVADComplications);

			return t_;
		};
		var f_ = context.Operators.WhereOrNull<Condition>(d_, e_);
		var g_ = context.Operators.ExistsInList<Condition>(f_);

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
		var e_ = context.Operators.ListUnion<Encounter>(b_, d_);
		var f_ = this.Nursing_Facility_Visit();
		var g_ = context.Operators.RetrieveByValueSet<Encounter>(f_, null);
		var h_ = this.Office_Visit();
		var i_ = context.Operators.RetrieveByValueSet<Encounter>(h_, null);
		var j_ = context.Operators.ListUnion<Encounter>(g_, i_);
		var k_ = context.Operators.ListUnion<Encounter>(e_, j_);
		var l_ = this.Outpatient_Consultation();
		var m_ = context.Operators.RetrieveByValueSet<Encounter>(l_, null);
		var n_ = this.Patient_Provider_Interaction();
		var o_ = context.Operators.RetrieveByValueSet<Encounter>(n_, null);
		var p_ = context.Operators.ListUnion<Encounter>(m_, o_);
		var q_ = context.Operators.ListUnion<Encounter>(k_, p_);
		bool? r_(Encounter ValidEncounter)
		{
			var t_ = this.Measurement_Period();
			var u_ = FHIRHelpers_4_3_000.ToInterval(ValidEncounter?.Period);
			var v_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(t_, u_, null);
			var w_ = this.isFinished(ValidEncounter);
			var x_ = context.Operators.And(v_, w_);

			return x_;
		};
		var s_ = context.Operators.WhereOrNull<Encounter>(q_, r_);

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
		var g_ = context.Operators.GreaterOrEqual(f_, (int?)18);
		var h_ = this.Qualifying_Outpatient_Encounter_During_Measurement_Period();
		IEnumerable<Encounter> i_(Encounter Encounter1)
		{
			var p_ = this.Qualifying_Outpatient_Encounter_During_Measurement_Period();
			bool? q_(Encounter Encounter2)
			{
				var u_ = context.Operators.Equivalent(Encounter2?.IdElement?.Value, Encounter1?.IdElement?.Value);
				var v_ = context.Operators.Not(u_);

				return v_;
			};
			var r_ = context.Operators.WhereOrNull<Encounter>(p_, q_);
			Encounter s_(Encounter Encounter2) => 
				Encounter1;
			var t_ = context.Operators.SelectOrNull<Encounter, Encounter>(r_, s_);

			return t_;
		};
		var j_ = context.Operators.SelectManyOrNull<Encounter, Encounter>(h_, i_);
		var k_ = context.Operators.ExistsInList<Encounter>(j_);
		var l_ = context.Operators.And(g_, k_);
		var m_ = this.Heart_Failure_Outpatient_Encounter();
		var n_ = context.Operators.ExistsInList<Encounter>(m_);
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
				var m_ = FHIRHelpers_4_3_000.ToValue(HeartTransplant?.Performed);
				var n_ = QICoreCommon_2_0_000.toInterval(m_);
				var o_ = context.Operators.Start(n_);
				var p_ = FHIRHelpers_4_3_000.ToInterval(ModerateOrSevereLVSDHFOutpatientEncounter?.Period);
				var q_ = context.Operators.End(p_);
				var r_ = context.Operators.Before(o_, q_, null);

				return r_;
			};
			var j_ = context.Operators.WhereOrNull<Encounter>(h_, i_);
			Procedure k_(Encounter ModerateOrSevereLVSDHFOutpatientEncounter) => 
				HeartTransplant;
			var l_ = context.Operators.SelectOrNull<Encounter, Procedure>(j_, k_);

			return l_;
		};
		var d_ = context.Operators.SelectManyOrNull<Procedure, Procedure>(b_, c_);
		bool? e_(Procedure HeartTransplant)
		{
			var s_ = context.Operators.Convert<string>(HeartTransplant?.StatusElement?.Value);
			var t_ = context.Operators.Equal(s_, (string)"completed");

			return t_;
		};
		var f_ = context.Operators.WhereOrNull<Procedure>(d_, e_);
		var g_ = context.Operators.ExistsInList<Procedure>(f_);

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
			var e_ = context.Operators.Convert<CqlDateTime>(Order?.AuthoredOnElement);
			var f_ = FHIRHelpers_4_3_000.ToInterval(ModerateOrSevereLVSDHFOutpatientEncounter?.Period);
			var g_ = context.Operators.ElementInInterval<CqlDateTime>(e_, f_, "day");
			var h_ = context.Operators.Convert<string>(Order?.StatusElement?.Value);
			var i_ = new string[]
			{
				(string)"active",
				(string)"completed",
			};
			var j_ = context.Operators.InList<string>(h_, (i_ as IEnumerable<string>));
			var k_ = context.Operators.And(g_, j_);
			var l_ = context.Operators.Convert<string>(Order?.IntentElement?.Value);
			var m_ = new string[]
			{
				(string)"order",
				(string)"original-order",
				(string)"reflex-order",
				(string)"filler-order",
				(string)"instance-order",
			};
			var n_ = context.Operators.InList<string>(l_, (m_ as IEnumerable<string>));
			var o_ = context.Operators.And(k_, n_);
			var p_ = context.Operators.IsTrue(Order?.DoNotPerformElement?.Value);
			var q_ = context.Operators.Not(p_);
			var r_ = context.Operators.And(o_, q_);

			return r_;
		};
		var c_ = context.Operators.WhereOrNull<Encounter>(a_, b_);
		var d_ = context.Operators.ExistsInList<Encounter>(c_);

		return d_;
	}

    [CqlDeclaration("overlapsHeartFailureOutpatientEncounter")]
	public bool? overlapsHeartFailureOutpatientEncounter(Condition Diagnosis)
	{
		var a_ = this.Heart_Failure_Outpatient_Encounter_with_History_of_Moderate_or_Severe_LVSD();
		bool? b_(Encounter ModerateOrSevereLVSDHFOutpatientEncounter)
		{
			var e_ = QICoreCommon_2_0_000.prevalenceInterval(Diagnosis);
			var f_ = FHIRHelpers_4_3_000.ToInterval(ModerateOrSevereLVSDHFOutpatientEncounter?.Period);
			var g_ = context.Operators.Overlaps(e_, f_, "day");
			var h_ = this.isConfirmedActiveDiagnosis(Diagnosis);
			var i_ = context.Operators.And(g_, h_);

			return i_;
		};
		var c_ = context.Operators.WhereOrNull<Encounter>(a_, b_);
		var d_ = context.Operators.ExistsInList<Encounter>(c_);

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
					var g_ = FHIRHelpers_4_3_000.ToInterval(ModerateOrSevereLVSDHFOutpatientEncounter?.Period);
					var h_ = context.Operators.OverlapsAfter(f_, g_, "day");
					var i_ = this.isConfirmedActiveDiagnosis((Event as Condition));
					var j_ = context.Operators.And(h_, i_);

					return j_;
				}
				else if (Event is Procedure)
				{
					var k_ = FHIRHelpers_4_3_000.ToValue((Event as Procedure)?.Performed);
					var l_ = QICoreCommon_2_0_000.toInterval(k_);
					var m_ = FHIRHelpers_4_3_000.ToInterval(ModerateOrSevereLVSDHFOutpatientEncounter?.Period);
					var n_ = context.Operators.OverlapsAfter(l_, m_, "day");
					var o_ = context.Operators.Convert<string>(((Event as Procedure)?.StatusElement)?.Value);
					var p_ = context.Operators.Equal(o_, (string)"completed");
					var q_ = context.Operators.And(n_, p_);

					return q_;
				}
				else if (Event is AllergyIntolerance)
				{
					var r_ = FHIRHelpers_4_3_000.ToValue((Event as AllergyIntolerance)?.Onset);
					var s_ = QICoreCommon_2_0_000.toInterval(r_);
					var t_ = context.Operators.Start(s_);
					var u_ = context.Operators.Convert<CqlDateTime>((Event as AllergyIntolerance)?.LastOccurrenceElement);
					var v_ = context.Operators.Interval(t_, u_, true, true);
					var w_ = FHIRHelpers_4_3_000.ToInterval(ModerateOrSevereLVSDHFOutpatientEncounter?.Period);
					var x_ = context.Operators.OverlapsAfter(v_, w_, "day");
					var y_ = FHIRHelpers_4_3_000.ToConcept((Event as AllergyIntolerance)?.ClinicalStatus);
					var z_ = QICoreCommon_2_0_000.allergy_active();
					var aa_ = context.Operators.ConvertCodeToConcept(z_);
					var ab_ = context.Operators.Equivalent(y_, aa_);
					var ac_ = context.Operators.And(x_, ab_);
					var ad_ = FHIRHelpers_4_3_000.ToConcept((Event as AllergyIntolerance)?.VerificationStatus);
					var ae_ = QICoreCommon_2_0_000.allergy_unconfirmed();
					var af_ = context.Operators.ConvertCodeToConcept(ae_);
					var ag_ = context.Operators.Equivalent(ad_, af_);
					var ai_ = QICoreCommon_2_0_000.allergy_refuted();
					var aj_ = context.Operators.ConvertCodeToConcept(ai_);
					var ak_ = context.Operators.Equivalent(ad_, aj_);
					var al_ = context.Operators.Or(ag_, ak_);
					var an_ = this.allergy_entered_in_error();
					var ao_ = context.Operators.ConvertCodeToConcept(an_);
					var ap_ = context.Operators.Equivalent(ad_, ao_);
					var aq_ = context.Operators.Or(al_, ap_);
					var ar_ = context.Operators.Not(aq_);
					var as_ = context.Operators.And(ac_, ar_);

					return as_;
				}
				else if (Event is MedicationRequest)
				{
					var at_ = context.Operators.LateBoundProperty<object>(Event, "dosageInstruction");
					var au_ = new object[]
					{
						at_,
					};
					bool? av_(object @this)
					{
						var cg_ = context.Operators.LateBoundProperty<object>(@this, "timing");
						var ch_ = context.Operators.Not((bool?)(cg_ is null));

						return ch_;
					};
					var aw_ = context.Operators.WhereOrNull<object>(au_, av_);
					object ax_(object @this)
					{
						var ci_ = context.Operators.LateBoundProperty<object>(@this, "timing");

						return ci_;
					};
					var ay_ = context.Operators.SelectOrNull<object, object>(aw_, ax_);
					var az_ = context.Operators.SingleOrNull<object>(ay_);
					var ba_ = new object[]
					{
						az_,
					};
					bool? bb_(object @this)
					{
						var cj_ = context.Operators.LateBoundProperty<object>(@this, "repeat");
						var ck_ = context.Operators.Not((bool?)(cj_ is null));

						return ck_;
					};
					var bc_ = context.Operators.WhereOrNull<object>(ba_, bb_);
					object bd_(object @this)
					{
						var cl_ = context.Operators.LateBoundProperty<object>(@this, "repeat");

						return cl_;
					};
					var be_ = context.Operators.SelectOrNull<object, object>(bc_, bd_);
					var bf_ = context.Operators.SingleOrNull<object>(be_);
					var bg_ = new object[]
					{
						bf_,
					};
					bool? bh_(object @this)
					{
						var cm_ = context.Operators.LateBoundProperty<object>(@this, "bounds");
						var cn_ = FHIRHelpers_4_3_000.ToValue(cm_);
						var co_ = context.Operators.Not((bool?)(cn_ is null));

						return co_;
					};
					var bi_ = context.Operators.WhereOrNull<object>(bg_, bh_);
					object bj_(object @this)
					{
						var cp_ = context.Operators.LateBoundProperty<object>(@this, "bounds");
						var cq_ = FHIRHelpers_4_3_000.ToValue(cp_);

						return cq_;
					};
					var bk_ = context.Operators.SelectOrNull<object, object>(bi_, bj_);
					var bl_ = context.Operators.SingleOrNull<object>(bk_);
					var bm_ = new object[]
					{
						bl_,
					};
					CqlInterval<CqlDateTime> bn_(object DoseTime)
					{
						var cr_ = QICoreCommon_2_0_000.toInterval(DoseTime);

						return cr_;
					};
					var bo_ = context.Operators.SelectOrNull<object, CqlInterval<CqlDateTime>>((bm_ as IEnumerable<object>), bn_);
					var bp_ = context.Operators.Collapse(bo_, null);
					object bq_(CqlInterval<CqlDateTime> @this)
					{
						var cs_ = context.Operators.Start(@this);

						return cs_;
					};
					var br_ = context.Operators.ListSortBy<CqlInterval<CqlDateTime>>(bp_, bq_, System.ComponentModel.ListSortDirection.Ascending);
					var bs_ = context.Operators.FirstOfList<CqlInterval<CqlDateTime>>(br_);
					var bt_ = FHIRHelpers_4_3_000.ToInterval(ModerateOrSevereLVSDHFOutpatientEncounter?.Period);
					var bu_ = context.Operators.OverlapsAfter(bs_, bt_, "day");
					var bv_ = context.Operators.Convert<string>(((Event as MedicationRequest)?.StatusElement)?.Value);
					var bw_ = new string[]
					{
						(string)"active",
						(string)"completed",
					};
					var bx_ = context.Operators.InList<string>(bv_, (bw_ as IEnumerable<string>));
					var by_ = context.Operators.And(bu_, bx_);
					var bz_ = context.Operators.Convert<string>(((Event as MedicationRequest)?.IntentElement)?.Value);
					var ca_ = new string[]
					{
						(string)"order",
						(string)"original-order",
						(string)"reflex-order",
						(string)"filler-order",
						(string)"instance-order",
					};
					var cb_ = context.Operators.InList<string>(bz_, (ca_ as IEnumerable<string>));
					var cc_ = context.Operators.And(by_, cb_);
					var cd_ = context.Operators.IsTrue(((Event as MedicationRequest)?.DoNotPerformElement)?.Value);
					var ce_ = context.Operators.Not(cd_);
					var cf_ = context.Operators.And(cc_, ce_);

					return cf_;
				}
				else if (Event is Observation)
				{
					var ct_ = FHIRHelpers_4_3_000.ToValue((Event as Observation)?.Effective);
					var cu_ = QICoreCommon_2_0_000.toInterval(ct_);
					var cv_ = FHIRHelpers_4_3_000.ToInterval(ModerateOrSevereLVSDHFOutpatientEncounter?.Period);
					var cw_ = context.Operators.OverlapsAfter(cu_, cv_, "day");
					var cx_ = context.Operators.Convert<string>(((Event as Observation)?.StatusElement)?.Value);
					var cy_ = new string[]
					{
						(string)"final",
						(string)"amended",
						(string)"corrected",
					};
					var cz_ = context.Operators.InList<string>(cx_, (cy_ as IEnumerable<string>));
					var da_ = context.Operators.And(cw_, cz_);

					return da_;
				}
				else
				{
					return (bool?)false;
				};
			};

			return e_();
		};
		var c_ = context.Operators.WhereOrNull<Encounter>(a_, b_);
		var d_ = context.Operators.ExistsInList<Encounter>(c_);

		return d_;
	}

}
