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
[CqlLibrary("ChildandAdolescentMajorDepressiveDisorderMDDSuicideRiskAssessmentFHIR", "0.1.000")]
public partial class ChildandAdolescentMajorDepressiveDisorderMDDSuicideRiskAssessmentFHIR_0_1_000 : ILibrary, ISingleton<ChildandAdolescentMajorDepressiveDisorderMDDSuicideRiskAssessmentFHIR_0_1_000>
{
    private ChildandAdolescentMajorDepressiveDisorderMDDSuicideRiskAssessmentFHIR_0_1_000() {}

    public static ChildandAdolescentMajorDepressiveDisorderMDDSuicideRiskAssessmentFHIR_0_1_000 Instance { get; } = new();

    #region ILibrary Implementation

    public string Name => "ChildandAdolescentMajorDepressiveDisorderMDDSuicideRiskAssessmentFHIR";
    public string Version => "0.1.000";
    public ILibrary[] Dependencies => [SupplementalDataElements_3_5_000.Instance, QICoreCommon_2_1_000.Instance, FHIRHelpers_4_4_000.Instance, CQMCommon_2_2_000.Instance];

    #endregion ILibrary Implementation

    #region ValueSets

    [CqlValueSetDefinition("Group Psychotherapy", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1187", valueSetVersion: null)]
    public CqlValueSet Group_Psychotherapy(CqlContext _) => _Group_Psychotherapy;
    private static readonly CqlValueSet _Group_Psychotherapy = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1187", null);

    [CqlValueSetDefinition("Major Depressive Disorder Active", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1491", valueSetVersion: null)]
    public CqlValueSet Major_Depressive_Disorder_Active(CqlContext _) => _Major_Depressive_Disorder_Active;
    private static readonly CqlValueSet _Major_Depressive_Disorder_Active = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1491", null);

    [CqlValueSetDefinition("Office Visit", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1001", valueSetVersion: null)]
    public CqlValueSet Office_Visit(CqlContext _) => _Office_Visit;
    private static readonly CqlValueSet _Office_Visit = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1001", null);

    [CqlValueSetDefinition("Outpatient Consultation", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1008", valueSetVersion: null)]
    public CqlValueSet Outpatient_Consultation(CqlContext _) => _Outpatient_Consultation;
    private static readonly CqlValueSet _Outpatient_Consultation = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1008", null);

    [CqlValueSetDefinition("Psych Visit Diagnostic Evaluation", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1492", valueSetVersion: null)]
    public CqlValueSet Psych_Visit_Diagnostic_Evaluation(CqlContext _) => _Psych_Visit_Diagnostic_Evaluation;
    private static readonly CqlValueSet _Psych_Visit_Diagnostic_Evaluation = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1492", null);

    [CqlValueSetDefinition("Psych Visit for Family Psychotherapy", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1018", valueSetVersion: null)]
    public CqlValueSet Psych_Visit_for_Family_Psychotherapy(CqlContext _) => _Psych_Visit_for_Family_Psychotherapy;
    private static readonly CqlValueSet _Psych_Visit_for_Family_Psychotherapy = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1018", null);

    [CqlValueSetDefinition("Psych Visit Psychotherapy", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1496", valueSetVersion: null)]
    public CqlValueSet Psych_Visit_Psychotherapy(CqlContext _) => _Psych_Visit_Psychotherapy;
    private static readonly CqlValueSet _Psych_Visit_Psychotherapy = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1496", null);

    [CqlValueSetDefinition("Psychoanalysis", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1141", valueSetVersion: null)]
    public CqlValueSet Psychoanalysis(CqlContext _) => _Psychoanalysis;
    private static readonly CqlValueSet _Psychoanalysis = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1141", null);

    [CqlValueSetDefinition("Telephone Visits", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1080", valueSetVersion: null)]
    public CqlValueSet Telephone_Visits(CqlContext _) => _Telephone_Visits;
    private static readonly CqlValueSet _Telephone_Visits = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1080", null);

    #endregion ValueSets

    #region Codes

    [CqlCodeDefinition("Birth date", codeId: "21112-8", codeSystem: "http://loinc.org")]
    public CqlCode Birth_date(CqlContext _) => _Birth_date;
    private static readonly CqlCode _Birth_date = new CqlCode("21112-8", "http://loinc.org", default, default);

    [CqlCodeDefinition("Suicide risk assessment (procedure)", codeId: "225337009", codeSystem: "http://snomed.info/sct")]
    public CqlCode Suicide_risk_assessment__procedure_(CqlContext _) => _Suicide_risk_assessment__procedure_;
    private static readonly CqlCode _Suicide_risk_assessment__procedure_ = new CqlCode("225337009", "http://snomed.info/sct", default, default);

    [CqlCodeDefinition("AMB", codeId: "AMB", codeSystem: "http://terminology.hl7.org/CodeSystem/v3-ActCode")]
    public CqlCode AMB(CqlContext _) => _AMB;
    private static readonly CqlCode _AMB = new CqlCode("AMB", "http://terminology.hl7.org/CodeSystem/v3-ActCode", default, default);

    #endregion Codes

    #region CodeSystems

    [CqlCodeSystemDefinition("LOINC")]
    public CqlCodeSystem LOINC(CqlContext _) => _LOINC;
    private static readonly CqlCodeSystem _LOINC = new CqlCodeSystem();

    [CqlCodeSystemDefinition("SNOMEDCT")]
    public CqlCodeSystem SNOMEDCT(CqlContext _) => _SNOMEDCT;
    private static readonly CqlCodeSystem _SNOMEDCT = new CqlCodeSystem();

    [CqlCodeSystemDefinition("ActCode")]
    public CqlCodeSystem ActCode(CqlContext _) => _ActCode;
    private static readonly CqlCodeSystem _ActCode = new CqlCodeSystem();

    [CqlCodeSystemDefinition("ICD10CM")]
    public CqlCodeSystem ICD10CM(CqlContext _) => _ICD10CM;
    private static readonly CqlCodeSystem _ICD10CM = new CqlCodeSystem();

    #endregion CodeSystems

    #region Parameters

    [CqlParameterDefinition("Measurement Period")]
    public CqlInterval<CqlDateTime> Measurement_Period(CqlContext context)
    {
        CqlDateTime szzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.DateTime(2025, 1, 1, 0, 0, 0, 0, 0.0m);
        CqlDateTime szzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.DateTime(2025, 12, 31, 23, 59, 59, 999, 0.0m);
        CqlInterval<CqlDateTime> szzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Interval(szzzzzzzzzzzzzzzzzzzzzzzzzzzzr_, szzzzzzzzzzzzzzzzzzzzzzzzzzzzs_, true, true);
        object szzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.ResolveParameter("ChildandAdolescentMajorDepressiveDisorderMDDSuicideRiskAssessmentFHIR-0.1.000", "Measurement Period", szzzzzzzzzzzzzzzzzzzzzzzzzzzzt_);

        return (CqlInterval<CqlDateTime>)szzzzzzzzzzzzzzzzzzzzzzzzzzzzu_;
    }


    #endregion Parameters

    #region Expressions

    [CqlExpressionDefinition("Patient")]
    public Patient Patient(CqlContext context)
    {
        IEnumerable<Patient> szzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-patient"));
        Patient szzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.SingletonFrom<Patient>(szzzzzzzzzzzzzzzzzzzzzzzzzzzzv_);

        return szzzzzzzzzzzzzzzzzzzzzzzzzzzzw_;
    }


    [CqlExpressionDefinition("SDE Ethnicity")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Ethnicity(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? szzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = SupplementalDataElements_3_5_000.Instance.SDE_Ethnicity(context);

        return szzzzzzzzzzzzzzzzzzzzzzzzzzzzx_;
    }


    [CqlExpressionDefinition("SDE Payer")]
    public IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> SDE_Payer(CqlContext context)
    {
        IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> szzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = SupplementalDataElements_3_5_000.Instance.SDE_Payer(context);

        return szzzzzzzzzzzzzzzzzzzzzzzzzzzzy_;
    }


    [CqlExpressionDefinition("SDE Race")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Race(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? szzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = SupplementalDataElements_3_5_000.Instance.SDE_Race(context);

        return szzzzzzzzzzzzzzzzzzzzzzzzzzzzz_;
    }


    [CqlExpressionDefinition("SDE Sex")]
    public CqlCode SDE_Sex(CqlContext context)
    {
        CqlCode tzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = SupplementalDataElements_3_5_000.Instance.SDE_Sex(context);

        return tzzzzzzzzzzzzzzzzzzzzzzzzzzzza_;
    }


    [CqlExpressionDefinition("Major Depressive Disorder Encounter")]
    public IEnumerable<Encounter> Major_Depressive_Disorder_Encounter(CqlContext context)
    {
        CqlValueSet tzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = this.Office_Visit(context);
        IEnumerable<Encounter> tzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, tzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        CqlValueSet tzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = this.Outpatient_Consultation(context);
        IEnumerable<Encounter> tzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, tzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> tzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Union<Encounter>(tzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_, tzzzzzzzzzzzzzzzzzzzzzzzzzzzze_);
        CqlValueSet tzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = this.Psych_Visit_Diagnostic_Evaluation(context);
        IEnumerable<Encounter> tzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, tzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        CqlValueSet tzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = this.Psych_Visit_for_Family_Psychotherapy(context);
        IEnumerable<Encounter> tzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, tzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> tzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Union<Encounter>(tzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_, tzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_);
        IEnumerable<Encounter> tzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Union<Encounter>(tzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_, tzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_);
        CqlValueSet tzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = this.Psych_Visit_Psychotherapy(context);
        IEnumerable<Encounter> tzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, tzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        CqlValueSet tzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = this.Psychoanalysis(context);
        IEnumerable<Encounter> tzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, tzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> tzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Union<Encounter>(tzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_, tzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_);
        IEnumerable<Encounter> tzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Union<Encounter>(tzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_, tzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_);
        CqlValueSet tzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = this.Group_Psychotherapy(context);
        IEnumerable<Encounter> tzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, tzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        CqlValueSet tzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = this.Telephone_Visits(context);
        IEnumerable<Encounter> tzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, tzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> tzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Union<Encounter>(tzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_, tzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_);
        IEnumerable<Encounter> tzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Union<Encounter>(tzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_, tzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_);
        bool? tzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_(Encounter ValidEncounter)
        {
            Code<Encounter.EncounterStatus> uzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = ValidEncounter?.StatusElement;
            Encounter.EncounterStatus? uzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = uzzzzzzzzzzzzzzzzzzzzzzzzzzzza_?.Value;
            Code<Encounter.EncounterStatus> uzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(uzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_);
            bool? uzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Equal(uzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_, "finished");
            List<CodeableConcept> uzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = ValidEncounter?.ReasonCode;
            CqlConcept uzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_(CodeableConcept @this)
            {
                CqlConcept uzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);

                return uzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_;
            };
            IEnumerable<CqlConcept> uzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)uzzzzzzzzzzzzzzzzzzzzzzzzzzzze_, uzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_);
            CqlValueSet uzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = this.Major_Depressive_Disorder_Active(context);
            bool? uzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.ConceptsInValueSet(uzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_, uzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_);
            IEnumerable<Condition> uzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = CQMCommon_2_2_000.Instance.encounterDiagnosis(context, ValidEncounter);
            bool? uzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_(Condition EncounterDiagnosis)
            {
                CodeableConcept uzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = EncounterDiagnosis?.Code;
                CqlConcept uzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, uzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_);
                CqlValueSet uzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = this.Major_Depressive_Disorder_Active(context);
                bool? uzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.ConceptInValueSet(uzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_, uzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_);

                return uzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_;
            };
            IEnumerable<Condition> uzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Where<Condition>(uzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_, uzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_);
            bool? uzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Exists<Condition>(uzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_);
            bool? uzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Or(uzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_, uzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_);
            bool? uzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.And(uzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_, uzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_);
            CqlInterval<CqlDateTime> uzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = this.Measurement_Period(context);
            Period uzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = ValidEncounter?.Period;
            CqlInterval<CqlDateTime> uzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, uzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_);
            bool? uzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(uzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_, uzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_, "day");
            bool? uzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.And(uzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_, uzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_);

            return uzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_;
        };
        IEnumerable<Encounter> tzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Where<Encounter>(tzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_, tzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_);

        return tzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_;
    }


    [CqlExpressionDefinition("Initial Population")]
    public IEnumerable<Encounter> Initial_Population(CqlContext context)
    {
        IEnumerable<Encounter> uzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = this.Major_Depressive_Disorder_Encounter(context);
        bool? vzzzzzzzzzzzzzzzzzzzzzzzzzzzza_(Encounter MDDEncounter)
        {
            Patient vzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = this.Patient(context);
            Date vzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = vzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_?.BirthDateElement;
            string vzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = vzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_?.Value;
            CqlDate vzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.ConvertStringToDate(vzzzzzzzzzzzzzzzzzzzzzzzzzzzze_);
            CqlInterval<CqlDateTime> vzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = this.Measurement_Period(context);
            CqlDateTime vzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Start(vzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_);
            CqlDate vzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.DateFrom(vzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_);
            int? vzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.CalculateAgeAt(vzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_, vzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_, "year");
            bool? vzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.GreaterOrEqual(vzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_, 6);
            Date vzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = vzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_?.BirthDateElement;
            string vzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = vzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_?.Value;
            CqlDate vzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.ConvertStringToDate(vzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_);
            CqlDateTime vzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Start(vzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_);
            CqlDate vzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.DateFrom(vzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_);
            int? vzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.CalculateAgeAt(vzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_, vzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_, "year");
            bool? vzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.LessOrEqual(vzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_, 16);
            bool? vzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.And(vzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_, vzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_);

            return vzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_;
        };
        IEnumerable<Encounter> vzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Where<Encounter>(uzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_, vzzzzzzzzzzzzzzzzzzzzzzzzzzzza_);

        return vzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_;
    }


    [CqlExpressionDefinition("Denominator")]
    public IEnumerable<Encounter> Denominator(CqlContext context)
    {
        IEnumerable<Encounter> vzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = this.Initial_Population(context);

        return vzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_;
    }


    [CqlExpressionDefinition("Numerator")]
    public IEnumerable<Encounter> Numerator(CqlContext context)
    {
        IEnumerable<Encounter> vzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = this.Major_Depressive_Disorder_Encounter(context);
        IEnumerable<Encounter> vzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_(Encounter MDDEncounter)
        {
            CqlCode vzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = this.Suicide_risk_assessment__procedure_(context);
            IEnumerable<CqlCode> wzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.ToList<CqlCode>(vzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_);
            IEnumerable<Procedure> wzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, default, wzzzzzzzzzzzzzzzzzzzzzzzzzzzza_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
            bool? wzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_(Procedure SuicideRiskAssessment)
            {
                Code<EventStatus> wzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = SuicideRiskAssessment?.StatusElement;
                EventStatus? wzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = wzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_?.Value;
                string wzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Convert<string>(wzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_);
                bool? wzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Equal(wzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_, "completed");
                Period wzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = MDDEncounter?.Period;
                CqlInterval<CqlDateTime> wzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, wzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_);
                DataType wzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = SuicideRiskAssessment?.Performed;
                object wzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = FHIRHelpers_4_4_000.Instance.ToValue(context, wzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_);
                CqlInterval<CqlDateTime> wzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = QICoreCommon_2_1_000.Instance.toInterval(context, wzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_);
                bool? wzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(wzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_, wzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_, default);
                bool? wzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.And(wzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_, wzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_);

                return wzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_;
            };
            IEnumerable<Procedure> wzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Where<Procedure>(wzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_, wzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_);
            Encounter wzzzzzzzzzzzzzzzzzzzzzzzzzzzze_(Procedure SuicideRiskAssessment) =>
                MDDEncounter;
            IEnumerable<Encounter> wzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Select<Procedure, Encounter>(wzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_, wzzzzzzzzzzzzzzzzzzzzzzzzzzzze_);

            return wzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_;
        };
        IEnumerable<Encounter> vzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.SelectMany<Encounter, Encounter>(vzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_, vzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_);

        return vzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_;
    }


    #endregion Expressions

}
