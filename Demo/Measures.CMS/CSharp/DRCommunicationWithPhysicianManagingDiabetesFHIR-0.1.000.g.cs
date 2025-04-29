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

    #region ValueSet: Care Services in Long-Term Residential Facility
    [CqlValueSetDefinition(
        definitionName: "Care Services in Long-Term Residential Facility",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1014",
        valueSetVersion: null)]
    public CqlValueSet Care_Services_in_Long_Term_Residential_Facility(CqlContext context) => _Care_Services_in_Long_Term_Residential_Facility;

    private static readonly CqlValueSet _Care_Services_in_Long_Term_Residential_Facility = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1014", null);
    #endregion

    #region ValueSet: Diabetic Retinopathy
    [CqlValueSetDefinition(
        definitionName: "Diabetic Retinopathy",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.327",
        valueSetVersion: null)]
    public CqlValueSet Diabetic_Retinopathy(CqlContext context) => _Diabetic_Retinopathy;

    private static readonly CqlValueSet _Diabetic_Retinopathy = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.327", null);
    #endregion

    #region ValueSet: Level of Severity of Retinopathy Findings
    [CqlValueSetDefinition(
        definitionName: "Level of Severity of Retinopathy Findings",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1283",
        valueSetVersion: null)]
    public CqlValueSet Level_of_Severity_of_Retinopathy_Findings(CqlContext context) => _Level_of_Severity_of_Retinopathy_Findings;

    private static readonly CqlValueSet _Level_of_Severity_of_Retinopathy_Findings = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1283", null);
    #endregion

    #region ValueSet: Macular Edema Findings Present
    [CqlValueSetDefinition(
        definitionName: "Macular Edema Findings Present",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1320",
        valueSetVersion: null)]
    public CqlValueSet Macular_Edema_Findings_Present(CqlContext context) => _Macular_Edema_Findings_Present;

    private static readonly CqlValueSet _Macular_Edema_Findings_Present = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1320", null);
    #endregion

    #region ValueSet: Macular Exam
    [CqlValueSetDefinition(
        definitionName: "Macular Exam",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1251",
        valueSetVersion: null)]
    public CqlValueSet Macular_Exam(CqlContext context) => _Macular_Exam;

    private static readonly CqlValueSet _Macular_Exam = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1251", null);
    #endregion

    #region ValueSet: Medical Reason
    [CqlValueSetDefinition(
        definitionName: "Medical Reason",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1007",
        valueSetVersion: null)]
    public CqlValueSet Medical_Reason(CqlContext context) => _Medical_Reason;

    private static readonly CqlValueSet _Medical_Reason = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1007", null);
    #endregion

    #region ValueSet: Nursing Facility Visit
    [CqlValueSetDefinition(
        definitionName: "Nursing Facility Visit",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1012",
        valueSetVersion: null)]
    public CqlValueSet Nursing_Facility_Visit(CqlContext context) => _Nursing_Facility_Visit;

    private static readonly CqlValueSet _Nursing_Facility_Visit = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1012", null);
    #endregion

    #region ValueSet: Office Visit
    [CqlValueSetDefinition(
        definitionName: "Office Visit",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1001",
        valueSetVersion: null)]
    public CqlValueSet Office_Visit(CqlContext context) => _Office_Visit;

    private static readonly CqlValueSet _Office_Visit = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1001", null);
    #endregion

    #region ValueSet: Ophthalmological Services
    [CqlValueSetDefinition(
        definitionName: "Ophthalmological Services",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1285",
        valueSetVersion: null)]
    public CqlValueSet Ophthalmological_Services(CqlContext context) => _Ophthalmological_Services;

    private static readonly CqlValueSet _Ophthalmological_Services = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1285", null);
    #endregion

    #region ValueSet: Outpatient Consultation
    [CqlValueSetDefinition(
        definitionName: "Outpatient Consultation",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1008",
        valueSetVersion: null)]
    public CqlValueSet Outpatient_Consultation(CqlContext context) => _Outpatient_Consultation;

    private static readonly CqlValueSet _Outpatient_Consultation = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1008", null);
    #endregion

    #region ValueSet: Patient Reason
    [CqlValueSetDefinition(
        definitionName: "Patient Reason",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1008",
        valueSetVersion: null)]
    public CqlValueSet Patient_Reason(CqlContext context) => _Patient_Reason;

    private static readonly CqlValueSet _Patient_Reason = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1008", null);
    #endregion

    #region ValueSet: Macular edema absent (situation)
    [CqlValueSetDefinition(
        definitionName: "Macular edema absent (situation)",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.2.1391",
        valueSetVersion: null)]
    public CqlValueSet Macular_edema_absent__situation_(CqlContext context) => _Macular_edema_absent__situation_;

    private static readonly CqlValueSet _Macular_edema_absent__situation_ = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.2.1391", null);
    #endregion

    #endregion ValueSets

    #region Codes

    #region Code: Healthcare professional (occupation)
    [CqlCodeDefinition(
        definitionName: "Healthcare professional (occupation)",
        codeId: "223366009",
        codeSystem: "http://snomed.info/sct")]
    public CqlCode Healthcare_professional__occupation_(CqlContext context) => _Healthcare_professional__occupation_;

    private static readonly CqlCode _Healthcare_professional__occupation_ = new CqlCode("223366009", "http://snomed.info/sct", default, default);
    #endregion

    #region Code: Medical practitioner (occupation)
    [CqlCodeDefinition(
        definitionName: "Medical practitioner (occupation)",
        codeId: "158965000",
        codeSystem: "http://snomed.info/sct")]
    public CqlCode Medical_practitioner__occupation_(CqlContext context) => _Medical_practitioner__occupation_;

    private static readonly CqlCode _Medical_practitioner__occupation_ = new CqlCode("158965000", "http://snomed.info/sct", default, default);
    #endregion

    #region Code: Ophthalmologist (occupation)
    [CqlCodeDefinition(
        definitionName: "Ophthalmologist (occupation)",
        codeId: "422234006",
        codeSystem: "http://snomed.info/sct")]
    public CqlCode Ophthalmologist__occupation_(CqlContext context) => _Ophthalmologist__occupation_;

    private static readonly CqlCode _Ophthalmologist__occupation_ = new CqlCode("422234006", "http://snomed.info/sct", default, default);
    #endregion

    #region Code: Optometrist (occupation)
    [CqlCodeDefinition(
        definitionName: "Optometrist (occupation)",
        codeId: "28229004",
        codeSystem: "http://snomed.info/sct")]
    public CqlCode Optometrist__occupation_(CqlContext context) => _Optometrist__occupation_;

    private static readonly CqlCode _Optometrist__occupation_ = new CqlCode("28229004", "http://snomed.info/sct", default, default);
    #endregion

    #region Code: Physician (occupation)
    [CqlCodeDefinition(
        definitionName: "Physician (occupation)",
        codeId: "309343006",
        codeSystem: "http://snomed.info/sct")]
    public CqlCode Physician__occupation_(CqlContext context) => _Physician__occupation_;

    private static readonly CqlCode _Physician__occupation_ = new CqlCode("309343006", "http://snomed.info/sct", default, default);
    #endregion

    #region Code: virtual
    [CqlCodeDefinition(
        definitionName: "virtual",
        codeId: "VR",
        codeSystem: "http://terminology.hl7.org/CodeSystem/v3-ActCode")]
    public CqlCode @virtual(CqlContext context) => _virtual;

    private static readonly CqlCode _virtual = new CqlCode("VR", "http://terminology.hl7.org/CodeSystem/v3-ActCode", default, default);
    #endregion

    #region Code: AMB
    [CqlCodeDefinition(
        definitionName: "AMB",
        codeId: "AMB",
        codeSystem: "http://terminology.hl7.org/CodeSystem/v3-ActCode")]
    public CqlCode AMB(CqlContext context) => _AMB;

    private static readonly CqlCode _AMB = new CqlCode("AMB", "http://terminology.hl7.org/CodeSystem/v3-ActCode", default, default);
    #endregion

    #endregion Codes

    #region CodeSystems

    [CqlCodeSystemDefinition(
        definitionName: "SNOMEDCT")]
    public CqlCode[] SNOMEDCT(CqlContext context)
    {
        CqlCode[] mzzzzzzzzzza_ = [
            new CqlCode("223366009", "http://snomed.info/sct", default, default),
            new CqlCode("158965000", "http://snomed.info/sct", default, default),
            new CqlCode("422234006", "http://snomed.info/sct", default, default),
            new CqlCode("28229004", "http://snomed.info/sct", default, default),
            new CqlCode("309343006", "http://snomed.info/sct", default, default),
        ];

        return mzzzzzzzzzza_;
    }


    [CqlCodeSystemDefinition(
        definitionName: "ActCode")]
    public CqlCode[] ActCode(CqlContext context)
    {
        CqlCode[] mzzzzzzzzzzb_ = [
            new CqlCode("VR", "http://terminology.hl7.org/CodeSystem/v3-ActCode", default, default),
            new CqlCode("AMB", "http://terminology.hl7.org/CodeSystem/v3-ActCode", default, default),
        ];

        return mzzzzzzzzzzb_;
    }


    #endregion CodeSystems

    #region Parameters

    [CqlParameterDefinition(
        definitionName: "Measurement Period")]
    public CqlInterval<CqlDateTime> Measurement_Period(CqlContext context)
    {
        CqlDateTime mzzzzzzzzzzc_ = context.Operators.DateTime(2025, 1, 1, 0, 0, 0, 0, 0.0m);
        CqlDateTime mzzzzzzzzzzd_ = context.Operators.DateTime(2025, 12, 31, 23, 59, 59, 999, 0.0m);
        CqlInterval<CqlDateTime> mzzzzzzzzzze_ = context.Operators.Interval(mzzzzzzzzzzc_, mzzzzzzzzzzd_, true, true);
        object mzzzzzzzzzzf_ = context.ResolveParameter("DRCommunicationWithPhysicianManagingDiabetesFHIR-0.1.000", "Measurement Period", mzzzzzzzzzze_);

        return (CqlInterval<CqlDateTime>)mzzzzzzzzzzf_;
    }


    #endregion Parameters

    #region Expressions

    [CqlExpressionDefinition(
        definitionName: "Patient")]
    public Patient Patient(CqlContext context)
    {
        IEnumerable<Patient> mzzzzzzzzzzg_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-patient"));
        Patient mzzzzzzzzzzh_ = context.Operators.SingletonFrom<Patient>(mzzzzzzzzzzg_);

        return mzzzzzzzzzzh_;
    }


    [CqlExpressionDefinition(
        definitionName: "SDE Ethnicity")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Ethnicity(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? mzzzzzzzzzzi_ = SupplementalDataElements_3_5_000.Instance.SDE_Ethnicity(context);

        return mzzzzzzzzzzi_;
    }


    [CqlExpressionDefinition(
        definitionName: "SDE Payer")]
    public IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> SDE_Payer(CqlContext context)
    {
        IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> mzzzzzzzzzzj_ = SupplementalDataElements_3_5_000.Instance.SDE_Payer(context);

        return mzzzzzzzzzzj_;
    }


    [CqlExpressionDefinition(
        definitionName: "SDE Race")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Race(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? mzzzzzzzzzzk_ = SupplementalDataElements_3_5_000.Instance.SDE_Race(context);

        return mzzzzzzzzzzk_;
    }


    [CqlExpressionDefinition(
        definitionName: "SDE Sex")]
    public CqlCode SDE_Sex(CqlContext context)
    {
        CqlCode mzzzzzzzzzzl_ = SupplementalDataElements_3_5_000.Instance.SDE_Sex(context);

        return mzzzzzzzzzzl_;
    }


    [CqlExpressionDefinition(
        definitionName: "Qualifying Encounter During Measurement Period")]
    public IEnumerable<Encounter> Qualifying_Encounter_During_Measurement_Period(CqlContext context)
    {
        CqlValueSet mzzzzzzzzzzm_ = this.Office_Visit(context);
        IEnumerable<Encounter> mzzzzzzzzzzn_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, mzzzzzzzzzzm_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        CqlValueSet mzzzzzzzzzzo_ = this.Ophthalmological_Services(context);
        IEnumerable<Encounter> mzzzzzzzzzzp_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, mzzzzzzzzzzo_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> mzzzzzzzzzzq_ = context.Operators.Union<Encounter>(mzzzzzzzzzzn_, mzzzzzzzzzzp_);
        CqlValueSet mzzzzzzzzzzr_ = this.Outpatient_Consultation(context);
        IEnumerable<Encounter> mzzzzzzzzzzs_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, mzzzzzzzzzzr_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        CqlValueSet mzzzzzzzzzzt_ = this.Care_Services_in_Long_Term_Residential_Facility(context);
        IEnumerable<Encounter> mzzzzzzzzzzu_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, mzzzzzzzzzzt_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> mzzzzzzzzzzv_ = context.Operators.Union<Encounter>(mzzzzzzzzzzs_, mzzzzzzzzzzu_);
        IEnumerable<Encounter> mzzzzzzzzzzw_ = context.Operators.Union<Encounter>(mzzzzzzzzzzq_, mzzzzzzzzzzv_);
        CqlValueSet mzzzzzzzzzzx_ = this.Nursing_Facility_Visit(context);
        IEnumerable<Encounter> mzzzzzzzzzzy_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, mzzzzzzzzzzx_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> mzzzzzzzzzzz_ = context.Operators.Union<Encounter>(mzzzzzzzzzzw_, mzzzzzzzzzzy_);
        bool? nzzzzzzzzzza_(Encounter QualifyingEncounter)
        {
            CqlInterval<CqlDateTime> nzzzzzzzzzzc_ = this.Measurement_Period(context);
            Period nzzzzzzzzzzd_ = QualifyingEncounter?.Period;
            CqlInterval<CqlDateTime> nzzzzzzzzzze_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, nzzzzzzzzzzd_);
            bool? nzzzzzzzzzzf_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(nzzzzzzzzzzc_, nzzzzzzzzzze_, default);
            Code<Encounter.EncounterStatus> nzzzzzzzzzzg_ = QualifyingEncounter?.StatusElement;
            Encounter.EncounterStatus? nzzzzzzzzzzh_ = nzzzzzzzzzzg_?.Value;
            Code<Encounter.EncounterStatus> nzzzzzzzzzzi_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(nzzzzzzzzzzh_);
            bool? nzzzzzzzzzzj_ = context.Operators.Equal(nzzzzzzzzzzi_, "finished");
            bool? nzzzzzzzzzzk_ = context.Operators.And(nzzzzzzzzzzf_, nzzzzzzzzzzj_);
            Coding nzzzzzzzzzzl_ = QualifyingEncounter?.Class;
            CqlCode nzzzzzzzzzzm_ = FHIRHelpers_4_4_000.Instance.ToCode(context, nzzzzzzzzzzl_);
            CqlCode nzzzzzzzzzzn_ = this.@virtual(context);
            bool? nzzzzzzzzzzo_ = context.Operators.Equivalent(nzzzzzzzzzzm_, nzzzzzzzzzzn_);
            bool? nzzzzzzzzzzp_ = context.Operators.Not(nzzzzzzzzzzo_);
            bool? nzzzzzzzzzzq_ = context.Operators.And(nzzzzzzzzzzk_, nzzzzzzzzzzp_);

            return nzzzzzzzzzzq_;
        };
        IEnumerable<Encounter> nzzzzzzzzzzb_ = context.Operators.Where<Encounter>(mzzzzzzzzzzz_, nzzzzzzzzzza_);

        return nzzzzzzzzzzb_;
    }


    [CqlExpressionDefinition(
        definitionName: "Diabetic Retinopathy Encounter")]
    public IEnumerable<Encounter> Diabetic_Retinopathy_Encounter(CqlContext context)
    {
        IEnumerable<Encounter> nzzzzzzzzzzr_ = this.Qualifying_Encounter_During_Measurement_Period(context);
        IEnumerable<Encounter> nzzzzzzzzzzs_(Encounter ValidQualifyingEncounter)
        {
            CqlValueSet nzzzzzzzzzzu_ = this.Diabetic_Retinopathy(context);
            IEnumerable<Condition> nzzzzzzzzzzv_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, nzzzzzzzzzzu_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
            bool? nzzzzzzzzzzw_(Condition DiabeticRetinopathy)
            {
                CqlInterval<CqlDateTime> ozzzzzzzzzza_ = QICoreCommon_2_1_000.Instance.prevalenceInterval(context, DiabeticRetinopathy);
                Period ozzzzzzzzzzb_ = ValidQualifyingEncounter?.Period;
                CqlInterval<CqlDateTime> ozzzzzzzzzzc_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ozzzzzzzzzzb_);
                bool? ozzzzzzzzzzd_ = context.Operators.Overlaps(ozzzzzzzzzza_, ozzzzzzzzzzc_, default);
                bool? ozzzzzzzzzze_ = QICoreCommon_2_1_000.Instance.isActive(context, DiabeticRetinopathy);
                bool? ozzzzzzzzzzf_ = context.Operators.And(ozzzzzzzzzzd_, ozzzzzzzzzze_);
                CodeableConcept ozzzzzzzzzzg_ = DiabeticRetinopathy?.VerificationStatus;
                CqlConcept ozzzzzzzzzzh_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, ozzzzzzzzzzg_);
                CqlCode ozzzzzzzzzzi_ = QICoreCommon_2_1_000.Instance.unconfirmed(context);
                CqlConcept ozzzzzzzzzzj_ = context.Operators.ConvertCodeToConcept(ozzzzzzzzzzi_);
                bool? ozzzzzzzzzzk_ = context.Operators.Equivalent(ozzzzzzzzzzh_, ozzzzzzzzzzj_);
                CqlConcept ozzzzzzzzzzm_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, ozzzzzzzzzzg_);
                CqlCode ozzzzzzzzzzn_ = QICoreCommon_2_1_000.Instance.refuted(context);
                CqlConcept ozzzzzzzzzzo_ = context.Operators.ConvertCodeToConcept(ozzzzzzzzzzn_);
                bool? ozzzzzzzzzzp_ = context.Operators.Equivalent(ozzzzzzzzzzm_, ozzzzzzzzzzo_);
                bool? ozzzzzzzzzzq_ = context.Operators.Or(ozzzzzzzzzzk_, ozzzzzzzzzzp_);
                CqlConcept ozzzzzzzzzzs_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, ozzzzzzzzzzg_);
                CqlCode ozzzzzzzzzzt_ = QICoreCommon_2_1_000.Instance.entered_in_error(context);
                CqlConcept ozzzzzzzzzzu_ = context.Operators.ConvertCodeToConcept(ozzzzzzzzzzt_);
                bool? ozzzzzzzzzzv_ = context.Operators.Equivalent(ozzzzzzzzzzs_, ozzzzzzzzzzu_);
                bool? ozzzzzzzzzzw_ = context.Operators.Or(ozzzzzzzzzzq_, ozzzzzzzzzzv_);
                bool? ozzzzzzzzzzx_ = context.Operators.Not(ozzzzzzzzzzw_);
                bool? ozzzzzzzzzzy_ = context.Operators.And(ozzzzzzzzzzf_, ozzzzzzzzzzx_);

                return ozzzzzzzzzzy_;
            };
            IEnumerable<Condition> nzzzzzzzzzzx_ = context.Operators.Where<Condition>(nzzzzzzzzzzv_, nzzzzzzzzzzw_);
            Encounter nzzzzzzzzzzy_(Condition DiabeticRetinopathy) =>
                ValidQualifyingEncounter;
            IEnumerable<Encounter> nzzzzzzzzzzz_ = context.Operators.Select<Condition, Encounter>(nzzzzzzzzzzx_, nzzzzzzzzzzy_);

            return nzzzzzzzzzzz_;
        };
        IEnumerable<Encounter> nzzzzzzzzzzt_ = context.Operators.SelectMany<Encounter, Encounter>(nzzzzzzzzzzr_, nzzzzzzzzzzs_);

        return nzzzzzzzzzzt_;
    }


    [CqlExpressionDefinition(
        definitionName: "Initial Population")]
    public bool? Initial_Population(CqlContext context)
    {
        Patient ozzzzzzzzzzz_ = this.Patient(context);
        Date pzzzzzzzzzza_ = ozzzzzzzzzzz_?.BirthDateElement;
        string pzzzzzzzzzzb_ = pzzzzzzzzzza_?.Value;
        CqlDate pzzzzzzzzzzc_ = context.Operators.ConvertStringToDate(pzzzzzzzzzzb_);
        CqlInterval<CqlDateTime> pzzzzzzzzzzd_ = this.Measurement_Period(context);
        CqlDateTime pzzzzzzzzzze_ = context.Operators.Start(pzzzzzzzzzzd_);
        CqlDate pzzzzzzzzzzf_ = context.Operators.DateFrom(pzzzzzzzzzze_);
        int? pzzzzzzzzzzg_ = context.Operators.CalculateAgeAt(pzzzzzzzzzzc_, pzzzzzzzzzzf_, "year");
        bool? pzzzzzzzzzzh_ = context.Operators.GreaterOrEqual(pzzzzzzzzzzg_, 18);
        IEnumerable<Encounter> pzzzzzzzzzzi_ = this.Diabetic_Retinopathy_Encounter(context);
        bool? pzzzzzzzzzzj_ = context.Operators.Exists<Encounter>(pzzzzzzzzzzi_);
        bool? pzzzzzzzzzzk_ = context.Operators.And(pzzzzzzzzzzh_, pzzzzzzzzzzj_);

        return pzzzzzzzzzzk_;
    }


    [CqlExpressionDefinition(
        definitionName: "Macular Exam Performed")]
    public IEnumerable<Observation> Macular_Exam_Performed(CqlContext context)
    {
        CqlValueSet pzzzzzzzzzzl_ = this.Macular_Exam(context);
        IEnumerable<Observation> pzzzzzzzzzzm_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, pzzzzzzzzzzl_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        IEnumerable<Observation> pzzzzzzzzzzn_(Observation MacularExam)
        {
            IEnumerable<Encounter> pzzzzzzzzzzr_ = this.Diabetic_Retinopathy_Encounter(context);
            bool? pzzzzzzzzzzs_(Encounter EncounterDiabeticRetinopathy)
            {
                Period pzzzzzzzzzzw_ = EncounterDiabeticRetinopathy?.Period;
                CqlInterval<CqlDateTime> pzzzzzzzzzzx_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, pzzzzzzzzzzw_);
                DataType pzzzzzzzzzzy_ = MacularExam?.Effective;
                object pzzzzzzzzzzz_ = FHIRHelpers_4_4_000.Instance.ToValue(context, pzzzzzzzzzzy_);
                CqlInterval<CqlDateTime> qzzzzzzzzzza_ = QICoreCommon_2_1_000.Instance.toInterval(context, pzzzzzzzzzzz_);
                bool? qzzzzzzzzzzb_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(pzzzzzzzzzzx_, qzzzzzzzzzza_, default);

                return qzzzzzzzzzzb_;
            };
            IEnumerable<Encounter> pzzzzzzzzzzt_ = context.Operators.Where<Encounter>(pzzzzzzzzzzr_, pzzzzzzzzzzs_);
            Observation pzzzzzzzzzzu_(Encounter EncounterDiabeticRetinopathy) =>
                MacularExam;
            IEnumerable<Observation> pzzzzzzzzzzv_ = context.Operators.Select<Encounter, Observation>(pzzzzzzzzzzt_, pzzzzzzzzzzu_);

            return pzzzzzzzzzzv_;
        };
        IEnumerable<Observation> pzzzzzzzzzzo_ = context.Operators.SelectMany<Observation, Observation>(pzzzzzzzzzzm_, pzzzzzzzzzzn_);
        bool? pzzzzzzzzzzp_(Observation MacularExam)
        {
            DataType qzzzzzzzzzzc_ = MacularExam?.Value;
            object qzzzzzzzzzzd_ = FHIRHelpers_4_4_000.Instance.ToValue(context, qzzzzzzzzzzc_);
            bool? qzzzzzzzzzze_ = context.Operators.Not((bool?)(qzzzzzzzzzzd_ is null));
            Code<ObservationStatus> qzzzzzzzzzzf_ = MacularExam?.StatusElement;
            ObservationStatus? qzzzzzzzzzzg_ = qzzzzzzzzzzf_?.Value;
            Code<ObservationStatus> qzzzzzzzzzzh_ = context.Operators.Convert<Code<ObservationStatus>>(qzzzzzzzzzzg_);
            string qzzzzzzzzzzi_ = context.Operators.Convert<string>(qzzzzzzzzzzh_);
            string[] qzzzzzzzzzzj_ = [
                "final",
                "amended",
                "corrected",
                "preliminary",
            ];
            bool? qzzzzzzzzzzk_ = context.Operators.In<string>(qzzzzzzzzzzi_, qzzzzzzzzzzj_ as IEnumerable<string>);
            bool? qzzzzzzzzzzl_ = context.Operators.And(qzzzzzzzzzze_, qzzzzzzzzzzk_);

            return qzzzzzzzzzzl_;
        };
        IEnumerable<Observation> pzzzzzzzzzzq_ = context.Operators.Where<Observation>(pzzzzzzzzzzo_, pzzzzzzzzzzp_);

        return pzzzzzzzzzzq_;
    }


    [CqlExpressionDefinition(
        definitionName: "Denominator")]
    public bool? Denominator(CqlContext context)
    {
        bool? qzzzzzzzzzzm_ = this.Initial_Population(context);
        IEnumerable<Observation> qzzzzzzzzzzn_ = this.Macular_Exam_Performed(context);
        bool? qzzzzzzzzzzo_ = context.Operators.Exists<Observation>(qzzzzzzzzzzn_);
        bool? qzzzzzzzzzzp_ = context.Operators.And(qzzzzzzzzzzm_, qzzzzzzzzzzo_);

        return qzzzzzzzzzzp_;
    }


    [CqlExpressionDefinition(
        definitionName: "Level of Severity of Retinopathy Findings Communicated")]
    public IEnumerable<Communication> Level_of_Severity_of_Retinopathy_Findings_Communicated(CqlContext context)
    {
        PropertyInfo qzzzzzzzzzzq_ = typeof(Communication).GetProperty("ReasonCode");
        CqlValueSet qzzzzzzzzzzr_ = this.Level_of_Severity_of_Retinopathy_Findings(context);
        IEnumerable<Communication> qzzzzzzzzzzs_ = context.Operators.Retrieve<Communication>(new RetrieveParameters(qzzzzzzzzzzq_, qzzzzzzzzzzr_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-communication"));
        IEnumerable<Communication> qzzzzzzzzzzt_(Communication LevelOfSeverityCommunicated)
        {
            IEnumerable<Encounter> qzzzzzzzzzzx_ = this.Diabetic_Retinopathy_Encounter(context);
            bool? qzzzzzzzzzzy_(Encounter EncounterDiabeticRetinopathy)
            {
                FhirDateTime rzzzzzzzzzzc_ = LevelOfSeverityCommunicated?.SentElement;
                CqlDateTime rzzzzzzzzzzd_ = context.Operators.Convert<CqlDateTime>(rzzzzzzzzzzc_);
                Period rzzzzzzzzzze_ = EncounterDiabeticRetinopathy?.Period;
                CqlInterval<CqlDateTime> rzzzzzzzzzzf_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, rzzzzzzzzzze_);
                CqlDateTime rzzzzzzzzzzg_ = context.Operators.Start(rzzzzzzzzzzf_);
                bool? rzzzzzzzzzzh_ = context.Operators.After(rzzzzzzzzzzd_, rzzzzzzzzzzg_, default);
                CqlDateTime rzzzzzzzzzzj_ = context.Operators.Convert<CqlDateTime>(rzzzzzzzzzzc_);
                CqlInterval<CqlDateTime> rzzzzzzzzzzk_ = this.Measurement_Period(context);
                bool? rzzzzzzzzzzl_ = context.Operators.In<CqlDateTime>(rzzzzzzzzzzj_, rzzzzzzzzzzk_, "day");
                bool? rzzzzzzzzzzm_ = context.Operators.And(rzzzzzzzzzzh_, rzzzzzzzzzzl_);

                return rzzzzzzzzzzm_;
            };
            IEnumerable<Encounter> qzzzzzzzzzzz_ = context.Operators.Where<Encounter>(qzzzzzzzzzzx_, qzzzzzzzzzzy_);
            Communication rzzzzzzzzzza_(Encounter EncounterDiabeticRetinopathy) =>
                LevelOfSeverityCommunicated;
            IEnumerable<Communication> rzzzzzzzzzzb_ = context.Operators.Select<Encounter, Communication>(qzzzzzzzzzzz_, rzzzzzzzzzza_);

            return rzzzzzzzzzzb_;
        };
        IEnumerable<Communication> qzzzzzzzzzzu_ = context.Operators.SelectMany<Communication, Communication>(qzzzzzzzzzzs_, qzzzzzzzzzzt_);
        bool? qzzzzzzzzzzv_(Communication LevelOfSeverityCommunicated)
        {
            Code<EventStatus> rzzzzzzzzzzn_ = LevelOfSeverityCommunicated?.StatusElement;
            EventStatus? rzzzzzzzzzzo_ = rzzzzzzzzzzn_?.Value;
            Code<EventStatus> rzzzzzzzzzzp_ = context.Operators.Convert<Code<EventStatus>>(rzzzzzzzzzzo_);
            bool? rzzzzzzzzzzq_ = context.Operators.Equal(rzzzzzzzzzzp_, "completed");

            return rzzzzzzzzzzq_;
        };
        IEnumerable<Communication> qzzzzzzzzzzw_ = context.Operators.Where<Communication>(qzzzzzzzzzzu_, qzzzzzzzzzzv_);

        return qzzzzzzzzzzw_;
    }


    [CqlExpressionDefinition(
        definitionName: "Macular Edema Absence Communicated")]
    public IEnumerable<Communication> Macular_Edema_Absence_Communicated(CqlContext context)
    {
        PropertyInfo rzzzzzzzzzzr_ = typeof(Communication).GetProperty("ReasonCode");
        CqlValueSet rzzzzzzzzzzs_ = this.Macular_edema_absent__situation_(context);
        IEnumerable<Communication> rzzzzzzzzzzt_ = context.Operators.Retrieve<Communication>(new RetrieveParameters(rzzzzzzzzzzr_, rzzzzzzzzzzs_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-communication"));
        IEnumerable<Communication> rzzzzzzzzzzu_(Communication MacularEdemaAbsentCommunicated)
        {
            IEnumerable<Encounter> rzzzzzzzzzzy_ = this.Diabetic_Retinopathy_Encounter(context);
            bool? rzzzzzzzzzzz_(Encounter EncounterDiabeticRetinopathy)
            {
                FhirDateTime szzzzzzzzzzd_ = MacularEdemaAbsentCommunicated?.SentElement;
                CqlDateTime szzzzzzzzzze_ = context.Operators.Convert<CqlDateTime>(szzzzzzzzzzd_);
                Period szzzzzzzzzzf_ = EncounterDiabeticRetinopathy?.Period;
                CqlInterval<CqlDateTime> szzzzzzzzzzg_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, szzzzzzzzzzf_);
                CqlDateTime szzzzzzzzzzh_ = context.Operators.Start(szzzzzzzzzzg_);
                bool? szzzzzzzzzzi_ = context.Operators.After(szzzzzzzzzze_, szzzzzzzzzzh_, default);
                CqlDateTime szzzzzzzzzzk_ = context.Operators.Convert<CqlDateTime>(szzzzzzzzzzd_);
                CqlInterval<CqlDateTime> szzzzzzzzzzl_ = this.Measurement_Period(context);
                bool? szzzzzzzzzzm_ = context.Operators.In<CqlDateTime>(szzzzzzzzzzk_, szzzzzzzzzzl_, "day");
                bool? szzzzzzzzzzn_ = context.Operators.And(szzzzzzzzzzi_, szzzzzzzzzzm_);

                return szzzzzzzzzzn_;
            };
            IEnumerable<Encounter> szzzzzzzzzza_ = context.Operators.Where<Encounter>(rzzzzzzzzzzy_, rzzzzzzzzzzz_);
            Communication szzzzzzzzzzb_(Encounter EncounterDiabeticRetinopathy) =>
                MacularEdemaAbsentCommunicated;
            IEnumerable<Communication> szzzzzzzzzzc_ = context.Operators.Select<Encounter, Communication>(szzzzzzzzzza_, szzzzzzzzzzb_);

            return szzzzzzzzzzc_;
        };
        IEnumerable<Communication> rzzzzzzzzzzv_ = context.Operators.SelectMany<Communication, Communication>(rzzzzzzzzzzt_, rzzzzzzzzzzu_);
        bool? rzzzzzzzzzzw_(Communication MacularEdemaAbsentCommunicated)
        {
            Code<EventStatus> szzzzzzzzzzo_ = MacularEdemaAbsentCommunicated?.StatusElement;
            EventStatus? szzzzzzzzzzp_ = szzzzzzzzzzo_?.Value;
            Code<EventStatus> szzzzzzzzzzq_ = context.Operators.Convert<Code<EventStatus>>(szzzzzzzzzzp_);
            bool? szzzzzzzzzzr_ = context.Operators.Equal(szzzzzzzzzzq_, "completed");

            return szzzzzzzzzzr_;
        };
        IEnumerable<Communication> rzzzzzzzzzzx_ = context.Operators.Where<Communication>(rzzzzzzzzzzv_, rzzzzzzzzzzw_);

        return rzzzzzzzzzzx_;
    }


    [CqlExpressionDefinition(
        definitionName: "Macular Edema Presence Communicated")]
    public IEnumerable<Communication> Macular_Edema_Presence_Communicated(CqlContext context)
    {
        PropertyInfo szzzzzzzzzzs_ = typeof(Communication).GetProperty("ReasonCode");
        CqlValueSet szzzzzzzzzzt_ = this.Macular_Edema_Findings_Present(context);
        IEnumerable<Communication> szzzzzzzzzzu_ = context.Operators.Retrieve<Communication>(new RetrieveParameters(szzzzzzzzzzs_, szzzzzzzzzzt_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-communication"));
        IEnumerable<Communication> szzzzzzzzzzv_(Communication MacularEdemaPresentCommunicated)
        {
            IEnumerable<Encounter> szzzzzzzzzzz_ = this.Diabetic_Retinopathy_Encounter(context);
            bool? tzzzzzzzzzza_(Encounter EncounterDiabeticRetinopathy)
            {
                FhirDateTime tzzzzzzzzzze_ = MacularEdemaPresentCommunicated?.SentElement;
                CqlDateTime tzzzzzzzzzzf_ = context.Operators.Convert<CqlDateTime>(tzzzzzzzzzze_);
                Period tzzzzzzzzzzg_ = EncounterDiabeticRetinopathy?.Period;
                CqlInterval<CqlDateTime> tzzzzzzzzzzh_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, tzzzzzzzzzzg_);
                CqlDateTime tzzzzzzzzzzi_ = context.Operators.Start(tzzzzzzzzzzh_);
                bool? tzzzzzzzzzzj_ = context.Operators.After(tzzzzzzzzzzf_, tzzzzzzzzzzi_, default);
                CqlDateTime tzzzzzzzzzzl_ = context.Operators.Convert<CqlDateTime>(tzzzzzzzzzze_);
                CqlInterval<CqlDateTime> tzzzzzzzzzzm_ = this.Measurement_Period(context);
                bool? tzzzzzzzzzzn_ = context.Operators.In<CqlDateTime>(tzzzzzzzzzzl_, tzzzzzzzzzzm_, "day");
                bool? tzzzzzzzzzzo_ = context.Operators.And(tzzzzzzzzzzj_, tzzzzzzzzzzn_);

                return tzzzzzzzzzzo_;
            };
            IEnumerable<Encounter> tzzzzzzzzzzb_ = context.Operators.Where<Encounter>(szzzzzzzzzzz_, tzzzzzzzzzza_);
            Communication tzzzzzzzzzzc_(Encounter EncounterDiabeticRetinopathy) =>
                MacularEdemaPresentCommunicated;
            IEnumerable<Communication> tzzzzzzzzzzd_ = context.Operators.Select<Encounter, Communication>(tzzzzzzzzzzb_, tzzzzzzzzzzc_);

            return tzzzzzzzzzzd_;
        };
        IEnumerable<Communication> szzzzzzzzzzw_ = context.Operators.SelectMany<Communication, Communication>(szzzzzzzzzzu_, szzzzzzzzzzv_);
        bool? szzzzzzzzzzx_(Communication MacularEdemaPresentCommunicated)
        {
            Code<EventStatus> tzzzzzzzzzzp_ = MacularEdemaPresentCommunicated?.StatusElement;
            EventStatus? tzzzzzzzzzzq_ = tzzzzzzzzzzp_?.Value;
            Code<EventStatus> tzzzzzzzzzzr_ = context.Operators.Convert<Code<EventStatus>>(tzzzzzzzzzzq_);
            bool? tzzzzzzzzzzs_ = context.Operators.Equal(tzzzzzzzzzzr_, "completed");

            return tzzzzzzzzzzs_;
        };
        IEnumerable<Communication> szzzzzzzzzzy_ = context.Operators.Where<Communication>(szzzzzzzzzzw_, szzzzzzzzzzx_);

        return szzzzzzzzzzy_;
    }


    [CqlExpressionDefinition(
        definitionName: "Numerator")]
    public bool? Numerator(CqlContext context)
    {
        IEnumerable<Communication> tzzzzzzzzzzt_ = this.Level_of_Severity_of_Retinopathy_Findings_Communicated(context);
        bool? tzzzzzzzzzzu_ = context.Operators.Exists<Communication>(tzzzzzzzzzzt_);
        IEnumerable<Communication> tzzzzzzzzzzv_ = this.Macular_Edema_Absence_Communicated(context);
        bool? tzzzzzzzzzzw_ = context.Operators.Exists<Communication>(tzzzzzzzzzzv_);
        IEnumerable<Communication> tzzzzzzzzzzx_ = this.Macular_Edema_Presence_Communicated(context);
        bool? tzzzzzzzzzzy_ = context.Operators.Exists<Communication>(tzzzzzzzzzzx_);
        bool? tzzzzzzzzzzz_ = context.Operators.Or(tzzzzzzzzzzw_, tzzzzzzzzzzy_);
        bool? uzzzzzzzzzza_ = context.Operators.And(tzzzzzzzzzzu_, tzzzzzzzzzzz_);

        return uzzzzzzzzzza_;
    }


    [CqlExpressionDefinition(
        definitionName: "Medical or Patient Reason for Not Communicating Level of Severity of Retinopathy")]
    public IEnumerable<Communication> Medical_or_Patient_Reason_for_Not_Communicating_Level_of_Severity_of_Retinopathy(CqlContext context)
    {
        PropertyInfo uzzzzzzzzzzb_ = typeof(Communication).GetProperty("ReasonCode");
        CqlValueSet uzzzzzzzzzzc_ = this.Level_of_Severity_of_Retinopathy_Findings(context);
        IEnumerable<Communication> uzzzzzzzzzzd_ = context.Operators.Retrieve<Communication>(new RetrieveParameters(uzzzzzzzzzzb_, uzzzzzzzzzzc_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-communicationnotdone"));
        IEnumerable<Communication> uzzzzzzzzzzg_ = context.Operators.Retrieve<Communication>(new RetrieveParameters(uzzzzzzzzzzb_, uzzzzzzzzzzc_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-communicationnotdone"));
        IEnumerable<Communication> uzzzzzzzzzzh_ = context.Operators.Union<Communication>(uzzzzzzzzzzd_, uzzzzzzzzzzg_);
        IEnumerable<Communication> uzzzzzzzzzzi_(Communication LevelOfSeverityNotCommunicated)
        {
            IEnumerable<Encounter> uzzzzzzzzzzm_ = this.Diabetic_Retinopathy_Encounter(context);
            bool? uzzzzzzzzzzn_(Encounter EncounterDiabeticRetinopathy)
            {
                FhirDateTime uzzzzzzzzzzr_ = LevelOfSeverityNotCommunicated?.SentElement;
                CqlDateTime uzzzzzzzzzzs_ = context.Operators.Convert<CqlDateTime>(uzzzzzzzzzzr_);
                Period uzzzzzzzzzzt_ = EncounterDiabeticRetinopathy?.Period;
                CqlInterval<CqlDateTime> uzzzzzzzzzzu_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, uzzzzzzzzzzt_);
                bool? uzzzzzzzzzzv_ = context.Operators.In<CqlDateTime>(uzzzzzzzzzzs_, uzzzzzzzzzzu_, default);

                return uzzzzzzzzzzv_;
            };
            IEnumerable<Encounter> uzzzzzzzzzzo_ = context.Operators.Where<Encounter>(uzzzzzzzzzzm_, uzzzzzzzzzzn_);
            Communication uzzzzzzzzzzp_(Encounter EncounterDiabeticRetinopathy) =>
                LevelOfSeverityNotCommunicated;
            IEnumerable<Communication> uzzzzzzzzzzq_ = context.Operators.Select<Encounter, Communication>(uzzzzzzzzzzo_, uzzzzzzzzzzp_);

            return uzzzzzzzzzzq_;
        };
        IEnumerable<Communication> uzzzzzzzzzzj_ = context.Operators.SelectMany<Communication, Communication>(uzzzzzzzzzzh_, uzzzzzzzzzzi_);
        bool? uzzzzzzzzzzk_(Communication LevelOfSeverityNotCommunicated)
        {
            CodeableConcept uzzzzzzzzzzw_ = LevelOfSeverityNotCommunicated?.StatusReason;
            CqlConcept uzzzzzzzzzzx_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, uzzzzzzzzzzw_);
            CqlValueSet uzzzzzzzzzzy_ = this.Medical_Reason(context);
            bool? uzzzzzzzzzzz_ = context.Operators.ConceptInValueSet(uzzzzzzzzzzx_, uzzzzzzzzzzy_);
            CqlConcept vzzzzzzzzzzb_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, uzzzzzzzzzzw_);
            CqlValueSet vzzzzzzzzzzc_ = this.Patient_Reason(context);
            bool? vzzzzzzzzzzd_ = context.Operators.ConceptInValueSet(vzzzzzzzzzzb_, vzzzzzzzzzzc_);
            bool? vzzzzzzzzzze_ = context.Operators.Or(uzzzzzzzzzzz_, vzzzzzzzzzzd_);

            return vzzzzzzzzzze_;
        };
        IEnumerable<Communication> uzzzzzzzzzzl_ = context.Operators.Where<Communication>(uzzzzzzzzzzj_, uzzzzzzzzzzk_);

        return uzzzzzzzzzzl_;
    }


    [CqlExpressionDefinition(
        definitionName: "Medical or Patient Reason for Not Communicating Absence of Macular Edema")]
    public IEnumerable<Communication> Medical_or_Patient_Reason_for_Not_Communicating_Absence_of_Macular_Edema(CqlContext context)
    {
        PropertyInfo vzzzzzzzzzzf_ = typeof(Communication).GetProperty("ReasonCode");
        CqlValueSet vzzzzzzzzzzg_ = this.Macular_edema_absent__situation_(context);
        IEnumerable<Communication> vzzzzzzzzzzh_ = context.Operators.Retrieve<Communication>(new RetrieveParameters(vzzzzzzzzzzf_, vzzzzzzzzzzg_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-communicationnotdone"));
        IEnumerable<Communication> vzzzzzzzzzzk_ = context.Operators.Retrieve<Communication>(new RetrieveParameters(vzzzzzzzzzzf_, vzzzzzzzzzzg_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-communicationnotdone"));
        IEnumerable<Communication> vzzzzzzzzzzl_ = context.Operators.Union<Communication>(vzzzzzzzzzzh_, vzzzzzzzzzzk_);
        IEnumerable<Communication> vzzzzzzzzzzm_(Communication MacularEdemaAbsentNotCommunicated)
        {
            IEnumerable<Encounter> vzzzzzzzzzzq_ = this.Diabetic_Retinopathy_Encounter(context);
            bool? vzzzzzzzzzzr_(Encounter EncounterDiabeticRetinopathy)
            {
                FhirDateTime vzzzzzzzzzzv_ = MacularEdemaAbsentNotCommunicated?.SentElement;
                CqlDateTime vzzzzzzzzzzw_ = context.Operators.Convert<CqlDateTime>(vzzzzzzzzzzv_);
                Period vzzzzzzzzzzx_ = EncounterDiabeticRetinopathy?.Period;
                CqlInterval<CqlDateTime> vzzzzzzzzzzy_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, vzzzzzzzzzzx_);
                bool? vzzzzzzzzzzz_ = context.Operators.In<CqlDateTime>(vzzzzzzzzzzw_, vzzzzzzzzzzy_, default);

                return vzzzzzzzzzzz_;
            };
            IEnumerable<Encounter> vzzzzzzzzzzs_ = context.Operators.Where<Encounter>(vzzzzzzzzzzq_, vzzzzzzzzzzr_);
            Communication vzzzzzzzzzzt_(Encounter EncounterDiabeticRetinopathy) =>
                MacularEdemaAbsentNotCommunicated;
            IEnumerable<Communication> vzzzzzzzzzzu_ = context.Operators.Select<Encounter, Communication>(vzzzzzzzzzzs_, vzzzzzzzzzzt_);

            return vzzzzzzzzzzu_;
        };
        IEnumerable<Communication> vzzzzzzzzzzn_ = context.Operators.SelectMany<Communication, Communication>(vzzzzzzzzzzl_, vzzzzzzzzzzm_);
        bool? vzzzzzzzzzzo_(Communication MacularEdemaAbsentNotCommunicated)
        {
            CodeableConcept wzzzzzzzzzza_ = MacularEdemaAbsentNotCommunicated?.StatusReason;
            CqlConcept wzzzzzzzzzzb_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, wzzzzzzzzzza_);
            CqlValueSet wzzzzzzzzzzc_ = this.Medical_Reason(context);
            bool? wzzzzzzzzzzd_ = context.Operators.ConceptInValueSet(wzzzzzzzzzzb_, wzzzzzzzzzzc_);
            CqlConcept wzzzzzzzzzzf_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, wzzzzzzzzzza_);
            CqlValueSet wzzzzzzzzzzg_ = this.Patient_Reason(context);
            bool? wzzzzzzzzzzh_ = context.Operators.ConceptInValueSet(wzzzzzzzzzzf_, wzzzzzzzzzzg_);
            bool? wzzzzzzzzzzi_ = context.Operators.Or(wzzzzzzzzzzd_, wzzzzzzzzzzh_);

            return wzzzzzzzzzzi_;
        };
        IEnumerable<Communication> vzzzzzzzzzzp_ = context.Operators.Where<Communication>(vzzzzzzzzzzn_, vzzzzzzzzzzo_);

        return vzzzzzzzzzzp_;
    }


    [CqlExpressionDefinition(
        definitionName: "Medical or Patient Reason for Not Communicating Presence of Macular Edema")]
    public IEnumerable<Communication> Medical_or_Patient_Reason_for_Not_Communicating_Presence_of_Macular_Edema(CqlContext context)
    {
        PropertyInfo wzzzzzzzzzzj_ = typeof(Communication).GetProperty("ReasonCode");
        CqlValueSet wzzzzzzzzzzk_ = this.Macular_Edema_Findings_Present(context);
        IEnumerable<Communication> wzzzzzzzzzzl_ = context.Operators.Retrieve<Communication>(new RetrieveParameters(wzzzzzzzzzzj_, wzzzzzzzzzzk_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-communicationnotdone"));
        IEnumerable<Communication> wzzzzzzzzzzo_ = context.Operators.Retrieve<Communication>(new RetrieveParameters(wzzzzzzzzzzj_, wzzzzzzzzzzk_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-communicationnotdone"));
        IEnumerable<Communication> wzzzzzzzzzzp_ = context.Operators.Union<Communication>(wzzzzzzzzzzl_, wzzzzzzzzzzo_);
        IEnumerable<Communication> wzzzzzzzzzzq_(Communication MacularEdemaPresentNotCommunicated)
        {
            IEnumerable<Encounter> wzzzzzzzzzzu_ = this.Diabetic_Retinopathy_Encounter(context);
            bool? wzzzzzzzzzzv_(Encounter EncounterDiabeticRetinopathy)
            {
                FhirDateTime wzzzzzzzzzzz_ = MacularEdemaPresentNotCommunicated?.SentElement;
                CqlDateTime xzzzzzzzzzza_ = context.Operators.Convert<CqlDateTime>(wzzzzzzzzzzz_);
                Period xzzzzzzzzzzb_ = EncounterDiabeticRetinopathy?.Period;
                CqlInterval<CqlDateTime> xzzzzzzzzzzc_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, xzzzzzzzzzzb_);
                bool? xzzzzzzzzzzd_ = context.Operators.In<CqlDateTime>(xzzzzzzzzzza_, xzzzzzzzzzzc_, default);

                return xzzzzzzzzzzd_;
            };
            IEnumerable<Encounter> wzzzzzzzzzzw_ = context.Operators.Where<Encounter>(wzzzzzzzzzzu_, wzzzzzzzzzzv_);
            Communication wzzzzzzzzzzx_(Encounter EncounterDiabeticRetinopathy) =>
                MacularEdemaPresentNotCommunicated;
            IEnumerable<Communication> wzzzzzzzzzzy_ = context.Operators.Select<Encounter, Communication>(wzzzzzzzzzzw_, wzzzzzzzzzzx_);

            return wzzzzzzzzzzy_;
        };
        IEnumerable<Communication> wzzzzzzzzzzr_ = context.Operators.SelectMany<Communication, Communication>(wzzzzzzzzzzp_, wzzzzzzzzzzq_);
        bool? wzzzzzzzzzzs_(Communication MacularEdemaPresentNotCommunicated)
        {
            CodeableConcept xzzzzzzzzzze_ = MacularEdemaPresentNotCommunicated?.StatusReason;
            CqlConcept xzzzzzzzzzzf_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, xzzzzzzzzzze_);
            CqlValueSet xzzzzzzzzzzg_ = this.Medical_Reason(context);
            bool? xzzzzzzzzzzh_ = context.Operators.ConceptInValueSet(xzzzzzzzzzzf_, xzzzzzzzzzzg_);
            CqlConcept xzzzzzzzzzzj_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, xzzzzzzzzzze_);
            CqlValueSet xzzzzzzzzzzk_ = this.Patient_Reason(context);
            bool? xzzzzzzzzzzl_ = context.Operators.ConceptInValueSet(xzzzzzzzzzzj_, xzzzzzzzzzzk_);
            bool? xzzzzzzzzzzm_ = context.Operators.Or(xzzzzzzzzzzh_, xzzzzzzzzzzl_);

            return xzzzzzzzzzzm_;
        };
        IEnumerable<Communication> wzzzzzzzzzzt_ = context.Operators.Where<Communication>(wzzzzzzzzzzr_, wzzzzzzzzzzs_);

        return wzzzzzzzzzzt_;
    }


    [CqlExpressionDefinition(
        definitionName: "Denominator Exceptions")]
    public bool? Denominator_Exceptions(CqlContext context)
    {
        IEnumerable<Communication> xzzzzzzzzzzn_ = this.Medical_or_Patient_Reason_for_Not_Communicating_Level_of_Severity_of_Retinopathy(context);
        bool? xzzzzzzzzzzo_ = context.Operators.Exists<Communication>(xzzzzzzzzzzn_);
        IEnumerable<Communication> xzzzzzzzzzzp_ = this.Medical_or_Patient_Reason_for_Not_Communicating_Absence_of_Macular_Edema(context);
        bool? xzzzzzzzzzzq_ = context.Operators.Exists<Communication>(xzzzzzzzzzzp_);
        bool? xzzzzzzzzzzr_ = context.Operators.Or(xzzzzzzzzzzo_, xzzzzzzzzzzq_);
        IEnumerable<Communication> xzzzzzzzzzzs_ = this.Medical_or_Patient_Reason_for_Not_Communicating_Presence_of_Macular_Edema(context);
        bool? xzzzzzzzzzzt_ = context.Operators.Exists<Communication>(xzzzzzzzzzzs_);
        bool? xzzzzzzzzzzu_ = context.Operators.Or(xzzzzzzzzzzr_, xzzzzzzzzzzt_);

        return xzzzzzzzzzzu_;
    }


    [CqlExpressionDefinition(
        definitionName: "Results of Dilated Macular or Fundus Exam Communicated")]
    public bool? Results_of_Dilated_Macular_or_Fundus_Exam_Communicated(CqlContext context)
    {
        IEnumerable<Communication> xzzzzzzzzzzv_ = this.Level_of_Severity_of_Retinopathy_Findings_Communicated(context);
        bool? xzzzzzzzzzzw_ = context.Operators.Exists<Communication>(xzzzzzzzzzzv_);
        IEnumerable<Communication> xzzzzzzzzzzx_ = this.Macular_Edema_Absence_Communicated(context);
        bool? xzzzzzzzzzzy_ = context.Operators.Exists<Communication>(xzzzzzzzzzzx_);
        IEnumerable<Communication> xzzzzzzzzzzz_ = this.Macular_Edema_Presence_Communicated(context);
        bool? yzzzzzzzzzza_ = context.Operators.Exists<Communication>(xzzzzzzzzzzz_);
        bool? yzzzzzzzzzzb_ = context.Operators.Or(xzzzzzzzzzzy_, yzzzzzzzzzza_);
        bool? yzzzzzzzzzzc_ = context.Operators.And(xzzzzzzzzzzw_, yzzzzzzzzzzb_);

        return yzzzzzzzzzzc_;
    }


    #endregion Expressions

}
