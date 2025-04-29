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
        CqlDateTime szzzzzzzzzzze_ = context.Operators.DateTime(2025, 1, 1, 0, 0, 0, 0, 0.0m);
        CqlDateTime szzzzzzzzzzzf_ = context.Operators.DateTime(2025, 12, 31, 23, 59, 59, 999, 0.0m);
        CqlInterval<CqlDateTime> szzzzzzzzzzzg_ = context.Operators.Interval(szzzzzzzzzzze_, szzzzzzzzzzzf_, true, true);
        object szzzzzzzzzzzh_ = context.ResolveParameter("HIVRetentionFHIR-0.1.000", "Measurement Period", szzzzzzzzzzzg_);

        return (CqlInterval<CqlDateTime>)szzzzzzzzzzzh_;
    }


    #endregion Parameters

    #region Expressions

    [CqlExpressionDefinition("Patient")]
    public Patient Patient(CqlContext context)
    {
        IEnumerable<Patient> szzzzzzzzzzzi_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-patient"));
        Patient szzzzzzzzzzzj_ = context.Operators.SingletonFrom<Patient>(szzzzzzzzzzzi_);

        return szzzzzzzzzzzj_;
    }


    [CqlExpressionDefinition("SDE Payer")]
    public IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> SDE_Payer(CqlContext context)
    {
        IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> szzzzzzzzzzzk_ = SupplementalDataElements_3_5_000.Instance.SDE_Payer(context);

        return szzzzzzzzzzzk_;
    }


    [CqlExpressionDefinition("SDE Ethnicity")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Ethnicity(CqlContext context)
    {
        List<Extension> szzzzzzzzzzzl_()
        {
            bool szzzzzzzzzzzu_()
            {
                Patient szzzzzzzzzzzv_ = this.Patient(context);
                bool szzzzzzzzzzzw_ = szzzzzzzzzzzv_ is DomainResource;

                return szzzzzzzzzzzw_;
            };
            if (szzzzzzzzzzzu_())
            {
                Patient szzzzzzzzzzzx_ = this.Patient(context);

                return (szzzzzzzzzzzx_ as DomainResource).Extension;
            }
            else
            {
                return default;
            }
        };
        bool? szzzzzzzzzzzm_(Extension @this)
        {
            string szzzzzzzzzzzy_ = @this?.Url;
            FhirString szzzzzzzzzzzz_ = context.Operators.Convert<FhirString>(szzzzzzzzzzzy_);
            string tzzzzzzzzzzza_ = FHIRHelpers_4_4_000.Instance.ToString(context, szzzzzzzzzzzz_);
            bool? tzzzzzzzzzzzb_ = context.Operators.Equal(tzzzzzzzzzzza_, "http://hl7.org/fhir/us/core/StructureDefinition/us-core-ethnicity");

            return tzzzzzzzzzzzb_;
        };
        IEnumerable<Extension> szzzzzzzzzzzn_ = context.Operators.Where<Extension>((IEnumerable<Extension>)(szzzzzzzzzzzl_()), szzzzzzzzzzzm_);
        Extension szzzzzzzzzzzo_ = context.Operators.SingletonFrom<Extension>(szzzzzzzzzzzn_);
        Extension[] szzzzzzzzzzzp_ = [
            szzzzzzzzzzzo_,
        ];
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? szzzzzzzzzzzq_(Extension E)
        {
            bool? tzzzzzzzzzzzc_(Extension @this)
            {
                string tzzzzzzzzzzzx_ = @this?.Url;
                FhirString tzzzzzzzzzzzy_ = context.Operators.Convert<FhirString>(tzzzzzzzzzzzx_);
                string tzzzzzzzzzzzz_ = FHIRHelpers_4_4_000.Instance.ToString(context, tzzzzzzzzzzzy_);
                bool? uzzzzzzzzzzza_ = context.Operators.Equal(tzzzzzzzzzzzz_, "ombCategory");

                return uzzzzzzzzzzza_;
            };
            IEnumerable<Extension> tzzzzzzzzzzzd_ = context.Operators.Where<Extension>((IEnumerable<Extension>)(E is Element
                    ? (E as Element).Extension
                    : default), tzzzzzzzzzzzc_);
            object tzzzzzzzzzzze_(Extension @this)
            {
                DataType uzzzzzzzzzzzb_ = @this?.Value;

                return uzzzzzzzzzzzb_;
            };
            IEnumerable<object> tzzzzzzzzzzzf_ = context.Operators.Select<Extension, object>(tzzzzzzzzzzzd_, tzzzzzzzzzzze_);
            object tzzzzzzzzzzzg_ = context.Operators.SingletonFrom<object>(tzzzzzzzzzzzf_);
            CqlCode tzzzzzzzzzzzh_ = FHIRHelpers_4_4_000.Instance.ToCode(context, tzzzzzzzzzzzg_ as Coding);
            CqlCode[] tzzzzzzzzzzzi_ = [
                tzzzzzzzzzzzh_,
            ];
            bool? tzzzzzzzzzzzj_(Extension @this)
            {
                string uzzzzzzzzzzzc_ = @this?.Url;
                FhirString uzzzzzzzzzzzd_ = context.Operators.Convert<FhirString>(uzzzzzzzzzzzc_);
                string uzzzzzzzzzzze_ = FHIRHelpers_4_4_000.Instance.ToString(context, uzzzzzzzzzzzd_);
                bool? uzzzzzzzzzzzf_ = context.Operators.Equal(uzzzzzzzzzzze_, "detailed");

                return uzzzzzzzzzzzf_;
            };
            IEnumerable<Extension> tzzzzzzzzzzzk_ = context.Operators.Where<Extension>((IEnumerable<Extension>)(E is Element
                    ? (E as Element).Extension
                    : default), tzzzzzzzzzzzj_);
            object tzzzzzzzzzzzl_(Extension @this)
            {
                DataType uzzzzzzzzzzzg_ = @this?.Value;

                return uzzzzzzzzzzzg_;
            };
            IEnumerable<object> tzzzzzzzzzzzm_ = context.Operators.Select<Extension, object>(tzzzzzzzzzzzk_, tzzzzzzzzzzzl_);
            CqlCode tzzzzzzzzzzzn_(object @this)
            {
                CqlCode uzzzzzzzzzzzh_ = FHIRHelpers_4_4_000.Instance.ToCode(context, @this as Coding);

                return uzzzzzzzzzzzh_;
            };
            IEnumerable<CqlCode> tzzzzzzzzzzzo_ = context.Operators.Select<object, CqlCode>(tzzzzzzzzzzzm_, tzzzzzzzzzzzn_);
            IEnumerable<CqlCode> tzzzzzzzzzzzp_ = context.Operators.Union<CqlCode>(tzzzzzzzzzzzi_ as IEnumerable<CqlCode>, tzzzzzzzzzzzo_);
            bool? tzzzzzzzzzzzq_(Extension @this)
            {
                string uzzzzzzzzzzzi_ = @this?.Url;
                FhirString uzzzzzzzzzzzj_ = context.Operators.Convert<FhirString>(uzzzzzzzzzzzi_);
                string uzzzzzzzzzzzk_ = FHIRHelpers_4_4_000.Instance.ToString(context, uzzzzzzzzzzzj_);
                bool? uzzzzzzzzzzzl_ = context.Operators.Equal(uzzzzzzzzzzzk_, "text");

                return uzzzzzzzzzzzl_;
            };
            IEnumerable<Extension> tzzzzzzzzzzzr_ = context.Operators.Where<Extension>((IEnumerable<Extension>)(E is Element
                    ? (E as Element).Extension
                    : default), tzzzzzzzzzzzq_);
            DataType tzzzzzzzzzzzs_(Extension @this)
            {
                DataType uzzzzzzzzzzzm_ = @this?.Value;

                return uzzzzzzzzzzzm_;
            };
            IEnumerable<DataType> tzzzzzzzzzzzt_ = context.Operators.Select<Extension, DataType>(tzzzzzzzzzzzr_, tzzzzzzzzzzzs_);
            DataType tzzzzzzzzzzzu_ = context.Operators.SingletonFrom<DataType>(tzzzzzzzzzzzt_);
            string tzzzzzzzzzzzv_ = context.Operators.Convert<string>(tzzzzzzzzzzzu_);
            (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? tzzzzzzzzzzzw_ = (CqlTupleMetadata_HPcCiDPXQfZTXIORThMLfTQDR, tzzzzzzzzzzzp_, tzzzzzzzzzzzv_);

            return tzzzzzzzzzzzw_;
        };
        IEnumerable<(CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)?> szzzzzzzzzzzr_ = context.Operators.Select<Extension, (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)?>((IEnumerable<Extension>)szzzzzzzzzzzp_, szzzzzzzzzzzq_);
        IEnumerable<(CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)?> szzzzzzzzzzzs_ = context.Operators.Distinct<(CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)?>(szzzzzzzzzzzr_);
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? szzzzzzzzzzzt_ = context.Operators.SingletonFrom<(CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)?>(szzzzzzzzzzzs_);

        return szzzzzzzzzzzt_;
    }


    [CqlExpressionDefinition("SDE Race")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Race(CqlContext context)
    {
        List<Extension> uzzzzzzzzzzzn_()
        {
            bool uzzzzzzzzzzzw_()
            {
                Patient uzzzzzzzzzzzx_ = this.Patient(context);
                bool uzzzzzzzzzzzy_ = uzzzzzzzzzzzx_ is DomainResource;

                return uzzzzzzzzzzzy_;
            };
            if (uzzzzzzzzzzzw_())
            {
                Patient uzzzzzzzzzzzz_ = this.Patient(context);

                return (uzzzzzzzzzzzz_ as DomainResource).Extension;
            }
            else
            {
                return default;
            }
        };
        bool? uzzzzzzzzzzzo_(Extension @this)
        {
            string vzzzzzzzzzzza_ = @this?.Url;
            FhirString vzzzzzzzzzzzb_ = context.Operators.Convert<FhirString>(vzzzzzzzzzzza_);
            string vzzzzzzzzzzzc_ = FHIRHelpers_4_4_000.Instance.ToString(context, vzzzzzzzzzzzb_);
            bool? vzzzzzzzzzzzd_ = context.Operators.Equal(vzzzzzzzzzzzc_, "http://hl7.org/fhir/us/core/StructureDefinition/us-core-race");

            return vzzzzzzzzzzzd_;
        };
        IEnumerable<Extension> uzzzzzzzzzzzp_ = context.Operators.Where<Extension>((IEnumerable<Extension>)(uzzzzzzzzzzzn_()), uzzzzzzzzzzzo_);
        Extension uzzzzzzzzzzzq_ = context.Operators.SingletonFrom<Extension>(uzzzzzzzzzzzp_);
        Extension[] uzzzzzzzzzzzr_ = [
            uzzzzzzzzzzzq_,
        ];
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? uzzzzzzzzzzzs_(Extension R)
        {
            bool? vzzzzzzzzzzze_(Extension @this)
            {
                string vzzzzzzzzzzzy_ = @this?.Url;
                FhirString vzzzzzzzzzzzz_ = context.Operators.Convert<FhirString>(vzzzzzzzzzzzy_);
                string wzzzzzzzzzzza_ = FHIRHelpers_4_4_000.Instance.ToString(context, vzzzzzzzzzzzz_);
                bool? wzzzzzzzzzzzb_ = context.Operators.Equal(wzzzzzzzzzzza_, "ombCategory");

                return wzzzzzzzzzzzb_;
            };
            IEnumerable<Extension> vzzzzzzzzzzzf_ = context.Operators.Where<Extension>((IEnumerable<Extension>)(R is Element
                    ? (R as Element).Extension
                    : default), vzzzzzzzzzzze_);
            object vzzzzzzzzzzzg_(Extension @this)
            {
                DataType wzzzzzzzzzzzc_ = @this?.Value;

                return wzzzzzzzzzzzc_;
            };
            IEnumerable<object> vzzzzzzzzzzzh_ = context.Operators.Select<Extension, object>(vzzzzzzzzzzzf_, vzzzzzzzzzzzg_);
            CqlCode vzzzzzzzzzzzi_(object @this)
            {
                CqlCode wzzzzzzzzzzzd_ = FHIRHelpers_4_4_000.Instance.ToCode(context, @this as Coding);

                return wzzzzzzzzzzzd_;
            };
            IEnumerable<CqlCode> vzzzzzzzzzzzj_ = context.Operators.Select<object, CqlCode>(vzzzzzzzzzzzh_, vzzzzzzzzzzzi_);
            bool? vzzzzzzzzzzzk_(Extension @this)
            {
                string wzzzzzzzzzzze_ = @this?.Url;
                FhirString wzzzzzzzzzzzf_ = context.Operators.Convert<FhirString>(wzzzzzzzzzzze_);
                string wzzzzzzzzzzzg_ = FHIRHelpers_4_4_000.Instance.ToString(context, wzzzzzzzzzzzf_);
                bool? wzzzzzzzzzzzh_ = context.Operators.Equal(wzzzzzzzzzzzg_, "detailed");

                return wzzzzzzzzzzzh_;
            };
            IEnumerable<Extension> vzzzzzzzzzzzl_ = context.Operators.Where<Extension>((IEnumerable<Extension>)(R is Element
                    ? (R as Element).Extension
                    : default), vzzzzzzzzzzzk_);
            object vzzzzzzzzzzzm_(Extension @this)
            {
                DataType wzzzzzzzzzzzi_ = @this?.Value;

                return wzzzzzzzzzzzi_;
            };
            IEnumerable<object> vzzzzzzzzzzzn_ = context.Operators.Select<Extension, object>(vzzzzzzzzzzzl_, vzzzzzzzzzzzm_);
            CqlCode vzzzzzzzzzzzo_(object @this)
            {
                CqlCode wzzzzzzzzzzzj_ = FHIRHelpers_4_4_000.Instance.ToCode(context, @this as Coding);

                return wzzzzzzzzzzzj_;
            };
            IEnumerable<CqlCode> vzzzzzzzzzzzp_ = context.Operators.Select<object, CqlCode>(vzzzzzzzzzzzn_, vzzzzzzzzzzzo_);
            IEnumerable<CqlCode> vzzzzzzzzzzzq_ = context.Operators.Union<CqlCode>(vzzzzzzzzzzzj_, vzzzzzzzzzzzp_);
            bool? vzzzzzzzzzzzr_(Extension @this)
            {
                string wzzzzzzzzzzzk_ = @this?.Url;
                FhirString wzzzzzzzzzzzl_ = context.Operators.Convert<FhirString>(wzzzzzzzzzzzk_);
                string wzzzzzzzzzzzm_ = FHIRHelpers_4_4_000.Instance.ToString(context, wzzzzzzzzzzzl_);
                bool? wzzzzzzzzzzzn_ = context.Operators.Equal(wzzzzzzzzzzzm_, "text");

                return wzzzzzzzzzzzn_;
            };
            IEnumerable<Extension> vzzzzzzzzzzzs_ = context.Operators.Where<Extension>((IEnumerable<Extension>)(R is Element
                    ? (R as Element).Extension
                    : default), vzzzzzzzzzzzr_);
            DataType vzzzzzzzzzzzt_(Extension @this)
            {
                DataType wzzzzzzzzzzzo_ = @this?.Value;

                return wzzzzzzzzzzzo_;
            };
            IEnumerable<DataType> vzzzzzzzzzzzu_ = context.Operators.Select<Extension, DataType>(vzzzzzzzzzzzs_, vzzzzzzzzzzzt_);
            DataType vzzzzzzzzzzzv_ = context.Operators.SingletonFrom<DataType>(vzzzzzzzzzzzu_);
            string vzzzzzzzzzzzw_ = context.Operators.Convert<string>(vzzzzzzzzzzzv_);
            (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? vzzzzzzzzzzzx_ = (CqlTupleMetadata_HPcCiDPXQfZTXIORThMLfTQDR, vzzzzzzzzzzzq_, vzzzzzzzzzzzw_);

            return vzzzzzzzzzzzx_;
        };
        IEnumerable<(CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)?> uzzzzzzzzzzzt_ = context.Operators.Select<Extension, (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)?>((IEnumerable<Extension>)uzzzzzzzzzzzr_, uzzzzzzzzzzzs_);
        IEnumerable<(CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)?> uzzzzzzzzzzzu_ = context.Operators.Distinct<(CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)?>(uzzzzzzzzzzzt_);
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? uzzzzzzzzzzzv_ = context.Operators.SingletonFrom<(CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)?>(uzzzzzzzzzzzu_);

        return uzzzzzzzzzzzv_;
    }


    [CqlExpressionDefinition("SDE Sex")]
    public CqlCode SDE_Sex(CqlContext context)
    {
        CqlCode wzzzzzzzzzzzp_ = SupplementalDataElements_3_5_000.Instance.SDE_Sex(context);

        return wzzzzzzzzzzzp_;
    }


    [CqlExpressionDefinition("Has Active HIV Diagnosis Starts On or Before First 240 Days of Measurement Period")]
    public bool? Has_Active_HIV_Diagnosis_Starts_On_or_Before_First_240_Days_of_Measurement_Period(CqlContext context)
    {
        CqlValueSet wzzzzzzzzzzzq_ = this.HIV(context);
        IEnumerable<Condition> wzzzzzzzzzzzr_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, wzzzzzzzzzzzq_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        bool? wzzzzzzzzzzzs_(Condition HIVDx)
        {
            CqlInterval<CqlDateTime> wzzzzzzzzzzzv_ = QICoreCommon_2_1_000.Instance.prevalenceInterval(context, HIVDx);
            CqlDateTime wzzzzzzzzzzzw_ = context.Operators.Start(wzzzzzzzzzzzv_);
            CqlInterval<CqlDateTime> wzzzzzzzzzzzx_ = this.Measurement_Period(context);
            CqlDateTime wzzzzzzzzzzzy_ = context.Operators.Start(wzzzzzzzzzzzx_);
            CqlQuantity wzzzzzzzzzzzz_ = context.Operators.Quantity(240m, "days");
            CqlDateTime xzzzzzzzzzzza_ = context.Operators.Add(wzzzzzzzzzzzy_, wzzzzzzzzzzzz_);
            bool? xzzzzzzzzzzzb_ = context.Operators.SameOrBefore(wzzzzzzzzzzzw_, xzzzzzzzzzzza_, "day");
            bool? xzzzzzzzzzzzc_ = QICoreCommon_2_1_000.Instance.isActive(context, HIVDx);
            bool? xzzzzzzzzzzzd_ = context.Operators.And(xzzzzzzzzzzzb_, xzzzzzzzzzzzc_);

            return xzzzzzzzzzzzd_;
        };
        IEnumerable<Condition> wzzzzzzzzzzzt_ = context.Operators.Where<Condition>(wzzzzzzzzzzzr_, wzzzzzzzzzzzs_);
        bool? wzzzzzzzzzzzu_ = context.Operators.Exists<Condition>(wzzzzzzzzzzzt_);

        return wzzzzzzzzzzzu_;
    }


    [CqlExpressionDefinition("Has Qualifying Encounter During First 240 Days of Measurement Period")]
    public bool? Has_Qualifying_Encounter_During_First_240_Days_of_Measurement_Period(CqlContext context)
    {
        CqlValueSet xzzzzzzzzzzze_ = this.Office_Visit(context);
        IEnumerable<Encounter> xzzzzzzzzzzzf_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, xzzzzzzzzzzze_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        CqlValueSet xzzzzzzzzzzzg_ = this.Outpatient_Consultation(context);
        IEnumerable<Encounter> xzzzzzzzzzzzh_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, xzzzzzzzzzzzg_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> xzzzzzzzzzzzi_ = context.Operators.Union<Encounter>(xzzzzzzzzzzzf_, xzzzzzzzzzzzh_);
        CqlValueSet xzzzzzzzzzzzj_ = this.Annual_Wellness_Visit(context);
        IEnumerable<Encounter> xzzzzzzzzzzzk_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, xzzzzzzzzzzzj_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        CqlValueSet xzzzzzzzzzzzl_ = this.Face_to_Face_Interaction(context);
        IEnumerable<Encounter> xzzzzzzzzzzzm_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, xzzzzzzzzzzzl_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> xzzzzzzzzzzzn_ = context.Operators.Union<Encounter>(xzzzzzzzzzzzk_, xzzzzzzzzzzzm_);
        IEnumerable<Encounter> xzzzzzzzzzzzo_ = context.Operators.Union<Encounter>(xzzzzzzzzzzzi_, xzzzzzzzzzzzn_);
        CqlValueSet xzzzzzzzzzzzp_ = this.Home_Healthcare_Services(context);
        IEnumerable<Encounter> xzzzzzzzzzzzq_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, xzzzzzzzzzzzp_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        CqlValueSet xzzzzzzzzzzzr_ = this.Preventive_Care_Services_Established_Office_Visit__18_and_Up(context);
        IEnumerable<Encounter> xzzzzzzzzzzzs_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, xzzzzzzzzzzzr_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> xzzzzzzzzzzzt_ = context.Operators.Union<Encounter>(xzzzzzzzzzzzq_, xzzzzzzzzzzzs_);
        IEnumerable<Encounter> xzzzzzzzzzzzu_ = context.Operators.Union<Encounter>(xzzzzzzzzzzzo_, xzzzzzzzzzzzt_);
        CqlValueSet xzzzzzzzzzzzv_ = this.Preventive_Care_Services_Initial_Office_Visit__18_and_Up(context);
        IEnumerable<Encounter> xzzzzzzzzzzzw_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, xzzzzzzzzzzzv_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        CqlValueSet xzzzzzzzzzzzx_ = this.Preventive_Care_Services__Initial_Office_Visit__0_to_17(context);
        IEnumerable<Encounter> xzzzzzzzzzzzy_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, xzzzzzzzzzzzx_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> xzzzzzzzzzzzz_ = context.Operators.Union<Encounter>(xzzzzzzzzzzzw_, xzzzzzzzzzzzy_);
        IEnumerable<Encounter> yzzzzzzzzzzza_ = context.Operators.Union<Encounter>(xzzzzzzzzzzzu_, xzzzzzzzzzzzz_);
        CqlValueSet yzzzzzzzzzzzb_ = this.Preventive_Care__Established_Office_Visit__0_to_17(context);
        IEnumerable<Encounter> yzzzzzzzzzzzc_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, yzzzzzzzzzzzb_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        CqlValueSet yzzzzzzzzzzzd_ = this.Telephone_Visits(context);
        IEnumerable<Encounter> yzzzzzzzzzzze_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, yzzzzzzzzzzzd_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> yzzzzzzzzzzzf_ = context.Operators.Union<Encounter>(yzzzzzzzzzzzc_, yzzzzzzzzzzze_);
        IEnumerable<Encounter> yzzzzzzzzzzzg_ = context.Operators.Union<Encounter>(yzzzzzzzzzzza_, yzzzzzzzzzzzf_);
        CqlValueSet yzzzzzzzzzzzh_ = this.Preventive_Care_Services_Other(context);
        IEnumerable<Encounter> yzzzzzzzzzzzi_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, yzzzzzzzzzzzh_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> yzzzzzzzzzzzj_ = context.Operators.Union<Encounter>(yzzzzzzzzzzzg_, yzzzzzzzzzzzi_);
        bool? yzzzzzzzzzzzk_(Encounter QualifyingEncounter)
        {
            CqlInterval<CqlDateTime> yzzzzzzzzzzzn_ = this.Measurement_Period(context);
            CqlDateTime yzzzzzzzzzzzo_ = context.Operators.Start(yzzzzzzzzzzzn_);
            CqlDateTime yzzzzzzzzzzzq_ = context.Operators.Start(yzzzzzzzzzzzn_);
            CqlQuantity yzzzzzzzzzzzr_ = context.Operators.Quantity(240m, "days");
            CqlDateTime yzzzzzzzzzzzs_ = context.Operators.Add(yzzzzzzzzzzzq_, yzzzzzzzzzzzr_);
            CqlInterval<CqlDateTime> yzzzzzzzzzzzt_ = context.Operators.Interval(yzzzzzzzzzzzo_, yzzzzzzzzzzzs_, true, true);
            Period yzzzzzzzzzzzu_ = QualifyingEncounter?.Period;
            CqlInterval<CqlDateTime> yzzzzzzzzzzzv_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, yzzzzzzzzzzzu_);
            bool? yzzzzzzzzzzzw_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(yzzzzzzzzzzzt_, yzzzzzzzzzzzv_, "day");

            return yzzzzzzzzzzzw_;
        };
        IEnumerable<Encounter> yzzzzzzzzzzzl_ = context.Operators.Where<Encounter>(yzzzzzzzzzzzj_, yzzzzzzzzzzzk_);
        bool? yzzzzzzzzzzzm_ = context.Operators.Exists<Encounter>(yzzzzzzzzzzzl_);

        return yzzzzzzzzzzzm_;
    }


    [CqlExpressionDefinition("Initial Population")]
    public bool? Initial_Population(CqlContext context)
    {
        bool? yzzzzzzzzzzzx_ = this.Has_Active_HIV_Diagnosis_Starts_On_or_Before_First_240_Days_of_Measurement_Period(context);
        bool? yzzzzzzzzzzzy_ = this.Has_Qualifying_Encounter_During_First_240_Days_of_Measurement_Period(context);
        bool? yzzzzzzzzzzzz_ = context.Operators.And(yzzzzzzzzzzzx_, yzzzzzzzzzzzy_);

        return yzzzzzzzzzzzz_;
    }


    [CqlExpressionDefinition("Denominator")]
    public bool? Denominator(CqlContext context)
    {
        bool? zzzzzzzzzzzza_ = this.Initial_Population(context);

        return zzzzzzzzzzzza_;
    }


    [CqlExpressionDefinition("Encounter During Measurement Period With HIV")]
    public IEnumerable<Encounter> Encounter_During_Measurement_Period_With_HIV(CqlContext context)
    {
        CqlValueSet zzzzzzzzzzzzb_ = this.Office_Visit(context);
        IEnumerable<Encounter> zzzzzzzzzzzzc_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, zzzzzzzzzzzzb_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        CqlValueSet zzzzzzzzzzzzd_ = this.Outpatient_Consultation(context);
        IEnumerable<Encounter> zzzzzzzzzzzze_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, zzzzzzzzzzzzd_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> zzzzzzzzzzzzf_ = context.Operators.Union<Encounter>(zzzzzzzzzzzzc_, zzzzzzzzzzzze_);
        CqlValueSet zzzzzzzzzzzzg_ = this.Annual_Wellness_Visit(context);
        IEnumerable<Encounter> zzzzzzzzzzzzh_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, zzzzzzzzzzzzg_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        CqlValueSet zzzzzzzzzzzzi_ = this.Face_to_Face_Interaction(context);
        IEnumerable<Encounter> zzzzzzzzzzzzj_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, zzzzzzzzzzzzi_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> zzzzzzzzzzzzk_ = context.Operators.Union<Encounter>(zzzzzzzzzzzzh_, zzzzzzzzzzzzj_);
        IEnumerable<Encounter> zzzzzzzzzzzzl_ = context.Operators.Union<Encounter>(zzzzzzzzzzzzf_, zzzzzzzzzzzzk_);
        CqlValueSet zzzzzzzzzzzzm_ = this.Home_Healthcare_Services(context);
        IEnumerable<Encounter> zzzzzzzzzzzzn_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, zzzzzzzzzzzzm_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        CqlValueSet zzzzzzzzzzzzo_ = this.Preventive_Care_Services_Established_Office_Visit__18_and_Up(context);
        IEnumerable<Encounter> zzzzzzzzzzzzp_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, zzzzzzzzzzzzo_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> zzzzzzzzzzzzq_ = context.Operators.Union<Encounter>(zzzzzzzzzzzzn_, zzzzzzzzzzzzp_);
        IEnumerable<Encounter> zzzzzzzzzzzzr_ = context.Operators.Union<Encounter>(zzzzzzzzzzzzl_, zzzzzzzzzzzzq_);
        CqlValueSet zzzzzzzzzzzzs_ = this.Preventive_Care_Services_Initial_Office_Visit__18_and_Up(context);
        IEnumerable<Encounter> zzzzzzzzzzzzt_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, zzzzzzzzzzzzs_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        CqlValueSet zzzzzzzzzzzzu_ = this.Preventive_Care_Services__Initial_Office_Visit__0_to_17(context);
        IEnumerable<Encounter> zzzzzzzzzzzzv_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, zzzzzzzzzzzzu_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> zzzzzzzzzzzzw_ = context.Operators.Union<Encounter>(zzzzzzzzzzzzt_, zzzzzzzzzzzzv_);
        IEnumerable<Encounter> zzzzzzzzzzzzx_ = context.Operators.Union<Encounter>(zzzzzzzzzzzzr_, zzzzzzzzzzzzw_);
        CqlValueSet zzzzzzzzzzzzy_ = this.Preventive_Care__Established_Office_Visit__0_to_17(context);
        IEnumerable<Encounter> zzzzzzzzzzzzz_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, zzzzzzzzzzzzy_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        CqlValueSet azzzzzzzzzzzza_ = this.Telephone_Visits(context);
        IEnumerable<Encounter> azzzzzzzzzzzzb_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, azzzzzzzzzzzza_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> azzzzzzzzzzzzc_ = context.Operators.Union<Encounter>(zzzzzzzzzzzzz_, azzzzzzzzzzzzb_);
        IEnumerable<Encounter> azzzzzzzzzzzzd_ = context.Operators.Union<Encounter>(zzzzzzzzzzzzx_, azzzzzzzzzzzzc_);
        CqlValueSet azzzzzzzzzzzze_ = this.Preventive_Care_Services_Other(context);
        IEnumerable<Encounter> azzzzzzzzzzzzf_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, azzzzzzzzzzzze_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> azzzzzzzzzzzzg_ = context.Operators.Union<Encounter>(azzzzzzzzzzzzd_, azzzzzzzzzzzzf_);
        IEnumerable<Encounter> azzzzzzzzzzzzh_(Encounter ValidEncounter)
        {
            CqlValueSet azzzzzzzzzzzzj_ = this.HIV(context);
            IEnumerable<Condition> azzzzzzzzzzzzk_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, azzzzzzzzzzzzj_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
            bool? azzzzzzzzzzzzl_(Condition HIVDiagnosis)
            {
                CqlInterval<CqlDateTime> azzzzzzzzzzzzp_ = this.Measurement_Period(context);
                Period azzzzzzzzzzzzq_ = ValidEncounter?.Period;
                CqlInterval<CqlDateTime> azzzzzzzzzzzzr_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, azzzzzzzzzzzzq_);
                bool? azzzzzzzzzzzzs_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(azzzzzzzzzzzzp_, azzzzzzzzzzzzr_, "day");
                CqlInterval<CqlDateTime> azzzzzzzzzzzzt_()
                {
                    bool bzzzzzzzzzzzza_()
                    {
                        CqlInterval<CqlDateTime> bzzzzzzzzzzzzb_ = QICoreCommon_2_1_000.Instance.prevalenceInterval(context, HIVDiagnosis);
                        CqlDateTime bzzzzzzzzzzzzc_ = context.Operators.Start(bzzzzzzzzzzzzb_);

                        return bzzzzzzzzzzzzc_ is null;
                    };
                    if (bzzzzzzzzzzzza_())
                    {
                        return default;
                    }
                    else
                    {
                        CqlInterval<CqlDateTime> bzzzzzzzzzzzzd_ = QICoreCommon_2_1_000.Instance.prevalenceInterval(context, HIVDiagnosis);
                        CqlDateTime bzzzzzzzzzzzze_ = context.Operators.Start(bzzzzzzzzzzzzd_);
                        CqlDateTime bzzzzzzzzzzzzg_ = context.Operators.Start(bzzzzzzzzzzzzd_);
                        CqlInterval<CqlDateTime> bzzzzzzzzzzzzh_ = context.Operators.Interval(bzzzzzzzzzzzze_, bzzzzzzzzzzzzg_, true, true);

                        return bzzzzzzzzzzzzh_;
                    }
                };
                CqlInterval<CqlDateTime> azzzzzzzzzzzzv_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, azzzzzzzzzzzzq_);
                bool? azzzzzzzzzzzzw_ = context.Operators.SameOrBefore(azzzzzzzzzzzzt_(), azzzzzzzzzzzzv_, "day");
                bool? azzzzzzzzzzzzx_ = context.Operators.And(azzzzzzzzzzzzs_, azzzzzzzzzzzzw_);
                bool? azzzzzzzzzzzzy_ = QICoreCommon_2_1_000.Instance.isActive(context, HIVDiagnosis);
                bool? azzzzzzzzzzzzz_ = context.Operators.And(azzzzzzzzzzzzx_, azzzzzzzzzzzzy_);

                return azzzzzzzzzzzzz_;
            };
            IEnumerable<Condition> azzzzzzzzzzzzm_ = context.Operators.Where<Condition>(azzzzzzzzzzzzk_, azzzzzzzzzzzzl_);
            Encounter azzzzzzzzzzzzn_(Condition HIVDiagnosis) =>
                ValidEncounter;
            IEnumerable<Encounter> azzzzzzzzzzzzo_ = context.Operators.Select<Condition, Encounter>(azzzzzzzzzzzzm_, azzzzzzzzzzzzn_);

            return azzzzzzzzzzzzo_;
        };
        IEnumerable<Encounter> azzzzzzzzzzzzi_ = context.Operators.SelectMany<Encounter, Encounter>(azzzzzzzzzzzzg_, azzzzzzzzzzzzh_);

        return azzzzzzzzzzzzi_;
    }


    [CqlExpressionDefinition("Has One Encounter With HIV and One Viral Load Test At Least 90 Days Apart")]
    public bool? Has_One_Encounter_With_HIV_and_One_Viral_Load_Test_At_Least_90_Days_Apart(CqlContext context)
    {
        IEnumerable<Encounter> bzzzzzzzzzzzzi_ = this.Encounter_During_Measurement_Period_With_HIV(context);
        IEnumerable<Encounter> bzzzzzzzzzzzzj_(Encounter EncounterWithHIV)
        {
            CqlValueSet bzzzzzzzzzzzzm_ = this.HIV_Viral_Load(context);
            IEnumerable<Observation> bzzzzzzzzzzzzn_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, bzzzzzzzzzzzzm_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
            bool? bzzzzzzzzzzzzo_(Observation ViralLoadTest)
            {
                CqlInterval<CqlDateTime> bzzzzzzzzzzzzs_ = this.Measurement_Period(context);
                DataType bzzzzzzzzzzzzt_ = ViralLoadTest?.Effective;
                object bzzzzzzzzzzzzu_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bzzzzzzzzzzzzt_);
                CqlInterval<CqlDateTime> bzzzzzzzzzzzzv_ = QICoreCommon_2_1_000.Instance.toInterval(context, bzzzzzzzzzzzzu_);
                bool? bzzzzzzzzzzzzw_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(bzzzzzzzzzzzzs_, bzzzzzzzzzzzzv_, "day");
                object bzzzzzzzzzzzzy_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bzzzzzzzzzzzzt_);
                CqlInterval<CqlDateTime> bzzzzzzzzzzzzz_ = QICoreCommon_2_1_000.Instance.toInterval(context, bzzzzzzzzzzzzy_);
                CqlDateTime czzzzzzzzzzzza_ = context.Operators.Start(bzzzzzzzzzzzzz_);
                Period czzzzzzzzzzzzb_ = EncounterWithHIV?.Period;
                CqlInterval<CqlDateTime> czzzzzzzzzzzzc_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, czzzzzzzzzzzzb_);
                CqlDateTime czzzzzzzzzzzzd_ = context.Operators.End(czzzzzzzzzzzzc_);
                CqlQuantity czzzzzzzzzzzze_ = context.Operators.Quantity(90m, "days");
                CqlDateTime czzzzzzzzzzzzf_ = context.Operators.Add(czzzzzzzzzzzzd_, czzzzzzzzzzzze_);
                bool? czzzzzzzzzzzzg_ = context.Operators.SameOrAfter(czzzzzzzzzzzza_, czzzzzzzzzzzzf_, "day");
                CqlInterval<CqlDateTime> czzzzzzzzzzzzi_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, czzzzzzzzzzzzb_);
                CqlDateTime czzzzzzzzzzzzj_ = context.Operators.Start(czzzzzzzzzzzzi_);
                object czzzzzzzzzzzzl_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bzzzzzzzzzzzzt_);
                CqlInterval<CqlDateTime> czzzzzzzzzzzzm_ = QICoreCommon_2_1_000.Instance.toInterval(context, czzzzzzzzzzzzl_);
                CqlDateTime czzzzzzzzzzzzn_ = context.Operators.End(czzzzzzzzzzzzm_);
                CqlDateTime czzzzzzzzzzzzp_ = context.Operators.Add(czzzzzzzzzzzzn_, czzzzzzzzzzzze_);
                bool? czzzzzzzzzzzzq_ = context.Operators.SameOrAfter(czzzzzzzzzzzzj_, czzzzzzzzzzzzp_, "day");
                bool? czzzzzzzzzzzzr_ = context.Operators.Or(czzzzzzzzzzzzg_, czzzzzzzzzzzzq_);
                bool? czzzzzzzzzzzzs_ = context.Operators.And(bzzzzzzzzzzzzw_, czzzzzzzzzzzzr_);

                return czzzzzzzzzzzzs_;
            };
            IEnumerable<Observation> bzzzzzzzzzzzzp_ = context.Operators.Where<Observation>(bzzzzzzzzzzzzn_, bzzzzzzzzzzzzo_);
            Encounter bzzzzzzzzzzzzq_(Observation ViralLoadTest) =>
                EncounterWithHIV;
            IEnumerable<Encounter> bzzzzzzzzzzzzr_ = context.Operators.Select<Observation, Encounter>(bzzzzzzzzzzzzp_, bzzzzzzzzzzzzq_);

            return bzzzzzzzzzzzzr_;
        };
        IEnumerable<Encounter> bzzzzzzzzzzzzk_ = context.Operators.SelectMany<Encounter, Encounter>(bzzzzzzzzzzzzi_, bzzzzzzzzzzzzj_);
        bool? bzzzzzzzzzzzzl_ = context.Operators.Exists<Encounter>(bzzzzzzzzzzzzk_);

        return bzzzzzzzzzzzzl_;
    }


    [CqlExpressionDefinition("Has Two Encounters With HIV At Least 90 Days Apart")]
    public bool? Has_Two_Encounters_With_HIV_At_Least_90_Days_Apart(CqlContext context)
    {
        IEnumerable<Encounter> czzzzzzzzzzzzt_ = this.Encounter_During_Measurement_Period_With_HIV(context);
        IEnumerable<Encounter> czzzzzzzzzzzzu_(Encounter EncounterWithHIV)
        {
            IEnumerable<Encounter> czzzzzzzzzzzzx_ = this.Encounter_During_Measurement_Period_With_HIV(context);
            bool? czzzzzzzzzzzzy_(Encounter AnotherEncounterWithHIV)
            {
                bool? dzzzzzzzzzzzzc_ = context.Operators.Equivalent(EncounterWithHIV, AnotherEncounterWithHIV);
                bool? dzzzzzzzzzzzzd_ = context.Operators.Not(dzzzzzzzzzzzzc_);
                Period dzzzzzzzzzzzze_ = AnotherEncounterWithHIV?.Period;
                CqlInterval<CqlDateTime> dzzzzzzzzzzzzf_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, dzzzzzzzzzzzze_);
                CqlDateTime dzzzzzzzzzzzzg_ = context.Operators.Start(dzzzzzzzzzzzzf_);
                Period dzzzzzzzzzzzzh_ = EncounterWithHIV?.Period;
                CqlInterval<CqlDateTime> dzzzzzzzzzzzzi_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, dzzzzzzzzzzzzh_);
                CqlDateTime dzzzzzzzzzzzzj_ = context.Operators.End(dzzzzzzzzzzzzi_);
                CqlQuantity dzzzzzzzzzzzzk_ = context.Operators.Quantity(90m, "days");
                CqlDateTime dzzzzzzzzzzzzl_ = context.Operators.Add(dzzzzzzzzzzzzj_, dzzzzzzzzzzzzk_);
                bool? dzzzzzzzzzzzzm_ = context.Operators.SameOrAfter(dzzzzzzzzzzzzg_, dzzzzzzzzzzzzl_, "day");
                bool? dzzzzzzzzzzzzn_ = context.Operators.And(dzzzzzzzzzzzzd_, dzzzzzzzzzzzzm_);

                return dzzzzzzzzzzzzn_;
            };
            IEnumerable<Encounter> czzzzzzzzzzzzz_ = context.Operators.Where<Encounter>(czzzzzzzzzzzzx_, czzzzzzzzzzzzy_);
            Encounter dzzzzzzzzzzzza_(Encounter AnotherEncounterWithHIV) =>
                EncounterWithHIV;
            IEnumerable<Encounter> dzzzzzzzzzzzzb_ = context.Operators.Select<Encounter, Encounter>(czzzzzzzzzzzzz_, dzzzzzzzzzzzza_);

            return dzzzzzzzzzzzzb_;
        };
        IEnumerable<Encounter> czzzzzzzzzzzzv_ = context.Operators.SelectMany<Encounter, Encounter>(czzzzzzzzzzzzt_, czzzzzzzzzzzzu_);
        bool? czzzzzzzzzzzzw_ = context.Operators.Exists<Encounter>(czzzzzzzzzzzzv_);

        return czzzzzzzzzzzzw_;
    }


    [CqlExpressionDefinition("Numerator")]
    public bool? Numerator(CqlContext context)
    {
        bool? dzzzzzzzzzzzzo_ = this.Has_One_Encounter_With_HIV_and_One_Viral_Load_Test_At_Least_90_Days_Apart(context);
        bool? dzzzzzzzzzzzzp_ = this.Has_Two_Encounters_With_HIV_At_Least_90_Days_Apart(context);
        bool? dzzzzzzzzzzzzq_ = context.Operators.Or(dzzzzzzzzzzzzo_, dzzzzzzzzzzzzp_);

        return dzzzzzzzzzzzzq_;
    }


    #endregion Expressions

    #region CqlTupleMetadata Properties

    private static CqlTupleMetadata CqlTupleMetadata_HPcCiDPXQfZTXIORThMLfTQDR = new(
        [typeof(IEnumerable<CqlCode>), typeof(string)],
        ["codes", "display"]);

    #endregion CqlTupleMetadata Properties

}
