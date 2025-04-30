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
[CqlLibrary("SupplementalDataElementsFHIR4", "2.0.000")]
public partial class SupplementalDataElementsFHIR4_2_0_000 : ILibrary, ISingleton<SupplementalDataElementsFHIR4_2_0_000>
{
    private SupplementalDataElementsFHIR4_2_0_000() {}

    public static SupplementalDataElementsFHIR4_2_0_000 Instance { get; } = new();

    #region ILibrary Implementation

    public string Name => "SupplementalDataElementsFHIR4";
    public string Version => "2.0.000";
    public ILibrary[] Dependencies => [FHIRHelpers_4_0_001.Instance];

    #endregion ILibrary Implementation

    #region ValueSets

    [CqlValueSetDefinition("Ethnicity", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.114222.4.11.837", valueSetVersion: null)]
    public CqlValueSet Ethnicity(CqlContext _) => _Ethnicity;
    private static readonly CqlValueSet _Ethnicity = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.114222.4.11.837", null);

    [CqlValueSetDefinition("ONC Administrative Sex", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1", valueSetVersion: null)]
    public CqlValueSet ONC_Administrative_Sex(CqlContext _) => _ONC_Administrative_Sex;
    private static readonly CqlValueSet _ONC_Administrative_Sex = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1", null);

    [CqlValueSetDefinition("Payer", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.114222.4.11.3591", valueSetVersion: null)]
    public CqlValueSet Payer(CqlContext _) => _Payer;
    private static readonly CqlValueSet _Payer = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.114222.4.11.3591", null);

    [CqlValueSetDefinition("Race", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.114222.4.11.836", valueSetVersion: null)]
    public CqlValueSet Race(CqlContext _) => _Race;
    private static readonly CqlValueSet _Race = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.114222.4.11.836", null);

    #endregion ValueSets

    #region Expressions

    [CqlExpressionDefinition("Patient")]
    public Patient Patient(CqlContext context)
    {
        IEnumerable<Patient> ezzzi_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/StructureDefinition/Patient"));
        Patient ezzzj_ = context.Operators.SingletonFrom<Patient>(ezzzi_);

        return ezzzj_;
    }


    [CqlExpressionDefinition("SDE Ethnicity")]
    public IEnumerable<Coding> SDE_Ethnicity(CqlContext context)
    {
        IEnumerable<Extension> ezzzk_()
        {
            bool ezzzw_()
            {
                Patient ezzzx_ = this.Patient(context);
                bool ezzzy_ = ezzzx_ is DomainResource;

                return ezzzy_;
            };
            if (ezzzw_())
            {
                Patient ezzzz_ = this.Patient(context);

                return (IEnumerable<Extension>)((ezzzz_ as DomainResource).Extension);
            }
            else
            {
                return default;
            }
        };
        bool? ezzzl_(Extension Extension)
        {
            string fzzza_ = Extension?.Url;
            FhirUri fzzzb_ = context.Operators.Convert<FhirUri>(fzzza_);
            string fzzzc_ = FHIRHelpers_4_0_001.Instance.ToString(context, fzzzb_);
            bool? fzzzd_ = context.Operators.Equal(fzzzc_, "http://hl7.org/fhir/us/core/StructureDefinition/us-core-ethnicity");

            return fzzzd_;
        };
        IEnumerable<Extension> ezzzm_ = context.Operators.Where<Extension>(ezzzk_(), ezzzl_);
        IEnumerable<Extension> ezzzn_(Extension Extension)
        {
            List<Extension> fzzze_ = Extension?.Extension;

            return (IEnumerable<Extension>)fzzze_;
        };
        IEnumerable<IEnumerable<Extension>> ezzzo_ = context.Operators.Select<Extension, IEnumerable<Extension>>(ezzzm_, ezzzn_);
        IEnumerable<IEnumerable<Extension>> ezzzp_ = context.Operators.Distinct<IEnumerable<Extension>>(ezzzo_);
        IEnumerable<Extension> ezzzq_ = context.Operators.Flatten<Extension>(ezzzp_);
        bool? ezzzr_(Extension E)
        {
            string fzzzf_ = E?.Url;
            FhirUri fzzzg_ = context.Operators.Convert<FhirUri>(fzzzf_);
            string fzzzh_ = FHIRHelpers_4_0_001.Instance.ToString(context, fzzzg_);
            bool? fzzzi_ = context.Operators.Equal(fzzzh_, "ombCategory");
            FhirUri fzzzk_ = context.Operators.Convert<FhirUri>(fzzzf_);
            string fzzzl_ = FHIRHelpers_4_0_001.Instance.ToString(context, fzzzk_);
            bool? fzzzm_ = context.Operators.Equal(fzzzl_, "detailed");
            bool? fzzzn_ = context.Operators.Or(fzzzi_, fzzzm_);

            return fzzzn_;
        };
        IEnumerable<Extension> ezzzs_ = context.Operators.Where<Extension>(ezzzq_, ezzzr_);
        Coding ezzzt_(Extension E)
        {
            DataType fzzzo_ = E?.Value;

            return fzzzo_ as Coding;
        };
        IEnumerable<Coding> ezzzu_ = context.Operators.Select<Extension, Coding>(ezzzs_, ezzzt_);
        IEnumerable<Coding> ezzzv_ = context.Operators.Distinct<Coding>(ezzzu_);

        return ezzzv_;
    }


    [CqlExpressionDefinition("SDE Payer")]
    public IEnumerable<(CqlTupleMetadata, CodeableConcept code, Period period)?> SDE_Payer(CqlContext context)
    {
        CqlValueSet fzzzp_ = this.Payer(context);
        IEnumerable<Coverage> fzzzq_ = context.Operators.Retrieve<Coverage>(new RetrieveParameters(default, fzzzp_, default, "http://hl7.org/fhir/StructureDefinition/Coverage"));
        (CqlTupleMetadata, CodeableConcept code, Period period)? fzzzr_(Coverage Payer)
        {
            CodeableConcept fzzzu_ = Payer?.Type;
            Period fzzzv_ = Payer?.Period;
            (CqlTupleMetadata, CodeableConcept code, Period period)? fzzzw_ = (CqlTupleMetadata_CaKghTfWMNOTHSWhifjFZOVYO, fzzzu_, fzzzv_);

            return fzzzw_;
        };
        IEnumerable<(CqlTupleMetadata, CodeableConcept code, Period period)?> fzzzs_ = context.Operators.Select<Coverage, (CqlTupleMetadata, CodeableConcept code, Period period)?>(fzzzq_, fzzzr_);
        IEnumerable<(CqlTupleMetadata, CodeableConcept code, Period period)?> fzzzt_ = context.Operators.Distinct<(CqlTupleMetadata, CodeableConcept code, Period period)?>(fzzzs_);

        return fzzzt_;
    }


    [CqlExpressionDefinition("SDE Race")]
    public IEnumerable<Coding> SDE_Race(CqlContext context)
    {
        IEnumerable<Extension> fzzzx_()
        {
            bool gzzzj_()
            {
                Patient gzzzk_ = this.Patient(context);
                bool gzzzl_ = gzzzk_ is DomainResource;

                return gzzzl_;
            };
            if (gzzzj_())
            {
                Patient gzzzm_ = this.Patient(context);

                return (IEnumerable<Extension>)((gzzzm_ as DomainResource).Extension);
            }
            else
            {
                return default;
            }
        };
        bool? fzzzy_(Extension Extension)
        {
            string gzzzn_ = Extension?.Url;
            FhirUri gzzzo_ = context.Operators.Convert<FhirUri>(gzzzn_);
            string gzzzp_ = FHIRHelpers_4_0_001.Instance.ToString(context, gzzzo_);
            bool? gzzzq_ = context.Operators.Equal(gzzzp_, "http://hl7.org/fhir/us/core/StructureDefinition/us-core-race");

            return gzzzq_;
        };
        IEnumerable<Extension> fzzzz_ = context.Operators.Where<Extension>(fzzzx_(), fzzzy_);
        IEnumerable<Extension> gzzza_(Extension Extension)
        {
            List<Extension> gzzzr_ = Extension?.Extension;

            return (IEnumerable<Extension>)gzzzr_;
        };
        IEnumerable<IEnumerable<Extension>> gzzzb_ = context.Operators.Select<Extension, IEnumerable<Extension>>(fzzzz_, gzzza_);
        IEnumerable<IEnumerable<Extension>> gzzzc_ = context.Operators.Distinct<IEnumerable<Extension>>(gzzzb_);
        IEnumerable<Extension> gzzzd_ = context.Operators.Flatten<Extension>(gzzzc_);
        bool? gzzze_(Extension E)
        {
            string gzzzs_ = E?.Url;
            FhirUri gzzzt_ = context.Operators.Convert<FhirUri>(gzzzs_);
            string gzzzu_ = FHIRHelpers_4_0_001.Instance.ToString(context, gzzzt_);
            bool? gzzzv_ = context.Operators.Equal(gzzzu_, "ombCategory");
            FhirUri gzzzx_ = context.Operators.Convert<FhirUri>(gzzzs_);
            string gzzzy_ = FHIRHelpers_4_0_001.Instance.ToString(context, gzzzx_);
            bool? gzzzz_ = context.Operators.Equal(gzzzy_, "detailed");
            bool? hzzza_ = context.Operators.Or(gzzzv_, gzzzz_);

            return hzzza_;
        };
        IEnumerable<Extension> gzzzf_ = context.Operators.Where<Extension>(gzzzd_, gzzze_);
        Coding gzzzg_(Extension E)
        {
            DataType hzzzb_ = E?.Value;

            return hzzzb_ as Coding;
        };
        IEnumerable<Coding> gzzzh_ = context.Operators.Select<Extension, Coding>(gzzzf_, gzzzg_);
        IEnumerable<Coding> gzzzi_ = context.Operators.Distinct<Coding>(gzzzh_);

        return gzzzi_;
    }


    [CqlExpressionDefinition("SDE Sex")]
    public CqlCode SDE_Sex(CqlContext context)
    {
        CqlCode hzzzc_()
        {
            bool hzzzd_()
            {
                Patient hzzzf_ = this.Patient(context);
                Code<AdministrativeGender> hzzzg_ = hzzzf_?.GenderElement;
                string hzzzh_ = FHIRHelpers_4_0_001.Instance.ToString(context, hzzzg_);
                bool? hzzzi_ = context.Operators.Equal(hzzzh_, "male");

                return hzzzi_ ?? false;
            };
            bool hzzze_()
            {
                Patient hzzzj_ = this.Patient(context);
                Code<AdministrativeGender> hzzzk_ = hzzzj_?.GenderElement;
                string hzzzl_ = FHIRHelpers_4_0_001.Instance.ToString(context, hzzzk_);
                bool? hzzzm_ = context.Operators.Equal(hzzzl_, "female");

                return hzzzm_ ?? false;
            };
            if (hzzzd_())
            {
                return new CqlCode("M", "http://hl7.org/fhir/v3/AdministrativeGender", "Male", default);
            }
            else if (hzzze_())
            {
                return new CqlCode("F", "http://hl7.org/fhir/v3/AdministrativeGender", "Female", default);
            }
            else
            {
                return default;
            }
        };

        return hzzzc_();
    }


    #endregion Expressions

    #region CqlTupleMetadata Properties

    private static CqlTupleMetadata CqlTupleMetadata_CaKghTfWMNOTHSWhifjFZOVYO = new(
        [typeof(CodeableConcept), typeof(Period)],
        ["code", "period"]);

    #endregion CqlTupleMetadata Properties

}
