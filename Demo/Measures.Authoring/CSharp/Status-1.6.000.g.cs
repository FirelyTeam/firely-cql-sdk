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
      new CqlCodeSystem("http://terminology.hl7.org/CodeSystem/observation-category", null,
          _laboratory,
          _exam,
          _survey,
          _vital_signs);

    [CqlCodeSystemDefinition("ConditionClinicalStatusCodes")]
    public CqlCodeSystem ConditionClinicalStatusCodes(CqlContext _) => _ConditionClinicalStatusCodes;
    private static readonly CqlCodeSystem _ConditionClinicalStatusCodes =
      new CqlCodeSystem("http://terminology.hl7.org/CodeSystem/condition-clinical", null,
          _active);

    #endregion CodeSystems

    #region Expressions

    [CqlExpressionDefinition("Patient")]
    public Patient Patient(CqlContext context)
    {
        IEnumerable<Patient> wzzg_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-patient"));
        Patient wzzh_ = context.Operators.SingletonFrom<Patient>(wzzg_);

        return wzzh_;
    }


    [CqlExpressionDefinition("Final Survey Observation")]
    public IEnumerable<Observation> Final_Survey_Observation(CqlContext context, IEnumerable<Observation> Obs)
    {
        bool? wzzi_(Observation O)
        {
            Code<ObservationStatus> wzzk_ = O?.StatusElement;
            ObservationStatus? wzzl_ = wzzk_?.Value;
            Code<ObservationStatus> wzzm_ = context.Operators.Convert<Code<ObservationStatus>>(wzzl_);
            string wzzn_ = context.Operators.Convert<string>(wzzm_);
            string[] wzzo_ = [
                "final",
                "amended",
                "corrected",
            ];
            bool? wzzp_ = context.Operators.In<string>(wzzn_, wzzo_ as IEnumerable<string>);
            List<CodeableConcept> wzzq_ = O?.Category;
            CqlConcept wzzr_(CodeableConcept @this)
            {
                CqlConcept wzzx_ = FHIRHelpers_4_3_000.Instance.ToConcept(context, @this);

                return wzzx_;
            };
            IEnumerable<CqlConcept> wzzs_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)wzzq_, wzzr_);
            bool? wzzt_(CqlConcept ObservationCategory)
            {
                CqlCode wzzy_ = this.survey(context);
                CqlConcept wzzz_ = context.Operators.ConvertCodeToConcept(wzzy_);
                bool? xzza_ = context.Operators.Equivalent(ObservationCategory, wzzz_);

                return xzza_;
            };
            IEnumerable<CqlConcept> wzzu_ = context.Operators.Where<CqlConcept>(wzzs_, wzzt_);
            bool? wzzv_ = context.Operators.Exists<CqlConcept>(wzzu_);
            bool? wzzw_ = context.Operators.And(wzzp_, wzzv_);

            return wzzw_;
        };
        IEnumerable<Observation> wzzj_ = context.Operators.Where<Observation>(Obs, wzzi_);

        return wzzj_;
    }


    [CqlExpressionDefinition("isAssessmentPerformed")]
    public IEnumerable<Observation> isAssessmentPerformed(CqlContext context, IEnumerable<Observation> Obs)
    {
        bool? xzzb_(Observation O)
        {
            Code<ObservationStatus> xzzd_ = O?.StatusElement;
            ObservationStatus? xzze_ = xzzd_?.Value;
            Code<ObservationStatus> xzzf_ = context.Operators.Convert<Code<ObservationStatus>>(xzze_);
            string xzzg_ = context.Operators.Convert<string>(xzzf_);
            string[] xzzh_ = [
                "final",
                "amended",
                "corrected",
            ];
            bool? xzzi_ = context.Operators.In<string>(xzzg_, xzzh_ as IEnumerable<string>);
            List<CodeableConcept> xzzj_ = O?.Category;
            CqlConcept xzzk_(CodeableConcept @this)
            {
                CqlConcept xzzq_ = FHIRHelpers_4_3_000.Instance.ToConcept(context, @this);

                return xzzq_;
            };
            IEnumerable<CqlConcept> xzzl_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)xzzj_, xzzk_);
            bool? xzzm_(CqlConcept ObservationCategory)
            {
                CqlCode xzzr_ = this.survey(context);
                CqlConcept xzzs_ = context.Operators.ConvertCodeToConcept(xzzr_);
                bool? xzzt_ = context.Operators.Equivalent(ObservationCategory, xzzs_);

                return xzzt_;
            };
            IEnumerable<CqlConcept> xzzn_ = context.Operators.Where<CqlConcept>(xzzl_, xzzm_);
            bool? xzzo_ = context.Operators.Exists<CqlConcept>(xzzn_);
            bool? xzzp_ = context.Operators.And(xzzi_, xzzo_);

            return xzzp_;
        };
        IEnumerable<Observation> xzzc_ = context.Operators.Where<Observation>(Obs, xzzb_);

        return xzzc_;
    }


    [CqlExpressionDefinition("Active Condition")]
    public IEnumerable<Condition> Active_Condition(CqlContext context, IEnumerable<Condition> Condition)
    {
        bool? xzzu_(Condition C)
        {
            CodeableConcept xzzw_ = C?.ClinicalStatus;
            CqlConcept xzzx_ = FHIRHelpers_4_3_000.Instance.ToConcept(context, xzzw_);
            CqlCode xzzy_ = this.active(context);
            CqlConcept xzzz_ = context.Operators.ConvertCodeToConcept(xzzy_);
            bool? yzza_ = context.Operators.Equivalent(xzzx_, xzzz_);

            return yzza_;
        };
        IEnumerable<Condition> xzzv_ = context.Operators.Where<Condition>(Condition, xzzu_);

        return xzzv_;
    }


    [CqlExpressionDefinition("isActiveOnly")]
    public IEnumerable<Condition> isActiveOnly(CqlContext context, IEnumerable<Condition> Condition)
    {
        bool? yzzb_(Condition C)
        {
            CodeableConcept yzzd_ = C?.ClinicalStatus;
            CqlConcept yzze_ = FHIRHelpers_4_3_000.Instance.ToConcept(context, yzzd_);
            CqlCode yzzf_ = this.active(context);
            CqlConcept yzzg_ = context.Operators.ConvertCodeToConcept(yzzf_);
            bool? yzzh_ = context.Operators.Equivalent(yzze_, yzzg_);

            return yzzh_;
        };
        IEnumerable<Condition> yzzc_ = context.Operators.Where<Condition>(Condition, yzzb_);

        return yzzc_;
    }


    [CqlExpressionDefinition("Completed or Ongoing Device Request")]
    public IEnumerable<DeviceRequest> Completed_or_Ongoing_Device_Request(CqlContext context, IEnumerable<DeviceRequest> DeviceRequest)
    {
        bool? yzzi_(DeviceRequest D)
        {
            Code<RequestStatus> yzzk_ = D?.StatusElement;
            RequestStatus? yzzl_ = yzzk_?.Value;
            Code<RequestStatus> yzzm_ = context.Operators.Convert<Code<RequestStatus>>(yzzl_);
            string yzzn_ = context.Operators.Convert<string>(yzzm_);
            string[] yzzo_ = [
                "active",
                "completed",
            ];
            bool? yzzp_ = context.Operators.In<string>(yzzn_, yzzo_ as IEnumerable<string>);
            Code<RequestIntent> yzzq_ = D?.IntentElement;
            RequestIntent? yzzr_ = yzzq_?.Value;
            Code<RequestIntent> yzzs_ = context.Operators.Convert<Code<RequestIntent>>(yzzr_);
            bool? yzzt_ = context.Operators.Equal(yzzs_, "order");
            bool? yzzu_ = context.Operators.And(yzzp_, yzzt_);

            return yzzu_;
        };
        IEnumerable<DeviceRequest> yzzj_ = context.Operators.Where<DeviceRequest>(DeviceRequest, yzzi_);

        return yzzj_;
    }


    [CqlExpressionDefinition("isDeviceOrder")]
    public IEnumerable<DeviceRequest> isDeviceOrder(CqlContext context, IEnumerable<DeviceRequest> DeviceRequest)
    {
        bool? yzzv_(DeviceRequest D)
        {
            Code<RequestStatus> yzzx_ = D?.StatusElement;
            RequestStatus? yzzy_ = yzzx_?.Value;
            Code<RequestStatus> yzzz_ = context.Operators.Convert<Code<RequestStatus>>(yzzy_);
            string zzza_ = context.Operators.Convert<string>(yzzz_);
            string[] zzzb_ = [
                "active",
                "completed",
            ];
            bool? zzzc_ = context.Operators.In<string>(zzza_, zzzb_ as IEnumerable<string>);
            Code<RequestIntent> zzzd_ = D?.IntentElement;
            RequestIntent? zzze_ = zzzd_?.Value;
            Code<RequestIntent> zzzf_ = context.Operators.Convert<Code<RequestIntent>>(zzze_);
            bool? zzzg_ = context.Operators.Equal(zzzf_, "order");
            bool? zzzh_ = context.Operators.And(zzzc_, zzzg_);

            return zzzh_;
        };
        IEnumerable<DeviceRequest> yzzw_ = context.Operators.Where<DeviceRequest>(DeviceRequest, yzzv_);

        return yzzw_;
    }


    [CqlExpressionDefinition("Completed or Ongoing Service Request")]
    public IEnumerable<ServiceRequest> Completed_or_Ongoing_Service_Request(CqlContext context, IEnumerable<ServiceRequest> ServiceRequest)
    {
        bool? zzzi_(ServiceRequest S)
        {
            Code<RequestStatus> zzzk_ = S?.StatusElement;
            RequestStatus? zzzl_ = zzzk_?.Value;
            Code<RequestStatus> zzzm_ = context.Operators.Convert<Code<RequestStatus>>(zzzl_);
            string zzzn_ = context.Operators.Convert<string>(zzzm_);
            string[] zzzo_ = [
                "active",
                "completed",
            ];
            bool? zzzp_ = context.Operators.In<string>(zzzn_, zzzo_ as IEnumerable<string>);
            Code<RequestIntent> zzzq_ = S?.IntentElement;
            RequestIntent? zzzr_ = zzzq_?.Value;
            Code<RequestIntent> zzzs_ = context.Operators.Convert<Code<RequestIntent>>(zzzr_);
            bool? zzzt_ = context.Operators.Equal(zzzs_, "order");
            bool? zzzu_ = context.Operators.And(zzzp_, zzzt_);

            return zzzu_;
        };
        IEnumerable<ServiceRequest> zzzj_ = context.Operators.Where<ServiceRequest>(ServiceRequest, zzzi_);

        return zzzj_;
    }


    [CqlExpressionDefinition("isDiagnosticStudyOrder")]
    public IEnumerable<ServiceRequest> isDiagnosticStudyOrder(CqlContext context, IEnumerable<ServiceRequest> ServiceRequest)
    {
        bool? zzzv_(ServiceRequest S)
        {
            Code<RequestStatus> zzzx_ = S?.StatusElement;
            RequestStatus? zzzy_ = zzzx_?.Value;
            Code<RequestStatus> zzzz_ = context.Operators.Convert<Code<RequestStatus>>(zzzy_);
            string azzza_ = context.Operators.Convert<string>(zzzz_);
            string[] azzzb_ = [
                "active",
                "completed",
            ];
            bool? azzzc_ = context.Operators.In<string>(azzza_, azzzb_ as IEnumerable<string>);
            Code<RequestIntent> azzzd_ = S?.IntentElement;
            RequestIntent? azzze_ = azzzd_?.Value;
            Code<RequestIntent> azzzf_ = context.Operators.Convert<Code<RequestIntent>>(azzze_);
            bool? azzzg_ = context.Operators.Equal(azzzf_, "order");
            bool? azzzh_ = context.Operators.And(azzzc_, azzzg_);

            return azzzh_;
        };
        IEnumerable<ServiceRequest> zzzw_ = context.Operators.Where<ServiceRequest>(ServiceRequest, zzzv_);

        return zzzw_;
    }


    [CqlExpressionDefinition("isInterventionOrder")]
    public IEnumerable<ServiceRequest> isInterventionOrder(CqlContext context, IEnumerable<ServiceRequest> ServiceRequest)
    {
        bool? azzzi_(ServiceRequest S)
        {
            Code<RequestStatus> azzzk_ = S?.StatusElement;
            RequestStatus? azzzl_ = azzzk_?.Value;
            Code<RequestStatus> azzzm_ = context.Operators.Convert<Code<RequestStatus>>(azzzl_);
            string azzzn_ = context.Operators.Convert<string>(azzzm_);
            string[] azzzo_ = [
                "active",
                "completed",
            ];
            bool? azzzp_ = context.Operators.In<string>(azzzn_, azzzo_ as IEnumerable<string>);
            Code<RequestIntent> azzzq_ = S?.IntentElement;
            RequestIntent? azzzr_ = azzzq_?.Value;
            Code<RequestIntent> azzzs_ = context.Operators.Convert<Code<RequestIntent>>(azzzr_);
            bool? azzzt_ = context.Operators.Equal(azzzs_, "order");
            bool? azzzu_ = context.Operators.And(azzzp_, azzzt_);

            return azzzu_;
        };
        IEnumerable<ServiceRequest> azzzj_ = context.Operators.Where<ServiceRequest>(ServiceRequest, azzzi_);

        return azzzj_;
    }


    [CqlExpressionDefinition("isLaboratoryTestOrder")]
    public IEnumerable<ServiceRequest> isLaboratoryTestOrder(CqlContext context, IEnumerable<ServiceRequest> ServiceRequest)
    {
        bool? azzzv_(ServiceRequest S)
        {
            Code<RequestStatus> azzzx_ = S?.StatusElement;
            RequestStatus? azzzy_ = azzzx_?.Value;
            Code<RequestStatus> azzzz_ = context.Operators.Convert<Code<RequestStatus>>(azzzy_);
            string bzzza_ = context.Operators.Convert<string>(azzzz_);
            string[] bzzzb_ = [
                "active",
                "completed",
            ];
            bool? bzzzc_ = context.Operators.In<string>(bzzza_, bzzzb_ as IEnumerable<string>);
            Code<RequestIntent> bzzzd_ = S?.IntentElement;
            RequestIntent? bzzze_ = bzzzd_?.Value;
            Code<RequestIntent> bzzzf_ = context.Operators.Convert<Code<RequestIntent>>(bzzze_);
            bool? bzzzg_ = context.Operators.Equal(bzzzf_, "order");
            bool? bzzzh_ = context.Operators.And(bzzzc_, bzzzg_);

            return bzzzh_;
        };
        IEnumerable<ServiceRequest> azzzw_ = context.Operators.Where<ServiceRequest>(ServiceRequest, azzzv_);

        return azzzw_;
    }


    [CqlExpressionDefinition("Final Observation")]
    public IEnumerable<Observation> Final_Observation(CqlContext context, IEnumerable<Observation> Obs)
    {
        bool? bzzzi_(Observation O)
        {
            Code<ObservationStatus> bzzzk_ = O?.StatusElement;
            ObservationStatus? bzzzl_ = bzzzk_?.Value;
            Code<ObservationStatus> bzzzm_ = context.Operators.Convert<Code<ObservationStatus>>(bzzzl_);
            string bzzzn_ = context.Operators.Convert<string>(bzzzm_);
            string[] bzzzo_ = [
                "final",
                "amended",
                "corrected",
            ];
            bool? bzzzp_ = context.Operators.In<string>(bzzzn_, bzzzo_ as IEnumerable<string>);

            return bzzzp_;
        };
        IEnumerable<Observation> bzzzj_ = context.Operators.Where<Observation>(Obs, bzzzi_);

        return bzzzj_;
    }


    [CqlExpressionDefinition("isDiagnosticStudyPerformed")]
    public IEnumerable<Observation> isDiagnosticStudyPerformed(CqlContext context, IEnumerable<Observation> Obs)
    {
        bool? bzzzq_(Observation O)
        {
            Code<ObservationStatus> bzzzs_ = O?.StatusElement;
            ObservationStatus? bzzzt_ = bzzzs_?.Value;
            Code<ObservationStatus> bzzzu_ = context.Operators.Convert<Code<ObservationStatus>>(bzzzt_);
            string bzzzv_ = context.Operators.Convert<string>(bzzzu_);
            string[] bzzzw_ = [
                "final",
                "amended",
                "corrected",
            ];
            bool? bzzzx_ = context.Operators.In<string>(bzzzv_, bzzzw_ as IEnumerable<string>);

            return bzzzx_;
        };
        IEnumerable<Observation> bzzzr_ = context.Operators.Where<Observation>(Obs, bzzzq_);

        return bzzzr_;
    }


    [CqlExpressionDefinition("Finished Encounter")]
    public IEnumerable<Encounter> Finished_Encounter(CqlContext context, IEnumerable<Encounter> Enc)
    {
        bool? bzzzy_(Encounter E)
        {
            Code<Encounter.EncounterStatus> czzza_ = E?.StatusElement;
            Encounter.EncounterStatus? czzzb_ = czzza_?.Value;
            Code<Encounter.EncounterStatus> czzzc_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(czzzb_);
            string czzzd_ = context.Operators.Convert<string>(czzzc_);
            string[] czzze_ = [
                "finished",
                "arrived",
                "triaged",
                "in-progress",
                "onleave",
            ];
            bool? czzzf_ = context.Operators.In<string>(czzzd_, czzze_ as IEnumerable<string>);

            return czzzf_;
        };
        IEnumerable<Encounter> bzzzz_ = context.Operators.Where<Encounter>(Enc, bzzzy_);

        return bzzzz_;
    }


    [CqlExpressionDefinition("isEncounterPerformed")]
    public IEnumerable<Encounter> isEncounterPerformed(CqlContext context, IEnumerable<Encounter> Enc)
    {
        bool? czzzg_(Encounter E)
        {
            Code<Encounter.EncounterStatus> czzzi_ = E?.StatusElement;
            Encounter.EncounterStatus? czzzj_ = czzzi_?.Value;
            Code<Encounter.EncounterStatus> czzzk_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(czzzj_);
            string czzzl_ = context.Operators.Convert<string>(czzzk_);
            string[] czzzm_ = [
                "finished",
                "arrived",
                "triaged",
                "in-progress",
                "onleave",
            ];
            bool? czzzn_ = context.Operators.In<string>(czzzl_, czzzm_ as IEnumerable<string>);

            return czzzn_;
        };
        IEnumerable<Encounter> czzzh_ = context.Operators.Where<Encounter>(Enc, czzzg_);

        return czzzh_;
    }


    [CqlExpressionDefinition("Completed Immunization")]
    public IEnumerable<Immunization> Completed_Immunization(CqlContext context, IEnumerable<Immunization> Immunization)
    {
        bool? czzzo_(Immunization I)
        {
            Code<Immunization.ImmunizationStatusCodes> czzzq_ = I?.StatusElement;
            Immunization.ImmunizationStatusCodes? czzzr_ = czzzq_?.Value;
            string czzzs_ = context.Operators.Convert<string>(czzzr_);
            bool? czzzt_ = context.Operators.Equivalent(czzzs_, "completed");

            return czzzt_;
        };
        IEnumerable<Immunization> czzzp_ = context.Operators.Where<Immunization>(Immunization, czzzo_);

        return czzzp_;
    }


    [CqlExpressionDefinition("isImmunizationAdministered")]
    public IEnumerable<Immunization> isImmunizationAdministered(CqlContext context, IEnumerable<Immunization> Immunization)
    {
        bool? czzzu_(Immunization I)
        {
            Code<Immunization.ImmunizationStatusCodes> czzzw_ = I?.StatusElement;
            Immunization.ImmunizationStatusCodes? czzzx_ = czzzw_?.Value;
            string czzzy_ = context.Operators.Convert<string>(czzzx_);
            bool? czzzz_ = context.Operators.Equivalent(czzzy_, "completed");

            return czzzz_;
        };
        IEnumerable<Immunization> czzzv_ = context.Operators.Where<Immunization>(Immunization, czzzu_);

        return czzzv_;
    }


    [CqlExpressionDefinition("Completed Procedure")]
    public IEnumerable<Procedure> Completed_Procedure(CqlContext context, IEnumerable<Procedure> Proc)
    {
        bool? dzzza_(Procedure P)
        {
            Code<EventStatus> dzzzc_ = P?.StatusElement;
            EventStatus? dzzzd_ = dzzzc_?.Value;
            string dzzze_ = context.Operators.Convert<string>(dzzzd_);
            bool? dzzzf_ = context.Operators.Equivalent(dzzze_, "completed");

            return dzzzf_;
        };
        IEnumerable<Procedure> dzzzb_ = context.Operators.Where<Procedure>(Proc, dzzza_);

        return dzzzb_;
    }


    [CqlExpressionDefinition("isInterventionPerformed")]
    public IEnumerable<Procedure> isInterventionPerformed(CqlContext context, IEnumerable<Procedure> Proc)
    {
        bool? dzzzg_(Procedure P)
        {
            Code<EventStatus> dzzzi_ = P?.StatusElement;
            EventStatus? dzzzj_ = dzzzi_?.Value;
            string dzzzk_ = context.Operators.Convert<string>(dzzzj_);
            bool? dzzzl_ = context.Operators.Equivalent(dzzzk_, "completed");

            return dzzzl_;
        };
        IEnumerable<Procedure> dzzzh_ = context.Operators.Where<Procedure>(Proc, dzzzg_);

        return dzzzh_;
    }


    [CqlExpressionDefinition("isProcedurePerformed")]
    public IEnumerable<Procedure> isProcedurePerformed(CqlContext context, IEnumerable<Procedure> Proc)
    {
        bool? dzzzm_(Procedure P)
        {
            Code<EventStatus> dzzzo_ = P?.StatusElement;
            EventStatus? dzzzp_ = dzzzo_?.Value;
            string dzzzq_ = context.Operators.Convert<string>(dzzzp_);
            bool? dzzzr_ = context.Operators.Equivalent(dzzzq_, "completed");

            return dzzzr_;
        };
        IEnumerable<Procedure> dzzzn_ = context.Operators.Where<Procedure>(Proc, dzzzm_);

        return dzzzn_;
    }


    [CqlExpressionDefinition("Final Lab Observation")]
    public IEnumerable<Observation> Final_Lab_Observation(CqlContext context, IEnumerable<Observation> Obs)
    {
        bool? dzzzs_(Observation O)
        {
            Code<ObservationStatus> dzzzu_ = O?.StatusElement;
            ObservationStatus? dzzzv_ = dzzzu_?.Value;
            Code<ObservationStatus> dzzzw_ = context.Operators.Convert<Code<ObservationStatus>>(dzzzv_);
            string dzzzx_ = context.Operators.Convert<string>(dzzzw_);
            string[] dzzzy_ = [
                "final",
                "amended",
                "corrected",
            ];
            bool? dzzzz_ = context.Operators.In<string>(dzzzx_, dzzzy_ as IEnumerable<string>);
            List<CodeableConcept> ezzza_ = O?.Category;
            CqlConcept ezzzb_(CodeableConcept @this)
            {
                CqlConcept ezzzh_ = FHIRHelpers_4_3_000.Instance.ToConcept(context, @this);

                return ezzzh_;
            };
            IEnumerable<CqlConcept> ezzzc_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)ezzza_, ezzzb_);
            bool? ezzzd_(CqlConcept ObservationCategory)
            {
                CqlCode ezzzi_ = this.laboratory(context);
                CqlConcept ezzzj_ = context.Operators.ConvertCodeToConcept(ezzzi_);
                bool? ezzzk_ = context.Operators.Equivalent(ObservationCategory, ezzzj_);

                return ezzzk_;
            };
            IEnumerable<CqlConcept> ezzze_ = context.Operators.Where<CqlConcept>(ezzzc_, ezzzd_);
            bool? ezzzf_ = context.Operators.Exists<CqlConcept>(ezzze_);
            bool? ezzzg_ = context.Operators.And(dzzzz_, ezzzf_);

            return ezzzg_;
        };
        IEnumerable<Observation> dzzzt_ = context.Operators.Where<Observation>(Obs, dzzzs_);

        return dzzzt_;
    }


    [CqlExpressionDefinition("isLaboratoryTestPerformed")]
    public IEnumerable<Observation> isLaboratoryTestPerformed(CqlContext context, IEnumerable<Observation> Obs)
    {
        bool? ezzzl_(Observation O)
        {
            Code<ObservationStatus> ezzzn_ = O?.StatusElement;
            ObservationStatus? ezzzo_ = ezzzn_?.Value;
            Code<ObservationStatus> ezzzp_ = context.Operators.Convert<Code<ObservationStatus>>(ezzzo_);
            string ezzzq_ = context.Operators.Convert<string>(ezzzp_);
            string[] ezzzr_ = [
                "final",
                "amended",
                "corrected",
            ];
            bool? ezzzs_ = context.Operators.In<string>(ezzzq_, ezzzr_ as IEnumerable<string>);
            List<CodeableConcept> ezzzt_ = O?.Category;
            CqlConcept ezzzu_(CodeableConcept @this)
            {
                CqlConcept fzzza_ = FHIRHelpers_4_3_000.Instance.ToConcept(context, @this);

                return fzzza_;
            };
            IEnumerable<CqlConcept> ezzzv_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)ezzzt_, ezzzu_);
            bool? ezzzw_(CqlConcept ObservationCategory)
            {
                CqlCode fzzzb_ = this.laboratory(context);
                CqlConcept fzzzc_ = context.Operators.ConvertCodeToConcept(fzzzb_);
                bool? fzzzd_ = context.Operators.Equivalent(ObservationCategory, fzzzc_);

                return fzzzd_;
            };
            IEnumerable<CqlConcept> ezzzx_ = context.Operators.Where<CqlConcept>(ezzzv_, ezzzw_);
            bool? ezzzy_ = context.Operators.Exists<CqlConcept>(ezzzx_);
            bool? ezzzz_ = context.Operators.And(ezzzs_, ezzzy_);

            return ezzzz_;
        };
        IEnumerable<Observation> ezzzm_ = context.Operators.Where<Observation>(Obs, ezzzl_);

        return ezzzm_;
    }


    [CqlExpressionDefinition("Active Medication")]
    public IEnumerable<MedicationRequest> Active_Medication(CqlContext context, IEnumerable<MedicationRequest> MedicationRequest)
    {
        bool? fzzze_(MedicationRequest M)
        {
            Code<MedicationRequest.MedicationrequestStatus> fzzzg_ = M?.StatusElement;
            MedicationRequest.MedicationrequestStatus? fzzzh_ = fzzzg_?.Value;
            string fzzzi_ = context.Operators.Convert<string>(fzzzh_);
            bool? fzzzj_ = context.Operators.Equal(fzzzi_, "active");
            Code<MedicationRequest.MedicationRequestIntent> fzzzk_ = M?.IntentElement;
            MedicationRequest.MedicationRequestIntent? fzzzl_ = fzzzk_?.Value;
            string fzzzm_ = context.Operators.Convert<string>(fzzzl_);
            bool? fzzzn_ = context.Operators.Equal(fzzzm_, "order");
            bool? fzzzo_ = context.Operators.And(fzzzj_, fzzzn_);

            return fzzzo_;
        };
        IEnumerable<MedicationRequest> fzzzf_ = context.Operators.Where<MedicationRequest>(MedicationRequest, fzzze_);

        return fzzzf_;
    }


    [CqlExpressionDefinition("isMedicationActive")]
    public IEnumerable<MedicationRequest> isMedicationActive(CqlContext context, IEnumerable<MedicationRequest> MedicationRequest)
    {
        bool? fzzzp_(MedicationRequest M)
        {
            Code<MedicationRequest.MedicationrequestStatus> fzzzr_ = M?.StatusElement;
            MedicationRequest.MedicationrequestStatus? fzzzs_ = fzzzr_?.Value;
            string fzzzt_ = context.Operators.Convert<string>(fzzzs_);
            bool? fzzzu_ = context.Operators.Equal(fzzzt_, "active");
            Code<MedicationRequest.MedicationRequestIntent> fzzzv_ = M?.IntentElement;
            MedicationRequest.MedicationRequestIntent? fzzzw_ = fzzzv_?.Value;
            string fzzzx_ = context.Operators.Convert<string>(fzzzw_);
            bool? fzzzy_ = context.Operators.Equal(fzzzx_, "order");
            bool? fzzzz_ = context.Operators.And(fzzzu_, fzzzy_);

            return fzzzz_;
        };
        IEnumerable<MedicationRequest> fzzzq_ = context.Operators.Where<MedicationRequest>(MedicationRequest, fzzzp_);

        return fzzzq_;
    }


    [CqlExpressionDefinition("Dispensed Medication")]
    public IEnumerable<MedicationDispense> Dispensed_Medication(CqlContext context, IEnumerable<MedicationDispense> Med)
    {
        bool? gzzza_(MedicationDispense M)
        {
            Code<MedicationDispense.MedicationDispenseStatusCodes> gzzzc_ = M?.StatusElement;
            MedicationDispense.MedicationDispenseStatusCodes? gzzzd_ = gzzzc_?.Value;
            Code<MedicationDispense.MedicationDispenseStatusCodes> gzzze_ = context.Operators.Convert<Code<MedicationDispense.MedicationDispenseStatusCodes>>(gzzzd_);
            string gzzzf_ = context.Operators.Convert<string>(gzzze_);
            string[] gzzzg_ = [
                "completed",
                "in-progress",
                "on-hold",
            ];
            bool? gzzzh_ = context.Operators.In<string>(gzzzf_, gzzzg_ as IEnumerable<string>);

            return gzzzh_;
        };
        IEnumerable<MedicationDispense> gzzzb_ = context.Operators.Where<MedicationDispense>(Med, gzzza_);

        return gzzzb_;
    }


    [CqlExpressionDefinition("isMedicationDispensed")]
    public IEnumerable<MedicationDispense> isMedicationDispensed(CqlContext context, IEnumerable<MedicationDispense> Med)
    {
        bool? gzzzi_(MedicationDispense M)
        {
            Code<MedicationDispense.MedicationDispenseStatusCodes> gzzzk_ = M?.StatusElement;
            MedicationDispense.MedicationDispenseStatusCodes? gzzzl_ = gzzzk_?.Value;
            Code<MedicationDispense.MedicationDispenseStatusCodes> gzzzm_ = context.Operators.Convert<Code<MedicationDispense.MedicationDispenseStatusCodes>>(gzzzl_);
            string gzzzn_ = context.Operators.Convert<string>(gzzzm_);
            string[] gzzzo_ = [
                "completed",
                "in-progress",
                "on-hold",
            ];
            bool? gzzzp_ = context.Operators.In<string>(gzzzn_, gzzzo_ as IEnumerable<string>);

            return gzzzp_;
        };
        IEnumerable<MedicationDispense> gzzzj_ = context.Operators.Where<MedicationDispense>(Med, gzzzi_);

        return gzzzj_;
    }


    [CqlExpressionDefinition("Active or Completed Medication Request")]
    public IEnumerable<MedicationRequest> Active_or_Completed_Medication_Request(CqlContext context, IEnumerable<MedicationRequest> MedicationRequest)
    {
        bool? gzzzq_(MedicationRequest M)
        {
            Code<MedicationRequest.MedicationrequestStatus> gzzzs_ = M?.StatusElement;
            MedicationRequest.MedicationrequestStatus? gzzzt_ = gzzzs_?.Value;
            string gzzzu_ = context.Operators.Convert<string>(gzzzt_);
            string[] gzzzv_ = [
                "active",
                "completed",
            ];
            bool? gzzzw_ = context.Operators.In<string>(gzzzu_, gzzzv_ as IEnumerable<string>);
            Code<MedicationRequest.MedicationRequestIntent> gzzzx_ = M?.IntentElement;
            MedicationRequest.MedicationRequestIntent? gzzzy_ = gzzzx_?.Value;
            string gzzzz_ = context.Operators.Convert<string>(gzzzy_);
            bool? hzzza_ = context.Operators.Equal(gzzzz_, "order");
            bool? hzzzb_ = context.Operators.And(gzzzw_, hzzza_);

            return hzzzb_;
        };
        IEnumerable<MedicationRequest> gzzzr_ = context.Operators.Where<MedicationRequest>(MedicationRequest, gzzzq_);

        return gzzzr_;
    }


    [CqlExpressionDefinition("isMedicationOrder")]
    public IEnumerable<MedicationRequest> isMedicationOrder(CqlContext context, IEnumerable<MedicationRequest> MedicationRequest)
    {
        bool? hzzzc_(MedicationRequest M)
        {
            Code<MedicationRequest.MedicationrequestStatus> hzzze_ = M?.StatusElement;
            MedicationRequest.MedicationrequestStatus? hzzzf_ = hzzze_?.Value;
            string hzzzg_ = context.Operators.Convert<string>(hzzzf_);
            string[] hzzzh_ = [
                "active",
                "completed",
            ];
            bool? hzzzi_ = context.Operators.In<string>(hzzzg_, hzzzh_ as IEnumerable<string>);
            Code<MedicationRequest.MedicationRequestIntent> hzzzj_ = M?.IntentElement;
            MedicationRequest.MedicationRequestIntent? hzzzk_ = hzzzj_?.Value;
            string hzzzl_ = context.Operators.Convert<string>(hzzzk_);
            bool? hzzzm_ = context.Operators.Equal(hzzzl_, "order");
            bool? hzzzn_ = context.Operators.And(hzzzi_, hzzzm_);

            return hzzzn_;
        };
        IEnumerable<MedicationRequest> hzzzd_ = context.Operators.Where<MedicationRequest>(MedicationRequest, hzzzc_);

        return hzzzd_;
    }


    [CqlExpressionDefinition("Final Exam Observation")]
    public IEnumerable<Observation> Final_Exam_Observation(CqlContext context, IEnumerable<Observation> Obs)
    {
        bool? hzzzo_(Observation O)
        {
            Code<ObservationStatus> hzzzq_ = O?.StatusElement;
            ObservationStatus? hzzzr_ = hzzzq_?.Value;
            Code<ObservationStatus> hzzzs_ = context.Operators.Convert<Code<ObservationStatus>>(hzzzr_);
            string hzzzt_ = context.Operators.Convert<string>(hzzzs_);
            string[] hzzzu_ = [
                "final",
                "amended",
                "corrected",
            ];
            bool? hzzzv_ = context.Operators.In<string>(hzzzt_, hzzzu_ as IEnumerable<string>);
            List<CodeableConcept> hzzzw_ = O?.Category;
            CqlConcept hzzzx_(CodeableConcept @this)
            {
                CqlConcept izzzd_ = FHIRHelpers_4_3_000.Instance.ToConcept(context, @this);

                return izzzd_;
            };
            IEnumerable<CqlConcept> hzzzy_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)hzzzw_, hzzzx_);
            bool? hzzzz_(CqlConcept ObservationCategory)
            {
                CqlCode izzze_ = this.exam(context);
                CqlConcept izzzf_ = context.Operators.ConvertCodeToConcept(izzze_);
                bool? izzzg_ = context.Operators.Equivalent(ObservationCategory, izzzf_);

                return izzzg_;
            };
            IEnumerable<CqlConcept> izzza_ = context.Operators.Where<CqlConcept>(hzzzy_, hzzzz_);
            bool? izzzb_ = context.Operators.Exists<CqlConcept>(izzza_);
            bool? izzzc_ = context.Operators.And(hzzzv_, izzzb_);

            return izzzc_;
        };
        IEnumerable<Observation> hzzzp_ = context.Operators.Where<Observation>(Obs, hzzzo_);

        return hzzzp_;
    }


    [CqlExpressionDefinition("isPhysicalExamPerformed")]
    public IEnumerable<Observation> isPhysicalExamPerformed(CqlContext context, IEnumerable<Observation> Obs)
    {
        bool? izzzh_(Observation O)
        {
            Code<ObservationStatus> izzzj_ = O?.StatusElement;
            ObservationStatus? izzzk_ = izzzj_?.Value;
            Code<ObservationStatus> izzzl_ = context.Operators.Convert<Code<ObservationStatus>>(izzzk_);
            string izzzm_ = context.Operators.Convert<string>(izzzl_);
            string[] izzzn_ = [
                "final",
                "amended",
                "corrected",
            ];
            bool? izzzo_ = context.Operators.In<string>(izzzm_, izzzn_ as IEnumerable<string>);
            List<CodeableConcept> izzzp_ = O?.Category;
            CqlConcept izzzq_(CodeableConcept @this)
            {
                CqlConcept izzzw_ = FHIRHelpers_4_3_000.Instance.ToConcept(context, @this);

                return izzzw_;
            };
            IEnumerable<CqlConcept> izzzr_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)izzzp_, izzzq_);
            bool? izzzs_(CqlConcept ObservationCategory)
            {
                CqlCode izzzx_ = this.exam(context);
                CqlConcept izzzy_ = context.Operators.ConvertCodeToConcept(izzzx_);
                bool? izzzz_ = context.Operators.Equivalent(ObservationCategory, izzzy_);

                return izzzz_;
            };
            IEnumerable<CqlConcept> izzzt_ = context.Operators.Where<CqlConcept>(izzzr_, izzzs_);
            bool? izzzu_ = context.Operators.Exists<CqlConcept>(izzzt_);
            bool? izzzv_ = context.Operators.And(izzzo_, izzzu_);

            return izzzv_;
        };
        IEnumerable<Observation> izzzi_ = context.Operators.Where<Observation>(Obs, izzzh_);

        return izzzi_;
    }


    [CqlExpressionDefinition("BloodPressure")]
    public IEnumerable<Observation> BloodPressure(CqlContext context, IEnumerable<Observation> Obs)
    {
        bool? jzzza_(Observation O)
        {
            Code<ObservationStatus> jzzzc_ = O?.StatusElement;
            ObservationStatus? jzzzd_ = jzzzc_?.Value;
            string jzzze_ = context.Operators.Convert<string>(jzzzd_);
            string[] jzzzf_ = [
                "final",
                "amended",
                "corrected",
            ];
            bool? jzzzg_ = context.Operators.In<string>(jzzze_, jzzzf_ as IEnumerable<string>);

            return jzzzg_;
        };
        IEnumerable<Observation> jzzzb_ = context.Operators.Where<Observation>(Obs, jzzza_);

        return jzzzb_;
    }


    [CqlExpressionDefinition("BodyHeight")]
    public IEnumerable<Observation> BodyHeight(CqlContext context, IEnumerable<Observation> Obs)
    {
        bool? jzzzh_(Observation O)
        {
            Code<ObservationStatus> jzzzj_ = O?.StatusElement;
            ObservationStatus? jzzzk_ = jzzzj_?.Value;
            string jzzzl_ = context.Operators.Convert<string>(jzzzk_);
            string[] jzzzm_ = [
                "final",
                "amended",
                "corrected",
            ];
            bool? jzzzn_ = context.Operators.In<string>(jzzzl_, jzzzm_ as IEnumerable<string>);

            return jzzzn_;
        };
        IEnumerable<Observation> jzzzi_ = context.Operators.Where<Observation>(Obs, jzzzh_);

        return jzzzi_;
    }


    [CqlExpressionDefinition("BodyWeight")]
    public IEnumerable<Observation> BodyWeight(CqlContext context, IEnumerable<Observation> Obs)
    {
        bool? jzzzo_(Observation O)
        {
            Code<ObservationStatus> jzzzq_ = O?.StatusElement;
            ObservationStatus? jzzzr_ = jzzzq_?.Value;
            string jzzzs_ = context.Operators.Convert<string>(jzzzr_);
            string[] jzzzt_ = [
                "final",
                "amended",
                "corrected",
            ];
            bool? jzzzu_ = context.Operators.In<string>(jzzzs_, jzzzt_ as IEnumerable<string>);

            return jzzzu_;
        };
        IEnumerable<Observation> jzzzp_ = context.Operators.Where<Observation>(Obs, jzzzo_);

        return jzzzp_;
    }


    [CqlExpressionDefinition("BMI")]
    public IEnumerable<Observation> BMI(CqlContext context, IEnumerable<Observation> Obs)
    {
        bool? jzzzv_(Observation O)
        {
            Code<ObservationStatus> jzzzx_ = O?.StatusElement;
            ObservationStatus? jzzzy_ = jzzzx_?.Value;
            string jzzzz_ = context.Operators.Convert<string>(jzzzy_);
            string[] kzzza_ = [
                "final",
                "amended",
                "corrected",
            ];
            bool? kzzzb_ = context.Operators.In<string>(jzzzz_, kzzza_ as IEnumerable<string>);

            return kzzzb_;
        };
        IEnumerable<Observation> jzzzw_ = context.Operators.Where<Observation>(Obs, jzzzv_);

        return jzzzw_;
    }


    [CqlExpressionDefinition("isObservationBP")]
    public IEnumerable<Observation> isObservationBP(CqlContext context, IEnumerable<Observation> Obs)
    {
        bool? kzzzc_(Observation O)
        {
            Code<ObservationStatus> kzzze_ = O?.StatusElement;
            ObservationStatus? kzzzf_ = kzzze_?.Value;
            string kzzzg_ = context.Operators.Convert<string>(kzzzf_);
            string[] kzzzh_ = [
                "final",
                "amended",
                "corrected",
            ];
            bool? kzzzi_ = context.Operators.In<string>(kzzzg_, kzzzh_ as IEnumerable<string>);

            return kzzzi_;
        };
        IEnumerable<Observation> kzzzd_ = context.Operators.Where<Observation>(Obs, kzzzc_);

        return kzzzd_;
    }


    [CqlExpressionDefinition("isObservationBodyHeight")]
    public IEnumerable<Observation> isObservationBodyHeight(CqlContext context, IEnumerable<Observation> Obs)
    {
        bool? kzzzj_(Observation O)
        {
            Code<ObservationStatus> kzzzl_ = O?.StatusElement;
            ObservationStatus? kzzzm_ = kzzzl_?.Value;
            string kzzzn_ = context.Operators.Convert<string>(kzzzm_);
            string[] kzzzo_ = [
                "final",
                "amended",
                "corrected",
            ];
            bool? kzzzp_ = context.Operators.In<string>(kzzzn_, kzzzo_ as IEnumerable<string>);

            return kzzzp_;
        };
        IEnumerable<Observation> kzzzk_ = context.Operators.Where<Observation>(Obs, kzzzj_);

        return kzzzk_;
    }


    [CqlExpressionDefinition("isObservationBodyWeight")]
    public IEnumerable<Observation> isObservationBodyWeight(CqlContext context, IEnumerable<Observation> Obs)
    {
        bool? kzzzq_(Observation O)
        {
            Code<ObservationStatus> kzzzs_ = O?.StatusElement;
            ObservationStatus? kzzzt_ = kzzzs_?.Value;
            string kzzzu_ = context.Operators.Convert<string>(kzzzt_);
            string[] kzzzv_ = [
                "final",
                "amended",
                "corrected",
            ];
            bool? kzzzw_ = context.Operators.In<string>(kzzzu_, kzzzv_ as IEnumerable<string>);

            return kzzzw_;
        };
        IEnumerable<Observation> kzzzr_ = context.Operators.Where<Observation>(Obs, kzzzq_);

        return kzzzr_;
    }


    [CqlExpressionDefinition("isObservationBMI")]
    public IEnumerable<Observation> isObservationBMI(CqlContext context, IEnumerable<Observation> Obs)
    {
        bool? kzzzx_(Observation O)
        {
            Code<ObservationStatus> kzzzz_ = O?.StatusElement;
            ObservationStatus? lzzza_ = kzzzz_?.Value;
            string lzzzb_ = context.Operators.Convert<string>(lzzza_);
            string[] lzzzc_ = [
                "final",
                "amended",
                "corrected",
            ];
            bool? lzzzd_ = context.Operators.In<string>(lzzzb_, lzzzc_ as IEnumerable<string>);

            return lzzzd_;
        };
        IEnumerable<Observation> kzzzy_ = context.Operators.Where<Observation>(Obs, kzzzx_);

        return kzzzy_;
    }


    [CqlExpressionDefinition("Initial or Final Observation")]
    public IEnumerable<Observation> Initial_or_Final_Observation(CqlContext context, IEnumerable<Observation> Obs)
    {
        bool? lzzze_(Observation O)
        {
            Code<ObservationStatus> lzzzg_ = O?.StatusElement;
            ObservationStatus? lzzzh_ = lzzzg_?.Value;
            Code<ObservationStatus> lzzzi_ = context.Operators.Convert<Code<ObservationStatus>>(lzzzh_);
            string lzzzj_ = context.Operators.Convert<string>(lzzzi_);
            string[] lzzzk_ = [
                "preliminary",
                "final",
                "amended",
                "corrected",
            ];
            bool? lzzzl_ = context.Operators.In<string>(lzzzj_, lzzzk_ as IEnumerable<string>);

            return lzzzl_;
        };
        IEnumerable<Observation> lzzzf_ = context.Operators.Where<Observation>(Obs, lzzze_);

        return lzzzf_;
    }


    [CqlExpressionDefinition("isSymptom")]
    public IEnumerable<Observation> isSymptom(CqlContext context, IEnumerable<Observation> Obs)
    {
        bool? lzzzm_(Observation O)
        {
            Code<ObservationStatus> lzzzo_ = O?.StatusElement;
            ObservationStatus? lzzzp_ = lzzzo_?.Value;
            Code<ObservationStatus> lzzzq_ = context.Operators.Convert<Code<ObservationStatus>>(lzzzp_);
            string lzzzr_ = context.Operators.Convert<string>(lzzzq_);
            string[] lzzzs_ = [
                "preliminary",
                "final",
                "amended",
                "corrected",
            ];
            bool? lzzzt_ = context.Operators.In<string>(lzzzr_, lzzzs_ as IEnumerable<string>);

            return lzzzt_;
        };
        IEnumerable<Observation> lzzzn_ = context.Operators.Where<Observation>(Obs, lzzzm_);

        return lzzzn_;
    }


    #endregion Expressions

}
