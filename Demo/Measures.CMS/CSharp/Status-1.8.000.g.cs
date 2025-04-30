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
        IEnumerable<Patient> qzzr_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-patient"));
        Patient qzzs_ = context.Operators.SingletonFrom<Patient>(qzzr_);

        return qzzs_;
    }


    [CqlExpressionDefinition("isAssessmentPerformed")]
    public IEnumerable<Observation> isAssessmentPerformed(CqlContext context, IEnumerable<Observation> Obs)
    {
        bool? qzzt_(Observation O)
        {
            Code<ObservationStatus> qzzv_ = O?.StatusElement;
            ObservationStatus? qzzw_ = qzzv_?.Value;
            Code<ObservationStatus> qzzx_ = context.Operators.Convert<Code<ObservationStatus>>(qzzw_);
            string qzzy_ = context.Operators.Convert<string>(qzzx_);
            string[] qzzz_ = [
                "final",
                "amended",
                "corrected",
            ];
            bool? rzza_ = context.Operators.In<string>(qzzy_, qzzz_ as IEnumerable<string>);
            List<CodeableConcept> rzzb_ = O?.Category;
            CqlConcept rzzc_(CodeableConcept @this)
            {
                CqlConcept rzzi_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);

                return rzzi_;
            };
            IEnumerable<CqlConcept> rzzd_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)rzzb_, rzzc_);
            bool? rzze_(CqlConcept ObservationCategory)
            {
                CqlCode rzzj_ = this.survey(context);
                CqlConcept rzzk_ = context.Operators.ConvertCodeToConcept(rzzj_);
                bool? rzzl_ = context.Operators.Equivalent(ObservationCategory, rzzk_);

                return rzzl_;
            };
            IEnumerable<CqlConcept> rzzf_ = context.Operators.Where<CqlConcept>(rzzd_, rzze_);
            bool? rzzg_ = context.Operators.Exists<CqlConcept>(rzzf_);
            bool? rzzh_ = context.Operators.And(rzza_, rzzg_);

            return rzzh_;
        };
        IEnumerable<Observation> qzzu_ = context.Operators.Where<Observation>(Obs, qzzt_);

        return qzzu_;
    }


    [CqlExpressionDefinition("isDeviceOrder")]
    public IEnumerable<DeviceRequest> isDeviceOrder(CqlContext context, IEnumerable<DeviceRequest> DeviceRequest)
    {
        bool? rzzm_(DeviceRequest D)
        {
            Code<RequestStatus> rzzo_ = D?.StatusElement;
            RequestStatus? rzzp_ = rzzo_?.Value;
            Code<RequestStatus> rzzq_ = context.Operators.Convert<Code<RequestStatus>>(rzzp_);
            string rzzr_ = context.Operators.Convert<string>(rzzq_);
            string[] rzzs_ = [
                "active",
                "completed",
            ];
            bool? rzzt_ = context.Operators.In<string>(rzzr_, rzzs_ as IEnumerable<string>);
            Code<RequestIntent> rzzu_ = D?.IntentElement;
            RequestIntent? rzzv_ = rzzu_?.Value;
            Code<RequestIntent> rzzw_ = context.Operators.Convert<Code<RequestIntent>>(rzzv_);
            bool? rzzx_ = context.Operators.Equal(rzzw_, "order");
            bool? rzzy_ = context.Operators.And(rzzt_, rzzx_);

            return rzzy_;
        };
        IEnumerable<DeviceRequest> rzzn_ = context.Operators.Where<DeviceRequest>(DeviceRequest, rzzm_);

        return rzzn_;
    }


    [CqlExpressionDefinition("isDiagnosticStudyOrder")]
    public IEnumerable<ServiceRequest> isDiagnosticStudyOrder(CqlContext context, IEnumerable<ServiceRequest> ServiceRequest)
    {
        bool? rzzz_(ServiceRequest S)
        {
            Code<RequestStatus> szzb_ = S?.StatusElement;
            RequestStatus? szzc_ = szzb_?.Value;
            Code<RequestStatus> szzd_ = context.Operators.Convert<Code<RequestStatus>>(szzc_);
            string szze_ = context.Operators.Convert<string>(szzd_);
            string[] szzf_ = [
                "active",
                "completed",
            ];
            bool? szzg_ = context.Operators.In<string>(szze_, szzf_ as IEnumerable<string>);
            Code<RequestIntent> szzh_ = S?.IntentElement;
            RequestIntent? szzi_ = szzh_?.Value;
            Code<RequestIntent> szzj_ = context.Operators.Convert<Code<RequestIntent>>(szzi_);
            bool? szzk_ = context.Operators.Equal(szzj_, "order");
            bool? szzl_ = context.Operators.And(szzg_, szzk_);

            return szzl_;
        };
        IEnumerable<ServiceRequest> szza_ = context.Operators.Where<ServiceRequest>(ServiceRequest, rzzz_);

        return szza_;
    }


    [CqlExpressionDefinition("isInterventionOrder")]
    public IEnumerable<ServiceRequest> isInterventionOrder(CqlContext context, IEnumerable<ServiceRequest> ServiceRequest)
    {
        bool? szzm_(ServiceRequest S)
        {
            Code<RequestStatus> szzo_ = S?.StatusElement;
            RequestStatus? szzp_ = szzo_?.Value;
            Code<RequestStatus> szzq_ = context.Operators.Convert<Code<RequestStatus>>(szzp_);
            string szzr_ = context.Operators.Convert<string>(szzq_);
            string[] szzs_ = [
                "active",
                "completed",
            ];
            bool? szzt_ = context.Operators.In<string>(szzr_, szzs_ as IEnumerable<string>);
            Code<RequestIntent> szzu_ = S?.IntentElement;
            RequestIntent? szzv_ = szzu_?.Value;
            Code<RequestIntent> szzw_ = context.Operators.Convert<Code<RequestIntent>>(szzv_);
            bool? szzx_ = context.Operators.Equal(szzw_, "order");
            bool? szzy_ = context.Operators.And(szzt_, szzx_);

            return szzy_;
        };
        IEnumerable<ServiceRequest> szzn_ = context.Operators.Where<ServiceRequest>(ServiceRequest, szzm_);

        return szzn_;
    }


    [CqlExpressionDefinition("isLaboratoryTestOrder")]
    public IEnumerable<ServiceRequest> isLaboratoryTestOrder(CqlContext context, IEnumerable<ServiceRequest> ServiceRequest)
    {
        bool? szzz_(ServiceRequest S)
        {
            Code<RequestStatus> tzzb_ = S?.StatusElement;
            RequestStatus? tzzc_ = tzzb_?.Value;
            Code<RequestStatus> tzzd_ = context.Operators.Convert<Code<RequestStatus>>(tzzc_);
            string tzze_ = context.Operators.Convert<string>(tzzd_);
            string[] tzzf_ = [
                "active",
                "completed",
            ];
            bool? tzzg_ = context.Operators.In<string>(tzze_, tzzf_ as IEnumerable<string>);
            Code<RequestIntent> tzzh_ = S?.IntentElement;
            RequestIntent? tzzi_ = tzzh_?.Value;
            Code<RequestIntent> tzzj_ = context.Operators.Convert<Code<RequestIntent>>(tzzi_);
            bool? tzzk_ = context.Operators.Equal(tzzj_, "order");
            bool? tzzl_ = context.Operators.And(tzzg_, tzzk_);

            return tzzl_;
        };
        IEnumerable<ServiceRequest> tzza_ = context.Operators.Where<ServiceRequest>(ServiceRequest, szzz_);

        return tzza_;
    }


    [CqlExpressionDefinition("isDiagnosticStudyPerformed")]
    public IEnumerable<Observation> isDiagnosticStudyPerformed(CqlContext context, IEnumerable<Observation> Obs)
    {
        bool? tzzm_(Observation O)
        {
            Code<ObservationStatus> tzzo_ = O?.StatusElement;
            ObservationStatus? tzzp_ = tzzo_?.Value;
            Code<ObservationStatus> tzzq_ = context.Operators.Convert<Code<ObservationStatus>>(tzzp_);
            string tzzr_ = context.Operators.Convert<string>(tzzq_);
            string[] tzzs_ = [
                "final",
                "amended",
                "corrected",
            ];
            bool? tzzt_ = context.Operators.In<string>(tzzr_, tzzs_ as IEnumerable<string>);

            return tzzt_;
        };
        IEnumerable<Observation> tzzn_ = context.Operators.Where<Observation>(Obs, tzzm_);

        return tzzn_;
    }


    [CqlExpressionDefinition("isEncounterPerformed")]
    public IEnumerable<Encounter> isEncounterPerformed(CqlContext context, IEnumerable<Encounter> Enc)
    {
        bool? tzzu_(Encounter E)
        {
            Code<Encounter.EncounterStatus> tzzw_ = E?.StatusElement;
            Encounter.EncounterStatus? tzzx_ = tzzw_?.Value;
            Code<Encounter.EncounterStatus> tzzy_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(tzzx_);
            string tzzz_ = context.Operators.Convert<string>(tzzy_);
            string[] uzza_ = [
                "finished",
                "arrived",
                "triaged",
                "in-progress",
                "onleave",
            ];
            bool? uzzb_ = context.Operators.In<string>(tzzz_, uzza_ as IEnumerable<string>);

            return uzzb_;
        };
        IEnumerable<Encounter> tzzv_ = context.Operators.Where<Encounter>(Enc, tzzu_);

        return tzzv_;
    }


    [CqlExpressionDefinition("isImmunizationAdministered")]
    public IEnumerable<Immunization> isImmunizationAdministered(CqlContext context, IEnumerable<Immunization> Immunization)
    {
        bool? uzzc_(Immunization I)
        {
            Code<Immunization.ImmunizationStatusCodes> uzze_ = I?.StatusElement;
            Immunization.ImmunizationStatusCodes? uzzf_ = uzze_?.Value;
            string uzzg_ = context.Operators.Convert<string>(uzzf_);
            bool? uzzh_ = context.Operators.Equivalent(uzzg_, "completed");

            return uzzh_;
        };
        IEnumerable<Immunization> uzzd_ = context.Operators.Where<Immunization>(Immunization, uzzc_);

        return uzzd_;
    }


    [CqlExpressionDefinition("isInterventionPerformed")]
    public IEnumerable<Procedure> isInterventionPerformed(CqlContext context, IEnumerable<Procedure> Proc)
    {
        bool? uzzi_(Procedure P)
        {
            Code<EventStatus> uzzk_ = P?.StatusElement;
            EventStatus? uzzl_ = uzzk_?.Value;
            string uzzm_ = context.Operators.Convert<string>(uzzl_);
            bool? uzzn_ = context.Operators.Equivalent(uzzm_, "completed");

            return uzzn_;
        };
        IEnumerable<Procedure> uzzj_ = context.Operators.Where<Procedure>(Proc, uzzi_);

        return uzzj_;
    }


    [CqlExpressionDefinition("isProcedurePerformed")]
    public IEnumerable<Procedure> isProcedurePerformed(CqlContext context, IEnumerable<Procedure> Proc)
    {
        bool? uzzo_(Procedure P)
        {
            Code<EventStatus> uzzq_ = P?.StatusElement;
            EventStatus? uzzr_ = uzzq_?.Value;
            string uzzs_ = context.Operators.Convert<string>(uzzr_);
            bool? uzzt_ = context.Operators.Equivalent(uzzs_, "completed");

            return uzzt_;
        };
        IEnumerable<Procedure> uzzp_ = context.Operators.Where<Procedure>(Proc, uzzo_);

        return uzzp_;
    }


    [CqlExpressionDefinition("isLaboratoryTestPerformed")]
    public IEnumerable<Observation> isLaboratoryTestPerformed(CqlContext context, IEnumerable<Observation> Obs)
    {
        bool? uzzu_(Observation O)
        {
            Code<ObservationStatus> uzzw_ = O?.StatusElement;
            ObservationStatus? uzzx_ = uzzw_?.Value;
            Code<ObservationStatus> uzzy_ = context.Operators.Convert<Code<ObservationStatus>>(uzzx_);
            string uzzz_ = context.Operators.Convert<string>(uzzy_);
            string[] vzza_ = [
                "final",
                "amended",
                "corrected",
            ];
            bool? vzzb_ = context.Operators.In<string>(uzzz_, vzza_ as IEnumerable<string>);
            List<CodeableConcept> vzzc_ = O?.Category;
            CqlConcept vzzd_(CodeableConcept @this)
            {
                CqlConcept vzzj_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);

                return vzzj_;
            };
            IEnumerable<CqlConcept> vzze_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)vzzc_, vzzd_);
            bool? vzzf_(CqlConcept ObservationCategory)
            {
                CqlCode vzzk_ = this.laboratory(context);
                CqlConcept vzzl_ = context.Operators.ConvertCodeToConcept(vzzk_);
                bool? vzzm_ = context.Operators.Equivalent(ObservationCategory, vzzl_);

                return vzzm_;
            };
            IEnumerable<CqlConcept> vzzg_ = context.Operators.Where<CqlConcept>(vzze_, vzzf_);
            bool? vzzh_ = context.Operators.Exists<CqlConcept>(vzzg_);
            bool? vzzi_ = context.Operators.And(vzzb_, vzzh_);

            return vzzi_;
        };
        IEnumerable<Observation> uzzv_ = context.Operators.Where<Observation>(Obs, uzzu_);

        return uzzv_;
    }


    [CqlExpressionDefinition("isMedicationActive")]
    public IEnumerable<MedicationRequest> isMedicationActive(CqlContext context, IEnumerable<MedicationRequest> MedicationRequest)
    {
        bool? vzzn_(MedicationRequest M)
        {
            Code<MedicationRequest.MedicationrequestStatus> vzzp_ = M?.StatusElement;
            MedicationRequest.MedicationrequestStatus? vzzq_ = vzzp_?.Value;
            string vzzr_ = context.Operators.Convert<string>(vzzq_);
            bool? vzzs_ = context.Operators.Equal(vzzr_, "active");
            Code<MedicationRequest.MedicationRequestIntent> vzzt_ = M?.IntentElement;
            MedicationRequest.MedicationRequestIntent? vzzu_ = vzzt_?.Value;
            string vzzv_ = context.Operators.Convert<string>(vzzu_);
            bool? vzzw_ = context.Operators.Equal(vzzv_, "order");
            bool? vzzx_ = context.Operators.And(vzzs_, vzzw_);

            return vzzx_;
        };
        IEnumerable<MedicationRequest> vzzo_ = context.Operators.Where<MedicationRequest>(MedicationRequest, vzzn_);

        return vzzo_;
    }


    [CqlExpressionDefinition("isMedicationDispensed")]
    public IEnumerable<MedicationDispense> isMedicationDispensed(CqlContext context, IEnumerable<MedicationDispense> Med)
    {
        bool? vzzy_(MedicationDispense M)
        {
            Code<MedicationDispense.MedicationDispenseStatusCodes> wzza_ = M?.StatusElement;
            MedicationDispense.MedicationDispenseStatusCodes? wzzb_ = wzza_?.Value;
            Code<MedicationDispense.MedicationDispenseStatusCodes> wzzc_ = context.Operators.Convert<Code<MedicationDispense.MedicationDispenseStatusCodes>>(wzzb_);
            string wzzd_ = context.Operators.Convert<string>(wzzc_);
            string[] wzze_ = [
                "completed",
                "in-progress",
                "on-hold",
            ];
            bool? wzzf_ = context.Operators.In<string>(wzzd_, wzze_ as IEnumerable<string>);

            return wzzf_;
        };
        IEnumerable<MedicationDispense> vzzz_ = context.Operators.Where<MedicationDispense>(Med, vzzy_);

        return vzzz_;
    }


    [CqlExpressionDefinition("isMedicationOrder")]
    public IEnumerable<MedicationRequest> isMedicationOrder(CqlContext context, IEnumerable<MedicationRequest> MedicationRequest)
    {
        bool? wzzg_(MedicationRequest M)
        {
            Code<MedicationRequest.MedicationrequestStatus> wzzi_ = M?.StatusElement;
            MedicationRequest.MedicationrequestStatus? wzzj_ = wzzi_?.Value;
            string wzzk_ = context.Operators.Convert<string>(wzzj_);
            string[] wzzl_ = [
                "active",
                "completed",
            ];
            bool? wzzm_ = context.Operators.In<string>(wzzk_, wzzl_ as IEnumerable<string>);
            Code<MedicationRequest.MedicationRequestIntent> wzzn_ = M?.IntentElement;
            MedicationRequest.MedicationRequestIntent? wzzo_ = wzzn_?.Value;
            string wzzp_ = context.Operators.Convert<string>(wzzo_);
            bool? wzzq_ = context.Operators.Equal(wzzp_, "order");
            bool? wzzr_ = context.Operators.And(wzzm_, wzzq_);

            return wzzr_;
        };
        IEnumerable<MedicationRequest> wzzh_ = context.Operators.Where<MedicationRequest>(MedicationRequest, wzzg_);

        return wzzh_;
    }


    [CqlExpressionDefinition("isPhysicalExamPerformed")]
    public IEnumerable<Observation> isPhysicalExamPerformed(CqlContext context, IEnumerable<Observation> Obs)
    {
        bool? wzzs_(Observation O)
        {
            Code<ObservationStatus> wzzu_ = O?.StatusElement;
            ObservationStatus? wzzv_ = wzzu_?.Value;
            Code<ObservationStatus> wzzw_ = context.Operators.Convert<Code<ObservationStatus>>(wzzv_);
            string wzzx_ = context.Operators.Convert<string>(wzzw_);
            string[] wzzy_ = [
                "final",
                "amended",
                "corrected",
            ];
            bool? wzzz_ = context.Operators.In<string>(wzzx_, wzzy_ as IEnumerable<string>);
            List<CodeableConcept> xzza_ = O?.Category;
            CqlConcept xzzb_(CodeableConcept @this)
            {
                CqlConcept xzzh_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);

                return xzzh_;
            };
            IEnumerable<CqlConcept> xzzc_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)xzza_, xzzb_);
            bool? xzzd_(CqlConcept ObservationCategory)
            {
                CqlCode xzzi_ = this.exam(context);
                CqlConcept xzzj_ = context.Operators.ConvertCodeToConcept(xzzi_);
                bool? xzzk_ = context.Operators.Equivalent(ObservationCategory, xzzj_);

                return xzzk_;
            };
            IEnumerable<CqlConcept> xzze_ = context.Operators.Where<CqlConcept>(xzzc_, xzzd_);
            bool? xzzf_ = context.Operators.Exists<CqlConcept>(xzze_);
            bool? xzzg_ = context.Operators.And(wzzz_, xzzf_);

            return xzzg_;
        };
        IEnumerable<Observation> wzzt_ = context.Operators.Where<Observation>(Obs, wzzs_);

        return wzzt_;
    }


    [CqlExpressionDefinition("isObservationBP")]
    public IEnumerable<Observation> isObservationBP(CqlContext context, IEnumerable<Observation> Obs)
    {
        bool? xzzl_(Observation O)
        {
            Code<ObservationStatus> xzzn_ = O?.StatusElement;
            ObservationStatus? xzzo_ = xzzn_?.Value;
            string xzzp_ = context.Operators.Convert<string>(xzzo_);
            string[] xzzq_ = [
                "final",
                "amended",
                "corrected",
            ];
            bool? xzzr_ = context.Operators.In<string>(xzzp_, xzzq_ as IEnumerable<string>);

            return xzzr_;
        };
        IEnumerable<Observation> xzzm_ = context.Operators.Where<Observation>(Obs, xzzl_);

        return xzzm_;
    }


    [CqlExpressionDefinition("isObservationBodyHeight")]
    public IEnumerable<Observation> isObservationBodyHeight(CqlContext context, IEnumerable<Observation> Obs)
    {
        bool? xzzs_(Observation O)
        {
            Code<ObservationStatus> xzzu_ = O?.StatusElement;
            ObservationStatus? xzzv_ = xzzu_?.Value;
            string xzzw_ = context.Operators.Convert<string>(xzzv_);
            string[] xzzx_ = [
                "final",
                "amended",
                "corrected",
            ];
            bool? xzzy_ = context.Operators.In<string>(xzzw_, xzzx_ as IEnumerable<string>);

            return xzzy_;
        };
        IEnumerable<Observation> xzzt_ = context.Operators.Where<Observation>(Obs, xzzs_);

        return xzzt_;
    }


    [CqlExpressionDefinition("isObservationBodyWeight")]
    public IEnumerable<Observation> isObservationBodyWeight(CqlContext context, IEnumerable<Observation> Obs)
    {
        bool? xzzz_(Observation O)
        {
            Code<ObservationStatus> yzzb_ = O?.StatusElement;
            ObservationStatus? yzzc_ = yzzb_?.Value;
            string yzzd_ = context.Operators.Convert<string>(yzzc_);
            string[] yzze_ = [
                "final",
                "amended",
                "corrected",
            ];
            bool? yzzf_ = context.Operators.In<string>(yzzd_, yzze_ as IEnumerable<string>);

            return yzzf_;
        };
        IEnumerable<Observation> yzza_ = context.Operators.Where<Observation>(Obs, xzzz_);

        return yzza_;
    }


    [CqlExpressionDefinition("isObservationBMI")]
    public IEnumerable<Observation> isObservationBMI(CqlContext context, IEnumerable<Observation> Obs)
    {
        bool? yzzg_(Observation O)
        {
            Code<ObservationStatus> yzzi_ = O?.StatusElement;
            ObservationStatus? yzzj_ = yzzi_?.Value;
            string yzzk_ = context.Operators.Convert<string>(yzzj_);
            string[] yzzl_ = [
                "final",
                "amended",
                "corrected",
            ];
            bool? yzzm_ = context.Operators.In<string>(yzzk_, yzzl_ as IEnumerable<string>);

            return yzzm_;
        };
        IEnumerable<Observation> yzzh_ = context.Operators.Where<Observation>(Obs, yzzg_);

        return yzzh_;
    }


    [CqlExpressionDefinition("isSymptom")]
    public IEnumerable<Observation> isSymptom(CqlContext context, IEnumerable<Observation> Obs)
    {
        bool? yzzn_(Observation O)
        {
            Code<ObservationStatus> yzzp_ = O?.StatusElement;
            ObservationStatus? yzzq_ = yzzp_?.Value;
            Code<ObservationStatus> yzzr_ = context.Operators.Convert<Code<ObservationStatus>>(yzzq_);
            string yzzs_ = context.Operators.Convert<string>(yzzr_);
            string[] yzzt_ = [
                "preliminary",
                "final",
                "amended",
                "corrected",
            ];
            bool? yzzu_ = context.Operators.In<string>(yzzs_, yzzt_ as IEnumerable<string>);

            return yzzu_;
        };
        IEnumerable<Observation> yzzo_ = context.Operators.Where<Observation>(Obs, yzzn_);

        return yzzo_;
    }


    #endregion Expressions

}
