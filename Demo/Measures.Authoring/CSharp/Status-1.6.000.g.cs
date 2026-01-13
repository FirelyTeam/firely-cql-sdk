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

[System.CodeDom.Compiler.GeneratedCode(".NET Code Generation", "5.0.0.0")]
[CqlLibrary("Status", "1.6.000")]
public partial class Status_1_6_000 : ILibrary, ISingleton<Status_1_6_000>
{
    #region Codes

    [CqlCodeDefinition("laboratory", codeId: "laboratory", codeSystem: "http://terminology.hl7.org/CodeSystem/observation-category")]
    public CqlCode laboratory(CqlContext _) => _laboratory;
    private static readonly CqlCode _laboratory = new CqlCode("laboratory", "http://terminology.hl7.org/CodeSystem/observation-category");

    [CqlCodeDefinition("exam", codeId: "exam", codeSystem: "http://terminology.hl7.org/CodeSystem/observation-category")]
    public CqlCode exam(CqlContext _) => _exam;
    private static readonly CqlCode _exam = new CqlCode("exam", "http://terminology.hl7.org/CodeSystem/observation-category");

    [CqlCodeDefinition("survey", codeId: "survey", codeSystem: "http://terminology.hl7.org/CodeSystem/observation-category")]
    public CqlCode survey(CqlContext _) => _survey;
    private static readonly CqlCode _survey = new CqlCode("survey", "http://terminology.hl7.org/CodeSystem/observation-category");

    [CqlCodeDefinition("vital-signs", codeId: "vital-signs", codeSystem: "http://terminology.hl7.org/CodeSystem/observation-category")]
    public CqlCode vital_signs(CqlContext _) => _vital_signs;
    private static readonly CqlCode _vital_signs = new CqlCode("vital-signs", "http://terminology.hl7.org/CodeSystem/observation-category");

    [CqlCodeDefinition("active", codeId: "active", codeSystem: "http://terminology.hl7.org/CodeSystem/condition-clinical")]
    public CqlCode active(CqlContext _) => _active;
    private static readonly CqlCode _active = new CqlCode("active", "http://terminology.hl7.org/CodeSystem/condition-clinical");

    #endregion Codes

    #region CodeSystems

    [CqlCodeSystemDefinition("ObservationCategoryCodes", codeSystemId: "http://terminology.hl7.org/CodeSystem/observation-category", codeSystemVersion: null)]
    public CqlCodeSystem ObservationCategoryCodes(CqlContext _) => _ObservationCategoryCodes;
    private static readonly CqlCodeSystem _ObservationCategoryCodes =
      new CqlCodeSystem("http://terminology.hl7.org/CodeSystem/observation-category", null, [
          _laboratory,
          _exam,
          _survey,
          _vital_signs]);

    [CqlCodeSystemDefinition("ConditionClinicalStatusCodes", codeSystemId: "http://terminology.hl7.org/CodeSystem/condition-clinical", codeSystemVersion: null)]
    public CqlCodeSystem ConditionClinicalStatusCodes(CqlContext _) => _ConditionClinicalStatusCodes;
    private static readonly CqlCodeSystem _ConditionClinicalStatusCodes =
      new CqlCodeSystem("http://terminology.hl7.org/CodeSystem/condition-clinical", null, [
          _active]);

    #endregion CodeSystems

    #region Functions and Expressions

    [CqlExpressionDefinition("Patient")]
    public Patient Patient(CqlContext context) =>
        ((ICqlContextInternals)context).GetOrCompute<Patient>(2429725487134773543L, () => {
            IEnumerable<Patient> a_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-patient"));
            Patient b_ = context.Operators.SingletonFrom<Patient>(a_);
            return b_;
        });


    [CqlFunctionDefinition("Final Survey Observation")]
    public IEnumerable<Observation> Final_Survey_Observation(CqlContext context, IEnumerable<Observation> Obs)
    {

        bool? a_(Observation O) {
            Code<ObservationStatus> c_ = O?.StatusElement;
            ObservationStatus? d_ = c_?.Value;
            Code<ObservationStatus> e_ = context.Operators.Convert<Code<ObservationStatus>>(d_);
            string f_ = context.Operators.Convert<string>(e_);
            string[] g_ = [
                "final",
                "amended",
                "corrected",
            ];
            bool? h_ = context.Operators.In<string>(f_, (IEnumerable<string>)g_);
            List<CodeableConcept> i_ = O?.Category;

            CqlConcept j_(CodeableConcept @this) {
                CqlConcept p_ = FHIRHelpers_4_3_000.Instance.ToConcept(context, @this);
                return p_;
            }

            IEnumerable<CqlConcept> k_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)i_, j_);

            bool? l_(CqlConcept ObservationCategory) {
                CqlCode q_ = this.survey(context);
                CqlConcept r_ = context.Operators.ConvertCodeToConcept(q_);
                bool? s_ = context.Operators.Equivalent(ObservationCategory, r_);
                return s_;
            }

            IEnumerable<CqlConcept> m_ = context.Operators.Where<CqlConcept>(k_, l_);
            bool? n_ = context.Operators.Exists<CqlConcept>(m_);
            bool? o_ = context.Operators.And(h_, n_);
            return o_;
        }

        IEnumerable<Observation> b_ = context.Operators.Where<Observation>(Obs, a_);
        return b_;
    }


    [CqlFunctionDefinition("isAssessmentPerformed")]
    public IEnumerable<Observation> isAssessmentPerformed(CqlContext context, IEnumerable<Observation> Obs)
    {

        bool? a_(Observation O) {
            Code<ObservationStatus> c_ = O?.StatusElement;
            ObservationStatus? d_ = c_?.Value;
            Code<ObservationStatus> e_ = context.Operators.Convert<Code<ObservationStatus>>(d_);
            string f_ = context.Operators.Convert<string>(e_);
            string[] g_ = [
                "final",
                "amended",
                "corrected",
            ];
            bool? h_ = context.Operators.In<string>(f_, (IEnumerable<string>)g_);
            List<CodeableConcept> i_ = O?.Category;

            CqlConcept j_(CodeableConcept @this) {
                CqlConcept p_ = FHIRHelpers_4_3_000.Instance.ToConcept(context, @this);
                return p_;
            }

            IEnumerable<CqlConcept> k_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)i_, j_);

            bool? l_(CqlConcept ObservationCategory) {
                CqlCode q_ = this.survey(context);
                CqlConcept r_ = context.Operators.ConvertCodeToConcept(q_);
                bool? s_ = context.Operators.Equivalent(ObservationCategory, r_);
                return s_;
            }

            IEnumerable<CqlConcept> m_ = context.Operators.Where<CqlConcept>(k_, l_);
            bool? n_ = context.Operators.Exists<CqlConcept>(m_);
            bool? o_ = context.Operators.And(h_, n_);
            return o_;
        }

        IEnumerable<Observation> b_ = context.Operators.Where<Observation>(Obs, a_);
        return b_;
    }


    [CqlFunctionDefinition("Active Condition")]
    public IEnumerable<Condition> Active_Condition(CqlContext context, IEnumerable<Condition> Condition)
    {

        bool? a_(Condition C) {
            CodeableConcept c_ = C?.ClinicalStatus;
            CqlConcept d_ = FHIRHelpers_4_3_000.Instance.ToConcept(context, c_);
            CqlCode e_ = this.active(context);
            CqlConcept f_ = context.Operators.ConvertCodeToConcept(e_);
            bool? g_ = context.Operators.Equivalent(d_, f_);
            return g_;
        }

        IEnumerable<Condition> b_ = context.Operators.Where<Condition>(Condition, a_);
        return b_;
    }


    [CqlFunctionDefinition("isActiveOnly")]
    public IEnumerable<Condition> isActiveOnly(CqlContext context, IEnumerable<Condition> Condition)
    {

        bool? a_(Condition C) {
            CodeableConcept c_ = C?.ClinicalStatus;
            CqlConcept d_ = FHIRHelpers_4_3_000.Instance.ToConcept(context, c_);
            CqlCode e_ = this.active(context);
            CqlConcept f_ = context.Operators.ConvertCodeToConcept(e_);
            bool? g_ = context.Operators.Equivalent(d_, f_);
            return g_;
        }

        IEnumerable<Condition> b_ = context.Operators.Where<Condition>(Condition, a_);
        return b_;
    }


    [CqlFunctionDefinition("Completed or Ongoing Device Request")]
    public IEnumerable<DeviceRequest> Completed_or_Ongoing_Device_Request(CqlContext context, IEnumerable<DeviceRequest> DeviceRequest)
    {

        bool? a_(DeviceRequest D) {
            Code<RequestStatus> c_ = D?.StatusElement;
            RequestStatus? d_ = c_?.Value;
            Code<RequestStatus> e_ = context.Operators.Convert<Code<RequestStatus>>(d_);
            string f_ = context.Operators.Convert<string>(e_);
            string[] g_ = [
                "active",
                "completed",
            ];
            bool? h_ = context.Operators.In<string>(f_, (IEnumerable<string>)g_);
            Code<RequestIntent> i_ = D?.IntentElement;
            RequestIntent? j_ = i_?.Value;
            Code<RequestIntent> k_ = context.Operators.Convert<Code<RequestIntent>>(j_);
            bool? l_ = context.Operators.Equal(k_, "order");
            bool? m_ = context.Operators.And(h_, l_);
            return m_;
        }

        IEnumerable<DeviceRequest> b_ = context.Operators.Where<DeviceRequest>(DeviceRequest, a_);
        return b_;
    }


    [CqlFunctionDefinition("isDeviceOrder")]
    public IEnumerable<DeviceRequest> isDeviceOrder(CqlContext context, IEnumerable<DeviceRequest> DeviceRequest)
    {

        bool? a_(DeviceRequest D) {
            Code<RequestStatus> c_ = D?.StatusElement;
            RequestStatus? d_ = c_?.Value;
            Code<RequestStatus> e_ = context.Operators.Convert<Code<RequestStatus>>(d_);
            string f_ = context.Operators.Convert<string>(e_);
            string[] g_ = [
                "active",
                "completed",
            ];
            bool? h_ = context.Operators.In<string>(f_, (IEnumerable<string>)g_);
            Code<RequestIntent> i_ = D?.IntentElement;
            RequestIntent? j_ = i_?.Value;
            Code<RequestIntent> k_ = context.Operators.Convert<Code<RequestIntent>>(j_);
            bool? l_ = context.Operators.Equal(k_, "order");
            bool? m_ = context.Operators.And(h_, l_);
            return m_;
        }

        IEnumerable<DeviceRequest> b_ = context.Operators.Where<DeviceRequest>(DeviceRequest, a_);
        return b_;
    }


    [CqlFunctionDefinition("Completed or Ongoing Service Request")]
    public IEnumerable<ServiceRequest> Completed_or_Ongoing_Service_Request(CqlContext context, IEnumerable<ServiceRequest> ServiceRequest)
    {

        bool? a_(ServiceRequest S) {
            Code<RequestStatus> c_ = S?.StatusElement;
            RequestStatus? d_ = c_?.Value;
            Code<RequestStatus> e_ = context.Operators.Convert<Code<RequestStatus>>(d_);
            string f_ = context.Operators.Convert<string>(e_);
            string[] g_ = [
                "active",
                "completed",
            ];
            bool? h_ = context.Operators.In<string>(f_, (IEnumerable<string>)g_);
            Code<RequestIntent> i_ = S?.IntentElement;
            RequestIntent? j_ = i_?.Value;
            Code<RequestIntent> k_ = context.Operators.Convert<Code<RequestIntent>>(j_);
            bool? l_ = context.Operators.Equal(k_, "order");
            bool? m_ = context.Operators.And(h_, l_);
            return m_;
        }

        IEnumerable<ServiceRequest> b_ = context.Operators.Where<ServiceRequest>(ServiceRequest, a_);
        return b_;
    }


    [CqlFunctionDefinition("isDiagnosticStudyOrder")]
    public IEnumerable<ServiceRequest> isDiagnosticStudyOrder(CqlContext context, IEnumerable<ServiceRequest> ServiceRequest)
    {

        bool? a_(ServiceRequest S) {
            Code<RequestStatus> c_ = S?.StatusElement;
            RequestStatus? d_ = c_?.Value;
            Code<RequestStatus> e_ = context.Operators.Convert<Code<RequestStatus>>(d_);
            string f_ = context.Operators.Convert<string>(e_);
            string[] g_ = [
                "active",
                "completed",
            ];
            bool? h_ = context.Operators.In<string>(f_, (IEnumerable<string>)g_);
            Code<RequestIntent> i_ = S?.IntentElement;
            RequestIntent? j_ = i_?.Value;
            Code<RequestIntent> k_ = context.Operators.Convert<Code<RequestIntent>>(j_);
            bool? l_ = context.Operators.Equal(k_, "order");
            bool? m_ = context.Operators.And(h_, l_);
            return m_;
        }

        IEnumerable<ServiceRequest> b_ = context.Operators.Where<ServiceRequest>(ServiceRequest, a_);
        return b_;
    }


    [CqlFunctionDefinition("isInterventionOrder")]
    public IEnumerable<ServiceRequest> isInterventionOrder(CqlContext context, IEnumerable<ServiceRequest> ServiceRequest)
    {

        bool? a_(ServiceRequest S) {
            Code<RequestStatus> c_ = S?.StatusElement;
            RequestStatus? d_ = c_?.Value;
            Code<RequestStatus> e_ = context.Operators.Convert<Code<RequestStatus>>(d_);
            string f_ = context.Operators.Convert<string>(e_);
            string[] g_ = [
                "active",
                "completed",
            ];
            bool? h_ = context.Operators.In<string>(f_, (IEnumerable<string>)g_);
            Code<RequestIntent> i_ = S?.IntentElement;
            RequestIntent? j_ = i_?.Value;
            Code<RequestIntent> k_ = context.Operators.Convert<Code<RequestIntent>>(j_);
            bool? l_ = context.Operators.Equal(k_, "order");
            bool? m_ = context.Operators.And(h_, l_);
            return m_;
        }

        IEnumerable<ServiceRequest> b_ = context.Operators.Where<ServiceRequest>(ServiceRequest, a_);
        return b_;
    }


    [CqlFunctionDefinition("isLaboratoryTestOrder")]
    public IEnumerable<ServiceRequest> isLaboratoryTestOrder(CqlContext context, IEnumerable<ServiceRequest> ServiceRequest)
    {

        bool? a_(ServiceRequest S) {
            Code<RequestStatus> c_ = S?.StatusElement;
            RequestStatus? d_ = c_?.Value;
            Code<RequestStatus> e_ = context.Operators.Convert<Code<RequestStatus>>(d_);
            string f_ = context.Operators.Convert<string>(e_);
            string[] g_ = [
                "active",
                "completed",
            ];
            bool? h_ = context.Operators.In<string>(f_, (IEnumerable<string>)g_);
            Code<RequestIntent> i_ = S?.IntentElement;
            RequestIntent? j_ = i_?.Value;
            Code<RequestIntent> k_ = context.Operators.Convert<Code<RequestIntent>>(j_);
            bool? l_ = context.Operators.Equal(k_, "order");
            bool? m_ = context.Operators.And(h_, l_);
            return m_;
        }

        IEnumerable<ServiceRequest> b_ = context.Operators.Where<ServiceRequest>(ServiceRequest, a_);
        return b_;
    }


    [CqlFunctionDefinition("Final Observation")]
    public IEnumerable<Observation> Final_Observation(CqlContext context, IEnumerable<Observation> Obs)
    {

        bool? a_(Observation O) {
            Code<ObservationStatus> c_ = O?.StatusElement;
            ObservationStatus? d_ = c_?.Value;
            Code<ObservationStatus> e_ = context.Operators.Convert<Code<ObservationStatus>>(d_);
            string f_ = context.Operators.Convert<string>(e_);
            string[] g_ = [
                "final",
                "amended",
                "corrected",
            ];
            bool? h_ = context.Operators.In<string>(f_, (IEnumerable<string>)g_);
            return h_;
        }

        IEnumerable<Observation> b_ = context.Operators.Where<Observation>(Obs, a_);
        return b_;
    }


    [CqlFunctionDefinition("isDiagnosticStudyPerformed")]
    public IEnumerable<Observation> isDiagnosticStudyPerformed(CqlContext context, IEnumerable<Observation> Obs)
    {

        bool? a_(Observation O) {
            Code<ObservationStatus> c_ = O?.StatusElement;
            ObservationStatus? d_ = c_?.Value;
            Code<ObservationStatus> e_ = context.Operators.Convert<Code<ObservationStatus>>(d_);
            string f_ = context.Operators.Convert<string>(e_);
            string[] g_ = [
                "final",
                "amended",
                "corrected",
            ];
            bool? h_ = context.Operators.In<string>(f_, (IEnumerable<string>)g_);
            return h_;
        }

        IEnumerable<Observation> b_ = context.Operators.Where<Observation>(Obs, a_);
        return b_;
    }


    [CqlFunctionDefinition("Finished Encounter")]
    public IEnumerable<Encounter> Finished_Encounter(CqlContext context, IEnumerable<Encounter> Enc)
    {

        bool? a_(Encounter E) {
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
            bool? h_ = context.Operators.In<string>(f_, (IEnumerable<string>)g_);
            return h_;
        }

        IEnumerable<Encounter> b_ = context.Operators.Where<Encounter>(Enc, a_);
        return b_;
    }


    [CqlFunctionDefinition("isEncounterPerformed")]
    public IEnumerable<Encounter> isEncounterPerformed(CqlContext context, IEnumerable<Encounter> Enc)
    {

        bool? a_(Encounter E) {
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
            bool? h_ = context.Operators.In<string>(f_, (IEnumerable<string>)g_);
            return h_;
        }

        IEnumerable<Encounter> b_ = context.Operators.Where<Encounter>(Enc, a_);
        return b_;
    }


    [CqlFunctionDefinition("Completed Immunization")]
    public IEnumerable<Immunization> Completed_Immunization(CqlContext context, IEnumerable<Immunization> Immunization)
    {

        bool? a_(Immunization I) {
            Code<Immunization.ImmunizationStatusCodes> c_ = I?.StatusElement;
            Immunization.ImmunizationStatusCodes? d_ = c_?.Value;
            string e_ = context.Operators.Convert<string>(d_);
            bool? f_ = context.Operators.Equivalent(e_, "completed");
            return f_;
        }

        IEnumerable<Immunization> b_ = context.Operators.Where<Immunization>(Immunization, a_);
        return b_;
    }


    [CqlFunctionDefinition("isImmunizationAdministered")]
    public IEnumerable<Immunization> isImmunizationAdministered(CqlContext context, IEnumerable<Immunization> Immunization)
    {

        bool? a_(Immunization I) {
            Code<Immunization.ImmunizationStatusCodes> c_ = I?.StatusElement;
            Immunization.ImmunizationStatusCodes? d_ = c_?.Value;
            string e_ = context.Operators.Convert<string>(d_);
            bool? f_ = context.Operators.Equivalent(e_, "completed");
            return f_;
        }

        IEnumerable<Immunization> b_ = context.Operators.Where<Immunization>(Immunization, a_);
        return b_;
    }


    [CqlFunctionDefinition("Completed Procedure")]
    public IEnumerable<Procedure> Completed_Procedure(CqlContext context, IEnumerable<Procedure> Proc)
    {

        bool? a_(Procedure P) {
            Code<EventStatus> c_ = P?.StatusElement;
            EventStatus? d_ = c_?.Value;
            string e_ = context.Operators.Convert<string>(d_);
            bool? f_ = context.Operators.Equivalent(e_, "completed");
            return f_;
        }

        IEnumerable<Procedure> b_ = context.Operators.Where<Procedure>(Proc, a_);
        return b_;
    }


    [CqlFunctionDefinition("isInterventionPerformed")]
    public IEnumerable<Procedure> isInterventionPerformed(CqlContext context, IEnumerable<Procedure> Proc)
    {

        bool? a_(Procedure P) {
            Code<EventStatus> c_ = P?.StatusElement;
            EventStatus? d_ = c_?.Value;
            string e_ = context.Operators.Convert<string>(d_);
            bool? f_ = context.Operators.Equivalent(e_, "completed");
            return f_;
        }

        IEnumerable<Procedure> b_ = context.Operators.Where<Procedure>(Proc, a_);
        return b_;
    }


    [CqlFunctionDefinition("isProcedurePerformed")]
    public IEnumerable<Procedure> isProcedurePerformed(CqlContext context, IEnumerable<Procedure> Proc)
    {

        bool? a_(Procedure P) {
            Code<EventStatus> c_ = P?.StatusElement;
            EventStatus? d_ = c_?.Value;
            string e_ = context.Operators.Convert<string>(d_);
            bool? f_ = context.Operators.Equivalent(e_, "completed");
            return f_;
        }

        IEnumerable<Procedure> b_ = context.Operators.Where<Procedure>(Proc, a_);
        return b_;
    }


    [CqlFunctionDefinition("Final Lab Observation")]
    public IEnumerable<Observation> Final_Lab_Observation(CqlContext context, IEnumerable<Observation> Obs)
    {

        bool? a_(Observation O) {
            Code<ObservationStatus> c_ = O?.StatusElement;
            ObservationStatus? d_ = c_?.Value;
            Code<ObservationStatus> e_ = context.Operators.Convert<Code<ObservationStatus>>(d_);
            string f_ = context.Operators.Convert<string>(e_);
            string[] g_ = [
                "final",
                "amended",
                "corrected",
            ];
            bool? h_ = context.Operators.In<string>(f_, (IEnumerable<string>)g_);
            List<CodeableConcept> i_ = O?.Category;

            CqlConcept j_(CodeableConcept @this) {
                CqlConcept p_ = FHIRHelpers_4_3_000.Instance.ToConcept(context, @this);
                return p_;
            }

            IEnumerable<CqlConcept> k_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)i_, j_);

            bool? l_(CqlConcept ObservationCategory) {
                CqlCode q_ = this.laboratory(context);
                CqlConcept r_ = context.Operators.ConvertCodeToConcept(q_);
                bool? s_ = context.Operators.Equivalent(ObservationCategory, r_);
                return s_;
            }

            IEnumerable<CqlConcept> m_ = context.Operators.Where<CqlConcept>(k_, l_);
            bool? n_ = context.Operators.Exists<CqlConcept>(m_);
            bool? o_ = context.Operators.And(h_, n_);
            return o_;
        }

        IEnumerable<Observation> b_ = context.Operators.Where<Observation>(Obs, a_);
        return b_;
    }


    [CqlFunctionDefinition("isLaboratoryTestPerformed")]
    public IEnumerable<Observation> isLaboratoryTestPerformed(CqlContext context, IEnumerable<Observation> Obs)
    {

        bool? a_(Observation O) {
            Code<ObservationStatus> c_ = O?.StatusElement;
            ObservationStatus? d_ = c_?.Value;
            Code<ObservationStatus> e_ = context.Operators.Convert<Code<ObservationStatus>>(d_);
            string f_ = context.Operators.Convert<string>(e_);
            string[] g_ = [
                "final",
                "amended",
                "corrected",
            ];
            bool? h_ = context.Operators.In<string>(f_, (IEnumerable<string>)g_);
            List<CodeableConcept> i_ = O?.Category;

            CqlConcept j_(CodeableConcept @this) {
                CqlConcept p_ = FHIRHelpers_4_3_000.Instance.ToConcept(context, @this);
                return p_;
            }

            IEnumerable<CqlConcept> k_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)i_, j_);

            bool? l_(CqlConcept ObservationCategory) {
                CqlCode q_ = this.laboratory(context);
                CqlConcept r_ = context.Operators.ConvertCodeToConcept(q_);
                bool? s_ = context.Operators.Equivalent(ObservationCategory, r_);
                return s_;
            }

            IEnumerable<CqlConcept> m_ = context.Operators.Where<CqlConcept>(k_, l_);
            bool? n_ = context.Operators.Exists<CqlConcept>(m_);
            bool? o_ = context.Operators.And(h_, n_);
            return o_;
        }

        IEnumerable<Observation> b_ = context.Operators.Where<Observation>(Obs, a_);
        return b_;
    }


    [CqlFunctionDefinition("Active Medication")]
    public IEnumerable<MedicationRequest> Active_Medication(CqlContext context, IEnumerable<MedicationRequest> MedicationRequest)
    {

        bool? a_(MedicationRequest M) {
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
        }

        IEnumerable<MedicationRequest> b_ = context.Operators.Where<MedicationRequest>(MedicationRequest, a_);
        return b_;
    }


    [CqlFunctionDefinition("isMedicationActive")]
    public IEnumerable<MedicationRequest> isMedicationActive(CqlContext context, IEnumerable<MedicationRequest> MedicationRequest)
    {

        bool? a_(MedicationRequest M) {
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
        }

        IEnumerable<MedicationRequest> b_ = context.Operators.Where<MedicationRequest>(MedicationRequest, a_);
        return b_;
    }


    [CqlFunctionDefinition("Dispensed Medication")]
    public IEnumerable<MedicationDispense> Dispensed_Medication(CqlContext context, IEnumerable<MedicationDispense> Med)
    {

        bool? a_(MedicationDispense M) {
            Code<MedicationDispense.MedicationDispenseStatusCodes> c_ = M?.StatusElement;
            MedicationDispense.MedicationDispenseStatusCodes? d_ = c_?.Value;
            Code<MedicationDispense.MedicationDispenseStatusCodes> e_ = context.Operators.Convert<Code<MedicationDispense.MedicationDispenseStatusCodes>>(d_);
            string f_ = context.Operators.Convert<string>(e_);
            string[] g_ = [
                "completed",
                "in-progress",
                "on-hold",
            ];
            bool? h_ = context.Operators.In<string>(f_, (IEnumerable<string>)g_);
            return h_;
        }

        IEnumerable<MedicationDispense> b_ = context.Operators.Where<MedicationDispense>(Med, a_);
        return b_;
    }


    [CqlFunctionDefinition("isMedicationDispensed")]
    public IEnumerable<MedicationDispense> isMedicationDispensed(CqlContext context, IEnumerable<MedicationDispense> Med)
    {

        bool? a_(MedicationDispense M) {
            Code<MedicationDispense.MedicationDispenseStatusCodes> c_ = M?.StatusElement;
            MedicationDispense.MedicationDispenseStatusCodes? d_ = c_?.Value;
            Code<MedicationDispense.MedicationDispenseStatusCodes> e_ = context.Operators.Convert<Code<MedicationDispense.MedicationDispenseStatusCodes>>(d_);
            string f_ = context.Operators.Convert<string>(e_);
            string[] g_ = [
                "completed",
                "in-progress",
                "on-hold",
            ];
            bool? h_ = context.Operators.In<string>(f_, (IEnumerable<string>)g_);
            return h_;
        }

        IEnumerable<MedicationDispense> b_ = context.Operators.Where<MedicationDispense>(Med, a_);
        return b_;
    }


    [CqlFunctionDefinition("Active or Completed Medication Request")]
    public IEnumerable<MedicationRequest> Active_or_Completed_Medication_Request(CqlContext context, IEnumerable<MedicationRequest> MedicationRequest)
    {

        bool? a_(MedicationRequest M) {
            Code<MedicationRequest.MedicationrequestStatus> c_ = M?.StatusElement;
            MedicationRequest.MedicationrequestStatus? d_ = c_?.Value;
            string e_ = context.Operators.Convert<string>(d_);
            string[] f_ = [
                "active",
                "completed",
            ];
            bool? g_ = context.Operators.In<string>(e_, (IEnumerable<string>)f_);
            Code<MedicationRequest.MedicationRequestIntent> h_ = M?.IntentElement;
            MedicationRequest.MedicationRequestIntent? i_ = h_?.Value;
            string j_ = context.Operators.Convert<string>(i_);
            bool? k_ = context.Operators.Equal(j_, "order");
            bool? l_ = context.Operators.And(g_, k_);
            return l_;
        }

        IEnumerable<MedicationRequest> b_ = context.Operators.Where<MedicationRequest>(MedicationRequest, a_);
        return b_;
    }


    [CqlFunctionDefinition("isMedicationOrder")]
    public IEnumerable<MedicationRequest> isMedicationOrder(CqlContext context, IEnumerable<MedicationRequest> MedicationRequest)
    {

        bool? a_(MedicationRequest M) {
            Code<MedicationRequest.MedicationrequestStatus> c_ = M?.StatusElement;
            MedicationRequest.MedicationrequestStatus? d_ = c_?.Value;
            string e_ = context.Operators.Convert<string>(d_);
            string[] f_ = [
                "active",
                "completed",
            ];
            bool? g_ = context.Operators.In<string>(e_, (IEnumerable<string>)f_);
            Code<MedicationRequest.MedicationRequestIntent> h_ = M?.IntentElement;
            MedicationRequest.MedicationRequestIntent? i_ = h_?.Value;
            string j_ = context.Operators.Convert<string>(i_);
            bool? k_ = context.Operators.Equal(j_, "order");
            bool? l_ = context.Operators.And(g_, k_);
            return l_;
        }

        IEnumerable<MedicationRequest> b_ = context.Operators.Where<MedicationRequest>(MedicationRequest, a_);
        return b_;
    }


    [CqlFunctionDefinition("Final Exam Observation")]
    public IEnumerable<Observation> Final_Exam_Observation(CqlContext context, IEnumerable<Observation> Obs)
    {

        bool? a_(Observation O) {
            Code<ObservationStatus> c_ = O?.StatusElement;
            ObservationStatus? d_ = c_?.Value;
            Code<ObservationStatus> e_ = context.Operators.Convert<Code<ObservationStatus>>(d_);
            string f_ = context.Operators.Convert<string>(e_);
            string[] g_ = [
                "final",
                "amended",
                "corrected",
            ];
            bool? h_ = context.Operators.In<string>(f_, (IEnumerable<string>)g_);
            List<CodeableConcept> i_ = O?.Category;

            CqlConcept j_(CodeableConcept @this) {
                CqlConcept p_ = FHIRHelpers_4_3_000.Instance.ToConcept(context, @this);
                return p_;
            }

            IEnumerable<CqlConcept> k_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)i_, j_);

            bool? l_(CqlConcept ObservationCategory) {
                CqlCode q_ = this.exam(context);
                CqlConcept r_ = context.Operators.ConvertCodeToConcept(q_);
                bool? s_ = context.Operators.Equivalent(ObservationCategory, r_);
                return s_;
            }

            IEnumerable<CqlConcept> m_ = context.Operators.Where<CqlConcept>(k_, l_);
            bool? n_ = context.Operators.Exists<CqlConcept>(m_);
            bool? o_ = context.Operators.And(h_, n_);
            return o_;
        }

        IEnumerable<Observation> b_ = context.Operators.Where<Observation>(Obs, a_);
        return b_;
    }


    [CqlFunctionDefinition("isPhysicalExamPerformed")]
    public IEnumerable<Observation> isPhysicalExamPerformed(CqlContext context, IEnumerable<Observation> Obs)
    {

        bool? a_(Observation O) {
            Code<ObservationStatus> c_ = O?.StatusElement;
            ObservationStatus? d_ = c_?.Value;
            Code<ObservationStatus> e_ = context.Operators.Convert<Code<ObservationStatus>>(d_);
            string f_ = context.Operators.Convert<string>(e_);
            string[] g_ = [
                "final",
                "amended",
                "corrected",
            ];
            bool? h_ = context.Operators.In<string>(f_, (IEnumerable<string>)g_);
            List<CodeableConcept> i_ = O?.Category;

            CqlConcept j_(CodeableConcept @this) {
                CqlConcept p_ = FHIRHelpers_4_3_000.Instance.ToConcept(context, @this);
                return p_;
            }

            IEnumerable<CqlConcept> k_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)i_, j_);

            bool? l_(CqlConcept ObservationCategory) {
                CqlCode q_ = this.exam(context);
                CqlConcept r_ = context.Operators.ConvertCodeToConcept(q_);
                bool? s_ = context.Operators.Equivalent(ObservationCategory, r_);
                return s_;
            }

            IEnumerable<CqlConcept> m_ = context.Operators.Where<CqlConcept>(k_, l_);
            bool? n_ = context.Operators.Exists<CqlConcept>(m_);
            bool? o_ = context.Operators.And(h_, n_);
            return o_;
        }

        IEnumerable<Observation> b_ = context.Operators.Where<Observation>(Obs, a_);
        return b_;
    }


    [CqlFunctionDefinition("BloodPressure")]
    public IEnumerable<Observation> BloodPressure(CqlContext context, IEnumerable<Observation> Obs)
    {

        bool? a_(Observation O) {
            Code<ObservationStatus> c_ = O?.StatusElement;
            ObservationStatus? d_ = c_?.Value;
            string e_ = context.Operators.Convert<string>(d_);
            string[] f_ = [
                "final",
                "amended",
                "corrected",
            ];
            bool? g_ = context.Operators.In<string>(e_, (IEnumerable<string>)f_);
            return g_;
        }

        IEnumerable<Observation> b_ = context.Operators.Where<Observation>(Obs, a_);
        return b_;
    }


    [CqlFunctionDefinition("BodyHeight")]
    public IEnumerable<Observation> BodyHeight(CqlContext context, IEnumerable<Observation> Obs)
    {

        bool? a_(Observation O) {
            Code<ObservationStatus> c_ = O?.StatusElement;
            ObservationStatus? d_ = c_?.Value;
            string e_ = context.Operators.Convert<string>(d_);
            string[] f_ = [
                "final",
                "amended",
                "corrected",
            ];
            bool? g_ = context.Operators.In<string>(e_, (IEnumerable<string>)f_);
            return g_;
        }

        IEnumerable<Observation> b_ = context.Operators.Where<Observation>(Obs, a_);
        return b_;
    }


    [CqlFunctionDefinition("BodyWeight")]
    public IEnumerable<Observation> BodyWeight(CqlContext context, IEnumerable<Observation> Obs)
    {

        bool? a_(Observation O) {
            Code<ObservationStatus> c_ = O?.StatusElement;
            ObservationStatus? d_ = c_?.Value;
            string e_ = context.Operators.Convert<string>(d_);
            string[] f_ = [
                "final",
                "amended",
                "corrected",
            ];
            bool? g_ = context.Operators.In<string>(e_, (IEnumerable<string>)f_);
            return g_;
        }

        IEnumerable<Observation> b_ = context.Operators.Where<Observation>(Obs, a_);
        return b_;
    }


    [CqlFunctionDefinition("BMI")]
    public IEnumerable<Observation> BMI(CqlContext context, IEnumerable<Observation> Obs)
    {

        bool? a_(Observation O) {
            Code<ObservationStatus> c_ = O?.StatusElement;
            ObservationStatus? d_ = c_?.Value;
            string e_ = context.Operators.Convert<string>(d_);
            string[] f_ = [
                "final",
                "amended",
                "corrected",
            ];
            bool? g_ = context.Operators.In<string>(e_, (IEnumerable<string>)f_);
            return g_;
        }

        IEnumerable<Observation> b_ = context.Operators.Where<Observation>(Obs, a_);
        return b_;
    }


    [CqlFunctionDefinition("isObservationBP")]
    public IEnumerable<Observation> isObservationBP(CqlContext context, IEnumerable<Observation> Obs)
    {

        bool? a_(Observation O) {
            Code<ObservationStatus> c_ = O?.StatusElement;
            ObservationStatus? d_ = c_?.Value;
            string e_ = context.Operators.Convert<string>(d_);
            string[] f_ = [
                "final",
                "amended",
                "corrected",
            ];
            bool? g_ = context.Operators.In<string>(e_, (IEnumerable<string>)f_);
            return g_;
        }

        IEnumerable<Observation> b_ = context.Operators.Where<Observation>(Obs, a_);
        return b_;
    }


    [CqlFunctionDefinition("isObservationBodyHeight")]
    public IEnumerable<Observation> isObservationBodyHeight(CqlContext context, IEnumerable<Observation> Obs)
    {

        bool? a_(Observation O) {
            Code<ObservationStatus> c_ = O?.StatusElement;
            ObservationStatus? d_ = c_?.Value;
            string e_ = context.Operators.Convert<string>(d_);
            string[] f_ = [
                "final",
                "amended",
                "corrected",
            ];
            bool? g_ = context.Operators.In<string>(e_, (IEnumerable<string>)f_);
            return g_;
        }

        IEnumerable<Observation> b_ = context.Operators.Where<Observation>(Obs, a_);
        return b_;
    }


    [CqlFunctionDefinition("isObservationBodyWeight")]
    public IEnumerable<Observation> isObservationBodyWeight(CqlContext context, IEnumerable<Observation> Obs)
    {

        bool? a_(Observation O) {
            Code<ObservationStatus> c_ = O?.StatusElement;
            ObservationStatus? d_ = c_?.Value;
            string e_ = context.Operators.Convert<string>(d_);
            string[] f_ = [
                "final",
                "amended",
                "corrected",
            ];
            bool? g_ = context.Operators.In<string>(e_, (IEnumerable<string>)f_);
            return g_;
        }

        IEnumerable<Observation> b_ = context.Operators.Where<Observation>(Obs, a_);
        return b_;
    }


    [CqlFunctionDefinition("isObservationBMI")]
    public IEnumerable<Observation> isObservationBMI(CqlContext context, IEnumerable<Observation> Obs)
    {

        bool? a_(Observation O) {
            Code<ObservationStatus> c_ = O?.StatusElement;
            ObservationStatus? d_ = c_?.Value;
            string e_ = context.Operators.Convert<string>(d_);
            string[] f_ = [
                "final",
                "amended",
                "corrected",
            ];
            bool? g_ = context.Operators.In<string>(e_, (IEnumerable<string>)f_);
            return g_;
        }

        IEnumerable<Observation> b_ = context.Operators.Where<Observation>(Obs, a_);
        return b_;
    }


    [CqlFunctionDefinition("Initial or Final Observation")]
    public IEnumerable<Observation> Initial_or_Final_Observation(CqlContext context, IEnumerable<Observation> Obs)
    {

        bool? a_(Observation O) {
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
            bool? h_ = context.Operators.In<string>(f_, (IEnumerable<string>)g_);
            return h_;
        }

        IEnumerable<Observation> b_ = context.Operators.Where<Observation>(Obs, a_);
        return b_;
    }


    [CqlFunctionDefinition("isSymptom")]
    public IEnumerable<Observation> isSymptom(CqlContext context, IEnumerable<Observation> Obs)
    {

        bool? a_(Observation O) {
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
            bool? h_ = context.Operators.In<string>(f_, (IEnumerable<string>)g_);
            return h_;
        }

        IEnumerable<Observation> b_ = context.Operators.Where<Observation>(Obs, a_);
        return b_;
    }


    #endregion Functions and Expressions

    #region Singleton Lifetime Members

    private Status_1_6_000() {}

    public static Status_1_6_000 Instance { get; } = new();

    #endregion

    #region ILibrary Implementation

    public string Name => "Status";
    public string Version => "1.6.000";
    public ILibrary[] Dependencies => [FHIRHelpers_4_3_000.Instance];

    #endregion ILibrary Implementation

}
