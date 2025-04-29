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
[CqlLibrary("OncologyPainIntensityQuantifiedFHIR", "0.1.000")]
public partial class OncologyPainIntensityQuantifiedFHIR_0_1_000 : ILibrary, ISingleton<OncologyPainIntensityQuantifiedFHIR_0_1_000>
{
    private OncologyPainIntensityQuantifiedFHIR_0_1_000() {}

    public static OncologyPainIntensityQuantifiedFHIR_0_1_000 Instance { get; } = new();

    #region ILibrary Implementation

    public string Name => "OncologyPainIntensityQuantifiedFHIR";
    public string Version => "0.1.000";
    public ILibrary[] Dependencies => [FHIRHelpers_4_4_000.Instance, CQMCommon_2_2_000.Instance, QICoreCommon_2_1_000.Instance, SupplementalDataElements_3_5_000.Instance];

    #endregion ILibrary Implementation

    #region ValueSets

    [CqlValueSetDefinition("Cancer", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1010", valueSetVersion: null)]
    public CqlValueSet Cancer(CqlContext _) => _Cancer;
    private static readonly CqlValueSet _Cancer = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1010", null);

    [CqlValueSetDefinition("Chemotherapy Administration", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1027", valueSetVersion: null)]
    public CqlValueSet Chemotherapy_Administration(CqlContext _) => _Chemotherapy_Administration;
    private static readonly CqlValueSet _Chemotherapy_Administration = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1027", null);

    [CqlValueSetDefinition("Office Visit", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1001", valueSetVersion: null)]
    public CqlValueSet Office_Visit(CqlContext _) => _Office_Visit;
    private static readonly CqlValueSet _Office_Visit = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1001", null);

    [CqlValueSetDefinition("Radiation Treatment Management", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1026", valueSetVersion: null)]
    public CqlValueSet Radiation_Treatment_Management(CqlContext _) => _Radiation_Treatment_Management;
    private static readonly CqlValueSet _Radiation_Treatment_Management = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1026", null);

    [CqlValueSetDefinition("Standardized Pain Assessment Tool", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1028", valueSetVersion: null)]
    public CqlValueSet Standardized_Pain_Assessment_Tool(CqlContext _) => _Standardized_Pain_Assessment_Tool;
    private static readonly CqlValueSet _Standardized_Pain_Assessment_Tool = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1028", null);

    #endregion ValueSets

    #region Codes

    [CqlCodeDefinition("Radiation treatment management, 5 treatments", codeId: "77427", codeSystem: "http://www.ama-assn.org/go/cpt")]
    public CqlCode Radiation_treatment_management__5_treatments(CqlContext _) => _Radiation_treatment_management__5_treatments;
    private static readonly CqlCode _Radiation_treatment_management__5_treatments = new CqlCode("77427", "http://www.ama-assn.org/go/cpt", default, default);

    #endregion Codes

    #region CodeSystems

    [CqlCodeSystemDefinition("CPT")]
    public CqlCodeSystem CPT(CqlContext _) => _CPT;
    private static readonly CqlCodeSystem _CPT = new CqlCodeSystem();

    #endregion CodeSystems

    #region Parameters

    [CqlParameterDefinition("Measurement Period")]
    public CqlInterval<CqlDateTime> Measurement_Period(CqlContext context)
    {
        CqlDateTime lzzzzzzzzzzzzzzzzzzb_ = context.Operators.DateTime(2025, 1, 1, 0, 0, 0, 0, 0.0m);
        CqlDateTime lzzzzzzzzzzzzzzzzzzc_ = context.Operators.DateTime(2025, 12, 31, 23, 59, 59, 999, 0.0m);
        CqlInterval<CqlDateTime> lzzzzzzzzzzzzzzzzzzd_ = context.Operators.Interval(lzzzzzzzzzzzzzzzzzzb_, lzzzzzzzzzzzzzzzzzzc_, true, true);
        object lzzzzzzzzzzzzzzzzzze_ = context.ResolveParameter("OncologyPainIntensityQuantifiedFHIR-0.1.000", "Measurement Period", lzzzzzzzzzzzzzzzzzzd_);

        return (CqlInterval<CqlDateTime>)lzzzzzzzzzzzzzzzzzze_;
    }


    #endregion Parameters

    #region Expressions

    [CqlExpressionDefinition("Patient")]
    public Patient Patient(CqlContext context)
    {
        IEnumerable<Patient> lzzzzzzzzzzzzzzzzzzf_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-patient"));
        Patient lzzzzzzzzzzzzzzzzzzg_ = context.Operators.SingletonFrom<Patient>(lzzzzzzzzzzzzzzzzzzf_);

        return lzzzzzzzzzzzzzzzzzzg_;
    }


    [CqlExpressionDefinition("Chemotherapy Within 31 Days Prior and During Measurement Period")]
    public IEnumerable<Procedure> Chemotherapy_Within_31_Days_Prior_and_During_Measurement_Period(CqlContext context)
    {
        CqlValueSet lzzzzzzzzzzzzzzzzzzh_ = this.Chemotherapy_Administration(context);
        IEnumerable<Procedure> lzzzzzzzzzzzzzzzzzzi_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, lzzzzzzzzzzzzzzzzzzh_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
        bool? lzzzzzzzzzzzzzzzzzzj_(Procedure ChemoAdministration)
        {
            CqlInterval<CqlDateTime> lzzzzzzzzzzzzzzzzzzl_ = this.Measurement_Period(context);
            CqlDateTime lzzzzzzzzzzzzzzzzzzm_ = context.Operators.Start(lzzzzzzzzzzzzzzzzzzl_);
            CqlQuantity lzzzzzzzzzzzzzzzzzzn_ = context.Operators.Quantity(31m, "days");
            CqlDateTime lzzzzzzzzzzzzzzzzzzo_ = context.Operators.Subtract(lzzzzzzzzzzzzzzzzzzm_, lzzzzzzzzzzzzzzzzzzn_);
            CqlDateTime lzzzzzzzzzzzzzzzzzzq_ = context.Operators.End(lzzzzzzzzzzzzzzzzzzl_);
            CqlInterval<CqlDateTime> lzzzzzzzzzzzzzzzzzzr_ = context.Operators.Interval(lzzzzzzzzzzzzzzzzzzo_, lzzzzzzzzzzzzzzzzzzq_, true, true);
            DataType lzzzzzzzzzzzzzzzzzzs_ = ChemoAdministration?.Performed;
            object lzzzzzzzzzzzzzzzzzzt_ = FHIRHelpers_4_4_000.Instance.ToValue(context, lzzzzzzzzzzzzzzzzzzs_);
            CqlInterval<CqlDateTime> lzzzzzzzzzzzzzzzzzzu_ = QICoreCommon_2_1_000.Instance.toInterval(context, lzzzzzzzzzzzzzzzzzzt_);
            bool? lzzzzzzzzzzzzzzzzzzv_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(lzzzzzzzzzzzzzzzzzzr_, lzzzzzzzzzzzzzzzzzzu_, default);
            Code<EventStatus> lzzzzzzzzzzzzzzzzzzw_ = ChemoAdministration?.StatusElement;
            EventStatus? lzzzzzzzzzzzzzzzzzzx_ = lzzzzzzzzzzzzzzzzzzw_?.Value;
            string lzzzzzzzzzzzzzzzzzzy_ = context.Operators.Convert<string>(lzzzzzzzzzzzzzzzzzzx_);
            bool? lzzzzzzzzzzzzzzzzzzz_ = context.Operators.Equal(lzzzzzzzzzzzzzzzzzzy_, "completed");
            bool? mzzzzzzzzzzzzzzzzzza_ = context.Operators.And(lzzzzzzzzzzzzzzzzzzv_, lzzzzzzzzzzzzzzzzzzz_);

            return mzzzzzzzzzzzzzzzzzza_;
        };
        IEnumerable<Procedure> lzzzzzzzzzzzzzzzzzzk_ = context.Operators.Where<Procedure>(lzzzzzzzzzzzzzzzzzzi_, lzzzzzzzzzzzzzzzzzzj_);

        return lzzzzzzzzzzzzzzzzzzk_;
    }


    [CqlExpressionDefinition("Face to Face or Telehealth Encounter with Ongoing Chemotherapy")]
    public IEnumerable<Encounter> Face_to_Face_or_Telehealth_Encounter_with_Ongoing_Chemotherapy(CqlContext context)
    {
        CqlValueSet mzzzzzzzzzzzzzzzzzzb_ = this.Office_Visit(context);
        IEnumerable<Encounter> mzzzzzzzzzzzzzzzzzzc_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, mzzzzzzzzzzzzzzzzzzb_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Procedure> mzzzzzzzzzzzzzzzzzzd_ = this.Chemotherapy_Within_31_Days_Prior_and_During_Measurement_Period(context);
        CqlValueSet mzzzzzzzzzzzzzzzzzzf_ = this.Cancer(context);
        IEnumerable<Condition> mzzzzzzzzzzzzzzzzzzg_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, mzzzzzzzzzzzzzzzzzzf_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        IEnumerable<ValueTuple<Encounter, Procedure, Procedure, Condition>> mzzzzzzzzzzzzzzzzzzh_ = context.Operators.CrossJoin<Encounter, Procedure, Procedure, Condition>(mzzzzzzzzzzzzzzzzzzc_, mzzzzzzzzzzzzzzzzzzd_, mzzzzzzzzzzzzzzzzzzd_, mzzzzzzzzzzzzzzzzzzg_);
        (CqlTupleMetadata, Encounter FaceToFaceOrTelehealthEncounter, Procedure ChemoBeforeEncounter, Procedure ChemoAfterEncounter, Condition Cancer)? mzzzzzzzzzzzzzzzzzzi_(ValueTuple<Encounter, Procedure, Procedure, Condition> _valueTuple)
        {
            (CqlTupleMetadata, Encounter FaceToFaceOrTelehealthEncounter, Procedure ChemoBeforeEncounter, Procedure ChemoAfterEncounter, Condition Cancer)? mzzzzzzzzzzzzzzzzzzp_ = (CqlTupleMetadata_GEQGUKVdHYQAZdGbSEBAPcHZR, _valueTuple.Item1, _valueTuple.Item2, _valueTuple.Item3, _valueTuple.Item4);

            return mzzzzzzzzzzzzzzzzzzp_;
        };
        IEnumerable<(CqlTupleMetadata, Encounter FaceToFaceOrTelehealthEncounter, Procedure ChemoBeforeEncounter, Procedure ChemoAfterEncounter, Condition Cancer)?> mzzzzzzzzzzzzzzzzzzj_ = context.Operators.Select<ValueTuple<Encounter, Procedure, Procedure, Condition>, (CqlTupleMetadata, Encounter FaceToFaceOrTelehealthEncounter, Procedure ChemoBeforeEncounter, Procedure ChemoAfterEncounter, Condition Cancer)?>(mzzzzzzzzzzzzzzzzzzh_, mzzzzzzzzzzzzzzzzzzi_);
        bool? mzzzzzzzzzzzzzzzzzzk_((CqlTupleMetadata, Encounter FaceToFaceOrTelehealthEncounter, Procedure ChemoBeforeEncounter, Procedure ChemoAfterEncounter, Condition Cancer)? tuple_cibligzrihjljqmithporoase)
        {
            bool? mzzzzzzzzzzzzzzzzzzq_ = QICoreCommon_2_1_000.Instance.isActive(context, tuple_cibligzrihjljqmithporoase?.Cancer);
            CqlInterval<CqlDateTime> mzzzzzzzzzzzzzzzzzzr_ = QICoreCommon_2_1_000.Instance.prevalenceInterval(context, tuple_cibligzrihjljqmithporoase?.Cancer);
            Period mzzzzzzzzzzzzzzzzzzs_ = tuple_cibligzrihjljqmithporoase?.FaceToFaceOrTelehealthEncounter?.Period;
            CqlInterval<CqlDateTime> mzzzzzzzzzzzzzzzzzzt_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, mzzzzzzzzzzzzzzzzzzs_);
            bool? mzzzzzzzzzzzzzzzzzzu_ = context.Operators.Overlaps(mzzzzzzzzzzzzzzzzzzr_, mzzzzzzzzzzzzzzzzzzt_, default);
            bool? mzzzzzzzzzzzzzzzzzzv_ = context.Operators.And(mzzzzzzzzzzzzzzzzzzq_, mzzzzzzzzzzzzzzzzzzu_);
            DataType mzzzzzzzzzzzzzzzzzzw_ = tuple_cibligzrihjljqmithporoase?.ChemoBeforeEncounter?.Performed;
            object mzzzzzzzzzzzzzzzzzzx_ = FHIRHelpers_4_4_000.Instance.ToValue(context, mzzzzzzzzzzzzzzzzzzw_);
            CqlInterval<CqlDateTime> mzzzzzzzzzzzzzzzzzzy_ = QICoreCommon_2_1_000.Instance.toInterval(context, mzzzzzzzzzzzzzzzzzzx_);
            CqlDateTime mzzzzzzzzzzzzzzzzzzz_ = context.Operators.Start(mzzzzzzzzzzzzzzzzzzy_);
            CqlInterval<CqlDateTime> nzzzzzzzzzzzzzzzzzzb_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, mzzzzzzzzzzzzzzzzzzs_);
            CqlDateTime nzzzzzzzzzzzzzzzzzzc_ = context.Operators.End(nzzzzzzzzzzzzzzzzzzb_);
            CqlQuantity nzzzzzzzzzzzzzzzzzzd_ = context.Operators.Quantity(30m, "days");
            CqlDateTime nzzzzzzzzzzzzzzzzzze_ = context.Operators.Subtract(nzzzzzzzzzzzzzzzzzzc_, nzzzzzzzzzzzzzzzzzzd_);
            CqlInterval<CqlDateTime> nzzzzzzzzzzzzzzzzzzg_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, mzzzzzzzzzzzzzzzzzzs_);
            CqlDateTime nzzzzzzzzzzzzzzzzzzh_ = context.Operators.End(nzzzzzzzzzzzzzzzzzzg_);
            CqlInterval<CqlDateTime> nzzzzzzzzzzzzzzzzzzi_ = context.Operators.Interval(nzzzzzzzzzzzzzzzzzze_, nzzzzzzzzzzzzzzzzzzh_, true, true);
            bool? nzzzzzzzzzzzzzzzzzzj_ = context.Operators.In<CqlDateTime>(mzzzzzzzzzzzzzzzzzzz_, nzzzzzzzzzzzzzzzzzzi_, "day");
            CqlInterval<CqlDateTime> nzzzzzzzzzzzzzzzzzzl_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, mzzzzzzzzzzzzzzzzzzs_);
            CqlDateTime nzzzzzzzzzzzzzzzzzzm_ = context.Operators.End(nzzzzzzzzzzzzzzzzzzl_);
            bool? nzzzzzzzzzzzzzzzzzzn_ = context.Operators.Not((bool?)(nzzzzzzzzzzzzzzzzzzm_ is null));
            bool? nzzzzzzzzzzzzzzzzzzo_ = context.Operators.And(nzzzzzzzzzzzzzzzzzzj_, nzzzzzzzzzzzzzzzzzzn_);
            bool? nzzzzzzzzzzzzzzzzzzp_ = context.Operators.And(mzzzzzzzzzzzzzzzzzzv_, nzzzzzzzzzzzzzzzzzzo_);
            DataType nzzzzzzzzzzzzzzzzzzq_ = tuple_cibligzrihjljqmithporoase?.ChemoAfterEncounter?.Performed;
            object nzzzzzzzzzzzzzzzzzzr_ = FHIRHelpers_4_4_000.Instance.ToValue(context, nzzzzzzzzzzzzzzzzzzq_);
            CqlInterval<CqlDateTime> nzzzzzzzzzzzzzzzzzzs_ = QICoreCommon_2_1_000.Instance.toInterval(context, nzzzzzzzzzzzzzzzzzzr_);
            CqlDateTime nzzzzzzzzzzzzzzzzzzt_ = context.Operators.Start(nzzzzzzzzzzzzzzzzzzs_);
            CqlInterval<CqlDateTime> nzzzzzzzzzzzzzzzzzzv_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, mzzzzzzzzzzzzzzzzzzs_);
            CqlDateTime nzzzzzzzzzzzzzzzzzzw_ = context.Operators.End(nzzzzzzzzzzzzzzzzzzv_);
            CqlInterval<CqlDateTime> nzzzzzzzzzzzzzzzzzzy_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, mzzzzzzzzzzzzzzzzzzs_);
            CqlDateTime nzzzzzzzzzzzzzzzzzzz_ = context.Operators.End(nzzzzzzzzzzzzzzzzzzy_);
            CqlDateTime ozzzzzzzzzzzzzzzzzzb_ = context.Operators.Add(nzzzzzzzzzzzzzzzzzzz_, nzzzzzzzzzzzzzzzzzzd_);
            CqlInterval<CqlDateTime> ozzzzzzzzzzzzzzzzzzc_ = context.Operators.Interval(nzzzzzzzzzzzzzzzzzzw_, ozzzzzzzzzzzzzzzzzzb_, true, true);
            bool? ozzzzzzzzzzzzzzzzzzd_ = context.Operators.In<CqlDateTime>(nzzzzzzzzzzzzzzzzzzt_, ozzzzzzzzzzzzzzzzzzc_, "day");
            CqlInterval<CqlDateTime> ozzzzzzzzzzzzzzzzzzf_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, mzzzzzzzzzzzzzzzzzzs_);
            CqlDateTime ozzzzzzzzzzzzzzzzzzg_ = context.Operators.End(ozzzzzzzzzzzzzzzzzzf_);
            bool? ozzzzzzzzzzzzzzzzzzh_ = context.Operators.Not((bool?)(ozzzzzzzzzzzzzzzzzzg_ is null));
            bool? ozzzzzzzzzzzzzzzzzzi_ = context.Operators.And(ozzzzzzzzzzzzzzzzzzd_, ozzzzzzzzzzzzzzzzzzh_);
            bool? ozzzzzzzzzzzzzzzzzzj_ = context.Operators.And(nzzzzzzzzzzzzzzzzzzp_, ozzzzzzzzzzzzzzzzzzi_);
            object ozzzzzzzzzzzzzzzzzzl_ = FHIRHelpers_4_4_000.Instance.ToValue(context, nzzzzzzzzzzzzzzzzzzq_);
            CqlInterval<CqlDateTime> ozzzzzzzzzzzzzzzzzzm_ = QICoreCommon_2_1_000.Instance.toInterval(context, ozzzzzzzzzzzzzzzzzzl_);
            object ozzzzzzzzzzzzzzzzzzo_ = FHIRHelpers_4_4_000.Instance.ToValue(context, mzzzzzzzzzzzzzzzzzzw_);
            CqlInterval<CqlDateTime> ozzzzzzzzzzzzzzzzzzp_ = QICoreCommon_2_1_000.Instance.toInterval(context, ozzzzzzzzzzzzzzzzzzo_);
            bool? ozzzzzzzzzzzzzzzzzzq_ = context.Operators.SameAs<CqlDateTime>(ozzzzzzzzzzzzzzzzzzm_, ozzzzzzzzzzzzzzzzzzp_, "day");
            bool? ozzzzzzzzzzzzzzzzzzr_ = context.Operators.Not(ozzzzzzzzzzzzzzzzzzq_);
            bool? ozzzzzzzzzzzzzzzzzzs_ = context.Operators.And(ozzzzzzzzzzzzzzzzzzj_, ozzzzzzzzzzzzzzzzzzr_);
            CqlInterval<CqlDateTime> ozzzzzzzzzzzzzzzzzzt_ = this.Measurement_Period(context);
            CqlInterval<CqlDateTime> ozzzzzzzzzzzzzzzzzzv_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, mzzzzzzzzzzzzzzzzzzs_);
            bool? ozzzzzzzzzzzzzzzzzzw_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(ozzzzzzzzzzzzzzzzzzt_, ozzzzzzzzzzzzzzzzzzv_, default);
            bool? ozzzzzzzzzzzzzzzzzzx_ = context.Operators.And(ozzzzzzzzzzzzzzzzzzs_, ozzzzzzzzzzzzzzzzzzw_);
            Code<Encounter.EncounterStatus> ozzzzzzzzzzzzzzzzzzy_ = tuple_cibligzrihjljqmithporoase?.FaceToFaceOrTelehealthEncounter?.StatusElement;
            Encounter.EncounterStatus? ozzzzzzzzzzzzzzzzzzz_ = ozzzzzzzzzzzzzzzzzzy_?.Value;
            Code<Encounter.EncounterStatus> pzzzzzzzzzzzzzzzzzza_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(ozzzzzzzzzzzzzzzzzzz_);
            bool? pzzzzzzzzzzzzzzzzzzb_ = context.Operators.Equal(pzzzzzzzzzzzzzzzzzza_, "finished");
            bool? pzzzzzzzzzzzzzzzzzzc_ = context.Operators.And(ozzzzzzzzzzzzzzzzzzx_, pzzzzzzzzzzzzzzzzzzb_);

            return pzzzzzzzzzzzzzzzzzzc_;
        };
        IEnumerable<(CqlTupleMetadata, Encounter FaceToFaceOrTelehealthEncounter, Procedure ChemoBeforeEncounter, Procedure ChemoAfterEncounter, Condition Cancer)?> mzzzzzzzzzzzzzzzzzzl_ = context.Operators.Where<(CqlTupleMetadata, Encounter FaceToFaceOrTelehealthEncounter, Procedure ChemoBeforeEncounter, Procedure ChemoAfterEncounter, Condition Cancer)?>(mzzzzzzzzzzzzzzzzzzj_, mzzzzzzzzzzzzzzzzzzk_);
        Encounter mzzzzzzzzzzzzzzzzzzm_((CqlTupleMetadata, Encounter FaceToFaceOrTelehealthEncounter, Procedure ChemoBeforeEncounter, Procedure ChemoAfterEncounter, Condition Cancer)? tuple_cibligzrihjljqmithporoase) =>
            tuple_cibligzrihjljqmithporoase?.FaceToFaceOrTelehealthEncounter;
        IEnumerable<Encounter> mzzzzzzzzzzzzzzzzzzn_ = context.Operators.Select<(CqlTupleMetadata, Encounter FaceToFaceOrTelehealthEncounter, Procedure ChemoBeforeEncounter, Procedure ChemoAfterEncounter, Condition Cancer)?, Encounter>(mzzzzzzzzzzzzzzzzzzl_, mzzzzzzzzzzzzzzzzzzm_);
        IEnumerable<Encounter> mzzzzzzzzzzzzzzzzzzo_ = context.Operators.Distinct<Encounter>(mzzzzzzzzzzzzzzzzzzn_);

        return mzzzzzzzzzzzzzzzzzzo_;
    }


    [CqlExpressionDefinition("Initial Population 1")]
    public IEnumerable<Encounter> Initial_Population_1(CqlContext context)
    {
        IEnumerable<Encounter> pzzzzzzzzzzzzzzzzzzd_ = this.Face_to_Face_or_Telehealth_Encounter_with_Ongoing_Chemotherapy(context);

        return pzzzzzzzzzzzzzzzzzzd_;
    }


    [CqlExpressionDefinition("Denominator 1")]
    public IEnumerable<Encounter> Denominator_1(CqlContext context)
    {
        IEnumerable<Encounter> pzzzzzzzzzzzzzzzzzze_ = this.Initial_Population_1(context);

        return pzzzzzzzzzzzzzzzzzze_;
    }


    [CqlExpressionDefinition("Radiation Treatment Management During Measurement Period with Cancer Diagnosis")]
    public IEnumerable<Encounter> Radiation_Treatment_Management_During_Measurement_Period_with_Cancer_Diagnosis(CqlContext context)
    {
        CqlValueSet pzzzzzzzzzzzzzzzzzzf_ = this.Radiation_Treatment_Management(context);
        IEnumerable<Encounter> pzzzzzzzzzzzzzzzzzzg_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, pzzzzzzzzzzzzzzzzzzf_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> pzzzzzzzzzzzzzzzzzzh_(Encounter RadiationTreatmentManagement)
        {
            CqlValueSet pzzzzzzzzzzzzzzzzzzl_ = this.Cancer(context);
            IEnumerable<Condition> pzzzzzzzzzzzzzzzzzzm_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, pzzzzzzzzzzzzzzzzzzl_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
            bool? pzzzzzzzzzzzzzzzzzzn_(Condition Cancer)
            {
                bool? pzzzzzzzzzzzzzzzzzzr_ = QICoreCommon_2_1_000.Instance.isActive(context, Cancer);
                CqlInterval<CqlDateTime> pzzzzzzzzzzzzzzzzzzs_ = QICoreCommon_2_1_000.Instance.prevalenceInterval(context, Cancer);
                Period pzzzzzzzzzzzzzzzzzzt_ = RadiationTreatmentManagement?.Period;
                CqlInterval<CqlDateTime> pzzzzzzzzzzzzzzzzzzu_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, pzzzzzzzzzzzzzzzzzzt_);
                bool? pzzzzzzzzzzzzzzzzzzv_ = context.Operators.Overlaps(pzzzzzzzzzzzzzzzzzzs_, pzzzzzzzzzzzzzzzzzzu_, default);
                bool? pzzzzzzzzzzzzzzzzzzw_ = context.Operators.And(pzzzzzzzzzzzzzzzzzzr_, pzzzzzzzzzzzzzzzzzzv_);

                return pzzzzzzzzzzzzzzzzzzw_;
            };
            IEnumerable<Condition> pzzzzzzzzzzzzzzzzzzo_ = context.Operators.Where<Condition>(pzzzzzzzzzzzzzzzzzzm_, pzzzzzzzzzzzzzzzzzzn_);
            Encounter pzzzzzzzzzzzzzzzzzzp_(Condition Cancer) =>
                RadiationTreatmentManagement;
            IEnumerable<Encounter> pzzzzzzzzzzzzzzzzzzq_ = context.Operators.Select<Condition, Encounter>(pzzzzzzzzzzzzzzzzzzo_, pzzzzzzzzzzzzzzzzzzp_);

            return pzzzzzzzzzzzzzzzzzzq_;
        };
        IEnumerable<Encounter> pzzzzzzzzzzzzzzzzzzi_ = context.Operators.SelectMany<Encounter, Encounter>(pzzzzzzzzzzzzzzzzzzg_, pzzzzzzzzzzzzzzzzzzh_);
        bool? pzzzzzzzzzzzzzzzzzzj_(Encounter RadiationTreatmentManagement)
        {
            CqlInterval<CqlDateTime> pzzzzzzzzzzzzzzzzzzx_ = this.Measurement_Period(context);
            Period pzzzzzzzzzzzzzzzzzzy_ = RadiationTreatmentManagement?.Period;
            CqlInterval<CqlDateTime> pzzzzzzzzzzzzzzzzzzz_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, pzzzzzzzzzzzzzzzzzzy_);
            bool? qzzzzzzzzzzzzzzzzzza_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(pzzzzzzzzzzzzzzzzzzx_, pzzzzzzzzzzzzzzzzzzz_, default);
            Code<Encounter.EncounterStatus> qzzzzzzzzzzzzzzzzzzb_ = RadiationTreatmentManagement?.StatusElement;
            Encounter.EncounterStatus? qzzzzzzzzzzzzzzzzzzc_ = qzzzzzzzzzzzzzzzzzzb_?.Value;
            Code<Encounter.EncounterStatus> qzzzzzzzzzzzzzzzzzzd_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(qzzzzzzzzzzzzzzzzzzc_);
            bool? qzzzzzzzzzzzzzzzzzze_ = context.Operators.Equal(qzzzzzzzzzzzzzzzzzzd_, "finished");
            bool? qzzzzzzzzzzzzzzzzzzf_ = context.Operators.And(qzzzzzzzzzzzzzzzzzza_, qzzzzzzzzzzzzzzzzzze_);

            return qzzzzzzzzzzzzzzzzzzf_;
        };
        IEnumerable<Encounter> pzzzzzzzzzzzzzzzzzzk_ = context.Operators.Where<Encounter>(pzzzzzzzzzzzzzzzzzzi_, pzzzzzzzzzzzzzzzzzzj_);

        return pzzzzzzzzzzzzzzzzzzk_;
    }


    [CqlExpressionDefinition("Initial Population 2")]
    public IEnumerable<Encounter> Initial_Population_2(CqlContext context)
    {
        IEnumerable<Encounter> qzzzzzzzzzzzzzzzzzzg_ = this.Radiation_Treatment_Management_During_Measurement_Period_with_Cancer_Diagnosis(context);

        return qzzzzzzzzzzzzzzzzzzg_;
    }


    [CqlExpressionDefinition("Denominator 2")]
    public IEnumerable<Encounter> Denominator_2(CqlContext context)
    {
        IEnumerable<Encounter> qzzzzzzzzzzzzzzzzzzh_ = this.Initial_Population_2(context);

        return qzzzzzzzzzzzzzzzzzzh_;
    }


    [CqlExpressionDefinition("Standard Pain Assessment with Result")]
    public IEnumerable<Observation> Standard_Pain_Assessment_with_Result(CqlContext context)
    {
        CqlValueSet qzzzzzzzzzzzzzzzzzzi_ = this.Standardized_Pain_Assessment_Tool(context);
        IEnumerable<Observation> qzzzzzzzzzzzzzzzzzzj_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, qzzzzzzzzzzzzzzzzzzi_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        bool? qzzzzzzzzzzzzzzzzzzk_(Observation AssessedPain)
        {
            DataType qzzzzzzzzzzzzzzzzzzm_ = AssessedPain?.Value;
            object qzzzzzzzzzzzzzzzzzzn_ = FHIRHelpers_4_4_000.Instance.ToValue(context, qzzzzzzzzzzzzzzzzzzm_);
            bool? qzzzzzzzzzzzzzzzzzzo_ = context.Operators.Not((bool?)(qzzzzzzzzzzzzzzzzzzn_ is null));
            Code<ObservationStatus> qzzzzzzzzzzzzzzzzzzp_ = AssessedPain?.StatusElement;
            ObservationStatus? qzzzzzzzzzzzzzzzzzzq_ = qzzzzzzzzzzzzzzzzzzp_?.Value;
            Code<ObservationStatus> qzzzzzzzzzzzzzzzzzzr_ = context.Operators.Convert<Code<ObservationStatus>>(qzzzzzzzzzzzzzzzzzzq_);
            bool? qzzzzzzzzzzzzzzzzzzs_ = context.Operators.Equal(qzzzzzzzzzzzzzzzzzzr_, "final");
            bool? qzzzzzzzzzzzzzzzzzzt_ = context.Operators.And(qzzzzzzzzzzzzzzzzzzo_, qzzzzzzzzzzzzzzzzzzs_);

            return qzzzzzzzzzzzzzzzzzzt_;
        };
        IEnumerable<Observation> qzzzzzzzzzzzzzzzzzzl_ = context.Operators.Where<Observation>(qzzzzzzzzzzzzzzzzzzj_, qzzzzzzzzzzzzzzzzzzk_);

        return qzzzzzzzzzzzzzzzzzzl_;
    }


    [CqlExpressionDefinition("Numerator 1")]
    public IEnumerable<Encounter> Numerator_1(CqlContext context)
    {
        IEnumerable<Encounter> qzzzzzzzzzzzzzzzzzzu_ = this.Face_to_Face_or_Telehealth_Encounter_with_Ongoing_Chemotherapy(context);
        IEnumerable<Encounter> qzzzzzzzzzzzzzzzzzzv_(Encounter FaceToFaceOrTelehealthEncounterWithChemo)
        {
            IEnumerable<Observation> qzzzzzzzzzzzzzzzzzzx_ = this.Standard_Pain_Assessment_with_Result(context);
            bool? qzzzzzzzzzzzzzzzzzzy_(Observation PainAssessed)
            {
                Period rzzzzzzzzzzzzzzzzzzc_ = FaceToFaceOrTelehealthEncounterWithChemo?.Period;
                CqlInterval<CqlDateTime> rzzzzzzzzzzzzzzzzzzd_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, rzzzzzzzzzzzzzzzzzzc_);
                DataType rzzzzzzzzzzzzzzzzzze_ = PainAssessed?.Effective;
                object rzzzzzzzzzzzzzzzzzzf_ = FHIRHelpers_4_4_000.Instance.ToValue(context, rzzzzzzzzzzzzzzzzzze_);
                CqlInterval<CqlDateTime> rzzzzzzzzzzzzzzzzzzg_ = QICoreCommon_2_1_000.Instance.toInterval(context, rzzzzzzzzzzzzzzzzzzf_);
                bool? rzzzzzzzzzzzzzzzzzzh_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(rzzzzzzzzzzzzzzzzzzd_, rzzzzzzzzzzzzzzzzzzg_, default);

                return rzzzzzzzzzzzzzzzzzzh_;
            };
            IEnumerable<Observation> qzzzzzzzzzzzzzzzzzzz_ = context.Operators.Where<Observation>(qzzzzzzzzzzzzzzzzzzx_, qzzzzzzzzzzzzzzzzzzy_);
            Encounter rzzzzzzzzzzzzzzzzzza_(Observation PainAssessed) =>
                FaceToFaceOrTelehealthEncounterWithChemo;
            IEnumerable<Encounter> rzzzzzzzzzzzzzzzzzzb_ = context.Operators.Select<Observation, Encounter>(qzzzzzzzzzzzzzzzzzzz_, rzzzzzzzzzzzzzzzzzza_);

            return rzzzzzzzzzzzzzzzzzzb_;
        };
        IEnumerable<Encounter> qzzzzzzzzzzzzzzzzzzw_ = context.Operators.SelectMany<Encounter, Encounter>(qzzzzzzzzzzzzzzzzzzu_, qzzzzzzzzzzzzzzzzzzv_);

        return qzzzzzzzzzzzzzzzzzzw_;
    }


    [CqlExpressionDefinition("Numerator 2")]
    public IEnumerable<Encounter> Numerator_2(CqlContext context)
    {
        IEnumerable<Encounter> rzzzzzzzzzzzzzzzzzzi_ = this.Radiation_Treatment_Management_During_Measurement_Period_with_Cancer_Diagnosis(context);
        IEnumerable<Encounter> rzzzzzzzzzzzzzzzzzzj_(Encounter RadiationManagementEncounter)
        {
            IEnumerable<Observation> rzzzzzzzzzzzzzzzzzzl_ = this.Standard_Pain_Assessment_with_Result(context);
            bool? rzzzzzzzzzzzzzzzzzzm_(Observation PainAssessed)
            {
                bool? rzzzzzzzzzzzzzzzzzzq_()
                {
                    bool rzzzzzzzzzzzzzzzzzzr_()
                    {
                        List<CodeableConcept> rzzzzzzzzzzzzzzzzzzs_ = RadiationManagementEncounter?.Type;
                        CqlConcept rzzzzzzzzzzzzzzzzzzt_(CodeableConcept @this)
                        {
                            CqlConcept rzzzzzzzzzzzzzzzzzzy_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);

                            return rzzzzzzzzzzzzzzzzzzy_;
                        };
                        IEnumerable<CqlConcept> rzzzzzzzzzzzzzzzzzzu_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)rzzzzzzzzzzzzzzzzzzs_, rzzzzzzzzzzzzzzzzzzt_);
                        bool? rzzzzzzzzzzzzzzzzzzv_(CqlConcept RadiationManagement)
                        {
                            CqlCode rzzzzzzzzzzzzzzzzzzz_ = this.Radiation_treatment_management__5_treatments(context);
                            CqlConcept szzzzzzzzzzzzzzzzzza_ = context.Operators.ConvertCodeToConcept(rzzzzzzzzzzzzzzzzzzz_);
                            bool? szzzzzzzzzzzzzzzzzzb_ = context.Operators.Equivalent(RadiationManagement, szzzzzzzzzzzzzzzzzza_);

                            return szzzzzzzzzzzzzzzzzzb_;
                        };
                        IEnumerable<CqlConcept> rzzzzzzzzzzzzzzzzzzw_ = context.Operators.Where<CqlConcept>(rzzzzzzzzzzzzzzzzzzu_, rzzzzzzzzzzzzzzzzzzv_);
                        bool? rzzzzzzzzzzzzzzzzzzx_ = context.Operators.Exists<CqlConcept>(rzzzzzzzzzzzzzzzzzzw_);

                        return rzzzzzzzzzzzzzzzzzzx_ ?? false;
                    };
                    if (rzzzzzzzzzzzzzzzzzzr_())
                    {
                        DataType szzzzzzzzzzzzzzzzzzc_ = PainAssessed?.Effective;
                        object szzzzzzzzzzzzzzzzzzd_ = FHIRHelpers_4_4_000.Instance.ToValue(context, szzzzzzzzzzzzzzzzzzc_);
                        CqlInterval<CqlDateTime> szzzzzzzzzzzzzzzzzze_ = QICoreCommon_2_1_000.Instance.toInterval(context, szzzzzzzzzzzzzzzzzzd_);
                        CqlDateTime szzzzzzzzzzzzzzzzzzf_ = context.Operators.End(szzzzzzzzzzzzzzzzzze_);
                        Period szzzzzzzzzzzzzzzzzzg_ = RadiationManagementEncounter?.Period;
                        CqlInterval<CqlDateTime> szzzzzzzzzzzzzzzzzzh_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, szzzzzzzzzzzzzzzzzzg_);
                        CqlDateTime szzzzzzzzzzzzzzzzzzi_ = context.Operators.Start(szzzzzzzzzzzzzzzzzzh_);
                        CqlQuantity szzzzzzzzzzzzzzzzzzj_ = context.Operators.Quantity(6m, "days");
                        CqlDateTime szzzzzzzzzzzzzzzzzzk_ = context.Operators.Subtract(szzzzzzzzzzzzzzzzzzi_, szzzzzzzzzzzzzzzzzzj_);
                        CqlInterval<CqlDateTime> szzzzzzzzzzzzzzzzzzm_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, szzzzzzzzzzzzzzzzzzg_);
                        CqlDateTime szzzzzzzzzzzzzzzzzzn_ = context.Operators.Start(szzzzzzzzzzzzzzzzzzm_);
                        CqlInterval<CqlDateTime> szzzzzzzzzzzzzzzzzzo_ = context.Operators.Interval(szzzzzzzzzzzzzzzzzzk_, szzzzzzzzzzzzzzzzzzn_, true, true);
                        bool? szzzzzzzzzzzzzzzzzzp_ = context.Operators.In<CqlDateTime>(szzzzzzzzzzzzzzzzzzf_, szzzzzzzzzzzzzzzzzzo_, "day");
                        CqlInterval<CqlDateTime> szzzzzzzzzzzzzzzzzzr_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, szzzzzzzzzzzzzzzzzzg_);
                        CqlDateTime szzzzzzzzzzzzzzzzzzs_ = context.Operators.Start(szzzzzzzzzzzzzzzzzzr_);
                        bool? szzzzzzzzzzzzzzzzzzt_ = context.Operators.Not((bool?)(szzzzzzzzzzzzzzzzzzs_ is null));
                        bool? szzzzzzzzzzzzzzzzzzu_ = context.Operators.And(szzzzzzzzzzzzzzzzzzp_, szzzzzzzzzzzzzzzzzzt_);

                        return szzzzzzzzzzzzzzzzzzu_;
                    }
                    else
                    {
                        Period szzzzzzzzzzzzzzzzzzv_ = RadiationManagementEncounter?.Period;
                        CqlInterval<CqlDateTime> szzzzzzzzzzzzzzzzzzw_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, szzzzzzzzzzzzzzzzzzv_);
                        DataType szzzzzzzzzzzzzzzzzzx_ = PainAssessed?.Effective;
                        object szzzzzzzzzzzzzzzzzzy_ = FHIRHelpers_4_4_000.Instance.ToValue(context, szzzzzzzzzzzzzzzzzzx_);
                        CqlInterval<CqlDateTime> szzzzzzzzzzzzzzzzzzz_ = QICoreCommon_2_1_000.Instance.toInterval(context, szzzzzzzzzzzzzzzzzzy_);
                        bool? tzzzzzzzzzzzzzzzzzza_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(szzzzzzzzzzzzzzzzzzw_, szzzzzzzzzzzzzzzzzzz_, "day");

                        return tzzzzzzzzzzzzzzzzzza_;
                    }
                };

                return rzzzzzzzzzzzzzzzzzzq_();
            };
            IEnumerable<Observation> rzzzzzzzzzzzzzzzzzzn_ = context.Operators.Where<Observation>(rzzzzzzzzzzzzzzzzzzl_, rzzzzzzzzzzzzzzzzzzm_);
            Encounter rzzzzzzzzzzzzzzzzzzo_(Observation PainAssessed) =>
                RadiationManagementEncounter;
            IEnumerable<Encounter> rzzzzzzzzzzzzzzzzzzp_ = context.Operators.Select<Observation, Encounter>(rzzzzzzzzzzzzzzzzzzn_, rzzzzzzzzzzzzzzzzzzo_);

            return rzzzzzzzzzzzzzzzzzzp_;
        };
        IEnumerable<Encounter> rzzzzzzzzzzzzzzzzzzk_ = context.Operators.SelectMany<Encounter, Encounter>(rzzzzzzzzzzzzzzzzzzi_, rzzzzzzzzzzzzzzzzzzj_);

        return rzzzzzzzzzzzzzzzzzzk_;
    }


    [CqlExpressionDefinition("SDE Ethnicity")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Ethnicity(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? tzzzzzzzzzzzzzzzzzzb_ = SupplementalDataElements_3_5_000.Instance.SDE_Ethnicity(context);

        return tzzzzzzzzzzzzzzzzzzb_;
    }


    [CqlExpressionDefinition("SDE Payer")]
    public IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> SDE_Payer(CqlContext context)
    {
        IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> tzzzzzzzzzzzzzzzzzzc_ = SupplementalDataElements_3_5_000.Instance.SDE_Payer(context);

        return tzzzzzzzzzzzzzzzzzzc_;
    }


    [CqlExpressionDefinition("SDE Race")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Race(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? tzzzzzzzzzzzzzzzzzzd_ = SupplementalDataElements_3_5_000.Instance.SDE_Race(context);

        return tzzzzzzzzzzzzzzzzzzd_;
    }


    [CqlExpressionDefinition("SDE Sex")]
    public CqlCode SDE_Sex(CqlContext context)
    {
        CqlCode tzzzzzzzzzzzzzzzzzze_ = SupplementalDataElements_3_5_000.Instance.SDE_Sex(context);

        return tzzzzzzzzzzzzzzzzzze_;
    }


    #endregion Expressions

    #region CqlTupleMetadata Properties

    private static CqlTupleMetadata CqlTupleMetadata_GEQGUKVdHYQAZdGbSEBAPcHZR = new(
        [typeof(Encounter), typeof(Procedure), typeof(Procedure), typeof(Condition)],
        ["FaceToFaceOrTelehealthEncounter", "ChemoBeforeEncounter", "ChemoAfterEncounter", "Cancer"]);

    #endregion CqlTupleMetadata Properties

}
