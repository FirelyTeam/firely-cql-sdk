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

    #region Expressions

    [CqlExpressionDefinition("Patient")]
    public Patient Patient(CqlContext context)
    {
        IEnumerable<Patient> lzzw_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-patient"));
        Patient lzzx_ = context.Operators.SingletonFrom<Patient>(lzzw_);

        return lzzx_;
    }


    [CqlExpressionDefinition("SDE Ethnicity")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Ethnicity(CqlContext context)
    {
        List<Extension> lzzy_()
        {
            bool mzzh_()
            {
                Patient mzzi_ = this.Patient(context);
                bool mzzj_ = mzzi_ is DomainResource;

                return mzzj_;
            };
            if (mzzh_())
            {
                Patient mzzk_ = this.Patient(context);

                return (mzzk_ as DomainResource).Extension;
            }
            else
            {
                return default;
            }
        };
        bool? lzzz_(Extension @this)
        {
            string mzzl_ = @this?.Url;
            FhirString mzzm_ = context.Operators.Convert<FhirString>(mzzl_);
            string mzzn_ = FHIRHelpers_4_3_000.Instance.ToString(context, mzzm_);
            bool? mzzo_ = context.Operators.Equal(mzzn_, "http://hl7.org/fhir/us/core/StructureDefinition/us-core-ethnicity");

            return mzzo_;
        };
        IEnumerable<Extension> mzza_ = context.Operators.Where<Extension>((IEnumerable<Extension>)(lzzy_()), lzzz_);
        Extension mzzb_ = context.Operators.SingletonFrom<Extension>(mzza_);
        Extension[] mzzc_ = [
            mzzb_,
        ];
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? mzzd_(Extension E)
        {
            bool? mzzp_(Extension @this)
            {
                string nzzk_ = @this?.Url;
                FhirString nzzl_ = context.Operators.Convert<FhirString>(nzzk_);
                string nzzm_ = FHIRHelpers_4_3_000.Instance.ToString(context, nzzl_);
                bool? nzzn_ = context.Operators.Equal(nzzm_, "ombCategory");

                return nzzn_;
            };
            IEnumerable<Extension> mzzq_ = context.Operators.Where<Extension>((IEnumerable<Extension>)(E is Element
                    ? (E as Element).Extension
                    : default), mzzp_);
            object mzzr_(Extension @this)
            {
                DataType nzzo_ = @this?.Value;

                return nzzo_;
            };
            IEnumerable<object> mzzs_ = context.Operators.Select<Extension, object>(mzzq_, mzzr_);
            object mzzt_ = context.Operators.SingletonFrom<object>(mzzs_);
            CqlCode mzzu_ = FHIRHelpers_4_3_000.Instance.ToCode(context, mzzt_ as Coding);
            CqlCode[] mzzv_ = [
                mzzu_,
            ];
            bool? mzzw_(Extension @this)
            {
                string nzzp_ = @this?.Url;
                FhirString nzzq_ = context.Operators.Convert<FhirString>(nzzp_);
                string nzzr_ = FHIRHelpers_4_3_000.Instance.ToString(context, nzzq_);
                bool? nzzs_ = context.Operators.Equal(nzzr_, "detailed");

                return nzzs_;
            };
            IEnumerable<Extension> mzzx_ = context.Operators.Where<Extension>((IEnumerable<Extension>)(E is Element
                    ? (E as Element).Extension
                    : default), mzzw_);
            object mzzy_(Extension @this)
            {
                DataType nzzt_ = @this?.Value;

                return nzzt_;
            };
            IEnumerable<object> mzzz_ = context.Operators.Select<Extension, object>(mzzx_, mzzy_);
            CqlCode nzza_(object @this)
            {
                CqlCode nzzu_ = FHIRHelpers_4_3_000.Instance.ToCode(context, @this as Coding);

                return nzzu_;
            };
            IEnumerable<CqlCode> nzzb_ = context.Operators.Select<object, CqlCode>(mzzz_, nzza_);
            IEnumerable<CqlCode> nzzc_ = context.Operators.Union<CqlCode>(mzzv_ as IEnumerable<CqlCode>, nzzb_);
            bool? nzzd_(Extension @this)
            {
                string nzzv_ = @this?.Url;
                FhirString nzzw_ = context.Operators.Convert<FhirString>(nzzv_);
                string nzzx_ = FHIRHelpers_4_3_000.Instance.ToString(context, nzzw_);
                bool? nzzy_ = context.Operators.Equal(nzzx_, "text");

                return nzzy_;
            };
            IEnumerable<Extension> nzze_ = context.Operators.Where<Extension>((IEnumerable<Extension>)(E is Element
                    ? (E as Element).Extension
                    : default), nzzd_);
            DataType nzzf_(Extension @this)
            {
                DataType nzzz_ = @this?.Value;

                return nzzz_;
            };
            IEnumerable<DataType> nzzg_ = context.Operators.Select<Extension, DataType>(nzze_, nzzf_);
            DataType nzzh_ = context.Operators.SingletonFrom<DataType>(nzzg_);
            string nzzi_ = context.Operators.Convert<string>(nzzh_);
            (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? nzzj_ = (CqlTupleMetadata_HPcCiDPXQfZTXIORThMLfTQDR, nzzc_, nzzi_);

            return nzzj_;
        };
        IEnumerable<(CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)?> mzze_ = context.Operators.Select<Extension, (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)?>((IEnumerable<Extension>)mzzc_, mzzd_);
        IEnumerable<(CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)?> mzzf_ = context.Operators.Distinct<(CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)?>(mzze_);
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? mzzg_ = context.Operators.SingletonFrom<(CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)?>(mzzf_);

        return mzzg_;
    }


    [CqlExpressionDefinition("SDE Payer")]
    public IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> SDE_Payer(CqlContext context)
    {
        CqlValueSet ozza_ = this.Payer_Type(context);
        IEnumerable<Coverage> ozzb_ = context.Operators.Retrieve<Coverage>(new RetrieveParameters(default, ozza_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-coverage"));
        (CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)? ozzc_(Coverage Payer)
        {
            CodeableConcept ozzf_ = Payer?.Type;
            CqlConcept ozzg_ = FHIRHelpers_4_3_000.Instance.ToConcept(context, ozzf_);
            Period ozzh_ = Payer?.Period;
            CqlInterval<CqlDateTime> ozzi_ = FHIRHelpers_4_3_000.Instance.ToInterval(context, ozzh_);
            (CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)? ozzj_ = (CqlTupleMetadata_GPRWMPNAYaJRiGDFSTLJOPeIJ, ozzg_, ozzi_);

            return ozzj_;
        };
        IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> ozzd_ = context.Operators.Select<Coverage, (CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?>(ozzb_, ozzc_);
        IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> ozze_ = context.Operators.Distinct<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?>(ozzd_);

        return ozze_;
    }


    [CqlExpressionDefinition("SDE Race")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Race(CqlContext context)
    {
        List<Extension> ozzk_()
        {
            bool ozzt_()
            {
                Patient ozzu_ = this.Patient(context);
                bool ozzv_ = ozzu_ is DomainResource;

                return ozzv_;
            };
            if (ozzt_())
            {
                Patient ozzw_ = this.Patient(context);

                return (ozzw_ as DomainResource).Extension;
            }
            else
            {
                return default;
            }
        };
        bool? ozzl_(Extension @this)
        {
            string ozzx_ = @this?.Url;
            FhirString ozzy_ = context.Operators.Convert<FhirString>(ozzx_);
            string ozzz_ = FHIRHelpers_4_3_000.Instance.ToString(context, ozzy_);
            bool? pzza_ = context.Operators.Equal(ozzz_, "http://hl7.org/fhir/us/core/StructureDefinition/us-core-race");

            return pzza_;
        };
        IEnumerable<Extension> ozzm_ = context.Operators.Where<Extension>((IEnumerable<Extension>)(ozzk_()), ozzl_);
        Extension ozzn_ = context.Operators.SingletonFrom<Extension>(ozzm_);
        Extension[] ozzo_ = [
            ozzn_,
        ];
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? ozzp_(Extension R)
        {
            bool? pzzb_(Extension @this)
            {
                string pzzv_ = @this?.Url;
                FhirString pzzw_ = context.Operators.Convert<FhirString>(pzzv_);
                string pzzx_ = FHIRHelpers_4_3_000.Instance.ToString(context, pzzw_);
                bool? pzzy_ = context.Operators.Equal(pzzx_, "ombCategory");

                return pzzy_;
            };
            IEnumerable<Extension> pzzc_ = context.Operators.Where<Extension>((IEnumerable<Extension>)(R is Element
                    ? (R as Element).Extension
                    : default), pzzb_);
            object pzzd_(Extension @this)
            {
                DataType pzzz_ = @this?.Value;

                return pzzz_;
            };
            IEnumerable<object> pzze_ = context.Operators.Select<Extension, object>(pzzc_, pzzd_);
            CqlCode pzzf_(object @this)
            {
                CqlCode qzza_ = FHIRHelpers_4_3_000.Instance.ToCode(context, @this as Coding);

                return qzza_;
            };
            IEnumerable<CqlCode> pzzg_ = context.Operators.Select<object, CqlCode>(pzze_, pzzf_);
            bool? pzzh_(Extension @this)
            {
                string qzzb_ = @this?.Url;
                FhirString qzzc_ = context.Operators.Convert<FhirString>(qzzb_);
                string qzzd_ = FHIRHelpers_4_3_000.Instance.ToString(context, qzzc_);
                bool? qzze_ = context.Operators.Equal(qzzd_, "detailed");

                return qzze_;
            };
            IEnumerable<Extension> pzzi_ = context.Operators.Where<Extension>((IEnumerable<Extension>)(R is Element
                    ? (R as Element).Extension
                    : default), pzzh_);
            object pzzj_(Extension @this)
            {
                DataType qzzf_ = @this?.Value;

                return qzzf_;
            };
            IEnumerable<object> pzzk_ = context.Operators.Select<Extension, object>(pzzi_, pzzj_);
            CqlCode pzzl_(object @this)
            {
                CqlCode qzzg_ = FHIRHelpers_4_3_000.Instance.ToCode(context, @this as Coding);

                return qzzg_;
            };
            IEnumerable<CqlCode> pzzm_ = context.Operators.Select<object, CqlCode>(pzzk_, pzzl_);
            IEnumerable<CqlCode> pzzn_ = context.Operators.Union<CqlCode>(pzzg_, pzzm_);
            bool? pzzo_(Extension @this)
            {
                string qzzh_ = @this?.Url;
                FhirString qzzi_ = context.Operators.Convert<FhirString>(qzzh_);
                string qzzj_ = FHIRHelpers_4_3_000.Instance.ToString(context, qzzi_);
                bool? qzzk_ = context.Operators.Equal(qzzj_, "text");

                return qzzk_;
            };
            IEnumerable<Extension> pzzp_ = context.Operators.Where<Extension>((IEnumerable<Extension>)(R is Element
                    ? (R as Element).Extension
                    : default), pzzo_);
            DataType pzzq_(Extension @this)
            {
                DataType qzzl_ = @this?.Value;

                return qzzl_;
            };
            IEnumerable<DataType> pzzr_ = context.Operators.Select<Extension, DataType>(pzzp_, pzzq_);
            DataType pzzs_ = context.Operators.SingletonFrom<DataType>(pzzr_);
            string pzzt_ = context.Operators.Convert<string>(pzzs_);
            (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? pzzu_ = (CqlTupleMetadata_HPcCiDPXQfZTXIORThMLfTQDR, pzzn_, pzzt_);

            return pzzu_;
        };
        IEnumerable<(CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)?> ozzq_ = context.Operators.Select<Extension, (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)?>((IEnumerable<Extension>)ozzo_, ozzp_);
        IEnumerable<(CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)?> ozzr_ = context.Operators.Distinct<(CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)?>(ozzq_);
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? ozzs_ = context.Operators.SingletonFrom<(CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)?>(ozzr_);

        return ozzs_;
    }


    [CqlExpressionDefinition("SDE Sex")]
    public CqlCode SDE_Sex(CqlContext context)
    {
        CqlCode qzzm_()
        {
            bool qzzn_()
            {
                Patient qzzp_ = this.Patient(context);
                Code<AdministrativeGender> qzzq_ = qzzp_?.GenderElement;
                AdministrativeGender? qzzr_ = qzzq_?.Value;
                string qzzs_ = context.Operators.Convert<string>(qzzr_);
                bool? qzzt_ = context.Operators.Equal(qzzs_, "male");

                return qzzt_ ?? false;
            };
            bool qzzo_()
            {
                Patient qzzu_ = this.Patient(context);
                Code<AdministrativeGender> qzzv_ = qzzu_?.GenderElement;
                AdministrativeGender? qzzw_ = qzzv_?.Value;
                string qzzx_ = context.Operators.Convert<string>(qzzw_);
                bool? qzzy_ = context.Operators.Equal(qzzx_, "female");

                return qzzy_ ?? false;
            };
            if (qzzn_())
            {
                return new CqlCode("M", "http://hl7.org/fhir/v3/AdministrativeGender", "Male", default);
            }
            else if (qzzo_())
            {
                return new CqlCode("F", "http://hl7.org/fhir/v3/AdministrativeGender", "Female", default);
            }
            else
            {
                return default;
            }
        };

        return qzzm_();
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
