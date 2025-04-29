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
        CqlDateTime dzzzzzzzzzzj_ = context.Operators.DateTime(2025, 1, 1, 0, 0, 0, 0, 0.0m);
        CqlDateTime dzzzzzzzzzzk_ = context.Operators.DateTime(2025, 12, 31, 23, 59, 59, 999, 0.0m);
        CqlInterval<CqlDateTime> dzzzzzzzzzzl_ = context.Operators.Interval(dzzzzzzzzzzj_, dzzzzzzzzzzk_, true, true);
        object dzzzzzzzzzzm_ = context.ResolveParameter("HIVRetentionFHIR-0.1.000", "Measurement Period", dzzzzzzzzzzl_);

        return (CqlInterval<CqlDateTime>)dzzzzzzzzzzm_;
    }


    #endregion Parameters

    #region Expressions

    [CqlExpressionDefinition("Patient")]
    public Patient Patient(CqlContext context)
    {
        IEnumerable<Patient> dzzzzzzzzzzn_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-patient"));
        Patient dzzzzzzzzzzo_ = context.Operators.SingletonFrom<Patient>(dzzzzzzzzzzn_);

        return dzzzzzzzzzzo_;
    }


    [CqlExpressionDefinition("SDE Payer")]
    public IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> SDE_Payer(CqlContext context)
    {
        IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> dzzzzzzzzzzp_ = SupplementalDataElements_3_5_000.Instance.SDE_Payer(context);

        return dzzzzzzzzzzp_;
    }


    [CqlExpressionDefinition("SDE Ethnicity")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Ethnicity(CqlContext context)
    {
        List<Extension> dzzzzzzzzzzq_()
        {
            bool dzzzzzzzzzzz_()
            {
                Patient ezzzzzzzzzza_ = this.Patient(context);
                bool ezzzzzzzzzzb_ = ezzzzzzzzzza_ is DomainResource;

                return ezzzzzzzzzzb_;
            };
            if (dzzzzzzzzzzz_())
            {
                Patient ezzzzzzzzzzc_ = this.Patient(context);

                return (ezzzzzzzzzzc_ as DomainResource).Extension;
            }
            else
            {
                return default;
            }
        };
        bool? dzzzzzzzzzzr_(Extension @this)
        {
            string ezzzzzzzzzzd_ = @this?.Url;
            FhirString ezzzzzzzzzze_ = context.Operators.Convert<FhirString>(ezzzzzzzzzzd_);
            string ezzzzzzzzzzf_ = FHIRHelpers_4_4_000.Instance.ToString(context, ezzzzzzzzzze_);
            bool? ezzzzzzzzzzg_ = context.Operators.Equal(ezzzzzzzzzzf_, "http://hl7.org/fhir/us/core/StructureDefinition/us-core-ethnicity");

            return ezzzzzzzzzzg_;
        };
        IEnumerable<Extension> dzzzzzzzzzzs_ = context.Operators.Where<Extension>((IEnumerable<Extension>)(dzzzzzzzzzzq_()), dzzzzzzzzzzr_);
        Extension dzzzzzzzzzzt_ = context.Operators.SingletonFrom<Extension>(dzzzzzzzzzzs_);
        Extension[] dzzzzzzzzzzu_ = [
            dzzzzzzzzzzt_,
        ];
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? dzzzzzzzzzzv_(Extension E)
        {
            bool? ezzzzzzzzzzh_(Extension @this)
            {
                string fzzzzzzzzzzc_ = @this?.Url;
                FhirString fzzzzzzzzzzd_ = context.Operators.Convert<FhirString>(fzzzzzzzzzzc_);
                string fzzzzzzzzzze_ = FHIRHelpers_4_4_000.Instance.ToString(context, fzzzzzzzzzzd_);
                bool? fzzzzzzzzzzf_ = context.Operators.Equal(fzzzzzzzzzze_, "ombCategory");

                return fzzzzzzzzzzf_;
            };
            IEnumerable<Extension> ezzzzzzzzzzi_ = context.Operators.Where<Extension>((IEnumerable<Extension>)(E is Element
                    ? (E as Element).Extension
                    : default), ezzzzzzzzzzh_);
            object ezzzzzzzzzzj_(Extension @this)
            {
                DataType fzzzzzzzzzzg_ = @this?.Value;

                return fzzzzzzzzzzg_;
            };
            IEnumerable<object> ezzzzzzzzzzk_ = context.Operators.Select<Extension, object>(ezzzzzzzzzzi_, ezzzzzzzzzzj_);
            object ezzzzzzzzzzl_ = context.Operators.SingletonFrom<object>(ezzzzzzzzzzk_);
            CqlCode ezzzzzzzzzzm_ = FHIRHelpers_4_4_000.Instance.ToCode(context, ezzzzzzzzzzl_ as Coding);
            CqlCode[] ezzzzzzzzzzn_ = [
                ezzzzzzzzzzm_,
            ];
            bool? ezzzzzzzzzzo_(Extension @this)
            {
                string fzzzzzzzzzzh_ = @this?.Url;
                FhirString fzzzzzzzzzzi_ = context.Operators.Convert<FhirString>(fzzzzzzzzzzh_);
                string fzzzzzzzzzzj_ = FHIRHelpers_4_4_000.Instance.ToString(context, fzzzzzzzzzzi_);
                bool? fzzzzzzzzzzk_ = context.Operators.Equal(fzzzzzzzzzzj_, "detailed");

                return fzzzzzzzzzzk_;
            };
            IEnumerable<Extension> ezzzzzzzzzzp_ = context.Operators.Where<Extension>((IEnumerable<Extension>)(E is Element
                    ? (E as Element).Extension
                    : default), ezzzzzzzzzzo_);
            object ezzzzzzzzzzq_(Extension @this)
            {
                DataType fzzzzzzzzzzl_ = @this?.Value;

                return fzzzzzzzzzzl_;
            };
            IEnumerable<object> ezzzzzzzzzzr_ = context.Operators.Select<Extension, object>(ezzzzzzzzzzp_, ezzzzzzzzzzq_);
            CqlCode ezzzzzzzzzzs_(object @this)
            {
                CqlCode fzzzzzzzzzzm_ = FHIRHelpers_4_4_000.Instance.ToCode(context, @this as Coding);

                return fzzzzzzzzzzm_;
            };
            IEnumerable<CqlCode> ezzzzzzzzzzt_ = context.Operators.Select<object, CqlCode>(ezzzzzzzzzzr_, ezzzzzzzzzzs_);
            IEnumerable<CqlCode> ezzzzzzzzzzu_ = context.Operators.Union<CqlCode>(ezzzzzzzzzzn_ as IEnumerable<CqlCode>, ezzzzzzzzzzt_);
            bool? ezzzzzzzzzzv_(Extension @this)
            {
                string fzzzzzzzzzzn_ = @this?.Url;
                FhirString fzzzzzzzzzzo_ = context.Operators.Convert<FhirString>(fzzzzzzzzzzn_);
                string fzzzzzzzzzzp_ = FHIRHelpers_4_4_000.Instance.ToString(context, fzzzzzzzzzzo_);
                bool? fzzzzzzzzzzq_ = context.Operators.Equal(fzzzzzzzzzzp_, "text");

                return fzzzzzzzzzzq_;
            };
            IEnumerable<Extension> ezzzzzzzzzzw_ = context.Operators.Where<Extension>((IEnumerable<Extension>)(E is Element
                    ? (E as Element).Extension
                    : default), ezzzzzzzzzzv_);
            DataType ezzzzzzzzzzx_(Extension @this)
            {
                DataType fzzzzzzzzzzr_ = @this?.Value;

                return fzzzzzzzzzzr_;
            };
            IEnumerable<DataType> ezzzzzzzzzzy_ = context.Operators.Select<Extension, DataType>(ezzzzzzzzzzw_, ezzzzzzzzzzx_);
            DataType ezzzzzzzzzzz_ = context.Operators.SingletonFrom<DataType>(ezzzzzzzzzzy_);
            string fzzzzzzzzzza_ = context.Operators.Convert<string>(ezzzzzzzzzzz_);
            (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? fzzzzzzzzzzb_ = (CqlTupleMetadata_HPcCiDPXQfZTXIORThMLfTQDR, ezzzzzzzzzzu_, fzzzzzzzzzza_);

            return fzzzzzzzzzzb_;
        };
        IEnumerable<(CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)?> dzzzzzzzzzzw_ = context.Operators.Select<Extension, (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)?>((IEnumerable<Extension>)dzzzzzzzzzzu_, dzzzzzzzzzzv_);
        IEnumerable<(CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)?> dzzzzzzzzzzx_ = context.Operators.Distinct<(CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)?>(dzzzzzzzzzzw_);
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? dzzzzzzzzzzy_ = context.Operators.SingletonFrom<(CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)?>(dzzzzzzzzzzx_);

        return dzzzzzzzzzzy_;
    }


    [CqlExpressionDefinition("SDE Race")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Race(CqlContext context)
    {
        List<Extension> fzzzzzzzzzzs_()
        {
            bool gzzzzzzzzzzb_()
            {
                Patient gzzzzzzzzzzc_ = this.Patient(context);
                bool gzzzzzzzzzzd_ = gzzzzzzzzzzc_ is DomainResource;

                return gzzzzzzzzzzd_;
            };
            if (gzzzzzzzzzzb_())
            {
                Patient gzzzzzzzzzze_ = this.Patient(context);

                return (gzzzzzzzzzze_ as DomainResource).Extension;
            }
            else
            {
                return default;
            }
        };
        bool? fzzzzzzzzzzt_(Extension @this)
        {
            string gzzzzzzzzzzf_ = @this?.Url;
            FhirString gzzzzzzzzzzg_ = context.Operators.Convert<FhirString>(gzzzzzzzzzzf_);
            string gzzzzzzzzzzh_ = FHIRHelpers_4_4_000.Instance.ToString(context, gzzzzzzzzzzg_);
            bool? gzzzzzzzzzzi_ = context.Operators.Equal(gzzzzzzzzzzh_, "http://hl7.org/fhir/us/core/StructureDefinition/us-core-race");

            return gzzzzzzzzzzi_;
        };
        IEnumerable<Extension> fzzzzzzzzzzu_ = context.Operators.Where<Extension>((IEnumerable<Extension>)(fzzzzzzzzzzs_()), fzzzzzzzzzzt_);
        Extension fzzzzzzzzzzv_ = context.Operators.SingletonFrom<Extension>(fzzzzzzzzzzu_);
        Extension[] fzzzzzzzzzzw_ = [
            fzzzzzzzzzzv_,
        ];
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? fzzzzzzzzzzx_(Extension R)
        {
            bool? gzzzzzzzzzzj_(Extension @this)
            {
                string hzzzzzzzzzzd_ = @this?.Url;
                FhirString hzzzzzzzzzze_ = context.Operators.Convert<FhirString>(hzzzzzzzzzzd_);
                string hzzzzzzzzzzf_ = FHIRHelpers_4_4_000.Instance.ToString(context, hzzzzzzzzzze_);
                bool? hzzzzzzzzzzg_ = context.Operators.Equal(hzzzzzzzzzzf_, "ombCategory");

                return hzzzzzzzzzzg_;
            };
            IEnumerable<Extension> gzzzzzzzzzzk_ = context.Operators.Where<Extension>((IEnumerable<Extension>)(R is Element
                    ? (R as Element).Extension
                    : default), gzzzzzzzzzzj_);
            object gzzzzzzzzzzl_(Extension @this)
            {
                DataType hzzzzzzzzzzh_ = @this?.Value;

                return hzzzzzzzzzzh_;
            };
            IEnumerable<object> gzzzzzzzzzzm_ = context.Operators.Select<Extension, object>(gzzzzzzzzzzk_, gzzzzzzzzzzl_);
            CqlCode gzzzzzzzzzzn_(object @this)
            {
                CqlCode hzzzzzzzzzzi_ = FHIRHelpers_4_4_000.Instance.ToCode(context, @this as Coding);

                return hzzzzzzzzzzi_;
            };
            IEnumerable<CqlCode> gzzzzzzzzzzo_ = context.Operators.Select<object, CqlCode>(gzzzzzzzzzzm_, gzzzzzzzzzzn_);
            bool? gzzzzzzzzzzp_(Extension @this)
            {
                string hzzzzzzzzzzj_ = @this?.Url;
                FhirString hzzzzzzzzzzk_ = context.Operators.Convert<FhirString>(hzzzzzzzzzzj_);
                string hzzzzzzzzzzl_ = FHIRHelpers_4_4_000.Instance.ToString(context, hzzzzzzzzzzk_);
                bool? hzzzzzzzzzzm_ = context.Operators.Equal(hzzzzzzzzzzl_, "detailed");

                return hzzzzzzzzzzm_;
            };
            IEnumerable<Extension> gzzzzzzzzzzq_ = context.Operators.Where<Extension>((IEnumerable<Extension>)(R is Element
                    ? (R as Element).Extension
                    : default), gzzzzzzzzzzp_);
            object gzzzzzzzzzzr_(Extension @this)
            {
                DataType hzzzzzzzzzzn_ = @this?.Value;

                return hzzzzzzzzzzn_;
            };
            IEnumerable<object> gzzzzzzzzzzs_ = context.Operators.Select<Extension, object>(gzzzzzzzzzzq_, gzzzzzzzzzzr_);
            CqlCode gzzzzzzzzzzt_(object @this)
            {
                CqlCode hzzzzzzzzzzo_ = FHIRHelpers_4_4_000.Instance.ToCode(context, @this as Coding);

                return hzzzzzzzzzzo_;
            };
            IEnumerable<CqlCode> gzzzzzzzzzzu_ = context.Operators.Select<object, CqlCode>(gzzzzzzzzzzs_, gzzzzzzzzzzt_);
            IEnumerable<CqlCode> gzzzzzzzzzzv_ = context.Operators.Union<CqlCode>(gzzzzzzzzzzo_, gzzzzzzzzzzu_);
            bool? gzzzzzzzzzzw_(Extension @this)
            {
                string hzzzzzzzzzzp_ = @this?.Url;
                FhirString hzzzzzzzzzzq_ = context.Operators.Convert<FhirString>(hzzzzzzzzzzp_);
                string hzzzzzzzzzzr_ = FHIRHelpers_4_4_000.Instance.ToString(context, hzzzzzzzzzzq_);
                bool? hzzzzzzzzzzs_ = context.Operators.Equal(hzzzzzzzzzzr_, "text");

                return hzzzzzzzzzzs_;
            };
            IEnumerable<Extension> gzzzzzzzzzzx_ = context.Operators.Where<Extension>((IEnumerable<Extension>)(R is Element
                    ? (R as Element).Extension
                    : default), gzzzzzzzzzzw_);
            DataType gzzzzzzzzzzy_(Extension @this)
            {
                DataType hzzzzzzzzzzt_ = @this?.Value;

                return hzzzzzzzzzzt_;
            };
            IEnumerable<DataType> gzzzzzzzzzzz_ = context.Operators.Select<Extension, DataType>(gzzzzzzzzzzx_, gzzzzzzzzzzy_);
            DataType hzzzzzzzzzza_ = context.Operators.SingletonFrom<DataType>(gzzzzzzzzzzz_);
            string hzzzzzzzzzzb_ = context.Operators.Convert<string>(hzzzzzzzzzza_);
            (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? hzzzzzzzzzzc_ = (CqlTupleMetadata_HPcCiDPXQfZTXIORThMLfTQDR, gzzzzzzzzzzv_, hzzzzzzzzzzb_);

            return hzzzzzzzzzzc_;
        };
        IEnumerable<(CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)?> fzzzzzzzzzzy_ = context.Operators.Select<Extension, (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)?>((IEnumerable<Extension>)fzzzzzzzzzzw_, fzzzzzzzzzzx_);
        IEnumerable<(CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)?> fzzzzzzzzzzz_ = context.Operators.Distinct<(CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)?>(fzzzzzzzzzzy_);
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? gzzzzzzzzzza_ = context.Operators.SingletonFrom<(CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)?>(fzzzzzzzzzzz_);

        return gzzzzzzzzzza_;
    }


    [CqlExpressionDefinition("SDE Sex")]
    public CqlCode SDE_Sex(CqlContext context)
    {
        CqlCode hzzzzzzzzzzu_ = SupplementalDataElements_3_5_000.Instance.SDE_Sex(context);

        return hzzzzzzzzzzu_;
    }


    [CqlExpressionDefinition("Has Active HIV Diagnosis Starts On or Before First 240 Days of Measurement Period")]
    public bool? Has_Active_HIV_Diagnosis_Starts_On_or_Before_First_240_Days_of_Measurement_Period(CqlContext context)
    {
        CqlValueSet hzzzzzzzzzzv_ = this.HIV(context);
        IEnumerable<Condition> hzzzzzzzzzzw_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, hzzzzzzzzzzv_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        bool? hzzzzzzzzzzx_(Condition HIVDx)
        {
            CqlInterval<CqlDateTime> izzzzzzzzzza_ = QICoreCommon_2_1_000.Instance.prevalenceInterval(context, HIVDx);
            CqlDateTime izzzzzzzzzzb_ = context.Operators.Start(izzzzzzzzzza_);
            CqlInterval<CqlDateTime> izzzzzzzzzzc_ = this.Measurement_Period(context);
            CqlDateTime izzzzzzzzzzd_ = context.Operators.Start(izzzzzzzzzzc_);
            CqlQuantity izzzzzzzzzze_ = context.Operators.Quantity(240m, "days");
            CqlDateTime izzzzzzzzzzf_ = context.Operators.Add(izzzzzzzzzzd_, izzzzzzzzzze_);
            bool? izzzzzzzzzzg_ = context.Operators.SameOrBefore(izzzzzzzzzzb_, izzzzzzzzzzf_, "day");
            bool? izzzzzzzzzzh_ = QICoreCommon_2_1_000.Instance.isActive(context, HIVDx);
            bool? izzzzzzzzzzi_ = context.Operators.And(izzzzzzzzzzg_, izzzzzzzzzzh_);

            return izzzzzzzzzzi_;
        };
        IEnumerable<Condition> hzzzzzzzzzzy_ = context.Operators.Where<Condition>(hzzzzzzzzzzw_, hzzzzzzzzzzx_);
        bool? hzzzzzzzzzzz_ = context.Operators.Exists<Condition>(hzzzzzzzzzzy_);

        return hzzzzzzzzzzz_;
    }


    [CqlExpressionDefinition("Has Qualifying Encounter During First 240 Days of Measurement Period")]
    public bool? Has_Qualifying_Encounter_During_First_240_Days_of_Measurement_Period(CqlContext context)
    {
        CqlValueSet izzzzzzzzzzj_ = this.Office_Visit(context);
        IEnumerable<Encounter> izzzzzzzzzzk_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, izzzzzzzzzzj_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        CqlValueSet izzzzzzzzzzl_ = this.Outpatient_Consultation(context);
        IEnumerable<Encounter> izzzzzzzzzzm_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, izzzzzzzzzzl_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> izzzzzzzzzzn_ = context.Operators.Union<Encounter>(izzzzzzzzzzk_, izzzzzzzzzzm_);
        CqlValueSet izzzzzzzzzzo_ = this.Annual_Wellness_Visit(context);
        IEnumerable<Encounter> izzzzzzzzzzp_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, izzzzzzzzzzo_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        CqlValueSet izzzzzzzzzzq_ = this.Face_to_Face_Interaction(context);
        IEnumerable<Encounter> izzzzzzzzzzr_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, izzzzzzzzzzq_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> izzzzzzzzzzs_ = context.Operators.Union<Encounter>(izzzzzzzzzzp_, izzzzzzzzzzr_);
        IEnumerable<Encounter> izzzzzzzzzzt_ = context.Operators.Union<Encounter>(izzzzzzzzzzn_, izzzzzzzzzzs_);
        CqlValueSet izzzzzzzzzzu_ = this.Home_Healthcare_Services(context);
        IEnumerable<Encounter> izzzzzzzzzzv_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, izzzzzzzzzzu_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        CqlValueSet izzzzzzzzzzw_ = this.Preventive_Care_Services_Established_Office_Visit__18_and_Up(context);
        IEnumerable<Encounter> izzzzzzzzzzx_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, izzzzzzzzzzw_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> izzzzzzzzzzy_ = context.Operators.Union<Encounter>(izzzzzzzzzzv_, izzzzzzzzzzx_);
        IEnumerable<Encounter> izzzzzzzzzzz_ = context.Operators.Union<Encounter>(izzzzzzzzzzt_, izzzzzzzzzzy_);
        CqlValueSet jzzzzzzzzzza_ = this.Preventive_Care_Services_Initial_Office_Visit__18_and_Up(context);
        IEnumerable<Encounter> jzzzzzzzzzzb_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, jzzzzzzzzzza_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        CqlValueSet jzzzzzzzzzzc_ = this.Preventive_Care_Services__Initial_Office_Visit__0_to_17(context);
        IEnumerable<Encounter> jzzzzzzzzzzd_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, jzzzzzzzzzzc_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> jzzzzzzzzzze_ = context.Operators.Union<Encounter>(jzzzzzzzzzzb_, jzzzzzzzzzzd_);
        IEnumerable<Encounter> jzzzzzzzzzzf_ = context.Operators.Union<Encounter>(izzzzzzzzzzz_, jzzzzzzzzzze_);
        CqlValueSet jzzzzzzzzzzg_ = this.Preventive_Care__Established_Office_Visit__0_to_17(context);
        IEnumerable<Encounter> jzzzzzzzzzzh_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, jzzzzzzzzzzg_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        CqlValueSet jzzzzzzzzzzi_ = this.Telephone_Visits(context);
        IEnumerable<Encounter> jzzzzzzzzzzj_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, jzzzzzzzzzzi_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> jzzzzzzzzzzk_ = context.Operators.Union<Encounter>(jzzzzzzzzzzh_, jzzzzzzzzzzj_);
        IEnumerable<Encounter> jzzzzzzzzzzl_ = context.Operators.Union<Encounter>(jzzzzzzzzzzf_, jzzzzzzzzzzk_);
        CqlValueSet jzzzzzzzzzzm_ = this.Preventive_Care_Services_Other(context);
        IEnumerable<Encounter> jzzzzzzzzzzn_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, jzzzzzzzzzzm_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> jzzzzzzzzzzo_ = context.Operators.Union<Encounter>(jzzzzzzzzzzl_, jzzzzzzzzzzn_);
        bool? jzzzzzzzzzzp_(Encounter QualifyingEncounter)
        {
            CqlInterval<CqlDateTime> jzzzzzzzzzzs_ = this.Measurement_Period(context);
            CqlDateTime jzzzzzzzzzzt_ = context.Operators.Start(jzzzzzzzzzzs_);
            CqlDateTime jzzzzzzzzzzv_ = context.Operators.Start(jzzzzzzzzzzs_);
            CqlQuantity jzzzzzzzzzzw_ = context.Operators.Quantity(240m, "days");
            CqlDateTime jzzzzzzzzzzx_ = context.Operators.Add(jzzzzzzzzzzv_, jzzzzzzzzzzw_);
            CqlInterval<CqlDateTime> jzzzzzzzzzzy_ = context.Operators.Interval(jzzzzzzzzzzt_, jzzzzzzzzzzx_, true, true);
            Period jzzzzzzzzzzz_ = QualifyingEncounter?.Period;
            CqlInterval<CqlDateTime> kzzzzzzzzzza_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, jzzzzzzzzzzz_);
            bool? kzzzzzzzzzzb_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(jzzzzzzzzzzy_, kzzzzzzzzzza_, "day");

            return kzzzzzzzzzzb_;
        };
        IEnumerable<Encounter> jzzzzzzzzzzq_ = context.Operators.Where<Encounter>(jzzzzzzzzzzo_, jzzzzzzzzzzp_);
        bool? jzzzzzzzzzzr_ = context.Operators.Exists<Encounter>(jzzzzzzzzzzq_);

        return jzzzzzzzzzzr_;
    }


    [CqlExpressionDefinition("Initial Population")]
    public bool? Initial_Population(CqlContext context)
    {
        bool? kzzzzzzzzzzc_ = this.Has_Active_HIV_Diagnosis_Starts_On_or_Before_First_240_Days_of_Measurement_Period(context);
        bool? kzzzzzzzzzzd_ = this.Has_Qualifying_Encounter_During_First_240_Days_of_Measurement_Period(context);
        bool? kzzzzzzzzzze_ = context.Operators.And(kzzzzzzzzzzc_, kzzzzzzzzzzd_);

        return kzzzzzzzzzze_;
    }


    [CqlExpressionDefinition("Denominator")]
    public bool? Denominator(CqlContext context)
    {
        bool? kzzzzzzzzzzf_ = this.Initial_Population(context);

        return kzzzzzzzzzzf_;
    }


    [CqlExpressionDefinition("Encounter During Measurement Period With HIV")]
    public IEnumerable<Encounter> Encounter_During_Measurement_Period_With_HIV(CqlContext context)
    {
        CqlValueSet kzzzzzzzzzzg_ = this.Office_Visit(context);
        IEnumerable<Encounter> kzzzzzzzzzzh_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, kzzzzzzzzzzg_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        CqlValueSet kzzzzzzzzzzi_ = this.Outpatient_Consultation(context);
        IEnumerable<Encounter> kzzzzzzzzzzj_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, kzzzzzzzzzzi_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> kzzzzzzzzzzk_ = context.Operators.Union<Encounter>(kzzzzzzzzzzh_, kzzzzzzzzzzj_);
        CqlValueSet kzzzzzzzzzzl_ = this.Annual_Wellness_Visit(context);
        IEnumerable<Encounter> kzzzzzzzzzzm_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, kzzzzzzzzzzl_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        CqlValueSet kzzzzzzzzzzn_ = this.Face_to_Face_Interaction(context);
        IEnumerable<Encounter> kzzzzzzzzzzo_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, kzzzzzzzzzzn_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> kzzzzzzzzzzp_ = context.Operators.Union<Encounter>(kzzzzzzzzzzm_, kzzzzzzzzzzo_);
        IEnumerable<Encounter> kzzzzzzzzzzq_ = context.Operators.Union<Encounter>(kzzzzzzzzzzk_, kzzzzzzzzzzp_);
        CqlValueSet kzzzzzzzzzzr_ = this.Home_Healthcare_Services(context);
        IEnumerable<Encounter> kzzzzzzzzzzs_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, kzzzzzzzzzzr_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        CqlValueSet kzzzzzzzzzzt_ = this.Preventive_Care_Services_Established_Office_Visit__18_and_Up(context);
        IEnumerable<Encounter> kzzzzzzzzzzu_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, kzzzzzzzzzzt_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> kzzzzzzzzzzv_ = context.Operators.Union<Encounter>(kzzzzzzzzzzs_, kzzzzzzzzzzu_);
        IEnumerable<Encounter> kzzzzzzzzzzw_ = context.Operators.Union<Encounter>(kzzzzzzzzzzq_, kzzzzzzzzzzv_);
        CqlValueSet kzzzzzzzzzzx_ = this.Preventive_Care_Services_Initial_Office_Visit__18_and_Up(context);
        IEnumerable<Encounter> kzzzzzzzzzzy_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, kzzzzzzzzzzx_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        CqlValueSet kzzzzzzzzzzz_ = this.Preventive_Care_Services__Initial_Office_Visit__0_to_17(context);
        IEnumerable<Encounter> lzzzzzzzzzza_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, kzzzzzzzzzzz_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> lzzzzzzzzzzb_ = context.Operators.Union<Encounter>(kzzzzzzzzzzy_, lzzzzzzzzzza_);
        IEnumerable<Encounter> lzzzzzzzzzzc_ = context.Operators.Union<Encounter>(kzzzzzzzzzzw_, lzzzzzzzzzzb_);
        CqlValueSet lzzzzzzzzzzd_ = this.Preventive_Care__Established_Office_Visit__0_to_17(context);
        IEnumerable<Encounter> lzzzzzzzzzze_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, lzzzzzzzzzzd_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        CqlValueSet lzzzzzzzzzzf_ = this.Telephone_Visits(context);
        IEnumerable<Encounter> lzzzzzzzzzzg_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, lzzzzzzzzzzf_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> lzzzzzzzzzzh_ = context.Operators.Union<Encounter>(lzzzzzzzzzze_, lzzzzzzzzzzg_);
        IEnumerable<Encounter> lzzzzzzzzzzi_ = context.Operators.Union<Encounter>(lzzzzzzzzzzc_, lzzzzzzzzzzh_);
        CqlValueSet lzzzzzzzzzzj_ = this.Preventive_Care_Services_Other(context);
        IEnumerable<Encounter> lzzzzzzzzzzk_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, lzzzzzzzzzzj_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> lzzzzzzzzzzl_ = context.Operators.Union<Encounter>(lzzzzzzzzzzi_, lzzzzzzzzzzk_);
        IEnumerable<Encounter> lzzzzzzzzzzm_(Encounter ValidEncounter)
        {
            CqlValueSet lzzzzzzzzzzo_ = this.HIV(context);
            IEnumerable<Condition> lzzzzzzzzzzp_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, lzzzzzzzzzzo_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
            bool? lzzzzzzzzzzq_(Condition HIVDiagnosis)
            {
                CqlInterval<CqlDateTime> lzzzzzzzzzzu_ = this.Measurement_Period(context);
                Period lzzzzzzzzzzv_ = ValidEncounter?.Period;
                CqlInterval<CqlDateTime> lzzzzzzzzzzw_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, lzzzzzzzzzzv_);
                bool? lzzzzzzzzzzx_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(lzzzzzzzzzzu_, lzzzzzzzzzzw_, "day");
                CqlInterval<CqlDateTime> lzzzzzzzzzzy_()
                {
                    bool mzzzzzzzzzzf_()
                    {
                        CqlInterval<CqlDateTime> mzzzzzzzzzzg_ = QICoreCommon_2_1_000.Instance.prevalenceInterval(context, HIVDiagnosis);
                        CqlDateTime mzzzzzzzzzzh_ = context.Operators.Start(mzzzzzzzzzzg_);

                        return mzzzzzzzzzzh_ is null;
                    };
                    if (mzzzzzzzzzzf_())
                    {
                        return default;
                    }
                    else
                    {
                        CqlInterval<CqlDateTime> mzzzzzzzzzzi_ = QICoreCommon_2_1_000.Instance.prevalenceInterval(context, HIVDiagnosis);
                        CqlDateTime mzzzzzzzzzzj_ = context.Operators.Start(mzzzzzzzzzzi_);
                        CqlDateTime mzzzzzzzzzzl_ = context.Operators.Start(mzzzzzzzzzzi_);
                        CqlInterval<CqlDateTime> mzzzzzzzzzzm_ = context.Operators.Interval(mzzzzzzzzzzj_, mzzzzzzzzzzl_, true, true);

                        return mzzzzzzzzzzm_;
                    }
                };
                CqlInterval<CqlDateTime> mzzzzzzzzzza_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, lzzzzzzzzzzv_);
                bool? mzzzzzzzzzzb_ = context.Operators.SameOrBefore(lzzzzzzzzzzy_(), mzzzzzzzzzza_, "day");
                bool? mzzzzzzzzzzc_ = context.Operators.And(lzzzzzzzzzzx_, mzzzzzzzzzzb_);
                bool? mzzzzzzzzzzd_ = QICoreCommon_2_1_000.Instance.isActive(context, HIVDiagnosis);
                bool? mzzzzzzzzzze_ = context.Operators.And(mzzzzzzzzzzc_, mzzzzzzzzzzd_);

                return mzzzzzzzzzze_;
            };
            IEnumerable<Condition> lzzzzzzzzzzr_ = context.Operators.Where<Condition>(lzzzzzzzzzzp_, lzzzzzzzzzzq_);
            Encounter lzzzzzzzzzzs_(Condition HIVDiagnosis) =>
                ValidEncounter;
            IEnumerable<Encounter> lzzzzzzzzzzt_ = context.Operators.Select<Condition, Encounter>(lzzzzzzzzzzr_, lzzzzzzzzzzs_);

            return lzzzzzzzzzzt_;
        };
        IEnumerable<Encounter> lzzzzzzzzzzn_ = context.Operators.SelectMany<Encounter, Encounter>(lzzzzzzzzzzl_, lzzzzzzzzzzm_);

        return lzzzzzzzzzzn_;
    }


    [CqlExpressionDefinition("Has One Encounter With HIV and One Viral Load Test At Least 90 Days Apart")]
    public bool? Has_One_Encounter_With_HIV_and_One_Viral_Load_Test_At_Least_90_Days_Apart(CqlContext context)
    {
        IEnumerable<Encounter> mzzzzzzzzzzn_ = this.Encounter_During_Measurement_Period_With_HIV(context);
        IEnumerable<Encounter> mzzzzzzzzzzo_(Encounter EncounterWithHIV)
        {
            CqlValueSet mzzzzzzzzzzr_ = this.HIV_Viral_Load(context);
            IEnumerable<Observation> mzzzzzzzzzzs_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, mzzzzzzzzzzr_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
            bool? mzzzzzzzzzzt_(Observation ViralLoadTest)
            {
                CqlInterval<CqlDateTime> mzzzzzzzzzzx_ = this.Measurement_Period(context);
                DataType mzzzzzzzzzzy_ = ViralLoadTest?.Effective;
                object mzzzzzzzzzzz_ = FHIRHelpers_4_4_000.Instance.ToValue(context, mzzzzzzzzzzy_);
                CqlInterval<CqlDateTime> nzzzzzzzzzza_ = QICoreCommon_2_1_000.Instance.toInterval(context, mzzzzzzzzzzz_);
                bool? nzzzzzzzzzzb_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(mzzzzzzzzzzx_, nzzzzzzzzzza_, "day");
                object nzzzzzzzzzzd_ = FHIRHelpers_4_4_000.Instance.ToValue(context, mzzzzzzzzzzy_);
                CqlInterval<CqlDateTime> nzzzzzzzzzze_ = QICoreCommon_2_1_000.Instance.toInterval(context, nzzzzzzzzzzd_);
                CqlDateTime nzzzzzzzzzzf_ = context.Operators.Start(nzzzzzzzzzze_);
                Period nzzzzzzzzzzg_ = EncounterWithHIV?.Period;
                CqlInterval<CqlDateTime> nzzzzzzzzzzh_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, nzzzzzzzzzzg_);
                CqlDateTime nzzzzzzzzzzi_ = context.Operators.End(nzzzzzzzzzzh_);
                CqlQuantity nzzzzzzzzzzj_ = context.Operators.Quantity(90m, "days");
                CqlDateTime nzzzzzzzzzzk_ = context.Operators.Add(nzzzzzzzzzzi_, nzzzzzzzzzzj_);
                bool? nzzzzzzzzzzl_ = context.Operators.SameOrAfter(nzzzzzzzzzzf_, nzzzzzzzzzzk_, "day");
                CqlInterval<CqlDateTime> nzzzzzzzzzzn_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, nzzzzzzzzzzg_);
                CqlDateTime nzzzzzzzzzzo_ = context.Operators.Start(nzzzzzzzzzzn_);
                object nzzzzzzzzzzq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, mzzzzzzzzzzy_);
                CqlInterval<CqlDateTime> nzzzzzzzzzzr_ = QICoreCommon_2_1_000.Instance.toInterval(context, nzzzzzzzzzzq_);
                CqlDateTime nzzzzzzzzzzs_ = context.Operators.End(nzzzzzzzzzzr_);
                CqlDateTime nzzzzzzzzzzu_ = context.Operators.Add(nzzzzzzzzzzs_, nzzzzzzzzzzj_);
                bool? nzzzzzzzzzzv_ = context.Operators.SameOrAfter(nzzzzzzzzzzo_, nzzzzzzzzzzu_, "day");
                bool? nzzzzzzzzzzw_ = context.Operators.Or(nzzzzzzzzzzl_, nzzzzzzzzzzv_);
                bool? nzzzzzzzzzzx_ = context.Operators.And(nzzzzzzzzzzb_, nzzzzzzzzzzw_);

                return nzzzzzzzzzzx_;
            };
            IEnumerable<Observation> mzzzzzzzzzzu_ = context.Operators.Where<Observation>(mzzzzzzzzzzs_, mzzzzzzzzzzt_);
            Encounter mzzzzzzzzzzv_(Observation ViralLoadTest) =>
                EncounterWithHIV;
            IEnumerable<Encounter> mzzzzzzzzzzw_ = context.Operators.Select<Observation, Encounter>(mzzzzzzzzzzu_, mzzzzzzzzzzv_);

            return mzzzzzzzzzzw_;
        };
        IEnumerable<Encounter> mzzzzzzzzzzp_ = context.Operators.SelectMany<Encounter, Encounter>(mzzzzzzzzzzn_, mzzzzzzzzzzo_);
        bool? mzzzzzzzzzzq_ = context.Operators.Exists<Encounter>(mzzzzzzzzzzp_);

        return mzzzzzzzzzzq_;
    }


    [CqlExpressionDefinition("Has Two Encounters With HIV At Least 90 Days Apart")]
    public bool? Has_Two_Encounters_With_HIV_At_Least_90_Days_Apart(CqlContext context)
    {
        IEnumerable<Encounter> nzzzzzzzzzzy_ = this.Encounter_During_Measurement_Period_With_HIV(context);
        IEnumerable<Encounter> nzzzzzzzzzzz_(Encounter EncounterWithHIV)
        {
            IEnumerable<Encounter> ozzzzzzzzzzc_ = this.Encounter_During_Measurement_Period_With_HIV(context);
            bool? ozzzzzzzzzzd_(Encounter AnotherEncounterWithHIV)
            {
                bool? ozzzzzzzzzzh_ = context.Operators.Equivalent(EncounterWithHIV, AnotherEncounterWithHIV);
                bool? ozzzzzzzzzzi_ = context.Operators.Not(ozzzzzzzzzzh_);
                Period ozzzzzzzzzzj_ = AnotherEncounterWithHIV?.Period;
                CqlInterval<CqlDateTime> ozzzzzzzzzzk_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ozzzzzzzzzzj_);
                CqlDateTime ozzzzzzzzzzl_ = context.Operators.Start(ozzzzzzzzzzk_);
                Period ozzzzzzzzzzm_ = EncounterWithHIV?.Period;
                CqlInterval<CqlDateTime> ozzzzzzzzzzn_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ozzzzzzzzzzm_);
                CqlDateTime ozzzzzzzzzzo_ = context.Operators.End(ozzzzzzzzzzn_);
                CqlQuantity ozzzzzzzzzzp_ = context.Operators.Quantity(90m, "days");
                CqlDateTime ozzzzzzzzzzq_ = context.Operators.Add(ozzzzzzzzzzo_, ozzzzzzzzzzp_);
                bool? ozzzzzzzzzzr_ = context.Operators.SameOrAfter(ozzzzzzzzzzl_, ozzzzzzzzzzq_, "day");
                bool? ozzzzzzzzzzs_ = context.Operators.And(ozzzzzzzzzzi_, ozzzzzzzzzzr_);

                return ozzzzzzzzzzs_;
            };
            IEnumerable<Encounter> ozzzzzzzzzze_ = context.Operators.Where<Encounter>(ozzzzzzzzzzc_, ozzzzzzzzzzd_);
            Encounter ozzzzzzzzzzf_(Encounter AnotherEncounterWithHIV) =>
                EncounterWithHIV;
            IEnumerable<Encounter> ozzzzzzzzzzg_ = context.Operators.Select<Encounter, Encounter>(ozzzzzzzzzze_, ozzzzzzzzzzf_);

            return ozzzzzzzzzzg_;
        };
        IEnumerable<Encounter> ozzzzzzzzzza_ = context.Operators.SelectMany<Encounter, Encounter>(nzzzzzzzzzzy_, nzzzzzzzzzzz_);
        bool? ozzzzzzzzzzb_ = context.Operators.Exists<Encounter>(ozzzzzzzzzza_);

        return ozzzzzzzzzzb_;
    }


    [CqlExpressionDefinition("Numerator")]
    public bool? Numerator(CqlContext context)
    {
        bool? ozzzzzzzzzzt_ = this.Has_One_Encounter_With_HIV_and_One_Viral_Load_Test_At_Least_90_Days_Apart(context);
        bool? ozzzzzzzzzzu_ = this.Has_Two_Encounters_With_HIV_At_Least_90_Days_Apart(context);
        bool? ozzzzzzzzzzv_ = context.Operators.Or(ozzzzzzzzzzt_, ozzzzzzzzzzu_);

        return ozzzzzzzzzzv_;
    }


    #endregion Expressions

    #region CqlTupleMetadata Properties

    private static CqlTupleMetadata CqlTupleMetadata_HPcCiDPXQfZTXIORThMLfTQDR = new(
        [typeof(IEnumerable<CqlCode>), typeof(string)],
        ["codes", "display"]);

    #endregion CqlTupleMetadata Properties

}
