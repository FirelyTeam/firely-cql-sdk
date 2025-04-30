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
        IEnumerable<Patient> lzzp_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-patient"));
        Patient lzzq_ = context.Operators.SingletonFrom<Patient>(lzzp_);

        return lzzq_;
    }


    [CqlExpressionDefinition("SDE Ethnicity")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Ethnicity(CqlContext context)
    {
        List<Extension> lzzr_()
        {
            bool mzza_()
            {
                Patient mzzb_ = this.Patient(context);
                bool mzzc_ = mzzb_ is DomainResource;

                return mzzc_;
            };
            if (mzza_())
            {
                Patient mzzd_ = this.Patient(context);

                return (mzzd_ as DomainResource).Extension;
            }
            else
            {
                return default;
            }
        };
        bool? lzzs_(Extension @this)
        {
            string mzze_ = @this?.Url;
            FhirString mzzf_ = context.Operators.Convert<FhirString>(mzze_);
            string mzzg_ = FHIRHelpers_4_4_000.Instance.ToString(context, mzzf_);
            bool? mzzh_ = context.Operators.Equal(mzzg_, "http://hl7.org/fhir/us/core/StructureDefinition/us-core-ethnicity");

            return mzzh_;
        };
        IEnumerable<Extension> lzzt_ = context.Operators.Where<Extension>((IEnumerable<Extension>)(lzzr_()), lzzs_);
        Extension lzzu_ = context.Operators.SingletonFrom<Extension>(lzzt_);
        Extension[] lzzv_ = [
            lzzu_,
        ];
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? lzzw_(Extension E)
        {
            bool? mzzi_(Extension @this)
            {
                string nzzd_ = @this?.Url;
                FhirString nzze_ = context.Operators.Convert<FhirString>(nzzd_);
                string nzzf_ = FHIRHelpers_4_4_000.Instance.ToString(context, nzze_);
                bool? nzzg_ = context.Operators.Equal(nzzf_, "ombCategory");

                return nzzg_;
            };
            IEnumerable<Extension> mzzj_ = context.Operators.Where<Extension>((IEnumerable<Extension>)(E is Element
                    ? (E as Element).Extension
                    : default), mzzi_);
            object mzzk_(Extension @this)
            {
                DataType nzzh_ = @this?.Value;

                return nzzh_;
            };
            IEnumerable<object> mzzl_ = context.Operators.Select<Extension, object>(mzzj_, mzzk_);
            object mzzm_ = context.Operators.SingletonFrom<object>(mzzl_);
            CqlCode mzzn_ = FHIRHelpers_4_4_000.Instance.ToCode(context, mzzm_ as Coding);
            CqlCode[] mzzo_ = [
                mzzn_,
            ];
            bool? mzzp_(Extension @this)
            {
                string nzzi_ = @this?.Url;
                FhirString nzzj_ = context.Operators.Convert<FhirString>(nzzi_);
                string nzzk_ = FHIRHelpers_4_4_000.Instance.ToString(context, nzzj_);
                bool? nzzl_ = context.Operators.Equal(nzzk_, "detailed");

                return nzzl_;
            };
            IEnumerable<Extension> mzzq_ = context.Operators.Where<Extension>((IEnumerable<Extension>)(E is Element
                    ? (E as Element).Extension
                    : default), mzzp_);
            object mzzr_(Extension @this)
            {
                DataType nzzm_ = @this?.Value;

                return nzzm_;
            };
            IEnumerable<object> mzzs_ = context.Operators.Select<Extension, object>(mzzq_, mzzr_);
            CqlCode mzzt_(object @this)
            {
                CqlCode nzzn_ = FHIRHelpers_4_4_000.Instance.ToCode(context, @this as Coding);

                return nzzn_;
            };
            IEnumerable<CqlCode> mzzu_ = context.Operators.Select<object, CqlCode>(mzzs_, mzzt_);
            IEnumerable<CqlCode> mzzv_ = context.Operators.Union<CqlCode>(mzzo_ as IEnumerable<CqlCode>, mzzu_);
            bool? mzzw_(Extension @this)
            {
                string nzzo_ = @this?.Url;
                FhirString nzzp_ = context.Operators.Convert<FhirString>(nzzo_);
                string nzzq_ = FHIRHelpers_4_4_000.Instance.ToString(context, nzzp_);
                bool? nzzr_ = context.Operators.Equal(nzzq_, "text");

                return nzzr_;
            };
            IEnumerable<Extension> mzzx_ = context.Operators.Where<Extension>((IEnumerable<Extension>)(E is Element
                    ? (E as Element).Extension
                    : default), mzzw_);
            DataType mzzy_(Extension @this)
            {
                DataType nzzs_ = @this?.Value;

                return nzzs_;
            };
            IEnumerable<DataType> mzzz_ = context.Operators.Select<Extension, DataType>(mzzx_, mzzy_);
            DataType nzza_ = context.Operators.SingletonFrom<DataType>(mzzz_);
            string nzzb_ = context.Operators.Convert<string>(nzza_);
            (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? nzzc_ = (CqlTupleMetadata_HPcCiDPXQfZTXIORThMLfTQDR, mzzv_, nzzb_);

            return nzzc_;
        };
        IEnumerable<(CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)?> lzzx_ = context.Operators.Select<Extension, (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)?>((IEnumerable<Extension>)lzzv_, lzzw_);
        IEnumerable<(CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)?> lzzy_ = context.Operators.Distinct<(CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)?>(lzzx_);
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? lzzz_ = context.Operators.SingletonFrom<(CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)?>(lzzy_);

        return lzzz_;
    }


    [CqlExpressionDefinition("SDE Payer")]
    public IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> SDE_Payer(CqlContext context)
    {
        CqlValueSet nzzt_ = this.Payer_Type(context);
        IEnumerable<Coverage> nzzu_ = context.Operators.Retrieve<Coverage>(new RetrieveParameters(default, nzzt_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-coverage"));
        (CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)? nzzv_(Coverage Payer)
        {
            CodeableConcept nzzy_ = Payer?.Type;
            CqlConcept nzzz_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, nzzy_);
            Period ozza_ = Payer?.Period;
            CqlInterval<CqlDateTime> ozzb_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ozza_);
            (CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)? ozzc_ = (CqlTupleMetadata_GPRWMPNAYaJRiGDFSTLJOPeIJ, nzzz_, ozzb_);

            return ozzc_;
        };
        IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> nzzw_ = context.Operators.Select<Coverage, (CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?>(nzzu_, nzzv_);
        IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> nzzx_ = context.Operators.Distinct<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?>(nzzw_);

        return nzzx_;
    }


    [CqlExpressionDefinition("SDE Race")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Race(CqlContext context)
    {
        List<Extension> ozzd_()
        {
            bool ozzm_()
            {
                Patient ozzn_ = this.Patient(context);
                bool ozzo_ = ozzn_ is DomainResource;

                return ozzo_;
            };
            if (ozzm_())
            {
                Patient ozzp_ = this.Patient(context);

                return (ozzp_ as DomainResource).Extension;
            }
            else
            {
                return default;
            }
        };
        bool? ozze_(Extension @this)
        {
            string ozzq_ = @this?.Url;
            FhirString ozzr_ = context.Operators.Convert<FhirString>(ozzq_);
            string ozzs_ = FHIRHelpers_4_4_000.Instance.ToString(context, ozzr_);
            bool? ozzt_ = context.Operators.Equal(ozzs_, "http://hl7.org/fhir/us/core/StructureDefinition/us-core-race");

            return ozzt_;
        };
        IEnumerable<Extension> ozzf_ = context.Operators.Where<Extension>((IEnumerable<Extension>)(ozzd_()), ozze_);
        Extension ozzg_ = context.Operators.SingletonFrom<Extension>(ozzf_);
        Extension[] ozzh_ = [
            ozzg_,
        ];
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? ozzi_(Extension R)
        {
            bool? ozzu_(Extension @this)
            {
                string pzzo_ = @this?.Url;
                FhirString pzzp_ = context.Operators.Convert<FhirString>(pzzo_);
                string pzzq_ = FHIRHelpers_4_4_000.Instance.ToString(context, pzzp_);
                bool? pzzr_ = context.Operators.Equal(pzzq_, "ombCategory");

                return pzzr_;
            };
            IEnumerable<Extension> ozzv_ = context.Operators.Where<Extension>((IEnumerable<Extension>)(R is Element
                    ? (R as Element).Extension
                    : default), ozzu_);
            object ozzw_(Extension @this)
            {
                DataType pzzs_ = @this?.Value;

                return pzzs_;
            };
            IEnumerable<object> ozzx_ = context.Operators.Select<Extension, object>(ozzv_, ozzw_);
            CqlCode ozzy_(object @this)
            {
                CqlCode pzzt_ = FHIRHelpers_4_4_000.Instance.ToCode(context, @this as Coding);

                return pzzt_;
            };
            IEnumerable<CqlCode> ozzz_ = context.Operators.Select<object, CqlCode>(ozzx_, ozzy_);
            bool? pzza_(Extension @this)
            {
                string pzzu_ = @this?.Url;
                FhirString pzzv_ = context.Operators.Convert<FhirString>(pzzu_);
                string pzzw_ = FHIRHelpers_4_4_000.Instance.ToString(context, pzzv_);
                bool? pzzx_ = context.Operators.Equal(pzzw_, "detailed");

                return pzzx_;
            };
            IEnumerable<Extension> pzzb_ = context.Operators.Where<Extension>((IEnumerable<Extension>)(R is Element
                    ? (R as Element).Extension
                    : default), pzza_);
            object pzzc_(Extension @this)
            {
                DataType pzzy_ = @this?.Value;

                return pzzy_;
            };
            IEnumerable<object> pzzd_ = context.Operators.Select<Extension, object>(pzzb_, pzzc_);
            CqlCode pzze_(object @this)
            {
                CqlCode pzzz_ = FHIRHelpers_4_4_000.Instance.ToCode(context, @this as Coding);

                return pzzz_;
            };
            IEnumerable<CqlCode> pzzf_ = context.Operators.Select<object, CqlCode>(pzzd_, pzze_);
            IEnumerable<CqlCode> pzzg_ = context.Operators.Union<CqlCode>(ozzz_, pzzf_);
            bool? pzzh_(Extension @this)
            {
                string qzza_ = @this?.Url;
                FhirString qzzb_ = context.Operators.Convert<FhirString>(qzza_);
                string qzzc_ = FHIRHelpers_4_4_000.Instance.ToString(context, qzzb_);
                bool? qzzd_ = context.Operators.Equal(qzzc_, "text");

                return qzzd_;
            };
            IEnumerable<Extension> pzzi_ = context.Operators.Where<Extension>((IEnumerable<Extension>)(R is Element
                    ? (R as Element).Extension
                    : default), pzzh_);
            DataType pzzj_(Extension @this)
            {
                DataType qzze_ = @this?.Value;

                return qzze_;
            };
            IEnumerable<DataType> pzzk_ = context.Operators.Select<Extension, DataType>(pzzi_, pzzj_);
            DataType pzzl_ = context.Operators.SingletonFrom<DataType>(pzzk_);
            string pzzm_ = context.Operators.Convert<string>(pzzl_);
            (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? pzzn_ = (CqlTupleMetadata_HPcCiDPXQfZTXIORThMLfTQDR, pzzg_, pzzm_);

            return pzzn_;
        };
        IEnumerable<(CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)?> ozzj_ = context.Operators.Select<Extension, (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)?>((IEnumerable<Extension>)ozzh_, ozzi_);
        IEnumerable<(CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)?> ozzk_ = context.Operators.Distinct<(CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)?>(ozzj_);
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? ozzl_ = context.Operators.SingletonFrom<(CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)?>(ozzk_);

        return ozzl_;
    }


    [CqlExpressionDefinition("SDE Sex")]
    public CqlCode SDE_Sex(CqlContext context)
    {
        CqlCode qzzf_()
        {
            bool qzzg_()
            {
                Patient qzzi_ = this.Patient(context);
                Code<AdministrativeGender> qzzj_ = qzzi_?.GenderElement;
                AdministrativeGender? qzzk_ = qzzj_?.Value;
                string qzzl_ = context.Operators.Convert<string>(qzzk_);
                bool? qzzm_ = context.Operators.Equal(qzzl_, "male");

                return qzzm_ ?? false;
            };
            bool qzzh_()
            {
                Patient qzzn_ = this.Patient(context);
                Code<AdministrativeGender> qzzo_ = qzzn_?.GenderElement;
                AdministrativeGender? qzzp_ = qzzo_?.Value;
                string qzzq_ = context.Operators.Convert<string>(qzzp_);
                bool? qzzr_ = context.Operators.Equal(qzzq_, "female");

                return qzzr_ ?? false;
            };
            if (qzzg_())
            {
                CqlCode qzzs_ = this.M(context);

                return qzzs_;
            }
            else if (qzzh_())
            {
                CqlCode qzzt_ = this.F(context);

                return qzzt_;
            }
            else
            {
                return default;
            }
        };

        return qzzf_();
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
