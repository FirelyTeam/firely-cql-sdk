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
[CqlLibrary("SupplementalDataElements", "3.5.000")]
public partial class SupplementalDataElements_3_5_000 : ILibrary, ISingleton<SupplementalDataElements_3_5_000>
{
    private SupplementalDataElements_3_5_000() {}

    public static SupplementalDataElements_3_5_000 Instance { get; } = new();

    #region ILibrary Implementation

    public string Name => "SupplementalDataElements";
    public string Version => "3.5.000";
    public ILibrary[] Dependencies => [FHIRHelpers_4_4_000.Instance];

    #endregion ILibrary Implementation

    #region ValueSets

    [CqlValueSetDefinition("Ethnicity", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.114222.4.11.837", valueSetVersion: null)]
    public CqlValueSet Ethnicity(CqlContext _) => _Ethnicity;
    private static readonly CqlValueSet _Ethnicity = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.114222.4.11.837", null);

    [CqlValueSetDefinition("ONC Administrative Sex", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1", valueSetVersion: null)]
    public CqlValueSet ONC_Administrative_Sex(CqlContext _) => _ONC_Administrative_Sex;
    private static readonly CqlValueSet _ONC_Administrative_Sex = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1", null);

    [CqlValueSetDefinition("Payer Type", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.114222.4.11.3591", valueSetVersion: null)]
    public CqlValueSet Payer_Type(CqlContext _) => _Payer_Type;
    private static readonly CqlValueSet _Payer_Type = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.114222.4.11.3591", null);

    [CqlValueSetDefinition("Race", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.114222.4.11.836", valueSetVersion: null)]
    public CqlValueSet Race(CqlContext _) => _Race;
    private static readonly CqlValueSet _Race = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.114222.4.11.836", null);

    #endregion ValueSets

    #region Codes

    [CqlCodeDefinition("M", codeId: "M", codeSystem: "http://hl7.org/fhir/administrative-gender")]
    public CqlCode M(CqlContext _) => _M;
    private static readonly CqlCode _M = new CqlCode("M", "http://hl7.org/fhir/administrative-gender");

    [CqlCodeDefinition("F", codeId: "F", codeSystem: "http://hl7.org/fhir/administrative-gender")]
    public CqlCode F(CqlContext _) => _F;
    private static readonly CqlCode _F = new CqlCode("F", "http://hl7.org/fhir/administrative-gender");

    #endregion Codes

    #region CodeSystems

    [CqlCodeSystemDefinition("AdministrativeGender")]
    public CqlCodeSystem AdministrativeGender(CqlContext _) => _AdministrativeGender;
    private static readonly CqlCodeSystem _AdministrativeGender =
      new CqlCodeSystem("http://hl7.org/fhir/administrative-gender", null, [
          _M,
          _F]);

    #endregion CodeSystems

    #region Expressions

    [CqlExpressionDefinition("Patient")]
    public Patient Patient(CqlContext context)
    {
        IEnumerable<Patient> wr_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-patient"));
        Patient ws_ = context.Operators.SingletonFrom<Patient>(wr_);

        return ws_;
    }


    [CqlExpressionDefinition("SDE Ethnicity")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Ethnicity(CqlContext context)
    {
        List<Extension> wt_()
        {
            bool xc_()
            {
                Patient xd_ = this.Patient(context);
                bool xe_ = xd_ is DomainResource;

                return xe_;
            };
            if (xc_())
            {
                Patient xf_ = this.Patient(context);

                return (xf_ as DomainResource).Extension;
            }
            else
            {
                return default;
            }
        };
        bool? wu_(Extension @this)
        {
            string xg_ = @this?.Url;
            FhirString xh_ = context.Operators.Convert<FhirString>(xg_);
            string xi_ = FHIRHelpers_4_4_000.Instance.ToString(context, xh_);
            bool? xj_ = context.Operators.Equal(xi_, "http://hl7.org/fhir/us/core/StructureDefinition/us-core-ethnicity");

            return xj_;
        };
        IEnumerable<Extension> wv_ = context.Operators.Where<Extension>((IEnumerable<Extension>)(wt_()), wu_);
        Extension ww_ = context.Operators.SingletonFrom<Extension>(wv_);
        Extension[] wx_ = [
            ww_,
        ];
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? wy_(Extension E)
        {
            bool? xk_(Extension @this)
            {
                string yf_ = @this?.Url;
                FhirString yg_ = context.Operators.Convert<FhirString>(yf_);
                string yh_ = FHIRHelpers_4_4_000.Instance.ToString(context, yg_);
                bool? yi_ = context.Operators.Equal(yh_, "ombCategory");

                return yi_;
            };
            IEnumerable<Extension> xl_ = context.Operators.Where<Extension>((IEnumerable<Extension>)(E is Element
                    ? (E as Element).Extension
                    : default), xk_);
            object xm_(Extension @this)
            {
                DataType yj_ = @this?.Value;

                return yj_;
            };
            IEnumerable<object> xn_ = context.Operators.Select<Extension, object>(xl_, xm_);
            object xo_ = context.Operators.SingletonFrom<object>(xn_);
            CqlCode xp_ = FHIRHelpers_4_4_000.Instance.ToCode(context, xo_ as Coding);
            CqlCode[] xq_ = [
                xp_,
            ];
            bool? xr_(Extension @this)
            {
                string yk_ = @this?.Url;
                FhirString yl_ = context.Operators.Convert<FhirString>(yk_);
                string ym_ = FHIRHelpers_4_4_000.Instance.ToString(context, yl_);
                bool? yn_ = context.Operators.Equal(ym_, "detailed");

                return yn_;
            };
            IEnumerable<Extension> xs_ = context.Operators.Where<Extension>((IEnumerable<Extension>)(E is Element
                    ? (E as Element).Extension
                    : default), xr_);
            object xt_(Extension @this)
            {
                DataType yo_ = @this?.Value;

                return yo_;
            };
            IEnumerable<object> xu_ = context.Operators.Select<Extension, object>(xs_, xt_);
            CqlCode xv_(object @this)
            {
                CqlCode yp_ = FHIRHelpers_4_4_000.Instance.ToCode(context, @this as Coding);

                return yp_;
            };
            IEnumerable<CqlCode> xw_ = context.Operators.Select<object, CqlCode>(xu_, xv_);
            IEnumerable<CqlCode> xx_ = context.Operators.Union<CqlCode>(xq_ as IEnumerable<CqlCode>, xw_);
            bool? xy_(Extension @this)
            {
                string yq_ = @this?.Url;
                FhirString yr_ = context.Operators.Convert<FhirString>(yq_);
                string ys_ = FHIRHelpers_4_4_000.Instance.ToString(context, yr_);
                bool? yt_ = context.Operators.Equal(ys_, "text");

                return yt_;
            };
            IEnumerable<Extension> xz_ = context.Operators.Where<Extension>((IEnumerable<Extension>)(E is Element
                    ? (E as Element).Extension
                    : default), xy_);
            DataType ya_(Extension @this)
            {
                DataType yu_ = @this?.Value;

                return yu_;
            };
            IEnumerable<DataType> yb_ = context.Operators.Select<Extension, DataType>(xz_, ya_);
            DataType yc_ = context.Operators.SingletonFrom<DataType>(yb_);
            string yd_ = context.Operators.Convert<string>(yc_);
            (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? ye_ = (CqlTupleMetadata_HPcCiDPXQfZTXIORThMLfTQDR, xx_, yd_);

            return ye_;
        };
        IEnumerable<(CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)?> wz_ = context.Operators.Select<Extension, (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)?>((IEnumerable<Extension>)wx_, wy_);
        IEnumerable<(CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)?> xa_ = context.Operators.Distinct<(CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)?>(wz_);
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? xb_ = context.Operators.SingletonFrom<(CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)?>(xa_);

        return xb_;
    }


    [CqlExpressionDefinition("SDE Payer")]
    public IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> SDE_Payer(CqlContext context)
    {
        CqlValueSet yv_ = this.Payer_Type(context);
        IEnumerable<Coverage> yw_ = context.Operators.Retrieve<Coverage>(new RetrieveParameters(default, yv_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-coverage"));
        (CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)? yx_(Coverage Payer)
        {
            CodeableConcept za_ = Payer?.Type;
            CqlConcept zb_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, za_);
            Period zc_ = Payer?.Period;
            CqlInterval<CqlDateTime> zd_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, zc_);
            (CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)? ze_ = (CqlTupleMetadata_GPRWMPNAYaJRiGDFSTLJOPeIJ, zb_, zd_);

            return ze_;
        };
        IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> yy_ = context.Operators.Select<Coverage, (CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?>(yw_, yx_);
        IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> yz_ = context.Operators.Distinct<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?>(yy_);

        return yz_;
    }


    [CqlExpressionDefinition("SDE Race")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Race(CqlContext context)
    {
        List<Extension> zf_()
        {
            bool zo_()
            {
                Patient zp_ = this.Patient(context);
                bool zq_ = zp_ is DomainResource;

                return zq_;
            };
            if (zo_())
            {
                Patient zr_ = this.Patient(context);

                return (zr_ as DomainResource).Extension;
            }
            else
            {
                return default;
            }
        };
        bool? zg_(Extension @this)
        {
            string zs_ = @this?.Url;
            FhirString zt_ = context.Operators.Convert<FhirString>(zs_);
            string zu_ = FHIRHelpers_4_4_000.Instance.ToString(context, zt_);
            bool? zv_ = context.Operators.Equal(zu_, "http://hl7.org/fhir/us/core/StructureDefinition/us-core-race");

            return zv_;
        };
        IEnumerable<Extension> zh_ = context.Operators.Where<Extension>((IEnumerable<Extension>)(zf_()), zg_);
        Extension zi_ = context.Operators.SingletonFrom<Extension>(zh_);
        Extension[] zj_ = [
            zi_,
        ];
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? zk_(Extension R)
        {
            bool? zw_(Extension @this)
            {
                string azq_ = @this?.Url;
                FhirString azr_ = context.Operators.Convert<FhirString>(azq_);
                string azs_ = FHIRHelpers_4_4_000.Instance.ToString(context, azr_);
                bool? azt_ = context.Operators.Equal(azs_, "ombCategory");

                return azt_;
            };
            IEnumerable<Extension> zx_ = context.Operators.Where<Extension>((IEnumerable<Extension>)(R is Element
                    ? (R as Element).Extension
                    : default), zw_);
            object zy_(Extension @this)
            {
                DataType azu_ = @this?.Value;

                return azu_;
            };
            IEnumerable<object> zz_ = context.Operators.Select<Extension, object>(zx_, zy_);
            CqlCode aza_(object @this)
            {
                CqlCode azv_ = FHIRHelpers_4_4_000.Instance.ToCode(context, @this as Coding);

                return azv_;
            };
            IEnumerable<CqlCode> azb_ = context.Operators.Select<object, CqlCode>(zz_, aza_);
            bool? azc_(Extension @this)
            {
                string azw_ = @this?.Url;
                FhirString azx_ = context.Operators.Convert<FhirString>(azw_);
                string azy_ = FHIRHelpers_4_4_000.Instance.ToString(context, azx_);
                bool? azz_ = context.Operators.Equal(azy_, "detailed");

                return azz_;
            };
            IEnumerable<Extension> azd_ = context.Operators.Where<Extension>((IEnumerable<Extension>)(R is Element
                    ? (R as Element).Extension
                    : default), azc_);
            object aze_(Extension @this)
            {
                DataType bza_ = @this?.Value;

                return bza_;
            };
            IEnumerable<object> azf_ = context.Operators.Select<Extension, object>(azd_, aze_);
            CqlCode azg_(object @this)
            {
                CqlCode bzb_ = FHIRHelpers_4_4_000.Instance.ToCode(context, @this as Coding);

                return bzb_;
            };
            IEnumerable<CqlCode> azh_ = context.Operators.Select<object, CqlCode>(azf_, azg_);
            IEnumerable<CqlCode> azi_ = context.Operators.Union<CqlCode>(azb_, azh_);
            bool? azj_(Extension @this)
            {
                string bzc_ = @this?.Url;
                FhirString bzd_ = context.Operators.Convert<FhirString>(bzc_);
                string bze_ = FHIRHelpers_4_4_000.Instance.ToString(context, bzd_);
                bool? bzf_ = context.Operators.Equal(bze_, "text");

                return bzf_;
            };
            IEnumerable<Extension> azk_ = context.Operators.Where<Extension>((IEnumerable<Extension>)(R is Element
                    ? (R as Element).Extension
                    : default), azj_);
            DataType azl_(Extension @this)
            {
                DataType bzg_ = @this?.Value;

                return bzg_;
            };
            IEnumerable<DataType> azm_ = context.Operators.Select<Extension, DataType>(azk_, azl_);
            DataType azn_ = context.Operators.SingletonFrom<DataType>(azm_);
            string azo_ = context.Operators.Convert<string>(azn_);
            (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? azp_ = (CqlTupleMetadata_HPcCiDPXQfZTXIORThMLfTQDR, azi_, azo_);

            return azp_;
        };
        IEnumerable<(CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)?> zl_ = context.Operators.Select<Extension, (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)?>((IEnumerable<Extension>)zj_, zk_);
        IEnumerable<(CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)?> zm_ = context.Operators.Distinct<(CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)?>(zl_);
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? zn_ = context.Operators.SingletonFrom<(CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)?>(zm_);

        return zn_;
    }


    [CqlExpressionDefinition("SDE Sex")]
    public CqlCode SDE_Sex(CqlContext context)
    {
        CqlCode bzh_()
        {
            bool bzi_()
            {
                Patient bzk_ = this.Patient(context);
                Code<AdministrativeGender> bzl_ = bzk_?.GenderElement;
                AdministrativeGender? bzm_ = bzl_?.Value;
                string bzn_ = context.Operators.Convert<string>(bzm_);
                bool? bzo_ = context.Operators.Equal(bzn_, "male");

                return bzo_ ?? false;
            };
            bool bzj_()
            {
                Patient bzp_ = this.Patient(context);
                Code<AdministrativeGender> bzq_ = bzp_?.GenderElement;
                AdministrativeGender? bzr_ = bzq_?.Value;
                string bzs_ = context.Operators.Convert<string>(bzr_);
                bool? bzt_ = context.Operators.Equal(bzs_, "female");

                return bzt_ ?? false;
            };
            if (bzi_())
            {
                CqlCode bzu_ = this.M(context);

                return bzu_;
            }
            else if (bzj_())
            {
                CqlCode bzv_ = this.F(context);

                return bzv_;
            }
            else
            {
                return default;
            }
        };

        return bzh_();
    }


    #endregion Expressions

    #region CqlTupleMetadata Properties

    private static CqlTupleMetadata CqlTupleMetadata_GPRWMPNAYaJRiGDFSTLJOPeIJ = new(
        [typeof(CqlConcept), typeof(CqlInterval<CqlDateTime>)],
        ["code", "period"]);

    private static CqlTupleMetadata CqlTupleMetadata_HPcCiDPXQfZTXIORThMLfTQDR = new(
        [typeof(IEnumerable<CqlCode>), typeof(string)],
        ["codes", "display"]);

    #endregion CqlTupleMetadata Properties

}
