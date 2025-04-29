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
        IEnumerable<Patient> wu_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-patient"));
        Patient wv_ = context.Operators.SingletonFrom<Patient>(wu_);

        return wv_;
    }


    [CqlExpressionDefinition("isAssessmentPerformed")]
    public IEnumerable<Observation> isAssessmentPerformed(CqlContext context, IEnumerable<Observation> Obs)
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
                CqlConcept xl_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);

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


    [CqlExpressionDefinition("isDeviceOrder")]
    public IEnumerable<DeviceRequest> isDeviceOrder(CqlContext context, IEnumerable<DeviceRequest> DeviceRequest)
    {
        bool? xp_(DeviceRequest D)
        {
            Code<RequestStatus> xr_ = D?.StatusElement;
            RequestStatus? xs_ = xr_?.Value;
            Code<RequestStatus> xt_ = context.Operators.Convert<Code<RequestStatus>>(xs_);
            string xu_ = context.Operators.Convert<string>(xt_);
            string[] xv_ = [
                "active",
                "completed",
            ];
            bool? xw_ = context.Operators.In<string>(xu_, xv_ as IEnumerable<string>);
            Code<RequestIntent> xx_ = D?.IntentElement;
            RequestIntent? xy_ = xx_?.Value;
            Code<RequestIntent> xz_ = context.Operators.Convert<Code<RequestIntent>>(xy_);
            bool? ya_ = context.Operators.Equal(xz_, "order");
            bool? yb_ = context.Operators.And(xw_, ya_);

            return yb_;
        };
        IEnumerable<DeviceRequest> xq_ = context.Operators.Where<DeviceRequest>(DeviceRequest, xp_);

        return xq_;
    }


    [CqlExpressionDefinition("isDiagnosticStudyOrder")]
    public IEnumerable<ServiceRequest> isDiagnosticStudyOrder(CqlContext context, IEnumerable<ServiceRequest> ServiceRequest)
    {
        bool? yc_(ServiceRequest S)
        {
            Code<RequestStatus> ye_ = S?.StatusElement;
            RequestStatus? yf_ = ye_?.Value;
            Code<RequestStatus> yg_ = context.Operators.Convert<Code<RequestStatus>>(yf_);
            string yh_ = context.Operators.Convert<string>(yg_);
            string[] yi_ = [
                "active",
                "completed",
            ];
            bool? yj_ = context.Operators.In<string>(yh_, yi_ as IEnumerable<string>);
            Code<RequestIntent> yk_ = S?.IntentElement;
            RequestIntent? yl_ = yk_?.Value;
            Code<RequestIntent> ym_ = context.Operators.Convert<Code<RequestIntent>>(yl_);
            bool? yn_ = context.Operators.Equal(ym_, "order");
            bool? yo_ = context.Operators.And(yj_, yn_);

            return yo_;
        };
        IEnumerable<ServiceRequest> yd_ = context.Operators.Where<ServiceRequest>(ServiceRequest, yc_);

        return yd_;
    }


    [CqlExpressionDefinition("isInterventionOrder")]
    public IEnumerable<ServiceRequest> isInterventionOrder(CqlContext context, IEnumerable<ServiceRequest> ServiceRequest)
    {
        bool? yp_(ServiceRequest S)
        {
            Code<RequestStatus> yr_ = S?.StatusElement;
            RequestStatus? ys_ = yr_?.Value;
            Code<RequestStatus> yt_ = context.Operators.Convert<Code<RequestStatus>>(ys_);
            string yu_ = context.Operators.Convert<string>(yt_);
            string[] yv_ = [
                "active",
                "completed",
            ];
            bool? yw_ = context.Operators.In<string>(yu_, yv_ as IEnumerable<string>);
            Code<RequestIntent> yx_ = S?.IntentElement;
            RequestIntent? yy_ = yx_?.Value;
            Code<RequestIntent> yz_ = context.Operators.Convert<Code<RequestIntent>>(yy_);
            bool? za_ = context.Operators.Equal(yz_, "order");
            bool? zb_ = context.Operators.And(yw_, za_);

            return zb_;
        };
        IEnumerable<ServiceRequest> yq_ = context.Operators.Where<ServiceRequest>(ServiceRequest, yp_);

        return yq_;
    }


    [CqlExpressionDefinition("isLaboratoryTestOrder")]
    public IEnumerable<ServiceRequest> isLaboratoryTestOrder(CqlContext context, IEnumerable<ServiceRequest> ServiceRequest)
    {
        bool? zc_(ServiceRequest S)
        {
            Code<RequestStatus> ze_ = S?.StatusElement;
            RequestStatus? zf_ = ze_?.Value;
            Code<RequestStatus> zg_ = context.Operators.Convert<Code<RequestStatus>>(zf_);
            string zh_ = context.Operators.Convert<string>(zg_);
            string[] zi_ = [
                "active",
                "completed",
            ];
            bool? zj_ = context.Operators.In<string>(zh_, zi_ as IEnumerable<string>);
            Code<RequestIntent> zk_ = S?.IntentElement;
            RequestIntent? zl_ = zk_?.Value;
            Code<RequestIntent> zm_ = context.Operators.Convert<Code<RequestIntent>>(zl_);
            bool? zn_ = context.Operators.Equal(zm_, "order");
            bool? zo_ = context.Operators.And(zj_, zn_);

            return zo_;
        };
        IEnumerable<ServiceRequest> zd_ = context.Operators.Where<ServiceRequest>(ServiceRequest, zc_);

        return zd_;
    }


    [CqlExpressionDefinition("isDiagnosticStudyPerformed")]
    public IEnumerable<Observation> isDiagnosticStudyPerformed(CqlContext context, IEnumerable<Observation> Obs)
    {
        bool? zp_(Observation O)
        {
            Code<ObservationStatus> zr_ = O?.StatusElement;
            ObservationStatus? zs_ = zr_?.Value;
            Code<ObservationStatus> zt_ = context.Operators.Convert<Code<ObservationStatus>>(zs_);
            string zu_ = context.Operators.Convert<string>(zt_);
            string[] zv_ = [
                "final",
                "amended",
                "corrected",
            ];
            bool? zw_ = context.Operators.In<string>(zu_, zv_ as IEnumerable<string>);

            return zw_;
        };
        IEnumerable<Observation> zq_ = context.Operators.Where<Observation>(Obs, zp_);

        return zq_;
    }


    [CqlExpressionDefinition("isEncounterPerformed")]
    public IEnumerable<Encounter> isEncounterPerformed(CqlContext context, IEnumerable<Encounter> Enc)
    {
        bool? zx_(Encounter E)
        {
            Code<Encounter.EncounterStatus> zz_ = E?.StatusElement;
            Encounter.EncounterStatus? aza_ = zz_?.Value;
            Code<Encounter.EncounterStatus> azb_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(aza_);
            string azc_ = context.Operators.Convert<string>(azb_);
            string[] azd_ = [
                "finished",
                "arrived",
                "triaged",
                "in-progress",
                "onleave",
            ];
            bool? aze_ = context.Operators.In<string>(azc_, azd_ as IEnumerable<string>);

            return aze_;
        };
        IEnumerable<Encounter> zy_ = context.Operators.Where<Encounter>(Enc, zx_);

        return zy_;
    }


    [CqlExpressionDefinition("isImmunizationAdministered")]
    public IEnumerable<Immunization> isImmunizationAdministered(CqlContext context, IEnumerable<Immunization> Immunization)
    {
        bool? azf_(Immunization I)
        {
            Code<Immunization.ImmunizationStatusCodes> azh_ = I?.StatusElement;
            Immunization.ImmunizationStatusCodes? azi_ = azh_?.Value;
            string azj_ = context.Operators.Convert<string>(azi_);
            bool? azk_ = context.Operators.Equivalent(azj_, "completed");

            return azk_;
        };
        IEnumerable<Immunization> azg_ = context.Operators.Where<Immunization>(Immunization, azf_);

        return azg_;
    }


    [CqlExpressionDefinition("isInterventionPerformed")]
    public IEnumerable<Procedure> isInterventionPerformed(CqlContext context, IEnumerable<Procedure> Proc)
    {
        bool? azl_(Procedure P)
        {
            Code<EventStatus> azn_ = P?.StatusElement;
            EventStatus? azo_ = azn_?.Value;
            string azp_ = context.Operators.Convert<string>(azo_);
            bool? azq_ = context.Operators.Equivalent(azp_, "completed");

            return azq_;
        };
        IEnumerable<Procedure> azm_ = context.Operators.Where<Procedure>(Proc, azl_);

        return azm_;
    }


    [CqlExpressionDefinition("isProcedurePerformed")]
    public IEnumerable<Procedure> isProcedurePerformed(CqlContext context, IEnumerable<Procedure> Proc)
    {
        bool? azr_(Procedure P)
        {
            Code<EventStatus> azt_ = P?.StatusElement;
            EventStatus? azu_ = azt_?.Value;
            string azv_ = context.Operators.Convert<string>(azu_);
            bool? azw_ = context.Operators.Equivalent(azv_, "completed");

            return azw_;
        };
        IEnumerable<Procedure> azs_ = context.Operators.Where<Procedure>(Proc, azr_);

        return azs_;
    }


    [CqlExpressionDefinition("isLaboratoryTestPerformed")]
    public IEnumerable<Observation> isLaboratoryTestPerformed(CqlContext context, IEnumerable<Observation> Obs)
    {
        bool? azx_(Observation O)
        {
            Code<ObservationStatus> azz_ = O?.StatusElement;
            ObservationStatus? bza_ = azz_?.Value;
            Code<ObservationStatus> bzb_ = context.Operators.Convert<Code<ObservationStatus>>(bza_);
            string bzc_ = context.Operators.Convert<string>(bzb_);
            string[] bzd_ = [
                "final",
                "amended",
                "corrected",
            ];
            bool? bze_ = context.Operators.In<string>(bzc_, bzd_ as IEnumerable<string>);
            List<CodeableConcept> bzf_ = O?.Category;
            CqlConcept bzg_(CodeableConcept @this)
            {
                CqlConcept bzm_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);

                return bzm_;
            };
            IEnumerable<CqlConcept> bzh_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)bzf_, bzg_);
            bool? bzi_(CqlConcept ObservationCategory)
            {
                CqlCode bzn_ = this.laboratory(context);
                CqlConcept bzo_ = context.Operators.ConvertCodeToConcept(bzn_);
                bool? bzp_ = context.Operators.Equivalent(ObservationCategory, bzo_);

                return bzp_;
            };
            IEnumerable<CqlConcept> bzj_ = context.Operators.Where<CqlConcept>(bzh_, bzi_);
            bool? bzk_ = context.Operators.Exists<CqlConcept>(bzj_);
            bool? bzl_ = context.Operators.And(bze_, bzk_);

            return bzl_;
        };
        IEnumerable<Observation> azy_ = context.Operators.Where<Observation>(Obs, azx_);

        return azy_;
    }


    [CqlExpressionDefinition("isMedicationActive")]
    public IEnumerable<MedicationRequest> isMedicationActive(CqlContext context, IEnumerable<MedicationRequest> MedicationRequest)
    {
        bool? bzq_(MedicationRequest M)
        {
            Code<MedicationRequest.MedicationrequestStatus> bzs_ = M?.StatusElement;
            MedicationRequest.MedicationrequestStatus? bzt_ = bzs_?.Value;
            string bzu_ = context.Operators.Convert<string>(bzt_);
            bool? bzv_ = context.Operators.Equal(bzu_, "active");
            Code<MedicationRequest.MedicationRequestIntent> bzw_ = M?.IntentElement;
            MedicationRequest.MedicationRequestIntent? bzx_ = bzw_?.Value;
            string bzy_ = context.Operators.Convert<string>(bzx_);
            bool? bzz_ = context.Operators.Equal(bzy_, "order");
            bool? cza_ = context.Operators.And(bzv_, bzz_);

            return cza_;
        };
        IEnumerable<MedicationRequest> bzr_ = context.Operators.Where<MedicationRequest>(MedicationRequest, bzq_);

        return bzr_;
    }


    [CqlExpressionDefinition("isMedicationDispensed")]
    public IEnumerable<MedicationDispense> isMedicationDispensed(CqlContext context, IEnumerable<MedicationDispense> Med)
    {
        bool? czb_(MedicationDispense M)
        {
            Code<MedicationDispense.MedicationDispenseStatusCodes> czd_ = M?.StatusElement;
            MedicationDispense.MedicationDispenseStatusCodes? cze_ = czd_?.Value;
            Code<MedicationDispense.MedicationDispenseStatusCodes> czf_ = context.Operators.Convert<Code<MedicationDispense.MedicationDispenseStatusCodes>>(cze_);
            string czg_ = context.Operators.Convert<string>(czf_);
            string[] czh_ = [
                "completed",
                "in-progress",
                "on-hold",
            ];
            bool? czi_ = context.Operators.In<string>(czg_, czh_ as IEnumerable<string>);

            return czi_;
        };
        IEnumerable<MedicationDispense> czc_ = context.Operators.Where<MedicationDispense>(Med, czb_);

        return czc_;
    }


    [CqlExpressionDefinition("isMedicationOrder")]
    public IEnumerable<MedicationRequest> isMedicationOrder(CqlContext context, IEnumerable<MedicationRequest> MedicationRequest)
    {
        bool? czj_(MedicationRequest M)
        {
            Code<MedicationRequest.MedicationrequestStatus> czl_ = M?.StatusElement;
            MedicationRequest.MedicationrequestStatus? czm_ = czl_?.Value;
            string czn_ = context.Operators.Convert<string>(czm_);
            string[] czo_ = [
                "active",
                "completed",
            ];
            bool? czp_ = context.Operators.In<string>(czn_, czo_ as IEnumerable<string>);
            Code<MedicationRequest.MedicationRequestIntent> czq_ = M?.IntentElement;
            MedicationRequest.MedicationRequestIntent? czr_ = czq_?.Value;
            string czs_ = context.Operators.Convert<string>(czr_);
            bool? czt_ = context.Operators.Equal(czs_, "order");
            bool? czu_ = context.Operators.And(czp_, czt_);

            return czu_;
        };
        IEnumerable<MedicationRequest> czk_ = context.Operators.Where<MedicationRequest>(MedicationRequest, czj_);

        return czk_;
    }


    [CqlExpressionDefinition("isPhysicalExamPerformed")]
    public IEnumerable<Observation> isPhysicalExamPerformed(CqlContext context, IEnumerable<Observation> Obs)
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
                CqlConcept dzk_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);

                return dzk_;
            };
            IEnumerable<CqlConcept> dzf_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)dzd_, dze_);
            bool? dzg_(CqlConcept ObservationCategory)
            {
                CqlCode dzl_ = this.exam(context);
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


    [CqlExpressionDefinition("isObservationBP")]
    public IEnumerable<Observation> isObservationBP(CqlContext context, IEnumerable<Observation> Obs)
    {
        bool? dzo_(Observation O)
        {
            Code<ObservationStatus> dzq_ = O?.StatusElement;
            ObservationStatus? dzr_ = dzq_?.Value;
            string dzs_ = context.Operators.Convert<string>(dzr_);
            string[] dzt_ = [
                "final",
                "amended",
                "corrected",
            ];
            bool? dzu_ = context.Operators.In<string>(dzs_, dzt_ as IEnumerable<string>);

            return dzu_;
        };
        IEnumerable<Observation> dzp_ = context.Operators.Where<Observation>(Obs, dzo_);

        return dzp_;
    }


    [CqlExpressionDefinition("isObservationBodyHeight")]
    public IEnumerable<Observation> isObservationBodyHeight(CqlContext context, IEnumerable<Observation> Obs)
    {
        bool? dzv_(Observation O)
        {
            Code<ObservationStatus> dzx_ = O?.StatusElement;
            ObservationStatus? dzy_ = dzx_?.Value;
            string dzz_ = context.Operators.Convert<string>(dzy_);
            string[] eza_ = [
                "final",
                "amended",
                "corrected",
            ];
            bool? ezb_ = context.Operators.In<string>(dzz_, eza_ as IEnumerable<string>);

            return ezb_;
        };
        IEnumerable<Observation> dzw_ = context.Operators.Where<Observation>(Obs, dzv_);

        return dzw_;
    }


    [CqlExpressionDefinition("isObservationBodyWeight")]
    public IEnumerable<Observation> isObservationBodyWeight(CqlContext context, IEnumerable<Observation> Obs)
    {
        bool? ezc_(Observation O)
        {
            Code<ObservationStatus> eze_ = O?.StatusElement;
            ObservationStatus? ezf_ = eze_?.Value;
            string ezg_ = context.Operators.Convert<string>(ezf_);
            string[] ezh_ = [
                "final",
                "amended",
                "corrected",
            ];
            bool? ezi_ = context.Operators.In<string>(ezg_, ezh_ as IEnumerable<string>);

            return ezi_;
        };
        IEnumerable<Observation> ezd_ = context.Operators.Where<Observation>(Obs, ezc_);

        return ezd_;
    }


    [CqlExpressionDefinition("isObservationBMI")]
    public IEnumerable<Observation> isObservationBMI(CqlContext context, IEnumerable<Observation> Obs)
    {
        bool? ezj_(Observation O)
        {
            Code<ObservationStatus> ezl_ = O?.StatusElement;
            ObservationStatus? ezm_ = ezl_?.Value;
            string ezn_ = context.Operators.Convert<string>(ezm_);
            string[] ezo_ = [
                "final",
                "amended",
                "corrected",
            ];
            bool? ezp_ = context.Operators.In<string>(ezn_, ezo_ as IEnumerable<string>);

            return ezp_;
        };
        IEnumerable<Observation> ezk_ = context.Operators.Where<Observation>(Obs, ezj_);

        return ezk_;
    }


    [CqlExpressionDefinition("isSymptom")]
    public IEnumerable<Observation> isSymptom(CqlContext context, IEnumerable<Observation> Obs)
    {
        bool? ezq_(Observation O)
        {
            Code<ObservationStatus> ezs_ = O?.StatusElement;
            ObservationStatus? ezt_ = ezs_?.Value;
            Code<ObservationStatus> ezu_ = context.Operators.Convert<Code<ObservationStatus>>(ezt_);
            string ezv_ = context.Operators.Convert<string>(ezu_);
            string[] ezw_ = [
                "preliminary",
                "final",
                "amended",
                "corrected",
            ];
            bool? ezx_ = context.Operators.In<string>(ezv_, ezw_ as IEnumerable<string>);

            return ezx_;
        };
        IEnumerable<Observation> ezr_ = context.Operators.Where<Observation>(Obs, ezq_);

        return ezr_;
    }


    #endregion Expressions

}
