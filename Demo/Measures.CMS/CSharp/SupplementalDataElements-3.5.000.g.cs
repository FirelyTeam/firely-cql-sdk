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
    private static readonly CqlCode _M = new CqlCode("M", "http://hl7.org/fhir/administrative-gender", default, default);

    [CqlCodeDefinition("F", codeId: "F", codeSystem: "http://hl7.org/fhir/administrative-gender")]
    public CqlCode F(CqlContext _) => _F;
    private static readonly CqlCode _F = new CqlCode("F", "http://hl7.org/fhir/administrative-gender", default, default);

    #endregion Codes

    #region CodeSystems

    [CqlCodeSystemDefinition("AdministrativeGender")]
    public CqlCodeSystem AdministrativeGender(CqlContext _) => _AdministrativeGender;
    private static readonly CqlCodeSystem _AdministrativeGender = new CqlCodeSystem();

    #endregion CodeSystems

    #region Expressions

    [CqlExpressionDefinition("Patient")]
    public Patient Patient(CqlContext context)
    {
        IEnumerable<Patient> ezy_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-patient"));
        Patient ezz_ = context.Operators.SingletonFrom<Patient>(ezy_);

        return ezz_;
    }


    [CqlExpressionDefinition("SDE Ethnicity")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Ethnicity(CqlContext context)
    {
        List<Extension> fza_()
        {
            bool fzj_()
            {
                Patient fzk_ = this.Patient(context);
                bool fzl_ = fzk_ is DomainResource;

                return fzl_;
            };
            if (fzj_())
            {
                Patient fzm_ = this.Patient(context);

                return (fzm_ as DomainResource).Extension;
            }
            else
            {
                return default;
            }
        };
        bool? fzb_(Extension @this)
        {
            string fzn_ = @this?.Url;
            FhirString fzo_ = context.Operators.Convert<FhirString>(fzn_);
            string fzp_ = FHIRHelpers_4_4_000.Instance.ToString(context, fzo_);
            bool? fzq_ = context.Operators.Equal(fzp_, "http://hl7.org/fhir/us/core/StructureDefinition/us-core-ethnicity");

            return fzq_;
        };
        IEnumerable<Extension> fzc_ = context.Operators.Where<Extension>((IEnumerable<Extension>)(fza_()), fzb_);
        Extension fzd_ = context.Operators.SingletonFrom<Extension>(fzc_);
        Extension[] fze_ = [
            fzd_,
        ];
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? fzf_(Extension E)
        {
            bool? fzr_(Extension @this)
            {
                string gzm_ = @this?.Url;
                FhirString gzn_ = context.Operators.Convert<FhirString>(gzm_);
                string gzo_ = FHIRHelpers_4_4_000.Instance.ToString(context, gzn_);
                bool? gzp_ = context.Operators.Equal(gzo_, "ombCategory");

                return gzp_;
            };
            IEnumerable<Extension> fzs_ = context.Operators.Where<Extension>((IEnumerable<Extension>)(E is Element
                    ? (E as Element).Extension
                    : default), fzr_);
            object fzt_(Extension @this)
            {
                DataType gzq_ = @this?.Value;

                return gzq_;
            };
            IEnumerable<object> fzu_ = context.Operators.Select<Extension, object>(fzs_, fzt_);
            object fzv_ = context.Operators.SingletonFrom<object>(fzu_);
            CqlCode fzw_ = FHIRHelpers_4_4_000.Instance.ToCode(context, fzv_ as Coding);
            CqlCode[] fzx_ = [
                fzw_,
            ];
            bool? fzy_(Extension @this)
            {
                string gzr_ = @this?.Url;
                FhirString gzs_ = context.Operators.Convert<FhirString>(gzr_);
                string gzt_ = FHIRHelpers_4_4_000.Instance.ToString(context, gzs_);
                bool? gzu_ = context.Operators.Equal(gzt_, "detailed");

                return gzu_;
            };
            IEnumerable<Extension> fzz_ = context.Operators.Where<Extension>((IEnumerable<Extension>)(E is Element
                    ? (E as Element).Extension
                    : default), fzy_);
            object gza_(Extension @this)
            {
                DataType gzv_ = @this?.Value;

                return gzv_;
            };
            IEnumerable<object> gzb_ = context.Operators.Select<Extension, object>(fzz_, gza_);
            CqlCode gzc_(object @this)
            {
                CqlCode gzw_ = FHIRHelpers_4_4_000.Instance.ToCode(context, @this as Coding);

                return gzw_;
            };
            IEnumerable<CqlCode> gzd_ = context.Operators.Select<object, CqlCode>(gzb_, gzc_);
            IEnumerable<CqlCode> gze_ = context.Operators.Union<CqlCode>(fzx_ as IEnumerable<CqlCode>, gzd_);
            bool? gzf_(Extension @this)
            {
                string gzx_ = @this?.Url;
                FhirString gzy_ = context.Operators.Convert<FhirString>(gzx_);
                string gzz_ = FHIRHelpers_4_4_000.Instance.ToString(context, gzy_);
                bool? hza_ = context.Operators.Equal(gzz_, "text");

                return hza_;
            };
            IEnumerable<Extension> gzg_ = context.Operators.Where<Extension>((IEnumerable<Extension>)(E is Element
                    ? (E as Element).Extension
                    : default), gzf_);
            DataType gzh_(Extension @this)
            {
                DataType hzb_ = @this?.Value;

                return hzb_;
            };
            IEnumerable<DataType> gzi_ = context.Operators.Select<Extension, DataType>(gzg_, gzh_);
            DataType gzj_ = context.Operators.SingletonFrom<DataType>(gzi_);
            string gzk_ = context.Operators.Convert<string>(gzj_);
            (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? gzl_ = (CqlTupleMetadata_HPcCiDPXQfZTXIORThMLfTQDR, gze_, gzk_);

            return gzl_;
        };
        IEnumerable<(CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)?> fzg_ = context.Operators.Select<Extension, (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)?>((IEnumerable<Extension>)fze_, fzf_);
        IEnumerable<(CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)?> fzh_ = context.Operators.Distinct<(CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)?>(fzg_);
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? fzi_ = context.Operators.SingletonFrom<(CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)?>(fzh_);

        return fzi_;
    }


    [CqlExpressionDefinition("SDE Payer")]
    public IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> SDE_Payer(CqlContext context)
    {
        CqlValueSet hzc_ = this.Payer_Type(context);
        IEnumerable<Coverage> hzd_ = context.Operators.Retrieve<Coverage>(new RetrieveParameters(default, hzc_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-coverage"));
        (CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)? hze_(Coverage Payer)
        {
            CodeableConcept hzh_ = Payer?.Type;
            CqlConcept hzi_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, hzh_);
            Period hzj_ = Payer?.Period;
            CqlInterval<CqlDateTime> hzk_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, hzj_);
            (CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)? hzl_ = (CqlTupleMetadata_GPRWMPNAYaJRiGDFSTLJOPeIJ, hzi_, hzk_);

            return hzl_;
        };
        IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> hzf_ = context.Operators.Select<Coverage, (CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?>(hzd_, hze_);
        IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> hzg_ = context.Operators.Distinct<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?>(hzf_);

        return hzg_;
    }


    [CqlExpressionDefinition("SDE Race")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Race(CqlContext context)
    {
        List<Extension> hzm_()
        {
            bool hzv_()
            {
                Patient hzw_ = this.Patient(context);
                bool hzx_ = hzw_ is DomainResource;

                return hzx_;
            };
            if (hzv_())
            {
                Patient hzy_ = this.Patient(context);

                return (hzy_ as DomainResource).Extension;
            }
            else
            {
                return default;
            }
        };
        bool? hzn_(Extension @this)
        {
            string hzz_ = @this?.Url;
            FhirString iza_ = context.Operators.Convert<FhirString>(hzz_);
            string izb_ = FHIRHelpers_4_4_000.Instance.ToString(context, iza_);
            bool? izc_ = context.Operators.Equal(izb_, "http://hl7.org/fhir/us/core/StructureDefinition/us-core-race");

            return izc_;
        };
        IEnumerable<Extension> hzo_ = context.Operators.Where<Extension>((IEnumerable<Extension>)(hzm_()), hzn_);
        Extension hzp_ = context.Operators.SingletonFrom<Extension>(hzo_);
        Extension[] hzq_ = [
            hzp_,
        ];
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? hzr_(Extension R)
        {
            bool? izd_(Extension @this)
            {
                string izx_ = @this?.Url;
                FhirString izy_ = context.Operators.Convert<FhirString>(izx_);
                string izz_ = FHIRHelpers_4_4_000.Instance.ToString(context, izy_);
                bool? jza_ = context.Operators.Equal(izz_, "ombCategory");

                return jza_;
            };
            IEnumerable<Extension> ize_ = context.Operators.Where<Extension>((IEnumerable<Extension>)(R is Element
                    ? (R as Element).Extension
                    : default), izd_);
            object izf_(Extension @this)
            {
                DataType jzb_ = @this?.Value;

                return jzb_;
            };
            IEnumerable<object> izg_ = context.Operators.Select<Extension, object>(ize_, izf_);
            CqlCode izh_(object @this)
            {
                CqlCode jzc_ = FHIRHelpers_4_4_000.Instance.ToCode(context, @this as Coding);

                return jzc_;
            };
            IEnumerable<CqlCode> izi_ = context.Operators.Select<object, CqlCode>(izg_, izh_);
            bool? izj_(Extension @this)
            {
                string jzd_ = @this?.Url;
                FhirString jze_ = context.Operators.Convert<FhirString>(jzd_);
                string jzf_ = FHIRHelpers_4_4_000.Instance.ToString(context, jze_);
                bool? jzg_ = context.Operators.Equal(jzf_, "detailed");

                return jzg_;
            };
            IEnumerable<Extension> izk_ = context.Operators.Where<Extension>((IEnumerable<Extension>)(R is Element
                    ? (R as Element).Extension
                    : default), izj_);
            object izl_(Extension @this)
            {
                DataType jzh_ = @this?.Value;

                return jzh_;
            };
            IEnumerable<object> izm_ = context.Operators.Select<Extension, object>(izk_, izl_);
            CqlCode izn_(object @this)
            {
                CqlCode jzi_ = FHIRHelpers_4_4_000.Instance.ToCode(context, @this as Coding);

                return jzi_;
            };
            IEnumerable<CqlCode> izo_ = context.Operators.Select<object, CqlCode>(izm_, izn_);
            IEnumerable<CqlCode> izp_ = context.Operators.Union<CqlCode>(izi_, izo_);
            bool? izq_(Extension @this)
            {
                string jzj_ = @this?.Url;
                FhirString jzk_ = context.Operators.Convert<FhirString>(jzj_);
                string jzl_ = FHIRHelpers_4_4_000.Instance.ToString(context, jzk_);
                bool? jzm_ = context.Operators.Equal(jzl_, "text");

                return jzm_;
            };
            IEnumerable<Extension> izr_ = context.Operators.Where<Extension>((IEnumerable<Extension>)(R is Element
                    ? (R as Element).Extension
                    : default), izq_);
            DataType izs_(Extension @this)
            {
                DataType jzn_ = @this?.Value;

                return jzn_;
            };
            IEnumerable<DataType> izt_ = context.Operators.Select<Extension, DataType>(izr_, izs_);
            DataType izu_ = context.Operators.SingletonFrom<DataType>(izt_);
            string izv_ = context.Operators.Convert<string>(izu_);
            (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? izw_ = (CqlTupleMetadata_HPcCiDPXQfZTXIORThMLfTQDR, izp_, izv_);

            return izw_;
        };
        IEnumerable<(CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)?> hzs_ = context.Operators.Select<Extension, (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)?>((IEnumerable<Extension>)hzq_, hzr_);
        IEnumerable<(CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)?> hzt_ = context.Operators.Distinct<(CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)?>(hzs_);
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? hzu_ = context.Operators.SingletonFrom<(CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)?>(hzt_);

        return hzu_;
    }


    [CqlExpressionDefinition("SDE Sex")]
    public CqlCode SDE_Sex(CqlContext context)
    {
        CqlCode jzo_()
        {
            bool jzp_()
            {
                Patient jzr_ = this.Patient(context);
                Code<AdministrativeGender> jzs_ = jzr_?.GenderElement;
                AdministrativeGender? jzt_ = jzs_?.Value;
                string jzu_ = context.Operators.Convert<string>(jzt_);
                bool? jzv_ = context.Operators.Equal(jzu_, "male");

                return jzv_ ?? false;
            };
            bool jzq_()
            {
                Patient jzw_ = this.Patient(context);
                Code<AdministrativeGender> jzx_ = jzw_?.GenderElement;
                AdministrativeGender? jzy_ = jzx_?.Value;
                string jzz_ = context.Operators.Convert<string>(jzy_);
                bool? kza_ = context.Operators.Equal(jzz_, "female");

                return kza_ ?? false;
            };
            if (jzp_())
            {
                CqlCode kzb_ = this.M(context);

                return kzb_;
            }
            else if (jzq_())
            {
                CqlCode kzc_ = this.F(context);

                return kzc_;
            }
            else
            {
                return default;
            }
        };

        return jzo_();
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
