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

    #region ValueSet: Group Psychotherapy
    [CqlValueSetDefinition(
        definitionName: "Group Psychotherapy",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1187",
        valueSetVersion: null)]
    public CqlValueSet Group_Psychotherapy(CqlContext context) => _Group_Psychotherapy;

    private static readonly CqlValueSet _Group_Psychotherapy = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1187", null);
    #endregion

    #region ValueSet: Major Depressive Disorder Active
    [CqlValueSetDefinition(
        definitionName: "Major Depressive Disorder Active",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1491",
        valueSetVersion: null)]
    public CqlValueSet Major_Depressive_Disorder_Active(CqlContext context) => _Major_Depressive_Disorder_Active;

    private static readonly CqlValueSet _Major_Depressive_Disorder_Active = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1491", null);
    #endregion

    #region ValueSet: Office Visit
    [CqlValueSetDefinition(
        definitionName: "Office Visit",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1001",
        valueSetVersion: null)]
    public CqlValueSet Office_Visit(CqlContext context) => _Office_Visit;

    private static readonly CqlValueSet _Office_Visit = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1001", null);
    #endregion

    #region ValueSet: Outpatient Consultation
    [CqlValueSetDefinition(
        definitionName: "Outpatient Consultation",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1008",
        valueSetVersion: null)]
    public CqlValueSet Outpatient_Consultation(CqlContext context) => _Outpatient_Consultation;

    private static readonly CqlValueSet _Outpatient_Consultation = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1008", null);
    #endregion

    #region ValueSet: Psych Visit Diagnostic Evaluation
    [CqlValueSetDefinition(
        definitionName: "Psych Visit Diagnostic Evaluation",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1492",
        valueSetVersion: null)]
    public CqlValueSet Psych_Visit_Diagnostic_Evaluation(CqlContext context) => _Psych_Visit_Diagnostic_Evaluation;

    private static readonly CqlValueSet _Psych_Visit_Diagnostic_Evaluation = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1492", null);
    #endregion

    #region ValueSet: Psych Visit for Family Psychotherapy
    [CqlValueSetDefinition(
        definitionName: "Psych Visit for Family Psychotherapy",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1018",
        valueSetVersion: null)]
    public CqlValueSet Psych_Visit_for_Family_Psychotherapy(CqlContext context) => _Psych_Visit_for_Family_Psychotherapy;

    private static readonly CqlValueSet _Psych_Visit_for_Family_Psychotherapy = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1018", null);
    #endregion

    #region ValueSet: Psych Visit Psychotherapy
    [CqlValueSetDefinition(
        definitionName: "Psych Visit Psychotherapy",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1496",
        valueSetVersion: null)]
    public CqlValueSet Psych_Visit_Psychotherapy(CqlContext context) => _Psych_Visit_Psychotherapy;

    private static readonly CqlValueSet _Psych_Visit_Psychotherapy = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1496", null);
    #endregion

    #region ValueSet: Psychoanalysis
    [CqlValueSetDefinition(
        definitionName: "Psychoanalysis",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1141",
        valueSetVersion: null)]
    public CqlValueSet Psychoanalysis(CqlContext context) => _Psychoanalysis;

    private static readonly CqlValueSet _Psychoanalysis = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1141", null);
    #endregion

    #region ValueSet: Telephone Visits
    [CqlValueSetDefinition(
        definitionName: "Telephone Visits",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1080",
        valueSetVersion: null)]
    public CqlValueSet Telephone_Visits(CqlContext context) => _Telephone_Visits;

    private static readonly CqlValueSet _Telephone_Visits = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1080", null);
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

    #region Code: Suicide risk assessment (procedure)
    [CqlCodeDefinition(
        definitionName: "Suicide risk assessment (procedure)",
        codeId: "225337009",
        codeSystem: "http://snomed.info/sct")]
    public CqlCode Suicide_risk_assessment__procedure_(CqlContext context) => _Suicide_risk_assessment__procedure_;

    private static readonly CqlCode _Suicide_risk_assessment__procedure_ = new CqlCode("225337009", "http://snomed.info/sct", default, default);
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
        definitionName: "LOINC")]
    public CqlCode[] LOINC(CqlContext context)
    {
        CqlCode[] hzzzzzzzzzzw_ = [
            new CqlCode("21112-8", "http://loinc.org", default, default),
        ];

        return hzzzzzzzzzzw_;
    }


    [CqlCodeSystemDefinition(
        definitionName: "SNOMEDCT")]
    public CqlCode[] SNOMEDCT(CqlContext context)
    {
        CqlCode[] hzzzzzzzzzzx_ = [
            new CqlCode("225337009", "http://snomed.info/sct", default, default),
        ];

        return hzzzzzzzzzzx_;
    }


    [CqlCodeSystemDefinition(
        definitionName: "ActCode")]
    public CqlCode[] ActCode(CqlContext context)
    {
        CqlCode[] hzzzzzzzzzzy_ = [
            new CqlCode("AMB", "http://terminology.hl7.org/CodeSystem/v3-ActCode", default, default),
        ];

        return hzzzzzzzzzzy_;
    }


    [CqlCodeSystemDefinition(
        definitionName: "ICD10CM")]
    public CqlCode[] ICD10CM(CqlContext context)
    {
        CqlCode[] hzzzzzzzzzzz_ = []
;

        return hzzzzzzzzzzz_;
    }


    #endregion CodeSystems

    #region Parameters

    [CqlParameterDefinition(
        definitionName: "Measurement Period")]
    public CqlInterval<CqlDateTime> Measurement_Period(CqlContext context)
    {
        CqlDateTime izzzzzzzzzza_ = context.Operators.DateTime(2025, 1, 1, 0, 0, 0, 0, 0.0m);
        CqlDateTime izzzzzzzzzzb_ = context.Operators.DateTime(2025, 12, 31, 23, 59, 59, 999, 0.0m);
        CqlInterval<CqlDateTime> izzzzzzzzzzc_ = context.Operators.Interval(izzzzzzzzzza_, izzzzzzzzzzb_, true, true);
        object izzzzzzzzzzd_ = context.ResolveParameter("ChildandAdolescentMajorDepressiveDisorderMDDSuicideRiskAssessmentFHIR-0.1.000", "Measurement Period", izzzzzzzzzzc_);

        return (CqlInterval<CqlDateTime>)izzzzzzzzzzd_;
    }


    #endregion Parameters

    #region Expressions

    [CqlExpressionDefinition(
        definitionName: "Patient")]
    public Patient Patient(CqlContext context)
    {
        IEnumerable<Patient> izzzzzzzzzze_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-patient"));
        Patient izzzzzzzzzzf_ = context.Operators.SingletonFrom<Patient>(izzzzzzzzzze_);

        return izzzzzzzzzzf_;
    }


    [CqlExpressionDefinition(
        definitionName: "SDE Ethnicity")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Ethnicity(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? izzzzzzzzzzg_ = SupplementalDataElements_3_5_000.Instance.SDE_Ethnicity(context);

        return izzzzzzzzzzg_;
    }


    [CqlExpressionDefinition(
        definitionName: "SDE Payer")]
    public IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> SDE_Payer(CqlContext context)
    {
        IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> izzzzzzzzzzh_ = SupplementalDataElements_3_5_000.Instance.SDE_Payer(context);

        return izzzzzzzzzzh_;
    }


    [CqlExpressionDefinition(
        definitionName: "SDE Race")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Race(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? izzzzzzzzzzi_ = SupplementalDataElements_3_5_000.Instance.SDE_Race(context);

        return izzzzzzzzzzi_;
    }


    [CqlExpressionDefinition(
        definitionName: "SDE Sex")]
    public CqlCode SDE_Sex(CqlContext context)
    {
        CqlCode izzzzzzzzzzj_ = SupplementalDataElements_3_5_000.Instance.SDE_Sex(context);

        return izzzzzzzzzzj_;
    }


    [CqlExpressionDefinition(
        definitionName: "Major Depressive Disorder Encounter")]
    public IEnumerable<Encounter> Major_Depressive_Disorder_Encounter(CqlContext context)
    {
        CqlValueSet izzzzzzzzzzk_ = this.Office_Visit(context);
        IEnumerable<Encounter> izzzzzzzzzzl_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, izzzzzzzzzzk_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        CqlValueSet izzzzzzzzzzm_ = this.Outpatient_Consultation(context);
        IEnumerable<Encounter> izzzzzzzzzzn_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, izzzzzzzzzzm_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> izzzzzzzzzzo_ = context.Operators.Union<Encounter>(izzzzzzzzzzl_, izzzzzzzzzzn_);
        CqlValueSet izzzzzzzzzzp_ = this.Psych_Visit_Diagnostic_Evaluation(context);
        IEnumerable<Encounter> izzzzzzzzzzq_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, izzzzzzzzzzp_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        CqlValueSet izzzzzzzzzzr_ = this.Psych_Visit_for_Family_Psychotherapy(context);
        IEnumerable<Encounter> izzzzzzzzzzs_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, izzzzzzzzzzr_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> izzzzzzzzzzt_ = context.Operators.Union<Encounter>(izzzzzzzzzzq_, izzzzzzzzzzs_);
        IEnumerable<Encounter> izzzzzzzzzzu_ = context.Operators.Union<Encounter>(izzzzzzzzzzo_, izzzzzzzzzzt_);
        CqlValueSet izzzzzzzzzzv_ = this.Psych_Visit_Psychotherapy(context);
        IEnumerable<Encounter> izzzzzzzzzzw_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, izzzzzzzzzzv_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        CqlValueSet izzzzzzzzzzx_ = this.Psychoanalysis(context);
        IEnumerable<Encounter> izzzzzzzzzzy_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, izzzzzzzzzzx_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> izzzzzzzzzzz_ = context.Operators.Union<Encounter>(izzzzzzzzzzw_, izzzzzzzzzzy_);
        IEnumerable<Encounter> jzzzzzzzzzza_ = context.Operators.Union<Encounter>(izzzzzzzzzzu_, izzzzzzzzzzz_);
        CqlValueSet jzzzzzzzzzzb_ = this.Group_Psychotherapy(context);
        IEnumerable<Encounter> jzzzzzzzzzzc_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, jzzzzzzzzzzb_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        CqlValueSet jzzzzzzzzzzd_ = this.Telephone_Visits(context);
        IEnumerable<Encounter> jzzzzzzzzzze_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, jzzzzzzzzzzd_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> jzzzzzzzzzzf_ = context.Operators.Union<Encounter>(jzzzzzzzzzzc_, jzzzzzzzzzze_);
        IEnumerable<Encounter> jzzzzzzzzzzg_ = context.Operators.Union<Encounter>(jzzzzzzzzzza_, jzzzzzzzzzzf_);
        bool? jzzzzzzzzzzh_(Encounter ValidEncounter)
        {
            Code<Encounter.EncounterStatus> jzzzzzzzzzzj_ = ValidEncounter?.StatusElement;
            Encounter.EncounterStatus? jzzzzzzzzzzk_ = jzzzzzzzzzzj_?.Value;
            Code<Encounter.EncounterStatus> jzzzzzzzzzzl_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(jzzzzzzzzzzk_);
            bool? jzzzzzzzzzzm_ = context.Operators.Equal(jzzzzzzzzzzl_, "finished");
            List<CodeableConcept> jzzzzzzzzzzn_ = ValidEncounter?.ReasonCode;
            CqlConcept jzzzzzzzzzzo_(CodeableConcept @this)
            {
                CqlConcept kzzzzzzzzzzd_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);

                return kzzzzzzzzzzd_;
            };
            IEnumerable<CqlConcept> jzzzzzzzzzzp_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)jzzzzzzzzzzn_, jzzzzzzzzzzo_);
            CqlValueSet jzzzzzzzzzzq_ = this.Major_Depressive_Disorder_Active(context);
            bool? jzzzzzzzzzzr_ = context.Operators.ConceptsInValueSet(jzzzzzzzzzzp_, jzzzzzzzzzzq_);
            IEnumerable<Condition> jzzzzzzzzzzs_ = CQMCommon_2_2_000.Instance.encounterDiagnosis(context, ValidEncounter);
            bool? jzzzzzzzzzzt_(Condition EncounterDiagnosis)
            {
                CodeableConcept kzzzzzzzzzze_ = EncounterDiagnosis?.Code;
                CqlConcept kzzzzzzzzzzf_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, kzzzzzzzzzze_);
                CqlValueSet kzzzzzzzzzzg_ = this.Major_Depressive_Disorder_Active(context);
                bool? kzzzzzzzzzzh_ = context.Operators.ConceptInValueSet(kzzzzzzzzzzf_, kzzzzzzzzzzg_);

                return kzzzzzzzzzzh_;
            };
            IEnumerable<Condition> jzzzzzzzzzzu_ = context.Operators.Where<Condition>(jzzzzzzzzzzs_, jzzzzzzzzzzt_);
            bool? jzzzzzzzzzzv_ = context.Operators.Exists<Condition>(jzzzzzzzzzzu_);
            bool? jzzzzzzzzzzw_ = context.Operators.Or(jzzzzzzzzzzr_, jzzzzzzzzzzv_);
            bool? jzzzzzzzzzzx_ = context.Operators.And(jzzzzzzzzzzm_, jzzzzzzzzzzw_);
            CqlInterval<CqlDateTime> jzzzzzzzzzzy_ = this.Measurement_Period(context);
            Period jzzzzzzzzzzz_ = ValidEncounter?.Period;
            CqlInterval<CqlDateTime> kzzzzzzzzzza_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, jzzzzzzzzzzz_);
            bool? kzzzzzzzzzzb_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(jzzzzzzzzzzy_, kzzzzzzzzzza_, "day");
            bool? kzzzzzzzzzzc_ = context.Operators.And(jzzzzzzzzzzx_, kzzzzzzzzzzb_);

            return kzzzzzzzzzzc_;
        };
        IEnumerable<Encounter> jzzzzzzzzzzi_ = context.Operators.Where<Encounter>(jzzzzzzzzzzg_, jzzzzzzzzzzh_);

        return jzzzzzzzzzzi_;
    }


    [CqlExpressionDefinition(
        definitionName: "Initial Population")]
    public IEnumerable<Encounter> Initial_Population(CqlContext context)
    {
        IEnumerable<Encounter> kzzzzzzzzzzi_ = this.Major_Depressive_Disorder_Encounter(context);
        bool? kzzzzzzzzzzj_(Encounter MDDEncounter)
        {
            Patient kzzzzzzzzzzl_ = this.Patient(context);
            Date kzzzzzzzzzzm_ = kzzzzzzzzzzl_?.BirthDateElement;
            string kzzzzzzzzzzn_ = kzzzzzzzzzzm_?.Value;
            CqlDate kzzzzzzzzzzo_ = context.Operators.ConvertStringToDate(kzzzzzzzzzzn_);
            CqlInterval<CqlDateTime> kzzzzzzzzzzp_ = this.Measurement_Period(context);
            CqlDateTime kzzzzzzzzzzq_ = context.Operators.Start(kzzzzzzzzzzp_);
            CqlDate kzzzzzzzzzzr_ = context.Operators.DateFrom(kzzzzzzzzzzq_);
            int? kzzzzzzzzzzs_ = context.Operators.CalculateAgeAt(kzzzzzzzzzzo_, kzzzzzzzzzzr_, "year");
            bool? kzzzzzzzzzzt_ = context.Operators.GreaterOrEqual(kzzzzzzzzzzs_, 6);
            Date kzzzzzzzzzzv_ = kzzzzzzzzzzl_?.BirthDateElement;
            string kzzzzzzzzzzw_ = kzzzzzzzzzzv_?.Value;
            CqlDate kzzzzzzzzzzx_ = context.Operators.ConvertStringToDate(kzzzzzzzzzzw_);
            CqlDateTime kzzzzzzzzzzz_ = context.Operators.Start(kzzzzzzzzzzp_);
            CqlDate lzzzzzzzzzza_ = context.Operators.DateFrom(kzzzzzzzzzzz_);
            int? lzzzzzzzzzzb_ = context.Operators.CalculateAgeAt(kzzzzzzzzzzx_, lzzzzzzzzzza_, "year");
            bool? lzzzzzzzzzzc_ = context.Operators.LessOrEqual(lzzzzzzzzzzb_, 16);
            bool? lzzzzzzzzzzd_ = context.Operators.And(kzzzzzzzzzzt_, lzzzzzzzzzzc_);

            return lzzzzzzzzzzd_;
        };
        IEnumerable<Encounter> kzzzzzzzzzzk_ = context.Operators.Where<Encounter>(kzzzzzzzzzzi_, kzzzzzzzzzzj_);

        return kzzzzzzzzzzk_;
    }


    [CqlExpressionDefinition(
        definitionName: "Denominator")]
    public IEnumerable<Encounter> Denominator(CqlContext context)
    {
        IEnumerable<Encounter> lzzzzzzzzzze_ = this.Initial_Population(context);

        return lzzzzzzzzzze_;
    }


    [CqlExpressionDefinition(
        definitionName: "Numerator")]
    public IEnumerable<Encounter> Numerator(CqlContext context)
    {
        IEnumerable<Encounter> lzzzzzzzzzzf_ = this.Major_Depressive_Disorder_Encounter(context);
        IEnumerable<Encounter> lzzzzzzzzzzg_(Encounter MDDEncounter)
        {
            CqlCode lzzzzzzzzzzi_ = this.Suicide_risk_assessment__procedure_(context);
            IEnumerable<CqlCode> lzzzzzzzzzzj_ = context.Operators.ToList<CqlCode>(lzzzzzzzzzzi_);
            IEnumerable<Procedure> lzzzzzzzzzzk_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, default, lzzzzzzzzzzj_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
            bool? lzzzzzzzzzzl_(Procedure SuicideRiskAssessment)
            {
                Code<EventStatus> lzzzzzzzzzzp_ = SuicideRiskAssessment?.StatusElement;
                EventStatus? lzzzzzzzzzzq_ = lzzzzzzzzzzp_?.Value;
                string lzzzzzzzzzzr_ = context.Operators.Convert<string>(lzzzzzzzzzzq_);
                bool? lzzzzzzzzzzs_ = context.Operators.Equal(lzzzzzzzzzzr_, "completed");
                Period lzzzzzzzzzzt_ = MDDEncounter?.Period;
                CqlInterval<CqlDateTime> lzzzzzzzzzzu_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, lzzzzzzzzzzt_);
                DataType lzzzzzzzzzzv_ = SuicideRiskAssessment?.Performed;
                object lzzzzzzzzzzw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, lzzzzzzzzzzv_);
                CqlInterval<CqlDateTime> lzzzzzzzzzzx_ = QICoreCommon_2_1_000.Instance.toInterval(context, lzzzzzzzzzzw_);
                bool? lzzzzzzzzzzy_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(lzzzzzzzzzzu_, lzzzzzzzzzzx_, default);
                bool? lzzzzzzzzzzz_ = context.Operators.And(lzzzzzzzzzzs_, lzzzzzzzzzzy_);

                return lzzzzzzzzzzz_;
            };
            IEnumerable<Procedure> lzzzzzzzzzzm_ = context.Operators.Where<Procedure>(lzzzzzzzzzzk_, lzzzzzzzzzzl_);
            Encounter lzzzzzzzzzzn_(Procedure SuicideRiskAssessment) =>
                MDDEncounter;
            IEnumerable<Encounter> lzzzzzzzzzzo_ = context.Operators.Select<Procedure, Encounter>(lzzzzzzzzzzm_, lzzzzzzzzzzn_);

            return lzzzzzzzzzzo_;
        };
        IEnumerable<Encounter> lzzzzzzzzzzh_ = context.Operators.SelectMany<Encounter, Encounter>(lzzzzzzzzzzf_, lzzzzzzzzzzg_);

        return lzzzzzzzzzzh_;
    }


    #endregion Expressions

}
