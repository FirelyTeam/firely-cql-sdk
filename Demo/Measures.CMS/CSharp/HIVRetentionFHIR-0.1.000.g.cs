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
    private static readonly CqlCodeSystem _CPT =
      new CqlCodeSystem("http://www.ama-assn.org/go/cpt", null);

    #endregion CodeSystems

    #region Parameters

    [CqlParameterDefinition("Measurement Period")]
    public CqlInterval<CqlDateTime> Measurement_Period(CqlContext context)
    {
        CqlDateTime mzzzzzzzzz_ = context.Operators.DateTime(2025, 1, 1, 0, 0, 0, 0, 0.0m);
        CqlDateTime nzzzzzzzza_ = context.Operators.DateTime(2025, 12, 31, 23, 59, 59, 999, 0.0m);
        CqlInterval<CqlDateTime> nzzzzzzzzb_ = context.Operators.Interval(mzzzzzzzzz_, nzzzzzzzza_, true, true);
        object nzzzzzzzzc_ = context.ResolveParameter("HIVRetentionFHIR-0.1.000", "Measurement Period", nzzzzzzzzb_);

        return (CqlInterval<CqlDateTime>)nzzzzzzzzc_;
    }


    #endregion Parameters

    #region Expressions

    [CqlExpressionDefinition("Patient")]
    public Patient Patient(CqlContext context)
    {
        IEnumerable<Patient> nzzzzzzzzd_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-patient"));
        Patient nzzzzzzzze_ = context.Operators.SingletonFrom<Patient>(nzzzzzzzzd_);

        return nzzzzzzzze_;
    }


    [CqlExpressionDefinition("SDE Payer")]
    public IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> SDE_Payer(CqlContext context)
    {
        IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> nzzzzzzzzf_ = SupplementalDataElements_3_5_000.Instance.SDE_Payer(context);

        return nzzzzzzzzf_;
    }


    [CqlExpressionDefinition("SDE Ethnicity")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Ethnicity(CqlContext context)
    {
        List<Extension> nzzzzzzzzg_()
        {
            bool nzzzzzzzzp_()
            {
                Patient nzzzzzzzzq_ = this.Patient(context);
                bool nzzzzzzzzr_ = nzzzzzzzzq_ is DomainResource;

                return nzzzzzzzzr_;
            };
            if (nzzzzzzzzp_())
            {
                Patient nzzzzzzzzs_ = this.Patient(context);

                return (nzzzzzzzzs_ as DomainResource).Extension;
            }
            else
            {
                return default;
            }
        };
        bool? nzzzzzzzzh_(Extension @this)
        {
            string nzzzzzzzzt_ = @this?.Url;
            FhirString nzzzzzzzzu_ = context.Operators.Convert<FhirString>(nzzzzzzzzt_);
            string nzzzzzzzzv_ = FHIRHelpers_4_4_000.Instance.ToString(context, nzzzzzzzzu_);
            bool? nzzzzzzzzw_ = context.Operators.Equal(nzzzzzzzzv_, "http://hl7.org/fhir/us/core/StructureDefinition/us-core-ethnicity");

            return nzzzzzzzzw_;
        };
        IEnumerable<Extension> nzzzzzzzzi_ = context.Operators.Where<Extension>((IEnumerable<Extension>)(nzzzzzzzzg_()), nzzzzzzzzh_);
        Extension nzzzzzzzzj_ = context.Operators.SingletonFrom<Extension>(nzzzzzzzzi_);
        Extension[] nzzzzzzzzk_ = [
            nzzzzzzzzj_,
        ];
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? nzzzzzzzzl_(Extension E)
        {
            bool? nzzzzzzzzx_(Extension @this)
            {
                string ozzzzzzzzs_ = @this?.Url;
                FhirString ozzzzzzzzt_ = context.Operators.Convert<FhirString>(ozzzzzzzzs_);
                string ozzzzzzzzu_ = FHIRHelpers_4_4_000.Instance.ToString(context, ozzzzzzzzt_);
                bool? ozzzzzzzzv_ = context.Operators.Equal(ozzzzzzzzu_, "ombCategory");

                return ozzzzzzzzv_;
            };
            IEnumerable<Extension> nzzzzzzzzy_ = context.Operators.Where<Extension>((IEnumerable<Extension>)(E is Element
                    ? (E as Element).Extension
                    : default), nzzzzzzzzx_);
            object nzzzzzzzzz_(Extension @this)
            {
                DataType ozzzzzzzzw_ = @this?.Value;

                return ozzzzzzzzw_;
            };
            IEnumerable<object> ozzzzzzzza_ = context.Operators.Select<Extension, object>(nzzzzzzzzy_, nzzzzzzzzz_);
            object ozzzzzzzzb_ = context.Operators.SingletonFrom<object>(ozzzzzzzza_);
            CqlCode ozzzzzzzzc_ = FHIRHelpers_4_4_000.Instance.ToCode(context, ozzzzzzzzb_ as Coding);
            CqlCode[] ozzzzzzzzd_ = [
                ozzzzzzzzc_,
            ];
            bool? ozzzzzzzze_(Extension @this)
            {
                string ozzzzzzzzx_ = @this?.Url;
                FhirString ozzzzzzzzy_ = context.Operators.Convert<FhirString>(ozzzzzzzzx_);
                string ozzzzzzzzz_ = FHIRHelpers_4_4_000.Instance.ToString(context, ozzzzzzzzy_);
                bool? pzzzzzzzza_ = context.Operators.Equal(ozzzzzzzzz_, "detailed");

                return pzzzzzzzza_;
            };
            IEnumerable<Extension> ozzzzzzzzf_ = context.Operators.Where<Extension>((IEnumerable<Extension>)(E is Element
                    ? (E as Element).Extension
                    : default), ozzzzzzzze_);
            object ozzzzzzzzg_(Extension @this)
            {
                DataType pzzzzzzzzb_ = @this?.Value;

                return pzzzzzzzzb_;
            };
            IEnumerable<object> ozzzzzzzzh_ = context.Operators.Select<Extension, object>(ozzzzzzzzf_, ozzzzzzzzg_);
            CqlCode ozzzzzzzzi_(object @this)
            {
                CqlCode pzzzzzzzzc_ = FHIRHelpers_4_4_000.Instance.ToCode(context, @this as Coding);

                return pzzzzzzzzc_;
            };
            IEnumerable<CqlCode> ozzzzzzzzj_ = context.Operators.Select<object, CqlCode>(ozzzzzzzzh_, ozzzzzzzzi_);
            IEnumerable<CqlCode> ozzzzzzzzk_ = context.Operators.Union<CqlCode>(ozzzzzzzzd_ as IEnumerable<CqlCode>, ozzzzzzzzj_);
            bool? ozzzzzzzzl_(Extension @this)
            {
                string pzzzzzzzzd_ = @this?.Url;
                FhirString pzzzzzzzze_ = context.Operators.Convert<FhirString>(pzzzzzzzzd_);
                string pzzzzzzzzf_ = FHIRHelpers_4_4_000.Instance.ToString(context, pzzzzzzzze_);
                bool? pzzzzzzzzg_ = context.Operators.Equal(pzzzzzzzzf_, "text");

                return pzzzzzzzzg_;
            };
            IEnumerable<Extension> ozzzzzzzzm_ = context.Operators.Where<Extension>((IEnumerable<Extension>)(E is Element
                    ? (E as Element).Extension
                    : default), ozzzzzzzzl_);
            DataType ozzzzzzzzn_(Extension @this)
            {
                DataType pzzzzzzzzh_ = @this?.Value;

                return pzzzzzzzzh_;
            };
            IEnumerable<DataType> ozzzzzzzzo_ = context.Operators.Select<Extension, DataType>(ozzzzzzzzm_, ozzzzzzzzn_);
            DataType ozzzzzzzzp_ = context.Operators.SingletonFrom<DataType>(ozzzzzzzzo_);
            string ozzzzzzzzq_ = context.Operators.Convert<string>(ozzzzzzzzp_);
            (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? ozzzzzzzzr_ = (CqlTupleMetadata_HPcCiDPXQfZTXIORThMLfTQDR, ozzzzzzzzk_, ozzzzzzzzq_);

            return ozzzzzzzzr_;
        };
        IEnumerable<(CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)?> nzzzzzzzzm_ = context.Operators.Select<Extension, (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)?>((IEnumerable<Extension>)nzzzzzzzzk_, nzzzzzzzzl_);
        IEnumerable<(CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)?> nzzzzzzzzn_ = context.Operators.Distinct<(CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)?>(nzzzzzzzzm_);
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? nzzzzzzzzo_ = context.Operators.SingletonFrom<(CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)?>(nzzzzzzzzn_);

        return nzzzzzzzzo_;
    }


    [CqlExpressionDefinition("SDE Race")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Race(CqlContext context)
    {
        List<Extension> pzzzzzzzzi_()
        {
            bool pzzzzzzzzr_()
            {
                Patient pzzzzzzzzs_ = this.Patient(context);
                bool pzzzzzzzzt_ = pzzzzzzzzs_ is DomainResource;

                return pzzzzzzzzt_;
            };
            if (pzzzzzzzzr_())
            {
                Patient pzzzzzzzzu_ = this.Patient(context);

                return (pzzzzzzzzu_ as DomainResource).Extension;
            }
            else
            {
                return default;
            }
        };
        bool? pzzzzzzzzj_(Extension @this)
        {
            string pzzzzzzzzv_ = @this?.Url;
            FhirString pzzzzzzzzw_ = context.Operators.Convert<FhirString>(pzzzzzzzzv_);
            string pzzzzzzzzx_ = FHIRHelpers_4_4_000.Instance.ToString(context, pzzzzzzzzw_);
            bool? pzzzzzzzzy_ = context.Operators.Equal(pzzzzzzzzx_, "http://hl7.org/fhir/us/core/StructureDefinition/us-core-race");

            return pzzzzzzzzy_;
        };
        IEnumerable<Extension> pzzzzzzzzk_ = context.Operators.Where<Extension>((IEnumerable<Extension>)(pzzzzzzzzi_()), pzzzzzzzzj_);
        Extension pzzzzzzzzl_ = context.Operators.SingletonFrom<Extension>(pzzzzzzzzk_);
        Extension[] pzzzzzzzzm_ = [
            pzzzzzzzzl_,
        ];
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? pzzzzzzzzn_(Extension R)
        {
            bool? pzzzzzzzzz_(Extension @this)
            {
                string qzzzzzzzzt_ = @this?.Url;
                FhirString qzzzzzzzzu_ = context.Operators.Convert<FhirString>(qzzzzzzzzt_);
                string qzzzzzzzzv_ = FHIRHelpers_4_4_000.Instance.ToString(context, qzzzzzzzzu_);
                bool? qzzzzzzzzw_ = context.Operators.Equal(qzzzzzzzzv_, "ombCategory");

                return qzzzzzzzzw_;
            };
            IEnumerable<Extension> qzzzzzzzza_ = context.Operators.Where<Extension>((IEnumerable<Extension>)(R is Element
                    ? (R as Element).Extension
                    : default), pzzzzzzzzz_);
            object qzzzzzzzzb_(Extension @this)
            {
                DataType qzzzzzzzzx_ = @this?.Value;

                return qzzzzzzzzx_;
            };
            IEnumerable<object> qzzzzzzzzc_ = context.Operators.Select<Extension, object>(qzzzzzzzza_, qzzzzzzzzb_);
            CqlCode qzzzzzzzzd_(object @this)
            {
                CqlCode qzzzzzzzzy_ = FHIRHelpers_4_4_000.Instance.ToCode(context, @this as Coding);

                return qzzzzzzzzy_;
            };
            IEnumerable<CqlCode> qzzzzzzzze_ = context.Operators.Select<object, CqlCode>(qzzzzzzzzc_, qzzzzzzzzd_);
            bool? qzzzzzzzzf_(Extension @this)
            {
                string qzzzzzzzzz_ = @this?.Url;
                FhirString rzzzzzzzza_ = context.Operators.Convert<FhirString>(qzzzzzzzzz_);
                string rzzzzzzzzb_ = FHIRHelpers_4_4_000.Instance.ToString(context, rzzzzzzzza_);
                bool? rzzzzzzzzc_ = context.Operators.Equal(rzzzzzzzzb_, "detailed");

                return rzzzzzzzzc_;
            };
            IEnumerable<Extension> qzzzzzzzzg_ = context.Operators.Where<Extension>((IEnumerable<Extension>)(R is Element
                    ? (R as Element).Extension
                    : default), qzzzzzzzzf_);
            object qzzzzzzzzh_(Extension @this)
            {
                DataType rzzzzzzzzd_ = @this?.Value;

                return rzzzzzzzzd_;
            };
            IEnumerable<object> qzzzzzzzzi_ = context.Operators.Select<Extension, object>(qzzzzzzzzg_, qzzzzzzzzh_);
            CqlCode qzzzzzzzzj_(object @this)
            {
                CqlCode rzzzzzzzze_ = FHIRHelpers_4_4_000.Instance.ToCode(context, @this as Coding);

                return rzzzzzzzze_;
            };
            IEnumerable<CqlCode> qzzzzzzzzk_ = context.Operators.Select<object, CqlCode>(qzzzzzzzzi_, qzzzzzzzzj_);
            IEnumerable<CqlCode> qzzzzzzzzl_ = context.Operators.Union<CqlCode>(qzzzzzzzze_, qzzzzzzzzk_);
            bool? qzzzzzzzzm_(Extension @this)
            {
                string rzzzzzzzzf_ = @this?.Url;
                FhirString rzzzzzzzzg_ = context.Operators.Convert<FhirString>(rzzzzzzzzf_);
                string rzzzzzzzzh_ = FHIRHelpers_4_4_000.Instance.ToString(context, rzzzzzzzzg_);
                bool? rzzzzzzzzi_ = context.Operators.Equal(rzzzzzzzzh_, "text");

                return rzzzzzzzzi_;
            };
            IEnumerable<Extension> qzzzzzzzzn_ = context.Operators.Where<Extension>((IEnumerable<Extension>)(R is Element
                    ? (R as Element).Extension
                    : default), qzzzzzzzzm_);
            DataType qzzzzzzzzo_(Extension @this)
            {
                DataType rzzzzzzzzj_ = @this?.Value;

                return rzzzzzzzzj_;
            };
            IEnumerable<DataType> qzzzzzzzzp_ = context.Operators.Select<Extension, DataType>(qzzzzzzzzn_, qzzzzzzzzo_);
            DataType qzzzzzzzzq_ = context.Operators.SingletonFrom<DataType>(qzzzzzzzzp_);
            string qzzzzzzzzr_ = context.Operators.Convert<string>(qzzzzzzzzq_);
            (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? qzzzzzzzzs_ = (CqlTupleMetadata_HPcCiDPXQfZTXIORThMLfTQDR, qzzzzzzzzl_, qzzzzzzzzr_);

            return qzzzzzzzzs_;
        };
        IEnumerable<(CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)?> pzzzzzzzzo_ = context.Operators.Select<Extension, (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)?>((IEnumerable<Extension>)pzzzzzzzzm_, pzzzzzzzzn_);
        IEnumerable<(CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)?> pzzzzzzzzp_ = context.Operators.Distinct<(CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)?>(pzzzzzzzzo_);
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? pzzzzzzzzq_ = context.Operators.SingletonFrom<(CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)?>(pzzzzzzzzp_);

        return pzzzzzzzzq_;
    }


    [CqlExpressionDefinition("SDE Sex")]
    public CqlCode SDE_Sex(CqlContext context)
    {
        CqlCode rzzzzzzzzk_ = SupplementalDataElements_3_5_000.Instance.SDE_Sex(context);

        return rzzzzzzzzk_;
    }


    [CqlExpressionDefinition("Has Active HIV Diagnosis Starts On or Before First 240 Days of Measurement Period")]
    public bool? Has_Active_HIV_Diagnosis_Starts_On_or_Before_First_240_Days_of_Measurement_Period(CqlContext context)
    {
        CqlValueSet rzzzzzzzzl_ = this.HIV(context);
        IEnumerable<Condition> rzzzzzzzzm_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, rzzzzzzzzl_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        bool? rzzzzzzzzn_(Condition HIVDx)
        {
            CqlInterval<CqlDateTime> rzzzzzzzzq_ = QICoreCommon_2_1_000.Instance.prevalenceInterval(context, HIVDx);
            CqlDateTime rzzzzzzzzr_ = context.Operators.Start(rzzzzzzzzq_);
            CqlInterval<CqlDateTime> rzzzzzzzzs_ = this.Measurement_Period(context);
            CqlDateTime rzzzzzzzzt_ = context.Operators.Start(rzzzzzzzzs_);
            CqlQuantity rzzzzzzzzu_ = context.Operators.Quantity(240m, "days");
            CqlDateTime rzzzzzzzzv_ = context.Operators.Add(rzzzzzzzzt_, rzzzzzzzzu_);
            bool? rzzzzzzzzw_ = context.Operators.SameOrBefore(rzzzzzzzzr_, rzzzzzzzzv_, "day");
            bool? rzzzzzzzzx_ = QICoreCommon_2_1_000.Instance.isActive(context, HIVDx);
            bool? rzzzzzzzzy_ = context.Operators.And(rzzzzzzzzw_, rzzzzzzzzx_);

            return rzzzzzzzzy_;
        };
        IEnumerable<Condition> rzzzzzzzzo_ = context.Operators.Where<Condition>(rzzzzzzzzm_, rzzzzzzzzn_);
        bool? rzzzzzzzzp_ = context.Operators.Exists<Condition>(rzzzzzzzzo_);

        return rzzzzzzzzp_;
    }


    [CqlExpressionDefinition("Has Qualifying Encounter During First 240 Days of Measurement Period")]
    public bool? Has_Qualifying_Encounter_During_First_240_Days_of_Measurement_Period(CqlContext context)
    {
        CqlValueSet rzzzzzzzzz_ = this.Office_Visit(context);
        IEnumerable<Encounter> szzzzzzzza_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, rzzzzzzzzz_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        CqlValueSet szzzzzzzzb_ = this.Outpatient_Consultation(context);
        IEnumerable<Encounter> szzzzzzzzc_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, szzzzzzzzb_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> szzzzzzzzd_ = context.Operators.Union<Encounter>(szzzzzzzza_, szzzzzzzzc_);
        CqlValueSet szzzzzzzze_ = this.Annual_Wellness_Visit(context);
        IEnumerable<Encounter> szzzzzzzzf_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, szzzzzzzze_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        CqlValueSet szzzzzzzzg_ = this.Face_to_Face_Interaction(context);
        IEnumerable<Encounter> szzzzzzzzh_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, szzzzzzzzg_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> szzzzzzzzi_ = context.Operators.Union<Encounter>(szzzzzzzzf_, szzzzzzzzh_);
        IEnumerable<Encounter> szzzzzzzzj_ = context.Operators.Union<Encounter>(szzzzzzzzd_, szzzzzzzzi_);
        CqlValueSet szzzzzzzzk_ = this.Home_Healthcare_Services(context);
        IEnumerable<Encounter> szzzzzzzzl_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, szzzzzzzzk_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        CqlValueSet szzzzzzzzm_ = this.Preventive_Care_Services_Established_Office_Visit__18_and_Up(context);
        IEnumerable<Encounter> szzzzzzzzn_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, szzzzzzzzm_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> szzzzzzzzo_ = context.Operators.Union<Encounter>(szzzzzzzzl_, szzzzzzzzn_);
        IEnumerable<Encounter> szzzzzzzzp_ = context.Operators.Union<Encounter>(szzzzzzzzj_, szzzzzzzzo_);
        CqlValueSet szzzzzzzzq_ = this.Preventive_Care_Services_Initial_Office_Visit__18_and_Up(context);
        IEnumerable<Encounter> szzzzzzzzr_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, szzzzzzzzq_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        CqlValueSet szzzzzzzzs_ = this.Preventive_Care_Services__Initial_Office_Visit__0_to_17(context);
        IEnumerable<Encounter> szzzzzzzzt_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, szzzzzzzzs_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> szzzzzzzzu_ = context.Operators.Union<Encounter>(szzzzzzzzr_, szzzzzzzzt_);
        IEnumerable<Encounter> szzzzzzzzv_ = context.Operators.Union<Encounter>(szzzzzzzzp_, szzzzzzzzu_);
        CqlValueSet szzzzzzzzw_ = this.Preventive_Care__Established_Office_Visit__0_to_17(context);
        IEnumerable<Encounter> szzzzzzzzx_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, szzzzzzzzw_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        CqlValueSet szzzzzzzzy_ = this.Telephone_Visits(context);
        IEnumerable<Encounter> szzzzzzzzz_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, szzzzzzzzy_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> tzzzzzzzza_ = context.Operators.Union<Encounter>(szzzzzzzzx_, szzzzzzzzz_);
        IEnumerable<Encounter> tzzzzzzzzb_ = context.Operators.Union<Encounter>(szzzzzzzzv_, tzzzzzzzza_);
        CqlValueSet tzzzzzzzzc_ = this.Preventive_Care_Services_Other(context);
        IEnumerable<Encounter> tzzzzzzzzd_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, tzzzzzzzzc_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> tzzzzzzzze_ = context.Operators.Union<Encounter>(tzzzzzzzzb_, tzzzzzzzzd_);
        bool? tzzzzzzzzf_(Encounter QualifyingEncounter)
        {
            CqlInterval<CqlDateTime> tzzzzzzzzi_ = this.Measurement_Period(context);
            CqlDateTime tzzzzzzzzj_ = context.Operators.Start(tzzzzzzzzi_);
            CqlDateTime tzzzzzzzzl_ = context.Operators.Start(tzzzzzzzzi_);
            CqlQuantity tzzzzzzzzm_ = context.Operators.Quantity(240m, "days");
            CqlDateTime tzzzzzzzzn_ = context.Operators.Add(tzzzzzzzzl_, tzzzzzzzzm_);
            CqlInterval<CqlDateTime> tzzzzzzzzo_ = context.Operators.Interval(tzzzzzzzzj_, tzzzzzzzzn_, true, true);
            Period tzzzzzzzzp_ = QualifyingEncounter?.Period;
            CqlInterval<CqlDateTime> tzzzzzzzzq_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, tzzzzzzzzp_);
            bool? tzzzzzzzzr_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(tzzzzzzzzo_, tzzzzzzzzq_, "day");

            return tzzzzzzzzr_;
        };
        IEnumerable<Encounter> tzzzzzzzzg_ = context.Operators.Where<Encounter>(tzzzzzzzze_, tzzzzzzzzf_);
        bool? tzzzzzzzzh_ = context.Operators.Exists<Encounter>(tzzzzzzzzg_);

        return tzzzzzzzzh_;
    }


    [CqlExpressionDefinition("Initial Population")]
    public bool? Initial_Population(CqlContext context)
    {
        bool? tzzzzzzzzs_ = this.Has_Active_HIV_Diagnosis_Starts_On_or_Before_First_240_Days_of_Measurement_Period(context);
        bool? tzzzzzzzzt_ = this.Has_Qualifying_Encounter_During_First_240_Days_of_Measurement_Period(context);
        bool? tzzzzzzzzu_ = context.Operators.And(tzzzzzzzzs_, tzzzzzzzzt_);

        return tzzzzzzzzu_;
    }


    [CqlExpressionDefinition("Denominator")]
    public bool? Denominator(CqlContext context)
    {
        bool? tzzzzzzzzv_ = this.Initial_Population(context);

        return tzzzzzzzzv_;
    }


    [CqlExpressionDefinition("Encounter During Measurement Period With HIV")]
    public IEnumerable<Encounter> Encounter_During_Measurement_Period_With_HIV(CqlContext context)
    {
        CqlValueSet tzzzzzzzzw_ = this.Office_Visit(context);
        IEnumerable<Encounter> tzzzzzzzzx_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, tzzzzzzzzw_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        CqlValueSet tzzzzzzzzy_ = this.Outpatient_Consultation(context);
        IEnumerable<Encounter> tzzzzzzzzz_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, tzzzzzzzzy_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> uzzzzzzzza_ = context.Operators.Union<Encounter>(tzzzzzzzzx_, tzzzzzzzzz_);
        CqlValueSet uzzzzzzzzb_ = this.Annual_Wellness_Visit(context);
        IEnumerable<Encounter> uzzzzzzzzc_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, uzzzzzzzzb_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        CqlValueSet uzzzzzzzzd_ = this.Face_to_Face_Interaction(context);
        IEnumerable<Encounter> uzzzzzzzze_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, uzzzzzzzzd_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> uzzzzzzzzf_ = context.Operators.Union<Encounter>(uzzzzzzzzc_, uzzzzzzzze_);
        IEnumerable<Encounter> uzzzzzzzzg_ = context.Operators.Union<Encounter>(uzzzzzzzza_, uzzzzzzzzf_);
        CqlValueSet uzzzzzzzzh_ = this.Home_Healthcare_Services(context);
        IEnumerable<Encounter> uzzzzzzzzi_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, uzzzzzzzzh_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        CqlValueSet uzzzzzzzzj_ = this.Preventive_Care_Services_Established_Office_Visit__18_and_Up(context);
        IEnumerable<Encounter> uzzzzzzzzk_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, uzzzzzzzzj_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> uzzzzzzzzl_ = context.Operators.Union<Encounter>(uzzzzzzzzi_, uzzzzzzzzk_);
        IEnumerable<Encounter> uzzzzzzzzm_ = context.Operators.Union<Encounter>(uzzzzzzzzg_, uzzzzzzzzl_);
        CqlValueSet uzzzzzzzzn_ = this.Preventive_Care_Services_Initial_Office_Visit__18_and_Up(context);
        IEnumerable<Encounter> uzzzzzzzzo_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, uzzzzzzzzn_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        CqlValueSet uzzzzzzzzp_ = this.Preventive_Care_Services__Initial_Office_Visit__0_to_17(context);
        IEnumerable<Encounter> uzzzzzzzzq_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, uzzzzzzzzp_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> uzzzzzzzzr_ = context.Operators.Union<Encounter>(uzzzzzzzzo_, uzzzzzzzzq_);
        IEnumerable<Encounter> uzzzzzzzzs_ = context.Operators.Union<Encounter>(uzzzzzzzzm_, uzzzzzzzzr_);
        CqlValueSet uzzzzzzzzt_ = this.Preventive_Care__Established_Office_Visit__0_to_17(context);
        IEnumerable<Encounter> uzzzzzzzzu_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, uzzzzzzzzt_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        CqlValueSet uzzzzzzzzv_ = this.Telephone_Visits(context);
        IEnumerable<Encounter> uzzzzzzzzw_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, uzzzzzzzzv_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> uzzzzzzzzx_ = context.Operators.Union<Encounter>(uzzzzzzzzu_, uzzzzzzzzw_);
        IEnumerable<Encounter> uzzzzzzzzy_ = context.Operators.Union<Encounter>(uzzzzzzzzs_, uzzzzzzzzx_);
        CqlValueSet uzzzzzzzzz_ = this.Preventive_Care_Services_Other(context);
        IEnumerable<Encounter> vzzzzzzzza_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, uzzzzzzzzz_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> vzzzzzzzzb_ = context.Operators.Union<Encounter>(uzzzzzzzzy_, vzzzzzzzza_);
        IEnumerable<Encounter> vzzzzzzzzc_(Encounter ValidEncounter)
        {
            CqlValueSet vzzzzzzzze_ = this.HIV(context);
            IEnumerable<Condition> vzzzzzzzzf_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, vzzzzzzzze_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
            bool? vzzzzzzzzg_(Condition HIVDiagnosis)
            {
                CqlInterval<CqlDateTime> vzzzzzzzzk_ = this.Measurement_Period(context);
                Period vzzzzzzzzl_ = ValidEncounter?.Period;
                CqlInterval<CqlDateTime> vzzzzzzzzm_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, vzzzzzzzzl_);
                bool? vzzzzzzzzn_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(vzzzzzzzzk_, vzzzzzzzzm_, "day");
                CqlInterval<CqlDateTime> vzzzzzzzzo_()
                {
                    bool vzzzzzzzzv_()
                    {
                        CqlInterval<CqlDateTime> vzzzzzzzzw_ = QICoreCommon_2_1_000.Instance.prevalenceInterval(context, HIVDiagnosis);
                        CqlDateTime vzzzzzzzzx_ = context.Operators.Start(vzzzzzzzzw_);

                        return vzzzzzzzzx_ is null;
                    };
                    if (vzzzzzzzzv_())
                    {
                        return default;
                    }
                    else
                    {
                        CqlInterval<CqlDateTime> vzzzzzzzzy_ = QICoreCommon_2_1_000.Instance.prevalenceInterval(context, HIVDiagnosis);
                        CqlDateTime vzzzzzzzzz_ = context.Operators.Start(vzzzzzzzzy_);
                        CqlDateTime wzzzzzzzzb_ = context.Operators.Start(vzzzzzzzzy_);
                        CqlInterval<CqlDateTime> wzzzzzzzzc_ = context.Operators.Interval(vzzzzzzzzz_, wzzzzzzzzb_, true, true);

                        return wzzzzzzzzc_;
                    }
                };
                CqlInterval<CqlDateTime> vzzzzzzzzq_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, vzzzzzzzzl_);
                bool? vzzzzzzzzr_ = context.Operators.SameOrBefore(vzzzzzzzzo_(), vzzzzzzzzq_, "day");
                bool? vzzzzzzzzs_ = context.Operators.And(vzzzzzzzzn_, vzzzzzzzzr_);
                bool? vzzzzzzzzt_ = QICoreCommon_2_1_000.Instance.isActive(context, HIVDiagnosis);
                bool? vzzzzzzzzu_ = context.Operators.And(vzzzzzzzzs_, vzzzzzzzzt_);

                return vzzzzzzzzu_;
            };
            IEnumerable<Condition> vzzzzzzzzh_ = context.Operators.Where<Condition>(vzzzzzzzzf_, vzzzzzzzzg_);
            Encounter vzzzzzzzzi_(Condition HIVDiagnosis) =>
                ValidEncounter;
            IEnumerable<Encounter> vzzzzzzzzj_ = context.Operators.Select<Condition, Encounter>(vzzzzzzzzh_, vzzzzzzzzi_);

            return vzzzzzzzzj_;
        };
        IEnumerable<Encounter> vzzzzzzzzd_ = context.Operators.SelectMany<Encounter, Encounter>(vzzzzzzzzb_, vzzzzzzzzc_);

        return vzzzzzzzzd_;
    }


    [CqlExpressionDefinition("Has One Encounter With HIV and One Viral Load Test At Least 90 Days Apart")]
    public bool? Has_One_Encounter_With_HIV_and_One_Viral_Load_Test_At_Least_90_Days_Apart(CqlContext context)
    {
        IEnumerable<Encounter> wzzzzzzzzd_ = this.Encounter_During_Measurement_Period_With_HIV(context);
        IEnumerable<Encounter> wzzzzzzzze_(Encounter EncounterWithHIV)
        {
            CqlValueSet wzzzzzzzzh_ = this.HIV_Viral_Load(context);
            IEnumerable<Observation> wzzzzzzzzi_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, wzzzzzzzzh_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
            bool? wzzzzzzzzj_(Observation ViralLoadTest)
            {
                CqlInterval<CqlDateTime> wzzzzzzzzn_ = this.Measurement_Period(context);
                DataType wzzzzzzzzo_ = ViralLoadTest?.Effective;
                object wzzzzzzzzp_ = FHIRHelpers_4_4_000.Instance.ToValue(context, wzzzzzzzzo_);
                CqlInterval<CqlDateTime> wzzzzzzzzq_ = QICoreCommon_2_1_000.Instance.toInterval(context, wzzzzzzzzp_);
                bool? wzzzzzzzzr_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(wzzzzzzzzn_, wzzzzzzzzq_, "day");
                object wzzzzzzzzt_ = FHIRHelpers_4_4_000.Instance.ToValue(context, wzzzzzzzzo_);
                CqlInterval<CqlDateTime> wzzzzzzzzu_ = QICoreCommon_2_1_000.Instance.toInterval(context, wzzzzzzzzt_);
                CqlDateTime wzzzzzzzzv_ = context.Operators.Start(wzzzzzzzzu_);
                Period wzzzzzzzzw_ = EncounterWithHIV?.Period;
                CqlInterval<CqlDateTime> wzzzzzzzzx_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, wzzzzzzzzw_);
                CqlDateTime wzzzzzzzzy_ = context.Operators.End(wzzzzzzzzx_);
                CqlQuantity wzzzzzzzzz_ = context.Operators.Quantity(90m, "days");
                CqlDateTime xzzzzzzzza_ = context.Operators.Add(wzzzzzzzzy_, wzzzzzzzzz_);
                bool? xzzzzzzzzb_ = context.Operators.SameOrAfter(wzzzzzzzzv_, xzzzzzzzza_, "day");
                CqlInterval<CqlDateTime> xzzzzzzzzd_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, wzzzzzzzzw_);
                CqlDateTime xzzzzzzzze_ = context.Operators.Start(xzzzzzzzzd_);
                object xzzzzzzzzg_ = FHIRHelpers_4_4_000.Instance.ToValue(context, wzzzzzzzzo_);
                CqlInterval<CqlDateTime> xzzzzzzzzh_ = QICoreCommon_2_1_000.Instance.toInterval(context, xzzzzzzzzg_);
                CqlDateTime xzzzzzzzzi_ = context.Operators.End(xzzzzzzzzh_);
                CqlDateTime xzzzzzzzzk_ = context.Operators.Add(xzzzzzzzzi_, wzzzzzzzzz_);
                bool? xzzzzzzzzl_ = context.Operators.SameOrAfter(xzzzzzzzze_, xzzzzzzzzk_, "day");
                bool? xzzzzzzzzm_ = context.Operators.Or(xzzzzzzzzb_, xzzzzzzzzl_);
                bool? xzzzzzzzzn_ = context.Operators.And(wzzzzzzzzr_, xzzzzzzzzm_);

                return xzzzzzzzzn_;
            };
            IEnumerable<Observation> wzzzzzzzzk_ = context.Operators.Where<Observation>(wzzzzzzzzi_, wzzzzzzzzj_);
            Encounter wzzzzzzzzl_(Observation ViralLoadTest) =>
                EncounterWithHIV;
            IEnumerable<Encounter> wzzzzzzzzm_ = context.Operators.Select<Observation, Encounter>(wzzzzzzzzk_, wzzzzzzzzl_);

            return wzzzzzzzzm_;
        };
        IEnumerable<Encounter> wzzzzzzzzf_ = context.Operators.SelectMany<Encounter, Encounter>(wzzzzzzzzd_, wzzzzzzzze_);
        bool? wzzzzzzzzg_ = context.Operators.Exists<Encounter>(wzzzzzzzzf_);

        return wzzzzzzzzg_;
    }


    [CqlExpressionDefinition("Has Two Encounters With HIV At Least 90 Days Apart")]
    public bool? Has_Two_Encounters_With_HIV_At_Least_90_Days_Apart(CqlContext context)
    {
        IEnumerable<Encounter> xzzzzzzzzo_ = this.Encounter_During_Measurement_Period_With_HIV(context);
        IEnumerable<Encounter> xzzzzzzzzp_(Encounter EncounterWithHIV)
        {
            IEnumerable<Encounter> xzzzzzzzzs_ = this.Encounter_During_Measurement_Period_With_HIV(context);
            bool? xzzzzzzzzt_(Encounter AnotherEncounterWithHIV)
            {
                bool? xzzzzzzzzx_ = context.Operators.Equivalent(EncounterWithHIV, AnotherEncounterWithHIV);
                bool? xzzzzzzzzy_ = context.Operators.Not(xzzzzzzzzx_);
                Period xzzzzzzzzz_ = AnotherEncounterWithHIV?.Period;
                CqlInterval<CqlDateTime> yzzzzzzzza_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, xzzzzzzzzz_);
                CqlDateTime yzzzzzzzzb_ = context.Operators.Start(yzzzzzzzza_);
                Period yzzzzzzzzc_ = EncounterWithHIV?.Period;
                CqlInterval<CqlDateTime> yzzzzzzzzd_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, yzzzzzzzzc_);
                CqlDateTime yzzzzzzzze_ = context.Operators.End(yzzzzzzzzd_);
                CqlQuantity yzzzzzzzzf_ = context.Operators.Quantity(90m, "days");
                CqlDateTime yzzzzzzzzg_ = context.Operators.Add(yzzzzzzzze_, yzzzzzzzzf_);
                bool? yzzzzzzzzh_ = context.Operators.SameOrAfter(yzzzzzzzzb_, yzzzzzzzzg_, "day");
                bool? yzzzzzzzzi_ = context.Operators.And(xzzzzzzzzy_, yzzzzzzzzh_);

                return yzzzzzzzzi_;
            };
            IEnumerable<Encounter> xzzzzzzzzu_ = context.Operators.Where<Encounter>(xzzzzzzzzs_, xzzzzzzzzt_);
            Encounter xzzzzzzzzv_(Encounter AnotherEncounterWithHIV) =>
                EncounterWithHIV;
            IEnumerable<Encounter> xzzzzzzzzw_ = context.Operators.Select<Encounter, Encounter>(xzzzzzzzzu_, xzzzzzzzzv_);

            return xzzzzzzzzw_;
        };
        IEnumerable<Encounter> xzzzzzzzzq_ = context.Operators.SelectMany<Encounter, Encounter>(xzzzzzzzzo_, xzzzzzzzzp_);
        bool? xzzzzzzzzr_ = context.Operators.Exists<Encounter>(xzzzzzzzzq_);

        return xzzzzzzzzr_;
    }


    [CqlExpressionDefinition("Numerator")]
    public bool? Numerator(CqlContext context)
    {
        bool? yzzzzzzzzj_ = this.Has_One_Encounter_With_HIV_and_One_Viral_Load_Test_At_Least_90_Days_Apart(context);
        bool? yzzzzzzzzk_ = this.Has_Two_Encounters_With_HIV_At_Least_90_Days_Apart(context);
        bool? yzzzzzzzzl_ = context.Operators.Or(yzzzzzzzzj_, yzzzzzzzzk_);

        return yzzzzzzzzl_;
    }


    #endregion Expressions

    #region CqlTupleMetadata Properties

    private static CqlTupleMetadata CqlTupleMetadata_HPcCiDPXQfZTXIORThMLfTQDR = new(
        [typeof(IEnumerable<CqlCode>), typeof(string)],
        ["codes", "display"]);

    #endregion CqlTupleMetadata Properties

}
