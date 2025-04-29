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
    private static readonly CqlCode _laboratory = new CqlCode("laboratory", "http://terminology.hl7.org/CodeSystem/observation-category", default, default);

    [CqlCodeDefinition("exam", codeId: "exam", codeSystem: "http://terminology.hl7.org/CodeSystem/observation-category")]
    public CqlCode exam(CqlContext _) => _exam;
    private static readonly CqlCode _exam = new CqlCode("exam", "http://terminology.hl7.org/CodeSystem/observation-category", default, default);

    [CqlCodeDefinition("survey", codeId: "survey", codeSystem: "http://terminology.hl7.org/CodeSystem/observation-category")]
    public CqlCode survey(CqlContext _) => _survey;
    private static readonly CqlCode _survey = new CqlCode("survey", "http://terminology.hl7.org/CodeSystem/observation-category", default, default);

    #endregion Codes

    #region CodeSystems

    [CqlCodeSystemDefinition("ObservationCategoryCodes")]
    public CqlCodeSystem ObservationCategoryCodes(CqlContext _) => _ObservationCategoryCodes;
    private static readonly CqlCodeSystem _ObservationCategoryCodes = new CqlCodeSystem();

    #endregion CodeSystems

    #region Expressions

    [CqlExpressionDefinition("Patient")]
    public Patient Patient(CqlContext context)
    {
        IEnumerable<Patient> azzzzzzzzj_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-patient"));
        Patient azzzzzzzzk_ = context.Operators.SingletonFrom<Patient>(azzzzzzzzj_);

        return azzzzzzzzk_;
    }


    [CqlExpressionDefinition("isAssessmentPerformed")]
    public IEnumerable<Observation> isAssessmentPerformed(CqlContext context, IEnumerable<Observation> Obs)
    {
        bool? azzzzzzzzl_(Observation O)
        {
            Code<ObservationStatus> azzzzzzzzn_ = O?.StatusElement;
            ObservationStatus? azzzzzzzzo_ = azzzzzzzzn_?.Value;
            Code<ObservationStatus> azzzzzzzzp_ = context.Operators.Convert<Code<ObservationStatus>>(azzzzzzzzo_);
            string azzzzzzzzq_ = context.Operators.Convert<string>(azzzzzzzzp_);
            string[] azzzzzzzzr_ = [
                "final",
                "amended",
                "corrected",
            ];
            bool? azzzzzzzzs_ = context.Operators.In<string>(azzzzzzzzq_, azzzzzzzzr_ as IEnumerable<string>);
            List<CodeableConcept> azzzzzzzzt_ = O?.Category;
            CqlConcept azzzzzzzzu_(CodeableConcept @this)
            {
                CqlConcept bzzzzzzzza_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);

                return bzzzzzzzza_;
            };
            IEnumerable<CqlConcept> azzzzzzzzv_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)azzzzzzzzt_, azzzzzzzzu_);
            bool? azzzzzzzzw_(CqlConcept ObservationCategory)
            {
                CqlCode bzzzzzzzzb_ = this.survey(context);
                CqlConcept bzzzzzzzzc_ = context.Operators.ConvertCodeToConcept(bzzzzzzzzb_);
                bool? bzzzzzzzzd_ = context.Operators.Equivalent(ObservationCategory, bzzzzzzzzc_);

                return bzzzzzzzzd_;
            };
            IEnumerable<CqlConcept> azzzzzzzzx_ = context.Operators.Where<CqlConcept>(azzzzzzzzv_, azzzzzzzzw_);
            bool? azzzzzzzzy_ = context.Operators.Exists<CqlConcept>(azzzzzzzzx_);
            bool? azzzzzzzzz_ = context.Operators.And(azzzzzzzzs_, azzzzzzzzy_);

            return azzzzzzzzz_;
        };
        IEnumerable<Observation> azzzzzzzzm_ = context.Operators.Where<Observation>(Obs, azzzzzzzzl_);

        return azzzzzzzzm_;
    }


    [CqlExpressionDefinition("isDeviceOrder")]
    public IEnumerable<DeviceRequest> isDeviceOrder(CqlContext context, IEnumerable<DeviceRequest> DeviceRequest)
    {
        bool? bzzzzzzzze_(DeviceRequest D)
        {
            Code<RequestStatus> bzzzzzzzzg_ = D?.StatusElement;
            RequestStatus? bzzzzzzzzh_ = bzzzzzzzzg_?.Value;
            Code<RequestStatus> bzzzzzzzzi_ = context.Operators.Convert<Code<RequestStatus>>(bzzzzzzzzh_);
            string bzzzzzzzzj_ = context.Operators.Convert<string>(bzzzzzzzzi_);
            string[] bzzzzzzzzk_ = [
                "active",
                "completed",
            ];
            bool? bzzzzzzzzl_ = context.Operators.In<string>(bzzzzzzzzj_, bzzzzzzzzk_ as IEnumerable<string>);
            Code<RequestIntent> bzzzzzzzzm_ = D?.IntentElement;
            RequestIntent? bzzzzzzzzn_ = bzzzzzzzzm_?.Value;
            Code<RequestIntent> bzzzzzzzzo_ = context.Operators.Convert<Code<RequestIntent>>(bzzzzzzzzn_);
            bool? bzzzzzzzzp_ = context.Operators.Equal(bzzzzzzzzo_, "order");
            bool? bzzzzzzzzq_ = context.Operators.And(bzzzzzzzzl_, bzzzzzzzzp_);

            return bzzzzzzzzq_;
        };
        IEnumerable<DeviceRequest> bzzzzzzzzf_ = context.Operators.Where<DeviceRequest>(DeviceRequest, bzzzzzzzze_);

        return bzzzzzzzzf_;
    }


    [CqlExpressionDefinition("isDiagnosticStudyOrder")]
    public IEnumerable<ServiceRequest> isDiagnosticStudyOrder(CqlContext context, IEnumerable<ServiceRequest> ServiceRequest)
    {
        bool? bzzzzzzzzr_(ServiceRequest S)
        {
            Code<RequestStatus> bzzzzzzzzt_ = S?.StatusElement;
            RequestStatus? bzzzzzzzzu_ = bzzzzzzzzt_?.Value;
            Code<RequestStatus> bzzzzzzzzv_ = context.Operators.Convert<Code<RequestStatus>>(bzzzzzzzzu_);
            string bzzzzzzzzw_ = context.Operators.Convert<string>(bzzzzzzzzv_);
            string[] bzzzzzzzzx_ = [
                "active",
                "completed",
            ];
            bool? bzzzzzzzzy_ = context.Operators.In<string>(bzzzzzzzzw_, bzzzzzzzzx_ as IEnumerable<string>);
            Code<RequestIntent> bzzzzzzzzz_ = S?.IntentElement;
            RequestIntent? czzzzzzzza_ = bzzzzzzzzz_?.Value;
            Code<RequestIntent> czzzzzzzzb_ = context.Operators.Convert<Code<RequestIntent>>(czzzzzzzza_);
            bool? czzzzzzzzc_ = context.Operators.Equal(czzzzzzzzb_, "order");
            bool? czzzzzzzzd_ = context.Operators.And(bzzzzzzzzy_, czzzzzzzzc_);

            return czzzzzzzzd_;
        };
        IEnumerable<ServiceRequest> bzzzzzzzzs_ = context.Operators.Where<ServiceRequest>(ServiceRequest, bzzzzzzzzr_);

        return bzzzzzzzzs_;
    }


    [CqlExpressionDefinition("isInterventionOrder")]
    public IEnumerable<ServiceRequest> isInterventionOrder(CqlContext context, IEnumerable<ServiceRequest> ServiceRequest)
    {
        bool? czzzzzzzze_(ServiceRequest S)
        {
            Code<RequestStatus> czzzzzzzzg_ = S?.StatusElement;
            RequestStatus? czzzzzzzzh_ = czzzzzzzzg_?.Value;
            Code<RequestStatus> czzzzzzzzi_ = context.Operators.Convert<Code<RequestStatus>>(czzzzzzzzh_);
            string czzzzzzzzj_ = context.Operators.Convert<string>(czzzzzzzzi_);
            string[] czzzzzzzzk_ = [
                "active",
                "completed",
            ];
            bool? czzzzzzzzl_ = context.Operators.In<string>(czzzzzzzzj_, czzzzzzzzk_ as IEnumerable<string>);
            Code<RequestIntent> czzzzzzzzm_ = S?.IntentElement;
            RequestIntent? czzzzzzzzn_ = czzzzzzzzm_?.Value;
            Code<RequestIntent> czzzzzzzzo_ = context.Operators.Convert<Code<RequestIntent>>(czzzzzzzzn_);
            bool? czzzzzzzzp_ = context.Operators.Equal(czzzzzzzzo_, "order");
            bool? czzzzzzzzq_ = context.Operators.And(czzzzzzzzl_, czzzzzzzzp_);

            return czzzzzzzzq_;
        };
        IEnumerable<ServiceRequest> czzzzzzzzf_ = context.Operators.Where<ServiceRequest>(ServiceRequest, czzzzzzzze_);

        return czzzzzzzzf_;
    }


    [CqlExpressionDefinition("isLaboratoryTestOrder")]
    public IEnumerable<ServiceRequest> isLaboratoryTestOrder(CqlContext context, IEnumerable<ServiceRequest> ServiceRequest)
    {
        bool? czzzzzzzzr_(ServiceRequest S)
        {
            Code<RequestStatus> czzzzzzzzt_ = S?.StatusElement;
            RequestStatus? czzzzzzzzu_ = czzzzzzzzt_?.Value;
            Code<RequestStatus> czzzzzzzzv_ = context.Operators.Convert<Code<RequestStatus>>(czzzzzzzzu_);
            string czzzzzzzzw_ = context.Operators.Convert<string>(czzzzzzzzv_);
            string[] czzzzzzzzx_ = [
                "active",
                "completed",
            ];
            bool? czzzzzzzzy_ = context.Operators.In<string>(czzzzzzzzw_, czzzzzzzzx_ as IEnumerable<string>);
            Code<RequestIntent> czzzzzzzzz_ = S?.IntentElement;
            RequestIntent? dzzzzzzzza_ = czzzzzzzzz_?.Value;
            Code<RequestIntent> dzzzzzzzzb_ = context.Operators.Convert<Code<RequestIntent>>(dzzzzzzzza_);
            bool? dzzzzzzzzc_ = context.Operators.Equal(dzzzzzzzzb_, "order");
            bool? dzzzzzzzzd_ = context.Operators.And(czzzzzzzzy_, dzzzzzzzzc_);

            return dzzzzzzzzd_;
        };
        IEnumerable<ServiceRequest> czzzzzzzzs_ = context.Operators.Where<ServiceRequest>(ServiceRequest, czzzzzzzzr_);

        return czzzzzzzzs_;
    }


    [CqlExpressionDefinition("isDiagnosticStudyPerformed")]
    public IEnumerable<Observation> isDiagnosticStudyPerformed(CqlContext context, IEnumerable<Observation> Obs)
    {
        bool? dzzzzzzzze_(Observation O)
        {
            Code<ObservationStatus> dzzzzzzzzg_ = O?.StatusElement;
            ObservationStatus? dzzzzzzzzh_ = dzzzzzzzzg_?.Value;
            Code<ObservationStatus> dzzzzzzzzi_ = context.Operators.Convert<Code<ObservationStatus>>(dzzzzzzzzh_);
            string dzzzzzzzzj_ = context.Operators.Convert<string>(dzzzzzzzzi_);
            string[] dzzzzzzzzk_ = [
                "final",
                "amended",
                "corrected",
            ];
            bool? dzzzzzzzzl_ = context.Operators.In<string>(dzzzzzzzzj_, dzzzzzzzzk_ as IEnumerable<string>);

            return dzzzzzzzzl_;
        };
        IEnumerable<Observation> dzzzzzzzzf_ = context.Operators.Where<Observation>(Obs, dzzzzzzzze_);

        return dzzzzzzzzf_;
    }


    [CqlExpressionDefinition("isEncounterPerformed")]
    public IEnumerable<Encounter> isEncounterPerformed(CqlContext context, IEnumerable<Encounter> Enc)
    {
        bool? dzzzzzzzzm_(Encounter E)
        {
            Code<Encounter.EncounterStatus> dzzzzzzzzo_ = E?.StatusElement;
            Encounter.EncounterStatus? dzzzzzzzzp_ = dzzzzzzzzo_?.Value;
            Code<Encounter.EncounterStatus> dzzzzzzzzq_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(dzzzzzzzzp_);
            string dzzzzzzzzr_ = context.Operators.Convert<string>(dzzzzzzzzq_);
            string[] dzzzzzzzzs_ = [
                "finished",
                "arrived",
                "triaged",
                "in-progress",
                "onleave",
            ];
            bool? dzzzzzzzzt_ = context.Operators.In<string>(dzzzzzzzzr_, dzzzzzzzzs_ as IEnumerable<string>);

            return dzzzzzzzzt_;
        };
        IEnumerable<Encounter> dzzzzzzzzn_ = context.Operators.Where<Encounter>(Enc, dzzzzzzzzm_);

        return dzzzzzzzzn_;
    }


    [CqlExpressionDefinition("isImmunizationAdministered")]
    public IEnumerable<Immunization> isImmunizationAdministered(CqlContext context, IEnumerable<Immunization> Immunization)
    {
        bool? dzzzzzzzzu_(Immunization I)
        {
            Code<Immunization.ImmunizationStatusCodes> dzzzzzzzzw_ = I?.StatusElement;
            Immunization.ImmunizationStatusCodes? dzzzzzzzzx_ = dzzzzzzzzw_?.Value;
            string dzzzzzzzzy_ = context.Operators.Convert<string>(dzzzzzzzzx_);
            bool? dzzzzzzzzz_ = context.Operators.Equivalent(dzzzzzzzzy_, "completed");

            return dzzzzzzzzz_;
        };
        IEnumerable<Immunization> dzzzzzzzzv_ = context.Operators.Where<Immunization>(Immunization, dzzzzzzzzu_);

        return dzzzzzzzzv_;
    }


    [CqlExpressionDefinition("isInterventionPerformed")]
    public IEnumerable<Procedure> isInterventionPerformed(CqlContext context, IEnumerable<Procedure> Proc)
    {
        bool? ezzzzzzzza_(Procedure P)
        {
            Code<EventStatus> ezzzzzzzzc_ = P?.StatusElement;
            EventStatus? ezzzzzzzzd_ = ezzzzzzzzc_?.Value;
            string ezzzzzzzze_ = context.Operators.Convert<string>(ezzzzzzzzd_);
            bool? ezzzzzzzzf_ = context.Operators.Equivalent(ezzzzzzzze_, "completed");

            return ezzzzzzzzf_;
        };
        IEnumerable<Procedure> ezzzzzzzzb_ = context.Operators.Where<Procedure>(Proc, ezzzzzzzza_);

        return ezzzzzzzzb_;
    }


    [CqlExpressionDefinition("isProcedurePerformed")]
    public IEnumerable<Procedure> isProcedurePerformed(CqlContext context, IEnumerable<Procedure> Proc)
    {
        bool? ezzzzzzzzg_(Procedure P)
        {
            Code<EventStatus> ezzzzzzzzi_ = P?.StatusElement;
            EventStatus? ezzzzzzzzj_ = ezzzzzzzzi_?.Value;
            string ezzzzzzzzk_ = context.Operators.Convert<string>(ezzzzzzzzj_);
            bool? ezzzzzzzzl_ = context.Operators.Equivalent(ezzzzzzzzk_, "completed");

            return ezzzzzzzzl_;
        };
        IEnumerable<Procedure> ezzzzzzzzh_ = context.Operators.Where<Procedure>(Proc, ezzzzzzzzg_);

        return ezzzzzzzzh_;
    }


    [CqlExpressionDefinition("isLaboratoryTestPerformed")]
    public IEnumerable<Observation> isLaboratoryTestPerformed(CqlContext context, IEnumerable<Observation> Obs)
    {
        bool? ezzzzzzzzm_(Observation O)
        {
            Code<ObservationStatus> ezzzzzzzzo_ = O?.StatusElement;
            ObservationStatus? ezzzzzzzzp_ = ezzzzzzzzo_?.Value;
            Code<ObservationStatus> ezzzzzzzzq_ = context.Operators.Convert<Code<ObservationStatus>>(ezzzzzzzzp_);
            string ezzzzzzzzr_ = context.Operators.Convert<string>(ezzzzzzzzq_);
            string[] ezzzzzzzzs_ = [
                "final",
                "amended",
                "corrected",
            ];
            bool? ezzzzzzzzt_ = context.Operators.In<string>(ezzzzzzzzr_, ezzzzzzzzs_ as IEnumerable<string>);
            List<CodeableConcept> ezzzzzzzzu_ = O?.Category;
            CqlConcept ezzzzzzzzv_(CodeableConcept @this)
            {
                CqlConcept fzzzzzzzzb_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);

                return fzzzzzzzzb_;
            };
            IEnumerable<CqlConcept> ezzzzzzzzw_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)ezzzzzzzzu_, ezzzzzzzzv_);
            bool? ezzzzzzzzx_(CqlConcept ObservationCategory)
            {
                CqlCode fzzzzzzzzc_ = this.laboratory(context);
                CqlConcept fzzzzzzzzd_ = context.Operators.ConvertCodeToConcept(fzzzzzzzzc_);
                bool? fzzzzzzzze_ = context.Operators.Equivalent(ObservationCategory, fzzzzzzzzd_);

                return fzzzzzzzze_;
            };
            IEnumerable<CqlConcept> ezzzzzzzzy_ = context.Operators.Where<CqlConcept>(ezzzzzzzzw_, ezzzzzzzzx_);
            bool? ezzzzzzzzz_ = context.Operators.Exists<CqlConcept>(ezzzzzzzzy_);
            bool? fzzzzzzzza_ = context.Operators.And(ezzzzzzzzt_, ezzzzzzzzz_);

            return fzzzzzzzza_;
        };
        IEnumerable<Observation> ezzzzzzzzn_ = context.Operators.Where<Observation>(Obs, ezzzzzzzzm_);

        return ezzzzzzzzn_;
    }


    [CqlExpressionDefinition("isMedicationActive")]
    public IEnumerable<MedicationRequest> isMedicationActive(CqlContext context, IEnumerable<MedicationRequest> MedicationRequest)
    {
        bool? fzzzzzzzzf_(MedicationRequest M)
        {
            Code<MedicationRequest.MedicationrequestStatus> fzzzzzzzzh_ = M?.StatusElement;
            MedicationRequest.MedicationrequestStatus? fzzzzzzzzi_ = fzzzzzzzzh_?.Value;
            string fzzzzzzzzj_ = context.Operators.Convert<string>(fzzzzzzzzi_);
            bool? fzzzzzzzzk_ = context.Operators.Equal(fzzzzzzzzj_, "active");
            Code<MedicationRequest.MedicationRequestIntent> fzzzzzzzzl_ = M?.IntentElement;
            MedicationRequest.MedicationRequestIntent? fzzzzzzzzm_ = fzzzzzzzzl_?.Value;
            string fzzzzzzzzn_ = context.Operators.Convert<string>(fzzzzzzzzm_);
            bool? fzzzzzzzzo_ = context.Operators.Equal(fzzzzzzzzn_, "order");
            bool? fzzzzzzzzp_ = context.Operators.And(fzzzzzzzzk_, fzzzzzzzzo_);

            return fzzzzzzzzp_;
        };
        IEnumerable<MedicationRequest> fzzzzzzzzg_ = context.Operators.Where<MedicationRequest>(MedicationRequest, fzzzzzzzzf_);

        return fzzzzzzzzg_;
    }


    [CqlExpressionDefinition("isMedicationDispensed")]
    public IEnumerable<MedicationDispense> isMedicationDispensed(CqlContext context, IEnumerable<MedicationDispense> Med)
    {
        bool? fzzzzzzzzq_(MedicationDispense M)
        {
            Code<MedicationDispense.MedicationDispenseStatusCodes> fzzzzzzzzs_ = M?.StatusElement;
            MedicationDispense.MedicationDispenseStatusCodes? fzzzzzzzzt_ = fzzzzzzzzs_?.Value;
            Code<MedicationDispense.MedicationDispenseStatusCodes> fzzzzzzzzu_ = context.Operators.Convert<Code<MedicationDispense.MedicationDispenseStatusCodes>>(fzzzzzzzzt_);
            string fzzzzzzzzv_ = context.Operators.Convert<string>(fzzzzzzzzu_);
            string[] fzzzzzzzzw_ = [
                "completed",
                "in-progress",
                "on-hold",
            ];
            bool? fzzzzzzzzx_ = context.Operators.In<string>(fzzzzzzzzv_, fzzzzzzzzw_ as IEnumerable<string>);

            return fzzzzzzzzx_;
        };
        IEnumerable<MedicationDispense> fzzzzzzzzr_ = context.Operators.Where<MedicationDispense>(Med, fzzzzzzzzq_);

        return fzzzzzzzzr_;
    }


    [CqlExpressionDefinition("isMedicationOrder")]
    public IEnumerable<MedicationRequest> isMedicationOrder(CqlContext context, IEnumerable<MedicationRequest> MedicationRequest)
    {
        bool? fzzzzzzzzy_(MedicationRequest M)
        {
            Code<MedicationRequest.MedicationrequestStatus> gzzzzzzzza_ = M?.StatusElement;
            MedicationRequest.MedicationrequestStatus? gzzzzzzzzb_ = gzzzzzzzza_?.Value;
            string gzzzzzzzzc_ = context.Operators.Convert<string>(gzzzzzzzzb_);
            string[] gzzzzzzzzd_ = [
                "active",
                "completed",
            ];
            bool? gzzzzzzzze_ = context.Operators.In<string>(gzzzzzzzzc_, gzzzzzzzzd_ as IEnumerable<string>);
            Code<MedicationRequest.MedicationRequestIntent> gzzzzzzzzf_ = M?.IntentElement;
            MedicationRequest.MedicationRequestIntent? gzzzzzzzzg_ = gzzzzzzzzf_?.Value;
            string gzzzzzzzzh_ = context.Operators.Convert<string>(gzzzzzzzzg_);
            bool? gzzzzzzzzi_ = context.Operators.Equal(gzzzzzzzzh_, "order");
            bool? gzzzzzzzzj_ = context.Operators.And(gzzzzzzzze_, gzzzzzzzzi_);

            return gzzzzzzzzj_;
        };
        IEnumerable<MedicationRequest> fzzzzzzzzz_ = context.Operators.Where<MedicationRequest>(MedicationRequest, fzzzzzzzzy_);

        return fzzzzzzzzz_;
    }


    [CqlExpressionDefinition("isPhysicalExamPerformed")]
    public IEnumerable<Observation> isPhysicalExamPerformed(CqlContext context, IEnumerable<Observation> Obs)
    {
        bool? gzzzzzzzzk_(Observation O)
        {
            Code<ObservationStatus> gzzzzzzzzm_ = O?.StatusElement;
            ObservationStatus? gzzzzzzzzn_ = gzzzzzzzzm_?.Value;
            Code<ObservationStatus> gzzzzzzzzo_ = context.Operators.Convert<Code<ObservationStatus>>(gzzzzzzzzn_);
            string gzzzzzzzzp_ = context.Operators.Convert<string>(gzzzzzzzzo_);
            string[] gzzzzzzzzq_ = [
                "final",
                "amended",
                "corrected",
            ];
            bool? gzzzzzzzzr_ = context.Operators.In<string>(gzzzzzzzzp_, gzzzzzzzzq_ as IEnumerable<string>);
            List<CodeableConcept> gzzzzzzzzs_ = O?.Category;
            CqlConcept gzzzzzzzzt_(CodeableConcept @this)
            {
                CqlConcept gzzzzzzzzz_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);

                return gzzzzzzzzz_;
            };
            IEnumerable<CqlConcept> gzzzzzzzzu_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)gzzzzzzzzs_, gzzzzzzzzt_);
            bool? gzzzzzzzzv_(CqlConcept ObservationCategory)
            {
                CqlCode hzzzzzzzza_ = this.exam(context);
                CqlConcept hzzzzzzzzb_ = context.Operators.ConvertCodeToConcept(hzzzzzzzza_);
                bool? hzzzzzzzzc_ = context.Operators.Equivalent(ObservationCategory, hzzzzzzzzb_);

                return hzzzzzzzzc_;
            };
            IEnumerable<CqlConcept> gzzzzzzzzw_ = context.Operators.Where<CqlConcept>(gzzzzzzzzu_, gzzzzzzzzv_);
            bool? gzzzzzzzzx_ = context.Operators.Exists<CqlConcept>(gzzzzzzzzw_);
            bool? gzzzzzzzzy_ = context.Operators.And(gzzzzzzzzr_, gzzzzzzzzx_);

            return gzzzzzzzzy_;
        };
        IEnumerable<Observation> gzzzzzzzzl_ = context.Operators.Where<Observation>(Obs, gzzzzzzzzk_);

        return gzzzzzzzzl_;
    }


    [CqlExpressionDefinition("isObservationBP")]
    public IEnumerable<Observation> isObservationBP(CqlContext context, IEnumerable<Observation> Obs)
    {
        bool? hzzzzzzzzd_(Observation O)
        {
            Code<ObservationStatus> hzzzzzzzzf_ = O?.StatusElement;
            ObservationStatus? hzzzzzzzzg_ = hzzzzzzzzf_?.Value;
            string hzzzzzzzzh_ = context.Operators.Convert<string>(hzzzzzzzzg_);
            string[] hzzzzzzzzi_ = [
                "final",
                "amended",
                "corrected",
            ];
            bool? hzzzzzzzzj_ = context.Operators.In<string>(hzzzzzzzzh_, hzzzzzzzzi_ as IEnumerable<string>);

            return hzzzzzzzzj_;
        };
        IEnumerable<Observation> hzzzzzzzze_ = context.Operators.Where<Observation>(Obs, hzzzzzzzzd_);

        return hzzzzzzzze_;
    }


    [CqlExpressionDefinition("isObservationBodyHeight")]
    public IEnumerable<Observation> isObservationBodyHeight(CqlContext context, IEnumerable<Observation> Obs)
    {
        bool? hzzzzzzzzk_(Observation O)
        {
            Code<ObservationStatus> hzzzzzzzzm_ = O?.StatusElement;
            ObservationStatus? hzzzzzzzzn_ = hzzzzzzzzm_?.Value;
            string hzzzzzzzzo_ = context.Operators.Convert<string>(hzzzzzzzzn_);
            string[] hzzzzzzzzp_ = [
                "final",
                "amended",
                "corrected",
            ];
            bool? hzzzzzzzzq_ = context.Operators.In<string>(hzzzzzzzzo_, hzzzzzzzzp_ as IEnumerable<string>);

            return hzzzzzzzzq_;
        };
        IEnumerable<Observation> hzzzzzzzzl_ = context.Operators.Where<Observation>(Obs, hzzzzzzzzk_);

        return hzzzzzzzzl_;
    }


    [CqlExpressionDefinition("isObservationBodyWeight")]
    public IEnumerable<Observation> isObservationBodyWeight(CqlContext context, IEnumerable<Observation> Obs)
    {
        bool? hzzzzzzzzr_(Observation O)
        {
            Code<ObservationStatus> hzzzzzzzzt_ = O?.StatusElement;
            ObservationStatus? hzzzzzzzzu_ = hzzzzzzzzt_?.Value;
            string hzzzzzzzzv_ = context.Operators.Convert<string>(hzzzzzzzzu_);
            string[] hzzzzzzzzw_ = [
                "final",
                "amended",
                "corrected",
            ];
            bool? hzzzzzzzzx_ = context.Operators.In<string>(hzzzzzzzzv_, hzzzzzzzzw_ as IEnumerable<string>);

            return hzzzzzzzzx_;
        };
        IEnumerable<Observation> hzzzzzzzzs_ = context.Operators.Where<Observation>(Obs, hzzzzzzzzr_);

        return hzzzzzzzzs_;
    }


    [CqlExpressionDefinition("isObservationBMI")]
    public IEnumerable<Observation> isObservationBMI(CqlContext context, IEnumerable<Observation> Obs)
    {
        bool? hzzzzzzzzy_(Observation O)
        {
            Code<ObservationStatus> izzzzzzzza_ = O?.StatusElement;
            ObservationStatus? izzzzzzzzb_ = izzzzzzzza_?.Value;
            string izzzzzzzzc_ = context.Operators.Convert<string>(izzzzzzzzb_);
            string[] izzzzzzzzd_ = [
                "final",
                "amended",
                "corrected",
            ];
            bool? izzzzzzzze_ = context.Operators.In<string>(izzzzzzzzc_, izzzzzzzzd_ as IEnumerable<string>);

            return izzzzzzzze_;
        };
        IEnumerable<Observation> hzzzzzzzzz_ = context.Operators.Where<Observation>(Obs, hzzzzzzzzy_);

        return hzzzzzzzzz_;
    }


    [CqlExpressionDefinition("isSymptom")]
    public IEnumerable<Observation> isSymptom(CqlContext context, IEnumerable<Observation> Obs)
    {
        bool? izzzzzzzzf_(Observation O)
        {
            Code<ObservationStatus> izzzzzzzzh_ = O?.StatusElement;
            ObservationStatus? izzzzzzzzi_ = izzzzzzzzh_?.Value;
            Code<ObservationStatus> izzzzzzzzj_ = context.Operators.Convert<Code<ObservationStatus>>(izzzzzzzzi_);
            string izzzzzzzzk_ = context.Operators.Convert<string>(izzzzzzzzj_);
            string[] izzzzzzzzl_ = [
                "preliminary",
                "final",
                "amended",
                "corrected",
            ];
            bool? izzzzzzzzm_ = context.Operators.In<string>(izzzzzzzzk_, izzzzzzzzl_ as IEnumerable<string>);

            return izzzzzzzzm_;
        };
        IEnumerable<Observation> izzzzzzzzg_ = context.Operators.Where<Observation>(Obs, izzzzzzzzf_);

        return izzzzzzzzg_;
    }


    #endregion Expressions

}
