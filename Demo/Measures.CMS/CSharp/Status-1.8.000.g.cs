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
      new CqlCodeSystem("http://terminology.hl7.org/CodeSystem/observation-category", null,
          _laboratory,
          _exam,
          _survey);

    #endregion CodeSystems

    #region Expressions

    [CqlExpressionDefinition("Patient")]
    public Patient Patient(CqlContext context)
    {
        IEnumerable<Patient> lzzn_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-patient"));
        Patient lzzo_ = context.Operators.SingletonFrom<Patient>(lzzn_);

        return lzzo_;
    }


    [CqlExpressionDefinition("isAssessmentPerformed")]
    public IEnumerable<Observation> isAssessmentPerformed(CqlContext context, IEnumerable<Observation> Obs)
    {
        bool? lzzp_(Observation O)
        {
            Code<ObservationStatus> lzzr_ = O?.StatusElement;
            ObservationStatus? lzzs_ = lzzr_?.Value;
            Code<ObservationStatus> lzzt_ = context.Operators.Convert<Code<ObservationStatus>>(lzzs_);
            string lzzu_ = context.Operators.Convert<string>(lzzt_);
            string[] lzzv_ = [
                "final",
                "amended",
                "corrected",
            ];
            bool? lzzw_ = context.Operators.In<string>(lzzu_, lzzv_ as IEnumerable<string>);
            List<CodeableConcept> lzzx_ = O?.Category;
            CqlConcept lzzy_(CodeableConcept @this)
            {
                CqlConcept mzze_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);

                return mzze_;
            };
            IEnumerable<CqlConcept> lzzz_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)lzzx_, lzzy_);
            bool? mzza_(CqlConcept ObservationCategory)
            {
                CqlCode mzzf_ = this.survey(context);
                CqlConcept mzzg_ = context.Operators.ConvertCodeToConcept(mzzf_);
                bool? mzzh_ = context.Operators.Equivalent(ObservationCategory, mzzg_);

                return mzzh_;
            };
            IEnumerable<CqlConcept> mzzb_ = context.Operators.Where<CqlConcept>(lzzz_, mzza_);
            bool? mzzc_ = context.Operators.Exists<CqlConcept>(mzzb_);
            bool? mzzd_ = context.Operators.And(lzzw_, mzzc_);

            return mzzd_;
        };
        IEnumerable<Observation> lzzq_ = context.Operators.Where<Observation>(Obs, lzzp_);

        return lzzq_;
    }


    [CqlExpressionDefinition("isDeviceOrder")]
    public IEnumerable<DeviceRequest> isDeviceOrder(CqlContext context, IEnumerable<DeviceRequest> DeviceRequest)
    {
        bool? mzzi_(DeviceRequest D)
        {
            Code<RequestStatus> mzzk_ = D?.StatusElement;
            RequestStatus? mzzl_ = mzzk_?.Value;
            Code<RequestStatus> mzzm_ = context.Operators.Convert<Code<RequestStatus>>(mzzl_);
            string mzzn_ = context.Operators.Convert<string>(mzzm_);
            string[] mzzo_ = [
                "active",
                "completed",
            ];
            bool? mzzp_ = context.Operators.In<string>(mzzn_, mzzo_ as IEnumerable<string>);
            Code<RequestIntent> mzzq_ = D?.IntentElement;
            RequestIntent? mzzr_ = mzzq_?.Value;
            Code<RequestIntent> mzzs_ = context.Operators.Convert<Code<RequestIntent>>(mzzr_);
            bool? mzzt_ = context.Operators.Equal(mzzs_, "order");
            bool? mzzu_ = context.Operators.And(mzzp_, mzzt_);

            return mzzu_;
        };
        IEnumerable<DeviceRequest> mzzj_ = context.Operators.Where<DeviceRequest>(DeviceRequest, mzzi_);

        return mzzj_;
    }


    [CqlExpressionDefinition("isDiagnosticStudyOrder")]
    public IEnumerable<ServiceRequest> isDiagnosticStudyOrder(CqlContext context, IEnumerable<ServiceRequest> ServiceRequest)
    {
        bool? mzzv_(ServiceRequest S)
        {
            Code<RequestStatus> mzzx_ = S?.StatusElement;
            RequestStatus? mzzy_ = mzzx_?.Value;
            Code<RequestStatus> mzzz_ = context.Operators.Convert<Code<RequestStatus>>(mzzy_);
            string nzza_ = context.Operators.Convert<string>(mzzz_);
            string[] nzzb_ = [
                "active",
                "completed",
            ];
            bool? nzzc_ = context.Operators.In<string>(nzza_, nzzb_ as IEnumerable<string>);
            Code<RequestIntent> nzzd_ = S?.IntentElement;
            RequestIntent? nzze_ = nzzd_?.Value;
            Code<RequestIntent> nzzf_ = context.Operators.Convert<Code<RequestIntent>>(nzze_);
            bool? nzzg_ = context.Operators.Equal(nzzf_, "order");
            bool? nzzh_ = context.Operators.And(nzzc_, nzzg_);

            return nzzh_;
        };
        IEnumerable<ServiceRequest> mzzw_ = context.Operators.Where<ServiceRequest>(ServiceRequest, mzzv_);

        return mzzw_;
    }


    [CqlExpressionDefinition("isInterventionOrder")]
    public IEnumerable<ServiceRequest> isInterventionOrder(CqlContext context, IEnumerable<ServiceRequest> ServiceRequest)
    {
        bool? nzzi_(ServiceRequest S)
        {
            Code<RequestStatus> nzzk_ = S?.StatusElement;
            RequestStatus? nzzl_ = nzzk_?.Value;
            Code<RequestStatus> nzzm_ = context.Operators.Convert<Code<RequestStatus>>(nzzl_);
            string nzzn_ = context.Operators.Convert<string>(nzzm_);
            string[] nzzo_ = [
                "active",
                "completed",
            ];
            bool? nzzp_ = context.Operators.In<string>(nzzn_, nzzo_ as IEnumerable<string>);
            Code<RequestIntent> nzzq_ = S?.IntentElement;
            RequestIntent? nzzr_ = nzzq_?.Value;
            Code<RequestIntent> nzzs_ = context.Operators.Convert<Code<RequestIntent>>(nzzr_);
            bool? nzzt_ = context.Operators.Equal(nzzs_, "order");
            bool? nzzu_ = context.Operators.And(nzzp_, nzzt_);

            return nzzu_;
        };
        IEnumerable<ServiceRequest> nzzj_ = context.Operators.Where<ServiceRequest>(ServiceRequest, nzzi_);

        return nzzj_;
    }


    [CqlExpressionDefinition("isLaboratoryTestOrder")]
    public IEnumerable<ServiceRequest> isLaboratoryTestOrder(CqlContext context, IEnumerable<ServiceRequest> ServiceRequest)
    {
        bool? nzzv_(ServiceRequest S)
        {
            Code<RequestStatus> nzzx_ = S?.StatusElement;
            RequestStatus? nzzy_ = nzzx_?.Value;
            Code<RequestStatus> nzzz_ = context.Operators.Convert<Code<RequestStatus>>(nzzy_);
            string ozza_ = context.Operators.Convert<string>(nzzz_);
            string[] ozzb_ = [
                "active",
                "completed",
            ];
            bool? ozzc_ = context.Operators.In<string>(ozza_, ozzb_ as IEnumerable<string>);
            Code<RequestIntent> ozzd_ = S?.IntentElement;
            RequestIntent? ozze_ = ozzd_?.Value;
            Code<RequestIntent> ozzf_ = context.Operators.Convert<Code<RequestIntent>>(ozze_);
            bool? ozzg_ = context.Operators.Equal(ozzf_, "order");
            bool? ozzh_ = context.Operators.And(ozzc_, ozzg_);

            return ozzh_;
        };
        IEnumerable<ServiceRequest> nzzw_ = context.Operators.Where<ServiceRequest>(ServiceRequest, nzzv_);

        return nzzw_;
    }


    [CqlExpressionDefinition("isDiagnosticStudyPerformed")]
    public IEnumerable<Observation> isDiagnosticStudyPerformed(CqlContext context, IEnumerable<Observation> Obs)
    {
        bool? ozzi_(Observation O)
        {
            Code<ObservationStatus> ozzk_ = O?.StatusElement;
            ObservationStatus? ozzl_ = ozzk_?.Value;
            Code<ObservationStatus> ozzm_ = context.Operators.Convert<Code<ObservationStatus>>(ozzl_);
            string ozzn_ = context.Operators.Convert<string>(ozzm_);
            string[] ozzo_ = [
                "final",
                "amended",
                "corrected",
            ];
            bool? ozzp_ = context.Operators.In<string>(ozzn_, ozzo_ as IEnumerable<string>);

            return ozzp_;
        };
        IEnumerable<Observation> ozzj_ = context.Operators.Where<Observation>(Obs, ozzi_);

        return ozzj_;
    }


    [CqlExpressionDefinition("isEncounterPerformed")]
    public IEnumerable<Encounter> isEncounterPerformed(CqlContext context, IEnumerable<Encounter> Enc)
    {
        bool? ozzq_(Encounter E)
        {
            Code<Encounter.EncounterStatus> ozzs_ = E?.StatusElement;
            Encounter.EncounterStatus? ozzt_ = ozzs_?.Value;
            Code<Encounter.EncounterStatus> ozzu_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(ozzt_);
            string ozzv_ = context.Operators.Convert<string>(ozzu_);
            string[] ozzw_ = [
                "finished",
                "arrived",
                "triaged",
                "in-progress",
                "onleave",
            ];
            bool? ozzx_ = context.Operators.In<string>(ozzv_, ozzw_ as IEnumerable<string>);

            return ozzx_;
        };
        IEnumerable<Encounter> ozzr_ = context.Operators.Where<Encounter>(Enc, ozzq_);

        return ozzr_;
    }


    [CqlExpressionDefinition("isImmunizationAdministered")]
    public IEnumerable<Immunization> isImmunizationAdministered(CqlContext context, IEnumerable<Immunization> Immunization)
    {
        bool? ozzy_(Immunization I)
        {
            Code<Immunization.ImmunizationStatusCodes> pzza_ = I?.StatusElement;
            Immunization.ImmunizationStatusCodes? pzzb_ = pzza_?.Value;
            string pzzc_ = context.Operators.Convert<string>(pzzb_);
            bool? pzzd_ = context.Operators.Equivalent(pzzc_, "completed");

            return pzzd_;
        };
        IEnumerable<Immunization> ozzz_ = context.Operators.Where<Immunization>(Immunization, ozzy_);

        return ozzz_;
    }


    [CqlExpressionDefinition("isInterventionPerformed")]
    public IEnumerable<Procedure> isInterventionPerformed(CqlContext context, IEnumerable<Procedure> Proc)
    {
        bool? pzze_(Procedure P)
        {
            Code<EventStatus> pzzg_ = P?.StatusElement;
            EventStatus? pzzh_ = pzzg_?.Value;
            string pzzi_ = context.Operators.Convert<string>(pzzh_);
            bool? pzzj_ = context.Operators.Equivalent(pzzi_, "completed");

            return pzzj_;
        };
        IEnumerable<Procedure> pzzf_ = context.Operators.Where<Procedure>(Proc, pzze_);

        return pzzf_;
    }


    [CqlExpressionDefinition("isProcedurePerformed")]
    public IEnumerable<Procedure> isProcedurePerformed(CqlContext context, IEnumerable<Procedure> Proc)
    {
        bool? pzzk_(Procedure P)
        {
            Code<EventStatus> pzzm_ = P?.StatusElement;
            EventStatus? pzzn_ = pzzm_?.Value;
            string pzzo_ = context.Operators.Convert<string>(pzzn_);
            bool? pzzp_ = context.Operators.Equivalent(pzzo_, "completed");

            return pzzp_;
        };
        IEnumerable<Procedure> pzzl_ = context.Operators.Where<Procedure>(Proc, pzzk_);

        return pzzl_;
    }


    [CqlExpressionDefinition("isLaboratoryTestPerformed")]
    public IEnumerable<Observation> isLaboratoryTestPerformed(CqlContext context, IEnumerable<Observation> Obs)
    {
        bool? pzzq_(Observation O)
        {
            Code<ObservationStatus> pzzs_ = O?.StatusElement;
            ObservationStatus? pzzt_ = pzzs_?.Value;
            Code<ObservationStatus> pzzu_ = context.Operators.Convert<Code<ObservationStatus>>(pzzt_);
            string pzzv_ = context.Operators.Convert<string>(pzzu_);
            string[] pzzw_ = [
                "final",
                "amended",
                "corrected",
            ];
            bool? pzzx_ = context.Operators.In<string>(pzzv_, pzzw_ as IEnumerable<string>);
            List<CodeableConcept> pzzy_ = O?.Category;
            CqlConcept pzzz_(CodeableConcept @this)
            {
                CqlConcept qzzf_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);

                return qzzf_;
            };
            IEnumerable<CqlConcept> qzza_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)pzzy_, pzzz_);
            bool? qzzb_(CqlConcept ObservationCategory)
            {
                CqlCode qzzg_ = this.laboratory(context);
                CqlConcept qzzh_ = context.Operators.ConvertCodeToConcept(qzzg_);
                bool? qzzi_ = context.Operators.Equivalent(ObservationCategory, qzzh_);

                return qzzi_;
            };
            IEnumerable<CqlConcept> qzzc_ = context.Operators.Where<CqlConcept>(qzza_, qzzb_);
            bool? qzzd_ = context.Operators.Exists<CqlConcept>(qzzc_);
            bool? qzze_ = context.Operators.And(pzzx_, qzzd_);

            return qzze_;
        };
        IEnumerable<Observation> pzzr_ = context.Operators.Where<Observation>(Obs, pzzq_);

        return pzzr_;
    }


    [CqlExpressionDefinition("isMedicationActive")]
    public IEnumerable<MedicationRequest> isMedicationActive(CqlContext context, IEnumerable<MedicationRequest> MedicationRequest)
    {
        bool? qzzj_(MedicationRequest M)
        {
            Code<MedicationRequest.MedicationrequestStatus> qzzl_ = M?.StatusElement;
            MedicationRequest.MedicationrequestStatus? qzzm_ = qzzl_?.Value;
            string qzzn_ = context.Operators.Convert<string>(qzzm_);
            bool? qzzo_ = context.Operators.Equal(qzzn_, "active");
            Code<MedicationRequest.MedicationRequestIntent> qzzp_ = M?.IntentElement;
            MedicationRequest.MedicationRequestIntent? qzzq_ = qzzp_?.Value;
            string qzzr_ = context.Operators.Convert<string>(qzzq_);
            bool? qzzs_ = context.Operators.Equal(qzzr_, "order");
            bool? qzzt_ = context.Operators.And(qzzo_, qzzs_);

            return qzzt_;
        };
        IEnumerable<MedicationRequest> qzzk_ = context.Operators.Where<MedicationRequest>(MedicationRequest, qzzj_);

        return qzzk_;
    }


    [CqlExpressionDefinition("isMedicationDispensed")]
    public IEnumerable<MedicationDispense> isMedicationDispensed(CqlContext context, IEnumerable<MedicationDispense> Med)
    {
        bool? qzzu_(MedicationDispense M)
        {
            Code<MedicationDispense.MedicationDispenseStatusCodes> qzzw_ = M?.StatusElement;
            MedicationDispense.MedicationDispenseStatusCodes? qzzx_ = qzzw_?.Value;
            Code<MedicationDispense.MedicationDispenseStatusCodes> qzzy_ = context.Operators.Convert<Code<MedicationDispense.MedicationDispenseStatusCodes>>(qzzx_);
            string qzzz_ = context.Operators.Convert<string>(qzzy_);
            string[] rzza_ = [
                "completed",
                "in-progress",
                "on-hold",
            ];
            bool? rzzb_ = context.Operators.In<string>(qzzz_, rzza_ as IEnumerable<string>);

            return rzzb_;
        };
        IEnumerable<MedicationDispense> qzzv_ = context.Operators.Where<MedicationDispense>(Med, qzzu_);

        return qzzv_;
    }


    [CqlExpressionDefinition("isMedicationOrder")]
    public IEnumerable<MedicationRequest> isMedicationOrder(CqlContext context, IEnumerable<MedicationRequest> MedicationRequest)
    {
        bool? rzzc_(MedicationRequest M)
        {
            Code<MedicationRequest.MedicationrequestStatus> rzze_ = M?.StatusElement;
            MedicationRequest.MedicationrequestStatus? rzzf_ = rzze_?.Value;
            string rzzg_ = context.Operators.Convert<string>(rzzf_);
            string[] rzzh_ = [
                "active",
                "completed",
            ];
            bool? rzzi_ = context.Operators.In<string>(rzzg_, rzzh_ as IEnumerable<string>);
            Code<MedicationRequest.MedicationRequestIntent> rzzj_ = M?.IntentElement;
            MedicationRequest.MedicationRequestIntent? rzzk_ = rzzj_?.Value;
            string rzzl_ = context.Operators.Convert<string>(rzzk_);
            bool? rzzm_ = context.Operators.Equal(rzzl_, "order");
            bool? rzzn_ = context.Operators.And(rzzi_, rzzm_);

            return rzzn_;
        };
        IEnumerable<MedicationRequest> rzzd_ = context.Operators.Where<MedicationRequest>(MedicationRequest, rzzc_);

        return rzzd_;
    }


    [CqlExpressionDefinition("isPhysicalExamPerformed")]
    public IEnumerable<Observation> isPhysicalExamPerformed(CqlContext context, IEnumerable<Observation> Obs)
    {
        bool? rzzo_(Observation O)
        {
            Code<ObservationStatus> rzzq_ = O?.StatusElement;
            ObservationStatus? rzzr_ = rzzq_?.Value;
            Code<ObservationStatus> rzzs_ = context.Operators.Convert<Code<ObservationStatus>>(rzzr_);
            string rzzt_ = context.Operators.Convert<string>(rzzs_);
            string[] rzzu_ = [
                "final",
                "amended",
                "corrected",
            ];
            bool? rzzv_ = context.Operators.In<string>(rzzt_, rzzu_ as IEnumerable<string>);
            List<CodeableConcept> rzzw_ = O?.Category;
            CqlConcept rzzx_(CodeableConcept @this)
            {
                CqlConcept szzd_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);

                return szzd_;
            };
            IEnumerable<CqlConcept> rzzy_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)rzzw_, rzzx_);
            bool? rzzz_(CqlConcept ObservationCategory)
            {
                CqlCode szze_ = this.exam(context);
                CqlConcept szzf_ = context.Operators.ConvertCodeToConcept(szze_);
                bool? szzg_ = context.Operators.Equivalent(ObservationCategory, szzf_);

                return szzg_;
            };
            IEnumerable<CqlConcept> szza_ = context.Operators.Where<CqlConcept>(rzzy_, rzzz_);
            bool? szzb_ = context.Operators.Exists<CqlConcept>(szza_);
            bool? szzc_ = context.Operators.And(rzzv_, szzb_);

            return szzc_;
        };
        IEnumerable<Observation> rzzp_ = context.Operators.Where<Observation>(Obs, rzzo_);

        return rzzp_;
    }


    [CqlExpressionDefinition("isObservationBP")]
    public IEnumerable<Observation> isObservationBP(CqlContext context, IEnumerable<Observation> Obs)
    {
        bool? szzh_(Observation O)
        {
            Code<ObservationStatus> szzj_ = O?.StatusElement;
            ObservationStatus? szzk_ = szzj_?.Value;
            string szzl_ = context.Operators.Convert<string>(szzk_);
            string[] szzm_ = [
                "final",
                "amended",
                "corrected",
            ];
            bool? szzn_ = context.Operators.In<string>(szzl_, szzm_ as IEnumerable<string>);

            return szzn_;
        };
        IEnumerable<Observation> szzi_ = context.Operators.Where<Observation>(Obs, szzh_);

        return szzi_;
    }


    [CqlExpressionDefinition("isObservationBodyHeight")]
    public IEnumerable<Observation> isObservationBodyHeight(CqlContext context, IEnumerable<Observation> Obs)
    {
        bool? szzo_(Observation O)
        {
            Code<ObservationStatus> szzq_ = O?.StatusElement;
            ObservationStatus? szzr_ = szzq_?.Value;
            string szzs_ = context.Operators.Convert<string>(szzr_);
            string[] szzt_ = [
                "final",
                "amended",
                "corrected",
            ];
            bool? szzu_ = context.Operators.In<string>(szzs_, szzt_ as IEnumerable<string>);

            return szzu_;
        };
        IEnumerable<Observation> szzp_ = context.Operators.Where<Observation>(Obs, szzo_);

        return szzp_;
    }


    [CqlExpressionDefinition("isObservationBodyWeight")]
    public IEnumerable<Observation> isObservationBodyWeight(CqlContext context, IEnumerable<Observation> Obs)
    {
        bool? szzv_(Observation O)
        {
            Code<ObservationStatus> szzx_ = O?.StatusElement;
            ObservationStatus? szzy_ = szzx_?.Value;
            string szzz_ = context.Operators.Convert<string>(szzy_);
            string[] tzza_ = [
                "final",
                "amended",
                "corrected",
            ];
            bool? tzzb_ = context.Operators.In<string>(szzz_, tzza_ as IEnumerable<string>);

            return tzzb_;
        };
        IEnumerable<Observation> szzw_ = context.Operators.Where<Observation>(Obs, szzv_);

        return szzw_;
    }


    [CqlExpressionDefinition("isObservationBMI")]
    public IEnumerable<Observation> isObservationBMI(CqlContext context, IEnumerable<Observation> Obs)
    {
        bool? tzzc_(Observation O)
        {
            Code<ObservationStatus> tzze_ = O?.StatusElement;
            ObservationStatus? tzzf_ = tzze_?.Value;
            string tzzg_ = context.Operators.Convert<string>(tzzf_);
            string[] tzzh_ = [
                "final",
                "amended",
                "corrected",
            ];
            bool? tzzi_ = context.Operators.In<string>(tzzg_, tzzh_ as IEnumerable<string>);

            return tzzi_;
        };
        IEnumerable<Observation> tzzd_ = context.Operators.Where<Observation>(Obs, tzzc_);

        return tzzd_;
    }


    [CqlExpressionDefinition("isSymptom")]
    public IEnumerable<Observation> isSymptom(CqlContext context, IEnumerable<Observation> Obs)
    {
        bool? tzzj_(Observation O)
        {
            Code<ObservationStatus> tzzl_ = O?.StatusElement;
            ObservationStatus? tzzm_ = tzzl_?.Value;
            Code<ObservationStatus> tzzn_ = context.Operators.Convert<Code<ObservationStatus>>(tzzm_);
            string tzzo_ = context.Operators.Convert<string>(tzzn_);
            string[] tzzp_ = [
                "preliminary",
                "final",
                "amended",
                "corrected",
            ];
            bool? tzzq_ = context.Operators.In<string>(tzzo_, tzzp_ as IEnumerable<string>);

            return tzzq_;
        };
        IEnumerable<Observation> tzzk_ = context.Operators.Where<Observation>(Obs, tzzj_);

        return tzzk_;
    }


    #endregion Expressions

}
