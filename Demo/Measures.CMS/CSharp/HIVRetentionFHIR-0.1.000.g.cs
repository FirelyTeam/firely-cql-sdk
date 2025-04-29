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

    [CqlValueSetDefinition("Annual Wellness Visit", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1240", valueSetVersion: null)]
    public CqlValueSet Annual_Wellness_Visit(CqlContext _) => _Annual_Wellness_Visit;
    private static readonly CqlValueSet _Annual_Wellness_Visit = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1240", null);

    [CqlValueSetDefinition("Face-to-Face Interaction", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1048", valueSetVersion: null)]
    public CqlValueSet Face_to_Face_Interaction(CqlContext _) => _Face_to_Face_Interaction;
    private static readonly CqlValueSet _Face_to_Face_Interaction = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1048", null);

    [CqlValueSetDefinition("HIV", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.120.12.1003", valueSetVersion: null)]
    public CqlValueSet HIV(CqlContext _) => _HIV;
    private static readonly CqlValueSet _HIV = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.120.12.1003", null);

    [CqlValueSetDefinition("HIV Viral Load", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.120.12.1002", valueSetVersion: null)]
    public CqlValueSet HIV_Viral_Load(CqlContext _) => _HIV_Viral_Load;
    private static readonly CqlValueSet _HIV_Viral_Load = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.120.12.1002", null);

    [CqlValueSetDefinition("Home Healthcare Services", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1016", valueSetVersion: null)]
    public CqlValueSet Home_Healthcare_Services(CqlContext _) => _Home_Healthcare_Services;
    private static readonly CqlValueSet _Home_Healthcare_Services = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1016", null);

    [CqlValueSetDefinition("Office Visit", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1001", valueSetVersion: null)]
    public CqlValueSet Office_Visit(CqlContext _) => _Office_Visit;
    private static readonly CqlValueSet _Office_Visit = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1001", null);

    [CqlValueSetDefinition("Outpatient Consultation", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1008", valueSetVersion: null)]
    public CqlValueSet Outpatient_Consultation(CqlContext _) => _Outpatient_Consultation;
    private static readonly CqlValueSet _Outpatient_Consultation = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1008", null);

    [CqlValueSetDefinition("Preventive Care Services Established Office Visit, 18 and Up", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1025", valueSetVersion: null)]
    public CqlValueSet Preventive_Care_Services_Established_Office_Visit__18_and_Up(CqlContext _) => _Preventive_Care_Services_Established_Office_Visit__18_and_Up;
    private static readonly CqlValueSet _Preventive_Care_Services_Established_Office_Visit__18_and_Up = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1025", null);

    [CqlValueSetDefinition("Preventive Care Services Initial Office Visit, 18 and Up", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1023", valueSetVersion: null)]
    public CqlValueSet Preventive_Care_Services_Initial_Office_Visit__18_and_Up(CqlContext _) => _Preventive_Care_Services_Initial_Office_Visit__18_and_Up;
    private static readonly CqlValueSet _Preventive_Care_Services_Initial_Office_Visit__18_and_Up = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1023", null);

    [CqlValueSetDefinition("Preventive Care Services, Initial Office Visit, 0 to 17", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1022", valueSetVersion: null)]
    public CqlValueSet Preventive_Care_Services__Initial_Office_Visit__0_to_17(CqlContext _) => _Preventive_Care_Services__Initial_Office_Visit__0_to_17;
    private static readonly CqlValueSet _Preventive_Care_Services__Initial_Office_Visit__0_to_17 = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1022", null);

    [CqlValueSetDefinition("Preventive Care, Established Office Visit, 0 to 17", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1024", valueSetVersion: null)]
    public CqlValueSet Preventive_Care__Established_Office_Visit__0_to_17(CqlContext _) => _Preventive_Care__Established_Office_Visit__0_to_17;
    private static readonly CqlValueSet _Preventive_Care__Established_Office_Visit__0_to_17 = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1024", null);

    [CqlValueSetDefinition("Telephone Visits", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1080", valueSetVersion: null)]
    public CqlValueSet Telephone_Visits(CqlContext _) => _Telephone_Visits;
    private static readonly CqlValueSet _Telephone_Visits = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1080", null);

    [CqlValueSetDefinition("Preventive Care Services Other", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.11.1150", valueSetVersion: null)]
    public CqlValueSet Preventive_Care_Services_Other(CqlContext _) => _Preventive_Care_Services_Other;
    private static readonly CqlValueSet _Preventive_Care_Services_Other = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.11.1150", null);

    #endregion ValueSets

    #region CodeSystems

    [CqlCodeSystemDefinition("CPT")]
    public CqlCodeSystem CPT(CqlContext _) => _CPT;
    private static readonly CqlCodeSystem _CPT = new CqlCodeSystem();

    #endregion CodeSystems

    #region Parameters

    [CqlParameterDefinition("Measurement Period")]
    public CqlInterval<CqlDateTime> Measurement_Period(CqlContext context)
    {
        CqlDateTime fzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.DateTime(2025, 1, 1, 0, 0, 0, 0, 0.0m);
        CqlDateTime fzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.DateTime(2025, 12, 31, 23, 59, 59, 999, 0.0m);
        CqlInterval<CqlDateTime> fzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Interval(fzzzzzzzzzzzzzzzzzzzzzg_, fzzzzzzzzzzzzzzzzzzzzzh_, true, true);
        object fzzzzzzzzzzzzzzzzzzzzzj_ = context.ResolveParameter("HIVRetentionFHIR-0.1.000", "Measurement Period", fzzzzzzzzzzzzzzzzzzzzzi_);

        return (CqlInterval<CqlDateTime>)fzzzzzzzzzzzzzzzzzzzzzj_;
    }


    #endregion Parameters

    #region Expressions

    [CqlExpressionDefinition("Patient")]
    public Patient Patient(CqlContext context)
    {
        IEnumerable<Patient> fzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-patient"));
        Patient fzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.SingletonFrom<Patient>(fzzzzzzzzzzzzzzzzzzzzzk_);

        return fzzzzzzzzzzzzzzzzzzzzzl_;
    }


    [CqlExpressionDefinition("SDE Payer")]
    public IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> SDE_Payer(CqlContext context)
    {
        IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> fzzzzzzzzzzzzzzzzzzzzzm_ = SupplementalDataElements_3_5_000.Instance.SDE_Payer(context);

        return fzzzzzzzzzzzzzzzzzzzzzm_;
    }


    [CqlExpressionDefinition("SDE Ethnicity")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Ethnicity(CqlContext context)
    {
        List<Extension> fzzzzzzzzzzzzzzzzzzzzzn_()
        {
            bool fzzzzzzzzzzzzzzzzzzzzzw_()
            {
                Patient fzzzzzzzzzzzzzzzzzzzzzx_ = this.Patient(context);
                bool fzzzzzzzzzzzzzzzzzzzzzy_ = fzzzzzzzzzzzzzzzzzzzzzx_ is DomainResource;

                return fzzzzzzzzzzzzzzzzzzzzzy_;
            };
            if (fzzzzzzzzzzzzzzzzzzzzzw_())
            {
                Patient fzzzzzzzzzzzzzzzzzzzzzz_ = this.Patient(context);

                return (fzzzzzzzzzzzzzzzzzzzzzz_ as DomainResource).Extension;
            }
            else
            {
                return default;
            }
        };
        bool? fzzzzzzzzzzzzzzzzzzzzzo_(Extension @this)
        {
            string gzzzzzzzzzzzzzzzzzzzzza_ = @this?.Url;
            FhirString gzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Convert<FhirString>(gzzzzzzzzzzzzzzzzzzzzza_);
            string gzzzzzzzzzzzzzzzzzzzzzc_ = FHIRHelpers_4_4_000.Instance.ToString(context, gzzzzzzzzzzzzzzzzzzzzzb_);
            bool? gzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Equal(gzzzzzzzzzzzzzzzzzzzzzc_, "http://hl7.org/fhir/us/core/StructureDefinition/us-core-ethnicity");

            return gzzzzzzzzzzzzzzzzzzzzzd_;
        };
        IEnumerable<Extension> fzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Where<Extension>((IEnumerable<Extension>)(fzzzzzzzzzzzzzzzzzzzzzn_()), fzzzzzzzzzzzzzzzzzzzzzo_);
        Extension fzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.SingletonFrom<Extension>(fzzzzzzzzzzzzzzzzzzzzzp_);
        Extension[] fzzzzzzzzzzzzzzzzzzzzzr_ = [
            fzzzzzzzzzzzzzzzzzzzzzq_,
        ];
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? fzzzzzzzzzzzzzzzzzzzzzs_(Extension E)
        {
            bool? gzzzzzzzzzzzzzzzzzzzzze_(Extension @this)
            {
                string gzzzzzzzzzzzzzzzzzzzzzz_ = @this?.Url;
                FhirString hzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Convert<FhirString>(gzzzzzzzzzzzzzzzzzzzzzz_);
                string hzzzzzzzzzzzzzzzzzzzzzb_ = FHIRHelpers_4_4_000.Instance.ToString(context, hzzzzzzzzzzzzzzzzzzzzza_);
                bool? hzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Equal(hzzzzzzzzzzzzzzzzzzzzzb_, "ombCategory");

                return hzzzzzzzzzzzzzzzzzzzzzc_;
            };
            IEnumerable<Extension> gzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Where<Extension>((IEnumerable<Extension>)(E is Element
                    ? (E as Element).Extension
                    : default), gzzzzzzzzzzzzzzzzzzzzze_);
            object gzzzzzzzzzzzzzzzzzzzzzg_(Extension @this)
            {
                DataType hzzzzzzzzzzzzzzzzzzzzzd_ = @this?.Value;

                return hzzzzzzzzzzzzzzzzzzzzzd_;
            };
            IEnumerable<object> gzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Select<Extension, object>(gzzzzzzzzzzzzzzzzzzzzzf_, gzzzzzzzzzzzzzzzzzzzzzg_);
            object gzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.SingletonFrom<object>(gzzzzzzzzzzzzzzzzzzzzzh_);
            CqlCode gzzzzzzzzzzzzzzzzzzzzzj_ = FHIRHelpers_4_4_000.Instance.ToCode(context, gzzzzzzzzzzzzzzzzzzzzzi_ as Coding);
            CqlCode[] gzzzzzzzzzzzzzzzzzzzzzk_ = [
                gzzzzzzzzzzzzzzzzzzzzzj_,
            ];
            bool? gzzzzzzzzzzzzzzzzzzzzzl_(Extension @this)
            {
                string hzzzzzzzzzzzzzzzzzzzzze_ = @this?.Url;
                FhirString hzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Convert<FhirString>(hzzzzzzzzzzzzzzzzzzzzze_);
                string hzzzzzzzzzzzzzzzzzzzzzg_ = FHIRHelpers_4_4_000.Instance.ToString(context, hzzzzzzzzzzzzzzzzzzzzzf_);
                bool? hzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Equal(hzzzzzzzzzzzzzzzzzzzzzg_, "detailed");

                return hzzzzzzzzzzzzzzzzzzzzzh_;
            };
            IEnumerable<Extension> gzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Where<Extension>((IEnumerable<Extension>)(E is Element
                    ? (E as Element).Extension
                    : default), gzzzzzzzzzzzzzzzzzzzzzl_);
            object gzzzzzzzzzzzzzzzzzzzzzn_(Extension @this)
            {
                DataType hzzzzzzzzzzzzzzzzzzzzzi_ = @this?.Value;

                return hzzzzzzzzzzzzzzzzzzzzzi_;
            };
            IEnumerable<object> gzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Select<Extension, object>(gzzzzzzzzzzzzzzzzzzzzzm_, gzzzzzzzzzzzzzzzzzzzzzn_);
            CqlCode gzzzzzzzzzzzzzzzzzzzzzp_(object @this)
            {
                CqlCode hzzzzzzzzzzzzzzzzzzzzzj_ = FHIRHelpers_4_4_000.Instance.ToCode(context, @this as Coding);

                return hzzzzzzzzzzzzzzzzzzzzzj_;
            };
            IEnumerable<CqlCode> gzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Select<object, CqlCode>(gzzzzzzzzzzzzzzzzzzzzzo_, gzzzzzzzzzzzzzzzzzzzzzp_);
            IEnumerable<CqlCode> gzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Union<CqlCode>(gzzzzzzzzzzzzzzzzzzzzzk_ as IEnumerable<CqlCode>, gzzzzzzzzzzzzzzzzzzzzzq_);
            bool? gzzzzzzzzzzzzzzzzzzzzzs_(Extension @this)
            {
                string hzzzzzzzzzzzzzzzzzzzzzk_ = @this?.Url;
                FhirString hzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Convert<FhirString>(hzzzzzzzzzzzzzzzzzzzzzk_);
                string hzzzzzzzzzzzzzzzzzzzzzm_ = FHIRHelpers_4_4_000.Instance.ToString(context, hzzzzzzzzzzzzzzzzzzzzzl_);
                bool? hzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Equal(hzzzzzzzzzzzzzzzzzzzzzm_, "text");

                return hzzzzzzzzzzzzzzzzzzzzzn_;
            };
            IEnumerable<Extension> gzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Where<Extension>((IEnumerable<Extension>)(E is Element
                    ? (E as Element).Extension
                    : default), gzzzzzzzzzzzzzzzzzzzzzs_);
            DataType gzzzzzzzzzzzzzzzzzzzzzu_(Extension @this)
            {
                DataType hzzzzzzzzzzzzzzzzzzzzzo_ = @this?.Value;

                return hzzzzzzzzzzzzzzzzzzzzzo_;
            };
            IEnumerable<DataType> gzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Select<Extension, DataType>(gzzzzzzzzzzzzzzzzzzzzzt_, gzzzzzzzzzzzzzzzzzzzzzu_);
            DataType gzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.SingletonFrom<DataType>(gzzzzzzzzzzzzzzzzzzzzzv_);
            string gzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Convert<string>(gzzzzzzzzzzzzzzzzzzzzzw_);
            (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? gzzzzzzzzzzzzzzzzzzzzzy_ = (CqlTupleMetadata_HPcCiDPXQfZTXIORThMLfTQDR, gzzzzzzzzzzzzzzzzzzzzzr_, gzzzzzzzzzzzzzzzzzzzzzx_);

            return gzzzzzzzzzzzzzzzzzzzzzy_;
        };
        IEnumerable<(CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)?> fzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Select<Extension, (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)?>((IEnumerable<Extension>)fzzzzzzzzzzzzzzzzzzzzzr_, fzzzzzzzzzzzzzzzzzzzzzs_);
        IEnumerable<(CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)?> fzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Distinct<(CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)?>(fzzzzzzzzzzzzzzzzzzzzzt_);
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? fzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.SingletonFrom<(CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)?>(fzzzzzzzzzzzzzzzzzzzzzu_);

        return fzzzzzzzzzzzzzzzzzzzzzv_;
    }


    [CqlExpressionDefinition("SDE Race")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Race(CqlContext context)
    {
        List<Extension> hzzzzzzzzzzzzzzzzzzzzzp_()
        {
            bool hzzzzzzzzzzzzzzzzzzzzzy_()
            {
                Patient hzzzzzzzzzzzzzzzzzzzzzz_ = this.Patient(context);
                bool izzzzzzzzzzzzzzzzzzzzza_ = hzzzzzzzzzzzzzzzzzzzzzz_ is DomainResource;

                return izzzzzzzzzzzzzzzzzzzzza_;
            };
            if (hzzzzzzzzzzzzzzzzzzzzzy_())
            {
                Patient izzzzzzzzzzzzzzzzzzzzzb_ = this.Patient(context);

                return (izzzzzzzzzzzzzzzzzzzzzb_ as DomainResource).Extension;
            }
            else
            {
                return default;
            }
        };
        bool? hzzzzzzzzzzzzzzzzzzzzzq_(Extension @this)
        {
            string izzzzzzzzzzzzzzzzzzzzzc_ = @this?.Url;
            FhirString izzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Convert<FhirString>(izzzzzzzzzzzzzzzzzzzzzc_);
            string izzzzzzzzzzzzzzzzzzzzze_ = FHIRHelpers_4_4_000.Instance.ToString(context, izzzzzzzzzzzzzzzzzzzzzd_);
            bool? izzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Equal(izzzzzzzzzzzzzzzzzzzzze_, "http://hl7.org/fhir/us/core/StructureDefinition/us-core-race");

            return izzzzzzzzzzzzzzzzzzzzzf_;
        };
        IEnumerable<Extension> hzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Where<Extension>((IEnumerable<Extension>)(hzzzzzzzzzzzzzzzzzzzzzp_()), hzzzzzzzzzzzzzzzzzzzzzq_);
        Extension hzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.SingletonFrom<Extension>(hzzzzzzzzzzzzzzzzzzzzzr_);
        Extension[] hzzzzzzzzzzzzzzzzzzzzzt_ = [
            hzzzzzzzzzzzzzzzzzzzzzs_,
        ];
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? hzzzzzzzzzzzzzzzzzzzzzu_(Extension R)
        {
            bool? izzzzzzzzzzzzzzzzzzzzzg_(Extension @this)
            {
                string jzzzzzzzzzzzzzzzzzzzzza_ = @this?.Url;
                FhirString jzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Convert<FhirString>(jzzzzzzzzzzzzzzzzzzzzza_);
                string jzzzzzzzzzzzzzzzzzzzzzc_ = FHIRHelpers_4_4_000.Instance.ToString(context, jzzzzzzzzzzzzzzzzzzzzzb_);
                bool? jzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Equal(jzzzzzzzzzzzzzzzzzzzzzc_, "ombCategory");

                return jzzzzzzzzzzzzzzzzzzzzzd_;
            };
            IEnumerable<Extension> izzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Where<Extension>((IEnumerable<Extension>)(R is Element
                    ? (R as Element).Extension
                    : default), izzzzzzzzzzzzzzzzzzzzzg_);
            object izzzzzzzzzzzzzzzzzzzzzi_(Extension @this)
            {
                DataType jzzzzzzzzzzzzzzzzzzzzze_ = @this?.Value;

                return jzzzzzzzzzzzzzzzzzzzzze_;
            };
            IEnumerable<object> izzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Select<Extension, object>(izzzzzzzzzzzzzzzzzzzzzh_, izzzzzzzzzzzzzzzzzzzzzi_);
            CqlCode izzzzzzzzzzzzzzzzzzzzzk_(object @this)
            {
                CqlCode jzzzzzzzzzzzzzzzzzzzzzf_ = FHIRHelpers_4_4_000.Instance.ToCode(context, @this as Coding);

                return jzzzzzzzzzzzzzzzzzzzzzf_;
            };
            IEnumerable<CqlCode> izzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Select<object, CqlCode>(izzzzzzzzzzzzzzzzzzzzzj_, izzzzzzzzzzzzzzzzzzzzzk_);
            bool? izzzzzzzzzzzzzzzzzzzzzm_(Extension @this)
            {
                string jzzzzzzzzzzzzzzzzzzzzzg_ = @this?.Url;
                FhirString jzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Convert<FhirString>(jzzzzzzzzzzzzzzzzzzzzzg_);
                string jzzzzzzzzzzzzzzzzzzzzzi_ = FHIRHelpers_4_4_000.Instance.ToString(context, jzzzzzzzzzzzzzzzzzzzzzh_);
                bool? jzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Equal(jzzzzzzzzzzzzzzzzzzzzzi_, "detailed");

                return jzzzzzzzzzzzzzzzzzzzzzj_;
            };
            IEnumerable<Extension> izzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Where<Extension>((IEnumerable<Extension>)(R is Element
                    ? (R as Element).Extension
                    : default), izzzzzzzzzzzzzzzzzzzzzm_);
            object izzzzzzzzzzzzzzzzzzzzzo_(Extension @this)
            {
                DataType jzzzzzzzzzzzzzzzzzzzzzk_ = @this?.Value;

                return jzzzzzzzzzzzzzzzzzzzzzk_;
            };
            IEnumerable<object> izzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Select<Extension, object>(izzzzzzzzzzzzzzzzzzzzzn_, izzzzzzzzzzzzzzzzzzzzzo_);
            CqlCode izzzzzzzzzzzzzzzzzzzzzq_(object @this)
            {
                CqlCode jzzzzzzzzzzzzzzzzzzzzzl_ = FHIRHelpers_4_4_000.Instance.ToCode(context, @this as Coding);

                return jzzzzzzzzzzzzzzzzzzzzzl_;
            };
            IEnumerable<CqlCode> izzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Select<object, CqlCode>(izzzzzzzzzzzzzzzzzzzzzp_, izzzzzzzzzzzzzzzzzzzzzq_);
            IEnumerable<CqlCode> izzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Union<CqlCode>(izzzzzzzzzzzzzzzzzzzzzl_, izzzzzzzzzzzzzzzzzzzzzr_);
            bool? izzzzzzzzzzzzzzzzzzzzzt_(Extension @this)
            {
                string jzzzzzzzzzzzzzzzzzzzzzm_ = @this?.Url;
                FhirString jzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Convert<FhirString>(jzzzzzzzzzzzzzzzzzzzzzm_);
                string jzzzzzzzzzzzzzzzzzzzzzo_ = FHIRHelpers_4_4_000.Instance.ToString(context, jzzzzzzzzzzzzzzzzzzzzzn_);
                bool? jzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Equal(jzzzzzzzzzzzzzzzzzzzzzo_, "text");

                return jzzzzzzzzzzzzzzzzzzzzzp_;
            };
            IEnumerable<Extension> izzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Where<Extension>((IEnumerable<Extension>)(R is Element
                    ? (R as Element).Extension
                    : default), izzzzzzzzzzzzzzzzzzzzzt_);
            DataType izzzzzzzzzzzzzzzzzzzzzv_(Extension @this)
            {
                DataType jzzzzzzzzzzzzzzzzzzzzzq_ = @this?.Value;

                return jzzzzzzzzzzzzzzzzzzzzzq_;
            };
            IEnumerable<DataType> izzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Select<Extension, DataType>(izzzzzzzzzzzzzzzzzzzzzu_, izzzzzzzzzzzzzzzzzzzzzv_);
            DataType izzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.SingletonFrom<DataType>(izzzzzzzzzzzzzzzzzzzzzw_);
            string izzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Convert<string>(izzzzzzzzzzzzzzzzzzzzzx_);
            (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? izzzzzzzzzzzzzzzzzzzzzz_ = (CqlTupleMetadata_HPcCiDPXQfZTXIORThMLfTQDR, izzzzzzzzzzzzzzzzzzzzzs_, izzzzzzzzzzzzzzzzzzzzzy_);

            return izzzzzzzzzzzzzzzzzzzzzz_;
        };
        IEnumerable<(CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)?> hzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Select<Extension, (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)?>((IEnumerable<Extension>)hzzzzzzzzzzzzzzzzzzzzzt_, hzzzzzzzzzzzzzzzzzzzzzu_);
        IEnumerable<(CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)?> hzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Distinct<(CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)?>(hzzzzzzzzzzzzzzzzzzzzzv_);
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? hzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.SingletonFrom<(CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)?>(hzzzzzzzzzzzzzzzzzzzzzw_);

        return hzzzzzzzzzzzzzzzzzzzzzx_;
    }


    [CqlExpressionDefinition("SDE Sex")]
    public CqlCode SDE_Sex(CqlContext context)
    {
        CqlCode jzzzzzzzzzzzzzzzzzzzzzr_ = SupplementalDataElements_3_5_000.Instance.SDE_Sex(context);

        return jzzzzzzzzzzzzzzzzzzzzzr_;
    }


    [CqlExpressionDefinition("Has Active HIV Diagnosis Starts On or Before First 240 Days of Measurement Period")]
    public bool? Has_Active_HIV_Diagnosis_Starts_On_or_Before_First_240_Days_of_Measurement_Period(CqlContext context)
    {
        CqlValueSet jzzzzzzzzzzzzzzzzzzzzzs_ = this.HIV(context);
        IEnumerable<Condition> jzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, jzzzzzzzzzzzzzzzzzzzzzs_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        bool? jzzzzzzzzzzzzzzzzzzzzzu_(Condition HIVDx)
        {
            CqlInterval<CqlDateTime> jzzzzzzzzzzzzzzzzzzzzzx_ = QICoreCommon_2_1_000.Instance.prevalenceInterval(context, HIVDx);
            CqlDateTime jzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Start(jzzzzzzzzzzzzzzzzzzzzzx_);
            CqlInterval<CqlDateTime> jzzzzzzzzzzzzzzzzzzzzzz_ = this.Measurement_Period(context);
            CqlDateTime kzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Start(jzzzzzzzzzzzzzzzzzzzzzz_);
            CqlQuantity kzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Quantity(240m, "days");
            CqlDateTime kzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Add(kzzzzzzzzzzzzzzzzzzzzza_, kzzzzzzzzzzzzzzzzzzzzzb_);
            bool? kzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.SameOrBefore(jzzzzzzzzzzzzzzzzzzzzzy_, kzzzzzzzzzzzzzzzzzzzzzc_, "day");
            bool? kzzzzzzzzzzzzzzzzzzzzze_ = QICoreCommon_2_1_000.Instance.isActive(context, HIVDx);
            bool? kzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.And(kzzzzzzzzzzzzzzzzzzzzzd_, kzzzzzzzzzzzzzzzzzzzzze_);

            return kzzzzzzzzzzzzzzzzzzzzzf_;
        };
        IEnumerable<Condition> jzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Where<Condition>(jzzzzzzzzzzzzzzzzzzzzzt_, jzzzzzzzzzzzzzzzzzzzzzu_);
        bool? jzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Exists<Condition>(jzzzzzzzzzzzzzzzzzzzzzv_);

        return jzzzzzzzzzzzzzzzzzzzzzw_;
    }


    [CqlExpressionDefinition("Has Qualifying Encounter During First 240 Days of Measurement Period")]
    public bool? Has_Qualifying_Encounter_During_First_240_Days_of_Measurement_Period(CqlContext context)
    {
        CqlValueSet kzzzzzzzzzzzzzzzzzzzzzg_ = this.Office_Visit(context);
        IEnumerable<Encounter> kzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, kzzzzzzzzzzzzzzzzzzzzzg_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        CqlValueSet kzzzzzzzzzzzzzzzzzzzzzi_ = this.Outpatient_Consultation(context);
        IEnumerable<Encounter> kzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, kzzzzzzzzzzzzzzzzzzzzzi_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> kzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Union<Encounter>(kzzzzzzzzzzzzzzzzzzzzzh_, kzzzzzzzzzzzzzzzzzzzzzj_);
        CqlValueSet kzzzzzzzzzzzzzzzzzzzzzl_ = this.Annual_Wellness_Visit(context);
        IEnumerable<Encounter> kzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, kzzzzzzzzzzzzzzzzzzzzzl_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        CqlValueSet kzzzzzzzzzzzzzzzzzzzzzn_ = this.Face_to_Face_Interaction(context);
        IEnumerable<Encounter> kzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, kzzzzzzzzzzzzzzzzzzzzzn_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> kzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Union<Encounter>(kzzzzzzzzzzzzzzzzzzzzzm_, kzzzzzzzzzzzzzzzzzzzzzo_);
        IEnumerable<Encounter> kzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Union<Encounter>(kzzzzzzzzzzzzzzzzzzzzzk_, kzzzzzzzzzzzzzzzzzzzzzp_);
        CqlValueSet kzzzzzzzzzzzzzzzzzzzzzr_ = this.Home_Healthcare_Services(context);
        IEnumerable<Encounter> kzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, kzzzzzzzzzzzzzzzzzzzzzr_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        CqlValueSet kzzzzzzzzzzzzzzzzzzzzzt_ = this.Preventive_Care_Services_Established_Office_Visit__18_and_Up(context);
        IEnumerable<Encounter> kzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, kzzzzzzzzzzzzzzzzzzzzzt_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> kzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Union<Encounter>(kzzzzzzzzzzzzzzzzzzzzzs_, kzzzzzzzzzzzzzzzzzzzzzu_);
        IEnumerable<Encounter> kzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Union<Encounter>(kzzzzzzzzzzzzzzzzzzzzzq_, kzzzzzzzzzzzzzzzzzzzzzv_);
        CqlValueSet kzzzzzzzzzzzzzzzzzzzzzx_ = this.Preventive_Care_Services_Initial_Office_Visit__18_and_Up(context);
        IEnumerable<Encounter> kzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, kzzzzzzzzzzzzzzzzzzzzzx_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        CqlValueSet kzzzzzzzzzzzzzzzzzzzzzz_ = this.Preventive_Care_Services__Initial_Office_Visit__0_to_17(context);
        IEnumerable<Encounter> lzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, kzzzzzzzzzzzzzzzzzzzzzz_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> lzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Union<Encounter>(kzzzzzzzzzzzzzzzzzzzzzy_, lzzzzzzzzzzzzzzzzzzzzza_);
        IEnumerable<Encounter> lzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Union<Encounter>(kzzzzzzzzzzzzzzzzzzzzzw_, lzzzzzzzzzzzzzzzzzzzzzb_);
        CqlValueSet lzzzzzzzzzzzzzzzzzzzzzd_ = this.Preventive_Care__Established_Office_Visit__0_to_17(context);
        IEnumerable<Encounter> lzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, lzzzzzzzzzzzzzzzzzzzzzd_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        CqlValueSet lzzzzzzzzzzzzzzzzzzzzzf_ = this.Telephone_Visits(context);
        IEnumerable<Encounter> lzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, lzzzzzzzzzzzzzzzzzzzzzf_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> lzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Union<Encounter>(lzzzzzzzzzzzzzzzzzzzzze_, lzzzzzzzzzzzzzzzzzzzzzg_);
        IEnumerable<Encounter> lzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Union<Encounter>(lzzzzzzzzzzzzzzzzzzzzzc_, lzzzzzzzzzzzzzzzzzzzzzh_);
        CqlValueSet lzzzzzzzzzzzzzzzzzzzzzj_ = this.Preventive_Care_Services_Other(context);
        IEnumerable<Encounter> lzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, lzzzzzzzzzzzzzzzzzzzzzj_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> lzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Union<Encounter>(lzzzzzzzzzzzzzzzzzzzzzi_, lzzzzzzzzzzzzzzzzzzzzzk_);
        bool? lzzzzzzzzzzzzzzzzzzzzzm_(Encounter QualifyingEncounter)
        {
            CqlInterval<CqlDateTime> lzzzzzzzzzzzzzzzzzzzzzp_ = this.Measurement_Period(context);
            CqlDateTime lzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Start(lzzzzzzzzzzzzzzzzzzzzzp_);
            CqlDateTime lzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Start(lzzzzzzzzzzzzzzzzzzzzzp_);
            CqlQuantity lzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Quantity(240m, "days");
            CqlDateTime lzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Add(lzzzzzzzzzzzzzzzzzzzzzs_, lzzzzzzzzzzzzzzzzzzzzzt_);
            CqlInterval<CqlDateTime> lzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Interval(lzzzzzzzzzzzzzzzzzzzzzq_, lzzzzzzzzzzzzzzzzzzzzzu_, true, true);
            Period lzzzzzzzzzzzzzzzzzzzzzw_ = QualifyingEncounter?.Period;
            CqlInterval<CqlDateTime> lzzzzzzzzzzzzzzzzzzzzzx_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, lzzzzzzzzzzzzzzzzzzzzzw_);
            bool? lzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(lzzzzzzzzzzzzzzzzzzzzzv_, lzzzzzzzzzzzzzzzzzzzzzx_, "day");

            return lzzzzzzzzzzzzzzzzzzzzzy_;
        };
        IEnumerable<Encounter> lzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Where<Encounter>(lzzzzzzzzzzzzzzzzzzzzzl_, lzzzzzzzzzzzzzzzzzzzzzm_);
        bool? lzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Exists<Encounter>(lzzzzzzzzzzzzzzzzzzzzzn_);

        return lzzzzzzzzzzzzzzzzzzzzzo_;
    }


    [CqlExpressionDefinition("Initial Population")]
    public bool? Initial_Population(CqlContext context)
    {
        bool? lzzzzzzzzzzzzzzzzzzzzzz_ = this.Has_Active_HIV_Diagnosis_Starts_On_or_Before_First_240_Days_of_Measurement_Period(context);
        bool? mzzzzzzzzzzzzzzzzzzzzza_ = this.Has_Qualifying_Encounter_During_First_240_Days_of_Measurement_Period(context);
        bool? mzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.And(lzzzzzzzzzzzzzzzzzzzzzz_, mzzzzzzzzzzzzzzzzzzzzza_);

        return mzzzzzzzzzzzzzzzzzzzzzb_;
    }


    [CqlExpressionDefinition("Denominator")]
    public bool? Denominator(CqlContext context)
    {
        bool? mzzzzzzzzzzzzzzzzzzzzzc_ = this.Initial_Population(context);

        return mzzzzzzzzzzzzzzzzzzzzzc_;
    }


    [CqlExpressionDefinition("Encounter During Measurement Period With HIV")]
    public IEnumerable<Encounter> Encounter_During_Measurement_Period_With_HIV(CqlContext context)
    {
        CqlValueSet mzzzzzzzzzzzzzzzzzzzzzd_ = this.Office_Visit(context);
        IEnumerable<Encounter> mzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, mzzzzzzzzzzzzzzzzzzzzzd_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        CqlValueSet mzzzzzzzzzzzzzzzzzzzzzf_ = this.Outpatient_Consultation(context);
        IEnumerable<Encounter> mzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, mzzzzzzzzzzzzzzzzzzzzzf_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> mzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Union<Encounter>(mzzzzzzzzzzzzzzzzzzzzze_, mzzzzzzzzzzzzzzzzzzzzzg_);
        CqlValueSet mzzzzzzzzzzzzzzzzzzzzzi_ = this.Annual_Wellness_Visit(context);
        IEnumerable<Encounter> mzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, mzzzzzzzzzzzzzzzzzzzzzi_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        CqlValueSet mzzzzzzzzzzzzzzzzzzzzzk_ = this.Face_to_Face_Interaction(context);
        IEnumerable<Encounter> mzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, mzzzzzzzzzzzzzzzzzzzzzk_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> mzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Union<Encounter>(mzzzzzzzzzzzzzzzzzzzzzj_, mzzzzzzzzzzzzzzzzzzzzzl_);
        IEnumerable<Encounter> mzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Union<Encounter>(mzzzzzzzzzzzzzzzzzzzzzh_, mzzzzzzzzzzzzzzzzzzzzzm_);
        CqlValueSet mzzzzzzzzzzzzzzzzzzzzzo_ = this.Home_Healthcare_Services(context);
        IEnumerable<Encounter> mzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, mzzzzzzzzzzzzzzzzzzzzzo_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        CqlValueSet mzzzzzzzzzzzzzzzzzzzzzq_ = this.Preventive_Care_Services_Established_Office_Visit__18_and_Up(context);
        IEnumerable<Encounter> mzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, mzzzzzzzzzzzzzzzzzzzzzq_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> mzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Union<Encounter>(mzzzzzzzzzzzzzzzzzzzzzp_, mzzzzzzzzzzzzzzzzzzzzzr_);
        IEnumerable<Encounter> mzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Union<Encounter>(mzzzzzzzzzzzzzzzzzzzzzn_, mzzzzzzzzzzzzzzzzzzzzzs_);
        CqlValueSet mzzzzzzzzzzzzzzzzzzzzzu_ = this.Preventive_Care_Services_Initial_Office_Visit__18_and_Up(context);
        IEnumerable<Encounter> mzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, mzzzzzzzzzzzzzzzzzzzzzu_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        CqlValueSet mzzzzzzzzzzzzzzzzzzzzzw_ = this.Preventive_Care_Services__Initial_Office_Visit__0_to_17(context);
        IEnumerable<Encounter> mzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, mzzzzzzzzzzzzzzzzzzzzzw_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> mzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Union<Encounter>(mzzzzzzzzzzzzzzzzzzzzzv_, mzzzzzzzzzzzzzzzzzzzzzx_);
        IEnumerable<Encounter> mzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Union<Encounter>(mzzzzzzzzzzzzzzzzzzzzzt_, mzzzzzzzzzzzzzzzzzzzzzy_);
        CqlValueSet nzzzzzzzzzzzzzzzzzzzzza_ = this.Preventive_Care__Established_Office_Visit__0_to_17(context);
        IEnumerable<Encounter> nzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, nzzzzzzzzzzzzzzzzzzzzza_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        CqlValueSet nzzzzzzzzzzzzzzzzzzzzzc_ = this.Telephone_Visits(context);
        IEnumerable<Encounter> nzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, nzzzzzzzzzzzzzzzzzzzzzc_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> nzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Union<Encounter>(nzzzzzzzzzzzzzzzzzzzzzb_, nzzzzzzzzzzzzzzzzzzzzzd_);
        IEnumerable<Encounter> nzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Union<Encounter>(mzzzzzzzzzzzzzzzzzzzzzz_, nzzzzzzzzzzzzzzzzzzzzze_);
        CqlValueSet nzzzzzzzzzzzzzzzzzzzzzg_ = this.Preventive_Care_Services_Other(context);
        IEnumerable<Encounter> nzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, nzzzzzzzzzzzzzzzzzzzzzg_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> nzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Union<Encounter>(nzzzzzzzzzzzzzzzzzzzzzf_, nzzzzzzzzzzzzzzzzzzzzzh_);
        IEnumerable<Encounter> nzzzzzzzzzzzzzzzzzzzzzj_(Encounter ValidEncounter)
        {
            CqlValueSet nzzzzzzzzzzzzzzzzzzzzzl_ = this.HIV(context);
            IEnumerable<Condition> nzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, nzzzzzzzzzzzzzzzzzzzzzl_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
            bool? nzzzzzzzzzzzzzzzzzzzzzn_(Condition HIVDiagnosis)
            {
                CqlInterval<CqlDateTime> nzzzzzzzzzzzzzzzzzzzzzr_ = this.Measurement_Period(context);
                Period nzzzzzzzzzzzzzzzzzzzzzs_ = ValidEncounter?.Period;
                CqlInterval<CqlDateTime> nzzzzzzzzzzzzzzzzzzzzzt_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, nzzzzzzzzzzzzzzzzzzzzzs_);
                bool? nzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(nzzzzzzzzzzzzzzzzzzzzzr_, nzzzzzzzzzzzzzzzzzzzzzt_, "day");
                CqlInterval<CqlDateTime> nzzzzzzzzzzzzzzzzzzzzzv_()
                {
                    bool ozzzzzzzzzzzzzzzzzzzzzc_()
                    {
                        CqlInterval<CqlDateTime> ozzzzzzzzzzzzzzzzzzzzzd_ = QICoreCommon_2_1_000.Instance.prevalenceInterval(context, HIVDiagnosis);
                        CqlDateTime ozzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Start(ozzzzzzzzzzzzzzzzzzzzzd_);

                        return ozzzzzzzzzzzzzzzzzzzzze_ is null;
                    };
                    if (ozzzzzzzzzzzzzzzzzzzzzc_())
                    {
                        return default;
                    }
                    else
                    {
                        CqlInterval<CqlDateTime> ozzzzzzzzzzzzzzzzzzzzzf_ = QICoreCommon_2_1_000.Instance.prevalenceInterval(context, HIVDiagnosis);
                        CqlDateTime ozzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Start(ozzzzzzzzzzzzzzzzzzzzzf_);
                        CqlDateTime ozzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Start(ozzzzzzzzzzzzzzzzzzzzzf_);
                        CqlInterval<CqlDateTime> ozzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Interval(ozzzzzzzzzzzzzzzzzzzzzg_, ozzzzzzzzzzzzzzzzzzzzzi_, true, true);

                        return ozzzzzzzzzzzzzzzzzzzzzj_;
                    }
                };
                CqlInterval<CqlDateTime> nzzzzzzzzzzzzzzzzzzzzzx_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, nzzzzzzzzzzzzzzzzzzzzzs_);
                bool? nzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.SameOrBefore(nzzzzzzzzzzzzzzzzzzzzzv_(), nzzzzzzzzzzzzzzzzzzzzzx_, "day");
                bool? nzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.And(nzzzzzzzzzzzzzzzzzzzzzu_, nzzzzzzzzzzzzzzzzzzzzzy_);
                bool? ozzzzzzzzzzzzzzzzzzzzza_ = QICoreCommon_2_1_000.Instance.isActive(context, HIVDiagnosis);
                bool? ozzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.And(nzzzzzzzzzzzzzzzzzzzzzz_, ozzzzzzzzzzzzzzzzzzzzza_);

                return ozzzzzzzzzzzzzzzzzzzzzb_;
            };
            IEnumerable<Condition> nzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Where<Condition>(nzzzzzzzzzzzzzzzzzzzzzm_, nzzzzzzzzzzzzzzzzzzzzzn_);
            Encounter nzzzzzzzzzzzzzzzzzzzzzp_(Condition HIVDiagnosis) =>
                ValidEncounter;
            IEnumerable<Encounter> nzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Select<Condition, Encounter>(nzzzzzzzzzzzzzzzzzzzzzo_, nzzzzzzzzzzzzzzzzzzzzzp_);

            return nzzzzzzzzzzzzzzzzzzzzzq_;
        };
        IEnumerable<Encounter> nzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.SelectMany<Encounter, Encounter>(nzzzzzzzzzzzzzzzzzzzzzi_, nzzzzzzzzzzzzzzzzzzzzzj_);

        return nzzzzzzzzzzzzzzzzzzzzzk_;
    }


    [CqlExpressionDefinition("Has One Encounter With HIV and One Viral Load Test At Least 90 Days Apart")]
    public bool? Has_One_Encounter_With_HIV_and_One_Viral_Load_Test_At_Least_90_Days_Apart(CqlContext context)
    {
        IEnumerable<Encounter> ozzzzzzzzzzzzzzzzzzzzzk_ = this.Encounter_During_Measurement_Period_With_HIV(context);
        IEnumerable<Encounter> ozzzzzzzzzzzzzzzzzzzzzl_(Encounter EncounterWithHIV)
        {
            CqlValueSet ozzzzzzzzzzzzzzzzzzzzzo_ = this.HIV_Viral_Load(context);
            IEnumerable<Observation> ozzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, ozzzzzzzzzzzzzzzzzzzzzo_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
            bool? ozzzzzzzzzzzzzzzzzzzzzq_(Observation ViralLoadTest)
            {
                CqlInterval<CqlDateTime> ozzzzzzzzzzzzzzzzzzzzzu_ = this.Measurement_Period(context);
                DataType ozzzzzzzzzzzzzzzzzzzzzv_ = ViralLoadTest?.Effective;
                object ozzzzzzzzzzzzzzzzzzzzzw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ozzzzzzzzzzzzzzzzzzzzzv_);
                CqlInterval<CqlDateTime> ozzzzzzzzzzzzzzzzzzzzzx_ = QICoreCommon_2_1_000.Instance.toInterval(context, ozzzzzzzzzzzzzzzzzzzzzw_);
                bool? ozzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(ozzzzzzzzzzzzzzzzzzzzzu_, ozzzzzzzzzzzzzzzzzzzzzx_, "day");
                object pzzzzzzzzzzzzzzzzzzzzza_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ozzzzzzzzzzzzzzzzzzzzzv_);
                CqlInterval<CqlDateTime> pzzzzzzzzzzzzzzzzzzzzzb_ = QICoreCommon_2_1_000.Instance.toInterval(context, pzzzzzzzzzzzzzzzzzzzzza_);
                CqlDateTime pzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Start(pzzzzzzzzzzzzzzzzzzzzzb_);
                Period pzzzzzzzzzzzzzzzzzzzzzd_ = EncounterWithHIV?.Period;
                CqlInterval<CqlDateTime> pzzzzzzzzzzzzzzzzzzzzze_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, pzzzzzzzzzzzzzzzzzzzzzd_);
                CqlDateTime pzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.End(pzzzzzzzzzzzzzzzzzzzzze_);
                CqlQuantity pzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Quantity(90m, "days");
                CqlDateTime pzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Add(pzzzzzzzzzzzzzzzzzzzzzf_, pzzzzzzzzzzzzzzzzzzzzzg_);
                bool? pzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.SameOrAfter(pzzzzzzzzzzzzzzzzzzzzzc_, pzzzzzzzzzzzzzzzzzzzzzh_, "day");
                CqlInterval<CqlDateTime> pzzzzzzzzzzzzzzzzzzzzzk_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, pzzzzzzzzzzzzzzzzzzzzzd_);
                CqlDateTime pzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Start(pzzzzzzzzzzzzzzzzzzzzzk_);
                object pzzzzzzzzzzzzzzzzzzzzzn_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ozzzzzzzzzzzzzzzzzzzzzv_);
                CqlInterval<CqlDateTime> pzzzzzzzzzzzzzzzzzzzzzo_ = QICoreCommon_2_1_000.Instance.toInterval(context, pzzzzzzzzzzzzzzzzzzzzzn_);
                CqlDateTime pzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.End(pzzzzzzzzzzzzzzzzzzzzzo_);
                CqlDateTime pzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Add(pzzzzzzzzzzzzzzzzzzzzzp_, pzzzzzzzzzzzzzzzzzzzzzg_);
                bool? pzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.SameOrAfter(pzzzzzzzzzzzzzzzzzzzzzl_, pzzzzzzzzzzzzzzzzzzzzzr_, "day");
                bool? pzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Or(pzzzzzzzzzzzzzzzzzzzzzi_, pzzzzzzzzzzzzzzzzzzzzzs_);
                bool? pzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.And(ozzzzzzzzzzzzzzzzzzzzzy_, pzzzzzzzzzzzzzzzzzzzzzt_);

                return pzzzzzzzzzzzzzzzzzzzzzu_;
            };
            IEnumerable<Observation> ozzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Where<Observation>(ozzzzzzzzzzzzzzzzzzzzzp_, ozzzzzzzzzzzzzzzzzzzzzq_);
            Encounter ozzzzzzzzzzzzzzzzzzzzzs_(Observation ViralLoadTest) =>
                EncounterWithHIV;
            IEnumerable<Encounter> ozzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Select<Observation, Encounter>(ozzzzzzzzzzzzzzzzzzzzzr_, ozzzzzzzzzzzzzzzzzzzzzs_);

            return ozzzzzzzzzzzzzzzzzzzzzt_;
        };
        IEnumerable<Encounter> ozzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.SelectMany<Encounter, Encounter>(ozzzzzzzzzzzzzzzzzzzzzk_, ozzzzzzzzzzzzzzzzzzzzzl_);
        bool? ozzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Exists<Encounter>(ozzzzzzzzzzzzzzzzzzzzzm_);

        return ozzzzzzzzzzzzzzzzzzzzzn_;
    }


    [CqlExpressionDefinition("Has Two Encounters With HIV At Least 90 Days Apart")]
    public bool? Has_Two_Encounters_With_HIV_At_Least_90_Days_Apart(CqlContext context)
    {
        IEnumerable<Encounter> pzzzzzzzzzzzzzzzzzzzzzv_ = this.Encounter_During_Measurement_Period_With_HIV(context);
        IEnumerable<Encounter> pzzzzzzzzzzzzzzzzzzzzzw_(Encounter EncounterWithHIV)
        {
            IEnumerable<Encounter> pzzzzzzzzzzzzzzzzzzzzzz_ = this.Encounter_During_Measurement_Period_With_HIV(context);
            bool? qzzzzzzzzzzzzzzzzzzzzza_(Encounter AnotherEncounterWithHIV)
            {
                bool? qzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Equivalent(EncounterWithHIV, AnotherEncounterWithHIV);
                bool? qzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Not(qzzzzzzzzzzzzzzzzzzzzze_);
                Period qzzzzzzzzzzzzzzzzzzzzzg_ = AnotherEncounterWithHIV?.Period;
                CqlInterval<CqlDateTime> qzzzzzzzzzzzzzzzzzzzzzh_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, qzzzzzzzzzzzzzzzzzzzzzg_);
                CqlDateTime qzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Start(qzzzzzzzzzzzzzzzzzzzzzh_);
                Period qzzzzzzzzzzzzzzzzzzzzzj_ = EncounterWithHIV?.Period;
                CqlInterval<CqlDateTime> qzzzzzzzzzzzzzzzzzzzzzk_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, qzzzzzzzzzzzzzzzzzzzzzj_);
                CqlDateTime qzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.End(qzzzzzzzzzzzzzzzzzzzzzk_);
                CqlQuantity qzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Quantity(90m, "days");
                CqlDateTime qzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Add(qzzzzzzzzzzzzzzzzzzzzzl_, qzzzzzzzzzzzzzzzzzzzzzm_);
                bool? qzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.SameOrAfter(qzzzzzzzzzzzzzzzzzzzzzi_, qzzzzzzzzzzzzzzzzzzzzzn_, "day");
                bool? qzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.And(qzzzzzzzzzzzzzzzzzzzzzf_, qzzzzzzzzzzzzzzzzzzzzzo_);

                return qzzzzzzzzzzzzzzzzzzzzzp_;
            };
            IEnumerable<Encounter> qzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Where<Encounter>(pzzzzzzzzzzzzzzzzzzzzzz_, qzzzzzzzzzzzzzzzzzzzzza_);
            Encounter qzzzzzzzzzzzzzzzzzzzzzc_(Encounter AnotherEncounterWithHIV) =>
                EncounterWithHIV;
            IEnumerable<Encounter> qzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Select<Encounter, Encounter>(qzzzzzzzzzzzzzzzzzzzzzb_, qzzzzzzzzzzzzzzzzzzzzzc_);

            return qzzzzzzzzzzzzzzzzzzzzzd_;
        };
        IEnumerable<Encounter> pzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.SelectMany<Encounter, Encounter>(pzzzzzzzzzzzzzzzzzzzzzv_, pzzzzzzzzzzzzzzzzzzzzzw_);
        bool? pzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Exists<Encounter>(pzzzzzzzzzzzzzzzzzzzzzx_);

        return pzzzzzzzzzzzzzzzzzzzzzy_;
    }


    [CqlExpressionDefinition("Numerator")]
    public bool? Numerator(CqlContext context)
    {
        bool? qzzzzzzzzzzzzzzzzzzzzzq_ = this.Has_One_Encounter_With_HIV_and_One_Viral_Load_Test_At_Least_90_Days_Apart(context);
        bool? qzzzzzzzzzzzzzzzzzzzzzr_ = this.Has_Two_Encounters_With_HIV_At_Least_90_Days_Apart(context);
        bool? qzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Or(qzzzzzzzzzzzzzzzzzzzzzq_, qzzzzzzzzzzzzzzzzzzzzzr_);

        return qzzzzzzzzzzzzzzzzzzzzzs_;
    }


    #endregion Expressions

    #region CqlTupleMetadata Properties

    private static CqlTupleMetadata CqlTupleMetadata_HPcCiDPXQfZTXIORThMLfTQDR = new(
        [typeof(IEnumerable<CqlCode>), typeof(string)],
        ["codes", "display"]);

    #endregion CqlTupleMetadata Properties

}
