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
[CqlLibrary("HIVRetentionFHIR", "0.1.000")]
public partial class HIVRetentionFHIR_0_1_000 : ILibrary, ISingleton<HIVRetentionFHIR_0_1_000>
{
    private HIVRetentionFHIR_0_1_000() {}

    public static HIVRetentionFHIR_0_1_000 Instance { get; } = new();

    #region ILibrary Implementation

    public string Name => "HIVRetentionFHIR";
    public string Version => "0.1.000";
    public ILibrary[] Dependencies => [CQMCommon_2_2_000.Instance, FHIRHelpers_4_4_000.Instance, QICoreCommon_2_1_000.Instance, SupplementalDataElements_3_5_000.Instance, CumulativeMedicationDuration_4_1_000.Instance];

    #endregion ILibrary Implementation

    #region ValueSets

    #region ValueSet: Annual Wellness Visit
    [CqlValueSetDefinition(
        definitionName: "Annual Wellness Visit",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1240",
        valueSetVersion: null)]
    public CqlValueSet Annual_Wellness_Visit(CqlContext context) => _Annual_Wellness_Visit;

    private static readonly CqlValueSet _Annual_Wellness_Visit = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1240", null);
    #endregion

    #region ValueSet: Face-to-Face Interaction
    [CqlValueSetDefinition(
        definitionName: "Face-to-Face Interaction",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1048",
        valueSetVersion: null)]
    public CqlValueSet Face_to_Face_Interaction(CqlContext context) => _Face_to_Face_Interaction;

    private static readonly CqlValueSet _Face_to_Face_Interaction = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1048", null);
    #endregion

    #region ValueSet: HIV
    [CqlValueSetDefinition(
        definitionName: "HIV",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.120.12.1003",
        valueSetVersion: null)]
    public CqlValueSet HIV(CqlContext context) => _HIV;

    private static readonly CqlValueSet _HIV = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.120.12.1003", null);
    #endregion

    #region ValueSet: HIV Viral Load
    [CqlValueSetDefinition(
        definitionName: "HIV Viral Load",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.120.12.1002",
        valueSetVersion: null)]
    public CqlValueSet HIV_Viral_Load(CqlContext context) => _HIV_Viral_Load;

    private static readonly CqlValueSet _HIV_Viral_Load = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.120.12.1002", null);
    #endregion

    #region ValueSet: Home Healthcare Services
    [CqlValueSetDefinition(
        definitionName: "Home Healthcare Services",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1016",
        valueSetVersion: null)]
    public CqlValueSet Home_Healthcare_Services(CqlContext context) => _Home_Healthcare_Services;

    private static readonly CqlValueSet _Home_Healthcare_Services = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1016", null);
    #endregion

    #region ValueSet: Office Visit
    [CqlValueSetDefinition(
        definitionName: "Office Visit",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1001",
        valueSetVersion: null)]
    public CqlValueSet Office_Visit(CqlContext context) => _Office_Visit;

    private static readonly CqlValueSet _Office_Visit = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1001", null);
    #endregion

    #region ValueSet: Outpatient Consultation
    [CqlValueSetDefinition(
        definitionName: "Outpatient Consultation",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1008",
        valueSetVersion: null)]
    public CqlValueSet Outpatient_Consultation(CqlContext context) => _Outpatient_Consultation;

    private static readonly CqlValueSet _Outpatient_Consultation = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1008", null);
    #endregion

    #region ValueSet: Preventive Care Services Established Office Visit, 18 and Up
    [CqlValueSetDefinition(
        definitionName: "Preventive Care Services Established Office Visit, 18 and Up",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1025",
        valueSetVersion: null)]
    public CqlValueSet Preventive_Care_Services_Established_Office_Visit__18_and_Up(CqlContext context) => _Preventive_Care_Services_Established_Office_Visit__18_and_Up;

    private static readonly CqlValueSet _Preventive_Care_Services_Established_Office_Visit__18_and_Up = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1025", null);
    #endregion

    #region ValueSet: Preventive Care Services Initial Office Visit, 18 and Up
    [CqlValueSetDefinition(
        definitionName: "Preventive Care Services Initial Office Visit, 18 and Up",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1023",
        valueSetVersion: null)]
    public CqlValueSet Preventive_Care_Services_Initial_Office_Visit__18_and_Up(CqlContext context) => _Preventive_Care_Services_Initial_Office_Visit__18_and_Up;

    private static readonly CqlValueSet _Preventive_Care_Services_Initial_Office_Visit__18_and_Up = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1023", null);
    #endregion

    #region ValueSet: Preventive Care Services, Initial Office Visit, 0 to 17
    [CqlValueSetDefinition(
        definitionName: "Preventive Care Services, Initial Office Visit, 0 to 17",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1022",
        valueSetVersion: null)]
    public CqlValueSet Preventive_Care_Services__Initial_Office_Visit__0_to_17(CqlContext context) => _Preventive_Care_Services__Initial_Office_Visit__0_to_17;

    private static readonly CqlValueSet _Preventive_Care_Services__Initial_Office_Visit__0_to_17 = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1022", null);
    #endregion

    #region ValueSet: Preventive Care, Established Office Visit, 0 to 17
    [CqlValueSetDefinition(
        definitionName: "Preventive Care, Established Office Visit, 0 to 17",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1024",
        valueSetVersion: null)]
    public CqlValueSet Preventive_Care__Established_Office_Visit__0_to_17(CqlContext context) => _Preventive_Care__Established_Office_Visit__0_to_17;

    private static readonly CqlValueSet _Preventive_Care__Established_Office_Visit__0_to_17 = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1024", null);
    #endregion

    #region ValueSet: Telephone Visits
    [CqlValueSetDefinition(
        definitionName: "Telephone Visits",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1080",
        valueSetVersion: null)]
    public CqlValueSet Telephone_Visits(CqlContext context) => _Telephone_Visits;

    private static readonly CqlValueSet _Telephone_Visits = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1080", null);
    #endregion

    #region ValueSet: Preventive Care Services Other
    [CqlValueSetDefinition(
        definitionName: "Preventive Care Services Other",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.11.1150",
        valueSetVersion: null)]
    public CqlValueSet Preventive_Care_Services_Other(CqlContext context) => _Preventive_Care_Services_Other;

    private static readonly CqlValueSet _Preventive_Care_Services_Other = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.11.1150", null);
    #endregion

    #endregion ValueSets

    #region CodeSystems

    [CqlCodeSystemDefinition(
        definitionName: "CPT")]
    public CqlCode[] CPT(CqlContext context)
    {
        CqlCode[] jzzzzzzzzg_ = []
;

        return jzzzzzzzzg_;
    }


    #endregion CodeSystems

    #region Parameters

    [CqlParameterDefinition(
        definitionName: "Measurement Period")]
    public CqlInterval<CqlDateTime> Measurement_Period(CqlContext context)
    {
        CqlDateTime jzzzzzzzzh_ = context.Operators.DateTime(2025, 1, 1, 0, 0, 0, 0, 0.0m);
        CqlDateTime jzzzzzzzzi_ = context.Operators.DateTime(2025, 12, 31, 23, 59, 59, 999, 0.0m);
        CqlInterval<CqlDateTime> jzzzzzzzzj_ = context.Operators.Interval(jzzzzzzzzh_, jzzzzzzzzi_, true, true);
        object jzzzzzzzzk_ = context.ResolveParameter("HIVRetentionFHIR-0.1.000", "Measurement Period", jzzzzzzzzj_);

        return (CqlInterval<CqlDateTime>)jzzzzzzzzk_;
    }


    #endregion Parameters

    #region Expressions

    [CqlExpressionDefinition(
        definitionName: "Patient")]
    public Patient Patient(CqlContext context)
    {
        IEnumerable<Patient> jzzzzzzzzl_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-patient"));
        Patient jzzzzzzzzm_ = context.Operators.SingletonFrom<Patient>(jzzzzzzzzl_);

        return jzzzzzzzzm_;
    }


    [CqlExpressionDefinition(
        definitionName: "SDE Payer")]
    public IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> SDE_Payer(CqlContext context)
    {
        IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> jzzzzzzzzn_ = SupplementalDataElements_3_5_000.Instance.SDE_Payer(context);

        return jzzzzzzzzn_;
    }


    [CqlExpressionDefinition(
        definitionName: "SDE Ethnicity")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Ethnicity(CqlContext context)
    {
        List<Extension> jzzzzzzzzo_()
        {
            bool jzzzzzzzzx_()
            {
                Patient jzzzzzzzzy_ = this.Patient(context);
                bool jzzzzzzzzz_ = jzzzzzzzzy_ is DomainResource;

                return jzzzzzzzzz_;
            };
            if (jzzzzzzzzx_())
            {
                Patient kzzzzzzzza_ = this.Patient(context);

                return (kzzzzzzzza_ as DomainResource).Extension;
            }
            else
            {
                return default;
            }
        };
        bool? jzzzzzzzzp_(Extension @this)
        {
            string kzzzzzzzzb_ = @this?.Url;
            FhirString kzzzzzzzzc_ = context.Operators.Convert<FhirString>(kzzzzzzzzb_);
            string kzzzzzzzzd_ = FHIRHelpers_4_4_000.Instance.ToString(context, kzzzzzzzzc_);
            bool? kzzzzzzzze_ = context.Operators.Equal(kzzzzzzzzd_, "http://hl7.org/fhir/us/core/StructureDefinition/us-core-ethnicity");

            return kzzzzzzzze_;
        };
        IEnumerable<Extension> jzzzzzzzzq_ = context.Operators.Where<Extension>((IEnumerable<Extension>)(jzzzzzzzzo_()), jzzzzzzzzp_);
        Extension jzzzzzzzzr_ = context.Operators.SingletonFrom<Extension>(jzzzzzzzzq_);
        Extension[] jzzzzzzzzs_ = [
            jzzzzzzzzr_,
        ];
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? jzzzzzzzzt_(Extension E)
        {
            bool? kzzzzzzzzf_(Extension @this)
            {
                string lzzzzzzzza_ = @this?.Url;
                FhirString lzzzzzzzzb_ = context.Operators.Convert<FhirString>(lzzzzzzzza_);
                string lzzzzzzzzc_ = FHIRHelpers_4_4_000.Instance.ToString(context, lzzzzzzzzb_);
                bool? lzzzzzzzzd_ = context.Operators.Equal(lzzzzzzzzc_, "ombCategory");

                return lzzzzzzzzd_;
            };
            IEnumerable<Extension> kzzzzzzzzg_ = context.Operators.Where<Extension>((IEnumerable<Extension>)(E is Element
                    ? (E as Element).Extension
                    : default), kzzzzzzzzf_);
            object kzzzzzzzzh_(Extension @this)
            {
                DataType lzzzzzzzze_ = @this?.Value;

                return lzzzzzzzze_;
            };
            IEnumerable<object> kzzzzzzzzi_ = context.Operators.Select<Extension, object>(kzzzzzzzzg_, kzzzzzzzzh_);
            object kzzzzzzzzj_ = context.Operators.SingletonFrom<object>(kzzzzzzzzi_);
            CqlCode kzzzzzzzzk_ = FHIRHelpers_4_4_000.Instance.ToCode(context, kzzzzzzzzj_ as Coding);
            CqlCode[] kzzzzzzzzl_ = [
                kzzzzzzzzk_,
            ];
            bool? kzzzzzzzzm_(Extension @this)
            {
                string lzzzzzzzzf_ = @this?.Url;
                FhirString lzzzzzzzzg_ = context.Operators.Convert<FhirString>(lzzzzzzzzf_);
                string lzzzzzzzzh_ = FHIRHelpers_4_4_000.Instance.ToString(context, lzzzzzzzzg_);
                bool? lzzzzzzzzi_ = context.Operators.Equal(lzzzzzzzzh_, "detailed");

                return lzzzzzzzzi_;
            };
            IEnumerable<Extension> kzzzzzzzzn_ = context.Operators.Where<Extension>((IEnumerable<Extension>)(E is Element
                    ? (E as Element).Extension
                    : default), kzzzzzzzzm_);
            object kzzzzzzzzo_(Extension @this)
            {
                DataType lzzzzzzzzj_ = @this?.Value;

                return lzzzzzzzzj_;
            };
            IEnumerable<object> kzzzzzzzzp_ = context.Operators.Select<Extension, object>(kzzzzzzzzn_, kzzzzzzzzo_);
            CqlCode kzzzzzzzzq_(object @this)
            {
                CqlCode lzzzzzzzzk_ = FHIRHelpers_4_4_000.Instance.ToCode(context, @this as Coding);

                return lzzzzzzzzk_;
            };
            IEnumerable<CqlCode> kzzzzzzzzr_ = context.Operators.Select<object, CqlCode>(kzzzzzzzzp_, kzzzzzzzzq_);
            IEnumerable<CqlCode> kzzzzzzzzs_ = context.Operators.Union<CqlCode>(kzzzzzzzzl_ as IEnumerable<CqlCode>, kzzzzzzzzr_);
            bool? kzzzzzzzzt_(Extension @this)
            {
                string lzzzzzzzzl_ = @this?.Url;
                FhirString lzzzzzzzzm_ = context.Operators.Convert<FhirString>(lzzzzzzzzl_);
                string lzzzzzzzzn_ = FHIRHelpers_4_4_000.Instance.ToString(context, lzzzzzzzzm_);
                bool? lzzzzzzzzo_ = context.Operators.Equal(lzzzzzzzzn_, "text");

                return lzzzzzzzzo_;
            };
            IEnumerable<Extension> kzzzzzzzzu_ = context.Operators.Where<Extension>((IEnumerable<Extension>)(E is Element
                    ? (E as Element).Extension
                    : default), kzzzzzzzzt_);
            DataType kzzzzzzzzv_(Extension @this)
            {
                DataType lzzzzzzzzp_ = @this?.Value;

                return lzzzzzzzzp_;
            };
            IEnumerable<DataType> kzzzzzzzzw_ = context.Operators.Select<Extension, DataType>(kzzzzzzzzu_, kzzzzzzzzv_);
            DataType kzzzzzzzzx_ = context.Operators.SingletonFrom<DataType>(kzzzzzzzzw_);
            string kzzzzzzzzy_ = context.Operators.Convert<string>(kzzzzzzzzx_);
            (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? kzzzzzzzzz_ = (CqlTupleMetadata_HPcCiDPXQfZTXIORThMLfTQDR, kzzzzzzzzs_, kzzzzzzzzy_);

            return kzzzzzzzzz_;
        };
        IEnumerable<(CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)?> jzzzzzzzzu_ = context.Operators.Select<Extension, (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)?>((IEnumerable<Extension>)jzzzzzzzzs_, jzzzzzzzzt_);
        IEnumerable<(CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)?> jzzzzzzzzv_ = context.Operators.Distinct<(CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)?>(jzzzzzzzzu_);
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? jzzzzzzzzw_ = context.Operators.SingletonFrom<(CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)?>(jzzzzzzzzv_);

        return jzzzzzzzzw_;
    }


    [CqlExpressionDefinition(
        definitionName: "SDE Race")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Race(CqlContext context)
    {
        List<Extension> lzzzzzzzzq_()
        {
            bool lzzzzzzzzz_()
            {
                Patient mzzzzzzzza_ = this.Patient(context);
                bool mzzzzzzzzb_ = mzzzzzzzza_ is DomainResource;

                return mzzzzzzzzb_;
            };
            if (lzzzzzzzzz_())
            {
                Patient mzzzzzzzzc_ = this.Patient(context);

                return (mzzzzzzzzc_ as DomainResource).Extension;
            }
            else
            {
                return default;
            }
        };
        bool? lzzzzzzzzr_(Extension @this)
        {
            string mzzzzzzzzd_ = @this?.Url;
            FhirString mzzzzzzzze_ = context.Operators.Convert<FhirString>(mzzzzzzzzd_);
            string mzzzzzzzzf_ = FHIRHelpers_4_4_000.Instance.ToString(context, mzzzzzzzze_);
            bool? mzzzzzzzzg_ = context.Operators.Equal(mzzzzzzzzf_, "http://hl7.org/fhir/us/core/StructureDefinition/us-core-race");

            return mzzzzzzzzg_;
        };
        IEnumerable<Extension> lzzzzzzzzs_ = context.Operators.Where<Extension>((IEnumerable<Extension>)(lzzzzzzzzq_()), lzzzzzzzzr_);
        Extension lzzzzzzzzt_ = context.Operators.SingletonFrom<Extension>(lzzzzzzzzs_);
        Extension[] lzzzzzzzzu_ = [
            lzzzzzzzzt_,
        ];
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? lzzzzzzzzv_(Extension R)
        {
            bool? mzzzzzzzzh_(Extension @this)
            {
                string nzzzzzzzzb_ = @this?.Url;
                FhirString nzzzzzzzzc_ = context.Operators.Convert<FhirString>(nzzzzzzzzb_);
                string nzzzzzzzzd_ = FHIRHelpers_4_4_000.Instance.ToString(context, nzzzzzzzzc_);
                bool? nzzzzzzzze_ = context.Operators.Equal(nzzzzzzzzd_, "ombCategory");

                return nzzzzzzzze_;
            };
            IEnumerable<Extension> mzzzzzzzzi_ = context.Operators.Where<Extension>((IEnumerable<Extension>)(R is Element
                    ? (R as Element).Extension
                    : default), mzzzzzzzzh_);
            object mzzzzzzzzj_(Extension @this)
            {
                DataType nzzzzzzzzf_ = @this?.Value;

                return nzzzzzzzzf_;
            };
            IEnumerable<object> mzzzzzzzzk_ = context.Operators.Select<Extension, object>(mzzzzzzzzi_, mzzzzzzzzj_);
            CqlCode mzzzzzzzzl_(object @this)
            {
                CqlCode nzzzzzzzzg_ = FHIRHelpers_4_4_000.Instance.ToCode(context, @this as Coding);

                return nzzzzzzzzg_;
            };
            IEnumerable<CqlCode> mzzzzzzzzm_ = context.Operators.Select<object, CqlCode>(mzzzzzzzzk_, mzzzzzzzzl_);
            bool? mzzzzzzzzn_(Extension @this)
            {
                string nzzzzzzzzh_ = @this?.Url;
                FhirString nzzzzzzzzi_ = context.Operators.Convert<FhirString>(nzzzzzzzzh_);
                string nzzzzzzzzj_ = FHIRHelpers_4_4_000.Instance.ToString(context, nzzzzzzzzi_);
                bool? nzzzzzzzzk_ = context.Operators.Equal(nzzzzzzzzj_, "detailed");

                return nzzzzzzzzk_;
            };
            IEnumerable<Extension> mzzzzzzzzo_ = context.Operators.Where<Extension>((IEnumerable<Extension>)(R is Element
                    ? (R as Element).Extension
                    : default), mzzzzzzzzn_);
            object mzzzzzzzzp_(Extension @this)
            {
                DataType nzzzzzzzzl_ = @this?.Value;

                return nzzzzzzzzl_;
            };
            IEnumerable<object> mzzzzzzzzq_ = context.Operators.Select<Extension, object>(mzzzzzzzzo_, mzzzzzzzzp_);
            CqlCode mzzzzzzzzr_(object @this)
            {
                CqlCode nzzzzzzzzm_ = FHIRHelpers_4_4_000.Instance.ToCode(context, @this as Coding);

                return nzzzzzzzzm_;
            };
            IEnumerable<CqlCode> mzzzzzzzzs_ = context.Operators.Select<object, CqlCode>(mzzzzzzzzq_, mzzzzzzzzr_);
            IEnumerable<CqlCode> mzzzzzzzzt_ = context.Operators.Union<CqlCode>(mzzzzzzzzm_, mzzzzzzzzs_);
            bool? mzzzzzzzzu_(Extension @this)
            {
                string nzzzzzzzzn_ = @this?.Url;
                FhirString nzzzzzzzzo_ = context.Operators.Convert<FhirString>(nzzzzzzzzn_);
                string nzzzzzzzzp_ = FHIRHelpers_4_4_000.Instance.ToString(context, nzzzzzzzzo_);
                bool? nzzzzzzzzq_ = context.Operators.Equal(nzzzzzzzzp_, "text");

                return nzzzzzzzzq_;
            };
            IEnumerable<Extension> mzzzzzzzzv_ = context.Operators.Where<Extension>((IEnumerable<Extension>)(R is Element
                    ? (R as Element).Extension
                    : default), mzzzzzzzzu_);
            DataType mzzzzzzzzw_(Extension @this)
            {
                DataType nzzzzzzzzr_ = @this?.Value;

                return nzzzzzzzzr_;
            };
            IEnumerable<DataType> mzzzzzzzzx_ = context.Operators.Select<Extension, DataType>(mzzzzzzzzv_, mzzzzzzzzw_);
            DataType mzzzzzzzzy_ = context.Operators.SingletonFrom<DataType>(mzzzzzzzzx_);
            string mzzzzzzzzz_ = context.Operators.Convert<string>(mzzzzzzzzy_);
            (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? nzzzzzzzza_ = (CqlTupleMetadata_HPcCiDPXQfZTXIORThMLfTQDR, mzzzzzzzzt_, mzzzzzzzzz_);

            return nzzzzzzzza_;
        };
        IEnumerable<(CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)?> lzzzzzzzzw_ = context.Operators.Select<Extension, (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)?>((IEnumerable<Extension>)lzzzzzzzzu_, lzzzzzzzzv_);
        IEnumerable<(CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)?> lzzzzzzzzx_ = context.Operators.Distinct<(CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)?>(lzzzzzzzzw_);
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? lzzzzzzzzy_ = context.Operators.SingletonFrom<(CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)?>(lzzzzzzzzx_);

        return lzzzzzzzzy_;
    }


    [CqlExpressionDefinition(
        definitionName: "SDE Sex")]
    public CqlCode SDE_Sex(CqlContext context)
    {
        CqlCode nzzzzzzzzs_ = SupplementalDataElements_3_5_000.Instance.SDE_Sex(context);

        return nzzzzzzzzs_;
    }


    [CqlExpressionDefinition(
        definitionName: "Has Active HIV Diagnosis Starts On or Before First 240 Days of Measurement Period")]
    public bool? Has_Active_HIV_Diagnosis_Starts_On_or_Before_First_240_Days_of_Measurement_Period(CqlContext context)
    {
        CqlValueSet nzzzzzzzzt_ = this.HIV(context);
        IEnumerable<Condition> nzzzzzzzzu_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, nzzzzzzzzt_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        bool? nzzzzzzzzv_(Condition HIVDx)
        {
            CqlInterval<CqlDateTime> nzzzzzzzzy_ = QICoreCommon_2_1_000.Instance.prevalenceInterval(context, HIVDx);
            CqlDateTime nzzzzzzzzz_ = context.Operators.Start(nzzzzzzzzy_);
            CqlInterval<CqlDateTime> ozzzzzzzza_ = this.Measurement_Period(context);
            CqlDateTime ozzzzzzzzb_ = context.Operators.Start(ozzzzzzzza_);
            CqlQuantity ozzzzzzzzc_ = context.Operators.Quantity(240m, "days");
            CqlDateTime ozzzzzzzzd_ = context.Operators.Add(ozzzzzzzzb_, ozzzzzzzzc_);
            bool? ozzzzzzzze_ = context.Operators.SameOrBefore(nzzzzzzzzz_, ozzzzzzzzd_, "day");
            bool? ozzzzzzzzf_ = QICoreCommon_2_1_000.Instance.isActive(context, HIVDx);
            bool? ozzzzzzzzg_ = context.Operators.And(ozzzzzzzze_, ozzzzzzzzf_);

            return ozzzzzzzzg_;
        };
        IEnumerable<Condition> nzzzzzzzzw_ = context.Operators.Where<Condition>(nzzzzzzzzu_, nzzzzzzzzv_);
        bool? nzzzzzzzzx_ = context.Operators.Exists<Condition>(nzzzzzzzzw_);

        return nzzzzzzzzx_;
    }


    [CqlExpressionDefinition(
        definitionName: "Has Qualifying Encounter During First 240 Days of Measurement Period")]
    public bool? Has_Qualifying_Encounter_During_First_240_Days_of_Measurement_Period(CqlContext context)
    {
        CqlValueSet ozzzzzzzzh_ = this.Office_Visit(context);
        IEnumerable<Encounter> ozzzzzzzzi_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, ozzzzzzzzh_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        CqlValueSet ozzzzzzzzj_ = this.Outpatient_Consultation(context);
        IEnumerable<Encounter> ozzzzzzzzk_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, ozzzzzzzzj_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> ozzzzzzzzl_ = context.Operators.Union<Encounter>(ozzzzzzzzi_, ozzzzzzzzk_);
        CqlValueSet ozzzzzzzzm_ = this.Annual_Wellness_Visit(context);
        IEnumerable<Encounter> ozzzzzzzzn_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, ozzzzzzzzm_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        CqlValueSet ozzzzzzzzo_ = this.Face_to_Face_Interaction(context);
        IEnumerable<Encounter> ozzzzzzzzp_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, ozzzzzzzzo_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> ozzzzzzzzq_ = context.Operators.Union<Encounter>(ozzzzzzzzn_, ozzzzzzzzp_);
        IEnumerable<Encounter> ozzzzzzzzr_ = context.Operators.Union<Encounter>(ozzzzzzzzl_, ozzzzzzzzq_);
        CqlValueSet ozzzzzzzzs_ = this.Home_Healthcare_Services(context);
        IEnumerable<Encounter> ozzzzzzzzt_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, ozzzzzzzzs_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        CqlValueSet ozzzzzzzzu_ = this.Preventive_Care_Services_Established_Office_Visit__18_and_Up(context);
        IEnumerable<Encounter> ozzzzzzzzv_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, ozzzzzzzzu_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> ozzzzzzzzw_ = context.Operators.Union<Encounter>(ozzzzzzzzt_, ozzzzzzzzv_);
        IEnumerable<Encounter> ozzzzzzzzx_ = context.Operators.Union<Encounter>(ozzzzzzzzr_, ozzzzzzzzw_);
        CqlValueSet ozzzzzzzzy_ = this.Preventive_Care_Services_Initial_Office_Visit__18_and_Up(context);
        IEnumerable<Encounter> ozzzzzzzzz_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, ozzzzzzzzy_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        CqlValueSet pzzzzzzzza_ = this.Preventive_Care_Services__Initial_Office_Visit__0_to_17(context);
        IEnumerable<Encounter> pzzzzzzzzb_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, pzzzzzzzza_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> pzzzzzzzzc_ = context.Operators.Union<Encounter>(ozzzzzzzzz_, pzzzzzzzzb_);
        IEnumerable<Encounter> pzzzzzzzzd_ = context.Operators.Union<Encounter>(ozzzzzzzzx_, pzzzzzzzzc_);
        CqlValueSet pzzzzzzzze_ = this.Preventive_Care__Established_Office_Visit__0_to_17(context);
        IEnumerable<Encounter> pzzzzzzzzf_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, pzzzzzzzze_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        CqlValueSet pzzzzzzzzg_ = this.Telephone_Visits(context);
        IEnumerable<Encounter> pzzzzzzzzh_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, pzzzzzzzzg_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> pzzzzzzzzi_ = context.Operators.Union<Encounter>(pzzzzzzzzf_, pzzzzzzzzh_);
        IEnumerable<Encounter> pzzzzzzzzj_ = context.Operators.Union<Encounter>(pzzzzzzzzd_, pzzzzzzzzi_);
        CqlValueSet pzzzzzzzzk_ = this.Preventive_Care_Services_Other(context);
        IEnumerable<Encounter> pzzzzzzzzl_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, pzzzzzzzzk_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> pzzzzzzzzm_ = context.Operators.Union<Encounter>(pzzzzzzzzj_, pzzzzzzzzl_);
        bool? pzzzzzzzzn_(Encounter QualifyingEncounter)
        {
            CqlInterval<CqlDateTime> pzzzzzzzzq_ = this.Measurement_Period(context);
            CqlDateTime pzzzzzzzzr_ = context.Operators.Start(pzzzzzzzzq_);
            CqlDateTime pzzzzzzzzt_ = context.Operators.Start(pzzzzzzzzq_);
            CqlQuantity pzzzzzzzzu_ = context.Operators.Quantity(240m, "days");
            CqlDateTime pzzzzzzzzv_ = context.Operators.Add(pzzzzzzzzt_, pzzzzzzzzu_);
            CqlInterval<CqlDateTime> pzzzzzzzzw_ = context.Operators.Interval(pzzzzzzzzr_, pzzzzzzzzv_, true, true);
            Period pzzzzzzzzx_ = QualifyingEncounter?.Period;
            CqlInterval<CqlDateTime> pzzzzzzzzy_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, pzzzzzzzzx_);
            bool? pzzzzzzzzz_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(pzzzzzzzzw_, pzzzzzzzzy_, "day");

            return pzzzzzzzzz_;
        };
        IEnumerable<Encounter> pzzzzzzzzo_ = context.Operators.Where<Encounter>(pzzzzzzzzm_, pzzzzzzzzn_);
        bool? pzzzzzzzzp_ = context.Operators.Exists<Encounter>(pzzzzzzzzo_);

        return pzzzzzzzzp_;
    }


    [CqlExpressionDefinition(
        definitionName: "Initial Population")]
    public bool? Initial_Population(CqlContext context)
    {
        bool? qzzzzzzzza_ = this.Has_Active_HIV_Diagnosis_Starts_On_or_Before_First_240_Days_of_Measurement_Period(context);
        bool? qzzzzzzzzb_ = this.Has_Qualifying_Encounter_During_First_240_Days_of_Measurement_Period(context);
        bool? qzzzzzzzzc_ = context.Operators.And(qzzzzzzzza_, qzzzzzzzzb_);

        return qzzzzzzzzc_;
    }


    [CqlExpressionDefinition(
        definitionName: "Denominator")]
    public bool? Denominator(CqlContext context)
    {
        bool? qzzzzzzzzd_ = this.Initial_Population(context);

        return qzzzzzzzzd_;
    }


    [CqlExpressionDefinition(
        definitionName: "Encounter During Measurement Period With HIV")]
    public IEnumerable<Encounter> Encounter_During_Measurement_Period_With_HIV(CqlContext context)
    {
        CqlValueSet qzzzzzzzze_ = this.Office_Visit(context);
        IEnumerable<Encounter> qzzzzzzzzf_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, qzzzzzzzze_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        CqlValueSet qzzzzzzzzg_ = this.Outpatient_Consultation(context);
        IEnumerable<Encounter> qzzzzzzzzh_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, qzzzzzzzzg_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> qzzzzzzzzi_ = context.Operators.Union<Encounter>(qzzzzzzzzf_, qzzzzzzzzh_);
        CqlValueSet qzzzzzzzzj_ = this.Annual_Wellness_Visit(context);
        IEnumerable<Encounter> qzzzzzzzzk_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, qzzzzzzzzj_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        CqlValueSet qzzzzzzzzl_ = this.Face_to_Face_Interaction(context);
        IEnumerable<Encounter> qzzzzzzzzm_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, qzzzzzzzzl_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> qzzzzzzzzn_ = context.Operators.Union<Encounter>(qzzzzzzzzk_, qzzzzzzzzm_);
        IEnumerable<Encounter> qzzzzzzzzo_ = context.Operators.Union<Encounter>(qzzzzzzzzi_, qzzzzzzzzn_);
        CqlValueSet qzzzzzzzzp_ = this.Home_Healthcare_Services(context);
        IEnumerable<Encounter> qzzzzzzzzq_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, qzzzzzzzzp_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        CqlValueSet qzzzzzzzzr_ = this.Preventive_Care_Services_Established_Office_Visit__18_and_Up(context);
        IEnumerable<Encounter> qzzzzzzzzs_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, qzzzzzzzzr_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> qzzzzzzzzt_ = context.Operators.Union<Encounter>(qzzzzzzzzq_, qzzzzzzzzs_);
        IEnumerable<Encounter> qzzzzzzzzu_ = context.Operators.Union<Encounter>(qzzzzzzzzo_, qzzzzzzzzt_);
        CqlValueSet qzzzzzzzzv_ = this.Preventive_Care_Services_Initial_Office_Visit__18_and_Up(context);
        IEnumerable<Encounter> qzzzzzzzzw_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, qzzzzzzzzv_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        CqlValueSet qzzzzzzzzx_ = this.Preventive_Care_Services__Initial_Office_Visit__0_to_17(context);
        IEnumerable<Encounter> qzzzzzzzzy_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, qzzzzzzzzx_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> qzzzzzzzzz_ = context.Operators.Union<Encounter>(qzzzzzzzzw_, qzzzzzzzzy_);
        IEnumerable<Encounter> rzzzzzzzza_ = context.Operators.Union<Encounter>(qzzzzzzzzu_, qzzzzzzzzz_);
        CqlValueSet rzzzzzzzzb_ = this.Preventive_Care__Established_Office_Visit__0_to_17(context);
        IEnumerable<Encounter> rzzzzzzzzc_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, rzzzzzzzzb_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        CqlValueSet rzzzzzzzzd_ = this.Telephone_Visits(context);
        IEnumerable<Encounter> rzzzzzzzze_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, rzzzzzzzzd_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> rzzzzzzzzf_ = context.Operators.Union<Encounter>(rzzzzzzzzc_, rzzzzzzzze_);
        IEnumerable<Encounter> rzzzzzzzzg_ = context.Operators.Union<Encounter>(rzzzzzzzza_, rzzzzzzzzf_);
        CqlValueSet rzzzzzzzzh_ = this.Preventive_Care_Services_Other(context);
        IEnumerable<Encounter> rzzzzzzzzi_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, rzzzzzzzzh_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> rzzzzzzzzj_ = context.Operators.Union<Encounter>(rzzzzzzzzg_, rzzzzzzzzi_);
        IEnumerable<Encounter> rzzzzzzzzk_(Encounter ValidEncounter)
        {
            CqlValueSet rzzzzzzzzm_ = this.HIV(context);
            IEnumerable<Condition> rzzzzzzzzn_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, rzzzzzzzzm_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
            bool? rzzzzzzzzo_(Condition HIVDiagnosis)
            {
                CqlInterval<CqlDateTime> rzzzzzzzzs_ = this.Measurement_Period(context);
                Period rzzzzzzzzt_ = ValidEncounter?.Period;
                CqlInterval<CqlDateTime> rzzzzzzzzu_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, rzzzzzzzzt_);
                bool? rzzzzzzzzv_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(rzzzzzzzzs_, rzzzzzzzzu_, "day");
                CqlInterval<CqlDateTime> rzzzzzzzzw_()
                {
                    bool szzzzzzzzd_()
                    {
                        CqlInterval<CqlDateTime> szzzzzzzze_ = QICoreCommon_2_1_000.Instance.prevalenceInterval(context, HIVDiagnosis);
                        CqlDateTime szzzzzzzzf_ = context.Operators.Start(szzzzzzzze_);

                        return szzzzzzzzf_ is null;
                    };
                    if (szzzzzzzzd_())
                    {
                        return default;
                    }
                    else
                    {
                        CqlInterval<CqlDateTime> szzzzzzzzg_ = QICoreCommon_2_1_000.Instance.prevalenceInterval(context, HIVDiagnosis);
                        CqlDateTime szzzzzzzzh_ = context.Operators.Start(szzzzzzzzg_);
                        CqlDateTime szzzzzzzzj_ = context.Operators.Start(szzzzzzzzg_);
                        CqlInterval<CqlDateTime> szzzzzzzzk_ = context.Operators.Interval(szzzzzzzzh_, szzzzzzzzj_, true, true);

                        return szzzzzzzzk_;
                    }
                };
                CqlInterval<CqlDateTime> rzzzzzzzzy_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, rzzzzzzzzt_);
                bool? rzzzzzzzzz_ = context.Operators.SameOrBefore(rzzzzzzzzw_(), rzzzzzzzzy_, "day");
                bool? szzzzzzzza_ = context.Operators.And(rzzzzzzzzv_, rzzzzzzzzz_);
                bool? szzzzzzzzb_ = QICoreCommon_2_1_000.Instance.isActive(context, HIVDiagnosis);
                bool? szzzzzzzzc_ = context.Operators.And(szzzzzzzza_, szzzzzzzzb_);

                return szzzzzzzzc_;
            };
            IEnumerable<Condition> rzzzzzzzzp_ = context.Operators.Where<Condition>(rzzzzzzzzn_, rzzzzzzzzo_);
            Encounter rzzzzzzzzq_(Condition HIVDiagnosis) =>
                ValidEncounter;
            IEnumerable<Encounter> rzzzzzzzzr_ = context.Operators.Select<Condition, Encounter>(rzzzzzzzzp_, rzzzzzzzzq_);

            return rzzzzzzzzr_;
        };
        IEnumerable<Encounter> rzzzzzzzzl_ = context.Operators.SelectMany<Encounter, Encounter>(rzzzzzzzzj_, rzzzzzzzzk_);

        return rzzzzzzzzl_;
    }


    [CqlExpressionDefinition(
        definitionName: "Has One Encounter With HIV and One Viral Load Test At Least 90 Days Apart")]
    public bool? Has_One_Encounter_With_HIV_and_One_Viral_Load_Test_At_Least_90_Days_Apart(CqlContext context)
    {
        IEnumerable<Encounter> szzzzzzzzl_ = this.Encounter_During_Measurement_Period_With_HIV(context);
        IEnumerable<Encounter> szzzzzzzzm_(Encounter EncounterWithHIV)
        {
            CqlValueSet szzzzzzzzp_ = this.HIV_Viral_Load(context);
            IEnumerable<Observation> szzzzzzzzq_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, szzzzzzzzp_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
            bool? szzzzzzzzr_(Observation ViralLoadTest)
            {
                CqlInterval<CqlDateTime> szzzzzzzzv_ = this.Measurement_Period(context);
                DataType szzzzzzzzw_ = ViralLoadTest?.Effective;
                object szzzzzzzzx_ = FHIRHelpers_4_4_000.Instance.ToValue(context, szzzzzzzzw_);
                CqlInterval<CqlDateTime> szzzzzzzzy_ = QICoreCommon_2_1_000.Instance.toInterval(context, szzzzzzzzx_);
                bool? szzzzzzzzz_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(szzzzzzzzv_, szzzzzzzzy_, "day");
                object tzzzzzzzzb_ = FHIRHelpers_4_4_000.Instance.ToValue(context, szzzzzzzzw_);
                CqlInterval<CqlDateTime> tzzzzzzzzc_ = QICoreCommon_2_1_000.Instance.toInterval(context, tzzzzzzzzb_);
                CqlDateTime tzzzzzzzzd_ = context.Operators.Start(tzzzzzzzzc_);
                Period tzzzzzzzze_ = EncounterWithHIV?.Period;
                CqlInterval<CqlDateTime> tzzzzzzzzf_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, tzzzzzzzze_);
                CqlDateTime tzzzzzzzzg_ = context.Operators.End(tzzzzzzzzf_);
                CqlQuantity tzzzzzzzzh_ = context.Operators.Quantity(90m, "days");
                CqlDateTime tzzzzzzzzi_ = context.Operators.Add(tzzzzzzzzg_, tzzzzzzzzh_);
                bool? tzzzzzzzzj_ = context.Operators.SameOrAfter(tzzzzzzzzd_, tzzzzzzzzi_, "day");
                CqlInterval<CqlDateTime> tzzzzzzzzl_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, tzzzzzzzze_);
                CqlDateTime tzzzzzzzzm_ = context.Operators.Start(tzzzzzzzzl_);
                object tzzzzzzzzo_ = FHIRHelpers_4_4_000.Instance.ToValue(context, szzzzzzzzw_);
                CqlInterval<CqlDateTime> tzzzzzzzzp_ = QICoreCommon_2_1_000.Instance.toInterval(context, tzzzzzzzzo_);
                CqlDateTime tzzzzzzzzq_ = context.Operators.End(tzzzzzzzzp_);
                CqlDateTime tzzzzzzzzs_ = context.Operators.Add(tzzzzzzzzq_, tzzzzzzzzh_);
                bool? tzzzzzzzzt_ = context.Operators.SameOrAfter(tzzzzzzzzm_, tzzzzzzzzs_, "day");
                bool? tzzzzzzzzu_ = context.Operators.Or(tzzzzzzzzj_, tzzzzzzzzt_);
                bool? tzzzzzzzzv_ = context.Operators.And(szzzzzzzzz_, tzzzzzzzzu_);

                return tzzzzzzzzv_;
            };
            IEnumerable<Observation> szzzzzzzzs_ = context.Operators.Where<Observation>(szzzzzzzzq_, szzzzzzzzr_);
            Encounter szzzzzzzzt_(Observation ViralLoadTest) =>
                EncounterWithHIV;
            IEnumerable<Encounter> szzzzzzzzu_ = context.Operators.Select<Observation, Encounter>(szzzzzzzzs_, szzzzzzzzt_);

            return szzzzzzzzu_;
        };
        IEnumerable<Encounter> szzzzzzzzn_ = context.Operators.SelectMany<Encounter, Encounter>(szzzzzzzzl_, szzzzzzzzm_);
        bool? szzzzzzzzo_ = context.Operators.Exists<Encounter>(szzzzzzzzn_);

        return szzzzzzzzo_;
    }


    [CqlExpressionDefinition(
        definitionName: "Has Two Encounters With HIV At Least 90 Days Apart")]
    public bool? Has_Two_Encounters_With_HIV_At_Least_90_Days_Apart(CqlContext context)
    {
        IEnumerable<Encounter> tzzzzzzzzw_ = this.Encounter_During_Measurement_Period_With_HIV(context);
        IEnumerable<Encounter> tzzzzzzzzx_(Encounter EncounterWithHIV)
        {
            IEnumerable<Encounter> uzzzzzzzza_ = this.Encounter_During_Measurement_Period_With_HIV(context);
            bool? uzzzzzzzzb_(Encounter AnotherEncounterWithHIV)
            {
                bool? uzzzzzzzzf_ = context.Operators.Equivalent(EncounterWithHIV, AnotherEncounterWithHIV);
                bool? uzzzzzzzzg_ = context.Operators.Not(uzzzzzzzzf_);
                Period uzzzzzzzzh_ = AnotherEncounterWithHIV?.Period;
                CqlInterval<CqlDateTime> uzzzzzzzzi_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, uzzzzzzzzh_);
                CqlDateTime uzzzzzzzzj_ = context.Operators.Start(uzzzzzzzzi_);
                Period uzzzzzzzzk_ = EncounterWithHIV?.Period;
                CqlInterval<CqlDateTime> uzzzzzzzzl_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, uzzzzzzzzk_);
                CqlDateTime uzzzzzzzzm_ = context.Operators.End(uzzzzzzzzl_);
                CqlQuantity uzzzzzzzzn_ = context.Operators.Quantity(90m, "days");
                CqlDateTime uzzzzzzzzo_ = context.Operators.Add(uzzzzzzzzm_, uzzzzzzzzn_);
                bool? uzzzzzzzzp_ = context.Operators.SameOrAfter(uzzzzzzzzj_, uzzzzzzzzo_, "day");
                bool? uzzzzzzzzq_ = context.Operators.And(uzzzzzzzzg_, uzzzzzzzzp_);

                return uzzzzzzzzq_;
            };
            IEnumerable<Encounter> uzzzzzzzzc_ = context.Operators.Where<Encounter>(uzzzzzzzza_, uzzzzzzzzb_);
            Encounter uzzzzzzzzd_(Encounter AnotherEncounterWithHIV) =>
                EncounterWithHIV;
            IEnumerable<Encounter> uzzzzzzzze_ = context.Operators.Select<Encounter, Encounter>(uzzzzzzzzc_, uzzzzzzzzd_);

            return uzzzzzzzze_;
        };
        IEnumerable<Encounter> tzzzzzzzzy_ = context.Operators.SelectMany<Encounter, Encounter>(tzzzzzzzzw_, tzzzzzzzzx_);
        bool? tzzzzzzzzz_ = context.Operators.Exists<Encounter>(tzzzzzzzzy_);

        return tzzzzzzzzz_;
    }


    [CqlExpressionDefinition(
        definitionName: "Numerator")]
    public bool? Numerator(CqlContext context)
    {
        bool? uzzzzzzzzr_ = this.Has_One_Encounter_With_HIV_and_One_Viral_Load_Test_At_Least_90_Days_Apart(context);
        bool? uzzzzzzzzs_ = this.Has_Two_Encounters_With_HIV_At_Least_90_Days_Apart(context);
        bool? uzzzzzzzzt_ = context.Operators.Or(uzzzzzzzzr_, uzzzzzzzzs_);

        return uzzzzzzzzt_;
    }


    #endregion Expressions

    #region CqlTupleMetadata Properties

    private static CqlTupleMetadata CqlTupleMetadata_HPcCiDPXQfZTXIORThMLfTQDR = new(
        [typeof(IEnumerable<CqlCode>), typeof(string)],
        ["codes", "display"]);

    #endregion CqlTupleMetadata Properties

}
