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

    #region Code: laboratory
    [CqlCodeDefinition(
        definitionName: "laboratory",
        codeId: "laboratory",
        codeSystem: "http://terminology.hl7.org/CodeSystem/observation-category")]
    public CqlCode laboratory(CqlContext context) => _laboratory;

    private static readonly CqlCode _laboratory = new CqlCode("laboratory", "http://terminology.hl7.org/CodeSystem/observation-category", default, default);
    #endregion

    #region Code: exam
    [CqlCodeDefinition(
        definitionName: "exam",
        codeId: "exam",
        codeSystem: "http://terminology.hl7.org/CodeSystem/observation-category")]
    public CqlCode exam(CqlContext context) => _exam;

    private static readonly CqlCode _exam = new CqlCode("exam", "http://terminology.hl7.org/CodeSystem/observation-category", default, default);
    #endregion

    #region Code: survey
    [CqlCodeDefinition(
        definitionName: "survey",
        codeId: "survey",
        codeSystem: "http://terminology.hl7.org/CodeSystem/observation-category")]
    public CqlCode survey(CqlContext context) => _survey;

    private static readonly CqlCode _survey = new CqlCode("survey", "http://terminology.hl7.org/CodeSystem/observation-category", default, default);
    #endregion

    #endregion Codes

    #region CodeSystems

    [CqlCodeSystemDefinition(
        definitionName: "ObservationCategoryCodes")]
    public CqlCode[] ObservationCategoryCodes(CqlContext context)
    {
        CqlCode[] uzzzzzzzzu_ = [
            new CqlCode("laboratory", "http://terminology.hl7.org/CodeSystem/observation-category", default, default),
            new CqlCode("exam", "http://terminology.hl7.org/CodeSystem/observation-category", default, default),
            new CqlCode("survey", "http://terminology.hl7.org/CodeSystem/observation-category", default, default),
        ];

        return uzzzzzzzzu_;
    }


    #endregion CodeSystems

    #region Expressions

    [CqlExpressionDefinition(
        definitionName: "Patient")]
    public Patient Patient(CqlContext context)
    {
        IEnumerable<Patient> uzzzzzzzzv_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-patient"));
        Patient uzzzzzzzzw_ = context.Operators.SingletonFrom<Patient>(uzzzzzzzzv_);

        return uzzzzzzzzw_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public IEnumerable<Observation> isAssessmentPerformed(CqlContext context, IEnumerable<Observation> Obs)
    {
        bool? uzzzzzzzzx_(Observation O)
        {
            Code<ObservationStatus> uzzzzzzzzz_ = O?.StatusElement;
            ObservationStatus? vzzzzzzzza_ = uzzzzzzzzz_?.Value;
            Code<ObservationStatus> vzzzzzzzzb_ = context.Operators.Convert<Code<ObservationStatus>>(vzzzzzzzza_);
            string vzzzzzzzzc_ = context.Operators.Convert<string>(vzzzzzzzzb_);
            string[] vzzzzzzzzd_ = [
                "final",
                "amended",
                "corrected",
            ];
            bool? vzzzzzzzze_ = context.Operators.In<string>(vzzzzzzzzc_, vzzzzzzzzd_ as IEnumerable<string>);
            List<CodeableConcept> vzzzzzzzzf_ = O?.Category;
            CqlConcept vzzzzzzzzg_(CodeableConcept @this)
            {
                CqlConcept vzzzzzzzzm_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);

                return vzzzzzzzzm_;
            };
            IEnumerable<CqlConcept> vzzzzzzzzh_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)vzzzzzzzzf_, vzzzzzzzzg_);
            bool? vzzzzzzzzi_(CqlConcept ObservationCategory)
            {
                CqlCode vzzzzzzzzn_ = this.survey(context);
                CqlConcept vzzzzzzzzo_ = context.Operators.ConvertCodeToConcept(vzzzzzzzzn_);
                bool? vzzzzzzzzp_ = context.Operators.Equivalent(ObservationCategory, vzzzzzzzzo_);

                return vzzzzzzzzp_;
            };
            IEnumerable<CqlConcept> vzzzzzzzzj_ = context.Operators.Where<CqlConcept>(vzzzzzzzzh_, vzzzzzzzzi_);
            bool? vzzzzzzzzk_ = context.Operators.Exists<CqlConcept>(vzzzzzzzzj_);
            bool? vzzzzzzzzl_ = context.Operators.And(vzzzzzzzze_, vzzzzzzzzk_);

            return vzzzzzzzzl_;
        };
        IEnumerable<Observation> uzzzzzzzzy_ = context.Operators.Where<Observation>(Obs, uzzzzzzzzx_);

        return uzzzzzzzzy_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public IEnumerable<DeviceRequest> isDeviceOrder(CqlContext context, IEnumerable<DeviceRequest> DeviceRequest)
    {
        bool? vzzzzzzzzq_(DeviceRequest D)
        {
            Code<RequestStatus> vzzzzzzzzs_ = D?.StatusElement;
            RequestStatus? vzzzzzzzzt_ = vzzzzzzzzs_?.Value;
            Code<RequestStatus> vzzzzzzzzu_ = context.Operators.Convert<Code<RequestStatus>>(vzzzzzzzzt_);
            string vzzzzzzzzv_ = context.Operators.Convert<string>(vzzzzzzzzu_);
            string[] vzzzzzzzzw_ = [
                "active",
                "completed",
            ];
            bool? vzzzzzzzzx_ = context.Operators.In<string>(vzzzzzzzzv_, vzzzzzzzzw_ as IEnumerable<string>);
            Code<RequestIntent> vzzzzzzzzy_ = D?.IntentElement;
            RequestIntent? vzzzzzzzzz_ = vzzzzzzzzy_?.Value;
            Code<RequestIntent> wzzzzzzzza_ = context.Operators.Convert<Code<RequestIntent>>(vzzzzzzzzz_);
            bool? wzzzzzzzzb_ = context.Operators.Equal(wzzzzzzzza_, "order");
            bool? wzzzzzzzzc_ = context.Operators.And(vzzzzzzzzx_, wzzzzzzzzb_);

            return wzzzzzzzzc_;
        };
        IEnumerable<DeviceRequest> vzzzzzzzzr_ = context.Operators.Where<DeviceRequest>(DeviceRequest, vzzzzzzzzq_);

        return vzzzzzzzzr_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public IEnumerable<ServiceRequest> isDiagnosticStudyOrder(CqlContext context, IEnumerable<ServiceRequest> ServiceRequest)
    {
        bool? wzzzzzzzzd_(ServiceRequest S)
        {
            Code<RequestStatus> wzzzzzzzzf_ = S?.StatusElement;
            RequestStatus? wzzzzzzzzg_ = wzzzzzzzzf_?.Value;
            Code<RequestStatus> wzzzzzzzzh_ = context.Operators.Convert<Code<RequestStatus>>(wzzzzzzzzg_);
            string wzzzzzzzzi_ = context.Operators.Convert<string>(wzzzzzzzzh_);
            string[] wzzzzzzzzj_ = [
                "active",
                "completed",
            ];
            bool? wzzzzzzzzk_ = context.Operators.In<string>(wzzzzzzzzi_, wzzzzzzzzj_ as IEnumerable<string>);
            Code<RequestIntent> wzzzzzzzzl_ = S?.IntentElement;
            RequestIntent? wzzzzzzzzm_ = wzzzzzzzzl_?.Value;
            Code<RequestIntent> wzzzzzzzzn_ = context.Operators.Convert<Code<RequestIntent>>(wzzzzzzzzm_);
            bool? wzzzzzzzzo_ = context.Operators.Equal(wzzzzzzzzn_, "order");
            bool? wzzzzzzzzp_ = context.Operators.And(wzzzzzzzzk_, wzzzzzzzzo_);

            return wzzzzzzzzp_;
        };
        IEnumerable<ServiceRequest> wzzzzzzzze_ = context.Operators.Where<ServiceRequest>(ServiceRequest, wzzzzzzzzd_);

        return wzzzzzzzze_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public IEnumerable<ServiceRequest> isInterventionOrder(CqlContext context, IEnumerable<ServiceRequest> ServiceRequest)
    {
        bool? wzzzzzzzzq_(ServiceRequest S)
        {
            Code<RequestStatus> wzzzzzzzzs_ = S?.StatusElement;
            RequestStatus? wzzzzzzzzt_ = wzzzzzzzzs_?.Value;
            Code<RequestStatus> wzzzzzzzzu_ = context.Operators.Convert<Code<RequestStatus>>(wzzzzzzzzt_);
            string wzzzzzzzzv_ = context.Operators.Convert<string>(wzzzzzzzzu_);
            string[] wzzzzzzzzw_ = [
                "active",
                "completed",
            ];
            bool? wzzzzzzzzx_ = context.Operators.In<string>(wzzzzzzzzv_, wzzzzzzzzw_ as IEnumerable<string>);
            Code<RequestIntent> wzzzzzzzzy_ = S?.IntentElement;
            RequestIntent? wzzzzzzzzz_ = wzzzzzzzzy_?.Value;
            Code<RequestIntent> xzzzzzzzza_ = context.Operators.Convert<Code<RequestIntent>>(wzzzzzzzzz_);
            bool? xzzzzzzzzb_ = context.Operators.Equal(xzzzzzzzza_, "order");
            bool? xzzzzzzzzc_ = context.Operators.And(wzzzzzzzzx_, xzzzzzzzzb_);

            return xzzzzzzzzc_;
        };
        IEnumerable<ServiceRequest> wzzzzzzzzr_ = context.Operators.Where<ServiceRequest>(ServiceRequest, wzzzzzzzzq_);

        return wzzzzzzzzr_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public IEnumerable<ServiceRequest> isLaboratoryTestOrder(CqlContext context, IEnumerable<ServiceRequest> ServiceRequest)
    {
        bool? xzzzzzzzzd_(ServiceRequest S)
        {
            Code<RequestStatus> xzzzzzzzzf_ = S?.StatusElement;
            RequestStatus? xzzzzzzzzg_ = xzzzzzzzzf_?.Value;
            Code<RequestStatus> xzzzzzzzzh_ = context.Operators.Convert<Code<RequestStatus>>(xzzzzzzzzg_);
            string xzzzzzzzzi_ = context.Operators.Convert<string>(xzzzzzzzzh_);
            string[] xzzzzzzzzj_ = [
                "active",
                "completed",
            ];
            bool? xzzzzzzzzk_ = context.Operators.In<string>(xzzzzzzzzi_, xzzzzzzzzj_ as IEnumerable<string>);
            Code<RequestIntent> xzzzzzzzzl_ = S?.IntentElement;
            RequestIntent? xzzzzzzzzm_ = xzzzzzzzzl_?.Value;
            Code<RequestIntent> xzzzzzzzzn_ = context.Operators.Convert<Code<RequestIntent>>(xzzzzzzzzm_);
            bool? xzzzzzzzzo_ = context.Operators.Equal(xzzzzzzzzn_, "order");
            bool? xzzzzzzzzp_ = context.Operators.And(xzzzzzzzzk_, xzzzzzzzzo_);

            return xzzzzzzzzp_;
        };
        IEnumerable<ServiceRequest> xzzzzzzzze_ = context.Operators.Where<ServiceRequest>(ServiceRequest, xzzzzzzzzd_);

        return xzzzzzzzze_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public IEnumerable<Observation> isDiagnosticStudyPerformed(CqlContext context, IEnumerable<Observation> Obs)
    {
        bool? xzzzzzzzzq_(Observation O)
        {
            Code<ObservationStatus> xzzzzzzzzs_ = O?.StatusElement;
            ObservationStatus? xzzzzzzzzt_ = xzzzzzzzzs_?.Value;
            Code<ObservationStatus> xzzzzzzzzu_ = context.Operators.Convert<Code<ObservationStatus>>(xzzzzzzzzt_);
            string xzzzzzzzzv_ = context.Operators.Convert<string>(xzzzzzzzzu_);
            string[] xzzzzzzzzw_ = [
                "final",
                "amended",
                "corrected",
            ];
            bool? xzzzzzzzzx_ = context.Operators.In<string>(xzzzzzzzzv_, xzzzzzzzzw_ as IEnumerable<string>);

            return xzzzzzzzzx_;
        };
        IEnumerable<Observation> xzzzzzzzzr_ = context.Operators.Where<Observation>(Obs, xzzzzzzzzq_);

        return xzzzzzzzzr_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public IEnumerable<Encounter> isEncounterPerformed(CqlContext context, IEnumerable<Encounter> Enc)
    {
        bool? xzzzzzzzzy_(Encounter E)
        {
            Code<Encounter.EncounterStatus> yzzzzzzzza_ = E?.StatusElement;
            Encounter.EncounterStatus? yzzzzzzzzb_ = yzzzzzzzza_?.Value;
            Code<Encounter.EncounterStatus> yzzzzzzzzc_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(yzzzzzzzzb_);
            string yzzzzzzzzd_ = context.Operators.Convert<string>(yzzzzzzzzc_);
            string[] yzzzzzzzze_ = [
                "finished",
                "arrived",
                "triaged",
                "in-progress",
                "onleave",
            ];
            bool? yzzzzzzzzf_ = context.Operators.In<string>(yzzzzzzzzd_, yzzzzzzzze_ as IEnumerable<string>);

            return yzzzzzzzzf_;
        };
        IEnumerable<Encounter> xzzzzzzzzz_ = context.Operators.Where<Encounter>(Enc, xzzzzzzzzy_);

        return xzzzzzzzzz_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public IEnumerable<Immunization> isImmunizationAdministered(CqlContext context, IEnumerable<Immunization> Immunization)
    {
        bool? yzzzzzzzzg_(Immunization I)
        {
            Code<Immunization.ImmunizationStatusCodes> yzzzzzzzzi_ = I?.StatusElement;
            Immunization.ImmunizationStatusCodes? yzzzzzzzzj_ = yzzzzzzzzi_?.Value;
            string yzzzzzzzzk_ = context.Operators.Convert<string>(yzzzzzzzzj_);
            bool? yzzzzzzzzl_ = context.Operators.Equivalent(yzzzzzzzzk_, "completed");

            return yzzzzzzzzl_;
        };
        IEnumerable<Immunization> yzzzzzzzzh_ = context.Operators.Where<Immunization>(Immunization, yzzzzzzzzg_);

        return yzzzzzzzzh_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public IEnumerable<Procedure> isInterventionPerformed(CqlContext context, IEnumerable<Procedure> Proc)
    {
        bool? yzzzzzzzzm_(Procedure P)
        {
            Code<EventStatus> yzzzzzzzzo_ = P?.StatusElement;
            EventStatus? yzzzzzzzzp_ = yzzzzzzzzo_?.Value;
            string yzzzzzzzzq_ = context.Operators.Convert<string>(yzzzzzzzzp_);
            bool? yzzzzzzzzr_ = context.Operators.Equivalent(yzzzzzzzzq_, "completed");

            return yzzzzzzzzr_;
        };
        IEnumerable<Procedure> yzzzzzzzzn_ = context.Operators.Where<Procedure>(Proc, yzzzzzzzzm_);

        return yzzzzzzzzn_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public IEnumerable<Procedure> isProcedurePerformed(CqlContext context, IEnumerable<Procedure> Proc)
    {
        bool? yzzzzzzzzs_(Procedure P)
        {
            Code<EventStatus> yzzzzzzzzu_ = P?.StatusElement;
            EventStatus? yzzzzzzzzv_ = yzzzzzzzzu_?.Value;
            string yzzzzzzzzw_ = context.Operators.Convert<string>(yzzzzzzzzv_);
            bool? yzzzzzzzzx_ = context.Operators.Equivalent(yzzzzzzzzw_, "completed");

            return yzzzzzzzzx_;
        };
        IEnumerable<Procedure> yzzzzzzzzt_ = context.Operators.Where<Procedure>(Proc, yzzzzzzzzs_);

        return yzzzzzzzzt_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public IEnumerable<Observation> isLaboratoryTestPerformed(CqlContext context, IEnumerable<Observation> Obs)
    {
        bool? yzzzzzzzzy_(Observation O)
        {
            Code<ObservationStatus> zzzzzzzzza_ = O?.StatusElement;
            ObservationStatus? zzzzzzzzzb_ = zzzzzzzzza_?.Value;
            Code<ObservationStatus> zzzzzzzzzc_ = context.Operators.Convert<Code<ObservationStatus>>(zzzzzzzzzb_);
            string zzzzzzzzzd_ = context.Operators.Convert<string>(zzzzzzzzzc_);
            string[] zzzzzzzzze_ = [
                "final",
                "amended",
                "corrected",
            ];
            bool? zzzzzzzzzf_ = context.Operators.In<string>(zzzzzzzzzd_, zzzzzzzzze_ as IEnumerable<string>);
            List<CodeableConcept> zzzzzzzzzg_ = O?.Category;
            CqlConcept zzzzzzzzzh_(CodeableConcept @this)
            {
                CqlConcept zzzzzzzzzn_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);

                return zzzzzzzzzn_;
            };
            IEnumerable<CqlConcept> zzzzzzzzzi_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)zzzzzzzzzg_, zzzzzzzzzh_);
            bool? zzzzzzzzzj_(CqlConcept ObservationCategory)
            {
                CqlCode zzzzzzzzzo_ = this.laboratory(context);
                CqlConcept zzzzzzzzzp_ = context.Operators.ConvertCodeToConcept(zzzzzzzzzo_);
                bool? zzzzzzzzzq_ = context.Operators.Equivalent(ObservationCategory, zzzzzzzzzp_);

                return zzzzzzzzzq_;
            };
            IEnumerable<CqlConcept> zzzzzzzzzk_ = context.Operators.Where<CqlConcept>(zzzzzzzzzi_, zzzzzzzzzj_);
            bool? zzzzzzzzzl_ = context.Operators.Exists<CqlConcept>(zzzzzzzzzk_);
            bool? zzzzzzzzzm_ = context.Operators.And(zzzzzzzzzf_, zzzzzzzzzl_);

            return zzzzzzzzzm_;
        };
        IEnumerable<Observation> yzzzzzzzzz_ = context.Operators.Where<Observation>(Obs, yzzzzzzzzy_);

        return yzzzzzzzzz_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public IEnumerable<MedicationRequest> isMedicationActive(CqlContext context, IEnumerable<MedicationRequest> MedicationRequest)
    {
        bool? zzzzzzzzzr_(MedicationRequest M)
        {
            Code<MedicationRequest.MedicationrequestStatus> zzzzzzzzzt_ = M?.StatusElement;
            MedicationRequest.MedicationrequestStatus? zzzzzzzzzu_ = zzzzzzzzzt_?.Value;
            string zzzzzzzzzv_ = context.Operators.Convert<string>(zzzzzzzzzu_);
            bool? zzzzzzzzzw_ = context.Operators.Equal(zzzzzzzzzv_, "active");
            Code<MedicationRequest.MedicationRequestIntent> zzzzzzzzzx_ = M?.IntentElement;
            MedicationRequest.MedicationRequestIntent? zzzzzzzzzy_ = zzzzzzzzzx_?.Value;
            string zzzzzzzzzz_ = context.Operators.Convert<string>(zzzzzzzzzy_);
            bool? azzzzzzzzza_ = context.Operators.Equal(zzzzzzzzzz_, "order");
            bool? azzzzzzzzzb_ = context.Operators.And(zzzzzzzzzw_, azzzzzzzzza_);

            return azzzzzzzzzb_;
        };
        IEnumerable<MedicationRequest> zzzzzzzzzs_ = context.Operators.Where<MedicationRequest>(MedicationRequest, zzzzzzzzzr_);

        return zzzzzzzzzs_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public IEnumerable<MedicationDispense> isMedicationDispensed(CqlContext context, IEnumerable<MedicationDispense> Med)
    {
        bool? azzzzzzzzzc_(MedicationDispense M)
        {
            Code<MedicationDispense.MedicationDispenseStatusCodes> azzzzzzzzze_ = M?.StatusElement;
            MedicationDispense.MedicationDispenseStatusCodes? azzzzzzzzzf_ = azzzzzzzzze_?.Value;
            Code<MedicationDispense.MedicationDispenseStatusCodes> azzzzzzzzzg_ = context.Operators.Convert<Code<MedicationDispense.MedicationDispenseStatusCodes>>(azzzzzzzzzf_);
            string azzzzzzzzzh_ = context.Operators.Convert<string>(azzzzzzzzzg_);
            string[] azzzzzzzzzi_ = [
                "completed",
                "in-progress",
                "on-hold",
            ];
            bool? azzzzzzzzzj_ = context.Operators.In<string>(azzzzzzzzzh_, azzzzzzzzzi_ as IEnumerable<string>);

            return azzzzzzzzzj_;
        };
        IEnumerable<MedicationDispense> azzzzzzzzzd_ = context.Operators.Where<MedicationDispense>(Med, azzzzzzzzzc_);

        return azzzzzzzzzd_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public IEnumerable<MedicationRequest> isMedicationOrder(CqlContext context, IEnumerable<MedicationRequest> MedicationRequest)
    {
        bool? azzzzzzzzzk_(MedicationRequest M)
        {
            Code<MedicationRequest.MedicationrequestStatus> azzzzzzzzzm_ = M?.StatusElement;
            MedicationRequest.MedicationrequestStatus? azzzzzzzzzn_ = azzzzzzzzzm_?.Value;
            string azzzzzzzzzo_ = context.Operators.Convert<string>(azzzzzzzzzn_);
            string[] azzzzzzzzzp_ = [
                "active",
                "completed",
            ];
            bool? azzzzzzzzzq_ = context.Operators.In<string>(azzzzzzzzzo_, azzzzzzzzzp_ as IEnumerable<string>);
            Code<MedicationRequest.MedicationRequestIntent> azzzzzzzzzr_ = M?.IntentElement;
            MedicationRequest.MedicationRequestIntent? azzzzzzzzzs_ = azzzzzzzzzr_?.Value;
            string azzzzzzzzzt_ = context.Operators.Convert<string>(azzzzzzzzzs_);
            bool? azzzzzzzzzu_ = context.Operators.Equal(azzzzzzzzzt_, "order");
            bool? azzzzzzzzzv_ = context.Operators.And(azzzzzzzzzq_, azzzzzzzzzu_);

            return azzzzzzzzzv_;
        };
        IEnumerable<MedicationRequest> azzzzzzzzzl_ = context.Operators.Where<MedicationRequest>(MedicationRequest, azzzzzzzzzk_);

        return azzzzzzzzzl_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public IEnumerable<Observation> isPhysicalExamPerformed(CqlContext context, IEnumerable<Observation> Obs)
    {
        bool? azzzzzzzzzw_(Observation O)
        {
            Code<ObservationStatus> azzzzzzzzzy_ = O?.StatusElement;
            ObservationStatus? azzzzzzzzzz_ = azzzzzzzzzy_?.Value;
            Code<ObservationStatus> bzzzzzzzzza_ = context.Operators.Convert<Code<ObservationStatus>>(azzzzzzzzzz_);
            string bzzzzzzzzzb_ = context.Operators.Convert<string>(bzzzzzzzzza_);
            string[] bzzzzzzzzzc_ = [
                "final",
                "amended",
                "corrected",
            ];
            bool? bzzzzzzzzzd_ = context.Operators.In<string>(bzzzzzzzzzb_, bzzzzzzzzzc_ as IEnumerable<string>);
            List<CodeableConcept> bzzzzzzzzze_ = O?.Category;
            CqlConcept bzzzzzzzzzf_(CodeableConcept @this)
            {
                CqlConcept bzzzzzzzzzl_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);

                return bzzzzzzzzzl_;
            };
            IEnumerable<CqlConcept> bzzzzzzzzzg_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)bzzzzzzzzze_, bzzzzzzzzzf_);
            bool? bzzzzzzzzzh_(CqlConcept ObservationCategory)
            {
                CqlCode bzzzzzzzzzm_ = this.exam(context);
                CqlConcept bzzzzzzzzzn_ = context.Operators.ConvertCodeToConcept(bzzzzzzzzzm_);
                bool? bzzzzzzzzzo_ = context.Operators.Equivalent(ObservationCategory, bzzzzzzzzzn_);

                return bzzzzzzzzzo_;
            };
            IEnumerable<CqlConcept> bzzzzzzzzzi_ = context.Operators.Where<CqlConcept>(bzzzzzzzzzg_, bzzzzzzzzzh_);
            bool? bzzzzzzzzzj_ = context.Operators.Exists<CqlConcept>(bzzzzzzzzzi_);
            bool? bzzzzzzzzzk_ = context.Operators.And(bzzzzzzzzzd_, bzzzzzzzzzj_);

            return bzzzzzzzzzk_;
        };
        IEnumerable<Observation> azzzzzzzzzx_ = context.Operators.Where<Observation>(Obs, azzzzzzzzzw_);

        return azzzzzzzzzx_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public IEnumerable<Observation> isObservationBP(CqlContext context, IEnumerable<Observation> Obs)
    {
        bool? bzzzzzzzzzp_(Observation O)
        {
            Code<ObservationStatus> bzzzzzzzzzr_ = O?.StatusElement;
            ObservationStatus? bzzzzzzzzzs_ = bzzzzzzzzzr_?.Value;
            string bzzzzzzzzzt_ = context.Operators.Convert<string>(bzzzzzzzzzs_);
            string[] bzzzzzzzzzu_ = [
                "final",
                "amended",
                "corrected",
            ];
            bool? bzzzzzzzzzv_ = context.Operators.In<string>(bzzzzzzzzzt_, bzzzzzzzzzu_ as IEnumerable<string>);

            return bzzzzzzzzzv_;
        };
        IEnumerable<Observation> bzzzzzzzzzq_ = context.Operators.Where<Observation>(Obs, bzzzzzzzzzp_);

        return bzzzzzzzzzq_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public IEnumerable<Observation> isObservationBodyHeight(CqlContext context, IEnumerable<Observation> Obs)
    {
        bool? bzzzzzzzzzw_(Observation O)
        {
            Code<ObservationStatus> bzzzzzzzzzy_ = O?.StatusElement;
            ObservationStatus? bzzzzzzzzzz_ = bzzzzzzzzzy_?.Value;
            string czzzzzzzzza_ = context.Operators.Convert<string>(bzzzzzzzzzz_);
            string[] czzzzzzzzzb_ = [
                "final",
                "amended",
                "corrected",
            ];
            bool? czzzzzzzzzc_ = context.Operators.In<string>(czzzzzzzzza_, czzzzzzzzzb_ as IEnumerable<string>);

            return czzzzzzzzzc_;
        };
        IEnumerable<Observation> bzzzzzzzzzx_ = context.Operators.Where<Observation>(Obs, bzzzzzzzzzw_);

        return bzzzzzzzzzx_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public IEnumerable<Observation> isObservationBodyWeight(CqlContext context, IEnumerable<Observation> Obs)
    {
        bool? czzzzzzzzzd_(Observation O)
        {
            Code<ObservationStatus> czzzzzzzzzf_ = O?.StatusElement;
            ObservationStatus? czzzzzzzzzg_ = czzzzzzzzzf_?.Value;
            string czzzzzzzzzh_ = context.Operators.Convert<string>(czzzzzzzzzg_);
            string[] czzzzzzzzzi_ = [
                "final",
                "amended",
                "corrected",
            ];
            bool? czzzzzzzzzj_ = context.Operators.In<string>(czzzzzzzzzh_, czzzzzzzzzi_ as IEnumerable<string>);

            return czzzzzzzzzj_;
        };
        IEnumerable<Observation> czzzzzzzzze_ = context.Operators.Where<Observation>(Obs, czzzzzzzzzd_);

        return czzzzzzzzze_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public IEnumerable<Observation> isObservationBMI(CqlContext context, IEnumerable<Observation> Obs)
    {
        bool? czzzzzzzzzk_(Observation O)
        {
            Code<ObservationStatus> czzzzzzzzzm_ = O?.StatusElement;
            ObservationStatus? czzzzzzzzzn_ = czzzzzzzzzm_?.Value;
            string czzzzzzzzzo_ = context.Operators.Convert<string>(czzzzzzzzzn_);
            string[] czzzzzzzzzp_ = [
                "final",
                "amended",
                "corrected",
            ];
            bool? czzzzzzzzzq_ = context.Operators.In<string>(czzzzzzzzzo_, czzzzzzzzzp_ as IEnumerable<string>);

            return czzzzzzzzzq_;
        };
        IEnumerable<Observation> czzzzzzzzzl_ = context.Operators.Where<Observation>(Obs, czzzzzzzzzk_);

        return czzzzzzzzzl_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public IEnumerable<Observation> isSymptom(CqlContext context, IEnumerable<Observation> Obs)
    {
        bool? czzzzzzzzzr_(Observation O)
        {
            Code<ObservationStatus> czzzzzzzzzt_ = O?.StatusElement;
            ObservationStatus? czzzzzzzzzu_ = czzzzzzzzzt_?.Value;
            Code<ObservationStatus> czzzzzzzzzv_ = context.Operators.Convert<Code<ObservationStatus>>(czzzzzzzzzu_);
            string czzzzzzzzzw_ = context.Operators.Convert<string>(czzzzzzzzzv_);
            string[] czzzzzzzzzx_ = [
                "preliminary",
                "final",
                "amended",
                "corrected",
            ];
            bool? czzzzzzzzzy_ = context.Operators.In<string>(czzzzzzzzzw_, czzzzzzzzzx_ as IEnumerable<string>);

            return czzzzzzzzzy_;
        };
        IEnumerable<Observation> czzzzzzzzzs_ = context.Operators.Where<Observation>(Obs, czzzzzzzzzr_);

        return czzzzzzzzzs_;
    }


    #endregion Expressions

}
