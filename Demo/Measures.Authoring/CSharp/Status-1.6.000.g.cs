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
        IEnumerable<Patient> wu_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-patient"));
        Patient wv_ = context.Operators.SingletonFrom<Patient>(wu_);

        return wv_;
    }


    [CqlExpressionDefinition("Final Survey Observation")]
    public IEnumerable<Observation> Final_Survey_Observation(CqlContext context, IEnumerable<Observation> Obs)
    {
        bool? ww_(Observation O)
        {
            Code<ObservationStatus> wy_ = O?.StatusElement;
            ObservationStatus? wz_ = wy_?.Value;
            Code<ObservationStatus> xa_ = context.Operators.Convert<Code<ObservationStatus>>(wz_);
            string xb_ = context.Operators.Convert<string>(xa_);
            string[] xc_ = [
                "final",
                "amended",
                "corrected",
            ];
            bool? xd_ = context.Operators.In<string>(xb_, xc_ as IEnumerable<string>);
            List<CodeableConcept> xe_ = O?.Category;
            CqlConcept xf_(CodeableConcept @this)
            {
                CqlConcept xl_ = FHIRHelpers_4_3_000.Instance.ToConcept(context, @this);

                return xl_;
            };
            IEnumerable<CqlConcept> xg_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)xe_, xf_);
            bool? xh_(CqlConcept ObservationCategory)
            {
                CqlCode xm_ = this.survey(context);
                CqlConcept xn_ = context.Operators.ConvertCodeToConcept(xm_);
                bool? xo_ = context.Operators.Equivalent(ObservationCategory, xn_);

                return xo_;
            };
            IEnumerable<CqlConcept> xi_ = context.Operators.Where<CqlConcept>(xg_, xh_);
            bool? xj_ = context.Operators.Exists<CqlConcept>(xi_);
            bool? xk_ = context.Operators.And(xd_, xj_);

            return xk_;
        };
        IEnumerable<Observation> wx_ = context.Operators.Where<Observation>(Obs, ww_);

        return wx_;
    }


    [CqlExpressionDefinition("isAssessmentPerformed")]
    public IEnumerable<Observation> isAssessmentPerformed(CqlContext context, IEnumerable<Observation> Obs)
    {
        bool? xp_(Observation O)
        {
            Code<ObservationStatus> xr_ = O?.StatusElement;
            ObservationStatus? xs_ = xr_?.Value;
            Code<ObservationStatus> xt_ = context.Operators.Convert<Code<ObservationStatus>>(xs_);
            string xu_ = context.Operators.Convert<string>(xt_);
            string[] xv_ = [
                "final",
                "amended",
                "corrected",
            ];
            bool? xw_ = context.Operators.In<string>(xu_, xv_ as IEnumerable<string>);
            List<CodeableConcept> xx_ = O?.Category;
            CqlConcept xy_(CodeableConcept @this)
            {
                CqlConcept ye_ = FHIRHelpers_4_3_000.Instance.ToConcept(context, @this);

                return ye_;
            };
            IEnumerable<CqlConcept> xz_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)xx_, xy_);
            bool? ya_(CqlConcept ObservationCategory)
            {
                CqlCode yf_ = this.survey(context);
                CqlConcept yg_ = context.Operators.ConvertCodeToConcept(yf_);
                bool? yh_ = context.Operators.Equivalent(ObservationCategory, yg_);

                return yh_;
            };
            IEnumerable<CqlConcept> yb_ = context.Operators.Where<CqlConcept>(xz_, ya_);
            bool? yc_ = context.Operators.Exists<CqlConcept>(yb_);
            bool? yd_ = context.Operators.And(xw_, yc_);

            return yd_;
        };
        IEnumerable<Observation> xq_ = context.Operators.Where<Observation>(Obs, xp_);

        return xq_;
    }


    [CqlExpressionDefinition("Active Condition")]
    public IEnumerable<Condition> Active_Condition(CqlContext context, IEnumerable<Condition> Condition)
    {
        bool? yi_(Condition C)
        {
            CodeableConcept yk_ = C?.ClinicalStatus;
            CqlConcept yl_ = FHIRHelpers_4_3_000.Instance.ToConcept(context, yk_);
            CqlCode ym_ = this.active(context);
            CqlConcept yn_ = context.Operators.ConvertCodeToConcept(ym_);
            bool? yo_ = context.Operators.Equivalent(yl_, yn_);

            return yo_;
        };
        IEnumerable<Condition> yj_ = context.Operators.Where<Condition>(Condition, yi_);

        return yj_;
    }


    [CqlExpressionDefinition("isActiveOnly")]
    public IEnumerable<Condition> isActiveOnly(CqlContext context, IEnumerable<Condition> Condition)
    {
        bool? yp_(Condition C)
        {
            CodeableConcept yr_ = C?.ClinicalStatus;
            CqlConcept ys_ = FHIRHelpers_4_3_000.Instance.ToConcept(context, yr_);
            CqlCode yt_ = this.active(context);
            CqlConcept yu_ = context.Operators.ConvertCodeToConcept(yt_);
            bool? yv_ = context.Operators.Equivalent(ys_, yu_);

            return yv_;
        };
        IEnumerable<Condition> yq_ = context.Operators.Where<Condition>(Condition, yp_);

        return yq_;
    }


    [CqlExpressionDefinition("Completed or Ongoing Device Request")]
    public IEnumerable<DeviceRequest> Completed_or_Ongoing_Device_Request(CqlContext context, IEnumerable<DeviceRequest> DeviceRequest)
    {
        bool? yw_(DeviceRequest D)
        {
            Code<RequestStatus> yy_ = D?.StatusElement;
            RequestStatus? yz_ = yy_?.Value;
            Code<RequestStatus> za_ = context.Operators.Convert<Code<RequestStatus>>(yz_);
            string zb_ = context.Operators.Convert<string>(za_);
            string[] zc_ = [
                "active",
                "completed",
            ];
            bool? zd_ = context.Operators.In<string>(zb_, zc_ as IEnumerable<string>);
            Code<RequestIntent> ze_ = D?.IntentElement;
            RequestIntent? zf_ = ze_?.Value;
            Code<RequestIntent> zg_ = context.Operators.Convert<Code<RequestIntent>>(zf_);
            bool? zh_ = context.Operators.Equal(zg_, "order");
            bool? zi_ = context.Operators.And(zd_, zh_);

            return zi_;
        };
        IEnumerable<DeviceRequest> yx_ = context.Operators.Where<DeviceRequest>(DeviceRequest, yw_);

        return yx_;
    }


    [CqlExpressionDefinition("isDeviceOrder")]
    public IEnumerable<DeviceRequest> isDeviceOrder(CqlContext context, IEnumerable<DeviceRequest> DeviceRequest)
    {
        bool? zj_(DeviceRequest D)
        {
            Code<RequestStatus> zl_ = D?.StatusElement;
            RequestStatus? zm_ = zl_?.Value;
            Code<RequestStatus> zn_ = context.Operators.Convert<Code<RequestStatus>>(zm_);
            string zo_ = context.Operators.Convert<string>(zn_);
            string[] zp_ = [
                "active",
                "completed",
            ];
            bool? zq_ = context.Operators.In<string>(zo_, zp_ as IEnumerable<string>);
            Code<RequestIntent> zr_ = D?.IntentElement;
            RequestIntent? zs_ = zr_?.Value;
            Code<RequestIntent> zt_ = context.Operators.Convert<Code<RequestIntent>>(zs_);
            bool? zu_ = context.Operators.Equal(zt_, "order");
            bool? zv_ = context.Operators.And(zq_, zu_);

            return zv_;
        };
        IEnumerable<DeviceRequest> zk_ = context.Operators.Where<DeviceRequest>(DeviceRequest, zj_);

        return zk_;
    }


    [CqlExpressionDefinition("Completed or Ongoing Service Request")]
    public IEnumerable<ServiceRequest> Completed_or_Ongoing_Service_Request(CqlContext context, IEnumerable<ServiceRequest> ServiceRequest)
    {
        bool? zw_(ServiceRequest S)
        {
            Code<RequestStatus> zy_ = S?.StatusElement;
            RequestStatus? zz_ = zy_?.Value;
            Code<RequestStatus> aza_ = context.Operators.Convert<Code<RequestStatus>>(zz_);
            string azb_ = context.Operators.Convert<string>(aza_);
            string[] azc_ = [
                "active",
                "completed",
            ];
            bool? azd_ = context.Operators.In<string>(azb_, azc_ as IEnumerable<string>);
            Code<RequestIntent> aze_ = S?.IntentElement;
            RequestIntent? azf_ = aze_?.Value;
            Code<RequestIntent> azg_ = context.Operators.Convert<Code<RequestIntent>>(azf_);
            bool? azh_ = context.Operators.Equal(azg_, "order");
            bool? azi_ = context.Operators.And(azd_, azh_);

            return azi_;
        };
        IEnumerable<ServiceRequest> zx_ = context.Operators.Where<ServiceRequest>(ServiceRequest, zw_);

        return zx_;
    }


    [CqlExpressionDefinition("isDiagnosticStudyOrder")]
    public IEnumerable<ServiceRequest> isDiagnosticStudyOrder(CqlContext context, IEnumerable<ServiceRequest> ServiceRequest)
    {
        bool? azj_(ServiceRequest S)
        {
            Code<RequestStatus> azl_ = S?.StatusElement;
            RequestStatus? azm_ = azl_?.Value;
            Code<RequestStatus> azn_ = context.Operators.Convert<Code<RequestStatus>>(azm_);
            string azo_ = context.Operators.Convert<string>(azn_);
            string[] azp_ = [
                "active",
                "completed",
            ];
            bool? azq_ = context.Operators.In<string>(azo_, azp_ as IEnumerable<string>);
            Code<RequestIntent> azr_ = S?.IntentElement;
            RequestIntent? azs_ = azr_?.Value;
            Code<RequestIntent> azt_ = context.Operators.Convert<Code<RequestIntent>>(azs_);
            bool? azu_ = context.Operators.Equal(azt_, "order");
            bool? azv_ = context.Operators.And(azq_, azu_);

            return azv_;
        };
        IEnumerable<ServiceRequest> azk_ = context.Operators.Where<ServiceRequest>(ServiceRequest, azj_);

        return azk_;
    }


    [CqlExpressionDefinition("isInterventionOrder")]
    public IEnumerable<ServiceRequest> isInterventionOrder(CqlContext context, IEnumerable<ServiceRequest> ServiceRequest)
    {
        bool? azw_(ServiceRequest S)
        {
            Code<RequestStatus> azy_ = S?.StatusElement;
            RequestStatus? azz_ = azy_?.Value;
            Code<RequestStatus> bza_ = context.Operators.Convert<Code<RequestStatus>>(azz_);
            string bzb_ = context.Operators.Convert<string>(bza_);
            string[] bzc_ = [
                "active",
                "completed",
            ];
            bool? bzd_ = context.Operators.In<string>(bzb_, bzc_ as IEnumerable<string>);
            Code<RequestIntent> bze_ = S?.IntentElement;
            RequestIntent? bzf_ = bze_?.Value;
            Code<RequestIntent> bzg_ = context.Operators.Convert<Code<RequestIntent>>(bzf_);
            bool? bzh_ = context.Operators.Equal(bzg_, "order");
            bool? bzi_ = context.Operators.And(bzd_, bzh_);

            return bzi_;
        };
        IEnumerable<ServiceRequest> azx_ = context.Operators.Where<ServiceRequest>(ServiceRequest, azw_);

        return azx_;
    }


    [CqlExpressionDefinition("isLaboratoryTestOrder")]
    public IEnumerable<ServiceRequest> isLaboratoryTestOrder(CqlContext context, IEnumerable<ServiceRequest> ServiceRequest)
    {
        bool? bzj_(ServiceRequest S)
        {
            Code<RequestStatus> bzl_ = S?.StatusElement;
            RequestStatus? bzm_ = bzl_?.Value;
            Code<RequestStatus> bzn_ = context.Operators.Convert<Code<RequestStatus>>(bzm_);
            string bzo_ = context.Operators.Convert<string>(bzn_);
            string[] bzp_ = [
                "active",
                "completed",
            ];
            bool? bzq_ = context.Operators.In<string>(bzo_, bzp_ as IEnumerable<string>);
            Code<RequestIntent> bzr_ = S?.IntentElement;
            RequestIntent? bzs_ = bzr_?.Value;
            Code<RequestIntent> bzt_ = context.Operators.Convert<Code<RequestIntent>>(bzs_);
            bool? bzu_ = context.Operators.Equal(bzt_, "order");
            bool? bzv_ = context.Operators.And(bzq_, bzu_);

            return bzv_;
        };
        IEnumerable<ServiceRequest> bzk_ = context.Operators.Where<ServiceRequest>(ServiceRequest, bzj_);

        return bzk_;
    }


    [CqlExpressionDefinition("Final Observation")]
    public IEnumerable<Observation> Final_Observation(CqlContext context, IEnumerable<Observation> Obs)
    {
        bool? bzw_(Observation O)
        {
            Code<ObservationStatus> bzy_ = O?.StatusElement;
            ObservationStatus? bzz_ = bzy_?.Value;
            Code<ObservationStatus> cza_ = context.Operators.Convert<Code<ObservationStatus>>(bzz_);
            string czb_ = context.Operators.Convert<string>(cza_);
            string[] czc_ = [
                "final",
                "amended",
                "corrected",
            ];
            bool? czd_ = context.Operators.In<string>(czb_, czc_ as IEnumerable<string>);

            return czd_;
        };
        IEnumerable<Observation> bzx_ = context.Operators.Where<Observation>(Obs, bzw_);

        return bzx_;
    }


    [CqlExpressionDefinition("isDiagnosticStudyPerformed")]
    public IEnumerable<Observation> isDiagnosticStudyPerformed(CqlContext context, IEnumerable<Observation> Obs)
    {
        bool? cze_(Observation O)
        {
            Code<ObservationStatus> czg_ = O?.StatusElement;
            ObservationStatus? czh_ = czg_?.Value;
            Code<ObservationStatus> czi_ = context.Operators.Convert<Code<ObservationStatus>>(czh_);
            string czj_ = context.Operators.Convert<string>(czi_);
            string[] czk_ = [
                "final",
                "amended",
                "corrected",
            ];
            bool? czl_ = context.Operators.In<string>(czj_, czk_ as IEnumerable<string>);

            return czl_;
        };
        IEnumerable<Observation> czf_ = context.Operators.Where<Observation>(Obs, cze_);

        return czf_;
    }


    [CqlExpressionDefinition("Finished Encounter")]
    public IEnumerable<Encounter> Finished_Encounter(CqlContext context, IEnumerable<Encounter> Enc)
    {
        bool? czm_(Encounter E)
        {
            Code<Encounter.EncounterStatus> czo_ = E?.StatusElement;
            Encounter.EncounterStatus? czp_ = czo_?.Value;
            Code<Encounter.EncounterStatus> czq_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(czp_);
            string czr_ = context.Operators.Convert<string>(czq_);
            string[] czs_ = [
                "finished",
                "arrived",
                "triaged",
                "in-progress",
                "onleave",
            ];
            bool? czt_ = context.Operators.In<string>(czr_, czs_ as IEnumerable<string>);

            return czt_;
        };
        IEnumerable<Encounter> czn_ = context.Operators.Where<Encounter>(Enc, czm_);

        return czn_;
    }


    [CqlExpressionDefinition("isEncounterPerformed")]
    public IEnumerable<Encounter> isEncounterPerformed(CqlContext context, IEnumerable<Encounter> Enc)
    {
        bool? czu_(Encounter E)
        {
            Code<Encounter.EncounterStatus> czw_ = E?.StatusElement;
            Encounter.EncounterStatus? czx_ = czw_?.Value;
            Code<Encounter.EncounterStatus> czy_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(czx_);
            string czz_ = context.Operators.Convert<string>(czy_);
            string[] dza_ = [
                "finished",
                "arrived",
                "triaged",
                "in-progress",
                "onleave",
            ];
            bool? dzb_ = context.Operators.In<string>(czz_, dza_ as IEnumerable<string>);

            return dzb_;
        };
        IEnumerable<Encounter> czv_ = context.Operators.Where<Encounter>(Enc, czu_);

        return czv_;
    }


    [CqlExpressionDefinition("Completed Immunization")]
    public IEnumerable<Immunization> Completed_Immunization(CqlContext context, IEnumerable<Immunization> Immunization)
    {
        bool? dzc_(Immunization I)
        {
            Code<Immunization.ImmunizationStatusCodes> dze_ = I?.StatusElement;
            Immunization.ImmunizationStatusCodes? dzf_ = dze_?.Value;
            string dzg_ = context.Operators.Convert<string>(dzf_);
            bool? dzh_ = context.Operators.Equivalent(dzg_, "completed");

            return dzh_;
        };
        IEnumerable<Immunization> dzd_ = context.Operators.Where<Immunization>(Immunization, dzc_);

        return dzd_;
    }


    [CqlExpressionDefinition("isImmunizationAdministered")]
    public IEnumerable<Immunization> isImmunizationAdministered(CqlContext context, IEnumerable<Immunization> Immunization)
    {
        bool? dzi_(Immunization I)
        {
            Code<Immunization.ImmunizationStatusCodes> dzk_ = I?.StatusElement;
            Immunization.ImmunizationStatusCodes? dzl_ = dzk_?.Value;
            string dzm_ = context.Operators.Convert<string>(dzl_);
            bool? dzn_ = context.Operators.Equivalent(dzm_, "completed");

            return dzn_;
        };
        IEnumerable<Immunization> dzj_ = context.Operators.Where<Immunization>(Immunization, dzi_);

        return dzj_;
    }


    [CqlExpressionDefinition("Completed Procedure")]
    public IEnumerable<Procedure> Completed_Procedure(CqlContext context, IEnumerable<Procedure> Proc)
    {
        bool? dzo_(Procedure P)
        {
            Code<EventStatus> dzq_ = P?.StatusElement;
            EventStatus? dzr_ = dzq_?.Value;
            string dzs_ = context.Operators.Convert<string>(dzr_);
            bool? dzt_ = context.Operators.Equivalent(dzs_, "completed");

            return dzt_;
        };
        IEnumerable<Procedure> dzp_ = context.Operators.Where<Procedure>(Proc, dzo_);

        return dzp_;
    }


    [CqlExpressionDefinition("isInterventionPerformed")]
    public IEnumerable<Procedure> isInterventionPerformed(CqlContext context, IEnumerable<Procedure> Proc)
    {
        bool? dzu_(Procedure P)
        {
            Code<EventStatus> dzw_ = P?.StatusElement;
            EventStatus? dzx_ = dzw_?.Value;
            string dzy_ = context.Operators.Convert<string>(dzx_);
            bool? dzz_ = context.Operators.Equivalent(dzy_, "completed");

            return dzz_;
        };
        IEnumerable<Procedure> dzv_ = context.Operators.Where<Procedure>(Proc, dzu_);

        return dzv_;
    }


    [CqlExpressionDefinition("isProcedurePerformed")]
    public IEnumerable<Procedure> isProcedurePerformed(CqlContext context, IEnumerable<Procedure> Proc)
    {
        bool? eza_(Procedure P)
        {
            Code<EventStatus> ezc_ = P?.StatusElement;
            EventStatus? ezd_ = ezc_?.Value;
            string eze_ = context.Operators.Convert<string>(ezd_);
            bool? ezf_ = context.Operators.Equivalent(eze_, "completed");

            return ezf_;
        };
        IEnumerable<Procedure> ezb_ = context.Operators.Where<Procedure>(Proc, eza_);

        return ezb_;
    }


    [CqlExpressionDefinition("Final Lab Observation")]
    public IEnumerable<Observation> Final_Lab_Observation(CqlContext context, IEnumerable<Observation> Obs)
    {
        bool? ezg_(Observation O)
        {
            Code<ObservationStatus> ezi_ = O?.StatusElement;
            ObservationStatus? ezj_ = ezi_?.Value;
            Code<ObservationStatus> ezk_ = context.Operators.Convert<Code<ObservationStatus>>(ezj_);
            string ezl_ = context.Operators.Convert<string>(ezk_);
            string[] ezm_ = [
                "final",
                "amended",
                "corrected",
            ];
            bool? ezn_ = context.Operators.In<string>(ezl_, ezm_ as IEnumerable<string>);
            List<CodeableConcept> ezo_ = O?.Category;
            CqlConcept ezp_(CodeableConcept @this)
            {
                CqlConcept ezv_ = FHIRHelpers_4_3_000.Instance.ToConcept(context, @this);

                return ezv_;
            };
            IEnumerable<CqlConcept> ezq_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)ezo_, ezp_);
            bool? ezr_(CqlConcept ObservationCategory)
            {
                CqlCode ezw_ = this.laboratory(context);
                CqlConcept ezx_ = context.Operators.ConvertCodeToConcept(ezw_);
                bool? ezy_ = context.Operators.Equivalent(ObservationCategory, ezx_);

                return ezy_;
            };
            IEnumerable<CqlConcept> ezs_ = context.Operators.Where<CqlConcept>(ezq_, ezr_);
            bool? ezt_ = context.Operators.Exists<CqlConcept>(ezs_);
            bool? ezu_ = context.Operators.And(ezn_, ezt_);

            return ezu_;
        };
        IEnumerable<Observation> ezh_ = context.Operators.Where<Observation>(Obs, ezg_);

        return ezh_;
    }


    [CqlExpressionDefinition("isLaboratoryTestPerformed")]
    public IEnumerable<Observation> isLaboratoryTestPerformed(CqlContext context, IEnumerable<Observation> Obs)
    {
        bool? ezz_(Observation O)
        {
            Code<ObservationStatus> fzb_ = O?.StatusElement;
            ObservationStatus? fzc_ = fzb_?.Value;
            Code<ObservationStatus> fzd_ = context.Operators.Convert<Code<ObservationStatus>>(fzc_);
            string fze_ = context.Operators.Convert<string>(fzd_);
            string[] fzf_ = [
                "final",
                "amended",
                "corrected",
            ];
            bool? fzg_ = context.Operators.In<string>(fze_, fzf_ as IEnumerable<string>);
            List<CodeableConcept> fzh_ = O?.Category;
            CqlConcept fzi_(CodeableConcept @this)
            {
                CqlConcept fzo_ = FHIRHelpers_4_3_000.Instance.ToConcept(context, @this);

                return fzo_;
            };
            IEnumerable<CqlConcept> fzj_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)fzh_, fzi_);
            bool? fzk_(CqlConcept ObservationCategory)
            {
                CqlCode fzp_ = this.laboratory(context);
                CqlConcept fzq_ = context.Operators.ConvertCodeToConcept(fzp_);
                bool? fzr_ = context.Operators.Equivalent(ObservationCategory, fzq_);

                return fzr_;
            };
            IEnumerable<CqlConcept> fzl_ = context.Operators.Where<CqlConcept>(fzj_, fzk_);
            bool? fzm_ = context.Operators.Exists<CqlConcept>(fzl_);
            bool? fzn_ = context.Operators.And(fzg_, fzm_);

            return fzn_;
        };
        IEnumerable<Observation> fza_ = context.Operators.Where<Observation>(Obs, ezz_);

        return fza_;
    }


    [CqlExpressionDefinition("Active Medication")]
    public IEnumerable<MedicationRequest> Active_Medication(CqlContext context, IEnumerable<MedicationRequest> MedicationRequest)
    {
        bool? fzs_(MedicationRequest M)
        {
            Code<MedicationRequest.MedicationrequestStatus> fzu_ = M?.StatusElement;
            MedicationRequest.MedicationrequestStatus? fzv_ = fzu_?.Value;
            string fzw_ = context.Operators.Convert<string>(fzv_);
            bool? fzx_ = context.Operators.Equal(fzw_, "active");
            Code<MedicationRequest.MedicationRequestIntent> fzy_ = M?.IntentElement;
            MedicationRequest.MedicationRequestIntent? fzz_ = fzy_?.Value;
            string gza_ = context.Operators.Convert<string>(fzz_);
            bool? gzb_ = context.Operators.Equal(gza_, "order");
            bool? gzc_ = context.Operators.And(fzx_, gzb_);

            return gzc_;
        };
        IEnumerable<MedicationRequest> fzt_ = context.Operators.Where<MedicationRequest>(MedicationRequest, fzs_);

        return fzt_;
    }


    [CqlExpressionDefinition("isMedicationActive")]
    public IEnumerable<MedicationRequest> isMedicationActive(CqlContext context, IEnumerable<MedicationRequest> MedicationRequest)
    {
        bool? gzd_(MedicationRequest M)
        {
            Code<MedicationRequest.MedicationrequestStatus> gzf_ = M?.StatusElement;
            MedicationRequest.MedicationrequestStatus? gzg_ = gzf_?.Value;
            string gzh_ = context.Operators.Convert<string>(gzg_);
            bool? gzi_ = context.Operators.Equal(gzh_, "active");
            Code<MedicationRequest.MedicationRequestIntent> gzj_ = M?.IntentElement;
            MedicationRequest.MedicationRequestIntent? gzk_ = gzj_?.Value;
            string gzl_ = context.Operators.Convert<string>(gzk_);
            bool? gzm_ = context.Operators.Equal(gzl_, "order");
            bool? gzn_ = context.Operators.And(gzi_, gzm_);

            return gzn_;
        };
        IEnumerable<MedicationRequest> gze_ = context.Operators.Where<MedicationRequest>(MedicationRequest, gzd_);

        return gze_;
    }


    [CqlExpressionDefinition("Dispensed Medication")]
    public IEnumerable<MedicationDispense> Dispensed_Medication(CqlContext context, IEnumerable<MedicationDispense> Med)
    {
        bool? gzo_(MedicationDispense M)
        {
            Code<MedicationDispense.MedicationDispenseStatusCodes> gzq_ = M?.StatusElement;
            MedicationDispense.MedicationDispenseStatusCodes? gzr_ = gzq_?.Value;
            Code<MedicationDispense.MedicationDispenseStatusCodes> gzs_ = context.Operators.Convert<Code<MedicationDispense.MedicationDispenseStatusCodes>>(gzr_);
            string gzt_ = context.Operators.Convert<string>(gzs_);
            string[] gzu_ = [
                "completed",
                "in-progress",
                "on-hold",
            ];
            bool? gzv_ = context.Operators.In<string>(gzt_, gzu_ as IEnumerable<string>);

            return gzv_;
        };
        IEnumerable<MedicationDispense> gzp_ = context.Operators.Where<MedicationDispense>(Med, gzo_);

        return gzp_;
    }


    [CqlExpressionDefinition("isMedicationDispensed")]
    public IEnumerable<MedicationDispense> isMedicationDispensed(CqlContext context, IEnumerable<MedicationDispense> Med)
    {
        bool? gzw_(MedicationDispense M)
        {
            Code<MedicationDispense.MedicationDispenseStatusCodes> gzy_ = M?.StatusElement;
            MedicationDispense.MedicationDispenseStatusCodes? gzz_ = gzy_?.Value;
            Code<MedicationDispense.MedicationDispenseStatusCodes> hza_ = context.Operators.Convert<Code<MedicationDispense.MedicationDispenseStatusCodes>>(gzz_);
            string hzb_ = context.Operators.Convert<string>(hza_);
            string[] hzc_ = [
                "completed",
                "in-progress",
                "on-hold",
            ];
            bool? hzd_ = context.Operators.In<string>(hzb_, hzc_ as IEnumerable<string>);

            return hzd_;
        };
        IEnumerable<MedicationDispense> gzx_ = context.Operators.Where<MedicationDispense>(Med, gzw_);

        return gzx_;
    }


    [CqlExpressionDefinition("Active or Completed Medication Request")]
    public IEnumerable<MedicationRequest> Active_or_Completed_Medication_Request(CqlContext context, IEnumerable<MedicationRequest> MedicationRequest)
    {
        bool? hze_(MedicationRequest M)
        {
            Code<MedicationRequest.MedicationrequestStatus> hzg_ = M?.StatusElement;
            MedicationRequest.MedicationrequestStatus? hzh_ = hzg_?.Value;
            string hzi_ = context.Operators.Convert<string>(hzh_);
            string[] hzj_ = [
                "active",
                "completed",
            ];
            bool? hzk_ = context.Operators.In<string>(hzi_, hzj_ as IEnumerable<string>);
            Code<MedicationRequest.MedicationRequestIntent> hzl_ = M?.IntentElement;
            MedicationRequest.MedicationRequestIntent? hzm_ = hzl_?.Value;
            string hzn_ = context.Operators.Convert<string>(hzm_);
            bool? hzo_ = context.Operators.Equal(hzn_, "order");
            bool? hzp_ = context.Operators.And(hzk_, hzo_);

            return hzp_;
        };
        IEnumerable<MedicationRequest> hzf_ = context.Operators.Where<MedicationRequest>(MedicationRequest, hze_);

        return hzf_;
    }


    [CqlExpressionDefinition("isMedicationOrder")]
    public IEnumerable<MedicationRequest> isMedicationOrder(CqlContext context, IEnumerable<MedicationRequest> MedicationRequest)
    {
        bool? hzq_(MedicationRequest M)
        {
            Code<MedicationRequest.MedicationrequestStatus> hzs_ = M?.StatusElement;
            MedicationRequest.MedicationrequestStatus? hzt_ = hzs_?.Value;
            string hzu_ = context.Operators.Convert<string>(hzt_);
            string[] hzv_ = [
                "active",
                "completed",
            ];
            bool? hzw_ = context.Operators.In<string>(hzu_, hzv_ as IEnumerable<string>);
            Code<MedicationRequest.MedicationRequestIntent> hzx_ = M?.IntentElement;
            MedicationRequest.MedicationRequestIntent? hzy_ = hzx_?.Value;
            string hzz_ = context.Operators.Convert<string>(hzy_);
            bool? iza_ = context.Operators.Equal(hzz_, "order");
            bool? izb_ = context.Operators.And(hzw_, iza_);

            return izb_;
        };
        IEnumerable<MedicationRequest> hzr_ = context.Operators.Where<MedicationRequest>(MedicationRequest, hzq_);

        return hzr_;
    }


    [CqlExpressionDefinition("Final Exam Observation")]
    public IEnumerable<Observation> Final_Exam_Observation(CqlContext context, IEnumerable<Observation> Obs)
    {
        bool? izc_(Observation O)
        {
            Code<ObservationStatus> ize_ = O?.StatusElement;
            ObservationStatus? izf_ = ize_?.Value;
            Code<ObservationStatus> izg_ = context.Operators.Convert<Code<ObservationStatus>>(izf_);
            string izh_ = context.Operators.Convert<string>(izg_);
            string[] izi_ = [
                "final",
                "amended",
                "corrected",
            ];
            bool? izj_ = context.Operators.In<string>(izh_, izi_ as IEnumerable<string>);
            List<CodeableConcept> izk_ = O?.Category;
            CqlConcept izl_(CodeableConcept @this)
            {
                CqlConcept izr_ = FHIRHelpers_4_3_000.Instance.ToConcept(context, @this);

                return izr_;
            };
            IEnumerable<CqlConcept> izm_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)izk_, izl_);
            bool? izn_(CqlConcept ObservationCategory)
            {
                CqlCode izs_ = this.exam(context);
                CqlConcept izt_ = context.Operators.ConvertCodeToConcept(izs_);
                bool? izu_ = context.Operators.Equivalent(ObservationCategory, izt_);

                return izu_;
            };
            IEnumerable<CqlConcept> izo_ = context.Operators.Where<CqlConcept>(izm_, izn_);
            bool? izp_ = context.Operators.Exists<CqlConcept>(izo_);
            bool? izq_ = context.Operators.And(izj_, izp_);

            return izq_;
        };
        IEnumerable<Observation> izd_ = context.Operators.Where<Observation>(Obs, izc_);

        return izd_;
    }


    [CqlExpressionDefinition("isPhysicalExamPerformed")]
    public IEnumerable<Observation> isPhysicalExamPerformed(CqlContext context, IEnumerable<Observation> Obs)
    {
        bool? izv_(Observation O)
        {
            Code<ObservationStatus> izx_ = O?.StatusElement;
            ObservationStatus? izy_ = izx_?.Value;
            Code<ObservationStatus> izz_ = context.Operators.Convert<Code<ObservationStatus>>(izy_);
            string jza_ = context.Operators.Convert<string>(izz_);
            string[] jzb_ = [
                "final",
                "amended",
                "corrected",
            ];
            bool? jzc_ = context.Operators.In<string>(jza_, jzb_ as IEnumerable<string>);
            List<CodeableConcept> jzd_ = O?.Category;
            CqlConcept jze_(CodeableConcept @this)
            {
                CqlConcept jzk_ = FHIRHelpers_4_3_000.Instance.ToConcept(context, @this);

                return jzk_;
            };
            IEnumerable<CqlConcept> jzf_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)jzd_, jze_);
            bool? jzg_(CqlConcept ObservationCategory)
            {
                CqlCode jzl_ = this.exam(context);
                CqlConcept jzm_ = context.Operators.ConvertCodeToConcept(jzl_);
                bool? jzn_ = context.Operators.Equivalent(ObservationCategory, jzm_);

                return jzn_;
            };
            IEnumerable<CqlConcept> jzh_ = context.Operators.Where<CqlConcept>(jzf_, jzg_);
            bool? jzi_ = context.Operators.Exists<CqlConcept>(jzh_);
            bool? jzj_ = context.Operators.And(jzc_, jzi_);

            return jzj_;
        };
        IEnumerable<Observation> izw_ = context.Operators.Where<Observation>(Obs, izv_);

        return izw_;
    }


    [CqlExpressionDefinition("BloodPressure")]
    public IEnumerable<Observation> BloodPressure(CqlContext context, IEnumerable<Observation> Obs)
    {
        bool? jzo_(Observation O)
        {
            Code<ObservationStatus> jzq_ = O?.StatusElement;
            ObservationStatus? jzr_ = jzq_?.Value;
            string jzs_ = context.Operators.Convert<string>(jzr_);
            string[] jzt_ = [
                "final",
                "amended",
                "corrected",
            ];
            bool? jzu_ = context.Operators.In<string>(jzs_, jzt_ as IEnumerable<string>);

            return jzu_;
        };
        IEnumerable<Observation> jzp_ = context.Operators.Where<Observation>(Obs, jzo_);

        return jzp_;
    }


    [CqlExpressionDefinition("BodyHeight")]
    public IEnumerable<Observation> BodyHeight(CqlContext context, IEnumerable<Observation> Obs)
    {
        bool? jzv_(Observation O)
        {
            Code<ObservationStatus> jzx_ = O?.StatusElement;
            ObservationStatus? jzy_ = jzx_?.Value;
            string jzz_ = context.Operators.Convert<string>(jzy_);
            string[] kza_ = [
                "final",
                "amended",
                "corrected",
            ];
            bool? kzb_ = context.Operators.In<string>(jzz_, kza_ as IEnumerable<string>);

            return kzb_;
        };
        IEnumerable<Observation> jzw_ = context.Operators.Where<Observation>(Obs, jzv_);

        return jzw_;
    }


    [CqlExpressionDefinition("BodyWeight")]
    public IEnumerable<Observation> BodyWeight(CqlContext context, IEnumerable<Observation> Obs)
    {
        bool? kzc_(Observation O)
        {
            Code<ObservationStatus> kze_ = O?.StatusElement;
            ObservationStatus? kzf_ = kze_?.Value;
            string kzg_ = context.Operators.Convert<string>(kzf_);
            string[] kzh_ = [
                "final",
                "amended",
                "corrected",
            ];
            bool? kzi_ = context.Operators.In<string>(kzg_, kzh_ as IEnumerable<string>);

            return kzi_;
        };
        IEnumerable<Observation> kzd_ = context.Operators.Where<Observation>(Obs, kzc_);

        return kzd_;
    }


    [CqlExpressionDefinition("BMI")]
    public IEnumerable<Observation> BMI(CqlContext context, IEnumerable<Observation> Obs)
    {
        bool? kzj_(Observation O)
        {
            Code<ObservationStatus> kzl_ = O?.StatusElement;
            ObservationStatus? kzm_ = kzl_?.Value;
            string kzn_ = context.Operators.Convert<string>(kzm_);
            string[] kzo_ = [
                "final",
                "amended",
                "corrected",
            ];
            bool? kzp_ = context.Operators.In<string>(kzn_, kzo_ as IEnumerable<string>);

            return kzp_;
        };
        IEnumerable<Observation> kzk_ = context.Operators.Where<Observation>(Obs, kzj_);

        return kzk_;
    }


    [CqlExpressionDefinition("isObservationBP")]
    public IEnumerable<Observation> isObservationBP(CqlContext context, IEnumerable<Observation> Obs)
    {
        bool? kzq_(Observation O)
        {
            Code<ObservationStatus> kzs_ = O?.StatusElement;
            ObservationStatus? kzt_ = kzs_?.Value;
            string kzu_ = context.Operators.Convert<string>(kzt_);
            string[] kzv_ = [
                "final",
                "amended",
                "corrected",
            ];
            bool? kzw_ = context.Operators.In<string>(kzu_, kzv_ as IEnumerable<string>);

            return kzw_;
        };
        IEnumerable<Observation> kzr_ = context.Operators.Where<Observation>(Obs, kzq_);

        return kzr_;
    }


    [CqlExpressionDefinition("isObservationBodyHeight")]
    public IEnumerable<Observation> isObservationBodyHeight(CqlContext context, IEnumerable<Observation> Obs)
    {
        bool? kzx_(Observation O)
        {
            Code<ObservationStatus> kzz_ = O?.StatusElement;
            ObservationStatus? lza_ = kzz_?.Value;
            string lzb_ = context.Operators.Convert<string>(lza_);
            string[] lzc_ = [
                "final",
                "amended",
                "corrected",
            ];
            bool? lzd_ = context.Operators.In<string>(lzb_, lzc_ as IEnumerable<string>);

            return lzd_;
        };
        IEnumerable<Observation> kzy_ = context.Operators.Where<Observation>(Obs, kzx_);

        return kzy_;
    }


    [CqlExpressionDefinition("isObservationBodyWeight")]
    public IEnumerable<Observation> isObservationBodyWeight(CqlContext context, IEnumerable<Observation> Obs)
    {
        bool? lze_(Observation O)
        {
            Code<ObservationStatus> lzg_ = O?.StatusElement;
            ObservationStatus? lzh_ = lzg_?.Value;
            string lzi_ = context.Operators.Convert<string>(lzh_);
            string[] lzj_ = [
                "final",
                "amended",
                "corrected",
            ];
            bool? lzk_ = context.Operators.In<string>(lzi_, lzj_ as IEnumerable<string>);

            return lzk_;
        };
        IEnumerable<Observation> lzf_ = context.Operators.Where<Observation>(Obs, lze_);

        return lzf_;
    }


    [CqlExpressionDefinition("isObservationBMI")]
    public IEnumerable<Observation> isObservationBMI(CqlContext context, IEnumerable<Observation> Obs)
    {
        bool? lzl_(Observation O)
        {
            Code<ObservationStatus> lzn_ = O?.StatusElement;
            ObservationStatus? lzo_ = lzn_?.Value;
            string lzp_ = context.Operators.Convert<string>(lzo_);
            string[] lzq_ = [
                "final",
                "amended",
                "corrected",
            ];
            bool? lzr_ = context.Operators.In<string>(lzp_, lzq_ as IEnumerable<string>);

            return lzr_;
        };
        IEnumerable<Observation> lzm_ = context.Operators.Where<Observation>(Obs, lzl_);

        return lzm_;
    }


    [CqlExpressionDefinition("Initial or Final Observation")]
    public IEnumerable<Observation> Initial_or_Final_Observation(CqlContext context, IEnumerable<Observation> Obs)
    {
        bool? lzs_(Observation O)
        {
            Code<ObservationStatus> lzu_ = O?.StatusElement;
            ObservationStatus? lzv_ = lzu_?.Value;
            Code<ObservationStatus> lzw_ = context.Operators.Convert<Code<ObservationStatus>>(lzv_);
            string lzx_ = context.Operators.Convert<string>(lzw_);
            string[] lzy_ = [
                "preliminary",
                "final",
                "amended",
                "corrected",
            ];
            bool? lzz_ = context.Operators.In<string>(lzx_, lzy_ as IEnumerable<string>);

            return lzz_;
        };
        IEnumerable<Observation> lzt_ = context.Operators.Where<Observation>(Obs, lzs_);

        return lzt_;
    }


    [CqlExpressionDefinition("isSymptom")]
    public IEnumerable<Observation> isSymptom(CqlContext context, IEnumerable<Observation> Obs)
    {
        bool? mza_(Observation O)
        {
            Code<ObservationStatus> mzc_ = O?.StatusElement;
            ObservationStatus? mzd_ = mzc_?.Value;
            Code<ObservationStatus> mze_ = context.Operators.Convert<Code<ObservationStatus>>(mzd_);
            string mzf_ = context.Operators.Convert<string>(mze_);
            string[] mzg_ = [
                "preliminary",
                "final",
                "amended",
                "corrected",
            ];
            bool? mzh_ = context.Operators.In<string>(mzf_, mzg_ as IEnumerable<string>);

            return mzh_;
        };
        IEnumerable<Observation> mzb_ = context.Operators.Where<Observation>(Obs, mza_);

        return mzb_;
    }


    #endregion Expressions

}
