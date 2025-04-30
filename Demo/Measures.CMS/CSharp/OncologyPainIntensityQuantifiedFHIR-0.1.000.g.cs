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
        CqlDateTime kzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.DateTime(2025, 1, 1, 0, 0, 0, 0, 0.0m);
        CqlDateTime kzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.DateTime(2025, 12, 31, 23, 59, 59, 999, 0.0m);
        CqlInterval<CqlDateTime> kzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Interval(kzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_, kzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_, true, true);
        object kzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.ResolveParameter("OncologyPainIntensityQuantifiedFHIR-0.1.000", "Measurement Period", kzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_);

        return (CqlInterval<CqlDateTime>)kzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_;
    }


    #endregion Parameters

    #region Expressions

    [CqlExpressionDefinition("Patient")]
    public Patient Patient(CqlContext context)
    {
        IEnumerable<Patient> kzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-patient"));
        Patient kzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.SingletonFrom<Patient>(kzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_);

        return kzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_;
    }


    [CqlExpressionDefinition("Chemotherapy Within 31 Days Prior and During Measurement Period")]
    public IEnumerable<Procedure> Chemotherapy_Within_31_Days_Prior_and_During_Measurement_Period(CqlContext context)
    {
        CqlValueSet kzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = this.Chemotherapy_Administration(context);
        IEnumerable<Procedure> kzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, kzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
        bool? kzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_(Procedure ChemoAdministration)
        {
            CqlInterval<CqlDateTime> kzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = this.Measurement_Period(context);
            CqlDateTime kzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Start(kzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_);
            CqlQuantity kzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Quantity(31m, "days");
            CqlDateTime lzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Subtract(kzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_, kzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_);
            CqlDateTime lzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.End(kzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_);
            CqlInterval<CqlDateTime> lzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Interval(lzzzzzzzzzzzzzzzzzzzzzzzzzzzza_, lzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_, true, true);
            DataType lzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = ChemoAdministration?.Performed;
            object lzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = FHIRHelpers_4_4_000.Instance.ToValue(context, lzzzzzzzzzzzzzzzzzzzzzzzzzzzze_);
            CqlInterval<CqlDateTime> lzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = QICoreCommon_2_1_000.Instance.toInterval(context, lzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_);
            bool? lzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(lzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_, lzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_, default);
            Code<EventStatus> lzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = ChemoAdministration?.StatusElement;
            EventStatus? lzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = lzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_?.Value;
            string lzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Convert<string>(lzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_);
            bool? lzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Equal(lzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_, "completed");
            bool? lzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.And(lzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_, lzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_);

            return lzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_;
        };
        IEnumerable<Procedure> kzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Where<Procedure>(kzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_, kzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_);

        return kzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_;
    }


    [CqlExpressionDefinition("Face to Face or Telehealth Encounter with Ongoing Chemotherapy")]
    public IEnumerable<Encounter> Face_to_Face_or_Telehealth_Encounter_with_Ongoing_Chemotherapy(CqlContext context)
    {
        CqlValueSet lzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = this.Office_Visit(context);
        IEnumerable<Encounter> lzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, lzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Procedure> lzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = this.Chemotherapy_Within_31_Days_Prior_and_During_Measurement_Period(context);
        CqlValueSet lzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = this.Cancer(context);
        IEnumerable<Condition> lzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, lzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        IEnumerable<ValueTuple<Encounter, Procedure, Procedure, Condition>> lzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.CrossJoin<Encounter, Procedure, Procedure, Condition>(lzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_, lzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_, lzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_, lzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_);
        (CqlTupleMetadata, Encounter FaceToFaceOrTelehealthEncounter, Procedure ChemoBeforeEncounter, Procedure ChemoAfterEncounter, Condition Cancer)? lzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_(ValueTuple<Encounter, Procedure, Procedure, Condition> _valueTuple)
        {
            (CqlTupleMetadata, Encounter FaceToFaceOrTelehealthEncounter, Procedure ChemoBeforeEncounter, Procedure ChemoAfterEncounter, Condition Cancer)? mzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = (CqlTupleMetadata_GEQGUKVdHYQAZdGbSEBAPcHZR, _valueTuple.Item1, _valueTuple.Item2, _valueTuple.Item3, _valueTuple.Item4);

            return mzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_;
        };
        IEnumerable<(CqlTupleMetadata, Encounter FaceToFaceOrTelehealthEncounter, Procedure ChemoBeforeEncounter, Procedure ChemoAfterEncounter, Condition Cancer)?> lzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Select<ValueTuple<Encounter, Procedure, Procedure, Condition>, (CqlTupleMetadata, Encounter FaceToFaceOrTelehealthEncounter, Procedure ChemoBeforeEncounter, Procedure ChemoAfterEncounter, Condition Cancer)?>(lzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_, lzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_);
        bool? lzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_((CqlTupleMetadata, Encounter FaceToFaceOrTelehealthEncounter, Procedure ChemoBeforeEncounter, Procedure ChemoAfterEncounter, Condition Cancer)? tuple_cibligzrihjljqmithporoase)
        {
            bool? mzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = QICoreCommon_2_1_000.Instance.isActive(context, tuple_cibligzrihjljqmithporoase?.Cancer);
            CqlInterval<CqlDateTime> mzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = QICoreCommon_2_1_000.Instance.prevalenceInterval(context, tuple_cibligzrihjljqmithporoase?.Cancer);
            Period mzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = tuple_cibligzrihjljqmithporoase?.FaceToFaceOrTelehealthEncounter?.Period;
            CqlInterval<CqlDateTime> mzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, mzzzzzzzzzzzzzzzzzzzzzzzzzzzze_);
            bool? mzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Overlaps(mzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_, mzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_, default);
            bool? mzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.And(mzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_, mzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_);
            DataType mzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = tuple_cibligzrihjljqmithporoase?.ChemoBeforeEncounter?.Performed;
            object mzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, mzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_);
            CqlInterval<CqlDateTime> mzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = QICoreCommon_2_1_000.Instance.toInterval(context, mzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_);
            CqlDateTime mzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Start(mzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_);
            CqlInterval<CqlDateTime> mzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, mzzzzzzzzzzzzzzzzzzzzzzzzzzzze_);
            CqlDateTime mzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.End(mzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_);
            CqlQuantity mzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Quantity(30m, "days");
            CqlDateTime mzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Subtract(mzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_, mzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_);
            CqlInterval<CqlDateTime> mzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, mzzzzzzzzzzzzzzzzzzzzzzzzzzzze_);
            CqlDateTime mzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.End(mzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_);
            CqlInterval<CqlDateTime> mzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Interval(mzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_, mzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_, true, true);
            bool? mzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.In<CqlDateTime>(mzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_, mzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_, "day");
            CqlInterval<CqlDateTime> mzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, mzzzzzzzzzzzzzzzzzzzzzzzzzzzze_);
            CqlDateTime mzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.End(mzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_);
            bool? mzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Not((bool?)(mzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ is null));
            bool? nzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.And(mzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_, mzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_);
            bool? nzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.And(mzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_, nzzzzzzzzzzzzzzzzzzzzzzzzzzzza_);
            DataType nzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = tuple_cibligzrihjljqmithporoase?.ChemoAfterEncounter?.Performed;
            object nzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = FHIRHelpers_4_4_000.Instance.ToValue(context, nzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_);
            CqlInterval<CqlDateTime> nzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = QICoreCommon_2_1_000.Instance.toInterval(context, nzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_);
            CqlDateTime nzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Start(nzzzzzzzzzzzzzzzzzzzzzzzzzzzze_);
            CqlInterval<CqlDateTime> nzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, mzzzzzzzzzzzzzzzzzzzzzzzzzzzze_);
            CqlDateTime nzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.End(nzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_);
            CqlInterval<CqlDateTime> nzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, mzzzzzzzzzzzzzzzzzzzzzzzzzzzze_);
            CqlDateTime nzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.End(nzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_);
            CqlDateTime nzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Add(nzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_, mzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_);
            CqlInterval<CqlDateTime> nzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Interval(nzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_, nzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_, true, true);
            bool? nzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.In<CqlDateTime>(nzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_, nzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_, "day");
            CqlInterval<CqlDateTime> nzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, mzzzzzzzzzzzzzzzzzzzzzzzzzzzze_);
            CqlDateTime nzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.End(nzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_);
            bool? nzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Not((bool?)(nzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ is null));
            bool? nzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.And(nzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_, nzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_);
            bool? nzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.And(nzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_, nzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_);
            object nzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = FHIRHelpers_4_4_000.Instance.ToValue(context, nzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_);
            CqlInterval<CqlDateTime> nzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = QICoreCommon_2_1_000.Instance.toInterval(context, nzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_);
            object ozzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = FHIRHelpers_4_4_000.Instance.ToValue(context, mzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_);
            CqlInterval<CqlDateTime> ozzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = QICoreCommon_2_1_000.Instance.toInterval(context, ozzzzzzzzzzzzzzzzzzzzzzzzzzzza_);
            bool? ozzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.SameAs<CqlDateTime>(nzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_, ozzzzzzzzzzzzzzzzzzzzzzzzzzzzb_, "day");
            bool? ozzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Not(ozzzzzzzzzzzzzzzzzzzzzzzzzzzzc_);
            bool? ozzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.And(nzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_, ozzzzzzzzzzzzzzzzzzzzzzzzzzzzd_);
            CqlInterval<CqlDateTime> ozzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = this.Measurement_Period(context);
            CqlInterval<CqlDateTime> ozzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, mzzzzzzzzzzzzzzzzzzzzzzzzzzzze_);
            bool? ozzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(ozzzzzzzzzzzzzzzzzzzzzzzzzzzzf_, ozzzzzzzzzzzzzzzzzzzzzzzzzzzzh_, default);
            bool? ozzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.And(ozzzzzzzzzzzzzzzzzzzzzzzzzzzze_, ozzzzzzzzzzzzzzzzzzzzzzzzzzzzi_);
            Code<Encounter.EncounterStatus> ozzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = tuple_cibligzrihjljqmithporoase?.FaceToFaceOrTelehealthEncounter?.StatusElement;
            Encounter.EncounterStatus? ozzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = ozzzzzzzzzzzzzzzzzzzzzzzzzzzzk_?.Value;
            Code<Encounter.EncounterStatus> ozzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(ozzzzzzzzzzzzzzzzzzzzzzzzzzzzl_);
            bool? ozzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Equal(ozzzzzzzzzzzzzzzzzzzzzzzzzzzzm_, "finished");
            bool? ozzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.And(ozzzzzzzzzzzzzzzzzzzzzzzzzzzzj_, ozzzzzzzzzzzzzzzzzzzzzzzzzzzzn_);

            return ozzzzzzzzzzzzzzzzzzzzzzzzzzzzo_;
        };
        IEnumerable<(CqlTupleMetadata, Encounter FaceToFaceOrTelehealthEncounter, Procedure ChemoBeforeEncounter, Procedure ChemoAfterEncounter, Condition Cancer)?> lzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Where<(CqlTupleMetadata, Encounter FaceToFaceOrTelehealthEncounter, Procedure ChemoBeforeEncounter, Procedure ChemoAfterEncounter, Condition Cancer)?>(lzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_, lzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_);
        Encounter lzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_((CqlTupleMetadata, Encounter FaceToFaceOrTelehealthEncounter, Procedure ChemoBeforeEncounter, Procedure ChemoAfterEncounter, Condition Cancer)? tuple_cibligzrihjljqmithporoase) =>
            tuple_cibligzrihjljqmithporoase?.FaceToFaceOrTelehealthEncounter;
        IEnumerable<Encounter> lzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Select<(CqlTupleMetadata, Encounter FaceToFaceOrTelehealthEncounter, Procedure ChemoBeforeEncounter, Procedure ChemoAfterEncounter, Condition Cancer)?, Encounter>(lzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_, lzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_);
        IEnumerable<Encounter> mzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Distinct<Encounter>(lzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_);

        return mzzzzzzzzzzzzzzzzzzzzzzzzzzzza_;
    }


    [CqlExpressionDefinition("Initial Population 1")]
    public IEnumerable<Encounter> Initial_Population_1(CqlContext context)
    {
        IEnumerable<Encounter> ozzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = this.Face_to_Face_or_Telehealth_Encounter_with_Ongoing_Chemotherapy(context);

        return ozzzzzzzzzzzzzzzzzzzzzzzzzzzzp_;
    }


    [CqlExpressionDefinition("Denominator 1")]
    public IEnumerable<Encounter> Denominator_1(CqlContext context)
    {
        IEnumerable<Encounter> ozzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = this.Initial_Population_1(context);

        return ozzzzzzzzzzzzzzzzzzzzzzzzzzzzq_;
    }


    [CqlExpressionDefinition("Radiation Treatment Management During Measurement Period with Cancer Diagnosis")]
    public IEnumerable<Encounter> Radiation_Treatment_Management_During_Measurement_Period_with_Cancer_Diagnosis(CqlContext context)
    {
        CqlValueSet ozzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = this.Radiation_Treatment_Management(context);
        IEnumerable<Encounter> ozzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, ozzzzzzzzzzzzzzzzzzzzzzzzzzzzr_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> ozzzzzzzzzzzzzzzzzzzzzzzzzzzzt_(Encounter RadiationTreatmentManagement)
        {
            CqlValueSet ozzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = this.Cancer(context);
            IEnumerable<Condition> ozzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, ozzzzzzzzzzzzzzzzzzzzzzzzzzzzx_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
            bool? ozzzzzzzzzzzzzzzzzzzzzzzzzzzzz_(Condition Cancer)
            {
                bool? pzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = QICoreCommon_2_1_000.Instance.isActive(context, Cancer);
                CqlInterval<CqlDateTime> pzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = QICoreCommon_2_1_000.Instance.prevalenceInterval(context, Cancer);
                Period pzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = RadiationTreatmentManagement?.Period;
                CqlInterval<CqlDateTime> pzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, pzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_);
                bool? pzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Overlaps(pzzzzzzzzzzzzzzzzzzzzzzzzzzzze_, pzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_, default);
                bool? pzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.And(pzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_, pzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_);

                return pzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_;
            };
            IEnumerable<Condition> pzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Where<Condition>(ozzzzzzzzzzzzzzzzzzzzzzzzzzzzy_, ozzzzzzzzzzzzzzzzzzzzzzzzzzzzz_);
            Encounter pzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_(Condition Cancer) =>
                RadiationTreatmentManagement;
            IEnumerable<Encounter> pzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Select<Condition, Encounter>(pzzzzzzzzzzzzzzzzzzzzzzzzzzzza_, pzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_);

            return pzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_;
        };
        IEnumerable<Encounter> ozzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.SelectMany<Encounter, Encounter>(ozzzzzzzzzzzzzzzzzzzzzzzzzzzzs_, ozzzzzzzzzzzzzzzzzzzzzzzzzzzzt_);
        bool? ozzzzzzzzzzzzzzzzzzzzzzzzzzzzv_(Encounter RadiationTreatmentManagement)
        {
            CqlInterval<CqlDateTime> pzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = this.Measurement_Period(context);
            Period pzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = RadiationTreatmentManagement?.Period;
            CqlInterval<CqlDateTime> pzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, pzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_);
            bool? pzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(pzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_, pzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_, default);
            Code<Encounter.EncounterStatus> pzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = RadiationTreatmentManagement?.StatusElement;
            Encounter.EncounterStatus? pzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = pzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_?.Value;
            Code<Encounter.EncounterStatus> pzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(pzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_);
            bool? pzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Equal(pzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_, "finished");
            bool? pzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.And(pzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_, pzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_);

            return pzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_;
        };
        IEnumerable<Encounter> ozzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Where<Encounter>(ozzzzzzzzzzzzzzzzzzzzzzzzzzzzu_, ozzzzzzzzzzzzzzzzzzzzzzzzzzzzv_);

        return ozzzzzzzzzzzzzzzzzzzzzzzzzzzzw_;
    }


    [CqlExpressionDefinition("Initial Population 2")]
    public IEnumerable<Encounter> Initial_Population_2(CqlContext context)
    {
        IEnumerable<Encounter> pzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = this.Radiation_Treatment_Management_During_Measurement_Period_with_Cancer_Diagnosis(context);

        return pzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_;
    }


    [CqlExpressionDefinition("Denominator 2")]
    public IEnumerable<Encounter> Denominator_2(CqlContext context)
    {
        IEnumerable<Encounter> pzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = this.Initial_Population_2(context);

        return pzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_;
    }


    [CqlExpressionDefinition("Standard Pain Assessment with Result")]
    public IEnumerable<Observation> Standard_Pain_Assessment_with_Result(CqlContext context)
    {
        CqlValueSet pzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = this.Standardized_Pain_Assessment_Tool(context);
        IEnumerable<Observation> pzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, pzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        bool? pzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_(Observation AssessedPain)
        {
            DataType pzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = AssessedPain?.Value;
            object pzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = FHIRHelpers_4_4_000.Instance.ToValue(context, pzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_);
            bool? qzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Not((bool?)(pzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ is null));
            Code<ObservationStatus> qzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = AssessedPain?.StatusElement;
            ObservationStatus? qzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = qzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_?.Value;
            Code<ObservationStatus> qzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Convert<Code<ObservationStatus>>(qzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_);
            bool? qzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Equal(qzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_, "final");
            bool? qzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.And(qzzzzzzzzzzzzzzzzzzzzzzzzzzzza_, qzzzzzzzzzzzzzzzzzzzzzzzzzzzze_);

            return qzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_;
        };
        IEnumerable<Observation> pzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Where<Observation>(pzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_, pzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_);

        return pzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_;
    }


    [CqlExpressionDefinition("Numerator 1")]
    public IEnumerable<Encounter> Numerator_1(CqlContext context)
    {
        IEnumerable<Encounter> qzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = this.Face_to_Face_or_Telehealth_Encounter_with_Ongoing_Chemotherapy(context);
        IEnumerable<Encounter> qzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_(Encounter FaceToFaceOrTelehealthEncounterWithChemo)
        {
            IEnumerable<Observation> qzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = this.Standard_Pain_Assessment_with_Result(context);
            bool? qzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_(Observation PainAssessed)
            {
                Period qzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = FaceToFaceOrTelehealthEncounterWithChemo?.Period;
                CqlInterval<CqlDateTime> qzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, qzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_);
                DataType qzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = PainAssessed?.Effective;
                object qzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = FHIRHelpers_4_4_000.Instance.ToValue(context, qzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_);
                CqlInterval<CqlDateTime> qzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = QICoreCommon_2_1_000.Instance.toInterval(context, qzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_);
                bool? qzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(qzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_, qzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_, default);

                return qzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_;
            };
            IEnumerable<Observation> qzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Where<Observation>(qzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_, qzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_);
            Encounter qzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_(Observation PainAssessed) =>
                FaceToFaceOrTelehealthEncounterWithChemo;
            IEnumerable<Encounter> qzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Select<Observation, Encounter>(qzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_, qzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_);

            return qzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_;
        };
        IEnumerable<Encounter> qzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.SelectMany<Encounter, Encounter>(qzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_, qzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_);

        return qzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_;
    }


    [CqlExpressionDefinition("Numerator 2")]
    public IEnumerable<Encounter> Numerator_2(CqlContext context)
    {
        IEnumerable<Encounter> qzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = this.Radiation_Treatment_Management_During_Measurement_Period_with_Cancer_Diagnosis(context);
        IEnumerable<Encounter> qzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_(Encounter RadiationManagementEncounter)
        {
            IEnumerable<Observation> qzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = this.Standard_Pain_Assessment_with_Result(context);
            bool? qzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_(Observation PainAssessed)
            {
                bool? rzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_()
                {
                    bool rzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_()
                    {
                        List<CodeableConcept> rzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = RadiationManagementEncounter?.Type;
                        CqlConcept rzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_(CodeableConcept @this)
                        {
                            CqlConcept rzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);

                            return rzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_;
                        };
                        IEnumerable<CqlConcept> rzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)rzzzzzzzzzzzzzzzzzzzzzzzzzzzze_, rzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_);
                        bool? rzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_(CqlConcept RadiationManagement)
                        {
                            CqlCode rzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = this.Radiation_treatment_management__5_treatments(context);
                            CqlConcept rzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.ConvertCodeToConcept(rzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_);
                            bool? rzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Equivalent(RadiationManagement, rzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_);

                            return rzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_;
                        };
                        IEnumerable<CqlConcept> rzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Where<CqlConcept>(rzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_, rzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_);
                        bool? rzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Exists<CqlConcept>(rzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_);

                        return rzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ ?? false;
                    };
                    if (rzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_())
                    {
                        DataType rzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = PainAssessed?.Effective;
                        object rzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = FHIRHelpers_4_4_000.Instance.ToValue(context, rzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_);
                        CqlInterval<CqlDateTime> rzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = QICoreCommon_2_1_000.Instance.toInterval(context, rzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_);
                        CqlDateTime rzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.End(rzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_);
                        Period rzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = RadiationManagementEncounter?.Period;
                        CqlInterval<CqlDateTime> rzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, rzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_);
                        CqlDateTime rzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Start(rzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_);
                        CqlQuantity rzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Quantity(6m, "days");
                        CqlDateTime rzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Subtract(rzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_, rzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_);
                        CqlInterval<CqlDateTime> rzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, rzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_);
                        CqlDateTime rzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Start(rzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_);
                        CqlInterval<CqlDateTime> szzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Interval(rzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_, rzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_, true, true);
                        bool? szzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.In<CqlDateTime>(rzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_, szzzzzzzzzzzzzzzzzzzzzzzzzzzza_, "day");
                        CqlInterval<CqlDateTime> szzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, rzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_);
                        CqlDateTime szzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Start(szzzzzzzzzzzzzzzzzzzzzzzzzzzzd_);
                        bool? szzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Not((bool?)(szzzzzzzzzzzzzzzzzzzzzzzzzzzze_ is null));
                        bool? szzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.And(szzzzzzzzzzzzzzzzzzzzzzzzzzzzb_, szzzzzzzzzzzzzzzzzzzzzzzzzzzzf_);

                        return szzzzzzzzzzzzzzzzzzzzzzzzzzzzg_;
                    }
                    else
                    {
                        Period szzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = RadiationManagementEncounter?.Period;
                        CqlInterval<CqlDateTime> szzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, szzzzzzzzzzzzzzzzzzzzzzzzzzzzh_);
                        DataType szzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = PainAssessed?.Effective;
                        object szzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = FHIRHelpers_4_4_000.Instance.ToValue(context, szzzzzzzzzzzzzzzzzzzzzzzzzzzzj_);
                        CqlInterval<CqlDateTime> szzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = QICoreCommon_2_1_000.Instance.toInterval(context, szzzzzzzzzzzzzzzzzzzzzzzzzzzzk_);
                        bool? szzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(szzzzzzzzzzzzzzzzzzzzzzzzzzzzi_, szzzzzzzzzzzzzzzzzzzzzzzzzzzzl_, "day");

                        return szzzzzzzzzzzzzzzzzzzzzzzzzzzzm_;
                    }
                };

                return rzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_();
            };
            IEnumerable<Observation> qzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Where<Observation>(qzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_, qzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_);
            Encounter rzzzzzzzzzzzzzzzzzzzzzzzzzzzza_(Observation PainAssessed) =>
                RadiationManagementEncounter;
            IEnumerable<Encounter> rzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Select<Observation, Encounter>(qzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_, rzzzzzzzzzzzzzzzzzzzzzzzzzzzza_);

            return rzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_;
        };
        IEnumerable<Encounter> qzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.SelectMany<Encounter, Encounter>(qzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_, qzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_);

        return qzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_;
    }


    [CqlExpressionDefinition("SDE Ethnicity")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Ethnicity(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? szzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = SupplementalDataElements_3_5_000.Instance.SDE_Ethnicity(context);

        return szzzzzzzzzzzzzzzzzzzzzzzzzzzzn_;
    }


    [CqlExpressionDefinition("SDE Payer")]
    public IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> SDE_Payer(CqlContext context)
    {
        IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> szzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = SupplementalDataElements_3_5_000.Instance.SDE_Payer(context);

        return szzzzzzzzzzzzzzzzzzzzzzzzzzzzo_;
    }


    [CqlExpressionDefinition("SDE Race")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Race(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? szzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = SupplementalDataElements_3_5_000.Instance.SDE_Race(context);

        return szzzzzzzzzzzzzzzzzzzzzzzzzzzzp_;
    }


    [CqlExpressionDefinition("SDE Sex")]
    public CqlCode SDE_Sex(CqlContext context)
    {
        CqlCode szzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = SupplementalDataElements_3_5_000.Instance.SDE_Sex(context);

        return szzzzzzzzzzzzzzzzzzzzzzzzzzzzq_;
    }


    #endregion Expressions

    #region CqlTupleMetadata Properties

    private static CqlTupleMetadata CqlTupleMetadata_GEQGUKVdHYQAZdGbSEBAPcHZR = new(
        [typeof(Encounter), typeof(Procedure), typeof(Procedure), typeof(Condition)],
        ["FaceToFaceOrTelehealthEncounter", "ChemoBeforeEncounter", "ChemoAfterEncounter", "Cancer"]);

    #endregion CqlTupleMetadata Properties

}
