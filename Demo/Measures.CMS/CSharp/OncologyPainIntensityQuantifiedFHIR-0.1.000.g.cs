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
    private static readonly CqlCode _Radiation_treatment_management__5_treatments = new CqlCode("77427", "http://www.ama-assn.org/go/cpt");

    #endregion Codes

    #region CodeSystems

    [CqlCodeSystemDefinition("CPT")]
    public CqlCodeSystem CPT(CqlContext _) => _CPT;
    private static readonly CqlCodeSystem _CPT =
      new CqlCodeSystem("http://www.ama-assn.org/go/cpt", null,
          _Radiation_treatment_management__5_treatments);

    #endregion CodeSystems

    #region Parameters

    [CqlParameterDefinition("Measurement Period")]
    public CqlInterval<CqlDateTime> Measurement_Period(CqlContext context)
    {
        CqlDateTime gzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.DateTime(2025, 1, 1, 0, 0, 0, 0, 0.0m);
        CqlDateTime gzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.DateTime(2025, 12, 31, 23, 59, 59, 999, 0.0m);
        CqlInterval<CqlDateTime> gzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Interval(gzzzzzzzzzzzzzzzzzzzzzzzzv_, gzzzzzzzzzzzzzzzzzzzzzzzzw_, true, true);
        object gzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.ResolveParameter("OncologyPainIntensityQuantifiedFHIR-0.1.000", "Measurement Period", gzzzzzzzzzzzzzzzzzzzzzzzzx_);

        return (CqlInterval<CqlDateTime>)gzzzzzzzzzzzzzzzzzzzzzzzzy_;
    }


    #endregion Parameters

    #region Expressions

    [CqlExpressionDefinition("Patient")]
    public Patient Patient(CqlContext context)
    {
        IEnumerable<Patient> gzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-patient"));
        Patient hzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.SingletonFrom<Patient>(gzzzzzzzzzzzzzzzzzzzzzzzzz_);

        return hzzzzzzzzzzzzzzzzzzzzzzzza_;
    }


    [CqlExpressionDefinition("Chemotherapy Within 31 Days Prior and During Measurement Period")]
    public IEnumerable<Procedure> Chemotherapy_Within_31_Days_Prior_and_During_Measurement_Period(CqlContext context)
    {
        CqlValueSet hzzzzzzzzzzzzzzzzzzzzzzzzb_ = this.Chemotherapy_Administration(context);
        IEnumerable<Procedure> hzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, hzzzzzzzzzzzzzzzzzzzzzzzzb_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
        bool? hzzzzzzzzzzzzzzzzzzzzzzzzd_(Procedure ChemoAdministration)
        {
            CqlInterval<CqlDateTime> hzzzzzzzzzzzzzzzzzzzzzzzzf_ = this.Measurement_Period(context);
            CqlDateTime hzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Start(hzzzzzzzzzzzzzzzzzzzzzzzzf_);
            CqlQuantity hzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Quantity(31m, "days");
            CqlDateTime hzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Subtract(hzzzzzzzzzzzzzzzzzzzzzzzzg_, hzzzzzzzzzzzzzzzzzzzzzzzzh_);
            CqlDateTime hzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.End(hzzzzzzzzzzzzzzzzzzzzzzzzf_);
            CqlInterval<CqlDateTime> hzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Interval(hzzzzzzzzzzzzzzzzzzzzzzzzi_, hzzzzzzzzzzzzzzzzzzzzzzzzk_, true, true);
            DataType hzzzzzzzzzzzzzzzzzzzzzzzzm_ = ChemoAdministration?.Performed;
            object hzzzzzzzzzzzzzzzzzzzzzzzzn_ = FHIRHelpers_4_4_000.Instance.ToValue(context, hzzzzzzzzzzzzzzzzzzzzzzzzm_);
            CqlInterval<CqlDateTime> hzzzzzzzzzzzzzzzzzzzzzzzzo_ = QICoreCommon_2_1_000.Instance.toInterval(context, hzzzzzzzzzzzzzzzzzzzzzzzzn_);
            bool? hzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(hzzzzzzzzzzzzzzzzzzzzzzzzl_, hzzzzzzzzzzzzzzzzzzzzzzzzo_, default);
            Code<EventStatus> hzzzzzzzzzzzzzzzzzzzzzzzzq_ = ChemoAdministration?.StatusElement;
            EventStatus? hzzzzzzzzzzzzzzzzzzzzzzzzr_ = hzzzzzzzzzzzzzzzzzzzzzzzzq_?.Value;
            string hzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Convert<string>(hzzzzzzzzzzzzzzzzzzzzzzzzr_);
            bool? hzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Equal(hzzzzzzzzzzzzzzzzzzzzzzzzs_, "completed");
            bool? hzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.And(hzzzzzzzzzzzzzzzzzzzzzzzzp_, hzzzzzzzzzzzzzzzzzzzzzzzzt_);

            return hzzzzzzzzzzzzzzzzzzzzzzzzu_;
        };
        IEnumerable<Procedure> hzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Where<Procedure>(hzzzzzzzzzzzzzzzzzzzzzzzzc_, hzzzzzzzzzzzzzzzzzzzzzzzzd_);

        return hzzzzzzzzzzzzzzzzzzzzzzzze_;
    }


    [CqlExpressionDefinition("Face to Face or Telehealth Encounter with Ongoing Chemotherapy")]
    public IEnumerable<Encounter> Face_to_Face_or_Telehealth_Encounter_with_Ongoing_Chemotherapy(CqlContext context)
    {
        CqlValueSet hzzzzzzzzzzzzzzzzzzzzzzzzv_ = this.Office_Visit(context);
        IEnumerable<Encounter> hzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, hzzzzzzzzzzzzzzzzzzzzzzzzv_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Procedure> hzzzzzzzzzzzzzzzzzzzzzzzzx_ = this.Chemotherapy_Within_31_Days_Prior_and_During_Measurement_Period(context);
        CqlValueSet hzzzzzzzzzzzzzzzzzzzzzzzzz_ = this.Cancer(context);
        IEnumerable<Condition> izzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, hzzzzzzzzzzzzzzzzzzzzzzzzz_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        IEnumerable<ValueTuple<Encounter, Procedure, Procedure, Condition>> izzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.CrossJoin<Encounter, Procedure, Procedure, Condition>(hzzzzzzzzzzzzzzzzzzzzzzzzw_, hzzzzzzzzzzzzzzzzzzzzzzzzx_, hzzzzzzzzzzzzzzzzzzzzzzzzx_, izzzzzzzzzzzzzzzzzzzzzzzza_);
        (CqlTupleMetadata, Encounter FaceToFaceOrTelehealthEncounter, Procedure ChemoBeforeEncounter, Procedure ChemoAfterEncounter, Condition Cancer)? izzzzzzzzzzzzzzzzzzzzzzzzc_(ValueTuple<Encounter, Procedure, Procedure, Condition> _valueTuple)
        {
            (CqlTupleMetadata, Encounter FaceToFaceOrTelehealthEncounter, Procedure ChemoBeforeEncounter, Procedure ChemoAfterEncounter, Condition Cancer)? izzzzzzzzzzzzzzzzzzzzzzzzj_ = (CqlTupleMetadata_GEQGUKVdHYQAZdGbSEBAPcHZR, _valueTuple.Item1, _valueTuple.Item2, _valueTuple.Item3, _valueTuple.Item4);

            return izzzzzzzzzzzzzzzzzzzzzzzzj_;
        };
        IEnumerable<(CqlTupleMetadata, Encounter FaceToFaceOrTelehealthEncounter, Procedure ChemoBeforeEncounter, Procedure ChemoAfterEncounter, Condition Cancer)?> izzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Select<ValueTuple<Encounter, Procedure, Procedure, Condition>, (CqlTupleMetadata, Encounter FaceToFaceOrTelehealthEncounter, Procedure ChemoBeforeEncounter, Procedure ChemoAfterEncounter, Condition Cancer)?>(izzzzzzzzzzzzzzzzzzzzzzzzb_, izzzzzzzzzzzzzzzzzzzzzzzzc_);
        bool? izzzzzzzzzzzzzzzzzzzzzzzze_((CqlTupleMetadata, Encounter FaceToFaceOrTelehealthEncounter, Procedure ChemoBeforeEncounter, Procedure ChemoAfterEncounter, Condition Cancer)? tuple_cibligzrihjljqmithporoase)
        {
            bool? izzzzzzzzzzzzzzzzzzzzzzzzk_ = QICoreCommon_2_1_000.Instance.isActive(context, tuple_cibligzrihjljqmithporoase?.Cancer);
            CqlInterval<CqlDateTime> izzzzzzzzzzzzzzzzzzzzzzzzl_ = QICoreCommon_2_1_000.Instance.prevalenceInterval(context, tuple_cibligzrihjljqmithporoase?.Cancer);
            Period izzzzzzzzzzzzzzzzzzzzzzzzm_ = tuple_cibligzrihjljqmithporoase?.FaceToFaceOrTelehealthEncounter?.Period;
            CqlInterval<CqlDateTime> izzzzzzzzzzzzzzzzzzzzzzzzn_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, izzzzzzzzzzzzzzzzzzzzzzzzm_);
            bool? izzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Overlaps(izzzzzzzzzzzzzzzzzzzzzzzzl_, izzzzzzzzzzzzzzzzzzzzzzzzn_, default);
            bool? izzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.And(izzzzzzzzzzzzzzzzzzzzzzzzk_, izzzzzzzzzzzzzzzzzzzzzzzzo_);
            DataType izzzzzzzzzzzzzzzzzzzzzzzzq_ = tuple_cibligzrihjljqmithporoase?.ChemoBeforeEncounter?.Performed;
            object izzzzzzzzzzzzzzzzzzzzzzzzr_ = FHIRHelpers_4_4_000.Instance.ToValue(context, izzzzzzzzzzzzzzzzzzzzzzzzq_);
            CqlInterval<CqlDateTime> izzzzzzzzzzzzzzzzzzzzzzzzs_ = QICoreCommon_2_1_000.Instance.toInterval(context, izzzzzzzzzzzzzzzzzzzzzzzzr_);
            CqlDateTime izzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Start(izzzzzzzzzzzzzzzzzzzzzzzzs_);
            CqlInterval<CqlDateTime> izzzzzzzzzzzzzzzzzzzzzzzzv_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, izzzzzzzzzzzzzzzzzzzzzzzzm_);
            CqlDateTime izzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.End(izzzzzzzzzzzzzzzzzzzzzzzzv_);
            CqlQuantity izzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Quantity(30m, "days");
            CqlDateTime izzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Subtract(izzzzzzzzzzzzzzzzzzzzzzzzw_, izzzzzzzzzzzzzzzzzzzzzzzzx_);
            CqlInterval<CqlDateTime> jzzzzzzzzzzzzzzzzzzzzzzzza_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, izzzzzzzzzzzzzzzzzzzzzzzzm_);
            CqlDateTime jzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.End(jzzzzzzzzzzzzzzzzzzzzzzzza_);
            CqlInterval<CqlDateTime> jzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Interval(izzzzzzzzzzzzzzzzzzzzzzzzy_, jzzzzzzzzzzzzzzzzzzzzzzzzb_, true, true);
            bool? jzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.In<CqlDateTime>(izzzzzzzzzzzzzzzzzzzzzzzzt_, jzzzzzzzzzzzzzzzzzzzzzzzzc_, "day");
            CqlInterval<CqlDateTime> jzzzzzzzzzzzzzzzzzzzzzzzzf_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, izzzzzzzzzzzzzzzzzzzzzzzzm_);
            CqlDateTime jzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.End(jzzzzzzzzzzzzzzzzzzzzzzzzf_);
            bool? jzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Not((bool?)(jzzzzzzzzzzzzzzzzzzzzzzzzg_ is null));
            bool? jzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.And(jzzzzzzzzzzzzzzzzzzzzzzzzd_, jzzzzzzzzzzzzzzzzzzzzzzzzh_);
            bool? jzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.And(izzzzzzzzzzzzzzzzzzzzzzzzp_, jzzzzzzzzzzzzzzzzzzzzzzzzi_);
            DataType jzzzzzzzzzzzzzzzzzzzzzzzzk_ = tuple_cibligzrihjljqmithporoase?.ChemoAfterEncounter?.Performed;
            object jzzzzzzzzzzzzzzzzzzzzzzzzl_ = FHIRHelpers_4_4_000.Instance.ToValue(context, jzzzzzzzzzzzzzzzzzzzzzzzzk_);
            CqlInterval<CqlDateTime> jzzzzzzzzzzzzzzzzzzzzzzzzm_ = QICoreCommon_2_1_000.Instance.toInterval(context, jzzzzzzzzzzzzzzzzzzzzzzzzl_);
            CqlDateTime jzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Start(jzzzzzzzzzzzzzzzzzzzzzzzzm_);
            CqlInterval<CqlDateTime> jzzzzzzzzzzzzzzzzzzzzzzzzp_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, izzzzzzzzzzzzzzzzzzzzzzzzm_);
            CqlDateTime jzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.End(jzzzzzzzzzzzzzzzzzzzzzzzzp_);
            CqlInterval<CqlDateTime> jzzzzzzzzzzzzzzzzzzzzzzzzs_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, izzzzzzzzzzzzzzzzzzzzzzzzm_);
            CqlDateTime jzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.End(jzzzzzzzzzzzzzzzzzzzzzzzzs_);
            CqlDateTime jzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Add(jzzzzzzzzzzzzzzzzzzzzzzzzt_, izzzzzzzzzzzzzzzzzzzzzzzzx_);
            CqlInterval<CqlDateTime> jzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Interval(jzzzzzzzzzzzzzzzzzzzzzzzzq_, jzzzzzzzzzzzzzzzzzzzzzzzzv_, true, true);
            bool? jzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.In<CqlDateTime>(jzzzzzzzzzzzzzzzzzzzzzzzzn_, jzzzzzzzzzzzzzzzzzzzzzzzzw_, "day");
            CqlInterval<CqlDateTime> jzzzzzzzzzzzzzzzzzzzzzzzzz_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, izzzzzzzzzzzzzzzzzzzzzzzzm_);
            CqlDateTime kzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.End(jzzzzzzzzzzzzzzzzzzzzzzzzz_);
            bool? kzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Not((bool?)(kzzzzzzzzzzzzzzzzzzzzzzzza_ is null));
            bool? kzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.And(jzzzzzzzzzzzzzzzzzzzzzzzzx_, kzzzzzzzzzzzzzzzzzzzzzzzzb_);
            bool? kzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.And(jzzzzzzzzzzzzzzzzzzzzzzzzj_, kzzzzzzzzzzzzzzzzzzzzzzzzc_);
            object kzzzzzzzzzzzzzzzzzzzzzzzzf_ = FHIRHelpers_4_4_000.Instance.ToValue(context, jzzzzzzzzzzzzzzzzzzzzzzzzk_);
            CqlInterval<CqlDateTime> kzzzzzzzzzzzzzzzzzzzzzzzzg_ = QICoreCommon_2_1_000.Instance.toInterval(context, kzzzzzzzzzzzzzzzzzzzzzzzzf_);
            object kzzzzzzzzzzzzzzzzzzzzzzzzi_ = FHIRHelpers_4_4_000.Instance.ToValue(context, izzzzzzzzzzzzzzzzzzzzzzzzq_);
            CqlInterval<CqlDateTime> kzzzzzzzzzzzzzzzzzzzzzzzzj_ = QICoreCommon_2_1_000.Instance.toInterval(context, kzzzzzzzzzzzzzzzzzzzzzzzzi_);
            bool? kzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.SameAs<CqlDateTime>(kzzzzzzzzzzzzzzzzzzzzzzzzg_, kzzzzzzzzzzzzzzzzzzzzzzzzj_, "day");
            bool? kzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Not(kzzzzzzzzzzzzzzzzzzzzzzzzk_);
            bool? kzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.And(kzzzzzzzzzzzzzzzzzzzzzzzzd_, kzzzzzzzzzzzzzzzzzzzzzzzzl_);
            CqlInterval<CqlDateTime> kzzzzzzzzzzzzzzzzzzzzzzzzn_ = this.Measurement_Period(context);
            CqlInterval<CqlDateTime> kzzzzzzzzzzzzzzzzzzzzzzzzp_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, izzzzzzzzzzzzzzzzzzzzzzzzm_);
            bool? kzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(kzzzzzzzzzzzzzzzzzzzzzzzzn_, kzzzzzzzzzzzzzzzzzzzzzzzzp_, default);
            bool? kzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.And(kzzzzzzzzzzzzzzzzzzzzzzzzm_, kzzzzzzzzzzzzzzzzzzzzzzzzq_);
            Code<Encounter.EncounterStatus> kzzzzzzzzzzzzzzzzzzzzzzzzs_ = tuple_cibligzrihjljqmithporoase?.FaceToFaceOrTelehealthEncounter?.StatusElement;
            Encounter.EncounterStatus? kzzzzzzzzzzzzzzzzzzzzzzzzt_ = kzzzzzzzzzzzzzzzzzzzzzzzzs_?.Value;
            Code<Encounter.EncounterStatus> kzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(kzzzzzzzzzzzzzzzzzzzzzzzzt_);
            bool? kzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Equal(kzzzzzzzzzzzzzzzzzzzzzzzzu_, "finished");
            bool? kzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.And(kzzzzzzzzzzzzzzzzzzzzzzzzr_, kzzzzzzzzzzzzzzzzzzzzzzzzv_);

            return kzzzzzzzzzzzzzzzzzzzzzzzzw_;
        };
        IEnumerable<(CqlTupleMetadata, Encounter FaceToFaceOrTelehealthEncounter, Procedure ChemoBeforeEncounter, Procedure ChemoAfterEncounter, Condition Cancer)?> izzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Where<(CqlTupleMetadata, Encounter FaceToFaceOrTelehealthEncounter, Procedure ChemoBeforeEncounter, Procedure ChemoAfterEncounter, Condition Cancer)?>(izzzzzzzzzzzzzzzzzzzzzzzzd_, izzzzzzzzzzzzzzzzzzzzzzzze_);
        Encounter izzzzzzzzzzzzzzzzzzzzzzzzg_((CqlTupleMetadata, Encounter FaceToFaceOrTelehealthEncounter, Procedure ChemoBeforeEncounter, Procedure ChemoAfterEncounter, Condition Cancer)? tuple_cibligzrihjljqmithporoase) =>
            tuple_cibligzrihjljqmithporoase?.FaceToFaceOrTelehealthEncounter;
        IEnumerable<Encounter> izzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Select<(CqlTupleMetadata, Encounter FaceToFaceOrTelehealthEncounter, Procedure ChemoBeforeEncounter, Procedure ChemoAfterEncounter, Condition Cancer)?, Encounter>(izzzzzzzzzzzzzzzzzzzzzzzzf_, izzzzzzzzzzzzzzzzzzzzzzzzg_);
        IEnumerable<Encounter> izzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Distinct<Encounter>(izzzzzzzzzzzzzzzzzzzzzzzzh_);

        return izzzzzzzzzzzzzzzzzzzzzzzzi_;
    }


    [CqlExpressionDefinition("Initial Population 1")]
    public IEnumerable<Encounter> Initial_Population_1(CqlContext context)
    {
        IEnumerable<Encounter> kzzzzzzzzzzzzzzzzzzzzzzzzx_ = this.Face_to_Face_or_Telehealth_Encounter_with_Ongoing_Chemotherapy(context);

        return kzzzzzzzzzzzzzzzzzzzzzzzzx_;
    }


    [CqlExpressionDefinition("Denominator 1")]
    public IEnumerable<Encounter> Denominator_1(CqlContext context)
    {
        IEnumerable<Encounter> kzzzzzzzzzzzzzzzzzzzzzzzzy_ = this.Initial_Population_1(context);

        return kzzzzzzzzzzzzzzzzzzzzzzzzy_;
    }


    [CqlExpressionDefinition("Radiation Treatment Management During Measurement Period with Cancer Diagnosis")]
    public IEnumerable<Encounter> Radiation_Treatment_Management_During_Measurement_Period_with_Cancer_Diagnosis(CqlContext context)
    {
        CqlValueSet kzzzzzzzzzzzzzzzzzzzzzzzzz_ = this.Radiation_Treatment_Management(context);
        IEnumerable<Encounter> lzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, kzzzzzzzzzzzzzzzzzzzzzzzzz_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> lzzzzzzzzzzzzzzzzzzzzzzzzb_(Encounter RadiationTreatmentManagement)
        {
            CqlValueSet lzzzzzzzzzzzzzzzzzzzzzzzzf_ = this.Cancer(context);
            IEnumerable<Condition> lzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, lzzzzzzzzzzzzzzzzzzzzzzzzf_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
            bool? lzzzzzzzzzzzzzzzzzzzzzzzzh_(Condition Cancer)
            {
                bool? lzzzzzzzzzzzzzzzzzzzzzzzzl_ = QICoreCommon_2_1_000.Instance.isActive(context, Cancer);
                CqlInterval<CqlDateTime> lzzzzzzzzzzzzzzzzzzzzzzzzm_ = QICoreCommon_2_1_000.Instance.prevalenceInterval(context, Cancer);
                Period lzzzzzzzzzzzzzzzzzzzzzzzzn_ = RadiationTreatmentManagement?.Period;
                CqlInterval<CqlDateTime> lzzzzzzzzzzzzzzzzzzzzzzzzo_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, lzzzzzzzzzzzzzzzzzzzzzzzzn_);
                bool? lzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Overlaps(lzzzzzzzzzzzzzzzzzzzzzzzzm_, lzzzzzzzzzzzzzzzzzzzzzzzzo_, default);
                bool? lzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.And(lzzzzzzzzzzzzzzzzzzzzzzzzl_, lzzzzzzzzzzzzzzzzzzzzzzzzp_);

                return lzzzzzzzzzzzzzzzzzzzzzzzzq_;
            };
            IEnumerable<Condition> lzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Where<Condition>(lzzzzzzzzzzzzzzzzzzzzzzzzg_, lzzzzzzzzzzzzzzzzzzzzzzzzh_);
            Encounter lzzzzzzzzzzzzzzzzzzzzzzzzj_(Condition Cancer) =>
                RadiationTreatmentManagement;
            IEnumerable<Encounter> lzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Select<Condition, Encounter>(lzzzzzzzzzzzzzzzzzzzzzzzzi_, lzzzzzzzzzzzzzzzzzzzzzzzzj_);

            return lzzzzzzzzzzzzzzzzzzzzzzzzk_;
        };
        IEnumerable<Encounter> lzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.SelectMany<Encounter, Encounter>(lzzzzzzzzzzzzzzzzzzzzzzzza_, lzzzzzzzzzzzzzzzzzzzzzzzzb_);
        bool? lzzzzzzzzzzzzzzzzzzzzzzzzd_(Encounter RadiationTreatmentManagement)
        {
            CqlInterval<CqlDateTime> lzzzzzzzzzzzzzzzzzzzzzzzzr_ = this.Measurement_Period(context);
            Period lzzzzzzzzzzzzzzzzzzzzzzzzs_ = RadiationTreatmentManagement?.Period;
            CqlInterval<CqlDateTime> lzzzzzzzzzzzzzzzzzzzzzzzzt_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, lzzzzzzzzzzzzzzzzzzzzzzzzs_);
            bool? lzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(lzzzzzzzzzzzzzzzzzzzzzzzzr_, lzzzzzzzzzzzzzzzzzzzzzzzzt_, default);
            Code<Encounter.EncounterStatus> lzzzzzzzzzzzzzzzzzzzzzzzzv_ = RadiationTreatmentManagement?.StatusElement;
            Encounter.EncounterStatus? lzzzzzzzzzzzzzzzzzzzzzzzzw_ = lzzzzzzzzzzzzzzzzzzzzzzzzv_?.Value;
            Code<Encounter.EncounterStatus> lzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(lzzzzzzzzzzzzzzzzzzzzzzzzw_);
            bool? lzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Equal(lzzzzzzzzzzzzzzzzzzzzzzzzx_, "finished");
            bool? lzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.And(lzzzzzzzzzzzzzzzzzzzzzzzzu_, lzzzzzzzzzzzzzzzzzzzzzzzzy_);

            return lzzzzzzzzzzzzzzzzzzzzzzzzz_;
        };
        IEnumerable<Encounter> lzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Where<Encounter>(lzzzzzzzzzzzzzzzzzzzzzzzzc_, lzzzzzzzzzzzzzzzzzzzzzzzzd_);

        return lzzzzzzzzzzzzzzzzzzzzzzzze_;
    }


    [CqlExpressionDefinition("Initial Population 2")]
    public IEnumerable<Encounter> Initial_Population_2(CqlContext context)
    {
        IEnumerable<Encounter> mzzzzzzzzzzzzzzzzzzzzzzzza_ = this.Radiation_Treatment_Management_During_Measurement_Period_with_Cancer_Diagnosis(context);

        return mzzzzzzzzzzzzzzzzzzzzzzzza_;
    }


    [CqlExpressionDefinition("Denominator 2")]
    public IEnumerable<Encounter> Denominator_2(CqlContext context)
    {
        IEnumerable<Encounter> mzzzzzzzzzzzzzzzzzzzzzzzzb_ = this.Initial_Population_2(context);

        return mzzzzzzzzzzzzzzzzzzzzzzzzb_;
    }


    [CqlExpressionDefinition("Standard Pain Assessment with Result")]
    public IEnumerable<Observation> Standard_Pain_Assessment_with_Result(CqlContext context)
    {
        CqlValueSet mzzzzzzzzzzzzzzzzzzzzzzzzc_ = this.Standardized_Pain_Assessment_Tool(context);
        IEnumerable<Observation> mzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, mzzzzzzzzzzzzzzzzzzzzzzzzc_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        bool? mzzzzzzzzzzzzzzzzzzzzzzzze_(Observation AssessedPain)
        {
            DataType mzzzzzzzzzzzzzzzzzzzzzzzzg_ = AssessedPain?.Value;
            object mzzzzzzzzzzzzzzzzzzzzzzzzh_ = FHIRHelpers_4_4_000.Instance.ToValue(context, mzzzzzzzzzzzzzzzzzzzzzzzzg_);
            bool? mzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Not((bool?)(mzzzzzzzzzzzzzzzzzzzzzzzzh_ is null));
            Code<ObservationStatus> mzzzzzzzzzzzzzzzzzzzzzzzzj_ = AssessedPain?.StatusElement;
            ObservationStatus? mzzzzzzzzzzzzzzzzzzzzzzzzk_ = mzzzzzzzzzzzzzzzzzzzzzzzzj_?.Value;
            Code<ObservationStatus> mzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Convert<Code<ObservationStatus>>(mzzzzzzzzzzzzzzzzzzzzzzzzk_);
            bool? mzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Equal(mzzzzzzzzzzzzzzzzzzzzzzzzl_, "final");
            bool? mzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.And(mzzzzzzzzzzzzzzzzzzzzzzzzi_, mzzzzzzzzzzzzzzzzzzzzzzzzm_);

            return mzzzzzzzzzzzzzzzzzzzzzzzzn_;
        };
        IEnumerable<Observation> mzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Where<Observation>(mzzzzzzzzzzzzzzzzzzzzzzzzd_, mzzzzzzzzzzzzzzzzzzzzzzzze_);

        return mzzzzzzzzzzzzzzzzzzzzzzzzf_;
    }


    [CqlExpressionDefinition("Numerator 1")]
    public IEnumerable<Encounter> Numerator_1(CqlContext context)
    {
        IEnumerable<Encounter> mzzzzzzzzzzzzzzzzzzzzzzzzo_ = this.Face_to_Face_or_Telehealth_Encounter_with_Ongoing_Chemotherapy(context);
        IEnumerable<Encounter> mzzzzzzzzzzzzzzzzzzzzzzzzp_(Encounter FaceToFaceOrTelehealthEncounterWithChemo)
        {
            IEnumerable<Observation> mzzzzzzzzzzzzzzzzzzzzzzzzr_ = this.Standard_Pain_Assessment_with_Result(context);
            bool? mzzzzzzzzzzzzzzzzzzzzzzzzs_(Observation PainAssessed)
            {
                Period mzzzzzzzzzzzzzzzzzzzzzzzzw_ = FaceToFaceOrTelehealthEncounterWithChemo?.Period;
                CqlInterval<CqlDateTime> mzzzzzzzzzzzzzzzzzzzzzzzzx_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, mzzzzzzzzzzzzzzzzzzzzzzzzw_);
                DataType mzzzzzzzzzzzzzzzzzzzzzzzzy_ = PainAssessed?.Effective;
                object mzzzzzzzzzzzzzzzzzzzzzzzzz_ = FHIRHelpers_4_4_000.Instance.ToValue(context, mzzzzzzzzzzzzzzzzzzzzzzzzy_);
                CqlInterval<CqlDateTime> nzzzzzzzzzzzzzzzzzzzzzzzza_ = QICoreCommon_2_1_000.Instance.toInterval(context, mzzzzzzzzzzzzzzzzzzzzzzzzz_);
                bool? nzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(mzzzzzzzzzzzzzzzzzzzzzzzzx_, nzzzzzzzzzzzzzzzzzzzzzzzza_, default);

                return nzzzzzzzzzzzzzzzzzzzzzzzzb_;
            };
            IEnumerable<Observation> mzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Where<Observation>(mzzzzzzzzzzzzzzzzzzzzzzzzr_, mzzzzzzzzzzzzzzzzzzzzzzzzs_);
            Encounter mzzzzzzzzzzzzzzzzzzzzzzzzu_(Observation PainAssessed) =>
                FaceToFaceOrTelehealthEncounterWithChemo;
            IEnumerable<Encounter> mzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Select<Observation, Encounter>(mzzzzzzzzzzzzzzzzzzzzzzzzt_, mzzzzzzzzzzzzzzzzzzzzzzzzu_);

            return mzzzzzzzzzzzzzzzzzzzzzzzzv_;
        };
        IEnumerable<Encounter> mzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.SelectMany<Encounter, Encounter>(mzzzzzzzzzzzzzzzzzzzzzzzzo_, mzzzzzzzzzzzzzzzzzzzzzzzzp_);

        return mzzzzzzzzzzzzzzzzzzzzzzzzq_;
    }


    [CqlExpressionDefinition("Numerator 2")]
    public IEnumerable<Encounter> Numerator_2(CqlContext context)
    {
        IEnumerable<Encounter> nzzzzzzzzzzzzzzzzzzzzzzzzc_ = this.Radiation_Treatment_Management_During_Measurement_Period_with_Cancer_Diagnosis(context);
        IEnumerable<Encounter> nzzzzzzzzzzzzzzzzzzzzzzzzd_(Encounter RadiationManagementEncounter)
        {
            IEnumerable<Observation> nzzzzzzzzzzzzzzzzzzzzzzzzf_ = this.Standard_Pain_Assessment_with_Result(context);
            bool? nzzzzzzzzzzzzzzzzzzzzzzzzg_(Observation PainAssessed)
            {
                bool? nzzzzzzzzzzzzzzzzzzzzzzzzk_()
                {
                    bool nzzzzzzzzzzzzzzzzzzzzzzzzl_()
                    {
                        List<CodeableConcept> nzzzzzzzzzzzzzzzzzzzzzzzzm_ = RadiationManagementEncounter?.Type;
                        CqlConcept nzzzzzzzzzzzzzzzzzzzzzzzzn_(CodeableConcept @this)
                        {
                            CqlConcept nzzzzzzzzzzzzzzzzzzzzzzzzs_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);

                            return nzzzzzzzzzzzzzzzzzzzzzzzzs_;
                        };
                        IEnumerable<CqlConcept> nzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)nzzzzzzzzzzzzzzzzzzzzzzzzm_, nzzzzzzzzzzzzzzzzzzzzzzzzn_);
                        bool? nzzzzzzzzzzzzzzzzzzzzzzzzp_(CqlConcept RadiationManagement)
                        {
                            CqlCode nzzzzzzzzzzzzzzzzzzzzzzzzt_ = this.Radiation_treatment_management__5_treatments(context);
                            CqlConcept nzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.ConvertCodeToConcept(nzzzzzzzzzzzzzzzzzzzzzzzzt_);
                            bool? nzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Equivalent(RadiationManagement, nzzzzzzzzzzzzzzzzzzzzzzzzu_);

                            return nzzzzzzzzzzzzzzzzzzzzzzzzv_;
                        };
                        IEnumerable<CqlConcept> nzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Where<CqlConcept>(nzzzzzzzzzzzzzzzzzzzzzzzzo_, nzzzzzzzzzzzzzzzzzzzzzzzzp_);
                        bool? nzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Exists<CqlConcept>(nzzzzzzzzzzzzzzzzzzzzzzzzq_);

                        return nzzzzzzzzzzzzzzzzzzzzzzzzr_ ?? false;
                    };
                    if (nzzzzzzzzzzzzzzzzzzzzzzzzl_())
                    {
                        DataType nzzzzzzzzzzzzzzzzzzzzzzzzw_ = PainAssessed?.Effective;
                        object nzzzzzzzzzzzzzzzzzzzzzzzzx_ = FHIRHelpers_4_4_000.Instance.ToValue(context, nzzzzzzzzzzzzzzzzzzzzzzzzw_);
                        CqlInterval<CqlDateTime> nzzzzzzzzzzzzzzzzzzzzzzzzy_ = QICoreCommon_2_1_000.Instance.toInterval(context, nzzzzzzzzzzzzzzzzzzzzzzzzx_);
                        CqlDateTime nzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.End(nzzzzzzzzzzzzzzzzzzzzzzzzy_);
                        Period ozzzzzzzzzzzzzzzzzzzzzzzza_ = RadiationManagementEncounter?.Period;
                        CqlInterval<CqlDateTime> ozzzzzzzzzzzzzzzzzzzzzzzzb_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ozzzzzzzzzzzzzzzzzzzzzzzza_);
                        CqlDateTime ozzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Start(ozzzzzzzzzzzzzzzzzzzzzzzzb_);
                        CqlQuantity ozzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Quantity(6m, "days");
                        CqlDateTime ozzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Subtract(ozzzzzzzzzzzzzzzzzzzzzzzzc_, ozzzzzzzzzzzzzzzzzzzzzzzzd_);
                        CqlInterval<CqlDateTime> ozzzzzzzzzzzzzzzzzzzzzzzzg_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ozzzzzzzzzzzzzzzzzzzzzzzza_);
                        CqlDateTime ozzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Start(ozzzzzzzzzzzzzzzzzzzzzzzzg_);
                        CqlInterval<CqlDateTime> ozzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Interval(ozzzzzzzzzzzzzzzzzzzzzzzze_, ozzzzzzzzzzzzzzzzzzzzzzzzh_, true, true);
                        bool? ozzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.In<CqlDateTime>(nzzzzzzzzzzzzzzzzzzzzzzzzz_, ozzzzzzzzzzzzzzzzzzzzzzzzi_, "day");
                        CqlInterval<CqlDateTime> ozzzzzzzzzzzzzzzzzzzzzzzzl_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ozzzzzzzzzzzzzzzzzzzzzzzza_);
                        CqlDateTime ozzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Start(ozzzzzzzzzzzzzzzzzzzzzzzzl_);
                        bool? ozzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Not((bool?)(ozzzzzzzzzzzzzzzzzzzzzzzzm_ is null));
                        bool? ozzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.And(ozzzzzzzzzzzzzzzzzzzzzzzzj_, ozzzzzzzzzzzzzzzzzzzzzzzzn_);

                        return ozzzzzzzzzzzzzzzzzzzzzzzzo_;
                    }
                    else
                    {
                        Period ozzzzzzzzzzzzzzzzzzzzzzzzp_ = RadiationManagementEncounter?.Period;
                        CqlInterval<CqlDateTime> ozzzzzzzzzzzzzzzzzzzzzzzzq_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ozzzzzzzzzzzzzzzzzzzzzzzzp_);
                        DataType ozzzzzzzzzzzzzzzzzzzzzzzzr_ = PainAssessed?.Effective;
                        object ozzzzzzzzzzzzzzzzzzzzzzzzs_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ozzzzzzzzzzzzzzzzzzzzzzzzr_);
                        CqlInterval<CqlDateTime> ozzzzzzzzzzzzzzzzzzzzzzzzt_ = QICoreCommon_2_1_000.Instance.toInterval(context, ozzzzzzzzzzzzzzzzzzzzzzzzs_);
                        bool? ozzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(ozzzzzzzzzzzzzzzzzzzzzzzzq_, ozzzzzzzzzzzzzzzzzzzzzzzzt_, "day");

                        return ozzzzzzzzzzzzzzzzzzzzzzzzu_;
                    }
                };

                return nzzzzzzzzzzzzzzzzzzzzzzzzk_();
            };
            IEnumerable<Observation> nzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Where<Observation>(nzzzzzzzzzzzzzzzzzzzzzzzzf_, nzzzzzzzzzzzzzzzzzzzzzzzzg_);
            Encounter nzzzzzzzzzzzzzzzzzzzzzzzzi_(Observation PainAssessed) =>
                RadiationManagementEncounter;
            IEnumerable<Encounter> nzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Select<Observation, Encounter>(nzzzzzzzzzzzzzzzzzzzzzzzzh_, nzzzzzzzzzzzzzzzzzzzzzzzzi_);

            return nzzzzzzzzzzzzzzzzzzzzzzzzj_;
        };
        IEnumerable<Encounter> nzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.SelectMany<Encounter, Encounter>(nzzzzzzzzzzzzzzzzzzzzzzzzc_, nzzzzzzzzzzzzzzzzzzzzzzzzd_);

        return nzzzzzzzzzzzzzzzzzzzzzzzze_;
    }


    [CqlExpressionDefinition("SDE Ethnicity")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Ethnicity(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? ozzzzzzzzzzzzzzzzzzzzzzzzv_ = SupplementalDataElements_3_5_000.Instance.SDE_Ethnicity(context);

        return ozzzzzzzzzzzzzzzzzzzzzzzzv_;
    }


    [CqlExpressionDefinition("SDE Payer")]
    public IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> SDE_Payer(CqlContext context)
    {
        IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> ozzzzzzzzzzzzzzzzzzzzzzzzw_ = SupplementalDataElements_3_5_000.Instance.SDE_Payer(context);

        return ozzzzzzzzzzzzzzzzzzzzzzzzw_;
    }


    [CqlExpressionDefinition("SDE Race")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Race(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? ozzzzzzzzzzzzzzzzzzzzzzzzx_ = SupplementalDataElements_3_5_000.Instance.SDE_Race(context);

        return ozzzzzzzzzzzzzzzzzzzzzzzzx_;
    }


    [CqlExpressionDefinition("SDE Sex")]
    public CqlCode SDE_Sex(CqlContext context)
    {
        CqlCode ozzzzzzzzzzzzzzzzzzzzzzzzy_ = SupplementalDataElements_3_5_000.Instance.SDE_Sex(context);

        return ozzzzzzzzzzzzzzzzzzzzzzzzy_;
    }


    #endregion Expressions

    #region CqlTupleMetadata Properties

    private static CqlTupleMetadata CqlTupleMetadata_GEQGUKVdHYQAZdGbSEBAPcHZR = new(
        [typeof(Encounter), typeof(Procedure), typeof(Procedure), typeof(Condition)],
        ["FaceToFaceOrTelehealthEncounter", "ChemoBeforeEncounter", "ChemoAfterEncounter", "Cancer"]);

    #endregion CqlTupleMetadata Properties

}
