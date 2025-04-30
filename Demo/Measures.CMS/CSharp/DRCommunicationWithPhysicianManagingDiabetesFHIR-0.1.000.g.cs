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
    private static readonly CqlCode _Healthcare_professional__occupation_ = new CqlCode("223366009", "http://snomed.info/sct");

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

    [CqlCodeDefinition("virtual", codeId: "VR", codeSystem: "http://terminology.hl7.org/CodeSystem/v3-ActCode")]
    public CqlCode @virtual(CqlContext _) => _virtual;
    private static readonly CqlCode _virtual = new CqlCode("VR", "http://terminology.hl7.org/CodeSystem/v3-ActCode");

    [CqlCodeDefinition("AMB", codeId: "AMB", codeSystem: "http://terminology.hl7.org/CodeSystem/v3-ActCode")]
    public CqlCode AMB(CqlContext _) => _AMB;
    private static readonly CqlCode _AMB = new CqlCode("AMB", "http://terminology.hl7.org/CodeSystem/v3-ActCode");

    #endregion Codes

    #region CodeSystems

    [CqlCodeSystemDefinition("SNOMEDCT")]
    public CqlCodeSystem SNOMEDCT(CqlContext _) => _SNOMEDCT;
    private static readonly CqlCodeSystem _SNOMEDCT =
      new CqlCodeSystem("http://snomed.info/sct", null,
          _Healthcare_professional__occupation_,
          _Medical_practitioner__occupation_,
          _Ophthalmologist__occupation_,
          _Optometrist__occupation_,
          _Physician__occupation_);

    [CqlCodeSystemDefinition("ActCode")]
    public CqlCodeSystem ActCode(CqlContext _) => _ActCode;
    private static readonly CqlCodeSystem _ActCode =
      new CqlCodeSystem("http://terminology.hl7.org/CodeSystem/v3-ActCode", null,
          _virtual,
          _AMB);

    #endregion CodeSystems

    #region Parameters

    [CqlParameterDefinition("Measurement Period")]
    public CqlInterval<CqlDateTime> Measurement_Period(CqlContext context)
    {
        CqlDateTime mzzzzzzzzzzzzzzzw_ = context.Operators.DateTime(2025, 1, 1, 0, 0, 0, 0, 0.0m);
        CqlDateTime mzzzzzzzzzzzzzzzx_ = context.Operators.DateTime(2025, 12, 31, 23, 59, 59, 999, 0.0m);
        CqlInterval<CqlDateTime> mzzzzzzzzzzzzzzzy_ = context.Operators.Interval(mzzzzzzzzzzzzzzzw_, mzzzzzzzzzzzzzzzx_, true, true);
        object mzzzzzzzzzzzzzzzz_ = context.ResolveParameter("DRCommunicationWithPhysicianManagingDiabetesFHIR-0.1.000", "Measurement Period", mzzzzzzzzzzzzzzzy_);

        return (CqlInterval<CqlDateTime>)mzzzzzzzzzzzzzzzz_;
    }


    #endregion Parameters

    #region Expressions

    [CqlExpressionDefinition("Patient")]
    public Patient Patient(CqlContext context)
    {
        IEnumerable<Patient> nzzzzzzzzzzzzzzza_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-patient"));
        Patient nzzzzzzzzzzzzzzzb_ = context.Operators.SingletonFrom<Patient>(nzzzzzzzzzzzzzzza_);

        return nzzzzzzzzzzzzzzzb_;
    }


    [CqlExpressionDefinition("SDE Ethnicity")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Ethnicity(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? nzzzzzzzzzzzzzzzc_ = SupplementalDataElements_3_5_000.Instance.SDE_Ethnicity(context);

        return nzzzzzzzzzzzzzzzc_;
    }


    [CqlExpressionDefinition("SDE Payer")]
    public IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> SDE_Payer(CqlContext context)
    {
        IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> nzzzzzzzzzzzzzzzd_ = SupplementalDataElements_3_5_000.Instance.SDE_Payer(context);

        return nzzzzzzzzzzzzzzzd_;
    }


    [CqlExpressionDefinition("SDE Race")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Race(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? nzzzzzzzzzzzzzzze_ = SupplementalDataElements_3_5_000.Instance.SDE_Race(context);

        return nzzzzzzzzzzzzzzze_;
    }


    [CqlExpressionDefinition("SDE Sex")]
    public CqlCode SDE_Sex(CqlContext context)
    {
        CqlCode nzzzzzzzzzzzzzzzf_ = SupplementalDataElements_3_5_000.Instance.SDE_Sex(context);

        return nzzzzzzzzzzzzzzzf_;
    }


    [CqlExpressionDefinition("Qualifying Encounter During Measurement Period")]
    public IEnumerable<Encounter> Qualifying_Encounter_During_Measurement_Period(CqlContext context)
    {
        CqlValueSet nzzzzzzzzzzzzzzzg_ = this.Office_Visit(context);
        IEnumerable<Encounter> nzzzzzzzzzzzzzzzh_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, nzzzzzzzzzzzzzzzg_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        CqlValueSet nzzzzzzzzzzzzzzzi_ = this.Ophthalmological_Services(context);
        IEnumerable<Encounter> nzzzzzzzzzzzzzzzj_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, nzzzzzzzzzzzzzzzi_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> nzzzzzzzzzzzzzzzk_ = context.Operators.Union<Encounter>(nzzzzzzzzzzzzzzzh_, nzzzzzzzzzzzzzzzj_);
        CqlValueSet nzzzzzzzzzzzzzzzl_ = this.Outpatient_Consultation(context);
        IEnumerable<Encounter> nzzzzzzzzzzzzzzzm_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, nzzzzzzzzzzzzzzzl_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        CqlValueSet nzzzzzzzzzzzzzzzn_ = this.Care_Services_in_Long_Term_Residential_Facility(context);
        IEnumerable<Encounter> nzzzzzzzzzzzzzzzo_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, nzzzzzzzzzzzzzzzn_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> nzzzzzzzzzzzzzzzp_ = context.Operators.Union<Encounter>(nzzzzzzzzzzzzzzzm_, nzzzzzzzzzzzzzzzo_);
        IEnumerable<Encounter> nzzzzzzzzzzzzzzzq_ = context.Operators.Union<Encounter>(nzzzzzzzzzzzzzzzk_, nzzzzzzzzzzzzzzzp_);
        CqlValueSet nzzzzzzzzzzzzzzzr_ = this.Nursing_Facility_Visit(context);
        IEnumerable<Encounter> nzzzzzzzzzzzzzzzs_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, nzzzzzzzzzzzzzzzr_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> nzzzzzzzzzzzzzzzt_ = context.Operators.Union<Encounter>(nzzzzzzzzzzzzzzzq_, nzzzzzzzzzzzzzzzs_);
        bool? nzzzzzzzzzzzzzzzu_(Encounter QualifyingEncounter)
        {
            CqlInterval<CqlDateTime> nzzzzzzzzzzzzzzzw_ = this.Measurement_Period(context);
            Period nzzzzzzzzzzzzzzzx_ = QualifyingEncounter?.Period;
            CqlInterval<CqlDateTime> nzzzzzzzzzzzzzzzy_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, nzzzzzzzzzzzzzzzx_);
            bool? nzzzzzzzzzzzzzzzz_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(nzzzzzzzzzzzzzzzw_, nzzzzzzzzzzzzzzzy_, default);
            Code<Encounter.EncounterStatus> ozzzzzzzzzzzzzzza_ = QualifyingEncounter?.StatusElement;
            Encounter.EncounterStatus? ozzzzzzzzzzzzzzzb_ = ozzzzzzzzzzzzzzza_?.Value;
            Code<Encounter.EncounterStatus> ozzzzzzzzzzzzzzzc_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(ozzzzzzzzzzzzzzzb_);
            bool? ozzzzzzzzzzzzzzzd_ = context.Operators.Equal(ozzzzzzzzzzzzzzzc_, "finished");
            bool? ozzzzzzzzzzzzzzze_ = context.Operators.And(nzzzzzzzzzzzzzzzz_, ozzzzzzzzzzzzzzzd_);
            Coding ozzzzzzzzzzzzzzzf_ = QualifyingEncounter?.Class;
            CqlCode ozzzzzzzzzzzzzzzg_ = FHIRHelpers_4_4_000.Instance.ToCode(context, ozzzzzzzzzzzzzzzf_);
            CqlCode ozzzzzzzzzzzzzzzh_ = this.@virtual(context);
            bool? ozzzzzzzzzzzzzzzi_ = context.Operators.Equivalent(ozzzzzzzzzzzzzzzg_, ozzzzzzzzzzzzzzzh_);
            bool? ozzzzzzzzzzzzzzzj_ = context.Operators.Not(ozzzzzzzzzzzzzzzi_);
            bool? ozzzzzzzzzzzzzzzk_ = context.Operators.And(ozzzzzzzzzzzzzzze_, ozzzzzzzzzzzzzzzj_);

            return ozzzzzzzzzzzzzzzk_;
        };
        IEnumerable<Encounter> nzzzzzzzzzzzzzzzv_ = context.Operators.Where<Encounter>(nzzzzzzzzzzzzzzzt_, nzzzzzzzzzzzzzzzu_);

        return nzzzzzzzzzzzzzzzv_;
    }


    [CqlExpressionDefinition("Diabetic Retinopathy Encounter")]
    public IEnumerable<Encounter> Diabetic_Retinopathy_Encounter(CqlContext context)
    {
        IEnumerable<Encounter> ozzzzzzzzzzzzzzzl_ = this.Qualifying_Encounter_During_Measurement_Period(context);
        IEnumerable<Encounter> ozzzzzzzzzzzzzzzm_(Encounter ValidQualifyingEncounter)
        {
            CqlValueSet ozzzzzzzzzzzzzzzo_ = this.Diabetic_Retinopathy(context);
            IEnumerable<Condition> ozzzzzzzzzzzzzzzp_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, ozzzzzzzzzzzzzzzo_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
            bool? ozzzzzzzzzzzzzzzq_(Condition DiabeticRetinopathy)
            {
                CqlInterval<CqlDateTime> ozzzzzzzzzzzzzzzu_ = QICoreCommon_2_1_000.Instance.prevalenceInterval(context, DiabeticRetinopathy);
                Period ozzzzzzzzzzzzzzzv_ = ValidQualifyingEncounter?.Period;
                CqlInterval<CqlDateTime> ozzzzzzzzzzzzzzzw_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ozzzzzzzzzzzzzzzv_);
                bool? ozzzzzzzzzzzzzzzx_ = context.Operators.Overlaps(ozzzzzzzzzzzzzzzu_, ozzzzzzzzzzzzzzzw_, default);
                bool? ozzzzzzzzzzzzzzzy_ = QICoreCommon_2_1_000.Instance.isActive(context, DiabeticRetinopathy);
                bool? ozzzzzzzzzzzzzzzz_ = context.Operators.And(ozzzzzzzzzzzzzzzx_, ozzzzzzzzzzzzzzzy_);
                CodeableConcept pzzzzzzzzzzzzzzza_ = DiabeticRetinopathy?.VerificationStatus;
                CqlConcept pzzzzzzzzzzzzzzzb_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, pzzzzzzzzzzzzzzza_);
                CqlCode pzzzzzzzzzzzzzzzc_ = QICoreCommon_2_1_000.Instance.unconfirmed(context);
                CqlConcept pzzzzzzzzzzzzzzzd_ = context.Operators.ConvertCodeToConcept(pzzzzzzzzzzzzzzzc_);
                bool? pzzzzzzzzzzzzzzze_ = context.Operators.Equivalent(pzzzzzzzzzzzzzzzb_, pzzzzzzzzzzzzzzzd_);
                CqlConcept pzzzzzzzzzzzzzzzg_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, pzzzzzzzzzzzzzzza_);
                CqlCode pzzzzzzzzzzzzzzzh_ = QICoreCommon_2_1_000.Instance.refuted(context);
                CqlConcept pzzzzzzzzzzzzzzzi_ = context.Operators.ConvertCodeToConcept(pzzzzzzzzzzzzzzzh_);
                bool? pzzzzzzzzzzzzzzzj_ = context.Operators.Equivalent(pzzzzzzzzzzzzzzzg_, pzzzzzzzzzzzzzzzi_);
                bool? pzzzzzzzzzzzzzzzk_ = context.Operators.Or(pzzzzzzzzzzzzzzze_, pzzzzzzzzzzzzzzzj_);
                CqlConcept pzzzzzzzzzzzzzzzm_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, pzzzzzzzzzzzzzzza_);
                CqlCode pzzzzzzzzzzzzzzzn_ = QICoreCommon_2_1_000.Instance.entered_in_error(context);
                CqlConcept pzzzzzzzzzzzzzzzo_ = context.Operators.ConvertCodeToConcept(pzzzzzzzzzzzzzzzn_);
                bool? pzzzzzzzzzzzzzzzp_ = context.Operators.Equivalent(pzzzzzzzzzzzzzzzm_, pzzzzzzzzzzzzzzzo_);
                bool? pzzzzzzzzzzzzzzzq_ = context.Operators.Or(pzzzzzzzzzzzzzzzk_, pzzzzzzzzzzzzzzzp_);
                bool? pzzzzzzzzzzzzzzzr_ = context.Operators.Not(pzzzzzzzzzzzzzzzq_);
                bool? pzzzzzzzzzzzzzzzs_ = context.Operators.And(ozzzzzzzzzzzzzzzz_, pzzzzzzzzzzzzzzzr_);

                return pzzzzzzzzzzzzzzzs_;
            };
            IEnumerable<Condition> ozzzzzzzzzzzzzzzr_ = context.Operators.Where<Condition>(ozzzzzzzzzzzzzzzp_, ozzzzzzzzzzzzzzzq_);
            Encounter ozzzzzzzzzzzzzzzs_(Condition DiabeticRetinopathy) =>
                ValidQualifyingEncounter;
            IEnumerable<Encounter> ozzzzzzzzzzzzzzzt_ = context.Operators.Select<Condition, Encounter>(ozzzzzzzzzzzzzzzr_, ozzzzzzzzzzzzzzzs_);

            return ozzzzzzzzzzzzzzzt_;
        };
        IEnumerable<Encounter> ozzzzzzzzzzzzzzzn_ = context.Operators.SelectMany<Encounter, Encounter>(ozzzzzzzzzzzzzzzl_, ozzzzzzzzzzzzzzzm_);

        return ozzzzzzzzzzzzzzzn_;
    }


    [CqlExpressionDefinition("Initial Population")]
    public bool? Initial_Population(CqlContext context)
    {
        Patient pzzzzzzzzzzzzzzzt_ = this.Patient(context);
        Date pzzzzzzzzzzzzzzzu_ = pzzzzzzzzzzzzzzzt_?.BirthDateElement;
        string pzzzzzzzzzzzzzzzv_ = pzzzzzzzzzzzzzzzu_?.Value;
        CqlDate pzzzzzzzzzzzzzzzw_ = context.Operators.ConvertStringToDate(pzzzzzzzzzzzzzzzv_);
        CqlInterval<CqlDateTime> pzzzzzzzzzzzzzzzx_ = this.Measurement_Period(context);
        CqlDateTime pzzzzzzzzzzzzzzzy_ = context.Operators.Start(pzzzzzzzzzzzzzzzx_);
        CqlDate pzzzzzzzzzzzzzzzz_ = context.Operators.DateFrom(pzzzzzzzzzzzzzzzy_);
        int? qzzzzzzzzzzzzzzza_ = context.Operators.CalculateAgeAt(pzzzzzzzzzzzzzzzw_, pzzzzzzzzzzzzzzzz_, "year");
        bool? qzzzzzzzzzzzzzzzb_ = context.Operators.GreaterOrEqual(qzzzzzzzzzzzzzzza_, 18);
        IEnumerable<Encounter> qzzzzzzzzzzzzzzzc_ = this.Diabetic_Retinopathy_Encounter(context);
        bool? qzzzzzzzzzzzzzzzd_ = context.Operators.Exists<Encounter>(qzzzzzzzzzzzzzzzc_);
        bool? qzzzzzzzzzzzzzzze_ = context.Operators.And(qzzzzzzzzzzzzzzzb_, qzzzzzzzzzzzzzzzd_);

        return qzzzzzzzzzzzzzzze_;
    }


    [CqlExpressionDefinition("Macular Exam Performed")]
    public IEnumerable<Observation> Macular_Exam_Performed(CqlContext context)
    {
        CqlValueSet qzzzzzzzzzzzzzzzf_ = this.Macular_Exam(context);
        IEnumerable<Observation> qzzzzzzzzzzzzzzzg_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, qzzzzzzzzzzzzzzzf_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        IEnumerable<Observation> qzzzzzzzzzzzzzzzh_(Observation MacularExam)
        {
            IEnumerable<Encounter> qzzzzzzzzzzzzzzzl_ = this.Diabetic_Retinopathy_Encounter(context);
            bool? qzzzzzzzzzzzzzzzm_(Encounter EncounterDiabeticRetinopathy)
            {
                Period qzzzzzzzzzzzzzzzq_ = EncounterDiabeticRetinopathy?.Period;
                CqlInterval<CqlDateTime> qzzzzzzzzzzzzzzzr_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, qzzzzzzzzzzzzzzzq_);
                DataType qzzzzzzzzzzzzzzzs_ = MacularExam?.Effective;
                object qzzzzzzzzzzzzzzzt_ = FHIRHelpers_4_4_000.Instance.ToValue(context, qzzzzzzzzzzzzzzzs_);
                CqlInterval<CqlDateTime> qzzzzzzzzzzzzzzzu_ = QICoreCommon_2_1_000.Instance.toInterval(context, qzzzzzzzzzzzzzzzt_);
                bool? qzzzzzzzzzzzzzzzv_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(qzzzzzzzzzzzzzzzr_, qzzzzzzzzzzzzzzzu_, default);

                return qzzzzzzzzzzzzzzzv_;
            };
            IEnumerable<Encounter> qzzzzzzzzzzzzzzzn_ = context.Operators.Where<Encounter>(qzzzzzzzzzzzzzzzl_, qzzzzzzzzzzzzzzzm_);
            Observation qzzzzzzzzzzzzzzzo_(Encounter EncounterDiabeticRetinopathy) =>
                MacularExam;
            IEnumerable<Observation> qzzzzzzzzzzzzzzzp_ = context.Operators.Select<Encounter, Observation>(qzzzzzzzzzzzzzzzn_, qzzzzzzzzzzzzzzzo_);

            return qzzzzzzzzzzzzzzzp_;
        };
        IEnumerable<Observation> qzzzzzzzzzzzzzzzi_ = context.Operators.SelectMany<Observation, Observation>(qzzzzzzzzzzzzzzzg_, qzzzzzzzzzzzzzzzh_);
        bool? qzzzzzzzzzzzzzzzj_(Observation MacularExam)
        {
            DataType qzzzzzzzzzzzzzzzw_ = MacularExam?.Value;
            object qzzzzzzzzzzzzzzzx_ = FHIRHelpers_4_4_000.Instance.ToValue(context, qzzzzzzzzzzzzzzzw_);
            bool? qzzzzzzzzzzzzzzzy_ = context.Operators.Not((bool?)(qzzzzzzzzzzzzzzzx_ is null));
            Code<ObservationStatus> qzzzzzzzzzzzzzzzz_ = MacularExam?.StatusElement;
            ObservationStatus? rzzzzzzzzzzzzzzza_ = qzzzzzzzzzzzzzzzz_?.Value;
            Code<ObservationStatus> rzzzzzzzzzzzzzzzb_ = context.Operators.Convert<Code<ObservationStatus>>(rzzzzzzzzzzzzzzza_);
            string rzzzzzzzzzzzzzzzc_ = context.Operators.Convert<string>(rzzzzzzzzzzzzzzzb_);
            string[] rzzzzzzzzzzzzzzzd_ = [
                "final",
                "amended",
                "corrected",
                "preliminary",
            ];
            bool? rzzzzzzzzzzzzzzze_ = context.Operators.In<string>(rzzzzzzzzzzzzzzzc_, rzzzzzzzzzzzzzzzd_ as IEnumerable<string>);
            bool? rzzzzzzzzzzzzzzzf_ = context.Operators.And(qzzzzzzzzzzzzzzzy_, rzzzzzzzzzzzzzzze_);

            return rzzzzzzzzzzzzzzzf_;
        };
        IEnumerable<Observation> qzzzzzzzzzzzzzzzk_ = context.Operators.Where<Observation>(qzzzzzzzzzzzzzzzi_, qzzzzzzzzzzzzzzzj_);

        return qzzzzzzzzzzzzzzzk_;
    }


    [CqlExpressionDefinition("Denominator")]
    public bool? Denominator(CqlContext context)
    {
        bool? rzzzzzzzzzzzzzzzg_ = this.Initial_Population(context);
        IEnumerable<Observation> rzzzzzzzzzzzzzzzh_ = this.Macular_Exam_Performed(context);
        bool? rzzzzzzzzzzzzzzzi_ = context.Operators.Exists<Observation>(rzzzzzzzzzzzzzzzh_);
        bool? rzzzzzzzzzzzzzzzj_ = context.Operators.And(rzzzzzzzzzzzzzzzg_, rzzzzzzzzzzzzzzzi_);

        return rzzzzzzzzzzzzzzzj_;
    }


    [CqlExpressionDefinition("Level of Severity of Retinopathy Findings Communicated")]
    public IEnumerable<Communication> Level_of_Severity_of_Retinopathy_Findings_Communicated(CqlContext context)
    {
        PropertyInfo rzzzzzzzzzzzzzzzk_ = typeof(Communication).GetProperty("ReasonCode");
        CqlValueSet rzzzzzzzzzzzzzzzl_ = this.Level_of_Severity_of_Retinopathy_Findings(context);
        IEnumerable<Communication> rzzzzzzzzzzzzzzzm_ = context.Operators.Retrieve<Communication>(new RetrieveParameters(rzzzzzzzzzzzzzzzk_, rzzzzzzzzzzzzzzzl_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-communication"));
        IEnumerable<Communication> rzzzzzzzzzzzzzzzn_(Communication LevelOfSeverityCommunicated)
        {
            IEnumerable<Encounter> rzzzzzzzzzzzzzzzr_ = this.Diabetic_Retinopathy_Encounter(context);
            bool? rzzzzzzzzzzzzzzzs_(Encounter EncounterDiabeticRetinopathy)
            {
                FhirDateTime rzzzzzzzzzzzzzzzw_ = LevelOfSeverityCommunicated?.SentElement;
                CqlDateTime rzzzzzzzzzzzzzzzx_ = context.Operators.Convert<CqlDateTime>(rzzzzzzzzzzzzzzzw_);
                Period rzzzzzzzzzzzzzzzy_ = EncounterDiabeticRetinopathy?.Period;
                CqlInterval<CqlDateTime> rzzzzzzzzzzzzzzzz_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, rzzzzzzzzzzzzzzzy_);
                CqlDateTime szzzzzzzzzzzzzzza_ = context.Operators.Start(rzzzzzzzzzzzzzzzz_);
                bool? szzzzzzzzzzzzzzzb_ = context.Operators.After(rzzzzzzzzzzzzzzzx_, szzzzzzzzzzzzzzza_, default);
                CqlDateTime szzzzzzzzzzzzzzzd_ = context.Operators.Convert<CqlDateTime>(rzzzzzzzzzzzzzzzw_);
                CqlInterval<CqlDateTime> szzzzzzzzzzzzzzze_ = this.Measurement_Period(context);
                bool? szzzzzzzzzzzzzzzf_ = context.Operators.In<CqlDateTime>(szzzzzzzzzzzzzzzd_, szzzzzzzzzzzzzzze_, "day");
                bool? szzzzzzzzzzzzzzzg_ = context.Operators.And(szzzzzzzzzzzzzzzb_, szzzzzzzzzzzzzzzf_);

                return szzzzzzzzzzzzzzzg_;
            };
            IEnumerable<Encounter> rzzzzzzzzzzzzzzzt_ = context.Operators.Where<Encounter>(rzzzzzzzzzzzzzzzr_, rzzzzzzzzzzzzzzzs_);
            Communication rzzzzzzzzzzzzzzzu_(Encounter EncounterDiabeticRetinopathy) =>
                LevelOfSeverityCommunicated;
            IEnumerable<Communication> rzzzzzzzzzzzzzzzv_ = context.Operators.Select<Encounter, Communication>(rzzzzzzzzzzzzzzzt_, rzzzzzzzzzzzzzzzu_);

            return rzzzzzzzzzzzzzzzv_;
        };
        IEnumerable<Communication> rzzzzzzzzzzzzzzzo_ = context.Operators.SelectMany<Communication, Communication>(rzzzzzzzzzzzzzzzm_, rzzzzzzzzzzzzzzzn_);
        bool? rzzzzzzzzzzzzzzzp_(Communication LevelOfSeverityCommunicated)
        {
            Code<EventStatus> szzzzzzzzzzzzzzzh_ = LevelOfSeverityCommunicated?.StatusElement;
            EventStatus? szzzzzzzzzzzzzzzi_ = szzzzzzzzzzzzzzzh_?.Value;
            Code<EventStatus> szzzzzzzzzzzzzzzj_ = context.Operators.Convert<Code<EventStatus>>(szzzzzzzzzzzzzzzi_);
            bool? szzzzzzzzzzzzzzzk_ = context.Operators.Equal(szzzzzzzzzzzzzzzj_, "completed");

            return szzzzzzzzzzzzzzzk_;
        };
        IEnumerable<Communication> rzzzzzzzzzzzzzzzq_ = context.Operators.Where<Communication>(rzzzzzzzzzzzzzzzo_, rzzzzzzzzzzzzzzzp_);

        return rzzzzzzzzzzzzzzzq_;
    }


    [CqlExpressionDefinition("Macular Edema Absence Communicated")]
    public IEnumerable<Communication> Macular_Edema_Absence_Communicated(CqlContext context)
    {
        PropertyInfo szzzzzzzzzzzzzzzl_ = typeof(Communication).GetProperty("ReasonCode");
        CqlValueSet szzzzzzzzzzzzzzzm_ = this.Macular_edema_absent__situation_(context);
        IEnumerable<Communication> szzzzzzzzzzzzzzzn_ = context.Operators.Retrieve<Communication>(new RetrieveParameters(szzzzzzzzzzzzzzzl_, szzzzzzzzzzzzzzzm_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-communication"));
        IEnumerable<Communication> szzzzzzzzzzzzzzzo_(Communication MacularEdemaAbsentCommunicated)
        {
            IEnumerable<Encounter> szzzzzzzzzzzzzzzs_ = this.Diabetic_Retinopathy_Encounter(context);
            bool? szzzzzzzzzzzzzzzt_(Encounter EncounterDiabeticRetinopathy)
            {
                FhirDateTime szzzzzzzzzzzzzzzx_ = MacularEdemaAbsentCommunicated?.SentElement;
                CqlDateTime szzzzzzzzzzzzzzzy_ = context.Operators.Convert<CqlDateTime>(szzzzzzzzzzzzzzzx_);
                Period szzzzzzzzzzzzzzzz_ = EncounterDiabeticRetinopathy?.Period;
                CqlInterval<CqlDateTime> tzzzzzzzzzzzzzzza_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, szzzzzzzzzzzzzzzz_);
                CqlDateTime tzzzzzzzzzzzzzzzb_ = context.Operators.Start(tzzzzzzzzzzzzzzza_);
                bool? tzzzzzzzzzzzzzzzc_ = context.Operators.After(szzzzzzzzzzzzzzzy_, tzzzzzzzzzzzzzzzb_, default);
                CqlDateTime tzzzzzzzzzzzzzzze_ = context.Operators.Convert<CqlDateTime>(szzzzzzzzzzzzzzzx_);
                CqlInterval<CqlDateTime> tzzzzzzzzzzzzzzzf_ = this.Measurement_Period(context);
                bool? tzzzzzzzzzzzzzzzg_ = context.Operators.In<CqlDateTime>(tzzzzzzzzzzzzzzze_, tzzzzzzzzzzzzzzzf_, "day");
                bool? tzzzzzzzzzzzzzzzh_ = context.Operators.And(tzzzzzzzzzzzzzzzc_, tzzzzzzzzzzzzzzzg_);

                return tzzzzzzzzzzzzzzzh_;
            };
            IEnumerable<Encounter> szzzzzzzzzzzzzzzu_ = context.Operators.Where<Encounter>(szzzzzzzzzzzzzzzs_, szzzzzzzzzzzzzzzt_);
            Communication szzzzzzzzzzzzzzzv_(Encounter EncounterDiabeticRetinopathy) =>
                MacularEdemaAbsentCommunicated;
            IEnumerable<Communication> szzzzzzzzzzzzzzzw_ = context.Operators.Select<Encounter, Communication>(szzzzzzzzzzzzzzzu_, szzzzzzzzzzzzzzzv_);

            return szzzzzzzzzzzzzzzw_;
        };
        IEnumerable<Communication> szzzzzzzzzzzzzzzp_ = context.Operators.SelectMany<Communication, Communication>(szzzzzzzzzzzzzzzn_, szzzzzzzzzzzzzzzo_);
        bool? szzzzzzzzzzzzzzzq_(Communication MacularEdemaAbsentCommunicated)
        {
            Code<EventStatus> tzzzzzzzzzzzzzzzi_ = MacularEdemaAbsentCommunicated?.StatusElement;
            EventStatus? tzzzzzzzzzzzzzzzj_ = tzzzzzzzzzzzzzzzi_?.Value;
            Code<EventStatus> tzzzzzzzzzzzzzzzk_ = context.Operators.Convert<Code<EventStatus>>(tzzzzzzzzzzzzzzzj_);
            bool? tzzzzzzzzzzzzzzzl_ = context.Operators.Equal(tzzzzzzzzzzzzzzzk_, "completed");

            return tzzzzzzzzzzzzzzzl_;
        };
        IEnumerable<Communication> szzzzzzzzzzzzzzzr_ = context.Operators.Where<Communication>(szzzzzzzzzzzzzzzp_, szzzzzzzzzzzzzzzq_);

        return szzzzzzzzzzzzzzzr_;
    }


    [CqlExpressionDefinition("Macular Edema Presence Communicated")]
    public IEnumerable<Communication> Macular_Edema_Presence_Communicated(CqlContext context)
    {
        PropertyInfo tzzzzzzzzzzzzzzzm_ = typeof(Communication).GetProperty("ReasonCode");
        CqlValueSet tzzzzzzzzzzzzzzzn_ = this.Macular_Edema_Findings_Present(context);
        IEnumerable<Communication> tzzzzzzzzzzzzzzzo_ = context.Operators.Retrieve<Communication>(new RetrieveParameters(tzzzzzzzzzzzzzzzm_, tzzzzzzzzzzzzzzzn_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-communication"));
        IEnumerable<Communication> tzzzzzzzzzzzzzzzp_(Communication MacularEdemaPresentCommunicated)
        {
            IEnumerable<Encounter> tzzzzzzzzzzzzzzzt_ = this.Diabetic_Retinopathy_Encounter(context);
            bool? tzzzzzzzzzzzzzzzu_(Encounter EncounterDiabeticRetinopathy)
            {
                FhirDateTime tzzzzzzzzzzzzzzzy_ = MacularEdemaPresentCommunicated?.SentElement;
                CqlDateTime tzzzzzzzzzzzzzzzz_ = context.Operators.Convert<CqlDateTime>(tzzzzzzzzzzzzzzzy_);
                Period uzzzzzzzzzzzzzzza_ = EncounterDiabeticRetinopathy?.Period;
                CqlInterval<CqlDateTime> uzzzzzzzzzzzzzzzb_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, uzzzzzzzzzzzzzzza_);
                CqlDateTime uzzzzzzzzzzzzzzzc_ = context.Operators.Start(uzzzzzzzzzzzzzzzb_);
                bool? uzzzzzzzzzzzzzzzd_ = context.Operators.After(tzzzzzzzzzzzzzzzz_, uzzzzzzzzzzzzzzzc_, default);
                CqlDateTime uzzzzzzzzzzzzzzzf_ = context.Operators.Convert<CqlDateTime>(tzzzzzzzzzzzzzzzy_);
                CqlInterval<CqlDateTime> uzzzzzzzzzzzzzzzg_ = this.Measurement_Period(context);
                bool? uzzzzzzzzzzzzzzzh_ = context.Operators.In<CqlDateTime>(uzzzzzzzzzzzzzzzf_, uzzzzzzzzzzzzzzzg_, "day");
                bool? uzzzzzzzzzzzzzzzi_ = context.Operators.And(uzzzzzzzzzzzzzzzd_, uzzzzzzzzzzzzzzzh_);

                return uzzzzzzzzzzzzzzzi_;
            };
            IEnumerable<Encounter> tzzzzzzzzzzzzzzzv_ = context.Operators.Where<Encounter>(tzzzzzzzzzzzzzzzt_, tzzzzzzzzzzzzzzzu_);
            Communication tzzzzzzzzzzzzzzzw_(Encounter EncounterDiabeticRetinopathy) =>
                MacularEdemaPresentCommunicated;
            IEnumerable<Communication> tzzzzzzzzzzzzzzzx_ = context.Operators.Select<Encounter, Communication>(tzzzzzzzzzzzzzzzv_, tzzzzzzzzzzzzzzzw_);

            return tzzzzzzzzzzzzzzzx_;
        };
        IEnumerable<Communication> tzzzzzzzzzzzzzzzq_ = context.Operators.SelectMany<Communication, Communication>(tzzzzzzzzzzzzzzzo_, tzzzzzzzzzzzzzzzp_);
        bool? tzzzzzzzzzzzzzzzr_(Communication MacularEdemaPresentCommunicated)
        {
            Code<EventStatus> uzzzzzzzzzzzzzzzj_ = MacularEdemaPresentCommunicated?.StatusElement;
            EventStatus? uzzzzzzzzzzzzzzzk_ = uzzzzzzzzzzzzzzzj_?.Value;
            Code<EventStatus> uzzzzzzzzzzzzzzzl_ = context.Operators.Convert<Code<EventStatus>>(uzzzzzzzzzzzzzzzk_);
            bool? uzzzzzzzzzzzzzzzm_ = context.Operators.Equal(uzzzzzzzzzzzzzzzl_, "completed");

            return uzzzzzzzzzzzzzzzm_;
        };
        IEnumerable<Communication> tzzzzzzzzzzzzzzzs_ = context.Operators.Where<Communication>(tzzzzzzzzzzzzzzzq_, tzzzzzzzzzzzzzzzr_);

        return tzzzzzzzzzzzzzzzs_;
    }


    [CqlExpressionDefinition("Numerator")]
    public bool? Numerator(CqlContext context)
    {
        IEnumerable<Communication> uzzzzzzzzzzzzzzzn_ = this.Level_of_Severity_of_Retinopathy_Findings_Communicated(context);
        bool? uzzzzzzzzzzzzzzzo_ = context.Operators.Exists<Communication>(uzzzzzzzzzzzzzzzn_);
        IEnumerable<Communication> uzzzzzzzzzzzzzzzp_ = this.Macular_Edema_Absence_Communicated(context);
        bool? uzzzzzzzzzzzzzzzq_ = context.Operators.Exists<Communication>(uzzzzzzzzzzzzzzzp_);
        IEnumerable<Communication> uzzzzzzzzzzzzzzzr_ = this.Macular_Edema_Presence_Communicated(context);
        bool? uzzzzzzzzzzzzzzzs_ = context.Operators.Exists<Communication>(uzzzzzzzzzzzzzzzr_);
        bool? uzzzzzzzzzzzzzzzt_ = context.Operators.Or(uzzzzzzzzzzzzzzzq_, uzzzzzzzzzzzzzzzs_);
        bool? uzzzzzzzzzzzzzzzu_ = context.Operators.And(uzzzzzzzzzzzzzzzo_, uzzzzzzzzzzzzzzzt_);

        return uzzzzzzzzzzzzzzzu_;
    }


    [CqlExpressionDefinition("Medical or Patient Reason for Not Communicating Level of Severity of Retinopathy")]
    public IEnumerable<Communication> Medical_or_Patient_Reason_for_Not_Communicating_Level_of_Severity_of_Retinopathy(CqlContext context)
    {
        PropertyInfo uzzzzzzzzzzzzzzzv_ = typeof(Communication).GetProperty("ReasonCode");
        CqlValueSet uzzzzzzzzzzzzzzzw_ = this.Level_of_Severity_of_Retinopathy_Findings(context);
        IEnumerable<Communication> uzzzzzzzzzzzzzzzx_ = context.Operators.Retrieve<Communication>(new RetrieveParameters(uzzzzzzzzzzzzzzzv_, uzzzzzzzzzzzzzzzw_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-communicationnotdone"));
        IEnumerable<Communication> vzzzzzzzzzzzzzzza_ = context.Operators.Retrieve<Communication>(new RetrieveParameters(uzzzzzzzzzzzzzzzv_, uzzzzzzzzzzzzzzzw_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-communicationnotdone"));
        IEnumerable<Communication> vzzzzzzzzzzzzzzzb_ = context.Operators.Union<Communication>(uzzzzzzzzzzzzzzzx_, vzzzzzzzzzzzzzzza_);
        IEnumerable<Communication> vzzzzzzzzzzzzzzzc_(Communication LevelOfSeverityNotCommunicated)
        {
            IEnumerable<Encounter> vzzzzzzzzzzzzzzzg_ = this.Diabetic_Retinopathy_Encounter(context);
            bool? vzzzzzzzzzzzzzzzh_(Encounter EncounterDiabeticRetinopathy)
            {
                FhirDateTime vzzzzzzzzzzzzzzzl_ = LevelOfSeverityNotCommunicated?.SentElement;
                CqlDateTime vzzzzzzzzzzzzzzzm_ = context.Operators.Convert<CqlDateTime>(vzzzzzzzzzzzzzzzl_);
                Period vzzzzzzzzzzzzzzzn_ = EncounterDiabeticRetinopathy?.Period;
                CqlInterval<CqlDateTime> vzzzzzzzzzzzzzzzo_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, vzzzzzzzzzzzzzzzn_);
                bool? vzzzzzzzzzzzzzzzp_ = context.Operators.In<CqlDateTime>(vzzzzzzzzzzzzzzzm_, vzzzzzzzzzzzzzzzo_, default);

                return vzzzzzzzzzzzzzzzp_;
            };
            IEnumerable<Encounter> vzzzzzzzzzzzzzzzi_ = context.Operators.Where<Encounter>(vzzzzzzzzzzzzzzzg_, vzzzzzzzzzzzzzzzh_);
            Communication vzzzzzzzzzzzzzzzj_(Encounter EncounterDiabeticRetinopathy) =>
                LevelOfSeverityNotCommunicated;
            IEnumerable<Communication> vzzzzzzzzzzzzzzzk_ = context.Operators.Select<Encounter, Communication>(vzzzzzzzzzzzzzzzi_, vzzzzzzzzzzzzzzzj_);

            return vzzzzzzzzzzzzzzzk_;
        };
        IEnumerable<Communication> vzzzzzzzzzzzzzzzd_ = context.Operators.SelectMany<Communication, Communication>(vzzzzzzzzzzzzzzzb_, vzzzzzzzzzzzzzzzc_);
        bool? vzzzzzzzzzzzzzzze_(Communication LevelOfSeverityNotCommunicated)
        {
            CodeableConcept vzzzzzzzzzzzzzzzq_ = LevelOfSeverityNotCommunicated?.StatusReason;
            CqlConcept vzzzzzzzzzzzzzzzr_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, vzzzzzzzzzzzzzzzq_);
            CqlValueSet vzzzzzzzzzzzzzzzs_ = this.Medical_Reason(context);
            bool? vzzzzzzzzzzzzzzzt_ = context.Operators.ConceptInValueSet(vzzzzzzzzzzzzzzzr_, vzzzzzzzzzzzzzzzs_);
            CqlConcept vzzzzzzzzzzzzzzzv_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, vzzzzzzzzzzzzzzzq_);
            CqlValueSet vzzzzzzzzzzzzzzzw_ = this.Patient_Reason(context);
            bool? vzzzzzzzzzzzzzzzx_ = context.Operators.ConceptInValueSet(vzzzzzzzzzzzzzzzv_, vzzzzzzzzzzzzzzzw_);
            bool? vzzzzzzzzzzzzzzzy_ = context.Operators.Or(vzzzzzzzzzzzzzzzt_, vzzzzzzzzzzzzzzzx_);

            return vzzzzzzzzzzzzzzzy_;
        };
        IEnumerable<Communication> vzzzzzzzzzzzzzzzf_ = context.Operators.Where<Communication>(vzzzzzzzzzzzzzzzd_, vzzzzzzzzzzzzzzze_);

        return vzzzzzzzzzzzzzzzf_;
    }


    [CqlExpressionDefinition("Medical or Patient Reason for Not Communicating Absence of Macular Edema")]
    public IEnumerable<Communication> Medical_or_Patient_Reason_for_Not_Communicating_Absence_of_Macular_Edema(CqlContext context)
    {
        PropertyInfo vzzzzzzzzzzzzzzzz_ = typeof(Communication).GetProperty("ReasonCode");
        CqlValueSet wzzzzzzzzzzzzzzza_ = this.Macular_edema_absent__situation_(context);
        IEnumerable<Communication> wzzzzzzzzzzzzzzzb_ = context.Operators.Retrieve<Communication>(new RetrieveParameters(vzzzzzzzzzzzzzzzz_, wzzzzzzzzzzzzzzza_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-communicationnotdone"));
        IEnumerable<Communication> wzzzzzzzzzzzzzzze_ = context.Operators.Retrieve<Communication>(new RetrieveParameters(vzzzzzzzzzzzzzzzz_, wzzzzzzzzzzzzzzza_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-communicationnotdone"));
        IEnumerable<Communication> wzzzzzzzzzzzzzzzf_ = context.Operators.Union<Communication>(wzzzzzzzzzzzzzzzb_, wzzzzzzzzzzzzzzze_);
        IEnumerable<Communication> wzzzzzzzzzzzzzzzg_(Communication MacularEdemaAbsentNotCommunicated)
        {
            IEnumerable<Encounter> wzzzzzzzzzzzzzzzk_ = this.Diabetic_Retinopathy_Encounter(context);
            bool? wzzzzzzzzzzzzzzzl_(Encounter EncounterDiabeticRetinopathy)
            {
                FhirDateTime wzzzzzzzzzzzzzzzp_ = MacularEdemaAbsentNotCommunicated?.SentElement;
                CqlDateTime wzzzzzzzzzzzzzzzq_ = context.Operators.Convert<CqlDateTime>(wzzzzzzzzzzzzzzzp_);
                Period wzzzzzzzzzzzzzzzr_ = EncounterDiabeticRetinopathy?.Period;
                CqlInterval<CqlDateTime> wzzzzzzzzzzzzzzzs_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, wzzzzzzzzzzzzzzzr_);
                bool? wzzzzzzzzzzzzzzzt_ = context.Operators.In<CqlDateTime>(wzzzzzzzzzzzzzzzq_, wzzzzzzzzzzzzzzzs_, default);

                return wzzzzzzzzzzzzzzzt_;
            };
            IEnumerable<Encounter> wzzzzzzzzzzzzzzzm_ = context.Operators.Where<Encounter>(wzzzzzzzzzzzzzzzk_, wzzzzzzzzzzzzzzzl_);
            Communication wzzzzzzzzzzzzzzzn_(Encounter EncounterDiabeticRetinopathy) =>
                MacularEdemaAbsentNotCommunicated;
            IEnumerable<Communication> wzzzzzzzzzzzzzzzo_ = context.Operators.Select<Encounter, Communication>(wzzzzzzzzzzzzzzzm_, wzzzzzzzzzzzzzzzn_);

            return wzzzzzzzzzzzzzzzo_;
        };
        IEnumerable<Communication> wzzzzzzzzzzzzzzzh_ = context.Operators.SelectMany<Communication, Communication>(wzzzzzzzzzzzzzzzf_, wzzzzzzzzzzzzzzzg_);
        bool? wzzzzzzzzzzzzzzzi_(Communication MacularEdemaAbsentNotCommunicated)
        {
            CodeableConcept wzzzzzzzzzzzzzzzu_ = MacularEdemaAbsentNotCommunicated?.StatusReason;
            CqlConcept wzzzzzzzzzzzzzzzv_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, wzzzzzzzzzzzzzzzu_);
            CqlValueSet wzzzzzzzzzzzzzzzw_ = this.Medical_Reason(context);
            bool? wzzzzzzzzzzzzzzzx_ = context.Operators.ConceptInValueSet(wzzzzzzzzzzzzzzzv_, wzzzzzzzzzzzzzzzw_);
            CqlConcept wzzzzzzzzzzzzzzzz_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, wzzzzzzzzzzzzzzzu_);
            CqlValueSet xzzzzzzzzzzzzzzza_ = this.Patient_Reason(context);
            bool? xzzzzzzzzzzzzzzzb_ = context.Operators.ConceptInValueSet(wzzzzzzzzzzzzzzzz_, xzzzzzzzzzzzzzzza_);
            bool? xzzzzzzzzzzzzzzzc_ = context.Operators.Or(wzzzzzzzzzzzzzzzx_, xzzzzzzzzzzzzzzzb_);

            return xzzzzzzzzzzzzzzzc_;
        };
        IEnumerable<Communication> wzzzzzzzzzzzzzzzj_ = context.Operators.Where<Communication>(wzzzzzzzzzzzzzzzh_, wzzzzzzzzzzzzzzzi_);

        return wzzzzzzzzzzzzzzzj_;
    }


    [CqlExpressionDefinition("Medical or Patient Reason for Not Communicating Presence of Macular Edema")]
    public IEnumerable<Communication> Medical_or_Patient_Reason_for_Not_Communicating_Presence_of_Macular_Edema(CqlContext context)
    {
        PropertyInfo xzzzzzzzzzzzzzzzd_ = typeof(Communication).GetProperty("ReasonCode");
        CqlValueSet xzzzzzzzzzzzzzzze_ = this.Macular_Edema_Findings_Present(context);
        IEnumerable<Communication> xzzzzzzzzzzzzzzzf_ = context.Operators.Retrieve<Communication>(new RetrieveParameters(xzzzzzzzzzzzzzzzd_, xzzzzzzzzzzzzzzze_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-communicationnotdone"));
        IEnumerable<Communication> xzzzzzzzzzzzzzzzi_ = context.Operators.Retrieve<Communication>(new RetrieveParameters(xzzzzzzzzzzzzzzzd_, xzzzzzzzzzzzzzzze_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-communicationnotdone"));
        IEnumerable<Communication> xzzzzzzzzzzzzzzzj_ = context.Operators.Union<Communication>(xzzzzzzzzzzzzzzzf_, xzzzzzzzzzzzzzzzi_);
        IEnumerable<Communication> xzzzzzzzzzzzzzzzk_(Communication MacularEdemaPresentNotCommunicated)
        {
            IEnumerable<Encounter> xzzzzzzzzzzzzzzzo_ = this.Diabetic_Retinopathy_Encounter(context);
            bool? xzzzzzzzzzzzzzzzp_(Encounter EncounterDiabeticRetinopathy)
            {
                FhirDateTime xzzzzzzzzzzzzzzzt_ = MacularEdemaPresentNotCommunicated?.SentElement;
                CqlDateTime xzzzzzzzzzzzzzzzu_ = context.Operators.Convert<CqlDateTime>(xzzzzzzzzzzzzzzzt_);
                Period xzzzzzzzzzzzzzzzv_ = EncounterDiabeticRetinopathy?.Period;
                CqlInterval<CqlDateTime> xzzzzzzzzzzzzzzzw_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, xzzzzzzzzzzzzzzzv_);
                bool? xzzzzzzzzzzzzzzzx_ = context.Operators.In<CqlDateTime>(xzzzzzzzzzzzzzzzu_, xzzzzzzzzzzzzzzzw_, default);

                return xzzzzzzzzzzzzzzzx_;
            };
            IEnumerable<Encounter> xzzzzzzzzzzzzzzzq_ = context.Operators.Where<Encounter>(xzzzzzzzzzzzzzzzo_, xzzzzzzzzzzzzzzzp_);
            Communication xzzzzzzzzzzzzzzzr_(Encounter EncounterDiabeticRetinopathy) =>
                MacularEdemaPresentNotCommunicated;
            IEnumerable<Communication> xzzzzzzzzzzzzzzzs_ = context.Operators.Select<Encounter, Communication>(xzzzzzzzzzzzzzzzq_, xzzzzzzzzzzzzzzzr_);

            return xzzzzzzzzzzzzzzzs_;
        };
        IEnumerable<Communication> xzzzzzzzzzzzzzzzl_ = context.Operators.SelectMany<Communication, Communication>(xzzzzzzzzzzzzzzzj_, xzzzzzzzzzzzzzzzk_);
        bool? xzzzzzzzzzzzzzzzm_(Communication MacularEdemaPresentNotCommunicated)
        {
            CodeableConcept xzzzzzzzzzzzzzzzy_ = MacularEdemaPresentNotCommunicated?.StatusReason;
            CqlConcept xzzzzzzzzzzzzzzzz_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, xzzzzzzzzzzzzzzzy_);
            CqlValueSet yzzzzzzzzzzzzzzza_ = this.Medical_Reason(context);
            bool? yzzzzzzzzzzzzzzzb_ = context.Operators.ConceptInValueSet(xzzzzzzzzzzzzzzzz_, yzzzzzzzzzzzzzzza_);
            CqlConcept yzzzzzzzzzzzzzzzd_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, xzzzzzzzzzzzzzzzy_);
            CqlValueSet yzzzzzzzzzzzzzzze_ = this.Patient_Reason(context);
            bool? yzzzzzzzzzzzzzzzf_ = context.Operators.ConceptInValueSet(yzzzzzzzzzzzzzzzd_, yzzzzzzzzzzzzzzze_);
            bool? yzzzzzzzzzzzzzzzg_ = context.Operators.Or(yzzzzzzzzzzzzzzzb_, yzzzzzzzzzzzzzzzf_);

            return yzzzzzzzzzzzzzzzg_;
        };
        IEnumerable<Communication> xzzzzzzzzzzzzzzzn_ = context.Operators.Where<Communication>(xzzzzzzzzzzzzzzzl_, xzzzzzzzzzzzzzzzm_);

        return xzzzzzzzzzzzzzzzn_;
    }


    [CqlExpressionDefinition("Denominator Exceptions")]
    public bool? Denominator_Exceptions(CqlContext context)
    {
        IEnumerable<Communication> yzzzzzzzzzzzzzzzh_ = this.Medical_or_Patient_Reason_for_Not_Communicating_Level_of_Severity_of_Retinopathy(context);
        bool? yzzzzzzzzzzzzzzzi_ = context.Operators.Exists<Communication>(yzzzzzzzzzzzzzzzh_);
        IEnumerable<Communication> yzzzzzzzzzzzzzzzj_ = this.Medical_or_Patient_Reason_for_Not_Communicating_Absence_of_Macular_Edema(context);
        bool? yzzzzzzzzzzzzzzzk_ = context.Operators.Exists<Communication>(yzzzzzzzzzzzzzzzj_);
        bool? yzzzzzzzzzzzzzzzl_ = context.Operators.Or(yzzzzzzzzzzzzzzzi_, yzzzzzzzzzzzzzzzk_);
        IEnumerable<Communication> yzzzzzzzzzzzzzzzm_ = this.Medical_or_Patient_Reason_for_Not_Communicating_Presence_of_Macular_Edema(context);
        bool? yzzzzzzzzzzzzzzzn_ = context.Operators.Exists<Communication>(yzzzzzzzzzzzzzzzm_);
        bool? yzzzzzzzzzzzzzzzo_ = context.Operators.Or(yzzzzzzzzzzzzzzzl_, yzzzzzzzzzzzzzzzn_);

        return yzzzzzzzzzzzzzzzo_;
    }


    [CqlExpressionDefinition("Results of Dilated Macular or Fundus Exam Communicated")]
    public bool? Results_of_Dilated_Macular_or_Fundus_Exam_Communicated(CqlContext context)
    {
        IEnumerable<Communication> yzzzzzzzzzzzzzzzp_ = this.Level_of_Severity_of_Retinopathy_Findings_Communicated(context);
        bool? yzzzzzzzzzzzzzzzq_ = context.Operators.Exists<Communication>(yzzzzzzzzzzzzzzzp_);
        IEnumerable<Communication> yzzzzzzzzzzzzzzzr_ = this.Macular_Edema_Absence_Communicated(context);
        bool? yzzzzzzzzzzzzzzzs_ = context.Operators.Exists<Communication>(yzzzzzzzzzzzzzzzr_);
        IEnumerable<Communication> yzzzzzzzzzzzzzzzt_ = this.Macular_Edema_Presence_Communicated(context);
        bool? yzzzzzzzzzzzzzzzu_ = context.Operators.Exists<Communication>(yzzzzzzzzzzzzzzzt_);
        bool? yzzzzzzzzzzzzzzzv_ = context.Operators.Or(yzzzzzzzzzzzzzzzs_, yzzzzzzzzzzzzzzzu_);
        bool? yzzzzzzzzzzzzzzzw_ = context.Operators.And(yzzzzzzzzzzzzzzzq_, yzzzzzzzzzzzzzzzv_);

        return yzzzzzzzzzzzzzzzw_;
    }


    #endregion Expressions

}
