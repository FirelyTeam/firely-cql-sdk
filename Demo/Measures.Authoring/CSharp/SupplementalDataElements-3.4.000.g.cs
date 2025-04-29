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
[CqlLibrary("SupplementalDataElements", "3.4.000")]
public partial class SupplementalDataElements_3_4_000 : ILibrary, ISingleton<SupplementalDataElements_3_4_000>
{
    private SupplementalDataElements_3_4_000() {}

    public static SupplementalDataElements_3_4_000 Instance { get; } = new();

    #region ILibrary Implementation

    public string Name => "SupplementalDataElements";
    public string Version => "3.4.000";
    public ILibrary[] Dependencies => [FHIRHelpers_4_3_000.Instance];

    #endregion ILibrary Implementation

    #region ValueSets

    #region ValueSet: Ethnicity
    [CqlValueSetDefinition(
        definitionName: "Ethnicity",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.114222.4.11.837",
        valueSetVersion: null)]
    public CqlValueSet Ethnicity(CqlContext context) => _Ethnicity;

    private static readonly CqlValueSet _Ethnicity = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.114222.4.11.837", null);
    #endregion

    #region ValueSet: ONC Administrative Sex
    [CqlValueSetDefinition(
        definitionName: "ONC Administrative Sex",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1",
        valueSetVersion: null)]
    public CqlValueSet ONC_Administrative_Sex(CqlContext context) => _ONC_Administrative_Sex;

    private static readonly CqlValueSet _ONC_Administrative_Sex = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1", null);
    #endregion

    #region ValueSet: Payer Type
    [CqlValueSetDefinition(
        definitionName: "Payer Type",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.114222.4.11.3591",
        valueSetVersion: null)]
    public CqlValueSet Payer_Type(CqlContext context) => _Payer_Type;

    private static readonly CqlValueSet _Payer_Type = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.114222.4.11.3591", null);
    #endregion

    #region ValueSet: Race
    [CqlValueSetDefinition(
        definitionName: "Race",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.114222.4.11.836",
        valueSetVersion: null)]
    public CqlValueSet Race(CqlContext context) => _Race;

    private static readonly CqlValueSet _Race = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.114222.4.11.836", null);
    #endregion

    #endregion ValueSets

    #region Expressions

    [CqlExpressionDefinition(
        definitionName: "Patient")]
    public Patient Patient(CqlContext context)
    {
        IEnumerable<Patient> wu_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-patient"));
        Patient wv_ = context.Operators.SingletonFrom<Patient>(wu_);

        return wv_;
    }


    [CqlExpressionDefinition(
        definitionName: "SDE Ethnicity")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Ethnicity(CqlContext context)
    {
        List<Extension> ww_()
        {
            bool xf_()
            {
                Patient xg_ = this.Patient(context);
                bool xh_ = xg_ is DomainResource;

                return xh_;
            };
            if (xf_())
            {
                Patient xi_ = this.Patient(context);

                return (xi_ as DomainResource).Extension;
            }
            else
            {
                return default;
            }
        };
        bool? wx_(Extension @this)
        {
            string xj_ = @this?.Url;
            FhirString xk_ = context.Operators.Convert<FhirString>(xj_);
            string xl_ = FHIRHelpers_4_3_000.Instance.ToString(context, xk_);
            bool? xm_ = context.Operators.Equal(xl_, "http://hl7.org/fhir/us/core/StructureDefinition/us-core-ethnicity");

            return xm_;
        };
        IEnumerable<Extension> wy_ = context.Operators.Where<Extension>((IEnumerable<Extension>)(ww_()), wx_);
        Extension wz_ = context.Operators.SingletonFrom<Extension>(wy_);
        Extension[] xa_ = [
            wz_,
        ];
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? xb_(Extension E)
        {
            bool? xn_(Extension @this)
            {
                string yi_ = @this?.Url;
                FhirString yj_ = context.Operators.Convert<FhirString>(yi_);
                string yk_ = FHIRHelpers_4_3_000.Instance.ToString(context, yj_);
                bool? yl_ = context.Operators.Equal(yk_, "ombCategory");

                return yl_;
            };
            IEnumerable<Extension> xo_ = context.Operators.Where<Extension>((IEnumerable<Extension>)(E is Element
                    ? (E as Element).Extension
                    : default), xn_);
            object xp_(Extension @this)
            {
                DataType ym_ = @this?.Value;

                return ym_;
            };
            IEnumerable<object> xq_ = context.Operators.Select<Extension, object>(xo_, xp_);
            object xr_ = context.Operators.SingletonFrom<object>(xq_);
            CqlCode xs_ = FHIRHelpers_4_3_000.Instance.ToCode(context, xr_ as Coding);
            CqlCode[] xt_ = [
                xs_,
            ];
            bool? xu_(Extension @this)
            {
                string yn_ = @this?.Url;
                FhirString yo_ = context.Operators.Convert<FhirString>(yn_);
                string yp_ = FHIRHelpers_4_3_000.Instance.ToString(context, yo_);
                bool? yq_ = context.Operators.Equal(yp_, "detailed");

                return yq_;
            };
            IEnumerable<Extension> xv_ = context.Operators.Where<Extension>((IEnumerable<Extension>)(E is Element
                    ? (E as Element).Extension
                    : default), xu_);
            object xw_(Extension @this)
            {
                DataType yr_ = @this?.Value;

                return yr_;
            };
            IEnumerable<object> xx_ = context.Operators.Select<Extension, object>(xv_, xw_);
            CqlCode xy_(object @this)
            {
                CqlCode ys_ = FHIRHelpers_4_3_000.Instance.ToCode(context, @this as Coding);

                return ys_;
            };
            IEnumerable<CqlCode> xz_ = context.Operators.Select<object, CqlCode>(xx_, xy_);
            IEnumerable<CqlCode> ya_ = context.Operators.Union<CqlCode>(xt_ as IEnumerable<CqlCode>, xz_);
            bool? yb_(Extension @this)
            {
                string yt_ = @this?.Url;
                FhirString yu_ = context.Operators.Convert<FhirString>(yt_);
                string yv_ = FHIRHelpers_4_3_000.Instance.ToString(context, yu_);
                bool? yw_ = context.Operators.Equal(yv_, "text");

                return yw_;
            };
            IEnumerable<Extension> yc_ = context.Operators.Where<Extension>((IEnumerable<Extension>)(E is Element
                    ? (E as Element).Extension
                    : default), yb_);
            DataType yd_(Extension @this)
            {
                DataType yx_ = @this?.Value;

                return yx_;
            };
            IEnumerable<DataType> ye_ = context.Operators.Select<Extension, DataType>(yc_, yd_);
            DataType yf_ = context.Operators.SingletonFrom<DataType>(ye_);
            string yg_ = context.Operators.Convert<string>(yf_);
            (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? yh_ = (CqlTupleMetadata_HPcCiDPXQfZTXIORThMLfTQDR, ya_, yg_);

            return yh_;
        };
        IEnumerable<(CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)?> xc_ = context.Operators.Select<Extension, (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)?>((IEnumerable<Extension>)xa_, xb_);
        IEnumerable<(CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)?> xd_ = context.Operators.Distinct<(CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)?>(xc_);
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? xe_ = context.Operators.SingletonFrom<(CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)?>(xd_);

        return xe_;
    }


    [CqlExpressionDefinition(
        definitionName: "SDE Payer")]
    public IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> SDE_Payer(CqlContext context)
    {
        CqlValueSet yy_ = this.Payer_Type(context);
        IEnumerable<Coverage> yz_ = context.Operators.Retrieve<Coverage>(new RetrieveParameters(default, yy_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-coverage"));
        (CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)? za_(Coverage Payer)
        {
            CodeableConcept zd_ = Payer?.Type;
            CqlConcept ze_ = FHIRHelpers_4_3_000.Instance.ToConcept(context, zd_);
            Period zf_ = Payer?.Period;
            CqlInterval<CqlDateTime> zg_ = FHIRHelpers_4_3_000.Instance.ToInterval(context, zf_);
            (CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)? zh_ = (CqlTupleMetadata_GPRWMPNAYaJRiGDFSTLJOPeIJ, ze_, zg_);

            return zh_;
        };
        IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> zb_ = context.Operators.Select<Coverage, (CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?>(yz_, za_);
        IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> zc_ = context.Operators.Distinct<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?>(zb_);

        return zc_;
    }


    [CqlExpressionDefinition(
        definitionName: "SDE Race")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Race(CqlContext context)
    {
        List<Extension> zi_()
        {
            bool zr_()
            {
                Patient zs_ = this.Patient(context);
                bool zt_ = zs_ is DomainResource;

                return zt_;
            };
            if (zr_())
            {
                Patient zu_ = this.Patient(context);

                return (zu_ as DomainResource).Extension;
            }
            else
            {
                return default;
            }
        };
        bool? zj_(Extension @this)
        {
            string zv_ = @this?.Url;
            FhirString zw_ = context.Operators.Convert<FhirString>(zv_);
            string zx_ = FHIRHelpers_4_3_000.Instance.ToString(context, zw_);
            bool? zy_ = context.Operators.Equal(zx_, "http://hl7.org/fhir/us/core/StructureDefinition/us-core-race");

            return zy_;
        };
        IEnumerable<Extension> zk_ = context.Operators.Where<Extension>((IEnumerable<Extension>)(zi_()), zj_);
        Extension zl_ = context.Operators.SingletonFrom<Extension>(zk_);
        Extension[] zm_ = [
            zl_,
        ];
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? zn_(Extension R)
        {
            bool? zz_(Extension @this)
            {
                string azt_ = @this?.Url;
                FhirString azu_ = context.Operators.Convert<FhirString>(azt_);
                string azv_ = FHIRHelpers_4_3_000.Instance.ToString(context, azu_);
                bool? azw_ = context.Operators.Equal(azv_, "ombCategory");

                return azw_;
            };
            IEnumerable<Extension> aza_ = context.Operators.Where<Extension>((IEnumerable<Extension>)(R is Element
                    ? (R as Element).Extension
                    : default), zz_);
            object azb_(Extension @this)
            {
                DataType azx_ = @this?.Value;

                return azx_;
            };
            IEnumerable<object> azc_ = context.Operators.Select<Extension, object>(aza_, azb_);
            CqlCode azd_(object @this)
            {
                CqlCode azy_ = FHIRHelpers_4_3_000.Instance.ToCode(context, @this as Coding);

                return azy_;
            };
            IEnumerable<CqlCode> aze_ = context.Operators.Select<object, CqlCode>(azc_, azd_);
            bool? azf_(Extension @this)
            {
                string azz_ = @this?.Url;
                FhirString bza_ = context.Operators.Convert<FhirString>(azz_);
                string bzb_ = FHIRHelpers_4_3_000.Instance.ToString(context, bza_);
                bool? bzc_ = context.Operators.Equal(bzb_, "detailed");

                return bzc_;
            };
            IEnumerable<Extension> azg_ = context.Operators.Where<Extension>((IEnumerable<Extension>)(R is Element
                    ? (R as Element).Extension
                    : default), azf_);
            object azh_(Extension @this)
            {
                DataType bzd_ = @this?.Value;

                return bzd_;
            };
            IEnumerable<object> azi_ = context.Operators.Select<Extension, object>(azg_, azh_);
            CqlCode azj_(object @this)
            {
                CqlCode bze_ = FHIRHelpers_4_3_000.Instance.ToCode(context, @this as Coding);

                return bze_;
            };
            IEnumerable<CqlCode> azk_ = context.Operators.Select<object, CqlCode>(azi_, azj_);
            IEnumerable<CqlCode> azl_ = context.Operators.Union<CqlCode>(aze_, azk_);
            bool? azm_(Extension @this)
            {
                string bzf_ = @this?.Url;
                FhirString bzg_ = context.Operators.Convert<FhirString>(bzf_);
                string bzh_ = FHIRHelpers_4_3_000.Instance.ToString(context, bzg_);
                bool? bzi_ = context.Operators.Equal(bzh_, "text");

                return bzi_;
            };
            IEnumerable<Extension> azn_ = context.Operators.Where<Extension>((IEnumerable<Extension>)(R is Element
                    ? (R as Element).Extension
                    : default), azm_);
            DataType azo_(Extension @this)
            {
                DataType bzj_ = @this?.Value;

                return bzj_;
            };
            IEnumerable<DataType> azp_ = context.Operators.Select<Extension, DataType>(azn_, azo_);
            DataType azq_ = context.Operators.SingletonFrom<DataType>(azp_);
            string azr_ = context.Operators.Convert<string>(azq_);
            (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? azs_ = (CqlTupleMetadata_HPcCiDPXQfZTXIORThMLfTQDR, azl_, azr_);

            return azs_;
        };
        IEnumerable<(CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)?> zo_ = context.Operators.Select<Extension, (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)?>((IEnumerable<Extension>)zm_, zn_);
        IEnumerable<(CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)?> zp_ = context.Operators.Distinct<(CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)?>(zo_);
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? zq_ = context.Operators.SingletonFrom<(CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)?>(zp_);

        return zq_;
    }


    [CqlExpressionDefinition(
        definitionName: "SDE Sex")]
    public CqlCode SDE_Sex(CqlContext context)
    {
        CqlCode bzk_()
        {
            bool bzl_()
            {
                Patient bzn_ = this.Patient(context);
                Code<AdministrativeGender> bzo_ = bzn_?.GenderElement;
                AdministrativeGender? bzp_ = bzo_?.Value;
                string bzq_ = context.Operators.Convert<string>(bzp_);
                bool? bzr_ = context.Operators.Equal(bzq_, "male");

                return bzr_ ?? false;
            };
            bool bzm_()
            {
                Patient bzs_ = this.Patient(context);
                Code<AdministrativeGender> bzt_ = bzs_?.GenderElement;
                AdministrativeGender? bzu_ = bzt_?.Value;
                string bzv_ = context.Operators.Convert<string>(bzu_);
                bool? bzw_ = context.Operators.Equal(bzv_, "female");

                return bzw_ ?? false;
            };
            if (bzl_())
            {
                return new CqlCode("M", "http://hl7.org/fhir/v3/AdministrativeGender", null, "Male");
            }
            else if (bzm_())
            {
                return new CqlCode("F", "http://hl7.org/fhir/v3/AdministrativeGender", null, "Female");
            }
            else
            {
                return default;
            }
        };

        return bzk_();
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
