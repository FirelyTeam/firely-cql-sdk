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
        IEnumerable<Patient> lzzp_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-patient"));
        Patient lzzq_ = context.Operators.SingletonFrom<Patient>(lzzp_);

        return lzzq_;
    }


    [CqlExpressionDefinition("isAssessmentPerformed")]
    public IEnumerable<Observation> isAssessmentPerformed(CqlContext context, IEnumerable<Observation> Obs)
    {
        bool? lzzr_(Observation O)
        {
            Code<ObservationStatus> lzzt_ = O?.StatusElement;
            ObservationStatus? lzzu_ = lzzt_?.Value;
            Code<ObservationStatus> lzzv_ = context.Operators.Convert<Code<ObservationStatus>>(lzzu_);
            string lzzw_ = context.Operators.Convert<string>(lzzv_);
            string[] lzzx_ = [
                "final",
                "amended",
                "corrected",
            ];
            bool? lzzy_ = context.Operators.In<string>(lzzw_, lzzx_ as IEnumerable<string>);
            List<CodeableConcept> lzzz_ = O?.Category;
            CqlConcept mzza_(CodeableConcept @this)
            {
                CqlConcept mzzg_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);

                return mzzg_;
            };
            IEnumerable<CqlConcept> mzzb_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)lzzz_, mzza_);
            bool? mzzc_(CqlConcept ObservationCategory)
            {
                CqlCode mzzh_ = this.survey(context);
                CqlConcept mzzi_ = context.Operators.ConvertCodeToConcept(mzzh_);
                bool? mzzj_ = context.Operators.Equivalent(ObservationCategory, mzzi_);

                return mzzj_;
            };
            IEnumerable<CqlConcept> mzzd_ = context.Operators.Where<CqlConcept>(mzzb_, mzzc_);
            bool? mzze_ = context.Operators.Exists<CqlConcept>(mzzd_);
            bool? mzzf_ = context.Operators.And(lzzy_, mzze_);

            return mzzf_;
        };
        IEnumerable<Observation> lzzs_ = context.Operators.Where<Observation>(Obs, lzzr_);

        return lzzs_;
    }


    [CqlExpressionDefinition("isDeviceOrder")]
    public IEnumerable<DeviceRequest> isDeviceOrder(CqlContext context, IEnumerable<DeviceRequest> DeviceRequest)
    {
        bool? mzzk_(DeviceRequest D)
        {
            Code<RequestStatus> mzzm_ = D?.StatusElement;
            RequestStatus? mzzn_ = mzzm_?.Value;
            Code<RequestStatus> mzzo_ = context.Operators.Convert<Code<RequestStatus>>(mzzn_);
            string mzzp_ = context.Operators.Convert<string>(mzzo_);
            string[] mzzq_ = [
                "active",
                "completed",
            ];
            bool? mzzr_ = context.Operators.In<string>(mzzp_, mzzq_ as IEnumerable<string>);
            Code<RequestIntent> mzzs_ = D?.IntentElement;
            RequestIntent? mzzt_ = mzzs_?.Value;
            Code<RequestIntent> mzzu_ = context.Operators.Convert<Code<RequestIntent>>(mzzt_);
            bool? mzzv_ = context.Operators.Equal(mzzu_, "order");
            bool? mzzw_ = context.Operators.And(mzzr_, mzzv_);

            return mzzw_;
        };
        IEnumerable<DeviceRequest> mzzl_ = context.Operators.Where<DeviceRequest>(DeviceRequest, mzzk_);

        return mzzl_;
    }


    [CqlExpressionDefinition("isDiagnosticStudyOrder")]
    public IEnumerable<ServiceRequest> isDiagnosticStudyOrder(CqlContext context, IEnumerable<ServiceRequest> ServiceRequest)
    {
        bool? mzzx_(ServiceRequest S)
        {
            Code<RequestStatus> mzzz_ = S?.StatusElement;
            RequestStatus? nzza_ = mzzz_?.Value;
            Code<RequestStatus> nzzb_ = context.Operators.Convert<Code<RequestStatus>>(nzza_);
            string nzzc_ = context.Operators.Convert<string>(nzzb_);
            string[] nzzd_ = [
                "active",
                "completed",
            ];
            bool? nzze_ = context.Operators.In<string>(nzzc_, nzzd_ as IEnumerable<string>);
            Code<RequestIntent> nzzf_ = S?.IntentElement;
            RequestIntent? nzzg_ = nzzf_?.Value;
            Code<RequestIntent> nzzh_ = context.Operators.Convert<Code<RequestIntent>>(nzzg_);
            bool? nzzi_ = context.Operators.Equal(nzzh_, "order");
            bool? nzzj_ = context.Operators.And(nzze_, nzzi_);

            return nzzj_;
        };
        IEnumerable<ServiceRequest> mzzy_ = context.Operators.Where<ServiceRequest>(ServiceRequest, mzzx_);

        return mzzy_;
    }


    [CqlExpressionDefinition("isInterventionOrder")]
    public IEnumerable<ServiceRequest> isInterventionOrder(CqlContext context, IEnumerable<ServiceRequest> ServiceRequest)
    {
        bool? nzzk_(ServiceRequest S)
        {
            Code<RequestStatus> nzzm_ = S?.StatusElement;
            RequestStatus? nzzn_ = nzzm_?.Value;
            Code<RequestStatus> nzzo_ = context.Operators.Convert<Code<RequestStatus>>(nzzn_);
            string nzzp_ = context.Operators.Convert<string>(nzzo_);
            string[] nzzq_ = [
                "active",
                "completed",
            ];
            bool? nzzr_ = context.Operators.In<string>(nzzp_, nzzq_ as IEnumerable<string>);
            Code<RequestIntent> nzzs_ = S?.IntentElement;
            RequestIntent? nzzt_ = nzzs_?.Value;
            Code<RequestIntent> nzzu_ = context.Operators.Convert<Code<RequestIntent>>(nzzt_);
            bool? nzzv_ = context.Operators.Equal(nzzu_, "order");
            bool? nzzw_ = context.Operators.And(nzzr_, nzzv_);

            return nzzw_;
        };
        IEnumerable<ServiceRequest> nzzl_ = context.Operators.Where<ServiceRequest>(ServiceRequest, nzzk_);

        return nzzl_;
    }


    [CqlExpressionDefinition("isLaboratoryTestOrder")]
    public IEnumerable<ServiceRequest> isLaboratoryTestOrder(CqlContext context, IEnumerable<ServiceRequest> ServiceRequest)
    {
        bool? nzzx_(ServiceRequest S)
        {
            Code<RequestStatus> nzzz_ = S?.StatusElement;
            RequestStatus? ozza_ = nzzz_?.Value;
            Code<RequestStatus> ozzb_ = context.Operators.Convert<Code<RequestStatus>>(ozza_);
            string ozzc_ = context.Operators.Convert<string>(ozzb_);
            string[] ozzd_ = [
                "active",
                "completed",
            ];
            bool? ozze_ = context.Operators.In<string>(ozzc_, ozzd_ as IEnumerable<string>);
            Code<RequestIntent> ozzf_ = S?.IntentElement;
            RequestIntent? ozzg_ = ozzf_?.Value;
            Code<RequestIntent> ozzh_ = context.Operators.Convert<Code<RequestIntent>>(ozzg_);
            bool? ozzi_ = context.Operators.Equal(ozzh_, "order");
            bool? ozzj_ = context.Operators.And(ozze_, ozzi_);

            return ozzj_;
        };
        IEnumerable<ServiceRequest> nzzy_ = context.Operators.Where<ServiceRequest>(ServiceRequest, nzzx_);

        return nzzy_;
    }


    [CqlExpressionDefinition("isDiagnosticStudyPerformed")]
    public IEnumerable<Observation> isDiagnosticStudyPerformed(CqlContext context, IEnumerable<Observation> Obs)
    {
        bool? ozzk_(Observation O)
        {
            Code<ObservationStatus> ozzm_ = O?.StatusElement;
            ObservationStatus? ozzn_ = ozzm_?.Value;
            Code<ObservationStatus> ozzo_ = context.Operators.Convert<Code<ObservationStatus>>(ozzn_);
            string ozzp_ = context.Operators.Convert<string>(ozzo_);
            string[] ozzq_ = [
                "final",
                "amended",
                "corrected",
            ];
            bool? ozzr_ = context.Operators.In<string>(ozzp_, ozzq_ as IEnumerable<string>);

            return ozzr_;
        };
        IEnumerable<Observation> ozzl_ = context.Operators.Where<Observation>(Obs, ozzk_);

        return ozzl_;
    }


    [CqlExpressionDefinition("isEncounterPerformed")]
    public IEnumerable<Encounter> isEncounterPerformed(CqlContext context, IEnumerable<Encounter> Enc)
    {
        bool? ozzs_(Encounter E)
        {
            Code<Encounter.EncounterStatus> ozzu_ = E?.StatusElement;
            Encounter.EncounterStatus? ozzv_ = ozzu_?.Value;
            Code<Encounter.EncounterStatus> ozzw_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(ozzv_);
            string ozzx_ = context.Operators.Convert<string>(ozzw_);
            string[] ozzy_ = [
                "finished",
                "arrived",
                "triaged",
                "in-progress",
                "onleave",
            ];
            bool? ozzz_ = context.Operators.In<string>(ozzx_, ozzy_ as IEnumerable<string>);

            return ozzz_;
        };
        IEnumerable<Encounter> ozzt_ = context.Operators.Where<Encounter>(Enc, ozzs_);

        return ozzt_;
    }


    [CqlExpressionDefinition("isImmunizationAdministered")]
    public IEnumerable<Immunization> isImmunizationAdministered(CqlContext context, IEnumerable<Immunization> Immunization)
    {
        bool? pzza_(Immunization I)
        {
            Code<Immunization.ImmunizationStatusCodes> pzzc_ = I?.StatusElement;
            Immunization.ImmunizationStatusCodes? pzzd_ = pzzc_?.Value;
            string pzze_ = context.Operators.Convert<string>(pzzd_);
            bool? pzzf_ = context.Operators.Equivalent(pzze_, "completed");

            return pzzf_;
        };
        IEnumerable<Immunization> pzzb_ = context.Operators.Where<Immunization>(Immunization, pzza_);

        return pzzb_;
    }


    [CqlExpressionDefinition("isInterventionPerformed")]
    public IEnumerable<Procedure> isInterventionPerformed(CqlContext context, IEnumerable<Procedure> Proc)
    {
        bool? pzzg_(Procedure P)
        {
            Code<EventStatus> pzzi_ = P?.StatusElement;
            EventStatus? pzzj_ = pzzi_?.Value;
            string pzzk_ = context.Operators.Convert<string>(pzzj_);
            bool? pzzl_ = context.Operators.Equivalent(pzzk_, "completed");

            return pzzl_;
        };
        IEnumerable<Procedure> pzzh_ = context.Operators.Where<Procedure>(Proc, pzzg_);

        return pzzh_;
    }


    [CqlExpressionDefinition("isProcedurePerformed")]
    public IEnumerable<Procedure> isProcedurePerformed(CqlContext context, IEnumerable<Procedure> Proc)
    {
        bool? pzzm_(Procedure P)
        {
            Code<EventStatus> pzzo_ = P?.StatusElement;
            EventStatus? pzzp_ = pzzo_?.Value;
            string pzzq_ = context.Operators.Convert<string>(pzzp_);
            bool? pzzr_ = context.Operators.Equivalent(pzzq_, "completed");

            return pzzr_;
        };
        IEnumerable<Procedure> pzzn_ = context.Operators.Where<Procedure>(Proc, pzzm_);

        return pzzn_;
    }


    [CqlExpressionDefinition("isLaboratoryTestPerformed")]
    public IEnumerable<Observation> isLaboratoryTestPerformed(CqlContext context, IEnumerable<Observation> Obs)
    {
        bool? pzzs_(Observation O)
        {
            Code<ObservationStatus> pzzu_ = O?.StatusElement;
            ObservationStatus? pzzv_ = pzzu_?.Value;
            Code<ObservationStatus> pzzw_ = context.Operators.Convert<Code<ObservationStatus>>(pzzv_);
            string pzzx_ = context.Operators.Convert<string>(pzzw_);
            string[] pzzy_ = [
                "final",
                "amended",
                "corrected",
            ];
            bool? pzzz_ = context.Operators.In<string>(pzzx_, pzzy_ as IEnumerable<string>);
            List<CodeableConcept> qzza_ = O?.Category;
            CqlConcept qzzb_(CodeableConcept @this)
            {
                CqlConcept qzzh_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);

                return qzzh_;
            };
            IEnumerable<CqlConcept> qzzc_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)qzza_, qzzb_);
            bool? qzzd_(CqlConcept ObservationCategory)
            {
                CqlCode qzzi_ = this.laboratory(context);
                CqlConcept qzzj_ = context.Operators.ConvertCodeToConcept(qzzi_);
                bool? qzzk_ = context.Operators.Equivalent(ObservationCategory, qzzj_);

                return qzzk_;
            };
            IEnumerable<CqlConcept> qzze_ = context.Operators.Where<CqlConcept>(qzzc_, qzzd_);
            bool? qzzf_ = context.Operators.Exists<CqlConcept>(qzze_);
            bool? qzzg_ = context.Operators.And(pzzz_, qzzf_);

            return qzzg_;
        };
        IEnumerable<Observation> pzzt_ = context.Operators.Where<Observation>(Obs, pzzs_);

        return pzzt_;
    }


    [CqlExpressionDefinition("isMedicationActive")]
    public IEnumerable<MedicationRequest> isMedicationActive(CqlContext context, IEnumerable<MedicationRequest> MedicationRequest)
    {
        bool? qzzl_(MedicationRequest M)
        {
            Code<MedicationRequest.MedicationrequestStatus> qzzn_ = M?.StatusElement;
            MedicationRequest.MedicationrequestStatus? qzzo_ = qzzn_?.Value;
            string qzzp_ = context.Operators.Convert<string>(qzzo_);
            bool? qzzq_ = context.Operators.Equal(qzzp_, "active");
            Code<MedicationRequest.MedicationRequestIntent> qzzr_ = M?.IntentElement;
            MedicationRequest.MedicationRequestIntent? qzzs_ = qzzr_?.Value;
            string qzzt_ = context.Operators.Convert<string>(qzzs_);
            bool? qzzu_ = context.Operators.Equal(qzzt_, "order");
            bool? qzzv_ = context.Operators.And(qzzq_, qzzu_);

            return qzzv_;
        };
        IEnumerable<MedicationRequest> qzzm_ = context.Operators.Where<MedicationRequest>(MedicationRequest, qzzl_);

        return qzzm_;
    }


    [CqlExpressionDefinition("isMedicationDispensed")]
    public IEnumerable<MedicationDispense> isMedicationDispensed(CqlContext context, IEnumerable<MedicationDispense> Med)
    {
        bool? qzzw_(MedicationDispense M)
        {
            Code<MedicationDispense.MedicationDispenseStatusCodes> qzzy_ = M?.StatusElement;
            MedicationDispense.MedicationDispenseStatusCodes? qzzz_ = qzzy_?.Value;
            Code<MedicationDispense.MedicationDispenseStatusCodes> rzza_ = context.Operators.Convert<Code<MedicationDispense.MedicationDispenseStatusCodes>>(qzzz_);
            string rzzb_ = context.Operators.Convert<string>(rzza_);
            string[] rzzc_ = [
                "completed",
                "in-progress",
                "on-hold",
            ];
            bool? rzzd_ = context.Operators.In<string>(rzzb_, rzzc_ as IEnumerable<string>);

            return rzzd_;
        };
        IEnumerable<MedicationDispense> qzzx_ = context.Operators.Where<MedicationDispense>(Med, qzzw_);

        return qzzx_;
    }


    [CqlExpressionDefinition("isMedicationOrder")]
    public IEnumerable<MedicationRequest> isMedicationOrder(CqlContext context, IEnumerable<MedicationRequest> MedicationRequest)
    {
        bool? rzze_(MedicationRequest M)
        {
            Code<MedicationRequest.MedicationrequestStatus> rzzg_ = M?.StatusElement;
            MedicationRequest.MedicationrequestStatus? rzzh_ = rzzg_?.Value;
            string rzzi_ = context.Operators.Convert<string>(rzzh_);
            string[] rzzj_ = [
                "active",
                "completed",
            ];
            bool? rzzk_ = context.Operators.In<string>(rzzi_, rzzj_ as IEnumerable<string>);
            Code<MedicationRequest.MedicationRequestIntent> rzzl_ = M?.IntentElement;
            MedicationRequest.MedicationRequestIntent? rzzm_ = rzzl_?.Value;
            string rzzn_ = context.Operators.Convert<string>(rzzm_);
            bool? rzzo_ = context.Operators.Equal(rzzn_, "order");
            bool? rzzp_ = context.Operators.And(rzzk_, rzzo_);

            return rzzp_;
        };
        IEnumerable<MedicationRequest> rzzf_ = context.Operators.Where<MedicationRequest>(MedicationRequest, rzze_);

        return rzzf_;
    }


    [CqlExpressionDefinition("isPhysicalExamPerformed")]
    public IEnumerable<Observation> isPhysicalExamPerformed(CqlContext context, IEnumerable<Observation> Obs)
    {
        bool? rzzq_(Observation O)
        {
            Code<ObservationStatus> rzzs_ = O?.StatusElement;
            ObservationStatus? rzzt_ = rzzs_?.Value;
            Code<ObservationStatus> rzzu_ = context.Operators.Convert<Code<ObservationStatus>>(rzzt_);
            string rzzv_ = context.Operators.Convert<string>(rzzu_);
            string[] rzzw_ = [
                "final",
                "amended",
                "corrected",
            ];
            bool? rzzx_ = context.Operators.In<string>(rzzv_, rzzw_ as IEnumerable<string>);
            List<CodeableConcept> rzzy_ = O?.Category;
            CqlConcept rzzz_(CodeableConcept @this)
            {
                CqlConcept szzf_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);

                return szzf_;
            };
            IEnumerable<CqlConcept> szza_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)rzzy_, rzzz_);
            bool? szzb_(CqlConcept ObservationCategory)
            {
                CqlCode szzg_ = this.exam(context);
                CqlConcept szzh_ = context.Operators.ConvertCodeToConcept(szzg_);
                bool? szzi_ = context.Operators.Equivalent(ObservationCategory, szzh_);

                return szzi_;
            };
            IEnumerable<CqlConcept> szzc_ = context.Operators.Where<CqlConcept>(szza_, szzb_);
            bool? szzd_ = context.Operators.Exists<CqlConcept>(szzc_);
            bool? szze_ = context.Operators.And(rzzx_, szzd_);

            return szze_;
        };
        IEnumerable<Observation> rzzr_ = context.Operators.Where<Observation>(Obs, rzzq_);

        return rzzr_;
    }


    [CqlExpressionDefinition("isObservationBP")]
    public IEnumerable<Observation> isObservationBP(CqlContext context, IEnumerable<Observation> Obs)
    {
        bool? szzj_(Observation O)
        {
            Code<ObservationStatus> szzl_ = O?.StatusElement;
            ObservationStatus? szzm_ = szzl_?.Value;
            string szzn_ = context.Operators.Convert<string>(szzm_);
            string[] szzo_ = [
                "final",
                "amended",
                "corrected",
            ];
            bool? szzp_ = context.Operators.In<string>(szzn_, szzo_ as IEnumerable<string>);

            return szzp_;
        };
        IEnumerable<Observation> szzk_ = context.Operators.Where<Observation>(Obs, szzj_);

        return szzk_;
    }


    [CqlExpressionDefinition("isObservationBodyHeight")]
    public IEnumerable<Observation> isObservationBodyHeight(CqlContext context, IEnumerable<Observation> Obs)
    {
        bool? szzq_(Observation O)
        {
            Code<ObservationStatus> szzs_ = O?.StatusElement;
            ObservationStatus? szzt_ = szzs_?.Value;
            string szzu_ = context.Operators.Convert<string>(szzt_);
            string[] szzv_ = [
                "final",
                "amended",
                "corrected",
            ];
            bool? szzw_ = context.Operators.In<string>(szzu_, szzv_ as IEnumerable<string>);

            return szzw_;
        };
        IEnumerable<Observation> szzr_ = context.Operators.Where<Observation>(Obs, szzq_);

        return szzr_;
    }


    [CqlExpressionDefinition("isObservationBodyWeight")]
    public IEnumerable<Observation> isObservationBodyWeight(CqlContext context, IEnumerable<Observation> Obs)
    {
        bool? szzx_(Observation O)
        {
            Code<ObservationStatus> szzz_ = O?.StatusElement;
            ObservationStatus? tzza_ = szzz_?.Value;
            string tzzb_ = context.Operators.Convert<string>(tzza_);
            string[] tzzc_ = [
                "final",
                "amended",
                "corrected",
            ];
            bool? tzzd_ = context.Operators.In<string>(tzzb_, tzzc_ as IEnumerable<string>);

            return tzzd_;
        };
        IEnumerable<Observation> szzy_ = context.Operators.Where<Observation>(Obs, szzx_);

        return szzy_;
    }


    [CqlExpressionDefinition("isObservationBMI")]
    public IEnumerable<Observation> isObservationBMI(CqlContext context, IEnumerable<Observation> Obs)
    {
        bool? tzze_(Observation O)
        {
            Code<ObservationStatus> tzzg_ = O?.StatusElement;
            ObservationStatus? tzzh_ = tzzg_?.Value;
            string tzzi_ = context.Operators.Convert<string>(tzzh_);
            string[] tzzj_ = [
                "final",
                "amended",
                "corrected",
            ];
            bool? tzzk_ = context.Operators.In<string>(tzzi_, tzzj_ as IEnumerable<string>);

            return tzzk_;
        };
        IEnumerable<Observation> tzzf_ = context.Operators.Where<Observation>(Obs, tzze_);

        return tzzf_;
    }


    [CqlExpressionDefinition("isSymptom")]
    public IEnumerable<Observation> isSymptom(CqlContext context, IEnumerable<Observation> Obs)
    {
        bool? tzzl_(Observation O)
        {
            Code<ObservationStatus> tzzn_ = O?.StatusElement;
            ObservationStatus? tzzo_ = tzzn_?.Value;
            Code<ObservationStatus> tzzp_ = context.Operators.Convert<Code<ObservationStatus>>(tzzo_);
            string tzzq_ = context.Operators.Convert<string>(tzzp_);
            string[] tzzr_ = [
                "preliminary",
                "final",
                "amended",
                "corrected",
            ];
            bool? tzzs_ = context.Operators.In<string>(tzzq_, tzzr_ as IEnumerable<string>);

            return tzzs_;
        };
        IEnumerable<Observation> tzzm_ = context.Operators.Where<Observation>(Obs, tzzl_);

        return tzzm_;
    }


    #endregion Expressions

}
