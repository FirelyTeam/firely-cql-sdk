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
    private static readonly CqlCode _Birth_date = new CqlCode("21112-8", "http://loinc.org");

    [CqlCodeDefinition("Healthcare professional (occupation)", codeId: "223366009", codeSystem: "http://snomed.info/sct")]
    public CqlCode Healthcare_professional__occupation_(CqlContext _) => _Healthcare_professional__occupation_;
    private static readonly CqlCode _Healthcare_professional__occupation_ = new CqlCode("223366009", "http://snomed.info/sct");

    [CqlCodeDefinition("Macular edema absent (situation)", codeId: "428341000124108", codeSystem: "http://snomed.info/sct")]
    public CqlCode Macular_edema_absent__situation_(CqlContext _) => _Macular_edema_absent__situation_;
    private static readonly CqlCode _Macular_edema_absent__situation_ = new CqlCode("428341000124108", "http://snomed.info/sct");

    [CqlCodeDefinition("Medical practitioner (occupation)", codeId: "158965000", codeSystem: "http://snomed.info/sct")]
    public CqlCode Medical_practitioner__occupation_(CqlContext _) => _Medical_practitioner__occupation_;
    private static readonly CqlCode _Medical_practitioner__occupation_ = new CqlCode("158965000", "http://snomed.info/sct");

    [CqlCodeDefinition("Ophthalmologist (occupation)", codeId: "422234006", codeSystem: "http://snomed.info/sct")]
    public CqlCode Ophthalmologist__occupation_(CqlContext _) => _Ophthalmologist__occupation_;
    private static readonly CqlCode _Ophthalmologist__occupation_ = new CqlCode("422234006", "http://snomed.info/sct");

    [CqlCodeDefinition("Optometrist (occupation)", codeId: "28229004", codeSystem: "http://snomed.info/sct")]
    public CqlCode Optometrist__occupation_(CqlContext _) => _Optometrist__occupation_;
    private static readonly CqlCode _Optometrist__occupation_ = new CqlCode("28229004", "http://snomed.info/sct");

    [CqlCodeDefinition("Physician (occupation)", codeId: "309343006", codeSystem: "http://snomed.info/sct")]
    public CqlCode Physician__occupation_(CqlContext _) => _Physician__occupation_;
    private static readonly CqlCode _Physician__occupation_ = new CqlCode("309343006", "http://snomed.info/sct");

    #endregion Codes

    #region CodeSystems

    [CqlCodeSystemDefinition("LOINC")]
    public CqlCodeSystem LOINC(CqlContext _) => _LOINC;
    private static readonly CqlCodeSystem _LOINC =
      new CqlCodeSystem("http://loinc.org", null, [
          _Birth_date]);

    [CqlCodeSystemDefinition("SNOMEDCT")]
    public CqlCodeSystem SNOMEDCT(CqlContext _) => _SNOMEDCT;
    private static readonly CqlCodeSystem _SNOMEDCT =
      new CqlCodeSystem("http://snomed.info/sct", null, [
          _Healthcare_professional__occupation_,
          _Macular_edema_absent__situation_,
          _Medical_practitioner__occupation_,
          _Ophthalmologist__occupation_,
          _Optometrist__occupation_,
          _Physician__occupation_]);

    #endregion CodeSystems

    #region Parameters

    [CqlParameterDefinition("Measurement Period")]
    public CqlInterval<CqlDateTime> Measurement_Period(CqlContext context)
    {
        object zzzzzi_ = context.ResolveParameter("DRCommunicationWithPhysicianManagingDiabetesFHIR-0.0.004", "Measurement Period", null);

        return (CqlInterval<CqlDateTime>)zzzzzi_;
    }


    #endregion Parameters

    #region Expressions

    [CqlExpressionDefinition("Patient")]
    public Patient Patient(CqlContext context)
    {
        IEnumerable<Patient> zzzzzj_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/StructureDefinition/Patient"));
        Patient zzzzzk_ = context.Operators.SingletonFrom<Patient>(zzzzzj_);

        return zzzzzk_;
    }


    [CqlExpressionDefinition("SDE Ethnicity")]
    public IEnumerable<Coding> SDE_Ethnicity(CqlContext context)
    {
        IEnumerable<Coding> zzzzzl_ = SupplementalDataElementsFHIR4_2_0_000.Instance.SDE_Ethnicity(context);

        return zzzzzl_;
    }


    [CqlExpressionDefinition("SDE Payer")]
    public IEnumerable<(CqlTupleMetadata, CodeableConcept code, Period period)?> SDE_Payer(CqlContext context)
    {
        IEnumerable<(CqlTupleMetadata, CodeableConcept code, Period period)?> zzzzzm_ = SupplementalDataElementsFHIR4_2_0_000.Instance.SDE_Payer(context);

        return zzzzzm_;
    }


    [CqlExpressionDefinition("SDE Race")]
    public IEnumerable<Coding> SDE_Race(CqlContext context)
    {
        IEnumerable<Coding> zzzzzn_ = SupplementalDataElementsFHIR4_2_0_000.Instance.SDE_Race(context);

        return zzzzzn_;
    }


    [CqlExpressionDefinition("SDE Sex")]
    public CqlCode SDE_Sex(CqlContext context)
    {
        CqlCode zzzzzo_ = SupplementalDataElementsFHIR4_2_0_000.Instance.SDE_Sex(context);

        return zzzzzo_;
    }


    [CqlExpressionDefinition("Qualifying Encounter During Measurement Period")]
    public IEnumerable<Encounter> Qualifying_Encounter_During_Measurement_Period(CqlContext context)
    {
        CqlValueSet zzzzzp_ = this.Office_Visit(context);
        IEnumerable<Encounter> zzzzzq_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, zzzzzp_, default, "http://hl7.org/fhir/StructureDefinition/Encounter"));
        CqlValueSet zzzzzr_ = this.Ophthalmological_Services(context);
        IEnumerable<Encounter> zzzzzs_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, zzzzzr_, default, "http://hl7.org/fhir/StructureDefinition/Encounter"));
        IEnumerable<Encounter> zzzzzt_ = context.Operators.Union<Encounter>(zzzzzq_, zzzzzs_);
        CqlValueSet zzzzzu_ = this.Outpatient_Consultation(context);
        IEnumerable<Encounter> zzzzzv_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, zzzzzu_, default, "http://hl7.org/fhir/StructureDefinition/Encounter"));
        CqlValueSet zzzzzw_ = this.Care_Services_in_Long_Term_Residential_Facility(context);
        IEnumerable<Encounter> zzzzzx_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, zzzzzw_, default, "http://hl7.org/fhir/StructureDefinition/Encounter"));
        IEnumerable<Encounter> zzzzzy_ = context.Operators.Union<Encounter>(zzzzzv_, zzzzzx_);
        IEnumerable<Encounter> zzzzzz_ = context.Operators.Union<Encounter>(zzzzzt_, zzzzzy_);
        CqlValueSet azzzzza_ = this.Nursing_Facility_Visit(context);
        IEnumerable<Encounter> azzzzzb_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, azzzzza_, default, "http://hl7.org/fhir/StructureDefinition/Encounter"));
        IEnumerable<Encounter> azzzzzc_ = context.Operators.Union<Encounter>(zzzzzz_, azzzzzb_);
        bool? azzzzzd_(Encounter QualifyingEncounter)
        {
            CqlInterval<CqlDateTime> azzzzzf_ = this.Measurement_Period(context);
            Period azzzzzg_ = QualifyingEncounter?.Period;
            CqlInterval<CqlDateTime> azzzzzh_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, azzzzzg_);
            bool? azzzzzi_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(azzzzzf_, azzzzzh_, default);
            Code<Encounter.EncounterStatus> azzzzzj_ = QualifyingEncounter?.StatusElement;
            string azzzzzk_ = FHIRHelpers_4_0_001.Instance.ToString(context, azzzzzj_);
            bool? azzzzzl_ = context.Operators.Equal(azzzzzk_, "finished");
            bool? azzzzzm_ = context.Operators.And(azzzzzi_, azzzzzl_);

            return azzzzzm_;
        };
        IEnumerable<Encounter> azzzzze_ = context.Operators.Where<Encounter>(azzzzzc_, azzzzzd_);

        return azzzzze_;
    }


    [CqlExpressionDefinition("Diabetic Retinopathy Encounter")]
    public IEnumerable<Encounter> Diabetic_Retinopathy_Encounter(CqlContext context)
    {
        IEnumerable<Encounter> azzzzzn_ = this.Qualifying_Encounter_During_Measurement_Period(context);
        IEnumerable<Encounter> azzzzzo_(Encounter ValidQualifyingEncounter)
        {
            CqlValueSet azzzzzq_ = this.Diabetic_Retinopathy(context);
            IEnumerable<Condition> azzzzzr_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, azzzzzq_, default, "http://hl7.org/fhir/StructureDefinition/Condition"));
            bool? azzzzzs_(Condition DiabeticRetinopathy)
            {
                CodeableConcept azzzzzw_ = DiabeticRetinopathy?.ClinicalStatus;
                CqlConcept azzzzzx_ = FHIRHelpers_4_0_001.Instance.ToConcept(context, azzzzzw_);
                CqlCode azzzzzy_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.active(context);
                CqlConcept azzzzzz_ = context.Operators.ConvertCodeToConcept(azzzzzy_);
                bool? bzzzzza_ = context.Operators.Equivalent(azzzzzx_, azzzzzz_);
                CqlInterval<CqlDateTime> bzzzzzb_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Prevalence_Period(context, DiabeticRetinopathy);
                Period bzzzzzc_ = ValidQualifyingEncounter?.Period;
                CqlInterval<CqlDateTime> bzzzzzd_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, bzzzzzc_);
                bool? bzzzzze_ = context.Operators.Overlaps(bzzzzzb_, bzzzzzd_, default);
                bool? bzzzzzf_ = context.Operators.And(bzzzzza_, bzzzzze_);

                return bzzzzzf_;
            };
            IEnumerable<Condition> azzzzzt_ = context.Operators.Where<Condition>(azzzzzr_, azzzzzs_);
            Encounter azzzzzu_(Condition DiabeticRetinopathy) =>
                ValidQualifyingEncounter;
            IEnumerable<Encounter> azzzzzv_ = context.Operators.Select<Condition, Encounter>(azzzzzt_, azzzzzu_);

            return azzzzzv_;
        };
        IEnumerable<Encounter> azzzzzp_ = context.Operators.SelectMany<Encounter, Encounter>(azzzzzn_, azzzzzo_);

        return azzzzzp_;
    }


    [CqlExpressionDefinition("GetModifierExtensions")]
    public IEnumerable<Extension> GetModifierExtensions(CqlContext context, DomainResource domainResource, string url)
    {
        List<Extension> bzzzzzg_ = domainResource?.ModifierExtension;
        bool? bzzzzzh_(Extension E)
        {
            string bzzzzzm_ = E?.Url;
            FhirUri bzzzzzn_ = context.Operators.Convert<FhirUri>(bzzzzzm_);
            string bzzzzzo_ = FHIRHelpers_4_0_001.Instance.ToString(context, bzzzzzn_);
            string bzzzzzp_ = context.Operators.Concatenate("http://hl7.org/fhir/us/qicore/StructureDefinition/", url);
            bool? bzzzzzq_ = context.Operators.Equal(bzzzzzo_, bzzzzzp_);

            return bzzzzzq_;
        };
        IEnumerable<Extension> bzzzzzi_ = context.Operators.Where<Extension>((IEnumerable<Extension>)bzzzzzg_, bzzzzzh_);
        Extension bzzzzzj_(Extension E) =>
            E;
        IEnumerable<Extension> bzzzzzk_ = context.Operators.Select<Extension, Extension>(bzzzzzi_, bzzzzzj_);
        IEnumerable<Extension> bzzzzzl_ = context.Operators.Distinct<Extension>(bzzzzzk_);

        return bzzzzzl_;
    }


    [CqlExpressionDefinition("GetModifierExtension")]
    public Extension GetModifierExtension(CqlContext context, DomainResource domainResource, string url)
    {
        IEnumerable<Extension> bzzzzzr_ = this.GetModifierExtensions(context, domainResource, url);
        Extension bzzzzzs_ = context.Operators.SingletonFrom<Extension>(bzzzzzr_);

        return bzzzzzs_;
    }


    [CqlExpressionDefinition("Medical or Patient Reason for Not Communicating Level of Severity of Retinopathy")]
    public IEnumerable<Communication> Medical_or_Patient_Reason_for_Not_Communicating_Level_of_Severity_of_Retinopathy(CqlContext context)
    {
        PropertyInfo bzzzzzt_ = typeof(Communication).GetProperty("ReasonCode");
        CqlValueSet bzzzzzu_ = this.Level_of_Severity_of_Retinopathy_Findings(context);
        IEnumerable<Communication> bzzzzzv_ = context.Operators.Retrieve<Communication>(new RetrieveParameters(bzzzzzt_, bzzzzzu_, default, "http://hl7.org/fhir/StructureDefinition/Communication"));
        IEnumerable<Communication> bzzzzzw_(Communication LevelOfSeverityNotCommunicated)
        {
            IEnumerable<Encounter> czzzzza_ = this.Diabetic_Retinopathy_Encounter(context);
            bool? czzzzzb_(Encounter EncounterDiabeticRetinopathy)
            {
                Period czzzzzf_ = EncounterDiabeticRetinopathy?.Period;
                CqlInterval<CqlDateTime> czzzzzg_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, czzzzzf_);
                Extension czzzzzh_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.GetExtension(context, LevelOfSeverityNotCommunicated, "qicore-recorded");
                DataType czzzzzi_ = czzzzzh_?.Value;
                CqlInterval<CqlDateTime> czzzzzj_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, czzzzzi_ as Period);
                bool? czzzzzk_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(czzzzzg_, czzzzzj_, default);

                return czzzzzk_;
            };
            IEnumerable<Encounter> czzzzzc_ = context.Operators.Where<Encounter>(czzzzza_, czzzzzb_);
            Communication czzzzzd_(Encounter EncounterDiabeticRetinopathy) =>
                LevelOfSeverityNotCommunicated;
            IEnumerable<Communication> czzzzze_ = context.Operators.Select<Encounter, Communication>(czzzzzc_, czzzzzd_);

            return czzzzze_;
        };
        IEnumerable<Communication> bzzzzzx_ = context.Operators.SelectMany<Communication, Communication>(bzzzzzv_, bzzzzzw_);
        bool? bzzzzzy_(Communication LevelOfSeverityNotCommunicated)
        {
            Code<EventStatus> czzzzzl_ = LevelOfSeverityNotCommunicated?.StatusElement;
            string czzzzzm_ = FHIRHelpers_4_0_001.Instance.ToString(context, czzzzzl_);
            bool? czzzzzn_ = context.Operators.Equal(czzzzzm_, "not-done");
            Extension czzzzzo_ = this.GetModifierExtension(context, LevelOfSeverityNotCommunicated, "qicore-notDone");
            DataType czzzzzp_ = czzzzzo_?.Value;
            bool? czzzzzq_ = FHIRHelpers_4_0_001.Instance.ToBoolean(context, czzzzzp_ as FhirBoolean);
            bool? czzzzzr_ = context.Operators.IsTrue(czzzzzq_);
            bool? czzzzzs_ = context.Operators.And(czzzzzn_, czzzzzr_);
            CodeableConcept czzzzzt_ = LevelOfSeverityNotCommunicated?.StatusReason;
            CqlConcept czzzzzu_ = FHIRHelpers_4_0_001.Instance.ToConcept(context, czzzzzt_);
            CqlValueSet czzzzzv_ = this.Medical_Reason(context);
            bool? czzzzzw_ = context.Operators.ConceptInValueSet(czzzzzu_, czzzzzv_);
            CqlConcept czzzzzy_ = FHIRHelpers_4_0_001.Instance.ToConcept(context, czzzzzt_);
            CqlValueSet czzzzzz_ = this.Patient_Reason(context);
            bool? dzzzzza_ = context.Operators.ConceptInValueSet(czzzzzy_, czzzzzz_);
            bool? dzzzzzb_ = context.Operators.Or(czzzzzw_, dzzzzza_);
            bool? dzzzzzc_ = context.Operators.And(czzzzzs_, dzzzzzb_);

            return dzzzzzc_;
        };
        IEnumerable<Communication> bzzzzzz_ = context.Operators.Where<Communication>(bzzzzzx_, bzzzzzy_);

        return bzzzzzz_;
    }


    [CqlExpressionDefinition("Medical or Patient Reason for Not Communicating Absence of Macular Edema")]
    public IEnumerable<Communication> Medical_or_Patient_Reason_for_Not_Communicating_Absence_of_Macular_Edema(CqlContext context)
    {
        PropertyInfo dzzzzzd_ = typeof(Communication).GetProperty("ReasonCode");
        CqlCode dzzzzze_ = this.Macular_edema_absent__situation_(context);
        IEnumerable<CqlCode> dzzzzzf_ = context.Operators.ToList<CqlCode>(dzzzzze_);
        IEnumerable<Communication> dzzzzzg_ = context.Operators.Retrieve<Communication>(new RetrieveParameters(dzzzzzd_, default, dzzzzzf_, "http://hl7.org/fhir/StructureDefinition/Communication"));
        IEnumerable<Communication> dzzzzzh_(Communication MacularEdemaAbsentNotCommunicated)
        {
            IEnumerable<Encounter> dzzzzzl_ = this.Diabetic_Retinopathy_Encounter(context);
            bool? dzzzzzm_(Encounter EncounterDiabeticRetinopathy)
            {
                Period dzzzzzq_ = EncounterDiabeticRetinopathy?.Period;
                CqlInterval<CqlDateTime> dzzzzzr_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, dzzzzzq_);
                Extension dzzzzzs_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.GetExtension(context, MacularEdemaAbsentNotCommunicated, "qicore-recorded");
                DataType dzzzzzt_ = dzzzzzs_?.Value;
                CqlInterval<CqlDateTime> dzzzzzu_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, dzzzzzt_ as Period);
                bool? dzzzzzv_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(dzzzzzr_, dzzzzzu_, default);

                return dzzzzzv_;
            };
            IEnumerable<Encounter> dzzzzzn_ = context.Operators.Where<Encounter>(dzzzzzl_, dzzzzzm_);
            Communication dzzzzzo_(Encounter EncounterDiabeticRetinopathy) =>
                MacularEdemaAbsentNotCommunicated;
            IEnumerable<Communication> dzzzzzp_ = context.Operators.Select<Encounter, Communication>(dzzzzzn_, dzzzzzo_);

            return dzzzzzp_;
        };
        IEnumerable<Communication> dzzzzzi_ = context.Operators.SelectMany<Communication, Communication>(dzzzzzg_, dzzzzzh_);
        bool? dzzzzzj_(Communication MacularEdemaAbsentNotCommunicated)
        {
            Code<EventStatus> dzzzzzw_ = MacularEdemaAbsentNotCommunicated?.StatusElement;
            string dzzzzzx_ = FHIRHelpers_4_0_001.Instance.ToString(context, dzzzzzw_);
            bool? dzzzzzy_ = context.Operators.Equal(dzzzzzx_, "not-done");
            Extension dzzzzzz_ = this.GetModifierExtension(context, MacularEdemaAbsentNotCommunicated, "qicore-notDone");
            DataType ezzzzza_ = dzzzzzz_?.Value;
            bool? ezzzzzb_ = FHIRHelpers_4_0_001.Instance.ToBoolean(context, ezzzzza_ as FhirBoolean);
            bool? ezzzzzc_ = context.Operators.IsTrue(ezzzzzb_);
            bool? ezzzzzd_ = context.Operators.And(dzzzzzy_, ezzzzzc_);
            CodeableConcept ezzzzze_ = MacularEdemaAbsentNotCommunicated?.StatusReason;
            CqlConcept ezzzzzf_ = FHIRHelpers_4_0_001.Instance.ToConcept(context, ezzzzze_);
            CqlValueSet ezzzzzg_ = this.Medical_Reason(context);
            bool? ezzzzzh_ = context.Operators.ConceptInValueSet(ezzzzzf_, ezzzzzg_);
            CqlConcept ezzzzzj_ = FHIRHelpers_4_0_001.Instance.ToConcept(context, ezzzzze_);
            CqlValueSet ezzzzzk_ = this.Patient_Reason(context);
            bool? ezzzzzl_ = context.Operators.ConceptInValueSet(ezzzzzj_, ezzzzzk_);
            bool? ezzzzzm_ = context.Operators.Or(ezzzzzh_, ezzzzzl_);
            bool? ezzzzzn_ = context.Operators.And(ezzzzzd_, ezzzzzm_);

            return ezzzzzn_;
        };
        IEnumerable<Communication> dzzzzzk_ = context.Operators.Where<Communication>(dzzzzzi_, dzzzzzj_);

        return dzzzzzk_;
    }


    [CqlExpressionDefinition("Medical or Patient Reason for Not Communicating Presence of Macular Edema")]
    public IEnumerable<Communication> Medical_or_Patient_Reason_for_Not_Communicating_Presence_of_Macular_Edema(CqlContext context)
    {
        PropertyInfo ezzzzzo_ = typeof(Communication).GetProperty("ReasonCode");
        CqlValueSet ezzzzzp_ = this.Macular_Edema_Findings_Present(context);
        IEnumerable<Communication> ezzzzzq_ = context.Operators.Retrieve<Communication>(new RetrieveParameters(ezzzzzo_, ezzzzzp_, default, "http://hl7.org/fhir/StructureDefinition/Communication"));
        IEnumerable<Communication> ezzzzzr_(Communication MacularEdemaPresentNotCommunicated)
        {
            IEnumerable<Encounter> ezzzzzv_ = this.Diabetic_Retinopathy_Encounter(context);
            bool? ezzzzzw_(Encounter EncounterDiabeticRetinopathy)
            {
                Period fzzzzza_ = EncounterDiabeticRetinopathy?.Period;
                CqlInterval<CqlDateTime> fzzzzzb_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, fzzzzza_);
                Extension fzzzzzc_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.GetExtension(context, MacularEdemaPresentNotCommunicated, "qicore-recorded");
                DataType fzzzzzd_ = fzzzzzc_?.Value;
                CqlInterval<CqlDateTime> fzzzzze_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, fzzzzzd_ as Period);
                bool? fzzzzzf_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(fzzzzzb_, fzzzzze_, default);

                return fzzzzzf_;
            };
            IEnumerable<Encounter> ezzzzzx_ = context.Operators.Where<Encounter>(ezzzzzv_, ezzzzzw_);
            Communication ezzzzzy_(Encounter EncounterDiabeticRetinopathy) =>
                MacularEdemaPresentNotCommunicated;
            IEnumerable<Communication> ezzzzzz_ = context.Operators.Select<Encounter, Communication>(ezzzzzx_, ezzzzzy_);

            return ezzzzzz_;
        };
        IEnumerable<Communication> ezzzzzs_ = context.Operators.SelectMany<Communication, Communication>(ezzzzzq_, ezzzzzr_);
        bool? ezzzzzt_(Communication MacularEdemaPresentNotCommunicated)
        {
            Code<EventStatus> fzzzzzg_ = MacularEdemaPresentNotCommunicated?.StatusElement;
            string fzzzzzh_ = FHIRHelpers_4_0_001.Instance.ToString(context, fzzzzzg_);
            bool? fzzzzzi_ = context.Operators.Equal(fzzzzzh_, "not-done");
            Extension fzzzzzj_ = this.GetModifierExtension(context, MacularEdemaPresentNotCommunicated, "qicore-notDone");
            DataType fzzzzzk_ = fzzzzzj_?.Value;
            bool? fzzzzzl_ = FHIRHelpers_4_0_001.Instance.ToBoolean(context, fzzzzzk_ as FhirBoolean);
            bool? fzzzzzm_ = context.Operators.IsTrue(fzzzzzl_);
            bool? fzzzzzn_ = context.Operators.And(fzzzzzi_, fzzzzzm_);
            CodeableConcept fzzzzzo_ = MacularEdemaPresentNotCommunicated?.StatusReason;
            CqlConcept fzzzzzp_ = FHIRHelpers_4_0_001.Instance.ToConcept(context, fzzzzzo_);
            CqlValueSet fzzzzzq_ = this.Medical_Reason(context);
            bool? fzzzzzr_ = context.Operators.ConceptInValueSet(fzzzzzp_, fzzzzzq_);
            CqlConcept fzzzzzt_ = FHIRHelpers_4_0_001.Instance.ToConcept(context, fzzzzzo_);
            CqlValueSet fzzzzzu_ = this.Patient_Reason(context);
            bool? fzzzzzv_ = context.Operators.ConceptInValueSet(fzzzzzt_, fzzzzzu_);
            bool? fzzzzzw_ = context.Operators.Or(fzzzzzr_, fzzzzzv_);
            bool? fzzzzzx_ = context.Operators.And(fzzzzzn_, fzzzzzw_);

            return fzzzzzx_;
        };
        IEnumerable<Communication> ezzzzzu_ = context.Operators.Where<Communication>(ezzzzzs_, ezzzzzt_);

        return ezzzzzu_;
    }


    [CqlExpressionDefinition("Denominator Exceptions")]
    public bool? Denominator_Exceptions(CqlContext context)
    {
        IEnumerable<Communication> fzzzzzy_ = this.Medical_or_Patient_Reason_for_Not_Communicating_Level_of_Severity_of_Retinopathy(context);
        bool? fzzzzzz_ = context.Operators.Exists<Communication>(fzzzzzy_);
        IEnumerable<Communication> gzzzzza_ = this.Medical_or_Patient_Reason_for_Not_Communicating_Absence_of_Macular_Edema(context);
        bool? gzzzzzb_ = context.Operators.Exists<Communication>(gzzzzza_);
        bool? gzzzzzc_ = context.Operators.Or(fzzzzzz_, gzzzzzb_);
        IEnumerable<Communication> gzzzzzd_ = this.Medical_or_Patient_Reason_for_Not_Communicating_Presence_of_Macular_Edema(context);
        bool? gzzzzze_ = context.Operators.Exists<Communication>(gzzzzzd_);
        bool? gzzzzzf_ = context.Operators.Or(gzzzzzc_, gzzzzze_);

        return gzzzzzf_;
    }


    [CqlExpressionDefinition("Initial Population")]
    public bool? Initial_Population(CqlContext context)
    {
        Patient gzzzzzg_ = this.Patient(context);
        Date gzzzzzh_ = gzzzzzg_?.BirthDateElement;
        string gzzzzzi_ = gzzzzzh_?.Value;
        CqlDateTime gzzzzzj_ = context.Operators.ConvertStringToDateTime(gzzzzzi_);
        CqlInterval<CqlDateTime> gzzzzzk_ = this.Measurement_Period(context);
        CqlDateTime gzzzzzl_ = context.Operators.Start(gzzzzzk_);
        int? gzzzzzm_ = context.Operators.CalculateAgeAt(gzzzzzj_, gzzzzzl_, "year");
        bool? gzzzzzn_ = context.Operators.GreaterOrEqual(gzzzzzm_, 18);
        IEnumerable<Encounter> gzzzzzo_ = this.Diabetic_Retinopathy_Encounter(context);
        bool? gzzzzzp_ = context.Operators.Exists<Encounter>(gzzzzzo_);
        bool? gzzzzzq_ = context.Operators.And(gzzzzzn_, gzzzzzp_);

        return gzzzzzq_;
    }


    [CqlExpressionDefinition("Macular Exam Performed")]
    public IEnumerable<Observation> Macular_Exam_Performed(CqlContext context)
    {
        CqlValueSet gzzzzzr_ = this.Macular_Exam(context);
        IEnumerable<Observation> gzzzzzs_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, gzzzzzr_, default, "http://hl7.org/fhir/StructureDefinition/Observation"));
        IEnumerable<Observation> gzzzzzt_(Observation MacularExam)
        {
            IEnumerable<Encounter> gzzzzzx_ = this.Diabetic_Retinopathy_Encounter(context);
            bool? gzzzzzy_(Encounter EncounterDiabeticRetinopathy)
            {
                Period hzzzzzc_ = EncounterDiabeticRetinopathy?.Period;
                CqlInterval<CqlDateTime> hzzzzzd_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, hzzzzzc_);
                DataType hzzzzze_ = MacularExam?.Effective;
                CqlInterval<CqlDateTime> hzzzzzf_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, hzzzzze_);
                bool? hzzzzzg_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(hzzzzzd_, hzzzzzf_, default);

                return hzzzzzg_;
            };
            IEnumerable<Encounter> gzzzzzz_ = context.Operators.Where<Encounter>(gzzzzzx_, gzzzzzy_);
            Observation hzzzzza_(Encounter EncounterDiabeticRetinopathy) =>
                MacularExam;
            IEnumerable<Observation> hzzzzzb_ = context.Operators.Select<Encounter, Observation>(gzzzzzz_, hzzzzza_);

            return hzzzzzb_;
        };
        IEnumerable<Observation> gzzzzzu_ = context.Operators.SelectMany<Observation, Observation>(gzzzzzs_, gzzzzzt_);
        bool? gzzzzzv_(Observation MacularExam)
        {
            Code<ObservationStatus> hzzzzzh_ = MacularExam?.StatusElement;
            string hzzzzzi_ = FHIRHelpers_4_0_001.Instance.ToString(context, hzzzzzh_);
            string[] hzzzzzj_ = [
                "final",
                "amended",
                "corrected",
            ];
            bool? hzzzzzk_ = context.Operators.In<string>(hzzzzzi_, hzzzzzj_ as IEnumerable<string>);
            DataType hzzzzzl_ = MacularExam?.Value;
            bool? hzzzzzm_ = context.Operators.Not((bool?)(hzzzzzl_ is null));
            bool? hzzzzzn_ = context.Operators.And(hzzzzzk_, hzzzzzm_);

            return hzzzzzn_;
        };
        IEnumerable<Observation> gzzzzzw_ = context.Operators.Where<Observation>(gzzzzzu_, gzzzzzv_);

        return gzzzzzw_;
    }


    [CqlExpressionDefinition("Denominator")]
    public bool? Denominator(CqlContext context)
    {
        bool? hzzzzzo_ = this.Initial_Population(context);
        IEnumerable<Observation> hzzzzzp_ = this.Macular_Exam_Performed(context);
        bool? hzzzzzq_ = context.Operators.Exists<Observation>(hzzzzzp_);
        bool? hzzzzzr_ = context.Operators.And(hzzzzzo_, hzzzzzq_);

        return hzzzzzr_;
    }


    [CqlExpressionDefinition("Level of Severity of Retinopathy Findings Communicated")]
    public IEnumerable<Communication> Level_of_Severity_of_Retinopathy_Findings_Communicated(CqlContext context)
    {
        PropertyInfo hzzzzzs_ = typeof(Communication).GetProperty("ReasonCode");
        CqlValueSet hzzzzzt_ = this.Level_of_Severity_of_Retinopathy_Findings(context);
        IEnumerable<Communication> hzzzzzu_ = context.Operators.Retrieve<Communication>(new RetrieveParameters(hzzzzzs_, hzzzzzt_, default, "http://hl7.org/fhir/StructureDefinition/Communication"));
        IEnumerable<Communication> hzzzzzv_(Communication LevelOfSeverityCommunicated)
        {
            IEnumerable<Encounter> hzzzzzz_ = this.Diabetic_Retinopathy_Encounter(context);
            bool? izzzzza_(Encounter EncounterDiabeticRetinopathy)
            {
                FhirDateTime izzzzze_ = LevelOfSeverityCommunicated?.SentElement;
                CqlDateTime izzzzzf_ = FHIRHelpers_4_0_001.Instance.ToDateTime(context, izzzzze_);
                Period izzzzzg_ = EncounterDiabeticRetinopathy?.Period;
                CqlInterval<CqlDateTime> izzzzzh_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, izzzzzg_);
                CqlDateTime izzzzzi_ = context.Operators.Start(izzzzzh_);
                bool? izzzzzj_ = context.Operators.After(izzzzzf_, izzzzzi_, default);

                return izzzzzj_;
            };
            IEnumerable<Encounter> izzzzzb_ = context.Operators.Where<Encounter>(hzzzzzz_, izzzzza_);
            Communication izzzzzc_(Encounter EncounterDiabeticRetinopathy) =>
                LevelOfSeverityCommunicated;
            IEnumerable<Communication> izzzzzd_ = context.Operators.Select<Encounter, Communication>(izzzzzb_, izzzzzc_);

            return izzzzzd_;
        };
        IEnumerable<Communication> hzzzzzw_ = context.Operators.SelectMany<Communication, Communication>(hzzzzzu_, hzzzzzv_);
        bool? hzzzzzx_(Communication LevelOfSeverityCommunicated)
        {
            Code<EventStatus> izzzzzk_ = LevelOfSeverityCommunicated?.StatusElement;
            string izzzzzl_ = FHIRHelpers_4_0_001.Instance.ToString(context, izzzzzk_);
            bool? izzzzzm_ = context.Operators.Equal(izzzzzl_, "completed");

            return izzzzzm_;
        };
        IEnumerable<Communication> hzzzzzy_ = context.Operators.Where<Communication>(hzzzzzw_, hzzzzzx_);

        return hzzzzzy_;
    }


    [CqlExpressionDefinition("Macular Edema Absence Communicated")]
    public IEnumerable<Communication> Macular_Edema_Absence_Communicated(CqlContext context)
    {
        PropertyInfo izzzzzn_ = typeof(Communication).GetProperty("ReasonCode");
        CqlCode izzzzzo_ = this.Macular_edema_absent__situation_(context);
        IEnumerable<CqlCode> izzzzzp_ = context.Operators.ToList<CqlCode>(izzzzzo_);
        IEnumerable<Communication> izzzzzq_ = context.Operators.Retrieve<Communication>(new RetrieveParameters(izzzzzn_, default, izzzzzp_, "http://hl7.org/fhir/StructureDefinition/Communication"));
        IEnumerable<Communication> izzzzzr_(Communication MacularEdemaAbsentCommunicated)
        {
            IEnumerable<Encounter> izzzzzv_ = this.Diabetic_Retinopathy_Encounter(context);
            bool? izzzzzw_(Encounter EncounterDiabeticRetinopathy)
            {
                FhirDateTime jzzzzza_ = MacularEdemaAbsentCommunicated?.SentElement;
                CqlDateTime jzzzzzb_ = FHIRHelpers_4_0_001.Instance.ToDateTime(context, jzzzzza_);
                Period jzzzzzc_ = EncounterDiabeticRetinopathy?.Period;
                CqlInterval<CqlDateTime> jzzzzzd_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, jzzzzzc_);
                CqlDateTime jzzzzze_ = context.Operators.Start(jzzzzzd_);
                bool? jzzzzzf_ = context.Operators.After(jzzzzzb_, jzzzzze_, default);

                return jzzzzzf_;
            };
            IEnumerable<Encounter> izzzzzx_ = context.Operators.Where<Encounter>(izzzzzv_, izzzzzw_);
            Communication izzzzzy_(Encounter EncounterDiabeticRetinopathy) =>
                MacularEdemaAbsentCommunicated;
            IEnumerable<Communication> izzzzzz_ = context.Operators.Select<Encounter, Communication>(izzzzzx_, izzzzzy_);

            return izzzzzz_;
        };
        IEnumerable<Communication> izzzzzs_ = context.Operators.SelectMany<Communication, Communication>(izzzzzq_, izzzzzr_);
        bool? izzzzzt_(Communication MacularEdemaAbsentCommunicated)
        {
            Code<EventStatus> jzzzzzg_ = MacularEdemaAbsentCommunicated?.StatusElement;
            string jzzzzzh_ = FHIRHelpers_4_0_001.Instance.ToString(context, jzzzzzg_);
            bool? jzzzzzi_ = context.Operators.Equal(jzzzzzh_, "completed");

            return jzzzzzi_;
        };
        IEnumerable<Communication> izzzzzu_ = context.Operators.Where<Communication>(izzzzzs_, izzzzzt_);

        return izzzzzu_;
    }


    [CqlExpressionDefinition("Macular Edema Presence Communicated")]
    public IEnumerable<Communication> Macular_Edema_Presence_Communicated(CqlContext context)
    {
        PropertyInfo jzzzzzj_ = typeof(Communication).GetProperty("ReasonCode");
        CqlValueSet jzzzzzk_ = this.Macular_Edema_Findings_Present(context);
        IEnumerable<Communication> jzzzzzl_ = context.Operators.Retrieve<Communication>(new RetrieveParameters(jzzzzzj_, jzzzzzk_, default, "http://hl7.org/fhir/StructureDefinition/Communication"));
        IEnumerable<Communication> jzzzzzm_(Communication MacularEdemaPresentCommunicated)
        {
            IEnumerable<Encounter> jzzzzzq_ = this.Diabetic_Retinopathy_Encounter(context);
            bool? jzzzzzr_(Encounter EncounterDiabeticRetinopathy)
            {
                FhirDateTime jzzzzzv_ = MacularEdemaPresentCommunicated?.SentElement;
                CqlDateTime jzzzzzw_ = FHIRHelpers_4_0_001.Instance.ToDateTime(context, jzzzzzv_);
                Period jzzzzzx_ = EncounterDiabeticRetinopathy?.Period;
                CqlInterval<CqlDateTime> jzzzzzy_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, jzzzzzx_);
                CqlDateTime jzzzzzz_ = context.Operators.Start(jzzzzzy_);
                bool? kzzzzza_ = context.Operators.After(jzzzzzw_, jzzzzzz_, default);

                return kzzzzza_;
            };
            IEnumerable<Encounter> jzzzzzs_ = context.Operators.Where<Encounter>(jzzzzzq_, jzzzzzr_);
            Communication jzzzzzt_(Encounter EncounterDiabeticRetinopathy) =>
                MacularEdemaPresentCommunicated;
            IEnumerable<Communication> jzzzzzu_ = context.Operators.Select<Encounter, Communication>(jzzzzzs_, jzzzzzt_);

            return jzzzzzu_;
        };
        IEnumerable<Communication> jzzzzzn_ = context.Operators.SelectMany<Communication, Communication>(jzzzzzl_, jzzzzzm_);
        bool? jzzzzzo_(Communication MacularEdemaPresentCommunicated)
        {
            Code<EventStatus> kzzzzzb_ = MacularEdemaPresentCommunicated?.StatusElement;
            string kzzzzzc_ = FHIRHelpers_4_0_001.Instance.ToString(context, kzzzzzb_);
            bool? kzzzzzd_ = context.Operators.Equal(kzzzzzc_, "completed");

            return kzzzzzd_;
        };
        IEnumerable<Communication> jzzzzzp_ = context.Operators.Where<Communication>(jzzzzzn_, jzzzzzo_);

        return jzzzzzp_;
    }


    [CqlExpressionDefinition("Results of Dilated Macular or Fundus Exam Communicated")]
    public bool? Results_of_Dilated_Macular_or_Fundus_Exam_Communicated(CqlContext context)
    {
        IEnumerable<Communication> kzzzzze_ = this.Level_of_Severity_of_Retinopathy_Findings_Communicated(context);
        bool? kzzzzzf_ = context.Operators.Exists<Communication>(kzzzzze_);
        IEnumerable<Communication> kzzzzzg_ = this.Macular_Edema_Absence_Communicated(context);
        bool? kzzzzzh_ = context.Operators.Exists<Communication>(kzzzzzg_);
        IEnumerable<Communication> kzzzzzi_ = this.Macular_Edema_Presence_Communicated(context);
        bool? kzzzzzj_ = context.Operators.Exists<Communication>(kzzzzzi_);
        bool? kzzzzzk_ = context.Operators.Or(kzzzzzh_, kzzzzzj_);
        bool? kzzzzzl_ = context.Operators.And(kzzzzzf_, kzzzzzk_);

        return kzzzzzl_;
    }


    [CqlExpressionDefinition("Numerator")]
    public bool? Numerator(CqlContext context)
    {
        IEnumerable<Communication> kzzzzzm_ = this.Level_of_Severity_of_Retinopathy_Findings_Communicated(context);
        bool? kzzzzzn_ = context.Operators.Exists<Communication>(kzzzzzm_);
        IEnumerable<Communication> kzzzzzo_ = this.Macular_Edema_Absence_Communicated(context);
        bool? kzzzzzp_ = context.Operators.Exists<Communication>(kzzzzzo_);
        IEnumerable<Communication> kzzzzzq_ = this.Macular_Edema_Presence_Communicated(context);
        bool? kzzzzzr_ = context.Operators.Exists<Communication>(kzzzzzq_);
        bool? kzzzzzs_ = context.Operators.Or(kzzzzzp_, kzzzzzr_);
        bool? kzzzzzt_ = context.Operators.And(kzzzzzn_, kzzzzzs_);

        return kzzzzzt_;
    }


    #endregion Expressions

}
