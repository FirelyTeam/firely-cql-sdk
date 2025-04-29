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
        IEnumerable<Patient> mzzs_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-patient"));
        Patient mzzt_ = context.Operators.SingletonFrom<Patient>(mzzs_);

        return mzzt_;
    }


    [CqlExpressionDefinition("SDE Ethnicity")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Ethnicity(CqlContext context)
    {
        List<Extension> mzzu_()
        {
            bool nzzd_()
            {
                Patient nzze_ = this.Patient(context);
                bool nzzf_ = nzze_ is DomainResource;

                return nzzf_;
            };
            if (nzzd_())
            {
                Patient nzzg_ = this.Patient(context);

                return (nzzg_ as DomainResource).Extension;
            }
            else
            {
                return default;
            }
        };
        bool? mzzv_(Extension @this)
        {
            string nzzh_ = @this?.Url;
            FhirString nzzi_ = context.Operators.Convert<FhirString>(nzzh_);
            string nzzj_ = FHIRHelpers_4_3_000.Instance.ToString(context, nzzi_);
            bool? nzzk_ = context.Operators.Equal(nzzj_, "http://hl7.org/fhir/us/core/StructureDefinition/us-core-ethnicity");

            return nzzk_;
        };
        IEnumerable<Extension> mzzw_ = context.Operators.Where<Extension>((IEnumerable<Extension>)(mzzu_()), mzzv_);
        Extension mzzx_ = context.Operators.SingletonFrom<Extension>(mzzw_);
        Extension[] mzzy_ = [
            mzzx_,
        ];
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? mzzz_(Extension E)
        {
            bool? nzzl_(Extension @this)
            {
                string ozzg_ = @this?.Url;
                FhirString ozzh_ = context.Operators.Convert<FhirString>(ozzg_);
                string ozzi_ = FHIRHelpers_4_3_000.Instance.ToString(context, ozzh_);
                bool? ozzj_ = context.Operators.Equal(ozzi_, "ombCategory");

                return ozzj_;
            };
            IEnumerable<Extension> nzzm_ = context.Operators.Where<Extension>((IEnumerable<Extension>)(E is Element
                    ? (E as Element).Extension
                    : default), nzzl_);
            object nzzn_(Extension @this)
            {
                DataType ozzk_ = @this?.Value;

                return ozzk_;
            };
            IEnumerable<object> nzzo_ = context.Operators.Select<Extension, object>(nzzm_, nzzn_);
            object nzzp_ = context.Operators.SingletonFrom<object>(nzzo_);
            CqlCode nzzq_ = FHIRHelpers_4_3_000.Instance.ToCode(context, nzzp_ as Coding);
            CqlCode[] nzzr_ = [
                nzzq_,
            ];
            bool? nzzs_(Extension @this)
            {
                string ozzl_ = @this?.Url;
                FhirString ozzm_ = context.Operators.Convert<FhirString>(ozzl_);
                string ozzn_ = FHIRHelpers_4_3_000.Instance.ToString(context, ozzm_);
                bool? ozzo_ = context.Operators.Equal(ozzn_, "detailed");

                return ozzo_;
            };
            IEnumerable<Extension> nzzt_ = context.Operators.Where<Extension>((IEnumerable<Extension>)(E is Element
                    ? (E as Element).Extension
                    : default), nzzs_);
            object nzzu_(Extension @this)
            {
                DataType ozzp_ = @this?.Value;

                return ozzp_;
            };
            IEnumerable<object> nzzv_ = context.Operators.Select<Extension, object>(nzzt_, nzzu_);
            CqlCode nzzw_(object @this)
            {
                CqlCode ozzq_ = FHIRHelpers_4_3_000.Instance.ToCode(context, @this as Coding);

                return ozzq_;
            };
            IEnumerable<CqlCode> nzzx_ = context.Operators.Select<object, CqlCode>(nzzv_, nzzw_);
            IEnumerable<CqlCode> nzzy_ = context.Operators.Union<CqlCode>(nzzr_ as IEnumerable<CqlCode>, nzzx_);
            bool? nzzz_(Extension @this)
            {
                string ozzr_ = @this?.Url;
                FhirString ozzs_ = context.Operators.Convert<FhirString>(ozzr_);
                string ozzt_ = FHIRHelpers_4_3_000.Instance.ToString(context, ozzs_);
                bool? ozzu_ = context.Operators.Equal(ozzt_, "text");

                return ozzu_;
            };
            IEnumerable<Extension> ozza_ = context.Operators.Where<Extension>((IEnumerable<Extension>)(E is Element
                    ? (E as Element).Extension
                    : default), nzzz_);
            DataType ozzb_(Extension @this)
            {
                DataType ozzv_ = @this?.Value;

                return ozzv_;
            };
            IEnumerable<DataType> ozzc_ = context.Operators.Select<Extension, DataType>(ozza_, ozzb_);
            DataType ozzd_ = context.Operators.SingletonFrom<DataType>(ozzc_);
            string ozze_ = context.Operators.Convert<string>(ozzd_);
            (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? ozzf_ = (CqlTupleMetadata_HPcCiDPXQfZTXIORThMLfTQDR, nzzy_, ozze_);

            return ozzf_;
        };
        IEnumerable<(CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)?> nzza_ = context.Operators.Select<Extension, (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)?>((IEnumerable<Extension>)mzzy_, mzzz_);
        IEnumerable<(CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)?> nzzb_ = context.Operators.Distinct<(CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)?>(nzza_);
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? nzzc_ = context.Operators.SingletonFrom<(CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)?>(nzzb_);

        return nzzc_;
    }


    [CqlExpressionDefinition("SDE Payer")]
    public IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> SDE_Payer(CqlContext context)
    {
        CqlValueSet ozzw_ = this.Payer_Type(context);
        IEnumerable<Coverage> ozzx_ = context.Operators.Retrieve<Coverage>(new RetrieveParameters(default, ozzw_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-coverage"));
        (CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)? ozzy_(Coverage Payer)
        {
            CodeableConcept pzzb_ = Payer?.Type;
            CqlConcept pzzc_ = FHIRHelpers_4_3_000.Instance.ToConcept(context, pzzb_);
            Period pzzd_ = Payer?.Period;
            CqlInterval<CqlDateTime> pzze_ = FHIRHelpers_4_3_000.Instance.ToInterval(context, pzzd_);
            (CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)? pzzf_ = (CqlTupleMetadata_GPRWMPNAYaJRiGDFSTLJOPeIJ, pzzc_, pzze_);

            return pzzf_;
        };
        IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> ozzz_ = context.Operators.Select<Coverage, (CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?>(ozzx_, ozzy_);
        IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> pzza_ = context.Operators.Distinct<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?>(ozzz_);

        return pzza_;
    }


    [CqlExpressionDefinition("SDE Race")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Race(CqlContext context)
    {
        List<Extension> pzzg_()
        {
            bool pzzp_()
            {
                Patient pzzq_ = this.Patient(context);
                bool pzzr_ = pzzq_ is DomainResource;

                return pzzr_;
            };
            if (pzzp_())
            {
                Patient pzzs_ = this.Patient(context);

                return (pzzs_ as DomainResource).Extension;
            }
            else
            {
                return default;
            }
        };
        bool? pzzh_(Extension @this)
        {
            string pzzt_ = @this?.Url;
            FhirString pzzu_ = context.Operators.Convert<FhirString>(pzzt_);
            string pzzv_ = FHIRHelpers_4_3_000.Instance.ToString(context, pzzu_);
            bool? pzzw_ = context.Operators.Equal(pzzv_, "http://hl7.org/fhir/us/core/StructureDefinition/us-core-race");

            return pzzw_;
        };
        IEnumerable<Extension> pzzi_ = context.Operators.Where<Extension>((IEnumerable<Extension>)(pzzg_()), pzzh_);
        Extension pzzj_ = context.Operators.SingletonFrom<Extension>(pzzi_);
        Extension[] pzzk_ = [
            pzzj_,
        ];
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? pzzl_(Extension R)
        {
            bool? pzzx_(Extension @this)
            {
                string qzzr_ = @this?.Url;
                FhirString qzzs_ = context.Operators.Convert<FhirString>(qzzr_);
                string qzzt_ = FHIRHelpers_4_3_000.Instance.ToString(context, qzzs_);
                bool? qzzu_ = context.Operators.Equal(qzzt_, "ombCategory");

                return qzzu_;
            };
            IEnumerable<Extension> pzzy_ = context.Operators.Where<Extension>((IEnumerable<Extension>)(R is Element
                    ? (R as Element).Extension
                    : default), pzzx_);
            object pzzz_(Extension @this)
            {
                DataType qzzv_ = @this?.Value;

                return qzzv_;
            };
            IEnumerable<object> qzza_ = context.Operators.Select<Extension, object>(pzzy_, pzzz_);
            CqlCode qzzb_(object @this)
            {
                CqlCode qzzw_ = FHIRHelpers_4_3_000.Instance.ToCode(context, @this as Coding);

                return qzzw_;
            };
            IEnumerable<CqlCode> qzzc_ = context.Operators.Select<object, CqlCode>(qzza_, qzzb_);
            bool? qzzd_(Extension @this)
            {
                string qzzx_ = @this?.Url;
                FhirString qzzy_ = context.Operators.Convert<FhirString>(qzzx_);
                string qzzz_ = FHIRHelpers_4_3_000.Instance.ToString(context, qzzy_);
                bool? rzza_ = context.Operators.Equal(qzzz_, "detailed");

                return rzza_;
            };
            IEnumerable<Extension> qzze_ = context.Operators.Where<Extension>((IEnumerable<Extension>)(R is Element
                    ? (R as Element).Extension
                    : default), qzzd_);
            object qzzf_(Extension @this)
            {
                DataType rzzb_ = @this?.Value;

                return rzzb_;
            };
            IEnumerable<object> qzzg_ = context.Operators.Select<Extension, object>(qzze_, qzzf_);
            CqlCode qzzh_(object @this)
            {
                CqlCode rzzc_ = FHIRHelpers_4_3_000.Instance.ToCode(context, @this as Coding);

                return rzzc_;
            };
            IEnumerable<CqlCode> qzzi_ = context.Operators.Select<object, CqlCode>(qzzg_, qzzh_);
            IEnumerable<CqlCode> qzzj_ = context.Operators.Union<CqlCode>(qzzc_, qzzi_);
            bool? qzzk_(Extension @this)
            {
                string rzzd_ = @this?.Url;
                FhirString rzze_ = context.Operators.Convert<FhirString>(rzzd_);
                string rzzf_ = FHIRHelpers_4_3_000.Instance.ToString(context, rzze_);
                bool? rzzg_ = context.Operators.Equal(rzzf_, "text");

                return rzzg_;
            };
            IEnumerable<Extension> qzzl_ = context.Operators.Where<Extension>((IEnumerable<Extension>)(R is Element
                    ? (R as Element).Extension
                    : default), qzzk_);
            DataType qzzm_(Extension @this)
            {
                DataType rzzh_ = @this?.Value;

                return rzzh_;
            };
            IEnumerable<DataType> qzzn_ = context.Operators.Select<Extension, DataType>(qzzl_, qzzm_);
            DataType qzzo_ = context.Operators.SingletonFrom<DataType>(qzzn_);
            string qzzp_ = context.Operators.Convert<string>(qzzo_);
            (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? qzzq_ = (CqlTupleMetadata_HPcCiDPXQfZTXIORThMLfTQDR, qzzj_, qzzp_);

            return qzzq_;
        };
        IEnumerable<(CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)?> pzzm_ = context.Operators.Select<Extension, (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)?>((IEnumerable<Extension>)pzzk_, pzzl_);
        IEnumerable<(CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)?> pzzn_ = context.Operators.Distinct<(CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)?>(pzzm_);
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? pzzo_ = context.Operators.SingletonFrom<(CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)?>(pzzn_);

        return pzzo_;
    }


    [CqlExpressionDefinition("SDE Sex")]
    public CqlCode SDE_Sex(CqlContext context)
    {
        CqlCode rzzi_()
        {
            bool rzzj_()
            {
                Patient rzzl_ = this.Patient(context);
                Code<AdministrativeGender> rzzm_ = rzzl_?.GenderElement;
                AdministrativeGender? rzzn_ = rzzm_?.Value;
                string rzzo_ = context.Operators.Convert<string>(rzzn_);
                bool? rzzp_ = context.Operators.Equal(rzzo_, "male");

                return rzzp_ ?? false;
            };
            bool rzzk_()
            {
                Patient rzzq_ = this.Patient(context);
                Code<AdministrativeGender> rzzr_ = rzzq_?.GenderElement;
                AdministrativeGender? rzzs_ = rzzr_?.Value;
                string rzzt_ = context.Operators.Convert<string>(rzzs_);
                bool? rzzu_ = context.Operators.Equal(rzzt_, "female");

                return rzzu_ ?? false;
            };
            if (rzzj_())
            {
                return new CqlCode("M", "http://hl7.org/fhir/v3/AdministrativeGender", null, "Male");
            }
            else if (rzzk_())
            {
                return new CqlCode("F", "http://hl7.org/fhir/v3/AdministrativeGender", null, "Female");
            }
            else
            {
                return default;
            }
        };

        return rzzi_();
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
