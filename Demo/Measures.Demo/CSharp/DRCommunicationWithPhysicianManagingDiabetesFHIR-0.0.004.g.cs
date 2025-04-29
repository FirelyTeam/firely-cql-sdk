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
[CqlLibrary("DRCommunicationWithPhysicianManagingDiabetesFHIR", "0.0.004")]
public partial class DRCommunicationWithPhysicianManagingDiabetesFHIR_0_0_004 : ILibrary, ISingleton<DRCommunicationWithPhysicianManagingDiabetesFHIR_0_0_004>
{
    private DRCommunicationWithPhysicianManagingDiabetesFHIR_0_0_004() {}

    public static DRCommunicationWithPhysicianManagingDiabetesFHIR_0_0_004 Instance { get; } = new();

    #region ILibrary Implementation

    public string Name => "DRCommunicationWithPhysicianManagingDiabetesFHIR";
    public string Version => "0.0.004";
    public ILibrary[] Dependencies => [FHIRHelpers_4_0_001.Instance, SupplementalDataElementsFHIR4_2_0_000.Instance, MATGlobalCommonFunctionsFHIR4_6_1_000.Instance];

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

    #endregion ValueSets

    #region Codes

    #region Code: Birth date
    [CqlCodeDefinition(
        definitionName: "Birth date",
        codeId: "21112-8",
        codeSystem: "http://loinc.org")]
    public CqlCode Birth_date(CqlContext context) => _Birth_date;

    private static readonly CqlCode _Birth_date = new CqlCode("21112-8", "http://loinc.org", default, default);
    #endregion

    #region Code: Healthcare professional (occupation)
    [CqlCodeDefinition(
        definitionName: "Healthcare professional (occupation)",
        codeId: "223366009",
        codeSystem: "http://snomed.info/sct")]
    public CqlCode Healthcare_professional__occupation_(CqlContext context) => _Healthcare_professional__occupation_;

    private static readonly CqlCode _Healthcare_professional__occupation_ = new CqlCode("223366009", "http://snomed.info/sct", default, default);
    #endregion

    #region Code: Macular edema absent (situation)
    [CqlCodeDefinition(
        definitionName: "Macular edema absent (situation)",
        codeId: "428341000124108",
        codeSystem: "http://snomed.info/sct")]
    public CqlCode Macular_edema_absent__situation_(CqlContext context) => _Macular_edema_absent__situation_;

    private static readonly CqlCode _Macular_edema_absent__situation_ = new CqlCode("428341000124108", "http://snomed.info/sct", default, default);
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

    #endregion Codes

    #region CodeSystems

    [CqlCodeSystemDefinition(
        definitionName: "LOINC")]
    public CqlCode[] LOINC(CqlContext context)
    {
        CqlCode[] kzzzzzzzzzzzzt_ = [
            new CqlCode("21112-8", "http://loinc.org", default, default),
        ];

        return kzzzzzzzzzzzzt_;
    }


    [CqlCodeSystemDefinition(
        definitionName: "SNOMEDCT")]
    public CqlCode[] SNOMEDCT(CqlContext context)
    {
        CqlCode[] kzzzzzzzzzzzzu_ = [
            new CqlCode("223366009", "http://snomed.info/sct", default, default),
            new CqlCode("428341000124108", "http://snomed.info/sct", default, default),
            new CqlCode("158965000", "http://snomed.info/sct", default, default),
            new CqlCode("422234006", "http://snomed.info/sct", default, default),
            new CqlCode("28229004", "http://snomed.info/sct", default, default),
            new CqlCode("309343006", "http://snomed.info/sct", default, default),
        ];

        return kzzzzzzzzzzzzu_;
    }


    #endregion CodeSystems

    #region Parameters

    [CqlParameterDefinition(
        definitionName: "Measurement Period")]
    public CqlInterval<CqlDateTime> Measurement_Period(CqlContext context)
    {
        object kzzzzzzzzzzzzv_ = context.ResolveParameter("DRCommunicationWithPhysicianManagingDiabetesFHIR-0.0.004", "Measurement Period", null);

        return (CqlInterval<CqlDateTime>)kzzzzzzzzzzzzv_;
    }


    #endregion Parameters

    #region Expressions

    [CqlExpressionDefinition(
        definitionName: "Patient")]
    public Patient Patient(CqlContext context)
    {
        IEnumerable<Patient> kzzzzzzzzzzzzw_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/StructureDefinition/Patient"));
        Patient kzzzzzzzzzzzzx_ = context.Operators.SingletonFrom<Patient>(kzzzzzzzzzzzzw_);

        return kzzzzzzzzzzzzx_;
    }


    [CqlExpressionDefinition(
        definitionName: "SDE Ethnicity")]
    public IEnumerable<Coding> SDE_Ethnicity(CqlContext context)
    {
        IEnumerable<Coding> kzzzzzzzzzzzzy_ = SupplementalDataElementsFHIR4_2_0_000.Instance.SDE_Ethnicity(context);

        return kzzzzzzzzzzzzy_;
    }


    [CqlExpressionDefinition(
        definitionName: "SDE Payer")]
    public IEnumerable<(CqlTupleMetadata, CodeableConcept code, Period period)?> SDE_Payer(CqlContext context)
    {
        IEnumerable<(CqlTupleMetadata, CodeableConcept code, Period period)?> kzzzzzzzzzzzzz_ = SupplementalDataElementsFHIR4_2_0_000.Instance.SDE_Payer(context);

        return kzzzzzzzzzzzzz_;
    }


    [CqlExpressionDefinition(
        definitionName: "SDE Race")]
    public IEnumerable<Coding> SDE_Race(CqlContext context)
    {
        IEnumerable<Coding> lzzzzzzzzzzzza_ = SupplementalDataElementsFHIR4_2_0_000.Instance.SDE_Race(context);

        return lzzzzzzzzzzzza_;
    }


    [CqlExpressionDefinition(
        definitionName: "SDE Sex")]
    public CqlCode SDE_Sex(CqlContext context)
    {
        CqlCode lzzzzzzzzzzzzb_ = SupplementalDataElementsFHIR4_2_0_000.Instance.SDE_Sex(context);

        return lzzzzzzzzzzzzb_;
    }


    [CqlExpressionDefinition(
        definitionName: "Qualifying Encounter During Measurement Period")]
    public IEnumerable<Encounter> Qualifying_Encounter_During_Measurement_Period(CqlContext context)
    {
        CqlValueSet lzzzzzzzzzzzzc_ = this.Office_Visit(context);
        IEnumerable<Encounter> lzzzzzzzzzzzzd_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, lzzzzzzzzzzzzc_, default, "http://hl7.org/fhir/StructureDefinition/Encounter"));
        CqlValueSet lzzzzzzzzzzzze_ = this.Ophthalmological_Services(context);
        IEnumerable<Encounter> lzzzzzzzzzzzzf_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, lzzzzzzzzzzzze_, default, "http://hl7.org/fhir/StructureDefinition/Encounter"));
        IEnumerable<Encounter> lzzzzzzzzzzzzg_ = context.Operators.Union<Encounter>(lzzzzzzzzzzzzd_, lzzzzzzzzzzzzf_);
        CqlValueSet lzzzzzzzzzzzzh_ = this.Outpatient_Consultation(context);
        IEnumerable<Encounter> lzzzzzzzzzzzzi_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, lzzzzzzzzzzzzh_, default, "http://hl7.org/fhir/StructureDefinition/Encounter"));
        CqlValueSet lzzzzzzzzzzzzj_ = this.Care_Services_in_Long_Term_Residential_Facility(context);
        IEnumerable<Encounter> lzzzzzzzzzzzzk_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, lzzzzzzzzzzzzj_, default, "http://hl7.org/fhir/StructureDefinition/Encounter"));
        IEnumerable<Encounter> lzzzzzzzzzzzzl_ = context.Operators.Union<Encounter>(lzzzzzzzzzzzzi_, lzzzzzzzzzzzzk_);
        IEnumerable<Encounter> lzzzzzzzzzzzzm_ = context.Operators.Union<Encounter>(lzzzzzzzzzzzzg_, lzzzzzzzzzzzzl_);
        CqlValueSet lzzzzzzzzzzzzn_ = this.Nursing_Facility_Visit(context);
        IEnumerable<Encounter> lzzzzzzzzzzzzo_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, lzzzzzzzzzzzzn_, default, "http://hl7.org/fhir/StructureDefinition/Encounter"));
        IEnumerable<Encounter> lzzzzzzzzzzzzp_ = context.Operators.Union<Encounter>(lzzzzzzzzzzzzm_, lzzzzzzzzzzzzo_);
        bool? lzzzzzzzzzzzzq_(Encounter QualifyingEncounter)
        {
            CqlInterval<CqlDateTime> lzzzzzzzzzzzzs_ = this.Measurement_Period(context);
            Period lzzzzzzzzzzzzt_ = QualifyingEncounter?.Period;
            CqlInterval<CqlDateTime> lzzzzzzzzzzzzu_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, lzzzzzzzzzzzzt_);
            bool? lzzzzzzzzzzzzv_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(lzzzzzzzzzzzzs_, lzzzzzzzzzzzzu_, default);
            Code<Encounter.EncounterStatus> lzzzzzzzzzzzzw_ = QualifyingEncounter?.StatusElement;
            string lzzzzzzzzzzzzx_ = FHIRHelpers_4_0_001.Instance.ToString(context, lzzzzzzzzzzzzw_);
            bool? lzzzzzzzzzzzzy_ = context.Operators.Equal(lzzzzzzzzzzzzx_, "finished");
            bool? lzzzzzzzzzzzzz_ = context.Operators.And(lzzzzzzzzzzzzv_, lzzzzzzzzzzzzy_);

            return lzzzzzzzzzzzzz_;
        };
        IEnumerable<Encounter> lzzzzzzzzzzzzr_ = context.Operators.Where<Encounter>(lzzzzzzzzzzzzp_, lzzzzzzzzzzzzq_);

        return lzzzzzzzzzzzzr_;
    }


    [CqlExpressionDefinition(
        definitionName: "Diabetic Retinopathy Encounter")]
    public IEnumerable<Encounter> Diabetic_Retinopathy_Encounter(CqlContext context)
    {
        IEnumerable<Encounter> mzzzzzzzzzzzza_ = this.Qualifying_Encounter_During_Measurement_Period(context);
        IEnumerable<Encounter> mzzzzzzzzzzzzb_(Encounter ValidQualifyingEncounter)
        {
            CqlValueSet mzzzzzzzzzzzzd_ = this.Diabetic_Retinopathy(context);
            IEnumerable<Condition> mzzzzzzzzzzzze_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, mzzzzzzzzzzzzd_, default, "http://hl7.org/fhir/StructureDefinition/Condition"));
            bool? mzzzzzzzzzzzzf_(Condition DiabeticRetinopathy)
            {
                CodeableConcept mzzzzzzzzzzzzj_ = DiabeticRetinopathy?.ClinicalStatus;
                CqlConcept mzzzzzzzzzzzzk_ = FHIRHelpers_4_0_001.Instance.ToConcept(context, mzzzzzzzzzzzzj_);
                CqlCode mzzzzzzzzzzzzl_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.active(context);
                CqlConcept mzzzzzzzzzzzzm_ = context.Operators.ConvertCodeToConcept(mzzzzzzzzzzzzl_);
                bool? mzzzzzzzzzzzzn_ = context.Operators.Equivalent(mzzzzzzzzzzzzk_, mzzzzzzzzzzzzm_);
                CqlInterval<CqlDateTime> mzzzzzzzzzzzzo_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Prevalence_Period(context, DiabeticRetinopathy);
                Period mzzzzzzzzzzzzp_ = ValidQualifyingEncounter?.Period;
                CqlInterval<CqlDateTime> mzzzzzzzzzzzzq_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, mzzzzzzzzzzzzp_);
                bool? mzzzzzzzzzzzzr_ = context.Operators.Overlaps(mzzzzzzzzzzzzo_, mzzzzzzzzzzzzq_, default);
                bool? mzzzzzzzzzzzzs_ = context.Operators.And(mzzzzzzzzzzzzn_, mzzzzzzzzzzzzr_);

                return mzzzzzzzzzzzzs_;
            };
            IEnumerable<Condition> mzzzzzzzzzzzzg_ = context.Operators.Where<Condition>(mzzzzzzzzzzzze_, mzzzzzzzzzzzzf_);
            Encounter mzzzzzzzzzzzzh_(Condition DiabeticRetinopathy) =>
                ValidQualifyingEncounter;
            IEnumerable<Encounter> mzzzzzzzzzzzzi_ = context.Operators.Select<Condition, Encounter>(mzzzzzzzzzzzzg_, mzzzzzzzzzzzzh_);

            return mzzzzzzzzzzzzi_;
        };
        IEnumerable<Encounter> mzzzzzzzzzzzzc_ = context.Operators.SelectMany<Encounter, Encounter>(mzzzzzzzzzzzza_, mzzzzzzzzzzzzb_);

        return mzzzzzzzzzzzzc_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public IEnumerable<Extension> GetModifierExtensions(CqlContext context, DomainResource domainResource, string url)
    {
        List<Extension> mzzzzzzzzzzzzt_ = domainResource?.ModifierExtension;
        bool? mzzzzzzzzzzzzu_(Extension E)
        {
            string mzzzzzzzzzzzzz_ = E?.Url;
            FhirUri nzzzzzzzzzzzza_ = context.Operators.Convert<FhirUri>(mzzzzzzzzzzzzz_);
            string nzzzzzzzzzzzzb_ = FHIRHelpers_4_0_001.Instance.ToString(context, nzzzzzzzzzzzza_);
            string nzzzzzzzzzzzzc_ = context.Operators.Concatenate("http://hl7.org/fhir/us/qicore/StructureDefinition/", url);
            bool? nzzzzzzzzzzzzd_ = context.Operators.Equal(nzzzzzzzzzzzzb_, nzzzzzzzzzzzzc_);

            return nzzzzzzzzzzzzd_;
        };
        IEnumerable<Extension> mzzzzzzzzzzzzv_ = context.Operators.Where<Extension>((IEnumerable<Extension>)mzzzzzzzzzzzzt_, mzzzzzzzzzzzzu_);
        Extension mzzzzzzzzzzzzw_(Extension E) =>
            E;
        IEnumerable<Extension> mzzzzzzzzzzzzx_ = context.Operators.Select<Extension, Extension>(mzzzzzzzzzzzzv_, mzzzzzzzzzzzzw_);
        IEnumerable<Extension> mzzzzzzzzzzzzy_ = context.Operators.Distinct<Extension>(mzzzzzzzzzzzzx_);

        return mzzzzzzzzzzzzy_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public Extension GetModifierExtension(CqlContext context, DomainResource domainResource, string url)
    {
        IEnumerable<Extension> nzzzzzzzzzzzze_ = this.GetModifierExtensions(context, domainResource, url);
        Extension nzzzzzzzzzzzzf_ = context.Operators.SingletonFrom<Extension>(nzzzzzzzzzzzze_);

        return nzzzzzzzzzzzzf_;
    }


    [CqlExpressionDefinition(
        definitionName: "Medical or Patient Reason for Not Communicating Level of Severity of Retinopathy")]
    public IEnumerable<Communication> Medical_or_Patient_Reason_for_Not_Communicating_Level_of_Severity_of_Retinopathy(CqlContext context)
    {
        PropertyInfo nzzzzzzzzzzzzg_ = typeof(Communication).GetProperty("ReasonCode");
        CqlValueSet nzzzzzzzzzzzzh_ = this.Level_of_Severity_of_Retinopathy_Findings(context);
        IEnumerable<Communication> nzzzzzzzzzzzzi_ = context.Operators.Retrieve<Communication>(new RetrieveParameters(nzzzzzzzzzzzzg_, nzzzzzzzzzzzzh_, default, "http://hl7.org/fhir/StructureDefinition/Communication"));
        IEnumerable<Communication> nzzzzzzzzzzzzj_(Communication LevelOfSeverityNotCommunicated)
        {
            IEnumerable<Encounter> nzzzzzzzzzzzzn_ = this.Diabetic_Retinopathy_Encounter(context);
            bool? nzzzzzzzzzzzzo_(Encounter EncounterDiabeticRetinopathy)
            {
                Period nzzzzzzzzzzzzs_ = EncounterDiabeticRetinopathy?.Period;
                CqlInterval<CqlDateTime> nzzzzzzzzzzzzt_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, nzzzzzzzzzzzzs_);
                Extension nzzzzzzzzzzzzu_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.GetExtension(context, LevelOfSeverityNotCommunicated, "qicore-recorded");
                DataType nzzzzzzzzzzzzv_ = nzzzzzzzzzzzzu_?.Value;
                CqlInterval<CqlDateTime> nzzzzzzzzzzzzw_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, nzzzzzzzzzzzzv_ as Period);
                bool? nzzzzzzzzzzzzx_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(nzzzzzzzzzzzzt_, nzzzzzzzzzzzzw_, default);

                return nzzzzzzzzzzzzx_;
            };
            IEnumerable<Encounter> nzzzzzzzzzzzzp_ = context.Operators.Where<Encounter>(nzzzzzzzzzzzzn_, nzzzzzzzzzzzzo_);
            Communication nzzzzzzzzzzzzq_(Encounter EncounterDiabeticRetinopathy) =>
                LevelOfSeverityNotCommunicated;
            IEnumerable<Communication> nzzzzzzzzzzzzr_ = context.Operators.Select<Encounter, Communication>(nzzzzzzzzzzzzp_, nzzzzzzzzzzzzq_);

            return nzzzzzzzzzzzzr_;
        };
        IEnumerable<Communication> nzzzzzzzzzzzzk_ = context.Operators.SelectMany<Communication, Communication>(nzzzzzzzzzzzzi_, nzzzzzzzzzzzzj_);
        bool? nzzzzzzzzzzzzl_(Communication LevelOfSeverityNotCommunicated)
        {
            Code<EventStatus> nzzzzzzzzzzzzy_ = LevelOfSeverityNotCommunicated?.StatusElement;
            string nzzzzzzzzzzzzz_ = FHIRHelpers_4_0_001.Instance.ToString(context, nzzzzzzzzzzzzy_);
            bool? ozzzzzzzzzzzza_ = context.Operators.Equal(nzzzzzzzzzzzzz_, "not-done");
            Extension ozzzzzzzzzzzzb_ = this.GetModifierExtension(context, LevelOfSeverityNotCommunicated, "qicore-notDone");
            DataType ozzzzzzzzzzzzc_ = ozzzzzzzzzzzzb_?.Value;
            bool? ozzzzzzzzzzzzd_ = FHIRHelpers_4_0_001.Instance.ToBoolean(context, ozzzzzzzzzzzzc_ as FhirBoolean);
            bool? ozzzzzzzzzzzze_ = context.Operators.IsTrue(ozzzzzzzzzzzzd_);
            bool? ozzzzzzzzzzzzf_ = context.Operators.And(ozzzzzzzzzzzza_, ozzzzzzzzzzzze_);
            CodeableConcept ozzzzzzzzzzzzg_ = LevelOfSeverityNotCommunicated?.StatusReason;
            CqlConcept ozzzzzzzzzzzzh_ = FHIRHelpers_4_0_001.Instance.ToConcept(context, ozzzzzzzzzzzzg_);
            CqlValueSet ozzzzzzzzzzzzi_ = this.Medical_Reason(context);
            bool? ozzzzzzzzzzzzj_ = context.Operators.ConceptInValueSet(ozzzzzzzzzzzzh_, ozzzzzzzzzzzzi_);
            CqlConcept ozzzzzzzzzzzzl_ = FHIRHelpers_4_0_001.Instance.ToConcept(context, ozzzzzzzzzzzzg_);
            CqlValueSet ozzzzzzzzzzzzm_ = this.Patient_Reason(context);
            bool? ozzzzzzzzzzzzn_ = context.Operators.ConceptInValueSet(ozzzzzzzzzzzzl_, ozzzzzzzzzzzzm_);
            bool? ozzzzzzzzzzzzo_ = context.Operators.Or(ozzzzzzzzzzzzj_, ozzzzzzzzzzzzn_);
            bool? ozzzzzzzzzzzzp_ = context.Operators.And(ozzzzzzzzzzzzf_, ozzzzzzzzzzzzo_);

            return ozzzzzzzzzzzzp_;
        };
        IEnumerable<Communication> nzzzzzzzzzzzzm_ = context.Operators.Where<Communication>(nzzzzzzzzzzzzk_, nzzzzzzzzzzzzl_);

        return nzzzzzzzzzzzzm_;
    }


    [CqlExpressionDefinition(
        definitionName: "Medical or Patient Reason for Not Communicating Absence of Macular Edema")]
    public IEnumerable<Communication> Medical_or_Patient_Reason_for_Not_Communicating_Absence_of_Macular_Edema(CqlContext context)
    {
        PropertyInfo ozzzzzzzzzzzzq_ = typeof(Communication).GetProperty("ReasonCode");
        CqlCode ozzzzzzzzzzzzr_ = this.Macular_edema_absent__situation_(context);
        IEnumerable<CqlCode> ozzzzzzzzzzzzs_ = context.Operators.ToList<CqlCode>(ozzzzzzzzzzzzr_);
        IEnumerable<Communication> ozzzzzzzzzzzzt_ = context.Operators.Retrieve<Communication>(new RetrieveParameters(ozzzzzzzzzzzzq_, default, ozzzzzzzzzzzzs_, "http://hl7.org/fhir/StructureDefinition/Communication"));
        IEnumerable<Communication> ozzzzzzzzzzzzu_(Communication MacularEdemaAbsentNotCommunicated)
        {
            IEnumerable<Encounter> ozzzzzzzzzzzzy_ = this.Diabetic_Retinopathy_Encounter(context);
            bool? ozzzzzzzzzzzzz_(Encounter EncounterDiabeticRetinopathy)
            {
                Period pzzzzzzzzzzzzd_ = EncounterDiabeticRetinopathy?.Period;
                CqlInterval<CqlDateTime> pzzzzzzzzzzzze_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, pzzzzzzzzzzzzd_);
                Extension pzzzzzzzzzzzzf_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.GetExtension(context, MacularEdemaAbsentNotCommunicated, "qicore-recorded");
                DataType pzzzzzzzzzzzzg_ = pzzzzzzzzzzzzf_?.Value;
                CqlInterval<CqlDateTime> pzzzzzzzzzzzzh_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, pzzzzzzzzzzzzg_ as Period);
                bool? pzzzzzzzzzzzzi_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(pzzzzzzzzzzzze_, pzzzzzzzzzzzzh_, default);

                return pzzzzzzzzzzzzi_;
            };
            IEnumerable<Encounter> pzzzzzzzzzzzza_ = context.Operators.Where<Encounter>(ozzzzzzzzzzzzy_, ozzzzzzzzzzzzz_);
            Communication pzzzzzzzzzzzzb_(Encounter EncounterDiabeticRetinopathy) =>
                MacularEdemaAbsentNotCommunicated;
            IEnumerable<Communication> pzzzzzzzzzzzzc_ = context.Operators.Select<Encounter, Communication>(pzzzzzzzzzzzza_, pzzzzzzzzzzzzb_);

            return pzzzzzzzzzzzzc_;
        };
        IEnumerable<Communication> ozzzzzzzzzzzzv_ = context.Operators.SelectMany<Communication, Communication>(ozzzzzzzzzzzzt_, ozzzzzzzzzzzzu_);
        bool? ozzzzzzzzzzzzw_(Communication MacularEdemaAbsentNotCommunicated)
        {
            Code<EventStatus> pzzzzzzzzzzzzj_ = MacularEdemaAbsentNotCommunicated?.StatusElement;
            string pzzzzzzzzzzzzk_ = FHIRHelpers_4_0_001.Instance.ToString(context, pzzzzzzzzzzzzj_);
            bool? pzzzzzzzzzzzzl_ = context.Operators.Equal(pzzzzzzzzzzzzk_, "not-done");
            Extension pzzzzzzzzzzzzm_ = this.GetModifierExtension(context, MacularEdemaAbsentNotCommunicated, "qicore-notDone");
            DataType pzzzzzzzzzzzzn_ = pzzzzzzzzzzzzm_?.Value;
            bool? pzzzzzzzzzzzzo_ = FHIRHelpers_4_0_001.Instance.ToBoolean(context, pzzzzzzzzzzzzn_ as FhirBoolean);
            bool? pzzzzzzzzzzzzp_ = context.Operators.IsTrue(pzzzzzzzzzzzzo_);
            bool? pzzzzzzzzzzzzq_ = context.Operators.And(pzzzzzzzzzzzzl_, pzzzzzzzzzzzzp_);
            CodeableConcept pzzzzzzzzzzzzr_ = MacularEdemaAbsentNotCommunicated?.StatusReason;
            CqlConcept pzzzzzzzzzzzzs_ = FHIRHelpers_4_0_001.Instance.ToConcept(context, pzzzzzzzzzzzzr_);
            CqlValueSet pzzzzzzzzzzzzt_ = this.Medical_Reason(context);
            bool? pzzzzzzzzzzzzu_ = context.Operators.ConceptInValueSet(pzzzzzzzzzzzzs_, pzzzzzzzzzzzzt_);
            CqlConcept pzzzzzzzzzzzzw_ = FHIRHelpers_4_0_001.Instance.ToConcept(context, pzzzzzzzzzzzzr_);
            CqlValueSet pzzzzzzzzzzzzx_ = this.Patient_Reason(context);
            bool? pzzzzzzzzzzzzy_ = context.Operators.ConceptInValueSet(pzzzzzzzzzzzzw_, pzzzzzzzzzzzzx_);
            bool? pzzzzzzzzzzzzz_ = context.Operators.Or(pzzzzzzzzzzzzu_, pzzzzzzzzzzzzy_);
            bool? qzzzzzzzzzzzza_ = context.Operators.And(pzzzzzzzzzzzzq_, pzzzzzzzzzzzzz_);

            return qzzzzzzzzzzzza_;
        };
        IEnumerable<Communication> ozzzzzzzzzzzzx_ = context.Operators.Where<Communication>(ozzzzzzzzzzzzv_, ozzzzzzzzzzzzw_);

        return ozzzzzzzzzzzzx_;
    }


    [CqlExpressionDefinition(
        definitionName: "Medical or Patient Reason for Not Communicating Presence of Macular Edema")]
    public IEnumerable<Communication> Medical_or_Patient_Reason_for_Not_Communicating_Presence_of_Macular_Edema(CqlContext context)
    {
        PropertyInfo qzzzzzzzzzzzzb_ = typeof(Communication).GetProperty("ReasonCode");
        CqlValueSet qzzzzzzzzzzzzc_ = this.Macular_Edema_Findings_Present(context);
        IEnumerable<Communication> qzzzzzzzzzzzzd_ = context.Operators.Retrieve<Communication>(new RetrieveParameters(qzzzzzzzzzzzzb_, qzzzzzzzzzzzzc_, default, "http://hl7.org/fhir/StructureDefinition/Communication"));
        IEnumerable<Communication> qzzzzzzzzzzzze_(Communication MacularEdemaPresentNotCommunicated)
        {
            IEnumerable<Encounter> qzzzzzzzzzzzzi_ = this.Diabetic_Retinopathy_Encounter(context);
            bool? qzzzzzzzzzzzzj_(Encounter EncounterDiabeticRetinopathy)
            {
                Period qzzzzzzzzzzzzn_ = EncounterDiabeticRetinopathy?.Period;
                CqlInterval<CqlDateTime> qzzzzzzzzzzzzo_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, qzzzzzzzzzzzzn_);
                Extension qzzzzzzzzzzzzp_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.GetExtension(context, MacularEdemaPresentNotCommunicated, "qicore-recorded");
                DataType qzzzzzzzzzzzzq_ = qzzzzzzzzzzzzp_?.Value;
                CqlInterval<CqlDateTime> qzzzzzzzzzzzzr_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, qzzzzzzzzzzzzq_ as Period);
                bool? qzzzzzzzzzzzzs_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(qzzzzzzzzzzzzo_, qzzzzzzzzzzzzr_, default);

                return qzzzzzzzzzzzzs_;
            };
            IEnumerable<Encounter> qzzzzzzzzzzzzk_ = context.Operators.Where<Encounter>(qzzzzzzzzzzzzi_, qzzzzzzzzzzzzj_);
            Communication qzzzzzzzzzzzzl_(Encounter EncounterDiabeticRetinopathy) =>
                MacularEdemaPresentNotCommunicated;
            IEnumerable<Communication> qzzzzzzzzzzzzm_ = context.Operators.Select<Encounter, Communication>(qzzzzzzzzzzzzk_, qzzzzzzzzzzzzl_);

            return qzzzzzzzzzzzzm_;
        };
        IEnumerable<Communication> qzzzzzzzzzzzzf_ = context.Operators.SelectMany<Communication, Communication>(qzzzzzzzzzzzzd_, qzzzzzzzzzzzze_);
        bool? qzzzzzzzzzzzzg_(Communication MacularEdemaPresentNotCommunicated)
        {
            Code<EventStatus> qzzzzzzzzzzzzt_ = MacularEdemaPresentNotCommunicated?.StatusElement;
            string qzzzzzzzzzzzzu_ = FHIRHelpers_4_0_001.Instance.ToString(context, qzzzzzzzzzzzzt_);
            bool? qzzzzzzzzzzzzv_ = context.Operators.Equal(qzzzzzzzzzzzzu_, "not-done");
            Extension qzzzzzzzzzzzzw_ = this.GetModifierExtension(context, MacularEdemaPresentNotCommunicated, "qicore-notDone");
            DataType qzzzzzzzzzzzzx_ = qzzzzzzzzzzzzw_?.Value;
            bool? qzzzzzzzzzzzzy_ = FHIRHelpers_4_0_001.Instance.ToBoolean(context, qzzzzzzzzzzzzx_ as FhirBoolean);
            bool? qzzzzzzzzzzzzz_ = context.Operators.IsTrue(qzzzzzzzzzzzzy_);
            bool? rzzzzzzzzzzzza_ = context.Operators.And(qzzzzzzzzzzzzv_, qzzzzzzzzzzzzz_);
            CodeableConcept rzzzzzzzzzzzzb_ = MacularEdemaPresentNotCommunicated?.StatusReason;
            CqlConcept rzzzzzzzzzzzzc_ = FHIRHelpers_4_0_001.Instance.ToConcept(context, rzzzzzzzzzzzzb_);
            CqlValueSet rzzzzzzzzzzzzd_ = this.Medical_Reason(context);
            bool? rzzzzzzzzzzzze_ = context.Operators.ConceptInValueSet(rzzzzzzzzzzzzc_, rzzzzzzzzzzzzd_);
            CqlConcept rzzzzzzzzzzzzg_ = FHIRHelpers_4_0_001.Instance.ToConcept(context, rzzzzzzzzzzzzb_);
            CqlValueSet rzzzzzzzzzzzzh_ = this.Patient_Reason(context);
            bool? rzzzzzzzzzzzzi_ = context.Operators.ConceptInValueSet(rzzzzzzzzzzzzg_, rzzzzzzzzzzzzh_);
            bool? rzzzzzzzzzzzzj_ = context.Operators.Or(rzzzzzzzzzzzze_, rzzzzzzzzzzzzi_);
            bool? rzzzzzzzzzzzzk_ = context.Operators.And(rzzzzzzzzzzzza_, rzzzzzzzzzzzzj_);

            return rzzzzzzzzzzzzk_;
        };
        IEnumerable<Communication> qzzzzzzzzzzzzh_ = context.Operators.Where<Communication>(qzzzzzzzzzzzzf_, qzzzzzzzzzzzzg_);

        return qzzzzzzzzzzzzh_;
    }


    [CqlExpressionDefinition(
        definitionName: "Denominator Exceptions")]
    public bool? Denominator_Exceptions(CqlContext context)
    {
        IEnumerable<Communication> rzzzzzzzzzzzzl_ = this.Medical_or_Patient_Reason_for_Not_Communicating_Level_of_Severity_of_Retinopathy(context);
        bool? rzzzzzzzzzzzzm_ = context.Operators.Exists<Communication>(rzzzzzzzzzzzzl_);
        IEnumerable<Communication> rzzzzzzzzzzzzn_ = this.Medical_or_Patient_Reason_for_Not_Communicating_Absence_of_Macular_Edema(context);
        bool? rzzzzzzzzzzzzo_ = context.Operators.Exists<Communication>(rzzzzzzzzzzzzn_);
        bool? rzzzzzzzzzzzzp_ = context.Operators.Or(rzzzzzzzzzzzzm_, rzzzzzzzzzzzzo_);
        IEnumerable<Communication> rzzzzzzzzzzzzq_ = this.Medical_or_Patient_Reason_for_Not_Communicating_Presence_of_Macular_Edema(context);
        bool? rzzzzzzzzzzzzr_ = context.Operators.Exists<Communication>(rzzzzzzzzzzzzq_);
        bool? rzzzzzzzzzzzzs_ = context.Operators.Or(rzzzzzzzzzzzzp_, rzzzzzzzzzzzzr_);

        return rzzzzzzzzzzzzs_;
    }


    [CqlExpressionDefinition(
        definitionName: "Initial Population")]
    public bool? Initial_Population(CqlContext context)
    {
        Patient rzzzzzzzzzzzzt_ = this.Patient(context);
        Date rzzzzzzzzzzzzu_ = rzzzzzzzzzzzzt_?.BirthDateElement;
        string rzzzzzzzzzzzzv_ = rzzzzzzzzzzzzu_?.Value;
        CqlDateTime rzzzzzzzzzzzzw_ = context.Operators.ConvertStringToDateTime(rzzzzzzzzzzzzv_);
        CqlInterval<CqlDateTime> rzzzzzzzzzzzzx_ = this.Measurement_Period(context);
        CqlDateTime rzzzzzzzzzzzzy_ = context.Operators.Start(rzzzzzzzzzzzzx_);
        int? rzzzzzzzzzzzzz_ = context.Operators.CalculateAgeAt(rzzzzzzzzzzzzw_, rzzzzzzzzzzzzy_, "year");
        bool? szzzzzzzzzzzza_ = context.Operators.GreaterOrEqual(rzzzzzzzzzzzzz_, 18);
        IEnumerable<Encounter> szzzzzzzzzzzzb_ = this.Diabetic_Retinopathy_Encounter(context);
        bool? szzzzzzzzzzzzc_ = context.Operators.Exists<Encounter>(szzzzzzzzzzzzb_);
        bool? szzzzzzzzzzzzd_ = context.Operators.And(szzzzzzzzzzzza_, szzzzzzzzzzzzc_);

        return szzzzzzzzzzzzd_;
    }


    [CqlExpressionDefinition(
        definitionName: "Macular Exam Performed")]
    public IEnumerable<Observation> Macular_Exam_Performed(CqlContext context)
    {
        CqlValueSet szzzzzzzzzzzze_ = this.Macular_Exam(context);
        IEnumerable<Observation> szzzzzzzzzzzzf_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, szzzzzzzzzzzze_, default, "http://hl7.org/fhir/StructureDefinition/Observation"));
        IEnumerable<Observation> szzzzzzzzzzzzg_(Observation MacularExam)
        {
            IEnumerable<Encounter> szzzzzzzzzzzzk_ = this.Diabetic_Retinopathy_Encounter(context);
            bool? szzzzzzzzzzzzl_(Encounter EncounterDiabeticRetinopathy)
            {
                Period szzzzzzzzzzzzp_ = EncounterDiabeticRetinopathy?.Period;
                CqlInterval<CqlDateTime> szzzzzzzzzzzzq_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, szzzzzzzzzzzzp_);
                DataType szzzzzzzzzzzzr_ = MacularExam?.Effective;
                CqlInterval<CqlDateTime> szzzzzzzzzzzzs_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, szzzzzzzzzzzzr_);
                bool? szzzzzzzzzzzzt_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(szzzzzzzzzzzzq_, szzzzzzzzzzzzs_, default);

                return szzzzzzzzzzzzt_;
            };
            IEnumerable<Encounter> szzzzzzzzzzzzm_ = context.Operators.Where<Encounter>(szzzzzzzzzzzzk_, szzzzzzzzzzzzl_);
            Observation szzzzzzzzzzzzn_(Encounter EncounterDiabeticRetinopathy) =>
                MacularExam;
            IEnumerable<Observation> szzzzzzzzzzzzo_ = context.Operators.Select<Encounter, Observation>(szzzzzzzzzzzzm_, szzzzzzzzzzzzn_);

            return szzzzzzzzzzzzo_;
        };
        IEnumerable<Observation> szzzzzzzzzzzzh_ = context.Operators.SelectMany<Observation, Observation>(szzzzzzzzzzzzf_, szzzzzzzzzzzzg_);
        bool? szzzzzzzzzzzzi_(Observation MacularExam)
        {
            Code<ObservationStatus> szzzzzzzzzzzzu_ = MacularExam?.StatusElement;
            string szzzzzzzzzzzzv_ = FHIRHelpers_4_0_001.Instance.ToString(context, szzzzzzzzzzzzu_);
            string[] szzzzzzzzzzzzw_ = [
                "final",
                "amended",
                "corrected",
            ];
            bool? szzzzzzzzzzzzx_ = context.Operators.In<string>(szzzzzzzzzzzzv_, szzzzzzzzzzzzw_ as IEnumerable<string>);
            DataType szzzzzzzzzzzzy_ = MacularExam?.Value;
            bool? szzzzzzzzzzzzz_ = context.Operators.Not((bool?)(szzzzzzzzzzzzy_ is null));
            bool? tzzzzzzzzzzzza_ = context.Operators.And(szzzzzzzzzzzzx_, szzzzzzzzzzzzz_);

            return tzzzzzzzzzzzza_;
        };
        IEnumerable<Observation> szzzzzzzzzzzzj_ = context.Operators.Where<Observation>(szzzzzzzzzzzzh_, szzzzzzzzzzzzi_);

        return szzzzzzzzzzzzj_;
    }


    [CqlExpressionDefinition(
        definitionName: "Denominator")]
    public bool? Denominator(CqlContext context)
    {
        bool? tzzzzzzzzzzzzb_ = this.Initial_Population(context);
        IEnumerable<Observation> tzzzzzzzzzzzzc_ = this.Macular_Exam_Performed(context);
        bool? tzzzzzzzzzzzzd_ = context.Operators.Exists<Observation>(tzzzzzzzzzzzzc_);
        bool? tzzzzzzzzzzzze_ = context.Operators.And(tzzzzzzzzzzzzb_, tzzzzzzzzzzzzd_);

        return tzzzzzzzzzzzze_;
    }


    [CqlExpressionDefinition(
        definitionName: "Level of Severity of Retinopathy Findings Communicated")]
    public IEnumerable<Communication> Level_of_Severity_of_Retinopathy_Findings_Communicated(CqlContext context)
    {
        PropertyInfo tzzzzzzzzzzzzf_ = typeof(Communication).GetProperty("ReasonCode");
        CqlValueSet tzzzzzzzzzzzzg_ = this.Level_of_Severity_of_Retinopathy_Findings(context);
        IEnumerable<Communication> tzzzzzzzzzzzzh_ = context.Operators.Retrieve<Communication>(new RetrieveParameters(tzzzzzzzzzzzzf_, tzzzzzzzzzzzzg_, default, "http://hl7.org/fhir/StructureDefinition/Communication"));
        IEnumerable<Communication> tzzzzzzzzzzzzi_(Communication LevelOfSeverityCommunicated)
        {
            IEnumerable<Encounter> tzzzzzzzzzzzzm_ = this.Diabetic_Retinopathy_Encounter(context);
            bool? tzzzzzzzzzzzzn_(Encounter EncounterDiabeticRetinopathy)
            {
                FhirDateTime tzzzzzzzzzzzzr_ = LevelOfSeverityCommunicated?.SentElement;
                CqlDateTime tzzzzzzzzzzzzs_ = FHIRHelpers_4_0_001.Instance.ToDateTime(context, tzzzzzzzzzzzzr_);
                Period tzzzzzzzzzzzzt_ = EncounterDiabeticRetinopathy?.Period;
                CqlInterval<CqlDateTime> tzzzzzzzzzzzzu_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, tzzzzzzzzzzzzt_);
                CqlDateTime tzzzzzzzzzzzzv_ = context.Operators.Start(tzzzzzzzzzzzzu_);
                bool? tzzzzzzzzzzzzw_ = context.Operators.After(tzzzzzzzzzzzzs_, tzzzzzzzzzzzzv_, default);

                return tzzzzzzzzzzzzw_;
            };
            IEnumerable<Encounter> tzzzzzzzzzzzzo_ = context.Operators.Where<Encounter>(tzzzzzzzzzzzzm_, tzzzzzzzzzzzzn_);
            Communication tzzzzzzzzzzzzp_(Encounter EncounterDiabeticRetinopathy) =>
                LevelOfSeverityCommunicated;
            IEnumerable<Communication> tzzzzzzzzzzzzq_ = context.Operators.Select<Encounter, Communication>(tzzzzzzzzzzzzo_, tzzzzzzzzzzzzp_);

            return tzzzzzzzzzzzzq_;
        };
        IEnumerable<Communication> tzzzzzzzzzzzzj_ = context.Operators.SelectMany<Communication, Communication>(tzzzzzzzzzzzzh_, tzzzzzzzzzzzzi_);
        bool? tzzzzzzzzzzzzk_(Communication LevelOfSeverityCommunicated)
        {
            Code<EventStatus> tzzzzzzzzzzzzx_ = LevelOfSeverityCommunicated?.StatusElement;
            string tzzzzzzzzzzzzy_ = FHIRHelpers_4_0_001.Instance.ToString(context, tzzzzzzzzzzzzx_);
            bool? tzzzzzzzzzzzzz_ = context.Operators.Equal(tzzzzzzzzzzzzy_, "completed");

            return tzzzzzzzzzzzzz_;
        };
        IEnumerable<Communication> tzzzzzzzzzzzzl_ = context.Operators.Where<Communication>(tzzzzzzzzzzzzj_, tzzzzzzzzzzzzk_);

        return tzzzzzzzzzzzzl_;
    }


    [CqlExpressionDefinition(
        definitionName: "Macular Edema Absence Communicated")]
    public IEnumerable<Communication> Macular_Edema_Absence_Communicated(CqlContext context)
    {
        PropertyInfo uzzzzzzzzzzzza_ = typeof(Communication).GetProperty("ReasonCode");
        CqlCode uzzzzzzzzzzzzb_ = this.Macular_edema_absent__situation_(context);
        IEnumerable<CqlCode> uzzzzzzzzzzzzc_ = context.Operators.ToList<CqlCode>(uzzzzzzzzzzzzb_);
        IEnumerable<Communication> uzzzzzzzzzzzzd_ = context.Operators.Retrieve<Communication>(new RetrieveParameters(uzzzzzzzzzzzza_, default, uzzzzzzzzzzzzc_, "http://hl7.org/fhir/StructureDefinition/Communication"));
        IEnumerable<Communication> uzzzzzzzzzzzze_(Communication MacularEdemaAbsentCommunicated)
        {
            IEnumerable<Encounter> uzzzzzzzzzzzzi_ = this.Diabetic_Retinopathy_Encounter(context);
            bool? uzzzzzzzzzzzzj_(Encounter EncounterDiabeticRetinopathy)
            {
                FhirDateTime uzzzzzzzzzzzzn_ = MacularEdemaAbsentCommunicated?.SentElement;
                CqlDateTime uzzzzzzzzzzzzo_ = FHIRHelpers_4_0_001.Instance.ToDateTime(context, uzzzzzzzzzzzzn_);
                Period uzzzzzzzzzzzzp_ = EncounterDiabeticRetinopathy?.Period;
                CqlInterval<CqlDateTime> uzzzzzzzzzzzzq_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, uzzzzzzzzzzzzp_);
                CqlDateTime uzzzzzzzzzzzzr_ = context.Operators.Start(uzzzzzzzzzzzzq_);
                bool? uzzzzzzzzzzzzs_ = context.Operators.After(uzzzzzzzzzzzzo_, uzzzzzzzzzzzzr_, default);

                return uzzzzzzzzzzzzs_;
            };
            IEnumerable<Encounter> uzzzzzzzzzzzzk_ = context.Operators.Where<Encounter>(uzzzzzzzzzzzzi_, uzzzzzzzzzzzzj_);
            Communication uzzzzzzzzzzzzl_(Encounter EncounterDiabeticRetinopathy) =>
                MacularEdemaAbsentCommunicated;
            IEnumerable<Communication> uzzzzzzzzzzzzm_ = context.Operators.Select<Encounter, Communication>(uzzzzzzzzzzzzk_, uzzzzzzzzzzzzl_);

            return uzzzzzzzzzzzzm_;
        };
        IEnumerable<Communication> uzzzzzzzzzzzzf_ = context.Operators.SelectMany<Communication, Communication>(uzzzzzzzzzzzzd_, uzzzzzzzzzzzze_);
        bool? uzzzzzzzzzzzzg_(Communication MacularEdemaAbsentCommunicated)
        {
            Code<EventStatus> uzzzzzzzzzzzzt_ = MacularEdemaAbsentCommunicated?.StatusElement;
            string uzzzzzzzzzzzzu_ = FHIRHelpers_4_0_001.Instance.ToString(context, uzzzzzzzzzzzzt_);
            bool? uzzzzzzzzzzzzv_ = context.Operators.Equal(uzzzzzzzzzzzzu_, "completed");

            return uzzzzzzzzzzzzv_;
        };
        IEnumerable<Communication> uzzzzzzzzzzzzh_ = context.Operators.Where<Communication>(uzzzzzzzzzzzzf_, uzzzzzzzzzzzzg_);

        return uzzzzzzzzzzzzh_;
    }


    [CqlExpressionDefinition(
        definitionName: "Macular Edema Presence Communicated")]
    public IEnumerable<Communication> Macular_Edema_Presence_Communicated(CqlContext context)
    {
        PropertyInfo uzzzzzzzzzzzzw_ = typeof(Communication).GetProperty("ReasonCode");
        CqlValueSet uzzzzzzzzzzzzx_ = this.Macular_Edema_Findings_Present(context);
        IEnumerable<Communication> uzzzzzzzzzzzzy_ = context.Operators.Retrieve<Communication>(new RetrieveParameters(uzzzzzzzzzzzzw_, uzzzzzzzzzzzzx_, default, "http://hl7.org/fhir/StructureDefinition/Communication"));
        IEnumerable<Communication> uzzzzzzzzzzzzz_(Communication MacularEdemaPresentCommunicated)
        {
            IEnumerable<Encounter> vzzzzzzzzzzzzd_ = this.Diabetic_Retinopathy_Encounter(context);
            bool? vzzzzzzzzzzzze_(Encounter EncounterDiabeticRetinopathy)
            {
                FhirDateTime vzzzzzzzzzzzzi_ = MacularEdemaPresentCommunicated?.SentElement;
                CqlDateTime vzzzzzzzzzzzzj_ = FHIRHelpers_4_0_001.Instance.ToDateTime(context, vzzzzzzzzzzzzi_);
                Period vzzzzzzzzzzzzk_ = EncounterDiabeticRetinopathy?.Period;
                CqlInterval<CqlDateTime> vzzzzzzzzzzzzl_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, vzzzzzzzzzzzzk_);
                CqlDateTime vzzzzzzzzzzzzm_ = context.Operators.Start(vzzzzzzzzzzzzl_);
                bool? vzzzzzzzzzzzzn_ = context.Operators.After(vzzzzzzzzzzzzj_, vzzzzzzzzzzzzm_, default);

                return vzzzzzzzzzzzzn_;
            };
            IEnumerable<Encounter> vzzzzzzzzzzzzf_ = context.Operators.Where<Encounter>(vzzzzzzzzzzzzd_, vzzzzzzzzzzzze_);
            Communication vzzzzzzzzzzzzg_(Encounter EncounterDiabeticRetinopathy) =>
                MacularEdemaPresentCommunicated;
            IEnumerable<Communication> vzzzzzzzzzzzzh_ = context.Operators.Select<Encounter, Communication>(vzzzzzzzzzzzzf_, vzzzzzzzzzzzzg_);

            return vzzzzzzzzzzzzh_;
        };
        IEnumerable<Communication> vzzzzzzzzzzzza_ = context.Operators.SelectMany<Communication, Communication>(uzzzzzzzzzzzzy_, uzzzzzzzzzzzzz_);
        bool? vzzzzzzzzzzzzb_(Communication MacularEdemaPresentCommunicated)
        {
            Code<EventStatus> vzzzzzzzzzzzzo_ = MacularEdemaPresentCommunicated?.StatusElement;
            string vzzzzzzzzzzzzp_ = FHIRHelpers_4_0_001.Instance.ToString(context, vzzzzzzzzzzzzo_);
            bool? vzzzzzzzzzzzzq_ = context.Operators.Equal(vzzzzzzzzzzzzp_, "completed");

            return vzzzzzzzzzzzzq_;
        };
        IEnumerable<Communication> vzzzzzzzzzzzzc_ = context.Operators.Where<Communication>(vzzzzzzzzzzzza_, vzzzzzzzzzzzzb_);

        return vzzzzzzzzzzzzc_;
    }


    [CqlExpressionDefinition(
        definitionName: "Results of Dilated Macular or Fundus Exam Communicated")]
    public bool? Results_of_Dilated_Macular_or_Fundus_Exam_Communicated(CqlContext context)
    {
        IEnumerable<Communication> vzzzzzzzzzzzzr_ = this.Level_of_Severity_of_Retinopathy_Findings_Communicated(context);
        bool? vzzzzzzzzzzzzs_ = context.Operators.Exists<Communication>(vzzzzzzzzzzzzr_);
        IEnumerable<Communication> vzzzzzzzzzzzzt_ = this.Macular_Edema_Absence_Communicated(context);
        bool? vzzzzzzzzzzzzu_ = context.Operators.Exists<Communication>(vzzzzzzzzzzzzt_);
        IEnumerable<Communication> vzzzzzzzzzzzzv_ = this.Macular_Edema_Presence_Communicated(context);
        bool? vzzzzzzzzzzzzw_ = context.Operators.Exists<Communication>(vzzzzzzzzzzzzv_);
        bool? vzzzzzzzzzzzzx_ = context.Operators.Or(vzzzzzzzzzzzzu_, vzzzzzzzzzzzzw_);
        bool? vzzzzzzzzzzzzy_ = context.Operators.And(vzzzzzzzzzzzzs_, vzzzzzzzzzzzzx_);

        return vzzzzzzzzzzzzy_;
    }


    [CqlExpressionDefinition(
        definitionName: "Numerator")]
    public bool? Numerator(CqlContext context)
    {
        IEnumerable<Communication> vzzzzzzzzzzzzz_ = this.Level_of_Severity_of_Retinopathy_Findings_Communicated(context);
        bool? wzzzzzzzzzzzza_ = context.Operators.Exists<Communication>(vzzzzzzzzzzzzz_);
        IEnumerable<Communication> wzzzzzzzzzzzzb_ = this.Macular_Edema_Absence_Communicated(context);
        bool? wzzzzzzzzzzzzc_ = context.Operators.Exists<Communication>(wzzzzzzzzzzzzb_);
        IEnumerable<Communication> wzzzzzzzzzzzzd_ = this.Macular_Edema_Presence_Communicated(context);
        bool? wzzzzzzzzzzzze_ = context.Operators.Exists<Communication>(wzzzzzzzzzzzzd_);
        bool? wzzzzzzzzzzzzf_ = context.Operators.Or(wzzzzzzzzzzzzc_, wzzzzzzzzzzzze_);
        bool? wzzzzzzzzzzzzg_ = context.Operators.And(wzzzzzzzzzzzza_, wzzzzzzzzzzzzf_);

        return wzzzzzzzzzzzzg_;
    }


    #endregion Expressions

}
