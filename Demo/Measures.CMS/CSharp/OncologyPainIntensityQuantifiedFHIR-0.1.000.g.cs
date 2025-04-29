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
        CqlDateTime tzzzzzzzzzzzzzzzzzzl_ = context.Operators.DateTime(2025, 1, 1, 0, 0, 0, 0, 0.0m);
        CqlDateTime tzzzzzzzzzzzzzzzzzzm_ = context.Operators.DateTime(2025, 12, 31, 23, 59, 59, 999, 0.0m);
        CqlInterval<CqlDateTime> tzzzzzzzzzzzzzzzzzzn_ = context.Operators.Interval(tzzzzzzzzzzzzzzzzzzl_, tzzzzzzzzzzzzzzzzzzm_, true, true);
        object tzzzzzzzzzzzzzzzzzzo_ = context.ResolveParameter("OncologyPainIntensityQuantifiedFHIR-0.1.000", "Measurement Period", tzzzzzzzzzzzzzzzzzzn_);

        return (CqlInterval<CqlDateTime>)tzzzzzzzzzzzzzzzzzzo_;
    }


    #endregion Parameters

    #region Expressions

    [CqlExpressionDefinition("Patient")]
    public Patient Patient(CqlContext context)
    {
        IEnumerable<Patient> tzzzzzzzzzzzzzzzzzzp_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-patient"));
        Patient tzzzzzzzzzzzzzzzzzzq_ = context.Operators.SingletonFrom<Patient>(tzzzzzzzzzzzzzzzzzzp_);

        return tzzzzzzzzzzzzzzzzzzq_;
    }


    [CqlExpressionDefinition("Chemotherapy Within 31 Days Prior and During Measurement Period")]
    public IEnumerable<Procedure> Chemotherapy_Within_31_Days_Prior_and_During_Measurement_Period(CqlContext context)
    {
        CqlValueSet tzzzzzzzzzzzzzzzzzzr_ = this.Chemotherapy_Administration(context);
        IEnumerable<Procedure> tzzzzzzzzzzzzzzzzzzs_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, tzzzzzzzzzzzzzzzzzzr_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
        bool? tzzzzzzzzzzzzzzzzzzt_(Procedure ChemoAdministration)
        {
            CqlInterval<CqlDateTime> tzzzzzzzzzzzzzzzzzzv_ = this.Measurement_Period(context);
            CqlDateTime tzzzzzzzzzzzzzzzzzzw_ = context.Operators.Start(tzzzzzzzzzzzzzzzzzzv_);
            CqlQuantity tzzzzzzzzzzzzzzzzzzx_ = context.Operators.Quantity(31m, "days");
            CqlDateTime tzzzzzzzzzzzzzzzzzzy_ = context.Operators.Subtract(tzzzzzzzzzzzzzzzzzzw_, tzzzzzzzzzzzzzzzzzzx_);
            CqlDateTime uzzzzzzzzzzzzzzzzzza_ = context.Operators.End(tzzzzzzzzzzzzzzzzzzv_);
            CqlInterval<CqlDateTime> uzzzzzzzzzzzzzzzzzzb_ = context.Operators.Interval(tzzzzzzzzzzzzzzzzzzy_, uzzzzzzzzzzzzzzzzzza_, true, true);
            DataType uzzzzzzzzzzzzzzzzzzc_ = ChemoAdministration?.Performed;
            object uzzzzzzzzzzzzzzzzzzd_ = FHIRHelpers_4_4_000.Instance.ToValue(context, uzzzzzzzzzzzzzzzzzzc_);
            CqlInterval<CqlDateTime> uzzzzzzzzzzzzzzzzzze_ = QICoreCommon_2_1_000.Instance.toInterval(context, uzzzzzzzzzzzzzzzzzzd_);
            bool? uzzzzzzzzzzzzzzzzzzf_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(uzzzzzzzzzzzzzzzzzzb_, uzzzzzzzzzzzzzzzzzze_, default);
            Code<EventStatus> uzzzzzzzzzzzzzzzzzzg_ = ChemoAdministration?.StatusElement;
            EventStatus? uzzzzzzzzzzzzzzzzzzh_ = uzzzzzzzzzzzzzzzzzzg_?.Value;
            string uzzzzzzzzzzzzzzzzzzi_ = context.Operators.Convert<string>(uzzzzzzzzzzzzzzzzzzh_);
            bool? uzzzzzzzzzzzzzzzzzzj_ = context.Operators.Equal(uzzzzzzzzzzzzzzzzzzi_, "completed");
            bool? uzzzzzzzzzzzzzzzzzzk_ = context.Operators.And(uzzzzzzzzzzzzzzzzzzf_, uzzzzzzzzzzzzzzzzzzj_);

            return uzzzzzzzzzzzzzzzzzzk_;
        };
        IEnumerable<Procedure> tzzzzzzzzzzzzzzzzzzu_ = context.Operators.Where<Procedure>(tzzzzzzzzzzzzzzzzzzs_, tzzzzzzzzzzzzzzzzzzt_);

        return tzzzzzzzzzzzzzzzzzzu_;
    }


    [CqlExpressionDefinition("Face to Face or Telehealth Encounter with Ongoing Chemotherapy")]
    public IEnumerable<Encounter> Face_to_Face_or_Telehealth_Encounter_with_Ongoing_Chemotherapy(CqlContext context)
    {
        CqlValueSet uzzzzzzzzzzzzzzzzzzl_ = this.Office_Visit(context);
        IEnumerable<Encounter> uzzzzzzzzzzzzzzzzzzm_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, uzzzzzzzzzzzzzzzzzzl_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Procedure> uzzzzzzzzzzzzzzzzzzn_ = this.Chemotherapy_Within_31_Days_Prior_and_During_Measurement_Period(context);
        CqlValueSet uzzzzzzzzzzzzzzzzzzp_ = this.Cancer(context);
        IEnumerable<Condition> uzzzzzzzzzzzzzzzzzzq_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, uzzzzzzzzzzzzzzzzzzp_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        IEnumerable<ValueTuple<Encounter, Procedure, Procedure, Condition>> uzzzzzzzzzzzzzzzzzzr_ = context.Operators.CrossJoin<Encounter, Procedure, Procedure, Condition>(uzzzzzzzzzzzzzzzzzzm_, uzzzzzzzzzzzzzzzzzzn_, uzzzzzzzzzzzzzzzzzzn_, uzzzzzzzzzzzzzzzzzzq_);
        (CqlTupleMetadata, Encounter FaceToFaceOrTelehealthEncounter, Procedure ChemoBeforeEncounter, Procedure ChemoAfterEncounter, Condition Cancer)? uzzzzzzzzzzzzzzzzzzs_(ValueTuple<Encounter, Procedure, Procedure, Condition> _valueTuple)
        {
            (CqlTupleMetadata, Encounter FaceToFaceOrTelehealthEncounter, Procedure ChemoBeforeEncounter, Procedure ChemoAfterEncounter, Condition Cancer)? uzzzzzzzzzzzzzzzzzzz_ = (CqlTupleMetadata_GEQGUKVdHYQAZdGbSEBAPcHZR, _valueTuple.Item1, _valueTuple.Item2, _valueTuple.Item3, _valueTuple.Item4);

            return uzzzzzzzzzzzzzzzzzzz_;
        };
        IEnumerable<(CqlTupleMetadata, Encounter FaceToFaceOrTelehealthEncounter, Procedure ChemoBeforeEncounter, Procedure ChemoAfterEncounter, Condition Cancer)?> uzzzzzzzzzzzzzzzzzzt_ = context.Operators.Select<ValueTuple<Encounter, Procedure, Procedure, Condition>, (CqlTupleMetadata, Encounter FaceToFaceOrTelehealthEncounter, Procedure ChemoBeforeEncounter, Procedure ChemoAfterEncounter, Condition Cancer)?>(uzzzzzzzzzzzzzzzzzzr_, uzzzzzzzzzzzzzzzzzzs_);
        bool? uzzzzzzzzzzzzzzzzzzu_((CqlTupleMetadata, Encounter FaceToFaceOrTelehealthEncounter, Procedure ChemoBeforeEncounter, Procedure ChemoAfterEncounter, Condition Cancer)? tuple_cibligzrihjljqmithporoase)
        {
            bool? vzzzzzzzzzzzzzzzzzza_ = QICoreCommon_2_1_000.Instance.isActive(context, tuple_cibligzrihjljqmithporoase?.Cancer);
            CqlInterval<CqlDateTime> vzzzzzzzzzzzzzzzzzzb_ = QICoreCommon_2_1_000.Instance.prevalenceInterval(context, tuple_cibligzrihjljqmithporoase?.Cancer);
            Period vzzzzzzzzzzzzzzzzzzc_ = tuple_cibligzrihjljqmithporoase?.FaceToFaceOrTelehealthEncounter?.Period;
            CqlInterval<CqlDateTime> vzzzzzzzzzzzzzzzzzzd_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, vzzzzzzzzzzzzzzzzzzc_);
            bool? vzzzzzzzzzzzzzzzzzze_ = context.Operators.Overlaps(vzzzzzzzzzzzzzzzzzzb_, vzzzzzzzzzzzzzzzzzzd_, default);
            bool? vzzzzzzzzzzzzzzzzzzf_ = context.Operators.And(vzzzzzzzzzzzzzzzzzza_, vzzzzzzzzzzzzzzzzzze_);
            DataType vzzzzzzzzzzzzzzzzzzg_ = tuple_cibligzrihjljqmithporoase?.ChemoBeforeEncounter?.Performed;
            object vzzzzzzzzzzzzzzzzzzh_ = FHIRHelpers_4_4_000.Instance.ToValue(context, vzzzzzzzzzzzzzzzzzzg_);
            CqlInterval<CqlDateTime> vzzzzzzzzzzzzzzzzzzi_ = QICoreCommon_2_1_000.Instance.toInterval(context, vzzzzzzzzzzzzzzzzzzh_);
            CqlDateTime vzzzzzzzzzzzzzzzzzzj_ = context.Operators.Start(vzzzzzzzzzzzzzzzzzzi_);
            CqlInterval<CqlDateTime> vzzzzzzzzzzzzzzzzzzl_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, vzzzzzzzzzzzzzzzzzzc_);
            CqlDateTime vzzzzzzzzzzzzzzzzzzm_ = context.Operators.End(vzzzzzzzzzzzzzzzzzzl_);
            CqlQuantity vzzzzzzzzzzzzzzzzzzn_ = context.Operators.Quantity(30m, "days");
            CqlDateTime vzzzzzzzzzzzzzzzzzzo_ = context.Operators.Subtract(vzzzzzzzzzzzzzzzzzzm_, vzzzzzzzzzzzzzzzzzzn_);
            CqlInterval<CqlDateTime> vzzzzzzzzzzzzzzzzzzq_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, vzzzzzzzzzzzzzzzzzzc_);
            CqlDateTime vzzzzzzzzzzzzzzzzzzr_ = context.Operators.End(vzzzzzzzzzzzzzzzzzzq_);
            CqlInterval<CqlDateTime> vzzzzzzzzzzzzzzzzzzs_ = context.Operators.Interval(vzzzzzzzzzzzzzzzzzzo_, vzzzzzzzzzzzzzzzzzzr_, true, true);
            bool? vzzzzzzzzzzzzzzzzzzt_ = context.Operators.In<CqlDateTime>(vzzzzzzzzzzzzzzzzzzj_, vzzzzzzzzzzzzzzzzzzs_, "day");
            CqlInterval<CqlDateTime> vzzzzzzzzzzzzzzzzzzv_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, vzzzzzzzzzzzzzzzzzzc_);
            CqlDateTime vzzzzzzzzzzzzzzzzzzw_ = context.Operators.End(vzzzzzzzzzzzzzzzzzzv_);
            bool? vzzzzzzzzzzzzzzzzzzx_ = context.Operators.Not((bool?)(vzzzzzzzzzzzzzzzzzzw_ is null));
            bool? vzzzzzzzzzzzzzzzzzzy_ = context.Operators.And(vzzzzzzzzzzzzzzzzzzt_, vzzzzzzzzzzzzzzzzzzx_);
            bool? vzzzzzzzzzzzzzzzzzzz_ = context.Operators.And(vzzzzzzzzzzzzzzzzzzf_, vzzzzzzzzzzzzzzzzzzy_);
            DataType wzzzzzzzzzzzzzzzzzza_ = tuple_cibligzrihjljqmithporoase?.ChemoAfterEncounter?.Performed;
            object wzzzzzzzzzzzzzzzzzzb_ = FHIRHelpers_4_4_000.Instance.ToValue(context, wzzzzzzzzzzzzzzzzzza_);
            CqlInterval<CqlDateTime> wzzzzzzzzzzzzzzzzzzc_ = QICoreCommon_2_1_000.Instance.toInterval(context, wzzzzzzzzzzzzzzzzzzb_);
            CqlDateTime wzzzzzzzzzzzzzzzzzzd_ = context.Operators.Start(wzzzzzzzzzzzzzzzzzzc_);
            CqlInterval<CqlDateTime> wzzzzzzzzzzzzzzzzzzf_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, vzzzzzzzzzzzzzzzzzzc_);
            CqlDateTime wzzzzzzzzzzzzzzzzzzg_ = context.Operators.End(wzzzzzzzzzzzzzzzzzzf_);
            CqlInterval<CqlDateTime> wzzzzzzzzzzzzzzzzzzi_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, vzzzzzzzzzzzzzzzzzzc_);
            CqlDateTime wzzzzzzzzzzzzzzzzzzj_ = context.Operators.End(wzzzzzzzzzzzzzzzzzzi_);
            CqlDateTime wzzzzzzzzzzzzzzzzzzl_ = context.Operators.Add(wzzzzzzzzzzzzzzzzzzj_, vzzzzzzzzzzzzzzzzzzn_);
            CqlInterval<CqlDateTime> wzzzzzzzzzzzzzzzzzzm_ = context.Operators.Interval(wzzzzzzzzzzzzzzzzzzg_, wzzzzzzzzzzzzzzzzzzl_, true, true);
            bool? wzzzzzzzzzzzzzzzzzzn_ = context.Operators.In<CqlDateTime>(wzzzzzzzzzzzzzzzzzzd_, wzzzzzzzzzzzzzzzzzzm_, "day");
            CqlInterval<CqlDateTime> wzzzzzzzzzzzzzzzzzzp_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, vzzzzzzzzzzzzzzzzzzc_);
            CqlDateTime wzzzzzzzzzzzzzzzzzzq_ = context.Operators.End(wzzzzzzzzzzzzzzzzzzp_);
            bool? wzzzzzzzzzzzzzzzzzzr_ = context.Operators.Not((bool?)(wzzzzzzzzzzzzzzzzzzq_ is null));
            bool? wzzzzzzzzzzzzzzzzzzs_ = context.Operators.And(wzzzzzzzzzzzzzzzzzzn_, wzzzzzzzzzzzzzzzzzzr_);
            bool? wzzzzzzzzzzzzzzzzzzt_ = context.Operators.And(vzzzzzzzzzzzzzzzzzzz_, wzzzzzzzzzzzzzzzzzzs_);
            object wzzzzzzzzzzzzzzzzzzv_ = FHIRHelpers_4_4_000.Instance.ToValue(context, wzzzzzzzzzzzzzzzzzza_);
            CqlInterval<CqlDateTime> wzzzzzzzzzzzzzzzzzzw_ = QICoreCommon_2_1_000.Instance.toInterval(context, wzzzzzzzzzzzzzzzzzzv_);
            object wzzzzzzzzzzzzzzzzzzy_ = FHIRHelpers_4_4_000.Instance.ToValue(context, vzzzzzzzzzzzzzzzzzzg_);
            CqlInterval<CqlDateTime> wzzzzzzzzzzzzzzzzzzz_ = QICoreCommon_2_1_000.Instance.toInterval(context, wzzzzzzzzzzzzzzzzzzy_);
            bool? xzzzzzzzzzzzzzzzzzza_ = context.Operators.SameAs<CqlDateTime>(wzzzzzzzzzzzzzzzzzzw_, wzzzzzzzzzzzzzzzzzzz_, "day");
            bool? xzzzzzzzzzzzzzzzzzzb_ = context.Operators.Not(xzzzzzzzzzzzzzzzzzza_);
            bool? xzzzzzzzzzzzzzzzzzzc_ = context.Operators.And(wzzzzzzzzzzzzzzzzzzt_, xzzzzzzzzzzzzzzzzzzb_);
            CqlInterval<CqlDateTime> xzzzzzzzzzzzzzzzzzzd_ = this.Measurement_Period(context);
            CqlInterval<CqlDateTime> xzzzzzzzzzzzzzzzzzzf_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, vzzzzzzzzzzzzzzzzzzc_);
            bool? xzzzzzzzzzzzzzzzzzzg_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(xzzzzzzzzzzzzzzzzzzd_, xzzzzzzzzzzzzzzzzzzf_, default);
            bool? xzzzzzzzzzzzzzzzzzzh_ = context.Operators.And(xzzzzzzzzzzzzzzzzzzc_, xzzzzzzzzzzzzzzzzzzg_);
            Code<Encounter.EncounterStatus> xzzzzzzzzzzzzzzzzzzi_ = tuple_cibligzrihjljqmithporoase?.FaceToFaceOrTelehealthEncounter?.StatusElement;
            Encounter.EncounterStatus? xzzzzzzzzzzzzzzzzzzj_ = xzzzzzzzzzzzzzzzzzzi_?.Value;
            Code<Encounter.EncounterStatus> xzzzzzzzzzzzzzzzzzzk_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(xzzzzzzzzzzzzzzzzzzj_);
            bool? xzzzzzzzzzzzzzzzzzzl_ = context.Operators.Equal(xzzzzzzzzzzzzzzzzzzk_, "finished");
            bool? xzzzzzzzzzzzzzzzzzzm_ = context.Operators.And(xzzzzzzzzzzzzzzzzzzh_, xzzzzzzzzzzzzzzzzzzl_);

            return xzzzzzzzzzzzzzzzzzzm_;
        };
        IEnumerable<(CqlTupleMetadata, Encounter FaceToFaceOrTelehealthEncounter, Procedure ChemoBeforeEncounter, Procedure ChemoAfterEncounter, Condition Cancer)?> uzzzzzzzzzzzzzzzzzzv_ = context.Operators.Where<(CqlTupleMetadata, Encounter FaceToFaceOrTelehealthEncounter, Procedure ChemoBeforeEncounter, Procedure ChemoAfterEncounter, Condition Cancer)?>(uzzzzzzzzzzzzzzzzzzt_, uzzzzzzzzzzzzzzzzzzu_);
        Encounter uzzzzzzzzzzzzzzzzzzw_((CqlTupleMetadata, Encounter FaceToFaceOrTelehealthEncounter, Procedure ChemoBeforeEncounter, Procedure ChemoAfterEncounter, Condition Cancer)? tuple_cibligzrihjljqmithporoase) =>
            tuple_cibligzrihjljqmithporoase?.FaceToFaceOrTelehealthEncounter;
        IEnumerable<Encounter> uzzzzzzzzzzzzzzzzzzx_ = context.Operators.Select<(CqlTupleMetadata, Encounter FaceToFaceOrTelehealthEncounter, Procedure ChemoBeforeEncounter, Procedure ChemoAfterEncounter, Condition Cancer)?, Encounter>(uzzzzzzzzzzzzzzzzzzv_, uzzzzzzzzzzzzzzzzzzw_);
        IEnumerable<Encounter> uzzzzzzzzzzzzzzzzzzy_ = context.Operators.Distinct<Encounter>(uzzzzzzzzzzzzzzzzzzx_);

        return uzzzzzzzzzzzzzzzzzzy_;
    }


    [CqlExpressionDefinition("Initial Population 1")]
    public IEnumerable<Encounter> Initial_Population_1(CqlContext context)
    {
        IEnumerable<Encounter> xzzzzzzzzzzzzzzzzzzn_ = this.Face_to_Face_or_Telehealth_Encounter_with_Ongoing_Chemotherapy(context);

        return xzzzzzzzzzzzzzzzzzzn_;
    }


    [CqlExpressionDefinition("Denominator 1")]
    public IEnumerable<Encounter> Denominator_1(CqlContext context)
    {
        IEnumerable<Encounter> xzzzzzzzzzzzzzzzzzzo_ = this.Initial_Population_1(context);

        return xzzzzzzzzzzzzzzzzzzo_;
    }


    [CqlExpressionDefinition("Radiation Treatment Management During Measurement Period with Cancer Diagnosis")]
    public IEnumerable<Encounter> Radiation_Treatment_Management_During_Measurement_Period_with_Cancer_Diagnosis(CqlContext context)
    {
        CqlValueSet xzzzzzzzzzzzzzzzzzzp_ = this.Radiation_Treatment_Management(context);
        IEnumerable<Encounter> xzzzzzzzzzzzzzzzzzzq_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, xzzzzzzzzzzzzzzzzzzp_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> xzzzzzzzzzzzzzzzzzzr_(Encounter RadiationTreatmentManagement)
        {
            CqlValueSet xzzzzzzzzzzzzzzzzzzv_ = this.Cancer(context);
            IEnumerable<Condition> xzzzzzzzzzzzzzzzzzzw_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, xzzzzzzzzzzzzzzzzzzv_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
            bool? xzzzzzzzzzzzzzzzzzzx_(Condition Cancer)
            {
                bool? yzzzzzzzzzzzzzzzzzzb_ = QICoreCommon_2_1_000.Instance.isActive(context, Cancer);
                CqlInterval<CqlDateTime> yzzzzzzzzzzzzzzzzzzc_ = QICoreCommon_2_1_000.Instance.prevalenceInterval(context, Cancer);
                Period yzzzzzzzzzzzzzzzzzzd_ = RadiationTreatmentManagement?.Period;
                CqlInterval<CqlDateTime> yzzzzzzzzzzzzzzzzzze_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, yzzzzzzzzzzzzzzzzzzd_);
                bool? yzzzzzzzzzzzzzzzzzzf_ = context.Operators.Overlaps(yzzzzzzzzzzzzzzzzzzc_, yzzzzzzzzzzzzzzzzzze_, default);
                bool? yzzzzzzzzzzzzzzzzzzg_ = context.Operators.And(yzzzzzzzzzzzzzzzzzzb_, yzzzzzzzzzzzzzzzzzzf_);

                return yzzzzzzzzzzzzzzzzzzg_;
            };
            IEnumerable<Condition> xzzzzzzzzzzzzzzzzzzy_ = context.Operators.Where<Condition>(xzzzzzzzzzzzzzzzzzzw_, xzzzzzzzzzzzzzzzzzzx_);
            Encounter xzzzzzzzzzzzzzzzzzzz_(Condition Cancer) =>
                RadiationTreatmentManagement;
            IEnumerable<Encounter> yzzzzzzzzzzzzzzzzzza_ = context.Operators.Select<Condition, Encounter>(xzzzzzzzzzzzzzzzzzzy_, xzzzzzzzzzzzzzzzzzzz_);

            return yzzzzzzzzzzzzzzzzzza_;
        };
        IEnumerable<Encounter> xzzzzzzzzzzzzzzzzzzs_ = context.Operators.SelectMany<Encounter, Encounter>(xzzzzzzzzzzzzzzzzzzq_, xzzzzzzzzzzzzzzzzzzr_);
        bool? xzzzzzzzzzzzzzzzzzzt_(Encounter RadiationTreatmentManagement)
        {
            CqlInterval<CqlDateTime> yzzzzzzzzzzzzzzzzzzh_ = this.Measurement_Period(context);
            Period yzzzzzzzzzzzzzzzzzzi_ = RadiationTreatmentManagement?.Period;
            CqlInterval<CqlDateTime> yzzzzzzzzzzzzzzzzzzj_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, yzzzzzzzzzzzzzzzzzzi_);
            bool? yzzzzzzzzzzzzzzzzzzk_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(yzzzzzzzzzzzzzzzzzzh_, yzzzzzzzzzzzzzzzzzzj_, default);
            Code<Encounter.EncounterStatus> yzzzzzzzzzzzzzzzzzzl_ = RadiationTreatmentManagement?.StatusElement;
            Encounter.EncounterStatus? yzzzzzzzzzzzzzzzzzzm_ = yzzzzzzzzzzzzzzzzzzl_?.Value;
            Code<Encounter.EncounterStatus> yzzzzzzzzzzzzzzzzzzn_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(yzzzzzzzzzzzzzzzzzzm_);
            bool? yzzzzzzzzzzzzzzzzzzo_ = context.Operators.Equal(yzzzzzzzzzzzzzzzzzzn_, "finished");
            bool? yzzzzzzzzzzzzzzzzzzp_ = context.Operators.And(yzzzzzzzzzzzzzzzzzzk_, yzzzzzzzzzzzzzzzzzzo_);

            return yzzzzzzzzzzzzzzzzzzp_;
        };
        IEnumerable<Encounter> xzzzzzzzzzzzzzzzzzzu_ = context.Operators.Where<Encounter>(xzzzzzzzzzzzzzzzzzzs_, xzzzzzzzzzzzzzzzzzzt_);

        return xzzzzzzzzzzzzzzzzzzu_;
    }


    [CqlExpressionDefinition("Initial Population 2")]
    public IEnumerable<Encounter> Initial_Population_2(CqlContext context)
    {
        IEnumerable<Encounter> yzzzzzzzzzzzzzzzzzzq_ = this.Radiation_Treatment_Management_During_Measurement_Period_with_Cancer_Diagnosis(context);

        return yzzzzzzzzzzzzzzzzzzq_;
    }


    [CqlExpressionDefinition("Denominator 2")]
    public IEnumerable<Encounter> Denominator_2(CqlContext context)
    {
        IEnumerable<Encounter> yzzzzzzzzzzzzzzzzzzr_ = this.Initial_Population_2(context);

        return yzzzzzzzzzzzzzzzzzzr_;
    }


    [CqlExpressionDefinition("Standard Pain Assessment with Result")]
    public IEnumerable<Observation> Standard_Pain_Assessment_with_Result(CqlContext context)
    {
        CqlValueSet yzzzzzzzzzzzzzzzzzzs_ = this.Standardized_Pain_Assessment_Tool(context);
        IEnumerable<Observation> yzzzzzzzzzzzzzzzzzzt_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, yzzzzzzzzzzzzzzzzzzs_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        bool? yzzzzzzzzzzzzzzzzzzu_(Observation AssessedPain)
        {
            DataType yzzzzzzzzzzzzzzzzzzw_ = AssessedPain?.Value;
            object yzzzzzzzzzzzzzzzzzzx_ = FHIRHelpers_4_4_000.Instance.ToValue(context, yzzzzzzzzzzzzzzzzzzw_);
            bool? yzzzzzzzzzzzzzzzzzzy_ = context.Operators.Not((bool?)(yzzzzzzzzzzzzzzzzzzx_ is null));
            Code<ObservationStatus> yzzzzzzzzzzzzzzzzzzz_ = AssessedPain?.StatusElement;
            ObservationStatus? zzzzzzzzzzzzzzzzzzza_ = yzzzzzzzzzzzzzzzzzzz_?.Value;
            Code<ObservationStatus> zzzzzzzzzzzzzzzzzzzb_ = context.Operators.Convert<Code<ObservationStatus>>(zzzzzzzzzzzzzzzzzzza_);
            bool? zzzzzzzzzzzzzzzzzzzc_ = context.Operators.Equal(zzzzzzzzzzzzzzzzzzzb_, "final");
            bool? zzzzzzzzzzzzzzzzzzzd_ = context.Operators.And(yzzzzzzzzzzzzzzzzzzy_, zzzzzzzzzzzzzzzzzzzc_);

            return zzzzzzzzzzzzzzzzzzzd_;
        };
        IEnumerable<Observation> yzzzzzzzzzzzzzzzzzzv_ = context.Operators.Where<Observation>(yzzzzzzzzzzzzzzzzzzt_, yzzzzzzzzzzzzzzzzzzu_);

        return yzzzzzzzzzzzzzzzzzzv_;
    }


    [CqlExpressionDefinition("Numerator 1")]
    public IEnumerable<Encounter> Numerator_1(CqlContext context)
    {
        IEnumerable<Encounter> zzzzzzzzzzzzzzzzzzze_ = this.Face_to_Face_or_Telehealth_Encounter_with_Ongoing_Chemotherapy(context);
        IEnumerable<Encounter> zzzzzzzzzzzzzzzzzzzf_(Encounter FaceToFaceOrTelehealthEncounterWithChemo)
        {
            IEnumerable<Observation> zzzzzzzzzzzzzzzzzzzh_ = this.Standard_Pain_Assessment_with_Result(context);
            bool? zzzzzzzzzzzzzzzzzzzi_(Observation PainAssessed)
            {
                Period zzzzzzzzzzzzzzzzzzzm_ = FaceToFaceOrTelehealthEncounterWithChemo?.Period;
                CqlInterval<CqlDateTime> zzzzzzzzzzzzzzzzzzzn_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, zzzzzzzzzzzzzzzzzzzm_);
                DataType zzzzzzzzzzzzzzzzzzzo_ = PainAssessed?.Effective;
                object zzzzzzzzzzzzzzzzzzzp_ = FHIRHelpers_4_4_000.Instance.ToValue(context, zzzzzzzzzzzzzzzzzzzo_);
                CqlInterval<CqlDateTime> zzzzzzzzzzzzzzzzzzzq_ = QICoreCommon_2_1_000.Instance.toInterval(context, zzzzzzzzzzzzzzzzzzzp_);
                bool? zzzzzzzzzzzzzzzzzzzr_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(zzzzzzzzzzzzzzzzzzzn_, zzzzzzzzzzzzzzzzzzzq_, default);

                return zzzzzzzzzzzzzzzzzzzr_;
            };
            IEnumerable<Observation> zzzzzzzzzzzzzzzzzzzj_ = context.Operators.Where<Observation>(zzzzzzzzzzzzzzzzzzzh_, zzzzzzzzzzzzzzzzzzzi_);
            Encounter zzzzzzzzzzzzzzzzzzzk_(Observation PainAssessed) =>
                FaceToFaceOrTelehealthEncounterWithChemo;
            IEnumerable<Encounter> zzzzzzzzzzzzzzzzzzzl_ = context.Operators.Select<Observation, Encounter>(zzzzzzzzzzzzzzzzzzzj_, zzzzzzzzzzzzzzzzzzzk_);

            return zzzzzzzzzzzzzzzzzzzl_;
        };
        IEnumerable<Encounter> zzzzzzzzzzzzzzzzzzzg_ = context.Operators.SelectMany<Encounter, Encounter>(zzzzzzzzzzzzzzzzzzze_, zzzzzzzzzzzzzzzzzzzf_);

        return zzzzzzzzzzzzzzzzzzzg_;
    }


    [CqlExpressionDefinition("Numerator 2")]
    public IEnumerable<Encounter> Numerator_2(CqlContext context)
    {
        IEnumerable<Encounter> zzzzzzzzzzzzzzzzzzzs_ = this.Radiation_Treatment_Management_During_Measurement_Period_with_Cancer_Diagnosis(context);
        IEnumerable<Encounter> zzzzzzzzzzzzzzzzzzzt_(Encounter RadiationManagementEncounter)
        {
            IEnumerable<Observation> zzzzzzzzzzzzzzzzzzzv_ = this.Standard_Pain_Assessment_with_Result(context);
            bool? zzzzzzzzzzzzzzzzzzzw_(Observation PainAssessed)
            {
                bool? azzzzzzzzzzzzzzzzzzza_()
                {
                    bool azzzzzzzzzzzzzzzzzzzb_()
                    {
                        List<CodeableConcept> azzzzzzzzzzzzzzzzzzzc_ = RadiationManagementEncounter?.Type;
                        CqlConcept azzzzzzzzzzzzzzzzzzzd_(CodeableConcept @this)
                        {
                            CqlConcept azzzzzzzzzzzzzzzzzzzi_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);

                            return azzzzzzzzzzzzzzzzzzzi_;
                        };
                        IEnumerable<CqlConcept> azzzzzzzzzzzzzzzzzzze_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)azzzzzzzzzzzzzzzzzzzc_, azzzzzzzzzzzzzzzzzzzd_);
                        bool? azzzzzzzzzzzzzzzzzzzf_(CqlConcept RadiationManagement)
                        {
                            CqlCode azzzzzzzzzzzzzzzzzzzj_ = this.Radiation_treatment_management__5_treatments(context);
                            CqlConcept azzzzzzzzzzzzzzzzzzzk_ = context.Operators.ConvertCodeToConcept(azzzzzzzzzzzzzzzzzzzj_);
                            bool? azzzzzzzzzzzzzzzzzzzl_ = context.Operators.Equivalent(RadiationManagement, azzzzzzzzzzzzzzzzzzzk_);

                            return azzzzzzzzzzzzzzzzzzzl_;
                        };
                        IEnumerable<CqlConcept> azzzzzzzzzzzzzzzzzzzg_ = context.Operators.Where<CqlConcept>(azzzzzzzzzzzzzzzzzzze_, azzzzzzzzzzzzzzzzzzzf_);
                        bool? azzzzzzzzzzzzzzzzzzzh_ = context.Operators.Exists<CqlConcept>(azzzzzzzzzzzzzzzzzzzg_);

                        return azzzzzzzzzzzzzzzzzzzh_ ?? false;
                    };
                    if (azzzzzzzzzzzzzzzzzzzb_())
                    {
                        DataType azzzzzzzzzzzzzzzzzzzm_ = PainAssessed?.Effective;
                        object azzzzzzzzzzzzzzzzzzzn_ = FHIRHelpers_4_4_000.Instance.ToValue(context, azzzzzzzzzzzzzzzzzzzm_);
                        CqlInterval<CqlDateTime> azzzzzzzzzzzzzzzzzzzo_ = QICoreCommon_2_1_000.Instance.toInterval(context, azzzzzzzzzzzzzzzzzzzn_);
                        CqlDateTime azzzzzzzzzzzzzzzzzzzp_ = context.Operators.End(azzzzzzzzzzzzzzzzzzzo_);
                        Period azzzzzzzzzzzzzzzzzzzq_ = RadiationManagementEncounter?.Period;
                        CqlInterval<CqlDateTime> azzzzzzzzzzzzzzzzzzzr_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, azzzzzzzzzzzzzzzzzzzq_);
                        CqlDateTime azzzzzzzzzzzzzzzzzzzs_ = context.Operators.Start(azzzzzzzzzzzzzzzzzzzr_);
                        CqlQuantity azzzzzzzzzzzzzzzzzzzt_ = context.Operators.Quantity(6m, "days");
                        CqlDateTime azzzzzzzzzzzzzzzzzzzu_ = context.Operators.Subtract(azzzzzzzzzzzzzzzzzzzs_, azzzzzzzzzzzzzzzzzzzt_);
                        CqlInterval<CqlDateTime> azzzzzzzzzzzzzzzzzzzw_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, azzzzzzzzzzzzzzzzzzzq_);
                        CqlDateTime azzzzzzzzzzzzzzzzzzzx_ = context.Operators.Start(azzzzzzzzzzzzzzzzzzzw_);
                        CqlInterval<CqlDateTime> azzzzzzzzzzzzzzzzzzzy_ = context.Operators.Interval(azzzzzzzzzzzzzzzzzzzu_, azzzzzzzzzzzzzzzzzzzx_, true, true);
                        bool? azzzzzzzzzzzzzzzzzzzz_ = context.Operators.In<CqlDateTime>(azzzzzzzzzzzzzzzzzzzp_, azzzzzzzzzzzzzzzzzzzy_, "day");
                        CqlInterval<CqlDateTime> bzzzzzzzzzzzzzzzzzzzb_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, azzzzzzzzzzzzzzzzzzzq_);
                        CqlDateTime bzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Start(bzzzzzzzzzzzzzzzzzzzb_);
                        bool? bzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Not((bool?)(bzzzzzzzzzzzzzzzzzzzc_ is null));
                        bool? bzzzzzzzzzzzzzzzzzzze_ = context.Operators.And(azzzzzzzzzzzzzzzzzzzz_, bzzzzzzzzzzzzzzzzzzzd_);

                        return bzzzzzzzzzzzzzzzzzzze_;
                    }
                    else
                    {
                        Period bzzzzzzzzzzzzzzzzzzzf_ = RadiationManagementEncounter?.Period;
                        CqlInterval<CqlDateTime> bzzzzzzzzzzzzzzzzzzzg_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, bzzzzzzzzzzzzzzzzzzzf_);
                        DataType bzzzzzzzzzzzzzzzzzzzh_ = PainAssessed?.Effective;
                        object bzzzzzzzzzzzzzzzzzzzi_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bzzzzzzzzzzzzzzzzzzzh_);
                        CqlInterval<CqlDateTime> bzzzzzzzzzzzzzzzzzzzj_ = QICoreCommon_2_1_000.Instance.toInterval(context, bzzzzzzzzzzzzzzzzzzzi_);
                        bool? bzzzzzzzzzzzzzzzzzzzk_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(bzzzzzzzzzzzzzzzzzzzg_, bzzzzzzzzzzzzzzzzzzzj_, "day");

                        return bzzzzzzzzzzzzzzzzzzzk_;
                    }
                };

                return azzzzzzzzzzzzzzzzzzza_();
            };
            IEnumerable<Observation> zzzzzzzzzzzzzzzzzzzx_ = context.Operators.Where<Observation>(zzzzzzzzzzzzzzzzzzzv_, zzzzzzzzzzzzzzzzzzzw_);
            Encounter zzzzzzzzzzzzzzzzzzzy_(Observation PainAssessed) =>
                RadiationManagementEncounter;
            IEnumerable<Encounter> zzzzzzzzzzzzzzzzzzzz_ = context.Operators.Select<Observation, Encounter>(zzzzzzzzzzzzzzzzzzzx_, zzzzzzzzzzzzzzzzzzzy_);

            return zzzzzzzzzzzzzzzzzzzz_;
        };
        IEnumerable<Encounter> zzzzzzzzzzzzzzzzzzzu_ = context.Operators.SelectMany<Encounter, Encounter>(zzzzzzzzzzzzzzzzzzzs_, zzzzzzzzzzzzzzzzzzzt_);

        return zzzzzzzzzzzzzzzzzzzu_;
    }


    [CqlExpressionDefinition("SDE Ethnicity")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Ethnicity(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? bzzzzzzzzzzzzzzzzzzzl_ = SupplementalDataElements_3_5_000.Instance.SDE_Ethnicity(context);

        return bzzzzzzzzzzzzzzzzzzzl_;
    }


    [CqlExpressionDefinition("SDE Payer")]
    public IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> SDE_Payer(CqlContext context)
    {
        IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> bzzzzzzzzzzzzzzzzzzzm_ = SupplementalDataElements_3_5_000.Instance.SDE_Payer(context);

        return bzzzzzzzzzzzzzzzzzzzm_;
    }


    [CqlExpressionDefinition("SDE Race")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Race(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? bzzzzzzzzzzzzzzzzzzzn_ = SupplementalDataElements_3_5_000.Instance.SDE_Race(context);

        return bzzzzzzzzzzzzzzzzzzzn_;
    }


    [CqlExpressionDefinition("SDE Sex")]
    public CqlCode SDE_Sex(CqlContext context)
    {
        CqlCode bzzzzzzzzzzzzzzzzzzzo_ = SupplementalDataElements_3_5_000.Instance.SDE_Sex(context);

        return bzzzzzzzzzzzzzzzzzzzo_;
    }


    #endregion Expressions

    #region CqlTupleMetadata Properties

    private static CqlTupleMetadata CqlTupleMetadata_GEQGUKVdHYQAZdGbSEBAPcHZR = new(
        [typeof(Encounter), typeof(Procedure), typeof(Procedure), typeof(Condition)],
        ["FaceToFaceOrTelehealthEncounter", "ChemoBeforeEncounter", "ChemoAfterEncounter", "Cancer"]);

    #endregion CqlTupleMetadata Properties

}
