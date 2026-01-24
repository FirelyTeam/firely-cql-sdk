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
using Hl7.Cql.Runtime.Internal;
using Hl7.Fhir.Model;
using Range = Hl7.Fhir.Model.Range;
using Task = Hl7.Fhir.Model.Task;

[System.CodeDom.Compiler.GeneratedCode(".NET Code Generation", "6.0.0.0")]
[CqlLibrary("Status", "1.15.000")]
public partial class Status_1_15_000 : ILibrary, ILibraryInternals, ISingleton<Status_1_15_000>
{
    #region Codes (6)

    [CqlCodeDefinition("exam", codeId: "exam", codeSystem: "http://terminology.hl7.org/CodeSystem/observation-category")]
    public CqlCode exam(CqlContext _) => _exam;
    private static readonly CqlCode _exam = new CqlCode("exam", "http://terminology.hl7.org/CodeSystem/observation-category");

    [CqlCodeDefinition("imaging", codeId: "imaging", codeSystem: "http://terminology.hl7.org/CodeSystem/observation-category")]
    public CqlCode imaging(CqlContext _) => _imaging;
    private static readonly CqlCode _imaging = new CqlCode("imaging", "http://terminology.hl7.org/CodeSystem/observation-category");

    [CqlCodeDefinition("confirmed", codeId: "confirmed", codeSystem: "http://terminology.hl7.org/CodeSystem/condition-ver-status")]
    public CqlCode confirmed(CqlContext _) => _confirmed;
    private static readonly CqlCode _confirmed = new CqlCode("confirmed", "http://terminology.hl7.org/CodeSystem/condition-ver-status");

    [CqlCodeDefinition("unconfirmed", codeId: "unconfirmed", codeSystem: "http://terminology.hl7.org/CodeSystem/condition-ver-status")]
    public CqlCode unconfirmed(CqlContext _) => _unconfirmed;
    private static readonly CqlCode _unconfirmed = new CqlCode("unconfirmed", "http://terminology.hl7.org/CodeSystem/condition-ver-status");

    [CqlCodeDefinition("provisional", codeId: "provisional", codeSystem: "http://terminology.hl7.org/CodeSystem/condition-ver-status")]
    public CqlCode provisional(CqlContext _) => _provisional;
    private static readonly CqlCode _provisional = new CqlCode("provisional", "http://terminology.hl7.org/CodeSystem/condition-ver-status");

    [CqlCodeDefinition("differential", codeId: "differential", codeSystem: "http://terminology.hl7.org/CodeSystem/condition-ver-status")]
    public CqlCode differential(CqlContext _) => _differential;
    private static readonly CqlCode _differential = new CqlCode("differential", "http://terminology.hl7.org/CodeSystem/condition-ver-status");

    #endregion Codes

    #region CodeSystems (2)

    [CqlCodeSystemDefinition("ObservationCategoryCodes", codeSystemId: "http://terminology.hl7.org/CodeSystem/observation-category", codeSystemVersion: null)]
    public CqlCodeSystem ObservationCategoryCodes(CqlContext _) => _ObservationCategoryCodes;
    private static readonly CqlCodeSystem _ObservationCategoryCodes =
      new CqlCodeSystem("http://terminology.hl7.org/CodeSystem/observation-category", null, [
          _exam,
          _imaging]);

    [CqlCodeSystemDefinition("ConditionVerificationStatusCodes", codeSystemId: "http://terminology.hl7.org/CodeSystem/condition-ver-status", codeSystemVersion: null)]
    public CqlCodeSystem ConditionVerificationStatusCodes(CqlContext _) => _ConditionVerificationStatusCodes;
    private static readonly CqlCodeSystem _ConditionVerificationStatusCodes =
      new CqlCodeSystem("http://terminology.hl7.org/CodeSystem/condition-ver-status", null, [
          _confirmed,
          _unconfirmed,
          _provisional,
          _differential]);

    #endregion CodeSystems

    #region Functions and Expressions (24)

    [CqlExpressionDefinition("Patient")]
    public Patient Patient(CqlContext context) =>
        _cache?.GetOrCompute(_cacheIndex_Patient, Patient_Compute, context) ?? Patient_Compute(context);

    private Patient Patient_Compute(CqlContext context)
    {
        IEnumerable<Patient> a_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-patient"));
        Patient b_ = context.Operators.SingletonFrom<Patient>(a_);
        return b_;
    }


    [CqlFunctionDefinition("verified")]
    public IEnumerable<object> verified(CqlContext context, IEnumerable<object> conditions)
    {

        bool? a_(object C) {
            object c_ = context.Operators.LateBoundProperty<object>(C, "verificationStatus");
            CqlConcept d_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, c_ as CodeableConcept);
            bool? e_ = context.Operators.Not((bool?)(d_ is null));
            CqlConcept g_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, c_ as CodeableConcept);
            CqlCode h_ = this.confirmed(context);
            CqlConcept i_ = context.Operators.ConvertCodeToConcept(h_);
            bool? j_ = context.Operators.Equivalent(g_, i_);
            CqlConcept l_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, c_ as CodeableConcept);
            CqlCode m_ = this.unconfirmed(context);
            CqlConcept n_ = context.Operators.ConvertCodeToConcept(m_);
            bool? o_ = context.Operators.Equivalent(l_, n_);
            bool? p_ = context.Operators.Or(j_, o_);
            CqlConcept r_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, c_ as CodeableConcept);
            CqlCode s_ = this.provisional(context);
            CqlConcept t_ = context.Operators.ConvertCodeToConcept(s_);
            bool? u_ = context.Operators.Equivalent(r_, t_);
            bool? v_ = context.Operators.Or(p_, u_);
            CqlConcept x_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, c_ as CodeableConcept);
            CqlCode y_ = this.differential(context);
            CqlConcept z_ = context.Operators.ConvertCodeToConcept(y_);
            bool? aa_ = context.Operators.Equivalent(x_, z_);
            bool? ab_ = context.Operators.Or(v_, aa_);
            bool? ac_ = context.Operators.Implies(e_, ab_);
            return ac_;
        }

        IEnumerable<object> b_ = context.Operators.Where<object>(conditions, a_);
        return b_;
    }


    [CqlFunctionDefinition("isAssessmentPerformed")]
    public IEnumerable<Observation> isAssessmentPerformed(CqlContext context, IEnumerable<Observation> Obs)
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


    [CqlFunctionDefinition("isDeviceOrderPersonalUseDevices")]
    public IEnumerable<DeviceRequest> isDeviceOrderPersonalUseDevices(CqlContext context, IEnumerable<DeviceRequest> DeviceRequest)
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
            string l_ = context.Operators.Convert<string>(k_);
            string[] m_ = [
                "order",
                "original-order",
                "reflex-order",
                "filler-order",
                "instance-order",
            ];
            bool? n_ = context.Operators.In<string>(l_, (IEnumerable<string>)m_);
            bool? o_ = context.Operators.And(h_, n_);
            return o_;
        }

        IEnumerable<DeviceRequest> b_ = context.Operators.Where<DeviceRequest>(DeviceRequest, a_);
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
            string l_ = context.Operators.Convert<string>(k_);
            string[] m_ = [
                "order",
                "original-order",
                "reflex-order",
                "filler-order",
                "instance-order",
            ];
            bool? n_ = context.Operators.In<string>(l_, (IEnumerable<string>)m_);
            bool? o_ = context.Operators.And(h_, n_);
            return o_;
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
            string l_ = context.Operators.Convert<string>(k_);
            string[] m_ = [
                "order",
                "original-order",
                "reflex-order",
                "filler-order",
                "instance-order",
            ];
            bool? n_ = context.Operators.In<string>(l_, (IEnumerable<string>)m_);
            bool? o_ = context.Operators.And(h_, n_);
            return o_;
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
            string l_ = context.Operators.Convert<string>(k_);
            string[] m_ = [
                "order",
                "original-order",
                "reflex-order",
                "filler-order",
                "instance-order",
            ];
            bool? n_ = context.Operators.In<string>(l_, (IEnumerable<string>)m_);
            bool? o_ = context.Operators.And(h_, n_);
            return o_;
        }

        IEnumerable<ServiceRequest> b_ = context.Operators.Where<ServiceRequest>(ServiceRequest, a_);
        return b_;
    }


    [CqlFunctionDefinition("isDiagnosticStudyPerformed")]
    public IEnumerable<Observation> isDiagnosticStudyPerformed(CqlContext context, IEnumerable<Observation> Obs)
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
            List<CodeableConcept> h_ = O?.Category;

            CqlConcept i_(CodeableConcept @this) {
                CqlConcept o_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);
                return o_;
            }

            IEnumerable<CqlConcept> j_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)h_, i_);

            bool? k_(CqlConcept ObservationCategory) {
                CqlCode p_ = this.imaging(context);
                CqlConcept q_ = context.Operators.ConvertCodeToConcept(p_);
                bool? r_ = context.Operators.Equivalent(ObservationCategory, q_);
                return r_;
            }

            IEnumerable<CqlConcept> l_ = context.Operators.Where<CqlConcept>(j_, k_);
            bool? m_ = context.Operators.Exists<CqlConcept>(l_);
            bool? n_ = context.Operators.And(g_, m_);
            return n_;
        }

        IEnumerable<Observation> b_ = context.Operators.Where<Observation>(Obs, a_);
        return b_;
    }


    [CqlFunctionDefinition("isEncounterPerformed")]
    public IEnumerable<Encounter> isEncounterPerformed(CqlContext context, IEnumerable<Encounter> Enc)
    {

        bool? a_(Encounter E) {
            Code<Encounter.EncounterStatus> c_ = E?.StatusElement;
            Encounter.EncounterStatus? d_ = c_?.Value;
            Code<Encounter.EncounterStatus> e_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(d_);
            bool? f_ = context.Operators.Equal(e_, "finished");
            return f_;
        }

        IEnumerable<Encounter> b_ = context.Operators.Where<Encounter>(Enc, a_);
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


    [CqlFunctionDefinition("isLaboratoryTestPerformed")]
    public IEnumerable<Observation> isLaboratoryTestPerformed(CqlContext context, IEnumerable<Observation> Obs)
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
            string[] j_ = [
                "order",
                "original-order",
                "reflex-order",
                "filler-order",
                "instance-order",
            ];
            bool? k_ = context.Operators.In<string>(i_, (IEnumerable<string>)j_);
            bool? l_ = context.Operators.And(f_, k_);
            return l_;
        }

        IEnumerable<MedicationRequest> b_ = context.Operators.Where<MedicationRequest>(MedicationRequest, a_);
        return b_;
    }


    [CqlFunctionDefinition("isMedicationDispensed")]
    public IEnumerable<MedicationDispense> isMedicationDispensed(CqlContext context, IEnumerable<MedicationDispense> Med)
    {

        bool? a_(MedicationDispense M) {
            Code<MedicationDispense.MedicationDispenseStatusCodes> c_ = M?.StatusElement;
            MedicationDispense.MedicationDispenseStatusCodes? d_ = c_?.Value;
            string e_ = context.Operators.Convert<string>(d_);
            string[] f_ = [
                "completed",
                "in-progress",
                "on-hold",
            ];
            bool? g_ = context.Operators.In<string>(e_, (IEnumerable<string>)f_);
            return g_;
        }

        IEnumerable<MedicationDispense> b_ = context.Operators.Where<MedicationDispense>(Med, a_);
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
            string[] k_ = [
                "order",
                "original-order",
                "reflex-order",
                "filler-order",
                "instance-order",
            ];
            bool? l_ = context.Operators.In<string>(j_, (IEnumerable<string>)k_);
            bool? m_ = context.Operators.And(g_, l_);
            return m_;
        }

        IEnumerable<MedicationRequest> b_ = context.Operators.Where<MedicationRequest>(MedicationRequest, a_);
        return b_;
    }


    [CqlFunctionDefinition("isPhysicalExamPerformed")]
    public IEnumerable<Observation> isPhysicalExamPerformed(CqlContext context, IEnumerable<Observation> Obs)
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
            List<CodeableConcept> h_ = O?.Category;

            CqlConcept i_(CodeableConcept @this) {
                CqlConcept o_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);
                return o_;
            }

            IEnumerable<CqlConcept> j_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)h_, i_);

            bool? k_(CqlConcept ObservationCategory) {
                CqlCode p_ = this.exam(context);
                CqlConcept q_ = context.Operators.ConvertCodeToConcept(p_);
                bool? r_ = context.Operators.Equivalent(ObservationCategory, q_);
                return r_;
            }

            IEnumerable<CqlConcept> l_ = context.Operators.Where<CqlConcept>(j_, k_);
            bool? m_ = context.Operators.Exists<CqlConcept>(l_);
            bool? n_ = context.Operators.And(g_, m_);
            return n_;
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


    [CqlFunctionDefinition("isObservationPediatricBMI")]
    public IEnumerable<Observation> isObservationPediatricBMI(CqlContext context, IEnumerable<Observation> Obs)
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


    [CqlFunctionDefinition("isObservationSmokingStatus")]
    public IEnumerable<Observation> isObservationSmokingStatus(CqlContext context, IEnumerable<Observation> Obs)
    {

        bool? a_(Observation O) {
            Code<ObservationStatus> c_ = O?.StatusElement;
            ObservationStatus? d_ = c_?.Value;
            string e_ = context.Operators.Convert<string>(d_);
            bool? f_ = context.Operators.Equal(e_, "final");
            return f_;
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
            string e_ = context.Operators.Convert<string>(d_);
            string[] f_ = [
                "preliminary",
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


    #endregion Functions and Expressions

    #region Cache Index Fields (1)

    private int _cacheIndex_Patient = -1;

    #endregion Cache Index Fields

    #region ILibraryInternals Implementation

    private CqlLibraryInvocationCache _cache = CqlLibraryInvocationCache.NeverCached;

    /// <summary>
    /// Initializes cache indices for this library's cached expressions.
    /// </summary>
    /// <param name="libraryInvocationSet">The library invocation set performing initialization.</param>
    /// <param name="startIndex">The starting index for cache field assignment.</param>
    /// <returns>The number of cache indices initialized (number of cached expressions in this library).</returns>
    int ILibraryInternals.InitializeCacheIndices(
        CqlLibraryInvocationSet libraryInvocationSet,
        int startIndex)
    {
        var index = startIndex;
        _cacheIndex_Patient = index++;
        return index - startIndex;
    }

    /// <summary>
    /// Sets the cache instance that this library will use for caching computed values.
    /// </summary>
    /// <param name="cache">The cache instance to use.</param>
    void ILibraryInternals.SetCacheInstance(CqlLibraryInvocationCache cache)
    {
        _cache = cache;
    }

    #endregion ILibraryInternals Implementation

    #region Singleton Lifetime Members

    private Status_1_15_000() {}

    public static Status_1_15_000 Instance { get; } = new();

    #endregion

    #region ILibrary Implementation

    public string Name => "Status";
    public string Version => "1.15.000";
    public ILibrary[] Dependencies => [FHIRHelpers_4_4_000.Instance];

    #endregion ILibrary Implementation

}
