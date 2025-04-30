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
      new CqlCodeSystem("http://hl7.org/fhir/administrative-gender", null,
          _M,
          _F);

    #endregion CodeSystems

    #region Expressions

    [CqlExpressionDefinition("Patient")]
    public Patient Patient(CqlContext context)
    {
        IEnumerable<Patient> hzzzzzzt_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-patient"));
        Patient hzzzzzzu_ = context.Operators.SingletonFrom<Patient>(hzzzzzzt_);

        return hzzzzzzu_;
    }


    [CqlExpressionDefinition("SDE Ethnicity")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Ethnicity(CqlContext context)
    {
        List<Extension> hzzzzzzv_()
        {
            bool izzzzzze_()
            {
                Patient izzzzzzf_ = this.Patient(context);
                bool izzzzzzg_ = izzzzzzf_ is DomainResource;

                return izzzzzzg_;
            };
            if (izzzzzze_())
            {
                Patient izzzzzzh_ = this.Patient(context);

                return (izzzzzzh_ as DomainResource).Extension;
            }
            else
            {
                return default;
            }
        };
        bool? hzzzzzzw_(Extension @this)
        {
            string izzzzzzi_ = @this?.Url;
            FhirString izzzzzzj_ = context.Operators.Convert<FhirString>(izzzzzzi_);
            string izzzzzzk_ = FHIRHelpers_4_4_000.Instance.ToString(context, izzzzzzj_);
            bool? izzzzzzl_ = context.Operators.Equal(izzzzzzk_, "http://hl7.org/fhir/us/core/StructureDefinition/us-core-ethnicity");

            return izzzzzzl_;
        };
        IEnumerable<Extension> hzzzzzzx_ = context.Operators.Where<Extension>((IEnumerable<Extension>)(hzzzzzzv_()), hzzzzzzw_);
        Extension hzzzzzzy_ = context.Operators.SingletonFrom<Extension>(hzzzzzzx_);
        Extension[] hzzzzzzz_ = [
            hzzzzzzy_,
        ];
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? izzzzzza_(Extension E)
        {
            bool? izzzzzzm_(Extension @this)
            {
                string jzzzzzzh_ = @this?.Url;
                FhirString jzzzzzzi_ = context.Operators.Convert<FhirString>(jzzzzzzh_);
                string jzzzzzzj_ = FHIRHelpers_4_4_000.Instance.ToString(context, jzzzzzzi_);
                bool? jzzzzzzk_ = context.Operators.Equal(jzzzzzzj_, "ombCategory");

                return jzzzzzzk_;
            };
            IEnumerable<Extension> izzzzzzn_ = context.Operators.Where<Extension>((IEnumerable<Extension>)(E is Element
                    ? (E as Element).Extension
                    : default), izzzzzzm_);
            object izzzzzzo_(Extension @this)
            {
                DataType jzzzzzzl_ = @this?.Value;

                return jzzzzzzl_;
            };
            IEnumerable<object> izzzzzzp_ = context.Operators.Select<Extension, object>(izzzzzzn_, izzzzzzo_);
            object izzzzzzq_ = context.Operators.SingletonFrom<object>(izzzzzzp_);
            CqlCode izzzzzzr_ = FHIRHelpers_4_4_000.Instance.ToCode(context, izzzzzzq_ as Coding);
            CqlCode[] izzzzzzs_ = [
                izzzzzzr_,
            ];
            bool? izzzzzzt_(Extension @this)
            {
                string jzzzzzzm_ = @this?.Url;
                FhirString jzzzzzzn_ = context.Operators.Convert<FhirString>(jzzzzzzm_);
                string jzzzzzzo_ = FHIRHelpers_4_4_000.Instance.ToString(context, jzzzzzzn_);
                bool? jzzzzzzp_ = context.Operators.Equal(jzzzzzzo_, "detailed");

                return jzzzzzzp_;
            };
            IEnumerable<Extension> izzzzzzu_ = context.Operators.Where<Extension>((IEnumerable<Extension>)(E is Element
                    ? (E as Element).Extension
                    : default), izzzzzzt_);
            object izzzzzzv_(Extension @this)
            {
                DataType jzzzzzzq_ = @this?.Value;

                return jzzzzzzq_;
            };
            IEnumerable<object> izzzzzzw_ = context.Operators.Select<Extension, object>(izzzzzzu_, izzzzzzv_);
            CqlCode izzzzzzx_(object @this)
            {
                CqlCode jzzzzzzr_ = FHIRHelpers_4_4_000.Instance.ToCode(context, @this as Coding);

                return jzzzzzzr_;
            };
            IEnumerable<CqlCode> izzzzzzy_ = context.Operators.Select<object, CqlCode>(izzzzzzw_, izzzzzzx_);
            IEnumerable<CqlCode> izzzzzzz_ = context.Operators.Union<CqlCode>(izzzzzzs_ as IEnumerable<CqlCode>, izzzzzzy_);
            bool? jzzzzzza_(Extension @this)
            {
                string jzzzzzzs_ = @this?.Url;
                FhirString jzzzzzzt_ = context.Operators.Convert<FhirString>(jzzzzzzs_);
                string jzzzzzzu_ = FHIRHelpers_4_4_000.Instance.ToString(context, jzzzzzzt_);
                bool? jzzzzzzv_ = context.Operators.Equal(jzzzzzzu_, "text");

                return jzzzzzzv_;
            };
            IEnumerable<Extension> jzzzzzzb_ = context.Operators.Where<Extension>((IEnumerable<Extension>)(E is Element
                    ? (E as Element).Extension
                    : default), jzzzzzza_);
            DataType jzzzzzzc_(Extension @this)
            {
                DataType jzzzzzzw_ = @this?.Value;

                return jzzzzzzw_;
            };
            IEnumerable<DataType> jzzzzzzd_ = context.Operators.Select<Extension, DataType>(jzzzzzzb_, jzzzzzzc_);
            DataType jzzzzzze_ = context.Operators.SingletonFrom<DataType>(jzzzzzzd_);
            string jzzzzzzf_ = context.Operators.Convert<string>(jzzzzzze_);
            (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? jzzzzzzg_ = (CqlTupleMetadata_HPcCiDPXQfZTXIORThMLfTQDR, izzzzzzz_, jzzzzzzf_);

            return jzzzzzzg_;
        };
        IEnumerable<(CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)?> izzzzzzb_ = context.Operators.Select<Extension, (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)?>((IEnumerable<Extension>)hzzzzzzz_, izzzzzza_);
        IEnumerable<(CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)?> izzzzzzc_ = context.Operators.Distinct<(CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)?>(izzzzzzb_);
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? izzzzzzd_ = context.Operators.SingletonFrom<(CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)?>(izzzzzzc_);

        return izzzzzzd_;
    }


    [CqlExpressionDefinition("SDE Payer")]
    public IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> SDE_Payer(CqlContext context)
    {
        CqlValueSet jzzzzzzx_ = this.Payer_Type(context);
        IEnumerable<Coverage> jzzzzzzy_ = context.Operators.Retrieve<Coverage>(new RetrieveParameters(default, jzzzzzzx_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-coverage"));
        (CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)? jzzzzzzz_(Coverage Payer)
        {
            CodeableConcept kzzzzzzc_ = Payer?.Type;
            CqlConcept kzzzzzzd_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, kzzzzzzc_);
            Period kzzzzzze_ = Payer?.Period;
            CqlInterval<CqlDateTime> kzzzzzzf_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, kzzzzzze_);
            (CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)? kzzzzzzg_ = (CqlTupleMetadata_GPRWMPNAYaJRiGDFSTLJOPeIJ, kzzzzzzd_, kzzzzzzf_);

            return kzzzzzzg_;
        };
        IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> kzzzzzza_ = context.Operators.Select<Coverage, (CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?>(jzzzzzzy_, jzzzzzzz_);
        IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> kzzzzzzb_ = context.Operators.Distinct<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?>(kzzzzzza_);

        return kzzzzzzb_;
    }


    [CqlExpressionDefinition("SDE Race")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Race(CqlContext context)
    {
        List<Extension> kzzzzzzh_()
        {
            bool kzzzzzzq_()
            {
                Patient kzzzzzzr_ = this.Patient(context);
                bool kzzzzzzs_ = kzzzzzzr_ is DomainResource;

                return kzzzzzzs_;
            };
            if (kzzzzzzq_())
            {
                Patient kzzzzzzt_ = this.Patient(context);

                return (kzzzzzzt_ as DomainResource).Extension;
            }
            else
            {
                return default;
            }
        };
        bool? kzzzzzzi_(Extension @this)
        {
            string kzzzzzzu_ = @this?.Url;
            FhirString kzzzzzzv_ = context.Operators.Convert<FhirString>(kzzzzzzu_);
            string kzzzzzzw_ = FHIRHelpers_4_4_000.Instance.ToString(context, kzzzzzzv_);
            bool? kzzzzzzx_ = context.Operators.Equal(kzzzzzzw_, "http://hl7.org/fhir/us/core/StructureDefinition/us-core-race");

            return kzzzzzzx_;
        };
        IEnumerable<Extension> kzzzzzzj_ = context.Operators.Where<Extension>((IEnumerable<Extension>)(kzzzzzzh_()), kzzzzzzi_);
        Extension kzzzzzzk_ = context.Operators.SingletonFrom<Extension>(kzzzzzzj_);
        Extension[] kzzzzzzl_ = [
            kzzzzzzk_,
        ];
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? kzzzzzzm_(Extension R)
        {
            bool? kzzzzzzy_(Extension @this)
            {
                string lzzzzzzs_ = @this?.Url;
                FhirString lzzzzzzt_ = context.Operators.Convert<FhirString>(lzzzzzzs_);
                string lzzzzzzu_ = FHIRHelpers_4_4_000.Instance.ToString(context, lzzzzzzt_);
                bool? lzzzzzzv_ = context.Operators.Equal(lzzzzzzu_, "ombCategory");

                return lzzzzzzv_;
            };
            IEnumerable<Extension> kzzzzzzz_ = context.Operators.Where<Extension>((IEnumerable<Extension>)(R is Element
                    ? (R as Element).Extension
                    : default), kzzzzzzy_);
            object lzzzzzza_(Extension @this)
            {
                DataType lzzzzzzw_ = @this?.Value;

                return lzzzzzzw_;
            };
            IEnumerable<object> lzzzzzzb_ = context.Operators.Select<Extension, object>(kzzzzzzz_, lzzzzzza_);
            CqlCode lzzzzzzc_(object @this)
            {
                CqlCode lzzzzzzx_ = FHIRHelpers_4_4_000.Instance.ToCode(context, @this as Coding);

                return lzzzzzzx_;
            };
            IEnumerable<CqlCode> lzzzzzzd_ = context.Operators.Select<object, CqlCode>(lzzzzzzb_, lzzzzzzc_);
            bool? lzzzzzze_(Extension @this)
            {
                string lzzzzzzy_ = @this?.Url;
                FhirString lzzzzzzz_ = context.Operators.Convert<FhirString>(lzzzzzzy_);
                string mzzzzzza_ = FHIRHelpers_4_4_000.Instance.ToString(context, lzzzzzzz_);
                bool? mzzzzzzb_ = context.Operators.Equal(mzzzzzza_, "detailed");

                return mzzzzzzb_;
            };
            IEnumerable<Extension> lzzzzzzf_ = context.Operators.Where<Extension>((IEnumerable<Extension>)(R is Element
                    ? (R as Element).Extension
                    : default), lzzzzzze_);
            object lzzzzzzg_(Extension @this)
            {
                DataType mzzzzzzc_ = @this?.Value;

                return mzzzzzzc_;
            };
            IEnumerable<object> lzzzzzzh_ = context.Operators.Select<Extension, object>(lzzzzzzf_, lzzzzzzg_);
            CqlCode lzzzzzzi_(object @this)
            {
                CqlCode mzzzzzzd_ = FHIRHelpers_4_4_000.Instance.ToCode(context, @this as Coding);

                return mzzzzzzd_;
            };
            IEnumerable<CqlCode> lzzzzzzj_ = context.Operators.Select<object, CqlCode>(lzzzzzzh_, lzzzzzzi_);
            IEnumerable<CqlCode> lzzzzzzk_ = context.Operators.Union<CqlCode>(lzzzzzzd_, lzzzzzzj_);
            bool? lzzzzzzl_(Extension @this)
            {
                string mzzzzzze_ = @this?.Url;
                FhirString mzzzzzzf_ = context.Operators.Convert<FhirString>(mzzzzzze_);
                string mzzzzzzg_ = FHIRHelpers_4_4_000.Instance.ToString(context, mzzzzzzf_);
                bool? mzzzzzzh_ = context.Operators.Equal(mzzzzzzg_, "text");

                return mzzzzzzh_;
            };
            IEnumerable<Extension> lzzzzzzm_ = context.Operators.Where<Extension>((IEnumerable<Extension>)(R is Element
                    ? (R as Element).Extension
                    : default), lzzzzzzl_);
            DataType lzzzzzzn_(Extension @this)
            {
                DataType mzzzzzzi_ = @this?.Value;

                return mzzzzzzi_;
            };
            IEnumerable<DataType> lzzzzzzo_ = context.Operators.Select<Extension, DataType>(lzzzzzzm_, lzzzzzzn_);
            DataType lzzzzzzp_ = context.Operators.SingletonFrom<DataType>(lzzzzzzo_);
            string lzzzzzzq_ = context.Operators.Convert<string>(lzzzzzzp_);
            (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? lzzzzzzr_ = (CqlTupleMetadata_HPcCiDPXQfZTXIORThMLfTQDR, lzzzzzzk_, lzzzzzzq_);

            return lzzzzzzr_;
        };
        IEnumerable<(CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)?> kzzzzzzn_ = context.Operators.Select<Extension, (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)?>((IEnumerable<Extension>)kzzzzzzl_, kzzzzzzm_);
        IEnumerable<(CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)?> kzzzzzzo_ = context.Operators.Distinct<(CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)?>(kzzzzzzn_);
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? kzzzzzzp_ = context.Operators.SingletonFrom<(CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)?>(kzzzzzzo_);

        return kzzzzzzp_;
    }


    [CqlExpressionDefinition("SDE Sex")]
    public CqlCode SDE_Sex(CqlContext context)
    {
        CqlCode mzzzzzzj_()
        {
            bool mzzzzzzk_()
            {
                Patient mzzzzzzm_ = this.Patient(context);
                Code<AdministrativeGender> mzzzzzzn_ = mzzzzzzm_?.GenderElement;
                AdministrativeGender? mzzzzzzo_ = mzzzzzzn_?.Value;
                string mzzzzzzp_ = context.Operators.Convert<string>(mzzzzzzo_);
                bool? mzzzzzzq_ = context.Operators.Equal(mzzzzzzp_, "male");

                return mzzzzzzq_ ?? false;
            };
            bool mzzzzzzl_()
            {
                Patient mzzzzzzr_ = this.Patient(context);
                Code<AdministrativeGender> mzzzzzzs_ = mzzzzzzr_?.GenderElement;
                AdministrativeGender? mzzzzzzt_ = mzzzzzzs_?.Value;
                string mzzzzzzu_ = context.Operators.Convert<string>(mzzzzzzt_);
                bool? mzzzzzzv_ = context.Operators.Equal(mzzzzzzu_, "female");

                return mzzzzzzv_ ?? false;
            };
            if (mzzzzzzk_())
            {
                CqlCode mzzzzzzw_ = this.M(context);

                return mzzzzzzw_;
            }
            else if (mzzzzzzl_())
            {
                CqlCode mzzzzzzx_ = this.F(context);

                return mzzzzzzx_;
            }
            else
            {
                return default;
            }
        };

        return mzzzzzzj_();
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
