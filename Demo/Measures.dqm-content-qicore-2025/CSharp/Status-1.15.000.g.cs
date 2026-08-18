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

[System.CodeDom.Compiler.GeneratedCode(".NET Code Generation", "5.3.5.0")]
[CqlLibrary("Status", "1.15.000")]
public partial class Status_1_15_000 : ILibrary, ISingleton<Status_1_15_000>
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
        context.GetOrCompute(_cacheIndex_Patient, Patient_Compute);

    private const long _cacheIndex_Patient = 1021606727424411750L;

    private Patient Patient_Compute(CqlContext context)
    {
        IEnumerable<Patient> a_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-patient"));
        Patient b_ = context.Operators.SingletonFrom<Patient>(a_);
        return b_;
    }


    [CqlFunctionDefinition("verified")]
    public IEnumerable<Condition> verified(CqlContext context, IEnumerable<Condition> conditions)
    {

        bool? a_(Condition C) {
            CodeableConcept c_ = C?.VerificationStatus;
            CqlConcept d_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, c_);

            CqlBoolean e_() {
                CodeableConcept f_ = C?.VerificationStatus;
                CqlConcept g_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, f_);
                CqlCode h_ = this.confirmed(context);
                CqlConcept i_ = context.Operators.ConvertCodeToConcept(h_);
                CqlBoolean j_ = context.Operators.Equivalent(g_, i_);

                CqlBoolean k_() {
                    CodeableConcept n_ = C?.VerificationStatus;
                    CqlConcept o_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, n_);
                    CqlCode p_ = this.unconfirmed(context);
                    CqlConcept q_ = context.Operators.ConvertCodeToConcept(p_);
                    CqlBoolean r_ = context.Operators.Equivalent(o_, q_);
                    return r_;
                }


                CqlBoolean l_() {
                    CodeableConcept s_ = C?.VerificationStatus;
                    CqlConcept t_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, s_);
                    CqlCode u_ = this.provisional(context);
                    CqlConcept v_ = context.Operators.ConvertCodeToConcept(u_);
                    CqlBoolean w_ = context.Operators.Equivalent(t_, v_);
                    return w_;
                }


                CqlBoolean m_() {
                    CodeableConcept x_ = C?.VerificationStatus;
                    CqlConcept y_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, x_);
                    CqlCode z_ = this.differential(context);
                    CqlConcept aa_ = context.Operators.ConvertCodeToConcept(z_);
                    CqlBoolean ab_ = context.Operators.Equivalent(y_, aa_);
                    return ab_;
                }

                return j_
                    /* CQL 'or' (26:8-27:47) */ || k_()
                    /* CQL 'or' (26:8-28:47) */ || l_()
                    /* CQL 'or' (26:7-30:7) */ || m_();
            }

            return (CqlBoolean)(!(!((bool?)(d_ is null))))
                /* CQL 'implies' (25:5-30:7) */ || e_();
        }

        IEnumerable<Condition> b_ = context.Operators.Where<Condition>(conditions, a_);
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
            CqlBoolean g_ = context.Operators.In<string>(e_, (IEnumerable<string>)f_);
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
            CqlBoolean h_ = context.Operators.In<string>(f_, (IEnumerable<string>)g_);

            CqlBoolean i_() {
                Code<RequestIntent> j_ = D?.IntentElement;
                RequestIntent? k_ = j_?.Value;
                Code<RequestIntent> l_ = context.Operators.Convert<Code<RequestIntent>>(k_);
                string m_ = context.Operators.Convert<string>(l_);
                string[] n_ = [
                    "order",
                    "original-order",
                    "reflex-order",
                    "filler-order",
                    "instance-order",
                ];
                CqlBoolean o_ = context.Operators.In<string>(m_, (IEnumerable<string>)n_);
                return o_;
            }

            return h_
                /* CQL 'and' (40:5-41:99) */ && i_();
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
            CqlBoolean h_ = context.Operators.In<string>(f_, (IEnumerable<string>)g_);

            CqlBoolean i_() {
                Code<RequestIntent> j_ = S?.IntentElement;
                RequestIntent? k_ = j_?.Value;
                Code<RequestIntent> l_ = context.Operators.Convert<Code<RequestIntent>>(k_);
                string m_ = context.Operators.Convert<string>(l_);
                string[] n_ = [
                    "order",
                    "original-order",
                    "reflex-order",
                    "filler-order",
                    "instance-order",
                ];
                CqlBoolean o_ = context.Operators.In<string>(m_, (IEnumerable<string>)n_);
                return o_;
            }

            return h_
                /* CQL 'and' (46:5-47:99) */ && i_();
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
            CqlBoolean h_ = context.Operators.In<string>(f_, (IEnumerable<string>)g_);

            CqlBoolean i_() {
                Code<RequestIntent> j_ = S?.IntentElement;
                RequestIntent? k_ = j_?.Value;
                Code<RequestIntent> l_ = context.Operators.Convert<Code<RequestIntent>>(k_);
                string m_ = context.Operators.Convert<string>(l_);
                string[] n_ = [
                    "order",
                    "original-order",
                    "reflex-order",
                    "filler-order",
                    "instance-order",
                ];
                CqlBoolean o_ = context.Operators.In<string>(m_, (IEnumerable<string>)n_);
                return o_;
            }

            return h_
                /* CQL 'and' (52:5-53:99) */ && i_();
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
            CqlBoolean h_ = context.Operators.In<string>(f_, (IEnumerable<string>)g_);

            CqlBoolean i_() {
                Code<RequestIntent> j_ = S?.IntentElement;
                RequestIntent? k_ = j_?.Value;
                Code<RequestIntent> l_ = context.Operators.Convert<Code<RequestIntent>>(k_);
                string m_ = context.Operators.Convert<string>(l_);
                string[] n_ = [
                    "order",
                    "original-order",
                    "reflex-order",
                    "filler-order",
                    "instance-order",
                ];
                CqlBoolean o_ = context.Operators.In<string>(m_, (IEnumerable<string>)n_);
                return o_;
            }

            return h_
                /* CQL 'and' (58:5-59:99) */ && i_();
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
            CqlBoolean g_ = context.Operators.In<string>(e_, (IEnumerable<string>)f_);

            CqlBoolean h_() {
                List<CodeableConcept> i_ = O?.Category;

                CqlConcept j_(CodeableConcept @this) {
                    CqlConcept n_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);
                    return n_;
                }


                bool? k_(CqlConcept ObservationCategory) {
                    CqlCode o_ = this.imaging(context);
                    CqlConcept p_ = context.Operators.ConvertCodeToConcept(o_);
                    CqlBoolean q_ = context.Operators.Equivalent(ObservationCategory, p_);
                    return q_;
                }

                IEnumerable<CqlConcept> l_ = context.Operators.SelectWhere<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)i_, j_, k_);
                CqlBoolean m_ = context.Operators.Exists<CqlConcept>(l_);
                return m_;
            }

            return g_
                /* CQL 'and' (64:5-67:5) */ && h_();
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
            CqlBoolean f_ = context.Operators.Equal(e_, "finished");
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
            CqlBoolean f_ = context.Operators.Equivalent(e_, "completed");
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
            CqlBoolean f_ = context.Operators.Equivalent(e_, "completed");
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
            CqlBoolean f_ = context.Operators.Equivalent(e_, "completed");
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
            CqlBoolean g_ = context.Operators.In<string>(e_, (IEnumerable<string>)f_);
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
            CqlBoolean f_ = context.Operators.Equal(e_, "active");

            CqlBoolean g_() {
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
                CqlBoolean l_ = context.Operators.In<string>(j_, (IEnumerable<string>)k_);
                return l_;
            }

            return f_
                /* CQL 'and' (98:5-99:99) */ && g_();
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
            CqlBoolean g_ = context.Operators.In<string>(e_, (IEnumerable<string>)f_);
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
            CqlBoolean g_ = context.Operators.In<string>(e_, (IEnumerable<string>)f_);

            CqlBoolean h_() {
                Code<MedicationRequest.MedicationRequestIntent> i_ = M?.IntentElement;
                MedicationRequest.MedicationRequestIntent? j_ = i_?.Value;
                string k_ = context.Operators.Convert<string>(j_);
                string[] l_ = [
                    "order",
                    "original-order",
                    "reflex-order",
                    "filler-order",
                    "instance-order",
                ];
                CqlBoolean m_ = context.Operators.In<string>(k_, (IEnumerable<string>)l_);
                return m_;
            }

            return g_
                /* CQL 'and' (109:5-110:97) */ && h_();
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
            CqlBoolean g_ = context.Operators.In<string>(e_, (IEnumerable<string>)f_);

            CqlBoolean h_() {
                List<CodeableConcept> i_ = O?.Category;

                CqlConcept j_(CodeableConcept @this) {
                    CqlConcept n_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);
                    return n_;
                }


                bool? k_(CqlConcept ObservationCategory) {
                    CqlCode o_ = this.exam(context);
                    CqlConcept p_ = context.Operators.ConvertCodeToConcept(o_);
                    CqlBoolean q_ = context.Operators.Equivalent(ObservationCategory, p_);
                    return q_;
                }

                IEnumerable<CqlConcept> l_ = context.Operators.SelectWhere<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)i_, j_, k_);
                CqlBoolean m_ = context.Operators.Exists<CqlConcept>(l_);
                return m_;
            }

            return g_
                /* CQL 'and' (115:5-118:7) */ && h_();
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
            CqlBoolean g_ = context.Operators.In<string>(e_, (IEnumerable<string>)f_);
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
            CqlBoolean g_ = context.Operators.In<string>(e_, (IEnumerable<string>)f_);
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
            CqlBoolean g_ = context.Operators.In<string>(e_, (IEnumerable<string>)f_);
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
            CqlBoolean g_ = context.Operators.In<string>(e_, (IEnumerable<string>)f_);
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
            CqlBoolean g_ = context.Operators.In<string>(e_, (IEnumerable<string>)f_);
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
            CqlBoolean f_ = context.Operators.Equal(e_, "final");
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
            CqlBoolean g_ = context.Operators.In<string>(e_, (IEnumerable<string>)f_);
            return g_;
        }

        IEnumerable<Observation> b_ = context.Operators.Where<Observation>(Obs, a_);
        return b_;
    }


    #endregion Functions and Expressions

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
