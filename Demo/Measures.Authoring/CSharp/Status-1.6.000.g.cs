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
[CqlLibrary("Status", "1.6.000")]
public partial class Status_1_6_000 : ILibrary, ISingleton<Status_1_6_000>
{
    private Status_1_6_000() {}

    public static Status_1_6_000 Instance { get; } = new();

    #region ILibrary Implementation

    public string Name => "Status";
    public string Version => "1.6.000";
    public ILibrary[] Dependencies => [FHIRHelpers_4_3_000.Instance];

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

    [CqlCodeDefinition("vital-signs", codeId: "vital-signs", codeSystem: "http://terminology.hl7.org/CodeSystem/observation-category")]
    public CqlCode vital_signs(CqlContext _) => _vital_signs;
    private static readonly CqlCode _vital_signs = new CqlCode("vital-signs", "http://terminology.hl7.org/CodeSystem/observation-category", default, default);

    [CqlCodeDefinition("active", codeId: "active", codeSystem: "http://terminology.hl7.org/CodeSystem/condition-clinical")]
    public CqlCode active(CqlContext _) => _active;
    private static readonly CqlCode _active = new CqlCode("active", "http://terminology.hl7.org/CodeSystem/condition-clinical", default, default);

    #endregion Codes

    #region CodeSystems

    [CqlCodeSystemDefinition("ObservationCategoryCodes")]
    public CqlCodeSystem ObservationCategoryCodes(CqlContext _) => _ObservationCategoryCodes;
    private static readonly CqlCodeSystem _ObservationCategoryCodes = new CqlCodeSystem();

    [CqlCodeSystemDefinition("ConditionClinicalStatusCodes")]
    public CqlCodeSystem ConditionClinicalStatusCodes(CqlContext _) => _ConditionClinicalStatusCodes;
    private static readonly CqlCodeSystem _ConditionClinicalStatusCodes = new CqlCodeSystem();

    #endregion CodeSystems

    #region Expressions

    [CqlExpressionDefinition("Patient")]
    public Patient Patient(CqlContext context)
    {
        IEnumerable<Patient> ozza_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-patient"));
        Patient ozzb_ = context.Operators.SingletonFrom<Patient>(ozza_);

        return ozzb_;
    }


    [CqlExpressionDefinition("Final Survey Observation")]
    public IEnumerable<Observation> Final_Survey_Observation(CqlContext context, IEnumerable<Observation> Obs)
    {
        bool? ozzc_(Observation O)
        {
            Code<ObservationStatus> ozze_ = O?.StatusElement;
            ObservationStatus? ozzf_ = ozze_?.Value;
            Code<ObservationStatus> ozzg_ = context.Operators.Convert<Code<ObservationStatus>>(ozzf_);
            string ozzh_ = context.Operators.Convert<string>(ozzg_);
            string[] ozzi_ = [
                "final",
                "amended",
                "corrected",
            ];
            bool? ozzj_ = context.Operators.In<string>(ozzh_, ozzi_ as IEnumerable<string>);
            List<CodeableConcept> ozzk_ = O?.Category;
            CqlConcept ozzl_(CodeableConcept @this)
            {
                CqlConcept ozzr_ = FHIRHelpers_4_3_000.Instance.ToConcept(context, @this);

                return ozzr_;
            };
            IEnumerable<CqlConcept> ozzm_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)ozzk_, ozzl_);
            bool? ozzn_(CqlConcept ObservationCategory)
            {
                CqlCode ozzs_ = this.survey(context);
                CqlConcept ozzt_ = context.Operators.ConvertCodeToConcept(ozzs_);
                bool? ozzu_ = context.Operators.Equivalent(ObservationCategory, ozzt_);

                return ozzu_;
            };
            IEnumerable<CqlConcept> ozzo_ = context.Operators.Where<CqlConcept>(ozzm_, ozzn_);
            bool? ozzp_ = context.Operators.Exists<CqlConcept>(ozzo_);
            bool? ozzq_ = context.Operators.And(ozzj_, ozzp_);

            return ozzq_;
        };
        IEnumerable<Observation> ozzd_ = context.Operators.Where<Observation>(Obs, ozzc_);

        return ozzd_;
    }


    [CqlExpressionDefinition("isAssessmentPerformed")]
    public IEnumerable<Observation> isAssessmentPerformed(CqlContext context, IEnumerable<Observation> Obs)
    {
        bool? ozzv_(Observation O)
        {
            Code<ObservationStatus> ozzx_ = O?.StatusElement;
            ObservationStatus? ozzy_ = ozzx_?.Value;
            Code<ObservationStatus> ozzz_ = context.Operators.Convert<Code<ObservationStatus>>(ozzy_);
            string pzza_ = context.Operators.Convert<string>(ozzz_);
            string[] pzzb_ = [
                "final",
                "amended",
                "corrected",
            ];
            bool? pzzc_ = context.Operators.In<string>(pzza_, pzzb_ as IEnumerable<string>);
            List<CodeableConcept> pzzd_ = O?.Category;
            CqlConcept pzze_(CodeableConcept @this)
            {
                CqlConcept pzzk_ = FHIRHelpers_4_3_000.Instance.ToConcept(context, @this);

                return pzzk_;
            };
            IEnumerable<CqlConcept> pzzf_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)pzzd_, pzze_);
            bool? pzzg_(CqlConcept ObservationCategory)
            {
                CqlCode pzzl_ = this.survey(context);
                CqlConcept pzzm_ = context.Operators.ConvertCodeToConcept(pzzl_);
                bool? pzzn_ = context.Operators.Equivalent(ObservationCategory, pzzm_);

                return pzzn_;
            };
            IEnumerable<CqlConcept> pzzh_ = context.Operators.Where<CqlConcept>(pzzf_, pzzg_);
            bool? pzzi_ = context.Operators.Exists<CqlConcept>(pzzh_);
            bool? pzzj_ = context.Operators.And(pzzc_, pzzi_);

            return pzzj_;
        };
        IEnumerable<Observation> ozzw_ = context.Operators.Where<Observation>(Obs, ozzv_);

        return ozzw_;
    }


    [CqlExpressionDefinition("Active Condition")]
    public IEnumerable<Condition> Active_Condition(CqlContext context, IEnumerable<Condition> Condition)
    {
        bool? pzzo_(Condition C)
        {
            CodeableConcept pzzq_ = C?.ClinicalStatus;
            CqlConcept pzzr_ = FHIRHelpers_4_3_000.Instance.ToConcept(context, pzzq_);
            CqlCode pzzs_ = this.active(context);
            CqlConcept pzzt_ = context.Operators.ConvertCodeToConcept(pzzs_);
            bool? pzzu_ = context.Operators.Equivalent(pzzr_, pzzt_);

            return pzzu_;
        };
        IEnumerable<Condition> pzzp_ = context.Operators.Where<Condition>(Condition, pzzo_);

        return pzzp_;
    }


    [CqlExpressionDefinition("isActiveOnly")]
    public IEnumerable<Condition> isActiveOnly(CqlContext context, IEnumerable<Condition> Condition)
    {
        bool? pzzv_(Condition C)
        {
            CodeableConcept pzzx_ = C?.ClinicalStatus;
            CqlConcept pzzy_ = FHIRHelpers_4_3_000.Instance.ToConcept(context, pzzx_);
            CqlCode pzzz_ = this.active(context);
            CqlConcept qzza_ = context.Operators.ConvertCodeToConcept(pzzz_);
            bool? qzzb_ = context.Operators.Equivalent(pzzy_, qzza_);

            return qzzb_;
        };
        IEnumerable<Condition> pzzw_ = context.Operators.Where<Condition>(Condition, pzzv_);

        return pzzw_;
    }


    [CqlExpressionDefinition("Completed or Ongoing Device Request")]
    public IEnumerable<DeviceRequest> Completed_or_Ongoing_Device_Request(CqlContext context, IEnumerable<DeviceRequest> DeviceRequest)
    {
        bool? qzzc_(DeviceRequest D)
        {
            Code<RequestStatus> qzze_ = D?.StatusElement;
            RequestStatus? qzzf_ = qzze_?.Value;
            Code<RequestStatus> qzzg_ = context.Operators.Convert<Code<RequestStatus>>(qzzf_);
            string qzzh_ = context.Operators.Convert<string>(qzzg_);
            string[] qzzi_ = [
                "active",
                "completed",
            ];
            bool? qzzj_ = context.Operators.In<string>(qzzh_, qzzi_ as IEnumerable<string>);
            Code<RequestIntent> qzzk_ = D?.IntentElement;
            RequestIntent? qzzl_ = qzzk_?.Value;
            Code<RequestIntent> qzzm_ = context.Operators.Convert<Code<RequestIntent>>(qzzl_);
            bool? qzzn_ = context.Operators.Equal(qzzm_, "order");
            bool? qzzo_ = context.Operators.And(qzzj_, qzzn_);

            return qzzo_;
        };
        IEnumerable<DeviceRequest> qzzd_ = context.Operators.Where<DeviceRequest>(DeviceRequest, qzzc_);

        return qzzd_;
    }


    [CqlExpressionDefinition("isDeviceOrder")]
    public IEnumerable<DeviceRequest> isDeviceOrder(CqlContext context, IEnumerable<DeviceRequest> DeviceRequest)
    {
        bool? qzzp_(DeviceRequest D)
        {
            Code<RequestStatus> qzzr_ = D?.StatusElement;
            RequestStatus? qzzs_ = qzzr_?.Value;
            Code<RequestStatus> qzzt_ = context.Operators.Convert<Code<RequestStatus>>(qzzs_);
            string qzzu_ = context.Operators.Convert<string>(qzzt_);
            string[] qzzv_ = [
                "active",
                "completed",
            ];
            bool? qzzw_ = context.Operators.In<string>(qzzu_, qzzv_ as IEnumerable<string>);
            Code<RequestIntent> qzzx_ = D?.IntentElement;
            RequestIntent? qzzy_ = qzzx_?.Value;
            Code<RequestIntent> qzzz_ = context.Operators.Convert<Code<RequestIntent>>(qzzy_);
            bool? rzza_ = context.Operators.Equal(qzzz_, "order");
            bool? rzzb_ = context.Operators.And(qzzw_, rzza_);

            return rzzb_;
        };
        IEnumerable<DeviceRequest> qzzq_ = context.Operators.Where<DeviceRequest>(DeviceRequest, qzzp_);

        return qzzq_;
    }


    [CqlExpressionDefinition("Completed or Ongoing Service Request")]
    public IEnumerable<ServiceRequest> Completed_or_Ongoing_Service_Request(CqlContext context, IEnumerable<ServiceRequest> ServiceRequest)
    {
        bool? rzzc_(ServiceRequest S)
        {
            Code<RequestStatus> rzze_ = S?.StatusElement;
            RequestStatus? rzzf_ = rzze_?.Value;
            Code<RequestStatus> rzzg_ = context.Operators.Convert<Code<RequestStatus>>(rzzf_);
            string rzzh_ = context.Operators.Convert<string>(rzzg_);
            string[] rzzi_ = [
                "active",
                "completed",
            ];
            bool? rzzj_ = context.Operators.In<string>(rzzh_, rzzi_ as IEnumerable<string>);
            Code<RequestIntent> rzzk_ = S?.IntentElement;
            RequestIntent? rzzl_ = rzzk_?.Value;
            Code<RequestIntent> rzzm_ = context.Operators.Convert<Code<RequestIntent>>(rzzl_);
            bool? rzzn_ = context.Operators.Equal(rzzm_, "order");
            bool? rzzo_ = context.Operators.And(rzzj_, rzzn_);

            return rzzo_;
        };
        IEnumerable<ServiceRequest> rzzd_ = context.Operators.Where<ServiceRequest>(ServiceRequest, rzzc_);

        return rzzd_;
    }


    [CqlExpressionDefinition("isDiagnosticStudyOrder")]
    public IEnumerable<ServiceRequest> isDiagnosticStudyOrder(CqlContext context, IEnumerable<ServiceRequest> ServiceRequest)
    {
        bool? rzzp_(ServiceRequest S)
        {
            Code<RequestStatus> rzzr_ = S?.StatusElement;
            RequestStatus? rzzs_ = rzzr_?.Value;
            Code<RequestStatus> rzzt_ = context.Operators.Convert<Code<RequestStatus>>(rzzs_);
            string rzzu_ = context.Operators.Convert<string>(rzzt_);
            string[] rzzv_ = [
                "active",
                "completed",
            ];
            bool? rzzw_ = context.Operators.In<string>(rzzu_, rzzv_ as IEnumerable<string>);
            Code<RequestIntent> rzzx_ = S?.IntentElement;
            RequestIntent? rzzy_ = rzzx_?.Value;
            Code<RequestIntent> rzzz_ = context.Operators.Convert<Code<RequestIntent>>(rzzy_);
            bool? szza_ = context.Operators.Equal(rzzz_, "order");
            bool? szzb_ = context.Operators.And(rzzw_, szza_);

            return szzb_;
        };
        IEnumerable<ServiceRequest> rzzq_ = context.Operators.Where<ServiceRequest>(ServiceRequest, rzzp_);

        return rzzq_;
    }


    [CqlExpressionDefinition("isInterventionOrder")]
    public IEnumerable<ServiceRequest> isInterventionOrder(CqlContext context, IEnumerable<ServiceRequest> ServiceRequest)
    {
        bool? szzc_(ServiceRequest S)
        {
            Code<RequestStatus> szze_ = S?.StatusElement;
            RequestStatus? szzf_ = szze_?.Value;
            Code<RequestStatus> szzg_ = context.Operators.Convert<Code<RequestStatus>>(szzf_);
            string szzh_ = context.Operators.Convert<string>(szzg_);
            string[] szzi_ = [
                "active",
                "completed",
            ];
            bool? szzj_ = context.Operators.In<string>(szzh_, szzi_ as IEnumerable<string>);
            Code<RequestIntent> szzk_ = S?.IntentElement;
            RequestIntent? szzl_ = szzk_?.Value;
            Code<RequestIntent> szzm_ = context.Operators.Convert<Code<RequestIntent>>(szzl_);
            bool? szzn_ = context.Operators.Equal(szzm_, "order");
            bool? szzo_ = context.Operators.And(szzj_, szzn_);

            return szzo_;
        };
        IEnumerable<ServiceRequest> szzd_ = context.Operators.Where<ServiceRequest>(ServiceRequest, szzc_);

        return szzd_;
    }


    [CqlExpressionDefinition("isLaboratoryTestOrder")]
    public IEnumerable<ServiceRequest> isLaboratoryTestOrder(CqlContext context, IEnumerable<ServiceRequest> ServiceRequest)
    {
        bool? szzp_(ServiceRequest S)
        {
            Code<RequestStatus> szzr_ = S?.StatusElement;
            RequestStatus? szzs_ = szzr_?.Value;
            Code<RequestStatus> szzt_ = context.Operators.Convert<Code<RequestStatus>>(szzs_);
            string szzu_ = context.Operators.Convert<string>(szzt_);
            string[] szzv_ = [
                "active",
                "completed",
            ];
            bool? szzw_ = context.Operators.In<string>(szzu_, szzv_ as IEnumerable<string>);
            Code<RequestIntent> szzx_ = S?.IntentElement;
            RequestIntent? szzy_ = szzx_?.Value;
            Code<RequestIntent> szzz_ = context.Operators.Convert<Code<RequestIntent>>(szzy_);
            bool? tzza_ = context.Operators.Equal(szzz_, "order");
            bool? tzzb_ = context.Operators.And(szzw_, tzza_);

            return tzzb_;
        };
        IEnumerable<ServiceRequest> szzq_ = context.Operators.Where<ServiceRequest>(ServiceRequest, szzp_);

        return szzq_;
    }


    [CqlExpressionDefinition("Final Observation")]
    public IEnumerable<Observation> Final_Observation(CqlContext context, IEnumerable<Observation> Obs)
    {
        bool? tzzc_(Observation O)
        {
            Code<ObservationStatus> tzze_ = O?.StatusElement;
            ObservationStatus? tzzf_ = tzze_?.Value;
            Code<ObservationStatus> tzzg_ = context.Operators.Convert<Code<ObservationStatus>>(tzzf_);
            string tzzh_ = context.Operators.Convert<string>(tzzg_);
            string[] tzzi_ = [
                "final",
                "amended",
                "corrected",
            ];
            bool? tzzj_ = context.Operators.In<string>(tzzh_, tzzi_ as IEnumerable<string>);

            return tzzj_;
        };
        IEnumerable<Observation> tzzd_ = context.Operators.Where<Observation>(Obs, tzzc_);

        return tzzd_;
    }


    [CqlExpressionDefinition("isDiagnosticStudyPerformed")]
    public IEnumerable<Observation> isDiagnosticStudyPerformed(CqlContext context, IEnumerable<Observation> Obs)
    {
        bool? tzzk_(Observation O)
        {
            Code<ObservationStatus> tzzm_ = O?.StatusElement;
            ObservationStatus? tzzn_ = tzzm_?.Value;
            Code<ObservationStatus> tzzo_ = context.Operators.Convert<Code<ObservationStatus>>(tzzn_);
            string tzzp_ = context.Operators.Convert<string>(tzzo_);
            string[] tzzq_ = [
                "final",
                "amended",
                "corrected",
            ];
            bool? tzzr_ = context.Operators.In<string>(tzzp_, tzzq_ as IEnumerable<string>);

            return tzzr_;
        };
        IEnumerable<Observation> tzzl_ = context.Operators.Where<Observation>(Obs, tzzk_);

        return tzzl_;
    }


    [CqlExpressionDefinition("Finished Encounter")]
    public IEnumerable<Encounter> Finished_Encounter(CqlContext context, IEnumerable<Encounter> Enc)
    {
        bool? tzzs_(Encounter E)
        {
            Code<Encounter.EncounterStatus> tzzu_ = E?.StatusElement;
            Encounter.EncounterStatus? tzzv_ = tzzu_?.Value;
            Code<Encounter.EncounterStatus> tzzw_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(tzzv_);
            string tzzx_ = context.Operators.Convert<string>(tzzw_);
            string[] tzzy_ = [
                "finished",
                "arrived",
                "triaged",
                "in-progress",
                "onleave",
            ];
            bool? tzzz_ = context.Operators.In<string>(tzzx_, tzzy_ as IEnumerable<string>);

            return tzzz_;
        };
        IEnumerable<Encounter> tzzt_ = context.Operators.Where<Encounter>(Enc, tzzs_);

        return tzzt_;
    }


    [CqlExpressionDefinition("isEncounterPerformed")]
    public IEnumerable<Encounter> isEncounterPerformed(CqlContext context, IEnumerable<Encounter> Enc)
    {
        bool? uzza_(Encounter E)
        {
            Code<Encounter.EncounterStatus> uzzc_ = E?.StatusElement;
            Encounter.EncounterStatus? uzzd_ = uzzc_?.Value;
            Code<Encounter.EncounterStatus> uzze_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(uzzd_);
            string uzzf_ = context.Operators.Convert<string>(uzze_);
            string[] uzzg_ = [
                "finished",
                "arrived",
                "triaged",
                "in-progress",
                "onleave",
            ];
            bool? uzzh_ = context.Operators.In<string>(uzzf_, uzzg_ as IEnumerable<string>);

            return uzzh_;
        };
        IEnumerable<Encounter> uzzb_ = context.Operators.Where<Encounter>(Enc, uzza_);

        return uzzb_;
    }


    [CqlExpressionDefinition("Completed Immunization")]
    public IEnumerable<Immunization> Completed_Immunization(CqlContext context, IEnumerable<Immunization> Immunization)
    {
        bool? uzzi_(Immunization I)
        {
            Code<Immunization.ImmunizationStatusCodes> uzzk_ = I?.StatusElement;
            Immunization.ImmunizationStatusCodes? uzzl_ = uzzk_?.Value;
            string uzzm_ = context.Operators.Convert<string>(uzzl_);
            bool? uzzn_ = context.Operators.Equivalent(uzzm_, "completed");

            return uzzn_;
        };
        IEnumerable<Immunization> uzzj_ = context.Operators.Where<Immunization>(Immunization, uzzi_);

        return uzzj_;
    }


    [CqlExpressionDefinition("isImmunizationAdministered")]
    public IEnumerable<Immunization> isImmunizationAdministered(CqlContext context, IEnumerable<Immunization> Immunization)
    {
        bool? uzzo_(Immunization I)
        {
            Code<Immunization.ImmunizationStatusCodes> uzzq_ = I?.StatusElement;
            Immunization.ImmunizationStatusCodes? uzzr_ = uzzq_?.Value;
            string uzzs_ = context.Operators.Convert<string>(uzzr_);
            bool? uzzt_ = context.Operators.Equivalent(uzzs_, "completed");

            return uzzt_;
        };
        IEnumerable<Immunization> uzzp_ = context.Operators.Where<Immunization>(Immunization, uzzo_);

        return uzzp_;
    }


    [CqlExpressionDefinition("Completed Procedure")]
    public IEnumerable<Procedure> Completed_Procedure(CqlContext context, IEnumerable<Procedure> Proc)
    {
        bool? uzzu_(Procedure P)
        {
            Code<EventStatus> uzzw_ = P?.StatusElement;
            EventStatus? uzzx_ = uzzw_?.Value;
            string uzzy_ = context.Operators.Convert<string>(uzzx_);
            bool? uzzz_ = context.Operators.Equivalent(uzzy_, "completed");

            return uzzz_;
        };
        IEnumerable<Procedure> uzzv_ = context.Operators.Where<Procedure>(Proc, uzzu_);

        return uzzv_;
    }


    [CqlExpressionDefinition("isInterventionPerformed")]
    public IEnumerable<Procedure> isInterventionPerformed(CqlContext context, IEnumerable<Procedure> Proc)
    {
        bool? vzza_(Procedure P)
        {
            Code<EventStatus> vzzc_ = P?.StatusElement;
            EventStatus? vzzd_ = vzzc_?.Value;
            string vzze_ = context.Operators.Convert<string>(vzzd_);
            bool? vzzf_ = context.Operators.Equivalent(vzze_, "completed");

            return vzzf_;
        };
        IEnumerable<Procedure> vzzb_ = context.Operators.Where<Procedure>(Proc, vzza_);

        return vzzb_;
    }


    [CqlExpressionDefinition("isProcedurePerformed")]
    public IEnumerable<Procedure> isProcedurePerformed(CqlContext context, IEnumerable<Procedure> Proc)
    {
        bool? vzzg_(Procedure P)
        {
            Code<EventStatus> vzzi_ = P?.StatusElement;
            EventStatus? vzzj_ = vzzi_?.Value;
            string vzzk_ = context.Operators.Convert<string>(vzzj_);
            bool? vzzl_ = context.Operators.Equivalent(vzzk_, "completed");

            return vzzl_;
        };
        IEnumerable<Procedure> vzzh_ = context.Operators.Where<Procedure>(Proc, vzzg_);

        return vzzh_;
    }


    [CqlExpressionDefinition("Final Lab Observation")]
    public IEnumerable<Observation> Final_Lab_Observation(CqlContext context, IEnumerable<Observation> Obs)
    {
        bool? vzzm_(Observation O)
        {
            Code<ObservationStatus> vzzo_ = O?.StatusElement;
            ObservationStatus? vzzp_ = vzzo_?.Value;
            Code<ObservationStatus> vzzq_ = context.Operators.Convert<Code<ObservationStatus>>(vzzp_);
            string vzzr_ = context.Operators.Convert<string>(vzzq_);
            string[] vzzs_ = [
                "final",
                "amended",
                "corrected",
            ];
            bool? vzzt_ = context.Operators.In<string>(vzzr_, vzzs_ as IEnumerable<string>);
            List<CodeableConcept> vzzu_ = O?.Category;
            CqlConcept vzzv_(CodeableConcept @this)
            {
                CqlConcept wzzb_ = FHIRHelpers_4_3_000.Instance.ToConcept(context, @this);

                return wzzb_;
            };
            IEnumerable<CqlConcept> vzzw_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)vzzu_, vzzv_);
            bool? vzzx_(CqlConcept ObservationCategory)
            {
                CqlCode wzzc_ = this.laboratory(context);
                CqlConcept wzzd_ = context.Operators.ConvertCodeToConcept(wzzc_);
                bool? wzze_ = context.Operators.Equivalent(ObservationCategory, wzzd_);

                return wzze_;
            };
            IEnumerable<CqlConcept> vzzy_ = context.Operators.Where<CqlConcept>(vzzw_, vzzx_);
            bool? vzzz_ = context.Operators.Exists<CqlConcept>(vzzy_);
            bool? wzza_ = context.Operators.And(vzzt_, vzzz_);

            return wzza_;
        };
        IEnumerable<Observation> vzzn_ = context.Operators.Where<Observation>(Obs, vzzm_);

        return vzzn_;
    }


    [CqlExpressionDefinition("isLaboratoryTestPerformed")]
    public IEnumerable<Observation> isLaboratoryTestPerformed(CqlContext context, IEnumerable<Observation> Obs)
    {
        bool? wzzf_(Observation O)
        {
            Code<ObservationStatus> wzzh_ = O?.StatusElement;
            ObservationStatus? wzzi_ = wzzh_?.Value;
            Code<ObservationStatus> wzzj_ = context.Operators.Convert<Code<ObservationStatus>>(wzzi_);
            string wzzk_ = context.Operators.Convert<string>(wzzj_);
            string[] wzzl_ = [
                "final",
                "amended",
                "corrected",
            ];
            bool? wzzm_ = context.Operators.In<string>(wzzk_, wzzl_ as IEnumerable<string>);
            List<CodeableConcept> wzzn_ = O?.Category;
            CqlConcept wzzo_(CodeableConcept @this)
            {
                CqlConcept wzzu_ = FHIRHelpers_4_3_000.Instance.ToConcept(context, @this);

                return wzzu_;
            };
            IEnumerable<CqlConcept> wzzp_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)wzzn_, wzzo_);
            bool? wzzq_(CqlConcept ObservationCategory)
            {
                CqlCode wzzv_ = this.laboratory(context);
                CqlConcept wzzw_ = context.Operators.ConvertCodeToConcept(wzzv_);
                bool? wzzx_ = context.Operators.Equivalent(ObservationCategory, wzzw_);

                return wzzx_;
            };
            IEnumerable<CqlConcept> wzzr_ = context.Operators.Where<CqlConcept>(wzzp_, wzzq_);
            bool? wzzs_ = context.Operators.Exists<CqlConcept>(wzzr_);
            bool? wzzt_ = context.Operators.And(wzzm_, wzzs_);

            return wzzt_;
        };
        IEnumerable<Observation> wzzg_ = context.Operators.Where<Observation>(Obs, wzzf_);

        return wzzg_;
    }


    [CqlExpressionDefinition("Active Medication")]
    public IEnumerable<MedicationRequest> Active_Medication(CqlContext context, IEnumerable<MedicationRequest> MedicationRequest)
    {
        bool? wzzy_(MedicationRequest M)
        {
            Code<MedicationRequest.MedicationrequestStatus> xzza_ = M?.StatusElement;
            MedicationRequest.MedicationrequestStatus? xzzb_ = xzza_?.Value;
            string xzzc_ = context.Operators.Convert<string>(xzzb_);
            bool? xzzd_ = context.Operators.Equal(xzzc_, "active");
            Code<MedicationRequest.MedicationRequestIntent> xzze_ = M?.IntentElement;
            MedicationRequest.MedicationRequestIntent? xzzf_ = xzze_?.Value;
            string xzzg_ = context.Operators.Convert<string>(xzzf_);
            bool? xzzh_ = context.Operators.Equal(xzzg_, "order");
            bool? xzzi_ = context.Operators.And(xzzd_, xzzh_);

            return xzzi_;
        };
        IEnumerable<MedicationRequest> wzzz_ = context.Operators.Where<MedicationRequest>(MedicationRequest, wzzy_);

        return wzzz_;
    }


    [CqlExpressionDefinition("isMedicationActive")]
    public IEnumerable<MedicationRequest> isMedicationActive(CqlContext context, IEnumerable<MedicationRequest> MedicationRequest)
    {
        bool? xzzj_(MedicationRequest M)
        {
            Code<MedicationRequest.MedicationrequestStatus> xzzl_ = M?.StatusElement;
            MedicationRequest.MedicationrequestStatus? xzzm_ = xzzl_?.Value;
            string xzzn_ = context.Operators.Convert<string>(xzzm_);
            bool? xzzo_ = context.Operators.Equal(xzzn_, "active");
            Code<MedicationRequest.MedicationRequestIntent> xzzp_ = M?.IntentElement;
            MedicationRequest.MedicationRequestIntent? xzzq_ = xzzp_?.Value;
            string xzzr_ = context.Operators.Convert<string>(xzzq_);
            bool? xzzs_ = context.Operators.Equal(xzzr_, "order");
            bool? xzzt_ = context.Operators.And(xzzo_, xzzs_);

            return xzzt_;
        };
        IEnumerable<MedicationRequest> xzzk_ = context.Operators.Where<MedicationRequest>(MedicationRequest, xzzj_);

        return xzzk_;
    }


    [CqlExpressionDefinition("Dispensed Medication")]
    public IEnumerable<MedicationDispense> Dispensed_Medication(CqlContext context, IEnumerable<MedicationDispense> Med)
    {
        bool? xzzu_(MedicationDispense M)
        {
            Code<MedicationDispense.MedicationDispenseStatusCodes> xzzw_ = M?.StatusElement;
            MedicationDispense.MedicationDispenseStatusCodes? xzzx_ = xzzw_?.Value;
            Code<MedicationDispense.MedicationDispenseStatusCodes> xzzy_ = context.Operators.Convert<Code<MedicationDispense.MedicationDispenseStatusCodes>>(xzzx_);
            string xzzz_ = context.Operators.Convert<string>(xzzy_);
            string[] yzza_ = [
                "completed",
                "in-progress",
                "on-hold",
            ];
            bool? yzzb_ = context.Operators.In<string>(xzzz_, yzza_ as IEnumerable<string>);

            return yzzb_;
        };
        IEnumerable<MedicationDispense> xzzv_ = context.Operators.Where<MedicationDispense>(Med, xzzu_);

        return xzzv_;
    }


    [CqlExpressionDefinition("isMedicationDispensed")]
    public IEnumerable<MedicationDispense> isMedicationDispensed(CqlContext context, IEnumerable<MedicationDispense> Med)
    {
        bool? yzzc_(MedicationDispense M)
        {
            Code<MedicationDispense.MedicationDispenseStatusCodes> yzze_ = M?.StatusElement;
            MedicationDispense.MedicationDispenseStatusCodes? yzzf_ = yzze_?.Value;
            Code<MedicationDispense.MedicationDispenseStatusCodes> yzzg_ = context.Operators.Convert<Code<MedicationDispense.MedicationDispenseStatusCodes>>(yzzf_);
            string yzzh_ = context.Operators.Convert<string>(yzzg_);
            string[] yzzi_ = [
                "completed",
                "in-progress",
                "on-hold",
            ];
            bool? yzzj_ = context.Operators.In<string>(yzzh_, yzzi_ as IEnumerable<string>);

            return yzzj_;
        };
        IEnumerable<MedicationDispense> yzzd_ = context.Operators.Where<MedicationDispense>(Med, yzzc_);

        return yzzd_;
    }


    [CqlExpressionDefinition("Active or Completed Medication Request")]
    public IEnumerable<MedicationRequest> Active_or_Completed_Medication_Request(CqlContext context, IEnumerable<MedicationRequest> MedicationRequest)
    {
        bool? yzzk_(MedicationRequest M)
        {
            Code<MedicationRequest.MedicationrequestStatus> yzzm_ = M?.StatusElement;
            MedicationRequest.MedicationrequestStatus? yzzn_ = yzzm_?.Value;
            string yzzo_ = context.Operators.Convert<string>(yzzn_);
            string[] yzzp_ = [
                "active",
                "completed",
            ];
            bool? yzzq_ = context.Operators.In<string>(yzzo_, yzzp_ as IEnumerable<string>);
            Code<MedicationRequest.MedicationRequestIntent> yzzr_ = M?.IntentElement;
            MedicationRequest.MedicationRequestIntent? yzzs_ = yzzr_?.Value;
            string yzzt_ = context.Operators.Convert<string>(yzzs_);
            bool? yzzu_ = context.Operators.Equal(yzzt_, "order");
            bool? yzzv_ = context.Operators.And(yzzq_, yzzu_);

            return yzzv_;
        };
        IEnumerable<MedicationRequest> yzzl_ = context.Operators.Where<MedicationRequest>(MedicationRequest, yzzk_);

        return yzzl_;
    }


    [CqlExpressionDefinition("isMedicationOrder")]
    public IEnumerable<MedicationRequest> isMedicationOrder(CqlContext context, IEnumerable<MedicationRequest> MedicationRequest)
    {
        bool? yzzw_(MedicationRequest M)
        {
            Code<MedicationRequest.MedicationrequestStatus> yzzy_ = M?.StatusElement;
            MedicationRequest.MedicationrequestStatus? yzzz_ = yzzy_?.Value;
            string zzza_ = context.Operators.Convert<string>(yzzz_);
            string[] zzzb_ = [
                "active",
                "completed",
            ];
            bool? zzzc_ = context.Operators.In<string>(zzza_, zzzb_ as IEnumerable<string>);
            Code<MedicationRequest.MedicationRequestIntent> zzzd_ = M?.IntentElement;
            MedicationRequest.MedicationRequestIntent? zzze_ = zzzd_?.Value;
            string zzzf_ = context.Operators.Convert<string>(zzze_);
            bool? zzzg_ = context.Operators.Equal(zzzf_, "order");
            bool? zzzh_ = context.Operators.And(zzzc_, zzzg_);

            return zzzh_;
        };
        IEnumerable<MedicationRequest> yzzx_ = context.Operators.Where<MedicationRequest>(MedicationRequest, yzzw_);

        return yzzx_;
    }


    [CqlExpressionDefinition("Final Exam Observation")]
    public IEnumerable<Observation> Final_Exam_Observation(CqlContext context, IEnumerable<Observation> Obs)
    {
        bool? zzzi_(Observation O)
        {
            Code<ObservationStatus> zzzk_ = O?.StatusElement;
            ObservationStatus? zzzl_ = zzzk_?.Value;
            Code<ObservationStatus> zzzm_ = context.Operators.Convert<Code<ObservationStatus>>(zzzl_);
            string zzzn_ = context.Operators.Convert<string>(zzzm_);
            string[] zzzo_ = [
                "final",
                "amended",
                "corrected",
            ];
            bool? zzzp_ = context.Operators.In<string>(zzzn_, zzzo_ as IEnumerable<string>);
            List<CodeableConcept> zzzq_ = O?.Category;
            CqlConcept zzzr_(CodeableConcept @this)
            {
                CqlConcept zzzx_ = FHIRHelpers_4_3_000.Instance.ToConcept(context, @this);

                return zzzx_;
            };
            IEnumerable<CqlConcept> zzzs_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)zzzq_, zzzr_);
            bool? zzzt_(CqlConcept ObservationCategory)
            {
                CqlCode zzzy_ = this.exam(context);
                CqlConcept zzzz_ = context.Operators.ConvertCodeToConcept(zzzy_);
                bool? azzza_ = context.Operators.Equivalent(ObservationCategory, zzzz_);

                return azzza_;
            };
            IEnumerable<CqlConcept> zzzu_ = context.Operators.Where<CqlConcept>(zzzs_, zzzt_);
            bool? zzzv_ = context.Operators.Exists<CqlConcept>(zzzu_);
            bool? zzzw_ = context.Operators.And(zzzp_, zzzv_);

            return zzzw_;
        };
        IEnumerable<Observation> zzzj_ = context.Operators.Where<Observation>(Obs, zzzi_);

        return zzzj_;
    }


    [CqlExpressionDefinition("isPhysicalExamPerformed")]
    public IEnumerable<Observation> isPhysicalExamPerformed(CqlContext context, IEnumerable<Observation> Obs)
    {
        bool? azzzb_(Observation O)
        {
            Code<ObservationStatus> azzzd_ = O?.StatusElement;
            ObservationStatus? azzze_ = azzzd_?.Value;
            Code<ObservationStatus> azzzf_ = context.Operators.Convert<Code<ObservationStatus>>(azzze_);
            string azzzg_ = context.Operators.Convert<string>(azzzf_);
            string[] azzzh_ = [
                "final",
                "amended",
                "corrected",
            ];
            bool? azzzi_ = context.Operators.In<string>(azzzg_, azzzh_ as IEnumerable<string>);
            List<CodeableConcept> azzzj_ = O?.Category;
            CqlConcept azzzk_(CodeableConcept @this)
            {
                CqlConcept azzzq_ = FHIRHelpers_4_3_000.Instance.ToConcept(context, @this);

                return azzzq_;
            };
            IEnumerable<CqlConcept> azzzl_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)azzzj_, azzzk_);
            bool? azzzm_(CqlConcept ObservationCategory)
            {
                CqlCode azzzr_ = this.exam(context);
                CqlConcept azzzs_ = context.Operators.ConvertCodeToConcept(azzzr_);
                bool? azzzt_ = context.Operators.Equivalent(ObservationCategory, azzzs_);

                return azzzt_;
            };
            IEnumerable<CqlConcept> azzzn_ = context.Operators.Where<CqlConcept>(azzzl_, azzzm_);
            bool? azzzo_ = context.Operators.Exists<CqlConcept>(azzzn_);
            bool? azzzp_ = context.Operators.And(azzzi_, azzzo_);

            return azzzp_;
        };
        IEnumerable<Observation> azzzc_ = context.Operators.Where<Observation>(Obs, azzzb_);

        return azzzc_;
    }


    [CqlExpressionDefinition("BloodPressure")]
    public IEnumerable<Observation> BloodPressure(CqlContext context, IEnumerable<Observation> Obs)
    {
        bool? azzzu_(Observation O)
        {
            Code<ObservationStatus> azzzw_ = O?.StatusElement;
            ObservationStatus? azzzx_ = azzzw_?.Value;
            string azzzy_ = context.Operators.Convert<string>(azzzx_);
            string[] azzzz_ = [
                "final",
                "amended",
                "corrected",
            ];
            bool? bzzza_ = context.Operators.In<string>(azzzy_, azzzz_ as IEnumerable<string>);

            return bzzza_;
        };
        IEnumerable<Observation> azzzv_ = context.Operators.Where<Observation>(Obs, azzzu_);

        return azzzv_;
    }


    [CqlExpressionDefinition("BodyHeight")]
    public IEnumerable<Observation> BodyHeight(CqlContext context, IEnumerable<Observation> Obs)
    {
        bool? bzzzb_(Observation O)
        {
            Code<ObservationStatus> bzzzd_ = O?.StatusElement;
            ObservationStatus? bzzze_ = bzzzd_?.Value;
            string bzzzf_ = context.Operators.Convert<string>(bzzze_);
            string[] bzzzg_ = [
                "final",
                "amended",
                "corrected",
            ];
            bool? bzzzh_ = context.Operators.In<string>(bzzzf_, bzzzg_ as IEnumerable<string>);

            return bzzzh_;
        };
        IEnumerable<Observation> bzzzc_ = context.Operators.Where<Observation>(Obs, bzzzb_);

        return bzzzc_;
    }


    [CqlExpressionDefinition("BodyWeight")]
    public IEnumerable<Observation> BodyWeight(CqlContext context, IEnumerable<Observation> Obs)
    {
        bool? bzzzi_(Observation O)
        {
            Code<ObservationStatus> bzzzk_ = O?.StatusElement;
            ObservationStatus? bzzzl_ = bzzzk_?.Value;
            string bzzzm_ = context.Operators.Convert<string>(bzzzl_);
            string[] bzzzn_ = [
                "final",
                "amended",
                "corrected",
            ];
            bool? bzzzo_ = context.Operators.In<string>(bzzzm_, bzzzn_ as IEnumerable<string>);

            return bzzzo_;
        };
        IEnumerable<Observation> bzzzj_ = context.Operators.Where<Observation>(Obs, bzzzi_);

        return bzzzj_;
    }


    [CqlExpressionDefinition("BMI")]
    public IEnumerable<Observation> BMI(CqlContext context, IEnumerable<Observation> Obs)
    {
        bool? bzzzp_(Observation O)
        {
            Code<ObservationStatus> bzzzr_ = O?.StatusElement;
            ObservationStatus? bzzzs_ = bzzzr_?.Value;
            string bzzzt_ = context.Operators.Convert<string>(bzzzs_);
            string[] bzzzu_ = [
                "final",
                "amended",
                "corrected",
            ];
            bool? bzzzv_ = context.Operators.In<string>(bzzzt_, bzzzu_ as IEnumerable<string>);

            return bzzzv_;
        };
        IEnumerable<Observation> bzzzq_ = context.Operators.Where<Observation>(Obs, bzzzp_);

        return bzzzq_;
    }


    [CqlExpressionDefinition("isObservationBP")]
    public IEnumerable<Observation> isObservationBP(CqlContext context, IEnumerable<Observation> Obs)
    {
        bool? bzzzw_(Observation O)
        {
            Code<ObservationStatus> bzzzy_ = O?.StatusElement;
            ObservationStatus? bzzzz_ = bzzzy_?.Value;
            string czzza_ = context.Operators.Convert<string>(bzzzz_);
            string[] czzzb_ = [
                "final",
                "amended",
                "corrected",
            ];
            bool? czzzc_ = context.Operators.In<string>(czzza_, czzzb_ as IEnumerable<string>);

            return czzzc_;
        };
        IEnumerable<Observation> bzzzx_ = context.Operators.Where<Observation>(Obs, bzzzw_);

        return bzzzx_;
    }


    [CqlExpressionDefinition("isObservationBodyHeight")]
    public IEnumerable<Observation> isObservationBodyHeight(CqlContext context, IEnumerable<Observation> Obs)
    {
        bool? czzzd_(Observation O)
        {
            Code<ObservationStatus> czzzf_ = O?.StatusElement;
            ObservationStatus? czzzg_ = czzzf_?.Value;
            string czzzh_ = context.Operators.Convert<string>(czzzg_);
            string[] czzzi_ = [
                "final",
                "amended",
                "corrected",
            ];
            bool? czzzj_ = context.Operators.In<string>(czzzh_, czzzi_ as IEnumerable<string>);

            return czzzj_;
        };
        IEnumerable<Observation> czzze_ = context.Operators.Where<Observation>(Obs, czzzd_);

        return czzze_;
    }


    [CqlExpressionDefinition("isObservationBodyWeight")]
    public IEnumerable<Observation> isObservationBodyWeight(CqlContext context, IEnumerable<Observation> Obs)
    {
        bool? czzzk_(Observation O)
        {
            Code<ObservationStatus> czzzm_ = O?.StatusElement;
            ObservationStatus? czzzn_ = czzzm_?.Value;
            string czzzo_ = context.Operators.Convert<string>(czzzn_);
            string[] czzzp_ = [
                "final",
                "amended",
                "corrected",
            ];
            bool? czzzq_ = context.Operators.In<string>(czzzo_, czzzp_ as IEnumerable<string>);

            return czzzq_;
        };
        IEnumerable<Observation> czzzl_ = context.Operators.Where<Observation>(Obs, czzzk_);

        return czzzl_;
    }


    [CqlExpressionDefinition("isObservationBMI")]
    public IEnumerable<Observation> isObservationBMI(CqlContext context, IEnumerable<Observation> Obs)
    {
        bool? czzzr_(Observation O)
        {
            Code<ObservationStatus> czzzt_ = O?.StatusElement;
            ObservationStatus? czzzu_ = czzzt_?.Value;
            string czzzv_ = context.Operators.Convert<string>(czzzu_);
            string[] czzzw_ = [
                "final",
                "amended",
                "corrected",
            ];
            bool? czzzx_ = context.Operators.In<string>(czzzv_, czzzw_ as IEnumerable<string>);

            return czzzx_;
        };
        IEnumerable<Observation> czzzs_ = context.Operators.Where<Observation>(Obs, czzzr_);

        return czzzs_;
    }


    [CqlExpressionDefinition("Initial or Final Observation")]
    public IEnumerable<Observation> Initial_or_Final_Observation(CqlContext context, IEnumerable<Observation> Obs)
    {
        bool? czzzy_(Observation O)
        {
            Code<ObservationStatus> dzzza_ = O?.StatusElement;
            ObservationStatus? dzzzb_ = dzzza_?.Value;
            Code<ObservationStatus> dzzzc_ = context.Operators.Convert<Code<ObservationStatus>>(dzzzb_);
            string dzzzd_ = context.Operators.Convert<string>(dzzzc_);
            string[] dzzze_ = [
                "preliminary",
                "final",
                "amended",
                "corrected",
            ];
            bool? dzzzf_ = context.Operators.In<string>(dzzzd_, dzzze_ as IEnumerable<string>);

            return dzzzf_;
        };
        IEnumerable<Observation> czzzz_ = context.Operators.Where<Observation>(Obs, czzzy_);

        return czzzz_;
    }


    [CqlExpressionDefinition("isSymptom")]
    public IEnumerable<Observation> isSymptom(CqlContext context, IEnumerable<Observation> Obs)
    {
        bool? dzzzg_(Observation O)
        {
            Code<ObservationStatus> dzzzi_ = O?.StatusElement;
            ObservationStatus? dzzzj_ = dzzzi_?.Value;
            Code<ObservationStatus> dzzzk_ = context.Operators.Convert<Code<ObservationStatus>>(dzzzj_);
            string dzzzl_ = context.Operators.Convert<string>(dzzzk_);
            string[] dzzzm_ = [
                "preliminary",
                "final",
                "amended",
                "corrected",
            ];
            bool? dzzzn_ = context.Operators.In<string>(dzzzl_, dzzzm_ as IEnumerable<string>);

            return dzzzn_;
        };
        IEnumerable<Observation> dzzzh_ = context.Operators.Where<Observation>(Obs, dzzzg_);

        return dzzzh_;
    }


    #endregion Expressions

}
