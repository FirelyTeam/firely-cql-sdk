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
    private static readonly CqlCode _Birth_date = new CqlCode("21112-8", "http://loinc.org");

    [CqlCodeDefinition("Suicide risk assessment (procedure)", codeId: "225337009", codeSystem: "http://snomed.info/sct")]
    public CqlCode Suicide_risk_assessment__procedure_(CqlContext _) => _Suicide_risk_assessment__procedure_;
    private static readonly CqlCode _Suicide_risk_assessment__procedure_ = new CqlCode("225337009", "http://snomed.info/sct");

    [CqlCodeDefinition("AMB", codeId: "AMB", codeSystem: "http://terminology.hl7.org/CodeSystem/v3-ActCode")]
    public CqlCode AMB(CqlContext _) => _AMB;
    private static readonly CqlCode _AMB = new CqlCode("AMB", "http://terminology.hl7.org/CodeSystem/v3-ActCode");

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
          _Suicide_risk_assessment__procedure_);

    [CqlCodeSystemDefinition("ActCode")]
    public CqlCodeSystem ActCode(CqlContext _) => _ActCode;
    private static readonly CqlCodeSystem _ActCode =
      new CqlCodeSystem("http://terminology.hl7.org/CodeSystem/v3-ActCode", null,
          _AMB);

    [CqlCodeSystemDefinition("ICD10CM")]
    public CqlCodeSystem ICD10CM(CqlContext _) => _ICD10CM;
    private static readonly CqlCodeSystem _ICD10CM =
      new CqlCodeSystem("http://hl7.org/fhir/sid/icd-10-cm", null);

    #endregion CodeSystems

    #region Parameters

    [CqlParameterDefinition("Measurement Period")]
    public CqlInterval<CqlDateTime> Measurement_Period(CqlContext context)
    {
        CqlDateTime mzzzzzzzzzzzzzzi_ = context.Operators.DateTime(2025, 1, 1, 0, 0, 0, 0, 0.0m);
        CqlDateTime mzzzzzzzzzzzzzzj_ = context.Operators.DateTime(2025, 12, 31, 23, 59, 59, 999, 0.0m);
        CqlInterval<CqlDateTime> mzzzzzzzzzzzzzzk_ = context.Operators.Interval(mzzzzzzzzzzzzzzi_, mzzzzzzzzzzzzzzj_, true, true);
        object mzzzzzzzzzzzzzzl_ = context.ResolveParameter("ChildandAdolescentMajorDepressiveDisorderMDDSuicideRiskAssessmentFHIR-0.1.000", "Measurement Period", mzzzzzzzzzzzzzzk_);

        return (CqlInterval<CqlDateTime>)mzzzzzzzzzzzzzzl_;
    }


    #endregion Parameters

    #region Expressions

    [CqlExpressionDefinition("Patient")]
    public Patient Patient(CqlContext context)
    {
        IEnumerable<Patient> mzzzzzzzzzzzzzzm_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-patient"));
        Patient mzzzzzzzzzzzzzzn_ = context.Operators.SingletonFrom<Patient>(mzzzzzzzzzzzzzzm_);

        return mzzzzzzzzzzzzzzn_;
    }


    [CqlExpressionDefinition("SDE Ethnicity")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Ethnicity(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? mzzzzzzzzzzzzzzo_ = SupplementalDataElements_3_5_000.Instance.SDE_Ethnicity(context);

        return mzzzzzzzzzzzzzzo_;
    }


    [CqlExpressionDefinition("SDE Payer")]
    public IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> SDE_Payer(CqlContext context)
    {
        IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> mzzzzzzzzzzzzzzp_ = SupplementalDataElements_3_5_000.Instance.SDE_Payer(context);

        return mzzzzzzzzzzzzzzp_;
    }


    [CqlExpressionDefinition("SDE Race")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Race(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? mzzzzzzzzzzzzzzq_ = SupplementalDataElements_3_5_000.Instance.SDE_Race(context);

        return mzzzzzzzzzzzzzzq_;
    }


    [CqlExpressionDefinition("SDE Sex")]
    public CqlCode SDE_Sex(CqlContext context)
    {
        CqlCode mzzzzzzzzzzzzzzr_ = SupplementalDataElements_3_5_000.Instance.SDE_Sex(context);

        return mzzzzzzzzzzzzzzr_;
    }


    [CqlExpressionDefinition("Major Depressive Disorder Encounter")]
    public IEnumerable<Encounter> Major_Depressive_Disorder_Encounter(CqlContext context)
    {
        CqlValueSet mzzzzzzzzzzzzzzs_ = this.Office_Visit(context);
        IEnumerable<Encounter> mzzzzzzzzzzzzzzt_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, mzzzzzzzzzzzzzzs_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        CqlValueSet mzzzzzzzzzzzzzzu_ = this.Outpatient_Consultation(context);
        IEnumerable<Encounter> mzzzzzzzzzzzzzzv_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, mzzzzzzzzzzzzzzu_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> mzzzzzzzzzzzzzzw_ = context.Operators.Union<Encounter>(mzzzzzzzzzzzzzzt_, mzzzzzzzzzzzzzzv_);
        CqlValueSet mzzzzzzzzzzzzzzx_ = this.Psych_Visit_Diagnostic_Evaluation(context);
        IEnumerable<Encounter> mzzzzzzzzzzzzzzy_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, mzzzzzzzzzzzzzzx_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        CqlValueSet mzzzzzzzzzzzzzzz_ = this.Psych_Visit_for_Family_Psychotherapy(context);
        IEnumerable<Encounter> nzzzzzzzzzzzzzza_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, mzzzzzzzzzzzzzzz_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> nzzzzzzzzzzzzzzb_ = context.Operators.Union<Encounter>(mzzzzzzzzzzzzzzy_, nzzzzzzzzzzzzzza_);
        IEnumerable<Encounter> nzzzzzzzzzzzzzzc_ = context.Operators.Union<Encounter>(mzzzzzzzzzzzzzzw_, nzzzzzzzzzzzzzzb_);
        CqlValueSet nzzzzzzzzzzzzzzd_ = this.Psych_Visit_Psychotherapy(context);
        IEnumerable<Encounter> nzzzzzzzzzzzzzze_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, nzzzzzzzzzzzzzzd_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        CqlValueSet nzzzzzzzzzzzzzzf_ = this.Psychoanalysis(context);
        IEnumerable<Encounter> nzzzzzzzzzzzzzzg_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, nzzzzzzzzzzzzzzf_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> nzzzzzzzzzzzzzzh_ = context.Operators.Union<Encounter>(nzzzzzzzzzzzzzze_, nzzzzzzzzzzzzzzg_);
        IEnumerable<Encounter> nzzzzzzzzzzzzzzi_ = context.Operators.Union<Encounter>(nzzzzzzzzzzzzzzc_, nzzzzzzzzzzzzzzh_);
        CqlValueSet nzzzzzzzzzzzzzzj_ = this.Group_Psychotherapy(context);
        IEnumerable<Encounter> nzzzzzzzzzzzzzzk_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, nzzzzzzzzzzzzzzj_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        CqlValueSet nzzzzzzzzzzzzzzl_ = this.Telephone_Visits(context);
        IEnumerable<Encounter> nzzzzzzzzzzzzzzm_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, nzzzzzzzzzzzzzzl_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> nzzzzzzzzzzzzzzn_ = context.Operators.Union<Encounter>(nzzzzzzzzzzzzzzk_, nzzzzzzzzzzzzzzm_);
        IEnumerable<Encounter> nzzzzzzzzzzzzzzo_ = context.Operators.Union<Encounter>(nzzzzzzzzzzzzzzi_, nzzzzzzzzzzzzzzn_);
        bool? nzzzzzzzzzzzzzzp_(Encounter ValidEncounter)
        {
            Code<Encounter.EncounterStatus> nzzzzzzzzzzzzzzr_ = ValidEncounter?.StatusElement;
            Encounter.EncounterStatus? nzzzzzzzzzzzzzzs_ = nzzzzzzzzzzzzzzr_?.Value;
            Code<Encounter.EncounterStatus> nzzzzzzzzzzzzzzt_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(nzzzzzzzzzzzzzzs_);
            bool? nzzzzzzzzzzzzzzu_ = context.Operators.Equal(nzzzzzzzzzzzzzzt_, "finished");
            List<CodeableConcept> nzzzzzzzzzzzzzzv_ = ValidEncounter?.ReasonCode;
            CqlConcept nzzzzzzzzzzzzzzw_(CodeableConcept @this)
            {
                CqlConcept ozzzzzzzzzzzzzzl_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);

                return ozzzzzzzzzzzzzzl_;
            };
            IEnumerable<CqlConcept> nzzzzzzzzzzzzzzx_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)nzzzzzzzzzzzzzzv_, nzzzzzzzzzzzzzzw_);
            CqlValueSet nzzzzzzzzzzzzzzy_ = this.Major_Depressive_Disorder_Active(context);
            bool? nzzzzzzzzzzzzzzz_ = context.Operators.ConceptsInValueSet(nzzzzzzzzzzzzzzx_, nzzzzzzzzzzzzzzy_);
            IEnumerable<Condition> ozzzzzzzzzzzzzza_ = CQMCommon_2_2_000.Instance.encounterDiagnosis(context, ValidEncounter);
            bool? ozzzzzzzzzzzzzzb_(Condition EncounterDiagnosis)
            {
                CodeableConcept ozzzzzzzzzzzzzzm_ = EncounterDiagnosis?.Code;
                CqlConcept ozzzzzzzzzzzzzzn_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, ozzzzzzzzzzzzzzm_);
                CqlValueSet ozzzzzzzzzzzzzzo_ = this.Major_Depressive_Disorder_Active(context);
                bool? ozzzzzzzzzzzzzzp_ = context.Operators.ConceptInValueSet(ozzzzzzzzzzzzzzn_, ozzzzzzzzzzzzzzo_);

                return ozzzzzzzzzzzzzzp_;
            };
            IEnumerable<Condition> ozzzzzzzzzzzzzzc_ = context.Operators.Where<Condition>(ozzzzzzzzzzzzzza_, ozzzzzzzzzzzzzzb_);
            bool? ozzzzzzzzzzzzzzd_ = context.Operators.Exists<Condition>(ozzzzzzzzzzzzzzc_);
            bool? ozzzzzzzzzzzzzze_ = context.Operators.Or(nzzzzzzzzzzzzzzz_, ozzzzzzzzzzzzzzd_);
            bool? ozzzzzzzzzzzzzzf_ = context.Operators.And(nzzzzzzzzzzzzzzu_, ozzzzzzzzzzzzzze_);
            CqlInterval<CqlDateTime> ozzzzzzzzzzzzzzg_ = this.Measurement_Period(context);
            Period ozzzzzzzzzzzzzzh_ = ValidEncounter?.Period;
            CqlInterval<CqlDateTime> ozzzzzzzzzzzzzzi_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ozzzzzzzzzzzzzzh_);
            bool? ozzzzzzzzzzzzzzj_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(ozzzzzzzzzzzzzzg_, ozzzzzzzzzzzzzzi_, "day");
            bool? ozzzzzzzzzzzzzzk_ = context.Operators.And(ozzzzzzzzzzzzzzf_, ozzzzzzzzzzzzzzj_);

            return ozzzzzzzzzzzzzzk_;
        };
        IEnumerable<Encounter> nzzzzzzzzzzzzzzq_ = context.Operators.Where<Encounter>(nzzzzzzzzzzzzzzo_, nzzzzzzzzzzzzzzp_);

        return nzzzzzzzzzzzzzzq_;
    }


    [CqlExpressionDefinition("Initial Population")]
    public IEnumerable<Encounter> Initial_Population(CqlContext context)
    {
        IEnumerable<Encounter> ozzzzzzzzzzzzzzq_ = this.Major_Depressive_Disorder_Encounter(context);
        bool? ozzzzzzzzzzzzzzr_(Encounter MDDEncounter)
        {
            Patient ozzzzzzzzzzzzzzt_ = this.Patient(context);
            Date ozzzzzzzzzzzzzzu_ = ozzzzzzzzzzzzzzt_?.BirthDateElement;
            string ozzzzzzzzzzzzzzv_ = ozzzzzzzzzzzzzzu_?.Value;
            CqlDate ozzzzzzzzzzzzzzw_ = context.Operators.ConvertStringToDate(ozzzzzzzzzzzzzzv_);
            CqlInterval<CqlDateTime> ozzzzzzzzzzzzzzx_ = this.Measurement_Period(context);
            CqlDateTime ozzzzzzzzzzzzzzy_ = context.Operators.Start(ozzzzzzzzzzzzzzx_);
            CqlDate ozzzzzzzzzzzzzzz_ = context.Operators.DateFrom(ozzzzzzzzzzzzzzy_);
            int? pzzzzzzzzzzzzzza_ = context.Operators.CalculateAgeAt(ozzzzzzzzzzzzzzw_, ozzzzzzzzzzzzzzz_, "year");
            bool? pzzzzzzzzzzzzzzb_ = context.Operators.GreaterOrEqual(pzzzzzzzzzzzzzza_, 6);
            Date pzzzzzzzzzzzzzzd_ = ozzzzzzzzzzzzzzt_?.BirthDateElement;
            string pzzzzzzzzzzzzzze_ = pzzzzzzzzzzzzzzd_?.Value;
            CqlDate pzzzzzzzzzzzzzzf_ = context.Operators.ConvertStringToDate(pzzzzzzzzzzzzzze_);
            CqlDateTime pzzzzzzzzzzzzzzh_ = context.Operators.Start(ozzzzzzzzzzzzzzx_);
            CqlDate pzzzzzzzzzzzzzzi_ = context.Operators.DateFrom(pzzzzzzzzzzzzzzh_);
            int? pzzzzzzzzzzzzzzj_ = context.Operators.CalculateAgeAt(pzzzzzzzzzzzzzzf_, pzzzzzzzzzzzzzzi_, "year");
            bool? pzzzzzzzzzzzzzzk_ = context.Operators.LessOrEqual(pzzzzzzzzzzzzzzj_, 16);
            bool? pzzzzzzzzzzzzzzl_ = context.Operators.And(pzzzzzzzzzzzzzzb_, pzzzzzzzzzzzzzzk_);

            return pzzzzzzzzzzzzzzl_;
        };
        IEnumerable<Encounter> ozzzzzzzzzzzzzzs_ = context.Operators.Where<Encounter>(ozzzzzzzzzzzzzzq_, ozzzzzzzzzzzzzzr_);

        return ozzzzzzzzzzzzzzs_;
    }


    [CqlExpressionDefinition("Denominator")]
    public IEnumerable<Encounter> Denominator(CqlContext context)
    {
        IEnumerable<Encounter> pzzzzzzzzzzzzzzm_ = this.Initial_Population(context);

        return pzzzzzzzzzzzzzzm_;
    }


    [CqlExpressionDefinition("Numerator")]
    public IEnumerable<Encounter> Numerator(CqlContext context)
    {
        IEnumerable<Encounter> pzzzzzzzzzzzzzzn_ = this.Major_Depressive_Disorder_Encounter(context);
        IEnumerable<Encounter> pzzzzzzzzzzzzzzo_(Encounter MDDEncounter)
        {
            CqlCode pzzzzzzzzzzzzzzq_ = this.Suicide_risk_assessment__procedure_(context);
            IEnumerable<CqlCode> pzzzzzzzzzzzzzzr_ = context.Operators.ToList<CqlCode>(pzzzzzzzzzzzzzzq_);
            IEnumerable<Procedure> pzzzzzzzzzzzzzzs_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, default, pzzzzzzzzzzzzzzr_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
            bool? pzzzzzzzzzzzzzzt_(Procedure SuicideRiskAssessment)
            {
                Code<EventStatus> pzzzzzzzzzzzzzzx_ = SuicideRiskAssessment?.StatusElement;
                EventStatus? pzzzzzzzzzzzzzzy_ = pzzzzzzzzzzzzzzx_?.Value;
                string pzzzzzzzzzzzzzzz_ = context.Operators.Convert<string>(pzzzzzzzzzzzzzzy_);
                bool? qzzzzzzzzzzzzzza_ = context.Operators.Equal(pzzzzzzzzzzzzzzz_, "completed");
                Period qzzzzzzzzzzzzzzb_ = MDDEncounter?.Period;
                CqlInterval<CqlDateTime> qzzzzzzzzzzzzzzc_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, qzzzzzzzzzzzzzzb_);
                DataType qzzzzzzzzzzzzzzd_ = SuicideRiskAssessment?.Performed;
                object qzzzzzzzzzzzzzze_ = FHIRHelpers_4_4_000.Instance.ToValue(context, qzzzzzzzzzzzzzzd_);
                CqlInterval<CqlDateTime> qzzzzzzzzzzzzzzf_ = QICoreCommon_2_1_000.Instance.toInterval(context, qzzzzzzzzzzzzzze_);
                bool? qzzzzzzzzzzzzzzg_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(qzzzzzzzzzzzzzzc_, qzzzzzzzzzzzzzzf_, default);
                bool? qzzzzzzzzzzzzzzh_ = context.Operators.And(qzzzzzzzzzzzzzza_, qzzzzzzzzzzzzzzg_);

                return qzzzzzzzzzzzzzzh_;
            };
            IEnumerable<Procedure> pzzzzzzzzzzzzzzu_ = context.Operators.Where<Procedure>(pzzzzzzzzzzzzzzs_, pzzzzzzzzzzzzzzt_);
            Encounter pzzzzzzzzzzzzzzv_(Procedure SuicideRiskAssessment) =>
                MDDEncounter;
            IEnumerable<Encounter> pzzzzzzzzzzzzzzw_ = context.Operators.Select<Procedure, Encounter>(pzzzzzzzzzzzzzzu_, pzzzzzzzzzzzzzzv_);

            return pzzzzzzzzzzzzzzw_;
        };
        IEnumerable<Encounter> pzzzzzzzzzzzzzzp_ = context.Operators.SelectMany<Encounter, Encounter>(pzzzzzzzzzzzzzzn_, pzzzzzzzzzzzzzzo_);

        return pzzzzzzzzzzzzzzp_;
    }


    #endregion Expressions

}
