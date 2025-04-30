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

    [CqlCodeSystemDefinition("ObservationCategoryCodes")]
    public CqlCodeSystem ObservationCategoryCodes(CqlContext _) => _ObservationCategoryCodes;
    private static readonly CqlCodeSystem _ObservationCategoryCodes =
      new CqlCodeSystem("http://terminology.hl7.org/CodeSystem/observation-category", null, [
          _laboratory,
          _exam,
          _survey,
          _vital_signs]);

    [CqlCodeSystemDefinition("ConditionClinicalStatusCodes")]
    public CqlCodeSystem ConditionClinicalStatusCodes(CqlContext _) => _ConditionClinicalStatusCodes;
    private static readonly CqlCodeSystem _ConditionClinicalStatusCodes =
      new CqlCodeSystem("http://terminology.hl7.org/CodeSystem/condition-clinical", null, [
          _active]);

    #endregion CodeSystems

    #region Expressions

    [CqlExpressionDefinition("Patient")]
    public Patient Patient(CqlContext context)
    {
        IEnumerable<Patient> vzzm_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-patient"));
        Patient vzzn_ = context.Operators.SingletonFrom<Patient>(vzzm_);

        return vzzn_;
    }


    [CqlExpressionDefinition("Final Survey Observation")]
    public IEnumerable<Observation> Final_Survey_Observation(CqlContext context, IEnumerable<Observation> Obs)
    {
        bool? vzzo_(Observation O)
        {
            Code<ObservationStatus> vzzq_ = O?.StatusElement;
            ObservationStatus? vzzr_ = vzzq_?.Value;
            Code<ObservationStatus> vzzs_ = context.Operators.Convert<Code<ObservationStatus>>(vzzr_);
            string vzzt_ = context.Operators.Convert<string>(vzzs_);
            string[] vzzu_ = [
                "final",
                "amended",
                "corrected",
            ];
            bool? vzzv_ = context.Operators.In<string>(vzzt_, vzzu_ as IEnumerable<string>);
            List<CodeableConcept> vzzw_ = O?.Category;
            CqlConcept vzzx_(CodeableConcept @this)
            {
                CqlConcept wzzd_ = FHIRHelpers_4_3_000.Instance.ToConcept(context, @this);

                return wzzd_;
            };
            IEnumerable<CqlConcept> vzzy_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)vzzw_, vzzx_);
            bool? vzzz_(CqlConcept ObservationCategory)
            {
                CqlCode wzze_ = this.survey(context);
                CqlConcept wzzf_ = context.Operators.ConvertCodeToConcept(wzze_);
                bool? wzzg_ = context.Operators.Equivalent(ObservationCategory, wzzf_);

                return wzzg_;
            };
            IEnumerable<CqlConcept> wzza_ = context.Operators.Where<CqlConcept>(vzzy_, vzzz_);
            bool? wzzb_ = context.Operators.Exists<CqlConcept>(wzza_);
            bool? wzzc_ = context.Operators.And(vzzv_, wzzb_);

            return wzzc_;
        };
        IEnumerable<Observation> vzzp_ = context.Operators.Where<Observation>(Obs, vzzo_);

        return vzzp_;
    }


    [CqlExpressionDefinition("isAssessmentPerformed")]
    public IEnumerable<Observation> isAssessmentPerformed(CqlContext context, IEnumerable<Observation> Obs)
    {
        bool? wzzh_(Observation O)
        {
            Code<ObservationStatus> wzzj_ = O?.StatusElement;
            ObservationStatus? wzzk_ = wzzj_?.Value;
            Code<ObservationStatus> wzzl_ = context.Operators.Convert<Code<ObservationStatus>>(wzzk_);
            string wzzm_ = context.Operators.Convert<string>(wzzl_);
            string[] wzzn_ = [
                "final",
                "amended",
                "corrected",
            ];
            bool? wzzo_ = context.Operators.In<string>(wzzm_, wzzn_ as IEnumerable<string>);
            List<CodeableConcept> wzzp_ = O?.Category;
            CqlConcept wzzq_(CodeableConcept @this)
            {
                CqlConcept wzzw_ = FHIRHelpers_4_3_000.Instance.ToConcept(context, @this);

                return wzzw_;
            };
            IEnumerable<CqlConcept> wzzr_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)wzzp_, wzzq_);
            bool? wzzs_(CqlConcept ObservationCategory)
            {
                CqlCode wzzx_ = this.survey(context);
                CqlConcept wzzy_ = context.Operators.ConvertCodeToConcept(wzzx_);
                bool? wzzz_ = context.Operators.Equivalent(ObservationCategory, wzzy_);

                return wzzz_;
            };
            IEnumerable<CqlConcept> wzzt_ = context.Operators.Where<CqlConcept>(wzzr_, wzzs_);
            bool? wzzu_ = context.Operators.Exists<CqlConcept>(wzzt_);
            bool? wzzv_ = context.Operators.And(wzzo_, wzzu_);

            return wzzv_;
        };
        IEnumerable<Observation> wzzi_ = context.Operators.Where<Observation>(Obs, wzzh_);

        return wzzi_;
    }


    [CqlExpressionDefinition("Active Condition")]
    public IEnumerable<Condition> Active_Condition(CqlContext context, IEnumerable<Condition> Condition)
    {
        bool? xzza_(Condition C)
        {
            CodeableConcept xzzc_ = C?.ClinicalStatus;
            CqlConcept xzzd_ = FHIRHelpers_4_3_000.Instance.ToConcept(context, xzzc_);
            CqlCode xzze_ = this.active(context);
            CqlConcept xzzf_ = context.Operators.ConvertCodeToConcept(xzze_);
            bool? xzzg_ = context.Operators.Equivalent(xzzd_, xzzf_);

            return xzzg_;
        };
        IEnumerable<Condition> xzzb_ = context.Operators.Where<Condition>(Condition, xzza_);

        return xzzb_;
    }


    [CqlExpressionDefinition("isActiveOnly")]
    public IEnumerable<Condition> isActiveOnly(CqlContext context, IEnumerable<Condition> Condition)
    {
        bool? xzzh_(Condition C)
        {
            CodeableConcept xzzj_ = C?.ClinicalStatus;
            CqlConcept xzzk_ = FHIRHelpers_4_3_000.Instance.ToConcept(context, xzzj_);
            CqlCode xzzl_ = this.active(context);
            CqlConcept xzzm_ = context.Operators.ConvertCodeToConcept(xzzl_);
            bool? xzzn_ = context.Operators.Equivalent(xzzk_, xzzm_);

            return xzzn_;
        };
        IEnumerable<Condition> xzzi_ = context.Operators.Where<Condition>(Condition, xzzh_);

        return xzzi_;
    }


    [CqlExpressionDefinition("Completed or Ongoing Device Request")]
    public IEnumerable<DeviceRequest> Completed_or_Ongoing_Device_Request(CqlContext context, IEnumerable<DeviceRequest> DeviceRequest)
    {
        bool? xzzo_(DeviceRequest D)
        {
            Code<RequestStatus> xzzq_ = D?.StatusElement;
            RequestStatus? xzzr_ = xzzq_?.Value;
            Code<RequestStatus> xzzs_ = context.Operators.Convert<Code<RequestStatus>>(xzzr_);
            string xzzt_ = context.Operators.Convert<string>(xzzs_);
            string[] xzzu_ = [
                "active",
                "completed",
            ];
            bool? xzzv_ = context.Operators.In<string>(xzzt_, xzzu_ as IEnumerable<string>);
            Code<RequestIntent> xzzw_ = D?.IntentElement;
            RequestIntent? xzzx_ = xzzw_?.Value;
            Code<RequestIntent> xzzy_ = context.Operators.Convert<Code<RequestIntent>>(xzzx_);
            bool? xzzz_ = context.Operators.Equal(xzzy_, "order");
            bool? yzza_ = context.Operators.And(xzzv_, xzzz_);

            return yzza_;
        };
        IEnumerable<DeviceRequest> xzzp_ = context.Operators.Where<DeviceRequest>(DeviceRequest, xzzo_);

        return xzzp_;
    }


    [CqlExpressionDefinition("isDeviceOrder")]
    public IEnumerable<DeviceRequest> isDeviceOrder(CqlContext context, IEnumerable<DeviceRequest> DeviceRequest)
    {
        bool? yzzb_(DeviceRequest D)
        {
            Code<RequestStatus> yzzd_ = D?.StatusElement;
            RequestStatus? yzze_ = yzzd_?.Value;
            Code<RequestStatus> yzzf_ = context.Operators.Convert<Code<RequestStatus>>(yzze_);
            string yzzg_ = context.Operators.Convert<string>(yzzf_);
            string[] yzzh_ = [
                "active",
                "completed",
            ];
            bool? yzzi_ = context.Operators.In<string>(yzzg_, yzzh_ as IEnumerable<string>);
            Code<RequestIntent> yzzj_ = D?.IntentElement;
            RequestIntent? yzzk_ = yzzj_?.Value;
            Code<RequestIntent> yzzl_ = context.Operators.Convert<Code<RequestIntent>>(yzzk_);
            bool? yzzm_ = context.Operators.Equal(yzzl_, "order");
            bool? yzzn_ = context.Operators.And(yzzi_, yzzm_);

            return yzzn_;
        };
        IEnumerable<DeviceRequest> yzzc_ = context.Operators.Where<DeviceRequest>(DeviceRequest, yzzb_);

        return yzzc_;
    }


    [CqlExpressionDefinition("Completed or Ongoing Service Request")]
    public IEnumerable<ServiceRequest> Completed_or_Ongoing_Service_Request(CqlContext context, IEnumerable<ServiceRequest> ServiceRequest)
    {
        bool? yzzo_(ServiceRequest S)
        {
            Code<RequestStatus> yzzq_ = S?.StatusElement;
            RequestStatus? yzzr_ = yzzq_?.Value;
            Code<RequestStatus> yzzs_ = context.Operators.Convert<Code<RequestStatus>>(yzzr_);
            string yzzt_ = context.Operators.Convert<string>(yzzs_);
            string[] yzzu_ = [
                "active",
                "completed",
            ];
            bool? yzzv_ = context.Operators.In<string>(yzzt_, yzzu_ as IEnumerable<string>);
            Code<RequestIntent> yzzw_ = S?.IntentElement;
            RequestIntent? yzzx_ = yzzw_?.Value;
            Code<RequestIntent> yzzy_ = context.Operators.Convert<Code<RequestIntent>>(yzzx_);
            bool? yzzz_ = context.Operators.Equal(yzzy_, "order");
            bool? zzza_ = context.Operators.And(yzzv_, yzzz_);

            return zzza_;
        };
        IEnumerable<ServiceRequest> yzzp_ = context.Operators.Where<ServiceRequest>(ServiceRequest, yzzo_);

        return yzzp_;
    }


    [CqlExpressionDefinition("isDiagnosticStudyOrder")]
    public IEnumerable<ServiceRequest> isDiagnosticStudyOrder(CqlContext context, IEnumerable<ServiceRequest> ServiceRequest)
    {
        bool? zzzb_(ServiceRequest S)
        {
            Code<RequestStatus> zzzd_ = S?.StatusElement;
            RequestStatus? zzze_ = zzzd_?.Value;
            Code<RequestStatus> zzzf_ = context.Operators.Convert<Code<RequestStatus>>(zzze_);
            string zzzg_ = context.Operators.Convert<string>(zzzf_);
            string[] zzzh_ = [
                "active",
                "completed",
            ];
            bool? zzzi_ = context.Operators.In<string>(zzzg_, zzzh_ as IEnumerable<string>);
            Code<RequestIntent> zzzj_ = S?.IntentElement;
            RequestIntent? zzzk_ = zzzj_?.Value;
            Code<RequestIntent> zzzl_ = context.Operators.Convert<Code<RequestIntent>>(zzzk_);
            bool? zzzm_ = context.Operators.Equal(zzzl_, "order");
            bool? zzzn_ = context.Operators.And(zzzi_, zzzm_);

            return zzzn_;
        };
        IEnumerable<ServiceRequest> zzzc_ = context.Operators.Where<ServiceRequest>(ServiceRequest, zzzb_);

        return zzzc_;
    }


    [CqlExpressionDefinition("isInterventionOrder")]
    public IEnumerable<ServiceRequest> isInterventionOrder(CqlContext context, IEnumerable<ServiceRequest> ServiceRequest)
    {
        bool? zzzo_(ServiceRequest S)
        {
            Code<RequestStatus> zzzq_ = S?.StatusElement;
            RequestStatus? zzzr_ = zzzq_?.Value;
            Code<RequestStatus> zzzs_ = context.Operators.Convert<Code<RequestStatus>>(zzzr_);
            string zzzt_ = context.Operators.Convert<string>(zzzs_);
            string[] zzzu_ = [
                "active",
                "completed",
            ];
            bool? zzzv_ = context.Operators.In<string>(zzzt_, zzzu_ as IEnumerable<string>);
            Code<RequestIntent> zzzw_ = S?.IntentElement;
            RequestIntent? zzzx_ = zzzw_?.Value;
            Code<RequestIntent> zzzy_ = context.Operators.Convert<Code<RequestIntent>>(zzzx_);
            bool? zzzz_ = context.Operators.Equal(zzzy_, "order");
            bool? azzza_ = context.Operators.And(zzzv_, zzzz_);

            return azzza_;
        };
        IEnumerable<ServiceRequest> zzzp_ = context.Operators.Where<ServiceRequest>(ServiceRequest, zzzo_);

        return zzzp_;
    }


    [CqlExpressionDefinition("isLaboratoryTestOrder")]
    public IEnumerable<ServiceRequest> isLaboratoryTestOrder(CqlContext context, IEnumerable<ServiceRequest> ServiceRequest)
    {
        bool? azzzb_(ServiceRequest S)
        {
            Code<RequestStatus> azzzd_ = S?.StatusElement;
            RequestStatus? azzze_ = azzzd_?.Value;
            Code<RequestStatus> azzzf_ = context.Operators.Convert<Code<RequestStatus>>(azzze_);
            string azzzg_ = context.Operators.Convert<string>(azzzf_);
            string[] azzzh_ = [
                "active",
                "completed",
            ];
            bool? azzzi_ = context.Operators.In<string>(azzzg_, azzzh_ as IEnumerable<string>);
            Code<RequestIntent> azzzj_ = S?.IntentElement;
            RequestIntent? azzzk_ = azzzj_?.Value;
            Code<RequestIntent> azzzl_ = context.Operators.Convert<Code<RequestIntent>>(azzzk_);
            bool? azzzm_ = context.Operators.Equal(azzzl_, "order");
            bool? azzzn_ = context.Operators.And(azzzi_, azzzm_);

            return azzzn_;
        };
        IEnumerable<ServiceRequest> azzzc_ = context.Operators.Where<ServiceRequest>(ServiceRequest, azzzb_);

        return azzzc_;
    }


    [CqlExpressionDefinition("Final Observation")]
    public IEnumerable<Observation> Final_Observation(CqlContext context, IEnumerable<Observation> Obs)
    {
        bool? azzzo_(Observation O)
        {
            Code<ObservationStatus> azzzq_ = O?.StatusElement;
            ObservationStatus? azzzr_ = azzzq_?.Value;
            Code<ObservationStatus> azzzs_ = context.Operators.Convert<Code<ObservationStatus>>(azzzr_);
            string azzzt_ = context.Operators.Convert<string>(azzzs_);
            string[] azzzu_ = [
                "final",
                "amended",
                "corrected",
            ];
            bool? azzzv_ = context.Operators.In<string>(azzzt_, azzzu_ as IEnumerable<string>);

            return azzzv_;
        };
        IEnumerable<Observation> azzzp_ = context.Operators.Where<Observation>(Obs, azzzo_);

        return azzzp_;
    }


    [CqlExpressionDefinition("isDiagnosticStudyPerformed")]
    public IEnumerable<Observation> isDiagnosticStudyPerformed(CqlContext context, IEnumerable<Observation> Obs)
    {
        bool? azzzw_(Observation O)
        {
            Code<ObservationStatus> azzzy_ = O?.StatusElement;
            ObservationStatus? azzzz_ = azzzy_?.Value;
            Code<ObservationStatus> bzzza_ = context.Operators.Convert<Code<ObservationStatus>>(azzzz_);
            string bzzzb_ = context.Operators.Convert<string>(bzzza_);
            string[] bzzzc_ = [
                "final",
                "amended",
                "corrected",
            ];
            bool? bzzzd_ = context.Operators.In<string>(bzzzb_, bzzzc_ as IEnumerable<string>);

            return bzzzd_;
        };
        IEnumerable<Observation> azzzx_ = context.Operators.Where<Observation>(Obs, azzzw_);

        return azzzx_;
    }


    [CqlExpressionDefinition("Finished Encounter")]
    public IEnumerable<Encounter> Finished_Encounter(CqlContext context, IEnumerable<Encounter> Enc)
    {
        bool? bzzze_(Encounter E)
        {
            Code<Encounter.EncounterStatus> bzzzg_ = E?.StatusElement;
            Encounter.EncounterStatus? bzzzh_ = bzzzg_?.Value;
            Code<Encounter.EncounterStatus> bzzzi_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(bzzzh_);
            string bzzzj_ = context.Operators.Convert<string>(bzzzi_);
            string[] bzzzk_ = [
                "finished",
                "arrived",
                "triaged",
                "in-progress",
                "onleave",
            ];
            bool? bzzzl_ = context.Operators.In<string>(bzzzj_, bzzzk_ as IEnumerable<string>);

            return bzzzl_;
        };
        IEnumerable<Encounter> bzzzf_ = context.Operators.Where<Encounter>(Enc, bzzze_);

        return bzzzf_;
    }


    [CqlExpressionDefinition("isEncounterPerformed")]
    public IEnumerable<Encounter> isEncounterPerformed(CqlContext context, IEnumerable<Encounter> Enc)
    {
        bool? bzzzm_(Encounter E)
        {
            Code<Encounter.EncounterStatus> bzzzo_ = E?.StatusElement;
            Encounter.EncounterStatus? bzzzp_ = bzzzo_?.Value;
            Code<Encounter.EncounterStatus> bzzzq_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(bzzzp_);
            string bzzzr_ = context.Operators.Convert<string>(bzzzq_);
            string[] bzzzs_ = [
                "finished",
                "arrived",
                "triaged",
                "in-progress",
                "onleave",
            ];
            bool? bzzzt_ = context.Operators.In<string>(bzzzr_, bzzzs_ as IEnumerable<string>);

            return bzzzt_;
        };
        IEnumerable<Encounter> bzzzn_ = context.Operators.Where<Encounter>(Enc, bzzzm_);

        return bzzzn_;
    }


    [CqlExpressionDefinition("Completed Immunization")]
    public IEnumerable<Immunization> Completed_Immunization(CqlContext context, IEnumerable<Immunization> Immunization)
    {
        bool? bzzzu_(Immunization I)
        {
            Code<Immunization.ImmunizationStatusCodes> bzzzw_ = I?.StatusElement;
            Immunization.ImmunizationStatusCodes? bzzzx_ = bzzzw_?.Value;
            string bzzzy_ = context.Operators.Convert<string>(bzzzx_);
            bool? bzzzz_ = context.Operators.Equivalent(bzzzy_, "completed");

            return bzzzz_;
        };
        IEnumerable<Immunization> bzzzv_ = context.Operators.Where<Immunization>(Immunization, bzzzu_);

        return bzzzv_;
    }


    [CqlExpressionDefinition("isImmunizationAdministered")]
    public IEnumerable<Immunization> isImmunizationAdministered(CqlContext context, IEnumerable<Immunization> Immunization)
    {
        bool? czzza_(Immunization I)
        {
            Code<Immunization.ImmunizationStatusCodes> czzzc_ = I?.StatusElement;
            Immunization.ImmunizationStatusCodes? czzzd_ = czzzc_?.Value;
            string czzze_ = context.Operators.Convert<string>(czzzd_);
            bool? czzzf_ = context.Operators.Equivalent(czzze_, "completed");

            return czzzf_;
        };
        IEnumerable<Immunization> czzzb_ = context.Operators.Where<Immunization>(Immunization, czzza_);

        return czzzb_;
    }


    [CqlExpressionDefinition("Completed Procedure")]
    public IEnumerable<Procedure> Completed_Procedure(CqlContext context, IEnumerable<Procedure> Proc)
    {
        bool? czzzg_(Procedure P)
        {
            Code<EventStatus> czzzi_ = P?.StatusElement;
            EventStatus? czzzj_ = czzzi_?.Value;
            string czzzk_ = context.Operators.Convert<string>(czzzj_);
            bool? czzzl_ = context.Operators.Equivalent(czzzk_, "completed");

            return czzzl_;
        };
        IEnumerable<Procedure> czzzh_ = context.Operators.Where<Procedure>(Proc, czzzg_);

        return czzzh_;
    }


    [CqlExpressionDefinition("isInterventionPerformed")]
    public IEnumerable<Procedure> isInterventionPerformed(CqlContext context, IEnumerable<Procedure> Proc)
    {
        bool? czzzm_(Procedure P)
        {
            Code<EventStatus> czzzo_ = P?.StatusElement;
            EventStatus? czzzp_ = czzzo_?.Value;
            string czzzq_ = context.Operators.Convert<string>(czzzp_);
            bool? czzzr_ = context.Operators.Equivalent(czzzq_, "completed");

            return czzzr_;
        };
        IEnumerable<Procedure> czzzn_ = context.Operators.Where<Procedure>(Proc, czzzm_);

        return czzzn_;
    }


    [CqlExpressionDefinition("isProcedurePerformed")]
    public IEnumerable<Procedure> isProcedurePerformed(CqlContext context, IEnumerable<Procedure> Proc)
    {
        bool? czzzs_(Procedure P)
        {
            Code<EventStatus> czzzu_ = P?.StatusElement;
            EventStatus? czzzv_ = czzzu_?.Value;
            string czzzw_ = context.Operators.Convert<string>(czzzv_);
            bool? czzzx_ = context.Operators.Equivalent(czzzw_, "completed");

            return czzzx_;
        };
        IEnumerable<Procedure> czzzt_ = context.Operators.Where<Procedure>(Proc, czzzs_);

        return czzzt_;
    }


    [CqlExpressionDefinition("Final Lab Observation")]
    public IEnumerable<Observation> Final_Lab_Observation(CqlContext context, IEnumerable<Observation> Obs)
    {
        bool? czzzy_(Observation O)
        {
            Code<ObservationStatus> dzzza_ = O?.StatusElement;
            ObservationStatus? dzzzb_ = dzzza_?.Value;
            Code<ObservationStatus> dzzzc_ = context.Operators.Convert<Code<ObservationStatus>>(dzzzb_);
            string dzzzd_ = context.Operators.Convert<string>(dzzzc_);
            string[] dzzze_ = [
                "final",
                "amended",
                "corrected",
            ];
            bool? dzzzf_ = context.Operators.In<string>(dzzzd_, dzzze_ as IEnumerable<string>);
            List<CodeableConcept> dzzzg_ = O?.Category;
            CqlConcept dzzzh_(CodeableConcept @this)
            {
                CqlConcept dzzzn_ = FHIRHelpers_4_3_000.Instance.ToConcept(context, @this);

                return dzzzn_;
            };
            IEnumerable<CqlConcept> dzzzi_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)dzzzg_, dzzzh_);
            bool? dzzzj_(CqlConcept ObservationCategory)
            {
                CqlCode dzzzo_ = this.laboratory(context);
                CqlConcept dzzzp_ = context.Operators.ConvertCodeToConcept(dzzzo_);
                bool? dzzzq_ = context.Operators.Equivalent(ObservationCategory, dzzzp_);

                return dzzzq_;
            };
            IEnumerable<CqlConcept> dzzzk_ = context.Operators.Where<CqlConcept>(dzzzi_, dzzzj_);
            bool? dzzzl_ = context.Operators.Exists<CqlConcept>(dzzzk_);
            bool? dzzzm_ = context.Operators.And(dzzzf_, dzzzl_);

            return dzzzm_;
        };
        IEnumerable<Observation> czzzz_ = context.Operators.Where<Observation>(Obs, czzzy_);

        return czzzz_;
    }


    [CqlExpressionDefinition("isLaboratoryTestPerformed")]
    public IEnumerable<Observation> isLaboratoryTestPerformed(CqlContext context, IEnumerable<Observation> Obs)
    {
        bool? dzzzr_(Observation O)
        {
            Code<ObservationStatus> dzzzt_ = O?.StatusElement;
            ObservationStatus? dzzzu_ = dzzzt_?.Value;
            Code<ObservationStatus> dzzzv_ = context.Operators.Convert<Code<ObservationStatus>>(dzzzu_);
            string dzzzw_ = context.Operators.Convert<string>(dzzzv_);
            string[] dzzzx_ = [
                "final",
                "amended",
                "corrected",
            ];
            bool? dzzzy_ = context.Operators.In<string>(dzzzw_, dzzzx_ as IEnumerable<string>);
            List<CodeableConcept> dzzzz_ = O?.Category;
            CqlConcept ezzza_(CodeableConcept @this)
            {
                CqlConcept ezzzg_ = FHIRHelpers_4_3_000.Instance.ToConcept(context, @this);

                return ezzzg_;
            };
            IEnumerable<CqlConcept> ezzzb_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)dzzzz_, ezzza_);
            bool? ezzzc_(CqlConcept ObservationCategory)
            {
                CqlCode ezzzh_ = this.laboratory(context);
                CqlConcept ezzzi_ = context.Operators.ConvertCodeToConcept(ezzzh_);
                bool? ezzzj_ = context.Operators.Equivalent(ObservationCategory, ezzzi_);

                return ezzzj_;
            };
            IEnumerable<CqlConcept> ezzzd_ = context.Operators.Where<CqlConcept>(ezzzb_, ezzzc_);
            bool? ezzze_ = context.Operators.Exists<CqlConcept>(ezzzd_);
            bool? ezzzf_ = context.Operators.And(dzzzy_, ezzze_);

            return ezzzf_;
        };
        IEnumerable<Observation> dzzzs_ = context.Operators.Where<Observation>(Obs, dzzzr_);

        return dzzzs_;
    }


    [CqlExpressionDefinition("Active Medication")]
    public IEnumerable<MedicationRequest> Active_Medication(CqlContext context, IEnumerable<MedicationRequest> MedicationRequest)
    {
        bool? ezzzk_(MedicationRequest M)
        {
            Code<MedicationRequest.MedicationrequestStatus> ezzzm_ = M?.StatusElement;
            MedicationRequest.MedicationrequestStatus? ezzzn_ = ezzzm_?.Value;
            string ezzzo_ = context.Operators.Convert<string>(ezzzn_);
            bool? ezzzp_ = context.Operators.Equal(ezzzo_, "active");
            Code<MedicationRequest.MedicationRequestIntent> ezzzq_ = M?.IntentElement;
            MedicationRequest.MedicationRequestIntent? ezzzr_ = ezzzq_?.Value;
            string ezzzs_ = context.Operators.Convert<string>(ezzzr_);
            bool? ezzzt_ = context.Operators.Equal(ezzzs_, "order");
            bool? ezzzu_ = context.Operators.And(ezzzp_, ezzzt_);

            return ezzzu_;
        };
        IEnumerable<MedicationRequest> ezzzl_ = context.Operators.Where<MedicationRequest>(MedicationRequest, ezzzk_);

        return ezzzl_;
    }


    [CqlExpressionDefinition("isMedicationActive")]
    public IEnumerable<MedicationRequest> isMedicationActive(CqlContext context, IEnumerable<MedicationRequest> MedicationRequest)
    {
        bool? ezzzv_(MedicationRequest M)
        {
            Code<MedicationRequest.MedicationrequestStatus> ezzzx_ = M?.StatusElement;
            MedicationRequest.MedicationrequestStatus? ezzzy_ = ezzzx_?.Value;
            string ezzzz_ = context.Operators.Convert<string>(ezzzy_);
            bool? fzzza_ = context.Operators.Equal(ezzzz_, "active");
            Code<MedicationRequest.MedicationRequestIntent> fzzzb_ = M?.IntentElement;
            MedicationRequest.MedicationRequestIntent? fzzzc_ = fzzzb_?.Value;
            string fzzzd_ = context.Operators.Convert<string>(fzzzc_);
            bool? fzzze_ = context.Operators.Equal(fzzzd_, "order");
            bool? fzzzf_ = context.Operators.And(fzzza_, fzzze_);

            return fzzzf_;
        };
        IEnumerable<MedicationRequest> ezzzw_ = context.Operators.Where<MedicationRequest>(MedicationRequest, ezzzv_);

        return ezzzw_;
    }


    [CqlExpressionDefinition("Dispensed Medication")]
    public IEnumerable<MedicationDispense> Dispensed_Medication(CqlContext context, IEnumerable<MedicationDispense> Med)
    {
        bool? fzzzg_(MedicationDispense M)
        {
            Code<MedicationDispense.MedicationDispenseStatusCodes> fzzzi_ = M?.StatusElement;
            MedicationDispense.MedicationDispenseStatusCodes? fzzzj_ = fzzzi_?.Value;
            Code<MedicationDispense.MedicationDispenseStatusCodes> fzzzk_ = context.Operators.Convert<Code<MedicationDispense.MedicationDispenseStatusCodes>>(fzzzj_);
            string fzzzl_ = context.Operators.Convert<string>(fzzzk_);
            string[] fzzzm_ = [
                "completed",
                "in-progress",
                "on-hold",
            ];
            bool? fzzzn_ = context.Operators.In<string>(fzzzl_, fzzzm_ as IEnumerable<string>);

            return fzzzn_;
        };
        IEnumerable<MedicationDispense> fzzzh_ = context.Operators.Where<MedicationDispense>(Med, fzzzg_);

        return fzzzh_;
    }


    [CqlExpressionDefinition("isMedicationDispensed")]
    public IEnumerable<MedicationDispense> isMedicationDispensed(CqlContext context, IEnumerable<MedicationDispense> Med)
    {
        bool? fzzzo_(MedicationDispense M)
        {
            Code<MedicationDispense.MedicationDispenseStatusCodes> fzzzq_ = M?.StatusElement;
            MedicationDispense.MedicationDispenseStatusCodes? fzzzr_ = fzzzq_?.Value;
            Code<MedicationDispense.MedicationDispenseStatusCodes> fzzzs_ = context.Operators.Convert<Code<MedicationDispense.MedicationDispenseStatusCodes>>(fzzzr_);
            string fzzzt_ = context.Operators.Convert<string>(fzzzs_);
            string[] fzzzu_ = [
                "completed",
                "in-progress",
                "on-hold",
            ];
            bool? fzzzv_ = context.Operators.In<string>(fzzzt_, fzzzu_ as IEnumerable<string>);

            return fzzzv_;
        };
        IEnumerable<MedicationDispense> fzzzp_ = context.Operators.Where<MedicationDispense>(Med, fzzzo_);

        return fzzzp_;
    }


    [CqlExpressionDefinition("Active or Completed Medication Request")]
    public IEnumerable<MedicationRequest> Active_or_Completed_Medication_Request(CqlContext context, IEnumerable<MedicationRequest> MedicationRequest)
    {
        bool? fzzzw_(MedicationRequest M)
        {
            Code<MedicationRequest.MedicationrequestStatus> fzzzy_ = M?.StatusElement;
            MedicationRequest.MedicationrequestStatus? fzzzz_ = fzzzy_?.Value;
            string gzzza_ = context.Operators.Convert<string>(fzzzz_);
            string[] gzzzb_ = [
                "active",
                "completed",
            ];
            bool? gzzzc_ = context.Operators.In<string>(gzzza_, gzzzb_ as IEnumerable<string>);
            Code<MedicationRequest.MedicationRequestIntent> gzzzd_ = M?.IntentElement;
            MedicationRequest.MedicationRequestIntent? gzzze_ = gzzzd_?.Value;
            string gzzzf_ = context.Operators.Convert<string>(gzzze_);
            bool? gzzzg_ = context.Operators.Equal(gzzzf_, "order");
            bool? gzzzh_ = context.Operators.And(gzzzc_, gzzzg_);

            return gzzzh_;
        };
        IEnumerable<MedicationRequest> fzzzx_ = context.Operators.Where<MedicationRequest>(MedicationRequest, fzzzw_);

        return fzzzx_;
    }


    [CqlExpressionDefinition("isMedicationOrder")]
    public IEnumerable<MedicationRequest> isMedicationOrder(CqlContext context, IEnumerable<MedicationRequest> MedicationRequest)
    {
        bool? gzzzi_(MedicationRequest M)
        {
            Code<MedicationRequest.MedicationrequestStatus> gzzzk_ = M?.StatusElement;
            MedicationRequest.MedicationrequestStatus? gzzzl_ = gzzzk_?.Value;
            string gzzzm_ = context.Operators.Convert<string>(gzzzl_);
            string[] gzzzn_ = [
                "active",
                "completed",
            ];
            bool? gzzzo_ = context.Operators.In<string>(gzzzm_, gzzzn_ as IEnumerable<string>);
            Code<MedicationRequest.MedicationRequestIntent> gzzzp_ = M?.IntentElement;
            MedicationRequest.MedicationRequestIntent? gzzzq_ = gzzzp_?.Value;
            string gzzzr_ = context.Operators.Convert<string>(gzzzq_);
            bool? gzzzs_ = context.Operators.Equal(gzzzr_, "order");
            bool? gzzzt_ = context.Operators.And(gzzzo_, gzzzs_);

            return gzzzt_;
        };
        IEnumerable<MedicationRequest> gzzzj_ = context.Operators.Where<MedicationRequest>(MedicationRequest, gzzzi_);

        return gzzzj_;
    }


    [CqlExpressionDefinition("Final Exam Observation")]
    public IEnumerable<Observation> Final_Exam_Observation(CqlContext context, IEnumerable<Observation> Obs)
    {
        bool? gzzzu_(Observation O)
        {
            Code<ObservationStatus> gzzzw_ = O?.StatusElement;
            ObservationStatus? gzzzx_ = gzzzw_?.Value;
            Code<ObservationStatus> gzzzy_ = context.Operators.Convert<Code<ObservationStatus>>(gzzzx_);
            string gzzzz_ = context.Operators.Convert<string>(gzzzy_);
            string[] hzzza_ = [
                "final",
                "amended",
                "corrected",
            ];
            bool? hzzzb_ = context.Operators.In<string>(gzzzz_, hzzza_ as IEnumerable<string>);
            List<CodeableConcept> hzzzc_ = O?.Category;
            CqlConcept hzzzd_(CodeableConcept @this)
            {
                CqlConcept hzzzj_ = FHIRHelpers_4_3_000.Instance.ToConcept(context, @this);

                return hzzzj_;
            };
            IEnumerable<CqlConcept> hzzze_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)hzzzc_, hzzzd_);
            bool? hzzzf_(CqlConcept ObservationCategory)
            {
                CqlCode hzzzk_ = this.exam(context);
                CqlConcept hzzzl_ = context.Operators.ConvertCodeToConcept(hzzzk_);
                bool? hzzzm_ = context.Operators.Equivalent(ObservationCategory, hzzzl_);

                return hzzzm_;
            };
            IEnumerable<CqlConcept> hzzzg_ = context.Operators.Where<CqlConcept>(hzzze_, hzzzf_);
            bool? hzzzh_ = context.Operators.Exists<CqlConcept>(hzzzg_);
            bool? hzzzi_ = context.Operators.And(hzzzb_, hzzzh_);

            return hzzzi_;
        };
        IEnumerable<Observation> gzzzv_ = context.Operators.Where<Observation>(Obs, gzzzu_);

        return gzzzv_;
    }


    [CqlExpressionDefinition("isPhysicalExamPerformed")]
    public IEnumerable<Observation> isPhysicalExamPerformed(CqlContext context, IEnumerable<Observation> Obs)
    {
        bool? hzzzn_(Observation O)
        {
            Code<ObservationStatus> hzzzp_ = O?.StatusElement;
            ObservationStatus? hzzzq_ = hzzzp_?.Value;
            Code<ObservationStatus> hzzzr_ = context.Operators.Convert<Code<ObservationStatus>>(hzzzq_);
            string hzzzs_ = context.Operators.Convert<string>(hzzzr_);
            string[] hzzzt_ = [
                "final",
                "amended",
                "corrected",
            ];
            bool? hzzzu_ = context.Operators.In<string>(hzzzs_, hzzzt_ as IEnumerable<string>);
            List<CodeableConcept> hzzzv_ = O?.Category;
            CqlConcept hzzzw_(CodeableConcept @this)
            {
                CqlConcept izzzc_ = FHIRHelpers_4_3_000.Instance.ToConcept(context, @this);

                return izzzc_;
            };
            IEnumerable<CqlConcept> hzzzx_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)hzzzv_, hzzzw_);
            bool? hzzzy_(CqlConcept ObservationCategory)
            {
                CqlCode izzzd_ = this.exam(context);
                CqlConcept izzze_ = context.Operators.ConvertCodeToConcept(izzzd_);
                bool? izzzf_ = context.Operators.Equivalent(ObservationCategory, izzze_);

                return izzzf_;
            };
            IEnumerable<CqlConcept> hzzzz_ = context.Operators.Where<CqlConcept>(hzzzx_, hzzzy_);
            bool? izzza_ = context.Operators.Exists<CqlConcept>(hzzzz_);
            bool? izzzb_ = context.Operators.And(hzzzu_, izzza_);

            return izzzb_;
        };
        IEnumerable<Observation> hzzzo_ = context.Operators.Where<Observation>(Obs, hzzzn_);

        return hzzzo_;
    }


    [CqlExpressionDefinition("BloodPressure")]
    public IEnumerable<Observation> BloodPressure(CqlContext context, IEnumerable<Observation> Obs)
    {
        bool? izzzg_(Observation O)
        {
            Code<ObservationStatus> izzzi_ = O?.StatusElement;
            ObservationStatus? izzzj_ = izzzi_?.Value;
            string izzzk_ = context.Operators.Convert<string>(izzzj_);
            string[] izzzl_ = [
                "final",
                "amended",
                "corrected",
            ];
            bool? izzzm_ = context.Operators.In<string>(izzzk_, izzzl_ as IEnumerable<string>);

            return izzzm_;
        };
        IEnumerable<Observation> izzzh_ = context.Operators.Where<Observation>(Obs, izzzg_);

        return izzzh_;
    }


    [CqlExpressionDefinition("BodyHeight")]
    public IEnumerable<Observation> BodyHeight(CqlContext context, IEnumerable<Observation> Obs)
    {
        bool? izzzn_(Observation O)
        {
            Code<ObservationStatus> izzzp_ = O?.StatusElement;
            ObservationStatus? izzzq_ = izzzp_?.Value;
            string izzzr_ = context.Operators.Convert<string>(izzzq_);
            string[] izzzs_ = [
                "final",
                "amended",
                "corrected",
            ];
            bool? izzzt_ = context.Operators.In<string>(izzzr_, izzzs_ as IEnumerable<string>);

            return izzzt_;
        };
        IEnumerable<Observation> izzzo_ = context.Operators.Where<Observation>(Obs, izzzn_);

        return izzzo_;
    }


    [CqlExpressionDefinition("BodyWeight")]
    public IEnumerable<Observation> BodyWeight(CqlContext context, IEnumerable<Observation> Obs)
    {
        bool? izzzu_(Observation O)
        {
            Code<ObservationStatus> izzzw_ = O?.StatusElement;
            ObservationStatus? izzzx_ = izzzw_?.Value;
            string izzzy_ = context.Operators.Convert<string>(izzzx_);
            string[] izzzz_ = [
                "final",
                "amended",
                "corrected",
            ];
            bool? jzzza_ = context.Operators.In<string>(izzzy_, izzzz_ as IEnumerable<string>);

            return jzzza_;
        };
        IEnumerable<Observation> izzzv_ = context.Operators.Where<Observation>(Obs, izzzu_);

        return izzzv_;
    }


    [CqlExpressionDefinition("BMI")]
    public IEnumerable<Observation> BMI(CqlContext context, IEnumerable<Observation> Obs)
    {
        bool? jzzzb_(Observation O)
        {
            Code<ObservationStatus> jzzzd_ = O?.StatusElement;
            ObservationStatus? jzzze_ = jzzzd_?.Value;
            string jzzzf_ = context.Operators.Convert<string>(jzzze_);
            string[] jzzzg_ = [
                "final",
                "amended",
                "corrected",
            ];
            bool? jzzzh_ = context.Operators.In<string>(jzzzf_, jzzzg_ as IEnumerable<string>);

            return jzzzh_;
        };
        IEnumerable<Observation> jzzzc_ = context.Operators.Where<Observation>(Obs, jzzzb_);

        return jzzzc_;
    }


    [CqlExpressionDefinition("isObservationBP")]
    public IEnumerable<Observation> isObservationBP(CqlContext context, IEnumerable<Observation> Obs)
    {
        bool? jzzzi_(Observation O)
        {
            Code<ObservationStatus> jzzzk_ = O?.StatusElement;
            ObservationStatus? jzzzl_ = jzzzk_?.Value;
            string jzzzm_ = context.Operators.Convert<string>(jzzzl_);
            string[] jzzzn_ = [
                "final",
                "amended",
                "corrected",
            ];
            bool? jzzzo_ = context.Operators.In<string>(jzzzm_, jzzzn_ as IEnumerable<string>);

            return jzzzo_;
        };
        IEnumerable<Observation> jzzzj_ = context.Operators.Where<Observation>(Obs, jzzzi_);

        return jzzzj_;
    }


    [CqlExpressionDefinition("isObservationBodyHeight")]
    public IEnumerable<Observation> isObservationBodyHeight(CqlContext context, IEnumerable<Observation> Obs)
    {
        bool? jzzzp_(Observation O)
        {
            Code<ObservationStatus> jzzzr_ = O?.StatusElement;
            ObservationStatus? jzzzs_ = jzzzr_?.Value;
            string jzzzt_ = context.Operators.Convert<string>(jzzzs_);
            string[] jzzzu_ = [
                "final",
                "amended",
                "corrected",
            ];
            bool? jzzzv_ = context.Operators.In<string>(jzzzt_, jzzzu_ as IEnumerable<string>);

            return jzzzv_;
        };
        IEnumerable<Observation> jzzzq_ = context.Operators.Where<Observation>(Obs, jzzzp_);

        return jzzzq_;
    }


    [CqlExpressionDefinition("isObservationBodyWeight")]
    public IEnumerable<Observation> isObservationBodyWeight(CqlContext context, IEnumerable<Observation> Obs)
    {
        bool? jzzzw_(Observation O)
        {
            Code<ObservationStatus> jzzzy_ = O?.StatusElement;
            ObservationStatus? jzzzz_ = jzzzy_?.Value;
            string kzzza_ = context.Operators.Convert<string>(jzzzz_);
            string[] kzzzb_ = [
                "final",
                "amended",
                "corrected",
            ];
            bool? kzzzc_ = context.Operators.In<string>(kzzza_, kzzzb_ as IEnumerable<string>);

            return kzzzc_;
        };
        IEnumerable<Observation> jzzzx_ = context.Operators.Where<Observation>(Obs, jzzzw_);

        return jzzzx_;
    }


    [CqlExpressionDefinition("isObservationBMI")]
    public IEnumerable<Observation> isObservationBMI(CqlContext context, IEnumerable<Observation> Obs)
    {
        bool? kzzzd_(Observation O)
        {
            Code<ObservationStatus> kzzzf_ = O?.StatusElement;
            ObservationStatus? kzzzg_ = kzzzf_?.Value;
            string kzzzh_ = context.Operators.Convert<string>(kzzzg_);
            string[] kzzzi_ = [
                "final",
                "amended",
                "corrected",
            ];
            bool? kzzzj_ = context.Operators.In<string>(kzzzh_, kzzzi_ as IEnumerable<string>);

            return kzzzj_;
        };
        IEnumerable<Observation> kzzze_ = context.Operators.Where<Observation>(Obs, kzzzd_);

        return kzzze_;
    }


    [CqlExpressionDefinition("Initial or Final Observation")]
    public IEnumerable<Observation> Initial_or_Final_Observation(CqlContext context, IEnumerable<Observation> Obs)
    {
        bool? kzzzk_(Observation O)
        {
            Code<ObservationStatus> kzzzm_ = O?.StatusElement;
            ObservationStatus? kzzzn_ = kzzzm_?.Value;
            Code<ObservationStatus> kzzzo_ = context.Operators.Convert<Code<ObservationStatus>>(kzzzn_);
            string kzzzp_ = context.Operators.Convert<string>(kzzzo_);
            string[] kzzzq_ = [
                "preliminary",
                "final",
                "amended",
                "corrected",
            ];
            bool? kzzzr_ = context.Operators.In<string>(kzzzp_, kzzzq_ as IEnumerable<string>);

            return kzzzr_;
        };
        IEnumerable<Observation> kzzzl_ = context.Operators.Where<Observation>(Obs, kzzzk_);

        return kzzzl_;
    }


    [CqlExpressionDefinition("isSymptom")]
    public IEnumerable<Observation> isSymptom(CqlContext context, IEnumerable<Observation> Obs)
    {
        bool? kzzzs_(Observation O)
        {
            Code<ObservationStatus> kzzzu_ = O?.StatusElement;
            ObservationStatus? kzzzv_ = kzzzu_?.Value;
            Code<ObservationStatus> kzzzw_ = context.Operators.Convert<Code<ObservationStatus>>(kzzzv_);
            string kzzzx_ = context.Operators.Convert<string>(kzzzw_);
            string[] kzzzy_ = [
                "preliminary",
                "final",
                "amended",
                "corrected",
            ];
            bool? kzzzz_ = context.Operators.In<string>(kzzzx_, kzzzy_ as IEnumerable<string>);

            return kzzzz_;
        };
        IEnumerable<Observation> kzzzt_ = context.Operators.Where<Observation>(Obs, kzzzs_);

        return kzzzt_;
    }


    #endregion Expressions

}
