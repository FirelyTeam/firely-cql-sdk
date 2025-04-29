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
        IEnumerable<Patient> dzzzo_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-patient"));
        Patient dzzzp_ = context.Operators.SingletonFrom<Patient>(dzzzo_);

        return dzzzp_;
    }


    [CqlExpressionDefinition("SDE Ethnicity")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Ethnicity(CqlContext context)
    {
        List<Extension> dzzzq_()
        {
            bool dzzzz_()
            {
                Patient ezzza_ = this.Patient(context);
                bool ezzzb_ = ezzza_ is DomainResource;

                return ezzzb_;
            };
            if (dzzzz_())
            {
                Patient ezzzc_ = this.Patient(context);

                return (ezzzc_ as DomainResource).Extension;
            }
            else
            {
                return default;
            }
        };
        bool? dzzzr_(Extension @this)
        {
            string ezzzd_ = @this?.Url;
            FhirString ezzze_ = context.Operators.Convert<FhirString>(ezzzd_);
            string ezzzf_ = FHIRHelpers_4_3_000.Instance.ToString(context, ezzze_);
            bool? ezzzg_ = context.Operators.Equal(ezzzf_, "http://hl7.org/fhir/us/core/StructureDefinition/us-core-ethnicity");

            return ezzzg_;
        };
        IEnumerable<Extension> dzzzs_ = context.Operators.Where<Extension>((IEnumerable<Extension>)(dzzzq_()), dzzzr_);
        Extension dzzzt_ = context.Operators.SingletonFrom<Extension>(dzzzs_);
        Extension[] dzzzu_ = [
            dzzzt_,
        ];
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? dzzzv_(Extension E)
        {
            bool? ezzzh_(Extension @this)
            {
                string fzzzc_ = @this?.Url;
                FhirString fzzzd_ = context.Operators.Convert<FhirString>(fzzzc_);
                string fzzze_ = FHIRHelpers_4_3_000.Instance.ToString(context, fzzzd_);
                bool? fzzzf_ = context.Operators.Equal(fzzze_, "ombCategory");

                return fzzzf_;
            };
            IEnumerable<Extension> ezzzi_ = context.Operators.Where<Extension>((IEnumerable<Extension>)(E is Element
                    ? (E as Element).Extension
                    : default), ezzzh_);
            object ezzzj_(Extension @this)
            {
                DataType fzzzg_ = @this?.Value;

                return fzzzg_;
            };
            IEnumerable<object> ezzzk_ = context.Operators.Select<Extension, object>(ezzzi_, ezzzj_);
            object ezzzl_ = context.Operators.SingletonFrom<object>(ezzzk_);
            CqlCode ezzzm_ = FHIRHelpers_4_3_000.Instance.ToCode(context, ezzzl_ as Coding);
            CqlCode[] ezzzn_ = [
                ezzzm_,
            ];
            bool? ezzzo_(Extension @this)
            {
                string fzzzh_ = @this?.Url;
                FhirString fzzzi_ = context.Operators.Convert<FhirString>(fzzzh_);
                string fzzzj_ = FHIRHelpers_4_3_000.Instance.ToString(context, fzzzi_);
                bool? fzzzk_ = context.Operators.Equal(fzzzj_, "detailed");

                return fzzzk_;
            };
            IEnumerable<Extension> ezzzp_ = context.Operators.Where<Extension>((IEnumerable<Extension>)(E is Element
                    ? (E as Element).Extension
                    : default), ezzzo_);
            object ezzzq_(Extension @this)
            {
                DataType fzzzl_ = @this?.Value;

                return fzzzl_;
            };
            IEnumerable<object> ezzzr_ = context.Operators.Select<Extension, object>(ezzzp_, ezzzq_);
            CqlCode ezzzs_(object @this)
            {
                CqlCode fzzzm_ = FHIRHelpers_4_3_000.Instance.ToCode(context, @this as Coding);

                return fzzzm_;
            };
            IEnumerable<CqlCode> ezzzt_ = context.Operators.Select<object, CqlCode>(ezzzr_, ezzzs_);
            IEnumerable<CqlCode> ezzzu_ = context.Operators.Union<CqlCode>(ezzzn_ as IEnumerable<CqlCode>, ezzzt_);
            bool? ezzzv_(Extension @this)
            {
                string fzzzn_ = @this?.Url;
                FhirString fzzzo_ = context.Operators.Convert<FhirString>(fzzzn_);
                string fzzzp_ = FHIRHelpers_4_3_000.Instance.ToString(context, fzzzo_);
                bool? fzzzq_ = context.Operators.Equal(fzzzp_, "text");

                return fzzzq_;
            };
            IEnumerable<Extension> ezzzw_ = context.Operators.Where<Extension>((IEnumerable<Extension>)(E is Element
                    ? (E as Element).Extension
                    : default), ezzzv_);
            DataType ezzzx_(Extension @this)
            {
                DataType fzzzr_ = @this?.Value;

                return fzzzr_;
            };
            IEnumerable<DataType> ezzzy_ = context.Operators.Select<Extension, DataType>(ezzzw_, ezzzx_);
            DataType ezzzz_ = context.Operators.SingletonFrom<DataType>(ezzzy_);
            string fzzza_ = context.Operators.Convert<string>(ezzzz_);
            (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? fzzzb_ = (CqlTupleMetadata_HPcCiDPXQfZTXIORThMLfTQDR, ezzzu_, fzzza_);

            return fzzzb_;
        };
        IEnumerable<(CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)?> dzzzw_ = context.Operators.Select<Extension, (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)?>((IEnumerable<Extension>)dzzzu_, dzzzv_);
        IEnumerable<(CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)?> dzzzx_ = context.Operators.Distinct<(CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)?>(dzzzw_);
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? dzzzy_ = context.Operators.SingletonFrom<(CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)?>(dzzzx_);

        return dzzzy_;
    }


    [CqlExpressionDefinition("SDE Payer")]
    public IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> SDE_Payer(CqlContext context)
    {
        CqlValueSet fzzzs_ = this.Payer_Type(context);
        IEnumerable<Coverage> fzzzt_ = context.Operators.Retrieve<Coverage>(new RetrieveParameters(default, fzzzs_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-coverage"));
        (CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)? fzzzu_(Coverage Payer)
        {
            CodeableConcept fzzzx_ = Payer?.Type;
            CqlConcept fzzzy_ = FHIRHelpers_4_3_000.Instance.ToConcept(context, fzzzx_);
            Period fzzzz_ = Payer?.Period;
            CqlInterval<CqlDateTime> gzzza_ = FHIRHelpers_4_3_000.Instance.ToInterval(context, fzzzz_);
            (CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)? gzzzb_ = (CqlTupleMetadata_GPRWMPNAYaJRiGDFSTLJOPeIJ, fzzzy_, gzzza_);

            return gzzzb_;
        };
        IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> fzzzv_ = context.Operators.Select<Coverage, (CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?>(fzzzt_, fzzzu_);
        IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> fzzzw_ = context.Operators.Distinct<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?>(fzzzv_);

        return fzzzw_;
    }


    [CqlExpressionDefinition("SDE Race")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Race(CqlContext context)
    {
        List<Extension> gzzzc_()
        {
            bool gzzzl_()
            {
                Patient gzzzm_ = this.Patient(context);
                bool gzzzn_ = gzzzm_ is DomainResource;

                return gzzzn_;
            };
            if (gzzzl_())
            {
                Patient gzzzo_ = this.Patient(context);

                return (gzzzo_ as DomainResource).Extension;
            }
            else
            {
                return default;
            }
        };
        bool? gzzzd_(Extension @this)
        {
            string gzzzp_ = @this?.Url;
            FhirString gzzzq_ = context.Operators.Convert<FhirString>(gzzzp_);
            string gzzzr_ = FHIRHelpers_4_3_000.Instance.ToString(context, gzzzq_);
            bool? gzzzs_ = context.Operators.Equal(gzzzr_, "http://hl7.org/fhir/us/core/StructureDefinition/us-core-race");

            return gzzzs_;
        };
        IEnumerable<Extension> gzzze_ = context.Operators.Where<Extension>((IEnumerable<Extension>)(gzzzc_()), gzzzd_);
        Extension gzzzf_ = context.Operators.SingletonFrom<Extension>(gzzze_);
        Extension[] gzzzg_ = [
            gzzzf_,
        ];
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? gzzzh_(Extension R)
        {
            bool? gzzzt_(Extension @this)
            {
                string hzzzn_ = @this?.Url;
                FhirString hzzzo_ = context.Operators.Convert<FhirString>(hzzzn_);
                string hzzzp_ = FHIRHelpers_4_3_000.Instance.ToString(context, hzzzo_);
                bool? hzzzq_ = context.Operators.Equal(hzzzp_, "ombCategory");

                return hzzzq_;
            };
            IEnumerable<Extension> gzzzu_ = context.Operators.Where<Extension>((IEnumerable<Extension>)(R is Element
                    ? (R as Element).Extension
                    : default), gzzzt_);
            object gzzzv_(Extension @this)
            {
                DataType hzzzr_ = @this?.Value;

                return hzzzr_;
            };
            IEnumerable<object> gzzzw_ = context.Operators.Select<Extension, object>(gzzzu_, gzzzv_);
            CqlCode gzzzx_(object @this)
            {
                CqlCode hzzzs_ = FHIRHelpers_4_3_000.Instance.ToCode(context, @this as Coding);

                return hzzzs_;
            };
            IEnumerable<CqlCode> gzzzy_ = context.Operators.Select<object, CqlCode>(gzzzw_, gzzzx_);
            bool? gzzzz_(Extension @this)
            {
                string hzzzt_ = @this?.Url;
                FhirString hzzzu_ = context.Operators.Convert<FhirString>(hzzzt_);
                string hzzzv_ = FHIRHelpers_4_3_000.Instance.ToString(context, hzzzu_);
                bool? hzzzw_ = context.Operators.Equal(hzzzv_, "detailed");

                return hzzzw_;
            };
            IEnumerable<Extension> hzzza_ = context.Operators.Where<Extension>((IEnumerable<Extension>)(R is Element
                    ? (R as Element).Extension
                    : default), gzzzz_);
            object hzzzb_(Extension @this)
            {
                DataType hzzzx_ = @this?.Value;

                return hzzzx_;
            };
            IEnumerable<object> hzzzc_ = context.Operators.Select<Extension, object>(hzzza_, hzzzb_);
            CqlCode hzzzd_(object @this)
            {
                CqlCode hzzzy_ = FHIRHelpers_4_3_000.Instance.ToCode(context, @this as Coding);

                return hzzzy_;
            };
            IEnumerable<CqlCode> hzzze_ = context.Operators.Select<object, CqlCode>(hzzzc_, hzzzd_);
            IEnumerable<CqlCode> hzzzf_ = context.Operators.Union<CqlCode>(gzzzy_, hzzze_);
            bool? hzzzg_(Extension @this)
            {
                string hzzzz_ = @this?.Url;
                FhirString izzza_ = context.Operators.Convert<FhirString>(hzzzz_);
                string izzzb_ = FHIRHelpers_4_3_000.Instance.ToString(context, izzza_);
                bool? izzzc_ = context.Operators.Equal(izzzb_, "text");

                return izzzc_;
            };
            IEnumerable<Extension> hzzzh_ = context.Operators.Where<Extension>((IEnumerable<Extension>)(R is Element
                    ? (R as Element).Extension
                    : default), hzzzg_);
            DataType hzzzi_(Extension @this)
            {
                DataType izzzd_ = @this?.Value;

                return izzzd_;
            };
            IEnumerable<DataType> hzzzj_ = context.Operators.Select<Extension, DataType>(hzzzh_, hzzzi_);
            DataType hzzzk_ = context.Operators.SingletonFrom<DataType>(hzzzj_);
            string hzzzl_ = context.Operators.Convert<string>(hzzzk_);
            (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? hzzzm_ = (CqlTupleMetadata_HPcCiDPXQfZTXIORThMLfTQDR, hzzzf_, hzzzl_);

            return hzzzm_;
        };
        IEnumerable<(CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)?> gzzzi_ = context.Operators.Select<Extension, (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)?>((IEnumerable<Extension>)gzzzg_, gzzzh_);
        IEnumerable<(CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)?> gzzzj_ = context.Operators.Distinct<(CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)?>(gzzzi_);
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? gzzzk_ = context.Operators.SingletonFrom<(CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)?>(gzzzj_);

        return gzzzk_;
    }


    [CqlExpressionDefinition("SDE Sex")]
    public CqlCode SDE_Sex(CqlContext context)
    {
        CqlCode izzze_()
        {
            bool izzzf_()
            {
                Patient izzzh_ = this.Patient(context);
                Code<AdministrativeGender> izzzi_ = izzzh_?.GenderElement;
                AdministrativeGender? izzzj_ = izzzi_?.Value;
                string izzzk_ = context.Operators.Convert<string>(izzzj_);
                bool? izzzl_ = context.Operators.Equal(izzzk_, "male");

                return izzzl_ ?? false;
            };
            bool izzzg_()
            {
                Patient izzzm_ = this.Patient(context);
                Code<AdministrativeGender> izzzn_ = izzzm_?.GenderElement;
                AdministrativeGender? izzzo_ = izzzn_?.Value;
                string izzzp_ = context.Operators.Convert<string>(izzzo_);
                bool? izzzq_ = context.Operators.Equal(izzzp_, "female");

                return izzzq_ ?? false;
            };
            if (izzzf_())
            {
                return new CqlCode("M", "http://hl7.org/fhir/v3/AdministrativeGender", null, "Male");
            }
            else if (izzzg_())
            {
                return new CqlCode("F", "http://hl7.org/fhir/v3/AdministrativeGender", null, "Female");
            }
            else
            {
                return default;
            }
        };

        return izzze_();
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
