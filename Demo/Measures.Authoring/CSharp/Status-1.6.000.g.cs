using System;
using System.Linq;
using System.Collections.Generic;
using Hl7.Cql.Runtime;
using Hl7.Cql.Primitives;
using Hl7.Cql.Abstractions;
using Hl7.Cql.ValueSets;
using Hl7.Cql.Iso8601;
using System.Reflection;
using Hl7.Cql.Operators;
using Hl7.Fhir.Model;
using Range = Hl7.Fhir.Model.Range;
using Task = Hl7.Fhir.Model.Task;
[System.CodeDom.Compiler.GeneratedCode(".NET Code Generation", "2.0.4.0")]
[CqlLibrary("Status", "1.6.000")]
public class Status_1_6_000
{


    internal CqlContext context;

    #region Cached values

    internal Lazy<CqlCode> __laboratory;
    internal Lazy<CqlCode> __exam;
    internal Lazy<CqlCode> __survey;
    internal Lazy<CqlCode> __vital_signs;
    internal Lazy<CqlCode> __active;
    internal Lazy<CqlCode[]> __ObservationCategoryCodes;
    internal Lazy<CqlCode[]> __ConditionClinicalStatusCodes;
    internal Lazy<Patient> __Patient;

    #endregion
    public Status_1_6_000(CqlContext context)
    {
        this.context = context ?? throw new ArgumentNullException("context");

        FHIRHelpers_4_3_000 = new FHIRHelpers_4_3_000(context);

        __laboratory = new Lazy<CqlCode>(this.laboratory_Value);
        __exam = new Lazy<CqlCode>(this.exam_Value);
        __survey = new Lazy<CqlCode>(this.survey_Value);
        __vital_signs = new Lazy<CqlCode>(this.vital_signs_Value);
        __active = new Lazy<CqlCode>(this.active_Value);
        __ObservationCategoryCodes = new Lazy<CqlCode[]>(this.ObservationCategoryCodes_Value);
        __ConditionClinicalStatusCodes = new Lazy<CqlCode[]>(this.ConditionClinicalStatusCodes_Value);
        __Patient = new Lazy<Patient>(this.Patient_Value);
    }
    #region Dependencies

    public FHIRHelpers_4_3_000 FHIRHelpers_4_3_000 { get; }

    #endregion

	private CqlCode laboratory_Value() => 
		new CqlCode("laboratory", "http://terminology.hl7.org/CodeSystem/observation-category", default, default);

    [CqlDeclaration("laboratory")]
	public CqlCode laboratory() => 
		__laboratory.Value;

	private CqlCode exam_Value() => 
		new CqlCode("exam", "http://terminology.hl7.org/CodeSystem/observation-category", default, default);

    [CqlDeclaration("exam")]
	public CqlCode exam() => 
		__exam.Value;

	private CqlCode survey_Value() => 
		new CqlCode("survey", "http://terminology.hl7.org/CodeSystem/observation-category", default, default);

    [CqlDeclaration("survey")]
	public CqlCode survey() => 
		__survey.Value;

	private CqlCode vital_signs_Value() => 
		new CqlCode("vital-signs", "http://terminology.hl7.org/CodeSystem/observation-category", default, default);

    [CqlDeclaration("vital-signs")]
	public CqlCode vital_signs() => 
		__vital_signs.Value;

	private CqlCode active_Value() => 
		new CqlCode("active", "http://terminology.hl7.org/CodeSystem/condition-clinical", default, default);

    [CqlDeclaration("active")]
	public CqlCode active() => 
		__active.Value;

	private CqlCode[] ObservationCategoryCodes_Value()
	{
		CqlCode[] a_ = [
			new CqlCode("laboratory", "http://terminology.hl7.org/CodeSystem/observation-category", default, default),
			new CqlCode("exam", "http://terminology.hl7.org/CodeSystem/observation-category", default, default),
			new CqlCode("survey", "http://terminology.hl7.org/CodeSystem/observation-category", default, default),
			new CqlCode("vital-signs", "http://terminology.hl7.org/CodeSystem/observation-category", default, default),
		];

		return a_;
	}

    [CqlDeclaration("ObservationCategoryCodes")]
	public CqlCode[] ObservationCategoryCodes() => 
		__ObservationCategoryCodes.Value;

	private CqlCode[] ConditionClinicalStatusCodes_Value()
	{
		CqlCode[] a_ = [
			new CqlCode("active", "http://terminology.hl7.org/CodeSystem/condition-clinical", default, default),
		];

		return a_;
	}

    [CqlDeclaration("ConditionClinicalStatusCodes")]
	public CqlCode[] ConditionClinicalStatusCodes() => 
		__ConditionClinicalStatusCodes.Value;

	private Patient Patient_Value()
	{
		IEnumerable<Patient> a_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-patient"));
		Patient b_ = context.Operators.SingletonFrom<Patient>(a_);

		return b_;
	}

    [CqlDeclaration("Patient")]
	public Patient Patient() => 
		__Patient.Value;

    [CqlDeclaration("Final Survey Observation")]
	public IEnumerable<Observation> Final_Survey_Observation(IEnumerable<Observation> Obs)
	{
		bool? a_(Observation O)
		{
			Code<ObservationStatus> c_ = O?.StatusElement;
			ObservationStatus? d_ = c_?.Value;
			Code<ObservationStatus> e_ = context.Operators.Convert<Code<ObservationStatus>>(d_);
			string f_ = context.Operators.Convert<string>(e_);
			string[] g_ = [
				"final",
				"amended",
				"corrected",
			];
			bool? h_ = context.Operators.In<string>(f_, g_ as IEnumerable<string>);
			List<CodeableConcept> i_ = O?.Category;
			CqlConcept j_(CodeableConcept @this)
			{
				CqlConcept p_ = FHIRHelpers_4_3_000.ToConcept(@this);

				return p_;
			};
			IEnumerable<CqlConcept> k_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)i_, j_);
			bool? l_(CqlConcept ObservationCategory)
			{
				CqlCode q_ = this.survey();
				CqlConcept r_ = context.Operators.ConvertCodeToConcept(q_);
				bool? s_ = context.Operators.Equivalent(ObservationCategory, r_);

				return s_;
			};
			IEnumerable<CqlConcept> m_ = context.Operators.Where<CqlConcept>(k_, l_);
			bool? n_ = context.Operators.Exists<CqlConcept>(m_);
			bool? o_ = context.Operators.And(h_, n_);

			return o_;
		};
		IEnumerable<Observation> b_ = context.Operators.Where<Observation>(Obs, a_);

		return b_;
	}

    [CqlDeclaration("isAssessmentPerformed")]
	public IEnumerable<Observation> isAssessmentPerformed(IEnumerable<Observation> Obs)
	{
		bool? a_(Observation O)
		{
			Code<ObservationStatus> c_ = O?.StatusElement;
			ObservationStatus? d_ = c_?.Value;
			Code<ObservationStatus> e_ = context.Operators.Convert<Code<ObservationStatus>>(d_);
			string f_ = context.Operators.Convert<string>(e_);
			string[] g_ = [
				"final",
				"amended",
				"corrected",
			];
			bool? h_ = context.Operators.In<string>(f_, g_ as IEnumerable<string>);
			List<CodeableConcept> i_ = O?.Category;
			CqlConcept j_(CodeableConcept @this)
			{
				CqlConcept p_ = FHIRHelpers_4_3_000.ToConcept(@this);

				return p_;
			};
			IEnumerable<CqlConcept> k_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)i_, j_);
			bool? l_(CqlConcept ObservationCategory)
			{
				CqlCode q_ = this.survey();
				CqlConcept r_ = context.Operators.ConvertCodeToConcept(q_);
				bool? s_ = context.Operators.Equivalent(ObservationCategory, r_);

				return s_;
			};
			IEnumerable<CqlConcept> m_ = context.Operators.Where<CqlConcept>(k_, l_);
			bool? n_ = context.Operators.Exists<CqlConcept>(m_);
			bool? o_ = context.Operators.And(h_, n_);

			return o_;
		};
		IEnumerable<Observation> b_ = context.Operators.Where<Observation>(Obs, a_);

		return b_;
	}

    [CqlDeclaration("Active Condition")]
	public IEnumerable<Condition> Active_Condition(IEnumerable<Condition> Condition)
	{
		bool? a_(Condition C)
		{
			CodeableConcept c_ = C?.ClinicalStatus;
			CqlConcept d_ = FHIRHelpers_4_3_000.ToConcept(c_);
			CqlCode e_ = this.active();
			CqlConcept f_ = context.Operators.ConvertCodeToConcept(e_);
			bool? g_ = context.Operators.Equivalent(d_, f_);

			return g_;
		};
		IEnumerable<Condition> b_ = context.Operators.Where<Condition>(Condition, a_);

		return b_;
	}

    [CqlDeclaration("isActiveOnly")]
	public IEnumerable<Condition> isActiveOnly(IEnumerable<Condition> Condition)
	{
		bool? a_(Condition C)
		{
			CodeableConcept c_ = C?.ClinicalStatus;
			CqlConcept d_ = FHIRHelpers_4_3_000.ToConcept(c_);
			CqlCode e_ = this.active();
			CqlConcept f_ = context.Operators.ConvertCodeToConcept(e_);
			bool? g_ = context.Operators.Equivalent(d_, f_);

			return g_;
		};
		IEnumerable<Condition> b_ = context.Operators.Where<Condition>(Condition, a_);

		return b_;
	}

    [CqlDeclaration("Completed or Ongoing Device Request")]
	public IEnumerable<DeviceRequest> Completed_or_Ongoing_Device_Request(IEnumerable<DeviceRequest> DeviceRequest)
	{
		bool? a_(DeviceRequest D)
		{
			Code<RequestStatus> c_ = D?.StatusElement;
			RequestStatus? d_ = c_?.Value;
			Code<RequestStatus> e_ = context.Operators.Convert<Code<RequestStatus>>(d_);
			string f_ = context.Operators.Convert<string>(e_);
			string[] g_ = [
				"active",
				"completed",
			];
			bool? h_ = context.Operators.In<string>(f_, g_ as IEnumerable<string>);
			Code<RequestIntent> i_ = D?.IntentElement;
			RequestIntent? j_ = i_?.Value;
			Code<RequestIntent> k_ = context.Operators.Convert<Code<RequestIntent>>(j_);
			bool? l_ = context.Operators.Equal(k_, "order");
			bool? m_ = context.Operators.And(h_, l_);

			return m_;
		};
		IEnumerable<DeviceRequest> b_ = context.Operators.Where<DeviceRequest>(DeviceRequest, a_);

		return b_;
	}

    [CqlDeclaration("isDeviceOrder")]
	public IEnumerable<DeviceRequest> isDeviceOrder(IEnumerable<DeviceRequest> DeviceRequest)
	{
		bool? a_(DeviceRequest D)
		{
			Code<RequestStatus> c_ = D?.StatusElement;
			RequestStatus? d_ = c_?.Value;
			Code<RequestStatus> e_ = context.Operators.Convert<Code<RequestStatus>>(d_);
			string f_ = context.Operators.Convert<string>(e_);
			string[] g_ = [
				"active",
				"completed",
			];
			bool? h_ = context.Operators.In<string>(f_, g_ as IEnumerable<string>);
			Code<RequestIntent> i_ = D?.IntentElement;
			RequestIntent? j_ = i_?.Value;
			Code<RequestIntent> k_ = context.Operators.Convert<Code<RequestIntent>>(j_);
			bool? l_ = context.Operators.Equal(k_, "order");
			bool? m_ = context.Operators.And(h_, l_);

			return m_;
		};
		IEnumerable<DeviceRequest> b_ = context.Operators.Where<DeviceRequest>(DeviceRequest, a_);

		return b_;
	}

    [CqlDeclaration("Completed or Ongoing Service Request")]
	public IEnumerable<ServiceRequest> Completed_or_Ongoing_Service_Request(IEnumerable<ServiceRequest> ServiceRequest)
	{
		bool? a_(ServiceRequest S)
		{
			Code<RequestStatus> c_ = S?.StatusElement;
			RequestStatus? d_ = c_?.Value;
			Code<RequestStatus> e_ = context.Operators.Convert<Code<RequestStatus>>(d_);
			string f_ = context.Operators.Convert<string>(e_);
			string[] g_ = [
				"active",
				"completed",
			];
			bool? h_ = context.Operators.In<string>(f_, g_ as IEnumerable<string>);
			Code<RequestIntent> i_ = S?.IntentElement;
			RequestIntent? j_ = i_?.Value;
			Code<RequestIntent> k_ = context.Operators.Convert<Code<RequestIntent>>(j_);
			bool? l_ = context.Operators.Equal(k_, "order");
			bool? m_ = context.Operators.And(h_, l_);

			return m_;
		};
		IEnumerable<ServiceRequest> b_ = context.Operators.Where<ServiceRequest>(ServiceRequest, a_);

		return b_;
	}

    [CqlDeclaration("isDiagnosticStudyOrder")]
	public IEnumerable<ServiceRequest> isDiagnosticStudyOrder(IEnumerable<ServiceRequest> ServiceRequest)
	{
		bool? a_(ServiceRequest S)
		{
			Code<RequestStatus> c_ = S?.StatusElement;
			RequestStatus? d_ = c_?.Value;
			Code<RequestStatus> e_ = context.Operators.Convert<Code<RequestStatus>>(d_);
			string f_ = context.Operators.Convert<string>(e_);
			string[] g_ = [
				"active",
				"completed",
			];
			bool? h_ = context.Operators.In<string>(f_, g_ as IEnumerable<string>);
			Code<RequestIntent> i_ = S?.IntentElement;
			RequestIntent? j_ = i_?.Value;
			Code<RequestIntent> k_ = context.Operators.Convert<Code<RequestIntent>>(j_);
			bool? l_ = context.Operators.Equal(k_, "order");
			bool? m_ = context.Operators.And(h_, l_);

			return m_;
		};
		IEnumerable<ServiceRequest> b_ = context.Operators.Where<ServiceRequest>(ServiceRequest, a_);

		return b_;
	}

    [CqlDeclaration("isInterventionOrder")]
	public IEnumerable<ServiceRequest> isInterventionOrder(IEnumerable<ServiceRequest> ServiceRequest)
	{
		bool? a_(ServiceRequest S)
		{
			Code<RequestStatus> c_ = S?.StatusElement;
			RequestStatus? d_ = c_?.Value;
			Code<RequestStatus> e_ = context.Operators.Convert<Code<RequestStatus>>(d_);
			string f_ = context.Operators.Convert<string>(e_);
			string[] g_ = [
				"active",
				"completed",
			];
			bool? h_ = context.Operators.In<string>(f_, g_ as IEnumerable<string>);
			Code<RequestIntent> i_ = S?.IntentElement;
			RequestIntent? j_ = i_?.Value;
			Code<RequestIntent> k_ = context.Operators.Convert<Code<RequestIntent>>(j_);
			bool? l_ = context.Operators.Equal(k_, "order");
			bool? m_ = context.Operators.And(h_, l_);

			return m_;
		};
		IEnumerable<ServiceRequest> b_ = context.Operators.Where<ServiceRequest>(ServiceRequest, a_);

		return b_;
	}

    [CqlDeclaration("isLaboratoryTestOrder")]
	public IEnumerable<ServiceRequest> isLaboratoryTestOrder(IEnumerable<ServiceRequest> ServiceRequest)
	{
		bool? a_(ServiceRequest S)
		{
			Code<RequestStatus> c_ = S?.StatusElement;
			RequestStatus? d_ = c_?.Value;
			Code<RequestStatus> e_ = context.Operators.Convert<Code<RequestStatus>>(d_);
			string f_ = context.Operators.Convert<string>(e_);
			string[] g_ = [
				"active",
				"completed",
			];
			bool? h_ = context.Operators.In<string>(f_, g_ as IEnumerable<string>);
			Code<RequestIntent> i_ = S?.IntentElement;
			RequestIntent? j_ = i_?.Value;
			Code<RequestIntent> k_ = context.Operators.Convert<Code<RequestIntent>>(j_);
			bool? l_ = context.Operators.Equal(k_, "order");
			bool? m_ = context.Operators.And(h_, l_);

			return m_;
		};
		IEnumerable<ServiceRequest> b_ = context.Operators.Where<ServiceRequest>(ServiceRequest, a_);

		return b_;
	}

    [CqlDeclaration("Final Observation")]
	public IEnumerable<Observation> Final_Observation(IEnumerable<Observation> Obs)
	{
		bool? a_(Observation O)
		{
			Code<ObservationStatus> c_ = O?.StatusElement;
			ObservationStatus? d_ = c_?.Value;
			Code<ObservationStatus> e_ = context.Operators.Convert<Code<ObservationStatus>>(d_);
			string f_ = context.Operators.Convert<string>(e_);
			string[] g_ = [
				"final",
				"amended",
				"corrected",
			];
			bool? h_ = context.Operators.In<string>(f_, g_ as IEnumerable<string>);

			return h_;
		};
		IEnumerable<Observation> b_ = context.Operators.Where<Observation>(Obs, a_);

		return b_;
	}

    [CqlDeclaration("isDiagnosticStudyPerformed")]
	public IEnumerable<Observation> isDiagnosticStudyPerformed(IEnumerable<Observation> Obs)
	{
		bool? a_(Observation O)
		{
			Code<ObservationStatus> c_ = O?.StatusElement;
			ObservationStatus? d_ = c_?.Value;
			Code<ObservationStatus> e_ = context.Operators.Convert<Code<ObservationStatus>>(d_);
			string f_ = context.Operators.Convert<string>(e_);
			string[] g_ = [
				"final",
				"amended",
				"corrected",
			];
			bool? h_ = context.Operators.In<string>(f_, g_ as IEnumerable<string>);

			return h_;
		};
		IEnumerable<Observation> b_ = context.Operators.Where<Observation>(Obs, a_);

		return b_;
	}

    [CqlDeclaration("Finished Encounter")]
	public IEnumerable<Encounter> Finished_Encounter(IEnumerable<Encounter> Enc)
	{
		bool? a_(Encounter E)
		{
			Code<Encounter.EncounterStatus> c_ = E?.StatusElement;
			Encounter.EncounterStatus? d_ = c_?.Value;
			Code<Encounter.EncounterStatus> e_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(d_);
			string f_ = context.Operators.Convert<string>(e_);
			string[] g_ = [
				"finished",
				"arrived",
				"triaged",
				"in-progress",
				"onleave",
			];
			bool? h_ = context.Operators.In<string>(f_, g_ as IEnumerable<string>);

			return h_;
		};
		IEnumerable<Encounter> b_ = context.Operators.Where<Encounter>(Enc, a_);

		return b_;
	}

    [CqlDeclaration("isEncounterPerformed")]
	public IEnumerable<Encounter> isEncounterPerformed(IEnumerable<Encounter> Enc)
	{
		bool? a_(Encounter E)
		{
			Code<Encounter.EncounterStatus> c_ = E?.StatusElement;
			Encounter.EncounterStatus? d_ = c_?.Value;
			Code<Encounter.EncounterStatus> e_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(d_);
			string f_ = context.Operators.Convert<string>(e_);
			string[] g_ = [
				"finished",
				"arrived",
				"triaged",
				"in-progress",
				"onleave",
			];
			bool? h_ = context.Operators.In<string>(f_, g_ as IEnumerable<string>);

			return h_;
		};
		IEnumerable<Encounter> b_ = context.Operators.Where<Encounter>(Enc, a_);

		return b_;
	}

    [CqlDeclaration("Completed Immunization")]
	public IEnumerable<Immunization> Completed_Immunization(IEnumerable<Immunization> Immunization)
	{
		bool? a_(Immunization I)
		{
			Code<Immunization.ImmunizationStatusCodes> c_ = I?.StatusElement;
			Immunization.ImmunizationStatusCodes? d_ = c_?.Value;
			string e_ = context.Operators.Convert<string>(d_);
			bool? f_ = context.Operators.Equivalent(e_, "completed");

			return f_;
		};
		IEnumerable<Immunization> b_ = context.Operators.Where<Immunization>(Immunization, a_);

		return b_;
	}

    [CqlDeclaration("isImmunizationAdministered")]
	public IEnumerable<Immunization> isImmunizationAdministered(IEnumerable<Immunization> Immunization)
	{
		bool? a_(Immunization I)
		{
			Code<Immunization.ImmunizationStatusCodes> c_ = I?.StatusElement;
			Immunization.ImmunizationStatusCodes? d_ = c_?.Value;
			string e_ = context.Operators.Convert<string>(d_);
			bool? f_ = context.Operators.Equivalent(e_, "completed");

			return f_;
		};
		IEnumerable<Immunization> b_ = context.Operators.Where<Immunization>(Immunization, a_);

		return b_;
	}

    [CqlDeclaration("Completed Procedure")]
	public IEnumerable<Procedure> Completed_Procedure(IEnumerable<Procedure> Proc)
	{
		bool? a_(Procedure P)
		{
			Code<EventStatus> c_ = P?.StatusElement;
			EventStatus? d_ = c_?.Value;
			string e_ = context.Operators.Convert<string>(d_);
			bool? f_ = context.Operators.Equivalent(e_, "completed");

			return f_;
		};
		IEnumerable<Procedure> b_ = context.Operators.Where<Procedure>(Proc, a_);

		return b_;
	}

    [CqlDeclaration("isInterventionPerformed")]
	public IEnumerable<Procedure> isInterventionPerformed(IEnumerable<Procedure> Proc)
	{
		bool? a_(Procedure P)
		{
			Code<EventStatus> c_ = P?.StatusElement;
			EventStatus? d_ = c_?.Value;
			string e_ = context.Operators.Convert<string>(d_);
			bool? f_ = context.Operators.Equivalent(e_, "completed");

			return f_;
		};
		IEnumerable<Procedure> b_ = context.Operators.Where<Procedure>(Proc, a_);

		return b_;
	}

    [CqlDeclaration("isProcedurePerformed")]
	public IEnumerable<Procedure> isProcedurePerformed(IEnumerable<Procedure> Proc)
	{
		bool? a_(Procedure P)
		{
			Code<EventStatus> c_ = P?.StatusElement;
			EventStatus? d_ = c_?.Value;
			string e_ = context.Operators.Convert<string>(d_);
			bool? f_ = context.Operators.Equivalent(e_, "completed");

			return f_;
		};
		IEnumerable<Procedure> b_ = context.Operators.Where<Procedure>(Proc, a_);

		return b_;
	}

    [CqlDeclaration("Final Lab Observation")]
	public IEnumerable<Observation> Final_Lab_Observation(IEnumerable<Observation> Obs)
	{
		bool? a_(Observation O)
		{
			Code<ObservationStatus> c_ = O?.StatusElement;
			ObservationStatus? d_ = c_?.Value;
			Code<ObservationStatus> e_ = context.Operators.Convert<Code<ObservationStatus>>(d_);
			string f_ = context.Operators.Convert<string>(e_);
			string[] g_ = [
				"final",
				"amended",
				"corrected",
			];
			bool? h_ = context.Operators.In<string>(f_, g_ as IEnumerable<string>);
			List<CodeableConcept> i_ = O?.Category;
			CqlConcept j_(CodeableConcept @this)
			{
				CqlConcept p_ = FHIRHelpers_4_3_000.ToConcept(@this);

				return p_;
			};
			IEnumerable<CqlConcept> k_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)i_, j_);
			bool? l_(CqlConcept ObservationCategory)
			{
				CqlCode q_ = this.laboratory();
				CqlConcept r_ = context.Operators.ConvertCodeToConcept(q_);
				bool? s_ = context.Operators.Equivalent(ObservationCategory, r_);

				return s_;
			};
			IEnumerable<CqlConcept> m_ = context.Operators.Where<CqlConcept>(k_, l_);
			bool? n_ = context.Operators.Exists<CqlConcept>(m_);
			bool? o_ = context.Operators.And(h_, n_);

			return o_;
		};
		IEnumerable<Observation> b_ = context.Operators.Where<Observation>(Obs, a_);

		return b_;
	}

    [CqlDeclaration("isLaboratoryTestPerformed")]
	public IEnumerable<Observation> isLaboratoryTestPerformed(IEnumerable<Observation> Obs)
	{
		bool? a_(Observation O)
		{
			Code<ObservationStatus> c_ = O?.StatusElement;
			ObservationStatus? d_ = c_?.Value;
			Code<ObservationStatus> e_ = context.Operators.Convert<Code<ObservationStatus>>(d_);
			string f_ = context.Operators.Convert<string>(e_);
			string[] g_ = [
				"final",
				"amended",
				"corrected",
			];
			bool? h_ = context.Operators.In<string>(f_, g_ as IEnumerable<string>);
			List<CodeableConcept> i_ = O?.Category;
			CqlConcept j_(CodeableConcept @this)
			{
				CqlConcept p_ = FHIRHelpers_4_3_000.ToConcept(@this);

				return p_;
			};
			IEnumerable<CqlConcept> k_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)i_, j_);
			bool? l_(CqlConcept ObservationCategory)
			{
				CqlCode q_ = this.laboratory();
				CqlConcept r_ = context.Operators.ConvertCodeToConcept(q_);
				bool? s_ = context.Operators.Equivalent(ObservationCategory, r_);

				return s_;
			};
			IEnumerable<CqlConcept> m_ = context.Operators.Where<CqlConcept>(k_, l_);
			bool? n_ = context.Operators.Exists<CqlConcept>(m_);
			bool? o_ = context.Operators.And(h_, n_);

			return o_;
		};
		IEnumerable<Observation> b_ = context.Operators.Where<Observation>(Obs, a_);

		return b_;
	}

    [CqlDeclaration("Active Medication")]
	public IEnumerable<MedicationRequest> Active_Medication(IEnumerable<MedicationRequest> MedicationRequest)
	{
		bool? a_(MedicationRequest M)
		{
			Code<MedicationRequest.MedicationrequestStatus> c_ = M?.StatusElement;
			MedicationRequest.MedicationrequestStatus? d_ = c_?.Value;
			string e_ = context.Operators.Convert<string>(d_);
			bool? f_ = context.Operators.Equal(e_, "active");
			Code<MedicationRequest.MedicationRequestIntent> g_ = M?.IntentElement;
			MedicationRequest.MedicationRequestIntent? h_ = g_?.Value;
			string i_ = context.Operators.Convert<string>(h_);
			bool? j_ = context.Operators.Equal(i_, "order");
			bool? k_ = context.Operators.And(f_, j_);

			return k_;
		};
		IEnumerable<MedicationRequest> b_ = context.Operators.Where<MedicationRequest>(MedicationRequest, a_);

		return b_;
	}

    [CqlDeclaration("isMedicationActive")]
	public IEnumerable<MedicationRequest> isMedicationActive(IEnumerable<MedicationRequest> MedicationRequest)
	{
		bool? a_(MedicationRequest M)
		{
			Code<MedicationRequest.MedicationrequestStatus> c_ = M?.StatusElement;
			MedicationRequest.MedicationrequestStatus? d_ = c_?.Value;
			string e_ = context.Operators.Convert<string>(d_);
			bool? f_ = context.Operators.Equal(e_, "active");
			Code<MedicationRequest.MedicationRequestIntent> g_ = M?.IntentElement;
			MedicationRequest.MedicationRequestIntent? h_ = g_?.Value;
			string i_ = context.Operators.Convert<string>(h_);
			bool? j_ = context.Operators.Equal(i_, "order");
			bool? k_ = context.Operators.And(f_, j_);

			return k_;
		};
		IEnumerable<MedicationRequest> b_ = context.Operators.Where<MedicationRequest>(MedicationRequest, a_);

		return b_;
	}

    [CqlDeclaration("Dispensed Medication")]
	public IEnumerable<MedicationDispense> Dispensed_Medication(IEnumerable<MedicationDispense> Med)
	{
		bool? a_(MedicationDispense M)
		{
			Code<MedicationDispense.MedicationDispenseStatusCodes> c_ = M?.StatusElement;
			MedicationDispense.MedicationDispenseStatusCodes? d_ = c_?.Value;
			Code<MedicationDispense.MedicationDispenseStatusCodes> e_ = context.Operators.Convert<Code<MedicationDispense.MedicationDispenseStatusCodes>>(d_);
			string f_ = context.Operators.Convert<string>(e_);
			string[] g_ = [
				"completed",
				"in-progress",
				"on-hold",
			];
			bool? h_ = context.Operators.In<string>(f_, g_ as IEnumerable<string>);

			return h_;
		};
		IEnumerable<MedicationDispense> b_ = context.Operators.Where<MedicationDispense>(Med, a_);

		return b_;
	}

    [CqlDeclaration("isMedicationDispensed")]
	public IEnumerable<MedicationDispense> isMedicationDispensed(IEnumerable<MedicationDispense> Med)
	{
		bool? a_(MedicationDispense M)
		{
			Code<MedicationDispense.MedicationDispenseStatusCodes> c_ = M?.StatusElement;
			MedicationDispense.MedicationDispenseStatusCodes? d_ = c_?.Value;
			Code<MedicationDispense.MedicationDispenseStatusCodes> e_ = context.Operators.Convert<Code<MedicationDispense.MedicationDispenseStatusCodes>>(d_);
			string f_ = context.Operators.Convert<string>(e_);
			string[] g_ = [
				"completed",
				"in-progress",
				"on-hold",
			];
			bool? h_ = context.Operators.In<string>(f_, g_ as IEnumerable<string>);

			return h_;
		};
		IEnumerable<MedicationDispense> b_ = context.Operators.Where<MedicationDispense>(Med, a_);

		return b_;
	}

    [CqlDeclaration("Active or Completed Medication Request")]
	public IEnumerable<MedicationRequest> Active_or_Completed_Medication_Request(IEnumerable<MedicationRequest> MedicationRequest)
	{
		bool? a_(MedicationRequest M)
		{
			Code<MedicationRequest.MedicationrequestStatus> c_ = M?.StatusElement;
			MedicationRequest.MedicationrequestStatus? d_ = c_?.Value;
			string e_ = context.Operators.Convert<string>(d_);
			string[] f_ = [
				"active",
				"completed",
			];
			bool? g_ = context.Operators.In<string>(e_, f_ as IEnumerable<string>);
			Code<MedicationRequest.MedicationRequestIntent> h_ = M?.IntentElement;
			MedicationRequest.MedicationRequestIntent? i_ = h_?.Value;
			string j_ = context.Operators.Convert<string>(i_);
			bool? k_ = context.Operators.Equal(j_, "order");
			bool? l_ = context.Operators.And(g_, k_);

			return l_;
		};
		IEnumerable<MedicationRequest> b_ = context.Operators.Where<MedicationRequest>(MedicationRequest, a_);

		return b_;
	}

    [CqlDeclaration("isMedicationOrder")]
	public IEnumerable<MedicationRequest> isMedicationOrder(IEnumerable<MedicationRequest> MedicationRequest)
	{
		bool? a_(MedicationRequest M)
		{
			Code<MedicationRequest.MedicationrequestStatus> c_ = M?.StatusElement;
			MedicationRequest.MedicationrequestStatus? d_ = c_?.Value;
			string e_ = context.Operators.Convert<string>(d_);
			string[] f_ = [
				"active",
				"completed",
			];
			bool? g_ = context.Operators.In<string>(e_, f_ as IEnumerable<string>);
			Code<MedicationRequest.MedicationRequestIntent> h_ = M?.IntentElement;
			MedicationRequest.MedicationRequestIntent? i_ = h_?.Value;
			string j_ = context.Operators.Convert<string>(i_);
			bool? k_ = context.Operators.Equal(j_, "order");
			bool? l_ = context.Operators.And(g_, k_);

			return l_;
		};
		IEnumerable<MedicationRequest> b_ = context.Operators.Where<MedicationRequest>(MedicationRequest, a_);

		return b_;
	}

    [CqlDeclaration("Final Exam Observation")]
	public IEnumerable<Observation> Final_Exam_Observation(IEnumerable<Observation> Obs)
	{
		bool? a_(Observation O)
		{
			Code<ObservationStatus> c_ = O?.StatusElement;
			ObservationStatus? d_ = c_?.Value;
			Code<ObservationStatus> e_ = context.Operators.Convert<Code<ObservationStatus>>(d_);
			string f_ = context.Operators.Convert<string>(e_);
			string[] g_ = [
				"final",
				"amended",
				"corrected",
			];
			bool? h_ = context.Operators.In<string>(f_, g_ as IEnumerable<string>);
			List<CodeableConcept> i_ = O?.Category;
			CqlConcept j_(CodeableConcept @this)
			{
				CqlConcept p_ = FHIRHelpers_4_3_000.ToConcept(@this);

				return p_;
			};
			IEnumerable<CqlConcept> k_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)i_, j_);
			bool? l_(CqlConcept ObservationCategory)
			{
				CqlCode q_ = this.exam();
				CqlConcept r_ = context.Operators.ConvertCodeToConcept(q_);
				bool? s_ = context.Operators.Equivalent(ObservationCategory, r_);

				return s_;
			};
			IEnumerable<CqlConcept> m_ = context.Operators.Where<CqlConcept>(k_, l_);
			bool? n_ = context.Operators.Exists<CqlConcept>(m_);
			bool? o_ = context.Operators.And(h_, n_);

			return o_;
		};
		IEnumerable<Observation> b_ = context.Operators.Where<Observation>(Obs, a_);

		return b_;
	}

    [CqlDeclaration("isPhysicalExamPerformed")]
	public IEnumerable<Observation> isPhysicalExamPerformed(IEnumerable<Observation> Obs)
	{
		bool? a_(Observation O)
		{
			Code<ObservationStatus> c_ = O?.StatusElement;
			ObservationStatus? d_ = c_?.Value;
			Code<ObservationStatus> e_ = context.Operators.Convert<Code<ObservationStatus>>(d_);
			string f_ = context.Operators.Convert<string>(e_);
			string[] g_ = [
				"final",
				"amended",
				"corrected",
			];
			bool? h_ = context.Operators.In<string>(f_, g_ as IEnumerable<string>);
			List<CodeableConcept> i_ = O?.Category;
			CqlConcept j_(CodeableConcept @this)
			{
				CqlConcept p_ = FHIRHelpers_4_3_000.ToConcept(@this);

				return p_;
			};
			IEnumerable<CqlConcept> k_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)i_, j_);
			bool? l_(CqlConcept ObservationCategory)
			{
				CqlCode q_ = this.exam();
				CqlConcept r_ = context.Operators.ConvertCodeToConcept(q_);
				bool? s_ = context.Operators.Equivalent(ObservationCategory, r_);

				return s_;
			};
			IEnumerable<CqlConcept> m_ = context.Operators.Where<CqlConcept>(k_, l_);
			bool? n_ = context.Operators.Exists<CqlConcept>(m_);
			bool? o_ = context.Operators.And(h_, n_);

			return o_;
		};
		IEnumerable<Observation> b_ = context.Operators.Where<Observation>(Obs, a_);

		return b_;
	}

    [CqlDeclaration("BloodPressure")]
	public IEnumerable<Observation> BloodPressure(IEnumerable<Observation> Obs)
	{
		bool? a_(Observation O)
		{
			Code<ObservationStatus> c_ = O?.StatusElement;
			ObservationStatus? d_ = c_?.Value;
			string e_ = context.Operators.Convert<string>(d_);
			string[] f_ = [
				"final",
				"amended",
				"corrected",
			];
			bool? g_ = context.Operators.In<string>(e_, f_ as IEnumerable<string>);

			return g_;
		};
		IEnumerable<Observation> b_ = context.Operators.Where<Observation>(Obs, a_);

		return b_;
	}

    [CqlDeclaration("BodyHeight")]
	public IEnumerable<Observation> BodyHeight(IEnumerable<Observation> Obs)
	{
		bool? a_(Observation O)
		{
			Code<ObservationStatus> c_ = O?.StatusElement;
			ObservationStatus? d_ = c_?.Value;
			string e_ = context.Operators.Convert<string>(d_);
			string[] f_ = [
				"final",
				"amended",
				"corrected",
			];
			bool? g_ = context.Operators.In<string>(e_, f_ as IEnumerable<string>);

			return g_;
		};
		IEnumerable<Observation> b_ = context.Operators.Where<Observation>(Obs, a_);

		return b_;
	}

    [CqlDeclaration("BodyWeight")]
	public IEnumerable<Observation> BodyWeight(IEnumerable<Observation> Obs)
	{
		bool? a_(Observation O)
		{
			Code<ObservationStatus> c_ = O?.StatusElement;
			ObservationStatus? d_ = c_?.Value;
			string e_ = context.Operators.Convert<string>(d_);
			string[] f_ = [
				"final",
				"amended",
				"corrected",
			];
			bool? g_ = context.Operators.In<string>(e_, f_ as IEnumerable<string>);

			return g_;
		};
		IEnumerable<Observation> b_ = context.Operators.Where<Observation>(Obs, a_);

		return b_;
	}

    [CqlDeclaration("BMI")]
	public IEnumerable<Observation> BMI(IEnumerable<Observation> Obs)
	{
		bool? a_(Observation O)
		{
			Code<ObservationStatus> c_ = O?.StatusElement;
			ObservationStatus? d_ = c_?.Value;
			string e_ = context.Operators.Convert<string>(d_);
			string[] f_ = [
				"final",
				"amended",
				"corrected",
			];
			bool? g_ = context.Operators.In<string>(e_, f_ as IEnumerable<string>);

			return g_;
		};
		IEnumerable<Observation> b_ = context.Operators.Where<Observation>(Obs, a_);

		return b_;
	}

    [CqlDeclaration("isObservationBP")]
	public IEnumerable<Observation> isObservationBP(IEnumerable<Observation> Obs)
	{
		bool? a_(Observation O)
		{
			Code<ObservationStatus> c_ = O?.StatusElement;
			ObservationStatus? d_ = c_?.Value;
			string e_ = context.Operators.Convert<string>(d_);
			string[] f_ = [
				"final",
				"amended",
				"corrected",
			];
			bool? g_ = context.Operators.In<string>(e_, f_ as IEnumerable<string>);

			return g_;
		};
		IEnumerable<Observation> b_ = context.Operators.Where<Observation>(Obs, a_);

		return b_;
	}

    [CqlDeclaration("isObservationBodyHeight")]
	public IEnumerable<Observation> isObservationBodyHeight(IEnumerable<Observation> Obs)
	{
		bool? a_(Observation O)
		{
			Code<ObservationStatus> c_ = O?.StatusElement;
			ObservationStatus? d_ = c_?.Value;
			string e_ = context.Operators.Convert<string>(d_);
			string[] f_ = [
				"final",
				"amended",
				"corrected",
			];
			bool? g_ = context.Operators.In<string>(e_, f_ as IEnumerable<string>);

			return g_;
		};
		IEnumerable<Observation> b_ = context.Operators.Where<Observation>(Obs, a_);

		return b_;
	}

    [CqlDeclaration("isObservationBodyWeight")]
	public IEnumerable<Observation> isObservationBodyWeight(IEnumerable<Observation> Obs)
	{
		bool? a_(Observation O)
		{
			Code<ObservationStatus> c_ = O?.StatusElement;
			ObservationStatus? d_ = c_?.Value;
			string e_ = context.Operators.Convert<string>(d_);
			string[] f_ = [
				"final",
				"amended",
				"corrected",
			];
			bool? g_ = context.Operators.In<string>(e_, f_ as IEnumerable<string>);

			return g_;
		};
		IEnumerable<Observation> b_ = context.Operators.Where<Observation>(Obs, a_);

		return b_;
	}

    [CqlDeclaration("isObservationBMI")]
	public IEnumerable<Observation> isObservationBMI(IEnumerable<Observation> Obs)
	{
		bool? a_(Observation O)
		{
			Code<ObservationStatus> c_ = O?.StatusElement;
			ObservationStatus? d_ = c_?.Value;
			string e_ = context.Operators.Convert<string>(d_);
			string[] f_ = [
				"final",
				"amended",
				"corrected",
			];
			bool? g_ = context.Operators.In<string>(e_, f_ as IEnumerable<string>);

			return g_;
		};
		IEnumerable<Observation> b_ = context.Operators.Where<Observation>(Obs, a_);

		return b_;
	}

    [CqlDeclaration("Initial or Final Observation")]
	public IEnumerable<Observation> Initial_or_Final_Observation(IEnumerable<Observation> Obs)
	{
		bool? a_(Observation O)
		{
			Code<ObservationStatus> c_ = O?.StatusElement;
			ObservationStatus? d_ = c_?.Value;
			Code<ObservationStatus> e_ = context.Operators.Convert<Code<ObservationStatus>>(d_);
			string f_ = context.Operators.Convert<string>(e_);
			string[] g_ = [
				"preliminary",
				"final",
				"amended",
				"corrected",
			];
			bool? h_ = context.Operators.In<string>(f_, g_ as IEnumerable<string>);

			return h_;
		};
		IEnumerable<Observation> b_ = context.Operators.Where<Observation>(Obs, a_);

		return b_;
	}

    [CqlDeclaration("isSymptom")]
	public IEnumerable<Observation> isSymptom(IEnumerable<Observation> Obs)
	{
		bool? a_(Observation O)
		{
			Code<ObservationStatus> c_ = O?.StatusElement;
			ObservationStatus? d_ = c_?.Value;
			Code<ObservationStatus> e_ = context.Operators.Convert<Code<ObservationStatus>>(d_);
			string f_ = context.Operators.Convert<string>(e_);
			string[] g_ = [
				"preliminary",
				"final",
				"amended",
				"corrected",
			];
			bool? h_ = context.Operators.In<string>(f_, g_ as IEnumerable<string>);

			return h_;
		};
		IEnumerable<Observation> b_ = context.Operators.Where<Observation>(Obs, a_);

		return b_;
	}

}
