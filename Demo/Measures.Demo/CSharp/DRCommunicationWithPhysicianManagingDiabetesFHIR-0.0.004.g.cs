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

    #endregion ValueSets

    #region Codes

    [CqlCodeDefinition("Birth date", codeId: "21112-8", codeSystem: "http://loinc.org")]
    public CqlCode Birth_date(CqlContext _) => _Birth_date;
    private static readonly CqlCode _Birth_date = new CqlCode("21112-8", "http://loinc.org", default, default);

    [CqlCodeDefinition("Healthcare professional (occupation)", codeId: "223366009", codeSystem: "http://snomed.info/sct")]
    public CqlCode Healthcare_professional__occupation_(CqlContext _) => _Healthcare_professional__occupation_;
    private static readonly CqlCode _Healthcare_professional__occupation_ = new CqlCode("223366009", "http://snomed.info/sct", default, default);

    [CqlCodeDefinition("Macular edema absent (situation)", codeId: "428341000124108", codeSystem: "http://snomed.info/sct")]
    public CqlCode Macular_edema_absent__situation_(CqlContext _) => _Macular_edema_absent__situation_;
    private static readonly CqlCode _Macular_edema_absent__situation_ = new CqlCode("428341000124108", "http://snomed.info/sct", default, default);

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

    #endregion Codes

    #region CodeSystems

    [CqlCodeSystemDefinition("LOINC")]
    public CqlCodeSystem LOINC(CqlContext _) => _LOINC;
    private static readonly CqlCodeSystem _LOINC = new CqlCodeSystem();

    [CqlCodeSystemDefinition("SNOMEDCT")]
    public CqlCodeSystem SNOMEDCT(CqlContext _) => _SNOMEDCT;
    private static readonly CqlCodeSystem _SNOMEDCT = new CqlCodeSystem();

    #endregion CodeSystems

    #region Parameters

    [CqlParameterDefinition("Measurement Period")]
    public CqlInterval<CqlDateTime> Measurement_Period(CqlContext context)
    {
        object azzzzzzzzzzzzze_ = context.ResolveParameter("DRCommunicationWithPhysicianManagingDiabetesFHIR-0.0.004", "Measurement Period", null);

        return (CqlInterval<CqlDateTime>)azzzzzzzzzzzzze_;
    }


    #endregion Parameters

    #region Expressions

    [CqlExpressionDefinition("Patient")]
    public Patient Patient(CqlContext context)
    {
        IEnumerable<Patient> azzzzzzzzzzzzzf_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/StructureDefinition/Patient"));
        Patient azzzzzzzzzzzzzg_ = context.Operators.SingletonFrom<Patient>(azzzzzzzzzzzzzf_);

        return azzzzzzzzzzzzzg_;
    }


    [CqlExpressionDefinition("SDE Ethnicity")]
    public IEnumerable<Coding> SDE_Ethnicity(CqlContext context)
    {
        IEnumerable<Coding> azzzzzzzzzzzzzh_ = SupplementalDataElementsFHIR4_2_0_000.Instance.SDE_Ethnicity(context);

        return azzzzzzzzzzzzzh_;
    }


    [CqlExpressionDefinition("SDE Payer")]
    public IEnumerable<(CqlTupleMetadata, CodeableConcept code, Period period)?> SDE_Payer(CqlContext context)
    {
        IEnumerable<(CqlTupleMetadata, CodeableConcept code, Period period)?> azzzzzzzzzzzzzi_ = SupplementalDataElementsFHIR4_2_0_000.Instance.SDE_Payer(context);

        return azzzzzzzzzzzzzi_;
    }


    [CqlExpressionDefinition("SDE Race")]
    public IEnumerable<Coding> SDE_Race(CqlContext context)
    {
        IEnumerable<Coding> azzzzzzzzzzzzzj_ = SupplementalDataElementsFHIR4_2_0_000.Instance.SDE_Race(context);

        return azzzzzzzzzzzzzj_;
    }


    [CqlExpressionDefinition("SDE Sex")]
    public CqlCode SDE_Sex(CqlContext context)
    {
        CqlCode azzzzzzzzzzzzzk_ = SupplementalDataElementsFHIR4_2_0_000.Instance.SDE_Sex(context);

        return azzzzzzzzzzzzzk_;
    }


    [CqlExpressionDefinition("Qualifying Encounter During Measurement Period")]
    public IEnumerable<Encounter> Qualifying_Encounter_During_Measurement_Period(CqlContext context)
    {
        CqlValueSet azzzzzzzzzzzzzl_ = this.Office_Visit(context);
        IEnumerable<Encounter> azzzzzzzzzzzzzm_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, azzzzzzzzzzzzzl_, default, "http://hl7.org/fhir/StructureDefinition/Encounter"));
        CqlValueSet azzzzzzzzzzzzzn_ = this.Ophthalmological_Services(context);
        IEnumerable<Encounter> azzzzzzzzzzzzzo_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, azzzzzzzzzzzzzn_, default, "http://hl7.org/fhir/StructureDefinition/Encounter"));
        IEnumerable<Encounter> azzzzzzzzzzzzzp_ = context.Operators.Union<Encounter>(azzzzzzzzzzzzzm_, azzzzzzzzzzzzzo_);
        CqlValueSet azzzzzzzzzzzzzq_ = this.Outpatient_Consultation(context);
        IEnumerable<Encounter> azzzzzzzzzzzzzr_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, azzzzzzzzzzzzzq_, default, "http://hl7.org/fhir/StructureDefinition/Encounter"));
        CqlValueSet azzzzzzzzzzzzzs_ = this.Care_Services_in_Long_Term_Residential_Facility(context);
        IEnumerable<Encounter> azzzzzzzzzzzzzt_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, azzzzzzzzzzzzzs_, default, "http://hl7.org/fhir/StructureDefinition/Encounter"));
        IEnumerable<Encounter> azzzzzzzzzzzzzu_ = context.Operators.Union<Encounter>(azzzzzzzzzzzzzr_, azzzzzzzzzzzzzt_);
        IEnumerable<Encounter> azzzzzzzzzzzzzv_ = context.Operators.Union<Encounter>(azzzzzzzzzzzzzp_, azzzzzzzzzzzzzu_);
        CqlValueSet azzzzzzzzzzzzzw_ = this.Nursing_Facility_Visit(context);
        IEnumerable<Encounter> azzzzzzzzzzzzzx_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, azzzzzzzzzzzzzw_, default, "http://hl7.org/fhir/StructureDefinition/Encounter"));
        IEnumerable<Encounter> azzzzzzzzzzzzzy_ = context.Operators.Union<Encounter>(azzzzzzzzzzzzzv_, azzzzzzzzzzzzzx_);
        bool? azzzzzzzzzzzzzz_(Encounter QualifyingEncounter)
        {
            CqlInterval<CqlDateTime> bzzzzzzzzzzzzzb_ = this.Measurement_Period(context);
            Period bzzzzzzzzzzzzzc_ = QualifyingEncounter?.Period;
            CqlInterval<CqlDateTime> bzzzzzzzzzzzzzd_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, bzzzzzzzzzzzzzc_);
            bool? bzzzzzzzzzzzzze_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(bzzzzzzzzzzzzzb_, bzzzzzzzzzzzzzd_, default);
            Code<Encounter.EncounterStatus> bzzzzzzzzzzzzzf_ = QualifyingEncounter?.StatusElement;
            string bzzzzzzzzzzzzzg_ = FHIRHelpers_4_0_001.Instance.ToString(context, bzzzzzzzzzzzzzf_);
            bool? bzzzzzzzzzzzzzh_ = context.Operators.Equal(bzzzzzzzzzzzzzg_, "finished");
            bool? bzzzzzzzzzzzzzi_ = context.Operators.And(bzzzzzzzzzzzzze_, bzzzzzzzzzzzzzh_);

            return bzzzzzzzzzzzzzi_;
        };
        IEnumerable<Encounter> bzzzzzzzzzzzzza_ = context.Operators.Where<Encounter>(azzzzzzzzzzzzzy_, azzzzzzzzzzzzzz_);

        return bzzzzzzzzzzzzza_;
    }


    [CqlExpressionDefinition("Diabetic Retinopathy Encounter")]
    public IEnumerable<Encounter> Diabetic_Retinopathy_Encounter(CqlContext context)
    {
        IEnumerable<Encounter> bzzzzzzzzzzzzzj_ = this.Qualifying_Encounter_During_Measurement_Period(context);
        IEnumerable<Encounter> bzzzzzzzzzzzzzk_(Encounter ValidQualifyingEncounter)
        {
            CqlValueSet bzzzzzzzzzzzzzm_ = this.Diabetic_Retinopathy(context);
            IEnumerable<Condition> bzzzzzzzzzzzzzn_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, bzzzzzzzzzzzzzm_, default, "http://hl7.org/fhir/StructureDefinition/Condition"));
            bool? bzzzzzzzzzzzzzo_(Condition DiabeticRetinopathy)
            {
                CodeableConcept bzzzzzzzzzzzzzs_ = DiabeticRetinopathy?.ClinicalStatus;
                CqlConcept bzzzzzzzzzzzzzt_ = FHIRHelpers_4_0_001.Instance.ToConcept(context, bzzzzzzzzzzzzzs_);
                CqlCode bzzzzzzzzzzzzzu_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.active(context);
                CqlConcept bzzzzzzzzzzzzzv_ = context.Operators.ConvertCodeToConcept(bzzzzzzzzzzzzzu_);
                bool? bzzzzzzzzzzzzzw_ = context.Operators.Equivalent(bzzzzzzzzzzzzzt_, bzzzzzzzzzzzzzv_);
                CqlInterval<CqlDateTime> bzzzzzzzzzzzzzx_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Prevalence_Period(context, DiabeticRetinopathy);
                Period bzzzzzzzzzzzzzy_ = ValidQualifyingEncounter?.Period;
                CqlInterval<CqlDateTime> bzzzzzzzzzzzzzz_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, bzzzzzzzzzzzzzy_);
                bool? czzzzzzzzzzzzza_ = context.Operators.Overlaps(bzzzzzzzzzzzzzx_, bzzzzzzzzzzzzzz_, default);
                bool? czzzzzzzzzzzzzb_ = context.Operators.And(bzzzzzzzzzzzzzw_, czzzzzzzzzzzzza_);

                return czzzzzzzzzzzzzb_;
            };
            IEnumerable<Condition> bzzzzzzzzzzzzzp_ = context.Operators.Where<Condition>(bzzzzzzzzzzzzzn_, bzzzzzzzzzzzzzo_);
            Encounter bzzzzzzzzzzzzzq_(Condition DiabeticRetinopathy) =>
                ValidQualifyingEncounter;
            IEnumerable<Encounter> bzzzzzzzzzzzzzr_ = context.Operators.Select<Condition, Encounter>(bzzzzzzzzzzzzzp_, bzzzzzzzzzzzzzq_);

            return bzzzzzzzzzzzzzr_;
        };
        IEnumerable<Encounter> bzzzzzzzzzzzzzl_ = context.Operators.SelectMany<Encounter, Encounter>(bzzzzzzzzzzzzzj_, bzzzzzzzzzzzzzk_);

        return bzzzzzzzzzzzzzl_;
    }


    [CqlExpressionDefinition("GetModifierExtensions")]
    public IEnumerable<Extension> GetModifierExtensions(CqlContext context, DomainResource domainResource, string url)
    {
        List<Extension> czzzzzzzzzzzzzc_ = domainResource?.ModifierExtension;
        bool? czzzzzzzzzzzzzd_(Extension E)
        {
            string czzzzzzzzzzzzzi_ = E?.Url;
            FhirUri czzzzzzzzzzzzzj_ = context.Operators.Convert<FhirUri>(czzzzzzzzzzzzzi_);
            string czzzzzzzzzzzzzk_ = FHIRHelpers_4_0_001.Instance.ToString(context, czzzzzzzzzzzzzj_);
            string czzzzzzzzzzzzzl_ = context.Operators.Concatenate("http://hl7.org/fhir/us/qicore/StructureDefinition/", url);
            bool? czzzzzzzzzzzzzm_ = context.Operators.Equal(czzzzzzzzzzzzzk_, czzzzzzzzzzzzzl_);

            return czzzzzzzzzzzzzm_;
        };
        IEnumerable<Extension> czzzzzzzzzzzzze_ = context.Operators.Where<Extension>((IEnumerable<Extension>)czzzzzzzzzzzzzc_, czzzzzzzzzzzzzd_);
        Extension czzzzzzzzzzzzzf_(Extension E) =>
            E;
        IEnumerable<Extension> czzzzzzzzzzzzzg_ = context.Operators.Select<Extension, Extension>(czzzzzzzzzzzzze_, czzzzzzzzzzzzzf_);
        IEnumerable<Extension> czzzzzzzzzzzzzh_ = context.Operators.Distinct<Extension>(czzzzzzzzzzzzzg_);

        return czzzzzzzzzzzzzh_;
    }


    [CqlExpressionDefinition("GetModifierExtension")]
    public Extension GetModifierExtension(CqlContext context, DomainResource domainResource, string url)
    {
        IEnumerable<Extension> czzzzzzzzzzzzzn_ = this.GetModifierExtensions(context, domainResource, url);
        Extension czzzzzzzzzzzzzo_ = context.Operators.SingletonFrom<Extension>(czzzzzzzzzzzzzn_);

        return czzzzzzzzzzzzzo_;
    }


    [CqlExpressionDefinition("Medical or Patient Reason for Not Communicating Level of Severity of Retinopathy")]
    public IEnumerable<Communication> Medical_or_Patient_Reason_for_Not_Communicating_Level_of_Severity_of_Retinopathy(CqlContext context)
    {
        PropertyInfo czzzzzzzzzzzzzp_ = typeof(Communication).GetProperty("ReasonCode");
        CqlValueSet czzzzzzzzzzzzzq_ = this.Level_of_Severity_of_Retinopathy_Findings(context);
        IEnumerable<Communication> czzzzzzzzzzzzzr_ = context.Operators.Retrieve<Communication>(new RetrieveParameters(czzzzzzzzzzzzzp_, czzzzzzzzzzzzzq_, default, "http://hl7.org/fhir/StructureDefinition/Communication"));
        IEnumerable<Communication> czzzzzzzzzzzzzs_(Communication LevelOfSeverityNotCommunicated)
        {
            IEnumerable<Encounter> czzzzzzzzzzzzzw_ = this.Diabetic_Retinopathy_Encounter(context);
            bool? czzzzzzzzzzzzzx_(Encounter EncounterDiabeticRetinopathy)
            {
                Period dzzzzzzzzzzzzzb_ = EncounterDiabeticRetinopathy?.Period;
                CqlInterval<CqlDateTime> dzzzzzzzzzzzzzc_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, dzzzzzzzzzzzzzb_);
                Extension dzzzzzzzzzzzzzd_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.GetExtension(context, LevelOfSeverityNotCommunicated, "qicore-recorded");
                DataType dzzzzzzzzzzzzze_ = dzzzzzzzzzzzzzd_?.Value;
                CqlInterval<CqlDateTime> dzzzzzzzzzzzzzf_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, dzzzzzzzzzzzzze_ as Period);
                bool? dzzzzzzzzzzzzzg_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(dzzzzzzzzzzzzzc_, dzzzzzzzzzzzzzf_, default);

                return dzzzzzzzzzzzzzg_;
            };
            IEnumerable<Encounter> czzzzzzzzzzzzzy_ = context.Operators.Where<Encounter>(czzzzzzzzzzzzzw_, czzzzzzzzzzzzzx_);
            Communication czzzzzzzzzzzzzz_(Encounter EncounterDiabeticRetinopathy) =>
                LevelOfSeverityNotCommunicated;
            IEnumerable<Communication> dzzzzzzzzzzzzza_ = context.Operators.Select<Encounter, Communication>(czzzzzzzzzzzzzy_, czzzzzzzzzzzzzz_);

            return dzzzzzzzzzzzzza_;
        };
        IEnumerable<Communication> czzzzzzzzzzzzzt_ = context.Operators.SelectMany<Communication, Communication>(czzzzzzzzzzzzzr_, czzzzzzzzzzzzzs_);
        bool? czzzzzzzzzzzzzu_(Communication LevelOfSeverityNotCommunicated)
        {
            Code<EventStatus> dzzzzzzzzzzzzzh_ = LevelOfSeverityNotCommunicated?.StatusElement;
            string dzzzzzzzzzzzzzi_ = FHIRHelpers_4_0_001.Instance.ToString(context, dzzzzzzzzzzzzzh_);
            bool? dzzzzzzzzzzzzzj_ = context.Operators.Equal(dzzzzzzzzzzzzzi_, "not-done");
            Extension dzzzzzzzzzzzzzk_ = this.GetModifierExtension(context, LevelOfSeverityNotCommunicated, "qicore-notDone");
            DataType dzzzzzzzzzzzzzl_ = dzzzzzzzzzzzzzk_?.Value;
            bool? dzzzzzzzzzzzzzm_ = FHIRHelpers_4_0_001.Instance.ToBoolean(context, dzzzzzzzzzzzzzl_ as FhirBoolean);
            bool? dzzzzzzzzzzzzzn_ = context.Operators.IsTrue(dzzzzzzzzzzzzzm_);
            bool? dzzzzzzzzzzzzzo_ = context.Operators.And(dzzzzzzzzzzzzzj_, dzzzzzzzzzzzzzn_);
            CodeableConcept dzzzzzzzzzzzzzp_ = LevelOfSeverityNotCommunicated?.StatusReason;
            CqlConcept dzzzzzzzzzzzzzq_ = FHIRHelpers_4_0_001.Instance.ToConcept(context, dzzzzzzzzzzzzzp_);
            CqlValueSet dzzzzzzzzzzzzzr_ = this.Medical_Reason(context);
            bool? dzzzzzzzzzzzzzs_ = context.Operators.ConceptInValueSet(dzzzzzzzzzzzzzq_, dzzzzzzzzzzzzzr_);
            CqlConcept dzzzzzzzzzzzzzu_ = FHIRHelpers_4_0_001.Instance.ToConcept(context, dzzzzzzzzzzzzzp_);
            CqlValueSet dzzzzzzzzzzzzzv_ = this.Patient_Reason(context);
            bool? dzzzzzzzzzzzzzw_ = context.Operators.ConceptInValueSet(dzzzzzzzzzzzzzu_, dzzzzzzzzzzzzzv_);
            bool? dzzzzzzzzzzzzzx_ = context.Operators.Or(dzzzzzzzzzzzzzs_, dzzzzzzzzzzzzzw_);
            bool? dzzzzzzzzzzzzzy_ = context.Operators.And(dzzzzzzzzzzzzzo_, dzzzzzzzzzzzzzx_);

            return dzzzzzzzzzzzzzy_;
        };
        IEnumerable<Communication> czzzzzzzzzzzzzv_ = context.Operators.Where<Communication>(czzzzzzzzzzzzzt_, czzzzzzzzzzzzzu_);

        return czzzzzzzzzzzzzv_;
    }


    [CqlExpressionDefinition("Medical or Patient Reason for Not Communicating Absence of Macular Edema")]
    public IEnumerable<Communication> Medical_or_Patient_Reason_for_Not_Communicating_Absence_of_Macular_Edema(CqlContext context)
    {
        PropertyInfo dzzzzzzzzzzzzzz_ = typeof(Communication).GetProperty("ReasonCode");
        CqlCode ezzzzzzzzzzzzza_ = this.Macular_edema_absent__situation_(context);
        IEnumerable<CqlCode> ezzzzzzzzzzzzzb_ = context.Operators.ToList<CqlCode>(ezzzzzzzzzzzzza_);
        IEnumerable<Communication> ezzzzzzzzzzzzzc_ = context.Operators.Retrieve<Communication>(new RetrieveParameters(dzzzzzzzzzzzzzz_, default, ezzzzzzzzzzzzzb_, "http://hl7.org/fhir/StructureDefinition/Communication"));
        IEnumerable<Communication> ezzzzzzzzzzzzzd_(Communication MacularEdemaAbsentNotCommunicated)
        {
            IEnumerable<Encounter> ezzzzzzzzzzzzzh_ = this.Diabetic_Retinopathy_Encounter(context);
            bool? ezzzzzzzzzzzzzi_(Encounter EncounterDiabeticRetinopathy)
            {
                Period ezzzzzzzzzzzzzm_ = EncounterDiabeticRetinopathy?.Period;
                CqlInterval<CqlDateTime> ezzzzzzzzzzzzzn_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, ezzzzzzzzzzzzzm_);
                Extension ezzzzzzzzzzzzzo_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.GetExtension(context, MacularEdemaAbsentNotCommunicated, "qicore-recorded");
                DataType ezzzzzzzzzzzzzp_ = ezzzzzzzzzzzzzo_?.Value;
                CqlInterval<CqlDateTime> ezzzzzzzzzzzzzq_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, ezzzzzzzzzzzzzp_ as Period);
                bool? ezzzzzzzzzzzzzr_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(ezzzzzzzzzzzzzn_, ezzzzzzzzzzzzzq_, default);

                return ezzzzzzzzzzzzzr_;
            };
            IEnumerable<Encounter> ezzzzzzzzzzzzzj_ = context.Operators.Where<Encounter>(ezzzzzzzzzzzzzh_, ezzzzzzzzzzzzzi_);
            Communication ezzzzzzzzzzzzzk_(Encounter EncounterDiabeticRetinopathy) =>
                MacularEdemaAbsentNotCommunicated;
            IEnumerable<Communication> ezzzzzzzzzzzzzl_ = context.Operators.Select<Encounter, Communication>(ezzzzzzzzzzzzzj_, ezzzzzzzzzzzzzk_);

            return ezzzzzzzzzzzzzl_;
        };
        IEnumerable<Communication> ezzzzzzzzzzzzze_ = context.Operators.SelectMany<Communication, Communication>(ezzzzzzzzzzzzzc_, ezzzzzzzzzzzzzd_);
        bool? ezzzzzzzzzzzzzf_(Communication MacularEdemaAbsentNotCommunicated)
        {
            Code<EventStatus> ezzzzzzzzzzzzzs_ = MacularEdemaAbsentNotCommunicated?.StatusElement;
            string ezzzzzzzzzzzzzt_ = FHIRHelpers_4_0_001.Instance.ToString(context, ezzzzzzzzzzzzzs_);
            bool? ezzzzzzzzzzzzzu_ = context.Operators.Equal(ezzzzzzzzzzzzzt_, "not-done");
            Extension ezzzzzzzzzzzzzv_ = this.GetModifierExtension(context, MacularEdemaAbsentNotCommunicated, "qicore-notDone");
            DataType ezzzzzzzzzzzzzw_ = ezzzzzzzzzzzzzv_?.Value;
            bool? ezzzzzzzzzzzzzx_ = FHIRHelpers_4_0_001.Instance.ToBoolean(context, ezzzzzzzzzzzzzw_ as FhirBoolean);
            bool? ezzzzzzzzzzzzzy_ = context.Operators.IsTrue(ezzzzzzzzzzzzzx_);
            bool? ezzzzzzzzzzzzzz_ = context.Operators.And(ezzzzzzzzzzzzzu_, ezzzzzzzzzzzzzy_);
            CodeableConcept fzzzzzzzzzzzzza_ = MacularEdemaAbsentNotCommunicated?.StatusReason;
            CqlConcept fzzzzzzzzzzzzzb_ = FHIRHelpers_4_0_001.Instance.ToConcept(context, fzzzzzzzzzzzzza_);
            CqlValueSet fzzzzzzzzzzzzzc_ = this.Medical_Reason(context);
            bool? fzzzzzzzzzzzzzd_ = context.Operators.ConceptInValueSet(fzzzzzzzzzzzzzb_, fzzzzzzzzzzzzzc_);
            CqlConcept fzzzzzzzzzzzzzf_ = FHIRHelpers_4_0_001.Instance.ToConcept(context, fzzzzzzzzzzzzza_);
            CqlValueSet fzzzzzzzzzzzzzg_ = this.Patient_Reason(context);
            bool? fzzzzzzzzzzzzzh_ = context.Operators.ConceptInValueSet(fzzzzzzzzzzzzzf_, fzzzzzzzzzzzzzg_);
            bool? fzzzzzzzzzzzzzi_ = context.Operators.Or(fzzzzzzzzzzzzzd_, fzzzzzzzzzzzzzh_);
            bool? fzzzzzzzzzzzzzj_ = context.Operators.And(ezzzzzzzzzzzzzz_, fzzzzzzzzzzzzzi_);

            return fzzzzzzzzzzzzzj_;
        };
        IEnumerable<Communication> ezzzzzzzzzzzzzg_ = context.Operators.Where<Communication>(ezzzzzzzzzzzzze_, ezzzzzzzzzzzzzf_);

        return ezzzzzzzzzzzzzg_;
    }


    [CqlExpressionDefinition("Medical or Patient Reason for Not Communicating Presence of Macular Edema")]
    public IEnumerable<Communication> Medical_or_Patient_Reason_for_Not_Communicating_Presence_of_Macular_Edema(CqlContext context)
    {
        PropertyInfo fzzzzzzzzzzzzzk_ = typeof(Communication).GetProperty("ReasonCode");
        CqlValueSet fzzzzzzzzzzzzzl_ = this.Macular_Edema_Findings_Present(context);
        IEnumerable<Communication> fzzzzzzzzzzzzzm_ = context.Operators.Retrieve<Communication>(new RetrieveParameters(fzzzzzzzzzzzzzk_, fzzzzzzzzzzzzzl_, default, "http://hl7.org/fhir/StructureDefinition/Communication"));
        IEnumerable<Communication> fzzzzzzzzzzzzzn_(Communication MacularEdemaPresentNotCommunicated)
        {
            IEnumerable<Encounter> fzzzzzzzzzzzzzr_ = this.Diabetic_Retinopathy_Encounter(context);
            bool? fzzzzzzzzzzzzzs_(Encounter EncounterDiabeticRetinopathy)
            {
                Period fzzzzzzzzzzzzzw_ = EncounterDiabeticRetinopathy?.Period;
                CqlInterval<CqlDateTime> fzzzzzzzzzzzzzx_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, fzzzzzzzzzzzzzw_);
                Extension fzzzzzzzzzzzzzy_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.GetExtension(context, MacularEdemaPresentNotCommunicated, "qicore-recorded");
                DataType fzzzzzzzzzzzzzz_ = fzzzzzzzzzzzzzy_?.Value;
                CqlInterval<CqlDateTime> gzzzzzzzzzzzzza_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, fzzzzzzzzzzzzzz_ as Period);
                bool? gzzzzzzzzzzzzzb_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(fzzzzzzzzzzzzzx_, gzzzzzzzzzzzzza_, default);

                return gzzzzzzzzzzzzzb_;
            };
            IEnumerable<Encounter> fzzzzzzzzzzzzzt_ = context.Operators.Where<Encounter>(fzzzzzzzzzzzzzr_, fzzzzzzzzzzzzzs_);
            Communication fzzzzzzzzzzzzzu_(Encounter EncounterDiabeticRetinopathy) =>
                MacularEdemaPresentNotCommunicated;
            IEnumerable<Communication> fzzzzzzzzzzzzzv_ = context.Operators.Select<Encounter, Communication>(fzzzzzzzzzzzzzt_, fzzzzzzzzzzzzzu_);

            return fzzzzzzzzzzzzzv_;
        };
        IEnumerable<Communication> fzzzzzzzzzzzzzo_ = context.Operators.SelectMany<Communication, Communication>(fzzzzzzzzzzzzzm_, fzzzzzzzzzzzzzn_);
        bool? fzzzzzzzzzzzzzp_(Communication MacularEdemaPresentNotCommunicated)
        {
            Code<EventStatus> gzzzzzzzzzzzzzc_ = MacularEdemaPresentNotCommunicated?.StatusElement;
            string gzzzzzzzzzzzzzd_ = FHIRHelpers_4_0_001.Instance.ToString(context, gzzzzzzzzzzzzzc_);
            bool? gzzzzzzzzzzzzze_ = context.Operators.Equal(gzzzzzzzzzzzzzd_, "not-done");
            Extension gzzzzzzzzzzzzzf_ = this.GetModifierExtension(context, MacularEdemaPresentNotCommunicated, "qicore-notDone");
            DataType gzzzzzzzzzzzzzg_ = gzzzzzzzzzzzzzf_?.Value;
            bool? gzzzzzzzzzzzzzh_ = FHIRHelpers_4_0_001.Instance.ToBoolean(context, gzzzzzzzzzzzzzg_ as FhirBoolean);
            bool? gzzzzzzzzzzzzzi_ = context.Operators.IsTrue(gzzzzzzzzzzzzzh_);
            bool? gzzzzzzzzzzzzzj_ = context.Operators.And(gzzzzzzzzzzzzze_, gzzzzzzzzzzzzzi_);
            CodeableConcept gzzzzzzzzzzzzzk_ = MacularEdemaPresentNotCommunicated?.StatusReason;
            CqlConcept gzzzzzzzzzzzzzl_ = FHIRHelpers_4_0_001.Instance.ToConcept(context, gzzzzzzzzzzzzzk_);
            CqlValueSet gzzzzzzzzzzzzzm_ = this.Medical_Reason(context);
            bool? gzzzzzzzzzzzzzn_ = context.Operators.ConceptInValueSet(gzzzzzzzzzzzzzl_, gzzzzzzzzzzzzzm_);
            CqlConcept gzzzzzzzzzzzzzp_ = FHIRHelpers_4_0_001.Instance.ToConcept(context, gzzzzzzzzzzzzzk_);
            CqlValueSet gzzzzzzzzzzzzzq_ = this.Patient_Reason(context);
            bool? gzzzzzzzzzzzzzr_ = context.Operators.ConceptInValueSet(gzzzzzzzzzzzzzp_, gzzzzzzzzzzzzzq_);
            bool? gzzzzzzzzzzzzzs_ = context.Operators.Or(gzzzzzzzzzzzzzn_, gzzzzzzzzzzzzzr_);
            bool? gzzzzzzzzzzzzzt_ = context.Operators.And(gzzzzzzzzzzzzzj_, gzzzzzzzzzzzzzs_);

            return gzzzzzzzzzzzzzt_;
        };
        IEnumerable<Communication> fzzzzzzzzzzzzzq_ = context.Operators.Where<Communication>(fzzzzzzzzzzzzzo_, fzzzzzzzzzzzzzp_);

        return fzzzzzzzzzzzzzq_;
    }


    [CqlExpressionDefinition("Denominator Exceptions")]
    public bool? Denominator_Exceptions(CqlContext context)
    {
        IEnumerable<Communication> gzzzzzzzzzzzzzu_ = this.Medical_or_Patient_Reason_for_Not_Communicating_Level_of_Severity_of_Retinopathy(context);
        bool? gzzzzzzzzzzzzzv_ = context.Operators.Exists<Communication>(gzzzzzzzzzzzzzu_);
        IEnumerable<Communication> gzzzzzzzzzzzzzw_ = this.Medical_or_Patient_Reason_for_Not_Communicating_Absence_of_Macular_Edema(context);
        bool? gzzzzzzzzzzzzzx_ = context.Operators.Exists<Communication>(gzzzzzzzzzzzzzw_);
        bool? gzzzzzzzzzzzzzy_ = context.Operators.Or(gzzzzzzzzzzzzzv_, gzzzzzzzzzzzzzx_);
        IEnumerable<Communication> gzzzzzzzzzzzzzz_ = this.Medical_or_Patient_Reason_for_Not_Communicating_Presence_of_Macular_Edema(context);
        bool? hzzzzzzzzzzzzza_ = context.Operators.Exists<Communication>(gzzzzzzzzzzzzzz_);
        bool? hzzzzzzzzzzzzzb_ = context.Operators.Or(gzzzzzzzzzzzzzy_, hzzzzzzzzzzzzza_);

        return hzzzzzzzzzzzzzb_;
    }


    [CqlExpressionDefinition("Initial Population")]
    public bool? Initial_Population(CqlContext context)
    {
        Patient hzzzzzzzzzzzzzc_ = this.Patient(context);
        Date hzzzzzzzzzzzzzd_ = hzzzzzzzzzzzzzc_?.BirthDateElement;
        string hzzzzzzzzzzzzze_ = hzzzzzzzzzzzzzd_?.Value;
        CqlDateTime hzzzzzzzzzzzzzf_ = context.Operators.ConvertStringToDateTime(hzzzzzzzzzzzzze_);
        CqlInterval<CqlDateTime> hzzzzzzzzzzzzzg_ = this.Measurement_Period(context);
        CqlDateTime hzzzzzzzzzzzzzh_ = context.Operators.Start(hzzzzzzzzzzzzzg_);
        int? hzzzzzzzzzzzzzi_ = context.Operators.CalculateAgeAt(hzzzzzzzzzzzzzf_, hzzzzzzzzzzzzzh_, "year");
        bool? hzzzzzzzzzzzzzj_ = context.Operators.GreaterOrEqual(hzzzzzzzzzzzzzi_, 18);
        IEnumerable<Encounter> hzzzzzzzzzzzzzk_ = this.Diabetic_Retinopathy_Encounter(context);
        bool? hzzzzzzzzzzzzzl_ = context.Operators.Exists<Encounter>(hzzzzzzzzzzzzzk_);
        bool? hzzzzzzzzzzzzzm_ = context.Operators.And(hzzzzzzzzzzzzzj_, hzzzzzzzzzzzzzl_);

        return hzzzzzzzzzzzzzm_;
    }


    [CqlExpressionDefinition("Macular Exam Performed")]
    public IEnumerable<Observation> Macular_Exam_Performed(CqlContext context)
    {
        CqlValueSet hzzzzzzzzzzzzzn_ = this.Macular_Exam(context);
        IEnumerable<Observation> hzzzzzzzzzzzzzo_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, hzzzzzzzzzzzzzn_, default, "http://hl7.org/fhir/StructureDefinition/Observation"));
        IEnumerable<Observation> hzzzzzzzzzzzzzp_(Observation MacularExam)
        {
            IEnumerable<Encounter> hzzzzzzzzzzzzzt_ = this.Diabetic_Retinopathy_Encounter(context);
            bool? hzzzzzzzzzzzzzu_(Encounter EncounterDiabeticRetinopathy)
            {
                Period hzzzzzzzzzzzzzy_ = EncounterDiabeticRetinopathy?.Period;
                CqlInterval<CqlDateTime> hzzzzzzzzzzzzzz_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, hzzzzzzzzzzzzzy_);
                DataType izzzzzzzzzzzzza_ = MacularExam?.Effective;
                CqlInterval<CqlDateTime> izzzzzzzzzzzzzb_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, izzzzzzzzzzzzza_);
                bool? izzzzzzzzzzzzzc_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(hzzzzzzzzzzzzzz_, izzzzzzzzzzzzzb_, default);

                return izzzzzzzzzzzzzc_;
            };
            IEnumerable<Encounter> hzzzzzzzzzzzzzv_ = context.Operators.Where<Encounter>(hzzzzzzzzzzzzzt_, hzzzzzzzzzzzzzu_);
            Observation hzzzzzzzzzzzzzw_(Encounter EncounterDiabeticRetinopathy) =>
                MacularExam;
            IEnumerable<Observation> hzzzzzzzzzzzzzx_ = context.Operators.Select<Encounter, Observation>(hzzzzzzzzzzzzzv_, hzzzzzzzzzzzzzw_);

            return hzzzzzzzzzzzzzx_;
        };
        IEnumerable<Observation> hzzzzzzzzzzzzzq_ = context.Operators.SelectMany<Observation, Observation>(hzzzzzzzzzzzzzo_, hzzzzzzzzzzzzzp_);
        bool? hzzzzzzzzzzzzzr_(Observation MacularExam)
        {
            Code<ObservationStatus> izzzzzzzzzzzzzd_ = MacularExam?.StatusElement;
            string izzzzzzzzzzzzze_ = FHIRHelpers_4_0_001.Instance.ToString(context, izzzzzzzzzzzzzd_);
            string[] izzzzzzzzzzzzzf_ = [
                "final",
                "amended",
                "corrected",
            ];
            bool? izzzzzzzzzzzzzg_ = context.Operators.In<string>(izzzzzzzzzzzzze_, izzzzzzzzzzzzzf_ as IEnumerable<string>);
            DataType izzzzzzzzzzzzzh_ = MacularExam?.Value;
            bool? izzzzzzzzzzzzzi_ = context.Operators.Not((bool?)(izzzzzzzzzzzzzh_ is null));
            bool? izzzzzzzzzzzzzj_ = context.Operators.And(izzzzzzzzzzzzzg_, izzzzzzzzzzzzzi_);

            return izzzzzzzzzzzzzj_;
        };
        IEnumerable<Observation> hzzzzzzzzzzzzzs_ = context.Operators.Where<Observation>(hzzzzzzzzzzzzzq_, hzzzzzzzzzzzzzr_);

        return hzzzzzzzzzzzzzs_;
    }


    [CqlExpressionDefinition("Denominator")]
    public bool? Denominator(CqlContext context)
    {
        bool? izzzzzzzzzzzzzk_ = this.Initial_Population(context);
        IEnumerable<Observation> izzzzzzzzzzzzzl_ = this.Macular_Exam_Performed(context);
        bool? izzzzzzzzzzzzzm_ = context.Operators.Exists<Observation>(izzzzzzzzzzzzzl_);
        bool? izzzzzzzzzzzzzn_ = context.Operators.And(izzzzzzzzzzzzzk_, izzzzzzzzzzzzzm_);

        return izzzzzzzzzzzzzn_;
    }


    [CqlExpressionDefinition("Level of Severity of Retinopathy Findings Communicated")]
    public IEnumerable<Communication> Level_of_Severity_of_Retinopathy_Findings_Communicated(CqlContext context)
    {
        PropertyInfo izzzzzzzzzzzzzo_ = typeof(Communication).GetProperty("ReasonCode");
        CqlValueSet izzzzzzzzzzzzzp_ = this.Level_of_Severity_of_Retinopathy_Findings(context);
        IEnumerable<Communication> izzzzzzzzzzzzzq_ = context.Operators.Retrieve<Communication>(new RetrieveParameters(izzzzzzzzzzzzzo_, izzzzzzzzzzzzzp_, default, "http://hl7.org/fhir/StructureDefinition/Communication"));
        IEnumerable<Communication> izzzzzzzzzzzzzr_(Communication LevelOfSeverityCommunicated)
        {
            IEnumerable<Encounter> izzzzzzzzzzzzzv_ = this.Diabetic_Retinopathy_Encounter(context);
            bool? izzzzzzzzzzzzzw_(Encounter EncounterDiabeticRetinopathy)
            {
                FhirDateTime jzzzzzzzzzzzzza_ = LevelOfSeverityCommunicated?.SentElement;
                CqlDateTime jzzzzzzzzzzzzzb_ = FHIRHelpers_4_0_001.Instance.ToDateTime(context, jzzzzzzzzzzzzza_);
                Period jzzzzzzzzzzzzzc_ = EncounterDiabeticRetinopathy?.Period;
                CqlInterval<CqlDateTime> jzzzzzzzzzzzzzd_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, jzzzzzzzzzzzzzc_);
                CqlDateTime jzzzzzzzzzzzzze_ = context.Operators.Start(jzzzzzzzzzzzzzd_);
                bool? jzzzzzzzzzzzzzf_ = context.Operators.After(jzzzzzzzzzzzzzb_, jzzzzzzzzzzzzze_, default);

                return jzzzzzzzzzzzzzf_;
            };
            IEnumerable<Encounter> izzzzzzzzzzzzzx_ = context.Operators.Where<Encounter>(izzzzzzzzzzzzzv_, izzzzzzzzzzzzzw_);
            Communication izzzzzzzzzzzzzy_(Encounter EncounterDiabeticRetinopathy) =>
                LevelOfSeverityCommunicated;
            IEnumerable<Communication> izzzzzzzzzzzzzz_ = context.Operators.Select<Encounter, Communication>(izzzzzzzzzzzzzx_, izzzzzzzzzzzzzy_);

            return izzzzzzzzzzzzzz_;
        };
        IEnumerable<Communication> izzzzzzzzzzzzzs_ = context.Operators.SelectMany<Communication, Communication>(izzzzzzzzzzzzzq_, izzzzzzzzzzzzzr_);
        bool? izzzzzzzzzzzzzt_(Communication LevelOfSeverityCommunicated)
        {
            Code<EventStatus> jzzzzzzzzzzzzzg_ = LevelOfSeverityCommunicated?.StatusElement;
            string jzzzzzzzzzzzzzh_ = FHIRHelpers_4_0_001.Instance.ToString(context, jzzzzzzzzzzzzzg_);
            bool? jzzzzzzzzzzzzzi_ = context.Operators.Equal(jzzzzzzzzzzzzzh_, "completed");

            return jzzzzzzzzzzzzzi_;
        };
        IEnumerable<Communication> izzzzzzzzzzzzzu_ = context.Operators.Where<Communication>(izzzzzzzzzzzzzs_, izzzzzzzzzzzzzt_);

        return izzzzzzzzzzzzzu_;
    }


    [CqlExpressionDefinition("Macular Edema Absence Communicated")]
    public IEnumerable<Communication> Macular_Edema_Absence_Communicated(CqlContext context)
    {
        PropertyInfo jzzzzzzzzzzzzzj_ = typeof(Communication).GetProperty("ReasonCode");
        CqlCode jzzzzzzzzzzzzzk_ = this.Macular_edema_absent__situation_(context);
        IEnumerable<CqlCode> jzzzzzzzzzzzzzl_ = context.Operators.ToList<CqlCode>(jzzzzzzzzzzzzzk_);
        IEnumerable<Communication> jzzzzzzzzzzzzzm_ = context.Operators.Retrieve<Communication>(new RetrieveParameters(jzzzzzzzzzzzzzj_, default, jzzzzzzzzzzzzzl_, "http://hl7.org/fhir/StructureDefinition/Communication"));
        IEnumerable<Communication> jzzzzzzzzzzzzzn_(Communication MacularEdemaAbsentCommunicated)
        {
            IEnumerable<Encounter> jzzzzzzzzzzzzzr_ = this.Diabetic_Retinopathy_Encounter(context);
            bool? jzzzzzzzzzzzzzs_(Encounter EncounterDiabeticRetinopathy)
            {
                FhirDateTime jzzzzzzzzzzzzzw_ = MacularEdemaAbsentCommunicated?.SentElement;
                CqlDateTime jzzzzzzzzzzzzzx_ = FHIRHelpers_4_0_001.Instance.ToDateTime(context, jzzzzzzzzzzzzzw_);
                Period jzzzzzzzzzzzzzy_ = EncounterDiabeticRetinopathy?.Period;
                CqlInterval<CqlDateTime> jzzzzzzzzzzzzzz_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, jzzzzzzzzzzzzzy_);
                CqlDateTime kzzzzzzzzzzzzza_ = context.Operators.Start(jzzzzzzzzzzzzzz_);
                bool? kzzzzzzzzzzzzzb_ = context.Operators.After(jzzzzzzzzzzzzzx_, kzzzzzzzzzzzzza_, default);

                return kzzzzzzzzzzzzzb_;
            };
            IEnumerable<Encounter> jzzzzzzzzzzzzzt_ = context.Operators.Where<Encounter>(jzzzzzzzzzzzzzr_, jzzzzzzzzzzzzzs_);
            Communication jzzzzzzzzzzzzzu_(Encounter EncounterDiabeticRetinopathy) =>
                MacularEdemaAbsentCommunicated;
            IEnumerable<Communication> jzzzzzzzzzzzzzv_ = context.Operators.Select<Encounter, Communication>(jzzzzzzzzzzzzzt_, jzzzzzzzzzzzzzu_);

            return jzzzzzzzzzzzzzv_;
        };
        IEnumerable<Communication> jzzzzzzzzzzzzzo_ = context.Operators.SelectMany<Communication, Communication>(jzzzzzzzzzzzzzm_, jzzzzzzzzzzzzzn_);
        bool? jzzzzzzzzzzzzzp_(Communication MacularEdemaAbsentCommunicated)
        {
            Code<EventStatus> kzzzzzzzzzzzzzc_ = MacularEdemaAbsentCommunicated?.StatusElement;
            string kzzzzzzzzzzzzzd_ = FHIRHelpers_4_0_001.Instance.ToString(context, kzzzzzzzzzzzzzc_);
            bool? kzzzzzzzzzzzzze_ = context.Operators.Equal(kzzzzzzzzzzzzzd_, "completed");

            return kzzzzzzzzzzzzze_;
        };
        IEnumerable<Communication> jzzzzzzzzzzzzzq_ = context.Operators.Where<Communication>(jzzzzzzzzzzzzzo_, jzzzzzzzzzzzzzp_);

        return jzzzzzzzzzzzzzq_;
    }


    [CqlExpressionDefinition("Macular Edema Presence Communicated")]
    public IEnumerable<Communication> Macular_Edema_Presence_Communicated(CqlContext context)
    {
        PropertyInfo kzzzzzzzzzzzzzf_ = typeof(Communication).GetProperty("ReasonCode");
        CqlValueSet kzzzzzzzzzzzzzg_ = this.Macular_Edema_Findings_Present(context);
        IEnumerable<Communication> kzzzzzzzzzzzzzh_ = context.Operators.Retrieve<Communication>(new RetrieveParameters(kzzzzzzzzzzzzzf_, kzzzzzzzzzzzzzg_, default, "http://hl7.org/fhir/StructureDefinition/Communication"));
        IEnumerable<Communication> kzzzzzzzzzzzzzi_(Communication MacularEdemaPresentCommunicated)
        {
            IEnumerable<Encounter> kzzzzzzzzzzzzzm_ = this.Diabetic_Retinopathy_Encounter(context);
            bool? kzzzzzzzzzzzzzn_(Encounter EncounterDiabeticRetinopathy)
            {
                FhirDateTime kzzzzzzzzzzzzzr_ = MacularEdemaPresentCommunicated?.SentElement;
                CqlDateTime kzzzzzzzzzzzzzs_ = FHIRHelpers_4_0_001.Instance.ToDateTime(context, kzzzzzzzzzzzzzr_);
                Period kzzzzzzzzzzzzzt_ = EncounterDiabeticRetinopathy?.Period;
                CqlInterval<CqlDateTime> kzzzzzzzzzzzzzu_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, kzzzzzzzzzzzzzt_);
                CqlDateTime kzzzzzzzzzzzzzv_ = context.Operators.Start(kzzzzzzzzzzzzzu_);
                bool? kzzzzzzzzzzzzzw_ = context.Operators.After(kzzzzzzzzzzzzzs_, kzzzzzzzzzzzzzv_, default);

                return kzzzzzzzzzzzzzw_;
            };
            IEnumerable<Encounter> kzzzzzzzzzzzzzo_ = context.Operators.Where<Encounter>(kzzzzzzzzzzzzzm_, kzzzzzzzzzzzzzn_);
            Communication kzzzzzzzzzzzzzp_(Encounter EncounterDiabeticRetinopathy) =>
                MacularEdemaPresentCommunicated;
            IEnumerable<Communication> kzzzzzzzzzzzzzq_ = context.Operators.Select<Encounter, Communication>(kzzzzzzzzzzzzzo_, kzzzzzzzzzzzzzp_);

            return kzzzzzzzzzzzzzq_;
        };
        IEnumerable<Communication> kzzzzzzzzzzzzzj_ = context.Operators.SelectMany<Communication, Communication>(kzzzzzzzzzzzzzh_, kzzzzzzzzzzzzzi_);
        bool? kzzzzzzzzzzzzzk_(Communication MacularEdemaPresentCommunicated)
        {
            Code<EventStatus> kzzzzzzzzzzzzzx_ = MacularEdemaPresentCommunicated?.StatusElement;
            string kzzzzzzzzzzzzzy_ = FHIRHelpers_4_0_001.Instance.ToString(context, kzzzzzzzzzzzzzx_);
            bool? kzzzzzzzzzzzzzz_ = context.Operators.Equal(kzzzzzzzzzzzzzy_, "completed");

            return kzzzzzzzzzzzzzz_;
        };
        IEnumerable<Communication> kzzzzzzzzzzzzzl_ = context.Operators.Where<Communication>(kzzzzzzzzzzzzzj_, kzzzzzzzzzzzzzk_);

        return kzzzzzzzzzzzzzl_;
    }


    [CqlExpressionDefinition("Results of Dilated Macular or Fundus Exam Communicated")]
    public bool? Results_of_Dilated_Macular_or_Fundus_Exam_Communicated(CqlContext context)
    {
        IEnumerable<Communication> lzzzzzzzzzzzzza_ = this.Level_of_Severity_of_Retinopathy_Findings_Communicated(context);
        bool? lzzzzzzzzzzzzzb_ = context.Operators.Exists<Communication>(lzzzzzzzzzzzzza_);
        IEnumerable<Communication> lzzzzzzzzzzzzzc_ = this.Macular_Edema_Absence_Communicated(context);
        bool? lzzzzzzzzzzzzzd_ = context.Operators.Exists<Communication>(lzzzzzzzzzzzzzc_);
        IEnumerable<Communication> lzzzzzzzzzzzzze_ = this.Macular_Edema_Presence_Communicated(context);
        bool? lzzzzzzzzzzzzzf_ = context.Operators.Exists<Communication>(lzzzzzzzzzzzzze_);
        bool? lzzzzzzzzzzzzzg_ = context.Operators.Or(lzzzzzzzzzzzzzd_, lzzzzzzzzzzzzzf_);
        bool? lzzzzzzzzzzzzzh_ = context.Operators.And(lzzzzzzzzzzzzzb_, lzzzzzzzzzzzzzg_);

        return lzzzzzzzzzzzzzh_;
    }


    [CqlExpressionDefinition("Numerator")]
    public bool? Numerator(CqlContext context)
    {
        IEnumerable<Communication> lzzzzzzzzzzzzzi_ = this.Level_of_Severity_of_Retinopathy_Findings_Communicated(context);
        bool? lzzzzzzzzzzzzzj_ = context.Operators.Exists<Communication>(lzzzzzzzzzzzzzi_);
        IEnumerable<Communication> lzzzzzzzzzzzzzk_ = this.Macular_Edema_Absence_Communicated(context);
        bool? lzzzzzzzzzzzzzl_ = context.Operators.Exists<Communication>(lzzzzzzzzzzzzzk_);
        IEnumerable<Communication> lzzzzzzzzzzzzzm_ = this.Macular_Edema_Presence_Communicated(context);
        bool? lzzzzzzzzzzzzzn_ = context.Operators.Exists<Communication>(lzzzzzzzzzzzzzm_);
        bool? lzzzzzzzzzzzzzo_ = context.Operators.Or(lzzzzzzzzzzzzzl_, lzzzzzzzzzzzzzn_);
        bool? lzzzzzzzzzzzzzp_ = context.Operators.And(lzzzzzzzzzzzzzj_, lzzzzzzzzzzzzzo_);

        return lzzzzzzzzzzzzzp_;
    }


    #endregion Expressions

}
