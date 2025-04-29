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
        CqlDateTime kzzzzzzzzzzzzzzzg_ = context.Operators.DateTime(2025, 1, 1, 0, 0, 0, 0, 0.0m);
        CqlDateTime kzzzzzzzzzzzzzzzh_ = context.Operators.DateTime(2025, 12, 31, 23, 59, 59, 999, 0.0m);
        CqlInterval<CqlDateTime> kzzzzzzzzzzzzzzzi_ = context.Operators.Interval(kzzzzzzzzzzzzzzzg_, kzzzzzzzzzzzzzzzh_, true, true);
        object kzzzzzzzzzzzzzzzj_ = context.ResolveParameter("OncologyPainIntensityQuantifiedFHIR-0.1.000", "Measurement Period", kzzzzzzzzzzzzzzzi_);

        return (CqlInterval<CqlDateTime>)kzzzzzzzzzzzzzzzj_;
    }


    #endregion Parameters

    #region Expressions

    [CqlExpressionDefinition("Patient")]
    public Patient Patient(CqlContext context)
    {
        IEnumerable<Patient> kzzzzzzzzzzzzzzzk_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-patient"));
        Patient kzzzzzzzzzzzzzzzl_ = context.Operators.SingletonFrom<Patient>(kzzzzzzzzzzzzzzzk_);

        return kzzzzzzzzzzzzzzzl_;
    }


    [CqlExpressionDefinition("Chemotherapy Within 31 Days Prior and During Measurement Period")]
    public IEnumerable<Procedure> Chemotherapy_Within_31_Days_Prior_and_During_Measurement_Period(CqlContext context)
    {
        CqlValueSet kzzzzzzzzzzzzzzzm_ = this.Chemotherapy_Administration(context);
        IEnumerable<Procedure> kzzzzzzzzzzzzzzzn_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, kzzzzzzzzzzzzzzzm_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
        bool? kzzzzzzzzzzzzzzzo_(Procedure ChemoAdministration)
        {
            CqlInterval<CqlDateTime> kzzzzzzzzzzzzzzzq_ = this.Measurement_Period(context);
            CqlDateTime kzzzzzzzzzzzzzzzr_ = context.Operators.Start(kzzzzzzzzzzzzzzzq_);
            CqlQuantity kzzzzzzzzzzzzzzzs_ = context.Operators.Quantity(31m, "days");
            CqlDateTime kzzzzzzzzzzzzzzzt_ = context.Operators.Subtract(kzzzzzzzzzzzzzzzr_, kzzzzzzzzzzzzzzzs_);
            CqlDateTime kzzzzzzzzzzzzzzzv_ = context.Operators.End(kzzzzzzzzzzzzzzzq_);
            CqlInterval<CqlDateTime> kzzzzzzzzzzzzzzzw_ = context.Operators.Interval(kzzzzzzzzzzzzzzzt_, kzzzzzzzzzzzzzzzv_, true, true);
            DataType kzzzzzzzzzzzzzzzx_ = ChemoAdministration?.Performed;
            object kzzzzzzzzzzzzzzzy_ = FHIRHelpers_4_4_000.Instance.ToValue(context, kzzzzzzzzzzzzzzzx_);
            CqlInterval<CqlDateTime> kzzzzzzzzzzzzzzzz_ = QICoreCommon_2_1_000.Instance.toInterval(context, kzzzzzzzzzzzzzzzy_);
            bool? lzzzzzzzzzzzzzzza_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(kzzzzzzzzzzzzzzzw_, kzzzzzzzzzzzzzzzz_, default);
            Code<EventStatus> lzzzzzzzzzzzzzzzb_ = ChemoAdministration?.StatusElement;
            EventStatus? lzzzzzzzzzzzzzzzc_ = lzzzzzzzzzzzzzzzb_?.Value;
            string lzzzzzzzzzzzzzzzd_ = context.Operators.Convert<string>(lzzzzzzzzzzzzzzzc_);
            bool? lzzzzzzzzzzzzzzze_ = context.Operators.Equal(lzzzzzzzzzzzzzzzd_, "completed");
            bool? lzzzzzzzzzzzzzzzf_ = context.Operators.And(lzzzzzzzzzzzzzzza_, lzzzzzzzzzzzzzzze_);

            return lzzzzzzzzzzzzzzzf_;
        };
        IEnumerable<Procedure> kzzzzzzzzzzzzzzzp_ = context.Operators.Where<Procedure>(kzzzzzzzzzzzzzzzn_, kzzzzzzzzzzzzzzzo_);

        return kzzzzzzzzzzzzzzzp_;
    }


    [CqlExpressionDefinition("Face to Face or Telehealth Encounter with Ongoing Chemotherapy")]
    public IEnumerable<Encounter> Face_to_Face_or_Telehealth_Encounter_with_Ongoing_Chemotherapy(CqlContext context)
    {
        CqlValueSet lzzzzzzzzzzzzzzzg_ = this.Office_Visit(context);
        IEnumerable<Encounter> lzzzzzzzzzzzzzzzh_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, lzzzzzzzzzzzzzzzg_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Procedure> lzzzzzzzzzzzzzzzi_ = this.Chemotherapy_Within_31_Days_Prior_and_During_Measurement_Period(context);
        CqlValueSet lzzzzzzzzzzzzzzzk_ = this.Cancer(context);
        IEnumerable<Condition> lzzzzzzzzzzzzzzzl_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, lzzzzzzzzzzzzzzzk_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        IEnumerable<ValueTuple<Encounter, Procedure, Procedure, Condition>> lzzzzzzzzzzzzzzzm_ = context.Operators.CrossJoin<Encounter, Procedure, Procedure, Condition>(lzzzzzzzzzzzzzzzh_, lzzzzzzzzzzzzzzzi_, lzzzzzzzzzzzzzzzi_, lzzzzzzzzzzzzzzzl_);
        (CqlTupleMetadata, Encounter FaceToFaceOrTelehealthEncounter, Procedure ChemoBeforeEncounter, Procedure ChemoAfterEncounter, Condition Cancer)? lzzzzzzzzzzzzzzzn_(ValueTuple<Encounter, Procedure, Procedure, Condition> _valueTuple)
        {
            (CqlTupleMetadata, Encounter FaceToFaceOrTelehealthEncounter, Procedure ChemoBeforeEncounter, Procedure ChemoAfterEncounter, Condition Cancer)? lzzzzzzzzzzzzzzzu_ = (CqlTupleMetadata_GEQGUKVdHYQAZdGbSEBAPcHZR, _valueTuple.Item1, _valueTuple.Item2, _valueTuple.Item3, _valueTuple.Item4);

            return lzzzzzzzzzzzzzzzu_;
        };
        IEnumerable<(CqlTupleMetadata, Encounter FaceToFaceOrTelehealthEncounter, Procedure ChemoBeforeEncounter, Procedure ChemoAfterEncounter, Condition Cancer)?> lzzzzzzzzzzzzzzzo_ = context.Operators.Select<ValueTuple<Encounter, Procedure, Procedure, Condition>, (CqlTupleMetadata, Encounter FaceToFaceOrTelehealthEncounter, Procedure ChemoBeforeEncounter, Procedure ChemoAfterEncounter, Condition Cancer)?>(lzzzzzzzzzzzzzzzm_, lzzzzzzzzzzzzzzzn_);
        bool? lzzzzzzzzzzzzzzzp_((CqlTupleMetadata, Encounter FaceToFaceOrTelehealthEncounter, Procedure ChemoBeforeEncounter, Procedure ChemoAfterEncounter, Condition Cancer)? tuple_cibligzrihjljqmithporoase)
        {
            bool? lzzzzzzzzzzzzzzzv_ = QICoreCommon_2_1_000.Instance.isActive(context, tuple_cibligzrihjljqmithporoase?.Cancer);
            CqlInterval<CqlDateTime> lzzzzzzzzzzzzzzzw_ = QICoreCommon_2_1_000.Instance.prevalenceInterval(context, tuple_cibligzrihjljqmithporoase?.Cancer);
            Period lzzzzzzzzzzzzzzzx_ = tuple_cibligzrihjljqmithporoase?.FaceToFaceOrTelehealthEncounter?.Period;
            CqlInterval<CqlDateTime> lzzzzzzzzzzzzzzzy_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, lzzzzzzzzzzzzzzzx_);
            bool? lzzzzzzzzzzzzzzzz_ = context.Operators.Overlaps(lzzzzzzzzzzzzzzzw_, lzzzzzzzzzzzzzzzy_, default);
            bool? mzzzzzzzzzzzzzzza_ = context.Operators.And(lzzzzzzzzzzzzzzzv_, lzzzzzzzzzzzzzzzz_);
            DataType mzzzzzzzzzzzzzzzb_ = tuple_cibligzrihjljqmithporoase?.ChemoBeforeEncounter?.Performed;
            object mzzzzzzzzzzzzzzzc_ = FHIRHelpers_4_4_000.Instance.ToValue(context, mzzzzzzzzzzzzzzzb_);
            CqlInterval<CqlDateTime> mzzzzzzzzzzzzzzzd_ = QICoreCommon_2_1_000.Instance.toInterval(context, mzzzzzzzzzzzzzzzc_);
            CqlDateTime mzzzzzzzzzzzzzzze_ = context.Operators.Start(mzzzzzzzzzzzzzzzd_);
            CqlInterval<CqlDateTime> mzzzzzzzzzzzzzzzg_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, lzzzzzzzzzzzzzzzx_);
            CqlDateTime mzzzzzzzzzzzzzzzh_ = context.Operators.End(mzzzzzzzzzzzzzzzg_);
            CqlQuantity mzzzzzzzzzzzzzzzi_ = context.Operators.Quantity(30m, "days");
            CqlDateTime mzzzzzzzzzzzzzzzj_ = context.Operators.Subtract(mzzzzzzzzzzzzzzzh_, mzzzzzzzzzzzzzzzi_);
            CqlInterval<CqlDateTime> mzzzzzzzzzzzzzzzl_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, lzzzzzzzzzzzzzzzx_);
            CqlDateTime mzzzzzzzzzzzzzzzm_ = context.Operators.End(mzzzzzzzzzzzzzzzl_);
            CqlInterval<CqlDateTime> mzzzzzzzzzzzzzzzn_ = context.Operators.Interval(mzzzzzzzzzzzzzzzj_, mzzzzzzzzzzzzzzzm_, true, true);
            bool? mzzzzzzzzzzzzzzzo_ = context.Operators.In<CqlDateTime>(mzzzzzzzzzzzzzzze_, mzzzzzzzzzzzzzzzn_, "day");
            CqlInterval<CqlDateTime> mzzzzzzzzzzzzzzzq_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, lzzzzzzzzzzzzzzzx_);
            CqlDateTime mzzzzzzzzzzzzzzzr_ = context.Operators.End(mzzzzzzzzzzzzzzzq_);
            bool? mzzzzzzzzzzzzzzzs_ = context.Operators.Not((bool?)(mzzzzzzzzzzzzzzzr_ is null));
            bool? mzzzzzzzzzzzzzzzt_ = context.Operators.And(mzzzzzzzzzzzzzzzo_, mzzzzzzzzzzzzzzzs_);
            bool? mzzzzzzzzzzzzzzzu_ = context.Operators.And(mzzzzzzzzzzzzzzza_, mzzzzzzzzzzzzzzzt_);
            DataType mzzzzzzzzzzzzzzzv_ = tuple_cibligzrihjljqmithporoase?.ChemoAfterEncounter?.Performed;
            object mzzzzzzzzzzzzzzzw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, mzzzzzzzzzzzzzzzv_);
            CqlInterval<CqlDateTime> mzzzzzzzzzzzzzzzx_ = QICoreCommon_2_1_000.Instance.toInterval(context, mzzzzzzzzzzzzzzzw_);
            CqlDateTime mzzzzzzzzzzzzzzzy_ = context.Operators.Start(mzzzzzzzzzzzzzzzx_);
            CqlInterval<CqlDateTime> nzzzzzzzzzzzzzzza_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, lzzzzzzzzzzzzzzzx_);
            CqlDateTime nzzzzzzzzzzzzzzzb_ = context.Operators.End(nzzzzzzzzzzzzzzza_);
            CqlInterval<CqlDateTime> nzzzzzzzzzzzzzzzd_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, lzzzzzzzzzzzzzzzx_);
            CqlDateTime nzzzzzzzzzzzzzzze_ = context.Operators.End(nzzzzzzzzzzzzzzzd_);
            CqlDateTime nzzzzzzzzzzzzzzzg_ = context.Operators.Add(nzzzzzzzzzzzzzzze_, mzzzzzzzzzzzzzzzi_);
            CqlInterval<CqlDateTime> nzzzzzzzzzzzzzzzh_ = context.Operators.Interval(nzzzzzzzzzzzzzzzb_, nzzzzzzzzzzzzzzzg_, true, true);
            bool? nzzzzzzzzzzzzzzzi_ = context.Operators.In<CqlDateTime>(mzzzzzzzzzzzzzzzy_, nzzzzzzzzzzzzzzzh_, "day");
            CqlInterval<CqlDateTime> nzzzzzzzzzzzzzzzk_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, lzzzzzzzzzzzzzzzx_);
            CqlDateTime nzzzzzzzzzzzzzzzl_ = context.Operators.End(nzzzzzzzzzzzzzzzk_);
            bool? nzzzzzzzzzzzzzzzm_ = context.Operators.Not((bool?)(nzzzzzzzzzzzzzzzl_ is null));
            bool? nzzzzzzzzzzzzzzzn_ = context.Operators.And(nzzzzzzzzzzzzzzzi_, nzzzzzzzzzzzzzzzm_);
            bool? nzzzzzzzzzzzzzzzo_ = context.Operators.And(mzzzzzzzzzzzzzzzu_, nzzzzzzzzzzzzzzzn_);
            object nzzzzzzzzzzzzzzzq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, mzzzzzzzzzzzzzzzv_);
            CqlInterval<CqlDateTime> nzzzzzzzzzzzzzzzr_ = QICoreCommon_2_1_000.Instance.toInterval(context, nzzzzzzzzzzzzzzzq_);
            object nzzzzzzzzzzzzzzzt_ = FHIRHelpers_4_4_000.Instance.ToValue(context, mzzzzzzzzzzzzzzzb_);
            CqlInterval<CqlDateTime> nzzzzzzzzzzzzzzzu_ = QICoreCommon_2_1_000.Instance.toInterval(context, nzzzzzzzzzzzzzzzt_);
            bool? nzzzzzzzzzzzzzzzv_ = context.Operators.SameAs<CqlDateTime>(nzzzzzzzzzzzzzzzr_, nzzzzzzzzzzzzzzzu_, "day");
            bool? nzzzzzzzzzzzzzzzw_ = context.Operators.Not(nzzzzzzzzzzzzzzzv_);
            bool? nzzzzzzzzzzzzzzzx_ = context.Operators.And(nzzzzzzzzzzzzzzzo_, nzzzzzzzzzzzzzzzw_);
            CqlInterval<CqlDateTime> nzzzzzzzzzzzzzzzy_ = this.Measurement_Period(context);
            CqlInterval<CqlDateTime> ozzzzzzzzzzzzzzza_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, lzzzzzzzzzzzzzzzx_);
            bool? ozzzzzzzzzzzzzzzb_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(nzzzzzzzzzzzzzzzy_, ozzzzzzzzzzzzzzza_, default);
            bool? ozzzzzzzzzzzzzzzc_ = context.Operators.And(nzzzzzzzzzzzzzzzx_, ozzzzzzzzzzzzzzzb_);
            Code<Encounter.EncounterStatus> ozzzzzzzzzzzzzzzd_ = tuple_cibligzrihjljqmithporoase?.FaceToFaceOrTelehealthEncounter?.StatusElement;
            Encounter.EncounterStatus? ozzzzzzzzzzzzzzze_ = ozzzzzzzzzzzzzzzd_?.Value;
            Code<Encounter.EncounterStatus> ozzzzzzzzzzzzzzzf_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(ozzzzzzzzzzzzzzze_);
            bool? ozzzzzzzzzzzzzzzg_ = context.Operators.Equal(ozzzzzzzzzzzzzzzf_, "finished");
            bool? ozzzzzzzzzzzzzzzh_ = context.Operators.And(ozzzzzzzzzzzzzzzc_, ozzzzzzzzzzzzzzzg_);

            return ozzzzzzzzzzzzzzzh_;
        };
        IEnumerable<(CqlTupleMetadata, Encounter FaceToFaceOrTelehealthEncounter, Procedure ChemoBeforeEncounter, Procedure ChemoAfterEncounter, Condition Cancer)?> lzzzzzzzzzzzzzzzq_ = context.Operators.Where<(CqlTupleMetadata, Encounter FaceToFaceOrTelehealthEncounter, Procedure ChemoBeforeEncounter, Procedure ChemoAfterEncounter, Condition Cancer)?>(lzzzzzzzzzzzzzzzo_, lzzzzzzzzzzzzzzzp_);
        Encounter lzzzzzzzzzzzzzzzr_((CqlTupleMetadata, Encounter FaceToFaceOrTelehealthEncounter, Procedure ChemoBeforeEncounter, Procedure ChemoAfterEncounter, Condition Cancer)? tuple_cibligzrihjljqmithporoase) =>
            tuple_cibligzrihjljqmithporoase?.FaceToFaceOrTelehealthEncounter;
        IEnumerable<Encounter> lzzzzzzzzzzzzzzzs_ = context.Operators.Select<(CqlTupleMetadata, Encounter FaceToFaceOrTelehealthEncounter, Procedure ChemoBeforeEncounter, Procedure ChemoAfterEncounter, Condition Cancer)?, Encounter>(lzzzzzzzzzzzzzzzq_, lzzzzzzzzzzzzzzzr_);
        IEnumerable<Encounter> lzzzzzzzzzzzzzzzt_ = context.Operators.Distinct<Encounter>(lzzzzzzzzzzzzzzzs_);

        return lzzzzzzzzzzzzzzzt_;
    }


    [CqlExpressionDefinition("Initial Population 1")]
    public IEnumerable<Encounter> Initial_Population_1(CqlContext context)
    {
        IEnumerable<Encounter> ozzzzzzzzzzzzzzzi_ = this.Face_to_Face_or_Telehealth_Encounter_with_Ongoing_Chemotherapy(context);

        return ozzzzzzzzzzzzzzzi_;
    }


    [CqlExpressionDefinition("Denominator 1")]
    public IEnumerable<Encounter> Denominator_1(CqlContext context)
    {
        IEnumerable<Encounter> ozzzzzzzzzzzzzzzj_ = this.Initial_Population_1(context);

        return ozzzzzzzzzzzzzzzj_;
    }


    [CqlExpressionDefinition("Radiation Treatment Management During Measurement Period with Cancer Diagnosis")]
    public IEnumerable<Encounter> Radiation_Treatment_Management_During_Measurement_Period_with_Cancer_Diagnosis(CqlContext context)
    {
        CqlValueSet ozzzzzzzzzzzzzzzk_ = this.Radiation_Treatment_Management(context);
        IEnumerable<Encounter> ozzzzzzzzzzzzzzzl_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, ozzzzzzzzzzzzzzzk_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> ozzzzzzzzzzzzzzzm_(Encounter RadiationTreatmentManagement)
        {
            CqlValueSet ozzzzzzzzzzzzzzzq_ = this.Cancer(context);
            IEnumerable<Condition> ozzzzzzzzzzzzzzzr_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, ozzzzzzzzzzzzzzzq_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
            bool? ozzzzzzzzzzzzzzzs_(Condition Cancer)
            {
                bool? ozzzzzzzzzzzzzzzw_ = QICoreCommon_2_1_000.Instance.isActive(context, Cancer);
                CqlInterval<CqlDateTime> ozzzzzzzzzzzzzzzx_ = QICoreCommon_2_1_000.Instance.prevalenceInterval(context, Cancer);
                Period ozzzzzzzzzzzzzzzy_ = RadiationTreatmentManagement?.Period;
                CqlInterval<CqlDateTime> ozzzzzzzzzzzzzzzz_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ozzzzzzzzzzzzzzzy_);
                bool? pzzzzzzzzzzzzzzza_ = context.Operators.Overlaps(ozzzzzzzzzzzzzzzx_, ozzzzzzzzzzzzzzzz_, default);
                bool? pzzzzzzzzzzzzzzzb_ = context.Operators.And(ozzzzzzzzzzzzzzzw_, pzzzzzzzzzzzzzzza_);

                return pzzzzzzzzzzzzzzzb_;
            };
            IEnumerable<Condition> ozzzzzzzzzzzzzzzt_ = context.Operators.Where<Condition>(ozzzzzzzzzzzzzzzr_, ozzzzzzzzzzzzzzzs_);
            Encounter ozzzzzzzzzzzzzzzu_(Condition Cancer) =>
                RadiationTreatmentManagement;
            IEnumerable<Encounter> ozzzzzzzzzzzzzzzv_ = context.Operators.Select<Condition, Encounter>(ozzzzzzzzzzzzzzzt_, ozzzzzzzzzzzzzzzu_);

            return ozzzzzzzzzzzzzzzv_;
        };
        IEnumerable<Encounter> ozzzzzzzzzzzzzzzn_ = context.Operators.SelectMany<Encounter, Encounter>(ozzzzzzzzzzzzzzzl_, ozzzzzzzzzzzzzzzm_);
        bool? ozzzzzzzzzzzzzzzo_(Encounter RadiationTreatmentManagement)
        {
            CqlInterval<CqlDateTime> pzzzzzzzzzzzzzzzc_ = this.Measurement_Period(context);
            Period pzzzzzzzzzzzzzzzd_ = RadiationTreatmentManagement?.Period;
            CqlInterval<CqlDateTime> pzzzzzzzzzzzzzzze_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, pzzzzzzzzzzzzzzzd_);
            bool? pzzzzzzzzzzzzzzzf_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(pzzzzzzzzzzzzzzzc_, pzzzzzzzzzzzzzzze_, default);
            Code<Encounter.EncounterStatus> pzzzzzzzzzzzzzzzg_ = RadiationTreatmentManagement?.StatusElement;
            Encounter.EncounterStatus? pzzzzzzzzzzzzzzzh_ = pzzzzzzzzzzzzzzzg_?.Value;
            Code<Encounter.EncounterStatus> pzzzzzzzzzzzzzzzi_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(pzzzzzzzzzzzzzzzh_);
            bool? pzzzzzzzzzzzzzzzj_ = context.Operators.Equal(pzzzzzzzzzzzzzzzi_, "finished");
            bool? pzzzzzzzzzzzzzzzk_ = context.Operators.And(pzzzzzzzzzzzzzzzf_, pzzzzzzzzzzzzzzzj_);

            return pzzzzzzzzzzzzzzzk_;
        };
        IEnumerable<Encounter> ozzzzzzzzzzzzzzzp_ = context.Operators.Where<Encounter>(ozzzzzzzzzzzzzzzn_, ozzzzzzzzzzzzzzzo_);

        return ozzzzzzzzzzzzzzzp_;
    }


    [CqlExpressionDefinition("Initial Population 2")]
    public IEnumerable<Encounter> Initial_Population_2(CqlContext context)
    {
        IEnumerable<Encounter> pzzzzzzzzzzzzzzzl_ = this.Radiation_Treatment_Management_During_Measurement_Period_with_Cancer_Diagnosis(context);

        return pzzzzzzzzzzzzzzzl_;
    }


    [CqlExpressionDefinition("Denominator 2")]
    public IEnumerable<Encounter> Denominator_2(CqlContext context)
    {
        IEnumerable<Encounter> pzzzzzzzzzzzzzzzm_ = this.Initial_Population_2(context);

        return pzzzzzzzzzzzzzzzm_;
    }


    [CqlExpressionDefinition("Standard Pain Assessment with Result")]
    public IEnumerable<Observation> Standard_Pain_Assessment_with_Result(CqlContext context)
    {
        CqlValueSet pzzzzzzzzzzzzzzzn_ = this.Standardized_Pain_Assessment_Tool(context);
        IEnumerable<Observation> pzzzzzzzzzzzzzzzo_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, pzzzzzzzzzzzzzzzn_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        bool? pzzzzzzzzzzzzzzzp_(Observation AssessedPain)
        {
            DataType pzzzzzzzzzzzzzzzr_ = AssessedPain?.Value;
            object pzzzzzzzzzzzzzzzs_ = FHIRHelpers_4_4_000.Instance.ToValue(context, pzzzzzzzzzzzzzzzr_);
            bool? pzzzzzzzzzzzzzzzt_ = context.Operators.Not((bool?)(pzzzzzzzzzzzzzzzs_ is null));
            Code<ObservationStatus> pzzzzzzzzzzzzzzzu_ = AssessedPain?.StatusElement;
            ObservationStatus? pzzzzzzzzzzzzzzzv_ = pzzzzzzzzzzzzzzzu_?.Value;
            Code<ObservationStatus> pzzzzzzzzzzzzzzzw_ = context.Operators.Convert<Code<ObservationStatus>>(pzzzzzzzzzzzzzzzv_);
            bool? pzzzzzzzzzzzzzzzx_ = context.Operators.Equal(pzzzzzzzzzzzzzzzw_, "final");
            bool? pzzzzzzzzzzzzzzzy_ = context.Operators.And(pzzzzzzzzzzzzzzzt_, pzzzzzzzzzzzzzzzx_);

            return pzzzzzzzzzzzzzzzy_;
        };
        IEnumerable<Observation> pzzzzzzzzzzzzzzzq_ = context.Operators.Where<Observation>(pzzzzzzzzzzzzzzzo_, pzzzzzzzzzzzzzzzp_);

        return pzzzzzzzzzzzzzzzq_;
    }


    [CqlExpressionDefinition("Numerator 1")]
    public IEnumerable<Encounter> Numerator_1(CqlContext context)
    {
        IEnumerable<Encounter> pzzzzzzzzzzzzzzzz_ = this.Face_to_Face_or_Telehealth_Encounter_with_Ongoing_Chemotherapy(context);
        IEnumerable<Encounter> qzzzzzzzzzzzzzzza_(Encounter FaceToFaceOrTelehealthEncounterWithChemo)
        {
            IEnumerable<Observation> qzzzzzzzzzzzzzzzc_ = this.Standard_Pain_Assessment_with_Result(context);
            bool? qzzzzzzzzzzzzzzzd_(Observation PainAssessed)
            {
                Period qzzzzzzzzzzzzzzzh_ = FaceToFaceOrTelehealthEncounterWithChemo?.Period;
                CqlInterval<CqlDateTime> qzzzzzzzzzzzzzzzi_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, qzzzzzzzzzzzzzzzh_);
                DataType qzzzzzzzzzzzzzzzj_ = PainAssessed?.Effective;
                object qzzzzzzzzzzzzzzzk_ = FHIRHelpers_4_4_000.Instance.ToValue(context, qzzzzzzzzzzzzzzzj_);
                CqlInterval<CqlDateTime> qzzzzzzzzzzzzzzzl_ = QICoreCommon_2_1_000.Instance.toInterval(context, qzzzzzzzzzzzzzzzk_);
                bool? qzzzzzzzzzzzzzzzm_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(qzzzzzzzzzzzzzzzi_, qzzzzzzzzzzzzzzzl_, default);

                return qzzzzzzzzzzzzzzzm_;
            };
            IEnumerable<Observation> qzzzzzzzzzzzzzzze_ = context.Operators.Where<Observation>(qzzzzzzzzzzzzzzzc_, qzzzzzzzzzzzzzzzd_);
            Encounter qzzzzzzzzzzzzzzzf_(Observation PainAssessed) =>
                FaceToFaceOrTelehealthEncounterWithChemo;
            IEnumerable<Encounter> qzzzzzzzzzzzzzzzg_ = context.Operators.Select<Observation, Encounter>(qzzzzzzzzzzzzzzze_, qzzzzzzzzzzzzzzzf_);

            return qzzzzzzzzzzzzzzzg_;
        };
        IEnumerable<Encounter> qzzzzzzzzzzzzzzzb_ = context.Operators.SelectMany<Encounter, Encounter>(pzzzzzzzzzzzzzzzz_, qzzzzzzzzzzzzzzza_);

        return qzzzzzzzzzzzzzzzb_;
    }


    [CqlExpressionDefinition("Numerator 2")]
    public IEnumerable<Encounter> Numerator_2(CqlContext context)
    {
        IEnumerable<Encounter> qzzzzzzzzzzzzzzzn_ = this.Radiation_Treatment_Management_During_Measurement_Period_with_Cancer_Diagnosis(context);
        IEnumerable<Encounter> qzzzzzzzzzzzzzzzo_(Encounter RadiationManagementEncounter)
        {
            IEnumerable<Observation> qzzzzzzzzzzzzzzzq_ = this.Standard_Pain_Assessment_with_Result(context);
            bool? qzzzzzzzzzzzzzzzr_(Observation PainAssessed)
            {
                bool? qzzzzzzzzzzzzzzzv_()
                {
                    bool qzzzzzzzzzzzzzzzw_()
                    {
                        List<CodeableConcept> qzzzzzzzzzzzzzzzx_ = RadiationManagementEncounter?.Type;
                        CqlConcept qzzzzzzzzzzzzzzzy_(CodeableConcept @this)
                        {
                            CqlConcept rzzzzzzzzzzzzzzzd_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);

                            return rzzzzzzzzzzzzzzzd_;
                        };
                        IEnumerable<CqlConcept> qzzzzzzzzzzzzzzzz_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)qzzzzzzzzzzzzzzzx_, qzzzzzzzzzzzzzzzy_);
                        bool? rzzzzzzzzzzzzzzza_(CqlConcept RadiationManagement)
                        {
                            CqlCode rzzzzzzzzzzzzzzze_ = this.Radiation_treatment_management__5_treatments(context);
                            CqlConcept rzzzzzzzzzzzzzzzf_ = context.Operators.ConvertCodeToConcept(rzzzzzzzzzzzzzzze_);
                            bool? rzzzzzzzzzzzzzzzg_ = context.Operators.Equivalent(RadiationManagement, rzzzzzzzzzzzzzzzf_);

                            return rzzzzzzzzzzzzzzzg_;
                        };
                        IEnumerable<CqlConcept> rzzzzzzzzzzzzzzzb_ = context.Operators.Where<CqlConcept>(qzzzzzzzzzzzzzzzz_, rzzzzzzzzzzzzzzza_);
                        bool? rzzzzzzzzzzzzzzzc_ = context.Operators.Exists<CqlConcept>(rzzzzzzzzzzzzzzzb_);

                        return rzzzzzzzzzzzzzzzc_ ?? false;
                    };
                    if (qzzzzzzzzzzzzzzzw_())
                    {
                        DataType rzzzzzzzzzzzzzzzh_ = PainAssessed?.Effective;
                        object rzzzzzzzzzzzzzzzi_ = FHIRHelpers_4_4_000.Instance.ToValue(context, rzzzzzzzzzzzzzzzh_);
                        CqlInterval<CqlDateTime> rzzzzzzzzzzzzzzzj_ = QICoreCommon_2_1_000.Instance.toInterval(context, rzzzzzzzzzzzzzzzi_);
                        CqlDateTime rzzzzzzzzzzzzzzzk_ = context.Operators.End(rzzzzzzzzzzzzzzzj_);
                        Period rzzzzzzzzzzzzzzzl_ = RadiationManagementEncounter?.Period;
                        CqlInterval<CqlDateTime> rzzzzzzzzzzzzzzzm_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, rzzzzzzzzzzzzzzzl_);
                        CqlDateTime rzzzzzzzzzzzzzzzn_ = context.Operators.Start(rzzzzzzzzzzzzzzzm_);
                        CqlQuantity rzzzzzzzzzzzzzzzo_ = context.Operators.Quantity(6m, "days");
                        CqlDateTime rzzzzzzzzzzzzzzzp_ = context.Operators.Subtract(rzzzzzzzzzzzzzzzn_, rzzzzzzzzzzzzzzzo_);
                        CqlInterval<CqlDateTime> rzzzzzzzzzzzzzzzr_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, rzzzzzzzzzzzzzzzl_);
                        CqlDateTime rzzzzzzzzzzzzzzzs_ = context.Operators.Start(rzzzzzzzzzzzzzzzr_);
                        CqlInterval<CqlDateTime> rzzzzzzzzzzzzzzzt_ = context.Operators.Interval(rzzzzzzzzzzzzzzzp_, rzzzzzzzzzzzzzzzs_, true, true);
                        bool? rzzzzzzzzzzzzzzzu_ = context.Operators.In<CqlDateTime>(rzzzzzzzzzzzzzzzk_, rzzzzzzzzzzzzzzzt_, "day");
                        CqlInterval<CqlDateTime> rzzzzzzzzzzzzzzzw_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, rzzzzzzzzzzzzzzzl_);
                        CqlDateTime rzzzzzzzzzzzzzzzx_ = context.Operators.Start(rzzzzzzzzzzzzzzzw_);
                        bool? rzzzzzzzzzzzzzzzy_ = context.Operators.Not((bool?)(rzzzzzzzzzzzzzzzx_ is null));
                        bool? rzzzzzzzzzzzzzzzz_ = context.Operators.And(rzzzzzzzzzzzzzzzu_, rzzzzzzzzzzzzzzzy_);

                        return rzzzzzzzzzzzzzzzz_;
                    }
                    else
                    {
                        Period szzzzzzzzzzzzzzza_ = RadiationManagementEncounter?.Period;
                        CqlInterval<CqlDateTime> szzzzzzzzzzzzzzzb_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, szzzzzzzzzzzzzzza_);
                        DataType szzzzzzzzzzzzzzzc_ = PainAssessed?.Effective;
                        object szzzzzzzzzzzzzzzd_ = FHIRHelpers_4_4_000.Instance.ToValue(context, szzzzzzzzzzzzzzzc_);
                        CqlInterval<CqlDateTime> szzzzzzzzzzzzzzze_ = QICoreCommon_2_1_000.Instance.toInterval(context, szzzzzzzzzzzzzzzd_);
                        bool? szzzzzzzzzzzzzzzf_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(szzzzzzzzzzzzzzzb_, szzzzzzzzzzzzzzze_, "day");

                        return szzzzzzzzzzzzzzzf_;
                    }
                };

                return qzzzzzzzzzzzzzzzv_();
            };
            IEnumerable<Observation> qzzzzzzzzzzzzzzzs_ = context.Operators.Where<Observation>(qzzzzzzzzzzzzzzzq_, qzzzzzzzzzzzzzzzr_);
            Encounter qzzzzzzzzzzzzzzzt_(Observation PainAssessed) =>
                RadiationManagementEncounter;
            IEnumerable<Encounter> qzzzzzzzzzzzzzzzu_ = context.Operators.Select<Observation, Encounter>(qzzzzzzzzzzzzzzzs_, qzzzzzzzzzzzzzzzt_);

            return qzzzzzzzzzzzzzzzu_;
        };
        IEnumerable<Encounter> qzzzzzzzzzzzzzzzp_ = context.Operators.SelectMany<Encounter, Encounter>(qzzzzzzzzzzzzzzzn_, qzzzzzzzzzzzzzzzo_);

        return qzzzzzzzzzzzzzzzp_;
    }


    [CqlExpressionDefinition("SDE Ethnicity")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Ethnicity(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? szzzzzzzzzzzzzzzg_ = SupplementalDataElements_3_5_000.Instance.SDE_Ethnicity(context);

        return szzzzzzzzzzzzzzzg_;
    }


    [CqlExpressionDefinition("SDE Payer")]
    public IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> SDE_Payer(CqlContext context)
    {
        IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> szzzzzzzzzzzzzzzh_ = SupplementalDataElements_3_5_000.Instance.SDE_Payer(context);

        return szzzzzzzzzzzzzzzh_;
    }


    [CqlExpressionDefinition("SDE Race")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Race(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? szzzzzzzzzzzzzzzi_ = SupplementalDataElements_3_5_000.Instance.SDE_Race(context);

        return szzzzzzzzzzzzzzzi_;
    }


    [CqlExpressionDefinition("SDE Sex")]
    public CqlCode SDE_Sex(CqlContext context)
    {
        CqlCode szzzzzzzzzzzzzzzj_ = SupplementalDataElements_3_5_000.Instance.SDE_Sex(context);

        return szzzzzzzzzzzzzzzj_;
    }


    #endregion Expressions

    #region CqlTupleMetadata Properties

    private static CqlTupleMetadata CqlTupleMetadata_GEQGUKVdHYQAZdGbSEBAPcHZR = new(
        [typeof(Encounter), typeof(Procedure), typeof(Procedure), typeof(Condition)],
        ["FaceToFaceOrTelehealthEncounter", "ChemoBeforeEncounter", "ChemoAfterEncounter", "Cancer"]);

    #endregion CqlTupleMetadata Properties

}
