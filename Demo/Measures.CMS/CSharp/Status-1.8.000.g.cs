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
        IEnumerable<Patient> hzzzzzzzd_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-patient"));
        Patient hzzzzzzze_ = context.Operators.SingletonFrom<Patient>(hzzzzzzzd_);

        return hzzzzzzze_;
    }


    [CqlExpressionDefinition("isAssessmentPerformed")]
    public IEnumerable<Observation> isAssessmentPerformed(CqlContext context, IEnumerable<Observation> Obs)
    {
        bool? hzzzzzzzf_(Observation O)
        {
            Code<ObservationStatus> hzzzzzzzh_ = O?.StatusElement;
            ObservationStatus? hzzzzzzzi_ = hzzzzzzzh_?.Value;
            Code<ObservationStatus> hzzzzzzzj_ = context.Operators.Convert<Code<ObservationStatus>>(hzzzzzzzi_);
            string hzzzzzzzk_ = context.Operators.Convert<string>(hzzzzzzzj_);
            string[] hzzzzzzzl_ = [
                "final",
                "amended",
                "corrected",
            ];
            bool? hzzzzzzzm_ = context.Operators.In<string>(hzzzzzzzk_, hzzzzzzzl_ as IEnumerable<string>);
            List<CodeableConcept> hzzzzzzzn_ = O?.Category;
            CqlConcept hzzzzzzzo_(CodeableConcept @this)
            {
                CqlConcept hzzzzzzzu_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);

                return hzzzzzzzu_;
            };
            IEnumerable<CqlConcept> hzzzzzzzp_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)hzzzzzzzn_, hzzzzzzzo_);
            bool? hzzzzzzzq_(CqlConcept ObservationCategory)
            {
                CqlCode hzzzzzzzv_ = this.survey(context);
                CqlConcept hzzzzzzzw_ = context.Operators.ConvertCodeToConcept(hzzzzzzzv_);
                bool? hzzzzzzzx_ = context.Operators.Equivalent(ObservationCategory, hzzzzzzzw_);

                return hzzzzzzzx_;
            };
            IEnumerable<CqlConcept> hzzzzzzzr_ = context.Operators.Where<CqlConcept>(hzzzzzzzp_, hzzzzzzzq_);
            bool? hzzzzzzzs_ = context.Operators.Exists<CqlConcept>(hzzzzzzzr_);
            bool? hzzzzzzzt_ = context.Operators.And(hzzzzzzzm_, hzzzzzzzs_);

            return hzzzzzzzt_;
        };
        IEnumerable<Observation> hzzzzzzzg_ = context.Operators.Where<Observation>(Obs, hzzzzzzzf_);

        return hzzzzzzzg_;
    }


    [CqlExpressionDefinition("isDeviceOrder")]
    public IEnumerable<DeviceRequest> isDeviceOrder(CqlContext context, IEnumerable<DeviceRequest> DeviceRequest)
    {
        bool? hzzzzzzzy_(DeviceRequest D)
        {
            Code<RequestStatus> izzzzzzza_ = D?.StatusElement;
            RequestStatus? izzzzzzzb_ = izzzzzzza_?.Value;
            Code<RequestStatus> izzzzzzzc_ = context.Operators.Convert<Code<RequestStatus>>(izzzzzzzb_);
            string izzzzzzzd_ = context.Operators.Convert<string>(izzzzzzzc_);
            string[] izzzzzzze_ = [
                "active",
                "completed",
            ];
            bool? izzzzzzzf_ = context.Operators.In<string>(izzzzzzzd_, izzzzzzze_ as IEnumerable<string>);
            Code<RequestIntent> izzzzzzzg_ = D?.IntentElement;
            RequestIntent? izzzzzzzh_ = izzzzzzzg_?.Value;
            Code<RequestIntent> izzzzzzzi_ = context.Operators.Convert<Code<RequestIntent>>(izzzzzzzh_);
            bool? izzzzzzzj_ = context.Operators.Equal(izzzzzzzi_, "order");
            bool? izzzzzzzk_ = context.Operators.And(izzzzzzzf_, izzzzzzzj_);

            return izzzzzzzk_;
        };
        IEnumerable<DeviceRequest> hzzzzzzzz_ = context.Operators.Where<DeviceRequest>(DeviceRequest, hzzzzzzzy_);

        return hzzzzzzzz_;
    }


    [CqlExpressionDefinition("isDiagnosticStudyOrder")]
    public IEnumerable<ServiceRequest> isDiagnosticStudyOrder(CqlContext context, IEnumerable<ServiceRequest> ServiceRequest)
    {
        bool? izzzzzzzl_(ServiceRequest S)
        {
            Code<RequestStatus> izzzzzzzn_ = S?.StatusElement;
            RequestStatus? izzzzzzzo_ = izzzzzzzn_?.Value;
            Code<RequestStatus> izzzzzzzp_ = context.Operators.Convert<Code<RequestStatus>>(izzzzzzzo_);
            string izzzzzzzq_ = context.Operators.Convert<string>(izzzzzzzp_);
            string[] izzzzzzzr_ = [
                "active",
                "completed",
            ];
            bool? izzzzzzzs_ = context.Operators.In<string>(izzzzzzzq_, izzzzzzzr_ as IEnumerable<string>);
            Code<RequestIntent> izzzzzzzt_ = S?.IntentElement;
            RequestIntent? izzzzzzzu_ = izzzzzzzt_?.Value;
            Code<RequestIntent> izzzzzzzv_ = context.Operators.Convert<Code<RequestIntent>>(izzzzzzzu_);
            bool? izzzzzzzw_ = context.Operators.Equal(izzzzzzzv_, "order");
            bool? izzzzzzzx_ = context.Operators.And(izzzzzzzs_, izzzzzzzw_);

            return izzzzzzzx_;
        };
        IEnumerable<ServiceRequest> izzzzzzzm_ = context.Operators.Where<ServiceRequest>(ServiceRequest, izzzzzzzl_);

        return izzzzzzzm_;
    }


    [CqlExpressionDefinition("isInterventionOrder")]
    public IEnumerable<ServiceRequest> isInterventionOrder(CqlContext context, IEnumerable<ServiceRequest> ServiceRequest)
    {
        bool? izzzzzzzy_(ServiceRequest S)
        {
            Code<RequestStatus> jzzzzzzza_ = S?.StatusElement;
            RequestStatus? jzzzzzzzb_ = jzzzzzzza_?.Value;
            Code<RequestStatus> jzzzzzzzc_ = context.Operators.Convert<Code<RequestStatus>>(jzzzzzzzb_);
            string jzzzzzzzd_ = context.Operators.Convert<string>(jzzzzzzzc_);
            string[] jzzzzzzze_ = [
                "active",
                "completed",
            ];
            bool? jzzzzzzzf_ = context.Operators.In<string>(jzzzzzzzd_, jzzzzzzze_ as IEnumerable<string>);
            Code<RequestIntent> jzzzzzzzg_ = S?.IntentElement;
            RequestIntent? jzzzzzzzh_ = jzzzzzzzg_?.Value;
            Code<RequestIntent> jzzzzzzzi_ = context.Operators.Convert<Code<RequestIntent>>(jzzzzzzzh_);
            bool? jzzzzzzzj_ = context.Operators.Equal(jzzzzzzzi_, "order");
            bool? jzzzzzzzk_ = context.Operators.And(jzzzzzzzf_, jzzzzzzzj_);

            return jzzzzzzzk_;
        };
        IEnumerable<ServiceRequest> izzzzzzzz_ = context.Operators.Where<ServiceRequest>(ServiceRequest, izzzzzzzy_);

        return izzzzzzzz_;
    }


    [CqlExpressionDefinition("isLaboratoryTestOrder")]
    public IEnumerable<ServiceRequest> isLaboratoryTestOrder(CqlContext context, IEnumerable<ServiceRequest> ServiceRequest)
    {
        bool? jzzzzzzzl_(ServiceRequest S)
        {
            Code<RequestStatus> jzzzzzzzn_ = S?.StatusElement;
            RequestStatus? jzzzzzzzo_ = jzzzzzzzn_?.Value;
            Code<RequestStatus> jzzzzzzzp_ = context.Operators.Convert<Code<RequestStatus>>(jzzzzzzzo_);
            string jzzzzzzzq_ = context.Operators.Convert<string>(jzzzzzzzp_);
            string[] jzzzzzzzr_ = [
                "active",
                "completed",
            ];
            bool? jzzzzzzzs_ = context.Operators.In<string>(jzzzzzzzq_, jzzzzzzzr_ as IEnumerable<string>);
            Code<RequestIntent> jzzzzzzzt_ = S?.IntentElement;
            RequestIntent? jzzzzzzzu_ = jzzzzzzzt_?.Value;
            Code<RequestIntent> jzzzzzzzv_ = context.Operators.Convert<Code<RequestIntent>>(jzzzzzzzu_);
            bool? jzzzzzzzw_ = context.Operators.Equal(jzzzzzzzv_, "order");
            bool? jzzzzzzzx_ = context.Operators.And(jzzzzzzzs_, jzzzzzzzw_);

            return jzzzzzzzx_;
        };
        IEnumerable<ServiceRequest> jzzzzzzzm_ = context.Operators.Where<ServiceRequest>(ServiceRequest, jzzzzzzzl_);

        return jzzzzzzzm_;
    }


    [CqlExpressionDefinition("isDiagnosticStudyPerformed")]
    public IEnumerable<Observation> isDiagnosticStudyPerformed(CqlContext context, IEnumerable<Observation> Obs)
    {
        bool? jzzzzzzzy_(Observation O)
        {
            Code<ObservationStatus> kzzzzzzza_ = O?.StatusElement;
            ObservationStatus? kzzzzzzzb_ = kzzzzzzza_?.Value;
            Code<ObservationStatus> kzzzzzzzc_ = context.Operators.Convert<Code<ObservationStatus>>(kzzzzzzzb_);
            string kzzzzzzzd_ = context.Operators.Convert<string>(kzzzzzzzc_);
            string[] kzzzzzzze_ = [
                "final",
                "amended",
                "corrected",
            ];
            bool? kzzzzzzzf_ = context.Operators.In<string>(kzzzzzzzd_, kzzzzzzze_ as IEnumerable<string>);

            return kzzzzzzzf_;
        };
        IEnumerable<Observation> jzzzzzzzz_ = context.Operators.Where<Observation>(Obs, jzzzzzzzy_);

        return jzzzzzzzz_;
    }


    [CqlExpressionDefinition("isEncounterPerformed")]
    public IEnumerable<Encounter> isEncounterPerformed(CqlContext context, IEnumerable<Encounter> Enc)
    {
        bool? kzzzzzzzg_(Encounter E)
        {
            Code<Encounter.EncounterStatus> kzzzzzzzi_ = E?.StatusElement;
            Encounter.EncounterStatus? kzzzzzzzj_ = kzzzzzzzi_?.Value;
            Code<Encounter.EncounterStatus> kzzzzzzzk_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(kzzzzzzzj_);
            string kzzzzzzzl_ = context.Operators.Convert<string>(kzzzzzzzk_);
            string[] kzzzzzzzm_ = [
                "finished",
                "arrived",
                "triaged",
                "in-progress",
                "onleave",
            ];
            bool? kzzzzzzzn_ = context.Operators.In<string>(kzzzzzzzl_, kzzzzzzzm_ as IEnumerable<string>);

            return kzzzzzzzn_;
        };
        IEnumerable<Encounter> kzzzzzzzh_ = context.Operators.Where<Encounter>(Enc, kzzzzzzzg_);

        return kzzzzzzzh_;
    }


    [CqlExpressionDefinition("isImmunizationAdministered")]
    public IEnumerable<Immunization> isImmunizationAdministered(CqlContext context, IEnumerable<Immunization> Immunization)
    {
        bool? kzzzzzzzo_(Immunization I)
        {
            Code<Immunization.ImmunizationStatusCodes> kzzzzzzzq_ = I?.StatusElement;
            Immunization.ImmunizationStatusCodes? kzzzzzzzr_ = kzzzzzzzq_?.Value;
            string kzzzzzzzs_ = context.Operators.Convert<string>(kzzzzzzzr_);
            bool? kzzzzzzzt_ = context.Operators.Equivalent(kzzzzzzzs_, "completed");

            return kzzzzzzzt_;
        };
        IEnumerable<Immunization> kzzzzzzzp_ = context.Operators.Where<Immunization>(Immunization, kzzzzzzzo_);

        return kzzzzzzzp_;
    }


    [CqlExpressionDefinition("isInterventionPerformed")]
    public IEnumerable<Procedure> isInterventionPerformed(CqlContext context, IEnumerable<Procedure> Proc)
    {
        bool? kzzzzzzzu_(Procedure P)
        {
            Code<EventStatus> kzzzzzzzw_ = P?.StatusElement;
            EventStatus? kzzzzzzzx_ = kzzzzzzzw_?.Value;
            string kzzzzzzzy_ = context.Operators.Convert<string>(kzzzzzzzx_);
            bool? kzzzzzzzz_ = context.Operators.Equivalent(kzzzzzzzy_, "completed");

            return kzzzzzzzz_;
        };
        IEnumerable<Procedure> kzzzzzzzv_ = context.Operators.Where<Procedure>(Proc, kzzzzzzzu_);

        return kzzzzzzzv_;
    }


    [CqlExpressionDefinition("isProcedurePerformed")]
    public IEnumerable<Procedure> isProcedurePerformed(CqlContext context, IEnumerable<Procedure> Proc)
    {
        bool? lzzzzzzza_(Procedure P)
        {
            Code<EventStatus> lzzzzzzzc_ = P?.StatusElement;
            EventStatus? lzzzzzzzd_ = lzzzzzzzc_?.Value;
            string lzzzzzzze_ = context.Operators.Convert<string>(lzzzzzzzd_);
            bool? lzzzzzzzf_ = context.Operators.Equivalent(lzzzzzzze_, "completed");

            return lzzzzzzzf_;
        };
        IEnumerable<Procedure> lzzzzzzzb_ = context.Operators.Where<Procedure>(Proc, lzzzzzzza_);

        return lzzzzzzzb_;
    }


    [CqlExpressionDefinition("isLaboratoryTestPerformed")]
    public IEnumerable<Observation> isLaboratoryTestPerformed(CqlContext context, IEnumerable<Observation> Obs)
    {
        bool? lzzzzzzzg_(Observation O)
        {
            Code<ObservationStatus> lzzzzzzzi_ = O?.StatusElement;
            ObservationStatus? lzzzzzzzj_ = lzzzzzzzi_?.Value;
            Code<ObservationStatus> lzzzzzzzk_ = context.Operators.Convert<Code<ObservationStatus>>(lzzzzzzzj_);
            string lzzzzzzzl_ = context.Operators.Convert<string>(lzzzzzzzk_);
            string[] lzzzzzzzm_ = [
                "final",
                "amended",
                "corrected",
            ];
            bool? lzzzzzzzn_ = context.Operators.In<string>(lzzzzzzzl_, lzzzzzzzm_ as IEnumerable<string>);
            List<CodeableConcept> lzzzzzzzo_ = O?.Category;
            CqlConcept lzzzzzzzp_(CodeableConcept @this)
            {
                CqlConcept lzzzzzzzv_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);

                return lzzzzzzzv_;
            };
            IEnumerable<CqlConcept> lzzzzzzzq_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)lzzzzzzzo_, lzzzzzzzp_);
            bool? lzzzzzzzr_(CqlConcept ObservationCategory)
            {
                CqlCode lzzzzzzzw_ = this.laboratory(context);
                CqlConcept lzzzzzzzx_ = context.Operators.ConvertCodeToConcept(lzzzzzzzw_);
                bool? lzzzzzzzy_ = context.Operators.Equivalent(ObservationCategory, lzzzzzzzx_);

                return lzzzzzzzy_;
            };
            IEnumerable<CqlConcept> lzzzzzzzs_ = context.Operators.Where<CqlConcept>(lzzzzzzzq_, lzzzzzzzr_);
            bool? lzzzzzzzt_ = context.Operators.Exists<CqlConcept>(lzzzzzzzs_);
            bool? lzzzzzzzu_ = context.Operators.And(lzzzzzzzn_, lzzzzzzzt_);

            return lzzzzzzzu_;
        };
        IEnumerable<Observation> lzzzzzzzh_ = context.Operators.Where<Observation>(Obs, lzzzzzzzg_);

        return lzzzzzzzh_;
    }


    [CqlExpressionDefinition("isMedicationActive")]
    public IEnumerable<MedicationRequest> isMedicationActive(CqlContext context, IEnumerable<MedicationRequest> MedicationRequest)
    {
        bool? lzzzzzzzz_(MedicationRequest M)
        {
            Code<MedicationRequest.MedicationrequestStatus> mzzzzzzzb_ = M?.StatusElement;
            MedicationRequest.MedicationrequestStatus? mzzzzzzzc_ = mzzzzzzzb_?.Value;
            string mzzzzzzzd_ = context.Operators.Convert<string>(mzzzzzzzc_);
            bool? mzzzzzzze_ = context.Operators.Equal(mzzzzzzzd_, "active");
            Code<MedicationRequest.MedicationRequestIntent> mzzzzzzzf_ = M?.IntentElement;
            MedicationRequest.MedicationRequestIntent? mzzzzzzzg_ = mzzzzzzzf_?.Value;
            string mzzzzzzzh_ = context.Operators.Convert<string>(mzzzzzzzg_);
            bool? mzzzzzzzi_ = context.Operators.Equal(mzzzzzzzh_, "order");
            bool? mzzzzzzzj_ = context.Operators.And(mzzzzzzze_, mzzzzzzzi_);

            return mzzzzzzzj_;
        };
        IEnumerable<MedicationRequest> mzzzzzzza_ = context.Operators.Where<MedicationRequest>(MedicationRequest, lzzzzzzzz_);

        return mzzzzzzza_;
    }


    [CqlExpressionDefinition("isMedicationDispensed")]
    public IEnumerable<MedicationDispense> isMedicationDispensed(CqlContext context, IEnumerable<MedicationDispense> Med)
    {
        bool? mzzzzzzzk_(MedicationDispense M)
        {
            Code<MedicationDispense.MedicationDispenseStatusCodes> mzzzzzzzm_ = M?.StatusElement;
            MedicationDispense.MedicationDispenseStatusCodes? mzzzzzzzn_ = mzzzzzzzm_?.Value;
            Code<MedicationDispense.MedicationDispenseStatusCodes> mzzzzzzzo_ = context.Operators.Convert<Code<MedicationDispense.MedicationDispenseStatusCodes>>(mzzzzzzzn_);
            string mzzzzzzzp_ = context.Operators.Convert<string>(mzzzzzzzo_);
            string[] mzzzzzzzq_ = [
                "completed",
                "in-progress",
                "on-hold",
            ];
            bool? mzzzzzzzr_ = context.Operators.In<string>(mzzzzzzzp_, mzzzzzzzq_ as IEnumerable<string>);

            return mzzzzzzzr_;
        };
        IEnumerable<MedicationDispense> mzzzzzzzl_ = context.Operators.Where<MedicationDispense>(Med, mzzzzzzzk_);

        return mzzzzzzzl_;
    }


    [CqlExpressionDefinition("isMedicationOrder")]
    public IEnumerable<MedicationRequest> isMedicationOrder(CqlContext context, IEnumerable<MedicationRequest> MedicationRequest)
    {
        bool? mzzzzzzzs_(MedicationRequest M)
        {
            Code<MedicationRequest.MedicationrequestStatus> mzzzzzzzu_ = M?.StatusElement;
            MedicationRequest.MedicationrequestStatus? mzzzzzzzv_ = mzzzzzzzu_?.Value;
            string mzzzzzzzw_ = context.Operators.Convert<string>(mzzzzzzzv_);
            string[] mzzzzzzzx_ = [
                "active",
                "completed",
            ];
            bool? mzzzzzzzy_ = context.Operators.In<string>(mzzzzzzzw_, mzzzzzzzx_ as IEnumerable<string>);
            Code<MedicationRequest.MedicationRequestIntent> mzzzzzzzz_ = M?.IntentElement;
            MedicationRequest.MedicationRequestIntent? nzzzzzzza_ = mzzzzzzzz_?.Value;
            string nzzzzzzzb_ = context.Operators.Convert<string>(nzzzzzzza_);
            bool? nzzzzzzzc_ = context.Operators.Equal(nzzzzzzzb_, "order");
            bool? nzzzzzzzd_ = context.Operators.And(mzzzzzzzy_, nzzzzzzzc_);

            return nzzzzzzzd_;
        };
        IEnumerable<MedicationRequest> mzzzzzzzt_ = context.Operators.Where<MedicationRequest>(MedicationRequest, mzzzzzzzs_);

        return mzzzzzzzt_;
    }


    [CqlExpressionDefinition("isPhysicalExamPerformed")]
    public IEnumerable<Observation> isPhysicalExamPerformed(CqlContext context, IEnumerable<Observation> Obs)
    {
        bool? nzzzzzzze_(Observation O)
        {
            Code<ObservationStatus> nzzzzzzzg_ = O?.StatusElement;
            ObservationStatus? nzzzzzzzh_ = nzzzzzzzg_?.Value;
            Code<ObservationStatus> nzzzzzzzi_ = context.Operators.Convert<Code<ObservationStatus>>(nzzzzzzzh_);
            string nzzzzzzzj_ = context.Operators.Convert<string>(nzzzzzzzi_);
            string[] nzzzzzzzk_ = [
                "final",
                "amended",
                "corrected",
            ];
            bool? nzzzzzzzl_ = context.Operators.In<string>(nzzzzzzzj_, nzzzzzzzk_ as IEnumerable<string>);
            List<CodeableConcept> nzzzzzzzm_ = O?.Category;
            CqlConcept nzzzzzzzn_(CodeableConcept @this)
            {
                CqlConcept nzzzzzzzt_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);

                return nzzzzzzzt_;
            };
            IEnumerable<CqlConcept> nzzzzzzzo_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)nzzzzzzzm_, nzzzzzzzn_);
            bool? nzzzzzzzp_(CqlConcept ObservationCategory)
            {
                CqlCode nzzzzzzzu_ = this.exam(context);
                CqlConcept nzzzzzzzv_ = context.Operators.ConvertCodeToConcept(nzzzzzzzu_);
                bool? nzzzzzzzw_ = context.Operators.Equivalent(ObservationCategory, nzzzzzzzv_);

                return nzzzzzzzw_;
            };
            IEnumerable<CqlConcept> nzzzzzzzq_ = context.Operators.Where<CqlConcept>(nzzzzzzzo_, nzzzzzzzp_);
            bool? nzzzzzzzr_ = context.Operators.Exists<CqlConcept>(nzzzzzzzq_);
            bool? nzzzzzzzs_ = context.Operators.And(nzzzzzzzl_, nzzzzzzzr_);

            return nzzzzzzzs_;
        };
        IEnumerable<Observation> nzzzzzzzf_ = context.Operators.Where<Observation>(Obs, nzzzzzzze_);

        return nzzzzzzzf_;
    }


    [CqlExpressionDefinition("isObservationBP")]
    public IEnumerable<Observation> isObservationBP(CqlContext context, IEnumerable<Observation> Obs)
    {
        bool? nzzzzzzzx_(Observation O)
        {
            Code<ObservationStatus> nzzzzzzzz_ = O?.StatusElement;
            ObservationStatus? ozzzzzzza_ = nzzzzzzzz_?.Value;
            string ozzzzzzzb_ = context.Operators.Convert<string>(ozzzzzzza_);
            string[] ozzzzzzzc_ = [
                "final",
                "amended",
                "corrected",
            ];
            bool? ozzzzzzzd_ = context.Operators.In<string>(ozzzzzzzb_, ozzzzzzzc_ as IEnumerable<string>);

            return ozzzzzzzd_;
        };
        IEnumerable<Observation> nzzzzzzzy_ = context.Operators.Where<Observation>(Obs, nzzzzzzzx_);

        return nzzzzzzzy_;
    }


    [CqlExpressionDefinition("isObservationBodyHeight")]
    public IEnumerable<Observation> isObservationBodyHeight(CqlContext context, IEnumerable<Observation> Obs)
    {
        bool? ozzzzzzze_(Observation O)
        {
            Code<ObservationStatus> ozzzzzzzg_ = O?.StatusElement;
            ObservationStatus? ozzzzzzzh_ = ozzzzzzzg_?.Value;
            string ozzzzzzzi_ = context.Operators.Convert<string>(ozzzzzzzh_);
            string[] ozzzzzzzj_ = [
                "final",
                "amended",
                "corrected",
            ];
            bool? ozzzzzzzk_ = context.Operators.In<string>(ozzzzzzzi_, ozzzzzzzj_ as IEnumerable<string>);

            return ozzzzzzzk_;
        };
        IEnumerable<Observation> ozzzzzzzf_ = context.Operators.Where<Observation>(Obs, ozzzzzzze_);

        return ozzzzzzzf_;
    }


    [CqlExpressionDefinition("isObservationBodyWeight")]
    public IEnumerable<Observation> isObservationBodyWeight(CqlContext context, IEnumerable<Observation> Obs)
    {
        bool? ozzzzzzzl_(Observation O)
        {
            Code<ObservationStatus> ozzzzzzzn_ = O?.StatusElement;
            ObservationStatus? ozzzzzzzo_ = ozzzzzzzn_?.Value;
            string ozzzzzzzp_ = context.Operators.Convert<string>(ozzzzzzzo_);
            string[] ozzzzzzzq_ = [
                "final",
                "amended",
                "corrected",
            ];
            bool? ozzzzzzzr_ = context.Operators.In<string>(ozzzzzzzp_, ozzzzzzzq_ as IEnumerable<string>);

            return ozzzzzzzr_;
        };
        IEnumerable<Observation> ozzzzzzzm_ = context.Operators.Where<Observation>(Obs, ozzzzzzzl_);

        return ozzzzzzzm_;
    }


    [CqlExpressionDefinition("isObservationBMI")]
    public IEnumerable<Observation> isObservationBMI(CqlContext context, IEnumerable<Observation> Obs)
    {
        bool? ozzzzzzzs_(Observation O)
        {
            Code<ObservationStatus> ozzzzzzzu_ = O?.StatusElement;
            ObservationStatus? ozzzzzzzv_ = ozzzzzzzu_?.Value;
            string ozzzzzzzw_ = context.Operators.Convert<string>(ozzzzzzzv_);
            string[] ozzzzzzzx_ = [
                "final",
                "amended",
                "corrected",
            ];
            bool? ozzzzzzzy_ = context.Operators.In<string>(ozzzzzzzw_, ozzzzzzzx_ as IEnumerable<string>);

            return ozzzzzzzy_;
        };
        IEnumerable<Observation> ozzzzzzzt_ = context.Operators.Where<Observation>(Obs, ozzzzzzzs_);

        return ozzzzzzzt_;
    }


    [CqlExpressionDefinition("isSymptom")]
    public IEnumerable<Observation> isSymptom(CqlContext context, IEnumerable<Observation> Obs)
    {
        bool? ozzzzzzzz_(Observation O)
        {
            Code<ObservationStatus> pzzzzzzzb_ = O?.StatusElement;
            ObservationStatus? pzzzzzzzc_ = pzzzzzzzb_?.Value;
            Code<ObservationStatus> pzzzzzzzd_ = context.Operators.Convert<Code<ObservationStatus>>(pzzzzzzzc_);
            string pzzzzzzze_ = context.Operators.Convert<string>(pzzzzzzzd_);
            string[] pzzzzzzzf_ = [
                "preliminary",
                "final",
                "amended",
                "corrected",
            ];
            bool? pzzzzzzzg_ = context.Operators.In<string>(pzzzzzzze_, pzzzzzzzf_ as IEnumerable<string>);

            return pzzzzzzzg_;
        };
        IEnumerable<Observation> pzzzzzzza_ = context.Operators.Where<Observation>(Obs, ozzzzzzzz_);

        return pzzzzzzza_;
    }


    #endregion Expressions

}
