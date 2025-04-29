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
        CqlDateTime vzzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.DateTime(2025, 1, 1, 0, 0, 0, 0, 0.0m);
        CqlDateTime vzzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.DateTime(2025, 12, 31, 23, 59, 59, 999, 0.0m);
        CqlInterval<CqlDateTime> vzzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Interval(vzzzzzzzzzzzzzzzzzzzzzzzzze_, vzzzzzzzzzzzzzzzzzzzzzzzzzf_, true, true);
        object vzzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.ResolveParameter("DRCommunicationWithPhysicianManagingDiabetesFHIR-0.1.000", "Measurement Period", vzzzzzzzzzzzzzzzzzzzzzzzzzg_);

        return (CqlInterval<CqlDateTime>)vzzzzzzzzzzzzzzzzzzzzzzzzzh_;
    }


    #endregion Parameters

    #region Expressions

    [CqlExpressionDefinition("Patient")]
    public Patient Patient(CqlContext context)
    {
        IEnumerable<Patient> vzzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-patient"));
        Patient vzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.SingletonFrom<Patient>(vzzzzzzzzzzzzzzzzzzzzzzzzzi_);

        return vzzzzzzzzzzzzzzzzzzzzzzzzzj_;
    }


    [CqlExpressionDefinition("SDE Ethnicity")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Ethnicity(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? vzzzzzzzzzzzzzzzzzzzzzzzzzk_ = SupplementalDataElements_3_5_000.Instance.SDE_Ethnicity(context);

        return vzzzzzzzzzzzzzzzzzzzzzzzzzk_;
    }


    [CqlExpressionDefinition("SDE Payer")]
    public IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> SDE_Payer(CqlContext context)
    {
        IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> vzzzzzzzzzzzzzzzzzzzzzzzzzl_ = SupplementalDataElements_3_5_000.Instance.SDE_Payer(context);

        return vzzzzzzzzzzzzzzzzzzzzzzzzzl_;
    }


    [CqlExpressionDefinition("SDE Race")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Race(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? vzzzzzzzzzzzzzzzzzzzzzzzzzm_ = SupplementalDataElements_3_5_000.Instance.SDE_Race(context);

        return vzzzzzzzzzzzzzzzzzzzzzzzzzm_;
    }


    [CqlExpressionDefinition("SDE Sex")]
    public CqlCode SDE_Sex(CqlContext context)
    {
        CqlCode vzzzzzzzzzzzzzzzzzzzzzzzzzn_ = SupplementalDataElements_3_5_000.Instance.SDE_Sex(context);

        return vzzzzzzzzzzzzzzzzzzzzzzzzzn_;
    }


    [CqlExpressionDefinition("Qualifying Encounter During Measurement Period")]
    public IEnumerable<Encounter> Qualifying_Encounter_During_Measurement_Period(CqlContext context)
    {
        CqlValueSet vzzzzzzzzzzzzzzzzzzzzzzzzzo_ = this.Office_Visit(context);
        IEnumerable<Encounter> vzzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, vzzzzzzzzzzzzzzzzzzzzzzzzzo_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        CqlValueSet vzzzzzzzzzzzzzzzzzzzzzzzzzq_ = this.Ophthalmological_Services(context);
        IEnumerable<Encounter> vzzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, vzzzzzzzzzzzzzzzzzzzzzzzzzq_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> vzzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Union<Encounter>(vzzzzzzzzzzzzzzzzzzzzzzzzzp_, vzzzzzzzzzzzzzzzzzzzzzzzzzr_);
        CqlValueSet vzzzzzzzzzzzzzzzzzzzzzzzzzt_ = this.Outpatient_Consultation(context);
        IEnumerable<Encounter> vzzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, vzzzzzzzzzzzzzzzzzzzzzzzzzt_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        CqlValueSet vzzzzzzzzzzzzzzzzzzzzzzzzzv_ = this.Care_Services_in_Long_Term_Residential_Facility(context);
        IEnumerable<Encounter> vzzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, vzzzzzzzzzzzzzzzzzzzzzzzzzv_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> vzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Union<Encounter>(vzzzzzzzzzzzzzzzzzzzzzzzzzu_, vzzzzzzzzzzzzzzzzzzzzzzzzzw_);
        IEnumerable<Encounter> vzzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Union<Encounter>(vzzzzzzzzzzzzzzzzzzzzzzzzzs_, vzzzzzzzzzzzzzzzzzzzzzzzzzx_);
        CqlValueSet vzzzzzzzzzzzzzzzzzzzzzzzzzz_ = this.Nursing_Facility_Visit(context);
        IEnumerable<Encounter> wzzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, vzzzzzzzzzzzzzzzzzzzzzzzzzz_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> wzzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Union<Encounter>(vzzzzzzzzzzzzzzzzzzzzzzzzzy_, wzzzzzzzzzzzzzzzzzzzzzzzzza_);
        bool? wzzzzzzzzzzzzzzzzzzzzzzzzzc_(Encounter QualifyingEncounter)
        {
            CqlInterval<CqlDateTime> wzzzzzzzzzzzzzzzzzzzzzzzzze_ = this.Measurement_Period(context);
            Period wzzzzzzzzzzzzzzzzzzzzzzzzzf_ = QualifyingEncounter?.Period;
            CqlInterval<CqlDateTime> wzzzzzzzzzzzzzzzzzzzzzzzzzg_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, wzzzzzzzzzzzzzzzzzzzzzzzzzf_);
            bool? wzzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(wzzzzzzzzzzzzzzzzzzzzzzzzze_, wzzzzzzzzzzzzzzzzzzzzzzzzzg_, default);
            Code<Encounter.EncounterStatus> wzzzzzzzzzzzzzzzzzzzzzzzzzi_ = QualifyingEncounter?.StatusElement;
            Encounter.EncounterStatus? wzzzzzzzzzzzzzzzzzzzzzzzzzj_ = wzzzzzzzzzzzzzzzzzzzzzzzzzi_?.Value;
            Code<Encounter.EncounterStatus> wzzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(wzzzzzzzzzzzzzzzzzzzzzzzzzj_);
            bool? wzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Equal(wzzzzzzzzzzzzzzzzzzzzzzzzzk_, "finished");
            bool? wzzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.And(wzzzzzzzzzzzzzzzzzzzzzzzzzh_, wzzzzzzzzzzzzzzzzzzzzzzzzzl_);
            Coding wzzzzzzzzzzzzzzzzzzzzzzzzzn_ = QualifyingEncounter?.Class;
            CqlCode wzzzzzzzzzzzzzzzzzzzzzzzzzo_ = FHIRHelpers_4_4_000.Instance.ToCode(context, wzzzzzzzzzzzzzzzzzzzzzzzzzn_);
            CqlCode wzzzzzzzzzzzzzzzzzzzzzzzzzp_ = this.@virtual(context);
            bool? wzzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Equivalent(wzzzzzzzzzzzzzzzzzzzzzzzzzo_, wzzzzzzzzzzzzzzzzzzzzzzzzzp_);
            bool? wzzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Not(wzzzzzzzzzzzzzzzzzzzzzzzzzq_);
            bool? wzzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.And(wzzzzzzzzzzzzzzzzzzzzzzzzzm_, wzzzzzzzzzzzzzzzzzzzzzzzzzr_);

            return wzzzzzzzzzzzzzzzzzzzzzzzzzs_;
        };
        IEnumerable<Encounter> wzzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Where<Encounter>(wzzzzzzzzzzzzzzzzzzzzzzzzzb_, wzzzzzzzzzzzzzzzzzzzzzzzzzc_);

        return wzzzzzzzzzzzzzzzzzzzzzzzzzd_;
    }


    [CqlExpressionDefinition("Diabetic Retinopathy Encounter")]
    public IEnumerable<Encounter> Diabetic_Retinopathy_Encounter(CqlContext context)
    {
        IEnumerable<Encounter> wzzzzzzzzzzzzzzzzzzzzzzzzzt_ = this.Qualifying_Encounter_During_Measurement_Period(context);
        IEnumerable<Encounter> wzzzzzzzzzzzzzzzzzzzzzzzzzu_(Encounter ValidQualifyingEncounter)
        {
            CqlValueSet wzzzzzzzzzzzzzzzzzzzzzzzzzw_ = this.Diabetic_Retinopathy(context);
            IEnumerable<Condition> wzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, wzzzzzzzzzzzzzzzzzzzzzzzzzw_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
            bool? wzzzzzzzzzzzzzzzzzzzzzzzzzy_(Condition DiabeticRetinopathy)
            {
                CqlInterval<CqlDateTime> xzzzzzzzzzzzzzzzzzzzzzzzzzc_ = QICoreCommon_2_1_000.Instance.prevalenceInterval(context, DiabeticRetinopathy);
                Period xzzzzzzzzzzzzzzzzzzzzzzzzzd_ = ValidQualifyingEncounter?.Period;
                CqlInterval<CqlDateTime> xzzzzzzzzzzzzzzzzzzzzzzzzze_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, xzzzzzzzzzzzzzzzzzzzzzzzzzd_);
                bool? xzzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Overlaps(xzzzzzzzzzzzzzzzzzzzzzzzzzc_, xzzzzzzzzzzzzzzzzzzzzzzzzze_, default);
                bool? xzzzzzzzzzzzzzzzzzzzzzzzzzg_ = QICoreCommon_2_1_000.Instance.isActive(context, DiabeticRetinopathy);
                bool? xzzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.And(xzzzzzzzzzzzzzzzzzzzzzzzzzf_, xzzzzzzzzzzzzzzzzzzzzzzzzzg_);
                CodeableConcept xzzzzzzzzzzzzzzzzzzzzzzzzzi_ = DiabeticRetinopathy?.VerificationStatus;
                CqlConcept xzzzzzzzzzzzzzzzzzzzzzzzzzj_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, xzzzzzzzzzzzzzzzzzzzzzzzzzi_);
                CqlCode xzzzzzzzzzzzzzzzzzzzzzzzzzk_ = QICoreCommon_2_1_000.Instance.unconfirmed(context);
                CqlConcept xzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.ConvertCodeToConcept(xzzzzzzzzzzzzzzzzzzzzzzzzzk_);
                bool? xzzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Equivalent(xzzzzzzzzzzzzzzzzzzzzzzzzzj_, xzzzzzzzzzzzzzzzzzzzzzzzzzl_);
                CqlConcept xzzzzzzzzzzzzzzzzzzzzzzzzzo_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, xzzzzzzzzzzzzzzzzzzzzzzzzzi_);
                CqlCode xzzzzzzzzzzzzzzzzzzzzzzzzzp_ = QICoreCommon_2_1_000.Instance.refuted(context);
                CqlConcept xzzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.ConvertCodeToConcept(xzzzzzzzzzzzzzzzzzzzzzzzzzp_);
                bool? xzzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Equivalent(xzzzzzzzzzzzzzzzzzzzzzzzzzo_, xzzzzzzzzzzzzzzzzzzzzzzzzzq_);
                bool? xzzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Or(xzzzzzzzzzzzzzzzzzzzzzzzzzm_, xzzzzzzzzzzzzzzzzzzzzzzzzzr_);
                CqlConcept xzzzzzzzzzzzzzzzzzzzzzzzzzu_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, xzzzzzzzzzzzzzzzzzzzzzzzzzi_);
                CqlCode xzzzzzzzzzzzzzzzzzzzzzzzzzv_ = QICoreCommon_2_1_000.Instance.entered_in_error(context);
                CqlConcept xzzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.ConvertCodeToConcept(xzzzzzzzzzzzzzzzzzzzzzzzzzv_);
                bool? xzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Equivalent(xzzzzzzzzzzzzzzzzzzzzzzzzzu_, xzzzzzzzzzzzzzzzzzzzzzzzzzw_);
                bool? xzzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Or(xzzzzzzzzzzzzzzzzzzzzzzzzzs_, xzzzzzzzzzzzzzzzzzzzzzzzzzx_);
                bool? xzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Not(xzzzzzzzzzzzzzzzzzzzzzzzzzy_);
                bool? yzzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.And(xzzzzzzzzzzzzzzzzzzzzzzzzzh_, xzzzzzzzzzzzzzzzzzzzzzzzzzz_);

                return yzzzzzzzzzzzzzzzzzzzzzzzzza_;
            };
            IEnumerable<Condition> wzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Where<Condition>(wzzzzzzzzzzzzzzzzzzzzzzzzzx_, wzzzzzzzzzzzzzzzzzzzzzzzzzy_);
            Encounter xzzzzzzzzzzzzzzzzzzzzzzzzza_(Condition DiabeticRetinopathy) =>
                ValidQualifyingEncounter;
            IEnumerable<Encounter> xzzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Select<Condition, Encounter>(wzzzzzzzzzzzzzzzzzzzzzzzzzz_, xzzzzzzzzzzzzzzzzzzzzzzzzza_);

            return xzzzzzzzzzzzzzzzzzzzzzzzzzb_;
        };
        IEnumerable<Encounter> wzzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.SelectMany<Encounter, Encounter>(wzzzzzzzzzzzzzzzzzzzzzzzzzt_, wzzzzzzzzzzzzzzzzzzzzzzzzzu_);

        return wzzzzzzzzzzzzzzzzzzzzzzzzzv_;
    }


    [CqlExpressionDefinition("Initial Population")]
    public bool? Initial_Population(CqlContext context)
    {
        Patient yzzzzzzzzzzzzzzzzzzzzzzzzzb_ = this.Patient(context);
        Date yzzzzzzzzzzzzzzzzzzzzzzzzzc_ = yzzzzzzzzzzzzzzzzzzzzzzzzzb_?.BirthDateElement;
        string yzzzzzzzzzzzzzzzzzzzzzzzzzd_ = yzzzzzzzzzzzzzzzzzzzzzzzzzc_?.Value;
        CqlDate yzzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.ConvertStringToDate(yzzzzzzzzzzzzzzzzzzzzzzzzzd_);
        CqlInterval<CqlDateTime> yzzzzzzzzzzzzzzzzzzzzzzzzzf_ = this.Measurement_Period(context);
        CqlDateTime yzzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Start(yzzzzzzzzzzzzzzzzzzzzzzzzzf_);
        CqlDate yzzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.DateFrom(yzzzzzzzzzzzzzzzzzzzzzzzzzg_);
        int? yzzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.CalculateAgeAt(yzzzzzzzzzzzzzzzzzzzzzzzzze_, yzzzzzzzzzzzzzzzzzzzzzzzzzh_, "year");
        bool? yzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.GreaterOrEqual(yzzzzzzzzzzzzzzzzzzzzzzzzzi_, 18);
        IEnumerable<Encounter> yzzzzzzzzzzzzzzzzzzzzzzzzzk_ = this.Diabetic_Retinopathy_Encounter(context);
        bool? yzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Exists<Encounter>(yzzzzzzzzzzzzzzzzzzzzzzzzzk_);
        bool? yzzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.And(yzzzzzzzzzzzzzzzzzzzzzzzzzj_, yzzzzzzzzzzzzzzzzzzzzzzzzzl_);

        return yzzzzzzzzzzzzzzzzzzzzzzzzzm_;
    }


    [CqlExpressionDefinition("Macular Exam Performed")]
    public IEnumerable<Observation> Macular_Exam_Performed(CqlContext context)
    {
        CqlValueSet yzzzzzzzzzzzzzzzzzzzzzzzzzn_ = this.Macular_Exam(context);
        IEnumerable<Observation> yzzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, yzzzzzzzzzzzzzzzzzzzzzzzzzn_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        IEnumerable<Observation> yzzzzzzzzzzzzzzzzzzzzzzzzzp_(Observation MacularExam)
        {
            IEnumerable<Encounter> yzzzzzzzzzzzzzzzzzzzzzzzzzt_ = this.Diabetic_Retinopathy_Encounter(context);
            bool? yzzzzzzzzzzzzzzzzzzzzzzzzzu_(Encounter EncounterDiabeticRetinopathy)
            {
                Period yzzzzzzzzzzzzzzzzzzzzzzzzzy_ = EncounterDiabeticRetinopathy?.Period;
                CqlInterval<CqlDateTime> yzzzzzzzzzzzzzzzzzzzzzzzzzz_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, yzzzzzzzzzzzzzzzzzzzzzzzzzy_);
                DataType zzzzzzzzzzzzzzzzzzzzzzzzzza_ = MacularExam?.Effective;
                object zzzzzzzzzzzzzzzzzzzzzzzzzzb_ = FHIRHelpers_4_4_000.Instance.ToValue(context, zzzzzzzzzzzzzzzzzzzzzzzzzza_);
                CqlInterval<CqlDateTime> zzzzzzzzzzzzzzzzzzzzzzzzzzc_ = QICoreCommon_2_1_000.Instance.toInterval(context, zzzzzzzzzzzzzzzzzzzzzzzzzzb_);
                bool? zzzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(yzzzzzzzzzzzzzzzzzzzzzzzzzz_, zzzzzzzzzzzzzzzzzzzzzzzzzzc_, default);

                return zzzzzzzzzzzzzzzzzzzzzzzzzzd_;
            };
            IEnumerable<Encounter> yzzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Where<Encounter>(yzzzzzzzzzzzzzzzzzzzzzzzzzt_, yzzzzzzzzzzzzzzzzzzzzzzzzzu_);
            Observation yzzzzzzzzzzzzzzzzzzzzzzzzzw_(Encounter EncounterDiabeticRetinopathy) =>
                MacularExam;
            IEnumerable<Observation> yzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Select<Encounter, Observation>(yzzzzzzzzzzzzzzzzzzzzzzzzzv_, yzzzzzzzzzzzzzzzzzzzzzzzzzw_);

            return yzzzzzzzzzzzzzzzzzzzzzzzzzx_;
        };
        IEnumerable<Observation> yzzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.SelectMany<Observation, Observation>(yzzzzzzzzzzzzzzzzzzzzzzzzzo_, yzzzzzzzzzzzzzzzzzzzzzzzzzp_);
        bool? yzzzzzzzzzzzzzzzzzzzzzzzzzr_(Observation MacularExam)
        {
            DataType zzzzzzzzzzzzzzzzzzzzzzzzzze_ = MacularExam?.Value;
            object zzzzzzzzzzzzzzzzzzzzzzzzzzf_ = FHIRHelpers_4_4_000.Instance.ToValue(context, zzzzzzzzzzzzzzzzzzzzzzzzzze_);
            bool? zzzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Not((bool?)(zzzzzzzzzzzzzzzzzzzzzzzzzzf_ is null));
            Code<ObservationStatus> zzzzzzzzzzzzzzzzzzzzzzzzzzh_ = MacularExam?.StatusElement;
            ObservationStatus? zzzzzzzzzzzzzzzzzzzzzzzzzzi_ = zzzzzzzzzzzzzzzzzzzzzzzzzzh_?.Value;
            Code<ObservationStatus> zzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Convert<Code<ObservationStatus>>(zzzzzzzzzzzzzzzzzzzzzzzzzzi_);
            string zzzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Convert<string>(zzzzzzzzzzzzzzzzzzzzzzzzzzj_);
            string[] zzzzzzzzzzzzzzzzzzzzzzzzzzl_ = [
                "final",
                "amended",
                "corrected",
                "preliminary",
            ];
            bool? zzzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.In<string>(zzzzzzzzzzzzzzzzzzzzzzzzzzk_, zzzzzzzzzzzzzzzzzzzzzzzzzzl_ as IEnumerable<string>);
            bool? zzzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.And(zzzzzzzzzzzzzzzzzzzzzzzzzzg_, zzzzzzzzzzzzzzzzzzzzzzzzzzm_);

            return zzzzzzzzzzzzzzzzzzzzzzzzzzn_;
        };
        IEnumerable<Observation> yzzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Where<Observation>(yzzzzzzzzzzzzzzzzzzzzzzzzzq_, yzzzzzzzzzzzzzzzzzzzzzzzzzr_);

        return yzzzzzzzzzzzzzzzzzzzzzzzzzs_;
    }


    [CqlExpressionDefinition("Denominator")]
    public bool? Denominator(CqlContext context)
    {
        bool? zzzzzzzzzzzzzzzzzzzzzzzzzzo_ = this.Initial_Population(context);
        IEnumerable<Observation> zzzzzzzzzzzzzzzzzzzzzzzzzzp_ = this.Macular_Exam_Performed(context);
        bool? zzzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Exists<Observation>(zzzzzzzzzzzzzzzzzzzzzzzzzzp_);
        bool? zzzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.And(zzzzzzzzzzzzzzzzzzzzzzzzzzo_, zzzzzzzzzzzzzzzzzzzzzzzzzzq_);

        return zzzzzzzzzzzzzzzzzzzzzzzzzzr_;
    }


    [CqlExpressionDefinition("Level of Severity of Retinopathy Findings Communicated")]
    public IEnumerable<Communication> Level_of_Severity_of_Retinopathy_Findings_Communicated(CqlContext context)
    {
        PropertyInfo zzzzzzzzzzzzzzzzzzzzzzzzzzs_ = typeof(Communication).GetProperty("ReasonCode");
        CqlValueSet zzzzzzzzzzzzzzzzzzzzzzzzzzt_ = this.Level_of_Severity_of_Retinopathy_Findings(context);
        IEnumerable<Communication> zzzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Retrieve<Communication>(new RetrieveParameters(zzzzzzzzzzzzzzzzzzzzzzzzzzs_, zzzzzzzzzzzzzzzzzzzzzzzzzzt_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-communication"));
        IEnumerable<Communication> zzzzzzzzzzzzzzzzzzzzzzzzzzv_(Communication LevelOfSeverityCommunicated)
        {
            IEnumerable<Encounter> zzzzzzzzzzzzzzzzzzzzzzzzzzz_ = this.Diabetic_Retinopathy_Encounter(context);
            bool? azzzzzzzzzzzzzzzzzzzzzzzzzza_(Encounter EncounterDiabeticRetinopathy)
            {
                FhirDateTime azzzzzzzzzzzzzzzzzzzzzzzzzze_ = LevelOfSeverityCommunicated?.SentElement;
                CqlDateTime azzzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Convert<CqlDateTime>(azzzzzzzzzzzzzzzzzzzzzzzzzze_);
                Period azzzzzzzzzzzzzzzzzzzzzzzzzzg_ = EncounterDiabeticRetinopathy?.Period;
                CqlInterval<CqlDateTime> azzzzzzzzzzzzzzzzzzzzzzzzzzh_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, azzzzzzzzzzzzzzzzzzzzzzzzzzg_);
                CqlDateTime azzzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Start(azzzzzzzzzzzzzzzzzzzzzzzzzzh_);
                bool? azzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.After(azzzzzzzzzzzzzzzzzzzzzzzzzzf_, azzzzzzzzzzzzzzzzzzzzzzzzzzi_, default);
                CqlDateTime azzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Convert<CqlDateTime>(azzzzzzzzzzzzzzzzzzzzzzzzzze_);
                CqlInterval<CqlDateTime> azzzzzzzzzzzzzzzzzzzzzzzzzzm_ = this.Measurement_Period(context);
                bool? azzzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.In<CqlDateTime>(azzzzzzzzzzzzzzzzzzzzzzzzzzl_, azzzzzzzzzzzzzzzzzzzzzzzzzzm_, "day");
                bool? azzzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.And(azzzzzzzzzzzzzzzzzzzzzzzzzzj_, azzzzzzzzzzzzzzzzzzzzzzzzzzn_);

                return azzzzzzzzzzzzzzzzzzzzzzzzzzo_;
            };
            IEnumerable<Encounter> azzzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Where<Encounter>(zzzzzzzzzzzzzzzzzzzzzzzzzzz_, azzzzzzzzzzzzzzzzzzzzzzzzzza_);
            Communication azzzzzzzzzzzzzzzzzzzzzzzzzzc_(Encounter EncounterDiabeticRetinopathy) =>
                LevelOfSeverityCommunicated;
            IEnumerable<Communication> azzzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Select<Encounter, Communication>(azzzzzzzzzzzzzzzzzzzzzzzzzzb_, azzzzzzzzzzzzzzzzzzzzzzzzzzc_);

            return azzzzzzzzzzzzzzzzzzzzzzzzzzd_;
        };
        IEnumerable<Communication> zzzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.SelectMany<Communication, Communication>(zzzzzzzzzzzzzzzzzzzzzzzzzzu_, zzzzzzzzzzzzzzzzzzzzzzzzzzv_);
        bool? zzzzzzzzzzzzzzzzzzzzzzzzzzx_(Communication LevelOfSeverityCommunicated)
        {
            Code<EventStatus> azzzzzzzzzzzzzzzzzzzzzzzzzzp_ = LevelOfSeverityCommunicated?.StatusElement;
            EventStatus? azzzzzzzzzzzzzzzzzzzzzzzzzzq_ = azzzzzzzzzzzzzzzzzzzzzzzzzzp_?.Value;
            Code<EventStatus> azzzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Convert<Code<EventStatus>>(azzzzzzzzzzzzzzzzzzzzzzzzzzq_);
            bool? azzzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Equal(azzzzzzzzzzzzzzzzzzzzzzzzzzr_, "completed");

            return azzzzzzzzzzzzzzzzzzzzzzzzzzs_;
        };
        IEnumerable<Communication> zzzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Where<Communication>(zzzzzzzzzzzzzzzzzzzzzzzzzzw_, zzzzzzzzzzzzzzzzzzzzzzzzzzx_);

        return zzzzzzzzzzzzzzzzzzzzzzzzzzy_;
    }


    [CqlExpressionDefinition("Macular Edema Absence Communicated")]
    public IEnumerable<Communication> Macular_Edema_Absence_Communicated(CqlContext context)
    {
        PropertyInfo azzzzzzzzzzzzzzzzzzzzzzzzzzt_ = typeof(Communication).GetProperty("ReasonCode");
        CqlValueSet azzzzzzzzzzzzzzzzzzzzzzzzzzu_ = this.Macular_edema_absent__situation_(context);
        IEnumerable<Communication> azzzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Retrieve<Communication>(new RetrieveParameters(azzzzzzzzzzzzzzzzzzzzzzzzzzt_, azzzzzzzzzzzzzzzzzzzzzzzzzzu_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-communication"));
        IEnumerable<Communication> azzzzzzzzzzzzzzzzzzzzzzzzzzw_(Communication MacularEdemaAbsentCommunicated)
        {
            IEnumerable<Encounter> bzzzzzzzzzzzzzzzzzzzzzzzzzza_ = this.Diabetic_Retinopathy_Encounter(context);
            bool? bzzzzzzzzzzzzzzzzzzzzzzzzzzb_(Encounter EncounterDiabeticRetinopathy)
            {
                FhirDateTime bzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = MacularEdemaAbsentCommunicated?.SentElement;
                CqlDateTime bzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Convert<CqlDateTime>(bzzzzzzzzzzzzzzzzzzzzzzzzzzf_);
                Period bzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = EncounterDiabeticRetinopathy?.Period;
                CqlInterval<CqlDateTime> bzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, bzzzzzzzzzzzzzzzzzzzzzzzzzzh_);
                CqlDateTime bzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Start(bzzzzzzzzzzzzzzzzzzzzzzzzzzi_);
                bool? bzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.After(bzzzzzzzzzzzzzzzzzzzzzzzzzzg_, bzzzzzzzzzzzzzzzzzzzzzzzzzzj_, default);
                CqlDateTime bzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Convert<CqlDateTime>(bzzzzzzzzzzzzzzzzzzzzzzzzzzf_);
                CqlInterval<CqlDateTime> bzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = this.Measurement_Period(context);
                bool? bzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.In<CqlDateTime>(bzzzzzzzzzzzzzzzzzzzzzzzzzzm_, bzzzzzzzzzzzzzzzzzzzzzzzzzzn_, "day");
                bool? bzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.And(bzzzzzzzzzzzzzzzzzzzzzzzzzzk_, bzzzzzzzzzzzzzzzzzzzzzzzzzzo_);

                return bzzzzzzzzzzzzzzzzzzzzzzzzzzp_;
            };
            IEnumerable<Encounter> bzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Where<Encounter>(bzzzzzzzzzzzzzzzzzzzzzzzzzza_, bzzzzzzzzzzzzzzzzzzzzzzzzzzb_);
            Communication bzzzzzzzzzzzzzzzzzzzzzzzzzzd_(Encounter EncounterDiabeticRetinopathy) =>
                MacularEdemaAbsentCommunicated;
            IEnumerable<Communication> bzzzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Select<Encounter, Communication>(bzzzzzzzzzzzzzzzzzzzzzzzzzzc_, bzzzzzzzzzzzzzzzzzzzzzzzzzzd_);

            return bzzzzzzzzzzzzzzzzzzzzzzzzzze_;
        };
        IEnumerable<Communication> azzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.SelectMany<Communication, Communication>(azzzzzzzzzzzzzzzzzzzzzzzzzzv_, azzzzzzzzzzzzzzzzzzzzzzzzzzw_);
        bool? azzzzzzzzzzzzzzzzzzzzzzzzzzy_(Communication MacularEdemaAbsentCommunicated)
        {
            Code<EventStatus> bzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = MacularEdemaAbsentCommunicated?.StatusElement;
            EventStatus? bzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = bzzzzzzzzzzzzzzzzzzzzzzzzzzq_?.Value;
            Code<EventStatus> bzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Convert<Code<EventStatus>>(bzzzzzzzzzzzzzzzzzzzzzzzzzzr_);
            bool? bzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Equal(bzzzzzzzzzzzzzzzzzzzzzzzzzzs_, "completed");

            return bzzzzzzzzzzzzzzzzzzzzzzzzzzt_;
        };
        IEnumerable<Communication> azzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Where<Communication>(azzzzzzzzzzzzzzzzzzzzzzzzzzx_, azzzzzzzzzzzzzzzzzzzzzzzzzzy_);

        return azzzzzzzzzzzzzzzzzzzzzzzzzzz_;
    }


    [CqlExpressionDefinition("Macular Edema Presence Communicated")]
    public IEnumerable<Communication> Macular_Edema_Presence_Communicated(CqlContext context)
    {
        PropertyInfo bzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = typeof(Communication).GetProperty("ReasonCode");
        CqlValueSet bzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = this.Macular_Edema_Findings_Present(context);
        IEnumerable<Communication> bzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Retrieve<Communication>(new RetrieveParameters(bzzzzzzzzzzzzzzzzzzzzzzzzzzu_, bzzzzzzzzzzzzzzzzzzzzzzzzzzv_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-communication"));
        IEnumerable<Communication> bzzzzzzzzzzzzzzzzzzzzzzzzzzx_(Communication MacularEdemaPresentCommunicated)
        {
            IEnumerable<Encounter> czzzzzzzzzzzzzzzzzzzzzzzzzzb_ = this.Diabetic_Retinopathy_Encounter(context);
            bool? czzzzzzzzzzzzzzzzzzzzzzzzzzc_(Encounter EncounterDiabeticRetinopathy)
            {
                FhirDateTime czzzzzzzzzzzzzzzzzzzzzzzzzzg_ = MacularEdemaPresentCommunicated?.SentElement;
                CqlDateTime czzzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Convert<CqlDateTime>(czzzzzzzzzzzzzzzzzzzzzzzzzzg_);
                Period czzzzzzzzzzzzzzzzzzzzzzzzzzi_ = EncounterDiabeticRetinopathy?.Period;
                CqlInterval<CqlDateTime> czzzzzzzzzzzzzzzzzzzzzzzzzzj_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, czzzzzzzzzzzzzzzzzzzzzzzzzzi_);
                CqlDateTime czzzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Start(czzzzzzzzzzzzzzzzzzzzzzzzzzj_);
                bool? czzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.After(czzzzzzzzzzzzzzzzzzzzzzzzzzh_, czzzzzzzzzzzzzzzzzzzzzzzzzzk_, default);
                CqlDateTime czzzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Convert<CqlDateTime>(czzzzzzzzzzzzzzzzzzzzzzzzzzg_);
                CqlInterval<CqlDateTime> czzzzzzzzzzzzzzzzzzzzzzzzzzo_ = this.Measurement_Period(context);
                bool? czzzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.In<CqlDateTime>(czzzzzzzzzzzzzzzzzzzzzzzzzzn_, czzzzzzzzzzzzzzzzzzzzzzzzzzo_, "day");
                bool? czzzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.And(czzzzzzzzzzzzzzzzzzzzzzzzzzl_, czzzzzzzzzzzzzzzzzzzzzzzzzzp_);

                return czzzzzzzzzzzzzzzzzzzzzzzzzzq_;
            };
            IEnumerable<Encounter> czzzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Where<Encounter>(czzzzzzzzzzzzzzzzzzzzzzzzzzb_, czzzzzzzzzzzzzzzzzzzzzzzzzzc_);
            Communication czzzzzzzzzzzzzzzzzzzzzzzzzze_(Encounter EncounterDiabeticRetinopathy) =>
                MacularEdemaPresentCommunicated;
            IEnumerable<Communication> czzzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Select<Encounter, Communication>(czzzzzzzzzzzzzzzzzzzzzzzzzzd_, czzzzzzzzzzzzzzzzzzzzzzzzzze_);

            return czzzzzzzzzzzzzzzzzzzzzzzzzzf_;
        };
        IEnumerable<Communication> bzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.SelectMany<Communication, Communication>(bzzzzzzzzzzzzzzzzzzzzzzzzzzw_, bzzzzzzzzzzzzzzzzzzzzzzzzzzx_);
        bool? bzzzzzzzzzzzzzzzzzzzzzzzzzzz_(Communication MacularEdemaPresentCommunicated)
        {
            Code<EventStatus> czzzzzzzzzzzzzzzzzzzzzzzzzzr_ = MacularEdemaPresentCommunicated?.StatusElement;
            EventStatus? czzzzzzzzzzzzzzzzzzzzzzzzzzs_ = czzzzzzzzzzzzzzzzzzzzzzzzzzr_?.Value;
            Code<EventStatus> czzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Convert<Code<EventStatus>>(czzzzzzzzzzzzzzzzzzzzzzzzzzs_);
            bool? czzzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Equal(czzzzzzzzzzzzzzzzzzzzzzzzzzt_, "completed");

            return czzzzzzzzzzzzzzzzzzzzzzzzzzu_;
        };
        IEnumerable<Communication> czzzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Where<Communication>(bzzzzzzzzzzzzzzzzzzzzzzzzzzy_, bzzzzzzzzzzzzzzzzzzzzzzzzzzz_);

        return czzzzzzzzzzzzzzzzzzzzzzzzzza_;
    }


    [CqlExpressionDefinition("Numerator")]
    public bool? Numerator(CqlContext context)
    {
        IEnumerable<Communication> czzzzzzzzzzzzzzzzzzzzzzzzzzv_ = this.Level_of_Severity_of_Retinopathy_Findings_Communicated(context);
        bool? czzzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Exists<Communication>(czzzzzzzzzzzzzzzzzzzzzzzzzzv_);
        IEnumerable<Communication> czzzzzzzzzzzzzzzzzzzzzzzzzzx_ = this.Macular_Edema_Absence_Communicated(context);
        bool? czzzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Exists<Communication>(czzzzzzzzzzzzzzzzzzzzzzzzzzx_);
        IEnumerable<Communication> czzzzzzzzzzzzzzzzzzzzzzzzzzz_ = this.Macular_Edema_Presence_Communicated(context);
        bool? dzzzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Exists<Communication>(czzzzzzzzzzzzzzzzzzzzzzzzzzz_);
        bool? dzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Or(czzzzzzzzzzzzzzzzzzzzzzzzzzy_, dzzzzzzzzzzzzzzzzzzzzzzzzzza_);
        bool? dzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.And(czzzzzzzzzzzzzzzzzzzzzzzzzzw_, dzzzzzzzzzzzzzzzzzzzzzzzzzzb_);

        return dzzzzzzzzzzzzzzzzzzzzzzzzzzc_;
    }


    [CqlExpressionDefinition("Medical or Patient Reason for Not Communicating Level of Severity of Retinopathy")]
    public IEnumerable<Communication> Medical_or_Patient_Reason_for_Not_Communicating_Level_of_Severity_of_Retinopathy(CqlContext context)
    {
        PropertyInfo dzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = typeof(Communication).GetProperty("ReasonCode");
        CqlValueSet dzzzzzzzzzzzzzzzzzzzzzzzzzze_ = this.Level_of_Severity_of_Retinopathy_Findings(context);
        IEnumerable<Communication> dzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Retrieve<Communication>(new RetrieveParameters(dzzzzzzzzzzzzzzzzzzzzzzzzzzd_, dzzzzzzzzzzzzzzzzzzzzzzzzzze_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-communicationnotdone"));
        IEnumerable<Communication> dzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Retrieve<Communication>(new RetrieveParameters(dzzzzzzzzzzzzzzzzzzzzzzzzzzd_, dzzzzzzzzzzzzzzzzzzzzzzzzzze_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-communicationnotdone"));
        IEnumerable<Communication> dzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Union<Communication>(dzzzzzzzzzzzzzzzzzzzzzzzzzzf_, dzzzzzzzzzzzzzzzzzzzzzzzzzzi_);
        IEnumerable<Communication> dzzzzzzzzzzzzzzzzzzzzzzzzzzk_(Communication LevelOfSeverityNotCommunicated)
        {
            IEnumerable<Encounter> dzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = this.Diabetic_Retinopathy_Encounter(context);
            bool? dzzzzzzzzzzzzzzzzzzzzzzzzzzp_(Encounter EncounterDiabeticRetinopathy)
            {
                FhirDateTime dzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = LevelOfSeverityNotCommunicated?.SentElement;
                CqlDateTime dzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Convert<CqlDateTime>(dzzzzzzzzzzzzzzzzzzzzzzzzzzt_);
                Period dzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = EncounterDiabeticRetinopathy?.Period;
                CqlInterval<CqlDateTime> dzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, dzzzzzzzzzzzzzzzzzzzzzzzzzzv_);
                bool? dzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.In<CqlDateTime>(dzzzzzzzzzzzzzzzzzzzzzzzzzzu_, dzzzzzzzzzzzzzzzzzzzzzzzzzzw_, default);

                return dzzzzzzzzzzzzzzzzzzzzzzzzzzx_;
            };
            IEnumerable<Encounter> dzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Where<Encounter>(dzzzzzzzzzzzzzzzzzzzzzzzzzzo_, dzzzzzzzzzzzzzzzzzzzzzzzzzzp_);
            Communication dzzzzzzzzzzzzzzzzzzzzzzzzzzr_(Encounter EncounterDiabeticRetinopathy) =>
                LevelOfSeverityNotCommunicated;
            IEnumerable<Communication> dzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Select<Encounter, Communication>(dzzzzzzzzzzzzzzzzzzzzzzzzzzq_, dzzzzzzzzzzzzzzzzzzzzzzzzzzr_);

            return dzzzzzzzzzzzzzzzzzzzzzzzzzzs_;
        };
        IEnumerable<Communication> dzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.SelectMany<Communication, Communication>(dzzzzzzzzzzzzzzzzzzzzzzzzzzj_, dzzzzzzzzzzzzzzzzzzzzzzzzzzk_);
        bool? dzzzzzzzzzzzzzzzzzzzzzzzzzzm_(Communication LevelOfSeverityNotCommunicated)
        {
            CodeableConcept dzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = LevelOfSeverityNotCommunicated?.StatusReason;
            CqlConcept dzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, dzzzzzzzzzzzzzzzzzzzzzzzzzzy_);
            CqlValueSet ezzzzzzzzzzzzzzzzzzzzzzzzzza_ = this.Medical_Reason(context);
            bool? ezzzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.ConceptInValueSet(dzzzzzzzzzzzzzzzzzzzzzzzzzzz_, ezzzzzzzzzzzzzzzzzzzzzzzzzza_);
            CqlConcept ezzzzzzzzzzzzzzzzzzzzzzzzzzd_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, dzzzzzzzzzzzzzzzzzzzzzzzzzzy_);
            CqlValueSet ezzzzzzzzzzzzzzzzzzzzzzzzzze_ = this.Patient_Reason(context);
            bool? ezzzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.ConceptInValueSet(ezzzzzzzzzzzzzzzzzzzzzzzzzzd_, ezzzzzzzzzzzzzzzzzzzzzzzzzze_);
            bool? ezzzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Or(ezzzzzzzzzzzzzzzzzzzzzzzzzzb_, ezzzzzzzzzzzzzzzzzzzzzzzzzzf_);

            return ezzzzzzzzzzzzzzzzzzzzzzzzzzg_;
        };
        IEnumerable<Communication> dzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Where<Communication>(dzzzzzzzzzzzzzzzzzzzzzzzzzzl_, dzzzzzzzzzzzzzzzzzzzzzzzzzzm_);

        return dzzzzzzzzzzzzzzzzzzzzzzzzzzn_;
    }


    [CqlExpressionDefinition("Medical or Patient Reason for Not Communicating Absence of Macular Edema")]
    public IEnumerable<Communication> Medical_or_Patient_Reason_for_Not_Communicating_Absence_of_Macular_Edema(CqlContext context)
    {
        PropertyInfo ezzzzzzzzzzzzzzzzzzzzzzzzzzh_ = typeof(Communication).GetProperty("ReasonCode");
        CqlValueSet ezzzzzzzzzzzzzzzzzzzzzzzzzzi_ = this.Macular_edema_absent__situation_(context);
        IEnumerable<Communication> ezzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Retrieve<Communication>(new RetrieveParameters(ezzzzzzzzzzzzzzzzzzzzzzzzzzh_, ezzzzzzzzzzzzzzzzzzzzzzzzzzi_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-communicationnotdone"));
        IEnumerable<Communication> ezzzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Retrieve<Communication>(new RetrieveParameters(ezzzzzzzzzzzzzzzzzzzzzzzzzzh_, ezzzzzzzzzzzzzzzzzzzzzzzzzzi_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-communicationnotdone"));
        IEnumerable<Communication> ezzzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Union<Communication>(ezzzzzzzzzzzzzzzzzzzzzzzzzzj_, ezzzzzzzzzzzzzzzzzzzzzzzzzzm_);
        IEnumerable<Communication> ezzzzzzzzzzzzzzzzzzzzzzzzzzo_(Communication MacularEdemaAbsentNotCommunicated)
        {
            IEnumerable<Encounter> ezzzzzzzzzzzzzzzzzzzzzzzzzzs_ = this.Diabetic_Retinopathy_Encounter(context);
            bool? ezzzzzzzzzzzzzzzzzzzzzzzzzzt_(Encounter EncounterDiabeticRetinopathy)
            {
                FhirDateTime ezzzzzzzzzzzzzzzzzzzzzzzzzzx_ = MacularEdemaAbsentNotCommunicated?.SentElement;
                CqlDateTime ezzzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Convert<CqlDateTime>(ezzzzzzzzzzzzzzzzzzzzzzzzzzx_);
                Period ezzzzzzzzzzzzzzzzzzzzzzzzzzz_ = EncounterDiabeticRetinopathy?.Period;
                CqlInterval<CqlDateTime> fzzzzzzzzzzzzzzzzzzzzzzzzzza_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ezzzzzzzzzzzzzzzzzzzzzzzzzzz_);
                bool? fzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.In<CqlDateTime>(ezzzzzzzzzzzzzzzzzzzzzzzzzzy_, fzzzzzzzzzzzzzzzzzzzzzzzzzza_, default);

                return fzzzzzzzzzzzzzzzzzzzzzzzzzzb_;
            };
            IEnumerable<Encounter> ezzzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Where<Encounter>(ezzzzzzzzzzzzzzzzzzzzzzzzzzs_, ezzzzzzzzzzzzzzzzzzzzzzzzzzt_);
            Communication ezzzzzzzzzzzzzzzzzzzzzzzzzzv_(Encounter EncounterDiabeticRetinopathy) =>
                MacularEdemaAbsentNotCommunicated;
            IEnumerable<Communication> ezzzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Select<Encounter, Communication>(ezzzzzzzzzzzzzzzzzzzzzzzzzzu_, ezzzzzzzzzzzzzzzzzzzzzzzzzzv_);

            return ezzzzzzzzzzzzzzzzzzzzzzzzzzw_;
        };
        IEnumerable<Communication> ezzzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.SelectMany<Communication, Communication>(ezzzzzzzzzzzzzzzzzzzzzzzzzzn_, ezzzzzzzzzzzzzzzzzzzzzzzzzzo_);
        bool? ezzzzzzzzzzzzzzzzzzzzzzzzzzq_(Communication MacularEdemaAbsentNotCommunicated)
        {
            CodeableConcept fzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = MacularEdemaAbsentNotCommunicated?.StatusReason;
            CqlConcept fzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, fzzzzzzzzzzzzzzzzzzzzzzzzzzc_);
            CqlValueSet fzzzzzzzzzzzzzzzzzzzzzzzzzze_ = this.Medical_Reason(context);
            bool? fzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.ConceptInValueSet(fzzzzzzzzzzzzzzzzzzzzzzzzzzd_, fzzzzzzzzzzzzzzzzzzzzzzzzzze_);
            CqlConcept fzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, fzzzzzzzzzzzzzzzzzzzzzzzzzzc_);
            CqlValueSet fzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = this.Patient_Reason(context);
            bool? fzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.ConceptInValueSet(fzzzzzzzzzzzzzzzzzzzzzzzzzzh_, fzzzzzzzzzzzzzzzzzzzzzzzzzzi_);
            bool? fzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Or(fzzzzzzzzzzzzzzzzzzzzzzzzzzf_, fzzzzzzzzzzzzzzzzzzzzzzzzzzj_);

            return fzzzzzzzzzzzzzzzzzzzzzzzzzzk_;
        };
        IEnumerable<Communication> ezzzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Where<Communication>(ezzzzzzzzzzzzzzzzzzzzzzzzzzp_, ezzzzzzzzzzzzzzzzzzzzzzzzzzq_);

        return ezzzzzzzzzzzzzzzzzzzzzzzzzzr_;
    }


    [CqlExpressionDefinition("Medical or Patient Reason for Not Communicating Presence of Macular Edema")]
    public IEnumerable<Communication> Medical_or_Patient_Reason_for_Not_Communicating_Presence_of_Macular_Edema(CqlContext context)
    {
        PropertyInfo fzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = typeof(Communication).GetProperty("ReasonCode");
        CqlValueSet fzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = this.Macular_Edema_Findings_Present(context);
        IEnumerable<Communication> fzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Retrieve<Communication>(new RetrieveParameters(fzzzzzzzzzzzzzzzzzzzzzzzzzzl_, fzzzzzzzzzzzzzzzzzzzzzzzzzzm_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-communicationnotdone"));
        IEnumerable<Communication> fzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Retrieve<Communication>(new RetrieveParameters(fzzzzzzzzzzzzzzzzzzzzzzzzzzl_, fzzzzzzzzzzzzzzzzzzzzzzzzzzm_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-communicationnotdone"));
        IEnumerable<Communication> fzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Union<Communication>(fzzzzzzzzzzzzzzzzzzzzzzzzzzn_, fzzzzzzzzzzzzzzzzzzzzzzzzzzq_);
        IEnumerable<Communication> fzzzzzzzzzzzzzzzzzzzzzzzzzzs_(Communication MacularEdemaPresentNotCommunicated)
        {
            IEnumerable<Encounter> fzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = this.Diabetic_Retinopathy_Encounter(context);
            bool? fzzzzzzzzzzzzzzzzzzzzzzzzzzx_(Encounter EncounterDiabeticRetinopathy)
            {
                FhirDateTime gzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = MacularEdemaPresentNotCommunicated?.SentElement;
                CqlDateTime gzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Convert<CqlDateTime>(gzzzzzzzzzzzzzzzzzzzzzzzzzzb_);
                Period gzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = EncounterDiabeticRetinopathy?.Period;
                CqlInterval<CqlDateTime> gzzzzzzzzzzzzzzzzzzzzzzzzzze_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, gzzzzzzzzzzzzzzzzzzzzzzzzzzd_);
                bool? gzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.In<CqlDateTime>(gzzzzzzzzzzzzzzzzzzzzzzzzzzc_, gzzzzzzzzzzzzzzzzzzzzzzzzzze_, default);

                return gzzzzzzzzzzzzzzzzzzzzzzzzzzf_;
            };
            IEnumerable<Encounter> fzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Where<Encounter>(fzzzzzzzzzzzzzzzzzzzzzzzzzzw_, fzzzzzzzzzzzzzzzzzzzzzzzzzzx_);
            Communication fzzzzzzzzzzzzzzzzzzzzzzzzzzz_(Encounter EncounterDiabeticRetinopathy) =>
                MacularEdemaPresentNotCommunicated;
            IEnumerable<Communication> gzzzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Select<Encounter, Communication>(fzzzzzzzzzzzzzzzzzzzzzzzzzzy_, fzzzzzzzzzzzzzzzzzzzzzzzzzzz_);

            return gzzzzzzzzzzzzzzzzzzzzzzzzzza_;
        };
        IEnumerable<Communication> fzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.SelectMany<Communication, Communication>(fzzzzzzzzzzzzzzzzzzzzzzzzzzr_, fzzzzzzzzzzzzzzzzzzzzzzzzzzs_);
        bool? fzzzzzzzzzzzzzzzzzzzzzzzzzzu_(Communication MacularEdemaPresentNotCommunicated)
        {
            CodeableConcept gzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = MacularEdemaPresentNotCommunicated?.StatusReason;
            CqlConcept gzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, gzzzzzzzzzzzzzzzzzzzzzzzzzzg_);
            CqlValueSet gzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = this.Medical_Reason(context);
            bool? gzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.ConceptInValueSet(gzzzzzzzzzzzzzzzzzzzzzzzzzzh_, gzzzzzzzzzzzzzzzzzzzzzzzzzzi_);
            CqlConcept gzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, gzzzzzzzzzzzzzzzzzzzzzzzzzzg_);
            CqlValueSet gzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = this.Patient_Reason(context);
            bool? gzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.ConceptInValueSet(gzzzzzzzzzzzzzzzzzzzzzzzzzzl_, gzzzzzzzzzzzzzzzzzzzzzzzzzzm_);
            bool? gzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Or(gzzzzzzzzzzzzzzzzzzzzzzzzzzj_, gzzzzzzzzzzzzzzzzzzzzzzzzzzn_);

            return gzzzzzzzzzzzzzzzzzzzzzzzzzzo_;
        };
        IEnumerable<Communication> fzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Where<Communication>(fzzzzzzzzzzzzzzzzzzzzzzzzzzt_, fzzzzzzzzzzzzzzzzzzzzzzzzzzu_);

        return fzzzzzzzzzzzzzzzzzzzzzzzzzzv_;
    }


    [CqlExpressionDefinition("Denominator Exceptions")]
    public bool? Denominator_Exceptions(CqlContext context)
    {
        IEnumerable<Communication> gzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = this.Medical_or_Patient_Reason_for_Not_Communicating_Level_of_Severity_of_Retinopathy(context);
        bool? gzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Exists<Communication>(gzzzzzzzzzzzzzzzzzzzzzzzzzzp_);
        IEnumerable<Communication> gzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = this.Medical_or_Patient_Reason_for_Not_Communicating_Absence_of_Macular_Edema(context);
        bool? gzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Exists<Communication>(gzzzzzzzzzzzzzzzzzzzzzzzzzzr_);
        bool? gzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Or(gzzzzzzzzzzzzzzzzzzzzzzzzzzq_, gzzzzzzzzzzzzzzzzzzzzzzzzzzs_);
        IEnumerable<Communication> gzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = this.Medical_or_Patient_Reason_for_Not_Communicating_Presence_of_Macular_Edema(context);
        bool? gzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Exists<Communication>(gzzzzzzzzzzzzzzzzzzzzzzzzzzu_);
        bool? gzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Or(gzzzzzzzzzzzzzzzzzzzzzzzzzzt_, gzzzzzzzzzzzzzzzzzzzzzzzzzzv_);

        return gzzzzzzzzzzzzzzzzzzzzzzzzzzw_;
    }


    [CqlExpressionDefinition("Results of Dilated Macular or Fundus Exam Communicated")]
    public bool? Results_of_Dilated_Macular_or_Fundus_Exam_Communicated(CqlContext context)
    {
        IEnumerable<Communication> gzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = this.Level_of_Severity_of_Retinopathy_Findings_Communicated(context);
        bool? gzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Exists<Communication>(gzzzzzzzzzzzzzzzzzzzzzzzzzzx_);
        IEnumerable<Communication> gzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = this.Macular_Edema_Absence_Communicated(context);
        bool? hzzzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Exists<Communication>(gzzzzzzzzzzzzzzzzzzzzzzzzzzz_);
        IEnumerable<Communication> hzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = this.Macular_Edema_Presence_Communicated(context);
        bool? hzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Exists<Communication>(hzzzzzzzzzzzzzzzzzzzzzzzzzzb_);
        bool? hzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Or(hzzzzzzzzzzzzzzzzzzzzzzzzzza_, hzzzzzzzzzzzzzzzzzzzzzzzzzzc_);
        bool? hzzzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.And(gzzzzzzzzzzzzzzzzzzzzzzzzzzy_, hzzzzzzzzzzzzzzzzzzzzzzzzzzd_);

        return hzzzzzzzzzzzzzzzzzzzzzzzzzze_;
    }


    #endregion Expressions

}
