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
		new CqlCode("laboratory", "http://terminology.hl7.org/CodeSystem/observation-category", null, null);

    [CqlDeclaration("laboratory")]
	public CqlCode laboratory() => 
		__laboratory.Value;

	private CqlCode exam_Value() => 
		new CqlCode("exam", "http://terminology.hl7.org/CodeSystem/observation-category", null, null);

    [CqlDeclaration("exam")]
	public CqlCode exam() => 
		__exam.Value;

	private CqlCode survey_Value() => 
		new CqlCode("survey", "http://terminology.hl7.org/CodeSystem/observation-category", null, null);

    [CqlDeclaration("survey")]
	public CqlCode survey() => 
		__survey.Value;

	private CqlCode vital_signs_Value() => 
		new CqlCode("vital-signs", "http://terminology.hl7.org/CodeSystem/observation-category", null, null);

    [CqlDeclaration("vital-signs")]
	public CqlCode vital_signs() => 
		__vital_signs.Value;

	private CqlCode active_Value() => 
		new CqlCode("active", "http://terminology.hl7.org/CodeSystem/condition-clinical", null, null);

    [CqlDeclaration("active")]
	public CqlCode active() => 
		__active.Value;

	private CqlCode[] ObservationCategoryCodes_Value()
	{
		var a_ = new CqlCode[]
		{
			new CqlCode("laboratory", "http://terminology.hl7.org/CodeSystem/observation-category", null, null),
			new CqlCode("exam", "http://terminology.hl7.org/CodeSystem/observation-category", null, null),
			new CqlCode("survey", "http://terminology.hl7.org/CodeSystem/observation-category", null, null),
			new CqlCode("vital-signs", "http://terminology.hl7.org/CodeSystem/observation-category", null, null),
		};

		return a_;
	}

    [CqlDeclaration("ObservationCategoryCodes")]
	public CqlCode[] ObservationCategoryCodes() => 
		__ObservationCategoryCodes.Value;

	private CqlCode[] ConditionClinicalStatusCodes_Value()
	{
		var a_ = new CqlCode[]
		{
			new CqlCode("active", "http://terminology.hl7.org/CodeSystem/condition-clinical", null, null),
		};

		return a_;
	}

    [CqlDeclaration("ConditionClinicalStatusCodes")]
	public CqlCode[] ConditionClinicalStatusCodes() => 
		__ConditionClinicalStatusCodes.Value;

	private Patient Patient_Value()
	{
		var a_ = context.Operators.RetrieveByValueSet<Patient>(null, null);
		var b_ = context.Operators.Single<Patient>(a_);

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
			var c_ = context.Operators.Convert<Code<ObservationStatus>>(O?.StatusElement?.Value);
			var d_ = context.Operators.Convert<string>(c_);
			var e_ = new string[]
			{
				"final",
				"amended",
				"corrected",
			};
			var f_ = context.Operators.InList<string>(d_, (e_ as IEnumerable<string>));
			CqlConcept g_(CodeableConcept @this)
			{
				var m_ = FHIRHelpers_4_3_000.ToConcept(@this);

				return m_;
			};
			var h_ = context.Operators.Select<CodeableConcept, CqlConcept>(O?.Category, g_);
			bool? i_(CqlConcept ObservationCategory)
			{
				var n_ = this.survey();
				var o_ = context.Operators.ConvertCodeToConcept(n_);
				var p_ = context.Operators.Equivalent(ObservationCategory, o_);

				return p_;
			};
			var j_ = context.Operators.WhereOrNull<CqlConcept>(h_, i_);
			var k_ = context.Operators.ExistsInList<CqlConcept>(j_);
			var l_ = context.Operators.And(f_, k_);

			return l_;
		};
		var b_ = context.Operators.WhereOrNull<Observation>(Obs, a_);

		return b_;
	}

    [CqlDeclaration("isAssessmentPerformed")]
	public IEnumerable<Observation> isAssessmentPerformed(IEnumerable<Observation> Obs)
	{
		bool? a_(Observation O)
		{
			var c_ = context.Operators.Convert<Code<ObservationStatus>>(O?.StatusElement?.Value);
			var d_ = context.Operators.Convert<string>(c_);
			var e_ = new string[]
			{
				"final",
				"amended",
				"corrected",
			};
			var f_ = context.Operators.InList<string>(d_, (e_ as IEnumerable<string>));
			CqlConcept g_(CodeableConcept @this)
			{
				var m_ = FHIRHelpers_4_3_000.ToConcept(@this);

				return m_;
			};
			var h_ = context.Operators.Select<CodeableConcept, CqlConcept>(O?.Category, g_);
			bool? i_(CqlConcept ObservationCategory)
			{
				var n_ = this.survey();
				var o_ = context.Operators.ConvertCodeToConcept(n_);
				var p_ = context.Operators.Equivalent(ObservationCategory, o_);

				return p_;
			};
			var j_ = context.Operators.WhereOrNull<CqlConcept>(h_, i_);
			var k_ = context.Operators.ExistsInList<CqlConcept>(j_);
			var l_ = context.Operators.And(f_, k_);

			return l_;
		};
		var b_ = context.Operators.WhereOrNull<Observation>(Obs, a_);

		return b_;
	}

    [CqlDeclaration("Active Condition")]
	public IEnumerable<Condition> Active_Condition(IEnumerable<Condition> Condition)
	{
		bool? a_(Condition C)
		{
			var c_ = FHIRHelpers_4_3_000.ToConcept(C?.ClinicalStatus);
			var d_ = this.active();
			var e_ = context.Operators.ConvertCodeToConcept(d_);
			var f_ = context.Operators.Equivalent(c_, e_);

			return f_;
		};
		var b_ = context.Operators.WhereOrNull<Condition>(Condition, a_);

		return b_;
	}

    [CqlDeclaration("isActiveOnly")]
	public IEnumerable<Condition> isActiveOnly(IEnumerable<Condition> Condition)
	{
		bool? a_(Condition C)
		{
			var c_ = FHIRHelpers_4_3_000.ToConcept(C?.ClinicalStatus);
			var d_ = this.active();
			var e_ = context.Operators.ConvertCodeToConcept(d_);
			var f_ = context.Operators.Equivalent(c_, e_);

			return f_;
		};
		var b_ = context.Operators.WhereOrNull<Condition>(Condition, a_);

		return b_;
	}

    [CqlDeclaration("Completed or Ongoing Device Request")]
	public IEnumerable<DeviceRequest> Completed_or_Ongoing_Device_Request(IEnumerable<DeviceRequest> DeviceRequest)
	{
		bool? a_(DeviceRequest D)
		{
			var c_ = context.Operators.Convert<Code<RequestStatus>>(D?.StatusElement?.Value);
			var d_ = context.Operators.Convert<string>(c_);
			var e_ = new string[]
			{
				"active",
				"completed",
			};
			var f_ = context.Operators.InList<string>(d_, (e_ as IEnumerable<string>));
			var g_ = context.Operators.Convert<Code<RequestIntent>>(D?.IntentElement?.Value);
			var h_ = context.Operators.Equal(g_, "order");
			var i_ = context.Operators.And(f_, h_);

			return i_;
		};
		var b_ = context.Operators.WhereOrNull<DeviceRequest>(DeviceRequest, a_);

		return b_;
	}

    [CqlDeclaration("isDeviceOrder")]
	public IEnumerable<DeviceRequest> isDeviceOrder(IEnumerable<DeviceRequest> DeviceRequest)
	{
		bool? a_(DeviceRequest D)
		{
			var c_ = context.Operators.Convert<Code<RequestStatus>>(D?.StatusElement?.Value);
			var d_ = context.Operators.Convert<string>(c_);
			var e_ = new string[]
			{
				"active",
				"completed",
			};
			var f_ = context.Operators.InList<string>(d_, (e_ as IEnumerable<string>));
			var g_ = context.Operators.Convert<Code<RequestIntent>>(D?.IntentElement?.Value);
			var h_ = context.Operators.Equal(g_, "order");
			var i_ = context.Operators.And(f_, h_);

			return i_;
		};
		var b_ = context.Operators.WhereOrNull<DeviceRequest>(DeviceRequest, a_);

		return b_;
	}

    [CqlDeclaration("Completed or Ongoing Service Request")]
	public IEnumerable<ServiceRequest> Completed_or_Ongoing_Service_Request(IEnumerable<ServiceRequest> ServiceRequest)
	{
		bool? a_(ServiceRequest S)
		{
			var c_ = context.Operators.Convert<Code<RequestStatus>>(S?.StatusElement?.Value);
			var d_ = context.Operators.Convert<string>(c_);
			var e_ = new string[]
			{
				"active",
				"completed",
			};
			var f_ = context.Operators.InList<string>(d_, (e_ as IEnumerable<string>));
			var g_ = context.Operators.Convert<Code<RequestIntent>>(S?.IntentElement?.Value);
			var h_ = context.Operators.Equal(g_, "order");
			var i_ = context.Operators.And(f_, h_);

			return i_;
		};
		var b_ = context.Operators.WhereOrNull<ServiceRequest>(ServiceRequest, a_);

		return b_;
	}

    [CqlDeclaration("isDiagnosticStudyOrder")]
	public IEnumerable<ServiceRequest> isDiagnosticStudyOrder(IEnumerable<ServiceRequest> ServiceRequest)
	{
		bool? a_(ServiceRequest S)
		{
			var c_ = context.Operators.Convert<Code<RequestStatus>>(S?.StatusElement?.Value);
			var d_ = context.Operators.Convert<string>(c_);
			var e_ = new string[]
			{
				"active",
				"completed",
			};
			var f_ = context.Operators.InList<string>(d_, (e_ as IEnumerable<string>));
			var g_ = context.Operators.Convert<Code<RequestIntent>>(S?.IntentElement?.Value);
			var h_ = context.Operators.Equal(g_, "order");
			var i_ = context.Operators.And(f_, h_);

			return i_;
		};
		var b_ = context.Operators.WhereOrNull<ServiceRequest>(ServiceRequest, a_);

		return b_;
	}

    [CqlDeclaration("isInterventionOrder")]
	public IEnumerable<ServiceRequest> isInterventionOrder(IEnumerable<ServiceRequest> ServiceRequest)
	{
		bool? a_(ServiceRequest S)
		{
			var c_ = context.Operators.Convert<Code<RequestStatus>>(S?.StatusElement?.Value);
			var d_ = context.Operators.Convert<string>(c_);
			var e_ = new string[]
			{
				"active",
				"completed",
			};
			var f_ = context.Operators.InList<string>(d_, (e_ as IEnumerable<string>));
			var g_ = context.Operators.Convert<Code<RequestIntent>>(S?.IntentElement?.Value);
			var h_ = context.Operators.Equal(g_, "order");
			var i_ = context.Operators.And(f_, h_);

			return i_;
		};
		var b_ = context.Operators.WhereOrNull<ServiceRequest>(ServiceRequest, a_);

		return b_;
	}

    [CqlDeclaration("isLaboratoryTestOrder")]
	public IEnumerable<ServiceRequest> isLaboratoryTestOrder(IEnumerable<ServiceRequest> ServiceRequest)
	{
		bool? a_(ServiceRequest S)
		{
			var c_ = context.Operators.Convert<Code<RequestStatus>>(S?.StatusElement?.Value);
			var d_ = context.Operators.Convert<string>(c_);
			var e_ = new string[]
			{
				"active",
				"completed",
			};
			var f_ = context.Operators.InList<string>(d_, (e_ as IEnumerable<string>));
			var g_ = context.Operators.Convert<Code<RequestIntent>>(S?.IntentElement?.Value);
			var h_ = context.Operators.Equal(g_, "order");
			var i_ = context.Operators.And(f_, h_);

			return i_;
		};
		var b_ = context.Operators.WhereOrNull<ServiceRequest>(ServiceRequest, a_);

		return b_;
	}

    [CqlDeclaration("Final Observation")]
	public IEnumerable<Observation> Final_Observation(IEnumerable<Observation> Obs)
	{
		bool? a_(Observation O)
		{
			var c_ = context.Operators.Convert<Code<ObservationStatus>>(O?.StatusElement?.Value);
			var d_ = context.Operators.Convert<string>(c_);
			var e_ = new string[]
			{
				"final",
				"amended",
				"corrected",
			};
			var f_ = context.Operators.InList<string>(d_, (e_ as IEnumerable<string>));

			return f_;
		};
		var b_ = context.Operators.WhereOrNull<Observation>(Obs, a_);

		return b_;
	}

    [CqlDeclaration("isDiagnosticStudyPerformed")]
	public IEnumerable<Observation> isDiagnosticStudyPerformed(IEnumerable<Observation> Obs)
	{
		bool? a_(Observation O)
		{
			var c_ = context.Operators.Convert<Code<ObservationStatus>>(O?.StatusElement?.Value);
			var d_ = context.Operators.Convert<string>(c_);
			var e_ = new string[]
			{
				"final",
				"amended",
				"corrected",
			};
			var f_ = context.Operators.InList<string>(d_, (e_ as IEnumerable<string>));

			return f_;
		};
		var b_ = context.Operators.WhereOrNull<Observation>(Obs, a_);

		return b_;
	}

    [CqlDeclaration("Finished Encounter")]
	public IEnumerable<Encounter> Finished_Encounter(IEnumerable<Encounter> Enc)
	{
		bool? a_(Encounter E)
		{
			var c_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(E?.StatusElement?.Value);
			var d_ = context.Operators.Convert<string>(c_);
			var e_ = new string[]
			{
				"finished",
				"arrived",
				"triaged",
				"in-progress",
				"onleave",
			};
			var f_ = context.Operators.InList<string>(d_, (e_ as IEnumerable<string>));

			return f_;
		};
		var b_ = context.Operators.WhereOrNull<Encounter>(Enc, a_);

		return b_;
	}

    [CqlDeclaration("isEncounterPerformed")]
	public IEnumerable<Encounter> isEncounterPerformed(IEnumerable<Encounter> Enc)
	{
		bool? a_(Encounter E)
		{
			var c_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(E?.StatusElement?.Value);
			var d_ = context.Operators.Convert<string>(c_);
			var e_ = new string[]
			{
				"finished",
				"arrived",
				"triaged",
				"in-progress",
				"onleave",
			};
			var f_ = context.Operators.InList<string>(d_, (e_ as IEnumerable<string>));

			return f_;
		};
		var b_ = context.Operators.WhereOrNull<Encounter>(Enc, a_);

		return b_;
	}

    [CqlDeclaration("Completed Immunization")]
	public IEnumerable<Immunization> Completed_Immunization(IEnumerable<Immunization> Immunization)
	{
		bool? a_(Immunization I)
		{
			var c_ = context.Operators.Equivalent(I?.StatusElement?.Value, "completed");

			return c_;
		};
		var b_ = context.Operators.WhereOrNull<Immunization>(Immunization, a_);

		return b_;
	}

    [CqlDeclaration("isImmunizationAdministered")]
	public IEnumerable<Immunization> isImmunizationAdministered(IEnumerable<Immunization> Immunization)
	{
		bool? a_(Immunization I)
		{
			var c_ = context.Operators.Equivalent(I?.StatusElement?.Value, "completed");

			return c_;
		};
		var b_ = context.Operators.WhereOrNull<Immunization>(Immunization, a_);

		return b_;
	}

    [CqlDeclaration("Completed Procedure")]
	public IEnumerable<Procedure> Completed_Procedure(IEnumerable<Procedure> Proc)
	{
		bool? a_(Procedure P)
		{
			var c_ = context.Operators.Equivalent(P?.StatusElement?.Value, "completed");

			return c_;
		};
		var b_ = context.Operators.WhereOrNull<Procedure>(Proc, a_);

		return b_;
	}

    [CqlDeclaration("isInterventionPerformed")]
	public IEnumerable<Procedure> isInterventionPerformed(IEnumerable<Procedure> Proc)
	{
		bool? a_(Procedure P)
		{
			var c_ = context.Operators.Equivalent(P?.StatusElement?.Value, "completed");

			return c_;
		};
		var b_ = context.Operators.WhereOrNull<Procedure>(Proc, a_);

		return b_;
	}

    [CqlDeclaration("isProcedurePerformed")]
	public IEnumerable<Procedure> isProcedurePerformed(IEnumerable<Procedure> Proc)
	{
		bool? a_(Procedure P)
		{
			var c_ = context.Operators.Equivalent(P?.StatusElement?.Value, "completed");

			return c_;
		};
		var b_ = context.Operators.WhereOrNull<Procedure>(Proc, a_);

		return b_;
	}

    [CqlDeclaration("Final Lab Observation")]
	public IEnumerable<Observation> Final_Lab_Observation(IEnumerable<Observation> Obs)
	{
		bool? a_(Observation O)
		{
			var c_ = context.Operators.Convert<Code<ObservationStatus>>(O?.StatusElement?.Value);
			var d_ = context.Operators.Convert<string>(c_);
			var e_ = new string[]
			{
				"final",
				"amended",
				"corrected",
			};
			var f_ = context.Operators.InList<string>(d_, (e_ as IEnumerable<string>));
			CqlConcept g_(CodeableConcept @this)
			{
				var m_ = FHIRHelpers_4_3_000.ToConcept(@this);

				return m_;
			};
			var h_ = context.Operators.Select<CodeableConcept, CqlConcept>(O?.Category, g_);
			bool? i_(CqlConcept ObservationCategory)
			{
				var n_ = this.laboratory();
				var o_ = context.Operators.ConvertCodeToConcept(n_);
				var p_ = context.Operators.Equivalent(ObservationCategory, o_);

				return p_;
			};
			var j_ = context.Operators.WhereOrNull<CqlConcept>(h_, i_);
			var k_ = context.Operators.ExistsInList<CqlConcept>(j_);
			var l_ = context.Operators.And(f_, k_);

			return l_;
		};
		var b_ = context.Operators.WhereOrNull<Observation>(Obs, a_);

		return b_;
	}

    [CqlDeclaration("isLaboratoryTestPerformed")]
	public IEnumerable<Observation> isLaboratoryTestPerformed(IEnumerable<Observation> Obs)
	{
		bool? a_(Observation O)
		{
			var c_ = context.Operators.Convert<Code<ObservationStatus>>(O?.StatusElement?.Value);
			var d_ = context.Operators.Convert<string>(c_);
			var e_ = new string[]
			{
				"final",
				"amended",
				"corrected",
			};
			var f_ = context.Operators.InList<string>(d_, (e_ as IEnumerable<string>));
			CqlConcept g_(CodeableConcept @this)
			{
				var m_ = FHIRHelpers_4_3_000.ToConcept(@this);

				return m_;
			};
			var h_ = context.Operators.Select<CodeableConcept, CqlConcept>(O?.Category, g_);
			bool? i_(CqlConcept ObservationCategory)
			{
				var n_ = this.laboratory();
				var o_ = context.Operators.ConvertCodeToConcept(n_);
				var p_ = context.Operators.Equivalent(ObservationCategory, o_);

				return p_;
			};
			var j_ = context.Operators.WhereOrNull<CqlConcept>(h_, i_);
			var k_ = context.Operators.ExistsInList<CqlConcept>(j_);
			var l_ = context.Operators.And(f_, k_);

			return l_;
		};
		var b_ = context.Operators.WhereOrNull<Observation>(Obs, a_);

		return b_;
	}

    [CqlDeclaration("Active Medication")]
	public IEnumerable<MedicationRequest> Active_Medication(IEnumerable<MedicationRequest> MedicationRequest)
	{
		bool? a_(MedicationRequest M)
		{
			var c_ = context.Operators.EnumEqualsString(M?.StatusElement?.Value, "active");
			var d_ = context.Operators.EnumEqualsString(M?.IntentElement?.Value, "order");
			var e_ = context.Operators.And(c_, d_);

			return e_;
		};
		var b_ = context.Operators.WhereOrNull<MedicationRequest>(MedicationRequest, a_);

		return b_;
	}

    [CqlDeclaration("isMedicationActive")]
	public IEnumerable<MedicationRequest> isMedicationActive(IEnumerable<MedicationRequest> MedicationRequest)
	{
		bool? a_(MedicationRequest M)
		{
			var c_ = context.Operators.EnumEqualsString(M?.StatusElement?.Value, "active");
			var d_ = context.Operators.EnumEqualsString(M?.IntentElement?.Value, "order");
			var e_ = context.Operators.And(c_, d_);

			return e_;
		};
		var b_ = context.Operators.WhereOrNull<MedicationRequest>(MedicationRequest, a_);

		return b_;
	}

    [CqlDeclaration("Dispensed Medication")]
	public IEnumerable<MedicationDispense> Dispensed_Medication(IEnumerable<MedicationDispense> Med)
	{
		bool? a_(MedicationDispense M)
		{
			var c_ = context.Operators.Convert<Code<MedicationDispense.MedicationDispenseStatusCodes>>(M?.StatusElement?.Value);
			var d_ = context.Operators.Convert<string>(c_);
			var e_ = new string[]
			{
				"completed",
				"in-progress",
				"on-hold",
			};
			var f_ = context.Operators.InList<string>(d_, (e_ as IEnumerable<string>));

			return f_;
		};
		var b_ = context.Operators.WhereOrNull<MedicationDispense>(Med, a_);

		return b_;
	}

    [CqlDeclaration("isMedicationDispensed")]
	public IEnumerable<MedicationDispense> isMedicationDispensed(IEnumerable<MedicationDispense> Med)
	{
		bool? a_(MedicationDispense M)
		{
			var c_ = context.Operators.Convert<Code<MedicationDispense.MedicationDispenseStatusCodes>>(M?.StatusElement?.Value);
			var d_ = context.Operators.Convert<string>(c_);
			var e_ = new string[]
			{
				"completed",
				"in-progress",
				"on-hold",
			};
			var f_ = context.Operators.InList<string>(d_, (e_ as IEnumerable<string>));

			return f_;
		};
		var b_ = context.Operators.WhereOrNull<MedicationDispense>(Med, a_);

		return b_;
	}

    [CqlDeclaration("Active or Completed Medication Request")]
	public IEnumerable<MedicationRequest> Active_or_Completed_Medication_Request(IEnumerable<MedicationRequest> MedicationRequest)
	{
		bool? a_(MedicationRequest M)
		{
			var c_ = context.Operators.Convert<string>(M?.StatusElement?.Value);
			var d_ = new string[]
			{
				"active",
				"completed",
			};
			var e_ = context.Operators.InList<string>(c_, (d_ as IEnumerable<string>));
			var f_ = context.Operators.EnumEqualsString(M?.IntentElement?.Value, "order");
			var g_ = context.Operators.And(e_, f_);

			return g_;
		};
		var b_ = context.Operators.WhereOrNull<MedicationRequest>(MedicationRequest, a_);

		return b_;
	}

    [CqlDeclaration("isMedicationOrder")]
	public IEnumerable<MedicationRequest> isMedicationOrder(IEnumerable<MedicationRequest> MedicationRequest)
	{
		bool? a_(MedicationRequest M)
		{
			var c_ = context.Operators.Convert<string>(M?.StatusElement?.Value);
			var d_ = new string[]
			{
				"active",
				"completed",
			};
			var e_ = context.Operators.InList<string>(c_, (d_ as IEnumerable<string>));
			var f_ = context.Operators.EnumEqualsString(M?.IntentElement?.Value, "order");
			var g_ = context.Operators.And(e_, f_);

			return g_;
		};
		var b_ = context.Operators.WhereOrNull<MedicationRequest>(MedicationRequest, a_);

		return b_;
	}

    [CqlDeclaration("Final Exam Observation")]
	public IEnumerable<Observation> Final_Exam_Observation(IEnumerable<Observation> Obs)
	{
		bool? a_(Observation O)
		{
			var c_ = context.Operators.Convert<Code<ObservationStatus>>(O?.StatusElement?.Value);
			var d_ = context.Operators.Convert<string>(c_);
			var e_ = new string[]
			{
				"final",
				"amended",
				"corrected",
			};
			var f_ = context.Operators.InList<string>(d_, (e_ as IEnumerable<string>));
			CqlConcept g_(CodeableConcept @this)
			{
				var m_ = FHIRHelpers_4_3_000.ToConcept(@this);

				return m_;
			};
			var h_ = context.Operators.Select<CodeableConcept, CqlConcept>(O?.Category, g_);
			bool? i_(CqlConcept ObservationCategory)
			{
				var n_ = this.exam();
				var o_ = context.Operators.ConvertCodeToConcept(n_);
				var p_ = context.Operators.Equivalent(ObservationCategory, o_);

				return p_;
			};
			var j_ = context.Operators.WhereOrNull<CqlConcept>(h_, i_);
			var k_ = context.Operators.ExistsInList<CqlConcept>(j_);
			var l_ = context.Operators.And(f_, k_);

			return l_;
		};
		var b_ = context.Operators.WhereOrNull<Observation>(Obs, a_);

		return b_;
	}

    [CqlDeclaration("isPhysicalExamPerformed")]
	public IEnumerable<Observation> isPhysicalExamPerformed(IEnumerable<Observation> Obs)
	{
		bool? a_(Observation O)
		{
			var c_ = context.Operators.Convert<Code<ObservationStatus>>(O?.StatusElement?.Value);
			var d_ = context.Operators.Convert<string>(c_);
			var e_ = new string[]
			{
				"final",
				"amended",
				"corrected",
			};
			var f_ = context.Operators.InList<string>(d_, (e_ as IEnumerable<string>));
			CqlConcept g_(CodeableConcept @this)
			{
				var m_ = FHIRHelpers_4_3_000.ToConcept(@this);

				return m_;
			};
			var h_ = context.Operators.Select<CodeableConcept, CqlConcept>(O?.Category, g_);
			bool? i_(CqlConcept ObservationCategory)
			{
				var n_ = this.exam();
				var o_ = context.Operators.ConvertCodeToConcept(n_);
				var p_ = context.Operators.Equivalent(ObservationCategory, o_);

				return p_;
			};
			var j_ = context.Operators.WhereOrNull<CqlConcept>(h_, i_);
			var k_ = context.Operators.ExistsInList<CqlConcept>(j_);
			var l_ = context.Operators.And(f_, k_);

			return l_;
		};
		var b_ = context.Operators.WhereOrNull<Observation>(Obs, a_);

		return b_;
	}

    [CqlDeclaration("BloodPressure")]
	public IEnumerable<Observation> BloodPressure(IEnumerable<Observation> Obs)
	{
		bool? a_(Observation O)
		{
			var c_ = context.Operators.Convert<string>(O?.StatusElement?.Value);
			var d_ = new string[]
			{
				"final",
				"amended",
				"corrected",
			};
			var e_ = context.Operators.InList<string>(c_, (d_ as IEnumerable<string>));

			return e_;
		};
		var b_ = context.Operators.WhereOrNull<Observation>(Obs, a_);

		return b_;
	}

    [CqlDeclaration("BodyHeight")]
	public IEnumerable<Observation> BodyHeight(IEnumerable<Observation> Obs)
	{
		bool? a_(Observation O)
		{
			var c_ = context.Operators.Convert<string>(O?.StatusElement?.Value);
			var d_ = new string[]
			{
				"final",
				"amended",
				"corrected",
			};
			var e_ = context.Operators.InList<string>(c_, (d_ as IEnumerable<string>));

			return e_;
		};
		var b_ = context.Operators.WhereOrNull<Observation>(Obs, a_);

		return b_;
	}

    [CqlDeclaration("BodyWeight")]
	public IEnumerable<Observation> BodyWeight(IEnumerable<Observation> Obs)
	{
		bool? a_(Observation O)
		{
			var c_ = context.Operators.Convert<string>(O?.StatusElement?.Value);
			var d_ = new string[]
			{
				"final",
				"amended",
				"corrected",
			};
			var e_ = context.Operators.InList<string>(c_, (d_ as IEnumerable<string>));

			return e_;
		};
		var b_ = context.Operators.WhereOrNull<Observation>(Obs, a_);

		return b_;
	}

    [CqlDeclaration("BMI")]
	public IEnumerable<Observation> BMI(IEnumerable<Observation> Obs)
	{
		bool? a_(Observation O)
		{
			var c_ = context.Operators.Convert<string>(O?.StatusElement?.Value);
			var d_ = new string[]
			{
				"final",
				"amended",
				"corrected",
			};
			var e_ = context.Operators.InList<string>(c_, (d_ as IEnumerable<string>));

			return e_;
		};
		var b_ = context.Operators.WhereOrNull<Observation>(Obs, a_);

		return b_;
	}

    [CqlDeclaration("isObservationBP")]
	public IEnumerable<Observation> isObservationBP(IEnumerable<Observation> Obs)
	{
		bool? a_(Observation O)
		{
			var c_ = context.Operators.Convert<string>(O?.StatusElement?.Value);
			var d_ = new string[]
			{
				"final",
				"amended",
				"corrected",
			};
			var e_ = context.Operators.InList<string>(c_, (d_ as IEnumerable<string>));

			return e_;
		};
		var b_ = context.Operators.WhereOrNull<Observation>(Obs, a_);

		return b_;
	}

    [CqlDeclaration("isObservationBodyHeight")]
	public IEnumerable<Observation> isObservationBodyHeight(IEnumerable<Observation> Obs)
	{
		bool? a_(Observation O)
		{
			var c_ = context.Operators.Convert<string>(O?.StatusElement?.Value);
			var d_ = new string[]
			{
				"final",
				"amended",
				"corrected",
			};
			var e_ = context.Operators.InList<string>(c_, (d_ as IEnumerable<string>));

			return e_;
		};
		var b_ = context.Operators.WhereOrNull<Observation>(Obs, a_);

		return b_;
	}

    [CqlDeclaration("isObservationBodyWeight")]
	public IEnumerable<Observation> isObservationBodyWeight(IEnumerable<Observation> Obs)
	{
		bool? a_(Observation O)
		{
			var c_ = context.Operators.Convert<string>(O?.StatusElement?.Value);
			var d_ = new string[]
			{
				"final",
				"amended",
				"corrected",
			};
			var e_ = context.Operators.InList<string>(c_, (d_ as IEnumerable<string>));

			return e_;
		};
		var b_ = context.Operators.WhereOrNull<Observation>(Obs, a_);

		return b_;
	}

    [CqlDeclaration("isObservationBMI")]
	public IEnumerable<Observation> isObservationBMI(IEnumerable<Observation> Obs)
	{
		bool? a_(Observation O)
		{
			var c_ = context.Operators.Convert<string>(O?.StatusElement?.Value);
			var d_ = new string[]
			{
				"final",
				"amended",
				"corrected",
			};
			var e_ = context.Operators.InList<string>(c_, (d_ as IEnumerable<string>));

			return e_;
		};
		var b_ = context.Operators.WhereOrNull<Observation>(Obs, a_);

		return b_;
	}

    [CqlDeclaration("Initial or Final Observation")]
	public IEnumerable<Observation> Initial_or_Final_Observation(IEnumerable<Observation> Obs)
	{
		bool? a_(Observation O)
		{
			var c_ = context.Operators.Convert<Code<ObservationStatus>>(O?.StatusElement?.Value);
			var d_ = context.Operators.Convert<string>(c_);
			var e_ = new string[]
			{
				"preliminary",
				"final",
				"amended",
				"corrected",
			};
			var f_ = context.Operators.InList<string>(d_, (e_ as IEnumerable<string>));

			return f_;
		};
		var b_ = context.Operators.WhereOrNull<Observation>(Obs, a_);

		return b_;
	}

    [CqlDeclaration("isSymptom")]
	public IEnumerable<Observation> isSymptom(IEnumerable<Observation> Obs)
	{
		bool? a_(Observation O)
		{
			var c_ = context.Operators.Convert<Code<ObservationStatus>>(O?.StatusElement?.Value);
			var d_ = context.Operators.Convert<string>(c_);
			var e_ = new string[]
			{
				"preliminary",
				"final",
				"amended",
				"corrected",
			};
			var f_ = context.Operators.InList<string>(d_, (e_ as IEnumerable<string>));

			return f_;
		};
		var b_ = context.Operators.WhereOrNull<Observation>(Obs, a_);

		return b_;
	}

}
