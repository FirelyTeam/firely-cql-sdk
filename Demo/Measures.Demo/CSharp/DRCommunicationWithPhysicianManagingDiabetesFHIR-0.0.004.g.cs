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
        object azzzzzzzzk_ = context.ResolveParameter("DRCommunicationWithPhysicianManagingDiabetesFHIR-0.0.004", "Measurement Period", null);

        return (CqlInterval<CqlDateTime>)azzzzzzzzk_;
    }


    #endregion Parameters

    #region Expressions

    [CqlExpressionDefinition("Patient")]
    public Patient Patient(CqlContext context)
    {
        IEnumerable<Patient> azzzzzzzzl_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/StructureDefinition/Patient"));
        Patient azzzzzzzzm_ = context.Operators.SingletonFrom<Patient>(azzzzzzzzl_);

        return azzzzzzzzm_;
    }


    [CqlExpressionDefinition("SDE Ethnicity")]
    public IEnumerable<Coding> SDE_Ethnicity(CqlContext context)
    {
        IEnumerable<Coding> azzzzzzzzn_ = SupplementalDataElementsFHIR4_2_0_000.Instance.SDE_Ethnicity(context);

        return azzzzzzzzn_;
    }


    [CqlExpressionDefinition("SDE Payer")]
    public IEnumerable<(CqlTupleMetadata, CodeableConcept code, Period period)?> SDE_Payer(CqlContext context)
    {
        IEnumerable<(CqlTupleMetadata, CodeableConcept code, Period period)?> azzzzzzzzo_ = SupplementalDataElementsFHIR4_2_0_000.Instance.SDE_Payer(context);

        return azzzzzzzzo_;
    }


    [CqlExpressionDefinition("SDE Race")]
    public IEnumerable<Coding> SDE_Race(CqlContext context)
    {
        IEnumerable<Coding> azzzzzzzzp_ = SupplementalDataElementsFHIR4_2_0_000.Instance.SDE_Race(context);

        return azzzzzzzzp_;
    }


    [CqlExpressionDefinition("SDE Sex")]
    public CqlCode SDE_Sex(CqlContext context)
    {
        CqlCode azzzzzzzzq_ = SupplementalDataElementsFHIR4_2_0_000.Instance.SDE_Sex(context);

        return azzzzzzzzq_;
    }


    [CqlExpressionDefinition("Qualifying Encounter During Measurement Period")]
    public IEnumerable<Encounter> Qualifying_Encounter_During_Measurement_Period(CqlContext context)
    {
        CqlValueSet azzzzzzzzr_ = this.Office_Visit(context);
        IEnumerable<Encounter> azzzzzzzzs_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, azzzzzzzzr_, default, "http://hl7.org/fhir/StructureDefinition/Encounter"));
        CqlValueSet azzzzzzzzt_ = this.Ophthalmological_Services(context);
        IEnumerable<Encounter> azzzzzzzzu_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, azzzzzzzzt_, default, "http://hl7.org/fhir/StructureDefinition/Encounter"));
        IEnumerable<Encounter> azzzzzzzzv_ = context.Operators.Union<Encounter>(azzzzzzzzs_, azzzzzzzzu_);
        CqlValueSet azzzzzzzzw_ = this.Outpatient_Consultation(context);
        IEnumerable<Encounter> azzzzzzzzx_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, azzzzzzzzw_, default, "http://hl7.org/fhir/StructureDefinition/Encounter"));
        CqlValueSet azzzzzzzzy_ = this.Care_Services_in_Long_Term_Residential_Facility(context);
        IEnumerable<Encounter> azzzzzzzzz_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, azzzzzzzzy_, default, "http://hl7.org/fhir/StructureDefinition/Encounter"));
        IEnumerable<Encounter> bzzzzzzzza_ = context.Operators.Union<Encounter>(azzzzzzzzx_, azzzzzzzzz_);
        IEnumerable<Encounter> bzzzzzzzzb_ = context.Operators.Union<Encounter>(azzzzzzzzv_, bzzzzzzzza_);
        CqlValueSet bzzzzzzzzc_ = this.Nursing_Facility_Visit(context);
        IEnumerable<Encounter> bzzzzzzzzd_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, bzzzzzzzzc_, default, "http://hl7.org/fhir/StructureDefinition/Encounter"));
        IEnumerable<Encounter> bzzzzzzzze_ = context.Operators.Union<Encounter>(bzzzzzzzzb_, bzzzzzzzzd_);
        bool? bzzzzzzzzf_(Encounter QualifyingEncounter)
        {
            CqlInterval<CqlDateTime> bzzzzzzzzh_ = this.Measurement_Period(context);
            Period bzzzzzzzzi_ = QualifyingEncounter?.Period;
            CqlInterval<CqlDateTime> bzzzzzzzzj_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, bzzzzzzzzi_);
            bool? bzzzzzzzzk_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(bzzzzzzzzh_, bzzzzzzzzj_, default);
            Code<Encounter.EncounterStatus> bzzzzzzzzl_ = QualifyingEncounter?.StatusElement;
            string bzzzzzzzzm_ = FHIRHelpers_4_0_001.Instance.ToString(context, bzzzzzzzzl_);
            bool? bzzzzzzzzn_ = context.Operators.Equal(bzzzzzzzzm_, "finished");
            bool? bzzzzzzzzo_ = context.Operators.And(bzzzzzzzzk_, bzzzzzzzzn_);

            return bzzzzzzzzo_;
        };
        IEnumerable<Encounter> bzzzzzzzzg_ = context.Operators.Where<Encounter>(bzzzzzzzze_, bzzzzzzzzf_);

        return bzzzzzzzzg_;
    }


    [CqlExpressionDefinition("Diabetic Retinopathy Encounter")]
    public IEnumerable<Encounter> Diabetic_Retinopathy_Encounter(CqlContext context)
    {
        IEnumerable<Encounter> bzzzzzzzzp_ = this.Qualifying_Encounter_During_Measurement_Period(context);
        IEnumerable<Encounter> bzzzzzzzzq_(Encounter ValidQualifyingEncounter)
        {
            CqlValueSet bzzzzzzzzs_ = this.Diabetic_Retinopathy(context);
            IEnumerable<Condition> bzzzzzzzzt_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, bzzzzzzzzs_, default, "http://hl7.org/fhir/StructureDefinition/Condition"));
            bool? bzzzzzzzzu_(Condition DiabeticRetinopathy)
            {
                CodeableConcept bzzzzzzzzy_ = DiabeticRetinopathy?.ClinicalStatus;
                CqlConcept bzzzzzzzzz_ = FHIRHelpers_4_0_001.Instance.ToConcept(context, bzzzzzzzzy_);
                CqlCode czzzzzzzza_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.active(context);
                CqlConcept czzzzzzzzb_ = context.Operators.ConvertCodeToConcept(czzzzzzzza_);
                bool? czzzzzzzzc_ = context.Operators.Equivalent(bzzzzzzzzz_, czzzzzzzzb_);
                CqlInterval<CqlDateTime> czzzzzzzzd_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Prevalence_Period(context, DiabeticRetinopathy);
                Period czzzzzzzze_ = ValidQualifyingEncounter?.Period;
                CqlInterval<CqlDateTime> czzzzzzzzf_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, czzzzzzzze_);
                bool? czzzzzzzzg_ = context.Operators.Overlaps(czzzzzzzzd_, czzzzzzzzf_, default);
                bool? czzzzzzzzh_ = context.Operators.And(czzzzzzzzc_, czzzzzzzzg_);

                return czzzzzzzzh_;
            };
            IEnumerable<Condition> bzzzzzzzzv_ = context.Operators.Where<Condition>(bzzzzzzzzt_, bzzzzzzzzu_);
            Encounter bzzzzzzzzw_(Condition DiabeticRetinopathy) =>
                ValidQualifyingEncounter;
            IEnumerable<Encounter> bzzzzzzzzx_ = context.Operators.Select<Condition, Encounter>(bzzzzzzzzv_, bzzzzzzzzw_);

            return bzzzzzzzzx_;
        };
        IEnumerable<Encounter> bzzzzzzzzr_ = context.Operators.SelectMany<Encounter, Encounter>(bzzzzzzzzp_, bzzzzzzzzq_);

        return bzzzzzzzzr_;
    }


    [CqlExpressionDefinition("GetModifierExtensions")]
    public IEnumerable<Extension> GetModifierExtensions(CqlContext context, DomainResource domainResource, string url)
    {
        List<Extension> czzzzzzzzi_ = domainResource?.ModifierExtension;
        bool? czzzzzzzzj_(Extension E)
        {
            string czzzzzzzzo_ = E?.Url;
            FhirUri czzzzzzzzp_ = context.Operators.Convert<FhirUri>(czzzzzzzzo_);
            string czzzzzzzzq_ = FHIRHelpers_4_0_001.Instance.ToString(context, czzzzzzzzp_);
            string czzzzzzzzr_ = context.Operators.Concatenate("http://hl7.org/fhir/us/qicore/StructureDefinition/", url);
            bool? czzzzzzzzs_ = context.Operators.Equal(czzzzzzzzq_, czzzzzzzzr_);

            return czzzzzzzzs_;
        };
        IEnumerable<Extension> czzzzzzzzk_ = context.Operators.Where<Extension>((IEnumerable<Extension>)czzzzzzzzi_, czzzzzzzzj_);
        Extension czzzzzzzzl_(Extension E) =>
            E;
        IEnumerable<Extension> czzzzzzzzm_ = context.Operators.Select<Extension, Extension>(czzzzzzzzk_, czzzzzzzzl_);
        IEnumerable<Extension> czzzzzzzzn_ = context.Operators.Distinct<Extension>(czzzzzzzzm_);

        return czzzzzzzzn_;
    }


    [CqlExpressionDefinition("GetModifierExtension")]
    public Extension GetModifierExtension(CqlContext context, DomainResource domainResource, string url)
    {
        IEnumerable<Extension> czzzzzzzzt_ = this.GetModifierExtensions(context, domainResource, url);
        Extension czzzzzzzzu_ = context.Operators.SingletonFrom<Extension>(czzzzzzzzt_);

        return czzzzzzzzu_;
    }


    [CqlExpressionDefinition("Medical or Patient Reason for Not Communicating Level of Severity of Retinopathy")]
    public IEnumerable<Communication> Medical_or_Patient_Reason_for_Not_Communicating_Level_of_Severity_of_Retinopathy(CqlContext context)
    {
        PropertyInfo czzzzzzzzv_ = typeof(Communication).GetProperty("ReasonCode");
        CqlValueSet czzzzzzzzw_ = this.Level_of_Severity_of_Retinopathy_Findings(context);
        IEnumerable<Communication> czzzzzzzzx_ = context.Operators.Retrieve<Communication>(new RetrieveParameters(czzzzzzzzv_, czzzzzzzzw_, default, "http://hl7.org/fhir/StructureDefinition/Communication"));
        IEnumerable<Communication> czzzzzzzzy_(Communication LevelOfSeverityNotCommunicated)
        {
            IEnumerable<Encounter> dzzzzzzzzc_ = this.Diabetic_Retinopathy_Encounter(context);
            bool? dzzzzzzzzd_(Encounter EncounterDiabeticRetinopathy)
            {
                Period dzzzzzzzzh_ = EncounterDiabeticRetinopathy?.Period;
                CqlInterval<CqlDateTime> dzzzzzzzzi_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, dzzzzzzzzh_);
                Extension dzzzzzzzzj_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.GetExtension(context, LevelOfSeverityNotCommunicated, "qicore-recorded");
                DataType dzzzzzzzzk_ = dzzzzzzzzj_?.Value;
                CqlInterval<CqlDateTime> dzzzzzzzzl_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, dzzzzzzzzk_ as Period);
                bool? dzzzzzzzzm_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(dzzzzzzzzi_, dzzzzzzzzl_, default);

                return dzzzzzzzzm_;
            };
            IEnumerable<Encounter> dzzzzzzzze_ = context.Operators.Where<Encounter>(dzzzzzzzzc_, dzzzzzzzzd_);
            Communication dzzzzzzzzf_(Encounter EncounterDiabeticRetinopathy) =>
                LevelOfSeverityNotCommunicated;
            IEnumerable<Communication> dzzzzzzzzg_ = context.Operators.Select<Encounter, Communication>(dzzzzzzzze_, dzzzzzzzzf_);

            return dzzzzzzzzg_;
        };
        IEnumerable<Communication> czzzzzzzzz_ = context.Operators.SelectMany<Communication, Communication>(czzzzzzzzx_, czzzzzzzzy_);
        bool? dzzzzzzzza_(Communication LevelOfSeverityNotCommunicated)
        {
            Code<EventStatus> dzzzzzzzzn_ = LevelOfSeverityNotCommunicated?.StatusElement;
            string dzzzzzzzzo_ = FHIRHelpers_4_0_001.Instance.ToString(context, dzzzzzzzzn_);
            bool? dzzzzzzzzp_ = context.Operators.Equal(dzzzzzzzzo_, "not-done");
            Extension dzzzzzzzzq_ = this.GetModifierExtension(context, LevelOfSeverityNotCommunicated, "qicore-notDone");
            DataType dzzzzzzzzr_ = dzzzzzzzzq_?.Value;
            bool? dzzzzzzzzs_ = FHIRHelpers_4_0_001.Instance.ToBoolean(context, dzzzzzzzzr_ as FhirBoolean);
            bool? dzzzzzzzzt_ = context.Operators.IsTrue(dzzzzzzzzs_);
            bool? dzzzzzzzzu_ = context.Operators.And(dzzzzzzzzp_, dzzzzzzzzt_);
            CodeableConcept dzzzzzzzzv_ = LevelOfSeverityNotCommunicated?.StatusReason;
            CqlConcept dzzzzzzzzw_ = FHIRHelpers_4_0_001.Instance.ToConcept(context, dzzzzzzzzv_);
            CqlValueSet dzzzzzzzzx_ = this.Medical_Reason(context);
            bool? dzzzzzzzzy_ = context.Operators.ConceptInValueSet(dzzzzzzzzw_, dzzzzzzzzx_);
            CqlConcept ezzzzzzzza_ = FHIRHelpers_4_0_001.Instance.ToConcept(context, dzzzzzzzzv_);
            CqlValueSet ezzzzzzzzb_ = this.Patient_Reason(context);
            bool? ezzzzzzzzc_ = context.Operators.ConceptInValueSet(ezzzzzzzza_, ezzzzzzzzb_);
            bool? ezzzzzzzzd_ = context.Operators.Or(dzzzzzzzzy_, ezzzzzzzzc_);
            bool? ezzzzzzzze_ = context.Operators.And(dzzzzzzzzu_, ezzzzzzzzd_);

            return ezzzzzzzze_;
        };
        IEnumerable<Communication> dzzzzzzzzb_ = context.Operators.Where<Communication>(czzzzzzzzz_, dzzzzzzzza_);

        return dzzzzzzzzb_;
    }


    [CqlExpressionDefinition("Medical or Patient Reason for Not Communicating Absence of Macular Edema")]
    public IEnumerable<Communication> Medical_or_Patient_Reason_for_Not_Communicating_Absence_of_Macular_Edema(CqlContext context)
    {
        PropertyInfo ezzzzzzzzf_ = typeof(Communication).GetProperty("ReasonCode");
        CqlCode ezzzzzzzzg_ = this.Macular_edema_absent__situation_(context);
        IEnumerable<CqlCode> ezzzzzzzzh_ = context.Operators.ToList<CqlCode>(ezzzzzzzzg_);
        IEnumerable<Communication> ezzzzzzzzi_ = context.Operators.Retrieve<Communication>(new RetrieveParameters(ezzzzzzzzf_, default, ezzzzzzzzh_, "http://hl7.org/fhir/StructureDefinition/Communication"));
        IEnumerable<Communication> ezzzzzzzzj_(Communication MacularEdemaAbsentNotCommunicated)
        {
            IEnumerable<Encounter> ezzzzzzzzn_ = this.Diabetic_Retinopathy_Encounter(context);
            bool? ezzzzzzzzo_(Encounter EncounterDiabeticRetinopathy)
            {
                Period ezzzzzzzzs_ = EncounterDiabeticRetinopathy?.Period;
                CqlInterval<CqlDateTime> ezzzzzzzzt_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, ezzzzzzzzs_);
                Extension ezzzzzzzzu_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.GetExtension(context, MacularEdemaAbsentNotCommunicated, "qicore-recorded");
                DataType ezzzzzzzzv_ = ezzzzzzzzu_?.Value;
                CqlInterval<CqlDateTime> ezzzzzzzzw_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, ezzzzzzzzv_ as Period);
                bool? ezzzzzzzzx_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(ezzzzzzzzt_, ezzzzzzzzw_, default);

                return ezzzzzzzzx_;
            };
            IEnumerable<Encounter> ezzzzzzzzp_ = context.Operators.Where<Encounter>(ezzzzzzzzn_, ezzzzzzzzo_);
            Communication ezzzzzzzzq_(Encounter EncounterDiabeticRetinopathy) =>
                MacularEdemaAbsentNotCommunicated;
            IEnumerable<Communication> ezzzzzzzzr_ = context.Operators.Select<Encounter, Communication>(ezzzzzzzzp_, ezzzzzzzzq_);

            return ezzzzzzzzr_;
        };
        IEnumerable<Communication> ezzzzzzzzk_ = context.Operators.SelectMany<Communication, Communication>(ezzzzzzzzi_, ezzzzzzzzj_);
        bool? ezzzzzzzzl_(Communication MacularEdemaAbsentNotCommunicated)
        {
            Code<EventStatus> ezzzzzzzzy_ = MacularEdemaAbsentNotCommunicated?.StatusElement;
            string ezzzzzzzzz_ = FHIRHelpers_4_0_001.Instance.ToString(context, ezzzzzzzzy_);
            bool? fzzzzzzzza_ = context.Operators.Equal(ezzzzzzzzz_, "not-done");
            Extension fzzzzzzzzb_ = this.GetModifierExtension(context, MacularEdemaAbsentNotCommunicated, "qicore-notDone");
            DataType fzzzzzzzzc_ = fzzzzzzzzb_?.Value;
            bool? fzzzzzzzzd_ = FHIRHelpers_4_0_001.Instance.ToBoolean(context, fzzzzzzzzc_ as FhirBoolean);
            bool? fzzzzzzzze_ = context.Operators.IsTrue(fzzzzzzzzd_);
            bool? fzzzzzzzzf_ = context.Operators.And(fzzzzzzzza_, fzzzzzzzze_);
            CodeableConcept fzzzzzzzzg_ = MacularEdemaAbsentNotCommunicated?.StatusReason;
            CqlConcept fzzzzzzzzh_ = FHIRHelpers_4_0_001.Instance.ToConcept(context, fzzzzzzzzg_);
            CqlValueSet fzzzzzzzzi_ = this.Medical_Reason(context);
            bool? fzzzzzzzzj_ = context.Operators.ConceptInValueSet(fzzzzzzzzh_, fzzzzzzzzi_);
            CqlConcept fzzzzzzzzl_ = FHIRHelpers_4_0_001.Instance.ToConcept(context, fzzzzzzzzg_);
            CqlValueSet fzzzzzzzzm_ = this.Patient_Reason(context);
            bool? fzzzzzzzzn_ = context.Operators.ConceptInValueSet(fzzzzzzzzl_, fzzzzzzzzm_);
            bool? fzzzzzzzzo_ = context.Operators.Or(fzzzzzzzzj_, fzzzzzzzzn_);
            bool? fzzzzzzzzp_ = context.Operators.And(fzzzzzzzzf_, fzzzzzzzzo_);

            return fzzzzzzzzp_;
        };
        IEnumerable<Communication> ezzzzzzzzm_ = context.Operators.Where<Communication>(ezzzzzzzzk_, ezzzzzzzzl_);

        return ezzzzzzzzm_;
    }


    [CqlExpressionDefinition("Medical or Patient Reason for Not Communicating Presence of Macular Edema")]
    public IEnumerable<Communication> Medical_or_Patient_Reason_for_Not_Communicating_Presence_of_Macular_Edema(CqlContext context)
    {
        PropertyInfo fzzzzzzzzq_ = typeof(Communication).GetProperty("ReasonCode");
        CqlValueSet fzzzzzzzzr_ = this.Macular_Edema_Findings_Present(context);
        IEnumerable<Communication> fzzzzzzzzs_ = context.Operators.Retrieve<Communication>(new RetrieveParameters(fzzzzzzzzq_, fzzzzzzzzr_, default, "http://hl7.org/fhir/StructureDefinition/Communication"));
        IEnumerable<Communication> fzzzzzzzzt_(Communication MacularEdemaPresentNotCommunicated)
        {
            IEnumerable<Encounter> fzzzzzzzzx_ = this.Diabetic_Retinopathy_Encounter(context);
            bool? fzzzzzzzzy_(Encounter EncounterDiabeticRetinopathy)
            {
                Period gzzzzzzzzc_ = EncounterDiabeticRetinopathy?.Period;
                CqlInterval<CqlDateTime> gzzzzzzzzd_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, gzzzzzzzzc_);
                Extension gzzzzzzzze_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.GetExtension(context, MacularEdemaPresentNotCommunicated, "qicore-recorded");
                DataType gzzzzzzzzf_ = gzzzzzzzze_?.Value;
                CqlInterval<CqlDateTime> gzzzzzzzzg_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, gzzzzzzzzf_ as Period);
                bool? gzzzzzzzzh_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(gzzzzzzzzd_, gzzzzzzzzg_, default);

                return gzzzzzzzzh_;
            };
            IEnumerable<Encounter> fzzzzzzzzz_ = context.Operators.Where<Encounter>(fzzzzzzzzx_, fzzzzzzzzy_);
            Communication gzzzzzzzza_(Encounter EncounterDiabeticRetinopathy) =>
                MacularEdemaPresentNotCommunicated;
            IEnumerable<Communication> gzzzzzzzzb_ = context.Operators.Select<Encounter, Communication>(fzzzzzzzzz_, gzzzzzzzza_);

            return gzzzzzzzzb_;
        };
        IEnumerable<Communication> fzzzzzzzzu_ = context.Operators.SelectMany<Communication, Communication>(fzzzzzzzzs_, fzzzzzzzzt_);
        bool? fzzzzzzzzv_(Communication MacularEdemaPresentNotCommunicated)
        {
            Code<EventStatus> gzzzzzzzzi_ = MacularEdemaPresentNotCommunicated?.StatusElement;
            string gzzzzzzzzj_ = FHIRHelpers_4_0_001.Instance.ToString(context, gzzzzzzzzi_);
            bool? gzzzzzzzzk_ = context.Operators.Equal(gzzzzzzzzj_, "not-done");
            Extension gzzzzzzzzl_ = this.GetModifierExtension(context, MacularEdemaPresentNotCommunicated, "qicore-notDone");
            DataType gzzzzzzzzm_ = gzzzzzzzzl_?.Value;
            bool? gzzzzzzzzn_ = FHIRHelpers_4_0_001.Instance.ToBoolean(context, gzzzzzzzzm_ as FhirBoolean);
            bool? gzzzzzzzzo_ = context.Operators.IsTrue(gzzzzzzzzn_);
            bool? gzzzzzzzzp_ = context.Operators.And(gzzzzzzzzk_, gzzzzzzzzo_);
            CodeableConcept gzzzzzzzzq_ = MacularEdemaPresentNotCommunicated?.StatusReason;
            CqlConcept gzzzzzzzzr_ = FHIRHelpers_4_0_001.Instance.ToConcept(context, gzzzzzzzzq_);
            CqlValueSet gzzzzzzzzs_ = this.Medical_Reason(context);
            bool? gzzzzzzzzt_ = context.Operators.ConceptInValueSet(gzzzzzzzzr_, gzzzzzzzzs_);
            CqlConcept gzzzzzzzzv_ = FHIRHelpers_4_0_001.Instance.ToConcept(context, gzzzzzzzzq_);
            CqlValueSet gzzzzzzzzw_ = this.Patient_Reason(context);
            bool? gzzzzzzzzx_ = context.Operators.ConceptInValueSet(gzzzzzzzzv_, gzzzzzzzzw_);
            bool? gzzzzzzzzy_ = context.Operators.Or(gzzzzzzzzt_, gzzzzzzzzx_);
            bool? gzzzzzzzzz_ = context.Operators.And(gzzzzzzzzp_, gzzzzzzzzy_);

            return gzzzzzzzzz_;
        };
        IEnumerable<Communication> fzzzzzzzzw_ = context.Operators.Where<Communication>(fzzzzzzzzu_, fzzzzzzzzv_);

        return fzzzzzzzzw_;
    }


    [CqlExpressionDefinition("Denominator Exceptions")]
    public bool? Denominator_Exceptions(CqlContext context)
    {
        IEnumerable<Communication> hzzzzzzzza_ = this.Medical_or_Patient_Reason_for_Not_Communicating_Level_of_Severity_of_Retinopathy(context);
        bool? hzzzzzzzzb_ = context.Operators.Exists<Communication>(hzzzzzzzza_);
        IEnumerable<Communication> hzzzzzzzzc_ = this.Medical_or_Patient_Reason_for_Not_Communicating_Absence_of_Macular_Edema(context);
        bool? hzzzzzzzzd_ = context.Operators.Exists<Communication>(hzzzzzzzzc_);
        bool? hzzzzzzzze_ = context.Operators.Or(hzzzzzzzzb_, hzzzzzzzzd_);
        IEnumerable<Communication> hzzzzzzzzf_ = this.Medical_or_Patient_Reason_for_Not_Communicating_Presence_of_Macular_Edema(context);
        bool? hzzzzzzzzg_ = context.Operators.Exists<Communication>(hzzzzzzzzf_);
        bool? hzzzzzzzzh_ = context.Operators.Or(hzzzzzzzze_, hzzzzzzzzg_);

        return hzzzzzzzzh_;
    }


    [CqlExpressionDefinition("Initial Population")]
    public bool? Initial_Population(CqlContext context)
    {
        Patient hzzzzzzzzi_ = this.Patient(context);
        Date hzzzzzzzzj_ = hzzzzzzzzi_?.BirthDateElement;
        string hzzzzzzzzk_ = hzzzzzzzzj_?.Value;
        CqlDateTime hzzzzzzzzl_ = context.Operators.ConvertStringToDateTime(hzzzzzzzzk_);
        CqlInterval<CqlDateTime> hzzzzzzzzm_ = this.Measurement_Period(context);
        CqlDateTime hzzzzzzzzn_ = context.Operators.Start(hzzzzzzzzm_);
        int? hzzzzzzzzo_ = context.Operators.CalculateAgeAt(hzzzzzzzzl_, hzzzzzzzzn_, "year");
        bool? hzzzzzzzzp_ = context.Operators.GreaterOrEqual(hzzzzzzzzo_, 18);
        IEnumerable<Encounter> hzzzzzzzzq_ = this.Diabetic_Retinopathy_Encounter(context);
        bool? hzzzzzzzzr_ = context.Operators.Exists<Encounter>(hzzzzzzzzq_);
        bool? hzzzzzzzzs_ = context.Operators.And(hzzzzzzzzp_, hzzzzzzzzr_);

        return hzzzzzzzzs_;
    }


    [CqlExpressionDefinition("Macular Exam Performed")]
    public IEnumerable<Observation> Macular_Exam_Performed(CqlContext context)
    {
        CqlValueSet hzzzzzzzzt_ = this.Macular_Exam(context);
        IEnumerable<Observation> hzzzzzzzzu_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, hzzzzzzzzt_, default, "http://hl7.org/fhir/StructureDefinition/Observation"));
        IEnumerable<Observation> hzzzzzzzzv_(Observation MacularExam)
        {
            IEnumerable<Encounter> hzzzzzzzzz_ = this.Diabetic_Retinopathy_Encounter(context);
            bool? izzzzzzzza_(Encounter EncounterDiabeticRetinopathy)
            {
                Period izzzzzzzze_ = EncounterDiabeticRetinopathy?.Period;
                CqlInterval<CqlDateTime> izzzzzzzzf_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, izzzzzzzze_);
                DataType izzzzzzzzg_ = MacularExam?.Effective;
                CqlInterval<CqlDateTime> izzzzzzzzh_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, izzzzzzzzg_);
                bool? izzzzzzzzi_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(izzzzzzzzf_, izzzzzzzzh_, default);

                return izzzzzzzzi_;
            };
            IEnumerable<Encounter> izzzzzzzzb_ = context.Operators.Where<Encounter>(hzzzzzzzzz_, izzzzzzzza_);
            Observation izzzzzzzzc_(Encounter EncounterDiabeticRetinopathy) =>
                MacularExam;
            IEnumerable<Observation> izzzzzzzzd_ = context.Operators.Select<Encounter, Observation>(izzzzzzzzb_, izzzzzzzzc_);

            return izzzzzzzzd_;
        };
        IEnumerable<Observation> hzzzzzzzzw_ = context.Operators.SelectMany<Observation, Observation>(hzzzzzzzzu_, hzzzzzzzzv_);
        bool? hzzzzzzzzx_(Observation MacularExam)
        {
            Code<ObservationStatus> izzzzzzzzj_ = MacularExam?.StatusElement;
            string izzzzzzzzk_ = FHIRHelpers_4_0_001.Instance.ToString(context, izzzzzzzzj_);
            string[] izzzzzzzzl_ = [
                "final",
                "amended",
                "corrected",
            ];
            bool? izzzzzzzzm_ = context.Operators.In<string>(izzzzzzzzk_, izzzzzzzzl_ as IEnumerable<string>);
            DataType izzzzzzzzn_ = MacularExam?.Value;
            bool? izzzzzzzzo_ = context.Operators.Not((bool?)(izzzzzzzzn_ is null));
            bool? izzzzzzzzp_ = context.Operators.And(izzzzzzzzm_, izzzzzzzzo_);

            return izzzzzzzzp_;
        };
        IEnumerable<Observation> hzzzzzzzzy_ = context.Operators.Where<Observation>(hzzzzzzzzw_, hzzzzzzzzx_);

        return hzzzzzzzzy_;
    }


    [CqlExpressionDefinition("Denominator")]
    public bool? Denominator(CqlContext context)
    {
        bool? izzzzzzzzq_ = this.Initial_Population(context);
        IEnumerable<Observation> izzzzzzzzr_ = this.Macular_Exam_Performed(context);
        bool? izzzzzzzzs_ = context.Operators.Exists<Observation>(izzzzzzzzr_);
        bool? izzzzzzzzt_ = context.Operators.And(izzzzzzzzq_, izzzzzzzzs_);

        return izzzzzzzzt_;
    }


    [CqlExpressionDefinition("Level of Severity of Retinopathy Findings Communicated")]
    public IEnumerable<Communication> Level_of_Severity_of_Retinopathy_Findings_Communicated(CqlContext context)
    {
        PropertyInfo izzzzzzzzu_ = typeof(Communication).GetProperty("ReasonCode");
        CqlValueSet izzzzzzzzv_ = this.Level_of_Severity_of_Retinopathy_Findings(context);
        IEnumerable<Communication> izzzzzzzzw_ = context.Operators.Retrieve<Communication>(new RetrieveParameters(izzzzzzzzu_, izzzzzzzzv_, default, "http://hl7.org/fhir/StructureDefinition/Communication"));
        IEnumerable<Communication> izzzzzzzzx_(Communication LevelOfSeverityCommunicated)
        {
            IEnumerable<Encounter> jzzzzzzzzb_ = this.Diabetic_Retinopathy_Encounter(context);
            bool? jzzzzzzzzc_(Encounter EncounterDiabeticRetinopathy)
            {
                FhirDateTime jzzzzzzzzg_ = LevelOfSeverityCommunicated?.SentElement;
                CqlDateTime jzzzzzzzzh_ = FHIRHelpers_4_0_001.Instance.ToDateTime(context, jzzzzzzzzg_);
                Period jzzzzzzzzi_ = EncounterDiabeticRetinopathy?.Period;
                CqlInterval<CqlDateTime> jzzzzzzzzj_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, jzzzzzzzzi_);
                CqlDateTime jzzzzzzzzk_ = context.Operators.Start(jzzzzzzzzj_);
                bool? jzzzzzzzzl_ = context.Operators.After(jzzzzzzzzh_, jzzzzzzzzk_, default);

                return jzzzzzzzzl_;
            };
            IEnumerable<Encounter> jzzzzzzzzd_ = context.Operators.Where<Encounter>(jzzzzzzzzb_, jzzzzzzzzc_);
            Communication jzzzzzzzze_(Encounter EncounterDiabeticRetinopathy) =>
                LevelOfSeverityCommunicated;
            IEnumerable<Communication> jzzzzzzzzf_ = context.Operators.Select<Encounter, Communication>(jzzzzzzzzd_, jzzzzzzzze_);

            return jzzzzzzzzf_;
        };
        IEnumerable<Communication> izzzzzzzzy_ = context.Operators.SelectMany<Communication, Communication>(izzzzzzzzw_, izzzzzzzzx_);
        bool? izzzzzzzzz_(Communication LevelOfSeverityCommunicated)
        {
            Code<EventStatus> jzzzzzzzzm_ = LevelOfSeverityCommunicated?.StatusElement;
            string jzzzzzzzzn_ = FHIRHelpers_4_0_001.Instance.ToString(context, jzzzzzzzzm_);
            bool? jzzzzzzzzo_ = context.Operators.Equal(jzzzzzzzzn_, "completed");

            return jzzzzzzzzo_;
        };
        IEnumerable<Communication> jzzzzzzzza_ = context.Operators.Where<Communication>(izzzzzzzzy_, izzzzzzzzz_);

        return jzzzzzzzza_;
    }


    [CqlExpressionDefinition("Macular Edema Absence Communicated")]
    public IEnumerable<Communication> Macular_Edema_Absence_Communicated(CqlContext context)
    {
        PropertyInfo jzzzzzzzzp_ = typeof(Communication).GetProperty("ReasonCode");
        CqlCode jzzzzzzzzq_ = this.Macular_edema_absent__situation_(context);
        IEnumerable<CqlCode> jzzzzzzzzr_ = context.Operators.ToList<CqlCode>(jzzzzzzzzq_);
        IEnumerable<Communication> jzzzzzzzzs_ = context.Operators.Retrieve<Communication>(new RetrieveParameters(jzzzzzzzzp_, default, jzzzzzzzzr_, "http://hl7.org/fhir/StructureDefinition/Communication"));
        IEnumerable<Communication> jzzzzzzzzt_(Communication MacularEdemaAbsentCommunicated)
        {
            IEnumerable<Encounter> jzzzzzzzzx_ = this.Diabetic_Retinopathy_Encounter(context);
            bool? jzzzzzzzzy_(Encounter EncounterDiabeticRetinopathy)
            {
                FhirDateTime kzzzzzzzzc_ = MacularEdemaAbsentCommunicated?.SentElement;
                CqlDateTime kzzzzzzzzd_ = FHIRHelpers_4_0_001.Instance.ToDateTime(context, kzzzzzzzzc_);
                Period kzzzzzzzze_ = EncounterDiabeticRetinopathy?.Period;
                CqlInterval<CqlDateTime> kzzzzzzzzf_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, kzzzzzzzze_);
                CqlDateTime kzzzzzzzzg_ = context.Operators.Start(kzzzzzzzzf_);
                bool? kzzzzzzzzh_ = context.Operators.After(kzzzzzzzzd_, kzzzzzzzzg_, default);

                return kzzzzzzzzh_;
            };
            IEnumerable<Encounter> jzzzzzzzzz_ = context.Operators.Where<Encounter>(jzzzzzzzzx_, jzzzzzzzzy_);
            Communication kzzzzzzzza_(Encounter EncounterDiabeticRetinopathy) =>
                MacularEdemaAbsentCommunicated;
            IEnumerable<Communication> kzzzzzzzzb_ = context.Operators.Select<Encounter, Communication>(jzzzzzzzzz_, kzzzzzzzza_);

            return kzzzzzzzzb_;
        };
        IEnumerable<Communication> jzzzzzzzzu_ = context.Operators.SelectMany<Communication, Communication>(jzzzzzzzzs_, jzzzzzzzzt_);
        bool? jzzzzzzzzv_(Communication MacularEdemaAbsentCommunicated)
        {
            Code<EventStatus> kzzzzzzzzi_ = MacularEdemaAbsentCommunicated?.StatusElement;
            string kzzzzzzzzj_ = FHIRHelpers_4_0_001.Instance.ToString(context, kzzzzzzzzi_);
            bool? kzzzzzzzzk_ = context.Operators.Equal(kzzzzzzzzj_, "completed");

            return kzzzzzzzzk_;
        };
        IEnumerable<Communication> jzzzzzzzzw_ = context.Operators.Where<Communication>(jzzzzzzzzu_, jzzzzzzzzv_);

        return jzzzzzzzzw_;
    }


    [CqlExpressionDefinition("Macular Edema Presence Communicated")]
    public IEnumerable<Communication> Macular_Edema_Presence_Communicated(CqlContext context)
    {
        PropertyInfo kzzzzzzzzl_ = typeof(Communication).GetProperty("ReasonCode");
        CqlValueSet kzzzzzzzzm_ = this.Macular_Edema_Findings_Present(context);
        IEnumerable<Communication> kzzzzzzzzn_ = context.Operators.Retrieve<Communication>(new RetrieveParameters(kzzzzzzzzl_, kzzzzzzzzm_, default, "http://hl7.org/fhir/StructureDefinition/Communication"));
        IEnumerable<Communication> kzzzzzzzzo_(Communication MacularEdemaPresentCommunicated)
        {
            IEnumerable<Encounter> kzzzzzzzzs_ = this.Diabetic_Retinopathy_Encounter(context);
            bool? kzzzzzzzzt_(Encounter EncounterDiabeticRetinopathy)
            {
                FhirDateTime kzzzzzzzzx_ = MacularEdemaPresentCommunicated?.SentElement;
                CqlDateTime kzzzzzzzzy_ = FHIRHelpers_4_0_001.Instance.ToDateTime(context, kzzzzzzzzx_);
                Period kzzzzzzzzz_ = EncounterDiabeticRetinopathy?.Period;
                CqlInterval<CqlDateTime> lzzzzzzzza_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, kzzzzzzzzz_);
                CqlDateTime lzzzzzzzzb_ = context.Operators.Start(lzzzzzzzza_);
                bool? lzzzzzzzzc_ = context.Operators.After(kzzzzzzzzy_, lzzzzzzzzb_, default);

                return lzzzzzzzzc_;
            };
            IEnumerable<Encounter> kzzzzzzzzu_ = context.Operators.Where<Encounter>(kzzzzzzzzs_, kzzzzzzzzt_);
            Communication kzzzzzzzzv_(Encounter EncounterDiabeticRetinopathy) =>
                MacularEdemaPresentCommunicated;
            IEnumerable<Communication> kzzzzzzzzw_ = context.Operators.Select<Encounter, Communication>(kzzzzzzzzu_, kzzzzzzzzv_);

            return kzzzzzzzzw_;
        };
        IEnumerable<Communication> kzzzzzzzzp_ = context.Operators.SelectMany<Communication, Communication>(kzzzzzzzzn_, kzzzzzzzzo_);
        bool? kzzzzzzzzq_(Communication MacularEdemaPresentCommunicated)
        {
            Code<EventStatus> lzzzzzzzzd_ = MacularEdemaPresentCommunicated?.StatusElement;
            string lzzzzzzzze_ = FHIRHelpers_4_0_001.Instance.ToString(context, lzzzzzzzzd_);
            bool? lzzzzzzzzf_ = context.Operators.Equal(lzzzzzzzze_, "completed");

            return lzzzzzzzzf_;
        };
        IEnumerable<Communication> kzzzzzzzzr_ = context.Operators.Where<Communication>(kzzzzzzzzp_, kzzzzzzzzq_);

        return kzzzzzzzzr_;
    }


    [CqlExpressionDefinition("Results of Dilated Macular or Fundus Exam Communicated")]
    public bool? Results_of_Dilated_Macular_or_Fundus_Exam_Communicated(CqlContext context)
    {
        IEnumerable<Communication> lzzzzzzzzg_ = this.Level_of_Severity_of_Retinopathy_Findings_Communicated(context);
        bool? lzzzzzzzzh_ = context.Operators.Exists<Communication>(lzzzzzzzzg_);
        IEnumerable<Communication> lzzzzzzzzi_ = this.Macular_Edema_Absence_Communicated(context);
        bool? lzzzzzzzzj_ = context.Operators.Exists<Communication>(lzzzzzzzzi_);
        IEnumerable<Communication> lzzzzzzzzk_ = this.Macular_Edema_Presence_Communicated(context);
        bool? lzzzzzzzzl_ = context.Operators.Exists<Communication>(lzzzzzzzzk_);
        bool? lzzzzzzzzm_ = context.Operators.Or(lzzzzzzzzj_, lzzzzzzzzl_);
        bool? lzzzzzzzzn_ = context.Operators.And(lzzzzzzzzh_, lzzzzzzzzm_);

        return lzzzzzzzzn_;
    }


    [CqlExpressionDefinition("Numerator")]
    public bool? Numerator(CqlContext context)
    {
        IEnumerable<Communication> lzzzzzzzzo_ = this.Level_of_Severity_of_Retinopathy_Findings_Communicated(context);
        bool? lzzzzzzzzp_ = context.Operators.Exists<Communication>(lzzzzzzzzo_);
        IEnumerable<Communication> lzzzzzzzzq_ = this.Macular_Edema_Absence_Communicated(context);
        bool? lzzzzzzzzr_ = context.Operators.Exists<Communication>(lzzzzzzzzq_);
        IEnumerable<Communication> lzzzzzzzzs_ = this.Macular_Edema_Presence_Communicated(context);
        bool? lzzzzzzzzt_ = context.Operators.Exists<Communication>(lzzzzzzzzs_);
        bool? lzzzzzzzzu_ = context.Operators.Or(lzzzzzzzzr_, lzzzzzzzzt_);
        bool? lzzzzzzzzv_ = context.Operators.And(lzzzzzzzzp_, lzzzzzzzzu_);

        return lzzzzzzzzv_;
    }


    #endregion Expressions

}
