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
[System.CodeDom.Compiler.GeneratedCode(".NET Code Generation", "2.0.5.0")]
[CqlLibrary("AHAOverall", "2.6.000")]
public partial class AHAOverall_2_6_000 : ILibrary, ISingleton<AHAOverall_2_6_000>
{
    private AHAOverall_2_6_000() {}

    public static AHAOverall_2_6_000 Instance { get; } = new();

    #region Library Members
    public string Name => "AHAOverall";
    public string Version => "2.6.000";
    public ILibrary[] Dependencies => [FHIRHelpers_4_3_000.Instance, QICoreCommon_2_0_000.Instance];
    #endregion Library Members

    [CqlDeclaration("Care Services in Long Term Residential Facility")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1014")]
	public CqlValueSet Care_Services_in_Long_Term_Residential_Facility(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1014", default);


    [CqlDeclaration("Ejection Fraction")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1134")]
	public CqlValueSet Ejection_Fraction(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1134", default);


    [CqlDeclaration("Heart Failure")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.376")]
	public CqlValueSet Heart_Failure(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.376", default);


    [CqlDeclaration("Heart Transplant")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1178.33")]
	public CqlValueSet Heart_Transplant(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1178.33", default);


    [CqlDeclaration("Heart Transplant Complications")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1178.56")]
	public CqlValueSet Heart_Transplant_Complications(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1178.56", default);


    [CqlDeclaration("Home Healthcare Services")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1016")]
	public CqlValueSet Home_Healthcare_Services(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1016", default);


    [CqlDeclaration("Left Ventricular Assist Device Complications")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1178.58")]
	public CqlValueSet Left_Ventricular_Assist_Device_Complications(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1178.58", default);


    [CqlDeclaration("Left Ventricular Assist Device Placement")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1178.61")]
	public CqlValueSet Left_Ventricular_Assist_Device_Placement(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1178.61", default);


    [CqlDeclaration("Moderate or Severe")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1092")]
	public CqlValueSet Moderate_or_Severe(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1092", default);


    [CqlDeclaration("Moderate or Severe LVSD")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1090")]
	public CqlValueSet Moderate_or_Severe_LVSD(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1090", default);


    [CqlDeclaration("Nursing Facility Visit")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1012")]
	public CqlValueSet Nursing_Facility_Visit(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1012", default);


    [CqlDeclaration("Office Visit")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1001")]
	public CqlValueSet Office_Visit(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1001", default);


    [CqlDeclaration("Outpatient Consultation")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1008")]
	public CqlValueSet Outpatient_Consultation(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1008", default);


    [CqlDeclaration("Patient Provider Interaction")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1012")]
	public CqlValueSet Patient_Provider_Interaction(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1012", default);


    [CqlDeclaration("Left ventricular systolic dysfunction (disorder)")]
	public CqlCode Left_ventricular_systolic_dysfunction__disorder_(CqlContext context) => 
		new CqlCode("134401001", "http://snomed.info/sct", default, default);


    [CqlDeclaration("allergy-entered-in-error")]
	public CqlCode allergy_entered_in_error(CqlContext context) => 
		new CqlCode("entered-in-error", "http://terminology.hl7.org/CodeSystem/allergyintolerance-verification", default, default);


    [CqlDeclaration("SNOMEDCT")]
	public CqlCode[] SNOMEDCT(CqlContext context)
	{
		CqlCode[] a_ = [
			new CqlCode("134401001", "http://snomed.info/sct", default, default),
		];

		return a_;
	}


    [CqlDeclaration("AllergyIntoleranceVerificationStatusCodes")]
	public CqlCode[] AllergyIntoleranceVerificationStatusCodes(CqlContext context)
	{
		CqlCode[] a_ = [
			new CqlCode("entered-in-error", "http://terminology.hl7.org/CodeSystem/allergyintolerance-verification", default, default),
		];

		return a_;
	}


    [CqlDeclaration("Measurement Period")]
	public CqlInterval<CqlDateTime> Measurement_Period(CqlContext context)
	{
		CqlDateTime a_ = context.Operators.DateTime(2025, 1, 1, 0, 0, 0, 0, default);
		CqlDateTime b_ = context.Operators.DateTime(2026, 1, 1, 0, 0, 0, 0, default);
		CqlInterval<CqlDateTime> c_ = context.Operators.Interval(a_, b_, true, false);
		object d_ = context.ResolveParameter("AHAOverall-2.6.000", "Measurement Period", c_);

		return (CqlInterval<CqlDateTime>)d_;
	}


    [CqlDeclaration("Patient")]
	public Patient Patient(CqlContext context)
	{
		IEnumerable<Patient> a_ = context.Operators.RetrieveByValueSet<Patient>(default, default);
		Patient b_ = context.Operators.SingletonFrom<Patient>(a_);

		return b_;
	}

	public bool? isConfirmedActiveDiagnosis(CqlContext context, Condition Condition)
	{
		Condition[] a_ = [
			Condition,
		];
		bool? b_(Condition Diagnosis)
		{
			CodeableConcept f_ = Diagnosis?.ClinicalStatus;
			CqlConcept g_ = FHIRHelpers_4_3_000.Instance.ToConcept(context, f_);
			CqlCode h_ = QICoreCommon_2_0_000.Instance.active(context);
			CqlConcept i_ = context.Operators.ConvertCodeToConcept(h_);
			bool? j_ = context.Operators.Equivalent(g_, i_);
			CodeableConcept k_ = Diagnosis?.VerificationStatus;
			CqlConcept l_ = FHIRHelpers_4_3_000.Instance.ToConcept(context, k_);
			CqlCode m_ = QICoreCommon_2_0_000.Instance.unconfirmed(context);
			CqlConcept n_ = context.Operators.ConvertCodeToConcept(m_);
			bool? o_ = context.Operators.Equivalent(l_, n_);
			CqlConcept q_ = FHIRHelpers_4_3_000.Instance.ToConcept(context, k_);
			CqlCode r_ = QICoreCommon_2_0_000.Instance.refuted(context);
			CqlConcept s_ = context.Operators.ConvertCodeToConcept(r_);
			bool? t_ = context.Operators.Equivalent(q_, s_);
			bool? u_ = context.Operators.Or(o_, t_);
			CqlConcept w_ = FHIRHelpers_4_3_000.Instance.ToConcept(context, k_);
			CqlCode x_ = QICoreCommon_2_0_000.Instance.entered_in_error(context);
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

	public bool? isFinished(CqlContext context, Encounter Visit)
	{
		Code<Encounter.EncounterStatus> a_ = Visit?.StatusElement;
		Encounter.EncounterStatus? b_ = a_?.Value;
		Code<Encounter.EncounterStatus> c_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(b_);
		bool? d_ = context.Operators.Equal(c_, "finished");

		return d_;
	}


    [CqlDeclaration("Heart Failure Outpatient Encounter")]
	public IEnumerable<Encounter> Heart_Failure_Outpatient_Encounter(CqlContext context)
	{
		CqlValueSet a_ = this.Care_Services_in_Long_Term_Residential_Facility(context);
		IEnumerable<Encounter> b_ = context.Operators.RetrieveByValueSet<Encounter>(a_, default);
		CqlValueSet c_ = this.Home_Healthcare_Services(context);
		IEnumerable<Encounter> d_ = context.Operators.RetrieveByValueSet<Encounter>(c_, default);
		IEnumerable<Encounter> e_ = context.Operators.Union<Encounter>(b_, d_);
		CqlValueSet f_ = this.Nursing_Facility_Visit(context);
		IEnumerable<Encounter> g_ = context.Operators.RetrieveByValueSet<Encounter>(f_, default);
		CqlValueSet h_ = this.Office_Visit(context);
		IEnumerable<Encounter> i_ = context.Operators.RetrieveByValueSet<Encounter>(h_, default);
		IEnumerable<Encounter> j_ = context.Operators.Union<Encounter>(g_, i_);
		IEnumerable<Encounter> k_ = context.Operators.Union<Encounter>(e_, j_);
		CqlValueSet l_ = this.Outpatient_Consultation(context);
		IEnumerable<Encounter> m_ = context.Operators.RetrieveByValueSet<Encounter>(l_, default);
		IEnumerable<Encounter> n_ = context.Operators.Union<Encounter>(k_, m_);
		IEnumerable<Encounter> o_(Encounter QualifyingEncounter)
		{
			CqlValueSet s_ = this.Heart_Failure(context);
			IEnumerable<Condition> t_ = context.Operators.RetrieveByValueSet<Condition>(s_, default);
			bool? u_(Condition HeartFailure)
			{
				CqlInterval<CqlDateTime> y_ = QICoreCommon_2_0_000.Instance.prevalenceInterval(context, HeartFailure);
				Period z_ = QualifyingEncounter?.Period;
				CqlInterval<CqlDateTime> aa_ = FHIRHelpers_4_3_000.Instance.ToInterval(context, z_);
				bool? ab_ = context.Operators.Overlaps(y_, aa_, default);
				bool? ac_ = this.isConfirmedActiveDiagnosis(context, HeartFailure);
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
			CqlInterval<CqlDateTime> ae_ = this.Measurement_Period(context);
			Period af_ = QualifyingEncounter?.Period;
			CqlInterval<CqlDateTime> ag_ = FHIRHelpers_4_3_000.Instance.ToInterval(context, af_);
			bool? ah_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(ae_, ag_, default);
			bool? ai_ = this.isFinished(context, QualifyingEncounter);
			bool? aj_ = context.Operators.And(ah_, ai_);

			return aj_;
		};
		IEnumerable<Encounter> r_ = context.Operators.Where<Encounter>(p_, q_);

		return r_;
	}


    [CqlDeclaration("Moderate or Severe LVSD Findings")]
	public IEnumerable<object> Moderate_or_Severe_LVSD_Findings(CqlContext context)
	{
		CqlValueSet a_ = this.Ejection_Fraction(context);
		IEnumerable<Observation> b_ = context.Operators.RetrieveByValueSet<Observation>(a_, default);
		bool? c_(Observation EjectionFraction)
		{
			DataType n_ = EjectionFraction?.Value;
			object o_ = FHIRHelpers_4_3_000.Instance.ToValue(context, n_);
			CqlQuantity p_ = context.Operators.Quantity(40m, "%");
			bool? q_ = context.Operators.LessOrEqual(o_ as CqlQuantity, p_);
			Code<ObservationStatus> r_ = EjectionFraction?.StatusElement;
			ObservationStatus? s_ = r_?.Value;
			Code<ObservationStatus> t_ = context.Operators.Convert<Code<ObservationStatus>>(s_);
			string u_ = context.Operators.Convert<string>(t_);
			string[] v_ = [
				"final",
				"amended",
				"corrected",
			];
			bool? w_ = context.Operators.In<string>(u_, v_ as IEnumerable<string>);
			bool? x_ = context.Operators.And(q_, w_);

			return x_;
		};
		IEnumerable<Observation> d_ = context.Operators.Where<Observation>(b_, c_);
		CqlValueSet e_ = this.Moderate_or_Severe_LVSD(context);
		IEnumerable<Condition> f_ = context.Operators.RetrieveByValueSet<Condition>(e_, default);
		IEnumerable<object> g_ = context.Operators.Union<object>(d_ as IEnumerable<object>, f_ as IEnumerable<object>);
		CqlCode h_ = this.Left_ventricular_systolic_dysfunction__disorder_(context);
		IEnumerable<CqlCode> i_ = context.Operators.ToList<CqlCode>(h_);
		IEnumerable<Condition> j_ = context.Operators.RetrieveByCodes<Condition>(i_, default);
		bool? k_(Condition LVSDDiagnosis)
		{
			CodeableConcept y_ = LVSDDiagnosis?.Severity;
			CqlConcept z_ = FHIRHelpers_4_3_000.Instance.ToConcept(context, y_);
			CqlValueSet aa_ = this.Moderate_or_Severe(context);
			bool? ab_ = context.Operators.ConceptInValueSet(z_, aa_);

			return ab_;
		};
		IEnumerable<Condition> l_ = context.Operators.Where<Condition>(j_, k_);
		IEnumerable<object> m_ = context.Operators.Union<object>(g_ as IEnumerable<object>, l_ as IEnumerable<object>);

		return m_;
	}


    [CqlDeclaration("Heart Failure Outpatient Encounter with History of Moderate or Severe LVSD")]
	public IEnumerable<Encounter> Heart_Failure_Outpatient_Encounter_with_History_of_Moderate_or_Severe_LVSD(CqlContext context)
	{
		IEnumerable<Encounter> a_ = this.Heart_Failure_Outpatient_Encounter(context);
		IEnumerable<Encounter> b_(Encounter HFOutpatientEncounter)
		{
			IEnumerable<object> d_ = this.Moderate_or_Severe_LVSD_Findings(context);
			bool? e_(object LVSDFindings)
			{
				CqlInterval<CqlDateTime> i_ = QICoreCommon_2_0_000.Instance.prevalenceInterval(context, LVSDFindings as Condition);
				object j_ = context.Operators.LateBoundProperty<object>(LVSDFindings, "effective");
				object k_ = FHIRHelpers_4_3_000.Instance.ToValue(context, j_);
				CqlInterval<CqlDateTime> l_ = QICoreCommon_2_0_000.Instance.toInterval(context, k_);
				CqlDateTime m_ = context.Operators.Start(i_ ?? l_);
				Period n_ = HFOutpatientEncounter?.Period;
				CqlInterval<CqlDateTime> o_ = FHIRHelpers_4_3_000.Instance.ToInterval(context, n_);
				CqlDateTime p_ = context.Operators.End(o_);
				bool? q_ = context.Operators.Before(m_, p_, default);

				return q_;
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


    [CqlDeclaration("Has Heart Transplant Complications")]
	public bool? Has_Heart_Transplant_Complications(CqlContext context)
	{
		CqlValueSet a_ = this.Heart_Transplant_Complications(context);
		IEnumerable<Condition> b_ = context.Operators.RetrieveByValueSet<Condition>(a_, default);
		IEnumerable<Condition> c_(Condition HeartTransplantComplications)
		{
			IEnumerable<Encounter> h_ = this.Heart_Failure_Outpatient_Encounter_with_History_of_Moderate_or_Severe_LVSD(context);
			bool? i_(Encounter ModerateOrSevereLVSDHFOutpatientEncounter)
			{
				FhirDateTime m_ = HeartTransplantComplications?.RecordedDateElement;
				CqlDateTime n_ = context.Operators.Convert<CqlDateTime>(m_);
				CqlInterval<CqlDateTime> o_ = QICoreCommon_2_0_000.Instance.toInterval(context, n_ as object);
				CqlInterval<CqlDateTime> p_ = QICoreCommon_2_0_000.Instance.prevalenceInterval(context, HeartTransplantComplications);
				CqlDateTime q_ = context.Operators.Start(o_ ?? p_);
				Period r_ = ModerateOrSevereLVSDHFOutpatientEncounter?.Period;
				CqlInterval<CqlDateTime> s_ = FHIRHelpers_4_3_000.Instance.ToInterval(context, r_);
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
			bool? v_ = this.isConfirmedActiveDiagnosis(context, HeartTransplantComplications);

			return v_;
		};
		IEnumerable<Condition> f_ = context.Operators.Where<Condition>(d_, e_);
		bool? g_ = context.Operators.Exists<Condition>(f_);

		return g_;
	}


    [CqlDeclaration("Has Left Ventricular Assist Device")]
	public bool? Has_Left_Ventricular_Assist_Device(CqlContext context)
	{
		CqlValueSet a_ = this.Left_Ventricular_Assist_Device_Placement(context);
		IEnumerable<Procedure> b_ = context.Operators.RetrieveByValueSet<Procedure>(a_, default);
		IEnumerable<Procedure> c_(Procedure LVADOutpatient)
		{
			IEnumerable<Encounter> h_ = this.Heart_Failure_Outpatient_Encounter_with_History_of_Moderate_or_Severe_LVSD(context);
			bool? i_(Encounter ModerateOrSevereLVSDHFOutpatientEncounter)
			{
				DataType m_ = LVADOutpatient?.Performed;
				object n_ = FHIRHelpers_4_3_000.Instance.ToValue(context, m_);
				CqlInterval<CqlDateTime> o_ = QICoreCommon_2_0_000.Instance.toInterval(context, n_);
				CqlDateTime p_ = context.Operators.Start(o_);
				Period q_ = ModerateOrSevereLVSDHFOutpatientEncounter?.Period;
				CqlInterval<CqlDateTime> r_ = FHIRHelpers_4_3_000.Instance.ToInterval(context, q_);
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


    [CqlDeclaration("Has Left Ventricular Assist Device Complications")]
	public bool? Has_Left_Ventricular_Assist_Device_Complications(CqlContext context)
	{
		CqlValueSet a_ = this.Left_Ventricular_Assist_Device_Complications(context);
		IEnumerable<Condition> b_ = context.Operators.RetrieveByValueSet<Condition>(a_, default);
		IEnumerable<Condition> c_(Condition LVADComplications)
		{
			IEnumerable<Encounter> h_ = this.Heart_Failure_Outpatient_Encounter_with_History_of_Moderate_or_Severe_LVSD(context);
			bool? i_(Encounter ModerateOrSevereLVSDHFOutpatientEncounter)
			{
				FhirDateTime m_ = LVADComplications?.RecordedDateElement;
				CqlDateTime n_ = context.Operators.Convert<CqlDateTime>(m_);
				CqlInterval<CqlDateTime> o_ = QICoreCommon_2_0_000.Instance.toInterval(context, n_ as object);
				CqlInterval<CqlDateTime> p_ = QICoreCommon_2_0_000.Instance.prevalenceInterval(context, LVADComplications);
				CqlDateTime q_ = context.Operators.Start(o_ ?? p_);
				Period r_ = ModerateOrSevereLVSDHFOutpatientEncounter?.Period;
				CqlInterval<CqlDateTime> s_ = FHIRHelpers_4_3_000.Instance.ToInterval(context, r_);
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
			bool? v_ = this.isConfirmedActiveDiagnosis(context, LVADComplications);

			return v_;
		};
		IEnumerable<Condition> f_ = context.Operators.Where<Condition>(d_, e_);
		bool? g_ = context.Operators.Exists<Condition>(f_);

		return g_;
	}


    [CqlDeclaration("Qualifying Outpatient Encounter During Measurement Period")]
	public IEnumerable<Encounter> Qualifying_Outpatient_Encounter_During_Measurement_Period(CqlContext context)
	{
		CqlValueSet a_ = this.Care_Services_in_Long_Term_Residential_Facility(context);
		IEnumerable<Encounter> b_ = context.Operators.RetrieveByValueSet<Encounter>(a_, default);
		CqlValueSet c_ = this.Home_Healthcare_Services(context);
		IEnumerable<Encounter> d_ = context.Operators.RetrieveByValueSet<Encounter>(c_, default);
		IEnumerable<Encounter> e_ = context.Operators.Union<Encounter>(b_, d_);
		CqlValueSet f_ = this.Nursing_Facility_Visit(context);
		IEnumerable<Encounter> g_ = context.Operators.RetrieveByValueSet<Encounter>(f_, default);
		CqlValueSet h_ = this.Office_Visit(context);
		IEnumerable<Encounter> i_ = context.Operators.RetrieveByValueSet<Encounter>(h_, default);
		IEnumerable<Encounter> j_ = context.Operators.Union<Encounter>(g_, i_);
		IEnumerable<Encounter> k_ = context.Operators.Union<Encounter>(e_, j_);
		CqlValueSet l_ = this.Outpatient_Consultation(context);
		IEnumerable<Encounter> m_ = context.Operators.RetrieveByValueSet<Encounter>(l_, default);
		CqlValueSet n_ = this.Patient_Provider_Interaction(context);
		IEnumerable<Encounter> o_ = context.Operators.RetrieveByValueSet<Encounter>(n_, default);
		IEnumerable<Encounter> p_ = context.Operators.Union<Encounter>(m_, o_);
		IEnumerable<Encounter> q_ = context.Operators.Union<Encounter>(k_, p_);
		bool? r_(Encounter ValidEncounter)
		{
			CqlInterval<CqlDateTime> t_ = this.Measurement_Period(context);
			Period u_ = ValidEncounter?.Period;
			CqlInterval<CqlDateTime> v_ = FHIRHelpers_4_3_000.Instance.ToInterval(context, u_);
			bool? w_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(t_, v_, default);
			bool? x_ = this.isFinished(context, ValidEncounter);
			bool? y_ = context.Operators.And(w_, x_);

			return y_;
		};
		IEnumerable<Encounter> s_ = context.Operators.Where<Encounter>(q_, r_);

		return s_;
	}


    [CqlDeclaration("Has Two Qualifying Outpatient Encounters and Heart Failure Outpatient Encounter During the Measurement Period")]
	public bool? Has_Two_Qualifying_Outpatient_Encounters_and_Heart_Failure_Outpatient_Encounter_During_the_Measurement_Period(CqlContext context)
	{
		Patient a_ = this.Patient(context);
		Date b_ = a_?.BirthDateElement;
		string c_ = b_?.Value;
		CqlDate d_ = context.Operators.ConvertStringToDate(c_);
		CqlInterval<CqlDateTime> e_ = this.Measurement_Period(context);
		CqlDateTime f_ = context.Operators.Start(e_);
		CqlDate g_ = context.Operators.DateFrom(f_);
		int? h_ = context.Operators.CalculateAgeAt(d_, g_, "year");
		bool? i_ = context.Operators.GreaterOrEqual(h_, 18);
		IEnumerable<Encounter> j_ = this.Qualifying_Outpatient_Encounter_During_Measurement_Period(context);
		IEnumerable<Encounter> k_(Encounter Encounter1)
		{
			IEnumerable<Encounter> r_ = this.Qualifying_Outpatient_Encounter_During_Measurement_Period(context);
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
		IEnumerable<Encounter> o_ = this.Heart_Failure_Outpatient_Encounter(context);
		bool? p_ = context.Operators.Exists<Encounter>(o_);
		bool? q_ = context.Operators.And(n_, p_);

		return q_;
	}


    [CqlDeclaration("Has Heart Transplant")]
	public bool? Has_Heart_Transplant(CqlContext context)
	{
		CqlValueSet a_ = this.Heart_Transplant(context);
		IEnumerable<Procedure> b_ = context.Operators.RetrieveByValueSet<Procedure>(a_, default);
		IEnumerable<Procedure> c_(Procedure HeartTransplant)
		{
			IEnumerable<Encounter> h_ = this.Heart_Failure_Outpatient_Encounter_with_History_of_Moderate_or_Severe_LVSD(context);
			bool? i_(Encounter ModerateOrSevereLVSDHFOutpatientEncounter)
			{
				DataType m_ = HeartTransplant?.Performed;
				object n_ = FHIRHelpers_4_3_000.Instance.ToValue(context, m_);
				CqlInterval<CqlDateTime> o_ = QICoreCommon_2_0_000.Instance.toInterval(context, n_);
				CqlDateTime p_ = context.Operators.Start(o_);
				Period q_ = ModerateOrSevereLVSDHFOutpatientEncounter?.Period;
				CqlInterval<CqlDateTime> r_ = FHIRHelpers_4_3_000.Instance.ToInterval(context, q_);
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

	public bool? isOrderedDuringHeartFailureOutpatientEncounter(CqlContext context, MedicationRequest Order)
	{
		IEnumerable<Encounter> a_ = this.Heart_Failure_Outpatient_Encounter_with_History_of_Moderate_or_Severe_LVSD(context);
		bool? b_(Encounter ModerateOrSevereLVSDHFOutpatientEncounter)
		{
			FhirDateTime e_ = Order?.AuthoredOnElement;
			CqlDateTime f_ = context.Operators.Convert<CqlDateTime>(e_);
			Period g_ = ModerateOrSevereLVSDHFOutpatientEncounter?.Period;
			CqlInterval<CqlDateTime> h_ = FHIRHelpers_4_3_000.Instance.ToInterval(context, g_);
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

	public bool? overlapsHeartFailureOutpatientEncounter(CqlContext context, Condition Diagnosis)
	{
		IEnumerable<Encounter> a_ = this.Heart_Failure_Outpatient_Encounter_with_History_of_Moderate_or_Severe_LVSD(context);
		bool? b_(Encounter ModerateOrSevereLVSDHFOutpatientEncounter)
		{
			CqlInterval<CqlDateTime> e_ = QICoreCommon_2_0_000.Instance.prevalenceInterval(context, Diagnosis);
			Period f_ = ModerateOrSevereLVSDHFOutpatientEncounter?.Period;
			CqlInterval<CqlDateTime> g_ = FHIRHelpers_4_3_000.Instance.ToInterval(context, f_);
			bool? h_ = context.Operators.Overlaps(e_, g_, "day");
			bool? i_ = this.isConfirmedActiveDiagnosis(context, Diagnosis);
			bool? j_ = context.Operators.And(h_, i_);

			return j_;
		};
		IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);
		bool? d_ = context.Operators.Exists<Encounter>(c_);

		return d_;
	}

	public bool? overlapsAfterHeartFailureOutpatientEncounter(CqlContext context, object Event)
	{
		IEnumerable<Encounter> a_ = this.Heart_Failure_Outpatient_Encounter_with_History_of_Moderate_or_Severe_LVSD(context);
		bool? b_(Encounter ModerateOrSevereLVSDHFOutpatientEncounter)
		{
			bool? e_()
			{
				if (Event is Condition)
				{
					CqlInterval<CqlDateTime> f_ = QICoreCommon_2_0_000.Instance.prevalenceInterval(context, Event as Condition);
					Period g_ = ModerateOrSevereLVSDHFOutpatientEncounter?.Period;
					CqlInterval<CqlDateTime> h_ = FHIRHelpers_4_3_000.Instance.ToInterval(context, g_);
					bool? i_ = context.Operators.OverlapsAfter(f_, h_, "day");
					bool? j_ = this.isConfirmedActiveDiagnosis(context, Event as Condition);
					bool? k_ = context.Operators.And(i_, j_);

					return k_;
				}
				else if (Event is Procedure)
				{
					DataType l_ = (Event as Procedure)?.Performed;
					object m_ = FHIRHelpers_4_3_000.Instance.ToValue(context, l_);
					CqlInterval<CqlDateTime> n_ = QICoreCommon_2_0_000.Instance.toInterval(context, m_);
					Period o_ = ModerateOrSevereLVSDHFOutpatientEncounter?.Period;
					CqlInterval<CqlDateTime> p_ = FHIRHelpers_4_3_000.Instance.ToInterval(context, o_);
					bool? q_ = context.Operators.OverlapsAfter(n_, p_, "day");
					Code<EventStatus> r_ = (Event as Procedure)?.StatusElement;
					EventStatus? s_ = r_?.Value;
					string t_ = context.Operators.Convert<string>(s_);
					bool? u_ = context.Operators.Equal(t_, "completed");
					bool? v_ = context.Operators.And(q_, u_);

					return v_;
				}
				else if (Event is AllergyIntolerance)
				{
					DataType w_ = (Event as AllergyIntolerance)?.Onset;
					object x_ = FHIRHelpers_4_3_000.Instance.ToValue(context, w_);
					CqlInterval<CqlDateTime> y_ = QICoreCommon_2_0_000.Instance.toInterval(context, x_);
					CqlDateTime z_ = context.Operators.Start(y_);
					FhirDateTime aa_ = (Event as AllergyIntolerance)?.LastOccurrenceElement;
					CqlDateTime ab_ = context.Operators.Convert<CqlDateTime>(aa_);
					CqlInterval<CqlDateTime> ac_ = context.Operators.Interval(z_, ab_, true, true);
					Period ad_ = ModerateOrSevereLVSDHFOutpatientEncounter?.Period;
					CqlInterval<CqlDateTime> ae_ = FHIRHelpers_4_3_000.Instance.ToInterval(context, ad_);
					bool? af_ = context.Operators.OverlapsAfter(ac_, ae_, "day");
					CodeableConcept ag_ = (Event as AllergyIntolerance)?.ClinicalStatus;
					CqlConcept ah_ = FHIRHelpers_4_3_000.Instance.ToConcept(context, ag_);
					CqlCode ai_ = QICoreCommon_2_0_000.Instance.allergy_active(context);
					CqlConcept aj_ = context.Operators.ConvertCodeToConcept(ai_);
					bool? ak_ = context.Operators.Equivalent(ah_, aj_);
					bool? al_ = context.Operators.And(af_, ak_);
					CodeableConcept am_ = (Event as AllergyIntolerance)?.VerificationStatus;
					CqlConcept an_ = FHIRHelpers_4_3_000.Instance.ToConcept(context, am_);
					CqlCode ao_ = QICoreCommon_2_0_000.Instance.allergy_unconfirmed(context);
					CqlConcept ap_ = context.Operators.ConvertCodeToConcept(ao_);
					bool? aq_ = context.Operators.Equivalent(an_, ap_);
					CqlConcept as_ = FHIRHelpers_4_3_000.Instance.ToConcept(context, am_);
					CqlCode at_ = QICoreCommon_2_0_000.Instance.allergy_refuted(context);
					CqlConcept au_ = context.Operators.ConvertCodeToConcept(at_);
					bool? av_ = context.Operators.Equivalent(as_, au_);
					bool? aw_ = context.Operators.Or(aq_, av_);
					CqlConcept ay_ = FHIRHelpers_4_3_000.Instance.ToConcept(context, am_);
					CqlCode az_ = this.allergy_entered_in_error(context);
					CqlConcept ba_ = context.Operators.ConvertCodeToConcept(az_);
					bool? bb_ = context.Operators.Equivalent(ay_, ba_);
					bool? bc_ = context.Operators.Or(aw_, bb_);
					bool? bd_ = context.Operators.Not(bc_);
					bool? be_ = context.Operators.And(al_, bd_);

					return be_;
				}
				else if (Event is MedicationRequest)
				{
					object bf_ = context.Operators.LateBoundProperty<object>(Event, "dosageInstruction");
					object[] bg_ = [
						bf_,
					];
					bool? bh_(object @this)
					{
						object cz_ = context.Operators.LateBoundProperty<object>(@this, "timing");
						bool? da_ = context.Operators.Not((bool?)(cz_ is null));

						return da_;
					};
					IEnumerable<object> bi_ = context.Operators.Where<object>((IEnumerable<object>)bg_, bh_);
					object bj_(object @this)
					{
						object db_ = context.Operators.LateBoundProperty<object>(@this, "timing");

						return db_;
					};
					IEnumerable<object> bk_ = context.Operators.Select<object, object>(bi_, bj_);
					object bl_ = context.Operators.SingletonFrom<object>(bk_);
					object[] bm_ = [
						bl_,
					];
					bool? bn_(object @this)
					{
						object dc_ = context.Operators.LateBoundProperty<object>(@this, "repeat");
						bool? dd_ = context.Operators.Not((bool?)(dc_ is null));

						return dd_;
					};
					IEnumerable<object> bo_ = context.Operators.Where<object>((IEnumerable<object>)bm_, bn_);
					object bp_(object @this)
					{
						object de_ = context.Operators.LateBoundProperty<object>(@this, "repeat");

						return de_;
					};
					IEnumerable<object> bq_ = context.Operators.Select<object, object>(bo_, bp_);
					object br_ = context.Operators.SingletonFrom<object>(bq_);
					object[] bs_ = [
						br_,
					];
					bool? bt_(object @this)
					{
						object df_ = context.Operators.LateBoundProperty<object>(@this, "bounds");
						object dg_ = FHIRHelpers_4_3_000.Instance.ToValue(context, df_);
						bool? dh_ = context.Operators.Not((bool?)(dg_ is null));

						return dh_;
					};
					IEnumerable<object> bu_ = context.Operators.Where<object>((IEnumerable<object>)bs_, bt_);
					object bv_(object @this)
					{
						object di_ = context.Operators.LateBoundProperty<object>(@this, "bounds");
						object dj_ = FHIRHelpers_4_3_000.Instance.ToValue(context, di_);

						return dj_;
					};
					IEnumerable<object> bw_ = context.Operators.Select<object, object>(bu_, bv_);
					object bx_ = context.Operators.SingletonFrom<object>(bw_);
					object[] by_ = [
						bx_,
					];
					CqlInterval<CqlDateTime> bz_(object DoseTime)
					{
						CqlInterval<CqlDateTime> dk_ = QICoreCommon_2_0_000.Instance.toInterval(context, DoseTime);

						return dk_;
					};
					IEnumerable<CqlInterval<CqlDateTime>> ca_ = context.Operators.Select<object, CqlInterval<CqlDateTime>>((IEnumerable<object>)by_, bz_);
					IEnumerable<CqlInterval<CqlDateTime>> cb_ = context.Operators.Collapse(ca_, default);
					object cc_(CqlInterval<CqlDateTime> @this)
					{
						CqlDateTime dl_ = context.Operators.Start(@this);

						return dl_;
					};
					IEnumerable<CqlInterval<CqlDateTime>> cd_ = context.Operators.SortBy<CqlInterval<CqlDateTime>>(cb_, cc_, System.ComponentModel.ListSortDirection.Ascending);
					CqlInterval<CqlDateTime> ce_ = context.Operators.First<CqlInterval<CqlDateTime>>(cd_);
					Period cf_ = ModerateOrSevereLVSDHFOutpatientEncounter?.Period;
					CqlInterval<CqlDateTime> cg_ = FHIRHelpers_4_3_000.Instance.ToInterval(context, cf_);
					bool? ch_ = context.Operators.OverlapsAfter(ce_, cg_, "day");
					Code<MedicationRequest.MedicationrequestStatus> ci_ = (Event as MedicationRequest)?.StatusElement;
					MedicationRequest.MedicationrequestStatus? cj_ = ci_?.Value;
					string ck_ = context.Operators.Convert<string>(cj_);
					string[] cl_ = [
						"active",
						"completed",
					];
					bool? cm_ = context.Operators.In<string>(ck_, cl_ as IEnumerable<string>);
					bool? cn_ = context.Operators.And(ch_, cm_);
					Code<MedicationRequest.MedicationRequestIntent> co_ = (Event as MedicationRequest)?.IntentElement;
					MedicationRequest.MedicationRequestIntent? cp_ = co_?.Value;
					string cq_ = context.Operators.Convert<string>(cp_);
					string[] cr_ = [
						"order",
						"original-order",
						"reflex-order",
						"filler-order",
						"instance-order",
					];
					bool? cs_ = context.Operators.In<string>(cq_, cr_ as IEnumerable<string>);
					bool? ct_ = context.Operators.And(cn_, cs_);
					FhirBoolean cu_ = (Event as MedicationRequest)?.DoNotPerformElement;
					bool? cv_ = cu_?.Value;
					bool? cw_ = context.Operators.IsTrue(cv_);
					bool? cx_ = context.Operators.Not(cw_);
					bool? cy_ = context.Operators.And(ct_, cx_);

					return cy_;
				}
				else if (Event is Observation)
				{
					DataType dm_ = (Event as Observation)?.Effective;
					object dn_ = FHIRHelpers_4_3_000.Instance.ToValue(context, dm_);
					CqlInterval<CqlDateTime> do_ = QICoreCommon_2_0_000.Instance.toInterval(context, dn_);
					Period dp_ = ModerateOrSevereLVSDHFOutpatientEncounter?.Period;
					CqlInterval<CqlDateTime> dq_ = FHIRHelpers_4_3_000.Instance.ToInterval(context, dp_);
					bool? dr_ = context.Operators.OverlapsAfter(do_, dq_, "day");
					Code<ObservationStatus> ds_ = (Event as Observation)?.StatusElement;
					ObservationStatus? dt_ = ds_?.Value;
					string du_ = context.Operators.Convert<string>(dt_);
					string[] dv_ = [
						"final",
						"amended",
						"corrected",
					];
					bool? dw_ = context.Operators.In<string>(du_, dv_ as IEnumerable<string>);
					bool? dx_ = context.Operators.And(dr_, dw_);

					return dx_;
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
