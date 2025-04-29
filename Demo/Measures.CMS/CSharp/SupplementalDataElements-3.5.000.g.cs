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
        IEnumerable<Patient> xzzi_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-patient"));
        Patient xzzj_ = context.Operators.SingletonFrom<Patient>(xzzi_);

        return xzzj_;
    }


    [CqlExpressionDefinition("SDE Ethnicity")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Ethnicity(CqlContext context)
    {
        List<Extension> xzzk_()
        {
            bool xzzt_()
            {
                Patient xzzu_ = this.Patient(context);
                bool xzzv_ = xzzu_ is DomainResource;

                return xzzv_;
            };
            if (xzzt_())
            {
                Patient xzzw_ = this.Patient(context);

                return (xzzw_ as DomainResource).Extension;
            }
            else
            {
                return default;
            }
        };
        bool? xzzl_(Extension @this)
        {
            string xzzx_ = @this?.Url;
            FhirString xzzy_ = context.Operators.Convert<FhirString>(xzzx_);
            string xzzz_ = FHIRHelpers_4_4_000.Instance.ToString(context, xzzy_);
            bool? yzza_ = context.Operators.Equal(xzzz_, "http://hl7.org/fhir/us/core/StructureDefinition/us-core-ethnicity");

            return yzza_;
        };
        IEnumerable<Extension> xzzm_ = context.Operators.Where<Extension>((IEnumerable<Extension>)(xzzk_()), xzzl_);
        Extension xzzn_ = context.Operators.SingletonFrom<Extension>(xzzm_);
        Extension[] xzzo_ = [
            xzzn_,
        ];
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? xzzp_(Extension E)
        {
            bool? yzzb_(Extension @this)
            {
                string yzzw_ = @this?.Url;
                FhirString yzzx_ = context.Operators.Convert<FhirString>(yzzw_);
                string yzzy_ = FHIRHelpers_4_4_000.Instance.ToString(context, yzzx_);
                bool? yzzz_ = context.Operators.Equal(yzzy_, "ombCategory");

                return yzzz_;
            };
            IEnumerable<Extension> yzzc_ = context.Operators.Where<Extension>((IEnumerable<Extension>)(E is Element
                    ? (E as Element).Extension
                    : default), yzzb_);
            object yzzd_(Extension @this)
            {
                DataType zzza_ = @this?.Value;

                return zzza_;
            };
            IEnumerable<object> yzze_ = context.Operators.Select<Extension, object>(yzzc_, yzzd_);
            object yzzf_ = context.Operators.SingletonFrom<object>(yzze_);
            CqlCode yzzg_ = FHIRHelpers_4_4_000.Instance.ToCode(context, yzzf_ as Coding);
            CqlCode[] yzzh_ = [
                yzzg_,
            ];
            bool? yzzi_(Extension @this)
            {
                string zzzb_ = @this?.Url;
                FhirString zzzc_ = context.Operators.Convert<FhirString>(zzzb_);
                string zzzd_ = FHIRHelpers_4_4_000.Instance.ToString(context, zzzc_);
                bool? zzze_ = context.Operators.Equal(zzzd_, "detailed");

                return zzze_;
            };
            IEnumerable<Extension> yzzj_ = context.Operators.Where<Extension>((IEnumerable<Extension>)(E is Element
                    ? (E as Element).Extension
                    : default), yzzi_);
            object yzzk_(Extension @this)
            {
                DataType zzzf_ = @this?.Value;

                return zzzf_;
            };
            IEnumerable<object> yzzl_ = context.Operators.Select<Extension, object>(yzzj_, yzzk_);
            CqlCode yzzm_(object @this)
            {
                CqlCode zzzg_ = FHIRHelpers_4_4_000.Instance.ToCode(context, @this as Coding);

                return zzzg_;
            };
            IEnumerable<CqlCode> yzzn_ = context.Operators.Select<object, CqlCode>(yzzl_, yzzm_);
            IEnumerable<CqlCode> yzzo_ = context.Operators.Union<CqlCode>(yzzh_ as IEnumerable<CqlCode>, yzzn_);
            bool? yzzp_(Extension @this)
            {
                string zzzh_ = @this?.Url;
                FhirString zzzi_ = context.Operators.Convert<FhirString>(zzzh_);
                string zzzj_ = FHIRHelpers_4_4_000.Instance.ToString(context, zzzi_);
                bool? zzzk_ = context.Operators.Equal(zzzj_, "text");

                return zzzk_;
            };
            IEnumerable<Extension> yzzq_ = context.Operators.Where<Extension>((IEnumerable<Extension>)(E is Element
                    ? (E as Element).Extension
                    : default), yzzp_);
            DataType yzzr_(Extension @this)
            {
                DataType zzzl_ = @this?.Value;

                return zzzl_;
            };
            IEnumerable<DataType> yzzs_ = context.Operators.Select<Extension, DataType>(yzzq_, yzzr_);
            DataType yzzt_ = context.Operators.SingletonFrom<DataType>(yzzs_);
            string yzzu_ = context.Operators.Convert<string>(yzzt_);
            (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? yzzv_ = (CqlTupleMetadata_HPcCiDPXQfZTXIORThMLfTQDR, yzzo_, yzzu_);

            return yzzv_;
        };
        IEnumerable<(CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)?> xzzq_ = context.Operators.Select<Extension, (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)?>((IEnumerable<Extension>)xzzo_, xzzp_);
        IEnumerable<(CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)?> xzzr_ = context.Operators.Distinct<(CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)?>(xzzq_);
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? xzzs_ = context.Operators.SingletonFrom<(CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)?>(xzzr_);

        return xzzs_;
    }


    [CqlExpressionDefinition("SDE Payer")]
    public IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> SDE_Payer(CqlContext context)
    {
        CqlValueSet zzzm_ = this.Payer_Type(context);
        IEnumerable<Coverage> zzzn_ = context.Operators.Retrieve<Coverage>(new RetrieveParameters(default, zzzm_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-coverage"));
        (CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)? zzzo_(Coverage Payer)
        {
            CodeableConcept zzzr_ = Payer?.Type;
            CqlConcept zzzs_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, zzzr_);
            Period zzzt_ = Payer?.Period;
            CqlInterval<CqlDateTime> zzzu_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, zzzt_);
            (CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)? zzzv_ = (CqlTupleMetadata_GPRWMPNAYaJRiGDFSTLJOPeIJ, zzzs_, zzzu_);

            return zzzv_;
        };
        IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> zzzp_ = context.Operators.Select<Coverage, (CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?>(zzzn_, zzzo_);
        IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> zzzq_ = context.Operators.Distinct<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?>(zzzp_);

        return zzzq_;
    }


    [CqlExpressionDefinition("SDE Race")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Race(CqlContext context)
    {
        List<Extension> zzzw_()
        {
            bool azzzf_()
            {
                Patient azzzg_ = this.Patient(context);
                bool azzzh_ = azzzg_ is DomainResource;

                return azzzh_;
            };
            if (azzzf_())
            {
                Patient azzzi_ = this.Patient(context);

                return (azzzi_ as DomainResource).Extension;
            }
            else
            {
                return default;
            }
        };
        bool? zzzx_(Extension @this)
        {
            string azzzj_ = @this?.Url;
            FhirString azzzk_ = context.Operators.Convert<FhirString>(azzzj_);
            string azzzl_ = FHIRHelpers_4_4_000.Instance.ToString(context, azzzk_);
            bool? azzzm_ = context.Operators.Equal(azzzl_, "http://hl7.org/fhir/us/core/StructureDefinition/us-core-race");

            return azzzm_;
        };
        IEnumerable<Extension> zzzy_ = context.Operators.Where<Extension>((IEnumerable<Extension>)(zzzw_()), zzzx_);
        Extension zzzz_ = context.Operators.SingletonFrom<Extension>(zzzy_);
        Extension[] azzza_ = [
            zzzz_,
        ];
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? azzzb_(Extension R)
        {
            bool? azzzn_(Extension @this)
            {
                string bzzzh_ = @this?.Url;
                FhirString bzzzi_ = context.Operators.Convert<FhirString>(bzzzh_);
                string bzzzj_ = FHIRHelpers_4_4_000.Instance.ToString(context, bzzzi_);
                bool? bzzzk_ = context.Operators.Equal(bzzzj_, "ombCategory");

                return bzzzk_;
            };
            IEnumerable<Extension> azzzo_ = context.Operators.Where<Extension>((IEnumerable<Extension>)(R is Element
                    ? (R as Element).Extension
                    : default), azzzn_);
            object azzzp_(Extension @this)
            {
                DataType bzzzl_ = @this?.Value;

                return bzzzl_;
            };
            IEnumerable<object> azzzq_ = context.Operators.Select<Extension, object>(azzzo_, azzzp_);
            CqlCode azzzr_(object @this)
            {
                CqlCode bzzzm_ = FHIRHelpers_4_4_000.Instance.ToCode(context, @this as Coding);

                return bzzzm_;
            };
            IEnumerable<CqlCode> azzzs_ = context.Operators.Select<object, CqlCode>(azzzq_, azzzr_);
            bool? azzzt_(Extension @this)
            {
                string bzzzn_ = @this?.Url;
                FhirString bzzzo_ = context.Operators.Convert<FhirString>(bzzzn_);
                string bzzzp_ = FHIRHelpers_4_4_000.Instance.ToString(context, bzzzo_);
                bool? bzzzq_ = context.Operators.Equal(bzzzp_, "detailed");

                return bzzzq_;
            };
            IEnumerable<Extension> azzzu_ = context.Operators.Where<Extension>((IEnumerable<Extension>)(R is Element
                    ? (R as Element).Extension
                    : default), azzzt_);
            object azzzv_(Extension @this)
            {
                DataType bzzzr_ = @this?.Value;

                return bzzzr_;
            };
            IEnumerable<object> azzzw_ = context.Operators.Select<Extension, object>(azzzu_, azzzv_);
            CqlCode azzzx_(object @this)
            {
                CqlCode bzzzs_ = FHIRHelpers_4_4_000.Instance.ToCode(context, @this as Coding);

                return bzzzs_;
            };
            IEnumerable<CqlCode> azzzy_ = context.Operators.Select<object, CqlCode>(azzzw_, azzzx_);
            IEnumerable<CqlCode> azzzz_ = context.Operators.Union<CqlCode>(azzzs_, azzzy_);
            bool? bzzza_(Extension @this)
            {
                string bzzzt_ = @this?.Url;
                FhirString bzzzu_ = context.Operators.Convert<FhirString>(bzzzt_);
                string bzzzv_ = FHIRHelpers_4_4_000.Instance.ToString(context, bzzzu_);
                bool? bzzzw_ = context.Operators.Equal(bzzzv_, "text");

                return bzzzw_;
            };
            IEnumerable<Extension> bzzzb_ = context.Operators.Where<Extension>((IEnumerable<Extension>)(R is Element
                    ? (R as Element).Extension
                    : default), bzzza_);
            DataType bzzzc_(Extension @this)
            {
                DataType bzzzx_ = @this?.Value;

                return bzzzx_;
            };
            IEnumerable<DataType> bzzzd_ = context.Operators.Select<Extension, DataType>(bzzzb_, bzzzc_);
            DataType bzzze_ = context.Operators.SingletonFrom<DataType>(bzzzd_);
            string bzzzf_ = context.Operators.Convert<string>(bzzze_);
            (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? bzzzg_ = (CqlTupleMetadata_HPcCiDPXQfZTXIORThMLfTQDR, azzzz_, bzzzf_);

            return bzzzg_;
        };
        IEnumerable<(CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)?> azzzc_ = context.Operators.Select<Extension, (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)?>((IEnumerable<Extension>)azzza_, azzzb_);
        IEnumerable<(CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)?> azzzd_ = context.Operators.Distinct<(CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)?>(azzzc_);
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? azzze_ = context.Operators.SingletonFrom<(CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)?>(azzzd_);

        return azzze_;
    }


    [CqlExpressionDefinition("SDE Sex")]
    public CqlCode SDE_Sex(CqlContext context)
    {
        CqlCode bzzzy_()
        {
            bool bzzzz_()
            {
                Patient czzzb_ = this.Patient(context);
                Code<AdministrativeGender> czzzc_ = czzzb_?.GenderElement;
                AdministrativeGender? czzzd_ = czzzc_?.Value;
                string czzze_ = context.Operators.Convert<string>(czzzd_);
                bool? czzzf_ = context.Operators.Equal(czzze_, "male");

                return czzzf_ ?? false;
            };
            bool czzza_()
            {
                Patient czzzg_ = this.Patient(context);
                Code<AdministrativeGender> czzzh_ = czzzg_?.GenderElement;
                AdministrativeGender? czzzi_ = czzzh_?.Value;
                string czzzj_ = context.Operators.Convert<string>(czzzi_);
                bool? czzzk_ = context.Operators.Equal(czzzj_, "female");

                return czzzk_ ?? false;
            };
            if (bzzzz_())
            {
                CqlCode czzzl_ = this.M(context);

                return czzzl_;
            }
            else if (czzza_())
            {
                CqlCode czzzm_ = this.F(context);

                return czzzm_;
            }
            else
            {
                return default;
            }
        };

        return bzzzy_();
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
