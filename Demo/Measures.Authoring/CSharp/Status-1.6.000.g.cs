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

    #region Code: vital-signs
    [CqlCodeDefinition(
        definitionName: "vital-signs",
        codeId: "vital-signs",
        codeSystem: "http://terminology.hl7.org/CodeSystem/observation-category")]
    public CqlCode vital_signs(CqlContext context) => _vital_signs;

    private static readonly CqlCode _vital_signs = new CqlCode("vital-signs", "http://terminology.hl7.org/CodeSystem/observation-category", default, default);
    #endregion

    #region Code: active
    [CqlCodeDefinition(
        definitionName: "active",
        codeId: "active",
        codeSystem: "http://terminology.hl7.org/CodeSystem/condition-clinical")]
    public CqlCode active(CqlContext context) => _active;

    private static readonly CqlCode _active = new CqlCode("active", "http://terminology.hl7.org/CodeSystem/condition-clinical", default, default);
    #endregion

    #endregion Codes

    #region CodeSystems

    [CqlCodeSystemDefinition(
        definitionName: "ObservationCategoryCodes")]
    public CqlCode[] ObservationCategoryCodes(CqlContext context)
    {
        CqlCode[] czr_ = [
            new CqlCode("laboratory", "http://terminology.hl7.org/CodeSystem/observation-category", default, default),
            new CqlCode("exam", "http://terminology.hl7.org/CodeSystem/observation-category", default, default),
            new CqlCode("survey", "http://terminology.hl7.org/CodeSystem/observation-category", default, default),
            new CqlCode("vital-signs", "http://terminology.hl7.org/CodeSystem/observation-category", default, default),
        ];

        return czr_;
    }


    [CqlCodeSystemDefinition(
        definitionName: "ConditionClinicalStatusCodes")]
    public CqlCode[] ConditionClinicalStatusCodes(CqlContext context)
    {
        CqlCode[] czs_ = [
            new CqlCode("active", "http://terminology.hl7.org/CodeSystem/condition-clinical", default, default),
        ];

        return czs_;
    }


    #endregion CodeSystems

    #region Expressions

    [CqlExpressionDefinition(
        definitionName: "Patient")]
    public Patient Patient(CqlContext context)
    {
        IEnumerable<Patient> czt_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-patient"));
        Patient czu_ = context.Operators.SingletonFrom<Patient>(czt_);

        return czu_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public IEnumerable<Observation> Final_Survey_Observation(CqlContext context, IEnumerable<Observation> Obs)
    {
        bool? czv_(Observation O)
        {
            Code<ObservationStatus> czx_ = O?.StatusElement;
            ObservationStatus? czy_ = czx_?.Value;
            Code<ObservationStatus> czz_ = context.Operators.Convert<Code<ObservationStatus>>(czy_);
            string dza_ = context.Operators.Convert<string>(czz_);
            string[] dzb_ = [
                "final",
                "amended",
                "corrected",
            ];
            bool? dzc_ = context.Operators.In<string>(dza_, dzb_ as IEnumerable<string>);
            List<CodeableConcept> dzd_ = O?.Category;
            CqlConcept dze_(CodeableConcept @this)
            {
                CqlConcept dzk_ = FHIRHelpers_4_3_000.Instance.ToConcept(context, @this);

                return dzk_;
            };
            IEnumerable<CqlConcept> dzf_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)dzd_, dze_);
            bool? dzg_(CqlConcept ObservationCategory)
            {
                CqlCode dzl_ = this.survey(context);
                CqlConcept dzm_ = context.Operators.ConvertCodeToConcept(dzl_);
                bool? dzn_ = context.Operators.Equivalent(ObservationCategory, dzm_);

                return dzn_;
            };
            IEnumerable<CqlConcept> dzh_ = context.Operators.Where<CqlConcept>(dzf_, dzg_);
            bool? dzi_ = context.Operators.Exists<CqlConcept>(dzh_);
            bool? dzj_ = context.Operators.And(dzc_, dzi_);

            return dzj_;
        };
        IEnumerable<Observation> czw_ = context.Operators.Where<Observation>(Obs, czv_);

        return czw_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public IEnumerable<Observation> isAssessmentPerformed(CqlContext context, IEnumerable<Observation> Obs)
    {
        bool? dzo_(Observation O)
        {
            Code<ObservationStatus> dzq_ = O?.StatusElement;
            ObservationStatus? dzr_ = dzq_?.Value;
            Code<ObservationStatus> dzs_ = context.Operators.Convert<Code<ObservationStatus>>(dzr_);
            string dzt_ = context.Operators.Convert<string>(dzs_);
            string[] dzu_ = [
                "final",
                "amended",
                "corrected",
            ];
            bool? dzv_ = context.Operators.In<string>(dzt_, dzu_ as IEnumerable<string>);
            List<CodeableConcept> dzw_ = O?.Category;
            CqlConcept dzx_(CodeableConcept @this)
            {
                CqlConcept ezd_ = FHIRHelpers_4_3_000.Instance.ToConcept(context, @this);

                return ezd_;
            };
            IEnumerable<CqlConcept> dzy_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)dzw_, dzx_);
            bool? dzz_(CqlConcept ObservationCategory)
            {
                CqlCode eze_ = this.survey(context);
                CqlConcept ezf_ = context.Operators.ConvertCodeToConcept(eze_);
                bool? ezg_ = context.Operators.Equivalent(ObservationCategory, ezf_);

                return ezg_;
            };
            IEnumerable<CqlConcept> eza_ = context.Operators.Where<CqlConcept>(dzy_, dzz_);
            bool? ezb_ = context.Operators.Exists<CqlConcept>(eza_);
            bool? ezc_ = context.Operators.And(dzv_, ezb_);

            return ezc_;
        };
        IEnumerable<Observation> dzp_ = context.Operators.Where<Observation>(Obs, dzo_);

        return dzp_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public IEnumerable<Condition> Active_Condition(CqlContext context, IEnumerable<Condition> Condition)
    {
        bool? ezh_(Condition C)
        {
            CodeableConcept ezj_ = C?.ClinicalStatus;
            CqlConcept ezk_ = FHIRHelpers_4_3_000.Instance.ToConcept(context, ezj_);
            CqlCode ezl_ = this.active(context);
            CqlConcept ezm_ = context.Operators.ConvertCodeToConcept(ezl_);
            bool? ezn_ = context.Operators.Equivalent(ezk_, ezm_);

            return ezn_;
        };
        IEnumerable<Condition> ezi_ = context.Operators.Where<Condition>(Condition, ezh_);

        return ezi_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public IEnumerable<Condition> isActiveOnly(CqlContext context, IEnumerable<Condition> Condition)
    {
        bool? ezo_(Condition C)
        {
            CodeableConcept ezq_ = C?.ClinicalStatus;
            CqlConcept ezr_ = FHIRHelpers_4_3_000.Instance.ToConcept(context, ezq_);
            CqlCode ezs_ = this.active(context);
            CqlConcept ezt_ = context.Operators.ConvertCodeToConcept(ezs_);
            bool? ezu_ = context.Operators.Equivalent(ezr_, ezt_);

            return ezu_;
        };
        IEnumerable<Condition> ezp_ = context.Operators.Where<Condition>(Condition, ezo_);

        return ezp_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public IEnumerable<DeviceRequest> Completed_or_Ongoing_Device_Request(CqlContext context, IEnumerable<DeviceRequest> DeviceRequest)
    {
        bool? ezv_(DeviceRequest D)
        {
            Code<RequestStatus> ezx_ = D?.StatusElement;
            RequestStatus? ezy_ = ezx_?.Value;
            Code<RequestStatus> ezz_ = context.Operators.Convert<Code<RequestStatus>>(ezy_);
            string fza_ = context.Operators.Convert<string>(ezz_);
            string[] fzb_ = [
                "active",
                "completed",
            ];
            bool? fzc_ = context.Operators.In<string>(fza_, fzb_ as IEnumerable<string>);
            Code<RequestIntent> fzd_ = D?.IntentElement;
            RequestIntent? fze_ = fzd_?.Value;
            Code<RequestIntent> fzf_ = context.Operators.Convert<Code<RequestIntent>>(fze_);
            bool? fzg_ = context.Operators.Equal(fzf_, "order");
            bool? fzh_ = context.Operators.And(fzc_, fzg_);

            return fzh_;
        };
        IEnumerable<DeviceRequest> ezw_ = context.Operators.Where<DeviceRequest>(DeviceRequest, ezv_);

        return ezw_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public IEnumerable<DeviceRequest> isDeviceOrder(CqlContext context, IEnumerable<DeviceRequest> DeviceRequest)
    {
        bool? fzi_(DeviceRequest D)
        {
            Code<RequestStatus> fzk_ = D?.StatusElement;
            RequestStatus? fzl_ = fzk_?.Value;
            Code<RequestStatus> fzm_ = context.Operators.Convert<Code<RequestStatus>>(fzl_);
            string fzn_ = context.Operators.Convert<string>(fzm_);
            string[] fzo_ = [
                "active",
                "completed",
            ];
            bool? fzp_ = context.Operators.In<string>(fzn_, fzo_ as IEnumerable<string>);
            Code<RequestIntent> fzq_ = D?.IntentElement;
            RequestIntent? fzr_ = fzq_?.Value;
            Code<RequestIntent> fzs_ = context.Operators.Convert<Code<RequestIntent>>(fzr_);
            bool? fzt_ = context.Operators.Equal(fzs_, "order");
            bool? fzu_ = context.Operators.And(fzp_, fzt_);

            return fzu_;
        };
        IEnumerable<DeviceRequest> fzj_ = context.Operators.Where<DeviceRequest>(DeviceRequest, fzi_);

        return fzj_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public IEnumerable<ServiceRequest> Completed_or_Ongoing_Service_Request(CqlContext context, IEnumerable<ServiceRequest> ServiceRequest)
    {
        bool? fzv_(ServiceRequest S)
        {
            Code<RequestStatus> fzx_ = S?.StatusElement;
            RequestStatus? fzy_ = fzx_?.Value;
            Code<RequestStatus> fzz_ = context.Operators.Convert<Code<RequestStatus>>(fzy_);
            string gza_ = context.Operators.Convert<string>(fzz_);
            string[] gzb_ = [
                "active",
                "completed",
            ];
            bool? gzc_ = context.Operators.In<string>(gza_, gzb_ as IEnumerable<string>);
            Code<RequestIntent> gzd_ = S?.IntentElement;
            RequestIntent? gze_ = gzd_?.Value;
            Code<RequestIntent> gzf_ = context.Operators.Convert<Code<RequestIntent>>(gze_);
            bool? gzg_ = context.Operators.Equal(gzf_, "order");
            bool? gzh_ = context.Operators.And(gzc_, gzg_);

            return gzh_;
        };
        IEnumerable<ServiceRequest> fzw_ = context.Operators.Where<ServiceRequest>(ServiceRequest, fzv_);

        return fzw_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public IEnumerable<ServiceRequest> isDiagnosticStudyOrder(CqlContext context, IEnumerable<ServiceRequest> ServiceRequest)
    {
        bool? gzi_(ServiceRequest S)
        {
            Code<RequestStatus> gzk_ = S?.StatusElement;
            RequestStatus? gzl_ = gzk_?.Value;
            Code<RequestStatus> gzm_ = context.Operators.Convert<Code<RequestStatus>>(gzl_);
            string gzn_ = context.Operators.Convert<string>(gzm_);
            string[] gzo_ = [
                "active",
                "completed",
            ];
            bool? gzp_ = context.Operators.In<string>(gzn_, gzo_ as IEnumerable<string>);
            Code<RequestIntent> gzq_ = S?.IntentElement;
            RequestIntent? gzr_ = gzq_?.Value;
            Code<RequestIntent> gzs_ = context.Operators.Convert<Code<RequestIntent>>(gzr_);
            bool? gzt_ = context.Operators.Equal(gzs_, "order");
            bool? gzu_ = context.Operators.And(gzp_, gzt_);

            return gzu_;
        };
        IEnumerable<ServiceRequest> gzj_ = context.Operators.Where<ServiceRequest>(ServiceRequest, gzi_);

        return gzj_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public IEnumerable<ServiceRequest> isInterventionOrder(CqlContext context, IEnumerable<ServiceRequest> ServiceRequest)
    {
        bool? gzv_(ServiceRequest S)
        {
            Code<RequestStatus> gzx_ = S?.StatusElement;
            RequestStatus? gzy_ = gzx_?.Value;
            Code<RequestStatus> gzz_ = context.Operators.Convert<Code<RequestStatus>>(gzy_);
            string hza_ = context.Operators.Convert<string>(gzz_);
            string[] hzb_ = [
                "active",
                "completed",
            ];
            bool? hzc_ = context.Operators.In<string>(hza_, hzb_ as IEnumerable<string>);
            Code<RequestIntent> hzd_ = S?.IntentElement;
            RequestIntent? hze_ = hzd_?.Value;
            Code<RequestIntent> hzf_ = context.Operators.Convert<Code<RequestIntent>>(hze_);
            bool? hzg_ = context.Operators.Equal(hzf_, "order");
            bool? hzh_ = context.Operators.And(hzc_, hzg_);

            return hzh_;
        };
        IEnumerable<ServiceRequest> gzw_ = context.Operators.Where<ServiceRequest>(ServiceRequest, gzv_);

        return gzw_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public IEnumerable<ServiceRequest> isLaboratoryTestOrder(CqlContext context, IEnumerable<ServiceRequest> ServiceRequest)
    {
        bool? hzi_(ServiceRequest S)
        {
            Code<RequestStatus> hzk_ = S?.StatusElement;
            RequestStatus? hzl_ = hzk_?.Value;
            Code<RequestStatus> hzm_ = context.Operators.Convert<Code<RequestStatus>>(hzl_);
            string hzn_ = context.Operators.Convert<string>(hzm_);
            string[] hzo_ = [
                "active",
                "completed",
            ];
            bool? hzp_ = context.Operators.In<string>(hzn_, hzo_ as IEnumerable<string>);
            Code<RequestIntent> hzq_ = S?.IntentElement;
            RequestIntent? hzr_ = hzq_?.Value;
            Code<RequestIntent> hzs_ = context.Operators.Convert<Code<RequestIntent>>(hzr_);
            bool? hzt_ = context.Operators.Equal(hzs_, "order");
            bool? hzu_ = context.Operators.And(hzp_, hzt_);

            return hzu_;
        };
        IEnumerable<ServiceRequest> hzj_ = context.Operators.Where<ServiceRequest>(ServiceRequest, hzi_);

        return hzj_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public IEnumerable<Observation> Final_Observation(CqlContext context, IEnumerable<Observation> Obs)
    {
        bool? hzv_(Observation O)
        {
            Code<ObservationStatus> hzx_ = O?.StatusElement;
            ObservationStatus? hzy_ = hzx_?.Value;
            Code<ObservationStatus> hzz_ = context.Operators.Convert<Code<ObservationStatus>>(hzy_);
            string iza_ = context.Operators.Convert<string>(hzz_);
            string[] izb_ = [
                "final",
                "amended",
                "corrected",
            ];
            bool? izc_ = context.Operators.In<string>(iza_, izb_ as IEnumerable<string>);

            return izc_;
        };
        IEnumerable<Observation> hzw_ = context.Operators.Where<Observation>(Obs, hzv_);

        return hzw_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public IEnumerable<Observation> isDiagnosticStudyPerformed(CqlContext context, IEnumerable<Observation> Obs)
    {
        bool? izd_(Observation O)
        {
            Code<ObservationStatus> izf_ = O?.StatusElement;
            ObservationStatus? izg_ = izf_?.Value;
            Code<ObservationStatus> izh_ = context.Operators.Convert<Code<ObservationStatus>>(izg_);
            string izi_ = context.Operators.Convert<string>(izh_);
            string[] izj_ = [
                "final",
                "amended",
                "corrected",
            ];
            bool? izk_ = context.Operators.In<string>(izi_, izj_ as IEnumerable<string>);

            return izk_;
        };
        IEnumerable<Observation> ize_ = context.Operators.Where<Observation>(Obs, izd_);

        return ize_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public IEnumerable<Encounter> Finished_Encounter(CqlContext context, IEnumerable<Encounter> Enc)
    {
        bool? izl_(Encounter E)
        {
            Code<Encounter.EncounterStatus> izn_ = E?.StatusElement;
            Encounter.EncounterStatus? izo_ = izn_?.Value;
            Code<Encounter.EncounterStatus> izp_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(izo_);
            string izq_ = context.Operators.Convert<string>(izp_);
            string[] izr_ = [
                "finished",
                "arrived",
                "triaged",
                "in-progress",
                "onleave",
            ];
            bool? izs_ = context.Operators.In<string>(izq_, izr_ as IEnumerable<string>);

            return izs_;
        };
        IEnumerable<Encounter> izm_ = context.Operators.Where<Encounter>(Enc, izl_);

        return izm_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public IEnumerable<Encounter> isEncounterPerformed(CqlContext context, IEnumerable<Encounter> Enc)
    {
        bool? izt_(Encounter E)
        {
            Code<Encounter.EncounterStatus> izv_ = E?.StatusElement;
            Encounter.EncounterStatus? izw_ = izv_?.Value;
            Code<Encounter.EncounterStatus> izx_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(izw_);
            string izy_ = context.Operators.Convert<string>(izx_);
            string[] izz_ = [
                "finished",
                "arrived",
                "triaged",
                "in-progress",
                "onleave",
            ];
            bool? jza_ = context.Operators.In<string>(izy_, izz_ as IEnumerable<string>);

            return jza_;
        };
        IEnumerable<Encounter> izu_ = context.Operators.Where<Encounter>(Enc, izt_);

        return izu_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public IEnumerable<Immunization> Completed_Immunization(CqlContext context, IEnumerable<Immunization> Immunization)
    {
        bool? jzb_(Immunization I)
        {
            Code<Immunization.ImmunizationStatusCodes> jzd_ = I?.StatusElement;
            Immunization.ImmunizationStatusCodes? jze_ = jzd_?.Value;
            string jzf_ = context.Operators.Convert<string>(jze_);
            bool? jzg_ = context.Operators.Equivalent(jzf_, "completed");

            return jzg_;
        };
        IEnumerable<Immunization> jzc_ = context.Operators.Where<Immunization>(Immunization, jzb_);

        return jzc_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public IEnumerable<Immunization> isImmunizationAdministered(CqlContext context, IEnumerable<Immunization> Immunization)
    {
        bool? jzh_(Immunization I)
        {
            Code<Immunization.ImmunizationStatusCodes> jzj_ = I?.StatusElement;
            Immunization.ImmunizationStatusCodes? jzk_ = jzj_?.Value;
            string jzl_ = context.Operators.Convert<string>(jzk_);
            bool? jzm_ = context.Operators.Equivalent(jzl_, "completed");

            return jzm_;
        };
        IEnumerable<Immunization> jzi_ = context.Operators.Where<Immunization>(Immunization, jzh_);

        return jzi_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public IEnumerable<Procedure> Completed_Procedure(CqlContext context, IEnumerable<Procedure> Proc)
    {
        bool? jzn_(Procedure P)
        {
            Code<EventStatus> jzp_ = P?.StatusElement;
            EventStatus? jzq_ = jzp_?.Value;
            string jzr_ = context.Operators.Convert<string>(jzq_);
            bool? jzs_ = context.Operators.Equivalent(jzr_, "completed");

            return jzs_;
        };
        IEnumerable<Procedure> jzo_ = context.Operators.Where<Procedure>(Proc, jzn_);

        return jzo_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public IEnumerable<Procedure> isInterventionPerformed(CqlContext context, IEnumerable<Procedure> Proc)
    {
        bool? jzt_(Procedure P)
        {
            Code<EventStatus> jzv_ = P?.StatusElement;
            EventStatus? jzw_ = jzv_?.Value;
            string jzx_ = context.Operators.Convert<string>(jzw_);
            bool? jzy_ = context.Operators.Equivalent(jzx_, "completed");

            return jzy_;
        };
        IEnumerable<Procedure> jzu_ = context.Operators.Where<Procedure>(Proc, jzt_);

        return jzu_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public IEnumerable<Procedure> isProcedurePerformed(CqlContext context, IEnumerable<Procedure> Proc)
    {
        bool? jzz_(Procedure P)
        {
            Code<EventStatus> kzb_ = P?.StatusElement;
            EventStatus? kzc_ = kzb_?.Value;
            string kzd_ = context.Operators.Convert<string>(kzc_);
            bool? kze_ = context.Operators.Equivalent(kzd_, "completed");

            return kze_;
        };
        IEnumerable<Procedure> kza_ = context.Operators.Where<Procedure>(Proc, jzz_);

        return kza_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public IEnumerable<Observation> Final_Lab_Observation(CqlContext context, IEnumerable<Observation> Obs)
    {
        bool? kzf_(Observation O)
        {
            Code<ObservationStatus> kzh_ = O?.StatusElement;
            ObservationStatus? kzi_ = kzh_?.Value;
            Code<ObservationStatus> kzj_ = context.Operators.Convert<Code<ObservationStatus>>(kzi_);
            string kzk_ = context.Operators.Convert<string>(kzj_);
            string[] kzl_ = [
                "final",
                "amended",
                "corrected",
            ];
            bool? kzm_ = context.Operators.In<string>(kzk_, kzl_ as IEnumerable<string>);
            List<CodeableConcept> kzn_ = O?.Category;
            CqlConcept kzo_(CodeableConcept @this)
            {
                CqlConcept kzu_ = FHIRHelpers_4_3_000.Instance.ToConcept(context, @this);

                return kzu_;
            };
            IEnumerable<CqlConcept> kzp_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)kzn_, kzo_);
            bool? kzq_(CqlConcept ObservationCategory)
            {
                CqlCode kzv_ = this.laboratory(context);
                CqlConcept kzw_ = context.Operators.ConvertCodeToConcept(kzv_);
                bool? kzx_ = context.Operators.Equivalent(ObservationCategory, kzw_);

                return kzx_;
            };
            IEnumerable<CqlConcept> kzr_ = context.Operators.Where<CqlConcept>(kzp_, kzq_);
            bool? kzs_ = context.Operators.Exists<CqlConcept>(kzr_);
            bool? kzt_ = context.Operators.And(kzm_, kzs_);

            return kzt_;
        };
        IEnumerable<Observation> kzg_ = context.Operators.Where<Observation>(Obs, kzf_);

        return kzg_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public IEnumerable<Observation> isLaboratoryTestPerformed(CqlContext context, IEnumerable<Observation> Obs)
    {
        bool? kzy_(Observation O)
        {
            Code<ObservationStatus> lza_ = O?.StatusElement;
            ObservationStatus? lzb_ = lza_?.Value;
            Code<ObservationStatus> lzc_ = context.Operators.Convert<Code<ObservationStatus>>(lzb_);
            string lzd_ = context.Operators.Convert<string>(lzc_);
            string[] lze_ = [
                "final",
                "amended",
                "corrected",
            ];
            bool? lzf_ = context.Operators.In<string>(lzd_, lze_ as IEnumerable<string>);
            List<CodeableConcept> lzg_ = O?.Category;
            CqlConcept lzh_(CodeableConcept @this)
            {
                CqlConcept lzn_ = FHIRHelpers_4_3_000.Instance.ToConcept(context, @this);

                return lzn_;
            };
            IEnumerable<CqlConcept> lzi_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)lzg_, lzh_);
            bool? lzj_(CqlConcept ObservationCategory)
            {
                CqlCode lzo_ = this.laboratory(context);
                CqlConcept lzp_ = context.Operators.ConvertCodeToConcept(lzo_);
                bool? lzq_ = context.Operators.Equivalent(ObservationCategory, lzp_);

                return lzq_;
            };
            IEnumerable<CqlConcept> lzk_ = context.Operators.Where<CqlConcept>(lzi_, lzj_);
            bool? lzl_ = context.Operators.Exists<CqlConcept>(lzk_);
            bool? lzm_ = context.Operators.And(lzf_, lzl_);

            return lzm_;
        };
        IEnumerable<Observation> kzz_ = context.Operators.Where<Observation>(Obs, kzy_);

        return kzz_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public IEnumerable<MedicationRequest> Active_Medication(CqlContext context, IEnumerable<MedicationRequest> MedicationRequest)
    {
        bool? lzr_(MedicationRequest M)
        {
            Code<MedicationRequest.MedicationrequestStatus> lzt_ = M?.StatusElement;
            MedicationRequest.MedicationrequestStatus? lzu_ = lzt_?.Value;
            string lzv_ = context.Operators.Convert<string>(lzu_);
            bool? lzw_ = context.Operators.Equal(lzv_, "active");
            Code<MedicationRequest.MedicationRequestIntent> lzx_ = M?.IntentElement;
            MedicationRequest.MedicationRequestIntent? lzy_ = lzx_?.Value;
            string lzz_ = context.Operators.Convert<string>(lzy_);
            bool? mza_ = context.Operators.Equal(lzz_, "order");
            bool? mzb_ = context.Operators.And(lzw_, mza_);

            return mzb_;
        };
        IEnumerable<MedicationRequest> lzs_ = context.Operators.Where<MedicationRequest>(MedicationRequest, lzr_);

        return lzs_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public IEnumerable<MedicationRequest> isMedicationActive(CqlContext context, IEnumerable<MedicationRequest> MedicationRequest)
    {
        bool? mzc_(MedicationRequest M)
        {
            Code<MedicationRequest.MedicationrequestStatus> mze_ = M?.StatusElement;
            MedicationRequest.MedicationrequestStatus? mzf_ = mze_?.Value;
            string mzg_ = context.Operators.Convert<string>(mzf_);
            bool? mzh_ = context.Operators.Equal(mzg_, "active");
            Code<MedicationRequest.MedicationRequestIntent> mzi_ = M?.IntentElement;
            MedicationRequest.MedicationRequestIntent? mzj_ = mzi_?.Value;
            string mzk_ = context.Operators.Convert<string>(mzj_);
            bool? mzl_ = context.Operators.Equal(mzk_, "order");
            bool? mzm_ = context.Operators.And(mzh_, mzl_);

            return mzm_;
        };
        IEnumerable<MedicationRequest> mzd_ = context.Operators.Where<MedicationRequest>(MedicationRequest, mzc_);

        return mzd_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public IEnumerable<MedicationDispense> Dispensed_Medication(CqlContext context, IEnumerable<MedicationDispense> Med)
    {
        bool? mzn_(MedicationDispense M)
        {
            Code<MedicationDispense.MedicationDispenseStatusCodes> mzp_ = M?.StatusElement;
            MedicationDispense.MedicationDispenseStatusCodes? mzq_ = mzp_?.Value;
            Code<MedicationDispense.MedicationDispenseStatusCodes> mzr_ = context.Operators.Convert<Code<MedicationDispense.MedicationDispenseStatusCodes>>(mzq_);
            string mzs_ = context.Operators.Convert<string>(mzr_);
            string[] mzt_ = [
                "completed",
                "in-progress",
                "on-hold",
            ];
            bool? mzu_ = context.Operators.In<string>(mzs_, mzt_ as IEnumerable<string>);

            return mzu_;
        };
        IEnumerable<MedicationDispense> mzo_ = context.Operators.Where<MedicationDispense>(Med, mzn_);

        return mzo_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public IEnumerable<MedicationDispense> isMedicationDispensed(CqlContext context, IEnumerable<MedicationDispense> Med)
    {
        bool? mzv_(MedicationDispense M)
        {
            Code<MedicationDispense.MedicationDispenseStatusCodes> mzx_ = M?.StatusElement;
            MedicationDispense.MedicationDispenseStatusCodes? mzy_ = mzx_?.Value;
            Code<MedicationDispense.MedicationDispenseStatusCodes> mzz_ = context.Operators.Convert<Code<MedicationDispense.MedicationDispenseStatusCodes>>(mzy_);
            string nza_ = context.Operators.Convert<string>(mzz_);
            string[] nzb_ = [
                "completed",
                "in-progress",
                "on-hold",
            ];
            bool? nzc_ = context.Operators.In<string>(nza_, nzb_ as IEnumerable<string>);

            return nzc_;
        };
        IEnumerable<MedicationDispense> mzw_ = context.Operators.Where<MedicationDispense>(Med, mzv_);

        return mzw_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public IEnumerable<MedicationRequest> Active_or_Completed_Medication_Request(CqlContext context, IEnumerable<MedicationRequest> MedicationRequest)
    {
        bool? nzd_(MedicationRequest M)
        {
            Code<MedicationRequest.MedicationrequestStatus> nzf_ = M?.StatusElement;
            MedicationRequest.MedicationrequestStatus? nzg_ = nzf_?.Value;
            string nzh_ = context.Operators.Convert<string>(nzg_);
            string[] nzi_ = [
                "active",
                "completed",
            ];
            bool? nzj_ = context.Operators.In<string>(nzh_, nzi_ as IEnumerable<string>);
            Code<MedicationRequest.MedicationRequestIntent> nzk_ = M?.IntentElement;
            MedicationRequest.MedicationRequestIntent? nzl_ = nzk_?.Value;
            string nzm_ = context.Operators.Convert<string>(nzl_);
            bool? nzn_ = context.Operators.Equal(nzm_, "order");
            bool? nzo_ = context.Operators.And(nzj_, nzn_);

            return nzo_;
        };
        IEnumerable<MedicationRequest> nze_ = context.Operators.Where<MedicationRequest>(MedicationRequest, nzd_);

        return nze_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public IEnumerable<MedicationRequest> isMedicationOrder(CqlContext context, IEnumerable<MedicationRequest> MedicationRequest)
    {
        bool? nzp_(MedicationRequest M)
        {
            Code<MedicationRequest.MedicationrequestStatus> nzr_ = M?.StatusElement;
            MedicationRequest.MedicationrequestStatus? nzs_ = nzr_?.Value;
            string nzt_ = context.Operators.Convert<string>(nzs_);
            string[] nzu_ = [
                "active",
                "completed",
            ];
            bool? nzv_ = context.Operators.In<string>(nzt_, nzu_ as IEnumerable<string>);
            Code<MedicationRequest.MedicationRequestIntent> nzw_ = M?.IntentElement;
            MedicationRequest.MedicationRequestIntent? nzx_ = nzw_?.Value;
            string nzy_ = context.Operators.Convert<string>(nzx_);
            bool? nzz_ = context.Operators.Equal(nzy_, "order");
            bool? oza_ = context.Operators.And(nzv_, nzz_);

            return oza_;
        };
        IEnumerable<MedicationRequest> nzq_ = context.Operators.Where<MedicationRequest>(MedicationRequest, nzp_);

        return nzq_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public IEnumerable<Observation> Final_Exam_Observation(CqlContext context, IEnumerable<Observation> Obs)
    {
        bool? ozb_(Observation O)
        {
            Code<ObservationStatus> ozd_ = O?.StatusElement;
            ObservationStatus? oze_ = ozd_?.Value;
            Code<ObservationStatus> ozf_ = context.Operators.Convert<Code<ObservationStatus>>(oze_);
            string ozg_ = context.Operators.Convert<string>(ozf_);
            string[] ozh_ = [
                "final",
                "amended",
                "corrected",
            ];
            bool? ozi_ = context.Operators.In<string>(ozg_, ozh_ as IEnumerable<string>);
            List<CodeableConcept> ozj_ = O?.Category;
            CqlConcept ozk_(CodeableConcept @this)
            {
                CqlConcept ozq_ = FHIRHelpers_4_3_000.Instance.ToConcept(context, @this);

                return ozq_;
            };
            IEnumerable<CqlConcept> ozl_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)ozj_, ozk_);
            bool? ozm_(CqlConcept ObservationCategory)
            {
                CqlCode ozr_ = this.exam(context);
                CqlConcept ozs_ = context.Operators.ConvertCodeToConcept(ozr_);
                bool? ozt_ = context.Operators.Equivalent(ObservationCategory, ozs_);

                return ozt_;
            };
            IEnumerable<CqlConcept> ozn_ = context.Operators.Where<CqlConcept>(ozl_, ozm_);
            bool? ozo_ = context.Operators.Exists<CqlConcept>(ozn_);
            bool? ozp_ = context.Operators.And(ozi_, ozo_);

            return ozp_;
        };
        IEnumerable<Observation> ozc_ = context.Operators.Where<Observation>(Obs, ozb_);

        return ozc_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public IEnumerable<Observation> isPhysicalExamPerformed(CqlContext context, IEnumerable<Observation> Obs)
    {
        bool? ozu_(Observation O)
        {
            Code<ObservationStatus> ozw_ = O?.StatusElement;
            ObservationStatus? ozx_ = ozw_?.Value;
            Code<ObservationStatus> ozy_ = context.Operators.Convert<Code<ObservationStatus>>(ozx_);
            string ozz_ = context.Operators.Convert<string>(ozy_);
            string[] pza_ = [
                "final",
                "amended",
                "corrected",
            ];
            bool? pzb_ = context.Operators.In<string>(ozz_, pza_ as IEnumerable<string>);
            List<CodeableConcept> pzc_ = O?.Category;
            CqlConcept pzd_(CodeableConcept @this)
            {
                CqlConcept pzj_ = FHIRHelpers_4_3_000.Instance.ToConcept(context, @this);

                return pzj_;
            };
            IEnumerable<CqlConcept> pze_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)pzc_, pzd_);
            bool? pzf_(CqlConcept ObservationCategory)
            {
                CqlCode pzk_ = this.exam(context);
                CqlConcept pzl_ = context.Operators.ConvertCodeToConcept(pzk_);
                bool? pzm_ = context.Operators.Equivalent(ObservationCategory, pzl_);

                return pzm_;
            };
            IEnumerable<CqlConcept> pzg_ = context.Operators.Where<CqlConcept>(pze_, pzf_);
            bool? pzh_ = context.Operators.Exists<CqlConcept>(pzg_);
            bool? pzi_ = context.Operators.And(pzb_, pzh_);

            return pzi_;
        };
        IEnumerable<Observation> ozv_ = context.Operators.Where<Observation>(Obs, ozu_);

        return ozv_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public IEnumerable<Observation> BloodPressure(CqlContext context, IEnumerable<Observation> Obs)
    {
        bool? pzn_(Observation O)
        {
            Code<ObservationStatus> pzp_ = O?.StatusElement;
            ObservationStatus? pzq_ = pzp_?.Value;
            string pzr_ = context.Operators.Convert<string>(pzq_);
            string[] pzs_ = [
                "final",
                "amended",
                "corrected",
            ];
            bool? pzt_ = context.Operators.In<string>(pzr_, pzs_ as IEnumerable<string>);

            return pzt_;
        };
        IEnumerable<Observation> pzo_ = context.Operators.Where<Observation>(Obs, pzn_);

        return pzo_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public IEnumerable<Observation> BodyHeight(CqlContext context, IEnumerable<Observation> Obs)
    {
        bool? pzu_(Observation O)
        {
            Code<ObservationStatus> pzw_ = O?.StatusElement;
            ObservationStatus? pzx_ = pzw_?.Value;
            string pzy_ = context.Operators.Convert<string>(pzx_);
            string[] pzz_ = [
                "final",
                "amended",
                "corrected",
            ];
            bool? qza_ = context.Operators.In<string>(pzy_, pzz_ as IEnumerable<string>);

            return qza_;
        };
        IEnumerable<Observation> pzv_ = context.Operators.Where<Observation>(Obs, pzu_);

        return pzv_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public IEnumerable<Observation> BodyWeight(CqlContext context, IEnumerable<Observation> Obs)
    {
        bool? qzb_(Observation O)
        {
            Code<ObservationStatus> qzd_ = O?.StatusElement;
            ObservationStatus? qze_ = qzd_?.Value;
            string qzf_ = context.Operators.Convert<string>(qze_);
            string[] qzg_ = [
                "final",
                "amended",
                "corrected",
            ];
            bool? qzh_ = context.Operators.In<string>(qzf_, qzg_ as IEnumerable<string>);

            return qzh_;
        };
        IEnumerable<Observation> qzc_ = context.Operators.Where<Observation>(Obs, qzb_);

        return qzc_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public IEnumerable<Observation> BMI(CqlContext context, IEnumerable<Observation> Obs)
    {
        bool? qzi_(Observation O)
        {
            Code<ObservationStatus> qzk_ = O?.StatusElement;
            ObservationStatus? qzl_ = qzk_?.Value;
            string qzm_ = context.Operators.Convert<string>(qzl_);
            string[] qzn_ = [
                "final",
                "amended",
                "corrected",
            ];
            bool? qzo_ = context.Operators.In<string>(qzm_, qzn_ as IEnumerable<string>);

            return qzo_;
        };
        IEnumerable<Observation> qzj_ = context.Operators.Where<Observation>(Obs, qzi_);

        return qzj_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public IEnumerable<Observation> isObservationBP(CqlContext context, IEnumerable<Observation> Obs)
    {
        bool? qzp_(Observation O)
        {
            Code<ObservationStatus> qzr_ = O?.StatusElement;
            ObservationStatus? qzs_ = qzr_?.Value;
            string qzt_ = context.Operators.Convert<string>(qzs_);
            string[] qzu_ = [
                "final",
                "amended",
                "corrected",
            ];
            bool? qzv_ = context.Operators.In<string>(qzt_, qzu_ as IEnumerable<string>);

            return qzv_;
        };
        IEnumerable<Observation> qzq_ = context.Operators.Where<Observation>(Obs, qzp_);

        return qzq_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public IEnumerable<Observation> isObservationBodyHeight(CqlContext context, IEnumerable<Observation> Obs)
    {
        bool? qzw_(Observation O)
        {
            Code<ObservationStatus> qzy_ = O?.StatusElement;
            ObservationStatus? qzz_ = qzy_?.Value;
            string rza_ = context.Operators.Convert<string>(qzz_);
            string[] rzb_ = [
                "final",
                "amended",
                "corrected",
            ];
            bool? rzc_ = context.Operators.In<string>(rza_, rzb_ as IEnumerable<string>);

            return rzc_;
        };
        IEnumerable<Observation> qzx_ = context.Operators.Where<Observation>(Obs, qzw_);

        return qzx_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public IEnumerable<Observation> isObservationBodyWeight(CqlContext context, IEnumerable<Observation> Obs)
    {
        bool? rzd_(Observation O)
        {
            Code<ObservationStatus> rzf_ = O?.StatusElement;
            ObservationStatus? rzg_ = rzf_?.Value;
            string rzh_ = context.Operators.Convert<string>(rzg_);
            string[] rzi_ = [
                "final",
                "amended",
                "corrected",
            ];
            bool? rzj_ = context.Operators.In<string>(rzh_, rzi_ as IEnumerable<string>);

            return rzj_;
        };
        IEnumerable<Observation> rze_ = context.Operators.Where<Observation>(Obs, rzd_);

        return rze_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public IEnumerable<Observation> isObservationBMI(CqlContext context, IEnumerable<Observation> Obs)
    {
        bool? rzk_(Observation O)
        {
            Code<ObservationStatus> rzm_ = O?.StatusElement;
            ObservationStatus? rzn_ = rzm_?.Value;
            string rzo_ = context.Operators.Convert<string>(rzn_);
            string[] rzp_ = [
                "final",
                "amended",
                "corrected",
            ];
            bool? rzq_ = context.Operators.In<string>(rzo_, rzp_ as IEnumerable<string>);

            return rzq_;
        };
        IEnumerable<Observation> rzl_ = context.Operators.Where<Observation>(Obs, rzk_);

        return rzl_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public IEnumerable<Observation> Initial_or_Final_Observation(CqlContext context, IEnumerable<Observation> Obs)
    {
        bool? rzr_(Observation O)
        {
            Code<ObservationStatus> rzt_ = O?.StatusElement;
            ObservationStatus? rzu_ = rzt_?.Value;
            Code<ObservationStatus> rzv_ = context.Operators.Convert<Code<ObservationStatus>>(rzu_);
            string rzw_ = context.Operators.Convert<string>(rzv_);
            string[] rzx_ = [
                "preliminary",
                "final",
                "amended",
                "corrected",
            ];
            bool? rzy_ = context.Operators.In<string>(rzw_, rzx_ as IEnumerable<string>);

            return rzy_;
        };
        IEnumerable<Observation> rzs_ = context.Operators.Where<Observation>(Obs, rzr_);

        return rzs_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public IEnumerable<Observation> isSymptom(CqlContext context, IEnumerable<Observation> Obs)
    {
        bool? rzz_(Observation O)
        {
            Code<ObservationStatus> szb_ = O?.StatusElement;
            ObservationStatus? szc_ = szb_?.Value;
            Code<ObservationStatus> szd_ = context.Operators.Convert<Code<ObservationStatus>>(szc_);
            string sze_ = context.Operators.Convert<string>(szd_);
            string[] szf_ = [
                "preliminary",
                "final",
                "amended",
                "corrected",
            ];
            bool? szg_ = context.Operators.In<string>(sze_, szf_ as IEnumerable<string>);

            return szg_;
        };
        IEnumerable<Observation> sza_ = context.Operators.Where<Observation>(Obs, rzz_);

        return sza_;
    }


    #endregion Expressions

}
