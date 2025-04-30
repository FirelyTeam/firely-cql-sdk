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

[System.CodeDom.Compiler.GeneratedCode(".NET Code Generation", "3.0.0.0")]
[CqlLibrary("Status", "1.8.000")]
public partial class Status_1_8_000 : ILibrary, ISingleton<Status_1_8_000>
{
    private Status_1_8_000() {}

    public static Status_1_8_000 Instance { get; } = new();

    #region ILibrary Implementation

    public string Name => "Status";
    public string Version => "1.8.000";
    public ILibrary[] Dependencies => [FHIRHelpers_4_4_000.Instance];

    #endregion ILibrary Implementation

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

    #endregion Codes

    #region CodeSystems

    [CqlCodeSystemDefinition("ObservationCategoryCodes")]
    public CqlCodeSystem ObservationCategoryCodes(CqlContext _) => _ObservationCategoryCodes;
    private static readonly CqlCodeSystem _ObservationCategoryCodes =
      new CqlCodeSystem("http://terminology.hl7.org/CodeSystem/observation-category", null, [
          _laboratory,
          _exam,
          _survey]);

    #endregion CodeSystems

    #region Expressions

    [CqlExpressionDefinition("Patient")]
    public Patient Patient(CqlContext context)
    {
        IEnumerable<Patient> a_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-patient"));
        Patient b_ = context.Operators.SingletonFrom<Patient>(a_);

        return b_;
    }


    [CqlExpressionDefinition("isAssessmentPerformed")]
    public IEnumerable<Observation> isAssessmentPerformed(CqlContext context, IEnumerable<Observation> Obs)
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
                CqlConcept p_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);

                return p_;
            };
            IEnumerable<CqlConcept> k_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)i_, j_);
            bool? l_(CqlConcept ObservationCategory)
            {
                CqlCode q_ = this.survey(context);
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


    [CqlExpressionDefinition("isDeviceOrder")]
    public IEnumerable<DeviceRequest> isDeviceOrder(CqlContext context, IEnumerable<DeviceRequest> DeviceRequest)
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


    [CqlExpressionDefinition("isDiagnosticStudyOrder")]
    public IEnumerable<ServiceRequest> isDiagnosticStudyOrder(CqlContext context, IEnumerable<ServiceRequest> ServiceRequest)
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


    [CqlExpressionDefinition("isInterventionOrder")]
    public IEnumerable<ServiceRequest> isInterventionOrder(CqlContext context, IEnumerable<ServiceRequest> ServiceRequest)
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


    [CqlExpressionDefinition("isLaboratoryTestOrder")]
    public IEnumerable<ServiceRequest> isLaboratoryTestOrder(CqlContext context, IEnumerable<ServiceRequest> ServiceRequest)
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


    [CqlExpressionDefinition("isDiagnosticStudyPerformed")]
    public IEnumerable<Observation> isDiagnosticStudyPerformed(CqlContext context, IEnumerable<Observation> Obs)
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


    [CqlExpressionDefinition("isEncounterPerformed")]
    public IEnumerable<Encounter> isEncounterPerformed(CqlContext context, IEnumerable<Encounter> Enc)
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


    [CqlExpressionDefinition("isImmunizationAdministered")]
    public IEnumerable<Immunization> isImmunizationAdministered(CqlContext context, IEnumerable<Immunization> Immunization)
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


    [CqlExpressionDefinition("isInterventionPerformed")]
    public IEnumerable<Procedure> isInterventionPerformed(CqlContext context, IEnumerable<Procedure> Proc)
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


    [CqlExpressionDefinition("isProcedurePerformed")]
    public IEnumerable<Procedure> isProcedurePerformed(CqlContext context, IEnumerable<Procedure> Proc)
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


    [CqlExpressionDefinition("isLaboratoryTestPerformed")]
    public IEnumerable<Observation> isLaboratoryTestPerformed(CqlContext context, IEnumerable<Observation> Obs)
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
                CqlConcept p_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);

                return p_;
            };
            IEnumerable<CqlConcept> k_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)i_, j_);
            bool? l_(CqlConcept ObservationCategory)
            {
                CqlCode q_ = this.laboratory(context);
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


    [CqlExpressionDefinition("isMedicationActive")]
    public IEnumerable<MedicationRequest> isMedicationActive(CqlContext context, IEnumerable<MedicationRequest> MedicationRequest)
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


    [CqlExpressionDefinition("isMedicationDispensed")]
    public IEnumerable<MedicationDispense> isMedicationDispensed(CqlContext context, IEnumerable<MedicationDispense> Med)
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


    [CqlExpressionDefinition("isMedicationOrder")]
    public IEnumerable<MedicationRequest> isMedicationOrder(CqlContext context, IEnumerable<MedicationRequest> MedicationRequest)
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


    [CqlExpressionDefinition("isPhysicalExamPerformed")]
    public IEnumerable<Observation> isPhysicalExamPerformed(CqlContext context, IEnumerable<Observation> Obs)
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
                CqlConcept p_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);

                return p_;
            };
            IEnumerable<CqlConcept> k_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)i_, j_);
            bool? l_(CqlConcept ObservationCategory)
            {
                CqlCode q_ = this.exam(context);
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


    [CqlExpressionDefinition("isObservationBP")]
    public IEnumerable<Observation> isObservationBP(CqlContext context, IEnumerable<Observation> Obs)
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


    [CqlExpressionDefinition("isObservationBodyHeight")]
    public IEnumerable<Observation> isObservationBodyHeight(CqlContext context, IEnumerable<Observation> Obs)
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


    [CqlExpressionDefinition("isObservationBodyWeight")]
    public IEnumerable<Observation> isObservationBodyWeight(CqlContext context, IEnumerable<Observation> Obs)
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


    [CqlExpressionDefinition("isObservationBMI")]
    public IEnumerable<Observation> isObservationBMI(CqlContext context, IEnumerable<Observation> Obs)
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


    [CqlExpressionDefinition("isSymptom")]
    public IEnumerable<Observation> isSymptom(CqlContext context, IEnumerable<Observation> Obs)
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


    #endregion Expressions

}
