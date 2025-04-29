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
        IEnumerable<Patient> yzzzzzm_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-patient"));
        Patient yzzzzzn_ = context.Operators.SingletonFrom<Patient>(yzzzzzm_);

        return yzzzzzn_;
    }


    [CqlExpressionDefinition("SDE Ethnicity")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Ethnicity(CqlContext context)
    {
        List<Extension> yzzzzzo_()
        {
            bool yzzzzzx_()
            {
                Patient yzzzzzy_ = this.Patient(context);
                bool yzzzzzz_ = yzzzzzy_ is DomainResource;

                return yzzzzzz_;
            };
            if (yzzzzzx_())
            {
                Patient zzzzzza_ = this.Patient(context);

                return (zzzzzza_ as DomainResource).Extension;
            }
            else
            {
                return default;
            }
        };
        bool? yzzzzzp_(Extension @this)
        {
            string zzzzzzb_ = @this?.Url;
            FhirString zzzzzzc_ = context.Operators.Convert<FhirString>(zzzzzzb_);
            string zzzzzzd_ = FHIRHelpers_4_4_000.Instance.ToString(context, zzzzzzc_);
            bool? zzzzzze_ = context.Operators.Equal(zzzzzzd_, "http://hl7.org/fhir/us/core/StructureDefinition/us-core-ethnicity");

            return zzzzzze_;
        };
        IEnumerable<Extension> yzzzzzq_ = context.Operators.Where<Extension>((IEnumerable<Extension>)(yzzzzzo_()), yzzzzzp_);
        Extension yzzzzzr_ = context.Operators.SingletonFrom<Extension>(yzzzzzq_);
        Extension[] yzzzzzs_ = [
            yzzzzzr_,
        ];
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? yzzzzzt_(Extension E)
        {
            bool? zzzzzzf_(Extension @this)
            {
                string azzzzzza_ = @this?.Url;
                FhirString azzzzzzb_ = context.Operators.Convert<FhirString>(azzzzzza_);
                string azzzzzzc_ = FHIRHelpers_4_4_000.Instance.ToString(context, azzzzzzb_);
                bool? azzzzzzd_ = context.Operators.Equal(azzzzzzc_, "ombCategory");

                return azzzzzzd_;
            };
            IEnumerable<Extension> zzzzzzg_ = context.Operators.Where<Extension>((IEnumerable<Extension>)(E is Element
                    ? (E as Element).Extension
                    : default), zzzzzzf_);
            object zzzzzzh_(Extension @this)
            {
                DataType azzzzzze_ = @this?.Value;

                return azzzzzze_;
            };
            IEnumerable<object> zzzzzzi_ = context.Operators.Select<Extension, object>(zzzzzzg_, zzzzzzh_);
            object zzzzzzj_ = context.Operators.SingletonFrom<object>(zzzzzzi_);
            CqlCode zzzzzzk_ = FHIRHelpers_4_4_000.Instance.ToCode(context, zzzzzzj_ as Coding);
            CqlCode[] zzzzzzl_ = [
                zzzzzzk_,
            ];
            bool? zzzzzzm_(Extension @this)
            {
                string azzzzzzf_ = @this?.Url;
                FhirString azzzzzzg_ = context.Operators.Convert<FhirString>(azzzzzzf_);
                string azzzzzzh_ = FHIRHelpers_4_4_000.Instance.ToString(context, azzzzzzg_);
                bool? azzzzzzi_ = context.Operators.Equal(azzzzzzh_, "detailed");

                return azzzzzzi_;
            };
            IEnumerable<Extension> zzzzzzn_ = context.Operators.Where<Extension>((IEnumerable<Extension>)(E is Element
                    ? (E as Element).Extension
                    : default), zzzzzzm_);
            object zzzzzzo_(Extension @this)
            {
                DataType azzzzzzj_ = @this?.Value;

                return azzzzzzj_;
            };
            IEnumerable<object> zzzzzzp_ = context.Operators.Select<Extension, object>(zzzzzzn_, zzzzzzo_);
            CqlCode zzzzzzq_(object @this)
            {
                CqlCode azzzzzzk_ = FHIRHelpers_4_4_000.Instance.ToCode(context, @this as Coding);

                return azzzzzzk_;
            };
            IEnumerable<CqlCode> zzzzzzr_ = context.Operators.Select<object, CqlCode>(zzzzzzp_, zzzzzzq_);
            IEnumerable<CqlCode> zzzzzzs_ = context.Operators.Union<CqlCode>(zzzzzzl_ as IEnumerable<CqlCode>, zzzzzzr_);
            bool? zzzzzzt_(Extension @this)
            {
                string azzzzzzl_ = @this?.Url;
                FhirString azzzzzzm_ = context.Operators.Convert<FhirString>(azzzzzzl_);
                string azzzzzzn_ = FHIRHelpers_4_4_000.Instance.ToString(context, azzzzzzm_);
                bool? azzzzzzo_ = context.Operators.Equal(azzzzzzn_, "text");

                return azzzzzzo_;
            };
            IEnumerable<Extension> zzzzzzu_ = context.Operators.Where<Extension>((IEnumerable<Extension>)(E is Element
                    ? (E as Element).Extension
                    : default), zzzzzzt_);
            DataType zzzzzzv_(Extension @this)
            {
                DataType azzzzzzp_ = @this?.Value;

                return azzzzzzp_;
            };
            IEnumerable<DataType> zzzzzzw_ = context.Operators.Select<Extension, DataType>(zzzzzzu_, zzzzzzv_);
            DataType zzzzzzx_ = context.Operators.SingletonFrom<DataType>(zzzzzzw_);
            string zzzzzzy_ = context.Operators.Convert<string>(zzzzzzx_);
            (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? zzzzzzz_ = (CqlTupleMetadata_HPcCiDPXQfZTXIORThMLfTQDR, zzzzzzs_, zzzzzzy_);

            return zzzzzzz_;
        };
        IEnumerable<(CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)?> yzzzzzu_ = context.Operators.Select<Extension, (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)?>((IEnumerable<Extension>)yzzzzzs_, yzzzzzt_);
        IEnumerable<(CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)?> yzzzzzv_ = context.Operators.Distinct<(CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)?>(yzzzzzu_);
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? yzzzzzw_ = context.Operators.SingletonFrom<(CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)?>(yzzzzzv_);

        return yzzzzzw_;
    }


    [CqlExpressionDefinition("SDE Payer")]
    public IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> SDE_Payer(CqlContext context)
    {
        CqlValueSet azzzzzzq_ = this.Payer_Type(context);
        IEnumerable<Coverage> azzzzzzr_ = context.Operators.Retrieve<Coverage>(new RetrieveParameters(default, azzzzzzq_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-coverage"));
        (CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)? azzzzzzs_(Coverage Payer)
        {
            CodeableConcept azzzzzzv_ = Payer?.Type;
            CqlConcept azzzzzzw_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, azzzzzzv_);
            Period azzzzzzx_ = Payer?.Period;
            CqlInterval<CqlDateTime> azzzzzzy_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, azzzzzzx_);
            (CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)? azzzzzzz_ = (CqlTupleMetadata_GPRWMPNAYaJRiGDFSTLJOPeIJ, azzzzzzw_, azzzzzzy_);

            return azzzzzzz_;
        };
        IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> azzzzzzt_ = context.Operators.Select<Coverage, (CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?>(azzzzzzr_, azzzzzzs_);
        IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> azzzzzzu_ = context.Operators.Distinct<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?>(azzzzzzt_);

        return azzzzzzu_;
    }


    [CqlExpressionDefinition("SDE Race")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Race(CqlContext context)
    {
        List<Extension> bzzzzzza_()
        {
            bool bzzzzzzj_()
            {
                Patient bzzzzzzk_ = this.Patient(context);
                bool bzzzzzzl_ = bzzzzzzk_ is DomainResource;

                return bzzzzzzl_;
            };
            if (bzzzzzzj_())
            {
                Patient bzzzzzzm_ = this.Patient(context);

                return (bzzzzzzm_ as DomainResource).Extension;
            }
            else
            {
                return default;
            }
        };
        bool? bzzzzzzb_(Extension @this)
        {
            string bzzzzzzn_ = @this?.Url;
            FhirString bzzzzzzo_ = context.Operators.Convert<FhirString>(bzzzzzzn_);
            string bzzzzzzp_ = FHIRHelpers_4_4_000.Instance.ToString(context, bzzzzzzo_);
            bool? bzzzzzzq_ = context.Operators.Equal(bzzzzzzp_, "http://hl7.org/fhir/us/core/StructureDefinition/us-core-race");

            return bzzzzzzq_;
        };
        IEnumerable<Extension> bzzzzzzc_ = context.Operators.Where<Extension>((IEnumerable<Extension>)(bzzzzzza_()), bzzzzzzb_);
        Extension bzzzzzzd_ = context.Operators.SingletonFrom<Extension>(bzzzzzzc_);
        Extension[] bzzzzzze_ = [
            bzzzzzzd_,
        ];
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? bzzzzzzf_(Extension R)
        {
            bool? bzzzzzzr_(Extension @this)
            {
                string czzzzzzl_ = @this?.Url;
                FhirString czzzzzzm_ = context.Operators.Convert<FhirString>(czzzzzzl_);
                string czzzzzzn_ = FHIRHelpers_4_4_000.Instance.ToString(context, czzzzzzm_);
                bool? czzzzzzo_ = context.Operators.Equal(czzzzzzn_, "ombCategory");

                return czzzzzzo_;
            };
            IEnumerable<Extension> bzzzzzzs_ = context.Operators.Where<Extension>((IEnumerable<Extension>)(R is Element
                    ? (R as Element).Extension
                    : default), bzzzzzzr_);
            object bzzzzzzt_(Extension @this)
            {
                DataType czzzzzzp_ = @this?.Value;

                return czzzzzzp_;
            };
            IEnumerable<object> bzzzzzzu_ = context.Operators.Select<Extension, object>(bzzzzzzs_, bzzzzzzt_);
            CqlCode bzzzzzzv_(object @this)
            {
                CqlCode czzzzzzq_ = FHIRHelpers_4_4_000.Instance.ToCode(context, @this as Coding);

                return czzzzzzq_;
            };
            IEnumerable<CqlCode> bzzzzzzw_ = context.Operators.Select<object, CqlCode>(bzzzzzzu_, bzzzzzzv_);
            bool? bzzzzzzx_(Extension @this)
            {
                string czzzzzzr_ = @this?.Url;
                FhirString czzzzzzs_ = context.Operators.Convert<FhirString>(czzzzzzr_);
                string czzzzzzt_ = FHIRHelpers_4_4_000.Instance.ToString(context, czzzzzzs_);
                bool? czzzzzzu_ = context.Operators.Equal(czzzzzzt_, "detailed");

                return czzzzzzu_;
            };
            IEnumerable<Extension> bzzzzzzy_ = context.Operators.Where<Extension>((IEnumerable<Extension>)(R is Element
                    ? (R as Element).Extension
                    : default), bzzzzzzx_);
            object bzzzzzzz_(Extension @this)
            {
                DataType czzzzzzv_ = @this?.Value;

                return czzzzzzv_;
            };
            IEnumerable<object> czzzzzza_ = context.Operators.Select<Extension, object>(bzzzzzzy_, bzzzzzzz_);
            CqlCode czzzzzzb_(object @this)
            {
                CqlCode czzzzzzw_ = FHIRHelpers_4_4_000.Instance.ToCode(context, @this as Coding);

                return czzzzzzw_;
            };
            IEnumerable<CqlCode> czzzzzzc_ = context.Operators.Select<object, CqlCode>(czzzzzza_, czzzzzzb_);
            IEnumerable<CqlCode> czzzzzzd_ = context.Operators.Union<CqlCode>(bzzzzzzw_, czzzzzzc_);
            bool? czzzzzze_(Extension @this)
            {
                string czzzzzzx_ = @this?.Url;
                FhirString czzzzzzy_ = context.Operators.Convert<FhirString>(czzzzzzx_);
                string czzzzzzz_ = FHIRHelpers_4_4_000.Instance.ToString(context, czzzzzzy_);
                bool? dzzzzzza_ = context.Operators.Equal(czzzzzzz_, "text");

                return dzzzzzza_;
            };
            IEnumerable<Extension> czzzzzzf_ = context.Operators.Where<Extension>((IEnumerable<Extension>)(R is Element
                    ? (R as Element).Extension
                    : default), czzzzzze_);
            DataType czzzzzzg_(Extension @this)
            {
                DataType dzzzzzzb_ = @this?.Value;

                return dzzzzzzb_;
            };
            IEnumerable<DataType> czzzzzzh_ = context.Operators.Select<Extension, DataType>(czzzzzzf_, czzzzzzg_);
            DataType czzzzzzi_ = context.Operators.SingletonFrom<DataType>(czzzzzzh_);
            string czzzzzzj_ = context.Operators.Convert<string>(czzzzzzi_);
            (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? czzzzzzk_ = (CqlTupleMetadata_HPcCiDPXQfZTXIORThMLfTQDR, czzzzzzd_, czzzzzzj_);

            return czzzzzzk_;
        };
        IEnumerable<(CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)?> bzzzzzzg_ = context.Operators.Select<Extension, (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)?>((IEnumerable<Extension>)bzzzzzze_, bzzzzzzf_);
        IEnumerable<(CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)?> bzzzzzzh_ = context.Operators.Distinct<(CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)?>(bzzzzzzg_);
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? bzzzzzzi_ = context.Operators.SingletonFrom<(CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)?>(bzzzzzzh_);

        return bzzzzzzi_;
    }


    [CqlExpressionDefinition("SDE Sex")]
    public CqlCode SDE_Sex(CqlContext context)
    {
        CqlCode dzzzzzzc_()
        {
            bool dzzzzzzd_()
            {
                Patient dzzzzzzf_ = this.Patient(context);
                Code<AdministrativeGender> dzzzzzzg_ = dzzzzzzf_?.GenderElement;
                AdministrativeGender? dzzzzzzh_ = dzzzzzzg_?.Value;
                string dzzzzzzi_ = context.Operators.Convert<string>(dzzzzzzh_);
                bool? dzzzzzzj_ = context.Operators.Equal(dzzzzzzi_, "male");

                return dzzzzzzj_ ?? false;
            };
            bool dzzzzzze_()
            {
                Patient dzzzzzzk_ = this.Patient(context);
                Code<AdministrativeGender> dzzzzzzl_ = dzzzzzzk_?.GenderElement;
                AdministrativeGender? dzzzzzzm_ = dzzzzzzl_?.Value;
                string dzzzzzzn_ = context.Operators.Convert<string>(dzzzzzzm_);
                bool? dzzzzzzo_ = context.Operators.Equal(dzzzzzzn_, "female");

                return dzzzzzzo_ ?? false;
            };
            if (dzzzzzzd_())
            {
                CqlCode dzzzzzzp_ = this.M(context);

                return dzzzzzzp_;
            }
            else if (dzzzzzze_())
            {
                CqlCode dzzzzzzq_ = this.F(context);

                return dzzzzzzq_;
            }
            else
            {
                return default;
            }
        };

        return dzzzzzzc_();
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
