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
        IEnumerable<Patient> lzzx_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-patient"));
        Patient lzzy_ = context.Operators.SingletonFrom<Patient>(lzzx_);

        return lzzy_;
    }


    [CqlExpressionDefinition("SDE Ethnicity")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Ethnicity(CqlContext context)
    {
        List<Extension> lzzz_()
        {
            bool mzzi_()
            {
                Patient mzzj_ = this.Patient(context);
                bool mzzk_ = mzzj_ is DomainResource;

                return mzzk_;
            };
            if (mzzi_())
            {
                Patient mzzl_ = this.Patient(context);

                return (mzzl_ as DomainResource).Extension;
            }
            else
            {
                return default;
            }
        };
        bool? mzza_(Extension @this)
        {
            string mzzm_ = @this?.Url;
            FhirString mzzn_ = context.Operators.Convert<FhirString>(mzzm_);
            string mzzo_ = FHIRHelpers_4_3_000.Instance.ToString(context, mzzn_);
            bool? mzzp_ = context.Operators.Equal(mzzo_, "http://hl7.org/fhir/us/core/StructureDefinition/us-core-ethnicity");

            return mzzp_;
        };
        IEnumerable<Extension> mzzb_ = context.Operators.Where<Extension>((IEnumerable<Extension>)(lzzz_()), mzza_);
        Extension mzzc_ = context.Operators.SingletonFrom<Extension>(mzzb_);
        Extension[] mzzd_ = [
            mzzc_,
        ];
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? mzze_(Extension E)
        {
            bool? mzzq_(Extension @this)
            {
                string nzzl_ = @this?.Url;
                FhirString nzzm_ = context.Operators.Convert<FhirString>(nzzl_);
                string nzzn_ = FHIRHelpers_4_3_000.Instance.ToString(context, nzzm_);
                bool? nzzo_ = context.Operators.Equal(nzzn_, "ombCategory");

                return nzzo_;
            };
            IEnumerable<Extension> mzzr_ = context.Operators.Where<Extension>((IEnumerable<Extension>)(E is Element
                    ? (E as Element).Extension
                    : default), mzzq_);
            object mzzs_(Extension @this)
            {
                DataType nzzp_ = @this?.Value;

                return nzzp_;
            };
            IEnumerable<object> mzzt_ = context.Operators.Select<Extension, object>(mzzr_, mzzs_);
            object mzzu_ = context.Operators.SingletonFrom<object>(mzzt_);
            CqlCode mzzv_ = FHIRHelpers_4_3_000.Instance.ToCode(context, mzzu_ as Coding);
            CqlCode[] mzzw_ = [
                mzzv_,
            ];
            bool? mzzx_(Extension @this)
            {
                string nzzq_ = @this?.Url;
                FhirString nzzr_ = context.Operators.Convert<FhirString>(nzzq_);
                string nzzs_ = FHIRHelpers_4_3_000.Instance.ToString(context, nzzr_);
                bool? nzzt_ = context.Operators.Equal(nzzs_, "detailed");

                return nzzt_;
            };
            IEnumerable<Extension> mzzy_ = context.Operators.Where<Extension>((IEnumerable<Extension>)(E is Element
                    ? (E as Element).Extension
                    : default), mzzx_);
            object mzzz_(Extension @this)
            {
                DataType nzzu_ = @this?.Value;

                return nzzu_;
            };
            IEnumerable<object> nzza_ = context.Operators.Select<Extension, object>(mzzy_, mzzz_);
            CqlCode nzzb_(object @this)
            {
                CqlCode nzzv_ = FHIRHelpers_4_3_000.Instance.ToCode(context, @this as Coding);

                return nzzv_;
            };
            IEnumerable<CqlCode> nzzc_ = context.Operators.Select<object, CqlCode>(nzza_, nzzb_);
            IEnumerable<CqlCode> nzzd_ = context.Operators.Union<CqlCode>(mzzw_ as IEnumerable<CqlCode>, nzzc_);
            bool? nzze_(Extension @this)
            {
                string nzzw_ = @this?.Url;
                FhirString nzzx_ = context.Operators.Convert<FhirString>(nzzw_);
                string nzzy_ = FHIRHelpers_4_3_000.Instance.ToString(context, nzzx_);
                bool? nzzz_ = context.Operators.Equal(nzzy_, "text");

                return nzzz_;
            };
            IEnumerable<Extension> nzzf_ = context.Operators.Where<Extension>((IEnumerable<Extension>)(E is Element
                    ? (E as Element).Extension
                    : default), nzze_);
            DataType nzzg_(Extension @this)
            {
                DataType ozza_ = @this?.Value;

                return ozza_;
            };
            IEnumerable<DataType> nzzh_ = context.Operators.Select<Extension, DataType>(nzzf_, nzzg_);
            DataType nzzi_ = context.Operators.SingletonFrom<DataType>(nzzh_);
            string nzzj_ = context.Operators.Convert<string>(nzzi_);
            (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? nzzk_ = (CqlTupleMetadata_HPcCiDPXQfZTXIORThMLfTQDR, nzzd_, nzzj_);

            return nzzk_;
        };
        IEnumerable<(CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)?> mzzf_ = context.Operators.Select<Extension, (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)?>((IEnumerable<Extension>)mzzd_, mzze_);
        IEnumerable<(CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)?> mzzg_ = context.Operators.Distinct<(CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)?>(mzzf_);
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? mzzh_ = context.Operators.SingletonFrom<(CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)?>(mzzg_);

        return mzzh_;
    }


    [CqlExpressionDefinition("SDE Payer")]
    public IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> SDE_Payer(CqlContext context)
    {
        CqlValueSet ozzb_ = this.Payer_Type(context);
        IEnumerable<Coverage> ozzc_ = context.Operators.Retrieve<Coverage>(new RetrieveParameters(default, ozzb_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-coverage"));
        (CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)? ozzd_(Coverage Payer)
        {
            CodeableConcept ozzg_ = Payer?.Type;
            CqlConcept ozzh_ = FHIRHelpers_4_3_000.Instance.ToConcept(context, ozzg_);
            Period ozzi_ = Payer?.Period;
            CqlInterval<CqlDateTime> ozzj_ = FHIRHelpers_4_3_000.Instance.ToInterval(context, ozzi_);
            (CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)? ozzk_ = (CqlTupleMetadata_GPRWMPNAYaJRiGDFSTLJOPeIJ, ozzh_, ozzj_);

            return ozzk_;
        };
        IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> ozze_ = context.Operators.Select<Coverage, (CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?>(ozzc_, ozzd_);
        IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> ozzf_ = context.Operators.Distinct<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?>(ozze_);

        return ozzf_;
    }


    [CqlExpressionDefinition("SDE Race")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Race(CqlContext context)
    {
        List<Extension> ozzl_()
        {
            bool ozzu_()
            {
                Patient ozzv_ = this.Patient(context);
                bool ozzw_ = ozzv_ is DomainResource;

                return ozzw_;
            };
            if (ozzu_())
            {
                Patient ozzx_ = this.Patient(context);

                return (ozzx_ as DomainResource).Extension;
            }
            else
            {
                return default;
            }
        };
        bool? ozzm_(Extension @this)
        {
            string ozzy_ = @this?.Url;
            FhirString ozzz_ = context.Operators.Convert<FhirString>(ozzy_);
            string pzza_ = FHIRHelpers_4_3_000.Instance.ToString(context, ozzz_);
            bool? pzzb_ = context.Operators.Equal(pzza_, "http://hl7.org/fhir/us/core/StructureDefinition/us-core-race");

            return pzzb_;
        };
        IEnumerable<Extension> ozzn_ = context.Operators.Where<Extension>((IEnumerable<Extension>)(ozzl_()), ozzm_);
        Extension ozzo_ = context.Operators.SingletonFrom<Extension>(ozzn_);
        Extension[] ozzp_ = [
            ozzo_,
        ];
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? ozzq_(Extension R)
        {
            bool? pzzc_(Extension @this)
            {
                string pzzw_ = @this?.Url;
                FhirString pzzx_ = context.Operators.Convert<FhirString>(pzzw_);
                string pzzy_ = FHIRHelpers_4_3_000.Instance.ToString(context, pzzx_);
                bool? pzzz_ = context.Operators.Equal(pzzy_, "ombCategory");

                return pzzz_;
            };
            IEnumerable<Extension> pzzd_ = context.Operators.Where<Extension>((IEnumerable<Extension>)(R is Element
                    ? (R as Element).Extension
                    : default), pzzc_);
            object pzze_(Extension @this)
            {
                DataType qzza_ = @this?.Value;

                return qzza_;
            };
            IEnumerable<object> pzzf_ = context.Operators.Select<Extension, object>(pzzd_, pzze_);
            CqlCode pzzg_(object @this)
            {
                CqlCode qzzb_ = FHIRHelpers_4_3_000.Instance.ToCode(context, @this as Coding);

                return qzzb_;
            };
            IEnumerable<CqlCode> pzzh_ = context.Operators.Select<object, CqlCode>(pzzf_, pzzg_);
            bool? pzzi_(Extension @this)
            {
                string qzzc_ = @this?.Url;
                FhirString qzzd_ = context.Operators.Convert<FhirString>(qzzc_);
                string qzze_ = FHIRHelpers_4_3_000.Instance.ToString(context, qzzd_);
                bool? qzzf_ = context.Operators.Equal(qzze_, "detailed");

                return qzzf_;
            };
            IEnumerable<Extension> pzzj_ = context.Operators.Where<Extension>((IEnumerable<Extension>)(R is Element
                    ? (R as Element).Extension
                    : default), pzzi_);
            object pzzk_(Extension @this)
            {
                DataType qzzg_ = @this?.Value;

                return qzzg_;
            };
            IEnumerable<object> pzzl_ = context.Operators.Select<Extension, object>(pzzj_, pzzk_);
            CqlCode pzzm_(object @this)
            {
                CqlCode qzzh_ = FHIRHelpers_4_3_000.Instance.ToCode(context, @this as Coding);

                return qzzh_;
            };
            IEnumerable<CqlCode> pzzn_ = context.Operators.Select<object, CqlCode>(pzzl_, pzzm_);
            IEnumerable<CqlCode> pzzo_ = context.Operators.Union<CqlCode>(pzzh_, pzzn_);
            bool? pzzp_(Extension @this)
            {
                string qzzi_ = @this?.Url;
                FhirString qzzj_ = context.Operators.Convert<FhirString>(qzzi_);
                string qzzk_ = FHIRHelpers_4_3_000.Instance.ToString(context, qzzj_);
                bool? qzzl_ = context.Operators.Equal(qzzk_, "text");

                return qzzl_;
            };
            IEnumerable<Extension> pzzq_ = context.Operators.Where<Extension>((IEnumerable<Extension>)(R is Element
                    ? (R as Element).Extension
                    : default), pzzp_);
            DataType pzzr_(Extension @this)
            {
                DataType qzzm_ = @this?.Value;

                return qzzm_;
            };
            IEnumerable<DataType> pzzs_ = context.Operators.Select<Extension, DataType>(pzzq_, pzzr_);
            DataType pzzt_ = context.Operators.SingletonFrom<DataType>(pzzs_);
            string pzzu_ = context.Operators.Convert<string>(pzzt_);
            (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? pzzv_ = (CqlTupleMetadata_HPcCiDPXQfZTXIORThMLfTQDR, pzzo_, pzzu_);

            return pzzv_;
        };
        IEnumerable<(CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)?> ozzr_ = context.Operators.Select<Extension, (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)?>((IEnumerable<Extension>)ozzp_, ozzq_);
        IEnumerable<(CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)?> ozzs_ = context.Operators.Distinct<(CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)?>(ozzr_);
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? ozzt_ = context.Operators.SingletonFrom<(CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)?>(ozzs_);

        return ozzt_;
    }


    [CqlExpressionDefinition("SDE Sex")]
    public CqlCode SDE_Sex(CqlContext context)
    {
        CqlCode qzzn_()
        {
            bool qzzo_()
            {
                Patient qzzq_ = this.Patient(context);
                Code<AdministrativeGender> qzzr_ = qzzq_?.GenderElement;
                AdministrativeGender? qzzs_ = qzzr_?.Value;
                string qzzt_ = context.Operators.Convert<string>(qzzs_);
                bool? qzzu_ = context.Operators.Equal(qzzt_, "male");

                return qzzu_ ?? false;
            };
            bool qzzp_()
            {
                Patient qzzv_ = this.Patient(context);
                Code<AdministrativeGender> qzzw_ = qzzv_?.GenderElement;
                AdministrativeGender? qzzx_ = qzzw_?.Value;
                string qzzy_ = context.Operators.Convert<string>(qzzx_);
                bool? qzzz_ = context.Operators.Equal(qzzy_, "female");

                return qzzz_ ?? false;
            };
            if (qzzo_())
            {
                return new CqlCode("M", "http://hl7.org/fhir/v3/AdministrativeGender", null, "Male");
            }
            else if (qzzp_())
            {
                return new CqlCode("F", "http://hl7.org/fhir/v3/AdministrativeGender", null, "Female");
            }
            else
            {
                return default;
            }
        };

        return qzzn_();
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
