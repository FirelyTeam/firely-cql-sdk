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
[CqlLibrary("DRCommunicationWithPhysicianManagingDiabetesFHIR", "0.1.000")]
public partial class DRCommunicationWithPhysicianManagingDiabetesFHIR_0_1_000 : ILibrary, ISingleton<DRCommunicationWithPhysicianManagingDiabetesFHIR_0_1_000>
{
    private DRCommunicationWithPhysicianManagingDiabetesFHIR_0_1_000() {}

    public static DRCommunicationWithPhysicianManagingDiabetesFHIR_0_1_000 Instance { get; } = new();

    #region ILibrary Implementation

    public string Name => "DRCommunicationWithPhysicianManagingDiabetesFHIR";
    public string Version => "0.1.000";
    public ILibrary[] Dependencies => [FHIRHelpers_4_4_000.Instance, SupplementalDataElements_3_5_000.Instance, QICoreCommon_2_1_000.Instance];

    #endregion ILibrary Implementation

    #region ValueSets

    [CqlValueSetDefinition("Care Services in Long-Term Residential Facility", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1014", valueSetVersion: null)]
    public CqlValueSet Care_Services_in_Long_Term_Residential_Facility(CqlContext _) => _Care_Services_in_Long_Term_Residential_Facility;
    private static readonly CqlValueSet _Care_Services_in_Long_Term_Residential_Facility = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1014", null);

    [CqlValueSetDefinition("Diabetic Retinopathy", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.327", valueSetVersion: null)]
    public CqlValueSet Diabetic_Retinopathy(CqlContext _) => _Diabetic_Retinopathy;
    private static readonly CqlValueSet _Diabetic_Retinopathy = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.327", null);

    [CqlValueSetDefinition("Level of Severity of Retinopathy Findings", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1283", valueSetVersion: null)]
    public CqlValueSet Level_of_Severity_of_Retinopathy_Findings(CqlContext _) => _Level_of_Severity_of_Retinopathy_Findings;
    private static readonly CqlValueSet _Level_of_Severity_of_Retinopathy_Findings = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1283", null);

    [CqlValueSetDefinition("Macular Edema Findings Present", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1320", valueSetVersion: null)]
    public CqlValueSet Macular_Edema_Findings_Present(CqlContext _) => _Macular_Edema_Findings_Present;
    private static readonly CqlValueSet _Macular_Edema_Findings_Present = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1320", null);

    [CqlValueSetDefinition("Macular Exam", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1251", valueSetVersion: null)]
    public CqlValueSet Macular_Exam(CqlContext _) => _Macular_Exam;
    private static readonly CqlValueSet _Macular_Exam = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1251", null);

    [CqlValueSetDefinition("Medical Reason", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1007", valueSetVersion: null)]
    public CqlValueSet Medical_Reason(CqlContext _) => _Medical_Reason;
    private static readonly CqlValueSet _Medical_Reason = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1007", null);

    [CqlValueSetDefinition("Nursing Facility Visit", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1012", valueSetVersion: null)]
    public CqlValueSet Nursing_Facility_Visit(CqlContext _) => _Nursing_Facility_Visit;
    private static readonly CqlValueSet _Nursing_Facility_Visit = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1012", null);

    [CqlValueSetDefinition("Office Visit", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1001", valueSetVersion: null)]
    public CqlValueSet Office_Visit(CqlContext _) => _Office_Visit;
    private static readonly CqlValueSet _Office_Visit = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1001", null);

    [CqlValueSetDefinition("Ophthalmological Services", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1285", valueSetVersion: null)]
    public CqlValueSet Ophthalmological_Services(CqlContext _) => _Ophthalmological_Services;
    private static readonly CqlValueSet _Ophthalmological_Services = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1285", null);

    [CqlValueSetDefinition("Outpatient Consultation", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1008", valueSetVersion: null)]
    public CqlValueSet Outpatient_Consultation(CqlContext _) => _Outpatient_Consultation;
    private static readonly CqlValueSet _Outpatient_Consultation = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1008", null);

    [CqlValueSetDefinition("Patient Reason", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1008", valueSetVersion: null)]
    public CqlValueSet Patient_Reason(CqlContext _) => _Patient_Reason;
    private static readonly CqlValueSet _Patient_Reason = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1008", null);

    [CqlValueSetDefinition("Macular edema absent (situation)", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.2.1391", valueSetVersion: null)]
    public CqlValueSet Macular_edema_absent__situation_(CqlContext _) => _Macular_edema_absent__situation_;
    private static readonly CqlValueSet _Macular_edema_absent__situation_ = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.2.1391", null);

    #endregion ValueSets

    #region Codes

    [CqlCodeDefinition("Healthcare professional (occupation)", codeId: "223366009", codeSystem: "http://snomed.info/sct")]
    public CqlCode Healthcare_professional__occupation_(CqlContext _) => _Healthcare_professional__occupation_;
    private static readonly CqlCode _Healthcare_professional__occupation_ = new CqlCode("223366009", "http://snomed.info/sct", default, default);

    [CqlCodeDefinition("Medical practitioner (occupation)", codeId: "158965000", codeSystem: "http://snomed.info/sct")]
    public CqlCode Medical_practitioner__occupation_(CqlContext _) => _Medical_practitioner__occupation_;
    private static readonly CqlCode _Medical_practitioner__occupation_ = new CqlCode("158965000", "http://snomed.info/sct", default, default);

    [CqlCodeDefinition("Ophthalmologist (occupation)", codeId: "422234006", codeSystem: "http://snomed.info/sct")]
    public CqlCode Ophthalmologist__occupation_(CqlContext _) => _Ophthalmologist__occupation_;
    private static readonly CqlCode _Ophthalmologist__occupation_ = new CqlCode("422234006", "http://snomed.info/sct", default, default);

    [CqlCodeDefinition("Optometrist (occupation)", codeId: "28229004", codeSystem: "http://snomed.info/sct")]
    public CqlCode Optometrist__occupation_(CqlContext _) => _Optometrist__occupation_;
    private static readonly CqlCode _Optometrist__occupation_ = new CqlCode("28229004", "http://snomed.info/sct", default, default);

    [CqlCodeDefinition("Physician (occupation)", codeId: "309343006", codeSystem: "http://snomed.info/sct")]
    public CqlCode Physician__occupation_(CqlContext _) => _Physician__occupation_;
    private static readonly CqlCode _Physician__occupation_ = new CqlCode("309343006", "http://snomed.info/sct", default, default);

    [CqlCodeDefinition("virtual", codeId: "VR", codeSystem: "http://terminology.hl7.org/CodeSystem/v3-ActCode")]
    public CqlCode @virtual(CqlContext _) => _virtual;
    private static readonly CqlCode _virtual = new CqlCode("VR", "http://terminology.hl7.org/CodeSystem/v3-ActCode", default, default);

    [CqlCodeDefinition("AMB", codeId: "AMB", codeSystem: "http://terminology.hl7.org/CodeSystem/v3-ActCode")]
    public CqlCode AMB(CqlContext _) => _AMB;
    private static readonly CqlCode _AMB = new CqlCode("AMB", "http://terminology.hl7.org/CodeSystem/v3-ActCode", default, default);

    #endregion Codes

    #region CodeSystems

    [CqlCodeSystemDefinition("SNOMEDCT")]
    public CqlCodeSystem SNOMEDCT(CqlContext _) => _SNOMEDCT;
    private static readonly CqlCodeSystem _SNOMEDCT = new CqlCodeSystem();

    [CqlCodeSystemDefinition("ActCode")]
    public CqlCodeSystem ActCode(CqlContext _) => _ActCode;
    private static readonly CqlCodeSystem _ActCode = new CqlCodeSystem();

    #endregion CodeSystems

    #region Parameters

    [CqlParameterDefinition("Measurement Period")]
    public CqlInterval<CqlDateTime> Measurement_Period(CqlContext context)
    {
        CqlDateTime yzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.DateTime(2025, 1, 1, 0, 0, 0, 0, 0.0m);
        CqlDateTime yzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.DateTime(2025, 12, 31, 23, 59, 59, 999, 0.0m);
        CqlInterval<CqlDateTime> yzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Interval(yzzzzzzzzzzzzzzzzzzzzzzzzzzzm_, yzzzzzzzzzzzzzzzzzzzzzzzzzzzn_, true, true);
        object yzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.ResolveParameter("DRCommunicationWithPhysicianManagingDiabetesFHIR-0.1.000", "Measurement Period", yzzzzzzzzzzzzzzzzzzzzzzzzzzzo_);

        return (CqlInterval<CqlDateTime>)yzzzzzzzzzzzzzzzzzzzzzzzzzzzp_;
    }


    #endregion Parameters

    #region Expressions

    [CqlExpressionDefinition("Patient")]
    public Patient Patient(CqlContext context)
    {
        IEnumerable<Patient> yzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-patient"));
        Patient yzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.SingletonFrom<Patient>(yzzzzzzzzzzzzzzzzzzzzzzzzzzzq_);

        return yzzzzzzzzzzzzzzzzzzzzzzzzzzzr_;
    }


    [CqlExpressionDefinition("SDE Ethnicity")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Ethnicity(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? yzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = SupplementalDataElements_3_5_000.Instance.SDE_Ethnicity(context);

        return yzzzzzzzzzzzzzzzzzzzzzzzzzzzs_;
    }


    [CqlExpressionDefinition("SDE Payer")]
    public IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> SDE_Payer(CqlContext context)
    {
        IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> yzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = SupplementalDataElements_3_5_000.Instance.SDE_Payer(context);

        return yzzzzzzzzzzzzzzzzzzzzzzzzzzzt_;
    }


    [CqlExpressionDefinition("SDE Race")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Race(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? yzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = SupplementalDataElements_3_5_000.Instance.SDE_Race(context);

        return yzzzzzzzzzzzzzzzzzzzzzzzzzzzu_;
    }


    [CqlExpressionDefinition("SDE Sex")]
    public CqlCode SDE_Sex(CqlContext context)
    {
        CqlCode yzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = SupplementalDataElements_3_5_000.Instance.SDE_Sex(context);

        return yzzzzzzzzzzzzzzzzzzzzzzzzzzzv_;
    }


    [CqlExpressionDefinition("Qualifying Encounter During Measurement Period")]
    public IEnumerable<Encounter> Qualifying_Encounter_During_Measurement_Period(CqlContext context)
    {
        CqlValueSet yzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = this.Office_Visit(context);
        IEnumerable<Encounter> yzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, yzzzzzzzzzzzzzzzzzzzzzzzzzzzw_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        CqlValueSet yzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = this.Ophthalmological_Services(context);
        IEnumerable<Encounter> yzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, yzzzzzzzzzzzzzzzzzzzzzzzzzzzy_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> zzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Union<Encounter>(yzzzzzzzzzzzzzzzzzzzzzzzzzzzx_, yzzzzzzzzzzzzzzzzzzzzzzzzzzzz_);
        CqlValueSet zzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = this.Outpatient_Consultation(context);
        IEnumerable<Encounter> zzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, zzzzzzzzzzzzzzzzzzzzzzzzzzzzb_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        CqlValueSet zzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = this.Care_Services_in_Long_Term_Residential_Facility(context);
        IEnumerable<Encounter> zzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, zzzzzzzzzzzzzzzzzzzzzzzzzzzzd_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> zzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Union<Encounter>(zzzzzzzzzzzzzzzzzzzzzzzzzzzzc_, zzzzzzzzzzzzzzzzzzzzzzzzzzzze_);
        IEnumerable<Encounter> zzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Union<Encounter>(zzzzzzzzzzzzzzzzzzzzzzzzzzzza_, zzzzzzzzzzzzzzzzzzzzzzzzzzzzf_);
        CqlValueSet zzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = this.Nursing_Facility_Visit(context);
        IEnumerable<Encounter> zzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, zzzzzzzzzzzzzzzzzzzzzzzzzzzzh_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> zzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Union<Encounter>(zzzzzzzzzzzzzzzzzzzzzzzzzzzzg_, zzzzzzzzzzzzzzzzzzzzzzzzzzzzi_);
        bool? zzzzzzzzzzzzzzzzzzzzzzzzzzzzk_(Encounter QualifyingEncounter)
        {
            CqlInterval<CqlDateTime> zzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = this.Measurement_Period(context);
            Period zzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = QualifyingEncounter?.Period;
            CqlInterval<CqlDateTime> zzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, zzzzzzzzzzzzzzzzzzzzzzzzzzzzn_);
            bool? zzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(zzzzzzzzzzzzzzzzzzzzzzzzzzzzm_, zzzzzzzzzzzzzzzzzzzzzzzzzzzzo_, default);
            Code<Encounter.EncounterStatus> zzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = QualifyingEncounter?.StatusElement;
            Encounter.EncounterStatus? zzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = zzzzzzzzzzzzzzzzzzzzzzzzzzzzq_?.Value;
            Code<Encounter.EncounterStatus> zzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(zzzzzzzzzzzzzzzzzzzzzzzzzzzzr_);
            bool? zzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Equal(zzzzzzzzzzzzzzzzzzzzzzzzzzzzs_, "finished");
            bool? zzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.And(zzzzzzzzzzzzzzzzzzzzzzzzzzzzp_, zzzzzzzzzzzzzzzzzzzzzzzzzzzzt_);
            Coding zzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = QualifyingEncounter?.Class;
            CqlCode zzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = FHIRHelpers_4_4_000.Instance.ToCode(context, zzzzzzzzzzzzzzzzzzzzzzzzzzzzv_);
            CqlCode zzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = this.@virtual(context);
            bool? zzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Equivalent(zzzzzzzzzzzzzzzzzzzzzzzzzzzzw_, zzzzzzzzzzzzzzzzzzzzzzzzzzzzx_);
            bool? zzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Not(zzzzzzzzzzzzzzzzzzzzzzzzzzzzy_);
            bool? azzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.And(zzzzzzzzzzzzzzzzzzzzzzzzzzzzu_, zzzzzzzzzzzzzzzzzzzzzzzzzzzzz_);

            return azzzzzzzzzzzzzzzzzzzzzzzzzzzza_;
        };
        IEnumerable<Encounter> zzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Where<Encounter>(zzzzzzzzzzzzzzzzzzzzzzzzzzzzj_, zzzzzzzzzzzzzzzzzzzzzzzzzzzzk_);

        return zzzzzzzzzzzzzzzzzzzzzzzzzzzzl_;
    }


    [CqlExpressionDefinition("Diabetic Retinopathy Encounter")]
    public IEnumerable<Encounter> Diabetic_Retinopathy_Encounter(CqlContext context)
    {
        IEnumerable<Encounter> azzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = this.Qualifying_Encounter_During_Measurement_Period(context);
        IEnumerable<Encounter> azzzzzzzzzzzzzzzzzzzzzzzzzzzzc_(Encounter ValidQualifyingEncounter)
        {
            CqlValueSet azzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = this.Diabetic_Retinopathy(context);
            IEnumerable<Condition> azzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, azzzzzzzzzzzzzzzzzzzzzzzzzzzze_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
            bool? azzzzzzzzzzzzzzzzzzzzzzzzzzzzg_(Condition DiabeticRetinopathy)
            {
                CqlInterval<CqlDateTime> azzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = QICoreCommon_2_1_000.Instance.prevalenceInterval(context, DiabeticRetinopathy);
                Period azzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = ValidQualifyingEncounter?.Period;
                CqlInterval<CqlDateTime> azzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, azzzzzzzzzzzzzzzzzzzzzzzzzzzzl_);
                bool? azzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Overlaps(azzzzzzzzzzzzzzzzzzzzzzzzzzzzk_, azzzzzzzzzzzzzzzzzzzzzzzzzzzzm_, default);
                bool? azzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = QICoreCommon_2_1_000.Instance.isActive(context, DiabeticRetinopathy);
                bool? azzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.And(azzzzzzzzzzzzzzzzzzzzzzzzzzzzn_, azzzzzzzzzzzzzzzzzzzzzzzzzzzzo_);
                CodeableConcept azzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = DiabeticRetinopathy?.VerificationStatus;
                CqlConcept azzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, azzzzzzzzzzzzzzzzzzzzzzzzzzzzq_);
                CqlCode azzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = QICoreCommon_2_1_000.Instance.unconfirmed(context);
                CqlConcept azzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.ConvertCodeToConcept(azzzzzzzzzzzzzzzzzzzzzzzzzzzzs_);
                bool? azzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Equivalent(azzzzzzzzzzzzzzzzzzzzzzzzzzzzr_, azzzzzzzzzzzzzzzzzzzzzzzzzzzzt_);
                CqlConcept azzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, azzzzzzzzzzzzzzzzzzzzzzzzzzzzq_);
                CqlCode azzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = QICoreCommon_2_1_000.Instance.refuted(context);
                CqlConcept azzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.ConvertCodeToConcept(azzzzzzzzzzzzzzzzzzzzzzzzzzzzx_);
                bool? azzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Equivalent(azzzzzzzzzzzzzzzzzzzzzzzzzzzzw_, azzzzzzzzzzzzzzzzzzzzzzzzzzzzy_);
                bool? bzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Or(azzzzzzzzzzzzzzzzzzzzzzzzzzzzu_, azzzzzzzzzzzzzzzzzzzzzzzzzzzzz_);
                CqlConcept bzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, azzzzzzzzzzzzzzzzzzzzzzzzzzzzq_);
                CqlCode bzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = QICoreCommon_2_1_000.Instance.entered_in_error(context);
                CqlConcept bzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.ConvertCodeToConcept(bzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_);
                bool? bzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Equivalent(bzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_, bzzzzzzzzzzzzzzzzzzzzzzzzzzzze_);
                bool? bzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Or(bzzzzzzzzzzzzzzzzzzzzzzzzzzzza_, bzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_);
                bool? bzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Not(bzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_);
                bool? bzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.And(azzzzzzzzzzzzzzzzzzzzzzzzzzzzp_, bzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_);

                return bzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_;
            };
            IEnumerable<Condition> azzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Where<Condition>(azzzzzzzzzzzzzzzzzzzzzzzzzzzzf_, azzzzzzzzzzzzzzzzzzzzzzzzzzzzg_);
            Encounter azzzzzzzzzzzzzzzzzzzzzzzzzzzzi_(Condition DiabeticRetinopathy) =>
                ValidQualifyingEncounter;
            IEnumerable<Encounter> azzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Select<Condition, Encounter>(azzzzzzzzzzzzzzzzzzzzzzzzzzzzh_, azzzzzzzzzzzzzzzzzzzzzzzzzzzzi_);

            return azzzzzzzzzzzzzzzzzzzzzzzzzzzzj_;
        };
        IEnumerable<Encounter> azzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.SelectMany<Encounter, Encounter>(azzzzzzzzzzzzzzzzzzzzzzzzzzzzb_, azzzzzzzzzzzzzzzzzzzzzzzzzzzzc_);

        return azzzzzzzzzzzzzzzzzzzzzzzzzzzzd_;
    }


    [CqlExpressionDefinition("Initial Population")]
    public bool? Initial_Population(CqlContext context)
    {
        Patient bzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = this.Patient(context);
        Date bzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = bzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_?.BirthDateElement;
        string bzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = bzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_?.Value;
        CqlDate bzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.ConvertStringToDate(bzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_);
        CqlInterval<CqlDateTime> bzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = this.Measurement_Period(context);
        CqlDateTime bzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Start(bzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_);
        CqlDate bzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.DateFrom(bzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_);
        int? bzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.CalculateAgeAt(bzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_, bzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_, "year");
        bool? bzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.GreaterOrEqual(bzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_, 18);
        IEnumerable<Encounter> bzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = this.Diabetic_Retinopathy_Encounter(context);
        bool? bzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Exists<Encounter>(bzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_);
        bool? bzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.And(bzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_, bzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_);

        return bzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_;
    }


    [CqlExpressionDefinition("Macular Exam Performed")]
    public IEnumerable<Observation> Macular_Exam_Performed(CqlContext context)
    {
        CqlValueSet bzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = this.Macular_Exam(context);
        IEnumerable<Observation> bzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, bzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        IEnumerable<Observation> bzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_(Observation MacularExam)
        {
            IEnumerable<Encounter> czzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = this.Diabetic_Retinopathy_Encounter(context);
            bool? czzzzzzzzzzzzzzzzzzzzzzzzzzzzc_(Encounter EncounterDiabeticRetinopathy)
            {
                Period czzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = EncounterDiabeticRetinopathy?.Period;
                CqlInterval<CqlDateTime> czzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, czzzzzzzzzzzzzzzzzzzzzzzzzzzzg_);
                DataType czzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = MacularExam?.Effective;
                object czzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, czzzzzzzzzzzzzzzzzzzzzzzzzzzzi_);
                CqlInterval<CqlDateTime> czzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = QICoreCommon_2_1_000.Instance.toInterval(context, czzzzzzzzzzzzzzzzzzzzzzzzzzzzj_);
                bool? czzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(czzzzzzzzzzzzzzzzzzzzzzzzzzzzh_, czzzzzzzzzzzzzzzzzzzzzzzzzzzzk_, default);

                return czzzzzzzzzzzzzzzzzzzzzzzzzzzzl_;
            };
            IEnumerable<Encounter> czzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Where<Encounter>(czzzzzzzzzzzzzzzzzzzzzzzzzzzzb_, czzzzzzzzzzzzzzzzzzzzzzzzzzzzc_);
            Observation czzzzzzzzzzzzzzzzzzzzzzzzzzzze_(Encounter EncounterDiabeticRetinopathy) =>
                MacularExam;
            IEnumerable<Observation> czzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Select<Encounter, Observation>(czzzzzzzzzzzzzzzzzzzzzzzzzzzzd_, czzzzzzzzzzzzzzzzzzzzzzzzzzzze_);

            return czzzzzzzzzzzzzzzzzzzzzzzzzzzzf_;
        };
        IEnumerable<Observation> bzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.SelectMany<Observation, Observation>(bzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_, bzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_);
        bool? bzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_(Observation MacularExam)
        {
            DataType czzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = MacularExam?.Value;
            object czzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = FHIRHelpers_4_4_000.Instance.ToValue(context, czzzzzzzzzzzzzzzzzzzzzzzzzzzzm_);
            bool? czzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Not((bool?)(czzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ is null));
            Code<ObservationStatus> czzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = MacularExam?.StatusElement;
            ObservationStatus? czzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = czzzzzzzzzzzzzzzzzzzzzzzzzzzzp_?.Value;
            Code<ObservationStatus> czzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Convert<Code<ObservationStatus>>(czzzzzzzzzzzzzzzzzzzzzzzzzzzzq_);
            string czzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Convert<string>(czzzzzzzzzzzzzzzzzzzzzzzzzzzzr_);
            string[] czzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = [
                "final",
                "amended",
                "corrected",
                "preliminary",
            ];
            bool? czzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.In<string>(czzzzzzzzzzzzzzzzzzzzzzzzzzzzs_, czzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ as IEnumerable<string>);
            bool? czzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.And(czzzzzzzzzzzzzzzzzzzzzzzzzzzzo_, czzzzzzzzzzzzzzzzzzzzzzzzzzzzu_);

            return czzzzzzzzzzzzzzzzzzzzzzzzzzzzv_;
        };
        IEnumerable<Observation> czzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Where<Observation>(bzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_, bzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_);

        return czzzzzzzzzzzzzzzzzzzzzzzzzzzza_;
    }


    [CqlExpressionDefinition("Denominator")]
    public bool? Denominator(CqlContext context)
    {
        bool? czzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = this.Initial_Population(context);
        IEnumerable<Observation> czzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = this.Macular_Exam_Performed(context);
        bool? czzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Exists<Observation>(czzzzzzzzzzzzzzzzzzzzzzzzzzzzx_);
        bool? czzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.And(czzzzzzzzzzzzzzzzzzzzzzzzzzzzw_, czzzzzzzzzzzzzzzzzzzzzzzzzzzzy_);

        return czzzzzzzzzzzzzzzzzzzzzzzzzzzzz_;
    }


    [CqlExpressionDefinition("Level of Severity of Retinopathy Findings Communicated")]
    public IEnumerable<Communication> Level_of_Severity_of_Retinopathy_Findings_Communicated(CqlContext context)
    {
        PropertyInfo dzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = typeof(Communication).GetProperty("ReasonCode");
        CqlValueSet dzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = this.Level_of_Severity_of_Retinopathy_Findings(context);
        IEnumerable<Communication> dzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Retrieve<Communication>(new RetrieveParameters(dzzzzzzzzzzzzzzzzzzzzzzzzzzzza_, dzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-communication"));
        IEnumerable<Communication> dzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_(Communication LevelOfSeverityCommunicated)
        {
            IEnumerable<Encounter> dzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = this.Diabetic_Retinopathy_Encounter(context);
            bool? dzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_(Encounter EncounterDiabeticRetinopathy)
            {
                FhirDateTime dzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = LevelOfSeverityCommunicated?.SentElement;
                CqlDateTime dzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Convert<CqlDateTime>(dzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_);
                Period dzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = EncounterDiabeticRetinopathy?.Period;
                CqlInterval<CqlDateTime> dzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, dzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_);
                CqlDateTime dzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Start(dzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_);
                bool? dzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.After(dzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_, dzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_, default);
                CqlDateTime dzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Convert<CqlDateTime>(dzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_);
                CqlInterval<CqlDateTime> dzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = this.Measurement_Period(context);
                bool? dzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.In<CqlDateTime>(dzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_, dzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_, "day");
                bool? dzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.And(dzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_, dzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_);

                return dzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_;
            };
            IEnumerable<Encounter> dzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Where<Encounter>(dzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_, dzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_);
            Communication dzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_(Encounter EncounterDiabeticRetinopathy) =>
                LevelOfSeverityCommunicated;
            IEnumerable<Communication> dzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Select<Encounter, Communication>(dzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_, dzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_);

            return dzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_;
        };
        IEnumerable<Communication> dzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.SelectMany<Communication, Communication>(dzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_, dzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_);
        bool? dzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_(Communication LevelOfSeverityCommunicated)
        {
            Code<EventStatus> dzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = LevelOfSeverityCommunicated?.StatusElement;
            EventStatus? dzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = dzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_?.Value;
            Code<EventStatus> dzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Convert<Code<EventStatus>>(dzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_);
            bool? ezzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Equal(dzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_, "completed");

            return ezzzzzzzzzzzzzzzzzzzzzzzzzzzza_;
        };
        IEnumerable<Communication> dzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Where<Communication>(dzzzzzzzzzzzzzzzzzzzzzzzzzzzze_, dzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_);

        return dzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_;
    }


    [CqlExpressionDefinition("Macular Edema Absence Communicated")]
    public IEnumerable<Communication> Macular_Edema_Absence_Communicated(CqlContext context)
    {
        PropertyInfo ezzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = typeof(Communication).GetProperty("ReasonCode");
        CqlValueSet ezzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = this.Macular_edema_absent__situation_(context);
        IEnumerable<Communication> ezzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Retrieve<Communication>(new RetrieveParameters(ezzzzzzzzzzzzzzzzzzzzzzzzzzzzb_, ezzzzzzzzzzzzzzzzzzzzzzzzzzzzc_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-communication"));
        IEnumerable<Communication> ezzzzzzzzzzzzzzzzzzzzzzzzzzzze_(Communication MacularEdemaAbsentCommunicated)
        {
            IEnumerable<Encounter> ezzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = this.Diabetic_Retinopathy_Encounter(context);
            bool? ezzzzzzzzzzzzzzzzzzzzzzzzzzzzj_(Encounter EncounterDiabeticRetinopathy)
            {
                FhirDateTime ezzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = MacularEdemaAbsentCommunicated?.SentElement;
                CqlDateTime ezzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Convert<CqlDateTime>(ezzzzzzzzzzzzzzzzzzzzzzzzzzzzn_);
                Period ezzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = EncounterDiabeticRetinopathy?.Period;
                CqlInterval<CqlDateTime> ezzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ezzzzzzzzzzzzzzzzzzzzzzzzzzzzp_);
                CqlDateTime ezzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Start(ezzzzzzzzzzzzzzzzzzzzzzzzzzzzq_);
                bool? ezzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.After(ezzzzzzzzzzzzzzzzzzzzzzzzzzzzo_, ezzzzzzzzzzzzzzzzzzzzzzzzzzzzr_, default);
                CqlDateTime ezzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Convert<CqlDateTime>(ezzzzzzzzzzzzzzzzzzzzzzzzzzzzn_);
                CqlInterval<CqlDateTime> ezzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = this.Measurement_Period(context);
                bool? ezzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.In<CqlDateTime>(ezzzzzzzzzzzzzzzzzzzzzzzzzzzzu_, ezzzzzzzzzzzzzzzzzzzzzzzzzzzzv_, "day");
                bool? ezzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.And(ezzzzzzzzzzzzzzzzzzzzzzzzzzzzs_, ezzzzzzzzzzzzzzzzzzzzzzzzzzzzw_);

                return ezzzzzzzzzzzzzzzzzzzzzzzzzzzzx_;
            };
            IEnumerable<Encounter> ezzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Where<Encounter>(ezzzzzzzzzzzzzzzzzzzzzzzzzzzzi_, ezzzzzzzzzzzzzzzzzzzzzzzzzzzzj_);
            Communication ezzzzzzzzzzzzzzzzzzzzzzzzzzzzl_(Encounter EncounterDiabeticRetinopathy) =>
                MacularEdemaAbsentCommunicated;
            IEnumerable<Communication> ezzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Select<Encounter, Communication>(ezzzzzzzzzzzzzzzzzzzzzzzzzzzzk_, ezzzzzzzzzzzzzzzzzzzzzzzzzzzzl_);

            return ezzzzzzzzzzzzzzzzzzzzzzzzzzzzm_;
        };
        IEnumerable<Communication> ezzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.SelectMany<Communication, Communication>(ezzzzzzzzzzzzzzzzzzzzzzzzzzzzd_, ezzzzzzzzzzzzzzzzzzzzzzzzzzzze_);
        bool? ezzzzzzzzzzzzzzzzzzzzzzzzzzzzg_(Communication MacularEdemaAbsentCommunicated)
        {
            Code<EventStatus> ezzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = MacularEdemaAbsentCommunicated?.StatusElement;
            EventStatus? ezzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = ezzzzzzzzzzzzzzzzzzzzzzzzzzzzy_?.Value;
            Code<EventStatus> fzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Convert<Code<EventStatus>>(ezzzzzzzzzzzzzzzzzzzzzzzzzzzzz_);
            bool? fzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Equal(fzzzzzzzzzzzzzzzzzzzzzzzzzzzza_, "completed");

            return fzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_;
        };
        IEnumerable<Communication> ezzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Where<Communication>(ezzzzzzzzzzzzzzzzzzzzzzzzzzzzf_, ezzzzzzzzzzzzzzzzzzzzzzzzzzzzg_);

        return ezzzzzzzzzzzzzzzzzzzzzzzzzzzzh_;
    }


    [CqlExpressionDefinition("Macular Edema Presence Communicated")]
    public IEnumerable<Communication> Macular_Edema_Presence_Communicated(CqlContext context)
    {
        PropertyInfo fzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = typeof(Communication).GetProperty("ReasonCode");
        CqlValueSet fzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = this.Macular_Edema_Findings_Present(context);
        IEnumerable<Communication> fzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Retrieve<Communication>(new RetrieveParameters(fzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_, fzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-communication"));
        IEnumerable<Communication> fzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_(Communication MacularEdemaPresentCommunicated)
        {
            IEnumerable<Encounter> fzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = this.Diabetic_Retinopathy_Encounter(context);
            bool? fzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_(Encounter EncounterDiabeticRetinopathy)
            {
                FhirDateTime fzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = MacularEdemaPresentCommunicated?.SentElement;
                CqlDateTime fzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Convert<CqlDateTime>(fzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_);
                Period fzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = EncounterDiabeticRetinopathy?.Period;
                CqlInterval<CqlDateTime> fzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, fzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_);
                CqlDateTime fzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Start(fzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_);
                bool? fzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.After(fzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_, fzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_, default);
                CqlDateTime fzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Convert<CqlDateTime>(fzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_);
                CqlInterval<CqlDateTime> fzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = this.Measurement_Period(context);
                bool? fzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.In<CqlDateTime>(fzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_, fzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_, "day");
                bool? fzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.And(fzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_, fzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_);

                return fzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_;
            };
            IEnumerable<Encounter> fzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Where<Encounter>(fzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_, fzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_);
            Communication fzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_(Encounter EncounterDiabeticRetinopathy) =>
                MacularEdemaPresentCommunicated;
            IEnumerable<Communication> fzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Select<Encounter, Communication>(fzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_, fzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_);

            return fzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_;
        };
        IEnumerable<Communication> fzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.SelectMany<Communication, Communication>(fzzzzzzzzzzzzzzzzzzzzzzzzzzzze_, fzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_);
        bool? fzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_(Communication MacularEdemaPresentCommunicated)
        {
            Code<EventStatus> fzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = MacularEdemaPresentCommunicated?.StatusElement;
            EventStatus? gzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = fzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_?.Value;
            Code<EventStatus> gzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Convert<Code<EventStatus>>(gzzzzzzzzzzzzzzzzzzzzzzzzzzzza_);
            bool? gzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Equal(gzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_, "completed");

            return gzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_;
        };
        IEnumerable<Communication> fzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Where<Communication>(fzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_, fzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_);

        return fzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_;
    }


    [CqlExpressionDefinition("Numerator")]
    public bool? Numerator(CqlContext context)
    {
        IEnumerable<Communication> gzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = this.Level_of_Severity_of_Retinopathy_Findings_Communicated(context);
        bool? gzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Exists<Communication>(gzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_);
        IEnumerable<Communication> gzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = this.Macular_Edema_Absence_Communicated(context);
        bool? gzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Exists<Communication>(gzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_);
        IEnumerable<Communication> gzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = this.Macular_Edema_Presence_Communicated(context);
        bool? gzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Exists<Communication>(gzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_);
        bool? gzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Or(gzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_, gzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_);
        bool? gzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.And(gzzzzzzzzzzzzzzzzzzzzzzzzzzzze_, gzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_);

        return gzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_;
    }


    [CqlExpressionDefinition("Medical or Patient Reason for Not Communicating Level of Severity of Retinopathy")]
    public IEnumerable<Communication> Medical_or_Patient_Reason_for_Not_Communicating_Level_of_Severity_of_Retinopathy(CqlContext context)
    {
        PropertyInfo gzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = typeof(Communication).GetProperty("ReasonCode");
        CqlValueSet gzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = this.Level_of_Severity_of_Retinopathy_Findings(context);
        IEnumerable<Communication> gzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Retrieve<Communication>(new RetrieveParameters(gzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_, gzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-communicationnotdone"));
        IEnumerable<Communication> gzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Retrieve<Communication>(new RetrieveParameters(gzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_, gzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-communicationnotdone"));
        IEnumerable<Communication> gzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Union<Communication>(gzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_, gzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_);
        IEnumerable<Communication> gzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_(Communication LevelOfSeverityNotCommunicated)
        {
            IEnumerable<Encounter> gzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = this.Diabetic_Retinopathy_Encounter(context);
            bool? gzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_(Encounter EncounterDiabeticRetinopathy)
            {
                FhirDateTime hzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = LevelOfSeverityNotCommunicated?.SentElement;
                CqlDateTime hzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Convert<CqlDateTime>(hzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_);
                Period hzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = EncounterDiabeticRetinopathy?.Period;
                CqlInterval<CqlDateTime> hzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, hzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_);
                bool? hzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.In<CqlDateTime>(hzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_, hzzzzzzzzzzzzzzzzzzzzzzzzzzzze_, default);

                return hzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_;
            };
            IEnumerable<Encounter> gzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Where<Encounter>(gzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_, gzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_);
            Communication gzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_(Encounter EncounterDiabeticRetinopathy) =>
                LevelOfSeverityNotCommunicated;
            IEnumerable<Communication> hzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Select<Encounter, Communication>(gzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_, gzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_);

            return hzzzzzzzzzzzzzzzzzzzzzzzzzzzza_;
        };
        IEnumerable<Communication> gzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.SelectMany<Communication, Communication>(gzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_, gzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_);
        bool? gzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_(Communication LevelOfSeverityNotCommunicated)
        {
            CodeableConcept hzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = LevelOfSeverityNotCommunicated?.StatusReason;
            CqlConcept hzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, hzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_);
            CqlValueSet hzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = this.Medical_Reason(context);
            bool? hzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.ConceptInValueSet(hzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_, hzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_);
            CqlConcept hzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, hzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_);
            CqlValueSet hzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = this.Patient_Reason(context);
            bool? hzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.ConceptInValueSet(hzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_, hzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_);
            bool? hzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Or(hzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_, hzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_);

            return hzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_;
        };
        IEnumerable<Communication> gzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Where<Communication>(gzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_, gzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_);

        return gzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_;
    }


    [CqlExpressionDefinition("Medical or Patient Reason for Not Communicating Absence of Macular Edema")]
    public IEnumerable<Communication> Medical_or_Patient_Reason_for_Not_Communicating_Absence_of_Macular_Edema(CqlContext context)
    {
        PropertyInfo hzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = typeof(Communication).GetProperty("ReasonCode");
        CqlValueSet hzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = this.Macular_edema_absent__situation_(context);
        IEnumerable<Communication> hzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Retrieve<Communication>(new RetrieveParameters(hzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_, hzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-communicationnotdone"));
        IEnumerable<Communication> hzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Retrieve<Communication>(new RetrieveParameters(hzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_, hzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-communicationnotdone"));
        IEnumerable<Communication> hzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Union<Communication>(hzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_, hzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_);
        IEnumerable<Communication> hzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_(Communication MacularEdemaAbsentNotCommunicated)
        {
            IEnumerable<Encounter> izzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = this.Diabetic_Retinopathy_Encounter(context);
            bool? izzzzzzzzzzzzzzzzzzzzzzzzzzzzb_(Encounter EncounterDiabeticRetinopathy)
            {
                FhirDateTime izzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = MacularEdemaAbsentNotCommunicated?.SentElement;
                CqlDateTime izzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Convert<CqlDateTime>(izzzzzzzzzzzzzzzzzzzzzzzzzzzzf_);
                Period izzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = EncounterDiabeticRetinopathy?.Period;
                CqlInterval<CqlDateTime> izzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, izzzzzzzzzzzzzzzzzzzzzzzzzzzzh_);
                bool? izzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.In<CqlDateTime>(izzzzzzzzzzzzzzzzzzzzzzzzzzzzg_, izzzzzzzzzzzzzzzzzzzzzzzzzzzzi_, default);

                return izzzzzzzzzzzzzzzzzzzzzzzzzzzzj_;
            };
            IEnumerable<Encounter> izzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Where<Encounter>(izzzzzzzzzzzzzzzzzzzzzzzzzzzza_, izzzzzzzzzzzzzzzzzzzzzzzzzzzzb_);
            Communication izzzzzzzzzzzzzzzzzzzzzzzzzzzzd_(Encounter EncounterDiabeticRetinopathy) =>
                MacularEdemaAbsentNotCommunicated;
            IEnumerable<Communication> izzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Select<Encounter, Communication>(izzzzzzzzzzzzzzzzzzzzzzzzzzzzc_, izzzzzzzzzzzzzzzzzzzzzzzzzzzzd_);

            return izzzzzzzzzzzzzzzzzzzzzzzzzzzze_;
        };
        IEnumerable<Communication> hzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.SelectMany<Communication, Communication>(hzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_, hzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_);
        bool? hzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_(Communication MacularEdemaAbsentNotCommunicated)
        {
            CodeableConcept izzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = MacularEdemaAbsentNotCommunicated?.StatusReason;
            CqlConcept izzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, izzzzzzzzzzzzzzzzzzzzzzzzzzzzk_);
            CqlValueSet izzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = this.Medical_Reason(context);
            bool? izzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.ConceptInValueSet(izzzzzzzzzzzzzzzzzzzzzzzzzzzzl_, izzzzzzzzzzzzzzzzzzzzzzzzzzzzm_);
            CqlConcept izzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, izzzzzzzzzzzzzzzzzzzzzzzzzzzzk_);
            CqlValueSet izzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = this.Patient_Reason(context);
            bool? izzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.ConceptInValueSet(izzzzzzzzzzzzzzzzzzzzzzzzzzzzp_, izzzzzzzzzzzzzzzzzzzzzzzzzzzzq_);
            bool? izzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Or(izzzzzzzzzzzzzzzzzzzzzzzzzzzzn_, izzzzzzzzzzzzzzzzzzzzzzzzzzzzr_);

            return izzzzzzzzzzzzzzzzzzzzzzzzzzzzs_;
        };
        IEnumerable<Communication> hzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Where<Communication>(hzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_, hzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_);

        return hzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_;
    }


    [CqlExpressionDefinition("Medical or Patient Reason for Not Communicating Presence of Macular Edema")]
    public IEnumerable<Communication> Medical_or_Patient_Reason_for_Not_Communicating_Presence_of_Macular_Edema(CqlContext context)
    {
        PropertyInfo izzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = typeof(Communication).GetProperty("ReasonCode");
        CqlValueSet izzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = this.Macular_Edema_Findings_Present(context);
        IEnumerable<Communication> izzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Retrieve<Communication>(new RetrieveParameters(izzzzzzzzzzzzzzzzzzzzzzzzzzzzt_, izzzzzzzzzzzzzzzzzzzzzzzzzzzzu_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-communicationnotdone"));
        IEnumerable<Communication> izzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Retrieve<Communication>(new RetrieveParameters(izzzzzzzzzzzzzzzzzzzzzzzzzzzzt_, izzzzzzzzzzzzzzzzzzzzzzzzzzzzu_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-communicationnotdone"));
        IEnumerable<Communication> izzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Union<Communication>(izzzzzzzzzzzzzzzzzzzzzzzzzzzzv_, izzzzzzzzzzzzzzzzzzzzzzzzzzzzy_);
        IEnumerable<Communication> jzzzzzzzzzzzzzzzzzzzzzzzzzzzza_(Communication MacularEdemaPresentNotCommunicated)
        {
            IEnumerable<Encounter> jzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = this.Diabetic_Retinopathy_Encounter(context);
            bool? jzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_(Encounter EncounterDiabeticRetinopathy)
            {
                FhirDateTime jzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = MacularEdemaPresentNotCommunicated?.SentElement;
                CqlDateTime jzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Convert<CqlDateTime>(jzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_);
                Period jzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = EncounterDiabeticRetinopathy?.Period;
                CqlInterval<CqlDateTime> jzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, jzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_);
                bool? jzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.In<CqlDateTime>(jzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_, jzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_, default);

                return jzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_;
            };
            IEnumerable<Encounter> jzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Where<Encounter>(jzzzzzzzzzzzzzzzzzzzzzzzzzzzze_, jzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_);
            Communication jzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_(Encounter EncounterDiabeticRetinopathy) =>
                MacularEdemaPresentNotCommunicated;
            IEnumerable<Communication> jzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Select<Encounter, Communication>(jzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_, jzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_);

            return jzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_;
        };
        IEnumerable<Communication> jzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.SelectMany<Communication, Communication>(izzzzzzzzzzzzzzzzzzzzzzzzzzzzz_, jzzzzzzzzzzzzzzzzzzzzzzzzzzzza_);
        bool? jzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_(Communication MacularEdemaPresentNotCommunicated)
        {
            CodeableConcept jzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = MacularEdemaPresentNotCommunicated?.StatusReason;
            CqlConcept jzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, jzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_);
            CqlValueSet jzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = this.Medical_Reason(context);
            bool? jzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.ConceptInValueSet(jzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_, jzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_);
            CqlConcept jzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, jzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_);
            CqlValueSet jzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = this.Patient_Reason(context);
            bool? jzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.ConceptInValueSet(jzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_, jzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_);
            bool? jzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Or(jzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_, jzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_);

            return jzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_;
        };
        IEnumerable<Communication> jzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Where<Communication>(jzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_, jzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_);

        return jzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_;
    }


    [CqlExpressionDefinition("Denominator Exceptions")]
    public bool? Denominator_Exceptions(CqlContext context)
    {
        IEnumerable<Communication> jzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = this.Medical_or_Patient_Reason_for_Not_Communicating_Level_of_Severity_of_Retinopathy(context);
        bool? jzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Exists<Communication>(jzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_);
        IEnumerable<Communication> jzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = this.Medical_or_Patient_Reason_for_Not_Communicating_Absence_of_Macular_Edema(context);
        bool? kzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Exists<Communication>(jzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_);
        bool? kzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Or(jzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_, kzzzzzzzzzzzzzzzzzzzzzzzzzzzza_);
        IEnumerable<Communication> kzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = this.Medical_or_Patient_Reason_for_Not_Communicating_Presence_of_Macular_Edema(context);
        bool? kzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Exists<Communication>(kzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_);
        bool? kzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Or(kzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_, kzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_);

        return kzzzzzzzzzzzzzzzzzzzzzzzzzzzze_;
    }


    [CqlExpressionDefinition("Results of Dilated Macular or Fundus Exam Communicated")]
    public bool? Results_of_Dilated_Macular_or_Fundus_Exam_Communicated(CqlContext context)
    {
        IEnumerable<Communication> kzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = this.Level_of_Severity_of_Retinopathy_Findings_Communicated(context);
        bool? kzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Exists<Communication>(kzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_);
        IEnumerable<Communication> kzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = this.Macular_Edema_Absence_Communicated(context);
        bool? kzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Exists<Communication>(kzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_);
        IEnumerable<Communication> kzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = this.Macular_Edema_Presence_Communicated(context);
        bool? kzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Exists<Communication>(kzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_);
        bool? kzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Or(kzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_, kzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_);
        bool? kzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.And(kzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_, kzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_);

        return kzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_;
    }


    #endregion Expressions

}
