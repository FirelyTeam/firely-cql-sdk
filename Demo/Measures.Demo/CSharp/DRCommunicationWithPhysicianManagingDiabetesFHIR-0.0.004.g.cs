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
      new CqlCodeSystem("http://loinc.org", null,
          _Birth_date);

    [CqlCodeSystemDefinition("SNOMEDCT")]
    public CqlCodeSystem SNOMEDCT(CqlContext _) => _SNOMEDCT;
    private static readonly CqlCodeSystem _SNOMEDCT =
      new CqlCodeSystem("http://snomed.info/sct", null,
          _Healthcare_professional__occupation_,
          _Macular_edema_absent__situation_,
          _Medical_practitioner__occupation_,
          _Ophthalmologist__occupation_,
          _Optometrist__occupation_,
          _Physician__occupation_);

    #endregion CodeSystems

    #region Parameters

    [CqlParameterDefinition("Measurement Period")]
    public CqlInterval<CqlDateTime> Measurement_Period(CqlContext context)
    {
        object yzn_ = context.ResolveParameter("DRCommunicationWithPhysicianManagingDiabetesFHIR-0.0.004", "Measurement Period", null);

        return (CqlInterval<CqlDateTime>)yzn_;
    }


    #endregion Parameters

    #region Expressions

    [CqlExpressionDefinition("Patient")]
    public Patient Patient(CqlContext context)
    {
        IEnumerable<Patient> yzo_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/StructureDefinition/Patient"));
        Patient yzp_ = context.Operators.SingletonFrom<Patient>(yzo_);

        return yzp_;
    }


    [CqlExpressionDefinition("SDE Ethnicity")]
    public IEnumerable<Coding> SDE_Ethnicity(CqlContext context)
    {
        IEnumerable<Coding> yzq_ = SupplementalDataElementsFHIR4_2_0_000.Instance.SDE_Ethnicity(context);

        return yzq_;
    }


    [CqlExpressionDefinition("SDE Payer")]
    public IEnumerable<(CqlTupleMetadata, CodeableConcept code, Period period)?> SDE_Payer(CqlContext context)
    {
        IEnumerable<(CqlTupleMetadata, CodeableConcept code, Period period)?> yzr_ = SupplementalDataElementsFHIR4_2_0_000.Instance.SDE_Payer(context);

        return yzr_;
    }


    [CqlExpressionDefinition("SDE Race")]
    public IEnumerable<Coding> SDE_Race(CqlContext context)
    {
        IEnumerable<Coding> yzs_ = SupplementalDataElementsFHIR4_2_0_000.Instance.SDE_Race(context);

        return yzs_;
    }


    [CqlExpressionDefinition("SDE Sex")]
    public CqlCode SDE_Sex(CqlContext context)
    {
        CqlCode yzt_ = SupplementalDataElementsFHIR4_2_0_000.Instance.SDE_Sex(context);

        return yzt_;
    }


    [CqlExpressionDefinition("Qualifying Encounter During Measurement Period")]
    public IEnumerable<Encounter> Qualifying_Encounter_During_Measurement_Period(CqlContext context)
    {
        CqlValueSet yzu_ = this.Office_Visit(context);
        IEnumerable<Encounter> yzv_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, yzu_, default, "http://hl7.org/fhir/StructureDefinition/Encounter"));
        CqlValueSet yzw_ = this.Ophthalmological_Services(context);
        IEnumerable<Encounter> yzx_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, yzw_, default, "http://hl7.org/fhir/StructureDefinition/Encounter"));
        IEnumerable<Encounter> yzy_ = context.Operators.Union<Encounter>(yzv_, yzx_);
        CqlValueSet yzz_ = this.Outpatient_Consultation(context);
        IEnumerable<Encounter> zza_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, yzz_, default, "http://hl7.org/fhir/StructureDefinition/Encounter"));
        CqlValueSet zzb_ = this.Care_Services_in_Long_Term_Residential_Facility(context);
        IEnumerable<Encounter> zzc_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, zzb_, default, "http://hl7.org/fhir/StructureDefinition/Encounter"));
        IEnumerable<Encounter> zzd_ = context.Operators.Union<Encounter>(zza_, zzc_);
        IEnumerable<Encounter> zze_ = context.Operators.Union<Encounter>(yzy_, zzd_);
        CqlValueSet zzf_ = this.Nursing_Facility_Visit(context);
        IEnumerable<Encounter> zzg_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, zzf_, default, "http://hl7.org/fhir/StructureDefinition/Encounter"));
        IEnumerable<Encounter> zzh_ = context.Operators.Union<Encounter>(zze_, zzg_);
        bool? zzi_(Encounter QualifyingEncounter)
        {
            CqlInterval<CqlDateTime> zzk_ = this.Measurement_Period(context);
            Period zzl_ = QualifyingEncounter?.Period;
            CqlInterval<CqlDateTime> zzm_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, zzl_);
            bool? zzn_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(zzk_, zzm_, default);
            Code<Encounter.EncounterStatus> zzo_ = QualifyingEncounter?.StatusElement;
            string zzp_ = FHIRHelpers_4_0_001.Instance.ToString(context, zzo_);
            bool? zzq_ = context.Operators.Equal(zzp_, "finished");
            bool? zzr_ = context.Operators.And(zzn_, zzq_);

            return zzr_;
        };
        IEnumerable<Encounter> zzj_ = context.Operators.Where<Encounter>(zzh_, zzi_);

        return zzj_;
    }


    [CqlExpressionDefinition("Diabetic Retinopathy Encounter")]
    public IEnumerable<Encounter> Diabetic_Retinopathy_Encounter(CqlContext context)
    {
        IEnumerable<Encounter> zzs_ = this.Qualifying_Encounter_During_Measurement_Period(context);
        IEnumerable<Encounter> zzt_(Encounter ValidQualifyingEncounter)
        {
            CqlValueSet zzv_ = this.Diabetic_Retinopathy(context);
            IEnumerable<Condition> zzw_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, zzv_, default, "http://hl7.org/fhir/StructureDefinition/Condition"));
            bool? zzx_(Condition DiabeticRetinopathy)
            {
                CodeableConcept azzb_ = DiabeticRetinopathy?.ClinicalStatus;
                CqlConcept azzc_ = FHIRHelpers_4_0_001.Instance.ToConcept(context, azzb_);
                CqlCode azzd_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.active(context);
                CqlConcept azze_ = context.Operators.ConvertCodeToConcept(azzd_);
                bool? azzf_ = context.Operators.Equivalent(azzc_, azze_);
                CqlInterval<CqlDateTime> azzg_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Prevalence_Period(context, DiabeticRetinopathy);
                Period azzh_ = ValidQualifyingEncounter?.Period;
                CqlInterval<CqlDateTime> azzi_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, azzh_);
                bool? azzj_ = context.Operators.Overlaps(azzg_, azzi_, default);
                bool? azzk_ = context.Operators.And(azzf_, azzj_);

                return azzk_;
            };
            IEnumerable<Condition> zzy_ = context.Operators.Where<Condition>(zzw_, zzx_);
            Encounter zzz_(Condition DiabeticRetinopathy) =>
                ValidQualifyingEncounter;
            IEnumerable<Encounter> azza_ = context.Operators.Select<Condition, Encounter>(zzy_, zzz_);

            return azza_;
        };
        IEnumerable<Encounter> zzu_ = context.Operators.SelectMany<Encounter, Encounter>(zzs_, zzt_);

        return zzu_;
    }


    [CqlExpressionDefinition("GetModifierExtensions")]
    public IEnumerable<Extension> GetModifierExtensions(CqlContext context, DomainResource domainResource, string url)
    {
        List<Extension> azzl_ = domainResource?.ModifierExtension;
        bool? azzm_(Extension E)
        {
            string azzr_ = E?.Url;
            FhirUri azzs_ = context.Operators.Convert<FhirUri>(azzr_);
            string azzt_ = FHIRHelpers_4_0_001.Instance.ToString(context, azzs_);
            string azzu_ = context.Operators.Concatenate("http://hl7.org/fhir/us/qicore/StructureDefinition/", url);
            bool? azzv_ = context.Operators.Equal(azzt_, azzu_);

            return azzv_;
        };
        IEnumerable<Extension> azzn_ = context.Operators.Where<Extension>((IEnumerable<Extension>)azzl_, azzm_);
        Extension azzo_(Extension E) =>
            E;
        IEnumerable<Extension> azzp_ = context.Operators.Select<Extension, Extension>(azzn_, azzo_);
        IEnumerable<Extension> azzq_ = context.Operators.Distinct<Extension>(azzp_);

        return azzq_;
    }


    [CqlExpressionDefinition("GetModifierExtension")]
    public Extension GetModifierExtension(CqlContext context, DomainResource domainResource, string url)
    {
        IEnumerable<Extension> azzw_ = this.GetModifierExtensions(context, domainResource, url);
        Extension azzx_ = context.Operators.SingletonFrom<Extension>(azzw_);

        return azzx_;
    }


    [CqlExpressionDefinition("Medical or Patient Reason for Not Communicating Level of Severity of Retinopathy")]
    public IEnumerable<Communication> Medical_or_Patient_Reason_for_Not_Communicating_Level_of_Severity_of_Retinopathy(CqlContext context)
    {
        PropertyInfo azzy_ = typeof(Communication).GetProperty("ReasonCode");
        CqlValueSet azzz_ = this.Level_of_Severity_of_Retinopathy_Findings(context);
        IEnumerable<Communication> bzza_ = context.Operators.Retrieve<Communication>(new RetrieveParameters(azzy_, azzz_, default, "http://hl7.org/fhir/StructureDefinition/Communication"));
        IEnumerable<Communication> bzzb_(Communication LevelOfSeverityNotCommunicated)
        {
            IEnumerable<Encounter> bzzf_ = this.Diabetic_Retinopathy_Encounter(context);
            bool? bzzg_(Encounter EncounterDiabeticRetinopathy)
            {
                Period bzzk_ = EncounterDiabeticRetinopathy?.Period;
                CqlInterval<CqlDateTime> bzzl_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, bzzk_);
                Extension bzzm_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.GetExtension(context, LevelOfSeverityNotCommunicated, "qicore-recorded");
                DataType bzzn_ = bzzm_?.Value;
                CqlInterval<CqlDateTime> bzzo_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, bzzn_ as Period);
                bool? bzzp_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(bzzl_, bzzo_, default);

                return bzzp_;
            };
            IEnumerable<Encounter> bzzh_ = context.Operators.Where<Encounter>(bzzf_, bzzg_);
            Communication bzzi_(Encounter EncounterDiabeticRetinopathy) =>
                LevelOfSeverityNotCommunicated;
            IEnumerable<Communication> bzzj_ = context.Operators.Select<Encounter, Communication>(bzzh_, bzzi_);

            return bzzj_;
        };
        IEnumerable<Communication> bzzc_ = context.Operators.SelectMany<Communication, Communication>(bzza_, bzzb_);
        bool? bzzd_(Communication LevelOfSeverityNotCommunicated)
        {
            Code<EventStatus> bzzq_ = LevelOfSeverityNotCommunicated?.StatusElement;
            string bzzr_ = FHIRHelpers_4_0_001.Instance.ToString(context, bzzq_);
            bool? bzzs_ = context.Operators.Equal(bzzr_, "not-done");
            Extension bzzt_ = this.GetModifierExtension(context, LevelOfSeverityNotCommunicated, "qicore-notDone");
            DataType bzzu_ = bzzt_?.Value;
            bool? bzzv_ = FHIRHelpers_4_0_001.Instance.ToBoolean(context, bzzu_ as FhirBoolean);
            bool? bzzw_ = context.Operators.IsTrue(bzzv_);
            bool? bzzx_ = context.Operators.And(bzzs_, bzzw_);
            CodeableConcept bzzy_ = LevelOfSeverityNotCommunicated?.StatusReason;
            CqlConcept bzzz_ = FHIRHelpers_4_0_001.Instance.ToConcept(context, bzzy_);
            CqlValueSet czza_ = this.Medical_Reason(context);
            bool? czzb_ = context.Operators.ConceptInValueSet(bzzz_, czza_);
            CqlConcept czzd_ = FHIRHelpers_4_0_001.Instance.ToConcept(context, bzzy_);
            CqlValueSet czze_ = this.Patient_Reason(context);
            bool? czzf_ = context.Operators.ConceptInValueSet(czzd_, czze_);
            bool? czzg_ = context.Operators.Or(czzb_, czzf_);
            bool? czzh_ = context.Operators.And(bzzx_, czzg_);

            return czzh_;
        };
        IEnumerable<Communication> bzze_ = context.Operators.Where<Communication>(bzzc_, bzzd_);

        return bzze_;
    }


    [CqlExpressionDefinition("Medical or Patient Reason for Not Communicating Absence of Macular Edema")]
    public IEnumerable<Communication> Medical_or_Patient_Reason_for_Not_Communicating_Absence_of_Macular_Edema(CqlContext context)
    {
        PropertyInfo czzi_ = typeof(Communication).GetProperty("ReasonCode");
        CqlCode czzj_ = this.Macular_edema_absent__situation_(context);
        IEnumerable<CqlCode> czzk_ = context.Operators.ToList<CqlCode>(czzj_);
        IEnumerable<Communication> czzl_ = context.Operators.Retrieve<Communication>(new RetrieveParameters(czzi_, default, czzk_, "http://hl7.org/fhir/StructureDefinition/Communication"));
        IEnumerable<Communication> czzm_(Communication MacularEdemaAbsentNotCommunicated)
        {
            IEnumerable<Encounter> czzq_ = this.Diabetic_Retinopathy_Encounter(context);
            bool? czzr_(Encounter EncounterDiabeticRetinopathy)
            {
                Period czzv_ = EncounterDiabeticRetinopathy?.Period;
                CqlInterval<CqlDateTime> czzw_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, czzv_);
                Extension czzx_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.GetExtension(context, MacularEdemaAbsentNotCommunicated, "qicore-recorded");
                DataType czzy_ = czzx_?.Value;
                CqlInterval<CqlDateTime> czzz_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, czzy_ as Period);
                bool? dzza_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(czzw_, czzz_, default);

                return dzza_;
            };
            IEnumerable<Encounter> czzs_ = context.Operators.Where<Encounter>(czzq_, czzr_);
            Communication czzt_(Encounter EncounterDiabeticRetinopathy) =>
                MacularEdemaAbsentNotCommunicated;
            IEnumerable<Communication> czzu_ = context.Operators.Select<Encounter, Communication>(czzs_, czzt_);

            return czzu_;
        };
        IEnumerable<Communication> czzn_ = context.Operators.SelectMany<Communication, Communication>(czzl_, czzm_);
        bool? czzo_(Communication MacularEdemaAbsentNotCommunicated)
        {
            Code<EventStatus> dzzb_ = MacularEdemaAbsentNotCommunicated?.StatusElement;
            string dzzc_ = FHIRHelpers_4_0_001.Instance.ToString(context, dzzb_);
            bool? dzzd_ = context.Operators.Equal(dzzc_, "not-done");
            Extension dzze_ = this.GetModifierExtension(context, MacularEdemaAbsentNotCommunicated, "qicore-notDone");
            DataType dzzf_ = dzze_?.Value;
            bool? dzzg_ = FHIRHelpers_4_0_001.Instance.ToBoolean(context, dzzf_ as FhirBoolean);
            bool? dzzh_ = context.Operators.IsTrue(dzzg_);
            bool? dzzi_ = context.Operators.And(dzzd_, dzzh_);
            CodeableConcept dzzj_ = MacularEdemaAbsentNotCommunicated?.StatusReason;
            CqlConcept dzzk_ = FHIRHelpers_4_0_001.Instance.ToConcept(context, dzzj_);
            CqlValueSet dzzl_ = this.Medical_Reason(context);
            bool? dzzm_ = context.Operators.ConceptInValueSet(dzzk_, dzzl_);
            CqlConcept dzzo_ = FHIRHelpers_4_0_001.Instance.ToConcept(context, dzzj_);
            CqlValueSet dzzp_ = this.Patient_Reason(context);
            bool? dzzq_ = context.Operators.ConceptInValueSet(dzzo_, dzzp_);
            bool? dzzr_ = context.Operators.Or(dzzm_, dzzq_);
            bool? dzzs_ = context.Operators.And(dzzi_, dzzr_);

            return dzzs_;
        };
        IEnumerable<Communication> czzp_ = context.Operators.Where<Communication>(czzn_, czzo_);

        return czzp_;
    }


    [CqlExpressionDefinition("Medical or Patient Reason for Not Communicating Presence of Macular Edema")]
    public IEnumerable<Communication> Medical_or_Patient_Reason_for_Not_Communicating_Presence_of_Macular_Edema(CqlContext context)
    {
        PropertyInfo dzzt_ = typeof(Communication).GetProperty("ReasonCode");
        CqlValueSet dzzu_ = this.Macular_Edema_Findings_Present(context);
        IEnumerable<Communication> dzzv_ = context.Operators.Retrieve<Communication>(new RetrieveParameters(dzzt_, dzzu_, default, "http://hl7.org/fhir/StructureDefinition/Communication"));
        IEnumerable<Communication> dzzw_(Communication MacularEdemaPresentNotCommunicated)
        {
            IEnumerable<Encounter> ezza_ = this.Diabetic_Retinopathy_Encounter(context);
            bool? ezzb_(Encounter EncounterDiabeticRetinopathy)
            {
                Period ezzf_ = EncounterDiabeticRetinopathy?.Period;
                CqlInterval<CqlDateTime> ezzg_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, ezzf_);
                Extension ezzh_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.GetExtension(context, MacularEdemaPresentNotCommunicated, "qicore-recorded");
                DataType ezzi_ = ezzh_?.Value;
                CqlInterval<CqlDateTime> ezzj_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, ezzi_ as Period);
                bool? ezzk_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(ezzg_, ezzj_, default);

                return ezzk_;
            };
            IEnumerable<Encounter> ezzc_ = context.Operators.Where<Encounter>(ezza_, ezzb_);
            Communication ezzd_(Encounter EncounterDiabeticRetinopathy) =>
                MacularEdemaPresentNotCommunicated;
            IEnumerable<Communication> ezze_ = context.Operators.Select<Encounter, Communication>(ezzc_, ezzd_);

            return ezze_;
        };
        IEnumerable<Communication> dzzx_ = context.Operators.SelectMany<Communication, Communication>(dzzv_, dzzw_);
        bool? dzzy_(Communication MacularEdemaPresentNotCommunicated)
        {
            Code<EventStatus> ezzl_ = MacularEdemaPresentNotCommunicated?.StatusElement;
            string ezzm_ = FHIRHelpers_4_0_001.Instance.ToString(context, ezzl_);
            bool? ezzn_ = context.Operators.Equal(ezzm_, "not-done");
            Extension ezzo_ = this.GetModifierExtension(context, MacularEdemaPresentNotCommunicated, "qicore-notDone");
            DataType ezzp_ = ezzo_?.Value;
            bool? ezzq_ = FHIRHelpers_4_0_001.Instance.ToBoolean(context, ezzp_ as FhirBoolean);
            bool? ezzr_ = context.Operators.IsTrue(ezzq_);
            bool? ezzs_ = context.Operators.And(ezzn_, ezzr_);
            CodeableConcept ezzt_ = MacularEdemaPresentNotCommunicated?.StatusReason;
            CqlConcept ezzu_ = FHIRHelpers_4_0_001.Instance.ToConcept(context, ezzt_);
            CqlValueSet ezzv_ = this.Medical_Reason(context);
            bool? ezzw_ = context.Operators.ConceptInValueSet(ezzu_, ezzv_);
            CqlConcept ezzy_ = FHIRHelpers_4_0_001.Instance.ToConcept(context, ezzt_);
            CqlValueSet ezzz_ = this.Patient_Reason(context);
            bool? fzza_ = context.Operators.ConceptInValueSet(ezzy_, ezzz_);
            bool? fzzb_ = context.Operators.Or(ezzw_, fzza_);
            bool? fzzc_ = context.Operators.And(ezzs_, fzzb_);

            return fzzc_;
        };
        IEnumerable<Communication> dzzz_ = context.Operators.Where<Communication>(dzzx_, dzzy_);

        return dzzz_;
    }


    [CqlExpressionDefinition("Denominator Exceptions")]
    public bool? Denominator_Exceptions(CqlContext context)
    {
        IEnumerable<Communication> fzzd_ = this.Medical_or_Patient_Reason_for_Not_Communicating_Level_of_Severity_of_Retinopathy(context);
        bool? fzze_ = context.Operators.Exists<Communication>(fzzd_);
        IEnumerable<Communication> fzzf_ = this.Medical_or_Patient_Reason_for_Not_Communicating_Absence_of_Macular_Edema(context);
        bool? fzzg_ = context.Operators.Exists<Communication>(fzzf_);
        bool? fzzh_ = context.Operators.Or(fzze_, fzzg_);
        IEnumerable<Communication> fzzi_ = this.Medical_or_Patient_Reason_for_Not_Communicating_Presence_of_Macular_Edema(context);
        bool? fzzj_ = context.Operators.Exists<Communication>(fzzi_);
        bool? fzzk_ = context.Operators.Or(fzzh_, fzzj_);

        return fzzk_;
    }


    [CqlExpressionDefinition("Initial Population")]
    public bool? Initial_Population(CqlContext context)
    {
        Patient fzzl_ = this.Patient(context);
        Date fzzm_ = fzzl_?.BirthDateElement;
        string fzzn_ = fzzm_?.Value;
        CqlDateTime fzzo_ = context.Operators.ConvertStringToDateTime(fzzn_);
        CqlInterval<CqlDateTime> fzzp_ = this.Measurement_Period(context);
        CqlDateTime fzzq_ = context.Operators.Start(fzzp_);
        int? fzzr_ = context.Operators.CalculateAgeAt(fzzo_, fzzq_, "year");
        bool? fzzs_ = context.Operators.GreaterOrEqual(fzzr_, 18);
        IEnumerable<Encounter> fzzt_ = this.Diabetic_Retinopathy_Encounter(context);
        bool? fzzu_ = context.Operators.Exists<Encounter>(fzzt_);
        bool? fzzv_ = context.Operators.And(fzzs_, fzzu_);

        return fzzv_;
    }


    [CqlExpressionDefinition("Macular Exam Performed")]
    public IEnumerable<Observation> Macular_Exam_Performed(CqlContext context)
    {
        CqlValueSet fzzw_ = this.Macular_Exam(context);
        IEnumerable<Observation> fzzx_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, fzzw_, default, "http://hl7.org/fhir/StructureDefinition/Observation"));
        IEnumerable<Observation> fzzy_(Observation MacularExam)
        {
            IEnumerable<Encounter> gzzc_ = this.Diabetic_Retinopathy_Encounter(context);
            bool? gzzd_(Encounter EncounterDiabeticRetinopathy)
            {
                Period gzzh_ = EncounterDiabeticRetinopathy?.Period;
                CqlInterval<CqlDateTime> gzzi_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, gzzh_);
                DataType gzzj_ = MacularExam?.Effective;
                CqlInterval<CqlDateTime> gzzk_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, gzzj_);
                bool? gzzl_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(gzzi_, gzzk_, default);

                return gzzl_;
            };
            IEnumerable<Encounter> gzze_ = context.Operators.Where<Encounter>(gzzc_, gzzd_);
            Observation gzzf_(Encounter EncounterDiabeticRetinopathy) =>
                MacularExam;
            IEnumerable<Observation> gzzg_ = context.Operators.Select<Encounter, Observation>(gzze_, gzzf_);

            return gzzg_;
        };
        IEnumerable<Observation> fzzz_ = context.Operators.SelectMany<Observation, Observation>(fzzx_, fzzy_);
        bool? gzza_(Observation MacularExam)
        {
            Code<ObservationStatus> gzzm_ = MacularExam?.StatusElement;
            string gzzn_ = FHIRHelpers_4_0_001.Instance.ToString(context, gzzm_);
            string[] gzzo_ = [
                "final",
                "amended",
                "corrected",
            ];
            bool? gzzp_ = context.Operators.In<string>(gzzn_, gzzo_ as IEnumerable<string>);
            DataType gzzq_ = MacularExam?.Value;
            bool? gzzr_ = context.Operators.Not((bool?)(gzzq_ is null));
            bool? gzzs_ = context.Operators.And(gzzp_, gzzr_);

            return gzzs_;
        };
        IEnumerable<Observation> gzzb_ = context.Operators.Where<Observation>(fzzz_, gzza_);

        return gzzb_;
    }


    [CqlExpressionDefinition("Denominator")]
    public bool? Denominator(CqlContext context)
    {
        bool? gzzt_ = this.Initial_Population(context);
        IEnumerable<Observation> gzzu_ = this.Macular_Exam_Performed(context);
        bool? gzzv_ = context.Operators.Exists<Observation>(gzzu_);
        bool? gzzw_ = context.Operators.And(gzzt_, gzzv_);

        return gzzw_;
    }


    [CqlExpressionDefinition("Level of Severity of Retinopathy Findings Communicated")]
    public IEnumerable<Communication> Level_of_Severity_of_Retinopathy_Findings_Communicated(CqlContext context)
    {
        PropertyInfo gzzx_ = typeof(Communication).GetProperty("ReasonCode");
        CqlValueSet gzzy_ = this.Level_of_Severity_of_Retinopathy_Findings(context);
        IEnumerable<Communication> gzzz_ = context.Operators.Retrieve<Communication>(new RetrieveParameters(gzzx_, gzzy_, default, "http://hl7.org/fhir/StructureDefinition/Communication"));
        IEnumerable<Communication> hzza_(Communication LevelOfSeverityCommunicated)
        {
            IEnumerable<Encounter> hzze_ = this.Diabetic_Retinopathy_Encounter(context);
            bool? hzzf_(Encounter EncounterDiabeticRetinopathy)
            {
                FhirDateTime hzzj_ = LevelOfSeverityCommunicated?.SentElement;
                CqlDateTime hzzk_ = FHIRHelpers_4_0_001.Instance.ToDateTime(context, hzzj_);
                Period hzzl_ = EncounterDiabeticRetinopathy?.Period;
                CqlInterval<CqlDateTime> hzzm_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, hzzl_);
                CqlDateTime hzzn_ = context.Operators.Start(hzzm_);
                bool? hzzo_ = context.Operators.After(hzzk_, hzzn_, default);

                return hzzo_;
            };
            IEnumerable<Encounter> hzzg_ = context.Operators.Where<Encounter>(hzze_, hzzf_);
            Communication hzzh_(Encounter EncounterDiabeticRetinopathy) =>
                LevelOfSeverityCommunicated;
            IEnumerable<Communication> hzzi_ = context.Operators.Select<Encounter, Communication>(hzzg_, hzzh_);

            return hzzi_;
        };
        IEnumerable<Communication> hzzb_ = context.Operators.SelectMany<Communication, Communication>(gzzz_, hzza_);
        bool? hzzc_(Communication LevelOfSeverityCommunicated)
        {
            Code<EventStatus> hzzp_ = LevelOfSeverityCommunicated?.StatusElement;
            string hzzq_ = FHIRHelpers_4_0_001.Instance.ToString(context, hzzp_);
            bool? hzzr_ = context.Operators.Equal(hzzq_, "completed");

            return hzzr_;
        };
        IEnumerable<Communication> hzzd_ = context.Operators.Where<Communication>(hzzb_, hzzc_);

        return hzzd_;
    }


    [CqlExpressionDefinition("Macular Edema Absence Communicated")]
    public IEnumerable<Communication> Macular_Edema_Absence_Communicated(CqlContext context)
    {
        PropertyInfo hzzs_ = typeof(Communication).GetProperty("ReasonCode");
        CqlCode hzzt_ = this.Macular_edema_absent__situation_(context);
        IEnumerable<CqlCode> hzzu_ = context.Operators.ToList<CqlCode>(hzzt_);
        IEnumerable<Communication> hzzv_ = context.Operators.Retrieve<Communication>(new RetrieveParameters(hzzs_, default, hzzu_, "http://hl7.org/fhir/StructureDefinition/Communication"));
        IEnumerable<Communication> hzzw_(Communication MacularEdemaAbsentCommunicated)
        {
            IEnumerable<Encounter> izza_ = this.Diabetic_Retinopathy_Encounter(context);
            bool? izzb_(Encounter EncounterDiabeticRetinopathy)
            {
                FhirDateTime izzf_ = MacularEdemaAbsentCommunicated?.SentElement;
                CqlDateTime izzg_ = FHIRHelpers_4_0_001.Instance.ToDateTime(context, izzf_);
                Period izzh_ = EncounterDiabeticRetinopathy?.Period;
                CqlInterval<CqlDateTime> izzi_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, izzh_);
                CqlDateTime izzj_ = context.Operators.Start(izzi_);
                bool? izzk_ = context.Operators.After(izzg_, izzj_, default);

                return izzk_;
            };
            IEnumerable<Encounter> izzc_ = context.Operators.Where<Encounter>(izza_, izzb_);
            Communication izzd_(Encounter EncounterDiabeticRetinopathy) =>
                MacularEdemaAbsentCommunicated;
            IEnumerable<Communication> izze_ = context.Operators.Select<Encounter, Communication>(izzc_, izzd_);

            return izze_;
        };
        IEnumerable<Communication> hzzx_ = context.Operators.SelectMany<Communication, Communication>(hzzv_, hzzw_);
        bool? hzzy_(Communication MacularEdemaAbsentCommunicated)
        {
            Code<EventStatus> izzl_ = MacularEdemaAbsentCommunicated?.StatusElement;
            string izzm_ = FHIRHelpers_4_0_001.Instance.ToString(context, izzl_);
            bool? izzn_ = context.Operators.Equal(izzm_, "completed");

            return izzn_;
        };
        IEnumerable<Communication> hzzz_ = context.Operators.Where<Communication>(hzzx_, hzzy_);

        return hzzz_;
    }


    [CqlExpressionDefinition("Macular Edema Presence Communicated")]
    public IEnumerable<Communication> Macular_Edema_Presence_Communicated(CqlContext context)
    {
        PropertyInfo izzo_ = typeof(Communication).GetProperty("ReasonCode");
        CqlValueSet izzp_ = this.Macular_Edema_Findings_Present(context);
        IEnumerable<Communication> izzq_ = context.Operators.Retrieve<Communication>(new RetrieveParameters(izzo_, izzp_, default, "http://hl7.org/fhir/StructureDefinition/Communication"));
        IEnumerable<Communication> izzr_(Communication MacularEdemaPresentCommunicated)
        {
            IEnumerable<Encounter> izzv_ = this.Diabetic_Retinopathy_Encounter(context);
            bool? izzw_(Encounter EncounterDiabeticRetinopathy)
            {
                FhirDateTime jzza_ = MacularEdemaPresentCommunicated?.SentElement;
                CqlDateTime jzzb_ = FHIRHelpers_4_0_001.Instance.ToDateTime(context, jzza_);
                Period jzzc_ = EncounterDiabeticRetinopathy?.Period;
                CqlInterval<CqlDateTime> jzzd_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, jzzc_);
                CqlDateTime jzze_ = context.Operators.Start(jzzd_);
                bool? jzzf_ = context.Operators.After(jzzb_, jzze_, default);

                return jzzf_;
            };
            IEnumerable<Encounter> izzx_ = context.Operators.Where<Encounter>(izzv_, izzw_);
            Communication izzy_(Encounter EncounterDiabeticRetinopathy) =>
                MacularEdemaPresentCommunicated;
            IEnumerable<Communication> izzz_ = context.Operators.Select<Encounter, Communication>(izzx_, izzy_);

            return izzz_;
        };
        IEnumerable<Communication> izzs_ = context.Operators.SelectMany<Communication, Communication>(izzq_, izzr_);
        bool? izzt_(Communication MacularEdemaPresentCommunicated)
        {
            Code<EventStatus> jzzg_ = MacularEdemaPresentCommunicated?.StatusElement;
            string jzzh_ = FHIRHelpers_4_0_001.Instance.ToString(context, jzzg_);
            bool? jzzi_ = context.Operators.Equal(jzzh_, "completed");

            return jzzi_;
        };
        IEnumerable<Communication> izzu_ = context.Operators.Where<Communication>(izzs_, izzt_);

        return izzu_;
    }


    [CqlExpressionDefinition("Results of Dilated Macular or Fundus Exam Communicated")]
    public bool? Results_of_Dilated_Macular_or_Fundus_Exam_Communicated(CqlContext context)
    {
        IEnumerable<Communication> jzzj_ = this.Level_of_Severity_of_Retinopathy_Findings_Communicated(context);
        bool? jzzk_ = context.Operators.Exists<Communication>(jzzj_);
        IEnumerable<Communication> jzzl_ = this.Macular_Edema_Absence_Communicated(context);
        bool? jzzm_ = context.Operators.Exists<Communication>(jzzl_);
        IEnumerable<Communication> jzzn_ = this.Macular_Edema_Presence_Communicated(context);
        bool? jzzo_ = context.Operators.Exists<Communication>(jzzn_);
        bool? jzzp_ = context.Operators.Or(jzzm_, jzzo_);
        bool? jzzq_ = context.Operators.And(jzzk_, jzzp_);

        return jzzq_;
    }


    [CqlExpressionDefinition("Numerator")]
    public bool? Numerator(CqlContext context)
    {
        IEnumerable<Communication> jzzr_ = this.Level_of_Severity_of_Retinopathy_Findings_Communicated(context);
        bool? jzzs_ = context.Operators.Exists<Communication>(jzzr_);
        IEnumerable<Communication> jzzt_ = this.Macular_Edema_Absence_Communicated(context);
        bool? jzzu_ = context.Operators.Exists<Communication>(jzzt_);
        IEnumerable<Communication> jzzv_ = this.Macular_Edema_Presence_Communicated(context);
        bool? jzzw_ = context.Operators.Exists<Communication>(jzzv_);
        bool? jzzx_ = context.Operators.Or(jzzu_, jzzw_);
        bool? jzzy_ = context.Operators.And(jzzs_, jzzx_);

        return jzzy_;
    }


    #endregion Expressions

}
