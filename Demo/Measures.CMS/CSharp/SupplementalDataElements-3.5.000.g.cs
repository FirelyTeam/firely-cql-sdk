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

    #region Codes

    #region Code: M
    [CqlCodeDefinition(
        definitionName: "M",
        codeId: "M",
        codeSystem: "http://hl7.org/fhir/administrative-gender")]
    public CqlCode M(CqlContext context) => _M;

    private static readonly CqlCode _M = new CqlCode("M", "http://hl7.org/fhir/administrative-gender", default, default);
    #endregion

    #region Code: F
    [CqlCodeDefinition(
        definitionName: "F",
        codeId: "F",
        codeSystem: "http://hl7.org/fhir/administrative-gender")]
    public CqlCode F(CqlContext context) => _F;

    private static readonly CqlCode _F = new CqlCode("F", "http://hl7.org/fhir/administrative-gender", default, default);
    #endregion

    #endregion Codes

    #region CodeSystems

    [CqlCodeSystemDefinition(
        definitionName: "AdministrativeGender")]
    public CqlCode[] AdministrativeGender(CqlContext context)
    {
        CqlCode[] zzzzzzc_ = [
            new CqlCode("M", "http://hl7.org/fhir/administrative-gender", default, default),
            new CqlCode("F", "http://hl7.org/fhir/administrative-gender", default, default),
        ];

        return zzzzzzc_;
    }


    #endregion CodeSystems

    #region Expressions

    [CqlExpressionDefinition(
        definitionName: "Patient")]
    public Patient Patient(CqlContext context)
    {
        IEnumerable<Patient> zzzzzzd_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-patient"));
        Patient zzzzzze_ = context.Operators.SingletonFrom<Patient>(zzzzzzd_);

        return zzzzzze_;
    }


    [CqlExpressionDefinition(
        definitionName: "SDE Ethnicity")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Ethnicity(CqlContext context)
    {
        List<Extension> zzzzzzf_()
        {
            bool zzzzzzo_()
            {
                Patient zzzzzzp_ = this.Patient(context);
                bool zzzzzzq_ = zzzzzzp_ is DomainResource;

                return zzzzzzq_;
            };
            if (zzzzzzo_())
            {
                Patient zzzzzzr_ = this.Patient(context);

                return (zzzzzzr_ as DomainResource).Extension;
            }
            else
            {
                return default;
            }
        };
        bool? zzzzzzg_(Extension @this)
        {
            string zzzzzzs_ = @this?.Url;
            FhirString zzzzzzt_ = context.Operators.Convert<FhirString>(zzzzzzs_);
            string zzzzzzu_ = FHIRHelpers_4_4_000.Instance.ToString(context, zzzzzzt_);
            bool? zzzzzzv_ = context.Operators.Equal(zzzzzzu_, "http://hl7.org/fhir/us/core/StructureDefinition/us-core-ethnicity");

            return zzzzzzv_;
        };
        IEnumerable<Extension> zzzzzzh_ = context.Operators.Where<Extension>((IEnumerable<Extension>)(zzzzzzf_()), zzzzzzg_);
        Extension zzzzzzi_ = context.Operators.SingletonFrom<Extension>(zzzzzzh_);
        Extension[] zzzzzzj_ = [
            zzzzzzi_,
        ];
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? zzzzzzk_(Extension E)
        {
            bool? zzzzzzw_(Extension @this)
            {
                string azzzzzzr_ = @this?.Url;
                FhirString azzzzzzs_ = context.Operators.Convert<FhirString>(azzzzzzr_);
                string azzzzzzt_ = FHIRHelpers_4_4_000.Instance.ToString(context, azzzzzzs_);
                bool? azzzzzzu_ = context.Operators.Equal(azzzzzzt_, "ombCategory");

                return azzzzzzu_;
            };
            IEnumerable<Extension> zzzzzzx_ = context.Operators.Where<Extension>((IEnumerable<Extension>)(E is Element
                    ? (E as Element).Extension
                    : default), zzzzzzw_);
            object zzzzzzy_(Extension @this)
            {
                DataType azzzzzzv_ = @this?.Value;

                return azzzzzzv_;
            };
            IEnumerable<object> zzzzzzz_ = context.Operators.Select<Extension, object>(zzzzzzx_, zzzzzzy_);
            object azzzzzza_ = context.Operators.SingletonFrom<object>(zzzzzzz_);
            CqlCode azzzzzzb_ = FHIRHelpers_4_4_000.Instance.ToCode(context, azzzzzza_ as Coding);
            CqlCode[] azzzzzzc_ = [
                azzzzzzb_,
            ];
            bool? azzzzzzd_(Extension @this)
            {
                string azzzzzzw_ = @this?.Url;
                FhirString azzzzzzx_ = context.Operators.Convert<FhirString>(azzzzzzw_);
                string azzzzzzy_ = FHIRHelpers_4_4_000.Instance.ToString(context, azzzzzzx_);
                bool? azzzzzzz_ = context.Operators.Equal(azzzzzzy_, "detailed");

                return azzzzzzz_;
            };
            IEnumerable<Extension> azzzzzze_ = context.Operators.Where<Extension>((IEnumerable<Extension>)(E is Element
                    ? (E as Element).Extension
                    : default), azzzzzzd_);
            object azzzzzzf_(Extension @this)
            {
                DataType bzzzzzza_ = @this?.Value;

                return bzzzzzza_;
            };
            IEnumerable<object> azzzzzzg_ = context.Operators.Select<Extension, object>(azzzzzze_, azzzzzzf_);
            CqlCode azzzzzzh_(object @this)
            {
                CqlCode bzzzzzzb_ = FHIRHelpers_4_4_000.Instance.ToCode(context, @this as Coding);

                return bzzzzzzb_;
            };
            IEnumerable<CqlCode> azzzzzzi_ = context.Operators.Select<object, CqlCode>(azzzzzzg_, azzzzzzh_);
            IEnumerable<CqlCode> azzzzzzj_ = context.Operators.Union<CqlCode>(azzzzzzc_ as IEnumerable<CqlCode>, azzzzzzi_);
            bool? azzzzzzk_(Extension @this)
            {
                string bzzzzzzc_ = @this?.Url;
                FhirString bzzzzzzd_ = context.Operators.Convert<FhirString>(bzzzzzzc_);
                string bzzzzzze_ = FHIRHelpers_4_4_000.Instance.ToString(context, bzzzzzzd_);
                bool? bzzzzzzf_ = context.Operators.Equal(bzzzzzze_, "text");

                return bzzzzzzf_;
            };
            IEnumerable<Extension> azzzzzzl_ = context.Operators.Where<Extension>((IEnumerable<Extension>)(E is Element
                    ? (E as Element).Extension
                    : default), azzzzzzk_);
            DataType azzzzzzm_(Extension @this)
            {
                DataType bzzzzzzg_ = @this?.Value;

                return bzzzzzzg_;
            };
            IEnumerable<DataType> azzzzzzn_ = context.Operators.Select<Extension, DataType>(azzzzzzl_, azzzzzzm_);
            DataType azzzzzzo_ = context.Operators.SingletonFrom<DataType>(azzzzzzn_);
            string azzzzzzp_ = context.Operators.Convert<string>(azzzzzzo_);
            (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? azzzzzzq_ = (CqlTupleMetadata_HPcCiDPXQfZTXIORThMLfTQDR, azzzzzzj_, azzzzzzp_);

            return azzzzzzq_;
        };
        IEnumerable<(CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)?> zzzzzzl_ = context.Operators.Select<Extension, (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)?>((IEnumerable<Extension>)zzzzzzj_, zzzzzzk_);
        IEnumerable<(CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)?> zzzzzzm_ = context.Operators.Distinct<(CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)?>(zzzzzzl_);
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? zzzzzzn_ = context.Operators.SingletonFrom<(CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)?>(zzzzzzm_);

        return zzzzzzn_;
    }


    [CqlExpressionDefinition(
        definitionName: "SDE Payer")]
    public IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> SDE_Payer(CqlContext context)
    {
        CqlValueSet bzzzzzzh_ = this.Payer_Type(context);
        IEnumerable<Coverage> bzzzzzzi_ = context.Operators.Retrieve<Coverage>(new RetrieveParameters(default, bzzzzzzh_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-coverage"));
        (CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)? bzzzzzzj_(Coverage Payer)
        {
            CodeableConcept bzzzzzzm_ = Payer?.Type;
            CqlConcept bzzzzzzn_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, bzzzzzzm_);
            Period bzzzzzzo_ = Payer?.Period;
            CqlInterval<CqlDateTime> bzzzzzzp_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, bzzzzzzo_);
            (CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)? bzzzzzzq_ = (CqlTupleMetadata_GPRWMPNAYaJRiGDFSTLJOPeIJ, bzzzzzzn_, bzzzzzzp_);

            return bzzzzzzq_;
        };
        IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> bzzzzzzk_ = context.Operators.Select<Coverage, (CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?>(bzzzzzzi_, bzzzzzzj_);
        IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> bzzzzzzl_ = context.Operators.Distinct<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?>(bzzzzzzk_);

        return bzzzzzzl_;
    }


    [CqlExpressionDefinition(
        definitionName: "SDE Race")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Race(CqlContext context)
    {
        List<Extension> bzzzzzzr_()
        {
            bool czzzzzza_()
            {
                Patient czzzzzzb_ = this.Patient(context);
                bool czzzzzzc_ = czzzzzzb_ is DomainResource;

                return czzzzzzc_;
            };
            if (czzzzzza_())
            {
                Patient czzzzzzd_ = this.Patient(context);

                return (czzzzzzd_ as DomainResource).Extension;
            }
            else
            {
                return default;
            }
        };
        bool? bzzzzzzs_(Extension @this)
        {
            string czzzzzze_ = @this?.Url;
            FhirString czzzzzzf_ = context.Operators.Convert<FhirString>(czzzzzze_);
            string czzzzzzg_ = FHIRHelpers_4_4_000.Instance.ToString(context, czzzzzzf_);
            bool? czzzzzzh_ = context.Operators.Equal(czzzzzzg_, "http://hl7.org/fhir/us/core/StructureDefinition/us-core-race");

            return czzzzzzh_;
        };
        IEnumerable<Extension> bzzzzzzt_ = context.Operators.Where<Extension>((IEnumerable<Extension>)(bzzzzzzr_()), bzzzzzzs_);
        Extension bzzzzzzu_ = context.Operators.SingletonFrom<Extension>(bzzzzzzt_);
        Extension[] bzzzzzzv_ = [
            bzzzzzzu_,
        ];
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? bzzzzzzw_(Extension R)
        {
            bool? czzzzzzi_(Extension @this)
            {
                string dzzzzzzc_ = @this?.Url;
                FhirString dzzzzzzd_ = context.Operators.Convert<FhirString>(dzzzzzzc_);
                string dzzzzzze_ = FHIRHelpers_4_4_000.Instance.ToString(context, dzzzzzzd_);
                bool? dzzzzzzf_ = context.Operators.Equal(dzzzzzze_, "ombCategory");

                return dzzzzzzf_;
            };
            IEnumerable<Extension> czzzzzzj_ = context.Operators.Where<Extension>((IEnumerable<Extension>)(R is Element
                    ? (R as Element).Extension
                    : default), czzzzzzi_);
            object czzzzzzk_(Extension @this)
            {
                DataType dzzzzzzg_ = @this?.Value;

                return dzzzzzzg_;
            };
            IEnumerable<object> czzzzzzl_ = context.Operators.Select<Extension, object>(czzzzzzj_, czzzzzzk_);
            CqlCode czzzzzzm_(object @this)
            {
                CqlCode dzzzzzzh_ = FHIRHelpers_4_4_000.Instance.ToCode(context, @this as Coding);

                return dzzzzzzh_;
            };
            IEnumerable<CqlCode> czzzzzzn_ = context.Operators.Select<object, CqlCode>(czzzzzzl_, czzzzzzm_);
            bool? czzzzzzo_(Extension @this)
            {
                string dzzzzzzi_ = @this?.Url;
                FhirString dzzzzzzj_ = context.Operators.Convert<FhirString>(dzzzzzzi_);
                string dzzzzzzk_ = FHIRHelpers_4_4_000.Instance.ToString(context, dzzzzzzj_);
                bool? dzzzzzzl_ = context.Operators.Equal(dzzzzzzk_, "detailed");

                return dzzzzzzl_;
            };
            IEnumerable<Extension> czzzzzzp_ = context.Operators.Where<Extension>((IEnumerable<Extension>)(R is Element
                    ? (R as Element).Extension
                    : default), czzzzzzo_);
            object czzzzzzq_(Extension @this)
            {
                DataType dzzzzzzm_ = @this?.Value;

                return dzzzzzzm_;
            };
            IEnumerable<object> czzzzzzr_ = context.Operators.Select<Extension, object>(czzzzzzp_, czzzzzzq_);
            CqlCode czzzzzzs_(object @this)
            {
                CqlCode dzzzzzzn_ = FHIRHelpers_4_4_000.Instance.ToCode(context, @this as Coding);

                return dzzzzzzn_;
            };
            IEnumerable<CqlCode> czzzzzzt_ = context.Operators.Select<object, CqlCode>(czzzzzzr_, czzzzzzs_);
            IEnumerable<CqlCode> czzzzzzu_ = context.Operators.Union<CqlCode>(czzzzzzn_, czzzzzzt_);
            bool? czzzzzzv_(Extension @this)
            {
                string dzzzzzzo_ = @this?.Url;
                FhirString dzzzzzzp_ = context.Operators.Convert<FhirString>(dzzzzzzo_);
                string dzzzzzzq_ = FHIRHelpers_4_4_000.Instance.ToString(context, dzzzzzzp_);
                bool? dzzzzzzr_ = context.Operators.Equal(dzzzzzzq_, "text");

                return dzzzzzzr_;
            };
            IEnumerable<Extension> czzzzzzw_ = context.Operators.Where<Extension>((IEnumerable<Extension>)(R is Element
                    ? (R as Element).Extension
                    : default), czzzzzzv_);
            DataType czzzzzzx_(Extension @this)
            {
                DataType dzzzzzzs_ = @this?.Value;

                return dzzzzzzs_;
            };
            IEnumerable<DataType> czzzzzzy_ = context.Operators.Select<Extension, DataType>(czzzzzzw_, czzzzzzx_);
            DataType czzzzzzz_ = context.Operators.SingletonFrom<DataType>(czzzzzzy_);
            string dzzzzzza_ = context.Operators.Convert<string>(czzzzzzz_);
            (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? dzzzzzzb_ = (CqlTupleMetadata_HPcCiDPXQfZTXIORThMLfTQDR, czzzzzzu_, dzzzzzza_);

            return dzzzzzzb_;
        };
        IEnumerable<(CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)?> bzzzzzzx_ = context.Operators.Select<Extension, (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)?>((IEnumerable<Extension>)bzzzzzzv_, bzzzzzzw_);
        IEnumerable<(CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)?> bzzzzzzy_ = context.Operators.Distinct<(CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)?>(bzzzzzzx_);
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? bzzzzzzz_ = context.Operators.SingletonFrom<(CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)?>(bzzzzzzy_);

        return bzzzzzzz_;
    }


    [CqlExpressionDefinition(
        definitionName: "SDE Sex")]
    public CqlCode SDE_Sex(CqlContext context)
    {
        CqlCode dzzzzzzt_()
        {
            bool dzzzzzzu_()
            {
                Patient dzzzzzzw_ = this.Patient(context);
                Code<AdministrativeGender> dzzzzzzx_ = dzzzzzzw_?.GenderElement;
                AdministrativeGender? dzzzzzzy_ = dzzzzzzx_?.Value;
                string dzzzzzzz_ = context.Operators.Convert<string>(dzzzzzzy_);
                bool? ezzzzzza_ = context.Operators.Equal(dzzzzzzz_, "male");

                return ezzzzzza_ ?? false;
            };
            bool dzzzzzzv_()
            {
                Patient ezzzzzzb_ = this.Patient(context);
                Code<AdministrativeGender> ezzzzzzc_ = ezzzzzzb_?.GenderElement;
                AdministrativeGender? ezzzzzzd_ = ezzzzzzc_?.Value;
                string ezzzzzze_ = context.Operators.Convert<string>(ezzzzzzd_);
                bool? ezzzzzzf_ = context.Operators.Equal(ezzzzzze_, "female");

                return ezzzzzzf_ ?? false;
            };
            if (dzzzzzzu_())
            {
                CqlCode ezzzzzzg_ = this.M(context);

                return ezzzzzzg_;
            }
            else if (dzzzzzzv_())
            {
                CqlCode ezzzzzzh_ = this.F(context);

                return ezzzzzzh_;
            }
            else
            {
                return default;
            }
        };

        return dzzzzzzt_();
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
